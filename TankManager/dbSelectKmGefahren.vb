Module dbSelectKmGefahren

    'Abfrage: Km Gefahren
    Public Function MySqlSelectKmGefahren(selectedJahr)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT SUM(`tankmanager`.`tbl_tanken`.`gefahren`) AS KmGefahren FROM `tankmanager`.`tbl_tanken` WHERE DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%Y') = '" & selectedJahr & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module