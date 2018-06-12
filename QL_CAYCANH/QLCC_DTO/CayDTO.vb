Public Class CayDTO
    Private strMSCay As String
    Private iMaLC As Integer
    Private iMaVT As Integer
    Private strTenCay As String
    Private dateNgayTrong As DateTime

    Public Sub New()
    End Sub
    Public Sub New(strMSCay As String, iMaLC As Integer, iMaVT As Integer, strTenCay As String, dateNgayTrong As DateTime)
        Me.strMSCay = strMSCay
        Me.iMaLC = iMaLC
        Me.iMaVT = iMaVT
        Me.strTenCay = strTenCay
        Me.dateNgayTrong = dateNgayTrong
    End Sub
    Property MS_Cay() As String
        Get
            Return strMSCay
        End Get
        Set(ByVal Value As String)
            strMSCay = Value
        End Set
    End Property
    Property MS_LoaiCay() As Integer
        Get
            Return iMaLC
        End Get
        Set(ByVal Value As Integer)
            iMaLC = Value
        End Set
    End Property
    Property ViTriCay() As Integer
        Get
            Return iMaVT
        End Get
        Set(ByVal Value As Integer)
            iMaVT = Value
        End Set
    End Property
    Property TenCay() As String
        Get
            Return strTenCay
        End Get
        Set(ByVal Value As String)
            strTenCay = Value
        End Set
    End Property
    Property NgayTrong() As DateTime
        Get
            Return dateNgayTrong
        End Get
        Set(ByVal Value As DateTime)
            dateNgayTrong = Value
        End Set
    End Property
End Class
