Module refreshDisplay

    Public Function refreshFormMain()

        'ergebnis der comboxbox auswahl definieren und gleich den ausgewählten wert eintragen
        Dim resultComboboxJahr As String = formMain.ComboboxJahrAuswahl.SelectedItem.ToString

        'variable für mysql befehl erstellen und eine leere zeichenkette zuweisen
        Dim myQueryJahre As String = ""
        Dim myQueryReparaturen As String = ""

        'variable für fehlerabfrage definieren
        Dim comboboxError As Boolean = False

        'variable für alle Jahre anzeigen definieren
        Dim comboboxAlleJahre As Boolean = False

        'variablen für Fehler der Tabelle tbl_tanken und tbl_reparaturen
        Dim benzinJahrError As Boolean = False
        Dim reparaturJahrError As Boolean = False
        Dim kostenJahrError As Boolean = False
        Dim kilometerJahrError As Boolean = False
        Dim verbrauchJahrError As Boolean = False

        'wenn in comboboxJahrAuswahl eine JAhreszahl ausgewählt ist
        If IsNumeric(resultComboboxJahr) Then

            'string für abfrage einzelner Jahre definieren
            myQueryJahre = MySqlSelectTankenJahr(resultComboboxJahr)
            myQueryReparaturen = MySqlSelectReparaturenJahr(resultComboboxJahr)

            'variable für alle Jahre auf falsch setzen
            comboboxAlleJahre = False

            'wenn die Auswahl auf Alle Jahre steht
        ElseIf resultComboboxJahr = comboboxJahrAuswahlErsterEintrag Then

            'string für abfrage aller daten definieren
            myQueryJahre = MySqlSelectTankenGesamt()
            myQueryReparaturen = MySqlSelectReparaturenGesamt()

            'variable für alle Jahre auf wahr setzen
            comboboxAlleJahre = True

            'wenn unbekannte Auswahö
        Else

            'fehler ausgeben
            MessageBox.Show("unbekannte Auswahl", "comboboxJahrAuswahl", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'fehlervariable auf wahr setzen
            comboboxError = True

        End If

        'wenn kein Fehler vorliegt
        If comboboxError = False Then

            'Daten für DGV Tanken lesen
            LeseTanken(myQueryJahre)

            'testen ob datagridview zeilen hat
            If formMain.DatagridviewTanken.Rows.Count > 0 Then

                'DGV Tanken Anzeige anpssen
                setupDGVTankenDisplay()

                'DGV Tanken anpassen
                setupDGVTanken()

                'wenn resultComboboxJahr eine Jahreszahl enthält dann
                If comboboxAlleJahre = False Then

                    'Benzinkosten pro Jahr berechnen und anzeigen
                    benzinJahrError = LeseBenzinkostenJahr(resultComboboxJahr)

                    'Reparaturkosten pro Jahr berechnen und anzeigen
                    reparaturJahrError = LeseReparaturkostenJahr(resultComboboxJahr)

                    'Gesamtkosten berechnen und anzeigen
                    kostenJahrError = getCostsYear()

                    'km gefahren jahr berechnen und anzeigen
                    kilometerJahrError = LeseKilometerJahr(resultComboboxJahr)

                    'verbrauch jahr berechnen und anzeigen
                    verbrauchJahrError = LeseVerbrauchJahr(resultComboboxJahr)

                    'Fehler auswerten
                    If benzinJahrError = True Or
                        reparaturJahrError = True Or
                        kostenJahrError = True Or
                        kilometerJahrError = True Or
                        verbrauchJahrError = True Then
                        Dim myErrorString As String = "Fehlerliste: " & vbCrLf
                        If benzinJahrError = True Then myErrorString = myErrorString & vbCrLf & "* 'tbl_tanken' enthält keine Benzinkosten"
                        If reparaturJahrError = True Then myErrorString = myErrorString & vbCrLf & "* 'tbl_reparaturen' enthält keine Reparaturkosten"
                        If kostenJahrError = True Then myErrorString = myErrorString & vbCrLf & "* Gesamtkosten (Jahr) können nicht berechnet werden"
                        If kilometerJahrError = True Then myErrorString = myErrorString & vbCrLf & "* 'tbl_tanken' enthält keine gefahrenen Kilometer"
                        If verbrauchJahrError = True Then myErrorString = myErrorString & vbCrLf & "* Verbrauch kann nicht berechnet werden"

                        'Fehlermeldung anzeigen
                        MessageBox.Show(myErrorString, "Tabellen Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                Else

                    'ansonsten Textboxen für Jahresdaten leeren

                    'preis pro jahr löschen
                    formMain.TextboxBenzinkostenJahr.Text = ""

                    'reparaturkosten pro jahr löschen
                    formMain.TextboxReparaturkostenJahr.Text = ""

                    'gesamtkosten pro jahr löschen
                    formMain.TextboxGesamtkostenJahr.Text = ""

                    'km gefahren löschen
                    formMain.TextboxKmGefahrenJahr.Text = ""

                    'gesamtverbrauch pro jahr löschen
                    formMain.TextboxVerbrauchJahr.Text = ""

                End If

                'Daten für DGV Reparaturen lesen
                LeseReparaturen(myQueryReparaturen)

                'testen ob datagridview zeilen hat
                If formMain.DatagridviewReparaturen.Rows.Count > 0 Then

                    'DataGridView Reparaturen füllen
                    setupDGVReparaturenDisplay()

                    'DataGridView Reparaturen anpassen
                    setupDGVReparaturen()

                End If

                'Gesamtdaten für Benzin lesen und anzeigen
                LeseBezinkostenGesamt()

                'Gesamtdaten für Reparaturen lesen und anzeigen
                LeseReparaturkostenGesamt()

                'Gesamtkosten für alles lesen und anzeigen
                getCostsAll()

                'Gesamtdaten km gefahren lesen und anzeigen
                LeseKilometerGesamt()

                'Gesamtdaten Verbrauch lesen und anzeigen
                LeseVerbrauchGesamt()

            End If

        End If

        'Alter einlesen
        LeseAlter()

        'die blaue markierung eines ausgewählten eintrages entfernen durch setzen des focus auf ein anderes objekt
        formMain.FormMainLabelNumberOfDataRecords.Focus()

    End Function

    Public Function setupDGVTankenDisplay()

        'erstes datum erfassen
        Dim myTankenDate = formMain.DatagridviewTanken.Rows(0).Cells(1).Value

        'alle zeilen durchlaufen
        For i = 1 To formMain.DatagridviewTanken.Rows.Count - 1

            'wenn einstellung für mehrfache gleiche Datumsangaben ausblenden auf 1 steht
            If tankmanagerSettings.tankenHideDoubleDateEntries = True Then

                'wenn datum in zeile gleich datum der vorherigen zeile
                If formMain.DatagridviewTanken.Rows(i).Cells(1).Value = myTankenDate Then

                    'dann datum leer lassen
                    formMain.DatagridviewTanken.Rows(i).Cells(1).Value = ""

                Else

                    'ansonsten neues datum erfassen
                    myTankenDate = formMain.DatagridviewTanken.Rows(i).Cells(1).Value

                End If

            End If

        Next

    End Function

    Public Function setupDGVReparaturenDisplay()

        'erstes datum und ersten preis erfassen
        Dim myReparaturDate = formMain.DatagridviewReparaturen.Rows(0).Cells(1).Value
        Dim myReparaturPrice = formMain.DatagridviewReparaturen.Rows(0).Cells(2).Value

        'wenn einstellung für mehrfache gleiche Datumsangaben oder mehrfache gleiche Zeitangaben ausblenden auf 1 steht
        If tankmanagerSettings.reparaturHideDoubleDateEntries = True Or tankmanagerSettings.reparaturHideDoublePriceEntries = True Then

            'alle zeilen durchlaufen
            For i = 1 To formMain.DatagridviewReparaturen.Rows.Count - 1

                'wenn einstellung für mehrfache doppelte Datumsangaben ausblenden auf 1 steht
                If tankmanagerSettings.reparaturHideDoubleDateEntries = True Then

                    'wenn datum in zeile gleich datum der vorherigen zeile
                    If formMain.DatagridviewReparaturen.Rows(i).Cells(1).Value = myReparaturDate Then

                        'dann datum leer lassen
                        formMain.DatagridviewReparaturen.Rows(i).Cells(1).Value = ""

                    Else

                        'ansonsten neues datum erfassen
                        myReparaturDate = formMain.DatagridviewReparaturen.Rows(i).Cells(1).Value

                    End If

                End If

                'wenn einstellung für mehrfache doppelte Preisangaben ausblenden auf 1 steht
                If tankmanagerSettings.reparaturHideDoublePriceEntries = True Then

                    'wenn preis in zeile gleich preis der vorherigen zeile
                    If formMain.DatagridviewReparaturen.Rows(i).Cells(2).Value IsNot DBNull.Value Then

                        If formMain.DatagridviewReparaturen.Rows(i).Cells(2).Value = myReparaturPrice Then

                            'dann preis leer lassen
                            formMain.DatagridviewReparaturen.Rows(i).Cells(2).Value = DBNull.Value

                        Else

                            'ansonsten neuen preis erfassen
                            myReparaturPrice = formMain.DatagridviewReparaturen.Rows(i).Cells(2).Value

                        End If
                    End If

                End If

            Next

        End If

    End Function

End Module
