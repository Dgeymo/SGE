Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Module FUNCIONES
    Public ACCION_AGENDA As String
    Dim MDURow As EDIFICIODataSet.MDURow
    Dim FTTBRow As EDIFICIODataSet.FTTBRow
    Dim CERTRow As EDIFICIODataSet.CERTIFICACIONESRow
    Dim DT As DataTable

    Public Sub ACTUALIZAR_INFO_MDU(NODO As String, Optional TODOS As String = Nothing)
        INICIO.EDIFICIODataSet.EDIF_VISTA.Clear()
        Dim RESULTADO As OleDbDataReader = ExecuteQuery("EDIFICIO", EDIFICIO_NODO & Trim(NODO) & "'")
        DT = New DataTable
        DT.Load(RESULTADO)
        INICIO.lbl_nodo.Text = NODO.ToUpper
        If TODOS IsNot Nothing Then
            For Each Row In DT.Rows
                AGREGAR(Row)
            Next
        Else
            INICIO.AVANCETableAdapter.FillByHABILITADOS(INICIO.EDIFICIODataSet.AVANCE, Trim(NODO))
            INICIO.EDIFICIODataSet.EDIF_VISTA.Clear()

            For Each Row In DT.Rows
                For Each AVANCE In INICIO.EDIFICIODataSet.AVANCE
                    ' MsgBox(AVANCE.NODO)
                    If AVANCE.ZONA = CInt(Row("ZONA")) And IsDBNull(Row("INGRESO")) = False Then
                        If AVANCE.VER_SUBTERRANEO And Row("INGRESO") = "SUBTERRANEO" Then
                            AGREGAR(Row)
                        ElseIf AVANCE.VER_DUCTOS_FECHADA And Row("INGRESO") = "DUCTO" Then
                            AGREGAR(Row)
                        ElseIf AVANCE.VER_AEREOS And Row("INGRESO") = "AEREO" Then
                            AGREGAR(Row)
                        End If
                    End If
                Next
                If IsDBNull(Row("INGRESO")) And SECTOR = "PLANIFICACION TECNICA" Then
                    AGREGAR(Row)
                End If
            Next
        End If
        marcarVencidos()
        INICIO.AVANCETableAdapter.FillByNODO(INICIO.EDIFICIODataSet.AVANCE, Trim(NODO))
        INICIO.LBL_CANT_ROWS.Text = "MOSTRANDO: " & INICIO.EDIF_VISTABindingSource.Count & " EDIFICIOS"
    End Sub
    Public Sub marcarVencidos()
        If INICIO.DGV_EDIFICIOS.Rows.Count > 0 Then
            For i = 0 To INICIO.DGV_EDIFICIOS.Rows.Count - 1
                If IsDBNull(INICIO.DGV_EDIFICIOS.Rows(i).Cells(7).Value) = False Then
                    If CDate(INICIO.DGV_EDIFICIOS.Rows(i).Cells(7).Value) < Today Then
                        INICIO.DGV_EDIFICIOS.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                    Else
                        INICIO.DGV_EDIFICIOS.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            Next
        End If
    End Sub
    Private Function ARMAR_NAP(ByVal NUMERO As Object, ByVal TIPO_DISTRO As String, ByVal DIST_ACO As Object, ByVal NODO As String, ByVal ZONA As Object) As String
        Dim EQUIPO As String
        Dim ACOMETIDASTR As String
        Dim NAPSTR As String
        Dim ZONASTR As String

        EQUIPO = "NAP"


        If IsDBNull(NUMERO) Then
            NAPSTR = "s/d"
        Else
            NAPSTR = NUMERO.ToString()
            If NAPSTR < 10 Then NAPSTR = "0" & NAPSTR
        End If
        EQUIPO += NAPSTR & "-" & TIPO_DISTRO


        If IsDBNull(DIST_ACO) Then
            ACOMETIDASTR = "s/d"
        Else
            ACOMETIDASTR = DIST_ACO.ToString()
            If ACOMETIDASTR < 10 Then ACOMETIDASTR = "0" & ACOMETIDASTR
        End If
        EQUIPO += ACOMETIDASTR & "-" & NODO



        If IsDBNull(ZONA) Then
            ZONASTR = "s/d"
        Else
            ZONASTR = ZONA.ToString()
            If ZONASTR < 10 Then ZONASTR = "0" & ZONASTR
        End If
        EQUIPO += ZONASTR

        Return EQUIPO
    End Function
    Private Sub AGREGAR(ByVal dataRow As DataRow)
        INICIO.VER_EDIFICIO = INICIO.EDIFICIODataSet.EDIF_VISTA.NewEDIF_VISTARow()
        INICIO.VER_EDIFICIO.ID_EDIFICIO = dataRow("ID_MDU")
        INICIO.VER_EDIFICIO.NODO = dataRow("NODO")
        INICIO.VER_EDIFICIO.ZONA = dataRow("ZONA")
        INICIO.VER_EDIFICIO.CALLE = dataRow("CALLE")
        INICIO.VER_EDIFICIO.PUERTA = dataRow("PUERTA")
        If IsDBNull(dataRow("INGRESO")) Then INICIO.VER_EDIFICIO.INGRESO = "N/A" Else INICIO.VER_EDIFICIO.INGRESO = dataRow("INGRESO")
        If IsDBNull(dataRow("ACOMETIDA")) Then INICIO.VER_EDIFICIO.ACOMETIDA = "N/A" Else INICIO.VER_EDIFICIO.ACOMETIDA = dataRow("ACOMETIDA")
        INICIO.VER_EDIFICIO.STATUS = dataRow("STATUS")
        If dataRow("ID_STATUS") = 2 Or dataRow("ID_STATUS") = 5 Then
            INICIO.AGENDATableAdapter.FillByID_EDIFICIO(INICIO.EDIFICIODataSet.AGENDA, CInt(dataRow("ID_MDU")))
            If INICIO.EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
                INICIO.VER_EDIFICIO.AGENDADO = INICIO.EDIFICIODataSet.AGENDA.Rows(INICIO.EDIFICIODataSet.AGENDA.Rows.Count - 1).Item("DIA_AGENDA")
            End If
        End If
        INICIO.EDIFICIODataSet.EDIF_VISTA.AddEDIF_VISTARow(INICIO.VER_EDIFICIO)
    End Sub

    Public Sub CARGARDESDEEXCEL(path As String)
        INICIO.COLORESTableAdapter.Fill(INICIO.EDIFICIODataSet.COLORES)
        INICIO.ARTICULOTableAdapter.Fill(INICIO.EDIFICIODataSet.ARTICULO)
        INICIO.EDIFICIODataSet.MDU.Clear()
        INICIO.Cursor = Cursors.WaitCursor
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        oLibro = oExcel.Workbooks.Open(path)
        oHoja = oLibro.Sheets(oLibro.Worksheets.Item(1).NAME)
        Dim CALLE As String = "CALLE"
        Dim REGISTRO As Integer = 4
        Dim INGRESO As String = String.Empty
        Dim ZONA As String
        Dim TUBO As String
        Dim PELO As String
        Dim PUERTA As String
        Dim TORRE As Integer
        Dim APTOS As String
        Dim PISOS As String
        Dim CARPETA As Integer
        Dim NAP As String
        Dim MDURow As EDIFICIODataSet.MDURow
        Dim ACOMETIDA As Integer
        Dim NEWFTTBRow As EDIFICIODataSet.FTTBRow
        While CALLE <> ""
            REGISTRO += 1
            ZONA = oHoja.Cells(REGISTRO, 3).text
            CALLE = Trim(oHoja.Cells(REGISTRO, 5).value)
            PUERTA = oHoja.Cells(REGISTRO, 6).value
            CARPETA = Trim(oHoja.Cells(REGISTRO, 1).value)
            If ZONA < 15 Then

                INICIO.MDUTableAdapter.FillByCARPETA(INICIO.EDIFICIODataSet.MDU, CARPETA)

                'If INICIO.EDIFICIODataSet.MDU.Rows.Count = 0 Then
                '    INICIO.MDUTableAdapter.FillByNOMBRECALLEyPUERTA(INICIO.EDIFICIODataSet.MDU, CALLE, PUERTA)
                'End If
                'If INICIO.EDIFICIODataSet.MDU.Rows.Count = 0 Then
                '    Try
                '        CALLE = CALLE(0)
                '        PUERTA = CALLE(1)
                '        INICIO.MDUTableAdapter.FillByNOMBRECALLEyPUERTA(INICIO.EDIFICIODataSet.MDU, CALLE, PUERTA)
                '    Catch ex As Exception
                '    End Try
                'End If
                ACOMETIDA = CInt(oHoja.Cells(REGISTRO, 26).value)
                INICIO.LBL_CANT_ROWS.Text = "TRABAJANDO EN.. " & REGISTRO & " - " & CALLE & " " & PUERTA
                INICIO.LBL_CANT_ROWS.Refresh()

                If INICIO.EDIFICIODataSet.MDU.Rows.Count > 0 And ACOMETIDA <> 0 Then
                    MDURow = INICIO.EDIFICIODataSet.MDU.Rows(0)
                    'APTOS = oHoja.Cells(REGISTRO, 8).value
                    'PISOS = oHoja.Cells(REGISTRO, 9).value
                    'If oHoja.Cells(REGISTRO, 13).value = "SI" Then INGRESO = "AEREO"
                    'If oHoja.Cells(REGISTRO, 14).value = "SI" Then INGRESO = "SUBTERRANEO"
                    'If oHoja.Cells(REGISTRO, 15).value = "SI" Then INGRESO = "DUCTO"
                    'Try
                    '    TORRE = oHoja.Cells(REGISTRO, 10).value
                    '    If TORRE = 0 Then TORRE = 1
                    'Catch ex As Exception
                    '    TORRE = 1
                    'End Try
                    TUBO = Trim(oHoja.Cells(REGISTRO, 22).value)
                    PELO = Trim(oHoja.Cells(REGISTRO, 23).value)
                    For Each TUBOS In INICIO.EDIFICIODataSet.COLORES
                        If TUBOS.COLOR = TUBO Then
                            TUBO = TUBOS.ID_COLOR
                            Exit For
                        End If
                    Next
                    For Each PELOS In INICIO.EDIFICIODataSet.COLORES
                        If PELOS.COLOR = PELO Then
                            PELO = PELOS.ID_COLOR
                            Exit For
                        End If
                    Next
                    INICIO.FTTBTableAdapter.FillByEDIFICIO_TUBO_PELO(INICIO.EDIFICIODataSet.FTTB, MDURow.ID_MDU, TUBO, PELO)

                    If INICIO.EDIFICIODataSet.FTTB.Rows.Count > 0 Then
                        FTTBRow = INICIO.EDIFICIODataSet.FTTB.Rows(0)

                        If FTTBRow.IsCAJA_DISTRIBUCIONNull And FTTBRow.TIPO_CONEXION_DESDE <> 2 Then

                            FTTBRow.CAJA_DISTRIBUCION = oHoja.Cells(REGISTRO, 20).value
                            INICIO.FTTBTableAdapter.Update(FTTBRow)

                        End If
                        'If INICIO.EDIFICIODataSet.FTTB.Rows.Count = 0 Then
                        '    NEWFTTBRow = INICIO.EDIFICIODataSet.FTTB.NewFTTBRow
                        '    NEWFTTBRow.ID_EDIFICIO = MDURow.ID_MDU
                        '    NEWFTTBRow.ACOMETIDA = ACOMETIDA
                        '    NEWFTTBRow.CABLE = 1
                        '    For Each CAJAS In INICIO.EDIFICIODataSet.ARTICULO
                        '        If CAJAS.NOMBRE = Trim(oHoja.Cells(REGISTRO, 16).value) Then
                        '            NEWFTTBRow.TIPO_CONEXION_DESDE = CAJAS.ID_ARTICULO
                        '            Exit For
                        '        End If
                        '    Next

                        '    NEWFTTBRow.CONEXION_DESDE = oHoja.Cells(REGISTRO, 17).value

                        '    If NEWFTTBRow.TIPO_CONEXION_DESDE <> 2 Then
                        '        If oHoja.Cells(REGISTRO, 19).value Is Nothing Then
                        '        Else
                        '            NEWFTTBRow.CAJA_DISTRIBUCION = oHoja.Cells(REGISTRO, 19).value
                        '        End If
                        '    End If

                        '    NEWFTTBRow.TUBO = TUBO
                        '    NEWFTTBRow.PELO = PELO
                        '    NEWFTTBRow.SPL_NRO = 1
                        '    NEWFTTBRow.NAP_NRO = oHoja.Cells(REGISTRO, 24).value
                        '    NAP = oHoja.Cells(REGISTRO, 25).value
                        '    Select Case NAP
                        '        Case 8
                        '            NEWFTTBRow.NAP = 4
                        '        Case 16
                        '            NEWFTTBRow.NAP = 3
                        '        Case 4
                        '            NEWFTTBRow.NAP = 5
                        '    End Select
                        '    NEWFTTBRow.OBS_TEC = oHoja.Cells(REGISTRO, 32).value
                        '    If TUBO = 1 And PELO = 2 Then
                        '        If NEWFTTBRow.NAP_NRO = 2 Then
                        '            NEWFTTBRow.SPL_NRO = 1
                        '        Else
                        '            NEWFTTBRow.SPL_NRO = 2
                        '        End If
                        '    End If
                        '    Try
                        '        INICIO.EDIFICIODataSet.FTTB.AddFTTBRow(NEWFTTBRow)
                        '        INICIO.FTTBTableAdapter.Update(NEWFTTBRow)
                        '        ' MsgBox("AGREGUE FTTB " & MDURow.CALLE & " " & MDURow.PUERTA)
                        '    Catch ex As Exception
                        '        MsgBox(ex.Message)
                        '    End Try

                        'End If
                        'If APTOS <> Nothing And PISOS <> Nothing And TORRE <> Nothing And INGRESO <> Nothing And ACOMETIDA <> Nothing And MDURow.IsACOMETIDANull Then

                        'Dim SQL As String = "UPDATE MDU SET 
                        '                    APTOS = " & APTOS & ",
                        '                    PISOS = " & PISOS & ",
                        '                    TORRE = " & TORRE & ",
                        '                    INGRESO = '" & INGRESO & "',
                        '                    ACOMETIDA = " & ACOMETIDA & " 
                        '                    WHERE ID_MDU = " & MDURow.ID_MDU
                        'Try
                        '    ExecuteNonQuery("EDIFICIO", SQL)
                        '    'MsgBox("MODIFICQUE " & MDURow.ACOMETIDA)
                        'Catch ex As Exception
                        '    MsgBox(SQL)
                        'End Try
                    End If
                Else
                    '    MsgBox("NO SE ECONTRO: " & CALLE & " " & PUERTA)
                End If
            End If
        End While

        oLibro.Close()
        oExcel.Quit()
        INICIO.Cursor = Cursors.Default

    End Sub
    Public Sub CargarCertExcel(fileName As String)
        INICIO.Cursor = Cursors.WaitCursor
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        oLibro = oExcel.Workbooks.Open(fileName)
        INICIO.MDUTableAdapter.Fill(INICIO.EdificioDataSetBackUp.MDU)

        Dim nroNap As String
        Dim nroAcometida As String
        Dim nroZona As String
        Dim nodo As String

        For x = 0 To INICIO.EdificioDataSetBackUp.MDU.Rows.Count - 1
            MDURow = INICIO.EdificioDataSetBackUp.MDU.Rows(x)
            INICIO.FTTBTableAdapter.FillByID_EDIFICIO(INICIO.EdificioDataSetBackUp.FTTB, MDURow.ID_MDU)
            If INICIO.EdificioDataSetBackUp.FTTB.Rows.Count > 0 Then
                nodo = MDURow.NODO
                nroZona = MDURow.ZONA
                If nroZona < 10 Then nroZona = "0" & nroZona
                Dim HOJA As String = nodo & nroZona
                Dim ENCONTRADO = False
                For H = 1 To 35
                    Try
                        If oLibro.Sheets(H).NAME = HOJA Then
                            oHoja = oLibro.Sheets(H)
                            ENCONTRADO = True
                            Exit For
                        End If
                    Catch eS As Exception
                    End Try
                Next
                If ENCONTRADO = False Then Continue For
                Try
                    Dim CONTADOR As Integer = 1
                    Dim NAP As String = "1"
                    Try
                        While NAP <> ""
                            CONTADOR += 1
                            NAP = oHoja.Cells(CONTADOR, 8).Value
                            If NAP = "" Then Continue While
                            For e = 0 To INICIO.EdificioDataSetBackUp.FTTB.Rows.Count - 1
                                FTTBRow = INICIO.EdificioDataSetBackUp.FTTB.Rows(e)
                                nroNap = FTTBRow.NAP_NRO
                                If CInt(nroNap) < 10 Then nroNap = "0" & nroNap
                                nroAcometida = FTTBRow.ACOMETIDA
                                If CInt(nroAcometida) < 10 Then nroAcometida = "0" & nroAcometida
                                If Trim(NAP) = "NAP" & nroNap & "-A" & nroAcometida & "-" & nodo & nroZona Then
                                    CERTRow = INICIO.EDIFICIODataSet.CERTIFICACIONES.NewCERTIFICACIONESRow
                                    CERTRow.FTTB_ID = FTTBRow.ID_FTTB
                                    If IsDBNull(oHoja.Cells(CONTADOR, 9).Value) = False Then CERTRow.BOCA1 = oHoja.Cells(CONTADOR, 9).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 10).Value) = False Then CERTRow.BOCA2 = oHoja.Cells(CONTADOR, 10).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 11).Value) = False Then CERTRow.BOCA3 = oHoja.Cells(CONTADOR, 11).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 12).Value) = False Then CERTRow.BOCA4 = oHoja.Cells(CONTADOR, 12).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 13).Value) = False Then CERTRow.BOCA5 = oHoja.Cells(CONTADOR, 13).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 14).Value) = False Then CERTRow.BOCA6 = oHoja.Cells(CONTADOR, 14).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 15).Value) = False Then CERTRow.BOCA7 = oHoja.Cells(CONTADOR, 15).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 16).Value) = False Then CERTRow.BOCA8 = oHoja.Cells(CONTADOR, 16).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 17).Value) = False Then CERTRow.BOCA9 = oHoja.Cells(CONTADOR, 17).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 18).Value) = False Then CERTRow.BOCA10 = oHoja.Cells(CONTADOR, 18).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 19).Value) = False Then CERTRow.BOCA11 = oHoja.Cells(CONTADOR, 19).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 20).Value) = False Then CERTRow.BOCA12 = oHoja.Cells(CONTADOR, 20).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 21).Value) = False Then CERTRow.BOCA13 = oHoja.Cells(CONTADOR, 21).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 22).Value) = False Then CERTRow.BOCA14 = oHoja.Cells(CONTADOR, 22).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 23).Value) = False Then CERTRow.BOCA15 = oHoja.Cells(CONTADOR, 23).Value
                                    If IsDBNull(oHoja.Cells(CONTADOR, 24).Value) = False Then CERTRow.BOCA16 = oHoja.Cells(CONTADOR, 24).Value
                                    CERTRow.LONGITUD = Split(oHoja.Cells(CONTADOR, 25).Value, ",")(0)
                                    CERTRow.LATITUD = Split(oHoja.Cells(CONTADOR, 25).Value, ",")(1)
                                    INICIO.EDIFICIODataSet.CERTIFICACIONES.AddCERTIFICACIONESRow(CERTRow)
                                    INICIO.CERTIFICACIONESTableAdapter.Update(INICIO.EDIFICIODataSet.CERTIFICACIONES)
                                End If
                            Next
                        End While
                    Catch ex As Exception
                        MsgBox("La Hoja no tiene los datos correctos" & ex.Message)
                    End Try
                Catch eY As Exception
                    MsgBox("No exite la Hoja " & eY.Message)
                End Try
            End If
        Next
        oLibro.Close()
        oExcel.Quit()
        INICIO.Cursor = Cursors.Default
    End Sub
    Public Sub REFRESCAR_TRONCALES(filename As String)
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        INICIO.Cursor = Cursors.WaitCursor
        Dim FIBRARow As FIBRADataSet.TRONCALESRow
        Dim ColA As Integer = 1
        Dim ColB As Integer = 2
        Dim ColC As Integer = 3
        Dim ColSALIDAS_h As Integer = 8
        Dim ColCAJA As Integer = 9
        Dim ColILUMINADO_q As Integer = 17
        Dim ColR As Integer = 18
        Dim ColS As Integer = 19
        Dim ColT As Integer = 20
        Dim ColU As Integer = 21
        Dim ColPADRE_w As Integer = 23
        Dim ColX As Integer = 24
        Dim ColBANDEJA_OLT_y As Integer = 25
        Dim ColPUERTO_PON_z As Integer = 26
        Dim CONTADOR As Integer = 2
        Dim CAJA As String
        Dim CAJA_PRIMERA As String
        Dim BANDEJA As Integer
        Dim PUERTOPON As Integer
        Dim OLT As String
        Dim ODF As String
        Dim SPLSEGUNDA As String
        Dim HUB As String
        Dim SPL As String
        ' Try
        oLibro = oExcel.Workbooks.Open(filename)
        oHoja = oLibro.Sheets(1)
        Dim HUERFANORow As FIBRADataSet.HuerfanosRow
        Dim ODFHUERFANORow As FIBRADataSet.odf_huerfanoRow
        ' PRIMERA VUELTA AL EXCEL, OBTENEMOS TODAS LAS NAPS
        While oHoja.Cells(CONTADOR, 1).Value <> ""
            CAJA = oHoja.Cells(CONTADOR, ColCAJA).Value
            Select Case Mid(CAJA, 1, 3)
                Case "NAP"
                    'POR CADA NAP SE CARGA UNA NUEVA LINEA (si no es SPL2)
                    SPLSEGUNDA = Trim(oHoja.Cells(CONTADOR, ColA).Value)
                    INICIO.TRONCALESTableAdapter.FillByCAJA_SEGUNDA(INICIO.FIBRADataSet.TRONCALES, CAJA)
                    If INICIO.FIBRADataSet.TRONCALES.Rows.Count > 0 Then
                        FIBRARow = INICIO.FIBRADataSet.TRONCALES.Rows(0)
                        If SPLSEGUNDA = "Splitter 2" And FIBRARow.SALIDA_SEGUNDA = 8 Then
                            FIBRARow.SALIDA_SEGUNDA = 16
                            Try
                                INICIO.TRONCALESTableAdapter.Update(FIBRARow)
                            Catch ex As DBConcurrencyException
                                INICIO.TRONCALESTableAdapter.Update(FIBRARow)
                            End Try

                        End If

                    Else 'si no hay nap, la crea
                        FIBRARow = INICIO.FIBRADataSet.TRONCALES.NewTRONCALESRow
                        Dim MAXIMO As Integer = INICIO.TRONCALESTableAdapter.ScalarQueryMAXIMO()
                        FIBRARow.ID = MAXIMO + 1

                        Try
                            FIBRARow.NODO = Mid(CAJA, 11, 1)
                            FIBRARow.ZONA = Mid(CAJA, 12)
                        Catch ex As Exception
                            MsgBox("EQUIPO MAL NOMBRADO: " & CAJA)
                            Exit Sub
                        End Try

                        'OLT
                        FIBRARow.OLT = oHoja.Cells(CONTADOR, ColPADRE_w).Value
                        If oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).Value.ToString() <> "" Then FIBRARow.PLACA_OLT = CDbl(oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).Value)

                        If oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value.ToString() <> "" And oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value.ToString() <> "N/A" Then FIBRARow.PUERTO_OLT = oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value

                        'PRIMER NIVEL SPLITEO
                        CAJA_PRIMERA = oHoja.Cells(CONTADOR, ColILUMINADO_q).Value

                        'FIBRARow.CAJA_PRIMERA = CAJA_PRIMERA
                        If Mid(CAJA_PRIMERA, 1, 3) = "CED" Or Mid(CAJA_PRIMERA, 1, 3) = "NAP" Then
                            FIBRARow.CAJA_CED_NAP = CAJA_PRIMERA
                        End If

                        ' FIBRARow.SPLITTER_PRIMERA = oHoja.Cells(CONTADOR, ColR).Value
                        If oHoja.Cells(CONTADOR, ColS).Value <> "" Then FIBRARow.SALIDAS_PRIMERA = Mid(oHoja.Cells(CONTADOR, ColS).Value, 3, 1)

                        'SEGUNDO NIVEL SPLITEO - LA NAP
                        FIBRARow.CAJA_SEGUNDA = CAJA
                        FIBRARow.SALIDA_SEGUNDA = oHoja.Cells(CONTADOR, ColSALIDAS_h).Value

                        INICIO.FIBRADataSet.TRONCALES.AddTRONCALESRow(FIBRARow)
                        INICIO.TRONCALESTableAdapter.Update(FIBRARow)
                    End If
            End Select
            CONTADOR += 1
            INICIO.LBL_CANT_ROWS.Text = "TRABAJANDO SOBRE ROW " & CONTADOR
            INICIO.LBL_CANT_ROWS.Refresh()
        End While


        INICIO.FIBRADataSet.Huerfanos.Clear()

        'VALIDAMOS SOBRE LA OLT QUE ODF TIENE
        CONTADOR = 2
        While oHoja.Cells(CONTADOR, 1).Value <> ""
            OLT = oHoja.Cells(CONTADOR, ColR).Value
            If OLT = "" OrElse Mid(OLT, 1, 3) = "Spl" OrElse OLT = "N/A" Or Mid(oHoja.Cells(CONTADOR, ColA).Value, 1, 3) = "Spl" Or Mid(oHoja.Cells(CONTADOR, ColPADRE_w).Value, 1, 3) = "ODF" Then
                ODF = oHoja.Cells(CONTADOR, ColA).Value

                If OLT <> "" AndAlso Mid(ODF, 1, 3) = "ODF" Then
                    HUERFANORow = INICIO.FIBRADataSet.Huerfanos.NewHuerfanosRow
                    HUERFANORow.equipo_OLT = oHoja.Cells(CONTADOR, ColPADRE_w).Value
                    HUERFANORow.equipo_ODF = ODF
                    HUERFANORow.bandeja_OLT = oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).Value
                    HUERFANORow.puerto_OLT = oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value
                    INICIO.FIBRADataSet.Huerfanos.AddHuerfanosRow(HUERFANORow)
                End If
            Else
                BANDEJA = oHoja.Cells(CONTADOR, ColT).Value
                PUERTOPON = oHoja.Cells(CONTADOR, ColU).Value
                INICIO.TRONCALESTableAdapter.FillByOLT_BANDEJA_PUERTO(INICIO.FIBRADataSet.TRONCALES, OLT, BANDEJA, PUERTOPON)
                If INICIO.FIBRADataSet.TRONCALES.Rows.Count > 0 Then
                    For Each EQUIPOS In INICIO.FIBRADataSet.TRONCALES
                        EQUIPOS.ODF = oHoja.Cells(CONTADOR, ColA).Value
                        EQUIPOS.BANDEJA_ODF = oHoja.Cells(CONTADOR, ColB).Value
                        EQUIPOS.PUERTO_ODF = oHoja.Cells(CONTADOR, ColC).Value
                    Next
                    INICIO.TRONCALESTableAdapter.Update(INICIO.FIBRADataSet.TRONCALES)
                End If
            End If

            CONTADOR += 1
            INICIO.LBL_CANT_ROWS.Text = "Creando huerfanos - TRABAJANDO SOBRE ROW " & CONTADOR
            INICIO.LBL_CANT_ROWS.Refresh()
        End While
        Dim ITEM As FIBRADataSet.HuerfanosRow
        'SI HAY HUERFANOS
        If INICIO.FIBRADataSet.Huerfanos.Rows.Count > 0 Then
            'A PARTIR DEL ODF OBTENER EL PRIMER NIVEL DE SPLITEO
            INICIO.FIBRADataSet.odf_huerfano.Clear()
            CONTADOR = 2
            While oHoja.Cells(CONTADOR, 1).Value <> ""
                ODF = oHoja.Cells(CONTADOR, ColA).Value
                HUB = oHoja.Cells(CONTADOR, ColILUMINADO_q).Value
                SPL = oHoja.Cells(CONTADOR, ColR).Value
                For I = 0 To INICIO.FIBRADataSet.Huerfanos.Rows.Count - 1
                    ITEM = INICIO.FIBRADataSet.Huerfanos.Rows(I)

                    If ITEM.equipo_ODF = ODF Then
                        ODFHUERFANORow = INICIO.FIBRADataSet.odf_huerfano.Newodf_huerfanoRow
                        ODFHUERFANORow.nombreodf_a = oHoja.Cells(CONTADOR, ColA).Value
                        ODFHUERFANORow.bandejaodf_b = oHoja.Cells(CONTADOR, ColB).Value
                        ODFHUERFANORow.puertoodf_c = oHoja.Cells(CONTADOR, ColC).Value
                        ODFHUERFANORow.nombreolt_w = oHoja.Cells(CONTADOR, ColPADRE_w).Value
                        ODFHUERFANORow.bandejaolt_y = oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).Value
                        ODFHUERFANORow.puertoolt_z = oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value
                        INICIO.FIBRADataSet.odf_huerfano.Addodf_huerfanoRow(ODFHUERFANORow)
                    End If
                Next
                CONTADOR += 1
                INICIO.LBL_CANT_ROWS.Text = "Obteniendo ODF del huerfano - TRABAJANDO SOBRE ROW " & CONTADOR
                INICIO.LBL_CANT_ROWS.Refresh()
            End While

            Dim ITEM_ODF As FIBRADataSet.odf_huerfanoRow
            CONTADOR = 2
            While oHoja.Cells(CONTADOR, 1).Value <> ""
                CAJA = oHoja.Cells(CONTADOR, ColCAJA).Value
                If Mid(CAJA, 1, 3) = "NAP" Then
                    If oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).value.ToString() = "" Then
                        CONTADOR += 1
                        Continue While
                    End If
                    CAJA_PRIMERA = oHoja.Cells(CONTADOR, ColILUMINADO_q).Value
                    SPL = oHoja.Cells(CONTADOR, ColR).Value
                    BANDEJA = oHoja.Cells(CONTADOR, ColBANDEJA_OLT_y).Value
                    PUERTOPON = oHoja.Cells(CONTADOR, ColPUERTO_PON_z).Value
                    INICIO.TRONCALESTableAdapter.FillByCAJA_SEGUNDA(INICIO.FIBRADataSet.TRONCALES, CAJA)
                    If INICIO.FIBRADataSet.TRONCALES.Rows.Count > 0 Then
                        FIBRARow = INICIO.FIBRADataSet.TRONCALES.Rows(0)
                        'verificamos que no tenga la ODF cargada
                        If FIBRARow.ODF = "" Then
                            For I = 0 To INICIO.FIBRADataSet.odf_huerfano.Rows.Count - 1
                                ITEM_ODF = INICIO.FIBRADataSet.odf_huerfano.Rows(I)
                                If FIBRARow.OLT = ITEM_ODF.nombreolt_w And BANDEJA = ITEM_ODF.bandejaolt_y And PUERTOPON = ITEM_ODF.puertoolt_z Then
                                    FIBRARow.ODF = ITEM_ODF.nombreodf_a
                                    FIBRARow.BANDEJA_ODF = ITEM_ODF.bandejaodf_b
                                    FIBRARow.PUERTO_ODF = ITEM_ODF.puertoodf_c
                                    FIBRARow.CAJA_PRIMERA = CAJA_PRIMERA
                                    FIBRARow.SPLITTER_PRIMERA = SPL
                                    FIBRARow.SALIDAS_PRIMERA = Mid(oHoja.Cells(CONTADOR, ColS).Value, 3, 1)
                                    INICIO.TRONCALESTableAdapter.Update(FIBRARow)
                                End If
                            Next
                        End If
                    End If
                End If
                CONTADOR += 1
                INICIO.LBL_CANT_ROWS.Text = "Agregando datos NAP - TRABAJANDO SOBRE ROW " & CONTADOR
                INICIO.LBL_CANT_ROWS.Refresh()
            End While
        End If
        'A PARTIR DEL ODF OBTENER EL PRIMER NIVEL DE SPLITEO
        CONTADOR = 2
        While oHoja.Cells(CONTADOR, 1).Value <> ""

            ODF = oHoja.Cells(CONTADOR, ColR).Value
            If Mid(ODF, 1, 3) = "ODF" Then 'ODF <> "" AndAlso
                BANDEJA = oHoja.Cells(CONTADOR, ColT).value
                PUERTOPON = oHoja.Cells(CONTADOR, ColU).value
                INICIO.TRONCALESTableAdapter.FillByODF_BANDEJA_PUERTO(INICIO.FIBRADataSet.TRONCALES, ODF, BANDEJA, PUERTOPON)
                If INICIO.FIBRADataSet.TRONCALES.Rows.Count > 0 Then
                    For Each EQUIPOS In INICIO.FIBRADataSet.TRONCALES
                        EQUIPOS.CAJA_PRIMERA = oHoja.Cells(CONTADOR, ColCAJA).value
                        EQUIPOS.SALIDAS_PRIMERA = oHoja.Cells(CONTADOR, ColSALIDAS_h).value
                        EQUIPOS.SPLITTER_PRIMERA = oHoja.Cells(CONTADOR, ColA).value
                    Next
                    INICIO.TRONCALESTableAdapter.Update(INICIO.FIBRADataSet.TRONCALES)
                End If
            End If

            CONTADOR += 1
            INICIO.LBL_CANT_ROWS.Text = "Cargando 1er nivel de spliteo - TRABAJANDO SOBRE ROW " & CONTADOR
            INICIO.LBL_CANT_ROWS.Refresh()
        End While

        oLibro.Close()
        oExcel.Quit()
        Runtime.InteropServices.Marshal.ReleaseComObject(oHoja)
        Runtime.InteropServices.Marshal.ReleaseComObject(oLibro)
        Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)




        INICIO.LBL_CANT_ROWS.Text = "LISTO!"
        INICIO.LBL_CANT_ROWS.Refresh()
        INICIO.Cursor = Cursors.Default
    End Sub

    'Public Sub VINCULAR_EDIFICIOS()
    '    INICIO.Cursor = Cursors.WaitCursor
    '    INICIO.FTTBTableAdapter.FillByFTTEDIFICIO(INICIO.FIBRADataSet.FTTB, INICIO.CBNODO.Text)
    '    INICIO.TRONCALESTableAdapter.FillByNODO(INICIO.FIBRADataSet.TRONCALES, INICIO.CBNODO.Text)
    '    For Each FTTB In INICIO.FIBRADataSet.FTTB
    '        Dim CAJA_ORIGEN = ARMAR_NAP(FTTB("NAP_NRO"), "A", FTTB("ACOMETIDA"), INICIO.CBNODO.Text, FTTB("ZONA"))
    '        For Each TRONC In INICIO.FIBRADataSet.TRONCALES
    '            If CAJA_ORIGEN = TRONC.CAJA_SEGUNDA Then
    '                If IsDBNull(FTTB("CARPETA")) = False Then TRONC.CARPETA_MDU = FTTB("CARPETA")
    '                TRONC.ID_MDU = FTTB("ID_MDU")
    '                INICIO.TRONCALESTableAdapter.Update(TRONC)
    '            End If
    '        Next
    '        INICIO.LBL_CANT_ROWS.Text = "LEYENDO EL EDIFICIO " & FTTB("ID_MDU")
    '        INICIO.LBL_CANT_ROWS.Refresh()
    '    Next
    '    INICIO.Cursor = Cursors.Default
    'End Sub

    Public Sub CARGARDESDEEXCELRELEVAMIENTO(fileName As String)
        INICIO.Cursor = Cursors.WaitCursor
        Dim OBS As EDIFICIODataSet.OBS_MDURow
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        oLibro = oExcel.Workbooks.Open(fileName)
        If INICIO.TXT_ZONA.Text <> "" Then
            INICIO.MDUTableAdapter.FillByNODOYZONA(INICIO.EdificioDataSetBackUp.MDU, INICIO.CBNODO.Text, INICIO.TXT_ZONA.Text)
        Else
            INICIO.MDUTableAdapter.FillBynodo(INICIO.EdificioDataSetBackUp.MDU, INICIO.CBNODO.Text)
        End If

        Dim nroZona As String
        Dim nodo As String
        Dim CARPETA As Integer
        For Each MDURow In INICIO.EdificioDataSetBackUp.MDU
            ' MDURow = INICIO.EdificioDataSetBackUp.MDU.Rows(X)
            INICIO.LBL_CANT_ROWS.Text = MDURow.ID_MDU
            INICIO.LBL_CANT_ROWS.Refresh()
            nodo = MDURow.NODO
            nroZona = MDURow.ZONA
            If nroZona < 10 Then nroZona = "0" & nroZona
            Dim HOJA As String = nodo & nroZona
            Dim ENCONTRADO = False
            Dim SUBTERRANEO As String
            For H = 1 To 35
                Try
                    If oLibro.Sheets(H).NAME = HOJA Then
                        oHoja = oLibro.Sheets(H)
                        ENCONTRADO = True
                        Exit For
                    End If
                Catch eS As Exception
                End Try
            Next
            If ENCONTRADO = False Then Continue For
            Try
                Dim CONTADOR As Integer = 2
                Dim TIPO_EDIFICIO As String = "1"
                Try
                    While TIPO_EDIFICIO <> ""
                        CONTADOR += 1
                        TIPO_EDIFICIO = oHoja.Cells(CONTADOR, 2).Value
                        If TIPO_EDIFICIO = "" Or TIPO_EDIFICIO = "Secundaria" Then Continue While
                        CARPETA = oHoja.Cells(CONTADOR, 1).Value
                        If MDURow.CALLE = oHoja.Cells(CONTADOR, 3).Value And MDURow.PUERTA = oHoja.Cells(CONTADOR, 4).Value Then
                            SUBTERRANEO = oHoja.Cells(CONTADOR, 8).Value.ToString.ToUpper()
                            If SUBTERRANEO = "SUBTERRÁNEO" Then SUBTERRANEO = "SUBTERRANEO"
                            If SUBTERRANEO = "AÉREO" Then SUBTERRANEO = "AEREO"
                            INICIO.OBS_MDUTableAdapter.FillByID(INICIO.EDIFICIODataSet.OBS_MDU, MDURow.ID_MDU)
                            If INICIO.EDIFICIODataSet.OBS_MDU.Rows.Count > 0 Then
                                OBS = INICIO.EDIFICIODataSet.OBS_MDU.Rows(0)
                                OBS.OBSERVACION = oHoja.Cells(CONTADOR, 11).Value
                                INICIO.OBS_MDUTableAdapter.Update(OBS)
                            Else
                                OBS = INICIO.EDIFICIODataSet.OBS_MDU.NewOBS_MDURow
                                OBS.ID_MDU = MDURow.ID_MDU

                                OBS.OBSERVACION = oHoja.Cells(CONTADOR, 11).Value
                                INICIO.EDIFICIODataSet.OBS_MDU.AddOBS_MDURow(OBS)
                                Try
                                    INICIO.OBS_MDUTableAdapter.Update(OBS)
                                Catch ex As Exception
                                    MsgBox("MDU ID " & MDURow.ID_MDU & ",  " & ex.Message)
                                End Try
                            End If

                            Dim SQL = "UPDATE MDU SET 
                                        APTOS =" & oHoja.Cells(CONTADOR, 5).Value & ", 
                                        PISOS=" & oHoja.Cells(CONTADOR, 6).Value & ", 
                                        TORRE=" & oHoja.Cells(CONTADOR, 7).Value & ", 
                                        INGRESO = '" & SUBTERRANEO & "',
                                        PORTERIA = " & oHoja.Cells(CONTADOR, 10).Value & " 
                                        WHERE ID_MDU=" & MDURow.ID_MDU
                            ExecuteNonQuery("edificio", SQL)
                            Continue For
                        End If
                    End While

                Catch ex As Exception
                    ' MsgBox("La Hoja no tiene los datos correctos" & ex.Message)
                End Try
            Catch eY As Exception
                MsgBox("No exite la Hoja " & eY.Message)
            End Try

        Next

        oLibro.Close()
        oExcel.Quit()
        INICIO.Cursor = Cursors.Default
    End Sub
End Module
