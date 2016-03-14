Public NotInheritable Class SplashScreen5

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)

        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class
