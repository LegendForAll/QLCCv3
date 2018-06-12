Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class PhieuMuaVT_CTDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMS_PhieuCT(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ID_PHIEUMUA_CT] "
        query &= "FROM [PHIEUMUA_VTCT] "
        query &= "ORDER BY [ID_PHIEUMUA_CT] DESC "

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
                            idOnDB = reader("ID_PHIEUMUA_CT")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp phieu mua chi tiet cay canh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(PhieuCT As PhieuMuaVT_CTDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [PHIEUMUA_VTCT] ([ID_PHIEUMUA_CT], [ID_PHIEUMUA_VT], [DIACHIMUA], [SOLUONGMUA], [SOTIEN], [ID_VATTU])"
        query &= "VALUES (@ID_PHIEUMUA_CT,@ID_PHIEUMUA_VT, @DIACHIMUA, @SOLUONGMUA, @SOTIEN, @ID_VATTU)"

        Dim nextID = 0
        Dim result As Result
        result = buildMS_PhieuCT(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        PhieuCT.MS_CTPhieu = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_CT", PhieuCT.MS_CTPhieu)
                    .Parameters.AddWithValue("@ID_PHIEUMUA_VT", PhieuCT.MS_Phieu)
                    .Parameters.AddWithValue("@DIACHIMUA", PhieuCT.DiaChi)
                    .Parameters.AddWithValue("@SOLUONGMUA", PhieuCT.SoLuongMua)
                    .Parameters.AddWithValue("@SOTIEN", PhieuCT.SoTien)
                    .Parameters.AddWithValue("@ID_VATTU", PhieuCT.MS_VatTu)
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
    Public Function update(PhieuCT As PhieuMuaVT_CTDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUMUA_VTCT] SET"
        query &= " [ID_PHIEUMUA_VT] = @ID_PHIEUMUA_VT "
        query &= " ,[DIACHIMUA] = @DIACHIMUA "
        query &= " ,[SOLUONGMUA] = @SOLUONGMUA "
        query &= " ,[SOTIEN] = @SOTIEN "
        query &= "WHERE "
        query &= " [ID_PHIEUMUA_CT] = @ID_PHIEUMUA_CT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_CT", PhieuCT.MS_CTPhieu)
                    .Parameters.AddWithValue("@ID_PHIEUMUA_VT", PhieuCT.MS_Phieu)
                    .Parameters.AddWithValue("@DIACHIMUA", PhieuCT.DiaChi)
                    .Parameters.AddWithValue("@SOLUONGMUA", PhieuCT.SoLuongMua)
                    .Parameters.AddWithValue("@SOTIEN", PhieuCT.SoTien)
                    .Parameters.AddWithValue("@ID_VATTU", PhieuCT.MS_VatTu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phieu mua vat tu chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listPhieuCT As List(Of PhieuMuaVT_CTDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_PHIEUMUA_CT], [ID_PHIEUMUA_VT], [DIACHIMUA], [SOLUONGMUA], [SOTIEN], [ID_VATTU]"
        query &= " FROM [PHIEUMUA_VTCT]"


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
                        listPhieuCT.Clear()
                        While reader.Read()
                            listPhieuCT.Add(New PhieuMuaVT_CTDTO(reader("ID_PHIEUMUA_CT"), reader("ID_PHIEUMUA_VT"), reader("DIACHIMUA"), reader("SOLUONGMUA"), reader("SOTIEN"), reader("ID_VATTU")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phieu mua vat tu chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maPhieuCT As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUMUA_VTCT] "
        query &= " WHERE "
        query &= " [ID_PHIEUMUA_CT] = @ID_PHIEUMUA_CT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_CT", maPhieuCT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phieu mua vat tu chi tiet không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
