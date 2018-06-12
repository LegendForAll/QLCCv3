<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Cay
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_ThemCay = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_NgayTrong = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tbx_IDCay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_ViTri = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbx_TenCay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_LoaiCay = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.tbx_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Location = New System.Drawing.Point(19, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 31)
        Me.Panel1.TabIndex = 1
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
        Me.Panel2.Controls.Add(Me.btn_ThemCay)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(19, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 114)
        Me.Panel2.TabIndex = 2
        '
        'btn_ThemCay
        '
        Me.btn_ThemCay.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_ThemCay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemCay.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ThemCay.ForeColor = System.Drawing.Color.White
        Me.btn_ThemCay.Location = New System.Drawing.Point(445, 68)
        Me.btn_ThemCay.Name = "btn_ThemCay"
        Me.btn_ThemCay.Size = New System.Drawing.Size(65, 25)
        Me.btn_ThemCay.TabIndex = 18
        Me.btn_ThemCay.Text = "Insert"
        Me.btn_ThemCay.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.dtp_NgayTrong)
        Me.Panel5.Location = New System.Drawing.Point(226, 67)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(204, 26)
        Me.Panel5.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Planting date:"
        '
        'dtp_NgayTrong
        '
        Me.dtp_NgayTrong.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_NgayTrong.Location = New System.Drawing.Point(83, 3)
        Me.dtp_NgayTrong.Name = "dtp_NgayTrong"
        Me.dtp_NgayTrong.Size = New System.Drawing.Size(118, 20)
        Me.dtp_NgayTrong.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tbx_IDCay)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(16, 12)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(204, 26)
        Me.Panel7.TabIndex = 17
        '
        'tbx_IDCay
        '
        Me.tbx_IDCay.Location = New System.Drawing.Point(70, 2)
        Me.tbx_IDCay.Name = "tbx_IDCay"
        Me.tbx_IDCay.ReadOnly = True
        Me.tbx_IDCay.Size = New System.Drawing.Size(131, 20)
        Me.tbx_IDCay.TabIndex = 7
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cbx_ViTri)
        Me.Panel4.Location = New System.Drawing.Point(226, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(204, 26)
        Me.Panel4.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Location:"
        '
        'cbx_ViTri
        '
        Me.cbx_ViTri.FormattingEnabled = True
        Me.cbx_ViTri.Location = New System.Drawing.Point(94, 3)
        Me.cbx_ViTri.Name = "cbx_ViTri"
        Me.cbx_ViTri.Size = New System.Drawing.Size(107, 21)
        Me.cbx_ViTri.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tbx_TenCay)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(16, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(204, 26)
        Me.Panel6.TabIndex = 18
        '
        'tbx_TenCay
        '
        Me.tbx_TenCay.Location = New System.Drawing.Point(70, 3)
        Me.tbx_TenCay.Name = "tbx_TenCay"
        Me.tbx_TenCay.Size = New System.Drawing.Size(131, 20)
        Me.tbx_TenCay.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tree name:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cbx_LoaiCay)
        Me.Panel3.Location = New System.Drawing.Point(226, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(204, 26)
        Me.Panel3.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type:"
        '
        'cbx_LoaiCay
        '
        Me.cbx_LoaiCay.FormattingEnabled = True
        Me.cbx_LoaiCay.Location = New System.Drawing.Point(94, 2)
        Me.cbx_LoaiCay.Name = "cbx_LoaiCay"
        Me.cbx_LoaiCay.Size = New System.Drawing.Size(107, 21)
        Me.cbx_LoaiCay.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 170)
        Me.DataGridView1.TabIndex = 29
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.tbx_search)
        Me.Panel8.Controls.Add(Me.btn_search)
        Me.Panel8.Location = New System.Drawing.Point(129, 173)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(430, 31)
        Me.Panel8.TabIndex = 30
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
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_del.ForeColor = System.Drawing.Color.White
        Me.btn_del.Location = New System.Drawing.Point(349, 386)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(65, 25)
        Me.btn_del.TabIndex = 32
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_up.ForeColor = System.Drawing.Color.White
        Me.btn_up.Location = New System.Drawing.Point(420, 386)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(65, 25)
        Me.btn_up.TabIndex = 33
        Me.btn_up.Text = "Update"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(491, 386)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 34
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'UC_Cay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_huy)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Cay"
        Me.Size = New System.Drawing.Size(578, 426)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_NgayTrong As DateTimePicker
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tbx_IDCay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_ViTri As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tbx_TenCay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_LoaiCay As ComboBox
    Friend WithEvents btn_ThemCay As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents tbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_huy As Button
End Class
