Public Class newmembermenu
    Private Sub formregister_Click(sender As Object, e As EventArgs) Handles formregister.Click
        register.Show()
        Me.Close()
    End Sub

    Private Sub pembeliannewmember_Click(sender As Object, e As EventArgs) Handles pembeliannewmember.Click
        pembelianewmember.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup.Show()
        Me.Close()
    End Sub
    Private Sub pembeliannewmember_MouseHover(sender As Object, e As EventArgs) Handles pembeliannewmember.MouseHover
        lblpembelian.Visible = True
    End Sub

    Private Sub pembeliannewmember_MouseLeave(sender As Object, e As EventArgs) Handles pembeliannewmember.MouseLeave
        lblpembelian.Visible = False
    End Sub
End Class