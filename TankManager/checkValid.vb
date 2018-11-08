Module checkValid

    Public Function checkValidKey(e)

        'Funktion zum prüfen ob innerhalb einer Textbox für Kommawerte gültige Tasten gedrückt werden
        Select Case Asc(e.KeyChar)

            ', Komma
            Case 44

                Return True

            '0 - 9 Zahlen
            Case 48 To 57

                Return True

            'Backspace zum Löschen
            Case 8

                Return True

            Case Else

                'alle anderen Eingaben unterdrücken
                e.Handled = True

                'MessageBox.Show("Es sind nur Zahlen und Komma erlaubt.")

                Return False

        End Select

    End Function

    Public Function checkValidNumber(e)

        'Funktion zum prüfen ob innerhalb einer Textbox für Zahlen gültige Tasten gedrückt werden
        Select Case Asc(e.KeyChar)

            '0 - 9 Zahlen
            Case 48 To 57

                Return True

            'Backspace zum Löschen
            Case 8

                Return True

            Case Else

                'alle anderen Eingaben unterdrücken
                e.Handled = True

                'MessageBox.Show("Es sind nur Zahlen erlaubt.")

                Return False

        End Select

    End Function

    Public Function checkValidInput(MyValue)

        'Funktion zum prüfen ob in die Textboxen gültige Werte für Kommazahlen eingegeben wurden

        Dim MyTest As Single = 0

        If MyValue = "" Then Return False
        If MyValue = "0" Then Return False
        If MyValue = "0,0" Then Return False
        If MyValue Is Nothing Then Return False
        If Not Single.TryParse(MyValue, MyTest) Then Return False

        Return True

    End Function

    Public Function checkBlankOrNull(MyObject)

        Dim MyTest As Single = 0

        If MyObject.Text = "" Then Return False
        If MyObject.TextLength = 0 Then Return False
        If MyObject.Text = "0" Then Return False
        If MyObject.Text = "0," Then Return False
        If MyObject.Text = "0,0" Then Return False
        If MyObject.Text = "0,00" Then Return False
        If MyObject.Text = "," Then Return False
        If MyObject.Text = ",0" Then Return False
        If MyObject.Text = ",00" Then Return False
        If Not Single.TryParse(MyObject.Text, MyTest) Then Return False
        If Not CSng(MyObject.Text) > 0 Then Return False

        Return True

    End Function

    Public Function checkValidDate(MyObject)

        'prüft ob Datum des Objektes in der Zukunft liegt
        If MyObject.Value > Now Then Return False Else Return True

    End Function

End Module
