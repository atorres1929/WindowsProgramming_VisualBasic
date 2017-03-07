Module modObjects

    Public Sub ClearScreenControls(f As Form)

        Dim strControlType As String
        Dim obj As Control

        For Each obj In f.Controls
            strControlType = TypeName(obj)
            Select Case strControlType
                Case "TextBox"
                    Dim cntrl As TextBox
                    cntrl = DirectCast(obj, TextBox)
                    cntrl.Clear()
                Case "CheckBox"
                    Dim cntrl As CheckBox
                    cntrl = DirectCast(obj, CheckBox)
                    cntrl.Checked = False
                Case "ComboBox"
                    Dim cntrl As ComboBox
                    cntrl = DirectCast(obj, ComboBox)
                    cntrl.SelectedIndex = -1
                Case "ListBox"
                    Dim cntrl As ListBox
                    cntrl = DirectCast(obj, ListBox)
                    cntrl.SelectedIndex = -1
                Case "RadioButton"
                    Dim cntrl As RadioButton
                    cntrl = DirectCast(obj, RadioButton)
                    cntrl.Checked = False
                Case "MaskedTextBox"
                    Dim cntrl As MaskedTextBox
                    cntrl = DirectCast(obj, MaskedTextBox)
                    cntrl.Clear()
                Case Else

            End Select
        Next
    End Sub

    Public Sub UpcaseText(grpBox As GroupBox)
        For Each cntrl In grpBox.Controls
            If TypeOf cntrl Is TextBox Then
                Dim tBox As TextBox = DirectCast(cntrl, TextBox)
                tBox.Text = tBox.Text.ToUpper
            End If
        Next
    End Sub

End Module
