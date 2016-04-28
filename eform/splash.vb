Public Class splash
    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        Dim Splash As New splash
        tmr.Enabled = True
        pgb.Value += 10
        If pgb.Value = 200 Then
            tmr.Dispose()
            Me.Visible = False
            Splash = New splash
            Splash.Show()

        End If
    End Sub
End Class