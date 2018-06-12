Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As FrmUpdateCSCAY = New FrmUpdateCSCAY()
        frm.Show()
    End Sub
    Dim flag As Boolean
    Dim x, y As Integer

    Private Sub Panel_header_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseMove
        If (flag = True) Then
            Me.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y)
        End If
    End Sub

    Private Sub Panel_header_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseUp
        flag = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Application.Exit()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        btn_updateTree.Visible = False
        btn_insertTree.Visible = False
    End Sub

    Private Sub btn_treeMenu_Click(sender As Object, e As EventArgs) Handles btn_treeMenu.Click
        tool_tree.Visible = True
    End Sub

    Private Sub btn_suppliesMenu_Click(sender As Object, e As EventArgs) Handles btn_suppliesMenu.Click
        tool_supplies.Visible = True
    End Sub

    Private Sub btn_cost_Click(sender As Object, e As EventArgs) Handles btn_cost.Click
        tool_report.Visible = True
    End Sub

    Private Sub pic_reTree_Click(sender As Object, e As EventArgs) Handles pic_reTree.Click
        tool_tree.Visible = False
    End Sub

    Private Sub pic_reSup_Click(sender As Object, e As EventArgs) Handles pic_reSup.Click
        tool_supplies.Visible = False
    End Sub

    Private Sub pic_reReport_Click(sender As Object, e As EventArgs) Handles pic_reReport.Click
        tool_report.Visible = False
    End Sub

    Private Sub btn_manage_Click(sender As Object, e As EventArgs) Handles btn_manage.Click
        toolbar_manage.Enabled = True
        toolbar_scheduling.Enabled = False
        toolbar_report.Enabled = False
        tool_tree.Visible = False
        tool_supplies.Visible = False
        tool_report.Visible = False
    End Sub

    Private Sub btn_scheduling_Click(sender As Object, e As EventArgs) Handles btn_scheduling.Click
        toolbar_scheduling.Enabled = True
        toolbar_manage.Enabled = False
        toolbar_report.Enabled = False
        tool_tree.Visible = False
        tool_supplies.Visible = False
        tool_report.Visible = False

    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        toolbar_report.Enabled = True
        toolbar_manage.Enabled = False
        toolbar_scheduling.Enabled = False
        tool_tree.Visible = False
        tool_supplies.Visible = False
        tool_report.Visible = False
    End Sub

    Private Sub btn_insertTree_Click(sender As Object, e As EventArgs) Handles btn_insertTree.Click
        Dim frm As FrmThemCay = New FrmThemCay()
        frm.Show()
    End Sub

    Private Sub btn_careTree_Click(sender As Object, e As EventArgs) Handles btn_careTree.Click
        Dim frm As FrmThemChamSoc = New FrmThemChamSoc()
        frm.Show()
    End Sub

    Private Sub btn_updateTree_Click(sender As Object, e As EventArgs) Handles btn_updateTree.Click
        Dim frm As FrmUpdateCay = New FrmUpdateCay()
        frm.Show()
    End Sub

    Private Sub btn_insertSup_Click(sender As Object, e As EventArgs) Handles btn_insertSup.Click
        Dim frm As Frm_ThemVatTu = New Frm_ThemVatTu()
        frm.Show()
    End Sub

    Private Sub btn_upVatTu_Click(sender As Object, e As EventArgs) Handles btn_upVatTu.Click
        Dim frm As FrmUpdateVatTu = New FrmUpdateVatTu()
        frm.Show()
    End Sub

    Private Sub btn_phieumuaVT_Click(sender As Object, e As EventArgs) Handles btn_phieumuaVT.Click
        Dim frm As FrmPhieuMuaVT = New FrmPhieuMuaVT()
        frm.Show()
    End Sub

    Private Sub btn_costRe_Click(sender As Object, e As EventArgs) Handles btn_costRe.Click
        Dim frm As FrmBaoCaoCP = New FrmBaoCaoCP()
        frm.Show()
    End Sub

    Private Sub btn_scheduling_tree_Click(sender As Object, e As EventArgs) Handles btn_scheduling_tree.Click
        Dim frm As FrmThemLichCS = New FrmThemLichCS()
        frm.Show()
    End Sub

    Private Sub btn_Unit_Click(sender As Object, e As EventArgs) Handles btn_Unit.Click
        Dim frm As FrmDonVi = New FrmDonVi()
        frm.Show()
    End Sub

    Private Sub btn_treetype_Click(sender As Object, e As EventArgs) Handles btn_treetype.Click
        Dim frm As FrmThemLoaiCay = New FrmThemLoaiCay()
        frm.Show()
    End Sub

    Private Sub btn_treelocation_Click(sender As Object, e As EventArgs) Handles btn_treelocation.Click
        Dim frm As FrmThemViTri = New FrmThemViTri()
        frm.Show()
    End Sub

    Private Sub btn_statusRe_Click(sender As Object, e As EventArgs) Handles btn_statusRe.Click
        Dim frm As FrmBaoCaoTTCay = New FrmBaoCaoTTCay()
        frm.Show()
    End Sub

    Private Sub Panel_header_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseDown
        flag = True
        x = e.X
        y = e.Y
    End Sub
End Class
