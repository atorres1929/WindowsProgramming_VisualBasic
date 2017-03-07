Imports System.Data.SqlClient

Module modDB
    'connection string
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Google Drive\Programming Projects\Visual Basic\HenryBrookes\HBooks.mdf;Integrated Security=True"
    'Database objects
    Public objSQLConnection As SqlConnection
    Public objSQLCommand As SqlCommand
    Public objSQLDR As SqlDataReader


End Module
