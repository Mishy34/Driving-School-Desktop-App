Public Class BookingLessons
    Private Sub Introductory_Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Successfull booked"
        MessageBox1.Message.Text = "Your booking is successfull !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Successfull booked"
        MessageBox1.Message.Text = "Your booking is successfull !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Successfull booked"
        MessageBox1.Message.Text = "Your booking is successfull !"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub
End Class