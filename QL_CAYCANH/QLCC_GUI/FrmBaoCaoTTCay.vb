Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmBaoCaoTTCay
    Private BCaoBus As BCTinhTrang_CayBUS
    Private BCaoCTBus As BCCT_TinhTrangCayBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        Dim str As String = Convert.ToString(dtp_choose.Value.Month)
        Dim searchQuery As String = "SELECT C.ID_CAY AS ID, C.TENCAY AS TENCAY, L.TEN_LOAICAY AS LOAI, C.NGAYTRONG, CS.TT_CAY FROM [CHAMSOC_CAY] CS, [CAY] C, [LOAICAY] L
        WHERE  CS.ID_CAY=C.ID_CAY AND C.ID_LOAICAY=L.ID_LOAICAY
        AND MONTH(CS.TG_CHAMSOC)='" & str & "'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)

        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT * FROM [BCTINHTRANG_CAY]"
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
    Private Sub FrmBaoCaoTTCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BCaoBus = New BCTinhTrang_CayBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = BCaoBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDBC.Text = nextID.ToString()
        End If

        BCaoCTBus = New BCCT_TinhTrangCayBUS()
        ' Get Next ID
        Dim nextID_1 As Integer
        Dim result_1 As Result
        result_1 = BCaoCTBus.getNextID(nextID_1)
        If (result_1.FlagResult = True) Then
            tbx_IDBCCT.Text = nextID_1.ToString()
        End If
    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Dim updateQuery As String = "INSERT INTO [BCTINHTRANG_CAY]
                                            ([ID_BCTT_CAY]
                                            ,[TG_BAOCAO])
                                            VALUES
                                            ('" & tbx_IDBC.Text & "','" & Convert.ToString(dtp_TGBC.Value) & "')"
        ExcuteQuery(updateQuery)
        MessageBox.Show("Them lich bao cao thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DataGridView1.Refresh()
        FiterData1("")

        BCaoBus = New BCTinhTrang_CayBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = BCaoBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDBC.Text = nextID.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FiterData1("")
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDlich.Text = SelectRow.Cells(0).Value.ToString()
            dtp_choose.Value = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())
            FiterData("")
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_insert2_Click(sender As Object, e As EventArgs) Handles btn_insert2.Click

        For i As Integer = DataGridView2.Rows.Count() - 1 To 0 Step -1
            Dim Insert As Boolean
            Insert = DataGridView2.Rows(i).Cells(0).Value
            If Insert = True Then
                Dim updateQuery As String = "INSERT INTO [BCCT_TINHTRANGCAY]
                                                ([ID_BCCT_TINHTRANGCAY]
                                                ,[ID_BCTT_CAY]
                                                ,[ID_CAY])
                                                VALUES
                                                ('" & tbx_IDBCCT.Text & "',
                                                 '" & tbx_IDlich.Text & "',
                                                 '" & tbx_IDCay.Text & "')"
                ExcuteQuery(updateQuery)
                MessageBox.Show("Them danh muc bao cao thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Get Next ID
                BCaoCTBus = New BCCT_TinhTrangCayBUS()
                Dim nextID_1 As Integer
                Dim result_1 As Result
                result_1 = BCaoCTBus.getNextID(nextID_1)
                If (result_1.FlagResult = True) Then
                    tbx_IDBCCT.Text = nextID_1.ToString()
                End If

                'Xoa dong da them tranh trung lap khoa chinh
                Dim row As DataGridViewRow
                row = DataGridView2.Rows(i)
                DataGridView2.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView2.Rows(index)
            tbx_IDCay.Text = SelectRow.Cells(1).Value.ToString()
            tbx_TenCay.Text = SelectRow.Cells(2).Value.ToString()
            tbx_loaicay.Text = SelectRow.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim frm As FrmUpdateBCTT = New FrmUpdateBCTT()
        frm.Show()
    End Sub
End Class