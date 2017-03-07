Imports System.IO
Public Class frmMenus

    Private Sub frmMenus_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set up the properties for the open and save dialogs
        ' ofdOpen.DefaultExt = "*.vb"
        ofdOpen.Filter = "VB Forms (*.vb)|*.vb|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        ofdOpen.FilterIndex = 1
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.FileName = ""
        sfdSave.DefaultExt = "*.vb"
        sfdSave.Filter = "VB Forms (*.vb)|*.vb|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        sfdSave.FilterIndex = 1
        sfdSave.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim srdTextFile As StreamReader
        'show the open file dialog, then get the results from that dialog
        ofdOpen.ShowDialog()
        If ofdOpen.FileName = "" Then 'user did not select a file
            sslStatus.Text = "File action canceled"
            Exit Sub
        End If
        srdTextFile = File.OpenText(ofdOpen.FileName)
        sslStatus.Text = ofdOpen.FileName & " opened"
        While Not srdTextFile.EndOfStream
            lstText.Items.Add(srdTextFile.ReadLine)
        End While
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim swrTextFile As StreamWriter
        Dim i As Integer
        sfdSave.ShowDialog()
        If sfdSave.FileName = "" Then 'user did not select a filename
            sslStatus.Text = "File action canceled"
            Exit Sub
        End If
        swrTextFile = File.CreateText(sfdSave.FileName)
        For i = 0 To lstText.Items.Count - 1
            swrTextFile.WriteLine(lstText.Items(i).ToString) 'write each listbox item to the output file
        Next
        swrTextFile.Close()
        sslStatus.Text = sfdSave.FileName & " saved"
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        Dim swrTextFile As StreamWriter
        Dim i As Integer
        sfdSave.ShowDialog()
        If sfdSave.FileName = "" Then 'user did not select a filename
            sslStatus.Text = "File action canceled"
            Exit Sub
        End If
        swrTextFile = File.CreateText(sfdSave.FileName)
        sspProgress.Minimum = 0
        sspProgress.Maximum = 100
        sspProgress.Step = CInt(lstText.Items.Count / 100) 'determine the increment size for a single write

        For i = 0 To lstText.Items.Count - 1
            swrTextFile.WriteLine(lstText.Items(i).ToString) 'write each listbox item to the output file
            sspProgress.Increment(sspProgress.Step) 'increment the progress bar display
        Next
        swrTextFile.Close()
        sslStatus.Text = sfdSave.FileName & " saved"
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        Dim intResult As Integer
        intResult = fntChange.ShowDialog
        If intResult <> DialogResult.Cancel Then
            txtInput.Font = fntChange.Font
            sslStatus.Text = "Font changed"
        Else
            sslStatus.Text = "Operation canceled"
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        'we will fake this, because you actually have to set up a document object
        'and load it with text/image before actually printing
        prtPrint.ShowDialog()

    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Clipboard.SetDataObject(txtInput.SelectedText)
        sslStatus.Text = "Copy Action"
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        'determine whether the data in the clipboard is in a format that we can put into a textbox
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then 'it is text
            txtInput.SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text)
            sslStatus.Text = "Paste Action"
        Else 'clipboard data is not in a format we can use in a textbox
            sslStatus.Text = "Could not retrieve data from Clipboard"
        End If
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Clipboard.SetDataObject(txtInput.SelectedText)
        txtInput.SelectedText = ""
        sslStatus.Text = "Cut Action"
    End Sub

    Private Sub mnuFlip_Click(sender As Object, e As EventArgs) Handles mnuFlip.Click
        picImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        picImage.Refresh()
        sslStatus.Text = "Image Flipped"
    End Sub

    Private Sub mnuRotate_Click(sender As Object, e As EventArgs) Handles mnuRotate.Click
        picImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picImage.Refresh()
        sslStatus.Text = "Image Rotated"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim About As New frmAbout
        About.ShowDialog()
    End Sub
End Class
