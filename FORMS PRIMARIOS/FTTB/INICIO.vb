
Public Class INICIO
    Public VER_EDIFICIO As EDIFICIODataSet.EDIF_VISTARow
    Public VER_MDU As EDIFICIODataSet.MDURow
    Dim CAMPO(5) As String
    Dim DATO(5) As String
    Dim FILTRO(5) As String
    Dim VISTAEDIFICIO As DataView
    Dim AVANCERow As EDIFICIODataSet.AVANCERow

    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EDIFICIODataSet.OBS_MDU' Puede moverla o quitarla según sea necesario.
        Me.OBS_MDUTableAdapter.Fill(Me.EDIFICIODataSet.OBS_MDU)

        MDUTableAdapter.FillByDISCT_NODO(EDIFICIODataSet.MDU)
        CBNODO.Items.Clear()
        For Each MDU In EDIFICIODataSet.MDU
            CBNODO.Items.Add(MDU.NODO)
        Next


        If FULLNOMBRE = "FRANCO QUINTANA" Or FULLNOMBRE = "DIEGO GEYMONAT" Then
            CB_INGRESO.Visible = True
            BTN_HABILITAR.Visible = True
        End If
        ACTUALIZAR_INFO_MDU(My.Settings.VALOR_NODO)
        CBNODO.Text = My.Settings.VALOR_NODO
        CB_STATUS.Items.Clear()
        STATUSTableAdapter.Fill(EDIFICIODataSet.STATUS)
        CB_STATUS.Items.Add("SIN FILTRO")
        For Each STATUS In EDIFICIODataSet.STATUS
            CB_STATUS.Items.Add(STATUS.NOMBRE)
        Next
    End Sub

    Private Sub BUSCA_TIPO()
        VISTAEDIFICIO = EDIFICIODataSet.EDIF_VISTA.AsDataView
        CAMPO(0) = "NODO"
        DATO(0) = CBNODO.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"

        CAMPO(1) = "ZONA"
        DATO(1) = TXT_ZONA.Text

        If TXT_ZONA.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND " & CAMPO(1) & "=" & DATO(1) & ""
        End If

        CAMPO(2) = "CALLE"
        DATO(2) = TXT_CALLE.Text
        If TXT_CALLE.Text = "" Then
            FILTRO(2) = ""
        Else
            FILTRO(2) = " AND  [" & CAMPO(2) & "] like '*" & DATO(2) & "*'"
        End If

        CAMPO(3) = "PUERTA"
        DATO(3) = TXT_NRO.Text
        If TXT_NRO.Text = "" Then
            FILTRO(3) = ""
        Else
            FILTRO(3) = " AND  [" & CAMPO(3) & "] like '*" & DATO(3) & "*'"
        End If
        CAMPO(4) = "STATUS"
        DATO(4) = CB_STATUS.Text
        If CB_STATUS.Text = "SIN FILTRO" Then
            FILTRO(4) = ""
        Else
            FILTRO(4) = " AND  " & CAMPO(4) & "='" & DATO(4) & "'"
        End If
        VISTAEDIFICIO.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) & FILTRO(4) '& FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8)
        EDIF_VISTABindingSource.DataSource = VISTAEDIFICIO
        LBL_CANT_ROWS.Text = "MOSTRANDO: " & EDIF_VISTABindingSource.Count & " EDIFICIOS"
        marcarVencidos()
    End Sub
    Private Sub TXT_NODO_TextChanged(sender As Object, e As EventArgs)
        ACTUALIZAR_INFO_MDU(CBNODO.Text)

    End Sub


    Private Sub TXT_ZONA_TextChanged(sender As Object, e As EventArgs) Handles TXT_ZONA.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CALLE.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_NRO_TextChanged(sender As Object, e As EventArgs) Handles TXT_NRO.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub CB_STATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_STATUS.SelectedIndexChanged
        If CB_STATUS.Text <> "SIN FILTRO" Then
            BUSCA_TIPO()
        End If
    End Sub
    Private Sub BTN_REFRESCAR_Click(sender As Object, e As EventArgs) Handles BTN_REFRESCAR.Click
        ACTUALIZAR_INFO_MDU(CBNODO.Text)
    End Sub
    Private Sub BTN_VER_AGENDA_Click(sender As Object, e As EventArgs) Handles BTN_VER_AGENDA.Click
        If AGENDA.Visible Then AGENDA.Close()
        ACCION_AGENDA = "VISTA"
        ' AGENDA.EDI_ID_AGENDAR = VER_MDU.ID_MDU
        AGENDA.Show(Me)
    End Sub
    Private Sub BTN_VER_AGENDA_CERTIFICADO_Click(sender As Object, e As EventArgs) Handles BTN_VER_AGENDA_CERTIFICADO.Click
        If AGENDA.Visible Then AGENDA.Close()
        ACCION_AGENDA = "VISTA CERTIFICADOS"
        '  AGENDA.EDI_ID_AGENDAR = VER_MDU.ID_MDU
        AGENDA.Show(Me)
    End Sub
    Private Sub DGV_EDIFICIOS_DoubleClick(sender As Object, e As EventArgs) Handles DGV_EDIFICIOS.DoubleClick
        If DGV_EDIFICIOS.Rows.Count > 0 AndAlso DGV_EDIFICIOS.CurrentRow.Selected Then
            If DETALLE_MDU.Visible Then DETALLE_MDU.Close()
            DETALLE_MDU.Show(Me)
        End If
    End Sub
    Private Sub BTN_VER_EDIFICIO_Click(sender As Object, e As EventArgs) Handles BTN_VER_EDIFICIO.Click
        If DETALLE_MDU.Visible Then DETALLE_MDU.Close()
        DETALLE_MDU.Show(Me)
    End Sub
    Private Sub AGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_AGENDAR.Click
        If AGENDA.Visible Then
            AGENDA.Close()
        End If
        ACCION_AGENDA = "AGENDAR"
        AGENDA.EDI_ID_AGENDAR = DGV_EDIFICIOS.CurrentRow.Cells(0).Value
        AGENDA.Show(Me)
    End Sub
    Private Sub BTN_DESAGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_DESAGENDAR.Click
        If DGV_EDIFICIOS.CurrentRow.Cells(0).Value Then
            AGENDATableAdapter.FillByIDMDU_DIAAGENDA(EDIFICIODataSet.AGENDA, CInt(DGV_EDIFICIOS.CurrentRow.Cells(0).Value), DGV_EDIFICIOS.CurrentRow.Cells(7).Value)
        End If
        EDIFICIODataSet.AGENDA.Rows(0).Delete()
        AGENDATableAdapter.Update(EDIFICIODataSet.AGENDA)
        VER_MDU.ID_STATUS = 1
        VER_MDU.MODIFICADO = Today.ToShortDateString
        'MDUTableAdapter.Update(VER_MDU)
        ACTUALIZAR_INFO_MDU(CBNODO.Text)
        NOTIFICACION("SYS", "EDIFICIO DESAGENDADO")
    End Sub

    Private Sub DGV_EDIFICIOS_Click(sender As Object, e As EventArgs) Handles DGV_EDIFICIOS.Click
        BTN_DESAGENDAR.Enabled = False
        BTN_AGENDAR.Enabled = False
        BTN_VER_AGENDA.Enabled = True
        BTN_VER_EDIFICIO.Enabled = True
        If DGV_EDIFICIOS.Rows.Count > 0 Then
            MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, CInt(DGV_EDIFICIOS.CurrentRow.Cells(0).Value))
            VER_MDU = EDIFICIODataSet.MDU.Rows(0)
            Select Case VER_MDU.ID_STATUS
                Case 2 ' AGENDADO
                    BTN_DESAGENDAR.Enabled = True
                Case 1, 3, 4
                    BTN_AGENDAR.Enabled = True
            End Select
        End If
    End Sub
    Private Sub BTN_HABILITAR_Click(sender As Object, e As EventArgs) Handles BTN_HABILITAR.Click
        AVANCERow = EDIFICIODataSet.AVANCE.Rows(AVANCEBindingSource.Position)
        Select Case CB_INGRESO.Text
            Case "AEREO"
                AVANCERow.VER_AEREOS = True
            Case "DUCTO"
                AVANCERow.VER_DUCTOS_FECHADA = True
            Case "SUBTERRANEO"
                AVANCERow.VER_SUBTERRANEO = True
        End Select
        AVANCETableAdapter.Update(AVANCERow)
        AVANCETableAdapter.Fill(EDIFICIODataSet.AVANCE)
    End Sub
    Private Sub BTN_ACTUALIZAR_MDU_Click(sender As Object, e As EventArgs)
        MDU.MDUTableAdapter.FillByID(MDU.EDIFICIODataSet.MDU, DGV_EDIFICIOS.CurrentRow.Cells(0).Value)
        If MDU.Visible Then MDU.Close()
        MDU.Show(Me)
    End Sub
    Private Sub DGV_EDIFICIOS_Sorted(sender As Object, e As EventArgs) Handles DGV_EDIFICIOS.Sorted
        marcarVencidos()
    End Sub

    Private Sub REPORTE_AGENDA()
        'AGENDATableAdapter.FillByDESDE(EdificioDataSetBackUp.AGENDA, Today)

        Dim EDIFICIO As EDIFICIODataSet.MDURow
        '  Dim AGENDA As EDIFICIODataSet.AGENDARow
        EdificioDataSetBackUp.EDIF_VISTA.Clear()
        Dim NEWaG As EDIFICIODataSet.AGENDA_VIEWRow

        'If EdificioDataSetBackUp.AGENDA.Rows.Count > 0 Then
        '    For i = 0 To EdificioDataSetBackUp.AGENDA.Rows.Count - 1
        '        AGENDA = EdificioDataSetBackUp.AGENDA.Rows(i)
        '        MDUTableAdapter.FillByID(EdificioDataSetBackUp.MDU, CInt(AGENDA.ID_EDIFICIO))
        '        EDIFICIO = EdificioDataSetBackUp.MDU.Rows(0)
        '        TURNOSTableAdapter.Fill(EDIFICIODataSet.TURNOS)

        '        NEWaG = EdificioDataSetBackUp.AGENDA_VIEW.NewAGENDA_VIEWRow()

        '        NEWaG.NODO = EDIFICIO.NODO
        '        NEWaG.ZONA = EDIFICIO.ZONA
        '        NEWaG.TURNOAG = EDIFICIODataSet.TURNOS.Rows(AGENDA.ID_TURNO - 1).Item("HORARIO")
        '        NEWaG.DIAAGENDA = AGENDA.DIA_AGENDA
        '        NEWaG.CALLE = EDIFICIO.CALLE
        '        NEWaG.PUERTA = EDIFICIO.PUERTA
        '        EdificioDataSetBackUp.AGENDA_VIEW.AddAGENDA_VIEWRow(NEWaG)
        '    Next
        '    ExportarExcel(EdificioDataSetBackUp.AGENDA_VIEW, "AGENDA FTTH")
        'End If
        TURNOSTableAdapter.Fill(EDIFICIODataSet.TURNOS)
        For dias = 0 To 7
            For tec = 1 To 3
                'Select Case CBAGENDA.Text
                '    Case "AGENDA CABLEADO"
                '        AGENDATableAdapter.FILLBYDIA_TEC(EdificioDataSetBackUp.AGENDA, Today.AddDays(dias), tec, False)
                '    Case "AGENDA CERTIFICADO"
                '        AGENDATableAdapter.FILLBYDIA_TEC(EdificioDataSetBackUp.AGENDA, Today.AddDays(dias), tec, True)
                'End Select

                If Today.AddDays(dias).ToString("dddd").ToUpper = "SÁBADO" Or Today.AddDays(dias).ToString("dddd").ToUpper = "DOMINGO" Then
                    Continue For
                End If
                For turno = 1 To 4
                    Select Case turno
                        Case 1 'matutino
                            NEWaG = EdificioDataSetBackUp.AGENDA_VIEW.NewAGENDA_VIEWRow()
                            NEWaG.CALLE = "SIN AGENDAMIENTO"
                            NEWaG.DIA = Today.AddDays(dias)
                            NEWaG.TURNO = "MATUTINO"

                            If EdificioDataSetBackUp.AGENDA.Rows.Count > 0 Then
                                For Each AGENDA In EdificioDataSetBackUp.AGENDA
                                    If AGENDA.ID_TURNO = 1 Then
                                        MDUTableAdapter.FillByID(EdificioDataSetBackUp.MDU, CInt(AGENDA.ID_EDIFICIO))
                                        EDIFICIO = EdificioDataSetBackUp.MDU.Rows(0)
                                        NEWaG.NODO = EDIFICIO.NODO
                                        NEWaG.ZONA = EDIFICIO.ZONA
                                        NEWaG.DIA = AGENDA.DIA_AGENDA
                                        NEWaG.CALLE = EDIFICIO.CALLE
                                        NEWaG.PUERTA = EDIFICIO.PUERTA
                                    End If
                                Next
                            End If
                            EdificioDataSetBackUp.AGENDA_VIEW.AddAGENDA_VIEWRow(NEWaG)
                        Case 2
                            NEWaG = EdificioDataSetBackUp.AGENDA_VIEW.NewAGENDA_VIEWRow()
                            NEWaG.CALLE = "SIN AGENDAMIENTO"
                            NEWaG.DIA = Today.AddDays(dias)
                            NEWaG.TURNO = "INTERMEDIO"

                            If EdificioDataSetBackUp.AGENDA.Rows.Count > 0 Then
                                For Each AGENDA In EdificioDataSetBackUp.AGENDA
                                    If AGENDA.ID_TURNO = 4 Then
                                        MDUTableAdapter.FillByID(EdificioDataSetBackUp.MDU, CInt(AGENDA.ID_EDIFICIO))
                                        EDIFICIO = EdificioDataSetBackUp.MDU.Rows(0)
                                        NEWaG.NODO = EDIFICIO.NODO
                                        NEWaG.ZONA = EDIFICIO.ZONA
                                        NEWaG.DIA = AGENDA.DIA_AGENDA
                                        NEWaG.CALLE = EDIFICIO.CALLE
                                        NEWaG.PUERTA = EDIFICIO.PUERTA
                                    End If
                                Next
                            End If
                            EdificioDataSetBackUp.AGENDA_VIEW.AddAGENDA_VIEWRow(NEWaG)
                        Case 3
                            NEWaG = EdificioDataSetBackUp.AGENDA_VIEW.NewAGENDA_VIEWRow()
                            NEWaG.CALLE = "SIN AGENDAMIENTO"
                            NEWaG.DIA = Today.AddDays(dias)
                            NEWaG.TURNO = "VESPERTINO"

                            If EdificioDataSetBackUp.AGENDA.Rows.Count > 0 Then
                                For Each AGENDA In EdificioDataSetBackUp.AGENDA
                                    If AGENDA.ID_TURNO = 6 Then
                                        MDUTableAdapter.FillByID(EdificioDataSetBackUp.MDU, CInt(AGENDA.ID_EDIFICIO))
                                        EDIFICIO = EdificioDataSetBackUp.MDU.Rows(0)
                                        NEWaG.NODO = EDIFICIO.NODO
                                        NEWaG.ZONA = EDIFICIO.ZONA
                                        NEWaG.DIA = AGENDA.DIA_AGENDA
                                        NEWaG.CALLE = EDIFICIO.CALLE
                                        NEWaG.PUERTA = EDIFICIO.PUERTA
                                    End If
                                Next
                            End If
                            EdificioDataSetBackUp.AGENDA_VIEW.AddAGENDA_VIEWRow(NEWaG)
                        Case 4
                            NEWaG = EdificioDataSetBackUp.AGENDA_VIEW.NewAGENDA_VIEWRow()
                            NEWaG.CALLE = "SIN AGENDAMIENTO"
                            NEWaG.DIA = Today.AddDays(dias)
                            NEWaG.TURNO = "FLEXIBLE"

                            If EdificioDataSetBackUp.AGENDA.Rows.Count > 0 Then
                                For Each AGENDA In EdificioDataSetBackUp.AGENDA
                                    If AGENDA.ID_TURNO = 7 Then
                                        MDUTableAdapter.FillByID(EdificioDataSetBackUp.MDU, CInt(AGENDA.ID_EDIFICIO))
                                        EDIFICIO = EdificioDataSetBackUp.MDU.Rows(0)
                                        NEWaG.NODO = EDIFICIO.NODO
                                        NEWaG.ZONA = EDIFICIO.ZONA
                                        NEWaG.DIA = AGENDA.DIA_AGENDA
                                        NEWaG.CALLE = EDIFICIO.CALLE
                                        NEWaG.PUERTA = EDIFICIO.PUERTA
                                    End If
                                Next
                            End If
                            EdificioDataSetBackUp.AGENDA_VIEW.AddAGENDA_VIEWRow(NEWaG)
                    End Select
                Next


            Next
        Next
        ExportarExcel(EdificioDataSetBackUp.AGENDA_VIEW, "AGENDA FTTH")
    End Sub

    Private Sub BTN_VER_TODOS_Click(sender As Object, e As EventArgs) Handles BTN_VER_TODOS.Click
        ACTUALIZAR_INFO_MDU(CBNODO.Text, "TODOS")
    End Sub

    Private Sub SalirSubMenuItem_Click(sender As Object, e As EventArgs) Handles SalirSubMenuItem.Click
        Close()
    End Sub
    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        REPORTE_AGENDA()
    End Sub

    Private Sub BTN_IRNODO_Click(sender As Object, e As EventArgs) Handles BTN_IRNODO.Click
        Cursor = Cursors.WaitCursor
        ACTUALIZAR_INFO_MDU(CBNODO.Text)
        My.Settings.VALOR_NODO = CBNODO.Text
        My.Settings.Save()
        Cursor = Cursors.Default
    End Sub



    Private Sub AdministrarSubMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarSubMenuItem.Click
        If MDU.Visible Then
            MDU.BringToFront()
        End If
        MDU.Show()
    End Sub

    Private Sub AgregarPorExcelCertEdificioSubMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPorExcelCertEdificioSubMenuItem.Click
        Dim ruta = New OpenFileDialog()
        ruta.Multiselect = False
        If ruta.ShowDialog = DialogResult.OK Then
            CargarCertExcel(ruta.FileName)
        End If
    End Sub


    Private Sub ExportarSubMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarSubMenuItem.Click
        Cursor = Cursors.WaitCursor
        TRONCALESTableAdapter.FillByNODO(FIBRADataSet.TRONCALES, CBNODO.Text)
        ExportarExcel(FIBRADataSet.TRONCALES, "TRONCALES")
        Cursor = Cursors.Default
        NOTIFICACION("SYS", "EXCEL FINALIZADA")
    End Sub

    Private Sub CrearSubMenuItem_Click(sender As Object, e As EventArgs) Handles CrearSubMenuItem.Click
        Dim ruta = New OpenFileDialog()
        ruta.Multiselect = False
        If ruta.ShowDialog = DialogResult.OK Then
            REFRESCAR_TRONCALES(ruta.FileName)
        End If
        NOTIFICACION("SYS", "CARGA FINALIZADA")
    End Sub
    Private Sub AsignarNAPEdificioSubMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarNAPEdificioSubMenuItem.Click
        VINCULAR_EDIFICIOS()
    End Sub
    Private Sub AgregarPorExcelSubMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPorExcelSubMenuItem.Click
        Dim ruta = New OpenFileDialog()
        ruta.Multiselect = False
        If ruta.ShowDialog = DialogResult.OK Then
            CARGARDESDEEXCEL(ruta.FileName)
        End If
    End Sub

    Private Sub ExcelDeRelevamientoMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelDeRelevamientoMenuItem.Click
        Dim ruta = New OpenFileDialog()
        ruta.Multiselect = False
        If ruta.ShowDialog = DialogResult.OK Then
            CARGARDESDEEXCELRELEVAMIENTO(ruta.FileName)
        End If
    End Sub


End Class