Public Class mainmenu
    Private Sub member_Click(sender As Object, e As EventArgs) Handles member.Click
        membermenu.Show()
        Me.Close()
    End Sub

    Private Sub newmember_Click(sender As Object, e As EventArgs) Handles newmember.Click
        newmembermenu.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup.Show()
        Me.Close()
    End Sub
End Class