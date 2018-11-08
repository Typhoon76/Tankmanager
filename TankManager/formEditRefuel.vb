Public Class formEditRefuel

    Private Sub formEditRefuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'andere Felder auf 0 stellentextBoxNewRefuelPreis
        textBoxEditRefuelMenge.Text = 0
        textBoxEditRefuelSumme.Text = 0
        textBoxEditRefuelGefahreneStrecke.Text = 0
        textBoxEditRefuelTachostand.Text = 0
        textBoxEditRefuelPreis.Text = 0
        textBoxEditRefuelVerbrauch.Text = 0

        'format auf custom stellen
        datetimepickerEditRefuelDate.Format = DateTimePickerFormat.Custom
        datetimepickerEditRefuelTime.Format = DateTimePickerFormat.Custom

        'format aus einstellungen übernehmen
        datetimepickerEditRefuelDate.CustomFormat = tankmanagerSettings.format_date
        datetimepickerEditRefuelTime.CustomFormat = tankmanagerSettings.format_time

        'Daten in Objekte eintragen
        datetimepickerEditRefuelDate.Value = tankmanagerRefuel.refuel_date
        datetimepickerEditRefuelTime.Value = CDate("01.01.1900 " & tankmanagerRefuel.refuel_time)
        textBoxEditRefuelMenge.Text = tankmanagerRefuel.refuel_quantity
        textBoxEditRefuelSumme.Text = tankmanagerRefuel.refuel_price
        textBoxEditRefuelGefahreneStrecke.Text = tankmanagerRefuel.refuel_route
        textBoxEditRefuelTachostand.Text = tankmanagerRefuel.refuel_mileage

        'Preis pro Liter und Verbrauch berechnen

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxEditRefuelMenge.Text) = True And checkValidInput(textBoxEditRefuelGefahreneStrecke.Text) = True Then

            'wenn ja, Verbrauch und Summe berechnen
            berechneVerbrauch()

        Else

            'wenn nein, Textboxen für Verbrauch auf 0 setzen
            textBoxEditRefuelVerbrauch.Text = 0

        End If

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxEditRefuelSumme.Text) = True And checkValidInput(textBoxEditRefuelMenge.Text) = True Then

            'wenn ja, Summe berechnen
            berechnePreisProLiter()

        Else

            'wenn nein, Textboxen für Summe auf 0 setzen
            textBoxEditRefuelPreis.Text = 0

        End If

    End Sub

    Private Sub buttonEditRefuelCancel_Click(sender As Object, e As EventArgs) Handles buttonEditRefuelCancel.Click

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub textBoxEditRefuelMenge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxEditRefuelMenge.KeyPress

        If Not checkValidKey(e) = True Then textBoxEditRefuelVerbrauch.Text = 0

    End Sub

    Private Sub textBoxNditRefuelSumme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxEditRefuelSumme.KeyPress

        If Not checkValidKey(e) = True Then textBoxEditRefuelPreis.Text = 0

    End Sub

    Private Sub textBoxEditRefuelGefahreneStrecke_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxEditRefuelGefahreneStrecke.KeyPress

        If Not checkValidKey(e) = True Then textBoxEditRefuelPreis.Text = 0

    End Sub

    Private Sub textBoxEditRefuelTachostand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxEditRefuelTachostand.KeyPress

        checkValidNumber(e)

    End Sub

    Private Sub textBoxEditRefuelMenge_TextChanged(sender As Object, e As EventArgs) Handles textBoxEditRefuelMenge.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxEditRefuelMenge.Text) = True And checkValidInput(textBoxEditRefuelGefahreneStrecke.Text) = True And checkValidInput(textBoxEditRefuelSumme.Text) = True Then

            'wenn ja, Verbrauch und Summe berechnen
            berechneVerbrauch()
            berechnePreisProLiter()

        Else

            'wenn nein, Textboxen für Verbrauch und Summe auf 0 setzen
            textBoxEditRefuelVerbrauch.Text = 0
            textBoxEditRefuelPreis.Text = 0

        End If

    End Sub

    Private Sub textBoxNewRefuelGefahreneStrecke_TextChanged(sender As Object, e As EventArgs) Handles textBoxEditRefuelGefahreneStrecke.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxEditRefuelGefahreneStrecke.Text) = True And checkValidInput(textBoxEditRefuelMenge.Text) = True Then

            'wenn ja, Verbrauch berechnen
            berechneVerbrauch()

        Else

            'wenn nein, Textboxen für Verbrauch auf 0 setzen
            textBoxEditRefuelVerbrauch.Text = 0

        End If

    End Sub

    Private Sub textBoxNewRefuelSumme_TextChanged(sender As Object, e As EventArgs) Handles textBoxEditRefuelSumme.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxEditRefuelSumme.Text) = True And checkValidInput(textBoxEditRefuelMenge.Text) = True Then

            'wenn ja, Summe berechnen
            berechnePreisProLiter()

        Else

            'wenn nein, Textboxen für Summe auf 0 setzen
            textBoxEditRefuelPreis.Text = 0

        End If

    End Sub

    Private Sub berechneVerbrauch()

        'Funktion zum berechnen des Verbrauchs

        Dim MyRefuel As Single = textBoxEditRefuelMenge.Text
        Dim MyRoute As Single = textBoxEditRefuelGefahreneStrecke.Text

        textBoxEditRefuelVerbrauch.Text = Format(MyRefuel * 100 / MyRoute, "F" & tankmanagerSettings.format_quantity)

    End Sub

    Private Sub berechnePreisProLiter()

        'Funktion zum berechnen des Literpreise (Preis pro Liter) auf der Tankquittung

        Dim MyRefuel As Single = textBoxEditRefuelMenge.Text
        Dim MySumme As Single = textBoxEditRefuelSumme.Text

        textBoxEditRefuelPreis.Text = Format(MySumme / MyRefuel, "F" & tankmanagerSettings.format_price_per_liter)

    End Sub

    Private Sub buttonEditRefuelDelete_Click(sender As Object, e As EventArgs) Handles buttonEditRefuelDelete.Click

        'Abfrage ob Eintrag wirklich gelöscht werden soll
        Select Case MsgBox("Wollen Sie folgenden Eintrag wirklich löschen?" & vbNewLine & vbNewLine &
                "Datum" & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_date & vbNewLine &
                "Uhrzeit" & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_time & vbNewLine &
                "Getankt" & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_quantity & " Liter" & vbNewLine &
                "Bezahlt" & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_price & " EUR" & vbNewLine &
                "Gefahren" & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_route & " Kilometer" & vbNewLine &
                "Tachostand" & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_mileage & " Kilometer", vbQuestion Or vbYesNo Or vbDefaultButton2, "Eintrag löschen?")

            'wenn ja
            Case vbYes

                'Eintrag löschen
                If LoescheTankenEintrag(MySqlDeleteTankenEintrag(tankmanagerRefuel.refuel_id)) = True Then

                    'wenn ohne fehler, erfolgsmeldung und fenster schließen
                    MessageBox.Show("Eintrag wurde erfolgreich gelöscht")

                Else

                    'wenn fehler, fehler melden
                    MessageBox.Show("Eintrag konnte nicht gelöscht werden")

                End If

                'formMain neu aufbauen
                refreshFormMain()

                'Fenster schließen
                Me.Close()

            'wenn nein
            Case vbNo

                'nichts tun

        End Select

    End Sub

    Private Sub buttonEditRefuelSaveAndExit_Click(sender As Object, e As EventArgs) Handles buttonEditRefuelSaveAndExit.Click

        'prüfen ob alle Felder gültige Inhalte haben

        Dim myDateError As Boolean = False
        Dim myValueError As Boolean = False

        'Datum prüfen
        If checkValidDate(datetimepickerEditRefuelDate) = False Then

            'Datumsfehler auf wahr setzen
            myDateError = True

            'Datumsfeld mit Fehler auswählen
            datetimepickerEditRefuelDate.Select()

        ElseIf checkBlankOrNull(textBoxEditRefuelMenge) = False Then

            'Zahlenfehler auf wahr setzen
            myValueError = True

            'Textbox mit Fehler auswählen
            textBoxEditRefuelMenge.Select()

        ElseIf checkBlankOrNull(textBoxEditRefuelSumme) = False Then

            'Zahlenfehler auf wahr setzen
            myValueError = True

            'Textbox mit Fehler auswählen
            textBoxEditRefuelSumme.Select()

        ElseIf checkBlankOrNull(textBoxEditRefuelGefahreneStrecke) = False Then

            'Zahlenfehler auf wahr setzen
            myValueError = True

            'Textbox mit Fehler auswählen
            textBoxEditRefuelGefahreneStrecke.Select()

        ElseIf checkBlankOrNull(textBoxEditRefuelTachostand) = False Then

            'Zahlenfehler auf wahr setzen
            myValueError = True

            'Textbox mit Fehler auswählen
            textBoxEditRefuelTachostand.Select()

        End If

        'wenn Fehler, Fehlermeldungen anzeigen
        If myDateError = True Then

            'Datumsfehler anzeigen
            MessageBox.Show("Das gewählte Datum liegt in der Zukunft. Der Eintrag kann nicht gespeichert werden")

        ElseIf myValueError = True Then

            'Zahlenfehler anzeigen
            MessageBox.Show("Das Feld enthält einen ungültigen Wert. Der Eintrag kann nicht gespeichert werden")

        Else

            'wenn kein Fehler
            'Abfrage ob Eintrag wirklich gespeichert werden soll

            Select Case MsgBox("Wollen Sie folgenden Eintrag wirklich speichern?" & vbNewLine & vbNewLine &
                    "Datum" & vbTab & vbTab & ">" & vbTab & Format(datetimepickerEditRefuelDate.Value, tankmanagerSettings.format_date) & vbNewLine &
                    "Uhrzeit" & vbTab & vbTab & ">" & vbTab & Format(datetimepickerEditRefuelTime.Value, tankmanagerSettings.format_time) & vbNewLine &
                    "Getankt" & vbTab & vbTab & ">" & vbTab & textBoxEditRefuelMenge.Text & " Liter" & vbNewLine &
                    "Bezahlt" & vbTab & vbTab & ">" & vbTab & textBoxEditRefuelSumme.Text & " EUR" & vbNewLine &
                    "Gefahren" & vbTab & ">" & vbTab & textBoxEditRefuelGefahreneStrecke.Text & " Kilometer" & vbNewLine &
                    "Tachostand" & vbTab & ">" & vbTab & textBoxEditRefuelTachostand.Text & " Kilometer", vbQuestion Or vbYesNo Or vbDefaultButton2, "Eintrag speichern?")

                'wenn ja
                Case vbYes

                    'Eintrag updaten
                    If updateTankenEintrag(datetimepickerEditRefuelDate.Value,
                                        datetimepickerEditRefuelTime.Value,
                                        textBoxEditRefuelMenge.Text,
                                        textBoxEditRefuelSumme.Text,
                                        textBoxEditRefuelGefahreneStrecke.Text,
                                        textBoxEditRefuelTachostand.Text,
                                        tankmanagerRefuel.refuel_id) = False Then

                        'wenn ohne fehler, erfolgsmeldung und fenster schließen
                        MessageBox.Show("Eintrag wurde erfolgreich speichert.")

                    Else

                        'wenn fehler, fehler melden
                        MessageBox.Show("Eintrag konnte nicht speichert werden")

                    End If

                    'formMain neu aufbauen
                    refreshFormMain()

                    'Fenster schließen
                    Me.Close()

                'wenn nein
                Case vbNo

                    'nichts tun

            End Select

        End If
    End Sub

End Class