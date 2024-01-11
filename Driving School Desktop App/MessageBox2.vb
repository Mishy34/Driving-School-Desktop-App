Public Class MessageBox2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Cancel" Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Book" Then
            Me.Hide()
            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Booking Request"
            MessageBox1.Message.Text = "Your request is submitted! Admin will contact you!"
            MessageBox1.MessageButton.Text = "Ok"

        ElseIf Button2.Text = "Yes" Then
            Application.ExitThread()
        End If
    End Sub
End Class