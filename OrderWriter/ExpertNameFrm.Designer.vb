<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpertNameFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExpertTitle = New System.Windows.Forms.ComboBox()
        Me.txtExpertFirstName = New System.Windows.Forms.TextBox()
        Me.txtExpertSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(79, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Name of the Expert"
        '
        'cmbExpertTitle
        '
        Me.cmbExpertTitle.FormattingEnabled = True
        Me.cmbExpertTitle.Items.AddRange(New Object() {"Mr ", "Mrs", "Miss", "Ms"})
        Me.cmbExpertTitle.Location = New System.Drawing.Point(432, 54)
        Me.cmbExpertTitle.Name = "cmbExpertTitle"
        Me.cmbExpertTitle.Size = New System.Drawing.Size(121, 21)
        Me.cmbExpertTitle.TabIndex = 1
        '
        'txtExpertFirstName
        '
        Me.txtExpertFirstName.Location = New System.Drawing.Point(453, 83)
        Me.txtExpertFirstName.Name = "txtExpertFirstName"
        Me.txtExpertFirstName.Size = New System.Drawing.Size(130, 20)
        Me.txtExpertFirstName.TabIndex = 2
        '
        'txtExpertSurname
        '
        Me.txtExpertSurname.Location = New System.Drawing.Point(432, 109)
        Me.txtExpertSurname.Name = "txtExpertSurname"
        Me.txtExpertSurname.Size = New System.Drawing.Size(151, 20)
        Me.txtExpertSurname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1027, 588)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ExpertNameFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1314, 655)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtExpertSurname)
        Me.Controls.Add(Me.txtExpertFirstName)
        Me.Controls.Add(Me.cmbExpertTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ExpertNameFrm"
        Me.Text = "ExpertNameFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbExpertTitle As ComboBox
    Friend WithEvents txtExpertFirstName As TextBox
    Friend WithEvents txtExpertSurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
