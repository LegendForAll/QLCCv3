Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class BCChiPhiBUS
    Private baocaoDAL As BCChiPhiDALvb
    Public Sub New()
        baocaoDAL = New BCChiPhiDALvb()
    End Sub
    Public Sub New(connectionString As String)
        baocaoDAL = New BCChiPhiDALvb(connectionString)
    End Sub

    Public Function insert(baocao As BCChiPhiDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return baocaoDAL.insert(baocao)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return baocaoDAL.getNextID(nextID)
    End Function
End Class
