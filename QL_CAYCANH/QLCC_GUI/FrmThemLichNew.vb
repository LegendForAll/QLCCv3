Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmThemLichNew
    Private lichBus As LichChamSocBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")

    Private Sub FrmThemLichNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lichBus = New LichChamSocBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = lichBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDLich.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Dim lichCS As LichChamSocDTO
        lichCS = New LichChamSocDTO()

        '1. Mapping data from GUI control
        lichCS.MS_LichCS = Convert.ToInt32(tbx_IDLich.Text)
        lichCS.TG_ChamSoc = dtp_TGLich.Value

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = lichBus.insert(lichCS)

        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm lich cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = lichBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDLich.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class