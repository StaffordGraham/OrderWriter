Imports System.Text
Public Class PenClass
    Public Provider As String
    Public ComplianceDate As String
    Public Requirement As String
    Public FullOrderPara As String

    Public Sub JoinUp()
        Dim ord As New StringBuilder

        ord.append("The ")
        ord.append(Provider)
        ord.Append(" shall ")
        If Requirement = "A" Then
            ord.Append("complete, file and serve a copy of the Form P1 (pension inquiry form) by ")
        Else

            ord.Append("provide the information required by Regulations 2, 3 and 4 of the Pensions on Divorce etc (Provision of Information Regulations) 2000 by ")
        End If

        ord.Append(ComplianceDate)

        FullOrderPara = ord.ToString

    End Sub
End Class
