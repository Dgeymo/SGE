Public Class NUEVOTRABAJO

    Dim CampoCalle(5) As String
    Dim ExpreCalle(5) As String
    Dim FiltrCalle(5) As String
    Dim Valor_indice_calle As String = ""
    Dim VISTACALLE As DataView
    Dim NewTRABAJORow As ORDENESDataSet.TRABAJOSRow
    Private Sub NUEVO_TRABAJO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.INDICE_CALLESTableAdapter.Fill(Me.INDICESDataSet.INDICE_CALLES)

        Select Case TIPOACCION

            Case "NUEVO"
                If DATOS.DATOS_GESTIONRow("TIPOGESTION") = "RELEVAMIENTO PRE GESTION" Then
                    TRAB_DESCRIPCION.Text = DATOS.DATOS_GESTIONRow("DESCRIPCION")

                    TRAB_NODO.ReadOnly = False
                Else
                    TRAB_ZONA.Text = DATOS.GEST_ZONA.Text
                    TRAB_NODO.ReadOnly = True
                End If
                Select Case INGRESO_AREA
                    Case "FUENTES"
                        TRAB_TIPO.Text = FUENTE_TRABAJO
                        TRAB_INIESTIMADO.Value = Now.ToShortDateString
                        TRAB_DESCRIPCION.Text = ""
                        TRAB_TIEMPOESTIMADO.Text = 1
                        TRAB_NODO.Text = FUENTE_NODO
                        TRAB_ZONA.Text = FUENTE_ZONA
                        TRAB_MANZANA.Text = ""
                        TRAB_CALLE.Text = FUENTE_CALLE
                        TRAB_NRO.Text = FUENTE_NRO
                        CB_TRAB_ATRIBUTO.Text = "HFC"
                        TRAB_INSTALACION.Text = FUENTE_ID
                        TRAB_INSTALACIONRUS.Text = FUENTE_INSTALACIONRUS
                        DEPEND.Text = ""
                        TIPO_DEP.Text = ""
                    Case Else
                        TRAB_TIPO.Text = DATOS.VARTRAB_TIPO
                        If Format(Today, "yyyyMMdd") > Format(DATOS.VARTRAB_INIEST, "yyyyMMdd") Then
                            TRAB_INIESTIMADO.Value = Today.ToShortDateString
                        Else
                            TRAB_INIESTIMADO.Value = DATOS.VARTRAB_INIEST
                        End If
                        TRAB_TIEMPOESTIMADO.Text = ""
                        TRAB_NODO.Text = DATOS.VARGEST_NODO
                        TRAB_ZONA.Text = DATOS.VARGEST_ZONA
                        TRAB_MANZANA.Text = DATOS.VARGEST_SSM
                        TRAB_CALLE.Text = DATOS.VARGEST_CALLE
                        TRAB_NRO.Text = DATOS.VARGEST_PUERTA
                        TRAB_INSTALACION.Text = ""
                        TRAB_INSTALACIONRUS.Text = ""
                        DEPEND.Text = DATOS.VARTRAB_DEP
                        TIPO_DEP.Text = DATOS.VARTRAB_TIPODEP
                        TRAB_DESCRIPCION.Text = DATOS.VARGEST_DESCRIPCION
                End Select
                CB_TRAB_ATRIBUTO.Text = DATOS.VARGEST_ATRIBUTO
            Case "EDITAR"
                TRAB_TIPO.Text = DATOS.DATOS_TRABAJORow("TIPOTRABAJO")
                If IsDBNull(DATOS.DATOS_TRABAJORow("NODO")) = False Then TRAB_NODO.Text = DATOS.DATOS_TRABAJORow("NODO")
                If IsDBNull(DATOS.DATOS_TRABAJORow("ZONA")) = False Then TRAB_ZONA.Text = DATOS.DATOS_TRABAJORow("ZONA")
                If IsDBNull(DATOS.DATOS_TRABAJORow("CALLE")) = False Then TRAB_CALLE.Text = DATOS.DATOS_TRABAJORow("CALLE")
                If IsDBNull(DATOS.DATOS_TRABAJORow("MANZANA")) = False Then TRAB_MANZANA.Text = DATOS.DATOS_TRABAJORow("MANZANA")
                If IsDBNull(DATOS.DATOS_TRABAJORow("NRO")) = False Then TRAB_NRO.Text = DATOS.DATOS_TRABAJORow("NRO")
                TRAB_INIESTIMADO.Text = DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")
                TRAB_TIEMPOESTIMADO.Text = DATOS.DATOS_TRABAJORow("TIEMPOESTIMADO")
                If IsDBNull(DATOS.DATOS_TRABAJORow("DEPENDENCIA")) = False Then DEPEND.Text = DATOS.DATOS_TRABAJORow("DEPENDENCIA")
                If IsDBNull(DATOS.DATOS_TRABAJORow("TIPODEP")) = False Then TIPO_DEP.Text = DATOS.DATOS_TRABAJORow("TIPODEP")
                If IsDBNull(DATOS.DATOS_TRABAJORow("DESCRIPCION")) = False Then TRAB_DESCRIPCION.Text = DATOS.DATOS_TRABAJORow("DESCRIPCION")
                If DATOS.DATOS_TRABAJORow.IsPROYECTO_ORDINALESNull = False Then TXT_PROYECTO.Text = DATOS.DATOS_TRABAJORow.PROYECTO_ORDINALES Else TXT_PROYECTO.Text = 0
                If IsDBNull(DATOS.DATOS_TRABAJORow("INSTALACION")) = False Then
                    TRAB_INSTALACION.Text = DATOS.DATOS_TRABAJORow("INSTALACION")
                Else
                    TRAB_INSTALACION.Text = ""
                End If

                If IsDBNull(DATOS.DATOS_TRABAJORow("INSTALACIONRUS")) = False Then
                    TRAB_INSTALACIONRUS.Text = DATOS.DATOS_TRABAJORow("INSTALACIONRUS")
                Else
                    TRAB_INSTALACIONRUS.Text = ""
                End If

                If INGRESO_AREA = "RED" Then
                    TRAB_ZONA.ReadOnly = False
                Else
                    TRAB_ZONA.ReadOnly = True
                    If DATOS.DATOS_TRABAJORow.TIPOTRABAJO = "ASOCIADO A RED" Then TRAB_ZONA.ReadOnly = False
                End If
                    CB_TRAB_ATRIBUTO.Text = DATOS.VARTRAB_ATRIBUTO
        End Select
    End Sub
    Private Sub BOT_CANCELARTRABAJO_Click(sender As Object, e As EventArgs) Handles BOT_CANCELARTRABAJO.Click
        DATOS.Enabled = True
        Me.Close()
    End Sub
    Private Sub BOT_GUARDARTRABAJO_Click(sender As Object, e As EventArgs) Handles BOT_GUARDARTRABAJO.Click
        Cursor = Cursors.WaitCursor
        If TRAB_ZONA.Text = "" Then
            MsgBox("El ingreso de una ZONA es obligatoria para la definicion de TRABAJO")
            Exit Sub
        Else
            If TRAB_NODO.Text = "" Then
                MsgBox("El ingreso de una NODO es obligatorio para la definicion de TRABAJO")
                Exit Sub
            End If
        End If
        If TRAB_TIEMPOESTIMADO.Text = "" Then
            MsgBox("Debe ingresar un TIEMPO ESTIMADO para la ejecucion del TRABAJO que se pretende ingresar", vbInformation)
            TRAB_TIEMPOESTIMADO.Focus()
            Exit Sub
        End If
        Select Case TIPOACCION
            Case "NUEVO"

                'ACTUALIZA EL ESTADO DE DEPENDENCIA DEL TRABAJO SELECCIONADO
                NewTRABAJORow = DATOS.ORDENESDataSet.TRABAJOS.NewTRABAJOSRow
                NewTRABAJORow("ID_GESTION") = DATOS.DATOS_GESTIONRow("Id_GESTION")
                NewTRABAJORow("TIPOTRABAJO") = TRAB_TIPO.Text
                NewTRABAJORow("FECHAINICESTIMADO") = TRAB_INIESTIMADO.Value.ToShortDateString
                NewTRABAJORow("TIEMPOESTIMADO") = TRAB_TIEMPOESTIMADO.Text
                NewTRABAJORow("DESCRIPCION") = TRAB_DESCRIPCION.Text
                NewTRABAJORow("NODO") = TRAB_NODO.Text
                NewTRABAJORow("ZONA") = TRAB_ZONA.Text
                NewTRABAJORow("MANZANA") = TRAB_MANZANA.Text
                NewTRABAJORow("ATRIBUTO") = CB_TRAB_ATRIBUTO.Text
                If Valor_indice_calle = "" Then
                    If TRAB_CALLE.Text = "" Then
                        'acepta que no tiene calle
                    Else
                        INDICE_CALLESTableAdapter.FillByNomCalle(INDICESDataSet.INDICE_CALLES, Trim(TRAB_CALLE.Text))
                        If INDICESDataSet.INDICE_CALLES.Rows.Count = 1 Then
                            'acepta que tiene la calle correcta

                        Else
                            MsgBox("La calle no esta correctamente escrita" & vbNewLine & "Haga Click en el campo CALLE y seleccione la buscada")
                            Exit Sub
                        End If
                    End If
                End If
                NewTRABAJORow("CALLE") = TRAB_CALLE.Text
                NewTRABAJORow("NRO") = TRAB_NRO.Text
                NewTRABAJORow("FECHAINGRESADO") = Now
                NewTRABAJORow("GENERADOX") = FULLNOMBRE
                NewTRABAJORow("ASIGNADOA") = FULLNOMBRE
                NewTRABAJORow("SECTORASIG") = SECTOR
                NewTRABAJORow("IDASIG") = DATOS.IDASIG
                NewTRABAJORow("INSTALACION") = TRAB_INSTALACION.Text
                NewTRABAJORow("INSTALACIONRUS") = TRAB_INSTALACIONRUS.Text

                Select Case Trim(TRAB_TIPO.Text)
                    Case "ASOCIADO A RED", "OBRA CIVIL"
                        NewTRABAJORow("AREA") = "RED"
                    Case Else
                        NewTRABAJORow("AREA") = DATOS.DATOS_GESTIONRow("AREA")
                End Select
                NewTRABAJORow("STATUS") = "INGRESADO"

                If DEPEND.Text <> "" Then
                    NewTRABAJORow("TIPODEP") = TIPO_DEP.Text
                    NewTRABAJORow("DEPENDENCIA") = DEPEND.Text
                Else
                    NewTRABAJORow("TIPODEP") = ""
                    NewTRABAJORow("DEPENDENCIA") = 0
                End If
                If IsNumeric(Trim(TXT_PROYECTO.Text)) Then
                    NewTRABAJORow.PROYECTO_ORDINALES = TXT_PROYECTO.Text
                Else
                    MsgBox("DEBE INGRESAR UN NUMERO PARA EL PROYECTO QUE NO CONTENGAN LETRAS")
                    Exit Sub
                    Cursor = Cursors.Default
                End If
                DATOS.ORDENESDataSet.TRABAJOS.AddTRABAJOSRow(NewTRABAJORow)
                DATOS.TRABAJOSTableAdapter.Update(NewTRABAJORow)

                'RECARGA LA BASE DE DATOS Y SE MUEVE AL ULTIMO REGISTRO
                If INGRESO_AREA = "FUENTES" Then
                    DATOS.TRABAJOSTableAdapter.FillByTRAB_FUENTE(DATOS.ORDENESDataSet.TRABAJOS, DATOS.DATOS_GESTIONRow("ID_GESTION"), FUENTE_TRABAJO)
                Else
                    DATOS.TRABAJOSTableAdapter.FillByIDGESTION_RELEV(DATOS.ORDENESDataSet.TRABAJOS, DATOS.DATOS_GESTIONRow("Id_GESTION"))
                End If
                DATOS.TRABAJOSBindingSource.MoveLast()
                DATOS.DATOS_TRABAJORow = DATOS.ORDENESDataSet.TRABAJOS.Rows(DATOS.TRABAJOSBindingSource.Position)
                If Trim(UCase(DATOS.GEST_NEWTRAB_TOOLS_VAR)) = "RELEVAMIENTO" Then
                    DATOS.DATOS_TRABAJORow = DATOS.ORDENESDataSet.TRABAJOS.Rows(DATOS.TRABAJOSBindingSource.Position)
                    DATOS.GENERA_RELEVAMIENTO()
                End If
                'CARGA HISTORICO

                DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADO"
                DATOS.DATOS_HIS_CAUSA = "GENERACION NUEVO TRABAJO"
                DATOS.DATOS_HIS_DETALLE = "INICIO ESTIMADO : " & TRAB_INIESTIMADO.Value.ToShortDateString

                DATOS.DATOS_NewHISTORICORow = DATOS.ORDENESDataSet.HISTORICO.NewHISTORICORow

                DATOS.DATOS_NewHISTORICORow("ID_GESTION") = DATOS.DATOS_GESTIONRow("Id_GESTION")
                DATOS.DATOS_NewHISTORICORow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                DATOS.DATOS_NewHISTORICORow("ID_ORDENINT") = 0
                DATOS.DATOS_NewHISTORICORow("FECHA") = Now
                DATOS.DATOS_NewHISTORICORow("STATUSANTERIOR") = "---------"
                DATOS.DATOS_NewHISTORICORow("STATUSACTUAL") = DATOS.DATOS_HIS_STATUSACTUAL
                DATOS.DATOS_NewHISTORICORow("CAUSA") = DATOS.DATOS_HIS_CAUSA
                DATOS.DATOS_NewHISTORICORow("DETALLE") = DATOS.DATOS_HIS_DETALLE
                DATOS.DATOS_NewHISTORICORow("EJECUTANTE") = NOMBRE & " " & APELLIDO

                DATOS.ORDENESDataSet.HISTORICO.AddHISTORICORow(DATOS.DATOS_NewHISTORICORow)
                DATOS.HISTORICOTableAdapter.Update(DATOS.DATOS_NewHISTORICORow)

                'ENVIA MENSAJE 
                DATOS.DATOS_MJE_ASUNTO = "NUEVO TRABAJO"
                DATOS.DATOS_MJE_DESTINONOMBRE = ""
                DATOS.DATOS_MJE_DESTINOSECTOR = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("SECTORASIG")
                DATOS.DATOS_MJE_MENSAJE = "SE HA CREADO UN TRABAJO DE " & TRAB_TIPO.Text & " CON EL SIGUIENTE DETALLE: " & TRAB_DESCRIPCION.Text & " CORRESPONDIENTE A LA GESTION DE " _
                       & DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("TIPOGESTION") & " - " & DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("DESCRIPCION") & "- "
                DATOS.DATOS_MJE_NROORDENASOC = 0
                DATOS.ENVIA_MENSAJE()

            Case "EDITAR"

                'TRABAJOSRow = ORDENESDataSet.TRABAJOS(TRABAJOSBindingSource.Position)
                If Valor_indice_calle = "" Then
                    If TRAB_CALLE.Text = "" Then
                        'acepta que no tiene calle
                    Else
                        INDICE_CALLESTableAdapter.FillByNomCalle(INDICESDataSet.INDICE_CALLES, Trim(TRAB_CALLE.Text))
                        If INDICESDataSet.INDICE_CALLES.Rows.Count = 1 Then
                            'acepta que tiene la calle correcta
                        Else
                            MsgBox("La calle no esta correctamente escrita" & vbNewLine & "Haga Click en el campo CALLE y seleccione la buscada")
                            Exit Sub
                        End If
                    End If
                End If
                DATOS.DATOS_TRABAJORow("TIPOTRABAJO") = TRAB_TIPO.Text
                DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO") = TRAB_INIESTIMADO.Value.ToShortDateString
                DATOS.DATOS_TRABAJORow("TIEMPOESTIMADO") = TRAB_TIEMPOESTIMADO.Text
                DATOS.DATOS_TRABAJORow("DESCRIPCION") = TRAB_DESCRIPCION.Text
                DATOS.DATOS_TRABAJORow("ZONA") = TRAB_ZONA.Text
                DATOS.DATOS_TRABAJORow("MANZANA") = TRAB_MANZANA.Text
                DATOS.DATOS_TRABAJORow("CALLE") = TRAB_CALLE.Text
                DATOS.DATOS_TRABAJORow("NRO") = TRAB_NRO.Text

                DATOS.DATOS_TRABAJORow("INSTALACION") = TRAB_INSTALACION.Text
                DATOS.DATOS_TRABAJORow("INSTALACIONRUS") = TRAB_INSTALACIONRUS.Text
                DATOS.DATOS_TRABAJORow("ATRIBUTO") = CB_TRAB_ATRIBUTO.Text
                If IsNumeric(Trim(TXT_PROYECTO.Text)) Then
                    DATOS.DATOS_TRABAJORow.PROYECTO_ORDINALES = TXT_PROYECTO.Text
                Else
                    MsgBox("DEBE INGRESAR UN NUMERO PARA EL PROYECTO QUE NO CONTENGAN LETRAS")
                    Exit Sub
                    Cursor = Cursors.Default
                End If

                DATOS.TRABAJOSTableAdapter.Update(DATOS.DATOS_TRABAJORow)
                DATOS.TRABAJOSDataGridView.Refresh()

                DATOS.ETI_TRABDESCRIPCION.Text = TRAB_DESCRIPCION.Text
                DATOS.ETI_TRABDESCRIPCION.Refresh()
                'CARGA HISTORICO

                DATOS.DATOS_HIS_STATUSACTUAL = DATOS.DATOS_TRABAJORow("STATUS")
                DATOS.DATOS_HIS_CAUSA = "EDICION DATOS DE TRABAJO"
                DATOS.DATOS_HIS_DETALLE = "INICIO ESTIMADO " & TRAB_INIESTIMADO.Value.ToShortDateString & " - DURACION " & TRAB_TIEMPOESTIMADO.Text & " Dias"

                DATOS.DATOS_NewHISTORICORow = DATOS.ORDENESDataSet.HISTORICO.NewHISTORICORow

                DATOS.DATOS_NewHISTORICORow("ID_GESTION") = DATOS.DATOS_GESTIONRow("Id_GESTION")
                DATOS.DATOS_NewHISTORICORow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                DATOS.DATOS_NewHISTORICORow("ID_ORDENINT") = 0
                DATOS.DATOS_NewHISTORICORow("FECHA") = Now
                DATOS.DATOS_NewHISTORICORow("STATUSANTERIOR") = DATOS.DATOS_TRABAJORow("STATUS")
                DATOS.DATOS_NewHISTORICORow("STATUSACTUAL") = DATOS.DATOS_HIS_STATUSACTUAL
                DATOS.DATOS_NewHISTORICORow("CAUSA") = DATOS.DATOS_HIS_CAUSA
                DATOS.DATOS_NewHISTORICORow("DETALLE") = DATOS.DATOS_HIS_DETALLE
                DATOS.DATOS_NewHISTORICORow("EJECUTANTE") = FULLNOMBRE

                DATOS.ORDENESDataSet.HISTORICO.AddHISTORICORow(DATOS.DATOS_NewHISTORICORow)
                DATOS.HISTORICOTableAdapter.Update(DATOS.DATOS_NewHISTORICORow)

        End Select


        Cursor = DefaultCursor
        DATOS.Enabled = True
        Me.Close()
    End Sub
    Private Sub TRAB_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TRAB_CALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
        ' Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = TRAB_CALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        INDICE_CALLESBindingSource.DataSource = VISTACALLE
        INDICE_CALLESDataGridView.Columns(0).Visible = False
    End Sub
    Private Sub TRAB_CALLE_Click(sender As Object, e As EventArgs) Handles TRAB_CALLE.Click
        If INDICE_CALLESDataGridView.Visible = False Then
            INDICE_CALLESDataGridView.Visible = True
            INDICE_CALLESDataGridView.Columns(0).Visible = False
        End If
    End Sub
    Private Sub TRAB_CALLE_KeyDown(sender As Object, e As KeyEventArgs) Handles TRAB_CALLE.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If VISTACALLE.Count = 1 Then
                TRAB_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                Valor_indice_calle = INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                INDICE_CALLESDataGridView.Visible = False
            Else
                TRAB_CALLE.Text = ""
                Valor_indice_calle = ""
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.DoubleClick
        If INDICE_CALLESDataGridView.RowCount > 0 Then
            TRAB_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            Valor_indice_calle = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
End Class