Module dbSelectReparaturkosten

    'Abfrage: Reparaturen
    Public Function MySqlSelectReparaturkosten(selectedJahr)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT 

SUM(`tankmanager`.`tbl_reparaturen`.`preis`) AS Reparaturkosten
FROM `tankmanager`.`tbl_reparaturen` 
WHERE DATE_FORMAT(`tankmanager`.`tbl_reparaturen`.`datum`, '%Y') = '" & selectedJahr & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
