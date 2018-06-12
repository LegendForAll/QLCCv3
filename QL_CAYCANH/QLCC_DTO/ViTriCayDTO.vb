Public Class ViTriCayDTO
    Private iMaVT As Integer
    Private strTenVT As String

    Public Sub New()
    End Sub
    Public Sub New(iMaVT As Integer, strTenVT As String)
        Me.iMaVT = iMaVT
        Me.strTenVT = strTenVT
    End Sub
    Property Ma_VT() As Integer
        Get
            Return iMaVT
        End Get
        Set(ByVal Value As Integer)
            iMaVT = Value
        End Set
    End Property
    Property Ten_VT() As String
        Get
            Return strTenVT
        End Get
        Set(ByVal Value As String)
            strTenVT = Value
        End Set
    End Property
End Class
