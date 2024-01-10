Public Class UploadFile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "File Upload"
        MessageBox1.Message.Text = "Successfully Uploaded !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub
End Class