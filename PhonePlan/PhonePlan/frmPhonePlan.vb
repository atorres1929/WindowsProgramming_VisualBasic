Public Class frmPhonePlan

    Private Summary As frmSummary
    Private sngMonthlyFee As Single = -1
    Private sngOptionalFee As Single = -1
    Private arrRadPhone(2) As RadioButton
    Private arrRadPlan(NUM_PLANS - 1) As RadioButton
    Private arrSngPlanCosts(NUM_PLANS - 1) As Single
    Private arrStrPlanDescriptions(NUM_PLANS - 1) As String

    Private Const NUM_PLANS As Integer = 4
    Private Const BASIC_PLAN As Single = 19.95
    Private Const TEXT50 As Single = 24.95
    Private Const TEXT200 As Single = 34.95
    Private Const UNLIMITED As Single = 44.95
    Private Const OPTIONAL_DATA_PLAN As Single = 20.0


    Private Sub frmPhonePlan_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Summary = New frmSummary
        radPhone1.Checked = False
        picPhone.Hide()
        lblWarningScale.Hide()
        lblOptionalDataPlan.Hide()

        arrRadPhone(0) = radPhone1
        arrRadPhone(1) = radPhone2
        arrRadPhone(2) = radPhone3

        arrRadPlan(0) = radPlanBasic
        arrRadPlan(1) = radPlan50
        arrRadPlan(2) = radPlan200
        arrRadPlan(3) = radPlanUnlimited

        arrSngPlanCosts(0) = BASIC_PLAN
        arrSngPlanCosts(1) = TEXT50
        arrSngPlanCosts(2) = TEXT200
        arrSngPlanCosts(3) = UNLIMITED

        arrStrPlanDescriptions(0) = " Cell Service Only"
        arrStrPlanDescriptions(1) = " Cell Service and 50 Text Messages"
        arrStrPlanDescriptions(2) = " Cell Service and 200 Text Messages"
        arrStrPlanDescriptions(3) = " Cell Service and Unlimited Text Messages"

    End Sub

    Private Sub radPhoneSelection_Click(sender As Object, e As EventArgs) Handles radPhone1.Click, radPhone2.Click, radPhone3.Click
        picPhone.Show()
        lblWarningScale.Show()

        Select Case sender.ToString
            Case radPhone1.ToString
                picPhone.Load("Resources/Galaxy S7.png")
            Case radPhone2.ToString
                picPhone.Load("Resources/Google Pixel.jpeg")
            Case radPhone3.ToString
                picPhone.Load("Resources/iPhone 7.png")
        End Select
    End Sub

    Private Sub chkOptionalDataPlan_MouseEnter(sender As Object, e As EventArgs) Handles chkOptionalDataPlan.MouseEnter
        lblOptionalDataPlan.Show()
    End Sub

    Private Sub chkOptionalDataPlan_MouseLeave(sender As Object, e As EventArgs) Handles chkOptionalDataPlan.MouseLeave
        If chkOptionalDataPlan.Checked Then
            Exit Sub
        End If
        lblOptionalDataPlan.Hide()
    End Sub

    Private Sub chkOptionalDataPlan_Click(sender As Object, e As EventArgs) Handles chkOptionalDataPlan.Click
        lblOptionalDataPlan.Show()
        CalculateMonthlyFee()
    End Sub

    Private Sub radPhonePlanSelection_MouseEnter(sender As Object, e As EventArgs) Handles radPlan200.MouseEnter, radPlan50.MouseEnter, radPlanBasic.MouseEnter, radPlanUnlimited.MouseEnter

        If PhonePlaneSelected() Then
            Exit Sub
        End If
        SelectPhonePlan(sender)

    End Sub

    Private Sub radPlanBasic_MouseLeave(sender As Object, e As EventArgs) Handles radPlanBasic.MouseLeave, radPlan50.MouseLeave, radPlan200.MouseLeave, radPlanUnlimited.MouseLeave
        If PhonePlaneSelected() Then
            Exit Sub
        End If
        lblPhonePlan.Hide()
    End Sub

    Private Sub radChoosePhonePlan_Click(sender As Object, e As EventArgs) Handles radPlanBasic.Click, radPlan50.Click, radPlan200.Click, radPlanUnlimited.Click
        SelectPhonePlan(sender)
    End Sub

    Private Sub SelectPhonePlan(rad As RadioButton)
        Dim strPlanSelection As String = "Error"

        Dim i As Integer
        For i = 0 To arrRadPlan.Length - 1
            'Check which plan was chosen by comparing hases of those radio buttons in the array, and that which was selected
            If arrRadPlan(i).GetHashCode = rad.GetHashCode Then
                sngMonthlyFee = arrSngPlanCosts(i)
                strPlanSelection = FormatCurrency(sngMonthlyFee) & vbCrLf & arrStrPlanDescriptions(i)
            End If
        Next

        lblPhonePlan.Text = strPlanSelection
        lblPhonePlan.Show()

        If PhonePlaneSelected() Then
            CalculateMonthlyFee()
        End If
    End Sub

    Private Function PhonePlaneSelected() As Boolean
        For Each rad As RadioButton In grpPlanChoice.Controls
            If rad.Checked Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub CalculateMonthlyFee()
        If chkOptionalDataPlan.Checked Then
            sngOptionalFee = OPTIONAL_DATA_PLAN
        Else
            sngOptionalFee = 0
        End If
        lblMonthlyFee.Text = "Monthly Fee: " & FormatCurrency(sngMonthlyFee + sngOptionalFee)
    End Sub

    Private Function IsError() As Boolean
        errP.Clear()

        'Checking if both Radio Button groups have a selection
        Dim i As Integer
        Dim booPhoneSelected As Boolean = False
        Dim booPlanSelected As Boolean = False
        For i = 0 To arrRadPhone.Length - 1
            If arrRadPhone(i).Checked Then
                booPhoneSelected = True
            End If
        Next
        For i = 0 To arrRadPlan.Length - 1
            If arrRadPlan(i).Checked Then
                booPlanSelected = True
            End If
        Next

        'Setting up errors
        If Not booPhoneSelected Then
            errP.SetError(grpPhoneChoice, "You must select a phone")
        End If
        If Not booPlanSelected Then
            errP.SetError(grpPlanChoice, "You must select a plan")
        End If

        'If the phone or plan is not selected, then return false
        Return Not (booPhoneSelected And booPlanSelected)
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If IsError() Then
            Exit Sub
        End If

        Summary.lstSummary.Items.Clear()

        'Find and gather the text related to each selected control
        Dim strSelectedPhone As String = "Phone Selected: "
        Dim strSelectedPlan As String = "Plan Selected: "
        Dim i As Integer
        For i = 0 To arrRadPhone.Length - 1
            If arrRadPhone(i).Checked Then
                strSelectedPhone &= arrRadPhone(i).Text
                Exit For
            End If
        Next

        For i = 0 To arrRadPlan.Length - 1
            If arrRadPlan(i).Checked Then
                strSelectedPlan &= arrRadPlan(i).Text & " |" & arrStrPlanDescriptions(i)
                Exit For
            End If
        Next

        'Add the control's text to the list
        With Summary.lstSummary.Items
            .Add(strSelectedPhone)
            .Add(strSelectedPlan)
            If chkOptionalDataPlan.Checked Then
                .Add(lblOptionalDataPlan.Text)
            End If
            .Add(lblMonthlyFee.Text)
        End With

        Summary.ShowDialog()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To arrRadPhone.Length - 1
            arrRadPhone(i).Checked = False
        Next
        For i = 0 To arrRadPlan.Length - 1
            arrRadPlan(i).Checked = False
        Next
        picPhone.Hide()
        chkOptionalDataPlan.Checked = False
        lblOptionalDataPlan.Hide()
        lblWarningScale.Hide()
        lblPhonePlan.Hide()
        sngMonthlyFee = 0
        sngOptionalFee = 0
        CalculateMonthlyFee()
    End Sub
End Class
