<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_ChamSocCay
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Ud_soluongCS = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tbx_IDChamSoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_vattu = New System.Windows.Forms.ComboBox()
        Me.btn_ThemCS = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_TGCham = New System.Windows.Forms.DateTimePicker()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cbx_GhiChu = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cbx_TenCay = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_tinhtrang = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbx_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Ud_soluongCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Location = New System.Drawing.Point(16, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 31)
        Me.Panel1.TabIndex = 2
        '
        'btn_sua
        '
        Me.btn_sua.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sua.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_sua.ForeColor = System.Drawing.Color.White
        Me.btn_sua.Location = New System.Drawing.Point(135, 3)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(65, 25)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Update"
        Me.btn_sua.UseVisualStyleBackColor = False
        '
        'btn_them
        '
        Me.btn_them.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_them.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.ForeColor = System.Drawing.Color.White
        Me.btn_them.Location = New System.Drawing.Point(3, 3)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(65, 25)
        Me.btn_them.TabIndex = 1
        Me.btn_them.Text = "Insert"
        Me.btn_them.UseVisualStyleBackColor = False
        '
        'btn_xoa
        '
        Me.btn_xoa.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_xoa.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_xoa.ForeColor = System.Drawing.Color.White
        Me.btn_xoa.Location = New System.Drawing.Point(69, 3)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(65, 25)
        Me.btn_xoa.TabIndex = 2
        Me.btn_xoa.Text = "Delete"
        Me.btn_xoa.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.btn_ThemCS)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Location = New System.Drawing.Point(16, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(505, 117)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Ud_soluongCS)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 26)
        Me.Panel3.TabIndex = 13
        '
        'Ud_soluongCS
        '
        Me.Ud_soluongCS.Location = New System.Drawing.Point(196, 3)
        Me.Ud_soluongCS.Name = "Ud_soluongCS"
        Me.Ud_soluongCS.Size = New System.Drawing.Size(46, 20)
        Me.Ud_soluongCS.TabIndex = 4
        Me.Ud_soluongCS.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tbx_IDChamSoc)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(245, 26)
        Me.Panel7.TabIndex = 18
        '
        'tbx_IDChamSoc
        '
        Me.tbx_IDChamSoc.Location = New System.Drawing.Point(121, 2)
        Me.tbx_IDChamSoc.Name = "tbx_IDChamSoc"
        Me.tbx_IDChamSoc.ReadOnly = True
        Me.tbx_IDChamSoc.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDChamSoc.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.cbx_vattu)
        Me.Panel8.Location = New System.Drawing.Point(3, 58)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(245, 26)
        Me.Panel8.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Supplies:"
        '
        'cbx_vattu
        '
        Me.cbx_vattu.FormattingEnabled = True
        Me.cbx_vattu.Location = New System.Drawing.Point(121, 2)
        Me.cbx_vattu.Name = "cbx_vattu"
        Me.cbx_vattu.Size = New System.Drawing.Size(121, 21)
        Me.cbx_vattu.TabIndex = 9
        '
        'btn_ThemCS
        '
        Me.btn_ThemCS.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_ThemCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemCS.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ThemCS.ForeColor = System.Drawing.Color.White
        Me.btn_ThemCS.Location = New System.Drawing.Point(421, 88)
        Me.btn_ThemCS.Name = "btn_ThemCS"
        Me.btn_ThemCS.Size = New System.Drawing.Size(65, 25)
        Me.btn_ThemCS.TabIndex = 18
        Me.btn_ThemCS.Text = "Insert"
        Me.btn_ThemCS.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.dtp_TGCham)
        Me.Panel9.Location = New System.Drawing.Point(254, 58)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(245, 26)
        Me.Panel9.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Time of care:"
        '
        'dtp_TGCham
        '
        Me.dtp_TGCham.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TGCham.Location = New System.Drawing.Point(121, 3)
        Me.dtp_TGCham.Name = "dtp_TGCham"
        Me.dtp_TGCham.Size = New System.Drawing.Size(121, 20)
        Me.dtp_TGCham.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.cbx_GhiChu)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Location = New System.Drawing.Point(254, 31)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(245, 26)
        Me.Panel10.TabIndex = 32
        '
        'cbx_GhiChu
        '
        Me.cbx_GhiChu.FormattingEnabled = True
        Me.cbx_GhiChu.Items.AddRange(New Object() {"Sick", "Strong", "Death"})
        Me.cbx_GhiChu.Location = New System.Drawing.Point(121, 3)
        Me.cbx_GhiChu.Name = "cbx_GhiChu"
        Me.cbx_GhiChu.Size = New System.Drawing.Size(121, 21)
        Me.cbx_GhiChu.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Note:"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.cbx_TenCay)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Location = New System.Drawing.Point(3, 31)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(245, 26)
        Me.Panel12.TabIndex = 30
        '
        'cbx_TenCay
        '
        Me.cbx_TenCay.FormattingEnabled = True
        Me.cbx_TenCay.Location = New System.Drawing.Point(121, 2)
        Me.cbx_TenCay.Name = "cbx_TenCay"
        Me.cbx_TenCay.Size = New System.Drawing.Size(121, 21)
        Me.cbx_TenCay.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Tree ID:"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Controls.Add(Me.cbx_tinhtrang)
        Me.Panel11.Location = New System.Drawing.Point(254, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(245, 26)
        Me.Panel11.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Quantity:"
        '
        'cbx_tinhtrang
        '
        Me.cbx_tinhtrang.FormattingEnabled = True
        Me.cbx_tinhtrang.Items.AddRange(New Object() {"Normal", "Good"})
        Me.cbx_tinhtrang.Location = New System.Drawing.Point(121, 2)
        Me.cbx_tinhtrang.Name = "cbx_tinhtrang"
        Me.cbx_tinhtrang.Size = New System.Drawing.Size(121, 21)
        Me.cbx_tinhtrang.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.tbx_search)
        Me.Panel6.Controls.Add(Me.btn_search)
        Me.Panel6.Location = New System.Drawing.Point(86, 177)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(429, 31)
        Me.Panel6.TabIndex = 29
        '
        'tbx_search
        '
        Me.tbx_search.Location = New System.Drawing.Point(202, 5)
        Me.tbx_search.Name = "tbx_search"
        Me.tbx_search.Size = New System.Drawing.Size(153, 20)
        Me.tbx_search.TabIndex = 23
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(361, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(65, 25)
        Me.btn_search.TabIndex = 24
        Me.btn_search.Text = "search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(505, 150)
        Me.DataGridView1.TabIndex = 30
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_del.ForeColor = System.Drawing.Color.White
        Me.btn_del.Location = New System.Drawing.Point(305, 370)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(65, 25)
        Me.btn_del.TabIndex = 31
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_up.ForeColor = System.Drawing.Color.White
        Me.btn_up.Location = New System.Drawing.Point(376, 370)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(65, 25)
        Me.btn_up.TabIndex = 32
        Me.btn_up.Text = "Update"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(447, 370)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 33
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'UC_ChamSocCay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_huy)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_ChamSocCay"
        Me.Size = New System.Drawing.Size(541, 404)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Ud_soluongCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_ThemCS As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_vattu As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_TGCham As DateTimePicker
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbx_tinhtrang As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tbx_IDChamSoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_TenCay As ComboBox
    Friend WithEvents cbx_GhiChu As ComboBox
    Friend WithEvents Ud_soluongCS As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_huy As Button
End Class
