Public Class frmOrderSelector

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrders.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles lstOrders.DoubleClick
        ItemSelect()

    End Sub
    Private Sub ItemSelect()

        Dim v As String
        'v = lstOrders.GetItemText
        v = lstOrders.SelectedItem.ToString()
        lstOrdersSelected.Items.Add(v)


        'MsgBox(v)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ItemSelect()

    End Sub
    Private Sub ItemRemove()
        lstOrdersSelected.Items.Remove(lstOrdersSelected.SelectedItem)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ItemRemove()
    End Sub
    Private Sub Lading()
        OrderCounter = 0 'Global variable which is used to keep track of which form is next to be presented to the user. It is set at 0 when this Form is loaded.

    End Sub
    Private Sub Unlading()
        Dim i As Integer
        Dim v As String



        For i = 0 To lstOrdersSelected.Items.Count - 1 'loop from 0 to the number of items in lstOrderSelected listbox
            v = lstOrdersSelected.Items(i).ToString 'put the name of order selected into The variable v
            TheOrders.OrderAdd(v) 'Put the contents of variable v into the TheOrders object 

            'w = w + TheOrders.OrderType(i).ToString


        Next
        'The Orders object now contains the name of each order selected

        ' MsgBox(Applicant.PossessivePronoun)
        ' MsgBox(Applicant.PossessivePronoun)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Unlading()
        CaseDetails.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Unlading()

        ChooseForm() 'This is in Module1. The hope is that I can have a routine that applies to each form
        Me.Hide()

    End Sub

    Private Sub frmOrderSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lading()

    End Sub

    Private Sub frmOrderSelector_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Dim v As String
        v = "37.Updating disclosure"
        lstOrdersSelected.Items.Add(v)


    End Sub
End Class