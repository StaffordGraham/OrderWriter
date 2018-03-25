Imports System.Text

Public Class LSOClass
    Inherits BasicParaClass
    Public Amount As Decimal
    Public PeriodicAmount As Decimal
    Public Amount2 As Decimal

    Public Sols As String
    Public Frequency As String
    Public Form As Integer
    Public PeriodicStart As String
    Public PeriodicEnd As String



    Public Sub joinup()
        Dim amountstring As String
        amountstring = CStr(Amount)
        Dim sb As New StringBuilder


        sb.Append("a.	This is a legal services order made pursuant to")
        Select Case Dossier.Statute
            Case "The Matrimonial Causes Act 1973"
                sb.Append("s 22ZA of the Matrimonial Causes Act 1973")
            Case "The Civil Partnership Act 2004"
                sb.Append("para 38A of Schedule 5 to the Civil Partnership Act 2004")
            Case "The Child Support Act 1991"
            Case "Schedule 1 To the Children Act 1989"
            Case "The Inheritance(Provision For Family And Dependants) Act 1975 "
            Case "The Matrimonial And Family Proceedings Act 1984 And Schedule 7 To the Civil Partnership Act 2004"
            Case "The Trusts Of Land And Appointment Of Trustees Act 1996"
            Case "The Married Women's Property Act 1882 and ss 67,68 and 74 of the Civil Partnership Act 2004"
        End Select
        sb.Append(vbCrLf)
        sb.Append("b.	The court was satisfied that without the amount specified below, the")
        sb.Append(OtherParty.PartyType)
        sb.Append("would not reasonably be able to obtain appropriate legal services for the purposes of the proceedings.")
        sb.Append(vbCrLf)
        sb.Append("c.")
        sb.Append(vbTab)
        sb.Append("The ")
        sb.Append(AppliesTo.PartyType)

        Select Case LSO.Form
            Case 1 'lump sum
                sb.Append(" shall pay the amount of £")
                sb.Append(amountstring)
                sb.Append(" by ")
                sb.Append(ComplianceDate)
            Case 2 'periodic
                sb.Append(" shall pay the amount of £")
                sb.Append(LSO.PeriodicAmount.ToString)
                sb.Append(" per calendar month commencing on ")
                sb.Append(PeriodicStart)
                sb.Append(" until ")
                sb.Append(PeriodicEnd)
                sb.Append(".")
            Case 3 'Both
                sb.Append(" shall pay the amount of £")
                sb.Append(amountstring)
                sb.Append(" by ")
                sb.Append(ComplianceDate)
                sb.Append("and thereafter the sum of £")
                sb.Append(LSO.PeriodicAmount.ToString)
                sb.Append(" per calendar month commencing on ")
                sb.Append(PeriodicStart)
                sb.Append(" until ")
                sb.Append(PeriodicEnd)
                sb.Append(".")


        End Select




        sb.Append("  to ")
        sb.Append(Sols)
        sb.Append(", the legal representaives of the ")
        sb.Append(OtherParty.PartyType)


        FullOrderPara = sb.ToString
        Dim s As String
        s = AppliesTo.PartyType

        'ut.Append(AppliesTo.PartyType)
        FullUTPara = "The " + OtherParty.PartyType.ToString + "  shall repay To the " + s + "  such part Of the amounts paid under the legal services order below if, and to the extent that, the court is of the opinion, when considering costs at the conclusion of the proceedings, that " + LCase(OtherParty.NominativePronoun) + " ought to do so."
    End Sub
End Class
