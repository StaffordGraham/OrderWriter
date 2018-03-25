<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLegalServices
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
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpByDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblthereafter = New System.Windows.Forms.Label()
        Me.lblperCalendar = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblUntil = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPevious = New System.Windows.Forms.Button()
        Me.txtSols = New System.Windows.Forms.TextBox()
        Me.lblOrder2 = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.txtPeriodicAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(94, 102)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 1
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(221, 105)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(125, 13)
        Me.lblOrder.TabIndex = 2
        Me.lblOrder.Text = "shall pay the amount of £"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(360, 103)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        '
        'dtpByDate
        '
        Me.dtpByDate.Location = New System.Drawing.Point(517, 106)
        Me.dtpByDate.Name = "dtpByDate"
        Me.dtpByDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpByDate.TabIndex = 4
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(481, 106)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(18, 13)
        Me.lblBy.TabIndex = 5
        Me.lblBy.Text = "by"
        '
        'lblthereafter
        '
        Me.lblthereafter.AutoSize = True
        Me.lblthereafter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthereafter.Location = New System.Drawing.Point(40, 147)
        Me.lblthereafter.Name = "lblthereafter"
        Me.lblthereafter.Size = New System.Drawing.Size(154, 13)
        Me.lblthereafter.TabIndex = 6
        Me.lblthereafter.Text = "and thereafter the sum of "
        '
        'lblperCalendar
        '
        Me.lblperCalendar.AutoSize = True
        Me.lblperCalendar.Location = New System.Drawing.Point(320, 150)
        Me.lblperCalendar.Name = "lblperCalendar"
        Me.lblperCalendar.Size = New System.Drawing.Size(179, 13)
        Me.lblperCalendar.TabIndex = 7
        Me.lblperCalendar.Text = "per calendar month commencing on "
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(50, 236)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(16, 13)
        Me.lblTo.TabIndex = 9
        Me.lblTo.Text = "to"
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(517, 150)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 10
        '
        'lblUntil
        '
        Me.lblUntil.AutoSize = True
        Me.lblUntil.Location = New System.Drawing.Point(40, 189)
        Me.lblUntil.Name = "lblUntil"
        Me.lblUntil.Size = New System.Drawing.Size(26, 13)
        Me.lblUntil.TabIndex = 11
        Me.lblUntil.Text = "until"
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(136, 189)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 12
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(855, 499)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPevious
        '
        Me.btnPevious.Location = New System.Drawing.Point(13, 498)
        Me.btnPevious.Name = "btnPevious"
        Me.btnPevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPevious.TabIndex = 14
        Me.btnPevious.Text = "Previous"
        Me.btnPevious.UseVisualStyleBackColor = True
        '
        'txtSols
        '
        Me.txtSols.Location = New System.Drawing.Point(94, 239)
        Me.txtSols.Name = "txtSols"
        Me.txtSols.Size = New System.Drawing.Size(100, 20)
        Me.txtSols.TabIndex = 15
        '
        'lblOrder2
        '
        Me.lblOrder2.AutoSize = True
        Me.lblOrder2.Location = New System.Drawing.Point(357, 246)
        Me.lblOrder2.Name = "lblOrder2"
        Me.lblOrder2.Size = New System.Drawing.Size(262, 13)
        Me.lblOrder2.TabIndex = 16
        Me.lblOrder2.Text = "the legal representatives of the Applicant/Respondent"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(560, 352)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(383, 119)
        Me.txtTest.TabIndex = 17
        '
        'txtPeriodicAmount
        '
        Me.txtPeriodicAmount.Location = New System.Drawing.Point(194, 144)
        Me.txtPeriodicAmount.Name = "txtPeriodicAmount"
        Me.txtPeriodicAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriodicAmount.TabIndex = 18
        '
        'frmLegalServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 549)
        Me.Controls.Add(Me.txtPeriodicAmount)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.lblOrder2)
        Me.Controls.Add(Me.txtSols)
        Me.Controls.Add(Me.btnPevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.lblUntil)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblperCalendar)
        Me.Controls.Add(Me.lblthereafter)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.dtpByDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLegalServices"
        Me.Text = "Legal Services Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpByDate As DateTimePicker
    Friend WithEvents lblBy As Label
    Friend WithEvents lblthereafter As Label
    Friend WithEvents lblperCalendar As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblUntil As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPevious As Button
    Friend WithEvents txtSols As TextBox
    Friend WithEvents lblOrder2 As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents txtPeriodicAmount As TextBox
End Class
