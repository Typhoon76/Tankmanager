Module dbSelectVerbrauch

    'Abfrage: durschnittlicher Verbrauch auf 100 Kilometer pro Jahr
    Public Function MySqlSelectVerbrauch(selectedJahr)

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT

ROUND((SUM(`tankmanager`.`tbl_tanken`.`liter`) / COUNT(`tankmanager`.`tbl_tanken`.`liter`) * 100) / 
(SUM(`tankmanager`.`tbl_tanken`.`gefahren`) / COUNT(`tankmanager`.`tbl_tanken`.`gefahren`)),2) AS DGV
FROM `tankmanager`.`tbl_tanken`
WHERE DATE_FORMAT(`tankmanager`.`tbl_tanken`.`datum`, '%Y') = '" & selectedJahr & "';"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module