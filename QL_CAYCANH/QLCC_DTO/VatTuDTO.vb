Public Class VatTuDTO
    Private iMaVatTu As Integer
    Private strTenVatTu As String
    Private iMaDonVi As Integer
    Public Sub New()
    End Sub
    Public Sub New(iMaVatTu As Integer, strTenVatTu As String, iMaDonVi As Integer)
        Me.iMaVatTu = iMaVatTu
        Me.strTenVatTu = strTenVatTu
        Me.iMaDonVi = iMaDonVi
    End Sub
    Property MS_VatTu() As Integer
        Get
            Return iMaVatTu
        End Get
        Set(ByVal Value As Integer)
            iMaVatTu = Value
        End Set
    End Property
    Property Ten_VatTu() As String
        Get
            Return strTenVatTu
        End Get
        Set(ByVal Value As String)
            strTenVatTu = Value
        End Set
    End Property
    Property MS_DonVi() As Integer
        Get
            Return iMaDonVi
        End Get
        Set(ByVal Value As Integer)
            iMaDonVi = Value
        End Set
    End Property
End Class
