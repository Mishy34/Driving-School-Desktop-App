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
End Class