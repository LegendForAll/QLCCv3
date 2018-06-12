Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class PhieuMua_VTDAL
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
        query &= "SELECT TOP 1 [ID_PHIEUMUA_VT] "
        query &= "FROM [PHIEUMUA_VT] "
        query &= "ORDER BY [ID_PHIEUMUA_VT] DESC "

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
                            idOnDB = reader("ID_PHIEUMUA_VT")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của phieu mua canh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieu As PhieuMuaVTDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [PHIEUMUA_VT] ([ID_PHIEUMUA_VT], [NGAYMUAVT])"
        query &= "VALUES (@ID_PHIEUMUA_VT,@NGAYMUAVT)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieu.MS_Phieu = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_VT", phieu.MS_Phieu)
                    .Parameters.AddWithValue("@NGAYMUAVT", phieu.TG_Mua)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phieu mua không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(phieu As PhieuMuaVTDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUMUA_VT] SET"
        query &= " [NGAYMUAVT] = @NGAYMUAVT "
        query &= "WHERE "
        query &= " [ID_PHIEUMUA_VT] = @ID_PHIEUMUA_VT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_VT", phieu.MS_Phieu)
                    .Parameters.AddWithValue("@NGAYMUAVT", phieu.TG_Mua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phieu mua không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listPhieu As List(Of PhieuMuaVTDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_PHIEUMUA_VT], [NGAYMUAVT]"
        query &= " FROM [PHIEUMUA_VT]"


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
                        listPhieu.Clear()
                        While reader.Read()
                            listPhieu.Add(New PhieuMuaVTDTO(reader("ID_PHIEUMUA_VT"), reader("NGAYMUAVT")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phieu mua không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maPhieu As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUMUA_VT] "
        query &= " WHERE "
        query &= " [ID_PHIEUMUA_VT] = @ID_PHIEUMUA_VT "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_PHIEUMUA_VT", maPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phieu mua không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
