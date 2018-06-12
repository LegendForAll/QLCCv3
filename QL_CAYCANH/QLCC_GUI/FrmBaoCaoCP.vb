Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmBaoCaoCP
    Private BCaoBus As BCChiPhiBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        Dim str As String = Convert.ToString(dtp_choose.Value.Month)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        'Dim searchQuery As String = "SELECT V.TEN_VATTU AS TENVT FROM [PHIEUMUA_VT] P, [PHIEUMUA_VTCT] CT, [VATTU] V
        'WHERE P.ID_PHIEUMUA_VT=CT.ID_PHIEUMUA_VT
        'AND V.ID_VATTU = CT.ID_VATTU
        'AND MONTH(P.NGAYMUAVT)='" & str & "'"
        '   Dim searchQuery As String = "SELECT V.TEN_VATTU AS TENVT,SUM(SOTIEN) AS TRIGIA  FROM [PHIEUMUA_VT] P, [PHIEUMUA_VTCT] CT, [VATTU] V
        '   WHERE P.ID_PHIEUMUA_VT=CT.ID_PHIEUMUA_VT
        '   AND V.ID_VATTU = CT.ID_VATTU
        '   AND MONTH(P.NGAYMUAVT)='" & str & "'
        'GROUP BY V.TEN_VATTU,V.ID_VATTU"
        Dim searchQuery As String = "SELECT V.TEN_VATTU AS TENVT,SUM(SOTIEN) AS TRIGIA,COUNT(CT.ID_VATTU) AS SOPHIEU  FROM [PHIEUMUA_VT] P, [PHIEUMUA_VTCT] CT, [VATTU] V
        WHERE P.ID_PHIEUMUA_VT=CT.ID_PHIEUMUA_VT
        AND V.ID_VATTU = CT.ID_VATTU
        AND MONTH(P.NGAYMUAVT)='" & str & "'
	    GROUP BY V.TEN_VATTU,CT.ID_VATTU"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)

        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT * FROM [BCCHIPHI]"
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
    Private Sub FrmBaoCaoCP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BCaoBus = New BCChiPhiBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = BCaoBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDBC.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Dim BaoCao As BCChiPhiDTO
        BaoCao = New BCChiPhiDTO()

        '1. Mapping data from GUI control
        BaoCao.MS_BCChiPhi = Convert.ToInt32(tbx_IDBC.Text)
        BaoCao.TG_BaoCao = dtp_TGBC.Value

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = BCaoBus.insert(BaoCao)

        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm lich bao cao thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = BCaoBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDBC.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của lich bao cao không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm lich bao cao không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
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


    Private Sub btn_huy_Click_1(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class