Public Class frmMiamFormE
    Dim Miam1 As New MiamOrderClass
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Unlading()

        frm29_FirsAppointmentDocs.Show()
        Me.Hide()

    End Sub
    Private Sub Unlading()

        Miam1.AppliesTo = Applicant
        Miam1.ComplianceDate = dtpAppMiam.Value.ToLongDateString


        Miam1.JoinUp()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()

        frmOrderSelector.Show()
        Me.Hide()

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Unlading()
        txtText.Text = Miam1.FullPara

    End Sub

    Private Sub frmMiamFormE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class