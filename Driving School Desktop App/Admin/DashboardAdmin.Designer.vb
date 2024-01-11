<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdmin))
        PanelRibbon = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        labelcurrentForm = New Label()
        iconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelMenu = New Panel()
        BtnRequests = New FontAwesome.Sharp.IconButton()
        btnProgress = New FontAwesome.Sharp.IconButton()
        btnLessons = New FontAwesome.Sharp.IconButton()
        btnSchedules = New FontAwesome.Sharp.IconButton()
        btnInstructors = New FontAwesome.Sharp.IconButton()
        btnStudents = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelDesktop = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PanelRibbon.SuspendLayout()
        CType(iconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelRibbon
        ' 
        PanelRibbon.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        PanelRibbon.Controls.Add(PictureBox2)
        PanelRibbon.Controls.Add(Label2)
        PanelRibbon.Controls.Add(Label1)
        PanelRibbon.Controls.Add(labelcurrentForm)
        PanelRibbon.Controls.Add(iconCurrentForm)
        PanelRibbon.Dock = DockStyle.Top
        PanelRibbon.Location = New Point(0, 0)
        PanelRibbon.Name = "PanelRibbon"
        PanelRibbon.Size = New Size(1500, 80)
        PanelRibbon.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1315, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 36)
        Label2.TabIndex = 5
        Label2.Text = "Admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1218, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 36)
        Label1.TabIndex = 4
        Label1.Text = "Logout"
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
        PanelMenu.Controls.Add(BtnRequests)
        PanelMenu.Controls.Add(btnProgress)
        PanelMenu.Controls.Add(btnLessons)
        PanelMenu.Controls.Add(btnSchedules)
        PanelMenu.Controls.Add(btnInstructors)
        PanelMenu.Controls.Add(btnStudents)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 80)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(375, 870)
        PanelMenu.TabIndex = 1
        ' 
        ' BtnRequests
        ' 
        BtnRequests.Dock = DockStyle.Top
        BtnRequests.FlatAppearance.BorderSize = 0
        BtnRequests.FlatStyle = FlatStyle.Flat
        BtnRequests.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRequests.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        BtnRequests.IconChar = FontAwesome.Sharp.IconChar.CommentDots
        BtnRequests.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        BtnRequests.IconFont = FontAwesome.Sharp.IconFont.Solid
        BtnRequests.IconSize = 50
        BtnRequests.ImageAlign = ContentAlignment.MiddleLeft
        BtnRequests.Location = New Point(0, 715)
        BtnRequests.Name = "BtnRequests"
        BtnRequests.Padding = New Padding(10, 0, 20, 0)
        BtnRequests.Size = New Size(375, 103)
        BtnRequests.TabIndex = 6
        BtnRequests.Text = "Requests"
        BtnRequests.TextAlign = ContentAlignment.MiddleLeft
        BtnRequests.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnRequests.UseVisualStyleBackColor = True
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
        btnProgress.Location = New Point(0, 612)
        btnProgress.Name = "btnProgress"
        btnProgress.Padding = New Padding(10, 0, 20, 0)
        btnProgress.Size = New Size(375, 103)
        btnProgress.TabIndex = 5
        btnProgress.Text = "Progress upload"
        btnProgress.TextAlign = ContentAlignment.MiddleLeft
        btnProgress.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProgress.UseVisualStyleBackColor = True
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
        btnLessons.Location = New Point(0, 509)
        btnLessons.Name = "btnLessons"
        btnLessons.Padding = New Padding(10, 0, 20, 0)
        btnLessons.Size = New Size(375, 103)
        btnLessons.TabIndex = 4
        btnLessons.Text = "Lessons"
        btnLessons.TextAlign = ContentAlignment.MiddleLeft
        btnLessons.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLessons.UseVisualStyleBackColor = True
        ' 
        ' btnSchedules
        ' 
        btnSchedules.Dock = DockStyle.Top
        btnSchedules.FlatAppearance.BorderSize = 0
        btnSchedules.FlatStyle = FlatStyle.Flat
        btnSchedules.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSchedules.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnSchedules.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        btnSchedules.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnSchedules.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSchedules.IconSize = 50
        btnSchedules.ImageAlign = ContentAlignment.MiddleLeft
        btnSchedules.Location = New Point(0, 406)
        btnSchedules.Name = "btnSchedules"
        btnSchedules.Padding = New Padding(10, 0, 20, 0)
        btnSchedules.Size = New Size(375, 103)
        btnSchedules.TabIndex = 3
        btnSchedules.Text = "Schedules"
        btnSchedules.TextAlign = ContentAlignment.MiddleLeft
        btnSchedules.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSchedules.UseVisualStyleBackColor = True
        ' 
        ' btnInstructors
        ' 
        btnInstructors.Dock = DockStyle.Top
        btnInstructors.FlatAppearance.BorderSize = 0
        btnInstructors.FlatStyle = FlatStyle.Flat
        btnInstructors.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstructors.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnInstructors.IconChar = FontAwesome.Sharp.IconChar.ChalkboardUser
        btnInstructors.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnInstructors.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnInstructors.IconSize = 50
        btnInstructors.ImageAlign = ContentAlignment.MiddleLeft
        btnInstructors.Location = New Point(0, 303)
        btnInstructors.Name = "btnInstructors"
        btnInstructors.Padding = New Padding(10, 0, 20, 0)
        btnInstructors.Size = New Size(375, 103)
        btnInstructors.TabIndex = 2
        btnInstructors.Text = "Instructors"
        btnInstructors.TextAlign = ContentAlignment.MiddleLeft
        btnInstructors.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInstructors.UseVisualStyleBackColor = True
        ' 
        ' btnStudents
        ' 
        btnStudents.Dock = DockStyle.Top
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Neue Haas Unica Med", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudents.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        btnStudents.IconColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        btnStudents.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnStudents.IconSize = 50
        btnStudents.ImageAlign = ContentAlignment.MiddleLeft
        btnStudents.Location = New Point(0, 200)
        btnStudents.Name = "btnStudents"
        btnStudents.Padding = New Padding(10, 0, 20, 0)
        btnStudents.Size = New Size(375, 103)
        btnStudents.TabIndex = 1
        btnStudents.Text = "Students"
        btnStudents.TextAlign = ContentAlignment.MiddleLeft
        btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStudents.UseVisualStyleBackColor = True
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
        imgHome.Location = New Point(-61, -33)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(482, 277)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(375, 80)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1125, 870)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1125, 870)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1421, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(49, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 950)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelMenu)
        Controls.Add(PanelRibbon)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        PanelRibbon.ResumeLayout(False)
        PanelRibbon.PerformLayout()
        CType(iconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelRibbon As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnStudents As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProgress As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLessons As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSchedules As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInstructors As FontAwesome.Sharp.IconButton
    Friend WithEvents iconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents labelcurrentForm As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRequests As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
