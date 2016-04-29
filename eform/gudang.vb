Public Class gudang

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        adminmenu.Show()
        Me.Hide()
    End Sub

    Private Sub gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.e_form' table. You can move, or remove it, as needed.
        Me.E_formTableAdapter.Fill(Me.DatabaseDataSet.e_form)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub E_formBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles E_formBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.E_formBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        ReportViewer1.Refresh()
    End Sub
End Class