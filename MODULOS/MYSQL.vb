Imports MySql.Data.MySqlClient
Module MYSQL
    Public USUARIODataTable As DataTable
    Public conn As New MySqlConnection("Server=mysql.webcindario.com;Uid=obra;Pwd=Pedernal2075;Database=obra")
    Public Sub VALIDAR_CONN()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub


End Module
