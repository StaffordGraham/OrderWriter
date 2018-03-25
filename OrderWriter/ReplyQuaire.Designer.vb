<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplyQuaire
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
        Me.lblOther = New System.Windows.Forms.Label()
        Me.lblHisHers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCompliance = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbException = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "Both parties"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(59, 53)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 1
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(199, 64)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(200, 13)
        Me.lblOther.TabIndex = 2
        Me.lblOther.Text = "shall send to the court  and serve on  the"
        '
        'lblHisHers
        '
        Me.lblHisHers.AutoSize = True
        Me.lblHisHers.Location = New System.Drawing.Point(97, 139)
        Me.lblHisHers.Name = "lblHisHers"
        Me.lblHisHers.Size = New System.Drawing.Size(372, 13)
        Me.lblHisHers.TabIndex = 3
        Me.lblHisHers.Text = "His/Her replies to the other's questionnaire  and request for further documents"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "by"
        '
        'dtpCompliance
        '
        Me.dtpCompliance.Location = New System.Drawing.Point(150, 222)
        Me.dtpCompliance.Name = "dtpCompliance"
        Me.dtpCompliance.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(392, 164)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(288, 106)
        Me.txtTest.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(602, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbException
        '
        Me.cmbException.FormattingEnabled = True
        Me.cmbException.Items.AddRange(New Object() {"As amended by the Judge", "save for just exceptions", "[No variation or addition]"})
        Me.cmbException.Location = New System.Drawing.Point(100, 164)
        Me.cmbException.Name = "cmbException"
        Me.cmbException.Size = New System.Drawing.Size(250, 21)
        Me.cmbException.TabIndex = 10
        '
        'frmReplyQuaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 384)
        Me.Controls.Add(Me.cmbException)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpCompliance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHisHers)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReplyQuaire"
        Me.Text = "30 Replies to Questionnaire and request for furher documents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents lblOther As Label
    Friend WithEvents lblHisHers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCompliance As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbException As ComboBox
End Class
