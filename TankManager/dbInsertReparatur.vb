Module dbInsertReparatur

    'Insert: Reparatur
    Public Function MySqlInsertReparatur(repairDate, repairCosts)

        'Datumformat für DB anpassen
        Dim MyRepairDate As String = Convert.ToDateTime(repairDate).ToString("yyyy-MM-dd")

        'Kommas durch Punkte setzen
        Dim MyRepairCosts As String = repairCosts.Replace(",", ".")

        'variable definieren und predefined statement einfügen
        Dim insert_statement As String = "INSERT INTO `tankmanager`.`tbl_reparaturen` (`datum`, `preis`) VALUES ('" & MyRepairDate & "','" & MyRepairCosts & "');"

        'Statement zurückgeben
        Return insert_statement

    End Function

End Module
