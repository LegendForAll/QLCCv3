Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient

Public Class UC_PhieuMuaVT
    Private phieumuaBus As PhieuMua_VTBUS
    Private phieumuaCTBus As PhieuMuaVT_CTBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [PHIEUMUA_VTCT] WHERE CONCAT (ID_PHIEUMUA_CT,ID_PHIEUMUA_VT,DIACHIMUA,SOLUONGMUA,SOTIEN,ID_VATTU) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT P.ID_PHIEUMUA_CT,P.ID_PHIEUMUA_VT,P.DIACHIMUA,P.SOLUONGMUA,P.SOTIEN,P.ID_VATTU,VT.TEN_VATTU FROM [PHIEUMUA_VTCT] P,[VATTU] VT WHERE P.ID_VATTU = VT.ID_VATTU
        AND CONCAT (P.ID_PHIEUMUA_CT,P.ID_PHIEUMUA_VT,P.DIACHIMUA,P.SOLUONGMUA,P.SOTIEN,VT.TEN_VATTU) LIKE'%" & tbx_search.Text & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub UC_PhieuMuaVT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuaBus = New PhieuMua_VTBUS()
        phieumuaCTBus = New PhieuMuaVT_CTBUS()

        FiterData("")
        ' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = phieumuaCTBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDPhieuCT.Text = nextID.ToString()
        'End If

        'connect table [VATTU]

        Dim command_vt As New SqlCommand("SELECT * FROM [VATTU]", connection)
        Dim adapter_vt As New SqlDataAdapter(command_vt)
        Dim table_vt As New DataTable()
        adapter_vt.Fill(table_vt)
        cbx_TenVatTu.DataSource = table_vt
        cbx_TenVatTu.DisplayMember = "TEN_VATTU"
        cbx_TenVatTu.ValueMember = "ID_VATTU"

        'connect table [DONVI]
        Dim command_dv As New SqlCommand("SELECT * FROM [DONVI]", connection)
        Dim adapter_dv As New SqlDataAdapter(command_dv)
        Dim table_dv As New DataTable()
        adapter_dv.Fill(table_dv)
        cbx_DonVi.DataSource = table_dv
        cbx_DonVi.DisplayMember = "TEN_DONVI"
        cbx_DonVi.ValueMember = "ID_DONVI"
    End Sub

    Private Sub btn_next1_Click(sender As Object, e As EventArgs) Handles btn_next1.Click
        phieumuaCTBus = New PhieuMuaVT_CTBUS()

        ' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = phieumuaCTBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDPhieuCT.Text = nextID.ToString()
        'End If


    End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click
        'Dim phieu As PhieuMuaVTDTO
        'phieu = New PhieuMuaVTDTO()

        'Dim phieuCT As PhieuMuaVT_CTDTO
        'phieuCT = New PhieuMuaVT_CTDTO()

        ''1. Mapping data from GUI control
        ''phieu.MS_Phieu = Convert.ToInt32(tbx_IDPhieu.Text)
        ''phieu.TG_Mua = dtp_TGMua.Value
        'phieuCT.MS_CTPhieu = Convert.ToInt32(tbx_IDPhieuCT.Text)
        'phieuCT.MS_VatTu = Convert.ToInt32(cbx_TenVatTu.SelectedValue)
        'phieuCT.SoLuongMua = Convert.ToInt32(ud_SoluongMua.Value)
        ''phieuCT.SoTien = Convert.ToInt32(tbx_tien.Text)
        'phieuCT.DiaChi = tbx_diachi.Text
        ''2. Business .....

        ''3. Insert to DB
        ''Dim result As Result
        ''result = phieumuaBus.insert(phieu)
        'Dim result_CT As Result
        'result_CT = phieumuaCTBus.insert(phieuCT)
        'If (result_CT.FlagResult = True) Then
        '    MessageBox.Show("Thêm phieu mua vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    ' Get Next ID
        '    Dim nextID As Integer
        '    result_CT = phieumuaCTBus.getNextID(nextID)
        '    If (result_CT.FlagResult = True) Then
        '        tbx_IDPhieuCT.Text = nextID.ToString()
        '    Else
        '        MessageBox.Show("Lấy ID kế tiếp của phieu mua vat tu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        System.Console.WriteLine(result_CT.SystemMessage)
        '    End If

        'Else
        '    MessageBox.Show("Thêm phieu mua vat tu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result_CT.SystemMessage)
        'End If
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView2.Rows(index)
            tbx_IDPhieuCT.Text = SelectRow.Cells(0).Value.ToString()
            tbx_IDPhieu.Text = SelectRow.Cells(1).Value.ToString()
            tbx_diachi.Text = SelectRow.Cells(2).Value.ToString()
            ud_SoluongMua.Value = SelectRow.Cells(3).Value.ToString()
            tbx_tien.Text = SelectRow.Cells(4).Value.ToString()
            cbx_TenVatTu.Text = SelectRow.Cells(5).Value.ToString()
        End If
    End Sub

    'Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
    '    If DataGridView2.Rows(0).IsNewRow Then
    '    Else
    '        Dim insertQuery As String = "INSERT INTO [PHIEUMUA_VTCT]
    '       ([ID_PHIEUMUA_CT]
    '       ,[ID_PHIEUMUA_VT]
    '       ,[DIACHIMUA]
    '       ,[SOLUONGMUA]
    '       ,[SOTIEN]
    '       ,[ID_VATTU])
    ' VALUES
    '       ('" & tbx_IDPhieuCT.Text & "'
    '        ,'" & tbx_IDPhieu.Text & "'
    '       ,'" & tbx_diachi.Text & "'
    '        ,'" & Convert.ToString(ud_SoluongMua.Value) & "'
    '       ,'" & tbx_tien.Text & "'
    '        ,'" & Convert.ToInt32(cbx_TenVatTu.SelectedValue) & "')"
    '        ExcuteQuery(insertQuery)
    '        MessageBox.Show("Thêm phieu mua vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        DataGridView2.Refresh()
    '        FiterData("")
    '    End If
    'End Sub

    'Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
    '    If DataGridView2.Rows(0).IsNewRow Then
    '    Else
    '        DataGridView2.Rows.RemoveAt(index)
    '        Dim deleteQuery As String = "DELETE FROM [PHIEUMUA_VTCT] WHERE [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'"
    '        ExcuteQuery(deleteQuery)
    '        MessageBox.Show("Xoa danh muc vat tu da mua thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        DataGridView2.Refresh()
    '        FiterData("")
    '    End If
    'End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [dbo].[PHIEUMUA_VTCT]
                                            SET [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'
                                            ,[ID_PHIEUMUA_VT] = '" & tbx_IDPhieu.Text & "'
                                            ,[DIACHIMUA] = '" & tbx_diachi.Text & "'
                                            ,[SOLUONGMUA] = '" & Convert.ToString(ud_SoluongMua.Value) & "'
                                            ,[SOTIEN] = '" & tbx_tien.Text & "'
                                            ,[ID_VATTU] = '" & cbx_TenVatTu.SelectedValue & "'
                                            WHERE [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update danh muc vat tu da mua thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            DataGridView2.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [PHIEUMUA_VTCT] WHERE [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Xoa danh muc vat tu da mua thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData("")
        End If
    End Sub
End Class
