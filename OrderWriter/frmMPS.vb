Imports System.Text
Public Class frmMPS


    Public MPS As New MPSClass

    'Public RespMPS As MPSClass
    'Public Applicant As Party
    ' Public Respondent As Party




    Private Sub frmMPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Unlading()
        If cmbAppliesTo.Text = "Applicant " Then
            MPS.AppliesTo = Applicant
            MPS.OtherParty = Respondent
        Else
            MPS.AppliesTo = Respondent
            MPS.OtherParty = Applicant

            MPS.Payment = CDec(txtPayment.Text)
            MPS.Frequency = cmbFrequency.Text
            MPS.StartDate = dtpStartDate.Value.ToLongDateString
            MPS.GiveCredit = True
            MPS.CreditPayment = CDec(txtCreditPayment.Text)
            MPS.CreditDate = dtpCredit.Value.ToLongDateString





        End If








    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
Dim p As String
        Select Case cmbAppliesTo.SelectedText
            Case = "Applicant"
                cmbOtherParty.SelectedText = "Respondent"
                chklstEmpty(chklstEnd)

                chkCredit.Text = "The Applicant shall be given credit for the payment of £"
                chklstEnd.Items.Add("The Remarriage of the Respondent")
                chklstEnd.Items.Add("The Death of the Respondent")
                chklstEnd.Items.Add("The Disposal of the Respondent's application for financial remedy")
                chklstEnd.Items.Add("Further or Other Order")
            Case = "Respondent"
                chklstEmpty(chklstEnd)

                cmbOtherParty.Text = "Applicant"
                chkCredit.Text = "The Respondent shall be given credit for the payment of £"
                chklstEnd.Items.Add("The Remarriage of the Applicant")
                chklstEnd.Items.Add("The Death of the Applicant")
                chklstEnd.Items.Add("The Disposal of the Applicant's application for financial remedy")
                chklstEnd.Items.Add("Further or Other Order")
        End Select
    End Sub









    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Unlading()
        txtTest.Text = MPS.FullOrderPara

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb As New StringBuilder



        Dim i As Integer
        i = 1


        For Each item In chklstEnd.Items
            sb.Append("(")
            sb.Append(i.ToString)
            sb.Append(")")
            sb.Append(vbTab)
            sb.Append(item.ToString)
            sb.Append(vbCrLf)



            i = i + 1


        Next
        txtTest.Text = sb.ToString



    End Sub

    Private Sub chklstEnd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chklstEnd.SelectedIndexChanged

    End Sub

    Private Sub cmbAppliesTo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedValueChanged
        Select Case cmbAppliesTo.Text
            Case = "Applicant"
                chklstEmpty(chklstEnd)

                cmbOtherParty.Text = "Respondent"
                chkCredit.Text = "The Respondent shall be given credit for the payment of £"
                chklstEnd.Items.Add("The Remarriage of the Respondent")
                chklstEnd.Items.Add("The Death of the Respondent")
                chklstEnd.Items.Add("The Disposal of the Respondent's application for financial remedy")
                chklstEnd.Items.Add("Further or Other Order")
            Case = "Respondent"
                chklstEmpty(chklstEnd)
                cmbOtherParty.Text = "Applicant"
                chkCredit.Text = "The Applicant shall be given credit for the payment of £"
                chklstEnd.Items.Add("The Remarriage of the Applicant")
                chklstEnd.Items.Add("The Death of the Applicant")
                chklstEnd.Items.Add("The Disposal of the Applicant's application for financial remedy")
                chklstEnd.Items.Add("Further or Other Order")
        End Select



    End Sub
End Class