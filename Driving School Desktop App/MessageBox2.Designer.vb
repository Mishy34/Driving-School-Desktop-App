<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBox2))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        MessageName = New Label()
        Message = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 387)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 11)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(11, 387)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(621, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(11, 387)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel4.Controls.Add(MessageName)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(11, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(610, 73)
        Panel4.TabIndex = 3
        ' 
        ' MessageName
        ' 
        MessageName.AutoSize = True
        MessageName.Font = New Font("Neue Haas Unica ExtBd", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MessageName.ForeColor = Color.White
        MessageName.Location = New Point(6, 9)
        MessageName.Name = "MessageName"
        MessageName.Size = New Size(145, 56)
        MessageName.TabIndex = 4
        MessageName.Text = "Label1"
        ' 
        ' Message
        ' 
        Message.AutoSize = True
        Message.Font = New Font("Titillium Web", 10.874999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Message.ForeColor = Color.FromArgb(CByte(56), CByte(58), CByte(54))
        Message.Location = New Point(49, 151)
        Message.Name = "Message"
        Message.Size = New Size(103, 44)
        Message.TabIndex = 4
        Message.Text = "Label2"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Neue Haas Unica ExtBd", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(56), CByte(58), CByte(54))
        Button2.Location = New Point(339, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(176, 57)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Neue Haas Unica ExtBd", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(56), CByte(58), CByte(54))
        Button1.Location = New Point(119, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 57)
        Button1.TabIndex = 7
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MessageBox2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(632, 398)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Message)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MessageBox2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MessageBox2"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MessageName As Label
    Friend WithEvents Message As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
