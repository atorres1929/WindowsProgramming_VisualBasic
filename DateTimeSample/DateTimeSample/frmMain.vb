Public Class frmMain
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dtiInteveralType As DateInterval
        Dim blnErrors As Boolean
        Dim dblAmount As Double
        errP.Clear()
        If Not ValidateListBox(lstIntervalAdd, errP) Then
            blnErrors = True
        End If
        If Not ValidateListBox(lstOp, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxNumeric(txtQty, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        dblAmount = CDbl(txtQty.Text)
        If lstOp.SelectedItem = "Subtract" Then
            dblAmount *= -1 'make it negative
        End If
        Select Case lstIntervalAdd.SelectedItem
            Case "Day"
                dtiInteveralType = DateInterval.Day
            Case "Month"
                dtiInteveralType = DateInterval.Month
            Case "Year"
                dtiInteveralType = DateInterval.Year
            Case Else
                MessageBox.Show("Unexpected date interval in btnAdd_Click", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        dtmEndAdd.Value = DateAdd(dtiInteveralType, dblAmount, dtmStartAdd.Value)
        lblResult.Text = CStr(dtmEndAdd.Value)
        lblAlt.Text = Format(dtmEndAdd.Value, "MM-dd-yyyy")

    End Sub

    Private Sub btnCalculateSpan_Click(sender As Object, e As EventArgs) Handles btnCalculateSpan.Click
        txtElapsed.Text = CStr(ElapsedTime(dtmStartSpan.Value, dtmEndSpan.Value, lstIntervalSpan.SelectedItem.ToString))
    End Sub

    Private Sub btnClearAdd_Click(sender As Object, e As EventArgs) Handles btnClearAdd.Click
        ClearScreenControls(grpAdd)
    End Sub

    Private Sub btnClearSpan_Click(sender As Object, e As EventArgs) Handles btnClearSpan.Click
        ClearScreenControls(grpSpan)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIntervalAdd.Items.Add("Day")
        lstIntervalAdd.Items.Add("Month")
        lstIntervalAdd.Items.Add("Year")
        lstOp.Items.Add("Add")
        lstOp.Items.Add("Subtract")

        lstIntervalSpan.Items.Add("Day")
        lstIntervalSpan.Items.Add("Hours")
        lstIntervalSpan.Items.Add("Minutes")
        lstIntervalSpan.Items.Add("Seconds")
        dtmStartSpan.Format = DateTimePickerFormat.Custom
        dtmStartSpan.CustomFormat = "hh:mm:ss"
        dtmEndSpan.Format = DateTimePickerFormat.Custom
        dtmEndSpan.CustomFormat = "hh:mm:ss"
    End Sub

    Private Function ElapsedTime(ByVal dtmEarly As Date, ByVal dtmLate As Date, strInterval As String) As Integer
        Dim tspDifference As TimeSpan = dtmLate.Subtract(dtmEarly)
        Select Case strInterval
            Case "Days"
                Return tspDifference.TotalDays
            Case "Hours"
                Return tspDifference.TotalHours
            Case "Minutes"
                Return tspDifference.TotalMinutes
            Case "Seconds"
                Return tspDifference.TotalSeconds
            Case Else
                MessageBox.Show("Unexpected interval type in ElapsedTime", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Return tspDifference.TotalDays

    End Function

End Class
