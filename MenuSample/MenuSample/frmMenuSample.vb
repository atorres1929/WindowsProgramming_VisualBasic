Imports System.IO
Public Class frmMenuSample
    Private Sub frmMenuSample_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set up the properties for the open and save dialogs
        ofdOpen.DefaultExt = "*.vb"
        ofdOpen.Filter = "VB Forms (*.vb)|(*.vb)|Text Files (*.txt)|(*.txt)|All Files (*.*)|(*.*)"
        ofdOpen.FilterIndex = 1
        ofdOpen.InitialDirectory = Application.StartupPath

        sfdSave.DefaultExt = "*.vb"
        sfdSave.Filter = "VB Forms (*.vb)|(*.vb)|Text Files (*.txt)|(*.txt)|All Files (*.*)|(*.*)"
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
        sslStatus.Text = ofdOpen.FileName & "  opened"
        While Not srdTextFile.EndOfStream
            lstText.Items.Add(srdTextFile.ReadLine)

        End While
    End Sub
End Class
