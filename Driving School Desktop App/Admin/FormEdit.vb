Public Class FormEdit
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Form Submitted"
        MessageBox1.Message.Text = "Successfully Submitted !"
        MessageBox1.MessageButton.Text = "Ok"
        DashboardAdmin.Show()
    End Sub
End Class