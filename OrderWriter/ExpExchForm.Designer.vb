<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpExchForm
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
        Me.dtpExpMeet = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpExchRep = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.txtDiscussion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAppliesTo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpExpMeet
        '
        Me.dtpExpMeet.Location = New System.Drawing.Point(472, 189)
        Me.dtpExpMeet.Name = "dtpExpMeet"
        Me.dtpExpMeet.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpMeet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date for Experts to Meet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date for Disclosure "
        '
        'dtpExchRep
        '
        Me.dtpExchRep.Location = New System.Drawing.Point(460, 73)
        Me.dtpExchRep.Name = "dtpExchRep"
        Me.dtpExchRep.Size = New System.Drawing.Size(200, 20)
        Me.dtpExchRep.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(783, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(38, 401)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(341, 146)
        Me.txtTest.TabIndex = 5
        '
        'txtDiscussion
        '
        Me.txtDiscussion.Location = New System.Drawing.Point(460, 236)
        Me.txtDiscussion.Multiline = True
        Me.txtDiscussion.Name = "txtDiscussion"
        Me.txtDiscussion.Size = New System.Drawing.Size(363, 101)
        Me.txtDiscussion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Issue for Experts to Discuss"
        '
        'cmbAppliesTo
        '
        Me.cmbAppliesTo.FormattingEnabled = True
        Me.cmbAppliesTo.Items.AddRange(New Object() {"Applicant", "Respondent", "Both"})
        Me.cmbAppliesTo.Location = New System.Drawing.Point(460, 13)
        Me.cmbAppliesTo.Name = "cmbAppliesTo"
        Me.cmbAppliesTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliesTo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Who is to be ordered to disclose their report"
        '
        'ExpExchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 559)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAppliesTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiscussion)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpExchRep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpExpMeet)
        Me.Name = "ExpExchForm"
        Me.Text = "ExpExchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpExpMeet As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpExchRep As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTest As TextBox
    Friend WithEvents txtDiscussion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbAppliesTo As ComboBox
    Friend WithEvents Label4 As Label
End Class
