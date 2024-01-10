Public Class MessageBox2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Cancel" Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button1.Text = "Book" Then
            Me.Hide()
            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Booking Request"
            MessageBox1.Message.Text = "Your request is submitted ! Administration will contact you soon !"
            MessageBox1.MessageButton.Text = "Ok"
        End If
    End Sub
End Class