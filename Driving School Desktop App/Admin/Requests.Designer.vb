<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requests
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
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Font = New Font("Neue Haas Unica Med", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heading.ForeColor = Color.FromArgb(CByte(128), CByte(123), CByte(132))
        Heading.Location = New Point(36, 78)
        Heading.Name = "Heading"
        Heading.Size = New Size(346, 56)
        Heading.TabIndex = 8
        Heading.Text = "Student Requests"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(36, 182)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(997, 583)
        Panel1.TabIndex = 10
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Label8, 2, 1)
        TableLayoutPanel1.Controls.Add(Label7, 1, 1)
        TableLayoutPanel1.Controls.Add(Label5, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 1)
        TableLayoutPanel1.Controls.Add(Button1, 3, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.Size = New Size(997, 583)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Titillium Web", 8.999999F)
        Label8.Location = New Point(501, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(168, 36)
        Label8.TabIndex = 7
        Label8.Text = "Book Pass plus"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Titillium Web", 8.999999F)
        Label7.Location = New Point(253, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(232, 36)
        Label7.TabIndex = 6
        Label7.Text = "student1@gmail.com"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(749, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 60)
        Label5.TabIndex = 4
        Label5.Text = "View Message"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label3.Location = New Point(501, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 60)
        Label3.TabIndex = 2
        Label3.Text = "Request type"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Neue Haas Unica Med", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label1.Location = New Point(5, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 60)
        Label1.TabIndex = 0
        Label1.Text = "Student Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Neue Haas Unica Med", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(253, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 60)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Titillium Web", 8.999999F)
        Label6.Location = New Point(5, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 36)
        Label6.TabIndex = 5
        Label6.Text = "Student 1"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(246), CByte(107), CByte(7))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Titillium Web", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(749, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(243, 64)
        Button1.TabIndex = 30
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Requests
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(238), CByte(233))
        ClientSize = New Size(1125, 870)
        Controls.Add(Panel1)
        Controls.Add(Heading)
        FormBorderStyle = FormBorderStyle.None
        Name = "Requests"
        Text = "StudentDetails"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
