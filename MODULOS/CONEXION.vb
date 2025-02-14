Imports System.Data.OleDb
Module CONEXION
    Dim ConnectEDIFICIO As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\OPERACIONES\BD_FTTHMDU\EDIFICIO.accdb"
    Dim ConnectORDENES As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\OPERACIONES\BD_ORDENES\ORDENES.accdb"
    Dim ConnectFUENTES As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\OPERACIONES\BD_FUENTES\BASEFUENTES.accdb"
    Dim ConnectFUENTESmod As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\OPERACIONES\BD_FUENTES\BD_FUENTES.accdb"
    Public connE As New OleDbConnection(ConnectEDIFICIO)
    Public connO As New OleDbConnection(ConnectORDENES)
    Public connF As New OleDbConnection(ConnectFUENTES)
    Public connFmod As New OleDbConnection(ConnectFUENTESmod)
    Dim CONNECT As OleDbConnection

    Function TipoConexion(ByVal conn As String) As OleDbConnection
        Dim thisConnect As OleDbConnection
        Select Case conn.ToLower
            Case "ordenes"
                thisConnect = connO
                Return thisConnect
            Case "edificio"
                thisConnect = connE
                Return thisConnect
            Case "fuentes"
                thisConnect = connF
                Return thisConnect
            Case "fuentesmod"
                thisConnect = connFmod
                Return thisConnect
        End Select

    End Function
    Function ExecuteQuery(conn As String, query As String) As OleDbDataReader
        Try
            CONNECT = TipoConexion(conn)
            Try
                CONNECT.Open()
            Catch ex As Exception
                CONNECT.Close()
                CONNECT.Open()
            End Try

            Using Comm As OleDbCommand = New OleDbCommand(query, CONNECT)
                Return Comm.ExecuteReader()
            End Using
        Catch ex As OleDbException
            CONNECT.Close()
            Throw New Exception("Error al ejecutar la consulta: " & ex.Message)
        End Try
        CONNECT.Close()
    End Function

    Function ExecuteNonQuery(conn As String, query As String) As Integer
        Try
            CONNECT = TipoConexion(conn)
            Try
                CONNECT.Open()
            Catch ex As Exception
                CONNECT.Close()
                CONNECT.Open()
            End Try
            Using Comm As OleDbCommand = New OleDbCommand(query, TipoConexion(conn))
                Return Comm.ExecuteNonQuery()
            End Using
        Catch ex As OleDbException
            CONNECT.Close()
            Throw New Exception("Error al ejecutar la consulta: " & ex.Message)
        End Try
        CONNECT.Close()
    End Function
End Module
