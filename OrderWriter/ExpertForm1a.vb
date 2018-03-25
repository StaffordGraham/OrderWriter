Public Class ExpertForm1a
    Private Sub ExpertForm1a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQuestion1.Text = "Choose which type of " + ValuerOrder.ExpertType + "  will do the " + ValuerOrder.ReportType
        Label1.Text = "Choose the nature of the valuation"
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        AddressForm.Show()
        Me.Hide()



    End Sub

    Private Sub cmbExpSubType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpSubType.SelectedIndexChanged

    End Sub

    Private Sub cmbExpSubType_DoubleClick(sender As Object, e As EventArgs) Handles cmbExpSubType.DoubleClick
        cmbExpSubType.Text = " estate agent"
        cmbRepSubType.Text = "Market Appraisal"
    End Sub
    Private Sub Unlading()
        ValuerOrder.ExpertSubType = cmbExpSubType.Text
        ValuerOrder.ReportSubType = cmbRepSubType.Text


    End Sub
End Class