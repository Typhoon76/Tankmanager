<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEditRefuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditRefuel))
        Me.buttonEditRefuelSaveAndExit = New System.Windows.Forms.Button()
        Me.buttonEditRefuelCancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelVerbrauch = New System.Windows.Forms.TextBox()
        Me.groupboxNewRefuelVerbrauch = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelPreis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonEditRefuelDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelMenge = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datetimepickerEditRefuelTime = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.datetimepickerEditRefuelDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupboxNewRefuelTacho = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelGefahreneStrecke = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelTachostand = New System.Windows.Forms.TextBox()
        Me.groupboxNewRefuelGetankt = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelSumme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.groupboxNewRefuelVerbrauch.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupboxNewRefuelTacho.SuspendLayout()
        Me.groupboxNewRefuelGetankt.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonEditRefuelSaveAndExit
        '
        Me.buttonEditRefuelSaveAndExit.Location = New System.Drawing.Point(560, 260)
        Me.buttonEditRefuelSaveAndExit.Name = "buttonEditRefuelSaveAndExit"
        Me.buttonEditRefuelSaveAndExit.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRefuelSaveAndExit.TabIndex = 103
        Me.buttonEditRefuelSaveAndExit.Text = "Speichern && Schließen"
        Me.buttonEditRefuelSaveAndExit.UseVisualStyleBackColor = True
        '
        'buttonEditRefuelCancel
        '
        Me.buttonEditRefuelCancel.Location = New System.Drawing.Point(95, 260)
        Me.buttonEditRefuelCancel.Name = "buttonEditRefuelCancel"
        Me.buttonEditRefuelCancel.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRefuelCancel.TabIndex = 100
        Me.buttonEditRefuelCancel.Text = "Abbrechen"
        Me.buttonEditRefuelCancel.UseVisualStyleBackColor = True
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
        'textBoxEditRefuelVerbrauch
        '
        Me.textBoxEditRefuelVerbrauch.Enabled = False
        Me.textBoxEditRefuelVerbrauch.Location = New System.Drawing.Point(9, 35)
        Me.textBoxEditRefuelVerbrauch.Name = "textBoxEditRefuelVerbrauch"
        Me.textBoxEditRefuelVerbrauch.ReadOnly = True
        Me.textBoxEditRefuelVerbrauch.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelVerbrauch.TabIndex = 2
        Me.textBoxEditRefuelVerbrauch.TabStop = False
        '
        'groupboxNewRefuelVerbrauch
        '
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.Label11)
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.Label10)
        Me.groupboxNewRefuelVerbrauch.Controls.Add(Me.textBoxEditRefuelVerbrauch)
        Me.groupboxNewRefuelVerbrauch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRefuelVerbrauch.Location = New System.Drawing.Point(535, 3)
        Me.groupboxNewRefuelVerbrauch.Name = "groupboxNewRefuelVerbrauch"
        Me.groupboxNewRefuelVerbrauch.Size = New System.Drawing.Size(261, 114)
        Me.groupboxNewRefuelVerbrauch.TabIndex = 1
        Me.groupboxNewRefuelVerbrauch.TabStop = False
        Me.groupboxNewRefuelVerbrauch.Text = "Verbrauch"
        '
        'textBoxEditRefuelPreis
        '
        Me.textBoxEditRefuelPreis.Enabled = False
        Me.textBoxEditRefuelPreis.Location = New System.Drawing.Point(9, 35)
        Me.textBoxEditRefuelPreis.Name = "textBoxEditRefuelPreis"
        Me.textBoxEditRefuelPreis.ReadOnly = True
        Me.textBoxEditRefuelPreis.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelPreis.TabIndex = 3
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textBoxEditRefuelPreis)
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
        'buttonEditRefuelDelete
        '
        Me.buttonEditRefuelDelete.Location = New System.Drawing.Point(324, 260)
        Me.buttonEditRefuelDelete.Name = "buttonEditRefuelDelete"
        Me.buttonEditRefuelDelete.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRefuelDelete.TabIndex = 102
        Me.buttonEditRefuelDelete.Text = "Eintrag löschen"
        Me.buttonEditRefuelDelete.UseVisualStyleBackColor = True
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
        'textBoxEditRefuelMenge
        '
        Me.textBoxEditRefuelMenge.Location = New System.Drawing.Point(9, 35)
        Me.textBoxEditRefuelMenge.Name = "textBoxEditRefuelMenge"
        Me.textBoxEditRefuelMenge.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelMenge.TabIndex = 2
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
        Me.TableLayoutPanel1.TabIndex = 104
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
        Me.GroupBox1.Controls.Add(Me.datetimepickerEditRefuelTime)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.datetimepickerEditRefuelDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datum und Uhrzeit"
        '
        'datetimepickerEditRefuelTime
        '
        Me.datetimepickerEditRefuelTime.Location = New System.Drawing.Point(9, 80)
        Me.datetimepickerEditRefuelTime.Name = "datetimepickerEditRefuelTime"
        Me.datetimepickerEditRefuelTime.ShowUpDown = True
        Me.datetimepickerEditRefuelTime.Size = New System.Drawing.Size(100, 20)
        Me.datetimepickerEditRefuelTime.TabIndex = 1
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
        'datetimepickerEditRefuelDate
        '
        Me.datetimepickerEditRefuelDate.Location = New System.Drawing.Point(9, 35)
        Me.datetimepickerEditRefuelDate.Name = "datetimepickerEditRefuelDate"
        Me.datetimepickerEditRefuelDate.Size = New System.Drawing.Size(200, 20)
        Me.datetimepickerEditRefuelDate.TabIndex = 0
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
        Me.groupboxNewRefuelTacho.Controls.Add(Me.textBoxEditRefuelGefahreneStrecke)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label9)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label6)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label7)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.Label8)
        Me.groupboxNewRefuelTacho.Controls.Add(Me.textBoxEditRefuelTachostand)
        Me.groupboxNewRefuelTacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRefuelTacho.Location = New System.Drawing.Point(535, 3)
        Me.groupboxNewRefuelTacho.Name = "groupboxNewRefuelTacho"
        Me.groupboxNewRefuelTacho.Size = New System.Drawing.Size(261, 114)
        Me.groupboxNewRefuelTacho.TabIndex = 2
        Me.groupboxNewRefuelTacho.TabStop = False
        Me.groupboxNewRefuelTacho.Text = "Tacho"
        '
        'textBoxEditRefuelGefahreneStrecke
        '
        Me.textBoxEditRefuelGefahreneStrecke.Location = New System.Drawing.Point(9, 35)
        Me.textBoxEditRefuelGefahreneStrecke.Name = "textBoxEditRefuelGefahreneStrecke"
        Me.textBoxEditRefuelGefahreneStrecke.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelGefahreneStrecke.TabIndex = 4
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
        'textBoxEditRefuelTachostand
        '
        Me.textBoxEditRefuelTachostand.Location = New System.Drawing.Point(9, 80)
        Me.textBoxEditRefuelTachostand.Name = "textBoxEditRefuelTachostand"
        Me.textBoxEditRefuelTachostand.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelTachostand.TabIndex = 5
        '
        'groupboxNewRefuelGetankt
        '
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.Label4)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.textBoxEditRefuelMenge)
        Me.groupboxNewRefuelGetankt.Controls.Add(Me.textBoxEditRefuelSumme)
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
        'textBoxEditRefuelSumme
        '
        Me.textBoxEditRefuelSumme.Location = New System.Drawing.Point(9, 80)
        Me.textBoxEditRefuelSumme.Name = "textBoxEditRefuelSumme"
        Me.textBoxEditRefuelSumme.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelSumme.TabIndex = 2
        Me.textBoxEditRefuelSumme.TabStop = False
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
        'formEditRefuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 301)
        Me.Controls.Add(Me.buttonEditRefuelSaveAndExit)
        Me.Controls.Add(Me.buttonEditRefuelCancel)
        Me.Controls.Add(Me.buttonEditRefuelDelete)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(815, 340)
        Me.MinimumSize = New System.Drawing.Size(815, 340)
        Me.Name = "formEditRefuel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eintrag bearbeiten"
        Me.groupboxNewRefuelVerbrauch.ResumeLayout(False)
        Me.groupboxNewRefuelVerbrauch.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupboxNewRefuelTacho.ResumeLayout(False)
        Me.groupboxNewRefuelTacho.PerformLayout()
        Me.groupboxNewRefuelGetankt.ResumeLayout(False)
        Me.groupboxNewRefuelGetankt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonEditRefuelSaveAndExit As Button
    Friend WithEvents buttonEditRefuelCancel As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents textBoxEditRefuelVerbrauch As TextBox
    Friend WithEvents groupboxNewRefuelVerbrauch As GroupBox
    Friend WithEvents textBoxEditRefuelPreis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents buttonEditRefuelDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxEditRefuelMenge As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents datetimepickerEditRefuelTime As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents datetimepickerEditRefuelDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents groupboxNewRefuelTacho As GroupBox
    Friend WithEvents textBoxEditRefuelGefahreneStrecke As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textBoxEditRefuelTachostand As TextBox
    Friend WithEvents groupboxNewRefuelGetankt As GroupBox
    Friend WithEvents textBoxEditRefuelSumme As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
