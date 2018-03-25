Public Class MortCapForm
    Private Sub Label5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()
        txtText.Text = MortCapOrder.FullOrderPara

    End Sub
    Private Sub Unlading()
        MortCapOrder.ComplianceDate = dtpCompliance1.Value.ToLongDateString
        MortCapOrder.WhoseNeeds1 = cmbWhoseNeeds1.Text
        MortCapOrder.WhoseNeeds2 = cmbWhoseNeeds2.Text

        MortCapOrder.WeeksBefore = NumericUpDown1.Value
        If cmbHearingType.Text <> "[a specified date]" Then
            MortCapOrder.Hearing = cmbHearingType.Text
        End If
        MortCapOrder.JoinUp()



    End Sub

    Private Sub MortCapForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHearingType.SelectedIndexChanged
        If cmbHearingType.Text = "[a specified date]" Then
            dtpCompliance1.Enabled = True
        Else
            dtpCompliance1.Enabled = False
        End If





    End Sub
End Class