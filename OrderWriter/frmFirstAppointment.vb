Public Class frm29_FirsAppointmentDocs

    Public AppOrder As New FirstAppointmentDocs
    Public RespOrder As New FirstAppointmentDocs
    Public Doccos As New Collection




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Unlading()

        frmOrderSelector.Show()
        Me.Hide()

    End Sub
    Private Sub Unlading()
        If chkAppChron.Checked Or chkAppIssue.Checked Or chkAppQuaire.Checked Then
            AppOrder.AppliesTo = Applicant
            AppOrder.OtherParty = Respondent
            AppOrder.ComplianceDate = dtpFirstAppDate.Value.ToLongDateString
            AppOrder.Determinant = Determine(chkAppChron, chkAppIssue, chkAppQuaire) 'sends to AppOrder Object a letter code, which determines which documents go in the order
            AppOrder.JoinUp() ' a sub in AppOrder that drafts the final paragraph. 

        End If
        If chkRespChron.Checked Or chkRespIssue.Checked Or chkRespQuaire.Checked Then
            RespOrder.AppliesTo = Respondent
            RespOrder.OtherParty = Applicant
            RespOrder.ComplianceDate = dtpRespQuaire.Value.ToLongDateString
            RespOrder.Determinant = Determine(chkRespChron, chkRespIssue, chkRespQuaire)
            RespOrder.JoinUp()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Unlading()

        txtTest.Text = RespOrder.FullOrderPara


    End Sub

    Private Sub chkAppChron_CheckedChanged(sender As Object, e As EventArgs) Handles chkAppChron.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Sub ClearForm()
        AppOrder.Chron = False
        AppOrder.Issue = False
        AppOrder.Quaire = False
        AppOrder.ComplianceDate = ""
        chkAppChron.Checked = False
        chkAppIssue.Checked = False
        chkAppQuaire.Checked = False
        AppOrder.Doc1 = ""
        AppOrder.Doc2 = ""
        AppOrder.Doc3 = ""


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        AppOrder.Determinant = ""
        txtTest.Text = ""



    End Sub



    Private Sub frm29_FirsAppointmentDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("")

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class