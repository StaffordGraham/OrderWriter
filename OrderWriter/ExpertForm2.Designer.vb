<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpertForm2
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
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.cmbPayer1 = New System.Windows.Forms.ComboBox()
        Me.cmbLoIDrafter = New System.Windows.Forms.ComboBox()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.dtpLoIDrafted = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpertInform = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.dtpLoISent = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.dtpRepFilServ = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion5 = New System.Windows.Forms.Label()
        Me.lblQuestion6 = New System.Windows.Forms.Label()
        Me.dtpExpertReply = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion7 = New System.Windows.Forms.Label()
        Me.cmbPayer2 = New System.Windows.Forms.ComboBox()
        Me.lblQuestion8 = New System.Windows.Forms.Label()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.lblQuestion9 = New System.Windows.Forms.Label()
        Me.lblQuestion5a = New System.Windows.Forms.Label()
        Me.dtpQtoExpert = New System.Windows.Forms.DateTimePicker()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Location = New System.Drawing.Point(145, 83)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion1.TabIndex = 0
        Me.lblQuestion1.Text = "Label1"
        '
        'cmbPayer1
        '
        Me.cmbPayer1.FormattingEnabled = True
        Me.cmbPayer1.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbPayer1.Location = New System.Drawing.Point(516, 286)
        Me.cmbPayer1.Name = "cmbPayer1"
        Me.cmbPayer1.Size = New System.Drawing.Size(247, 21)
        Me.cmbPayer1.TabIndex = 1
        '
        'cmbLoIDrafter
        '
        Me.cmbLoIDrafter.BackColor = System.Drawing.Color.White
        Me.cmbLoIDrafter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoIDrafter.ForeColor = System.Drawing.Color.Navy
        Me.cmbLoIDrafter.FormattingEnabled = True
        Me.cmbLoIDrafter.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbLoIDrafter.Location = New System.Drawing.Point(515, 75)
        Me.cmbLoIDrafter.Name = "cmbLoIDrafter"
        Me.cmbLoIDrafter.Size = New System.Drawing.Size(248, 21)
        Me.cmbLoIDrafter.TabIndex = 3
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(145, 122)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(57, 20)
        Me.lblQuestion2.TabIndex = 2
        Me.lblQuestion2.Text = "Label1"
        '
        'dtpLoIDrafted
        '
        Me.dtpLoIDrafted.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLoIDrafted.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpLoIDrafted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLoIDrafted.Location = New System.Drawing.Point(515, 122)
        Me.dtpLoIDrafted.Name = "dtpLoIDrafted"
        Me.dtpLoIDrafted.Size = New System.Drawing.Size(248, 20)
        Me.dtpLoIDrafted.TabIndex = 5
        '
        'dtpExpertInform
        '
        Me.dtpExpertInform.Location = New System.Drawing.Point(563, 474)
        Me.dtpExpertInform.Name = "dtpExpertInform"
        Me.dtpExpertInform.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpertInform.TabIndex = 6
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Location = New System.Drawing.Point(148, 164)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion3.TabIndex = 7
        Me.lblQuestion3.Text = "Label1"
        '
        'dtpLoISent
        '
        Me.dtpLoISent.Location = New System.Drawing.Point(515, 164)
        Me.dtpLoISent.Name = "dtpLoISent"
        Me.dtpLoISent.Size = New System.Drawing.Size(248, 20)
        Me.dtpLoISent.TabIndex = 8
        '
        'lblQuestion4
        '
        Me.lblQuestion4.AutoSize = True
        Me.lblQuestion4.Location = New System.Drawing.Point(148, 206)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion4.TabIndex = 9
        Me.lblQuestion4.Text = "Label1"
        '
        'dtpRepFilServ
        '
        Me.dtpRepFilServ.Location = New System.Drawing.Point(515, 199)
        Me.dtpRepFilServ.Name = "dtpRepFilServ"
        Me.dtpRepFilServ.Size = New System.Drawing.Size(248, 20)
        Me.dtpRepFilServ.TabIndex = 10
        '
        'lblQuestion5
        '
        Me.lblQuestion5.AutoSize = True
        Me.lblQuestion5.Location = New System.Drawing.Point(145, 286)
        Me.lblQuestion5.Name = "lblQuestion5"
        Me.lblQuestion5.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion5.TabIndex = 11
        Me.lblQuestion5.Text = "Label1"
        '
        'lblQuestion6
        '
        Me.lblQuestion6.AutoSize = True
        Me.lblQuestion6.Location = New System.Drawing.Point(151, 325)
        Me.lblQuestion6.Name = "lblQuestion6"
        Me.lblQuestion6.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion6.TabIndex = 12
        Me.lblQuestion6.Text = "Label1"
        '
        'dtpExpertReply
        '
        Me.dtpExpertReply.Location = New System.Drawing.Point(516, 325)
        Me.dtpExpertReply.Name = "dtpExpertReply"
        Me.dtpExpertReply.Size = New System.Drawing.Size(247, 20)
        Me.dtpExpertReply.TabIndex = 13
        '
        'lblQuestion7
        '
        Me.lblQuestion7.AutoSize = True
        Me.lblQuestion7.Location = New System.Drawing.Point(151, 364)
        Me.lblQuestion7.Name = "lblQuestion7"
        Me.lblQuestion7.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion7.TabIndex = 14
        Me.lblQuestion7.Text = "Label1"
        '
        'cmbPayer2
        '
        Me.cmbPayer2.FormattingEnabled = True
        Me.cmbPayer2.Items.AddRange(New Object() {"Applicant", "Respondent", "Both", "The party putting the question"})
        Me.cmbPayer2.Location = New System.Drawing.Point(530, 356)
        Me.cmbPayer2.Name = "cmbPayer2"
        Me.cmbPayer2.Size = New System.Drawing.Size(233, 21)
        Me.cmbPayer2.TabIndex = 15
        '
        'lblQuestion8
        '
        Me.lblQuestion8.AutoSize = True
        Me.lblQuestion8.Location = New System.Drawing.Point(151, 411)
        Me.lblQuestion8.Name = "lblQuestion8"
        Me.lblQuestion8.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion8.TabIndex = 16
        Me.lblQuestion8.Text = "Label1"
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(516, 411)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(116, 17)
        Me.rdoYes.TabIndex = 17
        Me.rdoYes.Text = "Yes, unless notified"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Checked = True
        Me.rdoNo.Location = New System.Drawing.Point(658, 411)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(116, 17)
        Me.rdoNo.TabIndex = 18
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No, unless required"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'lblQuestion9
        '
        Me.lblQuestion9.AutoSize = True
        Me.lblQuestion9.Location = New System.Drawing.Point(148, 479)
        Me.lblQuestion9.Name = "lblQuestion9"
        Me.lblQuestion9.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion9.TabIndex = 19
        Me.lblQuestion9.Text = "Label1"
        '
        'lblQuestion5a
        '
        Me.lblQuestion5a.AutoSize = True
        Me.lblQuestion5a.Location = New System.Drawing.Point(145, 243)
        Me.lblQuestion5a.Name = "lblQuestion5a"
        Me.lblQuestion5a.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion5a.TabIndex = 20
        Me.lblQuestion5a.Text = "Label1"
        '
        'dtpQtoExpert
        '
        Me.dtpQtoExpert.Location = New System.Drawing.Point(515, 243)
        Me.dtpQtoExpert.Name = "dtpQtoExpert"
        Me.dtpQtoExpert.Size = New System.Drawing.Size(248, 20)
        Me.dtpQtoExpert.TabIndex = 21
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(863, 468)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(30, 475)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 23
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(805, 64)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(359, 281)
        Me.txtTest.TabIndex = 24
        '
        'ExpertForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1438, 679)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.dtpQtoExpert)
        Me.Controls.Add(Me.lblQuestion5a)
        Me.Controls.Add(Me.lblQuestion9)
        Me.Controls.Add(Me.rdoNo)
        Me.Controls.Add(Me.rdoYes)
        Me.Controls.Add(Me.lblQuestion8)
        Me.Controls.Add(Me.cmbPayer2)
        Me.Controls.Add(Me.lblQuestion7)
        Me.Controls.Add(Me.dtpExpertReply)
        Me.Controls.Add(Me.lblQuestion6)
        Me.Controls.Add(Me.lblQuestion5)
        Me.Controls.Add(Me.dtpRepFilServ)
        Me.Controls.Add(Me.lblQuestion4)
        Me.Controls.Add(Me.dtpLoISent)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.dtpExpertInform)
        Me.Controls.Add(Me.dtpLoIDrafted)
        Me.Controls.Add(Me.cmbLoIDrafter)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.cmbPayer1)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Name = "ExpertForm2"
        Me.Text = "ExpertForm2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents cmbPayer1 As ComboBox
    Friend WithEvents cmbLoIDrafter As ComboBox
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents dtpLoIDrafted As DateTimePicker
    Friend WithEvents dtpExpertInform As DateTimePicker
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents dtpLoISent As DateTimePicker
    Friend WithEvents lblQuestion4 As Label
    Friend WithEvents dtpRepFilServ As DateTimePicker
    Friend WithEvents lblQuestion5 As Label
    Friend WithEvents lblQuestion6 As Label
    Friend WithEvents dtpExpertReply As DateTimePicker
    Friend WithEvents lblQuestion7 As Label
    Friend WithEvents cmbPayer2 As ComboBox
    Friend WithEvents lblQuestion8 As Label
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents lblQuestion9 As Label
    Friend WithEvents lblQuestion5a As Label
    Friend WithEvents dtpQtoExpert As DateTimePicker
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents txtTest As TextBox
End Class
