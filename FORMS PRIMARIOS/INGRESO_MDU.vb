Public Class INGRESO_MDU

    Dim NewEDIFICIO As MDUDataSet.EdificiosRow
    Dim ActEDIFICIO As DataRow
    Dim GESTION As ORDENESDataSet.GESTIONRow
    Dim TRABAJO As ORDENESDataSet.TRABAJOSRow
    Dim EDIF As MDUDataSet.REPORTERow
    Dim MDU As New DataSet()
    Dim NUEVO_REG As MDUDataSet.REPORTERow
    Dim DIA_SEMANA As String

    Dim POSX As Integer
    Dim POSY As Integer
    Dim FECHA_INIGEST As Date
    Dim GRAF_GESTION As Integer
    Dim TRABAJOSRow As DataRow

    Dim NUEVOEDIFICIO As MDUDataSet.EdificiosRow
    Dim NUEVACALLE As MDUDataSet.CallesRow

    Dim EDIFICIO_ID As Integer
    Dim TIPO_GEST As String
    Dim TIPO_GESTABR As String

    Dim Campo(10) As String
    Dim Expre(10) As String
    Dim Filtr(10) As String

    Dim PRINCampo(10) As String
    Dim PRINExpre(10) As String
    Dim PRINFiltr(10) As String

    Dim CampoCalle(3) As String
    Dim ExpreCalle(3) As String
    Dim FiltrCalle(3) As String

    Dim GRUPOFILTRO As String

    Dim ACCION As String




    Dim FECHAFINAL_ESTIMADA As Date
    Dim FECHAFINAL_REAL As Date
    Dim FECHAINICIO_REAL As Date
    Dim FECHAINICIO_ESTIMADO As Date
    Dim TIEMPO_ESTIMADO As Integer

    'BUSCA LAS GESTIONES NO FINALIZADAS

    '  Dim VAR_EST As Integer
    Dim VAR_DEM As Integer

    'Private Sub EdificiosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EdificiosBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.EdificiosBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.MDUDataSet)
    'End Sub
    Private Sub INGRESO_DATOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If THEME_BLACK Then
            ' Panel1.BackColor = Color.FromArgb(64, 64, 64)
            Panel2.BackColor = Color.FromArgb(64, 64, 64)
            BackColor = Color.FromArgb(64, 64, 64)
            '        DGV_MDU.BackgroundColor = Color.FromArgb(64, 64, 64)
            '        ORDENESDataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
            '        GroupBox2.ForeColor = Color.White
            '        GroupBox1.BackColor = Color.FromArgb(64, 64, 64)
            '        DGV_MDU.RowsDefaultCellStyle.ForeColor = Color.White
            '        DGV_MDU.RowsDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            '        ORDENESDataGridView.RowsDefaultCellStyle.ForeColor = Color.White
            '        ORDENESDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            '        ORDENESDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White
            '        ORDENESDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64)
        End If

        Me.Refresh()
        DASHBOARD.Cursor = Cursors.WaitCursor
        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        EdificiosTableAdapter.Fill(MDUDataSet.Edificios)

        Me.EdificiosBindingSource.MoveFirst()
        GESTIONTableAdapter.FillByMDU(ORDENESDataSet.GESTION)
        GESTIONTableAdapter.FillByMANT_aCTIVO(MANT_OrdenesDataSet.GESTION)
        ' PINTA_EDIFICIOS()
        CONDICION_INICIAL()
        ' GRUPOFILTRO = "AND"
        FECHA_INIGEST = Now.ToShortDateString
        'GRAF_INGREGEST.Text = "Fecha de hoy: " & FECHA_INIGEST.ToLongDateString
        'LBL_FINEST.Visible = False

        DASHBOARD.Cursor = DefaultCursor
    End Sub
    'Private Sub DGVMDU()
    '    MDUDataSet.REPORTE.Clear()
    '    DGV_MDU.DataSource = MDUDataSet.REPORTE
    '    CURSOR_WAIT(True, Me)
    '    GESTIONTableAdapter.FillByNOSTATUS(ORDENESDataSet.GESTION, "FINALIZADO", TIPO_GEST)
    '    ' CANTGEST.Value = 0
    '    If ORDENESDataSet.GESTION.Rows.Count > 0 Then
    '        '  CANTGEST.Maximum = ORDENESDataSet.GESTION.Rows.Count
    '        For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
    '            ' CANTGEST.Value += I
    '            GESTION = ORDENESDataSet.GESTION.Rows(I)
    '            NUEVO_REG = MDUDataSet.REPORTE.NewREPORTERow
    '            NUEVO_REG.ID_GEST = GESTION("Id_GESTION")
    '            NUEVO_REG.DIRECCION = GESTION("CALLE") & "  " & GESTION("NUMERO")
    '            NUEVO_REG.GEST_STS = GESTION("STATUS")

    '            'BUSCA TRABAJOS DEFINIDOS EN LA GESTION
    '            TRABAJOSTableAdapter.FillByIDGESTIONNOCANCELADO(ORDENESDataSet.TRABAJOS, GESTION.Id_GESTION)
    '            If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    Select Case TRABAJO.TIPOTRABAJO
    '                        Case "RELEVAMIENTO"
    '                            NUEVO_REG.RELEVAMIENTO = TRABAJO.STATUS
    '                        Case "DISEÑO"
    '                            NUEVO_REG.DISEÑO = TRABAJO.STATUS
    '                        Case "PRESUPUESTO"
    '                            NUEVO_REG.PRESUPUESTO = TRABAJO.STATUS
    '                        Case "APROBACION PERMISOS"
    '                            NUEVO_REG.APROB_PERMISORES = TRABAJO.STATUS
    '                        Case "APROBACION IMM"
    '                            NUEVO_REG.APROB_IMM = TRABAJO.STATUS
    '                        Case "AUTORIZACION CABLEADO"
    '                            NUEVO_REG.AUTO_CABLEADO = TRABAJO.STATUS
    '                        Case "OBRA CIVIL"
    '                            NUEVO_REG.OBRA_CIVIL = TRABAJO.STATUS
    '                        Case "ASOCIADO A RED", "GESTION RED"
    '                            NUEVO_REG.ASOC_RED = TRABAJO.STATUS
    '                        Case "EJECUCION"
    '                            NUEVO_REG.EJECUCION = TRABAJO.STATUS
    '                        Case "ACTUALIZACION PLANOS"
    '                            NUEVO_REG.ACT_PLANOS = TRABAJO.STATUS
    '                    End Select
    '                Next
    '            End If
    '            MDUDataSet.REPORTE.AddREPORTERow(NUEVO_REG)
    '        Next
    '    End If
    '    'ARMAMOS EL DATAGRID PARA MOSTRAR LA INFORMACION
    '    If MDUDataSet.REPORTE.Rows.Count > 0 Then
    '        DGV_MDU.DataSource = MDUDataSet.REPORTE
    '        DGV_MDU.Columns("DIRECCION").Visible = False
    '        DGV_MDU.Columns("GEST_STS").Visible = False
    '        DGV_MDU.Columns("ID_GEST").Visible = False
    '        DGV_MDU.Columns("RELEVAMIENTO").Visible = False
    '        DGV_MDU.Columns("DISEÑO").Visible = False
    '        DGV_MDU.Columns("PRESUPUESTO").Visible = False
    '        DGV_MDU.Columns("APROB_PERMISORES").Visible = False
    '        DGV_MDU.Columns("APROB_IMM").Visible = False
    '        DGV_MDU.Columns("AUTO_CABLEADO").Visible = False
    '        DGV_MDU.Columns("OBRA_CIVIL").Visible = False
    '        DGV_MDU.Columns("ASOC_RED").Visible = False
    '        DGV_MDU.Columns("EJECUCION").Visible = False
    '        DGV_MDU.Columns("ACT_PLANOS").Visible = False
    '        DGV_MDU.Visible = True

    '        For X = 0 To MDUDataSet.REPORTE.Rows.Count - 1
    '            EDIF = MDUDataSet.REPORTE.Rows(X)
    '            DGV_MDU.Item(0, X).Value = EDIF.DIRECCION
    '            DGV_MDU.Item(0, X).Style.Alignment = ContentAlignment.MiddleCenter
    '            DGV_MDU.Columns(0).Width = 250
    '            DGV_MDU.Item(1, X).Value = EDIF.ID_GEST
    '            DGV_MDU.Item(1, X).Style.Alignment = ContentAlignment.MiddleCenter
    '            DGV_MDU.Columns(1).Width = 45

    '            Select Case EDIF.GEST_STS
    '                Case "INGRESADO"
    '                    DGV_MDU.Item(1, X).Style.BackColor = Color.DarkGreen
    '                Case "INICIADO"
    '                    DGV_MDU.Item(1, X).Style.BackColor = Color.Yellow
    '                Case "DEMORADO"
    '                    DGV_MDU.Item(1, X).Style.BackColor = Color.Red
    '            End Select
    '            If EDIF.IsRELEVAMIENTONull Then
    '                DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.RELEVAMIENTO
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(2).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(2).HeaderText = "RELE"
    '            DGV_MDU.Columns(2).Width = 45
    '            DGV_MDU.Columns(3).Visible = False
    '            If EDIF.IsDISEÑONull Then
    '                DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.DISEÑO
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(4).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(4).Width = 45
    '            DGV_MDU.Columns(4).HeaderText = "DISE"
    '            If EDIF.IsPRESUPUESTONull Then
    '                DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.PRESUPUESTO
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(5).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(5).Width = 45
    '            DGV_MDU.Columns(5).HeaderText = "PRES"
    '            If EDIF.IsAPROB_PERMISORESNull Then
    '                DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.APROB_PERMISORES
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(6).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(6).Width = 45
    '            DGV_MDU.Columns(6).HeaderText = "APER"
    '            If EDIF.IsAPROB_IMMNull Then
    '                DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.APROB_IMM
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(7).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(7).Width = 45
    '            DGV_MDU.Columns(7).HeaderText = "AIMM"
    '            If EDIF.IsAUTO_CABLEADONull Then
    '                DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.AUTO_CABLEADO
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(8).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(8).Width = 45
    '            DGV_MDU.Columns(8).HeaderText = "ACAB"
    '            If EDIF.IsOBRA_CIVILNull Then
    '                DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.OBRA_CIVIL
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(9).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(9).Width = 45
    '            DGV_MDU.Columns(9).HeaderText = "OBCI"

    '            If EDIF.IsASOC_REDNull Then
    '                DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.ASOC_RED
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(10).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(10).Width = 45
    '            DGV_MDU.Columns(10).HeaderText = "ARED"

    '            If EDIF.IsEJECUCIONNull Then
    '                DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case Trim(EDIF.EJECUCION)
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_VIOLETA)
    '                    Case "CANCELADO"
    '                        DGV_MDU.Rows(X).Cells(11).Value = New Bitmap(CIRCULO_NEGRO)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(11).Width = 45
    '            DGV_MDU.Columns(11).HeaderText = "EJEC"
    '            If EDIF.IsACT_PLANOSNull Then
    '                DGV_MDU.Rows(X).Cells(12).Value = New Bitmap(CIRCULO_NEGRO)
    '            Else
    '                Select Case EDIF.ACT_PLANOS
    '                    Case "INGRESADO"
    '                        DGV_MDU.Rows(X).Cells(12).Value = New Bitmap(CIRCULO_VERDE)
    '                    Case "INICIADO"
    '                        DGV_MDU.Rows(X).Cells(12).Value = New Bitmap(CIRCULO_AMARILLO)
    '                    Case "DEMORADO"
    '                        DGV_MDU.Rows(X).Cells(12).Value = New Bitmap(CIRCULO_ROJO)
    '                    Case "FINALIZADO"
    '                        DGV_MDU.Rows(X).Cells(12).Value = New Bitmap(CIRCULO_VIOLETA)
    '                End Select
    '            End If
    '            DGV_MDU.Columns(12).Width = 45
    '            DGV_MDU.Columns(12).HeaderText = "APLA"
    '        Next

    '    End If
    '    CURSOR_WAIT(False, Me)
    'End Sub
    Private Sub INGRESO_DATOS_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '  DIBUJA_FONDO()

    End Sub
    Private Sub BLOQUEA_FILTROS()
        NROCARPETA.Enabled = False
        CALLEPRIN.Enabled = False
        NROPRIN.Enabled = False
        GESTMAN.Enabled = False
        GESTOBRA.Enabled = False
    End Sub
    Private Sub HABILITA_FILTROS()
        NROCARPETA.Enabled = True
        CALLEPRIN.Enabled = True
        NROPRIN.Enabled = True
        GESTMAN.Enabled = True
        GESTOBRA.Enabled = True
    End Sub
    Private Sub CONDICION_INICIAL()
        BOT_GRABARMDU.Enabled = False
        BOT_CANCELAR.Enabled = False
        BOT_PROCESAR.Enabled = False
        BOT_VERHISTORIAL.Enabled = True
        BORRA_CAMPOS()
        DESHABILITA_CAMPOS()
    End Sub
    Private Sub DESHABILITA_CAMPOS()
        BOX_NOMBREEDIFICIO.ReadOnly = True
        BOX_CALLE.ReadOnly = True
        BOX_NRO.ReadOnly = True
        BOX_CARPETA.ReadOnly = True
        BOX_CARPETAP.ReadOnly = True
        BOX_PISOS.ReadOnly = True
        BOX_VIV.ReadOnly = True
        BOX_TIPO.Enabled = False
        BOX_NODO.Enabled = False
        BOX_ZONA.ReadOnly = False
        CallesDataGridView1.Enabled = False
    End Sub
    Private Sub HABILITA_CAMPOS()

        BOX_NOMBREEDIFICIO.ReadOnly = False
        BOX_CALLE.ReadOnly = False
        BOX_NRO.ReadOnly = False
        BOX_CARPETA.ReadOnly = False
        BOX_CARPETAP.ReadOnly = False
        BOX_PISOS.ReadOnly = False
        BOX_VIV.ReadOnly = False

        BOX_TIPO.Enabled = True
        BOX_NODO.Enabled = True

        BOX_ZONA.Enabled = True
        CallesDataGridView1.Enabled = True

    End Sub
    Private Sub BORRA_CAMPOS()

        BOX_NOMBREEDIFICIO.Text = ""
        BOX_CALLE.Text = ""
        BOX_NRO.Text = ""
        BOX_CARPETA.Text = ""
        BOX_CARPETAP.Text = ""
        BOX_PISOS.Text = ""
        BOX_VIV.Text = ""


        BOX_NODO.Text = ""
        BOX_ZONA.Text = ""

    End Sub
    Private Sub GRABAR_MDU()

        If ACCION = "NUEVO" Then
            NewEDIFICIO = MDUDataSet.Edificios.NewRow
            NewEDIFICIO("NOMBREEDIFICIO") = BOX_NOMBREEDIFICIO.Text
            NewEDIFICIO("CALLE") = BOX_CALLE.Text
            NewEDIFICIO("TIPODIR") = BOX_TIPO.Text
            NewEDIFICIO("NROPUERTA") = BOX_NRO.Text
            NewEDIFICIO("CARPETA") = BOX_CARPETA.Text
            NewEDIFICIO("CARPETAP") = BOX_CARPETAP.Text
            NewEDIFICIO("PISOS") = BOX_PISOS.Text
            NewEDIFICIO("APTOS") = BOX_VIV.Text
            NewEDIFICIO("GESTMANT") = False
            NewEDIFICIO("GESTOBR") = False
            NewEDIFICIO("NODO") = BOX_NODO.Text
            NewEDIFICIO("ZONA") = BOX_ZONA.Text


            Me.MDUDataSet.Edificios.AddEdificiosRow(NewEDIFICIO)
            Me.EdificiosTableAdapter.Update(NewEDIFICIO)
        End If

        If ACCION = "EDITAR" Then
            For I = 0 To MDUDataSet.Edificios.Rows.Count - 1

                If MDUDataSet.Edificios.Rows(I).Item("CARPETA") = BUSCA_CARP Then
                    ActEDIFICIO = MDUDataSet.Edificios.Rows(I)
                    ActEDIFICIO("NOMBREEDIFICIO") = BOX_NOMBREEDIFICIO.Text
                    ActEDIFICIO("TIPODIR") = BOX_TIPO.Text
                    ActEDIFICIO("CALLE") = BOX_CALLE.Text
                    ActEDIFICIO("NROPUERTA") = BOX_NRO.Text
                    ActEDIFICIO("CARPETA") = BOX_CARPETA.Text
                    'ActEDIFICIO("STSCARPETA") = BOX_CARPETAP.Text
                    ActEDIFICIO("PISOS") = BOX_PISOS.Text
                    ActEDIFICIO("APTOS") = BOX_VIV.Text
                    'ActEDIFICIO("CABLEADO") = BOX_CABLEADO.Text

                    ActEDIFICIO("NODO") = BOX_NODO.Text
                    ActEDIFICIO("ZONA") = BOX_ZONA.Text

                    EdificiosTableAdapter.Update(ActEDIFICIO)

                End If
            Next I
        End If


        CONDICION_INICIAL()
        EdificiosDataGridView.Enabled = True
        HABILITA_FILTROS()
    End Sub
    Private Sub CARGA_BOXEDIFICIO()
        'CARGA LOS VALORES DEL EDIFICIO SELECCIONADO EN LOS CAMPOS DE EDICION O SELECCION DE EDIFICIO, BUSCA LA CARPETA QUE COINCIDA CON BUSCA_CARP
        For I = 0 To MDUDataSet.Edificios.Rows.Count - 1
            '
            If MDUDataSet.Edificios.Rows(I).Item("CARPETA") = BUSCA_CARP Then
                If IsDBNull(MDUDataSet.Edificios.Rows(I).Item("NOMBREEDIFICIO")) = False Then BOX_NOMBREEDIFICIO.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("NOMBREEDIFICIO"))
                BOX_CALLE.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("CALLE"))

                If IsDBNull(MDUDataSet.Edificios.Rows(I).Item("NROPUERTA")) = False Then
                    BOX_NRO.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("NROPUERTA"))
                Else
                    BOX_NRO.Text = ""
                End If

                BOX_CARPETA.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("CARPETA"))
                'BOX_CARPETAP.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("STSCARPETA"))
                BOX_PISOS.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("PISOS"))
                BOX_VIV.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("APTOS"))
                BOX_NODO.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("NODO"))
                BOX_ZONA.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("ZONA"))
                BOX_TIPO.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("TIPODIR"))
                If IsDBNull(MDUDataSet.Edificios.Rows(I).Item("NOMBREEDIFICIO")) = False Then BOX_NOMBREEDIFICIO.Text = Trim(MDUDataSet.Edificios.Rows(I).Item("NOMBREEDIFICIO"))
            End If
        Next I
    End Sub
    Private Sub FILTRA_CALLE()
        Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = BOX_CALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        CallesDataGridView1.DataSource = VISTACALLE
    End Sub
    Private Sub FILTRA_PRINCIPAL()

        Dim VISTAPRIM As DataView = MDUDataSet.Edificios.AsDataView

        PRINCampo(0) = "CARPETA"
        PRINExpre(0) = NROCARPETA.Text
        PRINFiltr(0) = "[" & PRINCampo(0) & "] like '*" & PRINExpre(0) & "*'"

        PRINCampo(1) = "CALLE"
        PRINExpre(1) = CALLEPRIN.Text
        PRINFiltr(1) = " AND  [" & PRINCampo(1) & "] like '*" & PRINExpre(1) & "*'"

        PRINCampo(2) = "NROPUERTA"
        PRINExpre(2) = NROPRIN.Text
        PRINFiltr(2) = " AND  [" & PRINCampo(2) & "] like '*" & PRINExpre(2) & "*'"

        PRINCampo(3) = ("GESTMANT")
        PRINExpre(3) = GESTMAN.Checked
        If GESTMAN.Checked = False Then
            PRINFiltr(3) = ""
        Else
            PRINFiltr(3) = " AND  [" & PRINCampo(3) & "] =" & PRINExpre(3)
        End If

        PRINCampo(4) = ("GESTOBR")
        PRINExpre(4) = GESTOBRA.Checked
        If GESTOBRA.Checked = False Then
            PRINFiltr(4) = ""
        Else
            PRINFiltr(4) = " " & GRUPOFILTRO & "  [" & PRINCampo(4) & "] = " & PRINExpre(4)
        End If


        VISTAPRIM.RowFilter = PRINFiltr(0) & PRINFiltr(1) & PRINFiltr(2) & PRINFiltr(3) & PRINFiltr(4)
        'MsgBox(GRUPOFILTRO)
        EdificiosBindingSource.DataSource = VISTAPRIM
        '  PINTA_EDIFICIOS()

    End Sub
    'Private Sub CARGA_CALLES()

    '    For I = 0 To MDUDataSet.MDUBASE.Rows.Count - 2
    '        If MDUDataSet.MDUBASE.Rows(I).Item("Calle") <> MDUDataSet.MDUBASE.Rows(I + 1).Item("Calle") Then
    '            NUEVACALLE = MDUDataSet.Calles.NewCallesRow
    '            NUEVACALLE("NOMBRECALLE") = MDUDataSet.MDUBASE.Rows(I).Item("Calle")
    '            Me.MDUDataSet.Calles.Rows.Add(NUEVACALLE)
    '        End If
    '    Next
    '    Me.CallesTableAdapter.Update(MDUDataSet.Calles)
    'End Sub
    'Private Sub PINTA_EDIFICIOS()
    '    If EdificiosDataGridView.Rows.Count > 0 Then
    '        For I = 0 To EdificiosDataGridView.Rows.Count - 1
    '            If EdificiosDataGridView.Rows(I).Cells.Item(4).Value = "S" Then
    '                EdificiosDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.Gray

    '            Else
    '                EdificiosDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.MintCream

    '            End If

    '            If EdificiosDataGridView.Rows(I).Cells.Item(7).Value = True Then
    '                EdificiosDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.LightSalmon
    '            End If
    '            If EdificiosDataGridView.Rows(I).Cells.Item(8).Value = True Then
    '                EdificiosDataGridView.Rows(I).DefaultCellStyle.ForeColor = Color.LightGreen
    '            End If
    '        Next
    '    End If
    'End Sub
    'Private Sub BOT_CARGAR_Click(sender As Object, e As EventArgs)
    '    CARGA_CALLES()
    'End Sub

    Private Sub BOX_CARPETA_TextChanged(sender As Object, e As EventArgs) Handles BOX_CARPETA.TextChanged
        If BOX_CARPETA.Text = "" Then BOT_VERHISTORIAL.Enabled = False Else BOT_VERHISTORIAL.Enabled = True
    End Sub
    Private Sub BOT_VERHISTORIAL_Click(sender As Object, e As EventArgs) Handles BOT_VERHISTORIAL.Click

        ACCESO_TIPO = "CARPETA"
        ABRIR_DATOS()
        'HISTORIAL.Show()
    End Sub
    Private Sub ABRIR_DATOS()
        If DATOS.Visible = True Then
            DATOS.Close()
            If THEME_BLACK Then
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
            Else
                DASHBOARD.BTN_RED.BackgroundImage = My.Resources.RED
                DASHBOARD.BTN4Close.Visible = False
            End If

        End If
        INGRESO_AREA = "MDU"
        ACCESO_DESDE = "MDU"

        DATOS.TopLevel = False
        DATOS.Parent = DASHBOARD.PanelTrabajo
        DATOS.AutoSize = True
        DATOS.Dock = DockStyle.Fill
        DATOS.Show()
        DATOS.BringToFront()

        DATOS.Location = New Point(0, 0)
    End Sub
    Private Sub BOX_TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOX_TIPO.SelectedIndexChanged
        If BOX_TIPO.Text = "S" Then
            BOX_CARPETAP.Visible = True
        Else
            BOX_CARPETAP.Visible = False
        End If
    End Sub
    Private Sub BOT_GRABARMDU_Click(sender As Object, e As EventArgs) Handles BOT_GRABARMDU.Click
        GRABAR_MDU()
    End Sub
    'RUTINAS PARA MANEJAR LOS FILTROS DE MANTENIMIENTO Y OBRA
    Private Sub TIPO_FILTRO()
        If GESTMAN.Checked = GESTOBRA.Checked Then
            If GESTMAN.Checked = True Then
                GRUPOFILTRO = "OR"
            End If
        Else
            GRUPOFILTRO = "AND"
        End If
    End Sub
    Private Sub GESTMAN_CheckedChanged(sender As Object, e As EventArgs) Handles GESTMAN.CheckedChanged
        TIPO_FILTRO()
        FILTRA_PRINCIPAL()
    End Sub
    Private Sub GESTOBRA_CheckedChanged(sender As Object, e As EventArgs) Handles GESTOBRA.CheckedChanged
        TIPO_FILTRO()
        FILTRA_PRINCIPAL()
    End Sub
    Private Sub BOT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BOT_CANCELAR.Click
        CONDICION_INICIAL()
        EdificiosDataGridView.Enabled = True
        HABILITA_FILTROS()
    End Sub
    Private Sub BOT_CANFILTRO_Click(sender As Object, e As EventArgs) Handles BOT_CANFILTRO.Click
        BORRA_CAMPOS()
        GESTMAN.Checked = False
        GESTOBRA.Checked = False
        CALLEPRIN.Text = ""
        NROPRIN.Text = ""
        NROCARPETA.Text = ""
    End Sub
    Private Sub EdificiosDataGridView_Click(sender As Object, e As MouseEventArgs) Handles EdificiosDataGridView.Click
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'CARGA EL DATAROW DE TRABAJOS
            If EdificiosDataGridView.Rows.Count > 0 Then
                EdificiosDataGridView.ContextMenuStrip = MENU_EDIFICIOS
            End If
        End If
    End Sub
    Private Sub EdificiosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles EdificiosDataGridView.SelectionChanged

        If EdificiosDataGridView.Rows.Count > 0 Then
            '  BUSCA_PRIM = Me.EdificiosDataGridView.CurrentRow.Cells.Item(0).Value
            BUSCA_CARP = Me.EdificiosDataGridView.CurrentRow.Cells.Item(5).Value
            'CARGA LA VARIABLE BUSCAPRIM CON LA CARPETA PRIMARIA EL EDIFICIO
            If Me.EdificiosDataGridView.CurrentRow.Cells.Item(4).Value = "P" Then
                BUSCA_PRIM = Me.EdificiosDataGridView.CurrentRow.Cells.Item(5).Value
            Else
                BUSCA_PRIM = Me.EdificiosDataGridView.CurrentRow.Cells.Item(6).Value
            End If
            NODO_MDU = Me.EdificiosDataGridView.CurrentRow.Cells.Item(0).Value
            ZONA_MDU = Me.EdificiosDataGridView.CurrentRow.Cells.Item(1).Value
            DIRECCION_MDU = Me.EdificiosDataGridView.CurrentRow.Cells.Item(2).Value
            NUMERO_MDU = Me.EdificiosDataGridView.CurrentRow.Cells.Item(3).Value
            'BORRA_CAMPOS()
            CARGA_BOXEDIFICIO()

            End If
    End Sub
    Private Sub BOX_CALLE_TextChanged(sender As Object, e As EventArgs) Handles BOX_CALLE.TextChanged
        FILTRA_CALLE()
    End Sub
    Private Sub CallesDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CallesDataGridView1.CellClick
        BOX_CALLE.Text = Trim(Me.CallesDataGridView1.CurrentCell.Value.ToString)
    End Sub
    Private Sub NROCARPETA_TextChanged(sender As Object, e As EventArgs) Handles NROCARPETA.TextChanged
        If NROCARPETA.Text <> "" Then
            NROCARPETA.BackColor = Color.DarkGreen
            NROCARPETA.ForeColor = Color.Gainsboro
        Else
            NROCARPETA.BackColor = Color.Gainsboro
            NROCARPETA.ForeColor = Color.DarkGreen
        End If
        FILTRA_PRINCIPAL()
    End Sub
    Private Sub CALLEPRIN_TextChanged(sender As Object, e As EventArgs) Handles CALLEPRIN.TextChanged
        If CALLEPRIN.Text <> "" Then
            CALLEPRIN.BackColor = Color.DarkGreen
            CALLEPRIN.ForeColor = Color.Gainsboro
        Else
            CALLEPRIN.BackColor = Color.Gainsboro
            CALLEPRIN.ForeColor = Color.DarkGreen
        End If
        FILTRA_PRINCIPAL()
    End Sub
    Private Sub NROPRIN_TextChanged(sender As Object, e As EventArgs) Handles NROPRIN.TextChanged
        If NROPRIN.Text <> "" Then
            NROPRIN.BackColor = Color.DarkGreen
            NROPRIN.ForeColor = Color.Gainsboro
        Else
            NROPRIN.BackColor = Color.Gainsboro
            NROPRIN.ForeColor = Color.DarkGreen
        End If
        FILTRA_PRINCIPAL()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MANT_CHECK.CheckedChanged
        BOT_PROCESAR.Enabled = True
        TIPO_GEST = "Mant Preventivo"
        TIPO_GESTABR = "MANT"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles OBR_CHECK.CheckedChanged
        BOT_PROCESAR.Enabled = True
        TIPO_GEST = "Obra Nueva"
        TIPO_GESTABR = "OBRA"
    End Sub
    'Private Sub BOT_PROCESAR_Click(sender As Object, e As EventArgs) Handles BOT_PROCESAR.Click
    '    DGVMDU()
    'End Sub
    'Private Sub PINTA_GRILLA()
    '    Dim CALLEYNRO As String
    '    Dim STATUS As String
    '    For I = 0 To ANALISISGESTDataGridView.Rows.Count - 1
    '        For X = 0 To 39
    '            CALLEYNRO = "Edificio situado en: " & ANALISISGESTDataGridView.Item(4, I).Value & ANALISISGESTDataGridView.Item(5, I).Value
    '            If IsDBNull(ANALISISGESTDataGridView.Item(X, I).Value) = False Then
    '                'VERIFICA EL STATUS DE LA GESTION
    '                Select Case X
    '                    Case 2, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33
    '                        STATUS = ANALISISGESTDataGridView.Item(X, I).Value

    '                        Select Case STATUS
    '                            Case "ING"
    '                                'ANALISISGESTDataGridView.Item(M, I).Style.BackColor = Color.Green
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Yellow
    '                            Case "INI"
    '                                'ANALISISGESTDataGridView.Item(M, I).Style.BackColor = Color.Yellow
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Green
    '                            Case "FIN"
    '                                'ANALISISGESTDataGridView.Item(M, I).Style.BackColor = Color.DarkViolet
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Cyan
    '                            Case "DEM"
    '                                'ANALISISGESTDataGridView.Item(M, I).Style.BackColor = Color.DarkBlue
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.LightCoral
    '                            Case "COO"
    '                                'ANALISISGESTDataGridView.Item(X, I).Style.BackColor = Color.Orange
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Orange
    '                        End Select

    '                        'PINTA LOS CAMPOS DE DIAS REALES UTILIZADOS
    '                    Case 8, 11, 14, 17, 20, 23, 26, 29, 32, 35


    '                        If IsDBNull(ANALISISGESTDataGridView.Item(X - 1, I).Value) = False Then
    '                            If ANALISISGESTDataGridView.Item(X, I).Value <= ANALISISGESTDataGridView.Item(X - 1, I).Value Then
    '                                'ANALISISGESTDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Green
    '                            End If
    '                        Else
    '                            'MsgBox(CALLEYNRO)
    '                        End If

    '                        If IsDBNull(ANALISISGESTDataGridView.Item(X - 1, I).Value) = False Then
    '                            If ANALISISGESTDataGridView.Item(X, I).Value > ANALISISGESTDataGridView.Item(X - 1, I).Value Then
    '                                'ANALISISGESTDataGridView.Item(X, I).Style.BackColor = Color.LightPink
    '                                ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Red
    '                            Else
    '                                'MsgBox(CALLEYNRO)
    '                            End If
    '                        End If

    '                    Case 39

    '                        If ANALISISGESTDataGridView.Item(X, I).Value <= 0 Then
    '                            'ANALISISGESTDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
    '                            ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Green
    '                        End If

    '                        If ANALISISGESTDataGridView.Item(X, I).Value > 1 Then
    '                            'ANALISISGESTDataGridView.Item(X, I).Style.BackColor = Color.LightPink
    '                            ANALISISGESTDataGridView.Item(X, I).Style.ForeColor = Color.Red
    '                        End If


    '                End Select
    '            End If
    '        Next X
    '    Next I
    'End Sub
    'Private Sub ANALISISGESTDataGridView_Click(sender As Object, e As MouseEventArgs) Handles ANALISISGESTDataGridView.Click

    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        'CARGA EL DATAROW DE TRABAJOS
    '        If ANALISISGESTDataGridView.Rows.Count > 0 Then
    '            ANALISISGESTDataGridView.ContextMenuStrip = MENU_ANALISIS
    '            Cursor = Cursors.WaitCursor
    '            GRAF_GESTION = ANALISISGESTDataGridView.CurrentRow.Cells.Item(0).Value

    '            'BUSCA LA GESTION SELECCIONADA MEDIANTE EL ID DE LA GESTION
    '            Me.GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, GRAF_GESTION)

    '            FECHA_INIGEST = Format(CDate(ORDENESDataSet.GESTION.Rows(0).Item("FECHAINGRESADA")), "dd/MM/yyyy")
    '            GRAF_INGREGEST.Text = "Ingreso de Gestion: " & FECHA_INIGEST.ToLongDateString

    '            Me.TRABAJOSTableAdapter.FillByIDGESTIONNOCANCELADO(ORDENESDataSet.TRABAJOS, GRAF_GESTION)
    '            PINTA_GRAF()
    '            Cursor = DefaultCursor
    '        End If
    '    End If


    'End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'ControlGestion.Show(Me)
    End Sub
    Private Sub DIBUJA_GRILLA()

        'Dim GRILLA As Graphics = Me.CreateGraphics()
        'Dim BLANCO As New Pen(Color.White, 1)
        'Dim GRIS As New Pen(Color.Silver, 6)
        'Dim VERDE As New Pen(Color.LightGreen, 10)
        'Dim FONDO As New Pen(Color.Silver, 210)
        'Dim LINEA As New Pen(Color.DimGray, 1)
        'Dim GRISCLARO As New Pen(Color.DarkGray, 1)
        'Dim FONDOETI As New Pen(Color.DarkGray, 209)
        'DIBUJA LINEA BASE DE GRILLA

        'DIBUJA LINEA BLANCA CON SEPARACION DE DIAS
        'GRILLA.DrawLine(BLANCO, 120, 444, 1300, 444)
        'For I = 120 To 1300 Step 10
        '    GRILLA.DrawLine(BLANCO, I, 444, I, 444 + 8)
        'Next I

        'DIBUJA FONDO
        'GRILLA.DrawLine(FONDO, 5, 334, 1300, 334)
        'GRILLA.DrawLine(FONDOETI, 5, 334, 120, 334)
        'LINEAS DE FONDO HRIZONTALES DEL GRAFICO
        'For J = 228 To 417 Step 21
        'GRILLA.DrawLine(LINEA, 5, J, 1300, J)
        'Next J

        'LINEAS DE FONDO VERTICALES DEL GRAFICO
        'For Q = 120 To 1300 Step 10
        'GRILLA.DrawLine(GRISCLARO, Q, 438, Q, 230)
        'Next Q
        'DIBUJA_FONDO()

    End Sub
    Private Sub DIBUJA_FONDO()

        Dim CALC_FERIADO As Integer
        Dim POSX As Integer
        Dim GRILLA As Graphics = Me.CreateGraphics()
        Dim BLANCO As New Pen(Color.White, 1)
        Dim FONDO As New Pen(Color.Silver, 210)
        Dim GRIS As New Pen(Color.Gray, 6)
        Dim GRISCLARO As New Pen(Color.DarkGray, 1)
        Dim LINEA As New Pen(Color.DimGray, 1)
        Dim LABORABLE As New Pen(Color.DarkGreen, 6)
        Dim FERIADO As New Pen(Color.DarkGray, 9)
        Dim FONDOETI As New Pen(Color.DarkGray, 209)

        'DIBUJA FONDO
        GRILLA.DrawLine(FONDO, 5, 334, 1300, 334)
        GRILLA.DrawLine(FONDOETI, 5, 334, 120, 334)

        'LINEAS DE FONDO HORIZONTALES DEL GRAFICO
        For J = 228 To 417 Step 21
            GRILLA.DrawLine(LINEA, 5, J, 1300, J)
        Next J


        'LINEAS DE FONDO VERTICALES DEL GRAFICO
        For Q = 120 To 1300 Step 10
            GRILLA.DrawLine(GRISCLARO, Q, 438, Q, 230)
        Next Q

        'DIBUJA LINEA BLANCA CON SEPARACION DE DIAS

        For Q = 120 To 1300 Step 10
            GRILLA.DrawLine(GRISCLARO, Q, 419, Q, 230 + 8)
        Next Q



        'DIBUJA FERIADOS
        DIA_SEMANA = (FECHA_INIGEST).DayOfWeek
        CALC_FERIADO = (6 - DIA_SEMANA) * 10

        Select Case DIA_SEMANA

            Case 1, 2, 3, 4, 5
                For S = 120 + CALC_FERIADO To 1300 Step 70
                    POSX = S + 5
                    GRILLA.DrawLine(FERIADO, POSX, 438, POSX, 229)
                    GRILLA.DrawLine(FERIADO, POSX + 10, 438, POSX + 10, 229)
                    If POSX + 5 + 10 + 50 < 1300 Then
                        GRILLA.DrawLine(LABORABLE, POSX + 5 + 10, 447, POSX + 5 + 10 + 50, 447)
                    End If
                Next S


            Case 6
                For S = 120 To 1300 Step 10
                    POSX = S + 5
                    GRILLA.DrawLine(FERIADO, POSX, 438, POSX, 229)
                    GRILLA.DrawLine(FERIADO, POSX + 10, 438, POSX + 10, 229)
                    If POSX + 5 + 10 + 50 < 1300 Then
                        GRILLA.DrawLine(LABORABLE, POSX + 5 + 20, 447, POSX + 5 + 50, 447)
                    End If
                Next S
            Case 7
                GRILLA.DrawLine(FERIADO, 120 + 5, 438, 120 + 5, 229)
                For S = 180 To 1300 Step 10
                    POSX = S + 5
                    GRILLA.DrawLine(FERIADO, S, 438, S, 229)
                    GRILLA.DrawLine(FERIADO, S + 10, 438, S + 10, 229)
                    If POSX + 5 + 10 + 50 < 1300 Then
                        GRILLA.DrawLine(LABORABLE, S + 5 + 20, 447, S + 5 + 50, 447)
                    End If
                Next S




        End Select

        'DIBUJA LINEA BLANCA CON SEPARACION DE DIAS
        GRILLA.DrawLine(BLANCO, 120, 444, 1300, 444)
        For Q = 120 To 1300 Step 10

            GRILLA.DrawLine(BLANCO, Q, 444, Q, 444 + 8)
        Next Q

    End Sub
    Private Sub PINTA_GRAF()


        Dim BORRATODO As Graphics = Me.CreateGraphics()

        Dim NEGRO As New Pen(Color.Gray, 300)
        BORRATODO.DrawLine(NEGRO, 1, 334, 1300, 334)
        'LBL_FINEST.Visible = True
        'LBL_FINEST.Text = ""
        'CONDICION_INICIAL()

        DIBUJA_FONDO()

        Dim GRAF_DIASDIF As Long
        Dim GRAF_XNOW As Integer

        Dim GRAF As Graphics = Me.CreateGraphics()

        Dim VERDE As New Pen(Color.LightGreen, 9)

        Dim AZULFINO As New Pen(Color.DarkBlue, 4)
        Dim AZULFINOCLARO As New Pen(Color.LightBlue, 4)
        Dim AZULGRUESO As New Pen(Color.DarkBlue, 13)
        Dim AZULGRUESOCLARO As New Pen(Color.LightBlue, 13)

        Dim NEGROFINO As New Pen(Color.Black, 4)

        Dim ROYALFINO As New Pen(Color.RoyalBlue, 4)
        Dim ROYALFINOCLARO As New Pen(Color.LightBlue, 4)
        Dim ROYALGRUESO As New Pen(Color.RoyalBlue, 13)
        Dim ROYALGRUESOCLARO As New Pen(Color.LightBlue, 13)

        Dim SIENAFINO As New Pen(Color.Sienna, 4)
        Dim SIENAFINOCLARO As New Pen(Color.LightSalmon, 4)
        Dim SIENAGRUESO As New Pen(Color.Sienna, 13)
        Dim SIENAGRUESOCLARO As New Pen(Color.LightSalmon, 13)

        Dim FORESTFINO As New Pen(Color.ForestGreen, 4)
        Dim FORESTFINOCLARO As New Pen(Color.LightGreen, 4)
        Dim FORESTGRUESO As New Pen(Color.ForestGreen, 13)
        Dim FORESTGRUESOCLARO As New Pen(Color.LightGreen, 13)

        Dim REDFINO As New Pen(Color.DarkRed, 4)
        Dim REDFINOCLARO As New Pen(Color.LightCoral, 4)
        Dim REDGRUESO As New Pen(Color.DarkRed, 13)
        Dim REDGRUESOCLARO As New Pen(Color.LightCoral, 13)

        Dim GREENFINO As New Pen(Color.DarkGreen, 4)
        Dim GREENFINOCLARO As New Pen(Color.LightGreen, 4)
        Dim GREENGRUESO As New Pen(Color.DarkGreen, 13)
        Dim GREENGRUESOCLARO As New Pen(Color.LightGreen, 13)

        Dim GRISGRUESO As New Pen(Color.Gray, 13)
        Dim AMARILLOGRUESO As New Pen(Color.Yellow, 13)
        Dim VIOLETAFINO As New Pen(Color.Purple, 13)

        Dim XGRAF As Integer
        Dim XGRAFFIN As Integer
        Dim YGRAF As Integer
        Dim LONGGRAF As Integer


        GRAF_DIASDIF = DateDiff(DateInterval.Day, FECHA_INIGEST, Today)
        GRAF_XNOW = GRAF_DIASDIF * 10 + 125
        GRAF.DrawLine(VERDE, GRAF_XNOW, 443, GRAF_XNOW, 229)

        'If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '    For I = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '        TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(I)

        '        Select Case TRABAJOSRow("TIPOTRABAJO")


        '            'DIBUJA RELEVAMIENTO__________________________________________________________________________________________________
        '            Case "Relevamiento", "RELEVAMIENTO"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 2
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10

        '                        GRAF.DrawLine(AZULFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(AZULFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 11
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(AZULGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(AZULGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select

        '                'DIBUJA ADMINSITRATIVO__________________________________________________________________________________________________

        '            Case "Administrativo", "ADMINISTRATIVO"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 23
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(ROYALFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(ROYALFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 32
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select

        '            'DIBUJA DISEÑO__________________________________________________________________________________________________
        '            Case "Diseño", "DISEÑO"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 229 + 44
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(SIENAFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(SIENAFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 53
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(SIENAGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(SIENAGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(SIENAGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select


        '                   'DIBUJA PRESUPUESTO__________________________________________________________________________________________________

        '            Case "PRESUPUESTO"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 65
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(ROYALFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(ROYALFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 74
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select



        '                   'DIBUJA APROBACION PERMISORES__________________________________________________________________________________________________

        '            Case "APROBACION PERMISORES"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 86
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(ROYALFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(ROYALFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 95
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select


        '                   'DIBUJA APROBACION IMM__________________________________________________________________________________________________

        '            Case "APROBACION IMM"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 107
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(ROYALFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(ROYALFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 116
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select


        '                   'AUTORIZACION CABLEADO__________________________________________________________________________________________________

        '            Case "AUTORIZACION CABLEADO"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 128
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(ROYALFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(ROYALFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 137
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(AZULGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(ROYALGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select

        '           'DIBUJA GESTION OC__________________________________________________________________________________________________
        '            Case "Gestion OC", "GESTION OC"
        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 149
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(FORESTFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 1
        '                        GRAF.DrawLine(FORESTFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 158
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(FORESTGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(FORESTGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(FORESTGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select



        '                'DIBUJA GESTION RED__________________________________________________________________________________________________
        '            Case "Gestion RED", "GESTION RED"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 170
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(REDFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(REDFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 179
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(REDGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(REDGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(REDGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select


        '                    'DIBUJA EJECUCION__________________________________________________________________________________________________
        '            Case "Ejecucion", "EJECUCION"

        '                'DIBUJA ESTIMADO
        '                YGRAF = 230 + 191
        '                If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                    If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                        XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                        LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                        GRAF.DrawLine(GREENFINO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    Else
        '                        LONGGRAF = 10
        '                        GRAF.DrawLine(GREENFINOCLARO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                    End If
        '                End If
        '                'DIBUJA REAL
        '                YGRAF = 230 + 200
        '                Select Case TRABAJOSRow("STATUS")
        '                    Case "FINALIZADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAFINALIZADO")) * 10 + 120
        '                                GRAF.DrawLine(GREENGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                                XGRAFFIN = XGRAF + LONGGRAF
        '                                GRAF.DrawLine(GREENGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            End If
        '                        Else
        '                            If IsDBNull(TRABAJOSRow("FECHAFINALIZADO")) = False Then
        '                                XGRAF = XGRAFFIN - LONGGRAF
        '                                GRAF.DrawLine(GREENGRUESOCLARO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                            Else
        '                            End If
        '                        End If
        '                    Case "COORDINADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            If (TRABAJOSRow("TIEMPOESTIMADO")) <> "" Then
        '                                XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 120
        '                                LONGGRAF = TRABAJOSRow("TIEMPOESTIMADO") * 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            Else
        '                                LONGGRAF = 10
        '                                GRAF.DrawLine(GRISGRUESO, XGRAF, YGRAF, XGRAF + LONGGRAF, YGRAF)
        '                            End If
        '                        End If
        '                    Case "INICIADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICIADO")) = False Then

        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICIADO")) * 10 + 120
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(AMARILLOGRUESO, XGRAF, YGRAF, XGRAFFIN, YGRAF)

        '                        End If
        '                    Case "DEMORADO"
        '                        If IsDBNull(TRABAJOSRow("FECHAINICESTIMADO")) = False Then
        '                            XGRAF = DateDiff(DateInterval.Day, FECHA_INIGEST, TRABAJOSRow("FECHAINICESTIMADO")) * 10 + 125
        '                            XGRAFFIN = DateDiff(DateInterval.Day, FECHA_INIGEST, Now) * 10 + 120
        '                            GRAF.DrawLine(VIOLETAFINO, XGRAF, YGRAF, XGRAFFIN, YGRAF)
        '                        End If
        '                End Select

        '                LBL_FINEST.Visible = True
        '                LBL_FINEST.Location = New Point(XGRAF + LONGGRAF, YGRAF - 9)
        '                LBL_FINEST.Text = "Fecha Est: " & DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
        '        End Select
        '    Next
        'End If

    End Sub
    'Private Sub INGRESO_DATOS_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    POSX = Control.MousePosition.X
    '    POSY = Control.MousePosition.Y
    '    'FECHA_INIGEST = Now.ToShortDateString
    '    Dim CANTDIAS As Integer

    '    If POSY > 230 And POSY < 470 Then
    '        If POSX > 120 And POSX < 1300 Then
    '            CANTDIAS = (POSX - 125) / 10
    '            Label27.Text = DateAdd(DateInterval.Day, CANTDIAS, FECHA_INIGEST).ToLongDateString
    '        End If
    '    End If

    'End Sub
    'Private Sub ANALISISGESTDataGridView_Sorted(sender As Object, e As EventArgs)
    '    PINTA_GRILLA()
    'End Sub
    'Private Sub IRAHISTORIALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRAHISTORIALToolStripMenuItem.Click
    '    'ENVIA AL HISTORIAL DESDE LA GRILLA RESUMEN DE GESTIONES
    '    ACCESO_DESDE = "MDU"
    '    BUSCA_PRIM = ANALISISGESTDataGridView.CurrentRow.Cells.Item(3).Value
    '    DIRECCION_MDU = Me.ANALISISGESTDataGridView.CurrentRow.Cells.Item(4).Value
    '    NUMERO_MDU = Me.ANALISISGESTDataGridView.CurrentRow.Cells.Item(5).Value

    '    If INGRESO_AREA = "RED" And DATOS.Visible = True Then
    '        DATOS.Close()
    '        If THEME_BLACK Then
    '            If DASHBOARD.BTN1.Text = "RED" Then
    '                EstiloBTNCerrar(1)
    '            ElseIf DASHBOARD.BTN2.Text = "RED" Then
    '                EstiloBTNCerrar(2)
    '            ElseIf DASHBOARD.BTN3.Text = "RED" Then
    '                EstiloBTNCerrar(3)
    '            ElseIf DASHBOARD.BTN4.Text = "RED" Then
    '                EstiloBTNCerrar(4)
    '            ElseIf DASHBOARD.BTN5.Text = "RED" Then
    '                EstiloBTNCerrar(5)
    '            ElseIf DASHBOARD.BTN6.Text = "RED" Then
    '                EstiloBTNCerrar(6)
    '            ElseIf DASHBOARD.BTN7.Text = "RED" Then
    '                EstiloBTNCerrar(7)
    '            ElseIf DASHBOARD.BTN8.Text = "RED" Then
    '                EstiloBTNCerrar(8)
    '            End If
    '        Else
    '            DASHBOARD.BTN_RED.BackgroundImage = My.Resources.RED
    '            DASHBOARD.BTN4Close.Visible = False
    '        End If
    '    End If
    '    INGRESO_AREA = "MDU"
    '    ACCESO_DESDE = "MDU"

    '    DATOS.TopLevel = False
    '    DATOS.Parent = DASHBOARD.PanelTrabajo
    '    DATOS.Show()
    '    DATOS.BringToFront()


    '    ANALISISGESTDataGridView.ContextMenuStrip = Nothing
    'End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        INFORME_MDU_GESTIONESPROGRAMADAS.Show()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        EdificiosDataGridView.Enabled = False

        BLOQUEA_FILTROS()
        HABILITA_CAMPOS()
        BORRA_CAMPOS()


        BOT_CANCELAR.Enabled = True
        BOT_GRABARMDU.Enabled = True
        BOT_VERHISTORIAL.Enabled = False

        ACCION = "NUEVO"

        EdificiosDataGridView.ContextMenuStrip = Nothing

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        EdificiosDataGridView.Enabled = False

        BLOQUEA_FILTROS()


        BOT_CANCELAR.Enabled = True
        BOT_GRABARMDU.Enabled = True
        BOT_VERHISTORIAL.Enabled = False

        HABILITA_CAMPOS()

        ACCION = "EDITAR"
        EdificiosDataGridView.ContextMenuStrip = Nothing
    End Sub

    Private Sub INGRESO_MDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'OBRA_LISTA.Items.Clear()
        'For X = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
        '    OBRA_LISTA.Items.Add(ORDENESDataSet.GESTION.Rows(X).Item("CALLE"))
        'Next
    End Sub

    'Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
    '    Dim CANT_X As Integer = 0
    '    Dim POS_X As Integer = 10
    '    Dim POS_Y As Integer = 10

    '    GESTIONTableAdapter2.FillByGEST_XTIPO(OBRAS_MDUDataSet.GESTION, "OBRA NUEVA HFC")

    '    For X = 0 To OBRAS_MDUDataSet.GESTION.Rows.Count - 1
    '        If CANT_X = 8 Then
    '            CANT_X = 0
    '            POS_Y += 55

    '        End If
    '        CREAR_GESTION(Me.Panel2, POS_X + (155 * CANT_X), POS_Y + 55, X, Color.Red, 150, 50)
    '        CANT_X += 1
    '    Next



    '    Dim OBRA As OBRAS_MDUDataSet.GESTIONRow
    '    'For X = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
    '    '    GESTION = ORDENESDataSet.GESTION.Rows(X)
    '    '    OBRA = OBRAS_MDUDataSet.GESTION.NewGESTIONRow()
    '    '    OBRA.DIRECCION = GESTION.CALLE
    '    '    OBRA.PUERTA = GESTION.NUMERO
    '    '    OBRA.FECHA_INGRESADO = GESTION.FECHAINGRESADA
    '    '    If GESTION.IsFECHAINICIADANull = False Then OBRA.FECHA_INICIADO = GESTION.FECHAINICIADA
    '    '    OBRA.STATUS = GESTION.STATUS
    '    '    OBRA.OBSERVACIONES = GESTION.DESCRIPCION
    '    '    OBRAS_MDUDataSet.GESTION.AddGESTIONRow(OBRA)
    '    '    OBRA_LISTA.Items.Add(ORDENESDataSet.GESTION.Rows(X).Item("CALLE"))
    '    'Next
    '    'GESTIONTableAdapter1.Update(OBRAS_MDUDataSet.GESTION)
    'End Sub



    Private Sub DGV_EDIFICIOS_DoubleClick(sender As Object, e As EventArgs) Handles DGV_EDIFICIOS.DoubleClick
        'BUSCA SI TIENE GESTION RUS INGRESADA
        ACCESO_TIPO = "GESTION"
        NROGESTION = DGV_EDIFICIOS.CurrentRow.Cells.Item(0).Value
        ABRIR_DATOS()
    End Sub

    Private Sub MANT_DGV_DoubleClick(sender As Object, e As EventArgs) Handles MANT_DGV.DoubleClick
        'BUSCA SI TIENE GESTION RUS INGRESADA
        ACCESO_TIPO = "GESTION"
        NROGESTION = MANT_DGV.CurrentRow.Cells.Item(0).Value
        ABRIR_DATOS()
    End Sub



    'Private Sub DGV_MDU_CellClick(sender As Object, e As DataGridViewCellEventArgs)
    '    TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, CInt(DGV_MDU.Rows(DGV_MDU.CurrentCell.RowIndex).Cells(1).Value))
    '    If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
    '        Select Case DGV_MDU.CurrentCell.ColumnIndex
    '            Case 2
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "RELEVAMIENTO" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 4
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "DISEÑO" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 5
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "PRESUPUESTO" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 6
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "APROBACION PERMISOS" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 7
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "APROBACION IMM" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 8
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "AUTORIZACION CABLEADO" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 9
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "OBRA CIVIL" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 10
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "ASOCIADO A RED" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 11
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "EJECUCION" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '            Case 12
    '                For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    TRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    If TRABAJO.TIPOTRABAJO = "ACTUALIZACION PLANOS" Then
    '                        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO.Id_TRABAJO)
    '                    End If
    '                Next
    '        End Select
    '        ORDENESDataGridView.Visible = True
    '    End If
    'End Sub

    'Private Sub DGV_MDU_Leave(sender As Object, e As EventArgs)
    '    ORDENESDataGridView.Visible = False
    'End Sub

    'Private Sub DGV_MDU_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    DIRECCION_MDU = DGV_MDU.Rows(DGV_MDU.CurrentCell.RowIndex).Cells(0).Value
    '    GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, DGV_MDU.Rows(DGV_MDU.CurrentCell.RowIndex).Cells(1).Value)
    '    BUSCA_PRIM = ORDENESDataSet.GESTION.Rows(0).Item("CARPETA")
    '    NUMERO_MDU = ORDENESDataSet.GESTION.Rows(0).Item("Id_GESTION")
    '    If INGRESO_AREA = "RED" And DATOS.Visible = True Then
    '        DATOS.Close()
    '        If THEME_BLACK Then
    '            If DASHBOARD.BTN1.Text = "RED" Then
    '                EstiloBTNCerrar(1)
    '            ElseIf DASHBOARD.BTN2.Text = "RED" Then
    '                EstiloBTNCerrar(2)
    '            ElseIf DASHBOARD.BTN3.Text = "RED" Then
    '                EstiloBTNCerrar(3)
    '            ElseIf DASHBOARD.BTN4.Text = "RED" Then
    '                EstiloBTNCerrar(4)
    '            ElseIf DASHBOARD.BTN5.Text = "RED" Then
    '                EstiloBTNCerrar(5)
    '            ElseIf DASHBOARD.BTN6.Text = "RED" Then
    '                EstiloBTNCerrar(6)
    '            ElseIf DASHBOARD.BTN7.Text = "RED" Then
    '                EstiloBTNCerrar(7)
    '            ElseIf DASHBOARD.BTN8.Text = "RED" Then
    '                EstiloBTNCerrar(8)
    '            End If
    '        Else
    '            DASHBOARD.BTN_RED.BackgroundImage = My.Resources.RED
    '            DASHBOARD.BTN4Close.Visible = False
    '        End If
    '    End If
    '    ABRIR_DATOS()
    'End Sub







    'PROCESO PARA MOSTRAR GESTIONES DE MDU

    '    MDUDataSet.ANALISISGEST.Clear()
    '    Me.Cursor = Cursors.WaitCursor

    'Dim FECHAFINAL_ESTIMADA As Date
    'Dim FECHAFINAL_REAL As Date
    'Dim FECHAINICIO_REAL As Date
    'Dim FECHAINICIO_ESTIMADO As Date
    'Dim TIEMPO_ESTIMADO As Integer

    ''BUSCA LAS GESTIONES NO FINALIZADAS

    ''  Dim VAR_EST As Integer
    'Dim VAR_DEM As Integer
    '    GESTIONTableAdapter.FillByNOSTATUS(ORDENESDataSet.GESTION, "FINALIZADO", TIPO_GEST)


    '    If ORDENESDataSet.GESTION.Rows.Count > 0 Then
    '        CANTGEST.Maximum = ORDENESDataSet.GESTION.Rows.Count

    '        For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1

    '            CANTGEST.Value = I + 1

    '            ActGESTION = ORDENESDataSet.GESTION.Rows(I)

    '            NUEVAGEST = MDUDataSet.ANALISISGEST.NewRow

    '            NUEVAGEST("ID_GESTION") = ActGESTION("Id_GESTION")
    '            NUEVAGEST("CALLE") = ActGESTION("CALLE")
    '            NUEVAGEST("NRO") = ActGESTION("NUMERO")
    '            NUEVAGEST("STATUSGEST") = Mid(ActGESTION("STATUS"), 1, 3)
    '            NUEVAGEST("CARPETA") = ActGESTION("CARPETA")
    '            NUEVAGEST("TIPOGEST") = TIPO_GESTABR
    '            NUEVAGEST("FECH_INI") = ActGESTION("FECHAINICIADA")
    '            NUEVAGEST("DIAS_EST") = 0
    '            NUEVAGEST("DIAS_REAL") = 0
    '            'NUEVAGEST("DIAS_ATRASO") = 0
    '            VAR_DEM = 0

    '            'BUSCA TRABAJOS DEFINIDOS EN LA GESTION
    '            TRABAJOSTableAdapter.FillByIDGESTIONNOCANCELADO(ORDENESDataSet.TRABAJOS, ActGESTION("Id_GESTION"))

    '            If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
    'For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '                    ActTRABAJO = ORDENESDataSet.TRABAJOS.Rows(X)
    '                    Select Case ActTRABAJO("TIPOTRABAJO")

    '                        'SI ES UN TRABAJO DE RELEVAMIENTO
    'Case "Relevamiento", "RELEVAMIENTO"
    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("REL_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("REL_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    'If IsDBNull(ActTRABAJO("FECHAINICIADO")) = False Then
    '                                        FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    End If
    'If IsDBNull(ActTRABAJO("FECHAFINALIZADO")) = False Then
    '                                        FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    End If
    '                                    NUEVAGEST("REL_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("REL_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("REL_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    'If IsDBNull(ActTRABAJO("FECHAINICIADO")) = False Then
    '                                        FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    Else
    '                                        MsgBox("El trabajo de " & ActTRABAJO("TIPOTRABAJO") & " del EDIIFICIO situado en " & ActGESTION("CALLE") & " NRO: " & ActGESTION("NUMERO") & " no tiene FECCHA DE INICIO ", vbInformation)
    '                                    End If
    '                                    NUEVAGEST("REL_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    '                              'SI ES UN TRABAJO DE DISEÑO____________________________________________________________________
    'Case "Administrativo", "ADMINISTRATIVO"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("ADM_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("DIS_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("ADM_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("ADM_DEM")

    '                                Case "INGRESADO"
    '                                    NUEVAGEST("ADM_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("ADM_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    '                              'SI ES UN TRABAJO DE DISEÑO____________________________________________________________________
    'Case "Diseño", "DISEÑO"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("DIS_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("DIS_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("DIS_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("DIS_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("DIS_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("DIS_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    '                            'SI ES UN TRABAJO DE PRESUPUESTO
    'Case "PRESUPUESTO"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("PRE_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("PRE_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("PRE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("PRE_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("PRE_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("PRE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    'Case "APROBACION PERMISOS"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("PER_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("PER_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("PER_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("PER_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("PER_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("PER_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select



    '                            'SI ES UN TRABAJO DE APROBACION IMM
    'Case "APROBACION IMM"
    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("IMM_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("IMM_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("IMM_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("IMM_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("IMM_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("IMM_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select
    '                            'SI ES UN TRABAJO DE AUTORIZACION DE CABLEADO


    'Case "AUTORIZACION CABLEADO"
    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("AUT_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("AUT_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    'If IsDBNull(ActTRABAJO("FECHAINICIADO")) = False Then
    '                                        FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    Else
    '                                        MsgBox("El trabajo de " & ActTRABAJO("TIPOTRABAJO") & " del EDIIFICIO situado en " & ActGESTION("CALLE") & " NRO: " & ActGESTION("NUMERO") & " no tiene FECCHA DE INICIO ", vbInformation)
    '                                    End If
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("AUT_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("AUT_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("AUT_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("AUT_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select




    'Case "Gestion OC", "GESTION OC"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("GOC_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("GOC_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("GOC_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("GOC_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("GOC_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("GOC_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    'Case "Gestion RED", "GESTION RED"

    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("GRE_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("GRE_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("GRE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("GRE_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("GRE_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("GRE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select

    'Case "Ejecucion", "EJECUCION"
    '                            TIEMPO_ESTIMADO = ActTRABAJO("TIEMPOESTIMADO")
    '                            FECHAINICIO_ESTIMADO = ActTRABAJO("FECHAINICESTIMADO")
    '                            FECHAFINAL_ESTIMADA = DateAdd(DateInterval.Day, TIEMPO_ESTIMADO, FECHAINICIO_ESTIMADO)

    '                            NUEVAGEST("EJE_STS") = Mid(ActTRABAJO("STATUS"), 1, 3)
    '                            If ActTRABAJO("TIEMPOESTIMADO") <> "" Then NUEVAGEST("EJE_EST") = CInt(ActTRABAJO("TIEMPOESTIMADO"))

    '                            Select Case ActTRABAJO("STATUS")
    'Case "FINALIZADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    FECHAFINAL_REAL = ActTRABAJO("FECHAFINALIZADO")
    '                                    NUEVAGEST("EJE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, FECHAFINAL_REAL)
    '                                    VAR_DEM = VAR_DEM + NUEVAGEST("EJE_DEM")
    '                                Case "INGRESADO"
    '                                    NUEVAGEST("EJE_DEM") = DateDiff(DateInterval.Day, FECHAINICIO_ESTIMADO, Now)
    '                                Case "INICIADO"
    '                                    FECHAINICIO_REAL = ActTRABAJO("FECHAINICIADO")
    '                                    NUEVAGEST("EJE_DEM") = DateDiff(DateInterval.Day, FECHAFINAL_ESTIMADA, Now)
    '                            End Select


    'End Select

    ''CARGA LA FECHA ESTIMADA DE FIN
    'Select Case ActTRABAJO("TIPOTRABAJO")
    'Case "EJECUCION", "Ejecucion"

    'If IsDBNull(ActTRABAJO("FECHAINICESTIMADO")) = False Then
    '                                NUEVAGEST("FIN_EST") = DateAdd(DateInterval.Day, ActTRABAJO("TIEMPOESTIMADO"), ActTRABAJO("FECHAINICESTIMADO"))
    '                            Else
    '                                NUEVAGEST("FIN_EST") = DBNull.Value
    '                            End If

    'End Select
    'Next

    ''Dim TIEMPOESTIMADOGEST As Integer
    ''Dim TIEMPOATRASOGEST As Integer

    ''TIEMPOESTIMADOGEST = NUEVAGEST("DIAS_EST")
    ''TIEMPOATRASOGEST = NUEVAGEST("DIAS_ATRASO")

    'End If
    '            NUEVAGEST("DIAS_ATRASO") = VAR_DEM
    '            MDUDataSet.ANALISISGEST.AddANALISISGESTRow(NUEVAGEST)
    '        Next
    'End If
    '    CANTGEST.Value = 0
    '    PINTA_GRILLA()
    '    Me.Cursor = DefaultCursor
End Class