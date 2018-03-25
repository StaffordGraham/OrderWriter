Public Class ExpertForm1
    Private Sub ExpertForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()


        ExpertForm1a.Show()
            Me.Hide()




        ' ExpertForm1a.Show()
        ' Me.Hide()

    End Sub
    Public Sub Unlading()
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                ValuerOrder.AppliesTo = Applicant
                ValuerOrder.OtherParty = Respondent
            Case "Respondent"
                ValuerOrder.AppliesTo = Respondent
                ValuerOrder.OtherParty = Applicant
            Case "Both"
                ValuerOrder.AppliesTo = Both
                ValuerOrder.OtherParty = Both



        End Select


        If rdoValKnown.Checked = True Then
            ValuerOrder.ExpertKnown = True
        Else
            ValuerOrder.ExpertKnown = False

        End If
        If rdoJoint.Checked Then
            ValuerOrder.SingleJointExpert = True

            ExpertOrder.AppliesTo = Both

        End If


    End Sub

    Private Sub ExpertForm1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        cmbAppliesTo.Text = "Applicant"
    End Sub

    Private Sub rdoSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingle.CheckedChanged
        If rdoSingle.Checked Then
            lblAppliesTo.Show()

            cmbAppliesTo.Show()
            cmbAppliesTo.Focus()



        End If
    End Sub

    Private Sub rdoJoint_CheckedChanged(sender As Object, e As EventArgs) Handles rdoJoint.CheckedChanged
        If rdoJoint.Checked Then
            lblAppliesTo.Hide()
            cmbAppliesTo.Hide()


        End If
    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        btnNext.Focus()

    End Sub
End Class