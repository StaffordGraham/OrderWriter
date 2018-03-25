Public Class RepSchedDefClass
    Inherits BasicParaClass
    Public Both As Boolean
    Public Exception As Integer



    Public Sub JoinUp()
        Dim s As String
        Select Case RepSchedDef.Exception
            Case 0

                s = ", as amended by the the Judge,"
            Case 1
                s = ", save for just exceptions, "
            Case 2

                s = ""

        End Select

        If Both = True Then
            FullOrderPara = "[Both parties] shall send to the court and serve on other party replies to the other’s schedule of deficiencies and supplemental questionnaire and request for further documents " + s + " by " + ReplyQuaire.ComplianceDate + "."
        Else

            FullOrderPara = "The " + RepSchedDef.AppliesTo.Name + "shall send to the court and serve on the " + OtherParty.PartyType + " " + AppliesTo.PossessivePronoun + " replies to the " + OtherParty.PartyType + "'s schedule of deficiencies and supplemental questionnaire and request for further documents" + s + " by " + RepSchedDef.ComplianceDate
        End If

    End Sub
End Class
