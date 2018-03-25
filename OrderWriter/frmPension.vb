Public Class frmPension
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        PensionValue.JoinUp()
        rtbTest.Text = PensionValue.FullOrderPara.ToString


    End Sub
    Private Sub Unlading()
        PensionValue.Provider = txtProvider.Text
        PensionValue.ComplianceDate = MonthCalendar1.SelectionRange.Start.ToLongDateString()
        Select Case cmbInfo.Text
            Case "Form P1 (Pension Enquiry Form)"
                PensionValue.Requirement = "A"

        End Select
    End Sub

    Private Sub frmPension_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class