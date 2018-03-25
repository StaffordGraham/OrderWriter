<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSelector
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
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lstOrdersSelected = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOrders
        '
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.Items.AddRange(New Object() {"25.Maintenance Pending Suit", "26.Legal Services Order", "27 & 28 Miam& FormE", "29 1st Appointment Documents", "30.Replies to questionnaire", "31.Schedule of Deficiencies and Supplemental Questionnaire", "32.Replies to schedule of deficiencies and supplemental questionnaire", "33.Statements", "34.Statements dealing with Conduct", "35.Permission regarding other evidence", "36.Evidence regarding mortgage raising capacity and housing needs", "37.Updating disclosure", "38.Expert Valuer", "40.Experts Exchange Reports", "68.Variation of Settlement", "Pensions Report", "Actuary Report", "69.Consolidation of Proceedings"})
        Me.lstOrders.Location = New System.Drawing.Point(106, 60)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(299, 498)
        Me.lstOrders.TabIndex = 0
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(56, 602)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(872, 602)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lstOrdersSelected
        '
        Me.lstOrdersSelected.FormattingEnabled = True
        Me.lstOrdersSelected.Location = New System.Drawing.Point(551, 60)
        Me.lstOrdersSelected.Name = "lstOrdersSelected"
        Me.lstOrdersSelected.Size = New System.Drawing.Size(299, 485)
        Me.lstOrdersSelected.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Orders Selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Choose from list below"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(441, 128)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(84, 28)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(441, 199)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmOrderSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 685)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOrdersSelected)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lstOrders)
        Me.Name = "frmOrderSelector"
        Me.Text = "frmOrderSelector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOrders As ListBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lstOrdersSelected As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnRemove As Button
End Class
