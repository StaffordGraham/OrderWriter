Public Class frmLSOPrelim
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()


    End Sub
    Private Sub Unlading()
        LSO.Form = Radio(optLump, optPeriodic, optBoth)
        frmLegalServices.Show()
        Me.Hide()

    End Sub
    Private Function Radio(a As RadioButton, b As RadioButton, c As RadioButton) As Integer
        If a.Checked Then
            Return 1

        End If
        If b.Checked Then
            Return 2
        End If

        If c.Checked Then
            Return 3
        End If



    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class