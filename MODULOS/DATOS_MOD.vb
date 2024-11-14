Module DATOS_MOD
    Function ObtenerUltimo(BD As String, tabla As String) As Integer
        Dim RESPUESTA = ExecuteQuery(BD, "SELECT TOP 1 ID_TRABAJO FROM " & tabla & " ORDER BY ID_TRABAJO DESC")
        Dim DT As New DataTable()
        DT.Load(RESPUESTA)
        Return DT.Rows(0).Item("ID_TRABAJO")
    End Function


End Module
