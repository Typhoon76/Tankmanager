Module dbUpdateReparaturEintrag

    'Update: Reparatur Eintrag
    Public Function MySqlUpdateReparaturEintrag(datum, preis, selectedID)

        'variable definieren und predefined statement einfügen
        Dim update_statement As String = "UPDATE `tankmanager`.`tbl_reparaturen` SET `datum`='" & datum & "', `preis`='" & preis & "' WHERE `id`='" & selectedID & "';"

        'Statement zurückgeben
        Return update_statement

    End Function

End Module