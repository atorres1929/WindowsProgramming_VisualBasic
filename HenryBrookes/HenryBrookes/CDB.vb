Imports System.Data.SqlClient

Public Class CDB

    Public Function OpenDB() As Boolean

        objSQLCommand = New SqlCommand
        Dim blnResult As Boolean

        If objSQLConnection Is Nothing Then 'we need to instantiate the connection object
            Try
                objSQLConnection = New SqlConnection(gstrConn)
                objSQLConnection.Open()
                blnResult = True
            Catch ex As Exception
                MessageBox.Show("Cannot Open Database: " & ex.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False
                'you should log this error

            End Try
        Else 'check if the connection is open
            If objSQLConnection.State = ConnectionState.Open Then
                blnResult = True
            Else
                blnResult = False
            End If
        End If
        Return blnResult
    End Function

    Public Sub CloseDB()
        Try
            objSQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error when attempting to close Database: " & ex.ToString, "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        Dim sqlCommand As New SqlCommand(strSP, objSQLConnection)
        If Not OpenDB() Then
            'error log this problem if needed
            Return Nothing
        End If

        sqlCommand.CommandType = CommandType.StoredProcedure

        If Not params Is Nothing Then 'add each parameter into the command object
            For Each p As SqlParameter In params
                sqlCommand.Parameters.Add(p)
            Next
        End If

        Try
            Return sqlCommand.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Failed to get datareader: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Nothing

    End Function

    Public Function GetDataAdapterBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        Dim sqlCommand As New SqlCommand(strSP, objSQLConnection)
        Dim sqlDA As SqlDataAdapter
        sqlCommand.CommandType = CommandType.StoredProcedure

        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                sqlCommand.Parameters.Add(p)
            Next
        End If

        Try
            sqlDA = New SqlDataAdapter(sqlCommand)
            Return sqlDA
        Catch ex As Exception
            MessageBox.Show("Failed to get data adapter: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        Dim sqlComm As New SqlCommand(strSP, objSQLConnection)
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    sqlComm.Parameters.Add(p)
                Next
            End If
            Return sqlComm.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Error executing SP: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return -1
    End Function

End Class
