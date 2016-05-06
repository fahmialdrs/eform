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

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup.Show()
        Me.Close()
    End Sub

    Private Sub mobiletmember_Click(sender As Object, e As EventArgs) Handles mobiletmember.Click
        mobilestockistt.Show()
        Me.Close()
    End Sub

    Private Sub pembelianmember_MouseHover(sender As Object, e As EventArgs) Handles pembelianmember.MouseHover
        lblpembelian.Visible = True
    End Sub

    Private Sub pembelianmember_MouseLeave(sender As Object, e As EventArgs) Handles pembelianmember.MouseLeave
        lblpembelian.Visible = False
    End Sub

    Private Sub mobilemember_MouseHover(sender As Object, e As EventArgs) Handles mobilemember.MouseHover
        lblmobiler.Visible = True
    End Sub

    Private Sub mobilemember_MouseLeave(sender As Object, e As EventArgs) Handles mobilemember.MouseLeave
        lblmobiler.Visible = False
    End Sub

    Private Sub mobiletmember_MouseHover(sender As Object, e As EventArgs) Handles mobiletmember.MouseHover
        lblmobilet.Visible = True
    End Sub

    Private Sub mobiletmember_MouseLeave(sender As Object, e As EventArgs) Handles mobiletmember.MouseLeave
        lblmobilet.Visible = False
    End Sub

    Private Sub maintainmember_MouseHover(sender As Object, e As EventArgs) Handles maintainmember.MouseHover
        lblmaintain.Visible = True
    End Sub

    Private Sub maintainmember_MouseLeave(sender As Object, e As EventArgs) Handles maintainmember.MouseLeave
        lblmaintain.Visible = False
    End Sub

    Private Sub claimmember_MouseHover(sender As Object, e As EventArgs) Handles claimmember.MouseHover
        lblclaim.Visible = True
    End Sub

    Private Sub claimmember_MouseLeave(sender As Object, e As EventArgs) Handles claimmember.MouseLeave
        lblclaim.Visible = False
    End Sub
End Class