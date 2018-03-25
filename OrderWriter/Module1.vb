Imports System.Text
Module Module1
    Public Globe As New GlobalObject
    Public Children As New Collection
    Public Property1 As New PropertyClass
    Public ExpExchOrder As New ExpertExchangeClass




    Public Applicant As New Party 'With {.PartyType = "Applicant"}



    Public Respondent As New Party With {.PartyType = "Respondent"}
    Public Both As New Party With {.PartyType = "both Parties", .NominativePronoun = "they", .AccusativePronoun = "them", .PossessivePronoun = "their"}
    Public FourthParty As New Party With {.PartyType = "The  Party asking the Question"}
    Public OtherParty As New Party With {.PartyType = " the other expert"}



    Public TheOrders As New OrderListClass  'creates a new object based on OrderListClass
    Public OrderTypes() As String 'The array in which the finalised paragraphs aare stored
    Public OrderCounter As Integer ' Keeps track of the Forms that have been presented. 
    ' Public AllParas As NewList(Of FinalParaClass)
    Public AllTheOrders As New Collection
    'Public ThisCase As New DetailsCase
    Public Dossier As New DetailsCase
    Public LSO As New LSOClass
    Public ReplyQuaire As New ReplyQuaireClass
    Public SchedDef As New SchedDefClass
    Public RepSchedDef As New RepSchedDefClass
    Public StatementOrder As New StatementClass
    Public ConductStatementObj As New ConductStatementClass
    Public OtherEvidenceObj As New OtherEvidenceClass
    Public MortCapOrder As New MortCapClass
    Public UpDateobj As New UpdateClass
    Public ExpertOrder As New ExpertClass With {.ExpertType = "Valuer", .ReportType = "valuation"}
    Public ValuerOrder As New ExpertClass With {.ExpertType = "Valuer", .ReportType = "valuation"}
    Public VarySettlementOrder As New VarySettlementClass
    Public ConsolOrder As New ConsolidateClass
    Public FMH As New PropertyClass
    Public PensionValue As New PenClass
    Public ActuaryOrder As New ExpertClass














    'Public oWord As


    Public FormADocs As New Collection From {"a chronology", "b list of issues", "a questionnaire"}

    Public Sub ChooseForm()
        Dim v As String


        'This sub will select the next Form to be presented to the user. 

        ' Dim f As String

        v = OrderCounter 'Order Counter is the Global Variable that keeps track of how many selected forms have been presented to the user. 
        '  f = TheOrders.OrderType.Item(v).ToString
        Select Case TheOrders.OrderType.Item(v).ToString
            Case "26.Legal Services Order"
                frmLSOPrelim.Show()

                'frmLegalServices.Show()

            Case "27 & 28 Miam& FormE"
                frmMiamFormE.Show()
            Case "29 1st Appointment Documents"
                frm29_FirsAppointmentDocs.Show()
            Case "25.Maintenance Pending Suit"
                frmMPS.Show()

            Case "30.Replies to questionnaire"
                frmReplyQuaire.Show()
            Case "31.Schedule of Deficiencies and Supplemental Questionnaire"
                frmSchedDef.Show()
            Case "32.Replies to schedule of deficiencies and supplemental questionnaire"
                RepSchedDefForm.Show()
            Case "33.Statements"
                StatementForm.Show()


            Case "34.Statements dealing with Conduct"
                ConductStatementForm.Show()
            Case "35.Permission regarding other evidence"
                OtherEvidenceForm.Show()
            Case "36.Evidence regarding mortgage raising capacity and housing needs"
                MortCapForm.Show()
            Case "37.Updating disclosure"
                UpdateForm.Show()
            Case "38.Expert Valuer"
                ValuerOrder.ExpertType = "valuer"

                ValuerOrder.ReportType = "Valuation"
                ExpertForm1.Show()
            Case "40.Experts Exchange Reports"
                ExpExchForm.Show()

            Case "38.Expert Valuer"
            Case "68.Variation of Settlement"
                VarySettlementForm.Show()
            Case "69.Consolidation of Proceedings"
                ConsolidateForm.Show()
            Case "Pensions Report"
                frmPension.Show()
            Case "Actuary Report"
                ActuaryForm.Show()

        End Select







        OrderCounter = OrderCounter + 1




    End Sub

    Public Sub Fonting(Mich As Form)
        For Each Label In Mich.Controls
            Label.Font = New Font("Times New Roman", 12)
        Next
        Mich.BackColor = Color.FromArgb(255, 255, 192)







    End Sub

    Public Function ParaLetter(Number As Integer) As String
        Select Case Number
            Case 1
                Return "a. "
            Case 2
                Return "b. "
            Case 3
                Return "c. "

            Case Else
                Return ""



        End Select
    End Function
    Public Function Determine(a As CheckBox, b As CheckBox, c As CheckBox) As String
        If a.Checked And b.Checked And c.Checked Then
            Return "A"
        End If
        If a.Checked = True And b.Checked = True And c.Checked = False Then

            Return "B"
        End If
        If a.Checked = True And b.Checked = False And c.Checked = True Then
            Return "C"

        End If
        If a.Checked = True And b.Checked = False And c.Checked = False Then
            Return "D"
        End If
        If a.Checked = False And b.Checked = True And c.Checked = True Then
            Return "E"
        End If
        If a.Checked = False And b.Checked = False And c.Checked = True Then
            Return "F"
        End If

        If a.Checked = False And b.Checked = True And c.Checked = False Then

            Return "G"
        End If
        If a.Checked = False And b.Checked = False And c.Checked = False Then
            Exit Function
            Return "H"
            MsgBox("You have not selected a First Appointment Document to be served")

        End If


    End Function

    Public Function listbox2string(a As CheckedListBox) As String

        Dim sb As New StringBuilder



        Dim i As Integer
        i = 1


        For Each item In a.Items


            sb.Append("(")
            sb.Append(i.ToString)
            sb.Append(")")
            sb.Append(vbTab)
            sb.Append(item.ToString)
            sb.Append(vbCrLf)



            i = i + 1

        Next
        Return sb.ToString

    End Function
    Public Sub chklstEmpty(a As CheckedListBox)
        a.Items.Clear()




    End Sub
    Public Function IsWeekDay(d As Date) As Boolean
        Select Case d.ToString("ddd")
            Case "Mon"
                Return True
            Case "Tue"
                Return True
            Case "Wed"
                Return True
            Case "Thu"
                Return True
            Case "Fri"
                Return True
            Case "Sat"
                Return False
            Case "Sun"
                Return False
            Case Else
                Exit Function




        End Select
    End Function


End Module
