Imports System.Text
Public Class OtherEvidenceClass
    Inherits BasicParaClass
    Public EvidenceForm As String
    Public IfAdvised As Boolean
    Public EvidenceIssue As String
    Public LimitedTo As Boolean
    Public Issue As String
    Public ThereIsIssue As Boolean
    Public DealWithIssue As Boolean
    Public EvidenceSource As String






    Public Sub JoinUp()
        Dim ord As New StringBuilder
        ord.Append("The ")
        ord.Append(AppliesTo.PartyType)
        ord.Append(" has permission to send to the court and serve on the ")
        ord.Append(OtherParty.PartyType)
        ord.Append(" ")
        ord.Append(EvidenceForm)
        ord.Append(" from ")
        ord.Append(EvidenceSource)

        If IfAdvised = True Then
            ord.Append(", if so advised, ")
        End If
        If LimitedTo = True Then
            ord.Append(" limited to dealing with the issue of ")
        End If

        If DealWithIssue = True Then
            ord.Append(" dealing with the issue of ")
            ord.Append(Issue)


        End If
        ord.Append(" by ")
        ord.Append(ComplianceDate)
        FullOrderPara = ord.ToString


    End Sub
    Private Sub nonsub()
        Dim d As String
        d = "35.	The [applicant] / [respondent] has permission to send to the court and serve on the [respondent] / [applicant] [evidence] " + "
/ [a letter] / [a statement] from [name] if so advised [dealing with [issue]] / [limited to dealing with [issue]] by [time and date]."
    End Sub
End Class
