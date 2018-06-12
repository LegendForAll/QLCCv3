Public Class BCCT_TinhTrangCayDTO
    '[ID_BCCT_TINHTRANGCAY] [nchar](10) Not NULL,
    '[ID_BCTT_CAY] [nchar](10) Not NULL,
    '[ID_CAY] [nchar](10) Not NULL,
    Private strMaBCCT_TinhTrang As Integer
    Private strMaBC_TinhTrang As Integer
    Private strMSCay As String

    Public Sub New()

    End Sub
    Public Sub New(strMaBCCT_TinhTrang As Integer, strMaBC_TinhTrang As Integer, strMSCay As String)
        Me.strMaBCCT_TinhTrang = strMaBCCT_TinhTrang
        Me.strMaBC_TinhTrang = strMaBC_TinhTrang
        Me.strMSCay = strMSCay
    End Sub
    Property MS_BCCTTinhTrang() As Integer
        Get
            Return strMaBCCT_TinhTrang
        End Get
        Set(ByVal Value As Integer)
            strMaBCCT_TinhTrang = Value
        End Set
    End Property
    Property MS_BCTinhTrang() As Integer
        Get
            Return strMaBC_TinhTrang
        End Get
        Set(ByVal Value As Integer)
            strMaBC_TinhTrang = Value
        End Set
    End Property
    Property MS_Cay() As String
        Get
            Return strMSCay
        End Get
        Set(ByVal Value As String)
            strMSCay = Value
        End Set
    End Property
End Class
