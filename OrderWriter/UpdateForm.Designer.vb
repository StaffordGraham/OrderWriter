<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.chkInvestInc = New System.Windows.Forms.CheckBox()
        Me.chkTaxReturn = New System.Windows.Forms.CheckBox()
        Me.chkP60 = New System.Windows.Forms.CheckBox()
        Me.chkPensionCEV = New System.Windows.Forms.CheckBox()
        Me.chkBusinessAccounts = New System.Windows.Forms.CheckBox()
        Me.chkLiabilities = New System.Windows.Forms.CheckBox()
        Me.chkPolicies = New System.Windows.Forms.CheckBox()
        Me.chkDividends = New System.Windows.Forms.CheckBox()
        Me.chkInvestments = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTest)
        Me.GroupBox1.Controls.Add(Me.chkInvestInc)
        Me.GroupBox1.Controls.Add(Me.chkTaxReturn)
        Me.GroupBox1.Controls.Add(Me.chkP60)
        Me.GroupBox1.Controls.Add(Me.chkPensionCEV)
        Me.GroupBox1.Controls.Add(Me.chkBusinessAccounts)
        Me.GroupBox1.Controls.Add(Me.chkLiabilities)
        Me.GroupBox1.Controls.Add(Me.chkPolicies)
        Me.GroupBox1.Controls.Add(Me.chkDividends)
        Me.GroupBox1.Controls.Add(Me.chkInvestments)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Updating Disclosure Shall Mean"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(403, 21)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(421, 181)
        Me.txtTest.TabIndex = 9
        '
        'chkInvestInc
        '
        Me.chkInvestInc.AutoSize = True
        Me.chkInvestInc.Location = New System.Drawing.Point(20, 351)
        Me.chkInvestInc.Name = "chkInvestInc"
        Me.chkInvestInc.Size = New System.Drawing.Size(116, 17)
        Me.chkInvestInc.TabIndex = 8
        Me.chkInvestInc.Text = "Investment Income"
        Me.chkInvestInc.UseVisualStyleBackColor = True
        '
        'chkTaxReturn
        '
        Me.chkTaxReturn.AutoSize = True
        Me.chkTaxReturn.Location = New System.Drawing.Point(20, 313)
        Me.chkTaxReturn.Name = "chkTaxReturn"
        Me.chkTaxReturn.Size = New System.Drawing.Size(84, 17)
        Me.chkTaxReturn.TabIndex = 7
        Me.chkTaxReturn.Text = "Tax Returns"
        Me.chkTaxReturn.UseVisualStyleBackColor = True
        '
        'chkP60
        '
        Me.chkP60.AutoSize = True
        Me.chkP60.Location = New System.Drawing.Point(20, 274)
        Me.chkP60.Name = "chkP60"
        Me.chkP60.Size = New System.Drawing.Size(133, 17)
        Me.chkP60.TabIndex = 6
        Me.chkP60.Text = "P60s && P11D&&Payslips"
        Me.chkP60.UseVisualStyleBackColor = True
        '
        'chkPensionCEV
        '
        Me.chkPensionCEV.AutoSize = True
        Me.chkPensionCEV.Location = New System.Drawing.Point(16, 219)
        Me.chkPensionCEV.Name = "chkPensionCEV"
        Me.chkPensionCEV.Size = New System.Drawing.Size(88, 17)
        Me.chkPensionCEV.TabIndex = 5
        Me.chkPensionCEV.Text = "Pension CEV"
        Me.chkPensionCEV.UseVisualStyleBackColor = True
        '
        'chkBusinessAccounts
        '
        Me.chkBusinessAccounts.AutoSize = True
        Me.chkBusinessAccounts.Location = New System.Drawing.Point(20, 185)
        Me.chkBusinessAccounts.Name = "chkBusinessAccounts"
        Me.chkBusinessAccounts.Size = New System.Drawing.Size(116, 17)
        Me.chkBusinessAccounts.TabIndex = 4
        Me.chkBusinessAccounts.Text = "Business Accounts"
        Me.chkBusinessAccounts.UseVisualStyleBackColor = True
        '
        'chkLiabilities
        '
        Me.chkLiabilities.AutoSize = True
        Me.chkLiabilities.Location = New System.Drawing.Point(20, 137)
        Me.chkLiabilities.Name = "chkLiabilities"
        Me.chkLiabilities.Size = New System.Drawing.Size(68, 17)
        Me.chkLiabilities.TabIndex = 3
        Me.chkLiabilities.Text = "Liabilities"
        Me.chkLiabilities.UseVisualStyleBackColor = True
        '
        'chkPolicies
        '
        Me.chkPolicies.AutoSize = True
        Me.chkPolicies.Location = New System.Drawing.Point(20, 100)
        Me.chkPolicies.Name = "chkPolicies"
        Me.chkPolicies.Size = New System.Drawing.Size(62, 17)
        Me.chkPolicies.TabIndex = 2
        Me.chkPolicies.Text = "Policies"
        Me.chkPolicies.UseVisualStyleBackColor = True
        '
        'chkDividends
        '
        Me.chkDividends.AutoSize = True
        Me.chkDividends.Location = New System.Drawing.Point(20, 64)
        Me.chkDividends.Name = "chkDividends"
        Me.chkDividends.Size = New System.Drawing.Size(73, 17)
        Me.chkDividends.TabIndex = 1
        Me.chkDividends.Text = "Dividends"
        Me.chkDividends.UseVisualStyleBackColor = True
        '
        'chkInvestments
        '
        Me.chkInvestments.AutoSize = True
        Me.chkInvestments.Location = New System.Drawing.Point(20, 30)
        Me.chkInvestments.Name = "chkInvestments"
        Me.chkInvestments.Size = New System.Drawing.Size(83, 17)
        Me.chkInvestments.TabIndex = 0
        Me.chkInvestments.Text = "Investments"
        Me.chkInvestments.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1057, 533)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(13, 517)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 568)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UpdateForm"
        Me.Tag = "UpdateForm"
        Me.Text = "Updating Disclosure"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkInvestInc As CheckBox
    Friend WithEvents chkTaxReturn As CheckBox
    Friend WithEvents chkP60 As CheckBox
    Friend WithEvents chkPensionCEV As CheckBox
    Friend WithEvents chkBusinessAccounts As CheckBox
    Friend WithEvents chkLiabilities As CheckBox
    Friend WithEvents chkPolicies As CheckBox
    Friend WithEvents chkDividends As CheckBox
    Friend WithEvents chkInvestments As CheckBox
    Friend WithEvents txtTest As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
