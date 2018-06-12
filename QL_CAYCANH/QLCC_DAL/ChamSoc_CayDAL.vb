Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class ChamSoc_CayDAL
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
        query &= "SELECT TOP 1 [ID_CHAMSOC] "
        query &= "FROM [CHAMSOC_CAY] "
        query &= "ORDER BY [ID_CHAMSOC] DESC "

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
                            idOnDB = reader("ID_CHAMSOC")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của cham soc cay canh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(lChamSoc As ChamSoc_CayDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [CHAMSOC_CAY] ([ID_CHAMSOC], [TG_CHAMSOC], [ID_VATTU], [ID_CAY], [SL_CHAMSOC], [TT_CAY], [GHICHU])"
        query &= "VALUES (@ID_CHAMSOC,@TG_CHAMSOC,@ID_VATTU,@ID_CAY,@SL_CHAMSOC,@TT_CAY,@GHICHU)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        lChamSoc.MS_ChamSoc = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_CHAMSOC", lChamSoc.MS_ChamSoc)
                    .Parameters.AddWithValue("@TG_CHAMSOC", lChamSoc.TG_ChamSoc)
                    .Parameters.AddWithValue("@ID_VATTU", lChamSoc.MS_VatTu)
                    .Parameters.AddWithValue("@ID_CAY", lChamSoc.MS_Cay)
                    .Parameters.AddWithValue("@SL_CHAMSOC", lChamSoc.SoLuong_CS)
                    .Parameters.AddWithValue("@TT_CAY", lChamSoc.TinhTrang_Cay)
                    .Parameters.AddWithValue("@GHICHU", lChamSoc.GhiChu_Cay)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm cham soc cay không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lChamSoc As ChamSoc_CayDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [CHAMSOC_CAY] SET"
        query &= " [TG_CHAMSOC] = @TG_CHAMSOC "
        query &= " ,[ID_VATTU] = @ID_VATTU "
        query &= " ,[ID_CAY] = @ID_CAY "
        query &= " ,[SL_CHAMSOC] = @SL_CHAMSOC "
        query &= " ,[TT_CAY] = @TT_CAY "
        query &= " ,[GHICHU] = @GHICHU "
        query &= "WHERE "
        query &= " [ID_CHAMSOC] = @ID_CHAMSOC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_CHAMSOC", lChamSoc.MS_ChamSoc)
                    .Parameters.AddWithValue("@TG_CHAMSOC", lChamSoc.TG_ChamSoc)
                    .Parameters.AddWithValue("@ID_VATTU", lChamSoc.MS_VatTu)
                    .Parameters.AddWithValue("@ID_CAY", lChamSoc.MS_Cay)
                    .Parameters.AddWithValue("@SL_CHAMSOC", lChamSoc.SoLuong_CS)
                    .Parameters.AddWithValue("@TT_CAY", lChamSoc.TinhTrang_Cay)
                    .Parameters.AddWithValue("@GHICHU", lChamSoc.GhiChu_Cay)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật cham soc sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listChamSoc As List(Of ChamSoc_CayDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_CHAMSOC], [TG_CHAMSOC], [ID_VATTU], [ID_CAY], [SL_CHAMSOC], [TT_CAY], [GHICHU]"
        query &= " FROM [CHAMSOC_CAY]"


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
                        listChamSoc.Clear()
                        While reader.Read()
                            listChamSoc.Add(New ChamSoc_CayDTO(reader("ID_CHAMSOC"), reader("TG_CHAMSOC"), reader("ID_VATTU"), reader("ID_CAY"), reader("SL_CHAMSOC"), reader("TT_CAY"), reader("GHICHU")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả cham soc cay không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(mvChamSoc As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHAMSOC_CAY] "
        query &= " WHERE "
        query &= " [ID_CHAMSOC] = @ID_CHAMSOC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_CHAMSOC", mvChamSoc)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa cham soc cay không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
