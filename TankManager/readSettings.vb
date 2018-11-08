Imports MySql.Data.MySqlClient

Module readSettings

    Public Function LeseEinstellungen()

        Dim dbQuerySettings As New MySqlCommand(MySqlSelectEinstellungen(), con)
        Dim dbResultSettings As MySqlDataReader

        Dim settingsError As Boolean = False

        'Einstellungen abfragen
        dbResultSettings = dbQuerySettings.ExecuteReader

        'wenn die Einstellungen eine Zeile haben dann
        While (dbResultSettings.Read())

            If dbResultSettings.HasRows = True Then

                'zuweisen der einzelnen werte aus der abfrage
                tankmanagerSettings.date_of_construction = dbResultSettings("car_date_of_construction")
                tankmanagerSettings.format_date = dbResultSettings("format_date")
                tankmanagerSettings.format_time = dbResultSettings("format_time")
                tankmanagerSettings.format_quantity = dbResultSettings("format_quantity")
                tankmanagerSettings.format_price_per_liter = dbResultSettings("format_price_per_liter")
                tankmanagerSettings.format_price = dbResultSettings("format_price")
                tankmanagerSettings.format_route = dbResultSettings("format_route")
                tankmanagerSettings.format_mileage = dbResultSettings("format_mileage")
                tankmanagerSettings.selectedYear = dbResultSettings("comboboxJahrAuswahlSelected")
                If dbResultSettings("tankenHideDoubleDateEntries") = True Then tankmanagerSettings.tankenHideDoubleDateEntries = True Else tankmanagerSettings.tankenHideDoubleDateEntries = False
                If dbResultSettings("reparaturHideDoubleDateEntries") = True Then tankmanagerSettings.reparaturHideDoubleDateEntries = True Else tankmanagerSettings.reparaturHideDoubleDateEntries = False
                If dbResultSettings("reparaturHideDoublePriceEntries") = True Then tankmanagerSettings.reparaturHideDoublePriceEntries = True Else tankmanagerSettings.reparaturHideDoublePriceEntries = False

            Else

                'wenn kein ergebnis einstellungsfehler auf wahr setzen
                settingsError = True

            End If

        End While

        'Einstellungensabfrage schließen
        dbResultSettings.Close()

        Return settingsError

    End Function

    Public Function LeseIni()

        If System.IO.File.Exists(iniFileName) Then

            tankmanagerConnection.serverName = tankmanagerIni.GetString("SQLSERVER", "Address", "")
            tankmanagerConnection.serverPort = tankmanagerIni.GetString("SQLSERVER", "Port", "")
            tankmanagerConnection.charset = tankmanagerIni.GetString("SQLSERVER", "Charset", "")
            tankmanagerConnection.userName = tankmanagerIni.GetString("USER", "Name", "")
            tankmanagerConnection.userPassWd = tankmanagerIni.GetString("USER", "Passwd", "")

        Else

            MessageBox.Show("Die Datei " & iniFileName & " existiert nicht.")

        End If

    End Function

End Module
