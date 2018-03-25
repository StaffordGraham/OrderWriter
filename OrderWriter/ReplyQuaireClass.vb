Imports System.Text
Public Class ReplyQuaireClass
    Inherits BasicParaClass
    Public Both As Boolean
    Public Exception As Integer



    Public Sub JoinUp()
        Dim s As String
        Select Case Exception
            Case 0

                s = ", as amended by the Judge,"
            Case 1
                s = ", save for just exceptions, "
            Case 2

                s = ""

        End Select

        If Both = True Then
            FullOrderPara = "Both parties shall send to the court and serve on theother party their respective replies to the other’s questionnaire and request for further documents by " + ReplyQuaire.ComplianceDate + "."
        Else

            FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + " " + AppliesTo.PossessivePronoun + " replies to the " + ReplyQuaire.OtherParty.Name + "'s questionnaire  and request for further documents" + s + " by " + ReplyQuaire.ComplianceDate
        End If

    End Sub

End Class
