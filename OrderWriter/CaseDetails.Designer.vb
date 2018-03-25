<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseDetails
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
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.optAppMale = New System.Windows.Forms.RadioButton()
        Me.optAppFemale = New System.Windows.Forms.RadioButton()
        Me.optRespFemale = New System.Windows.Forms.RadioButton()
        Me.optRespMale = New System.Windows.Forms.RadioButton()
        Me.txtRespName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRelation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbStatute = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(670, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Case Number"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(805, 40)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(138, 20)
        Me.txtCaseNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "who is "
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(23, 476)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(880, 517)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(73, 30)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(100, 20)
        Me.txtAppName.TabIndex = 21
        '
        'optAppMale
        '
        Me.optAppMale.AutoSize = True
        Me.optAppMale.Location = New System.Drawing.Point(268, 37)
        Me.optAppMale.Name = "optAppMale"
        Me.optAppMale.Size = New System.Drawing.Size(48, 17)
        Me.optAppMale.TabIndex = 22
        Me.optAppMale.TabStop = True
        Me.optAppMale.Text = "Male"
        Me.optAppMale.UseVisualStyleBackColor = True
        '
        'optAppFemale
        '
        Me.optAppFemale.AutoSize = True
        Me.optAppFemale.Location = New System.Drawing.Point(378, 37)
        Me.optAppFemale.Name = "optAppFemale"
        Me.optAppFemale.Size = New System.Drawing.Size(59, 17)
        Me.optAppFemale.TabIndex = 23
        Me.optAppFemale.TabStop = True
        Me.optAppFemale.Text = "Female"
        Me.optAppFemale.UseVisualStyleBackColor = True
        '
        'optRespFemale
        '
        Me.optRespFemale.AutoSize = True
        Me.optRespFemale.Location = New System.Drawing.Point(360, 44)
        Me.optRespFemale.Name = "optRespFemale"
        Me.optRespFemale.Size = New System.Drawing.Size(59, 17)
        Me.optRespFemale.TabIndex = 28
        Me.optRespFemale.TabStop = True
        Me.optRespFemale.Text = "Female"
        Me.optRespFemale.UseVisualStyleBackColor = True
        '
        'optRespMale
        '
        Me.optRespMale.AutoSize = True
        Me.optRespMale.Location = New System.Drawing.Point(265, 44)
        Me.optRespMale.Name = "optRespMale"
        Me.optRespMale.Size = New System.Drawing.Size(48, 17)
        Me.optRespMale.TabIndex = 27
        Me.optRespMale.TabStop = True
        Me.optRespMale.Text = "Male"
        Me.optRespMale.UseVisualStyleBackColor = True
        '
        'txtRespName
        '
        Me.txtRespName.Location = New System.Drawing.Point(79, 41)
        Me.txtRespName.Name = "txtRespName"
        Me.txtRespName.Size = New System.Drawing.Size(100, 20)
        Me.txtRespName.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Name"
        '
        'cmbRelation
        '
        Me.cmbRelation.FormattingEnabled = True
        Me.cmbRelation.Items.AddRange(New Object() {"Married", "Civil Partnership", "Relationship"})
        Me.cmbRelation.Location = New System.Drawing.Point(88, 413)
        Me.cmbRelation.Name = "cmbRelation"
        Me.cmbRelation.Size = New System.Drawing.Size(121, 21)
        Me.cmbRelation.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Relationship"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAppName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.optAppMale)
        Me.GroupBox1.Controls.Add(Me.optAppFemale)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 71)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Applicant"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtRespName)
        Me.GroupBox2.Controls.Add(Me.optRespMale)
        Me.GroupBox2.Controls.Add(Me.optRespFemale)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 100)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respondent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "who is "
        '
        'cmbStatute
        '
        Me.cmbStatute.FormattingEnabled = True
        Me.cmbStatute.Items.AddRange(New Object() {"The Matrimonial Causes Act 1973", "The Civil Partnership Act 2004", "The Child Support Act 1991 ", "Schedule 1 to the Children Act 1989", "The Inheritance (Provision for Family and Dependants) Act 1975 ", "The Matrimonial and Family Proceedings Act 1984 and Schedule 7 to the Civil Partn" &
                "ership Act 2004", "The Trusts of Land and Appointment of Trustees Act 1996", "The Married Women’s Property Act 1882 and ss 67,68 and 74 of the Civil Partnershi" &
                "p Act 2004"})
        Me.cmbStatute.Location = New System.Drawing.Point(406, 413)
        Me.cmbStatute.Name = "cmbStatute"
        Me.cmbStatute.Size = New System.Drawing.Size(390, 21)
        Me.cmbStatute.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Statute"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(614, 242)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(279, 100)
        Me.txtTest.TabIndex = 35
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(721, 348)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 36
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'CaseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 552)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbStatute)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbRelation)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CaseDetails"
        Me.Text = "CaseDetails"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtAppName As TextBox
    Friend WithEvents optAppMale As RadioButton
    Friend WithEvents optAppFemale As RadioButton
    Friend WithEvents optRespFemale As RadioButton
    Friend WithEvents optRespMale As RadioButton
    Friend WithEvents txtRespName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRelation As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbStatute As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents btnTest As Button
End Class
