Imports System.Text
Public Class VarySettlementClass
    Inherits FinalParaClass
    Public Doc1 As String
    Public Doc2 As String
    Public ComplianceDate As String
    Public ComplianceDate2 As String
    Public DaysAfterService As Integer
    Public Bene1 As String
    Public Bene2 As String
    Public Bene3 As String

    Public AppliesTo As Party
    Public FullOrderPara As String


    Public Sub JoinUp()
        Dim ord As New StringBuilder
        ord.Append("a.  A copy of the ")
        ord.Append(AppliesTo.PartyType)
        ord.Append("'s application for variation of the marriage settlement  ")
        If Doc1 <> "" Then
            ord.Append("and a copy of ")
            ord.Append(Doc1)
            ord.Append(" ")
        End If
        If Doc2 <> "" Then
            ord.Append(" and a copy of ")
            ord.Append(Doc2)
            ord.Append(" ")

        End If

        ord.Append(" shall be served upon the ")
        ord.Append("following beneficiaries under the settlement,  ")
        ord.Append(Bene1)
        ord.Append(", ")
        ord.Append(Bene2)
        ord.Append(", ")
        ord.Append(Bene3)
        ord.Append(".")
        ord.Append("by ")
        ord.Append(ComplianceDate)
        ord.Append(".")
        ord.Append(vbCrLf)

        ord.Append(vbCrLf)

        ord.Append("b.  ")

        ord.Append(" the beneficiaries shall have permission  to send to the court and serve signed statements in answer or otherwise in response to the application ")
        If DaysAfterService <> 0 Then
            ord.Append("within ")
            ord.Append(DaysAfterService)
            ord.Append("days after service on them.")
        Else
            ord.Append("by ")
            ord.Append(ComplianceDate2)
        End If
        FullOrderPara = ord.ToString


    End Sub


End Class
