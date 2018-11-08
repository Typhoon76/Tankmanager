Public Class formTest

    Private Sub formTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addHeadersToLV()

        'Testdaten
        ListView1.Items.Add(1).SubItems.Add("Winterreifen")
        ListView1.Items.Add(2).SubItems.Add("Bremsbeläge")
        ListView1.Items.Add(3).SubItems.Add("Scheibenwischer")
        ListView1.Items.Add(4).SubItems.Add("Ölwechsel")
        ListView1.Items.Add(5).SubItems.Add("Rückleuchten")

    End Sub

    'Print
    Private Sub buttonPagePreview_Click(sender As Object, e As EventArgs) Handles buttonPagePreview.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub buttonPrint_Click(sender As Object, e As EventArgs) Handles buttonPrint.Click

        PrintDialog1.ShowDialog()

    End Sub

    'Listview
    Private Sub buttonLVDown_Click(sender As Object, e As EventArgs) Handles buttonLVDown.Click

        Dim newIndex As Integer = 0

        For currentIndex As Integer = ListView1.Items.Count - 1 To 0 Step -1

            Dim li As ListViewItem = ListView1.Items(currentIndex)

            If li.Selected = True Then

                moveListViewItemDown(ListView1, li.Index)

                newIndex = li.Index

                renumerateLV()

                ListView1.Items(newIndex).Selected = True
                ListView1.Select()

            End If

        Next

    End Sub

    Private Sub buttonLVUp_Click(sender As Object, e As EventArgs) Handles buttonLVUp.Click

        Dim newIndex As Integer = 0

        For Each li As ListViewItem In ListView1.Items

            If li.Selected = True Then

                moveListViewItemUp(ListView1, li.Index)

                newIndex = li.Index

                renumerateLV()

                ListView1.Items(newIndex).Selected = True
                ListView1.Select()

            End If

        Next

    End Sub

    Private Sub buttonLVDelete_Click(sender As Object, e As EventArgs) Handles buttonLVDelete.Click

        If ListView1.SelectedItems.Count > 0 Then

            ListView1.Items.RemoveAt(ListView1.SelectedIndices(0))

            renumerateLV()

        End If

    End Sub

    Private Sub buttonLVEdit_Click(sender As Object, e As EventArgs) Handles buttonLVEdit.Click

        If ListView1.SelectedItems.Count > 0 Then

            Dim myText = InputBox(TM_REPAIR_LV_REPAIR_CHANGE_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_CHANGE_POSITION_TITLE_TEXT, ListView1.SelectedItems(0).SubItems(1).Text)

            ListView1.SelectedItems(0).SubItems(1).Text = myText

        End If

    End Sub

    Private Sub buttonLVAdd_Click(sender As Object, e As EventArgs) Handles buttonLVAdd.Click

        Dim myItems = ListView1.Items.Count

        Dim myText = InputBox(TM_REPAIR_LV_REPAIR_NEW_POSITION_DESCRIPTION_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_TITLE_TEXT, TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT)

        If Not myText = TM_REPAIR_LV_REPAIR_NEW_POSITION_STANDARD_TEXT And Not myText = "" Then

            ListView1.Items.Add(myItems + 1).SubItems.Add(myText)

        End If

    End Sub

    'Form
    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click

        ListView1.Clear()

        addHeadersToLV()

    End Sub

    Private Sub addHeadersToLV()

        ListView1.Columns.Add(TM_MAIN_DGV_REPAIR_NUMBER_TEXT)
        ListView1.Columns.Add(TM_MAIN_DGV_REPAIR_POSITION_TEXT)
        ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub renumerateLV()

        Dim newIndex As Integer = 1

        For Each item As ListViewItem In ListView1.Items

            item.Text = newIndex

            newIndex = newIndex + 1

        Next

    End Sub

    Private Sub moveListViewItemUp(ByVal _ListView As ListView, ByVal selectedIndex As Integer)
        Try
            If Not _ListView.Items(selectedIndex).Index = 0 Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer
                oldIndex = _ListView.Items(selectedIndex).Index
                toMove = _ListView.Items(selectedIndex)
                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex - 1, toMove)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub moveListViewItemDown(ByVal _ListView As ListView, ByVal selectedIndex As Integer)
        Try
            If Not _ListView.Items(selectedIndex).Index + 1 = _ListView.Items.Count Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer
                oldIndex = _ListView.Items(selectedIndex).Index
                toMove = _ListView.Items(selectedIndex)
                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex + 1, toMove)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class