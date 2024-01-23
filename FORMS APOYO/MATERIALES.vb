Imports Microsoft.Office.Interop
Imports Newtonsoft.Json
Public Class MATERIALES
    Dim NUEVO_REGISTRORow As INDICESDataSet.MAT_STOCKRow
    Dim MATERIALRow As DataRow
    Dim MATERIALES_ACTIVOS As INDICESDataSet.MAT_ACTIVOSRow
    Dim CONTROL_MATRow As INDICESDataSet.MAT_CONSOLIDADORow
    Dim INFORMERow As INDICESDataSet.MAT_INFORMERow
    Dim CONTROL_SALRow As INDICESDataSet.MAT_CONSOLIDADORow
    Dim TRANSITORow As INDICESDataSet.MAT_TRANSITORow
    Dim CAMPO(5) As String
    Dim DATO(5) As String
    Dim FILTRO(5) As String
    Dim MES As String
    Dim AÑO As Integer
    Private Sub MATERIALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MAT_CONSOLIDADOTableAdapter.FillByDISTINCT_FECHA(IndicesDataSet.MAT_CONSOLIDADO)
        LBL_CONSOLIDADO_ULTIMA.Text = "ULTIMA FECHA INGRESADA: " & CDate(IndicesDataSet.MAT_CONSOLIDADO.Rows(IndicesDataSet.MAT_CONSOLIDADO.Rows.Count - 1).Item("FECHA")).ToShortDateString
        CB_ANIO.Text = Today.Year
    End Sub
    Private Sub BTN_CARGAR_Click(sender As Object, e As EventArgs) Handles BTN_CARGAR.Click 'CARGA STOCK CONTROL A FECHA DEL PROCESO
        MAT_STOCKTableAdapter.FillByFECHA_CONTROL(INDICESDataSet.MAT_STOCK, DT_FECHA.Value.ToShortDateString)
        If INDICESDataSet.MAT_STOCK.Rows.Count > 0 Then
            MsgBox("YA EXISTE REGISTROS INGRESADOS PARA LA FECHA " & DT_FECHA.Value.ToShortDateString, vbInformation)
            Exit Sub
        End If
        If TXT_PATH.Text = "" Then
            MsgBox("DEBE SELECCIONAR EL ARCHIVO EXCEL PARA CONTINUAR")
            Exit Sub
        End If

        'CARGAMOS LOS DATOS DEL EXCEL A LA BASE DE DATOS MAT_STOCK, 
        'EL EXCEL ES DEL STOCK DE CENTRO - CENTRO 3
        Dim Fila As Integer
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        oLibro = oExcel.Workbooks.Open(TXT_PATH.Text)
        oHoja = oLibro.Sheets(oLibro.Worksheets.Item(1).NAME)
        Dim ID_ARTICULO As String
        Dim CONTENIDO As String = oHoja.Cells(7, 1).VALUE
        CONTENIDO = oHoja.Cells(7, 1).VALUE
        Fila = 7
        While CONTENIDO <> ""
            txt_id.Text = "CARGANDO ARTIULO: " & CONTENIDO & " - " & oHoja.Cells(Fila, 2).value
            txt_id.Refresh()
            Try
                NUEVO_REGISTRORow = INDICESDataSet.MAT_STOCK.NewMAT_STOCKRow()
                NUEVO_REGISTRORow("ID_ARTICULO") = oHoja.Cells(Fila, 1).value
                ID_ARTICULO = oHoja.Cells(Fila, 1).value
                NUEVO_REGISTRORow("NOMBRE_ARTICULO") = oHoja.Cells(Fila, 2).value
                NUEVO_REGISTRORow("ESTADO") = oHoja.Cells(Fila, 3).value
                NUEVO_REGISTRORow("ALIAS") = oHoja.Cells(Fila, 4).value
                NUEVO_REGISTRORow("FISICO") = oHoja.Cells(Fila, 5).value
                NUEVO_REGISTRORow("COMPROMETIDO") = oHoja.Cells(Fila, 6).value
                NUEVO_REGISTRORow("DISPONIBLE") = oHoja.Cells(Fila, 7).value
                NUEVO_REGISTRORow("PRECIO") = oHoja.Cells(Fila, 8).value
                If IsDate(oHoja.Cells(Fila, 9).value) Then
                    NUEVO_REGISTRORow.FECHA_PRECIO = oHoja.Cells(Fila, 9).value
                    NUEVO_REGISTRORow("MES") = CDate(oHoja.Cells(Fila, 9).value).Month
                    NUEVO_REGISTRORow("AÑO") = CDate(oHoja.Cells(Fila, 9).value).Year
                End If
                NUEVO_REGISTRORow.MES_FECHACONTROL = DT_FECHA.Value.Month
                NUEVO_REGISTRORow.AÑO_FECHACONTROL = DT_FECHA.Value.Year
                NUEVO_REGISTRORow.FECHA_CONTROL = DT_FECHA.Value.ToShortDateString

                INDICESDataSet.MAT_STOCK.Rows.Add(NUEVO_REGISTRORow)
            Catch EX As Exception
                MsgBox("ERROR EN CARGAR DATOS " & EX.Message)
            End Try
            Fila += 1
            CONTENIDO = oHoja.Cells(Fila, 1).value
        End While
        Try
            Cursor = Cursors.WaitCursor
            MAT_STOCKTableAdapter.Update(INDICESDataSet.MAT_STOCK)
            Cursor = Cursors.Default
            NOTIFICACION("SYS", "REGISTROS INGRESADOS CORRECTAMENTE!")

        Catch ex As Exception
            MsgBox("NO SE PUDO ACTUALIZAR LA BASE DE DATOS    -> " & ex.Message, vbExclamation)
        End Try
        oLibro.Close()
        oExcel.Quit()
        BTN_CARGAR.BackColor = Color.Green
        BTN_CARGAR.ForeColor = Color.White
    End Sub
    'Private Sub CARGAR_PROMEDIOS()
    '    MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(INDICESDataSet.MAT_ACTIVOS, "NUEVO", True)
    '    MATERIALESTableAdapter.FillByDISTINCT_FECHA_CONTROL(INDICESDataSet.MATERIALES)
    '    Dim VIEJA_FECHACONTROL As Date = INDICESDataSet.MATERIALES.Rows(INDICESDataSet.MATERIALES.Rows.Count - 2).Item("FECHA_CONTROL")
    '    Dim ULTIMA_FECHACONTROL As Date = INDICESDataSet.MATERIALES.Rows(INDICESDataSet.MATERIALES.Rows.Count - 1).Item("FECHA_CONTROL")
    '    Try
    '        For MAT_ACT = 0 To INDICESDataSet.MAT_ACTIVOS.Rows.Count - 1
    '            MATERIALES_ACTIVOS = INDICESDataSet.MAT_ACTIVOS.Rows(MAT_ACT)
    '            MATERIALESTableAdapter.FillByARTICULO_FECHACONTROL(MATERIALES_ANTES.MATERIALES, MATERIALES_ACTIVOS.ID_MAT_ARTICULO, VIEJA_FECHACONTROL.ToShortDateString)

    '            MATERIALESTableAdapter.FillByARTICULO_FECHACONTROL(MATERIALES_ULTIMO.MATERIALES, MATERIALES_ACTIVOS.ID_MAT_ARTICULO, ULTIMA_FECHACONTROL.ToShortDateString)
    '            If MATERIALES_ANTES.MATERIALES.Rows.Count > 0 And MATERIALES_ULTIMO.MATERIALES.Rows.Count > 0 Then
    '                Dim CONSUMO_MES As Double = (MATERIALES_ANTES.MATERIALES.Rows(0).Item("FISICO") - MATERIALES_ULTIMO.MATERIALES.Rows(0).Item("FISICO")) / DateDiff(DateInterval.Day, VIEJA_FECHACONTROL, ULTIMA_FECHACONTROL)
    '                If CONSUMO_MES >= 0 Then
    '                    CONTROL_MATRow = INDICESDataSet.CONTROL_MAT.NewCONTROL_MATRow
    '                    CONTROL_MATRow.ID_MATERIAL_CONTROL = MATERIALES_ACTIVOS.ID_MAT_ARTICULO
    '                    CONTROL_MATRow.CONSUMO_XDIA = CONSUMO_MES
    '                    CONTROL_MATRow.FECHA_CALCULO = Today.ToShortDateString
    '                    CONTROL_MATRow.USUARIO_CALCULO = FULLNOMBRE
    '                    INDICESDataSet.CONTROL_MAT.Rows.Add(CONTROL_MATRow)
    '                    txt_id.Text = MATERIALES_ACTIVOS.ID_MAT_ARTICULO
    '                    txt_id.Refresh()
    '                    CONTROL_MATTableAdapter.Update(CONTROL_MATRow)
    '                End If
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub BTN_VER_PanelINGRESO_Click(sender As Object, e As EventArgs) Handles BTN_VER_PanelINGRESO.Click
        If BTN_VER_PanelINGRESO.Text = "CARGAR DATOS" Then
            P_INGRESO.Visible = True
            P_INGRESO.BringToFront()
            BTN_VER_PanelINGRESO.Text = "CERRAR CARGA DATOS"
            BTN_VER_PanelINGRESO.BackColor = Color.Red
            BTN_GENERAR_INFORME.BackColor = Color.White
            BTN_GENERAR_INFORME.Text = "INFORMES"
            P_INFORME.Visible = False
            BTN_CONTROL_MATERIAL.BackColor = Color.White
            BTN_CONTROL_MATERIAL.Text = "CONTROL MATERIAL"
            P_BUSCAR_MAT.Visible = False
        Else
            P_INGRESO.Visible = False
            BTN_VER_PanelINGRESO.Text = "CARGAR DATOS"
            BTN_VER_PanelINGRESO.BackColor = Color.White
        End If
    End Sub
    Private Sub BTN_ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click
        MATERIALES_ACTIVOS.ACTIVO = CK_MATERIAL_ACTIVO.Checked
        MATERIALES_ACTIVOS.PRECIO_ARTICULO = TXT_PRECIO.Text
        MATERIALES_ACTIVOS.TIPO_COMPRA = CB_TIPO_COMPRA.Text
        MATERIALES_ACTIVOS.TIPO_MATERIAL = CB_TIPO_MATERIAL.Text
        MATERIALES_ACTIVOS.MIN_STOCK = TXT_MIN_STOCK.Text
        MATERIALES_ACTIVOS.MIN_TIEMPO_COMPRA_DIAS = TXT_CANT_DIAS.Text
        MATERIALES_ACTIVOS.FECHAPRECIO_ARTICULO = DT_FECHA.Value.ToShortDateString

        Try
            MAT_ACTIVOSTableAdapter.Update(MATERIALES_ACTIVOS)
            NOTIFICACION("SYS", "ATICULO ACTUALIZADO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If CB_ESTADO.Text = "TODOS" Then
            MAT_ACTIVOSTableAdapter.FillByACTIVO(INDICESDataSet.MAT_ACTIVOS, CK_ACTIVO.Checked)
        Else
            MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(INDICESDataSet.MAT_ACTIVOS, CB_ESTADO.Text, CK_ACTIVO.Checked)
        End If
    End Sub
    Private Sub BTN_CONTROL_Click(sender As Object, e As EventArgs) Handles BTN_CONTROL_MATERIAL.Click
        If BTN_CONTROL_MATERIAL.Text = "CONTROL MATERIAL" Then
            P_BUSCAR_MAT.Visible = True
            BTN_CONTROL_MATERIAL.Text = "CERRAR CONTROL MATERIAL"
            BTN_CONTROL_MATERIAL.BackColor = Color.Red
            BTN_GENERAR_INFORME.BackColor = Color.White
            BTN_GENERAR_INFORME.Text = "INFORMES"
            P_INFORME.Visible = False
            BTN_VER_PanelINGRESO.BackColor = Color.White
            BTN_VER_PanelINGRESO.Text = "CARGAR DATOS"
            P_INGRESO.Visible = False

        Else
            P_BUSCAR_MAT.Visible = False
            BTN_CONTROL_MATERIAL.Text = "CONTROL MATERIAL"
            BTN_CONTROL_MATERIAL.BackColor = Color.White
        End If
        '    If BTN_CONTROL.Text = "CONTROL MATERIAL" Then
        '        P_CONTROL.Visible = True
        '        BTN_CONTROL.Text = "CERRAR CONTROL MATERIAL"
        '    Else
        '        P_CONTROL.Visible = False
        '        BTN_CONTROL.Text = "CONTROL MATERIAL"
        '    End If
    End Sub
    Private Sub CB_ESTADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ESTADO.SelectedIndexChanged
        Select Case CB_ESTADO.Text
            Case "TODOS"
                MAT_ACTIVOSTableAdapter.FillByACTIVO(IndicesDataSet.MAT_ACTIVOS, CK_ACTIVO.Checked)
            Case Else
                MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(IndicesDataSet.MAT_ACTIVOS, CB_ESTADO.Text, CK_ACTIVO.Checked)
        End Select
    End Sub
    Private Sub BTN_ABRIR_OPENFILE_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_OPENFILE.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TXT_PATH.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BTN_AGREGAR_ARTICULO_MANUAL_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_ARTICULO_MANUAL.Click
        If GB_AGREGAR_STOCK_MANUAL.Visible = False Then
            MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(INDICESDataSet.MAT_ACTIVOS, "NUEVO", True)
            CB_ARTICULO.Items.Clear()
            For M = 0 To INDICESDataSet.MAT_ACTIVOS.Rows.Count - 1
                CB_ARTICULO.Items.Add(INDICESDataSet.MAT_ACTIVOS.Rows(M).Item("NOMBRE_ARTICULO"))
                CB_ALIAS.Items.Add(INDICESDataSet.MAT_ACTIVOS.Rows(M).Item("ALIAS_ARTICULO"))
            Next
        End If
        GB_AGREGAR_STOCK_MANUAL.Visible = True
    End Sub 'AGREGA UN ARTICULO MANUAL AL CONTROL DE STOCK
    Private Sub CB_ALIAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ALIAS.SelectedIndexChanged
        MAT_ACTIVOSTableAdapter.FillByALIASACTIVO(INDICESDataSet.MAT_ACTIVOS, CB_ALIAS.Text)
        CB_ARTICULO.Text = INDICESDataSet.MAT_ACTIVOS.Rows(0).Item("NOMBRE_ARTICULO")
    End Sub
    Private Sub CB_ARTICULO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ARTICULO.SelectedIndexChanged
        MAT_ACTIVOSTableAdapter.FillByNOMBRE_ACTIVO(INDICESDataSet.MAT_ACTIVOS, CB_ARTICULO.Text)
        CB_ALIAS.Text = INDICESDataSet.MAT_ACTIVOS.Rows(0).Item("ALIAS_ARTICULO")
    End Sub
    Private Sub BTN_ACTUALIZAR_ARTICULO_Click_1(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR_ARTICULO.Click
        If CB_ALIAS.Text = "" Or CB_ARTICULO.Text = "SELECCIONE" Or TXT_CANT.Text = "" Then
            MsgBox("COMPLETE LOS CAMPOS PARA INGRESAR NUEVO STOCK ARTICULO")
            Exit Sub
        End If
    End Sub
    Private Sub CK_ACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CK_ACTIVO.CheckedChanged
        If CB_ESTADO.Text = "TODOS" Then
            MAT_ACTIVOSTableAdapter.FillByACTIVO(IndicesDataSet.MAT_ACTIVOS, CK_ACTIVO.Checked)
        Else
            MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(IndicesDataSet.MAT_ACTIVOS, CB_ESTADO.Text, CK_ACTIVO.Checked)
        End If
    End Sub
    Private Sub MAT_ACTIVOSDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MAT_ACTIVOSDataGridView.CellClick
        MATERIALES_ACTIVOS = INDICESDataSet.MAT_ACTIVOS.Rows(MAT_ACTIVOSDataGridView.CurrentRow.Index)
        CK_MATERIAL_ACTIVO.Checked = MATERIALES_ACTIVOS.ACTIVO
        If MATERIALES_ACTIVOS.IsTIPO_MATERIALNull = False Then
            CB_TIPO_MATERIAL.Text = MATERIALES_ACTIVOS.TIPO_MATERIAL
        Else
            CB_TIPO_MATERIAL.Text = ""
        End If
        If MATERIALES_ACTIVOS.IsTIPO_COMPRANull = False Then
            CB_TIPO_COMPRA.Text = MATERIALES_ACTIVOS.TIPO_COMPRA
        Else
            CB_TIPO_COMPRA.Text = ""
        End If
        If MATERIALES_ACTIVOS.IsFECHAPRECIO_ARTICULONull = False Then
            DT_FECHA.Value = MATERIALES_ACTIVOS.FECHAPRECIO_ARTICULO
            DT_FECHA.Text = MATERIALES_ACTIVOS.FECHAPRECIO_ARTICULO
            DT_FECHA.Visible = True
        Else
            DT_FECHA.Visible = False
        End If
        If MATERIALES_ACTIVOS.IsMIN_STOCKNull = False Then
            TXT_MIN_STOCK.Text = MATERIALES_ACTIVOS.MIN_STOCK
        Else
            TXT_MIN_STOCK.Text = 0
        End If
        If IsDBNull(MATERIALES_ACTIVOS("MIN_TIEMPO_COMPRA_DIAS")) = False Then
            TXT_CANT_DIAS.Text = MATERIALES_ACTIVOS.MIN_TIEMPO_COMPRA_DIAS
        Else
            TXT_CANT_DIAS.Text = 0
        End If
        If MATERIALES_ACTIVOS.IsPRECIO_ARTICULONull = False Then
            TXT_PRECIO.Text = MATERIALES_ACTIVOS.PRECIO_ARTICULO
        Else
            TXT_PRECIO.Text = 0
        End If

    End Sub
    Private Sub BTN_GENERAR_INFORME_Click(sender As Object, e As EventArgs) Handles BTN_GENERAR_INFORME.Click
        If BTN_GENERAR_INFORME.Text = "INFORMES" Then
            P_INFORME.Visible = True
            BTN_GENERAR_INFORME.Text = "CERRAR INFORME"
            BTN_GENERAR_INFORME.BackColor = Color.Red
            BTN_VER_PanelINGRESO.BackColor = Color.White
            BTN_VER_PanelINGRESO.Text = "CARGAR DATOS"
            P_BUSCAR_MAT.Visible = False
            BTN_CONTROL_MATERIAL.BackColor = Color.White
            BTN_CONTROL_MATERIAL.Text = "CONTROL MATERIAL"
            P_INGRESO.Visible = False
        Else
            P_INFORME.Visible = False
            BTN_GENERAR_INFORME.Text = "INFORMES"
            BTN_GENERAR_INFORME.BackColor = Color.White
        End If

        MAT_INFORMETableAdapter.FillByDISTINCTF_INFORME(IndicesDataSet1.MAT_INFORME)
        CB_BINFORME.Items.Clear()
        For CB = 0 To IndicesDataSet1.MAT_INFORME.Rows.Count - 1
            CB_BINFORME.Items.Add(IndicesDataSet1.MAT_INFORME.Rows(CB).Item("FECHA_INFORME"))
        Next
    End Sub 'MUESTRA LO INFORMES GENERADOS Y ABRE LA HOJA DE CONTENIDOS.
    Private Sub CALCULO_DE_INFORME()         'CALCULARA SOBRE LOS MATERIALES "ACTIVOS"

        'BUSCAMOS TODOS LOS MATERIALES ACTIVOS
        MAT_ACTIVOSTableAdapter.FillByESTADO_STATUS(IndicesDataSet.MAT_ACTIVOS, "NUEVO", True)

        'FECHA DEL ULTIMO CONTROL DE STOCK DE MATERIALES 
        MAT_STOCKTableAdapter.FillByDISTINCT_FECHACONTROL(IndicesDataSet.MAT_STOCK)

        MAT_CONSOLIDADOTableAdapter.FillByDISTINCT_FECHA(IndicesDataSet.MAT_CONSOLIDADO)
        Dim ULTIMA_FECHACONTROL As Date = IndicesDataSet.MAT_STOCK.Rows(IndicesDataSet.MAT_STOCK.Rows.Count - 1).Item("FECHA_CONTROL")

        Dim TIEMPO_FLETE As Integer
        Dim CANTIDAD_CONSUMIDO As Integer
        Dim STOCK_MIN_SEGUN_CONSUMO As Integer
        'EXTRAEMOS LA CANTIDAD DE MATERIALES SEGUN SE CONSUMIO EN EL PERIODO SELECCIONADO, A MES VENCIDO.
        Dim ULTIMO_CONTROL_CONSUMO As Date = IndicesDataSet.MAT_CONSOLIDADO.Rows(IndicesDataSet.MAT_CONSOLIDADO.Rows.Count - 1).Item("FECHA")
        'RECORREMOS LOS MATERIALES ACTIVOS
        For Each MATERIAL In IndicesDataSet.MAT_ACTIVOS
            CANTIDAD_CONSUMIDO = 0
            txt_id.Text = "CALCULANDO PARA: " & MATERIAL.ALIAS_ARTICULO & " - " & MATERIAL.NOMBRE_ARTICULO & " - " & MATERIAL.ESTADO_ARTICULO
            txt_id.Refresh()

            'INSTANCIAMOS PARA QUE SE GENERE UN NUEVO REGISTRO
            INFORMERow = IndicesDataSet.MAT_INFORME.NewMAT_INFORMERow
            INFORMERow.CODIGO = MATERIAL.ID_MAT_ARTICULO
            INFORMERow.CODIGO_ALIAS = MATERIAL.ALIAS_ARTICULO
            INFORMERow.ESTADO = MATERIAL.ESTADO_ARTICULO
            INFORMERow.NOMBRE = MATERIAL.NOMBRE_ARTICULO
            INFORMERow.PERIODO_PROMEDIO = CB_MESES.Text
            'CALCULO DE EXISTENTCIAS

            For M = 0 To CInt(CB_MESES.Text) - 1
                If CB_MESES.Text > ULTIMO_CONTROL_CONSUMO.Month Then
                    If M = ULTIMO_CONTROL_CONSUMO.Month Then
                        AÑO = ULTIMO_CONTROL_CONSUMO.AddYears(-1).Year
                    ElseIf M = ULTIMO_CONTROL_CONSUMO.Month + 12 Then
                        AÑO = ULTIMO_CONTROL_CONSUMO.AddYears(-2).Year
                    ElseIf M = ULTIMO_CONTROL_CONSUMO.Month + 24 Then
                        AÑO = ULTIMO_CONTROL_CONSUMO.AddYears(-3).Year
                    ElseIf M < ULTIMO_CONTROL_CONSUMO.Month Then
                        AÑO = ULTIMO_CONTROL_CONSUMO.Year
                    End If
                Else
                    AÑO = ULTIMO_CONTROL_CONSUMO.Year
                End If

                MAT_CONSUMOSXMESTableAdapter.FillByART_MES_ANIO(IndicesDataSet.MAT_CONSUMOSXMES, Trim(MATERIAL.ALIAS_ARTICULO), CInt(ULTIMO_CONTROL_CONSUMO.AddMonths(-M).Month), AÑO)
                '  MsgBox("CONSUMO PARA FECHA " & CInt(ULTIMO_CONTROL_CONSUMO.AddMonths(-M).Month) & "  " & AÑO & " - TRAJO " & IndicesDataSet.MAT_CONSUMOSXMES.Rows.Count & " REGISTROS")
                If IndicesDataSet.MAT_CONSUMOSXMES.Rows.Count > 0 Then
                    For CANT = 0 To IndicesDataSet.MAT_CONSUMOSXMES.Rows.Count - 1
                        CANTIDAD_CONSUMIDO += CInt(IndicesDataSet.MAT_CONSUMOSXMES.Rows(0).Item("CONSUMO"))
                        ' MsgBox("SUMO AL CONSUMO " & CInt(IndicesDataSet.MAT_CONSUMOSXMES.Rows(0).Item("CONSUMO")) & " - EL ACUMULADO ES " & CANTIDAD_CONSUMIDO)
                    Next
                End If
            Next
            If MATERIAL.TIPO_COMPRA = "EN PLAZA" Then

            End If
            INFORMERow.CONSUMOxMES = CANTIDAD_CONSUMIDO / CInt(CB_MESES.Text)
            INFORMERow.TOTAL_CONSUMIDO = CANTIDAD_CONSUMIDO
            'CONTROL DE STOCK INICIAL
            MAT_STOCKTableAdapter.FillByFECHACONTROL_ARTICULO(IndicesDataSet.MAT_STOCK, MATERIAL.ALIAS_ARTICULO, ULTIMA_FECHACONTROL)
            If IndicesDataSet.MAT_STOCK.Rows.Count > 0 Then
                INFORMERow.EXISTENCIA = IndicesDataSet.MAT_STOCK.Rows(0).Item("FISICO")
                INFORMERow.EXISTENCIA_COMPROMETIDA = IndicesDataSet.MAT_STOCK.Rows(0).Item("COMPROMETIDO")
            Else
                MsgBox("El articulo " & MATERIAL.ALIAS_ARTICULO & " - " & MATERIAL.NOMBRE_ARTICULO & " NO TRAJO DATOS DE EXISTENCIAS")
                INFORMERow.EXISTENCIA = 0
                INFORMERow.EXISTENCIA_COMPROMETIDA = 0
            End If

            'SI NO TIENE EL TIPO DE COMPRA ES QUITADO DEL INFORME
            If MATERIAL.IsTIPO_COMPRANull Then
                MsgBox("El articulo " & MATERIALES_ACTIVOS.ALIAS_ARTICULO & " - " & MATERIALES_ACTIVOS.NOMBRE_ARTICULO & " no tiene ingresado el tipo de COMPRA y no se incluirá en el informe")
                Continue For
            Else
                If MATERIAL.TIPO_COMPRA = "EN PLAZA" Then
                    TIEMPO_FLETE = CInt(TXT_FLETE_LOCAL.Text)
                Else
                    TIEMPO_FLETE = CInt(TXT_FLETE_IMPO.Text)
                End If
                INFORMERow("TIPO_COMPRA") = MATERIAL.TIPO_COMPRA
            End If
            'SETEAMOS STOCK MINIMO
            Dim STOCK_MINIMO As Integer
            Dim CANT_DIAS_COMPRA As Integer
            If MATERIAL.IsMIN_STOCKNull Then
                STOCK_MINIMO = CInt(CANTIDAD_CONSUMIDO / CInt(CB_MESES.Text)) * TIEMPO_FLETE 'SI NO TIENE CARGADO SE LE COFIGURA AUTOMATICAMENTE A 3 MESES DE CONSUMO
            Else
                If MATERIAL.MIN_STOCK = "" Then
                    STOCK_MINIMO = CInt(CANTIDAD_CONSUMIDO / CInt(CB_MESES.Text)) * TIEMPO_FLETE 'SI NO TIENE CARGADO SE LE COFIGURA AUTOMATICAMENTE A 3 MESES DE CONSUMO
                Else
                    STOCK_MINIMO = MATERIAL.MIN_STOCK
                End If
            End If
            INFORMERow.STOCK_MINIMO = STOCK_MINIMO
            STOCK_MIN_SEGUN_CONSUMO = CInt(CANTIDAD_CONSUMIDO / CInt(CB_MESES.Text)) * TIEMPO_FLETE
            INFORMERow.STOCK_MIN_SEGUN_CONSUMO = STOCK_MIN_SEGUN_CONSUMO
            'SETEO DEMORA DEL FLETE
            If MATERIAL.IsMIN_TIEMPO_COMPRA_DIASNull Then
                If MATERIAL.TIPO_COMPRA = "IMPORTACION" Then
                    CANT_DIAS_COMPRA = TXT_FLETE_IMPO.Text
                Else
                    CANT_DIAS_COMPRA = TXT_FLETE_LOCAL.Text
                End If
            Else
                CANT_DIAS_COMPRA = MATERIAL.MIN_TIEMPO_COMPRA_DIAS / 30
            End If
            INFORMERow.TIEMPO_ENTREGA_FLETE = CANT_DIAS_COMPRA
            'CALCULO DE FECHAS
            If INFORMERow.EXISTENCIA > 0 Then 'SI HAY EXISTENCIAS
                If CANTIDAD_CONSUMIDO = 0 Then
                    INFORMERow("FECHA_SIN_STOCK") = "SIN CONSUMOS"
                    INFORMERow("FECHA_SIN_STOCK_MIN") = "SIN CONSUMOS"
                    'INFORMERow("DIAS_PARA_COMPRA") = 9999
                    INFORMERow.FECHA_COMPRA = "NO COMPRAR"
                Else ' HAY EXISTENCIAS Y HAY CONSUMO
                    ' FALTA CALUCULO DE IMPORTACION
                    Dim FechaSinStock As Date = DateAdd(DateInterval.Day, CInt(INFORMERow.EXISTENCIA / (INFORMERow.CONSUMOxMES / 30)), ULTIMA_FECHACONTROL)
                    Dim FECHASINSTOCKMIN As Date = DateAdd(DateInterval.Day, CInt((INFORMERow.EXISTENCIA - STOCK_MIN_SEGUN_CONSUMO) / (INFORMERow.CONSUMOxMES / 30)), ULTIMA_FECHACONTROL)

                    If DateDiff(DateInterval.Day, Today, FECHASINSTOCKMIN) > 365 Then
                        INFORMERow("FECHA_COMPRA") = "NO COMPRAR"
                        INFORMERow("FECHA_SIN_STOCK_MIN") = "> 1 AÑO"
                    Else
                        INFORMERow("FECHA_SIN_STOCK") = FechaSinStock.ToShortDateString
                        INFORMERow("FECHA_SIN_STOCK_MIN") = FECHASINSTOCKMIN.ToShortDateString
                        INFORMERow.FECHA_COMPRA = FECHASINSTOCKMIN.ToShortDateString ' DateAdd(DateInterval.Day, CInt((INFORMERow.EXISTENCIA - STOCK_MINIMO) / INFORMERow.CONSUMOxMES / 30) - DateDiff(DateInterval.Day, Today, FECHASINSTOCKMIN), ULTIMA_FECHACONTROL).ToShortDateString
                        INFORMERow.DIAS_PARA_COMPRA = DateDiff(DateInterval.Day, Today, CDate(INFORMERow.FECHA_COMPRA))
                    End If
                End If

            Else ' SI NO HAY EXISTENCIAS
                If CANTIDAD_CONSUMIDO = 0 Then 'Y NO SE HAN CONSUMIDO
                    INFORMERow("FECHA_SIN_STOCK") = "SIN STOCK"
                    INFORMERow("FECHA_SIN_STOCK_MIN") = "SIN STOCK"
                    INFORMERow("DIAS_PARA_COMPRA") = 0
                    INFORMERow("FECHA_COMPRA") = "A VERIFICAR"
                Else
                    Dim FechaSinStock As Date = DateAdd(DateInterval.Day, CInt(INFORMERow.EXISTENCIA / INFORMERow.CONSUMOxMES * 30), ULTIMA_FECHACONTROL)
                    Dim FECHASINSTOCKMIN As Date = DateAdd(DateInterval.Day, CInt((INFORMERow.EXISTENCIA / INFORMERow.CONSUMOxMES * 30) - (STOCK_MIN_SEGUN_CONSUMO / (INFORMERow.CONSUMOxMES * 30))), ULTIMA_FECHACONTROL)

                    If DateDiff(DateInterval.Day, Today, FECHASINSTOCKMIN) > 365 Then
                        INFORMERow("FECHA_COMPRA") = "NO COMPRAR"
                        INFORMERow("FECHA_SIN_STOCK_MIN") = "> 1 AÑO"
                    Else
                        INFORMERow("FECHA_SIN_STOCK") = FechaSinStock.ToShortDateString
                        INFORMERow("FECHA_SIN_STOCK_MIN") = FECHASINSTOCKMIN.ToShortDateString
                        INFORMERow.FECHA_COMPRA = DateAdd(DateInterval.Day, CInt((INFORMERow.EXISTENCIA - STOCK_MINIMO) / INFORMERow.CONSUMOxMES * 30) - DateDiff(DateInterval.Day, Today, FECHASINSTOCKMIN), ULTIMA_FECHACONTROL).ToShortDateString
                        INFORMERow.DIAS_PARA_COMPRA = DateDiff(DateInterval.Day, Today, CDate(INFORMERow.FECHA_COMPRA))
                    End If
                End If

            End If
            Dim PREVISION_MESES As Integer
            If MATERIAL.TIPO_COMPRA = "IMPORTACION" Then 'PARA COMPRAS CON TIEMPO DE IMPORTACION
                INFORMERow.PREVISION_MESES = TXT_PREVISION_IMPORTACION.Text
                'MULTIPLICAMOS LA PREVISION POR EL CONSUMOXDIA PARA QUE NOS DE LA CANTIDAD QUE NECESITAMOS PARA CUBRIR
                'TENEMOS QUE VER SI NOS LLEGA UNA IMPORTACION EN EL CAMINO
                PREVISION_MESES = CInt(Trim(TXT_PREVISION_IMPORTACION.Text) * INFORMERow.CONSUMOxMES)
            Else
                INFORMERow.PREVISION_MESES = TXT_PREVISION_LOCAL.Text
                PREVISION_MESES = CInt(Trim(TXT_PREVISION_LOCAL.Text) * INFORMERow.CONSUMOxMES)
            End If
            If INFORMERow.FECHA_COMPRA = "NO COMPRAR" Then
            Else
                INFORMERow.CANTIDAD_A_COMPRAR = PREVISION_MESES + STOCK_MINIMO
            End If
            INFORMERow("FECHA_INFORME") = Today.ToShortDateString
            INFORMERow.GENERADO_POR = FULLNOMBRE

            IndicesDataSet.MAT_INFORME.Rows.Add(INFORMERow)
            MAT_INFORMEBindingSource.MoveLast()
            INFORME_MATERIALESDataGridView.Refresh()
        Next
        'Try
        '    txt_id.Text = "GRABANDO BASE DE DATOS"
        '    txt_id.Refresh()
        '    MAT_INFORMETableAdapter.Update(IndicesDataSet.MAT_INFORME)
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        txt_id.Text = "INFORME CREADO"
        txt_id.Refresh()
        ' VER_INFORME_MATERIALES.MAT_INFORMETableAdapter.FillByFECHA(VER_INFORME_MATERIALES.INDICESDataSet.MAT_INFORME, Today.ToShortDateString)
        VER_INFORME_MATERIALES.Show(Me)
        Cursor = DefaultCursor
    End Sub
    Private Sub BTN_CARGAR_CONSOLIDADO_Click(sender As Object, e As EventArgs) Handles BTN_CARGAR_CONSOLIDADO.Click 'AGREGA INFORMACION DEL CONSOLIDADO
        Dim Fila As Integer
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet
        oLibro = oExcel.Workbooks.Open(TXT_CONSOLIDADO.Text)
        oHoja = oLibro.Sheets(oLibro.Worksheets.Item(1).NAME)
        Dim CONTENIDO As String = oHoja.Cells(8, 1).VALUE
        Fila = 8
        While CONTENIDO <> ""
            Dim CODIGO As Integer = oHoja.Cells(Fila, 7).value 'ALIAS
            Try
                txt_id.Text = "INGRESANDO ARTICULO:  " & CODIGO & " - " & oHoja.Cells(Fila, 8).value
                txt_id.Refresh()
                CONTROL_SALRow = IndicesDataSet.MAT_CONSOLIDADO.NewMAT_CONSOLIDADORow
                CONTROL_SALRow.FECHA = oHoja.Cells(Fila, 1).value
                If CStr(Len(Trim(oHoja.Cells(Fila, 2).value))) = 3 Then
                    CONTROL_SALRow.HORA = Mid(Trim(oHoja.Cells(Fila, 2).value), 1, 1) & ":" & Mid(Trim(oHoja.Cells(Fila, 2).value), 2, 2)
                Else
                    CONTROL_SALRow.HORA = Mid(Trim(oHoja.Cells(Fila, 2).value), 1, 2) & ":" & Mid(Trim(oHoja.Cells(Fila, 2).value), 3, 2)
                End If
                CONTROL_SALRow.NUMERO_MOV = oHoja.Cells(Fila, 3).value
                CONTROL_SALRow.AUTORIZA = oHoja.Cells(Fila, 4).value
                CONTROL_SALRow.CODIGO = oHoja.Cells(Fila, 5).value
                CONTROL_SALRow.OPERARIO_CLIENTE = oHoja.Cells(Fila, 6).value
                CONTROL_SALRow.ARTICULO = CODIGO 'ALIAS
                CONTROL_SALRow.DESCRIPCION = oHoja.Cells(Fila, 8).value
                CONTROL_SALRow.UNIDAD = oHoja.Cells(Fila, 9).value
                CONTROL_SALRow.CANTIDAD = oHoja.Cells(Fila, 10).value

                CONTROL_SALRow.OBSERVACIONES = oHoja.Cells(Fila, 11).value
                IndicesDataSet.MAT_CONSOLIDADO.Rows.Add(CONTROL_SALRow)
            Catch ex As Exception
                MsgBox("NO SE PUDO INGRESAR EL ARTICULO " & CODIGO & ex.Message)
            End Try
            Fila += 1
            CONTENIDO = oHoja.Cells(Fila, 1).value
        End While
        oLibro.Close()
        oExcel.Quit()

        txt_id.Text = "INGRESANDO DATOS, ESPERE..."
        txt_id.Refresh()
        Try
            Cursor = Cursors.WaitCursor
            MAT_CONSOLIDADOTableAdapter.Update(IndicesDataSet.MAT_CONSOLIDADO)
            Cursor = Cursors.Default
            NOTIFICACION("SYS", "GUARDADO BASE DE DATOS")
        Catch ex As Exception
            MsgBox("NO SE PUDO GRABAR LA INFORMACION ANTERIOR EN LA BASE DE DATOS   " & ex.Message)
        End Try
    End Sub
    Private Sub CB_FECHA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FECHA.SelectedIndexChanged
        MES = ""
        If CB_FECHA.Text <> "(Seleccione)" Then
            Select Case CB_FECHA.SelectedItem
                Case "ENERO"
                    MES = "01"
                Case "FEBRERO"
                    MES = "02"
                Case "MARZO"
                    MES = "03"
                Case "ABRIL"
                    MES = "04"
                Case "MAYO"
                    MES = "05"
                Case "JUNIO"
                    MES = "06"
                Case "JULIO"
                    MES = "07"
                Case "AGOSTO"
                    MES = "08"
                Case "SETIEMBRE"
                    MES = "09"
                Case "OCTUBRE"
                    MES = "10"
                Case "NOVIEMBRE"
                    MES = "11"
                Case "DICIEMBRE"
                    MES = "12"
            End Select

        Else
            MsgBox("Seleccione un MES")
        End If
        AÑO = CB_ANIO.Text
    End Sub
    Private Sub FLITRA_CAMPOS()
        Dim VISTAMAT As DataView = IndicesDataSet.MAT_ACTIVOS.AsDataView
        CAMPO(0) = "ALIAS_ARTICULO"
        DATO(0) = TXT_ID_ART.Text
        If TXT_ID_ART.Text = "" Then
            FILTRO(0) = ""
        Else
            FILTRO(0) = "[" & CAMPO(0) & "] =" & DATO(0)
        End If

        CAMPO(1) = "NOMBRE_ARTICULO"
        DATO(1) = TXT_NOMBRE_ART.Text
        If TXT_NOMBRE_ART.Text = "" Then
            FILTRO(1) = ""
        Else
            If TXT_ID_ART.Text = "" Then
                FILTRO(1) = "[" & CAMPO(1) & "]   like '*" & DATO(1) & "*'"
            Else
                FILTRO(1) = " AND  [" & CAMPO(1) & "]  like '*" & DATO(1) & "*'"
            End If
        End If

        VISTAMAT.RowFilter = FILTRO(0) & FILTRO(1) '& FILTRO(2) ' & FILTRO(3) & FILTRO(4) & FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8)
        MAT_ACTIVOSBindingSource.DataSource = VISTAMAT
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
        Close()
    End Sub
    Private Sub BTN_BUSCAR_INFORME_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_INFORME.Click
        CALCULO_DE_INFORME()
        P_INFORME.Visible = True
        P_INFORME.BringToFront()
        'LBL_BINFORME.Visible = True
        'CB_BINFORME.Visible = True
        'BTN_BINFORME.Visible = True
    End Sub
    Private Sub BTN_BINFORME_Click(sender As Object, e As EventArgs) Handles BTN_BINFORME.Click
        If CB_BINFORME.Text <> "SELECCIONE" Then
            VER_INFORME_MATERIALES.MAT_INFORMETableAdapter.FillByFECHA(VER_INFORME_MATERIALES.INDICESDataSet.MAT_INFORME, CB_BINFORME.Text)
            If VER_INFORME_MATERIALES.Visible = False Then
                VER_INFORME_MATERIALES.Show(Me)
            End If
        Else
            MsgBox("SELECCIONE LA FECHA DEL REPORTE A VER")
        End If
    End Sub
    Private Sub TXT_NOMBRE_ART_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE_ART.TextChanged
        FLITRA_CAMPOS()
    End Sub
    Private Sub TXT_ID_ART_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID_ART.TextChanged
        FLITRA_CAMPOS()
    End Sub
    Private Sub BTN_ABRIR_CONSOLIDADO_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_CONSOLIDADO.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TXT_CONSOLIDADO.Text = OpenFileDialog1.FileName
        End If
    End Sub

    'TRANSITOS___________________________________________
    Private Sub BTN_AGREGAR_EXCEL_TRANISTO_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_EXCEL_TRANISTO.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TXT_TRANSITO.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub TRANSITODataGridView_DoubleClick(sender As Object, e As EventArgs) Handles TRANSITODataGridView.DoubleClick
        If TRANSITODataGridView.Rows.Count > 0 Then
            BTN_ACTUALIZAR_TRANSITO.Enabled = True
            TXT_ALIAS_TRANSITO.Enabled = True
            TXT_NOMBRE_TRANSITO.Enabled = True
            TXT_CANT_TRANSITO.Enabled = True
            DT_INI_TRANSITO.Enabled = True
            DT_FIN_TRANSITO.Enabled = True
            TRANSITORow = INDICESDataSet.MAT_TRANSITO.Rows(MAT_TRANSITOBindingSource.Position)
            If TRANSITORow IsNot Nothing Then
                TXT_ALIAS_TRANSITO.Text = TRANSITORow.COD_ALIAS
                TXT_NOMBRE_TRANSITO.Text = TRANSITORow.NOMBRE
                TXT_CANT_TRANSITO.Text = TRANSITORow.CANTIDAD
                DT_INI_TRANSITO.Value = TRANSITORow.FECHA_PEDIDO
                DT_FIN_TRANSITO.Value = TRANSITORow.FECHA_ARRIBO
            End If
        Else
            MsgBox("SIN REGISTROS")
        End If
    End Sub
    Private Sub BTN_ACTUALIZAR_TRANSITO_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR_TRANSITO.Click
        If TRANSITORow IsNot Nothing Then
            TRANSITORow.CANTIDAD = TXT_CANT_TRANSITO.Text
            TRANSITORow.FECHA_PEDIDO = DT_INI_TRANSITO.Value
            TRANSITORow.FECHA_ARRIBO = DT_FIN_TRANSITO.Value
            Try
                MAT_TRANSITOTableAdapter.Update(TRANSITORow)
                NOTIFICACION("OK", "REGISTRO MODIFICADO CORRECTAMENTE")
                BTN_ACTUALIZAR_TRANSITO.Enabled = False
                TXT_ALIAS_TRANSITO.Enabled = False
                TXT_NOMBRE_TRANSITO.Enabled = False
                TXT_CANT_TRANSITO.Enabled = False
                DT_INI_TRANSITO.Enabled = False
                DT_FIN_TRANSITO.Enabled = False
            Catch ex As Exception
                NOTIFICACION("ERR", "NO SE PUDO MODIFICAR REGISTRO")
            End Try
        End If
    End Sub
    Private Sub TRANSITODataGridView_Click(sender As Object, e As EventArgs) Handles TRANSITODataGridView.Click
        BTN_ACTUALIZAR_TRANSITO.Enabled = False
        TXT_ALIAS_TRANSITO.Enabled = False
        TXT_NOMBRE_TRANSITO.Enabled = False
        TXT_CANT_TRANSITO.Enabled = False
        DT_INI_TRANSITO.Enabled = False
        DT_FIN_TRANSITO.Enabled = False
    End Sub
    Private Sub BTN_AGREGAR_TRANSITO_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_TRANSITO.Click
        MAT_TRANSITOTableAdapter.FillByENTRE_FECHAS(INDICESDataSet.MAT_TRANSITO, Today.AddDays(-1).ToShortDateString, Today.ToShortDateString)
        BTN_AGREGAR_TRANSITO.BackColor = Color.Green
        BTN_AGREGAR_TRANSITO.ForeColor = Color.White
    End Sub
    Private Sub BTN_NUEVO_TRANSITO_MANUAL_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO_TRANSITO_MANUAL.Click
        If GB_NUEVO_TRANSITO.Visible = False Then
            MAT_ACTIVOSTableAdapter.FillByACTIVO(INDICESDataSet.MAT_ACTIVOS, "TRUE")
            For MAT = 0 To INDICESDataSet.MAT_ACTIVOS.Rows.Count - 1
                CB_ALIAS_TRANSITO.Items.Add(INDICESDataSet.MAT_ACTIVOS.Rows(MAT).Item("ALIAS_ARTICULO"))
                CB_NOMBRE_TRANSITO.Items.Add(INDICESDataSet.MAT_ACTIVOS.Rows(MAT).Item("NOMBRE_ARTICULO"))
            Next
        End If
        GB_NUEVO_TRANSITO.Visible = True
    End Sub
    Private Sub CB_ALIAS_TRANSITO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ALIAS_TRANSITO.SelectedIndexChanged
        MAT_ACTIVOSTableAdapter.FillByALIASACTIVO(INDICESDataSet.MAT_ACTIVOS, CB_ALIAS_TRANSITO.Text)
        CB_NOMBRE_TRANSITO.Text = INDICESDataSet.MAT_ACTIVOS.Rows(0).Item("NOMBRE_ARTICULO")
    End Sub
    Private Sub CB_NOMBRE_TRANSITO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NOMBRE_TRANSITO.SelectedIndexChanged
        MAT_ACTIVOSTableAdapter.FillByNOMBRE_ACTIVO(INDICESDataSet.MAT_ACTIVOS, CB_NOMBRE_TRANSITO.Text)
        CB_ALIAS_TRANSITO.Text = INDICESDataSet.MAT_ACTIVOS.Rows(0).Item("ALIAS_ARTICULO")
    End Sub
    Private Sub BTN_INGRESAR_TRANSITO_Click(sender As Object, e As EventArgs) Handles BTN_INGRESAR_TRANSITO.Click
        If CB_ALIAS_TRANSITO.Text <> "" Or CB_NOMBRE_TRANSITO.Text <> "" Or TXT_CANT_NUEVO_TRANSITO.Text <> "" Then
            MsgBox("COMPLETE LOS DATOS PARA REALIZAR EN NUEVO INGRESO")
            Exit Sub
        End If
        If DT_FIN_NUEVO_TRANSITO.Value > DT_INI_NUEVO_TRANSITO.Value Then
            MsgBox("LA FECHA DE ARRIBO DE LA MERCADERIA NO PUEDE SER MAYOR QUE LA DE SOLICITADA")
            Exit Sub
        End If

        Dim NEWTRANSITRow As INDICESDataSet.MAT_TRANSITORow = INDICESDataSet.MAT_TRANSITO.NewMAT_TRANSITORow()
        NEWTRANSITRow.COD_ALIAS = CB_ALIAS_TRANSITO.Text
        NEWTRANSITRow.NOMBRE = CB_NOMBRE_TRANSITO.Text
        NEWTRANSITRow.CANTIDAD = Trim(TXT_CANT_NUEVO_TRANSITO.Text)
        NEWTRANSITRow.FECHA_PEDIDO = DT_INI_NUEVO_TRANSITO.Value.ToShortDateString
        NEWTRANSITRow.FECHA_ARRIBO = DT_FIN_NUEVO_TRANSITO.Value.ToShortDateString
        INDICESDataSet.MAT_TRANSITO.AddMAT_TRANSITORow(NEWTRANSITRow)
        Try
            MAT_TRANSITOTableAdapter.Update(NEWTRANSITRow)
            MAT_TRANSITOTableAdapter.FillByENTRE_FECHAS(INDICESDataSet.MAT_TRANSITO, Today.AddDays(-1).ToShortDateString, Today.ToShortDateString)
            NOTIFICACION("OK", "REGISTRO INGRESADO CORRECTAMENTE")
        Catch ex As Exception
            NOTIFICACION("ERR", "NO SE PUDO AGREGAR REGISTRO")
        End Try
    End Sub
    Private Sub BTN_CALCULAR_PROMEDIO_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR_PROMEDIO.Click
        Dim CANT_MATERIAL As Integer


        MAT_ACTIVOSTableAdapter.FillByACTIVO(IndicesDataSet.MAT_ACTIVOS, True)
        For Each MATERIAL In IndicesDataSet.MAT_ACTIVOS

            CANT_MATERIAL = 0

            MAT_CONSUMOSXMESTableAdapter.FillByART_MES_ANIO(IndicesDataSet.MAT_CONSUMOSXMES, MATERIAL.ALIAS_ARTICULO, CInt(MES), AÑO)
            If IndicesDataSet.MAT_CONSUMOSXMES.Rows.Count > 0 Then
                txt_id.Text = "CALCULANDO PARA " & MATERIAL.ALIAS_ARTICULO & " - " & MATERIAL.NOMBRE_ARTICULO & " YA EXISTE REGISTRO!!"
                txt_id.Refresh()
            Else
                MAT_CONSOLIDADOTableAdapter.FillByFECHAYARTICULO(IndicesDataSet.MAT_CONSOLIDADO, "1/" & MES & "/2023", "1/1/" & AÑO, MATERIAL.ALIAS_ARTICULO)
                For X = 0 To IndicesDataSet.MAT_CONSOLIDADO.Rows.Count - 1
                    CANT_MATERIAL += IndicesDataSet.MAT_CONSOLIDADO.Rows(X).Item("CANTIDAD")
                Next
                txt_id.Text = "CALCULANDO PARA " & MATERIAL.ALIAS_ARTICULO & " - " & MATERIAL.NOMBRE_ARTICULO
                txt_id.Refresh()
                Dim NEWCONSUMORow = IndicesDataSet1.MAT_CONSUMOSXMES.NewMAT_CONSUMOSXMESRow
                NEWCONSUMORow.ANIO = CB_ANIO.Text
                NEWCONSUMORow.CONSUMO = CANT_MATERIAL
                NEWCONSUMORow.FECHA_INGRESADO = Today
                NEWCONSUMORow.ID_MATERIAL = MATERIAL.ALIAS_ARTICULO
                NEWCONSUMORow.INGRESADOX = FULLNOMBRE
                NEWCONSUMORow.MES = CInt(MES)
                IndicesDataSet1.MAT_CONSUMOSXMES.AddMAT_CONSUMOSXMESRow(NEWCONSUMORow)
            End If
        Next
        txt_id.Text = "LISTO"
        txt_id.Refresh()
        MAT_CONSUMOSXMESTableAdapter.Update(IndicesDataSet1.MAT_CONSUMOSXMES)

    End Sub

End Class