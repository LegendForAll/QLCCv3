Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmUpdateBCTT
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT DISTINCT  CT.ID_BCCT_TINHTRANGCAY, CT.ID_BCTT_CAY, C.TENCAY, L.TEN_LOAICAY, C.NGAYTRONG, CS.TT_CAY FROM [BCCT_TINHTRANGCAY] CT,[CHAMSOC_CAY] CS, [CAY] C, [LOAICAY] L
        WHERE CT.ID_CAY = CS.ID_CAY 
        AND CT.ID_CAY=C.ID_CAY
        AND C.ID_LOAICAY=L.ID_LOAICAY
        ORDER BY  CT.ID_BCCT_TINHTRANGCAY"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = table


    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub FrmUpdateBCTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiterData("")
        'connect table [VITRI]
        Dim command_dv As New SqlCommand("SELECT * FROM [BCTINHTRANG_CAY]", connection)
        Dim adapter_dv As New SqlDataAdapter(command_dv)
        Dim table_dv As New DataTable()
        adapter_dv.Fill(table_dv)
        cbx_lichBC.DataSource = table_dv
        cbx_lichBC.DisplayMember = "TG_BAOCAO"
        cbx_lichBC.ValueMember = "ID_BCTT_CAY"
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [BCCT_TINHTRANGCAY] WHERE [ID_BCCT_TINHTRANGCAY] = '" & tbx_IDBCCT.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Xoa danh muc bao cao thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDBCCT.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenCay.Text = SelectRow.Cells(1).Value.ToString()
            tbx_IDBC.Text = SelectRow.Cells(1).Value.ToString()
        End If
    End Sub
End Class