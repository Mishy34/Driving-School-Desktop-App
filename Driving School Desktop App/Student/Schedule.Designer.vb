<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
        subHeading = New Label()
        Heading = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel2 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label16 = New Label()
        Label15 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' subHeading
        ' 
        subHeading.AutoSize = True
        subHeading.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subHeading.ForeColor = Color.Black
        subHeading.Location = New Point(132, 42)
        subHeading.Name = "subHeading"
        subHeading.Size = New Size(842, 46)
        subHeading.TabIndex = 10
        subHeading.Text = "If you want to change your schedule, click on the request button !"
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(45, 110)
        Heading.Name = "Heading"
        Heading.Size = New Size(328, 56)
        Heading.TabIndex = 9
        Heading.Text = "Lesson schedule"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Label1.Location = New Point(45, 436)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 56)
        Label1.TabIndex = 11
        Label1.Text = "Exam schedule"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(48, 170)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(972, 257)
        Panel1.TabIndex = 12
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label8, 0, 2)
        TableLayoutPanel1.Controls.Add(Label7, 0, 2)
        TableLayoutPanel1.Controls.Add(Label5, 0, 2)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 1)
        TableLayoutPanel1.Controls.Add(Label9, 1, 1)
        TableLayoutPanel1.Controls.Add(Label10, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(972, 257)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Font = New Font("Titillium Web", 8.999999F)
        Label8.Location = New Point(6, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(313, 93)
        Label8.TabIndex = 11
        Label8.Text = "Label8"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Titillium Web", 8.999999F)
        Label7.Location = New Point(328, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(314, 93)
        Label7.TabIndex = 10
        Label7.Text = "Label7"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Titillium Web", 8.999999F)
        Label5.Location = New Point(651, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 36)
        Label5.TabIndex = 9
        Label5.Text = "Label5"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(6, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(313, 60)
        Label2.TabIndex = 1
        Label2.Text = "Lesson Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label3.Location = New Point(328, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(314, 60)
        Label3.TabIndex = 7
        Label3.Text = "Date"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label4.Location = New Point(651, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 36)
        Label4.TabIndex = 8
        Label4.Text = "Time"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Titillium Web", 8.999999F)
        Label6.Location = New Point(6, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(313, 92)
        Label6.TabIndex = 6
        Label6.Text = "Label6"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Fill
        Label9.Location = New Point(328, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(314, 92)
        Label9.TabIndex = 12
        Label9.Text = "Label9"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Fill
        Label10.Location = New Point(651, 66)
        Label10.Name = "Label10"
        Label10.Size = New Size(315, 92)
        Label10.TabIndex = 13
        Label10.Text = "Label10"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Location = New Point(51, 499)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(972, 244)
        Panel2.TabIndex = 13
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.Controls.Add(Label16, 2, 1)
        TableLayoutPanel2.Controls.Add(Label15, 1, 1)
        TableLayoutPanel2.Controls.Add(Label11, 0, 0)
        TableLayoutPanel2.Controls.Add(Label13, 1, 0)
        TableLayoutPanel2.Controls.Add(Label12, 2, 0)
        TableLayoutPanel2.Controls.Add(Label14, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(972, 244)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Fill
        Label16.Location = New Point(651, 66)
        Label16.Name = "Label16"
        Label16.Size = New Size(315, 86)
        Label16.TabIndex = 6
        Label16.Text = "Label16"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Fill
        Label15.Location = New Point(328, 66)
        Label15.Name = "Label15"
        Label15.Size = New Size(314, 86)
        Label15.TabIndex = 5
        Label15.Text = "Label15"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label11.Location = New Point(6, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(313, 60)
        Label11.TabIndex = 1
        Label11.Text = "Exam Name"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Fill
        Label13.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label13.Location = New Point(328, 3)
        Label13.Name = "Label13"
        Label13.Size = New Size(314, 60)
        Label13.TabIndex = 3
        Label13.Text = "Date"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Fill
        Label12.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label12.Location = New Point(651, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(315, 60)
        Label12.TabIndex = 2
        Label12.Text = "Time"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Fill
        Label14.Location = New Point(6, 66)
        Label14.Name = "Label14"
        Label14.Size = New Size(313, 86)
        Label14.TabIndex = 4
        Label14.Text = "Label14"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' IconButton1
        ' 
        IconButton1.BackgroundImage = CType(resources.GetObject("IconButton1.BackgroundImage"), Image)
        IconButton1.Font = New Font("Titillium Web SemiBold", 10.874999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(724, 760)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(272, 63)
        IconButton1.TabIndex = 14
        IconButton1.Text = "Request Change"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(IconButton1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "Schedule"
        Text = "Schedules"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents subHeading As Label
    Friend WithEvents Heading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
