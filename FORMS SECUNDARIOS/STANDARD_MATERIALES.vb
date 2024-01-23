Public Class STANDARD_MATERIALES
    Dim ARTICULO As INDICESDataSet.MAT_ACTIVOSRow
    Dim CANTIDAD As String
    Private Sub STANDARD_MATERIALES_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.PRESUPUESTO' Puede moverla o quitarla según sea necesario.
        Me.PRESUPUESTOTableAdapter.Fill(Me.ORDENESDataSet.PRESUPUESTO)
        'TODO: esta línea de código carga datos en la tabla 'INDICESDataSet.MAT_STOCK' Puede moverla o quitarla según sea necesario.
        Me.MAT_STOCKTableAdapter.Fill(Me.INDICESDataSet.MAT_STOCK)
        TipoAMP.Items.Clear()
        TipoAMP.Items.Add("NINGUNO")
        MAT_ACTIVOSTableAdapter.FillByTIPO_CONTROL(INDICESDataSet.MAT_ACTIVOS, "AMPLIFICADOR")
        For X = 0 To INDICESDataSet.MAT_ACTIVOS.Rows.Count - 1
            TipoAMP.Items.Add(INDICESDataSet.MAT_ACTIVOS.Rows(X).Item("NOMBRE_ARTICULO"))
        Next
        MAT_ACTIVOSTableAdapter.FillByTIPO_CONTROL(INDICESDataSet.MAT_ACTIVOS, "PASIVO")
        COD_ART_1.Items.Clear()
        COD_ART_2.Items.Clear()
        COD_ART_3.Items.Clear()
        COD_ART_4.Items.Clear()
        COD_ART_5.Items.Clear()
        COD_ART_6.Items.Clear()
        COD_ART_7.Items.Clear()
        COD_ART_8.Items.Clear()
        COD_ART_9.Items.Clear()

        For X = 0 To INDICESDataSet.MAT_ACTIVOS.Rows.Count - 1
            ARTICULO = INDICESDataSet.MAT_ACTIVOS.Rows(X)
            COD_ART_1.Items.Add(ARTICULO.ID_MAT_ARTICULO & " - " & ARTICULO.NOMBRE_ARTICULO)
        Next
    End Sub
    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
        If COD_2.Visible = False Then
            COD_2.Visible = True
            COD_ART_2.Visible = True
            CANT_2.Visible = True
            DISP_2.Visible = True
            BTN_QUITAR.Visible = True
        ElseIf COD_3.Visible = False Then
            COD_3.Visible = True
            COD_ART_3.Visible = True
            CANT_3.Visible = True
            DISP_3.Visible = True
        ElseIf COD_4.Visible = False Then
            COD_4.Visible = True
            COD_ART_4.Visible = True
            CANT_4.Visible = True
            DISP_4.Visible = True
        ElseIf COD_5.Visible = False Then
            COD_5.Visible = True
            COD_ART_5.Visible = True
            CANT_5.Visible = True
            DISP_5.Visible = True
        ElseIf COD_6.Visible = False Then
            COD_6.Visible = True
            COD_ART_6.Visible = True
            CANT_6.Visible = True
            DISP_6.Visible = True
        ElseIf COD_7.Visible = False Then
            COD_7.Visible = True
            COD_ART_7.Visible = True
            CANT_7.Visible = True
            DISP_7.Visible = True
        ElseIf COD_8.Visible = False Then
            COD_8.Visible = True
            COD_ART_8.Visible = True
            CANT_8.Visible = True
            DISP_8.Visible = True
        ElseIf COD_9.Visible = False Then
            COD_9.Visible = True
            COD_ART_9.Visible = True
            CANT_9.Visible = True
            DISP_9.Visible = True
        End If
    End Sub
    Private Sub BTN_QUITAR_Click(sender As Object, e As EventArgs) Handles BTN_QUITAR.Click
        If COD_9.Visible Then
            COD_9.Visible = False
            COD_ART_9.Visible = False
            CANT_9.Visible = False
            DISP_9.Visible = False
            COD_9.Text = ""
            COD_ART_9.Text = ""
            CANT_9.Text = ""
            DISP_9.Text = ""
        ElseIf COD_8.Visible Then
            COD_8.Visible = False
            COD_ART_8.Visible = False
            CANT_8.Visible = False
            DISP_8.Visible = False
            COD_8.Text = ""
            COD_ART_8.Text = ""
            CANT_8.Text = ""
            DISP_8.Text = ""
        ElseIf COD_7.Visible Then
            COD_7.Visible = False
            COD_ART_7.Visible = False
            CANT_7.Visible = False
            DISP_7.Visible = False
            COD_7.Text = ""
            COD_ART_7.Text = ""
            CANT_7.Text = ""
            DISP_7.Text = ""
        ElseIf COD_6.Visible Then
            COD_6.Visible = False
            COD_ART_6.Visible = False
            CANT_6.Visible = False
            DISP_6.Visible = False
            COD_6.Text = ""
            COD_ART_6.Text = ""
            CANT_6.Text = ""
            DISP_6.Text = ""
        ElseIf COD_5.Visible Then
            COD_5.Visible = False
            COD_ART_5.Visible = False
            CANT_5.Visible = False
            DISP_5.Visible = False
            COD_5.Text = ""
            COD_ART_5.Text = ""
            CANT_5.Text = ""
            DISP_5.Text = ""
        ElseIf COD_4.Visible Then
            COD_4.Visible = False
            COD_ART_4.Visible = False
            CANT_4.Visible = False
            DISP_4.Visible = False
            COD_4.Text = ""
            COD_ART_4.Text = ""
            CANT_4.Text = ""
            DISP_4.Text = ""
        ElseIf COD_3.Visible Then
            COD_3.Visible = False
            COD_ART_3.Visible = False
            CANT_3.Visible = False
            DISP_3.Visible = False
            COD_3.Text = ""
            COD_ART_3.Text = ""
            CANT_3.Text = ""
            DISP_3.Text = ""
        ElseIf COD_2.Visible Then
            COD_2.Visible = False
            COD_ART_2.Visible = False
            CANT_2.Visible = False
            BTN_QUITAR.Visible = False
            DISP_2.Visible = False
            COD_2.Text = ""
            COD_ART_2.Text = ""
            CANT_2.Text = ""
            DISP_2.Text = ""
        End If
    End Sub
    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        Me.Close()
    End Sub
    Private Sub COD_ART_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_1.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_1.SelectedItem, "-")(0)))
        COD_1.Text = Trim(Split(COD_ART_1.SelectedItem, "-")(0))
        DISP_1.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_2.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_2.SelectedItem, "-")(0)))
        COD_2.Text = Trim(Split(COD_ART_2.SelectedItem, "-")(0))
        DISP_2.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_3.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_3.SelectedItem, "-")(0)))
        COD_3.Text = Trim(Split(COD_ART_3.SelectedItem, "-")(0))
        DISP_3.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_4.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_4.SelectedItem, "-")(0)))
        COD_4.Text = Trim(Split(COD_ART_4.SelectedItem, "-")(0))
        DISP_4.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_5.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_5.SelectedItem, "-")(0)))
        COD_5.Text = Trim(Split(COD_ART_5.SelectedItem, "-")(0))
        DISP_5.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_6.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_6.SelectedItem, "-")(0)))
        COD_6.Text = Trim(Split(COD_ART_6.SelectedItem, "-")(0))
        DISP_6.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_7.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_7.SelectedItem, "-")(0)))
        COD_7.Text = Trim(Split(COD_ART_7.SelectedItem, "-")(0))
        DISP_7.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_8.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_8.SelectedItem, "-")(0)))
        COD_8.Text = Trim(Split(COD_ART_8.SelectedItem, "-")(0))
        DISP_8.Text = CANTIDAD
    End Sub
    Private Sub COD_ART_9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COD_ART_9.SelectedIndexChanged
        STOCK(Trim(Split(COD_ART_9.SelectedItem, "-")(0)))
        COD_9.Text = Trim(Split(COD_ART_9.SelectedItem, "-")(0))
        DISP_9.Text = CANTIDAD
    End Sub
    Private Sub STOCK(ByVal ARTICULO As String)
        MAT_STOCKTableAdapter.FillByID_ARTICULO(INDICESDataSet.MAT_STOCK, ARTICULO)
        If INDICESDataSet.MAT_STOCK.Rows.Count > 0 Then
            CANTIDAD = INDICESDataSet.MAT_STOCK.Rows(INDICESDataSet.MAT_STOCK.Rows.Count - 1).Item("DISPONIBLE")
        End If
    End Sub
    Private Sub BTN_INGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_INGRESAR.Click
        Dim NEWPRESUPUESTORow As ORDENESDataSet.PRESUPUESTORow
        If COD_1.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_1.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_1.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_1.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_2.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_2.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_2.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_2.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_3.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_3.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_3.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_3.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_4.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_4.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_4.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_4.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_5.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_5.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_5.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_5.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_6.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_6.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_6.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_6.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_7.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_7.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_7.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_7.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_8.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_8.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_8.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_8.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        If COD_9.Visible Then
            NEWPRESUPUESTORow = ORDENESDataSet.PRESUPUESTO.NewPRESUPUESTORow()
            NEWPRESUPUESTORow.ID_GESTION = DATOS.DATOS_GESTIONRow.Id_GESTION
            NEWPRESUPUESTORow.CODIGO_ART = COD_9.Text
            NEWPRESUPUESTORow.ARTICULO = COD_ART_9.Text
            NEWPRESUPUESTORow.CANTIDAD = CANT_9.Text
            ORDENESDataSet.PRESUPUESTO.AddPRESUPUESTORow(NEWPRESUPUESTORow)
        End If
        PRESUPUESTOTableAdapter.Update(ORDENESDataSet.PRESUPUESTO)
    End Sub
End Class