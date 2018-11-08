Imports MySql.Data.MySqlClient

Module deleteRefuelItem

    Public Function LoescheTankenEintrag(Query)

        'Mysql kommando definieren
        Dim myQueryTankenEintrag As New MySqlCommand(Query, con)

        'Statusvariable initialisieren und auf falsch setzen
        Dim tankenEintragStatus As Boolean = False

        Try

            'wenn Rückgabe ein Ergebnis hat
            If myQueryTankenEintrag.ExecuteNonQuery() = 1 Then

                'Statusvariable auf wahr setzen
                tankenEintragStatus = True

            Else

                'ansonstens Statusvariable auf falsch
                tankenEintragStatus = False

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'Fehler melden und Fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Statusvariable auf falsch
            tankenEintragStatus = False

        End Try

        'Status zurückgeben
        Return tankenEintragStatus

    End Function

End Module
