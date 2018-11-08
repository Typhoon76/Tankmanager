Imports MySql.Data.MySqlClient

Module readRefuel

    Public Function LeseTanken(Query)

        'Datentabelle definieren
        Dim dbDTTanken As New DataTable

        'Datenadapter definieren
        Dim dbDATanken As New MySqlDataAdapter

        'kommando füllen
        Dim cmd As New MySqlCommand With {
                    .Connection = con,
                    .CommandText = Query
                }

        'Datenadapter einem Kommando zuweisen
        dbDATanken.SelectCommand = cmd

        'Datenadapter füllen
        dbDATanken.Fill(dbDTTanken)

        'Daten in Datagridview eintragen
        formMain.datagridviewTanken.DataSource = dbDTTanken

        'auswahl der zeile bei der ersten anzeige der daten entfernen
        formMain.datagridviewTanken.ClearSelection()

        'anzahl datensätze in textbox eintragen
        formMain.textboxJahrDatensaetze.Text = dbDTTanken.Rows.Count

    End Function

    Public Function LeseTankenEintrag(Query)

        'MessageBox.Show(Query)
        'Console.WriteLine(Query)

        'mysql kommando definieren
        Dim myQueryTankenEintrag As New MySqlCommand(Query, con)
        Dim myResultTankenEintrag As MySqlDataReader

        'Fehlervariable initialisieren und auf falsch setzen
        Dim tankenEintragError As Boolean = False

        'mysql kommando ausführen
        myResultTankenEintrag = myQueryTankenEintrag.ExecuteReader

        'wenn abfrage ohne ergebnis 
        If IsDBNull(myResultTankenEintrag) Then

            'fehlervariable auf wahr setzen
            tankenEintragError = True

        Else

            'zeilen durcharbeiten
            While (myResultTankenEintrag.Read())

                'wenn die abfrage eine Zeile hat dann
                If myResultTankenEintrag.HasRows = True Then

                    'gelesene Daten in die Klasse übertragen
                    tankmanagerRefuel.refuel_id = myResultTankenEintrag("id")
                    tankmanagerRefuel.refuel_date = myResultTankenEintrag("datum")
                    tankmanagerRefuel.refuel_time = myResultTankenEintrag("zeit")
                    tankmanagerRefuel.refuel_quantity = myResultTankenEintrag("liter")
                    tankmanagerRefuel.refuel_price = myResultTankenEintrag("preis")
                    tankmanagerRefuel.refuel_route = myResultTankenEintrag("gefahren")
                    tankmanagerRefuel.refuel_mileage = myResultTankenEintrag("gesamt")

                Else

                    'wenn kein ergebnis fehlervariable auf wahr setzen
                    tankenEintragError = True

                End If

            End While

        End If

        'abfrage schließen
        myResultTankenEintrag.Close()

        'Fehler zurückgeben
        Return tankenEintragError

    End Function

End Module