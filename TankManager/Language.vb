Module Language

    'Namensschema
    'TM_<FORM>_<OBJEKTTYP>_<OBJEKTNAME>_

    '### Errors ###

    Public TM_ERROR_TYPE_MYSQL = "MySQL Fehler"
    Public TM_ERROR_TYPE_MYSQL_SERVER_CONNECTION = "MySQL Server Verbindung"
    Public TM_ERROR_TYPE_MYSQL_TABLE = "Tabellen Fehler"
    Public TM_ERROR_TYPE_DATA = "Datenfehler"
    'Public TM_ERROR_TYPE_
    'Public TM_ERROR_TYPE_
    'Public TM_ERROR_TYPE_

    Public TM_ERROR_MESSAGE_STANDARD = "Es ist ein Fehler aufgetreten"
    Public TM_ERROR_CODE = "Fehlercode: "

    Public TM_ERROR_MESSAGE_CONNECTION_OPEN = "Verbindung offen"
    Public TM_ERROR_MESSAGE_CONNECTION_TO_SERVER_COULD_NOT_OPEN = "Verbindung zum Server konnte nicht geöffnet werden:"
    Public TM_ERROR_MESSAGE_CONNECTION_CLOSED = "Verbindung geschlossen"
    Public TM_ERROR_MESSAGE_CONNECTION_TO_SERVER_COULD_NOT_CLOSED = "Verbindung konnte nicht geschlossen werden:"
    Public TM_ERROR_MESSAGE_CONNECTION_ALREADY_EXISTS = "Verbindung besteht bereits"

    Public TM_ERROR_MESSAGE_MYSQL_TABLE_SETTINGS_COULD_NOT_READ_COMPLETE = "Die Einstellungen konnten nicht richtig aus der Tabelle 'tbl_einstellungen' gelesen werden."
    Public TM_ERROR_MESSAGE_MYSQL_TABLE_REFUEL_HAS_NO_DATA = "'tbl_tanken' enthält keine Daten"

    Public TM_ERROR_MESSAGE_ENTRY_COULD_NOT_READ = "Eintrag Nummer %s konnte nicht gelesen werden"
    'Public TM_ERROR_MESSAGE_
    'Public TM_ERROR_MESSAGE_
    'Public TM_ERROR_MESSAGE_

    Public TM_MESSAGE_TITLE_EXIT_PROGRAM = "Programm beenden"
    Public TM_MESSAGE_QUESTION_EXIT_PROGRAM = "Wollen Sie das Programm wirklich beenden?"

    '### FormMain ###

    'menu
    Public TM_MAIN_MENU_FILE = "&Datei"
    Public TM_MAIN_MENU_FILE_SETUP_PAGE = "S&eite Einrichten"
    Public TM_MAIN_MENU_FILE_PRINT_PREVIEW = "Druck&vorschau"
    Public TM_MAIN_MENU_FILE_PRINT = "&Drucken"
    Public TM_MAIN_MENU_FILE_EXIT = "&Beenden"

    Public TM_MAIN_MENU_EDIT = "&Bearbeiten"
    Public TM_MAIN_MENU_EDIT_NEW_REFUEL = "Neue Tank&quittung eingeben"
    Public TM_MAIN_MENU_EDIT_NEW_REPAIR = "Neue &Reparatur eintragen"
    Public TM_MAIN_MENU_EDIT_SEARCH = "&Suchen"

    Public TM_MAIN_MENU_EXTRAS = "E&xtras"
    Public TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF = "Exportieren in PDF Datei"
    Public TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REFUEL = "Tabelle Tanken"
    Public TM_MAIN_MENU_EXTRAS_EXPORT_TO_PDF_TABLE_REPAIR = "Tabelle Reparaturen"
    Public TM_MAIN_MENU_EXTRAS_SETTINGS = "&Einstellungen"

    Public TM_MAIN_MENU_HELP = "&Hilfe"
    Public TM_MAIN_MENU_HELP_INFO = "&Info"

    'combobox
    Public TM_MAIN_COMBOBOX_SHOW_ALL_YEARS = "Alle Jahre anzeigen"
    Public TM_MAIN_COMBOBOX_SELECTED_VALUE_IS_NOT_VALID = "Der ausgewählte Eintrag (%s) der Jahresauswahl entspricht keinem erlaubten Wert."

    'export
    Public TM_MAIN_EXPORT_TO_FILE_ALL_YEARS_PART = "Alle_Jahre"

    'dgv
    Public TM_MAIN_DGV_REPAIR_NUMBER_TEXT = "Nummer"
    Public TM_MAIN_DGV_REPAIR_POSITION_TEXT = "Arbeitsschritt"

    'button show/hide reparations
    Public TM_MAIN_BUTTON_SHOW_REPAIRS = "Reparaturen anzeigen >>"
    Public TM_MAIN_BUTTON_HIDE_REPAIRS = "<< Reparaturen verbergen"

    'tables
    Public TM_MAIN_TABLE_REFUEL = "Tankliste"
    Public TM_MAIN_TABLE_REFUEL_COLON = "Tankliste: "
    Public TM_MAIN_TABLE_REPAIRS = "Reparaturliste"
    Public TM_MAIN_TABLE_REPAIRS_COLON = "Reparaturliste: "
    Public TM_MAIN_TABLE_ALL_YEARS_PART = "Alle Jahre"

    'print preview
    Public TM_MAIN_PREVIEW_REQUEST_TITLE = "Abfrage für Vorschau"
    Public TM_MAIN_PREVIEW_REQUEST_QUESTION = "Welche Vorschau soll angezeigt werden?"

    'print
    Public TM_MAIN_PRINT_REQUEST_TITLE = "Abfrage für Druck"
    Public TM_MAIN_PRINT_REQUEST_QUESTION = "Welche Liste soll gedruckt werden?"

    '### FormNewRepair ###

    'listview
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT = "<hier Arbeitsschritt eintragen>"
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_TITLE_TEXT = "Arbeitsschritt erfassen"
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_DESCRIPTION_TEXT = "Bitte den Arbeitsschritt eingeben, der in der Reparaturliste erfasst werden soll."
    Public TM_REPAIR_LV_REPAIR_CHANGE_POSITION_TITLE_TEXT = "Arbeitsschritt ändern"
    Public TM_REPAIR_LV_REPAIR_CHANGE_POSITION_DESCRIPTION_TEXT = "Bitte die neue oder geänderte Bezeichnung für den Abreitsschritt eingeben."

    '### FormInfo ###
    Public TM_INFO_SERVER_ADDRESS = "Serveradresse:"
    Public TM_INFO_SERVER_PORT = "Serverport:"
    Public TM_INFO_LOGGED_IN_AS = "angemeldet als:"
    Public TM_INFO_BUTTON_CLOSE = "Schließen"

End Module
