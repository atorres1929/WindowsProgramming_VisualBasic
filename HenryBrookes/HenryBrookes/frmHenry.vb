

Imports System.Data.SqlClient

Public Class frmHenry

    Private myDB As CDB
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strSp As String = ""
        objSQLCommand.Parameters.Clear()
        objSQLCommand.CommandType = CommandType.StoredProcedure
        Select Case cboTables.SelectedItem.ToString
            Case "AUTHOR"
                strSp = "dbo.sp_getTableAuthor"
            Case "BOOK"
                strSp = "dbo.getTableBook"
            Case "BRANCH"

            Case "INVENTORY"
            Case "PUBLISHER"
                strSp = "dbo.getPublisherList"
            Case "WROTE"
            Case Else
                MessageBox.Show("Loading Data Error", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select
        sqlDA = myDB.GetDataAdapterBySP(strSp, Nothing)
        dt = New DataTable
        sqlDA.Fill(dt)
        dgrInventory.DataSource = dt
        dgrInventory.AutoGenerateColumns = True
    End Sub

    Private Sub frmHenry_Load(sender As Object, e As EventArgs) Handles Me.Load
        myDB = New CDB
        If Not myDB.OpenDB() Then
            Application.Exit()
        End If
        LoadTableNames(cboTables)
        LoadSearchChoices(cboSearch)
    End Sub

    Private Sub LoadTableNames(cbo As ComboBox)
        cbo.Items.Clear()
        objSQLDR = myDB.GetDataReaderBySP("dbo.sp_GetTableList", Nothing)

        While objSQLDR.Read
            cbo.Items.Add(objSQLDR.Item("name"))
        End While

        objSQLDR.Close()
    End Sub

    Private Sub LoadSearchChoices(cbo As ComboBox)
        cbo.Items.Add("Book Title")
        cbo.Items.Add("Author Last Name")
        cbo.Items.Add("Branch Name")
        cbo.Items.Add("Publisher Name")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean
        Dim params As New ArrayList
        If txtVal.Text.Length = 0 Then
            errP.SetError(txtVal, "You must enter search value here")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        Select Case cboSearch.SelectedItem.ToString
            Case "Book Title"
                params.Add(New SqlParameter("@title", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getTitleList", params)
            Case "Author Last Name"
                params.Add(New SqlParameter("@author", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getAuthorList", params)
            Case "Branch Name"

                'sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getAuthorList", params)
            Case "Publisher Name"
                params.Add(New SqlParameter("@publisher", txtVal.Text))
                sqlDA = myDB.GetDataAdapterBySP("dbo.sp_getPublisherList", params)
            Case Else
                MessageBox.Show("Invalid Search Choice", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        dt = New DataTable
        sqlDA.Fill(dt)
        dgrInventory.DataSource = dt
        dgrInventory.AutoGenerateColumns = True

    End Sub
End Class
