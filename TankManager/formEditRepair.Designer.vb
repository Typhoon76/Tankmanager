<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditRepair))
        Me.buttonEditRepairCancel = New System.Windows.Forms.Button()
        Me.buttonEditRepairLVAdd = New System.Windows.Forms.Button()
        Me.buttonEditRepairLVEdit = New System.Windows.Forms.Button()
        Me.buttonEditRepairLVDelete = New System.Windows.Forms.Button()
        Me.buttonEditRepairLVUp = New System.Windows.Forms.Button()
        Me.buttonEditRepairLVDown = New System.Windows.Forms.Button()
        Me.listviewEditRepair = New System.Windows.Forms.ListView()
        Me.buttonEditRepairSaveAndExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateTimePickerEditRepair = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonEditRepairReset = New System.Windows.Forms.Button()
        Me.groupboxEditRepair = New System.Windows.Forms.GroupBox()
        Me.textboxEditRepairCosts = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonEditRepairDelete = New System.Windows.Forms.Button()
        Me.groupboxEditRepair.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonEditRepairCancel
        '
        Me.buttonEditRepairCancel.Location = New System.Drawing.Point(95, 365)
        Me.buttonEditRepairCancel.Name = "buttonEditRepairCancel"
        Me.buttonEditRepairCancel.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRepairCancel.TabIndex = 10
        Me.buttonEditRepairCancel.Text = "Abbrechen"
        Me.buttonEditRepairCancel.UseVisualStyleBackColor = True
        '
        'buttonEditRepairLVAdd
        '
        Me.buttonEditRepairLVAdd.Location = New System.Drawing.Point(680, 265)
        Me.buttonEditRepairLVAdd.Name = "buttonEditRepairLVAdd"
        Me.buttonEditRepairLVAdd.Size = New System.Drawing.Size(100, 23)
        Me.buttonEditRepairLVAdd.TabIndex = 12
        Me.buttonEditRepairLVAdd.Text = "Hinzufügen"
        Me.buttonEditRepairLVAdd.UseVisualStyleBackColor = True
        '
        'buttonEditRepairLVEdit
        '
        Me.buttonEditRepairLVEdit.Location = New System.Drawing.Point(575, 265)
        Me.buttonEditRepairLVEdit.Name = "buttonEditRepairLVEdit"
        Me.buttonEditRepairLVEdit.Size = New System.Drawing.Size(100, 23)
        Me.buttonEditRepairLVEdit.TabIndex = 11
        Me.buttonEditRepairLVEdit.Text = "Ändern"
        Me.buttonEditRepairLVEdit.UseVisualStyleBackColor = True
        '
        'buttonEditRepairLVDelete
        '
        Me.buttonEditRepairLVDelete.Location = New System.Drawing.Point(470, 265)
        Me.buttonEditRepairLVDelete.Name = "buttonEditRepairLVDelete"
        Me.buttonEditRepairLVDelete.Size = New System.Drawing.Size(100, 23)
        Me.buttonEditRepairLVDelete.TabIndex = 10
        Me.buttonEditRepairLVDelete.Text = "Löschen"
        Me.buttonEditRepairLVDelete.UseVisualStyleBackColor = True
        '
        'buttonEditRepairLVUp
        '
        Me.buttonEditRepairLVUp.Location = New System.Drawing.Point(215, 265)
        Me.buttonEditRepairLVUp.Name = "buttonEditRepairLVUp"
        Me.buttonEditRepairLVUp.Size = New System.Drawing.Size(100, 23)
        Me.buttonEditRepairLVUp.TabIndex = 9
        Me.buttonEditRepairLVUp.Text = "Hoch"
        Me.buttonEditRepairLVUp.UseVisualStyleBackColor = True
        '
        'buttonEditRepairLVDown
        '
        Me.buttonEditRepairLVDown.Location = New System.Drawing.Point(110, 265)
        Me.buttonEditRepairLVDown.Name = "buttonEditRepairLVDown"
        Me.buttonEditRepairLVDown.Size = New System.Drawing.Size(100, 23)
        Me.buttonEditRepairLVDown.TabIndex = 8
        Me.buttonEditRepairLVDown.Text = "Runter"
        Me.buttonEditRepairLVDown.UseVisualStyleBackColor = True
        '
        'listviewEditRepair
        '
        Me.listviewEditRepair.AutoArrange = False
        Me.listviewEditRepair.FullRowSelect = True
        Me.listviewEditRepair.GridLines = True
        Me.listviewEditRepair.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listviewEditRepair.Location = New System.Drawing.Point(110, 60)
        Me.listviewEditRepair.Name = "listviewEditRepair"
        Me.listviewEditRepair.ShowGroups = False
        Me.listviewEditRepair.Size = New System.Drawing.Size(670, 200)
        Me.listviewEditRepair.TabIndex = 7
        Me.listviewEditRepair.UseCompatibleStateImageBehavior = False
        Me.listviewEditRepair.View = System.Windows.Forms.View.Details
        '
        'buttonEditRepairSaveAndExit
        '
        Me.buttonEditRepairSaveAndExit.Location = New System.Drawing.Point(560, 365)
        Me.buttonEditRepairSaveAndExit.Name = "buttonEditRepairSaveAndExit"
        Me.buttonEditRepairSaveAndExit.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRepairSaveAndExit.TabIndex = 13
        Me.buttonEditRepairSaveAndExit.Text = "Speichern && Schließen"
        Me.buttonEditRepairSaveAndExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EUR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reparaturkosten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reparaturliste"
        '
        'dateTimePickerEditRepair
        '
        Me.dateTimePickerEditRepair.Location = New System.Drawing.Point(110, 30)
        Me.dateTimePickerEditRepair.Name = "dateTimePickerEditRepair"
        Me.dateTimePickerEditRepair.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePickerEditRepair.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datum"
        '
        'buttonEditRepairReset
        '
        Me.buttonEditRepairReset.Location = New System.Drawing.Point(405, 365)
        Me.buttonEditRepairReset.Name = "buttonEditRepairReset"
        Me.buttonEditRepairReset.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRepairReset.TabIndex = 11
        Me.buttonEditRepairReset.Text = "Reparatur zurücksetzen"
        Me.buttonEditRepairReset.UseVisualStyleBackColor = True
        '
        'groupboxEditRepair
        '
        Me.groupboxEditRepair.Controls.Add(Me.buttonEditRepairLVAdd)
        Me.groupboxEditRepair.Controls.Add(Me.buttonEditRepairLVEdit)
        Me.groupboxEditRepair.Controls.Add(Me.buttonEditRepairLVDelete)
        Me.groupboxEditRepair.Controls.Add(Me.buttonEditRepairLVUp)
        Me.groupboxEditRepair.Controls.Add(Me.buttonEditRepairLVDown)
        Me.groupboxEditRepair.Controls.Add(Me.listviewEditRepair)
        Me.groupboxEditRepair.Controls.Add(Me.Label4)
        Me.groupboxEditRepair.Controls.Add(Me.textboxEditRepairCosts)
        Me.groupboxEditRepair.Controls.Add(Me.Label3)
        Me.groupboxEditRepair.Controls.Add(Me.Label2)
        Me.groupboxEditRepair.Controls.Add(Me.dateTimePickerEditRepair)
        Me.groupboxEditRepair.Controls.Add(Me.Label1)
        Me.groupboxEditRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxEditRepair.Location = New System.Drawing.Point(3, 3)
        Me.groupboxEditRepair.Name = "groupboxEditRepair"
        Me.groupboxEditRepair.Size = New System.Drawing.Size(793, 339)
        Me.groupboxEditRepair.TabIndex = 0
        Me.groupboxEditRepair.TabStop = False
        Me.groupboxEditRepair.Text = "Reparatur"
        '
        'textboxEditRepairCosts
        '
        Me.textboxEditRepairCosts.Location = New System.Drawing.Point(110, 310)
        Me.textboxEditRepairCosts.Name = "textboxEditRepairCosts"
        Me.textboxEditRepairCosts.Size = New System.Drawing.Size(100, 20)
        Me.textboxEditRepairCosts.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxEditRepair, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 345)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'buttonEditRepairDelete
        '
        Me.buttonEditRepairDelete.Location = New System.Drawing.Point(250, 365)
        Me.buttonEditRepairDelete.Name = "buttonEditRepairDelete"
        Me.buttonEditRepairDelete.Size = New System.Drawing.Size(150, 25)
        Me.buttonEditRepairDelete.TabIndex = 14
        Me.buttonEditRepairDelete.Text = "Reparatur löschen"
        Me.buttonEditRepairDelete.UseVisualStyleBackColor = True
        '
        'formEditRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.Controls.Add(Me.buttonEditRepairDelete)
        Me.Controls.Add(Me.buttonEditRepairCancel)
        Me.Controls.Add(Me.buttonEditRepairSaveAndExit)
        Me.Controls.Add(Me.buttonEditRepairReset)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(815, 445)
        Me.MinimumSize = New System.Drawing.Size(815, 445)
        Me.Name = "formEditRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eintrag bearbeiten"
        Me.groupboxEditRepair.ResumeLayout(False)
        Me.groupboxEditRepair.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonEditRepairCancel As Button
    Friend WithEvents buttonEditRepairLVAdd As Button
    Friend WithEvents buttonEditRepairLVEdit As Button
    Friend WithEvents buttonEditRepairLVDelete As Button
    Friend WithEvents buttonEditRepairLVUp As Button
    Friend WithEvents listviewEditRepair As ListView
    Friend WithEvents buttonEditRepairSaveAndExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateTimePickerEditRepair As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonEditRepairReset As Button
    Friend WithEvents groupboxEditRepair As GroupBox
    Friend WithEvents textboxEditRepairCosts As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents buttonEditRepairLVDown As Button
    Friend WithEvents buttonEditRepairDelete As Button
End Class
