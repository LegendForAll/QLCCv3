Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class LichChamSoc_CTBUS
    Private lichCTDAL As LichChamSoc_CTDAL
    Public Sub New()
        lichCTDAL = New LichChamSoc_CTDAL()
    End Sub
    Public Sub New(connectionString As String)
        lichCTDAL = New LichChamSoc_CTDAL(connectionString)
    End Sub

    Public Function insert(lichCT As LichChamSoc_CTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichCTDAL.insert(lichCT)
    End Function
    Public Function update(lichCT As LichChamSoc_CTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichCTDAL.update(lichCT)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichCTDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listlichCT As List(Of LichChamSoc_CTDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lichCTDAL.selectALL(listlichCT)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lichCTDAL.buildMS_LichCT(nextID)
    End Function
End Class
