<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pgb
        '
        Me.pgb.Location = New System.Drawing.Point(55, 225)
        Me.pgb.Maximum = 200
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(427, 24)
        Me.pgb.TabIndex = 0
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 150
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 311)
        Me.Controls.Add(Me.pgb)
        Me.Name = "splash"
        Me.Text = "splash"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pgb As ProgressBar
    Friend WithEvents tmr As Timer
End Class
