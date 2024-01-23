Public Class VER_ORD_AGENDA
    Dim ORDEN_DESAGENDAR As ORDENESDataSet.ORDENESRow
    Dim CAPACIDAD_DEL_DIA As ANALISIS_AGDataSet.CAPACIDAXDIARow
    Public ORDEN_AG(50) As Integer
    Public CANTIDAD_ORDENES As Integer
    Dim POSY As Integer
    Dim HEIGHT_FORM As Integer
    Private Sub VER_ORD_AGENDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORMAGE.Enabled = False
        LBL_FECHAAGENDA.Text = "FECHA DE AGENDA: " & FECHAAGENDA
        LBL_PRIORIDAD.Text = "PRIORIDAD: " & FORMAGE.PRIORIDAD
        Select Case DATOS.SECTOR_CAP
            Case "TODOS"
                ORDENESTableAdapter.FillByFECHAGEND_PRIORIDAD(ORDENESDataSet.ORDENES, CDate(FECHAAGENDA), FORMAGE.PRIORIDAD)
            Case Else
                Select Case DATOS.RECURSO_CAP
                    Case "CUA", "TEC"
                        If DATOS.RECURSO_CAP = "CUA" Then
                            ORDENESTableAdapter.FillByAGENDA_PRIORIDAD_SECTOROPE(ORDENESDataSet.ORDENES, CDate(FECHAAGENDA), FORMAGE.PRIORIDAD, "CUADRILLAS", DATOS.SECTOR_CAP)
                        Else
                            ORDENESTableAdapter.FillByAGENDA_PRIORIDAD_SECTOROPE(ORDENESDataSet.ORDENES, CDate(FECHAAGENDA), FORMAGE.PRIORIDAD, "MANTENIMIENTO", DATOS.SECTOR_CAP)
                        End If
                End Select
        End Select
        If ORDENESDataSet.ORDENES.Rows.Count * 24 + 15 > 630 Then
            HEIGHT_FORM = 630
        Else
            HEIGHT_FORM = ORDENESDataSet.ORDENES.Rows.Count * 25
        End If
        DGVOrdenes.Size = New Size(Size.Width, HEIGHT_FORM + 15)
        Me.Size = New Size(Size.Width, HEIGHT_FORM + 80)
        If 600 - ORDENESDataSet.ORDENES.Rows.Count * 25 > 10 Then
            POSY = 600 - ORDENESDataSet.ORDENES.Rows.Count * 25
        Else
            POSY = 10
        End If
        DGVOrdenes.Dock = DockStyle.Bottom
        Select Case PANTALLA_PRIMARIA
            Case False
                If PANTALLA_NEGATIVA Then
                    Location = New Point(((1366 - Size.Width + 50) / 2) - 1366, POSY)
                Else
                    Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width + 50) / 2) + 1366, POSY)
                End If
            Case True
                Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width + 50) / 2), POSY)
        End Select

        LBL_PRIORIDAD.Text = "PRIORIDAD: " & FORMAGE.PRIORIDAD
    End Sub
    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        FORMAGE.Enabled = True
        Close()
    End Sub
    Private Sub DGVOrdenes_Click(sender As Object, e As EventArgs) Handles DGVOrdenes.Click
        If DGVOrdenes.Rows.Count > 0 Then
            Dim ORDEN_SEL As Integer = DGVOrdenes.CurrentRow.Cells(0).Value
            Dim ORDEN_DEPEND As Integer
            If IsDBNull(DGVOrdenes.CurrentRow.Cells(11).Value) = False Then ORDEN_DEPEND = DGVOrdenes.CurrentRow.Cells(11).Value
            If IsDBNull(DGVOrdenes.CurrentRow.Cells(57).Value) Then
                DATOS.SECTOR_CAP = "CO"
            Else
                DATOS.SECTOR_CAP = DGVOrdenes.CurrentRow.Cells(57).Value
            End If

            Select Case DGVOrdenes.CurrentRow.Cells(64).Value
                Case "MANTENIMIENTO"
                    DATOS.RECURSO_CAP = "TEC"
                Case "CUADRILLAS"
                    DATOS.RECURSO_CAP = "CUA"
            End Select
            If DGVOrdenes.CurrentRow.Cells(2).Value = "CUADRILLAS DE RED" Then
                DATOS.RECURSO_CAP = "CUA"
            End If

            Select Case DATOS.SECTOR_CAP
                    Case "PT"
                        FORMAGE.BTN_FILL_PT.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                        FORMAGE.BTN_FILL_COO.BackgroundImage = Nothing
                        FORMAGE.BTN_FILL_SU.BackgroundImage = Nothing
                    Case "SU"
                        FORMAGE.BTN_FILL_SU.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                        FORMAGE.BTN_FILL_COO.BackgroundImage = Nothing
                        FORMAGE.BTN_FILL_PT.BackgroundImage = Nothing
                    Case "CO"
                        FORMAGE.BTN_FILL_COO.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                        FORMAGE.BTN_FILL_PT.BackgroundImage = Nothing
                        FORMAGE.BTN_FILL_SU.BackgroundImage = Nothing
                End Select
                FORMAGE.BTN_FILL_TODOS.BackgroundImage = Nothing
                Select Case DATOS.RECURSO_CAP
                    Case "CUA"
                        FORMAGE.BTN_REC_CUA.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                        FORMAGE.BTN_REC_TEC.BackgroundImage = Nothing
                    Case "TEC"
                        FORMAGE.BTN_REC_TEC.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                        FORMAGE.BTN_REC_CUA.BackgroundImage = Nothing
                End Select
                FORMAGE.BTN_REC_TODOS.BackgroundImage = Nothing
                FORMAGE.MOSTRAR_AGENDA(FECHAINI, FECHAFIN)

                For X = 0 To DGVOrdenes.Rows.Count - 1
                    If IsDBNull(DGVOrdenes.Rows(X).Cells(11).Value) = False Then
                        If CK_UNITARIA.Checked = False Then
                            If ORDEN_DEPEND <> 0 Then
                                If ORDEN_DEPEND = DGVOrdenes.Rows(X).Cells(0).Value Or ORDEN_DEPEND = DGVOrdenes.Rows(X).Cells(11).Value Or ORDEN_SEL = DGVOrdenes.Rows(X).Cells(11).Value Then
                                    DGVOrdenes.Rows(X).Selected = True
                                End If
                            Else
                                If ORDEN_SEL = DGVOrdenes.Rows(X).Cells(11).Value Then
                                    DGVOrdenes.Rows(X).Selected = True
                                End If
                            End If
                        End If
                    End If
                Next
            End If

    End Sub
    Public Sub DESAGENDAR_ORDEN(ByVal DGV_ORDENES As DataGridView, ByVal FECHA_DE_AGENDA As String, ByVal DESDE As String)
        DASHBOARD.Cursor = Cursors.WaitCursor
        For X = 0 To 49
            ORDEN_AG(X) = 0
        Next
        CANTIDAD_ORDENES = 0
        If DGV_ORDENES.SelectedRows.Count > 0 Then
            For x = 0 To DGV_ORDENES.SelectedRows.Count - 1
                CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, FECHA_DE_AGENDA)
                CAPACIDAD_DEL_DIA = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
                If DESDE = "DATOS" Then
                    ORDENESTableAdapter.FillByIDORDENINT(OrdenesDataSet_DESAGENDAR.ORDENES, DGV_ORDENES.SelectedRows(x).Cells(3).Value)
                Else
                    ORDENESTableAdapter.FillByIDORDENINT(OrdenesDataSet_DESAGENDAR.ORDENES, DGV_ORDENES.SelectedRows(x).Cells(0).Value)
                End If

                ORDEN_DESAGENDAR = OrdenesDataSet_DESAGENDAR.ORDENES.Rows(0)
                ORDEN_AG(x) = ORDEN_DESAGENDAR.NRO_ORDENINT
                If ORDEN_DESAGENDAR("NRO_ORDINAL") <> 0 Then
                    ORDEN_DESAGENDAR("DESAGENDAR") = True
                    ORDEN_DESAGENDAR("STATUS") = "INGORDINAL"
                Else
                    ORDEN_DESAGENDAR("STATUS") = "INGRESADOINT"
                End If
                ORDEN_DESAGENDAR("AGENDAR") = False
                ORDEN_DESAGENDAR("FECHAAGEND") = DBNull.Value
                TIEMPO_AGENDA = -(CInt(ORDEN_DESAGENDAR("TPREVISTO") * CAPACIDAD_DIA / 100))
                CANTIDAD_ORDENES += 1
                Select Case ORDEN_DESAGENDAR("SECTORGEN")
                    Case "PT"
                        Select Case ORDEN_DESAGENDAR("RECURSO")
                            Case "MANTENIMIENTO"
                                Select Case ORDEN_DESAGENDAR("PRIORIDAD")
                                    Case "ALTA"
                                        If CAPACIDAD_DEL_DIA.MIN_ALT_TEC_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_ALT_TEC_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_ALT_TEC_PT_AGE = 0
                                        End If
                                    Case "MEDIA"
                                        If CAPACIDAD_DEL_DIA.MIN_MED_TEC_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_MED_TEC_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_MED_TEC_PT_AGE = 0
                                        End If
                                    Case "BAJA"
                                        If CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_PT_AGE = 0
                                        End If
                                End Select
                            Case "CUADRILLAS"
                                Select Case ORDEN_DESAGENDAR("PRIORIDAD")
                                    Case "ALTA"
                                        If CAPACIDAD_DEL_DIA.MIN_ALT_CUA_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_ALT_CUA_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_ALT_CUA_PT_AGE = 0
                                        End If
                                    Case "MEDIA"
                                        If CAPACIDAD_DEL_DIA.MIN_MED_CUA_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_MED_CUA_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_MED_CUA_PT_AGE = 0
                                        End If
                                    Case "BAJA"
                                        If CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_PT_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_PT_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_PT_AGE = 0
                                        End If
                                End Select
                        End Select
                    Case "SU"
                        Select Case ORDEN_DESAGENDAR("RECURSO")
                            Case "MANTENIMIENTO"
                                Select Case ORDEN_DESAGENDAR("PRIORIDAD")
                                    Case "ALTA"
                                        If CAPACIDAD_DEL_DIA.MIN_ALT_TEC_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_ALT_TEC_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_ALT_TEC_SU_AGE = 0
                                        End If
                                    Case "MEDIA"
                                        If CAPACIDAD_DEL_DIA.MIN_MED_TEC_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_MED_TEC_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_MED_TEC_SU_AGE = 0
                                        End If
                                    Case "BAJA"
                                        If CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_TEC_SU_AGE = 0
                                        End If
                                End Select
                            Case "CUADRILLAS"
                                Select Case ORDEN_DESAGENDAR("PRIORIDAD")
                                    Case "ALTA"
                                        If CAPACIDAD_DEL_DIA.MIN_ALT_CUA_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_ALT_CUA_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_ALT_CUA_SU_AGE = 0
                                        End If
                                    Case "MEDIA"
                                        If CAPACIDAD_DEL_DIA.MIN_MED_CUA_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_MED_CUA_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_MED_CUA_SU_AGE = 0
                                        End If
                                    Case "BAJA"
                                        If CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_SU_AGE + TIEMPO_AGENDA > 0 Then
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_SU_AGE += TIEMPO_AGENDA
                                        Else
                                            CAPACIDAD_DEL_DIA.MIN_BAJ_CUA_SU_AGE = 0
                                        End If
                                End Select
                        End Select
                End Select
                ORDENESTableAdapter.Update(ORDEN_DESAGENDAR)
                CAPACIDAXDIATableAdapter.Update(CAPACIDAD_DEL_DIA)
            Next
            Select Case DESDE
                Case "AGENDA"
                    ORDENESTableAdapter.FillByFECHAGEND_PRIORIDAD(ORDENESDataSet.ORDENES, FECHAAGENDA, FORMAGE.PRIORIDAD)
                    FORMAGE.MOSTRAR_AGENDA(Today.ToShortDateString, Today.AddDays(4).ToShortDateString)
                Case "DATOS"
                    DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, DATOS.DATOS_TRABAJORow.Id_TRABAJO)
            End Select

            DASHBOARD.Cursor = DefaultCursor
            If DGVOrdenes.SelectedRows.Count = 1 Then
                NOTIFICACION("SYS", "ORDEN " & DGVOrdenes.SelectedRows(0).Cells(0).Value & " DESAGENDADA")
            Else
                NOTIFICACION("SYS", "ORDENES DESAGENDADAS")
            End If
            DGVOrdenes.Visible = True
            BTN_CERRAR.Visible = True
        Else
            DASHBOARD.Cursor = DefaultCursor
            MsgBox("Seleccione al menos una fila")
        End If
    End Sub
    Private Sub BTN_DESAGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_DESAGENDAR.Click
        DESAGENDAR_ORDEN(DGVOrdenes, FECHAAGENDA, "AGENDA")
        If DATOS.Visible Then
            DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
        End If
    End Sub
    Private Sub BTN_REAGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_REAGENDAR.Click
        BTN_RESTAURAR.Visible = True
        BTN_DESAGENDAR.Visible = False
        LBL_FECHAAGENDA.Visible = False
        LBL_PRIORIDAD.Visible = False
        CK_UNITARIA.Visible = False
        FORMAGE.ACCION_AGENDA = "REAGENDAR"
        FORMAGE.Enabled = True
        BTN_REAGENDAR.Enabled = False
        TIEMPO_AGENDA = 0

        For X = 0 To DGVOrdenes.SelectedRows.Count - 1
            TIEMPO_AGENDA += CInt(DGVOrdenes.SelectedRows(X).Cells(43).Value * CAPACIDAD_DIA / 100)
        Next
        Size = New Size(Size.Width, 60)
        Select Case PANTALLA_PRIMARIA
            Case False
                If PANTALLA_NEGATIVA Then
                    Location = New Point(((1366 - Size.Width) / 2) - 1366, 740 - Size.Height)
                Else
                    Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2) + 1366, 740 - Size.Height)
                End If
            Case True
                Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2), 740 - Size.Height)
        End Select

        DGVOrdenes.Visible = False
        BTN_REAGENDAR.BackColor = Color.Red
        BTN_CERRAR.Visible = False
    End Sub
    Public Sub BTN_RESTAURAR_Click(sender As Object, e As EventArgs) Handles BTN_RESTAURAR.Click
        BTN_RESTAURAR.Visible = False
        BTN_DESAGENDAR.Visible = True
        LBL_FECHAAGENDA.Visible = True
        LBL_PRIORIDAD.Visible = True
        BTN_DESAGENDAR.Enabled = True
        CK_UNITARIA.Visible = True
        FORMAGE.ACCION_AGENDA = "VER AGENDA"
        FORMAGE.Enabled = False
        BTN_REAGENDAR.Enabled = True
        DGVOrdenes.Visible = True
        BTN_CERRAR.Visible = True
        BTN_REAGENDAR.BackColor = Color.Transparent
        BackColor = Color.FromArgb(40, 40, 40)
        Size = New Size(Size.Width, 315)
        Select Case PANTALLA_PRIMARIA
            Case False
                If PANTALLA_NEGATIVA Then
                    Location = New Point(((1366 - Size.Width) / 2) - 1366, 740 - Size.Height)
                Else
                    Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2) + 1366, 740 - Size.Height)
                End If
            Case True
                Location = New Point(((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2), 740 - Size.Height)
        End Select
    End Sub


End Class