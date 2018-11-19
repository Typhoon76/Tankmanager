Imports MySql.Data.MySqlClient

Public Class FormMain

    ''' <summary>
    ''' structire to hold printed page details
    ''' </summary>
    ''' <remarks></remarks>
    Private Structure PageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    ''' <summary>
    ''' dictionary to hold printed page details, with index key
    ''' </summary>
    ''' <remarks></remarks>
    Private pages As Dictionary(Of Integer, PageDetails)

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

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '### BEGIN PROGRAM ###

        'Menutexte setzen
        FormMainMenuFile.Text = TM_MAIN_MENU_FILE
        FormMainMenuFileSetupPage.Text = TM_MAIN_MENU_FILE_SETUP_PAGE
        FormMainMenuFilePreview.Text = TM_MAIN_MENU_FILE_PRINT_PREVIEW
        FormMainMenuFilePrint.Text = TM_MAIN_MENU_FILE_PRINT
        FormMainMenuFileExit.Text = TM_MAIN_MENU_FILE_EXIT
        FormMainMenuEdit.Text = TM_MAIN_MENU_EDIT
        FormMainMenuEditNewRefuel.Text = TM_MAIN_MENU_EDIT_NEW_REFUEL
        FormMainMenuEditNewRepair.Text = TM_MAIN_MENU_EDIT_NEW_REPAIR
        FormMainMenuEditSearch.Text = TM_MAIN_MENU_EDIT_SEARCH
        FormMainMenuXtras.Text = TM_MAIN_MENU_EXTRAS
        FormMainMenuXtrasExportToPDF.Text = TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF
        FormMainMenuXtrasExportToPDFTableRefuel.Text = TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REFUEL
        FormMainMenuXtrasExportToPDFTableRepair.Text = TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REPAIR
        FormMainMenuXtrasSettings.Text = TM_MAIN_MENU_EXTRAS_SETTINGS
        FormMainMenuHelp.Text = TM_MAIN_MENU_HELP
        FormMainMenuHelpInfo.Text = TM_MAIN_MENU_HELP_INFO

        'Groupbox Texte setzen
        FormMainGroupboxSelectYear.Text = TM_MAIN_GROUPBOX_SELECT_YEAR
        FormMainGroupboxFuelCostsYear.Text = TM_MAIN_GROUPBOX_FUEL_COSTS_YEAR
        FormMainGroupboxFuelCostsAll.Text = TM_MAIN_GROUPBOX_FUEL_COSTS_ALL
        FormMainGroupboxRepairCostsYear.Text = TM_MAIN_GROUPBOX_REPAIR_COSTS_YEAR
        FormMainGroupboxRepairCostsAll.Text = TM_MAIN_GROUPBOX_REPAIR_COSTS_ALL
        FormMainGroupboxCostsYear.Text = TM_MAIN_GROUPBOX_COSTS_YEAR
        FormMainGroupboxCostsAll.Text = TM_MAIN_GROUPBOX_COSTS_ALL
        FormMainGroupboxDrivenYear.Text = TM_MAIN_GROUPBOX_DRIVEN_YEAR
        FormMainGroupboxDrivenAll.Text = TM_MAIN_GROUPBOX_DRIVEN_ALL
        FormMainGroupboxAverageConsumptionYear.Text = TM_MAIN_GROUPBOX_AVERAGE_CONSUMPTION_YEAR
        FormMainGroupboxAverageConsumptionAll.Text = TM_MAIN_GROUPBOX_AVERAGE_CONSUMPTION_ALL
        FormMainGroupboxCarData.Text = TM_MAIN_GROUPBOX_CAR_DATA

        'Label Texte setzen
        FormMainLabelNumberOfDataRecords.Text = TM_MAIN_LABEL_NUMBER_OF_DATARECORDS
        FormMainLabelFuelCostsYear.Text = TM_STANDARD_CURRENCY
        FormMainLabelFuelCostsAll.Text = TM_STANDARD_CURRENCY
        FormMainLabelRepairCostsYear.Text = TM_STANDARD_CURRENCY
        FormMainLabelRepairCostsAll.Text = TM_STANDARD_CURRENCY
        FormMainLabelCostsYear.Text = TM_STANDARD_CURRENCY
        FormMainLabelCostsAll.Text = TM_STANDARD_CURRENCY
        FormMainLabelDrivenYear.Text = TM_STANDARD_TOTAL_SHORT
        FormMainLabelDrivenAll.Text = TM_STANDARD_TOTAL_SHORT
        FormMainLabelAverageConsumptionYear.Text = TM_STANDARD_CONSUMPTION_100KM
        FormMainLabelAverageConsumptionAll.Text = TM_STANDARD_CONSUMPTION_100KM
        FormMainLabelCarYearOfConstruction.Text = TM_MAIN_LABEL_CAR_YEAR_OF_CONSTRUCTION
        FormMainLabelCarAge.Text = TM_MAIN_LABEL_CAR_AGE

        'Button Texte setzen
        SwitchReparaturen.Text = TM_MAIN_BUTTON_SHOW_REPAIRS

        Try

            'prüfen ob connect funktion fehlerarray zurückgibt

            Dim myConnectArray = ConnectDatabase()

            If IsArray(myConnectArray) Then

                'wenn ja, dann fehlermeldung anzeigen
                MessageBox.Show(TM_ERROR_MESSAGE_CONNECTION_TO_SERVER_COULD_NOT_OPEN & vbCrLf & myConnectArray(0) & vbCrLf & "Errorcode: " & myConnectArray(1), TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION, MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf myConnectArray = vbBoolean And myConnectArray = True Then

                'wenn nein und rückgabe = wahr

                'erfolg anzeigen
                'If myDebug = True Then MessageBox.Show(TM_ERROR_MESSAGE_CONNECTION_OPEN, TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'connectState auf wahr setzen
                connectState = True

            Else

                'wenn nein und rückgabe = falsch

                'bereits bestehende Verbindung melden
                'If myDebug = True Then MessageBox.Show(TM_ERROR_MESSAGE_CONNECTION_ALREADY_EXISTS, TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION, MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                    MessageBox.Show(TM_ERROR_MESSAGE_MYSQL_TABLE_SETTINGS_COULD_NOT_READ_COMPLETE, TM_ERROR_TYPE_MYSQL_TABLE, MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    'ansonsten weiter im code

                    ''### füllen der ComboBox "comboboxJahrAuswahl"

                    If LeseJahre() = True Then

                        MessageBox.Show(TM_ERROR_MESSAGE_MYSQL_TABLE_REFUEL_HAS_NO_DATA, TM_ERROR_TYPE_MYSQL_TABLE, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        '### Startwert für comboboxJahrAuswahl setzen

                        'variable definieren
                        Dim comboboxJahrAuswahlResult As String

                        'startwert prüfen
                        comboboxJahrAuswahlResult = checkcomboboxJahrAuswahlMinMaxJahre(tankmanagerSettings.selectedYear, comboboxJahrAuswahlErsterEintrag)

                        'wenn startwert falsch dann
                        If comboboxJahrAuswahlResult = False Then

                            'meldung anzeigen
                            'MessageBox.Show("Der Standardwert (" & tankmanagerSettings.selectedYear & ") der Combobox 'comboboxJahrAuswahl' entspricht keinem erlaubten Wert.")
                            MessageBox.Show(TM_MAIN_COMBOBOX_SELECTED_VALUE_IS_NOT_VALID.Replace("%s", tankmanagerSettings.selectedYear))

                        Else

                            'ansonsten startwert setzen
                            ComboboxJahrAuswahl.SelectedItem = tankmanagerSettings.selectedYear

                        End If

                    End If

                    '### END CODE ###

                End If

            Else

                FormMainMenuFileSetupPage.Enabled = False
                FormMainMenuFilePreview.Enabled = False
                FormMainMenuFilePrint.Enabled = False

                FormMainMenuEditNewRefuel.Enabled = False
                FormMainMenuEditNewRepair.Enabled = False
                FormMainMenuEditSearch.Enabled = False

                FormMainMenuXtrasExportToPDF.Enabled = False

            End If

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            'Fehler abfangen

            'fehler meldung und fehlercode anzeigen
            MessageBox.Show(TM_ERROR_MESSAGE_STANDARD & vbCrLf & myerror.Message & vbCrLf & TM_ERROR_CODE & myerror.Number, TM_ERROR_TYPE_MYSQL, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MyClosingDialog() = True Then

            'Fenster wird geschlossen
            Me.Dispose()

            'und Anwendung beendet
            End

        Else

            'Fenster wird nicht geschlossen
            e.Cancel = True

        End If

    End Sub

    Private Sub FormMainMenuFileExit_Click(sender As Object, e As EventArgs) Handles FormMainMenuFileExit.Click

        If MyClosingDialog() = True Then

            'Fenster wird geschlossen
            Me.Dispose()

            'und Anwendung beendet
            End

        End If

    End Sub

    Private Sub FormMainMenuEditNewRefuel_Click(sender As Object, e As EventArgs) Handles FormMainMenuEditNewRefuel.Click

        FormNewRefuel.Show()

    End Sub

    Private Sub FormMainMenuEditNewRepair_Click(sender As Object, e As EventArgs) Handles FormMainMenuEditNewRepair.Click

        FormNewRepair.Show()

    End Sub

    Private Sub FormMainMenuXtrasSettings_Click(sender As Object, e As EventArgs) Handles FormMainMenuXtrasSettings.Click

        FormSettings.Show()

    End Sub

    Private Sub FormMainMenuHelpInfo_Click(sender As Object, e As EventArgs) Handles FormMainMenuHelpInfo.Click

        FormInfo.Show()

    End Sub

    Private Function MyClosingDialog()

        '### Programm beenden

        'variable für status definieren
        Dim closingState = False

        'abfrage ob programm wirklich geschlossen werden soll
        Select Case MsgBox(TM_MESSAGE_QUESTION_EXIT_PROGRAM, vbQuestion Or vbYesNo Or vbDefaultButton2, TM_MESSAGE_TITLE_EXIT_PROGRAM)

            Case vbYes

                'bei auswahl von ja

                '### END PROGRAMM ###

                Dim myDisconnectArray = DisconnectDatabase()

                'prüfen ob disconnect funktion fehlerarray zurück gibt
                If IsArray(myDisconnectArray) Then

                    'wenn ja, dann fehlermeldung anzeigen
                    MessageBox.Show(TM_ERROR_MESSAGE_CONNECTION_TO_SERVER_COULD_NOT_CLOSED & vbCrLf & myDisconnectArray(0) & vbCrLf & TM_ERROR_CODE & myDisconnectArray(1), TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION, MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf myDisconnectArray = vbBoolean And myDisconnectArray = True And connectState = True Then

                    'wenn nein und rückgabe gleich wahr

                    'erfolg anzeigen
                    'If myDebug = True Then MessageBox.Show(TM_ERROR_MESSAGE_CONNECTION_CLOSED, TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION, MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub ComboboxJahrAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboboxJahrAuswahl.SelectedIndexChanged

        'formMain neu aufbauen
        refreshFormMain()

    End Sub

    Private Sub SwitchReparaturen_Click(sender As Object, e As EventArgs) Handles SwitchReparaturen.Click

        'timer starten
        Tim.Enabled = True

        'die blaue markierung des buttons entfernen durch setzen des focus auf ein anderes objekt
        FormMainLabelNumberOfDataRecords.Focus()

    End Sub

    Private Sub DatagridviewTanken_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridviewTanken.CellDoubleClick

        'Index der Zeile ermitteln
        Dim rowIndex As Integer = DatagridviewTanken.CurrentRow.Index

        'ID des Eintrags auslesen
        Dim myID = DatagridviewTanken.Item(0, rowIndex).Value.ToString

        'wenn Abfrage auf die ID ohne Fehler
        If LeseTankenEintrag(MySqlSelectTankenEintrag(myID)) = False Then

            'Eintrag anzeigen
            FormEditRefuel.Show()

        Else

            'ansonsten Fehler anzeigen
            'MessageBox.Show("Eintrag Nummer " & myID & " konnte nicht gelesen werden", TM_ERROR_TYPE_DATA, MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(TM_ERROR_MESSAGE_ENTRY_COULD_NOT_READ.Replace("%s", myID), TM_ERROR_TYPE_DATA, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub DatagridviewReparaturen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridviewReparaturen.CellDoubleClick

        'Index der Zeile ermitteln
        Dim rowIndex As Integer = DatagridviewReparaturen.CurrentRow.Index

        'ID des Eintrags auslesen
        Dim myID = DatagridviewReparaturen.Item(0, rowIndex).Value.ToString

        'wenn ein Eintrag der ID in der DB gefunden wurde
        If LeseReparaturEintrag(MySqlSelectReparaturEintrag(myID)) = False Then

            'dann Eintrag anzeigen
            FormEditRepair.Show()

        End If

    End Sub

    Private Sub FormMainMenuFileSetupPage_Click(sender As Object, e As EventArgs) Handles FormMainMenuFileSetupPage.Click

        'Einstellungen setzen
        With PageSetupDialogFormMain

            'Dokument zuweisen
            .Document = PrintDocumentFormMain

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

    Private Sub FormMainMenuFilePreview_Click(sender As Object, e As EventArgs) Handles FormMainMenuFilePreview.Click

        'Drucken Icon im printPreviewDialog ersetzen
        'https://www.codeproject.com/Questions/675237/How-to-Access-Print-Button-Event-of-Print-Preview
        Dim b As New ToolStripButton With {
            .Image = CType(PrintPreviewFormMain.Controls(1), ToolStrip).ImageList.Images(0),
            .ToolTipText = "Drucken",
            .DisplayStyle = ToolStripItemDisplayStyle.Image
        }
        AddHandler b.Click, AddressOf PrintPreviewFormMain_PrintClick
        CType(PrintPreviewFormMain.Controls(1), ToolStrip).Items.RemoveAt(0)
        CType(PrintPreviewFormMain.Controls(1), ToolStrip).Items.Insert(0, b)
        AddHandler PrintDocumentFormMain.PrintPage, AddressOf PrintDocumentFormMain_PrintPage

        'Variabel für Rückgabewert initialisieren
        Dim myPreviewRC As Integer = 0

        'Abfrage was angezeigt werden soll
        myPreviewRC = RequestChoice(TM_MAIN_PREVIEW_REQUEST_TITLE, TM_MAIN_PREVIEW_REQUEST_QUESTION, TM_MAIN_TABLE_REFUEL, TM_MAIN_TABLE_REPAIRS)

        'wenn Rückgabewert = 1 (Tankliste)
        If myPreviewRC = 1 Then

            'das datagridviewTanken zuweisen
            DruckDataGridView = DatagridviewTanken

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(ComboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REFUEL_COLON & ComboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REFUEL_COLON & TM_MAIN_TABLE_ALL_YEARS_PART

            End If

            'Einstellungen für Vorschau setzen
            With PrintPreviewFormMain

                'Dokument zuweisen
                .Document = PrintDocumentFormMain

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
            DruckDataGridView = DatagridviewReparaturen

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(ComboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REPAIRS_COLON & ComboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REPAIRS_COLON & TM_MAIN_TABLE_ALL_YEARS_PART

            End If

            'Einstellungen für Vorschau setzen
            With PrintPreviewFormMain

                'Dokument zuweisen
                .Document = PrintDocumentFormMain

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
    Private Sub PrintPreviewFormMain_PrintClick(sender As Object, e As EventArgs)

        Try

            'Dokument zuweisen
            PrintDialogFormMain.Document = PrintDocumentFormMain

            'Druckdialog anzeigen
            If PrintDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                PrintDocumentFormMain.Print()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormMainMenuFilePrint_Click(sender As Object, e As EventArgs) Handles FormMainMenuFilePrint.Click

        'Variabel für Rückgabewert initialisieren
        Dim myPrintRC As Integer = 0

        'Abfrage was gedruckt werden soll
        myPrintRC = RequestChoice(TM_MAIN_PRINT_REQUEST_TITLE, TM_MAIN_PRINT_REQUEST_QUESTION, TM_MAIN_TABLE_REFUEL, TM_MAIN_TABLE_REPAIRS)

        'wenn Rückgabewert = 1 (Tankliste)
        If myPrintRC = 1 Then

            'das datagridviewTanken zuweisen
            DruckDataGridView = DatagridviewTanken

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(ComboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REFUEL_COLON & ComboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REFUEL_COLON & TM_MAIN_TABLE_ALL_YEARS_PART

            End If

            'Druckdialog anzeigen
            If PrintDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                PrintDocumentFormMain.Print()

            End If

            'wenn Rückgabewert = 2 (Reparaturliste)
        ElseIf myPrintRC = 2 Then

            'das datagridviewReparaturen zuweisen
            DruckDataGridView = DatagridviewReparaturen

            'wenn Jahresauswahl numerisch ist
            If IsNumeric(ComboboxJahrAuswahl.Text) Then

                'Titel auf das Jahr setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REPAIRS_COLON & ComboboxJahrAuswahl.Text

            Else

                'ansonsten Titel auf alle Jahre setzen
                TitleDruckDataGridView.Text = TM_MAIN_TABLE_REPAIRS_COLON & TM_MAIN_TABLE_ALL_YEARS_PART

            End If

            'Druckdialog anzeigen
            If PrintDialogFormMain.ShowDialog() = DialogResult.OK Then

                'Dokument drucken
                PrintDocumentFormMain.Print()

            End If

        End If

    End Sub

    Private Function RequestChoice(myTitleText, myDescriptionText, myRefuelText, myRepairText)

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

        End If

        'Rückgabecode zurückgeben
        Return myReturnCode

    End Function

    ''' <summary>
    ''' the majority of this Sub is calculating printed page ranges
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrintDocumentFormMain_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocumentFormMain.BeginPrint

        'Fix für Querformat
        Dim myWidth, myHeight As Single

        'wenn Querformat
        If PrintDocumentFormMain.DefaultPageSettings.Landscape = True Then

            'dann Breite und Höhe tauschen
            myWidth = PrintDocumentFormMain.DefaultPageSettings.PrintableArea.Height
            myHeight = PrintDocumentFormMain.DefaultPageSettings.PrintableArea.Width

        Else

            'ansonsten Breite und Höhe zuweisen
            myWidth = PrintDocumentFormMain.DefaultPageSettings.PrintableArea.Width
            myHeight = PrintDocumentFormMain.DefaultPageSettings.PrintableArea.Height

        End If

        pages = New Dictionary(Of Integer, PageDetails)

        'Dim maxWidth As Integer = CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Width) - 40
        'Dim maxHeight As Integer = CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Height) - 40 + TitleDruckDataGridView.Height
        Dim maxWidth As Integer = CInt(myWidth) - 40
        Dim maxHeight As Integer = CInt(myHeight) - 40 + TitleDruckDataGridView.Height - PrintDocumentFormMain.DefaultPageSettings.Margins.Bottom

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New PageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DruckDataGridView.RowHeadersWidth

        For c As Integer = 0 To DruckDataGridView.Columns.Count - 1
            If columnSum + DruckDataGridView.Columns(c).Width < maxWidth Then
                columnSum += DruckDataGridView.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New PageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DruckDataGridView.RowHeadersWidth + DruckDataGridView.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New PageDetails With {.startCol = c})
            End If
            If c = DruckDataGridView.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New PageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
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
                pages(pageCounter) = New PageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New PageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New PageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DruckDataGridView.ColumnHeadersHeight + DruckDataGridView.Rows(r).Height
                rowCounter = 1
            End If
            If r = DruckDataGridView.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New PageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
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
    Private Sub PrintDocumentFormMain_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentFormMain.PrintPage

        'Dim rect As New Rectangle(20, 20, CInt(printDocumentFormMain.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim rect As New Rectangle(20, 20, CInt(PrintDocumentFormMain.DefaultPageSettings.PrintableArea.Width), TitleDruckDataGridView.Height - PrintDocumentFormMain.DefaultPageSettings.Margins.Bottom)

        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

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

    Private Sub FormMainMenuXtrasExportToPDFTableRefuel_Click(sender As Object, e As EventArgs) Handles FormMainMenuXtrasExportToPDFTableRefuel.Click

        ExportToPDF(DatagridviewTanken, 1)

    End Sub

    Private Sub FormMainMenuXtrasExportToPDFTableRepair_Click(sender As Object, e As EventArgs) Handles FormMainMenuXtrasExportToPDFTableRepair.Click

        ExportToPDF(DatagridviewReparaturen, 2)

    End Sub

End Class