<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printpembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printpembelian))
        Me.datainput = New System.Windows.Forms.Label()
        Me.proceededby = New System.Windows.Forms.Label()
        Me.orderedby = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.Label()
        Me.totalset = New System.Windows.Forms.Label()
        Me.totalpcs = New System.Windows.Forms.Label()
        Me.o2max3 = New System.Windows.Forms.Label()
        Me.firmax3 = New System.Windows.Forms.Label()
        Me.notelfon = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.noform = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.firmax3_2 = New System.Windows.Forms.Label()
        Me.o2max3_2 = New System.Windows.Forms.Label()
        Me.totalpcs_2 = New System.Windows.Forms.Label()
        Me.totalset_2 = New System.Windows.Forms.Label()
        Me.amount_2 = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'datainput
        '
        Me.datainput.AutoSize = True
        Me.datainput.BackColor = System.Drawing.Color.Transparent
        Me.datainput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.datainput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datainput.Location = New System.Drawing.Point(1112, 766)
        Me.datainput.Name = "datainput"
        Me.datainput.Size = New System.Drawing.Size(13, 19)
        Me.datainput.TabIndex = 29
        Me.datainput.Text = " "
        '
        'proceededby
        '
        Me.proceededby.AutoSize = True
        Me.proceededby.BackColor = System.Drawing.Color.Transparent
        Me.proceededby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.proceededby.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceededby.Location = New System.Drawing.Point(279, 422)
        Me.proceededby.Name = "proceededby"
        Me.proceededby.Size = New System.Drawing.Size(13, 19)
        Me.proceededby.TabIndex = 26
        Me.proceededby.Text = " "
        '
        'orderedby
        '
        Me.orderedby.AutoSize = True
        Me.orderedby.BackColor = System.Drawing.Color.Transparent
        Me.orderedby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderedby.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderedby.Location = New System.Drawing.Point(54, 422)
        Me.orderedby.Name = "orderedby"
        Me.orderedby.Size = New System.Drawing.Size(13, 19)
        Me.orderedby.TabIndex = 25
        Me.orderedby.Text = " "
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.BackColor = System.Drawing.Color.Transparent
        Me.amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.amount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(203, 303)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(13, 19)
        Me.amount.TabIndex = 24
        Me.amount.Text = " "
        '
        'totalset
        '
        Me.totalset.AutoSize = True
        Me.totalset.BackColor = System.Drawing.Color.Transparent
        Me.totalset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalset.Location = New System.Drawing.Point(158, 270)
        Me.totalset.Name = "totalset"
        Me.totalset.Size = New System.Drawing.Size(13, 19)
        Me.totalset.TabIndex = 23
        Me.totalset.Text = " "
        '
        'totalpcs
        '
        Me.totalpcs.AutoSize = True
        Me.totalpcs.BackColor = System.Drawing.Color.Transparent
        Me.totalpcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalpcs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpcs.Location = New System.Drawing.Point(158, 247)
        Me.totalpcs.Name = "totalpcs"
        Me.totalpcs.Size = New System.Drawing.Size(13, 19)
        Me.totalpcs.TabIndex = 22
        Me.totalpcs.Text = " "
        '
        'o2max3
        '
        Me.o2max3.AutoSize = True
        Me.o2max3.BackColor = System.Drawing.Color.Transparent
        Me.o2max3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.o2max3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o2max3.Location = New System.Drawing.Point(285, 225)
        Me.o2max3.Name = "o2max3"
        Me.o2max3.Size = New System.Drawing.Size(13, 19)
        Me.o2max3.TabIndex = 21
        Me.o2max3.Text = " "
        '
        'firmax3
        '
        Me.firmax3.AutoSize = True
        Me.firmax3.BackColor = System.Drawing.Color.Transparent
        Me.firmax3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.firmax3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firmax3.Location = New System.Drawing.Point(158, 225)
        Me.firmax3.Name = "firmax3"
        Me.firmax3.Size = New System.Drawing.Size(13, 19)
        Me.firmax3.TabIndex = 20
        Me.firmax3.Text = " "
        '
        'notelfon
        '
        Me.notelfon.AutoSize = True
        Me.notelfon.BackColor = System.Drawing.Color.Transparent
        Me.notelfon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notelfon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notelfon.Location = New System.Drawing.Point(510, 136)
        Me.notelfon.Name = "notelfon"
        Me.notelfon.Size = New System.Drawing.Size(13, 19)
        Me.notelfon.TabIndex = 19
        Me.notelfon.Text = " "
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.BackColor = System.Drawing.Color.Transparent
        Me.nama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(158, 134)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(13, 19)
        Me.nama.TabIndex = 18
        Me.nama.Text = " "
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.BackColor = System.Drawing.Color.Transparent
        Me.userid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Location = New System.Drawing.Point(158, 107)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(13, 19)
        Me.userid.TabIndex = 17
        Me.userid.Text = " "
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tanggal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(546, 110)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(12, 17)
        Me.tanggal.TabIndex = 16
        Me.tanggal.Text = " "
        '
        'noform
        '
        Me.noform.AutoSize = True
        Me.noform.BackColor = System.Drawing.Color.Transparent
        Me.noform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.noform.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noform.Location = New System.Drawing.Point(465, 103)
        Me.noform.Name = "noform"
        Me.noform.Size = New System.Drawing.Size(13, 19)
        Me.noform.TabIndex = 15
        Me.noform.Text = " "
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(658, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'firmax3_2
        '
        Me.firmax3_2.AutoSize = True
        Me.firmax3_2.BackColor = System.Drawing.Color.Transparent
        Me.firmax3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.firmax3_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firmax3_2.Location = New System.Drawing.Point(510, 225)
        Me.firmax3_2.Name = "firmax3_2"
        Me.firmax3_2.Size = New System.Drawing.Size(13, 19)
        Me.firmax3_2.TabIndex = 31
        Me.firmax3_2.Text = " "
        '
        'o2max3_2
        '
        Me.o2max3_2.AutoSize = True
        Me.o2max3_2.BackColor = System.Drawing.Color.Transparent
        Me.o2max3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.o2max3_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o2max3_2.Location = New System.Drawing.Point(605, 225)
        Me.o2max3_2.Name = "o2max3_2"
        Me.o2max3_2.Size = New System.Drawing.Size(13, 19)
        Me.o2max3_2.TabIndex = 32
        Me.o2max3_2.Text = " "
        '
        'totalpcs_2
        '
        Me.totalpcs_2.AutoSize = True
        Me.totalpcs_2.BackColor = System.Drawing.Color.Transparent
        Me.totalpcs_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalpcs_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpcs_2.Location = New System.Drawing.Point(510, 247)
        Me.totalpcs_2.Name = "totalpcs_2"
        Me.totalpcs_2.Size = New System.Drawing.Size(13, 19)
        Me.totalpcs_2.TabIndex = 33
        Me.totalpcs_2.Text = " "
        '
        'totalset_2
        '
        Me.totalset_2.AutoSize = True
        Me.totalset_2.BackColor = System.Drawing.Color.Transparent
        Me.totalset_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalset_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalset_2.Location = New System.Drawing.Point(510, 270)
        Me.totalset_2.Name = "totalset_2"
        Me.totalset_2.Size = New System.Drawing.Size(13, 19)
        Me.totalset_2.TabIndex = 34
        Me.totalset_2.Text = " "
        '
        'amount_2
        '
        Me.amount_2.AutoSize = True
        Me.amount_2.BackColor = System.Drawing.Color.Transparent
        Me.amount_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.amount_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_2.Location = New System.Drawing.Point(546, 303)
        Me.amount_2.Name = "amount_2"
        Me.amount_2.Size = New System.Drawing.Size(13, 19)
        Me.amount_2.TabIndex = 35
        Me.amount_2.Text = " "
        '
        'note
        '
        Me.note.AutoSize = True
        Me.note.BackColor = System.Drawing.Color.Transparent
        Me.note.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note.Location = New System.Drawing.Point(405, 407)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(13, 19)
        Me.note.TabIndex = 27
        Me.note.Text = " "
        '
        'printpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(756, 520)
        Me.Controls.Add(Me.amount_2)
        Me.Controls.Add(Me.totalset_2)
        Me.Controls.Add(Me.totalpcs_2)
        Me.Controls.Add(Me.o2max3_2)
        Me.Controls.Add(Me.firmax3_2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.datainput)
        Me.Controls.Add(Me.note)
        Me.Controls.Add(Me.proceededby)
        Me.Controls.Add(Me.orderedby)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.totalset)
        Me.Controls.Add(Me.totalpcs)
        Me.Controls.Add(Me.o2max3)
        Me.Controls.Add(Me.firmax3)
        Me.Controls.Add(Me.notelfon)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.noform)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "printpembelian"
        Me.Text = "printpembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datainput As System.Windows.Forms.Label
    Friend WithEvents proceededby As System.Windows.Forms.Label
    Friend WithEvents orderedby As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.Label
    Friend WithEvents totalset As System.Windows.Forms.Label
    Friend WithEvents totalpcs As System.Windows.Forms.Label
    Friend WithEvents o2max3 As System.Windows.Forms.Label
    Friend WithEvents firmax3 As System.Windows.Forms.Label
    Friend WithEvents notelfon As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents userid As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents noform As System.Windows.Forms.Label
    Public WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents amount_2 As Label
    Friend WithEvents totalset_2 As Label
    Friend WithEvents totalpcs_2 As Label
    Friend WithEvents o2max3_2 As Label
    Friend WithEvents firmax3_2 As Label
    Friend WithEvents note As Label
End Class
