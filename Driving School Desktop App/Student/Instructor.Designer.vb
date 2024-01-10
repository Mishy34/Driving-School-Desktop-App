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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructor))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Heading = New Label()
        subHeading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(28, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(435, 767)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(435, 767)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(503, 69)
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
        Label2.Location = New Point(503, 415)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 46)
        Label2.TabIndex = 11
        Label2.Text = "Your message"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Titillium Web", 10.874999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(636, 761)
        Button1.Name = "Button1"
        Button1.Size = New Size(269, 70)
        Button1.TabIndex = 12
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(503, 194)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(553, 67)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(503, 330)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(553, 67)
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox3)
        Panel2.Location = New Point(503, 477)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(553, 258)
        Panel2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(13, 3)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(528, 252)
        TextBox3.TabIndex = 18
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(516, 209)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(528, 32)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(516, 345)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(528, 32)
        TextBox2.TabIndex = 17
        ' 
        ' Instructor
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(subHeading)
        Controls.Add(Heading)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Instructor"
        Text = "Instructor"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Heading As Label
    Friend WithEvents subHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
