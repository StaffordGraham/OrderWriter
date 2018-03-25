Public Class ExpExchForm
  


    Public Sub Unlading()
        ExpExchOrder.ComplianceDate2 = dtpExpMeet.Value.ToLongDateString
        ' ExpExchOrder.discussion = txtDiscussion.Text
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ExpExchOrder.AppliesTo = Applicant
                ExpExchOrder.OtherParty = Respondent
            Case "Respondent"
                ExpExchOrder.AppliesTo = Respondent
                ExpExchOrder.AppliesTo = Applicant
            Case "Both"
                ExpExchOrder.AppliesTo = Both
                ExpExchOrder.OtherParty = OtherParty
                MsgBox(ExpExchOrder.AppliesTo.PartyType)

        End Select
        ExpExchOrder.ReportSubType = "Valuation Report "
        ExpExchOrder.AppliesTo.SetPronouns()
        ExpExchOrder.OtherParty.SetPronouns()


        ExpExchOrder.Joinup()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()

        txtTest.Text = ExpExchOrder.FullOrderPara

    End Sub

    Private Sub ExpExchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class