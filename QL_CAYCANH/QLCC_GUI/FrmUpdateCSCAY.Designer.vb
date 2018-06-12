<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateCSCAY
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
        Me.UC_ChamSocCay1 = New QLCC_GUI.UC_ChamSocCay()
        Me.SuspendLayout()
        '
        'UC_ChamSocCay1
        '
        Me.UC_ChamSocCay1.Location = New System.Drawing.Point(54, 32)
        Me.UC_ChamSocCay1.Name = "UC_ChamSocCay1"
        Me.UC_ChamSocCay1.Size = New System.Drawing.Size(541, 404)
        Me.UC_ChamSocCay1.TabIndex = 0
        '
        'FrmUpdateCSCAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 488)
        Me.Controls.Add(Me.UC_ChamSocCay1)
        Me.Name = "FrmUpdateCSCAY"
        Me.Text = "FrmUpdateCSCAY"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_ChamSocCay1 As UC_ChamSocCay
End Class
