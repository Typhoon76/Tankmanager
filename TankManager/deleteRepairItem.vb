Imports MySql.Data.MySqlClient

Module deleteRepairItem

    Public Function LoescheReparaturEintrag()

        'ID ermitteln
        Dim MyID = tankmanagerRepair.Entry.Item(0).repair_id

        'Mysql kommando definieren
        Dim myQueryReparaturEintrag As New MySqlCommand(MySqlDeleteReparaturEintrag(MyID), con)

        'Statusvariable initialisieren und auf falsch setzen
        Dim reparaturEintragState As Boolean = False

        Try

            'wenn Rückgabe ein Ergebnis hat
            If myQueryReparaturEintrag.ExecuteNonQuery() = 1 Then

                'Mysql kommando definieren
                Dim myQueryReparaturArbeitsschritte As New MySqlCommand(MySqlDeleteReparaturArbeitsschritt(MyID), con)

                'Einträge mit id MyID in Tabelle tbl_reparaturliste löschen
                myQueryReparaturArbeitsschritte.ExecuteNonQuery()

                'Statusvariable auf wahr setzen
                reparaturEintragState = True

            Else

                'ansonstens Statusvariable auf falsch
                reparaturEintragState = False

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'Fehler melden und Fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Statusvariable auf falsch
            reparaturEintragState = False

        End Try

        'Status zurückgeben
        Return reparaturEintragState

    End Function

End Module
