Public Class frmChoice

    Private arrRadColor(2) As RadioButton 'array of 3 Radio Button Objects
    Private arrRadTrim(2) As RadioButton
    Private arrChk(2) As CheckBox
    Private strColor As String 'to hold the color choice
    Private strTrim As String 'to hold the trim choice
    Private strStartDate As String
    Private strEndDate As String
    Private Summary As frmSummary 'object reference variable pointing to the other form

    Private Sub frmChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxChoices()
        LoadListBoxChocies()
        LoadCheckedListBoxChoices()

        'load the control arrays
        arrRadColor(0) = radRed
        arrRadColor(1) = radBlue
        arrRadColor(2) = radGreen
        arrRadTrim(0) = radGold
        arrRadTrim(1) = radSilver
        arrRadTrim(2) = radBlack
        arrChk(0) = chkExpress
        arrChk(1) = chkSaturday
        arrChk(2) = chkResidence
    End Sub

    Private Sub LoadComboBoxChoices()
        cboChoices.Items.Add("Long Sleeve Shirt")
        cboChoices.Items.Add("Short Sleeve Shirt")
        cboChoices.Items.Add("No Sleeve Shirt")
    End Sub

    Private Sub LoadListBoxChocies()
        lstSizes.Items.Add("Small")
        lstSizes.Items.Add("Medium")
        lstSizes.Items.Add("Large")
        lstSizes.Items.Add("XL")
        lstSizes.Items.Add("XXL")
    End Sub

    Private Sub LoadCheckedListBoxChoices()
        clbHats.Items.Add("Baseball cap")
        clbHats.Items.Add("Cowboy hat")
        clbHats.Items.Add("Tennis hat")
        clbHats.Items.Add("Golf hat")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To arrRadColor.Length - 1
            arrRadColor(i).Checked = False
        Next
        For i = 0 To arrRadTrim.Length - 1
            arrRadTrim(i).Checked = False
        Next
        For i = 0 To arrChk.Length - 1
            arrChk(i).CheckState = CheckState.Unchecked
        Next
        errP.Clear()
        cboChoices.SelectedIndex = -1 'clear selection only, not the list
        lstSizes.SelectedIndex = -1
        strColor = ""
        strTrim = ""
        strStartDate = ""
        strEndDate = ""
        mclSaleRange.SelectionStart = Today
        mclSaleRange.SelectionEnd = Today
        dtmApproval.Value = Today.Date
        For i = 0 To clbHats.Items.Count - 1
            clbHats.SetItemCheckState(i, CheckState.Unchecked)
            clbHats.SetSelected(i, False)
        Next
    End Sub

    Private Sub radColors_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged, radBlue.CheckedChanged, radGreen.CheckedChanged
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        'grab the color from the radio button that caused this event
        If rad.Checked Then 'only do this if the radio button is being turned on
            strColor = rad.Text 'text property containts the color
        End If
    End Sub

    Private Sub radTrims_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged, radGold.CheckedChanged, radSilver.CheckedChanged
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then
            strTrim = rad.Text
        End If
    End Sub

    Private Sub mclSaleRange_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mclSaleRange.DateSelected
        'capture the start and end date of the selected date range
        strStartDate = FormatDateTime(e.Start.ToString, DateFormat.ShortDate)
        strEndDate = FormatDateTime(e.End.ToString, DateFormat.ShortDate)

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim strResult As String
        Dim i As Integer
        Dim blnErrors As Boolean
        errP.Clear() 'clear any previous error messages
        'validate that the user made selectoins in the combo, listbox, and radiobuttons
        If cboChoices.SelectedIndex = -1 Then 'no slection was made
            errP.SetError(cboChoices, "You must select a sale item")
            blnErrors = True
        End If
        If lstSizes.SelectedIndex = -1 Then 'no selection was made
            errP.SetError(lstSizes, "You must select a size")
            blnErrors = True
        End If
        If strColor = "" Then 'no color was selected
            errP.SetError(grpColors, "You must select a color")
            blnErrors = True
        End If
        If strTrim = "" Then 'no trim was selected
            errP.SetError(grpTrim, "You must select a trim")
            blnErrors = True
        End If
        If strStartDate = "" Then
            errP.SetError(mclSaleRange, "You must select  the date range")
        End If
        If blnErrors Then
            Exit Sub 'jump out of the subroutine
        End If
        strResult = "You selected the following:" & vbCrLf
        strResult &= "Sale item: " & cboChoices.SelectedItem.ToString & vbCrLf
        strResult &= "Size: " & lstSizes.SelectedItem.ToString & vbCrLf
        strResult &= "Color: " & strColor & vbCrLf
        strResult &= "Trim: " & strTrim & vbCrLf
        strResult &= "Hats: " & vbCrLf
        For i = 0 To clbHats.Items.Count - 1
            If clbHats.GetItemCheckState(i) = CheckState.Checked Then
                strResult &= "    " & clbHats.Items(i).ToString & vbCrLf
            End If
        Next
        strResult &= "Delivery options: " & vbCrLf
        For i = 0 To arrChk.Length - 1
            If arrChk(i).Checked Then
                strResult &= "    " & arrChk(i).Text & vbCrLf
            End If
        Next
        strResult &= "Approval date: " & FormatDateTime(dtmApproval.Value, DateFormat.ShortDate) & vbCrLf
        strResult &= "Sale Start Date: " & strStartDate & vbCrLf
        'push this data to the summary form and show it
        Summary = New frmSummary
        Summary.lblSummary.Text = strResult
        Summary.ShowDialog()
        btnClear.PerformClick() 'simulate the user clicking on this button
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class