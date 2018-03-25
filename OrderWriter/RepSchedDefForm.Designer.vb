<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepSchedDefForm
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
        Me.cmbException = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpCompliance = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.lblDocs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbException
        '
        Me.cmbException.FormattingEnabled = True
        Me.cmbException.Items.AddRange(New Object() {"As amended by the Judge", "save for just exceptions", "[No variation or addition]"})
        Me.cmbException.Location = New System.Drawing.Point(237, 158)
        Me.cmbException.Name = "cmbException"
        Me.cmbException.Size = New System.Drawing.Size(250, 21)
        Me.cmbException.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(739, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(529, 158)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(288, 106)
        Me.txtTest.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'dtpCompliance
        '
        Me.dtpCompliance.Location = New System.Drawing.Point(287, 216)
        Me.dtpCompliance.Name = "dtpCompliance"
        Me.dtpCompliance.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "by"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(336, 58)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(200, 13)
        Me.lblOther.TabIndex = 12
        Me.lblOther.Text = "shall send to the court  and serve on  the"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "Both parties"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(196, 47)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 11
        '
        'lblDocs
        '
        Me.lblDocs.AutoSize = True
        Me.lblDocs.Location = New System.Drawing.Point(215, 114)
        Me.lblDocs.Name = "lblDocs"
        Me.lblDocs.Size = New System.Drawing.Size(0, 13)
        Me.lblDocs.TabIndex = 19
        '
        'RepSchedDefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 398)
        Me.Controls.Add(Me.lblDocs)
        Me.Controls.Add(Me.cmbException)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpCompliance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Name = "RepSchedDefForm"
        Me.Text = "32.Replies to schedule of deficiencies and supplemental questionnaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbException As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpCompliance As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOther As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents lblDocs As Label
End Class
