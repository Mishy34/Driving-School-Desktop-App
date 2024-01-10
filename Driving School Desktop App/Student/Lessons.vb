Imports System.Windows.Controls

Public Class Lessons
    Private Sub btnIntroductory_Click(sender As Object, e As EventArgs) Handles btnIntroductory.Click
        Me.Hide()
        Dim parentForm As Dashboard = TryCast(Me.ParentForm, Dashboard)

        ' Check if the parent form reference is not null and if the panel exists
        If parentForm IsNot Nothing AndAlso parentForm.PanelDesktop IsNot Nothing Then
            Introductory_Lessons.TopLevel = False
            Introductory_Lessons.Dock = DockStyle.Fill
            parentForm.PanelDesktop.Controls.Clear()
            parentForm.PanelDesktop.Controls.Add(Introductory_Lessons)
            Introductory_Lessons.Show()
        End If

    End Sub

    Private Sub btnStandard_Click(sender As Object, e As EventArgs) Handles btnStandard.Click
        MessageBox2.Show()
        MessageBox2.MessageName.Text = "Standard Lessons"
        MessageBox2.Message.Text = "You have not booked this lesson type !"
        MessageBox2.Button1.Text = "Cancel"
        MessageBox2.Button2.Text = "Book"
    End Sub

    Private Sub btnPassPlus_Click(sender As Object, e As EventArgs) Handles btnPassPlus.Click
        MessageBox2.Show()
        MessageBox2.MessageName.Text = "Pass plus Lessons"
        MessageBox2.Message.Text = "You have not booked this lesson type !"
        MessageBox2.Button1.Text = "Cancel"
        MessageBox2.Button2.Text = "Book"
    End Sub

    Private Sub btnDrivingTest_Click(sender As Object, e As EventArgs) Handles btnDrivingTest.Click
        MessageBox1.Show()
        MessageBox1.MessageName.Text = "Driving Test Request"
        MessageBox1.Message.Text = "Your request is submitted! Admin will contact you!"
        MessageBox1.MessageButton.Text = "Ok"
    End Sub
End Class