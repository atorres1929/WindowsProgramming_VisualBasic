Public Class frmURL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUrl.Clear()
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUrl.Clear()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.DialogResult = DialogResult.OK
        Me.Hide()
    End Sub
End Class