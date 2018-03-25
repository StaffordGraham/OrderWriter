Imports System.Text

Public Class StatementForm
    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                StatementOrder.AppliesTo = Applicant
                StatementOrder.OtherParty = Respondent

        End Select


        Dim ord As New StringBuilder
        Dim ord2 As New StringBuilder

        Dim p As String
        If cmbAppliesTo.Text = "Both" Then
            ord.Append("parties shall send to the court and serve on the other ")
            ord2.Append("a concise narrative statement dealing with all of the relevant factors listed in ")
        Else


            ord.Append("The ")

            ord.Append("  shall send to the court and serve on the ")
            ord.Append(StatementOrder.OtherParty.PartyType)
            ord2.Append("a concise narrative statement dealing with all of the relevant factors listed in ")
        End If


        lblOrd.Text = ord.ToString

            lblOrd2.Text = ord2.ToString



    End Sub

    Private Sub StatementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatute.Text = Dossier.Statute + StatSection(Dossier.Statute)


    End Sub
    Private Function StatSection(stat As String) As String
        Select Case stat
            Case "The Matrimonial Causes Act 1973"
                StatSection = "Section 25  "
            Case "Case The Civil Partnership Act 2004"
                StatSection = "Schedule 5 para 20(2)"
            Case "The Child Support Act 1991 "
            Case "Schedule 1 to the Children Act 1989"
                StatSection = "Schedule 1 Para 4"
            Case "The Inheritance(Provision For Family And Dependants) Act 1975 "
                StatSection = "Section 3 "
            Case "The Matrimonial And Family Proceedings Act 1984 And Schedule 7 to the Civil Partnership Act 2004"
                StatSection = "Section 3"

            Case "The Trusts of Land And Appointment of Trustees Act 1996"
                StatSection = "Section 15"
            Case "The Married Women's Property Act 1882 and ss 67,68 and 74 of the Civil Partnership Act 2004"

        End Select
    End Function

    Private Sub cmbStatute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatute.SelectedIndexChanged
        cmbAppliesTo.Text = cmbStatute.Text + StatSection(cmbStatute.Text)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        StatementOrder.ComplianceDate = dtpCompliance.Value.ToLongDateString
        Unlading()

        StatementOrder.JoinUp()

        txtTest.Text = StatementOrder.FullOrderPara

    End Sub
    Public Sub Unlading()
        Select Case cmbAppliesTo.Text
            Case "Both"
                StatementOrder.Both = True
            Case "Applicant"
                StatementOrder.AppliesTo = Applicant
                StatementOrder.OtherParty = Respondent
                StatementOrder.Both = False
            Case "Respondent"
                StatementOrder.AppliesTo = Respondent
                StatementOrder.OtherParty = Applicant
                StatementOrder.Both = False

        End Select


    End Sub
End Class