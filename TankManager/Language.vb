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

    '### Standard ###

    Public TM_STANDARD_DATE = "Datum"
    Public TM_STANDARD_TIME = "Uhrzeit"
    Public TM_STANDARD_FUELLED = "Getankt"
    Public TM_STANDARD_PAID = "Bezahlt"
    Public TM_STANDARD_SPEEDOMETER = "Tacho"
    Public TM_STANDARD_DRIVEN = "Gefahren"
    Public TM_STANDARD_MILAGE = "Tachostand"
    Public TM_STANDARD_CURRENCY = "EUR"
    Public TM_STANDARD_LITRE = "Liter"
    Public TM_STANDARD_COSTS = "Kosten"
    Public TM_STANDARD_CONSUMPTION = "Verbrauch"
    Public TM_STANDARD_KILOMETER = "Kilometer"
    Public TM_STANDARD_QUANTITY = "Menge"
    Public TM_STANDARD_TOTAL = "Summe"
    Public TM_STANDARD_TOTAL_SHORT = "Km"
    Public TM_STANDARD_CONSUMPTION_100KM = "Liter/100 Km"
    Public TM_STANDARD_PER_100KM = "pro 100 Km"
    Public TM_STANDARD_COSTS_PER_LITER = "Preis/Liter"
    Public TM_STANDARD_QUESTION_DELETE_ENTRY = "Eintrag löschen?"
    Public TM_STANDARD_QUESTION_SAVE_ENTRY = "Eintrag speichern?"

    Public TM_STANDARD_BUTTON_CANCEL = "Abbruch"
    Public TM_STANDARD_BUTTON_DELETE_ENTRY = "Eintrag löschen"
    Public TM_STANDARD_BUTTON_SAVE_AND_NEW = "Speichern && Neu"
    Public TM_STANDARD_BUTTON_SAVE_AND_EXIT = "Speichern && Schließen"

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

    'grouboxes
    Public TM_MAIN_GROUPBOX_SELECT_YEAR = "Jahr auswählen:"
    Public TM_MAIN_GROUPBOX_FUEL_COSTS_YEAR = "Benzinkosten/Jahr:"
    Public TM_MAIN_GROUPBOX_FUEL_COSTS_ALL = "Gesamtkosten Benzin:"
    Public TM_MAIN_GROUPBOX_REPAIR_COSTS_YEAR = "Reparaturkosten/Jahr:"
    Public TM_MAIN_GROUPBOX_REPAIR_COSTS_ALL = "Gesamtkosten Reparatur:"
    Public TM_MAIN_GROUPBOX_COSTS_YEAR = "Gesamtkosten/Jahr:"
    Public TM_MAIN_GROUPBOX_COSTS_ALL = "Gesamtkosten alles:"
    Public TM_MAIN_GROUPBOX_DRIVEN_YEAR = "Km gefahren/Jahr:"
    Public TM_MAIN_GROUPBOX_DRIVEN_ALL = "Gesamtkilometer gefahren:"
    Public TM_MAIN_GROUPBOX_AVERAGE_CONSUMPTION_YEAR = "durchschnittlicher Verbrauch/Jahr:"
    Public TM_MAIN_GROUPBOX_AVERAGE_CONSUMPTION_ALL = "gesamter durchschnittlicher Verbrauch"
    Public TM_MAIN_GROUPBOX_CAR_DATA = "Daten des Autos:"

    'labels
    Public TM_MAIN_LABEL_NUMBER_OF_DATARECORDS = "Anzahl Datensätze:"
    Public TM_MAIN_LABEL_CAR_YEAR_OF_CONSTRUCTION = "Baujahr"
    Public TM_MAIN_LABEL_CAR_AGE = "Alter"

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

    '### FormNewRefuel ###

    '### FormNewRepair ###

    'listview
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT = "<hier Arbeitsschritt eintragen>"
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_TITLE_TEXT = "Arbeitsschritt erfassen"
    Public TM_REPAIR_LV_REPAIR_NEW_POSITION_DESCRIPTION_TEXT = "Bitte den Arbeitsschritt eingeben, der in der Reparaturliste erfasst werden soll."
    Public TM_REPAIR_LV_REPAIR_CHANGE_POSITION_TITLE_TEXT = "Arbeitsschritt ändern"
    Public TM_REPAIR_LV_REPAIR_CHANGE_POSITION_DESCRIPTION_TEXT = "Bitte die neue oder geänderte Bezeichnung für den Abreitsschritt eingeben."

    '### FormEditRefuel ###
    Public TM_EDIT_REFUEL_TITLE = "Eintrag bearbeiten"

    'groupboxes
    Public TM_EDIT_REFUEL_GROUPBOX_DATE_AND_TIME = "Datum und Uhrzeit"

    'texte
    Public TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY = "Wollen Sie folgenden Eintrag wirklich löschen?"
    Public TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY_SUCCESS = "Eintrag wurde erfolgreich gelöscht"
    Public TM_EDIT_REFUEL_QUESTION_DELETE_ENTRY_ERROR = "Eintrag konnte nicht gelöscht werden"
    Public TM_EDIT_REFUEL_ENTRY_COULD_NOT_SAVED_SELECTED_DATE_IS_IN_FUTURE = "Der Eintrag kann nicht gespeichert werden. Das gewählte Datum liegt in der Zukunft."
    Public TM_EDIT_REFUEL_ENTRY_COULD_NOT_SAVED_FIELD_HAS_INVALID_VALUE = "Der Eintrag kann nicht gespeichert werden. Das Feld enthält einen ungültigen Wert."
    Public TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY = "Wollen Sie folgenden Eintrag wirklich speichern?"
    Public TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY_SUCCESS = "Eintrag wurde erfolgreich speichert."
    Public TM_EDIT_REFUEL_QUESTION_SAVE_ENTRY_ERROR = "Eintrag konnte nicht speichert werden"

    '### FormEditRepair ###

    '### FormInfo ###
    Public TM_INFO_SERVER_ADDRESS = "Serveradresse:"
    Public TM_INFO_SERVER_PORT = "Serverport:"
    Public TM_INFO_LOGGED_IN_AS = "angemeldet als:"
    Public TM_INFO_BUTTON_CLOSE = "Schließen"

End Module
