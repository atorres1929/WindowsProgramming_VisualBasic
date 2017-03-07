Public Class frmGenericStuff
    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Dim blnErrors As Boolean
        Dim intNumericGrade As Integer
        Dim intPosition As Integer
        If Not ValidateTextBoxLength(txtName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxNumeric(txtAge, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxNumeric(txtNumericGrade, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboGrade, errP) Then
            blnErrors = True
        End If
        If Not ValidateMaskedTextBoxDate(mskBirthday, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        For Each cntrl In Me.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.text.toupper()
            End If
        Next

        intNumericGrade = CInt(txtNumericGrade.Text)
        Select Case intNumericGrade
            Case Is < 60
                intPosition = cboGrade.FindStringExact("F")
            Case Is < 70
                intPosition = cboGrade.FindStringExact("D")
            Case Is < 80
                intPosition = cboGrade.FindStringExact("C")
            Case Is < 90
                intPosition = cboGrade.FindStringExact("B")
            Case Else
                intPosition = cboGrade.FindStringExact("A")
        End Select
        cboGrade.SelectedIndex = intPosition
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearScreenControls(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmGenericStuff_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboGrade.Items.Add("A")
        cboGrade.Items.Add("B")
        cboGrade.Items.Add("C")
        cboGrade.Items.Add("D")
        cboGrade.Items.Add("F")
    End Sub

    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtAge.GotFocus, txtName.GotFocus, txtNumericGrade.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub

    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtAge.LostFocus, txtName.LostFocus, txtNumericGrade.LostFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub
End Class
