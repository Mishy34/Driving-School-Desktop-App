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
        subHeading = New Label()
        Heading = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' subHeading
        ' 
        subHeading.AutoSize = True
        subHeading.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subHeading.ForeColor = Color.Black
        subHeading.Location = New Point(135, 56)
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
        Heading.Location = New Point(48, 125)
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
        Label1.Location = New Point(48, 462)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 56)
        Label1.TabIndex = 11
        Label1.Text = "Exam schedule"
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 870)
        Controls.Add(Label1)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "Schedule"
        Text = "Schedule"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents subHeading As Label
    Friend WithEvents Heading As Label
    Friend WithEvents Label1 As Label
End Class
