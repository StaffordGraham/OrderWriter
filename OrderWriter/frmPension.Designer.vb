<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPension
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
        Me.txtProvider = New System.Windows.Forms.TextBox()
        Me.cmbInfo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.rtbTest = New System.Windows.Forms.RichTextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insert Name of Pension Provideer && choose the information required and date for " &
    "filing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Name of Pension Provider"
        '
        'txtProvider
        '
        Me.txtProvider.Location = New System.Drawing.Point(427, 144)
        Me.txtProvider.Multiline = True
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(178, 20)
        Me.txtProvider.TabIndex = 2
        '
        'cmbInfo
        '
        Me.cmbInfo.FormattingEnabled = True
        Me.cmbInfo.Items.AddRange(New Object() {"Form P1 (Pension Enquiry Form)", "Info Required by Regs"})
        Me.cmbInfo.Location = New System.Drawing.Point(427, 198)
        Me.cmbInfo.Name = "cmbInfo"
        Me.cmbInfo.Size = New System.Drawing.Size(178, 21)
        Me.cmbInfo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select the Information Required"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Select the Date for Filing"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(427, 272)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'rtbTest
        '
        Me.rtbTest.Location = New System.Drawing.Point(745, 132)
        Me.rtbTest.Name = "rtbTest"
        Me.rtbTest.Size = New System.Drawing.Size(314, 257)
        Me.rtbTest.TabIndex = 8
        Me.rtbTest.Text = ""
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1013, 530)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(70, 529)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmPension
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1122, 595)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rtbTest)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbInfo)
        Me.Controls.Add(Me.txtProvider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "frmPension"
        Me.Text = "frmPension"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProvider As TextBox
    Friend WithEvents cmbInfo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents rtbTest As RichTextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
