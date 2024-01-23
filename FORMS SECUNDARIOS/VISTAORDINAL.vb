Public Class VISTAORDINAL

    Dim MENSAJESRow As DataRow
    Dim FALLARow As DataRow
    Dim CAUSARow As DataRow
    Dim SECTORRow As DataRow
    Dim FUNCIONARIORow As DataRow
    Dim ORDENRow As ORDENESDataSet.ORDENESRow
    Dim OBSERVACIONESRow As DataRow
    Dim TAREASRow As DataRow
    Dim GESTIONRow As DataRow
    Dim TRABAJORow As DataRow

    'Dim NewHISTORICORow As ORDENESDataSet.HISTORICORow
    'Dim NewMENSAJE As ORDENESDataSet.MENSAJERIARow
    Dim NewORDENRow As ORDENESDataSet.ORDENESRow
    Dim NewOBSERVACIONESRow As ORDENESDataSet.OBESERVACIONESRow
    Dim NewTAREASRow As ORDENESDataSet.TAREASRow
    Dim NewADJUNTORow As ORDENESDataSet.ADJUNTOSRow

    'VARIABLES PARA DULICACION DE ORDENES
    Dim DUP_NRO_ORDENINT As Integer
    Dim DUP_NRO_ORDINAL As Integer
    Dim DUP_FECHAAGEND As Date
    Dim DUP_TESTIMADO As Integer
    Dim DUP_ID_GESTION As Integer
    Dim DUP_ID_TRABAJO As Integer
    Dim DUP_TIPO As String
    Dim DUP_SECTOROPE As String
    Dim DUP_SECTORDESTINO As String
    Dim DUP_SECTORGEN As String
    Dim DUP_RECURSO As String
    Dim DUP_SUBRED As String
    Dim DUP_FECHASOL As Date
    Dim DUP_GEST_SOL As String = ""

    Dim DUP_PRIORIDAD As String
    Dim DUP_NODO As String
    Dim DUP_ZONA As String
    Dim DUP_IDCALLE As String
    Dim DUP_CALLE As String
    Dim DUP_NRO As String
    Dim DUP_MANZANA As String

    Dim DUP_MOTIVOORIGEN As String
    Dim DUP_CAUSARIGEN As String
    Dim DUP_INSTALACION As String
    Dim DUP_INSTALACIONRUS As String
    Dim DUP_CARPETA As String

    Dim DUP_INICIOEST As Date
    Dim DUP_TPREVISTO As Integer
    Dim DUP_DUPLICADADE As Integer
    Dim DUP_DUPLICADAA As Integer
    Dim NUM_ORDENDUPLICADA As Integer
    Dim NUM_ORDENADUPLICAR As Integer
    Dim DUP_PROYECTO As Integer

    Dim DUP_TAREADESC(50) As String
    Dim DUP_TAREACANTSTD(50) As Integer
    Dim DUP_TAREATIEMPOSTD(50) As Integer
    Dim DUP_TAREAUNIDAD(50) As String
    Dim DUP_TAREATIEMPOPREV(50) As Integer

    Dim DUP_DEPENDENCIA As Integer
    Dim DUP_TIPODEP As String
    Dim DUP_CLASEDEP As String
    Dim DUP_ORDENDEP As Integer
    Dim DUP_AFECTACION As String

    'Dim HIS_STATUSACTUAL As String
    'Dim HIS_CAUSA As String
    'Dim HIS_DETALLE As String

    'Dim MJE_ASUNTO As String
    'Dim MJE_DESTINONOMBRE As String
    'Dim MJE_DESTINOSECTOR As String
    'Dim MJE_MENSAJE As String
    'Dim MJE_NROORDENASOC As String



    Private Sub VISTAORDINAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PROCESOS.Text = "BUSCANDO ORDEN"
        PROCESOS.Refresh()

        'CARGA EL ROW DE LA ORDEN SELECCIONADO EN EL FORMAULARIO ANTERIOR
        Me.ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, NROORDENINT)
        ORDENRow = ORDENESDataSet.ORDENES.Rows(0)

        'CARGA LOS DATOS DE LA ORDEN
        PROCESOS.Text = "CARGANDO DATOS DE ORDEN"
        PROCESOS.Refresh()


        COMB_STATUS.Text = ORDENRow("STATUS")
        COMB_STATUS.Refresh()

        PROCESOS.Text = "BUSCANDO GESTION Y TRABAJO"
        PROCESOS.Refresh()

        'CARGA LOS DATOS DE GESTION Y TRABAJO DE LA ORDEN SELECCIONADA EN EL FORM ANTERIOR
        Me.GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, ORDENRow("ID_GESTION"))
        Me.TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ORDENRow("Id_TRABAJO"))
        PROCESOS.Text = "CARGANDO FUNCIONARIOS"
        PROCESOS.Refresh()


        'CARGA LOS FUNCIONARIOS DEL SECTOR OPERATIVO QUE FIGURA EN LA ORDEN
        Me.FUNCIONARIOSTableAdapter.FillBySECTOR(ORDENESDataSet.FUNCIONARIOS, DATOS.ORDSECTOROPE)

        If ORDENESDataSet.FUNCIONARIOS.Rows.Count > 0 Then
            For I = 0 To ORDENESDataSet.FUNCIONARIOS.Rows.Count - 1
                FUNCIONARIORow = ORDENESDataSet.FUNCIONARIOS.Rows(I)
            Next I
        End If

        PROCESOS.Text = "INICIALIZA ACCIONES"
        PROCESOS.Refresh()

        'FIJA LAS INICIALIZACIONES DE ACUERDO AL STATUS DE LA ORDEN A VISUALIZAR

        COMB_STATUS.Items.Clear()
        COMB_FALLACIERRE.Items.Clear()
        COMB_CAUSACIERRE.Items.Clear()

        COMB_STATUS.Refresh()
        COMB_FALLACIERRE.Refresh()
        COMB_CAUSACIERRE.Refresh()

        Select Case Trim(ORDENRow("STATUS"))

            Case "FINALIZADO", "CANCELADO"
                COMB_FALLACIERRE.Text = DATOS.ORDFALLACIERRE
                COMB_CAUSACIERRE.Text = DATOS.ORDCAUSACIERRE
                If SECTOR = "SUPERVISION" Or SECTOR = "PLANIFICACION TECNICA" Then
                    OBS_INGRESO.ReadOnly = True
                    COMB_CAUSACIERRE.Enabled = False
                    COMB_FALLACIERRE.Enabled = False
                    BOT_GUARDARORD.Visible = True
                    LBL_GUARDAR.Visible = True
                Else
                    BOT_GUARDARORD.Visible = False
                    LBL_GUARDAR.Visible = False
                End If
                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False
                LBLObsOrigenOrdinal.Visible = True
                TXTOrigenOrdinal.Visible = True

            Case "INGORDINAL"

                COMB_FALLACIERRE.Text = DATOS.ORDFALLACIERRE
                COMB_CAUSACIERRE.Text = DATOS.ORDCAUSACIERRE

                'BOT_GUARDARORD.Visible = False
                'LBL_GUARDAR.Visible = False

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False


            Case "INGRESADOINT"
                'COMB_STATUS.Items.Add("INICIADO")
                COMB_STATUS.Items.Add("CANCELADO")

                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

                Me.SECTORESTableAdapter.FillByORDENADO(ORDENESDataSet.SECTORES)
                For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
                    SECTORRow = ORDENESDataSet.SECTORES.Rows(I)

                Next I

            Case "RUTEADO"
                'COMB_STATUS.Items.Add("INICIADO")
                COMB_STATUS.Items.Add("CANCELADO")
                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

                Me.SECTORESTableAdapter.FillByORDENADO(ORDENESDataSet.SECTORES)
                For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
                    SECTORRow = ORDENESDataSet.SECTORES.Rows(I)

                Next I

            Case "AGENDADO"
                'COMB_STATUS.Items.Add("INICIADO")
                COMB_STATUS.Items.Add("CANCELADO")

                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

                Me.SECTORESTableAdapter.FillByORDENADO(ORDENESDataSet.SECTORES)
                For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
                    SECTORRow = ORDENESDataSet.SECTORES.Rows(I)
                Next I

            Case "INICIADO"
                'BUSCA Y AGREGA LAS FALLAS DE CIERRE CORRESPONDIENTES AL SECTOR OPERATIVO
                Me.SECTORFALLATableAdapter.FillBySECTORCIERRE(ORDENESDataSet.SECTORFALLA, DATOS.ORDSECTOROPE)
                If ORDENESDataSet.SECTORFALLA.Rows.Count > 0 Then
                    For I = 0 To ORDENESDataSet.SECTORFALLA.Rows.Count - 1
                        FALLARow = ORDENESDataSet.SECTORFALLA.Rows(I)
                        COMB_FALLACIERRE.Items.Add(FALLARow("FALLA"))
                    Next I
                End If

                COMB_STATUS.Text = "SELECCIONE"

                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                COMB_STATUS.Items.Add("FINALIZADO")
                COMB_STATUS.Items.Add("CANCELADO")

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

            Case "ASIGNADO"
                'COMB_STATUS.Items.Add("INICIADO")
                COMB_STATUS.Items.Add("CANCELADO")

                Me.SECTORESTableAdapter.FillByORDENADO(ORDENESDataSet.SECTORES)
                For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
                    SECTORRow = ORDENESDataSet.SECTORES.Rows(I)
                Next I

                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

            Case "COORDINADO"
                ' COMB_STATUS.Items.Add("INICIADO")
                COMB_STATUS.Items.Add("CANCELADO")

                Me.SECTORESTableAdapter.FillByORDENADO(ORDENESDataSet.SECTORES)
                For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
                    SECTORRow = ORDENESDataSet.SECTORES.Rows(I)
                Next I


                COMB_FALLACIERRE.Text = ""
                COMB_CAUSACIERRE.Text = ""

                BOT_GUARDARORD.Visible = True
                LBL_GUARDAR.Visible = True

                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False

            Case "ADUPLICAR"
                COMB_STATUS.Items.Add("CANCELADO")

                COMB_FALLACIERRE.Text = DATOS.ORDFALLACIERRE
                COMB_CAUSACIERRE.Text = DATOS.ORDCAUSACIERRE

                BOT_GUARDARORD.Visible = False
                LBL_GUARDAR.Visible = False
                BOT_DUPLICAR.Visible = True
                LBL_DUPLICAR.Visible = True
                LBLObsOrigenOrdinal.Visible = True
                TXTOrigenOrdinal.Visible = True
            Case "DUPLICADO"

                COMB_FALLACIERRE.Text = DATOS.ORDFALLACIERRE
                COMB_CAUSACIERRE.Text = DATOS.ORDCAUSACIERRE

                BOT_GUARDARORD.Visible = False
                LBL_GUARDAR.Visible = False
                BOT_DUPLICAR.Visible = False
                LBL_DUPLICAR.Visible = False
                LBLObsOrigenOrdinal.Visible = True
                TXTOrigenOrdinal.Visible = True
        End Select

        COMB_FALLACIERRE.Refresh()
        COMB_CAUSACIERRE.Refresh()
        BOT_GUARDARORD.Refresh()
        BOT_DUPLICAR.Refresh()

        'ACHICA EL ALTO DE LAS FILAS DE LA TABLA DE TAREAS
        For i = 0 To ORDENESDataSet.TAREAS.Rows.Count - 1
            TAREASDataGridView.Rows(i).Height = 18
        Next i

        'FIJA EL ALTO DE LA TABLA DE ADJUNTOS

        PROCESOS.Text = "CARGANDO OBSERVACIONES Y TAREAS"
        PROCESOS.Refresh()


        'SELECCIONA LA MANERA DE BUSCAR LAS TAREAS Y OBSERVACIONES DE ACUERDO AL STATUS Y SI TIENE O NO ORDINAL___________
        Select Case ORDENRow("STATUS")
            Case "FINALIZADO"
                If NROORDINAL = 0 Then
                    Me.TAREASTableAdapter.FillByNROORDENINT(Me.ORDENESDataSet.TAREAS, NROORDENINT)
                Else
                    Me.TAREASTableAdapter.FillByORDINAL(ORDENESDataSet.TAREAS, NROORDINAL)
                End If
            Case "ADUPLICAR"
                Me.TAREASTableAdapter.FillByADUPLICAR(Me.ORDENESDataSet.TAREAS, NROORDENINT)
        End Select
        OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, NROORDENINT)
        'CARGA LAS OBSERVACIONES SI LAS HAY
        If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
            OBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.Rows(0)
            For x = 0 To ORDENESDataSet.OBESERVACIONES.Rows.Count - 1
                If ORDENESDataSet.OBESERVACIONES.Rows(x).Item("NROORDINAL") = 0 Then
                    If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSORIGEN")) = False Then OBS_INGRESO.Text = ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSORIGEN")
                    If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSCIERRE")
                Else
                    If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSORIGEN")) = False Then TXTOrigenOrdinal.Text = ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSORIGEN")
                    If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(x).Item("OBSCIERRE")

                End If
            Next
        Else
            OBESERVACIONESTableAdapter.FillByORDINAL(ORDENESDataSet.OBESERVACIONES, NROORDINAL)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")) = False Then TXTOrigenOrdinal.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")
            End If
        End If
        '__________________________________________________________________________________________________________________

        DATOS.Cursor = DefaultCursor

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'BOTON DE CERRAR FORMULARIO, RECARGA LAS ORDENES EN EL FORMULARIO DE GESTION CON LOS DATOS ACTUALIZADOS
        DATOS.Enabled = True
        Me.Close()
    End Sub
    'Private Sub COMB_SECTOROPE_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Me.COMB_FALLACIERRE.Items.Clear()
    '    If ORDENESDataSet.FUNCIONARIOS.Rows.Count > 0 Then
    '        For I = 0 To ORDENESDataSet.FUNCIONARIOS.Rows.Count - 1
    '            FUNCIONARIORow = ORDENESDataSet.FUNCIONARIOS.Rows(I)

    '        Next I
    '    End If
    'End Sub
    Private Sub COMB_STATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMB_STATUS.SelectedIndexChanged
        If COMB_STATUS.Text = "FINALIZADO" Then
            If ORDENESDataSet.SECTORFALLA.Rows.Count > 0 Then
                COMB_FALLACIERRE.Items.Clear()
                For I = 0 To ORDENESDataSet.SECTORFALLA.Rows.Count - 1
                    FALLARow = ORDENESDataSet.SECTORFALLA.Rows(I)
                    COMB_FALLACIERRE.Items.Add(FALLARow("FALLA"))
                Next I
            End If
        End If
    End Sub
    Private Sub CARGA_ORDENADUPLICAR()

        'CARGA EL NUMERO DE LA ORDEN QUE VA A SER DUPLICADA PARA EDITARLA Y CARGARLE EL NRO DE ORDEN A LA CUAL SE DUPLICO
        NUM_ORDENADUPLICAR = ORDENRow("NRO_ORDENINT")

        DUP_ID_GESTION = ORDENRow("ID_GESTION")
        DUP_ID_TRABAJO = ORDENRow("ID_TRABAJO")
        DUP_TIPO = ORDENRow("TIPO")
        DUP_SECTOROPE = ORDENRow("SECTOROPE")
        DUP_SECTORDESTINO = ORDENRow("SECTORDESTINO")
        DUP_SECTORGEN = ORDENRow("SECTORGEN")
        DUP_RECURSO = ORDENRow("RECURSO")
        DUP_FECHASOL = ORDENRow("FECHASOL")
        If IsDBNull(ORDENRow("ATRIBUTO")) = False Then
            If ORDENRow("ATRIBUTO") = "" Then
                DUP_SUBRED = "HFC"
            Else
                DUP_SUBRED = ORDENRow("ATRIBUTO")
            End If
        Else
            DUP_SUBRED = "HFC"
        End If
        DUP_PRIORIDAD = ORDENRow("PRIORIDAD")
        DUP_NODO = ORDENRow("NODO")
        DUP_IDCALLE = ORDENRow("ID_CALLE")
        DUP_ZONA = ORDENRow("ZONA")
        DUP_CALLE = ORDENRow("CALLE")
        DUP_NRO = ORDENRow("NRO")
        DUP_MANZANA = ORDENRow("MANZANA")
        If ORDENRow.IsGEST_SOLICITADONull = False Then DUP_GEST_SOL = ORDENRow.GEST_SOLICITADO
        DUP_DEPENDENCIA = 0
        DUP_TIPODEP = "IND"
        DUP_CLASEDEP = "IND"
        DUP_ORDENDEP = 0
        If ORDENRow.IsPROYECTO_ORDINALNull = False Then DUP_PROYECTO = ORDENRow.PROYECTO_ORDINAL Else DUP_PROYECTO = 0
        DUP_MOTIVOORIGEN = ORDENRow("MOTIVOORIGEN")
        If Trim(ORDENRow("CAUSARIGEN")) = "CONSTRUCCION DE EDIFICIOS" Then
            DUP_CAUSARIGEN = "OBRA NUEVA"
        Else
            DUP_CAUSARIGEN = ORDENRow("CAUSARIGEN")
        End If


        If IsDBNull(ORDENRow("INSTALACIONRUS")) = False Then DUP_INSTALACIONRUS = ORDENRow("INSTALACIONRUS")
        If IsDBNull(ORDENRow("INSTALACION")) = False Then DUP_INSTALACION = ORDENRow("INSTALACION")

        If IsDBNull(ORDENRow("CARPETA")) = False Then
            DUP_CARPETA = ORDENRow("CARPETA")
        End If
        If IsDBNull(ORDENRow("AFECTACION")) = False Then DUP_AFECTACION = ORDENRow("AFECTACION")
        If IsDBNull(ORDENRow("TPREVISTO")) = False Then DUP_TPREVISTO = ORDENRow("TPREVISTO")

        If IsDBNull(ORDENRow("FECHAINICESTIMADO")) = False Then
            DUP_INICIOEST = ORDENRow("FECHAINICESTIMADO")
        Else
            DUP_INICIOEST = Now.ToShortDateString
        End If

        DUP_TESTIMADO = ORDENRow("TESTIMADO")
        DUP_TPREVISTO = ORDENRow("TPREVISTO")
        DUP_DUPLICADADE = ORDENRow("NRO_ORDENINT")
        DUP_DUPLICADAA = 0

    End Sub
    Private Sub CARGA_ORDENDUPLICADA()
        NewORDENRow = ORDENESDataSet.ORDENES.NewORDENESRow
        NewORDENRow("NRO_ORDINAL") = 0
        NewORDENRow("ID_GESTION") = DUP_ID_GESTION
        NewORDENRow("ID_TRABAJO") = DUP_ID_TRABAJO
        NewORDENRow("TIPO") = DUP_TIPO
        NewORDENRow("SECTOROPE") = DUP_SECTOROPE
        NewORDENRow("SECTORDESTINO") = DUP_SECTORDESTINO
        NewORDENRow("SECTORGEN") = DUP_SECTORGEN
        NewORDENRow("RECURSO") = DUP_RECURSO
        NewORDENRow("FECHASOL") = DUP_FECHASOL
        NewORDENRow("ATRIBUTO") = DUP_SUBRED
        NewORDENRow("PRIORIDAD") = DUP_PRIORIDAD

        NewORDENRow("NODO") = DUP_NODO
        NewORDENRow("ID_CALLE") = DUP_IDCALLE
        NewORDENRow("ZONA") = DUP_ZONA
        NewORDENRow("CALLE") = DUP_CALLE
        NewORDENRow("NRO") = DUP_NRO
        NewORDENRow("MANZANA") = DUP_MANZANA
        NewORDENRow.GEST_SOLICITADO = DUP_GEST_SOL
        NewORDENRow("DEPENDENCIA") = DUP_DEPENDENCIA
        NewORDENRow("TIPODEP") = DUP_TIPODEP
        NewORDENRow("CLASEDEP") = DUP_CLASEDEP
        NewORDENRow("ORDENDEP") = DUP_ORDENDEP
        NewORDENRow.PROYECTO_ORDINAL = DUP_PROYECTO

        NewORDENRow("MOTIVOORIGEN") = DUP_MOTIVOORIGEN
        NewORDENRow("CAUSARIGEN") = DUP_CAUSARIGEN
        NewORDENRow("ORDORIGEN") = 0
        NewORDENRow("INSTALACION") = DUP_INSTALACION
        NewORDENRow("INSTALACIONRUS") = DUP_INSTALACIONRUS
        NewORDENRow("CARPETA") = DUP_CARPETA
        NewORDENRow("TPREVISTO") = DUP_TPREVISTO
        NewORDENRow("TESTIMADO") = DUP_TESTIMADO
        NewORDENRow("FECHAINICESTIMADO") = DUP_INICIOEST
        NewORDENRow("DUPLICADADE") = DUP_DUPLICADADE
        NewORDENRow("AFECTACION") = DUP_AFECTACION
        NewORDENRow("FECHAINGRESO") = Now.ToShortDateString
        NewORDENRow("GENERADOR") = NOMBRE & " " & APELLIDO
        NewORDENRow("STATUS") = "INGRESADOINT"

        ORDENESDataSet.ORDENES.AddORDENESRow(NewORDENRow)
        ORDENESTableAdapter.Update(NewORDENRow)
    End Sub
    Private Sub BOT_GUARDARORD_Click(sender As Object, e As EventArgs) Handles BOT_GUARDARORD.Click
        Cursor = Cursors.WaitCursor
        If COMB_STATUS.Text = "SELECCIONE" Then
            MsgBox("SELECCIONE UN STATUS PARA LA ORDEN")
            Cursor = DefaultCursor
            COMB_STATUS.Focus()
            Exit Sub
        End If
        DATOS.DATOS_STATUSANT = ORDENRow("STATUS")
        'GUARDA TODOS LOS CAMBIOS HECHOS EN LA ORDEN SALVO LAS ASIGNACIONES Y AGENDAMIENTOS
        ORDENRow("STATUS") = COMB_STATUS.Text
        ORDENRow("CREARORDINAL") = False
        ORDENRow("COORDINAR") = False
        ORDENRow("AGENDAR") = False
         ORDENRow("COORDINAR") = False
        ORDENRow("MOTIVOCIERRE") = COMB_FALLACIERRE.Text
        ORDENRow("CAUSACIERRE") = COMB_CAUSACIERRE.Text
        'CARGA LOS HISTORICOS CORRESPONDIENTES AL CAMBIO DE STATUS
        Select Case COMB_STATUS.Text
            Case "FINALIZADO"
                'VERIFICA QUE LOS DATOS ESTEN COMPLETOS
                If COMB_FALLACIERRE.Text = "" Then
                    MsgBox("La FALLA  de cierre es obligatoria", MsgBoxStyle.Information)
                    COMB_FALLACIERRE.Focus()
                    Exit Sub
                Else
                    If COMB_CAUSACIERRE.Text = "" Then
                        MsgBox("La CAUSA de cierre es obligatoria", vbInformation)
                        COMB_CAUSACIERRE.Focus()
                        Exit Sub
                    End If
                End If
                ORDENRow("FECHAFIN") = Now.ToShortDateString
                'CARGA HISTORICO
                TIPOREGISTRO = "ORDEN"
                DATOS.DATOS_HIS_STATUSACTUAL = ORDENRow("STATUS")
                DATOS.DATOS_HIS_CAUSA = "FINALIZACION DE ORDEN"
                DATOS.DATOS_HIS_DETALLE = "FINALIZACION MANUAL"
                DATOS.DATOS_STATUSANT = DATOS.DATOS_ORDENESRow("STATUS")
                DATOS.CARGA_HISTORICO()
        End Select
        'ACTUALIZA OBSERVACIONES 
        OBSERVACIONESRow("OBSORIGEN") = OBS_INGRESO.Text
        OBSERVACIONESRow("OBSCIERRE") = OBS_CIERRE.Text
        OBESERVACIONESTableAdapter.Update(OBSERVACIONESRow)

        'ACTUALIZA TABLA DE ORDENES
        ORDENESTableAdapter.Update(ORDENRow)
        'ACTUALIZA TABLA DE TAREAS
        TAREASTableAdapter.Update(ORDENESDataSet.TAREAS)



        'ENVIA MENSAJE 
        MENSAJE = ""
        If ORDENRow.SECTOROPE = "DISEÑO" Then
            FUNCIONARIOSTableAdapter.FillByNOMBRE(ORDENESDataSet.FUNCIONARIOS, ORDENRow.GENERADOR)
            SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, ORDENESDataSet.FUNCIONARIOS.Rows(0).Item("SECTOR"))
            Dim DESTINATARIO_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")



            MENSAJE = "Hola, " & Split(ORDENRow.GENERADOR, " ")(0) & ". " & vbNewLine
            MENSAJE += "Se FINALIZÓ la orden " & ORDENRow.NRO_ORDENINT & " con causa " & ORDENRow.CAUSACIERRE & ", la orden tiene marcada que la documentación adjunta es en "
            If ORDENRow.DOCUMENTO_FISICO Then
                MENSAJE += "FISICO"
            Else
                MENSAJE += "DIGITAL"
                '    MENSAJE += vbNewLine & vbNewLine & "Detalle de la orden:" & vbNewLine & "    "
                '    MENSAJE += TXT_ING_OBSERVACIONES.Text
            End If
            ENVIAR_EMAIL(ORDENRow.PRIORIDAD, DESTINATARIO_SECTOR, "ORDEN FINALIZADA", MENSAJE, REMITENTE)
        End If

        DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, ORDENRow("ID_TRABAJO"))
        DATOS.Enabled = True
        Cursor = DefaultCursor
        Me.Close()


    End Sub
    Private Sub BOT_DUPLICAR_Click_1(sender As Object, e As EventArgs) Handles BOT_DUPLICAR.Click
        'SE GUARDAN LOS DATOS NUEVOS GENERADOS Y/O CORREGIDOS

        'CARGA EN LAS VARIABLES DUP_ TODOS LOS VALORES DE LA ORDEN A DUPLICAR (ORDENRow ACTUAL) YEN VARIABLES EL NUMERO DE LA ORDEN 
        'DUP_DUPLICADADE = ORDENRow("NRO_ORDENINT")
        'NUM_ORDENADUPLICAR = ORDENRow("NRO_ORDENINT")
        CARGA_ORDENADUPLICAR()

        'CARGA LOS VALORES OBTENIDOS EN LA RUTINA ANTERIOR EN UNA NUEVA ORDEN , AGREGA UN REGISTRO Y HACE EL UPDATE
        CARGA_ORDENDUPLICADA()
        'DESPUES DE CARGAR LA OREN YA DUPLICADA VUELVE A LLENAR LA BASE DE DATOS CON EL ID DE TRABAJO Y MUEVE EL BINDING AL FINAL PARA
        'OBTENER LOS DATS DE LA NUEVA ORDEN
        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, DUP_ID_TRABAJO)
        ORDENESBindingSource.MoveLast()

        'CARGA EN UNA VARIABLE EL NRO DE LA ORDEN DUPLICADA
        NUM_ORDENDUPLICADA = ORDENESDataSet.ORDENES.Rows(ORDENESBindingSource.Position).Item("NRO_ORDENINT")

        'CARGA EL VALOR DE LA ORDEN DUPLICADA EN LA ORDEN QUE FUE DUPLICADA CAMBIANDO EL STATUS A ORDEN DUPLICADA
        NewOBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
        NewOBSERVACIONESRow("NRO_ORDENINT") = NUM_ORDENDUPLICADA
        NewOBSERVACIONESRow("NROORDINAL") = 0
        NewOBSERVACIONESRow("OBSORIGEN") = OBS_INGRESO.Text
        NewOBSERVACIONESRow("OBSCIERRE") = ""
        ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACIONESRow)
        OBESERVACIONESTableAdapter.Update(NewOBSERVACIONESRow)

        'CARGA LAS TAREAS
        Dim CANT_TAREAS As Integer
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

            ORDENESDataSet.TAREAS.Clear()

            For X = 0 To CANT_TAREAS - 1
                NewTAREASRow = ORDENESDataSet.TAREAS.NewTAREASRow

                NewTAREASRow("ORDINAL") = 0
                NewTAREASRow("NRO_ORDENINT") = NUM_ORDENDUPLICADA
                NewTAREASRow("TAREADESC") = DUP_TAREADESC(X)
                NewTAREASRow("CANTSTD") = DUP_TAREACANTSTD(X)
                NewTAREASRow("TIEMPOSTD") = DUP_TAREATIEMPOSTD(X)
                NewTAREASRow("TIEMPOPREV") = DUP_TAREATIEMPOPREV(X)
                NewTAREASRow("UNIDAD") = DUP_TAREAUNIDAD(X)

                ORDENESDataSet.TAREAS.AddTAREASRow(NewTAREASRow)
                TAREASTableAdapter.Update(NewTAREASRow)
            Next X
        End If

        'EDITA LA ORDEN DUPLICADA
        Me.ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, NUM_ORDENADUPLICAR)
        ORDENRow = ORDENESDataSet.ORDENES.Rows(0)
        ORDENRow("STATUS") = "DUPLICADO"
        ORDENRow("DUPLICADAA") = NUM_ORDENDUPLICADA
        ORDENESTableAdapter.Update(ORDENRow)

        ' MsgBox("La Orden ha sido DUPLICADA", vbInformation)

        DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, ORDENRow("ID_TRABAJO"))
        DATOS.Enabled = True
        Me.Close()
    End Sub
    Private Sub COMB_FALLACIERRE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMB_FALLACIERRE.SelectedIndexChanged
        'BUSCA Y AGREGA LAS CAUSAS POSIBLES 
        COMB_CAUSACIERRE.Items.Clear()
        If COMB_FALLACIERRE.Text = "REALIZADO" Then
            COMB_CAUSACIERRE.Items.Add("SIN INCONVENIENTES")
            COMB_CAUSACIERRE.Text = COMB_CAUSACIERRE.Items(0)
        Else
            COMB_CAUSACIERRE.Items.Clear()
            Me.CAUSASTableAdapter.FillByCIERRE(ORDENESDataSet.CAUSAS)
            For I = 0 To ORDENESDataSet.CAUSAS.Rows.Count - 1
                CAUSARow = ORDENESDataSet.CAUSAS.Rows(I)
                COMB_CAUSACIERRE.Items.Add(CAUSARow("DESCCAUSA"))
            Next I
        End If
    End Sub
End Class