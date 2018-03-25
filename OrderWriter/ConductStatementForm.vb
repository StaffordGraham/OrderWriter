Public Class ConductStatementForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading

    End Sub
    Private Sub Unlading()
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ConductStatementObj.AppliesTo = Applicant
                ConductStatementObj.OtherParty = Respondent
            Case "Respondent"
                ConductStatementObj.AppliesTo = Respondent
                ConductStatementObj.OtherParty = Applicant

        End Select
        Respondent.SetPronouns()
        Applicant.SetPronouns()
        ConductStatementObj.ComplianceDate = dtpCompliance1.Value.ToLongDateString
        ConductStatementObj.ComplianceDate2 = dtpCompliance2.Value.ToLongDateString
        ConductStatementObj.PageLimit = CInt(txtPages.Text)
        ConductStatementObj.Joinup()
        txtTest.Text = ConductStatementObj.FullOrderPara

    End Sub

    Private Sub txtPages_TextChanged(sender As Object, e As EventArgs) Handles txtPages.TextChanged

    End Sub

    Private Sub txtPages_LostFocus(sender As Object, e As EventArgs) Handles txtPages.LostFocus
        Try
            Dim d As Integer
            d = CInt(txtPages.Text)
            'Catch


        Catch ex As Exception
            MsgBox("You must select a whole number of pages")
        End Try
    End Sub
End Class