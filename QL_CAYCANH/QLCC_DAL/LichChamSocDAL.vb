Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class LichChamSocDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMS_LichCS(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ID_LICHCHAMSOC] "
        query &= "FROM [LICHCHAMSOC] "
        query &= "ORDER BY [ID_LICHCHAMSOC] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("ID_LICHCHAMSOC")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của lich cham soc cay canh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(lich As LichChamSocDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LICHCHAMSOC] ([ID_LICHCHAMSOC], [NGAYLAP])"
        query &= "VALUES (@ID_LICHCHAMSOC,@NGAYLAP)"

        Dim nextID = 0
        Dim result As Result
        result = buildMS_LichCS(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        lich.MS_LichCS = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCHAMSOC", lich.MS_LichCS)
                    .Parameters.AddWithValue("@NGAYLAP", lich.TG_ChamSoc)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm lich cham soc không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lich As LichChamSocDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LICHCHAMSOC] SET"
        query &= " [NGAYLAP] = @NGAYLAP "
        query &= "WHERE "
        query &= " [ID_LICHCHAMSOC] = @ID_LICHCHAMSOC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCHAMSOC", lich.MS_LichCS)
                    .Parameters.AddWithValue("@NGAYLAP", lich.TG_ChamSoc)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật lich cham soc không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listlich As List(Of LichChamSocDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_LICHCHAMSOC], [NGAYLAP]"
        query &= " FROM [LICHCHAMSOC]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listlich.Clear()
                        While reader.Read()
                            listlich.Add(New LichChamSocDTO(reader("ID_LICHCHAMSOC"), reader("NGAYLAP")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lich cham soc không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(malich As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LICHCHAMSOC] "
        query &= " WHERE "
        query &= " [ID_LICHCHAMSOC] = @ID_LICHCHAMSOC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCHAMSOC", malich)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa lich cham soc không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
