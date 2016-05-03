Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim mainmenu As New mainmenu
        Timer1.Enabled = True
        If Timer1.Interval = 3000 Then
            Timer1.Dispose()
            Me.Visible = False
            mainmenu = New mainmenu
            mainmenu.Show()
        End If

    End Sub
End Class
