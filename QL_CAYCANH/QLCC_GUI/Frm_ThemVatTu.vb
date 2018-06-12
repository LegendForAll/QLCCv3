Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient

Public Class Frm_ThemVatTu
    Private VatTuBus As VaTuBUS
    Private donviBus As DonViBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")

    Private Sub Frm_ThemVatTu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VatTuBus = New VaTuBUS()
        donviBus = New DonViBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = VatTuBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDVatTu.Text = nextID.ToString()
        End If

        ' Load loai cay list
        Dim listdonvi = New List(Of DonViDTO)
        result = donviBus.selectAll(listdonvi)

        cbx_Donvi.DataSource = New BindingSource(listdonvi, String.Empty)
        cbx_Donvi.DisplayMember = "TenDonVi"
        cbx_Donvi.ValueMember = "MS_DonVi"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbx_Donvi.DataSource)
        myCurrencyManager.Refresh()
        If (listdonvi.Count > 0) Then
            cbx_Donvi.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_ThemVT_Click(sender As Object, e As EventArgs) Handles btn_ThemVT.Click
        Dim vatt As VatTuDTO
        vatt = New VatTuDTO()

        '1. Mapping data from GUI control
        vatt.MS_VatTu = Convert.ToInt32(tbx_IDVatTu.Text)
        vatt.Ten_VatTu = tbx_TenVatTu.Text
        vatt.MS_DonVi = Convert.ToInt32(cbx_Donvi.SelectedValue)
        '2. Business .....
        If (VatTuBus.isValidName(vatt) = False) Then
            MessageBox.Show("Tên vat tu không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbx_TenVatTu.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = VatTuBus.insert(vatt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm vat tu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbx_TenVatTu.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = VatTuBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDVatTu.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của vat tu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm vat tu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class