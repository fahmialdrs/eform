Public Class printpembelian



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False

        PrintForm1.Print()

        Button1.Visible = True
    End Sub

    Private Sub printpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub finalcheck_Click(sender As Object, e As EventArgs) Handles finalcheck.Click

    End Sub

    Private Sub tanggal_Click(sender As Object, e As EventArgs) Handles tanggal.Click

    End Sub

    Private Sub note_Click(sender As Object, e As EventArgs) Handles note.Click

    End Sub
End Class