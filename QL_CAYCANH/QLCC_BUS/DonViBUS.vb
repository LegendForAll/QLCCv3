Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class DonViBUS
    Private DViDAL As DonViDAL
    Public Sub New()
        DViDAL = New DonViDAL()
    End Sub
    Public Sub New(connectionString As String)
        DViDAL = New DonViDAL(connectionString)
    End Sub
    Public Function isValidName(dvi As DonViDTO) As Boolean

        If (dvi.TenDonVi.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(dvi As DonViDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DViDAL.insert(dvi)
    End Function
    Public Function update(dvi As DonViDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DViDAL.update(dvi)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DViDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listDonVi As List(Of DonViDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DViDAL.selectALL(listDonVi)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return DViDAL.getNextID(nextID)
    End Function
End Class
