Imports FontAwesome.Sharp
Public Class DashboardAdmin
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 103)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        'Me.Text = String.Empty
        'Me.ControlBox = False
        'Me.DoubleBuffered = True
        'Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.White
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            iconCurrentForm.IconChar = currentBtn.IconChar
            iconCurrentForm.IconColor = Color.White
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.White
            currentBtn.ForeColor = Color.FromArgb(128, 123, 132)
            currentBtn.IconColor = Color.FromArgb(128, 123, 132)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        labelcurrentForm.Text = childForm.Text
    End Sub

    Private Sub btnLessons_Click(sender As Object, e As EventArgs) Handles btnLessons.Click
        ActivateButton(sender, Color.FromArgb(246, 107, 7))
        OpenChildForm(New Lessons)
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        ActivateButton(sender, Color.FromArgb(246, 107, 7))
        OpenChildForm(New Schedule)
    End Sub

    Private Sub btnProgress_Click(sender As Object, e As EventArgs) Handles btnProgress.Click
        ActivateButton(sender, Color.FromArgb(246, 107, 7))
        OpenChildForm(New Progress)
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        ActivateButton(sender, Color.FromArgb(246, 107, 7))
        OpenChildForm(New BookingLessons)
    End Sub

    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        ActivateButton(sender, Color.FromArgb(246, 107, 7))
        OpenChildForm(New Instructor)
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        iconCurrentForm.IconChar = IconChar.Home
        iconCurrentForm.IconColor = Color.White
        labelcurrentForm.Text = "Home"
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub


End Class