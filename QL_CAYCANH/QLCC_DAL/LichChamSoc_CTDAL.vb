Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class LichChamSoc_CTDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMS_LichCT(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ID_LICHCT] "
        query &= "FROM [LICHCT] "
        query &= "ORDER BY [ID_LICHCT] DESC "

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
                            idOnDB = reader("ID_LICHCT")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của lich cham soc chi tiet cay canh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(lichCT As LichChamSoc_CTDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LICHCT] ([ID_LICHCT], [ID_LICHCHAMSOC], [ID_CHAMSOC])"
        query &= "VALUES (@ID_LICHCT,@ID_LICHCHAMSOC, @ID_CHAMSOC)"

        Dim nextID = 0
        Dim result As Result
        result = buildMS_LichCT(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        lichCT.MS_LichCSCT = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCT", lichCT.MS_LichCSCT)
                    .Parameters.AddWithValue("@ID_LICHCHAMSOC", lichCT.MS_LichCS)
                    .Parameters.AddWithValue("@ID_CHAMSOC", lichCT.MS_ChamSoc)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm lich cham soc chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lichCT As LichChamSoc_CTDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LICHCT] SET"
        query &= " [ID_LICHCHAMSOC] = @ID_LICHCHAMSOC "
        query &= " ,[ID_CHAMSOC] = @ID_CHAMSOC "
        query &= "WHERE "
        query &= " [ID_LICHCT] = @ID_LICHCT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCT", lichCT.MS_LichCSCT)
                    .Parameters.AddWithValue("@ID_LICHCHAMSOC", lichCT.MS_LichCS)
                    .Parameters.AddWithValue("@ID_CHAMSOC", lichCT.MS_ChamSoc)
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
    Public Function selectALL(ByRef listlichCT As List(Of LichChamSoc_CTDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_LICHCT], [ID_LICHCHAMSOC], [ID_CHAMSOC]"
        query &= " FROM [LICHCT]"


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
                        listlichCT.Clear()
                        While reader.Read()
                            listlichCT.Add(New LichChamSoc_CTDTO(reader("ID_LICHCT"), reader("ID_LICHCHAMSOC"), reader("ID_CHAMSOC")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lich cham soc chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(malich As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LICHCT] "
        query &= " WHERE "
        query &= " [ID_LICHCT] = @ID_LICHCT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LICHCT", malich)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa lich cham soc chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
