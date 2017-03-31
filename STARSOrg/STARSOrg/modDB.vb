Imports System.Data.SqlClient
Module modDB
    'connection string
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\COP 4005\Samples - Spring 2017\STARSOrg\STARSDB.mdf;Integrated Security=True"
    'Database objects
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand
    Public objSQLDR As SqlDataReader
End Module
