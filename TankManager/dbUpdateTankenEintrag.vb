Module dbUpdateTankenEintrag

    'Update: Tanken Eintrag
    Public Function MySqlUpdateTankenEintrag(datum, uhrzeit, menge, summe, gefahren, tacho, selectedID)

        'variable definieren und predefined statement einfügen
        Dim update_statement As String = "UPDATE `tankmanager`.`tbl_tanken` SET `datum`='" & datum & "', `zeit`='" & uhrzeit & "', `liter`='" & menge & "', `preis`='" & summe & "', `gefahren`='" & gefahren & "', `gesamt`='" & tacho & "' WHERE `id`='" & selectedID & "';"

        'Statement zurückgeben
        Return update_statement

    End Function

End Module
