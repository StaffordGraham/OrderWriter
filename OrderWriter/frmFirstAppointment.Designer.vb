<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm29_FirsAppointmentDocs
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFirstAppDate = New System.Windows.Forms.DateTimePicker()
        Me.chkAppQuaire = New System.Windows.Forms.CheckBox()
        Me.chkAppIssue = New System.Windows.Forms.CheckBox()
        Me.chkAppChron = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpRespQuaire = New System.Windows.Forms.DateTimePicker()
        Me.chkRespQuaire = New System.Windows.Forms.CheckBox()
        Me.chkRespIssue = New System.Windows.Forms.CheckBox()
        Me.chkRespChron = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFirstAppDate)
        Me.GroupBox1.Controls.Add(Me.chkAppQuaire)
        Me.GroupBox1.Controls.Add(Me.chkAppIssue)
        Me.GroupBox1.Controls.Add(Me.chkAppChron)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Applicant to File & Serve:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "by "
        '
        'dtpFirstAppDate
        '
        Me.dtpFirstAppDate.Location = New System.Drawing.Point(121, 218)
        Me.dtpFirstAppDate.Name = "dtpFirstAppDate"
        Me.dtpFirstAppDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpFirstAppDate.TabIndex = 8
        '
        'chkAppQuaire
        '
        Me.chkAppQuaire.AutoSize = True
        Me.chkAppQuaire.Location = New System.Drawing.Point(83, 179)
        Me.chkAppQuaire.Name = "chkAppQuaire"
        Me.chkAppQuaire.Size = New System.Drawing.Size(91, 17)
        Me.chkAppQuaire.TabIndex = 3
        Me.chkAppQuaire.Text = "Questionnaire"
        Me.chkAppQuaire.UseVisualStyleBackColor = True
        '
        'chkAppIssue
        '
        Me.chkAppIssue.AutoSize = True
        Me.chkAppIssue.Location = New System.Drawing.Point(72, 143)
        Me.chkAppIssue.Name = "chkAppIssue"
        Me.chkAppIssue.Size = New System.Drawing.Size(119, 17)
        Me.chkAppIssue.TabIndex = 2
        Me.chkAppIssue.Text = "Statement of Issues"
        Me.chkAppIssue.UseVisualStyleBackColor = True
        '
        'chkAppChron
        '
        Me.chkAppChron.AutoSize = True
        Me.chkAppChron.Location = New System.Drawing.Point(72, 104)
        Me.chkAppChron.Name = "chkAppChron"
        Me.chkAppChron.Size = New System.Drawing.Size(79, 17)
        Me.chkAppChron.TabIndex = 1
        Me.chkAppChron.Text = "Chronology"
        Me.chkAppChron.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpRespQuaire)
        Me.GroupBox2.Controls.Add(Me.chkRespQuaire)
        Me.GroupBox2.Controls.Add(Me.chkRespIssue)
        Me.GroupBox2.Controls.Add(Me.chkRespChron)
        Me.GroupBox2.Location = New System.Drawing.Point(613, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 349)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respondent to File & Serve"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "by "
        '
        'dtpRespQuaire
        '
        Me.dtpRespQuaire.Location = New System.Drawing.Point(125, 217)
        Me.dtpRespQuaire.Name = "dtpRespQuaire"
        Me.dtpRespQuaire.Size = New System.Drawing.Size(200, 20)
        Me.dtpRespQuaire.TabIndex = 8
        '
        'chkRespQuaire
        '
        Me.chkRespQuaire.AutoSize = True
        Me.chkRespQuaire.Location = New System.Drawing.Point(101, 179)
        Me.chkRespQuaire.Name = "chkRespQuaire"
        Me.chkRespQuaire.Size = New System.Drawing.Size(91, 17)
        Me.chkRespQuaire.TabIndex = 3
        Me.chkRespQuaire.Text = "Questionnaire"
        Me.chkRespQuaire.UseVisualStyleBackColor = True
        '
        'chkRespIssue
        '
        Me.chkRespIssue.AutoSize = True
        Me.chkRespIssue.Location = New System.Drawing.Point(101, 143)
        Me.chkRespIssue.Name = "chkRespIssue"
        Me.chkRespIssue.Size = New System.Drawing.Size(119, 17)
        Me.chkRespIssue.TabIndex = 2
        Me.chkRespIssue.Text = "Statement of Issues"
        Me.chkRespIssue.UseVisualStyleBackColor = True
        '
        'chkRespChron
        '
        Me.chkRespChron.AutoSize = True
        Me.chkRespChron.Location = New System.Drawing.Point(101, 104)
        Me.chkRespChron.Name = "chkRespChron"
        Me.chkRespChron.Size = New System.Drawing.Size(79, 17)
        Me.chkRespChron.TabIndex = 1
        Me.chkRespChron.Text = "Chronology"
        Me.chkRespChron.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1060, 527)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Paragraph 29 First Appointment Documents"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(98, 467)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(445, 60)
        Me.txtTest.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(266, 549)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(404, 549)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frm29_FirsAppointmentDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 580)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm29_FirsAppointmentDocs"
        Me.Text = "First Appointment Documents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFirstAppDate As DateTimePicker
    Friend WithEvents chkAppQuaire As CheckBox
    Friend WithEvents chkAppIssue As CheckBox
    Friend WithEvents chkAppChron As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpRespQuaire As DateTimePicker
    Friend WithEvents chkRespQuaire As CheckBox
    Friend WithEvents chkRespIssue As CheckBox
    Friend WithEvents chkRespChron As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnClear As Button
End Class
