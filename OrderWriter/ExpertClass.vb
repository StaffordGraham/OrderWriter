Imports System.Text

Public Class ExpertClass
    Public AppliesTo As Party
    Public OtherParty As Party
    Public ThirdParty As Party
    Public ComplianceDate As String
    Public FullOrderPara As String
    Public FullUTPara As String
    Public FullRecitePara As String
    Public ExpertTitle As String
    Public ExpertFirsttName As String
    Public ExpertSurname As String

    Public ExpertType As String
    Public ExpertSubType As String
    Public ExpertKnown As Boolean
    Public SingleJointExpert As Boolean

    Public TheProperty As PropertyClass



    Public ReportType As String
    Public ReportSubType As String

    Public LetterWriter As Party 'The party who will draft the letter of instruction
    Public ComplianceDate2 As String 'date for drafting LetterWriter of intruction
    Public ComplianceDate3 As String
    Public ComplianceDate4 As String
    Public ComplianceDate5 As String
    Public ComplianceDate6 As String
    Public ComplianceDate7 As String


    Public Payer2 As Party
    Public Document1 As String
    Public Document2 As String
    Public Payer As Party


    Public Prop As New PropertyClass
    Public AttendingExperts As String




    Public Sub JoinUp()
        Dim ord As New StringBuilder

        If SingleJointExpert = True Then
            ord.Append("Both Parties ")
        Else
            ord.Append("a. The ")
            ord.Append(ValuerOrder.AppliesTo.PartyType)
        End If

        ord.Append(" shall instruct ")
        If ExpertKnown = True Then
            ord.Append(ExpertTitle + ExpertFirsttName + ExpertSurname)
        Else

        End If
        ord.Append(ExpertSubType)
        If ExpertSubType <> "an appropriate expert" Then

            ord.Append(" as an expert ")
        End If
        ord.Append("to provide a ")

        ord.Append(ReportSubType)
        ord.Append(" in respect of the property at ")
        ord.Append(ValuerOrder.TheProperty.NameNumber)

        ord.Append(", ")
        ord.Append(ValuerOrder.TheProperty.Address1)
        ord.Append(", ")
        ord.Append(ValuerOrder.TheProperty.Addres2)
        ord.Append(", ")
        ord.Append(ValuerOrder.TheProperty.PostCode)



        ord.Append(vbCrLf)
        ord.Append("b. The letter of Instruction shall be drafted by the ")
        ord.Append(LetterWriter.PartyType)
        ord.Append(" by ")
        ord.Append(ComplianceDate)
        ord.Append(vbCrLf)
        ord.Append("c. The letter of instructions and ")



        ord.Append(Document1)
        ord.Append(", ")
        ord.Append(Document2)
        ord.Append(" shall be sent to the expert by ")
        ord.Append(ComplianceDate3)
        ord.Append(vbCrLf)
        ord.Append("d.The report shall be sent to the court in both hardcopy And electronic form And served on the ")
        ord.Append(ValuerOrder.OtherParty.PartyType)
        ord.Append(" by ")
        ord.Append(ComplianceDate4)
        ord.Append(vbCrLf)
        ord.Append("e. The ")
        ord.Append(AppliesTo.PartyType)
        ord.Append(" shall disclose the report to the ")
        ord.Append(OtherParty.PartyType)
        ord.Append(" by ")
        ord.Append(ComplianceDate5)
        ord.Append(vbCrLf)
        ord.Append("f.The costs charged by the expert for preparing the report shall be met by the ")
        ord.Append(Payer.PartyType)
        ord.Append(" in the first instance.")
        ord.Append(vbCrLf)

        ord.Append("g.Any questions shall be put to the expert by no later than 10 days after receipt of the report (in accordance with FPR 2010 rule 25.10.)")
        ord.Append(vbCrLf)
        ord.Append("h.The expert shallrespond to those questions by ")

        ord.Append(ComplianceDate6)
        ord.Append("The costs charged by the expert for answering those questions shall be met by ")

        ord.Append(Payer2.PartyType)



        ord.Append(vbCrLf)
        ord.Append("j. Save as Is expressly ordered by the court, the ")
        ord.Append(ValuerOrder.ReportSubType)
        ord.Append(" shall be admissible without the attendance at court of the experts. However, ")
        ord.Append(AttendingExperts)
            ord.Append(" shall attend the final hearing to give oral evidence  unless agreement about the opinions given by the experts Is reached by ")
            ord.Append(ComplianceDate6)
        FullOrderPara = ord.ToString









    End Sub





End Class
