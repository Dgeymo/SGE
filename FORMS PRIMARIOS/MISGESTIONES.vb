
Public Class MIS_GESTIONES
    Dim NEW_REPORTEOCRow As ORDENESDataSet.REPORTE_OCRow
    Dim GESTIONRow As ORDENESDataSet.GESTIONRow
    Dim TRABAJORow As ORDENESDataSet.TRABAJOSRow
    Dim ORDENRow As ORDENESDataSet.ORDENESRow
    Dim HISTORICORow As ORDENESDataSet.HISTORICORow
    Dim SONGENERADOSX As Boolean
    Private Sub MIS_GESTIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If THEME_BLACK = False Then
            BackColor = Color.White
            ForeColor = FORE_COLOR_W
            LBL_DESCRIPCION.ForeColor = FORE_COLOR_W
            LBLGESTIONES.ForeColor = FORE_COLOR_W
            LBLTRABAJOS.ForeColor = FORE_COLOR_W
            LBLORDENES.ForeColor = FORE_COLOR_W

            GESTIONDataGridView.BackgroundColor = Color.White
            '  GESTIONDataGridView.BorderStyle = BorderStyle.None
            GESTIONDataGridView.RowsDefaultCellStyle.ForeColor = Color.MidnightBlue
            GESTIONDataGridView.RowsDefaultCellStyle.BackColor = Color.White
            GESTIONDataGridView.RowsDefaultCellStyle.SelectionBackColor = FORE_COLOR_W
            GESTIONDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White
            GESTIONDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
            GESTIONDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
            GESTIONDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            GESTIONDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            GESTIONDataGridView.ColumnHeadersHeight = 25
            OBS_GESTION.BackColor = Color.White
            OBS_GESTION.ForeColor = Color.MidnightBlue

            TRABAJOSDataGridView.BackgroundColor = Color.White
            '   TRABAJOSDataGridView.BorderStyle = BorderStyle.None
            TRABAJOSDataGridView.RowsDefaultCellStyle.ForeColor = Color.DarkRed
            TRABAJOSDataGridView.RowsDefaultCellStyle.BackColor = Color.White
            TRABAJOSDataGridView.RowsDefaultCellStyle.SelectionBackColor = FORE_COLOR_W
            TRABAJOSDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White
            TRABAJOSDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
            TRABAJOSDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
            TRABAJOSDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            TRABAJOSDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            TRABAJOSDataGridView.ColumnHeadersHeight = 25
            OBS_TRABAJO.BackColor = Color.White
            OBS_TRABAJO.ForeColor = Color.DarkRed


            ORDENESDataGridView.BackgroundColor = Color.White
            '  ORDENESDataGridView.BorderStyle = BorderStyle.None
            ORDENESDataGridView.RowsDefaultCellStyle.ForeColor = Color.DarkGreen
            ORDENESDataGridView.RowsDefaultCellStyle.BackColor = Color.White
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionBackColor = FORE_COLOR_W
            ORDENESDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White
            ORDENESDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
            ORDENESDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            ORDENESDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            ORDENESDataGridView.ColumnHeadersHeight = 25
            OBS_ORDEN.ForeColor = Color.DarkGreen
            OBS_ORDEN.BackColor = Color.White

        End If
        LBL_DESCRIPCION.Text = "MIS ASIGNADOS"

        ' SECTOR = "OBRA CIVIL" '"DISEÑO" ' "OBRA CIVIL" '  '"OBRA CIVIL" '""  '
        ' FULLNOMBRE = "GUSTAVO ESTEVEZ" '"ZELMAR LAGOS" '"AGUSTINA MARTINEZ" '""DIEGO CAIMI" '"ZELMAR LAGOS" ' "PILAR LIMA" '






        If SECTOR = "OBRA CIVIL" Or FULLNOMBRE = "YANIRE DIAZ" Or FULLNOMBRE = "DIEGO GEYMONAT" Then
            REPORTE_OC.Visible = True
            '    LBLTRABAJOS.Location = New Point(23, 8)
            '    TRABAJOSDataGridView.Location = New Point(12, 29)
            '    TRABAJOSDataGridView.Size = New Size(983, 299)
            '    LBLORDENES.Location = New Point(12, 332)
            '    ORDENESDataGridView.Location = New Point(12, 340)
            '    ORDENESDataGridView.Size = New Size(1161, 295)
        End If
        If SECTOR = "DISEÑO" Then
            LBL_DESCRIPCION.Text = "PENDIENTES"
            ORDENESTableAdapter.FillByASIGNADOA(OrdenesDataSet1.ORDENES, "ZELMAR LAGOS")
            LBLORDENES.Visible = False
            ORDENESDataGridView.Location = New Point(5, 25)
            BTN_REQUERIDOS.Visible = False
            BTN_REQUERIDOSETOR.Visible = False
            BTN_ASIGNADOSSECTOR.Visible = False
            BTN_MISASIGNADOS.Visible = False
            '    TRABAJOSDataGridView.Size = New Size(983, 299)
            LBLORDENES.Location = New Point(12, 332)
            '  ORDENESDataGridView.Location = New Point(12, 340)
            ORDENESDataGridView.Size = New Size(1200, 650)
            F_ORDINAL.Visible = True
            F_ORDEN.Visible = True
            F_AREA.Visible = True
            F_CALLE.Visible = True
            F_MOTIVO.Visible = True
            F_NODO.Visible = True
            F_ZONA.Visible = True
            LBLTRABAJOS.Visible = False
            ORDENESDataGridView.Visible = True
        Else
            ORDENESTableAdapter.FillByASIGNADOA(OrdenesDataSet1.ORDENES, FULLNOMBRE)
            If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                LBLORDENES.Visible = True
                ORDENESDataGridView.Visible = True
                OBS_ORDEN.Visible = True
            End If
            TRABAJOSTableAdapter.FillByASIGNADOA(ORDENESDataSet.TRABAJOS, FULLNOMBRE)
            If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                LBLTRABAJOS.Visible = True
                TRABAJOSDataGridView.Visible = True
                OBS_TRABAJO.Visible = True
            End If
            GESTIONTableAdapter.FillByASIGNADOA(ORDENESDataSet.GESTION, FULLNOMBRE)
            If ORDENESDataSet.GESTION.Rows.Count > 0 Then
                LBLGESTIONES.Visible = True
                GESTIONDataGridView.Visible = True
                OBS_GESTION.Visible = True
            End If
        End If

    End Sub

    Private Sub GESTIONDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles GESTIONDataGridView.DoubleClick
        Cursor = Cursors.WaitCursor
        INGRESO_AREA = Me.GESTIONDataGridView.CurrentRow.Cells.Item(7).Value
        ACCESO_DESDE = "MISGESTIONES"
        ACCESO_TIPO = "GESTION"
        ACCESO_GESTION = GESTIONDataGridView.CurrentRow.Cells.Item(0).Value
        DATOS.BUSCA_NODO.Text = GESTIONDataGridView.CurrentRow.Cells.Item(10).Value
        ABRIRDATOS()
        Cursor = DefaultCursor
    End Sub
    Private Sub GESTIONDataGridView_Click(sender As Object, e As EventArgs) Handles GESTIONDataGridView.Click
        If IsDBNull(GESTIONDataGridView.CurrentRow.Cells(13).Value) = False Then
            OBS_GESTION.Text = GESTIONDataGridView.CurrentRow.Cells(13).Value
        End If
    End Sub
    Private Sub TRABAJOSDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles TRABAJOSDataGridView.DoubleClick
        Cursor = Cursors.WaitCursor
        INGRESO_AREA = TRABAJOSDataGridView.CurrentRow.Cells.Item(8).Value                      'LEE AREA
        ACCESO_DESDE = "MISGESTIONES"
        ACCESO_TIPO = "TRABAJO"
        ACCESO_TRABAJO = TRABAJOSDataGridView.CurrentRow.Cells.Item(0).Value
        ACCESO_GESTION = TRABAJOSDataGridView.CurrentRow.Cells.Item(1).Value            'LEE LA GESTION
        DATOS.BUSCA_NODO.Text = TRABAJOSDataGridView.CurrentRow.Cells.Item(11).Value    'LEE EL NODO
        ABRIRDATOS()
        Cursor = DefaultCursor
    End Sub
    Private Sub TRABAJOSDataGridView_Click(sender As Object, e As EventArgs) Handles TRABAJOSDataGridView.Click
        If IsDBNull(TRABAJOSDataGridView.CurrentRow.Cells(14).Value) = False Then OBS_TRABAJO.Text = TRABAJOSDataGridView.CurrentRow.Cells(14).Value Else OBS_TRABAJO.Text = ""
    End Sub
    Private Sub ORDENESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ORDENESDataGridView.DoubleClick
        Cursor = Cursors.WaitCursor
        INGRESO_AREA = Me.ORDENESDataGridView.CurrentRow.Cells.Item(13).Value
        ACCESO_DESDE = "MISGESTIONES"
        ACCESO_TIPO = "ORDEN"
        INGRESO_AREA = "RED"
        NROORDENINT = ORDENESDataGridView.CurrentRow.Cells.Item(3).Value
        ACCESO_TRABAJO = ORDENESDataGridView.CurrentRow.Cells.Item(1).Value
        ACCESO_GESTION = Me.ORDENESDataGridView.CurrentRow.Cells.Item(0).Value
        DATOS.BUSCA_NODO.Text = ORDENESDataGridView.CurrentRow.Cells.Item(6).Value
        ABRIRDATOS()
        Cursor = DefaultCursor
    End Sub
    Private Sub ORDENESDataGridView_Click(sender As Object, e As EventArgs) Handles ORDENESDataGridView.Click
        If ORDENESDataGridView.Rows.Count > 0 Then
            OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, ORDENESDataGridView.CurrentRow.Cells(3).Value)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                OBS_ORDEN.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
            Else
                OBS_ORDEN.Text = "**NO TIENE OBSERVACIONES INGRESADA**"
            End If
        End If
    End Sub
    Private Sub ABRIRDATOS()
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
        DATOS.TopLevel = False
        DATOS.Parent = DASHBOARD.PanelTrabajo
        DATOS.Dock = DockStyle.Fill
        DATOS.Show()
        DATOS.BringToFront()
        Cursor = DefaultCursor

        DATOS.BUSCA_NODO.Visible = False
        DATOS.LBLNODO.Visible = True
        DATOS.GEST_NODO.Visible = True
        DATOS.BTN_SALIR.Visible = True
    End Sub
    Private Sub BTN_REQUERIDOS_Click(sender As Object, e As EventArgs) Handles BTN_REQUERIDOS.Click
        LBL_DESCRIPCION.Text = "MIS REQUERIDOS"
        CB_FUNCIONARIOS.Visible = False
        GESTIONTableAdapter.FillByGEST_REQUERIDO(ORDENESDataSet.GESTION, FULLNOMBRE)
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            LBLGESTIONES.Visible = True
            GESTIONDataGridView.Visible = True
        Else
            LBLGESTIONES.Visible = False
            GESTIONDataGridView.Visible = False
        End If
        TRABAJOSTableAdapter.FillByTRABAJO_REQUERIDO(ORDENESDataSet.TRABAJOS, FULLNOMBRE)
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            LBLTRABAJOS.Visible = True
            TRABAJOSDataGridView.Visible = True
        Else
            LBLTRABAJOS.Visible = False
            TRABAJOSDataGridView.Visible = False
        End If
        ORDENESDataGridView.Visible = False
        LBLORDENES.Visible = False
    End Sub
    Private Sub BTN_REQUERIDOSETOR_Click(sender As Object, e As EventArgs) Handles BTN_REQUERIDOSETOR.Click
        LBL_DESCRIPCION.Text = "REQUERIDOS DEL SECTOR"
        CB_FUNCIONARIOS.Visible = False
        GESTIONTableAdapter.FillByREQUERIDOSECTOR(ORDENESDataSet.GESTION, SECTOR)
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            LBLGESTIONES.Visible = True
            GESTIONDataGridView.Visible = True
        Else
            LBLGESTIONES.Visible = False
            GESTIONDataGridView.Visible = False
        End If
        TRABAJOSTableAdapter.FillByTRABAJO_REQUERIDOSECTOR(ORDENESDataSet.TRABAJOS, SECTOR)
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            LBLTRABAJOS.Visible = True
            TRABAJOSDataGridView.Visible = True
        Else
            LBLTRABAJOS.Visible = False
            TRABAJOSDataGridView.Visible = False
        End If
        ORDENESDataGridView.Visible = False
        LBLORDENES.Visible = False
        ' PINTA_oc()
    End Sub
    Private Sub BTN_MISASIGNADOS_Click(sender As Object, e As EventArgs) Handles BTN_MISASIGNADOS.Click
        LBL_DESCRIPCION.Text = "MIS ASIGNADOS"
        CB_FUNCIONARIOS.Visible = False
        Me.ORDENESTableAdapter.FillByASIGNADOA(Me.OrdenesDataSet1.ORDENES, FULLNOMBRE)
        If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
            LBLORDENES.Visible = True
            ORDENESDataGridView.Visible = True
        End If
        Me.TRABAJOSTableAdapter.FillByASIGNADOA(Me.ORDENESDataSet.TRABAJOS, FULLNOMBRE)
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            LBLTRABAJOS.Visible = True
            TRABAJOSDataGridView.Visible = True
        End If
        Me.GESTIONTableAdapter.FillByASIGNADOA(Me.ORDENESDataSet.GESTION, FULLNOMBRE)
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            LBLGESTIONES.Visible = True
            GESTIONDataGridView.Visible = True
        End If
        ' PINTA_oc()
    End Sub
    Private Sub PINTA_ROWS()
        Try
            If ORDENESDataGridView.Rows.Count > 0 Then
                For x = 0 To ORDENESDataGridView.Rows.Count - 1
                    Select Case ORDENESDataGridView.Rows(x).Cells(13).Value
                        Case "URGENTE", "ALTA"
                            ORDENESDataGridView.Rows(x).DefaultCellStyle.ForeColor = Color.Red
                    End Select
                Next
            End If
        Catch EX As Exception
        End Try
    End Sub
    Private Sub BTN_ASIGNADOSSECTOR_Click(sender As Object, e As EventArgs) Handles BTN_ASIGNADOSSECTOR.Click
        LBL_DESCRIPCION.Text = "ASIGNADOS DEL SECTOR"
        SONGENERADOSX = False
        FUNCIONARIOSTableAdapter.FillBySECTOR(ORDENESDataSet.FUNCIONARIOS, SECTOR)
        CB_FUNCIONARIOS.Items.Clear()
        For F = 0 To ORDENESDataSet.FUNCIONARIOS.Rows.Count - 1
            CB_FUNCIONARIOS.Items.Add(ORDENESDataSet.FUNCIONARIOS.Rows(F).Item("NOMBRE"))
        Next

        CB_FUNCIONARIOS.Text = FULLNOMBRE
        CB_FUNCIONARIOS.Visible = True
        Me.TRABAJOSTableAdapter.FillByASIGNADOSECTOR(Me.ORDENESDataSet.TRABAJOS, SECTOR)
        If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
            LBLTRABAJOS.Visible = True
            TRABAJOSDataGridView.Visible = True
        End If
        Me.GESTIONTableAdapter.FillByASIGNADOSECTOR(Me.ORDENESDataSet.GESTION, SECTOR)
        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
            LBLGESTIONES.Visible = True
            GESTIONDataGridView.Visible = True
        End If
        ' PINTA_oc()
    End Sub
    Private Sub CB_FUNCIONARIOS_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_FUNCIONARIOS.SelectedValueChanged
        If SONGENERADOSX Then
            ORDENESTableAdapter.FillByGENERADOX(OrdenesDataSet1.ORDENES, CB_FUNCIONARIOS.SelectedItem)
        Else
            ORDENESTableAdapter.FillByASIGNADOA(OrdenesDataSet1.ORDENES, CB_FUNCIONARIOS.SelectedItem)
        End If

        If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
            LBLORDENES.Visible = True
            ORDENESDataGridView.Visible = True
        End If
    End Sub

    Private Sub REPORTE_OC_Click(sender As Object, e As EventArgs) Handles REPORTE_OC.Click
        Cursor = Cursors.WaitCursor
        Try
            TRABAJOSTableAdapter.FillByOBRACIVIL_ACTIVOS(OrdenesDataSet3.TRABAJOS)
            If OrdenesDataSet3.TRABAJOS.Rows.Count > 0 Then
                For Each TRABAJO In OrdenesDataSet3.TRABAJOS

                    'DATOS DE LA GESTION
                    GESTIONTableAdapter.FillByIDGESTION(OrdenesDataSet3.GESTION, TRABAJO.ID_GESTION)
                    GESTIONRow = OrdenesDataSet3.GESTION.Rows(0)

                    'DATOS DE LOS TRABAJOS
                    TRABAJOSTableAdapter.FillByIDGESTION(OrdenesDataSet2.TRABAJOS, TRABAJO.ID_GESTION)
                    For X = 0 To OrdenesDataSet2.TRABAJOS.Rows.Count - 1
                        TRABAJORow = OrdenesDataSet2.TRABAJOS.Rows(X)
                        'DATOS DE LAS ORDENES
                        ORDENESTableAdapter.FillByORDENES_OC(OrdenesDataSet3.ORDENES, TRABAJORow.Id_TRABAJO)
                        If OrdenesDataSet3.ORDENES.Rows.Count > 0 Then
                            For O = 0 To OrdenesDataSet3.ORDENES.Rows.Count - 1
                                ORDENRow = OrdenesDataSet3.ORDENES.Rows(O)
                                'VA DENTRO DE FOR DEL TRABAJO SI ES ORDEN DE OBRACIVIL LA INGRESAMOS
                                If ORDENRow.SECTOROPE = "OBRA CIVIL" Then
                                    Dim SIORDEN As ORDENESDataSet.REPORTE_OCRow
                                    SIORDEN = REPORTE_OBRACIVIL.ORDENESDataSet.REPORTE_OC.Rows.Find(78736)
                                    'MsgBox(SIORDEN.ORDEN_ID.ToString)
                                    If SIORDEN IsNot Nothing Then
                                        MsgBox("ORDEN " & SIORDEN.ORDEN_ID & "  YA ESTA")
                                        If SIORDEN.ORDEN_ID = ORDENRow.NRO_ORDENINT Then

                                            Continue For
                                        End If
                                    End If
                                    NEW_REPORTEOCRow = REPORTE_OBRACIVIL.ORDENESDataSet.REPORTE_OC.NewREPORTE_OCRow
                                    'INGRESA DATOS DE LA GESTION
                                    NEW_REPORTEOCRow.GEST_ID = GESTIONRow.Id_GESTION
                                    If GESTIONRow.IsCALLENull = False Then
                                        NEW_REPORTEOCRow.GEST_DIRECCION = GESTIONRow.CALLE
                                        If GESTIONRow.IsNUMERONull = False Then
                                            NEW_REPORTEOCRow.GEST_DIRECCION += " " & GESTIONRow.NUMERO
                                        End If
                                    End If
                                    NEW_REPORTEOCRow.GEST_DESC = GESTIONRow.TIPOGESTION

                                    'INGRESA DATOS DEL TRABAJO
                                    NEW_REPORTEOCRow.TRAB_NODO_ZONA = GESTIONRow.NODO
                                    If TRABAJORow.IsZONANull = False Then
                                        NEW_REPORTEOCRow.TRAB_NODO_ZONA += "/" & TRABAJORow.ZONA
                                    End If
                                    NEW_REPORTEOCRow.TRAB_ID = TRABAJORow.Id_TRABAJO
                                    NEW_REPORTEOCRow.TRAB_DESC = TRABAJORow.TIPOTRABAJO
                                    NEW_REPORTEOCRow.TRAB_STS = TRABAJORow.STATUS
                                    HISTORICOTableAdapter.FillByIDTRABAJO_ASIG_RESPONSABLE(ORDENESDataSet.HISTORICO, TRABAJORow.Id_TRABAJO)
                                    If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
                                        For H = 0 To ORDENESDataSet.HISTORICO.Rows.Count - 1
                                            HISTORICORow = ORDENESDataSet.HISTORICO.Rows(H)
                                            NEW_REPORTEOCRow.TRAB_ASIGNADO_FECHA = HISTORICORow.FECHA
                                        Next
                                    Else
                                        NEW_REPORTEOCRow.TRAB_ASIGNADO_FECHA = ""
                                    End If
                                    NEW_REPORTEOCRow.TRAB_DESCRIPCION = TRABAJORow.DESCRIPCION
                                    'INGRESA DATOS DE LA ORDEN
                                    NEW_REPORTEOCRow.ORDEN_ID = ORDENRow.NRO_ORDENINT
                                    NEW_REPORTEOCRow.ORDEN_ORDINAL = ORDENRow.NRO_ORDINAL
                                    NEW_REPORTEOCRow.ORDEN_TIPO = ORDENRow.MOTIVOORIGEN
                                    NEW_REPORTEOCRow.ORDEN_STS = ORDENRow.STATUS
                                    If ORDENRow.IsFECHAINICIONull = False Then
                                        If IsDate(ORDENRow.FECHAINICIO) Then
                                            NEW_REPORTEOCRow.ORDEN_FECHAINI = ORDENRow.FECHAINICIO
                                        End If
                                    End If
                                    If ORDENRow.IsFECHAFINNull = False Then
                                        If IsDate(ORDENRow.FECHAFIN) Then
                                            NEW_REPORTEOCRow.ORDEN_FECHAFIN = ORDENRow.FECHAFIN
                                        End If
                                    End If
                                    If ORDENRow.IsCUADRILLANull = False Then
                                        NEW_REPORTEOCRow.ORDEN_CUADRILLA = Trim(ORDENRow.CUADRILLA)
                                    Else
                                        NEW_REPORTEOCRow.ORDEN_CUADRILLA = "SIN ASIGNAR"
                                    End If

                                    HISTORICOTableAdapter.FillByORDEN_ASIG_RESPONSABLE(ORDENESDataSet.HISTORICO, ORDENRow.NRO_ORDENINT)
                                    If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
                                        HISTORICORow = ORDENESDataSet.HISTORICO.Rows(0)
                                        NEW_REPORTEOCRow.ORDEN_ASIGNADO_FECHA = HISTORICORow.FECHA
                                    Else
                                        NEW_REPORTEOCRow.ORDEN_ASIGNADO_FECHA = ""
                                    End If
                                    'MsgBox("ID_GRESTION: " & NEW_REPORTEOCRow.GEST_ID & vbNewLine & "GESTION DIRECCION: " & NEW_REPORTEOCRow.GEST_DIRECCION & vbNewLine & "GESTION DESC: " & NEW_REPORTEOCRow.GEST_DESC & vbNewLine &
                                    '       "TRABAJO NODO/ZONA " & NEW_REPORTEOCRow.TRAB_NODO_ZONA & vbNewLine & "TRABAJO_ID: " & NEW_REPORTEOCRow.TRAB_ID & vbNewLine & "TRABAJO DESCR: " & NEW_REPORTEOCRow.TRAB_DESC & vbNewLine & "TRABAJO STS: " & NEW_REPORTEOCRow.TRAB_STS & vbNewLine & "TRABAJO DESCRIPCION: " & NEW_REPORTEOCRow.TRAB_DESCRIPCION & vbNewLine &
                                    '       "ASIG_TRABAJO " & NEW_REPORTEOCRow.TRAB_ASIGNADO_FECHA & vbNewLine & "ORDEN_ID: " & NEW_REPORTEOCRow.ORDEN_ID & vbNewLine & "ORDEN_ORDINAL: " & NEW_REPORTEOCRow.ORDEN_ORDINAL & vbNewLine &
                                    '       "ORDEN_TIPO: " & NEW_REPORTEOCRow.ORDEN_TIPO & vbNewLine & "ORDEN:sTS: " & NEW_REPORTEOCRow.ORDEN_STS & vbNewLine & "ORDEN CUADRILLA " & NEW_REPORTEOCRow.ORDEN_CUADRILLA & vbNewLine & "ORDEN ASIGNADA FECHA " & NEW_REPORTEOCRow.ORDEN_ASIGNADO_FECHA)
                                    HISTORICOTableAdapter.FillByORDENINT(ORDENESDataSet.HISTORICO, ORDENRow.NRO_ORDENINT)
                                    REPORTE_OBRACIVIL.ORDENESDataSet.REPORTE_OC.AddREPORTE_OCRow(NEW_REPORTEOCRow)
                                End If
                            Next
                        End If
                    Next
                Next
                If REPORTE_OBRACIVIL.Visible Then
                    REPORTE_OBRACIVIL.Close()
                    REPORTE_OBRACIVIL.Dispose()
                Else
                    REPORTE_OBRACIVIL.Show(Me)
                End If
            End If
        Catch EX As Exception
            Cursor = Cursors.Default
            MsgBox("ESTO ES VERGONZOSO, REALIZA NUEVAMENTE LA PETICION..." & vbNewLine & EX.Message & vbNewLine & "Trabajo: " & TRABAJORow.Id_TRABAJO)
        End Try

        Cursor = Cursors.Default

    End Sub

    Private Sub MIS_GESTIONES_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PINTA_ROWS()
    End Sub

    Private Sub BTN_GENERADOSX_Click(sender As Object, e As EventArgs) Handles BTN_GENERADOSX.Click
        SONGENERADOSX = True
        FUNCIONARIOSTableAdapter.FillBySECTOR(ORDENESDataSet.FUNCIONARIOS, SECTOR)
        CB_FUNCIONARIOS.Items.Clear()
        For F = 0 To ORDENESDataSet.FUNCIONARIOS.Rows.Count - 1
            CB_FUNCIONARIOS.Items.Add(ORDENESDataSet.FUNCIONARIOS.Rows(F).Item("NOMBRE"))
        Next
        CB_FUNCIONARIOS.Text = FULLNOMBRE
        CB_FUNCIONARIOS.Visible = True
        ORDENESTableAdapter.FillByGENERADOX(OrdenesDataSet1.ORDENES, CB_FUNCIONARIOS.SelectedItem)
    End Sub





    'Private Sub MIS_GESTIONES_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    'PINTA_oc()
    'End Sub

    'Private Sub PINTA_oc()
    '    If TRABAJOSDataGridView.Rows.Count > 0 Then
    '        For X = 0 To TRABAJOSDataGridView.Rows.Count - 1
    '            If TRABAJOSDataGridView.Rows(X).Cells(13).Value = False Then
    '                TRABAJOSDataGridView.Rows(X).DefaultCellStyle.BackColor = Color.Black
    '            Else
    '                If TRABAJOSDataGridView.Rows(X).Cells(2).Value = "OBRA CIVIL" Then
    '                    TRABAJOSDataGridView.Rows(X).DefaultCellStyle.BackColor = Color.DarkGreen
    '                Else
    '                    TRABAJOSDataGridView.Rows(X).DefaultCellStyle.BackColor = Color.Black
    '                End If
    '            End If
    '        Next
    '    End If
    '    Try
    '        If ORDENESDataGridView.Rows.Count > 0 Then
    '            For x = 0 To ORDENESDataGridView.Rows.Count - 1

    '                ORDENESDataGridView.Rows(x).DefaultCellStyle.BackColor = Color.Black
    '                If ORDENESDataGridView.Rows(x).Cells(4).Value = "GESTIÓN C/IMM" Then
    '                    If ORDENESDataGridView.Rows(x).Cells(16).Value = "OBRA CIVIL" Then
    '                        TRABAJOSTableAdapter.FillByIDGESTION(OrdenesDataSet2.TRABAJOS, ORDENESDataGridView.Rows(x).Cells(0).Value)
    '                        If OrdenesDataSet2.TRABAJOS.Rows.Count > 0 Then
    '                            For Y = 0 To OrdenesDataSet2.TRABAJOS.Rows.Count - 1
    '                                If OrdenesDataSet2.TRABAJOS.Rows(Y).Item("TIPOTRABAJO") = "OBRA CIVIL" And CInt(ORDENESDataGridView.Rows(x).Cells(7).Value) = CInt(OrdenesDataSet2.TRABAJOS.Rows(Y).Item("ZONA")) Then
    '                                    If OrdenesDataSet2.TRABAJOS.Rows(Y).Item("HABILITADO") Then
    '                                        ORDENESDataGridView.Rows(x).DefaultCellStyle.BackColor = Color.DarkGreen
    '                                    Else
    '                                        ORDENESDataGridView.Rows(x).DefaultCellStyle.BackColor = Color.Black
    '                                    End If
    '                                End If
    '                            Next
    '                        End If

    '                    End If
    '                End If
    '            Next
    '        End If
    '    Catch EX As Exception
    '    End Try
    'End Sub
End Class