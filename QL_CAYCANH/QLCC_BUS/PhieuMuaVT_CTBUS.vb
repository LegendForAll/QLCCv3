Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class PhieuMuaVT_CTBUS
    Private phieuCTDAL As PhieuMuaVT_CTDAL
    Public Sub New()
        phieuCTDAL = New PhieuMuaVT_CTDAL()
    End Sub
    Public Sub New(connectionString As String)
        phieuCTDAL = New PhieuMuaVT_CTDAL(connectionString)
    End Sub

    Public Function insert(phieuCT As PhieuMuaVT_CTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuCTDAL.insert(phieuCT)
    End Function
    Public Function update(phieuCT As PhieuMuaVT_CTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuCTDAL.update(phieuCT)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuCTDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listPhieuCT As List(Of PhieuMuaVT_CTDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuCTDAL.selectALL(listPhieuCT)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return phieuCTDAL.buildMS_PhieuCT(nextID)
    End Function
End Class
