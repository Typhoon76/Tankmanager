'importieren von MySql
Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module dbConnect

    'die Verbindung zur Datenbank definieren, damit von überall her darauf zugegriffen werden kann
    Public con As New MySqlConnection

    Public Function ConnectDatabase()

        'array defninieren
        Dim mysqlError() As String

        LeseIni()

        Try

            'Testen ob die Verbindung noch offen ist, wenn nein dann
            If con.State = ConnectionState.Closed Then

                'VerbindungsString erstellen
                con.ConnectionString = "SERVER=" & tankmanagerConnection.serverName & "; PORT=" & tankmanagerConnection.serverPort & "; USER ID=" & tankmanagerConnection.userName & "; PASSWORD=" & tankmanagerConnection.userPassWd & "; CHARSET=" & tankmanagerConnection.charset & ";"

                'Verbindung öffnen
                con.Open()

            End If

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