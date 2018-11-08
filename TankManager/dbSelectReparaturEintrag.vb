Module dbSelectReparaturEintrag

    'Abfrage: Reparatur Eintrag
    Public Function MySqlSelectReparaturEintrag(selectedID)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT
`tankmanager`.`tbl_reparaturen`.`id`, 
DATE_FORMAT(`tankmanager`.`tbl_reparaturen`.`datum`, '%d.%m.%Y') AS datum,
`tankmanager`.`tbl_reparaturen`.`preis`, 
`tankmanager`.`tbl_reparaturliste`.`nummer`, 
`tankmanager`.`tbl_reparaturliste`.`posten`
FROM `tankmanager`.`tbl_reparaturen` 
LEFT JOIN `tankmanager`.`tbl_reparaturliste` ON `tankmanager`.`tbl_reparaturliste`.`reparatur_id` = `tankmanager`.`tbl_reparaturen`.`id`
WHERE `tankmanager`.`tbl_reparaturen`.`id` = '" & selectedID & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
