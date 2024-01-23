Public Class ORDEN
    Dim CONTAR As Integer
    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Cursor = Cursors.WaitCursor
        If NRO_ORDEN.Text <> "" Then
            ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, NRO_ORDEN.Text)
        End If
        If ORDINAL.Text <> "" Then
            ORDENESTableAdapter.FillByIDORDINAL(ORDENESDataSet.ORDENES, ORDINAL.Text)
        End If
        If GESTION.Text <> "" Then
            ORDENESTableAdapter.FillByIDGESTION(ORDENESDataSet.ORDENES, GESTION.Text)
        End If
        If TRABAJO.Text <> "" Then
            ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Text)
        End If


        If MOTIVO.Text <> "" And CALLE.Text = "" Then
            ORDENESTableAdapter.FillByMOTIVOORIGEN_LIKE(ORDENESDataSet.ORDENES, MOTIVO.Text)
        End If
        If INSTALACION.Text <> "" Then
            ORDENESTableAdapter.FillByINSTALACION(ORDENESDataSet.ORDENES, INSTALACION.Text)
        End If
        If INSTALACION_RUS.Text <> "" Then
            ORDENESTableAdapter.FillByINSTALACIONRUS(ORDENESDataSet.ORDENES, INSTALACION_RUS.Text)
        End If
        If CALLE.Text <> "" Then
            If MOTIVO.Text <> "" Then
                ORDENESTableAdapter.FillByCALLEyMOTIVO(ORDENESDataSet.ORDENES, CALLE.Text, MOTIVO.Text)
            Else
                ORDENESTableAdapter.FillByCALLE_LIKE(ORDENESDataSet.ORDENES, CALLE.Text)
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTN_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click
        ORDENESTableAdapter.Update(ORDENESDataSet.ORDENES)
    End Sub
End Class