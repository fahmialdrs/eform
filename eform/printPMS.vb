Public Class printPMS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        BackgroundImage = Nothing

        PrintDialog1.PrinterSettings = PrintForm1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then

            PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintForm1.Print()
        End If
        Button1.Visible = True
    End Sub

    Private Sub printPMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class