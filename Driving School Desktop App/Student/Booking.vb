Public Class Booking
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        Dim parentForm As Dashboard = TryCast(Me.ParentForm, Dashboard)

        ' Check if the parent form reference is not null and if the panel exists
        If parentForm IsNot Nothing AndAlso parentForm.PanelDesktop IsNot Nothing Then
            BookingLessons.TopLevel = False
            BookingLessons.Dock = DockStyle.Fill
            parentForm.PanelDesktop.Controls.Clear()
            parentForm.PanelDesktop.Controls.Add(BookingLessons)
            BookingLessons.Show()
        End If

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
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

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Dim parentForm As Dashboard = TryCast(Me.ParentForm, Dashboard)

        ' Check if the parent form reference is not null and if the panel exists
        If ParentForm IsNot Nothing AndAlso ParentForm.PanelDesktop IsNot Nothing Then
            BookingLessons.TopLevel = False
            BookingLessons.Dock = DockStyle.Fill
            ParentForm.PanelDesktop.Controls.Clear()
            ParentForm.PanelDesktop.Controls.Add(BookingLessons)
            BookingLessons.Show()
        End If
    End Sub
End Class