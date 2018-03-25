Imports System.Text

Public Class ConsolidateClass

    Inherits BasicParaClass
    Public App1 As String
    Public App2 As String
    Public App3 As String
    Public Doc1 As String
    Public Doc2 As String
    Public Doc3 As String
    Public LeadParty As Party


    Public ConsolCaseNo As String
    Public ServingParty As Party
    Public ReceivingParty As Party
    Public ReceivingParty2 As Party



    Public Sub JoinUp()
        Dim ord As New StringBuilder
        ord.Append("The ")
        ord.Append(AppliesTo)
        ord.Append("' and the  ")
        ord.Append(OtherParty)
        ord.Append("'s respective applications ")
        ord.Append(App1)
        ord.Append((", "))
        ord.Append(App2)
        ord.Append(", ")
        ord.Append(App3)
        ord.Append(" are consolidated ")
        ord.Append("The ")
        ord.Append(AppliesTo)
        ord.Append("'s application shall be the lead application and the 17.	and the consolidated applications shall proceed under case number")
        ord.Append(ConsolCaseNo)
        ord.Append(vbCrLf)
        ord.Append("b.  The ")
        ord.Append(ServingParty)
        ord.Append(" shall serve on the ")
        ord.Append(ReceivingParty)
        ord.Append(" and the ")
        ord.Append(ReceivingParty2)
        ord.Append("copies of the following documents relating to the ")
        ord.Append(ServingParty)
        ord.Append("'s application under ")
        ord.Append(App1)
        ord.Append(":-")
        ord.Append(vbCrLf)
        ord.Append(vbTab)
        ord.Append(Doc1)
        ord.Append(vbCrLf)
        ord.Append(vbTab)
        ord.Append(Doc2)
        ord.Append(vbCrLf)
        ord.Append(vbTab)
        ord.Append(Doc3)
        FullOrderPara = ord.ToString


    End Sub

End Class
