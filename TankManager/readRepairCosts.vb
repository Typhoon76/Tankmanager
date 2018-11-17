Imports MySql.Data.MySqlClient

Module readRepairCosts

    Public Function LeseReparaturkostenGesamt()

        'mysql kommando definieren
        Dim myQueryReparaturkostenGesamt As New MySqlCommand(MySqlSelectReparaturkostenGesamt(), con)
        Dim myResultReparaturkostenGesamt As Object

        Dim reparaturGesamtError As Boolean = False

        'mysql kommando ausführen
        myResultReparaturkostenGesamt = myQueryReparaturkostenGesamt.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultReparaturkostenGesamt) Then

            'wenn abfrage ohne ergebnis
            reparaturGesamtError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxGesamtkostenReparatur.Text = CType(myResultReparaturkostenGesamt, Single).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return reparaturGesamtError

    End Function

    Public Function LeseReparaturkostenJahr(Jahr)

        'mysql kommando definieren
        Dim myQueryReparaturkostenJahr As New MySqlCommand(MySqlSelectReparaturkosten(Jahr), con)
        Dim myResultReparaturkostenJahr As Object

        Dim reparaturJahrError As Boolean = False

        'mysql kommando ausführen
        myResultReparaturkostenJahr = myQueryReparaturkostenJahr.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultReparaturkostenJahr) Then

            'wenn abfrage ohne ergebnis
            reparaturJahrError = True

        Else

            'sonst abfrage ergebnis in textbox schreiben
            formMain.TextboxReparaturkostenJahr.Text = CType(myResultReparaturkostenJahr, Single).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return reparaturJahrError

    End Function

End Module
