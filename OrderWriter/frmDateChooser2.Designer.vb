<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateChooser2
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
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.cmbHearing = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNumber = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDWM = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1030, 484)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(13, 483)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Button2"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'cmbHearing
        '
        Me.cmbHearing.FormattingEnabled = True
        Me.cmbHearing.Location = New System.Drawing.Point(683, 192)
        Me.cmbHearing.Name = "cmbHearing"
        Me.cmbHearing.Size = New System.Drawing.Size(237, 21)
        Me.cmbHearing.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(572, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "before "
        '
        'cmbNumber
        '
        Me.cmbNumber.FormattingEnabled = True
        Me.cmbNumber.ItemHeight = 13
        Me.cmbNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbNumber.Location = New System.Drawing.Point(146, 192)
        Me.cmbNumber.Name = "cmbNumber"
        Me.cmbNumber.Size = New System.Drawing.Size(121, 21)
        Me.cmbNumber.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Number"
        '
        'cmbDWM
        '
        Me.cmbDWM.FormattingEnabled = True
        Me.cmbDWM.ItemHeight = 13
        Me.cmbDWM.Items.AddRange(New Object() {"days", "weeks", "months"})
        Me.cmbDWM.Location = New System.Drawing.Point(373, 192)
        Me.cmbDWM.Name = "cmbDWM"
        Me.cmbDWM.Size = New System.Drawing.Size(121, 21)
        Me.cmbDWM.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "days/weeks/months"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(680, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type of Hearing"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(711, 219)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(394, 248)
        Me.TextBox1.TabIndex = 9
        '
        'frmDateChooser2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 546)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDWM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHearing)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmDateChooser2"
        Me.Text = "Date for Compliance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents cmbHearing As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNumber As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDWM As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
