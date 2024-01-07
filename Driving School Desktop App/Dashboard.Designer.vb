<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        PanelRibbon = New Panel()
        labelcurrentForm = New Label()
        iconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelMenu = New Panel()
        btnInstructor = New FontAwesome.Sharp.IconButton()
        btnBooking = New FontAwesome.Sharp.IconButton()
        btnProgress = New FontAwesome.Sharp.IconButton()
        btnSchedule = New FontAwesome.Sharp.IconButton()
        btnLessons = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelDesktop = New Panel()
        PanelRibbon.SuspendLayout()
        CType(iconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelRibbon
        ' 
        PanelRibbon.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        PanelRibbon.Controls.Add(labelcurrentForm)
        PanelRibbon.Controls.Add(iconCurrentForm)
        PanelRibbon.Dock = DockStyle.Top
        PanelRibbon.Location = New Point(0, 0)
        PanelRibbon.Name = "PanelRibbon"
        PanelRibbon.Size = New Size(1500, 80)
        PanelRibbon.TabIndex = 0
        ' 
        ' labelcurrentForm
        ' 
        labelcurrentForm.AutoSize = True
        labelcurrentForm.Font = New Font("Titillium Web SemiBold", 10.124999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcurrentForm.ForeColor = Color.White
        labelcurrentForm.Location = New Point(96, 23)
        labelcurrentForm.Name = "labelcurrentForm"
        labelcurrentForm.Size = New Size(87, 41)
        labelcurrentForm.TabIndex = 3
        labelcurrentForm.Text = "Home"
        ' 
        ' iconCurrentForm
        ' 
        iconCurrentForm.BackColor = Color.Transparent
        iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney
        iconCurrentForm.IconColor = Color.White
        iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconCurrentForm.IconSize = 64
        iconCurrentForm.Location = New Point(26, 10)
        iconCurrentForm.Name = "iconCurrentForm"
        iconCurrentForm.Size = New Size(64, 64)
        iconCurrentForm.TabIndex = 2
        iconCurrentForm.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Controls.Add(btnInstructor)
        PanelMenu.Controls.Add(btnBooking)
        PanelMenu.Controls.Add(btnProgress)
        PanelMenu.Controls.Add(btnSchedule)
        PanelMenu.Controls.Add(btnLessons)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 80)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(375, 870)
        PanelMenu.TabIndex = 1
        ' 
        ' btnInstructor
        ' 
        btnInstructor.Dock = DockStyle.Top
        btnInstructor.FlatAppearance.BorderSize = 0
        btnInstructor.FlatStyle = FlatStyle.Flat
        btnInstructor.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstructor.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnInstructor.IconChar = FontAwesome.Sharp.IconChar.IdBadge
        btnInstructor.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnInstructor.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnInstructor.IconSize = 50
        btnInstructor.ImageAlign = ContentAlignment.MiddleLeft
        btnInstructor.Location = New Point(0, 612)
        btnInstructor.Name = "btnInstructor"
        btnInstructor.Padding = New Padding(10, 0, 20, 0)
        btnInstructor.Size = New Size(375, 103)
        btnInstructor.TabIndex = 5
        btnInstructor.Text = "Contact Instructor"
        btnInstructor.TextAlign = ContentAlignment.MiddleLeft
        btnInstructor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInstructor.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Dock = DockStyle.Top
        btnBooking.FlatAppearance.BorderSize = 0
        btnBooking.FlatStyle = FlatStyle.Flat
        btnBooking.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBooking.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnBooking.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        btnBooking.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnBooking.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnBooking.IconSize = 50
        btnBooking.ImageAlign = ContentAlignment.MiddleLeft
        btnBooking.Location = New Point(0, 509)
        btnBooking.Name = "btnBooking"
        btnBooking.Padding = New Padding(10, 0, 20, 0)
        btnBooking.Size = New Size(375, 103)
        btnBooking.TabIndex = 4
        btnBooking.Text = "Book a lesson"
        btnBooking.TextAlign = ContentAlignment.MiddleLeft
        btnBooking.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnProgress
        ' 
        btnProgress.Dock = DockStyle.Top
        btnProgress.FlatAppearance.BorderSize = 0
        btnProgress.FlatStyle = FlatStyle.Flat
        btnProgress.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProgress.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnProgress.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btnProgress.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnProgress.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnProgress.IconSize = 50
        btnProgress.ImageAlign = ContentAlignment.MiddleLeft
        btnProgress.Location = New Point(0, 406)
        btnProgress.Name = "btnProgress"
        btnProgress.Padding = New Padding(10, 0, 20, 0)
        btnProgress.Size = New Size(375, 103)
        btnProgress.TabIndex = 3
        btnProgress.Text = "Progress"
        btnProgress.TextAlign = ContentAlignment.MiddleLeft
        btnProgress.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProgress.UseVisualStyleBackColor = True
        ' 
        ' btnSchedule
        ' 
        btnSchedule.Dock = DockStyle.Top
        btnSchedule.FlatAppearance.BorderSize = 0
        btnSchedule.FlatStyle = FlatStyle.Flat
        btnSchedule.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSchedule.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnSchedule.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        btnSchedule.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnSchedule.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSchedule.IconSize = 50
        btnSchedule.ImageAlign = ContentAlignment.MiddleLeft
        btnSchedule.Location = New Point(0, 303)
        btnSchedule.Name = "btnSchedule"
        btnSchedule.Padding = New Padding(10, 0, 20, 0)
        btnSchedule.Size = New Size(375, 103)
        btnSchedule.TabIndex = 2
        btnSchedule.Text = "Schedules"
        btnSchedule.TextAlign = ContentAlignment.MiddleLeft
        btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSchedule.UseVisualStyleBackColor = True
        ' 
        ' btnLessons
        ' 
        btnLessons.Dock = DockStyle.Top
        btnLessons.FlatAppearance.BorderSize = 0
        btnLessons.FlatStyle = FlatStyle.Flat
        btnLessons.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLessons.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnLessons.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        btnLessons.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnLessons.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnLessons.IconSize = 50
        btnLessons.ImageAlign = ContentAlignment.MiddleLeft
        btnLessons.Location = New Point(0, 200)
        btnLessons.Name = "btnLessons"
        btnLessons.Padding = New Padding(10, 0, 20, 0)
        btnLessons.Size = New Size(375, 103)
        btnLessons.TabIndex = 1
        btnLessons.Text = "Lesson Materials"
        btnLessons.TextAlign = ContentAlignment.MiddleLeft
        btnLessons.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLessons.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(imgHome)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(375, 200)
        PanelLogo.TabIndex = 0
        ' 
        ' imgHome
        ' 
        imgHome.Image = CType(resources.GetObject("imgHome.Image"), Image)
        imgHome.Location = New Point(-62, -50)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(482, 277)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(375, 80)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1125, 870)
        PanelDesktop.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 950)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelMenu)
        Controls.Add(PanelRibbon)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        PanelRibbon.ResumeLayout(False)
        PanelRibbon.PerformLayout()
        CType(iconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelRibbon As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnLessons As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInstructor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBooking As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProgress As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSchedule As FontAwesome.Sharp.IconButton
    Friend WithEvents iconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents labelcurrentForm As Label
    Friend WithEvents PanelDesktop As Panel
End Class
