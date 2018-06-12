Public Class BCTinhTrang_CayDTO
    Private strMaBC_TinhTrang As Integer
    Private dateTG_BC As DateTime

    Public Sub New()

    End Sub
    Public Sub New(strMaBC_TinhTrang As Integer, dateTG_BC As DateTime)
        Me.strMaBC_TinhTrang = strMaBC_TinhTrang
        Me.dateTG_BC = dateTG_BC
    End Sub
    Property MS_BCTinhTrang() As Integer
        Get
            Return strMaBC_TinhTrang
        End Get
        Set(ByVal Value As Integer)
            strMaBC_TinhTrang = Value
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
