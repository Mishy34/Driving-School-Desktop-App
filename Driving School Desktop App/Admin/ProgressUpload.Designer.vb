<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgressUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgressUpload))
        Heading = New Label()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
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
        IconButton1 = New FontAwesome.Sharp.IconButton()
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
        Heading.Size = New Size(320, 56)
        Heading.TabIndex = 8
        Heading.Text = "Progress Upload"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(36, 105)
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Titillium Web", 8.999999F)
        Label9.Location = New Point(602, 64)
        Label9.Name = "Label9"
        Label9.Size = New Size(147, 36)
        Label9.TabIndex = 8
        Label9.Text = "Student1.pdf"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Titillium Web", 8.999999F)
        Label8.Location = New Point(403, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 36)
        Label8.TabIndex = 7
        Label8.Text = "Instructor 1"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Titillium Web", 8.999999F)
        Label7.Location = New Point(204, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 36)
        Label7.TabIndex = 6
        Label7.Text = "Instroductory"
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
        Label4.Text = "Progress File"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label3.Location = New Point(403, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 60)
        Label3.TabIndex = 2
        Label3.Text = "Instructor"
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
        Label2.Text = "Lesson type"
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
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackgroundImage = CType(resources.GetObject("IconButton1.BackgroundImage"), Image)
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Titillium Web", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(846, 710)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(182, 61)
        IconButton1.TabIndex = 11
        IconButton1.Text = "Upload"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' ProgressUpload
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(IconButton1)
        Controls.Add(Panel1)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "ProgressUpload"
        Text = "StudentDetails"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
