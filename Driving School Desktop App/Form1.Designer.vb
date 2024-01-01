<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Titillium Web", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(945, 222)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 48)
        Label1.TabIndex = 0
        Label1.Text = "Get started from login below !"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(945, 372)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(418, 65)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(945, 486)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(418, 65)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Titillium Web", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1009, 283)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 36)
        Label2.TabIndex = 3
        Label2.Text = "New to Pass IT? "
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(247), CByte(129), CByte(44))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Titillium Web", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(1028, 387)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Email address"
        TextBox1.Size = New Size(314, 49)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(247), CByte(129), CByte(44))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Titillium Web", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(1028, 501)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(314, 49)
        TextBox2.TabIndex = 5
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(247), CByte(126), CByte(44))
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.User
        IconButton1.IconColor = Color.Gray
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton1.Location = New Point(958, 381)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(64, 46)
        IconButton1.TabIndex = 6
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.FromArgb(CByte(247), CByte(126), CByte(44))
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Key
        IconButton2.IconColor = Color.Gray
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton2.Location = New Point(958, 496)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(64, 46)
        IconButton2.TabIndex = 7
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackgroundImage = CType(resources.GetObject("IconButton3.BackgroundImage"), Image)
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Titillium Web", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton3.ForeColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.Location = New Point(1009, 674)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(269, 70)
        IconButton3.TabIndex = 8
        IconButton3.Text = "Login"
        IconButton3.TextAlign = ContentAlignment.TopCenter
        IconButton3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Titillium Web", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(958, 565)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 36)
        Label3.TabIndex = 9
        Label3.Text = "Forget password?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Titillium Web", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1145, 565)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 36)
        Label4.TabIndex = 10
        Label4.Text = "Reset"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Titillium Web", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1176, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 36)
        Label5.TabIndex = 11
        Label5.Text = "Register"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1500, 950)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(IconButton3)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
