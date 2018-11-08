Module dbInsertTanken

    'Insert: tanken
    Public Function MySqlInsertTanken(refuelDate, refuelTime, refuelQuantity, refuelSum, refuelRoute, refuelMileage)

        'Datumformat für DB anpassen
        Dim MyRefuelDate As String = Convert.ToDateTime(refuelDate).ToString("yyyy-MM-dd")

        'Zeitformat für DB anpassen (derzeit keine Änderung)
        Dim MyRefuelTime As String = refuelTime

        'Kommas durch Punkte setzen
        Dim MyRefuelQuantity As String = refuelQuantity.Replace(",", ".")
        Dim MyRefuelSum As String = refuelSum.Replace(",", ".")
        Dim MyRefuelRoute As String = refuelRoute.Replace(",", ".")
        Dim MyRefuelMileage As String = refuelMileage.Replace(",", ".")

        'variable definieren und predefined statement einfügen
        Dim insert_statement As String = "INSERT INTO `tankmanager`.`tbl_tanken` (`datum`, `zeit`, `liter`, `preis`, `gefahren`, `gesamt`) VALUES ('" & MyRefuelDate & "', '" & MyRefuelTime & "', '" & MyRefuelQuantity & "', '" & MyRefuelSum & "', '" & MyRefuelRoute & "', '" & MyRefuelMileage & "');"

        'Statement zurückgeben
        Return insert_statement

    End Function

End Module