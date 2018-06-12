Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility

Public Class FrmThemCay
    Private cayBus As CayBUS
    Private loaiCayBus As LoaiCayBUS
    Private vitri As ViTriCayBUS

    Private Sub FrmThemCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CayBUS = New CayBUS()
        LoaiCayBUS = New LoaiCayBUS()
        vitri = New ViTriCayBUS()

        ' Load loai cay list
        Dim listLoaiCay = New List(Of LoaiCayDTO)
        Dim result As Result
        result = LoaiCayBUS.selectAll(listLoaiCay)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lay danh sach loai cay khong thanh cong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbx_LoaiCay.DataSource = New BindingSource(listLoaiCay, String.Empty)
        cbx_LoaiCay.DisplayMember = "TenLoai_Cay"
        cbx_LoaiCay.ValueMember = "MS_LoaiCay"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbx_LoaiCay.DataSource)
        myCurrencyManager.Refresh()
        If (listLoaiCay.Count > 0) Then
            cbx_LoaiCay.SelectedIndex = 0
        End If

        ' Load vi tri list
        Dim listViTri = New List(Of ViTriCayDTO)
        result = vitri.selectAll(listViTri)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lay danh vi tri cay khong thanh cong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbx_ViTri.DataSource = New BindingSource(listViTri, String.Empty)
        cbx_ViTri.DisplayMember = "Ten_VT"
        cbx_ViTri.ValueMember = "Ma_VT"
        myCurrencyManager = Me.BindingContext(cbx_ViTri.DataSource)
        myCurrencyManager.Refresh()
        If (listViTri.Count > 0) Then
            cbx_ViTri.SelectedIndex = 0
        End If

        'set MSSH auto
        Dim nextMshs = "1"
        result = CayBUS.buildMS_Cay(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Get the autocomplete code tree failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbx_IDCay.Text = nextMshs
    End Sub

    Private Sub btn_ThemCay_Click(sender As Object, e As EventArgs) Handles btn_ThemCay.Click
        Dim Cay As CayDTO
        Cay = New CayDTO()

        '1. Mapping data from GUI control
        Cay.MS_Cay = tbx_IDCay.Text
        Cay.TenCay = tbx_TenCay.Text
        Cay.MS_LoaiCay = Convert.ToInt32(cbx_LoaiCay.SelectedValue)
        Cay.ViTriCay = Convert.ToInt32(cbx_ViTri.SelectedValue)
        Cay.NgayTrong = dtp_NgayTrong.Value

        '2. Business .....
        If (cayBus.isValidName(Cay) = False) Then
            MessageBox.Show("Tree name is not correct")
            tbx_TenCay.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = cayBus.insert(Cay)
        If (result.FlagResult = True) Then
            MessageBox.Show("Add tree Success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = cayBus.buildMS_Cay(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Get the autocomplete code tree failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            tbx_IDCay.Text = nextMshs
            tbx_TenCay.Text = String.Empty

        Else
            MessageBox.Show("Add tree unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class