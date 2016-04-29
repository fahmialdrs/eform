Public Class backup

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub
End Class