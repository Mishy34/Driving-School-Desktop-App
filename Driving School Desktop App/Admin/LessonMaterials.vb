Imports System.Windows.Controls

Public Class LessonMaterials
    Private Sub btnIntroductory_Click(sender As Object, e As EventArgs) Handles btnIntroductory.Click
        Me.Hide()
        Dim parentForm As Dashboard = TryCast(Me.ParentForm, Dashboard)

        ' Check if the parent form reference is not null and if the panel exists
        If parentForm IsNot Nothing AndAlso parentForm.PanelDesktop IsNot Nothing Then
            LessonMatIntroductory.TopLevel = False
            LessonMatIntroductory.Dock = DockStyle.Fill
            parentForm.PanelDesktop.Controls.Clear()
            parentForm.PanelDesktop.Controls.Add(LessonMatIntroductory)
            LessonMatIntroductory.Show()
        End If

    End Sub
End Class