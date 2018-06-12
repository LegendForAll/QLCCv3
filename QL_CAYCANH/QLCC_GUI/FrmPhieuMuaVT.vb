Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmPhieuMuaVT
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Private phieuBus As PhieuMua_VTBUS
    Private donviBus As DonViBUS
    Private phieuCTBus As PhieuMuaVT_CTBUS

    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub FrmPhieuMuaVT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuBus = New PhieuMua_VTBUS()
        donviBus = New DonViBUS()
        phieuCTBus = New PhieuMuaVT_CTBUS()

        ' Get Next ID phieu mua
        Dim nextID As Integer
        Dim result As Result
        result = phieuBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDPhieu.Text = nextID.ToString()
        End If

        ' Get Next ID phieu mua ct
        Dim nextIDCT As Integer
        result = phieuCTBus.getNextID(nextIDCT)
        If (result.FlagResult = True) Then
            tbx_IDPhieuCT.Text = nextIDCT.ToString()
        End If
        'connect table [VATTU]

        Dim command As New SqlCommand("SELECT * FROM [VATTU]", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cbx_TenVatTu.DataSource = table
        cbx_TenVatTu.DisplayMember = "TEN_VATTU"
        cbx_TenVatTu.ValueMember = "ID_VATTU"

        'Load loai cay list

        Dim listdonvi = New List(Of DonViDTO)
        result = donviBus.selectAll(listdonvi)

        cbx_DonVi.DataSource = New BindingSource(listdonvi, String.Empty)
        cbx_DonVi.DisplayMember = "TenDonVi"
        cbx_DonVi.ValueMember = "MS_DonVi"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbx_DonVi.DataSource)
        myCurrencyManager.Refresh()
        If (listdonvi.Count > 0) Then
            cbx_DonVi.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click
        Dim insertQuery As String = "INSERT INTO [PHIEUMUA_VTCT]
           ([ID_PHIEUMUA_CT]
           ,[ID_PHIEUMUA_VT]
           ,[DIACHIMUA]
           ,[SOLUONGMUA]
           ,[SOTIEN]
           ,[ID_VATTU])
     VALUES
           ('" & tbx_IDPhieuCT.Text & "'
            ,'" & tbx_IDPhieu.Text & "'
           ,'" & tbx_diachi.Text & "'
            ,'" & Convert.ToString(ud_SoluongMua.Value) & "'
           ,'" & tbx_tien.Text & "'
            ,'" & Convert.ToInt32(cbx_TenVatTu.SelectedValue) & "')"
        ExcuteQuery(insertQuery)
        MessageBox.Show("Thêm phieu mua vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Get Next ID phieu mua ct
        phieuCTBus = New PhieuMuaVT_CTBUS()
        Dim result As Result
        Dim nextIDCT As Integer
        result = phieuCTBus.getNextID(nextIDCT)
        If (result.FlagResult = True) Then
            tbx_IDPhieuCT.Text = nextIDCT.ToString()
        End If
    End Sub

    Private Sub btn_next1_Click(sender As Object, e As EventArgs) Handles btn_next1.Click
        Dim insertQuery As String = "INSERT INTO [PHIEUMUA_VT]([ID_PHIEUMUA_VT],[NGAYMUAVT])VALUES('" & tbx_IDPhieu.Text & "','" & dtp_TGMua.Value & "')"
        ExcuteQuery(insertQuery)
        MessageBox.Show("Thêm phieu mua thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbx_IDPhieu.ReadOnly = True
        dtp_TGMua.Enabled = True
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim Frm As FrmUpdatePhieuMuaVT = New FrmUpdatePhieuMuaVT()
        Frm.Show()
    End Sub
End Class