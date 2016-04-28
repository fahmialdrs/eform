Public Class membermenu
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub pembelianmember_Click(sender As Object, e As EventArgs) Handles pembelianmember.Click
        Pembelian.Show()
        Me.Hide()
    End Sub

    Private Sub mobilemember_Click(sender As Object, e As EventArgs) Handles mobilemember.Click
        mobilestockist.Show()
        Me.Hide()
    End Sub

    Private Sub maintainmember_Click(sender As Object, e As EventArgs) Handles maintainmember.Click
        maintain.Show()
        Me.Hide()
    End Sub

    Private Sub claimmember_Click(sender As Object, e As EventArgs) Handles claimmember.Click
        maintainmobile.Show()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class