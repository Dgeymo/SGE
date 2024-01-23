Public Class MJE_FINALIZARTRAB

    Private Sub MJE_FINALIZARTRAB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MENSAJE.Text = DATOS.MJE_FINALIZAR
    End Sub

    Private Sub BOT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BOT_CANCELAR.Click
        DATOS.ACCION_FINALIZAR = "CANCELAR"
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DATOS.DATOS_TRABAJORow("STATUS") = "FINALIZADO"
        If IsDBNull(DATOS.DATOS_TRABAJORow("FECHAINICIADO")) = False Then DATOS.DATOS_TRABAJORow("DEMORA") = DateDiff(DateInterval.Day, DATOS.DATOS_TRABAJORow("FECHAINICIADO"), Now)
        DATOS.DATOS_TRABAJORow("FECHAFINALIZADO") = Now
        If DATOS.DATOS_TRABAJORow("REQUERIDO") = True Then
            DATOS.DATOS_TRABAJORow("REQUERIDO") = False
        End If
        DATOS.TRABAJOSTableAdapter.Update(DATOS.DATOS_TRABAJORow)

        DATOS.DATOS_HIS_STATUSACTUAL = "FINALIZADO"
        DATOS.DATOS_HIS_CAUSA = "TRABAJO FINALIZADO"
        DATOS.DATOS_HIS_DETALLE = DETALLE.Text
        TIPOREGISTRO = "TRABAJO"
        DATOS.CARGA_HISTORICO()
        DATOS.GESTIONTableAdapter.GEST_QUITARREQUERIDO(DATOS.DATOS_GESTIONRow("ID_GESTION"))
        Me.Close()
    End Sub


End Class