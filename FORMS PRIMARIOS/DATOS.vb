Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium
Public Class DATOS
    Public driver As IWebDriver
    Dim MENSAJE_DUPLI(100) As String
    Dim TOTAL_DUPLI As Integer
    Dim AUTORIZADO As Boolean
    Dim SECTORASIG As String
    Dim GEST_TRAB_TOOLS_VAR As String
    Dim TRAB_TRAB_TOOLS_VAR As String
    Dim NewRELEVAMIENTO As MDUDataSet.RELEVAMIENTOMDURow
    Public DATOS_NewHISTORICORow As ORDENESDataSet.HISTORICORow
    Public DATOS_NewMENSAJE As ORDENESDataSet.MENSAJERIARow
    Public DATOS_EDIFICIORow As DataRow
    Public DATOS_GESTIONRow As ORDENESDataSet.GESTIONRow
    Public COMBORow As ORDENESDataSet.COMBOSRow
    Public DATOS_TRABAJORow As ORDENESDataSet.TRABAJOSRow
    Public DATOS_ORDENESRow As ORDENESDataSet.ORDENESRow
    Public DATOS_ORDENAAGENDARRow As DataRow
    Dim NewTAREASRow As ORDENESDataSet.TAREASRow
    Dim TAREASRow As ORDENESDataSet.TAREASRow
    Dim NEWORDENRow As ORDENESDataSet.ORDENESRow
    Dim NEWADJUNTORow As ORDENESDataSet.ADJUNTOSRow
    Dim NewOBSERVACIONESRow As ORDENESDataSet.OBESERVACIONESRow
    Dim AGENDADORow As DataRow
    Dim HISTORICORow As DataRow
    Dim HISTORICO1Row As DataRow
    Dim HISTORICO2Row As DataRow
    Dim ID_GESTION As Integer
    Dim VAR_TIPODEP As String
    Public IDASIG As Integer
    Dim PathRuta As String
    Public FILTRONODO As String
    Dim FILTROZONA As String
    Public ORDEN_TIPODEPENDENCIA As String

    Dim GEST_STATUS_VAR As String
    Public GEST_NEWTRAB_TOOLS_VAR As String
    Dim GEST_RESP_NOMBRE As String
    Dim C_TRABAJO As Color = Color.FromArgb(255, 113, 0)
    Dim C_ORDENES As Color = Color.FromArgb(0, 117, 35)

    'VARIABLES PARA INTERACTUAR CON NUEVAS GESTIONES Y NUEVOS TRABAJOS
    Public VARGEST_TIPO As String
    Public VARGEST_DESCRIPCION As String
    Public VARGEST_SOLICITANTE As String
    Public VARGEST_CONTACTO As String
    Public VARGEST_TELEFONO As String
    Public VARGEST_MAIL As String
    Public VARGEST_INIEST As String
    Public VARGEST_TESTIM As String
    Public VARGEST_CALLE As String
    Public VARGEST_PUERTA As String
    Public VARGEST_ZONA As String
    Public VARGEST_SSM As String
    Public VARGEST_NODO As String
    Public VARGEST_ATRIBUTO As String
    Public VARGEST_ID_GEST_ORD As String

    Public VARTRAB_NODO As String
    Public VARTRAB_ZONA As String
    Public VARTRAB_GENERADOPOR As String
    Public VARTRAB_ASIGNADOA As String
    Public VARTRAB_TIPO As String
    Public VARTRAB_INIEST As String
    Public VARTRAB_TIEMEST As String
    Public VARTRAB_DESCRIPCION As String
    Public VARTRAB_MZNA As String
    Public VARTRAB_CALLE As String
    Public VARTRAB_NRO As String
    Public VARTRAB_TIPODEP As String
    Public VARTRAB_DEP As String
    Public VARTRAB_ATRIBUTO As String

    Dim TRAB_RESP_NOMBRE As String

    'VARIABLES DE ORDENES

    Dim ORDNODO As String
    Dim ORDZONA As String
    Dim ORDTIPO As String
    Dim ORDGENERADO As String
    Dim ORDFALLAORIG As String
    Dim ORDCAUSAING As String
    Public ORDSECTOROPE As String
    Dim ORDPRIORIDAD As String
    Dim ORDASIGNADO As String
    Public STATUSORD As String
    Public ORDFALLACIERRE As String
    Public ORDCAUSACIERRE As String
    Dim VAR_ORDENDP As Integer
    Dim VAR_CLASEDEP As String
    Dim VAR_DEPENDENCIA As Integer
    Dim ORDOBSERVACION As String

    'VARIABLES DE INFORMACION PARA ORDEN Y AGENDAMIENTOS
    Public ING_FECHAINICEST As Date
    Public ING_DEPENDENCIA As Integer
    Public ING_TIPODEP As String
    Public ING_CLASEDEP As String
    Public ING_ORDENDEP As Integer
    Public ING_ORDORIGEN As Integer
    Public CANT_ORDENESAAGENDAR As Integer
    Public CANT_ORDENESADESAGENDAR As Integer
    Public ORDEN_EST(100) As Integer
    Public RECURSO_CAP As String
    Public SECTOR_CAP As String
    Public TIEMPO_FINAL As Integer

    'VARIABLES PARA FINALIZAR UN TRABAJO CON ORDENES PENDIENTES
    Public MJE_FINALIZAR As String
    Public ACCION_FINALIZAR As String
    Public DET_HISTORICO As String


    Dim SOLOFECHA As Date

    Dim SEL_ORDENORIG As Integer
    Dim SEL_ORDENSELEC As Integer
    Dim SEL_SECTOROPERATIVO As String
    Dim SEL_SECTORGENERADOR As String
    Dim SEL_PRIORIDAD As String
    Dim SEL_FECHAORDEN As String

    'VARIABLES HISTORICO Y MENSAJES
    Public DATOS_STATUSANT As String
    Public DATOS_HIS_STATUSACTUAL As String
    Public DATOS_HIS_CAUSA As String
    Public DATOS_HIS_DETALLE As String
    Public DATOS_MJE_ASUNTO As String
    Public DATOS_MJE_DESTINONOMBRE As String
    Public DATOS_MJE_DESTINOSECTOR As String
    Public DATOS_MJE_MENSAJE As String
    Public DATOS_MJE_NROORDENASOC As String
    Dim ENCABEZADO As PdfPTable
    Private Sub DATOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case SECTOR
            Case "PLANIFICACION TECNICA"
                If FULLNOMBRE = "DIEGO GEYMONAT" Then
                    BTN_SERVICIO.Visible = True
                End If
            Case "GERENCIA", "OBRA CIVIL"
                BTN_SERVICIO.Visible = True
        End Select
        'SI EL TEMA ES BLANCO(CLARO)
        If THEME_BLACK = False Then
            'SETEO DEL FORM-DATOS
            BackColor = Color.White

            'PANEL GESTION
            PanelGESTION.BackgroundImage = My.Resources.BANNER_GESTION_W
            LBL_RECURSO.BackColor = Color.White
            LBL_RECURSO.ForeColor = FORE_COLOR_W
            LBLNODO.ForeColor = FORE_COLOR_W
            LBLNODO.BackColor = Color.White
            BUSCA_NODO.BackColor = Color.White
            BUSCA_NODO.ForeColor = FORE_COLOR_W
            LBL_ZONA.ForeColor = FORE_COLOR_W
            LBL_ZONA.BackColor = Color.White
            GEST_NODO.ForeColor = FORE_COLOR_W
            GEST_NODO.BackColor = Color.White
            GEST_ZONA.ForeColor = FORE_COLOR_W
            GEST_ZONA.BackColor = Color.White
            GEST_DESCRIPCION.BackColor = Color.White
            GEST_DESCRIPCION.ForeColor = Color.DarkBlue
            GESTIONDataGridView.BackgroundColor = Color.FromArgb(221, 221, 221)
            GESTIONDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
            GESTIONDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            GESTIONDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            GESTIONDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            LBL_GEST_RUS.ForeColor = Color.DarkBlue
            LBL_GEST_RUS.BackColor = Color.White
            BOT_NUEVAGEST.BackColor = Color.White
            RESPONSABLE.BackColor = Color.White
            RESPONSABLE.ForeColor = Color.DarkBlue
            VER_HISTGESTION.ForeColor = Color.DarkBlue
            VER_HISTGESTION.BackColor = Color.White
            DIRECCION_GEST.ForeColor = Color.DarkBlue
            DIRECCION_GEST.BackColor = Color.White
            INICIOGESTION.ForeColor = Color.DarkBlue
            INICIOGESTION.BackColor = Color.White
            TIEMESTIMADO.BackColor = Color.White
            TIEMESTIMADO.ForeColor = Color.DarkBlue
            CONTACTO.ForeColor = Color.DarkBlue
            CONTACTO.BackColor = Color.White
            TELEFONO.BackColor = Color.White
            TELEFONO.ForeColor = Color.DarkBlue
            MAIL.ForeColor = Color.DarkBlue
            MAIL.BackColor = Color.White
            GENERADOPOR.BackColor = Color.White
            GENERADOPOR.ForeColor = Color.DarkBlue
            SOLICITADOPOR.ForeColor = Color.DarkBlue
            SOLICITADOPOR.BackColor = Color.White
            LBL_ATRIBUTO1.BackColor = Color.White
            LBL_ATRIBUTO1.ForeColor = Color.DarkBlue
            LBL_ATRIBUTO.BackColor = Color.White
            LBL_ATRIBUTO.ForeColor = Color.DarkBlue
            BTN_VER_GOOGLE.BackColor = Color.White
            BTN_VER_GOOGLE.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            BTN_VER_GOOGLE.FlatAppearance.MouseDownBackColor = Color.LightBlue

            'PANEL TRABAJO
            PanelTRABAJO.BackgroundImage = My.Resources.BANNER_TRABAJO_W
            ETI_TRABGENERADOX.BackColor = Color.White
            ETI_TRABGENERADOX.ForeColor = C_TRABAJO
            ADJUNTOSDataGridView.BackgroundColor = Color.FromArgb(221, 221, 221)
            ADJUNTOSDataGridView.RowsDefaultCellStyle.ForeColor = C_TRABAJO
            ADJUNTOSDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
            ADJUNTOSDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200)
            ADJUNTOSDataGridView.RowsDefaultCellStyle.SelectionForeColor = C_TRABAJO
            ADJUNTOSDataGridView.Columns(0).Visible = False
            ETI_TRABDESCRIPCION.BackColor = Color.White
            ETI_TRABDESCRIPCION.ForeColor = C_TRABAJO
            VER_HISTTRABAJOS.BackColor = Color.White
            VER_HISTTRABAJOS.ForeColor = C_TRABAJO
            ETI_TRABCALLEYNRO.ForeColor = C_TRABAJO
            ETI_TRABCALLEYNRO.BackColor = Color.White
            LBL_ADJUNTOS.ForeColor = C_TRABAJO
            LBL_ADJUNTOS.BackColor = Color.FromArgb(221, 221, 221)
            TRABAJOSDataGridView.BackgroundColor = Color.FromArgb(221, 221, 221)
            TRABAJOSDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
            TRABAJOSDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = C_TRABAJO
            TRABAJOSDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            TRABAJOSDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            FILTRO_ZONA.BackColor = Color.White
            FILTRO_ZONA.ForeColor = C_TRABAJO
            ETI_TRABNODO.BackColor = Color.White
            ETI_TRABNODO.ForeColor = C_TRABAJO
            ETI_TRABMZNA.BackColor = Color.White
            ETI_TRABMZNA.ForeColor = C_TRABAJO
            BTN_AGREGAR.BackColor = Color.FromArgb(221, 221, 221)
            BTN_AGREGAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221)
            BTN_AGREGAR.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221)
            BTN_AGREGAR.ForeColor = C_TRABAJO
            BTN_BORRAR.ForeColor = C_TRABAJO
            BTN_BORRAR.BackColor = Color.FromArgb(221, 221, 221)
            BTN_VER_PLANOS.BackColor = Color.White
            BTN_VER_PLANOS.ForeColor = C_TRABAJO
            BTN_VER_PLANOS.FlatAppearance.MouseOverBackColor = Color.White
            LBL_PROYECTO.BackColor = Color.White
            LBL_PROYECTO.ForeColor = C_TRABAJO

            'PANEL ORDENES
            PanelORDENES.BackgroundImage = My.Resources.BANNER_ORDEN_W
            ORDENESDataGridView.BackgroundColor = Color.FromArgb(221, 221, 221)
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = C_ORDENES
            ORDENESDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ORDENESDataGridView.RowsDefaultCellStyle.ForeColor = FORE_COLOR_W 'C_ORDENES
            ORDENESDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50)
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 153, 46)
            LBL_ORDEN_DATOS.BackColor = Color.White
            LBL_ORDEN_DATOS.ForeColor = C_ORDENES
            TXT_OBS.BackColor = Color.White
            TXT_OBS.ForeColor = C_ORDENES
            TXT_OBS.BorderStyle = BorderStyle.None
            LBL_ORD_ORIGEN.BackColor = Color.White
            LBL_ORD_ORIGEN.ForeColor = FORE_COLOR_W
            VER_HISTORDENES.ForeColor = C_ORDENES
            VER_HISTORDENES.BackColor = Color.White
            LBL_ORD_NODO.BackColor = Color.White
            LBL_ORD_NODO.ForeColor = C_ORDENES
            CK_DATOS_SEL_UNITARIA.BackColor = Color.White
            CK_DATOS_SEL_UNITARIA.ForeColor = C_ORDENES
            'SETEO DE TRABAJO
            '  PanelTRABAJO.BackgroundImage = Nothing
            '   PanelTRABAJO.BackColor = Color.White
            '   PanelTRABAJO.ForeColor = Color.FromArgb(30, 30, 30)
            ' TRABAJOSDataGridView.Columns(10).Visible = False
            '  TRABAJOSDataGridView.Columns(11).Visible = True
            ' TRABAJOSDataGridView.BackgroundColor = Color.White
        End If
    End Sub
    Private Sub DATOS_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.ORDENESDataSet.ADJUNTOS.Clear()
        Cursor = Cursors.WaitCursor
        'MODIFICA LA PANTALLA DE ACUERDO AL AREA SELECCIONADA
        Select Case INGRESO_AREA
            Case "MDU"
                CONDINI_GESTION()
                LBL_RECURSO.Text = "MDU"

                DIRECCION_GEST.Visible = True
                LBL_ZONA.Visible = True
                BTN_SALIR.Visible = True

                'CARGA MDU SELECCIONADO
                Select Case ACCESO_DESDE
                    'SI VIENE DE INGRESO DATOS DE MDU
                    Case "MDU"
                        ' CARGA EDIFICIO SELECCIONADO
                        Select Case ACCESO_TIPO
                            Case "GESTION"
                                GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, NROGESTION)
                                GESTIONBindingSource.MoveLast()
                                DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(GESTIONBindingSource.Position)
                                ID_GESTION = DATOS_GESTIONRow("Id_GESTION")
                                DIRECCION_MDU = Trim(DATOS_GESTIONRow("CALLE"))
                                NUMERO_MDU = Trim(DATOS_GESTIONRow("NUMERO"))
                                NODO_MDU = DATOS_GESTIONRow("NODO")
                                ZONA_MDU = DATOS_GESTIONRow("ZONA")
                                DIRECCION_GEST.Text = DIRECCION_MDU & " " & NUMERO_MDU
                                DIRECCION_GEO = DIRECCION_GEST.Text
                                LLENA_CAMPOSGESTION()
                                LLENA_TRABAJOS()

                            Case "CARPETA"
                                EdificiosTableAdapter.FillByCARPETA(MDUDataSet.Edificios, BUSCA_PRIM, BUSCA_PRIM)
                                DATOS_EDIFICIORow = MDUDataSet.Edificios.Rows(0)
                                DIRECCION_GEST.Text = Trim(DATOS_EDIFICIORow("CALLE")) & " " & DATOS_EDIFICIORow("NROPUERTA")
                                DIRECCION_GEO = DIRECCION_GEST.Text
                                BTN_VER_GOOGLE.Visible = True
                                ''BUSCA SI HAY GESTIONES
                                GESTIONTableAdapter.FillByCARPETA(ORDENESDataSet.GESTION, BUSCA_PRIM)

                                If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                                    GESTIONBindingSource.MoveLast()
                                    DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(GESTIONBindingSource.Position)
                                    ID_GESTION = DATOS_GESTIONRow("Id_GESTION")
                                    If IsDBNull(DATOS_GESTIONRow("CALLE")) = False Then DIRECCION_MDU = DATOS_GESTIONRow("CALLE")
                                    If IsDBNull(DATOS_GESTIONRow("NUMERO")) = False Then NUMERO_MDU = DATOS_GESTIONRow("NUMERO")

                                    LLENA_CAMPOSGESTION()
                                    LLENA_TRABAJOS()

                                End If
                        End Select

                        '
                    Case "MISGESTIONES", "BUSCADOR"
                        'SI VIENE DE GESTIONES
                        BTN_SALIR.Visible = True
                        GESTIONTableAdapter.FillByIDGESTION(Me.ORDENESDataSet.GESTION, ACCESO_GESTION)
                        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                            DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(0)
                            BUSCA_PRIM = DATOS_GESTIONRow("ID_GESTION")
                            DIRECCION_MDU = DATOS_GESTIONRow("CALLE")
                            NUMERO_MDU = DATOS_GESTIONRow("NUMERO")
                            ZONA_MDU = DATOS_GESTIONRow("ZONA")
                            NODO_MDU = DATOS_GESTIONRow("NODO")
                            LLENA_CAMPOSGESTION()
                            Select Case ACCESO_TIPO
                                Case "GESTION"
                                    TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, ACCESO_GESTION)
                                    LLENA_TRABAJOS()
                                Case "TRABAJO"
                                    TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ACCESO_TRABAJO)
                                    LLENA_TRABAJOS()
                                Case "ORDEN"
                                    TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ACCESO_TRABAJO)
                                    ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, NROORDENINT)
                                    DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows(0)
                                    DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows(0)
                                    CARGA_TRABAJOS()
                                    CARGA_VALORESORDENES()
                            End Select
                            'CARGA EDIFICIO SELECCIONADO
                            'EdificiosTableAdapter.FillByCARPETA(MDUDataSet.Edificios, DATOS_GESTIONRow("CARPETA"), DATOS_GESTIONRow(""))
                        End If
                End Select
                'MUESTRA ZONA
                GEST_ZONA.Visible = True
                GEST_ZONA.Text = ZONA_MDU
                'MUESTRA NODO
                GEST_NODO.Visible = True
                GEST_NODO.Text = NODO_MDU
                BOT_CARGAREL.Visible = False
                ' BOT_CARGAREL.Enabled = False
                Me.Refresh()
            Case "RED"
                CONDINI_GESTION()
                LBL_RECURSO.Text = "RED"
                GEST_ZONA.Visible = False
                GEST_ZONA.Text = ""
                Me.Refresh()
                BOT_CARGAREL.Visible = False
                Select Case ACCESO_DESDE
                    Case "RED"
                        BUSCA_NODO.Visible = True
                    Case "MISGESTIONES", "BUSCADOR"
                        BTN_SALIR.Visible = True
                        GESTIONTableAdapter.FillByIDGESTION(Me.ORDENESDataSet.GESTION, ACCESO_GESTION)
                        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                            DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(0)
                            LLENA_CAMPOSGESTION()
                            Select Case ACCESO_TIPO
                                Case "GESTION"
                                    TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, ACCESO_GESTION)
                                    LLENA_TRABAJOS()
                                Case "TRABAJO"
                                    TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ACCESO_TRABAJO)
                                    ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, ACCESO_TRABAJO)
                                    LLENA_TRABAJOS()
                                Case "ORDEN"
                                    TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ACCESO_TRABAJO)
                                    ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, NROORDENINT)
                                    DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows.Find(ACCESO_TRABAJO)
                                    DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows.Find(NROORDENINT)
                                    CARGA_TRABAJOS()
                                    CARGA_VALORESORDENES()
                            End Select

                        End If
                End Select
            Case "FUENTES"
                BTN_SALIR.Visible = True
                DIRECCION_GEST.Text = ""
                DIRECCION_GEST.Visible = False
                BUSCA_NODO.Visible = False
                BUSCA_NODO.Text = FUENTE_NODO
                LBL_RECURSO.Text = "FUENTE"

                GEST_ZONA.Visible = False
                GEST_NODO.Visible = True
                GEST_NODO.Text = FUENTE_NODO
                BOT_CARGAREL.Visible = False
                Refresh()
        End Select
        Cursor = DefaultCursor
    End Sub
    Public Sub GESTIONDataGridView_Click(sender As Object, e As MouseEventArgs) Handles GESTIONDataGridView.Click
        Cursor = Cursors.WaitCursor
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                NROGESTION = GESTIONDataGridView.CurrentRow.Cells.Item(0).Value
                DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows.Find(NROGESTION)
                If DATOS_GESTIONRow("COMPLETO") = False Then
                    GEST_COMPLETO_TOOLSTRIP.Text = "Marcar COMPLETO"
                Else
                    GEST_COMPLETO_TOOLSTRIP.Text = "Quitar COMPLETO"
                End If
                GEST_NEWTRABAJO_TOOLSTRIP.Visible = True
                GEST_EDITAR_TOOLSTRIP.Visible = True
                GEST_STATUS_TOOLSTRIP.Visible = True
                GEST_RESPONSABLE_ToolStrip.Visible = True

                GEST_INICIAR_ToolStrip.Visible = False
                GEST_DEMORAR_ToolStrip.Visible = False
                GEST_REINICIAR_ToolStrip.Visible = False
                GEST_FINALIZAR_ToolStrip.Visible = False
                GEST_CANCELAR_ToolStrip.Visible = False
                GEST_COMPLETO_TOOLSTRIP.Visible = True
                GEST_Separator1.Visible = True
                If DATOS_GESTIONRow("COMPLETO") = True Then
                    GEST_COMPLETO_TOOLSTRIP.Text = "Quitar COMPLETO"
                Else
                    GEST_COMPLETO_TOOLSTRIP.Text = "Marcar COMPLETO"
                End If

                GEST_GRAFICAR_ToolStrip.Visible = True
                Select Case DATOS_GESTIONRow("STATUS")
                    Case "INGRESADO"
                        GEST_INICIAR_ToolStrip.Visible = True
                        GEST_CANCELAR_ToolStrip.Visible = True
                    Case "INICIADO"
                        GEST_DEMORAR_ToolStrip.Visible = True
                        GEST_FINALIZAR_ToolStrip.Visible = True
                        GEST_CANCELAR_ToolStrip.Visible = True
                    Case "DEMORADO"
                        GEST_REINICIAR_ToolStrip.Visible = True
                        GEST_CANCELAR_ToolStrip.Visible = True
                    Case "FINALIZADO"
                        GEST_NEWTRABAJO_TOOLSTRIP.Visible = False
                        GEST_EDITAR_TOOLSTRIP.Visible = False
                        GEST_STATUS_TOOLSTRIP.Visible = False
                        GEST_RESPONSABLE_ToolStrip.Visible = False
                        GEST_COMPLETO_TOOLSTRIP.Visible = False
                        GEST_Separator1.Visible = False
                End Select
                CARGA_COMBOSTRA()
                GESTIONDataGridView.ContextMenuStrip = MENU_GESTION
                LLENA_CAMPOSGESTION()
                TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, DATOS_GESTIONRow("ID_GESTION"))
                LLENA_TRABAJOS()
            End If
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub GESTIONDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles GESTIONDataGridView.SelectionChanged
        'LLENA_CAMPOSGESTION()
        If VER_HISTGESTION.Checked = True Then
            If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                Me.HISTORICOTableAdapter.FillByIDGESTION(OrdenesDataSet1.HISTORICO, DATOS_GESTIONRow("ID_GESTION"))
                Me.HISTORICOBindingSource1.MoveLast()
                LLENA_HISTORICOGESTION()
            End If
        End If   'CARGA HISTORICO
    End Sub
    Public Sub LLENA_CAMPOSGESTION()
        If ORDENESDataSet.GESTION.Count > 0 Then
            GEST_DESCRIPCION.Visible = True
            GESTIONDataGridView.Visible = True
            GENERADOPOR.Visible = True
            VER_HISTGESTION.Visible = True
            Try
                If THEME_BLACK = False Then
                    For C = 0 To GESTIONDataGridView.Rows.Count - 1
                        GESTIONDataGridView.Rows(C).Height = 21
                        GESTIONDataGridView.Rows(C).DefaultCellStyle.ForeColor = Color.FromArgb(46, 46, 46)
                        GESTIONDataGridView.Rows(C).DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
                    Next
                    GESTIONDataGridView.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 80, 80)
                    GESTIONDataGridView.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.FromArgb(93, 173, 226)
                Else
                    For C = 0 To GESTIONDataGridView.Rows.Count - 1
                        GESTIONDataGridView.Rows(C).Height = 21
                    Next
                End If
                GESTIONDataGridView.CurrentRow.Height = 40
            Catch ex As Exception
            End Try

            TIPOGESTION.Text = "Tipo Gestion: " & DATOS_GESTIONRow("TIPOGESTION")

            GENERADOPOR.Text = "Generado por: " & DATOS_GESTIONRow("GENERADOX")
            If IsDBNull(DATOS_GESTIONRow("ASIGNADOA")) = False Then
                If DATOS_GESTIONRow("ASIGNADOA") <> "" Then
                    GENERADOPOR.Text += "  | Responsable: " & DATOS_GESTIONRow("ASIGNADOA")
                End If
            End If
            If IsDBNull(DATOS_GESTIONRow("FECHAINICESTIMADA")) = False And IsDate(DATOS_GESTIONRow("FECHAINICESTIMADA")) Then
                GENERADOPOR.Text += "  | Inicio Estimado: " & DATOS_GESTIONRow("FECHAINICESTIMADA")
            End If
            If IsDBNull(DATOS_GESTIONRow("TIEMPOEST")) = False And DATOS_GESTIONRow("TIEMPOEST") <> "" Then
                GENERADOPOR.Text += "  | Tiempo Estimado: " & DATOS_GESTIONRow("TIEMPOEST") & " Días"
            End If
            If DATOS_GESTIONRow("SOLICITANTE") <> "" Then
                SOLICITADOPOR.Text = "Solicitante: " & DATOS_GESTIONRow("SOLICITANTE")
                SOLICITADOPOR.Visible = True
            Else
                SOLICITADOPOR.Visible = False
            End If
            VARGEST_CONTACTO = ""
            If DATOS_GESTIONRow.IsNOMBRECONTACTONull = False Then
                If DATOS_GESTIONRow("NOMBRECONTACTO") <> "" Then
                    VARGEST_CONTACTO = DATOS_GESTIONRow("NOMBRECONTACTO")
                    CONTACTO.Text = "Contacto: " & DATOS_GESTIONRow("NOMBRECONTACTO")
                    CONTACTO.Visible = True
                Else
                    CONTACTO.Visible = False
                End If
            Else
                CONTACTO.Visible = False
            End If
            VARGEST_TELEFONO = ""
            If DATOS_GESTIONRow.IsTELEFCONTACTONull = False Then
                If DATOS_GESTIONRow("TELEFCONTACTO") <> "" Then
                    VARGEST_TELEFONO = DATOS_GESTIONRow("TELEFCONTACTO")
                    TELEFONO.Text = "Telefono: " & DATOS_GESTIONRow("TELEFCONTACTO")
                    TELEFONO.Visible = True
                Else
                    TELEFONO.Visible = False
                End If
            Else
                TELEFONO.Visible = False
            End If
            VARGEST_MAIL = ""
            If DATOS_GESTIONRow.IsMAILCONTACTONull = False Then
                If DATOS_GESTIONRow("MAILCONTACTO") <> "" Then
                    MAIL.Text = "Mail: " & DATOS_GESTIONRow("MAILCONTACTO")
                    VARGEST_MAIL = DATOS_GESTIONRow("MAILCONTACTO")
                    MAIL.Visible = True
                Else
                    MAIL.Visible = False
                End If
            Else
                MAIL.Visible = False
            End If
            If IsDBNull(DATOS_GESTIONRow("ATRIBUTO")) = False Then
                If DATOS_GESTIONRow("ATRIBUTO") <> "" Then
                    VARGEST_ATRIBUTO = DATOS_GESTIONRow("ATRIBUTO")
                    LBL_ATRIBUTO.Visible = True
                Else
                    LBL_ATRIBUTO.Visible = False
                End If
            Else
                VARGEST_ATRIBUTO = "HFC"
                LBL_ATRIBUTO.Visible = True
            End If
            LBL_ATRIBUTO.Text = VARGEST_ATRIBUTO
            If DATOS_GESTIONRow.IsID_GESTION_ORDINALESNull = False Then VARGEST_ID_GEST_ORD = DATOS_GESTIONRow.ID_GESTION_ORDINALES Else VARGEST_ID_GEST_ORD = ""
            VARGEST_DESCRIPCION = ""
            If DATOS_GESTIONRow.IsDESCRIPCIONNull = False Then
                If DATOS_GESTIONRow("DESCRIPCION") <> "" Then
                    GEST_DESCRIPCION.Text = DATOS_GESTIONRow("DESCRIPCION")
                    VARGEST_DESCRIPCION = DATOS_GESTIONRow("DESCRIPCION")
                    GEST_DESCRIPCION.Visible = True
                Else
                    GEST_DESCRIPCION.Visible = False
                End If
            Else
                GEST_DESCRIPCION.Visible = False
            End If
            GEST_NODO.Text = DATOS_GESTIONRow("NODO")
            VARGEST_NODO = DATOS_GESTIONRow("NODO")
            VARGEST_TIPO = DATOS_GESTIONRow("TIPOGESTION")

            VARGEST_SOLICITANTE = DATOS_GESTIONRow("SOLICITANTE")
            If DATOS_GESTIONRow.IsID_GESTION_ORDINALESNull Then
                LBL_GEST_RUS.Visible = False
            Else
                If DATOS_GESTIONRow.ID_GESTION_ORDINALES <> "" Then
                    LBL_GEST_RUS.Visible = True
                    LBL_GEST_RUS.Text = DATOS_GESTIONRow.ID_GESTION_ORDINALES
                Else
                    LBL_GEST_RUS.Visible = False
                End If
            End If


            If IsDBNull(DATOS_GESTIONRow("FECHAINICESTIMADA")) = False Then
                    VARGEST_INIEST = DATOS_GESTIONRow("FECHAINICESTIMADA").ToString
                Else
                    VARGEST_INIEST = ""
                End If
                If IsDBNull(DATOS_GESTIONRow("TIEMPOEST")) = False Then
                    VARGEST_TESTIM = DATOS_GESTIONRow("TIEMPOEST")
                Else
                    VARGEST_TESTIM = 0
                End If
                If IsDBNull(DATOS_GESTIONRow("NUMERO")) = False Then
                    VARGEST_PUERTA = DATOS_GESTIONRow("NUMERO")
                Else
                    VARGEST_PUERTA = ""
                End If
                If IsDBNull(DATOS_GESTIONRow("CALLE")) = False Then
                    VARGEST_CALLE = DATOS_GESTIONRow("CALLE")

                    If DATOS_GESTIONRow("CALLE") <> "" Then
                        DIRECCION_GEST.Visible = True
                        DIRECCION_GEST.Text = VARGEST_CALLE & "  " & VARGEST_PUERTA
                        BTN_VER_GOOGLE.Visible = True
                    Else
                        DIRECCION_GEST.Visible = False
                        BTN_VER_GOOGLE.Visible = False
                    End If
                Else
                    DIRECCION_GEST.Visible = False
                End If
                If IsDBNull(DATOS_GESTIONRow("MANZANA")) = False Then
                    VARGEST_SSM = DATOS_GESTIONRow("MANZANA")
                Else
                    VARGEST_SSM = ""
                End If
                If IsDBNull(DATOS_GESTIONRow("ZONA")) = False Then
                    VARGEST_ZONA = DATOS_GESTIONRow("ZONA")
                Else
                    VARGEST_ZONA = ""
                End If
            Else
                BORRA_ETIQUETAS_GEST()
        End If
    End Sub
    Private Sub TRABAJOSDataGridView_Click(sender As Object, e As MouseEventArgs) Handles TRABAJOSDataGridView.Click
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            NROTRABAJO = TRABAJOSDataGridView.CurrentRow.Cells.Item(1).Value
            DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows.Find(NROTRABAJO)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                'CARGA EL DATAROW DE TRABAJOS
                If DATOS_TRABAJORow("COMPLETO") = False Then
                    TRAB_COMPLETO_ToolStrip.Text = "Marcar COMPLETO"
                Else
                    TRAB_COMPLETO_ToolStrip.Text = "Quitar COMPLETO"
                End If
                TRAB_NUEVOTRAB_ToolStrip.Visible = True
                TRAB_STATUS_ToolStrip.Visible = True
                TRAB_CANCELAR_ToolStrip.Visible = True
                TRAB_INICIAR_ToolStrip.Visible = True
                TRAB_DEMORAR_ToolStrip.Visible = True
                TRAB_FINALIZAR_ToolStrip.Visible = True
                TRAB_EDITAR_ToolStrip.Visible = True
                TRAB_COMPLETO_ToolStrip.Visible = True
                TRAB_CREARORDEN_ToolStrip.Visible = True
                TRAB_REINICIAR_ToolStrip.Visible = True
                TRAB_RESPONSABLE_ToolStrip.Visible = True
                TRAB_Separator1.Visible = True
                TRAB_Separator2.Visible = True
                TRAB_Separator3.Visible = True
                TRAB_HABILITA_ToolStrip.Visible = False
                Select Case SECTOR
                    Case "GERENCIA", "PLANIFICACION TECNICA", "SUPERVISION"
                        If DATOS_TRABAJORow("STATUS") <> "FINALIZADO" Then
                            TRAB_HABILITA_ToolStrip.Visible = True
                            If DATOS_TRABAJORow("HABILITADO") Then
                                TRAB_HABILITA_ToolStrip.Text = "DESHABILITAR TRABAJO"
                            Else
                                TRAB_HABILITA_ToolStrip.Text = "HABILITAR TRABAJO"
                            End If
                        End If
                End Select
                Select Case DATOS_TRABAJORow("STATUS")
                    Case "INGRESADO"
                        TRAB_FINALIZAR_ToolStrip.Visible = False
                        TRAB_DEMORAR_ToolStrip.Visible = False
                        TRAB_REINICIAR_ToolStrip.Visible = False
                    Case "INICIADO"
                        TRAB_INICIAR_ToolStrip.Visible = False
                        TRAB_REINICIAR_ToolStrip.Visible = False
                    Case "DEMORADO"
                        TRAB_INICIAR_ToolStrip.Visible = False
                        TRAB_FINALIZAR_ToolStrip.Visible = False
                        TRAB_DEMORAR_ToolStrip.Visible = False
                    Case "FINALIZADO", "CANCELADO"
                        If DATOS_GESTIONRow("STATUS") = "FINALIZADO" Then
                            TRAB_NUEVOTRAB_ToolStrip.Visible = False
                        End If
                        TRAB_STATUS_ToolStrip.Visible = False
                        TRAB_EDITAR_ToolStrip.Visible = False
                        TRAB_COMPLETO_ToolStrip.Visible = False
                        TRAB_CREARORDEN_ToolStrip.Visible = False
                        TRAB_RESPONSABLE_ToolStrip.Visible = False
                        TRAB_Separator1.Visible = False
                        TRAB_Separator2.Visible = False
                End Select
                TRABAJOSDataGridView.ContextMenuStrip = MENU_TRABAJO
                'CARGA LAS ORDENES RELACIONADAS CON EL TRABAJO
                CARGA_TRABAJOS()
                ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
                CARGA_VALORESORDENES()
            End If

            If INGRESO_AREA = "MDU" Then
                If TRABAJOSDataGridView.CurrentRow.Cells.Item(2).Value = "RELEVAMIENTO" Or TRABAJOSDataGridView.CurrentRow.Cells.Item(2).Value = "Relevamiento" Then
                    BOT_CARGAREL.Visible = True
                Else
                    BOT_CARGAREL.Visible = False
                End If
            End If
            CARGA_COMBOSTRA()
        End If
    End Sub
    Private Sub ORDENESDataGridView_MouseClick(sender As Object, e As MouseEventArgs) Handles ORDENESDataGridView.MouseClick
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            NROORDENINT = ORDENESDataGridView.CurrentRow.Cells.Item(3).Value
            DATOS_ORDENESRow = ORDENESDataSet.TRABAJOS.Rows.Find(NROORDENINT)
            CARGA_VALORESORDENES()
        End If
    End Sub
    Private Sub ORDENESDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles ORDENESDataGridView.MouseDown
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            'SI SE SELECCIONA UNA ROW DE LA TABLA ORDENES


            If e.Button = MouseButtons.Right Then
                With ORDENESDataGridView
                    Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                    ' Obtenemos la parte del control a las que
                    ' pertenecen las coordenadas.
                    If hti.Type = DataGridViewHitTestType.Cell Then
                        .CurrentCell = .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                    End If
                End With

                '    'HABILITA AL BOTON SECUNDADRIO DE LA TABLA A ABRIR UN MENU
                ORD_IMPRIMIR_ToolStrip.Visible = True
                ORD_EDITAR_ToolStrip.Visible = True
                ORD_EDITAR_ToolStrip.Text = "EDITAR ORDEN"
                ORD_STATUS_ToolStrip.Visible = True
                ORD_STATUS_ToolStrip.Text = "CAMBIAR STATUS"
                ORD_EMITIR_ToolStrip.Visible = False
                ORD_FINALIZAR_ToolStrip.Visible = False
                ORD_CANCELAR_ToolStrip.Visible = False
                ORD_IRAORDEN_ToolStrip.Visible = True
                ORD_Separator2.Visible = True
                ORD_CREAR_ToolStrip.Visible = True
                ORD_ESTRICTA_ToolStrip.Visible = True
                ORD_DINAMICA_ToolStrip.Visible = True
                ORD_Separator3.Visible = True
                ORD_MARCACREAR_ToolStrip.Visible = True
                ORD_MARCACOORDINAR_ToolStrip.Visible = False
                ORD_ELIMINARToolStripMenuItem.Visible = False
                ORD_REACTIVARToolStrip.Visible = False
                ORDSeparator4.Visible = True
                ORD_CREARORDBOTToolStrip.Visible = False
                If DATOS_ORDENESRow.CREARORDINAL = False Then
                    If DATOS_ORDENESRow.NRO_ORDINAL = 0 Then
                        ORD_MARCACREAR_ToolStrip.Text = "Marcar CREAR ORDINAL"
                    Else
                        ORD_MARCACREAR_ToolStrip.Visible = False
                    End If
                Else
                    ORD_MARCACREAR_ToolStrip.Text = "Quitar CREAR ORDINAL"
                End If
                If DATOS_ORDENESRow("COORDINAR") = False Then
                    ORD_MARCACOORDINAR_ToolStrip.Text = "Marcar COORDINAR"
                Else
                    ORD_MARCACOORDINAR_ToolStrip.Text = "Quitar COORDINAR"
                End If
                ' ORD_VER_RUSToolStrip.Visible = False
                ORD_Separator1.Visible = True
                ORD_AGENDAR_ToolStrip.Visible = False
                ORD_AGENDAR_ToolStrip.Text = "AGENDAR"
                Select Case DATOS_ORDENESRow("STATUS")
                    Case "INGRESADOINT", "ASIGNADO"
                        ORD_ELIMINARToolStripMenuItem.Visible = True
                        ORD_EMITIR_ToolStrip.Visible = True
                        ORD_CANCELAR_ToolStrip.Visible = True
                        ORD_MARCACOORDINAR_ToolStrip.Visible = True
                        ORD_AGENDAR_ToolStrip.Visible = True
                        ORD_CREARORDBOTToolStrip.Visible = True
                    Case "COORDINADO", "COORDINAR"
                        ORD_EMITIR_ToolStrip.Visible = True
                        ORD_CANCELAR_ToolStrip.Visible = True
                        ORD_MARCACOORDINAR_ToolStrip.Visible = True
                        ORD_AGENDAR_ToolStrip.Visible = True
                        If DATOS_ORDENESRow.IsFECHAAGENDNull = False Then
                            ORD_AGENDAR_ToolStrip.Text = "DESAGENDAR"
                        End If
                        ORD_CREARORDBOTToolStrip.Visible = True
                    Case "INICIADO"
                        ORD_FINALIZAR_ToolStrip.Visible = False
                        ORD_CANCELAR_ToolStrip.Visible = True
                    Case "AGENDADO"
                        'ORD_STATUS_ToolStrip.Visible = False
                        ORD_ELIMINARToolStripMenuItem.Visible = True
                        ORD_Separator2.Visible = False
                        ORD_Separator3.Visible = False
                        ORD_AGENDAR_ToolStrip.Text = "DESAGENDAR"
                        ORD_AGENDAR_ToolStrip.Visible = True
                    Case "CANCELADO"
                        ORD_ELIMINARToolStripMenuItem.Visible = True
                        ORD_Separator2.Visible = False
                        ORD_Separator1.Visible = False
                        ORD_Separator3.Visible = False
                        ORDSeparator4.Visible = False
                        ORD_MARCACREAR_ToolStrip.Visible = False
                        ORD_EDITAR_ToolStrip.Text = "ORDEN Y ADJUNTOS"
                        ORD_IRAORDEN_ToolStrip.Visible = False

                    Case "FINALIZADO", "DUPLICADO", "ADUPLICAR"
                        ORD_Separator2.Visible = False
                        ORD_Separator1.Visible = False
                        ORD_Separator3.Visible = False
                        ORDSeparator4.Visible = False
                        ORD_MARCACREAR_ToolStrip.Visible = False
                        ORD_EDITAR_ToolStrip.Text = "ORDEN Y ADJUNTOS"
                        ORD_IRAORDEN_ToolStrip.Visible = False
                    Case "INGORDINAL"
                        ORD_EMITIR_ToolStrip.Visible = True
                        ORD_ELIMINARToolStripMenuItem.Visible = True
                        ORD_STATUS_ToolStrip.Visible = True
                        ORD_AGENDAR_ToolStrip.Visible = True
                        ORD_MARCACOORDINAR_ToolStrip.Visible = True
                        ORD_Separator3.Visible = False
                        ORD_CANCELAR_ToolStrip.Visible = True
                End Select
                If DATOS_ORDENESRow.NRO_ORDINAL <> 0 Then
                    ORD_VER_RUSToolStrip.Visible = True
                Else
                    ORD_VER_RUSToolStrip.Visible = False
                End If
                Select Case DATOS_ORDENESRow("STATUS")
                    Case "FINALIZADO"
                        If DATOS_ORDENESRow("SECTOROPE") = "DISEÑO" Then
                            ORD_REACTIVARToolStrip.Visible = True
                        End If
                        ORD_STATUS_ToolStrip.Text = "VER ORDEN FINALIZADA"

                    Case "CANCELADO"
                        ORD_STATUS_ToolStrip.Text = "VER ORDEN CANCELADA"
                    Case "DUPLICADO"
                        ORD_STATUS_ToolStrip.Text = "VER ORDEN DUPLICADA"
                    Case "ADUPLICAR"
                        ORD_STATUS_ToolStrip.Text = "VER ORDEN A DUPLICAR"
                End Select
                ORDENESDataGridView.ContextMenuStrip = MENU_ORDEN
            End If
        End If
        If ORDENESDataGridView.Rows.Count > 0 Then
            Dim ORDEN_SEL As Integer = ORDENESDataGridView.CurrentRow.Cells(3).Value
            Dim ORDEN_DEPEND As Integer

            If IsDBNull(ORDENESDataGridView.CurrentRow.Cells(16).Value) = False Then ORDEN_DEPEND = ORDENESDataGridView.CurrentRow.Cells(16).Value
            For X = 0 To ORDENESDataGridView.Rows.Count - 1

                If IsDBNull(ORDENESDataGridView.Rows(X).Cells(16).Value) = False And CK_DATOS_SEL_UNITARIA.Checked = False And ORDEN_DEPEND <> 0 Then
                    If ORDEN_SEL = ORDENESDataGridView.Rows(X).Cells(16).Value Or ORDEN_DEPEND = ORDENESDataGridView.Rows(X).Cells(16).Value Or ORDEN_DEPEND = ORDENESDataGridView.Rows(X).Cells(3).Value Then
                        ORDENESDataGridView.Rows(X).Selected = True
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub ORDENESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ORDENESDataGridView.DoubleClick
        EDITAR_ORDEN()
    End Sub
    Public Sub LLENA_TRABAJOS()
        Dim CARGA_NUEVOTRABAJOFUENTEDIFERENTE As Boolean = True
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            Select Case ACCESO_DESDE
                Case "FUENTES"
                    TRABAJOSTableAdapter.FillByIDGESTIONZONAINSTRUS(ORDENESDataSet.TRABAJOS, DATOS_GESTIONRow("Id_GESTION"), FUENTE_ZONA, FUENTE_INSTALACIONRUS)
                    Select Case ORDENESDataSet.TRABAJOS.Rows.Count
                        Case 0
                            CARGA_NUEVOTRABAJOFUENTES()
                        Case Else
                            For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                                If FUENTE_TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X).Item("TIPOTRABAJO") And ORDENESDataSet.TRABAJOS.Rows(X).Item("STATUS") <> "FINALIZADO" Then
                                    CARGA_NUEVOTRABAJOFUENTEDIFERENTE = False
                                    Exit For
                                End If
                            Next
                            If CARGA_NUEVOTRABAJOFUENTEDIFERENTE = True Then
                                If NUEVOTRABAJO.Visible = False Then
                                    CARGA_NUEVOTRABAJOFUENTES()
                                End If
                            Else
                                DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows(TRABAJOSBindingSource.Position)
                                CARGA_TRABAJOS()
                                ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
                                CARGA_VALORESORDENES()
                            End If
                            For I = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                                Select Case TRABAJOSDataGridView.Item(9, I).Value
                                    Case "FINALIZADO"
                                        TRABAJOSDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DimGray
                                End Select
                            Next I
                    End Select
                Case "MISGESTIONES", "BUSCADOR"
                    If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                        NROTRABAJO = TRABAJOSDataGridView.CurrentRow.Cells.Item(1).Value
                        DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows.Find(NROTRABAJO)

                        CARGA_TRABAJOS()
                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
                        CARGA_VALORESORDENES()
                        If ORDENESDataSet.ORDENES.Rows.Count < 1 Then
                            ORDENESDataSet.ORDENES.Clear()
                        End If
                    Else
                        BORRA_ETIQUETAS()
                    End If
                Case Else
                    TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, DATOS_GESTIONRow("ID_GESTION"))
                    TRABAJOSBindingSource.MoveLast()
                    If TRABAJOSBindingSource.Count > 0 Then
                        'CARGA TRABAJOS ASOCIADOS
                        DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows(TRABAJOSBindingSource.Position)

                        CARGA_TRABAJOS()
                        'PINTA LOS TRABAJOS FINALIZADOS

                        NROTRABAJO = DATOS_TRABAJORow("ID_TRABAJO")
                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, NROTRABAJO)
                        CARGA_VALORESORDENES()
                        If ORDENESDataSet.ORDENES.Rows.Count < 1 Then
                            ORDENESDataSet.ORDENES.Clear()
                        End If
                    Else

                        BORRA_ETIQUETAS()
                    End If
            End Select

            If VER_HISTTRABAJOS.Checked = True Then
                If DATOS_TRABAJORow.RowState = DataRowState.Unchanged Then
                    Me.HISTORICOTableAdapter.FillByIDTRABAJO(ORDENESDataSet.HISTORICO, DATOS_TRABAJORow("ID_TRABAJO"))
                    Me.HISTORICOBindingSource.MoveLast()
                    LLENA_HISTORICOTRABAJOS()
                End If
            End If

        Else
            BORRA_ETIQUETAS_GEST()
            BORRA_ETIQUETAS()
            BORRA_ETIQUETAS_ORDEN()
        End If
    End Sub
    Private Sub BORRA_ETIQUETAS()
        'BORRA TODOS LAS ETIQUETAS SI NO HAY TRABAJOS
        'ETI_TRABDESCRIPCION.Text = ""
        'TRAB_ZONALBL.Text = ""
        'ETI_TRABTIPO.Text = "Tipo Trabajo"
        'ETI_TRABNODO.Text = "Nodo"
        'ETI_TRABZONA.Text = "Zona"
        'ETI_TRABMZNA.Text = "Mzna"
        'ETI_TRABCALLEYNRO.Text = "Calle y Nro"
        'ETI_TRABINIEST.Text = "Inicio Estimado"
        'ETI_TRABTESTIM.Text = "Tiempo Estimado"
        'ETI_TRABDEP.Text = "Depende de"
        'ETI_TRABTIPODEP.Text = "Tipo Dependencia"
        'ETI_TRABGENERADOX.Text = "Generado por"
        'ETI_TRABASIGNADOA.Text = "Asignado a"
        LBL_ADJUNTOS.Visible = False
        BTN_AGREGAR_ZONA.Visible = False
        BTN_VER_PLANOS.Visible = False
        BTN_AGREGAR.Visible = False
        BTN_BORRAR.Visible = False
        ETI_TRABGENERADOX.Visible = False
        FILTRO_ZONA.Visible = False
        BOT_FILTRAZONA.Visible = False
        ETI_TRABNODO.Visible = False
        BTN_AGREGAR.Visible = False
        ETI_TRABCALLEYNRO.Visible = False
        ADJUNTOSDataGridView.Visible = False
        ETI_TRABDESCRIPCION.Visible = False
        VER_HISTTRABAJOS.Visible = False
        ETI_TRABMZNA.Visible = False
        ORDENESDataSet.ADJUNTOS.Clear()
        ORDENESDataSet.TRABAJOS.Clear()
        ORDENESDataSet.ORDENES.Clear()
        TRABAJOSDataGridView.Visible = False
        'BORRA TODAS LAS ETIQUETAS SI NO HAY ORDENES
        'TXT_OBS.Text = ""
        'ING_NODO.Text = ""
        'ING_ZONA.Text = ""
        'ING_TIPO.Text = ""
        'ORDEN_TIPODEP.Text = ""
        'ORDEN_CLASEDEP.Text = ""
        'ORDEN_ORDENDEP.Text = ""
        'ORDEN_TIEMPOPREVISTO.Text = ""
        'ORDEN_ORDENORIG.Text = ""
        'ORDEN_DEPENDENCIA.Text = ""
        'ORDEN_GENERADOX.Text = ""
    End Sub
    Private Sub BORRA_ETIQUETAS_ORDEN()
        ORDENESDataGridView.Visible = False
        LBL_ORDEN_DATOS.Visible = False
        VER_HISTORDENES.Visible = False
        LBL_ORD_NODO.Visible = False
        TXT_OBS.Visible = False
        CK_DATOS_SEL_UNITARIA.Visible = False
    End Sub
    Private Sub BORRA_ETIQUETAS_GEST()
        GENERADOPOR.Visible = False
        VER_HISTGESTION.Visible = False
        SOLICITADOPOR.Visible = False
        GEST_DESCRIPCION.Text = ""
        DIRECCION_GEST.Visible = False
        TIPOGESTION.Text = "Tipo Gestion:"
        INICIOGESTION.Text = "Inicio Estimado"
        TIEMESTIMADO.Text = "Tiempo  Estimado"
        SOLICITADOPOR.Text = "Solicitado por"
        GENERADOPOR.Text = "Generado por"
        CONTACTO.Text = "Contacto"
        TELEFONO.Text = "Telefono"
        MAIL.Text = "Mail"
        RESPONSABLE.Text = "Responsable"
        BOX_HISTGESTION.Visible = False
        VER_HISTGESTION.Checked = False
        GESTIONDataGridView.Visible = False
        CONTACTO.Visible = False
        TELEFONO.Visible = False
        GEST_DESCRIPCION.Visible = False
        TIEMESTIMADO.Visible = False
        INICIOGESTION.Visible = False
    End Sub
    Private Sub BUSCA_NODO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BUSCA_NODO.SelectedIndexChanged
        'ORDENESDataSet.Clear()
        Cursor = Cursors.WaitCursor

        'CARGA LA VARIABLE PARA FILTRAR X NODO
        ING_ZONA.Text = ""
        FILTRONODO = BUSCA_NODO.Text
        'DIFERENCIA LAS GESTIONES COMUNES DE LAS DE RELEVAMIENTO PREGESTION, SI EXISTE UN NODO SELECCIONADO
        'BUSCA LAS GESTIONES PENDIENTES, SI NO CARGA COMO UNICA GESTION POSIBLE DE CREACION UN "RELEVAMIENTO PRE GESTION
        If BUSCA_NODO.SelectedItem.ToString <> "" Then
            VARGEST_TIPO = ""
            TIPOGESTION.Text = "Tipo Gestion: "
            GEST_NODO.Text = BUSCA_NODO.Text
            LBL_ATRIBUTO1.Text = "TODOS"
            'BOT_ORDENES.Visible = True
            'BORRA LOS DATOS PARA PREPARASE PARA LA NUEVA CARGA DE GESTIONES
            CONDINI_GESTION()
            'LLAMA A LAS GESTIONES PENDIENTES DEL NODO SELECCIONADO, DE ACUERDO A SI ES DE FUENTES O NO
            If INGRESO_AREA = "FUENTES" Then
                Me.GESTIONTableAdapter.FillByTIPO_STATUS_NODO(Me.ORDENESDataSet.GESTION, FUENTE_GESTION, GEST_NODO.Text)
                GESTIONBindingSource.MoveLast()
                If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                    DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(GESTIONBindingSource.Position)
                End If
            Else
                If BUSCA_NODO.Text = "PRE-G" Then
                    GESTIONTableAdapter.FillByPREGESTION(ORDENESDataSet.GESTION)
                Else
                    GESTIONTableAdapter.FillByREDPENDIENTE(Me.ORDENESDataSet.GESTION, GEST_NODO.Text)
                End If

                GESTIONBindingSource.MoveLast()
                If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                    DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(GESTIONBindingSource.Position)
                Else
                    MsgBox("Todo parece estar en orden...", vbInformation)

                End If
                'End If
            End If
        Else
            'CARGA AUTOMATICA DE RELEVAMIENTO PREGESTION
            'BOT_ORDENES.Visible = False
            VARGEST_TIPO = "RELEVAMIENTO PRE GESTION"
            TIPOGESTION.Text = "Tipo Gestion: " & VARGEST_TIPO

        End If

        'SI EXISTEN GESTIONES PENDIENTES CARGADAS
        If IsDBNull(DATOS_GESTIONRow) = False Then
            'SI HAY GESTIONES CARGADAS
            If ACCESO_DESDE <> "FUENTES" Then
                GESTIONBindingSource.MoveLast()
            End If
            LLENA_CAMPOSGESTION()

        Else
            'SI NO HAY GESTIONES CARGADAS
            If ACCESO_DESDE = "FUENTES" Then
                CARGA_NUEVAGESTIONFUENTES()
            End If
        End If

        Cursor = DefaultCursor
        FILTROZONA = ""
        GESTIONDataGridView.Focus()
        LLENA_TRABAJOS()
    End Sub
    Public Sub CARGA_VALORESORDENES()
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            ORDENESDataGridView.Visible = True
            LBL_ORDEN_DATOS.Visible = True
            VER_HISTORDENES.Visible = True
            LBL_ORD_NODO.Visible = True
            TXT_OBS.Visible = True
            CK_DATOS_SEL_UNITARIA.Visible = True
            ' PINTA_ORDENES()
            ORDENESDataGridView.Refresh()
            'For C = 0 To ORDENESDataGridView.Rows.Count - 1
            '    ORDENESDataGridView.Rows(C).Height = 30
            'Next
            'ORDENESDataGridView.CurrentRow.Height = 40

            NROORDENINT = ORDENESDataGridView.CurrentRow.Cells.Item(3).Value
            DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows.Find(NROORDENINT)

            STATUSORD = DATOS_ORDENESRow("STATUS")
            NROORDENINT = DATOS_ORDENESRow("NRO_ORDENINT")
            NROORDINAL = DATOS_ORDENESRow("NRO_ORDINAL")

            'FIJA EL ROW DE LA ORDEN SELECCIONADA
            DATOS_ORDENAAGENDARRow = ORDENESDataSet.ORDENES.Rows.Find(NROORDENINT)

            If VER_HISTORDENES.Checked = True Then
                Me.Cursor = Cursors.WaitCursor
                'CARGA DATOS HISTORICO
                Me.HISTORICOTableAdapter.FillByORDENINT(OrdenesDataSet2.HISTORICO, NROORDENINT)
                LLENA_HISTORICOORDENES()
                Me.Cursor = DefaultCursor
            End If
            If IsDBNull(DATOS_ORDENESRow("TIPODEP")) = False Then
                ORDEN_TIPODEPENDENCIA = DATOS_ORDENESRow("TIPODEP")
            Else
                MsgBox("La Orden seleccionada no tiene CLASE DE DEPENDENCIA, se le cargara 'IND' por default ")
                ORDEN_TIPODEPENDENCIA = "IND"
                DATOS_ORDENESRow("TIPODEP") = "IND"
                DATOS_ORDENESRow("CLASEDEP") = "IND"
                ORDENESTableAdapter.Update(DATOS_ORDENESRow)
                Exit Sub
            End If
            ORDTIPO = DATOS_ORDENESRow("TIPO")
            ORDNODO = DATOS_ORDENESRow("NODO")
            ORDZONA = DATOS_ORDENESRow("ZONA")
            ORDFALLAORIG = DATOS_ORDENESRow("MOTIVOORIGEN")
            ORDCAUSAING = DATOS_ORDENESRow("CAUSARIGEN")
            ORDGENERADO = DATOS_ORDENESRow("GENERADOR")
            ORDPRIORIDAD = DATOS_ORDENESRow("PRIORIDAD")
            ORDSECTOROPE = DATOS_ORDENESRow("SECTOROPE")
            STATUSORD = DATOS_ORDENESRow("STATUS")

            'ING_NODO.Text = ORDNODO
            'ING_ZONA.Text = ORDZONA
            ING_TIPO.Text = ORDTIPO
            LBL_ORD_NODO.Text = "Nodo: " & ORDNODO & "  Zona: " & ORDZONA
            LBL_ORDEN_DATOS.Text = "Generada por: " & DATOS_ORDENESRow("GENERADOR")
            If IsDBNull(DATOS_ORDENESRow("CLASEDEP")) = False Then
                If DATOS_ORDENESRow("CLASEDEP") <> "" Then
                    LBL_ORDEN_DATOS.Text += "  | Dependencia: Clase: " & DATOS_ORDENESRow("CLASEDEP") & " - Tipo: " & DATOS_ORDENESRow("TIPODEP")
                End If
                ORDEN_CLASEDEP.Text = DATOS_ORDENESRow("CLASEDEP")
            End If
            If IsDBNull(DATOS_ORDENESRow("DEPENDENCIA")) = False Then
                If DATOS_ORDENESRow("DEPENDENCIA") <> 0 Then
                    LBL_ORDEN_DATOS.Text += " | Orden origen: " & DATOS_ORDENESRow("ORDORIGEN") & " - Depende de: " & DATOS_ORDENESRow("DEPENDENCIA")
                End If
                ORDEN_DEPENDENCIA.Text = DATOS_ORDENESRow("DEPENDENCIA")
            End If
            If IsDBNull(DATOS_ORDENESRow("FECHA_ASIGNADA")) = False Then
                If IsDate(DATOS_ORDENESRow("FECHA_ASIGNADA")) Then LBL_ORDEN_DATOS.Text += " | Asignado desde: " & DATOS_ORDENESRow("FECHA_ASIGNADA")

            End If

            If IsDBNull(DATOS_ORDENESRow("ORDENDEP")) = False Then
                ORDEN_ORDENDEP.Text = DATOS_ORDENESRow("DEPENDENCIA")
            End If
            If IsDBNull(DATOS_ORDENESRow("TIPODEP")) = False Then
                ORDEN_TIPODEP.Text = DATOS_ORDENESRow("TIPODEP")
            End If
            If IsDBNull(DATOS_ORDENESRow("ORDORIGEN")) = False Then
                If DATOS_ORDENESRow("ORDORIGEN").ToString <> "" Then
                    SEL_ORDENORIG = DATOS_ORDENESRow("ORDORIGEN")
                    SEL_ORDENSELEC = DATOS_ORDENESRow("ORDORIGEN")
                End If
                Select Case DATOS_ORDENESRow("CLASEDEP")
                    Case "EST", "DIN"
                        ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                    Case "IND"
                        ING_ORDORIGEN = NROORDENINT
                End Select
            End If

            ORDEN_GENERADOX.Text = DATOS_ORDENESRow("GENERADOR")
            ORDEN_TIEMPOPREVISTO.Text = DATOS_ORDENESRow("TPREVISTO") & " %"
            If IsDBNull(DATOS_ORDENESRow("TPREVISTO")) = False Then
                TIEMPO_AGENDA = CInt(DATOS_ORDENESRow("TPREVISTO") * CAPACIDAD_DIA / 100)
            Else
                TIEMPO_AGENDA = 0
            End If
            If IsDBNull(DATOS_ORDENESRow("CUADRILLA")) = False Then
                ORDASIGNADO = DATOS_ORDENESRow("CUADRILLA")
            Else
                ORDASIGNADO = ""
            End If
            If DATOS_ORDENESRow("STATUS") = "FINALIZADO" Then
                ORDFALLACIERRE = DATOS_ORDENESRow("MOTIVOCIERRE")
                ORDCAUSACIERRE = DATOS_ORDENESRow("CAUSACIERRE")
            Else
                ORDFALLACIERRE = ""
                ORDCAUSACIERRE = ""
            End If
            OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, DATOS_ORDENESRow("NRO_ORDENINT"))
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                ORDOBSERVACION = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
                TXT_OBS.Text = ORDOBSERVACION
            Else
                OBESERVACIONESTableAdapter.FillByNROORDINAL(ORDENESDataSet.OBESERVACIONES, DATOS_ORDENESRow.NRO_ORDINAL)
                If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    TXT_OBS.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
                Else
                    ' MsgBox("OOOPS!!!" & vbNewLine & "LA ORDEN QUEDÓ MAL GENERADA, INGRESE A MODIFICAR LA ORDEN PARA CARGAR LAS OBSERVACIONES")
                    TXT_OBS.Text = ""
                End If
            End If
            'VARIALBLES PARA UTILIZAR EN AGENDA
            'If ORDEN_ORDENORIG.Text <> "" Then
            '    SEL_ORDENORIG = ORDEN_ORDENORIG.Text
            '    SEL_ORDENSELEC = ORDEN_ORDENORIG.Text
            'End If
            SEL_SECTOROPERATIVO = ORDSECTOROPE
            SEL_PRIORIDAD = ORDPRIORIDAD

            If DATOS_ORDENESRow.IsSECTORGENNull = False Then
                SEL_SECTORGENERADOR = DATOS_ORDENESRow.SECTORGEN
            Else
                NOTIFICACION("SYS", "La orden seleccionada no tiene definido SECTOR GENERADOR, se le cargara segun su trabajo dependiente")
                Select Case DATOS_TRABAJORow("SECTORASIG")
                    Case "PLANIFICACION TECNICA", "GERENCIA", "JEFATURA"
                        DATOS_ORDENESRow.SECTORGEN = "PT"
                    Case "SUPERVISION"
                        DATOS_ORDENESRow.SECTORGEN = "SU"
                    Case "OBRA CIVIL"
                        DATOS_ORDENESRow.SECTORGEN = "OC"
                    Case Else
                        DATOS_ORDENESRow.SECTORGEN = "SC"
                End Select
                ORDENESTableAdapter.Update(DATOS_ORDENESRow)
                Exit Sub
            End If

            If DATOS_ORDENESRow.IsFECHAAGENDNull Then
                SEL_FECHAORDEN = ""
            Else
                SEL_FECHAORDEN = DATOS_ORDENESRow.FECHAAGEND
            End If
        Else
            BORRA_ETIQUETAS_ORDEN()
        End If

    End Sub
    Public Sub CARGA_HISTORICO() 'RUTINA PARA LOS CAMBIOS DE STATUS
        DATOS_NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
        DATOS_STATUSANT = DATOS_GESTIONRow("STATUS")
        If TIPOREGISTRO = "ORDEN" Then
            If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            Else
                DATOS_STATUSANT = "-------"
            End If
            DATOS_NewHISTORICORow("ID_GESTION") = DATOS_GESTIONRow("Id_GESTION")
            DATOS_NewHISTORICORow("ID_TRABAJO") = DATOS_TRABAJORow("ID_TRABAJO")
            DATOS_NewHISTORICORow("ID_ORDENINT") = DATOS_ORDENESRow("NRO_ORDENINT")
        End If
        If TIPOREGISTRO = "TRABAJO" Then
            DATOS_NewHISTORICORow("ID_GESTION") = DATOS_GESTIONRow("ID_GESTION")
            DATOS_NewHISTORICORow("ID_TRABAJO") = DATOS_TRABAJORow("ID_TRABAJO")
            DATOS_NewHISTORICORow("ID_ORDENINT") = 0
        End If
        If TIPOREGISTRO = "GESTION" Then
            DATOS_NewHISTORICORow("ID_GESTION") = DATOS_GESTIONRow("ID_GESTION")
            DATOS_NewHISTORICORow("ID_TRABAJO") = 0
            DATOS_NewHISTORICORow("ID_ORDENINT") = 0
        End If

        DATOS_NewHISTORICORow("FECHA") = Now
        DATOS_NewHISTORICORow("STATUSANTERIOR") = DATOS_STATUSANT
        DATOS_NewHISTORICORow("EJECUTANTE") = FULLNOMBRE
        DATOS_NewHISTORICORow("STATUSACTUAL") = DATOS_HIS_STATUSACTUAL
        DATOS_NewHISTORICORow("CAUSA") = DATOS_HIS_CAUSA
        DATOS_NewHISTORICORow("DETALLE") = DATOS_HIS_DETALLE

        'GUARDA EL HISTORICO PROCESADO
        ORDENESDataSet.HISTORICO.AddHISTORICORow(DATOS_NewHISTORICORow)
        HISTORICOTableAdapter.Update(ORDENESDataSet.HISTORICO)

    End Sub 'GENERA HISTORICO
    Public Sub ENVIA_MENSAJE()
        'ENVIA MENSAJE 
        DATOS_NewMENSAJE = ORDENESDataSet.MENSAJERIA.NewMENSAJERIARow
        DATOS_NewMENSAJE("FECHACREADO") = Now
        DATOS_NewMENSAJE("TIPOMENSAJE") = "INFORMACION AUTOMATICA"
        DATOS_NewMENSAJE("ASUNTO") = DATOS_MJE_ASUNTO
        DATOS_NewMENSAJE("ORIGEN_NOMBRE") = NOMBRE & " " & APELLIDO
        DATOS_NewMENSAJE("ORIGEN_SECTOR") = ""
        DATOS_NewMENSAJE("DESTINO_NOMBRE") = DATOS_MJE_DESTINONOMBRE
        DATOS_NewMENSAJE("DESTINO_SECTOR") = DATOS_MJE_DESTINOSECTOR
        DATOS_NewMENSAJE("MENSAJE") = DATOS_MJE_MENSAJE
        DATOS_NewMENSAJE("TIPO_ORDENASOC") = "ORDEN INTERNA"
        'DATOS_NewMENSAJE("NRO_ORDENASOC") = MJE_NROORDENASOC

        ORDENESDataSet.MENSAJERIA.AddMENSAJERIARow(DATOS_NewMENSAJE)
        MENSAJERIATableAdapter.Update(DATOS_NewMENSAJE)
    End Sub ' ENVIA MENSAJES
    Public Sub CONDINI_GESTION()
        GEST_DESCRIPCION.Visible = True
        GEST_DESCRIPCION.ReadOnly = True
        ' GEST_NODO.Enabled = True
        BOT_NUEVAGEST.Enabled = True
    End Sub
    Private Sub CARGA_NUEVAGESTIONFUENTES()
        'BUSCA   SI HAY GESTIONES INGRESADAS CON EL TIPO SELECCIONADO EN STATUS "INGRESADO" O STATUS "INICADO"
        Select Case ORDENESDataSet.GESTION.Rows.Count
            Case 0
                'PIDE CONFIRMACION______________________________________________________________________________________________________________________________________
                Dim Msg, Style, Title, Response ', Mystring
                Msg = ("No existen GESTIONES creadas con el tipo " & FUENTE_GESTION & vbNewLine & vbNewLine &
                    "Se creara una GESTION con los siguientes datos : " & vbNewLine &
                    "TIPO GESTION: " & FUENTE_GESTION & vbNewLine &
                    "GENERADO POR: " & NOMBRE & " " & APELLIDO & vbNewLine &
                    "SECTOR ORIGEN: " & SECTOR)

                Style = vbOKCancel + vbQuestion + vbDefaultButton1
                Title = "Verificacion de existencia de GESTION"

                Response = MsgBox(Msg, Style, Title)
                If Response = vbOK Then

                    TIPOACCION = "NUEVO"
                    NUEVAGESTION.Show()
                    Me.Enabled = False
                    ORDENESDataSet.TRABAJOS.Clear()
                    ORDENESDataSet.ORDENES.Clear()

                    'Mystring = "SI"
                Else

                    CONDINI_GESTION()

                End If

        End Select
    End Sub
    Private Sub CARGA_COMBOSTRA()
        'BORRA LOS ITEMS DE COMBOS
        GEST_TRAB1_TOOLS.Visible = False
        GEST_TRAB2_TOOLS.Visible = False
        GEST_TRAB3_TOOLS.Visible = False
        GEST_TRAB4_TOOLS.Visible = False
        GEST_TRAB5_TOOLS.Visible = False
        GEST_TRAB6_TOOLS.Visible = False

        TRAB_ITEM1_ToolStrip.Visible = False
        TRAB_ITEM2_ToolStrip.Visible = False
        TRAB_ITEM3_ToolStrip.Visible = False
        TRAB_ITEM4_ToolStrip.Visible = False
        TRAB_ITEM5_ToolStrip.Visible = False
        TRAB_ITEM6_ToolStrip.Visible = False
        TRAB_ITEM7_ToolStrip.Visible = False
        TRAB_ITEM8_ToolStrip.Visible = False
        TRAB_ITEM9_ToolStrip.Visible = False
        TRAB_ITEM10_ToolStrip.Visible = False
        TRAB_ITEM11_ToolStrip.Visible = False

        If GESTIONBindingSource.Count > 0 Then
            GESTIONES_TIPOTableAdapter.FillByTIPO_GESTION(ORDENESDataSet.GESTIONES_TIPO, DATOS_GESTIONRow.TIPOGESTION)
            COMBOSTableAdapter.FillByTIPO_GESTION(ORDENESDataSet.COMBOS, CInt(ORDENESDataSet.GESTIONES_TIPO.Rows(0).Item("GRUPO_GESTION")))
            Dim CUENTA = 0
            For X = 0 To ORDENESDataSet.COMBOS.Rows.Count - 1
                COMBORow = ORDENESDataSet.COMBOS.Rows(X)
                Select Case COMBORow.DESDE
                    Case "GESTION"
                        Select Case CUENTA
                            Case 0
                                GEST_TRAB1_TOOLS.Visible = True
                                GEST_TRAB1_TOOLS.Text = COMBORow.TIPO_TRABAJO
                            Case 1
                                GEST_TRAB2_TOOLS.Visible = True
                                GEST_TRAB2_TOOLS.Text = COMBORow.TIPO_TRABAJO
                            Case 2
                                GEST_TRAB3_TOOLS.Visible = True
                                GEST_TRAB3_TOOLS.Text = COMBORow.TIPO_TRABAJO
                            Case 3
                                GEST_TRAB4_TOOLS.Visible = True
                                GEST_TRAB4_TOOLS.Text = COMBORow.TIPO_TRABAJO
                            Case 4
                                GEST_TRAB5_TOOLS.Visible = True
                                GEST_TRAB5_TOOLS.Text = COMBORow.TIPO_TRABAJO
                            Case 5
                                GEST_TRAB6_TOOLS.Visible = True
                                GEST_TRAB6_TOOLS.Text = COMBORow.TIPO_TRABAJO
                        End Select
                        CUENTA += 1
                    Case "TRABAJO"
                        Select Case X
                            Case 0
                                TRAB_ITEM1_ToolStrip.Visible = True
                                TRAB_ITEM1_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 1
                                TRAB_ITEM2_ToolStrip.Visible = True
                                TRAB_ITEM2_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 2
                                TRAB_ITEM3_ToolStrip.Visible = True
                                TRAB_ITEM3_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 3
                                TRAB_ITEM4_ToolStrip.Visible = True
                                TRAB_ITEM4_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 4
                                TRAB_ITEM5_ToolStrip.Visible = True
                                TRAB_ITEM5_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 5
                                TRAB_ITEM6_ToolStrip.Visible = True
                                TRAB_ITEM6_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 6
                                TRAB_ITEM7_ToolStrip.Visible = True
                                TRAB_ITEM7_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 7
                                TRAB_ITEM8_ToolStrip.Visible = True
                                TRAB_ITEM8_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 8
                                TRAB_ITEM9_ToolStrip.Visible = True
                                TRAB_ITEM9_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 9
                                TRAB_ITEM10_ToolStrip.Visible = True
                                TRAB_ITEM10_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                            Case 10
                                TRAB_ITEM11_ToolStrip.Visible = True
                                TRAB_ITEM11_ToolStrip.Text = COMBORow.TIPO_TRABAJO
                        End Select
                End Select
            Next
        End If
        '    Select Case INGRESO_AREA
        '        Case "RED"
        '            'FILL CON  DESDE = "GESTION" & INGRESO_AREA="RED"
        '            Select Case VARGEST_TIPO
        '                Case "MANT DISTRIBUCION", "MANT TRONCALES", "MANT FIBRA", "MODIF DE RED", "CONST DE RED", "MANT SOPORTES DE RED", "PREVENTIVO PUNTUAL", "MANT DISTRIBUCION - CRUCES"
        '                                                                           'FILL CON DESDE="TRABAJO" & INGRESO_AREA = "RED"
        '                Case "RELEVAMIENTO PRE GESTION"   'FILL CON DESDE="GESTION" & TIPO_GESTION = "9"
        '                    GEST_TRAB1_TOOLS.Visible = True
        '                    GEST_TRAB1_TOOLS.Text = "RELEVAMIENTO"

        '            End Select
        '        Case "FUENTES"
        '            Select Case DATOS_GESTIONRow("TIPOGESTION")

        '                Case "MANTENIMIENTO PROGRAMADO DE FUENTES"
        '                    GEST_TRAB1_TOOLS.Visible = True
        '                    GEST_TRAB1_TOOLS.Text = FUENTE_TRABAJO

        '                Case "MANTENIMIENTO PREVENTIVO DE FUENTES"
        '                    GEST_TRAB1_TOOLS.Visible = True
        '                    GEST_TRAB1_TOOLS.Text = FUENTE_TRABAJO

        '                    'FILL CON TIPO_GESTION = "11"

        '                    TRAB_ITEM1_ToolStrip.Visible = True
        '                    TRAB_ITEM1_ToolStrip.Text = "RELEVAMIENTO"
        '                    TRAB_ITEM2_ToolStrip.Visible = True
        '                    TRAB_ITEM2_ToolStrip.Text = "REEMPLAZO DE FUENTE"
        '                    TRAB_ITEM3_ToolStrip.Visible = True
        '                    TRAB_ITEM3_ToolStrip.Text = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        '                    TRAB_ITEM4_ToolStrip.Visible = True
        '                    TRAB_ITEM4_ToolStrip.Text = "REPARACION DE FUENTE"
        '                    TRAB_ITEM5_ToolStrip.Visible = True
        '                    TRAB_ITEM5_ToolStrip.Text = "CAMBIO DE UBICACION"
        '                    TRAB_ITEM6_ToolStrip.Visible = True
        '                    TRAB_ITEM6_ToolStrip.Text = "TRABAJOS DE RED"
        '                    TRAB_ITEM7_ToolStrip.Visible = True
        '                    TRAB_ITEM7_ToolStrip.Text = "ACTUALIZACION PLANOS"

        '                Case "INSTALACION / RETIRO DE FUENTE X OBRA"
        '                    GEST_TRAB1_TOOLS.Visible = True
        '                    GEST_TRAB1_TOOLS.Text = FUENTE_TRABAJO

        '                    'FILL CON TIPO_GESTION = "12"
        '                    TRAB_ITEM1_ToolStrip.Visible = True
        '                    TRAB_ITEM1_ToolStrip.Text = "INSTALACION DE FUENTE X OBRA"
        '                    TRAB_ITEM2_ToolStrip.Visible = True
        '                    TRAB_ITEM2_ToolStrip.Text = "RETIRO DE FUENTE X OBRA"
        '                    TRAB_ITEM3_ToolStrip.Visible = True
        '                    TRAB_ITEM3_ToolStrip.Text = "ACTUALIZACION PLANOS"
        '                Case "TRABAJOS DE LABORATORIO"
        '                    GEST_TRAB1_TOOLS.Visible = True
        '                    GEST_TRAB1_TOOLS.Text = FUENTE_TRABAJO
        '            End Select

        '        Case "MDU"
        '            GEST_TRAB1_TOOLS.Visible = True
        '            GEST_TRAB1_TOOLS.Text = "RELEVAMIENTO"
        '            GEST_TRAB2_TOOLS.Visible = True
        '            GEST_TRAB2_TOOLS.Text = "ADMINISTRATIVO"
        '            GEST_TRAB3_TOOLS.Visible = True
        '            GEST_TRAB3_TOOLS.Text = "DISEÑO"
        '            GEST_TRAB4_TOOLS.Visible = True
        '            GEST_TRAB4_TOOLS.Text = "PREDICTIVO"
        '            GEST_TRAB5_TOOLS.Visible = True
        '            GEST_TRAB5_TOOLS.Text = "PREVENTIVO"
        '            GEST_TRAB6_TOOLS.Visible = True
        '            GEST_TRAB6_TOOLS.Text = "EJECUCION"

        '            TRAB_ITEM1_ToolStrip.Visible = True
        '            TRAB_ITEM1_ToolStrip.Text = "RELEVAMIENTO"
        '            TRAB_ITEM2_ToolStrip.Visible = True
        '            TRAB_ITEM2_ToolStrip.Text = "ADMINISTRATIVO"
        '            TRAB_ITEM3_ToolStrip.Visible = True
        '            TRAB_ITEM3_ToolStrip.Text = "DISEÑO"
        '            TRAB_ITEM4_ToolStrip.Visible = True
        '            TRAB_ITEM4_ToolStrip.Text = "PRESUPUESTO"
        '            TRAB_ITEM5_ToolStrip.Visible = True
        '            TRAB_ITEM5_ToolStrip.Text = "APROBACION PERMISOS"
        '            TRAB_ITEM6_ToolStrip.Visible = True
        '            TRAB_ITEM6_ToolStrip.Text = "APROBACION IMM"
        '            TRAB_ITEM7_ToolStrip.Visible = True
        '            TRAB_ITEM7_ToolStrip.Text = "AUTORIZACION CABLEADO"
        '            TRAB_ITEM8_ToolStrip.Visible = True
        '            TRAB_ITEM8_ToolStrip.Text = "OBRA CIVIL"



        '    End Select
        'End If
    End Sub
    Private Sub LLENA_HISTORICOGESTION()
        If OrdenesDataSet1.HISTORICO.Rows.Count > 0 Then
            HISTORICO1Row = OrdenesDataSet1.HISTORICO.Rows(HISTORICOBindingSource1.Position)
            If IsDBNull(HISTORICO1Row("CAUSA")) = False Then GEST_CAUSA.Text = HISTORICO1Row("CAUSA")
            If IsDBNull(HISTORICO1Row("DETALLE")) = False Then GEST_DETALLE.Text = HISTORICO1Row("DETALLE")
            GEST_EJECUTANTE.Text = HISTORICO1Row("EJECUTANTE")
        End If
    End Sub
    Private Sub LLENA_HISTORICOTRABAJOS()
        If HISTORICOBindingSource.Position > -1 Then
            HISTORICORow = ORDENESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position)
            If IsDBNull(HISTORICORow("CAUSA")) = False Then HIST_CAUSA.Text = HISTORICORow("CAUSA")
            If IsDBNull(HISTORICORow("DETALLE")) = False Then HIST_DETALLE.Text = HISTORICORow("DETALLE")
            HIS_EJECUTANTE.Text = HISTORICORow("EJECUTANTE")
        End If
    End Sub
    Private Sub LLENA_HISTORICOORDENES()
        If OrdenesDataSet2.HISTORICO.Rows.Count > 0 Then
            HISTORICO2Row = OrdenesDataSet2.HISTORICO.Rows(HISTORICOBindingSource2.Position)
            If IsDBNull(HISTORICO2Row("CAUSA")) = False Then HIST_ORDENCAUSA.Text = HISTORICO2Row("CAUSA")
            If IsDBNull(HISTORICO2Row("DETALLE")) = False Then HIST_ORDENDETALLE.Text = HISTORICO2Row("DETALLE")
            If IsDBNull(HISTORICO2Row("EJECUTANTE")) = False Then HIST_ORDEJECUTANTE.Text = HISTORICO2Row("EJECUTANTE")
        End If
    End Sub
    Public Sub GENERA_RELEVAMIENTO()

        NewRELEVAMIENTO = MDUDataSet.RELEVAMIENTOMDU.NewRELEVAMIENTOMDURow

        NewRELEVAMIENTO("IDGESTION") = DATOS_GESTIONRow("ID_GESTION")
        NewRELEVAMIENTO("IDTRABAJO") = DATOS_TRABAJORow("Id_TRABAJO")
        NewRELEVAMIENTO("CARPETA") = ""
        NewRELEVAMIENTO("SOLICITANTE") = ""
        NewRELEVAMIENTO("NOMBRECONTACTO") = ""
        NewRELEVAMIENTO("TELEFCONTACTO") = ""
        NewRELEVAMIENTO("MAILCONTACTO") = ""
        NewRELEVAMIENTO("CAUSAORIGEN") = ""

        'TOMA EL DATO DE LA FECHA DE FINALIZACION ORDINAL
        NewRELEVAMIENTO("FECHARELEV") = "" ' LO DEBERIA CARGAR DEL ORDINAL
        NewRELEVAMIENTO("EJECUTANTE") = "" ' LO DEBERIA CARGAR DEL ORDINAL
        NewRELEVAMIENTO("NROORDINAL") = ""
        'CARGA DATOS RELEVADOS
        NewRELEVAMIENTO("PISOS") = ""
        NewRELEVAMIENTO("APTOS") = ""
        NewRELEVAMIENTO("BOCAS") = ""
        NewRELEVAMIENTO("NROTAP") = ""
        NewRELEVAMIENTO("MEDTAPCH3") = ""
        NewRELEVAMIENTO("MEDTAPCH70") = ""
        NewRELEVAMIENTO("MEDTAPCH5") = ""
        NewRELEVAMIENTO("ACOMETIDA") = ""
        NewRELEVAMIENTO("MONTANTE") = ""
        NewRELEVAMIENTO("PASIVOS") = ""
        NewRELEVAMIENTO("AMPUBIC") = ""
        NewRELEVAMIENTO("AMPTIPO") = ""
        NewRELEVAMIENTO("MEDENTCH3") = ""
        NewRELEVAMIENTO("MEDENTCH70") = ""
        NewRELEVAMIENTO("MEDENTCH5") = ""
        NewRELEVAMIENTO("MEDENT291") = ""
        NewRELEVAMIENTO("MEDENT327") = ""
        NewRELEVAMIENTO("MEDENT405") = ""
        NewRELEVAMIENTO("MEDENT561") = ""
        NewRELEVAMIENTO("MEDSALCH3") = ""
        NewRELEVAMIENTO("MEDSALCH70") = ""
        NewRELEVAMIENTO("MEDSALCH5") = ""
        NewRELEVAMIENTO("MEDSAL291") = ""
        NewRELEVAMIENTO("MEDSAL327") = ""
        NewRELEVAMIENTO("MEDSAL405") = ""
        NewRELEVAMIENTO("MEDSAL561") = ""
        NewRELEVAMIENTO("ELECSUMI") = ""
        NewRELEVAMIENTO("CAJA") = True
        NewRELEVAMIENTO("STSELECTRICA") = ""
        NewRELEVAMIENTO("STSACOMETIDA") = ""
        NewRELEVAMIENTO("STSMONTANTE") = ""
        NewRELEVAMIENTO("STSAMPLIFICADOR") = ""
        NewRELEVAMIENTO("RETDOMIC") = True
        NewRELEVAMIENTO("PORTERIA") = True
        NewRELEVAMIENTO("PORTDESDE") = ""
        NewRELEVAMIENTO("PORTHASTA") = ""

        MDUDataSet.RELEVAMIENTOMDU.Rows.Add(NewRELEVAMIENTO)
        RELEVAMIENTOMDUTableAdapter.Update(NewRELEVAMIENTO)

    End Sub
    Public Sub CARGA_TRABAJOS()
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            'CARGA EN VARIABLES LOS DATOS DEL TRABAJO SELECCIONADO
            BTN_AGREGAR.Enabled = True
            TRABAJOSDataGridView.Visible = True
            ETI_TRABGENERADOX.Visible = True
            FILTRO_ZONA.Visible = True
            BOT_FILTRAZONA.Visible = True
            ETI_TRABNODO.Visible = True
            BTN_AGREGAR.Visible = True
            ETI_TRABDESCRIPCION.Visible = True
            VER_HISTTRABAJOS.Visible = True

            If IsDBNull(DATOS_TRABAJORow("NODO")) = False Then VARTRAB_NODO = DATOS_TRABAJORow("NODO")
            If IsDBNull(DATOS_TRABAJORow("ZONA")) = False Then VARTRAB_ZONA = DATOS_TRABAJORow("ZONA")

            VARTRAB_GENERADOPOR = DATOS_TRABAJORow("GENERADOX")
            If IsDBNull(DATOS_TRABAJORow("ASIGNADOA")) = False Then
                If DATOS_TRABAJORow("ASIGNADOA") <> "" Then
                    VARTRAB_ASIGNADOA = DATOS_TRABAJORow("ASIGNADOA")
                Else
                    VARTRAB_ASIGNADOA = "Sin asignar"
                End If
            Else
                VARTRAB_ASIGNADOA = "Sin asignar"
            End If
            VARTRAB_TIPO = DATOS_TRABAJORow(("TIPOTRABAJO"))
            If DATOS_TRABAJORow.IsPROYECTO_ORDINALESNull = False Then LBL_PROYECTO.Text = DATOS_TRABAJORow.PROYECTO_ORDINALES Else LBL_PROYECTO.Text = ""
            If IsDBNull(DATOS_TRABAJORow("FECHAINICESTIMADO")) = False Then VARTRAB_INIEST = CDate(DATOS_TRABAJORow("FECHAINICESTIMADO")).ToShortDateString.ToString
            If IsDBNull(DATOS_TRABAJORow("TIEMPOESTIMADO")) = False Then VARTRAB_TIEMEST = DATOS_TRABAJORow("TIEMPOESTIMADO")
                If IsDBNull(DATOS_TRABAJORow("DESCRIPCION")) = False Then VARTRAB_DESCRIPCION = DATOS_TRABAJORow("DESCRIPCION")
                If IsDBNull(DATOS_TRABAJORow("ZONA")) = False Then VARTRAB_ZONA = DATOS_TRABAJORow("ZONA")
                If IsDBNull(DATOS_TRABAJORow("MANZANA")) = False Then VARTRAB_MZNA = DATOS_TRABAJORow("MANZANA")
                If IsDBNull(DATOS_TRABAJORow("CALLE")) = False Then VARTRAB_CALLE = DATOS_TRABAJORow("CALLE")
                If IsDBNull(DATOS_TRABAJORow("NRO")) = False Then VARTRAB_NRO = DATOS_TRABAJORow("NRO")
                If IsDBNull(DATOS_TRABAJORow("TIPODEP")) = False Then VARTRAB_TIPODEP = DATOS_TRABAJORow("TIPODEP") Else VARTRAB_TIPODEP = ""
                If IsDBNull(DATOS_TRABAJORow("DEPENDENCIA")) = False Then VARTRAB_DEP = DATOS_TRABAJORow("DEPENDENCIA") Else VARTRAB_DEP = ""
            If IsDBNull(DATOS_TRABAJORow("ATRIBUTO")) = False Then
                If DATOS_TRABAJORow("ATRIBUTO") = "" Then
                    VARTRAB_ATRIBUTO = "HFC"
                Else
                    VARTRAB_ATRIBUTO = DATOS_TRABAJORow("ATRIBUTO")
                End If
            Else
                VARTRAB_ATRIBUTO = "HFC"
            End If
            'If DATOS_TRABAJORow.GENERADOX <> DATOS_TRABAJORow.ASIGNADOA Then
            '    HISTORICOTableAdapter.FillByIDTRABAJO(OrdenesDataSet4.HISTORICO, DATOS_TRABAJORow.Id_TRABAJO)
            '    If OrdenesDataSet4.HISTORICO.Rows.Count > 0 Then


            '    End If
            'End If
            'CARGA LAS ETIQUETAS DE LECTURA DE LA PANTALLA DATOS
            ETI_TRABTIPO.Text = "Trabajo tipo: " & VARTRAB_TIPO
                'If VARTRAB_ZONA = "" Then ETI_TRABZONA.Visible = False Else ETI_TRABZONA.Visible = True
                'If VARTRAB_MZNA = "" Then ETI_TRABMZNA.Visible = False Else ETI_TRABMZNA.Visible = True
                If VARTRAB_NODO <> "" Then
                    ETI_TRABNODO.Text = VARTRAB_NODO
                    If VARTRAB_ZONA <> "" Then
                        ETI_TRABNODO.Text += VARTRAB_ZONA
                    End If

                End If
                If VARTRAB_MZNA <> "" Then
                    ETI_TRABMZNA.Text = VARTRAB_MZNA
                    ETI_TRABMZNA.Visible = True
                End If
            '  ETI_TRABNODO.Text = "Nodo: " & VARTRAB_NODO & "   Zona: " & VARTRAB_ZONA & "   Mzna: " & VARTRAB_MZNA
            'ETI_TRABZONA.Text =
            'ETI_TRABMZNA.Text =
            ETI_TRABGENERADOX.Text = "Generado por: " & VARTRAB_GENERADOPOR & "   |   Responsable: " & VARTRAB_ASIGNADOA & "   |   Inicio Estimado: " & VARTRAB_INIEST & "   |   Tiempo estimado: " & VARTRAB_TIEMEST & " Días"

            'ETI_TRABINIEST.Text = "Inicio Estimado: " & DateValue(VARTRAB_INIEST).ToShortDateString.ToString
            'ETI_TRABTESTIM.Text = "Tiempo estimado: " & VARTRAB_TIEMEST & " Dias"
            If VARTRAB_CALLE = "" And VARTRAB_NRO = "" Then ETI_TRABCALLEYNRO.Visible = False Else ETI_TRABCALLEYNRO.Visible = True
                ETI_TRABCALLEYNRO.Text = VARTRAB_CALLE & " " & VARTRAB_NRO
                ETI_TRABTIPODEP.Text = "Tipo Dependencia: " & VARTRAB_TIPODEP
                ETI_TRABDEP.Text = "Dependencia " & VARTRAB_DEP
                ETI_TRABDESCRIPCION.Text = VARTRAB_DESCRIPCION
                'CARGA EL HISTORICO DEL TRABAJO
                If VER_HISTTRABAJOS.Checked = True Then
                    HISTORICOTableAdapter.FillByIDTRABAJO(ORDENESDataSet.HISTORICO, DATOS_TRABAJORow("ID_TRABAJO"))
                    HISTORICOBindingSource.MoveLast()
                End If
                'CARGA LOS ADJUNTOS DEL TRABAJO
                ADJUNTOSTableAdapter.FillByORDEN(ORDENESDataSet.ADJUNTOS, DATOS_TRABAJORow("ID_TRABAJO"))
                If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
                    ADJUNTOSDataGridView.Visible = True
                    BTN_BORRAR.Visible = True
                    ' BTN_BORRAR.Enabled = True
                    LBL_ADJUNTOS.Visible = True
                Else
                    BTN_BORRAR.Visible = False
                    LBL_ADJUNTOS.Visible = False
                    ADJUNTOSDataGridView.Visible = False
                End If
                'CARGA LA RUTA PARA VER LOS PLANOS DESDE LA APLICACION
                PLANOSTableAdapter.FillByNODOZONA(INDICESDataSet.PLANOS, DATOS_TRABAJORow.NODO, CInt(DATOS_TRABAJORow.ZONA))
                If INDICESDataSet.PLANOS.Rows.Count > 0 Then
                    BTN_AGREGAR_ZONA.Visible = False
                    BTN_VER_PLANOS.Visible = True
                Else
                    BTN_AGREGAR_ZONA.Visible = True
                    BTN_VER_PLANOS.Visible = False
                End If
                'FORMATEA LAS CELDAS DEL DATAGRID SEGUN SU STATUS Y CONDICION

                If THEME_BLACK Then
                    For C = 0 To TRABAJOSDataGridView.Rows.Count - 1
                        TRABAJOSDataGridView.Rows(C).Height = 21
                        TRABAJOSDataGridView.Rows(C).DefaultCellStyle.ForeColor = Color.White
                        If TRABAJOSDataGridView.Rows(C).Cells(9).Value <> "FINALIZADO" Then
                            If TRABAJOSDataGridView.Rows(C).Cells(11).Value = True Then
                                TRABAJOSDataGridView.Rows(C).DefaultCellStyle.BackColor = Color.DarkGreen
                            Else
                                TRABAJOSDataGridView.Rows(C).DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                            End If
                            'Select Case TRABAJOSDataGridView.Rows(C).Cells(2).Value
                            '    Case "OBRA CIVIL", "GESTION OC"
                            '        If TRABAJOSDataGridView.Rows(C).Cells(11).Value = False Then
                            '            TRABAJOSDataGridView.Rows(C).DefaultCellStyle.BackColor = Color.IndianRed
                            '        End If
                            'End Select
                        Else
                            TRABAJOSDataGridView.Rows(C).DefaultCellStyle.ForeColor = Color.DimGray
                        End If
                    Next
                    'FORMATEA LA CELDA SELECCIONADA SEGUN EL STATUS Y CONDICION
                    If TRABAJOSDataGridView.CurrentRow.Cells(9).Value <> "FINALIZADO" Then
                        'If TRABAJOSDataGridView.CurrentRow.Cells(11).Value = False Then
                        'Select Case TRABAJOSDataGridView.CurrentRow.Cells(2).Value
                        '    Case "OBRA CIVIL", "GESTION OC"
                        '        TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.IndianRed
                        '        TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 25, 25)
                        '    Case Else
                        TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 25, 25)
                        TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 118, 51)
                        '    End Select
                        'Else
                        '    TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen
                        '    TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Orange
                        'End If
                    End If
                Else 'SI EL TEMA ES BLANCO
                    For C = 0 To TRABAJOSDataGridView.Rows.Count - 1
                        TRABAJOSDataGridView.Rows(C).Height = 25
                        TRABAJOSDataGridView.Rows(C).DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)
                        TRABAJOSDataGridView.Rows(C).DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221)
                        If TRABAJOSDataGridView.Rows(C).Cells(9).Value = "FINALIZADO" Then
                            TRABAJOSDataGridView.Rows(C).DefaultCellStyle.ForeColor = C_TRABAJO
                        End If
                    Next
                    ' If TRABAJOSDataGridView.CurrentRow.Cells(9).Value <> "FINALIZADO" Then
                    TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70)
                    TRABAJOSDataGridView.CurrentRow.DefaultCellStyle.SelectionForeColor = C_TRABAJO
                    ' End If
                End If
            End If
            TRABAJOSDataGridView.CurrentRow.Height = 40
    End Sub
    Private Sub BOT_FILTRAZONA_Click(sender As Object, e As EventArgs) Handles BOT_FILTRAZONA.Click
        Dim ID_GESTION As Integer
        ID_GESTION = ORDENESDataSet.GESTION.Rows(GESTIONBindingSource.Position).Item("Id_GESTION")
        If FILTRO_ZONA.Text = "" Then
            TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, ID_GESTION)
        Else
            TRABAJOSTableAdapter.FillByIDGESTIONZONA(ORDENESDataSet.TRABAJOS, ID_GESTION, CInt(FILTRO_ZONA.Text))
        End If
    End Sub
    Private Sub CREA_COPIAORDEN() 'aun sin usar


        'RUTINA QUE CREA UNA COPIA DE LA ORDEN  SITUADO EN ORDENROW()

        'CAMABIA EL STATUS DE LA ORDEN
        TOTAL_DUPLI += 1
        DATOS_ORDENESRow("STATUS") = "ADUPLICAR"
        MENSAJE_DUPLI(TOTAL_DUPLI) = "Orden Nro " & DATOS_ORDENESRow("NRO_ORDENINT") & "  Ordinal Correspondiente NRO " & DATOS_ORDENESRow("NRO_ORDINAL") & " Con Motivo de Origen " & DATOS_ORDENESRow("MOTIVOORIGEN")

        Try
            Me.ORDENESTableAdapter.Update(DATOS_ORDENESRow)
        Catch TRANCA As Data.DBConcurrencyException
            Dim RESPUESTA As Windows.Forms.DialogResult
            RESPUESTA = MsgBox("Falla en  cambio de status de ordenes duplicadas, desea continuar?", "CONTROL CARGA DE DATOS", MessageBoxButtons.YesNo)
            Select Case RESPUESTA
                Case Windows.Forms.DialogResult.Yes
                    ORDENESDataSet.ORDENES.Merge(ORDENESDataSet.ORDENES, True)
                    Me.ORDENESTableAdapter.Update(DATOS_ORDENESRow)
                Case Else
                    ORDENESDataSet.ORDENES.Merge(ORDENESDataSet.ORDENES, True)
                    MsgBox("La actualizacion ha sido cancelada")
            End Select
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la carga del status de la orden ADUPLICAR: " & DATOS_TRABAJORow("Id_TRABAJO") & "  " & ex.ToString)
        End Try

    End Sub 'aun sin usar
    Private Sub BOT_NUEVAGEST_Click(sender As Object, e As EventArgs) Handles BOT_NUEVAGEST.Click
        TIPOACCION = "NUEVO"
        ' BOT_NUEVAGEST.Enabled = False
        ' GEST_DESCRIPCION.Visible = False
        Me.Enabled = False
        NUEVAGESTION.Show(Me)
    End Sub
    Private Sub CONTROLA_USUARIO_GEST()
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA"
                AUTORIZADO = True
            Case Else
                If SECTOR <> DATOS_GESTIONRow("SECTORASIG") Then
                    MsgBox("SOLO PUEDE MODIFICAR ESTA GESTION ALGUIEN DEL SECTOR " & DATOS_GESTIONRow("SECTORASIG"))
                    AUTORIZADO = False
                Else
                    AUTORIZADO = True
                End If
        End Select
    End Sub
    Private Sub CONTROLA_USUARIO_TRA()
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA"
                AUTORIZADO = True
            Case Else
                If SECTOR <> DATOS_TRABAJORow("SECTORASIG") Then
                    MsgBox("SOLO PUEDE MODIFICAR ESTE TRABAJO ALGUIEN DEL SECTOR " & DATOS_TRABAJORow("SECTORASIG"))
                    AUTORIZADO = False
                Else
                    AUTORIZADO = True
                End If
        End Select
    End Sub
    Private Sub CONTROLA_USUARIO_ORDEN()
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA"
                AUTORIZADO = True
            Case Else
                If SECTOR <> DATOS_ORDENESRow("SECTORASIG") Then
                    MsgBox("SOLO PUEDE MODIFICAR ESTA ORDEN ALGUIEN DEL SECTOR " & DATOS_ORDENESRow("SECTORASIG"))
                    AUTORIZADO = False
                Else
                    AUTORIZADO = True
                End If
        End Select
    End Sub
    Private Sub CONTROLA_USUARIO()
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA"
                AUTORIZADO = True
            Case Else
                If SECTOR <> DATOS_TRABAJORow("SECTORASIG") Then
                    MsgBox("SOLO PUEDE MODIFICAR ESTE TRABAJO ALGUIEN DEL SECTOR " & DATOS_TRABAJORow("SECTORASIG"))
                    AUTORIZADO = False
                Else
                    AUTORIZADO = True
                End If
        End Select
    End Sub
    Private Sub CARGAR_DATOSORDENDEPENDIENTE()
        'CARGA LOS CAMPOS DE TEXTO
        ING_NODO.Text = DATOS_TRABAJORow("NODO")
        ING_ZONA.Text = DATOS_TRABAJORow("ZONA")
        ING_TIPO.Text = "TAREA"

    End Sub
    Private Sub BOT_CARGAREL_Click(sender As Object, e As EventArgs) Handles BOT_CARGAREL.Click
        RELEVAMIENTO.Show()
    End Sub
    Private Sub VER_HISTGESTION_CheckedChanged(sender As Object, e As EventArgs) Handles VER_HISTGESTION.CheckedChanged
        If VER_HISTGESTION.Checked = True Then
            BOX_HISTGESTION.Visible = True
            'CARGA HISTORICO
            Me.Cursor = Cursors.WaitCursor
            Me.HISTORICOTableAdapter.FillByIDGESTION(OrdenesDataSet1.HISTORICO, DATOS_GESTIONRow("ID_GESTION"))
            Me.HISTORICOBindingSource1.MoveLast()
            LLENA_HISTORICOGESTION()
            Me.Cursor = DefaultCursor
        Else
            BOX_HISTGESTION.Visible = False
        End If
    End Sub
    Private Sub VER_HISTTRABAJOS_CheckedChanged(sender As Object, e As EventArgs) Handles VER_HISTTRABAJOS.CheckedChanged
        If VER_HISTTRABAJOS.Checked = True Then
            BOX_HISTTRABAJOS.Visible = True
            Me.Cursor = Cursors.WaitCursor
            Me.HISTORICOTableAdapter.FillByIDTRABAJO(ORDENESDataSet.HISTORICO, DATOS_TRABAJORow("ID_TRABAJO"))
            Me.HISTORICOBindingSource.MoveLast()
            'LLENA_HISTORICOTRABAJOS()
            Me.Cursor = DefaultCursor
        Else
            BOX_HISTTRABAJOS.Visible = False
        End If
    End Sub
    Private Sub VER_HISTORDENES_CheckedChanged(sender As Object, e As EventArgs) Handles VER_HISTORDENES.CheckedChanged
        If VER_HISTORDENES.Checked = True Then
            BOX_HISTORDENES.Visible = True
            'CARGA DATOS HISTORICO

            Me.Cursor = Cursors.WaitCursor
            If ORDENESDataGridView.Rows.Count > 0 Then
                NROORDENINT = ORDENESDataGridView.CurrentRow.Cells.Item(3).Value
                Me.HISTORICOTableAdapter.FillByORDENINT(OrdenesDataSet2.HISTORICO, NROORDENINT)
                LLENA_HISTORICOORDENES()
                Me.Cursor = DefaultCursor
            End If
        Else
            BOX_HISTORDENES.Visible = False
        End If
    End Sub
    Private Sub HISTORDENESDataGridView_Click(sender As Object, e As EventArgs) Handles HISTORDENESDataGridView.Click
        If OrdenesDataSet2.HISTORICO.Rows.Count > 0 Then
            HISTORICO2Row = OrdenesDataSet2.HISTORICO.Rows(HISTORICOBindingSource2.Position)
            LLENA_HISTORICOORDENES()
        End If
    End Sub
    Private Sub HISTORICODataGridView_Click(sender As Object, e As EventArgs) Handles HISTORICO_TRABDataGridView.Click
        If HISTORICO_TRABDataGridView.Rows.Count > 0 Then
            HISTORICORow = ORDENESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position)
            LLENA_HISTORICOTRABAJOS()
        End If
    End Sub
    Private Sub GEST_HISTORICO_Click(sender As Object, e As EventArgs) Handles GEST_HISTORICO.Click
        HISTORICO1Row = OrdenesDataSet1.HISTORICO.Rows(HISTORICOBindingSource1.Position)
        LLENA_HISTORICOGESTION()
    End Sub
    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub
    Private Sub EDITA_CAPACIDADAGENDA() 'SIN USAR
        'BUSCA LA POSICION DE LA TABLA CORRESPONDIENTE A LA FECHA DE AGENDAMIENTO DE LA ORDEN
        'Me.CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, SOLOFECHA.Date)
        'AGENDADORow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
        Dim VAR_CAPANTES As Integer = 0
        Dim VAR_CAPDESPUES As Integer = 0
        'BUSCA LA POSICION DE LA TABLA CORRESPONDIENTE A LA FECHA DE AGENDAMIENTO DE LA ORDEN
        Select Case SEL_SECTORGENERADOR
            Case "PT"
                Select Case SEL_SECTOROPERATIVO
                    Case "MANTENIMIENTO"
                        Select Case SEL_PRIORIDAD
                            Case "ALTA"
                                VAR_CAPANTES = AGENDADORow("MIN_ALT_TEC_PT_AGE")
                                If AGENDADORow("MIN_ALT_TEC_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_ALT_TEC_PT_AGE") = AGENDADORow("MIN_ALT_TEC_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_ALT_TEC_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_ALT_TEC_PT_AGE")
                            Case "MEDIA"
                                VAR_CAPANTES = AGENDADORow("MIN_MED_TEC_PT_AGE")
                                If AGENDADORow("MIN_MED_TEC_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_MED_TEC_PT_AGE") = AGENDADORow("MIN_MED_TEC_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_MED_TEC_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_MED_TEC_PT_AGE")
                            Case "BAJA"
                                VAR_CAPANTES = AGENDADORow("MIN_BAJ_TEC_PT_AGE")
                                If AGENDADORow("MIN_BAJ_TEC_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_BAJ_TEC_PT_AGE") = AGENDADORow("MIN_BAJ_TEC_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_BAJ_TEC_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_TEC_PT_AGE")
                        End Select
                    Case "CUADRILLAS"
                        Select Case SEL_PRIORIDAD
                            Case "ALTA"
                                VAR_CAPANTES = AGENDADORow("MIN_ALT_CUA_PT_AGE")
                                If AGENDADORow("MIN_ALT_CUA_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_ALT_CUA_PT_AGE") = AGENDADORow("MIN_ALT_CUA_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_ALT_CUA_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_ALT_CUA_PT_AGE")
                            Case "MEDIA"
                                VAR_CAPANTES = AGENDADORow("MIN_MED_CUA_PT_AGE")
                                If AGENDADORow("MIN_MED_CUA_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_MED_CUA_PT_AGE") = AGENDADORow("MIN_MED_CUA_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_MED_CUA_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_MED_CUA_PT_AGE")
                            Case "BAJA"
                                VAR_CAPANTES = AGENDADORow("MIN_BAJ_CUA_PT_AGE")
                                If AGENDADORow("MIN_BAJ_CUA_PT_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_BAJ_CUA_PT_AGE") = AGENDADORow("MIN_BAJ_CUA_PT_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_BAJ_CUA_PT_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_CUA_PT_AGE")
                        End Select
                End Select

            Case "SU"
                Select Case SEL_SECTOROPERATIVO
                    Case "MANTENIMIENTO"
                        Select Case SEL_PRIORIDAD
                            Case "ALTA"
                                VAR_CAPANTES = AGENDADORow("MIN_ALT_TEC_SU_AGE")
                                If AGENDADORow("MIN_ALT_TEC_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_ALT_TEC_SU_AGE") = AGENDADORow("MIN_ALT_TEC_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_ALT_TEC_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_ALT_TEC_SU_AGE")
                            Case "MEDIA"
                                VAR_CAPANTES = AGENDADORow("MIN_MED_TEC_SU_AGE")
                                If AGENDADORow("MIN_MED_TEC_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_MED_TEC_SU_AGE") = AGENDADORow("MIN_MED_TEC_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_MED_TEC_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_MED_TEC_SU_AGE")
                            Case "BAJA"
                                VAR_CAPANTES = AGENDADORow("MIN_BAJ_TEC_SU_AGE")
                                If AGENDADORow("MIN_BAJ_TEC_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_BAJ_TEC_SU_AGE") = AGENDADORow("MIN_BAJ_TEC_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_BAJ_TEC_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_TEC_SU_AGE")
                        End Select
                    Case "CUADRILLAS"
                        Select Case SEL_PRIORIDAD
                            Case "ALTA"
                                VAR_CAPANTES = AGENDADORow("MIN_ALT_CUA_SU_AGE")
                                If AGENDADORow("MIN_ALT_CUA_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_ALT_CUA_SU_AGE") = AGENDADORow("MIN_ALT_CUA_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_ALT_CUA_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_ALT_CUA_SU_AGE")
                            Case "MEDIA"
                                VAR_CAPANTES = AGENDADORow("MIN_MED_CUA_SU_AGE")
                                If AGENDADORow("MIN_MED_CUA_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_MED_CUA_SU_AGE") = AGENDADORow("MIN_MED_CUA_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_MED_CUA_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_MED_CUA_SU_AGE")
                            Case "BAJA"
                                VAR_CAPANTES = AGENDADORow("MIN_BAJ_CUA_SU_AGE")
                                If AGENDADORow("MIN_BAJ_CUA_SU_AGE") - TIEMPO_AGENDA > 0 Then
                                    AGENDADORow("MIN_BAJ_CUA_SU_AGE") = AGENDADORow("MIN_BAJ_CUA_SU_AGE") - TIEMPO_AGENDA
                                Else
                                    AGENDADORow("MIN_BAJ_CUA_SU_AGE") = 0
                                End If
                                VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_CUA_PT_AGE")
                        End Select

                    Case "CO"
                        Select Case SEL_SECTOROPERATIVO
                            Case "MANTENIMIENTO"
                                Select Case SEL_PRIORIDAD
                                    Case "ALTA"
                                        VAR_CAPANTES = AGENDADORow("MIN_ALT_TEC_CO_AGE")
                                        If AGENDADORow("MIN_ALT_TEC_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_ALT_TEC_CO_AGE") = AGENDADORow("MIN_ALT_TEC_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_ALT_TEC_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_ALT_TEC_CO_AGE")
                                    Case "MEDIA"
                                        VAR_CAPANTES = AGENDADORow("MIN_MED_TEC_CO_AGE")
                                        If AGENDADORow("MIN_MED_TEC_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_MED_TEC_CO_AGE") = AGENDADORow("MIN_MED_TEC_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_MED_TEC_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_MED_TEC_CO_AGE")
                                    Case "BAJA"
                                        VAR_CAPANTES = AGENDADORow("MIN_BAJ_TEC_CO_AGE")
                                        If AGENDADORow("MIN_BAJ_TEC_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_BAJ_TEC_CO_AGE") = AGENDADORow("MIN_BAJ_TEC_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_BAJ_TEC_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_TEC_CO_AGE")
                                End Select
                            Case "CUADRILLAS"
                                Select Case SEL_PRIORIDAD
                                    Case "ALTA"
                                        VAR_CAPANTES = AGENDADORow("MIN_ALT_CUA_CO_AGE")
                                        If AGENDADORow("MIN_ALT_CUA_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_ALT_CUA_CO_AGE") = AGENDADORow("MIN_ALT_CUA_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_ALT_CUA_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_ALT_CUA_CO_AGE")
                                    Case "MEDIA"
                                        VAR_CAPANTES = AGENDADORow("MIN_MED_CUA_CO_AGE")
                                        If AGENDADORow("MIN_MED_CUA_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_MED_CUA_CO_AGE") = AGENDADORow("MIN_MED_CUA_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_MED_CUA_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_MED_CUA_CO_AGE")
                                    Case "BAJA"
                                        VAR_CAPANTES = AGENDADORow("MIN_BAJ_CUA_CO_AGE")
                                        If AGENDADORow("MIN_BAJ_CUA_CO_AGE") - TIEMPO_AGENDA > 0 Then
                                            AGENDADORow("MIN_BAJ_CUA_CO_AGE") = AGENDADORow("MIN_BAJ_CUA_CO_AGE") - TIEMPO_AGENDA
                                        Else
                                            AGENDADORow("MIN_BAJ_CUA_CO_AGE") = 0
                                        End If
                                        VAR_CAPDESPUES = AGENDADORow("MIN_BAJ_CUA_CO_AGE")
                                End Select
                        End Select
                End Select
        End Select


        MsgBox("La Capacidad del dia " & SOLOFECHA & " para el sector " & SEL_SECTOROPERATIVO & " Cambiara de la siguiente manera : " & vbNewLine &
               "Capacidad Actual: " & VAR_CAPANTES & vbNewLine & "Capacidad Nueva: " & VAR_CAPDESPUES, vbInformation)

    End Sub ' SIN USARSE
    Private Sub GEST_HISTORICO_SelectionChanged(sender As Object, e As EventArgs) Handles GEST_HISTORICO.SelectionChanged
        If VER_HISTGESTION.Checked = True Then
            LLENA_HISTORICOGESTION()
        End If
    End Sub
    Private Sub HISTORICO_TRABDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles HISTORICO_TRABDataGridView.SelectionChanged
        'If VER_HISTTRABAJOS.Checked = True Then
        '    LLENA_HISTORICOTRABAJOS()
        'End If
    End Sub

    'GESTION TOOLSTRIP ______________________
    Private Sub GEST_EDITAR_TOOLSTRIP_Click(sender As Object, e As EventArgs) Handles GEST_EDITAR_TOOLSTRIP.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO_GEST()
        'AUTORIZADO = True
        If AUTORIZADO = True Then
            TIPOACCION = "EDITAR"
            Me.Enabled = False
            NUEVAGESTION.Show(Me)
        Else
            MENU_GESTION.Close()
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub GEST_COMPLETO_TOOLSTRIP_Click(sender As Object, e As EventArgs) Handles GEST_COMPLETO_TOOLSTRIP.Click
        CONTROLA_USUARIO_GEST()
        If AUTORIZADO = True Then
            If GEST_COMPLETO_TOOLSTRIP.Text = "Marcar COMPLETO" Then
                GESTIONTableAdapter.UpdateQueryCOMPLETO(DATOS_GESTIONRow("Id_GESTION"))
                Me.GESTIONTableAdapter.FillByIDGESTION(Me.ORDENESDataSet.GESTION, DATOS_GESTIONRow("Id_GESTION"))
            Else
                GESTIONTableAdapter.UpdateQueryNOCOMPLETO(DATOS_GESTIONRow("Id_GESTION"))
                Me.GESTIONTableAdapter.FillByIDGESTION(Me.ORDENESDataSet.GESTION, DATOS_GESTIONRow("Id_GESTION"))
            End If
        Else
            MENU_GESTION.Close()
        End If
    End Sub
    Private Sub GEST_STATUS()
        CONTROLA_USUARIO_GEST()
        If AUTORIZADO = True Then
            If ACCESO_DESDE = "MDU" Or ACCESO_DESDE = "BUSCADOR" Then
                Me.EdificiosTableAdapter.FillByDIRECCION_P(MDUDataSet.Edificios, DATOS_GESTIONRow.CALLE, DATOS_GESTIONRow.NUMERO)
                If MDUDataSet.Edificios.Rows.Count = 1 Then
                    DATOS_EDIFICIORow = MDUDataSet.Edificios.Rows(0)
                Else
                    DATOS_EDIFICIORow = Nothing
                End If
            End If
            Select Case GEST_STATUS_VAR
                Case "INICIAR"
                    DATOS_GESTIONRow("STATUS") = "INICIADO"
                    DATOS_HIS_STATUSACTUAL = "INICIADO"
                    DATOS_HIS_CAUSA = "INICIO MANUAL"
                    DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"
                    DATOS_GESTIONRow("FECHAINICIADA") = Now
                Case "REINICIAR"
                    DATOS_GESTIONRow("STATUS") = "INICIADO"
                    DATOS_HIS_STATUSACTUAL = "INICIADO"
                    DATOS_HIS_CAUSA = "REINICIO MANUAL"
                    DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"
                Case "DEMORAR"
                    DATOS_GESTIONRow("STATUS") = "DEMORADO"
                    DATOS_HIS_STATUSACTUAL = "DEMORADO"
                    DATOS_HIS_CAUSA = "DEMORA MANUAL"
                    DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"
                Case "FINALIZAR"
                    DATOS_GESTIONRow("STATUS") = "FINALIZADO"
                    DATOS_GESTIONRow("FECHAFINALIZADA") = Now
                    If DATOS_EDIFICIORow IsNot Nothing Then
                        If DATOS_GESTIONRow.AREA = "MDU" Then
                            Select Case DATOS_GESTIONRow("TIPOGESTION")
                                Case "Mant Preventivo", "MANT PREVENTIVO"
                                    DATOS_EDIFICIORow("GESTMANT") = False
                                Case "Obra Nueva", "OBRA NUEVA"
                                    DATOS_EDIFICIORow("GESTOBR") = False
                                    DATOS_EDIFICIORow("CABLEADO") = True
                            End Select
                        End If
                    End If
                    DATOS_HIS_STATUSACTUAL = "FINALIZADO"
                    DATOS_HIS_CAUSA = "FINALIZACION MANUAL"
                    DATOS_HIS_DETALLE = DET_HISTORICO
                    If IsDBNull(DATOS_GESTIONRow("FECHAINICIADA")) = False Then DATOS_GESTIONRow("DEMORA") = DateDiff(DateInterval.Day, DATOS_GESTIONRow("FECHAINICIADA"), Now)
                    If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                        For I = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                            DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows(I)
                            If DATOS_TRABAJORow("STATUS") <> "FINALIZADO" Then
                                MJE_FINALIZAR = "La GESTION que se pretende FINALIZAR no tiene todas los TRABAJOS finalizadas, si desea hacerlo detalle las razones para ello y presione FINALIZAR "
                                MJE_FINALIZARTRAB.Show()
                            Else
                                ACCION_FINALIZAR = "FINALIZAR"
                            End If
                        Next I
                    End If
                    ACCION_FINALIZAR = "FINALIZAR"
                Case "CANCELAR"
                    DATOS_GESTIONRow("STATUS") = "CANCELADO"
                    If INGRESO_AREA = "MDU" Then
                        If DATOS_EDIFICIORow IsNot Nothing Then
                            Select Case DATOS_GESTIONRow("TIPOGESTION")
                                Case "Mant Preventivo", "MANT PREVENTIVO"
                                    DATOS_EDIFICIORow("GESTMANT") = False
                                Case "Obra Nueva", "OBRA NUEVA"
                                    DATOS_EDIFICIORow("GESTOBR") = False
                            End Select
                        End If
                    End If
                        DATOS_GESTIONRow("DESCRIPCION") += "  ++  GESTION CANCELADA EL " & Today & ":   "
                    DATOS_HIS_STATUSACTUAL = "CANCELADO"
                    DATOS_HIS_CAUSA = "CANCELACION MANUAL"
                    DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"
            End Select
            '  DATOS_GESTIONRow("DESCRIPCION") = GEST_DESCRIPCION.Text
            GESTIONTableAdapter.Update(DATOS_GESTIONRow)
            GESTIONTableAdapter.GEST_QUITARREQUERIDO(DATOS_GESTIONRow("ID_GESTION"))
            If DATOS_EDIFICIORow IsNot Nothing Then
                EdificiosTableAdapter.Update(DATOS_EDIFICIORow)
            End If

            'CARGA HISTORICO
            TIPOREGISTRO = "GESTION"
            CARGA_HISTORICO()
            MENU_GESTION.Close()
        Else
            MENU_GESTION.Close()
        End If
        If ACCESO_DESDE = "MDU" Then
            INGRESO_MDU.EdificiosTableAdapter.Fill(INGRESO_MDU.MDUDataSet.Edificios)
        End If
        Cursor = DefaultCursor
    End Sub  'GESTION CAMBIO DE STATUS
    Private Sub GEST_INICIAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_INICIAR_ToolStrip.Click
        GEST_STATUS_VAR = GEST_INICIAR_ToolStrip.Text
        GEST_STATUS()
    End Sub
    Private Sub GEST_REINICIAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_REINICIAR_ToolStrip.Click
        GEST_STATUS_VAR = GEST_REINICIAR_ToolStrip.Text
        GEST_STATUS()
    End Sub
    Private Sub GEST_FINALIZAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_FINALIZAR_ToolStrip.Click
        GEST_STATUS_VAR = GEST_FINALIZAR_ToolStrip.Text
        GEST_STATUS()
    End Sub
    Private Sub GEST_DEMORAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_DEMORAR_ToolStrip.Click
        GEST_STATUS_VAR = GEST_DEMORAR_ToolStrip.Text
        GEST_STATUS()
    End Sub
    Private Sub GEST_CANCELAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_CANCELAR_ToolStrip.Click
        GEST_STATUS_VAR = GEST_CANCELAR_ToolStrip.Text
        GEST_STATUS()
    End Sub
    Private Sub TRABAJO_GEST_GENERAR()
        CONTROLA_USUARIO_GEST()
        If AUTORIZADO = True Then
            Cursor = Cursors.WaitCursor
            VARTRAB_TIPO = GEST_NEWTRAB_TOOLS_VAR
            TIPOACCION = "NUEVO"
            VARTRAB_INIEST = Now.ToShortDateString
            VARTRAB_NODO = DATOS_GESTIONRow("NODO")
            VARTRAB_TIEMEST = ""
            VARTRAB_DESCRIPCION = ""
            VARTRAB_ZONA = ""
            VARTRAB_MZNA = ""
            If DATOS_GESTIONRow.IsCALLENull = False Then VARTRAB_CALLE = DATOS_GESTIONRow("CALLE")
            If DATOS_GESTIONRow.IsNUMERONull = False Then VARTRAB_NRO = DATOS_GESTIONRow("NUMERO")
            VARTRAB_TIPODEP = "IND"
            VARTRAB_DEP = ""
            NUEVOTRABAJO.Show(Me)
            Me.Enabled = False
            Cursor = DefaultCursor
        End If
        MENU_GESTION.Close()
    End Sub 'GENERAR TRABAJOS A PARTIR DE UNA GESTION
    Private Sub GEST_TRAB1_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB1_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB1_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_TRAB2_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB2_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB2_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_TRAB3_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB3_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB3_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_TRAB4_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB4_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB4_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_TRAB5_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB5_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB5_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_TRAB6_TOOLS_Click(sender As Object, e As EventArgs) Handles GEST_TRAB6_TOOLS.Click
        GEST_NEWTRAB_TOOLS_VAR = GEST_TRAB6_TOOLS.Text
        TRABAJO_GEST_GENERAR()
    End Sub
    Private Sub GEST_RESPONSABLE()
        CONTROLA_USUARIO_GEST()
        If AUTORIZADO = True Then

            Cursor = Cursors.WaitCursor
            Dim PARCIAL_NOMBRE As Array = Split(GEST_RESP_NOMBRE, " ")
            USUARIOSTableAdapter.FillByAPELLIDO(OPERACIONES_LOGDataSet.USUARIOS, PARCIAL_NOMBRE(1))
            SECTORASIG = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("SECTOR")
            IDASIG = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("Id")
            DATOS_GESTIONRow("ASIGNADOA") = GEST_RESP_NOMBRE
            DATOS_GESTIONRow("SECTORASIG") = SECTORASIG
            DATOS_GESTIONRow("IDASIG") = IDASIG
            Try
                GESTIONTableAdapter.Update(DATOS_GESTIONRow)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'CARGA HISTORICO
            DATOS_HIS_CAUSA = "ASIGNACION RESPONSABLE"
            DATOS_HIS_STATUSACTUAL = DATOS_GESTIONRow("STATUS")
            DATOS_HIS_DETALLE = "ASIGNADO A " & GEST_RESP_NOMBRE
            TIPOREGISTRO = "GESTION"
            CARGA_HISTORICO()

            'ENVIA MENSAJE 
            DATOS_MJE_DESTINONOMBRE = GEST_RESP_NOMBRE
            DATOS_MJE_DESTINOSECTOR = ""
            DATOS_MJE_MENSAJE = "A PARTIR DEL DIA DE LA FECHA " & NOMBRE & " " & APELLIDO & " LE A DESIGNADO COMO RESPOSABLE DE LA GESTION DE " & DATOS_GESTIONRow("TIPOGESTION") & " CON LA SIGUIENTE DESCRIPCION: " & DATOS_GESTIONRow("DESCRIPCION")
            DATOS_MJE_NROORDENASOC = ""
            ENVIA_MENSAJE()
            Cursor = DefaultCursor
        End If
        MENU_GESTION.Close()
    End Sub 'ASIGNACION DE GESTIONES
    Private Sub FRANCO_QUINTANA_Click(sender As Object, e As EventArgs) Handles FRANCO_QUINTANA.Click
        GEST_RESP_NOMBRE = FRANCO_QUINTANA.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub GABRIEL_SZUCS_Click(sender As Object, e As EventArgs) Handles GABRIEL_SZUCS.Click
        GEST_RESP_NOMBRE = GABRIEL_SZUCS.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub GERARDO_BOTTI_Click(sender As Object, e As EventArgs) Handles GERARDO_BOTTI.Click
        GEST_RESP_NOMBRE = GERARDO_BOTTI.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub DIEGO_BASSO_Click(sender As Object, e As EventArgs) Handles DIEGO_BASSO.Click
        GEST_RESP_NOMBRE = DIEGO_BASSO.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub DIEGO_GEYMONAT_Click(sender As Object, e As EventArgs) Handles DIEGO_GEYMONAT.Click
        GEST_RESP_NOMBRE = DIEGO_GEYMONAT.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub BRIAN_GELPI_Click(sender As Object, e As EventArgs) Handles BRIAN_GELPI.Click
        GEST_RESP_NOMBRE = BRIAN_GELPI.Text
        GEST_RESPONSABLE()
    End Sub
    Private Sub PABLO_ILLIONE_Click(sender As Object, e As EventArgs) Handles PABLO_ILLIONE.Click
        GEST_RESP_NOMBRE = PABLO_ILLIONE.Text
        GEST_RESPONSABLE()
    End Sub

    'TRABAJOS TOOLSTRIP ______________________
    Private Sub TRAB_EDITAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_EDITAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            TIPOACCION = "EDITAR"
            NUEVOTRABAJO.Show(Me)
            Me.Enabled = False
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub TRAB_CREARORDEN_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_CREARORDEN_ToolStrip.Click
        ACCION_ORDEN = "NUEVO"
        'CREAR UNA ORDEN INDEPENDIENTE
        CONTROLA_USUARIO_TRA()
        If AUTORIZADO = True Then
            CARGAR_DATOSORDENDEPENDIENTE()
            'CARGA FECHA DE INICIOESTIMADO DE LO ORDEN = FECHA DE INICIO DEL TRABAJO+
            ING_FECHAINICEST = VARTRAB_INIEST
            ING_DEPENDENCIA = 0
            ING_TIPODEP = "IND"
            ING_ORDENDEP = 0
            ING_CLASEDEP = "IND"
            ING_ORDORIGEN = 0

            VAR_TIPODEP = "IND"
            VAR_ORDENDP = 0
            VAR_CLASEDEP = "IND"
            TIEMPO_AGENDA = 0
            ORDEN_TIEMPORESTANTE = 450


            TRABAJOSDataGridView.ContextMenuStrip = Nothing
            STANDARD.Show(Me)
            Me.Enabled = False

        End If
    End Sub
    Private Sub TRAB_COMPLETO_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_COMPLETO_ToolStrip.Click
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            If DATOS_TRABAJORow("COMPLETO") = False Then
                DATOS_TRABAJORow("COMPLETO") = True
            Else
                DATOS_TRABAJORow("COMPLETO") = False
            End If
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)
        End If
    End Sub
    Private Sub TRAB_FINALIZAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_FINALIZAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO_TRA()
        If AUTORIZADO = True Then
            If DATOS_TRABAJORow("STATUS") = "INICIADO" Then
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                    For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                        DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows(I)
                        If DATOS_ORDENESRow("STATUS") <> "FINALIZADO" Then
                            MJE_FINALIZAR = "El trabajo que se pretende FINALIZAR no tiene todas las ordenes finalizadas, si desea hacerlo detalle las razones para hacerlo y presione FINALIZAR "
                            MJE_FINALIZARTRAB.Show()
                        Else
                            ACCION_FINALIZAR = "FINALIZAR"
                        End If
                    Next I
                Else
                    DATOS_TRABAJORow("STATUS") = "FINALIZADO"
                    If IsDBNull(DATOS_TRABAJORow("FECHAINICIADO")) = False Then DATOS_TRABAJORow("DEMORA") = DateDiff(DateInterval.Day, DATOS_TRABAJORow("FECHAINICIADO"), Now)
                    DATOS_TRABAJORow("FECHAFINALIZADO") = Now
                    If DATOS_TRABAJORow("REQUERIDO") = True Then
                        DATOS_TRABAJORow("REQUERIDO") = False
                    End If
                    TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)

                    DATOS_HIS_STATUSACTUAL = "FINALIZADO"
                    DATOS_HIS_CAUSA = "TRABAJO FINALIZADO"
                    DATOS_HIS_DETALLE = DET_HISTORICO

                    TIPOREGISTRO = "TRABAJO"
                    CARGA_HISTORICO()
                End If

                Select Case ACCION_FINALIZAR
                    Case "FINALIZAR"
                        DATOS_TRABAJORow("STATUS") = "FINALIZADO"
                        If IsDBNull(DATOS_TRABAJORow("FECHAINICIADO")) = False Then DATOS_TRABAJORow("DEMORA") = DateDiff(DateInterval.Day, DATOS_TRABAJORow("FECHAINICIADO"), Now)
                        DATOS_TRABAJORow("FECHAFINALIZADO") = Now
                        TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)

                        DATOS_HIS_STATUSACTUAL = "FINALIZADO"
                        DATOS_HIS_CAUSA = "TRABAJO FINALIZADO"
                        DATOS_HIS_DETALLE = DET_HISTORICO

                        TIPOREGISTRO = "TRABAJO"
                        CARGA_HISTORICO()

                End Select
            Else
                MsgBox("El trabajo seleccionado no esta INICIADO" & vbNewLine & vbNewLine & "Proceda a INICIAR el trabajo y para luego FINALIZAR el mismo ", vbInformation)
            End If
        End If
        Cursor = DefaultCursor

    End Sub
    Private Sub TRAB_CANCELAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_CANCELAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()

        If AUTORIZADO = True Then
            DATOS_TRABAJORow.STATUS = "CANCELADO"
            DATOS_TRABAJORow.REQUERIDO = False
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)

            DATOS_HIS_CAUSA = "TRABAJO CANCELADO"
            DATOS_HIS_STATUSACTUAL = "CANCELADO"
            DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"

            TIPOREGISTRO = "TRABAJO"
            CARGA_HISTORICO()

        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub TRAB_DEMORAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_DEMORAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            DATOS_TRABAJORow("STATUS") = "DEMORADO"
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)
            DATOS_HIS_STATUSACTUAL = "DEMORADO"
            DATOS_HIS_CAUSA = "DEMORA"
            DATOS_HIS_DETALLE = "CAMBIO DE STATUS MANUAL"
            TIPOREGISTRO = "TRABAJO"
            CARGA_HISTORICO()
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub TRAB_REINICIAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_REINICIAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            DATOS_TRABAJORow("STATUS") = "INICIADO"
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)

            DATOS_HIS_STATUSACTUAL = "INICIADO"
            DATOS_HIS_CAUSA = "REINICIO TRABAJO"
            DATOS_HIS_DETALLE = "FECHA DE INICIO : "

            TIPOREGISTRO = "TRABAJO"
            CARGA_HISTORICO()

            'CAMBIA STATUS DE LA GESTION, ESTE HISTORICO CAMBIA EL HISTORICO DE LA GESTION POR LO TANTO EL ID_TRABAJO DEBE SER 0

            'Select Case DATOS_GESTIONRow("STATUS")
            '    Case "DEMORADO"
            '        DATOS_GESTIONRow("STATUS") = "INICIADO"
            '        GESTIONTableAdapter.Update(DATOS_GESTIONRow)

            '        HIS_STATUSACTUAL = "INICIADO"
            '        HIS_CAUSA = "REINICIO TRABAJO"
            '        HIS_DETALLE = "CAMBIO DE STATUS POR REINICIO DE TRABAJO : " & DATOS_TRABAJORow("TIPOTRABAJO")

            '        TIPOREGISTRO = "GESTION"
            '        CARGA_HISTORICO()
            'End Select
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub TRAB_INICIAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_INICIAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            DATOS_TRABAJORow("STATUS") = "INICIADO"
            DATOS_TRABAJORow("FECHAINICIADO") = Now
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)
            DATOS_HIS_STATUSACTUAL = "INICIADO"
            DATOS_HIS_CAUSA = "INICIO TRABAJO"
            DATOS_HIS_DETALLE = "FECHA DE INICIO : "
            TIPOREGISTRO = "TRABAJO"
            CARGA_HISTORICO()
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub TRAB_HABILITA_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_HABILITA_ToolStrip.Click
        If TRAB_HABILITA_ToolStrip.Text = "HABILITAR TRABAJO" Then
            'HAY QUE HABILITARLO
            DATOS_TRABAJORow("HABILITADO") = True
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)
            DATOS_HIS_CAUSA = "HABILITACION DEL TRABAJO"
            DATOS_HIS_DETALLE = "SE HABILITA"
        Else
            DATOS_TRABAJORow("HABILITADO") = False
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)
            DATOS_HIS_CAUSA = "INHABILITACION DEL TRABAJO"
            DATOS_HIS_DETALLE = "SE DESHABILITA"
        End If
        TIPOREGISTRO = "TRABAJO"
        DATOS_STATUSANT = DATOS_TRABAJORow("STATUS")
        DATOS_HIS_STATUSACTUAL = DATOS_TRABAJORow("STATUS")

        CARGA_HISTORICO()
        CARGA_TRABAJOS()
    End Sub
    Private Sub TRAB_RESPONSABLE()
        Cursor = Cursors.WaitCursor
        CONTROLA_USUARIO()
        If AUTORIZADO = True Then
            Dim PARCIAL_NOMBRE As Array = Split(TRAB_RESP_NOMBRE, " ")
            USUARIOSTableAdapter.FillByAPELLIDO(OPERACIONES_LOGDataSet.USUARIOS, PARCIAL_NOMBRE(1))
            SECTORASIG = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("SECTOR")
            IDASIG = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("Id")

            DATOS_TRABAJORow("IDASIG") = IDASIG
            DATOS_TRABAJORow("ASIGNADOA") = TRAB_RESP_NOMBRE
            DATOS_TRABAJORow("SECTORASIG") = SECTORASIG
            DATOS_TRABAJORow.FECHA_ASIGNADO = Today.ToShortDateString()
            TRABAJOSTableAdapter.Update(DATOS_TRABAJORow)

            'CARGA HISTORICO
            DATOS_HIS_CAUSA = "ASIGNAR RESPONSABLE"
            DATOS_HIS_STATUSACTUAL = DATOS_TRABAJORow("STATUS")
            DATOS_HIS_DETALLE = "ASIGNACION DE TRABAJO A: " & TRAB_RESP_NOMBRE

            TIPOREGISTRO = "TRABAJO"
            CARGA_HISTORICO()

            'ENVIA MENSAJE A RESPOSABLE ASIGNADO
            DATOS_MJE_ASUNTO = "ASIGNACION DE TRABAJO"
            DATOS_MJE_DESTINONOMBRE = TRAB_RESP_NOMBRE
            DATOS_MJE_DESTINOSECTOR = ""
            DATOS_MJE_MENSAJE = "SE LE HA ASIGNADO EL TRABAJO Numero: " & DATOS_TRABAJORow.ID_GESTION & " - " & DATOS_TRABAJORow.Id_TRABAJO & ", EN EL NODO: " & DATOS_TRABAJORow("NODO") & "ZONA: " & DATOS_TRABAJORow("ZONA") & "    DE " & DATOS_TRABAJORow("TIPOTRABAJO") & " PERTENECIENTE A: " & DATOS_TRABAJORow("AREA") _
               & vbNewLine & "SITUADO EN: " & DATOS_TRABAJORow("CALLE") & "NRO: " & DATOS_TRABAJORow("NRO") & vbNewLine & " USTED DEBERA CREAR LAS ORDENES DE TRABAJO NECESARIAS PARA DICHO TRABAJO SE EJECUTE Y ACTUALIZAR LOS DISTINTOS ESTADOS DEL MISMO"
            DATOS_MJE_NROORDENASOC = ""
            ENVIA_MENSAJE()

            'ENVIA MENSAJE A RESPOSABLE GESTION
            DATOS_MJE_ASUNTO = "ASIGNACION DE TRABAJO"
            DATOS_MJE_DESTINONOMBRE = DATOS_GESTIONRow("ASIGNADOA")
            DATOS_MJE_DESTINOSECTOR = ""
            DATOS_MJE_MENSAJE = "A PARTIR DEL DIA DE LA FECHA SE LE HA ASIGNADO EL TRABAJO " & DATOS_TRABAJORow("TIPOTRABAJO") & " CON EL SIGUIENTE DETALLE : " & DATOS_TRABAJORow("DESCRIPCION") _
               & " A " & TRAB_RESP_NOMBRE
            DATOS_MJE_NROORDENASOC = ""
            ENVIA_MENSAJE()

        End If
        MENU_TRABAJO.Close()
        Cursor = DefaultCursor
    End Sub  'ASIGNAR TRABAJOS
    Private Sub TRAB_BASSO_Click(sender As Object, e As EventArgs) Handles TRAB_BASSO.Click
        TRAB_RESP_NOMBRE = TRAB_BASSO.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_BOTTI_Click(sender As Object, e As EventArgs) Handles TRAB_BOTTI.Click
        TRAB_RESP_NOMBRE = TRAB_BOTTI.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_GELPI_Click(sender As Object, e As EventArgs) Handles TRAB_GELPI.Click
        TRAB_RESP_NOMBRE = TRAB_GELPI.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_GEYMONAT_Click(sender As Object, e As EventArgs) Handles TRAB_GEYMONAT.Click
        TRAB_RESP_NOMBRE = TRAB_GEYMONAT.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_ILLIONE_Click(sender As Object, e As EventArgs) Handles TRAB_ILLIONE.Click
        TRAB_RESP_NOMBRE = TRAB_ILLIONE.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_SZUCS_Click(sender As Object, e As EventArgs) Handles TRAB_SZUCS.Click
        TRAB_RESP_NOMBRE = TRAB_SZUCS.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_MARQUEZ_Click(sender As Object, e As EventArgs) Handles TRAB_MARQUEZ.Click
        TRAB_RESP_NOMBRE = TRAB_MARQUEZ.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub TRAB_FRANCO_Click(sender As Object, e As EventArgs) Handles TRAB_FRANCO.Click
        TRAB_RESP_NOMBRE = TRAB_FRANCO.Text
        TRAB_RESPONSABLE()
    End Sub
    Private Sub CARGA_NUEVOTRABAJOFUENTES()
        If NUEVOTRABAJO.Visible = False Then
            'PIDE CONFIRMACION______________________________________________________________________________________________________________________________________
            Dim Msg, Style, Title, Response, Mystring
            Msg = ("No existen trabajos creadas con el tipo " & FUENTE_TRABAJO & vbNewLine & vbNewLine &
                                "Se creara un trabajo con los siguientes datos : " & vbNewLine &
                                "TIPO trabajo: " & FUENTE_TRABAJO & vbNewLine &
                                "GENERADO POR: " & NOMBRE & " " & APELLIDO & vbNewLine &
                                "SECTOR ORIGEN: " & SECTOR)

            Style = vbOKCancel + vbQuestion + vbDefaultButton1
            Title = "Verificacion de existencia de TRABAJO"

            Response = MsgBox(Msg, Style, Title)
            If Response = vbOK Then
                'CARGA(VACIA) LOS CAMPOS CORRESPONDIENTES A EL TRABAJO A CREAR
                TIPOACCION = "NUEVO"

                NUEVOTRABAJO.Show(Me)
                Me.Enabled = False
                MENU_GESTION.Close()
                Cursor = DefaultCursor

                Exit Sub
                Mystring = "SI"
            Else
                NUEVOTRABAJO.Close()
                Me.Enabled = False
                MENU_GESTION.Close()
                Cursor = DefaultCursor
            End If
        End If
        '_______________________________________________________

    End Sub
    Private Sub TRABAJO_TRAB_GENERAR()
        Dim FECHAINI_NUEVOTRABAJO = DateAdd(DateInterval.Day, DATOS_TRABAJORow("TIEMPOESTIMADO"), DATOS_TRABAJORow("FECHAINICESTIMADO")).ToShortDateString
        'ELECCION DEL TIPO DE TRABAJO DEPENDIENTE A CREAR
        CONTROLA_USUARIO_TRA()
        If AUTORIZADO = True Then
            Cursor = Cursors.WaitCursor
            VARTRAB_TIPO = TRAB_TRAB_TOOLS_VAR
            TIPOACCION = "NUEVO"

            VARTRAB_INIEST = Now.ToShortDateString
            VARTRAB_NODO = DATOS_GESTIONRow("NODO")
            VARTRAB_TIEMEST = ""
            VARTRAB_DESCRIPCION = ""
            VARTRAB_ZONA = ""
            VARTRAB_MZNA = ""
            If IsDBNull(DATOS_GESTIONRow("CALLE")) = False Then VARTRAB_CALLE = DATOS_GESTIONRow("CALLE") Else VARTRAB_CALLE = ""
            If IsDBNull(DATOS_GESTIONRow("NUMERO")) = False Then VARTRAB_NRO = DATOS_GESTIONRow("NUMERO") Else VARTRAB_NRO = ""
            VARTRAB_DESCRIPCION = ""

            VARTRAB_INIEST = FECHAINI_NUEVOTRABAJO

            If IsDBNull(DATOS_TRABAJORow("TIPODEP")) = False Then
                Select Case DATOS_TRABAJORow("TIPODEP")
                    Case ""
                        VARTRAB_TIPODEP = "ULT"
                        DATOS_TRABAJORow("TIPODEP") = "IND"
                    Case ("IND")
                        VARTRAB_TIPODEP = "ULT"
                    Case ("ULT")
                        VARTRAB_TIPODEP = "ULT"
                        DATOS_TRABAJORow("TIPODEP") = "INT"
                    Case ("INT")
                        VARTRAB_TIPODEP = "ULT"
                End Select
            Else
                VARTRAB_TIPODEP = "ULT"
                DATOS_TRABAJORow("TIPODEP") = "IND"
            End If

            VARTRAB_DEP = DATOS_TRABAJORow("Id_TRABAJO")

            VAR_DEPENDENCIA = VARTRAB_DEP
            VAR_TIPODEP = VARTRAB_TIPODEP


            MENU_GESTION.Close()
            If NUEVOTRABAJO.Visible = False Then
                NUEVOTRABAJO.Show(Me)
            End If
            Me.Enabled = False
            Cursor = DefaultCursor
        End If
    End Sub  'COMBOS GENERAR TRABAJOS DESDE TRABAJOS
    Private Sub TRAB_ITEM1_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM1_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM1_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM2_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM2_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM2_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM3_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM3_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM3_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM4_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM4_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM4_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM5_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM5_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM5_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM6_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM6_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM6_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM7_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM7_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM7_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM8_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM8_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM8_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM9_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM9_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM9_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM10_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM10_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM10_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub
    Private Sub TRAB_ITEM11_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_ITEM11_ToolStrip.Click
        TRAB_TRAB_TOOLS_VAR = TRAB_ITEM11_ToolStrip.Text
        TRABAJO_TRAB_GENERAR()
    End Sub

    'ORDENES TOOLSTRIP ______________________
    Private Sub ORD_EMITIR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_EMITIR_ToolStrip.Click
        Try
            TIPOREGISTRO = "ORDEN"
            DATOS_ORDENESRow("FECHAINICIO") = Now.ToShortDateString
            DATOS_ORDENESRow("STATUS") = "INICIADO"
            DATOS_ORDENESRow.AGENDAR = False
            'CARGA HISTORICO
            DATOS_HIS_STATUSACTUAL = DATOS_ORDENESRow("STATUS")
            DATOS_HIS_CAUSA = "INICIO DE ORDEN"
            DATOS_HIS_DETALLE = "INICIO MANUAL"
            CARGA_HISTORICO()

            ORDENESTableAdapter.Update(DATOS_ORDENESRow)
            ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
            CARGA_VALORESORDENES()
            NOTIFICACION("SYS", "ORDEN " & NROORDENINT & " INICIADA")
        Catch EX As Exception
            NOTIFICACION("SYS", "OPSS! No se pudo EMITIR la orden " & DATOS_ORDENESRow.NRO_ORDENINT)
        End Try
    End Sub
    Private Sub ORD_CANCELAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_CANCELAR_ToolStrip.Click
        'ASIGNADO A CANCELAR
        DATOS_ORDENESRow("STATUS") = "CANCELADO"

        DATOS_ORDENESRow.CREARORDINAL = False
        DATOS_ORDENESRow.COORDINAR = False
        DATOS_ORDENESRow.AGENDAR = False
        DATOS_ORDENESRow.DESAGENDAR = False

        'CARGA HISTORICO
        DATOS_HIS_STATUSACTUAL = "CANCELADO"
        TIPOREGISTRO = "ORDEN"
        DATOS_HIS_CAUSA = "CANCELACION MANUAL"
        DATOS_HIS_DETALLE = "CANCELAR"
        CARGA_HISTORICO()

        'ACTUALIZA TABLA DE ORDENES
        ORDENESTableAdapter.Update(DATOS_ORDENESRow)
        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_ORDENESRow("ID_TRABAJO"))
        MsgBox("ORDEN CANCELADA", MsgBoxStyle.Information)
    End Sub
    Private Sub ORD_IRAORDEN_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_IRAORDEN_ToolStrip.Click
        VISTAORDINAL.Show(Me)
    End Sub
    Private Sub ORD_IMPRIMIR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_IMPRIMIR_ToolStrip.Click
        'CREAMOS EL PDF PARA LUEGO IMPRIMIRLO
        Dim FUENTETITULOCOTI As Font = FontFactory.GetFont("arial", 30, 1)
        Dim FUENTE As Font = FontFactory.GetFont("arial", 10, 1)
        Dim barra As New BaseColor(84, 84, 84)
        Dim BORRAR As New BaseColor(255, 255, 255)
        Dim P As Process
        For Each P In Process.GetProcesses()
            If (P IsNot Nothing) And (P.ProcessName = "AcroRD32") Then
                P.Kill()
            End If
        Next
        If Directory.Exists("C:\DOCUMENTOS\ARCHIVOS") = False Then
            Directory.CreateDirectory("C:\DOCUMENTOS\ARCHIVOS")
        End If
        Dim RUTA As String = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF"
        If File.Exists("C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF") = True Then
            Try
                File.Delete("C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF")
            Catch ex As Exception
                Dim archivos = My.Computer.FileSystem.GetFiles("C:\DOCUMENTOS\ARCHIVOS\")
                If archivos.Count >= 1 Then
                    For X = 1 To archivos.Count
                        Try
                            If File.Exists(Path.GetFullPath(archivos(X))) = True Then
                                File.Delete(Path.GetFullPath(archivos(X)))
                            End If
                        Catch eM As Exception

                        End Try
                    Next
                    archivos = My.Computer.FileSystem.GetFiles("C:\DOCUMENTOS\ARCHIVOS\")
                    If archivos.Count >= 1 Then
                        RUTA = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR(" & archivos.Count & ").PDF"
                    Else
                        RUTA = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF"
                    End If

                End If
            End Try
        End If
        Select Case DATOS_ORDENESRow("STATUS")
            Case "FINALIZADO"
                Select Case NROORDINAL
                    Case 0
                        TAREASTableAdapter.FillByNROORDENINT(ORDENESDataSet.TAREAS, NROORDENINT)
                        OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, NROORDENINT)
                    Case Else
                        TAREASTableAdapter.FillByNROORDINAL(ORDENESDataSet.TAREAS, NROORDINAL)
                        OBESERVACIONESTableAdapter.FillByNROORDINAL(ORDENESDataSet.OBESERVACIONES, NROORDINAL)
                End Select
            Case Else
                TAREASTableAdapter.FillByNROORDENINT(ORDENESDataSet.TAREAS, NROORDENINT)
                OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, NROORDENINT)
        End Select


        Dim DOCUMENTO As New Document(PageSize.A4, 3, 3, 0, 10)
        Dim writer As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(RUTA, FileMode.Create))
        DOCUMENTO.Open()

        Dim CeldaVACIA As New PdfPCell(New Phrase("")) With {
           .Border = 0
        }
        ENCABEZADO = New PdfPTable(6) With {
            .WidthPercentage = 90
            }
        Dim GIF As Image = Image.GetInstance(My.Resources.equital, Imaging.ImageFormat.Png)
        GIF.ScalePercent(40)
        Dim CeldaLOGO As New PdfPCell(GIF) With {
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaLOGO)

        Dim celdaORDENTRABAJO As New PdfPCell(New Phrase("ORDEN DE TRABAJO", FontFactory.GetFont("Helvetica", 16, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .PaddingBottom = 15,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
        ENCABEZADO.AddCell(celdaORDENTRABAJO)
        Dim CeldaOrden As New PdfPCell(New Phrase("Orden Nro: ", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
        ENCABEZADO.AddCell(CeldaOrden)
        Dim valorCAMPOORDINAL As String = ""
        Dim CeldaOrdinal As New PdfPCell(New Phrase("Nro. Ordinal:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
        ENCABEZADO.AddCell(CeldaOrdinal)

        'NUEVA LINEA
        For X = 1 To 4
            ENCABEZADO.AddCell(CeldaVACIA)
        Next
        Dim CeldaNroOrden As New PdfPCell(New Phrase(DATOS_ORDENESRow("NRO_ORDENINT"), FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderColor = barra,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaNroOrden)
        Dim CeldaNroOrdinal As New PdfPCell(New Phrase(DATOS_ORDENESRow("NRO_ORDINAL"), FontFactory.GetFont("Arial", 12, 1))) With {
           .BorderColor = barra,
           .HorizontalAlignment = Element.ALIGN_CENTER,
           .VerticalAlignment = Element.ALIGN_MIDDLE
       }
        ENCABEZADO.AddCell(CeldaNroOrdinal)

        'NUEVA LINEA
        Dim CeldaTIPO As New PdfPCell(New Phrase("Tipo:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaTIPO)
        Dim CeldaTIPOValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("TIPO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaTIPOValor)
        For X = 1 To 4
            ENCABEZADO.AddCell(CeldaVACIA)
        Next

        'NUEVA LINEA
        Dim CeldaSECTOR As New PdfPCell(New Phrase("Sector:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaSECTOR)
        Dim CeldaSECTORValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("SECTOROPE"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaSECTORValor)
        For X = 1 To 3
            ENCABEZADO.AddCell(CeldaVACIA)
        Next

        'NUEVA LINEA
        Dim CeldaAREA As New PdfPCell(New Phrase("Area:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaAREA)
        Dim CeldaAREAValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("SECTORDESTINO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaAREAValor)
        ENCABEZADO.AddCell(CeldaVACIA)
        Dim CeldaASIGNADO As New PdfPCell(New Phrase("Asignado:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaASIGNADO)
        If IsDBNull(DATOS_ORDENESRow("CUADRILLA")) = False Then
            Dim CeldaASIGNADOValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("CUADRILLA"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
            ENCABEZADO.AddCell(CeldaASIGNADOValor)
        Else
            Dim CeldaASIGNADOValor As New PdfPCell(New Phrase("SIN ASIGNAR", FontFactory.GetFont("Arial", 10, 1))) With {
           .Border = 0,
           .Colspan = 2,
           .HorizontalAlignment = Element.ALIGN_LEFT
       }
            ENCABEZADO.AddCell(CeldaASIGNADOValor)
        End If

        'NUEVA LINEA ESPACJO
        Dim CeldaVACIACLINEA As New PdfPCell(New Phrase("")) With {
           .BorderColor = barra,
           .BorderWidth = 1.5,
           .BorderWidthLeft = 0,
           .BorderWidthTop = 0,
           .BorderWidthRight = 0
        }
        For X = 1 To 6
            ENCABEZADO.AddCell(CeldaVACIACLINEA)
        Next

        'NUEVA LINEA
        Dim CeldaFING As New PdfPCell(New Phrase("Fecha Ingreso:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .Padding = 2,
        .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaFING)
        Dim CeldaValorFING As New PdfPCell(New Phrase(DATOS_ORDENESRow("FECHAINGRESO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
        .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaValorFING)
        Dim CeldaFINIEST As New PdfPCell(New Phrase("Fecha INI Est:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
        .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaFINIEST)
        Dim CeldaValorFINIEST As New PdfPCell(New Phrase(DATOS_ORDENESRow("FECHAINICESTIMADO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
        .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaValorFINIEST)
        If DATOS_ORDENESRow.IsFECHAAGENDNull = False Then
            Dim CeldaFAGENDA As New PdfPCell(New Phrase("Fecha AGENDA:", FontFactory.GetFont("Arial", 10, 0))) With {
          .Border = 0,
        .HorizontalAlignment = Element.ALIGN_RIGHT
       }
            ENCABEZADO.AddCell(CeldaFAGENDA)
            Dim CeldaValorFAGENDA As New PdfPCell(New Phrase(DATOS_ORDENESRow("FECHAAGEND"), FontFactory.GetFont("Arial", 10, 1))) With {
                      .Border = 0,
                  .HorizontalAlignment = Element.ALIGN_LEFT
                    }
            ENCABEZADO.AddCell(CeldaValorFAGENDA)

        Else
            ENCABEZADO.AddCell(CeldaVACIA)
            ENCABEZADO.AddCell(CeldaVACIA)
        End If

        'NUEVA LINEA ESPACIO
        Dim CeldaVACIACLINEAD As New PdfPCell(New Phrase("")) With {
           .BorderColor = barra,
           .BorderWidth = 1.5,
           .BorderWidthLeft = 0,
           .BorderWidthBottom = 0,
           .BorderWidthRight = 0
        }
        For X = 1 To 6
            ENCABEZADO.AddCell(CeldaVACIACLINEAD)
        Next

        'NUEVA LINEA
        Dim CeldaDIRECCION As New PdfPCell(New Phrase("DIRECCION:", FontFactory.GetFont("Arial", 15, 0))) With {
            .Border = 0,
            .Padding = 2,
            .Colspan = 2,
             .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaDIRECCION)
        Dim CeldaDIRECCIONValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("CALLE") & "  " & DATOS_ORDENESRow("NRO"), FontFactory.GetFont("Arial", 15, 1))) With {
            .Border = 0,
            .Colspan = 4,
             .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaDIRECCIONValor)

        'NUEVA LINEA
        Dim CeldaNODO As New PdfPCell(New Phrase("NODO:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .PaddingTop = 10,
             .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaNODO)
        Dim CeldaNODOValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("NODO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
             .PaddingTop = 10,
             .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaNODOValor)
        Dim CeldaZONA As New PdfPCell(New Phrase("ZONA:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
             .PaddingTop = 10,
             .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaZONA)
        Dim CeldaZONAValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("ZONA"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
             .PaddingTop = 10,
             .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaZONAValor)
        If IsDBNull(DATOS_ORDENESRow("MANZANA")) = False Then
            If DATOS_ORDENESRow("MANZANA") <> "" Then
                Dim CeldaMANZANA As New PdfPCell(New Phrase("MANZANA:", FontFactory.GetFont("Arial", 10, 0))) With {
                   .Border = 0,
                    .PaddingTop = 10,
                    .HorizontalAlignment = Element.ALIGN_RIGHT
                }
                ENCABEZADO.AddCell(CeldaMANZANA)
                Dim CeldaMANZANAValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("MANZANA"), FontFactory.GetFont("Arial", 10, 1))) With {
                    .Border = 0,
                     .PaddingTop = 10,
                     .HorizontalAlignment = Element.ALIGN_LEFT
                }
                ENCABEZADO.AddCell(CeldaMANZANAValor)
            Else
                ENCABEZADO.AddCell(CeldaVACIA)
                ENCABEZADO.AddCell(CeldaVACIA)
            End If
        Else
            ENCABEZADO.AddCell(CeldaVACIA)
            ENCABEZADO.AddCell(CeldaVACIA)
        End If

        'NUEVA LINEA
        Dim CeldaGESTION As New PdfPCell(New Phrase("Gestion:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .PaddingTop = 20,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaGESTION)
        Dim CeldaGESTIONValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("ID_GESTION") & "  " & DATOS_GESTIONRow("TIPOGESTION"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
               .PaddingTop = 20,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaGESTIONValor)
        Dim CeldaMotORIGEN As New PdfPCell(New Phrase("Motivo ORIGEN:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .Padding = 2,
            .PaddingTop = 20,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaMotORIGEN)
        Dim CeldaMotORIGENValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("MOTIVOORIGEN"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .PaddingTop = 20,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaMotORIGENValor)

        'NUEVA LINEA
        Dim CeldaTRABAJO As New PdfPCell(New Phrase("Trabajo:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaTRABAJO)
        Dim CeldaTRABAJOValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("ID_TRABAJO") & "  " & DATOS_TRABAJORow("TIPOTRABAJO"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaTRABAJOValor)
        Dim CeldaCausaORIGEN As New PdfPCell(New Phrase("Causa ORIGEN:", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_RIGHT
        }
        ENCABEZADO.AddCell(CeldaCausaORIGEN)
        Dim CeldaCausaORIGENValor As New PdfPCell(New Phrase(DATOS_ORDENESRow("CAUSARIGEN"), FontFactory.GetFont("Arial", 10, 1))) With {
            .Border = 0,
            .Colspan = 2,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaCausaORIGENValor)
        'NUEVA LINEA
        Dim CeldaOBSERVACIONES As New PdfPCell(New Phrase("Observaciones de ORIGEN", FontFactory.GetFont("Arial", 10, 0))) With {
            .Border = 0,
            .Colspan = 6,
            .PaddingTop = 15,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaOBSERVACIONES)
        'NUEVA LINEA
        Dim CeldaOBSERVACIONESValor As New PdfPCell(New Phrase(ORDOBSERVACION, FontFactory.GetFont("Arial", 10, 0))) With {
            .Padding = 8,
            .Colspan = 6,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaOBSERVACIONESValor)
        'NUEVA LINEA
        Select Case DATOS_ORDENESRow("STATUS")
            Case "FINALIZADO", "ADUPLICAR", "DUPLICADO"
                'NUEVA LINEA
                Dim CeldaOBSERVACIONESCierre As New PdfPCell(New Phrase("Observaciones de CIERRE", FontFactory.GetFont("Arial", 10, 0))) With {
                .Colspan = 6,
                .Border = 0,
                .PaddingTop = 8,
                .HorizontalAlignment = Element.ALIGN_LEFT
            }
                ENCABEZADO.AddCell(CeldaOBSERVACIONESCierre)
                'NUEVA LINEA
                Dim CeldaOBSERVACIONESValorCierre
                Dim OBSCIERRE As String = ""
                If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    For X = 0 To ORDENESDataSet.OBESERVACIONES.Rows.Count - 1

                        If ORDENESDataSet.OBESERVACIONES.Rows(X).Item("NROORDINAL") <> 0 Then
                            OBSCIERRE = ORDENESDataSet.OBESERVACIONES.Rows(X).Item("OBSCIERRE")
                        Else
                            If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(X).Item("OBSCIERRE")) = False Then
                                OBSCIERRE = ORDENESDataSet.OBESERVACIONES.Rows(X).Item("OBSCIERRE")
                            End If
                        End If
                    Next
                    CeldaOBSERVACIONESValorCierre = New PdfPCell(New Phrase(OBSCIERRE, FontFactory.GetFont("Arial", 10, 0))) With {
                            .Padding = 8,
                            .Colspan = 6,
                            .HorizontalAlignment = Element.ALIGN_LEFT
                        }
                Else
                    CeldaOBSERVACIONESValorCierre = New PdfPCell(New Phrase("SIN OBSERVACIONES", FontFactory.GetFont("Arial", 10, 0))) With {
                        .Padding = 8,
                        .Colspan = 6,
                        .HorizontalAlignment = Element.ALIGN_LEFT
                    }
                End If
                ENCABEZADO.AddCell(CeldaOBSERVACIONESValorCierre)
        End Select
        'NUEVA LINEA
        Dim CeldaTAREAS As New PdfPCell(New Phrase("TAREAS", FontFactory.GetFont("Arial", 10, 0))) With {
            .BorderWidth = 1.5,
            .BorderColor = barra,
            .BorderWidthTop = 0,
            .BorderWidthRight = 0,
            .BorderWidthLeft = 0,
            .Colspan = 6,
            .PaddingTop = 15,
            .PaddingBottom = 3,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
        ENCABEZADO.AddCell(CeldaTAREAS)
        If ORDENESDataSet.TAREAS.Rows.Count > 0 Then
            'NUEVA LINEA
            Dim CeldaTAREASTITULONOMBRE As New PdfPCell(New Phrase("DESCRIPCION TAREAS", FontFactory.GetFont("Arial", 11, 1))) With {
            .Colspan = 2,
            .Padding = 3,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE
        }
            ENCABEZADO.AddCell(CeldaTAREASTITULONOMBRE)
            Dim CeldaTAREASTITULOPREVISTO As New PdfPCell(New Phrase("CANT. PREVISTO", FontFactory.GetFont("Arial", 11, 1))) With {
            .Padding = 3,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE
        }
            ENCABEZADO.AddCell(CeldaTAREASTITULOPREVISTO)
            Dim CeldaTAREASTITULOREAL As New PdfPCell(New Phrase("CANTIDAD REAL", FontFactory.GetFont("Arial", 11, 1))) With {
            .Padding = 3,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE
        }
            ENCABEZADO.AddCell(CeldaTAREASTITULOREAL)

            Dim CeldaTAREASTITULOUNIDAD As New PdfPCell(New Phrase("UNIDAD TAREA", FontFactory.GetFont("Arial", 11, 1))) With {
            .Padding = 3,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE
        }
            If IsDBNull(ORDENESDataSet.TAREAS.Rows(0).Item("UNIDAD")) = False Then
                ENCABEZADO.AddCell(CeldaTAREASTITULOUNIDAD)
            Else
                ENCABEZADO.AddCell(CeldaVACIA)
            End If
            ENCABEZADO.AddCell(CeldaVACIA)
            'NUEVA LINEA
            Dim CELDAS(20)
            Dim CELDASPrevista(20)
            Dim CELDASValor(20)
            Dim CELDASUnidad(20)
            For T = 0 To ORDENESDataSet.TAREAS.Rows.Count - 1

                CELDAS(T) = New PdfPCell(New Phrase(ORDENESDataSet.TAREAS.Rows(T).Item("TAREADESC"), FontFactory.GetFont("Arial", 10, 0))) With {
                    .Colspan = 2,
                    .BorderColor = barra,
                    .HorizontalAlignment = Element.ALIGN_RIGHT
                    }
                CELDASPrevista(T) = New PdfPCell(New Phrase(ORDENESDataSet.TAREAS.Rows(T).Item("CANTSTD"), FontFactory.GetFont("Arial", 10, 1))) With {
                    .BorderColor = barra,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                If DATOS_ORDENESRow("STATUS") = "FINALIZADO" Then
                    If IsDBNull(ORDENESDataSet.TAREAS.Rows(T).Item("CANTREAL")) = False Then
                        CELDASValor(T) = New PdfPCell(New Phrase(ORDENESDataSet.TAREAS.Rows(T).Item("CANTREAL"), FontFactory.GetFont("Arial", 10, 1))) With {
                        .BorderColor = barra,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    Else
                        CELDASValor(T) = New PdfPCell(New Phrase("0", FontFactory.GetFont("Arial", 10, 1))) With {
                  .BorderColor = barra,
                  .HorizontalAlignment = Element.ALIGN_CENTER
                  }
                    End If
                Else
                    CELDASValor(T) = New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 10, 1))) With {
                   .BorderColor = barra,
                   .HorizontalAlignment = Element.ALIGN_CENTER
                   }
                End If
                If IsDBNull(ORDENESDataSet.TAREAS.Rows(T).Item("UNIDAD")) = False Then
                    CELDASUnidad(T) = New PdfPCell(New Phrase(ORDENESDataSet.TAREAS.Rows(T).Item("UNIDAD"), FontFactory.GetFont("Arial", 10, 1))) With {
                    .BorderColor = barra,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                End If
                ENCABEZADO.AddCell(CELDAS(T))
                ENCABEZADO.AddCell(CELDASPrevista(T))
                ENCABEZADO.AddCell(CELDASValor(T))
                If IsDBNull(ORDENESDataSet.TAREAS.Rows(T).Item("UNIDAD")) = False Then
                    ENCABEZADO.AddCell(CELDASUnidad(T))
                Else
                    ENCABEZADO.AddCell(CeldaVACIA)
                End If
                ENCABEZADO.AddCell(CeldaVACIA)
            Next
        Else
            Dim CeldaTAREASSIN As New PdfPCell(New Phrase("NO EXITEN TAREAS ASOCIADAS A LA ORDEN", FontFactory.GetFont("Arial", 10, 0))) With {
          .Colspan = 6,
          .Padding = 8,
          .HorizontalAlignment = Element.ALIGN_LEFT
      }
            ENCABEZADO.AddCell(CeldaTAREASSIN)
        End If
        'NUEVA LINEA
        Dim CeldaDATOSDECIERRE As New PdfPCell(New Phrase("DATOS DE CIERRE:", FontFactory.GetFont("Arial", 10, 0))) With {
          .Colspan = 6,
          .PaddingTop = 12,
          .BorderColor = barra,
           .BorderWidth = 1.5,
           .BorderWidthLeft = 0,
           .BorderWidthTop = 0,
           .BorderWidthRight = 0,
          .HorizontalAlignment = Element.ALIGN_LEFT
      }
        ENCABEZADO.AddCell(CeldaDATOSDECIERRE)
        Dim TEMPLATE As PdfTemplate = writer.DirectContent().CreateTemplate(18, 18)
        TEMPLATE.SetColorStroke(barra)
        TEMPLATE.SetColorFill(BORRAR)
        TEMPLATE.SetLineWidth(1.0F)
        TEMPLATE.RoundRectangle(1, 1, 16, 16, 3)
        TEMPLATE.FillStroke()
        writer.ReleaseTemplate(TEMPLATE)
        Dim CeldaOPCIONREALIZADO As New PdfPCell(Image.GetInstance(TEMPLATE)) With {
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0
        }
        'CeldaOPCIONREALIZADO = PdfPCell(New Phrase("X"))
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        Dim CeldaOPCIONREALIZADOTEXTO As New PdfPCell(New Phrase("REALIZADO", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADOTEXTO)
        Dim CeldaOPCIONSININCONVENIENTE As New PdfPCell(New Phrase("SIN INCONVENIENTES", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONSININCONVENIENTE)
        'NUEVA LINEA
        For D = 1 To 6
            ENCABEZADO.AddCell(CeldaVACIACLINEA)
        Next
        'NUEVA LIENA
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        Dim CeldaOPCIONPARCIAL As New PdfPCell(New Phrase("PARCIALMENTE REALIZADO", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONPARCIAL)
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        Dim CeldaOPCIONTERCEROS As New PdfPCell(New Phrase("PROBLEMAS CON TERCEROS", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONTERCEROS)
        'NUEVA LIENA
        Dim CeldaOPCIONNOREALIZADO As New PdfPCell(New Phrase("NO REALIZADO", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONNOREALIZADO)
        Dim CeldaOPCIONNOACCESO As New PdfPCell(New Phrase("NO ACCESO", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONNOACCESO)
        'NUEVA LIENA
        For D = 1 To 3
            ENCABEZADO.AddCell(CeldaVACIA)
        Next
        Dim CeldaOPCIONSINTIEMPO As New PdfPCell(New Phrase("SIN TIEMPO PARA REALIZAR", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONSINTIEMPO)
        'NUEVA LIENA
        For D = 1 To 3
            ENCABEZADO.AddCell(CeldaVACIA)
        Next
        Dim CeldaOPCIONFALTAMAT As New PdfPCell(New Phrase("FALTA DE MATERIALES", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONFALTAMAT)

        'NUEVA LIENA
        For D = 1 To 3
            Dim CeldaRAYAFIRMA As New PdfPCell(New Phrase("")) With {
          .BorderColor = barra,
           .BorderWidth = 0.8,
           .BorderWidthLeft = 0,
           .BorderWidthTop = 0,
           .BorderWidthRight = 0
      }
            ENCABEZADO.AddCell(CeldaRAYAFIRMA)
        Next
        Dim CeldaOPCIONCLIMA As New PdfPCell(New Phrase("CLIMA", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Padding = 4,
            .Border = 0,
            .Colspan = 2
        }
        ENCABEZADO.AddCell(CeldaOPCIONREALIZADO)
        ENCABEZADO.AddCell(CeldaOPCIONCLIMA)
        'NUEVA LIENA
        Dim CeldaFIRMA As New PdfPCell(New Phrase("FECHA Y FIRMA", FontFactory.GetFont("Arial", 10, 0))) With {
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Border = 0,
            .Colspan = 3
        }
        ENCABEZADO.AddCell(CeldaFIRMA)
        ENCABEZADO.AddCell(CeldaVACIA)
        ENCABEZADO.AddCell(CeldaVACIA)
        ENCABEZADO.AddCell(CeldaVACIA)



        'DOCUMENTO.Add(INICIO)
        DOCUMENTO.Add(ENCABEZADO)

        DOCUMENTO.Close()

        Process.Start(RUTA)

        'IMPRIMIR_ORDEN.Show()
    End Sub
    Private Sub ABRIR_AGENDA()
        If THEME_BLACK Then
            If FORMAGE.Visible = True Then
                If FORMAGE.Visible = True Then
                    FORMAGE.Close()
                    If DASHBOARD.BTN1.Text = "AGENDA" Then
                        EstiloBTNCerrar(1)
                    ElseIf DASHBOARD.BTN2.Text = "AGENDA" Then
                        EstiloBTNCerrar(2)
                    ElseIf DASHBOARD.BTN3.Text = "AGENDA" Then
                        EstiloBTNCerrar(3)
                    ElseIf DASHBOARD.BTN4.Text = "AGENDA" Then
                        EstiloBTNCerrar(4)
                    ElseIf DASHBOARD.BTN5.Text = "AGENDA" Then
                        EstiloBTNCerrar(5)
                    ElseIf DASHBOARD.BTN6.Text = "AGENDA" Then
                        EstiloBTNCerrar(6)
                    ElseIf DASHBOARD.BTN7.Text = "AGENDA" Then
                        EstiloBTNCerrar(7)
                    ElseIf DASHBOARD.BTN8.Text = "AGENDA" Then
                        EstiloBTNCerrar(8)
                    End If
                End If
            End If
            FORMAGE.TopLevel = False
            FORMAGE.Parent = DASHBOARD.PanelTrabajo
            FORMAGE.Dock = DockStyle.Fill
            FORMAGE.Show()
            FORMAGE.BringToFront()
        Else
            If FORMAGE.Visible Then
                FORMAGE.Close()
                DASHBOARD.BTN3Close.Visible = False
                DASHBOARD.BTN_AGENDA.BackgroundImage = My.Resources.AGENDA
            End If
            FORMAGE.TopLevel = False
            FORMAGE.Parent = DASHBOARD.PanelTrabajo
            FORMAGE.Dock = DockStyle.Fill
            FORMAGE.Show()
            FORMAGE.BringToFront()
        End If
    End Sub
    Private Sub ORD_AGENDAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_AGENDAR_ToolStrip.Click
        If ORD_AGENDAR_ToolStrip.Text = "AGENDAR" Then
            Me.Cursor = Cursors.WaitCursor
            CANT_ORDENESAAGENDAR = 0
            NROORDENINT = 0
            TIEMPO_AGENDA = 0

            For x = 0 To 20
                ORDEN_EST(x) = 0
            Next

            If DATOS_ORDENESRow("SECTORGEN") = "SC" Then
                MsgBox(DATOS_ORDENESRow("SECTOROPE") & " SIN SECTOR DEFINIDO, DEFINALA EN LA AGENDA", vbInformation)
            End If
            'APLICA ATRIBUTOS DEPENDIENDO EL TIPO DE LA ORDEN
            Select Case SECTOR
                Case "SUPERVISION"
                    SECTOR_CAP = "SU"
                    Select Case DATOS_ORDENESRow("SECTOROPE")
                        Case "MANTENIMIENTO"
                            RECURSO_CAP = "TEC"
                        Case "CUADRILLAS"
                            RECURSO_CAP = "CUA"
                        Case Else
                            MsgBox(DATOS_ORDENESRow("SECTOROPE") & " SIN SECTOR DEFINIDO, DEFINALA EN LA AGENDA", vbInformation)
                    End Select

                Case "PLANIFICACION TECNICA", "JEFATURA", "GERENCIA"
                    SECTOR_CAP = "PT"
                    Select Case DATOS_ORDENESRow("SECTOROPE")
                        Case "MANTENIMIENTO"
                            RECURSO_CAP = "TEC"
                        Case "CUADRILLAS"
                            RECURSO_CAP = "CUA"
                        Case Else
                            MsgBox(DATOS_ORDENESRow("SECTOROPE") & " SIN SECTOR DEFINIDO, DEFINALA EN LA AGENDA", vbInformation)
                    End Select

                Case "ADMINISTRACION"
                    SECTOR_CAP = DATOS_ORDENESRow("SECTORGEN")
                    Select Case DATOS_ORDENESRow("SECTOROPE")
                        Case "MANTENIMIENTO"
                            RECURSO_CAP = "TEC"
                        Case "CUADRILLAS"
                            RECURSO_CAP = "CUA"
                        Case Else
                            MsgBox(DATOS_ORDENESRow("SECTOROPE") & " no tiene capacidad definida en agenda", vbInformation)
                            Exit Sub
                    End Select

                Case "DESPACHO"
                    SECTOR_CAP = DATOS_ORDENESRow("SECTORGEN")
                    Select Case DATOS_ORDENESRow("SECTOROPE")
                        Case "MANTENIMIENTO"
                            RECURSO_CAP = "TEC"
                        Case "CUADRILLAS"
                            RECURSO_CAP = "CUA"
                        Case Else
                            MsgBox(DATOS_ORDENESRow("SECTOROPE") & " no tiene capacidad definida en agenda", vbInformation)
                            Exit Sub
                    End Select

                Case Else
                    SECTOR_CAP = "-"
                    RECURSO_CAP = "-"
                    MsgBox(SECTOR & " no tiene atributos para trabajar en AGENDA", vbInformation)
            End Select
            Select Case STATUSORD
                Case "INGRESADOINT", "DUPLICADO", "INGORDINAL", "COORDINADO"
                    For X = 0 To ORDENESDataGridView.SelectedRows.Count - 1
                        ORDEN_EST(X) = ORDENESDataGridView.SelectedRows(X).Cells(3).Value
                        TIEMPO_AGENDA += CInt(ORDENESDataGridView.SelectedRows(X).Cells(18).Value * CAPACIDAD_DIA / 100)
                    Next
                    CANT_ORDENESAAGENDAR = ORDENESDataGridView.SelectedRows.Count
                    NROORDENINT = ING_ORDORIGEN
                    If CANT_ORDENESAAGENDAR > 1 Then
                        ORDEN_TIPODEPENDENCIA = "EST"
                    Else
                        ORDEN_TIPODEPENDENCIA = DATOS_ORDENESRow.TIPODEP
                    End If
                    'ABRE EL FORMULARIO DE AGENDAR
                    ACCESO_AGENDA = "FORM_AGENDAR"
                    FORMAGE.ACCION_AGENDA = "AGENDAR"
                    ABRIR_AGENDA()
                Case "AGENDADO", "RUTEADO"
                    MsgBox("La ORDEN seleccionada ya tiene compromiso de AGENDA")
                Case "FINALIZADO"
                    MsgBox("La ORDEN seleccionada esta FINALIZADA")
                Case "ADUPLICAR"
                    MsgBox(" La ORDEN seleccionada esta FINALIZADA y ADUPLICAR, agende el DUPLICADO ")

                Case Else
                    MsgBox("La Orden seleccionada no tiene un STATUS agendable")
            End Select
            Me.Cursor = DefaultCursor
        Else
            Me.Cursor = Cursors.WaitCursor
            Select Case DATOS_ORDENESRow("STATUS")
                Case "AGENDADO", "COORDINADO"
                    VER_ORD_AGENDA.DESAGENDAR_ORDEN(ORDENESDataGridView, DATOS_ORDENESRow.FECHAAGEND.ToShortDateString, "DATOS")
            End Select
            Cursor = Cursors.Default
        End If
    End Sub
    Private Sub ORD_STATUS_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_STATUS_ToolStrip.Click
        If ORD_STATUS_ToolStrip.Text <> "CAMBIAR STATUS" Then
            VISTAORDINAL.Show(Me)
        End If
    End Sub
    Private Sub ORD_ESTRICTA_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_ESTRICTA_ToolStrip.Click

        'SUBRUTINA QUE CARGA UNA ORDEN CON DEPENDENCIA ESTRICTA DE OTRA, ES DECIR  ESTA SUJETA A LA ACCION EL MISMO DIA
        Me.Cursor = Cursors.WaitCursor
        TIEMPO_AGENDA = 0
        TIEMPO_FINAL = 0

        ACCION_ORDEN = "NUEVO"
        CARGAR_DATOSORDENDEPENDIENTE()
        'CARGA DATOS DE DEPENDENCIA (DE QUE ORDEN DEPENDE)
        ING_DEPENDENCIA = DATOS_ORDENESRow("NRO_ORDENINT")
        'ING_FECHAINICEST = DATOS_TRABAJORow("FECHAINICESTIMADO")
        ING_CLASEDEP = "EST"
        VAR_CLASEDEP = "EST"

        'DETERMINA EL TIPO DE DEPENDENCIA (PRI-PRIMERA , INT-INTERMEDIA, ULT-ULTIMA, PAS-CAMBIO DE CLASE)
        If IsDBNull(DATOS_ORDENESRow("TIPODEP")) = False Then
            Select Case DATOS_ORDENESRow("TIPODEP")
                Case "IND"
                    'ORDEN ACTUAL
                    DATOS_ORDENESRow("TIPODEP") = "IND"
                    DATOS_ORDENESRow("CLASEDEP") = "EST"
                    DATOS_ORDENESRow("ORDORIGEN") = ING_DEPENDENCIA
                    'ORDEN A CREAR
                    ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                    ING_TIPODEP = "PRI"
                Case "PRI"
                    Select Case DATOS_ORDENESRow("CLASEDEP")
                        Case "DIN"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PAS"
                            DATOS_ORDENESRow("ORDORIGEN") = DATOS_ORDENESRow("NRO_ORDENINT")
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                            ING_TIPODEP = "PRI"
                        Case "EST"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PRI"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                            ING_TIPODEP = "ULT"
                    End Select
                Case "INT"
                    Select Case DATOS_ORDENESRow("CLASEDEP")
                        Case "DIN"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PAS"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                            ING_TIPODEP = "PRI"
                        Case "EST"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "INT"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                            ING_TIPODEP = "PRI"
                    End Select
                Case "ULT"
                    Select Case DATOS_ORDENESRow("CLASEDEP")
                        Case "DIN"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PAS"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                            ING_TIPODEP = "PRI"
                        Case "EST"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "INT"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                            ING_TIPODEP = "ULT"
                    End Select
            End Select
        Else

        End If
        VAR_TIPODEP = ING_TIPODEP

        'DETERMINA EL ORDEN DE LA ORDEN A DEPENDER, SI NO ESTA CARGADO COLOCA UN 0
        If IsDBNull(DATOS_ORDENESRow("ORDENDEP")) = False Then
            ING_ORDENDEP = DATOS_ORDENESRow("ORDENDEP") + 1
        Else
            DATOS_ORDENESRow("ORDENDEP") = 0
            ING_ORDENDEP = DATOS_ORDENESRow("ORDENDEP") + 1
        End If
        VAR_ORDENDP = ING_ORDENDEP

        'CARGA LA FECHA DE INICIO DE LA ORDEN DEPENDIENTE DINAMICA
        Dim FECHA_ACARGAR As Date
        Dim FECHA_POSIBLE As Date

        'TOMA EN CONSIDERACION LA FECHA QUE CORRESPONDE PARA EVALUAR LA FECHA DE INICIO DE LA ORDEN A CREAR
        If IsDBNull(DATOS_ORDENESRow("FECHAINICIO")) = False Then
            'SI LA ORDEN ESTA INICIADA
            FECHA_ACARGAR = DATOS_ORDENESRow("FECHAINICIO")
        Else
            If DATOS_ORDENESRow.IsFECHAAGENDNull = False Then
                'SI LA ORDEN NO ESTA INICADA PERO ESTA AGENDADA
                FECHA_ACARGAR = DATOS_ORDENESRow("FECHAAGEND")
            Else
                If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then
                    'SI LA ORDEN NO ESTA AGENDADA PERO TIENE CARGADA FECHA DE INICIO ESTIMADO
                    FECHA_ACARGAR = DATOS_ORDENESRow("FECHAINICESTIMADO")
                Else
                    'LA ORDEN NO TIENE FECHAS DE REFERANCIA CARGADA
                    MsgBox("La Orden Seleccionada no tiene los datos de fecha necesarios como para ejecutar esta operacion", vbInformation)
                    Exit Sub
                End If
            End If
        End If


        'DEFINE LA FECHA POSIBLE COMO LA MISMA QUE LA ORDEN QUE SE SELECCIONO
        FECHA_POSIBLE = FECHA_ACARGAR
        ING_FECHAINICEST = FECHA_POSIBLE.Date

        'VERIFICA LOS TIEMPOS DE LAS ORDENES INVOLUCRADAS DE MANERA DE DETERMINAR SI ENTRAN EN LA CAPACIDAD DEL DIA

        Dim ORDEN_DEPENDENCIA As Integer = DATOS_ORDENESRow("DEPENDENCIA")
        Dim ORDEN_CLASEDEP As String = DATOS_ORDENESRow("CLASEDEP")
        'Dim ORDEN_TIEMPOPREVISTO As Integer
        Dim ORDEN_ORDENDEP As Integer = DATOS_ORDENESRow("ORDENDEP")

        'ACCIONA DE ACUERDO A LA CLASE DE DEPENDENCIA DE LA ORDEN SELECCIONADA
        Select Case DATOS_ORDENESRow("CLASEDEP")
            Case "IND"  'LA ORDEN DE QUIEN DEPENDE ES INDEPENDIENTE
                TIEMPO_AGENDA = CInt(DATOS_ORDENESRow("TPREVISTO") * CAPACIDAD_DIA / 100)
            Case "DIN" 'LA ORDEN DE QUIEN DEPENDE ES DINAMICA
                TIEMPO_AGENDA = CInt(DATOS_ORDENESRow("TPREVISTO") * CAPACIDAD_DIA / 100)
            Case "EST"  'LA ORDEN DE QUIEN DEPENDE TAMBIES ES ESTRICTA
                'BUSCA LA ORDEN DE DEPENDENCIA DE LA ORDEN SELECCIONADA
                ORDENESTableAdapter.FillByORDORIGEN(OrdenesDataSet4.ORDENES, ING_ORDORIGEN, ING_ORDORIGEN)

                For I = 0 To OrdenesDataSet4.ORDENES.Rows.Count - 1
                    TIEMPO_AGENDA += CInt(OrdenesDataSet4.ORDENES.Rows(I).Item("TPREVISTO") * CAPACIDAD_DIA / 100)
                    'MsgBox(TIEMPO_AGENDA)
                Next I
        End Select
        'TIEMPO_AGENDA = ORDEN_TIEMPOPREVISTO

        ORDEN_TIEMPORESTANTE = CAPACIDAD_DIA - TIEMPO_AGENDA

        ORDENESDataGridView.ContextMenuStrip = Nothing

        STANDARD.Show(Me)
        Me.Enabled = False

        Me.Cursor = DefaultCursor
    End Sub

    Private Sub ORD_DINAMICA_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_DINAMICA_ToolStrip.Click
        DINAMICA()
        ORDENESDataGridView.ContextMenuStrip = Nothing
        STANDARD.Show(Me)
        Me.Enabled = False
        Me.Cursor = DefaultCursor
    End Sub
    Private Sub ORD_MARCACOORDINAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_MARCACOORDINAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        If ORD_MARCACOORDINAR_ToolStrip.Text = "Quitar COORDINAR" Then
            DATOS_ORDENESRow("COORDINAR") = False
            Select Case DATOS_ORDENESRow.STATUS
                Case "COORDINAR"
                    If DATOS_ORDENESRow.NRO_ORDINAL = 0 Then
                        DATOS_ORDENESRow.STATUS = "INGRESADOINT"
                    Else
                        DATOS_ORDENESRow.STATUS = "INGORDINAL"
                    End If
            End Select
            NOTIFICACION("SYS", "ORDEN " & NROORDENINT & " SE QUITO MARCA DE COORDINAR")
        Else
            DATOS_ORDENESRow("COORDINAR") = True
            DATOS_ORDENESRow.STATUS = "COORDINAR"
            NOTIFICACION("SYS", "ORDEN " & NROORDENINT & " MARCADA PARA COORDINAR")
        End If

        ORDENESTableAdapter.Update(DATOS_ORDENESRow)
        Cursor = DefaultCursor

    End Sub
    Private Sub ORD_MARCACREAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_MARCACREAR_ToolStrip.Click
        Cursor = Cursors.WaitCursor
        If ORD_MARCACREAR_ToolStrip.Text = "Marcar CREAR ORDINAL" Then
            DATOS_ORDENESRow("CREARORDINAL") = True
            NOTIFICACION("SYS", "ORDEN " & DATOS_ORDENESRow.NRO_ORDENINT & " MARCADA PARA CREAR")
        Else
            DATOS_ORDENESRow("CREARORDINAL") = False
            NOTIFICACION("SYS", "ORDEN " & DATOS_ORDENESRow.NRO_ORDENINT & " SE QUITO MARCA CREAR")
        End If
        ORDENESTableAdapter.Update(DATOS_ORDENESRow)
        Cursor = DefaultCursor
    End Sub
    Private Sub ORD_EDITAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_EDITAR_ToolStrip.Click
        EDITAR_ORDEN()
    End Sub
    Private Sub EDITAR_ORDEN()
        ACCION_ORDEN = "EDITAR"
        'EDITA UNA ORDEN DE TRABAJO

        'If AUTORIZADO = True Then
        ING_FECHAINICEST = VARTRAB_INIEST
        Select Case DATOS_ORDENESRow("CLASEDEP")
            Case "IND"  'LA ORDEN DE QUIEN DEPENDE ES INDEPENDIENTE
                TIEMPO_AGENDA = CInt(DATOS_ORDENESRow("TPREVISTO") * CAPACIDAD_DIA / 100)
                ORDEN_TIEMPORESTANTE = CAPACIDAD_DIA
            Case "DIN" 'LA ORDEN DE QUIEN DEPENDE ES DINAMICA
                TIEMPO_AGENDA = CInt(DATOS_ORDENESRow("TPREVISTO") * CAPACIDAD_DIA / 100)
                ORDEN_TIEMPORESTANTE = CAPACIDAD_DIA
            Case "EST"  'LA ORDEN DE QUIEN DEPENDE TAMBIES ES ESTRICTA
                'BUSCA LA ORDEN DE DEPENDENCIA DE LA ORDEN SELECCIONADA
                Me.Cursor = Cursors.WaitCursor
                ORDENESTableAdapter.FillByORDORIGEN(OrdenesDataSet4.ORDENES, ING_ORDORIGEN, ING_ORDORIGEN)

                For I = 0 To OrdenesDataSet4.ORDENES.Rows.Count - 1
                    TIEMPO_AGENDA += CInt(OrdenesDataSet4.ORDENES.Rows(I).Item("TPREVISTO") * CAPACIDAD_DIA / 100)

                Next I
                ORDEN_TIEMPORESTANTE = CAPACIDAD_DIA - TIEMPO_AGENDA
                Me.Cursor = DefaultCursor
        End Select

        TRABAJOSDataGridView.ContextMenuStrip = Nothing

        STANDARD.Show(Me)
        Me.Enabled = False

    End Sub
    Private Sub ORD_ELIMINAR_ToolStrip_Click_1(sender As Object, e As EventArgs) Handles ORD_ELIMINAR_ToolStrip.Click
        If DATOS_ORDENESRow.STATUS = "INGORDINAL" Then
            MsgBox("RECUERDE ELIMINAR EL ORDINAL " & DATOS_ORDENESRow.NRO_ORDINAL & " EN EL SISTEMA DE ORDINALES", MsgBoxStyle.Critical, "ATENCION!")
        End If
        Try
            'GENERA UN HISTORICO PARA VERIFICAR QUE SE BORRO LA ORDEN Y QUIEN FUE
            TIPOREGISTRO = "ORDEN"
            If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                DATOS_STATUSANT = DATOS_ORDENESRow("STATUS")
            Else
                DATOS_STATUSANT = "-------"
            End If
            DATOS_HIS_STATUSACTUAL = "CANCELADA"
            DATOS_HIS_CAUSA = "MANUAL"
            DATOS_HIS_DETALLE = "ELIMINACION MANUAL"
            CARGA_HISTORICO()

            OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, DATOS_ORDENESRow.NRO_ORDENINT)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                ORDENESDataSet.OBESERVACIONES.Rows(0).Delete()
                OBESERVACIONESTableAdapter.Update(ORDENESDataSet.OBESERVACIONES.Rows(0))
            End If
            TAREASTableAdapter.FillByordinal0(ORDENESDataSet.TAREAS, DATOS_ORDENESRow.NRO_ORDENINT)
            For X = 0 To ORDENESDataSet.TAREAS.Rows.Count - 1
                If DATOS_ORDENESRow.NRO_ORDENINT <> 0 Then
                    TAREASTableAdapter.DeleteQueryNRO_ORDENINT(DATOS_ORDENESRow.NRO_ORDENINT)
                End If
            Next
            ADJUNTOSTableAdapter.FillByORDEN(ORDENESDataSet.ADJUNTOS, DATOS_ORDENESRow.NRO_ORDENINT)
            If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
                Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
                Dim CANTIDADORDENES As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO")).Count
                Try
                    For X = 0 To ORDENESDataSet.ADJUNTOS.Rows.Count - 1
                        File.Delete(ORDENESDataSet.ADJUNTOS.Rows(X).Item("RUTA_ADJUNTO"))
                        If CANTIDADORDENES = 1 Then
                            If Directory.GetDirectories(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION")).Count = 1 Then
                                Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO"))
                                Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION"))
                            Else
                                Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO"))
                            End If
                        End If
                    Next
                Catch ex As Exception
                End Try
                ADJUNTOSTableAdapter.DeleteQueryNRO_ORDEN(DATOS_ORDENESRow.NRO_ORDENINT)
            End If

            If DATOS_ORDENESRow.NRO_ORDENINT <> 0 Then
                ORDENESTableAdapter.DeleteQueryIDINTERNA(DATOS_ORDENESRow.NRO_ORDENINT)
            End If

            ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("Id_TRABAJO"))
            NOTIFICACION("SYS", "ORDEN " & NROORDENINT & " HA SIDO ELIMINADA")
        Catch ex As Exception
            NOTIFICACION("SYS", "ORDEN " & NROORDENINT & " NO PUDO SER ELIMINADA")
        End Try

    End Sub
    Private Sub ORD_REACTIVARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORD_REACTIVARToolStrip.Click
        'AL REACTIVAR UNA ORDEN:
        '- GRABAR INCIDENCIA AL MOMENTO DE REACTIVAR EN HISTORICO DE LA ORDEN
        TIPOREGISTRO = "ORDEN"
        DATOS_HIS_STATUSACTUAL = "ORDEN REACTIVADA"
        DATOS_HIS_CAUSA = "REACTIVACION MANUAL"
        DATOS_HIS_DETALLE = "CORRECCION"
        CARGA_HISTORICO()
        '- CAMBIAR EL STATUS A ASIGNADO
        DATOS_ORDENESRow.STATUS = "ASIGNADO"
        DATOS_ORDENESRow.MOTIVOCIERRE = ""
        DATOS_ORDENESRow.CAUSACIERRE = ""
        DATOS_ORDENESRow("FECHAINICIO") = DBNull.Value
        DATOS_ORDENESRow("FECHAFIN") = DBNull.Value
        DATOS_ORDENESRow("FECHACIERRE") = DBNull.Value

        '- FECHA DE REASINGACION NUEVA.
        DATOS_ORDENESRow.FECHA_ASIGNADA = Now
        ORDENESTableAdapter.Update(DATOS_ORDENESRow)   'ACTUALIZA DATOS

        '- MANDAR MAIL AUTOMATICO, MOTIVO DEACTIVACION DE ORDEN.
        MENSAJE = ""
        SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, DATOS_ORDENESRow.SECTOROPE)
        Dim DESTINATARIO_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")
        SECTORESTableAdapter.FillBySECTOR(OrdenesDataSet1.SECTORES, SECTOR)
        Dim REMITENTE_SECTOR As String = OrdenesDataSet1.SECTORES.Rows(0).Item("EMAIL")

        MENSAJE = "Hola, " & Split(DATOS_ORDENESRow.CUADRILLA, " ")(0) & ". " & vbNewLine
        MENSAJE += FULLNOMBRE & " le ha REACTIVADO la orden " & DATOS_ORDENESRow("NRO_ORDENINT") & "."
        If DATOS_ORDENESRow.DOCUMENTO_FISICO = True Then
            MENSAJE += vbNewLine & "La orden tiene marcada que la documentacion adjunta es FISICA."
        Else
            MENSAJE += vbNewLine & "La orden tiene marcada que la documentacion adjunta es DIGITAL."
        End If
        If SECTOR = "OBRA CIVIL" Then
            ENVIAR_EMAIL(DATOS_ORDENESRow.PRIORIDAD, DESTINATARIO_SECTOR, "ORDEN REACTIVADA", MENSAJE, REMITENTE)
        Else
            ENVIAR_EMAIL(DATOS_ORDENESRow.PRIORIDAD, DESTINATARIO_SECTOR, "ORDEN REACTIVADA", MENSAJE, REMITENTE, REMITENTE_SECTOR)
        End If

    End Sub
    Private Sub ORD_CREARORDBOTToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_CREARORDBOTToolStrip.Click
        File.WriteAllText("C:\DOCUMENTOS\USUARIO\CommandBOT.txt", "A," & NROORDENINT)
        DATOS_ORDENESRow.CREARORDINAL = True
        ORDENESTableAdapter.Update(DATOS_ORDENESRow)
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\W10\" & VERSION & "\BOTSverver.exe")
        Else
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\" & VERSION & "\BOTSverver.exe")
        End If
    End Sub
    'FIN TOOLSTRIP ______________________________________________________________________________

    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Dim RESULTADO As DialogResult = OpenFileDialog1.ShowDialog()

            OpenFileDialog1.Multiselect = True
            If RESULTADO = DialogResult.OK Then

                Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
                Dim MSGBOX1 As MsgBoxResult
                Dim mover As Boolean = False

                If Directory.Exists(PathADJUNTOS) = False Then
                    Directory.CreateDirectory(PathADJUNTOS)
                End If 'CREA EL DIRECTORIO ADJUNTOS SI NO EXISTE
                If Directory.Exists(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO")) = False Then
                    Directory.CreateDirectory(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO"))
                End If 'PREGUNTAMOS SI EXISTE EL DIRECTORIO CREADO, DE LO CONTRARIO SE CREA

                'SE PREGUNTA SI SE QUIERE MOVER EL ARCHIVO A ADJUNTAR
                MSGBOX1 = MsgBox("MOVER ARCHIVO/S SELECCIONADO?" & vbNewLine & vbNewLine & "Si selecciona SI, borra el archivo seleccionado" & vbNewLine & "en caso contrario lo mantiene" & vbNewLine & "Para ambos casos el sistema creara un nuevo archivo" & vbNewLine & "asociado a la orden", vbYesNo, "ARCHIVO SELECCIONADO")
                If MSGBOX1 = DialogResult.Yes Then
                    mover = True
                End If
                ' MsgBox(OpenFileDialog2.FileNames.GetValue)

                'VERIFICAMOS SI YA EXISTE UN ARCHIVO QUE SE LLAME IGUAL, DENTRO DE LA CARPETA
                For A = 0 To OpenFileDialog1.FileNames.Length - 1
                    Dim CANTARCHIVOS As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\").Count
                    Dim NombreArchivos = Directory.GetFiles(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\")
                    Dim IgualArchivo As Boolean
                    PathRuta = OpenFileDialog1.FileNames(A)

                    NEWADJUNTORow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                    NEWADJUNTORow("ID_GESTION") = DATOS_TRABAJORow("ID_GESTION")
                    NEWADJUNTORow("ID_TRABAJO") = DATOS_TRABAJORow("ID_TRABAJO")
                    NEWADJUNTORow("ID_ORDEN") = DATOS_TRABAJORow("ID_TRABAJO")
                    If CANTARCHIVOS > 0 Then
                        For Each ExisteArchivo In NombreArchivos
                            If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS_TRABAJORow("ID_TRABAJO").ToString Then
                                IgualArchivo = True
                                Exit For
                            Else
                                IgualArchivo = False
                            End If
                        Next
                        If IgualArchivo = True Then
                            Try
                                NEWADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A))
                                File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                            Catch ex As Exception
                            End Try
                        Else
                            Try
                                NEWADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(OpenFileDialog1.FileNames(A))
                                File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                            Catch ex As Exception
                            End Try
                        End If
                    Else
                        NEWADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(OpenFileDialog1.FileNames(A))
                        File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                    End If
                    NEWADJUNTORow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileNames(A))

                    ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NEWADJUNTORow)
                    ADJUNTOSTableAdapter.Update(NEWADJUNTORow)
                    ADJUNTOSTableAdapter.FillByTRABAJO(ORDENESDataSet.ADJUNTOS, DATOS_TRABAJORow("ID_TRABAJO"), DATOS_TRABAJORow("ID_TRABAJO"))
                    'BORRA EL ARCHIVO DE ORIGEN
                    If mover = True Then
                        Try
                            File.Delete(PathRuta)
                        Catch ex As Exception
                            MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                        End Try
                    End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                Next A

                BTN_BORRAR.Visible = True
            End If
        Else
            If FOpenFileDialog.Visible = True Then
                FOpenFileDialog.BringToFront()
            Else
                FOpenFileDialog.Show(Me)
            End If
        End If
    End Sub
    Private Sub ADJUNTOSDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ADJUNTOSDataGridView.DoubleClick
        Dim RUTA_ARCHIVOS As String
        If ADJUNTOSDataGridView.Rows.Count > 0 Then
            RUTA_ARCHIVOS = ADJUNTOSDataGridView.CurrentRow.Cells.Item(0).Value
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
    Private Sub ADJUNTOSDataGridView_TextChanged(sender As Object, e As EventArgs) Handles ADJUNTOSDataGridView.TextChanged
        If ORDENESDataSet.ADJUNTOS.Rows.Count > 0 Then
            BTN_BORRAR.Visible = True
        Else
            BTN_BORRAR.Visible = False
        End If
    End Sub
    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
        Dim CANTIDADORDENES As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO")).Count
        If ADJUNTOSDataGridView.SelectedRows.Count > 0 Then
            Try
                File.Delete(ORDENESDataSet.ADJUNTOS.Rows(ADJUNTOSBindingSource.Position).Item("RUTA_ADJUNTO"))
                If CANTIDADORDENES = 1 Then
                    If Directory.GetDirectories(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION")).Count = 1 Then
                        Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO"))
                        Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION"))
                    Else
                        Directory.Delete(PathADJUNTOS & "\" & DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS_TRABAJORow("ID_TRABAJO"))
                    End If
                End If
            Catch ex As Exception
            End Try
            ORDENESDataSet.ADJUNTOS.Rows(ADJUNTOSBindingSource.Position).Delete()
            ADJUNTOSTableAdapter.Update(ORDENESDataSet.ADJUNTOS)
            MsgBox("Registro y archivo adjunto borrado")
        End If
        If ADJUNTOSDataGridView.Rows.Count < 1 Then
            BTN_BORRAR.Visible = False
        End If
    End Sub
    Private Sub BTN_AGREGAR_MouseHover(sender As Object, e As EventArgs) Handles BTN_AGREGAR.MouseHover
        'If THEME_BLACK Then
        BTN_AGREGAR.BackgroundImage = My.Resources.BTNGRAL_OVER
        'Else
        '    BTN_AGREGAR.BackgroundImage = My.Resources.BTN_VERMAS
        'End If

    End Sub
    Private Sub BTN_AGREGAR_MouseLeave(sender As Object, e As EventArgs) Handles BTN_AGREGAR.MouseLeave
        'If THEME_BLACK Then
        BTN_AGREGAR.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        'Else
        '    BTN_AGREGAR.BackgroundImage = My.Resources.BTN_VERMAS
        'End If
    End Sub
    Private Sub ORD_VER_RUSToolStrip_Click(sender As Object, e As EventArgs) Handles ORD_VER_RUSToolStrip.Click

        'VARIABLES PRIMARIOS PARA EL WEBDRIVER

        Dim URL As String = "http://wsinterno.equital.com/RUSEQ3.2/servlet/rus" ' PANTALLA LOGIN
        'Dim URL_BUSQUEDA As String = "http://wsinterno.equital.com/SERVICIOSURANO2.0/servlet/com.ordsrv.wwordinal" 'MUESTRA LA PANTALLA PRINCIPAL DEL LISTADO DE ORDINALES

        'VARIABLE MAESTRA EQUITAL
        'Dim CODIGO_EQ_042 As String = "W0024W0007"
        'Dim CODIGO_EQ_043 As String = "W0043"
        'Dim CODIGO_EQ_044 As String = "W0044W0007"
        Dim ESPERA As Integer
        Dim PASA As Boolean
        'VARIABLES DE LOGIN

        Dim USUARIO_ORDINAL As String = "vUSUARIO"
        Dim PASS_ORDINAL As String = "vUSRPSW"
        Dim INGRESAR_LOG_ORDINAL As String = "BUTTON1"
        Dim INGRESAR_MODULO_ORDINAL As String = "Object_vAPLLGOIMG_000"


        If USUARIO_RUS <> "" And PASSWORD_RUS <> "" And SELECTOR <> "" Then
            If driver Is Nothing Then
                Dim CHROMEOPTION As New ChromeOptions()
                CHROMEOPTION.PageLoadStrategy = PageLoadStrategy.Eager
                driver = New ChromeDriver(CHROMEOPTION)
            Else
                driver.Quit()
                driver.Dispose()
                ' driver = Nothing
                Dim CHROMEOPTION As New ChromeOptions()
                CHROMEOPTION.PageLoadStrategy = PageLoadStrategy.Eager
                driver = New ChromeDriver(CHROMEOPTION)
            End If 'INICIA EL DRIVER DEL BOT

            driver.Url = URL
            driver.Manage().Window.Maximize()

            'LOGIN DE USUARIO
            ESPERA = 100
            For p = 1 To 10
                Try
                    ESPERA += 100
                    Threading.Thread.Sleep(ESPERA)
                    Dim inputLoginUser = driver.FindElement(By.Id(USUARIO_ORDINAL))
                    inputLoginUser.SendKeys(USUARIO_RUS)
                    Threading.Thread.Sleep(ESPERA)
                    Dim inputLoginPass = driver.FindElement(By.Id(PASS_ORDINAL))
                    inputLoginPass.SendKeys(PASSWORD_RUS)
                    driver.FindElement(By.Name(INGRESAR_LOG_ORDINAL)).Click()
                    PASA = True
                    Exit For
                Catch ex As Exception
                    PASA = False
                End Try
            Next
            If PASA = False Then
                MsgBox("ERROR CON EL USUARIO O CONTRASEÑA RUS - MODIFÍQUELO EN DATOS DEL USUARIO")
                Exit Sub
            End If
            'INGRESAMOS A MODULO ORDINALES
            ESPERA = 100
            For P = 1 To 50
                Try
                    Threading.Thread.Sleep(ESPERA)
                    ESPERA += 100
                    driver.FindElement(By.Id(INGRESAR_MODULO_ORDINAL & SELECTOR)).Click()
                    PASA = True
                    Exit For
                Catch ex As Exception
                    PASA = False
                End Try
            Next
            If PASA = False Then
                MsgBox("ERROR CON EL SELECTOR DE RUS - MODIFÍQUELO EN DATOS DEL USUARIO")
                Exit Sub
            End If

            Try
                driver.Url = "http://wsinterno.equital.com/SERVICIOSURANO2.0/servlet/com.ordsrv.entitymanagerordinal?DSP," & DATOS_ORDENESRow.NRO_ORDINAL & ",General"
            Catch ex As Exception

            End Try
            If VER_ORDINAL_BOT.Visible = False Then
                VER_ORDINAL_BOT.Show(Me)
            End If
            VER_ORDINAL_BOT.BringToFront()
            'VER_ORDINAL_BOT.TopMost = False
            VER_ORDINAL_BOT.LBL_ORDINAL.Text = "VISUALIZANDO EL ORDINAL " & DATOS_ORDENESRow.NRO_ORDINAL
        Else
            MsgBox("COMPLETE EL PERFIL PARA ACCEDER AL RUS DESDE EL BOTON USUARIO EN LA BARRA INFERIOR DE LA PANTALLA", vbExclamation)
        End If
    End Sub
    Private Sub BTN_VER_PLANOS_Click(sender As Object, e As EventArgs) Handles BTN_VER_PLANOS.Click
        If INDICESDataSet.PLANOS.Rows.Count > 0 Then
            Dim PATH As String = INDICESDataSet.PLANOS.Rows(0).Item("PATH")
            Process.Start(PATH)
        End If
    End Sub
    Private Sub BTN_AGREGAR_ZONA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_ZONA.Click
        Dim RESULTADO As DialogResult = OpenFileDialog1.ShowDialog()
        OpenFileDialog1.InitialDirectory = "F:\CABECERA\ACAD\MDEO"
        OpenFileDialog1.Multiselect = False
        If RESULTADO = DialogResult.OK Then
            If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                Dim NEWPLANORow As INDICESDataSet.PLANOSRow
                NEWPLANORow = INDICESDataSet.PLANOS.NewPLANOSRow()
                NEWPLANORow.NODO = DATOS_TRABAJORow.NODO
                NEWPLANORow.ZONA = CInt(DATOS_TRABAJORow.ZONA)
                NEWPLANORow.PATH = OpenFileDialog1.FileName
                INDICESDataSet.PLANOS.AddPLANOSRow(NEWPLANORow)
                PLANOSTableAdapter.Update(NEWPLANORow)
            Else
                MsgBox("seleccione un archivo")
            End If
        End If
    End Sub
    Private Sub BTN_VER_PLANOS_MouseHover(sender As Object, e As EventArgs) Handles BTN_VER_PLANOS.MouseHover
        BTN_VER_PLANOS.BackgroundImage = My.Resources.BTNGRAL_OVER
    End Sub
    Private Sub BTN_VER_PLANOS_MouseLeave(sender As Object, e As EventArgs) Handles BTN_VER_PLANOS.MouseLeave
        BTN_VER_PLANOS.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    End Sub
    Private Sub LBL_ATRIBUTO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBL_ATRIBUTO1.SelectedIndexChanged
        GESTIONTableAdapter.FillByGEST_ACTIVAS_ATRIBUTO(ORDENESDataSet.GESTION, BUSCA_NODO.Text, LBL_ATRIBUTO1.Text)
    End Sub
    Private Sub BTN_SERVICIO_Click(sender As Object, e As EventArgs) Handles BTN_SERVICIO.Click
        Cursor = Cursors.WaitCursor
        If SERVICIOS.Visible Then
            SERVICIOS.ORDENESBindingSource1.MoveLast()
        Else
            SERVICIOS.Show()
        End If
        SERVICIOS.BringToFront()
        Cursor = Cursors.Default
    End Sub
    Private Sub TRABAJOSDataGridView_Click(sender As Object, e As EventArgs) Handles TRABAJOSDataGridView.Click

    End Sub
    Private Sub GESTIONDataGridView_Click(sender As Object, e As EventArgs) Handles GESTIONDataGridView.Click

    End Sub
    Private Sub BTN_VER_GOOGLE_Click(sender As Object, e As EventArgs) Handles BTN_VER_GOOGLE.Click
        DIRECCION_GEO = DIRECCION_GEST.Text
        If GEO.Visible Then
            GEO.ACTUALIZAR_GEO()
            GEO.BringToFront()
        Else
            GEO.Show(Me)
        End If
    End Sub
    Private Sub IGUAL_DIN_ToolStrip_Click(sender As Object, e As EventArgs) Handles IGUAL_DIN_ToolStrip.Click
        DINAMICA()
        CARGA_ORDENDUPLICADA()
        Dim OBS_ORDEN As String = TXT_OBS.Text
        'CARGA LAS TAREAS
        Dim CANT_TAREAS As Integer
        Dim ORDEN_A_DUPLICAR As Integer = NROORDENINT
        Dim DUP_TAREADESC(20)
        Dim DUP_TAREACANTSTD(20)
        Dim DUP_TAREATIEMPOSTD(20)
        Dim DUP_TAREATIEMPOPREV(20)
        Dim DUP_TAREAUNIDAD(20)

        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow.Id_TRABAJO)
        ORDENESBindingSource.MoveLast()

        'CARGA EL VALOR DE LA ORDEN DUPLICADA EN LA ORDEN QUE FUE DUPLICADA CAMBIANDO EL STATUS A ORDEN DUPLICADA
        NewOBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
        NewOBSERVACIONESRow("NRO_ORDENINT") = ORDENESDataSet.ORDENES.Rows(ORDENESBindingSource.Position).Item("NRO_ORDENINT")
        NewOBSERVACIONESRow("NROORDINAL") = 0
        NewOBSERVACIONESRow("OBSORIGEN") = OBS_ORDEN
        NewOBSERVACIONESRow("OBSCIERRE") = ""
        ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACIONESRow)
        OBESERVACIONESTableAdapter.Update(NewOBSERVACIONESRow)

        TAREASTableAdapter.FillByNROORDENINT(ORDENESDataSet.TAREAS, ORDEN_A_DUPLICAR)
        If ORDENESDataSet.TAREAS.Rows.Count > 0 Then
            CANT_TAREAS = ORDENESDataSet.TAREAS.Rows.Count
            For I = 0 To CANT_TAREAS - 1
                TAREASRow = ORDENESDataSet.TAREAS.Rows(I)
                DUP_TAREADESC(I) = TAREASRow("TAREADESC")
                DUP_TAREACANTSTD(I) = TAREASRow("CANTSTD")
                DUP_TAREATIEMPOSTD(I) = TAREASRow("TIEMPOSTD")
                DUP_TAREATIEMPOPREV(I) = TAREASRow("TIEMPOPREV")
                If IsDBNull(TAREASRow("UNIDAD")) = False Then DUP_TAREAUNIDAD(I) = TAREASRow("UNIDAD")
            Next I
            For X = 0 To CANT_TAREAS - 1
                NewTAREASRow = ORDENESDataSet.TAREAS.NewTAREASRow
                NewTAREASRow("ORDINAL") = 0
                NewTAREASRow("NRO_ORDENINT") = ORDENESDataSet.ORDENES.Rows(ORDENESBindingSource.Position).Item("NRO_ORDENINT")
                NewTAREASRow("TAREADESC") = DUP_TAREADESC(X)
                NewTAREASRow("CANTSTD") = DUP_TAREACANTSTD(X)
                NewTAREASRow("TIEMPOSTD") = DUP_TAREATIEMPOSTD(X)
                NewTAREASRow("TIEMPOPREV") = DUP_TAREATIEMPOPREV(X)
                NewTAREASRow("UNIDAD") = DUP_TAREAUNIDAD(X)

                ORDENESDataSet.TAREAS.AddTAREASRow(NewTAREASRow)
                TAREASTableAdapter.Update(NewTAREASRow)
            Next X
        End If


    End Sub
    Private Sub DINAMICA()
        'SUBRUTINA QUE CARGA UNA ORDEN CON DEPENDENCIA DINAMICA DE OTRA, ES DECIR DEPENDE PERO NO ESTA SUJETA A LA ACCION EL MISMO DIA
        TIEMPO_AGENDA = 0
        TIEMPO_FINAL = 0
        Me.Cursor = Cursors.WaitCursor
        ACCION_ORDEN = "NUEVO"

        CARGAR_DATOSORDENDEPENDIENTE()
        'CARGA LA FECHA DE INICIO DE LA ORDEN DEPENDIENTE DINAMICA
        Dim FECHA_ACARGAR As Date
        Dim FECHA_POSIBLE As Date

        'TOMA EN CONSIDERACION LA FECHA QUE CORRESPONDE PARA EVALUAR LA FECHA DE INICIO DE LA ORDEN A CREAR
        If IsDBNull(DATOS_ORDENESRow("FECHAINICIO")) = False Then
            'SI TIENE CARGADA LA FECHA DE INICIO
            FECHA_ACARGAR = DATOS_ORDENESRow("FECHAINICIO")
        Else
            If DATOS_ORDENESRow.IsFECHAAGENDNull = False Then
                'SI NO ESTA INICIADA PERO SI AGENDADA
                FECHA_ACARGAR = DATOS_ORDENESRow("FECHAAGEND")
            Else
                If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then
                    'SI NO ESTA AGENDADA Y TIENE FECHA DE INICIO ESTIMADO
                    FECHA_ACARGAR = DATOS_ORDENESRow("FECHAINICESTIMADO")
                Else
                    'SI NO TIENE FECHA DE INICIO ESTIMADO
                    MsgBox("La Orden Seleccionada no tiene los datos de fecha necesarios como para ejecutar esta operacion", vbInformation)
                    Exit Sub
                End If
            End If
        End If

        'CALCULA LA FECHA POSIBLE EN BASE A LOS DATOS DE FECHA DE INICIO Y TIEMPO ESTIMADO DE LA ORDEN SELECCIONADA
        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
            'SI LA ORDEN SELECCIONADA TIENE CARGADO EL TOIMEPO ESTIMADO
            If DATOS_ORDENESRow("TESTIMADO") Then
                FECHA_POSIBLE = DateAdd(DateInterval.Day, CInt(DATOS_ORDENESRow("TESTIMADO")), FECHA_ACARGAR)
            Else
                MsgBox("La Orden seleccionada no tiene definido un tiempo estimado, no se puede ejecutar esta operación", vbInformation)
                Exit Sub
            End If

            'VERIFICA QUE LA FECHA DE INICIO NO COINCIDA CON UN SABADO O DOMINGO

            Select Case FECHA_POSIBLE.DayOfWeek
                Case 6 'SABADO
                    ING_FECHAINICEST = DateAdd(DateInterval.Day, 2, FECHA_POSIBLE).Date
                Case 0 'DOMINGO
                    ING_FECHAINICEST = DateAdd(DateInterval.Day, 1, FECHA_POSIBLE).Date
                Case 1, 2, 3, 4, 5
                    ING_FECHAINICEST = FECHA_POSIBLE.Date
            End Select


            'CARGA DATOS DE DEPENDENCIA (DE QUE ORDEN DEPENDE)

            ING_DEPENDENCIA = DATOS_ORDENESRow("NRO_ORDENINT")
            ING_CLASEDEP = "DIN"
            VAR_CLASEDEP = "DIN"

            'DETERMINA EL ORDEN DE LA ORDEN A DEPENDER, SI NO ESTA CARGADO COLOCA UN 0
            If IsDBNull(DATOS_ORDENESRow("ORDENDEP")) = False Then
                ING_ORDENDEP = DATOS_ORDENESRow("ORDENDEP") + 1
            Else
                DATOS_ORDENESRow("ORDENDEP") = 0
                ING_ORDENDEP = DATOS_ORDENESRow("ORDENDEP") + 1
            End If
            VAR_ORDENDP = ING_ORDENDEP
        End If


        'DETERMINA EL TIPO DE DEPENDENCIA (PRI-PRIMERA , INT-INTERMEDIA, ULT-ULTIMA)
        If IsDBNull(DATOS_ORDENESRow("TIPODEP")) = False Then
            Select Case DATOS_ORDENESRow("TIPODEP")
                Case "IND"
                    'ORDEN ACTUAL
                    DATOS_ORDENESRow("TIPODEP") = "IND"
                    DATOS_ORDENESRow("CLASEDEP") = "DIN"
                    'ORDEN A CREAR
                    ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                    ING_TIPODEP = "PRI"
                Case "PRI"
                    Select Case DATOS_ORDENESRow("CLASEDEP")
                        Case "DIN"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PRI"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                            ING_TIPODEP = "ULT"
                        Case "EST"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PAS"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                            ING_TIPODEP = "PRI"
                    End Select

                Case "INT", "ULT"
                    Select Case DATOS_ORDENESRow("CLASEDEP")
                        Case "DIN"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "INT"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("ORDORIGEN")
                            ING_TIPODEP = "ULT"
                        Case "EST"
                            'ORDEN ACTUAL
                            DATOS_ORDENESRow("TIPODEP") = "PAS"
                            'ORDEN A CREAR
                            ING_ORDORIGEN = DATOS_ORDENESRow("NRO_ORDENINT")
                            ING_TIPODEP = "PRI"
                    End Select
            End Select
        Else

        End If

        VAR_TIPODEP = ING_TIPODEP
        ORDEN_TIEMPORESTANTE = CAPACIDAD_DIA

        'ACTUALIZA LOS DATOS DE DEPENDENCIA DE LA ORDEN SELECCIONADA
        ORDENESTableAdapter.Update(DATOS_ORDENESRow)
    End Sub
    Private Sub CARGA_ORDENDUPLICADA()
        NewORDENRow = ORDENESDataSet.ORDENES.NewORDENESRow
        NewORDENRow("NRO_ORDINAL") = 0
        NEWORDENRow("ID_GESTION") = DATOS_ORDENESRow.ID_GESTION
        NEWORDENRow("ID_TRABAJO") = DATOS_ORDENESRow.ID_TRABAJO
        NEWORDENRow("TIPO") = DATOS_ORDENESRow.TIPO
        NEWORDENRow("SECTOROPE") = DATOS_ORDENESRow.SECTOROPE
        NEWORDENRow("SECTORDESTINO") = DATOS_ORDENESRow.SECTORDESTINO
        Select Case SECTOR
            Case "PLANIFICACION TECNICA", "GERENCIA"
                NEWORDENRow("SECTORGEN") = "PT"
            Case "SUPERVISION", "JEFATURA"
                NEWORDENRow("SECTORGEN") = "SU"
            Case "DESPACHO"
                NEWORDENRow("SECTORGEN") = "CO"
            Case Else
                NEWORDENRow("SECTORGEN") = "SC"
        End Select
        NEWORDENRow("RECURSO") = DATOS_ORDENESRow.RECURSO
        NEWORDENRow("FECHASOL") = DATOS_ORDENESRow.FECHASOL
        NEWORDENRow("ATRIBUTO") = DATOS_ORDENESRow.ATRIBUTO
        NEWORDENRow("PRIORIDAD") = DATOS_ORDENESRow.PRIORIDAD

        NEWORDENRow("NODO") = DATOS_ORDENESRow.NODO
        NEWORDENRow("ID_CALLE") = DATOS_ORDENESRow.ID_CALLE
        NEWORDENRow("ZONA") = DATOS_ORDENESRow.ZONA
        NEWORDENRow("CALLE") = DATOS_ORDENESRow.CALLE
        NEWORDENRow("NRO") = DATOS_ORDENESRow.NRO
        NEWORDENRow("MANZANA") = DATOS_ORDENESRow.MANZANA
        If DATOS_ORDENESRow.IsSOLICITANTENull = False Then NEWORDENRow("SOLICITANTE") = DATOS_ORDENESRow.SOLICITANTE
        NEWORDENRow("CUADRILLA") = "SIN ASIGNAR"
        NEWORDENRow("DEPENDENCIA") = NROORDENINT
        NEWORDENRow("TIPODEP") = ING_TIPODEP
        NEWORDENRow("CLASEDEP") = DATOS_ORDENESRow.CLASEDEP
        NEWORDENRow("ORDENDEP") = VAR_ORDENDP
        NEWORDENRow("CANTIDAD_SERVICIOS") = 0
        NEWORDENRow("MOTIVOORIGEN") = DATOS_ORDENESRow.MOTIVOORIGEN
        NEWORDENRow("CAUSARIGEN") = DATOS_ORDENESRow.CAUSARIGEN
        NEWORDENRow("ORDORIGEN") = DATOS_ORDENESRow.ORDORIGEN
        NEWORDENRow("INSTALACION") = DATOS_ORDENESRow.INSTALACION
        If DATOS_ORDENESRow.IsINSTALACIONRUSNull = False Then NEWORDENRow("INSTALACIONRUS") = DATOS_ORDENESRow.INSTALACIONRUS
        NEWORDENRow("CARPETA") = DATOS_ORDENESRow.CARPETA
        NEWORDENRow("TPREVISTO") = DATOS_ORDENESRow.TPREVISTO
        NEWORDENRow("TESTIMADO") = DATOS_ORDENESRow.TESTIMADO
        NEWORDENRow("FECHAINICESTIMADO") = DATOS_ORDENESRow.FECHAINICESTIMADO
        If DATOS_ORDENESRow.IsDUPLICADADENull = False Then NEWORDENRow("DUPLICADADE") = DATOS_ORDENESRow.DUPLICADADE
        NEWORDENRow("AFECTACION") = DATOS_ORDENESRow.AFECTACION
        NEWORDENRow("FECHAINGRESO") = Now.ToShortDateString
        NEWORDENRow("GENERADOR") = FULLNOMBRE
        NEWORDENRow("STATUS") = "INGRESADOINT"
        If DATOS_ORDENESRow.IsPROYECTO_ORDINALNull = False Then NEWORDENRow.PROYECTO_ORDINAL = DATOS_ORDENESRow.PROYECTO_ORDINAL
        If DATOS_ORDENESRow.IsGEST_SOLICITADONull = False Then NEWORDENRow.GEST_SOLICITADO = DATOS_ORDENESRow.GEST_SOLICITADO

        ORDENESDataSet.ORDENES.AddORDENESRow(NEWORDENRow)
        ORDENESTableAdapter.Update(NEWORDENRow)


    End Sub
End Class


'Private Sub TRAB_GRAFICAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles TRAB_GRAFICAR_ToolStrip.Click
'    Dim POS_ORD As Integer = 1
'    'OBTIENE LOS DATOS DEL TRABAJO SELECCIONADO
'    GRAF_FECHAINIGRAFICO = DATOS_TRABAJORow("FECHAINGRESADO")
'    GRAF_CLASE(1) = "TRABAJO"
'    'CARGA DATOS BASICOS DEL TRABAJO
'    GRAF_NROGESTION(1) = DATOS_TRABAJORow("ID_GESTION")  'CARGA EN ESTE CAMPO EL NUMERO DE GESTION
'    GRAF_NROTRABAJO(1) = DATOS_TRABAJORow("Id_TRABAJO") 'CARGA EN ESTE CAMPO EL NUMERO DE TRABAJO
'    GRAF_NROORDEN(1) = 0
'    GRAF_NROORDINAL(1) = 0
'    GRAF_MOTIVO(1) = DATOS_TRABAJORow("TIPOTRABAJO")
'    GRAF_MANZANA(1) = DATOS_TRABAJORow("MANZANA")

'    GRAF_NODOTRAB(1) = DATOS_TRABAJORow("NODO")
'    GRAF_ZONATRAB(1) = DATOS_TRABAJORow("ZONA")

'    GRAF_CALLE(1) = DATOS_TRABAJORow("CALLE")
'    If IsDBNull(DATOS_TRABAJORow("NRO")) = False Then
'        If DATOS_TRABAJORow("NRO") <> "" Then GRAF_NRO(1) = DATOS_TRABAJORow("NRO")
'    End If
'    'CARGA DATOS DE PROGRAMACION DEL TRABAJO SELECCIONADO
'    GRAF_FECHAINIESTIMADO(1) = DATOS_TRABAJORow("FECHAINICESTIMADO")
'    GRAF_TIEMPOESTIMADO(1) = DATOS_TRABAJORow("TIEMPOESTIMADO")
'    GRAF_FECHAFINESTIMADO(1) = DateAdd(DateInterval.Day, DATOS_TRABAJORow("TIEMPOESTIMADO"), (DATOS_TRABAJORow("FECHAINICESTIMADO")))

'    GRAF_STATUS(1) = DATOS_TRABAJORow("STATUS")
'    GRAF_FECHAINGRESO(POS_ORD) = DATOS_TRABAJORow("FECHAINGRESADO")
'    Select Case DATOS_TRABAJORow("STATUS")

'        Case "INICIADO"
'            GRAF_FECHAINICIO(1) = DATOS_TRABAJORow("FECHAINICIADO")
'        Case "COORDINADO"
'            GRAF_FECHAAGENDADO(1) = DATOS_TRABAJORow("FECHAINICESTIMADO")
'        Case "FINALIZADO"
'            GRAF_FECHAINICIO(1) = DATOS_TRABAJORow("FECHAINICIADO")
'            GRAF_FECHAFINALIZADO(1) = DATOS_TRABAJORow("FECHAFINALIZADO")
'        Case "DEMORADO"
'            'GRAF_FECHAFINESTIMADO(1) = Now.ToShortDateString
'    End Select

'    'RECORRE LAS ORDENES QUE ESTAN RELACIONADAS CON EL TRABAJO
'    ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
'    If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
'        'BUSCA LAS ORDENES COMPRENDIDAS DENTRO DEL TRABAJO SELECCIONADO2
'        For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
'            POS_ORD += 1
'            DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows(X)

'            'OBTIENE LOS DATOS DE LA ORDEN SELECCIONADA
'            GRAF_CLASE(POS_ORD) = "ORDEN"
'            GRAF_CLASEDEP(POS_ORD) = DATOS_ORDENESRow("CLASEDEP")
'            'CARGA DATOS BASICOS DEL TRABAJO
'            GRAF_NROGESTION(POS_ORD) = DATOS_ORDENESRow("ID_GESTION")  'CARGA EN ESTE CAMPO EL NUMERO DE GESTION
'            GRAF_NROTRABAJO(POS_ORD) = DATOS_ORDENESRow("Id_TRABAJO") 'CARGA EN ESTE CAMPO EL NUMERO DE TRABAJO
'            GRAF_NROORDEN(POS_ORD) = DATOS_ORDENESRow("NRO_ORDENINT")
'            GRAF_NROORDINAL(POS_ORD) = DATOS_ORDENESRow("NRO_ORDINAL")
'            GRAF_MOTIVO(POS_ORD) = DATOS_ORDENESRow("MOTIVOORIGEN")
'            GRAF_CAUSA(POS_ORD) = DATOS_ORDENESRow("CAUSARIGEN")
'            GRAF_NODOTRAB(POS_ORD) = DATOS_ORDENESRow("NODO")
'            GRAF_ZONATRAB(POS_ORD) = DATOS_ORDENESRow("ZONA")

'            'CARGA LAS DIRECCIONES TENIENDO EN CUENTA LA FALTA DE ALGUN DATO
'            If IsDBNull(DATOS_ORDENESRow("MANZANA")) = False Then GRAF_MANZANA(POS_ORD) = DATOS_ORDENESRow("MANZANA")
'            If IsDBNull(DATOS_ORDENESRow("CALLE")) = False Then GRAF_CALLE(POS_ORD) = DATOS_ORDENESRow("CALLE")
'            If IsDBNull(DATOS_ORDENESRow("NRO")) = False Then If DATOS_ORDENESRow("NRO") <> "" Then GRAF_NRO(POS_ORD) = DATOS_ORDENESRow("NRO")

'            'CARGA LAS FECHAS CORRESPONDIENTES DE ACUERDO AL STATUS Y A LA PRESENCIA O NO DE ELLAS
'            GRAF_STATUS(POS_ORD) = DATOS_ORDENESRow("STATUS")
'            'LA FECHA DE INGRESO SIEMPRE ESTA POR LO QUE NO DEPENDE DEL ESTADO
'            GRAF_FECHAINGRESO(POS_ORD) = DATOS_ORDENESRow("FECHAINGRESO")
'            Select Case DATOS_ORDENESRow("STATUS")
'                Case "INGORDINAL", "INGRESADOINT", "ASIGNADO"
'                    'SI NO TIENE CARGADA LA FECHA DE INICIO ESTIMADO TOMA LA MISMA COMO LA DE HOY
'                    If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICESTIMADO") Else GRAF_FECHAINIESTIMADO(POS_ORD) = Now.ToShortDateString
'                    'SI NO TIENE CARGADO EL TIEMPO ESTIMADO, LO ESTIMA EN UN DIA
'                    If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                        If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                        End If
'                    Else
'                        GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                    End If
'                    GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                Case "COORDINADO", "AGENDADO", "RUTEADO"
'                    GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAAGEND")
'                    GRAF_FECHAAGENDADO(POS_ORD) = DATOS_ORDENESRow("FECHAAGEND")
'                    If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                        If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                        End If
'                    Else
'                        GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                    End If
'                    GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                Case "INICIADO"
'                    GRAF_FECHAINICIO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                    GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                    If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                        If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                        End If
'                    Else
'                        GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                    End If
'                    GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))

'                Case "FINALIZADO"
'                    GRAF_FECHAINICIO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                    GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                    If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                        If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                        End If
'                    Else
'                        GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                    End If
'                    GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                    GRAF_FECHAFINALIZADO(POS_ORD) = DATOS_ORDENESRow("FECHAFIN")

'                Case "DEMORADO"
'                    'SI NO TIENE CARGADA LA FECHA DE INICIO ESTIMADO TOMA LA MISMA COMO LA DE HOY
'                    If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICESTIMADO") Else GRAF_FECHAINIESTIMADO(POS_ORD) = Now.ToShortDateString
'                    'SI NO TIENE CARGADO EL TIEMPO ESTIMADO, LO ESTIMA EN UN DIA
'                    If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                        If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                        End If
'                    Else
'                        GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                    End If
'                    GRAF_FECHAFINESTIMADO(POS_ORD) = Now.ToShortDateString

'                Case "CANCELADO", "ADUPLICAR", "DUPLICADO"
'                    POS_ORD -= 1
'            End Select
'        Next X
'    End If
'    GRAF_CANTIDADFILAS = POS_ORD
'    GRAF_GESTION.Show(Me)
'End Sub
'Private Sub GEST_GRAFICAR_ToolStrip_Click(sender As Object, e As EventArgs) Handles GEST_GRAFICAR_ToolStrip.Click
'    Dim POS_ORD As Integer = 0

'    Cursor = Cursors.WaitCursor

'    'OBTIENE LOS DATOS DE LA GESTION SELECCIONADA
'    POS_ORD += 1
'    GRAF_FECHAINIGRAFICO = DATOS_GESTIONRow("FECHAINGRESADA")
'    GRAF_CLASE(POS_ORD) = "GESTION"
'    GRAF_NROGESTION(POS_ORD) = DATOS_GESTIONRow("ID_GESTION")  'CARGA EN ESTE CAMPO EL NUMERO DE GESTION
'    GRAF_NROTRABAJO(POS_ORD) = 0
'    GRAF_NROORDEN(POS_ORD) = 0
'    GRAF_NROORDINAL(POS_ORD) = 0

'    GRAF_MOTIVO(POS_ORD) = DATOS_GESTIONRow("TIPOgestion")
'    If IsDBNull(DATOS_GESTIONRow("MANZANA")) = False Then GRAF_MANZANA(POS_ORD) = DATOS_GESTIONRow("MANZANA")
'    GRAF_CALLE(POS_ORD) = DATOS_GESTIONRow("CALLE")
'    If IsDBNull(DATOS_GESTIONRow("NUMERO")) = False Then
'        If DATOS_GESTIONRow("NUMERO") <> "" Then GRAF_NRO(POS_ORD) = DATOS_GESTIONRow("NUMERO")
'    End If
'    'CARGA DATOS DE PROGRAMACION DE LA GESTION SELECCIONADA
'    GRAF_FECHAINGRESO(POS_ORD) = DATOS_GESTIONRow("FECHAINGRESADA")
'    GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_GESTIONRow("FECHAINICESTIMADA")
'    GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_GESTIONRow("TIEMPOEST")
'    GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, DATOS_GESTIONRow("TIEMPOEST"), (DATOS_GESTIONRow("FECHAINICESTIMADA")))

'    GRAF_STATUS(POS_ORD) = DATOS_GESTIONRow("STATUS")
'    Select Case DATOS_GESTIONRow("STATUS")
'        Case "INICIADO"
'            GRAF_FECHAINICIO(POS_ORD) = DATOS_GESTIONRow("FECHAINICIADA")
'        Case "COORDINADO"
'            GRAF_FECHAAGENDADO(POS_ORD) = DATOS_GESTIONRow("FECHAINICESTIMADA")
'        Case "FINALIZADO"
'            GRAF_FECHAINICIO(POS_ORD) = DATOS_GESTIONRow("FECHAINICIADA")
'            GRAF_FECHAFINALIZADO(POS_ORD) = DATOS_GESTIONRow("FECHAFINALIZADA")
'        Case "DEMORADO"
'            'GRAF_FECHAFINESTIMADO(POS_ORD) = Now.ToShortDateString
'    End Select


'    For I = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
'        DATOS_TRABAJORow = ORDENESDataSet.TRABAJOS.Rows(I)
'        POS_ORD += 1
'        'OBTIENE LOS DATOS DEL TRABAJO SELECCIONADO
'        GRAF_CLASE(POS_ORD) = "TRABAJO"
'        'CARGA DATOS BASICOS DEL TRABAJO
'        GRAF_NROGESTION(POS_ORD) = DATOS_TRABAJORow("ID_GESTION")  'CARGA EN ESTE CAMPO EL NUMERO DE GESTION
'        GRAF_NROTRABAJO(POS_ORD) = DATOS_TRABAJORow("Id_TRABAJO") 'CARGA EN ESTE CAMPO EL NUMERO DE TRABAJO
'        GRAF_NROORDEN(POS_ORD) = 0
'        GRAF_NROORDINAL(POS_ORD) = 0
'        GRAF_MOTIVO(POS_ORD) = DATOS_TRABAJORow("TIPOTRABAJO")
'        GRAF_NODOTRAB(POS_ORD) = DATOS_TRABAJORow("NODO")
'        GRAF_ZONATRAB(POS_ORD) = DATOS_TRABAJORow("ZONA")

'        If IsDBNull(DATOS_TRABAJORow("MANZANA")) = False Then GRAF_MANZANA(POS_ORD) = DATOS_TRABAJORow("MANZANA")
'        GRAF_CALLE(POS_ORD) = DATOS_TRABAJORow("CALLE")
'        If IsDBNull(DATOS_TRABAJORow("NRO")) = False Then If DATOS_TRABAJORow("NRO") <> "" Then GRAF_NRO(POS_ORD) = DATOS_TRABAJORow("NRO")

'        'CARGA DATOS DE PROGRAMACION DEL TRABAJO SELECCIONADO
'        GRAF_FECHAINGRESO(POS_ORD) = DATOS_TRABAJORow("FECHAINGRESADO")
'        GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_TRABAJORow("FECHAINICESTIMADO")
'        GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_TRABAJORow("TIEMPOESTIMADO")
'        GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, DATOS_TRABAJORow("TIEMPOESTIMADO"), (DATOS_TRABAJORow("FECHAINICESTIMADO")))

'        GRAF_STATUS(POS_ORD) = DATOS_TRABAJORow("STATUS")

'        Select Case DATOS_TRABAJORow("STATUS")
'            Case "INICIADO"
'                GRAF_FECHAINICIO(POS_ORD) = DATOS_TRABAJORow("FECHAINICIADO")
'            Case "COORDINADO", "AGENDADO", "RUTEADO"
'                GRAF_FECHAAGENDADO(POS_ORD) = DATOS_TRABAJORow("FECHAINICESTIMADO")
'            Case "FINALIZADO"
'                GRAF_FECHAINICIO(POS_ORD) = DATOS_TRABAJORow("FECHAINICIADO")
'                GRAF_FECHAFINALIZADO(POS_ORD) = DATOS_TRABAJORow("FECHAFINALIZADO")
'            Case "DEMORADO"
'                'GRAF_FECHAFINESTIMADO(POS_ORD) = Now.ToShortDateString
'        End Select

'        'RECORRE LAS ORDENES QUE ESTAN RELACIONADAS CON EL TRABAJO
'        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DATOS_TRABAJORow("ID_TRABAJO"))
'        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
'            'BUSCA LAS ORDENES COMPRENDIDAS DENTRO DEL TRABAJO SELECCIONADO2
'            For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
'                POS_ORD += 1
'                DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows(X)

'                'OBTIENE LOS DATOS DE LA ORDEN SELECCIONADA
'                GRAF_CLASE(POS_ORD) = "ORDEN"
'                If IsDBNull(DATOS_ORDENESRow("CLASEDEP")) = False Then GRAF_CLASEDEP(POS_ORD) = DATOS_ORDENESRow("CLASEDEP") Else GRAF_CLASEDEP(POS_ORD) = ""
'                'CARGA DATOS BASICOS DEL TRABAJO
'                GRAF_NROGESTION(POS_ORD) = DATOS_ORDENESRow("ID_GESTION")  'CARGA EN ESTE CAMPO EL NUMERO DE GESTION
'                GRAF_NROTRABAJO(POS_ORD) = DATOS_ORDENESRow("Id_TRABAJO") 'CARGA EN ESTE CAMPO EL NUMERO DE TRABAJO
'                GRAF_NROORDEN(POS_ORD) = DATOS_ORDENESRow("NRO_ORDENINT")
'                GRAF_NROORDINAL(POS_ORD) = DATOS_ORDENESRow("NRO_ORDINAL")
'                GRAF_MOTIVO(POS_ORD) = DATOS_ORDENESRow("MOTIVOORIGEN")
'                GRAF_CAUSA(POS_ORD) = DATOS_ORDENESRow("CAUSARIGEN")
'                GRAF_NODOTRAB(POS_ORD) = DATOS_ORDENESRow("NODO")
'                GRAF_ZONATRAB(POS_ORD) = DATOS_ORDENESRow("ZONA")

'                'CARGA LAS DIRECCIONES TENIENDO EN CUENTA LA FALTA DE ALGUN DATO
'                If IsDBNull(DATOS_ORDENESRow("MANZANA")) = False Then GRAF_MANZANA(POS_ORD) = DATOS_ORDENESRow("MANZANA")
'                If IsDBNull(DATOS_ORDENESRow("CALLE")) = False Then GRAF_CALLE(POS_ORD) = DATOS_ORDENESRow("CALLE")
'                If IsDBNull(DATOS_ORDENESRow("NRO")) = False Then If DATOS_ORDENESRow("NRO") <> "" Then GRAF_NRO(POS_ORD) = DATOS_ORDENESRow("NRO")

'                'CARGA LAS FECHAS CORRESPONDIENTES DE ACUERDO AL STATUS Y A LA PRESENCIA O NO DE ELLAS
'                GRAF_STATUS(POS_ORD) = DATOS_ORDENESRow("STATUS")
'                'LA FECHA DE INGRESO SIEMPRE ESTA POR LO QUE NO DEPENDE DEL ESTADO
'                GRAF_FECHAINGRESO(POS_ORD) = DATOS_ORDENESRow("FECHAINGRESO")
'                Select Case DATOS_ORDENESRow("STATUS")
'                    Case "INGORDINAL", "INGRESADOINT", "ASIGNADO"
'                        'SI NO TIENE CARGADA LA FECHA DE INICIO ESTIMADO TOMA LA MISMA COMO LA DE HOY
'                        If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICESTIMADO") Else GRAF_FECHAINIESTIMADO(POS_ORD) = Now.ToShortDateString
'                        'SI NO TIENE CARGADO EL TIEMPO ESTIMADO, LO ESTIMA EN UN DIA
'                        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                            If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                            Else
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                            End If
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        End If
'                        GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                    Case "COORDINADO", "AGENDADO", "RUTEADO"
'                        GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAAGEND")
'                        GRAF_FECHAAGENDADO(POS_ORD) = DATOS_ORDENESRow("FECHAAGEND")
'                        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                            If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                            Else
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                            End If
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        End If
'                        GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                    Case "INICIADO"
'                        GRAF_FECHAINICIO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                        GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                            If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                            Else
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                            End If
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        End If
'                        GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))

'                    Case "FINALIZADO"
'                        GRAF_FECHAINICIO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                        GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICIO")
'                        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                            If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                            Else
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                            End If
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        End If
'                        GRAF_FECHAFINESTIMADO(POS_ORD) = DateAdd(DateInterval.Day, GRAF_TIEMPOESTIMADO(POS_ORD), GRAF_FECHAINIESTIMADO(POS_ORD))
'                        GRAF_FECHAFINALIZADO(POS_ORD) = DATOS_ORDENESRow("FECHAFIN")

'                    Case "DEMORADO"
'                        'SI NO TIENE CARGADA LA FECHA DE INICIO ESTIMADO TOMA LA MISMA COMO LA DE HOY
'                        If IsDBNull(DATOS_ORDENESRow("FECHAINICESTIMADO")) = False Then GRAF_FECHAINIESTIMADO(POS_ORD) = DATOS_ORDENESRow("FECHAINICESTIMADO") Else GRAF_FECHAINIESTIMADO(POS_ORD) = Now.ToShortDateString
'                        'SI NO TIENE CARGADO EL TIEMPO ESTIMADO, LO ESTIMA EN UN DIA
'                        If IsDBNull(DATOS_ORDENESRow("TESTIMADO")) = False Then
'                            If DATOS_ORDENESRow("TESTIMADO") = 0 Then
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                            Else
'                                GRAF_TIEMPOESTIMADO(POS_ORD) = DATOS_ORDENESRow("TESTIMADO")
'                            End If
'                        Else
'                            GRAF_TIEMPOESTIMADO(POS_ORD) = 1
'                        End If
'                        GRAF_FECHAFINESTIMADO(POS_ORD) = Now.ToShortDateString

'                    Case "CANCELADO", "ADUPLICAR", "DUPLICADO"
'                        POS_ORD -= POS_ORD
'                End Select
'            Next X
'        End If
'    Next I
'    GRAF_CANTIDADFILAS = POS_ORD

'    GRAF_GESTION.Show(Me)
'    Cursor = DefaultCursor
'End Sub


