<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherEvidenceForm
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
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCompliance = New System.Windows.Forms.DateTimePicker()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEvidenceForm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEvidenceSource = New System.Windows.Forms.TextBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.chkIfSoAdvised = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLimitIssue = New System.Windows.Forms.CheckBox()
        Me.chkDealIssue = New System.Windows.Forms.CheckBox()
        Me.txtTheIssue = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The "
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(195, 43)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "by "
        '
        'dtpCompliance
        '
        Me.dtpCompliance.Location = New System.Drawing.Point(110, 403)
        Me.dtpCompliance.Name = "dtpCompliance"
        Me.dtpCompliance.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance.TabIndex = 3
        '
        'txtIssue
        '
        Me.txtIssue.Location = New System.Drawing.Point(467, 124)
        Me.txtIssue.Multiline = True
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(201, 57)
        Me.txtIssue.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "has permission to file with the court and serve on the "
        '
        'cmbEvidenceForm
        '
        Me.cmbEvidenceForm.FormattingEnabled = True
        Me.cmbEvidenceForm.Items.AddRange(New Object() {"evidence ", "a statement ", "a letter "})
        Me.cmbEvidenceForm.Location = New System.Drawing.Point(738, 53)
        Me.cmbEvidenceForm.Name = "cmbEvidenceForm"
        Me.cmbEvidenceForm.Size = New System.Drawing.Size(121, 21)
        Me.cmbEvidenceForm.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(903, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "from"
        '
        'txtEvidenceSource
        '
        Me.txtEvidenceSource.Location = New System.Drawing.Point(977, 58)
        Me.txtEvidenceSource.Multiline = True
        Me.txtEvidenceSource.Name = "txtEvidenceSource"
        Me.txtEvidenceSource.Size = New System.Drawing.Size(100, 20)
        Me.txtEvidenceSource.TabIndex = 10
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(615, 236)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(266, 69)
        Me.txtTest.TabIndex = 11
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(879, 404)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Button1"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'chkIfSoAdvised
        '
        Me.chkIfSoAdvised.AutoSize = True
        Me.chkIfSoAdvised.Location = New System.Drawing.Point(131, 80)
        Me.chkIfSoAdvised.Name = "chkIfSoAdvised"
        Me.chkIfSoAdvised.Size = New System.Drawing.Size(85, 17)
        Me.chkIfSoAdvised.TabIndex = 13
        Me.chkIfSoAdvised.Text = "if so advised"
        Me.chkIfSoAdvised.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTheIssue)
        Me.GroupBox1.Controls.Add(Me.chkDealIssue)
        Me.GroupBox1.Controls.Add(Me.chkLimitIssue)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 150)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'chkLimitIssue
        '
        Me.chkLimitIssue.AutoSize = True
        Me.chkLimitIssue.Location = New System.Drawing.Point(17, 20)
        Me.chkLimitIssue.Name = "chkLimitIssue"
        Me.chkLimitIssue.Size = New System.Drawing.Size(142, 17)
        Me.chkLimitIssue.TabIndex = 0
        Me.chkLimitIssue.Text = "dealing with the issue of "
        Me.chkLimitIssue.UseVisualStyleBackColor = True
        '
        'chkDealIssue
        '
        Me.chkDealIssue.AutoSize = True
        Me.chkDealIssue.Location = New System.Drawing.Point(17, 52)
        Me.chkDealIssue.Name = "chkDealIssue"
        Me.chkDealIssue.Size = New System.Drawing.Size(171, 17)
        Me.chkDealIssue.TabIndex = 1
        Me.chkDealIssue.Text = "limited to dealing with the issue"
        Me.chkDealIssue.UseVisualStyleBackColor = True
        '
        'txtTheIssue
        '
        Me.txtTheIssue.Enabled = False
        Me.txtTheIssue.Location = New System.Drawing.Point(17, 88)
        Me.txtTheIssue.Multiline = True
        Me.txtTheIssue.Name = "txtTheIssue"
        Me.txtTheIssue.Size = New System.Drawing.Size(340, 51)
        Me.txtTheIssue.TabIndex = 2
        '
        'OtherEvidenceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkIfSoAdvised)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.txtEvidenceSource)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbEvidenceForm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.dtpCompliance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OtherEvidenceForm"
        Me.Text = "OtherEvidenceForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCompliance As DateTimePicker
    Friend WithEvents txtIssue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEvidenceForm As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEvidenceSource As TextBox
    Friend WithEvents txtTest As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents chkIfSoAdvised As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTheIssue As TextBox
    Friend WithEvents chkDealIssue As CheckBox
    Friend WithEvents chkLimitIssue As CheckBox
End Class
