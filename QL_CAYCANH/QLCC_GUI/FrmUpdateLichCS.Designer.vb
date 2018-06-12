<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateLichCS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateLichCS))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_up2 = New System.Windows.Forms.Button()
        Me.btn_de2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.tbx_IDLich = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.dtp_TGLich = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_TGchamOfcay = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbx_LichCS = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.tbx_IDLichCT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_up1 = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.tbx_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_de1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 30)
        Me.Panel2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "update"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btn_up2)
        Me.Panel1.Controls.Add(Me.btn_de2)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_up1)
        Me.Panel1.Controls.Add(Me.btn_huy)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.btn_de1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 538)
        Me.Panel1.TabIndex = 32
        '
        'btn_up2
        '
        Me.btn_up2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_up2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up2.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up2.ForeColor = System.Drawing.Color.White
        Me.btn_up2.Location = New System.Drawing.Point(520, 236)
        Me.btn_up2.Name = "btn_up2"
        Me.btn_up2.Size = New System.Drawing.Size(65, 25)
        Me.btn_up2.TabIndex = 47
        Me.btn_up2.Text = "UPDATE"
        Me.btn_up2.UseVisualStyleBackColor = False
        '
        'btn_de2
        '
        Me.btn_de2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_de2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_de2.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_de2.ForeColor = System.Drawing.Color.White
        Me.btn_de2.Location = New System.Drawing.Point(449, 236)
        Me.btn_de2.Name = "btn_de2"
        Me.btn_de2.Size = New System.Drawing.Size(65, 25)
        Me.btn_de2.TabIndex = 48
        Me.btn_de2.Text = "DELETE"
        Me.btn_de2.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(271, 30)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(317, 197)
        Me.DataGridView2.TabIndex = 46
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Location = New System.Drawing.Point(12, 30)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(253, 61)
        Me.Panel11.TabIndex = 45
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.tbx_IDLich)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(245, 26)
        Me.Panel12.TabIndex = 15
        '
        'tbx_IDLich
        '
        Me.tbx_IDLich.Location = New System.Drawing.Point(121, 3)
        Me.tbx_IDLich.Name = "tbx_IDLich"
        Me.tbx_IDLich.ReadOnly = True
        Me.tbx_IDLich.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDLich.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ID Calendar care:"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.dtp_TGLich)
        Me.Panel13.Controls.Add(Me.Label7)
        Me.Panel13.Location = New System.Drawing.Point(3, 32)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(245, 26)
        Me.Panel13.TabIndex = 16
        '
        'dtp_TGLich
        '
        Me.dtp_TGLich.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TGLich.Location = New System.Drawing.Point(121, 3)
        Me.dtp_TGLich.Name = "dtp_TGLich"
        Me.dtp_TGLich.Size = New System.Drawing.Size(121, 20)
        Me.dtp_TGLich.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Time:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Location = New System.Drawing.Point(12, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 119)
        Me.Panel3.TabIndex = 44
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.cbx_TGchamOfcay)
        Me.Panel9.Location = New System.Drawing.Point(3, 90)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(245, 26)
        Me.Panel9.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Time to care:"
        '
        'cbx_TGchamOfcay
        '
        Me.cbx_TGchamOfcay.FormattingEnabled = True
        Me.cbx_TGchamOfcay.Location = New System.Drawing.Point(121, 2)
        Me.cbx_TGchamOfcay.Name = "cbx_TGchamOfcay"
        Me.cbx_TGchamOfcay.Size = New System.Drawing.Size(121, 21)
        Me.cbx_TGchamOfcay.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.ComboBox1)
        Me.Panel7.Location = New System.Drawing.Point(3, 61)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(245, 26)
        Me.Panel7.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Plants need care:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbx_LichCS)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 26)
        Me.Panel4.TabIndex = 28
        '
        'cbx_LichCS
        '
        Me.cbx_LichCS.FormattingEnabled = True
        Me.cbx_LichCS.Location = New System.Drawing.Point(121, 2)
        Me.cbx_LichCS.Name = "cbx_LichCS"
        Me.cbx_LichCS.Size = New System.Drawing.Size(121, 21)
        Me.cbx_LichCS.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID Calendar care:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.tbx_IDLichCT)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Location = New System.Drawing.Point(3, 32)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(245, 26)
        Me.Panel8.TabIndex = 15
        '
        'tbx_IDLichCT
        '
        Me.tbx_IDLichCT.Location = New System.Drawing.Point(121, 3)
        Me.tbx_IDLichCT.Name = "tbx_IDLichCT"
        Me.tbx_IDLichCT.ReadOnly = True
        Me.tbx_IDLichCT.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDLichCT.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Detail:"
        '
        'btn_up1
        '
        Me.btn_up1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_up1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up1.ForeColor = System.Drawing.Color.White
        Me.btn_up1.Location = New System.Drawing.Point(449, 501)
        Me.btn_up1.Name = "btn_up1"
        Me.btn_up1.Size = New System.Drawing.Size(65, 25)
        Me.btn_up1.TabIndex = 38
        Me.btn_up1.Text = "UPDATE"
        Me.btn_up1.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(520, 501)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 37
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.tbx_search)
        Me.Panel10.Controls.Add(Me.btn_search)
        Me.Panel10.Location = New System.Drawing.Point(159, 272)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(429, 31)
        Me.Panel10.TabIndex = 41
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
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
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
        'btn_de1
        '
        Me.btn_de1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_de1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_de1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_de1.ForeColor = System.Drawing.Color.White
        Me.btn_de1.Location = New System.Drawing.Point(378, 501)
        Me.btn_de1.Name = "btn_de1"
        Me.btn_de1.Size = New System.Drawing.Size(65, 25)
        Me.btn_de1.TabIndex = 39
        Me.btn_de1.Text = "DELETE"
        Me.btn_de1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(579, 186)
        Me.DataGridView1.TabIndex = 40
        '
        'FrmUpdateLichCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUpdateLichCS"
        Me.Text = "FrmUpdateLichCS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_up2 As Button
    Friend WithEvents btn_de2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents tbx_IDLich As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents dtp_TGLich As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbx_LichCS As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_up1 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_TGchamOfcay As ComboBox
    Friend WithEvents btn_huy As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents tbx_IDLichCT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents tbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_de1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
