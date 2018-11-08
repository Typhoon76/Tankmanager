Module dbDeleteReparaturArbeitsschritt

    'Delete: Reparatur Arbeitsschritt
    Public Function MySqlDeleteReparaturArbeitsschritt(repairID)

        'variable definieren und predefined statement einfügen
        Dim delete_statement As String = "DELETE FROM `tankmanager`.`tbl_reparaturliste` WHERE `reparatur_id`='" & repairID & "';"

        'Statement zurückgeben
        Return delete_statement

    End Function

End Module