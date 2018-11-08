Imports MySql.Data.MySqlClient

Module readConsumption

    'gas mileage
    Public Function LeseVerbrauchGesamt()

        'mysql kommando definieren
        Dim myQueryVerbrauchGesamt As New MySqlCommand(MySqlSelectVerbrauchGesamt(), con)
        Dim myResultVerbrauchGesamt As Object

        Dim verbrauchGesamtError As Boolean = False

        'mysql kommando ausführen
        myResultVerbrauchGesamt = myQueryVerbrauchGesamt.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultVerbrauchGesamt) Then

            'wenn abfrage ohne ergebnis
            verbrauchGesamtError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.textboxGesamterVerbrauch.Text = CType(myResultVerbrauchGesamt, Single).ToString("F" & tankmanagerSettings.format_quantity)

        End If

        Return verbrauchGesamtError

    End Function

    'fuel consumption
    Public Function LeseVerbrauchJahr(Jahr)

        'mysql kommando definieren
        Dim myQueryVerbrauchJahr As New MySqlCommand(MySqlSelectVerbrauch(Jahr), con)
        Dim myResultVerbrauchJahr As Object

        Dim verbrauchJahrError As Boolean = False

        'mysql kommando ausführen
        myResultVerbrauchJahr = myQueryVerbrauchJahr.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultVerbrauchJahr) Then

            'wenn abfrage ohne ergebnis
            verbrauchJahrError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.textboxVerbrauchJahr.Text = CType(myResultVerbrauchJahr, Single).ToString("F" & tankmanagerSettings.format_quantity)

        End If

        Return verbrauchJahrError

    End Function

End Module
