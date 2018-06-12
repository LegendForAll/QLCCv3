Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class VaTuBUS
    Private vatuDAL As VatTuDAL
    Public Sub New()
        vatuDAL = New VatTuDAL()
    End Sub
    Public Sub New(connectionString As String)
        vatuDAL = New VatTuDAL(connectionString)
    End Sub
    Public Function isValidName(vatt As VatTuDTO) As Boolean

        If (vatt.Ten_VatTu.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(vatt As VatTuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vatuDAL.insert(vatt)
    End Function
    Public Function update(vatt As VatTuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vatuDAL.update(vatt)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vatuDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listVatTu As List(Of VatTuDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vatuDAL.selectALL(listVatTu)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return vatuDAL.getNextID(nextID)
    End Function
End Class
