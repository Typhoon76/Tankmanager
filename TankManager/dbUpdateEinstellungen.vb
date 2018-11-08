Module dbUpdateEinstellungen

    'Abfrage: Einstellungen
    Public Function MySqlUpdateEinstellungen()

        'variable definieren und predefined statement einfügen
        Dim update_statement As String = "UPDATE `tankmanager`.`tbl_einstellungen` SET `car_date_of_construction`='" & Format(tankmanagerSettings.date_of_construction, "yyyy-MM-dd") & "', `format_date`='" & tankmanagerSettings.format_date & "', `format_time`='" & tankmanagerSettings.format_time & "', `format_quantity`='" & tankmanagerSettings.format_quantity & "', `format_price`='" & tankmanagerSettings.format_price & "', `format_price_per_liter`='" & tankmanagerSettings.format_price_per_liter & "', `format_route`='" & tankmanagerSettings.format_route & "', `format_mileage`='" & tankmanagerSettings.format_mileage & "', `comboboxJahrAuswahlSelected`='" & tankmanagerSettings.selectedYear & "', "
        If tankmanagerSettings.tankenHideDoubleDateEntries = True Then update_statement = update_statement & "`tankenHideDoubleDateEntries`='1', " Else update_statement = update_statement & "`tankenHideDoubleDateEntries`='0', "
        If tankmanagerSettings.reparaturHideDoubleDateEntries = True Then update_statement = update_statement & "`reparaturHideDoubleDateEntries`='1', " Else update_statement = update_statement & "`reparaturHideDoubleDateEntries`='0', "
        If tankmanagerSettings.reparaturHideDoublePriceEntries = True Then update_statement = update_statement & "`reparaturHideDoublePriceEntries`='1';" Else update_statement = update_statement & "`reparaturHideDoublePriceEntries`='0';"

        'Statement zurückgeben
        Return update_statement

    End Function

End Module
