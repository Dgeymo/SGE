Imports System.IO
Public Class SERVICIOS
    ReadOnly emailDestino As String = "diseno@equital.com.uy"
    Dim CAMPO(7)
    Dim DATO(7)
    Dim FILTRO(7)
    Dim CampoCalle(7) As String
    Dim ExpreCalle(7) As String
    Dim FiltrCalle(7) As String
    Dim Campo1Calle(7) As String
    Dim Expre1Calle(7) As String
    Dim Filtr1Calle(7) As String
    Dim VISTACALLE As DataView
    Dim VISTAORDEN As DataView
    Dim NewGESTIONRow As ORDENESDataSet.GESTIONRow
    Dim NewTRABAJORow As ORDENESDataSet.TRABAJOSRow
    Dim NewTAREARow As ORDENESDataSet.TAREASRow
    Dim NewORDENESRow As ORDENESDataSet.ORDENESRow
    Dim NewOBSERVACIONESRow As ORDENESDataSet.OBESERVACIONESRow
    Public NewADJUNTOSRow As ORDENESDataSet.ADJUNTOSRow
    Dim PathRuta As String

    Dim ORDEN_SERVICIORow As ORDENESDataSet.ORDENESRow
    Dim TRABAJO_SERVICIORow As ORDENESDataSet.TRABAJOSRow
    Dim GESTION_SERVICIORow As ORDENESDataSet.GESTIONRow
    Dim NewHISTORICORow As ORDENESDataSet.HISTORICORow
    Private Sub SERVICIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ORDENESTableAdapter.FillByDISENO(ORDENESDataSet.ORDENES)
        ORDENESBindingSource1.MoveLast()
    End Sub
    Private Sub BUSCA_TIPO()
        VISTAORDEN = ORDENESDataSet.ORDENES.AsDataView
        '0____________
        CAMPO(0) = "NODO"
        DATO(0) = BUSCA_NODO.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"
        ' FILTRO(0) = ""
        '1_________
        CAMPO(1) = "ZONA"
        DATO(1) = FILTRO_ZONA.Text
        If FILTRO_ZONA.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND [" & CAMPO(1) & "]  like '*" & DATO(1) & "*'"
        End If
        '2___________
        CAMPO(2) = "CALLE"
        DATO(2) = TXT_ING_CALLE.Text
        If TXT_ING_CALLE.Text = "" Then
            FILTRO(2) = ""
        Else
            FILTRO(2) = " AND  [" & CAMPO(2) & "] like '*" & DATO(2) & "*'"
        End If
        '3__________
        CAMPO(3) = "NRO"
        DATO(3) = TXT_ING_NRO.Text
        If TXT_ING_NRO.Text = "" Then
            FILTRO(3) = ""
        Else
            FILTRO(3) = " AND  [" & CAMPO(3) & "] like '*" & DATO(3) & "*'"
        End If
        '4__________
        CAMPO(4) = "STATUS"
        If CK_STATUS.Text = "TODOS" Then
            DATO(4) = ""
        Else
            DATO(4) = CK_STATUS.Text
        End If
        If CK_STATUS.Text = "TODOS" Then
            FILTRO(4) = ""
        Else
            FILTRO(4) = " AND  [" & CAMPO(4) & "] like '*" & DATO(4) & "*'"
        End If
        '5_____________
        CAMPO(5) = "NRO_ORDENINT"
        DATO(5) = TXT_ORDENINT.Text
        If TXT_ORDENINT.Text = "" Then
            FILTRO(5) = ""
        Else
            FILTRO(5) = " AND  [" & CAMPO(5) & "] =" & DATO(5)
        End If
        '5__________
        CAMPO(6) = "ORDEN_OC"
        DATO(6) = TXT_OC.Text
        If TXT_OC.Text = "" Then
            FILTRO(6) = ""
        Else
            FILTRO(6) = " AND  [" & CAMPO(6) & "] like '*" & DATO(6) & "*'"
        End If
        VISTAORDEN.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) & FILTRO(4) & FILTRO(5) & FILTRO(6) '& FILTRO(7) & FILTRO(8)
        ORDENESBindingSource1.DataSource = VISTAORDEN
    End Sub
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        INDICE_CAUSASTableAdapter.FillByFALLA(INDICESDataSet.INDICE_CAUSAS, "SERVICIOS")
        CB_CAUSAS.Items.Clear()
        For x = 0 To INDICESDataSet.INDICE_CAUSAS.Rows.Count - 1
            CB_CAUSAS.Items.Add(INDICESDataSet.INDICE_CAUSAS.Rows(x).Item("DETALLE_CAUSA"))
        Next
        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        If GB_NUEVO.Visible Then
            BTN_NUEVO.Text = "NUEVO"
            GB_NUEVO.Visible = False
            ' Size = New Size(1051, 475)
            '  Location = New Point(Location.X, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)
            DGV_ORDENES.Visible = True
            Panel1.Visible = True
            Panel2.Visible = True
        Else
            ' Size = New Size(1051, 660)
            ' Location = New Point(Location.X, (My.Computer.Screen.WorkingArea.Height - Size.Height) / 2)
            BTN_NUEVO.Text = "VOLVER"
            'DGV_ORDENES.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            GB_NUEVO.Visible = True
        End If
    End Sub
    Private Sub BTN_INGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_INGRESAR.Click
        Cursor = Cursors.WaitCursor
        If TXT_NODO.Text = "" Then
            MsgBox("COMPLETE EL NODO")
            TXT_NODO.Focus()
            Exit Sub
        End If
        If TXT_ZONA.Text = "" Then
            MsgBox("COMPLETE LA ZONA")
            TXT_ZONA.Focus()
            Exit Sub
        End If
        If CB_CAUSAS.Text = String.Empty Then
            MsgBox("INGRESE UNA CAUSA")
            CB_CAUSAS.Focus()
            Exit Sub
        End If
        If IND_CALLE.Text = "" Then
            If TXT_ING_CALLE.Text = "" Then
                'acepta que no tiene calle
                IND_CALLE.Text = 0
            Else
                MsgBox("La calle no tiene asociado un indice" & vbNewLine & "Haga Click en CALLE y seleccione la buscada")
                Exit Sub
            End If
        End If
        If TXT_CANT_OC.Text = "" Then
            MsgBox("Indique la cantidad de PLANOS OC incluidos en la orden interna")
            TXT_CANT_OC.Focus()
            Exit Sub
        End If
        GESTIONTableAdapter.FillByTIPO_STATUS_NODO(ORDENESDataSet.GESTION, "SERVICIOS", TXT_NODO.Text)
        If ORDENESDataSet.GESTION.Rows.Count = 0 Then
            NEW_GESTION()
            NEW_TRABAJO()
        Else
            GESTION_SERVICIORow = ORDENESDataSet.GESTION.Rows(ORDENESDataSet.GESTION.Rows.Count - 1)
            TRABAJOSTableAdapter.FillByIDGESTIONZONA(ORDENESDataSet.TRABAJOS, GESTION_SERVICIORow.Id_GESTION, CInt(TXT_ZONA.Text))
            If ORDENESDataSet.TRABAJOS.Rows.Count = 0 Then
                NEW_TRABAJO()
            Else
                TRABAJO_SERVICIORow = ORDENESDataSet.TRABAJOS.Rows(ORDENESDataSet.TRABAJOS.Rows.Count - 1)
            End If
        End If
        NEW_ORDEN()

        ORDENESTableAdapter.FillByDISENO(ORDENESDataSet.ORDENES)
        ORDENESBindingSource1.MoveLast()
        Cursor = Cursors.Default
    End Sub
    Private Sub NEW_GESTION()
        'INGRESAMOS LA GESTION NUEVA
        NewGESTIONRow = ORDENESDataSet.GESTION.NewGESTIONRow
        NewGESTIONRow("TIPOGESTION") = "SERVICIOS"
        NewGESTIONRow("DESCRIPCION") = "SERVICIOS MONTEVIDEO"
        NewGESTIONRow("SOLICITANTE") = ""
        NewGESTIONRow("NOMBRECONTACTO") = ""
        NewGESTIONRow("TELEFCONTACTO") = ""
        NewGESTIONRow("MAILCONTACTO") = ""
        NewGESTIONRow("GENERADOX") = "SISTEMA"
        NewGESTIONRow("NODO") = TXT_NODO.Text
        NewGESTIONRow("ATRIBUTO") = CB_ATRIBUTO.Text
        NewGESTIONRow("ASIGNADOA") = "SISTEMA"
        NewGESTIONRow("IDASIG") = ID
        NewGESTIONRow("SECTORASIG") = "SISTEMA"
        NewGESTIONRow("ESQ1") = ""
        NewGESTIONRow("ESQ2") = ""
        NewGESTIONRow("CARPETA") = ""
        NewGESTIONRow("FECHAINGRESADA") = Now
        NewGESTIONRow("FECHAINICESTIMADA") = Now.ToShortDateString
        NewGESTIONRow("STATUS") = "INGRESADO"
        NewGESTIONRow("AREA") = "RED"
        NewGESTIONRow("TIEMPOEST") = 0
        NewGESTIONRow("COMPLETO") = False
        ORDENESDataSet.GESTION.AddGESTIONRow(NewGESTIONRow)
        GESTIONTableAdapter.Update(NewGESTIONRow)
        GESTIONTableAdapter.FillByTIPO_STATUS_NODO(ORDENESDataSet.GESTION, "SERVICIOS", TXT_NODO.Text)
        GESTION_SERVICIORow = ORDENESDataSet.GESTION.Rows(ORDENESDataSet.GESTION.Rows.Count - 1)
    End Sub
    Private Sub NEW_TRABAJO()
        'INGRESAMOS EL TRABAJO NUEVO
        NewTRABAJORow = ORDENESDataSet.TRABAJOS.NewTRABAJOSRow
        NewTRABAJORow.Id_TRABAJO = ObtenerUltimo("ORDENES", "TRABAJOS") + 1
        NewTRABAJORow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
        NewTRABAJORow("TIPOTRABAJO") = "SERVICIOS"
        NewTRABAJORow("FECHAINICESTIMADO") = Now.ToShortDateString
        NewTRABAJORow("TIEMPOESTIMADO") = 0
        NewTRABAJORow("DESCRIPCION") = "SERVICIOS MONTEVIDEO ZONA " & TXT_ZONA.Text
        NewTRABAJORow("NODO") = TXT_NODO.Text
        NewTRABAJORow("ZONA") = CInt(TXT_ZONA.Text)
        NewTRABAJORow("MANZANA") = ""
        NewTRABAJORow("ATRIBUTO") = CB_ATRIBUTO.Text
        NewTRABAJORow("CALLE") = ""
        NewTRABAJORow("NRO") = ""
        NewTRABAJORow("FECHAINGRESADO") = Now
        NewTRABAJORow("GENERADOX") = "SISTEMA"
        NewTRABAJORow("ASIGNADOA") = "SISTEMA"
        NewTRABAJORow("SECTORASIG") = "SISTEMA"
        NewTRABAJORow("IDASIG") = DATOS.IDASIG
        NewTRABAJORow("INSTALACION") = ""
        NewTRABAJORow("INSTALACIONRUS") = ""
        NewTRABAJORow("AREA") = "RED"
        NewTRABAJORow("STATUS") = "INGRESADO"
        NewTRABAJORow("TIPODEP") = 0
        NewTRABAJORow("DEPENDENCIA") = 0
        ORDENESDataSet.TRABAJOS.AddTRABAJOSRow(NewTRABAJORow)
        TRABAJOSTableAdapter.Update(NewTRABAJORow)
        TRABAJOSTableAdapter.FillByIDGESTIONZONA(ORDENESDataSet.TRABAJOS, GESTION_SERVICIORow.Id_GESTION, CInt(TXT_ZONA.Text))
        TRABAJO_SERVICIORow = ORDENESDataSet.TRABAJOS.Rows(ORDENESDataSet.TRABAJOS.Rows.Count - 1)
    End Sub
    Private Sub NEW_ORDEN()
        'INGRESAMOS LA ORDEN INTERNA
        NewORDENESRow = ORDENESDataSet.ORDENES.NewORDENESRow

        'DATOS TEMPORALES
        NewORDENESRow("FECHAINGRESO") = Now.ToShortDateString
        NewORDENESRow("FECHASOL") = Now.ToShortDateString
        NewORDENESRow("FECHAINICESTIMADO") = Now.ToShortDateString
        NewORDENESRow("TESTIMADO") = 1
        NewORDENESRow("TPREVISTO") = 0
        NewORDENESRow("CUADRILLA") = "ZELMAR LAGOS"

        'DATOS DE DEPENDENCIA
        NewORDENESRow("DEPENDENCIA") = 0
        NewORDENESRow("TIPODEP") = "IND"
        NewORDENESRow("ORDENDEP") = 0
        NewORDENESRow("CLASEDEP") = "IND"
        NewORDENESRow("ORDORIGEN") = 0

        'IDENTIFICACION DE LA ORDEN
        NewORDENESRow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
        NewORDENESRow("ID_TRABAJO") = TRABAJO_SERVICIORow.Id_TRABAJO
        NewORDENESRow("ATRIBUTO") = CB_ATRIBUTO.Text
        NewORDENESRow("NRO_ORDINAL") = 0
        NewORDENESRow.ORDEN_OC = TXT_ORDEN_OC.Text
        NewORDENESRow.CANTIDAD_SERVICIOS = CInt(TXT_CANT_OC.Text)
        NewORDENESRow("STATUS") = "ASIGNADO"
        NewORDENESRow("FECHA_ASIGNADA") = Today.ToShortDateString
        NewORDENESRow("TIPO") = CB_TIPO.Text
        NewORDENESRow.SECTOROPE = "DISEÑO"
        NewORDENESRow.RECURSO = "DISEÑO"
        NewORDENESRow("SECTORGEN") = "OC"
        NewORDENESRow("PRIORIDAD") = CB_PRIORIDAD.Text
        NewORDENESRow("CARPETA") = ""
        NewORDENESRow("SECTORDESTINO") = "RED"

        'UBICACION
        NewORDENESRow("NODO") = TXT_NODO.Text
        NewORDENESRow("ZONA") = TXT_ZONA.Text
        NewORDENESRow("MANZANA") = TXT_SEC.Text & "/" & TXT_SEG.Text & "/" & TXT_MAN.Text
        NewORDENESRow("ESQU1") = TXT_ESQ1.Text
        NewORDENESRow("ESQU2") = TXT_ESQ2.Text
        NewORDENESRow("CALLE") = TXT_CALLE.Text
        Try
            NewORDENESRow("ID_CALLE") = IND_CALLE.Text
        Catch ex As Exception
            INDICE_CALLESDataGridView.Visible = True
            Exit Sub
        End Try
        NewORDENESRow("NRO") = TXT_NRO.Text
        NewORDENESRow("INSTALACION") = ""
        NewORDENESRow("AFECTACION") = ""

        'MOTIVOS DE GENERACION
        NewORDENESRow("MOTIVOORIGEN") = "SERVICIOS"
        NewORDENESRow("CAUSARIGEN") = CB_CAUSAS.Text

        'SOLICITUDES A ADMINISTRACION
        NewORDENESRow("CREARORDINAL") = False
        NewORDENESRow("COORDINAR") = False

        'REGISTRO DE SOLICITUDES EXTERNAS
        NewORDENESRow("SOLICITANTE") = ""
        NewORDENESRow("GENERADOR") = FULLNOMBRE
        NewORDENESRow("CONTACTONOMBRE") = ""
        NewORDENESRow("CONTACTOTEL") = ""
        NewORDENESRow("DOCUMENTO_FISICO") = CK_DOCUMENTO_FISICO.Checked

        Select Case CB_PRIORIDAD.Text
            Case "URGENTE", "ALTA"
                NewORDENESRow("NOTIF") = True
            Case Else
                NewORDENESRow("NOTIF") = False
        End Select
        'AGREGA REGISTRO
        ORDENESDataSet.ORDENES.AddORDENESRow(NewORDENESRow)
        ORDENESTableAdapter.Update(NewORDENESRow)

        'RECARGA LAS ORDENES PARA EL TRABAJO SELECCIONADO
        ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJO_SERVICIORow.Id_TRABAJO)
        ORDEN_SERVICIORow = ORDENESDataSet.ORDENES.Rows(ORDENESDataSet.ORDENES.Rows.Count - 1)
        'CARGA OBSERVACIONES
        NewOBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
        NewOBSERVACIONESRow("NRO_ORDENINT") = ORDEN_SERVICIORow.NRO_ORDENINT
        NewOBSERVACIONESRow("NROORDINAL") = 0
        NewOBSERVACIONESRow("OBSORIGEN") = TXT_OBS.Text
        ORDENESDataSet.OBESERVACIONES.AddOBESERVACIONESRow(NewOBSERVACIONESRow)
        OBESERVACIONESTableAdapter.Update(NewOBSERVACIONESRow)

        'CARGA HISTORICO
        NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
        NewHISTORICORow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
        NewHISTORICORow("ID_TRABAJO") = TRABAJO_SERVICIORow.Id_TRABAJO
        NewHISTORICORow("ID_ORDENINT") = ORDEN_SERVICIORow.NRO_ORDENINT
        NewHISTORICORow("FECHA") = Now
        NewHISTORICORow("STATUSANTERIOR") = "-------"
        NewHISTORICORow("STATUSACTUAL") = "INGRESADOINT"
        NewHISTORICORow("CAUSA") = "Ingreso nueva Orden"
        NewHISTORICORow("DETALLE") = "Ingreso nueva Orden"
        NewHISTORICORow("EJECUTANTE") = FULLNOMBRE
        ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)

        NewHISTORICORow = ORDENESDataSet.HISTORICO.NewHISTORICORow
        NewHISTORICORow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
        NewHISTORICORow("ID_TRABAJO") = TRABAJO_SERVICIORow.Id_TRABAJO
        NewHISTORICORow("ID_ORDENINT") = ORDEN_SERVICIORow.NRO_ORDENINT
        NewHISTORICORow("FECHA") = Now
        NewHISTORICORow("STATUSANTERIOR") = "INGRESADOINT"
        NewHISTORICORow("STATUSACTUAL") = "ASIGNADO"
        NewHISTORICORow("CAUSA") = "ASIGNACION DE ORDEN"
        NewHISTORICORow("DETALLE") = "ASIGNADO A: ZELMAR LAGOS"
        NewHISTORICORow("EJECUTANTE") = FULLNOMBRE
        'GUARDA EL HISTORICO PROCESADO
        ORDENESDataSet.HISTORICO.AddHISTORICORow(NewHISTORICORow)
        HISTORICOTableAdapter.Update(ORDENESDataSet.HISTORICO)
        If DGV_ADJUNTO.Rows.Count > 0 Then
            AGREGAR_ARCHIVO()
        End If

        'ENVIA MENSAJE 

        If CB_CAUSAS.Text = "SOLICITADO POR TERCEROS" Or CB_PRIORIDAD.Text = "URGENTE" Or CB_PRIORIDAD.Text = "ALTA" Then
            SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, SECTOR)
            Dim REMITENTE_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")

            MENSAJE = "Se genera la orden " & ORDEN_SERVICIORow.NRO_ORDENINT & " con motivo: SERVICIOS, asignado."
            If TXT_OBS.Text <> "" Then
                MENSAJE += vbNewLine & vbNewLine & "Detalle de la orden:" & vbNewLine & "    "
                MENSAJE += TXT_OBS.Text
            End If
            ENVIAR_EMAIL(CB_PRIORIDAD.Text, emailDestino, "NUEVA ORDEN SERVICIO", MENSAJE, REMITENTE) '
        End If

        BORRAR_CAMPOS()

    End Sub
    Private Sub BORRAR_CAMPOS()
        TXT_NODO.Text = ""
        TXT_NRO.Text = ""
        TXT_CALLE.Text = ""
        IND_CALLE.Text = "*"
        CB_TIPO.Text = "TAREA"
        TXT_ORDEN_OC.Text = ""
        TXT_ORDENINT.Text = ""
        CB_PRIORIDAD.Text = "BAJA"
        ORDENESDataSet.ADJUNTOS.Clear()
        CK_DOCUMENTO_FISICO.AutoCheck = False
        TXT_ESQ1.Text = ""
        TXT_ESQ2.Text = ""
        TXT_OBS.Text = ""
        TXT_SEC.Text = ""
        TXT_SEG.Text = ""
        TXT_MAN.Text = ""
        CB_CAUSAS.Text = ""

    End Sub
    Private Sub BTN_ADJUNTAR_Click(sender As Object, e As EventArgs) Handles BTN_ADJUNTAR.Click
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Dim RESULTADO As DialogResult = OpenFileDialog1.ShowDialog()
            If RESULTADO = DialogResult.OK Then
                For A = 0 To OpenFileDialog1.FileNames.Length - 1
                    NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                    NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileNames(A))
                    ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                    DGV_ADJUNTO.Refresh()
                Next
            End If
        Else
            TIPOACCION = "SERVICIOS"
            If FOpenFileDialog.Visible = True Then
                FOpenFileDialog.BringToFront()
            Else
                FOpenFileDialog.Show(Me)
            End If
        End If
    End Sub
    Private Sub AGREGAR_ARCHIVO()

        Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
        Dim MSGBOX1 As MsgBoxResult
        Dim mover As Boolean = False
        If Directory.Exists(PathADJUNTOS) = False Then
            Directory.CreateDirectory(PathADJUNTOS)
        End If 'CREA EL DIRECTORIO ADJUNTOS SI NO EXISTE
        If Directory.Exists(PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO) = False Then
            Directory.CreateDirectory(PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO)
        End If 'PREGUNTAMOS SI EXISTE EL DIRECTORIO CREADO, DE LO CONTRARIO SE CREA

        'SE PREGUNTA SI SE QUIERE MOVER EL ARCHIVO A ADJUNTAR
        MSGBOX1 = MsgBox("MOVER ARCHIVO/S SELECCIONADO?" & vbNewLine & vbNewLine & "Si selecciona SI, borra el archivo seleccionado" & vbNewLine & "en caso contrario lo mantiene" & vbNewLine & "Para ambos casos el sistema creará un nuevo archivo" & vbNewLine & "asociado a la orden", vbYesNo, "ARCHIVO SELECCIONADO")
        If MSGBOX1 = DialogResult.Yes Then
            mover = True
        End If

        Dim CANTARCHIVOS As Integer = Directory.GetFiles(PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\").Count
        Dim NombreArchivos = Directory.GetFiles(PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\")
        Dim IgualArchivo As Boolean

        ORDENESDataSet.ADJUNTOS.Clear()
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            For A = 0 To OpenFileDialog1.FileNames.Length - 1
                NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                NewADJUNTOSRow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
                NewADJUNTOSRow("ID_TRABAJO") = TRABAJO_SERVICIORow.Id_TRABAJO
                NewADJUNTOSRow("ID_ORDEN") = ORDEN_SERVICIORow.NRO_ORDENINT
                PathRuta = OpenFileDialog1.FileNames(A)
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        'VERIFICAMOS SI YA EXISTE UN ARCHIVO QUE SE LLAME IGUAL, DENTRO DE LA CARPETA
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = ORDEN_SERVICIORow.NRO_ORDENINT.ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A))
                            File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A))
                            File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A))
                    File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(OpenFileDialog1.FileNames(A)), True)
                End If
                NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileNames(A))
                If mover = True Then
                    Try
                        File.Delete(PathRuta)
                    Catch ex As Exception
                        MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                    End Try
                End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                ADJUNTOSTableAdapter.Update(NewADJUNTOSRow)
            Next A
        Else
            For A = 0 To ListArchivos.SelectedItems.Count - 1
                PathRuta = ListArchivos.SelectedItems(A).SubItems(0).Text
                NewADJUNTOSRow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                NewADJUNTOSRow("ID_GESTION") = GESTION_SERVICIORow.Id_GESTION
                NewADJUNTOSRow("ID_TRABAJO") = TRABAJO_SERVICIORow.Id_TRABAJO
                NewADJUNTOSRow("ID_ORDEN") = ORDEN_SERVICIORow.NRO_ORDENINT
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_ORDENESRow("NRO_ORDENINT").ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTOSRow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                    File.Copy(PathRuta, PathADJUNTOS & "\" & GESTION_SERVICIORow.Id_GESTION & "\" & TRABAJO_SERVICIORow.Id_TRABAJO & "\" & ORDEN_SERVICIORow.NRO_ORDENINT & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                End If
                NewADJUNTOSRow("NOM_ARCHIVO") = ListArchivos.SelectedItems(A).SubItems(1).Text
                If mover = True Then
                    Try
                        File.Delete(PathRuta)
                    Catch ex As Exception
                        MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                    End Try
                End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
                ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTOSRow)
                ADJUNTOSTableAdapter.Update(NewADJUNTOSRow)
            Next A
        End If

    End Sub
    Private Sub INDICE_CALLESDataGridView_LostFocus(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.LostFocus
        INDICE_CALLESDataGridView.Visible = False
    End Sub
    Private Sub TXT_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
        ' Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = TXT_CALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        INDICE_CALLESBindingSource.DataSource = VISTACALLE
        INDICE_CALLESDataGridView.Columns(0).Visible = False
    End Sub
    Private Sub TXT_CALLE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_CALLE.KeyDown
        If TXT_CALLE.Text.Length > 2 Then
            INDICE_CALLESDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Enter Then
            If INDICE_CALLESDataGridView.Rows.Count = 1 Then
                TXT_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                INDICE_CALLESDataGridView.Visible = False
                TXT_NRO.Focus()
            Else
                TXT_CALLE.Text = ""
                IND_CALLE.Text = "0"
                INDICE_CALLESDataGridView.Visible = False
                TXT_NRO.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            TXT_CALLE.Text = ""
            IND_CALLE.Text = "0"
            INDICE_CALLESDataGridView.Visible = False
            TXT_NRO.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            INDICE_CALLESDataGridView.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
            IND_CALLE.Text = 0
            TXT_CALLE.Text = ""
        End If
    End Sub
    Private Sub TXT_CALLE_DoubleClick(sender As Object, e As EventArgs) Handles TXT_CALLE.DoubleClick
        If INDICE_CALLESDataGridView.Visible = False Then
            INDICE_CALLESDataGridView.Visible = True
            INDICE_CALLESDataGridView.Columns(0).Visible = False
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles INDICE_CALLESDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
            TXT_NRO.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            TXT_CALLE.Text = ""
            IND_CALLE.Text = "0"
            INDICE_CALLESDataGridView.Visible = False
            TXT_NRO.Focus()
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.DoubleClick
        If INDICE_CALLESDataGridView.RowCount > 0 Then
            TXT_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    Private Sub DGV_ORDENES_Click(sender As Object, e As EventArgs) Handles DGV_ORDENES.Click
        Cursor = Cursors.WaitCursor
        If DGV_ORDENES.Rows.Count > 0 Then
            ORDENESTableAdapter.FillByIDORDENINT(OrdenesDataSet1.ORDENES, DGV_ORDENES.SelectedCells.Item(0).Value)
            If OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                ORDEN_SERVICIORow = OrdenesDataSet1.ORDENES.Rows(0)
                If ORDEN_SERVICIORow.OC_APROBADO Then
                    BTN_APROBAR.Enabled = False
                Else
                    BTN_APROBAR.Enabled = True
                End If
                OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, ORDEN_SERVICIORow.NRO_ORDENINT)
                If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                    OBS_ORIGEN.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")
                    If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")
                Else
                    OBS_CIERRE.Text = ""
                    OBS_ORIGEN.Text = ""
                End If
            End If
        Else
            BTN_APROBAR.Enabled = False
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs)
        Dim STATUS As String
        If CK_STATUS.Text = "TODOS" Then
            STATUS = ""

        Else
            STATUS = CK_STATUS.Text
        End If

    End Sub
    Private Sub BUSCA_NODO_TextChanged(sender As Object, e As EventArgs) Handles BUSCA_NODO.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub FILTRO_ZONA_TextChanged(sender As Object, e As EventArgs) Handles FILTRO_ZONA.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_ING_CALLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_ING_CALLE.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_ING_NRO_TextChanged(sender As Object, e As EventArgs) Handles TXT_ING_NRO.TextChanged
        BUSCA_TIPO()
    End Sub
    Private Sub CK_STATUS_MouseClick(sender As Object, e As MouseEventArgs) Handles CK_STATUS.MouseClick
        BUSCA_TIPO()
    End Sub
    Private Sub TXT_ORDENINT_TextChanged(sender As Object, e As EventArgs) Handles TXT_ORDENINT.TextChanged
        Try
            BUSCA_TIPO()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TXT_OC_TextChanged(sender As Object, e As EventArgs) Handles TXT_OC.TextChanged
        BUSCA_TIPO()
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
    Private Sub DGV_ORDENES_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_ORDENES.MouseDoubleClick
        Cursor = Cursors.WaitCursor
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            '  ORDEN_SERVICIORow = ORDENESDataSet.ORDENES.Rows()

            GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, DGV_ORDENES.CurrentRow.Cells(2).Value)
            GESTION_SERVICIORow = ORDENESDataSet.GESTION.Rows(0)
            'TRABAJOSTableAdapter.FillByID_TRABAJO(ORDENESDataSet.TRABAJOS, ORDEN_SERVICIORow("ID_TRABAJO"))
            'BUSQUEDA_TRABAJOROW = DGV_ORDENES.TRABAJOS.Rows(0)

            ACCESO_TIPO = "TRABAJO"
            ACCESO_DESDE = "BUSCADOR"
            ACCESO_GESTION = DGV_ORDENES.CurrentRow.Cells(2).Value
            ACCESO_TRABAJO = DGV_ORDENES.CurrentRow.Cells(3).Value
            NROORDENINT = DGV_ORDENES.CurrentRow.Cells(0).Value

            If GESTION_SERVICIORow("AREA") = "MDU" Then
                INGRESO_AREA = "MDU"
            Else
                INGRESO_AREA = GESTION_SERVICIORow("AREA")
                If GESTION_SERVICIORow("AREA") = "RED" Then
                    DATOS.GEST_NODO.Text = GESTION_SERVICIORow("NODO")
                End If
            End If
        End If
        abrirDatos()
        Cursor = Cursors.Default
    End Sub
    Private Sub CK_STATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CK_STATUS.SelectedIndexChanged
        If CK_STATUS.Text = "TODOS" Then

        Else
            BUSCA_TIPO()
        End If
    End Sub
    Private Sub TXT_CANT_OC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANT_OC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_APROBAR_Click(sender As Object, e As EventArgs) Handles BTN_APROBAR.Click
        '   If CB_CAUSAS.Text = "SOLICITADO POR TERCEROS" Or CB_PRIORIDAD.Text = "URGENTE" Or CB_PRIORIDAD.Text = "ALTA" Then
        Cursor = Cursors.WaitCursor
        SECTORESTableAdapter.FillBySECTOR(ORDENESDataSet.SECTORES, SECTOR)
        Dim REMITENTE_SECTOR As String = ORDENESDataSet.SECTORES.Rows(0).Item("EMAIL")

        MENSAJE = "Se APRUEBA la orden " & ORDEN_SERVICIORow.NRO_ORDENINT & ", habilitando poder finalizar la incidencia."
        If TXT_OBS.Text <> "" Then
            MENSAJE += vbNewLine & vbNewLine & "Detalle de la orden:" & vbNewLine & "    "
            MENSAJE += OBS_ORIGEN.Text
        End If
        ORDEN_SERVICIORow.OC_APROBADO = True
        ORDENESTableAdapter.Update(ORDEN_SERVICIORow)
        NOTIFICACION("SYS", "orden APROBADA")
        ENVIAR_EMAIL("BAJA", emailDestino, "APROBACION ORDEN SERVICIO", MENSAJE, REMITENTE) '
        Cursor = Cursors.Default
        'End If
    End Sub

    Private Sub BTN_REFRESCAR_Click(sender As Object, e As EventArgs) Handles BTN_REFRESCAR.Click
        Cursor = Cursors.WaitCursor
        ORDENESTableAdapter.FillByDISENO(ORDENESDataSet.ORDENES)
        ORDENESBindingSource1.MoveLast()
        Cursor = Cursors.Default
    End Sub
End Class