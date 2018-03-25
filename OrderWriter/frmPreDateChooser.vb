Public Class frmPreDateChooser
    Private Sub frmPreDateChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Globe.frmObj.Tag = "UpdateForm" Then
            Label1.Text = "You must now select a date by which the updating material must be filed and served. "
            Label2.Text = "Choose between these two options:"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            UpDateobj.SpecificDate = True
            frmDateChooser2.Show()
        Else
            UpDateobj.SpecificDate = False

            frmDateChooser.Show()
            Me.Hide()




        End If
    End Sub
End Class