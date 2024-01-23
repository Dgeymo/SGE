'Imports MySql.Data.MySqlClient
'Imports Newtonsoft.Json
'Module SQL
'    Public conn_USERLOG As New MySqlConnection("Server=10.5.2.185;Port=3306;Database=operaciones;Uid=Admin;Pwd=Equ1t4l;SslMode=None;")
'    Public conn_ANALISISAG As New MySqlConnection("Server=10.5.2.185;Port=3306;Database=analisis_ag;Uid=Admin;Pwd=Equ1t4l;SslMode=None;")
'    Public conn_OPERACIONES As New MySqlConnection("Server=10.5.2.185;Database=operaciones;Uid=Admin;Pwd=Equ1t4l;SslMode=None;")

'    Public JSONstring As String
'    Public DataSet As DataSet
'    Public DataTable As DataTable
'    Public Sub VALIDAR_CONN()
'        If conn_OPERACIONES.State = ConnectionState.Closed Then
'            conn_OPERACIONES.Open()
'        End If
'    End Sub
'    Function FILL_USUARIO_BY_NROFUNCIONARIO(ByVal ID_USAURIO As String)
'        Dim CMD As New MySqlCommand("SELECT * FROM usuarios WHERE NROFUNCIONARIO=" & ID_USAURIO, conn_OPERACIONES)
'        Dim DATO As MySqlDataReader
'        DataTable = New DataTable()
'        VALIDAR_CONN()
'        DATO = CMD.ExecuteReader()
'        DataTable.Load(DATO)
'        JSONstring = String.Empty
'        JSONstring = JsonConvert.SerializeObject(DataTable)
'        DATO.Close()
'        DATO.Dispose()
'        DataTable.Dispose()
'        conn_OPERACIONES.Close()

'        Return JSONstring
'    End Function
'    Function FILL_USUARIO_BY_USUARIO_PASWORD(ByVal USAURIO As String, ByVal PASWORD As String)

'        Dim CMD As New MySqlCommand("SELECT * FROM usuarios WHERE USUARIO='" & USAURIO & "' AND PASWORD='" & PASWORD & "'", conn_OPERACIONES)
'        Dim DATO As MySqlDataReader
'        DataTable = New DataTable()
'        VALIDAR_CONN()
'        DATO = CMD.ExecuteReader()
'        DataTable.Load(DATO)
'        JSONstring = String.Empty
'        JSONstring = JsonConvert.SerializeObject(DataTable)
'        DATO.Close()
'        DATO.Dispose()
'        DataTable.Dispose()
'        conn_OPERACIONES.Close()

'        Return JSONstring
'    End Function
'End Module
