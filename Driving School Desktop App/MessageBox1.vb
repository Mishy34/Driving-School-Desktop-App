Public Class MessageBox1

    Public Property DashboardType As String

    Private Sub MessageButton_Click(sender As Object, e As EventArgs) Handles MessageButton.Click
        If MessageButton.Text = "Retry" Then
            Me.Hide()
        ElseIf MessageButton.Text = "Ok" Then
            Me.Hide()
            If DashboardType = "Admin" Then
                DashboardAdmin.Show()
            ElseIf DashboardType = "Student" Then
                Dashboard.Show()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BringToFront()

    End Sub
End Class