Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class ChamSoc_CayBUS
    Private chamsocDAL As ChamSoc_CayDAL
    Public Sub New()
        chamsocDAL = New ChamSoc_CayDAL()
    End Sub
    Public Sub New(connectionString As String)
        chamsocDAL = New ChamSoc_CayDAL(connectionString)
    End Sub

    Public Function insert(chamsoc As ChamSoc_CayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return chamsocDAL.insert(chamsoc)
    End Function
    Public Function update(chamsoc As ChamSoc_CayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return chamsocDAL.update(chamsoc)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return chamsocDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listChamSoc As List(Of ChamSoc_CayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return chamsocDAL.selectALL(listChamSoc)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return chamsocDAL.getNextID(nextID)
    End Function
End Class
