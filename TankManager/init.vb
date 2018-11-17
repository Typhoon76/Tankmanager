Module init

    'True = zusätzliche Statusinformation werden angezeigt
    'False = zusätzliche Statusinformation werden unterdrückt
    Public myDebug As Boolean = False

    ' hier initialisieren wir erstmal die Variablen
    Public eintragDatum As Date
    Public eintragZeit As Date
    Public eintragLiter As Single
    Public eintragPreis As Single
    Public eintragPreisProLiter As Single
    Public eintragReparatur As Single
    Public eintragReparaturPreis As Single
    Public eintragGefahreneKm As Single
    Public eintragGesamtKm As Single
    Public eintragVerbrauch As Single

    ' und die Formate für die einzelnen Spalten
    Public formatDatum As String
    Public formatZeit As String
    Public formatLiter As String
    Public formatLiterpreis As String
    Public formatPreis As String
    Public formatKm As String
    Public formatGesamtKm As String

    Public autoBaujahr As Date = Nothing
    Public autoAlter As String = ""

    Public tankmanagerSettings As New classSettings
    Public tankmanagerConnection As New classConnection
    Public tankmanagerRefuel As New classRefuel
    Public tankmanagerRepair As New classRepair.Repairlist 'NEU
    Public iniFileName As String = Application.StartupPath & "\Tankmanager.ini"
    Public tankmanagerIni As New classIni(iniFileName)
    Public comboboxJahrAuswahlErsterEintrag As String = TM_MAIN_COMBOBOX_SHOW_ALL_YEARS

    'Variable für Verbindungsstatus definieren
    Public connectState As Boolean = False

    'Pfad für PDF Ausgabe
    Public exportToPDFPath = "C:\Temp\"

End Module