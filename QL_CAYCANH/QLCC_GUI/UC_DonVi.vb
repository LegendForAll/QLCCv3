Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class UC_DonVi
    Private DonViBus As DonViBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer

    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT * FROM [DONVI] WHERE CONCAT (ID_DONVI,TEN_DONVI) LIKE'%" & tbx_search.Text & "%'"
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

    Private Sub UC_DonVi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DonViBus = New DonViBUS()
        FiterData("")
        '' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = DonViBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDDonVi.Text = nextID.ToString()
        'End If
    End Sub

    'Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click
    '    Dim donvi As DonViDTO
    '    donvi = New DonViDTO()

    '    '1. Mapping data from GUI control
    '    donvi.MS_DonVi = Convert.ToInt32(tbx_IDDonVi.Text)
    '    donvi.TenDonVi = tbx_TenDonVi.Text

    '    '2. Business .....
    '    If (DonViBus.isValidName(donvi) = False) Then
    '        MessageBox.Show("Tên don vi không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        tbx_TenDonVi.Focus()
    '        Return
    '    End If
    '    '3. Insert to DB
    '    Dim result As Result
    '    result = DonViBus.insert(donvi)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Thêm don vi thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        tbx_TenDonVi.Text = String.Empty

    '        ' Get Next ID
    '        Dim nextID As Integer
    '        result = DonViBus.getNextID(nextID)
    '        If (result.FlagResult = True) Then
    '            tbx_IDDonVi.Text = nextID.ToString()
    '        Else
    '            MessageBox.Show("Lấy ID kế tiếp của don vi không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            System.Console.WriteLine(result.SystemMessage)
    '        End If

    '    Else
    '        MessageBox.Show("Thêm don vi không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    'End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [DONVI] SET [ID_DONVI] = '" & tbx_IDDonVi.Text & "'
                                                            ,[TEN_DONVI] = '" & tbx_TenDonVi.Text & "'
                                                            WHERE [ID_DONVI] = '" & tbx_IDDonVi.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update don vi thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    'Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
    '    'If DataGridView1.Rows(0).IsNewRow Then
    '    'Else
    '    '    DataGridView1.Rows.RemoveAt(index)
    '    '    Dim deleteQuery As String = "DELETE FROM [DONVI] WHERE [ID_DONVI] = '" & tbx_IDDonVi.Text & "'"
    '    '    ExcuteQuery(deleteQuery)
    '    '    MessageBox.Show("Xoa don vi thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    DataGridView1.Refresh()
    '    '    FiterData("")
    '    'End If
    'End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDDonVi.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenDonVi.Text = SelectRow.Cells(1).Value.ToString()
        End If
    End Sub
End Class
