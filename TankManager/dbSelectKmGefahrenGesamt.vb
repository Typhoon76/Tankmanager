Module dbSelectKmGefahrenGesamt

    'Abfrage: Km Gefahren Gesamt
    Public Function MySqlSelectKmGefahrenGesamt()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT SUM(`tankmanager`.`tbl_tanken`.`gefahren`) AS KmGefahrenGesamt FROM `tankmanager`.`tbl_tanken`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
