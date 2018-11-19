Public Class FormEditRefuel

    Private Sub FormEditRefuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'title
        Me.Text = TM_EDIT_REFUEL_TITLE

        'grouboxen
        FormEditRefuelGroupboxDateandTime.Text = TM_EDIT_REFUEL_GROUPBOX_DATE_AND_TIME
        FormEditRefuelGroupboxFuelled.Text = TM_STANDARD_FUELLED
        FormEditRefuelGroupboxSpeedometer.Text = TM_STANDARD_SPEEDOMETER
        FormEditRefuelGroupboxCosts.Text = TM_STANDARD_COSTS
        FormEditRefuelGroupboxConsumption.Text = TM_STANDARD_CONSUMPTION

        'label
        FormEditRefuelLabelDate.Text = TM_STANDARD_DATE
        FormEditRefuelLabelTime.Text = TM_STANDARD_TIME
        FormEditRefuelLabelQuantity.Text = TM_STANDARD_QUANTITY
        FormEditRefuelLabelQuantityLitre.Text = TM_STANDARD_LITRE
        FormEditRefuelLabelTotal.Text = TM_STANDARD_TOTAL
        FormEditRefuelLabelTotalCurrency.Text = TM_STANDARD_CURRENCY
        FormEditRefuelLabelCosts.Text = TM_STANDARD_COSTS_PER_LITER
        FormEditRefuelLabelCostsCurrency.Text = TM_STANDARD_CURRENCY
        FormEditRefuelLabelDriven.Text = TM_STANDARD_DRIVEN
        FormEditRefuelLabelDrivenKm.Text = TM_STANDARD_TOTAL_SHORT
        FormEditRefuelLabelMileage.Text = TM_STANDARD_MILAGE
        FormEditRefuelLabelMileageKm.Text = TM_STANDARD_TOTAL_SHORT
        FormEditRefuelLabelConsumption.Text = TM_STANDARD_PER_100KM
        FormEditRefuelLabelConsumptionLitre.Text = TM_STANDARD_LITRE

        'button
        buttonEditRefuelCancel.Text = TM_STANDARD_BUTTON_CANCEL
        buttonEditRefuelDelete.Text = TM_STANDARD_BUTTON_DELETE_ENTRY
        buttonEditRefuelSaveAndExit.Text = TM_STANDARD_BUTTON_SAVE_AND_EXIT

        'Felder auf 0 stellentextBoxNewRefuelPreis
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
        Select Case MsgBox(TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY & vbNewLine & vbNewLine &
                TM_STANDARD_DATE & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_date & vbNewLine &
                TM_STANDARD_TIME & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_time & vbNewLine &
                TM_STANDARD_FUELLED & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_quantity & " " & TM_STANDARD_LITRE & vbNewLine &
                TM_STANDARD_PAID & vbTab & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_price & " " & TM_STANDARD_CURRENCY & vbNewLine &
                TM_STANDARD_DRIVEN & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_route & " " & TM_STANDARD_KILOMETER & vbNewLine &
                TM_STANDARD_MILAGE & vbTab & ">" & vbTab & tankmanagerRefuel.refuel_mileage & " " & TM_STANDARD_KILOMETER, vbQuestion Or vbYesNo Or vbDefaultButton2, TM_STANDARD_QUESTION_DELETE_ENTRY)

            'wenn ja
            Case vbYes

                'Eintrag löschen
                If LoescheTankenEintrag(MySqlDeleteTankenEintrag(tankmanagerRefuel.refuel_id)) = True Then

                    'wenn ohne fehler, erfolgsmeldung und fenster schließen
                    MessageBox.Show(TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY_SUCCESS)

                Else

                    'wenn fehler, fehler melden
                    MessageBox.Show(TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY_ERROR)

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
            MessageBox.Show(TM_EDIT_REFUEL_ENTRY_COULD_NOT_SAVED_SELECTED_DATE_IS_IN_FUTURE)

        ElseIf myValueError = True Then

            'Zahlenfehler anzeigen
            MessageBox.Show(TM_EDIT_REFUEL_ENTRY_COULD_NOT_SAVED_FIELD_HAS_INVALID_VALUE)

        Else

            'wenn kein Fehler
            'Abfrage ob Eintrag wirklich gespeichert werden soll

            Select Case MsgBox(TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY & vbNewLine & vbNewLine &
                    TM_STANDARD_DATE & vbTab & vbTab & ">" & vbTab & Format(datetimepickerEditRefuelDate.Value, tankmanagerSettings.format_date) & vbNewLine &
                    TM_STANDARD_TIME & vbTab & vbTab & ">" & vbTab & Format(datetimepickerEditRefuelTime.Value, tankmanagerSettings.format_time) & vbNewLine &
                    TM_STANDARD_FUELLED & vbTab & vbTab & ">" & vbTab & textBoxEditRefuelMenge.Text & " " & TM_STANDARD_LITRE & vbNewLine &
                    TM_STANDARD_PAID & vbTab & vbTab & ">" & vbTab & textBoxEditRefuelSumme.Text & " " & TM_STANDARD_CURRENCY & vbNewLine &
                    TM_STANDARD_DRIVEN & vbTab & ">" & vbTab & textBoxEditRefuelGefahreneStrecke.Text & " " & TM_STANDARD_KILOMETER & vbNewLine &
                    TM_STANDARD_MILAGE & vbTab & ">" & vbTab & textBoxEditRefuelTachostand.Text & " " & TM_STANDARD_KILOMETER, vbQuestion Or vbYesNo Or vbDefaultButton2, TM_STANDARD_QUESTION_SAVE_ENTRY)


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
                        MessageBox.Show(TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY_SUCCESS)

                    Else

                        'wenn fehler, fehler melden
                        MessageBox.Show(TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY_ERROR)

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