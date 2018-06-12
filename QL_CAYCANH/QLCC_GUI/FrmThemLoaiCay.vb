Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility

Public Class FrmThemLoaiCay
    Private LoaiCayBus As LoaiCayBUS

    Private Sub LoaiCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoaiCayBus = New LoaiCayBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = LoaiCayBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDLoaiCay.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_ThemLoai_Click(sender As Object, e As EventArgs) Handles btn_ThemLoai.Click
        Dim loaicay As LoaiCayDTO
        loaicay = New LoaiCayDTO()

        '1. Mapping data from GUI control
        loaicay.MS_LoaiCay = Convert.ToInt32(tbx_IDLoaiCay.Text)
        loaicay.TenLoai_Cay = tbx_TenLoai.Text

        '2. Business .....
        If (LoaiCayBus.isValidName(loaicay) = False) Then
            MessageBox.Show("Tên loai cay không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbx_TenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = LoaiCayBus.insert(loaicay)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loai thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbx_TenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = LoaiCayBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDLoaiCay.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của loai cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loai cay không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim frm As FrmUpdateLoaiCay = New FrmUpdateLoaiCay()
        frm.Show()
    End Sub
End Class