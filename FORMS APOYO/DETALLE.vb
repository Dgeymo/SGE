Public Class DETALLE

    Private Sub DETALLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ORDINALES.Cursor = Cursors.WaitCursor
        Cursor = Cursors.WaitCursor

        Me.OBESERVACIONESTableAdapter.FillByORDENINT(Me.ORDENESDataSet.OBESERVACIONES, ORDINALES.ORD_ORDENINT)
        If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
            OBSERVACIONES.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
        Else
            MsgBox("OOOPS!!!" & vbNewLine & "LA ORDEN QUEDÓ MAL GENERADA, INGRESE A MODIFICAR LA ORDEN PARA CARGAR LAS OBSERVACIONES")
        End If


        Me.TAREASTableAdapter.FillByORDENINT(Me.ORDENESDataSet.TAREAS, ORDINALES.ORD_ORDENINT)

        Label11.Text = ORDINALES.ORD_TIPO
        Label12.Text = ORDINALES.ORD_SECTOR
        Label13.Text = ORDINALES.ORD_FALLAORIG
        Label14.Text = ORDINALES.ORD_CALLEYNRO
        Label15.Text = ORDINALES.ORD_NODO
        Label16.Text = ORDINALES.ORD_ZONA
        Label17.Text = ORDINALES.ORD_MANZ
        Label18.Text = ORDINALES.ORD_PRIORIDAD
        Label19.Text = ORDINALES.ORD_CAUSA
        Label21.Text = ORDINALES.ORD_FECHAAGEND
        Label23.Text = ORDINALES.ORD_SECTOROPE
        Label26.Text = ORDINALES.ORD_INSTALACION
        LBL_AFECTACION.Text = ORDINALES.ORD_AFECTACION
        If ORDINALES.ORD_CREAR = True Then LBL_CREAR.Visible = True Else LBL_CREAR.Visible = False
        If ORDINALES.ORD_COORDINAR = True Then LBL_COORDINAR.Visible = True Else LBL_COORDINAR.Visible = False
        If ORDINALES.ORD_AGENDAR = True Then LBL_AGENDAR.Visible = True Else LBL_AGENDAR.Visible = False
        Cursor = DefaultCursor
        ORDINALES.Cursor = DefaultCursor
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class