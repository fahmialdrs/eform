<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newmembermenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newmembermenu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pembeliannewmember = New System.Windows.Forms.Button()
        Me.formregister = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpembelian = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "FORM REGISTER"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(594, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 31)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "FORM PEMBELIAN"
        '
        'pembeliannewmember
        '
        Me.pembeliannewmember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pembeliannewmember.AutoSize = True
        Me.pembeliannewmember.BackColor = System.Drawing.SystemColors.Window
        Me.pembeliannewmember.BackgroundImage = CType(resources.GetObject("pembeliannewmember.BackgroundImage"), System.Drawing.Image)
        Me.pembeliannewmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pembeliannewmember.Image = CType(resources.GetObject("pembeliannewmember.Image"), System.Drawing.Image)
        Me.pembeliannewmember.Location = New System.Drawing.Point(651, 307)
        Me.pembeliannewmember.Name = "pembeliannewmember"
        Me.pembeliannewmember.Size = New System.Drawing.Size(136, 136)
        Me.pembeliannewmember.TabIndex = 27
        Me.pembeliannewmember.UseVisualStyleBackColor = False
        '
        'formregister
        '
        Me.formregister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.formregister.AutoSize = True
        Me.formregister.BackColor = System.Drawing.SystemColors.ControlDark
        Me.formregister.BackgroundImage = CType(resources.GetObject("formregister.BackgroundImage"), System.Drawing.Image)
        Me.formregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.formregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.formregister.Image = CType(resources.GetObject("formregister.Image"), System.Drawing.Image)
        Me.formregister.Location = New System.Drawing.Point(99, 270)
        Me.formregister.Name = "formregister"
        Me.formregister.Size = New System.Drawing.Size(136, 136)
        Me.formregister.TabIndex = 25
        Me.formregister.UseVisualStyleBackColor = False
        Me.formregister.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(90, 509)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 18)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "BACK TO MAIN MENU"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SettingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip.TabIndex = 36
        Me.MenuStrip.Text = "MenuStrip"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupDatabaseToolStripMenuItem})
        Me.SettingToolStripMenuItem.Image = CType(resources.GetObject("SettingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Image = CType(resources.GetObject("BackupDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(137, 449)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(67, 57)
        Me.back.TabIndex = 77
        Me.back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(588, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 638)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(897, 20)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Gedung Gajah Unit AP - Jl. Dr. Sahardjo No.111, Tebet Barat, Tebet 12810 Jakarta " & _
    "Selatan Telp. 021-8310351"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 31)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "PT. RF3 WORLD INDONESIA "
        '
        'lblpembelian
        '
        Me.lblpembelian.AutoSize = True
        Me.lblpembelian.Location = New System.Drawing.Point(782, 332)
        Me.lblpembelian.Name = "lblpembelian"
        Me.lblpembelian.Size = New System.Drawing.Size(82, 13)
        Me.lblpembelian.TabIndex = 85
        Me.lblpembelian.Text = "Form Pembelian"
        Me.lblpembelian.Visible = False
        '
        'newmembermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.lblpembelian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pembeliannewmember)
        Me.Controls.Add(Me.formregister)
        Me.Name = "newmembermenu"
        Me.Text = "Menu Member Baru"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pembeliannewmember As Button
    Friend WithEvents formregister As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblpembelian As System.Windows.Forms.Label
End Class
