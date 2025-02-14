Public Class FUENTE_EDICION
    Dim NEWFUENTERow As BASEFUENTESDataSet.FUENTERow
    Dim NewINSTALACION As BASEFUENTESDataSet.INSTALACIONRow
    Dim FUENTERow As BASEFUENTESDataSet.FUENTERow
    Dim RESPBAT
    Dim CampoCalle(5)
    Dim ExpreCalle(5)
    Dim FiltrCalle(5)
    Dim VISTACALLE As DataView
    Dim CODIGOFUENTE As String

    Dim AUTONOMIAFUENTE As Double
    Dim ICARGA(10) As Double
    Dim IBAT As Integer
    Dim CARGATOTAL As Double
    Dim POTBAT As Integer

    Dim CARGA As String
    Dim TIPOFUENTE As String
    Dim ZONAFUENTE As String
    Dim RX As Integer
    Dim TR As Integer
    Dim BR As Integer
    Dim LE As Integer
    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        FUENTES.Enabled = True
        Close()
    End Sub
    Private Sub FUENTE_EDICION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CARGARCOMBOBAT()
        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        If FUENTES.ACCION_FUENTE = "EDITAR" Then
            FUENTETableAdapter.FillByID(BASEFUENTESDataSet.FUENTE, FUENTE_ID)
            FUENTERow = BASEFUENTESDataSet.FUENTE.Rows(0)

            C_MODFUENTE.Text = FUENTERow("MODFUENTE")
            C_CALLE.Text = FUENTERow("CALLE")
            C_CANTBAT.Text = FUENTERow("CANT_BAT")
            C_NRO.Text = FUENTERow("PUERTA")
            C_ESQUINA.Text = FUENTERow("ESQUINA")
            C_NODO.Text = FUENTERow("NODO")
            C_ZONAG.Text = FUENTERow("ZONA")
            INSTALACION.Text = FUENTERow("INSTALACION_RUS")

            If IsDBNull(FUENTERow("ID2")) = False AndAlso FUENTERow("ID2") <> "" Then C_ID2.Text = FUENTERow("ID2") Else C_ID2.Text = "-"
            If IsDBNull(FUENTERow("IMEI")) = False AndAlso FUENTERow("IMEI") <> "" Then C_IMEI.Text = FUENTERow("IMEI") Else C_IMEI.Text = "-"
            If IsDBNull(FUENTERow("IPMODEM")) = False AndAlso FUENTERow("IPMODEM") <> "" Then C_IP.Text = FUENTERow("IPMODEM") Else C_IP.Text = "-"
            If IsDBNull(FUENTERow("PIN")) = False AndAlso FUENTERow("PIN") <> "" Then C_PIN.Text = FUENTERow("PIN") Else C_PIN.Text = "-"
            If IsDBNull(FUENTERow("PUK")) = False AndAlso FUENTERow("PUK") <> "" Then C_PUK.Text = FUENTERow("PUK") Else C_PUK.Text = "-"
            If IsDBNull(FUENTERow("VPN1")) = False AndAlso FUENTERow("VPN1") <> "" Then C_VPN1.Text = FUENTERow("VPN1") Else C_VPN1.Text = "-"
            If IsDBNull(FUENTERow("VPN2")) = False AndAlso FUENTERow("VPN2") <> "" Then C_VPN2.Text = FUENTERow("VPN2") Else C_VPN2.Text = "-"
            If IsDBNull(FUENTERow("MAC")) = False AndAlso FUENTERow("MAC") <> "" Then C_MAC.Text = FUENTERow("MAC") Else C_MAC.Text = "-"

            If IsDBNull(FUENTERow("LEX")) = False AndAlso FUENTERow("LEX") <> "" Then C_LEX.Text = FUENTERow("LEX") Else C_LEX.Text = 0
            If IsDBNull(FUENTERow("BR")) = False AndAlso FUENTERow("BR") <> "" Then C_MB.Text = FUENTERow("BR") Else C_MB.Text = 0
            If IsDBNull(FUENTERow("RX")) = False AndAlso FUENTERow("RX") <> "" Then C_RX.Text = FUENTERow("RX") Else C_RX.Text = 0
            If IsDBNull(FUENTERow("TR")) = False AndAlso FUENTERow("TR") <> "" Then C_TR.Text = FUENTERow("TR") Else C_TR.Text = 0

            If IsDBNull(FUENTERow("MODBATERIA")) = False Then CB_BAT.Text = FUENTERow("MODBATERIA") & " - " & Month(FUENTERow("FECHA_BAT")) & "/" & Year(FUENTERow("FECHA_BAT")) Else CB_BAT.Text = "N/A"
            If IsDBNull(FUENTERow("GABINETE")) = False Then C_MODGAB.Text = FUENTERow("GABINETE") Else C_MODGAB.Text = "N/A"

            If IsDBNull(FUENTERow("CARGA_REAL")) = False Then TXT_CARGA_REAL.Text = FUENTERow("CARGA_REAL")

        End If
    End Sub
    Private Sub CARGARCOMBOBAT()
        Try
            Dim SQL = "SELECT
                    FB.FECHA as [FECHA],
                    TB.TIPO AS [TIPO]
                    FROM (FECHA_BATERIA FB
                    INNER JOIN TIPO_BATERIA TB ON FB.TIPO_BATERIA = TB.Id)"
            RESPBAT = ExecuteQuery("FUENTES", SQL)
            CB_BAT.Items.Clear()
            For Each UNABAT In RESPBAT
                CB_BAT.Items.Add(UNABAT("TIPO") & " - " & UNABAT("FECHA"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub INDICE_CALLESDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles INDICE_CALLESDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            C_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            'IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
            C_NRO.Focus()
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.DoubleClick
        If INDICE_CALLESDataGridView.RowCount > 0 Then
            C_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
            'IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
            INDICE_CALLESDataGridView.Visible = False
        End If
    End Sub
    Private Sub INDICE_CALLESDataGridView_LostFocus(sender As Object, e As EventArgs) Handles INDICE_CALLESDataGridView.LostFocus
        INDICE_CALLESDataGridView.Visible = False
    End Sub
    Private Sub C_CALLE_KeyDown(sender As Object, e As KeyEventArgs) Handles C_CALLE.KeyDown
        If C_CALLE.Text.Length > 2 Then
            INDICE_CALLESDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Enter Then
            If INDICE_CALLESDataGridView.Rows.Count = 1 Then
                C_CALLE.Text = Trim(Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(2).Value)
                INDICE_CALLESDataGridView.Visible = False
                C_NRO.Focus()
            Else
                C_CALLE.Text = ""
                INDICE_CALLESDataGridView.Visible = False
                C_NRO.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            C_CALLE.Text = ""
            INDICE_CALLESDataGridView.Visible = False
            C_NRO.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            INDICE_CALLESDataGridView.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
            C_CALLE.Text = ""
        End If
    End Sub
    Private Sub C_CALLE_TextChanged(sender As Object, e As EventArgs) Handles C_CALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView

        CampoCalle(0) = "NOMBRE_CALLE"
        ExpreCalle(0) = C_CALLE.Text
        FiltrCalle(0) = "[" & CampoCalle(0) & "] like '*" & ExpreCalle(0) & "*'"

        VISTACALLE.RowFilter = FiltrCalle(0)
        INDICE_CALLESBindingSource.DataSource = VISTACALLE
        INDICE_CALLESDataGridView.Columns(0).Visible = False
    End Sub
    Private Sub C_CALLE_DoubleClick(sender As Object, e As EventArgs) Handles C_CALLE.DoubleClick
        If INDICE_CALLESDataGridView.Visible = False Then
            INDICE_CALLESDataGridView.Visible = True
            INDICE_CALLESDataGridView.Columns(0).Visible = False
        End If
    End Sub
    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        FUENTES.Enabled = True
        Me.Close()
    End Sub 'OK
    Private Sub C_MODFUENTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_MODFUENTE.SelectedIndexChanged
        If C_MODFUENTE.Text = "COM" Then CONDICION_COMUN() Else CONDICION_STDBY()
    End Sub 'OK
    Private Sub CONDICION_COMUN()
        C_CANTBAT.BackColor = Color.DarkRed
        C_CANTBAT.Text = ""
        C_ID2.BackColor = Color.DarkRed
        C_ID2.Text = ""
        C_IMEI.BackColor = Color.DarkRed
        C_IMEI.Text = ""
        C_IP.BackColor = Color.DarkRed
        C_IP.Text = ""
        C_MAC.BackColor = Color.DarkRed
        C_MAC.Text = ""
        '  C_MODBAT.BackColor = Color.DarkRed
        '  C_MODBAT.Text = "SELECCIONE"
        C_PIN.BackColor = Color.DarkRed
        C_PIN.Text = ""
        C_PUK.BackColor = Color.DarkRed
        C_PUK.Text = ""
        C_VPN1.BackColor = Color.DarkRed
        C_VPN1.Text = ""
        C_VPN2.BackColor = Color.DarkRed
        C_VPN2.Text = ""
        CB_BAT.BackColor = Color.DarkRed
        CB_BAT.Text = "SELECCIONE"
        LBLAUTONOMIA_REAL.Visible = False
        LBLAUTONOMIA_TEORICA.Visible = False
        LBLHRSAUTONOMIATEORICA.Visible = False
        LBLHSAUTONOMIAREAL.Visible = False
        C_AUTONOMIA.Visible = False
        C_AUTONOMIA_REAL.Visible = False
    End Sub 'OK
    Private Sub CONDICION_STDBY()
        C_CANTBAT.BackColor = Color.DarkSlateBlue
        C_ID2.BackColor = Color.DarkSlateBlue
        C_IMEI.BackColor = Color.DarkSlateBlue
        C_IP.BackColor = Color.DarkSlateBlue
        C_MAC.BackColor = Color.DarkSlateBlue
        CB_BAT.BackColor = Color.DarkSlateBlue
        C_PIN.BackColor = Color.DarkSlateBlue
        C_PUK.BackColor = Color.DarkSlateBlue
        C_VPN1.BackColor = Color.DarkSlateBlue
        C_VPN2.BackColor = Color.DarkSlateBlue
        ' CB_BAT.BackColor = Color.DarkSlateBlue
    End Sub 'OK


    Private Sub BOT_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BOT_ACEPTAR.Click
        If FUENTES.ACCION_FUENTE = "NUEVO" Then
            Cursor = Cursors.WaitCursor
            NEWFUENTERow = BASEFUENTESDataSet.FUENTE.NewFUENTERow()
            If C_MODFUENTE.Text <> "COM" Then
                If CB_BAT.Text = "" Then
                    MsgBox("Debe ingresar el Modelo de Bateria")
                    Exit Sub
                End If
            End If
            NEWFUENTERow.NODO = C_NODO.Text
            If C_ZONAG.Text = "" Then
                MsgBox("INGRESE UNA ZONA")
                C_ZONAG.Focus()
                Exit Sub
            Else
                NEWFUENTERow.ZONA = C_ZONAG.Text
            End If
            If C_CALLE.Text = "" Or C_NRO.Text = "" Then
                MsgBox("INGRESE DIRECCION Y/O PUERTA")
                C_CALLE.Focus()
                Exit Sub
            Else
                NEWFUENTERow.CALLE = C_CALLE.Text
                NEWFUENTERow.PUERTA = C_NRO.Text
            End If
            If C_ESQUINA.Text <> "" Then NEWFUENTERow.ESQUINA = C_ESQUINA.Text
            If C_MODFUENTE.Text <> "" Then NEWFUENTERow.MODFUENTE = C_MODFUENTE.Text
            If C_MODGAB.Text <> "" Then NEWFUENTERow.GABINETE = C_MODGAB.Text
            If C_CANTBAT.Text <> "" Then NEWFUENTERow.CANT_BAT = C_CANTBAT.Text Else NEWFUENTERow.CANT_BAT = 0
            If C_RX.Text <> "" Then NEWFUENTERow.RX = C_RX.Text
            If C_TR.Text <> "" Then NEWFUENTERow.TR = C_TR.Text
            If C_MB.Text <> "" Then NEWFUENTERow.BR = C_MB.Text
            If C_LEX.Text <> "" Then NEWFUENTERow.LEX = C_LEX.Text

            NEWFUENTERow.ITOTAL = ""
            NEWFUENTERow.AUTONOMIA = ""
            If INSTALACION.Text <> "" Then NEWFUENTERow.INSTALACION_RUS = INSTALACION.Text
            If CB_BAT.Text <> "" Then NEWFUENTERow.FECHA_BAT = Trim(Split(CB_BAT.Text, "-")(0))
            If CB_BAT.Text <> "" Then NEWFUENTERow.MODBATERIA = Trim(Split(CB_BAT.Text, "-")(1))
            If C_IP.Text <> "" Then NEWFUENTERow.IPMODEM = C_IP.Text Else NEWFUENTERow.IPMODEM = "-"
            If C_ID2.Text <> "" Then NEWFUENTERow.ID2 = C_ID2.Text Else NEWFUENTERow.ID2 = "-"
            If C_MAC.Text <> "" Then NEWFUENTERow.MAC = C_MAC.Text Else NEWFUENTERow.MAC = "-"
            If C_IMEI.Text <> "" Then NEWFUENTERow.IMEI = C_IMEI.Text Else NEWFUENTERow.IMEI = "-"
            If C_PIN.Text <> "" Then NEWFUENTERow.PIN = C_PIN.Text Else NEWFUENTERow.PIN = "-"
            If C_PUK.Text <> "" Then NEWFUENTERow.PUK = C_PUK.Text Else NEWFUENTERow.PUK = "-"
            If C_VPN1.Text <> "" Then NEWFUENTERow.VPN1 = C_VPN1.Text Else NEWFUENTERow.VPN1 = "-"
            If C_VPN2.Text <> "" Then NEWFUENTERow.VPN2 = C_VPN2.Text Else NEWFUENTERow.VPN2 = "-"
            If TXT_CARGA_REAL.Text <> "" Then NEWFUENTERow.CARGA_REAL = TXT_CARGA_REAL.Text
            If C_AUTONOMIA.Text <> "" Then NEWFUENTERow.AUTONOMIA = C_AUTONOMIA.Text
            'DETERMINA MODELO DE FUENTE
            If C_MODFUENTE.Text <> "" Then
                Select Case C_MODFUENTE.Text
                    Case "COM"
                        TIPOFUENTE = "FC"
                    Case Else
                        TIPOFUENTE = "FS"
                End Select
            Else
                MsgBox("SELECCIONE MODELO DE FUENTE")
            End If
            If C_RX.Text <> "" Then
                RX = C_RX.Text
            Else
                RX = 0
            End If
            If C_TR.Text <> "" Then
                TR = C_TR.Text
            Else
                TR = 0
            End If
            If C_MB.Text <> "" Then
                BR = C_MB.Text
            Else
                BR = 0
            End If
            If C_LEX.Text <> "" Then
                LE = C_LEX.Text
            Else
                LE = 0
            End If
            Select Case RX
                Case 0
                    Select Case LE
                        Case 0
                            Select Case TR
                                Case > 0
                                    CARGA = "T"
                            End Select
                        Case Else
                            Select Case TR
                                Case > 0
                                    CARGA = "M"
                                Case Else
                                    CARGA = "D"
                            End Select
                    End Select
                Case Else
                    CARGA = "R"
            End Select
            CODIGOFUENTE = TIPOFUENTE & "-" & CARGA & " [" & C_NODO.Text & "-" & C_ZONAG.Text & "]"
            'NEWFUENTERow.INSTALACION = CODIGOFUENTE

            'CALCULADORA_CARGA()

            'NEWFUENTERow.ITOTAL = Format(CARGATOTAL, "##.#")
            NEWFUENTERow.FECHA = Today.ToShortDateString
            Try
                BASEFUENTESDataSet.FUENTE.AddFUENTERow(NEWFUENTERow)
                FUENTETableAdapter.Update(NEWFUENTERow)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try

            '   FUENTETableAdapter.Fill(BASEFUENTESDataSet.FUENTE)
            '    FUENTE_MOD = BASEFUENTESDataSet.FUENTE.Rows(BASEFUENTESDataSet.FUENTE.Rows.Count - 1)
            NUEVA_INSTALACION()
            Me.Cursor = DefaultCursor
        End If
        If FUENTES.ACCION_FUENTE = "EDITAR" Then
            Me.Cursor = Cursors.WaitCursor
            NUEVA_INSTALACION()
            If INSTALACION.Text <> FUENTERow.INSTALACION_RUS Then FUENTERow.INSTALACION_RUS = INSTALACION.Text
            If C_CALLE.Text <> FUENTERow.CALLE Then FUENTERow.CALLE = C_CALLE.Text
            If C_NRO.Text <> FUENTERow.PUERTA Then FUENTERow.PUERTA = C_NRO.Text
            If C_ESQUINA.Text <> FUENTERow.ESQUINA Then FUENTERow.ESQUINA = C_ESQUINA.Text
            If C_NODO.Text <> FUENTERow.NODO Then FUENTERow.NODO = C_NODO.Text
            If C_ZONAG.Text <> FUENTERow.ZONA Then FUENTERow.ZONA = C_ZONAG.Text
            If FUENTERow.MODFUENTE <> C_MODFUENTE.Text Then FUENTERow.MODFUENTE = C_MODFUENTE.Text
            If FUENTERow.IsCARGA_REALNull = False Then
                If TXT_CARGA_REAL.Text <> FUENTERow.CARGA_REAL Then FUENTERow.CARGA_REAL = TXT_CARGA_REAL.Text
            Else
                FUENTERow.CARGA_REAL = TXT_CARGA_REAL.Text
            End If

            If FUENTERow.IsLEXNull = False AndAlso C_LEX.Text <> FUENTERow.LEX Then FUENTERow.LEX = C_LEX.Text
            If FUENTERow.IsBRNull = False AndAlso C_MB.Text <> FUENTERow.BR Then FUENTERow.BR = C_MB.Text
            If FUENTERow.IsRXNull = False AndAlso C_RX.Text <> FUENTERow.RX Then FUENTERow.RX = C_RX.Text
            If FUENTERow.IsTRNull = False AndAlso C_TR.Text <> FUENTERow.TR Then FUENTERow.TR = C_TR.Text

            If C_MODFUENTE.Text = "COM" Then
                FUENTERow.CANT_BAT = 0
                FUENTERow.ID2 = "-"
                FUENTERow.IMEI = "-"
                FUENTERow.IPMODEM = "-"
                FUENTERow.PIN = "-"
                FUENTERow.PUK = "-"
                FUENTERow.VPN1 = "-"
                FUENTERow.VPN2 = "-"
                FUENTERow.MAC = "-"
                FUENTERow.MODBATERIA = ""
                FUENTERow.GABINETE = ""
                ' FUENTERow.FECHA_BAT = ""
            Else
                FUENTERow.CANT_BAT = C_CANTBAT.Text
                FUENTERow.ID2 = C_ID2.Text
                FUENTERow.IMEI = C_IMEI.Text
                FUENTERow.IPMODEM = C_IP.Text
                FUENTERow.PIN = C_PIN.Text
                FUENTERow.PUK = C_PUK.Text
                FUENTERow.VPN1 = C_VPN1.Text
                FUENTERow.VPN2 = C_VPN2.Text
                FUENTERow.MAC = C_MAC.Text
                FUENTERow.FECHA_BAT = Trim(Split(CB_BAT.Text, "-")(1))
                FUENTERow.MODBATERIA = Trim(Split(CB_BAT.Text, "-")(0))
                FUENTERow.GABINETE = C_MODGAB.Text
            End If

            FUENTERow.FECHA = Today.ToShortDateString
            FUENTETableAdapter.Update(FUENTERow)
            Me.Cursor = DefaultCursor
        End If

        FUENTES.FUENTETableAdapter.FillByACTIVA(FUENTES.BASEFUENTESDataSet.FUENTE)
        FUENTES.Enabled = True
        Me.Close()
    End Sub
    Private Function FBAT(FBATERIA As String) As Integer
        For Each UNABAT In RESPBAT
            If UNABAT("TIPO") & " - " & UNABAT("FECHA") = FBATERIA Then Return UNABAT.Id
        Next
        Return Nothing
    End Function
    Private Sub NUEVA_INSTALACION()
        NewINSTALACION = BASEFUENTESDataSet.INSTALACION.NewINSTALACIONRow
        NewINSTALACION.FECHA_HIST = Today.ToShortDateString
        NewINSTALACION.NODO = FUENTERow.NODO
        NewINSTALACION.ZONAG = FUENTERow.ZONA
        NewINSTALACION.CALLE = FUENTERow.CALLE
        NewINSTALACION.NRO = FUENTERow.PUERTA
        NewINSTALACION.IDFUENTE = FUENTERow.ID_FUENTE
        If FUENTERow.IsESQUINANull = False Then NewINSTALACION.ESQUINA = FUENTERow.ESQUINA
        If FUENTERow.IsMODFUENTENull = False Then NewINSTALACION.MODFUENTE = FUENTERow.MODFUENTE
        If FUENTERow.IsGABINETENull = False Then NewINSTALACION.MODGABINETE = FUENTERow.GABINETE
        If FUENTERow.IsMODBATERIANull = False Then NewINSTALACION.MODBATERIA = FUENTERow.MODBATERIA
        If FUENTERow.IsCANT_BATNull = False Then NewINSTALACION.CANTBATERIA = FUENTERow.CANT_BAT

        If FUENTERow.IsRXNull = False Then NewINSTALACION.RX = FUENTERow.RX
        If FUENTERow.IsTRNull = False Then NewINSTALACION.TR = FUENTERow.TR
        If FUENTERow.IsBRNull = False Then NewINSTALACION.BR = FUENTERow.BR
        If FUENTERow.IsLEXNull = False Then NewINSTALACION.LE = FUENTERow.LEX
        If FUENTERow.IsITOTALNull = False Then NewINSTALACION.ITOTAL = FUENTERow.ITOTAL
        If FUENTERow.IsAUTONOMIANull = False Then NewINSTALACION.MODFUENTE = FUENTERow.MODFUENTE
        If IsNumeric(FUENTERow.AUTONOMIA) Then NewINSTALACION.AUTONOMIA_REAL = FUENTERow.AUTONOMIA
        If FUENTERow.IsINSTALACION_RUSNull = False Then NewINSTALACION.CODORD = FUENTERow.INSTALACION_RUS
        If FUENTERow.IsINSTALACIONNull = False Then NewINSTALACION.CODIGO = FUENTERow.INSTALACION

        If FUENTERow.IsFECHA_BATNull = False Then
            If FUENTERow.FECHA_BAT.ToString <> "" Then NewINSTALACION.FECHAFAB_BAT = FUENTERow.FECHA_BAT
        End If
        If FUENTERow.IsIPMODEMNull = False Then NewINSTALACION.IPMODEM = FUENTERow.IPMODEM
        If FUENTERow.IsID2Null = False Then NewINSTALACION.ID2 = FUENTERow.ID2
        If FUENTERow.IsMACNull = False Then NewINSTALACION.MAC = FUENTERow.MAC
        If FUENTERow.IsIMEINull = False Then NewINSTALACION.IMEI = FUENTERow.IMEI
        If FUENTERow.IsPINNull = False Then NewINSTALACION.PIN = FUENTERow.PIN
        If FUENTERow.IsPUKNull = False Then NewINSTALACION.PUK = FUENTERow.PUK
        If FUENTERow.IsVPN1Null = False Then NewINSTALACION.VPN1 = FUENTERow.VPN1
        If FUENTERow.IsVPN2Null = False Then NewINSTALACION.VPN2 = FUENTERow.VPN2

        ''DETERMINA MODELO DE FUENTE
        If FUENTERow.IsMODFUENTENull = False AndAlso FUENTERow.MODFUENTE <> "N/A" Then
            Select Case FUENTERow.MODFUENTE
                Case "COM"
                    TIPOFUENTE = "FC"
                Case Else
                    TIPOFUENTE = "FS"
            End Select
        End If
        If FUENTERow.IsRXNull = False AndAlso FUENTERow.RX <> "" Then
            RX = FUENTERow.RX
        Else
            RX = 0
        End If
        If FUENTERow.IsTRNull = False AndAlso FUENTERow.TR <> "" Then
            TR = FUENTERow.TR
        Else
            TR = 0
        End If
        If FUENTERow.IsBRNull = False AndAlso FUENTERow.BR <> "" Then
            BR = FUENTERow.BR
        Else
            BR = 0
        End If
        If FUENTERow.IsLEXNull = False AndAlso FUENTERow.LEX <> "" Then
            LE = FUENTERow.LEX
        Else
            LE = 0
        End If
        'CALCULA CARGA
        CALCULADORA_CARGA()

        If FUENTERow.MODFUENTE <> "COM" Then
            'CALCULA AUTONOMIA
            Select Case FUENTERow.MODBATERIA
                Case "150 XTV"
                    POTBAT = CInt(80 * 12 * FUENTERow.CANT_BAT)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)

                Case "165 GXL"
                    POTBAT = CInt(86 * 12 * FUENTERow.CANT_BAT)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)

                Case "195 XTV"
                    POTBAT = CInt(90 * 12 * FUENTERow.CANT_BAT)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)
            End Select
            NewINSTALACION.AUTONOMIA = Format(AUTONOMIAFUENTE, "##.#")
        Else
            NewINSTALACION.AUTONOMIA = 0
        End If
        'AGREGA UNA FILA A LA TABLA INSTALACION
        BASEFUENTESDataSet.INSTALACION.Rows.Add(NewINSTALACION)
        INSTALACIONTableAdapter.Update(NewINSTALACION)
    End Sub
    Private Sub CALCULADORA_CARGA()
        If C_RX.Text = "" Then ICARGA(0) = 0 Else ICARGA(0) = C_RX.Text * 2.5 'CARGA TEORICA RX
        If C_TR.Text = "" Then ICARGA(1) = 0 Else ICARGA(1) = C_TR.Text * 1.5 'CARGA TEORICA TR
        If C_MB.Text = "" Then ICARGA(2) = 0 Else ICARGA(2) = C_MB.Text * 0.95 'CARGA TEORICA MB
        If C_LEX.Text = "" Then ICARGA(3) = 0 Else ICARGA(3) = C_LEX.Text * 0.65 'CARGA TEORICA LEX
        CARGATOTAL = ICARGA(0) + ICARGA(1) + ICARGA(2) + ICARGA(3)
        C_CARGA.Text = CARGATOTAL

        If C_CANTBAT.Text <> "" Then
            Select Case Mid(CB_BAT.Text, 1, 7)
                Case "150 XTV"
                    POTBAT = CInt(80 * 12 * C_CANTBAT.Text)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)
                Case "165 GXL"
                    POTBAT = CInt(86 * 12 * C_CANTBAT.Text)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)
                Case "195 XTV"
                    POTBAT = CInt(100 * 12 * C_CANTBAT.Text)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)
            End Select
            C_AUTONOMIA.Text = Format(AUTONOMIAFUENTE, "##.#")
            If TXT_CARGA_REAL.Text <> "" Then C_AUTONOMIA_REAL.Text = Format(POTBAT * 0.85 / (TXT_CARGA_REAL.Text * 60), "##.#")
        End If

    End Sub
    Private Sub C_RX_TextChanged(sender As Object, e As EventArgs) Handles C_RX.TextChanged
        CALCULADORA_CARGA()
    End Sub
    Private Sub C_TR_TextChanged(sender As Object, e As EventArgs) Handles C_TR.TextChanged
        CALCULADORA_CARGA()
    End Sub
    Private Sub C_MB_TextChanged(sender As Object, e As EventArgs) Handles C_MB.TextChanged
        CALCULADORA_CARGA()
    End Sub
    Private Sub C_LEX_TextChanged(sender As Object, e As EventArgs) Handles C_LEX.TextChanged
        CALCULADORA_CARGA()
    End Sub

    Private Sub FUENTE_EDICION_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CALCULADORA_CARGA()
    End Sub

End Class