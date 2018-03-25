Public Class frmDateChooser
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Select Case Globe.frmObj.Tag
            Case "UpdateForm"
                UpDateobj.ComplianceDate = calComplianceDate.SelectionRange.Start.ToLongDateString
                UpDateobj.Joinup()
                txtTest.Text = UpDateobj.FullOrderPara

        End Select
    End Sub
End Class