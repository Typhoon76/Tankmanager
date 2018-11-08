Module dbSelectMinMaxJahr

    'Abfrage: Jahre
    Public Function MySqlSelectMinMaxJahr()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT 
DATE_FORMAT(MIN(`tankmanager`.`tbl_tanken`.`datum`), '%Y') AS MinJahr,
DATE_FORMAT(MAX(`tankmanager`.`tbl_tanken`.`datum`), '%Y') AS MaxJahr
FROM `tankmanager`.`tbl_tanken`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
