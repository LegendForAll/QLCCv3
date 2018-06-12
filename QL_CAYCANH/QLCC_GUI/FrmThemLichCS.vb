Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient

Public Class FrmThemLichCS
    Private lichBus As LichChamSocBUS
    Private lichCTBus As LichChamSoc_CTBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")

    Private Sub FrmThemLichCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lichBus = New LichChamSocBUS()

        '' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = lichBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDLich.Text = nextID.ToString()
        'End If
        lichCTBus = New LichChamSoc_CTBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = lichCTBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDLichCT.Text = nextID.ToString()
        End If

        'connect table [CAY]

        Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
        Dim adapter_cay As New SqlDataAdapter(command_cay)
        Dim table_cay As New DataTable()
        adapter_cay.Fill(table_cay)
        cbx_TenCay.DataSource = table_cay
        cbx_TenCay.DisplayMember = "TENCAY"
        cbx_TenCay.ValueMember = "ID_CAY"
        'connect table [CHAMSOCCAY]

        Dim command_CScay As New SqlCommand("SELECT * FROM [LICHCHAMSOC]", connection)
        Dim adapter_CScay As New SqlDataAdapter(command_CScay)
        Dim table_CScay As New DataTable()
        adapter_CScay.Fill(table_CScay)
        cbx_LichCS.DataSource = table_CScay
        cbx_LichCS.DisplayMember = "NGAYLAP"
        cbx_LichCS.ValueMember = "ID_LICHCHAMSOC"
    End Sub

    'Private Sub btn_next1_Click(sender As Object, e As EventArgs)
    '    'lichCTBus = New LichChamSoc_CTBUS()

    '    '' Get Next ID
    '    'Dim nextID As Integer
    '    'Dim result As Result
    '    'result = lichCTBus.getNextID(nextID)
    '    'If (result.FlagResult = True) Then
    '    '    tbx_IDLichCT.Text = nextID.ToString()
    '    'End If

    '    ''connect table [CAY]

    '    'Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
    '    'Dim adapter_cay As New SqlDataAdapter(command_cay)
    '    'Dim table_cay As New DataTable()
    '    'adapter_cay.Fill(table_cay)
    '    'cbx_TenCay.DataSource = table_cay
    '    'cbx_TenCay.DisplayMember = "TENCAY"
    '    'cbx_TenCay.ValueMember = "ID_CAY"

    'End Sub

    'Private Sub btn_Next2_Click(sender As Object, e As EventArgs) Handles btn_Next1.Click
    '    ''connect table [CHAMSOCCAY]

    '    'Dim command_CScay As New SqlCommand("SELECT * FROM [LICHCHAMSOC]", connection)
    '    'Dim adapter_CScay As New SqlDataAdapter(command_CScay)
    '    'Dim table_CScay As New DataTable()
    '    'adapter_CScay.Fill(table_CScay)
    '    'cbx_LichCS.DataSource = table_CScay
    '    'cbx_LichCS.DisplayMember = "TG_CHAMSOC"
    '    'cbx_LichCS.ValueMember = "ID_CHAMSOC"
    'End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click

        Dim lichCSCT As LichChamSoc_CTDTO
        lichCSCT = New LichChamSoc_CTDTO()

        '1. Mapping data from GUI control

        lichCSCT.MS_LichCS = Convert.ToInt32(cbx_LichCS.SelectedValue)
        lichCSCT.MS_LichCSCT = Convert.ToInt32(tbx_IDLichCT.Text)
        lichCSCT.MS_ChamSoc = Convert.ToInt32(cbx_TGchamOfcay.SelectedValue)

        '2. Business .....

        '3. Insert to DB
        Dim result_CT As Result
        result_CT = lichCTBus.insert(lichCSCT)
        If (result_CT.FlagResult = True) Then
            MessageBox.Show("Thêm danh muc cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result_CT = lichCTBus.getNextID(nextID)
            If (result_CT.FlagResult = True) Then
                tbx_IDLichCT.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của danh muc cham cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result_CT.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm danh muc cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result_CT.SystemMessage)
        End If
    End Sub

    Private Sub btn_Next1_Click(sender As Object, e As EventArgs) Handles btn_Next1.Click
        'connect table [CHAMSOCCAY]

        Dim command_CScay As New SqlCommand("SELECT * FROM [CHAMSOC_CAY] 
        WHERE [TG_CHAMSOC] >= '" & cbx_LichCS.Text & "' AND 
        [ID_CAY]= " + Convert.ToString(cbx_TenCay.ValueMember), connection)


        Dim adapter_CScay As New SqlDataAdapter(command_CScay)
        Dim table_CScay As New DataTable()
        adapter_CScay.Fill(table_CScay)
        cbx_TGchamOfcay.DataSource = table_CScay
        cbx_TGchamOfcay.DisplayMember = "TG_CHAMSOC"
        cbx_TGchamOfcay.ValueMember = "ID_CHAMSOC"
        cbx_TenCay.Enabled = False

    End Sub

    Private Sub cbx_LichCS_TextChanged(sender As Object, e As EventArgs) Handles cbx_LichCS.TextChanged
        cbx_TenCay.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As FrmThemLichNew = New FrmThemLichNew()
        frm.Show()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim frm As FrmUpdateLichCS = New FrmUpdateLichCS()
        frm.Show()
    End Sub
End Class