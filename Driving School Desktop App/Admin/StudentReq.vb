Public Class StudentReq
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()

        Dim parentForm As DashboardAdmin = TryCast(Me.ParentForm, DashboardAdmin)

        ' Check if the parent form reference is not null and if the panel exists
        If parentForm IsNot Nothing AndAlso parentForm.PanelDesktop IsNot Nothing Then
            Requests.TopLevel = False
            Requests.Dock = DockStyle.Fill
            parentForm.PanelDesktop.Controls.Clear()
            parentForm.PanelDesktop.Controls.Add(Requests)
            Requests.Show()
        End If
    End Sub
End Class