Imports System.Text

Public Class ConductStatementClass
    Inherits BasicParaClass
    Public ComplianceDate2 As String 'date by which answer to statement must be filed and served. 
    Public PageLimit As Integer



    Public Sub Joinup()
        Dim ord As New StringBuilder
        ord.Append("a.	In the event that the ")
        ord.Append(AppliesTo.PartyType)
        ord.Append("continues to seek to run a conduct case,")
        ord.Append(AppliesTo.NominativePronoun)
        ord.Append(" shall send to the court and serve on the ")
        ord.Append(OtherParty.PartyType)
        ord.Append(" a concise statement")
        ord.Append("limited to ")
        ord.Append(PageLimit)
        ord.Append(" pages by ")
        ord.Append(ComplianceDate)
        ord.Append(" restricted to addressing the following issues:")
        ord.Append(vbCrLf)
        ord.Append("i.")
        ord.Append("what conduct exactly ")
        ord.Append(OtherParty.NominativePronoun)
        ord.Append(" is seeking to rely upon;")
        ord.Append(vbCrLf)
        ord.Append("ii.the basis for ")
        ord.Append(AppliesTo.PossessivePronoun)
        ord.Append(" conduct allegations; and")
        ord.Append(vbCrLf)
        ord.Append("iii.what effect this alleged conduct would have on the current financial remedy or application.")
        ord.Append(vbCrLf)
        ord.Append("b.The ")
        ord.Append(OtherParty.PartyType)
        ord.Append(" has permission to send to the court and serve on the ")
        ord.Append(AppliesTo.PartyType)
        ord.Append(" a statement in answer if so advised by ")
        ord.Append(ComplianceDate2)
        ord.Append(".")

        FullOrderPara = ord.ToString





    End Sub

End Class
