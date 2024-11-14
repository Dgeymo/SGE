Imports System.ComponentModel

Public Class PROCESOS
    Dim CONTADOR As Integer
    Dim MENSAJE_GEST(100) As String
    Dim MENSAJE_DUPLI(100) As String

    Dim MENSAJESOLD As DataRow
    Dim MENSAJESOLDNew As ORDENESDataSet.MENSAJERIA_OLDRow
    Dim TIPO_MENSAJE As String
    Dim TOTAL_CAMBIOS As Integer
    Dim TOTAL_DUPLI As Integer
    Dim TOTAL_MJE As String
    Dim HIS_STATUSANT As String
    Dim HIS_STATUSACTUAL As String
    Dim HIS_CAUSA As String
    Dim HIS_DETALLE As String
    Dim MJE_ASUNTO As String
    Dim MJE_DESTINONOMBRE As String
    Dim MJE_DESTINOSECTOR As String
    Dim MJE_MENSAJE As String
    Dim MJE_NROORDENASOC As String

    Dim GESTIONRow As ORDENESDataSet.GESTIONRow
    Dim TRABAJOSRow As ORDENESDataSet.TRABAJOSRow
    Dim ORDENESRow As ORDENESDataSet.ORDENESRow
    Dim EdificiosRow As DataRow
    Dim TECNICO_ROW As INFORME_INDICEDataSet.TecnicosRow
    Dim FECHALIMITE As Date

    Dim NEWSERVICIORow As ORDENESDataSet.INFORME_SERVICIOSRow
    Dim NewHISTORICORow As ORDENESDataSet.HISTORICORow
    Dim NewMENSAJE As ORDENESDataSet.MENSAJERIARow
    Dim BASECALCULORow As INFORME_INDICEDataSet.BaseCalculoRow

    Dim SERVICIO As ORDENESDataSet.ORDENESRow
    Dim HISTORICO As ORDENESDataSet.HISTORICORow
    Dim HISTORICO_1 As ORDENESDataSet.HISTORICORow
    'INDICES

    Public INFORMERow As INFORME_INDICEDataSet.InformesRow
    Dim TABLAWEBRow As INFORME_INDICEDataSet.TablaWEBRow
    Dim REPOIndiceROW As INFORME_INDICEDataSet.RepoIndicesRow
    Dim newRecPermRow As INFORME_INDICEDataSet.BasePermisoresRow

    Public ULTIMO_INDICE As Integer
    Dim ORDEN_INT As Integer = 0
    Dim VALUE As Integer = 1

    Private Sub PROCESOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.OBESERVACIONES' Puede moverla o quitarla según sea necesario.
        '   Me.OBESERVACIONESTableAdapter.Fill(Me.ORDENESDataSet.OBESERVACIONES)
        'INDICES_INCIAL()
        'FECHALIMITE = DateAdd(DateInterval.Day, -30, Now)
        'Me.Refresh()
        'TecnicosTableAdapter.Fill(INFORME_INDICEDataSet.Tecnicos)
        'BaseCalculoTableAdapter.Fill(INFORME_INDICEDataSet.BaseCalculo)
        'BaseIndicesTableAdapter.Fill(INFORME_INDICEDataSet.BaseIndices)
        DT_SERVICIO_INICIO.Value = Today.AddMonths(-1)
        DT_SERVICIO_FIN.Value = Today

        If SECTOR = "PLANIFICACION TECNICA" Or SECTOR = "GERENCIA" Then
            BTN_PROCESO.Visible = True
        Else
            BTN_PROCESO.Visible = False
        End If
        If THEME_BLACK = False Then
            BackColor = Color.White
            CK_INICIAR_TRABAJOS.ForeColor = Color.Black
            CK_MARCA_DUPLICAR.ForeColor = Color.Black
            CK_INICIA_GESTION.ForeColor = Color.Black
            CK_FINALIZA_TRABAJO.ForeColor = Color.Black
            CK_FINALIZA_GESTION.ForeColor = Color.Black
            CK_REQUERIDOS.ForeColor = Color.Black
            CK_LIMPIEZA_MENSAJES.ForeColor = Color.Black
            LBL_DESDE_SERVICIOS.ForeColor = Color.Black
            LBL_HASTA_SERVICIOS.ForeColor = Color.Black
            CK_SERVICIOS.ForeColor = Color.Black
            CK_DISENO_OC.ForeColor = Color.Black
            CK_DISENO_RED.ForeColor = Color.Black
            CK_ACT_PLANOS.ForeColor = Color.Black
        End If


    End Sub
    'Public Sub INDICES_INCIAL()
    '    InformesTableAdapter.Fill(INFORME_INDICEDataSet.Informes)
    '    For X = 0 To INFORME_INDICEDataSet.Informes.Rows.Count - 1
    '        CB_INFORMES.Items.Add(INFORME_INDICEDataSet.Informes.Rows(X).Item("NombreInforme"))
    '        If X = INFORME_INDICEDataSet.Informes.Rows.Count - 1 Then
    '            CB_INFORMES.Text = INFORME_INDICEDataSet.Informes.Rows(X).Item("NombreInforme")
    '        End If
    '    Next
    '    ULTIMO_INDICE = InformesTableAdapter.ULTIMO_REGISTRO().Value
    '    InformesTableAdapter.FillByID(INFORME_INDICEDataSet.Informes, ULTIMO_INDICE)

    '    INFORMERow = INFORME_INDICEDataSet.Informes.Rows(0)

    '    LBL_INFORME_TITULO.Text = "ULTIMO INFORME CREADO: " & ULTIMO_INDICE & " - " & INFORMERow("MesNombre") & "  " & INFORMERow("Año")
    'End Sub
    Private Sub BTN_CREAR_Click(sender As Object, e As EventArgs) Handles BTN_CREAR.Click
        NUEVO_INDICE.Show(Me)
        BTN_CREAR.Enabled = False
        NUEVO_INDICE.lbl_mes.Visible = True
        NUEVO_INDICE.lbl_año.Visible = True
        NUEVO_INDICE.CB_ANIO.Visible = True
        NUEVO_INDICE.CB_FECHA.Visible = True
    End Sub
    Private Sub INICIA_TRABAJOS()
        For I = 1 To 100
            MENSAJE_GEST(I) = ""
        Next
        TOTAL_CAMBIOS = 0
        'BUSCA TRABAJOS INGRESADOS Y AGENDADOS
        TRABAJOSTableAdapter.FillByAINICIAR(ORDENESDataSet.TRABAJOS)

        'VERIFICA QUE EXISTAN TRABAJOS A VERIFICAR
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then

            'RECORRE LOS TRABAJOS RELACIONADOS CON LA GESTION
            For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                'ACTUALIZA BARRA DE TRABAJOS Y ESTABLECE FILA DE TRABAJOS

                TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)
                'POR CADA TRABAJO BUSCA LAS ORDENES RELACIONADAS FINALIZADAS
                ORDENESTableAdapter.FillByORDEN_ACTIVA(ORDENESDataSet.ORDENES, TRABAJOSRow("Id_TRABAJO"))
                PROGRESS_BAR("ANALIZANDO TRABAJOS A INICIAR", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, 0, 0)
                'VERIFICA QUE EXISTAN ORDENES FINALIZADAS PARA EL TRABAJO SELECCIONADO
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                    PROGRESS_BAR("ANALIZANDO TRABAJOS A INICIAR", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, 1, 1)
                    'CUENTA EL CAMBIO
                    TOTAL_CAMBIOS = TOTAL_CAMBIOS + 1
                    ORDENESRow = ORDENESDataSet.ORDENES.Rows(0)
                    NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
                    NewHISTORICORow("ID_GESTION") = TRABAJOSRow("ID_GESTION")
                    NewHISTORICORow("ID_TRABAJO") = TRABAJOSRow("Id_TRABAJO")
                    NewHISTORICORow("ID_ORDENINT") = 0
                    NewHISTORICORow("FECHA") = Now

                    Select Case ORDENESRow.STATUS
                        Case "COORDINADO"
                            TRABAJOSRow("STATUS") = "COORDINADO"
                            TRABAJOSRow.FECHAINICESTIMADO = ORDENESRow.FECHAINICESTIMADO
                            NewHISTORICORow("STATUSACTUAL") = "COORDINADO"
                        Case "FINALIZADO", "ADUPLICAR", "INICIADO"
                            TRABAJOSRow("STATUS") = "INICIADO"
                            TRABAJOSRow("FECHAINICIADO") = ORDENESRow("FECHAINICIO")
                            NewHISTORICORow("STATUSACTUAL") = "INICIADO"
                        Case "DEMORADO"
                            TRABAJOSRow("STATUS") = "DEMORADO"
                            NewHISTORICORow("STATUSACTUAL") = "DEMORADO"

                    End Select
                    TRABAJOSTableAdapter.Update(TRABAJOSRow)

                    'CARGA EL HISTORICO DEL TRABAJO PROCESADO
                    'CARGA HISTORICO
                    NewHISTORICORow("STATUSANTERIOR") = "INGRESADO"
                    NewHISTORICORow("CAUSA") = "ORDEN RELACIONADA FINALIZADA"
                    NewHISTORICORow("DETALLE") = "PROCESO AUTOMATICO"
                    NewHISTORICORow("EJECUTANTE") = FULLNOMBRE
                    'GUARDA EL HISTORICO PROCESADO
                    ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)
                    Me.HISTORICOTableAdapter.Update(NewHISTORICORow)
                    MENSAJE_GEST(TOTAL_CAMBIOS) = "TRABAJO NRO: " & TRABAJOSRow("Id_TRABAJO") & ",  NODO: " & TRABAJOSRow("NODO") & ",  ZONA: " &
                                TRABAJOSRow("ZONA") & vbNewLine & ",  CORRESPONDIENTE A LA GESTION NRO " & TRABAJOSRow("ID_GESTION") & ",  AREA: " &
                                TRABAJOSRow("AREA") & ",  DIRECCION: " & TRABAJOSRow("CALLE") & " " & TRABAJOSRow("NRO") & vbNewLine
                End If
            Next
        End If

        'ARMA MENSAJE A QUIEN EJECUTO EL PROCESO
        TOTAL_MJE = ""
        For X = 1 To TOTAL_CAMBIOS
            TOTAL_MJE = TOTAL_MJE & MENSAJE_GEST(X) & vbNewLine
        Next X

        If TOTAL_CAMBIOS > 0 Then
            'ENVIA MENSAJE A RESPONSABLE GESTION
            MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "En el proceso se han iniciado los siguientes trabajos " & vbNewLine & TOTAL_MJE & vbNewLine
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        Else
            'ENVIA MENSAJE A RESPOSABLE GESTION
            MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "No se han encontrado ORDENES finalizadas en TRABAJOS analizados"
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        End If
        CK_INICIAR_TRABAJOS.ForeColor = Color.Green
        CK_INICIAR_TRABAJOS.Refresh()
    End Sub
    Private Sub MARCA_ADUPLICAR()
        'ACTUALIZA FINALIZACION DE TRABAJOS
        Dim CANT_ORDENES As Integer
        Dim CANT_FINALIZADAS As Integer

        'INICIALIZA VARIABLES
        For I = 1 To 100
            MENSAJE_GEST(I) = ""
            MENSAJE_DUPLI(I) = ""
        Next

        'CARGA LOS TRABAJOS EN STATUS INICIADO O DEMORADO 
        '  TRABAJOSTableAdapter.FillByAFINALIZAR(ORDENESDataSet.TRABAJOS)
        '   CARGAMOS LA CONSULTADE ORDENES EN STATUS - FINALIZADO Y CON FALLA CIERRE - NO REALIZADO o PARCIALMENTE REALIZADO

        ORDENESTableAdapter.FillByNOFINPARCIAL(ORDENESDataSet.ORDENES)


        'CONTROLA QUE HAYA TRABAJOS SIN FINALIZAR
        '  If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        'RECORRE LA TABLA DE TRABAJOS
        'For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1

        '    TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)

        '    HIS_STATUSANT = TRABAJOSRow("STATUS")

        'BUSCA LAS ORDENES DENTRO DEL TRABAJO SELECCIONADO
        'ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJOSRow("Id_TRABAJO"))
        CANT_ORDENES = ORDENESDataSet.ORDENES.Rows.Count
        CANT_FINALIZADAS = 0

        'VERIFICA QUE HAYA ORDENES DENTRO DEL TRABAJO
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            'ORDENESBindingSource.MoveFirst()
            'RECORRE LAS ORDENES DEFINIDAS DENTRO DEL TRABAJO
            For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                ORDENESRow = ORDENESDataSet.ORDENES.Rows(I)
                PROGRESS_BAR("ANALIZANDO ORDENES A DUPLICAR", 0, 0, 0, 0, ORDENESDataSet.ORDENES.Rows.Count, I + 1)

                'CUENTA LAS ORDENES EN STATUS FINALIZADO Y LAS QUE NO FIGURAN COMO REALIZADO LAS MANDA A DUPLICAR
                'Select Case ORDENESRow("STATUS")
                '    Case "FINALIZADO"
                If IsDBNull(ORDENESRow("MOTIVOCIERRE")) = False Then
                    'Select Case Trim(ORDENESRow("MOTIVOCIERRE"))
                    '    Case "REALIZADO"
                    '        CANT_FINALIZADAS = CANT_FINALIZADAS + 1
                    '    Case Else
                    'MARCA LA ORDEN EN STATUS ADUPLICAR
                    'RUTINA QUE CREA UNA COPIA DE LA ORDEN  SITUADO EN ORDENROW()
                    'CAMBIA EL STATUS DE LA ORDEN

                    TOTAL_DUPLI = TOTAL_DUPLI + 1
                        ORDENESRow("STATUS") = "ADUPLICAR"
                        MENSAJE_DUPLI(TOTAL_DUPLI) = "Orden Nro " & ORDENESRow("NRO_ORDENINT") & "  -- NODO  " & ORDENESRow("NODO") & " ZONA  " & ORDENESRow("ZONA") & " CALLE  " & ORDENESRow("CALLE") & " NRO " & ORDENESRow("NRO") & " -- Ordinal Correspondiente NRO " & ORDENESRow("NRO_ORDINAL") & " Con Motivo de Origen " & ORDENESRow("MOTIVOORIGEN")
                        Try
                            ORDENESTableAdapter.Update(ORDENESRow)
                            If ORDENESRow.IsGENERADORNull = False And ORDENESRow.GENERADOR <> "Manual" Then
                                MJE_ASUNTO = "ORDENES A DUPLICAR"
                                MJE_DESTINONOMBRE = ORDENESRow.GENERADOR
                                MJE_DESTINOSECTOR = ""
                                MJE_MENSAJE = "La orden " & ORDENESRow.NRO_ORDENINT & " se ha marcado ADUPLICAR"
                                MJE_NROORDENASOC = 0
                                ENVIA_MENSAJE()
                                NOTIFICACION("SYS", "ORDEN " & ORDENESRow.NRO_ORDENINT & " DUPLICADA")
                            End If
                        Catch ex As Exception
                            MsgBox("Ha ocurrido un error en la carga del status de la orden ADUPLICAR: " & TRABAJOSRow("Id_TRABAJO") & "  " & ex.ToString)
                        End Try

                    'End Select
                Else
                    MsgBox("La orden " & ORDENESRow("NRO_ORDENINT") & " No tiene falla de cierre")
                End If

                '    Case "ADUPLICAR", "DUPLICADO", "CANCELADO"
                '        CANT_FINALIZADAS = CANT_FINALIZADAS + 1
                'End Select
            Next I
        End If
        ' Next X
        'ARMA MENSAJE A QUIEN EJECUTO EL PROCESO
        TOTAL_MJE = ""
        For X = 1 To TOTAL_CAMBIOS
            TOTAL_MJE = TOTAL_MJE & MENSAJE_GEST(X) & vbNewLine
        Next X
        'ENVIA MESAJES DE ORDENES A DUPLICAR
        TOTAL_MJE = ""
        For X = 1 To TOTAL_DUPLI
            TOTAL_MJE = TOTAL_MJE & MENSAJE_DUPLI(X) & vbNewLine
        Next X

        If TOTAL_DUPLI > 0 Then
            'ENVIA MENSAJE A RESPONSABLE GESTION
            MJE_ASUNTO = "ORDENES A DUPLICAR"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "En el proceso se han MARCADO para duplicar las siguientes ORDENES " & vbNewLine & TOTAL_MJE
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        Else
            MJE_ASUNTO = "ORDENES A DUPLICAR"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "No se han encontrado Ordenes NO REALIZADAS en TRABAJOS analizadas"
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        End If
        ' End If
        PROGRESS_BAR("FINALIZADO ORDENES A DUPLICAR", 0, 0, 0, 0, 0, 0)
        CK_MARCA_DUPLICAR.ForeColor = Color.Green
        CK_MARCA_DUPLICAR.Refresh()
    End Sub
    Private Sub INICIA_GESTIONES()
        'INICIALIZA VARIABLES
        For I = 1 To 100
            MENSAJE_GEST(I) = ""
        Next
        TOTAL_CAMBIOS = 0
        'CARGA LAS GESTIONES EN STATUS INGRESADO O DEMORADO
        GESTIONTableAdapter.FillByAINICIAR(ORDENESDataSet.GESTION)

        'VERIFICA QUE EXISTAN GESTIONES A PROCESAR
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then

            'RECORRE LAS GESTIONES
            For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
                ''ACTUALIZA BARRA DE GESTION Y ESTABLECE FILA DE GESTION
                PROGRESS_BAR("ANALIZANDO GESTIONES A INICIAR", ORDENESDataSet.GESTION.Rows.Count, I + 1, 0, 0, 0, 0)
                GESTIONRow = ORDENESDataSet.GESTION.Rows(I)
                'POR CADA GESTION BUSCA LOS TRABAJOS RELACIONADOS QUE ESTEN EN STATUS INGRESADO O INICIADO
                TRABAJOSTableAdapter.FillByID_GEST_INIoFIN(ORDENESDataSet.TRABAJOS, GESTIONRow("Id_GESTION"))

                'VERIFICA QUE EXISTAN TRABAJOS EN ESTE STATUS
                If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                    PROGRESS_BAR("ANALIZANDO GESTIONES A INICIAR", ORDENESDataSet.GESTION.Rows.Count, I + 1, ORDENESDataSet.TRABAJOS.Rows.Count, ORDENESDataSet.TRABAJOS.Rows.Count, 0, 0)

                    TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(0)
                    GESTIONRow("STATUS") = "INICIADO"
                    GESTIONRow("FECHAINICIADA") = TRABAJOSRow("FECHAINICIADO")
                    GESTIONTableAdapter.Update(GESTIONRow)
                    'CARGA HISTORICO
                    NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
                    NewHISTORICORow("ID_GESTION") = GESTIONRow("ID_GESTION")
                    NewHISTORICORow("ID_TRABAJO") = 0
                    NewHISTORICORow("ID_ORDENINT") = 0
                    NewHISTORICORow("FECHA") = Now
                    NewHISTORICORow("STATUSANTERIOR") = "INGRESADO"
                    NewHISTORICORow("STATUSACTUAL") = "INICIADO"
                    NewHISTORICORow("CAUSA") = "INICIO DE TRABAJO RELACIONADO"
                    NewHISTORICORow("DETALLE") = "PROCESO AUTOMATICO"
                    NewHISTORICORow("EJECUTANTE") = NOMBRE & " " & APELLIDO
                    'GUARDA EL HISTORICO PROCESADO
                    ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)
                    HISTORICOTableAdapter.Update(NewHISTORICORow)
                    'CUENTA EL CAMBIO
                    TOTAL_CAMBIOS = TOTAL_CAMBIOS + 1
                    'ARMA EL TEXTO DEL MENSAJE A COMUNICAR AL RESPONSABLLE DE LA GESTION
                    MENSAJE_GEST(TOTAL_CAMBIOS) = "GESTION NRO " & GESTIONRow("Id_GESTION") & ",  AREA: " & GESTIONRow("AREA") & "- TIPO: " & GESTIONRow("TIPOGESTION") & ",  MDU CARPETA NRO: " & GESTIONRow("CARPETA")

                End If
            Next
        End If

        'ARMA MENSAJE A QUIEN EJECUTO EL PROCESO
        TOTAL_MJE = ""
        For X = 1 To TOTAL_CAMBIOS
            TOTAL_MJE = TOTAL_MJE & MENSAJE_GEST(X) & vbNewLine
        Next X

        If TOTAL_CAMBIOS > 0 Then
            'ENVIA MENSAJE A RESPONSABLE GESTION
            MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "En el proceso se han iniciado las siguientes gestiones " & vbNewLine & TOTAL_MJE & vbNewLine
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        Else
            'ENVIA MENSAJE A RESPOSABLE GESTION
            MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
            MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
            MJE_DESTINOSECTOR = ""
            MJE_MENSAJE = "No se han encontrado ORDENES finalizadas en TRABAJOS analizados"
            MJE_NROORDENASOC = 0
            ENVIA_MENSAJE()
        End If
        CK_INICIA_GESTION.ForeColor = Color.Green
        CK_INICIA_GESTION.Refresh()
    End Sub
    Private Sub FINALIZA_TRABAJOS()

        'ACTUALIZA FINALIZACION DE TRABAJOS
        Dim CANT_ORDENES As Integer
        Dim CANT_FINALIZADAS As Integer

        'INICIALIZA VARIABLES
        For I = 1 To 100
            MENSAJE_GEST(I) = ""
            MENSAJE_DUPLI(I) = ""
        Next

        TOTAL_CAMBIOS = 0

        'CARGA LOS TRABAJOS EN STATUS INICIADO Y MARCADOS COMO COMPLETOS
        TRABAJOSTableAdapter.FillByINI_COMP(ORDENESDataSet.TRABAJOS)

        'CONTROLA QUE HAYA TRABAJOS SIN FINALIZAR
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            'RECORRE LA TABLA DE TRABAJOS
            For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                PROGRESS_BAR("ANALIZANDO FINALIZAR TRABAJOS", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, 0, 0)
                TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)
                HIS_STATUSANT = TRABAJOSRow("STATUS")

                TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)

                'BUSCA LAS ORDENES DENTRO DEL TRABAJO
                ORDENESTableAdapter.FillByIDTRABAJO_FINTRA(ORDENESDataSet.ORDENES, TRABAJOSRow("Id_TRABAJO"))
                'VERIFICA QUE HAYA ORDENES DENTRO DEL TRABAJO
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then

                    CANT_ORDENES = ORDENESDataSet.ORDENES.Rows.Count
                    CANT_FINALIZADAS = 0

                    'RECORRE LAS ORDENES DEFINIDAS DENTRO DEL TRABAJO
                    For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                        PROGRESS_BAR("ANALIZANDO FINALIZAR TRABAJOS", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, ORDENESDataSet.ORDENES.Rows.Count, I + 1)
                        ORDENESRow = ORDENESDataSet.ORDENES.Rows(I)
                        'CUENTA LAS ORDENES EN STATUS FINALIZADO Y LAS QUE NO FIGURAN COMO REALIZADO LAS MANDA A DUPLICAR
                        Select Case Trim(ORDENESRow("STATUS"))
                            Case "FINALIZADO"
                                Select Case Trim(ORDENESRow("MOTIVOCIERRE"))
                                    Case "REALIZADO"
                                        CANT_FINALIZADAS = CANT_FINALIZADAS + 1
                                    Case Else
                                        'CREA_COPIAORDEN()
                                End Select
                            Case "DUPLICADO", "CANCELADO"
                                CANT_FINALIZADAS = CANT_FINALIZADAS + 1
                        End Select

                    Next I

                    If CANT_FINALIZADAS = CANT_ORDENES Then

                        If TRABAJOSRow("COMPLETO") = True Then
                            TRABAJOSRow("STATUS") = "FINALIZADO"
                            TRABAJOSRow("FECHAFINALIZADO") = ORDENESRow("FECHAFIN")
                            If TRABAJOSRow("REQUERIDO") = True Then
                                TRABAJOSRow("REQUERIDO") = False
                            End If
                            TRABAJOSTableAdapter.Update(TRABAJOSRow)
                            NOTIFICACION("SYS", "TRABAJO " & TRABAJOSRow.Id_TRABAJO & " DE " & TRABAJOSRow.TIPOTRABAJO & " - FINALIZADO")
                            'CUENTA EL CAMBIO
                            TOTAL_CAMBIOS = TOTAL_CAMBIOS + 1
                            'ARMA EL TEXTO DEL MENSAJE A COMUNICAR AL RESPONSABLLE DE LA GESTION
                            MENSAJE_GEST(TOTAL_CAMBIOS) = "TRABAJO NRO: " & TRABAJOSRow("Id_TRABAJO") & ",  TIPO TRABAJO: " & TRABAJOSRow("TIPOTRABAJO") & ",  NODO: " & TRABAJOSRow("NODO") & ",  ZONA: " & TRABAJOSRow("ZONA") & vbNewLine
                            'CARGA EL HISTORICO DEL TRABAJO PROCESADO

                            'CARGA HISTORICO
                            NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
                            NewHISTORICORow("ID_GESTION") = TRABAJOSRow("ID_GESTION")
                            NewHISTORICORow("ID_TRABAJO") = TRABAJOSRow("Id_TRABAJO")
                            NewHISTORICORow("ID_ORDENINT") = 0
                            NewHISTORICORow("FECHA") = Now
                            NewHISTORICORow("STATUSANTERIOR") = HIS_STATUSANT
                            NewHISTORICORow("STATUSACTUAL") = "FINALIZADO"
                            NewHISTORICORow("CAUSA") = "ORDENES RELACIONADAS FINALIZADAS EN TRABAJO MARCADO COMO COMPLETO"
                            NewHISTORICORow("DETALLE") = "PROCESO AUTOMATICO"
                            NewHISTORICORow("EJECUTANTE") = NOMBRE & " " & APELLIDO
                            'GUARDA EL HISTORICO PROCESADO
                            ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)
                            Me.HISTORICOTableAdapter.Update(NewHISTORICORow)
                        End If
                    End If
                End If
            Next X


            TOTAL_MJE = ""
            For X = 1 To TOTAL_CAMBIOS
                TOTAL_MJE = TOTAL_MJE & MENSAJE_GEST(X) & vbNewLine
            Next X

            If TOTAL_CAMBIOS > 0 Then
                'ENVIA MENSAJE A RESPONSABLE GESTION
                MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
                MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
                MJE_DESTINOSECTOR = ""
                MJE_MENSAJE = "En el proceso se han FINALIZADO los siguientes trabajos " & vbNewLine & TOTAL_MJE
                MJE_NROORDENASOC = 0
                ENVIA_MENSAJE()
            Else
                'ENVIA MENSAJE A RESPOSABLE GESTION
                MJE_ASUNTO = "ACTUALIZACION DE STATUS DE TRABAJOS"
                MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
                MJE_DESTINOSECTOR = ""
                MJE_MENSAJE = "No se han encontrado Ordenes FINALIZADAS en TRABAJOS analizados"
                MJE_NROORDENASOC = 0
                ENVIA_MENSAJE()
            End If
        End If
        PROGRESS_BAR("FINALIZADO, FINALIZAR TRABAJOS", 0, 0, 0, 0, 0, 0)
        CK_FINALIZA_TRABAJO.ForeColor = Color.Green
        CK_FINALIZA_TRABAJO.Refresh()
    End Sub
    Private Sub FINALIZA_GESTIONES()

        'ACTUALIZA FINALIZACION DE GESTIONES
        Dim CANT_TRABAJOS As Integer
        Dim CANT_FINALIZADOS As Integer

        'INICIALIZA VARIABLES
        For I = 1 To 100
            MENSAJE_GEST(I) = ""
            MENSAJE_DUPLI(I) = ""
        Next
        TOTAL_CAMBIOS = 0

        'BUSCA LAS GESTIONES A FINALIZAR CON STATUS INICIADO O DEMORADO Y MARCA COMPLETO = TRUE
        GESTIONTableAdapter.FillByAFINALIZAR(ORDENESDataSet.GESTION)
        'SI EXISTEN GESTIONES NO FINALIZADAS
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            'RECORRE LAS GESTIONES NO FINALIZADAS
            For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
                'ACTUALIZA BARRA DE GESTION Y ESTABLECE FILA DE GESTION
                PROGRESS_BAR("FINALIZANDO GESTIONES", ORDENESDataSet.GESTION.Rows.Count, I + 1, 0, 0, 0, 0)

                GESTIONRow = ORDENESDataSet.GESTION.Rows(I)

                'POR CADA GESTION NO FINALIZADAS BUSCA LOS TRABAJO CARGADOS EN ELLA SI LA GESTION ESTA MARCADA COMO COMPLETA

                HIS_STATUSANT = GESTIONRow("STATUS")
                TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, GESTIONRow("Id_GESTION"))

                CANT_TRABAJOS = ORDENESDataSet.TRABAJOS.Rows.Count
                CANT_FINALIZADOS = 0

                'SI EXISTEN TRABAJOS DEFINIDOS EN LA GESTION
                If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then

                    'RECORRE LA BASE DE TRABAJO BUSCANDO EL STATUS
                    For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                        PROGRESS_BAR("FINALIZANDO GESTIONES", ORDENESDataSet.GESTION.Rows.Count, I + 1, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, 0, 0)

                        TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)
                        HIS_STATUSANT = TRABAJOSRow("STATUS")

                        'SELECCIONA EL STATUS DEL TRABAJO
                        Select Case TRABAJOSRow("STATUS")
                            Case "FINALIZADO", "CANCELADO", "ANULADO"
                                CANT_FINALIZADOS = CANT_FINALIZADOS + 1
                        End Select
                    Next X

                    If CANT_TRABAJOS = CANT_FINALIZADOS Then

                        GESTIONRow("STATUS") = "FINALIZADO"
                        GESTIONRow("FECHAFINALIZADA") = Today

                        'ACTUALIZA EL STATUS DE LA TABLA EDIFICIOS
                        If GESTIONRow.IsCARPETANull = False Then
                            If GESTIONRow("AREA") = "MDU" Then
                                EdificiosTableAdapter.FillByCARPETA(MDUDataSet.Edificios, GESTIONRow("CARPETA"), GESTIONRow("CARPETA"))
                                If MDUDataSet.Edificios.Rows.Count > 0 Then
                                    EdificiosRow = MDUDataSet.Edificios.Rows(0)
                                    Select Case GESTIONRow("TIPOGESTION")
                                        Case "Mant Preventivo", "MANT PREVENTIVO"
                                            EdificiosRow("GESTMANT") = False
                                        Case "Obra Nueva", "OBRA NUEVA"
                                            EdificiosRow("GESTOBR") = False
                                            EdificiosRow("CABLEADO") = True
                                    End Select
                                End If
                            End If
                        End If
                        If GESTIONRow("REQUERIDO") = True Then
                            GESTIONTableAdapter.GEST_QUITARREQUERIDO(GESTIONRow("ID_GESTION"))
                        End If
                        GESTIONTableAdapter.Update(GESTIONRow)
                        EdificiosTableAdapter.Update(EdificiosRow)
                        NOTIFICACION("SYS", "GESTION " & GESTIONRow.Id_GESTION & " DE " & GESTIONRow.TIPOGESTION & " - FINALIZADA")
                        'CUENTA EL CAMBIO
                        TOTAL_CAMBIOS = TOTAL_CAMBIOS + 1
                        'ARMA EL TEXTO DEL MENSAJE A COMUNICAR AL RESPONSABLLE DE LA GESTION
                        MENSAJE_GEST(TOTAL_CAMBIOS) = "GESTION NRO: " & GESTIONRow("Id_GESTION") & ",  TIPO " & GESTIONRow("TIPOGESTION") & ",  AREA: " & GESTIONRow("AREA") & ",  CARPETA: " & GESTIONRow("CARPETA") & vbNewLine &
                        "UBICACION: NODO: " & TRABAJOSRow("NODO") & ",  ZONA: " & TRABAJOSRow("ZONA") & ",  CALLE: " & TRABAJOSRow("CALLE") & " NRO: " & TRABAJOSRow("NRO") & vbNewLine
                        'CARGA EL HISTORICO DE LA GESTION PROCESADA
                        'CARGA HISTORICO
                        NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
                        NewHISTORICORow("ID_GESTION") = TRABAJOSRow("ID_GESTION")
                        NewHISTORICORow("ID_TRABAJO") = 0
                        NewHISTORICORow("ID_ORDENINT") = 0
                        NewHISTORICORow("FECHA") = Now
                        NewHISTORICORow("STATUSANTERIOR") = HIS_STATUSANT
                        NewHISTORICORow("STATUSACTUAL") = "FINALIZADO"
                        NewHISTORICORow("CAUSA") = "TRABAJOS RELACIONADOS FINALIZADOS EN GESTION MARCADA COMO COMPLETA"
                        NewHISTORICORow("DETALLE") = "PROCESO AUTOMATICO"
                        NewHISTORICORow("EJECUTANTE") = NOMBRE & " " & APELLIDO

                        'GUARDA EL HISTORICO PROCESADO
                        ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)
                        Me.HISTORICOTableAdapter.Update(NewHISTORICORow)

                    End If
                End If
            Next I

            TOTAL_MJE = ""
            For X = 1 To TOTAL_CAMBIOS
                TOTAL_MJE = TOTAL_MJE & MENSAJE_GEST(X) & vbNewLine
            Next X

            If TOTAL_CAMBIOS > 0 Then
                'ENVIA MENSAJE A RESPONSABLE GESTION
                MJE_ASUNTO = "ACTUALIZACION DE STATUS DE GESTIONES"
                MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
                MJE_DESTINOSECTOR = ""
                MJE_MENSAJE = "En el proceso se han FINALIZADO las siguientes GESTIONES " & vbNewLine & TOTAL_MJE
                MJE_NROORDENASOC = 0
                ENVIA_MENSAJE()
            Else
                'ENVIA MENSAJE A RESPOSABLE GESTION
                MJE_ASUNTO = "ACTUALIZACION DE STATUS DE GESTIONES"
                MJE_DESTINONOMBRE = NOMBRE & " " & APELLIDO
                MJE_DESTINOSECTOR = ""
                MJE_MENSAJE = "No se han encontrado TRABAJOS finalizados en GESTIONES analizadas"
                MJE_NROORDENASOC = 0
                ENVIA_MENSAJE()
            End If
        End If
        PROGRESS_BAR("FINALIZADO, FINALIZANDO GESTIONES", 0, 0, 0, 0, 0, 0)
        CK_FINALIZA_GESTION.ForeColor = Color.Green
        CK_FINALIZA_GESTION.Refresh()
    End Sub
    Private Sub LIMPIA_MENSAJES()

        Me.MENSAJERIATableAdapter.FillByMENOR_AFECHA(Me.ORDENESDataSet.MENSAJERIA, FECHALIMITE.ToShortDateString)


        If ORDENESDataSet.MENSAJERIA.Rows.Count > 0 Then
            For I = 0 To ORDENESDataSet.MENSAJERIA.Rows.Count - 1
                Try
                    MENSAJESOLD = ORDENESDataSet.MENSAJERIA.Rows(0)

                    'COPIA EL MENSAJE A LA TABLA OLD
                    MENSAJESOLDNew = ORDENESDataSet.MENSAJERIA_OLD.NewMENSAJERIA_OLDRow

                    MENSAJESOLDNew("FECHACREADO") = MENSAJESOLD("FECHACREADO")
                    MENSAJESOLDNew("TIPOMENSAJE") = MENSAJESOLD("TIPOMENSAJE")
                    MENSAJESOLDNew("ASUNTO") = MENSAJESOLD("ASUNTO")
                    MENSAJESOLDNew("ORIGEN_NOMBRE") = MENSAJESOLD("ORIGEN_NOMBRE")
                    MENSAJESOLDNew("ORIGEN_SECTOR") = MENSAJESOLD("ORIGEN_SECTOR")
                    MENSAJESOLDNew("DESTINO_NOMBRE") = MENSAJESOLD("DESTINO_NOMBRE")
                    MENSAJESOLDNew("DESTINO_SECTOR") = MENSAJESOLD("DESTINO_SECTOR")
                    MENSAJESOLDNew("MENSAJE") = MENSAJESOLD("MENSAJE")
                    MENSAJESOLDNew("TIPO_ORDENASOC") = MENSAJESOLD("TIPO_ORDENASOC")
                    MENSAJESOLDNew("NRO_ORDENASOC") = MENSAJESOLD("NRO_ORDENASOC")
                    MENSAJESOLDNew("STATUS") = MENSAJESOLD("STATUS")
                    MENSAJESOLDNew("LEIDO") = MENSAJESOLD("LEIDO")
                    MENSAJESOLDNew("FECHALEIDO") = MENSAJESOLD("FECHALEIDO")

                    ORDENESDataSet.MENSAJERIA_OLD.AddMENSAJERIA_OLDRow(MENSAJESOLDNew)
                    MENSAJERIA_OLDTableAdapter.Update(MENSAJESOLDNew)

                    '  MENSAJERIA_OLDBindingSource.MoveLast()
                    ' MENSAJERIA_OLDDataGridView.Refresh()

                    MENSAJESOLD.Delete()
                    MENSAJERIATableAdapter.Update(MENSAJESOLD)
                    ' MENSAJERIADataGridView.Refresh()
                Catch

                End Try

            Next

            'For X = 0 To ORDENESDataSet.MENSAJERIA.Rows.Count - 1
            '    'BORRA LINEA DE MENSAJE
            '    MENSAJESOLD = ORDENESDataSet.MENSAJERIA.Rows(X)
            '    MENSAJESOLD.Delete()
            '    'MENSAJESOLD.AcceptChanges()
            'Next

            'ORDENESDataSet.MENSAJERIA.AcceptChanges()
            'MENSAJERIADataGridView.Refresh()


            'MENSAJERIATableAdapter.Update(ORDENESDataSet.MENSAJERIA)

            'GRABA 
            'MENSAJERIATableAdapter.Update(ORDENESDataSet.MENSAJERIA)
            'MENSAJERIADataGridView.Refresh()

        End If
        CK_LIMPIEZA_MENSAJES.ForeColor = Color.Green
        CK_LIMPIEZA_MENSAJES.Refresh()


    End Sub

    Private Sub ENVIA_MENSAJE()
        'ENVIA MENSAJE 
        NewMENSAJE = ORDENESDataSet.MENSAJERIA.NewMENSAJERIARow
        NewMENSAJE("FECHACREADO") = Now
        NewMENSAJE("TIPOMENSAJE") = "INFORMACION AUTOMATICA"
        NewMENSAJE("ASUNTO") = MJE_ASUNTO
        NewMENSAJE("ORIGEN_NOMBRE") = NOMBRE & " " & APELLIDO
        NewMENSAJE("ORIGEN_SECTOR") = ""
        NewMENSAJE("DESTINO_NOMBRE") = MJE_DESTINONOMBRE
        NewMENSAJE("DESTINO_SECTOR") = MJE_DESTINOSECTOR
        NewMENSAJE("MENSAJE") = MJE_MENSAJE
        NewMENSAJE("TIPO_ORDENASOC") = "ORDEN INTERNA"
        'NewMENSAJE("NRO_ORDENASOC") = MJE_NROORDENASOC

        ORDENESDataSet.MENSAJERIA.AddMENSAJERIARow(NewMENSAJE)
        MENSAJERIATableAdapter.Update(NewMENSAJE)
    End Sub
    Private Sub REQUERIDOS()
        Dim CUENTA_TRA As Integer
        Dim CUENTA_ORDEN As Integer
        GESTIONTableAdapter.FillByNOFINALIZADO(ORDENESDataSet.GESTION) 'INGRESADOS, DEMORADOS, INICIADOS

        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            For G = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
                TRABAJOSTableAdapter.FillByIDGESTIONNOCANCELADO(ORDENESDataSet.TRABAJOS, ORDENESDataSet.GESTION.Rows(G).Item("ID_GESTION"))
                CUENTA_TRA = 0
                If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                    For T = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                        If ORDENESDataSet.TRABAJOS.Rows(T).Item("STATUS") = "FINALIZADO" Then
                            CUENTA_TRA += 1
                        End If
                    Next
                    If CUENTA_TRA = ORDENESDataSet.TRABAJOS.Rows.Count Then
                        GESTIONTableAdapter.GEST_MARCARREQUERIDO(ORDENESDataSet.GESTION.Rows(G).Item("ID_GESTION"))
                    Else
                        GESTIONTableAdapter.GEST_QUITARREQUERIDO(ORDENESDataSet.GESTION.Rows(G).Item("ID_GESTION"))
                    End If
                End If
                PROGRESS_BAR("ANALIZANDO GESTIONES REQUERIDAS", ORDENESDataSet.GESTION.Rows.Count, G + 1, 0, 0, 0, 0)
            Next
        End If
        NOTIFICACION("SYS", "GESTIONES REQUERIDAS ACTUALIZADAS")
        TRABAJOSTableAdapter.FillByNOFINALIZADO(ORDENESDataSet.TRABAJOS)
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            For T = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                CUENTA_ORDEN = 0
                ORDENESTableAdapter.FillByORDXTAB_REQUERIDO(ORDENESDataSet.ORDENES, ORDENESDataSet.TRABAJOS.Rows(T).Item("ID_TRABAJO"))
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                    For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                        PROGRESS_BAR("ANALIZANDO TRABAJOS REQUERIDOS", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, T + 1, ORDENESDataSet.ORDENES.Rows.Count, X + 1)
                        If ORDENESDataSet.ORDENES.Rows(X).Item("STATUS") = "FINALIZADO" Then
                            CUENTA_ORDEN += 1
                        End If
                    Next
                    If ORDENESDataSet.ORDENES.Rows.Count = CUENTA_ORDEN Then
                        ORDENESDataSet.TRABAJOS.Rows(T).Item("REQUERIDO") = True
                    Else
                        ORDENESDataSet.TRABAJOS.Rows(T).Item("REQUERIDO") = False
                    End If
                Else
                    ORDENESDataSet.TRABAJOS.Rows(T).Item("REQUERIDO") = False
                End If
                PROGRESS_BAR("ANALIZANDO TRABAJOS REQUERIDOS", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, T + 1, 0, 0)
            Next

            TRABAJOSTableAdapter.Update(ORDENESDataSet.TRABAJOS)
            NOTIFICACION("SYS", "TRABAJOS REQUERIDOS ACTUALIZADOS")
        End If
        CK_REQUERIDOS.ForeColor = Color.Green
        CK_REQUERIDOS.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_PROCESO.Click
        'CURSOR_WAIT(True, Me)
        BTN_PROCESO.Enabled = False
        BTN_PROCESO.Text = "PROCESANDO"
        LBL_ESTADO.Text = "PROCESO INICIALIZADO"
        LBL_ESTADO.Refresh()
        Cursor = Cursors.WaitCursor
        '   BackgroundWorker1.RunWorkerAsync()
        If CK_INICIAR_TRABAJOS.Checked Then INICIA_TRABAJOS()
        If CK_MARCA_DUPLICAR.Checked Then MARCA_ADUPLICAR()
        If CK_INICIA_GESTION.Checked Then INICIA_GESTIONES()
        If CK_FINALIZA_TRABAJO.Checked Then FINALIZA_TRABAJOS()
        If CK_FINALIZA_GESTION.Checked Then FINALIZA_GESTIONES()
        If CK_REQUERIDOS.Checked Then REQUERIDOS()
        If CK_LIMPIEZA_MENSAJES.Checked Then LIMPIA_MENSAJES()
        Cursor = Cursors.Default
    End Sub

    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    ''LBL_ESTADO.Text = "INICIANDO TRABAJOS"
    '    ''LBL_ESTADO.Refresh()
    '    INICIA_TRABAJOS()
    '    'LBL_ESTADO.Text = "MARCANDO ORDENES A DUPLICAR"
    '    'LBL_ESTADO.Refresh()
    '    MARCA_ADUPLICAR()
    '    'LBL_ESTADO.Text = "INICIANDO GESTIONES"
    '    'LBL_ESTADO.Refresh()
    '    INICIA_GESTIONES()
    '    'LBL_ESTADO.Text = "FINALIZANDO TRABAJOS"
    '    'LBL_ESTADO.Refresh()
    '    FINALIZA_TRABAJOS()
    '    'LBL_ESTADO.Text = "FINALIZANDO TRABAJOS"
    '    'LBL_ESTADO.Refresh()
    '    FINALIZA_GESTIONES()
    '    'LBL_ESTADO.Text = "LIMPIANDO MENSAJES"
    '    'LBL_ESTADO.Refresh()
    '    LIMPIA_MENSAJES()
    '    'LBL_ESTADO.Text = "TRABAJANDO EN REQUERIDOS"
    '    'LBL_ESTADO.Refresh()
    '    REQUERIDOS()

    'End Sub
    'Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
    '    LBL_ESTADO.Text = "ANALIZANDO GESTIONES QUE SEAN REQUERIDOS"
    '    LBL_ESTADO.Refresh()
    'End Sub
    'Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    '    If e.Error IsNot Nothing Then
    '        MsgBox("ERROR EN EL PROCESO", vbInformation)
    '    Else
    '        MsgBox("PROCESOS TERMINADO", vbInformation)
    '    End If
    '    CURSOR_WAIT(False, Me)
    '    BTN_PROCESO.Text = "PROCESAR"
    '    BTN_PROCESO.Enabled = True
    'End Sub
    Public Sub PROGRESS_BAR(ByVal TITULO As String, ByVal MAX_GEST As Integer, ByVal VALUE_GEST As Integer, ByVal MAX_TRABAJO As Integer, ByVal VALUE_TRABAJO As Integer, ByVal MAX_ORDEN As Integer, ByVal VALUE_ORDEN As Integer)
        LBL_REGISTROS.Visible = True
        If LBL_REGISTROS.Text <> TITULO Then
            LBL_REGISTROS.Text = TITULO
            LBL_REGISTROS.Refresh()
        End If
        'PARA LA GESTION
        If MAX_GEST = 0 Then
            LBL_CANT_REGISTROS.Visible = False
            lbl_slash.Visible = False
            PB_GESTIONES.Visible = False
            LBL_TOTAL.Visible = False
            LBL_GEST.Visible = False
        Else
            PB_GESTIONES.Visible = True
            LBL_GEST.Visible = True
            If VALUE_GEST = 0 Then
                LBL_CANT_REGISTROS.Visible = False
                lbl_slash.Visible = False
                LBL_TOTAL.Visible = False
            Else
                LBL_CANT_REGISTROS.Visible = True
                LBL_TOTAL.Visible = True
                lbl_slash.Visible = True
            End If
        End If
        If PB_GESTIONES.Maximum <> MAX_GEST Then
            PB_GESTIONES.Maximum = MAX_GEST
        End If
        If LBL_TOTAL.Text <> MAX_GEST Then
            LBL_TOTAL.Text = MAX_GEST
            LBL_TOTAL.Refresh()
        End If
        LBL_CANT_REGISTROS.Text = VALUE_GEST
        PB_GESTIONES.Value = VALUE_GEST
        PB_GESTIONES.Refresh()
        lbl_slash.Refresh()
        LBL_CANT_REGISTROS.Refresh()
        LBL_GEST.Refresh()
        'PARA EL TRABAJO
        If MAX_TRABAJO = 0 Then
            CANT_TRABAJOS.Visible = False
            SLASH_TRABAJOS.Visible = False
            PB_TRABAJOS.Visible = False
            TOTAL_TRABAJOS.Visible = False
            LBL_TRAB.Visible = False
        Else
            PB_TRABAJOS.Visible = True
            LBL_TRAB.Visible = True
            If VALUE_TRABAJO = 0 Then
                CANT_TRABAJOS.Visible = False
                SLASH_TRABAJOS.Visible = False
                TOTAL_TRABAJOS.Visible = False
            Else
                CANT_TRABAJOS.Visible = True
                TOTAL_TRABAJOS.Visible = True
                SLASH_TRABAJOS.Visible = True
            End If
        End If
        If PB_TRABAJOS.Maximum <> MAX_TRABAJO Then
            PB_TRABAJOS.Maximum = MAX_TRABAJO
        End If
        If TOTAL_TRABAJOS.Text <> MAX_TRABAJO Then
            TOTAL_TRABAJOS.Text = MAX_TRABAJO
            TOTAL_TRABAJOS.Refresh()
        End If
        CANT_TRABAJOS.Text = VALUE_TRABAJO
        PB_TRABAJOS.Value = VALUE_TRABAJO
        PB_TRABAJOS.Refresh()
        SLASH_TRABAJOS.Refresh()
        CANT_TRABAJOS.Refresh()
        LBL_TRAB.Refresh()
        'PARA LA ORDEN
        If MAX_ORDEN = 0 Then
            CANT_ORDENES.Visible = False
            SLASH_ORDENES.Visible = False
            PB_ORDENES.Visible = False
            TOTAL_ORDENES.Visible = False
            LBL_ORD.Visible = False
        Else
            PB_ORDENES.Visible = True
            LBL_ORD.Visible = True
            If VALUE_ORDEN = 0 Then
                CANT_ORDENES.Visible = False
                SLASH_ORDENES.Visible = False
                TOTAL_ORDENES.Visible = False
            Else
                CANT_ORDENES.Visible = True
                TOTAL_ORDENES.Visible = True
                SLASH_ORDENES.Visible = True
            End If
        End If
        If PB_ORDENES.Maximum <> MAX_ORDEN Then
            PB_ORDENES.Maximum = MAX_ORDEN
        End If
        If TOTAL_ORDENES.Text <> MAX_ORDEN Then
            TOTAL_ORDENES.Text = MAX_ORDEN
            TOTAL_ORDENES.Refresh()
        End If
        CANT_ORDENES.Text = VALUE_ORDEN
        PB_ORDENES.Value = VALUE_ORDEN
        PB_ORDENES.Refresh()
        SLASH_ORDENES.Refresh()
        CANT_ORDENES.Refresh()
        LBL_ORD.Refresh()
    End Sub
    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs)
        Close()
        Dispose()
    End Sub



    'INDICES________________________________________________________________________________________________________________________________________________________
    Private Sub CARGA_BASEPERMISORES()
        Dim VALOR_MES As String
        BasePermisoresTableAdapter.FillByID_INFORME(INFORME_INDICEDataSet.BasePermisores, INFORMERow.Id)
        If INFORME_INDICEDataSet.BasePermisores.Rows.Count > 0 Then
            MsgBox("CARGAN REGISTROS EXISTENTES")

        Else
            If INFORMERow("MES") < 10 Then
                VALOR_MES = "0" & INFORMERow("MES")
            Else
                VALOR_MES = INFORMERow("MES")
            End If
            TablaWEBTableAdapter.FillByAÑOMES(INFORME_INDICEDataSet.TablaWEB, INFORMERow("AÑO"), VALOR_MES)
            ' BaseCalculoTableAdapter.FillByINFORME(INFORME_INDICEDataSet.BaseCalculo, INFORMERow.Id)

            For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
                'Inicilaiza la fila como una nueva
                TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)
                BASECALCULORow = INFORME_INDICEDataSet.BaseCalculo.FindByidReclamo(TABLAWEBRow.ID_RECLAMO)
                'BaseCalculoTableAdapter.FillByID_RECLAMO(INFORME_INDICEDataSet.BaseCalculo, TABLAWEBRow.ID_RECLAMO)
                'If INFORME_INDICEDataSet.BaseCalculo.Rows.Count = 1 Then
                '    BASECALCULORow = INFORME_INDICEDataSet.BaseCalculo.Rows(0)
                'Else
                '    BASECALCULORow = Nothing
                'End If
                'Carga datos en tabla permisores

                newRecPermRow = INFORME_INDICEDataSet.BasePermisores.NewBasePermisoresRow
                newRecPermRow("IDReclamoEQUITAL") = TABLAWEBRow.ID_RECLAMO
                newRecPermRow("IDReclamoPERMISOR") = TABLAWEBRow.ID_RECLAMO_PERMISOR
                newRecPermRow("DESCFallaOrigen") = TABLAWEBRow.DESCRIPCION_DE_FALLA_ORI_REC
                newRecPermRow("TipoSolucion") = TABLAWEBRow.TIPO_DE_SOLUCION
                newRecPermRow("Permisor") = TABLAWEBRow.PERMISOR
                newRecPermRow("FechaIngSolREC") = DateValue(TABLAWEBRow.FECHA_ING_RECLAMO).ToShortDateString
                newRecPermRow("HoraIngreso") = TimeValue(TABLAWEBRow.FECHA_ING_RECLAMO).ToShortTimeString

                If BASECALCULORow IsNot Nothing Then
                    'If BASECALCULORow.FechaCierreCalculo.ToString <> "" Then
                    newRecPermRow("FechaCumpREC") = CDate(BASECALCULORow.FechaCierreCalculo).ToShortDateString
                    newRecPermRow("HoraCumpREC") = CDate(BASECALCULORow.FechaCierreCalculo).ToShortTimeString
                    'Else
                    '    newRecPermRow("FechaCumpREC") = ""
                    '    newRecPermRow("HoraCumpREC") = ""
                    'End If
                    'If IsDate(BASECALCULORow.FechaCierreCalculo) Then
                    newRecPermRow("FechaFinOrdinal") = DateValue(BASECALCULORow.FechaCierreCalculo).ToShortDateString
                    newRecPermRow("HoraFinOrdinal") = TimeValue(BASECALCULORow.FechaCierreCalculo).ToShortTimeString
                    'Else
                    '    newRecPermRow("FechaFinOrdinal") = ""
                    '    newRecPermRow("HoraFinOrdinal") = ""
                    'End If
                    newRecPermRow("DescFallaCierre") = BASECALCULORow.DescFallaCierre
                    newRecPermRow("DescCausaCierre") = BASECALCULORow.DescCausaCierre

                End If

                newRecPermRow("Ordinal") = TABLAWEBRow.ORDINAL
                If IsDate(TABLAWEBRow.HORA_ING_ORDINAL) Then
                    newRecPermRow("FechaIngOrdinal") = DateValue(TABLAWEBRow.HORA_ING_ORDINAL).ToShortDateString
                    newRecPermRow("HoraIngOrdinal") = TimeValue(TABLAWEBRow.HORA_ING_ORDINAL).ToShortTimeString
                Else
                    newRecPermRow("FechaIngOrdinal") = ""
                    newRecPermRow("HoraIngOrdinal") = ""
                End If

                newRecPermRow("TipoOrdinal") = TABLAWEBRow.TIPO_ORDINAL
                newRecPermRow("SectorOrdinal") = TABLAWEBRow.SECTOR_ORDINAL
                newRecPermRow("Tecnico") = TABLAWEBRow.TECNICO_EJECUTANTE
                TECNICO_ROW = INFORME_INDICEDataSet.Tecnicos.FindByTECNICO(TABLAWEBRow.TECNICO_EJECUTANTE)
                If IsNothing(TECNICO_ROW) Then
                    MsgBox("EL TECNICO " & TABLAWEBRow.TECNICO_EJECUTANTE & " NO SE ENCUENTRA DEFINIDO EN LA BASE DE DATOS")
                    newRecPermRow("NombreTecnico") = "TECNICO NO INGRESADO A BASE"
                Else
                    newRecPermRow("NombreTecnico") = TECNICO_ROW.NOMBRE_DE_TECNICO
                End If
                newRecPermRow("ValidoIND") = TABLAWEBRow.VALIDO_INDICE


                If Not TABLAWEBRow.IsMOTIVONull Then
                    If TABLAWEBRow.MOTIVO <> "" Then
                        newRecPermRow("Motivo") = TABLAWEBRow.MOTIVO
                    End If
                End If


                newRecPermRow("InformeNRO") = INFORMERow.Id
                'agrega una nueva fila
                INFORME_INDICEDataSet.BasePermisores.Rows.Add(newRecPermRow)
                '     PROGRESS_BAR("PROCESANDO BASE PERMISORES", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR + 1)


            Next
            '  PROGRESS_BAR("GRABANDO BASE PERMISORES", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR)
            BasePermisoresTableAdapter.Update(INFORME_INDICEDataSet.BasePermisores)
            'PROGRESS_BAR("GRABANDO BASE PERMISORES", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR)
            'BasePermisoresTableAdapter.Update(INFORME_INDICEDataSet.BasePermisores)
            '   PROGRESS_BAR("PROCESO TERMINADO", 0, 0)

        End If
    End Sub
    Private Sub BTN_CARGA_PERMISORES_Click(sender As Object, e As EventArgs) Handles BTN_CARGA_PERMISORES.Click
        CARGA_BASEPERMISORES()
    End Sub
    ' Private Sub BTN_EXPORTAR_Click(sender As Object, e As EventArgs) Handles BTN_EXPORTAR.Click
    '  P_BAR.Visible = True
    '  LBL_CANT_REGISTROS.Visible = True
    '   P_BAR.Refresh()
    '  LBL_CANT_REGISTROS.Refresh()
    '   PROGRESS_BAR("EXPORTANDO BASE CALCULO", 100, 0)
    '  LBL_TOTAL.Text = INFORME_INDICEDataSet.BasePermisores.Rows.Count
    ' ExportarExcel(INFORME_INDICEDataSet.BasePermisores, "", P_BAR, LBL_CANT_REGISTROS)
    '  End Sub
    'Private Sub BTN_BORRAR_BPERMISORES_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR_BPERMISORES.Click
    '    BTN_BORRAR_BPERMISORES.Enabled = False
    '    If INFORME_INDICEDataSet.BasePermisores.Rows.Count > 0 Then
    '        For X = 0 To INFORME_INDICEDataSet.BasePermisores.Rows.Count - 1
    '            INFORME_INDICEDataSet.BasePermisores.Rows(X).Delete()
    '            PROGRESS_BAR("BORRANDO BASE PERMISORES", INFORME_INDICEDataSet.BasePermisores.Rows.Count, X + 1)
    '        Next
    '        PROGRESS_BAR("GRABANDO BASE PERMISORES", INFORME_INDICEDataSet.BasePermisores.Rows.Count, INFORME_INDICEDataSet.BasePermisores.Rows.Count)
    '        BasePermisoresTableAdapter.Update(INFORME_INDICEDataSet.BasePermisores)
    '        PROGRESS_BAR("PROCESO TERMINADO", 0, 0)
    '        BTN_BORRAR_BPERMISORES.Enabled = True
    '    End If
    'End Sub
    Private Sub BTN_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles BTN_SELECCIONAR.Click
        GB_INFORME1.Visible = True
        InformesTableAdapter.FillByNOMBREINFORME(INFORME_INDICEDataSet.Informes, CB_INFORMES.Text)
        INFORMERow = INFORME_INDICEDataSet.Informes.Rows(0)
        RepoIndicesTableAdapter.FillByInformeID(INFORME_INDICEDataSet.RepoIndices, INFORMERow.Id)
        If INFORME_INDICEDataSet.RepoIndices.Rows.Count > 0 Then
            For INDICE = 0 To INFORME_INDICEDataSet.RepoIndices.Rows.Count - 1
                REPOIndiceROW = INFORME_INDICEDataSet.RepoIndices.Rows(INDICE)
                If Not REPOIndiceROW.IsValorIndiceNull Then
                    Select Case REPOIndiceROW.Indice
                        Case 1
                            TextBox1.Text = REPOIndiceROW.ValorIndice
                        Case 2
                            TextBox2.Text = REPOIndiceROW.ValorIndice
                        Case 3
                            TextBox3.Text = REPOIndiceROW.ValorIndice
                        Case 4
                            TextBox6.Text = REPOIndiceROW.ValorIndice
                        Case 5
                            TextBox7.Text = REPOIndiceROW.ValorIndice
                        Case 6
                            TextBox4.Text = REPOIndiceROW.ValorIndice
                        Case 7
                            TextBox5.Text = REPOIndiceROW.ValorIndice
                        Case 8
                            TextBox37.Text = REPOIndiceROW.ValorIndice
                        Case 9
                            TextBox39.Text = REPOIndiceROW.ValorIndice
                        Case 10
                            TextBox40.Text = REPOIndiceROW.ValorIndice
                        Case 11
                            TextBox42.Text = REPOIndiceROW.ValorIndice
                        Case 12
                            TextBox43.Text = REPOIndiceROW.ValorIndice
                        Case 13
                            TextBox17.Text = REPOIndiceROW.ValorIndice
                        Case 14
                            TextBox16.Text = REPOIndiceROW.ValorIndice
                        Case 15
                            TextBox19.Text = REPOIndiceROW.ValorIndice
                        Case 16
                            TextBox18.Text = REPOIndiceROW.ValorIndice

                        Case 17 'Cantidad de Reclamos SIN SEÑAL (Excluidos Corte x Mantenimiento) TAREAS/RED
                            TextBox21.Text = REPOIndiceROW.ValorIndice
                        Case 18 'Cantidad de Reclamos SIN SEÑAL (Excluidos Corte x Mantenimiento) CORRECTIVO/RED
                            TextBox20.Text = REPOIndiceROW.ValorIndice
                        Case 19 'Cantidad de Reclamos SIN SEÑAL (Excluidos Corte x Mantenimiento) TAREAS/MDU
                            TextBox23.Text = REPOIndiceROW.ValorIndice
                        Case 20 'Cantidad de Reclamos SIN SEÑAL (Excluidos Corte x Mantenimiento) CORRECTIVO/RED
                            TextBox22.Text = REPOIndiceROW.ValorIndice

                        Case 21 'Cantidad de Reclamos SIN SEÑAL X MANTENIMIENTO TAREA/RED
                            TextBox33.Text = REPOIndiceROW.ValorIndice
                        Case 22 'Tiempo de corte en reclamos SIN SEÑAL x MANTENIMIENTO TAREA/RED
                            TextBox27.Text = REPOIndiceROW.ValorIndice
                        Case 23 'Tiempo de corte en reclamos SIN SEÑAL x MANTENIMIENTO CORRECTIVO/RED
                            TextBox20.Text = REPOIndiceROW.ValorIndice
                        Case 24 'Tiempo de corte en reclamos SIN SEÑAL x MANTENIMIENTO          
                            TextBox21.Text = REPOIndiceROW.ValorIndice
                        Case 25 ''Porcentaje de tiempo de corte x mantenimiento Vs corte por otras causas

                        Case 26 'Cantidad de Reclamos SIN SEÑAL X MANTENIMIENTO TAREA/MDU
                            TextBox35.Text = REPOIndiceROW.ValorIndice
                        Case 27
                            TextBox25.Text = REPOIndiceROW.ValorIndice
                        Case 28 'Cantidad de Reclamos SIN SEÑAL X MANTENIMIENTO CORRECTIVO/MDU
                            TextBox34.Text = REPOIndiceROW.ValorIndice
                        Case 29

                        Case 30
                            TextBox28.Text = REPOIndiceROW.ValorIndice
                        Case 31
                        Case 32 'Tiempo de corte (Excluido Corte x Mantenimiento  RED
                            TextBox24.Text = REPOIndiceROW.ValorIndice
                        Case 33 'Tiempo de corte (Excluido Corte x Mantenimiento  MDU
                            TextBox30.Text = REPOIndiceROW.ValorIndice
                        Case 34
                        Case 35
                        Case 36 'TOTAL RECLAMOS SS ATENDIDOS
                            Label16.Text = REPOIndiceROW.ValorIndice
                        Case 37 'TOTAL DE RECLAMOS SS ATENDIDOS EN EL DIA O AL SIGUIENTE
                            Label19.Text = REPOIndiceROW.ValorIndice
                        Case 38 'TOTAL DE RECLAMOS SS SOLUCIONADOS DENTRO DEL TIEMPO ACEPTABLE
                            Label31.Text = REPOIndiceROW.ValorIndice
                        Case 39 'Cantidad de Reclamos SS solucionados despues del Tiempo ACEPTABLE pero antes que el Tiempo ADMISIBLE
                            Label33.Text = REPOIndiceROW.ValorIndice
                        Case 40 'Cantidad de reclamos SS solucionados en tiempo mayor que el tiempo ADMISIBLE
                            Label39.Text = REPOIndiceROW.ValorIndice
                        Case 41 'TOTAL RECLAMOS ATENDIDOS
                            Label17.Text = REPOIndiceROW.ValorIndice
                        Case 42 'TOTAL DE RECLAMOS ATENDIDOS EN EL DIA O AL SIGUIENTE
                            Label21.Text = REPOIndiceROW.ValorIndice
                        Case 43 'TOTAL DE RECLAMOS SOLUCIONADOS DENTRO DEL TIEMPO ACEPTABLE
                            Label35.Text = REPOIndiceROW.ValorIndice
                        Case 44 'Cantidad de Reclamos SS solucionados despues del Tiempo ACEPTABLE pero antes que el Tiempo ADMISIBLE
                            Label37.Text = REPOIndiceROW.ValorIndice
                        Case 45 'Cantidad de reclamos SS solucionados en tiempo mayor que el tiempo ADMISIBLE
                            Label42.Text = REPOIndiceROW.ValorIndice

                    End Select
                End If
            Next
        Else
            GB_INFORME1.Visible = False

        End If

    End Sub
    Private Sub BTN_REPORTE_Click(sender As Object, e As EventArgs) Handles BTN_REPORTE.Click
        'TODO: esta línea de código carga datos en la tabla 'INFORME_INDICEDataSet.HistoIndices' Puede moverla o quitarla según sea necesario.
        '  VER_INFORME_INDICE.HistoIndicesTableAdapter.Fill(VER_INFORME_INDICE.histo.HistoIndices)

        VER_INFORME_INDICE.RepoIndicesTableAdapter.FillByInformeID(VER_INFORME_INDICE.INFORME_INDICEDataSet.RepoIndices, INFORMERow.Id)
        'VER_INFORME_INDICE.HistoIndicesTableAdapter.FillByInformeNRO(VER_INFORME_INDICE.INFORME_INDICEDataSet.HistoIndices, ULTIMO_INDICE)

        VER_INFORME_INDICE.Show(Me)
    End Sub
    Private Sub BTN_MATERIALES_Click(sender As Object, e As EventArgs) Handles BTN_MATERIALES.Click
        MATERIALES.TopLevel = False
        MATERIALES.Parent = DASHBOARD.PanelTrabajo
        MATERIALES.Dock = DockStyle.Fill
        MATERIALES.Show()
        MATERIALES.BringToFront()
    End Sub

    'BUSCAR REPETIDO - CORRECCION DE BASE DE DATOS
    Private Sub BTN_BUSCAR_REPETIDOS_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_REPETIDOS.Click
        ORDEN_INT = 1000
        ORDENESTableAdapter.FillByMAYOR_ORDENINT(ORDENESDataSet.ORDENES, dt_desde_repetidos.Value.ToShortDateString)
        PROCESO_BUSQUEDA()
    End Sub
    Public Sub PROCESO_BUSQUEDA()
        For Each ORDEN In ORDENESDataSet.ORDENES
            PROGRESS_BAR("BUSCANDO REPETIDOS", 0, 0, 0, 0, ORDENESDataSet.ORDENES.Rows.Count, VALUE)
            VALUE += 1
            ORDEN_INT = ORDEN.NRO_ORDENINT
            If ORDEN.NRO_ORDINAL <> 0 Then
                Try
                    ORDENESTableAdapter.FillByIDORDINAL(OrdenesDataSet1.ORDENES, ORDEN.NRO_ORDINAL)
                Catch ex As Exception
                    Threading.Thread.Sleep(500)
                    ORDENESTableAdapter.FillByIDORDINAL(OrdenesDataSet1.ORDENES, ORDEN.NRO_ORDINAL)
                End Try
                If OrdenesDataSet1.ORDENES.Rows.Count > 1 Then
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        OrdenesDataSet1.ORDENES.Rows(BindingSource1.Position).Delete()
        ORDENESTableAdapter.Update(OrdenesDataSet1.ORDENES)
    End Sub

    Private Sub BTN_SIGUIENTE_Click(sender As Object, e As EventArgs) Handles BTN_SIGUIENTE.Click
        ORDENESTableAdapter.FillByMAYOR_ORDENINT(ORDENESDataSet.ORDENES, dt_desde_repetidos.Value.ToShortDateString)
        VALUE = 0

        PROCESO_BUSQUEDA()
    End Sub

    Private Sub BTN_REPORTE_SERVICIOS_Click(sender As Object, e As EventArgs) Handles BTN_REPORTE_SERVICIOS.Click
        CALCULAR_SERVICIOS()
        If INFORME_SERVICIOS.Visible Then
            INFORME_SERVICIOS.BringToFront()
        Else
            INFORME_SERVICIOS.Show(Me)
        End If
    End Sub
    Private Sub CALCULAR_SERVICIOS()
        Cursor = Cursors.WaitCursor
        If CB_TIPO_SERVICIOS.Text = "INGRESADOS" Then
            ORDENESTableAdapter.FillBySERVICIOS_INGRESO_ENTRE_FECHAS(ORDENESDataSet.ORDENES, "SERVICIOS", DT_SERVICIO_INICIO.Value, DT_SERVICIO_FIN.Value)
        Else
            ORDENESTableAdapter.FillBySERVICIOS_FIN_ENTRE_FECHAS(ORDENESDataSet.ORDENES, "SERVICIOS", DT_SERVICIO_INICIO.Value, DT_SERVICIO_FIN.Value)
        End If

        ORDENESDataSet.INFORME_SERVICIOS.Clear()
        Dim FECHA_ASIGNADO As Date
        Dim FECHA_FINALIZADO As Date
        Dim TOTAL_DIAS As Long
        Dim NRO_SERVICIO As Integer


        For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
            SERVICIO = ORDENESDataSet.ORDENES.Rows(X)

            If SERVICIO.STATUS <> "CANCELADO" Then
                HISTORICOTableAdapter.FillByORDENINT(ORDENESDataSet.HISTORICO, SERVICIO.NRO_ORDENINT)
                If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
                    NROORDENINT = SERVICIO.NRO_ORDENINT
                    For H = 0 To ORDENESDataSet.HISTORICO.Rows.Count - 1
                        TOTAL_DIAS = 0
                        HISTORICO = ORDENESDataSet.HISTORICO.Rows(H)

                        If HISTORICO.IsSTATUSACTUALNull Then
                            MsgBox("LA ORDEN " & HISTORICO.ID_ORDENINT & " NO TIENE STATUS ACTUAL")
                        Else
                            If HISTORICO.STATUSACTUAL = "ASIGNADO" And HISTORICO.DETALLE = "Edicion Orden" Then
                                Continue For
                            End If
                            Select Case HISTORICO.STATUSACTUAL
                                Case "ASIGNADO"
                                    NEWSERVICIORow = ORDENESDataSet.INFORME_SERVICIOS.NewINFORME_SERVICIOSRow
                                    NEWSERVICIORow.ID_ORDEN = SERVICIO.NRO_ORDENINT
                                    NEWSERVICIORow.ID_ORDEN_OC = SERVICIO.ORDEN_OC
                                    NEWSERVICIORow.NODO_ZONA = SERVICIO.NODO & "/" & SERVICIO.ZONA
                                    If NRO_SERVICIO <> SERVICIO.NRO_ORDENINT Then
                                        If SERVICIO.IsCANTIDAD_SERVICIOSNull = False Then NEWSERVICIORow.CANT_SERVICIOS = SERVICIO.CANTIDAD_SERVICIOS
                                        NEWSERVICIORow.CAUSA = SERVICIO.CAUSARIGEN
                                        NEWSERVICIORow.STATUS_ORDEN = SERVICIO.STATUS
                                    End If
                                    If ORDENESDataSet.HISTORICO.Rows.Count - 4 > 0 Then
                                        NEWSERVICIORow.REITERADO = "SI"
                                    Else
                                        NEWSERVICIORow.REITERADO = "NO"
                                    End If
                                    NEWSERVICIORow.TIPO_STATUS = HISTORICO.STATUSACTUAL
                                    NEWSERVICIORow.FECHA_INICIO = HISTORICO.FECHA
                                    FECHA_ASIGNADO = HISTORICO.FECHA.AddDays(-1).ToShortDateString
                                    '  NEWSERVICIORow.EJECUTANTE = HISTORICO.EJECUTANTE
                                    If SERVICIO.NRO_ORDENINT <> NROORDENINT Then
                                        TOTAL_DIAS = DateDiff(DateInterval.Day, FECHA_FINALIZADO, FECHA_ASIGNADO.AddDays(1))
                                        If TOTAL_DIAS > 3 Then
                                            If TOTAL_DIAS < 8 Then
                                                Select Case FECHA_FINALIZADO.DayOfWeek
                                                    Case 4, 5
                                                        TOTAL_DIAS -= 2
                                                End Select
                                            Else
                                                Select Case FECHA_FINALIZADO.DayOfWeek
                                                    Case 4, 5
                                                        TOTAL_DIAS -= 4
                                                    Case 1, 2, 3
                                                        TOTAL_DIAS -= 2
                                                End Select
                                            End If
                                        End If
                                        NEWSERVICIORow.TIEMPO_DEMORA = TOTAL_DIAS
                                    Else
                                        NEWSERVICIORow.TIEMPO_DEMORA = 0
                                    End If
                                    ORDENESDataSet.INFORME_SERVICIOS.AddINFORME_SERVICIOSRow(NEWSERVICIORow)
                                Case "INICIADO"
                                    NEWSERVICIORow = ORDENESDataSet.INFORME_SERVICIOS.NewINFORME_SERVICIOSRow
                                    NEWSERVICIORow.ID_ORDEN = SERVICIO.NRO_ORDENINT
                                    NEWSERVICIORow.ID_ORDEN_OC = SERVICIO.ORDEN_OC
                                    NEWSERVICIORow.NODO_ZONA = SERVICIO.NODO & "/" & SERVICIO.ZONA
                                    If NRO_SERVICIO <> SERVICIO.NRO_ORDENINT Then
                                        If SERVICIO.IsCANTIDAD_SERVICIOSNull = False Then NEWSERVICIORow.CANT_SERVICIOS = SERVICIO.CANTIDAD_SERVICIOS
                                        NEWSERVICIORow.CAUSA = SERVICIO.CAUSARIGEN
                                        NEWSERVICIORow.STATUS_ORDEN = SERVICIO.STATUS
                                    End If
                                    If ORDENESDataSet.HISTORICO.Rows.Count - 4 > 0 Then
                                        NEWSERVICIORow.REITERADO = "SI"
                                    Else
                                        NEWSERVICIORow.REITERADO = "NO"
                                    End If
                                    NEWSERVICIORow.TIPO_STATUS = "REALIZADO"
                                    NEWSERVICIORow.FECHA_INICIO = HISTORICO.FECHA
                                    'NEWSERVICIORow.EJECUTANTE = HISTORICO.EJECUTANTE
                                    If H < ORDENESDataSet.HISTORICO.Rows.Count - 1 Then
                                        HISTORICO_1 = ORDENESDataSet.HISTORICO.Rows(H + 1)
                                        If HISTORICO_1.STATUSACTUAL = "FINALIZADO" Then
                                            NEWSERVICIORow.FECHA_FIN = HISTORICO_1.FECHA
                                            FECHA_FINALIZADO = HISTORICO_1.FECHA.ToShortDateString
                                            TOTAL_DIAS = DateDiff(DateInterval.Day, FECHA_ASIGNADO, FECHA_FINALIZADO)
                                            If TOTAL_DIAS > 3 Then
                                                If TOTAL_DIAS < 8 Then
                                                    Select Case FECHA_ASIGNADO.DayOfWeek
                                                        Case 3, 4, 5
                                                            TOTAL_DIAS -= 2
                                                    End Select
                                                Else
                                                    Select Case FECHA_ASIGNADO.DayOfWeek
                                                        Case 4, 5
                                                            TOTAL_DIAS -= 4
                                                        Case 1, 2, 3
                                                            TOTAL_DIAS -= 2
                                                    End Select
                                                End If

                                            End If
                                            NEWSERVICIORow.TIEMPO_DEMORA = TOTAL_DIAS
                                        End If
                                    End If
                                    ORDENESDataSet.INFORME_SERVICIOS.AddINFORME_SERVICIOSRow(NEWSERVICIORow)
                                Case "ORDEN REACTIVADA"
                                    If HISTORICO.STATUSANTERIOR = "FINALIZADO" Then
                                        NEWSERVICIORow = ORDENESDataSet.INFORME_SERVICIOS.NewINFORME_SERVICIOSRow
                                        NEWSERVICIORow.ID_ORDEN = SERVICIO.NRO_ORDENINT
                                        NEWSERVICIORow.ID_ORDEN_OC = SERVICIO.ORDEN_OC
                                        NEWSERVICIORow.NODO_ZONA = SERVICIO.NODO & "/" & SERVICIO.ZONA
                                        If NRO_SERVICIO <> SERVICIO.NRO_ORDENINT Then
                                            If SERVICIO.IsCANTIDAD_SERVICIOSNull = False Then NEWSERVICIORow.CANT_SERVICIOS = SERVICIO.CANTIDAD_SERVICIOS
                                            NEWSERVICIORow.CAUSA = SERVICIO.CAUSARIGEN
                                            NEWSERVICIORow.STATUS_ORDEN = SERVICIO.STATUS
                                        End If
                                        If ORDENESDataSet.HISTORICO.Rows.Count - 4 > 0 Then
                                            NEWSERVICIORow.REITERADO = "SI"
                                        Else
                                            NEWSERVICIORow.REITERADO = "NO"
                                        End If
                                        NEWSERVICIORow.TIPO_STATUS = HISTORICO.STATUSACTUAL
                                        NEWSERVICIORow.FECHA_INICIO = HISTORICO.FECHA
                                        'NEWSERVICIORow.EJECUTANTE = HISTORICO.EJECUTANTE
                                        FECHA_ASIGNADO = HISTORICO.FECHA.ToShortDateString
                                        If FECHA_FINALIZADO = FECHA_ASIGNADO Then
                                            NEWSERVICIORow.TIEMPO_DEMORA = 0
                                        Else
                                            TOTAL_DIAS = DateDiff(DateInterval.Day, FECHA_FINALIZADO, FECHA_ASIGNADO.AddDays(1))
                                            If TOTAL_DIAS > 3 Then
                                                If TOTAL_DIAS < 8 Then
                                                    Select Case FECHA_ASIGNADO.DayOfWeek
                                                        Case 3, 4, 5
                                                            TOTAL_DIAS -= 2
                                                    End Select
                                                Else
                                                    Select Case FECHA_ASIGNADO.DayOfWeek
                                                        Case 4, 5
                                                            TOTAL_DIAS -= 4
                                                        Case 1, 2, 3
                                                            TOTAL_DIAS -= 2
                                                    End Select
                                                End If
                                            End If
                                            NEWSERVICIORow.TIEMPO_DEMORA = TOTAL_DIAS
                                        End If
                                        ORDENESDataSet.INFORME_SERVICIOS.AddINFORME_SERVICIOSRow(NEWSERVICIORow)
                                    End If
                            End Select
                            NRO_SERVICIO = SERVICIO.NRO_ORDENINT
                            NROORDENINT = HISTORICO.ID_ORDENINT
                        End If
                    Next
                Else
                    MsgBox("NO SE ENCONTRO HISTORICO PARA LA ORDEN " & SERVICIO.NRO_ORDENINT)
                End If
            End If
        Next

        Cursor = Cursors.Default
    End Sub

    Private Sub BTN_EXCEL_Click(sender As Object, e As EventArgs) Handles BTN_EXCEL.Click
        Cursor = Cursors.WaitCursor
        'CALCULAR_SERVICIOS()
        ORDENESDataSet.INFORME_SERVICIOS.Clear()
        ORDENESTableAdapter.FillBySERVICIOS(ORDENESDataSet.ORDENES)
        LISTAR_ORDENES()
        ExportarExcel(ORDENESDataSet.INFORME_SERVICIOS, "REPORTE DE SERVICIOS")
        DGVOBRACIVIL.DataSource = ORDENESDataSet.INFORME_SERVICIOS
        DGVOBRACIVIL.Visible = True
        Cursor = Cursors.Default
    End Sub
    Private Sub LISTAR_ORDENES()
        Cursor = Cursors.WaitCursor
        For S = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
            PROGRESS_BAR(TIPO_MENSAJE, 0, 0, 0, 0, ORDENESDataSet.ORDENES.Rows.Count, S + 1)
            SERVICIO = ORDENESDataSet.ORDENES.Rows(S)
            HISTORICOTableAdapter.FillBySERVICIOS_REACTIVADOS(ORDENESDataSet.HISTORICO, SERVICIO.NRO_ORDENINT)
            NEWSERVICIORow = ORDENESDataSet.INFORME_SERVICIOS.NewINFORME_SERVICIOSRow
            NEWSERVICIORow.ID_ORDEN = SERVICIO.NRO_ORDENINT
            OBESERVACIONESTableAdapter.FillByORDENINT(ORDENESDataSet.OBESERVACIONES, SERVICIO.NRO_ORDENINT)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                NEWSERVICIORow.OBSERVACIONES = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
            End If

            If SERVICIO.IsFECHA_ASIGNADANull = False Then NEWSERVICIORow.FECHA_INICIO = SERVICIO.FECHA_ASIGNADA.ToShortDateString Else NEWSERVICIORow.FECHA_INICIO = SERVICIO.FECHASOL.ToShortDateString
            If SERVICIO.STATUS = "FINALIZADO" Then NEWSERVICIORow.FECHA_FIN = SERVICIO.FECHAFIN.ToShortDateString
            NEWSERVICIORow.TIPO_STATUS = SERVICIO.MOTIVOORIGEN
            NEWSERVICIORow.CAUSA = SERVICIO.CAUSARIGEN
            If SERVICIO.IsCANTIDAD_SERVICIOSNull = False Then NEWSERVICIORow.CANT_SERVICIOS = SERVICIO.CANTIDAD_SERVICIOS Else NEWSERVICIORow.CANT_SERVICIOS = "N/D"
            If SERVICIO.IsORDEN_OCNull = False Then NEWSERVICIORow.ID_ORDEN_OC = SERVICIO.ORDEN_OC Else NEWSERVICIORow.ID_ORDEN_OC = "N/D"
            NEWSERVICIORow.NODO_ZONA = SERVICIO.NODO & "/" & SERVICIO.ZONA
            If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
                NEWSERVICIORow.REITERADO = "SI"
            End If
            NEWSERVICIORow.VECES_REITREADOS = ORDENESDataSet.HISTORICO.Rows.Count
            NEWSERVICIORow.STATUS_ORDEN = SERVICIO.STATUS
            ORDENESDataSet.INFORME_SERVICIOS.AddINFORME_SERVICIOSRow(NEWSERVICIORow)
        Next
        Cursor = Cursors.Default

    End Sub

    Private Sub BTN_OBRA_CIVIL_PENDIENTES_Click(sender As Object, e As EventArgs) Handles BTN_OBRA_CIVIL_PENDIENTES.Click
        Cursor = Cursors.WaitCursor
        ORDENESDataSet.TOBRAS.Clear()
        TRABAJOSTableAdapter.FillByASIGNADOA(ORDENESDataSet.TRABAJOS, "GERARDO BOTTI")
        Dim TOBRARow As ORDENESDataSet.TRABAJOSRow
        Dim NEWOBRARow As ORDENESDataSet.TOBRASRow
        Dim TGESTION As ORDENESDataSet.GESTIONRow

        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                TOBRARow = ORDENESDataSet.TRABAJOS.Rows(X)
                PROGRESS_BAR("ANALIZANDO TRABAJOS OC", 0, 0, ORDENESDataSet.TRABAJOS.Rows.Count, X + 1, 0, 0)
                If TOBRARow.STATUS <> "FINALIZADO" Or TOBRARow.STATUS <> "CANCELADO" Then
                    GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, TOBRARow.ID_GESTION)
                    TGESTION = ORDENESDataSet.GESTION.Rows(0)
                    NEWOBRARow = ORDENESDataSet.TOBRAS.NewTOBRASRow()
                    NEWOBRARow.GESTION = TGESTION.Id_GESTION
                    NEWOBRARow.NODO = TOBRARow.NODO
                    NEWOBRARow.ZONA = TOBRARow.ZONA
                    NEWOBRARow.GESTION_TIPO = TGESTION.TIPOGESTION
                    NEWOBRARow.GESTION_AREA = TGESTION.AREA
                    NEWOBRARow.SOLICITADO_X = TGESTION.SOLICITANTE
                    NEWOBRARow.GESTION_FECHAING = TGESTION.FECHAINGRESADA.ToShortDateString
                    NEWOBRARow.DIRECCION = "'" & TOBRARow.CALLE & "  " & TOBRARow.NRO
                    NEWOBRARow.TRABAJO_STATUS = TOBRARow.STATUS

                    HISTORICOTableAdapter.FillByIDTRABAJO_ASIG_RESPONSABLE(ORDENESDataSet.HISTORICO, TOBRARow.Id_TRABAJO)
                    If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
                        NEWOBRARow.TRABAJO_FASIGNADO = CDate(ORDENESDataSet.HISTORICO.Rows(0).Item("FECHA")).ToShortDateString
                        NEWOBRARow.ASIGNADO_X = ORDENESDataSet.HISTORICO.Rows(0).Item("EJECUTANTE")
                    End If
                    ORDENESDataSet.TOBRAS.AddTOBRASRow(NEWOBRARow)
                End If
            Next
        End If
        DGVOBRACIVIL.DataSource = ORDENESDataSet.TOBRAS
        DGVOBRACIVIL.Visible = True
        ExportarExcel(ORDENESDataSet.TOBRAS, "REPORTE DE OBRAS")
        Cursor = Cursors.Default
    End Sub

    Private Sub BTN_LISTAR_ORDENES_Click(sender As Object, e As EventArgs) Handles BTN_LISTAR_ORDENES.Click
        ORDENESDataSet.INFORME_SERVICIOS.Clear()
        If CK_SERVICIOS.Checked Then
            ORDENESTableAdapter.FillBySERVICIOS(ORDENESDataSet.ORDENES)
            TIPO_MENSAJE = "ANALIZANDO SERVICIOS"
            LISTAR_ORDENES()
        End If
        If CK_DISENO_RED.Checked Then
            ORDENESTableAdapter.FillByDISEÑORED(ORDENESDataSet.ORDENES)
            TIPO_MENSAJE = "ANALIZANDO DISEÑOS DE RED"
            LISTAR_ORDENES()
        End If
        If CK_DISENO_OC.Checked Then
            ORDENESTableAdapter.FillByDISEÑO_OC(ORDENESDataSet.ORDENES)
            TIPO_MENSAJE = "ANALIZANDO DISEÑOS OC"
            LISTAR_ORDENES()
        End If
        If CK_ACT_PLANOS.Checked Then
            ORDENESTableAdapter.FillByACT_PLANOS(ORDENESDataSet.ORDENES)
            TIPO_MENSAJE = "ANALIZANDO ACTUALIZACIONES DE PLANOS"
            LISTAR_ORDENES()
        End If
        DGVOBRACIVIL.DataSource = ORDENESDataSet.INFORME_SERVICIOS
        DGVOBRACIVIL.Visible = True
        ExportarExcel(ORDENESDataSet.INFORME_SERVICIOS, "REPORTE DISEÑOS, SERVICIOS Y ACT DE PLANOS")
    End Sub

    Private Sub BTN_TRABAJAR_ORDENES_Click(sender As Object, e As EventArgs) Handles BTN_TRABAJAR_ORDENES.Click
        If ORDEN.Visible Then
            ORDEN.BringToFront()
        Else
            ORDEN.TopLevel = False
            ORDEN.Parent = DASHBOARD.PanelTrabajo
            ORDEN.Dock = DockStyle.Fill
            ORDEN.Show()
            ORDEN.BringToFront()
        End If
    End Sub





    'Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
    '    If Int(TextBox6.Text) <= Int((TIE_MAX_OPT_97Label1.Text)) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(4) = "SI"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(4) = "SI"
    '        TextBox6.BackColor = Color.LightGreen
    '    ElseIf Int(TextBox6.Text) > Int((TIE_MAX_OPT_97Label1.Text)) And Int(TextBox6.Text) <= Int((TIE_MAX_MAX_97Label1.Text)) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(4) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(4) = "SI"
    '        TextBox6.BackColor = Color.Gold
    '    Else
    '        NUEVO_INDICE.CUMPLE_IND_OPT(4) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(4) = "NO"
    '        TextBox6.BackColor = Color.LightCoral
    '    End If
    'End Sub
    'Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
    '    'Evalua el cumplimiento del tiempo máximo para reclamos de Cualquier Tipo
    '    If Int(TextBox7.Text) <= Int((TIE_MAX_OPT_ALLLabel1.Text)) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(5) = "SI"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(5) = "SI"
    '        TextBox7.BackColor = Color.LightGreen
    '    ElseIf Int(TextBox7.Text) > Int((TIE_MAX_OPT_97Label1.Text)) And Int(TextBox7.Text) <= Int((TIE_MAX_MAX_ALLLabel1.Text)) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(5) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(5) = "SI"
    '        TextBox7.BackColor = Color.Gold
    '    Else
    '        NUEVO_INDICE.CUMPLE_IND_OPT(5) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(5) = "NO"
    '        TextBox7.BackColor = Color.LightCoral
    '    End If
    'End Sub
    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    'Evalua el cumplimiento del indice Nro 1 (Porcentaje de Sin Señal en el dia o al otro dia)
    '    If Val(TextBox1.Text) >= Val(PER_97_OPTLabel1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(1) = "SI"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(1) = "SI"
    '        TextBox1.BackColor = Color.LightGreen
    '    ElseIf Val(TextBox1.Text) < Val(PER_97_OPTLabel1.Text) And Val(TextBox1.Text) >= Val(PER_97_MINLabel1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(1) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(1) = "SI"
    '        TextBox1.BackColor = Color.Gold
    '    Else
    '        NUEVO_INDICE.CUMPLE_IND_OPT(1) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(1) = "NO"
    '        TextBox1.BackColor = Color.LightCoral
    '    End If
    'End Sub
    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    '    'Evalua el cumplimiento del indice Nro 1 (Porcentaje de RECLAMOS DE CUALQUIER TIPO en el dia o al otro dia)
    '    If Val(TextBox2.Text) >= Val(PER_ALL_OPTLabel1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(2) = "SI"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(2) = "SI"
    '        TextBox2.BackColor = Color.LightGreen
    '    ElseIf Val(TextBox2.Text) < Val(PER_ALL_OPTLabel1.Text) And Val(TextBox2.Text) >= Val(PER_ALL_MINLabel1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(2) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(2) = "SI"
    '        TextBox2.BackColor = Color.Gold
    '    Else
    '        NUEVO_INDICE.CUMPLE_IND_OPT(2) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(2) = "NO"
    '        TextBox2.BackColor = Color.LightCoral
    '    End If
    'End Sub
    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    '    'Evalua el cumplimiento del tiempo promedio de solucion de los reclamos del tipo sin señal
    '    If TimeValue(TextBox3.Text) <= TimeValue(TIE_PROM_OPT_97Label1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(3) = "SI"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(3) = "SI"
    '        TextBox3.BackColor = Color.LightGreen
    '    ElseIf TimeValue(TextBox3.Text) > TimeValue(TIE_PROM_OPT_97Label1.Text) And TimeValue(TextBox3.Text) <= TimeValue(TIE_PROM_MAX_97Label1.Text) Then
    '        NUEVO_INDICE.CUMPLE_IND_OPT(3) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(3) = "SI"
    '        TextBox2.BackColor = Color.Gold
    '    Else
    '        NUEVO_INDICE.CUMPLE_IND_OPT(3) = "NO"
    '        NUEVO_INDICE.CUMPLE_IND_ACEP(3) = "NO"
    '        TextBox2.BackColor = Color.LightCoral
    '    End If
    'End Sub
End Class