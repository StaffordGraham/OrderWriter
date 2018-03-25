<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpertForm1a
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
        Me.cmbExpSubType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRepSubType = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.ForeColor = System.Drawing.Color.Navy
        Me.lblQuestion1.Location = New System.Drawing.Point(75, 69)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(55, 19)
        Me.lblQuestion1.TabIndex = 0
        Me.lblQuestion1.Text = "Label1"
        '
        'cmbExpSubType
        '
        Me.cmbExpSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpSubType.ForeColor = System.Drawing.Color.Navy
        Me.cmbExpSubType.FormattingEnabled = True
        Me.cmbExpSubType.Items.AddRange(New Object() {"an estate agent", "a chartered surveyor", "an appropriate expert"})
        Me.cmbExpSubType.Location = New System.Drawing.Point(544, 69)
        Me.cmbExpSubType.Name = "cmbExpSubType"
        Me.cmbExpSubType.Size = New System.Drawing.Size(189, 28)
        Me.cmbExpSubType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'cmbRepSubType
        '
        Me.cmbRepSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepSubType.ForeColor = System.Drawing.Color.Navy
        Me.cmbRepSubType.FormattingEnabled = True
        Me.cmbRepSubType.Items.AddRange(New Object() {"valuation report", "market appraisal"})
        Me.cmbRepSubType.Location = New System.Drawing.Point(544, 142)
        Me.cmbRepSubType.Name = "cmbRepSubType"
        Me.cmbRepSubType.Size = New System.Drawing.Size(180, 28)
        Me.cmbRepSubType.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(758, 490)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(44, 505)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'ExpertForm1a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 548)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cmbRepSubType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbExpSubType)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Name = "ExpertForm1a"
        Me.Text = "ExpertForm1a"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents cmbExpSubType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRepSubType As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
