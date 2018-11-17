<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewRepair))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxNewRepair = New System.Windows.Forms.GroupBox()
        Me.buttonNewRepairLVAdd = New System.Windows.Forms.Button()
        Me.buttonNewRepairLVEdit = New System.Windows.Forms.Button()
        Me.buttonNewRepairLVDelete = New System.Windows.Forms.Button()
        Me.buttonNewRepairLVUp = New System.Windows.Forms.Button()
        Me.buttonNewRepairLVDown = New System.Windows.Forms.Button()
        Me.listviewNewRepair = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxNewRepairCosts = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateTimePickerNewRepair = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonNewRepairSaveAndExit = New System.Windows.Forms.Button()
        Me.buttonNewRepairCancel = New System.Windows.Forms.Button()
        Me.buttonNewRepairReset = New System.Windows.Forms.Button()
        Me.buttonNewRepairSaveAndNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupboxNewRepair.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxNewRepair, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 345)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'groupboxNewRepair
        '
        Me.groupboxNewRepair.Controls.Add(Me.buttonNewRepairLVAdd)
        Me.groupboxNewRepair.Controls.Add(Me.buttonNewRepairLVEdit)
        Me.groupboxNewRepair.Controls.Add(Me.buttonNewRepairLVDelete)
        Me.groupboxNewRepair.Controls.Add(Me.buttonNewRepairLVUp)
        Me.groupboxNewRepair.Controls.Add(Me.buttonNewRepairLVDown)
        Me.groupboxNewRepair.Controls.Add(Me.listviewNewRepair)
        Me.groupboxNewRepair.Controls.Add(Me.Label4)
        Me.groupboxNewRepair.Controls.Add(Me.textboxNewRepairCosts)
        Me.groupboxNewRepair.Controls.Add(Me.Label3)
        Me.groupboxNewRepair.Controls.Add(Me.Label2)
        Me.groupboxNewRepair.Controls.Add(Me.dateTimePickerNewRepair)
        Me.groupboxNewRepair.Controls.Add(Me.Label1)
        Me.groupboxNewRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxNewRepair.Location = New System.Drawing.Point(3, 3)
        Me.groupboxNewRepair.Name = "groupboxNewRepair"
        Me.groupboxNewRepair.Size = New System.Drawing.Size(793, 339)
        Me.groupboxNewRepair.TabIndex = 0
        Me.groupboxNewRepair.TabStop = False
        Me.groupboxNewRepair.Text = "Reparatur"
        '
        'buttonNewRepairLVAdd
        '
        Me.buttonNewRepairLVAdd.Location = New System.Drawing.Point(680, 265)
        Me.buttonNewRepairLVAdd.Name = "buttonNewRepairLVAdd"
        Me.buttonNewRepairLVAdd.Size = New System.Drawing.Size(100, 23)
        Me.buttonNewRepairLVAdd.TabIndex = 12
        Me.buttonNewRepairLVAdd.Text = "Hinzufügen"
        Me.buttonNewRepairLVAdd.UseVisualStyleBackColor = True
        '
        'buttonNewRepairLVEdit
        '
        Me.buttonNewRepairLVEdit.Location = New System.Drawing.Point(575, 265)
        Me.buttonNewRepairLVEdit.Name = "buttonNewRepairLVEdit"
        Me.buttonNewRepairLVEdit.Size = New System.Drawing.Size(100, 23)
        Me.buttonNewRepairLVEdit.TabIndex = 11
        Me.buttonNewRepairLVEdit.Text = "Ändern"
        Me.buttonNewRepairLVEdit.UseVisualStyleBackColor = True
        '
        'buttonNewRepairLVDelete
        '
        Me.buttonNewRepairLVDelete.Location = New System.Drawing.Point(470, 265)
        Me.buttonNewRepairLVDelete.Name = "buttonNewRepairLVDelete"
        Me.buttonNewRepairLVDelete.Size = New System.Drawing.Size(100, 23)
        Me.buttonNewRepairLVDelete.TabIndex = 10
        Me.buttonNewRepairLVDelete.Text = "Löschen"
        Me.buttonNewRepairLVDelete.UseVisualStyleBackColor = True
        '
        'buttonNewRepairLVUp
        '
        Me.buttonNewRepairLVUp.Location = New System.Drawing.Point(215, 265)
        Me.buttonNewRepairLVUp.Name = "buttonNewRepairLVUp"
        Me.buttonNewRepairLVUp.Size = New System.Drawing.Size(100, 23)
        Me.buttonNewRepairLVUp.TabIndex = 9
        Me.buttonNewRepairLVUp.Text = "Hoch"
        Me.buttonNewRepairLVUp.UseVisualStyleBackColor = True
        '
        'buttonNewRepairLVDown
        '
        Me.buttonNewRepairLVDown.Location = New System.Drawing.Point(110, 265)
        Me.buttonNewRepairLVDown.Name = "buttonNewRepairLVDown"
        Me.buttonNewRepairLVDown.Size = New System.Drawing.Size(100, 23)
        Me.buttonNewRepairLVDown.TabIndex = 8
        Me.buttonNewRepairLVDown.Text = "Runter"
        Me.buttonNewRepairLVDown.UseVisualStyleBackColor = True
        '
        'listviewNewRepair
        '
        Me.listviewNewRepair.AutoArrange = False
        Me.listviewNewRepair.FullRowSelect = True
        Me.listviewNewRepair.GridLines = True
        Me.listviewNewRepair.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listviewNewRepair.Location = New System.Drawing.Point(110, 60)
        Me.listviewNewRepair.Name = "listviewNewRepair"
        Me.listviewNewRepair.ShowGroups = False
        Me.listviewNewRepair.Size = New System.Drawing.Size(670, 200)
        Me.listviewNewRepair.TabIndex = 7
        Me.listviewNewRepair.UseCompatibleStateImageBehavior = False
        Me.listviewNewRepair.View = System.Windows.Forms.View.Details
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
        'textboxNewRepairCosts
        '
        Me.textboxNewRepairCosts.Location = New System.Drawing.Point(110, 310)
        Me.textboxNewRepairCosts.Name = "textboxNewRepairCosts"
        Me.textboxNewRepairCosts.Size = New System.Drawing.Size(100, 20)
        Me.textboxNewRepairCosts.TabIndex = 5
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
        'dateTimePickerNewRepair
        '
        Me.dateTimePickerNewRepair.Location = New System.Drawing.Point(110, 30)
        Me.dateTimePickerNewRepair.Name = "dateTimePickerNewRepair"
        Me.dateTimePickerNewRepair.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePickerNewRepair.TabIndex = 1
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
        'buttonNewRepairSaveAndExit
        '
        Me.buttonNewRepairSaveAndExit.Location = New System.Drawing.Point(560, 365)
        Me.buttonNewRepairSaveAndExit.Name = "buttonNewRepairSaveAndExit"
        Me.buttonNewRepairSaveAndExit.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRepairSaveAndExit.TabIndex = 8
        Me.buttonNewRepairSaveAndExit.Text = "Speichern && Schließen"
        Me.buttonNewRepairSaveAndExit.UseVisualStyleBackColor = True
        '
        'buttonNewRepairCancel
        '
        Me.buttonNewRepairCancel.Location = New System.Drawing.Point(95, 365)
        Me.buttonNewRepairCancel.Name = "buttonNewRepairCancel"
        Me.buttonNewRepairCancel.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRepairCancel.TabIndex = 5
        Me.buttonNewRepairCancel.Text = "Abbrechen"
        Me.buttonNewRepairCancel.UseVisualStyleBackColor = True
        '
        'buttonNewRepairReset
        '
        Me.buttonNewRepairReset.Location = New System.Drawing.Point(250, 365)
        Me.buttonNewRepairReset.Name = "buttonNewRepairReset"
        Me.buttonNewRepairReset.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRepairReset.TabIndex = 6
        Me.buttonNewRepairReset.Text = "Zurücksetzen"
        Me.buttonNewRepairReset.UseVisualStyleBackColor = True
        '
        'buttonNewRepairSaveAndNew
        '
        Me.buttonNewRepairSaveAndNew.Location = New System.Drawing.Point(405, 365)
        Me.buttonNewRepairSaveAndNew.Name = "buttonNewRepairSaveAndNew"
        Me.buttonNewRepairSaveAndNew.Size = New System.Drawing.Size(150, 25)
        Me.buttonNewRepairSaveAndNew.TabIndex = 7
        Me.buttonNewRepairSaveAndNew.Text = "Speichern && Neuer Eintrag"
        Me.buttonNewRepairSaveAndNew.UseVisualStyleBackColor = True
        '
        'FormNewRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.Controls.Add(Me.buttonNewRepairSaveAndExit)
        Me.Controls.Add(Me.buttonNewRepairCancel)
        Me.Controls.Add(Me.buttonNewRepairReset)
        Me.Controls.Add(Me.buttonNewRepairSaveAndNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(815, 445)
        Me.MinimumSize = New System.Drawing.Size(815, 445)
        Me.Name = "FormNewRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neue Reparatur erstellen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupboxNewRepair.ResumeLayout(False)
        Me.groupboxNewRepair.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents groupboxNewRepair As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textboxNewRepairCosts As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateTimePickerNewRepair As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonNewRepairSaveAndExit As Button
    Friend WithEvents buttonNewRepairCancel As Button
    Friend WithEvents buttonNewRepairReset As Button
    Friend WithEvents buttonNewRepairSaveAndNew As Button
    Friend WithEvents listviewNewRepair As ListView
    Friend WithEvents buttonNewRepairLVAdd As Button
    Friend WithEvents buttonNewRepairLVEdit As Button
    Friend WithEvents buttonNewRepairLVDelete As Button
    Friend WithEvents buttonNewRepairLVUp As Button
    Friend WithEvents buttonNewRepairLVDown As Button
End Class
