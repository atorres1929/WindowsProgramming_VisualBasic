Imports System.Net
Imports System.IO
Public Class frmMain
    Private GetURL As frmURL

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        webDoc.Navigate(tvwFaves.SelectedNode.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tvwFaves.SelectedNode.Remove()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetURL = New frmURL
    End Sub

    Private Sub tsbAddFave_Click(sender As Object, e As EventArgs) Handles tsbAddFave.Click
        'add to the treeview if not already there
        If Not tvwFaves.Nodes.ContainsKey(webDoc.Url.ToString) Then
            tvwFaves.Nodes.Add(webDoc.Url.ToString, webDoc.Url.ToString)
        End If
    End Sub

    Private Sub tsbBuild_Click(sender As Object, e As EventArgs) Handles tsbBuild.Click
        Dim strHTML As String
        'the HTML code
        strHTML = "<HTML><TITLE>Page on load</TITLE>" &
            "<BODY><FONT COLOR = BLUE>This is a <FONT SIZE=5><B>programmatically </B></FONT SIZE>" &
            "made page </FONT></BODY></HTML>"
        webDoc.DocumentText = strHTML
        ' webDoc.Document.Title = "My Page"
        webDoc.Document.OpenNew(False)
        webDoc.Document.Write(strHTML)
    End Sub

    Private Sub tsbGetText_Click(sender As Object, e As EventArgs) Handles tsbGetText.Click
        Dim strReader As StreamReader
        Dim dataStream As Stream
        Dim request As WebRequest
        Dim response As HttpWebResponse
        Dim strResponseText As String
        request = WebRequest.Create("http://stars.cis.fiu.edu/index.php")
        request.Credentials = CredentialCache.DefaultCredentials
        response = CType(request.GetResponse(), HttpWebResponse)
        dataStream = response.GetResponseStream
        strReader = New StreamReader(dataStream)
        strResponseText = strReader.ReadToEnd
        strReader.Close()
        dataStream.Close()
        response.Close()
        MessageBox.Show(strResponseText)
    End Sub

    Private Sub tsbGoPrev_Click(sender As Object, e As EventArgs) Handles tsbGoPrev.Click
        webDoc.GoBack()
    End Sub

    Private Sub tsbGoURL_Click(sender As Object, e As EventArgs) Handles tsbGoURL.Click
        Dim intResult As Integer
        GetURL.txtUrl.Clear()
        intResult = GetURL.ShowDialog
        If intResult = DialogResult.OK Then
            webDoc.Navigate(GetURL.txtUrl.Text)
        End If
    End Sub

    Private Sub tsbNext_Click(sender As Object, e As EventArgs) Handles tsbNext.Click
        webDoc.GoForward()
    End Sub

End Class
