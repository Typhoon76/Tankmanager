<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExportPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExportPDF))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxExportPDFOptionen = New System.Windows.Forms.GroupBox()
        Me.radiobuttonExportPDFTabelle = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxExportPDFSeitenBis = New System.Windows.Forms.TextBox()
        Me.textboxExportPDFSeitenVon = New System.Windows.Forms.TextBox()
        Me.checkboxExportPDFAnhaengenZeit = New System.Windows.Forms.CheckBox()
        Me.checkboxExportPDFAnhaengenDatum = New System.Windows.Forms.CheckBox()
        Me.checkboxExportPDFAnhaengenTabellenname = New System.Windows.Forms.CheckBox()
        Me.radiobuttonExportPDFKomprimierungJPEG = New System.Windows.Forms.RadioButton()
        Me.radiobuttonExportPDFKomprimierungVerlustfrei = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.radiobuttonExportPDFSeiten = New System.Windows.Forms.RadioButton()
        Me.radiobuttonExportPDFAlles = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupboxExportPDFSpeicherpfad = New System.Windows.Forms.GroupBox()
        Me.buttonExportPDFPfadWaehlen = New System.Windows.Forms.Button()
        Me.textboxExportPDFPfadWaehlen = New System.Windows.Forms.TextBox()
        Me.groupboxExportPDFDateiname = New System.Windows.Forms.GroupBox()
        Me.textboxExportPDFDateinname = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.buttonExportPDFAbbrechen = New System.Windows.Forms.Button()
        Me.buttonExportPDFEinstellungenStandard = New System.Windows.Forms.Button()
        Me.buttonExportPDFExport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupboxExportPDFOptionen.SuspendLayout()
        Me.groupboxExportPDFSpeicherpfad.SuspendLayout()
        Me.groupboxExportPDFDateiname.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxExportPDFOptionen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxExportPDFSpeicherpfad, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxExportPDFDateiname, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 305.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 425)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'groupboxExportPDFOptionen
        '
        Me.groupboxExportPDFOptionen.Controls.Add(Me.radiobuttonExportPDFTabelle)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.Label5)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.TextBox3)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.Label4)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.Label3)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.textboxExportPDFSeitenBis)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.textboxExportPDFSeitenVon)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.checkboxExportPDFAnhaengenZeit)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.checkboxExportPDFAnhaengenDatum)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.checkboxExportPDFAnhaengenTabellenname)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.radiobuttonExportPDFKomprimierungJPEG)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.radiobuttonExportPDFKomprimierungVerlustfrei)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.RadioButton3)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.radiobuttonExportPDFSeiten)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.radiobuttonExportPDFAlles)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.Label2)
        Me.groupboxExportPDFOptionen.Controls.Add(Me.Label1)
        Me.groupboxExportPDFOptionen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxExportPDFOptionen.Location = New System.Drawing.Point(3, 3)
        Me.groupboxExportPDFOptionen.Name = "groupboxExportPDFOptionen"
        Me.groupboxExportPDFOptionen.Size = New System.Drawing.Size(793, 299)
        Me.groupboxExportPDFOptionen.TabIndex = 0
        Me.groupboxExportPDFOptionen.TabStop = False
        Me.groupboxExportPDFOptionen.Text = "Optionen"
        '
        'radiobuttonExportPDFTabelle
        '
        Me.radiobuttonExportPDFTabelle.AutoSize = True
        Me.radiobuttonExportPDFTabelle.Location = New System.Drawing.Point(130, 60)
        Me.radiobuttonExportPDFTabelle.Name = "radiobuttonExportPDFTabelle"
        Me.radiobuttonExportPDFTabelle.Size = New System.Drawing.Size(100, 17)
        Me.radiobuttonExportPDFTabelle.TabIndex = 16
        Me.radiobuttonExportPDFTabelle.TabStop = True
        Me.radiobuttonExportPDFTabelle.Text = "aktuelle Tabelle"
        Me.radiobuttonExportPDFTabelle.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "%"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(340, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 20)
        Me.TextBox3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "von"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "bis"
        '
        'textboxExportPDFSeitenBis
        '
        Me.textboxExportPDFSeitenBis.Location = New System.Drawing.Point(370, 90)
        Me.textboxExportPDFSeitenBis.Name = "textboxExportPDFSeitenBis"
        Me.textboxExportPDFSeitenBis.Size = New System.Drawing.Size(50, 20)
        Me.textboxExportPDFSeitenBis.TabIndex = 11
        '
        'textboxExportPDFSeitenVon
        '
        Me.textboxExportPDFSeitenVon.Location = New System.Drawing.Point(275, 90)
        Me.textboxExportPDFSeitenVon.Name = "textboxExportPDFSeitenVon"
        Me.textboxExportPDFSeitenVon.Size = New System.Drawing.Size(50, 20)
        Me.textboxExportPDFSeitenVon.TabIndex = 10
        '
        'checkboxExportPDFAnhaengenZeit
        '
        Me.checkboxExportPDFAnhaengenZeit.AutoSize = True
        Me.checkboxExportPDFAnhaengenZeit.Location = New System.Drawing.Point(130, 250)
        Me.checkboxExportPDFAnhaengenZeit.Name = "checkboxExportPDFAnhaengenZeit"
        Me.checkboxExportPDFAnhaengenZeit.Size = New System.Drawing.Size(95, 17)
        Me.checkboxExportPDFAnhaengenZeit.TabIndex = 9
        Me.checkboxExportPDFAnhaengenZeit.Text = "Zeit anhängen"
        Me.checkboxExportPDFAnhaengenZeit.UseVisualStyleBackColor = True
        '
        'checkboxExportPDFAnhaengenDatum
        '
        Me.checkboxExportPDFAnhaengenDatum.AutoSize = True
        Me.checkboxExportPDFAnhaengenDatum.Location = New System.Drawing.Point(130, 220)
        Me.checkboxExportPDFAnhaengenDatum.Name = "checkboxExportPDFAnhaengenDatum"
        Me.checkboxExportPDFAnhaengenDatum.Size = New System.Drawing.Size(108, 17)
        Me.checkboxExportPDFAnhaengenDatum.TabIndex = 8
        Me.checkboxExportPDFAnhaengenDatum.Text = "Datum anhängen"
        Me.checkboxExportPDFAnhaengenDatum.UseVisualStyleBackColor = True
        '
        'checkboxExportPDFAnhaengenTabellenname
        '
        Me.checkboxExportPDFAnhaengenTabellenname.AutoSize = True
        Me.checkboxExportPDFAnhaengenTabellenname.Location = New System.Drawing.Point(130, 190)
        Me.checkboxExportPDFAnhaengenTabellenname.Name = "checkboxExportPDFAnhaengenTabellenname"
        Me.checkboxExportPDFAnhaengenTabellenname.Size = New System.Drawing.Size(144, 17)
        Me.checkboxExportPDFAnhaengenTabellenname.TabIndex = 7
        Me.checkboxExportPDFAnhaengenTabellenname.Text = "Tabellenname anhängen"
        Me.checkboxExportPDFAnhaengenTabellenname.UseVisualStyleBackColor = True
        '
        'radiobuttonExportPDFKomprimierungJPEG
        '
        Me.radiobuttonExportPDFKomprimierungJPEG.AutoSize = True
        Me.radiobuttonExportPDFKomprimierungJPEG.Location = New System.Drawing.Point(240, 150)
        Me.radiobuttonExportPDFKomprimierungJPEG.Name = "radiobuttonExportPDFKomprimierungJPEG"
        Me.radiobuttonExportPDFKomprimierungJPEG.Size = New System.Drawing.Size(94, 17)
        Me.radiobuttonExportPDFKomprimierungJPEG.TabIndex = 6
        Me.radiobuttonExportPDFKomprimierungJPEG.TabStop = True
        Me.radiobuttonExportPDFKomprimierungJPEG.Text = "JPEG, Qualität"
        Me.radiobuttonExportPDFKomprimierungJPEG.UseVisualStyleBackColor = True
        '
        'radiobuttonExportPDFKomprimierungVerlustfrei
        '
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.AutoSize = True
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.Location = New System.Drawing.Point(240, 120)
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.Name = "radiobuttonExportPDFKomprimierungVerlustfrei"
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.Size = New System.Drawing.Size(71, 17)
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.TabIndex = 5
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.TabStop = True
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.Text = "Verlustfrei"
        Me.radiobuttonExportPDFKomprimierungVerlustfrei.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(130, 120)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(94, 17)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Komprimierung"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'radiobuttonExportPDFSeiten
        '
        Me.radiobuttonExportPDFSeiten.AutoSize = True
        Me.radiobuttonExportPDFSeiten.Location = New System.Drawing.Point(130, 90)
        Me.radiobuttonExportPDFSeiten.Name = "radiobuttonExportPDFSeiten"
        Me.radiobuttonExportPDFSeiten.Size = New System.Drawing.Size(55, 17)
        Me.radiobuttonExportPDFSeiten.TabIndex = 3
        Me.radiobuttonExportPDFSeiten.TabStop = True
        Me.radiobuttonExportPDFSeiten.Text = "Seiten"
        Me.radiobuttonExportPDFSeiten.UseVisualStyleBackColor = True
        '
        'radiobuttonExportPDFAlles
        '
        Me.radiobuttonExportPDFAlles.AutoSize = True
        Me.radiobuttonExportPDFAlles.Location = New System.Drawing.Point(130, 30)
        Me.radiobuttonExportPDFAlles.Name = "radiobuttonExportPDFAlles"
        Me.radiobuttonExportPDFAlles.Size = New System.Drawing.Size(47, 17)
        Me.radiobuttonExportPDFAlles.TabIndex = 2
        Me.radiobuttonExportPDFAlles.TabStop = True
        Me.radiobuttonExportPDFAlles.Text = "Alles"
        Me.radiobuttonExportPDFAlles.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Speichern"
        '
        'groupboxExportPDFSpeicherpfad
        '
        Me.groupboxExportPDFSpeicherpfad.Controls.Add(Me.buttonExportPDFPfadWaehlen)
        Me.groupboxExportPDFSpeicherpfad.Controls.Add(Me.textboxExportPDFPfadWaehlen)
        Me.groupboxExportPDFSpeicherpfad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxExportPDFSpeicherpfad.Location = New System.Drawing.Point(3, 308)
        Me.groupboxExportPDFSpeicherpfad.Name = "groupboxExportPDFSpeicherpfad"
        Me.groupboxExportPDFSpeicherpfad.Size = New System.Drawing.Size(793, 54)
        Me.groupboxExportPDFSpeicherpfad.TabIndex = 1
        Me.groupboxExportPDFSpeicherpfad.TabStop = False
        Me.groupboxExportPDFSpeicherpfad.Text = "Datei speichern in"
        '
        'buttonExportPDFPfadWaehlen
        '
        Me.buttonExportPDFPfadWaehlen.Location = New System.Drawing.Point(634, 20)
        Me.buttonExportPDFPfadWaehlen.Name = "buttonExportPDFPfadWaehlen"
        Me.buttonExportPDFPfadWaehlen.Size = New System.Drawing.Size(150, 23)
        Me.buttonExportPDFPfadWaehlen.TabIndex = 1
        Me.buttonExportPDFPfadWaehlen.Text = "Pfad wählen"
        Me.buttonExportPDFPfadWaehlen.UseVisualStyleBackColor = True
        '
        'textboxExportPDFPfadWaehlen
        '
        Me.textboxExportPDFPfadWaehlen.Location = New System.Drawing.Point(10, 22)
        Me.textboxExportPDFPfadWaehlen.Name = "textboxExportPDFPfadWaehlen"
        Me.textboxExportPDFPfadWaehlen.Size = New System.Drawing.Size(620, 20)
        Me.textboxExportPDFPfadWaehlen.TabIndex = 0
        '
        'groupboxExportPDFDateiname
        '
        Me.groupboxExportPDFDateiname.Controls.Add(Me.textboxExportPDFDateinname)
        Me.groupboxExportPDFDateiname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxExportPDFDateiname.Location = New System.Drawing.Point(3, 368)
        Me.groupboxExportPDFDateiname.Name = "groupboxExportPDFDateiname"
        Me.groupboxExportPDFDateiname.Size = New System.Drawing.Size(793, 54)
        Me.groupboxExportPDFDateiname.TabIndex = 2
        Me.groupboxExportPDFDateiname.TabStop = False
        Me.groupboxExportPDFDateiname.Text = "Dateiname"
        '
        'textboxExportPDFDateinname
        '
        Me.textboxExportPDFDateinname.Location = New System.Drawing.Point(10, 22)
        Me.textboxExportPDFDateinname.Name = "textboxExportPDFDateinname"
        Me.textboxExportPDFDateinname.Size = New System.Drawing.Size(774, 20)
        Me.textboxExportPDFDateinname.TabIndex = 1
        '
        'buttonExportPDFAbbrechen
        '
        Me.buttonExportPDFAbbrechen.Location = New System.Drawing.Point(125, 445)
        Me.buttonExportPDFAbbrechen.Name = "buttonExportPDFAbbrechen"
        Me.buttonExportPDFAbbrechen.Size = New System.Drawing.Size(150, 25)
        Me.buttonExportPDFAbbrechen.TabIndex = 5
        Me.buttonExportPDFAbbrechen.Text = "Abbrechen"
        Me.buttonExportPDFAbbrechen.UseVisualStyleBackColor = True
        '
        'buttonExportPDFEinstellungenStandard
        '
        Me.buttonExportPDFEinstellungenStandard.Location = New System.Drawing.Point(280, 445)
        Me.buttonExportPDFEinstellungenStandard.Name = "buttonExportPDFEinstellungenStandard"
        Me.buttonExportPDFEinstellungenStandard.Size = New System.Drawing.Size(240, 25)
        Me.buttonExportPDFEinstellungenStandard.TabIndex = 6
        Me.buttonExportPDFEinstellungenStandard.Text = "Einstellungen als Standard übernehmen"
        Me.buttonExportPDFEinstellungenStandard.UseVisualStyleBackColor = True
        '
        'buttonExportPDFExport
        '
        Me.buttonExportPDFExport.Location = New System.Drawing.Point(525, 445)
        Me.buttonExportPDFExport.Name = "buttonExportPDFExport"
        Me.buttonExportPDFExport.Size = New System.Drawing.Size(150, 25)
        Me.buttonExportPDFExport.TabIndex = 7
        Me.buttonExportPDFExport.Text = "Exportieren"
        Me.buttonExportPDFExport.UseVisualStyleBackColor = True
        '
        'FormExportPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 486)
        Me.Controls.Add(Me.buttonExportPDFAbbrechen)
        Me.Controls.Add(Me.buttonExportPDFEinstellungenStandard)
        Me.Controls.Add(Me.buttonExportPDFExport)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormExportPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportieren in PDF"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupboxExportPDFOptionen.ResumeLayout(False)
        Me.groupboxExportPDFOptionen.PerformLayout()
        Me.groupboxExportPDFSpeicherpfad.ResumeLayout(False)
        Me.groupboxExportPDFSpeicherpfad.PerformLayout()
        Me.groupboxExportPDFDateiname.ResumeLayout(False)
        Me.groupboxExportPDFDateiname.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents groupboxExportPDFOptionen As GroupBox
    Friend WithEvents groupboxExportPDFSpeicherpfad As GroupBox
    Friend WithEvents groupboxExportPDFDateiname As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxExportPDFSeitenBis As TextBox
    Friend WithEvents textboxExportPDFSeitenVon As TextBox
    Friend WithEvents checkboxExportPDFAnhaengenZeit As CheckBox
    Friend WithEvents checkboxExportPDFAnhaengenDatum As CheckBox
    Friend WithEvents checkboxExportPDFAnhaengenTabellenname As CheckBox
    Friend WithEvents radiobuttonExportPDFKomprimierungJPEG As RadioButton
    Friend WithEvents radiobuttonExportPDFKomprimierungVerlustfrei As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents radiobuttonExportPDFSeiten As RadioButton
    Friend WithEvents radiobuttonExportPDFAlles As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents buttonExportPDFPfadWaehlen As Button
    Friend WithEvents textboxExportPDFPfadWaehlen As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents textboxExportPDFDateinname As TextBox
    Friend WithEvents buttonExportPDFAbbrechen As Button
    Friend WithEvents buttonExportPDFEinstellungenStandard As Button
    Friend WithEvents buttonExportPDFExport As Button
    Friend WithEvents radiobuttonExportPDFTabelle As RadioButton
End Class
