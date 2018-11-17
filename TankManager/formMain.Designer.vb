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
        Me.groupboxGesamtkostenBenzin = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenBenzin = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenReparatur = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenReparatur = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkilometerGefahren = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextboxGesamtkilometerGefahren = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenBezahlt = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenBezahlt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextboxGesamterVerbrauch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxBenzinkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextboxBenzinkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxReparaturkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextboxReparaturkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxKmGefahrenJahr = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextboxKmGefahrenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextboxGesamtkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxAutoDaten = New System.Windows.Forms.GroupBox()
        Me.textboxAutoAlter = New System.Windows.Forms.TextBox()
        Me.textboxAutoBaujahr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextboxVerbrauchJahr = New System.Windows.Forms.TextBox()
        Me.SwitchReparaturen = New System.Windows.Forms.Button()
        Me.groupboxJahrAuswahl = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboboxJahrAuswahl = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.groupboxGesamtkostenBenzin.SuspendLayout()
        Me.groupboxGesamtkostenReparatur.SuspendLayout()
        Me.groupboxGesamtkilometerGefahren.SuspendLayout()
        Me.groupboxGesamtkostenBezahlt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.groupboxBenzinkostenJahr.SuspendLayout()
        Me.groupboxReparaturkostenJahr.SuspendLayout()
        Me.groupboxKmGefahrenJahr.SuspendLayout()
        Me.groupboxGesamtkostenJahr.SuspendLayout()
        Me.groupboxAutoDaten.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupboxJahrAuswahl.SuspendLayout()
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
        Me.TableLayoutPanel2.Controls.Add(Me.groupboxJahrAuswahl, 0, 0)
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
        Me.TableLayoutPanel5.Controls.Add(Me.groupboxGesamtkostenBenzin, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.groupboxGesamtkostenReparatur, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.groupboxGesamtkilometerGefahren, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.groupboxGesamtkostenBezahlt, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 0, 4)
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
        'groupboxGesamtkostenBenzin
        '
        Me.groupboxGesamtkostenBenzin.Controls.Add(Me.Label6)
        Me.groupboxGesamtkostenBenzin.Controls.Add(Me.TextboxGesamtkostenBenzin)
        Me.groupboxGesamtkostenBenzin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxGesamtkostenBenzin.Location = New System.Drawing.Point(3, 3)
        Me.groupboxGesamtkostenBenzin.Name = "groupboxGesamtkostenBenzin"
        Me.groupboxGesamtkostenBenzin.Size = New System.Drawing.Size(210, 54)
        Me.groupboxGesamtkostenBenzin.TabIndex = 0
        Me.groupboxGesamtkostenBenzin.TabStop = False
        Me.groupboxGesamtkostenBenzin.Text = "Gesamtkosten Benzin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "EUR"
        '
        'TextboxGesamtkostenBenzin
        '
        Me.TextboxGesamtkostenBenzin.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenBenzin.Name = "TextboxGesamtkostenBenzin"
        Me.TextboxGesamtkostenBenzin.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenBenzin.TabIndex = 0
        Me.TextboxGesamtkostenBenzin.TabStop = False
        '
        'groupboxGesamtkostenReparatur
        '
        Me.groupboxGesamtkostenReparatur.Controls.Add(Me.Label7)
        Me.groupboxGesamtkostenReparatur.Controls.Add(Me.TextboxGesamtkostenReparatur)
        Me.groupboxGesamtkostenReparatur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxGesamtkostenReparatur.Location = New System.Drawing.Point(3, 63)
        Me.groupboxGesamtkostenReparatur.Name = "groupboxGesamtkostenReparatur"
        Me.groupboxGesamtkostenReparatur.Size = New System.Drawing.Size(210, 54)
        Me.groupboxGesamtkostenReparatur.TabIndex = 1
        Me.groupboxGesamtkostenReparatur.TabStop = False
        Me.groupboxGesamtkostenReparatur.Text = "Gesamtkosten Reparatur:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "EUR"
        '
        'TextboxGesamtkostenReparatur
        '
        Me.TextboxGesamtkostenReparatur.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenReparatur.Name = "TextboxGesamtkostenReparatur"
        Me.TextboxGesamtkostenReparatur.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenReparatur.TabIndex = 0
        Me.TextboxGesamtkostenReparatur.TabStop = False
        '
        'groupboxGesamtkilometerGefahren
        '
        Me.groupboxGesamtkilometerGefahren.Controls.Add(Me.Label8)
        Me.groupboxGesamtkilometerGefahren.Controls.Add(Me.TextboxGesamtkilometerGefahren)
        Me.groupboxGesamtkilometerGefahren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxGesamtkilometerGefahren.Location = New System.Drawing.Point(3, 183)
        Me.groupboxGesamtkilometerGefahren.Name = "groupboxGesamtkilometerGefahren"
        Me.groupboxGesamtkilometerGefahren.Size = New System.Drawing.Size(210, 54)
        Me.groupboxGesamtkilometerGefahren.TabIndex = 2
        Me.groupboxGesamtkilometerGefahren.TabStop = False
        Me.groupboxGesamtkilometerGefahren.Text = "Gesamtkilometer gefahren:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Km"
        '
        'TextboxGesamtkilometerGefahren
        '
        Me.TextboxGesamtkilometerGefahren.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkilometerGefahren.Name = "TextboxGesamtkilometerGefahren"
        Me.TextboxGesamtkilometerGefahren.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkilometerGefahren.TabIndex = 0
        Me.TextboxGesamtkilometerGefahren.TabStop = False
        '
        'groupboxGesamtkostenBezahlt
        '
        Me.groupboxGesamtkostenBezahlt.Controls.Add(Me.Label9)
        Me.groupboxGesamtkostenBezahlt.Controls.Add(Me.TextboxGesamtkostenBezahlt)
        Me.groupboxGesamtkostenBezahlt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxGesamtkostenBezahlt.Location = New System.Drawing.Point(3, 123)
        Me.groupboxGesamtkostenBezahlt.Name = "groupboxGesamtkostenBezahlt"
        Me.groupboxGesamtkostenBezahlt.Size = New System.Drawing.Size(210, 54)
        Me.groupboxGesamtkostenBezahlt.TabIndex = 3
        Me.groupboxGesamtkostenBezahlt.TabStop = False
        Me.groupboxGesamtkostenBezahlt.Text = "Gesamtkosten bezahlt:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "EUR"
        '
        'TextboxGesamtkostenBezahlt
        '
        Me.TextboxGesamtkostenBezahlt.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenBezahlt.Name = "TextboxGesamtkostenBezahlt"
        Me.TextboxGesamtkostenBezahlt.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenBezahlt.TabIndex = 0
        Me.TextboxGesamtkostenBezahlt.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextboxGesamterVerbrauch)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 54)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "gesamter durchschnittlicher Verbrauch"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Liter/100 Km"
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
        Me.TableLayoutPanel4.Controls.Add(Me.groupboxBenzinkostenJahr, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.groupboxReparaturkostenJahr, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.groupboxKmGefahrenJahr, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.groupboxGesamtkostenJahr, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.groupboxAutoDaten, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 4)
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
        'groupboxBenzinkostenJahr
        '
        Me.groupboxBenzinkostenJahr.Controls.Add(Me.Label2)
        Me.groupboxBenzinkostenJahr.Controls.Add(Me.TextboxBenzinkostenJahr)
        Me.groupboxBenzinkostenJahr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxBenzinkostenJahr.Location = New System.Drawing.Point(3, 3)
        Me.groupboxBenzinkostenJahr.Name = "groupboxBenzinkostenJahr"
        Me.groupboxBenzinkostenJahr.Size = New System.Drawing.Size(210, 54)
        Me.groupboxBenzinkostenJahr.TabIndex = 0
        Me.groupboxBenzinkostenJahr.TabStop = False
        Me.groupboxBenzinkostenJahr.Text = "Benzinkosten/Jahr:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EUR"
        '
        'TextboxBenzinkostenJahr
        '
        Me.TextboxBenzinkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxBenzinkostenJahr.Name = "TextboxBenzinkostenJahr"
        Me.TextboxBenzinkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxBenzinkostenJahr.TabIndex = 0
        Me.TextboxBenzinkostenJahr.TabStop = False
        '
        'groupboxReparaturkostenJahr
        '
        Me.groupboxReparaturkostenJahr.Controls.Add(Me.Label3)
        Me.groupboxReparaturkostenJahr.Controls.Add(Me.TextboxReparaturkostenJahr)
        Me.groupboxReparaturkostenJahr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxReparaturkostenJahr.Location = New System.Drawing.Point(3, 63)
        Me.groupboxReparaturkostenJahr.Name = "groupboxReparaturkostenJahr"
        Me.groupboxReparaturkostenJahr.Size = New System.Drawing.Size(210, 54)
        Me.groupboxReparaturkostenJahr.TabIndex = 1
        Me.groupboxReparaturkostenJahr.TabStop = False
        Me.groupboxReparaturkostenJahr.Text = "Reparaturkosten/Jahr:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "EUR"
        '
        'TextboxReparaturkostenJahr
        '
        Me.TextboxReparaturkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxReparaturkostenJahr.Name = "TextboxReparaturkostenJahr"
        Me.TextboxReparaturkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxReparaturkostenJahr.TabIndex = 0
        Me.TextboxReparaturkostenJahr.TabStop = False
        '
        'groupboxKmGefahrenJahr
        '
        Me.groupboxKmGefahrenJahr.Controls.Add(Me.Label4)
        Me.groupboxKmGefahrenJahr.Controls.Add(Me.TextboxKmGefahrenJahr)
        Me.groupboxKmGefahrenJahr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxKmGefahrenJahr.Location = New System.Drawing.Point(3, 183)
        Me.groupboxKmGefahrenJahr.Name = "groupboxKmGefahrenJahr"
        Me.groupboxKmGefahrenJahr.Size = New System.Drawing.Size(210, 54)
        Me.groupboxKmGefahrenJahr.TabIndex = 2
        Me.groupboxKmGefahrenJahr.TabStop = False
        Me.groupboxKmGefahrenJahr.Text = "Km gefahren/Jahr:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Km"
        '
        'TextboxKmGefahrenJahr
        '
        Me.TextboxKmGefahrenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxKmGefahrenJahr.Name = "TextboxKmGefahrenJahr"
        Me.TextboxKmGefahrenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxKmGefahrenJahr.TabIndex = 0
        Me.TextboxKmGefahrenJahr.TabStop = False
        '
        'groupboxGesamtkostenJahr
        '
        Me.groupboxGesamtkostenJahr.Controls.Add(Me.Label5)
        Me.groupboxGesamtkostenJahr.Controls.Add(Me.TextboxGesamtkostenJahr)
        Me.groupboxGesamtkostenJahr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxGesamtkostenJahr.Location = New System.Drawing.Point(3, 123)
        Me.groupboxGesamtkostenJahr.Name = "groupboxGesamtkostenJahr"
        Me.groupboxGesamtkostenJahr.Size = New System.Drawing.Size(210, 54)
        Me.groupboxGesamtkostenJahr.TabIndex = 3
        Me.groupboxGesamtkostenJahr.TabStop = False
        Me.groupboxGesamtkostenJahr.Text = "Gesamtkosten/Jahr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "EUR"
        '
        'TextboxGesamtkostenJahr
        '
        Me.TextboxGesamtkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.TextboxGesamtkostenJahr.Name = "TextboxGesamtkostenJahr"
        Me.TextboxGesamtkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.TextboxGesamtkostenJahr.TabIndex = 0
        Me.TextboxGesamtkostenJahr.TabStop = False
        '
        'groupboxAutoDaten
        '
        Me.groupboxAutoDaten.Controls.Add(Me.textboxAutoAlter)
        Me.groupboxAutoDaten.Controls.Add(Me.textboxAutoBaujahr)
        Me.groupboxAutoDaten.Controls.Add(Me.Label11)
        Me.groupboxAutoDaten.Controls.Add(Me.Label10)
        Me.groupboxAutoDaten.Location = New System.Drawing.Point(3, 363)
        Me.groupboxAutoDaten.Name = "groupboxAutoDaten"
        Me.groupboxAutoDaten.Size = New System.Drawing.Size(210, 114)
        Me.groupboxAutoDaten.TabIndex = 4
        Me.groupboxAutoDaten.TabStop = False
        Me.groupboxAutoDaten.Text = "Daten des Autos:"
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
        Me.textboxAutoAlter.Text = "<Alter>"
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
        Me.textboxAutoBaujahr.Text = "<Baujahr>"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Alter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Baujahr"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextboxVerbrauchJahr)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 54)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "durchschnittlicher Verbrauch/Jahr:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(115, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Liter/100 Km"
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
        Me.SwitchReparaturen.Text = "Reparaturen anzeigen >>"
        Me.SwitchReparaturen.UseVisualStyleBackColor = True
        '
        'groupboxJahrAuswahl
        '
        Me.groupboxJahrAuswahl.Controls.Add(Me.TableLayoutPanel6)
        Me.groupboxJahrAuswahl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxJahrAuswahl.Location = New System.Drawing.Point(6, 3)
        Me.groupboxJahrAuswahl.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.groupboxJahrAuswahl.Name = "groupboxJahrAuswahl"
        Me.groupboxJahrAuswahl.Size = New System.Drawing.Size(432, 88)
        Me.groupboxJahrAuswahl.TabIndex = 1
        Me.groupboxJahrAuswahl.TabStop = False
        Me.groupboxJahrAuswahl.Text = "Jahr auswählen:"
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
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 0)
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anzahl Datensätze:"
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
        Me.groupboxGesamtkostenBenzin.ResumeLayout(False)
        Me.groupboxGesamtkostenBenzin.PerformLayout()
        Me.groupboxGesamtkostenReparatur.ResumeLayout(False)
        Me.groupboxGesamtkostenReparatur.PerformLayout()
        Me.groupboxGesamtkilometerGefahren.ResumeLayout(False)
        Me.groupboxGesamtkilometerGefahren.PerformLayout()
        Me.groupboxGesamtkostenBezahlt.ResumeLayout(False)
        Me.groupboxGesamtkostenBezahlt.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.groupboxBenzinkostenJahr.ResumeLayout(False)
        Me.groupboxBenzinkostenJahr.PerformLayout()
        Me.groupboxReparaturkostenJahr.ResumeLayout(False)
        Me.groupboxReparaturkostenJahr.PerformLayout()
        Me.groupboxKmGefahrenJahr.ResumeLayout(False)
        Me.groupboxKmGefahrenJahr.PerformLayout()
        Me.groupboxGesamtkostenJahr.ResumeLayout(False)
        Me.groupboxGesamtkostenJahr.PerformLayout()
        Me.groupboxAutoDaten.ResumeLayout(False)
        Me.groupboxAutoDaten.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupboxJahrAuswahl.ResumeLayout(False)
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
    Friend WithEvents groupboxJahrAuswahl As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ComboboxJahrAuswahl As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextboxJahrDatensaetze As TextBox
    Friend WithEvents groupboxGesamtkostenBenzin As GroupBox
    Friend WithEvents groupboxGesamtkostenReparatur As GroupBox
    Friend WithEvents groupboxGesamtkilometerGefahren As GroupBox
    Friend WithEvents groupboxGesamtkostenBezahlt As GroupBox
    Friend WithEvents groupboxBenzinkostenJahr As GroupBox
    Friend WithEvents groupboxReparaturkostenJahr As GroupBox
    Friend WithEvents groupboxKmGefahrenJahr As GroupBox
    Friend WithEvents groupboxGesamtkostenJahr As GroupBox
    Friend WithEvents TextboxGesamtkostenBenzin As TextBox
    Friend WithEvents TextboxGesamtkostenReparatur As TextBox
    Friend WithEvents TextboxGesamtkilometerGefahren As TextBox
    Friend WithEvents TextboxGesamtkostenBezahlt As TextBox
    Friend WithEvents TextboxBenzinkostenJahr As TextBox
    Friend WithEvents TextboxReparaturkostenJahr As TextBox
    Friend WithEvents TextboxKmGefahrenJahr As TextBox
    Friend WithEvents TextboxGesamtkostenJahr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents groupboxAutoDaten As GroupBox
    Friend WithEvents textboxAutoAlter As TextBox
    Friend WithEvents textboxAutoBaujahr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextboxGesamterVerbrauch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextboxVerbrauchJahr As TextBox
    Friend WithEvents SwitchReparaturen As Button
    Friend WithEvents PageSetupDialogFormMain As PageSetupDialog
    Friend WithEvents FormMainMenuFileSetupPage As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtrasExportToPDFTableRefuel As ToolStripMenuItem
    Friend WithEvents FormMainMenuXtrasExportToPDFTableRepair As ToolStripMenuItem
End Class
