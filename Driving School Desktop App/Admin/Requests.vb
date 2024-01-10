Public Class Requests
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim parentForm As DashboardAdmin = TryCast(Me.ParentForm, DashboardAdmin)

        ' Check if the parent form reference is not null and if the panel exists
        If parentForm IsNot Nothing AndAlso parentForm.PanelDesktop IsNot Nothing Then
            StudentReq.TopLevel = False
            StudentReq.Dock = DockStyle.Fill
            parentForm.PanelDesktop.Controls.Clear()
            parentForm.PanelDesktop.Controls.Add(StudentReq)
            StudentReq.Show()
        End If
    End Sub

End Class