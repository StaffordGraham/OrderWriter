Public Class UpdateForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim Updateobj As New UpdateClass

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Unlading()
        Globe.frmObj = Me
        frmPreDateChooser.Show()

        ' frmDateChooser.Show()

        'UpDateobj.Joinup()

    End Sub
    Private Sub Unlading()
        If chkInvestments.Checked Then
            UpDateobj.Investments = True
        End If
        If chkBusinessAccounts.Checked = True Then
            UpDateobj.BusinessAccounts = True
        End If
        If chkDividends.Checked = True Then
            UpDateobj.Dividends = True
        End If
        If chkInvestInc.Checked = True Then
            UpDateobj.Income = True
        End If
        If chkP60.Checked = True Then
            UpDateobj.P60s = True
        End If
        If chkLiabilities.Checked = True Then
            UpDateobj.Liabilities = True
        End If
        If chkPensionCEV.Checked = True Then
            UpDateobj.CEV = True
        End If
        If chkPolicies.Checked = True Then
            UpDateobj.Policies = True
            If chkTaxReturn.Checked = True Then
                UpDateobj.TaxReturn = True
            End If

        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class