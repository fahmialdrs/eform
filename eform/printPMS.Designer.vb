<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printPMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printPMS))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Noform = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.notelp = New System.Windows.Forms.Label()
        Me.firmax3 = New System.Windows.Forms.Label()
        Me.O2max = New System.Windows.Forms.Label()
        Me.totalpcs = New System.Windows.Forms.Label()
        Me.totalset = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.Label()
        Me.firmax3_2 = New System.Windows.Forms.Label()
        Me.o2max_2 = New System.Windows.Forms.Label()
        Me.totalpcs_2 = New System.Windows.Forms.Label()
        Me.totalset_2 = New System.Windows.Forms.Label()
        Me.amount_2 = New System.Windows.Forms.Label()
        Me.ordered = New System.Windows.Forms.Label()
        Me.proceeded = New System.Windows.Forms.Label()
        Me.catatan = New System.Windows.Forms.Label()
        Me.finalcheck = New System.Windows.Forms.Label()
        Me.datainput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(407, 715)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Noform
        '
        Me.Noform.AutoSize = True
        Me.Noform.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Noform.Location = New System.Drawing.Point(383, -43)
        Me.Noform.Name = "Noform"
        Me.Noform.Size = New System.Drawing.Size(0, 13)
        Me.Noform.TabIndex = 32
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tanggal.Location = New System.Drawing.Point(204, 47)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(0, 13)
        Me.tanggal.TabIndex = 33
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.userid.Location = New System.Drawing.Point(204, 67)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(0, 13)
        Me.userid.TabIndex = 34
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nama.Location = New System.Drawing.Point(204, 86)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(0, 13)
        Me.nama.TabIndex = 35
        '
        'notelp
        '
        Me.notelp.AutoSize = True
        Me.notelp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.notelp.Location = New System.Drawing.Point(204, 106)
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(0, 13)
        Me.notelp.TabIndex = 36
        '
        'firmax3
        '
        Me.firmax3.AutoSize = True
        Me.firmax3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.firmax3.Location = New System.Drawing.Point(213, 193)
        Me.firmax3.Name = "firmax3"
        Me.firmax3.Size = New System.Drawing.Size(0, 13)
        Me.firmax3.TabIndex = 37
        '
        'O2max
        '
        Me.O2max.AutoSize = True
        Me.O2max.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.O2max.Location = New System.Drawing.Point(356, 193)
        Me.O2max.Name = "O2max"
        Me.O2max.Size = New System.Drawing.Size(0, 13)
        Me.O2max.TabIndex = 38
        '
        'totalpcs
        '
        Me.totalpcs.AutoSize = True
        Me.totalpcs.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalpcs.Location = New System.Drawing.Point(213, 208)
        Me.totalpcs.Name = "totalpcs"
        Me.totalpcs.Size = New System.Drawing.Size(0, 13)
        Me.totalpcs.TabIndex = 39
        '
        'totalset
        '
        Me.totalset.AutoSize = True
        Me.totalset.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalset.Location = New System.Drawing.Point(213, 228)
        Me.totalset.Name = "totalset"
        Me.totalset.Size = New System.Drawing.Size(0, 13)
        Me.totalset.TabIndex = 40
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.amount.Location = New System.Drawing.Point(240, 253)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(0, 13)
        Me.amount.TabIndex = 41
        '
        'firmax3_2
        '
        Me.firmax3_2.AutoSize = True
        Me.firmax3_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.firmax3_2.Location = New System.Drawing.Point(213, 349)
        Me.firmax3_2.Name = "firmax3_2"
        Me.firmax3_2.Size = New System.Drawing.Size(0, 13)
        Me.firmax3_2.TabIndex = 42
        '
        'o2max_2
        '
        Me.o2max_2.AutoSize = True
        Me.o2max_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.o2max_2.Location = New System.Drawing.Point(356, 348)
        Me.o2max_2.Name = "o2max_2"
        Me.o2max_2.Size = New System.Drawing.Size(0, 13)
        Me.o2max_2.TabIndex = 43
        '
        'totalpcs_2
        '
        Me.totalpcs_2.AutoSize = True
        Me.totalpcs_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalpcs_2.Location = New System.Drawing.Point(213, 367)
        Me.totalpcs_2.Name = "totalpcs_2"
        Me.totalpcs_2.Size = New System.Drawing.Size(0, 13)
        Me.totalpcs_2.TabIndex = 44
        '
        'totalset_2
        '
        Me.totalset_2.AutoSize = True
        Me.totalset_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalset_2.Location = New System.Drawing.Point(213, 387)
        Me.totalset_2.Name = "totalset_2"
        Me.totalset_2.Size = New System.Drawing.Size(0, 13)
        Me.totalset_2.TabIndex = 45
        '
        'amount_2
        '
        Me.amount_2.AutoSize = True
        Me.amount_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.amount_2.Location = New System.Drawing.Point(240, 413)
        Me.amount_2.Name = "amount_2"
        Me.amount_2.Size = New System.Drawing.Size(0, 13)
        Me.amount_2.TabIndex = 46
        '
        'ordered
        '
        Me.ordered.AutoSize = True
        Me.ordered.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ordered.Location = New System.Drawing.Point(78, 525)
        Me.ordered.Name = "ordered"
        Me.ordered.Size = New System.Drawing.Size(0, 13)
        Me.ordered.TabIndex = 47
        '
        'proceeded
        '
        Me.proceeded.AutoSize = True
        Me.proceeded.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.proceeded.Location = New System.Drawing.Point(396, 525)
        Me.proceeded.Name = "proceeded"
        Me.proceeded.Size = New System.Drawing.Size(0, 13)
        Me.proceeded.TabIndex = 48
        '
        'catatan
        '
        Me.catatan.AutoSize = True
        Me.catatan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.catatan.Location = New System.Drawing.Point(66, 556)
        Me.catatan.Name = "catatan"
        Me.catatan.Size = New System.Drawing.Size(0, 13)
        Me.catatan.TabIndex = 49
        '
        'finalcheck
        '
        Me.finalcheck.AutoSize = True
        Me.finalcheck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.finalcheck.Location = New System.Drawing.Point(221, 684)
        Me.finalcheck.Name = "finalcheck"
        Me.finalcheck.Size = New System.Drawing.Size(0, 13)
        Me.finalcheck.TabIndex = 50
        '
        'datainput
        '
        Me.datainput.AutoSize = True
        Me.datainput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.datainput.Location = New System.Drawing.Point(356, 684)
        Me.datainput.Name = "datainput"
        Me.datainput.Size = New System.Drawing.Size(0, 13)
        Me.datainput.TabIndex = 51
        '
        'printPMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(543, 733)
        Me.Controls.Add(Me.datainput)
        Me.Controls.Add(Me.finalcheck)
        Me.Controls.Add(Me.catatan)
        Me.Controls.Add(Me.proceeded)
        Me.Controls.Add(Me.ordered)
        Me.Controls.Add(Me.amount_2)
        Me.Controls.Add(Me.totalset_2)
        Me.Controls.Add(Me.totalpcs_2)
        Me.Controls.Add(Me.o2max_2)
        Me.Controls.Add(Me.firmax3_2)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.totalset)
        Me.Controls.Add(Me.totalpcs)
        Me.Controls.Add(Me.O2max)
        Me.Controls.Add(Me.firmax3)
        Me.Controls.Add(Me.notelp)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Noform)
        Me.Controls.Add(Me.Button1)
        Me.Name = "printPMS"
        Me.Text = "printPMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents datainput As Label
    Friend WithEvents finalcheck As Label
    Friend WithEvents catatan As Label
    Friend WithEvents proceeded As Label
    Friend WithEvents ordered As Label
    Friend WithEvents amount_2 As Label
    Friend WithEvents totalset_2 As Label
    Friend WithEvents totalpcs_2 As Label
    Friend WithEvents o2max_2 As Label
    Friend WithEvents firmax3_2 As Label
    Friend WithEvents amount As Label
    Friend WithEvents totalset As Label
    Friend WithEvents totalpcs As Label
    Friend WithEvents O2max As Label
    Friend WithEvents firmax3 As Label
    Friend WithEvents notelp As Label
    Friend WithEvents nama As Label
    Friend WithEvents userid As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents Noform As Label
    Friend WithEvents Button1 As Button
End Class
