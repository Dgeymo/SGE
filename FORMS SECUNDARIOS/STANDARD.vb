Imports System.IO

Public Class STANDARD

    Dim STANDARDRow As DataRow
    Dim TAREAordenRow As DataRow
    Dim OBSERVACIONESRow As DataRow
    Dim FUNCIONARIORow As DataRow

    Dim NewTAREARow As ORDENESDataSet.TAREASRow
    Dim NewORDENESRow As ORDENESDataSet.ORDENESRow
    Dim NewOBSERVACIONESRow As ORDENESDataSet.OBESERVACIONESRow
    Dim NewADJUNTOSRow As ORDENESDataSet.ADJUNTOSRow
    Dim TIEMPORESTANTE As Integer
    Dim STATUSANT As String
    Dim ASIGNADOA As String
    Dim ACTIVIDAD_SELEC As String
    Dim SECTORDESTINO As String
    Dim FECHAAGENDA As String
    Dim CANTIDADREG As Integer
    Dim NOTIFICAR_ORDEN As Boolean
    Dim CampoCalle(5)
    Dim ExpreCalle(5)
    Dim FiltrCalle(5)
    'VARIABLES DE STANDARD DE ORDENES
    Dim ACTIVIDAD(50) As String
    Dim TAREA(50) As String
    Dim CANTSTD(50) As Integer
    Dim CANTORDEN(50) As Integer
    Dim UNIDAD(50) As String
    Dim TIEMPOMIN(50) As Double
    Dim TIEMPOUNIT(50) As Double
    Dim ZONA_AFECTACION As Array
    Dim AFECTACION_ITEM(50) As String
    Dim TOTAL_AFECTACION As String
    Dim VISTACALLE As DataView
    Dim FIJA_TIEMPOAGENDA As Integer
    Dim ORDINAL As Integer
    Dim SOLICITANTE As String = ""
    Dim SECTOR_FALLA As String
    Dim SECTOR_TIPO As String
    Dim PathRuta As String
    Dim PROYECTO_ORDINAL As Integer

    Private Sub STANDARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If THEME_BLACK = False Then
            Label5.BackColor = Color.White
            Label5.ForeColor = Color.FromArgb(0, 64, 0)
            LBL_OCUPA_MOSTRAR.BackColor = Color.White
            LBL_OCUPA_MOSTRAR.ForeColor = Color.FromArgb(0, 64, 0)
            Label9.BackColor = Color.White
            Label9.ForeColor = Color.FromArgb(0, 64, 0)
            Label24.BackColor = Color.White
            Label24.ForeColor = Color.FromArgb(0, 64, 0)
            Label23.BackColor = Color.White
            Label23.ForeColor = Color.FromArgb(0, 64, 0)
            Label2.BackColor = Color.White
            Label2.ForeColor = Color.FromArgb(0, 64, 0)
            Label9.BackColor = Color.White
            Label9.ForeColor = Color.FromArgb(0, 64, 0)

            LBL_TIEMPOFINAL.BackColor = Color.White
            LBL_TIEMPOFINAL.ForeColor = Color.FromArgb(0, 64, 0)
            LBL_TRASLADO.BackColor = Color.White
            LBL_TRASLADO.ForeColor = Color.FromArgb(0, 64, 0)
            LBL_TIEMPOAGENDA.BackColor = Color.White
            LBL_TIEMPOAGENDA.ForeColor = Color.FromArgb(0, 64, 0)

            STANDARDDataGridView.BackgroundColor = Color.FromArgb(214, 214, 214)
            STANDARDDataGridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)
            STANDARDDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214)
            STANDARDDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(170, 170, 170)
            STANDARDDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Green

            MARCARTODO.BackColor = Color.FromArgb(214, 214, 214)
            MARCARTODO.ForeColor = Color.FromArgb(0, 64, 0)

            CB_ING_TIPO.BackColor = Color.FromArgb(214, 214, 214)
            CB_ING_TIPO.ForeColor = Color.FromArgb(0, 64, 0)
            CB_ING_TIPO_RED.BackColor = Color.FromArgb(214, 214, 214)
            CB_ING_TIPO_RED.ForeColor = Color.FromArgb(0, 64, 0)
            CB_ING_SECTOR.BackColor = Color.FromArgb(214, 214, 214)
            CB_ING_SECTOR.ForeColor = Color.FromArgb(0, 64, 0)
            CB_ING_FALLA.BackColor = Color.FromArgb(214, 214, 214)
            CB_ING_FALLA.ForeColor = Color.FromArgb(0, 64, 0)
            CB_ING_CAUSA.BackColor = Color.FromArgb(214, 214, 214)
            CB_ING_CAUSA.ForeColor = Color.FromArgb(0, 64, 0)

            DataGridView1.BackgroundColor = Color.FromArgb(214, 214, 214)
            DataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(214, 214, 214)
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(170, 170, 170)
            DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Green

            CK_DOCUMENTO_FISICO.ForeColor = Color.FromArgb(0, 64, 0)
            CK_DOCUMENTO_FISICO.BackColor = Color.FromArgb(214, 214, 214)
            BTN_ADJUNTAR.ForeColor = Color.White
            BTN_ADJUNTAR.BackColor = Color.FromArgb(214, 214, 214)
            BTN_ADJUNTAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214)
            BTNBorrar.ForeColor = Color.White
            BTNBorrar.BackColor = Color.FromArgb(214, 214, 214)
            BTNBorrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214)
            ESTADO.ForeColor = Color.FromArgb(0, 64, 0)
            ESTADO.BackColor = Color.FromArgb(214, 214, 214)

            BOT_GUARDAR.ForeColor = Color.White
            BOT_GUARDAR.BackColor = Color.FromArgb(214, 214, 214)
            BOT_GUARDAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214)
            CK_NOTIFICAR_ORDEN.ForeColor = Color.FromArgb(0, 64, 0)
            CK_NOTIFICAR_ORDEN.BackColor = Color.FromArgb(214, 214, 214)

            CHECK_COORDINAR.ForeColor = Color.FromArgb(0, 64, 0)
            CHECK_COORDINAR.BackColor = Color.FromArgb(214, 214, 214)

            CHECK_CREARORDINAL.ForeColor = Color.FromArgb(0, 64, 0)
            CHECK_CREARORDINAL.BackColor = Color.FromArgb(214, 214, 214)

            COMB_CUADRILLA.ForeColor = Color.FromArgb(0, 64, 0)
            COMB_CUADRILLA.BackColor = Color.FromArgb(214, 214, 214)

            Label32.ForeColor = Color.FromArgb(0, 64, 0)
            Label32.BackColor = Color.FromArgb(214, 214, 214)

            CB_PRIORIDAD.ForeColor = Color.FromArgb(0, 64, 0)
            CB_PRIORIDAD.BackColor = Color.FromArgb(214, 214, 214)

            Label26.ForeColor = Color.FromArgb(0, 64, 0)
            Label26.BackColor = Color.FromArgb(214, 214, 214)
            LBL_OC.ForeColor = Color.FromArgb(0, 64, 0)
            LBL_OC.BackColor = Color.FromArgb(214, 214, 214)
            LBL_CANT_OC.ForeColor = Color.FromArgb(0, 64, 0)
            LBL_CANT_OC.BackColor = Color.FromArgb(214, 214, 214)
            Label38.ForeColor = Color.FromArgb(0, 64, 0)
            Label38.BackColor = Color.FromArgb(214, 214, 214)
            IND_CALLE.ForeColor = Color.FromArgb(0, 64, 0)
            IND_CALLE.BackColor = Color.FromArgb(214, 214, 214)

        End If

        Size = New Size(1200, 600)
        '  Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)

        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        INDICE_CALLESDataGridView.Columns(0).Visible = False
        Cursor = Cursors.WaitCursor
        SECTORESTableAdapter.Fill(ORDENESDataSet.SECTORES)
        ORDENESDataSet.ADJUNTOS.Clear()
        TXT_ING_CALLE.Focus()

        CB_PRIORIDAD.Items.Clear()
        CB_PRIORIDAD.Items.Add("URGENTE")
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA", "OBRA CIVIL"
                TXT_OC.Visible = True
                LBL_OC.Visible = True
                TXT_CANT_OC.Visible = True
                LBL_CANT_OC.Visible = True
        End Select
        CB_PRIORIDAD.Items.Add("ALTA")
        CB_PRIORIDAD.Items.Add("MEDIA")
        CB_PRIORIDAD.Items.Add("BAJA")
        CB_PRIORIDAD.Text = "BAJA"



        Select Case ACCION_ORDEN
            Case "NUEVO"
                If THEME_BLACK = False Then
                    BackgroundImage = My.Resources.BANNER_ORDEN_NUEVA_W
                Else
                    BackgroundImage = My.Resources.BANNER_ORDEN_NUEVA
                End If
                TXT_ORDENINT.Visible = False
                TXT_ORDINAL.Visible = False
                Select Case DATOS.DATOS_GESTIONRow.TIPOGESTION
                    Case "OBRA NUEVA", "OBRA NUEVA HFC", "OBRA NUEVA FTTH", "OBRA NUEVA RHFC"
                        CB_ING_TIPO.SelectedItem = "OBRAS"
                    Case Else
                        CB_ING_TIPO.SelectedItem = "TAREA"
                End Select
                If DATOS.DATOS_GESTIONRow.IsSOLICITANTENull = False Then SOLICITANTE = DATOS.DATOS_GESTIONRow.SOLICITANTE
                If IsDBNull(DATOS.DATOS_TRABAJORow("NODO")) = False Then TXT_ING_NODO.Text = DATOS.DATOS_TRABAJORow("NODO")
                If IsDBNull(DATOS.DATOS_TRABAJORow("ZONA")) = False Then TXT_ING_NODO.Text += " " & DATOS.DATOS_TRABAJORow("ZONA")
                If IsDBNull(DATOS.DATOS_TRABAJORow("MANZANA")) = False Then TXT_ING_MANZANA.Text = DATOS.DATOS_TRABAJORow("MANZANA")
                If IsDBNull(DATOS.DATOS_TRABAJORow("ATRIBUTO")) = False Then
                    If DATOS.DATOS_TRABAJORow("ATRIBUTO") = "" Then
                        CB_ING_TIPO_RED.SelectedItem = "HFC"
                    Else
                        CB_ING_TIPO_RED.SelectedItem = DATOS.DATOS_TRABAJORow("ATRIBUTO")
                    End If
                Else
                    CB_ING_TIPO_RED.SelectedItem = "HFC"
                End If
                If DATOS.DATOS_TRABAJORow.IsPROYECTO_ORDINALESNull Then
                    PROYECTO_ORDINAL = 0
                Else
                    PROYECTO_ORDINAL = DATOS.DATOS_TRABAJORow.PROYECTO_ORDINALES
                End If
                'cargamos la calle y le buscamos si esta bien escrita
                Try
                    If IsDBNull(DATOS.DATOS_TRABAJORow("CALLE")) = False Then
                        If DATOS.DATOS_TRABAJORow("CALLE") <> "" Then
                            TXT_ING_CALLE.Text = DATOS.DATOS_TRABAJORow("CALLE")
                        Else
                            TXT_ING_CALLE.Text = ""
                        End If
                    End If
                    If TXT_ING_CALLE.Text <> "" Then
                        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
                        CampoCalle(0) = "NOMBRE_CALLE"
                        ExpreCalle(0) = TXT_ING_CALLE.Text
                        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"
                        VISTACALLE.RowFilter = FiltrCalle(0)
                        INDICE_CALLESBindingSource.DataSource = VISTACALLE
                        If VISTACALLE.Count = 1 Then
                            TXT_ING_CALLE.Text = Trim(INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                            IND_CALLE.Text = INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                        End If
                    Else
                        IND_CALLE.Text = 0
                    End If
                Catch ex As Exception
                End Try

                If IsDBNull(DATOS.DATOS_TRABAJORow("NRO")) = False Then TXT_ING_NRO.Text = DATOS.DATOS_TRABAJORow("NRO")
                If IsDBNull(DATOS.DATOS_TRABAJORow("INSTALACION")) = False Then
                    TXT_ING_INSTALACION.Text = DATOS.DATOS_TRABAJORow("INSTALACION")
                Else
                    TXT_ING_INSTALACION.Text = ""
                End If
                If IsDBNull(DATOS.DATOS_TRABAJORow("INSTALACIONRUS")) = False Then
                    TXT_ING_INSTALACIONRUS.Text = DATOS.DATOS_TRABAJORow("INSTALACIONRUS")
                Else
                    TXT_ING_INSTALACIONRUS.Text = ""
                End If
                If ACCESO_DESDE = "FUENTES" Then
                    TXT_ING_INSTALACION.Text = FUENTE_ID
                    TXT_ING_INSTALACIONRUS.Text = FUENTE_INSTALACIONRUS
                    TXT_AFECTACION.Text = FUENTE_AFECTACION
                End If
                CARGA_COMBOS()
                If IsDBNull(DATOS.ORDENESDataSet.TRABAJOS(DATOS.TRABAJOSBindingSource.Position).Item("DESCRIPCION")) = False Then TXT_ING_OBSERVACIONES.Text = DATOS.ORDENESDataSet.TRABAJOS(DATOS.TRABAJOSBindingSource.Position).Item("DESCRIPCION")

                TXT_ING_FECHAINICEST.Text = DATOS.ING_FECHAINICEST
                TXT_TIEMPO_FINAL.Text = DATOS.TIEMPO_FINAL
                LBL_TIEMPORESTANTE.Text = ORDEN_TIEMPORESTANTE
                TIEMPORESTANTE = ORDEN_TIEMPORESTANTE
                LBL_TIEMPOAGENDA.Text = 0

                FIJA_TIEMPOAGENDA = CInt(TIEMPO_AGENDA / CAPACIDAD_DIA * 100)
                LBL_OCUPA_MOSTRAR.Text = FIJA_TIEMPOAGENDA
                NOTIFICAR_ORDEN = False

                TXT_ING_DEPENDENCIA.Text = DATOS.ING_DEPENDENCIA
                TXT_ING_TIPODEP.Text = DATOS.ING_TIPODEP
                TXT_ING_CLASEDEP.Text = DATOS.ING_CLASEDEP
                TXT_ING_ORDENDEP.Text = DATOS.ING_ORDENDEP
                TXT_ING_ORDORIGEN.Text = DATOS.ING_ORDORIGEN
                Dim NOMBRE_CTTO As String
                Dim TELEFONO_CTTO As String
                Dim EMAIL_CTTO As String
                If DATOS.DATOS_GESTIONRow.IsNOMBRECONTACTONull = False Then
                    If DATOS.DATOS_GESTIONRow.NOMBRECONTACTO <> "" Then
                        NOMBRE_CTTO = DATOS.DATOS_GESTIONRow.NOMBRECONTACTO
                    Else
                        NOMBRE_CTTO = ""
                    End If
                Else
                    NOMBRE_CTTO = ""
                End If
                If DATOS.DATOS_GESTIONRow.IsTELEFCONTACTONull = False Then
                    If DATOS.DATOS_GESTIONRow.TELEFCONTACTO <> "" Then
                        TELEFONO_CTTO = " | TEL: " & DATOS.DATOS_GESTIONRow.TELEFCONTACTO
                    Else
                        TELEFONO_CTTO = ""
                    End If
                Else
                    TELEFONO_CTTO = ""
                End If
                If DATOS.DATOS_GESTIONRow.IsMAILCONTACTONull = False Then
                    If DATOS.DATOS_GESTIONRow.MAILCONTACTO <> "" Then
                        EMAIL_CTTO = " | EMAIL: " & DATOS.DATOS_GESTIONRow.MAILCONTACTO
                    Else
                        EMAIL_CTTO = ""
                    End If
                Else
                    EMAIL_CTTO = ""
                End If
                TXT_TRABAJO_A_REALIZAR.Text = "CTTO: " & NOMBRE_CTTO & TELEFONO_CTTO & EMAIL_CTTO
                LBL_TRASLADO.Text = TIEMPO_TRASLADO
                LBL_CAPACIDADDIA.Text = CAPACIDAD_DIA

                COMB_CUADRILLA.Text = "SIN ASIGNAR"
                ASIGNADOA = ""
                FECHAAGENDA = ""
                TXT_ORDINAL.Text = 0
            Case "EDITAR"
                If THEME_BLACK = False Then
                    BackgroundImage = My.Resources.BANNER_ORDEN_EDITAR_W
                Else
                    BackgroundImage = My.Resources.BANNER_ORDEN_EDITAR
                End If
                TXT_ORDENINT.Visible = True
                '   BOT_GUARDAR.Enabled = TRUE
                Select Case DATOS.DATOS_ORDENESRow("STATUS")
                    Case "FINALIZADO"
                        If DATOS.DATOS_ORDENESRow("SECTOROPE") = "DISEÑO" Then
                            BOT_GUARDAR.Text = "REACTIVAR"
                            BOT_GUARDAR.ForeColor = Color.Red

                        End If
                End Select
                OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    OBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.Rows(0)
                    TXT_ING_OBSERVACIONES.Text = OBSERVACIONESRow("OBSORIGEN")
                Else
                    TXT_ING_OBSERVACIONES.Focus()
                End If
                If DATOS.DATOS_TRABAJORow.IsPROYECTO_ORDINALESNull Then
                    PROYECTO_ORDINAL = 0
                Else
                    PROYECTO_ORDINAL = DATOS.DATOS_TRABAJORow.PROYECTO_ORDINALES
                End If
                If IsDBNull(DATOS.DATOS_ORDENESRow("ATRIBUTO")) = False Then
                    If DATOS.DATOS_ORDENESRow("ATRIBUTO") = "" Then
                        CB_ING_TIPO_RED.SelectedItem = "HFC"
                    Else
                        CB_ING_TIPO_RED.SelectedItem = DATOS.DATOS_ORDENESRow("ATRIBUTO")
                    End If
                Else
                    CB_ING_TIPO_RED.SelectedItem = "HFC"
                End If
                NROORDENINT = DATOS.DATOS_ORDENESRow("NRO_ORDENINT")
                NROORDINAL = DATOS.DATOS_ORDENESRow("NRO_ORDINAL")
                NROGESTION = DATOS.DATOS_ORDENESRow("ID_GESTION")
                NROTRABAJO = DATOS.DATOS_ORDENESRow("ID_TRABAJO")
                NOTIFICAR_ORDEN = DATOS.DATOS_ORDENESRow("NOTIF")
                TXT_ORDINAL.Text = NROORDINAL

                CB_PRIORIDAD.Text = DATOS.DATOS_ORDENESRow("PRIORIDAD")
                CHECK_CREARORDINAL.Checked = DATOS.DATOS_ORDENESRow("CREARORDINAL")
                CHECK_COORDINAR.Checked = DATOS.DATOS_ORDENESRow("COORDINAR")
                TXT_ORDENINT.Text = NROORDENINT

                TXT_ING_NODO.Text = DATOS.DATOS_ORDENESRow("NODO")
                If IsDBNull(DATOS.DATOS_ORDENESRow("ZONA")) = False Then TXT_ING_NODO.Text += " " & DATOS.DATOS_ORDENESRow("ZONA")
                If DATOS.DATOS_ORDENESRow.IsMANZANANull = False Then TXT_ING_MANZANA.Text = DATOS.DATOS_ORDENESRow("MANZANA") Else TXT_ING_MANZANA.Text = ""
                TXT_ING_CALLE.Text = DATOS.DATOS_ORDENESRow("CALLE")
                If IsDBNull(DATOS.DATOS_ORDENESRow("ORDEN_OC")) = False Then TXT_OC.Text = DATOS.DATOS_ORDENESRow("ORDEN_OC")
                If Not DATOS.DATOS_ORDENESRow.IsAFECTACIONNull Then TXT_AFECTACION.Text = Trim(DATOS.DATOS_ORDENESRow.AFECTACION).Trim("{", "}", """")
                Try
                    If IsDBNull(DATOS.DATOS_ORDENESRow("ID_CALLE")) = False Then
                        If DATOS.DATOS_ORDENESRow("ID_CALLE") <> 0 Then
                            IND_CALLE.Text = DATOS.DATOS_ORDENESRow("ID_CALLE")
                            TXT_ING_OBSERVACIONES.Focus()
                        Else
                            IND_CALLE.Text = 0
                            TXT_ING_CALLE.Focus()
                        End If
                    Else
                        IND_CALLE.Text = 0
                        TXT_ING_CALLE.Focus()
                    End If
                Catch ex As Exception
                End Try
                TXT_ING_NRO.Text = DATOS.DATOS_ORDENESRow("NRO")
                LBL_TRASLADO.Text = TIEMPO_TRASLADO
                LBL_CAPACIDADDIA.Text = CAPACIDAD_DIA
                LBL_TIEMPORESTANTE.Text = ORDEN_TIEMPORESTANTE
                TIEMPORESTANTE = ORDEN_TIEMPORESTANTE
                CB_ING_TIPO.SelectedItem = DATOS.DATOS_ORDENESRow("TIPO")
                CARGA_COMBOS()
                If DATOS.DATOS_ORDENESRow.IsCANTIDAD_SERVICIOSNull = False Then TXT_CANT_OC.Text = DATOS.DATOS_ORDENESRow.CANTIDAD_SERVICIOS
                Select Case DATOS.DATOS_ORDENESRow("SECTOROPE")
                    Case "CUADRILLAS"
                        SECTOR_FALLA = "CUADRILLA CABLEADO"
                    Case "MANTENIMIENTO"
                        SECTOR_FALLA = "TECNICO"
                    Case Else
                        SECTOR_FALLA = DATOS.DATOS_ORDENESRow("SECTOROPE")
                End Select
                If DATOS.DATOS_ORDENESRow.IsOBS_TRABAJO_A_REALIZARNull = False Then TXT_TRABAJO_A_REALIZAR.Text = DATOS.DATOS_ORDENESRow.OBS_TRABAJO_A_REALIZAR Else TXT_TRABAJO_A_REALIZAR.Text = ""
                CB_ING_SECTOR.SelectedItem = SECTOR_FALLA
                SECTORDESTINO = DATOS.DATOS_ORDENESRow("SECTORDESTINO")
                CK_DOCUMENTO_FISICO.Checked = DATOS.DATOS_ORDENESRow("DOCUMENTO_FISICO")

                If IsDBNull(DATOS.DATOS_ORDENESRow("CUADRILLA")) = False Then
                    If DATOS.DATOS_ORDENESRow("CUADRILLA") <> "" Then
                        COMB_CUADRILLA.Text = DATOS.DATOS_ORDENESRow("CUADRILLA")
                        ASIGNADOA = DATOS.DATOS_ORDENESRow("CUADRILLA")
                    Else
                        COMB_CUADRILLA.Text = "SIN ASIGNAR"
                        ASIGNADOA = ""
                    End If
                Else
                    COMB_CUADRILLA.Text = "SIN ASIGNAR"
                    ASIGNADOA = ""
                End If


                CB_ING_FALLA.SelectedItem = DATOS.DATOS_ORDENESRow("MOTIVOORIGEN")


                TXT_ING_FECHAINICEST.Text = DATOS.ING_FECHAINICEST
                If IsDBNull(DATOS.DATOS_ORDENESRow("TESTIMADO")) = False Then
                    TXT_ING_TESTIMADO.Text = DATOS.DATOS_ORDENESRow("TESTIMADO")
                Else
                    TXT_ING_TESTIMADO.Text = 0
                End If
                TXT_TIEMPO_FINAL.Text = DATOS.TIEMPO_FINAL
                If IsDBNull(DATOS.DATOS_ORDENESRow("DEPENDENCIA")) = False Then
                    TXT_ING_DEPENDENCIA.Text = DATOS.DATOS_ORDENESRow("DEPENDENCIA")
                Else
                    TXT_ING_DEPENDENCIA.Text = 0
                End If
                TXT_ING_TIPODEP.Text = DATOS.DATOS_ORDENESRow("TIPODEP")
                TXT_ING_CLASEDEP.Text = DATOS.DATOS_ORDENESRow("CLASEDEP")
                If DATOS.DATOS_ORDENESRow.IsORDENDEPNull = False Then TXT_ING_ORDENDEP.Text = DATOS.DATOS_ORDENESRow("ORDENDEP") Else TXT_ING_ORDENDEP.Text = 0
                If DATOS.DATOS_ORDENESRow.IsORDORIGENNull = False Then TXT_ING_ORDORIGEN.Text = DATOS.DATOS_ORDENESRow("ORDORIGEN") Else TXT_ING_ORDORIGEN.Text = 0

                If IsDBNull(DATOS.DATOS_ORDENESRow("INSTALACION")) = False Then
                    TXT_ING_INSTALACION.Text = DATOS.DATOS_ORDENESRow("INSTALACION")
                Else
                    TXT_ING_INSTALACION.Text = ""
                End If

                If IsDBNull(DATOS.DATOS_ORDENESRow("INSTALACIONRUS")) = False Then
                    TXT_ING_INSTALACIONRUS.Text = DATOS.DATOS_ORDENESRow("INSTALACIONRUS")
                Else
                    TXT_ING_INSTALACIONRUS.Text = ""
                End If

                If IsDBNull(DATOS.DATOS_ORDENESRow("FECHAAGEND")) = False Then
                    FECHAAGENDA = DATOS.DATOS_ORDENESRow("FECHAAGEND").ToString
                Else
                    FECHAAGENDA = ""
                End If

                'CARGA LAS TAREAS CORRESPONDIENTES A LA ORDEN A EDITAR
                If DATOS.DATOS_ORDENESRow("NRO_ORDINAL") = 0 Then
                    TAREASTableAdapter.FillByordinal0(ORDENESDataSet.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                Else
                    If DATOS.DATOS_ORDENESRow("STATUS") = "FINALIZADO" Then
                        TAREASTableAdapter.FillByordinalno0(ORDENESDataSet.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                    Else
                        TAREASTableAdapter.FillByordinal0(ORDENESDataSet.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                    End If
                End If

                If ORDENESDataSet.TAREAS.Rows.Count > 0 Then
                    For i = 0 To ORDENESDataSet.TAREAS.Rows.Count - 1
                        TAREAordenRow = ORDENESDataSet.TAREAS.Rows(i)

                        If ORDENESDataSet.STANDARD.Rows.Count > 0 Then
                            For X = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
                                STANDARDRow = ORDENESDataSet.STANDARD.Rows(X)

                                If STANDARDRow("TAREA") = TAREAordenRow("TAREADESC") Then
                                    STANDARDRow("CANTORDEN") = TAREAordenRow("CANTSTD")
                                    STANDARDRow("SOLICITADO") = True
                                    'STANDARDTableAdapter.Update(STANDARDRow)
                                End If
                            Next
                        End If

                    Next
                End If
                CALCULA_TIEMPOS()
                CB_ING_CAUSA.SelectedItem = DATOS.DATOS_ORDENESRow("CAUSARIGEN")

                ADJUNTOSTableAdapter.FillByORDEN(ORDENESDataSet.ADJUNTOS, NROORDENINT)
                If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
                    BTNBorrar.Enabled = True
                    ' Size = New Size(1150, 512)
                    '   Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)
                    '  BTN_EXPANDIR.Visible = False
                Else
                    BTNBorrar.Enabled = False
                End If
                'FIJA EL ALTO DE LA TABLA DE ADJUNTOS
                For i = 0 To ORDENESDataSet.ADJUNTOS.Rows.Count - 1
                    DataGridView1.Rows(i).Height = 18
                Next i
        End Select
        Cursor = DefaultCursor
    End Sub
    Private Sub CB_ING_SECTOR_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CB_ING_SECTOR.SelectedIndexChanged

        CB_ING_FALLA.Items.Clear()
        CB_ING_CAUSA.Items.Clear()

        Select Case CB_ING_SECTOR.Text
            Case "CUADRILLA CABLEADO"
                CK_NOTIFICAR_ORDEN.Enabled = False
                CK_NOTIFICAR_ORDEN.AutoCheck = False
                If DATOS.DATOS_TRABAJORow("AREA") = "MDU" Then
                    SECTOR_FALLA = "CUADRILLAS MDU"
                Else
                    SECTOR_FALLA = "CUADRILLAS RED"
                End If
            Case "TECNICO"
                CK_NOTIFICAR_ORDEN.Enabled = False
                CK_NOTIFICAR_ORDEN.AutoCheck = False
                Select Case DATOS.DATOS_TRABAJORow("TIPOTRABAJO")
                    Case "MEDICION Y CONTROL DE FUENTE", "REEMPLAZO DE BATERIAS", "CONTROL BATERIAS", "REPARACION DE FUENTE", "REEMPLAZO DE FUENTE", "TRABAJOS DE RED", "CONTROL DE COMPONENTES DE FUENTE"
                        SECTOR_FALLA = "MANTENIMIENTO FUENTE"
                    Case Else
                        If DATOS.DATOS_TRABAJORow("AREA") = "MDU" Then
                            SECTOR_FALLA = "MANTENIMIENTO MDU"
                        Else
                            SECTOR_FALLA = "MANTENIMIENTO RED"
                        End If
                End Select
                Select Case CB_ING_TIPO.SelectedItem
                    Case "TAREA"
                    Case "OBRAS"
                    Case "CORRECTIVO"
                        SECTOR_FALLA = "DIAGNOSTICO"
                End Select
            Case Else
                CK_NOTIFICAR_ORDEN.Enabled = True
                CK_NOTIFICAR_ORDEN.AutoCheck = False
                SECTOR_FALLA = CB_ING_SECTOR.Text
        End Select
        'CARGA LAS FALLAS RECLACIONADAS CON EL SECTOR

        SECTORFALLATableAdapter.FillBySECTOR(ORDENESDataSet.SECTORFALLA, SECTOR_FALLA, CB_ING_TIPO.SelectedItem)

        If ORDENESDataSet.SECTORFALLA.Rows.Count > 0 Then

            For I = 0 To ORDENESDataSet.SECTORFALLA.Rows.Count - 1
                CB_ING_FALLA.Items.Add(ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA"))
                STANDARDDataGridView.Refresh()
            Next I
        End If
        'CARGA LOS FUNCIONARIOS DEL SECTOR OPERATIVO QUE FIGURA EN LA ORDEN
        COMB_CUADRILLA.Items.Clear()
        Me.FUNCIONARIOSTableAdapter.FillBySECTOR(ORDENESDataSet.FUNCIONARIOS, CB_ING_SECTOR.Text)
        If ORDENESDataSet.FUNCIONARIOS.Rows.Count > 0 Then
            For I = 0 To ORDENESDataSet.FUNCIONARIOS.Rows.Count - 1
                FUNCIONARIORow = ORDENESDataSet.FUNCIONARIOS.Rows(I)
                COMB_CUADRILLA.Items.Add(FUNCIONARIORow("NOMBRE"))
            Next I
        End If
    End Sub
    Private Sub CB_ING_FALLA_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CB_ING_FALLA.SelectedIndexChanged
        RELACION_FALLAACTIVIDADTableAdapter.FillByFALLA(ORDENESDataSet.RELACION_FALLAACTIVIDAD, CB_ING_FALLA.Text)

        If ORDENESDataSet.RELACION_FALLAACTIVIDAD.Rows.Count > 0 Then
            ACTIVIDAD_SELEC = ORDENESDataSet.RELACION_FALLAACTIVIDAD.Rows(0).Item("ACTIVIDAD")
            STANDARDTableAdapter.FillByACTIVIDAD(ORDENESDataSet.STANDARD, ACTIVIDAD_SELEC)
            '    Size = New Size(1150, 512)
        Else
            ORDENESDataSet.STANDARD.Clear()
            '    Size = New Size(750, 512)
        End If

        'Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)

        'If CB_ING_FALLA.Text = "ENTREGA/RETIRO (DEPOSITO)" Then
        '    BTN_MATERIALES.Visible = True
        'Else
        '    BTN_MATERIALES.Visible = False
        'End If

        MARCARTODO.Checked = False
        INDICE_CAUSASTableAdapter.FillByFALLA_AREAS(INDICESDataSet.INDICE_CAUSAS, CB_ING_FALLA.Text, DATOS.DATOS_TRABAJORow.AREA) ', DATOS.DATOS_TRABAJORow.AREA, CB_ING_FALLA.SelectedValue
        'OR (AREA2 = ?) And (DETALLE_FALLA = ?)
        'COMPLETA COMBO DE CAUSA
        'INDICE_CAUSASTableAdapter.FillByFALLA(INDICESDataSet.INDICE_CAUSAS, CB_ING_FALLA.Text)
        CB_ING_CAUSA.Items.Clear()

        For X = 0 To INDICESDataSet.INDICE_CAUSAS.Rows.Count - 1
            CB_ING_CAUSA.Items.Add(INDICESDataSet.INDICE_CAUSAS.Rows(X).Item("DETALLE_CAUSA"))
        Next

        Try
            If CB_ING_FALLA.Text = "RELEVAMIENTO" Then
                CB_ING_CAUSA.SelectedIndex = 0
                CB_ING_CAUSA.Select()
            ElseIf CB_ING_FALLA.Text = "MANTENIM. TRAMO DISTRIBUCIÓN" Then
                CB_ING_CAUSA.SelectedIndex = 1
                CB_ING_CAUSA.Select()
            ElseIf CB_ING_FALLA.Text = "LIMPIEZA DE TAP" Then
                CB_ING_CAUSA.SelectedIndex = 0
                CB_ING_CAUSA.Select()
            End If
            If INDICESDataSet.INDICE_CAUSAS.Rows.Count = 1 Then
                CB_ING_CAUSA.SelectedIndex = 0
                CB_ING_CAUSA.Select()
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub CARGA_COMBOS()
        SECTORESTableAdapter.Fill(ORDENESDataSet.SECTORES)
        For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
            CB_ING_SECTOR.Items.Add(ORDENESDataSet.SECTORES.Rows(I).Item("SECTOR"))
        Next
    End Sub
    Private Sub LBL_TIEMPOFINAL_TextChanged(sender As Object, e As EventArgs) Handles LBL_TIEMPOFINAL.TextChanged
        If TXT_ING_CLASEDEP.Text = "EST" Then
            LBL_TIEMPOAGENDA.Text = CInt(LBL_TIEMPOFINAL.Text) + TIEMPO_AGENDA
        Else
            LBL_TIEMPOAGENDA.Text = LBL_TIEMPOFINAL.Text
        End If
        LBL_TIEMPORESTANTE.Text = CAPACIDAD_DIA - LBL_TIEMPOAGENDA.Text
    End Sub
    Private Sub LBL_TIEMPOAGENDA_TextChanged(sender As Object, e As EventArgs) Handles LBL_TIEMPOAGENDA.TextChanged
        LBL_OCUPACION.Text = CInt((LBL_TIEMPOAGENDA.Text / CAPACIDAD_DIA) * 100)
        If LBL_OCUPACION.Text > 100 Then
            MsgBox("La ocupacion no puede exceder del 100 %, Modifique la cantidad de tareas", vbInformation)
        End If
    End Sub
    Private Sub MARCARTODO_CheckedChanged(sender As Object, e As EventArgs) Handles MARCARTODO.CheckedChanged
        Select Case MARCARTODO.Checked
            Case True
                For I = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
                    STANDARDRow = ORDENESDataSet.STANDARD.Rows(I)
                    STANDARDRow("SOLICITADO") = True
                    STANDARDRow("CANTORDEN") = STANDARDRow("CANTSTD")
                Next
            Case Else
                For I = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
                    STANDARDRow = ORDENESDataSet.STANDARD.Rows(I)
                    STANDARDRow("SOLICITADO") = False
                    STANDARDRow("CANTORDEN") = STANDARDRow("CANTSTD")
                Next
        End Select
        CALCULA_TIEMPOS()
    End Sub
    Private Sub CALCULA_TIEMPOS()

        Dim TIEMPO As Integer
        TIEMPO = 0
        For I = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
            STANDARDRow = ORDENESDataSet.STANDARD.Rows(I)
            If STANDARDRow("SOLICITADO") = True Then
                TIEMPO += STANDARDRow("CANTORDEN") * STANDARDRow("TIEMPOMIN")
            End If
        Next
        'ACTUALIZA ETIQUETAS

        LBL_TIEMPOFINAL.Text = TIEMPO
        LBL_TIEMPOFINAL.Refresh()
        If TIEMPO = 0 Then
            TIEMPO_AGENDA = 0
        Else
            TIEMPO_AGENDA = CInt(LBL_TIEMPOFINAL.Text) + CInt(LBL_TRASLADO.Text)
        End If
        LBL_TIEMPOAGENDA.Text = Str(TIEMPO_AGENDA)
        LBL_TIEMPOAGENDA.Refresh()

        LBL_OCUPACION.Text = CInt((TIEMPO_AGENDA / CAPACIDAD_DIA) * 100)
        'If LBL_OCUPACION.Text < 100 Then LBL_TESTIMADO.Text = 1
        LBL_OCUPACION.Refresh()

        LBL_TIEMPORESTANTE.Text = CInt(LBL_TIEMPORESTANTE.Text - TIEMPO_AGENDA)
        LBL_TIEMPORESTANTE.Refresh()
        ' DIBUJA_BARRAS()
        'MsgBox(FIJA_TIEMPOAGENDA & " + " & LBL_OCUPACION.Text)
        LBL_OCUPA_MOSTRAR.Text = FIJA_TIEMPOAGENDA + LBL_OCUPACION.Text
    End Sub
    Private Sub STANDARDDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles STANDARDDataGridView.CellContentClick
        If e.ColumnIndex = 3 Then
            If STANDARDDataGridView.Rows(e.RowIndex).Cells(3).Value = True Then
                STANDARDDataGridView.Rows(e.RowIndex).Cells(3).Value = False
                STANDARDDataGridView.Rows(e.RowIndex).Cells(4).Value = STANDARDDataGridView.Rows(e.RowIndex).Cells(2).Value
            Else
                STANDARDDataGridView.Rows(e.RowIndex).Cells(3).Value = True
                STANDARDDataGridView.Rows(e.RowIndex).Cells(4).Value = STANDARDDataGridView.Rows(e.RowIndex).Cells(2).Value
            End If
        End If
        If e.ColumnIndex = 4 Then

        End If
        CALCULA_TIEMPOS()
    End Sub
    Private Sub STANDARDDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles STANDARDDataGridView.CellEndEdit
        If e.ColumnIndex = 4 Then
            CALCULA_TIEMPOS()
        End If
    End Sub
    Private Sub LBL_TESTIMADO_TextChanged(sender As Object, e As EventArgs)
        'ING_TESTIMADO.Text = LBL_TESTIMADO.Text
    End Sub
    Private Sub BOT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BOT_GUARDAR.Click
        Cursor.Current = Cursors.WaitCursor
        BOT_GUARDAR.BackgroundImage = My.Resources.BTNGRAL_PRESS
        Dim H As Integer
        H = 0
        Dim TIEMPOPREVISTO As Integer
        If ORDENESDataSet.STANDARD.Rows.Count > 0 Then
            If TXT_ING_CLASEDEP.Text = "EST" Then
                TXT_TIEMPO_FINAL.Text = Format(((LBL_TIEMPOFINAL.Text + TIEMPO_TRASLADO) / CAPACIDAD_DIA) * 100, "##.#")
                'ORDEN_OCUPACION = ((((LBL_TIEMPOFINAL.Text) + TIEMPO_TRASLADO(1)) / CAPACIDAD_DIA) * 100)
            Else
                If LBL_TIEMPOFINAL.Text = "" Then
                    MsgBox("MARQUE LAS TAREAS DE LA ORDEN", vbInformation)
                    STANDARDDataGridView.Focus()
                    Exit Sub
                End If
                TXT_TIEMPO_FINAL.Text = Format(((((LBL_TIEMPOFINAL.Text) + TIEMPO_TRASLADO) / CAPACIDAD_DIA) * 100), "##.#")
                'ORDEN_OCUPACION = ((((LBL_TIEMPOFINAL.Text) + TIEMPO_TRASLADO(1)) / CAPACIDAD_DIA) * 100)
            End If
            TIEMPOPREVISTO = CInt(TXT_TIEMPO_FINAL.Text)

            'CARGA TAREAS
            For I = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
                STANDARDRow = ORDENESDataSet.STANDARD.Rows(I)
                If STANDARDRow("SOLICITADO") = True Then
                    H += 1
                    ACTIVIDAD(H) = STANDARDRow("ACTIVIDAD")
                    TAREA(H) = STANDARDRow("TAREA")
                    CANTSTD(H) = STANDARDRow("CANTSTD")
                    CANTORDEN(H) = STANDARDRow("CANTORDEN")
                    UNIDAD(H) = STANDARDRow("UNIDAD")
                    TIEMPOMIN(H) = STANDARDRow("TIEMPOMIN")
                    TIEMPOUNIT(H) = STANDARDRow("TIEMPOUNIT")
                End If
                CANTIDADREG = H
            Next

        End If
        '_____________________________________________________________________________________________________________
        'CARGA ORDEN
        Select Case ACCION_ORDEN

            Case "EDITAR"

                'VERIFICACIONDE INTEGRIDAD DE DATOS

                If CB_ING_SECTOR.Text = "" Then
                    MsgBox("Debe ingresar un SECTOR", vbInformation)
                    Exit Sub
                End If
                If CB_ING_FALLA.Text = "" Then
                    MsgBox("Debe ingresar un MOTIVO", vbInformation)
                    Exit Sub
                End If
                If CB_ING_CAUSA.Text = "" Then
                    MsgBox("Debe ingresar una CAUSA", vbInformation)
                    Exit Sub
                End If

                'If CB_ING_TIPO.SelectedItem <> "" Then
                '    MsgBox("Debe ingresar un TIPO de orden", vbInformation)
                '    Exit Sub
                'End If


                'DATOS TEMPORALES
                ESTADO.Text = "Editando ORDEN"
                ESTADO.Refresh()
                DATOS.DATOS_ORDENESRow("ATRIBUTO") = CB_ING_TIPO_RED.SelectedItem

                DATOS.DATOS_ORDENESRow("FECHAINGRESO") = Now.ToShortDateString
                DATOS.DATOS_ORDENESRow("FECHASOL") = Now.ToShortDateString
                DATOS.DATOS_ORDENESRow("FECHAINICESTIMADO") = TXT_ING_FECHAINICEST.Text

                DATOS.DATOS_ORDENESRow("TESTIMADO") = TXT_ING_TESTIMADO.Text
                DATOS.DATOS_ORDENESRow("TPREVISTO") = TIEMPOPREVISTO
                If NOTIFICAR_ORDEN Then
                    DATOS.DATOS_ORDENESRow("NOTIF") = True
                Else
                    DATOS.DATOS_ORDENESRow("NOTIF") = False
                End If
                DATOS.DATOS_ORDENESRow("ORDEN_OC") = TXT_OC.Text
                DATOS.DATOS_ORDENESRow("CUADRILLA") = COMB_CUADRILLA.Text
                STATUSANT = DATOS.DATOS_ORDENESRow("STATUS")
                DATOS.DATOS_ORDENESRow.CANTIDAD_SERVICIOS = CInt(TXT_CANT_OC.Text)
                Select Case COMB_CUADRILLA.Text
                    Case "", "SIN ASIGNAR"
                        DATOS.DATOS_ORDENESRow("STATUS") = STATUSANT
                    Case Else
                        If STATUSANT = "INGRESADOINT" Or STATUSANT = "INGORDINAL" Then
                            DATOS.DATOS_ORDENESRow("STATUS") = "ASIGNADO"
                            DATOS.DATOS_ORDENESRow("FECHA_ASIGNADA") = Today.ToShortDateString
                        End If
                End Select
                'DATOS DE DEPENDENCIA
                DATOS.DATOS_ORDENESRow("DEPENDENCIA") = TXT_ING_DEPENDENCIA.Text
                DATOS.DATOS_ORDENESRow("TIPODEP") = TXT_ING_TIPODEP.Text
                DATOS.DATOS_ORDENESRow("ORDENDEP") = TXT_ING_ORDENDEP.Text
                DATOS.DATOS_ORDENESRow("CLASEDEP") = TXT_ING_CLASEDEP.Text
                DATOS.DATOS_ORDENESRow("ORDORIGEN") = TXT_ING_ORDORIGEN.Text
                DATOS.DATOS_ORDENESRow.PROYECTO_ORDINAL = PROYECTO_ORDINAL
                'IDENTIFICACION DE LA ORDEN
                DATOS.DATOS_ORDENESRow("ID_GESTION") = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("ID_GESTION")
                DATOS.DATOS_ORDENESRow("ID_TRABAJO") = DATOS.ORDENESDataSet.TRABAJOS.Rows(DATOS.TRABAJOSBindingSource.Position).Item("Id_TRABAJO")


                DATOS.DATOS_ORDENESRow("NRO_ORDINAL") = CInt(TXT_ORDINAL.Text)

                DATOS.DATOS_ORDENESRow("TIPO") = CB_ING_TIPO.SelectedItem
                DATOS.DATOS_ORDENESRow.OBS_TRABAJO_A_REALIZAR = TXT_TRABAJO_A_REALIZAR.Text

                Select Case CB_ING_SECTOR.Text
                    Case "MANTENIMIENTO", "ENERGIA", "FIBRA", "DIAGNOSTICO", "TECNICO"
                        DATOS.DATOS_ORDENESRow("SECTOROPE") = "MANTENIMIENTO"
                        DATOS.DATOS_ORDENESRow("RECURSO") = "MANTENIMIENTO"
                    Case "CUADRILLA CABLEADO"
                        DATOS.DATOS_ORDENESRow("SECTOROPE") = "CUADRILLAS"
                        DATOS.DATOS_ORDENESRow("RECURSO") = "CUADRILLAS"
                    Case Else
                        DATOS.DATOS_ORDENESRow("SECTOROPE") = CB_ING_SECTOR.Text
                        DATOS.DATOS_ORDENESRow("RECURSO") = CB_ING_SECTOR.Text
                End Select

                Select Case SECTOR
                    Case "PLANIFICACION TECNICA", "JEFATURA", "GERENCIA"
                        DATOS.DATOS_ORDENESRow("SECTORGEN") = "PT"
                    Case "SUPERVISION"
                        DATOS.DATOS_ORDENESRow("SECTORGEN") = "SU"
                    Case "DESPACHO"
                        DATOS.DATOS_ORDENESRow("SECTORGEN") = "CO"
                    Case Else
                        DATOS.DATOS_ORDENESRow("SECTORGEN") = "SC"
                End Select
                DATOS.DATOS_ORDENESRow("PRIORIDAD") = CB_PRIORIDAD.Text

                'UBICACION
                ' DATOS.DATOS_ORDENESRow("NODO") = TXT_ING_NODO.Text

                'If Len(TXT_ING_ZONA.Text) = 1 Then
                '    DATOS.DATOS_ORDENESRow("ZONA") = "0" & TXT_ING_ZONA.Text
                'Else
                '    DATOS.DATOS_ORDENESRow("ZONA") = TXT_ING_ZONA.Text
                'End If


                DATOS.DATOS_ORDENESRow("MANZANA") = TXT_ING_MANZANA.Text
                If INGRESO_AREA = "FUENTES" Then
                    DATOS.DATOS_ORDENESRow("CALLE") = FUENTE_CALLE
                    DATOS.DATOS_ORDENESRow("ID_CALLE") = IND_CALLE.Text
                    DATOS.DATOS_ORDENESRow("NRO") = FUENTE_NRO
                Else
                    DATOS.DATOS_ORDENESRow("CALLE") = TXT_ING_CALLE.Text
                    DATOS.DATOS_ORDENESRow("ID_CALLE") = IND_CALLE.Text
                    DATOS.DATOS_ORDENESRow("NRO") = TXT_ING_NRO.Text
                End If

                DATOS.DATOS_ORDENESRow("INSTALACIONRUS") = TXT_ING_INSTALACIONRUS.Text
                DATOS.DATOS_ORDENESRow("INSTALACION") = TXT_ING_INSTALACION.Text

                'MOTIVOS DE GENERACION
                DATOS.DATOS_ORDENESRow("MOTIVOORIGEN") = CB_ING_FALLA.Text
                DATOS.DATOS_ORDENESRow("CAUSARIGEN") = CB_ING_CAUSA.Text

                'SOLICITUDES A ADMINISTARCION
                DATOS.DATOS_ORDENESRow("CREARORDINAL") = CHECK_CREARORDINAL.Checked
                If CHECK_COORDINAR.Checked Then DATOS.DATOS_ORDENESRow("STATUS") = "COORDINAR"
                DATOS.DATOS_ORDENESRow("COORDINAR") = CHECK_COORDINAR.Checked
                DATOS.DATOS_ORDENESRow("DOCUMENTO_FISICO") = CK_DOCUMENTO_FISICO.Checked
                ARMA_AFECTACION()
                DATOS.DATOS_ORDENESRow.AFECTACION = TOTAL_AFECTACION
                DATOS.ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)

                ESTADO.Text = "Editando TAREAS"
                ESTADO.Refresh()

                'BORRA LAS TAREAS DE LA ORDEN SELECCIONADA


                If DATOS.DATOS_ORDENESRow("NRO_ORDINAL") = 0 Then
                    TAREASTableAdapter.FillByordinal0(OrdenesDataSet1.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                Else
                    If DATOS.DATOS_ORDENESRow("STATUS") = "FINALIZADO" Then
                        TAREASTableAdapter.FillByordinalno0(OrdenesDataSet1.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                    Else
                        TAREASTableAdapter.FillByordinal0(OrdenesDataSet1.TAREAS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                    End If
                End If
                For H = 0 To OrdenesDataSet1.TAREAS.Rows.Count - 1
                    TAREAordenRow = OrdenesDataSet1.TAREAS.Rows(H)
                    TAREAordenRow.Delete()
                Next
                TAREASTableAdapter.Update(OrdenesDataSet1.TAREAS)
                If CANTIDADREG > 0 Then
                    For x = 1 To CANTIDADREG
                        NewTAREARow = ORDENESDataSet.TAREAS.NewTAREASRow
                        NewTAREARow("ORDINAL") = 0
                        NewTAREARow("NRO_ORDENINT") = DATOS.ORDENESDataSet.ORDENES.Rows(DATOS.ORDENESBindingSource.Position).Item("NRO_ORDENINT")
                        NewTAREARow("NRO_AGENDAMIENTO") = 0
                        NewTAREARow("STATUS") = "INGRESADO"
                        NewTAREARow("ACTIVIDADDESC") = ACTIVIDAD(x)
                        NewTAREARow("TAREADESC") = TAREA(x)
                        NewTAREARow("CANTSTD") = CANTORDEN(x)
                        NewTAREARow("CANTREAL") = 0
                        NewTAREARow("TIEMPOSTD") = TIEMPOUNIT(x)
                        NewTAREARow("TIEMPOPREV") = CANTORDEN(x) * TIEMPOUNIT(x)
                        NewTAREARow("TIEMPOREAL") = 0
                        NewTAREARow("UNIDAD") = UNIDAD(x)

                        ORDENESDataSet.TAREAS.AddTAREASRow(NewTAREARow)
                    Next x

                    TAREASTableAdapter.Update(ORDENESDataSet.TAREAS)
                Else
                    ' MsgBox("La orden cargada no tiene definido un STANDARD")
                End If

                ESTADO.Text = "Ingresando HISTORICO"
                ESTADO.Refresh()

                'CARGA HISTORICO

                TIPOREGISTRO = "ORDEN"
                Select Case COMB_CUADRILLA.Text
                    Case "", "SIN ASIGNAR"
                        DATOS.DATOS_HIS_STATUSACTUAL = STATUSANT
                    Case Else
                        DATOS.DATOS_HIS_STATUSACTUAL = "ASIGNADO"
                End Select
                If NROORDINAL <> CInt(TXT_ORDINAL.Text) Then
                    DATOS.DATOS_HIS_DETALLE = "Edición Orden - SE MODIFICA NRO ORDINAL"
                Else
                    DATOS.DATOS_HIS_DETALLE = "Edición Orden"
                End If
                'TIPOREGISTRO = ""
                DATOS.CARGA_HISTORICO()

                ESTADO.Text = "Editando OBSERVACIONES"
                ESTADO.Refresh()

                'CARGA OBSERVACIONES
                OBESERVACIONESTableAdapter.FillByNROORDENINT(DATOS.ORDENESDataSet.OBESERVACIONES, DATOS.ORDENESDataSet.ORDENES.Rows(DATOS.ORDENESBindingSource.Position).Item("NRO_ORDENINT"))
                If DATOS.ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    OBSERVACIONESRow = DATOS.ORDENESDataSet.OBESERVACIONES.Rows(0)
                    OBSERVACIONESRow("OBSORIGEN") = TXT_ING_OBSERVACIONES.Text
                    OBESERVACIONESTableAdapter.Update(OBSERVACIONESRow)
                Else
                    NewOBSERVACIONESRow = DATOS.ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
                    NewOBSERVACIONESRow("NRO_ORDENINT") = TXT_ORDENINT.Text
                    NewOBSERVACIONESRow("NROORDINAL") = 0
                    NewOBSERVACIONESRow("OBSORIGEN") = TXT_ING_OBSERVACIONES.Text

                    DATOS.ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACIONESRow)
                    DATOS.OBESERVACIONESTableAdapter.Update(NewOBSERVACIONESRow)

                End If

                'ENVIA MENSAJE 
                MENSAJE = ""
                If CK_NOTIFICAR_ORDEN.Checked = True Then
                    ESTADO.Text = "Enviando MENSAJE"
                    ESTADO.Refresh()
                    SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, CB_ING_SECTOR.Text)
                    Dim DESTINATARIO_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")

                    SECTORESTableAdapter.FillBySECTOR(OrdenesDataSet1.SECTORES, SECTOR)
                    Dim REMITENTE_SECTOR As String = OrdenesDataSet1.SECTORES.Rows(0).Item("EMAIL")

                    MENSAJE = "Hola, " & Split(COMB_CUADRILLA.Text, " ")(0) & ". " & vbNewLine
                    MENSAJE += "Se genera la orden " & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & " con motivo " & CB_ING_FALLA.Text & ", asignado. "
                    If TXT_ING_OBSERVACIONES.Text <> "" Then
                        MENSAJE += vbNewLine & vbNewLine & "Detalle de la orden:" & vbNewLine & "    "
                        MENSAJE += TXT_ING_OBSERVACIONES.Text
                    End If
                    ENVIAR_EMAIL(CB_PRIORIDAD.Text, DESTINATARIO_SECTOR, "ORDEN ASIGNADA", MENSAJE, REMITENTE, REMITENTE_SECTOR)
                End If

                ESTADO.Text = "FIN PROCESO"
                ESTADO.Refresh()

                'RECARGA LAS ORDENES PARA EL TRABAJO SELECCIONADO
                DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, DATOS.DATOS_TRABAJORow("Id_TRABAJO"))
                DATOS.ORDENESBindingSource.MoveLast()
                DATOS.CARGA_VALORESORDENES()


'_____________________________________________________________________________________________
            Case "NUEVO"

                ESTADO.Text = "Ingresando ORDEN"
                ESTADO.Refresh()


                'VERIFICACIONDE INTEGRIDAD DE DATOS
                If IND_CALLE.Text = "" Then
                    If TXT_ING_CALLE.Text = "" Then
                        'acepta que no tiene calle
                        IND_CALLE.Text = 0
                    Else
                        MsgBox("La calle no tiene asociado un indice" & vbNewLine & "Haga Click en CALLE y seleccione la buscada")
                        Exit Sub
                    End If
                End If
                If CB_ING_SECTOR.Text = "" Then
                    MsgBox("Debe ingresar un SECTOR", vbInformation)
                    Exit Sub
                End If
                If CB_ING_FALLA.Text = "" Then
                    MsgBox("Debe ingresar un MOTIVO", vbInformation)
                    Exit Sub
                End If
                If CB_ING_CAUSA.Text = "" Then
                    MsgBox("Debe ingresar una CAUSA", vbInformation)
                    Exit Sub
                End If
                'If CB_ING_TIPO.SelectedItem = "" Then
                '    MsgBox("Debe ingresar un TIPO de orden", vbInformation)
                '    Exit Sub
                'End If

                'ACTUALIZA LOS DATOS DE DEPENDENCIA DE LA ORDEN SELECCIONADA
                DATOS.ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)

                'CARGA NUEVA ORDEN
                NewORDENESRow = DATOS.ORDENESDataSet.ORDENES.NewORDENESRow

                'DATOS TEMPORALES
                NewORDENESRow("FECHAINGRESO") = Now.ToShortDateString
                NewORDENESRow("FECHASOL") = Now.ToShortDateString
                NewORDENESRow("FECHAINICESTIMADO") = TXT_ING_FECHAINICEST.Text
                If TXT_ING_TESTIMADO.Text <> "" Then
                    NewORDENESRow("TESTIMADO") = TXT_ING_TESTIMADO.Text
                Else
                    NewORDENESRow("TESTIMADO") = 1
                End If
                NewORDENESRow("TPREVISTO") = TIEMPOPREVISTO
                NewORDENESRow("CUADRILLA") = COMB_CUADRILLA.Text
                NewORDENESRow.GEST_SOLICITADO = SOLICITANTE
                'DATOS DE DEPENDENCIA
                NewORDENESRow("DEPENDENCIA") = TXT_ING_DEPENDENCIA.Text
                NewORDENESRow("TIPODEP") = TXT_ING_TIPODEP.Text
                NewORDENESRow("ORDENDEP") = TXT_ING_ORDENDEP.Text
                NewORDENESRow("CLASEDEP") = TXT_ING_CLASEDEP.Text
                NewORDENESRow("ORDORIGEN") = TXT_ING_ORDORIGEN.Text
                NewORDENESRow.CANTIDAD_SERVICIOS = CInt(TXT_CANT_OC.Text)
                'IDENTIFICACION DE LA ORDEN
                NewORDENESRow("ID_GESTION") = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("iD_GESTION")
                NewORDENESRow("ID_TRABAJO") = DATOS.ORDENESDataSet.TRABAJOS.Rows(DATOS.TRABAJOSBindingSource.Position).Item("Id_TRABAJO")
                NewORDENESRow("ATRIBUTO") = CB_ING_TIPO_RED.SelectedItem
                NewORDENESRow("NRO_ORDINAL") = 0
                NewORDENESRow("ORDEN_OC") = TXT_OC.Text
                NewORDENESRow.PROYECTO_ORDINAL = PROYECTO_ORDINAL
                If COMB_CUADRILLA.Text = "" Or COMB_CUADRILLA.Text = "SIN ASIGNAR" Then
                    NewORDENESRow("STATUS") = "INGRESADOINT"
                Else
                    NewORDENESRow("STATUS") = "ASIGNADO"
                    NewORDENESRow("FECHA_ASIGNADA") = Today.ToShortDateString
                End If

                STATUSANT = "INGRESADOINT"
                NewORDENESRow("TIPO") = CB_ING_TIPO.SelectedItem

                Select Case CB_ING_SECTOR.Text
                    Case "ENERGIA", "FIBRA", "DIAGNOSTICO", "TECNICO"
                        NewORDENESRow.SECTOROPE = "MANTENIMIENTO"
                        NewORDENESRow.RECURSO = "MANTENIMIENTO"
                    Case "CUADRILLA CABLEADO"
                        NewORDENESRow.SECTOROPE = "CUADRILLAS"
                        NewORDENESRow.RECURSO = "CUADRILLAS"
                    Case Else
                        NewORDENESRow.SECTOROPE = CB_ING_SECTOR.Text
                        NewORDENESRow.RECURSO = CB_ING_SECTOR.Text
                End Select

                Select Case SECTOR
                    Case "PLANIFICACION TECNICA", "GERENCIA"
                        NewORDENESRow("SECTORGEN") = "PT"
                    Case "SUPERVISION", "JEFATURA"
                        NewORDENESRow("SECTORGEN") = "SU"
                    Case "DESPACHO"
                        NewORDENESRow("SECTORGEN") = "CO"
                    Case Else
                        NewORDENESRow("SECTORGEN") = "SC"
                End Select
                NewORDENESRow("PRIORIDAD") = CB_PRIORIDAD.Text

                Select Case DATOS.DATOS_TRABAJORow("AREA")
                    Case "RED"
                        NewORDENESRow("CARPETA") = ""
                        NewORDENESRow("SECTORDESTINO") = "RED"
                        SECTORDESTINO = "RED"
                    Case "MDU"
                        Select Case CB_ING_SECTOR.Text
                            Case "OBRA CIVIL"
                                NewORDENESRow("CARPETA") = ""
                                NewORDENESRow("SECTORDESTINO") = "RED"
                                SECTORDESTINO = "RED"
                            Case Else
                                NewORDENESRow("CARPETA") = BUSCA_PRIM
                                NewORDENESRow("SECTORDESTINO") = "MDU"
                                SECTORDESTINO = "MDU"
                        End Select

                End Select

                'UBICACION
                NewORDENESRow("NODO") = DATOS.DATOS_TRABAJORow.NODO
                NewORDENESRow.OBS_TRABAJO_A_REALIZAR = TXT_TRABAJO_A_REALIZAR.Text
                If Len(DATOS.DATOS_TRABAJORow.ZONA) = 1 Then
                    NewORDENESRow("ZONA") = "0" & DATOS.DATOS_TRABAJORow.ZONA
                Else
                    NewORDENESRow("ZONA") = DATOS.DATOS_TRABAJORow.ZONA
                End If
                NewORDENESRow("MANZANA") = TXT_ING_MANZANA.Text
                NewORDENESRow("CALLE") = TXT_ING_CALLE.Text
                Try
                    NewORDENESRow("ID_CALLE") = IND_CALLE.Text
                Catch ex As Exception
                    INDICE_CALLESDataGridView.Visible = True
                    Exit Sub
                End Try

                NewORDENESRow("NRO") = TXT_ING_NRO.Text

                NewORDENESRow("INSTALACION") = TXT_ING_INSTALACION.Text
                NewORDENESRow("INSTALACIONRUS") = TXT_ING_INSTALACIONRUS.Text


                If ACCESO_DESDE = "FUENTES" Then
                    NewORDENESRow("AFECTACION") = FUENTE_AFECTACION
                Else
                    ARMA_AFECTACION()
                    NewORDENESRow("AFECTACION") = TOTAL_AFECTACION
                End If

                'MOTIVOS DE GENERACION
                NewORDENESRow("MOTIVOORIGEN") = CB_ING_FALLA.Text
                NewORDENESRow("CAUSARIGEN") = CB_ING_CAUSA.Text

                'SOLICITUDES A ADMINISTRACION
                NewORDENESRow("CREARORDINAL") = CHECK_CREARORDINAL.Checked
                If CHECK_COORDINAR.Checked Then NewORDENESRow("STATUS") = "COORDINAR"

                NewORDENESRow("COORDINAR") = CHECK_COORDINAR.Checked

                'REGISTRO DE SOLICITUDES EXTERNAS
                NewORDENESRow("SOLICITANTE") = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("SOLICITANTE")
                NewORDENESRow("GENERADOR") = FULLNOMBRE
                NewORDENESRow("CONTACTONOMBRE") = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("NOMBRECONTACTO")
                NewORDENESRow("CONTACTOTEL") = DATOS.ORDENESDataSet.GESTION.Rows(DATOS.GESTIONBindingSource.Position).Item("TELEFCONTACTO")
                NewORDENESRow("DOCUMENTO_FISICO") = CK_DOCUMENTO_FISICO.Checked

                If NOTIFICAR_ORDEN Then
                    NewORDENESRow("NOTIF") = True
                Else
                    NewORDENESRow("NOTIF") = False
                End If
                'AGREGA REGISTRO
                DATOS.ORDENESDataSet.ORDENES.AddORDENESRow(NewORDENESRow)
                DATOS.ORDENESTableAdapter.Update(NewORDENESRow)

                'RECARGA LAS ORDENES PARA EL TRABAJO SELECCIONADO
                DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, DATOS.DATOS_TRABAJORow("Id_TRABAJO"))
                DATOS.ORDENESBindingSource.MoveLast()
                DATOS.CARGA_VALORESORDENES()

                'CARGA OBSERVACIONES
                ESTADO.Text = "Ingresando OBSERVACIONES"
                ESTADO.Refresh()
                NewOBSERVACIONESRow = DATOS.ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
                NewOBSERVACIONESRow("NRO_ORDENINT") = DATOS.ORDENESDataSet.ORDENES.Rows(DATOS.ORDENESBindingSource.Position).Item("NRO_ORDENINT")
                NewOBSERVACIONESRow("NROORDINAL") = 0
                NewOBSERVACIONESRow("OBSORIGEN") = TXT_ING_OBSERVACIONES.Text

                DATOS.ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACIONESRow)
                DATOS.OBESERVACIONESTableAdapter.Update(NewOBSERVACIONESRow)

                'CARGA TAREAS
                ESTADO.Text = "Ingresando TAREAS"
                ESTADO.Refresh()

                If CANTIDADREG > 0 Then
                    For x = 1 To CANTIDADREG
                        NewTAREARow = DATOS.OrdenesDataSet3.TAREAS.NewTAREASRow
                        NewTAREARow("ORDINAL") = 0
                        NewTAREARow("NRO_ORDENINT") = DATOS.ORDENESDataSet.ORDENES.Rows(DATOS.ORDENESBindingSource.Position).Item("NRO_ORDENINT")
                        NewTAREARow("NRO_AGENDAMIENTO") = 0
                        NewTAREARow("STATUS") = "INGRESADO"
                        NewTAREARow("ACTIVIDADDESC") = ACTIVIDAD(x)
                        NewTAREARow("TAREADESC") = TAREA(x)
                        NewTAREARow("CANTSTD") = CANTORDEN(x)
                        NewTAREARow("CANTREAL") = 0
                        NewTAREARow("TIEMPOSTD") = TIEMPOUNIT(x)
                        NewTAREARow("TIEMPOPREV") = CANTORDEN(x) * TIEMPOUNIT(x)
                        NewTAREARow("TIEMPOREAL") = 0
                        NewTAREARow("UNIDAD") = UNIDAD(x)

                        DATOS.OrdenesDataSet3.TAREAS.AddTAREASRow(NewTAREARow)
                    Next x

                    DATOS.TAREASTableAdapter.Update(DATOS.OrdenesDataSet3.TAREAS)
                Else
                    ' MsgBox("La orden cargada no tiene definido un STANDARD")
                End If


                'CARGA HISTORICO
                ESTADO.Text = "Ingresando HISTORICO"
                ESTADO.Refresh()
                TIPOREGISTRO = "ORDEN"
                DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADOINT"
                DATOS.DATOS_HIS_DETALLE = "Ingreso nueva Orden"
                DATOS.CARGA_HISTORICO()

                If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
                    AGREGAR_ARCHIVO()
                End If

                'ENVIA MENSAJE 
                MENSAJE = ""
                If CK_NOTIFICAR_ORDEN.Checked Then
                    ESTADO.Text = "Enviando MENSAJE"
                    ESTADO.Refresh()
                    FUNCIONARIOSTableAdapter.FillByNOMBRE(ORDENESDataSet.FUNCIONARIOS, Trim(COMB_CUADRILLA.Text))
                    SECTORESTableAdapter.FillBySECTOR(OrdenesDataSet1.SECTORES, SECTOR)
                    Dim REMITENTE_SECTOR As String = OrdenesDataSet1.SECTORES.Rows(0).Item("EMAIL")

                    SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, ORDENESDataSet.FUNCIONARIOS.Rows(0).Item("SECTOR"))
                    Dim DESTINATARIO_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")

                    MENSAJE = "Hola, " & Split(COMB_CUADRILLA.Text, " ")(0) & ". " & vbNewLine
                    MENSAJE += "Se genera la orden " & DATOS.ORDENESDataSet.ORDENES.Rows(DATOS.ORDENESBindingSource.Position).Item("NRO_ORDENINT") & " con motivo " & CB_ING_FALLA.Text & ", asignado. "
                    If TXT_ING_OBSERVACIONES.Text <> "" Then
                        MENSAJE += vbNewLine & vbNewLine & "Detalle de la orden:" & vbNewLine & "    "
                        MENSAJE += TXT_ING_OBSERVACIONES.Text
                    End If
                    ENVIAR_EMAIL(CB_PRIORIDAD.Text, DESTINATARIO_SECTOR, "NUEVA ORDEN ASIGNADA", MENSAJE, REMITENTE, REMITENTE_SECTOR)
                End If
                ESTADO.Text = "FIN PROCESO"
                ESTADO.Refresh()
        End Select

        'PROCESO DE ASIGNACION DE ORDENES
        Cursor = Cursors.WaitCursor
        Dim MENSAJEADJUNTO As String
        'ENVIA MENSAJE 
        Select Case ACCION_ORDEN
            Case "NUEVO"
                If COMB_CUADRILLA.Text <> "SIN ASIGNAR" Then
                    'CARGA HISTORICO
                    DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADOINT"
                    DATOS.DATOS_HIS_CAUSA = "ASIGNACION DE ORDEN"
                    DATOS.DATOS_HIS_DETALLE = "ASIGNADO A: " & COMB_CUADRILLA.Text
                    DATOS.CARGA_HISTORICO()

                    'ENVIA MENSAJE
                    DATOS.DATOS_MJE_ASUNTO = "ASIGNACION DE ORDEN"
                    DATOS.DATOS_MJE_DESTINONOMBRE = COMB_CUADRILLA.Text
                    DATOS.DATOS_MJE_DESTINOSECTOR = ""
                    DATOS.DATOS_MJE_NROORDENASOC = NROORDENINT

                    If FECHAAGENDA <> "" Then
                        MENSAJEADJUNTO = "LA MISMA SE ENCUENTRA COORDINADA PARA EL DIA : " & FECHAAGENDA
                    Else
                        MENSAJEADJUNTO = ""
                    End If

                    DATOS.DATOS_MJE_MENSAJE = "SE LE A ASIGNADO LA ORDEN INTERNA DE " & SECTORDESTINO & " NRO: " & NROORDENINT & " CON MOTIVO DE ORIGEN " & CB_ING_FALLA.Text & vbNewLine _
                    & MENSAJEADJUNTO & vbNewLine& & "[CALLE " & TXT_ING_CALLE.Text & "]" & " [NRO " & TXT_ING_NRO.Text & "]" & "---" & " [NODO " & TXT_ING_NODO.Text & " ZONA " & DATOS.DATOS_TRABAJORow.ZONA & "]"
                    Cursor = DefaultCursor
                End If
            Case "EDITAR"
                If COMB_CUADRILLA.Text <> ASIGNADOA Then

                    If COMB_CUADRILLA.Text = "SIN ASIGNAR" Then
                        'CARGA HISTORICO
                        If COMB_CUADRILLA.Text <> ASIGNADOA Then
                            DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADOINT"
                            DATOS.DATOS_HIS_CAUSA = "DESASIGNACION DE ORDEN"
                            DATOS.DATOS_HIS_DETALLE = "ASIGNADO A: SIN ASIGNAR"
                            DATOS.CARGA_HISTORICO()
                        End If

                    Else
                        'CARGA HISTORICO
                        DATOS.DATOS_HIS_STATUSACTUAL = "INGRESADOINT"
                        DATOS.DATOS_HIS_CAUSA = "ASIGNACION DE ORDEN"
                        DATOS.DATOS_HIS_DETALLE = "ASIGNADO A: " & COMB_CUADRILLA.Text
                        DATOS.CARGA_HISTORICO()

                        'ENVIA MENSAJE ASIGNACION
                        If FECHAAGENDA <> "" Then
                            MENSAJEADJUNTO = "LA MISMA SE ENCUENTRA COORDINADA PARA EL DIA : " & FECHAAGENDA
                        Else
                            MENSAJEADJUNTO = ""
                        End If

                        DATOS.DATOS_MJE_MENSAJE = "SE LE A ASIGNADO LA ORDEN INTERNA DE " & SECTORDESTINO & " NRO: " & NROORDENINT & " CON MOTIVO DE ORIGEN " & CB_ING_FALLA.Text & vbNewLine _
                        & MENSAJEADJUNTO & vbNewLine& & "[CALLE " & TXT_ING_CALLE.Text & "]" & " [NRO " & TXT_ING_NRO.Text & "]" & "---" & " [NODO " & TXT_ING_NODO.Text & " ZONA " & DATOS.DATOS_TRABAJORow.ZONA & "]"
                        DATOS.ENVIA_MENSAJE()
                        Cursor = DefaultCursor
                    End If
                End If
        End Select
        If BOT_GUARDAR.Text = "REACTIVAR" Then
            'AL REACTIVAR UNA ORDEN:
            '- GRABAR INCIDENCIA AL MOMENTO DE REACTIVAR EN HISTORICO DE LA ORDEN
            TIPOREGISTRO = "ORDEN"
            DATOS.DATOS_HIS_STATUSACTUAL = "ORDEN REACTIVADA"
            DATOS.DATOS_HIS_CAUSA = "REACTIVACION MANUAL"
            DATOS.DATOS_HIS_DETALLE = "CORRECCION"
            DATOS.CARGA_HISTORICO()
            '- CAMBIAR EL STATUS A ASIGNADO
            DATOS.DATOS_ORDENESRow.STATUS = "ASIGNADO"
            DATOS.DATOS_ORDENESRow.MOTIVOCIERRE = ""
            DATOS.DATOS_ORDENESRow.CAUSACIERRE = ""
            DATOS.DATOS_ORDENESRow("FECHAINICIO") = DBNull.Value
            DATOS.DATOS_ORDENESRow("FECHAFIN") = DBNull.Value
            DATOS.DATOS_ORDENESRow("FECHACIERRE") = DBNull.Value

            '- FECHA DE REASINGACION NUEVA.
            DATOS.DATOS_ORDENESRow.FECHA_ASIGNADA = Now
            DATOS.ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)   'ACTUALIZA DATOS

            '- MANDAR MAIL AUTOMATICO, MOTIVO DEACTIVACION DE ORDEN.
            MENSAJE = ""
            SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, DATOS.DATOS_ORDENESRow.SECTOROPE)
            Dim DESTINATARIO_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")
            SECTORESTableAdapter.FillBySECTOR(OrdenesDataSet1.SECTORES, SECTOR)
            Dim REMITENTE_SECTOR As String = OrdenesDataSet1.SECTORES.Rows(0).Item("EMAIL")

            MENSAJE = "Hola, " & Split(DATOS.DATOS_ORDENESRow.CUADRILLA, " ")(0) & ". " & vbNewLine
            MENSAJE += FULLNOMBRE & " le ha REACTIVADO la orden " & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & "."
            MENSAJE += vbNewLine & "Se ha marcado corregir error en: " & TXT_ING_OBSERVACIONES.Text
            If DATOS.DATOS_ORDENESRow.DOCUMENTO_FISICO = True Then
                MENSAJE += vbNewLine & "La orden tiene documentacion adjunta en formato FISICO."
            Else
                MENSAJE += vbNewLine & "La orden contiene documentacion adjunta en formato DIGITAL."
            End If
            ENVIAR_EMAIL(DATOS.DATOS_ORDENESRow.PRIORIDAD, DESTINATARIO_SECTOR, "ORDEN REACTIVADA", MENSAJE, REMITENTE, REMITENTE_SECTOR)
        End If

        'DATOS.CONDINI_INGORDEN()
        Cursor.Current = DefaultCursor
        DATOS.Enabled = True
        Me.Close()
    End Sub
    Private Sub ARMA_AFECTACION()
        Dim AFECTACION_VALUE As String
        TOTAL_AFECTACION = ""
        If TXT_AFECTACION.Text.Contains(".") Then
            AFECTACION_VALUE = TXT_AFECTACION.Text.Replace(".", ",")
        Else
            AFECTACION_VALUE = TXT_AFECTACION.Text
        End If
        ZONA_AFECTACION = Split(AFECTACION_VALUE, ",")
        For A = 0 To ZONA_AFECTACION.Length - 1
            Select Case Len(Trim(ZONA_AFECTACION(A)))
                Case 1
                    AFECTACION_ITEM(A) = Trim(DATOS.DATOS_GESTIONRow.NODO) & "0" & Trim(ZONA_AFECTACION(A))
                Case 2
                    If IsNumeric(Mid(Trim(ZONA_AFECTACION(A)), 1, 1)) = False Then
                        AFECTACION_ITEM(A) = Trim(DATOS.DATOS_GESTIONRow.NODO) & "0" & Mid(Trim(ZONA_AFECTACION(A)), 2, 1)
                    Else
                        AFECTACION_ITEM(A) = Trim(DATOS.DATOS_GESTIONRow.NODO) & Trim(ZONA_AFECTACION(A))
                    End If
                Case 3
                    If IsNumeric(Mid(Trim(ZONA_AFECTACION(A)), 1, 2)) = False Then
                        If Mid(Trim(ZONA_AFECTACION(A)), 1, 2) = "ZB" Then
                            AFECTACION_ITEM(A) = Mid(Trim(ZONA_AFECTACION(A)), 1, 2) & "0" & Mid(Trim(ZONA_AFECTACION(A)), 3, 1)
                        Else
                            AFECTACION_ITEM(A) = ZONA_AFECTACION(A)
                        End If
                    End If
                Case 4
                    If Mid(Trim(ZONA_AFECTACION(A)), 1, 3) = "CAB" Then
                        AFECTACION_ITEM(A) = Mid(Trim(ZONA_AFECTACION(A)), 1, 3) = "CAB" & "0" & Mid(Trim(ZONA_AFECTACION(A)), 4, 1)
                    Else
                        AFECTACION_ITEM(A) = Trim(ZONA_AFECTACION(A))
                    End If
                Case 5
                    AFECTACION_ITEM(A) = Trim(ZONA_AFECTACION(A))
            End Select

            If A = ZONA_AFECTACION.Length - 1 Then
                TOTAL_AFECTACION += AFECTACION_ITEM(A)
            Else
                TOTAL_AFECTACION += AFECTACION_ITEM(A) & ","
            End If
        Next
    End Sub
    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        DATOS.Enabled = True
        Close()
        Dispose()
    End Sub
    'Private Sub DIBUJA_BARRAS()
    '    Dim GRILLA As Graphics = PIC_BANNER.CreateGraphics()
    '    Dim HORACAP As Integer
    '    HORACAP = CInt(LBL_CAPACIDADDIA.Text / 60)

    '    Dim BARRABLANCA As New Pen(Color.Gray, 54)
    '    Dim BARRAGRIS As New Pen(Color.DimGray, 50)
    '    Dim BARRAVERDE As New Pen(Color.DarkOliveGreen, 50)
    '    Dim LINEABLANCA As New Pen(Color.Gray, 1)
    '    Dim BARRAROJA As New Pen(Color.DarkRed, 50)

    '    If LBL_TIEMPOAGENDA.Text > LBL_CAPACIDADDIA.Text Then LBL_TIEMPOAGENDA.Text = LBL_CAPACIDADDIA.Text
    '    If TIEMPORESTANTE < 0 Then TIEMPORESTANTE = 0

    '    'GRILLA.DrawLine(BARRABLANCA, 360, 495, 360, (495 - 2 - CInt(LBL_CAPACIDADDIA.Text / 4)))
    '    GRILLA.DrawLine(BARRAGRIS, 360, 495, 360, (495 - CInt(LBL_CAPACIDADDIA.Text / 4)))
    '    GRILLA.DrawLine(BARRAVERDE, 360, 495, 360, (495 - CInt(TIEMPORESTANTE / 4)))
    '    For I = 0 To HORACAP - 1
    '        GRILLA.DrawLine(LINEABLANCA, 335, 495 - I * 15, 385, 495 - I * 15)
    '    Next
    '    GRILLA.DrawLine(BARRAROJA, 360, 495, 360, (495 - CInt(LBL_TIEMPOAGENDA.Text / 4)))
    '    'LINEAS DE ESCALA

    'End Sub
    'Private Sub STANDARD_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    DIBUJA_BARRAS()
    'End Sub
    Private Sub ING_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_ING_CALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
        ' Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = TXT_ING_CALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        INDICE_CALLESBindingSource.DataSource = VISTACALLE
        INDICE_CALLESDataGridView.Columns(0).Visible = False
    End Sub
    Private Sub ING_CALLE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ING_CALLE.KeyDown
        If TXT_ING_CALLE.Text.Length > 2 Then
            INDICE_CALLESDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Enter Then
            If INDICE_CALLESDataGridView.Rows.Count = 1 Then
                TXT_ING_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                INDICE_CALLESDataGridView.Visible = False
                TXT_ING_NRO.Focus()
            Else
                TXT_ING_CALLE.Text = ""
                IND_CALLE.Text = "0"
                INDICE_CALLESDataGridView.Visible = False
                TXT_ING_NRO.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            TXT_ING_CALLE.Text = ""
            IND_CALLE.Text = "0"
            INDICE_CALLESDataGridView.Visible = False
            TXT_ING_NRO.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            INDICE_CALLESDataGridView.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
            IND_CALLE.Text = 0
            TXT_ING_CALLE.Text = ""
        End If
    End Sub
    Private Sub TXT_ING_CALLE_DoubleClick(sender As Object, e As EventArgs) Handles TXT_ING_CALLE.DoubleClick
        If INDICE_CALLESDataGridView.Visible = False Then
            INDICE_CALLESDataGridView.Visible = True
            INDICE_CALLESDataGridView.Columns(0).Visible = False
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles INDICE_CALLESDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_ING_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
            TXT_ING_NRO.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            TXT_ING_CALLE.Text = ""
            IND_CALLE.Text = "0"
            INDICE_CALLESDataGridView.Visible = False
            TXT_ING_NRO.Focus()
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.DoubleClick
        If INDICE_CALLESDataGridView.RowCount > 0 Then
            TXT_ING_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    'Private Sub BTNAgregarINST_Click(sender As Object, e As EventArgs)
    '    If TXT_ING_INSTALACIONRUS1.Visible = False Then
    '        TXT_ING_INSTALACIONRUS1.Visible = True
    '        BTNQuitarINST.Visible = True
    '    ElseIf TXT_ING_INSTALACIONRUS2.Visible = False And TXT_ING_INSTALACIONRUS1.Visible = True Then
    '        TXT_ING_INSTALACIONRUS2.Visible = True
    '    ElseIf TXT_ING_INSTALACIONRUS3.Visible = False And TXT_ING_INSTALACIONRUS2.Visible = True Then
    '        TXT_ING_INSTALACIONRUS3.Visible = True
    '        BTNAgregarINST.Visible = False
    '    End If
    'End Sub
    'Private Sub BTNQuitarINST_Click(sender As Object, e As EventArgs)
    '    If TXT_ING_INSTALACIONRUS1.Visible And TXT_ING_INSTALACIONRUS2.Visible = False Then
    '        TXT_ING_INSTALACIONRUS1.Visible = False
    '        BTNQuitarINST.Visible = False
    '        BTNAgregarINST.Visible = True
    '    ElseIf TXT_ING_INSTALACIONRUS2.Visible And TXT_ING_INSTALACIONRUS1.Visible And TXT_ING_INSTALACIONRUS3.Visible = False Then
    '        TXT_ING_INSTALACIONRUS2.Visible = False
    '        BTNAgregarINST.Visible = True
    '    ElseIf TXT_ING_INSTALACIONRUS3.Visible And TXT_ING_INSTALACIONRUS2.Visible Then
    '        TXT_ING_INSTALACIONRUS3.Visible = False
    '        BTNAgregarINST.Visible = True
    '    End If
    'End Sub
    Private Sub INDICE_CALLESDataGridView_LostFocus(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.LostFocus
        INDICE_CALLESDataGridView.Visible = False
    End Sub
    Private Sub BTNBorrar_Click(sender As Object, e As EventArgs) Handles BTNBorrar.Click
        Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
        Dim CANTIDADORDENES As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO")).Count
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                File.Delete(ORDENESDataSet.ADJUNTOS.Rows(ADJUNTOSBindingSource.Position).Item("RUTA_ADJUNTO"))
                If CANTIDADORDENES = 1 Then
                    If Directory.GetDirectories(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION")).Count = 1 Then
                        Directory.Delete(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
                        Directory.Delete(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION"))
                    Else
                        Directory.Delete(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
                    End If
                End If
            Catch ex As Exception
            End Try
            ORDENESDataSet.ADJUNTOS.Rows(ADJUNTOSBindingSource.Position).Delete()
            ADJUNTOSTableAdapter.Update(ORDENESDataSet.ADJUNTOS)
            MsgBox("Registro y archivo adjunto borrado")

        End If
        If DataGridView1.Rows.Count < 1 Then
            BTNBorrar.Enabled = False
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim RUTA_ARCHIVOS As String
        If DataGridView1.Rows.Count > 0 Then
            RUTA_ARCHIVOS = DataGridView1.CurrentRow.Cells.Item(0).Value
            'ABRE EL ARCHIO SELECCIONADO EN EL LISTBOX
            Try
                If File.Exists(RUTA_ARCHIVOS) Then
                    Process.Start(RUTA_ARCHIVOS)
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub
    Private Sub BOT_GUARDAR_MouseHover(sender As Object, e As EventArgs) Handles BOT_GUARDAR.MouseHover
        BOT_GUARDAR.BackgroundImage = My.Resources.BTNGRAL_OVER
    End Sub
    Private Sub BOT_GUARDAR_MouseLeave(sender As Object, e As EventArgs) Handles BOT_GUARDAR.MouseLeave
        BOT_GUARDAR.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    End Sub
    Private Sub DataGridView1_TextChanged(sender As Object, e As EventArgs) Handles DataGridView1.TextChanged
        'If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
        '    BTNBorrar.Enabled = True
        '    LBL_ADJUNTOS.Visible = True
        'Else
        '    BTNBorrar.Enabled = False
        '    LBL_ADJUNTOS.Visible = False
        'End If
    End Sub
    Private Sub BTN_ADJUNTAR_Click(sender As Object, e As EventArgs) Handles BTN_ADJUNTAR.Click
        If ACCION_ORDEN = "NUEVO" Then
            If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
                Dim RESULTADO As DialogResult = OpenFileDialog1.ShowDialog()
                If RESULTADO = DialogResult.OK Then
                    For A = 0 To OpenFileDialog1.FileNames.Length - 1
                        NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                        NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileNames(A))
                        ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                        DataGridView1.Refresh()
                    Next
                End If
            Else
                TIPOACCION = "STANDARD"
                If FOpenFileDialog.Visible = True Then
                    FOpenFileDialog.BringToFront()
                Else
                    FOpenFileDialog.Show(Me)
                End If
            End If
        Else
            If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
                Dim RESULTADO As DialogResult = OpenFileDialog2.ShowDialog()

                OpenFileDialog2.Multiselect = True
                If RESULTADO = DialogResult.OK Then

                    Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
                    Dim MSGBOX1 As MsgBoxResult
                    Dim mover As Boolean = False

                    If Directory.Exists(PathADJUNTOS) = False Then
                        Directory.CreateDirectory(PathADJUNTOS)
                    End If 'CREA EL DIRECTORIO ADJUNTOS SI NO EXISTE
                    If Directory.Exists(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO")) = False Then
                        Directory.CreateDirectory(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
                    End If 'PREGUNTAMOS SI EXISTE EL DIRECTORIO CREADO, DE LO CONTRARIO SE CREA

                    'SE PREGUNTA SI SE QUIERE MOVER EL ARCHIVO A ADJUNTAR
                    MSGBOX1 = MsgBox("MOVER ARCHIVO/S SELECCIONADO?" & vbNewLine & vbNewLine & "Si selecciona SI, borra el archivo seleccionado" & vbNewLine & "en caso contrario lo mantiene" & vbNewLine & "Para ambos casos el sistema creara un nuevo archivo" & vbNewLine & "asociado a la orden", vbYesNo, "ARCHIVO SELECCIONADO")
                    If MSGBOX1 = DialogResult.Yes Then
                        mover = True
                    End If
                    ' MsgBox(OpenFileDialog2.FileNames.GetValue)

                    'VERIFICAMOS SI YA EXISTE UN ARCHIVO QUE SE LLAME IGUAL, DENTRO DE LA CARPETA
                    For A = 0 To OpenFileDialog2.FileNames.Length - 1
                        Dim CANTARCHIVOS As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\").Count
                        Dim NombreArchivos = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\")
                        Dim IgualArchivo As Boolean
                        PathRuta = OpenFileDialog2.FileNames(A)

                        NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                        NewADJUNTOSRow("ID_GESTION") = DATOS.DATOS_TRABAJORow("ID_GESTION")
                        NewADJUNTOSRow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                        NewADJUNTOSRow("ID_ORDEN") = DATOS.DATOS_ORDENESRow("NRO_ORDENINT")
                        If CANTARCHIVOS > 0 Then
                            For Each ExisteArchivo In NombreArchivos
                                If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_ORDENESRow("NRO_ORDENINT").ToString Then
                                    IgualArchivo = True
                                    Exit For
                                Else
                                    IgualArchivo = False
                                End If
                            Next
                            If IgualArchivo = True Then
                                Try
                                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog2.FileNames(A))
                                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog2.FileNames(A)), True)
                                Catch ex As Exception
                                End Try
                            Else
                                Try
                                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(OpenFileDialog2.FileNames(A))
                                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(OpenFileDialog2.FileNames(A)), True)
                                Catch ex As Exception
                                End Try
                            End If
                        Else
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(OpenFileDialog2.FileNames(A))
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(OpenFileDialog2.FileNames(A)), True)
                        End If
                        NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog2.FileNames(A))

                        ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                        ADJUNTOSTableAdapter.Update(NewADJUNTOSRow)
                        ADJUNTOSTableAdapter.FillByORDEN(ORDENESDataSet.ADJUNTOS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
                        'BORRA EL ARCHIVO DE ORIGEN
                        If mover = True Then
                            Try
                                File.Delete(PathRuta)
                            Catch ex As Exception
                                MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                            End Try
                        End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                    Next A

                    BTNBorrar.Enabled = True
                End If
            Else
                If FOpenFileDialog.Visible = True Then
                    FOpenFileDialog.BringToFront()
                Else
                    FOpenFileDialog.Show(Me)
                End If
            End If
        End If
    End Sub
    Private Sub BTN_EXPANDIR_Click(sender As Object, e As EventArgs)
        '   Size = New Size(1150, 512)
        '   Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)
        '   BTN_EXPANDIR.Visible = False
    End Sub
    Private Sub CK_NOTIFICAR_ORDEN_Click(sender As Object, e As EventArgs) Handles CK_NOTIFICAR_ORDEN.Click
        If CK_NOTIFICAR_ORDEN.Checked Then
            CK_NOTIFICAR_ORDEN.Checked = False
            NOTIFICAR_ORDEN = False
        Else
            If COMB_CUADRILLA.Text = "" Or COMB_CUADRILLA.Text = "SIN ASIGNAR" Then
                NOTIFICACION("SYS", "DEBE ASIGNAR ORDEN A ALGUIEN")
            Else
                NOTIFICAR_ORDEN = True
                CK_NOTIFICAR_ORDEN.Checked = True
            End If
        End If
    End Sub
    Private Sub CB_PRIORIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PRIORIDAD.SelectedIndexChanged
        If CB_PRIORIDAD.Text = "URGENTE" Or CB_PRIORIDAD.Text = "ALTA" Then
            CB_PRIORIDAD.ForeColor = Color.Red
            ' CK_NOTIFICAR_ORDEN.Checked = True
        Else
            CB_PRIORIDAD.ForeColor = Color.Green
            '  CK_NOTIFICAR_ORDEN.Checked = False
        End If
    End Sub
    'Private Sub BTN_ACPTAR_Click(sender As Object, e As EventArgs)
    '    P_CONFIGURAR_ORDEN.Visible = False
    '    TXT_TIPO.Text = TXT_ING_TIPO.Text
    '    TXT_TIPO_RED.Text = ORDEN_CB_ATRIBUTO.Text
    '    TXT_SECTOR.Text = CB_ING_SECTOR.SelectedItem
    '    TXT_MOTIVO.Text = CB_ING_FALLA.SelectedItem
    '    TXT_CAUSA.Text = CB_ING_CAUSA.SelectedItem
    'End Sub
    'Private Sub BTN_CONFIGURAR_ORDEN_Click(sender As Object, e As EventArgs)
    '    P_CONFIGURAR_ORDEN.Visible = True
    'End Sub
    Private Sub AGREGAR_ARCHIVO()
        Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
        Dim MSGBOX1 As MsgBoxResult
        Dim mover As Boolean = False
        If Directory.Exists(PathADJUNTOS) = False Then
            Directory.CreateDirectory(PathADJUNTOS)
        End If 'CREA EL DIRECTORIO ADJUNTOS SI NO EXISTE
        If Directory.Exists(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO) = False Then
            Directory.CreateDirectory(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO)
        End If 'PREGUNTAMOS SI EXISTE EL DIRECTORIO CREADO, DE LO CONTRARIO SE CREA

        'SE PREGUNTA SI SE QUIERE MOVER EL ARCHIVO A ADJUNTAR
        MSGBOX1 = MsgBox("MOVER ARCHIVO/S SELECCIONADO?" & vbNewLine & vbNewLine & "Si selecciona SI, borra el archivo seleccionado" & vbNewLine & "en caso contrario lo mantiene" & vbNewLine & "Para ambos casos el sistema creará un nuevo archivo" & vbNewLine & "asociado a la orden", vbYesNo, "ARCHIVO SELECCIONADO")
        If MSGBOX1 = DialogResult.Yes Then
            mover = True
        End If

        Dim CANTARCHIVOS As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\").Count
        Dim NombreArchivos = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\")
        Dim IgualArchivo As Boolean

        ORDENESDataSet.ADJUNTOS.Clear()

        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            For A = 0 To OpenFileDialog1.FileNames.Length - 1
                NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                NewADJUNTOSRow("ID_GESTION") = DATOS.DATOS_GESTIONRow.Id_GESTION
                NewADJUNTOSRow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow.Id_TRABAJO
                NewADJUNTOSRow("ID_ORDEN") = DATOS.DATOS_ORDENESRow.NRO_ORDENINT
                PathRuta = OpenFileDialog1.FileNames(A)
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        'VERIFICAMOS SI YA EXISTE UN ARCHIVO QUE SE LLAME IGUAL, DENTRO DE LA CARPETA
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_ORDENESRow.NRO_ORDENINT.ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A))
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A))
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A))
                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                End If
                NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileNames(A))
                If mover = True Then
                    Try
                        File.Delete(PathRuta)
                    Catch ex As Exception
                        MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                    End Try
                End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                ADJUNTOSTableAdapter.Update(NewADJUNTOSRow)
            Next A
        Else
            For A = 0 To ListArchivos.SelectedItems.Count - 1
                PathRuta = ListArchivos.SelectedItems(A).SubItems(0).Text
                NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                NewADJUNTOSRow("ID_GESTION") = DATOS.DATOS_GESTIONRow.Id_GESTION
                NewADJUNTOSRow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow.Id_TRABAJO
                NewADJUNTOSRow("ID_ORDEN") = DATOS.DATOS_ORDENESRow.NRO_ORDENINT
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_ORDENESRow("NRO_ORDENINT").ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow.Id_GESTION & "\" & DATOS.DATOS_TRABAJORow.Id_TRABAJO & "\" & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                End If
                NewADJUNTOSRow("NOM_ARCHIVO") = ListArchivos.SelectedItems(A).SubItems(1).Text
                If mover = True Then
                    Try
                        File.Delete(PathRuta)
                    Catch ex As Exception
                        MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                    End Try
                End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                ADJUNTOSTableAdapter.Update(NewADJUNTOSRow)
            Next A
        End If

    End Sub
    Private Sub TXT_CANT_OC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANT_OC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub BTN_MATERIALES_Click(sender As Object, e As EventArgs) Handles BTN_MATERIALES.Click
        If STANDARD_MATERIALES.Visible Then
            BringToFront()
        Else
            STANDARD_MATERIALES.Show(Me)
        End If
    End Sub

End Class