Imports MySql.Data.MySqlClient

Module writeRefuel

    Public Function schreibeTanken(myDate, myTime, myQuantity, mySum, myRoute, myMileage)

        'mysql kommando definieren
        Dim myQuerySchreibeTanken As New MySqlCommand(MySqlInsertTanken(myDate, myTime, myQuantity, mySum, myRoute, myMileage), con)
        Dim myResultSchreibeTanken As Object

        Dim schreibeTankenError As Boolean = False

        'mysql kommando ausführen
        myResultSchreibeTanken = myQuerySchreibeTanken.ExecuteScalar()

        'wenn abfrage ohne ergebnis fehler melden
        If IsDBNull(myResultSchreibeTanken) Then

            'wenn abfrage ohne ergebnis
            schreibeTankenError = True

        End If

        Return schreibeTankenError

    End Function

End Module