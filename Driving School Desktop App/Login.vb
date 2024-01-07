Public Class Login

    Private clickCount As Integer = 0
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If TxtEmail.Text = "jaky@gmail.com" And TxtPassword.Text = "Newpw@123" Then
            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Successfull Login"
            MessageBox1.Message.Text = "You are successfully logged in !"
            MessageBox1.MessageButton.Text = "Ok"
            Me.Hide()
        Else
            MessageBox1.Show()
            MessageBox1.MessageName.Text = "Incorrect credentials"
            MessageBox1.Message.Text = "Your username or password is incorrect !"
            MessageBox1.MessageButton.Text = "Retry"
        End If


    End Sub
    Private Sub btnPwUnhide_Click(sender As Object, e As EventArgs) Handles btnPwUnhide.Click
        clickCount += 1

        If clickCount Mod 2 = 1 Then
            TxtPassword.UseSystemPasswordChar = True
            btnPwUnhide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            TxtPassword.UseSystemPasswordChar = False
            btnPwUnhide.IconChar = FontAwesome.Sharp.IconChar.Eye

        End If

    End Sub
End Class
