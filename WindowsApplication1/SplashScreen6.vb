Public NotInheritable Class SplashScreen6

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pgr1.Increment(10)

        If pgr1.Value = 100 Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
