Public Class LichChamSocDTO
    Private iMaLich_CS As Integer
    Private dateNgayLap As DateTime

    Public Sub New()

    End Sub
    Public Sub New(iMaLich_CS As Integer, dateNgayLap As DateTime)
        Me.iMaLich_CS = iMaLich_CS
        Me.dateNgayLap = dateNgayLap
    End Sub
    Property MS_LichCS() As Integer
        Get
            Return iMaLich_CS
        End Get
        Set(ByVal Value As Integer)
            iMaLich_CS = Value
        End Set
    End Property
    Property TG_ChamSoc() As DateTime
        Get
            Return dateNgayLap
        End Get
        Set(ByVal Value As DateTime)
            dateNgayLap = Value
        End Set
    End Property
End Class
