<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.menustripFormMain = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeiteEinrichtenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckvorschauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeueTankquittungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeueReparaturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExtrasExportToPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExtrasExportToPdfDgvRefuel = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExtrasExportToPdfDgvRepair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxGesamtkostenBenzin = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textboxGesamtkostenBenzin = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenReparatur = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textboxGesamtkostenReparatur = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkilometerGefahren = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textboxGesamtkilometerGefahren = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenBezahlt = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textboxGesamtkostenBezahlt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textboxGesamterVerbrauch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxBenzinkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxBenzinkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxReparaturkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxReparaturkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxKmGefahrenJahr = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxKmGefahrenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxGesamtkostenJahr = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textboxGesamtkostenJahr = New System.Windows.Forms.TextBox()
        Me.groupboxAutoDaten = New System.Windows.Forms.GroupBox()
        Me.textboxAutoAlter = New System.Windows.Forms.TextBox()
        Me.textboxAutoBaujahr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textboxVerbrauchJahr = New System.Windows.Forms.TextBox()
        Me.switchReparaturen = New System.Windows.Forms.Button()
        Me.groupboxJahrAuswahl = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.comboboxJahrAuswahl = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textboxJahrDatensaetze = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridviewTanken = New System.Windows.Forms.DataGridView()
        Me.datagridviewReparaturen = New System.Windows.Forms.DataGridView()
        Me.printDocumentFormMain = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewFormMain = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDialogFormMain = New System.Windows.Forms.PrintDialog()
        Me.pageSetupDialogFormMain = New System.Windows.Forms.PageSetupDialog()
        Me.menustripFormMain.SuspendLayout()
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
        CType(Me.datagridviewTanken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridviewReparaturen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menustripFormMain
        '
        Me.menustripFormMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EditToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.menustripFormMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripFormMain.Name = "menustripFormMain"
        Me.menustripFormMain.Size = New System.Drawing.Size(1254, 24)
        Me.menustripFormMain.TabIndex = 0
        Me.menustripFormMain.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeiteEinrichtenToolStripMenuItem, Me.DruckvorschauToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.ToolStripSeparator1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'SeiteEinrichtenToolStripMenuItem
        '
        Me.SeiteEinrichtenToolStripMenuItem.Name = "SeiteEinrichtenToolStripMenuItem"
        Me.SeiteEinrichtenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SeiteEinrichtenToolStripMenuItem.Text = "S&eite Einrichten"
        '
        'DruckvorschauToolStripMenuItem
        '
        Me.DruckvorschauToolStripMenuItem.Name = "DruckvorschauToolStripMenuItem"
        Me.DruckvorschauToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DruckvorschauToolStripMenuItem.Text = "Druck&vorschau"
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeueTankquittungToolStripMenuItem, Me.NeueReparaturToolStripMenuItem, Me.ToolStripMenuItem1, Me.SuchenToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.EditToolStripMenuItem.Text = "&Bearbeiten"
        '
        'NeueTankquittungToolStripMenuItem
        '
        Me.NeueTankquittungToolStripMenuItem.Name = "NeueTankquittungToolStripMenuItem"
        Me.NeueTankquittungToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NeueTankquittungToolStripMenuItem.Text = "Neue Tank&quittung eingeben"
        '
        'NeueReparaturToolStripMenuItem
        '
        Me.NeueReparaturToolStripMenuItem.Name = "NeueReparaturToolStripMenuItem"
        Me.NeueReparaturToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NeueReparaturToolStripMenuItem.Text = "Neue &Reparatur eintragen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 6)
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExtrasExportToPdf, Me.ToolStripMenuItem2, Me.EinstellungenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'MenuExtrasExportToPdf
        '
        Me.MenuExtrasExportToPdf.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExtrasExportToPdfDgvRefuel, Me.MenuExtrasExportToPdfDgvRepair})
        Me.MenuExtrasExportToPdf.Name = "MenuExtrasExportToPdf"
        Me.MenuExtrasExportToPdf.Size = New System.Drawing.Size(180, 22)
        Me.MenuExtrasExportToPdf.Text = "Export to PDF"
        '
        'MenuExtrasExportToPdfDgvRefuel
        '
        Me.MenuExtrasExportToPdfDgvRefuel.Name = "MenuExtrasExportToPdfDgvRefuel"
        Me.MenuExtrasExportToPdfDgvRefuel.Size = New System.Drawing.Size(180, 22)
        Me.MenuExtrasExportToPdfDgvRefuel.Text = "Table Refuel"
        '
        'MenuExtrasExportToPdfDgvRepair
        '
        Me.MenuExtrasExportToPdfDgvRepair.Name = "MenuExtrasExportToPdfDgvRepair"
        Me.MenuExtrasExportToPdfDgvRepair.Size = New System.Drawing.Size(180, 22)
        Me.MenuExtrasExportToPdfDgvRepair.Text = "Table Repair"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EinstellungenToolStripMenuItem.Text = "&Einstellungen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "&Info"
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
        Me.groupboxGesamtkostenBenzin.Controls.Add(Me.textboxGesamtkostenBenzin)
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
        'textboxGesamtkostenBenzin
        '
        Me.textboxGesamtkostenBenzin.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamtkostenBenzin.Name = "textboxGesamtkostenBenzin"
        Me.textboxGesamtkostenBenzin.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamtkostenBenzin.TabIndex = 0
        Me.textboxGesamtkostenBenzin.TabStop = False
        '
        'groupboxGesamtkostenReparatur
        '
        Me.groupboxGesamtkostenReparatur.Controls.Add(Me.Label7)
        Me.groupboxGesamtkostenReparatur.Controls.Add(Me.textboxGesamtkostenReparatur)
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
        'textboxGesamtkostenReparatur
        '
        Me.textboxGesamtkostenReparatur.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamtkostenReparatur.Name = "textboxGesamtkostenReparatur"
        Me.textboxGesamtkostenReparatur.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamtkostenReparatur.TabIndex = 0
        Me.textboxGesamtkostenReparatur.TabStop = False
        '
        'groupboxGesamtkilometerGefahren
        '
        Me.groupboxGesamtkilometerGefahren.Controls.Add(Me.Label8)
        Me.groupboxGesamtkilometerGefahren.Controls.Add(Me.textboxGesamtkilometerGefahren)
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
        'textboxGesamtkilometerGefahren
        '
        Me.textboxGesamtkilometerGefahren.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamtkilometerGefahren.Name = "textboxGesamtkilometerGefahren"
        Me.textboxGesamtkilometerGefahren.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamtkilometerGefahren.TabIndex = 0
        Me.textboxGesamtkilometerGefahren.TabStop = False
        '
        'groupboxGesamtkostenBezahlt
        '
        Me.groupboxGesamtkostenBezahlt.Controls.Add(Me.Label9)
        Me.groupboxGesamtkostenBezahlt.Controls.Add(Me.textboxGesamtkostenBezahlt)
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
        'textboxGesamtkostenBezahlt
        '
        Me.textboxGesamtkostenBezahlt.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamtkostenBezahlt.Name = "textboxGesamtkostenBezahlt"
        Me.textboxGesamtkostenBezahlt.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamtkostenBezahlt.TabIndex = 0
        Me.textboxGesamtkostenBezahlt.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.textboxGesamterVerbrauch)
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
        'textboxGesamterVerbrauch
        '
        Me.textboxGesamterVerbrauch.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamterVerbrauch.Name = "textboxGesamterVerbrauch"
        Me.textboxGesamterVerbrauch.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamterVerbrauch.TabIndex = 0
        Me.textboxGesamterVerbrauch.TabStop = False
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
        Me.TableLayoutPanel4.Controls.Add(Me.switchReparaturen, 0, 7)
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
        Me.groupboxBenzinkostenJahr.Controls.Add(Me.textboxBenzinkostenJahr)
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
        'textboxBenzinkostenJahr
        '
        Me.textboxBenzinkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.textboxBenzinkostenJahr.Name = "textboxBenzinkostenJahr"
        Me.textboxBenzinkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.textboxBenzinkostenJahr.TabIndex = 0
        Me.textboxBenzinkostenJahr.TabStop = False
        '
        'groupboxReparaturkostenJahr
        '
        Me.groupboxReparaturkostenJahr.Controls.Add(Me.Label3)
        Me.groupboxReparaturkostenJahr.Controls.Add(Me.textboxReparaturkostenJahr)
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
        'textboxReparaturkostenJahr
        '
        Me.textboxReparaturkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.textboxReparaturkostenJahr.Name = "textboxReparaturkostenJahr"
        Me.textboxReparaturkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.textboxReparaturkostenJahr.TabIndex = 0
        Me.textboxReparaturkostenJahr.TabStop = False
        '
        'groupboxKmGefahrenJahr
        '
        Me.groupboxKmGefahrenJahr.Controls.Add(Me.Label4)
        Me.groupboxKmGefahrenJahr.Controls.Add(Me.textboxKmGefahrenJahr)
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
        'textboxKmGefahrenJahr
        '
        Me.textboxKmGefahrenJahr.Location = New System.Drawing.Point(10, 20)
        Me.textboxKmGefahrenJahr.Name = "textboxKmGefahrenJahr"
        Me.textboxKmGefahrenJahr.Size = New System.Drawing.Size(100, 20)
        Me.textboxKmGefahrenJahr.TabIndex = 0
        Me.textboxKmGefahrenJahr.TabStop = False
        '
        'groupboxGesamtkostenJahr
        '
        Me.groupboxGesamtkostenJahr.Controls.Add(Me.Label5)
        Me.groupboxGesamtkostenJahr.Controls.Add(Me.textboxGesamtkostenJahr)
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
        'textboxGesamtkostenJahr
        '
        Me.textboxGesamtkostenJahr.Location = New System.Drawing.Point(10, 20)
        Me.textboxGesamtkostenJahr.Name = "textboxGesamtkostenJahr"
        Me.textboxGesamtkostenJahr.Size = New System.Drawing.Size(100, 20)
        Me.textboxGesamtkostenJahr.TabIndex = 0
        Me.textboxGesamtkostenJahr.TabStop = False
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
        Me.GroupBox1.Controls.Add(Me.textboxVerbrauchJahr)
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
        'textboxVerbrauchJahr
        '
        Me.textboxVerbrauchJahr.Location = New System.Drawing.Point(10, 20)
        Me.textboxVerbrauchJahr.Name = "textboxVerbrauchJahr"
        Me.textboxVerbrauchJahr.Size = New System.Drawing.Size(100, 20)
        Me.textboxVerbrauchJahr.TabIndex = 0
        Me.textboxVerbrauchJahr.TabStop = False
        '
        'switchReparaturen
        '
        Me.switchReparaturen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.switchReparaturen.Location = New System.Drawing.Point(3, 505)
        Me.switchReparaturen.Name = "switchReparaturen"
        Me.switchReparaturen.Size = New System.Drawing.Size(140, 23)
        Me.switchReparaturen.TabIndex = 6
        Me.switchReparaturen.TabStop = False
        Me.switchReparaturen.Text = "Reparaturen anzeigen >>"
        Me.switchReparaturen.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel6.Controls.Add(Me.comboboxJahrAuswahl, 0, 0)
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
        'comboboxJahrAuswahl
        '
        Me.comboboxJahrAuswahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxJahrAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxJahrAuswahl.FormattingEnabled = True
        Me.comboboxJahrAuswahl.IntegralHeight = False
        Me.comboboxJahrAuswahl.ItemHeight = 13
        Me.comboboxJahrAuswahl.Location = New System.Drawing.Point(231, 6)
        Me.comboboxJahrAuswahl.Margin = New System.Windows.Forms.Padding(6, 6, 5, 3)
        Me.comboboxJahrAuswahl.Name = "comboboxJahrAuswahl"
        Me.comboboxJahrAuswahl.Size = New System.Drawing.Size(190, 21)
        Me.comboboxJahrAuswahl.TabIndex = 0
        Me.comboboxJahrAuswahl.TabStop = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.textboxJahrDatensaetze, 1, 0)
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
        'textboxJahrDatensaetze
        '
        Me.textboxJahrDatensaetze.Enabled = False
        Me.textboxJahrDatensaetze.Location = New System.Drawing.Point(231, 7)
        Me.textboxJahrDatensaetze.Margin = New System.Windows.Forms.Padding(5, 7, 3, 3)
        Me.textboxJahrDatensaetze.Name = "textboxJahrDatensaetze"
        Me.textboxJahrDatensaetze.ReadOnly = True
        Me.textboxJahrDatensaetze.Size = New System.Drawing.Size(190, 20)
        Me.textboxJahrDatensaetze.TabIndex = 1
        Me.textboxJahrDatensaetze.TabStop = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 648.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.datagridviewTanken, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.datagridviewReparaturen, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(798, 631)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'datagridviewTanken
        '
        Me.datagridviewTanken.AllowUserToAddRows = False
        Me.datagridviewTanken.AllowUserToDeleteRows = False
        Me.datagridviewTanken.AllowUserToResizeRows = False
        Me.datagridviewTanken.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagridviewTanken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewTanken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewTanken.Location = New System.Drawing.Point(3, 3)
        Me.datagridviewTanken.MultiSelect = False
        Me.datagridviewTanken.Name = "datagridviewTanken"
        Me.datagridviewTanken.ReadOnly = True
        Me.datagridviewTanken.RowHeadersVisible = False
        Me.datagridviewTanken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewTanken.Size = New System.Drawing.Size(794, 625)
        Me.datagridviewTanken.TabIndex = 1
        Me.datagridviewTanken.TabStop = False
        '
        'datagridviewReparaturen
        '
        Me.datagridviewReparaturen.AllowUserToAddRows = False
        Me.datagridviewReparaturen.AllowUserToDeleteRows = False
        Me.datagridviewReparaturen.AllowUserToResizeRows = False
        Me.datagridviewReparaturen.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagridviewReparaturen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewReparaturen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewReparaturen.Location = New System.Drawing.Point(803, 3)
        Me.datagridviewReparaturen.MultiSelect = False
        Me.datagridviewReparaturen.Name = "datagridviewReparaturen"
        Me.datagridviewReparaturen.ReadOnly = True
        Me.datagridviewReparaturen.RowHeadersVisible = False
        Me.datagridviewReparaturen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewReparaturen.Size = New System.Drawing.Size(642, 625)
        Me.datagridviewReparaturen.TabIndex = 2
        Me.datagridviewReparaturen.TabStop = False
        '
        'printDocumentFormMain
        '
        '
        'printPreviewFormMain
        '
        Me.printPreviewFormMain.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewFormMain.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewFormMain.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewFormMain.Enabled = True
        Me.printPreviewFormMain.Icon = CType(resources.GetObject("printPreviewFormMain.Icon"), System.Drawing.Icon)
        Me.printPreviewFormMain.Name = "printPreviewFormMain"
        Me.printPreviewFormMain.Visible = False
        '
        'printDialogFormMain
        '
        Me.printDialogFormMain.UseEXDialog = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 661)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menustripFormMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menustripFormMain
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1270, 700)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TankManager"
        Me.menustripFormMain.ResumeLayout(False)
        Me.menustripFormMain.PerformLayout()
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
        CType(Me.datagridviewTanken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridviewReparaturen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menustripFormMain As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeueTankquittungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents datagridviewTanken As DataGridView
    Friend WithEvents groupboxJahrAuswahl As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents comboboxJahrAuswahl As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents textboxJahrDatensaetze As TextBox
    Friend WithEvents groupboxGesamtkostenBenzin As GroupBox
    Friend WithEvents groupboxGesamtkostenReparatur As GroupBox
    Friend WithEvents groupboxGesamtkilometerGefahren As GroupBox
    Friend WithEvents groupboxGesamtkostenBezahlt As GroupBox
    Friend WithEvents groupboxBenzinkostenJahr As GroupBox
    Friend WithEvents groupboxReparaturkostenJahr As GroupBox
    Friend WithEvents groupboxKmGefahrenJahr As GroupBox
    Friend WithEvents groupboxGesamtkostenJahr As GroupBox
    Friend WithEvents textboxGesamtkostenBenzin As TextBox
    Friend WithEvents textboxGesamtkostenReparatur As TextBox
    Friend WithEvents textboxGesamtkilometerGefahren As TextBox
    Friend WithEvents textboxGesamtkostenBezahlt As TextBox
    Friend WithEvents textboxBenzinkostenJahr As TextBox
    Friend WithEvents textboxReparaturkostenJahr As TextBox
    Friend WithEvents textboxKmGefahrenJahr As TextBox
    Friend WithEvents textboxGesamtkostenJahr As TextBox
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
    Friend WithEvents DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeueReparaturToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuExtrasExportToPdf As ToolStripMenuItem
    Friend WithEvents DruckvorschauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents printDocumentFormMain As Printing.PrintDocument
    Friend WithEvents printPreviewFormMain As PrintPreviewDialog
    Friend WithEvents printDialogFormMain As PrintDialog
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents datagridviewReparaturen As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents textboxGesamterVerbrauch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents textboxVerbrauchJahr As TextBox
    Friend WithEvents switchReparaturen As Button
    Friend WithEvents pageSetupDialogFormMain As PageSetupDialog
    Friend WithEvents SeiteEinrichtenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuExtrasExportToPdfDgvRefuel As ToolStripMenuItem
    Friend WithEvents MenuExtrasExportToPdfDgvRepair As ToolStripMenuItem
End Class
