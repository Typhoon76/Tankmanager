Module dbDeleteReparaturEintrag

    'Delete: Reparatur
    Public Function MySqlDeleteReparaturEintrag(repairID)

        'variable definieren und predefined statement einfügen
        Dim delete_statement As String = "DELETE FROM `tankmanager`.`tbl_reparaturen` WHERE `id`='" & repairID & "';"

        'Statement zurückgeben
        Return delete_statement

    End Function

End Module
