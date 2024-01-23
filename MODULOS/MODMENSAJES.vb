Module MODMENSAJES
    Public WAIT_ACTIVADO As Boolean
    Public ESPERAR As Boolean
    Dim RESULTADO As Boolean

    Public Async Sub CURSOR_WAIT(ByVal ACTIVO As Boolean, ByVal FORMULARIO As Form)
        If ACTIVO Then
            RESULTADO = True
            If ORDEN.Visible Then
                ORDEN.BringToFront()
                RESULTADO = Await ESPERA()
            Else
                ORDEN.Show(FORMULARIO)
                ORDEN.BringToFront()
                RESULTADO = Await ESPERA()
            End If
        Else
            RESULTADO = Await ESPERA()
        End If

    End Sub
    Public Async Function ESPERA() As Task(Of Boolean)
        Await Task.Delay(600)
        If RESULTADO = False Then
            ORDEN.Close()
        End If
        Return False
    End Function

    Public Sub NOTIFICACION(ByVal USUARIO_NOT As String, ByVal MENSAJE As String)

        If F_NOTIFICACION.Visible Then
            F_NOTIFICACION.Close()
            F_NOTIFICACION.Dispose()
        End If
        F_NOTIFICACION.Show()
        F_NOTIFICACION.LBL_ASUNTO.Text = MENSAJE
        F_NOTIFICACION.LBL_INICIALES.Text = USUARIO_NOT
        F_NOTIFICACION.Refresh()
    End Sub
End Module
