Public Class BUSQUEDA

    'VARIABLES DE AGENDA
    'Dim TIEMPOREALint As Integer
    Dim BUSQUEDA_GESTIONROW As DataRow
    Dim BUSQUEDA_TRABAJOROW As DataRow
    Dim BUSQUEDA_ORDENESRow As DataRow
    '  Dim LARGONOMBRE As Integer
    '  Dim APELLIDOASIG As String
    '  Dim MENSAJE_GEST(100) As String
    '  Dim MENSAJE_DUPLI(100) As String
    ' Dim TOTAL_CAMBIOS As Integer
    ' Dim TOTAL_DUPLI As Integer

    ' Dim NOMBREASIG As String
    ' Dim SECTORASIG As String

    ' Dim NewRELEVAMIENTO As MDUDataSet.RELEVAMIENTOMDURow
    'Dim NewRECLAMOSRow As ORDENESDataSet.GRAF_REDESRow
    'Dim NewORDINALESRow As ORDENESDataSet.GRAF_ORDINALESRow
    'Dim NewORDENRow As ORDENESDataSet.CREAR_ORDRow

    'VARIABLES EDICION REGISTROS

    'Dim RECDATAROW As DataRow

    ' Dim AGENDADORow As DataRow
    '  Dim HISTORICORow As DataRow
    ' Dim HISTORICO1Row As DataRow
    ' Dim HISTORICO2Row As DataRow

    ' Dim UI_DATAGRID_ROW As Integer
    ' Dim UI_DATAGRID_ROW_OLD As Integer
    ' Dim NODO As String
    ' Dim MIZONA As String

    '  Dim HABILITARCAMPOSGEST As String


    '  Dim FILTROZONA As String
    '  Dim CAMPOFILTRO(4) As String
    '  Dim EXPRFILTRO(4) As String
    '  Dim FILTRO(4) As String

    'Dim FECHADESDE As Date
    'Dim FECHAHASTA As Date

    'Dim I As Integer

    'Dim NROZONA As Integer
    'Dim CANTREC As Integer
    'Dim CANTRECZONA As Integer
    'Dim CANTRECNODO As Integer
    'Dim CANTRECTOTAL As Integer
    'Dim CANTRECMAX As Integer
    'Dim NUEVONODO As String


    'Private Sub OBTIENE_ZONA()

    '    'OBTIENE EL NUMERO DE LA ZONA
    '    Dim subString As String = Strings.Right(RECDATAROW("ZONA"), 2)
    '    If GetChar(subString, 1) = "0" Then
    '        MIZONA = Strings.Right(RECDATAROW("ZONA"), 1)
    '    Else
    '        MIZONA = subString
    '    End If
    '    NROZONA = CInt(MIZONA)
    'End Sub
    'Private Sub GRABA_NODOYORDINAL()

    '    NewORDINALESRow("NODO") = RECDATAROW("NODO")
    '    CANTREC = CANTREC + 1
    '    NewORDINALESRow(MIZONA) = CANTREC

    '    If CANTREC > CANTRECMAX Then CANTRECMAX = CANTREC

    '    If RECDATAROW("ZONA") <> ORDENESDataSet.ORDENES.Rows(I + 1).Item("ZONA") Then
    '        CANTRECNODO = CANTRECNODO + CANTREC
    '        CANTREC = 0
    '    End If

    'End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        CURSOR_WAIT(True, Me)
        '   ACCESO_DESDE = "BUSQUEDA"
        If OrdenesDataSet2.GESTION.Rows.Count > 0 Then
            BUSQUEDA_GESTIONROW = OrdenesDataSet2.GESTION.Rows(GESTIONBindingSource.Position)
            ACCESO_TIPO = "GESTION"
            ACCESO_DESDE = "BUSCADOR"
            ACCESO_GESTION = BUSQUEDA_GESTIONROW("ID_GESTION")
            If BUSQUEDA_GESTIONROW("AREA") = "MDU" Then
                INGRESO_AREA = "MDU"
            Else
                INGRESO_AREA = BUSQUEDA_GESTIONROW("AREA")
                If BUSQUEDA_GESTIONROW("AREA") = "RED" Then
                    DATOS.GEST_NODO.Text = BUSQUEDA_GESTIONROW("NODO")
                End If
            End If
            abrirDatos()
        End If
        CURSOR_WAIT(False, Me)

    End Sub 'ACCEDER A DATOS DESDE LA GESTION
    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick

        CURSOR_WAIT(True, Me)

        If OrdenesDataSet1.TRABAJOS.Rows.Count > 0 Then
            GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet3.GESTION, DataGridView2.CurrentRow.Cells.Item(1).Value)
            BUSQUEDA_GESTIONROW = OrdenesDataSet3.GESTION.Rows(0)
            ACCESO_TIPO = "TRABAJO"
            ACCESO_DESDE = "BUSCADOR"

            If BUSQUEDA_TRABAJOROW("AREA") = "MDU" Then
                INGRESO_AREA = "MDU"
                BUSCA_PRIM = BUSQUEDA_GESTIONROW("ID_GESTION")
            Else
                INGRESO_AREA = BUSQUEDA_TRABAJOROW("AREA")
                If BUSQUEDA_GESTIONROW("AREA") = "RED" Then
                    DATOS.GEST_NODO.Text = BUSQUEDA_GESTIONROW("NODO")
                End If
            End If
            ACCESO_GESTION = BUSQUEDA_GESTIONROW("ID_GESTION")
            ACCESO_TRABAJO = BUSQUEDA_TRABAJOROW("ID_TRABAJO")
            abrirDatos()
        End If
        CURSOR_WAIT(False, Me)
    End Sub 'ACCEDER A DATOS DESDE EL TRABAJO
    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick
        CURSOR_WAIT(True, Me)
        If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
            BUSQUEDA_ORDENESRow = OrdenesDataSet1.ORDENES.Rows(ORDENESBindingSource.Position)

            GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet3.GESTION, BUSQUEDA_ORDENESRow("ID_GESTION"))
            BUSQUEDA_GESTIONROW = OrdenesDataSet3.GESTION.Rows(0)
            TRABAJOSTableAdapter.FillByID_TRABAJO(OrdenesDataSet3.TRABAJOS, BUSQUEDA_ORDENESRow("ID_TRABAJO"))
            BUSQUEDA_TRABAJOROW = OrdenesDataSet3.TRABAJOS.Rows(0)

            ACCESO_TIPO = "ORDEN"
            ACCESO_DESDE = "BUSCADOR"
            ACCESO_GESTION = BUSQUEDA_ORDENESRow("ID_GESTION")
            ACCESO_TRABAJO = BUSQUEDA_ORDENESRow("ID_TRABAJO")
            NROORDENINT = BUSQUEDA_ORDENESRow("NRO_ORDENINT")

            If BUSQUEDA_GESTIONROW("AREA") = "MDU" Then
                INGRESO_AREA = "MDU"

            Else
                INGRESO_AREA = BUSQUEDA_GESTIONROW("AREA")
                If BUSQUEDA_GESTIONROW("AREA") = "RED" Then
                    DATOS.GEST_NODO.Text = BUSQUEDA_GESTIONROW("NODO")
                End If
            End If
        End If
        CURSOR_WAIT(False, Me)
        abrirDatos()
    End Sub 'ACCEDER A DATOS DESDE LA ORDEN
    'Private Sub GRABA_NODOYRECLAMO()
    '    NewRECLAMOSRow("NODO") = RECDATAROW("NODO")
    '    CANTREC = CANTREC + RECDATAROW("RECLAMOSTOT")
    '    NewRECLAMOSRow(MIZONA) = CANTREC

    '    If CANTREC > CANTRECMAX Then CANTRECMAX = CANTREC

    '    If RECDATAROW("ZONA") <> ORDENESDataSet.ORDENES.Rows(I + 1).Item("ZONA") Then
    '        CANTRECZONA = CANTRECZONA + CANTREC
    '        CANTREC = 0
    '    End If
    'End Sub

    'FIN BUSQUEDA______________________________________________________________________________
    'Private Sub PINTA_GESTIONES()
    '    Cursor = Cursors.WaitCursor

    '    If DataGridView1.Rows.Count > 0 Then

    '        For I = 0 To DataGridView1.Rows.Count - 1
    '            Select Case DataGridView1.Rows(I).Cells.Item(11).Value
    '                Case "INGRESADO"
    '                    DataGridView1.Item(15, I).Value = DateDiff(DateInterval.Day, DateValue(DataGridView1.Rows(I).Cells.Item(5).Value), DateValue(Now.ToShortDateString))
    '                    'SI LA FECHA DE HOY ES MAYOR QUE LA PREVISTA PARA INICIAR
    '                    If DateValue(Now.ToShortDateString) > DateValue(DataGridView1.Rows(I).Cells.Item(5).Value) Then
    '                        DataGridView1.Item(15, I).Style.ForeColor = Color.LightCoral
    '                        DataGridView1.Item(5, I).Style.ForeColor = Color.LightCoral
    '                        'DIFERENCIA EN DIAS ENTRE LA FECHA DE HOY Y LA PREVISTA
    '                    Else
    '                        DataGridView1.Item(5, I).Style.ForeColor = Color.LightGreen
    '                        DataGridView1.Item(15, I).Style.ForeColor = Color.LightGreen
    '                    End If
    '                Case "INICIADO"

    '                    TIEMPOREALint = DateDiff(DateInterval.Day, DateValue(DataGridView1.Rows(I).Cells.Item(6).Value), DateValue(Now.ToShortDateString))
    '                    DataGridView1.Item(9, I).Value = TIEMPOREALint

    '                    If IsDBNull(DataGridView1.Item(8, I).Value) = False Then
    '                        If DataGridView1.Item(8, I).Value <> "" Then

    '                            If TIEMPOREALint > DataGridView1.Item(8, I).Value Then
    '                                DataGridView1.Item(9, I).Style.ForeColor = Color.LightCoral
    '                            Else
    '                                DataGridView1.Item(9, I).Style.ForeColor = Color.LightGreen
    '                            End If

    '                            DataGridView1.Item(15, I).Value = TIEMPOREALint - DataGridView1.Item(8, I).Value
    '                            If DataGridView1.Item(15, I).Value <= 0 Then
    '                                DataGridView1.Item(15, I).Style.ForeColor = Color.LightGreen
    '                            Else
    '                                DataGridView1.Item(15, I).Style.ForeColor = Color.LightCoral
    '                            End If
    '                        Else
    '                            DataGridView1.Item(9, I).Style.ForeColor = Color.Purple

    '                        End If
    '                    End If
    '            End Select
    '        Next I
    '    End If
    '    Cursor = DefaultCursor
    'End Sub
    'Private Sub PINTA_TRABAJOS()
    '    'Cursor = Cursors.WaitCursor

    '    'Dim FINPREVISTO As Date
    '    'Dim FINREAL As Date
    '    'If DataGridView2.Rows.Count > 0 Then

    '    '    For I = 0 To DataGridView2.Rows.Count - 1
    '    '        Select Case DataGridView2.Rows(I).Cells.Item(2).Value

    '    '            Case "INGRESADO"
    '    '                If IsDBNull(DataGridView2.Rows(I).Cells.Item(5).Value) = False Then
    '    '                    'SI FECHA DE HOY ES MAYOR QUE FECHA ESTIMADA DE INICIO
    '    '                    'DIFERENCIA EN DIAS ENTRE FECHA ESTIMADA Y FECHA DE HOY
    '    '                    DataGridView2.Item(15, I).Value = DateDiff(DateInterval.Day, DateValue(DataGridView2.Rows(I).Cells.Item(5).Value), DateValue(Now.ToShortDateString))
    '    '                    If DateValue(Now.ToShortDateString) > DateValue(DataGridView2.Rows(I).Cells.Item(5).Value) Then

    '    '                        DataGridView2.Item(5, I).Style.ForeColor = Color.LightCoral
    '    '                        DataGridView2.Item(15, I).Style.ForeColor = Color.LightCoral

    '    '                    Else
    '    '                        DataGridView2.Item(15, I).Style.ForeColor = Color.LightGreen
    '    '                        DataGridView2.Item(15, I).Style.ForeColor = Color.LightGreen
    '    '                    End If
    '    '                End If
    '    '            Case "INICIADO"

    '    '                TIEMPOREALint = DateDiff(DateInterval.Day, DateValue(DataGridView2.Rows(I).Cells.Item(6).Value), DateValue(Now.ToShortDateString))
    '    '                DataGridView2.Item(9, I).Value = TIEMPOREALint
    '    '                If IsDBNull(DataGridView2.Item(8, I).Value) = False Then
    '    '                    If DataGridView2.Item(8, I).Value <> "" Then
    '    '                        'SI EL TIEMPO REAL ES MAYOR QUE EL PREVISTO                                DataGridView2.Item(15, I).Value = TIEMPOREALint - DataGridView2.Item(8, I).Value
    '    '                        If TIEMPOREALint >= DataGridView2.Item(8, I).Value Then
    '    '                            DataGridView2.Item(9, I).Style.ForeColor = Color.LightCoral
    '    '                            DataGridView2.Item(15, I).Style.ForeColor = Color.LightCoral
    '    '                        Else
    '    '                            DataGridView2.Item(9, I).Style.ForeColor = Color.LightGreen
    '    '                            DataGridView2.Item(15, I).Style.BackColor = Color.LightGreen
    '    '                        End If
    '    '                    Else
    '    '                        DataGridView2.Item(9, I).Style.ForeColor = Color.Purple
    '    '                        DataGridView2.Item(15, I).Style.BackColor = Color.Purple
    '    '                    End If
    '    '                End If

    '    '            Case "FINALIZADO"

    '    '                If IsDBNull(DataGridView2.Item(7, I).Value) = False Then
    '    '                    If IsDBNull(DataGridView2.Item(8, I).Value) = False Then
    '    '                        'FIN PREVISTO = INICIO ESTIMADO MAS DIAS DE DURACION
    '    '                        If DataGridView2.Item(8, I).Value <> "" Then
    '    '                            TIEMPOREALint = DateDiff(DateInterval.Day, DataGridView2.Item(6, I).Value, DataGridView2.Item(7, I).Value)
    '    '                            FINPREVISTO = DateAdd(DateInterval.Day, DataGridView2.Item(8, I).Value, DataGridView2.Item(5, I).Value)
    '    '                            FINREAL = DateAdd(DateInterval.Day, TIEMPOREALint, DataGridView2.Item(6, I).Value)
    '    '                            'DEMORA = FECHA FIN REALIZADO - FECHA FIN PREVISTA
    '    '                            DataGridView2.Item(10, I).Value = DateDiff(DateInterval.Day, FINPREVISTO, FINREAL)
    '    '                            DataGridView2.Item(9, I).Value = TIEMPOREALint
    '    '                            'SI EL TIEMPO REAL ES MAYOR QUE EL PREVISTO

    '    '                            If DataGridView2.Item(10, I).Value <= 0 Then
    '    '                                DataGridView2.Item(10, I).Style.ForeColor = Color.LightGreen
    '    '                            Else
    '    '                                DataGridView2.Item(10, I).Style.ForeColor = Color.LightCoral
    '    '                            End If

    '    '                            If DataGridView2.Item(6, I).Value <= DataGridView2.Item(5, I).Value Then
    '    '                                DataGridView2.Item(5, I).Style.ForeColor = Color.LightGreen
    '    '                            Else
    '    '                                DataGridView2.Item(5, I).Style.ForeColor = Color.LightCoral
    '    '                            End If

    '    '                            If TIEMPOREALint <= DataGridView2.Item(8, I).Value Then
    '    '                                DataGridView2.Item(8, I).Style.ForeColor = Color.LightGreen
    '    '                            Else
    '    '                                DataGridView2.Item(8, I).Style.ForeColor = Color.LightCoral
    '    '                            End If
    '    '                        Else
    '    '                            DataGridView2.Item(9, I).Style.ForeColor = Color.Purple
    '    '                            DataGridView2.Item(15, I).Style.BackColor = Color.Purple
    '    '                        End If
    '    '                    End If
    '    '                End If
    '    '        End Select
    '    '    Next I
    '    'End If

    '    'Cursor = DefaultCursor
    'End Sub
    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs)

        'If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
        '    NROORDENINT = Me.DataGridView3.CurrentRow.Cells.Item(0).Value
        '    NROORDINAL = Me.DataGridView3.CurrentRow.Cells.Item(1).Value
        '    ORDSTATUS = Me.DataGridView3.CurrentRow.Cells.Item(2).Value
        '    'TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, Me.DataGridView3.CurrentRow.Cells.Item(16).Value)
        '    'GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, Me.DataGridView3.CurrentRow.Cells.Item(15).Value)
        'End If
        ''End Try
    End Sub
    'Private Sub condicionales()
    '    If CBSector.Text = "Seleccione" Then
    '        MsgBox("Seleccione un SECTOR para la busqueda")
    '        CBSector.Focus()
    '        Exit Sub
    '    Else
    '        If CBNivel.Text = "Seleccione" Then
    '            MsgBox("Seleccione un NIVEL para la busqueda")
    '            CBNivel.Focus()
    '            Exit Sub
    '        Else
    '            If CBTipo.Text = "Seleccione" Then
    '                MsgBox("Seleccione un sector para la busqueda")
    '                CBTipo.Focus()
    '                Exit Sub
    '            Else
    '                If CBNodo.Text = "" Then
    '                    MsgBox("Seleccione un NODO para la busqueda")
    '                    CBNodo.Focus()
    '                    Exit Sub
    '                Else
    '                    If CBNivel.Text <> "GESTION" Then
    '                        If TXTZona.Text = "" Then
    '                            MsgBox("Complete la ZONA para la busqueda")
    '                            TXTZona.Focus()
    '                            Exit Sub
    '                        End If
    '                    End If
    '                    If CBNivel.Text <> "ORDEN" Then
    '                        If CBStatus.Text = "Seleccione" Then
    '                            MsgBox("Selecciones un STATUS para la busqueda")
    '                            CBStatus.Focus()
    '                            Exit Sub
    '                        End If
    '                    Else

    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub
    Private Sub BUSQUEDA_Load(sender As Object, e As EventArgs) Handles Me.Load

        If SECTOR = "GERENCIA" Or SECTOR = "PLANIFICACION TECNICA" Then
            Button8.Visible = True
        Else
            Button8.Visible = False
        End If

        'CAMPOS DE VISTA DE ORDENES
        FECHA_HASTA.Value = Now.ToShortDateString
        FECHA_DESDE.Value = DateAdd(DateInterval.Day, -30, Now)
    End Sub
    'Private Sub PINTA_GRAF()
    '    Dim CANT As Integer

    '    Dim CANTINT As Integer
    '    Dim CANTGREEN As Integer
    '    Dim CANTLIGHTGREEN As Integer
    '    Dim CANTYELLOW As Integer
    '    Dim CANTORANGE As Integer
    '    Dim CANTRED As Integer

    '    CANTINT = CInt(CANTMAXREC.Text / 5)
    '    CANTGREEN = CANTINT
    '    CANTLIGHTGREEN = 2 * CANTINT
    '    CANTYELLOW = 3 * CANTINT
    '    CANTORANGE = 4 * CANTINT
    '    CANTRED = 5 * CANTINT

    '    For I = 0 To GRAFTIPOFUENTEDataGridView.Rows.Count - 1
    '        For X = 1 To 29
    '            If IsDBNull(GRAFTIPOFUENTEDataGridView.Item(X, I).Value) = False Then
    '                CANT = GRAFTIPOFUENTEDataGridView.Item(X, I).Value

    '                If CANT > 0 And CANT < CANTGREEN Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Green
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '                If CANT >= CANTGREEN And CANT < CANTLIGHTGREEN Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTLIGHTGREEN And CANT < CANTYELLOW Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Yellow
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTYELLOW And CANT < CANTORANGE Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Orange
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTORANGE And CANT < CANTRED Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Red
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '                If CANT >= CANTRED Then
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.DarkRed
    '                    GRAFTIPOFUENTEDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '            End If
    '        Next X
    '    Next I


    '    For I = 0 To GRAFTIPOFUENTEDataGridView.Rows.Count - 1

    '        For X = 1 To 29
    '            Select Case Trim(GRAFTIPOFUENTEDataGridView.Rows(I).Cells.Item(0).Value)
    '                Case = "A"
    '                    If X > 26 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "B"
    '                    If X > 17 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "C"
    '                    If X > 14 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "CAB"
    '                    If X > 13 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "D"
    '                    If X > 26 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "E"
    '                    If X > 20 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "F"
    '                    If X > 16 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "G"
    '                    If X < 6 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 8 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "H"
    '                    If X > 18 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "I"
    '                    If X > 19 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "J"
    '                    If X > 18 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "K"
    '                    If X > 12 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "L"
    '                    If X > 10 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "M"
    '                    If X > 17 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "N"
    '                    If X > 15 And X < 18 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite

    '                    If X > 23 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "O"
    '                    If X > 29 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "P"
    '                    If X > 16 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "Q"
    '                    If X = 1 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 26 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "R"
    '                    If X > 28 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "S"
    '                    If X = 25 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 26 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "T"
    '                    If X > 22 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "U"
    '                    If X > 17 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "V"
    '                    If X > 23 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "W"
    '                    If X > 19 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "X"
    '                    If X > 7 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "Y"
    '                    If X > 23 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "ZB"
    '                    If X > 5 Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '            End Select

    '        Next X
    '    Next I
    'End Sub
    'Private Sub BOT_CALCULARORD_Click(sender As Object, e As EventArgs)

    '    ORDENESDataSet.GRAF_ORDINALES.Clear()
    '    CANTRECMAX = 0
    '    CANTMAXREC.Text = CANTRECMAX
    '    CANTRECTOTAL = 0
    '    TOTAL.Text = ""
    '    CANTREC = 0
    '    CANTRECZONA = 0
    '    FECHADESDE = FECHADESDEORD.Value.ToShortDateString
    '    FECHAHASTA = FECHAHASTAORD.Value.ToShortDateString

    '    Select Case OPCIONORD.Text
    '        Case "TODOS"
    '            ORDENESTableAdapter.FillByFULL(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "CORRECTIVOS TODOS"
    '            ORDENESTableAdapter.FillByCORRECTIVO(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "CORRECTIVOS SIN SEÑAL"
    '            ORDENESTableAdapter.FillByCORRESS(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "CORRECTIVOS 446 Y 771"
    '            ORDENESTableAdapter.FillByCORROTROS(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "MANT PREVENTIVO"
    '            ORDENESTableAdapter.FillByPREVENTIVO(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "MANT PREDICTIVO"
    '            ORDENESTableAdapter.FillByPREDICTIVO(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '    End Select


    '    If ORDENESDataSet.ORDENES.Rows.Count = 0 Then
    '        MsgBox("NO EXISTEN ORDINALES PARA LAS FECHAS SELECIONADAS")
    '        Exit Sub
    '    End If


    '    NewORDINALESRow = ORDENESDataSet.GRAF_ORDINALES.NewGRAF_ORDINALESRow

    '    For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 2
    '        RECDATAROW = ORDENESDataSet.ORDENES.Rows(I)

    '        If Len(RECDATAROW("ZONA")) < 6 Then
    '            If (RECDATAROW("ZONA")) <> "-" Then
    '                OBTIENE_ZONA()

    '                If I < ORDENESDataSet.ORDENES.Rows.Count Then

    '                    If RECDATAROW("NODO") = ORDENESDataSet.ORDENES.Rows(I + 1).Item("NODO") Then
    '                        NUEVONODO = "NO"
    '                    Else
    '                        NUEVONODO = "SI"
    '                    End If

    '                    GRABA_NODOYORDINAL()

    '                    If NUEVONODO = "SI" Then
    '                        NewORDINALESRow("30") = CANTRECNODO
    '                        CANTRECTOTAL = CANTRECTOTAL + CANTRECNODO
    '                        CANTRECNODO = 0

    '                        ORDENESDataSet.GRAF_ORDINALES.AddGRAF_ORDINALESRow(NewORDINALESRow)
    '                        NewORDINALESRow = ORDENESDataSet.GRAF_ORDINALES.NewGRAF_ORDINALESRow
    '                    End If

    '                End If
    '            End If
    '        End If
    '    Next I

    '    Dim subString As String = Microsoft.VisualBasic.Strings.Right(ORDENESDataSet.ORDENES.Rows(I)("ZONA"), 2)
    '    If GetChar(subString, 1) = "0" Then
    '        MIZONA = Microsoft.VisualBasic.Strings.Right(ORDENESDataSet.ORDENES.Rows(I)("ZONA"), 1)
    '    Else
    '        MIZONA = subString
    '    End If
    '    NROZONA = CInt(MIZONA)

    '    NewORDINALESRow("NODO") = ORDENESDataSet.ORDENES.Rows(I).Item("NODO")
    '    CANTREC = CANTREC + 1
    '    NewORDINALESRow(MIZONA) = CANTREC
    '    If CANTREC > CANTRECMAX Then CANTRECMAX = CANTREC

    '    CANTRECNODO = CANTRECNODO + CANTREC
    '    CANTREC = 0

    '    NewORDINALESRow("30") = CANTRECNODO
    '    CANTRECTOTAL = CANTRECTOTAL + CANTRECNODO
    '    CANTRECNODO = 0

    '    ORDENESDataSet.GRAF_ORDINALES.AddGRAF_ORDINALESRow(NewORDINALESRow)

    '    CANTMAXORD.Text = CANTRECMAX
    '    TOTALORD.Text = CANTRECTOTAL

    '    PINTA_ORDCORR()
    'End Sub
    'Private Sub PINTA_ORDCORR()
    '    Dim CANT As Integer

    '    Dim CANTINT As Integer
    '    Dim CANTGREEN As Integer
    '    Dim CANTLIGHTGREEN As Integer
    '    Dim CANTYELLOW As Integer
    '    Dim CANTORANGE As Integer
    '    Dim CANTRED As Integer

    '    CANTINT = CInt(CANTMAXORD.Text / 5)
    '    CANTGREEN = CANTINT
    '    CANTLIGHTGREEN = 2 * CANTINT
    '    CANTYELLOW = 3 * CANTINT
    '    CANTORANGE = 4 * CANTINT
    '    CANTRED = 5 * CANTINT

    '    For I = 0 To GRAFORDINALESDataGridView.Rows.Count - 1
    '        For X = 1 To 29
    '            If IsDBNull(GRAFORDINALESDataGridView.Item(X, I).Value) = False Then
    '                CANT = GRAFORDINALESDataGridView.Item(X, I).Value

    '                If CANT > 0 And CANT < CANTGREEN Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.Green
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '                If CANT >= CANTGREEN And CANT < CANTLIGHTGREEN Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTLIGHTGREEN And CANT < CANTYELLOW Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.Yellow
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTYELLOW And CANT < CANTORANGE Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.Orange
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.Black
    '                End If
    '                If CANT >= CANTORANGE And CANT < CANTRED Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.Red
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '                If CANT >= CANTRED Then
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.DarkRed
    '                    GRAFORDINALESDataGridView.Item(X, I).Style.ForeColor = Color.White
    '                End If
    '            End If
    '        Next X
    '    Next I

    '    For I = 0 To GRAFORDINALESDataGridView.Rows.Count - 1

    '        For X = 1 To 29
    '            Select Case Trim(GRAFORDINALESDataGridView.Rows(I).Cells.Item(0).Value)
    '                Case = "A"
    '                    If X > 26 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "B"
    '                    If X > 17 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "C"
    '                    If X > 14 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "CAB"
    '                    If X > 13 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "D"
    '                    If X > 26 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "E"
    '                    If X > 20 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "F"
    '                    If X > 16 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "G"
    '                    If X < 6 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 8 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "H"
    '                    If X > 18 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "I"
    '                    If X > 19 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "J"
    '                    If X > 18 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "K"
    '                    If X > 12 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "L"
    '                    If X > 10 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "M"
    '                    If X > 17 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "N"
    '                    If X > 15 And X < 18 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite

    '                    If X > 23 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "O"
    '                    If X > 29 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "P"
    '                    If X > 16 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "Q"
    '                    If X = 1 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 26 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "R"
    '                    If X > 28 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "S"
    '                    If X = 25 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                    If X > 26 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "T"
    '                    If X > 22 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "U"
    '                    If X > 17 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "V"
    '                    If X > 23 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "W"
    '                    If X > 19 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "X"
    '                    If X > 7 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "Y"
    '                    If X > 23 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '                Case = "ZB"
    '                    If X > 5 Then GRAFORDINALESDataGridView.Item(X, I).Style.BackColor = Color.FloralWhite
    '            End Select

    '        Next X
    '    Next I
    'End Sub
    'BUSQUEDA DE GESTIONES/TREABAJOS/ORDENES_________________________________________________________
    Private Sub CBSector_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBSector.SelectedIndexChanged

        If CBNivel.Text <> "Seleccione" Then
            'BORRA LOS ITEMS DE COMBOS
            CBTipo.Items.Clear()
            CBStatus.Items.Clear()

            'BORRA LOS TEXTOS

            ' TRAB_RESPONSABLE.Text = ""


            Select Case CBNivel.Text
                Case "GESTION"
                    Select Case CBSector.Text
                        Case "RED"
                            CBTipo.Items.Add("MANT DISTRIBUCION - CRUCES")
                            CBTipo.Items.Add("MANT DISTRIBUCION")
                            CBTipo.Items.Add("MANT TRONCALES")
                            CBTipo.Items.Add("MANT FIBRA")
                            CBTipo.Items.Add("MODIF DE RED")
                            CBTipo.Items.Add("CONST DE RED")
                            CBTipo.Items.Add("CONST DE FIBRA")
                            CBTipo.Items.Add("MANT SOPORTES DE RED")
                            CBTipo.Items.Add("RELEVAMIENTO PRE GESTION")
                            CBTipo.Items.Add("PREVENTIVO PUNTUAL")

                            'CBTipo.Items.Add("MANT SOPORTES DE RED")
                        Case "MDU"
                            CBTipo.Items.Add("MANT PREVENTIVO")
                            CBTipo.Items.Add("OBRA NUEVA")
                        Case "FUENTE"
                            CBTipo.Items.Add("MANTENIMIENTO PROGRAMADO DE FUENTES")
                            CBTipo.Items.Add("INSTALACION / RETIRO DE FUENTE X OBRA")
                            CBTipo.Items.Add("TRABAJOS DE LABORATORIO")
                    End Select
                Case "TRABAJO"
                    Select Case CBSector.Text
                        Case "RED"
                            CBTipo.Items.Add("RELEVAMIENTO")
                            CBTipo.Items.Add("DISEÑO")
                            CBTipo.Items.Add("PREDICTIVO")
                            CBTipo.Items.Add("PREVENTIVO")
                            CBTipo.Items.Add("CONSTRUCCION")
                            CBTipo.Items.Add("GESTION OC")
                        Case "MDU"
                            CBTipo.Items.Add("RELEVAMIENTO")
                            CBTipo.Items.Add("ADMINISTRATIVO")
                            CBTipo.Items.Add("DISEÑO")
                            CBTipo.Items.Add("PREDICTIVO")
                            CBTipo.Items.Add("PREVENTIVO")
                            CBTipo.Items.Add("EJECUCION")
                            CBTipo.Items.Add("PRESUPUESTO")
                            CBTipo.Items.Add("APROBACION PERMISOS")
                            CBTipo.Items.Add("APROBACION IMM")
                            CBTipo.Items.Add("AUTORIZACION CABLEADO")
                            CBTipo.Items.Add("GESTION OC")
                            CBTipo.Items.Add("GESTION RED")
                        Case "FUENTES"
                            CBTipo.Items.Add("REEMPLAZO DE BATERIAS")
                            CBTipo.Items.Add("MEDICION Y CONTROL DE FUENTE")
                            CBTipo.Items.Add("RELEVAMIENTO")
                            CBTipo.Items.Add("REEMPLAZO DE FUENTE")
                            CBTipo.Items.Add("MANTENIMIENTO PREVENTIVO DE FUENTES")
                            CBTipo.Items.Add("REPARACION DE FUENTE")
                            CBTipo.Items.Add("CAMBIO DE UBICACION")
                            CBTipo.Items.Add("TRABAJOS DE RED")
                            CBTipo.Items.Add("INSTALACION DE FUENTE X OBRA")
                            CBTipo.Items.Add("RETIRO DE FUENTE X OBRA")
                            CBTipo.Items.Add("CONTROL BATERIAS")
                            CBTipo.Items.Add("CONTROL DE COMPONENTES DE FUENTES")

                    End Select
                Case "ORDEN"
                    CBTipo.Items.Add("Seleccionar")
                    CBTipo.Text = "Seleccionar"
                    CBTipo.Items.Add("ADMINISTRACION")
                    CBTipo.Items.Add("CUADRILLAS")
                    CBTipo.Items.Add("DISEÑO")
                    CBTipo.Items.Add("ENERGIA")
                    CBTipo.Items.Add("FIBRA")
                    CBTipo.Items.Add("GERENCIA")
                    CBTipo.Items.Add("JEFATURA")
                    CBTipo.Items.Add("MANTENIMIENTO")
                    CBTipo.Items.Add("OBRA CIVIL")
                    CBTipo.Items.Add("PLANIFICACION TECNICA")
                    CBTipo.Items.Add("SUPERVISION")


            End Select
            'CONFIGURAMOS EL STATUS COMBOBOX
            If CBNivel.Text <> "" Then
                Select Case CBNivel.Text
                    Case "ORDEN"
                        CBStatus.Text = "NO APLICA"
                    Case "TRABAJO"
                        CBStatus.Text = "Seleccione"
                        CBStatus.Items.Add("ANULADO")
                        CBStatus.Items.Add("DEMORADO")
                        CBStatus.Items.Add("CANCELADO")
                        CBStatus.Items.Add("COORDINADO")
                        CBStatus.Items.Add("FINALIZADO")
                        CBStatus.Items.Add("INGRESADO")
                        CBStatus.Items.Add("INICIADO")
                    Case "GESTION"
                        CBStatus.Text = "Seleccione"
                        CBStatus.Items.Add("TODOS")
                        CBStatus.Items.Add("ANULADO")
                        CBStatus.Items.Add("DEMORADO")
                        CBStatus.Items.Add("CANCELADO")
                        CBStatus.Items.Add("FINALIZADO")
                        CBStatus.Items.Add("INGRESADO")
                        CBStatus.Items.Add("INICIADO")
                End Select
            End If
        End If
    End Sub
    Private Sub CBNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNivel.SelectedIndexChanged
        CBSector.Items.Clear()
        CBTipo.Items.Clear()
        CBStatus.Items.Clear()
        If CBNivel.Text = "Seleccione" Then
            CBSector.Items.Clear()
            CBTipo.Items.Clear()
            CBStatus.Items.Clear()
        Else
            Select Case CBNivel.Text
                Case "GESTION", "TRABAJO"
                    CBSector.Text = "Seleccione"
                    CBSector.Items.Add("RED")
                    CBSector.Items.Add("MDU")
                    CBSector.Items.Add("FUENTES")
                Case "ORDEN"
                    CBSector.Text = "Seleccione"
                    CBSector.Items.Add("RED")
                    CBSector.Items.Add("MDU")
                    CBSector.Items.Add("CUADRILLAS DE RED")
                    CBSector.Items.Add("CUADRILLAS MDU")
                    CBSector.Items.Add("RELEVAMIENTOS")
                    CBSector.Items.Add("OBRA CIVIL")
                    CBSector.Items.Add("GUARDIA")
            End Select
        End If
    End Sub
    Private Sub CKFechasSOL_CheckedChanged_1(sender As Object, e As EventArgs) Handles CKFechasSOL.CheckedChanged
        If CKFechasSOL.Checked = True Then
            LBLInicio.Visible = True
            LBLFin.Visible = True
            DTInicio.Visible = True
            DTInicio.Value = DateAdd(DateInterval.Month, -1, Today)
            DTFin.Visible = True
            DTFin.Value = Today
        Else
            LBLInicio.Visible = False
            LBLFin.Visible = False
            DTInicio.Visible = False
            DTFin.Visible = False

        End If
    End Sub
    Private Sub DataGridView3_Click(sender As Object, e As EventArgs) Handles DataGridView3.Click
        If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
            BUSQUEDA_ORDENESRow = OrdenesDataSet1.ORDENES.Rows(ORDENESBindingSource.Position)
            NROORDENINT = BUSQUEDA_ORDENESRow("NRO_ORDENINT")
            NROORDINAL = BUSQUEDA_ORDENESRow("NRO_ORDINAL")

            ORDSTATUS = BUSQUEDA_ORDENESRow("STATUS")
            If OrdenesDataSet1.TRABAJOS.Rows.Count < 1 Then
                TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, BUSQUEDA_ORDENESRow("ID_TRABAJO"))
            End If
            If OrdenesDataSet2.GESTION.Rows.Count < 1 Then
                GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, BUSQUEDA_ORDENESRow("ID_GESTION"))
            End If
        End If
    End Sub
    'Private Sub BOT_CALCULAR_Click(sender As Object, e As EventArgs) Handles BOT_CALCULAR.Click
    '    Me.Cursor = Cursors.WaitCursor

    '    ORDENESDataSet.GRAF_REDES.Clear()
    '    CANTRECMAX = 0
    '    CANTMAXREC.Text = CANTRECMAX
    '    CANTRECTOTAL = 0
    '    TOTAL.Text = ""
    '    CANTREC = 0
    '    CANTRECZONA = 0
    '    FECHADESDE = DESDE.Value.ToShortDateString
    '    FECHAHASTA = HASTA.Value.ToShortDateString


    '    Select Case OPCION.Text
    '        Case "TODOS"
    '            Me.ORDENESTableAdapter.FillByTODOS(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "SOLO SIN SEÑAL"
    '            Me.ORDENESTableAdapter.FillBySINSEÑAL(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "446 Y 771"
    '            Me.ORDENESTableAdapter.FillByDISTSS(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '        Case "CAUSA UTE"
    '            Me.ORDENESTableAdapter.FillByUTE(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)
    '    End Select

    '    BAR_CANTRECLAMOS.Maximum = ORDENESDataSet.ORDENES.Rows.Count

    '    If ORDENESDataSet.ORDENES.Rows.Count = 0 Then
    '        MsgBox("NO EXISTEN RECLAMOS PARA LAS FECHAS SELECIONADAS")
    '        Exit Sub
    '    End If

    '    NewRECLAMOSRow = ORDENESDataSet.GRAF_REDES.NewGRAF_REDESRow

    '    For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 2

    '        BAR_CANTRECLAMOS.Value = I + 1
    '        BAR_CANTRECLAMOS.Refresh()

    '        RECDATAROW = ORDENESDataSet.ORDENES.Rows(I)
    '        If Len(RECDATAROW("ZONA")) < 6 Then
    '            If (RECDATAROW("ZONA")) <> "-" Then
    '                OBTIENE_ZONA()
    '                If I < ORDENESDataSet.ORDENES.Rows.Count Then
    '                    If RECDATAROW("NODO") = ORDENESDataSet.ORDENES.Rows(I + 1).Item("NODO") Then
    '                        NUEVONODO = "NO"
    '                    Else
    '                        NUEVONODO = "SI"
    '                    End If

    '                    GRABA_NODOYRECLAMO()

    '                    If NUEVONODO = "SI" Then
    '                        NewRECLAMOSRow("30") = CANTRECZONA
    '                        CANTRECTOTAL = CANTRECTOTAL + CANTRECZONA
    '                        CANTRECZONA = 0
    '                        ORDENESDataSet.GRAF_REDES.AddGRAF_REDESRow(NewRECLAMOSRow)
    '                        NewRECLAMOSRow = ORDENESDataSet.GRAF_REDES.NewGRAF_REDESRow
    '                    End If

    '                End If
    '            End If
    '        End If
    '    Next I



    '    Dim subString As String = Microsoft.VisualBasic.Strings.Right(ORDENESDataSet.ORDENES.Rows(I)("ZONA"), 2)
    '    If GetChar(subString, 1) = "0" Then
    '        MIZONA = Microsoft.VisualBasic.Strings.Right(ORDENESDataSet.ORDENES.Rows(I)("ZONA"), 1)
    '    Else
    '        MIZONA = subString
    '    End If
    '    NROZONA = CInt(MIZONA)

    '    NewRECLAMOSRow("NODO") = ORDENESDataSet.ORDENES.Rows(I).Item("NODO")
    '    CANTREC = CANTREC + ORDENESDataSet.ORDENES.Rows(I).Item("RECLAMOSTOT")
    '    NewRECLAMOSRow(MIZONA) = CANTREC
    '    If CANTREC > CANTRECMAX Then CANTRECMAX = CANTREC

    '    CANTRECZONA = CANTRECZONA + CANTREC
    '    CANTREC = 0

    '    NewRECLAMOSRow("30") = CANTRECZONA
    '    CANTRECTOTAL = CANTRECTOTAL + CANTRECZONA
    '    CANTRECZONA = 0

    '    ORDENESDataSet.GRAF_REDES.AddGRAF_REDESRow(NewRECLAMOSRow)
    '    CANTMAXREC.Text = CANTRECMAX
    '    TOTAL.Text = CANTRECTOTAL
    '    PINTA_GRAF()

    '    BAR_CANTRECLAMOS.Value = 0

    '    Me.Cursor = DefaultCursor
    'End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim RESPUESTA As DialogResult = MsgBox("Esta seguro de borrar la orden seleccionada?", vbYesNo)
        If DataGridView3.SelectedRows.Count > 0 Then
            BUSQUEDA_ORDENESRow = OrdenesDataSet1.ORDENES.Rows(ORDENESBindingSource.Position)

            If RESPUESTA = DialogResult.Yes Then
                ORDENESTableAdapter.FillByIDORDENINT(OrdenesDataSet2.ORDENES, BUSQUEDA_ORDENESRow("NRO_ORDENINT"))
                OrdenesDataSet2.ORDENES.Rows(0).Delete()
                ORDENESTableAdapter.Update(OrdenesDataSet2.ORDENES)
                ORDENESTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.ORDENES, BUSQUEDA_TRABAJOROW("ID_TRABAJO"))

                MsgBox("El registro ha sido Borrado", vbInformation)
                Exit Sub
            Else

                Exit Sub
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim STATUS As String
        Dim fechaini As Date
        Dim fechafin As Date
        '  CURSOR_WAIT(True, Me)
        OrdenesDataSet2.GESTION.Clear()
        OrdenesDataSet1.TRABAJOS.Clear()
        OrdenesDataSet1.ORDENES.Clear()

        If CBStatus.Text = "Seleccione" Then
            STATUS = ""
        Else
            STATUS = CBStatus.Text
        End If
        If CKFechasSOL.Checked = True Then
            fechaini = DTInicio.Value
            fechafin = DTFin.Value
        Else
            fechaini = DateAdd(DateInterval.Year, -5, Today)
            fechafin = Today
        End If
        If TXTIdGestion.Text = "" And TXTIDTrabajo.Text = "" And TXTIDOrden.Text = "" And TXTOrdinal.Text = "" Then
            'condicionales()
            If TXTCalle.Text = "" Then
                Select Case CBNivel.Text
                    Case "GESTION"
                        If CBNodo.Text <> "" Then
                            GESTIONTableAdapter.FillByGESTBUSQUEDA(OrdenesDataSet2.GESTION, CBTipo.Text, CBNodo.Text, fechaini, fechafin, STATUS, CBSector.Text)
                        Else
                            If CBStatus.Text = "TODOS" Then
                                GESTIONTableAdapter.FillByBUSCAGESTNONODO(OrdenesDataSet2.GESTION, CBTipo.Text, fechaini, fechafin, CBSector.Text)
                            Else
                                GESTIONTableAdapter.FillByBUSCAGESTNODONOSTS(OrdenesDataSet2.GESTION, CBTipo.Text, fechaini, fechafin, CBSector.Text, CBStatus.Text)
                            End If
                        End If
                    Case "TRABAJO"
                        TRABAJOSTableAdapter.FillByTRABBUSQUEDA(OrdenesDataSet1.TRABAJOS, CBNodo.Text, STATUS, CBSector.Text, CBTipo.Text, TXTZona.Text, fechaini, fechafin)
                        If OrdenesDataSet1.TRABAJOS.Rows.Count > 0 Then
                            GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.TRABAJOS.Rows(0).Item("ID_GESTION"))
                            ORDENESTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.ORDENES, OrdenesDataSet1.TRABAJOS.Rows(0).Item("id_TRABAJO"))
                        End If
                End Select
            Else
                Select Case CBNivel.Text
                    Case "GESTION"
                        MsgBox("las GESTIONES no tienen calle, verifique el TIPO")
                    Case "TRABAJO"
                        TRABAJOSTableAdapter.FillByTRABBUSQCALLE(OrdenesDataSet1.TRABAJOS, CBTipo.Text, STATUS, CBSector.Text, CBNodo.Text, TXTZona.Text, TXTCalle.Text, fechaini, fechafin)
                        If OrdenesDataSet1.TRABAJOS.Rows.Count > 0 Then
                            GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.TRABAJOS.Rows(0).Item("ID_GESTION"))
                            ORDENESTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.ORDENES, OrdenesDataSet1.TRABAJOS.Rows(0).Item("id_TRABAJO"))
                        End If
                    Case "ORDEN"
                        ORDENESTableAdapter.FillByORDBUSQUEDA(OrdenesDataSet1.ORDENES, CBTipo.Text, CBSector.Text, CBNodo.Text, TXTZona.Text, fechaini, fechafin)
                        If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                            GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.TRABAJOS.Rows(0).Item("ID_GESTION"))
                            TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, OrdenesDataSet1.ORDENES.Rows(0).Item("ID_TRABAJO"))
                        End If
                End Select
            End If
        Else
            If TXTIdGestion.Text <> "" Then   'BUSCA POR IDGESTION
                If IsNumeric(TXTIdGestion.Text) Then
                    GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, TXTIdGestion.Text)
                    If OrdenesDataSet2.GESTION.Rows.Count > 0 Then
                        NOTIFICACION("SYS", "Solicitud encontrada!")
                    Else
                        NOTIFICACION("SYS", "Sin resultados")
                    End If
                Else
                    NOTIFICACION("SYS", "Verifique la numeración, contiene caracteres incorrectos")
                End If
            ElseIf TXTIDTrabajo.Text <> "" Then     'BUSCA POR IDTRABAJO
                If IsNumeric(TXTIDTrabajo.Text) Then
                    TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, TXTIDTrabajo.Text)
                    If OrdenesDataSet1.TRABAJOS.Rows.Count > 0 Then
                        GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.TRABAJOS.Rows(0).Item("ID_GESTION"))
                        NOTIFICACION("SYS", "Solicitud encontrada!")
                    Else
                        NOTIFICACION("SYS", "Sin resultados")
                    End If
                Else
                    MsgBox("Verifique la numeración, contiene caracteres incorrectos")
                End If
            ElseIf TXTIDOrden.Text <> "" Then  'BUSCA POR IDORDEN
                If IsNumeric(TXTIDOrden.Text) Then
                    ORDENESTableAdapter.FillByIDORDENINT(OrdenesDataSet1.ORDENES, TXTIDOrden.Text)
                    If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                        TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, OrdenesDataSet1.ORDENES.Rows(0).Item("ID_TRABAJO"))
                        GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.ORDENES.Rows(0).Item("ID_GESTION"))
                        NOTIFICACION("SYS", "Solicitud encontrada!")
                    Else
                        NOTIFICACION("SYS", "Sin resultados")
                    End If
                Else
                    NOTIFICACION("SYS", "Verifique la numeración, contiene caracteres incorrectos")
                End If
            ElseIf TXTOrdinal.Text <> "" Then 'BUSCA POR ORDINAL
                If IsNumeric(TXTOrdinal.Text) Then
                    ORDENESTableAdapter.FillByIDORDINAL(OrdenesDataSet1.ORDENES, TXTOrdinal.Text)
                    If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                        TRABAJOSTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.TRABAJOS, OrdenesDataSet1.ORDENES.Rows(0).Item("ID_TRABAJO"))
                        GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet2.GESTION, OrdenesDataSet1.ORDENES.Rows(0).Item("ID_GESTION"))
                        NOTIFICACION("SYS", "Solicitud encontrada!")
                    Else
                        NOTIFICACION("SYS", "Sin resultados")
                    End If
                Else
                    NOTIFICACION("SYS", "Verifique la numeración, contiene caracteres incorrectos")
                End If
            End If
        End If
        '   CURSOR_WAIT(False, Me)
    End Sub
    'Private Sub BOT_REDIBUJAR_Click(sender As Object, e As EventArgs) Handles BOT_REDIBUJAR.Click
    '    PINTA_GRAF()
    'End Sub
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Cursor = Cursors.WaitCursor
    '    If BUSCA_TIPOGESTION.Text = "TODAS" Then
    '        GESTIONTableAdapter.FillBySTATUS(OrdenesDataSet2.GESTION, BUSCA_STATUS.Text, FECHA_DESDE.Value, FECHA_HASTA.Value)
    '    Else
    '        GESTIONTableAdapter.FillByTIPOSTSFECHAS(OrdenesDataSet2.GESTION, BUSCA_TIPOGESTION.Text, BUSCA_STATUS.Text, FECHA_DESDE.Value, FECHA_HASTA.Value)
    '    End If
    '    PINTA_GESTIONES()
    '    'PINTA_TRABAJOS()
    '    Cursor = DefaultCursor
    'End Sub
    'Private Sub BOT_REDIBORD_Click(sender As Object, e As EventArgs) Handles BOT_REDIBORD.Click
    '    PINTA_ORDCORR()
    'End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VISTAORDINAL.Show(Me)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "FINALIZADO"
                LBLCierre.Visible = True
                CBMes.Visible = True
                CBAnio.Visible = True
                CBMes.Text = "Seleccione MES"
                CBAnio.Text = "Seleccione AÑO"
            Case Else
                LBLCierre.Visible = False
                CBMes.Visible = False
                CBAnio.Visible = False
                CBMes.Text = "TODOS"
                CBAnio.Text = "TODOS"
        End Select
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Cursor = Cursors.WaitCursor
        If OrdenesDataSet2.GESTION.Rows.Count > 0 Then
            BUSQUEDA_GESTIONROW = OrdenesDataSet2.GESTION.Rows(GESTIONBindingSource.Position)
            If IsDBNull(BUSQUEDA_GESTIONROW("DESCRIPCION")) = False Then DESCRIPCION_GEST.Text = BUSQUEDA_GESTIONROW("DESCRIPCION") Else DESCRIPCION_GEST.Text = ""
            TRABAJOSTableAdapter.FillByIDGESTION(OrdenesDataSet1.TRABAJOS, BUSQUEDA_GESTIONROW("ID_GESTION"))
        End If
        Cursor = DefaultCursor
    End Sub
    Private Sub abrirDatos()
        If DATOS.Visible = True Then
            DATOS.Close()
            If DASHBOARD.BTN1.Text = "RED" Then
                EstiloBTNCerrar(1)
            ElseIf DASHBOARD.BTN2.Text = "RED" Then
                EstiloBTNCerrar(2)
            ElseIf DASHBOARD.BTN3.Text = "RED" Then
                EstiloBTNCerrar(3)
            ElseIf DASHBOARD.BTN4.Text = "RED" Then
                EstiloBTNCerrar(4)
            ElseIf DASHBOARD.BTN5.Text = "RED" Then
                EstiloBTNCerrar(5)
            ElseIf DASHBOARD.BTN6.Text = "RED" Then
                EstiloBTNCerrar(6)
            ElseIf DASHBOARD.BTN7.Text = "RED" Then
                EstiloBTNCerrar(7)
            ElseIf DASHBOARD.BTN8.Text = "RED" Then
                EstiloBTNCerrar(8)
            End If
        End If
        DATOS.Show()
        DATOS.TopLevel = False
        DATOS.Parent = DASHBOARD.PanelTrabajo
        DATOS.Dock = DockStyle.Fill
        DATOS.Location = New Point(0, 0)
        DATOS.BringToFront()
        DATOS.LBLNODO.Visible = True
        DATOS.GEST_NODO.Visible = True
    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        If OrdenesDataSet1.TRABAJOS.Rows.Count > 0 Then
            NROTRABAJO = DataGridView2.CurrentRow.Cells.Item(0).Value
            BUSQUEDA_TRABAJOROW = OrdenesDataSet1.TRABAJOS.Rows.Find(NROTRABAJO)
            If IsDBNull(BUSQUEDA_TRABAJOROW("DESCRIPCION")) = False Then DESCRIPCION_TRAB.Text = BUSQUEDA_TRABAJOROW("DESCRIPCION") Else DESCRIPCION_TRAB.Text = ""
            ORDENESTableAdapter.FillByIDTRABAJO(OrdenesDataSet1.ORDENES, BUSQUEDA_TRABAJOROW("ID_TRABAJO"))
        End If
    End Sub
    Private Sub BTNExportarExcel_Click_1(sender As Object, e As EventArgs) Handles BTNExportarExcel.Click
        Dim MES As Integer
        Select Case CBMes.Text
            Case "ENERO"
                MES = 1
            Case "FEBRERO"
                MES = 2
            Case "MARZO"
                MES = 3
            Case "ABRIL"
                MES = 4
            Case "MAYO"
                MES = 5
            Case "JUNIO"
                MES = 6
            Case "JULIO"
                MES = 7
            Case = "AGOSTO"
                MES = 8
            Case = "SETIEMBRE"
                MES = 9
            Case = "OCTUBRE"
                MES = 10
            Case = "NOVIEMBRE"
                MES = 11
            Case = "DICIEMBRE"
                MES = 12

        End Select
        Dim INFORME_TAREAS As DataTable = New DataTable("INFORME_TAREAS")
        Dim INFORME_DATASET As DataSet
        Dim COLUMNA As DataColumn
        Dim ROW As DataRow

        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.Int32")
        COLUMNA.ColumnName = "ID_GESTION"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.Int32")
        COLUMNA.ColumnName = "ID_TRABAJO"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.Int32")
        COLUMNA.ColumnName = "ORDEN"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.Int32")
        COLUMNA.ColumnName = "ZONA"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "NODO"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "STATUS"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.DateTime")
        COLUMNA.ColumnName = "FECHAING"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.DateTime")
        COLUMNA.ColumnName = "FECHAINI"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.DateTime")
        COLUMNA.ColumnName = "FECHAFIN"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "TAREADESC"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "CANTPREVISTA"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "CANTREAL"
        INFORME_TAREAS.Columns.Add(COLUMNA)
        COLUMNA = New DataColumn()
        COLUMNA.DataType = Type.GetType("System.String")
        COLUMNA.ColumnName = "OBSTRA"
        INFORME_TAREAS.Columns.Add(COLUMNA)

        INFORME_DATASET = New DataSet()
        INFORME_DATASET.Tables.Add(INFORME_TAREAS)

        Dim CANTTAREADESC As Double
        If CBFiltroInforme.Text <> "Seleccione" Then
            If CBStatus.Text = "Seleccione STATUS" Then
                MsgBox("Seleccione un STATUS a filtrar, en caso de no querer usar el TODOS")
                CBStatus.Focus()
                Exit Sub
            End If
            If CBMes.Text = "Seleccione MES" Then
                MsgBox("Seleccione MES a filtrar, en caso de no querer usar el TODOS")
                CBMes.Focus()
                Exit Sub
            End If
            If CBAnio.Text = "Seleccione AÑo" Then
                MsgBox("Seleccione AÑo a filtrar, en caso de no querer usar el TODOS")
                CBAnio.Focus()
                Exit Sub
            End If

            'BUSCAMOS LAS TAREAS DE TODAS LAS GESTIONES FILTRADAS
            For G = 0 To OrdenesDataSet2.GESTION.Rows.Count - 1
                ProgressBar1.Maximum = OrdenesDataSet2.GESTION.Rows.Count()
                ProgressBar1.Value = G + 1
                'BUSCAMOS LOS TRABAJOS ASOCIADOS A LA GESTIONES EN G
                TRABAJOSTableAdapter.FillByIDGESTION(OrdenesDataSet2.TRABAJOS, OrdenesDataSet2.GESTION.Rows(G).Item("ID_GESTION"))
                If OrdenesDataSet2.TRABAJOS.Rows.Count > 0 Then
                    For T = 0 To OrdenesDataSet2.TRABAJOS.Rows.Count - 1
                        ProgressBar2.Maximum = OrdenesDataSet2.TRABAJOS.Rows.Count
                        ProgressBar2.Value = T + 1
                        ORDENESTableAdapter.FillByIDTRABAJO(OrdenesDataSet2.ORDENES, OrdenesDataSet2.TRABAJOS.Rows(T).Item("ID_TRABAJO"))
                        'BUSCAMOS LAS TAREAS ASOCIADAS LAS ORDENES
                        If OrdenesDataSet2.ORDENES.Rows.Count > 0 Then
                            If ComboBox1.Text = "TODOS" Then
                                For O = 0 To OrdenesDataSet2.ORDENES.Rows.Count - 1
                                    TAREASTableAdapter.FillByORDENINT(OrdenesDataSet2.TAREAS, OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT"))
                                    If OrdenesDataSet2.TAREAS.Rows.Count > 0 Then
                                        ProgressBar3.Maximum = OrdenesDataSet2.ORDENES.Rows.Count
                                        ProgressBar3.Value = O + 1
                                        'ARMAMOS EL NUEVO DATASET INFORME_TAREAS CON LOS DATOS OBTENIDOS
                                        'VERIFICAMOS PRIMERO SI TIENE TAREASDESC REPETIDAS PARA SUMAR LAS CANTREAL
                                        For Q = 0 To OrdenesDataSet2.TAREAS.Rows.Count - 1
                                            TAREASTableAdapter.FillByORDENINTyTAREADESC(OrdenesDataSet3.TAREAS, OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT"), OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC"))
                                            If OrdenesDataSet3.TAREAS.Count > 1 Then
                                                For R = 0 To OrdenesDataSet3.TAREAS.Rows.Count - 1
                                                    If OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC") = OrdenesDataSet3.TAREAS.Rows(R).Item("TAREADESC") Then
                                                        If IsDBNull(OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL")) = False Then
                                                            If OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL") > 0 Then
                                                                CANTTAREADESC += OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL")
                                                            End If
                                                        End If
                                                    End If
                                                Next
                                            Else
                                                If IsDBNull(OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL")) = False Then
                                                    If OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL") > 0 Then
                                                        CANTTAREADESC = OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL")
                                                    End If
                                                End If
                                            End If
                                            ROW = INFORME_TAREAS.NewRow()
                                            ROW("ID_GESTION") = OrdenesDataSet2.GESTION.Rows(G).Item("ID_GESTION")
                                            ROW("ID_TRABAJO") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("ID_TRABAJO")
                                            ROW("ORDEN") = OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT")
                                            ROW("STATUS") = OrdenesDataSet2.ORDENES.Rows(O).Item("STATUS")
                                            ROW("NODO") = OrdenesDataSet2.GESTION.Rows(G).Item("NODO")
                                            ROW("ZONA") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("ZONA")
                                            ROW("FECHAING") = OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAINGRESO")
                                            ROW("FECHAINI") = OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAINICIO")
                                            ROW("FECHAFIN") = OrdenesDataSet2.ORDENES.Rows(O).Item("FECHACIERRE")
                                            ROW("TAREADESC") = OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC")
                                            ROW("CANTPREVISTA") = OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTSTD")
                                            ROW("CANTREAL") = CANTTAREADESC
                                            ROW("OBSTRA") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("DESCRIPCION")
                                            INFORME_TAREAS.Rows.Add(ROW)
                                            'ARMAMOS EL DATASET NUEVO
                                            CANTTAREADESC = 0
                                        Next
                                    End If
                                Next
                            Else
                                For O = 0 To OrdenesDataSet2.ORDENES.Rows.Count - 1
                                    If OrdenesDataSet2.ORDENES.Rows(O).Item("STATUS") = "FINALIZADO" And OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDINAL") <> 0 Then
                                        If Month(OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAFIN")) = MES And Year(OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAFIN")) = CBAnio.Text Then
                                            TAREASTableAdapter.FillByORDENINT(OrdenesDataSet2.TAREAS, OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT"))
                                            If OrdenesDataSet2.TAREAS.Rows.Count > 0 Then
                                                ProgressBar3.Maximum = OrdenesDataSet2.ORDENES.Rows.Count
                                                ProgressBar3.Value = O + 1
                                                'ARMAMOS EL NUEVO DATASET INFORME_TAREAS CON LOS DATOS OBTENIDOS
                                                'VERIFICAMOS PRIMERO SI TIENE TAREASDESC REPETIDAS PARA SUMAR LAS CANTREAL

                                                For Q = 0 To OrdenesDataSet2.TAREAS.Rows.Count - 1
                                                    If OrdenesDataSet2.TAREAS.Rows(Q).Item("ORDINAL") <> 0 Then
                                                        TAREASTableAdapter.FillByORDENINTyTAREADESC(OrdenesDataSet3.TAREAS, OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT"), OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC"))
                                                        If OrdenesDataSet3.TAREAS.Count > 1 Then
                                                            For R = 0 To OrdenesDataSet3.TAREAS.Rows.Count - 1
                                                                If OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC") = OrdenesDataSet3.TAREAS.Rows(R).Item("TAREADESC") Then
                                                                    If IsDBNull(OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL")) = False Then
                                                                        If OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL") > 0 Then
                                                                            CANTTAREADESC += OrdenesDataSet3.TAREAS.Rows(R).Item("CANTREAL")
                                                                        End If
                                                                    End If
                                                                End If
                                                            Next
                                                        Else
                                                            If IsDBNull(OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL")) = False Then
                                                                If OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL") > 0 Then
                                                                    CANTTAREADESC = OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTREAL")
                                                                End If
                                                            End If
                                                        End If
                                                        ROW = INFORME_TAREAS.NewRow()
                                                        ROW("ID_GESTION") = OrdenesDataSet2.GESTION.Rows(G).Item("ID_GESTION")
                                                        ROW("ID_TRABAJO") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("ID_TRABAJO")
                                                        ROW("ORDEN") = OrdenesDataSet2.ORDENES.Rows(O).Item("NRO_ORDENINT")
                                                        ROW("STATUS") = OrdenesDataSet2.ORDENES.Rows(O).Item("STATUS")
                                                        ROW("NODO") = OrdenesDataSet2.GESTION.Rows(G).Item("NODO")
                                                        ROW("ZONA") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("ZONA")
                                                        ROW("FECHAING") = OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAINGRESO")
                                                        ROW("FECHAINI") = CDate(OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAINICIO"))
                                                        ROW("FECHAFIN") = CDate(OrdenesDataSet2.ORDENES.Rows(O).Item("FECHAFIN"))
                                                        'MsgBox(ORDENESDataSet2.ORDENES.Rows(O).Item("FECHAINICIO"))
                                                        'MsgBox(ORDENESDataSet2.ORDENES.Rows(O).Item("FECHAFIN"))
                                                        ROW("TAREADESC") = OrdenesDataSet2.TAREAS.Rows(Q).Item("TAREADESC")
                                                        ROW("CANTPREVISTA") = OrdenesDataSet2.TAREAS.Rows(Q).Item("CANTSTD")
                                                        ROW("CANTREAL") = CANTTAREADESC
                                                        ROW("OBSTRA") = OrdenesDataSet2.TRABAJOS.Rows(T).Item("DESCRIPCION")
                                                        INFORME_TAREAS.Rows.Add(ROW)
                                                        'ARMAMOS EL DATASET NUEVO
                                                        CANTTAREADESC = 0
                                                    End If
                                                Next

                                            End If
                                        End If
                                    End If
                                Next
                            End If
                        End If

                    Next
                End If

            Next
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0
            ProgressBar3.Value = 0
            ExportarExcel(INFORME_TAREAS, "", ProgressBar4)
            'DataGridView4.DataSource = INFORME_TAREAS
            ProgressBar4.Value = 0
        Else
            MsgBox("Seleccione un tipo de filtro para la exportacion/informe")
            CBFiltroInforme.Focus()
        End If
    End Sub
End Class