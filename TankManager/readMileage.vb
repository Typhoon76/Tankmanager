Imports MySql.Data.MySqlClient

Module readMileage

    Public Function LeseKilometerGesamt()

        'mysql kommando definieren
        Dim myQueryKmGefahrenGesamt As New MySqlCommand(MySqlSelectKmGefahrenGesamt(), con)
        Dim myResultKmGefahrenGesamt As Object

        Dim kilometerGesamtError As Boolean = False

        'mysql kommando ausführen
        myResultKmGefahrenGesamt = myQueryKmGefahrenGesamt.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultKmGefahrenGesamt) Then

            'wenn abfrage ohne ergebnis
            kilometerGesamtError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxGesamtkilometerGefahren.Text = CType(myResultKmGefahrenGesamt, Single).ToString("F" & tankmanagerSettings.format_mileage)

        End If

        Return kilometerGesamtError

    End Function

    Public Function LeseKilometerJahr(Jahr)

        'mysql kommando definieren
        Dim myQueryKmGefahrenJahr As New MySqlCommand(MySqlSelectKmGefahren(Jahr), con)
        Dim myResultKmGefahrenJahr As Object

        Dim kilometerJahrError As Boolean = False

        'mysql kommando ausführen
        myResultKmGefahrenJahr = myQueryKmGefahrenJahr.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultKmGefahrenJahr) Then

            'wenn abfrage ohne ergebnis
            kilometerJahrError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxKmGefahrenJahr.Text = CType(myResultKmGefahrenJahr, Single).ToString("F" & tankmanagerSettings.format_route)

        End If

        Return kilometerJahrError

    End Function

End Module
