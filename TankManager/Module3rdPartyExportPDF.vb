
'https://www.aspsnippets.com/Articles/Export-Windows-Forms-DataGridView-to-PDF-using-iTextSharp-C-and-VBNet.aspx

Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module Module3rdPartyExportPDF

    Public Sub ExportToPDF(myDGV As DataGridView, myFileNumber As Integer)

        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(myDGV.ColumnCount)

        pdfTable.DefaultCell.Padding = 3
        'pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In myDGV.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            'cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In myDGV.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = exportToPDFPath

        Dim myFile As String = "TankManager" & "_"

        If myFileNumber = 1 Then
            myFile = myFile & "Tanken" & "_"
        ElseIf myFileNumber = 2 Then
            myFile = myFile & "Reparaturen" & "_"
        End If

        'wenn Jahresauswahl numerisch ist
        If IsNumeric(formMain.comboboxJahrAuswahl.Text) Then

            'Jahr an Dateiname anhängen
            myFile = myFile & formMain.comboboxJahrAuswahl.Text

        Else

            'Alle Jahre an Dateiname anhängen
            myFile = myFile & "Alle_Jahre"

        End If

        'Datum an Dateiname anhängen
        myFile = myFile & "_" & Now.Day.ToString().PadLeft(2, "0") & "." & Now.Month.ToString().PadLeft(2, "0") & "." & Now.Year

        'Uhrzeit an Dateiname anhängen
        myFile = myFile & "_" & Now.Hour.ToString().PadLeft(2, "0") & "-" & Now.Minute.ToString().PadLeft(2, "0") & "-" & Now.Second.ToString().PadLeft(2, "0")

        'Endung an Dateiname anhängen
        myFile = myFile & ".pdf"

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        'Using stream As New FileStream(folderPath & "DataGridViewExport.pdf", FileMode.Create)
        Using stream As New FileStream(folderPath & myFile, FileMode.Create)
                Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()
                stream.Close()
            End Using
    End Sub

End Module
