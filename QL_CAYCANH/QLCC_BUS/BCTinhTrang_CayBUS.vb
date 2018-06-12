Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class BCTinhTrang_CayBUS
    Private BaoCaoDAL As BCTinhTrang_CayDAL
    Public Sub New()
        BaoCaoDAL = New BCTinhTrang_CayDAL()
    End Sub
    Public Sub New(connectionString As String)
        BaoCaoDAL = New BCTinhTrang_CayDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return BaoCaoDAL.getNextID(nextID)
    End Function
End Class
