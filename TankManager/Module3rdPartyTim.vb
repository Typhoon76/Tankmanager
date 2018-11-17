Module Module3rdPartyTim

    Public WithEvents Tim As New Timer With {.Interval = 1}

    Public Sub Tim_Tick(sender As Object, e As EventArgs) Handles Tim.Tick

        'wenn fensterstatusminimal wahr
        If FormMain.windowsStateMinimized = True Then

            'fenstergröße plus 10
            FormMain.Width = FormMain.Width + 10

            'wenn fenstergröße maximal
            If FormMain.Width = 1920 Then

                'timer stoppen
                Tim.Enabled = False

                'fensterstatusminimal auf falsch setzen
                FormMain.windowsStateMinimized = False

                'button text ändern
                FormMain.SwitchReparaturen.Text = TM_MAIN_BUTTON_HIDE_REPAIRS

            End If

        ElseIf FormMain.windowsStateMinimized = False Then

            'wenn fenster vergrößert

            'fenstergröße minus 10
            FormMain.Width = FormMain.Width - 10

            'wenn fenstergröße minila
            If FormMain.Width = 1270 Then

                'timer stoppen
                Tim.Enabled = False

                'fensterstatusminimal auf wahr setzen
                FormMain.windowsStateMinimized = True

                'button text ändern
                FormMain.SwitchReparaturen.Text = TM_MAIN_BUTTON_SHOW_REPAIRS

            End If

        End If

        'fenster zentrieren
        CenterForm(FormMain)

    End Sub

End Module
