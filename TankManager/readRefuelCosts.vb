Imports MySql.Data.MySqlClient

Module readFuel

    Public Function LeseBezinkostenGesamt()

        'mysql kommando definieren
        Dim myQueryBenzinkostenGesamt As New MySqlCommand(MySqlSelectBenzinkostenGesamt(), con)
        Dim myResultBenzinkostenGesamt As Object

        Dim benzinGesamtError As Boolean = False

        'mysql kommando ausführen
        myResultBenzinkostenGesamt = myQueryBenzinkostenGesamt.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultBenzinkostenGesamt) Then

            'wenn abfrage ohne ergebnis
            benzinGesamtError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxGesamtkostenBenzin.Text = CType(myResultBenzinkostenGesamt, Single).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return benzinGesamtError

    End Function

    Public Function LeseBenzinkostenJahr(Jahr)

        'mysql kommando definieren
        Dim myQueryBenzinkostenJahr As New MySqlCommand(MySqlSelectBenzinkosten(Jahr), con)
        Dim myResultBezinkostenJahr As Object

        Dim benzinJahrError As Boolean = False

        'mysql kommando ausführen
        myResultBezinkostenJahr = myQueryBenzinkostenJahr.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultBezinkostenJahr) Then

            'wenn abfrage ohne ergebnis
            benzinJahrError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxBenzinkostenJahr.Text = CType(myResultBezinkostenJahr, Single).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return benzinJahrError

    End Function

End Module
