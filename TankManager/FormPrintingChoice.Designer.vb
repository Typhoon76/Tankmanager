<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintingChoice
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
        Me.buttonPrintingChoiceRefuel = New System.Windows.Forms.Button()
        Me.buttonPrintingChoiceRepair = New System.Windows.Forms.Button()
        Me.buttonPrintingChoiceCancel = New System.Windows.Forms.Button()
        Me.labelPrintingChoice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonPrintingChoiceRefuel
        '
        Me.buttonPrintingChoiceRefuel.Location = New System.Drawing.Point(15, 80)
        Me.buttonPrintingChoiceRefuel.Name = "buttonPrintingChoiceRefuel"
        Me.buttonPrintingChoiceRefuel.Size = New System.Drawing.Size(150, 23)
        Me.buttonPrintingChoiceRefuel.TabIndex = 0
        Me.buttonPrintingChoiceRefuel.Text = "Button1"
        Me.buttonPrintingChoiceRefuel.UseVisualStyleBackColor = True
        '
        'buttonPrintingChoiceRepair
        '
        Me.buttonPrintingChoiceRepair.Location = New System.Drawing.Point(170, 80)
        Me.buttonPrintingChoiceRepair.Name = "buttonPrintingChoiceRepair"
        Me.buttonPrintingChoiceRepair.Size = New System.Drawing.Size(150, 23)
        Me.buttonPrintingChoiceRepair.TabIndex = 1
        Me.buttonPrintingChoiceRepair.Text = "Button2"
        Me.buttonPrintingChoiceRepair.UseVisualStyleBackColor = True
        '
        'buttonPrintingChoiceCancel
        '
        Me.buttonPrintingChoiceCancel.Location = New System.Drawing.Point(325, 80)
        Me.buttonPrintingChoiceCancel.Name = "buttonPrintingChoiceCancel"
        Me.buttonPrintingChoiceCancel.Size = New System.Drawing.Size(150, 23)
        Me.buttonPrintingChoiceCancel.TabIndex = 2
        Me.buttonPrintingChoiceCancel.Text = "Abbruch"
        Me.buttonPrintingChoiceCancel.UseVisualStyleBackColor = True
        '
        'labelPrintingChoice
        '
        Me.labelPrintingChoice.Location = New System.Drawing.Point(15, 15)
        Me.labelPrintingChoice.Name = "labelPrintingChoice"
        Me.labelPrintingChoice.Size = New System.Drawing.Size(460, 50)
        Me.labelPrintingChoice.TabIndex = 3
        Me.labelPrintingChoice.Text = "Label1"
        Me.labelPrintingChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPrintingChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelPrintingChoice)
        Me.Controls.Add(Me.buttonPrintingChoiceCancel)
        Me.Controls.Add(Me.buttonPrintingChoiceRepair)
        Me.Controls.Add(Me.buttonPrintingChoiceRefuel)
        Me.Name = "FormPrintingChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonPrintingChoiceRefuel As Button
    Friend WithEvents buttonPrintingChoiceRepair As Button
    Friend WithEvents buttonPrintingChoiceCancel As Button
    Friend WithEvents labelPrintingChoice As Label
End Class
