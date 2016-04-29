Imports System.Data
Imports System.Data.OleDb
Module MdlKoneksi
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String

    Public Sub konek()
        lokasidata = "provider=microsoft.jet.oledb.4.0;data source=database.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module