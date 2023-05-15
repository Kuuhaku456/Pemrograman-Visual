Imports MySql.Data.MySqlClient

Module koneksi_database
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String

    Sub connect()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=db_anime"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
