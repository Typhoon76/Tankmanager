Public Class formEditRepair

    Private Sub formEditRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'form initialisieren
        resetForm()

        'form füllen
        fillForm()

    End Sub

    Private Function fillForm()

        Dim myRepairDateState As Boolean = False
        Dim myRepairCostsState As Boolean = False

        'Daten in Objekte eintragen
        For Each Entry In tankmanagerRepair.Entry

            If myRepairDateState = False Then
                dateTimePickerEditRepair.Value = Entry.repair_date
                myRepairDateState = True
            End If

            If Entry.repair_number > 0 Then listviewEditRepair.Items.Add(Entry.repair_number).SubItems.Add(Entry.repair_step)

            If myRepairCostsState = False Then
                textboxEditRepairCosts.Text = Entry.repair_price
                myRepairCostsState = True
            End If

        Next

    End Function

    'Buttons
    Private Sub buttonEditRepairCancel_Click(sender As Object, e As EventArgs) Handles buttonEditRepairCancel.Click

        'Fenster Schließen
        Me.Close()

    End Sub

    Private Sub buttonEditRepairDelete_Click(sender As Object, e As EventArgs) Handles buttonEditRepairDelete.Click

        If LoescheReparaturEintrag() = True Then

            'formMain neu aufbauen
            refreshFormMain()

            'Fenster schließen
            Me.Close()

        Else

            MessageBox.Show("Reparatur konnte nicht gelöscht werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub buttonEditRepairReset_Click(sender As Object, e As EventArgs) Handles buttonEditRepairReset.Click

        'form initialisieren
        resetForm()

        'form füllen
        fillForm()

    End Sub

    Private Sub buttonEditRepairSaveAndExit_Click(sender As Object, e As EventArgs) Handles buttonEditRepairSaveAndExit.Click

        If checkForError() = False Then

            'If updateReparaturEintrag(dateTimePickerEditRepair.Value, textboxEditRepairCosts.Text) = True Then
            If updateReparaturEintrag() = True Then

                'formMain neu aufbauen
                refreshFormMain()

                'Fenster schließen
                Me.Close()

            Else

                MessageBox.Show("Reparatur konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    'Listview
    Private Sub listviewEditRepair_DoubleClick(sender As Object, e As EventArgs) Handles listviewEditRepair.DoubleClick

        'gewählten Eintrag ändern
        editSelectedItem()

    End Sub

    Private Sub editSelectedItem()

        'wenn Anzahl gewählter Einträge größer 0
        If listviewEditRepair.SelectedItems.Count > 0 Then

            'Text des alten Eintrages ermitteln
            Dim myOldItemText As String = listviewEditRepair.SelectedItems(0).SubItems(1).Text

            'Text des geänderten Eintrages abfragen
            Dim myNewItemText = InputBox(TM_REPAIR_LV_REPAIR_CHANGE_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_CHANGE_POSITION_TITLE_TEXT, listviewEditRepair.SelectedItems(0).SubItems(1).Text)

            'Text des geänderten Eintrages mit dem Text des alten Eintrages und einem leeren Text vergleichen
            If Not myNewItemText = myOldItemText And Not myNewItemText = "" Then

                'Text des gewählten Eintrages ändern
                listviewEditRepair.SelectedItems(0).SubItems(1).Text = myNewItemText

            End If

        End If

    End Sub

    'Listview Buttons
    Private Sub buttonEditRepairLVDown_Click(sender As Object, e As EventArgs) Handles buttonEditRepairLVDown.Click

        'Variable für Index definieren
        Dim newIndex As Integer = 0

        'für jeden Eintrag
        For currentIndex As Integer = listviewEditRepair.Items.Count - 1 To 0 Step -1

            'Variable für gewählten Eintrag definieren
            Dim li As ListViewItem = listviewEditRepair.Items(currentIndex)

            'prüfen ob ausgewählt
            If li.Selected = True Then

                'wenn ja, gewählten Eintrag einen Platz nach unten verschieben
                moveListViewItemDown(listviewEditRepair, li.Index)

                'dem Index den Wert den Indexes des gewählten Eintrages zuweisen
                newIndex = li.Index

                'Einträge neu nummerieren
                renumerateLV()

                'ursprünglich gewählten Eintrag erneut auswählen
                listviewEditRepair.Items(newIndex).Selected = True
                listviewEditRepair.Select()

            End If

        Next

    End Sub

    Private Sub buttonEditRepairLVUp_Click(sender As Object, e As EventArgs) Handles buttonEditRepairLVUp.Click

        'Variable für Index definieren
        Dim newIndex As Integer = 0

        'für jeden Eintrag
        For Each li As ListViewItem In listviewEditRepair.Items

            'prüfen ob ausgewählt
            If li.Selected = True Then

                'wenn ja, gewählten Eintrag einen Platz nach oben verschieben
                moveListViewItemUp(listviewEditRepair, li.Index)

                'dem Index den Wert den Indexes des gewählten Eintrages zuweisen
                newIndex = li.Index

                'Einträge neu nummerieren
                renumerateLV()

                'ursprünglich gewählten Eintrag erneut auswählen
                listviewEditRepair.Items(newIndex).Selected = True
                listviewEditRepair.Select()

            End If

        Next

    End Sub

    Private Sub buttonEditRepairLVDelete_Click(sender As Object, e As EventArgs) Handles buttonEditRepairLVDelete.Click

        'wenn Anzahl gewählter Einträge größer 0
        If listviewEditRepair.SelectedItems.Count > 0 Then

            'gewählten Eintrag löschen
            listviewEditRepair.Items.RemoveAt(listviewEditRepair.SelectedIndices(0))

            'verbleibende Einträge neu nummerieren
            renumerateLV()

        End If

    End Sub

    'Einträge neu nummerieren
    Private Sub renumerateLV()

        'Variable für neuen Indexzähler anlegen
        Dim newIndex As Integer = 1

        'für jeden Eintrag
        For Each item As ListViewItem In listviewEditRepair.Items

            'den neuen Indexzähler zuweisen
            item.Text = newIndex

            'den Indexzähler um eins erhöhen
            newIndex = newIndex + 1

        Next

    End Sub

    'aus dem Internet
    Private Sub moveListViewItemUp(ByVal _ListView As ListView, ByVal selectedIndex As Integer)
        Try
            If Not _ListView.Items(selectedIndex).Index = 0 Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer
                oldIndex = _ListView.Items(selectedIndex).Index
                toMove = _ListView.Items(selectedIndex)
                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex - 1, toMove)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub moveListViewItemDown(ByVal _ListView As ListView, ByVal selectedIndex As Integer)
        Try
            If Not _ListView.Items(selectedIndex).Index + 1 = _ListView.Items.Count Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer
                oldIndex = _ListView.Items(selectedIndex).Index
                toMove = _ListView.Items(selectedIndex)
                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex + 1, toMove)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub buttonEditRepairLVEdit_Click(sender As Object, e As EventArgs) Handles buttonEditRepairLVEdit.Click

        'gewählten Eintrag ändern
        editSelectedItem()

    End Sub

    Private Sub buttonEditRepairLVAdd_Click(sender As Object, e As EventArgs) Handles buttonEditRepairLVAdd.Click

        'Anzahl bisheriger Einträge ermitteln
        Dim myItems = listviewEditRepair.Items.Count

        'Text des neunen Eintrages abfragen
        Dim myText = InputBox(TM_REPAIR_LV_REPAIR_NEW_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_TITLE_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT)

        'Text des neunen Eintrages mit dem Standardtext und einem leeren Text vergleichen
        If Not myText = TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT And Not myText = "" Then

            'neuen Eintrag mit eingegebenen Text einfügen
            listviewEditRepair.Items.Add(myItems + 1).SubItems.Add(myText)

        End If

    End Sub

    Private Function checkForError()

        'Variablen definieren
        Dim formError As Boolean = False
        Dim customErrorString As String = ""

        'Datumsfeld mit Fehler auswählen
        If checkValidDate(dateTimePickerEditRepair) = False Then
            dateTimePickerEditRepair.Select()
            customErrorString = "Das Datum liegt in der Zukunft."
            formError = True
        End If

        'Listview mit Fehler auswählen
        If listviewEditRepair.Items.Count = 0 Then
            listviewEditRepair.Select()
            customErrorString = "Die Reparaturliste enthält keine Einträge."
            formError = True
        End If

        'Textbox mit Fehler auswählen
        If checkValidInput(textboxEditRepairCosts.Text) = False Or checkBlankOrNull(textboxEditRepairCosts) = False Then
            textboxEditRepairCosts.Select()
            customErrorString = "Es wurde kein gültiger Reparaturpreis eingegeben."
            formError = True
        End If

        'wenn Fehler dann Meldung ausgeben
        If formError = True Then MessageBox.Show("Es ist ein Fehler aufgetreten" & vbNewLine & vbNewLine & customErrorString, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return formError

    End Function
    Private Sub resetForm()

        'Listview leeren
        listviewEditRepair.Clear()

        'format auf custom stellen
        dateTimePickerEditRepair.Format = DateTimePickerFormat.Custom

        'format aus einstellungen übernehmen
        dateTimePickerEditRepair.CustomFormat = tankmanagerSettings.format_date

        'Datum zurücksetzen
        dateTimePickerEditRepair.Value = Now

        'Überschriften einfügen
        addHeadersToLV()

        'Reparaturkosten zurücksetzen
        textboxEditRepairCosts.Text = 0

    End Sub

    'Überschriften in LV einfügen
    Private Sub addHeadersToLV()

        'Überschriften einfügen
        listviewEditRepair.Columns.Add(TM_MAIN_DGV_REPAIR_NUMBER_TEXT)
        listviewEditRepair.Columns.Add(TM_MAIN_DGV_REPAIR_POSITION_TEXT)

        'letzte Spalte auf Autosize stellen
        listviewEditRepair.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub textboxEditRepairCosts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textboxEditRepairCosts.KeyPress

        If Not checkValidKey(e) = True Then textboxEditRepairCosts.Text = 0

    End Sub

End Class