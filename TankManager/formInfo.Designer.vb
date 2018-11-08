<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formInfo))
        Me.buttonInfoSchliessen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxInfoServeradresse = New System.Windows.Forms.TextBox()
        Me.textboxInfoServerport = New System.Windows.Forms.TextBox()
        Me.textboxInfoAngemeldetAls = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelApplicationName = New System.Windows.Forms.Label()
        Me.labelApplicationVersion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonInfoSchliessen
        '
        Me.buttonInfoSchliessen.Location = New System.Drawing.Point(120, 325)
        Me.buttonInfoSchliessen.Name = "buttonInfoSchliessen"
        Me.buttonInfoSchliessen.Size = New System.Drawing.Size(150, 25)
        Me.buttonInfoSchliessen.TabIndex = 0
        Me.buttonInfoSchliessen.Text = "Schließen"
        Me.buttonInfoSchliessen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serveradresse"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serverport"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textboxInfoServeradresse
        '
        Me.textboxInfoServeradresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxInfoServeradresse.Location = New System.Drawing.Point(48, 120)
        Me.textboxInfoServeradresse.Name = "textboxInfoServeradresse"
        Me.textboxInfoServeradresse.ReadOnly = True
        Me.textboxInfoServeradresse.Size = New System.Drawing.Size(290, 13)
        Me.textboxInfoServeradresse.TabIndex = 3
        Me.textboxInfoServeradresse.Text = "{{Server Address}}"
        Me.textboxInfoServeradresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxInfoServerport
        '
        Me.textboxInfoServerport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxInfoServerport.Location = New System.Drawing.Point(48, 168)
        Me.textboxInfoServerport.Name = "textboxInfoServerport"
        Me.textboxInfoServerport.ReadOnly = True
        Me.textboxInfoServerport.Size = New System.Drawing.Size(290, 13)
        Me.textboxInfoServerport.TabIndex = 4
        Me.textboxInfoServerport.Text = "{{Server Port}}"
        Me.textboxInfoServerport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxInfoAngemeldetAls
        '
        Me.textboxInfoAngemeldetAls.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxInfoAngemeldetAls.Location = New System.Drawing.Point(48, 216)
        Me.textboxInfoAngemeldetAls.Name = "textboxInfoAngemeldetAls"
        Me.textboxInfoAngemeldetAls.ReadOnly = True
        Me.textboxInfoAngemeldetAls.Size = New System.Drawing.Size(290, 13)
        Me.textboxInfoAngemeldetAls.TabIndex = 6
        Me.textboxInfoAngemeldetAls.Text = "{{User Name}}"
        Me.textboxInfoAngemeldetAls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "angemeldet als"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TankManager.My.Resources.Resources.if_gas_64313
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'labelApplicationName
        '
        Me.labelApplicationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelApplicationName.Location = New System.Drawing.Point(60, 10)
        Me.labelApplicationName.Name = "labelApplicationName"
        Me.labelApplicationName.Size = New System.Drawing.Size(264, 32)
        Me.labelApplicationName.TabIndex = 8
        Me.labelApplicationName.Text = "{{Application Name}}"
        Me.labelApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelApplicationVersion
        '
        Me.labelApplicationVersion.Location = New System.Drawing.Point(48, 48)
        Me.labelApplicationVersion.Name = "labelApplicationVersion"
        Me.labelApplicationVersion.Size = New System.Drawing.Size(290, 13)
        Me.labelApplicationVersion.TabIndex = 9
        Me.labelApplicationVersion.Text = "{{Application Version}}"
        Me.labelApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.labelApplicationVersion)
        Me.Controls.Add(Me.labelApplicationName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.textboxInfoAngemeldetAls)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textboxInfoServerport)
        Me.Controls.Add(Me.textboxInfoServeradresse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonInfoSchliessen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonInfoSchliessen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxInfoServeradresse As TextBox
    Friend WithEvents textboxInfoServerport As TextBox
    Friend WithEvents textboxInfoAngemeldetAls As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelApplicationName As Label
    Friend WithEvents labelApplicationVersion As Label
End Class
