Imports MySql.Data.MySqlClient

Module checkMinMaxJahre

    Public Function checkcomboboxJahrAuswahlMinMaxJahre(comboboxJahrAuswahlFromDB As String, comboboxJahrAuswahlStandard As String)

        'prüfen ob gesetzter Standardwert für comboboxJahrAuswahl innerhalb der minnimalen und maximalen Jahre der in der atenbank vorhandenen Einträge liegt

        Dim minMaxJahreState As Boolean = False
        Dim comboboxJahrAuswahlMinJahr As String = ""
        Dim comboboxJahrAuswahlMaxJahr As String = ""

        Try

            'mysql kommando definieren
            Dim myQueryMinMaxJahr As New MySqlCommand(MySqlSelectMinMaxJahr(), con)
            Dim myResultMinMaxJahr As MySqlDataReader

            'mysql kommando ausführen
            myResultMinMaxJahr = myQueryMinMaxJahr.ExecuteReader()

            While (myResultMinMaxJahr.Read())

                If myResultMinMaxJahr.HasRows = True Then

                    'sonst abfrage ergebnis i nvariablen schreiben
                    comboboxJahrAuswahlMinJahr = myResultMinMaxJahr("MinJahr")
                    comboboxJahrAuswahlMaxJahr = myResultMinMaxJahr("MaxJahr")

                End If

            End While

            'Jahresabfrage schließen
            myResultMinMaxJahr.Close()

            'prüfen ob standardwert der comboboxJahrAuswahl "gleich oder größer" und "gleich oder kleiner" oder gleich String für ersten Eintrag ist
            If comboboxJahrAuswahlFromDB >= comboboxJahrAuswahlMinJahr AndAlso comboboxJahrAuswahlFromDB <= comboboxJahrAuswahlMaxJahr Or comboboxJahrAuswahlFromDB = comboboxJahrAuswahlStandard Then

                'wenn ja status auf wahr setzen
                minMaxJahreState = True

            ElseIf comboboxJahrAuswahlFromDB = comboboxJahrAuswahlErsterEintrag Then

                'wenn ja status auf wahr setzen
                minMaxJahreState = True

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'status zurückgegeben
        Return minMaxJahreState

    End Function

End Module
