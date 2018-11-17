Imports MySql.Data.MySqlClient

Module writeRepair

    Public Function schreibeReparatur(myDate, myCosts)

        Dim schreibeReparaturError As Boolean = True

        Try

            'mysql kommando definieren
            Dim myQuerySchreibeReparatur As New MySqlCommand(MySqlInsertReparatur(myDate, myCosts), con)
            Dim myResultSchreibeReparatur As Object

            'mysql kommando ausführen
            myResultSchreibeReparatur = myQuerySchreibeReparatur.ExecuteScalar()

            'wenn abfrage ohne ergebnis fehler melden
            If IsDBNull(myResultSchreibeReparatur) Then

                'wenn abfrage ohne ergebnis
                schreibeReparaturError = False

            End If

            'Variablen definieren
            Dim MyRepairArbeitsschrittNummer As Integer = 0
            Dim MyRepairArbeitsschritt As String = ""

            For i = 0 To FormNewRepair.listviewNewRepair.Items.Count - 1

                MyRepairArbeitsschrittNummer = FormNewRepair.listviewNewRepair.Items(i).Text
                MyRepairArbeitsschritt = FormNewRepair.listviewNewRepair.Items(i).SubItems(1).Text

                'mysql kommando definieren
                Dim myQuerySchreibeReparaturItem As New MySqlCommand(MySqlInsertReparaturItem(myDate, myCosts, MyRepairArbeitsschrittNummer, MyRepairArbeitsschritt), con)
                Dim myResultSchreibeReparaturItem As Object

                'mysql kommando ausführen
                myResultSchreibeReparaturItem = myQuerySchreibeReparaturItem.ExecuteScalar()

                'wenn abfrage ohne ergebnis fehler melden
                If IsDBNull(myResultSchreibeReparaturItem) Then

                    'wenn abfrage ohne ergebnis
                    schreibeReparaturError = False

                End If

            Next

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return schreibeReparaturError

    End Function

End Module
