Imports System.IO
Public Class FUENTES
    Public INST_INT As String

    'Dim NewTRABAJOS As BASEFUENTESDataSet.TRABAJOSRow
    Dim NewAFECTACION As ORDENESDataSet.AFECTACIONRow
    Dim NewHISTORICO As BASEFUENTESDataSet.HISTORICORow
    Dim AFECTACIONRow As DataRow
    Dim OBSERVACIONESRow As DataRow
    Dim ActBASE As DataRow


    Public BUSCA_FUENTE As String
    Dim BUSCA_HISTORICO As String
    Dim FUENTEEDITADA As String
    Dim ESTADO_ACTIVACION As Boolean

    Public ACCION_FUENTE As String
    Dim ESQUINA As String

    Dim CANTIDADFUE As Integer
    Dim FECHAINSTALACION As String
    Dim TOTAL_BAT As Integer


    Dim BUSCA_COD As String


    Public CAMPO(10) As String
    Dim DATO(10) As String
    Dim FILTRO(10) As String

    Dim IPTRANSP As String
    Dim IPNUEVA As String
    Dim NODONRO As String
    Dim CANTFUE As String
    Dim NUEVOID2 As String

    Dim HIST_ORDENINT As Integer
    Dim HIST_FECHA As Date
    Private Sub GENERAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BIENVENIDOS!!!!
    End Sub
    Private Sub FUENTES_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FUENTETableAdapter.FillByFUENTES(BASEFUENTESDataSet.FUENTE)
        INFORMACION_GRAL()
    End Sub
    Private Sub INFORMACION_GRAL()
        TOTAL_BAT = 0
        CANTIDADFUE = INSTALACIONDataGridView.Rows.Count
        CANT_FUE.Text = CANTIDADFUE
        For X = 0 To INSTALACIONDataGridView.Rows.Count - 1
            If IsNumeric(INSTALACIONDataGridView.Rows(X).Cells(10).Value) Then TOTAL_BAT += CInt(INSTALACIONDataGridView.Rows(X).Cells(10).Value)
        Next
        TOTAL_BATERIAS.Text = TOTAL_BAT
    End Sub
    Private Sub INSTALACIONDataGridView_Click(sender As Object, e As MouseEventArgs) Handles INSTALACIONDataGridView.Click
        Me.Cursor = Cursors.WaitCursor
        If INSTALACIONDataGridView.Rows.Count > 0 Then
            Cursor = DefaultCursor
            SELECCIONA_FUENTE()
            If e.Button = Windows.Forms.MouseButtons.Left Then
                INSTALACIONDataGridView.ContextMenuStrip = MENU_INSTALACION
            End If
        End If
    End Sub
    Private Sub ORDENESDataGridView_Click(sender As Object, e As MouseEventArgs) Handles ORDENESDataGridView.Click

        If e.Button = Windows.Forms.MouseButtons.Left Then
            PROCESOS.Text = "BUSCANDO OBSERVACIONES"
            PROCESOS.Refresh()
            OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, ORDENESDataGridView.CurrentRow.Cells.Item(0).Value)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                For I = 0 To ORDENESDataSet.OBESERVACIONES.Rows.Count - 1
                    OBSERVACIONESRow = ORDENESDataSet.OBESERVACIONES.Rows(I)
                    Select Case OBSERVACIONESRow("NROORDINAL")
                        Case 0
                            OBS_ORIGEN.Text = OBSERVACIONESRow("OBSORIGEN")
                            If IsDBNull(OBSERVACIONESRow("OBSCIERRE")) = False Then OBS_CIERRE.Text = OBSERVACIONESRow("OBSCIERRE") Else OBS_CIERRE.Text = ""
                        Case Else
                            OBS_ORIGEN.Text = OBSERVACIONESRow("OBSORIGEN")
                            If IsDBNull(OBSERVACIONESRow("OBSCIERRE")) = False Then OBS_CIERRE.Text = OBSERVACIONESRow("OBSCIERRE") Else OBS_CIERRE.Text = ""
                    End Select
                Next I
            End If
            INSTALACIONDataGridView.ContextMenuStrip = MENU_INSTALACION
            ORDENESDataGridView.ContextMenuStrip = MENU_ORDENES
            PROCESOS.Text = ""
            PROCESOS.Refresh()
        End If
    End Sub
    Private Sub SELECCIONA_FUENTE()
        Me.Cursor = Cursors.WaitCursor
        PROCESOS.Text = "BUSCANDO FUENTE"
        PROCESOS.Refresh()
        'CARGA VARIABLES PARA TRAER DATOS DE LA FUENTE SELECCIONADA
        FUENTE_ID = INSTALACIONDataGridView.CurrentRow.Cells.Item(0).Value 'ID ÚNICO DE FUENTE POR DIRECCION
        FUENTE_INSTALACIONRUS = INSTALACIONDataGridView.CurrentRow.Cells.Item(1).Value 'ES LA INSTALACION DEL SISTEMA DE ORDINALES
        FUENTE_INSTALACION = INSTALACIONDataGridView.CurrentRow.Cells.Item(2).Value ' ES EL CODIGO GENERADO SEGUN ALIMENTACION DE FUENTE

        ETI_FUENTE.Text = FUENTE_INSTALACIONRUS & " - " & FUENTE_INSTALACION  'ACTUALIZA LA ETIQUETA DE LA FUENTE BUSCADA

        'CARGA LOS DATOS DE LA FUENTE EN LOS CAMPOS DE TEXTO
        PROCESOS.Text = "CARGANDO DATOS FUENTE"
        PROCESOS.Refresh()

        'PROCEDIMIENTO PARA CARGAR LAS OBSERVACIONES DE LAS ORDENES
        VER_ORDEN()

        'BUSCA LA AFECTACION DE LA FUENTE
        PROCESOS.Text = "BUSCANDO AFECTACION"
        PROCESOS.Refresh()
        AFECTACIONTableAdapter.FillByINSTALACION(ORDENESDataSet.AFECTACION, FUENTE_ID)

        'MODIFICA EL ESTADO DE LOS BOTONES DE ACCION
        BOT_CARGARTRABAJOS.Enabled = True

        'PRCEDIMIENTO PARA CARGAR LA VARIABLE DE AFECTACION EN LAS ORDENES Y/O ORDINALES
        If ORDENESDataSet.AFECTACION.Rows.Count = 0 Then
            Cursor = DefaultCursor
            MsgBox("La fuente seleccionada no tiene cargada la afectacion " & vbNewLine & "Cargue la misma en modificacion", vbInformation)
            Me.Cursor = Cursors.WaitCursor
        Else
            FUENTE_AFECTACION = ""
            For I = 0 To ORDENESDataSet.AFECTACION.Rows.Count - 1
                AFECTACIONRow = ORDENESDataSet.AFECTACION.Rows(I)
                If I < ORDENESDataSet.AFECTACION.Rows.Count - 1 Then
                    FUENTE_AFECTACION += AFECTACIONRow("NODO") & AFECTACIONRow("ZONA") & ","
                Else
                    FUENTE_AFECTACION += AFECTACIONRow("NODO") & AFECTACIONRow("ZONA")
                End If
            Next I
        End If
        FUENTE_NODO = INSTALACIONDataGridView.CurrentRow.Cells.Item(3).Value
        FUENTE_ZONA = INSTALACIONDataGridView.CurrentRow.Cells.Item(4).Value
        FUENTE_CALLE = INSTALACIONDataGridView.CurrentRow.Cells.Item(5).Value
        FUENTE_NRO = INSTALACIONDataGridView.CurrentRow.Cells.Item(6).Value

        PROCESOS.Text = ""
        PROCESOS.Refresh()

        Me.Cursor = DefaultCursor
    End Sub
    Private Sub VER_ORDEN()
        PROCESOS.Text = "CARGANDO ORDENES"
        PROCESOS.Refresh()
        ORDENESDataSet.OBESERVACIONES.Clear()
        ORDENESTableAdapter.FillByINSTALACION(ORDENESDataSet.ORDENES, FUENTE_ID)
        'End If
        'End If
        ORDENESBindingSource.MoveLast()
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            OBESERVACIONESTableAdapter.FillByNROORDENINT(ORDENESDataSet.OBESERVACIONES, ORDENESDataGridView.CurrentRow.Cells(0).Value)
            If ORDENESDataSet.OBESERVACIONES.Rows.Count > 0 Then
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE") Else OBS_CIERRE.Text = ""
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")) = False Then OBS_ORIGEN.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN") Else OBS_ORIGEN.Text = ""
            Else
                OBESERVACIONESTableAdapter.FillByNROORDINAL(ORDENESDataSet.OBESERVACIONES, ORDENESDataGridView.CurrentRow.Cells(1).Value)
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE")) = False Then OBS_CIERRE.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSCIERRE") Else OBS_CIERRE.Text = ""
                If IsDBNull(ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN")) = False Then OBS_ORIGEN.Text = ORDENESDataSet.OBESERVACIONES.Rows(0).Item("OBSORIGEN") Else OBS_ORIGEN.Text = ""
            End If
        End If
    End Sub
    Private Sub TXT_CARGA_REAL_TextChanged(sender As Object, e As EventArgs)
        '  CALCULADORA_CARGA()
    End Sub

    'Private Sub HABILITA_CAMPOS()
    '    C_CALLE.ReadOnly = False
    '    C_CALLE.BackColor = Color.DarkSlateBlue
    '    C_IP.ReadOnly = False
    '    C_IP.BackColor = Color.DarkSlateBlue
    '    C_ESQUINA.ReadOnly = False
    '    C_ESQUINA.BackColor = Color.DarkSlateBlue
    '    C_NRO.ReadOnly = False
    '    C_NRO.BackColor = Color.DarkSlateBlue
    '    C_ID2.ReadOnly = False
    '    C_ID2.BackColor = Color.DarkSlateBlue
    '    C_IMEI.ReadOnly = False
    '    C_IMEI.BackColor = Color.DarkSlateBlue
    '    C_IP.ReadOnly = False
    '    C_IP.BackColor = Color.DarkSlateBlue
    '    C_LEX.ReadOnly = False
    '    C_LEX.BackColor = Color.DarkSlateBlue
    '    C_MAC.ReadOnly = False
    '    C_MAC.BackColor = Color.DarkSlateBlue
    '    C_MB.ReadOnly = False
    '    C_MB.BackColor = Color.DarkSlateBlue
    '    C_MODBAT.BackColor = Color.DarkSlateBlue
    '    C_MODFUENTE.BackColor = Color.DarkSlateBlue
    '    C_MODGAB.BackColor = Color.DarkSlateBlue
    '    C_NODO.BackColor = Color.DarkSlateBlue
    '    C_PIN.ReadOnly = False
    '    C_PIN.BackColor = Color.DarkSlateBlue
    '    C_PUK.ReadOnly = False
    '    C_PUK.BackColor = Color.DarkSlateBlue
    '    C_RX.ReadOnly = False
    '    C_RX.BackColor = Color.DarkSlateBlue
    '    C_TR.ReadOnly = False
    '    C_TR.BackColor = Color.DarkSlateBlue
    '    C_VPN1.ReadOnly = False
    '    C_VPN1.BackColor = Color.DarkSlateBlue
    '    C_VPN2.ReadOnly = False
    '    C_VPN2.BackColor = Color.DarkSlateBlue
    '    '    C_ZONAA.ReadOnly = False
    '    '   C_ZONAA.BackColor = Color.DarkSlateBlue
    '    C_ZONAG.ReadOnly = False
    '    C_ZONAG.BackColor = Color.DarkSlateBlue
    '    INSTALACION.ReadOnly = False
    '    INSTALACION.BackColor = Color.DarkSlateBlue
    '    FECHAFAB.ReadOnly = False
    '    FECHAFAB.BackColor = Color.DarkSlateBlue


    'End Sub

    'Private Sub CARAGA_DATOScomun()

    '    For I = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 1
    '        NewINSTALACION = BASEFUENTESDataSet.INSTALACION.Rows(I)
    '        If NewINSTALACION("Id") = BUSCA_ID Then
    '            C_CALLE.Text = NewINSTALACION("CALLE")
    '            C_CANTBAT.Text = NewINSTALACION("CANTBATERIA")
    '            C_ESQUINA.Text = NewINSTALACION("ESQUINA")
    '            If IsDBNull(NewINSTALACION("NRO")) = False Then C_NRO.Text = NewINSTALACION("NRO")
    '            NewINSTALACION("ID2") = ""
    '            NewINSTALACION("IMEI") = ""
    '            C_IP.Text = NewINSTALACION("IPMODEM") = ""
    '            If IsDBNull(NewINSTALACION("LE")) = False Then C_LEX.Text = NewINSTALACION("LE")
    '            NewINSTALACION("MAC") = ""

    '            If IsDBNull(NewINSTALACION("BR")) = False Then C_MB.Text = NewINSTALACION("BR")
    '            NewINSTALACION("MODBATERIA") = ""
    '            'C_MODFUENTE.Text = ActINSTALACION("MODFUENTE")
    '            If IsDBNull(NewINSTALACION("MODGABINETE")) = False Then C_MODGAB.Text = NewINSTALACION("MODGABINETE")
    '            C_NODO.Text = NewINSTALACION("NODO")
    '            NewINSTALACION("PIN") = ""
    '            NewINSTALACION("PUK") = ""
    '            If IsDBNull(NewINSTALACION("RX")) = False Then C_RX.Text = NewINSTALACION("RX")
    '            If IsDBNull(NewINSTALACION("TR")) = False Then C_TR.Text = NewINSTALACION("TR")
    '            NewINSTALACION("VPN1") = ""
    '            NewINSTALACION("VPN2") = ""
    '            '      If IsDBNull(NewINSTALACION("ZONA")) = False Then C_ZONAA.Text = NewINSTALACION("ZONA")
    '            If IsDBNull(NewINSTALACION("ZONAG")) = False Then C_ZONAG.Text = NewINSTALACION("ZONAG")
    '            C_CARGA.Text = NewINSTALACION("ITOTAL").ToString
    '            C_AUTONOMIA.Text = NewINSTALACION("AUTONOMIA").ToString
    '            If IsDBNull(NewINSTALACION("CODORD")) = False Then INSTALACION.Text = NewINSTALACION("CODORD")
    '            Exit Sub
    '        End If
    '    Next


    'End Sub
    Private Sub REG_BATERIAS()

        'CARGA DATOS DE BATERIAS DE ACUERDO A LA CANTIDAD
        Select Case ActBASE("CANTB")
            Case 2
                NewHISTORICO("BAT1MARCA") = "ALPHA"
                NewHISTORICO("BAT1MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT1SERIE") = ""
                NewHISTORICO("BAT1FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT2MARCA") = "ALPHA"
                NewHISTORICO("BAT2MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT2SERIE") = ""
                NewHISTORICO("BAT2FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT3MARCA") = ""
                NewHISTORICO("BAT3MOD") = ""
                NewHISTORICO("BAT3SERIE") = ""
                'NewHISTORICO("BAT3FECHAFAB") = ""
                NewHISTORICO("BAT4MARCA") = ""
                NewHISTORICO("BAT4MOD") = ""
                NewHISTORICO("BAT4SERIE") = ""
                'NewHISTORICO("BAT4FECHAFAB") = ""
            Case 3
                NewHISTORICO("BAT1MARCA") = "ALPHA"
                NewHISTORICO("BAT1MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT1SERIE") = ""
                NewHISTORICO("BAT1FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT2MARCA") = "ALPHA"
                NewHISTORICO("BAT2MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT2SERIE") = ""
                NewHISTORICO("BAT2FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT3MARCA") = "ALPHA"
                NewHISTORICO("BAT3MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT3SERIE") = ""
                NewHISTORICO("BAT3FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT4MARCA") = ""
                NewHISTORICO("BAT4MOD") = ""
                NewHISTORICO("BAT4SERIE") = ""
                'NewHISTORICO("BAT4FECHAFAB") = ""
            Case 4
                NewHISTORICO("BAT1MARCA") = "ALPHA"
                NewHISTORICO("BAT1MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT1SERIE") = ""
                NewHISTORICO("BAT1FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT2MARCA") = "ALPHA"
                NewHISTORICO("BAT2MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT2SERIE") = ""
                NewHISTORICO("BAT2FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT3MARCA") = "ALPHA"
                NewHISTORICO("BAT3MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT3SERIE") = ""
                NewHISTORICO("BAT3FECHAFAB") = ActBASE("FECHAFABBAT")
                NewHISTORICO("BAT4MARCA") = "ALPHA"
                NewHISTORICO("BAT4MOD") = ActBASE("MODBAT")
                NewHISTORICO("BAT4SERIE") = ""
                NewHISTORICO("BAT4FECHAFAB") = ActBASE("FECHAFABBAT")

        End Select
    End Sub
    Private Sub FILTRA_FUENTE()
        Dim VISTAFUENTE As DataView = BASEFUENTESDataSet.FUENTE.AsDataView
        CAMPO(0) = ("INSTALACION")
        DATO(0) = BUSC_CODIGO.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"

        CAMPO(1) = ("NODO")
        DATO(1) = BUSC_NODO.Text
        If BUSC_NODO.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND  [" & CAMPO(1) & "] = '" & DATO(1) & "'"
        End If
        If BUSC_ZONA.Text = "" Then
            FILTRO(2) = ""
        Else
            CAMPO(2) = ("ZONA")
            DATO(2) = BUSC_ZONA.Text
            FILTRO(2) = " AND  [" & CAMPO(2) & "] like '*" & DATO(2) & "*'"
        End If
        If BUSC_CALLE.Text = "" Then
            FILTRO(3) = ""
        Else
            CAMPO(3) = ("CALLE")
            DATO(3) = BUSC_CALLE.Text
            FILTRO(3) = " AND  [" & CAMPO(3) & "] like '*" & DATO(3) & "*'"
        End If
        If BUSCA_INST.Text = "" Then
            FILTRO(4) = ""
        Else
            CAMPO(4) = ("INSTALACION_RUS")
            DATO(4) = BUSCA_INST.Text
            FILTRO(4) = " AND  [" & CAMPO(4) & "] like '*" & DATO(4) & "*'"
        End If

        If BUSC_FUENTE.Text = "" Then
            FILTRO(5) = ""
        Else
            CAMPO(5) = ("MODFUENTE")
            DATO(5) = BUSC_FUENTE.Text
            FILTRO(5) = " AND  [" & CAMPO(5) & "] like '*" & DATO(5) & "*'"
        End If

        If FILTRO_TIPO_BATERIA.Text = "" Then
            FILTRO(6) = ""
        Else
            CAMPO(6) = ("MODBATERIA")
            DATO(6) = FILTRO_TIPO_BATERIA.Text
            FILTRO(6) = " AND  [" & CAMPO(6) & "] like '*" & DATO(6) & "*'"
        End If

        If BUSCA_CANT_BAT.Text = "" Then
            FILTRO(7) = ""
        Else
            CAMPO(7) = ("CANT_BAT")
            DATO(7) = BUSCA_CANT_BAT.Text
            FILTRO(7) = " AND  [" & CAMPO(7) & "] like '*" & DATO(7) & "*'"
        End If
        If Len(BUSCA_FECHA_BAT.Text) < 4 Then
            FILTRO(8) = ""
        Else
            CAMPO(8) = ("FECHA_BAT")
            DATO(8) = BUSCA_FECHA_BAT.Text
            FILTRO(8) = " AND  [" & CAMPO(8) & "] like '*" & DATO(8) & "*'"
        End If
        'CAMPO(9) = ("ACTUAL")
        'DATO(9) = BUSC_ACTUAL.Checked
        'FILTRO(9) = " AND  [" & CAMPO(9) & "] = " & DATO(9)

        'If BUSC_ACTUAL.Checked = True Then
        '    VISTAFUENTE.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) & FILTRO(4) & FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8) & FILTRO(9)
        'Else
        VISTAFUENTE.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) & FILTRO(4) & FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8)

        FUENTEBindingSource.DataSource = VISTAFUENTE
        INFORMACION_GRAL()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BUSC_CODIGO.Text = ""
        BUSC_CALLE.Text = ""
        BUSCA_INST.Text = ""
        BUSC_FUENTE.Text = ""
        BUSC_NODO.Text = ""
        BUSC_ZONA.Text = ""
    End Sub
    Private Sub BUSC_NODO_TextChanged(sender As Object, e As EventArgs) Handles BUSC_NODO.TextChanged
        If BUSC_NODO.Text <> "" Then
            BUSC_NODO.BackColor = Color.Red
        Else
            BUSC_NODO.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSC_ZONA_TextChanged(sender As Object, e As EventArgs) Handles BUSC_ZONA.TextChanged
        If BUSC_ZONA.Text <> "" Then
            BUSC_ZONA.BackColor = Color.Red
        Else
            BUSC_ZONA.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSC_CALLE_TextChanged(sender As Object, e As EventArgs) Handles BUSC_CALLE.TextChanged
        If BUSC_CALLE.Text <> "" Then
            BUSC_CALLE.BackColor = Color.Red
        Else
            BUSC_CALLE.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSC_FUENTE_TextChanged(sender As Object, e As EventArgs) Handles BUSC_FUENTE.TextChanged
        If BUSC_FUENTE.Text <> "" Then
            BUSC_FUENTE.BackColor = Color.Red
        Else
            BUSC_FUENTE.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSC_CODIGO_TextChanged(sender As Object, e As EventArgs) Handles BUSC_CODIGO.TextChanged
        If BUSC_CODIGO.Text <> "" Then
            BUSC_CODIGO.BackColor = Color.Red
        Else
            BUSC_CODIGO.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSCA_INST_TextChanged(sender As Object, e As EventArgs) Handles BUSCA_INST.TextChanged
        If BUSCA_INST.Text <> "" Then
            BUSCA_INST.BackColor = Color.Red
        Else
            BUSCA_INST.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub FILTRO_TIPO_BATERIA_TextChanged(sender As Object, e As EventArgs) Handles FILTRO_TIPO_BATERIA.TextChanged
        If FILTRO_TIPO_BATERIA.Text <> "" Then
            FILTRO_TIPO_BATERIA.BackColor = Color.Red
        Else
            FILTRO_TIPO_BATERIA.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSCA_CANT_BAT_TextChanged(sender As Object, e As EventArgs) Handles BUSCA_CANT_BAT.TextChanged
        If BUSCA_CANT_BAT.Text <> "" Then
            BUSCA_CANT_BAT.BackColor = Color.Red
        Else
            BUSCA_CANT_BAT.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub BUSCA_FECHA_BAT_TextChanged(sender As Object, e As EventArgs) Handles BUSCA_FECHA_BAT.TextChanged
        If BUSCA_FECHA_BAT.Text <> "" Then
            BUSCA_FECHA_BAT.BackColor = Color.Red
        Else
            BUSCA_FECHA_BAT.BackColor = Color.FromArgb(64, 64, 64)
        End If
        FILTRA_FUENTE()
    End Sub
    Private Sub HISTORICODataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)

        'If IsDBNull(BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT1FECHAFAB")) = False Then
        '    BAT1_FECHAFAB.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT1FECHAFAB")
        '    BAT1_MOD.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT1MOD")
        '    BAT1_SERIE.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT1SERIE")
        '    BAT1_MARCA.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT1MARCA")
        'Else
        '    BAT1_FECHAFAB.Text = ""
        '    BAT1_MOD.Text = ""
        '    BAT1_MARCA.Text = ""
        '    BAT1_SERIE.Text = ""
        'End If

        'If IsDBNull(BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT2FECHAFAB")) = False Then
        '    BAT2_FECHAFAB.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT2FECHAFAB")
        '    BAT2_MOD.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT2MOD")
        '    BAT2_SERIE.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT2SERIE")
        '    BAT2_MARCA.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT2MARCA")
        'Else
        '    BAT2_FECHAFAB.Text = ""
        '    BAT2_MOD.Text = ""
        '    BAT2_MARCA.Text = ""
        '    BAT2_SERIE.Text = ""
        'End If

        'If IsDBNull(BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT3FECHAFAB")) = False Then
        '    BAT3_FECHAFAB.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT3FECHAFAB")
        '    BAT3_MOD.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT3MOD")
        '    BAT3_SERIE.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT3SERIE")
        '    BAT3_MARCA.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT3MARCA")
        'Else
        '    BAT3_FECHAFAB.Text = ""
        '    BAT3_MOD.Text = ""
        '    BAT3_MARCA.Text = ""
        '    BAT3_SERIE.Text = ""
        'End If

        'If IsDBNull(BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT4FECHAFAB")) = False Then
        '    BAT4_FECHAFAB.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT4FECHAFAB")
        '    BAT4_MOD.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT4MOD")
        '    BAT4_SERIE.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT4SERIE")
        '    BAT4_MARCA.Text = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position).Item("BAT4MARCA")
        'Else
        '    BAT4_FECHAFAB.Text = ""
        '    BAT4_MOD.Text = ""
        '    BAT4_MARCA.Text = ""
        '    BAT4_SERIE.Text = ""
        'End If

    End Sub
    Private Sub BOT_NUEVO_Click(sender As Object, e As EventArgs) Handles BOT_NUEVO.Click
        ACCION_FUENTE = "NUEVO"
        Me.Enabled = False
        If FUENTE_EDICION.Visible Then
            FUENTE_EDICION.Close()
            FUENTE_EDICION.Show(Me)
        Else
            FUENTE_EDICION.Show(Me)
        End If

    End Sub 'OK
    Private Sub BOT_EDITAR_Click(sender As Object, e As EventArgs) Handles BOT_EDITAR.Click
        ACCION_FUENTE = "EDITAR"
        Me.Enabled = False
        If FUENTE_EDICION.Visible Then
            FUENTE_EDICION.Close()
            FUENTE_EDICION.Show(Me)
        Else
            FUENTE_EDICION.Show(Me)
        End If

    End Sub 'OK
    Private Sub BOT_CARGARTRABAJOS_Click(sender As Object, e As EventArgs) Handles BOT_CARGARTRABAJOS.Click
        TRABAJOS.Show()
    End Sub

    Private Sub ABRE_DATOS()
        INSTALACIONDataGridView.ContextMenuStrip = Nothing
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
            End If
        End If
        INGRESO_AREA = "FUENTES"
        ACCESO_DESDE = "FUENTES"
        DATOS.GEST_NODO.Text = FUENTE_NODO
        DATOS.TopLevel = False
        DATOS.Parent = DASHBOARD.PanelTrabajo
        DATOS.Dock = DockStyle.Fill
        DATOS.Show()
        DATOS.BringToFront()
    End Sub
    Private Sub REMP_BAT_Click(sender As Object, e As EventArgs) Handles REMP_BAT.Click
        FUENTE_GESTION = "MANTENIMIENTO PROGRAMADO DE FUENTES"
        FUENTE_TRABAJO = "REEMPLAZO DE BATERIAS"
        ABRE_DATOS()

    End Sub
    Private Sub CONT_PER_Click(sender As Object, e As EventArgs) Handles CONT_PER.Click
        FUENTE_GESTION = "MANTENIMIENTO PROGRAMADO DE FUENTES"
        FUENTE_TRABAJO = "MEDICION Y CONTROL DE FUENTE"
        ABRE_DATOS()
    End Sub
    Private Sub PREV_RELEV_Click(sender As Object, e As EventArgs) Handles PREV_RELEV.Click
        FUENTE_GESTION = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        FUENTE_TRABAJO = "RELEVAMIENTO"
        ABRE_DATOS()
    End Sub
    Private Sub PREV_REEM_Click(sender As Object, e As EventArgs) Handles PREV_REEM.Click
        FUENTE_GESTION = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        FUENTE_TRABAJO = "REEMPLAZO DE FUENTE"
        ABRE_DATOS()
    End Sub
    Private Sub PREV_REPA_Click(sender As Object, e As EventArgs) Handles PREV_REPA.Click
        FUENTE_GESTION = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        FUENTE_TRABAJO = "REPARACION DE FUENTE"
        ABRE_DATOS()
    End Sub
    Private Sub PREV_CAMBIOUBICACION_Click(sender As Object, e As EventArgs) Handles PREV_CAMBIOUBICACION.Click
        FUENTE_GESTION = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        FUENTE_TRABAJO = "REEMPLAZO DE BATERIAS"
        ABRE_DATOS()
    End Sub
    Private Sub TRAB_RED_Click(sender As Object, e As EventArgs) Handles TRAB_RED.Click
        FUENTE_GESTION = "MANTENIMIENTO PREVENTIVO DE FUENTES"
        FUENTE_TRABAJO = "TRABAJOS DE RED"
        ABRE_DATOS()
    End Sub
    Private Sub CONTROLBATERIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLBATERIASToolStripMenuItem.Click
        FUENTE_GESTION = "TRABAJOS DE LABORATORIO"
        FUENTE_TRABAJO = "CONTROL BATERIAS"
        ABRE_DATOS()
    End Sub
    Private Sub CONTROLCOMPONENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLCOMPONENTESToolStripMenuItem.Click
        FUENTE_GESTION = "TRABAJOS DE LABORATORIO"
        FUENTE_TRABAJO = "CONTROL DE COMPONENTES DE FUENTE"
        ABRE_DATOS()
    End Sub
    Private Sub INSTALACIONFUENTEXOBRAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSTALACIONFUENTEXOBRAToolStripMenuItem.Click
        FUENTE_GESTION = "INSTALACION / RETIRO DE FUENTE X OBRA"
        FUENTE_TRABAJO = "INSTALACION FUENTE X OBRA"
        ABRE_DATOS()
    End Sub
    Private Sub RETIROFUENTEXOBRAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETIROFUENTEXOBRAToolStripMenuItem.Click
        FUENTE_GESTION = "INSTALACION / RETIRO DE FUENTE X OBRA"
        FUENTE_TRABAJO = "RETIRO FUENTE X OBRA"
        ABRE_DATOS()
    End Sub

    Private Sub DGVAdjuntos_DoubleClick(sender As Object, e As EventArgs) Handles DGVAdjuntos.DoubleClick
        Dim RUTA_ARCHIVOS As String
        If DGVAdjuntos.Rows.Count > 0 Then
            RUTA_ARCHIVOS = DGVAdjuntos.CurrentRow.Cells.Item(0).Value
            'ABRE EL ARCHIO SELECCIONADO EN EL LISTBOX
            Try
                If File.Exists(RUTA_ARCHIVOS) Then
                    Process.Start(RUTA_ARCHIVOS)
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub 'OK
    Private Sub BTN_REPORTE_Click(sender As Object, e As EventArgs) Handles BTN_REPORTE.Click
        Dim NEW_FUENTE_ROW As DataRow
        Dim FUENTE As BASEFUENTESDataSet.FUENTERow
        Dim ORDEN As ORDENESDataSet.ORDENESRow
        Dim TAREA As ORDENESDataSet.TAREASRow
        VER_INFORME_FUENTES.INFORME_FUENTESDataSet.Clear()
        FUENTETableAdapter.FillByFUENTES(BASEFUENTESDataSet.FUENTE)
        For X = 0 To BASEFUENTESDataSet.FUENTE.Rows.Count - 1
            FUENTE = BASEFUENTESDataSet.FUENTE.Rows(X)
            PROCESOS.Text = X & " - PROCESANDO FUENTE: " & FUENTE.INSTALACION_RUS
            PROCESOS.Refresh()

            ORDENESTableAdapter.FillByINSTALACIONRUS(ORDENESDataSet.ORDENES, FUENTE.ID_FUENTE)
            If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                For O = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                    ORDEN = ORDENESDataSet.ORDENES.Rows(O)
                    PROCESOS.Text = X & "  " & O & " - INTENTANDO ORDEN: " & ORDEN.NRO_ORDENINT
                    PROCESOS.Refresh()
                    If DateDiff(DateInterval.Day, ORDEN.FECHAFIN, Today) < 366 And ORDEN.NRO_ORDINAL <> 0 Then
                        PROCESOS.Text = X & "  " & O & " - ALIZANDO ORDEN: " & ORDEN.NRO_ORDENINT
                        PROCESOS.Refresh()
                        TAREASTableAdapter.FillByORDINAL(ORDENESDataSet.TAREAS, ORDEN.NRO_ORDINAL)
                        If ORDENESDataSet.TAREAS.Rows.Count > O Then
                            For T = 0 To ORDENESDataSet.TAREAS.Rows.Count - 1
                                TAREA = ORDENESDataSet.TAREAS.Rows(T)
                                PROCESOS.Text = X & "  " & ORDEN.NRO_ORDENINT & " - ALIZANDO TRABAJO: " & TAREA.ORDINAL
                                PROCESOS.Refresh()
                                NEW_FUENTE_ROW = VER_INFORME_FUENTES.INFORME_FUENTESDataSet.__INFORME.New__INFORMERow()
                                NEW_FUENTE_ROW("CODRUS_FUENTE") = FUENTE.INSTALACION_RUS
                                NEW_FUENTE_ROW("CALLE_FUENTE") = FUENTE.CALLE
                                NEW_FUENTE_ROW("PUERTA_FUENTE") = FUENTE.PUERTA
                                NEW_FUENTE_ROW("NODO_FUENTE") = FUENTE.NODO
                                NEW_FUENTE_ROW("ZONA_FUENTE") = FUENTE.ZONA
                                NEW_FUENTE_ROW("ORDENINT_FUENTE") = ORDEN.NRO_ORDENINT
                                NEW_FUENTE_ROW("ORDINAL_FUENTE") = ORDEN.NRO_ORDINAL
                                NEW_FUENTE_ROW("CUADRILLA_FUENTE") = ORDEN.CUADRILLA
                                If ORDEN.IsFECHAINICIONull Then
                                    If ORDEN.IsFECHAFINNull Then
                                        NEW_FUENTE_ROW("FECHAINI_FUENTE") = ""
                                    Else
                                        NEW_FUENTE_ROW("FECHAINI_FUENTE") = ORDEN.FECHAFIN
                                    End If
                                Else
                                    NEW_FUENTE_ROW("FECHAINI_FUENTE") = ORDEN.FECHAINICIO
                                End If
                                If ORDEN.IsFECHAFINNull Then
                                    NEW_FUENTE_ROW("FECHAFIN_FUENTE") = ""
                                Else
                                    NEW_FUENTE_ROW("FECHAFIN_FUENTE") = ORDEN.FECHAFIN
                                End If
                                NEW_FUENTE_ROW("MOTIVOORIGEN_FUENTE") = ORDEN.MOTIVOORIGEN
                                NEW_FUENTE_ROW("CAUSAORIGEN_FUENTE") = ORDEN.CAUSARIGEN
                                If TAREA.IsACTIVIDADDESCNull = False Then NEW_FUENTE_ROW("ACTIVIDAD_FUENTE") = TAREA.ACTIVIDADDESC
                                If TAREA.IsTAREADESCNull = False Then NEW_FUENTE_ROW("TAREADESC_FUENTE") = TAREA.TAREADESC
                                If TAREA.IsCANTREALNull = False Then NEW_FUENTE_ROW("CANT_REAL_FUENTE") = TAREA.CANTREAL
                                If TAREA.IsCANTSTDNull = False Then NEW_FUENTE_ROW("CANTSTD_FUENTE") = TAREA.CANTSTD
                                NEW_FUENTE_ROW("MODFUENTE_FUENTE") = FUENTE.MODFUENTE
                                NEW_FUENTE_ROW("CANT_BATERIA_FUENTE") = FUENTE.CANT_BAT
                                NEW_FUENTE_ROW("MOD_BATERIA_FUENTE") = FUENTE.MODBATERIA
                                NEW_FUENTE_ROW("FECHAFAB_BAT_FUENTE") = CDate(FUENTE.FECHA_BAT).ToShortDateString
                                VER_INFORME_FUENTES.INFORME_FUENTESDataSet.__INFORME.Add__INFORMERow(NEW_FUENTE_ROW)
                            Next
                        End If
                    End If
                Next
            End If
        Next
        VER_INFORME_FUENTES.Show(Me)
    End Sub 'OK
    Private Sub INSTALACIONDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles INSTALACIONDataGridView.SelectionChanged
        'If INSTALACIONDataGridView.Rows.Count > 0 Then
        '    SELECCIONA_FUENTE()
        'End If
    End Sub 'OK
    Private Sub AFECTACIONDataGridView_Click(sender As Object, e As MouseEventArgs) Handles AFECTACIONDataGridView.Click
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'CARGA EL DATAROW DE TRABAJOS
            Dim ID_AFECTACION As Integer
            AFECTACIONDataGridView.ContextMenuStrip = MENU_AFECTACION
            If ORDENESDataSet.AFECTACION.Rows.Count > 0 Then
                AFECTACIONRow = ORDENESDataSet.AFECTACION.Rows(0)
            End If
        End If
    End Sub
    Private Sub BOT_AFECTACION_Click(sender As Object, e As EventArgs) Handles BOT_AFECTACION.Click
        If ING_NODO.Text <> "" And ING_ZONA.Text <> "" Then
            NewAFECTACION = ORDENESDataSet.AFECTACION.NewAFECTACIONRow
            NewAFECTACION("INSTALACION") = FUENTE_ID
            NewAFECTACION("NODO") = ING_NODO.Text
            If Len(ING_ZONA.Text) = 1 Then
                NewAFECTACION("ZONA") = "0" & ING_ZONA.Text
            Else
                NewAFECTACION("ZONA") = ING_ZONA.Text
            End If
            Me.ORDENESDataSet.AFECTACION.Rows.Add(NewAFECTACION)
            AFECTACIONTableAdapter.Update(NewAFECTACION)
            ING_ZONA.Text = ""
            ING_ZONA.Focus()
        Else
            MsgBox("COMPLETE NODO Y ZONA PARA INGRESAR")
            ING_NODO.Focus()
        End If
    End Sub
    Private Sub BORRAR_AFECTACION_Click(sender As Object, e As EventArgs) Handles BORRAR_AFECTACION.Click
        ORDENESDataSet.AFECTACION.Rows(AFECTACIONDataGridView.CurrentRow.Index).Delete()
        AFECTACIONTableAdapter.Update(ORDENESDataSet.AFECTACION)
        AFECTACIONDataGridView.ContextMenuStrip = Nothing
    End Sub

End Class