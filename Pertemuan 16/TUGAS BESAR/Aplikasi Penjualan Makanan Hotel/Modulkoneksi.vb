Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public cmd As MySqlCommand
    Public ds As DataSet


    Public Sub koneksi()
        Try
            Dim sqlconn As String
            sqlconn = "server=localhost; uid=root; pwd=; database=dbapi"
            conn = New MySqlConnection(sqlconn)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
