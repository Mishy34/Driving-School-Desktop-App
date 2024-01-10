<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MngSchedule
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
        Heading = New Label()
        btnAddStudent = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button2 = New Button()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(36, 29)
        Heading.Name = "Heading"
        Heading.Size = New Size(213, 56)
        Heading.TabIndex = 8
        Heading.Text = "Schedules"
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        btnAddStudent.FlatAppearance.BorderSize = 0
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Neue Haas Unica", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddStudent.ForeColor = Color.White
        btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus
        btnAddStudent.IconColor = Color.White
        btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddStudent.Location = New Point(41, 102)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(234, 56)
        btnAddStudent.TabIndex = 9
        btnAddStudent.Text = "Add schedule"
        btnAddStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(36, 182)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(997, 583)
        Panel1.TabIndex = 10
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(Button2, 4, 2)
        TableLayoutPanel1.Controls.Add(Label14, 3, 2)
        TableLayoutPanel1.Controls.Add(Label13, 2, 2)
        TableLayoutPanel1.Controls.Add(Label12, 1, 2)
        TableLayoutPanel1.Controls.Add(Label11, 0, 2)
        TableLayoutPanel1.Controls.Add(Label9, 3, 1)
        TableLayoutPanel1.Controls.Add(Label8, 2, 1)
        TableLayoutPanel1.Controls.Add(Label7, 1, 1)
        TableLayoutPanel1.Controls.Add(Label5, 4, 0)
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 1)
        TableLayoutPanel1.Controls.Add(Button1, 4, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.Size = New Size(997, 583)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Titillium Web", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(801, 139)
        Button2.Name = "Button2"
        Button2.Size = New Size(191, 64)
        Button2.TabIndex = 31
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Titillium Web", 8.999999F)
        Label14.Location = New Point(602, 136)
        Label14.Name = "Label14"
        Label14.Size = New Size(138, 36)
        Label14.TabIndex = 13
        Label14.Text = "Introduction"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Titillium Web", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(403, 136)
        Label13.Name = "Label13"
        Label13.Size = New Size(133, 64)
        Label13.TabIndex = 12
        Label13.Text = "20-03-2024 9:00AM"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Titillium Web", 8.999999F)
        Label12.Location = New Point(204, 136)
        Label12.Name = "Label12"
        Label12.Size = New Size(131, 36)
        Label12.TabIndex = 11
        Label12.Text = "Instructor 2"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Titillium Web", 8.999999F)
        Label11.Location = New Point(5, 136)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 36)
        Label11.TabIndex = 10
        Label11.Text = "Student 2"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Titillium Web", 8.999999F)
        Label9.Location = New Point(602, 64)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 36)
        Label9.TabIndex = 8
        Label9.Text = "Introduction"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Titillium Web", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(403, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 64)
        Label8.TabIndex = 7
        Label8.Text = "20-03-2024 9:00AM"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Titillium Web", 8.999999F)
        Label7.Location = New Point(204, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 36)
        Label7.TabIndex = 6
        Label7.Text = "Instructor 1"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(801, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 60)
        Label5.TabIndex = 4
        Label5.Text = "Controls"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Neue Haas Unica Med", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label4.Location = New Point(602, 2)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 60)
        Label4.TabIndex = 3
        Label4.Text = "Lesson Name"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Neue Haas Unica Med", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label3.Location = New Point(403, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 60)
        Label3.TabIndex = 2
        Label3.Text = "Date and Time"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label1.Location = New Point(5, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 60)
        Label1.TabIndex = 0
        Label1.Text = "Student Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(204, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 60)
        Label2.TabIndex = 1
        Label2.Text = "Instructor"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Titillium Web", 8.999999F)
        Label6.Location = New Point(5, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 36)
        Label6.TabIndex = 5
        Label6.Text = "Student 1"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Titillium Web", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(801, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 64)
        Button1.TabIndex = 30
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MngSchedule
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(Panel1)
        Controls.Add(btnAddStudent)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "MngSchedule"
        Text = "Schedules"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents btnAddStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
