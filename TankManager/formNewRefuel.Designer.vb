<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewRefuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewRefuel))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datetimepickerNewRefuelTime = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.datetimepickerNewRefuelDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupboxNewRefuelTacho = New System.Windows.Forms.GroupBox()
        Me.textBoxNewRefuelGefahreneStrecke = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textBoxNewRefuelTachostand = New System.Windows.Forms.TextBox()
        Me.groupboxNewRefuelGetankt = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textBoxNewRefuelMenge = New System.Windows.Forms.TextBox()
        Me.textBoxNewRefuelSumme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textBoxNewRefuelPreis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupboxNewRefuelVerbrauch = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textBoxNewRefuelVerbrauch = New System.Windows.Forms.TextBox()
        Me.buttonNewRefuelCancel = New System.Windows.Forms.Button()
        Me.buttonNewRefuelReset = New System.Windows.Forms.Button()
        Me.buttonNewRefuelSaveAndNew = New System.Windows.Forms.Button()
        Me.buttonNewRefuelSaveAndExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupboxNewRefuelTacho.SuspendLayout()
        Me.groupboxNewRefuelGetankt.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupboxNewRefuelVerbrauch.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 240)
        Me.TableLayoutPanel1.TabIndex = 99
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.groupboxNewRefuelTacho, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.groupboxNewRefuelGetankt, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(799, 120)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datetimepickerNewRefuelTime)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.datetimepickerNewRefuelDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datum und Uhrzeit"
        '
        'datetimepickerNewRefuelTime
        '
        Me.datetimepickerNewRefuelTime.Location = New System.Drawing.Point(9, 80)
        Me.datetimepickerNewRefuelTime.Name = "datetimepickerNewRefuelTime"
        Me.datetimepickerNewRefuelTime.ShowUpDown = True
        Me.datetimepickerNewRefuelTime.Size = New System.Drawing.Size(100, 20)
        Me.datetimepickerNewRefuelTime.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Uhrzeit"
        '
        'datetimepickerNewRefuelDate
        '
        Me.datetimepickerNewRefuelDate.Location = New System.Drawing.Point(9, 35)
        Me.datetimepickerNewRefuelDate.Name = "datetimepickerNewRefuelDate"
        Me.datetimepickerNewRefuelDate.Size = New System.Drawing.Size(200, 20)
        Me.datetimepickerNewRefuelDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datum"
        '
        'groupboxNewRefuelTacho
        '
        Me.groupboxNewRefuelTacho.Controls.Add(Me.textBoxNewRefuelGefahreneStrecke)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label9)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label6)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label7)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label8)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.textBoxNewRefuelTachostand)
        Me.groupboxNewRefuelTacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRefuelTacho.Location = New System.Drawing.Point(535, 3)
        Me.groupboxNewRefuelTacho.Name = "groupboxNewRefuelTacho"
        Me.groupboxNewRefuelTacho.Size = New System.Drawing.Size(261, 114)
        Me.groupboxNewRefuelTacho.TabIndex = 2
        Me.groupboxNewRefuelTacho.TabStop = False
        Me.groupboxNewRefuelTacho.Text = "Tacho"
        '
        'textBoxNewRefuelGefahreneStrecke
        '
        Me.textBoxNewRefuelGefahreneStrecke.Location = New System.Drawing.Point(9, 35)
        Me.textBoxNewRefuelGefahreneStrecke.Name = "textBoxNewRefuelGefahreneStrecke"
        Me.textBoxNewRefuelGefahreneStrecke.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelGefahreneStrecke.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Km"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "gefahrene Strecke"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Km"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tachostand"
        '
        'textBoxNewRefuelTachostand
        '
        Me.textBoxNewRefuelTachostand.Location = New System.Drawing.Point(9, 80)
        Me.textBoxNewRefuelTachostand.Name = "textBoxNewRefuelTachostand"
        Me.textBoxNewRefuelTachostand.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelTachostand.TabIndex = 5
        '
        'groupboxNewRefuelGetankt
        '
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.Label4)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.textBoxNewRefuelMenge)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.textBoxNewRefuelSumme)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.Label2)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.Label13)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.Label14)
        Me.groupboxNewRefuelGetankt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRefuelGetankt.Location = New System.Drawing.Point(269, 3)
        Me.groupboxNewRefuelGetankt.Name = "groupboxNewRefuelGetankt"
        Me.groupboxNewRefuelGetankt.Size = New System.Drawing.Size(260, 114)
        Me.groupboxNewRefuelGetankt.TabIndex = 1
        Me.groupboxNewRefuelGetankt.TabStop = False
        Me.groupboxNewRefuelGetankt.Text = "Getankt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Liter"
        '
        'textBoxNewRefuelMenge
        '
        Me.textBoxNewRefuelMenge.Location = New System.Drawing.Point(9, 35)
        Me.textBoxNewRefuelMenge.Name = "textBoxNewRefuelMenge"
        Me.textBoxNewRefuelMenge.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelMenge.TabIndex = 2
        '
        'textBoxNewRefuelSumme
        '
        Me.textBoxNewRefuelSumme.Location = New System.Drawing.Point(9, 80)
        Me.textBoxNewRefuelSumme.Name = "textBoxNewRefuelSumme"
        Me.textBoxNewRefuelSumme.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelSumme.TabIndex = 2
        Me.textBoxNewRefuelSumme.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Menge"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Summe"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(110, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "EUR"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.groupboxNewRefuelVerbrauch, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(799, 120)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textBoxNewRefuelPreis)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(269, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 114)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Einzelangaben"
        '
        'textBoxNewRefuelPreis
        '
        Me.textBoxNewRefuelPreis.Enabled = False
        Me.textBoxNewRefuelPreis.Location = New System.Drawing.Point(9, 35)
        Me.textBoxNewRefuelPreis.Name = "textBoxNewRefuelPreis"
        Me.textBoxNewRefuelPreis.ReadOnly = True
        Me.textBoxNewRefuelPreis.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelPreis.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Preis/Liter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "EUR"
        '
        'groupboxNewRefuelVerbrauch
        '
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.Label11)
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.Label10)
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.textBoxNewRefuelVerbrauch)
        Me.groupboxNewRefuelVerbrauch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRefuelVerbrauch.Location = New System.Drawing.Point(535, 3)
        Me.groupboxNewRefuelVerbrauch.Name = "groupboxNewRefuelVerbrauch"
        Me.groupboxNewRefuelVerbrauch.Size = New System.Drawing.Size(261, 114)
        Me.groupboxNewRefuelVerbrauch.TabIndex = 1
        Me.groupboxNewRefuelVerbrauch.TabStop = False
        Me.groupboxNewRefuelVerbrauch.Text = "Verbrauch"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(110, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Liter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "pro 100 Km"
        '
        'textBoxNewRefuelVerbrauch
        '
        Me.textBoxNewRefuelVerbrauch.Enabled = False
        Me.textBoxNewRefuelVerbrauch.Location = New System.Drawing.Point(9, 35)
        Me.textBoxNewRefuelVerbrauch.Name = "textBoxNewRefuelVerbrauch"
        Me.textBoxNewRefuelVerbrauch.ReadOnly = True
        Me.textBoxNewRefuelVerbrauch.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNewRefuelVerbrauch.TabIndex = 2
        Me.textBoxNewRefuelVerbrauch.TabStop = False
        '
        'buttonNewRefuelCancel
        '
        Me.buttonNewRefuelCancel.Location = New System.Drawing.Point(95, 260)
        Me.buttonNewRefuelCancel.Name = "buttonNewRefuelCancel"
        Me.buttonNewRefuelCancel.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRefuelCancel.TabIndex = 1
        Me.buttonNewRefuelCancel.Text = "Abbrechen"
        Me.buttonNewRefuelCancel.UseVisualStyleBackColor = True
        '
        'buttonNewRefuelReset
        '
        Me.buttonNewRefuelReset.Location = New System.Drawing.Point(250, 260)
        Me.buttonNewRefuelReset.Name = "buttonNewRefuelReset"
        Me.buttonNewRefuelReset.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRefuelReset.TabIndex = 2
        Me.buttonNewRefuelReset.Text = "Zurücksetzen"
        Me.buttonNewRefuelReset.UseVisualStyleBackColor = True
        '
        'buttonNewRefuelSaveAndNew
        '
        Me.buttonNewRefuelSaveAndNew.Location = New System.Drawing.Point(405, 260)
        Me.buttonNewRefuelSaveAndNew.Name = "buttonNewRefuelSaveAndNew"
        Me.buttonNewRefuelSaveAndNew.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRefuelSaveAndNew.TabIndex = 3
        Me.buttonNewRefuelSaveAndNew.Text = "Speichern && Neuer Eintrag"
        Me.buttonNewRefuelSaveAndNew.UseVisualStyleBackColor = True
        '
        'buttonNewRefuelSaveAndExit
        '
        Me.buttonNewRefuelSaveAndExit.Location = New System.Drawing.Point(560, 260)
        Me.buttonNewRefuelSaveAndExit.Name = "buttonNewRefuelSaveAndExit"
        Me.buttonNewRefuelSaveAndExit.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRefuelSaveAndExit.TabIndex = 4
        Me.buttonNewRefuelSaveAndExit.Text = "Speichern && Schließen"
        Me.buttonNewRefuelSaveAndExit.UseVisualStyleBackColor = True
        '
        'FormNewRefuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 301)
        Me.Controls.Add(Me.buttonNewRefuelSaveAndExit)
        Me.Controls.Add(Me.buttonNewRefuelCancel)
        Me.Controls.Add(Me.buttonNewRefuelReset)
        Me.Controls.Add(Me.buttonNewRefuelSaveAndNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(815, 340)
        Me.MinimumSize = New System.Drawing.Size(815, 340)
        Me.Name = "FormNewRefuel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neuen Eintrag erstellen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupboxNewRefuelTacho.ResumeLayout(False)
        Me.groupboxNewRefuelTacho.PerformLayout()
        Me.groupboxNewRefuelGetankt.ResumeLayout(False)
        Me.groupboxNewRefuelGetankt.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupboxNewRefuelVerbrauch.ResumeLayout(False)
        Me.groupboxNewRefuelVerbrauch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents buttonNewRefuelCancel As Button
    Friend WithEvents buttonNewRefuelReset As Button
    Friend WithEvents buttonNewRefuelSaveAndNew As Button
    Friend WithEvents groupboxNewRefuelVerbrauch As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxNewRefuelPreis As TextBox
    Friend WithEvents textBoxNewRefuelMenge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents datetimepickerNewRefuelDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents textBoxNewRefuelTachostand As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textBoxNewRefuelGefahreneStrecke As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents textBoxNewRefuelVerbrauch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents buttonNewRefuelSaveAndExit As Button
    Friend WithEvents textBoxNewRefuelSumme As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents groupboxNewRefuelTacho As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents groupboxNewRefuelGetankt As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents datetimepickerNewRefuelTime As DateTimePicker
    Friend WithEvents Label12 As Label
End Class
