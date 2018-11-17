Imports MySql.Data.MySqlClient

Public Class FormSettings

    Private Sub formSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If connectState = True Then

            Try

                '### füllen der ComboBox "comboboxSettingsJahresauswahl"
                Dim dbQueryYears As New MySqlCommand(MySqlSelectComboboxJahre(), con)
                Dim dbResultYears As MySqlDataReader

                'weitere Daten abfragen
                dbResultYears = dbQueryYears.ExecuteReader

                'ersten Eintrag einfügen
                comboboxSettingsJahresauswahl.Items.Add(comboboxJahrAuswahlErsterEintrag)

                'Daten einlesen
                While (dbResultYears.Read())

                    'wenn die Daten eine Zeile haben dann
                    If dbResultYears.HasRows = True Then

                        'Inhalt der Spalte Jahre in Combobox eintragen
                        comboboxSettingsJahresauswahl.Items.Add(dbResultYears("ComboboxJahre"))

                    End If

                End While

                'Datenabfrage schließen
                dbResultYears.Close()

            Catch myerror As MySql.Data.MySqlClient.MySqlException

                'Fehler abfangen

                'fehler meldung und fehlercode anzeigen
                MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

            '### Tab Allgemein

            'combobox auf wert aus db setzen
            If tankmanagerSettings.selectedYear = comboboxJahrAuswahlErsterEintrag Then
                comboboxSettingsJahresauswahl.SelectedItem = comboboxJahrAuswahlErsterEintrag
            Else
                comboboxSettingsJahresauswahl.SelectedItem = tankmanagerSettings.selectedYear
            End If

            '### tab Autodaten
            datetimepickerSettingsBaujahr.CustomFormat = tankmanagerSettings.format_date
            datetimepickerSettingsBaujahr.Format = DateTimePickerFormat.Custom
            datetimepickerSettingsBaujahr.Value = tankmanagerSettings.date_of_construction

            '### Tab Anzeige
            checboxSettingsTankenHideDoubleDateEntries.Checked = tankmanagerSettings.tankenHideDoubleDateEntries
            checboxSettingsReparaturHideDoubleDateEntries.Checked = tankmanagerSettings.reparaturHideDoubleDateEntries
            checboxSettingsReparaturHideDoublePriceEntries.Checked = tankmanagerSettings.reparaturHideDoublePriceEntries

            '### Tab Formate
            textboxSettingsFormatDate.Text = tankmanagerSettings.format_date
            textboxSettingsFormatTime.Text = tankmanagerSettings.format_time
            textboxSettingsFormatQuantity.Text = tankmanagerSettings.format_quantity
            textboxSettingsFormatPrice.Text = tankmanagerSettings.format_price
            textboxSettingsFormatPricePerLiter.Text = tankmanagerSettings.format_price_per_liter
            textboxSettingsFormatRoute.Text = tankmanagerSettings.format_route
            textboxSettingsFormatMileage.Text = tankmanagerSettings.format_mileage

        Else

            tabControlGeneral.Enabled = False
            tabControlAuto.Enabled = False
            tabControlView.Enabled = False
            tabControlFormat.Enabled = False

        End If

        If System.IO.File.Exists(iniFileName) Then

            '### Tab Server
            textboxSettingsVerbindungServeradresse.Text = tankmanagerConnection.serverName
            textboxSettingsVerbindungServerport.Text = tankmanagerConnection.serverPort
            textboxSettingsVerbindungZeichencodierung.Text = tankmanagerConnection.charset

            '### Tab Zugangsdaten
            textboxSettingsVerbindungUsername.Text = tankmanagerConnection.userName
            textboxSettingsVerbindungUserpasswort.Text = tankmanagerConnection.userPassWd

        End If

    End Sub

    Private Sub buttonSettingsAbbrechen_Click(sender As Object, e As EventArgs) Handles buttonSettingsAbbrechen.Click

        Me.Close()

    End Sub

    Private Sub buttonSettingsSpeichernUndSchliessen_Click(sender As Object, e As EventArgs) Handles buttonSettingsSpeichernUndSchliessen.Click

        '### Tab Allgemein
        If comboboxSettingsJahresauswahl.SelectedItem = comboboxJahrAuswahlErsterEintrag Then
            tankmanagerSettings.selectedYear = comboboxJahrAuswahlErsterEintrag
        Else
            tankmanagerSettings.selectedYear = comboboxSettingsJahresauswahl.SelectedItem
        End If

        tankmanagerSettings.selectedYear = comboboxSettingsJahresauswahl.SelectedItem

        '### tab Autodaten
        tankmanagerSettings.date_of_construction = datetimepickerSettingsBaujahr.Value

        '### Tab Anzeige
        tankmanagerSettings.tankenHideDoubleDateEntries = checboxSettingsTankenHideDoubleDateEntries.Checked
        tankmanagerSettings.reparaturHideDoubleDateEntries = checboxSettingsReparaturHideDoubleDateEntries.Checked
        tankmanagerSettings.reparaturHideDoublePriceEntries = checboxSettingsReparaturHideDoublePriceEntries.Checked

        '### Tab Formate
        tankmanagerSettings.format_date = textboxSettingsFormatDate.Text
        tankmanagerSettings.format_time = textboxSettingsFormatTime.Text
        tankmanagerSettings.format_quantity = textboxSettingsFormatQuantity.Text
        tankmanagerSettings.format_price = textboxSettingsFormatPrice.Text
        tankmanagerSettings.format_price_per_liter = textboxSettingsFormatPricePerLiter.Text
        tankmanagerSettings.format_route = textboxSettingsFormatRoute.Text
        tankmanagerSettings.format_mileage = textboxSettingsFormatMileage.Text

        '### Tab Server
        tankmanagerConnection.serverName = textboxSettingsVerbindungServeradresse.Text
        tankmanagerConnection.serverPort = textboxSettingsVerbindungServerport.Text
        tankmanagerConnection.charset = textboxSettingsVerbindungZeichencodierung.Text

        '### Tab Zugangsdaten
        tankmanagerConnection.userName = textboxSettingsVerbindungUsername.Text
        tankmanagerConnection.userPassWd = textboxSettingsVerbindungUserpasswort.Text

        saveSettingsToIniFile()

        If connectState = True Then

            saveSettigsToDB()

            refreshFormMain()

        End If

        Me.Close()

        'Einstellungen in Ini Datei speichern
        saveSettingsToIniFile()

        If connectState = True Then

            'Einstellungen in Datenbank speichern
            saveSettigsToDB()

            'formMain neu aufbauen
            refreshFormMain()

            'formMain auf aktuelle Jahresansicht setzen
            formMain.ComboboxJahrAuswahl.SelectedItem = comboboxSettingsJahresauswahl.SelectedItem.ToString()

        End If

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub textboxSettingsVerbindungServerport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textboxSettingsVerbindungServerport.KeyPress

        Select Case Asc(e.KeyChar)

            Case 48 To 57, 8
                ' Zahlen und Backspace zulassen

            Case Else

                ' alle anderen Eingaben unterdrücken
                e.Handled = True

                MessageBox.Show("Bei der Portnummer sind nur Zahlen erlaubt.")

        End Select

    End Sub

    Private Sub buttonSettingsEinstellungenStandard_Click(sender As Object, e As EventArgs) Handles buttonSettingsEinstellungenStandard.Click

        'prüfen ob Einstellungen wirklich zurückgesetzt werden sollen
        If MessageBox.Show("Einstellungen auf Standard zurücksetzen", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            'wenn Ja, dann

            'Einstellungen in formSettings zurücksetzen
            comboboxSettingsJahresauswahl.SelectedItem = comboboxSettingsDefaultJahresauswahl
            datetimepickerSettingsBaujahr.Value = datetimepickerSettingsDefaultBaujahr
            checboxSettingsTankenHideDoubleDateEntries.Checked = checboxSettingsDefaultTankenHideDoubleDateEntries
            checboxSettingsReparaturHideDoubleDateEntries.Checked = checboxSettingsDefaultReparaturHideDoubleDateEntries
            checboxSettingsReparaturHideDoublePriceEntries.Checked = checboxSettingsDefaultReparaturHideDoublePriceEntries
            textboxSettingsFormatDate.Text = textboxSettingsDefaultFormatDate
            textboxSettingsFormatTime.Text = textboxSettingsDefaultFormatTime
            textboxSettingsFormatQuantity.Text = textboxSettingsDefaultFormatQuantity
            textboxSettingsFormatPrice.Text = textboxSettingsDefaultFormatPrice
            textboxSettingsFormatPricePerLiter.Text = textboxSettingsDefaultFormatPricePerLiter
            textboxSettingsFormatRoute.Text = textboxSettingsDefaultFormatRoute
            textboxSettingsFormatMileage.Text = textboxSettingsDefaultFormatMileage
            textboxSettingsVerbindungServeradresse.Text = textboxSettingsDefaultVerbindungServeradresse
            textboxSettingsVerbindungServerport.Text = textboxSettingsDefaultVerbindungServerport
            textboxSettingsVerbindungZeichencodierung.Text = textboxSettingsDefaultVerbindungZeichencodierung
            textboxSettingsVerbindungUsername.Text = textboxSettingsDefaultVerbindungUsername
            textboxSettingsVerbindungUserpasswort.Text = textboxSettingsDefaultVerbindungUserpasswort

            'Einstellungen in classSettings zurücksetzen
            tankmanagerSettings.date_of_construction = datetimepickerSettingsDefaultBaujahr
            tankmanagerSettings.format_date = textboxSettingsDefaultFormatDate
            tankmanagerSettings.format_time = textboxSettingsDefaultFormatTime
            tankmanagerSettings.format_quantity = textboxSettingsDefaultFormatQuantity
            tankmanagerSettings.format_price = textboxSettingsDefaultFormatPrice
            tankmanagerSettings.format_price_per_liter = textboxSettingsDefaultFormatPricePerLiter
            tankmanagerSettings.format_route = textboxSettingsDefaultFormatRoute
            tankmanagerSettings.format_mileage = textboxSettingsDefaultFormatMileage
            tankmanagerSettings.selectedYear = comboboxSettingsDefaultJahresauswahl
            tankmanagerSettings.tankenHideDoubleDateEntries = checboxSettingsDefaultTankenHideDoubleDateEntries
            tankmanagerSettings.reparaturHideDoubleDateEntries = checboxSettingsDefaultReparaturHideDoubleDateEntries
            tankmanagerSettings.reparaturHideDoublePriceEntries = checboxSettingsDefaultReparaturHideDoublePriceEntries

        End If

    End Sub

End Class
