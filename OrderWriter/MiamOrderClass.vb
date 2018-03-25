Public Class MiamOrderClass
    Public AppliesTo As Party
    Public OtherParty As Party
    Public ComplianceDate As String
    Public FullPara As String
    Public Sub JoinUp()
        FullPara = "The " + AppliesTo.PartyType + " shall attend a Mediation Information and Assessment Meeting and shall file a completed Form FM1 by  _
" + ComplianceDate + vbCrLf + vbCrLf

    End Sub
End Class
