Public Class frmReplyQuaire
    Dim Both As New Party


    Private Sub ReplyQuaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Both.AccusativePronoun = "Them"
        Both.NominativePronoun = "Both Parties"
        ' Both.PossesivePronoun = "Their"

    End Sub
    Private Sub Unlading()

        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ReplyQuaire.AppliesTo = Applicant
                ReplyQuaire.OtherParty = Respondent
            Case "Respondent"
                ReplyQuaire.AppliesTo = Respondent
                ReplyQuaire.OtherParty = Applicant

            Case "Both"
                ReplyQuaire.AppliesTo = Both
                ReplyQuaire.OtherParty = Both



        End Select

        ReplyQuaire.Exception = cmbException.SelectedIndex



        'End Select

        ReplyQuaire.ComplianceDate = dtpCompliance.Value.ToLongDateString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()
        ReplyQuaire.JoinUp()
        txtTest.Text = ReplyQuaire.FullOrderPara


    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ReplyQuaire.AppliesTo = Applicant
                ReplyQuaire.OtherParty = Respondent
            Case "Respondent"
                ReplyQuaire.AppliesTo = Respondent
                ReplyQuaire.OtherParty = Applicant

            Case "Both"
                ReplyQuaire.AppliesTo = Both
                ReplyQuaire.OtherParty = Both



        End Select
        ReplyQuaire.AppliesTo.SetPronouns()
        ReplyQuaire.OtherParty.SetPronouns()


        Label3.Text = ReplyQuaire.OtherParty.Name

        lblHisHers.Text = ReplyQuaire.AppliesTo.PossessivePronoun + " replies to the " + ReplyQuaire.OtherParty.Name + "'s questionnaire  and request for further documents"


    End Sub

    Private Sub cmbException_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbException.SelectedIndexChanged

    End Sub
End Class