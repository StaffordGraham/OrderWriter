Public Class RepSchedDefForm
    Private Sub RepSchedDefForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub RepSchedDef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Both.AccusativePronoun = "Them"
        Both.NominativePronoun = "Both Parties"
        ' Both.PossesivePronoun = "Their"

    End Sub
    Private Sub Unlading()

        Select Case cmbAppliesTo.Text
            Case "Applicant"
                RepSchedDef.AppliesTo = Applicant
                RepSchedDef.OtherParty = Respondent
            Case "Respondent"
                RepSchedDef.AppliesTo = Respondent
                RepSchedDef.OtherParty = Applicant

            Case "Both"
                RepSchedDef.AppliesTo = Both
                RepSchedDef.OtherParty = Both
                RepSchedDef.Both = True



        End Select

        RepSchedDef.Exception = cmbException.SelectedIndex


        'End Select

        RepSchedDef.ComplianceDate = dtpCompliance.Value.ToLongDateString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()
        RepSchedDef.JoinUp()
        txtTest.Text = RepSchedDef.FullOrderPara


    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                RepSchedDef.AppliesTo = Applicant
                RepSchedDef.OtherParty = Respondent
                RepSchedDef.AppliesTo.SetPronouns()
                RepSchedDef.OtherParty.SetPronouns()
                Label3.Text = RepSchedDef.OtherParty.Name
                lblDocs.Text = RepSchedDef.AppliesTo.PossessivePronoun + " replies to the " + RepSchedDef.OtherParty.Name + "'s schedule of deficiencies and supplemental questionnaire and request for further documents "

            Case "Respondent"
                RepSchedDef.AppliesTo = Respondent
                RepSchedDef.OtherParty = Applicant
                RepSchedDef.AppliesTo.SetPronouns()
                RepSchedDef.OtherParty.SetPronouns()
                Label3.Text = RepSchedDef.OtherParty.Name
                lblDocs.Text = RepSchedDef.AppliesTo.PossessivePronoun + " replies to the " + RepSchedDef.OtherParty.Name + "'s schedule of deficiencies and supplemental questionnaire and request for further documents "


            Case "Both"
                RepSchedDef.Both = True

                RepSchedDef.AppliesTo = Both
                RepSchedDef.OtherParty = Both
                lblDocs.Text = " shall send to the court and serve on other party replies to the other’s schedule of deficiencies and supplemental questionnaire and request for further documents "
                Label3.Text = "theOther"

        End Select



        'Label3.Text = RepSchedDef.OtherParty.Name
        'lblDocs.Text = RepSchedDef.AppliesTo.PossessivePronoun + " replies to the " + RepSchedDef.OtherParty.Name + "'s schedule of deficiencies and supplemental questionnaire and request for further documents "


    End Sub

    Private Sub cmbException_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbException.SelectedIndexChanged

    End Sub
End Class