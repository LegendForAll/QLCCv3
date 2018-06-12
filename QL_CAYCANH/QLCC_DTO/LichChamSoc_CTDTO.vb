Public Class LichChamSoc_CTDTO
    Private iMaLichCS_CT As Integer
    Private iMaLich_CS As Integer
    Private iMaCS As Integer

    Public Sub New()

    End Sub
    Public Sub New(iMaLichCS_CT As Integer, iMaLich_CS As Integer, iMaCS As Integer)
        Me.iMaLichCS_CT = iMaLichCS_CT
        Me.iMaLich_CS = iMaLich_CS
        Me.iMaCS = iMaCS
    End Sub
    Property MS_LichCSCT() As Integer
        Get
            Return iMaLichCS_CT
        End Get
        Set(ByVal Value As Integer)
            iMaLichCS_CT = Value
        End Set
    End Property
    Property MS_LichCS() As Integer
        Get
            Return iMaLich_CS
        End Get
        Set(ByVal Value As Integer)
            iMaLich_CS = Value
        End Set
    End Property
    Property MS_ChamSoc() As Integer
        Get
            Return iMaCS
        End Get
        Set(ByVal Value As Integer)
            iMaCS = Value
        End Set
    End Property
End Class
