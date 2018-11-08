Module dbSelectVerbrauchGesamt

    'Abfrage: durschnittlicher Verbrauch Alles auf 100 Kilometer
    Public Function MySqlSelectVerbrauchGesamt()

        'variable definieren und predefined statement einfügen
        'Dim select_statement As String = "SELECT ROUND(`tankmanager`.`tbl_tanken`.`liter` * 100 / `tankmanager`.`tbl_tanken`.`gefahren`, 2) AS verbrauch FROM `tankmanager`.`tbl_tanken`;"

        Dim select_statement As String = "SELECT
ROUND((SUM(`tankmanager`.`tbl_tanken`.`liter`) / COUNT(`tankmanager`.`tbl_tanken`.`liter`) * 100) / 
(SUM(`tankmanager`.`tbl_tanken`.`gefahren`) / COUNT(`tankmanager`.`tbl_tanken`.`gefahren`)),2) AS DGV
FROM `tankmanager`.`tbl_tanken`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module