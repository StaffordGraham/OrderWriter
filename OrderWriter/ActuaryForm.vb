Public Class ActuaryForm
    Private Sub ActuaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Unlading()

        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ActuaryOrder.AppliesTo = Applicant
                ActuaryOrder.OtherParty = Respondent
            Case "Respondent"
                ActuaryOrder.AppliesTo = Respondent
                ActuaryOrder.OtherParty = Applicant

        End Select

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        If rdoValuerKnown.Checked = True Then



            ActuaryForm2.Show()
            Me.Hide()


        End If
    End Sub
End Class