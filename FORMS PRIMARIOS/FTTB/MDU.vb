
Public Class MDU
    Dim FTTBRow As EDIFICIODataSet.FTTBRow
    Dim MDURow As EDIFICIODataSet.MDURow
    Dim NAP As String
    Dim ZONA As String
    Dim DISTRO As String
    Dim CAJAS As String
    Dim CAJANRO As String
    Dim SPLITTER As Integer
    Dim ACO As String
    Dim CAMPO(5) As String
    Dim DATO(5) As String
    Dim FILTRO(5) As String
    Dim VISTAEDIFICIO As DataView
    Private Sub MDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EDIFICIODataSet.CABLES' Puede moverla o quitarla según sea necesario.
        Me.CABLESTableAdapter.Fill(Me.EDIFICIODataSet.CABLES)
        CB_CABLE.Items.Clear()
        For Each CABLES In EDIFICIODataSet.CABLES
            CB_CABLE.Items.Add(CABLES.MODELO)
        Next

        'TODO: esta línea de código carga datos en la tabla 'EDIFICIODataSet.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.EDIFICIODataSet.ARTICULO)
        CB_TIPO_NAP.Items.Clear()
        For Each naps In EDIFICIODataSet.ARTICULO
            Select Case naps.NOMBRE
                Case "NAP4", "NAP8", "NAP16"
                    CB_TIPO_NAP.Items.Add(naps.NOMBRE)

            End Select
        Next
        CB_TIPO.Items.Clear()
        For Each UNACAJA In EDIFICIODataSet.ARTICULO
            Select Case UNACAJA.NOMBRE
                Case "CED", "FDH", "NAP"
                    CB_TIPO.Items.Add(UNACAJA.NOMBRE)
            End Select
        Next

        'TODO: esta línea de código carga datos en la tabla 'EDIFICIODataSet.COLORES' Puede moverla o quitarla según sea necesario.
        Me.COLORESTableAdapter.Fill(Me.EDIFICIODataSet.COLORES)
        NAP_TUBO.Items.Clear()
        NAP_PELO.Items.Clear()
        For Each COLORES In EDIFICIODataSet.COLORES
            NAP_TUBO.Items.Add(COLORES.COLOR)
            NAP_PELO.Items.Add(COLORES.COLOR)
        Next


        MDUTableAdapter.FillBynodo(EDIFICIODataSet.MDU, INICIO.CBNODO.Text)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU"))
        ACTUALIZAR_FTTB()

    End Sub

    Private Sub BtnGuardarFttb_Click(sender As Object, e As EventArgs) Handles btnGuardarFttb.Click
        FTTBRow.CONEXION_DESDE = TXT_CONEXION_DESDE.Text

        If CAJA_DISTRIBUCIONTextBox.Text <> "" Then FTTBRow.CAJA_DISTRIBUCION = CAJA_DISTRIBUCIONTextBox.Text
        For Each cable In EDIFICIODataSet.CABLES
            If cable.MODELO = CB_CABLE.Text Then
                FTTBRow.CABLE = cable.ID_CABLE
                Exit For
            End If
        Next
        For Each Naps In EDIFICIODataSet.ARTICULO
            If Naps.NOMBRE = CB_TIPO_NAP.Text Then
                FTTBRow.NAP = Naps.ID_ARTICULO
                Exit For
            End If
        Next
        For Each UNACAJA In EDIFICIODataSet.ARTICULO
            If UNACAJA.NOMBRE = CB_TIPO.Text Then
                FTTBRow.TIPO_CONEXION_DESDE = UNACAJA.NOMBRE
            End If
        Next
        FTTBRow.NAP_NRO = NAP_NROTextBox.Text

        For Each TUBO In EDIFICIODataSet.ARTICULO
            If TUBO.NOMBRE = NAP_TUBO.Text Then
                FTTBRow.TUBO = TUBO.NOMBRE
                Exit For
            End If
        Next
        For Each PELOS In EDIFICIODataSet.ARTICULO
            If PELOS.NOMBRE = NAP_PELO.Text Then
                FTTBRow.PELO = PELOS.NOMBRE
                Exit For
            End If
        Next
        FTTBRow.OBS_TEC = OBS_TECTextBox.Text
        FTTBRow.ACOMETIDA = TXT_ACOMETIDA.Text
        FTTBRow.SPL_NRO = NAP_SPL.Text
        FTTBTableAdapter.Update(FTTBRow)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDURow.ID_MDU)
        NOTIFICACION("SYS", "registro FTTB actualizado")
        PintarMDU()
    End Sub
    Private Sub DGV_MDU_Click(sender As Object, e As EventArgs) Handles DGV_MDU.Click
        Cursor = Cursors.WaitCursor

        MDURow = EDIFICIODataSet.MDU.FindByID_MDU(DGV_MDU.CurrentRow.Cells(4).Value)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDURow.ID_MDU)

        If MDURow.IsID_CALLENull Then ID_CALLETextBox.Text = "" Else ID_CALLETextBox.Text = MDURow("ID_CALLE")
        CALLETextBox.Text = MDURow.CALLE
        PUERTATextBox.Text = MDURow.PUERTA
        APTOSTextBox.Text = MDURow.APTOS
        If MDURow.IsPISOSNull Then PISOSTextBox.Text = "" Else PISOSTextBox.Text = MDURow.PISOS
        If MDURow.IsTORRENull Then TORRETextBox.Text = "" Else TORRETextBox.Text = MDURow.TORRE
        NODOTextBox.Text = MDURow.NODO
        ZONATextBox.Text = MDURow.ZONA
        If MDURow.IsCARPETANull Then CARPETATextBox.Text = "" Else CARPETATextBox.Text = MDURow.CARPETA
        If MDURow.IsMODIFICADONull Then MODIFICADODateTimePicker.Value = Today Else MODIFICADODateTimePicker.Value = MDURow.MODIFICADO
        If MDURow.IsACOMETIDANull Then
            ACOMETIDATextBox.Text = ""
        Else
            ACOMETIDATextBox.Text = MDURow.ACOMETIDA
        End If
        If MDURow.IsINGRESONull Then CB_INGRESO.Text = "" Else CB_INGRESO.Text = MDURow.INGRESO
        ACTUALIZAR_FTTB()
        Cursor = Cursors.Default
    End Sub
    Private Sub CargarListaFTTB()

        ' ListNAP.Items.Clear()
        If EDIFICIODataSet.FTTB.Rows.Count > 0 Then
            For i = 0 To EDIFICIODataSet.FTTB.Rows.Count - 1
                FTTBRow = EDIFICIODataSet.FTTB.Rows(i)
                CAJAS = FTTBRow.TIPO_CONEXION_DESDE
                SPLITTER = FTTBRow.SPL_NRO
                NAP = FTTBRow.NAP_NRO
                If NAP < 10 Then NAP = "0" & FTTBRow.NAP

                If FTTBRow.IsCAJA_DISTRIBUCIONNull = False Then
                    DISTRO = FTTBRow.CAJA_DISTRIBUCION
                    If DISTRO < 0 Then DISTRO = "0" & DISTRO
                End If
                If FTTBRow.IsCONEXION_DESDENull Then
                    CAJANRO = "N/A"
                Else
                    CAJANRO = FTTBRow.CONEXION_DESDE
                    If CAJANRO < 10 Then CAJANRO = "0" & CAJANRO
                End If
                If FTTBRow.IsCONEXION_DESDENull Then
                    CAJANRO = "N/A"
                Else
                    CAJANRO = FTTBRow.CONEXION_DESDE
                    If CAJANRO < 10 Then CAJANRO = "0" & CAJANRO
                End If

                If FTTBRow.IsACOMETIDANull Then
                    ACO = "N/A"
                Else
                    ACO = FTTBRow.ACOMETIDA
                    If ACO < 10 Then ACO = "0" & ACO
                End If


                ZONA = MDURow.ZONA
                If ZONA < 10 Then ZONA = "0" & ZONA



                If FTTBRow.NAP = 8 Then
                    ' ListNAP.Items.Add("NAP" & NAP & "-A" & ACO & "-" & MDURow.NODO & ZONA)
                    ' ListNAP.Items.Add("NAP" & NAP & "-A" & ACO & "-" & MDURow.NODO & ZONA).SubItems.Add(CAJA & CAJANRO & "-D" & DISTRO & "-" & MDURow.NODO & ZONA)
                Else
                    '  ListNAP.Items.Add("NAP" & NAP & "-A" & ACO & "-" & MDURow.NODO & ZONA).SubItems.Add(CAJA & CAJANRO & "-D" & DISTRO & "-" & MDURow.NODO & ZONA)
                    '  ListNAP.Items("")
                End If



                'If SPLITTER = 1 Then
                '    If CAJA = "FDH" Or CAJA = "CED" Then
                '        ListNAP.Items.Add(CAJA & CAJANRO & "-D" & DISTRO & "-" & MDURow.NODO & ZONA)
                '    Else
                '        ListNAP.Items.Add(CAJA & CAJANRO & "-A" & DISTRO & "-" & MDURow.NODO & ZONA)
                '    End If
                '    ListNAP.Items("").SubItems.Add("NAP" & NAP)
                'Else
                '    ListNAP.Items.Add("")
                '    ListNAP.Items("").SubItems.Add("NAP" & NAP)
                'End If

            Next
        End If
    End Sub
    Private Sub BUSCA_TIPO()
        VISTAEDIFICIO = EDIFICIODataSet.MDU.AsDataView

        CAMPO(0) = "CALLE"
        DATO(0) = TXT_CALLE.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"

        CAMPO(1) = "PUERTA"
        DATO(1) = TXT_NRO.Text
        If TXT_NRO.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND  [" & CAMPO(1) & "] like '*" & DATO(1) & "*'"
        End If

        VISTAEDIFICIO.RowFilter = FILTRO(0) & FILTRO(1)
        DGV_MDU.DataSource = VISTAEDIFICIO
        PintarMDU()
    End Sub
    Private Sub btnGuardarEdificio_Click(sender As Object, e As EventArgs) Handles btnGuardarEdificio.Click
        MDURow.ID_CALLE = ID_CALLETextBox.Text
        MDURow.PUERTA = PUERTATextBox.Text
        MDURow.APTOS = APTOSTextBox.Text
        MDURow.PISOS = PISOSTextBox.Text
        Try
            MDURow.TORRE = TORRETextBox.Text
        Catch ex As Exception
            MsgBox("complete la torre")
            Exit Sub
        End Try
        MDURow.TORRE = TORRETextBox.Text
        MDURow.NODO = NODOTextBox.Text
        MDURow.ZONA = ZONATextBox.Text
        MDURow.INGRESO = CB_INGRESO.Text
        Try
            MDURow.ACOMETIDA = ACOMETIDATextBox.Text
        Catch ex As Exception
            MsgBox("SE HA MODIFICADO SIN LA ACOMETIDA")

        End Try
        MDURow.MODIFICADO = MODIFICADODateTimePicker.Value
        MDUTableAdapter.Update(EdificioDataSetBACK.MDU)
        NOTIFICACION("SYS", "Edificio actualizado")
        PintarMDU()
    End Sub

    Private Sub MDU_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PintarMDU()
    End Sub
    Private Sub PintarMDU()
        If DGV_MDU.Rows.Count > 0 Then
            For i = 0 To DGV_MDU.Rows.Count - 1
                If IsDBNull(DGV_MDU.Rows(i).Cells(3).Value) Then
                    DGV_MDU.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                    DGV_MDU.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
    End Sub
    Private Sub BTN_AGREGAR_MDU_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_MDU.Click
        MDURow = EDIFICIODataSet.MDU.NewMDURow()
        MDURow.ID_CALLE = ID_CALLETextBox.Text
        MDURow.PUERTA = PUERTATextBox.Text
        MDURow.APTOS = APTOSTextBox.Text
        MDURow.PISOS = PISOSTextBox.Text
        Try
            MDURow.TORRE = TORRETextBox.Text
        Catch ex As Exception
            MsgBox("complete la torre")
            Exit Sub
        End Try
        MDURow.NODO = NODOTextBox.Text
        MDURow.ZONA = ZONATextBox.Text
        MDURow.INGRESO = CB_INGRESO.Text
        MDURow.ID_STATUS = 1
        Try
            MDURow.CARPETA = CARPETATextBox.Text
        Catch ex As Exception
            MsgBox("Complete CARPETA")
            Exit Sub
        End Try
        Try
            MDURow.ACOMETIDA = ACOMETIDATextBox.Text
        Catch ex As Exception
        End Try

        MDURow.MODIFICADO = MODIFICADODateTimePicker.Value

        EDIFICIODataSet.MDU.AddMDURow(MDURow)
        MDUTableAdapter.Update(MDURow)
        NOTIFICACION("SYS", "SE HA INGRESADO EDIFICIO")
    End Sub

    Private Sub BTN_AGREGAR_FTTB_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_FTTB.Click
        FTTBRow = EDIFICIODataSet.FTTB.NewFTTBRow()
        FTTBRow.ID_EDIFICIO = MDURow.ID_MDU
        FTTBRow.CONEXION_DESDE = TXT_CONEXION_DESDE.Text
        FTTBRow.TIPO_CONEXION_DESDE = CB_TIPO.Text
        If CAJA_DISTRIBUCIONTextBox.Text <> "" Then FTTBRow.CAJA_DISTRIBUCION = CAJA_DISTRIBUCIONTextBox.Text
        FTTBRow.CABLE = CB_CABLE.Text
        FTTBRow.NAP = CB_TIPO_NAP.Text
        FTTBRow.NAP_NRO = NAP_NROTextBox.Text
        FTTBRow.TUBO = NAP_TUBO.Text
        FTTBRow.PELO = NAP_PELO.Text
        FTTBRow.OBS_TEC = OBS_TECTextBox.Text
        FTTBRow.ACOMETIDA = TXT_ACOMETIDA.Text
        FTTBRow.SPL_NRO = NAP_SPL.Text
        EDIFICIODataSet.FTTB.AddFTTBRow(FTTBRow)
        FTTBTableAdapter.Update(EDIFICIODataSet.FTTB)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDURow.ID_MDU)
        NOTIFICACION("SYS", "REGISTRO FTTB AGREGADO")

    End Sub

    Private Sub PINTAR_FTTB(ByVal COLUMNA As Integer)

        For X = 0 To FTTBDataGridView.Rows.Count - 1
            FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.ForeColor = Color.White
            '  FTTBDataGridView.Rows(X).Cells(COLUMNA).Style = New Font(FontStyle.Bold)
            Select Case FTTBDataGridView.Rows(X).Cells(COLUMNA).Value
                Case "AZUL"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Blue
                Case "NARANJA"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Orange
                Case "VERDE"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Green
                Case "MARRON"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Brown
                Case "GRIS"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.DarkGray
                Case "BLANCO"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.White
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.ForeColor = Color.Black
                Case "ROJO"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Red
                Case "NEGRO"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Black
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.ForeColor = Color.White
                Case "AMARILLO"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Yellow
                Case "VIOLETA"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Purple
                Case "ROSADO"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.Pink
                Case "CELESTE"
                    FTTBDataGridView.Rows(X).Cells(COLUMNA).Style.BackColor = Color.LightSkyBlue

            End Select

        Next

    End Sub

    Private Sub ACTUALIZAR_FTTB()
        If FTTBDataGridView.Rows.Count > 0 Then
            FTTBTableAdapter.FillByID(EdificioDataSetBACK.FTTB, FTTBDataGridView.CurrentRow.Cells(0).Value)
            FTTBRow = EdificioDataSetBACK.FTTB.Rows(0)
            If FTTBRow.IsCONEXION_DESDENull Then TXT_CONEXION_DESDE.Text = "N/A" Else TXT_CONEXION_DESDE.Text = FTTBRow.CONEXION_DESDE
            CB_TIPO.Text = FTTBRow.TIPO_CONEXION_DESDE
            If FTTBRow.IsCAJA_DISTRIBUCIONNull Then CAJA_DISTRIBUCIONTextBox.Text = "" Else CAJA_DISTRIBUCIONTextBox.Text = FTTBRow.CAJA_DISTRIBUCION
            CB_CABLE.Text = FTTBRow.CABLE
            CB_TIPO_NAP.Text = FTTBRow.NAP
            NAP_NROTextBox.Text = FTTBRow.NAP_NRO
            NAP_TUBO.Text = FTTBRow.TUBO
            NAP_PELO.Text = FTTBRow.PELO
            If FTTBRow.IsOBS_TECNull Then OBS_TECTextBox.Text = "" Else OBS_TECTextBox.Text = FTTBRow.OBS_TEC
            NAP_SPL.Text = FTTBRow.SPL_NRO
            PINTAR_FTTB(6)
            PINTAR_FTTB(7)
        Else
            TXT_CONEXION_DESDE.Text = ""
            CAJA_DISTRIBUCIONTextBox.Text = ""
            CB_TIPO_NAP.Text = ""
            NAP_NROTextBox.Text = ""
            NAP_TUBO.Text = "AZUL"
            NAP_PELO.Text = "AZUL"
            OBS_TECTextBox.Text = ""
        End If
    End Sub

    Private Sub TXT_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CALLE.TextChanged
        BUSCA_TIPO()
    End Sub

    Private Sub TXT_NRO_TextChanged(sender As Object, e As EventArgs) Handles TXT_NRO.TextChanged
        BUSCA_TIPO()
    End Sub

    Private Sub FTTBDataGridView_Click(sender As Object, e As EventArgs) Handles FTTBDataGridView.Click
        ACTUALIZAR_FTTB()
    End Sub


End Class