Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class LoaiCayBUS
    Private lCayDAL As LoaiCayDAL
    Public Sub New()
        lCayDAL = New LoaiCayDAL()
    End Sub
    Public Sub New(connectionString As String)
        lCayDAL = New LoaiCayDAL(connectionString)
    End Sub
    Public Function isValidName(lCay As LoaiCayDTO) As Boolean

        If (lCay.TenLoai_Cay.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(lCay As LoaiCayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lCayDAL.insert(lCay)
    End Function
    Public Function update(lCay As LoaiCayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lCayDAL.update(lCay)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lCayDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiCay As List(Of LoaiCayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lCayDAL.selectALL(listLoaiCay)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lCayDAL.getNextID(nextID)
    End Function
End Class
