Module dbInsertReparaturArbeitsschritt

    'Insert: Reparatur Arbeitsschritt
    Public Function MySqlInsertReparaturArbeitsschritt(repairID, repairNumber, repairStep)

        'variable definieren und predefined statement einfügen
        Dim insert_statement As String = "INSERT INTO `tankmanager`.`tbl_reparaturliste` (reparatur_id, nummer, posten) VALUES('" & repairID & "', '" & repairNumber & "', '" & repairStep & "');"

        'Statement zurückgeben
        Return insert_statement

    End Function

End Module
