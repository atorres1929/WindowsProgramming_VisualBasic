'Name: Adam Torres
'Date: Mar 6 2017
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.
Imports System.IO

Public Class frmListView

#Region "Column Names"
    Private Const CUSTOMER_NAME As Integer = 0
    Private Const CUSTOMER_TYPE As Integer = 1
    Private Const BILL_WAIVED As Integer = 2
    Private Const TAXABLE As Integer = 3
    Private Const BILLING_YEAR As Integer = 4
    Private Const GAL_USED As Integer = 5
    Private Const GAL_BILLED As Integer = 6
    Private Const TAX As Integer = 7
    Private Const TOTAL_BILL As Integer = 8
#End Region
#Region "Calculation Constants"
    Private Const BILL_RATE_COMMERICAL As Integer = 3
    Private Const BILL_RATE_NON_PROFIT As Integer = 2
    Private Const BILL_RATE_GOVERNMENT As Single = 1.5
    Private Const BILL_PER_GALLONS = 1000
    Private Const TAX_RATE As Single = 0.035
    Private Const GALLON_LIMIT As Integer = 25000
    Private Const BILL_WAVED_TRUE As String = "Yes"
#End Region
#Region "Customer Types"
    Private Const CUSTOMER_GOVERNMENT As String = "GOV"
    Private Const CUSTOMER_NON_PROFIT As String = "NPROFIT"
    Private Const CUSTOMER_COMMERCIAL As String = "COM"
#End Region
#Region "Overall Statistics"
    Private totalCustomers As Integer
    Private totalGallonsUsed As Integer
    Private totalGallonsBilled As Integer
    Private totalTax As Single
    Private totalBills As Single
#End Region

    Private Stats As frmStatistics
    Private NonProfitCustomer As CCustomerTypeStats
    Private GovernmentCustomerType As CCustomerTypeStats
    Private CommercialCustomerType As CCustomerTypeStats

    Private Sub frmListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Stats = New frmStatistics
        NonProfitCustomer = New CCustomerTypeStats
        GovernmentCustomerType = New CCustomerTypeStats
        CommercialCustomerType = New CCustomerTypeStats
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub OpenFile()
        lvwBills.Clear()
        Dim intResult As Integer
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "All Files ('.')|'.'|Text Files (*.txt)|*.txt"
        ofdOpen.FilterIndex = 2
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        Try
            ReadFile(ofdOpen.FileName)
        Catch ex As FileNotFoundException
            ShowError("File Not Found: " & ex.ToString)
        Catch ex As IOException
            ShowError("IO Exception: " & ex.ToString)
        Catch ex As Exception
            ShowError("Unknown Error: " & ex.ToString)
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
        Try
            WriteFile(sfdSave.FileName)
        Catch exNotFound As FileNotFoundException
            MessageBox.Show("File Not Found: " & exNotFound.ToString)
        Catch exIOError As IOException
            MessageBox.Show("IO error: " & exIOError.ToString)
        Catch exOther As Exception
            'anything else that might go wrong
            MessageBox.Show("Error: " & exOther.ToString)
        End Try
    End Sub

    Private Sub WriteFile(strOut As String)
        Dim fileOut As StreamWriter
        Dim strLineOut As String = ""
        Dim i As Integer
        Dim j As Integer
        Try
            fileOut = New StreamWriter(strOut)

            'write column names to file
            For i = 0 To lvwBills.Columns.Count - 1
                If i <> lvwBills.Columns.Count - 1 Then
                    strLineOut &= lvwBills.Columns(i).Text & ","
                Else
                    strLineOut &= lvwBills.Columns(i).Text
                End If
            Next
            fileOut.WriteLine(strLineOut)

            'write column data to file
            For i = 0 To lvwBills.Items.Count - 1 'handle the first item in the row
                strLineOut = lvwBills.Items(i).Text
                For j = 1 To lvwBills.Items(i).SubItems.Count - 1 'handle the rest of the items in the row
                    strLineOut &= "," & lvwBills.Items(i).SubItems(j).Text
                Next
                'write out each line after it is assembled
                fileOut.WriteLine(strLineOut)
            Next
            fileOut.Close()
            fileOut.Dispose()
        Catch ex As IOException
            ShowError("IOException while writing file: " & ex.ToString)
        Catch ex As Exception
            ShowError("Program Error" & ex.ToString)
        End Try
    End Sub

    Private Sub ReadFile(fileName As String)
        Dim reader As StreamReader = New StreamReader(fileName)
        Dim line As String
        Dim elements() As String
        Try
            'Read first line to get column headers
            If Not reader.EndOfStream Then
                line = reader.ReadLine
                elements = line.Split(",")
                For Each col As String In elements
                    lvwBills.Columns.Add(col)
                Next
                With lvwBills.Columns
                    .Add("Gallons Billed")
                    .Add("Water Bill")
                    .Add("Tax")
                    .Add("Total Bill")
                End With
            End If

            'Read rest of file
            'ListViewItem = First Element in Row
            'ListViewItem.ListViewSubItem = Rest of the items in the row
            While Not reader.EndOfStream
                line = reader.ReadLine
                elements = line.Split(",")
                Dim currentCustomer As New CCustomerTypeStats

                'add the first item to the lvw
                Dim lviRow As New ListViewItem(elements(0))

                'add rest of items to lvw that reside within elements
                For i = 1 To elements.Length - 1
                    lviRow.SubItems.Add(elements(i))
                Next

                '**
                'add items that were not in elements (must be calculated)
                '**

                'Gallons Billed
                Dim billWaved As Boolean
                Dim galUsed As Integer = CInt(elements(GAL_USED))
                If elements(BILL_WAIVED).Equals(BILL_WAVED_TRUE) Or CInt(elements(GAL_USED)) < GALLON_LIMIT Then
                    lviRow.SubItems.Add(0)
                    billWaved = True
                Else
                    lviRow.SubItems.Add(galUsed)
                    totalGallonsBilled += galUsed
                    currentCustomer.GallonsBilled += galUsed
                    billWaved = False
                End If

                'Total Gallons Used added regardless of how many are billed
                totalGallonsUsed += galUsed
                currentCustomer.GallonsUsed += galUsed

                'Water Bill
                Dim bill As Single
                If billWaved Then
                    bill = 0
                Else
                    Select Case elements(CUSTOMER_TYPE)
                        Case CUSTOMER_COMMERCIAL
                            bill = BILL_RATE_COMMERICAL * (galUsed / BILL_PER_GALLONS)
                        Case CUSTOMER_GOVERNMENT
                            bill = BILL_RATE_GOVERNMENT * (galUsed / BILL_PER_GALLONS)
                        Case CUSTOMER_NON_PROFIT
                            bill = BILL_RATE_NON_PROFIT * (galUsed / BILL_PER_GALLONS)
                        Case Else
                            ShowError("Error calculating bill rate")
                            Exit Sub
                    End Select
                End If

                lviRow.SubItems.Add(FormatCurrency(bill))

                'Tax
                Dim tax As Single = bill * TAX_RATE
                lviRow.SubItems.Add(FormatCurrency(tax))
                currentCustomer.Taxes += tax

                'Total Tax
                totalTax += tax

                'Total Charge
                Dim total As Single = tax + bill
                lviRow.SubItems.Add(FormatCurrency(total))
                currentCustomer.Bill += total

                'Total Bill
                totalBills += total

                'now add the completed row to the list view
                lvwBills.Items.Add(lviRow)

                'Total Customers count

                totalCustomers += 1
                Dim customerType As String = elements(CUSTOMER_TYPE)
                Select Case customerType
                    Case CUSTOMER_COMMERCIAL
                        currentCustomer.Customers += 1
                        CommercialCustomerType.addValues(currentCustomer)
                    Case CUSTOMER_GOVERNMENT
                        currentCustomer.Customers += 1
                        GovernmentCustomerType.addValues(currentCustomer)
                    Case CUSTOMER_NON_PROFIT
                        currentCustomer.Customers += 1
                        NonProfitCustomer.addValues(currentCustomer)
                    Case Else
                        ShowError("Error: Unknown Customer Type")
                End Select
            End While
            lvwBills.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lvwBills.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            reader.Close()
            reader.Dispose()
        Catch ex As IOException
            ShowError("Program IOError: " & ex.ToString)
        Catch ex As Exception
            ShowError("Program Error: " & ex.ToString)
        End Try
    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        OpenFile()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        OpenFile()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuOverallStats_Click(sender As Object, e As EventArgs) Handles mnuOverallStats.Click
        Stats.Text = "Overall Statistics"
        With Stats.lstStats.Items
            .Clear()
            .Add("Total Customers: " & totalCustomers)
            .Add("Total Gallons Used: " & totalGallonsUsed)
            .Add("Total Gallons Billed: " & totalGallonsBilled)
            .Add("Total Taxes Collected: " & FormatCurrency(totalTax))
            .Add("Total of All Bills: " & FormatCurrency(totalBills))
        End With
        Stats.ShowDialog()
    End Sub

    Private Sub mnuCustomerStats_Click(sender As Object, e As EventArgs) Handles mnuCustomerStats.Click
        Stats.Text = "Customer Statistics"
        With Stats.lstStats.Items
            .Clear()
            .Add("COMMERICAL CUSTOMERS")
            .Add("Total Customers: " & CommercialCustomerType.Customers)
            .Add("Total Gallons Used: " & CommercialCustomerType.GallonsUsed)
            .Add("Total Gallons Billed: " & CommercialCustomerType.GallonsBilled)
            .Add("Total Taxes Collected: " & FormatCurrency(CommercialCustomerType.Taxes))
            .Add("Total of All Bills: " & FormatCurrency(CommercialCustomerType.Bill))
            .Add("")
            .Add("NON-PROFIT CUSTOMERS")
            .Add("Total Customers: " & NonProfitCustomer.Customers)
            .Add("Total Gallons Used: " & NonProfitCustomer.GallonsUsed)
            .Add("Total Gallons Billed: " & NonProfitCustomer.GallonsBilled)
            .Add("Total Taxes Collected: " & FormatCurrency(NonProfitCustomer.Taxes))
            .Add("Total of All Bills: " & FormatCurrency(NonProfitCustomer.Bill))
            .Add("")
            .Add("GOVERNMENT CUSTOMERS")
            .Add("Total Customers: " & GovernmentCustomerType.Customers)
            .Add("Total Gallons Used: " & GovernmentCustomerType.GallonsUsed)
            .Add("Total Gallons Billed: " & GovernmentCustomerType.GallonsBilled)
            .Add("Total Taxes Collected: " & FormatCurrency(GovernmentCustomerType.Taxes))
            .Add("Total of All Bills: " & FormatCurrency(GovernmentCustomerType.Bill))
        End With
        Stats.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvwBills.Clear()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        SaveFile()
    End Sub
End Class
