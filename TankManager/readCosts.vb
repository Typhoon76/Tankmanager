Module readCosts

    Public Function getCostsAll()

        Dim kostenGesamtError As Boolean = False

        '### gesamtkosten berechnen
        If formMain.TextboxGesamtkostenBenzin.Text = "" Or formMain.TextboxGesamtkostenReparatur.Text = "" Then

            'wenn keine werte
            kostenGesamtError = True

        Else

            Dim a As String = formMain.TextboxGesamtkostenBenzin.Text
            Dim b As String = formMain.TextboxGesamtkostenReparatur.Text
            formMain.TextboxGesamtkostenBezahlt.Text = (CType(a, Single) + CType(b, Single)).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return kostenGesamtError

    End Function

    Public Function getCostsYear()

        Dim kostenJahrError As Boolean = False

        If formMain.TextboxBenzinkostenJahr.Text = "" Or formMain.TextboxReparaturkostenJahr.Text = "" Then

            'wenn keine werte
            kostenJahrError = True

        Else

            Dim a As String = formMain.TextboxBenzinkostenJahr.Text
            Dim b As String = formMain.TextboxReparaturkostenJahr.Text
            formMain.TextboxGesamtkostenJahr.Text = (CType(a, Single) + CType(b, Single)).ToString("F" & tankmanagerSettings.format_price)

        End If

        Return kostenJahrError

    End Function

End Module
