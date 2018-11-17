Imports MySql.Data.MySqlClient

Module readYears

    Public Function LeseJahre()

        '### füllen der ComboBox "comboboxJahrAuswahl"
        Dim dbQueryYears As New MySqlCommand(MySqlSelectComboboxJahre(), con)
        Dim dbResultYears As MySqlDataReader

        Dim yearsError As Boolean = False

        'weitere Daten abfragen
        dbResultYears = dbQueryYears.ExecuteReader

        'wenn die Daten eine Zeile haben dann
        If dbResultYears.HasRows = True Then

            'ersten Eintrag einfügen
            formMain.ComboboxJahrAuswahl.Items.Add(comboboxJahrAuswahlErsterEintrag)

            'Daten einlesen
            While (dbResultYears.Read())

                'Inhalt der Spalte Jahre in Combobox eintragen
                formMain.ComboboxJahrAuswahl.Items.Add(dbResultYears("ComboboxJahre"))

            End While

        Else

            'wenn kein ergebnis einstellungsfehler auf wahr setzen
            yearsError = True

        End If

        'Datenabfrage schließen
        dbResultYears.Close()

        Return yearsError

    End Function

End Module
