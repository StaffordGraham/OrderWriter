Public Class ConsolidateForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Private Sub Unlading()
        If chkAppliesToLead.Checked = True Then
            If cmbAppliesTo.Text = "Applicant" Then
                ConsolOrder.LeadParty = Applicant
            Else
                ConsolOrder.LeadParty = Respondent

                If cmbAppliesTo.Text = "Respondent" Then
                    ConsolOrder.LeadParty = Respondent
                End If

            End If
            End If
            ConsolOrder.App1 = cmbAppliesTo.Text
        ConsolOrder.App2 = cmbApp2.Text

        ConsolOrder.Doc1 = txtDoc1.Text
        ConsolOrder.Doc2 = txtDoc2.Text
        ConsolOrder.Doc3 = txtDoc3.Text



        ConsolOrder.ConsolCaseNo = txtCaseNo.Text
        Select Case cmbServingParty.Text
            Case "Applicant"

                ConsolOrder.ServingParty = Applicant
                ConsolOrder.ReceivingParty = Respondent
            Case "Respondent"
                ConsolOrder.ServingParty = Respondent
                ConsolOrder.ReceivingParty = Applicant


        End Select

        ConsolOrder.JoinUp()
        txtTest.Text = ConsolOrder.FullOrderPara

    End Sub
End Class