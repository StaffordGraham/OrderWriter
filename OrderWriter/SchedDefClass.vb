Public Class SchedDefClass
    Inherits BasicParaClass
    'Public Both As Boolean
    Public Exception As Integer



    Public Sub JoinUp()
        Dim s As String
        Select Case Exception
            Case 0

                s = ", if so advised,"
            Case 1
                s = ""
            Case 2


        End Select



        FullOrderPara = "The " + AppliesTo.PartyType + "shall send to the court and serve on the " + OtherParty.PartyType + "   a schedule of deficiencies and supplemental questionnaire and request for further documents " + s + " by " + ComplianceDate


    End Sub

End Class
