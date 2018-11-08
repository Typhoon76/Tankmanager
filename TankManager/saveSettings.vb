Imports MySql.Data.MySqlClient

Module saveSettings

    Public Function saveSettigsToDB()

        Dim SaveSettingsToDBError As Boolean = False

        Try

            'mysql kommando definieren
            Dim myQuerySaveSettingsToDB As New MySqlCommand(MySqlUpdateEinstellungen(), con)
            Dim myResultSaveSettingsToDB As Object

            'mysql kommando ausführen
            myResultSaveSettingsToDB = myQuerySaveSettingsToDB.ExecuteScalar()

            'wenn abfrage ohne ergebnis fehler melden
            If IsDBNull(myResultSaveSettingsToDB) Then

                'wenn abfrage ohne ergebnis
                SaveSettingsToDBError = True

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return SaveSettingsToDBError

    End Function

    Public Function saveSettingsToIniFile()

        tankmanagerIni.WriteString("SQLSERVER", "Address", tankmanagerConnection.serverName)
        tankmanagerIni.WriteString("SQLSERVER", "Port", tankmanagerConnection.serverPort)
        tankmanagerIni.WriteString("SQLSERVER", "Charset", tankmanagerConnection.charset)
        tankmanagerIni.WriteString("USER", "Name", tankmanagerConnection.userName)
        tankmanagerIni.WriteString("USER", "Passwd", tankmanagerConnection.userPassWd)

    End Function

End Module
