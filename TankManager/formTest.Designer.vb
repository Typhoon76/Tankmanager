<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.buttonPrint = New System.Windows.Forms.Button()
        Me.buttonPagePreview = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.buttonLVAdd = New System.Windows.Forms.Button()
        Me.buttonLVEdit = New System.Windows.Forms.Button()
        Me.buttonLVDelete = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.buttonReset = New System.Windows.Forms.Button()
        Me.buttonLVUp = New System.Windows.Forms.Button()
        Me.buttonLVDown = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.buttonPrint)
        Me.GroupBox1.Controls.Add(Me.buttonPagePreview)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drucken"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 210)
        Me.DataGridView1.TabIndex = 1
        '
        'buttonPrint
        '
        Me.buttonPrint.Location = New System.Drawing.Point(190, 19)
        Me.buttonPrint.Name = "buttonPrint"
        Me.buttonPrint.Size = New System.Drawing.Size(169, 23)
        Me.buttonPrint.TabIndex = 2
        Me.buttonPrint.Text = "Drucken"
        Me.buttonPrint.UseVisualStyleBackColor = True
        '
        'buttonPagePreview
        '
        Me.buttonPagePreview.Location = New System.Drawing.Point(15, 19)
        Me.buttonPagePreview.Name = "buttonPagePreview"
        Me.buttonPagePreview.Size = New System.Drawing.Size(169, 23)
        Me.buttonPagePreview.TabIndex = 1
        Me.buttonPagePreview.Text = "Druckvorschau"
        Me.buttonPagePreview.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.buttonLVAdd)
        Me.GroupBox2.Controls.Add(Me.buttonLVEdit)
        Me.GroupBox2.Controls.Add(Me.buttonLVDelete)
        Me.GroupBox2.Controls.Add(Me.buttonLVUp)
        Me.GroupBox2.Controls.Add(Me.buttonLVDown)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 285)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reparaturen"
        '
        'buttonLVAdd
        '
        Me.buttonLVAdd.Location = New System.Drawing.Point(425, 246)
        Me.buttonLVAdd.Name = "buttonLVAdd"
        Me.buttonLVAdd.Size = New System.Drawing.Size(85, 23)
        Me.buttonLVAdd.TabIndex = 5
        Me.buttonLVAdd.Text = "Hinzufügen"
        Me.buttonLVAdd.UseVisualStyleBackColor = True
        '
        'buttonLVEdit
        '
        Me.buttonLVEdit.Location = New System.Drawing.Point(334, 246)
        Me.buttonLVEdit.Name = "buttonLVEdit"
        Me.buttonLVEdit.Size = New System.Drawing.Size(85, 23)
        Me.buttonLVEdit.TabIndex = 4
        Me.buttonLVEdit.Text = "Ändern"
        Me.buttonLVEdit.UseVisualStyleBackColor = True
        '
        'buttonLVDelete
        '
        Me.buttonLVDelete.Location = New System.Drawing.Point(243, 246)
        Me.buttonLVDelete.Name = "buttonLVDelete"
        Me.buttonLVDelete.Size = New System.Drawing.Size(85, 23)
        Me.buttonLVDelete.TabIndex = 3
        Me.buttonLVDelete.Text = "Löschen"
        Me.buttonLVDelete.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(15, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(495, 220)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'buttonReset
        '
        Me.buttonReset.Location = New System.Drawing.Point(415, 309)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(85, 23)
        Me.buttonReset.TabIndex = 2
        Me.buttonReset.Text = "Zurücksetzen"
        Me.buttonReset.UseVisualStyleBackColor = True
        '
        'buttonLVUp
        '
        Me.buttonLVUp.Location = New System.Drawing.Point(106, 246)
        Me.buttonLVUp.Name = "buttonLVUp"
        Me.buttonLVUp.Size = New System.Drawing.Size(85, 23)
        Me.buttonLVUp.TabIndex = 2
        Me.buttonLVUp.Text = "Hoch"
        Me.buttonLVUp.UseVisualStyleBackColor = True
        '
        'buttonLVDown
        '
        Me.buttonLVDown.Location = New System.Drawing.Point(15, 246)
        Me.buttonLVDown.Name = "buttonLVDown"
        Me.buttonLVDown.Size = New System.Drawing.Size(85, 23)
        Me.buttonLVDown.TabIndex = 1
        Me.buttonLVDown.Text = "Runter"
        Me.buttonLVDown.UseVisualStyleBackColor = True
        '
        'formTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 344)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttonPrint As Button
    Friend WithEvents buttonPagePreview As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents buttonLVAdd As Button
    Friend WithEvents buttonLVEdit As Button
    Friend WithEvents buttonLVDelete As Button
    Friend WithEvents buttonLVUp As Button
    Friend WithEvents buttonLVDown As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents buttonReset As Button
End Class
