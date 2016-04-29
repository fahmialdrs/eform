Public Class finance
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        adminmenu.Show()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'databaseDataSet1.e_form' table. You can move, or remove it, as needed.
        Me.e_formTableAdapter.Fill(Me.databaseDataSet1.e_form)
        'TODO: This line of code loads data into the 'databaseDataSet.e_form' table. You can move, or remove it, as needed.
        Me.e_formTableAdapter.Fill(Me.databaseDataSet1.e_form)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class