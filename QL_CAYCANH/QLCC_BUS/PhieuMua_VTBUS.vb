Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class PhieuMua_VTBUS
    Private PhieuDAL As PhieuMua_VTDAL
    Public Sub New()
        PhieuDAL = New PhieuMua_VTDAL()
    End Sub
    Public Sub New(connectionString As String)
        PhieuDAL = New PhieuMua_VTDAL(connectionString)
    End Sub

    Public Function insert(phieu As PhieuMuaVTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuDAL.insert(phieu)
    End Function
    Public Function update(phieu As PhieuMuaVTDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuDAL.update(phieu)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listphieu As List(Of PhieuMuaVTDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuDAL.selectALL(listphieu)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return PhieuDAL.getNextID(nextID)
    End Function
End Class
