Public Class frmLegalServices


    Private Sub frmLegalServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case LSO.Form
            Case 1 'lump sum only
                lblthereafter.Hide()
                    txtPeriodicAmount.Hide()
                    lblperCalendar.Hide()
                    dtpStart.Hide()
                    dtpEnd.Hide()
                    lblUntil.Hide()
            Case 2 'periodic only

                lblthereafter.Hide()

                lblBy.Hide()


                txtPeriodicAmount.Show()
                txtPeriodicAmount.Location = New Point(360, 103)


                lblperCalendar.Show()
                lblperCalendar.Location = New Point(145, 147)
                dtpStart.Show()
                dtpByDate.Hide()

                dtpStart.Location = New Point(360, 140)
                lblUntil.Show()
                lblUntil.Location = New Point(285, 196)
                dtpEnd.Show()
                dtpEnd.Location = New Point(360, 189)
                lblTo.Show()
                lblTo.Location = New Point(91, 236)
                txtSols.Show()
                txtSols.Location = New Point(110, 239)

            Case 3 'Both
                lblthereafter.Show()
                lblthereafter.Location = New Point(40, 147)
                txtPeriodicAmount.Show()


                lblBy.Show()
                lblBy.Location = New Point(481, 106)



                txtPeriodicAmount.Show()
                txtPeriodicAmount.Location = New Point(194, 144)



                lblperCalendar.Show()
                lblperCalendar.Location = New Point(320, 150)





                dtpStart.Show()
                dtpStart.Location = New Point(517, 150)
                dtpByDate.Show()
                dtpByDate.Location = New Point(517, 106)

                dtpStart.Location = New Point(517, 150)
                lblUntil.Show()
                lblUntil.Location = New Point(285, 196)
                dtpEnd.Show()
                dtpEnd.Location = New Point(360, 189)
                lblTo.Show()
                lblTo.Location = New Point(91, 236)
                txtSols.Show()
                txtSols.Location = New Point(224, 236)
                lblOrder2.Location = New Point(357, 246)
                txtPeriodicAmount.Location = New Point(194, 144)


        End Select







    End Sub
    Private Sub Unlading()
        Select Case cmbAppliesTo.Text
            Case "Applicant"
                LSO.AppliesTo = Applicant

                LSO.OtherParty = Respondent
            Case "Respondent"
                LSO.AppliesTo = Respondent
                LSO.OtherParty = Applicant
                Select Case LSO.Form
                    Case 1  'lump sum
                        LSO.Amount = CDec(txtAmount.Text)
                        LSO.ComplianceDate = dtpByDate.Value.ToLongDateString
                    Case 2 'Periodic
                        LSO.PeriodicAmount = CDec(txtPeriodicAmount.Text)
                        LSO.PeriodicStart = dtpStart.Value.ToLongDateString
                        LSO.PeriodicEnd = dtpEnd.Value.ToLongDateString
                    Case 3 'Both 

                        LSO.Amount = CDec(txtAmount.Text)
                        LSO.ComplianceDate = dtpByDate.Value.ToLongDateString
                        LSO.PeriodicAmount = CDec(txtPeriodicAmount.Text)
                        LSO.PeriodicStart = dtpStart.Value.ToLongDateString
                        LSO.PeriodicEnd = dtpEnd.Value.ToLongDateString
                End Select

                LSO.Sols = txtSols.Text






        End Select


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()

        LSO.joinup()

        'txtTest.Text = LSO.FullUTPara.ToString

        txtTest.Text = LSO.FullUTPara


    End Sub

    Private Sub cmbAppliesTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliesTo.SelectedIndexChanged
        Select Case cmbAppliesTo.Text
            Case "Applicant"

                lblOrder2.Text = "The Legal Representatives of the Respondent"
            Case "Respondent"
                lblOrder2.Text = "The Legal Representatives of the Applicant"
        End Select

    End Sub
End Class