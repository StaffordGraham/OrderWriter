Public Class frmSchedDef
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()
        txtTest.Text = SchedDef.FullOrderPara

    End Sub
    Private Sub Unlading()
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                SchedDef.AppliesTo = Applicant
                SchedDef.OtherParty = Respondent

            Case "Respondent"
                SchedDef.AppliesTo = Respondent
                SchedDef.OtherParty = Applicant




        End Select
        If chkIfAdv.Checked Then
            SchedDef.Exception = 0
        Else
            SchedDef.Exception = 1

        End If
        SchedDef.ComplianceDate = dtpCompliance.Value.ToLongDateString

        SchedDef.JoinUp()



    End Sub

    Private Sub cmbException_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                SchedDef.AppliesTo = Applicant
                SchedDef.OtherParty = Respondent
            Case "Respondent"
                SchedDef.AppliesTo = Respondent
                SchedDef.OtherParty = Applicant

            Case "Both"
                SchedDef.AppliesTo = Both
                SchedDef.OtherParty = Both



        End Select
        SchedDef.AppliesTo.SetPronouns()
        SchedDef.OtherParty.SetPronouns()

        lblOther.Text = "shall send to the court  and serve on  the " + SchedDef.OtherParty.Name

        'Label3.Text = SchedDef.OtherParty.Name

        lblHisHers.Text = "a schedule of deficiencies and supplemental questionnaire and request for further documents "

    End Sub

    Private Sub lblOther_Click(sender As Object, e As EventArgs) Handles lblOther.Click

    End Sub

    Private Sub lblHisHers_Click(sender As Object, e As EventArgs) Handles lblHisHers.Click

    End Sub

    Private Sub frmSchedDef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class