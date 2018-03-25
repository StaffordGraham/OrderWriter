<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActuaryForm
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.rdoJoint = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoValKnown = New System.Windows.Forms.RadioButton()
        Me.rdoValNotKnown = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.lblAppliesTo = New System.Windows.Forms.Label()
        Me.rdoValNoKnown = New System.Windows.Forms.RadioButton()
        Me.rdoValuerKnown = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoValuerNotKnown = New System.Windows.Forms.RadioButton()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(857, 581)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next "
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'rdoJoint
        '
        Me.rdoJoint.AutoSize = True
        Me.rdoJoint.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdoJoint.Location = New System.Drawing.Point(21, 37)
        Me.rdoJoint.Name = "rdoJoint"
        Me.rdoJoint.Size = New System.Drawing.Size(61, 23)
        Me.rdoJoint.TabIndex = 1
        Me.rdoJoint.Text = "Joint"
        Me.rdoJoint.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSingle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdoSingle.Location = New System.Drawing.Point(331, 37)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(97, 23)
        Me.rdoSingle.TabIndex = 2
        Me.rdoSingle.Text = "One Party"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoValKnown)
        Me.GroupBox1.Controls.Add(Me.rdoValNotKnown)
        Me.GroupBox1.Controls.Add(Me.rdoJoint)
        Me.GroupBox1.Controls.Add(Me.rdoSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(496, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 82)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'rdoValKnown
        '
        Me.rdoValKnown.AutoSize = True
        Me.rdoValKnown.Location = New System.Drawing.Point(55, 254)
        Me.rdoValKnown.Name = "rdoValKnown"
        Me.rdoValKnown.Size = New System.Drawing.Size(43, 17)
        Me.rdoValKnown.TabIndex = 1
        Me.rdoValKnown.Text = "Yes"
        Me.rdoValKnown.UseVisualStyleBackColor = True
        '
        'rdoValNotKnown
        '
        Me.rdoValNotKnown.AutoSize = True
        Me.rdoValNotKnown.Checked = True
        Me.rdoValNotKnown.Location = New System.Drawing.Point(219, 257)
        Me.rdoValNotKnown.Name = "rdoValNotKnown"
        Me.rdoValNotKnown.Size = New System.Drawing.Size(39, 17)
        Me.rdoValNotKnown.TabIndex = 2
        Me.rdoValNotKnown.TabStop = True
        Me.rdoValNotKnown.Text = "No"
        Me.rdoValNotKnown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Is the Name  of the Actuary Known?"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(524, 265)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(155, 27)
        Me.cmbAppliesTo.TabIndex = 13
        '
        'lblAppliesTo
        '
        Me.lblAppliesTo.AutoSize = True
        Me.lblAppliesTo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppliesTo.ForeColor = System.Drawing.Color.Blue
        Me.lblAppliesTo.Location = New System.Drawing.Point(174, 273)
        Me.lblAppliesTo.Name = "lblAppliesTo"
        Me.lblAppliesTo.Size = New System.Drawing.Size(245, 19)
        Me.lblAppliesTo.TabIndex = 9
        Me.lblAppliesTo.Text = "Which Party Instructs the Actuary"
        '
        'rdoValNoKnown
        '
        Me.rdoValNoKnown.AutoSize = True
        Me.rdoValNoKnown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoValNoKnown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdoValNoKnown.Location = New System.Drawing.Point(27, 31)
        Me.rdoValNoKnown.Name = "rdoValNoKnown"
        Me.rdoValNoKnown.Size = New System.Drawing.Size(52, 23)
        Me.rdoValNoKnown.TabIndex = 2
        Me.rdoValNoKnown.TabStop = True
        Me.rdoValNoKnown.Text = "No "
        Me.rdoValNoKnown.UseVisualStyleBackColor = True
        '
        'rdoValuerKnown
        '
        Me.rdoValuerKnown.AutoSize = True
        Me.rdoValuerKnown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoValuerKnown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdoValuerKnown.Location = New System.Drawing.Point(313, 34)
        Me.rdoValuerKnown.Name = "rdoValuerKnown"
        Me.rdoValuerKnown.Size = New System.Drawing.Size(52, 23)
        Me.rdoValuerKnown.TabIndex = 1
        Me.rdoValuerKnown.TabStop = True
        Me.rdoValuerKnown.Text = "Yes"
        Me.rdoValuerKnown.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoValNoKnown)
        Me.GroupBox2.Controls.Add(Me.rdoValuerKnown)
        Me.GroupBox2.Controls.Add(Me.rdoValuerNotKnown)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'rdoValuerNotKnown
        '
        Me.rdoValuerNotKnown.AutoSize = True
        Me.rdoValuerNotKnown.Location = New System.Drawing.Point(-37, 34)
        Me.rdoValuerNotKnown.Name = "rdoValuerNotKnown"
        Me.rdoValuerNotKnown.Size = New System.Drawing.Size(39, 17)
        Me.rdoValuerNotKnown.TabIndex = 0
        Me.rdoValuerNotKnown.TabStop = True
        Me.rdoValuerNotKnown.Text = "No"
        Me.rdoValuerNotKnown.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(177, 580)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "Back"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(174, 170)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(279, 19)
        Me.lblQuestion.TabIndex = 10
        Me.lblQuestion.Text = "Is the instruction joint or by one party"
        '
        'ActuaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 662)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.lblAppliesTo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "ActuaryForm"
        Me.Text = "ActuaryForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents rdoJoint As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoValKnown As RadioButton
    Friend WithEvents rdoValNotKnown As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents lblAppliesTo As Label
    Friend WithEvents rdoValNoKnown As RadioButton
    Friend WithEvents rdoValuerKnown As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoValuerNotKnown As RadioButton
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblQuestion As Label
End Class
