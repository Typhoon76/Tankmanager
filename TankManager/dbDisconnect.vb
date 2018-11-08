Module dbDisconnect

    Public Function DisconnectDatabase()

        'array defninieren
        Dim mysqlError() As String

        Try

            'Verbindung schließen
            con.Close()

            'und wahr zurückgeben
            Return True

            'Fehler abfangen
        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'fehler meldung und fehlercode in array schreiben
            mysqlError = {myerror.Message, myerror.Number}

            'und fehler zurück geben
            Return mysqlError

        End Try

    End Function

End Module
