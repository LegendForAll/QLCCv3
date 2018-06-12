Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility

Public Class FrmThemViTri
    Private VitriBus As ViTriCayBUS

    Private Sub ViTriCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VitriBus = New ViTriCayBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = VitriBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDVitri.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_ThemVT_Click(sender As Object, e As EventArgs) Handles btn_ThemVT.Click
        Dim vitri As ViTriCayDTO
        vitri = New ViTriCayDTO()

        '1. Mapping data from GUI control
        vitri.Ma_VT = Convert.ToInt32(tbx_IDVitri.Text)
        vitri.Ten_VT = tbx_TenViTri.Text

        '2. Business .....
        If (VitriBus.isValidName(vitri) = False) Then
            MessageBox.Show("Tên vi tri không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbx_TenViTri.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = VitriBus.insert(vitri)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm vi tri thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbx_TenViTri.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = VitriBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDVitri.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của vi tri cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm vi tri cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim frm As FrmUpdateViTri = New FrmUpdateViTri()
        frm.ShowDialog()
    End Sub
End Class