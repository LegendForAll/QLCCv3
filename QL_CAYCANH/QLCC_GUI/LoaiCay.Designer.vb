<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoaiCay
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbx_IDLoaiCay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbx_TenLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_ThemLoai = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbx_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(19, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 31)
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
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_ThemLoai)
        Me.Panel2.Location = New System.Drawing.Point(19, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 78)
        Me.Panel2.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tbx_IDLoaiCay)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 26)
        Me.Panel4.TabIndex = 15
        '
        'tbx_IDLoaiCay
        '
        Me.tbx_IDLoaiCay.Location = New System.Drawing.Point(121, 3)
        Me.tbx_IDLoaiCay.Name = "tbx_IDLoaiCay"
        Me.tbx_IDLoaiCay.ReadOnly = True
        Me.tbx_IDLoaiCay.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDLoaiCay.TabIndex = 7
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tbx_TenLoai)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(3, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 26)
        Me.Panel3.TabIndex = 16
        '
        'tbx_TenLoai
        '
        Me.tbx_TenLoai.Location = New System.Drawing.Point(89, 3)
        Me.tbx_TenLoai.Name = "tbx_TenLoai"
        Me.tbx_TenLoai.Size = New System.Drawing.Size(153, 20)
        Me.tbx_TenLoai.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type of trees:"
        '
        'btn_ThemLoai
        '
        Me.btn_ThemLoai.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_ThemLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemLoai.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ThemLoai.ForeColor = System.Drawing.Color.White
        Me.btn_ThemLoai.Location = New System.Drawing.Point(278, 42)
        Me.btn_ThemLoai.Name = "btn_ThemLoai"
        Me.btn_ThemLoai.Size = New System.Drawing.Size(65, 25)
        Me.btn_ThemLoai.TabIndex = 17
        Me.btn_ThemLoai.Text = "Insert"
        Me.btn_ThemLoai.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(368, 343)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 2
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.tbx_search)
        Me.Panel6.Controls.Add(Me.btn_search)
        Me.Panel6.Location = New System.Drawing.Point(19, 150)
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
        Me.DataGridView1.Location = New System.Drawing.Point(19, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(261, 150)
        Me.DataGridView1.TabIndex = 30
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.btn_up.ForeColor = System.Drawing.Color.White
        Me.btn_up.Location = New System.Drawing.Point(297, 343)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(65, 25)
        Me.btn_up.TabIndex = 33
        Me.btn_up.Text = "Update"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'LoaiCay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_huy)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoaiCay"
        Me.Size = New System.Drawing.Size(463, 379)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbx_IDLoaiCay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_huy As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbx_TenLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_ThemLoai As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_up As Button
End Class
