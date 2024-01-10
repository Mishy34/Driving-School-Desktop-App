Public Class MngSchedule
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

        FormEdit.Show()
        FormEdit.LabelHeading.Text = "Schedule Details"
        FormEdit.Label1.Text = "Student Name"
        FormEdit.Label2.Text = "Instructor"
        FormEdit.Label3.Text = "Date and Time"
        FormEdit.Label4.Text = "Lesson Name"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FormEdit.Show()
            FormEdit.LabelHeading.Text = "Schedule Details"
            FormEdit.Label1.Text = "Student Name"
            FormEdit.Label2.Text = "Instructor"
            FormEdit.Label3.Text = "Date and Time"
            FormEdit.Label4.Text = "Lesson Name"
            FormEdit.TextBox1.Text = "Student 1"
            FormEdit.TextBox2.Text = "Instructor 1"
            FormEdit.TextBox3.Text = "20 - 3 - 2024 9:00 AM"
            FormEdit.TextBox4.Text = "Instroduction"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FormEdit.Show()
            FormEdit.LabelHeading.Text = "Schedule Details"
            FormEdit.Label1.Text = "Student Name"
            FormEdit.Label2.Text = "Instructor"
            FormEdit.Label3.Text = "Date and Time"
            FormEdit.Label4.Text = "Lesson Name"
            FormEdit.TextBox1.Text = "Student 2"
            FormEdit.TextBox2.Text = "Instructor 2"
            FormEdit.TextBox3.Text = "20 - 3 - 2024 9:00 AM"
            FormEdit.TextBox4.Text = "Instroduction"


    End Sub
End Class