Public Class StatementClass
    Inherits BasicParaClass
    Public Both As Boolean
    Public Sub JoinUp()
        Dim s As String
        Select Case Dossier.Statute
            Case "The Matrimonial Causes Act 1973"
                s = " in Section 25 Matrimonial Causes Act 1973"
            Case "Schedule 1 Children Act"
                s = "Paragraph 4(1) of Schedule 1 to the Children Act 1989"
        End Select


        If Both = True Then
            FullOrderPara = "Both parties shall send to the court and serve on the a concise narrative statement dealing with all Of the relevant factors listed " + s _
                + "by" + ComplianceDate
        Else
            FullOrderPara = "The " + AppliesTo.Name + ”  shall send to the court and serve on the " + OtherParty.Name + " a concise narrative statement dealing with all of the relevant factors listed in " + s + " by " + StatementOrder.ComplianceDate + ”.”

        End If
    End Sub

End Class