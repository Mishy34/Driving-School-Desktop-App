Public Class Introductory_Lessons
    Private Sub Introductory_Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Download"
        MessageBox1.Message.Text = "Successfully Downloaded !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Download"
        MessageBox1.Message.Text = "Successfully Downloaded !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Lesson Download"
        MessageBox1.Message.Text = "Successfully Downloaded !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox2.Show()
        MessageBox2.MessageName.Text = "Lesson Locked"
        MessageBox2.Message.Text = "This lesson is locked ! Click Book to unlock !"
        MessageBox2.Button1.Text = "Cancel"
        MessageBox2.Button1.Text = "Book"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox2.Show()
        MessageBox2.MessageName.Text = "Lesson Locked"
        MessageBox2.Message.Text = "This lesson is locked ! Click Book to unlock !"
        MessageBox2.Button1.Text = "Cancel"
        MessageBox2.Button1.Text = "Book"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox2.Show()
        MessageBox2.MessageName.Text = "Lesson Locked"
        MessageBox2.Message.Text = "This lesson is locked ! Click Book to unlock !"
        MessageBox2.Button1.Text = "Cancel"
        MessageBox2.Button1.Text = "Book"
    End Sub
End Class