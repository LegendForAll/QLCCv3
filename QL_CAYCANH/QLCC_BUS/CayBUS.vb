Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class CayBUS
    Private CayDAL As CayDAL
    Public Sub New()
        CayDAL = New CayDAL()
    End Sub
    Public Sub New(connectionString As String)
        CayDAL = New CayDAL(connectionString)
    End Sub
    Public Function isValidName(cay As CayDTO) As Boolean

        If (cay.TenCay.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(cay As CayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return CayDAL.insert(cay)
    End Function
    Public Function update(cay As CayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return CayDAL.update(cay)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return CayDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listCay As List(Of CayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return CayDAL.selectALL(listCay)
    End Function
    Public Function selectALL_ByMaChamSoc(iMaCS As Integer, ByRef listCay As List(Of CayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return selectALL_ByMaChamSoc(iMaCS, listCay)
    End Function
    Public Function selectALL_ByType(maLoaiCay As Integer, ByRef listCay As List(Of CayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return CayDAL.selectALL_ByType(maLoaiCay, listCay)
    End Function
    Public Function buildMS_Cay(ByRef nextMsCay As String) As Result
        Return CayDAL.buildMS_Cay(nextMsCay)
    End Function
End Class
