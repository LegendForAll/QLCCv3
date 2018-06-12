Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class VatTuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ID_VATTU] "
        query &= "FROM [VATTU] "
        query &= "ORDER BY [ID_VATTU] DESC "

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
                            idOnDB = reader("ID_VATTU")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của vat tu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(vatt As VatTuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [VATTU] ([ID_VATTU], [TEN_VATTU], [ID_DONVI])"
        query &= "VALUES (@ID_VATTU,@TEN_VATTU,@ID_DONVI)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        vatt.MS_VatTu = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_VATTU", vatt.MS_VatTu)
                    .Parameters.AddWithValue("@TEN_VATTU", vatt.Ten_VatTu)
                    .Parameters.AddWithValue("@ID_DONVI", vatt.MS_DonVi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm vat tu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(vatt As VatTuDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [VATTU] SET"
        query &= " [TEN_VATTU] = @TEN_VATTU "
        query &= " ,[ID_DONVI] = @ID_DONVI "
        query &= "WHERE "
        query &= " [ID_VATTU] = @ID_VATTU "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_VATTU", vatt.MS_VatTu)
                    .Parameters.AddWithValue("@TEN_VATTU", vatt.Ten_VatTu)
                    .Parameters.AddWithValue("@ID_DONVI", vatt.MS_DonVi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật vat tu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listVatTu As List(Of VatTuDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_VATTU], [TEN_VATTU], [ID_DONVI]"
        query &= " FROM [VATTU]"


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
                        listVatTu.Clear()
                        While reader.Read()
                            listVatTu.Add(New VatTuDTO(reader("ID_DONVI"), reader("TEN_DONVI"), reader("TEN_DONVI")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả vat tu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(mvitri As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [VATTU] "
        query &= " WHERE "
        query &= " [ID_VATTU] = @ID_VATTU "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_VATTU", mvitri)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa vat tu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
