Imports System.IO
Public Class ORDINALES

    Dim NUEVOMENSAJE As ORDENESDataSet.MENSAJERIARow
    Dim NewFILAREPORTE As ORDENESDataSet.REPORTEORDINALESRow
    Dim NewOBSERVACION As ORDENESDataSet.OBESERVACIONESRow
    Dim ActTRABAJO As DataRow
    Dim ORD_NewHISTORICORow As ORDENESDataSet.HISTORICORow
    Dim ORD_NewMENSAJE As ORDENESDataSet.MENSAJERIARow
    Dim ORDENRow As ORDENESDataSet.ORDENESRow
    Dim FILAREPORTE As DataRow
    Dim FILAORDENES As ORDENESDataSet.ORDENESRow
    Dim FILAOBSERVACIONES As DataRow
    Dim GENERADOR As String
    Dim OBSERVACIONESACARGAR As String
    Dim OBSERVACIONESCARGADAS As String
    Dim MENSAJEACARGAR As String
    Dim FALLAORIGEN As String

    Dim DATOS_ORDEN As String
    Dim STATUSANTERIOR As String
    Dim ACCION_REQUERIDA As String

    Public ORD_TIPO As String
    Public ORD_FALLAORIG As String
    Public ORD_CAUSA As String
    Public ORD_NODO As String
    Public ORD_ZONA As String
    Public ORD_MANZ As String
    Public ORD_CALLEYNRO As String
    Public ORD_PRIORIDAD As String
    Public ORD_FECHAAGEND As String
    Public ORD_SECTOROPE As String
    Public ORD_CREAR As Boolean
    Public ORD_COORDINAR As Boolean
    Public ORD_AGENDAR As Boolean
    Public ORD_INSTALACION As String
    Public ORD_AFECTACION As String
    Public ORD_DESAGENDA As String
    Public ORD_ORDENINT As Integer
    Public ORD_SECTOR As String

    Dim STATUSANT As String
    Dim HIS_ID_GESTION As String
    Dim HIS_ID_TRABAJO As String
    Dim HIS_ID_ORDENINT As String
    Dim HIS_FECHA As String
    Dim HIS_STATUSANTERIOR As String
    Dim HIS_EJECUTANTE As String
    Dim HIS_STATUSACTUAL As String
    Dim HIS_CAUSA As String
    Dim HIS_DETALLE As String

    Dim MJE_DESTINO_NOMBRE As String
    Dim MJE_DESTINO_SECTOR As String
    Dim MJE_ASUNTO As String
    Dim MJE_DESTINO As String
    Dim MJE_TIPO_ORDENASOC As String
    Dim MJE_NRO_ORDENASOC As String
    Dim MJE_TIPOMENSAJE As String
    Dim MJE_MENSAJE As String

    Dim CAMPO(5) As String
    Dim DATO(5) As String
    Dim FILTRO(5) As String

    Private Sub ORDINALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.GESTION' Puede moverla o quitarla según sea necesario.
        'Me.GESTIONTableAdapter.Fill(Me.ORDENESDataSet.GESTION)
        ''Refresh()

        'ORDENESDataGridView.Columns.Clear()
        'ORDENESDataGridView.Columns.Add(0, "OrdINT")
        'ORDENESDataGridView.Columns(0).Width = 60
        'ORDENESDataGridView.Columns.Add(1, "Ordinal")
        'ORDENESDataGridView.Columns(1).Width = 65
        'ORDENESDataGridView.Columns.Add(2, "Tipo")
        'ORDENESDataGridView.Columns(2).Width = 50
        'ORDENESDataGridView.Columns.Add(3, "Sector Operativo")
        'ORDENESDataGridView.Columns(3).Width = 120
        'ORDENESDataGridView.Columns.Add(4, "Sector")
        'ORDENESDataGridView.Columns(4).Width = 50
        'ORDENESDataGridView.Columns.Add(5, "Motivo Origen")
        'ORDENESDataGridView.Columns(5).Width = 200
        'ORDENESDataGridView.Columns.Add(6, "Causa")
        'ORDENESDataGridView.Columns(6).Width = 180
        'ORDENESDataGridView.Columns.Add(7, "Prio")
        'ORDENESDataGridView.Columns(7).Width = 50
        'ORDENESDataGridView.Columns.Add(8, "Nodo")
        'ORDENESDataGridView.Columns(8).Width = 40
        'ORDENESDataGridView.Columns.Add(9, "Zona")
        'ORDENESDataGridView.Columns(9).Width = 40
        'ORDENESDataGridView.Columns.Add(10, "Calle")
        'ORDENESDataGridView.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'ORDENESDataGridView.Columns.Add(11, "Nro")
        'ORDENESDataGridView.Columns(11).Width = 60
        'Dim Nu As New DataGridViewCheckBoxColumn()
        'With Nu
        '    .Name = 12
        '    .HeaderText = "Cr"
        '    .Width = 21
        'End With
        'ORDENESDataGridView.Columns.Insert(12, Nu)
        'Dim CO As New DataGridViewCheckBoxColumn()
        'With CO
        '    .Name = 13
        '    .HeaderText = "Co"
        '    .Width = 21
        'End With
        'ORDENESDataGridView.Columns.Insert(13, CO)
        'Dim AG As New DataGridViewCheckBoxColumn()
        'With AG
        '    .Name = 14
        '    .HeaderText = "Ag"
        '    .Width = 21
        'End With
        'ORDENESDataGridView.Columns.Insert(14, AG)
        'Dim DE As New DataGridViewCheckBoxColumn()
        'With DE
        '    .Name = 15
        '    .HeaderText = "De"
        '    .Width = 21
        'End With
        'ORDENESDataGridView.Columns.Insert(15, DE)

        'ORDENESDataGridView.Columns.Add(16, "FechAGE")
        'ORDENESDataGridView.Columns(16).Width = 75

        'ORDENESDataGridView.Columns.Add(17, "SOL")
        'ORDENESDataGridView.Columns(17).Width = 30
        'Dim SEL As New DataGridViewCheckBoxColumn()
        'With SEL
        '    .Name = 18
        '    .HeaderText = "S"
        '    .Width = 21
        'End With
        'ORDENESDataGridView.Columns.Insert(18, SEL)

        If THEME_BLACK = False Then
            BackColor = Color.White
            ORDENESDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
            ORDENESDataGridView.BackgroundColor = Color.White
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = FORE_COLOR_W
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64)
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White
            ORDENESDataGridView.Refresh()

            CKTODOS.ForeColor = FORE_COLOR_W
            CK_AGENDAR.ForeColor = FORE_COLOR_W
            CK_COORDINAR.ForeColor = FORE_COLOR_W
            CK_CREAR.ForeColor = FORE_COLOR_W
            CK_DESAGENDAR.ForeColor = FORE_COLOR_W
            CK_SELTODOS.ForeColor = FORE_COLOR_W
            TXT_CAUSA_ORIGEN.BackColor = Color.White
            TXT_CAUSA_ORIGEN.ForeColor = FORE_COLOR_W
            TXT_MOTIVO_ORIGEN.BackColor = Color.White
            TXT_MOTIVO_ORIGEN.ForeColor = FORE_COLOR_W
            TXT_SECTOR_OPE.BackColor = Color.White
            TXT_SECTOR_OPE.ForeColor = FORE_COLOR_W
            TXT_SECTOR.BackColor = Color.White
            TXT_SECTOR.ForeColor = FORE_COLOR_W
            OBSERVACIONESCREA.BackColor = Color.White
            OBSERVACIONESCREA.ForeColor = FORE_COLOR_W

            LBL_ORDENINT.ForeColor = FORE_COLOR_W
            LBL_ORDINAL_CREADO.ForeColor = FORE_COLOR_W
            LBL_FILTRARX.ForeColor = FORE_COLOR_W

        End If
        CONDICION_INI()
    End Sub
    Private Sub CONDICION_INI()
        ORDENINT_TEXT.Text = ""

        OBSERVACIONESCREA.Text = ""
        OBSERVACIONESCREA.ReadOnly = False

        ORDINAL_TEXT.Text = ""
        ORDINAL_TEXT.BackColor = Color.Gray
        ORDINAL_TEXT.Enabled = False

        CARGA_ORDENESPENDIENTES()
        MENSAJEACARGAR = ""
        OBSERVACIONESACARGAR = ""
    End Sub
    Private Sub CARGA_ORDENESPENDIENTES()
        Me.Cursor = Cursors.WaitCursor
        Try
            If CKTODOS.Checked = True Then
                ORDENESTableAdapter.FillByCREARORDINAL(ORDENESDataSet.ORDENES)
            ElseIf CK_DESAGENDAR.Checked = True Then
                ORDENESTableAdapter.FillByCREARORDINAL_DES(ORDENESDataSet.ORDENES)
            ElseIf CK_AGENDAR.Checked = True Then
                ORDENESTableAdapter.FillByCREARORDINAL_AGE(ORDENESDataSet.ORDENES)
            ElseIf CK_COORDINAR.Checked = True Then
                ORDENESTableAdapter.FillByCREARORDINAL_COOR(ORDENESDataSet.ORDENES)
            ElseIf CK_CREAR.Checked = True Then
                ORDENESTableAdapter.FillByCREARORDINAL_CREAR(ORDENESDataSet.ORDENES)
            End If
            '  CARGAR_VALORES_DATAGRID()
            ' PINTA_GRILLA()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    'Private Sub CARGAR_VALORES_DATAGRID()
    '    ORDENESDataGridView.Rows.Clear()
    '    For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
    '        ORDENESDataGridView.Rows.Add()
    '        ORDENRow = ORDENESDataSet.ORDENES.Rows(X)
    '        ORDENESDataGridView.Item(0, X).Value = ORDENRow.NRO_ORDENINT
    '        ORDENESDataGridView.Item(1, X).Value = ORDENRow.NRO_ORDINAL
    '        ORDENESDataGridView.Item(2, X).Value = ORDENRow.TIPO
    '        ORDENESDataGridView.Item(3, X).Value = ORDENRow.SECTOROPE
    '        ORDENESDataGridView.Item(4, X).Value = ORDENRow.SECTORDESTINO
    '        ORDENESDataGridView.Item(5, X).Value = ORDENRow.MOTIVOORIGEN
    '        ORDENESDataGridView.Item(6, X).Value = ORDENRow.CAUSARIGEN
    '        ORDENESDataGridView.Item(7, X).Value = ORDENRow.PRIORIDAD
    '        ORDENESDataGridView.Item(8, X).Value = ORDENRow.NODO
    '        ORDENESDataGridView.Item(9, X).Value = ORDENRow.ZONA
    '        ORDENESDataGridView.Item(10, X).Value = ORDENRow.CALLE
    '        ORDENESDataGridView.Item(11, X).Value = ORDENRow.NRO
    '        ORDENESDataGridView.Rows(X).Cells(12).Value = ORDENRow.CREARORDINAL
    '        ORDENESDataGridView.Rows(X).Cells(13).Value = ORDENRow.COORDINAR
    '        ORDENESDataGridView.Rows(X).Cells(14).Value = ORDENRow.AGENDAR
    '        ORDENESDataGridView.Rows(X).Cells(15).Value = ORDENRow.DESAGENDAR

    '        If ORDENRow.IsFECHAAGENDNull = False Then ORDENESDataGridView.Item(16, X).Value = ORDENRow.FECHAAGEND
    '        GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, ORDENRow.ID_GESTION)
    '        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
    '            Select Case ORDENESDataSet.GESTION.Rows(0).Item("SOLICITANTE")
    '                Case "TERCEROS"
    '                    ORDENESDataGridView.Item(17, X).Value = "TER"
    '                Case "EQUITAL"
    '                    ORDENESDataGridView.Item(17, X).Value = "EQ"
    '                Case "MONTECABLE"
    '                    ORDENESDataGridView.Item(17, X).Value = "MC"
    '                Case "TCC"
    '                    ORDENESDataGridView.Item(17, X).Value = "TCC"
    '                Case "NUEVO SIGLO"
    '                    ORDENESDataGridView.Item(17, X).Value = "NS"
    '            End Select
    '        End If
    '    Next
    'End Sub
    Private Sub PINTA_GRILLA()
        If THEME_BLACK Then
            For I = 0 To ORDENESDataGridView.Rows.Count - 1
                'SI ES PARA COORDINAR
                Select Case ORDENESDataGridView.Rows(I).Cells.Item(6).Value
                    Case "OBRA NUEVA"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(123, 117, 114)
                    Case "MANTENIMIENTO PREVENTIVO"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(104, 141, 153)
                    Case "MANTENIMIENTO PREDICTIVO"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(112, 124, 93)
                End Select
                If ORDENESDataGridView.Rows(I).Cells.Item(13).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DarkBlue
                If ORDENESDataGridView.Rows(I).Cells.Item(14).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.Black
                If ORDENESDataGridView.Rows(I).Cells.Item(15).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DarkGreen
                ORDENESDataGridView.Rows(I).Height = 20
            Next I
        Else
            For I = 0 To ORDENESDataGridView.Rows.Count - 1
                'SI ES PARA COORDINAR
                Select Case ORDENESDataGridView.Rows(I).Cells.Item(6).Value
                    Case "OBRA NUEVA"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.Silver
                    Case "MANTENIMIENTO PREVENTIVO"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "MANTENIMIENTO PREDICTIVO"
                        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.AntiqueWhite
                End Select
                If ORDENESDataGridView.Rows(I).Cells.Item(12).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DarkGoldenrod
                If ORDENESDataGridView.Rows(I).Cells.Item(13).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.Navy
                If ORDENESDataGridView.Rows(I).Cells.Item(14).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.Green
                ORDENESDataGridView.Rows(I).Height = 20
            Next I

        End If
    End Sub
    Private Sub CREAR_ORDINALES_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' PINTA_GRILLA()
    End Sub
    Private Sub BUSCA_OBSERVACIONES()
        ORD_ORDENINT = Me.ORDENESDataGridView.CurrentRow.Cells.Item(0).Value
        OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, ORD_ORDENINT)
        If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
            FILAOBSERVACIONES = ORDENESDataSet.OBESERVACIONES.Rows(0)
            OBSERVACIONESCREA.Text = FILAOBSERVACIONES("OBSORIGEN")
        Else
            OBSERVACIONESCREA.Text = ""
        End If
    End Sub
    Private Sub ORDENESDataGridView_Click(sender As Object, e As MouseEventArgs) Handles ORDENESDataGridView.Click
        If ORDENESDataGridView.Rows.Count > 0 Then
            ORD_TIPO = ""
            ORD_SECTOR = ""
            ORD_FALLAORIG = ""
            ORD_CAUSA = ""
            ORD_PRIORIDAD = ""
            ORD_NODO = ""
            ORD_ZONA = ""
            ORD_MANZ = ""
            ORD_CALLEYNRO = ""
            ORD_ORDENINT = Me.ORDENESDataGridView.CurrentRow.Cells.Item(0).Value
            ORD_TIPO = Me.ORDENESDataGridView.CurrentRow.Cells.Item(2).Value
            ORD_SECTOROPE = Me.ORDENESDataGridView.CurrentRow.Cells.Item(3).Value
            ORD_SECTOR = Me.ORDENESDataGridView.CurrentRow.Cells.Item(4).Value
            ORD_FALLAORIG = Me.ORDENESDataGridView.CurrentRow.Cells.Item(5).Value
            ORD_CAUSA = Me.ORDENESDataGridView.CurrentRow.Cells.Item(6).Value
            ORD_PRIORIDAD = Me.ORDENESDataGridView.CurrentRow.Cells.Item(7).Value
            ORD_NODO = Me.ORDENESDataGridView.CurrentRow.Cells.Item(8).Value
            ORD_ZONA = Me.ORDENESDataGridView.CurrentRow.Cells.Item(9).Value
            ORD_CALLEYNRO = Me.ORDENESDataGridView.CurrentRow.Cells.Item(10).Value & " " & Me.ORDENESDataGridView.CurrentRow.Cells.Item(11).Value

            If Me.ORDENESDataGridView.CurrentRow.Cells.Item(19).Value = False Then
                Me.ORDENESDataGridView.CurrentRow.Cells.Item(19).Value = True
            ElseIf Me.ORDENESDataGridView.CurrentRow.Cells.Item(19).Value = True Then
                Me.ORDENESDataGridView.CurrentRow.Cells.Item(19).Value = False
            End If

            If IsDBNull(Me.ORDENESDataGridView.CurrentRow.Cells.Item(17).Value) = False Then ORD_FECHAAGEND = CDate(Me.ORDENESDataGridView.CurrentRow.Cells.Item(17).Value).Date
            ORDENINT_TEXT.Text = ORD_ORDENINT
            BUSCA_OBSERVACIONES()

            If e.Button = Windows.Forms.MouseButtons.Left Then
                ORDENESDataGridView.ContextMenuStrip = MENU_DATALLE
            End If

            FILAORDENES = ORDENESDataSet.Tables("ORDENES").Rows.Find(ORD_ORDENINT)
            DATOS_ORDEN = "TIPO: " & FILAORDENES("TIPO") & " MOTIVO: " & FILAORDENES("MOTIVOORIGEN") & " AREA " & FILAORDENES("SECTORDESTINO") & vbNewLine _
                & " UBICACION: NODO " & FILAORDENES("NODO") & " ZONA " & FILAORDENES("ZONA") & " CALLE " & FILAORDENES("CALLE") & " NRO " & FILAORDENES("NRO")
            GENERADOR = FILAORDENES("GENERADOR")
            FALLAORIGEN = FILAORDENES("MOTIVOORIGEN")
            BOT_ACTUALIZARORD.Enabled = False
            If ORDENESDataGridView.CurrentRow.Cells.Item(12).Value = True Then 'CONDICION DE CREAR ORDINAL

                ORDINAL_TEXT.Enabled = True
                ORDINAL_TEXT.BackColor = Color.DarkRed
                OBSERVACIONESCREA.ReadOnly = False
                BOT_ACTUALIZARORD.Text = "Ingresar Ordinal"
                BOT_ACTUALIZARORD.Enabled = True
                ACCION_REQUERIDA = "CREAR"
                If ORDENESDataGridView.CurrentRow.Cells.Item(13).Value Then     'CONDICION DE COORDINAR ORDINAL
                    BOT_ACTUALIZARORD.Text = "Actualizar orden"
                    BOT_ACTUALIZARORD.Enabled = True
                    ACCION_REQUERIDA = "COORDINAR"
                End If
            Else
                ORDINAL_TEXT.Enabled = False
                ORDINAL_TEXT.BackColor = Color.Gray
                If ORDENESDataGridView.CurrentRow.Cells.Item(13).Value Then     'CONDICION DE COORDINAR ORDINAL
                    BOT_ACTUALIZARORD.Text = "Actualizar orden"
                    BOT_ACTUALIZARORD.Enabled = True
                    ACCION_REQUERIDA = "COORDINAR"
                End If
            End If
            If ORDENESDataGridView.Rows.Count > 0 Then
                'PINTA_GRILLA()
                For I = 0 To ORDENESDataGridView.Rows.Count - 1
                    'SI ES PARA COORDINAR
                    'Select Case ORDENESDataGridView.Rows(I).Cells.Item(6).Value
                    '    Case "OBRA NUEVA"
                    '        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(123, 117, 114)
                    '    Case "MANTENIMIENTO PREVENTIVO"
                    '        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(104, 141, 153)
                    '    Case "MANTENIMIENTO PREDICTIVO"
                    '        ORDENESDataGridView.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(112, 124, 93)
                    'End Select
                    'If ORDENESDataGridView.Rows(I).Cells.Item(13).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DarkBlue
                    'If ORDENESDataGridView.Rows(I).Cells.Item(14).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.Black
                    'If ORDENESDataGridView.Rows(I).Cells.Item(15).Value = True Then ORDENESDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.DarkGreen
                    ORDENESDataGridView.Rows(I).Height = 20
                Next I
                ORDENESDataGridView.CurrentRow.Height = 50
            End If
        End If
    End Sub
    Private Sub BOT_ACTUALIZARORD_Click(sender As Object, e As EventArgs) Handles BOT_ACTUALIZARORD.Click
        Me.Cursor = Cursors.WaitCursor
        Select Case ACCION_REQUERIDA
            Case "CREAR"
                If ORDINAL_TEXT.Text = "" Then
                    MsgBox("INGRESE NUMERO DE ORDINAL", vbInformation)
                    ORDINAL_TEXT.Focus()
                    Exit Sub
                    'End If
                    ''OBSERVACIONES
                    'OBSERVACIONESACARGAR = vbNewLine & " NO SE HA PODIDO CREAR EL ORDINAL POR LAS SIGUIENTES RAZONES: " & OBSERVACIONESCREA.Text & " - " & FULLNOMBRE
                    ''LLENA EL HISTORICO DE LA ORDEN 
                    'STATUSANTERIOR = FILAORDENES("STATUS")
                    'HIS_ID_GESTION = 0
                    'HIS_ID_TRABAJO = 0
                    'HIS_ID_ORDENINT = ORD_ORDENINT
                    'HIS_STATUSANTERIOR = STATUSANTERIOR
                    'HIS_STATUSACTUAL = STATUSANTERIOR
                    'HIS_CAUSA = "INPOSIBILIDAD DE CREAR ORDINAL"
                    'HIS_DETALLE = ""
                    'GENERA_HISTORICO()
                    ''MENSAJE AL SOLICITANTE
                    'MENSAJEACARGAR = OBSERVACIONESACARGAR
                Else
                    'CAMBIO DE STATUS
                    STATUSANTERIOR = FILAORDENES("STATUS")
                    FILAORDENES("NRO_ORDINAL") = ORDINAL_TEXT.Text
                    FILAORDENES("CREARORDINAL") = False
                    Select Case FILAORDENES("STATUS")
                        Case "INGRESADOINT"
                            FILAORDENES("STATUS") = "INGORDINAL"
                        Case "AGENDADO"
                            FILAORDENES("STATUS") = "AGENDADO"
                        Case "RUTEADO"
                            FILAORDENES("STATUS") = "RUTEADO"
                        Case "COORDINADO"
                            FILAORDENES("STATUS") = "COORDINADO"
                        Case Else
                            FILAORDENES("STATUS") = "INGORDINAL"
                    End Select
                    ORDENESTableAdapter.Update(FILAORDENES)


                    'OBSERVACIONES
                    OBSERVACIONESACARGAR = vbNewLine & " SE CREO EL ORDINAL N° " & ORDINAL_TEXT.Text & " OBS: " & OBSERVACIONESCREA.Text & " - " & FULLNOMBRE

                    'CARGA OBSERVACIONES
                    OBESERVACIONESTableAdapter.FillByORDENINT(ORDENESDataSet.OBESERVACIONES, ORD_ORDENINT)

                    If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                        FILAOBSERVACIONES = ORDENESDataSet.OBESERVACIONES.Rows(0)
                        OBSERVACIONESCARGADAS = FILAOBSERVACIONES("OBSORIGEN")
                        FILAOBSERVACIONES("OBSORIGEN") = OBSERVACIONESCREA.Text
                        OBESERVACIONESTableAdapter.Update(FILAOBSERVACIONES)
                    Else
                        NewOBSERVACION = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
                        NewOBSERVACION("NRO_ORDENINT") = ORD_ORDENINT
                        NewOBSERVACION("OBSORIGEN") = Now & " " & OBSERVACIONESCREA.Text
                        ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACION)
                        OBESERVACIONESTableAdapter.Update(NewOBSERVACION)
                    End If
                    'LLENA EL HISTORICO DE LA ORDEN 
                    HIS_ID_GESTION = 0
                    HIS_ID_TRABAJO = 0
                    HIS_ID_ORDENINT = ORD_ORDENINT
                    HIS_STATUSANTERIOR = STATUSANTERIOR
                    HIS_STATUSACTUAL = "INGORDINAL"
                    HIS_CAUSA = "SOLICITUD A ADMINISTRACION"
                    HIS_DETALLE = ""
                    GENERA_HISTORICO()
                    MENSAJEACARGAR = "SE CREO EL ORDINAL N° " & ORDINAL_TEXT.Text & DATOS_ORDEN
                    'ENVIA MENSAJE AL GENERADOR DEL PEDIDO
                    MJE_ASUNTO = "CREACION DE ORDINAL"
                    MJE_TIPOMENSAJE = "INFORME"
                    MJE_DESTINO_NOMBRE = GENERADOR
                    MJE_DESTINO_SECTOR = ""
                    MJE_MENSAJE = MENSAJEACARGAR
                    MJE_TIPO_ORDENASOC = "ORDEN INTERNA"
                    MJE_NRO_ORDENASOC = ORD_ORDENINT
                    If IsNumeric(ORD_ORDENINT) = True Then MJE_NRO_ORDENASOC = ORD_ORDENINT

                    ENVIA_MENSAJE()


                    If FALLAORIGEN = "RELEVAMIENTO" Then
                        'ENVIA MENSAJE A SUPERVISORES 
                        MJE_ASUNTO = "CREACION DE ORDINAL"
                        MJE_TIPOMENSAJE = "INFORME"
                        MJE_DESTINO_NOMBRE = ""
                        MJE_DESTINO_SECTOR = "SUPERVISION"
                        MJE_MENSAJE = "Se ha creado el ordinal nro " & ORDINAL_TEXT.Text & " correspondiente a la Orden Interna de referencia" & vbNewLine _
                            & "DETALLE ORDEN: " & DATOS_ORDEN & "Debera comunicar los resultados del RELEVAMIENTO al generador del trabajo"
                        MJE_TIPO_ORDENASOC = "ORDEN INTERNA"
                        If IsNumeric(ORD_ORDENINT) = True Then MJE_NRO_ORDENASOC = ORD_ORDENINT
                        ENVIA_MENSAJE()

                    End If
                    CONDICION_INI()

                End If
            Case "COORDINAR"
                'CAMBIO DE STATUS
                STATUSANTERIOR = FILAORDENES("STATUS")
                'FILAORDENES("NRO_ORDINAL") = ORDINAL_TEXT.Text
                'FILAORDENES("CREARORDINAL") = False
                ' FILAORDENES("STATUS") = "COORDINADO"
                ORDENESTableAdapter.Update(FILAORDENES)
                'OBSERVACIONES
                OBSERVACIONESACARGAR = OBSERVACIONESCREA.Text & " - " & FULLNOMBRE
                'CARGA OBSERVACIONES
                OBESERVACIONESTableAdapter.FillByORDENINT(ORDENESDataSet.OBESERVACIONES, ORD_ORDENINT)

                If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    FILAOBSERVACIONES = ORDENESDataSet.OBESERVACIONES.Rows(0)
                    OBSERVACIONESCARGADAS = FILAOBSERVACIONES("OBSORIGEN")
                    FILAOBSERVACIONES("OBSORIGEN") = OBSERVACIONESCREA.Text
                    OBESERVACIONESTableAdapter.Update(FILAOBSERVACIONES)
                Else
                    NewOBSERVACION = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
                    NewOBSERVACION("NRO_ORDENINT") = ORD_ORDENINT
                    NewOBSERVACION("OBSORIGEN") = Now & OBSERVACIONESCREA.Text
                    ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACION)
                    OBESERVACIONESTableAdapter.Update(NewOBSERVACION)
                End If
                'LLENA EL HISTORICO DE LA ORDEN 
                HIS_ID_GESTION = 0
                HIS_ID_TRABAJO = 0
                HIS_ID_ORDENINT = ORD_ORDENINT
                HIS_STATUSANTERIOR = STATUSANTERIOR
                HIS_STATUSACTUAL = "INGRESO DE CONTACTO"
                HIS_CAUSA = "SOLICITADO ADMINISTRACION"
                HIS_DETALLE = ""
                GENERA_HISTORICO()

                ''ENVIA MENSAJE AL GENERADOR DEL PEDIDO
                'MJE_ASUNTO = "COORDINACION DE ORDINAL"
                'MJE_TIPOMENSAJE = "INFORME"
                'MJE_DESTINO_NOMBRE = GENERADOR
                'MJE_DESTINO_SECTOR = ""
                'MJE_MENSAJE = MENSAJEACARGAR
                'MJE_TIPO_ORDENASOC = "ORDEN INTERNA"

                'If IsNumeric(ORD_ORDENINT) = True Then MJE_NRO_ORDENASOC = ORD_ORDENINT

                'ENVIA_MENSAJE()
                CONDICION_INI()
        End Select
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ORDINAL_TEXT_TextChanged(sender As Object, e As EventArgs) Handles ORDINAL_TEXT.TextChanged
        If ORDINAL_TEXT.Text <> "" Then BOT_ACTUALIZARORD.Enabled = True
    End Sub
    Private Sub BOT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BOT_CANCELAR.Click
        CONDICION_INI()
        '  PINTA_GRILLA()
    End Sub
    Private Sub BOT_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BOT_IMPRIMIR.Click
        Cursor = Cursors.WaitCursor
        'IMPRIMEORDEN.Show(Me)
        Cursor = DefaultCursor
    End Sub
    Private Sub VERDETALLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERDETALLEToolStripMenuItem.Click
        DETALLE.Show()
        ORDENESDataGridView.ContextMenuStrip = Nothing
    End Sub
    Private Sub BOT_REGISTRARAGEND_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor

        'QUITA LA MARCA DE AGENDAR DE LA BAS DE ORDENES Y ACTUALIZA EL STATUS

        STATUSANTERIOR = FILAORDENES("STATUS")
        FILAORDENES("AGENDAR") = False
        'FILAORDENES("STATUS") = "COORDINADO"
        'FILAORDENES("FECHAAGEND") = FECHACOOR.Value.ToShortDateString
        ORDENESTableAdapter.Update(FILAORDENES)

        'ACTUALIZA EL TRABAJO AL STATUS COORDINADO
        TRABAJOSTableAdapter.FillByIDTRABAJO(ORDENESDataSet.TRABAJOS, FILAORDENES("Id_TRABAJO"))
        ActTRABAJO = ORDENESDataSet.TRABAJOS.Rows(0)

        Dim STATUSTRABANT As String = ActTRABAJO("STATUS")
        ActTRABAJO("STATUS") = "AGENDADO"
        'ActTRABAJO("FECHAINICESTIMADO") = LBL_FECHAAGEND.Text
        TRABAJOSTableAdapter.Update(ActTRABAJO)

        'CARGA EL HISTORICO DEL TRABAJOREGISTRANDO LA OPERACION
        HIS_ID_GESTION = FILAORDENES("ID_GESTION")
        HIS_ID_TRABAJO = FILAORDENES("ID_TRABAJO")
        HIS_ID_ORDENINT = 0
        HIS_STATUSANTERIOR = STATUSTRABANT
        HIS_STATUSACTUAL = "AGENDADO"
        HIS_CAUSA = "ORDEN INT " & FILAORDENES("NRO_ORDENINT") & " CON TAREA " & FILAORDENES("MOTIVOORIGEN") & " FUE AGENDADA"
        'HIS_DETALLE = LBL_FECHAAGEND.Text
        GENERA_HISTORICO()

        'CARGA EL HISTORICO REGISTRANDO LA OPERACION
        HIS_ID_GESTION = FILAORDENES("ID_GESTION")
        HIS_ID_TRABAJO = FILAORDENES("ID_TRABAJO")
        HIS_ID_ORDENINT = ORD_ORDENINT
        HIS_STATUSANTERIOR = STATUSANTERIOR
        HIS_STATUSACTUAL = "AGENDADO"
        HIS_CAUSA = "SOLICITUD A ADMINISTRACION"
        'HIS_DETALLE = LBL_FECHAAGEND.Text
        GENERA_HISTORICO()

        'CARGA OBSERVACIONES SI LAS HAY 
        OBESERVACIONESTableAdapter.FillByORDENINT(ORDENESDataSet.OBESERVACIONES, ORD_ORDENINT)

        If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
            FILAOBSERVACIONES = ORDENESDataSet.OBESERVACIONES.Rows(0)
            FILAOBSERVACIONES("OBSORIGEN") = FILAOBSERVACIONES("OBSORIGEN") & vbNewLine & Now & OBSERVACIONESACARGAR
            OBESERVACIONESTableAdapter.Update(FILAOBSERVACIONES)
        Else
            NewOBSERVACION = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
            NewOBSERVACION("NRO_ORDENINT") = ORD_ORDENINT
            NewOBSERVACION("OBSORIGEN") = Now & OBSERVACIONESACARGAR
            ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACION)
            OBESERVACIONESTableAdapter.Update(NewOBSERVACION)
        End If

        'ENVIA MENSAJE AL GENERADOR DEL PEDIDO
        MJE_ASUNTO = "AGENDADO DE ORDINAL"
        MJE_TIPOMENSAJE = "INFORME"
        MJE_DESTINO_NOMBRE = GENERADOR
        MJE_DESTINO_SECTOR = ""
        MJE_MENSAJE = MENSAJEACARGAR
        MJE_TIPO_ORDENASOC = "ORDEN INTERNA"
        If IsNumeric(ORD_ORDENINT) = True Then MJE_NRO_ORDENASOC = ORD_ORDENINT
        ENVIA_MENSAJE()

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub QMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QMToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        STATUSANTERIOR = FILAORDENES("STATUS")

        FILAORDENES("AGENDAR") = False

        ORDENESTableAdapter.Update(FILAORDENES)
        Cursor = DefaultCursor
    End Sub
    Private Sub QMCToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QMCToolStripMenuItem1.Click
        P_CALENDARIO.Location = New Point((ORDENESDataGridView.Size.Width - P_CALENDARIO.Size.Width) / 2, (ORDENESDataGridView.Size.Height - P_CALENDARIO.Size.Height) / 2)
        P_CALENDARIO.Visible = True

    End Sub
    Private Sub ProcesarAUTOMATICOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarAUTOMATICOToolStripMenuItem.Click
        File.WriteAllText("C:\DOCUMENTOS\USUARIO\CommandBOT.txt", "A," & FILAORDENES("NRO_ORDENINT"))
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\W10\" & VERSION & "\BOTSverver.exe")
        Else
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\" & VERSION & "\BOTSverver.exe")
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If File.ReadAllText("C:\DOCUMENTOS\USUARIO\CommandBOT.txt") = "" Then
            CARGA_ORDENESPENDIENTES()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub DESAGENDARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESAGENDARToolStripMenuItem1.Click
        FILAORDENES("DESAGENDAR") = False
        ORDENESTableAdapter.Update(ORDENESDataSet.ORDENES)
    End Sub
    Private Sub CK_CREAR_CheckedChanged(sender As Object, e As EventArgs) Handles CK_CREAR.CheckedChanged
        If CK_CREAR.Checked = True Then
            If CK_AGENDAR.Checked = True Then
                CK_AGENDAR.Checked = False
            End If
            If CK_COORDINAR.Checked = True Then
                CK_COORDINAR.Checked = False
            End If
            If CK_DESAGENDAR.Checked = True Then
                CK_DESAGENDAR.Checked = False
            End If
            If CKTODOS.Checked = True Then
                CKTODOS.Checked = False
            End If
            CARGA_ORDENESPENDIENTES()
        End If
    End Sub
    Private Sub CK_COORDINAR_CheckedChanged(sender As Object, e As EventArgs) Handles CK_COORDINAR.CheckedChanged
        If CK_COORDINAR.Checked = True Then
            If CK_AGENDAR.Checked = True Then
                CK_AGENDAR.Checked = False
            End If
            If CK_CREAR.Checked = True Then
                CK_CREAR.Checked = False
            End If
            If CK_DESAGENDAR.Checked = True Then
                CK_DESAGENDAR.Checked = False
            End If
            If CKTODOS.Checked = True Then
                CKTODOS.Checked = False
            End If
            CARGA_ORDENESPENDIENTES()
        End If
    End Sub
    Private Sub CK_AGENDAR_CheckedChanged(sender As Object, e As EventArgs) Handles CK_AGENDAR.CheckedChanged
        If CK_AGENDAR.Checked = True Then
            If CK_COORDINAR.Checked = True Then
                CK_COORDINAR.Checked = False
            End If
            If CK_CREAR.Checked = True Then
                CK_CREAR.Checked = False
            End If
            If CK_DESAGENDAR.Checked = True Then
                CK_DESAGENDAR.Checked = False
            End If
            If CKTODOS.Checked = True Then
                CKTODOS.Checked = False
            End If
            CARGA_ORDENESPENDIENTES()
        End If
    End Sub
    Private Sub CK_DESAGENDAR_CheckedChanged(sender As Object, e As EventArgs) Handles CK_DESAGENDAR.CheckedChanged
        If CK_DESAGENDAR.Checked = True Then
            If CK_AGENDAR.Checked = True Then
                CK_AGENDAR.Checked = False
            End If
            If CK_CREAR.Checked = True Then
                CK_CREAR.Checked = False
            End If
            If CK_COORDINAR.Checked = True Then
                CK_COORDINAR.Checked = False
            End If
            If CKTODOS.Checked = True Then
                CKTODOS.Checked = False
            End If
            CARGA_ORDENESPENDIENTES()
        End If

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CKTODOS.CheckedChanged
        If CKTODOS.Checked = True Then
            If CK_DESAGENDAR.Checked = True Then
                CK_DESAGENDAR.Checked = False
            End If
            If CK_AGENDAR.Checked = True Then
                CK_AGENDAR.Checked = False
            End If
            If CK_CREAR.Checked = True Then
                CK_CREAR.Checked = False
            End If
            If CK_COORDINAR.Checked = True Then
                CK_COORDINAR.Checked = False
            End If
            CARGA_ORDENESPENDIENTES()
        End If
    End Sub
    Private Sub BTN_PROCESARSELECCION_Click(sender As Object, e As EventArgs) Handles BTN_PROCESARSELECCION.Click
        Dim TXTARRAY As String = "A"
        For X = 0 To ORDENESDataGridView.Rows.Count - 1
            If ORDENESDataGridView.Rows(X).Cells.Item(19).Value = True Then
                TXTARRAY += "," & ORDENESDataGridView.Rows(X).Cells.Item(0).Value
            End If
        Next
        File.WriteAllText("C:\DOCUMENTOS\USUARIO\CommandBOT.txt", TXTARRAY)
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\W10\" & VERSION & "\BOTSverver.exe")
        Else
            Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\" & VERSION & "\BOTSverver.exe")
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub GENERA_HISTORICO() 'RUTINA PARA LOS CAMBIOS DE STATUS
        ORD_NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
        ORD_NewHISTORICORow("ID_GESTION") = HIS_ID_GESTION
        ORD_NewHISTORICORow("ID_TRABAJO") = HIS_ID_TRABAJO
        ORD_NewHISTORICORow("ID_ORDENINT") = HIS_ID_ORDENINT
        ORD_NewHISTORICORow("FECHA") = Now
        ORD_NewHISTORICORow("STATUSANTERIOR") = STATUSANT
        ORD_NewHISTORICORow("STATUSACTUAL") = HIS_STATUSACTUAL
        ORD_NewHISTORICORow("CAUSA") = HIS_CAUSA
        ORD_NewHISTORICORow("DETALLE") = HIS_DETALLE
        ORD_NewHISTORICORow("EJECUTANTE") = FULLNOMBRE

        'GUARDA EL HISTORICO PROCESADO
        ORDENESDataSet.HISTORICO.AddHISTORICORow(ORD_NewHISTORICORow)
        HISTORICOTableAdapter.Update(ORD_NewHISTORICORow)
    End Sub
    Private Sub ENVIA_MENSAJE()
        'ENVIA MENSAJE 
        ORD_NewMENSAJE = ORDENESDataSet.MENSAJERIA.NewMENSAJERIARow
        ORD_NewMENSAJE("FECHACREADO") = Now
        ORD_NewMENSAJE("TIPOMENSAJE") = MJE_TIPOMENSAJE
        ORD_NewMENSAJE("ASUNTO") = MJE_ASUNTO
        ORD_NewMENSAJE("ORIGEN_NOMBRE") = FULLNOMBRE
        ORD_NewMENSAJE("ORIGEN_SECTOR") = ""
        ORD_NewMENSAJE("DESTINO_NOMBRE") = MJE_DESTINO_NOMBRE
        ORD_NewMENSAJE("DESTINO_SECTOR") = MJE_DESTINO_SECTOR
        ORD_NewMENSAJE("MENSAJE") = MJE_MENSAJE
        ORD_NewMENSAJE("TIPO_ORDENASOC") = "ORDEN INTERNA"
        'ORD_NewMENSAJE("NRO_ORDENASOC") = MJE_NROORDENASOC

        ORDENESDataSet.MENSAJERIA.AddMENSAJERIARow(ORD_NewMENSAJE)
        MENSAJERIATableAdapter.Update(ORD_NewMENSAJE)
    End Sub
    Private Sub CK_SELTODOS_CheckedChanged(sender As Object, e As EventArgs) Handles CK_SELTODOS.CheckedChanged
        If CK_SELTODOS.Checked = True Then
            For X = 0 To ORDENESDataGridView.Rows.Count - 1
                ORDENESDataGridView.Rows(X).Cells.Item(19).Value = True
            Next
        Else
            For X = 0 To ORDENESDataGridView.Rows.Count - 1
                ORDENESDataGridView.Rows(X).Cells.Item(19).Value = False
            Next
        End If
    End Sub
    Private Sub BUSCA_TIPO()
        Dim VISTAORDEN As DataView = ORDENESDataSet.ORDENES.AsDataView
        CAMPO(0) = "SECTOROPE"
        DATO(0) = TXT_SECTOR_OPE.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"

        CAMPO(1) = "MOTIVOORIGEN"
        DATO(1) = TXT_MOTIVO_ORIGEN.Text

        If TXT_MOTIVO_ORIGEN.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND  [" & CAMPO(1) & "]  like '*" & DATO(1) & "*'"
        End If

        CAMPO(2) = "CAUSARIGEN"
        DATO(2) = TXT_CAUSA_ORIGEN.Text
        If TXT_CAUSA_ORIGEN.Text = "" Then
            FILTRO(2) = ""
        Else
            FILTRO(2) = " AND  [" & CAMPO(2) & "] like '*" & DATO(2) & "*'"
        End If

        CAMPO(3) = "SECTORDESTINO"
        DATO(3) = TXT_SECTOR.Text
        If TXT_SECTOR.Text = "" Then
            FILTRO(3) = ""
        Else
            FILTRO(3) = " AND  [" & CAMPO(3) & "] like '*" & DATO(3) & "*'"
        End If

        VISTAORDEN.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) '& FILTRO(4) & FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8)
        ORDENESBindingSource.DataSource = VISTAORDEN
        'CARGAR_VALORES_DATAGRID()
        ' PINTA_GRILLA()
    End Sub
    Private Sub TXT_SECTOR_OPE_TextChanged(sender As Object, e As EventArgs) Handles TXT_SECTOR_OPE.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_MOTIVO_ORIGEN_TextChanged(sender As Object, e As EventArgs) Handles TXT_MOTIVO_ORIGEN.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_CAUSA_ORIGEN_TextChanged(sender As Object, e As EventArgs) Handles TXT_CAUSA_ORIGEN.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_SECTOR_TextChanged(sender As Object, e As EventArgs) Handles TXT_SECTOR.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub BTN_COORDINADO_Click(sender As Object, e As EventArgs) Handles BTN_COORDINADO.Click
        Cursor = Cursors.WaitCursor
        STATUSANTERIOR = FILAORDENES("STATUS")
        FILAORDENES("COORDINAR") = False
        FILAORDENES.STATUS = "COORDINADO"
        FILAORDENES.FECHAINICESTIMADO = DT_FECHA.Value.ToShortDateString
        ORDENESTableAdapter.Update(FILAORDENES)


        MJE_TIPOMENSAJE = "INFORMATIVO"
        MJE_ASUNTO = "COORDINACION DE ORDEN"
        MJE_DESTINO_NOMBRE = GENERADOR
        MJE_DESTINO_SECTOR = ""
        MJE_MENSAJE = "SE COORDINÓ LA ORDEN DE " & FILAORDENES.MOTIVOORIGEN & " - " & FILAORDENES.CAUSARIGEN & " CON NUMERO: " & ORD_ORDENINT & " PARA EL " & DT_FECHA.Value.ToShortDateString

        ENVIA_MENSAJE()
        CARGA_ORDENESPENDIENTES()
        Cursor = DefaultCursor
    End Sub
    Private Sub BTN_CERRAR_COORD_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_COORD.Click
        P_CALENDARIO.Visible = False
    End Sub

End Class