
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
    Dim CABLEint As Integer
    Dim NAPint As Integer
    Dim TUBOint As Integer
    Dim PELOint As Integer
    Dim TIPOCONDESDE As Integer
    Private Sub MDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CABLESTableAdapter.Fill(EDIFICIODataSet.CABLES)
        CB_CABLE.Items.Clear()
        For Each CABLES In EDIFICIODataSet.CABLES
            CB_CABLE.Items.Add(CABLES.MODELO)
        Next

        ARTICULOTableAdapter.Fill(EDIFICIODataSet.ARTICULO)
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

        COLORESTableAdapter.Fill(EDIFICIODataSet.COLORES)
        NAP_TUBO.Items.Clear()
        NAP_PELO.Items.Clear()
        For Each COLORES In EDIFICIODataSet.COLORES
            NAP_TUBO.Items.Add(COLORES.COLOR)
            NAP_PELO.Items.Add(COLORES.COLOR)
        Next


        MDUTableAdapter.FillBynodo(EDIFICIODataSet.MDU, INICIO.CBNODO.Text)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU"))
    End Sub
    Private Sub BtnGuardarFttb_Click(sender As Object, e As EventArgs) Handles btnGuardarFttb.Click
        'FTTBRow.CONEXION_DESDE = CInt(TXT_CONEXION_DESDE.Text)
        'If CAJA_DISTRIBUCIONTextBox.Text <> "" Then FTTBRow.CAJA_DISTRIBUCION = CInt(CAJA_DISTRIBUCIONTextBox.Text)
        VERIFICACIONES()
        'FTTBRow.OBS_TEC = OBS_TECTextBox.Text
        'FTTBRow.ACOMETIDA = CInt(TXT_ACOMETIDA.Text)
        'FTTBRow.SPL_NRO = CInt(NAP_SPL.Text)

        Dim SQL = "UPDATE FTTB SET CONEXION_DESDE=" & TXT_CONEXION_DESDE.Text & ", CAJA_DISTRIBUCION=" & CAJA_DISTRIBUCIONTextBox.Text & ", CABLE=" & CABLEint & ", NAP=" & NAPint & ",TIPO_CONEXION_DESDE=" & TIPOCONDESDE & ", NAP_NRO=" & NAP_NROTextBox.Text & ", TUBO=" & TUBOint & ", PELO=" & PELOint & ",OBS_TEC='" & OBS_TECTextBox.Text & "', ACOMETIDA=" & TXT_ACOMETIDA.Text & ",SPL_NRO=" & NAP_SPL.Text & " WHERE ID_FTTB=" & FTTBRow.ID_FTTB & ";"
        'FTTBTableAdapter.Update(FTTBRow)
        'FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDURow.ID_MDU)
        Try
            ExecuteNonQuery("EDIFICIO", SQL)
            NOTIFICACION("SYS", "registro FTTB actualizado")
            ACTUALIZAR_FTTB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub VERIFICACIONES()

        For Each cable In EDIFICIODataSet.CABLES
            If cable.MODELO = CB_CABLE.Text Then
                FTTBRow.CABLE = cable.ID_CABLE
                CABLEint = cable.ID_CABLE
                Exit For
            End If
        Next
        For Each Naps In EDIFICIODataSet.ARTICULO
            If Naps.NOMBRE = CB_TIPO_NAP.Text Then
                FTTBRow.NAP = Naps.ID_ARTICULO
                NAPint = Naps.ID_ARTICULO
                Exit For
            End If
        Next
        For Each UNACAJA In EDIFICIODataSet.ARTICULO
            If UNACAJA.NOMBRE = CB_TIPO.Text Then
                FTTBRow.TIPO_CONEXION_DESDE = UNACAJA.ID_ARTICULO
                TIPOCONDESDE = UNACAJA.ID_ARTICULO
            End If
        Next
        For Each TUBO In EDIFICIODataSet.COLORES
            If TUBO.COLOR = NAP_TUBO.Text Then
                FTTBRow.TUBO = TUBO.ID_COLOR
                TUBOint = TUBO.ID_COLOR
                Exit For
            End If
        Next
        For Each PELOS In EDIFICIODataSet.COLORES
            If PELOS.COLOR = NAP_PELO.Text Then
                FTTBRow.PELO = PELOS.ID_COLOR
                PELOint = PELOS.ID_COLOR
                Exit For
            End If
        Next
    End Sub
    Private Sub DGV_MDU_Click(sender As Object, e As EventArgs) Handles DGV_MDU.Click
        Cursor = Cursors.WaitCursor

        MDURow = EDIFICIODataSet.MDU.FindByID_MDU(DGV_MDU.CurrentRow.Cells(4).Value)
        NOTIFICACION("SYS", "SELECCION DE " & MDURow.CARPETA)
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
            TXT_ACOMETIDA.Text = ""
        Else
            ACOMETIDATextBox.Text = MDURow.ACOMETIDA
            TXT_ACOMETIDA.Text = MDURow.ACOMETIDA
        End If
        If MDURow.IsORDENNull Then TXT_ORDEN.Text = "1" Else TXT_ORDEN.Text = MDURow.ORDEN
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
        Try
            If ID_CALLETextBox.Text = "" Then Throw New Exception("COMPLETE CALLE")
            If PUERTATextBox.Text = "" Then Throw New Exception("COMPLETE PUERTA")
            If APTOSTextBox.Text = "" Then Throw New Exception("COMPLETE APTOS")
            If PISOSTextBox.Text = "" Then Throw New Exception("COMPLETE PISOS")
            If TORRETextBox.Text = "" Then Throw New Exception("COMPLETE TORRE")
            If NODOTextBox.Text = "" Then Throw New Exception("COMPLETE NODO")
            If ZONATextBox.Text = "" Then Throw New Exception("COMPLETE ZONA")
            If CB_INGRESO.Text = "" Then Throw New Exception("COMPLETE INGRESO")
            If TXT_ORDEN.Text = "" Then Throw New Exception("COMPLETE EL ORDEN DE EJECUCION DEL EDIFICIO, POR DEFECTO ES 1")
            If ACOMETIDATextBox.Text = "" Then MsgBox("SE GUARDARA CAMBIOS SIN ACOMETIDA")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "SGE")
            Exit Sub
        End Try

        Dim SQL As String
        If ACOMETIDATextBox.Text = "" Then
            SQL = "UPDATE MDU SET PUERTA='" & PUERTATextBox.Text & "', APTOS=" & APTOSTextBox.Text & ", PISOS=" & PISOSTextBox.Text & ", TORRE=" & TORRETextBox.Text & ", NODO='" & NODOTextBox.Text & "', ORDEN=" & TXT_ORDEN.Text & ", ZONA=" & ZONATextBox.Text & ", INGRESO='" & CB_INGRESO.Text & "', MODIFICADO='" & MODIFICADODateTimePicker.Value & "' WHERE ID_MDU=" & MDURow.ID_MDU & ";"
        Else
            SQL = "UPDATE MDU SET PUERTA='" & PUERTATextBox.Text & "', APTOS=" & APTOSTextBox.Text & ", PISOS=" & PISOSTextBox.Text & ", TORRE=" & TORRETextBox.Text & ", NODO='" & NODOTextBox.Text & "', ORDEN=" & TXT_ORDEN.Text & ", ZONA=" & ZONATextBox.Text & ", ACOMETIDA=" & ACOMETIDATextBox.Text & ", INGRESO='" & CB_INGRESO.Text & "', MODIFICADO='" & MODIFICADODateTimePicker.Value & "' WHERE ID_MDU=" & MDURow.ID_MDU & ";"
        End If
        Try
            ExecuteNonQuery("EDIFICIO", SQL)
            NOTIFICACION("SYS", "Edificio actualizado")
            'MDUTableAdapter.FillBynodo(EDIFICIODataSet.MDU, INICIO.CBNODO.Text)
            'FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU"))
            PintarMDU()
            ACTUALIZAR_FTTB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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
        Dim SQL As String
        Try
            If ID_CALLETextBox.Text = "" Then Throw New Exception("COMPLETE ID CALLE")
            If PUERTATextBox.Text = "" Then Throw New Exception("COMPLETE EL NUMERO DE PUERTA")
            If APTOSTextBox.Text = "" Then Throw New Exception("COMPLETE LA CANTIDAD DE APTOS")
            If PISOSTextBox.Text = "" Then Throw New Exception("COMPLETE LA CANTIDAD DE PISOS")
            If TORRETextBox.Text = "" Then Throw New Exception("COMPLETE LA CANTIDAD DE TORRES")
            If NODOTextBox.Text = "" Then Throw New Exception("COMPLETE EL NODO")
            If ZONATextBox.Text = "" Then Throw New Exception("COMPLETE LA ZONA")
            If CARPETATextBox.Text = "" Then Throw New Exception("COMPLETE EL NUMERO DE CARPETA")
            If ACOMETIDATextBox.Text = "" Then Throw New Exception("COMPLETE EL NUMERO DE ACOMETIDA")
            If CB_INGRESO.Text = "" Then Throw New Exception("COMPLETE EL TIPO DE INGRESO")
            If TXT_ORDEN.Text = "" Then Throw New Exception("COMPLETE EL ORDEN DE EJECUCION, POR DEFECTO ES 1")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        SQL = "INSERT INTO MDU (CARPETA, ID_CALLE, PUERTA, APTOS, PISOS, TORRE, NODO, ZONA, ACOMETIDA, INGRESO, ID_STATUS, ORDEN, MODIFICADO) VALUES (" & CARPETATextBox.Text & ", " & ID_CALLETextBox.Text & ", '" & PUERTATextBox.Text & "'," & APTOSTextBox.Text & "," & PISOSTextBox.Text & "," & TORRETextBox.Text & ",'" & NODOTextBox.Text & "'," & ZONATextBox.Text & "," & ACOMETIDATextBox.Text & ",'" & CB_INGRESO.Text & "'," & 1 & "," & TXT_ORDEN.Text & ", '" & MODIFICADODateTimePicker.Value & "')"
        ' EDIFICIODataSet.MDU.AddMDURow(MDURow)

        ExecuteNonQuery("EDIFICIO", SQL)
        ' MDUTableAdapter.Update(MDURow)


        NOTIFICACION("SYS", "SE HA INGRESADO EDIFICIO")
    End Sub

    Private Sub BTN_AGREGAR_FTTB_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_FTTB.Click
        FTTBRow = EDIFICIODataSet.FTTB.NewFTTBRow()
        FTTBRow.ID_EDIFICIO = MDURow.ID_MDU
        If CAJA_DISTRIBUCIONTextBox.Text <> "" Then FTTBRow.CAJA_DISTRIBUCION = CAJA_DISTRIBUCIONTextBox.Text
        FTTBRow.CONEXION_DESDE = TXT_CONEXION_DESDE.Text
        FTTBRow.NAP_NRO = NAP_NROTextBox.Text
        FTTBRow.OBS_TEC = OBS_TECTextBox.Text
        FTTBRow.ACOMETIDA = CInt(TXT_ACOMETIDA.Text)
        FTTBRow.SPL_NRO = NAP_SPL.Text
        VERIFICACIONES()
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