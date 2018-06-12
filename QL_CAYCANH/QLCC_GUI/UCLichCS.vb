Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class UCLichCS
    Private lichBus As LichChamSocBUS
    Private lichCTBus As LichChamSoc_CTBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT L.NGAYLAP,CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU
        'FROM [CHAMSOC_CAY] CS,  [VATTU] V, [CAY] C ,[LICHCHAMSOC] L, [LICHCT] CT
        'WHERE CS.ID_CAY=C.ID_CAY AND CS.ID_VATTU=V.ID_VATTU 
        'AND   L.ID_LICHCHAMSOC = CT.ID_LICHCHAMSOC
        'AND   CT.ID_CHAMSOC = CS.ID_CHAMSOC
        'AND CONCAT (L.NGAYLAP,CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU) LIKE'%" & tbx_search.Text & "%'"

        Dim searchQuery As String = "SELECT CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU FROM [CHAMSOC_CAY] CS, [LICHCHAMSOC] L, [LICHCT] CT, [VATTU] V, [CAY] C
        WHERE L.ID_LICHCHAMSOC = '" & tbx_IDLich.Text & "'
        AND CS.ID_CAY=C.ID_CAY AND CS.ID_VATTU=V.ID_VATTU
        AND L.ID_LICHCHAMSOC = CT.ID_LICHCHAMSOC
        AND CT.ID_CHAMSOC = CS.ID_CHAMSOC"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT * FROM [LICHCHAMSOC] WHERE CONCAT (ID_LICHCHAMSOC, NGAYLAP) LIKE'%" & tbx_search.Text & "%'"
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
    Private Sub UCLichCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lichCTBus = New LichChamSoc_CTBUS()
        FiterData("")
        FiterData1("")
        ' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = lichCTBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDLich.Text = nextID.ToString()
        'End If
        ''connect table [CAY]

        'Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
        'Dim adapter_cay As New SqlDataAdapter(command_cay)
        'Dim table_cay As New DataTable()
        'adapter_cay.Fill(table_cay)
        'cbx_TenCay.DataSource = table_cay
        'cbx_TenCay.DisplayMember = "TENCAY"
        'cbx_TenCay.ValueMember = "ID_CAY"
        ''connect table [CHAMSOCCAY]

        'Dim command_CScay As New SqlCommand("SELECT * FROM [LICHCHAMSOC]", connection)
        'Dim adapter_CScay As New SqlDataAdapter(command_CScay)
        'Dim table_CScay As New DataTable()
        'adapter_CScay.Fill(table_CScay)
        'cbx_LichCS.DataSource = table_CScay
        'cbx_LichCS.DisplayMember = "NGAYLAP"
        'cbx_LichCS.ValueMember = "ID_LICHCHAMSOC"
    End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs)
        Dim lichCS As LichChamSocDTO
        lichCS = New LichChamSocDTO()

        Dim lichCSCT As LichChamSoc_CTDTO
        lichCSCT = New LichChamSoc_CTDTO()

        '1. Mapping data from GUI control
        'lichCS.MS_LichCS = Convert.ToInt32(tbx_IDLich.Text)
        'lichCS.TG_ChamSoc = dtp_TGLich.Value
        'lichCSCT.MS_LichCS = Convert.ToInt32(tbx_IDLich.Text)
        'lichCSCT.MS_LichCSCT = Convert.ToInt32(tbx_IDLichCT.Text)
        'lichCSCT.MS_ChamSoc = Convert.ToInt32(tbx_IDLichCT.Text)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = lichBus.insert(lichCS)
        Dim result_CT As Result
        result_CT = lichCTBus.insert(lichCSCT)
        If (result.FlagResult = True And result_CT.FlagResult = True) Then
            MessageBox.Show("Thêm lich cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '' Get Next ID
            'Dim nextID As Integer
            'result = lichBus.getNextID(nextID)
            'If (result.FlagResult = True) Then
            '    tbx_IDLich.Text = nextID.ToString()
            'Else
            '    MessageBox.Show("Lấy ID kế tiếp của lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    System.Console.WriteLine(result.SystemMessage)
            'End If

        Else
            MessageBox.Show("Thêm lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_next1_Click(sender As Object, e As EventArgs)
        lichCTBus = New LichChamSoc_CTBUS()

        '' Get Next ID
        'Dim nextID As Integer
        'Dim result As Result
        'result = lichCTBus.getNextID(nextID)
        'If (result.FlagResult = True) Then
        '    tbx_IDLichCT.Text = nextID.ToString()
        'End If

        ''connect table [CAY]

        'Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
        'Dim adapter_cay As New SqlDataAdapter(command_cay)
        'Dim table_cay As New DataTable()
        'adapter_cay.Fill(table_cay)
        'cbx_TenCay.DataSource = table_cay
        'cbx_TenCay.DisplayMember = "TENCAY"
        'cbx_TenCay.ValueMember = "ID_CAY"
    End Sub

    Private Sub btn_Next2_Click(sender As Object, e As EventArgs) Handles btn_Next2.Click
        ''connect table [CHAMSOCCAY]

        'Dim command_CScay As New SqlCommand("SELECT * FROM [CHAMSOC_CAY] WHERE [ID_CAY]= " + Convert.ToString(cbx_TenCay.ValueMember), connection)
        'Dim adapter_CScay As New SqlDataAdapter(command_CScay)
        'Dim table_CScay As New DataTable()
        'adapter_CScay.Fill(table_CScay)
        'cbx_TGchamOfcay.DataSource = table_CScay
        'cbx_TGchamOfcay.DisplayMember = "TG_CHAMSOC"
        'cbx_TGchamOfcay.ValueMember = "ID_CHAMSOC"
        FiterData("")
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView2.Rows(index)
            tbx_IDLich.Text = SelectRow.Cells(0).Value.ToString()
            dtp_TGLich.Text = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())
            FiterData("")
        End If
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData1(tbx_search.Text)
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData1(tbx_search.Text)
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_up2_Click(sender As Object, e As EventArgs) Handles btn_up2.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [LICHCHAMSOC] SET [ID_LICHCHAMSOC] = '" & tbx_IDLich.Text & "'
                                                            ,[NGAYLAP] = '" & Convert.ToString(dtp_TGLich.Value) & "'
                                                            WHERE [ID_LICHCHAMSOC] = '" & tbx_IDLich.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update lich cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData1("")
            FiterData("")
        End If
    End Sub

    Private Sub btn_de2_Click(sender As Object, e As EventArgs) Handles btn_de2.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            DataGridView2.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [LICHCHAMSOC] WHERE [ID_LICHCHAMSOC] = '" & tbx_IDLich.Text & "'"
            ExcuteQuery(deleteQuery)
            Dim deleteQuery1 As String = "DELETE FROM [LICHCT] WHERE [ID_LICHCHAMSOC] = '" & tbx_IDLich.Text & "'"
            ExcuteQuery(deleteQuery1)

            MessageBox.Show("Xoa lich cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData1("")
        End If
    End Sub
End Class
