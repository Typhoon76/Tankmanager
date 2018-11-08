Public Class FormPrintingChoice

    Public ReturnCode = 0

    Private Sub buttonPrintingChoiceCancel_Click(sender As Object, e As EventArgs) Handles buttonPrintingChoiceCancel.Click

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub buttonPrintingChoiceRefuel_Click(sender As Object, e As EventArgs) Handles buttonPrintingChoiceRefuel.Click

        ReturnCode = 1

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub buttonPrintingChoiceRepair_Click(sender As Object, e As EventArgs) Handles buttonPrintingChoiceRepair.Click

        ReturnCode = 2

        'Fenster schließen
        Me.Close()

    End Sub

    Public Function returning()

        Return ReturnCode

    End Function

End Class