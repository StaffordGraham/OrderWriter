Public Class Party
    Public PartyType As String
    Public Title As String
    Public Name As String

    Public Sex As String
    Public NominativePronoun As String
    Public AccusativePronoun As String
    Private PPronoun As String
    Public PossessivePronoun As String









    Public Sub SetPronouns()
        Select Case Sex
            Case "Male"
                NominativePronoun = "He"
                AccusativePronoun = "him"
                PossessivePronoun = "his"
            Case "Female"
                NominativePronoun = "She"
                AccusativePronoun = "her"
                PossessivePronoun = "her"


        End Select
        
End sub


End Class
