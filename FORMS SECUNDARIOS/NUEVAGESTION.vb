Public Class NUEVAGESTION

    Dim CampoCalle(5) As String
    Dim ExpreCalle(5) As String
    Dim FiltrCalle(5) As String
    Dim Valor_indice_calle As String = ""
    Dim VISTACALLE As DataView
    Dim NewGESTIONRow As ORDENESDataSet.GESTIONRow
    Dim NewTRABAJORow As ORDENESDataSet.TRABAJOSRow

    Dim NEWGEST_MJE_DESTINO_NOMBRE As String
    Dim NEWGEST_MJE_DESTINO_SECTOR As String
    Dim NEWGEST_MJE_ASUNTO As String
    Dim NEWGEST_MJE_DESTINO As String
    Dim NEWGEST_MJE_TIPO_ORDENASOC As String
    Dim NEWGEST_MJE_NRO_ORDENASOC As String
    Dim NEWGEST_MJE_TIPOMENSAJE As String
    Dim NEWGEST_MJE_MENSAJE As String

    Dim TIPO_TRABAJO As String
    Dim FECHA_INIEST As Date
    Dim TIEM_EST As Integer
    Dim DEPENDENCIA As Integer
    Dim ORD_DEPENDENCIA As Integer
    Dim FECHAFIN As Date
    Private Sub NUEVA_GESTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        'MODIFICA LA PANTALLA DE ACUERDO AL AREA SELECCIONADA
        GEST_TIPO.Items.Clear()
        Select Case INGRESO_AREA
            Case "MDU"
                GESTIONES_TIPOTableAdapter.FillByAREA(ORDENESDataSet.GESTIONES_TIPO, INGRESO_AREA)
                GEST_TIPO.Enabled = True
                GEST_TIPO.Text = ""
                For x = 0 To ORDENESDataSet.GESTIONES_TIPO.Rows.Count - 1
                    GEST_TIPO.Items.Add(ORDENESDataSet.GESTIONES_TIPO.Rows(x).Item("TIPO_GESTION"))
                Next
                GEST_NODO.Visible = True
                TXTCALLE.ReadOnly = True
                TXTPUERTA.ReadOnly = True
                TXTZONA.ReadOnly = True
            Case "RED"
                If DATOS.BUSCA_NODO.Text = "" Then
                    GESTIONES_TIPOTableAdapter.FillByAREA(ORDENESDataSet.GESTIONES_TIPO, "PREGESTION")
                    GEST_TIPO.Text = ORDENESDataSet.GESTIONES_TIPO.Rows(0).Item("TIPO_GESTION")
                    For x = 0 To ORDENESDataSet.GESTIONES_TIPO.Rows.Count - 1
                        GEST_TIPO.Items.Add(ORDENESDataSet.GESTIONES_TIPO.Rows(x).Item("TIPO_GESTION"))
                    Next
                    GEST_NODO.Text = DATOS.BUSCA_NODO.Text
                    GEST_TIPO.Enabled = False
                Else
                    GESTIONES_TIPOTableAdapter.FillByAREA(ORDENESDataSet.GESTIONES_TIPO, INGRESO_AREA)
                    GEST_TIPO.Enabled = True
                    GEST_TIPO.Text = ""
                    For x = 0 To ORDENESDataSet.GESTIONES_TIPO.Rows.Count - 1
                        GEST_TIPO.Items.Add(ORDENESDataSet.GESTIONES_TIPO.Rows(x).Item("TIPO_GESTION"))
                    Next

                    'GEST_TIPO.Items.Add("MANT DISTRIBUCION")
                    'GEST_TIPO.Items.Add("MANT TRONCALES")
                    'GEST_TIPO.Items.Add("MANT FIBRA")
                    'GEST_TIPO.Items.Add("MANT FUENTES")
                    'GEST_TIPO.Items.Add("MODIF DE RED")
                    'GEST_TIPO.Items.Add("CONST DE RED")
                    'GEST_TIPO.Items.Add("CONST DE FIBRA")
                    'GEST_TIPO.Items.Add("MANT SOPORTES DE RED")
                    'GEST_TIPO.Items.Add("PREVENTIVO PUNTUAL")
                    'GEST_TIPO.Items.Add("MANTENIMIENTO PROGRAMADO DE FUENTES")
                    'GEST_TIPO.Items.Add("MANTENIMIENTO PREVENTIVO DE FUENTES")
                    'GEST_TIPO.Items.Add("INSTALACION / RETIRO DE FUENTE X OBRA")
                    'GEST_TIPO.Items.Add("TRABAJOS DE LABORATORIO")
                End If
            Case "FUENTES"
                GEST_TIPO.Text = FUENTE_GESTION
        End Select
        Select Case TIPOACCION
            Case "NUEVO"
                GEST_NODO.ReadOnly = True
                DATOS.ORDENESDataSet.GESTION.Clear()
                DATOS.ORDENESDataSet.TRABAJOS.Clear()
                DATOS.ORDENESDataSet.ORDENES.Clear()
                GEST_NODO.Text = DATOS.BUSCA_NODO.Text
                GEST_INIEST.Value = Now
                GEST_CONTACTO.Text = ""
                GEST_DESCRIPCION2.Text = ""
                GEST_MAILCONTAC.Text = ""
                GEST_SOLICITANTE.Text = ""
                GEST_TELEFCONTAC.Text = ""
                GEST_TESTIMADO.Text = ""
                Select Case INGRESO_AREA
                    Case "MDU"
                        GEST_NODO.Text = NODO_MDU
                        TXTCALLE.Text = Trim(DIRECCION_MDU)
                        TXTPUERTA.Text = NUMERO_MDU
                        TXTZONA.Text = ZONA_MDU
                        For CALLES = 0 To INDICESDataSet.INDICE_CALLES.Rows.Count - 1
                            If Trim(DIRECCION_MDU) = Trim(INDICESDataSet.INDICE_CALLES.Rows(CALLES).Item("NOMBRE_CALLE")) Then
                                LBL_ID_CALLE.Text = INDICESDataSet.INDICE_CALLES.Rows(CALLES).Item("ID_CALLE")
                                Exit For
                            End If
                        Next
                End Select
            Case "EDITAR"
                If GEST_TIPO.Text = "RELEVAMIENTO PRE GESTION" Then
                    GESTIONES_TIPOTableAdapter.FillByAREA(ORDENESDataSet.GESTIONES_TIPO, INGRESO_AREA)
                    GEST_TIPO.Enabled = True
                    For x = 0 To ORDENESDataSet.GESTIONES_TIPO.Rows.Count - 1
                        GEST_TIPO.Items.Add(ORDENESDataSet.GESTIONES_TIPO.Rows(x).Item("TIPO_GESTION"))
                    Next
                End If
                GEST_TIPO.Enabled = True
                GEST_INIEST.Enabled = True
                GEST_CONTACTO.ReadOnly = False
                GEST_DESCRIPCION2.ReadOnly = False
                GEST_MAILCONTAC.ReadOnly = False

                GEST_TELEFCONTAC.ReadOnly = False
                GEST_TESTIMADO.ReadOnly = False
                If DATOS.VARGEST_ATRIBUTO = "" Then CB_GEST_ATRIBUTO.Text = "HFC" Else CB_GEST_ATRIBUTO.Text = DATOS.VARGEST_ATRIBUTO
                GEST_TIPO.Text = DATOS.VARGEST_TIPO
                GEST_DESCRIPCION2.Text = DATOS.VARGEST_DESCRIPCION
                GEST_SOLICITANTE.Text = DATOS.VARGEST_SOLICITANTE
                GEST_CONTACTO.Text = DATOS.VARGEST_CONTACTO
                GEST_TELEFCONTAC.Text = DATOS.VARGEST_TELEFONO
                GEST_MAILCONTAC.Text = DATOS.VARGEST_MAIL
                GEST_NODO.Text = DATOS.VARGEST_NODO
                ID_GEST_ORD.Text = DATOS.VARGEST_ID_GEST_ORD
                If DATOS.DATOS_GESTIONRow.IsID_CALLE_GESTNull = False Then LBL_ID_CALLE.Text = DATOS.DATOS_GESTIONRow.ID_CALLE_GEST
                TXTCALLE.Text = DATOS.VARGEST_CALLE
                TXTPUERTA.Text = DATOS.VARGEST_PUERTA
                TXTZONA.Text = DATOS.VARGEST_ZONA
                If DATOS.VARGEST_SSM <> "" Then
                    Dim SSM As Array = Split(DATOS.VARGEST_SSM, "/")
                    TXTSECCION.Text = SSM(0)
                    TXTSEGMENTO.Text = SSM(1)
                    TXTMANZANA.Text = SSM(2)
                End If
                If DATOS.VARGEST_INIEST <> "" Then
                    GEST_INIEST.Value = DateValue(DATOS.VARGEST_INIEST)
                Else
                    GEST_INIEST.Value = DateValue(Now)
                End If
                GEST_TESTIMADO.Text = DATOS.VARGEST_TESTIM
                BOT_GUARDARGEST.Enabled = True
                BOT_GUARDARGEST.Text = "GUARDAR"
        End Select
    End Sub
    Private Sub BOT_GUARDARGEST_Click(sender As Object, e As EventArgs) Handles BOT_GUARDARGEST.Click
        Me.Cursor = Cursors.WaitCursor
        If GEST_TIPO.Text = "" Then
            MsgBox("Complete el TIPO de gestion")
            GEST_TIPO.Focus()
            Exit Sub
        End If
        If GEST_SOLICITANTE.Text = "" Then
            MsgBox("Complete SOLICITANTE de gestion")
            GEST_SOLICITANTE.Focus()
            Exit Sub
        End If
        If GEST_TESTIMADO.Text = "" Then
            If GEST_TIPO.Text <> "RELEVAMIENTO PRE GESTION" Then
                MsgBox("Complete el tiempo estimado de la gestion")
                GEST_TESTIMADO.Focus()
                Exit Sub
            End If
        End If

        Select Case TIPOACCION
                Case "NUEVO"
                NewGESTIONRow = DATOS.ORDENESDataSet.GESTION.NewGESTIONRow
                NewGESTIONRow("TIPOGESTION") = GEST_TIPO.Text
                NewGESTIONRow("DESCRIPCION") = GEST_DESCRIPCION2.Text
                NewGESTIONRow("SOLICITANTE") = GEST_SOLICITANTE.Text
                NewGESTIONRow("NOMBRECONTACTO") = GEST_CONTACTO.Text
                NewGESTIONRow("TELEFCONTACTO") = GEST_TELEFCONTAC.Text
                NewGESTIONRow("MAILCONTACTO") = GEST_MAILCONTAC.Text
                NewGESTIONRow("GENERADOX") = FULLNOMBRE
                NewGESTIONRow("NODO") = GEST_NODO.Text
                NewGESTIONRow("ZONA") = TXTZONA.Text
                If TXTSECCION.Text <> "" And TXTSEGMENTO.Text <> "" And TXTMANZANA.Text <> "" Then NewGESTIONRow("MANZANA") = TXTSECCION.Text & "/" & TXTSEGMENTO.Text & "/" & TXTMANZANA.Text
                NewGESTIONRow("ATRIBUTO") = CB_GEST_ATRIBUTO.Text
                NewGESTIONRow("ID_GESTION_ORDINALES") = ID_GEST_ORD.Text

                'If GEST_TIPO.Text = "RELEVAMIENTO PRE GESTION" Then
                '    NewGESTIONRow("ASIGNADOA") = ""
                '    NewGESTIONRow("IDASIG") = 0
                '    NewGESTIONRow("SECTORASIG") = "PLANIFICACION TECNICA"

                '    DATOS.DATOS_MJE_ASUNTO = "Creacion de PREGESTION"
                '    DATOS.DATOS_MJE_DESTINONOMBRE = ""
                '    DATOS.DATOS_MJE_DESTINOSECTOR = "PLANIFICACION TECNICA"
                '    DATOS.DATOS_MJE_MENSAJE = "SE CREÓ UNA NUEVA PREGESTION"
                '    DATOS.ENVIA_MENSAJE()
                'Else
                NewGESTIONRow("ASIGNADOA") = FULLNOMBRE
                NewGESTIONRow("IDASIG") = ID
                NewGESTIONRow("SECTORASIG") = SECTOR
                'End If

                If LBL_ID_CALLE.Text = "" Then
                    '    'acepta que no tiene calle
                Else
                    NewGESTIONRow("ID_CALLE_GEST") = LBL_ID_CALLE.Text
                    NewGESTIONRow("CALLE") = TXTCALLE.Text
                    NewGESTIONRow("NUMERO") = TXTPUERTA.Text
                End If
                NewGESTIONRow("ESQ1") = ""
                NewGESTIONRow("CARPETA") = ""
                NewGESTIONRow("FECHAINGRESADA") = Today.ToShortDateString
                NewGESTIONRow("FECHAINICESTIMADA") = GEST_INIEST.Value.ToShortDateString
                NewGESTIONRow("STATUS") = "INGRESADO"
                NewGESTIONRow("TIEMPOEST") = GEST_TESTIMADO.Text
                NewGESTIONRow("COMPLETO") = False
                NewGESTIONRow("REQUERIDO") = False

                Select Case INGRESO_AREA
                    Case "RED"
                        NewGESTIONRow("AREA") = "RED"
                        If GEST_NODO.Text = "" Then
                            If GEST_TIPO.Text = "RELEVAMIENTO PRE GESTION" Then

                                DATOS.ORDENESDataSet.GESTION.AddGESTIONRow(NewGESTIONRow)
                                DATOS.GESTIONTableAdapter.Update(NewGESTIONRow)
                                DATOS.GESTIONTableAdapter.FillByTIPO_STATUS_NODO(DATOS.ORDENESDataSet.GESTION, "RELEVAMIENTO PRE GESTION", "")
                            Else
                                MsgBox("INGRESE UN NODO", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        Else
                            If GEST_TIPO.Text = "RELEVAMIENTO PRE GESTION" Then
                                MsgBox("SELECCIONE UN TIPO DE GESTION DIFERENTE", MsgBoxStyle.Information)
                                Exit Sub
                            Else
                                NewGESTIONRow("AREA") = "RED"
                                DATOS.ORDENESDataSet.GESTION.AddGESTIONRow(NewGESTIONRow)
                                DATOS.GESTIONTableAdapter.Update(NewGESTIONRow)
                                DATOS.GESTIONTableAdapter.FillByREDPENDIENTE(DATOS.ORDENESDataSet.GESTION, DATOS.BUSCA_NODO.Text)
                            End If
                        End If
                    Case "MDU"
                        NewGESTIONRow("CARPETA") = BUSCA_PRIM
                        NewGESTIONRow("AREA") = "MDU"
                        NewGESTIONRow("TIEMPOEST") = GEST_TESTIMADO.Text
                        DATOS.ORDENESDataSet.GESTION.AddGESTIONRow(NewGESTIONRow)
                        DATOS.GESTIONTableAdapter.Update(NewGESTIONRow)
                        DATOS.GESTIONTableAdapter.FillByGESTIPO_NODO_ZONA(DATOS.ORDENESDataSet.GESTION, GEST_TIPO.Text, GEST_NODO.Text, TXTZONA.Text)

                    Case "FUENTES"
                        NewGESTIONRow("AREA") = "RED"
                        NewGESTIONRow("TIEMPOEST") = GEST_TESTIMADO.Text
                        DATOS.ORDENESDataSet.GESTION.AddGESTIONRow(NewGESTIONRow)
                        DATOS.GESTIONTableAdapter.Update(NewGESTIONRow)
                        DATOS.GESTIONTableAdapter.FillByTIPO_STATUS_NODO(DATOS.ORDENESDataSet.GESTION, FUENTE_GESTION, FUENTE_NODO)
                End Select
                DATOS.GESTIONBindingSource.MoveLast()
                DATOS.DATOS_GESTIONRow = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position)
                DATOS.GESTIONTableAdapter.UpdateATRIBUTO(CB_GEST_ATRIBUTO.Text, DATOS.DATOS_GESTIONRow.Id_GESTION)

                DATOS.LLENA_TRABAJOS()
                DATOS.LLENA_CAMPOSGESTION()

                If ACCESO_DESDE = "MDU" Then
                    'ACTUALIZA EL STATUS DE LA TABLA EDIFICIOS
                    DATOS.DATOS_EDIFICIORow = DATOS.MDUDataSet.Edificios.Rows(0)
                    If INGRESO_AREA = "MDU" Then
                        Select Case GEST_TIPO.Text
                            Case "Mant Preventivo", "MANT PREVENTIVO"
                                DATOS.DATOS_EDIFICIORow("GESTMANT") = True
                            Case "Obra Nueva", "OBRA NUEVA"
                                DATOS.DATOS_EDIFICIORow("GESTOBR") = True
                        End Select
                    End If
                    DATOS.EdificiosTableAdapter.Update(DATOS.MDUDataSet.Edificios)
                End If
                DATOS.GEST_NODO.Text = DATOS.DATOS_GESTIONRow("NODO")

                'CARGA HISTORICO
                DATOS.DATOS_HIS_STATUSACTUAL = "NUEVA GESTION"
                DATOS.DATOS_HIS_CAUSA = "INGRESO GESTION"
                DATOS.DATOS_HIS_DETALLE = "FECHA DE INGRESO: " & Now.ToShortDateString

                TIPOREGISTRO = "GESTION"
                DATOS.CARGA_HISTORICO()
                'ENVIA MENSAJE
                If GEST_TIPO.Text = "RELEVAMIENTO PRE GESTION" Then
                    'ENVIA MENSAJE 
                    DATOS.DATOS_MJE_ASUNTO = "RELEVAMIENTO"
                    DATOS.DATOS_MJE_DESTINONOMBRE = ""
                    DATOS.DATOS_MJE_DESTINOSECTOR = "SUPERVISION"
                    DATOS.DATOS_MJE_MENSAJE = "SE HA CREADO UNA GESTION DE " & GEST_TIPO.Text & " CON EL SIGUIENTE DETALLE: " & GEST_DESCRIPCION2.Text _
                          & "GENERAR EL TRABAJO Y LAS ORDENES CORRESPONDIENTE "
                    DATOS.DATOS_MJE_NROORDENASOC = 0
                    DATOS.ENVIA_MENSAJE()
                End If
            Case "EDITAR"
                        DATOS.DATOS_GESTIONRow = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position)
                        DATOS.DATOS_GESTIONRow("TIPOGESTION") = GEST_TIPO.Text
                        DATOS.DATOS_GESTIONRow("NODO") = GEST_NODO.Text
                        DATOS.DATOS_GESTIONRow("ZONA") = TXTZONA.Text
                        If TXTSECCION.Text <> "" And TXTSEGMENTO.Text <> "" And TXTMANZANA.Text <> "" Then DATOS.DATOS_GESTIONRow("MANZANA") = TXTSECCION.Text & "/" & TXTSEGMENTO.Text & "/" & TXTMANZANA.Text
                ' DATOS.DATOS_GESTIONRow("ID_CALLE") = LBL_ID_CALLE.Text
                DATOS.DATOS_GESTIONRow("CALLE") = TXTCALLE.Text
                        DATOS.DATOS_GESTIONRow("NUMERO") = TXTPUERTA.Text
                        DATOS.DATOS_GESTIONRow("DESCRIPCION") = GEST_DESCRIPCION2.Text
                        DATOS.DATOS_GESTIONRow("SOLICITANTE") = GEST_SOLICITANTE.Text
                        DATOS.DATOS_GESTIONRow("NOMBRECONTACTO") = GEST_CONTACTO.Text
                        DATOS.DATOS_GESTIONRow("TELEFCONTACTO") = GEST_TELEFCONTAC.Text
                        DATOS.DATOS_GESTIONRow("MAILCONTACTO") = GEST_MAILCONTAC.Text
                        DATOS.DATOS_GESTIONRow("ASIGNADOA") = FULLNOMBRE
                        DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA") = GEST_INIEST.Value.ToShortDateString
                        DATOS.DATOS_GESTIONRow("TIEMPOEST") = GEST_TESTIMADO.Text
                        DATOS.DATOS_GESTIONRow.ID_GESTION_ORDINALES = ID_GEST_ORD.Text
                        DATOS.GESTIONTableAdapter.Update(DATOS.DATOS_GESTIONRow)
                        If DATOS.DATOS_GESTIONRow.IsATRIBUTONull Then
                            DATOS.GESTIONTableAdapter.UpdateATRIBUTO(CB_GEST_ATRIBUTO.Text, DATOS.DATOS_GESTIONRow.Id_GESTION)
                        Else
                            If DATOS.DATOS_GESTIONRow.ATRIBUTO <> CB_GEST_ATRIBUTO.Text Then
                                DATOS.GESTIONTableAdapter.UpdateATRIBUTO(CB_GEST_ATRIBUTO.Text, DATOS.DATOS_GESTIONRow.Id_GESTION)
                            End If
                        End If


                End Select


                TRABAJOS_A_GENERAR()
        DATOS.TRABAJOSTableAdapter.FillByIDGESTION(DATOS.ORDENESDataSet.TRABAJOS, DATOS.DATOS_GESTIONRow.Id_GESTION)
        Me.Cursor = DefaultCursor
        GEST_TIPO.Enabled = False
        GEST_INIEST.Enabled = False
        GEST_CONTACTO.ReadOnly = True
        GEST_DESCRIPCION2.ReadOnly = True
        GEST_MAILCONTAC.ReadOnly = True
        DATOS.GEST_NODO.Enabled = True

        GEST_TELEFCONTAC.ReadOnly = True
        GEST_TESTIMADO.ReadOnly = True
        BOT_CANCELARGEST.Enabled = False
        BOT_GUARDARGEST.Enabled = False
        DATOS.BOT_NUEVAGEST.Enabled = True

        DATOS.GESTIONDataGridView.Enabled = True
        DATOS.TRABAJOSDataGridView.Enabled = True
        DATOS.ORDENESDataGridView.Enabled = True

        DATOS.Enabled = True
        Me.Close()


    End Sub
    Private Sub BOT_CANCELARGEST_Click(sender As Object, e As EventArgs) Handles BOT_CANCELARGEST.Click
        DATOS.Enabled = True
        DATOS.CONDINI_GESTION()
        Me.Close()
    End Sub
    Private Sub BOT_CANCELARGEST_MouseHover(sender As Object, e As EventArgs) Handles BOT_CANCELARGEST.MouseHover
        BOT_CANCELARGEST.BackgroundImage = My.Resources.BTNGRAL_OVER
    End Sub
    Private Sub BOT_CANCELARGEST_MouseLeave(sender As Object, e As EventArgs) Handles BOT_CANCELARGEST.MouseLeave
        BOT_CANCELARGEST.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    End Sub
    Private Sub BOT_GUARDARGEST_MouseHover(sender As Object, e As EventArgs) Handles BOT_GUARDARGEST.MouseHover
        BOT_GUARDARGEST.BackgroundImage = My.Resources.BTNGRAL_OVER
    End Sub
    Private Sub BOT_GUARDARGEST_MouseLeave(sender As Object, e As EventArgs) Handles BOT_GUARDARGEST.MouseLeave
        BOT_GUARDARGEST.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    End Sub
    Private Sub BOT_GUARDARGEST_MouseClick(sender As Object, e As MouseEventArgs) Handles BOT_GUARDARGEST.MouseClick
        BOT_GUARDARGEST.BackgroundImage = My.Resources.BTNGRAL_PRESS
    End Sub
    Private Sub TXTCALLE_TextChanged(sender As Object, e As EventArgs) Handles TXTCALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
        ' Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = TXTCALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        INDICE_CALLESBindingSource.DataSource = VISTACALLE
        INDICE_CALLESDataGridView.Columns(0).Visible = False
    End Sub
    Private Sub TXTCALLE_Click(sender As Object, e As EventArgs) Handles TXTCALLE.Click
        If INDICE_CALLESDataGridView.Visible = False Then
            INDICE_CALLESDataGridView.Visible = True
            INDICE_CALLESDataGridView.Columns(0).Visible = False
        End If
    End Sub
    Private Sub TXTCALLE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCALLE.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If VISTACALLE.Count = 1 Then
                TXTCALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                Valor_indice_calle = INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                LBL_ID_CALLE.Text = Valor_indice_calle
                INDICE_CALLESDataGridView.Visible = False
            Else
                TXTCALLE.Text = ""
                Valor_indice_calle = ""
                LBL_ID_CALLE.Text = ""
            End If
        Else
            If INDICE_CALLESDataGridView.Visible = True Then
            Else
                INDICE_CALLESDataGridView.Visible = True
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.DoubleClick
        If INDICE_CALLESDataGridView.RowCount > 0 Then
            TXTCALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            Valor_indice_calle = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            LBL_ID_CALLE.Text = Valor_indice_calle
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    Private Sub GEST_TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GEST_TIPO.SelectedIndexChanged
        If CKGENTRAB.Checked = True Then
            TRABAJOS_AUTO_DESDEGEST()
        End If
    End Sub
    Private Sub TRABAJOS_AUTO_DESDEGEST()
        CKLIST.Items.Clear()
        If GEST_TIPO.Text = "" Then
            MsgBox("SELECCIONE UN TIPO DE GESTION")
        Else
            GESTIONES_TIPOTableAdapter.FillByTIPO_GESTION(ORDENESDataSet.GESTIONES_TIPO, GEST_TIPO.Text)
            COMBOSTableAdapter.FillByTIPO_GESTION_DESDE(ORDENESDataSet.COMBOS, ORDENESDataSet.GESTIONES_TIPO.Rows(0).Item("GRUPO_GESTION"), "TRABAJO")
        End If
        For X = 0 To ORDENESDataSet.COMBOS.Rows.Count - 1
            DATOS.COMBORow = ORDENESDataSet.COMBOS.Rows(X)
            CKLIST.Items.Add(DATOS.COMBORow.TIPO_TRABAJO)

        Next
        Dim REMOVER As Boolean
        If TIPOACCION = "EDITAR" Then
            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
                    REMOVER = False
                    For C = 0 To CKLIST.Items.Count - 1
                        If DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO") = CKLIST.Items(C).ToString Then
                            REMOVER = True
                        End If
                    Next
                    If REMOVER Then
                        CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
                    End If
                Next
            End If
        End If


        'If TIPOACCION = "NUEVO" Then
        '    Select Case GEST_TIPO.Text
        '        Case "MANT PREVENTIVO" 'GRUPO GEST 5
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("EJECUCION")
        '        Case "OBRA NUEVA" 'GRUPO GEST 4
        '            CKLIST.Items.Add("RELEVAMIENTO")

        '        Case "RELEVAMIENTO PRE GESTION" 'GRUPO GEST 3
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '        Case "MANT DISTRIBUCION", "MANT TRONCALES", "MANT FIBRA", "MANT SOPORTES DE RED", "PREVENTIVO PUNTUAL" 'GRUPO GEST 1
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("DISEÑO")
        '            CKLIST.Items.Add("PREDICTIVO")
        '            CKLIST.Items.Add("PREVENTIVO")
        '            CKLIST.Items.Add("OBRA CIVIL")
        '            CKLIST.Items.Add("ACTUALIZACION PLANOS")
        '        Case "MODIF DE RED", "CONST DE RED", "CONST DE FIBRA" 'GRUPO GEST 2
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("DISEÑO")
        '            CKLIST.Items.Add("APROBACION PERMISOS")
        '            CKLIST.Items.Add("AUTORIZACION CABLEADO")
        '            CKLIST.Items.Add("APROBACION IMM")
        '            CKLIST.Items.Add("OBRA CIVIL")
        '            CKLIST.Items.Add("EJECUCION")
        '            CKLIST.Items.Add("ACTUALIZACION PLANOS")
        '        Case ""

        '    End Select
        'Else
        '    Select Case GEST_TIPO.Text
        '        Case "MANT PREVENTIVO"
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("EJECUCION")
        '            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '                    Select Case DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO")
        '                        Case "RELEVAMIENTO", "EJECUCION"
        '                            CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
        '                    End Select
        '                Next
        '            End If
        '        Case "OBRA NUEVA"
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("DISEÑO")
        '            CKLIST.Items.Add("PRESUPUESTO")
        '            CKLIST.Items.Add("APROBACION PERMISOS")
        '            CKLIST.Items.Add("AUTORIZACION CABLEADO")
        '            CKLIST.Items.Add("APROBACION IMM")
        '            CKLIST.Items.Add("OBRA CIVIL")
        '            CKLIST.Items.Add("ASOCIADO A RED")
        '            CKLIST.Items.Add("EJECUCION")
        '            CKLIST.Items.Add("ACTUALIZACION PLANOS")
        '            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '                    Select Case DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO")
        '                        Case "RELEVAMIENTO", "DISEÑO", "PRESUPUESTO", "APROBACION PERMISOS", "AUTORIZACION CABLEADO", "APROBACION IMM", "OBRA CIVIL", "ASOCIADO A RED", "EJECUCION", "ACTUALIZACION PLANOS"
        '                            CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
        '                    End Select
        '                Next
        '            End If
        '        Case "RELEVAMIENTO PRE GESTION"
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '                    Select Case DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO")
        '                        Case "RELEVAMIENTO"
        '                            CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
        '                    End Select
        '                Next
        '            End If
        '        Case "MANT DISTRIBUCION", "MANT TRONCALES", "MANT FIBRA", "MANT SOPORTES DE RED", "PREVENTIVO PUNTUAL"
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("DISEÑO")
        '            CKLIST.Items.Add("PREDICTIVO")
        '            CKLIST.Items.Add("PREVENTIVO")
        '            CKLIST.Items.Add("OBRA CIVIL")
        '            CKLIST.Items.Add("EJECUCION")
        '            CKLIST.Items.Add("ACTUALIZACION PLANOS")
        '            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '                    Select Case DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO")
        '                        Case "RELEVAMIENTO", "DISEÑO", "PREDICTIVO", "PREVENTIVO", "OBRA CIVIL", "EJECUCION", "ACTUALIZACION PLANOS"
        '                            CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
        '                    End Select
        '                Next
        '            End If
        '        Case "MODIF DE RED", "CONST DE RED", "CONST DE FIBRA"
        '            CKLIST.Items.Add("RELEVAMIENTO")
        '            CKLIST.Items.Add("DISEÑO")
        '            CKLIST.Items.Add("APROBACION PERMISOS")
        '            CKLIST.Items.Add("AUTORIZACION CABLEADO")
        '            CKLIST.Items.Add("APROBACION IMM")
        '            CKLIST.Items.Add("OBRA CIVIL")
        '            CKLIST.Items.Add("EJECUCION")
        '            CKLIST.Items.Add("ACTUALIZACION PLANOS")
        '            If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '                For T = 0 To DATOS.ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '                    Select Case DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO")
        '                        Case "RELEVAMIENTO", "APROBACION PERMISOS", "AUTORIZACION CABLEADO", "APROBACION IMM", "OBRA CIVIL", "ASOCIADO A RED", "EJECUCION", "ACTUALIZACION PLANOS"
        '                            CKLIST.Items.Remove(DATOS.ORDENESDataSet.TRABAJOS.Rows(T).Item("TIPOTRABAJO"))
        '                    End Select
        '                Next
        '            End If
        '    End Select

        'End If
    End Sub
    Private Sub CKGENTRAB_CheckedChanged(sender As Object, e As EventArgs) Handles CKGENTRAB.CheckedChanged
        If CKGENTRAB.Checked = True Then
            If TXTZONA.Text = "" Then
                MsgBox("SELECCIONE UNA ZONA")
            Else
                TRABAJOS_AUTO_DESDEGEST()
            End If
        Else
            CKLIST.Items.Clear()
        End If

    End Sub
    Private Sub TRABAJOS_A_GENERAR()
        Dim TIEMPO_SOLUCION As Integer
        If CKGENTRAB.Checked = True Then
            If CKLIST.CheckedItems.Count > 0 Then
                For I = 0 To CKLIST.CheckedItems.Count - 1
                    TIPO_TRABAJO = CKLIST.CheckedItems(I).ToString
                    TIEM_EST = 0
                    Select Case CKLIST.CheckedItems(I).ToString
                        Case "RELEVAMIENTO"
                            TIEMPO_SOLUCION = 7
                        Case "DISEÑO", "APROBACION PERMISOS", "AUTORIZACION CABLEADO"
                            TIEMPO_SOLUCION = 5
                        Case "APROBACION IMM"
                            TIEMPO_SOLUCION = 10
                        Case "OBRA CIVIL"
                            TIEMPO_SOLUCION = 3
                        Case "ASOCIADO A RED", "EJECUCION", "ACTUALIZACION PLANOS", "PRESUPUESTO", "PREDICTIVO", "PREVENTIVO"
                            TIEMPO_SOLUCION = 2
                    End Select

                    For D = 1 To TIEMPO_SOLUCION
                        If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                            FECHAFIN = CDate(DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")).AddDays(D)
                            If D = TIEMPO_SOLUCION Then
                                If CDate(DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")).AddDays(TIEM_EST).DayOfWeek = DayOfWeek.Saturday Then
                                    TIEM_EST += 2
                                ElseIf CDate(DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")).AddDays(TIEM_EST).DayOfWeek = DayOfWeek.Sunday Then
                                    TIEM_EST += 1
                                End If
                            End If
                        Else
                            FECHAFIN = CDate(DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA")).AddDays(D)
                            If D = TIEMPO_SOLUCION Then
                                If CDate(DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA")).AddDays(TIEM_EST).DayOfWeek = DayOfWeek.Saturday Then
                                    TIEM_EST += 2
                                ElseIf CDate(DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA")).AddDays(TIEM_EST).DayOfWeek = DayOfWeek.Sunday Then
                                    TIEM_EST += 1
                                End If
                            End If
                        End If
                        If FECHAFIN.DayOfWeek = DayOfWeek.Saturday Or FECHAFIN.DayOfWeek = DayOfWeek.Sunday Then
                            TIEM_EST += 1
                        End If
                        TIEM_EST += 1
                    Next
                    If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                        FECHA_INIEST = CDate(DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")).AddDays(DATOS.DATOS_TRABAJORow("TIEMPOESTIMADO")).ToShortDateString
                        Select Case DATOS.DATOS_TRABAJORow("TIPODEP")
                            Case ""
                                ORD_DEPENDENCIA = 0
                            Case "ULT"
                                ORD_DEPENDENCIA = DATOS.ORDENESDataSet.TRABAJOS.Rows.Count
                                DATOS.DATOS_TRABAJORow("TIPODEP") = DATOS.ORDENESDataSet.TRABAJOS.Rows.Count
                                DATOS.TRABAJOSTableAdapter.Update(DATOS.DATOS_TRABAJORow)
                            Case Else
                                ORD_DEPENDENCIA = DATOS.DATOS_TRABAJORow("TIPODEP")
                        End Select
                        ORD_DEPENDENCIA += 1
                        DEPENDENCIA = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                    Else
                        FECHA_INIEST = CDate(DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA")).ToShortDateString
                        ORD_DEPENDENCIA = 0
                        DEPENDENCIA = 0
                    End If

                    NewTRABAJORow = DATOS.ORDENESDataSet.TRABAJOS.NewTRABAJOSRow
                    NewTRABAJORow("ID_GESTION") = DATOS.DATOS_GESTIONRow("Id_GESTION")
                    NewTRABAJORow("TIPOTRABAJO") = TIPO_TRABAJO
                    NewTRABAJORow("FECHAINICESTIMADO") = FECHA_INIEST
                    NewTRABAJORow("TIEMPOESTIMADO") = TIEM_EST
                    NewTRABAJORow("DESCRIPCION") = DATOS.DATOS_GESTIONRow("DESCRIPCION")
                    NewTRABAJORow("NODO") = DATOS.DATOS_GESTIONRow("NODO")
                    NewTRABAJORow("ZONA") = DATOS.DATOS_GESTIONRow("ZONA")
                    NewTRABAJORow("MANZANA") = DATOS.DATOS_GESTIONRow("MANZANA")
                    NewTRABAJORow("CALLE") = DATOS.DATOS_GESTIONRow("CALLE")
                    NewTRABAJORow("NRO") = DATOS.DATOS_GESTIONRow("NUMERO")
                    NewTRABAJORow("FECHAINGRESADO") = Now
                    NewTRABAJORow("GENERADOX") = FULLNOMBRE
                    NewTRABAJORow("ASIGNADOA") = FULLNOMBRE
                    NewTRABAJORow("SECTORASIG") = SECTOR
                    NewTRABAJORow("IDASIG") = ID
                    NewTRABAJORow("INSTALACION") = ""
                    NewTRABAJORow("INSTALACIONRUS") = ""
                    NewTRABAJORow("ATRIBUTO") = CB_GEST_ATRIBUTO.Text
                    Select Case TIPO_TRABAJO
                        Case "ASOCIADO A RED", "OBRA CIVIL"
                            NewTRABAJORow("AREA") = "RED"
                        Case Else
                            NewTRABAJORow("AREA") = DATOS.DATOS_GESTIONRow("AREA")
                    End Select
                    NewTRABAJORow("STATUS") = "INGRESADO"
                    NewTRABAJORow("TIPODEP") = ORD_DEPENDENCIA
                    NewTRABAJORow("DEPENDENCIA") = DEPENDENCIA

                    DATOS.ORDENESDataSet.TRABAJOS.AddTRABAJOSRow(NewTRABAJORow)
                    DATOS.TRABAJOSTableAdapter.Update(NewTRABAJORow)
                    DATOS.LLENA_TRABAJOS()

                    'HISTORICO TRABAJO
                    DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADO"
                    DATOS.DATOS_HIS_CAUSA = "GENERACION NUEVO TRABAJO AUTOMATICO"
                    DATOS.DATOS_HIS_DETALLE = "INICIO ESTIMADO : " & FECHA_INIEST

                    DATOS.DATOS_NewHISTORICORow = DATOS.ORDENESDataSet.HISTORICO.NewHISTORICORow
                    DATOS.DATOS_NewHISTORICORow("ID_GESTION") = DATOS.DATOS_GESTIONRow("Id_GESTION")
                    DATOS.DATOS_NewHISTORICORow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                    DATOS.DATOS_NewHISTORICORow("ID_ORDENINT") = 0
                    DATOS.DATOS_NewHISTORICORow("FECHA") = Now
                    DATOS.DATOS_NewHISTORICORow("STATUSANTERIOR") = "---------"
                    DATOS.DATOS_NewHISTORICORow("STATUSACTUAL") = DATOS.DATOS_HIS_STATUSACTUAL
                    DATOS.DATOS_NewHISTORICORow("CAUSA") = DATOS.DATOS_HIS_CAUSA
                    DATOS.DATOS_NewHISTORICORow("DETALLE") = DATOS.DATOS_HIS_DETALLE
                    DATOS.DATOS_NewHISTORICORow("EJECUTANTE") = FULLNOMBRE

                    DATOS.ORDENESDataSet.HISTORICO.AddHISTORICORow(DATOS.DATOS_NewHISTORICORow)
                    DATOS.HISTORICOTableAdapter.Update(DATOS.DATOS_NewHISTORICORow)
                    If I = CKLIST.CheckedItems.Count - 1 Then
                        DATOS.DATOS_GESTIONRow("TIEMPOEST") = DateDiff(DateInterval.Day, DATOS.DATOS_GESTIONRow("FECHAINICESTIMADA"), CDate(DATOS.DATOS_TRABAJORow("FECHAINICESTIMADO")).AddDays(DATOS.DATOS_TRABAJORow("TIEMPOESTIMADO")))
                        DATOS.GESTIONTableAdapter.Update(DATOS.DATOS_GESTIONRow)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub CB_GEST_ATRIBUTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GEST_ATRIBUTO.SelectedIndexChanged

    End Sub
End Class