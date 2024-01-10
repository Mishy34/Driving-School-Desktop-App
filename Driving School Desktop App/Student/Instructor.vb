Public Class Instructor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Successfull Submission"
        MessageBox1.Message.Text = "Your message successfully sent !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub
End Class