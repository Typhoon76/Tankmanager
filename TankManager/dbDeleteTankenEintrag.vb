Module dbDeleteTankenEintrag

    'Abfrage: Tanken Eintrag
    Public Function MySqlDeleteTankenEintrag(selectedID)

        'Variable definieren und predefined Statement einfügen
        Dim delete_statement As String = "DELETE FROM `tankmanager`.`tbl_tanken` WHERE `id`='" & selectedID & "';"

        'Statement zurückgeben
        Return delete_statement

    End Function

End Module
