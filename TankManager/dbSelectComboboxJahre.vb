Module dbSelectComboboxJahre

    'Abfrage: Jahre
    Public Function MySqlSelectComboboxJahre()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%Y') AS ComboboxJahre FROM `tankmanager`.`tbl_tanken` GROUP BY DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%Y');"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
