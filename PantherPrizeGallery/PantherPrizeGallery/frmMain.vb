Public Class frmMain

    Private rndVal As New Random
    Private sngWinnings As Single

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim intResponse As Integer
        intResponse = MessageBox.Show("You will forfeit your winnings if you quit now. Do you want to quit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intResponse = DialogResult.No Then 'user does not want to quit
            Exit Sub ' early jump out to end of procedure
        End If
        'end the program
        Application.Exit()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblForfeit.Visible = False
        timSpin.Start() 'start the timer
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timSpin.Stop() 'stop the timer
        If lblResult.Text <> "" Then
            CalculateWinnings()
        End If
    End Sub

    Private Sub CalculateWinnings()
        Dim intSpinVal As Integer
        Dim intPrizeNum As Integer
        Dim sngPrizeVal As Single
        Dim strImage As String
        'grab the last displayed random value and convert to an integer
        intSpinVal = CInt(lblResult.Text)
        Select Case intSpinVal
            Case Is < 100
                intPrizeNum = 1
                sngPrizeVal = 50
                strImage = "prize-1.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Is < 200
                intPrizeNum = 2
                sngPrizeVal = 75
                strImage = "prize-2.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Is < 300
                intPrizeNum = 3
                sngPrizeVal = 60
                strImage = "prize-3.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Else 'user loses
                intPrizeNum = 4
                sngPrizeVal = 0
                strImage = "consolation prize.png"
                picPrize.SizeMode = PictureBoxSizeMode.Zoom
                lblForfeit.Visible = True

        End Select

        lblPrizeVal.Text = FormatCurrency(sngPrizeVal)

        If intSpinVal < 300 Then 'winner
            sngWinnings += sngPrizeVal
        Else
            sngWinnings = 0
        End If
        lblWinnings.Text = FormatCurrency(sngWinnings)
        picPrize.Load("Resources\" + strImage)
    End Sub

    Private Sub timSpin_Tick(sender As Object, e As EventArgs) Handles timSpin.Tick
        lblResult.Text = rndVal.Next(500)
        lblResult.Refresh()
    End Sub

End Class
