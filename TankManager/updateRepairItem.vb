Imports MySql.Data.MySqlClient

Module updateRepairItem

    'Public Function updateReparaturEintrag(repairDate, repairCosts)
    Public Function updateReparaturEintrag()

        'Fehler variable definieren
        Dim updateReparaturState As Boolean = True

        'ID ermitteln
        Dim MyID = tankmanagerRepair.Entry.Item(0).repair_id

        'Datumformat für DB anpassen
        'Dim MyRepairDate As String = Convert.ToDateTime(repairDate).ToString("yyyy-MM-dd")
        Dim MyRepairDate As String = Convert.ToDateTime(formEditRepair.dateTimePickerEditRepair.Value).ToString("yyyy-MM-dd")

        'Kommas durch Punkte setzen
        'Dim MyRepairCosts As String = repairCosts.Replace(",", ".")
        Dim MyRepairCosts As String = formEditRepair.textboxEditRepairCosts.Text.Replace(",", ".")

        Try

            'mysql kommando definieren
            Dim myQueryUpdateReparatur As New MySqlCommand(MySqlUpdateReparaturEintrag(MyRepairDate, MyRepairCosts, MyID), con)
            Dim myResultUpdateReparatur As Object

            'mysql kommando ausführen
            myResultUpdateReparatur = myQueryUpdateReparatur.ExecuteScalar()

            'wenn abfrage ohne ergebnis fehler melden
            If IsDBNull(myResultUpdateReparatur) Then

                'wenn abfrage ohne ergebnis
                updateReparaturState = False

            Else

                'alte Einträge löschen
                'mysql kommando definieren
                Dim myQueryDeleteReparaturArbeitsschritt As New MySqlCommand(MySqlDeleteReparaturArbeitsschritt(MyID), con)
                Dim myResultDeleteReparaturArbeitsschritt As Object

                'mysql kommando ausführen
                myResultDeleteReparaturArbeitsschritt = myQueryDeleteReparaturArbeitsschritt.ExecuteScalar()

                'wenn abfrage ohne ergebnis
                If IsDBNull(myResultDeleteReparaturArbeitsschritt) Then

                    'wenn abfrage ohne ergebnis
                    updateReparaturState = False

                Else

                    'ansonsten reparaturliste eintragen

                    'Variablen definieren
                    Dim MyRepairArbeitsschrittNummer As Integer = 0
                    Dim MyRepairArbeitsschritt As String = ""

                    For i = 0 To formEditRepair.listviewEditRepair.Items.Count - 1

                        MyRepairArbeitsschrittNummer = formEditRepair.listviewEditRepair.Items(i).Text
                        MyRepairArbeitsschritt = formEditRepair.listviewEditRepair.Items(i).SubItems(1).Text

                        'mysql kommando definieren
                        Dim myQueryUpdateReparaturArbeitschritt As New MySqlCommand(MySqlInsertReparaturArbeitsschritt(MyID, MyRepairArbeitsschrittNummer, MyRepairArbeitsschritt), con)
                        Dim myResultUpdateReparaturArbeitschritt As Object

                        'mysql kommando ausführen
                        myResultUpdateReparaturArbeitschritt = myQueryUpdateReparaturArbeitschritt.ExecuteScalar()

                        'wenn abfrage ohne ergebnis fehler melden
                        If IsDBNull(myResultUpdateReparaturArbeitschritt) Then

                            'wenn abfrage ohne ergebnis
                            updateReparaturState = False

                        End If

                    Next

                End If

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            updateReparaturState = False

        End Try

        Return updateReparaturState

    End Function

End Module
