Public Class formNewRefuel

    Private Sub formNewRefuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resetForm()

    End Sub

    Private Sub buttonNewRefuelCancel_Click(sender As Object, e As EventArgs) Handles buttonNewRefuelCancel.Click

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub buttonNewRefuelReset_Click(sender As Object, e As EventArgs) Handles buttonNewRefuelReset.Click

        resetForm()

    End Sub

    Private Sub buttonNewRefuelSaveAndNew_Click(sender As Object, e As EventArgs) Handles buttonNewRefuelSaveAndNew.Click

        If checkValidDate(datetimepickerNewRefuelDate) = True And
            checkValidInput(textBoxNewRefuelMenge.Text) = True And
            checkValidInput(textBoxNewRefuelSumme.Text) = True And
            checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = True And
            checkValidInput(textBoxNewRefuelTachostand.Text) = True And
            checkBlankOrNull(textBoxNewRefuelMenge) = True And
            checkBlankOrNull(textBoxNewRefuelSumme) = True And
            checkBlankOrNull(textBoxNewRefuelGefahreneStrecke) = True And
            checkBlankOrNull(textBoxNewRefuelTachostand) = True Then

            Try

                schreibeTanken(Format(datetimepickerNewRefuelDate.Value, tankmanagerSettings.format_date), Format(datetimepickerNewRefuelTime.Value, tankmanagerSettings.format_time), textBoxNewRefuelMenge.Text, textBoxNewRefuelSumme.Text, textBoxNewRefuelGefahreneStrecke.Text, textBoxNewRefuelTachostand.Text)

            Catch myerror As MySql.Data.MySqlClient.MySqlException

                'Fehler abfangen

                'fehler meldung und fehlercode anzeigen
                MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

            'Fenster resetten
            resetForm()

            'formMain neu aufbauen
            refreshFormMain()

            'Fenster wieder in Vordergrund holen
            Me.Activate()

        Else

            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & "Nicht alle Angaben enthalten gültige Werte.", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Datumsfeld mit Fehler auswählen
            If checkValidDate(datetimepickerNewRefuelDate) = False Then datetimepickerNewRefuelDate.Select()

            'Textbox mit Fehler auswählen
            If checkValidInput(textBoxNewRefuelMenge.Text) = False Or checkBlankOrNull(textBoxNewRefuelMenge) = False Then
                textBoxNewRefuelMenge.Select()
            ElseIf checkValidInput(textBoxNewRefuelSumme.Text) = False Or checkBlankOrNull(textBoxNewRefuelSumme) = False Then
                textBoxNewRefuelSumme.Select()
            ElseIf checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = False Or checkBlankOrNull(textBoxNewRefuelGefahreneStrecke) = False Then
                textBoxNewRefuelGefahreneStrecke.Select()
            ElseIf checkValidInput(textBoxNewRefuelTachostand.Text) = False Or checkBlankOrNull(textBoxNewRefuelTachostand) = False Then
                textBoxNewRefuelTachostand.Select()
            End If

        End If

    End Sub

    Private Sub buttonNewRefuelSaveAndExit_Click(sender As Object, e As EventArgs) Handles buttonNewRefuelSaveAndExit.Click

        If checkValidDate(datetimepickerNewRefuelDate) = True And
            checkValidInput(textBoxNewRefuelMenge.Text) = True And
            checkValidInput(textBoxNewRefuelSumme.Text) = True And
            checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = True And
            checkValidInput(textBoxNewRefuelTachostand.Text) = True And
            checkBlankOrNull(textBoxNewRefuelMenge) = True And
            checkBlankOrNull(textBoxNewRefuelSumme) = True And
            checkBlankOrNull(textBoxNewRefuelGefahreneStrecke) = True And
            checkBlankOrNull(textBoxNewRefuelTachostand) = True Then

            Try

                schreibeTanken(Format(datetimepickerNewRefuelDate.Value, tankmanagerSettings.format_date), Format(datetimepickerNewRefuelTime.Value, tankmanagerSettings.format_time), textBoxNewRefuelMenge.Text, textBoxNewRefuelSumme.Text, textBoxNewRefuelGefahreneStrecke.Text, textBoxNewRefuelTachostand.Text)

            Catch myerror As MySql.Data.MySqlClient.MySqlException

                'Fehler abfangen

                'fehler meldung und fehlercode anzeigen
                MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

            'formMain neu aufbauen
            refreshFormMain()

            'Fenster schließen
            Me.Close()

        Else

            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & "Nicht alle Angaben enthalten gültige Werte.", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Datumsfeld mit Fehler auswählen
            If checkValidDate(datetimepickerNewRefuelDate) = False Then datetimepickerNewRefuelDate.Select()

            'Textbox mit Fehler auswählen
            If checkValidInput(textBoxNewRefuelMenge.Text) = False Or checkBlankOrNull(textBoxNewRefuelMenge) = False Then
                textBoxNewRefuelMenge.Select()
            ElseIf checkValidInput(textBoxNewRefuelSumme.Text) = False Or checkBlankOrNull(textBoxNewRefuelSumme) = False Then
                textBoxNewRefuelSumme.Select()
            ElseIf checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = False Or checkBlankOrNull(textBoxNewRefuelGefahreneStrecke) = False Then
                textBoxNewRefuelGefahreneStrecke.Select()
            ElseIf checkValidInput(textBoxNewRefuelTachostand.Text) = False Or checkBlankOrNull(textBoxNewRefuelTachostand) = False Then
                textBoxNewRefuelTachostand.Select()
            End If

        End If

    End Sub

    Private Sub textBoxNewRefuelMenge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxNewRefuelMenge.KeyPress

        If Not checkValidKey(e) = True Then textBoxNewRefuelVerbrauch.Text = 0

    End Sub

    Private Sub textBoxNewRefuelSumme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxNewRefuelSumme.KeyPress

        If Not checkValidKey(e) = True Then textBoxNewRefuelPreis.Text = 0

    End Sub

    Private Sub textBoxNewRefuelGefahreneStrecke_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxNewRefuelGefahreneStrecke.KeyPress

        If Not checkValidKey(e) = True Then textBoxNewRefuelPreis.Text = 0

    End Sub

    Private Sub textBoxNewRefuelTachostand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxNewRefuelTachostand.KeyPress

        checkValidNumber(e)

    End Sub

    Private Sub textBoxNewRefuelMenge_TextChanged(sender As Object, e As EventArgs) Handles textBoxNewRefuelMenge.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxNewRefuelMenge.Text) = True And checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = True And checkValidInput(textBoxNewRefuelSumme.Text) = True Then

            'wenn ja, Verbrauch und Summe berechnen
            berechneVerbrauch()
            berechnePreisProLiter()

        Else

            'wenn nein, Textboxen für Verbrauch und Summe auf 0 setzen
            textBoxNewRefuelVerbrauch.Text = 0
            textBoxNewRefuelPreis.Text = 0

        End If

    End Sub

    Private Sub textBoxNewRefuelGefahreneStrecke_TextChanged(sender As Object, e As EventArgs) Handles textBoxNewRefuelGefahreneStrecke.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxNewRefuelGefahreneStrecke.Text) = True And checkValidInput(textBoxNewRefuelMenge.Text) = True Then

            'wenn ja, Verbrauch berechnen
            berechneVerbrauch()

        Else

            'wenn nein, Textboxen für Verbrauch auf 0 setzen
            textBoxNewRefuelVerbrauch.Text = 0

        End If

    End Sub

    Private Sub textBoxNewRefuelSumme_TextChanged(sender As Object, e As EventArgs) Handles textBoxNewRefuelSumme.TextChanged

        'prüfen ob in beiden Textboxen gültige Werte stehen
        If checkValidInput(textBoxNewRefuelSumme.Text) = True And checkValidInput(textBoxNewRefuelMenge.Text) = True Then

            'wenn ja, Summe berechnen
            berechnePreisProLiter()

        Else

            'wenn nein, Textboxen für Summe auf 0 setzen
            textBoxNewRefuelPreis.Text = 0

        End If

    End Sub

    Private Sub berechneVerbrauch()

        'Funktion zum berechnen des Verbrauchs

        Dim MyRefuel As Single = textBoxNewRefuelMenge.Text
        Dim MyRoute As Single = textBoxNewRefuelGefahreneStrecke.Text

        textBoxNewRefuelVerbrauch.Text = Format(MyRefuel * 100 / MyRoute, "F" & tankmanagerSettings.format_quantity)

    End Sub

    Private Sub berechnePreisProLiter()

        'Funktion zum berechnen des Literpreise (Preis pro Liter) auf der Tankquittung

        Dim MyRefuel As Single = textBoxNewRefuelMenge.Text
        Dim MySumme As Single = textBoxNewRefuelSumme.Text

        textBoxNewRefuelPreis.Text = Format(MySumme / MyRefuel, "F" & tankmanagerSettings.format_price_per_liter)

    End Sub

    Private Sub resetForm()

        'format auf custom stellen
        datetimepickerNewRefuelDate.Format = DateTimePickerFormat.Custom
        datetimepickerNewRefuelTime.Format = DateTimePickerFormat.Custom

        'format aus einstellugen übernehmen
        datetimepickerNewRefuelDate.CustomFormat = tankmanagerSettings.format_date
        datetimepickerNewRefuelTime.CustomFormat = tankmanagerSettings.format_time

        'aktuelles Datum einfügen
        datetimepickerNewRefuelDate.Value = Now

        'aktuelle Zeit einfügen
        datetimepickerNewRefuelTime.Value = Now

        'andere Felder auf 0 stellentextBoxNewRefuelPreis
        textBoxNewRefuelMenge.Text = 0
        textBoxNewRefuelSumme.Text = 0
        textBoxNewRefuelGefahreneStrecke.Text = 0
        textBoxNewRefuelTachostand.Text = 0
        textBoxNewRefuelPreis.Text = 0
        textBoxNewRefuelVerbrauch.Text = 0

        'Tab auf Datumsauswahl setzen
        datetimepickerNewRefuelDate.Select()

    End Sub

End Class