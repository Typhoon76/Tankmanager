Module dbSelectBenzinkosten

    'Abfrage: Benzinkosten
    Public Function MySqlSelectBenzinkosten(selectedJahr)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT SUM(`tankmanager`.`tbl_tanken`.`preis`) AS Benzinkosten FROM `tankmanager`.`tbl_tanken` WHERE DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%Y') = '" & selectedJahr & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
