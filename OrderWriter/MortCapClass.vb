Imports System.Text
Public Class MortCapClass
    Inherits BasicParaClass
    Public WeeksBefore As Integer
    Public Hearing As String
    Public ComplianceDate2 As String
    Public WeeksBefore2 As Integer
    Public WhoseNeeds1 As String
    Public WhoseNeeds2 As String





    Public Sub JoinUp()
        Dim ord As New StringBuilder
        ord.Append("a.")
        ord.Append(vbTab)
        ord.Append("Each party shall serve on the other copy particulars of properties they consider ")
        ord.Append("to be suitable to meet their own housing needs ")

        If WhoseNeeds1 IsNot Nothing Then

            ord.Append("and the housing needs of the ")
            ord.Append(WhoseNeeds1)

        End If
        ord.Append(", and the housing needs of the other party ")
        If WhoseNeeds2 IsNot Nothing Then
            ord.Append("and the housing needs of the ")
            ord.Append(WhoseNeeds2)
        End If
        ord.Append(", limited to 5 of each, ")
        '
        If WeeksBefore <> 0 Then
            ord.Append("by ")
            ord.Append(WeeksBefore.ToString)
            ord.Append(" weeks prior to the ")
            ord.Append(Hearing)
            ord.Append(".")
        Else
            ord.Append(" by 4:00 pm on ")
            ord.Append(ComplianceDate)
            ord.Append(".")
        End If
        FullOrderPara = ord.ToString
        ord.Append(vbCrLf)
        ord.Append(vbCrLf)
        ord.Append("b.Each party shall serve on the other party evidence of their mortgage raising capacity by ")
        If WeeksBefore2 <> 0 Then
            ord.Append(WeeksBefore.ToString)
            ord.Append(" weeks prior to the ")
            ord.Append(Hearing)
            ord.Append(".")
        Else

            ord.Append(" by 4:00 pm on ")
            ord.Append(ComplianceDate2)
            ord.Append(".")
        End If
        ord.Append("such evidence to be in the form of a certificate from a mortgage broker, indicating ")
        ord.Append(vbCrLf)
        ord.Append("(i) the maximum mortgage that the broker believes he or she will be able to secure, and")
        ord.Append(vbCrLf)
        ord.Append("(ii) the payments that would be required on that mortgage on a repayment basis and on an interest only basis.")

    End Sub






End Class
