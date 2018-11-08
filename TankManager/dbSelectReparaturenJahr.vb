Module dbSelectReparaturenJahr

    'Abfrage: Reparaturkosten
    Public Function MySqlSelectReparaturenJahr(selectedJahr)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT 

`tankmanager`.`tbl_reparaturen`.`id`, 
DATE_FORMAT(`tankmanager`.`tbl_reparaturen`.`datum`, '%d.%m.%Y') AS datum,
`tankmanager`.`tbl_reparaturen`.`preis`, 
`tankmanager`.`tbl_reparaturliste`.`nummer`, 
`tankmanager`.`tbl_reparaturliste`.`posten` 
FROM `tankmanager`.`tbl_reparaturen` 
LEFT JOIN `tankmanager`.`tbl_reparaturliste` ON `tankmanager`.`tbl_reparaturliste`.`reparatur_id` = `tankmanager`.`tbl_reparaturen`.`id`
WHERE DATE_FORMAT(`tankmanager`.`tbl_reparaturen`.`datum`, '%Y') = '" & selectedJahr & "'
ORDER BY `tankmanager`.`tbl_reparaturen`.`datum`, `tankmanager`.`tbl_reparaturliste`.`nummer`, `tankmanager`.`tbl_reparaturen`.`id`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
