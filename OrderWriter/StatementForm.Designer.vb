<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatementForm
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
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.lblOrd2 = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStatute = New System.Windows.Forms.ComboBox()
        Me.dtpCompliance = New System.Windows.Forms.DateTimePicker()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(127, 50)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(103, 21)
        Me.cmbAppliesTo.TabIndex = 0
        '
        'lblOrd2
        '
        Me.lblOrd2.AutoSize = True
        Me.lblOrd2.Location = New System.Drawing.Point(150, 119)
        Me.lblOrd2.Name = "lblOrd2"
        Me.lblOrd2.Size = New System.Drawing.Size(39, 13)
        Me.lblOrd2.TabIndex = 1
        Me.lblOrd2.Text = "Label1"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Location = New System.Drawing.Point(300, 53)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(0, 13)
        Me.lblOrd.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "by"
        '
        'cmbStatute
        '
        Me.cmbStatute.FormattingEnabled = True
        Me.cmbStatute.Items.AddRange(New Object() {"The Matrimonial Causes Act 1973", "The Civil Partnership Act 2004", "The Child Support Act 1991 ", "Schedule 1 to the Children Act 1989", "The Inheritance (Provision for Family and Dependants) Act 1975 ", "The Matrimonial and Family Proceedings Act 1984 and Schedule 7 to the Civil Partn" &
                "ership Act 2004", "The Trusts of Land and Appointment of Trustees Act 1996", "The Married Women’s Property Act 1882 and ss 67,68 and 74 of the Civil Partnershi" &
                "p Act 2004"})
        Me.cmbStatute.Location = New System.Drawing.Point(559, 111)
        Me.cmbStatute.Name = "cmbStatute"
        Me.cmbStatute.Size = New System.Drawing.Size(287, 21)
        Me.cmbStatute.TabIndex = 4
        '
        'dtpCompliance
        '
        Me.dtpCompliance.Location = New System.Drawing.Point(127, 207)
        Me.dtpCompliance.Name = "dtpCompliance"
        Me.dtpCompliance.Size = New System.Drawing.Size(200, 20)
        Me.dtpCompliance.TabIndex = 5
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(525, 182)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(321, 134)
        Me.txtTest.TabIndex = 6
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(695, 398)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "The"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.dtpCompliance)
        Me.Controls.Add(Me.cmbStatute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOrd)
        Me.Controls.Add(Me.lblOrd2)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Name = "StatementForm"
        Me.Text = "StatementForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents lblOrd2 As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStatute As ComboBox
    Friend WithEvents dtpCompliance As DateTimePicker
    Friend WithEvents txtTest As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
End Class
