Public Class ComplianceDateForm
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rdoFixedDate.Checked Then
            'show Choose Date Form
        Else
            If rdoWeeksBefore.Checked = True Then
                'show Weeks before form
            End If
        End If
        Me.Hide()

    End Sub
End Class