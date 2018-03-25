Imports System.ComponentModel
Imports Word = Microsoft.Office.Interop.Word


Public Class Form1
    Public TheJudge As New Judge
    Public TheCourt As New CourtDetails
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' frm29_FirsAppointmentDocs.Show()
        'Me.Hide()
        Dim int As Integer
        Dim Baseday As Date
        Baseday = Today
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing



    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TheJudge.Rank = cmbJudgeRank.Text
        TheJudge.Name = cmbJudgeName.Text
        TheCourt.Court = cmbSitting.Text
        CaseDetails.Show()
        Me.Hide()

        ' MsgBox(TheJudge.Rank + " " + TheJudge.Name)

    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        cmbJudgeRank.Text = "Deputy District Judge"
        cmbJudgeName.Text = "Campbell"
        cmbSitting.Text = "Eastbourne"

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        cmbJudgeRank.Text = ""
        cmbJudgeName.Text = ""
        cmbSitting.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        txtTest.Text = Baseday.ToString("ddd")
        Baseday = Baseday.AddDays(1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Tag = "whhopee"


        Globe.frmObj = Me
        txtTest.Text = Globe.frmObj.Tag
        frmDateChooser.Show()
        Me.Hide()



    End Sub
End Class
