<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditRefuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditRefuel))
        Me.buttonEditRefuelSaveAndExit = New System.Windows.Forms.Button()
        Me.buttonEditRefuelCancel = New System.Windows.Forms.Button()
        Me.FormEditRefuelLabelConsumptionLitre = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelConsumption = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelVerbrauch = New System.Windows.Forms.TextBox()
        Me.FormEditRefuelGroupboxConsumption = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelPreis = New System.Windows.Forms.TextBox()
        Me.FormEditRefuelLabelCosts = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelCostsCurrency = New System.Windows.Forms.Label()
        Me.FormEditRefuelGroupboxCosts = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonEditRefuelDelete = New System.Windows.Forms.Button()
        Me.FormEditRefuelLabelQuantityLitre = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelMenge = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FormEditRefuelGroupboxDateandTime = New System.Windows.Forms.GroupBox()
        Me.datetimepickerEditRefuelTime = New System.Windows.Forms.DateTimePicker()
        Me.FormEditRefuelLabelTime = New System.Windows.Forms.Label()
        Me.datetimepickerEditRefuelDate = New System.Windows.Forms.DateTimePicker()
        Me.FormEditRefuelLabelDate = New System.Windows.Forms.Label()
        Me.FormEditRefuelGroupboxSpeedometer = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelGefahreneStrecke = New System.Windows.Forms.TextBox()
        Me.FormEditRefuelLabelMileageKm = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelDriven = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelDrivenKm = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelMileage = New System.Windows.Forms.Label()
        Me.textBoxEditRefuelTachostand = New System.Windows.Forms.TextBox()
        Me.FormEditRefuelGroupboxFuelled = New System.Windows.Forms.GroupBox()
        Me.textBoxEditRefuelSumme = New System.Windows.Forms.TextBox()
        Me.FormEditRefuelLabelQuantity = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelTotal = New System.Windows.Forms.Label()
        Me.FormEditRefuelLabelTotalCurrency = New System.Windows.Forms.Label()
        Me.FormEditRefuelGroupboxConsumption.SuspendLayout()
        Me.FormEditRefuelGroupboxCosts.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FormEditRefuelGroupboxDateandTime.SuspendLayout()
        Me.FormEditRefuelGroupboxSpeedometer.SuspendLayout()
        Me.FormEditRefuelGroupboxFuelled.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonEditRefuelSaveAndExit
        '
        Me.buttonEditRefuelSaveAndExit.Location = New System.Drawing.Point(560, 260)
        Me.buttonEditRefuelSaveAndExit.Name = "buttonEditRefuelSaveAndExit"
        Me.buttonEditRefuelSaveAndExit.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRefuelSaveAndExit.TabIndex = 103
        Me.buttonEditRefuelSaveAndExit.Text = "Save && Exit"
        Me.buttonEditRefuelSaveAndExit.UseVisualStyleBackColor = True
        '
        'buttonEditRefuelCancel
        '
        Me.buttonEditRefuelCancel.Location = New System.Drawing.Point(95, 260)
        Me.buttonEditRefuelCancel.Name = "buttonEditRefuelCancel"
        Me.buttonEditRefuelCancel.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRefuelCancel.TabIndex = 100
        Me.buttonEditRefuelCancel.Text = "Cancel"
        Me.buttonEditRefuelCancel.UseVisualStyleBackColor = True
        '
        'FormEditRefuelLabelConsumptionLitre
        '
        Me.FormEditRefuelLabelConsumptionLitre.AutoSize = True
        Me.FormEditRefuelLabelConsumptionLitre.Location = New System.Drawing.Point(110, 38)
        Me.FormEditRefuelLabelConsumptionLitre.Name = "FormEditRefuelLabelConsumptionLitre"
        Me.FormEditRefuelLabelConsumptionLitre.Size = New System.Drawing.Size(27, 13)
        Me.FormEditRefuelLabelConsumptionLitre.TabIndex = 1
        Me.FormEditRefuelLabelConsumptionLitre.Text = "Liter"
        '
        'FormEditRefuelLabelConsumption
        '
        Me.FormEditRefuelLabelConsumption.AutoSize = True
        Me.FormEditRefuelLabelConsumption.Location = New System.Drawing.Point(6, 20)
        Me.FormEditRefuelLabelConsumption.Name = "FormEditRefuelLabelConsumption"
        Me.FormEditRefuelLabelConsumption.Size = New System.Drawing.Size(61, 13)
        Me.FormEditRefuelLabelConsumption.TabIndex = 0
        Me.FormEditRefuelLabelConsumption.Text = "per 100 Km"
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
        'FormEditRefuelGroupboxConsumption
        '
        Me.FormEditRefuelGroupboxConsumption.Controls.Add(Me.FormEditRefuelLabelConsumptionLitre)
        Me.FormEditRefuelGroupboxConsumption.Controls.Add(Me.FormEditRefuelLabelConsumption)
        Me.FormEditRefuelGroupboxConsumption.Controls.Add(Me.textBoxEditRefuelVerbrauch)
        Me.FormEditRefuelGroupboxConsumption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormEditRefuelGroupboxConsumption.Location = New System.Drawing.Point(535, 3)
        Me.FormEditRefuelGroupboxConsumption.Name = "FormEditRefuelGroupboxConsumption"
        Me.FormEditRefuelGroupboxConsumption.Size = New System.Drawing.Size(261, 114)
        Me.FormEditRefuelGroupboxConsumption.TabIndex = 1
        Me.FormEditRefuelGroupboxConsumption.TabStop = False
        Me.FormEditRefuelGroupboxConsumption.Text = "Consumption"
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
        'FormEditRefuelLabelCosts
        '
        Me.FormEditRefuelLabelCosts.AutoSize = True
        Me.FormEditRefuelLabelCosts.Location = New System.Drawing.Point(6, 20)
        Me.FormEditRefuelLabelCosts.Name = "FormEditRefuelLabelCosts"
        Me.FormEditRefuelLabelCosts.Size = New System.Drawing.Size(64, 13)
        Me.FormEditRefuelLabelCosts.TabIndex = 3
        Me.FormEditRefuelLabelCosts.Text = "Costs / Litre"
        '
        'FormEditRefuelLabelCostsCurrency
        '
        Me.FormEditRefuelLabelCostsCurrency.AutoSize = True
        Me.FormEditRefuelLabelCostsCurrency.Location = New System.Drawing.Point(110, 38)
        Me.FormEditRefuelLabelCostsCurrency.Name = "FormEditRefuelLabelCostsCurrency"
        Me.FormEditRefuelLabelCostsCurrency.Size = New System.Drawing.Size(30, 13)
        Me.FormEditRefuelLabelCostsCurrency.TabIndex = 2
        Me.FormEditRefuelLabelCostsCurrency.Text = "EUR"
        '
        'FormEditRefuelGroupboxCosts
        '
        Me.FormEditRefuelGroupboxCosts.Controls.Add(Me.textBoxEditRefuelPreis)
        Me.FormEditRefuelGroupboxCosts.Controls.Add(Me.FormEditRefuelLabelCosts)
        Me.FormEditRefuelGroupboxCosts.Controls.Add(Me.FormEditRefuelLabelCostsCurrency)
        Me.FormEditRefuelGroupboxCosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormEditRefuelGroupboxCosts.Location = New System.Drawing.Point(269, 3)
        Me.FormEditRefuelGroupboxCosts.Name = "FormEditRefuelGroupboxCosts"
        Me.FormEditRefuelGroupboxCosts.Size = New System.Drawing.Size(260, 114)
        Me.FormEditRefuelGroupboxCosts.TabIndex = 0
        Me.FormEditRefuelGroupboxCosts.TabStop = False
        Me.FormEditRefuelGroupboxCosts.Text = "Costs"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.FormEditRefuelGroupboxCosts, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FormEditRefuelGroupboxConsumption, 2, 0)
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
        Me.buttonEditRefuelDelete.Text = "Delete Entry"
        Me.buttonEditRefuelDelete.UseVisualStyleBackColor = True
        '
        'FormEditRefuelLabelQuantityLitre
        '
        Me.FormEditRefuelLabelQuantityLitre.AutoSize = True
        Me.FormEditRefuelLabelQuantityLitre.Location = New System.Drawing.Point(110, 38)
        Me.FormEditRefuelLabelQuantityLitre.Name = "FormEditRefuelLabelQuantityLitre"
        Me.FormEditRefuelLabelQuantityLitre.Size = New System.Drawing.Size(27, 13)
        Me.FormEditRefuelLabelQuantityLitre.TabIndex = 1
        Me.FormEditRefuelLabelQuantityLitre.Text = "Liter"
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
        Me.TableLayoutPanel2.Controls.Add(Me.FormEditRefuelGroupboxDateandTime, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FormEditRefuelGroupboxSpeedometer, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FormEditRefuelGroupboxFuelled, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(799, 120)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'FormEditRefuelGroupboxDateandTime
        '
        Me.FormEditRefuelGroupboxDateandTime.Controls.Add(Me.datetimepickerEditRefuelTime)
        Me.FormEditRefuelGroupboxDateandTime.Controls.Add(Me.FormEditRefuelLabelTime)
        Me.FormEditRefuelGroupboxDateandTime.Controls.Add(Me.datetimepickerEditRefuelDate)
        Me.FormEditRefuelGroupboxDateandTime.Controls.Add(Me.FormEditRefuelLabelDate)
        Me.FormEditRefuelGroupboxDateandTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormEditRefuelGroupboxDateandTime.Location = New System.Drawing.Point(3, 3)
        Me.FormEditRefuelGroupboxDateandTime.Name = "FormEditRefuelGroupboxDateandTime"
        Me.FormEditRefuelGroupboxDateandTime.Size = New System.Drawing.Size(260, 114)
        Me.FormEditRefuelGroupboxDateandTime.TabIndex = 0
        Me.FormEditRefuelGroupboxDateandTime.TabStop = False
        Me.FormEditRefuelGroupboxDateandTime.Text = "Date and Time"
        '
        'datetimepickerEditRefuelTime
        '
        Me.datetimepickerEditRefuelTime.Location = New System.Drawing.Point(9, 80)
        Me.datetimepickerEditRefuelTime.Name = "datetimepickerEditRefuelTime"
        Me.datetimepickerEditRefuelTime.ShowUpDown = True
        Me.datetimepickerEditRefuelTime.Size = New System.Drawing.Size(100, 20)
        Me.datetimepickerEditRefuelTime.TabIndex = 1
        '
        'FormEditRefuelLabelTime
        '
        Me.FormEditRefuelLabelTime.AutoSize = True
        Me.FormEditRefuelLabelTime.Location = New System.Drawing.Point(6, 65)
        Me.FormEditRefuelLabelTime.Name = "FormEditRefuelLabelTime"
        Me.FormEditRefuelLabelTime.Size = New System.Drawing.Size(30, 13)
        Me.FormEditRefuelLabelTime.TabIndex = 0
        Me.FormEditRefuelLabelTime.Text = "Time"
        '
        'datetimepickerEditRefuelDate
        '
        Me.datetimepickerEditRefuelDate.Location = New System.Drawing.Point(9, 35)
        Me.datetimepickerEditRefuelDate.Name = "datetimepickerEditRefuelDate"
        Me.datetimepickerEditRefuelDate.Size = New System.Drawing.Size(200, 20)
        Me.datetimepickerEditRefuelDate.TabIndex = 0
        '
        'FormEditRefuelLabelDate
        '
        Me.FormEditRefuelLabelDate.AutoSize = True
        Me.FormEditRefuelLabelDate.Location = New System.Drawing.Point(6, 20)
        Me.FormEditRefuelLabelDate.Name = "FormEditRefuelLabelDate"
        Me.FormEditRefuelLabelDate.Size = New System.Drawing.Size(30, 13)
        Me.FormEditRefuelLabelDate.TabIndex = 1
        Me.FormEditRefuelLabelDate.Text = "Date"
        '
        'FormEditRefuelGroupboxSpeedometer
        '
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.textBoxEditRefuelGefahreneStrecke)
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.FormEditRefuelLabelMileageKm)
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.FormEditRefuelLabelDriven)
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.FormEditRefuelLabelDrivenKm)
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.FormEditRefuelLabelMileage)
        Me.FormEditRefuelGroupboxSpeedometer.Controls.Add(Me.textBoxEditRefuelTachostand)
        Me.FormEditRefuelGroupboxSpeedometer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormEditRefuelGroupboxSpeedometer.Location = New System.Drawing.Point(535, 3)
        Me.FormEditRefuelGroupboxSpeedometer.Name = "FormEditRefuelGroupboxSpeedometer"
        Me.FormEditRefuelGroupboxSpeedometer.Size = New System.Drawing.Size(261, 114)
        Me.FormEditRefuelGroupboxSpeedometer.TabIndex = 2
        Me.FormEditRefuelGroupboxSpeedometer.TabStop = False
        Me.FormEditRefuelGroupboxSpeedometer.Text = "Speedometer"
        '
        'textBoxEditRefuelGefahreneStrecke
        '
        Me.textBoxEditRefuelGefahreneStrecke.Location = New System.Drawing.Point(9, 35)
        Me.textBoxEditRefuelGefahreneStrecke.Name = "textBoxEditRefuelGefahreneStrecke"
        Me.textBoxEditRefuelGefahreneStrecke.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelGefahreneStrecke.TabIndex = 4
        '
        'FormEditRefuelLabelMileageKm
        '
        Me.FormEditRefuelLabelMileageKm.AutoSize = True
        Me.FormEditRefuelLabelMileageKm.Location = New System.Drawing.Point(110, 84)
        Me.FormEditRefuelLabelMileageKm.Name = "FormEditRefuelLabelMileageKm"
        Me.FormEditRefuelLabelMileageKm.Size = New System.Drawing.Size(22, 13)
        Me.FormEditRefuelLabelMileageKm.TabIndex = 2
        Me.FormEditRefuelLabelMileageKm.Text = "Km"
        '
        'FormEditRefuelLabelDriven
        '
        Me.FormEditRefuelLabelDriven.AutoSize = True
        Me.FormEditRefuelLabelDriven.Location = New System.Drawing.Point(6, 20)
        Me.FormEditRefuelLabelDriven.Name = "FormEditRefuelLabelDriven"
        Me.FormEditRefuelLabelDriven.Size = New System.Drawing.Size(38, 13)
        Me.FormEditRefuelLabelDriven.TabIndex = 0
        Me.FormEditRefuelLabelDriven.Text = "Driven"
        '
        'FormEditRefuelLabelDrivenKm
        '
        Me.FormEditRefuelLabelDrivenKm.AutoSize = True
        Me.FormEditRefuelLabelDrivenKm.Location = New System.Drawing.Point(110, 38)
        Me.FormEditRefuelLabelDrivenKm.Name = "FormEditRefuelLabelDrivenKm"
        Me.FormEditRefuelLabelDrivenKm.Size = New System.Drawing.Size(22, 13)
        Me.FormEditRefuelLabelDrivenKm.TabIndex = 1
        Me.FormEditRefuelLabelDrivenKm.Text = "Km"
        '
        'FormEditRefuelLabelMileage
        '
        Me.FormEditRefuelLabelMileage.AutoSize = True
        Me.FormEditRefuelLabelMileage.Location = New System.Drawing.Point(6, 65)
        Me.FormEditRefuelLabelMileage.Name = "FormEditRefuelLabelMileage"
        Me.FormEditRefuelLabelMileage.Size = New System.Drawing.Size(44, 13)
        Me.FormEditRefuelLabelMileage.TabIndex = 3
        Me.FormEditRefuelLabelMileage.Text = "Mileage"
        '
        'textBoxEditRefuelTachostand
        '
        Me.textBoxEditRefuelTachostand.Location = New System.Drawing.Point(9, 80)
        Me.textBoxEditRefuelTachostand.Name = "textBoxEditRefuelTachostand"
        Me.textBoxEditRefuelTachostand.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelTachostand.TabIndex = 5
        '
        'FormEditRefuelGroupboxFuelled
        '
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.FormEditRefuelLabelQuantityLitre)
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.textBoxEditRefuelMenge)
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.textBoxEditRefuelSumme)
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.FormEditRefuelLabelQuantity)
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.FormEditRefuelLabelTotal)
        Me.FormEditRefuelGroupboxFuelled.Controls.Add(Me.FormEditRefuelLabelTotalCurrency)
        Me.FormEditRefuelGroupboxFuelled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormEditRefuelGroupboxFuelled.Location = New System.Drawing.Point(269, 3)
        Me.FormEditRefuelGroupboxFuelled.Name = "FormEditRefuelGroupboxFuelled"
        Me.FormEditRefuelGroupboxFuelled.Size = New System.Drawing.Size(260, 114)
        Me.FormEditRefuelGroupboxFuelled.TabIndex = 1
        Me.FormEditRefuelGroupboxFuelled.TabStop = False
        Me.FormEditRefuelGroupboxFuelled.Text = "Fuelled"
        '
        'textBoxEditRefuelSumme
        '
        Me.textBoxEditRefuelSumme.Location = New System.Drawing.Point(9, 80)
        Me.textBoxEditRefuelSumme.Name = "textBoxEditRefuelSumme"
        Me.textBoxEditRefuelSumme.Size = New System.Drawing.Size(100, 20)
        Me.textBoxEditRefuelSumme.TabIndex = 2
        Me.textBoxEditRefuelSumme.TabStop = False
        '
        'FormEditRefuelLabelQuantity
        '
        Me.FormEditRefuelLabelQuantity.AutoSize = True
        Me.FormEditRefuelLabelQuantity.Location = New System.Drawing.Point(6, 20)
        Me.FormEditRefuelLabelQuantity.Name = "FormEditRefuelLabelQuantity"
        Me.FormEditRefuelLabelQuantity.Size = New System.Drawing.Size(46, 13)
        Me.FormEditRefuelLabelQuantity.TabIndex = 0
        Me.FormEditRefuelLabelQuantity.Text = "Quantity"
        '
        'FormEditRefuelLabelTotal
        '
        Me.FormEditRefuelLabelTotal.AutoSize = True
        Me.FormEditRefuelLabelTotal.Location = New System.Drawing.Point(6, 65)
        Me.FormEditRefuelLabelTotal.Name = "FormEditRefuelLabelTotal"
        Me.FormEditRefuelLabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.FormEditRefuelLabelTotal.TabIndex = 0
        Me.FormEditRefuelLabelTotal.Text = "Total"
        '
        'FormEditRefuelLabelTotalCurrency
        '
        Me.FormEditRefuelLabelTotalCurrency.AutoSize = True
        Me.FormEditRefuelLabelTotalCurrency.Location = New System.Drawing.Point(110, 84)
        Me.FormEditRefuelLabelTotalCurrency.Name = "FormEditRefuelLabelTotalCurrency"
        Me.FormEditRefuelLabelTotalCurrency.Size = New System.Drawing.Size(30, 13)
        Me.FormEditRefuelLabelTotalCurrency.TabIndex = 1
        Me.FormEditRefuelLabelTotalCurrency.Text = "EUR"
        '
        'FormEditRefuel
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
        Me.Name = "FormEditRefuel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Entry"
        Me.FormEditRefuelGroupboxConsumption.ResumeLayout(False)
        Me.FormEditRefuelGroupboxConsumption.PerformLayout()
        Me.FormEditRefuelGroupboxCosts.ResumeLayout(False)
        Me.FormEditRefuelGroupboxCosts.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FormEditRefuelGroupboxDateandTime.ResumeLayout(False)
        Me.FormEditRefuelGroupboxDateandTime.PerformLayout()
        Me.FormEditRefuelGroupboxSpeedometer.ResumeLayout(False)
        Me.FormEditRefuelGroupboxSpeedometer.PerformLayout()
        Me.FormEditRefuelGroupboxFuelled.ResumeLayout(False)
        Me.FormEditRefuelGroupboxFuelled.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonEditRefuelSaveAndExit As Button
    Friend WithEvents buttonEditRefuelCancel As Button
    Friend WithEvents FormEditRefuelLabelConsumptionLitre As Label
    Friend WithEvents FormEditRefuelLabelConsumption As Label
    Friend WithEvents textBoxEditRefuelVerbrauch As TextBox
    Friend WithEvents FormEditRefuelGroupboxConsumption As GroupBox
    Friend WithEvents textBoxEditRefuelPreis As TextBox
    Friend WithEvents FormEditRefuelLabelCosts As Label
    Friend WithEvents FormEditRefuelLabelCostsCurrency As Label
    Friend WithEvents FormEditRefuelGroupboxCosts As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents buttonEditRefuelDelete As Button
    Friend WithEvents FormEditRefuelLabelQuantityLitre As Label
    Friend WithEvents textBoxEditRefuelMenge As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FormEditRefuelGroupboxDateandTime As GroupBox
    Friend WithEvents datetimepickerEditRefuelTime As DateTimePicker
    Friend WithEvents FormEditRefuelLabelTime As Label
    Friend WithEvents datetimepickerEditRefuelDate As DateTimePicker
    Friend WithEvents FormEditRefuelLabelDate As Label
    Friend WithEvents FormEditRefuelGroupboxSpeedometer As GroupBox
    Friend WithEvents textBoxEditRefuelGefahreneStrecke As TextBox
    Friend WithEvents FormEditRefuelLabelMileageKm As Label
    Friend WithEvents FormEditRefuelLabelDriven As Label
    Friend WithEvents FormEditRefuelLabelDrivenKm As Label
    Friend WithEvents FormEditRefuelLabelMileage As Label
    Friend WithEvents textBoxEditRefuelTachostand As TextBox
    Friend WithEvents FormEditRefuelGroupboxFuelled As GroupBox
    Friend WithEvents textBoxEditRefuelSumme As TextBox
    Friend WithEvents FormEditRefuelLabelQuantity As Label
    Friend WithEvents FormEditRefuelLabelTotal As Label
    Friend WithEvents FormEditRefuelLabelTotalCurrency As Label
End Class
