Imports System.Data.Odbc

Module Module1
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public cmd As OdbcCommand
    Public Str As String
    Public MyDB As String
    Public Conn As New OdbcConnection("DSN=dbdokter")
    Public Sub Koneksi()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
            'MsgBox("Koneksi ke database berhasil")
        End If
    End Sub


End Module
