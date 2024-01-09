<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress
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
        SuspendLayout()
        ' 
        ' subHeading
        ' 
        subHeading.AutoSize = True
        subHeading.Font = New Font("Titillium Web", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subHeading.ForeColor = Color.Black
        subHeading.Location = New Point(66, 130)
        subHeading.Name = "subHeading"
        subHeading.Size = New Size(907, 46)
        subHeading.TabIndex = 10
        subHeading.Text = "You are nearly there ! Contact your instructor if you have any concerns!"
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(66, 52)
        Heading.Name = "Heading"
        Heading.Size = New Size(272, 56)
        Heading.TabIndex = 9
        Heading.Text = "Your progress"
        ' 
        ' Progress
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 870)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "Progress"
        Text = "Progress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents subHeading As Label
    Friend WithEvents Heading As Label
End Class
