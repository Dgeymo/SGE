Public Class FORMORDENES

    Dim BDtareasRow As DataRow
    Dim CAUSARow As DataRow
    Dim NewOrdinalRow As ORDENESDataSet.ORDENESRow
    Dim NewObservacionRow As ORDENESDataSet.OBESERVACIONESRow
    Dim NewTareaRow As ORDENESDataSet.TAREASRow
    Dim NUEVAFALLARow As ORDENESDataSet.SECTORFALLARow
    Dim NUEVAACTIVIDADRow As ORDENESDataSet.RELACION_FALLAACTIVIDADRow
    Dim NewSTANDARDRow As ORDENESDataSet.STANDARDRow
    Dim STANDARDRow As DataRow

    Dim ACTIVIDADRow As DataRow
    Dim VISTAORDENES As DataView
    Dim SECTOR_ELEGIDO As String


    Dim TIEMP_TARPREV As Double
    Dim TIEMP_TARREAL As Double
    Dim FECHAARRANQUE As Date

    Dim CANTIDADORD As Integer

    Dim NRO_ORDENINT As Integer
    Dim NRO_ORDINAL As Integer
    Dim STATUSACT As String

    Dim Campo(30) As String
    Dim Dato(30) As String
    Dim Filtro(30) As String
    Dim UNION(20) As String
    Private Sub FORMORDENES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ACTIVIDADESSTDTableAdapter.Fill(Me.ORDENESDataSet.ACTIVIDADESSTD)
            Me.TAREASSTDTableAdapter.Fill(Me.ORDENESDataSet.TAREASSTD)
            Me.USUARIOSTableAdapter.Fill(Me.OPERACIONES_LOGDataSet.USUARIOS)
            Me.SECTORESTableAdapter.Fill(Me.ORDENESDataSet.SECTORES)
            Me.SECTORESTableAdapter.Fill(Me.OrdenesDataSet1.SECTORES)
            SECTORESBindingSource1.MoveFirst()
            If IsDBNull(OrdenesDataSet1.SECTORES.Rows(0)) = False Then
                SECTOR_ELEGIDO = OrdenesDataSet1.SECTORES.Rows(0).Item("SECTOR")
                Label24.Text = Label24.Text & "  " & SECTOR_ELEGIDO
                Me.SECTORFALLATableAdapter.FillBySECTOR_USO(Me.OrdenesDataSet1.SECTORFALLA, SECTOR_ELEGIDO, ComboBox2.Text)
            End If


            Me.CAUSASTableAdapter.FillByORDEN(Me.ORDENESDataSet.CAUSAS)
            Me.FALLASTableAdapter.FillByORDEN(Me.ORDENESDataSet.FALLAS, "APERTURA")
            Me.SECTORFALLATableAdapter.Fill(Me.ORDENESDataSet.SECTORFALLA)
            Me.STATUSTableAdapter.Fill(Me.ORDENESDataSet.STATUS)

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

        Cursor = Cursors.Default
    End Sub
    Private Sub CARGA_COMBOS()

        'CARGA COMBO SECTORES

        SECTOR_ORD.Items.Add("")
        For I = 0 To ORDENESDataSet.SECTORES.Rows.Count - 1
            SECTOR_ORD.Items.Add(ORDENESDataSet.SECTORES.Rows(I).Item("SECTOR"))
        Next

        CAUSA_ORIGEN.Items.Add("")
        CAUSA_FIN.Items.Add("")

        For I = 0 To ORDENESDataSet.CAUSAS.Rows.Count - 1
            If ORDENESDataSet.CAUSAS.Rows(I).Item("USO") = "ORIGEN" Then
                CAUSA_ORIGEN.Items.Add(ORDENESDataSet.CAUSAS.Rows(I).Item("DESCCAUSA"))
            End If
            If ORDENESDataSet.CAUSAS.Rows(I).Item("USO") = "CIERRE" Then
                CAUSA_FIN.Items.Add(ORDENESDataSet.CAUSAS.Rows(I).Item("DESCCAUSA"))
            End If
        Next

        STATUS.Items.Add("")
        For I = 0 To ORDENESDataSet.STATUS.Rows.Count - 1
            STATUS.Items.Add(ORDENESDataSet.STATUS.Rows(I).Item("STATUS"))
        Next

    End Sub
    Private Sub FILTRA_ORDEN()

        VISTAORDENES = ORDENESDataSet.ORDENES.AsDataView

        Campo(0) = ("FECHAINGRESO")
        Dato(0) = CDate((FECH_INGDESDE.Value.Day & "/" & FECH_INGDESDE.Value.Month & "/" & FECH_INGDESDE.Value.Year))
        If FECH_INGDESDE.Checked = True Then
            Filtro(0) = "[" & Campo(0) & "] >= '" & CDate(Dato(0)) & "'"

            UNION(0) = "AND"
        Else
            Filtro(0) = ""
            UNION(0) = ""
        End If

        Campo(1) = ("FECHAINGRESO")
        Dato(1) = CDate((FECH_INGHASTA.Value.Day & "/" & FECH_INGHASTA.Value.Month & "/" & FECH_INGHASTA.Value.Year))
        If FECH_INGHASTA.Checked = True Then
            Filtro(1) = UNION(0) & " [" & Campo(1) & "] <= '" & CDate(Dato(1)) & "'"
        Else
            Filtro(1) = ""
        End If

        If Filtro(0) = "" And Filtro(1) = "" Then
            UNION(1) = ""
        Else
            UNION(1) = "AND"
        End If


        Campo(2) = ("FECHAINICIO")
        Dato(2) = CDate((FECH_INIDESDE.Value.Day & "/" & FECH_INIDESDE.Value.Month & "/" & FECH_INIDESDE.Value.Year))
        If FECH_INIDESDE.Checked = True Then
            Filtro(2) = " " & UNION(1) & " [" & Campo(2) & "] >= '" & CDate(Dato(2)) & "'"
        Else
            Filtro(2) = ""
        End If

        If Filtro(0) = "" And Filtro(1) = "" And Filtro(2) = "" Then
            UNION(2) = ""
        Else
            UNION(2) = "AND"
        End If




        Campo(3) = ("FECHAINICIO")
        Dato(3) = CDate((FECH_INIHASTA.Value.Day & "/" & FECH_INIHASTA.Value.Month & "/" & FECH_INIHASTA.Value.Year))
        If FECH_INIHASTA.Checked = True Then
            Filtro(3) = " " & UNION(2) & " [" & Campo(3) & "] <= '" & CDate(Dato(3)) & "'"
        Else
            Filtro(3) = ""
        End If

        If Filtro(0) = "" And Filtro(1) = "" And Filtro(2) = "" And Filtro(3) = "" Then
            UNION(3) = ""
        Else
            UNION(3) = "AND"
        End If


        Campo(4) = ("FECHACIERRE")
        Dato(4) = CDate((FECH_CIERREDESDE.Value.Day & "/" & FECH_CIERREDESDE.Value.Month & "/" & FECH_CIERREDESDE.Value.Year))
        If FECH_CIERREDESDE.Checked = True Then
            Filtro(4) = " " & UNION(3) & " [" & Campo(4) & "] >= '" & CDate(Dato(4)) & "'"
        Else
            Filtro(4) = ""
        End If

        If Filtro(0) = "" And Filtro(1) = "" And Filtro(2) = "" And Filtro(3) = "" And Filtro(4) = "" Then
            UNION(4) = ""
        Else
            UNION(4) = "AND"
        End If


        Campo(5) = ("FECHACIERRE")
        Dato(5) = CDate((FECH_CIERREHASTA.Value.Day & "/" & FECH_CIERREHASTA.Value.Month & "/" & FECH_CIERREHASTA.Value.Year))
        If FECH_CIERREHASTA.Checked = True Then
            Filtro(5) = " " & UNION(4) & " [" & Campo(5) & "] < '" & CDate(Dato(5)) & "'"
        Else
            Filtro(5) = ""
        End If

        If Filtro(0) = "" And Filtro(1) = "" And Filtro(2) = "" And Filtro(3) = "" And Filtro(4) = "" And Filtro(5) = "" Then
            UNION(5) = ""
        Else
            UNION(5) = "AND"
        End If

        Campo(6) = ("CALLE")
        Dato(6) = ORD_CALLE.Text
        Filtro(6) = UNION(5) & " [" & Campo(6) & "] like '*" & Dato(6) & "*'"

        Campo(7) = ("MOTIVOORIGEN")
        Dato(7) = MOT_ORIGEN.Text
        Filtro(7) = " AND [" & Campo(7) & "] like '*" & Dato(7) & "*'"


        Campo(8) = ("MOTIVOCIERRE")
        Dato(8) = MOT_FIN.Text
        If MOT_FIN.Text <> "" Then
            Filtro(8) = " AND [" & Campo(8) & "] like '*" & Dato(8) & "*'"
        Else
            Filtro(8) = ""
        End If

        Campo(9) = ("CAUSARIGEN")
        Dato(9) = CAUSA_ORIGEN.Text
        Filtro(9) = " AND [" & Campo(9) & "] like '*" & Dato(9) & "*'"

        Campo(10) = ("CAUSACIERRE")
        Dato(10) = CAUSA_FIN.Text
        If CAUSA_FIN.Text <> "" Then
            Filtro(10) = " AND [" & Campo(10) & "] like '*" & Dato(10) & "*'"
        Else
            Filtro(10) = ""
        End If
        Campo(11) = ("TIPO")
        Dato(11) = TIPO.Text
        Filtro(11) = " AND [" & Campo(11) & "] like '*" & Dato(11) & "*'"

        Campo(12) = ("SECTORDESTINO")
        Dato(12) = AREA.Text
        Filtro(12) = " AND [" & Campo(12) & "] like '*" & Dato(12) & "*'"

        Campo(13) = ("STATUS")
        Dato(13) = STATUS.Text
        Filtro(13) = " AND [" & Campo(13) & "] like '*" & Dato(13) & "*'"

        Campo(14) = ("NODO")
        Dato(14) = NODO.Text
        Filtro(14) = " AND [" & Campo(14) & "] like '*" & Dato(14) & "*'"

        Campo(15) = ("ZONA")
        Dato(15) = ZONA.Text
        Filtro(15) = " AND [" & Campo(15) & "] like '*" & Dato(15) & "*'"

        Campo(16) = ("CALLE")
        Dato(16) = ORD_CALLE.Text
        Filtro(16) = " AND [" & Campo(16) & "] like '*" & Dato(16) & "*'"

        Campo(17) = ("NRO")
        Dato(17) = NUMERO.Text
        Filtro(17) = " AND [" & Campo(17) & "] like '*" & Dato(17) & "*'"

        Campo(18) = ("CARPETA")
        Dato(18) = CARPMDU.Text
        Filtro(18) = " AND [" & Campo(18) & "] like '*" & Dato(18) & "*'"

        Campo(19) = ("GENERADOR")
        Dato(19) = GENERADOR.Text
        Filtro(19) = " AND [" & Campo(19) & "] like '*" & Dato(19) & "*'"

        Campo(20) = ("SOLICITANTE")
        Dato(20) = SOLICITANTE.Text
        Filtro(20) = " AND [" & Campo(20) & "] like '*" & Dato(20) & "*'"

        Campo(21) = ("CUADRILLA")
        Dato(21) = CUADRILLA.Text
        If CUADRILLA.Text <> "" Then
            Filtro(21) = " AND [" & Campo(21) & "] like '*" & Dato(21) & "*'"
        Else
            Filtro(21) = ""
        End If

        If ORDEN.Text <> "" Then
            Campo(22) = ("NRO_ORDENINT")
            Dato(22) = CInt(ORDEN.Text)
            Filtro(22) = " AND [" & Campo(22) & "] = '" & Dato(22) & "'"
        Else
            Filtro(22) = ""
        End If

        If ORDINAL.Text <> "" Then
            Campo(23) = ("NRO_ORDINAL")
            Dato(23) = CInt(ORDINAL.Text)
            Filtro(23) = " AND [" & Campo(23) & "] = '" & Dato(23) & "'"
        Else
            Filtro(23) = ""
        End If

        VISTAORDENES.RowFilter = Filtro(0) & Filtro(1) & Filtro(2) & Filtro(3) & Filtro(4) & Filtro(5) & Filtro(6) & Filtro(7) & Filtro(8) & Filtro(9) & Filtro(10) & Filtro(11) & Filtro(12) & Filtro(13) & Filtro(14) & Filtro(15) & Filtro(16) & Filtro(17) & Filtro(18) & Filtro(19) & Filtro(20) & Filtro(21) & Filtro(22) & Filtro(23)

        ORDENESBindingSource.DataSource = VISTAORDENES
        CANTIDADORD = ORDENESDataGridView.Rows.Count
        CANT_ORD.Text = CANTIDADORD
    End Sub
    Private Sub ORDENESDataGridView_Click(sender As Object, e As EventArgs) Handles ORDENESDataGridView.Click
        If ORDENESDataGridView.RowCount > 0 Then
            NRO_ORDINAL = Me.ORDENESDataGridView.CurrentRow.Cells.Item(1).Value
            NRO_ORDENINT = Me.ORDENESDataGridView.CurrentRow.Cells.Item(0).Value
            STATUSACT = Me.ORDENESDataGridView.CurrentRow.Cells.Item(2).Value

            'CARGA CAMPOS OBSERVACIONES
            If STATUSACT = "FINALIZADO" Then
                OBESERVACIONESTableAdapter.FillByORDINAL(ORDENESDataSet.OBESERVACIONES, NRO_ORDINAL)

            Else
                OBESERVACIONESTableAdapter.FillByORDENINT(ORDENESDataSet.OBESERVACIONES, NRO_ORDENINT)

            End If

            'CARGA HISTORICO
            HISTORICOTableAdapter.FillByORDENINT(ORDENESDataSet.HISTORICO, NRO_ORDENINT)

            'CARGA TAREAS
            If STATUSACT = "FINALIZADO" Then TAREASTableAdapter.FillByORDINAL(ORDENESDataSet.TAREAS, NRO_ORDINAL)

        End If
    End Sub
    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged


        Me.SECTORFALLATableAdapter.FillBySECTOR_USO(Me.OrdenesDataSet1.SECTORFALLA, SECTOR_ELEGIDO, ComboBox2.Text)
        If OrdenesDataSet1.SECTORFALLA.Rows.Count > 0 Then
            'BUSCA LA ACTIVIDAD DE LA FALLA SELECCIONADA
            RELACION_FALLAACTIVIDADTableAdapter.FillByFALLA(ORDENESDataSet.RELACION_FALLAACTIVIDAD, SECTORFALLADataGridView.SelectedCells.Item(0).Value)
            'SI ENCUENTRA UNA ACTIVIDAD DEFINIDA
            If DataGridView4.Rows.Count > 0 Then
                STANDARDTableAdapter.FillByACTIVIDAD(ORDENESDataSet.STANDARD, DataGridView4.CurrentRow.Cells.Item(0).Value)
                CALCULA_TIEMPOS()
            Else 'SI NO ENCUENTRA UNA ACTIVIDAD DEFINIDA
                ORDENESDataSet.STANDARD.Clear()
                LBL_TIEMPO_FINAL.Text = 0
            End If
        Else 'SI NO ENCUENTRA FALLAS EN AL SECTOR
            'BORRA LA TABLA DE ACTIVIDAD
            ORDENESDataSet.RELACION_FALLAACTIVIDAD.Clear()
            'BORRA LA TABLA DE STANDARD
            ORDENESDataSet.STANDARD.Clear()
        End If
        Me.FALLASTableAdapter.FillByORDEN(Me.ORDENESDataSet.FALLAS, ComboBox2.Text)


    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Cursor = Cursors.WaitCursor
        Label24.Text = "Fallas para "
        ORDENESDataSet.RELACION_FALLAACTIVIDAD.Clear()

        If IsDBNull(DataGridView1.SelectedCells.Item(0).Value) = False Then
            SECTOR_ELEGIDO = DataGridView1.CurrentRow.Cells.Item(0).Value
            Label24.Text = Label24.Text & "  " & SECTOR_ELEGIDO

            'BUSCA LAS FALLAS CORRESPONDIENTES AL SECTOR SELECCIONADO
            Me.SECTORFALLATableAdapter.FillBySECTOR_USO(Me.OrdenesDataSet1.SECTORFALLA, SECTOR_ELEGIDO, ComboBox2.Text)
            'SI ENCUENTRA FALLAS EN EL SECTOR
            If OrdenesDataSet1.SECTORFALLA.Rows.Count > 0 Then
                'BUSCA LA ACTIVIDAD DE LA FALLA SELECCIONADA
                RELACION_FALLAACTIVIDADTableAdapter.FillByFALLA(ORDENESDataSet.RELACION_FALLAACTIVIDAD, SECTORFALLADataGridView.SelectedCells.Item(0).Value)
                'SI ENCUENTRA UNA ACTIVIDAD DEFINIDA
                If DataGridView4.Rows.Count > 0 Then
                    STANDARDTableAdapter.FillByACTIVIDAD(ORDENESDataSet.STANDARD, DataGridView4.CurrentRow.Cells.Item(0).Value)
                    CALCULA_TIEMPOS()
                Else 'SI NO ENCUENTRA UNA ACTIVIDAD DEFINIDA
                    ORDENESDataSet.STANDARD.Clear()
                    LBL_TIEMPO_FINAL.Text = 0
                End If
            Else 'SI NO ENCUENTRA FALLAS EN AL SECTOR
                'BORRA LA TABLA DE ACTIVIDAD
                ORDENESDataSet.RELACION_FALLAACTIVIDAD.Clear()
                'BORRA LA TABLA DE STANDARD
                ORDENESDataSet.STANDARD.Clear()
            End If
        End If

        Cursor = DefaultCursor
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor
        Me.SECTORFALLATableAdapter.Update(ORDENESDataSet.SECTORFALLA)
        Cursor = DefaultCursor
    End Sub
    Private Sub FECH_INGDESDE_ValueChanged(sender As Object, e As EventArgs) Handles FECH_INGDESDE.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub FECH_INGHASTA_ValueChanged(sender As Object, e As EventArgs) Handles FECH_INGHASTA.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub FECH_INIDESDE_ValueChanged(sender As Object, e As EventArgs) Handles FECH_INIDESDE.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub FECH_INIHASTA_ValueChanged(sender As Object, e As EventArgs) Handles FECH_INIHASTA.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub FECH_CIERREDESDE_ValueChanged(sender As Object, e As EventArgs) Handles FECH_CIERREDESDE.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub FECH_CIERREHASTA_ValueChanged(sender As Object, e As EventArgs) Handles FECH_CIERREHASTA.ValueChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub ORD_CALLE_TextChanged(sender As Object, e As EventArgs) Handles ORD_CALLE.TextChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub SECTOR_ORD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SECTOR_ORD.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        MOT_ORIGEN.Items.Clear()
        MOT_FIN.Items.Clear()

        If SECTOR_ORD.Text <> "" Then
            SECTORFALLATableAdapter.FillBySECTOR(ORDENESDataSet.SECTORFALLA, SECTOR_ORD.Text, TXT_ING_TIPO.Text)
        Else
            SECTORFALLATableAdapter.Fill(ORDENESDataSet.SECTORFALLA)
        End If

        MOT_ORIGEN.Items.Add("")
        MOT_FIN.Items.Add("")

        For I = 0 To ORDENESDataSet.SECTORFALLA.Rows.Count - 1

            If ORDENESDataSet.SECTORFALLA.Rows(I).Item("USO") = "APERTURA" Then
                If I < ORDENESDataSet.SECTORFALLA.Rows.Count - 1 Then
                    If ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA") = ORDENESDataSet.SECTORFALLA.Rows(I + 1).Item("FALLA") Then
                        'LO GRABA CUANDO CAMBIE
                    Else
                        MOT_ORIGEN.Items.Add(ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA"))
                    End If
                Else
                    MOT_ORIGEN.Items.Add(ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA"))
                End If
            End If


            If ORDENESDataSet.SECTORFALLA.Rows(I).Item("USO") = "CIERRE" Then

                If I < ORDENESDataSet.SECTORFALLA.Rows.Count - 1 Then
                    If ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA") = ORDENESDataSet.SECTORFALLA.Rows(I + 1).Item("FALLA") Then
                        'LO GRABA CUANDO CAMBIE
                    Else
                        MOT_FIN.Items.Add(ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA"))
                    End If
                Else
                    MOT_FIN.Items.Add(ORDENESDataSet.SECTORFALLA.Rows(I).Item("FALLA"))
                End If
            End If
        Next
        Me.Cursor = DefaultCursor
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ORDEN.Text = ""
        ORDINAL.Text = ""
        TIPO.Text = ""
        AREA.Text = ""
        STATUS.Text = ""
        SECTOR_ORD.Text = ""
        MOT_ORIGEN.Text = ""
        MOT_FIN.Text = ""
        CAUSA_ORIGEN.Text = ""
        CAUSA_FIN.Text = ""
        FECH_INGDESDE.Checked = True
        FECH_INGHASTA.Checked = False
        FECH_INIDESDE.Checked = False
        FECH_INIHASTA.Checked = False
        FECH_CIERREDESDE.Checked = False
        FECH_CIERREHASTA.Checked = False
        NODO.Text = ""
        ZONA.Text = ""
        ORD_CALLE.Text = ""
        NUMERO.Text = ""
        CARPMDU.Text = ""
        GENERADOR.Text = ""
        SOLICITANTE.Text = ""
        CUADRILLA.Text = ""
        ORDEN.Text = ""
        ORDINAL.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SECTORESTableAdapter.Update(OrdenesDataSet1.SECTORES)
        Me.SECTORESTableAdapter.Fill(OrdenesDataSet1.SECTORES)
    End Sub
    Private Sub FALLASDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles FALLASDataGridView.DoubleClick
        For I = FALLASDataGridView.SelectedCells.Count - 1 To 0 Step -1

            NUEVAFALLARow = OrdenesDataSet1.SECTORFALLA.NewSECTORFALLARow

            NUEVAFALLARow("SECTOR") = DataGridView1.SelectedCells.Item(0).Value
            NUEVAFALLARow("FALLA") = FALLASDataGridView.SelectedRows(I).Cells.Item(0).Value
            NUEVAFALLARow("USO") = ComboBox2.Text

            Me.OrdenesDataSet1.SECTORFALLA.Rows.Add(NUEVAFALLARow)

        Next
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        SECTORFALLATableAdapter.Update(OrdenesDataSet1.SECTORFALLA)
        'SECTORFALLATableAdapter.Fill(ORDENESDataSet1.SECTORFALLA)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FALLASTableAdapter.Update(ORDENESDataSet.FALLAS)
        'FALLASTableAdapter.Fill(ORDENESDataSet.FALLAS)
    End Sub
    Private Sub SECTORFALLADataGridView_Click(sender As Object, e As EventArgs) Handles SECTORFALLADataGridView.Click
        ORDENESDataSet.RELACION_FALLAACTIVIDAD.Clear()
        If OrdenesDataSet1.SECTORFALLA.Rows.Count > 0 Then
            RELACION_FALLAACTIVIDADTableAdapter.FillByFALLA(ORDENESDataSet.RELACION_FALLAACTIVIDAD, SECTORFALLADataGridView.SelectedCells.Item(0).Value)
            'SI ENCUENTRA UNA ACTIVIDAD DEFINIDA
            If DataGridView4.Rows.Count > 0 Then
                STANDARDTableAdapter.FillByACTIVIDAD(ORDENESDataSet.STANDARD, DataGridView4.CurrentRow.Cells.Item(0).Value)
                CALCULA_TIEMPOS()
            Else 'SI NO ENCUENTRA UNA ACTIVIDAD DEFINIDA
                ORDENESDataSet.STANDARD.Clear()
                LBL_TIEMPO_FINAL.Text = 0
            End If
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        RELACION_FALLAACTIVIDADTableAdapter.Update(ORDENESDataSet.RELACION_FALLAACTIVIDAD)
    End Sub
    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        If DataGridView4.Rows.Count > 0 Then
            ACTIVIDADRow = ORDENESDataSet.RELACION_FALLAACTIVIDAD.Rows(0)
            ACTIVIDADRow("ACTIVIDAD") = DataGridView2.SelectedCells.Item(0).Value
        Else
            NUEVAACTIVIDADRow = ORDENESDataSet.RELACION_FALLAACTIVIDAD.NewRELACION_FALLAACTIVIDADRow
            NUEVAACTIVIDADRow("ACTIVIDAD") = DataGridView2.SelectedCells.Item(0).Value
            NUEVAACTIVIDADRow("FALLA") = SECTORFALLADataGridView.CurrentRow.Cells.Item(0).Value
            ORDENESDataSet.RELACION_FALLAACTIVIDAD.Rows.Add(NUEVAACTIVIDADRow)
        End If
    End Sub
    Private Sub MOT_ORIGEN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MOT_ORIGEN.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub MOT_FIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MOT_FIN.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub CAUSA_ORIGEN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CAUSA_ORIGEN.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub CAUSA_FIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CAUSA_FIN.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub AREA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AREA.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TIPO.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub STATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles STATUS.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub NODO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NODO.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub ZONA_SelectedIndexChanged(sender As Object, e As EventArgs)
        FILTRA_ORDEN()
    End Sub
    Private Sub NUMERO_TextChanged(sender As Object, e As EventArgs) Handles NUMERO.TextChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub CARPMDU_TextChanged(sender As Object, e As EventArgs) Handles CARPMDU.TextChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub GENERADOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GENERADOR.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub SOLICITANTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SOLICITANTE.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub CUADRILLA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CUADRILLA.SelectedIndexChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub ORDEN_TextChanged(sender As Object, e As EventArgs) Handles ORDEN.TextChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub ORDINAL_TextChanged(sender As Object, e As EventArgs) Handles ORDINAL.TextChanged
        FILTRA_ORDEN()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Cursor = Cursors.WaitCursor
        Me.STANDARDTableAdapter.Update(ORDENESDataSet.STANDARD)
        Cursor = DefaultCursor
    End Sub
    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick
        If DataGridView4.Rows.Count > 0 Then
            NewSTANDARDRow = ORDENESDataSet.STANDARD.NewSTANDARDRow

            NewSTANDARDRow("ACTIVIDAD") = DataGridView4.CurrentRow.Cells.Item(0).Value
            NewSTANDARDRow("TAREA") = DataGridView3.CurrentRow.Cells.Item(0).Value
            NewSTANDARDRow("CANTSTD") = 1
            NewSTANDARDRow("CANTORDEN") = 1
            NewSTANDARDRow("UNIDAD") = DataGridView3.CurrentRow.Cells.Item(1).Value
            NewSTANDARDRow("TIEMPOUNIT") = DataGridView3.CurrentRow.Cells.Item(2).Value
            NewSTANDARDRow("TIEMPOMIN") = DataGridView3.CurrentRow.Cells.Item(2).Value

            ORDENESDataSet.STANDARD.Rows.Add(NewSTANDARDRow)

        Else
            MsgBox("No existe ACTIVIDAD definida para la falla seleccionada")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TAREASSTDTableAdapter.Update(ORDENESDataSet.TAREASSTD)
    End Sub
    Private Sub CALCULA_TIEMPOS()
        Dim TIEMPO As Integer
        TIEMPO = 0
        For I = 0 To ORDENESDataSet.STANDARD.Rows.Count - 1
            STANDARDRow = ORDENESDataSet.STANDARD.Rows(I)
            If IsDBNull(STANDARDRow("TIEMPOUNIT")) = False Then
                STANDARDRow("TIEMPOMIN") = STANDARDRow("CANTORDEN") * STANDARDRow("TIEMPOUNIT")
                TIEMPO = TIEMPO + STANDARDRow("TIEMPOMIN")
            End If
            LBL_TIEMPO_FINAL.Text = TIEMPO
            'STANDARDTableAdapter.Update(STANDARDRow)
        Next
    End Sub
    Private Sub DataGridView5_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellEndEdit
        If e.ColumnIndex = 3 Then
            CALCULA_TIEMPOS()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ACTIVIDADESSTDTableAdapter.Update(ORDENESDataSet.ACTIVIDADESSTD)
    End Sub
    Private Sub BTNCargar_Click(sender As Object, e As EventArgs) Handles BTNCargar.Click

    End Sub


End Class
