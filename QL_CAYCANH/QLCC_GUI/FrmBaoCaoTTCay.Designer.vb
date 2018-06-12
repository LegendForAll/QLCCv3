<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBaoCaoTTCay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBaoCaoTTCay))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.tbx_IDBCCT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.tbx_IDCay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.tbx_TenCay = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.tbx_loaicay = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_insert2 = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtp_choose = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_IDlich = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbx_IDBC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtp_TGBC = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Insert = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(655, 30)
        Me.Panel7.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "status report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.btn_insert2)
        Me.Panel1.Controls.Add(Me.btn_huy)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 489)
        Me.Panel1.TabIndex = 39
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.tbx_IDBCCT)
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Enabled = False
        Me.Panel11.Location = New System.Drawing.Point(327, 154)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(204, 26)
        Me.Panel11.TabIndex = 57
        '
        'tbx_IDBCCT
        '
        Me.tbx_IDBCCT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbx_IDBCCT.Location = New System.Drawing.Point(80, 2)
        Me.tbx_IDBCCT.Name = "tbx_IDBCCT"
        Me.tbx_IDBCCT.ReadOnly = True
        Me.tbx_IDBCCT.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDBCCT.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Id:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(433, 454)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 25)
        Me.btn_update.TabIndex = 56
        Me.btn_update.Text = "update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.tbx_IDCay)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Enabled = False
        Me.Panel8.Location = New System.Drawing.Point(327, 184)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(204, 26)
        Me.Panel8.TabIndex = 53
        '
        'tbx_IDCay
        '
        Me.tbx_IDCay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbx_IDCay.Location = New System.Drawing.Point(80, 2)
        Me.tbx_IDCay.Name = "tbx_IDCay"
        Me.tbx_IDCay.ReadOnly = True
        Me.tbx_IDCay.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDCay.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Id tree:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.tbx_TenCay)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Enabled = False
        Me.Panel9.Location = New System.Drawing.Point(327, 212)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(204, 26)
        Me.Panel9.TabIndex = 54
        '
        'tbx_TenCay
        '
        Me.tbx_TenCay.Location = New System.Drawing.Point(80, 3)
        Me.tbx_TenCay.Name = "tbx_TenCay"
        Me.tbx_TenCay.Size = New System.Drawing.Size(121, 20)
        Me.tbx_TenCay.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tree name:"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.tbx_loaicay)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Enabled = False
        Me.Panel10.Location = New System.Drawing.Point(327, 241)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(204, 26)
        Me.Panel10.TabIndex = 55
        '
        'tbx_loaicay
        '
        Me.tbx_loaicay.Location = New System.Drawing.Point(80, 3)
        Me.tbx_loaicay.Name = "tbx_loaicay"
        Me.tbx_loaicay.Size = New System.Drawing.Size(121, 20)
        Me.tbx_loaicay.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Type:"
        '
        'btn_insert2
        '
        Me.btn_insert2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_insert2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insert2.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert2.ForeColor = System.Drawing.Color.White
        Me.btn_insert2.Location = New System.Drawing.Point(504, 454)
        Me.btn_insert2.Name = "btn_insert2"
        Me.btn_insert2.Size = New System.Drawing.Size(65, 25)
        Me.btn_insert2.TabIndex = 52
        Me.btn_insert2.Text = "Insert"
        Me.btn_insert2.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(577, 454)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 51
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.dtp_choose)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(12, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 27)
        Me.Panel2.TabIndex = 48
        '
        'dtp_choose
        '
        Me.dtp_choose.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_choose.Location = New System.Drawing.Point(124, 3)
        Me.dtp_choose.Name = "dtp_choose"
        Me.dtp_choose.Size = New System.Drawing.Size(121, 20)
        Me.dtp_choose.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Choose calendar:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(176, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 25)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "CATEGORY REPORT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tbx_IDlich)
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(12, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 26)
        Me.Panel5.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "ID calendar:"
        '
        'tbx_IDlich
        '
        Me.tbx_IDlich.Location = New System.Drawing.Point(124, 3)
        Me.tbx_IDlich.Name = "tbx_IDlich"
        Me.tbx_IDlich.Size = New System.Drawing.Size(73, 20)
        Me.tbx_IDlich.TabIndex = 31
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(306, 144)
        Me.DataGridView1.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.btn_Insert)
        Me.Panel3.Location = New System.Drawing.Point(324, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 61)
        Me.Panel3.TabIndex = 45
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tbx_IDBC)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 26)
        Me.Panel4.TabIndex = 15
        '
        'tbx_IDBC
        '
        Me.tbx_IDBC.Location = New System.Drawing.Point(140, 3)
        Me.tbx_IDBC.Name = "tbx_IDBC"
        Me.tbx_IDBC.ReadOnly = True
        Me.tbx_IDBC.Size = New System.Drawing.Size(102, 20)
        Me.tbx_IDBC.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Calendar report:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dtp_TGBC)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(3, 32)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(245, 26)
        Me.Panel6.TabIndex = 16
        '
        'dtp_TGBC
        '
        Me.dtp_TGBC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TGBC.Location = New System.Drawing.Point(140, 3)
        Me.dtp_TGBC.Name = "dtp_TGBC"
        Me.dtp_TGBC.Size = New System.Drawing.Size(102, 20)
        Me.dtp_TGBC.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Time:"
        '
        'btn_Insert
        '
        Me.btn_Insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Insert.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Insert.ForeColor = System.Drawing.Color.White
        Me.btn_Insert.Location = New System.Drawing.Point(254, 33)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(65, 25)
        Me.btn_Insert.TabIndex = 17
        Me.btn_Insert.Text = "Insert"
        Me.btn_Insert.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 272)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(630, 175)
        Me.DataGridView2.TabIndex = 49
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'FrmBaoCaoTTCay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBaoCaoTTCay"
        Me.Text = "FrmBaoCaoTTCay"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_huy As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtp_choose As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tbx_IDlich As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbx_IDBC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dtp_TGBC As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Insert As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents btn_insert2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents tbx_IDCay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents tbx_TenCay As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents tbx_loaicay As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents tbx_IDBCCT As TextBox
    Friend WithEvents Label9 As Label
End Class
