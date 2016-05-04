Public Class gudang

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        adminmenu.Show()
        Me.Close()
    End Sub

    Private Sub gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'databaseDataSet.e_form' table. You can move, or remove it, as needed.
        Me.e_formTableAdapter.FillAkunting(Me.databaseDataSet.e_form)
        Me.ReportViewer1.RefreshReport()
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