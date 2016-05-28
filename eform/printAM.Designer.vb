<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printAM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printAM))
        Me.no = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.notelp = New System.Windows.Forms.Label()
        Me.kurangbayar = New System.Windows.Forms.Label()
        Me.saldomaintain2 = New System.Windows.Forms.Label()
        Me.saldomaintain = New System.Windows.Forms.Label()
        Me.firmax3 = New System.Windows.Forms.Label()
        Me.o2max3 = New System.Windows.Forms.Label()
        Me.totalpcs = New System.Windows.Forms.Label()
        Me.totalset = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.Label()
        Me.ordered = New System.Windows.Forms.Label()
        Me.proceeded = New System.Windows.Forms.Label()
        Me.catatan = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'no
        '
        Me.no.AutoSize = True
        Me.no.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.no.Location = New System.Drawing.Point(355, 66)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(0, 13)
        Me.no.TabIndex = 0
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tanggal.Location = New System.Drawing.Point(209, 93)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(0, 13)
        Me.tanggal.TabIndex = 1
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.userid.Location = New System.Drawing.Point(209, 113)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(0, 13)
        Me.userid.TabIndex = 2
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nama.Location = New System.Drawing.Point(209, 137)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(0, 13)
        Me.nama.TabIndex = 3
        '
        'notelp
        '
        Me.notelp.AutoSize = True
        Me.notelp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.notelp.Location = New System.Drawing.Point(209, 160)
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(0, 13)
        Me.notelp.TabIndex = 4
        '
        'kurangbayar
        '
        Me.kurangbayar.AutoSize = True
        Me.kurangbayar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.kurangbayar.Location = New System.Drawing.Point(300, 270)
        Me.kurangbayar.Name = "kurangbayar"
        Me.kurangbayar.Size = New System.Drawing.Size(0, 13)
        Me.kurangbayar.TabIndex = 7
        '
        'saldomaintain2
        '
        Me.saldomaintain2.AutoSize = True
        Me.saldomaintain2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.saldomaintain2.Location = New System.Drawing.Point(300, 248)
        Me.saldomaintain2.Name = "saldomaintain2"
        Me.saldomaintain2.Size = New System.Drawing.Size(0, 13)
        Me.saldomaintain2.TabIndex = 6
        '
        'saldomaintain
        '
        Me.saldomaintain.AutoSize = True
        Me.saldomaintain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.saldomaintain.Location = New System.Drawing.Point(300, 225)
        Me.saldomaintain.Name = "saldomaintain"
        Me.saldomaintain.Size = New System.Drawing.Size(0, 13)
        Me.saldomaintain.TabIndex = 5
        '
        'firmax3
        '
        Me.firmax3.AutoSize = True
        Me.firmax3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.firmax3.Location = New System.Drawing.Point(207, 335)
        Me.firmax3.Name = "firmax3"
        Me.firmax3.Size = New System.Drawing.Size(0, 13)
        Me.firmax3.TabIndex = 8
        '
        'o2max3
        '
        Me.o2max3.AutoSize = True
        Me.o2max3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.o2max3.Location = New System.Drawing.Point(328, 335)
        Me.o2max3.Name = "o2max3"
        Me.o2max3.Size = New System.Drawing.Size(0, 13)
        Me.o2max3.TabIndex = 9
        '
        'totalpcs
        '
        Me.totalpcs.AutoSize = True
        Me.totalpcs.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalpcs.Location = New System.Drawing.Point(207, 368)
        Me.totalpcs.Name = "totalpcs"
        Me.totalpcs.Size = New System.Drawing.Size(0, 13)
        Me.totalpcs.TabIndex = 10
        '
        'totalset
        '
        Me.totalset.AutoSize = True
        Me.totalset.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalset.Location = New System.Drawing.Point(207, 404)
        Me.totalset.Name = "totalset"
        Me.totalset.Size = New System.Drawing.Size(0, 13)
        Me.totalset.TabIndex = 11
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.amount.Location = New System.Drawing.Point(234, 442)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(0, 13)
        Me.amount.TabIndex = 12
        '
        'ordered
        '
        Me.ordered.AutoSize = True
        Me.ordered.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ordered.Location = New System.Drawing.Point(110, 553)
        Me.ordered.Name = "ordered"
        Me.ordered.Size = New System.Drawing.Size(0, 13)
        Me.ordered.TabIndex = 13
        '
        'proceeded
        '
        Me.proceeded.AutoSize = True
        Me.proceeded.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.proceeded.Location = New System.Drawing.Point(375, 553)
        Me.proceeded.Name = "proceeded"
        Me.proceeded.Size = New System.Drawing.Size(0, 13)
        Me.proceeded.TabIndex = 14
        '
        'catatan
        '
        Me.catatan.AutoSize = True
        Me.catatan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.catatan.Location = New System.Drawing.Point(72, 613)
        Me.catatan.Name = "catatan"
        Me.catatan.Size = New System.Drawing.Size(0, 13)
        Me.catatan.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 697)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "print"
        Me.Button1.UseVisualStyleBackColor = True
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
        'printAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(543, 733)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.catatan)
        Me.Controls.Add(Me.proceeded)
        Me.Controls.Add(Me.ordered)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.totalset)
        Me.Controls.Add(Me.totalpcs)
        Me.Controls.Add(Me.o2max3)
        Me.Controls.Add(Me.firmax3)
        Me.Controls.Add(Me.kurangbayar)
        Me.Controls.Add(Me.saldomaintain2)
        Me.Controls.Add(Me.saldomaintain)
        Me.Controls.Add(Me.notelp)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.no)
        Me.Name = "printAM"
        Me.Text = "printAM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents no As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents userid As Label
    Friend WithEvents nama As Label
    Friend WithEvents notelp As Label
    Friend WithEvents kurangbayar As Label
    Friend WithEvents saldomaintain2 As Label
    Friend WithEvents saldomaintain As Label
    Friend WithEvents firmax3 As Label
    Friend WithEvents o2max3 As Label
    Friend WithEvents totalpcs As Label
    Friend WithEvents totalset As Label
    Friend WithEvents amount As Label
    Friend WithEvents ordered As Label
    Friend WithEvents proceeded As Label
    Friend WithEvents catatan As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
