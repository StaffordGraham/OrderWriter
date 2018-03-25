Imports System.Text
Public Class UpdateClass
    Inherits BasicParaClass
    Public Investments As Boolean
    Public Dividends As Boolean
    Public Policies As Boolean
    Public Liabilities As Boolean
    Public BusinessAccounts As Boolean
    Public CEV As Boolean
    Public P60s As Boolean
    Public TaxReturn As Boolean
    Public Income As Boolean
    Public SpecificDate As Boolean

    Public Sub Joinup()
        Dim i As Integer
        i = 1


        Dim ord As New StringBuilder
        ord.Append("Each party shall serve on the other party their updating disclosure")
        If SpecificDate = True Then
            ord.Append(" by ")
            ord.Append(ComplianceDate)
        Else
            ord.Append("by 4:00 pm on ")
            ord.Append(ComplianceDate
                           )
        End If
        ord.Append(". ")
        ord.Append("Updating disclosure means the disclosure of the following documents:")
        If Investments = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))


            ord.Append(vbTab)

            ord.Append("a copy of the most up to date statement or dividend counterfoil relating to investments in the category required by paragraph 2.4 of Form E, including in respect of any investments which have come into existence since Form E;")
            i = i + 1

        End If
        If Dividends = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("a copy of the most up to date statement or dividend counterfoil relating to investments in the category required by paragraph 2.4 of Form E, including in respect of any investments which have come into existence since Form E;")
            i = i + 1
        End If

        If Policies = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append(" a copy of an up to date surrender value for policies in the category required by paragraph 2.5 of Form E, including in respect of any policies which have come into existence since Form E;")
            i = i + 1

        End If
        If Liabilities = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of documents evidencing the up to date amount due on liabilities in the category required by paragraph 2.9 or 2.10 of Form E, including in respect of any liabilities which have come into existence since Form E;")
            i = i + 1

        End If
        If BusinessAccounts = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of any business accounts which have become available since Form E for businesses in the category required by paragraph 2.11 of Form E, including in respect of any businesses which have come into existence since Form E, identifying the expected share of business profits from these accounts;")
            i = i + 1
        End If
        If CEV = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of an up to date statement showing the Cash Equivalent of any pension rights (or value of any PPF rights) in the category required by paragraph 2.13 of Form E, including in respect of any pension rights or PPF rights which have come into existence since Form E;")
            i = i + 1

        End If
        If P60s = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of all P60s and P11Ds received since Form E, and all pay slips received since the last P60;")
            i = i + 1

        End If
        If TaxReturn = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of all tax returns sent to HMRC and tax assessments since Form E; and")
            i = i + 1


        End If
        If Income = True Then
            ord.Append(vbCrLf)
            ord.Append(NumbToLetter(i))
            ord.Append(vbTab)
            ord.Append("copies of all documents evidencing all income received since Form E in the nature of dividends, interest, rental income, state benefits or otherwise.")
            i = i + 1

        End If
        FullOrderPara = ord.ToString

    End Sub
    Private Function NumbToLetter(a As Integer) As Char
        Select Case a
            Case 1
                NumbToLetter = "a"
            Case 2
                NumbToLetter = "b"
            Case 3
                NumbToLetter = "c"
            Case 4
                NumbToLetter = "d"
            Case 5

                NumbToLetter = "e"
            Case 6

                NumbToLetter = "f"
            Case 7


                NumbToLetter = "g"
            Case 8
                NumbToLetter = "h"
            Case 9
                NumbToLetter = "i"
        End Select
        On Error Resume Next


    End Function



End Class
