Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class BCCT_TinhTrangCayBUS
    Private BaoCaoDAL As BCCT_TinhTrangCayDAL
    Public Sub New()
        BaoCaoDAL = New BCCT_TinhTrangCayDAL()
    End Sub
    Public Sub New(connectionString As String)
        BaoCaoDAL = New BCCT_TinhTrangCayDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return BaoCaoDAL.getNextID(nextID)
    End Function
End Class
