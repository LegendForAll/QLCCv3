Public Class DonViDTO
    Private iMaDonVi As Integer
    Private strTenDonVi As String

    Public Sub New()

    End Sub
    Public Sub New(iMaDonVi As Integer, strTenDonVi As String)
        Me.iMaDonVi = iMaDonVi
        Me.strTenDonVi = strTenDonVi
    End Sub
    Property MS_DonVi() As Integer
        Get
            Return iMaDonVi
        End Get
        Set(ByVal Value As Integer)
            iMaDonVi = Value
        End Set
    End Property
    Property TenDonVi() As String
        Get
            Return strTenDonVi
        End Get
        Set(ByVal Value As String)
            strTenDonVi = Value
        End Set
    End Property
End Class
