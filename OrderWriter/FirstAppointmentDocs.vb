Public Class FirstAppointmentDocs
    Inherits BasicParaClass
    Public Chron As Boolean
    Public Issue As Boolean
    Public Quaire As Boolean
    Public Doc1 As String
    Public Doc2 As String
    Public Doc3 As String
    Public Determinant As String 'This takes a letter, from A To F. The letter Is a code For which check boxes have been ticked. 



    Public Sub JoinUp() 'Drafts the final paragraph


        Select Case Determinant
            Case "A" 'Chronology, Issues and Questionnaire
                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + vbCrLf _
                    + vbTab + "a. a chronology" + vbCrLf + vbTab + "b. a statement of issues and" + vbCrLf + vbTab + "c.a questionnaire" + vbCrLf + "by " + ComplianceDate
            Case "B" 'Chronology and issues

                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + vbCrLf _
                    + vbTab + "a. a chronology and" + vbCrLf + vbTab + "b. a statement of issues " + vbCrLf + "by " + ComplianceDate
            Case "C" 'Chronology and Questionnaire

                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + vbCrLf _
                                    + vbTab + "a. a chronology and" + vbCrLf + vbTab + "b. a questionnaire(if so advised) " + vbCrLf + "by " + ComplianceDate
            Case "D" 'A chronology
                FullOrderPara = "The " + AppliesTo.PartyType + " shall send to the court and serve on the " + OtherParty.PartyType + " a chronology by " + ComplianceDate
            Case "E" 'Statement of Issues and Questionnaire
                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + vbCrLf + "a. a statement of issues" + vbCrLf + "b.a questionnaire" _
                    + vbCrLf + "by " + ComplianceDate
            Case "F"'Questionnaire
                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + " a  questionnaire (if so advised) by "+ComplianceDate
            Case "G" 'Issues

                FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + " a statement of issues " + ComplianceDate
        End Select



    End Sub



End Class
