Public Class ProgressUpload


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Progress File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"

    End Sub
End Class