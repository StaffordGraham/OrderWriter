<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsolidateForm
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
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.cmbApp1 = New System.Windows.Forms.ComboBox()
        Me.chkAppliesToLead = New System.Windows.Forms.CheckBox()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkOtherPartyLead = New System.Windows.Forms.CheckBox()
        Me.cmbApp2 = New System.Windows.Forms.ComboBox()
        Me.cmbOtherParty = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.cmbApp3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.cmbApp4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDoc3 = New System.Windows.Forms.TextBox()
        Me.txtDoc2 = New System.Windows.Forms.TextBox()
        Me.cmbReceivingParty = New System.Windows.Forms.ComboBox()
        Me.txtDoc1 = New System.Windows.Forms.TextBox()
        Me.cmbServingParty = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Party"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proceedings"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "First Respondent", "Second Respondent"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(109, 98)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 2
        '
        'cmbApp1
        '
        Me.cmbApp1.FormattingEnabled = True
        Me.cmbApp1.Location = New System.Drawing.Point(338, 98)
        Me.cmbApp1.Name = "cmbApp1"
        Me.cmbApp1.Size = New System.Drawing.Size(121, 21)
        Me.cmbApp1.TabIndex = 3
        '
        'chkAppliesToLead
        '
        Me.chkAppliesToLead.AutoSize = True
        Me.chkAppliesToLead.Location = New System.Drawing.Point(13, 101)
        Me.chkAppliesToLead.Name = "chkAppliesToLead"
        Me.chkAppliesToLead.Size = New System.Drawing.Size(77, 17)
        Me.chkAppliesToLead.TabIndex = 4
        Me.chkAppliesToLead.Text = "Lead Party"
        Me.chkAppliesToLead.UseVisualStyleBackColor = True
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(665, 99)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(100, 20)
        Me.txtCaseNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Case No for Consolidated Proceedings\"
        '
        'chkOtherPartyLead
        '
        Me.chkOtherPartyLead.AutoSize = True
        Me.chkOtherPartyLead.Location = New System.Drawing.Point(13, 145)
        Me.chkOtherPartyLead.Name = "chkOtherPartyLead"
        Me.chkOtherPartyLead.Size = New System.Drawing.Size(77, 17)
        Me.chkOtherPartyLead.TabIndex = 9
        Me.chkOtherPartyLead.Text = "Lead Party"
        Me.chkOtherPartyLead.UseVisualStyleBackColor = True
        '
        'cmbApp2
        '
        Me.cmbApp2.FormattingEnabled = True
        Me.cmbApp2.Location = New System.Drawing.Point(338, 142)
        Me.cmbApp2.Name = "cmbApp2"
        Me.cmbApp2.Size = New System.Drawing.Size(121, 21)
        Me.cmbApp2.TabIndex = 8
        '
        'cmbOtherParty
        '
        Me.cmbOtherParty.FormattingEnabled = True
        Me.cmbOtherParty.Location = New System.Drawing.Point(109, 142)
        Me.cmbOtherParty.Name = "cmbOtherParty"
        Me.cmbOtherParty.Size = New System.Drawing.Size(121, 21)
        Me.cmbOtherParty.TabIndex = 7
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(13, 194)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox3.TabIndex = 12
        Me.CheckBox3.Text = "Lead Party"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'cmbApp3
        '
        Me.cmbApp3.FormattingEnabled = True
        Me.cmbApp3.Location = New System.Drawing.Point(338, 191)
        Me.cmbApp3.Name = "cmbApp3"
        Me.cmbApp3.Size = New System.Drawing.Size(121, 21)
        Me.cmbApp3.TabIndex = 11
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(109, 191)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 10
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(13, 237)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "Lead Party"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'cmbApp4
        '
        Me.cmbApp4.FormattingEnabled = True
        Me.cmbApp4.Location = New System.Drawing.Point(338, 234)
        Me.cmbApp4.Name = "cmbApp4"
        Me.cmbApp4.Size = New System.Drawing.Size(121, 21)
        Me.cmbApp4.TabIndex = 14
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(109, 234)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox8.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDoc3)
        Me.GroupBox1.Controls.Add(Me.txtDoc2)
        Me.GroupBox1.Controls.Add(Me.cmbReceivingParty)
        Me.GroupBox1.Controls.Add(Me.txtDoc1)
        Me.GroupBox1.Controls.Add(Me.cmbServingParty)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 346)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directions for Service of Documents"
        '
        'txtDoc3
        '
        Me.txtDoc3.Location = New System.Drawing.Point(48, 244)
        Me.txtDoc3.Multiline = True
        Me.txtDoc3.Name = "txtDoc3"
        Me.txtDoc3.Size = New System.Drawing.Size(278, 20)
        Me.txtDoc3.TabIndex = 7
        '
        'txtDoc2
        '
        Me.txtDoc2.Location = New System.Drawing.Point(48, 206)
        Me.txtDoc2.Multiline = True
        Me.txtDoc2.Name = "txtDoc2"
        Me.txtDoc2.Size = New System.Drawing.Size(261, 20)
        Me.txtDoc2.TabIndex = 6
        '
        'cmbReceivingParty
        '
        Me.cmbReceivingParty.FormattingEnabled = True
        Me.cmbReceivingParty.Items.AddRange(New Object() {"Applicant", "Respondent", "First Respondent", "Second Respondent"})
        Me.cmbReceivingParty.Location = New System.Drawing.Point(38, 86)
        Me.cmbReceivingParty.Name = "cmbReceivingParty"
        Me.cmbReceivingParty.Size = New System.Drawing.Size(121, 21)
        Me.cmbReceivingParty.TabIndex = 5
        '
        'txtDoc1
        '
        Me.txtDoc1.Location = New System.Drawing.Point(48, 162)
        Me.txtDoc1.Multiline = True
        Me.txtDoc1.Name = "txtDoc1"
        Me.txtDoc1.Size = New System.Drawing.Size(261, 20)
        Me.txtDoc1.TabIndex = 4
        '
        'cmbServingParty
        '
        Me.cmbServingParty.FormattingEnabled = True
        Me.cmbServingParty.Items.AddRange(New Object() {"Applicant", "Respondent", "First Respondent", "Second Respondent"})
        Me.cmbServingParty.Location = New System.Drawing.Point(38, 50)
        Me.cmbServingParty.Name = "cmbServingParty"
        Me.cmbServingParty.Size = New System.Drawing.Size(121, 21)
        Me.cmbServingParty.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 704)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1091, 689)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(759, 142)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(352, 113)
        Me.txtTest.TabIndex = 19
        '
        'ConsolidateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 743)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.cmbApp4)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.cmbApp3)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.chkOtherPartyLead)
        Me.Controls.Add(Me.cmbApp2)
        Me.Controls.Add(Me.cmbOtherParty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.chkAppliesToLead)
        Me.Controls.Add(Me.cmbApp1)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsolidateForm"
        Me.Text = "Order to Consolidate Proceedings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents cmbApp1 As ComboBox
    Friend WithEvents chkAppliesToLead As CheckBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkOtherPartyLead As CheckBox
    Friend WithEvents cmbApp2 As ComboBox
    Friend WithEvents cmbOtherParty As ComboBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents cmbApp3 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents cmbApp4 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDoc3 As TextBox
    Friend WithEvents txtDoc2 As TextBox
    Friend WithEvents cmbReceivingParty As ComboBox
    Friend WithEvents txtDoc1 As TextBox
    Friend WithEvents cmbServingParty As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTest As TextBox
End Class
