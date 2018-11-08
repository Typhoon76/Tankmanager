Imports MySql.Data.MySqlClient

Module updateRefuelItem

    Public Function updateTankenEintrag(refuelDate, refuelTime, refuelQuantity, refuelSum, refuelRoute, refuelMileage, refuelID)

        'Datumformat für DB anpassen
        Dim MyRefuelDate As String = Convert.ToDateTime(refuelDate).ToString("yyyy-MM-dd")

        'Zeitformat für DB anpassen
        Dim MyRefuelTime As String = refuelTime
        Dim MyRefuelTimeA = MyRefuelTime.Remove(1, 11)
        Dim MyRefuelTimeB = MyRefuelTimeA.Remove(5)

        'Kommas durch Punkte setzen
        Dim MyRefuelQuantity As String = refuelQuantity.Replace(",", ".")
        Dim MyRefuelSum As String = refuelSum.Replace(",", ".")
        Dim MyRefuelRoute As String = refuelRoute.Replace(",", ".")
        Dim MyRefuelMileage As String = refuelMileage.Replace(",", ".")

        'mysql kommando definieren
        Dim myQueryUpdateTanken As New MySqlCommand(MySqlUpdateTankenEintrag(MyRefuelDate, MyRefuelTimeB, MyRefuelQuantity, MyRefuelSum, MyRefuelRoute, MyRefuelMileage, refuelID), con)
        Dim myResultUpdateTanken As Object

        Dim updateTankenError As Boolean = False

        'mysql kommando ausführen
        myResultUpdateTanken = myQueryUpdateTanken.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultUpdateTanken) Then

            'wenn abfrage ohne ergebnis
            updateTankenError = True

        End If

        Return updateTankenError

    End Function

End Module