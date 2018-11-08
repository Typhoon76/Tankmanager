Module dbSelectEinstellungen

    'Abfrage: Einstellungen
    Public Function MySqlSelectEinstellungen()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT * FROM `tankmanager`.`tbl_einstellungen` LIMIT 1;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module