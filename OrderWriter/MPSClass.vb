Public Class MPSClass

    Inherits BasicParaClass
    Public Undertaking As String 'Paragraph in which the undertaking is put

    Public Payment As Single
    Public Frequency As String
    Public StartDate As String
    Public GiveCredit As Boolean
    Public CreditPayment As Single
    Public CreditDate As String

    Public Sub JoinUp()
        FullOrderPara = "The" + AppliesTo.PartyType + " shall pay to the " + OtherParty.PartyType + " maintenance pending suit until the date of decree absolute and afterwards interim periodical payments. " _
+ "Payments shall be at the rate of £" + Payment.ToString + " payable " + Frequency + " by standing order. Payments shall start " + StartDate + "  until " + listbox2string(frmMPS.chklstEnd)
        If GiveCredit = True Then
            FullOrderPara = FullOrderPara + "The " + OtherParty.PartyType + " shall be given credit for the payment of £" + CreditPayment.ToString + " made on "

        End If

    End Sub






End Class
