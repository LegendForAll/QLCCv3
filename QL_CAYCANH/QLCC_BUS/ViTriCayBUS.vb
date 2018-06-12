Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class ViTriCayBUS
    Private viTriDAL As ViTriCayDAL
    Public Sub New()
        viTriDAL = New ViTriCayDAL()
    End Sub
    Public Sub New(connectionString As String)
        viTriDAL = New ViTriCayDAL(connectionString)
    End Sub
    Public Function isValidName(ViTri As ViTriCayDTO) As Boolean

        If (ViTri.Ten_VT.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(ViTri As ViTriCayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return viTriDAL.insert(ViTri)
    End Function
    Public Function update(ViTri As ViTriCayDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return viTriDAL.update(ViTri)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return viTriDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listViTri As List(Of ViTriCayDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return viTriDAL.selectALL(listViTri)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return viTriDAL.getNextID(nextID)
    End Function
End Class
