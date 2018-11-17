Public Class FormNewRepair

    Private Sub formNewRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'form zurücksetzen
        resetForm()

    End Sub

    'Form Buttons
    Private Sub buttonNewRepairCancel_Click(sender As Object, e As EventArgs) Handles buttonNewRepairCancel.Click

        'Fenster schließen
        Me.Close()

    End Sub

    Private Sub buttonNewRepairReset_Click(sender As Object, e As EventArgs) Handles buttonNewRepairReset.Click

        'form zurücksetzen
        resetForm()

    End Sub

    Private Sub buttonNewRepairSaveAndNew_Click(sender As Object, e As EventArgs) Handles buttonNewRepairSaveAndNew.Click

        If checkForError() = False Then

            If schreibeReparatur(dateTimePickerNewRepair.Value, textboxNewRepairCosts.Text) = True Then

                'Fenster resetten
                resetForm()

                'formMain neu aufbauen
                refreshFormMain()

                'Fenster wieder in Vordergrund holen
                Me.Activate()

            Else

                MessageBox.Show("Reparatur konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub buttonNewRepairSaveAndExit_Click(sender As Object, e As EventArgs) Handles buttonNewRepairSaveAndExit.Click

        If checkForError() = False Then

            If schreibeReparatur(dateTimePickerNewRepair.Value, textboxNewRepairCosts.Text) = True Then

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
    Private Sub listviewNewRepair_DoubleClick(sender As Object, e As EventArgs) Handles listviewNewRepair.DoubleClick

        'gewählten Eintrag ändern
        editSelectedItem()

    End Sub

    'Listview Buttons
    Private Sub buttonNewRepairLVDown_Click(sender As Object, e As EventArgs) Handles buttonNewRepairLVDown.Click

        'Variable für Index definieren
        Dim newIndex As Integer = 0

        'für jeden Eintrag
        For currentIndex As Integer = listviewNewRepair.Items.Count - 1 To 0 Step -1

            'Variable für gewählten Eintrag definieren
            Dim li As ListViewItem = listviewNewRepair.Items(currentIndex)

            'prüfen ob ausgewählt
            If li.Selected = True Then

                'wenn ja, gewählten Eintrag einen Platz nach unten verschieben
                moveListViewItemDown(listviewNewRepair, li.Index)

                'dem Index den Wert den Indexes des gewählten Eintrages zuweisen
                newIndex = li.Index

                'Einträge neu nummerieren
                renumerateLV()

                'ursprünglich gewählten Eintrag erneut auswählen
                listviewNewRepair.Items(newIndex).Selected = True
                listviewNewRepair.Select()

            End If

        Next

    End Sub

    Private Sub buttonNewRepairLVUp_Click(sender As Object, e As EventArgs) Handles buttonNewRepairLVUp.Click

        'Variable für Index definieren
        Dim newIndex As Integer = 0

        'für jeden Eintrag
        For Each li As ListViewItem In listviewNewRepair.Items

            'prüfen ob ausgewählt
            If li.Selected = True Then

                'wenn ja, gewählten Eintrag einen Platz nach oben verschieben
                moveListViewItemUp(listviewNewRepair, li.Index)

                'dem Index den Wert den Indexes des gewählten Eintrages zuweisen
                newIndex = li.Index

                'Einträge neu nummerieren
                renumerateLV()

                'ursprünglich gewählten Eintrag erneut auswählen
                listviewNewRepair.Items(newIndex).Selected = True
                listviewNewRepair.Select()

            End If

        Next

    End Sub

    Private Sub buttonNewRepairLVDelete_Click(sender As Object, e As EventArgs) Handles buttonNewRepairLVDelete.Click

        'wenn Anzahl gewählter Einträge größer 0
        If listviewNewRepair.SelectedItems.Count > 0 Then

            'gewählten Eintrag löschen
            listviewNewRepair.Items.RemoveAt(listviewNewRepair.SelectedIndices(0))

            'verbleibende Einträge neu nummerieren
            renumerateLV()

        End If

    End Sub

    Private Sub buttonNewRepairLVEdit_Click(sender As Object, e As EventArgs) Handles buttonNewRepairLVEdit.Click

        'gewählten Eintrag ändern
        editSelectedItem()

    End Sub

    Private Sub buttonNewRepairLVAdd_Click(sender As Object, e As EventArgs) Handles buttonNewRepairLVAdd.Click

        'Anzahl bisheriger Einträge ermitteln
        Dim myItems = listviewNewRepair.Items.Count

        'Text des neunen Eintrages abfragen
        Dim myText = InputBox(TM_REPAIR_LV_REPAIR_NEW_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_TITLE_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT)

        'Text des neunen Eintrages mit dem Standardtext und einem leeren Text vergleichen
        If Not myText = TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT And Not myText = "" Then

            'neuen Eintrag mit eingegebenen Text einfügen
            listviewNewRepair.Items.Add(myItems + 1).SubItems.Add(myText)

        End If

    End Sub

    'Special Subs

    'Überschriften in LV einfügen
    Private Sub addHeadersToLV()

        'Überschriften einfügen
        listviewNewRepair.Columns.Add(TM_MAIN_DGV_REPAIR_NUMBER_TEXT)
        listviewNewRepair.Columns.Add(TM_MAIN_DGV_REPAIR_POSITION_TEXT)

        'letzte Spalte auf Autosize stellen
        listviewNewRepair.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)

        'Testdaten einfügen
        'listviewNewRepair.Items.Add(1).SubItems.Add("Winterreifen")
        'listviewNewRepair.Items.Add(2).SubItems.Add("Bremsbeläge")
        'listviewNewRepair.Items.Add(3).SubItems.Add("Scheibenwischer")
        'listviewNewRepair.Items.Add(4).SubItems.Add("Ölwechsel")
        'listviewNewRepair.Items.Add(5).SubItems.Add("Rückleuchten")

    End Sub

    'Einträge neu nummerieren
    Private Sub renumerateLV()

        'Variable für neuen Indexzähler anlegen
        Dim newIndex As Integer = 1

        'für jeden Eintrag
        For Each item As ListViewItem In listviewNewRepair.Items

            'den neuen Indexzähler zuweisen
            item.Text = newIndex

            'den Indexzähler um eins erhöhen
            newIndex = newIndex + 1

        Next

    End Sub

    Private Sub editSelectedItem()

        'wenn Anzahl gewählter Einträge größer 0
        If listviewNewRepair.SelectedItems.Count > 0 Then

            'Text des alten Eintrages ermitteln
            Dim myOldItemText As String = listviewNewRepair.SelectedItems(0).SubItems(1).Text

            'Text des geänderten Eintrages abfragen
            Dim myNewItemText = InputBox(TM_REPAIR_LV_REPAIR_CHANGE_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_CHANGE_POSITION_TITLE_TEXT, listviewNewRepair.SelectedItems(0).SubItems(1).Text)

            'Text des geänderten Eintrages mit dem Text des alten Eintrages und einem leeren Text vergleichen
            If Not myNewItemText = myOldItemText And Not myNewItemText = "" Then

                'Text des gewählten Eintrages ändern
                listviewNewRepair.SelectedItems(0).SubItems(1).Text = myNewItemText

            End If

        End If

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

    Private Function checkForError()

        'Variablen definieren
        Dim formError As Boolean = False
        Dim customErrorString As String = ""

        'Datumsfeld mit Fehler auswählen
        If checkValidDate(dateTimePickerNewRepair) = False Then
            dateTimePickerNewRepair.Select()
            customErrorString = "Das Datum liegt in der Zukunft."
            formError = True
        End If

        'Listview mit Fehler auswählen
        If listviewNewRepair.Items.Count = 0 Then
            listviewNewRepair.Select()
            customErrorString = "Die Reparaturliste enthält keine Einträge."
            formError = True
        End If

        'Textbox mit Fehler auswählen
        If checkValidInput(textboxNewRepairCosts.Text) = False Or checkBlankOrNull(textboxNewRepairCosts) = False Then
            textboxNewRepairCosts.Select()
            customErrorString = "Es wurde kein gültiger Reparaturpreis eingegeben."
            formError = True
        End If

        'wenn Fehler dann Meldung ausgeben
        If formError = True Then MessageBox.Show("Es ist ein Fehler aufgetreten" & vbNewLine & vbNewLine & customErrorString, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return formError

    End Function

    Private Sub resetForm()

        'Listview leeren
        listviewNewRepair.Clear()

        'format auf custom stellen
        dateTimePickerNewRepair.Format = DateTimePickerFormat.Custom

        'format aus einstellungen übernehmen
        dateTimePickerNewRepair.CustomFormat = tankmanagerSettings.format_date
        'Datum zurücksetzen
        dateTimePickerNewRepair.Value = Now

        'Überschriften einfügen
        addHeadersToLV()

        'Reparaturkosten zurücksetzen
        textboxNewRepairCosts.Text = 0

    End Sub

    Private Sub textboxNewRepairCosts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textboxNewRepairCosts.KeyPress

        If Not checkValidKey(e) = True Then textboxNewRepairCosts.Text = 0

    End Sub

End Class