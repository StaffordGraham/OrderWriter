Public Class VarySettlementForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()
        VarySettlementOrder.JoinUp()

        txtTest.Text = VarySettlementOrder.FullOrderPara

    End Sub
    Private Sub Unlading()

        Select Case cmbAppliesTo.Text
            Case "Applicant"
                VarySettlementOrder.AppliesTo = Applicant
            Case "Respondent"
                VarySettlementOrder.AppliesTo = Respondent
        End Select

        VarySettlementOrder.Doc1 = txtDoc1.Text
                VarySettlementOrder.Doc2 = txtDoc2.Text

                VarySettlementOrder.Bene1 = txtBen1.Text
                VarySettlementOrder.Bene2 = txtBen2.Text
                VarySettlementOrder.Bene3 = txtBen3.Text
                VarySettlementOrder.ComplianceDate = dtpComplianceDate1.Value.ToLongDateString
                VarySettlementOrder.ComplianceDate2 = dtpComplianceDate2.Value.ToLongDateString





    End Sub

    Private Sub VarySettlementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class