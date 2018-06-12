Public Class BCChiPhiDTO
    Private strMaBC_ChiPhi As Integer
    Private dateTG_BC As DateTime

    Public Sub New()

    End Sub
    Public Sub New(strMaBC_ChiPhi As Integer, dateTG_BC As DateTime)
        Me.strMaBC_ChiPhi = strMaBC_ChiPhi
        Me.dateTG_BC = dateTG_BC
    End Sub
    Property MS_BCChiPhi() As Integer
        Get
            Return strMaBC_ChiPhi
        End Get
        Set(ByVal Value As Integer)
            strMaBC_ChiPhi = Value
        End Set
    End Property
    Property TG_BaoCao() As DateTime
        Get
            Return dateTG_BC
        End Get
        Set(ByVal Value As DateTime)
            dateTG_BC = Value
        End Set
    End Property
End Class
