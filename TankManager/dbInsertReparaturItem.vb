Module dbInsertReparaturItem

    'Insert: ReparaturItem
    Public Function MySqlInsertReparaturItem(repairDate, repairCosts, repairNumber, repairStep)

        'Datumformat für DB anpassen
        Dim MyRepairDate As String = Convert.ToDateTime(repairDate).ToString("yyyy-MM-dd")

        'Kommas durch Punkte setzen
        Dim MyRepairCosts As String = repairCosts.Replace(",", ".")

        'variable definieren und predefined statement einfügen
        Dim insert_statement As String = "INSERT INTO `tankmanager`.`tbl_reparaturliste` (reparatur_id, nummer, posten) VALUES((SELECT `tankmanager`.`tbl_reparaturen`.`id` FROM `tankmanager`.`tbl_reparaturen` WHERE datum = '" & MyRepairDate & "' AND preis = '" & MyRepairCosts & "'), '" & repairNumber & "', '" & repairStep & "');"

        'Statement zurückgeben
        Return insert_statement

    End Function

End Module
