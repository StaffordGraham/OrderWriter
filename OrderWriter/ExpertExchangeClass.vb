Imports System.Text

Public Class ExpertExchangeClass
    Inherits ExpertClass
    Public discussion As String

    Public Overloads Sub Joinup()
        Dim ord As New StringBuilder
        ord.Append("a.   The ")
        ord.Append(AppliesTo.PartyType)
        ord.Append(" shall ")
        If AppliesTo.PartyType = "Both" Then
            ord.Append(" each ")

        End If
        ord.Append(" shall disclose ")


        ord.Append(AppliesTo.PossessivePronoun)
        ord.Append(" expert's ")
        ord.Append(ValuerOrder.ReportType)
        ord.Append(" to the ")
        If AppliesTo.PartyType = "both Parties" Then
            ord.Append("other party")
        End If
        ord.Append(ExpExchOrder.OtherParty.PartyType)
        ord.Append("'s valuer by ")
        ord.Append(ExpExchOrder.ComplianceDate2)
        ord.Append(".")
        ord.Append(vbCrLf)
        ord.Append("b.  There shall be a meeting between the ")
        ord.Append(AppliesTo.PartyType)
        ord.Append("'s expert and the ")
        ord.Append(OtherParty.PartyType)
        ord.Append("'s expert by ")
        ord.Append(ComplianceDate2)
        ord.Append("to discuss: ")
        ord.Append(vbCrLf)
        ord.Append("(i) the reasons for disagreement on any expert question and what if any, action needs to be taken to resolve any oustanding disagreement or question;")
        ord.Append(vbCrLf)
        ord.Append("(ii) what existing evidence needs to be obtained to assist the Court to determine the issues;")
        ord.Append(vbCrLf)
        ord.Append("(iii)  ")
        ord.Append(discussion)
        FullOrderPara = ord.ToString


    End Sub


End Class
