Public Class ActuaryForm2
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        ActuaryForm3.Show()
        Me.Hide()

    End Sub
    Private Sub Unlading()
        ActuaryOrder.ExpertFirsttName = cmbActTitle.Text + txtActuaryName1.Text + " " + txtName2.Text


    End Sub
End Class