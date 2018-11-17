Public Class FormInfo

    Private Sub FormInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelApplicationName.Text = My.Application.Info.AssemblyName
        LabelApplicationVersion.Text = "Version " & myVersionMajor & "." & myVersionMinor & "." & myVersionBuild & "." & myVersionRevision & " (" & myVersionDate & ")"

        LabelServerAddress.Text = TM_INFO_SERVER_ADDRESS
        LabelServerPort.Text = TM_INFO_SERVER_PORT
        LabelLoggedInAs.Text = TM_INFO_LOGGED_IN_AS
        ButtonInfoClose.Text = TM_INFO_BUTTON_CLOSE


        If con.State = ConnectionState.Open Then

            TextboxInfoServeradresse.Text = tankmanagerConnection.serverName
            TextboxInfoServerport.Text = tankmanagerConnection.serverPort
            TextboxInfoLoggedInAs.Text = tankmanagerConnection.userName

        Else

            TextboxInfoServeradresse.Text = "nicht verbunden"
            TextboxInfoServerport.Text = "-"
            TextboxInfoLoggedInAs.Text = "-"

        End If

    End Sub

    Private Sub ButtonInfoSchliessen_Click(sender As Object, e As EventArgs) Handles ButtonInfoClose.Click

        Me.Close()

    End Sub

End Class