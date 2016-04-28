Public Class newmembermenu
    Private Sub formregister_Click(sender As Object, e As EventArgs) Handles formregister.Click
        register.Show()
        Me.Hide()
    End Sub

    Private Sub pembeliannewmember_Click(sender As Object, e As EventArgs) Handles pembeliannewmember.Click
        pembelianewmember.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class