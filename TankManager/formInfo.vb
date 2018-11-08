Public Class formInfo

    Private Sub formInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labelApplicationName.Text = My.Application.Info.AssemblyName
        labelApplicationVersion.Text = "Version 0.0.0.0"

        If con.State = ConnectionState.Open Then

            textboxInfoServeradresse.Text = tankmanagerConnection.serverName
            textboxInfoServerport.Text = tankmanagerConnection.serverPort
            textboxInfoAngemeldetAls.Text = tankmanagerConnection.userName

        Else

            textboxInfoServeradresse.Text = "nicht verbunden"
            textboxInfoServerport.Text = "-"
            textboxInfoAngemeldetAls.Text = "-"

        End If

    End Sub

    Private Sub buttonInfoSchliessen_Click(sender As Object, e As EventArgs) Handles buttonInfoSchliessen.Click

        Me.Close()

    End Sub

End Class