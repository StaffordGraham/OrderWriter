Imports System.Text

Public Class OtherEvidenceForm
    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Dim ord1 As New StringBuilder
        Dim ord2 As New StringBuilder
        Dim ord3 As New StringBuilder
        ord1.Append(" has permission to send to the court and serve on the ")
        If cmbAppliesTo.Text = "Applicant" Then
            OtherEvidenceObj.AppliesTo = Applicant
            OtherEvidenceObj.OtherParty = Respondent
        Else
            OtherEvidenceObj.AppliesTo = Respondent
            OtherEvidenceObj.OtherParty = Applicant
        End If

        ord1.Append(OtherEvidenceObj.OtherParty.PartyType)

        Label4.Text = ord1.ToString

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEvidenceForm.SelectedIndexChanged

    End Sub

    Private Sub OtherEvidenceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Unlading()
        If cmbAppliesTo.Text = "Applicant" Then
            OtherEvidenceObj.AppliesTo = Applicant
            OtherEvidenceObj.OtherParty = Respondent
        Else
            OtherEvidenceObj.AppliesTo = Respondent
            OtherEvidenceObj.OtherParty = Applicant
        End If
        If chkIfSoAdvised.Checked Then

            OtherEvidenceObj.IfAdvised = True
        End If
        If chkLimitIssue.Checked Then
            OtherEvidenceObj.ThereIsIssue = True

        End If

        If chkDealIssue.Checked = True Then
            OtherEvidenceObj.DealWithIssue = True

        End If


        OtherEvidenceObj.EvidenceForm = cmbEvidenceForm.Text
            OtherEvidenceObj.EvidenceSource = txtEvidenceSource.Text
        OtherEvidenceObj.ComplianceDate = dtpCompliance.Value.ToLongDateString
        OtherEvidenceObj.Issue = txtTheIssue.Text

    End Sub


    Public Function IsItChecked(a As String, c As CheckedListBox) As Boolean
        For Each item In c.CheckedItems
            If item = a Then
                IsItChecked = True
                Exit Function

            End If
        Next

    End Function


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()

        OtherEvidenceObj.JoinUp()

        txtTest.Text = OtherEvidenceObj.FullOrderPara

    End Sub

    Private Sub chkLimitIssue_CheckedChanged(sender As Object, e As EventArgs) Handles chkLimitIssue.CheckedChanged
        If chkLimitIssue.Checked = True Then


            txtTheIssue.Enabled = True
            chkDealIssue.Checked = False
            If chkDealIssue.Checked = True Then

            End If
        End If

    End Sub

    Private Sub chkDealIssue_CheckedChanged(sender As Object, e As EventArgs) Handles chkDealIssue.CheckedChanged
        If chkDealIssue.Checked = True Then
            chkLimitIssue.Checked = False
            txtTheIssue.Enabled = True

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class