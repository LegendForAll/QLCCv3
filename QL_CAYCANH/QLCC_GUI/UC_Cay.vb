Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class UC_Cay
    Private cayBus As CayBUS
    Private loaiCayBus As LoaiCayBUS
    Private vitri As ViTriCayBUS

    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT P.ID_CAY,P.TENCAY,L.TEN_LOAICAY,VT.TEN_VITRI,P.NGAYTRONG FROM [CAY] P,[VITRI] VT,[LOAICAY] L WHERE P.ID_VITRI = VT.ID_VITRI AND P.ID_LOAICAY=L.ID_LOAICAY
        AND CONCAT(P.ID_CAY, P.TENCAY, L.TEN_LOAICAY, VT.TEN_VITRI, P.NGAYTRONG) Like'%" & tbx_search.Text & "%'"

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

    Private Sub UC_Cay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cayBus = New CayBUS()
        loaiCayBus = New LoaiCayBUS()
        vitri = New ViTriCayBUS()
        FiterData("")
        'connect table [LOAICAY]

        Dim command_vt As New SqlCommand("SELECT * FROM [LOAICAY]", connection)
        Dim adapter_vt As New SqlDataAdapter(command_vt)
        Dim table_vt As New DataTable()
        adapter_vt.Fill(table_vt)
        cbx_LoaiCay.DataSource = table_vt
        cbx_LoaiCay.DisplayMember = "TEN_LOAICAY"
        cbx_LoaiCay.ValueMember = "ID_LOAICAY"

        'connect table [VITRI]
        Dim command_dv As New SqlCommand("SELECT * FROM [VITRI]", connection)
        Dim adapter_dv As New SqlDataAdapter(command_dv)
        Dim table_dv As New DataTable()
        adapter_dv.Fill(table_dv)
        cbx_ViTri.DataSource = table_dv
        cbx_ViTri.DisplayMember = "TEN_VITRI"
        cbx_ViTri.ValueMember = "ID_VITRI"

    End Sub

    'Private Sub btn_ThemCay_Click(sender As Object, e As EventArgs) Handles btn_ThemCay.Click
    '    Dim Cay As CayDTO
    '    Cay = New CayDTO()

    '    '1. Mapping data from GUI control
    '    Cay.MS_Cay = tbx_IDCay.Text
    '    Cay.TenCay = tbx_TenCay.Text
    '    Cay.MS_LoaiCay = Convert.ToInt32(cbx_LoaiCay.SelectedValue)
    '    Cay.ViTriCay = Convert.ToInt32(cbx_ViTri.SelectedValue)
    '    Cay.NgayTrong = dtp_NgayTrong.Value

    '    '2. Business .....
    '    If (cayBus.isValidName(Cay) = False) Then
    '        MessageBox.Show("Tree name is not correct")
    '        tbx_TenCay.Focus()
    '        Return
    '    End If
    '    '3. Insert to DB
    '    Dim result As Result
    '    result = cayBus.insert(Cay)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Add tree Success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'set MSSH auto
    '        Dim nextMshs = "1"
    '        result = cayBus.buildMS_Cay(nextMshs)
    '        If (result.FlagResult = False) Then
    '            MessageBox.Show("Get the autocomplete code tree failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return
    '        End If
    '        tbx_IDCay.Text = nextMshs
    '        tbx_TenCay.Text = String.Empty

    '    Else
    '        MessageBox.Show("Add tree unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    'End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDCay.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenCay.Text = SelectRow.Cells(1).Value.ToString()
            cbx_LoaiCay.Text = SelectRow.Cells(2).Value.ToString()
            cbx_ViTri.Text = SelectRow.Cells(3).Value.ToString()
            dtp_NgayTrong.Value = Convert.ToDateTime(SelectRow.Cells(4).Value.ToString())
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        'DELETE From [CAY] Where 
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [CAY] WHERE [ID_CAY] = '" & tbx_IDCay.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Xoa vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [dbo].[CAY]
            SET [ID_CAY] = '" & tbx_IDCay.Text & "'
            ,[TENCAY] = '" & tbx_TenCay.Text & "'
            ,[ID_LOAICAY] = '" & Convert.ToString(cbx_LoaiCay.SelectedValue) & "'
            ,[ID_VITRI] = '" & Convert.ToString(cbx_ViTri.SelectedValue) & "'
            ,[NGAYTRONG] = '" & Convert.ToString(dtp_NgayTrong.Value) & "'
            WHERE [ID_CAY] = '" & tbx_IDCay.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update cay thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub
End Class
