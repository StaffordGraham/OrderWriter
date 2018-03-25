Public Class InitStepsClass
    Public Order1 As String
    Public Order2 As String
    Public Order3 As String
    Public Order4 As String
    Public FullOrder As String
    Public AttendMiam As Boolean
    Public PersonDirected As String



    '27.	The [applicant] / [respondent] shall attend a Mediation Information And Assessment Meeting And shall file a completed Form FM1 by [time And date].

    Private Sub New(PersonDirected As String, DateDirected As Date, AttendMiam As Boolean)
        If AttendMiam = True Then

            Order1 = "The " + PersonDirected + "shall attend a Mediation Information and Assesssment Meeting and shall file a completed Form FM1 by " + CStr(DateDirected)

            ' End If



        End If

    End Sub

    Public Sub DraftInitOrder()







    End Sub
End Class
