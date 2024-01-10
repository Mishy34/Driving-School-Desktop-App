Public Class Schedule



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Request Schedule Change"
        MessageBox1.Message.Text = "Your request is sent ! Administration will contact you soon !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub
End Class