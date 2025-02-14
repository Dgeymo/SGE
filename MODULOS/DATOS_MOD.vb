Module DATOS_MOD
    Function ObtenerUltimo(BD As String, tabla As String) As Integer
        Dim RESPUESTA = ExecuteQuery(BD, "SELECT TOP 1 ID_TRABAJO FROM " & tabla & " ORDER BY ID_TRABAJO DESC")
        Dim DT As New DataTable()
        DT.Load(RESPUESTA)
        Return DT.Rows(0).Item("ID_TRABAJO")
    End Function
    Public EDIFICIO_NODO As String = "SELECT 
        m.CARPETA,
        m.ID_MDU,
        m.ID_STATUS, 
        TRIM(c.NOMBRE_CALLE) AS [CALLE], 
        m.PUERTA, 
        m.APTOS, 
        m.NODO, 
        m.ZONA, 
        m.INGRESO, 
        m.MODIFICADO, 
        m.TORRE, 
        m.PISOS, 
        s.NOMBRE AS [STATUS],  
        m.ACOMETIDA, 
        m.ORDEN 
        FROM ((MDU m
        INNER JOIN CALLES c ON c.ID_CALLE = m.ID_CALLE) 
        INNER JOIN STATUS s ON s.Id_STATUS = m.ID_STATUS)
        WHERE NODO = '"
End Module
