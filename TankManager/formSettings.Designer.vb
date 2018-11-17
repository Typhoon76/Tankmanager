<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.buttonSettingsAbbrechen = New System.Windows.Forms.Button()
        Me.buttonSettingsEinstellungenStandard = New System.Windows.Forms.Button()
        Me.buttonSettingsSpeichernUndSchliessen = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textboxSettingsVerbindungUserpasswort = New System.Windows.Forms.TextBox()
        Me.textboxSettingsVerbindungUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupBoxSettingsVerbindungVerbindenAls = New System.Windows.Forms.GroupBox()
        Me.textboxSettingsVerbindungServerport = New System.Windows.Forms.TextBox()
        Me.textboxSettingsVerbindungZeichencodierung = New System.Windows.Forms.TextBox()
        Me.textboxSettingsVerbindungServeradresse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBoxSettingsVerbindungServer = New System.Windows.Forms.GroupBox()
        Me.tabControlSettings = New System.Windows.Forms.TabControl()
        Me.tabControlGeneral = New System.Windows.Forms.TabPage()
        Me.comboboxSettingsJahresauswahl = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabControlAuto = New System.Windows.Forms.TabPage()
        Me.datetimepickerSettingsBaujahr = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabControlView = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checboxSettingsReparaturHideDoubleDateEntries = New System.Windows.Forms.CheckBox()
        Me.checboxSettingsReparaturHideDoublePriceEntries = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checboxSettingsTankenHideDoubleDateEntries = New System.Windows.Forms.CheckBox()
        Me.tabControlFormat = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textboxSettingsFormatDate = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatTime = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatQuantity = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatPrice = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatPricePerLiter = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatRoute = New System.Windows.Forms.TextBox()
        Me.textboxSettingsFormatMileage = New System.Windows.Forms.TextBox()
        Me.tabControlServer = New System.Windows.Forms.TabPage()
        Me.tabControlAccount = New System.Windows.Forms.TabPage()
        Me.groupBoxSettingsVerbindungVerbindenAls.SuspendLayout()
        Me.groupBoxSettingsVerbindungServer.SuspendLayout()
        Me.tabControlSettings.SuspendLayout()
        Me.tabControlGeneral.SuspendLayout()
        Me.tabControlAuto.SuspendLayout()
        Me.tabControlView.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabControlFormat.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabControlServer.SuspendLayout()
        Me.tabControlAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonSettingsAbbrechen
        '
        Me.buttonSettingsAbbrechen.Location = New System.Drawing.Point(74, 205)
        Me.buttonSettingsAbbrechen.Name = "buttonSettingsAbbrechen"
        Me.buttonSettingsAbbrechen.Size = New System.Drawing.Size(150, 25)
        Me.buttonSettingsAbbrechen.TabIndex = 8
        Me.buttonSettingsAbbrechen.Text = "Abbrechen"
        Me.buttonSettingsAbbrechen.UseVisualStyleBackColor = True
        '
        'buttonSettingsEinstellungenStandard
        '
        Me.buttonSettingsEinstellungenStandard.Location = New System.Drawing.Point(229, 205)
        Me.buttonSettingsEinstellungenStandard.Name = "buttonSettingsEinstellungenStandard"
        Me.buttonSettingsEinstellungenStandard.Size = New System.Drawing.Size(240, 25)
        Me.buttonSettingsEinstellungenStandard.TabIndex = 9
        Me.buttonSettingsEinstellungenStandard.Text = "auf Standard zurücksetzen"
        Me.buttonSettingsEinstellungenStandard.UseVisualStyleBackColor = True
        '
        'buttonSettingsSpeichernUndSchliessen
        '
        Me.buttonSettingsSpeichernUndSchliessen.Location = New System.Drawing.Point(474, 205)
        Me.buttonSettingsSpeichernUndSchliessen.Name = "buttonSettingsSpeichernUndSchliessen"
        Me.buttonSettingsSpeichernUndSchliessen.Size = New System.Drawing.Size(150, 25)
        Me.buttonSettingsSpeichernUndSchliessen.TabIndex = 10
        Me.buttonSettingsSpeichernUndSchliessen.Text = "Speichern && Schließen"
        Me.buttonSettingsSpeichernUndSchliessen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Userpasswort"
        '
        'textboxSettingsVerbindungUserpasswort
        '
        Me.textboxSettingsVerbindungUserpasswort.Location = New System.Drawing.Point(110, 55)
        Me.textboxSettingsVerbindungUserpasswort.Name = "textboxSettingsVerbindungUserpasswort"
        Me.textboxSettingsVerbindungUserpasswort.Size = New System.Drawing.Size(200, 20)
        Me.textboxSettingsVerbindungUserpasswort.TabIndex = 9
        '
        'textboxSettingsVerbindungUsername
        '
        Me.textboxSettingsVerbindungUsername.Location = New System.Drawing.Point(110, 25)
        Me.textboxSettingsVerbindungUsername.Name = "textboxSettingsVerbindungUsername"
        Me.textboxSettingsVerbindungUsername.Size = New System.Drawing.Size(200, 20)
        Me.textboxSettingsVerbindungUsername.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'groupBoxSettingsVerbindungVerbindenAls
        '
        Me.groupBoxSettingsVerbindungVerbindenAls.Controls.Add(Me.Label4)
        Me.groupBoxSettingsVerbindungVerbindenAls.Controls.Add(Me.textboxSettingsVerbindungUsername)
        Me.groupBoxSettingsVerbindungVerbindenAls.Controls.Add(Me.textboxSettingsVerbindungUserpasswort)
        Me.groupBoxSettingsVerbindungVerbindenAls.Controls.Add(Me.Label5)
        Me.groupBoxSettingsVerbindungVerbindenAls.Location = New System.Drawing.Point(12, 6)
        Me.groupBoxSettingsVerbindungVerbindenAls.Name = "groupBoxSettingsVerbindungVerbindenAls"
        Me.groupBoxSettingsVerbindungVerbindenAls.Size = New System.Drawing.Size(640, 134)
        Me.groupBoxSettingsVerbindungVerbindenAls.TabIndex = 11
        Me.groupBoxSettingsVerbindungVerbindenAls.TabStop = False
        Me.groupBoxSettingsVerbindungVerbindenAls.Text = "verbinden als"
        '
        'textboxSettingsVerbindungServerport
        '
        Me.textboxSettingsVerbindungServerport.Location = New System.Drawing.Point(110, 55)
        Me.textboxSettingsVerbindungServerport.Name = "textboxSettingsVerbindungServerport"
        Me.textboxSettingsVerbindungServerport.Size = New System.Drawing.Size(80, 20)
        Me.textboxSettingsVerbindungServerport.TabIndex = 6
        '
        'textboxSettingsVerbindungZeichencodierung
        '
        Me.textboxSettingsVerbindungZeichencodierung.Location = New System.Drawing.Point(110, 85)
        Me.textboxSettingsVerbindungZeichencodierung.Name = "textboxSettingsVerbindungZeichencodierung"
        Me.textboxSettingsVerbindungZeichencodierung.Size = New System.Drawing.Size(80, 20)
        Me.textboxSettingsVerbindungZeichencodierung.TabIndex = 7
        '
        'textboxSettingsVerbindungServeradresse
        '
        Me.textboxSettingsVerbindungServeradresse.Location = New System.Drawing.Point(110, 25)
        Me.textboxSettingsVerbindungServeradresse.Name = "textboxSettingsVerbindungServeradresse"
        Me.textboxSettingsVerbindungServeradresse.Size = New System.Drawing.Size(200, 20)
        Me.textboxSettingsVerbindungServeradresse.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Zeichencodierung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serverport"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serveradresse"
        '
        'groupBoxSettingsVerbindungServer
        '
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.Label1)
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.Label2)
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.Label3)
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.textboxSettingsVerbindungServeradresse)
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.textboxSettingsVerbindungZeichencodierung)
        Me.groupBoxSettingsVerbindungServer.Controls.Add(Me.textboxSettingsVerbindungServerport)
        Me.groupBoxSettingsVerbindungServer.Location = New System.Drawing.Point(12, 6)
        Me.groupBoxSettingsVerbindungServer.Name = "groupBoxSettingsVerbindungServer"
        Me.groupBoxSettingsVerbindungServer.Size = New System.Drawing.Size(640, 134)
        Me.groupBoxSettingsVerbindungServer.TabIndex = 10
        Me.groupBoxSettingsVerbindungServer.TabStop = False
        Me.groupBoxSettingsVerbindungServer.Text = "Server"
        '
        'tabControlSettings
        '
        Me.tabControlSettings.Controls.Add(Me.tabControlGeneral)
        Me.tabControlSettings.Controls.Add(Me.tabControlAuto)
        Me.tabControlSettings.Controls.Add(Me.tabControlView)
        Me.tabControlSettings.Controls.Add(Me.tabControlFormat)
        Me.tabControlSettings.Controls.Add(Me.tabControlServer)
        Me.tabControlSettings.Controls.Add(Me.tabControlAccount)
        Me.tabControlSettings.Location = New System.Drawing.Point(12, 12)
        Me.tabControlSettings.Name = "tabControlSettings"
        Me.tabControlSettings.SelectedIndex = 0
        Me.tabControlSettings.Size = New System.Drawing.Size(672, 177)
        Me.tabControlSettings.TabIndex = 12
        '
        'tabControlGeneral
        '
        Me.tabControlGeneral.Controls.Add(Me.comboboxSettingsJahresauswahl)
        Me.tabControlGeneral.Controls.Add(Me.Label13)
        Me.tabControlGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabControlGeneral.Name = "tabControlGeneral"
        Me.tabControlGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabControlGeneral.Size = New System.Drawing.Size(664, 151)
        Me.tabControlGeneral.TabIndex = 4
        Me.tabControlGeneral.Text = "Allgemein"
        Me.tabControlGeneral.UseVisualStyleBackColor = True
        '
        'comboboxSettingsJahresauswahl
        '
        Me.comboboxSettingsJahresauswahl.FormattingEnabled = True
        Me.comboboxSettingsJahresauswahl.Location = New System.Drawing.Point(150, 13)
        Me.comboboxSettingsJahresauswahl.Name = "comboboxSettingsJahresauswahl"
        Me.comboboxSettingsJahresauswahl.Size = New System.Drawing.Size(121, 21)
        Me.comboboxSettingsJahresauswahl.TabIndex = 1
        Me.comboboxSettingsJahresauswahl.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Startjahr für Jahreauswahl"
        '
        'tabControlAuto
        '
        Me.tabControlAuto.Controls.Add(Me.datetimepickerSettingsBaujahr)
        Me.tabControlAuto.Controls.Add(Me.Label14)
        Me.tabControlAuto.Location = New System.Drawing.Point(4, 22)
        Me.tabControlAuto.Name = "tabControlAuto"
        Me.tabControlAuto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabControlAuto.Size = New System.Drawing.Size(664, 151)
        Me.tabControlAuto.TabIndex = 5
        Me.tabControlAuto.Text = "Autodaten"
        Me.tabControlAuto.UseVisualStyleBackColor = True
        '
        'datetimepickerSettingsBaujahr
        '
        Me.datetimepickerSettingsBaujahr.Location = New System.Drawing.Point(150, 13)
        Me.datetimepickerSettingsBaujahr.Name = "datetimepickerSettingsBaujahr"
        Me.datetimepickerSettingsBaujahr.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerSettingsBaujahr.TabIndex = 1
        Me.datetimepickerSettingsBaujahr.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Baujahr des Autos"
        '
        'tabControlView
        '
        Me.tabControlView.Controls.Add(Me.GroupBox2)
        Me.tabControlView.Controls.Add(Me.GroupBox1)
        Me.tabControlView.Location = New System.Drawing.Point(4, 22)
        Me.tabControlView.Name = "tabControlView"
        Me.tabControlView.Padding = New System.Windows.Forms.Padding(3)
        Me.tabControlView.Size = New System.Drawing.Size(664, 151)
        Me.tabControlView.TabIndex = 0
        Me.tabControlView.Text = "Anzeige"
        Me.tabControlView.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checboxSettingsReparaturHideDoubleDateEntries)
        Me.GroupBox2.Controls.Add(Me.checboxSettingsReparaturHideDoublePriceEntries)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 65)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reparaturliste"
        '
        'checboxSettingsReparaturHideDoubleDateEntries
        '
        Me.checboxSettingsReparaturHideDoubleDateEntries.AutoSize = True
        Me.checboxSettingsReparaturHideDoubleDateEntries.Location = New System.Drawing.Point(10, 20)
        Me.checboxSettingsReparaturHideDoubleDateEntries.Name = "checboxSettingsReparaturHideDoubleDateEntries"
        Me.checboxSettingsReparaturHideDoubleDateEntries.Size = New System.Drawing.Size(252, 17)
        Me.checboxSettingsReparaturHideDoubleDateEntries.TabIndex = 0
        Me.checboxSettingsReparaturHideDoubleDateEntries.Text = "mehrfache gleiche Datumsangaben ausblenden"
        Me.checboxSettingsReparaturHideDoubleDateEntries.UseVisualStyleBackColor = True
        '
        'checboxSettingsReparaturHideDoublePriceEntries
        '
        Me.checboxSettingsReparaturHideDoublePriceEntries.AutoSize = True
        Me.checboxSettingsReparaturHideDoublePriceEntries.Location = New System.Drawing.Point(10, 40)
        Me.checboxSettingsReparaturHideDoublePriceEntries.Name = "checboxSettingsReparaturHideDoublePriceEntries"
        Me.checboxSettingsReparaturHideDoublePriceEntries.Size = New System.Drawing.Size(239, 17)
        Me.checboxSettingsReparaturHideDoublePriceEntries.TabIndex = 1
        Me.checboxSettingsReparaturHideDoublePriceEntries.Text = "mehrfache gleiche Preisangaben ausblenden"
        Me.checboxSettingsReparaturHideDoublePriceEntries.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checboxSettingsTankenHideDoubleDateEntries)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tankliste"
        '
        'checboxSettingsTankenHideDoubleDateEntries
        '
        Me.checboxSettingsTankenHideDoubleDateEntries.AutoSize = True
        Me.checboxSettingsTankenHideDoubleDateEntries.Location = New System.Drawing.Point(10, 20)
        Me.checboxSettingsTankenHideDoubleDateEntries.Name = "checboxSettingsTankenHideDoubleDateEntries"
        Me.checboxSettingsTankenHideDoubleDateEntries.Size = New System.Drawing.Size(252, 17)
        Me.checboxSettingsTankenHideDoubleDateEntries.TabIndex = 1
        Me.checboxSettingsTankenHideDoubleDateEntries.Text = "mehrfache gleiche Datumsangaben ausblenden"
        Me.checboxSettingsTankenHideDoubleDateEntries.UseVisualStyleBackColor = True
        '
        'tabControlFormat
        '
        Me.tabControlFormat.Controls.Add(Me.TableLayoutPanel1)
        Me.tabControlFormat.Location = New System.Drawing.Point(4, 22)
        Me.tabControlFormat.Name = "tabControlFormat"
        Me.tabControlFormat.Padding = New System.Windows.Forms.Padding(3)
        Me.tabControlFormat.Size = New System.Drawing.Size(664, 151)
        Me.tabControlFormat.TabIndex = 3
        Me.tabControlFormat.Text = "Formate"
        Me.tabControlFormat.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatDate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatTime, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatQuantity, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatPrice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatPricePerLiter, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatRoute, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.textboxSettingsFormatMileage, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(658, 145)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Format Datum"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Format Zeit"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Kommastellen Liter"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Kommastellen Preis"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(372, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Kommastellen Literpreis"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Kommastellen Kilometer"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(336, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Kommastellen Gesamtkilometer"
        '
        'textboxSettingsFormatDate
        '
        Me.textboxSettingsFormatDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatDate.Location = New System.Drawing.Point(167, 8)
        Me.textboxSettingsFormatDate.Name = "textboxSettingsFormatDate"
        Me.textboxSettingsFormatDate.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatDate.TabIndex = 7
        '
        'textboxSettingsFormatTime
        '
        Me.textboxSettingsFormatTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatTime.Location = New System.Drawing.Point(167, 44)
        Me.textboxSettingsFormatTime.Name = "textboxSettingsFormatTime"
        Me.textboxSettingsFormatTime.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatTime.TabIndex = 8
        '
        'textboxSettingsFormatQuantity
        '
        Me.textboxSettingsFormatQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatQuantity.Location = New System.Drawing.Point(167, 80)
        Me.textboxSettingsFormatQuantity.Name = "textboxSettingsFormatQuantity"
        Me.textboxSettingsFormatQuantity.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatQuantity.TabIndex = 9
        '
        'textboxSettingsFormatPrice
        '
        Me.textboxSettingsFormatPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatPrice.Location = New System.Drawing.Point(167, 116)
        Me.textboxSettingsFormatPrice.Name = "textboxSettingsFormatPrice"
        Me.textboxSettingsFormatPrice.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatPrice.TabIndex = 10
        '
        'textboxSettingsFormatPricePerLiter
        '
        Me.textboxSettingsFormatPricePerLiter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatPricePerLiter.Location = New System.Drawing.Point(495, 8)
        Me.textboxSettingsFormatPricePerLiter.Name = "textboxSettingsFormatPricePerLiter"
        Me.textboxSettingsFormatPricePerLiter.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatPricePerLiter.TabIndex = 11
        '
        'textboxSettingsFormatRoute
        '
        Me.textboxSettingsFormatRoute.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatRoute.Location = New System.Drawing.Point(495, 44)
        Me.textboxSettingsFormatRoute.Name = "textboxSettingsFormatRoute"
        Me.textboxSettingsFormatRoute.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatRoute.TabIndex = 12
        '
        'textboxSettingsFormatMileage
        '
        Me.textboxSettingsFormatMileage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textboxSettingsFormatMileage.Location = New System.Drawing.Point(495, 80)
        Me.textboxSettingsFormatMileage.Name = "textboxSettingsFormatMileage"
        Me.textboxSettingsFormatMileage.Size = New System.Drawing.Size(100, 20)
        Me.textboxSettingsFormatMileage.TabIndex = 13
        '
        'tabControlServer
        '
        Me.tabControlServer.Controls.Add(Me.groupBoxSettingsVerbindungServer)
        Me.tabControlServer.Location = New System.Drawing.Point(4, 22)
        Me.tabControlServer.Name = "tabControlServer"
        Me.tabControlServer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabControlServer.Size = New System.Drawing.Size(664, 151)
        Me.tabControlServer.TabIndex = 1
        Me.tabControlServer.Text = "Server"
        Me.tabControlServer.UseVisualStyleBackColor = True
        '
        'tabControlAccount
        '
        Me.tabControlAccount.Controls.Add(Me.groupBoxSettingsVerbindungVerbindenAls)
        Me.tabControlAccount.Location = New System.Drawing.Point(4, 22)
        Me.tabControlAccount.Name = "tabControlAccount"
        Me.tabControlAccount.Size = New System.Drawing.Size(664, 151)
        Me.tabControlAccount.TabIndex = 2
        Me.tabControlAccount.Text = "Zugangsdaten"
        Me.tabControlAccount.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 241)
        Me.Controls.Add(Me.tabControlSettings)
        Me.Controls.Add(Me.buttonSettingsAbbrechen)
        Me.Controls.Add(Me.buttonSettingsEinstellungenStandard)
        Me.Controls.Add(Me.buttonSettingsSpeichernUndSchliessen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.groupBoxSettingsVerbindungVerbindenAls.ResumeLayout(False)
        Me.groupBoxSettingsVerbindungVerbindenAls.PerformLayout()
        Me.groupBoxSettingsVerbindungServer.ResumeLayout(False)
        Me.groupBoxSettingsVerbindungServer.PerformLayout()
        Me.tabControlSettings.ResumeLayout(False)
        Me.tabControlGeneral.ResumeLayout(False)
        Me.tabControlGeneral.PerformLayout()
        Me.tabControlAuto.ResumeLayout(False)
        Me.tabControlAuto.PerformLayout()
        Me.tabControlView.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabControlFormat.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabControlServer.ResumeLayout(False)
        Me.tabControlAccount.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonSettingsAbbrechen As Button
    Friend WithEvents buttonSettingsEinstellungenStandard As Button
    Friend WithEvents buttonSettingsSpeichernUndSchliessen As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textboxSettingsVerbindungUserpasswort As TextBox
    Friend WithEvents textboxSettingsVerbindungUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents groupBoxSettingsVerbindungVerbindenAls As GroupBox
    Friend WithEvents textboxSettingsVerbindungServerport As TextBox
    Friend WithEvents textboxSettingsVerbindungZeichencodierung As TextBox
    Friend WithEvents textboxSettingsVerbindungServeradresse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents groupBoxSettingsVerbindungServer As GroupBox
    Friend WithEvents tabControlSettings As TabControl
    Friend WithEvents tabControlView As TabPage
    Friend WithEvents tabControlServer As TabPage
    Friend WithEvents tabControlAccount As TabPage
    Friend WithEvents checboxSettingsReparaturHideDoublePriceEntries As CheckBox
    Friend WithEvents checboxSettingsReparaturHideDoubleDateEntries As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checboxSettingsTankenHideDoubleDateEntries As CheckBox
    Friend WithEvents tabControlFormat As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabControlGeneral As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents textboxSettingsFormatDate As TextBox
    Friend WithEvents textboxSettingsFormatTime As TextBox
    Friend WithEvents textboxSettingsFormatQuantity As TextBox
    Friend WithEvents textboxSettingsFormatPrice As TextBox
    Friend WithEvents textboxSettingsFormatPricePerLiter As TextBox
    Friend WithEvents textboxSettingsFormatRoute As TextBox
    Friend WithEvents textboxSettingsFormatMileage As TextBox
    Friend WithEvents comboboxSettingsJahresauswahl As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tabControlAuto As TabPage
    Friend WithEvents datetimepickerSettingsBaujahr As DateTimePicker
    Friend WithEvents Label14 As Label
End Class
