Public Class AddressForm
    Public FMH As New PropertyClass

    Private Sub AddressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstruction.Text = "Enter the Address of the property to be valued"



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNameNo.TextChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()

        ExpertForm2.Show()
        Me.Hide()

    End Sub

    Private Sub AddressForm_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        txtNameNo.Text = "Howards End"
        txtAdd1.Text = "Watling Street"
        txtCityCounty.Text = "Barchester"
        txtPostCode.Text = "RG11 7PU"

    End Sub
    Private Sub Unlading()
        Dim MatHome As New PropertyClass
        MatHome.NameNumber = txtNameNo.Text
        MatHome.Address1 = txtAdd1.Text
        MatHome.Addres2 = txtAdd2.Text
        MatHome.PostCode = txtPostCode.Text
        ValuerOrder.TheProperty = MatHome

        'ValuerOrder.TheProperty.NameNumber = txtNameNo.Text
        'ValuerOrder.TheProperty.Address1 = txtAdd1.Text
        'ValuerOrder.TheProperty.Addres2 = txtAdd2.Text

        'ValuerOrder.TheProperty.PostCode = txtPostCode.Text
        'ValuerOrder.TheProperty = MatHome
        'f ValuerOrder.ExpertKnown = True Then
        'ExpertNameFrm.Show()
        ' Else
        'ExpertForm2.Show()

        ' End If


        Me.Hide()

    End Sub
End Class