<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_browser = New System.Windows.Forms.Button()
        Me.txt_filename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(542, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip.TabIndex = 37
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Image = CType(resources.GetObject("SettingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.SettingToolStripMenuItem.Text = "Main Menu"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(590, 399)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(125, 54)
        Me.btn_backup.TabIndex = 41
        Me.btn_backup.Text = "BACKUP"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_browser
        '
        Me.btn_browser.BackColor = System.Drawing.Color.Transparent
        Me.btn_browser.Location = New System.Drawing.Point(856, 343)
        Me.btn_browser.Name = "btn_browser"
        Me.btn_browser.Size = New System.Drawing.Size(119, 27)
        Me.btn_browser.TabIndex = 42
        Me.btn_browser.Text = "Browse"
        Me.btn_browser.UseVisualStyleBackColor = False
        '
        'txt_filename
        '
        Me.txt_filename.Location = New System.Drawing.Point(468, 347)
        Me.txt_filename.Name = "txt_filename"
        Me.txt_filename.Size = New System.Drawing.Size(382, 20)
        Me.txt_filename.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 39)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "BACKUP DATABASE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 601)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(897, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Gedung Gajah Unit AP - Jl. Dr. Sahardjo No.111, Tebet Barat, Tebet 12810 Jakarta " & _
    "Selatan Telp. 021-8310351"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 558)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 31)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "PT. RF3 WORLD INDONESIA "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(742, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 54)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "RESTORE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_filename)
        Me.Controls.Add(Me.btn_browser)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "backup"
        Me.Text = "Menu Backup Database"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_backup As System.Windows.Forms.Button
    Friend WithEvents btn_browser As System.Windows.Forms.Button
    Friend WithEvents txt_filename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
