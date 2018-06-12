Public Class BCCT_ChiPhiDTO
    '[ID_BCCT_CHIPHI] [nchar](10) Not NULL,
    '[ID_BCCHIPHI] [nchar](10) Not NULL,
    '[ID_VATTU] [int] Not NULL,
    '[SOPHIEUMUA] [int] Not NULL,
    '[TONG_GT] [money] Not NULL,
    '[TYLE] [float] Not NULL,
    Private strMaBCCT_ChiPhi As Integer
    Private strMaBC_ChiPhi As Integer
    Private iMaVatTu As Integer
    Private iSoLuong_Mua As Integer
    Private dTongTriGia As Double
    Private dTyLe As Double

    Public Sub New()

    End Sub
    Public Sub New(strMaBCCT_ChiPhi As Integer, strMaBC_ChiPhi As Integer, iMaVatTu As Integer, iSoLuong_Mua As Integer, dTongTriGia As Double, dTyLe As Double)
        Me.strMaBCCT_ChiPhi = strMaBCCT_ChiPhi
        Me.strMaBC_ChiPhi = strMaBC_ChiPhi
        Me.iMaVatTu = iMaVatTu
        Me.iSoLuong_Mua = iSoLuong_Mua
        Me.dTongTriGia = dTongTriGia
        Me.dTyLe = dTyLe
    End Sub
    Property MS_BCCTChiPhi() As Integer
        Get
            Return strMaBCCT_ChiPhi
        End Get
        Set(ByVal Value As Integer)
            strMaBCCT_ChiPhi = Value
        End Set
    End Property
    Property MS_BCChiPhi() As Integer
        Get
            Return strMaBC_ChiPhi
        End Get
        Set(ByVal Value As Integer)
            strMaBC_ChiPhi = Value
        End Set
    End Property
    Property MS_VatTu() As Integer
        Get
            Return iMaVatTu
        End Get
        Set(ByVal Value As Integer)
            iMaVatTu = Value
        End Set
    End Property
    Property SoLuongMua() As Integer
        Get
            Return iSoLuong_Mua
        End Get
        Set(ByVal Value As Integer)
            iSoLuong_Mua = Value
        End Set
    End Property
    Property TrongTriGia() As Double
        Get
            Return dTongTriGia
        End Get
        Set(ByVal Value As Double)
            dTongTriGia = Value
        End Set
    End Property
    Property TyLe() As Double
        Get
            Return dTyLe
        End Get
        Set(ByVal Value As Double)
            dTyLe = Value
        End Set
    End Property
End Class
