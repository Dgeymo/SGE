Public Class TORRES
    Private Sub TORRES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_ACOMETIDA.Text = DETALLE_MDU.ACT_MDURow.ACOMETIDA
        TXT_UBICACION_NAP.Text = DETALLE_MDU.FTTB_Row.OBS_TEC
        CB_TORRES.Text = DETALLE_MDU.ACT_MDURow.TORRE
    End Sub

    Private Sub BTN_CONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTN_CONFIRMAR.Click
        MsgBox("AUN NO HAGO NADA, SABEEE")
    End Sub
End Class