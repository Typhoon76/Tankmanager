<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenustripFormMain = New System.Windows.Forms.MenuStrip()
        Me.FormMainMenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuFileSetupPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuFilePreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormMainMenuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuEditNewRefuel = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuEditNewRepair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormMainMenuEditSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuXtras = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuXtrasExportToPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuXtrasExportToPDFTableRefuel = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuXtrasExportToPDFTableRepair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormMainMenuXtrasSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMainMenuHelpInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.FormMainGroupboxFuelCostsAll = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelFuelCostsAll = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenBenzin = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxRepairCostsAll = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelRepairCostsAll = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenReparatur = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxDrivenAll = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelDrivenAll = New System.Windows.Forms.Label()
        Me.TextboxGesamtkilometerGefahren = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxCostsAll = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelCostsAll = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenBezahlt = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxAverageConsumptionAll = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelAverageConsumptionAll = New System.Windows.Forms.Label()
        Me.TextboxGesamterVerbrauch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.FormMainGroupboxFuelCostsYear = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelFuelCostsYear = New System.Windows.Forms.Label()
        Me.TextboxBenzinkostenJahr = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxRepairCostsYear = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelRepairCostsYear = New System.Windows.Forms.Label()
        Me.TextboxReparaturkostenJahr = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxDrivenYear = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelDrivenYear = New System.Windows.Forms.Label()
        Me.TextboxKmGefahrenJahr = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxCostsYear = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelCostsYear = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenJahr = New System.Windows.Forms.TextBox()
        Me.FormMainGroupboxCarData = New System.Windows.Forms.GroupBox()
        Me.textboxAutoAlter = New System.Windows.Forms.TextBox()
        Me.textboxAutoBaujahr = New System.Windows.Forms.TextBox()
        Me.FormMainLabelCarAge = New System.Windows.Forms.Label()
        Me.FormMainLabelCarYearOfConstruction = New System.Windows.Forms.Label()
        Me.FormMainGroupboxAverageConsumptionYear = New System.Windows.Forms.GroupBox()
        Me.FormMainLabelAverageConsumptionYear = New System.Windows.Forms.Label()
        Me.TextboxVerbrauchJahr = New System.Windows.Forms.TextBox()
        Me.SwitchReparaturen = New System.Windows.Forms.Button()
        Me.FormMainGroupboxSelectYear = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboboxJahrAuswahl = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.FormMainLabelNumberOfDataRecords = New System.Windows.Forms.Label()
        Me.TextboxJahrDatensaetze = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.DatagridviewTanken = New System.Windows.Forms.DataGridView()
        Me.DatagridviewReparaturen = New System.Windows.Forms.DataGridView()
        Me.PrintDocumentFormMain = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewFormMain = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialogFormMain = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialogFormMain = New System.Windows.Forms.PageSetupDialog()
        Me.MenustripFormMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.FormMainGroupboxFuelCostsAll.SuspendLayout()
        Me.FormMainGroupboxRepairCostsAll.SuspendLayout()
        Me.FormMainGroupboxDrivenAll.SuspendLayout()
        Me.FormMainGroupboxCostsAll.SuspendLayout()
        Me.FormMainGroupboxAverageConsumptionAll.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FormMainGroupboxFuelCostsYear.SuspendLayout()
        Me.FormMainGroupboxRepairCostsYear.SuspendLayout()
        Me.FormMainGroupboxDrivenYear.SuspendLayout()
        Me.FormMainGroupboxCostsYear.SuspendLayout()
        Me.FormMainGroupboxCarData.SuspendLayout()
        Me.FormMainGroupboxAverageConsumptionYear.SuspendLayout()
        Me.FormMainGroupboxSelectYear.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.DatagridviewTanken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridviewReparaturen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenustripFormMain
        '
        Me.MenustripFormMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuFile, Me.FormMainMenuEdit, Me.FormMainMenuXtras, Me.FormMainMenuHelp})
        Me.MenustripFormMain.Location = New System.Drawing.Point(0, 0)
        Me.MenustripFormMain.Name = "MenustripFormMain"
        Me.MenustripFormMain.Size = New System.Drawing.Size(1254, 24)
        Me.MenustripFormMain.TabIndex = 0
        Me.MenustripFormMain.Text = "MenuStrip1"
        '
        'FormMainMenuFile
        '
        Me.FormMainMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuFileSetupPage, Me.FormMainMenuFilePreview, Me.FormMainMenuFilePrint, Me.ToolStripSeparator1, Me.FormMainMenuFileExit})
        Me.FormMainMenuFile.Name = "FormMainMenuFile"
        Me.FormMainMenuFile.Size = New System.Drawing.Size(79, 20)
        Me.FormMainMenuFile.Text = "MENU_FILE"
        '
        'FormMainMenuFileSetupPage
        '
        Me.FormMainMenuFileSetupPage.Name = "FormMainMenuFileSetupPage"
        Me.FormMainMenuFileSetupPage.Size = New System.Drawing.Size(224, 22)
        Me.FormMainMenuFileSetupPage.Text = "MENU_FILE_SETUP_PAGE"
        '
        'FormMainMenuFilePreview
        '
        Me.FormMainMenuFilePreview.Name = "FormMainMenuFilePreview"
        Me.FormMainMenuFilePreview.Size = New System.Drawing.Size(224, 22)
        Me.FormMainMenuFilePreview.Text = "MENU_FILE_PRINT_PREVIEW"
        '
        'FormMainMenuFilePrint
        '
        Me.FormMainMenuFilePrint.Name = "FormMainMenuFilePrint"
        Me.FormMainMenuFilePrint.Size = New System.Drawing.Size(224, 22)
        Me.FormMainMenuFilePrint.Text = "MENU_FILE_PRINT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'FormMainMenuFileExit
        '
        Me.FormMainMenuFileExit.Name = "FormMainMenuFileExit"
        Me.FormMainMenuFileExit.Size = New System.Drawing.Size(224, 22)
        Me.FormMainMenuFileExit.Text = "MENU_FILE_EXIT"
        '
        'FormMainMenuEdit
        '
        Me.FormMainMenuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuEditNewRefuel, Me.FormMainMenuEditNewRepair, Me.ToolStripMenuItem1, Me.FormMainMenuEditSearch})
        Me.FormMainMenuEdit.Name = "FormMainMenuEdit"
        Me.FormMainMenuEdit.Size = New System.Drawing.Size(82, 20)
        Me.FormMainMenuEdit.Text = "MENU_EDIT"
        '
        'FormMainMenuEditNewRefuel
        '
        Me.FormMainMenuEditNewRefuel.Name = "FormMainMenuEditNewRefuel"
        Me.FormMainMenuEditNewRefuel.Size = New System.Drawing.Size(212, 22)
        Me.FormMainMenuEditNewRefuel.Text = "MENU_EDIT_NEW_REFUEL"
        '
        'FormMainMenuEditNewRepair
        '
        Me.FormMainMenuEditNewRepair.Name = "FormMainMenuEditNewRepair"
        Me.FormMainMenuEditNewRepair.Size = New System.Drawing.Size(212, 22)
        Me.FormMainMenuEditNewRepair.Text = "MENU_EDIT_NEW_REPAIR"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(209, 6)
        '
        'FormMainMenuEditSearch
        '
        Me.FormMainMenuEditSearch.Name = "FormMainMenuEditSearch"
        Me.FormMainMenuEditSearch.Size = New System.Drawing.Size(212, 22)
        Me.FormMainMenuEditSearch.Text = "MENU_EDIT_SEARCH"
        '
        'FormMainMenuXtras
        '
        Me.FormMainMenuXtras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuXtrasExportToPDF, Me.ToolStripMenuItem2, Me.FormMainMenuXtrasSettings})
        Me.FormMainMenuXtras.Name = "FormMainMenuXtras"
        Me.FormMainMenuXtras.Size = New System.Drawing.Size(99, 20)
        Me.FormMainMenuXtras.Text = "MENU_EXTRAS"
        '
        'FormMainMenuXtrasExportToPDF
        '
        Me.FormMainMenuXtrasExportToPDF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuXtrasExportToPDFTableRefuel, Me.FormMainMenuXtrasExportToPDFTableRepair})
        Me.FormMainMenuXtrasExportToPDF.Name = "FormMainMenuXtrasExportToPDF"
        Me.FormMainMenuXtrasExportToPDF.Size = New System.Drawing.Size(247, 22)
        Me.FormMainMenuXtrasExportToPDF.Text = "MENU_EXTRAS_EXPORT_TO_PDF"
        '
        'FormMainMenuXtrasExportToPDFTableRefuel
        '
        Me.FormMainMenuXtrasExportToPDFTableRefuel.Name = "FormMainMenuXtrasExportToPDFTableRefuel"
        Me.FormMainMenuXtrasExportToPDFTableRefuel.Size = New System.Drawing.Size(329, 22)
        Me.FormMainMenuXtrasExportToPDFTableRefuel.Text = "MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REFUEL"
        '
        'FormMainMenuXtrasExportToPDFTableRepair
        '
        Me.FormMainMenuXtrasExportToPDFTableRepair.Name = "FormMainMenuXtrasExportToPDFTableRepair"
        Me.FormMainMenuXtrasExportToPDFTableRepair.Size = New System.Drawing.Size(329, 22)
        Me.FormMainMenuXtrasExportToPDFTableRepair.Text = "MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REPAIR"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(244, 6)
        '
        'FormMainMenuXtrasSettings
        '
        Me.FormMainMenuXtrasSettings.Name = "FormMainMenuXtrasSettings"
        Me.FormMainMenuXtrasSettings.Size = New System.Drawing.Size(247, 22)
        Me.FormMainMenuXtrasSettings.Text = "MENU_EXTRAS_SETTINGS"
        '
        'FormMainMenuHelp
        '
        Me.FormMainMenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMainMenuHelpInfo})
        Me.FormMainMenuHelp.Name = "FormMainMenuHelp"
        Me.FormMainMenuHelp.Size = New System.Drawing.Size(86, 20)
        Me.FormMainMenuHelp.Text = "MENU_HELP"
        '
        'FormMainMenuHelpInfo
        '
        Me.FormMainMenuHelpInfo.Name = "FormMainMenuHelpInfo"
        Me.FormMainMenuHelpInfo.Size = New System.Drawing.Size(173, 22)
        Me.FormMainMenuHelpInfo.Text = "MENU_HELP_INFO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1254, 637)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FormMainGroupboxSelectYear, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(807, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(444, 631)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 94)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(444, 537)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FormMainGroupboxFuelCostsAll, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.FormMainGroupboxRepairCostsAll, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.FormMainGroupboxDrivenAll, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.FormMainGroupboxCostsAll, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.FormMainGroupboxAverageConsumptionAll, 0, 4)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(225, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(216, 531)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'FormMainGroupboxFuelCostsAll
        '
        Me.FormMainGroupboxFuelCostsAll.Controls.Add(Me.FormMainLabelFuelCostsAll)
        Me.FormMainGroupboxFuelCostsAll.Controls.Add(Me.TextboxGesamtkostenBenzin)
        Me.FormMainGroupboxFuelCostsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxFuelCostsAll.Location = New System.Drawing.Point(3, 3)
        Me.FormMainGroupboxFuelCostsAll.Name = "FormMainGroupboxFuelCostsAll"
        Me.FormMainGroupboxFuelCostsAll.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxFuelCostsAll.TabIndex = 0
        Me.FormMainGroupboxFuelCostsAll.TabStop = False
        Me.FormMainGroupboxFuelCostsAll.Text = "Fuel Costs / All"
        '
        'FormMainLabelFuelCostsAll
        '
        Me.FormMainLabelFuelCostsAll.AutoSize = True
        Me.FormMainLabelFuelCostsAll.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelFuelCostsAll.Name = "FormMainLabelFuelCostsAll"
        Me.FormMainLabelFuelCostsAll.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelFuelCostsAll.TabIndex = 1
        Me.FormMainLabelFuelCostsAll.Text = "EUR"
        '
        'TextboxGesamtkostenBenzin
        '
        Me.TextboxGesamtkostenBenzin.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenBenzin.Name = "TextboxGesamtkostenBenzin"
        Me.TextboxGesamtkostenBenzin.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenBenzin.TabIndex = 0
        Me.TextboxGesamtkostenBenzin.TabStop = False
        '
        'FormMainGroupboxRepairCostsAll
        '
        Me.FormMainGroupboxRepairCostsAll.Controls.Add(Me.FormMainLabelRepairCostsAll)
        Me.FormMainGroupboxRepairCostsAll.Controls.Add(Me.TextboxGesamtkostenReparatur)
        Me.FormMainGroupboxRepairCostsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxRepairCostsAll.Location = New System.Drawing.Point(3, 63)
        Me.FormMainGroupboxRepairCostsAll.Name = "FormMainGroupboxRepairCostsAll"
        Me.FormMainGroupboxRepairCostsAll.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxRepairCostsAll.TabIndex = 1
        Me.FormMainGroupboxRepairCostsAll.TabStop = False
        Me.FormMainGroupboxRepairCostsAll.Text = "Repair Costs / All"
        '
        'FormMainLabelRepairCostsAll
        '
        Me.FormMainLabelRepairCostsAll.AutoSize = True
        Me.FormMainLabelRepairCostsAll.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelRepairCostsAll.Name = "FormMainLabelRepairCostsAll"
        Me.FormMainLabelRepairCostsAll.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelRepairCostsAll.TabIndex = 1
        Me.FormMainLabelRepairCostsAll.Text = "EUR"
        '
        'TextboxGesamtkostenReparatur
        '
        Me.TextboxGesamtkostenReparatur.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenReparatur.Name = "TextboxGesamtkostenReparatur"
        Me.TextboxGesamtkostenReparatur.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenReparatur.TabIndex = 0
        Me.TextboxGesamtkostenReparatur.TabStop = False
        '
        'FormMainGroupboxDrivenAll
        '
        Me.FormMainGroupboxDrivenAll.Controls.Add(Me.FormMainLabelDrivenAll)
        Me.FormMainGroupboxDrivenAll.Controls.Add(Me.TextboxGesamtkilometerGefahren)
        Me.FormMainGroupboxDrivenAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxDrivenAll.Location = New System.Drawing.Point(3, 183)
        Me.FormMainGroupboxDrivenAll.Name = "FormMainGroupboxDrivenAll"
        Me.FormMainGroupboxDrivenAll.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxDrivenAll.TabIndex = 2
        Me.FormMainGroupboxDrivenAll.TabStop = False
        Me.FormMainGroupboxDrivenAll.Text = "Driven / All"
        '
        'FormMainLabelDrivenAll
        '
        Me.FormMainLabelDrivenAll.AutoSize = True
        Me.FormMainLabelDrivenAll.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelDrivenAll.Name = "FormMainLabelDrivenAll"
        Me.FormMainLabelDrivenAll.Size = New System.Drawing.Size(22, 13)
        Me.FormMainLabelDrivenAll.TabIndex = 1
        Me.FormMainLabelDrivenAll.Text = "Km"
        '
        'TextboxGesamtkilometerGefahren
        '
        Me.TextboxGesamtkilometerGefahren.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkilometerGefahren.Name = "TextboxGesamtkilometerGefahren"
        Me.TextboxGesamtkilometerGefahren.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkilometerGefahren.TabIndex = 0
        Me.TextboxGesamtkilometerGefahren.TabStop = False
        '
        'FormMainGroupboxCostsAll
        '
        Me.FormMainGroupboxCostsAll.Controls.Add(Me.FormMainLabelCostsAll)
        Me.FormMainGroupboxCostsAll.Controls.Add(Me.TextboxGesamtkostenBezahlt)
        Me.FormMainGroupboxCostsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxCostsAll.Location = New System.Drawing.Point(3, 123)
        Me.FormMainGroupboxCostsAll.Name = "FormMainGroupboxCostsAll"
        Me.FormMainGroupboxCostsAll.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxCostsAll.TabIndex = 3
        Me.FormMainGroupboxCostsAll.TabStop = False
        Me.FormMainGroupboxCostsAll.Text = "Costs / All"
        '
        'FormMainLabelCostsAll
        '
        Me.FormMainLabelCostsAll.AutoSize = True
        Me.FormMainLabelCostsAll.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelCostsAll.Name = "FormMainLabelCostsAll"
        Me.FormMainLabelCostsAll.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelCostsAll.TabIndex = 1
        Me.FormMainLabelCostsAll.Text = "EUR"
        '
        'TextboxGesamtkostenBezahlt
        '
        Me.TextboxGesamtkostenBezahlt.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenBezahlt.Name = "TextboxGesamtkostenBezahlt"
        Me.TextboxGesamtkostenBezahlt.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenBezahlt.TabIndex = 0
        Me.TextboxGesamtkostenBezahlt.TabStop = False
        '
        'FormMainGroupboxAverageConsumptionAll
        '
        Me.FormMainGroupboxAverageConsumptionAll.Controls.Add(Me.FormMainLabelAverageConsumptionAll)
        Me.FormMainGroupboxAverageConsumptionAll.Controls.Add(Me.TextboxGesamterVerbrauch)
        Me.FormMainGroupboxAverageConsumptionAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxAverageConsumptionAll.Location = New System.Drawing.Point(3, 243)
        Me.FormMainGroupboxAverageConsumptionAll.Name = "FormMainGroupboxAverageConsumptionAll"
        Me.FormMainGroupboxAverageConsumptionAll.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxAverageConsumptionAll.TabIndex = 4
        Me.FormMainGroupboxAverageConsumptionAll.TabStop = False
        Me.FormMainGroupboxAverageConsumptionAll.Text = "Average Consumption / All"
        '
        'FormMainLabelAverageConsumptionAll
        '
        Me.FormMainLabelAverageConsumptionAll.AutoSize = True
        Me.FormMainLabelAverageConsumptionAll.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelAverageConsumptionAll.Name = "FormMainLabelAverageConsumptionAll"
        Me.FormMainLabelAverageConsumptionAll.Size = New System.Drawing.Size(68, 13)
        Me.FormMainLabelAverageConsumptionAll.TabIndex = 1
        Me.FormMainLabelAverageConsumptionAll.Text = "Liter/100 Km"
        '
        'TextboxGesamterVerbrauch
        '
        Me.TextboxGesamterVerbrauch.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamterVerbrauch.Name = "TextboxGesamterVerbrauch"
        Me.TextboxGesamterVerbrauch.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamterVerbrauch.TabIndex = 0
        Me.TextboxGesamterVerbrauch.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxFuelCostsYear, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxRepairCostsYear, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxDrivenYear, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxCostsYear, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxCarData, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.FormMainGroupboxAverageConsumptionYear, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.SwitchReparaturen, 0, 7)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 8
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(216, 531)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'FormMainGroupboxFuelCostsYear
        '
        Me.FormMainGroupboxFuelCostsYear.Controls.Add(Me.FormMainLabelFuelCostsYear)
        Me.FormMainGroupboxFuelCostsYear.Controls.Add(Me.TextboxBenzinkostenJahr)
        Me.FormMainGroupboxFuelCostsYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxFuelCostsYear.Location = New System.Drawing.Point(3, 3)
        Me.FormMainGroupboxFuelCostsYear.Name = "FormMainGroupboxFuelCostsYear"
        Me.FormMainGroupboxFuelCostsYear.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxFuelCostsYear.TabIndex = 0
        Me.FormMainGroupboxFuelCostsYear.TabStop = False
        Me.FormMainGroupboxFuelCostsYear.Text = "Fuel Costs / Year"
        '
        'FormMainLabelFuelCostsYear
        '
        Me.FormMainLabelFuelCostsYear.AutoSize = True
        Me.FormMainLabelFuelCostsYear.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelFuelCostsYear.Name = "FormMainLabelFuelCostsYear"
        Me.FormMainLabelFuelCostsYear.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelFuelCostsYear.TabIndex = 1
        Me.FormMainLabelFuelCostsYear.Text = "EUR"
        '
        'TextboxBenzinkostenJahr
        '
        Me.TextboxBenzinkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxBenzinkostenJahr.Name = "TextboxBenzinkostenJahr"
        Me.TextboxBenzinkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxBenzinkostenJahr.TabIndex = 0
        Me.TextboxBenzinkostenJahr.TabStop = False
        '
        'FormMainGroupboxRepairCostsYear
        '
        Me.FormMainGroupboxRepairCostsYear.Controls.Add(Me.FormMainLabelRepairCostsYear)
        Me.FormMainGroupboxRepairCostsYear.Controls.Add(Me.TextboxReparaturkostenJahr)
        Me.FormMainGroupboxRepairCostsYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxRepairCostsYear.Location = New System.Drawing.Point(3, 63)
        Me.FormMainGroupboxRepairCostsYear.Name = "FormMainGroupboxRepairCostsYear"
        Me.FormMainGroupboxRepairCostsYear.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxRepairCostsYear.TabIndex = 1
        Me.FormMainGroupboxRepairCostsYear.TabStop = False
        Me.FormMainGroupboxRepairCostsYear.Text = "Repair Costs / Year"
        '
        'FormMainLabelRepairCostsYear
        '
        Me.FormMainLabelRepairCostsYear.AutoSize = True
        Me.FormMainLabelRepairCostsYear.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelRepairCostsYear.Name = "FormMainLabelRepairCostsYear"
        Me.FormMainLabelRepairCostsYear.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelRepairCostsYear.TabIndex = 1
        Me.FormMainLabelRepairCostsYear.Text = "EUR"
        '
        'TextboxReparaturkostenJahr
        '
        Me.TextboxReparaturkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxReparaturkostenJahr.Name = "TextboxReparaturkostenJahr"
        Me.TextboxReparaturkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxReparaturkostenJahr.TabIndex = 0
        Me.TextboxReparaturkostenJahr.TabStop = False
        '
        'FormMainGroupboxDrivenYear
        '
        Me.FormMainGroupboxDrivenYear.Controls.Add(Me.FormMainLabelDrivenYear)
        Me.FormMainGroupboxDrivenYear.Controls.Add(Me.TextboxKmGefahrenJahr)
        Me.FormMainGroupboxDrivenYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxDrivenYear.Location = New System.Drawing.Point(3, 183)
        Me.FormMainGroupboxDrivenYear.Name = "FormMainGroupboxDrivenYear"
        Me.FormMainGroupboxDrivenYear.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxDrivenYear.TabIndex = 2
        Me.FormMainGroupboxDrivenYear.TabStop = False
        Me.FormMainGroupboxDrivenYear.Text = "Driven / Year"
        '
        'FormMainLabelDrivenYear
        '
        Me.FormMainLabelDrivenYear.AutoSize = True
        Me.FormMainLabelDrivenYear.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelDrivenYear.Name = "FormMainLabelDrivenYear"
        Me.FormMainLabelDrivenYear.Size = New System.Drawing.Size(22, 13)
        Me.FormMainLabelDrivenYear.TabIndex = 1
        Me.FormMainLabelDrivenYear.Text = "Km"
        '
        'TextboxKmGefahrenJahr
        '
        Me.TextboxKmGefahrenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxKmGefahrenJahr.Name = "TextboxKmGefahrenJahr"
        Me.TextboxKmGefahrenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxKmGefahrenJahr.TabIndex = 0
        Me.TextboxKmGefahrenJahr.TabStop = False
        '
        'FormMainGroupboxCostsYear
        '
        Me.FormMainGroupboxCostsYear.Controls.Add(Me.FormMainLabelCostsYear)
        Me.FormMainGroupboxCostsYear.Controls.Add(Me.TextboxGesamtkostenJahr)
        Me.FormMainGroupboxCostsYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxCostsYear.Location = New System.Drawing.Point(3, 123)
        Me.FormMainGroupboxCostsYear.Name = "FormMainGroupboxCostsYear"
        Me.FormMainGroupboxCostsYear.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxCostsYear.TabIndex = 3
        Me.FormMainGroupboxCostsYear.TabStop = False
        Me.FormMainGroupboxCostsYear.Text = "Costs / Year"
        '
        'FormMainLabelCostsYear
        '
        Me.FormMainLabelCostsYear.AutoSize = True
        Me.FormMainLabelCostsYear.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelCostsYear.Name = "FormMainLabelCostsYear"
        Me.FormMainLabelCostsYear.Size = New System.Drawing.Size(30, 13)
        Me.FormMainLabelCostsYear.TabIndex = 1
        Me.FormMainLabelCostsYear.Text = "EUR"
        '
        'TextboxGesamtkostenJahr
        '
        Me.TextboxGesamtkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenJahr.Name = "TextboxGesamtkostenJahr"
        Me.TextboxGesamtkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenJahr.TabIndex = 0
        Me.TextboxGesamtkostenJahr.TabStop = False
        '
        'FormMainGroupboxCarData
        '
        Me.FormMainGroupboxCarData.Controls.Add(Me.textboxAutoAlter)
        Me.FormMainGroupboxCarData.Controls.Add(Me.textboxAutoBaujahr)
        Me.FormMainGroupboxCarData.Controls.Add(Me.FormMainLabelCarAge)
        Me.FormMainGroupboxCarData.Controls.Add(Me.FormMainLabelCarYearOfConstruction)
        Me.FormMainGroupboxCarData.Location = New System.Drawing.Point(3, 363)
        Me.FormMainGroupboxCarData.Name = "FormMainGroupboxCarData"
        Me.FormMainGroupboxCarData.Size = New System.Drawing.Size(210, 114)
        Me.FormMainGroupboxCarData.TabIndex = 4
        Me.FormMainGroupboxCarData.TabStop = False
        Me.FormMainGroupboxCarData.Text = "Car Data"
        '
        'textboxAutoAlter
        '
        Me.textboxAutoAlter.BackColor = System.Drawing.SystemColors.Control
        Me.textboxAutoAlter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxAutoAlter.Location = New System.Drawing.Point(10, 84)
        Me.textboxAutoAlter.Name = "textboxAutoAlter"
        Me.textboxAutoAlter.ReadOnly = True
        Me.textboxAutoAlter.Size = New System.Drawing.Size(190, 13)
        Me.textboxAutoAlter.TabIndex = 3
        Me.textboxAutoAlter.TabStop = False
        Me.textboxAutoAlter.Text = "<Age>"
        '
        'textboxAutoBaujahr
        '
        Me.textboxAutoBaujahr.BackColor = System.Drawing.SystemColors.Control
        Me.textboxAutoBaujahr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxAutoBaujahr.Location = New System.Drawing.Point(10, 44)
        Me.textboxAutoBaujahr.Name = "textboxAutoBaujahr"
        Me.textboxAutoBaujahr.ReadOnly = True
        Me.textboxAutoBaujahr.Size = New System.Drawing.Size(190, 13)
        Me.textboxAutoBaujahr.TabIndex = 2
        Me.textboxAutoBaujahr.TabStop = False
        Me.textboxAutoBaujahr.Text = "<Date of Construction>"
        '
        'FormMainLabelCarAge
        '
        Me.FormMainLabelCarAge.AutoSize = True
        Me.FormMainLabelCarAge.Location = New System.Drawing.Point(7, 65)
        Me.FormMainLabelCarAge.Name = "FormMainLabelCarAge"
        Me.FormMainLabelCarAge.Size = New System.Drawing.Size(26, 13)
        Me.FormMainLabelCarAge.TabIndex = 1
        Me.FormMainLabelCarAge.Text = "Age"
        '
        'FormMainLabelCarYearOfConstruction
        '
        Me.FormMainLabelCarYearOfConstruction.AutoSize = True
        Me.FormMainLabelCarYearOfConstruction.Location = New System.Drawing.Point(7, 25)
        Me.FormMainLabelCarYearOfConstruction.Name = "FormMainLabelCarYearOfConstruction"
        Me.FormMainLabelCarYearOfConstruction.Size = New System.Drawing.Size(104, 13)
        Me.FormMainLabelCarYearOfConstruction.TabIndex = 0
        Me.FormMainLabelCarYearOfConstruction.Text = "Date of Construction"
        '
        'FormMainGroupboxAverageConsumptionYear
        '
        Me.FormMainGroupboxAverageConsumptionYear.Controls.Add(Me.FormMainLabelAverageConsumptionYear)
        Me.FormMainGroupboxAverageConsumptionYear.Controls.Add(Me.TextboxVerbrauchJahr)
        Me.FormMainGroupboxAverageConsumptionYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxAverageConsumptionYear.Location = New System.Drawing.Point(3, 243)
        Me.FormMainGroupboxAverageConsumptionYear.Name = "FormMainGroupboxAverageConsumptionYear"
        Me.FormMainGroupboxAverageConsumptionYear.Size = New System.Drawing.Size(210, 54)
        Me.FormMainGroupboxAverageConsumptionYear.TabIndex = 5
        Me.FormMainGroupboxAverageConsumptionYear.TabStop = False
        Me.FormMainGroupboxAverageConsumptionYear.Text = "Average Consumption / Year"
        '
        'FormMainLabelAverageConsumptionYear
        '
        Me.FormMainLabelAverageConsumptionYear.AutoSize = True
        Me.FormMainLabelAverageConsumptionYear.Location = New System.Drawing.Point(115, 24)
        Me.FormMainLabelAverageConsumptionYear.Name = "FormMainLabelAverageConsumptionYear"
        Me.FormMainLabelAverageConsumptionYear.Size = New System.Drawing.Size(68, 13)
        Me.FormMainLabelAverageConsumptionYear.TabIndex = 1
        Me.FormMainLabelAverageConsumptionYear.Text = "Liter/100 Km"
        '
        'TextboxVerbrauchJahr
        '
        Me.TextboxVerbrauchJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxVerbrauchJahr.Name = "TextboxVerbrauchJahr"
        Me.TextboxVerbrauchJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxVerbrauchJahr.TabIndex = 0
        Me.TextboxVerbrauchJahr.TabStop = False
        '
        'SwitchReparaturen
        '
        Me.SwitchReparaturen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SwitchReparaturen.Location = New System.Drawing.Point(3, 505)
        Me.SwitchReparaturen.Name = "SwitchReparaturen"
        Me.SwitchReparaturen.Size = New System.Drawing.Size(140, 23)
        Me.SwitchReparaturen.TabIndex = 6
        Me.SwitchReparaturen.TabStop = False
        Me.SwitchReparaturen.Text = "Show Repairs >>"
        Me.SwitchReparaturen.UseVisualStyleBackColor = True
        '
        'FormMainGroupboxSelectYear
        '
        Me.FormMainGroupboxSelectYear.Controls.Add(Me.TableLayoutPanel6)
        Me.FormMainGroupboxSelectYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormMainGroupboxSelectYear.Location = New System.Drawing.Point(6, 3)
        Me.FormMainGroupboxSelectYear.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.FormMainGroupboxSelectYear.Name = "FormMainGroupboxSelectYear"
        Me.FormMainGroupboxSelectYear.Size = New System.Drawing.Size(432, 88)
        Me.FormMainGroupboxSelectYear.TabIndex = 1
        Me.FormMainGroupboxSelectYear.TabStop = False
        Me.FormMainGroupboxSelectYear.Text = "Select Year:"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.ComboboxJahrAuswahl, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(426, 69)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'ComboboxJahrAuswahl
        '
        Me.ComboboxJahrAuswahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboboxJahrAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboboxJahrAuswahl.FormattingEnabled = True
        Me.ComboboxJahrAuswahl.IntegralHeight = False
        Me.ComboboxJahrAuswahl.ItemHeight = 13
        Me.ComboboxJahrAuswahl.Location = New System.Drawing.Point(231, 6)
        Me.ComboboxJahrAuswahl.Margin = New System.Windows.Forms.Padding(6, 6, 5, 3)
        Me.ComboboxJahrAuswahl.Name = "ComboboxJahrAuswahl"
        Me.ComboboxJahrAuswahl.Size = New System.Drawing.Size(190, 21)
        Me.ComboboxJahrAuswahl.TabIndex = 0
        Me.ComboboxJahrAuswahl.TabStop = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.FormMainLabelNumberOfDataRecords, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TextboxJahrDatensaetze, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 34)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(426, 35)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'FormMainLabelNumberOfDataRecords
        '
        Me.FormMainLabelNumberOfDataRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormMainLabelNumberOfDataRecords.AutoSize = True
        Me.FormMainLabelNumberOfDataRecords.Location = New System.Drawing.Point(98, 10)
        Me.FormMainLabelNumberOfDataRecords.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.FormMainLabelNumberOfDataRecords.Name = "FormMainLabelNumberOfDataRecords"
        Me.FormMainLabelNumberOfDataRecords.Size = New System.Drawing.Size(125, 13)
        Me.FormMainLabelNumberOfDataRecords.TabIndex = 0
        Me.FormMainLabelNumberOfDataRecords.Text = "Number of Data Records"
        '
        'TextboxJahrDatensaetze
        '
        Me.TextboxJahrDatensaetze.Enabled = False
        Me.TextboxJahrDatensaetze.Location = New System.Drawing.Point(231, 7)
        Me.TextboxJahrDatensaetze.Margin = New System.Windows.Forms.Padding(5, 7, 3, 3)
        Me.TextboxJahrDatensaetze.Name = "TextboxJahrDatensaetze"
        Me.TextboxJahrDatensaetze.ReadOnly = True
        Me.TextboxJahrDatensaetze.Size = New System.Drawing.Size(190, 20)
        Me.TextboxJahrDatensaetze.TabIndex = 1
        Me.TextboxJahrDatensaetze.TabStop = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 648.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.DatagridviewTanken, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.DatagridviewReparaturen, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(798, 631)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'DatagridviewTanken
        '
        Me.DatagridviewTanken.AllowUserToAddRows = False
        Me.DatagridviewTanken.AllowUserToDeleteRows = False
        Me.DatagridviewTanken.AllowUserToResizeRows = False
        Me.DatagridviewTanken.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DatagridviewTanken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridviewTanken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewTanken.Location = New System.Drawing.Point(3, 3)
        Me.DatagridviewTanken.MultiSelect = False
        Me.DatagridviewTanken.Name = "DatagridviewTanken"
        Me.DatagridviewTanken.ReadOnly = True
        Me.DatagridviewTanken.RowHeadersVisible = False
        Me.DatagridviewTanken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridviewTanken.Size = New System.Drawing.Size(794, 625)
        Me.DatagridviewTanken.TabIndex = 1
        Me.DatagridviewTanken.TabStop = False
        '
        'DatagridviewReparaturen
        '
        Me.DatagridviewReparaturen.AllowUserToAddRows = False
        Me.DatagridviewReparaturen.AllowUserToDeleteRows = False
        Me.DatagridviewReparaturen.AllowUserToResizeRows = False
        Me.DatagridviewReparaturen.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DatagridviewReparaturen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridviewReparaturen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewReparaturen.Location = New System.Drawing.Point(803, 3)
        Me.DatagridviewReparaturen.MultiSelect = False
        Me.DatagridviewReparaturen.Name = "DatagridviewReparaturen"
        Me.DatagridviewReparaturen.ReadOnly = True
        Me.DatagridviewReparaturen.RowHeadersVisible = False
        Me.DatagridviewReparaturen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridviewReparaturen.Size = New System.Drawing.Size(642, 625)
        Me.DatagridviewReparaturen.TabIndex = 2
        Me.DatagridviewReparaturen.TabStop = False
        '
        'PrintDocumentFormMain
        '
        '
        'PrintPreviewFormMain
        '
        Me.PrintPreviewFormMain.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewFormMain.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewFormMain.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewFormMain.Enabled = True
        Me.PrintPreviewFormMain.Icon = CType(resources.GetObject("PrintPreviewFormMain.Icon"), System.Drawing.Icon)
        Me.PrintPreviewFormMain.Name = "printPreviewFormMain"
        Me.PrintPreviewFormMain.Visible = False
        '
        'PrintDialogFormMain
        '
        Me.PrintDialogFormMain.UseEXDialog = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 661)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenustripFormMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenustripFormMain
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1270, 700)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TankManager"
        Me.MenustripFormMain.ResumeLayout(False)
        Me.MenustripFormMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.FormMainGroupboxFuelCostsAll.ResumeLayout(False)
        Me.FormMainGroupboxFuelCostsAll.PerformLayout()
        Me.FormMainGroupboxRepairCostsAll.ResumeLayout(False)
        Me.FormMainGroupboxRepairCostsAll.PerformLayout()
        Me.FormMainGroupboxDrivenAll.ResumeLayout(False)
        Me.FormMainGroupboxDrivenAll.PerformLayout()
        Me.FormMainGroupboxCostsAll.ResumeLayout(False)
        Me.FormMainGroupboxCostsAll.PerformLayout()
        Me.FormMainGroupboxAverageConsumptionAll.ResumeLayout(False)
        Me.FormMainGroupboxAverageConsumptionAll.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.FormMainGroupboxFuelCostsYear.ResumeLayout(False)
        Me.FormMainGroupboxFuelCostsYear.PerformLayout()
        Me.FormMainGroupboxRepairCostsYear.ResumeLayout(False)
        Me.FormMainGroupboxRepairCostsYear.PerformLayout()
        Me.FormMainGroupboxDrivenYear.ResumeLayout(False)
        Me.FormMainGroupboxDrivenYear.PerformLayout()
        Me.FormMainGroupboxCostsYear.ResumeLayout(False)
        Me.FormMainGroupboxCostsYear.PerformLayout()
        Me.FormMainGroupboxCarData.ResumeLayout(False)
        Me.FormMainGroupboxCarData.PerformLayout()
        Me.FormMainGroupboxAverageConsumptionYear.ResumeLayout(False)
        Me.FormMainGroupboxAverageConsumptionYear.PerformLayout()
        Me.FormMainGroupboxSelectYear.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.DatagridviewTanken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridviewReparaturen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenustripFormMain As MenuStrip
    Friend WithEvents FormMainMenuFile As ToolStripMenuItem
    Friend WithEvents FormMainMenuFileExit As ToolStripMenuItem
    Friend WithEvents FormMainMenuEdit As ToolStripMenuItem
    Friend WithEvents FormMainMenuEditNewRefuel As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FormMainMenuEditSearch As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtras As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents FormMainMenuXtrasSettings As ToolStripMenuItem
    Friend WithEvents FormMainMenuHelp As ToolStripMenuItem
    Friend WithEvents FormMainMenuHelpInfo As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DatagridviewTanken As DataGridView
    Friend WithEvents FormMainGroupboxSelectYear As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ComboboxJahrAuswahl As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents FormMainLabelNumberOfDataRecords As Label
    Friend WithEvents TextboxJahrDatensaetze As TextBox
    Friend WithEvents FormMainGroupboxFuelCostsAll As GroupBox
    Friend WithEvents FormMainGroupboxRepairCostsAll As GroupBox
    Friend WithEvents FormMainGroupboxDrivenAll As GroupBox
    Friend WithEvents FormMainGroupboxCostsAll As GroupBox
    Friend WithEvents FormMainGroupboxFuelCostsYear As GroupBox
    Friend WithEvents FormMainGroupboxRepairCostsYear As GroupBox
    Friend WithEvents FormMainGroupboxDrivenYear As GroupBox
    Friend WithEvents FormMainGroupboxCostsYear As GroupBox
    Friend WithEvents TextboxGesamtkostenBenzin As TextBox
    Friend WithEvents TextboxGesamtkostenReparatur As TextBox
    Friend WithEvents TextboxGesamtkilometerGefahren As TextBox
    Friend WithEvents TextboxGesamtkostenBezahlt As TextBox
    Friend WithEvents TextboxBenzinkostenJahr As TextBox
    Friend WithEvents TextboxReparaturkostenJahr As TextBox
    Friend WithEvents TextboxKmGefahrenJahr As TextBox
    Friend WithEvents TextboxGesamtkostenJahr As TextBox
    Friend WithEvents FormMainLabelFuelCostsAll As Label
    Friend WithEvents FormMainLabelRepairCostsAll As Label
    Friend WithEvents FormMainLabelDrivenAll As Label
    Friend WithEvents FormMainLabelCostsAll As Label
    Friend WithEvents FormMainLabelFuelCostsYear As Label
    Friend WithEvents FormMainLabelRepairCostsYear As Label
    Friend WithEvents FormMainLabelDrivenYear As Label
    Friend WithEvents FormMainLabelCostsYear As Label
    Friend WithEvents FormMainGroupboxCarData As GroupBox
    Friend WithEvents textboxAutoAlter As TextBox
    Friend WithEvents textboxAutoBaujahr As TextBox
    Friend WithEvents FormMainLabelCarAge As Label
    Friend WithEvents FormMainLabelCarYearOfConstruction As Label
    Friend WithEvents FormMainMenuFilePrint As ToolStripMenuItem
    Friend WithEvents FormMainMenuEditNewRepair As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtrasExportToPDF As ToolStripMenuItem
    Friend WithEvents FormMainMenuFilePreview As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintDocumentFormMain As Printing.PrintDocument
    Friend WithEvents PrintPreviewFormMain As PrintPreviewDialog
    Friend WithEvents PrintDialogFormMain As PrintDialog
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents DatagridviewReparaturen As DataGridView
    Friend WithEvents FormMainGroupboxAverageConsumptionAll As GroupBox
    Friend WithEvents FormMainLabelAverageConsumptionAll As Label
    Friend WithEvents TextboxGesamterVerbrauch As TextBox
    Friend WithEvents FormMainGroupboxAverageConsumptionYear As GroupBox
    Friend WithEvents FormMainLabelAverageConsumptionYear As Label
    Friend WithEvents TextboxVerbrauchJahr As TextBox
    Friend WithEvents SwitchReparaturen As Button
    Friend WithEvents PageSetupDialogFormMain As PageSetupDialog
    Friend WithEvents FormMainMenuFileSetupPage As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtrasExportToPDFTableRefuel As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtrasExportToPDFTableRepair As ToolStripMenuItem
End Class
