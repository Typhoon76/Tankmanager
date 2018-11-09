Imports MySql.Data.MySqlClient

Public Class formMain

    ''' <summary>
    ''' structire to hold printed page details
    ''' </summary>
    ''' <remarks></remarks>
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    ''' <summary>
    ''' dictionary to hold printed page details, with index key
    ''' </summary>
    ''' <remarks></remarks>
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer

    'leeren DGV initialisieren
    Public DruckDataGridView As New DataGridView
    Public TitleDruckDataGridView As New Label

    'variable für fenstermodus definieren
    Public windowsStateMinimized = True

    Public settingsError As Boolean = False
    Public yearsError As Boolean = False

    Public benzinGesamtError As Boolean = False
    Public reparaturGesamtError As Boolean = False
    Public kostenGesamtError As Boolean = False
    Public kilometerGesamtError As Boolean = False
    Public verbrauchGesamtError As Boolean = False

    Public benzinJahrError As Boolean = False
    Public reparaturJahrError As Boolean = False
    Public kostenJahrError As Boolean = False
    Public kilometerJahrError As Boolean = False
    Public verbrauchJahrError As Boolean = False

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '### BEGIN PROGRAM ###

        Try

            'prüfen ob connect funktion fehlerarray zurückgibt

            Dim myConnectArray = ConnectDatabase()

            If IsArray(myConnectArray) Then

                'wenn ja, dann fehlermeldung anzeigen
                MessageBox.Show("Verbindung konnte nicht geöffnet werden:" & vbCrLf & myConnectArray(0) & vbCrLf & "Errorcode: " & myConnectArray(1), "MySQL Server Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf myConnectArray = vbBoolean And myConnectArray = True Then

                'wenn nein und rückgabe = wahr

                'erfolg anzeigen
                If myDebug = True Then MessageBox.Show("Verbindung offen", "MySQL Server Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'connectState auf wahr setzen
                connectState = True

            Else

                'wenn nein und rückgabe = falsch

                'bereits bestehende Verbindung melden
                If myDebug = True Then MessageBox.Show("Verbindung besteht bereits", "MySQL Server Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'connectState auf wahr setzen
                connectState = True

            End If

            If connectState = True Then

                '### BEGIN CODE ###

                '### Einstellungen aus Datenbank lesen
                settingsError = LeseEinstellungen()

                'einzelne werte prüfen und bei leer einstellungsfehler auf wahr setzen
                If tankmanagerSettings.date_of_construction = "00:00:00" Then settingsError = True

                If tankmanagerSettings.format_date Is Nothing Or
                    tankmanagerSettings.format_time Is Nothing Or
                    tankmanagerSettings.format_quantity Is Nothing Or
                    tankmanagerSettings.format_price_per_liter Is Nothing Or
                    tankmanagerSettings.format_price Is Nothing Or
                    tankmanagerSettings.format_route Is Nothing Or
                    tankmanagerSettings.format_mileage Is Nothing Or
                    tankmanagerSettings.selectedYear Is Nothing Then
                    settingsError = True
                End If

                'wenn einstellungsfehler wahr dann fehlermeldung anzeigen
                If settingsError = True Then

                    'dann fehlermeldung anzeigen
                    MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf &
                                    "Die Einstellungen konnten nicht richtig aus der Tabelle 'tbl_einstellungen' gelesen werden", "Tabellen Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    'ansonsten weiter im code

                    ''### füllen der ComboBox "comboboxJahrAuswahl"

                    If LeseJahre() = True Then

                        MessageBox.Show("'tbl_tanken' enthält keine Daten", "Tabellen Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        '### Startwert für comboboxJahrAuswahl setzen

                        'variable definieren
                        Dim comboboxJahrAuswahlResult As String

                        'startwert prüfen
                        comboboxJahrAuswahlResult = checkcomboboxJahrAuswahlMinMaxJahre(tankmanagerSettings.selectedYear, comboboxJahrAuswahlErsterEintrag)

                        'wenn startwert falsch dann
                        If comboboxJahrAuswahlResult = False Then

                            'meldung anzeigen
                            MessageBox.Show("Der Standardwert (" & tankmanagerSettings.selectedYear & ") der Combobox 'comboboxJahrAuswahl' entspricht keinem erlaubten Wert.")

                        Else

                            'ansonsten startwert setzen
                            comboboxJahrAuswahl.SelectedItem = tankmanagerSettings.selectedYear

                        End If

                    End If

                    '### END CODE ###

                End If

            Else

                DruckvorschauToolStripMenuItem.Enabled = False
                DruckenToolStripMenuItem.Enabled = False

                NeueTankquittungToolStripMenuItem.Enabled = False
                NeueReparaturToolStripMenuItem.Enabled = False
                SuchenToolStripMenuItem.Enabled = False

                ExportierenNachPDFToolStripMenuItem.Enabled = False

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show("Es ist ein Fehler aufgetreten" & vbCrLf & myerror.Message & vbCrLf & "Errorcode: " & myerror.Number, "MySQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'TEST
        'formTest.Show()

    End Sub

    Private Sub formMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If myClosingDialog() = True Then

            'Fenster wird geschlossen
            Me.Dispose()

            'und Anwendung beendet
            End

        Else

            'Fenster wird nicht geschlossen
            e.Cancel = True

        End If

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click

        If myClosingDialog() = True Then

            'Fenster wird geschlossen
            Me.Dispose()

            'und Anwendung beendet
            End

        End If

    End Sub

    Private Sub NeueTankquittungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeueTankquittungToolStripMenuItem.Click

        formNewRefuel.Show()

    End Sub

    Private Sub NeueReparaturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeueReparaturToolStripMenuItem.Click

        formNewRepair.Show()

    End Sub

    Private Sub ExportierenNachPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportierenNachPDFToolStripMenuItem.Click

        formExportPDF.Show()

    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click

        formSettings.Show()

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click

        formInfo.Show()

    End Sub

    Private Function myClosingDialog()

        '### Programm beenden

        'variable für status definieren
        Dim closingState = False

        'abfrage ob programm wirklich geschlossen werden soll
        Select Case MsgBox("Wollen Sie das Programm wirklich beenden?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Programm beenden ?")

            Case vbYes

                'bei auswahl von ja

                '### END PROGRAMM ###

                Dim myDisconnectArray = DisconnectDatabase()

                'prüfen ob disconnect funktion fehlerarray zurück gibt
                If IsArray(myDisconnectArray) Then

                    'wenn ja, dann fehlermeldung anzeigen
                    MessageBox.Show("Verbindung konnte nicht geschlossen werden:" & vbCrLf & myDisconnectArray(0) & vbCrLf & "Errorcode: " & myDisconnectArray(1), "MySQL Server Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf myDisconnectArray = vbBoolean And myDisconnectArray = True And connectState = True Then

                    'wenn nein und rückgabe gleich wahr

                    'erfolg anzeigen
                    If myDebug = True Then MessageBox.Show("Verbindung geschlossen", "MySQL Server Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                'status auf wahr setzen
                closingState = True

            Case vbNo

                'bei auswahl von nein

                'status auf falsch setzen und datenbankverbindung offen lassen
                closingState = False

        End Select

        'status zurückgeben
        Return closingState

    End Function

    Private Sub comboboxJahrAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxJahrAuswahl.SelectedIndexChanged

        'formMain neu aufbauen
        refreshFormMain()

    End Sub

    Private Sub switchReparaturen_Click(sender As Object, e As EventArgs) Handles switchReparaturen.Click

        'timer starten
        tim.Enabled = True

        'die blaue markierung des buttons entfernen durch setzen des focus auf ein anderes objekt
        Label1.Focus()

    End Sub

    Private WithEvents tim As New Timer With {.Interval = 1}

    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick

        'wenn fensterstatusminimal wahr
        If windowsStateMinimized = True Then

            'fenstergröße plus 10
            Me.Width = Me.Width + 10

            'wenn fenstergröße maximal
            If Me.Width = 1920 Then

                'timer stoppen
                tim.Enabled = False

                'fensterstatusminimal auf falsch setzen
                windowsStateMinimized = False

                'button text ändern
                switchReparaturen.Text = "<< Reparaturen verbergen"

            End If

        ElseIf windowsStateMinimized = False Then

            'wenn fenster vergrößert

            'fenstergröße minus 10
            Me.Width = Me.Width - 10

            'wenn fenstergröße minila
            If Me.Width = 1270 Then

                'timer stoppen
                tim.Enabled = False

                'fensterstatusminimal auf wahr setzen
                windowsStateMinimized = True

                'button text ändern
                switchReparaturen.Text = "Reparaturen anzeigen >>"

            End If

        End If

        'fenster zentrieren
        CenterForm(Me)

    End Sub

    'von seite https://stackoverflow.com/questions/19392083/center-form-on-screen-or-on-parent
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub

    Private Sub datagridviewTanken_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewTanken.CellDoubleClick

        'Index der Zeile ermitteln
        Dim rowIndex As Integer = datagridviewTanken.CurrentRow.Index

        'ID des Eintrags auslesen
        Dim myID = datagridviewTanken.Item(0, rowIndex).Value.ToString

        'wenn Abfrage auf die ID ohne Fehler
        If LeseTankenEintrag(MySqlSelectTankenEintrag(myID)) = False Then

            'Eintrag anzeigen
            formEditRefuel.Show()

        Else

            'ansonsten Fehler anzeigen
            MessageBox.Show("Eintrag Nummer " & myID & " konnte nicht gelesen werden", "Datenfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub datagridviewReparaturen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewReparaturen.CellDoubleClick

        'Index der Zeile ermitteln
        Dim rowIndex As Integer = datagridviewReparaturen.CurrentRow.Index

        'ID des Eintrags auslesen
        Dim myID = datagridviewReparaturen.Item(0, rowIndex).Value.ToString

        'wenn ein Eintrag der ID in der DB gefunden wurde
        If LeseReparaturEintrag(MySqlSelectReparaturEintrag(myID)) = False Then

            'dann Eintrag anzeigen
            formEditRepair.Show()

        End If

    End Sub

    Private Sub SeiteEinrichtenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeiteEinrichtenToolStripMenuItem.Click

        'Einstellungen setzen
        With pageSetupDialogFormMain

            'Dokument zuweisen
            .Document = printDocumentFormMain

            'Einstellungen für Ränder setzen
            .PageSettings.Margins.Left = 10
            .PageSettings.Margins.Right = 10
            .PageSettings.Margins.Top = 10
            .PageSettings.Margins.Bottom = 10

            'Querformat einschalten
            .PageSettings.Landscape = True

            'Dialog anzeigen
            .ShowDialog()

        End With

    End Sub

    Private Sub DruckvorschauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DruckvorschauToolStripMenuItem.Click

        'Drucken Icon im printPreviewDialog ersetzen
        'https://www.codeproject.com/Questions/675237/How-to-Access-Print-Button-Event-of-Print-Preview
        Dim b As New ToolStripButton
        b.Image = CType(printPreviewFormMain.Controls(1), ToolStrip).ImageList.Images(0)
        b.ToolTipText = "Drucken"
        b.DisplayStyle = ToolStripItemDisplayStyle.Image
        AddHandler b.Click, AddressOf printPreviewFormMain_PrintClick
        CType(printPreviewFormMain.Controls(1), ToolStrip).Items.RemoveAt(0)
        CType(printPreviewFormMain.Controls(1), ToolStrip).Items.Insert(0, b)
        AddHandler printDocumentFormMain.PrintPage, AddressOf printDocumentFormMain_PrintPage

        'Variabel für Rückgabewert initialisieren
        Dim myPreviewRC = 0

        'Abfrage was angezeigt werden soll
        myPreviewRC = requestChoice("Abfrage für Vorschau", "Welche Vorschau soll angezeigt werden?", "Vorschau Tankenliste", "Vorschau Reparaturliste")

        'wenn Rückgabewert = 1 (Tankliste)
        If myPreviewRC = 1 Then

            'das datagridviewTanken zuweisen
            DruckDataGridView = datagridviewTanken

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(comboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = "Tankliste: " & comboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = "Tankliste: Alle Jahre"

            End If

            'Einstellungen für Vorschau setzen
            With printPreviewFormMain

                'Dokument zuweisen
                .Document = printDocumentFormMain

                'Startposition setzen
                .StartPosition = FormStartPosition.CenterScreen

                'Fenstergröße setzen
                .WindowState = FormWindowState.Maximized

                'aktuelles Icon zuweisen
                .Icon = Icon

                'Dialog anzeigen
                .ShowDialog()

            End With

            'wenn Rückgabewert = 2 (Reparaturliste)
        ElseIf myPreviewRC = 2 Then

            'das datagridviewReparaturen zuweisen
            DruckDataGridView = datagridviewReparaturen

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(comboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = "Reparaturliste: " & comboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = "Reparaturliste: Alle Jahre"

            End If

            'Einstellungen für Vorschau setzen
            With printPreviewFormMain

                'Dokument zuweisen
                .Document = printDocumentFormMain

                'Startposition setzen
                .StartPosition = FormStartPosition.CenterScreen

                'Fenstergröße setzen
                .WindowState = FormWindowState.Maximized

                'aktuelles Icon zuweisen
                .Icon = Icon

                'Dialog anzeigen
                .ShowDialog()

            End With

        End If

    End Sub

    'https://www.codeproject.com/Questions/675237/How-to-Access-Print-Button-Event-of-Print-Preview
    Private Sub printPreviewFormMain_PrintClick(sender As Object, e As EventArgs)

        Try

            'Dokument zuweisen
            printDialogFormMain.Document = printDocumentFormMain

            'Druckdialog anzeigen
            If printDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                printDocumentFormMain.Print()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DruckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DruckenToolStripMenuItem.Click

        'Variabel für Rückgabewert initialisieren
        Dim myPreviewRC = 0

        'Abfrage was gedruckt werden soll
        myPreviewRC = requestChoice("Abfrage für Druck", "Welche Liste soll gedruckt werden?", "Tankenliste", "Reparaturliste")

        'wenn Rückgabewert = 1 (Tankliste)
        If myPreviewRC = 1 Then

            'das datagridviewTanken zuweisen
            DruckDataGridView = datagridviewTanken

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(comboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = "Tankliste: " & comboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = "Tankliste: Alle Jahre"

            End If

            'Druckdialog anzeigen
            If printDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                printDocumentFormMain.Print()

            End If

            'wenn Rückgabewert = 2 (Reparaturliste)
        ElseIf myPreviewRC = 2 Then

            'das datagridviewReparaturen zuweisen
            DruckDataGridView = datagridviewReparaturen

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(comboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = "Reparaturliste: " & comboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = "Reparaturliste: Alle Jahre"

            End If

            'Druckdialog anzeigen
            If printDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                printDocumentFormMain.Print()

            End If

        End If

    End Sub

    Private Function requestChoice(myTitleText, myDescriptionText, myRefuelText, myRepairText)

        'Variabel für Rückgabecode initialisieren
        Dim myReturnCode = 0

        With FormPrintingChoice

            'Titletext festlegen
            .Text = myTitleText

            'Text für Beschreibung festlegen
            .labelPrintingChoice.Text = myDescriptionText

            'Text für Tank Button festlegen
            .buttonPrintingChoiceRefuel.Text = myRefuelText

            'Text für Reparatur Button festlegen
            .buttonPrintingChoiceRepair.Text = myRepairText

            'Vorauswahl für Button Abbruch
            .buttonPrintingChoiceCancel.Select()

            'Form anzeigen
            .ShowDialog()

        End With

        'wenn Form nicht sichtbar (geschlossen)
        If FormPrintingChoice.Visible = False Then

            'dann Rückgabecode abfragen
            myReturnCode = FormPrintingChoice.returning()

            'Rückgabecode zurückgeben
            Return myReturnCode

        End If

    End Function

    ''' <summary>
    ''' the majority of this Sub is calculating printed page ranges
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printDocumentFormMain_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles printDocumentFormMain.BeginPrint

        'Fix für Querformat
        Dim myWidth, myHeight As Single

        'wenn Querformat
        If printDocumentFormMain.DefaultPageSettings.Landscape = True Then

            'dann Breite und Höhe tauschen
            myWidth = printDocumentFormMain.DefaultPageSettings.PrintableArea.Height
            myHeight = printDocumentFormMain.DefaultPageSettings.PrintableArea.Width

        Else

            'ansonsten Breite und Höhe zuweisen
            myWidth = printDocumentFormMain.DefaultPageSettings.PrintableArea.Width
            myHeight = printDocumentFormMain.DefaultPageSettings.PrintableArea.Height

        End If

        pages = New Dictionary(Of Integer, pageDetails)

        'Dim maxWidth As Integer = CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Width) - 40
        'Dim maxHeight As Integer = CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Height) - 40 + TitleDruckDataGridView.Height
        Dim maxWidth As Integer = CInt(myWidth) - 40
        Dim maxHeight As Integer = CInt(myHeight) - 40 + TitleDruckDataGridView.Height - printDocumentFormMain.DefaultPageSettings.Margins.Bottom

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DruckDataGridView.RowHeadersWidth

        For c As Integer = 0 To DruckDataGridView.Columns.Count - 1
            If columnSum + DruckDataGridView.Columns(c).Width < maxWidth Then
                columnSum += DruckDataGridView.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DruckDataGridView.RowHeadersWidth + DruckDataGridView.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = DruckDataGridView.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = DruckDataGridView.ColumnHeadersHeight

        'For r As Integer = 0 To DruckDataGridView.Rows.Count - 2
        For r As Integer = 0 To DruckDataGridView.Rows.Count - 1
            If rowSum + DruckDataGridView.Rows(r).Height < maxHeight Then
                rowSum += DruckDataGridView.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DruckDataGridView.ColumnHeadersHeight + DruckDataGridView.Rows(r).Height
                rowCounter = 1
            End If
            If r = DruckDataGridView.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub

    ''' <summary>
    ''' this is the actual printing routine.
    ''' using the pagedetails i calculated earlier, it prints a title,
    ''' + as much of the datagridview as will fit on 1 page, then moves to the next page.
    ''' this is setup to be dynamic. try resizing the dgv columns or rows
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printDocumentFormMain_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocumentFormMain.PrintPage

        'Dim rect As New Rectangle(20, 20, CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim rect As New Rectangle(20, 20, CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Width), TitleDruckDataGridView.Height - printDocumentFormMain.DefaultPageSettings.Margins.Bottom)

        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)
        e.Graphics.DrawString(TitleDruckDataGridView.Text, TitleDruckDataGridView.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, DruckDataGridView.RowHeadersWidth, DruckDataGridView.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += DruckDataGridView.ColumnHeadersHeight

            'For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                cell = New Rectangle(startX, startY, DruckDataGridView.RowHeadersWidth, DruckDataGridView.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                'e.Graphics.DrawString(DruckDataGridView.Rows(r).HeaderCell.Value.ToString, TitleDruckDataGridView.Font, Brushes.Black, cell, sf)
                e.Graphics.DrawString(DruckDataGridView.Rows(r).HeaderCell.Value, TitleDruckDataGridView.Font, Brushes.Black, cell, sf)
                startY += DruckDataGridView.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, DruckDataGridView.Columns(c).Width, DruckDataGridView.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DruckDataGridView.Columns(c).HeaderCell.Value.ToString, TitleDruckDataGridView.Font, Brushes.Black, cell, sf)
                startX += DruckDataGridView.Columns(c).Width
            Next

            startY = rect.Bottom + DruckDataGridView.ColumnHeadersHeight

            'For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                startX = 50 + DruckDataGridView.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, DruckDataGridView.Columns(c).Width, DruckDataGridView.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(DruckDataGridView(c, r).Value.ToString, TitleDruckDataGridView.Font, Brushes.Black, cell, sf)
                    startX += DruckDataGridView.Columns(c).Width
                Next
                startY += DruckDataGridView.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub

End Class