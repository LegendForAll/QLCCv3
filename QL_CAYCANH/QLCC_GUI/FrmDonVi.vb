Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility

Public Class FrmDonVi
    Private DonViBus As DonViBUS
    Private Sub UC_DonVi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DonViBus = New DonViBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = DonViBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDDonVi.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click
        Dim donvi As DonViDTO
        donvi = New DonViDTO()

        '1. Mapping data from GUI control
        donvi.MS_DonVi = Convert.ToInt32(tbx_IDDonVi.Text)
        donvi.TenDonVi = tbx_TenDonVi.Text

        '2. Business .....
        If (DonViBus.isValidName(donvi) = False) Then
            MessageBox.Show("Tên don vi không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbx_TenDonVi.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = DonViBus.insert(donvi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm don vi thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbx_TenDonVi.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = DonViBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDDonVi.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của don vi không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm don vi không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim frm As FrmUpdateDonVi = New FrmUpdateDonVi()
        frm.Show()
    End Sub
End Class