Module dbSelectAlter

    'Spezialabfrage: Alter des Autos
    Public Function MySqlSelectAlter()

        'variable definieren und predefined statement einfügen
        Dim select_statement As String = "SELECT 
TRUNCATE(DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) / 365.25, 0) As Jahre,
TRUNCATE((DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) - TRUNCATE(TRUNCATE(DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) / 365.25, 0) * 365.25, 0)) / 30.4375, 0) As Monate,
DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) - TRUNCATE(TRUNCATE(DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) / 365.25, 0) * 365.25, 0) - 
TRUNCATE(TRUNCATE((DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) - TRUNCATE(TRUNCATE(DATEDIFF(CURDATE(), `tankmanager`.`tbl_einstellungen`.`car_date_of_construction`) / 365.25, 0) * 365.25, 0)) / 30.4375, 0) * 30.4375, 0) As Tage
FROM `tankmanager`.`tbl_einstellungen`;"

        'Statement zurückgeben
        Return select_statement

    End Function

End Module
