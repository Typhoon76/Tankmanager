Module dbSelectTankenGesamt

    'Abfrage: Tanken Alles
    Public Function MySqlSelectTankenGesamt()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT
`tankmanager`.`tbl_tanken`.`id`, 
DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%d.%m.%Y') AS datum,
DATE_FORMAT(`tankmanager`.`tbl_tanken`.`zeit`, '%H:%i') AS zeit,
`tankmanager`.`tbl_tanken`.`liter`, 
`tankmanager`.`tbl_tanken`.`preis`, 
ROUND(`tankmanager`.`tbl_tanken`.`preis` / `tankmanager`.`tbl_tanken`.`liter`, 3) AS literpreis, 
`tankmanager`.`tbl_tanken`.`gefahren`, 
`tankmanager`.`tbl_tanken`.`gesamt`, 
ROUND(`tankmanager`.`tbl_tanken`.`liter` * 100 / `tankmanager`.`tbl_tanken`.`gefahren`, 2) AS verbrauch FROM `tankmanager`.`tbl_tanken` 
ORDER BY `tankmanager`.`tbl_tanken`.`datum`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
