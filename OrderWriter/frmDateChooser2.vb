Public Class frmDateChooser2
    Private Sub frmDateChooser2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Globe.frmObj.Tag
            Case "UpdateForm"
                cmbHearing.Items.Add("FirstAppointment")
                cmbHearing.Items.Add("Financial Dispute Resolution Hearing")
                cmbHearing.Items.Add("Final Hearing")
                cmbHearing.Items.Add("Adjourned Hearing")
                cmbHearing.Items.Add("Preliminary Hearing")


        End Select
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Select Case Globe.frmObj.Tag
            Case "UpdateForm"
                UpDateobj.ComplianceDate = cmbNumber.Text.ToString + " " + cmbDWM.Text + " " + "before the " + cmbHearing.Text
                UpDateobj.Joinup()

                TextBox1.Text = UpDateobj.FullOrderPara


        End Select
    End Sub
End Class