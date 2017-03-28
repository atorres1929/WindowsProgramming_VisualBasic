Imports System.Data.SqlClient

Public Class CRole

    'represents a single record in the role table
    Private _mstrRoleID As String
    Private _mstrRoleDescription As String
    Private _isNewRole As Boolean

    'constructor
    Public Sub New()
        _mstrRoleID = ""
        _mstrRoleDescription = ""
    End Sub

#Region "Properties"
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property

    Public Property RoleDescription As String
        Get
            Return _mstrRoleDescription
        End Get
        Set(strVal As String)
            _mstrRoleDescription = strVal
        End Set
    End Property

    Public Property IsNewRole As Boolean
        Get
            Return _isNewRole
        End Get
        Set(blnval As Boolean)
            _isNewRole = blnval
        End Set
    End Property
#End Region

    Public ReadOnly Property GetSaveParamenters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            params.Add(New SqlParameter("roleDescription", _mstrRoleDescription))
            Return params
        End Get
    End Property

    Public Function Save() As Integer
        'return -1 if the ID  already exists (and we can't create a new record with  duplicate ID)
        If IsNewRole Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckRoleIDExists", params)
            If Not strRes = 0 Then
                Return -1
            End If
        End If
        Return myDB.ExecSP("sp_SaveRole", GetSaveParamenters)
    End Function

End Class
