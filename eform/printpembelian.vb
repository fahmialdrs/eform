Public Class printpembelian



    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        'BackgroundImage = Nothing

        PrintDialog1.PrinterSettings = PrintForm1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then

            PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintForm1.Print()
        End If
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

    Private Sub o2max3_Click(sender As Object, e As EventArgs) Handles o2max3.Click

    End Sub
End Class