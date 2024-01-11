Public Class FormEdit

    Private errorProvider As New ErrorProvider()
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        errorProvider.Clear()
        If String.IsNullOrEmpty(TextBox1.Text.Trim) Then
            errorProvider.SetError(TextBox1, "Please enter a value")
            TextBox1.Focus()
        End If

        If String.IsNullOrEmpty(TextBox2.Text.Trim) Then
            errorProvider.SetError(TextBox2, "Please enter a value")
            TextBox2.Focus()
        End If

        If String.IsNullOrEmpty(TextBox3.Text.Trim) Then
            errorProvider.SetError(TextBox3, "Please enter a value")
            TextBox3.Focus()
        End If

        If String.IsNullOrEmpty(TextBox4.Text.Trim) Then
            errorProvider.SetError(TextBox4, "Please enter a value")
            TextBox4.Focus()
        End If

        If errorProvider.GetError(TextBox1) <> "" OrElse
                errorProvider.GetError(TextBox2) <> "" OrElse
                errorProvider.GetError(TextBox3) <> "" OrElse
                errorProvider.GetError(TextBox4) <> "" Then

            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Error Null Values"
            MessageBox1.Message.Text = "Form has null values !"
            MessageBox1.MessageButton.Text = "Ok"
        Else
            Me.Hide()
            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Form Submitted"
            MessageBox1.Message.Text = "Successfully Submitted !"
            MessageBox1.MessageButton.Text = "Ok"
            DashboardAdmin.Show()

        End If

    End Sub
End Class