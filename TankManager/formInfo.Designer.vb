<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.ButtonInfoClose = New System.Windows.Forms.Button()
        Me.LabelServerAddress = New System.Windows.Forms.Label()
        Me.LabelServerPort = New System.Windows.Forms.Label()
        Me.TextboxInfoServeradresse = New System.Windows.Forms.TextBox()
        Me.TextboxInfoServerport = New System.Windows.Forms.TextBox()
        Me.TextboxInfoLoggedInAs = New System.Windows.Forms.TextBox()
        Me.LabelLoggedInAs = New System.Windows.Forms.Label()
        Me.PictureBoxInfo = New System.Windows.Forms.PictureBox()
        Me.LabelApplicationName = New System.Windows.Forms.Label()
        Me.LabelApplicationVersion = New System.Windows.Forms.Label()
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonInfoClose
        '
        Me.ButtonInfoClose.Location = New System.Drawing.Point(120, 325)
        Me.ButtonInfoClose.Name = "ButtonInfoClose"
        Me.ButtonInfoClose.Size = New System.Drawing.Size(150, 25)
        Me.ButtonInfoClose.TabIndex = 0
        Me.ButtonInfoClose.Text = "Close"
        Me.ButtonInfoClose.UseVisualStyleBackColor = True
        '
        'LabelServerAddress
        '
        Me.LabelServerAddress.Location = New System.Drawing.Point(48, 96)
        Me.LabelServerAddress.Name = "LabelServerAddress"
        Me.LabelServerAddress.Size = New System.Drawing.Size(290, 13)
        Me.LabelServerAddress.TabIndex = 1
        Me.LabelServerAddress.Text = "serveradress:"
        Me.LabelServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelServerPort
        '
        Me.LabelServerPort.Location = New System.Drawing.Point(48, 144)
        Me.LabelServerPort.Name = "LabelServerPort"
        Me.LabelServerPort.Size = New System.Drawing.Size(290, 13)
        Me.LabelServerPort.TabIndex = 2
        Me.LabelServerPort.Text = "serverport:"
        Me.LabelServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextboxInfoServeradresse
        '
        Me.TextboxInfoServeradresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextboxInfoServeradresse.Location = New System.Drawing.Point(48, 120)
        Me.TextboxInfoServeradresse.Name = "TextboxInfoServeradresse"
        Me.TextboxInfoServeradresse.ReadOnly = True
        Me.TextboxInfoServeradresse.Size = New System.Drawing.Size(290, 13)
        Me.TextboxInfoServeradresse.TabIndex = 3
        Me.TextboxInfoServeradresse.Text = "{{Server Address}}"
        Me.TextboxInfoServeradresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextboxInfoServerport
        '
        Me.TextboxInfoServerport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextboxInfoServerport.Location = New System.Drawing.Point(48, 168)
        Me.TextboxInfoServerport.Name = "TextboxInfoServerport"
        Me.TextboxInfoServerport.ReadOnly = True
        Me.TextboxInfoServerport.Size = New System.Drawing.Size(290, 13)
        Me.TextboxInfoServerport.TabIndex = 4
        Me.TextboxInfoServerport.Text = "{{Server Port}}"
        Me.TextboxInfoServerport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextboxInfoLoggedInAs
        '
        Me.TextboxInfoLoggedInAs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextboxInfoLoggedInAs.Location = New System.Drawing.Point(48, 216)
        Me.TextboxInfoLoggedInAs.Name = "TextboxInfoLoggedInAs"
        Me.TextboxInfoLoggedInAs.ReadOnly = True
        Me.TextboxInfoLoggedInAs.Size = New System.Drawing.Size(290, 13)
        Me.TextboxInfoLoggedInAs.TabIndex = 6
        Me.TextboxInfoLoggedInAs.Text = "{{User Name}}"
        Me.TextboxInfoLoggedInAs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelLoggedInAs
        '
        Me.LabelLoggedInAs.Location = New System.Drawing.Point(48, 192)
        Me.LabelLoggedInAs.Name = "LabelLoggedInAs"
        Me.LabelLoggedInAs.Size = New System.Drawing.Size(290, 13)
        Me.LabelLoggedInAs.TabIndex = 5
        Me.LabelLoggedInAs.Text = "logged in as:"
        Me.LabelLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxInfo
        '
        Me.PictureBoxInfo.Image = Global.TankManager.My.Resources.Resources.if_gas_64313
        Me.PictureBoxInfo.Location = New System.Drawing.Point(13, 12)
        Me.PictureBoxInfo.Name = "PictureBoxInfo"
        Me.PictureBoxInfo.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxInfo.TabIndex = 7
        Me.PictureBoxInfo.TabStop = False
        '
        'LabelApplicationName
        '
        Me.LabelApplicationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationName.Location = New System.Drawing.Point(60, 10)
        Me.LabelApplicationName.Name = "LabelApplicationName"
        Me.LabelApplicationName.Size = New System.Drawing.Size(264, 32)
        Me.LabelApplicationName.TabIndex = 8
        Me.LabelApplicationName.Text = "{{Application Name}}"
        Me.LabelApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelApplicationVersion
        '
        Me.LabelApplicationVersion.Location = New System.Drawing.Point(48, 48)
        Me.LabelApplicationVersion.Name = "LabelApplicationVersion"
        Me.LabelApplicationVersion.Size = New System.Drawing.Size(290, 13)
        Me.LabelApplicationVersion.TabIndex = 9
        Me.LabelApplicationVersion.Text = "{{Application Version}}"
        Me.LabelApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.LabelApplicationVersion)
        Me.Controls.Add(Me.LabelApplicationName)
        Me.Controls.Add(Me.PictureBoxInfo)
        Me.Controls.Add(Me.TextboxInfoLoggedInAs)
        Me.Controls.Add(Me.LabelLoggedInAs)
        Me.Controls.Add(Me.TextboxInfoServerport)
        Me.Controls.Add(Me.TextboxInfoServeradresse)
        Me.Controls.Add(Me.LabelServerPort)
        Me.Controls.Add(Me.LabelServerAddress)
        Me.Controls.Add(Me.ButtonInfoClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonInfoClose As Button
    Friend WithEvents LabelServerAddress As Label
    Friend WithEvents LabelServerPort As Label
    Friend WithEvents TextboxInfoServeradresse As TextBox
    Friend WithEvents TextboxInfoServerport As TextBox
    Friend WithEvents TextboxInfoLoggedInAs As TextBox
    Friend WithEvents LabelLoggedInAs As Label
    Friend WithEvents PictureBoxInfo As PictureBox
    Friend WithEvents LabelApplicationName As Label
    Friend WithEvents LabelApplicationVersion As Label
End Class
