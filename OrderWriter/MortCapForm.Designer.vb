<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MortCapForm
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
        Me.cmbWhoseNeeds1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbWhoseNeeds2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbHearingType = New System.Windows.Forms.ComboBox()
        Me.dtpCompliance1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbWhoseNeeds1
        '
        Me.cmbWhoseNeeds1.AutoCompleteCustomSource.AddRange(New String() {"their own", "their own and the child of the family ", "Their own and the children of the family"})
        Me.cmbWhoseNeeds1.FormattingEnabled = True
        Me.cmbWhoseNeeds1.Items.AddRange(New Object() {"the child of the family", "the children of the family"})
        Me.cmbWhoseNeeds1.Location = New System.Drawing.Point(909, 12)
        Me.cmbWhoseNeeds1.Name = "cmbWhoseNeeds1"
        Me.cmbWhoseNeeds1.Size = New System.Drawing.Size(201, 21)
        Me.cmbWhoseNeeds1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "and the housing needs of the  other "
        '
        'cmbWhoseNeeds2
        '
        Me.cmbWhoseNeeds2.AutoCompleteCustomSource.AddRange(New String() {"the other", "the other and of the child of the family", "the other and of the children of the family"})
        Me.cmbWhoseNeeds2.FormattingEnabled = True
        Me.cmbWhoseNeeds2.Items.AddRange(New Object() {"the child of the family", "the children of the family"})
        Me.cmbWhoseNeeds2.Location = New System.Drawing.Point(496, 75)
        Me.cmbWhoseNeeds2.Name = "cmbWhoseNeeds2"
        Me.cmbWhoseNeeds2.Size = New System.Drawing.Size(229, 21)
        Me.cmbWhoseNeeds2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "limited to "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(36, 238)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "by "
        '
        'cmbHearingType
        '
        Me.cmbHearingType.FormattingEnabled = True
        Me.cmbHearingType.Items.AddRange(New Object() {"[a specified date]", "financial dispute resolution appointment ", "final hearing "})
        Me.cmbHearingType.Location = New System.Drawing.Point(339, 245)
        Me.cmbHearingType.Name = "cmbHearingType"
        Me.cmbHearingType.Size = New System.Drawing.Size(121, 21)
        Me.cmbHearingType.TabIndex = 7
        '
        'dtpCompliance1
        '
        Me.dtpCompliance1.Enabled = False
        Me.dtpCompliance1.Location = New System.Drawing.Point(135, 341)
        Me.dtpCompliance1.Name = "dtpCompliance1"
        Me.dtpCompliance1.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1150, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "a." & Global.Microsoft.VisualBasic.ChrW(9) & "Each party shall serve on the other party copy particulars of properties they " &
    "consider to be suitable to meet  their own housing need "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(158, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "5 of each"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "or "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "weeks before "
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(598, 325)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(452, 66)
        Me.txtText.TabIndex = 19
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(760, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "and the housing needs of "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(339, 76)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "and the housing needs of "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(36, 473)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MortCapForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 517)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpCompliance1)
        Me.Controls.Add(Me.cmbHearingType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbWhoseNeeds2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbWhoseNeeds1)
        Me.Name = "MortCapForm"
        Me.Text = "MortCapForm"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbWhoseNeeds1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbWhoseNeeds2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbHearingType As ComboBox
    Friend WithEvents dtpCompliance1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button2 As Button
End Class
