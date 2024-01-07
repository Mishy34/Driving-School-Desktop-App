<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lessons
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
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Location = New Point(51, 269)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(299, 405)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(591, -75)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(400, 200)
        Panel4.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(299, 92)
        Panel5.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(16, 313)
        Panel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(283, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(16, 313)
        Panel3.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(16, 389)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(267, 16)
        Panel6.TabIndex = 4
        ' 
        ' Lessons
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1125, 870)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Lessons"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
End Class
