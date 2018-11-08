Imports MySql.Data.MySqlClient

Module readAge

    Public Function LeseAlter()

        'Text der Textbox Baujahr setzen
        formMain.textboxAutoBaujahr.Text = Format(tankmanagerSettings.date_of_construction, tankmanagerSettings.format_date)

        'Variablen definieren
        Dim dbQueryAutoAlter As New MySqlCommand(MySqlSelectAlter(), con)
        Dim dbResultAutoAlter As MySqlDataReader

        'Alter abfragen
        dbResultAutoAlter = dbQueryAutoAlter.ExecuteReader

        'wenn die Einstellungen eine Zeile haben dann
        While (dbResultAutoAlter.Read())

            If dbResultAutoAlter.HasRows = True Then

                'Jahre und Monate abfragen
                Dim myJahre As Integer = dbResultAutoAlter("Jahre")
                Dim myMonate As Integer = dbResultAutoAlter("Monate")
                Dim myTage As Integer = dbResultAutoAlter("Tage")

                'Variablen definieren
                Dim myJahrString As String
                Dim myMonatString As String
                Dim myTagString As String

                'Anzahl prüfen und String anpassen
                If myJahre = 1 Then myJahrString = "Jahr" Else myJahrString = "Jahre"
                If myMonate = 1 Then myMonatString = "Monat" Else myMonatString = "Monate"
                If myTage = 1 Then myTagString = "Tag" Else myTagString = "Tage"

                If DatePart(DateInterval.Month, tankmanagerSettings.date_of_construction) = "02" And myTage > 28 Then
                    myTage = 0
                ElseIf DatePart(DateInterval.Month, tankmanagerSettings.date_of_construction) = "04" Or
                    DatePart(DateInterval.Month, tankmanagerSettings.date_of_construction) = "06" Or
                    DatePart(DateInterval.Month, tankmanagerSettings.date_of_construction) = "09" Or
                    DatePart(DateInterval.Month, tankmanagerSettings.date_of_construction) = "11" And myTage > 30 Then
                    myTage = 0
                ElseIf myMonate = 12 Then
                    myMonate = 0
                    myJahre = myJahre + 1
                End If

                'Text der Textbox Alter setzen
                formMain.textboxAutoAlter.Text = myJahre & " " & myJahrString & ", " & myMonate & " " & myMonatString & ", " & myTage & " " & myTagString

            End If

        End While

        'Alterabfrage schließen
        dbResultAutoAlter.Close()

    End Function

End Module
