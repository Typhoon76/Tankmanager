Module readCosts

    Public Function getCostsAll()

        Dim kostenGesamtError As Boolean = False

        '### gesamtkosten berechnen
        If formMain.textboxGesamtkostenBenzin.Text = "" Or formMain.textboxGesamtkostenReparatur.Text = "" Then

            'wenn keine werte
            kostenGesamtError = True

        Else

            Dim a As String = formMain.textboxGesamtkostenBenzin.Text
            Dim b As String = formMain.textboxGesamtkostenReparatur.Text
            formMain.textboxGesamtkostenBezahlt.Text = (CType(a, Single) + CType(b, Single)).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return kostenGesamtError

    End Function

    Public Function getCostsYear()

        Dim kostenJahrError As Boolean = False

        If formMain.textboxBenzinkostenJahr.Text = "" Or formMain.textboxReparaturkostenJahr.Text = "" Then

            'wenn keine werte
            kostenJahrError = True

        Else

            Dim a As String = formMain.textboxBenzinkostenJahr.Text
            Dim b As String = formMain.textboxReparaturkostenJahr.Text
            formMain.textboxGesamtkostenJahr.Text = (CType(a, Single) + CType(b, Single)).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return kostenJahrError

    End Function

End Module
