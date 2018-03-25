Public Class CaseDetails




    'Public Shared Applicant As New Party
    Public Respondent1 As New Party
    Public Respondent2 As New Party
    Public Respondent3 As New Party


    'Public Dossier As New DetailsCase

    Private Sub CaseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Unlading()
        Select Case optAppFemale.Checked
            Case = True
                Applicant.Sex = "Female"
                Respondent.Sex = "Male"

            Case False
                Respondent.Sex = "Female"
                Applicant.Sex = "Male"

        End Select
        Applicant.SetPronouns()
        Respondent.SetPronouns()



        Dossier.CaseNo = txtCaseNo.Text
        'Dossier.Applicant = txtAppName.Text
        ' Dossier.Respondent = txtRespName.Text
        If optAppFemale.Checked = True Then
            Dossier.AppIsMale = False
            Dossier.RespIsMale = True
        End If

        Dossier.Statute = cmbStatute.Text
        Dossier.Relat = cmbRelation.Text




        Applicant.PartyType = "Applicant"
        If optAppMale.Checked Then
            Applicant.Sex = "Male"
        End If
        Applicant.SetPronouns()
        Respondent.PartyType = "Respondent"
        If optRespMale.Checked Then
            Respondent.Sex = "Male"
        Else Respondent.Sex = "Female"
        End If

        Respondent.PartyType = "Respondent"


        Respondent.SetPronouns()






        ' End If
    End Sub

    Private Sub Lading()
        txtCaseNo.Text = Dossier.CaseNo
        ' txtAppName.Text = Dossier.Applicant
        'txtRespName.Text = Dossier.Respondent
        If Dossier.RespIsMale = False Then
            optAppFemale.Checked = True
            optRespFemale.Checked = False
        Else
            optAppFemale.Checked = True
            optRespFemale.Checked = False
            cmbStatute.Text = Dossier.Statute
            cmbRelation.Text = Dossier.Relat


        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Unlading()





        Dossier.RespIsMale = True
        Dossier.AppIsMale = False
        Dossier.Statute = cmbStatute.Text
        Dossier.Relat = cmbRelation.Text

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub cmbStatute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatute.SelectedIndexChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        frmOrderSelector.Show()
        Me.Hide()

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click





    End Sub

    Private Sub optAppMale_CheckedChanged(sender As Object, e As EventArgs) Handles optAppMale.CheckedChanged
        If optAppFemale.Checked Then
            optAppMale.Checked = False

            optRespMale.Checked = True
            optRespFemale.Checked = False


        End If
        If optAppFemale.Checked = False Then
            optRespFemale.Checked = True
            optRespFemale.Checked = True
            optRespMale.Checked = False

        End If


        'End If
    End Sub

    Private Sub CaseDetails_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        txtAppName.Text = "Angela Carter"
        txtRespName.Text = "James Carter"
        txtCaseNo.Text = "CT D 0943"
        optAppFemale.Checked = True
        optRespMale.Checked = True

        cmbStatute.Text = "The Matrimonial Causes Act 1973"
        cmbRelation.Text = "Married"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class



