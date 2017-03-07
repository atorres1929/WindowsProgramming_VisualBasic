
Imports System.IO
Public Class frmListView

    Private strFileName As String
    Private arrCategories As ArrayList
    Private dblTotalInvValue As Double
    Private intTotalInvCount As Integer
    Private Stats As frmStats

#Region "Column Constants"
    'constants to manage the listview columns
    Private Const ARTID As Integer = 0
    Private Const ARTIST As Integer = 1
    Private Const TITLE As Integer = 2
    Private Const DATE_ACQUIRED As Integer = 3
    Private Const CATEGORY As Integer = 4
    Private Const CONDITION As Integer = 5
    Private Const ITEM_LOCATION As Integer = 6
    Private Const ITEM_VALUE As Integer = 7
    Private Const INS_PERCENT As Single = 0.03

#End Region
    Private Sub OpenFile()
        Dim intResult As Integer
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "All Files ('.')|'.'|Text Files (*.txt)|*.txt"
        ofdOpen.FilterIndex = 2
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        strFileName = ofdOpen.FileName
        Try
            ReadInputFile(strFileName)
        Catch exNotFound As FileNotFoundException
            MessageBox.Show("File Not Found: " & exNotFound.ToString)
        Catch exIOError As IOException
            MessageBox.Show("IO error: " & exIOError.ToString)
        Catch exOther As Exception
            'anything else that might go wrong
            MessageBox.Show("Error: " & exOther.ToString)
        End Try
    End Sub

    Private Sub SaveFile()
        Dim intResult As Integer
        sfdSave.InitialDirectory = Application.StartupPath
        sfdSave.Filter = "All Files ('.')|'.'|Text Files (*.txt)|*.txt"
        sfdSave.FilterIndex = 2
        intResult = sfdSave.ShowDialog
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        strFileName = sfdSave.FileName
        Try
            WriteOutputFile(strFileName)
        Catch exNotFound As FileNotFoundException
            MessageBox.Show("File Not Found: " & exNotFound.ToString)
        Catch exIOError As IOException
            MessageBox.Show("IO error: " & exIOError.ToString)
        Catch exOther As Exception
            'anything else that might go wrong
            MessageBox.Show("Error: " & exOther.ToString)
        End Try
    End Sub

    Private Sub ReadInputFile(strIn As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String 'String array to hold the fileds from a record in the file
        Dim i As Integer
        lvwInventory.Items.Clear()
        Try
            fileIn = New StreamReader(strIn)
            If Not fileIn.EndOfStream Then 'get the first line, use it to build column headers
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",") 'specify the delimeter
                For i = 0 To strFields.Length - 1
                    lvwInventory.Columns.Add(strFields(i))
                Next
                'do som formating
                With lvwInventory
                    .Columns(ARTIST).Width = 80
                    .Columns(TITLE).Width = 150
                    .Columns(DATE_ACQUIRED).Width = 80
                    .Columns(CATEGORY).Width = 80
                    .Columns(CONDITION).Width = 80
                    .Columns(ITEM_LOCATION).Width = 80
                    .Columns(ITEM_VALUE).Width = 100
                    .Columns(ITEM_VALUE).TextAlign = HorizontalAlignment.Right

                End With
            End If 'end of building column headers
            'now get the data for each row

            While Not fileIn.EndOfStream
                strLineIn = fileIn.ReadLine
                strFields = strLineIn.Split(",")
                Dim sngInsCost As Single
                'set up the first column value in a new listView item (the row)
                Dim lviRow As New ListViewItem(strFields(0))
                'now add the rest of the columns as subitems to that listViewItem
                For i = 1 To strFields.Length - 1
                    Dim lsiCol As New ListViewItem.ListViewSubItem
                    If i <> ITEM_VALUE Then
                        lsiCol.Text = strFields(i)
                    Else 'it is the money value
                        lsiCol.Text = FormatCurrency(strFields(i), 0)
                    End If

                    'now add this column to the row
                    lviRow.SubItems.Add(lsiCol)
                Next
                sngInsCost = INS_PERCENT * CSng(strFields(ITEM_VALUE))

                Dim lsiColIns As New ListViewItem.ListViewSubItem
                lsiColIns.Text = FormatCurrency(sngInsCost, 2)
                lviRow.SubItems.Add(lsiColIns)
                'now add the completed row to the list view
                lvwInventory.Items.Add(lviRow)
                UpdateStatistics(lviRow) 'pass the row to accumulate the statistics
            End While
            fileIn.Close()
            fileIn.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub WriteOutputFile(strOut As String)
        Dim fileOut As StreamWriter
        Dim strLineOut As String = ""
        Dim i As Integer
        Dim j As Integer
        Try
            fileOut = New StreamWriter(strOut)
            'build the field names as the first line in the output file
            For i = 0 To lvwInventory.Columns.Count - 1
                If i <> lvwInventory.Columns.Count - 1 Then
                    strLineOut &= lvwInventory.Columns(i).Text & ","
                Else
                    strLineOut &= lvwInventory.Columns(i).Text
                End If
            Next
            'write out the column headings to the output file
            fileOut.WriteLine(strLineOut)
            'build each data line with commas separating the fields
            'by looping through the rows and columns of the listview

            For i = 0 To lvwInventory.Items.Count - 1
                strLineOut = lvwInventory.Items(i).Text 'handle the rows
                For j = 1 To lvwInventory.Items(i).SubItems.Count - 1 'write thefirts column's
                    strLineOut &= "," & lvwInventory.Items(i).SubItems(j).Text 'handle the 
                Next
                'write out each line after it is assembled
                fileOut.WriteLine(strLineOut)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateStatistics(aRow As ListViewItem)
        Dim blnFoundIt As Boolean
        'first check if the new row's category already exists in our arraylist
        For Each aCat As CCategory In arrCategories
            If aCat.CatName = aRow.SubItems(CATEGORY).Text Then 'we have it
                aCat.TotalValue += CDbl(aRow.SubItems(ITEM_VALUE).Text)
                aCat.TotalCount += 1
                blnFoundIt = True
                Exit For 'early exit out of the For loop
            End If
        Next
        If Not blnFoundIt Then 'need to create a new Category object
            Dim newCat As New CCategory(aRow.SubItems(CATEGORY).Text, CDbl(aRow.SubItems(ITEM_VALUE).Text))
            arrCategories.Add(newCat) 'add the new CCategory object to the arraylist
        End If
        'update the grand total/count also
        dblTotalInvValue += CDbl(aRow.SubItems(ITEM_VALUE).Text)
        intTotalInvCount += 1

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFile()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        OpenFile()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        SaveFile()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvwInventory.Items.Clear()
    End Sub

    Private Sub frmListView_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrCategories = New ArrayList
        Stats = New frmStats
    End Sub

    Private Sub mnuStats_Click(sender As Object, e As EventArgs) Handles mnuStats.Click
        Stats.lstStats.Items.Clear()
        With Stats.lstStats
            .Items.Add("Total Inventory Value = " & FormatCurrency(dblTotalInvValue))
            .Items.Add("Total Inventory Count = " & CStr(intTotalInvCount))
            For Each aCat As CCategory In arrCategories
                .Items.Add(aCat.CatName & ":")
                .Items.Add("    Value =  " & FormatCurrency(aCat.TotalValue))
                .Items.Add("    Count = " & CStr(aCat.TotalCount))
            Next
        End With
        Stats.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
