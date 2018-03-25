<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLSOPrelim
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
        Me.optLump = New System.Windows.Forms.RadioButton()
        Me.optPeriodic = New System.Windows.Forms.RadioButton()
        Me.optBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(596, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First you must state whether the Legal Services Order is a lump sum payment, peri" &
    "odic payments or both"
        '
        'optLump
        '
        Me.optLump.AutoSize = True
        Me.optLump.Location = New System.Drawing.Point(26, 83)
        Me.optLump.Name = "optLump"
        Me.optLump.Size = New System.Drawing.Size(83, 17)
        Me.optLump.TabIndex = 1
        Me.optLump.TabStop = True
        Me.optLump.Text = "Lump Sum"
        Me.optLump.UseVisualStyleBackColor = True
        '
        'optPeriodic
        '
        Me.optPeriodic.AutoSize = True
        Me.optPeriodic.Location = New System.Drawing.Point(238, 83)
        Me.optPeriodic.Name = "optPeriodic"
        Me.optPeriodic.Size = New System.Drawing.Size(71, 17)
        Me.optPeriodic.TabIndex = 2
        Me.optPeriodic.TabStop = True
        Me.optPeriodic.Text = "Periodic"
        Me.optPeriodic.UseVisualStyleBackColor = True
        '
        'optBoth
        '
        Me.optBoth.AutoSize = True
        Me.optBoth.Location = New System.Drawing.Point(523, 83)
        Me.optBoth.Name = "optBoth"
        Me.optBoth.Size = New System.Drawing.Size(51, 17)
        Me.optBoth.TabIndex = 3
        Me.optBoth.TabStop = True
        Me.optBoth.Text = "Both"
        Me.optBoth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optLump)
        Me.GroupBox1.Controls.Add(Me.optBoth)
        Me.GroupBox1.Controls.Add(Me.optPeriodic)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(165, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 195)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the form of the Legal Services Order"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(796, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmLSOPrelim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 530)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLSOPrelim"
        Me.Text = "frmLSOPrelim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents optLump As RadioButton
    Friend WithEvents optPeriodic As RadioButton
    Friend WithEvents optBoth As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
