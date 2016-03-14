Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database4DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Database4DataSet.Table2)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table2BindingSource1.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Table2BindingSource1.MovePrevious()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Table2BindingSource2.MoveNext()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error GoTo saveErr
        Table2BindingSource1.EndEdit()
        Table2TableAdapter.Update(Database4DataSet)
        MessageBox.Show("ok!")
SaveErr:
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Table2BindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Form5.Show()
    End Sub
End Class