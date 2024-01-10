Public Class LessonMatIntroductory


    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Delete"
        MessageBox1.Message.Text = "Successfully Deleted !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Lesson File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Lesson File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Lesson File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Lesson File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UploadFile.Show()
        UploadFile.LabelHeading.Text = "Lesson File Upload"
        UploadFile.Label1.Text = "File Name"
        UploadFile.Label2.Text = "File"
    End Sub
End Class