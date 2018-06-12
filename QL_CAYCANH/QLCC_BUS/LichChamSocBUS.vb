Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class LichChamSocBUS
    Private lichDAL As LichChamSocDAL
    Public Sub New()
        lichDAL = New LichChamSocDAL()
    End Sub
    Public Sub New(connectionString As String)
        lichDAL = New LichChamSocDAL(connectionString)
    End Sub

    Public Function insert(lich As LichChamSocDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichDAL.insert(lich)
    End Function
    Public Function update(lich As LichChamSocDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichDAL.update(lich)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listlich As List(Of LichChamSocDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichDAL.selectALL(listlich)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lichDAL.buildMS_LichCS(nextID)
    End Function
End Class
