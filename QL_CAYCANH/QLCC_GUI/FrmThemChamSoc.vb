Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient

Public Class FrmThemChamSoc
    Private chamsocBus As ChamSoc_CayBUS
    Private vattuBus As VaTuBUS
    Private donviBus As DonViBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")

    Private Sub btn_ThemCS_Click(sender As Object, e As EventArgs) Handles btn_ThemCS.Click
        Dim chamsoc As ChamSoc_CayDTO
        chamsoc = New ChamSoc_CayDTO()

        '1. Mapping data from GUI control
        chamsoc.MS_ChamSoc = Convert.ToInt32(tbx_IDChamSoc.Text)
        chamsoc.MS_VatTu = Convert.ToInt32(cbx_vattu.SelectedValue)
        chamsoc.MS_Cay = Convert.ToString(cbx_TenCay.SelectedValue)
        chamsoc.TinhTrang_Cay = cbx_tinhtrang.Text
        chamsoc.GhiChu_Cay = cbx_GhiChu.Text
        chamsoc.TG_ChamSoc = dtp_TGCham.Value
        chamsoc.SoLuong_CS = Convert.ToInt32(Ud_soluongCS.Value)
        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = chamsocBus.insert(chamsoc)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ' Get Next ID
            Dim nextID As Integer
            result = chamsocBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDChamSoc.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của cham cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm cham soc cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub FrmThemChamSoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chamsocBus = New ChamSoc_CayBUS()
        vattuBus = New VaTuBUS()
        DonViBUS = New DonViBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = chamsocBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDChamSoc.Text = nextID.ToString()
        End If

        'connect table [VATTU]

        Dim command As New SqlCommand("SELECT * FROM [VATTU]", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cbx_vattu.DataSource = table
        cbx_vattu.DisplayMember = "TEN_VATTU"
        cbx_vattu.ValueMember = "ID_VATTU"

        'connect table [CAY]

        Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
        Dim adapter_cay As New SqlDataAdapter(command_cay)
        Dim table_cay As New DataTable()
        adapter_cay.Fill(table_cay)
        cbx_TenCay.DataSource = table_cay
        cbx_TenCay.DisplayMember = "TENCAY"
        cbx_TenCay.ValueMember = "ID_CAY"
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class