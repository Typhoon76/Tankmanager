Module dbSelectTankenEintrag

    'Abfrage: Tanken Eintrag
    Public Function MySqlSelectTankenEintrag(selectedID)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT
`tankmanager`.`tbl_tanken`.`id`,
DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%d.%m.%Y') AS datum,
DATE_FORMAT(`tankmanager`.`tbl_tanken`.`zeit`, '%H:%i') AS zeit,
`tankmanager`.`tbl_tanken`.`liter`,
`tankmanager`.`tbl_tanken`.`preis`,
`tankmanager`.`tbl_tanken`.`gefahren`,
`tankmanager`.`tbl_tanken`.`gesamt`
FROM `tankmanager`.`tbl_tanken`
WHERE 
`tankmanager`.`tbl_tanken`.`id` = '" & selectedID & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
