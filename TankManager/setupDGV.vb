Module setupDGV

    Public Function setupDGVTanken()

        'Überschriften anpassen
        formMain.DatagridviewTanken.Columns("id").HeaderText = "ID"
        formMain.DatagridviewTanken.Columns("datum").HeaderText = "Datum"
        formMain.DatagridviewTanken.Columns("zeit").HeaderText = "Uhrzeit"
        formMain.DatagridviewTanken.Columns("liter").HeaderText = "Getankte Liter"
        formMain.DatagridviewTanken.Columns("preis").HeaderText = "Summe bezahlt"
        formMain.DatagridviewTanken.Columns("literpreis").HeaderText = "Preis pro Liter"
        formMain.DatagridviewTanken.Columns("gefahren").HeaderText = "Km gefahren"
        formMain.DatagridviewTanken.Columns("gesamt").HeaderText = "Gesamtkilometer"
        formMain.DatagridviewTanken.Columns("verbrauch").HeaderText = "Verbrauch"

        'alle spalten auf nur lesen setzen
        formMain.DatagridviewTanken.Columns(0).ReadOnly = True
        formMain.DatagridviewTanken.Columns(1).ReadOnly = True
        formMain.DatagridviewTanken.Columns(2).ReadOnly = True
        formMain.DatagridviewTanken.Columns(3).ReadOnly = True
        formMain.DatagridviewTanken.Columns(4).ReadOnly = True
        formMain.DatagridviewTanken.Columns(5).ReadOnly = True
        formMain.DatagridviewTanken.Columns(6).ReadOnly = True
        formMain.DatagridviewTanken.Columns(7).ReadOnly = True
        formMain.DatagridviewTanken.Columns(8).ReadOnly = True

        'Spalte ID verstecken
        formMain.DatagridviewTanken.Columns(0).Visible = False

        'spalte verbrauch verkleinern
        'spalte auf füllen setzen
        'formMain.datagridviewTanken.Columns(8).Width = 90
        formMain.DatagridviewTanken.Columns("verbrauch").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Function

    Public Function setupDGVReparaturen()

        'Überschriften anpassen
        formMain.DatagridviewReparaturen.Columns("id").HeaderText = "ID"
        formMain.DatagridviewReparaturen.Columns("datum").HeaderText = "Datum"
        formMain.DatagridviewReparaturen.Columns("preis").HeaderText = "Summe"
        formMain.DatagridviewReparaturen.Columns("nummer").HeaderText = "Nummer"
        formMain.DatagridviewReparaturen.Columns("posten").HeaderText = "Arbeitsschritt"

        'alle spalten auf nur lesen setzen
        formMain.DatagridviewReparaturen.Columns("datum").ReadOnly = True
        formMain.DatagridviewReparaturen.Columns("preis").ReadOnly = True
        formMain.DatagridviewReparaturen.Columns("nummer").ReadOnly = True
        formMain.DatagridviewReparaturen.Columns("posten").ReadOnly = True

        'Spalte ID verstecken
        formMain.DatagridviewReparaturen.Columns(0).Visible = False

        'spalten verkleinern
        formMain.DatagridviewReparaturen.Columns("datum").Width = 70
        formMain.DatagridviewReparaturen.Columns("preis").Width = 70
        formMain.DatagridviewReparaturen.Columns("nummer").Width = 70

        'spalte auf füllen setzen
        formMain.DatagridviewReparaturen.Columns("posten").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Function

End Module
