<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.cmbOtherParty = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.cmbFrequency = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chklstEnd = New System.Windows.Forms.CheckedListBox()
        Me.chkCredit = New System.Windows.Forms.CheckBox()
        Me.txtCreditPayment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpCredit = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(207, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "The "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(456, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "shall pay to the "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(247, 148)
        Me.cmbAppliesTo.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(199, 28)
        Me.cmbAppliesTo.TabIndex = 3
        Me.cmbAppliesTo.Text = "Respondent"
        '
        'cmbOtherParty
        '
        Me.cmbOtherParty.FormattingEnabled = True
        Me.cmbOtherParty.Items.AddRange(New Object() {"Applicant", "Respondent"})
        Me.cmbOtherParty.Location = New System.Drawing.Point(602, 151)
        Me.cmbOtherParty.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbOtherParty.Name = "cmbOtherParty"
        Me.cmbOtherParty.Size = New System.Drawing.Size(199, 28)
        Me.cmbOtherParty.TabIndex = 4
        Me.cmbOtherParty.Text = "Applicant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(811, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(910, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "maintenance pending suit until the date of decree absolute and afterwards interim" &
    " periodical payments"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(483, 262)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(107, 26)
        Me.txtPayment.TabIndex = 6
        '
        'cmbFrequency
        '
        Me.cmbFrequency.FormattingEnabled = True
        Me.cmbFrequency.Items.AddRange(New Object() {"per annum", "weekly in advance ", "weekly in arrears", "monthly in advance", "monthly in arrears", ""})
        Me.cmbFrequency.Location = New System.Drawing.Point(675, 262)
        Me.cmbFrequency.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbFrequency.Name = "cmbFrequency"
        Me.cmbFrequency.Size = New System.Drawing.Size(199, 28)
        Me.cmbFrequency.TabIndex = 8
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Location = New System.Drawing.Point(1152, 263)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(331, 27)
        Me.dtpStartDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(190, 262)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(289, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ". Payments shall be at the rate of £"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(940, 272)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "by standing order from"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 352)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "and shall end "
        '
        'chklstEnd
        '
        Me.chklstEnd.FormattingEnabled = True
        Me.chklstEnd.Location = New System.Drawing.Point(343, 352)
        Me.chklstEnd.Margin = New System.Windows.Forms.Padding(5)
        Me.chklstEnd.Name = "chklstEnd"
        Me.chklstEnd.Size = New System.Drawing.Size(412, 130)
        Me.chklstEnd.TabIndex = 18
        '
        'chkCredit
        '
        Me.chkCredit.AutoSize = True
        Me.chkCredit.Location = New System.Drawing.Point(138, 620)
        Me.chkCredit.Margin = New System.Windows.Forms.Padding(5)
        Me.chkCredit.Name = "chkCredit"
        Me.chkCredit.Size = New System.Drawing.Size(617, 24)
        Me.chkCredit.TabIndex = 19
        Me.chkCredit.Text = "[The [applicant] / [respondent] shall be given credit for the payment[s] of £"
        Me.chkCredit.UseVisualStyleBackColor = True
        '
        'txtCreditPayment
        '
        Me.txtCreditPayment.Location = New System.Drawing.Point(773, 620)
        Me.txtCreditPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCreditPayment.Name = "txtCreditPayment"
        Me.txtCreditPayment.Size = New System.Drawing.Size(164, 26)
        Me.txtCreditPayment.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(950, 631)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "made on "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(1355, 620)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(331, 26)
        Me.DateTimePicker2.TabIndex = 22
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(1038, 309)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(459, 203)
        Me.txtTest.TabIndex = 23
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(1183, 518)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 32)
        Me.btnTest.TabIndex = 24
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1272, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpCredit
        '
        Me.dtpCredit.Location = New System.Drawing.Point(1058, 631)
        Me.dtpCredit.Name = "dtpCredit"
        Me.dtpCredit.Size = New System.Drawing.Size(200, 26)
        Me.dtpCredit.TabIndex = 26
        '
        'frmMPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1908, 905)
        Me.Controls.Add(Me.dtpCredit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCreditPayment)
        Me.Controls.Add(Me.chkCredit)
        Me.Controls.Add(Me.chklstEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.cmbFrequency)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbOtherParty)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmMPS"
        Me.Text = "29. MPS/Interim Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents cmbOtherParty As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cmbFrequency As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chklstEnd As CheckedListBox
    Friend WithEvents chkCredit As CheckBox
    Friend WithEvents txtCreditPayment As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtTest As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpCredit As DateTimePicker
End Class
