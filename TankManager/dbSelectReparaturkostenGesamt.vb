Module dbSelectReparaturkostenGesamt

    'Abfrage: Reparaturkosten Gesamt
    Public Function MySqlSelectReparaturkostenGesamt()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT SUM(`tankmanager`.`tbl_reparaturen`.`preis`) AS ReparaturkostenGesamt FROM `tankmanager`.`tbl_reparaturen`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
