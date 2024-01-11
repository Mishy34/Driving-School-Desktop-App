<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEdit))
        LabelHeading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelHeading
        ' 
        LabelHeading.AutoSize = True
        LabelHeading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        LabelHeading.Location = New Point(26, 33)
        LabelHeading.Name = "LabelHeading"
        LabelHeading.Size = New Size(339, 56)
        LabelHeading.TabIndex = 9
        LabelHeading.Text = "Instructor Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 41)
        Label1.TabIndex = 10
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 41)
        Label2.TabIndex = 11
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 400)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 41)
        Label3.TabIndex = 12
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Titillium Web", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 542)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 41)
        Label4.TabIndex = 13
        Label4.Text = "Label4"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(44, 177)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(694, 58)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(44, 309)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(694, 58)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(44, 444)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(694, 58)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(44, 586)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(694, 58)
        TextBox4.TabIndex = 17
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
        IconButton1.Text = "Submit"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormEdit
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(IconButton1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelHeading)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InstructorForm"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
