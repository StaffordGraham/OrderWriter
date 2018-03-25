<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplianceDateForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoFixedDate = New System.Windows.Forms.RadioButton()
        Me.rdoWeeksBefore = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "When do you want the updating disclosure to take place"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoWeeksBefore)
        Me.GroupBox1.Controls.Add(Me.rdoFixedDate)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 274)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdoFixedDate
        '
        Me.rdoFixedDate.AutoSize = True
        Me.rdoFixedDate.Location = New System.Drawing.Point(71, 62)
        Me.rdoFixedDate.Name = "rdoFixedDate"
        Me.rdoFixedDate.Size = New System.Drawing.Size(95, 17)
        Me.rdoFixedDate.TabIndex = 0
        Me.rdoFixedDate.TabStop = True
        Me.rdoFixedDate.Text = "By a fixed date"
        Me.rdoFixedDate.UseVisualStyleBackColor = True
        '
        'rdoWeeksBefore
        '
        Me.rdoWeeksBefore.AutoSize = True
        Me.rdoWeeksBefore.Location = New System.Drawing.Point(71, 129)
        Me.rdoWeeksBefore.Name = "rdoWeeksBefore"
        Me.rdoWeeksBefore.Size = New System.Drawing.Size(194, 17)
        Me.rdoWeeksBefore.TabIndex = 1
        Me.rdoWeeksBefore.TabStop = True
        Me.rdoWeeksBefore.Text = "Specified Time Before Next Hearing"
        Me.rdoWeeksBefore.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1125, 511)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(65, 529)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'ComplianceDateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 576)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ComplianceDateForm"
        Me.Text = "ComplianceDateForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoWeeksBefore As RadioButton
    Friend WithEvents rdoFixedDate As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
