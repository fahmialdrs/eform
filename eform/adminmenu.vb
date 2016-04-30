Public Class adminmenu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub member_Click(sender As Object, e As EventArgs) Handles member.Click
        finance.Show()
        Me.Hide()
    End Sub

    Private Sub newmember_Click(sender As Object, e As EventArgs) Handles newmember.Click
        gudang.Show()
        Me.Hide()
    End Sub
    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup.Show()
        Me.Hide()
    End Sub
End Class