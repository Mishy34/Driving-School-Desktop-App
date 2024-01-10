<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentReq))
        LabelHeading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' LabelHeading
        ' 
        LabelHeading.AutoSize = True
        LabelHeading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        LabelHeading.Location = New Point(26, 33)
        LabelHeading.Name = "LabelHeading"
        LabelHeading.Size = New Size(310, 56)
        LabelHeading.TabIndex = 9
        LabelHeading.Text = "Request Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 41)
        Label1.TabIndex = 10
        Label1.Text = "Student Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 41)
        Label2.TabIndex = 11
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 400)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 41)
        Label3.TabIndex = 12
        Label3.Text = "Request Type"
        ' 
        ' IconButton1
        ' 
        IconButton1.BackgroundImage = CType(resources.GetObject("IconButton1.BackgroundImage"), Image)
        IconButton1.Font = New Font("Titillium Web SemiBold", 10.874999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(766, 720)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(179, 58)
        IconButton1.TabIndex = 18
        IconButton1.Text = "OK"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 542)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 41)
        Label4.TabIndex = 13
        Label4.Text = "Message"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(61, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 36)
        Label5.TabIndex = 19
        Label5.Text = "Student 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(61, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(232, 36)
        Label6.TabIndex = 20
        Label6.Text = "student1@gmail.com"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(61, 454)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 36)
        Label7.TabIndex = 21
        Label7.Text = "Book Pass plus"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Titillium Web", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(61, 599)
        Label8.Name = "Label8"
        Label8.Size = New Size(345, 36)
        Label8.TabIndex = 22
        Label8.Text = "I want to book pass plus lessons."
        ' 
        ' StudentReq
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(IconButton1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelHeading)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentReq"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InstructorForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
