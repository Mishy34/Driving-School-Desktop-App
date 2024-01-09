<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructor
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
        Panel1 = New Panel()
        Heading = New Label()
        subHeading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(28, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(435, 767)
        Panel1.TabIndex = 0
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(503, 42)
        Heading.Name = "Heading"
        Heading.Size = New Size(442, 56)
        Heading.TabIndex = 8
        Heading.Text = "Contact your instructor"
        ' 
        ' subHeading
        ' 
        subHeading.AutoSize = True
        subHeading.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subHeading.ForeColor = Color.Black
        subHeading.Location = New Point(503, 145)
        subHeading.Name = "subHeading"
        subHeading.Size = New Size(154, 46)
        subHeading.TabIndex = 9
        subHeading.Text = "Your name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(503, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 46)
        Label1.TabIndex = 10
        Label1.Text = "Your email address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(503, 433)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 46)
        Label2.TabIndex = 11
        Label2.Text = "Your message"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(676, 739)
        Button1.Name = "Button1"
        Button1.Size = New Size(269, 70)
        Button1.TabIndex = 12
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Instructor
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 870)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Instructor"
        Text = "Instructor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Heading As Label
    Friend WithEvents subHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
