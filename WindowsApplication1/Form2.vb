Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "prianes" And TextBox2.Text = "prianes" Then
            Form5.Show()
            Me.Close()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class