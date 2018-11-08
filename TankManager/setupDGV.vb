Module setupDGV

    Public Function setupDGVTanken()

        'Überschriften anpassen
        formMain.datagridviewTanken.Columns("id").HeaderText = "ID"
        formMain.datagridviewTanken.Columns("datum").HeaderText = "Datum"
        formMain.datagridviewTanken.Columns("zeit").HeaderText = "Uhrzeit"
        formMain.datagridviewTanken.Columns("liter").HeaderText = "Getankte Liter"
        formMain.datagridviewTanken.Columns("preis").HeaderText = "Summe bezahlt"
        formMain.datagridviewTanken.Columns("literpreis").HeaderText = "Preis pro Liter"
        formMain.datagridviewTanken.Columns("gefahren").HeaderText = "Km gefahren"
        formMain.datagridviewTanken.Columns("gesamt").HeaderText = "Gesamtkilometer"
        formMain.datagridviewTanken.Columns("verbrauch").HeaderText = "Verbrauch"

        'alle spalten auf nur lesen setzen
        formMain.datagridviewTanken.Columns(0).ReadOnly = True
        formMain.datagridviewTanken.Columns(1).ReadOnly = True
        formMain.datagridviewTanken.Columns(2).ReadOnly = True
        formMain.datagridviewTanken.Columns(3).ReadOnly = True
        formMain.datagridviewTanken.Columns(4).ReadOnly = True
        formMain.datagridviewTanken.Columns(5).ReadOnly = True
        formMain.datagridviewTanken.Columns(6).ReadOnly = True
        formMain.datagridviewTanken.Columns(7).ReadOnly = True
        formMain.datagridviewTanken.Columns(8).ReadOnly = True

        'Spalte ID verstecken
        formMain.datagridviewTanken.Columns(0).Visible = False

        'spalte verbrauch verkleinern
        'spalte auf füllen setzen
        'formMain.datagridviewTanken.Columns(8).Width = 90
        formMain.datagridviewTanken.Columns("verbrauch").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Function

    Public Function setupDGVReparaturen()

        'Überschriften anpassen
        formMain.datagridviewReparaturen.Columns("id").HeaderText = "ID"
        formMain.datagridviewReparaturen.Columns("datum").HeaderText = "Datum"
        formMain.datagridviewReparaturen.Columns("preis").HeaderText = "Summe"
        formMain.datagridviewReparaturen.Columns("nummer").HeaderText = "Nummer"
        formMain.datagridviewReparaturen.Columns("posten").HeaderText = "Arbeitsschritt"

        'alle spalten auf nur lesen setzen
        formMain.datagridviewReparaturen.Columns("datum").ReadOnly = True
        formMain.datagridviewReparaturen.Columns("preis").ReadOnly = True
        formMain.datagridviewReparaturen.Columns("nummer").ReadOnly = True
        formMain.datagridviewReparaturen.Columns("posten").ReadOnly = True

        'Spalte ID verstecken
        formMain.datagridviewReparaturen.Columns(0).Visible = False

        'spalten verkleinern
        formMain.datagridviewReparaturen.Columns("datum").Width = 70
        formMain.datagridviewReparaturen.Columns("preis").Width = 70
        formMain.datagridviewReparaturen.Columns("nummer").Width = 70

        'spalte auf füllen setzen
        formMain.datagridviewReparaturen.Columns("posten").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Function

End Module
