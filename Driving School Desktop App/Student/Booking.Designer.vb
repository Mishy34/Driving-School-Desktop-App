﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking

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
        subHeading = New Label()
        Panel1 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(434, 69)
        Heading.Name = "Heading"
        Heading.Size = New Size(190, 56)
        Heading.TabIndex = 7
        Heading.Text = "Bookings"
        ' 
        ' subHeading
        ' 
        subHeading.AutoSize = True
        subHeading.Font = New Font("Titillium Web", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subHeading.ForeColor = Color.Black
        subHeading.Location = New Point(301, 149)
        subHeading.Name = "subHeading"
        subHeading.Size = New Size(471, 46)
        subHeading.TabIndex = 8
        subHeading.Text = "Book your exams and lessons here !"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(IconButton1)
        Panel1.Location = New Point(32, 247)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1032, 195)
        Panel1.TabIndex = 9
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        IconButton1.Dock = DockStyle.Left
        IconButton1.Font = New Font("Neue Haas Unica Med", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.ChalkboardUser
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 70
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 0)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 0, 0)
        IconButton1.Size = New Size(394, 195)
        IconButton1.TabIndex = 0
        IconButton1.Text = "Lesson Bookings"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseMnemonic = False
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(IconButton2)
        Panel2.Location = New Point(32, 502)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 195)
        Panel2.TabIndex = 10
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        IconButton2.Dock = DockStyle.Left
        IconButton2.Font = New Font("Neue Haas Unica Med", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton2.ForeColor = Color.White
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        IconButton2.IconColor = Color.White
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 70
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(0, 0)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(10, 0, 0, 0)
        IconButton2.Size = New Size(394, 195)
        IconButton2.TabIndex = 1
        IconButton2.Text = "Exam Bookings"
        IconButton2.TextAlign = ContentAlignment.MiddleLeft
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseMnemonic = False
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(394, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(638, 195)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(394, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(638, 195)
        Panel4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(210, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 32)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(248, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 32)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Booking
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "Booking"
        Text = "Instructor"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents subHeading As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
