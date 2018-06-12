Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class ViTriCay
    Private VitriBus As ViTriCayBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT * FROM [VITRI] WHERE CONCAT (ID_VITRI,TEN_VITRI) LIKE'%" & tbx_search.Text & "%'"
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

    Private Sub ViTriCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VitriBus = New ViTriCayBUS()
        FiterData("")
        '' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = VitriBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDVitri.Text = nextID.ToString()
        'End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [VITRI] SET [ID_VITRI] = '" & tbx_IDVitri.Text & "'
                                                            ,[TEN_VITRI] = '" & tbx_TenViTri.Text & "'
                                                            WHERE [ID_VITRI] = '" & tbx_IDVitri.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update vi tri thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDVitri.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenViTri.Text = SelectRow.Cells(1).Value.ToString()
        End If
    End Sub

    'Private Sub btn_ThemVT_Click(sender As Object, e As EventArgs) Handles btn_ThemVT.Click
    '    Dim vitri As ViTriCayDTO
    '    vitri = New ViTriCayDTO()

    '    '1. Mapping data from GUI control
    '    vitri.Ma_VT = Convert.ToInt32(tbx_IDVitri.Text)
    '    vitri.Ten_VT = tbx_TenViTri.Text

    '    '2. Business .....
    '    If (VitriBus.isValidName(vitri) = False) Then
    '        MessageBox.Show("Tên vi tri không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        tbx_TenViTri.Focus()
    '        Return
    '    End If
    '    '3. Insert to DB
    '    Dim result As Result
    '    result = VitriBus.insert(vitri)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Thêm vi tri thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        tbx_TenViTri.Text = String.Empty

    '        ' Get Next ID
    '        Dim nextID As Integer
    '        result = VitriBus.getNextID(nextID)
    '        If (result.FlagResult = True) Then
    '            tbx_IDVitri.Text = nextID.ToString()
    '        Else
    '            MessageBox.Show("Lấy ID kế tiếp của vi tri cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            System.Console.WriteLine(result.SystemMessage)
    '        End If

    '    Else
    '        MessageBox.Show("Thêm vi tri cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    'End Sub

End Class
