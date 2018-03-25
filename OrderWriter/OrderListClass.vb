Public Class OrderListClass
    Public Counter As Integer
    Public OrderType As New List(Of String)
    Public Sub New()

    End Sub
    Public Sub OrderAdd(p As String)

        OrderType.Add(p)

        Counter = Counter + 1

        'MsgBox()
    End Sub

End Class
