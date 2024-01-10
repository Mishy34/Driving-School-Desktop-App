Public Class InsDetails
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

        FormEdit.Show()
            FormEdit.LabelHeading.Text = "Instructor Details"
            FormEdit.Label1.Text = "Name"
            FormEdit.Label2.Text = "Contact No:"
            FormEdit.Label3.Text = "No of Students"
        FormEdit.Label4.Text = "Payment Status"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        FormEdit.Show()
            FormEdit.LabelHeading.Text = "Instructor Details"
            FormEdit.Label1.Text = "Name"
            FormEdit.Label2.Text = "Contact No:"
            FormEdit.Label3.Text = "No of Students"
            FormEdit.Label4.Text = "Payment Status"
            FormEdit.TextBox1.Text = "Instructor 1"
            FormEdit.TextBox2.Text = "+44 7667567654"
            FormEdit.TextBox3.Text = "20"
            FormEdit.TextBox4.Text = "Completed"



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FormEdit.Show()
            FormEdit.LabelHeading.Text = "Instructor Details"
            FormEdit.Label1.Text = "Name"
            FormEdit.Label2.Text = "Contact No:"
            FormEdit.Label3.Text = "No of Students"
            FormEdit.Label4.Text = "Payment Status"
            FormEdit.TextBox1.Text = "Instructor 2"
            FormEdit.TextBox2.Text = "+44 7667567654"
            FormEdit.TextBox3.Text = "10"
            FormEdit.TextBox4.Text = "Completed"

    End Sub

End Class