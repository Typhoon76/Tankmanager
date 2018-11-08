Public Class classRepair

    Public Class Reparation
        Public Property repair_id As Integer
        Public Property repair_date As String
        Public Property repair_price As Single
        Public Property repair_number As Integer
        Public Property repair_step As String
    End Class

    Public Class Repairlist
        Public Property Entry As New List(Of Reparation)
    End Class

End Class