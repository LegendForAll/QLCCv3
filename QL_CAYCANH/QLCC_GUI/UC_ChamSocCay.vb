Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class UC_ChamSocCay
    Private chamsocBus As ChamSoc_CayBUS
    Private vattuBus As VaTuBUS
    Private donviBus As DonViBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim index As Integer
    Dim table As New DataTable("Table")

    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU
        FROM [CHAMSOC_CAY] CS,  [VATTU] V, [CAY] C
        WHERE CS.ID_CAY=C.ID_CAY AND CS.ID_VATTU=V.ID_VATTU
        AND CONCAT (CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU) LIKE'%" & tbx_search.Text & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub


    Private Sub UC_ChamSocCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chamsocBus = New ChamSoc_CayBUS()
        vattuBus = New VaTuBUS()
        donviBus = New DonViBUS()

        FiterData("")
        '' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = chamsocBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDChamSoc.Text = nextID.ToString()
        'End If

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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (Index >= 0) Then
            SelectRow = DataGridView1.Rows(Index)
            tbx_IDChamSoc.Text = SelectRow.Cells(0).Value.ToString()
            dtp_TGCham.Value = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())
            cbx_TenCay.Text = SelectRow.Cells(2).Value.ToString()
            cbx_vattu.Text = SelectRow.Cells(3).Value.ToString()
            cbx_tinhtrang.Text = SelectRow.Cells(4).Value.ToString()
            cbx_GhiChu.Text = SelectRow.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [CHAMSOC_CAY] WHERE [ID_CHAMSOC] = '" & tbx_IDChamSoc.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Xoa vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [CHAMSOC_CAY]
            SET [ID_CHAMSOC] = '" & tbx_IDChamSoc.Text & "'
            ,[TG_CHAMSOC] = '" & Convert.ToString(dtp_TGCham.Value) & "'
            ,[ID_VATTU] = '" & Convert.ToString(cbx_vattu.SelectedValue) & "'
            ,[ID_CAY] = '" & Convert.ToString(cbx_TenCay.SelectedValue) & "'
            ,[SL_CHAMSOC] = '" & Convert.ToString(Ud_soluongCS.Value) & "'
            ,[TT_CAY] = '" & cbx_tinhtrang.Text & "'
            ,[GHICHU] = '" & cbx_GhiChu.Text & "'
            WHERE [ID_CHAMSOC] = '" & tbx_IDChamSoc.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update danh muc cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub
End Class
