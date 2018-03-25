<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedDef
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.dtpCompliance = New System.Windows.Forms.DateTimePicker()
        Me.lblHisHers = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkIfAdv = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(430, 188)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(288, 106)
        Me.txtTest.TabIndex = 15
        '
        'dtpCompliance
        '
        Me.dtpCompliance.Location = New System.Drawing.Point(188, 246)
        Me.dtpCompliance.Name = "dtpCompliance"
        Me.dtpCompliance.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance.TabIndex = 14
        '
        'lblHisHers
        '
        Me.lblHisHers.AutoSize = True
        Me.lblHisHers.Location = New System.Drawing.Point(135, 163)
        Me.lblHisHers.Name = "lblHisHers"
        Me.lblHisHers.Size = New System.Drawing.Size(445, 13)
        Me.lblHisHers.TabIndex = 13
        Me.lblHisHers.Text = "a schedule of deficiencies and a supplemental questionnaireand request for furthe" &
    "r document"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(237, 88)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(200, 13)
        Me.lblOther.TabIndex = 12
        Me.lblOther.Text = "shall send to the court  and serve on  the"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "Both Parties"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(97, 77)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "The"
        '
        'chkIfAdv
        '
        Me.chkIfAdv.AutoSize = True
        Me.chkIfAdv.Location = New System.Drawing.Point(640, 159)
        Me.chkIfAdv.Name = "chkIfAdv"
        Me.chkIfAdv.Size = New System.Drawing.Size(85, 17)
        Me.chkIfAdv.TabIndex = 19
        Me.chkIfAdv.Text = "if so advised"
        Me.chkIfAdv.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "by"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Label4"
        '
        'frmSchedDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 458)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkIfAdv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.dtpCompliance)
        Me.Controls.Add(Me.lblHisHers)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Name = "frmSchedDef"
        Me.Text = "32 Schedule of Deficiencies and Supplemental Questionnaire and request for furthe" &
    "r documents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTest As TextBox
    Friend WithEvents dtpCompliance As DateTimePicker
    Friend WithEvents lblHisHers As Label
    Friend WithEvents lblOther As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkIfAdv As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
