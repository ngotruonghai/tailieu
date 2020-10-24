<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Me.gr = New System.Windows.Forms.GroupBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'gr
        '
        Me.gr.Location = New System.Drawing.Point(12, 12)
        Me.gr.Name = "gr"
        Me.gr.Size = New System.Drawing.Size(652, 260)
        Me.gr.TabIndex = 0
        Me.gr.TabStop = False
        Me.gr.Text = "GroupBox1"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(825, 142)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 130)
        Me.VScrollBar1.TabIndex = 1
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 450)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.gr)
        Me.Name = "frm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gr As GroupBox
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
