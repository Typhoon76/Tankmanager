Imports MySql.Data.MySqlClient

Module readRepair

    Public Function LeseReparaturen(Query)

        'Datentabelle definieren
        Dim dbDTReparaturen As New DataTable

        'Datenadapter definieren
        Dim dbDAReparaturen As New MySqlDataAdapter

        'kommando füllen
        Dim cmd As New MySqlCommand With {
                    .Connection = con,
                    .CommandText = Query
                }

        'Datenadapter einem Kommando zuweisen
        dbDAReparaturen.SelectCommand = cmd

        'Datenadapter füllen
        dbDAReparaturen.Fill(dbDTReparaturen)

        'Daten in Datagridview eintragen
        formMain.datagridviewReparaturen.DataSource = dbDTReparaturen

        'auswahl der zeile bei der ersten anzeige der daten entfernen
        formMain.datagridviewReparaturen.ClearSelection()

    End Function

    Public Function LeseReparaturEintrag(Query)

        'mysql kommando definieren
        Dim myQueryReparaturEintrag As New MySqlCommand(Query, con)
        Dim myResultReparaturEintrag As MySqlDataReader

        'Fehlervariable initialisieren und auf falsch setzen
        Dim reparaturEintragError As Boolean = False

        'mysql kommando ausführen
        myResultReparaturEintrag = myQueryReparaturEintrag.ExecuteReader

        'wenn abfrage ohne ergebnis 
        If IsDBNull(myResultReparaturEintrag) Then

            'fehlervariable auf wahr setzen
            reparaturEintragError = True

        Else

            'wenn die abfrage eine Zeile hat dann
            If myResultReparaturEintrag.HasRows = True Then

                'Klasse leeren
                tankmanagerRepair.Entry.Clear()

                'zeilen durcharbeiten
                While (myResultReparaturEintrag.Read())

                    'wenn id vorhanden
                    If Not IsDBNull(myResultReparaturEintrag("id")) Then

                        'Klasse für Eintrag definieren
                        Dim tankmanagerRepairEntry As New classRepair.Reparation

                        'Klassendaten zuweisen
                        tankmanagerRepairEntry.repair_id = myResultReparaturEintrag("id")
                        tankmanagerRepairEntry.repair_date = myResultReparaturEintrag("datum")
                        tankmanagerRepairEntry.repair_price = myResultReparaturEintrag("preis")
                        If Not IsDBNull(myResultReparaturEintrag("nummer")) Then tankmanagerRepairEntry.repair_number = myResultReparaturEintrag("nummer")
                        If Not IsDBNull(myResultReparaturEintrag("posten")) Then tankmanagerRepairEntry.repair_step = myResultReparaturEintrag("posten")

                        'Klasse in Reparaturliste aufnehmen
                        tankmanagerRepair.Entry.Add(tankmanagerRepairEntry)

                        End If

                End While

            Else

                'wenn kein ergebnis fehlervariable auf wahr setzen
                reparaturEintragError = True

            End If

        End If

        'abfrage schließen
        myResultReparaturEintrag.Close()

        'Fehler zurückgeben
        Return reparaturEintragError

    End Function

End Module
