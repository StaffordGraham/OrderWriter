<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActuaryForm3
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
        Me.dtpQtoExpert = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion5a = New System.Windows.Forms.Label()
        Me.lblQuestion9 = New System.Windows.Forms.Label()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.lblQuestion8 = New System.Windows.Forms.Label()
        Me.cmbPayer2 = New System.Windows.Forms.ComboBox()
        Me.lblQuestion7 = New System.Windows.Forms.Label()
        Me.dtpExpertReply = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion6 = New System.Windows.Forms.Label()
        Me.lblQuestion5 = New System.Windows.Forms.Label()
        Me.dtpRepFilServ = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.dtpLoISent = New System.Windows.Forms.DateTimePicker()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.dtpExpertInform = New System.Windows.Forms.DateTimePicker()
        Me.dtpLoIDrafted = New System.Windows.Forms.DateTimePicker()
        Me.cmbLoIDrafter = New System.Windows.Forms.ComboBox()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.cmbPayer1 = New System.Windows.Forms.ComboBox()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpQtoExpert
        '
        Me.dtpQtoExpert.Location = New System.Drawing.Point(878, 418)
        Me.dtpQtoExpert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpQtoExpert.Name = "dtpQtoExpert"
        Me.dtpQtoExpert.Size = New System.Drawing.Size(370, 27)
        Me.dtpQtoExpert.TabIndex = 42
        '
        'lblQuestion5a
        '
        Me.lblQuestion5a.AutoSize = True
        Me.lblQuestion5a.Location = New System.Drawing.Point(322, 418)
        Me.lblQuestion5a.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion5a.Name = "lblQuestion5a"
        Me.lblQuestion5a.Size = New System.Drawing.Size(210, 19)
        Me.lblQuestion5a.TabIndex = 41
        Me.lblQuestion5a.Text = "Date for Questions to Expert"
        '
        'lblQuestion9
        '
        Me.lblQuestion9.AutoSize = True
        Me.lblQuestion9.Location = New System.Drawing.Point(327, 763)
        Me.lblQuestion9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion9.Name = "lblQuestion9"
        Me.lblQuestion9.Size = New System.Drawing.Size(405, 19)
        Me.lblQuestion9.TabIndex = 40
        Me.lblQuestion9.Text = "Date Expert is to be Informed if needed at Final Hearing"
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Checked = True
        Me.rdoNo.Location = New System.Drawing.Point(1092, 664)
        Me.rdoNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(165, 23)
        Me.rdoNo.TabIndex = 39
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No, unless required"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(879, 664)
        Me.rdoYes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(164, 23)
        Me.rdoYes.TabIndex = 38
        Me.rdoYes.Text = "Yes, unless notified"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'lblQuestion8
        '
        Me.lblQuestion8.AutoSize = True
        Me.lblQuestion8.Location = New System.Drawing.Point(332, 664)
        Me.lblQuestion8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion8.Name = "lblQuestion8"
        Me.lblQuestion8.Size = New System.Drawing.Size(246, 19)
        Me.lblQuestion8.TabIndex = 37
        Me.lblQuestion8.Text = "Is Expert to Attend Final Hearing "
        '
        'cmbPayer2
        '
        Me.cmbPayer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPayer2.FormattingEnabled = True
        Me.cmbPayer2.Items.AddRange(New Object() {"Applicant", "Respondent", "Both", "The party putting the question"})
        Me.cmbPayer2.Location = New System.Drawing.Point(900, 583)
        Me.cmbPayer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPayer2.Name = "cmbPayer2"
        Me.cmbPayer2.Size = New System.Drawing.Size(348, 27)
        Me.cmbPayer2.TabIndex = 36
        '
        'lblQuestion7
        '
        Me.lblQuestion7.AutoSize = True
        Me.lblQuestion7.Location = New System.Drawing.Point(332, 595)
        Me.lblQuestion7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion7.Name = "lblQuestion7"
        Me.lblQuestion7.Size = New System.Drawing.Size(332, 19)
        Me.lblQuestion7.TabIndex = 35
        Me.lblQuestion7.Text = "Who Pays for the Expert o Answer Questions "
        '
        'dtpExpertReply
        '
        Me.dtpExpertReply.Location = New System.Drawing.Point(879, 538)
        Me.dtpExpertReply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpExpertReply.Name = "dtpExpertReply"
        Me.dtpExpertReply.Size = New System.Drawing.Size(368, 27)
        Me.dtpExpertReply.TabIndex = 34
        '
        'lblQuestion6
        '
        Me.lblQuestion6.AutoSize = True
        Me.lblQuestion6.Location = New System.Drawing.Point(332, 538)
        Me.lblQuestion6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion6.Name = "lblQuestion6"
        Me.lblQuestion6.Size = New System.Drawing.Size(179, 19)
        Me.lblQuestion6.TabIndex = 33
        Me.lblQuestion6.Text = "Date for Expert to Reply"
        '
        'lblQuestion5
        '
        Me.lblQuestion5.AutoSize = True
        Me.lblQuestion5.Location = New System.Drawing.Point(322, 481)
        Me.lblQuestion5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion5.Name = "lblQuestion5"
        Me.lblQuestion5.Size = New System.Drawing.Size(294, 19)
        Me.lblQuestion5.TabIndex = 32
        Me.lblQuestion5.Text = "Who Pays for the Report in first instance"
        '
        'dtpRepFilServ
        '
        Me.dtpRepFilServ.Location = New System.Drawing.Point(878, 354)
        Me.dtpRepFilServ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpRepFilServ.Name = "dtpRepFilServ"
        Me.dtpRepFilServ.Size = New System.Drawing.Size(370, 27)
        Me.dtpRepFilServ.TabIndex = 31
        '
        'lblQuestion4
        '
        Me.lblQuestion4.AutoSize = True
        Me.lblQuestion4.Location = New System.Drawing.Point(327, 364)
        Me.lblQuestion4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(161, 19)
        Me.lblQuestion4.TabIndex = 30
        Me.lblQuestion4.Text = "Date for Filing Report"
        '
        'dtpLoISent
        '
        Me.dtpLoISent.Location = New System.Drawing.Point(878, 303)
        Me.dtpLoISent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpLoISent.Name = "dtpLoISent"
        Me.dtpLoISent.Size = New System.Drawing.Size(370, 27)
        Me.dtpLoISent.TabIndex = 29
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Location = New System.Drawing.Point(327, 303)
        Me.lblQuestion3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(306, 19)
        Me.lblQuestion3.TabIndex = 28
        Me.lblQuestion3.Text = "When Should Letter of Instruction be Sent"
        '
        'dtpExpertInform
        '
        Me.dtpExpertInform.Location = New System.Drawing.Point(950, 756)
        Me.dtpExpertInform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpExpertInform.Name = "dtpExpertInform"
        Me.dtpExpertInform.Size = New System.Drawing.Size(298, 27)
        Me.dtpExpertInform.TabIndex = 27
        '
        'dtpLoIDrafted
        '
        Me.dtpLoIDrafted.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLoIDrafted.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpLoIDrafted.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLoIDrafted.Location = New System.Drawing.Point(878, 241)
        Me.dtpLoIDrafted.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpLoIDrafted.Name = "dtpLoIDrafted"
        Me.dtpLoIDrafted.Size = New System.Drawing.Size(370, 27)
        Me.dtpLoIDrafted.TabIndex = 26
        '
        'cmbLoIDrafter
        '
        Me.cmbLoIDrafter.BackColor = System.Drawing.Color.White
        Me.cmbLoIDrafter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoIDrafter.ForeColor = System.Drawing.Color.Navy
        Me.cmbLoIDrafter.FormattingEnabled = True
        Me.cmbLoIDrafter.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbLoIDrafter.Location = New System.Drawing.Point(878, 172)
        Me.cmbLoIDrafter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLoIDrafter.Name = "cmbLoIDrafter"
        Me.cmbLoIDrafter.Size = New System.Drawing.Size(370, 21)
        Me.cmbLoIDrafter.TabIndex = 25
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(322, 241)
        Me.lblQuestion2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(327, 19)
        Me.lblQuestion2.TabIndex = 24
        Me.lblQuestion2.Text = "When Should Letter of Instruction be Drafted"
        '
        'cmbPayer1
        '
        Me.cmbPayer1.FormattingEnabled = True
        Me.cmbPayer1.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbPayer1.Location = New System.Drawing.Point(879, 481)
        Me.cmbPayer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPayer1.Name = "cmbPayer1"
        Me.cmbPayer1.Size = New System.Drawing.Size(368, 27)
        Me.cmbPayer1.TabIndex = 23
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Location = New System.Drawing.Point(322, 184)
        Me.lblQuestion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(307, 19)
        Me.lblQuestion1.TabIndex = 22
        Me.lblQuestion1.Text = "Select Who is to Draft Letter of Instruction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Consequential Provisions for the Instruction of an Actuary/Pensions Report"
        '
        'ActuaryForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1588, 956)
        Me.Controls.Add(Me.Label1)
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
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ActuaryForm3"
        Me.Text = "ActuaryForm3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpQtoExpert As DateTimePicker
    Friend WithEvents lblQuestion5a As Label
    Friend WithEvents lblQuestion9 As Label
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents lblQuestion8 As Label
    Friend WithEvents cmbPayer2 As ComboBox
    Friend WithEvents lblQuestion7 As Label
    Friend WithEvents dtpExpertReply As DateTimePicker
    Friend WithEvents lblQuestion6 As Label
    Friend WithEvents lblQuestion5 As Label
    Friend WithEvents dtpRepFilServ As DateTimePicker
    Friend WithEvents lblQuestion4 As Label
    Friend WithEvents dtpLoISent As DateTimePicker
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents dtpExpertInform As DateTimePicker
    Friend WithEvents dtpLoIDrafted As DateTimePicker
    Friend WithEvents cmbLoIDrafter As ComboBox
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents cmbPayer1 As ComboBox
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents Label1 As Label
End Class
