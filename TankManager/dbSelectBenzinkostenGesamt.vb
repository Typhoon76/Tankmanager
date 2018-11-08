Module dbSelectBenzinkostenGesamt

    'Abfrage: Benzinkosten Gesamt
    Public Function MySqlSelectBenzinkostenGesamt()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT SUM(`tankmanager`.`tbl_tanken`.`preis`) AS BenzinkostenGesamt FROM `tankmanager`.`tbl_tanken`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
