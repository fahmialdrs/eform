Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "manager" And password.Text = "12345" Then
            adminmenu.Show()
            Me.Hide()
            username.Text = ""
            password.Text = ""
        ElseIf username.Text = "akunting" And password.Text = "12345" Then
            finance.Show()
            Me.Hide()
            username.Text = ""
            password.Text = ""
        ElseIf username.Text = "gudang" And password.Text = "12345" Then
            gudang.Show()
            Me.Hide()
            username.Text = ""
            password.Text = ""
        Else
            MessageBox.Show("Username atau Password Salah", "Gagal Login", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub mainmenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mainmenuToolStripMenuItem.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup.Show()
        Me.Hide()
    End Sub
End Class