Public Class ExpertNameFrm
    Private Sub ExpertNameFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fonting(Me)

    End Sub
    Private Sub unlading()
        ValuerOrder.ExpertTitle = cmbExpertTitle.Text + " "

        ValuerOrder.ExpertFirsttName = txtExpertFirstName.Text + " "
        ValuerOrder.ExpertSurname = txtExpertSurname.Text + " "



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        unlading()
        AddressForm.Show()
        Me.Hide()

    End Sub
End Class