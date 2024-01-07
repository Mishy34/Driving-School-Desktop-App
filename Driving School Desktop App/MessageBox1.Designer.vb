<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBox1))
        Panel1 = New Panel()
        MessageName = New Label()
        Panel2 = New Panel()
        Message = New Label()
        MessageButton = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel1.Controls.Add(MessageName)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 73)
        Panel1.TabIndex = 0
        ' 
        ' MessageName
        ' 
        MessageName.AutoSize = True
        MessageName.Font = New Font("Neue Haas Unica Med", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MessageName.ForeColor = Color.White
        MessageName.Location = New Point(9, 7)
        MessageName.Name = "MessageName"
        MessageName.Size = New Size(148, 57)
        MessageName.TabIndex = 1
        MessageName.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(11, 398)
        Panel2.TabIndex = 3
        ' 
        ' Message
        ' 
        Message.AutoSize = True
        Message.Font = New Font("Titillium Web", 10.874999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Message.ForeColor = Color.FromArgb(CByte(56), CByte(58), CByte(54))
        Message.Location = New Point(42, 166)
        Message.Name = "Message"
        Message.Size = New Size(103, 44)
        Message.TabIndex = 1
        Message.Text = "Label2"
        ' 
        ' MessageButton
        ' 
        MessageButton.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        MessageButton.BackgroundImage = CType(resources.GetObject("MessageButton.BackgroundImage"), Image)
        MessageButton.FlatAppearance.BorderSize = 0
        MessageButton.FlatStyle = FlatStyle.Flat
        MessageButton.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MessageButton.ForeColor = Color.FromArgb(CByte(56), CByte(58), CByte(54))
        MessageButton.IconChar = FontAwesome.Sharp.IconChar.None
        MessageButton.IconColor = Color.Black
        MessageButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        MessageButton.Location = New Point(220, 292)
        MessageButton.Name = "MessageButton"
        MessageButton.Size = New Size(176, 57)
        MessageButton.TabIndex = 2
        MessageButton.Text = "IconButton1"
        MessageButton.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel3.Location = New Point(621, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(11, 398)
        Panel3.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Panel4.Location = New Point(4, 387)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(632, 11)
        Panel4.TabIndex = 5
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' MessageBox1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(632, 398)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(MessageButton)
        Controls.Add(Message)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MessageBox1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MessageBox1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MessageName As Label
    Friend WithEvents Message As Label
    Friend WithEvents MessageButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Timer1 As Timer
End Class
