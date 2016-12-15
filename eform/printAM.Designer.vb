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
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'no
        '
        resources.ApplyResources(Me.no, "no")
        Me.no.BackColor = System.Drawing.Color.Transparent
        Me.no.Name = "no"
        '
        'tanggal
        '
        resources.ApplyResources(Me.tanggal, "tanggal")
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.Name = "tanggal"
        '
        'userid
        '
        resources.ApplyResources(Me.userid, "userid")
        Me.userid.BackColor = System.Drawing.Color.Transparent
        Me.userid.Name = "userid"
        '
        'nama
        '
        resources.ApplyResources(Me.nama, "nama")
        Me.nama.BackColor = System.Drawing.Color.Transparent
        Me.nama.Name = "nama"
        '
        'notelp
        '
        resources.ApplyResources(Me.notelp, "notelp")
        Me.notelp.BackColor = System.Drawing.Color.Transparent
        Me.notelp.Name = "notelp"
        '
        'kurangbayar
        '
        resources.ApplyResources(Me.kurangbayar, "kurangbayar")
        Me.kurangbayar.BackColor = System.Drawing.Color.Transparent
        Me.kurangbayar.Name = "kurangbayar"
        '
        'saldomaintain2
        '
        resources.ApplyResources(Me.saldomaintain2, "saldomaintain2")
        Me.saldomaintain2.BackColor = System.Drawing.Color.Transparent
        Me.saldomaintain2.Name = "saldomaintain2"
        '
        'saldomaintain
        '
        resources.ApplyResources(Me.saldomaintain, "saldomaintain")
        Me.saldomaintain.BackColor = System.Drawing.Color.Transparent
        Me.saldomaintain.Name = "saldomaintain"
        '
        'firmax3
        '
        resources.ApplyResources(Me.firmax3, "firmax3")
        Me.firmax3.BackColor = System.Drawing.Color.Transparent
        Me.firmax3.Name = "firmax3"
        '
        'o2max3
        '
        resources.ApplyResources(Me.o2max3, "o2max3")
        Me.o2max3.BackColor = System.Drawing.Color.Transparent
        Me.o2max3.Name = "o2max3"
        '
        'totalpcs
        '
        resources.ApplyResources(Me.totalpcs, "totalpcs")
        Me.totalpcs.BackColor = System.Drawing.Color.Transparent
        Me.totalpcs.Name = "totalpcs"
        '
        'totalset
        '
        resources.ApplyResources(Me.totalset, "totalset")
        Me.totalset.BackColor = System.Drawing.Color.Transparent
        Me.totalset.Name = "totalset"
        '
        'amount
        '
        resources.ApplyResources(Me.amount, "amount")
        Me.amount.BackColor = System.Drawing.Color.Transparent
        Me.amount.Name = "amount"
        '
        'ordered
        '
        resources.ApplyResources(Me.ordered, "ordered")
        Me.ordered.BackColor = System.Drawing.Color.Transparent
        Me.ordered.Name = "ordered"
        '
        'proceeded
        '
        resources.ApplyResources(Me.proceeded, "proceeded")
        Me.proceeded.BackColor = System.Drawing.Color.Transparent
        Me.proceeded.Name = "proceeded"
        '
        'catatan
        '
        resources.ApplyResources(Me.catatan, "catatan")
        Me.catatan.BackColor = System.Drawing.Color.Transparent
        Me.catatan.Name = "catatan"
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
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'printAM
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "printAM"
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
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button1 As Button
End Class
