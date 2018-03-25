Public Class ExpertForm2
    Public Sub Lading()

        Fonting(Me)

        'For Each label In Me.Controls
        'Label.Font = New Font("Times New Roman", 12)




        'Next
    End Sub
    Public Sub Unlading()
        Select Case cmbLoIDrafter.Text
            Case "Applicant"

                ValuerOrder.LetterWriter = Applicant
            Case "Respondent"
                ValuerOrder.LetterWriter = Respondent


        End Select
        Select Case cmbPayer1.Text
            Case "Applicant"
                ValuerOrder.Payer = Applicant
            Case "Respondent"
                ValuerOrder.Payer = Respondent
            Case "Both"
                ValuerOrder.Payer = Both

        End Select
        Select Case cmbPayer2.Text
            Case "Applicant"
                ValuerOrder.Payer2 = Applicant
            Case "Respondent"
                ValuerOrder.Payer2 = Respondent
            Case "Both"
                ValuerOrder.Payer2 = Both

            Case "The Party putting the question"
                ValuerOrder.Payer2.PartyType = "The Party putting the question"



        End Select
        ValuerOrder.ComplianceDate = dtpLoIDrafted.Value.ToLongDateString
        ValuerOrder.ComplianceDate2 = dtpLoIDrafted.Value.ToLongDateString
        ValuerOrder.ComplianceDate3 = dtpLoISent.Value.ToLongDateString
        ValuerOrder.ComplianceDate4 = dtpRepFilServ.Value.ToLongDateString
        ValuerOrder.ComplianceDate5 = dtpQtoExpert.Value.ToLongDateString
        ValuerOrder.ComplianceDate6 = dtpExpertReply.Value.ToLongDateString
        ValuerOrder.ComplianceDate7 = dtpExpertInform.Value.ToLongDateString





    End Sub
    Private Sub ExpertForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lading()

        lblQuestion1.Text = "Which party will draft the letter of instruction?"
        lblQuestion2.Text = "By what date should the letter of instruction be drafted? "
        lblQuestion3.Text = "By what date should it be sent to the expert?"
        lblQuestion4.Text = "By what date should the expert's report  be filed and served?"
        lblQuestion5a.Text = "By what date should parties send questions to expert?"
        lblQuestion5.Text = "Who is to pay the expert's fees at the first instance?"
        lblQuestion6.Text = "By what date should expert reply to questions put by parties?"
        lblQuestion7.Text = "Who, in the first instance, should pay the expert's costs of replying to questions"
        lblQuestion8.Text = "Is the expert required to attend court?"

        Select Case rdoYes.Checked
            Case True
                lblQuestion9.Text = "By what date should the expert be notified that he does not need to attend?"
            Case False
                lblQuestion9.Text = "By  what date should expert be informed that he does need to attend?"
        End Select
        Dim Baseday As Date
        Dim LoIday As Date

        Baseday = Today
        Dim i As Integer
        Do Until IsWeekDay(Baseday) = True
            Baseday = Baseday.AddDays(1)
        Loop
        LoIday = Baseday.AddDays(7)
        dtpLoIDrafted.Value = LoIday
        dtpLoISent.Value = Baseday.AddDays(14)
        dtpRepFilServ.Value = Baseday.AddDays(42)
        i = 52
        Do Until IsWeekDay(Baseday.AddDays(i)) = True
            i = i + 1

        Loop



        dtpQtoExpert.Value = Baseday.AddDays(i)

        dtpExpertReply.Value = Baseday.AddDays(i + 7)

        dtpExpertInform.Value = Baseday.AddDays(i + 14)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayer1.SelectedIndexChanged

    End Sub

    Private Sub rdoYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYes.CheckedChanged
        Select Case rdoYes.Checked
            Case True
                lblQuestion9.Text = "By what date should the expert be notified that he does not need to attend?"
            Case False
                lblQuestion9.Text = "By  what date should expert be informed that he does need to attend?"
        End Select


    End Sub

    Private Sub dtpLoIDrafted_ValueChanged(sender As Object, e As EventArgs) Handles dtpLoIDrafted.ValueChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        Dim FMH As New PropertyClass
        FMH.NameNumber = "Acacia Cottage"
        FMH.Address1 = "Cormorant Road"
        FMH.Addres2 = "Burgess Heath"
        FMH.PostCode = "RG`` 7PU"
        Select Case cmbLoIDrafter.Text
            Case "Applicant"
                ValuerOrder.LetterWriter = Applicant
            Case "Respondent"
                ValuerOrder.LetterWriter = Respondent

        End Select
        ValuerOrder.JoinUp()
        txtTest.Text = ValuerOrder.FullOrderPara

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim FMH As New PropertyClass
        FMH.NameNumber = "Acacia Cottage"
        FMH.Address1 = "Cormorant Road"
        FMH.Addres2 = "Burgess Heath"
        FMH.PostCode = "RG`` 7PU"


    End Sub
End Class