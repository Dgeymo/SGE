Public Class FUENTE_EDICION
    Dim NEWFUENTERow As BASEFUENTESDataSet.FUENTERow
    Dim NewINSTALACION As BASEFUENTESDataSet.INSTALACIONRow
    Dim FUENTE_MOD As BASEFUENTESDataSet.FUENTERow
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
        Me.Close()
    End Sub
    Private Sub FUENTE_EDICION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INDICE_CALLESTableAdapter.Fill(INDICESDataSet.INDICE_CALLES)
        If FUENTES.ACCION_FUENTE = "EDITAR" Then
            FUENTETableAdapter.FillByID(BASEFUENTESDataSet.FUENTE, FUENTE_ID)
            FUENTE_MOD = BASEFUENTESDataSet.FUENTE.Rows(0)
            C_MODFUENTE.Text = FUENTE_MOD.MODFUENTE
            C_CALLE.Text = FUENTE_MOD.CALLE
            C_CANTBAT.Text = FUENTE_MOD.CANT_BAT
            C_NRO.Text = FUENTE_MOD.PUERTA
            C_ESQUINA.Text = FUENTE_MOD.ESQUINA
            C_NODO.Text = FUENTE_MOD.NODO
            C_ZONAG.Text = FUENTE_MOD.ZONA
            INSTALACION.Text = FUENTE_MOD.INSTALACION_RUS

            If FUENTE_MOD.IsID2Null = False AndAlso FUENTE_MOD.ID2 <> "" Then C_ID2.Text = FUENTE_MOD.ID2 Else C_ID2.Text = "-"
            If FUENTE_MOD.IsIMEINull = False AndAlso FUENTE_MOD.IMEI <> "" Then C_IMEI.Text = FUENTE_MOD.IMEI Else C_IMEI.Text = "-"
            If FUENTE_MOD.IsIPMODEMNull = False AndAlso FUENTE_MOD.IPMODEM <> "" Then C_IP.Text = FUENTE_MOD.IPMODEM Else C_IP.Text = "-"
            If FUENTE_MOD.IsPINNull = False AndAlso FUENTE_MOD.PIN <> "" Then C_PIN.Text = FUENTE_MOD.PIN Else C_PIN.Text = "-"
            If FUENTE_MOD.IsPUKNull = False AndAlso FUENTE_MOD.PUK <> "" Then C_PUK.Text = FUENTE_MOD.PUK Else C_PUK.Text = "-"
            If FUENTE_MOD.IsVPN1Null = False AndAlso FUENTE_MOD.VPN1 <> "" Then C_VPN1.Text = FUENTE_MOD.VPN1 Else C_VPN1.Text = "-"
            If FUENTE_MOD.IsVPN2Null = False AndAlso FUENTE_MOD.VPN2 <> "" Then C_VPN2.Text = FUENTE_MOD.VPN2 Else C_VPN2.Text = "-"
            If FUENTE_MOD.IsMACNull = False AndAlso FUENTE_MOD.MAC <> "" Then C_MAC.Text = FUENTE_MOD.MAC Else C_MAC.Text = "-"

            If FUENTE_MOD.IsLEXNull = False AndAlso FUENTE_MOD.LEX <> "" Then C_LEX.Text = FUENTE_MOD.LEX Else C_LEX.Text = 0
            If FUENTE_MOD.IsBRNull = False AndAlso FUENTE_MOD.BR <> "" Then C_MB.Text = FUENTE_MOD.BR Else C_MB.Text = 0
            If FUENTE_MOD.IsRXNull = False AndAlso FUENTE_MOD.RX <> "" Then C_RX.Text = FUENTE_MOD.RX Else C_RX.Text = 0
            If FUENTE_MOD.IsTRNull = False AndAlso FUENTE_MOD.TR <> "" Then C_TR.Text = FUENTE_MOD.TR Else C_TR.Text = 0

            If FUENTE_MOD.IsMODBATERIANull = False Then C_MODBAT.Text = FUENTE_MOD.MODBATERIA Else C_MODBAT.Text = "N/A"
            If FUENTE_MOD.IsGABINETENull = False Then C_MODGAB.Text = FUENTE_MOD.GABINETE Else C_MODGAB.Text = "N/A"
            If FUENTE_MOD.IsFECHA_BATNull = False Then FECHAFAB.Text = FUENTE_MOD.FECHA_BAT Else FECHAFAB.Text = "N/A"
            If FUENTE_MOD.IsCARGA_REALNull = False Then TXT_CARGA_REAL.Text = FUENTE_MOD.CARGA_REAL

            End If
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
                'IND_CALLE.Text = Me.INDICE_CALLESDataGridView.CurrentRow.Cells.Item(0).Value
                INDICE_CALLESDataGridView.Visible = False
                C_NRO.Focus()
            Else
                C_CALLE.Text = ""
                'IND_CALLE.Text = "0"
                INDICE_CALLESDataGridView.Visible = False
                C_NRO.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            C_CALLE.Text = ""
            'IND_CALLE.Text = "0"
            INDICE_CALLESDataGridView.Visible = False
            C_NRO.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            INDICE_CALLESDataGridView.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            INDICE_CALLESDataGridView.Visible = False
            'IND_CALLE.Text = 0
            C_CALLE.Text = ""
        End If
    End Sub
    Private Sub C_CALLE_TextChanged(sender As Object, e As EventArgs) Handles C_CALLE.TextChanged
        VISTACALLE = INDICESDataSet.INDICE_CALLES.AsDataView
        ' Dim VISTACALLE As DataView = INDICESDataSet.INDICE_CALLES.AsDataView
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
        C_MODBAT.BackColor = Color.DarkRed
        C_MODBAT.Text = ""
        C_PIN.BackColor = Color.DarkRed
        C_PIN.Text = ""
        C_PUK.BackColor = Color.DarkRed
        C_PUK.Text = ""
        C_VPN1.BackColor = Color.DarkRed
        C_VPN1.Text = ""
        C_VPN2.BackColor = Color.DarkRed
        C_VPN2.Text = ""
        FECHAFAB.BackColor = Color.DarkRed
        FECHAFAB.Text = ""
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
        C_MODBAT.BackColor = Color.DarkSlateBlue
        C_PIN.BackColor = Color.DarkSlateBlue
        C_PUK.BackColor = Color.DarkSlateBlue
        C_VPN1.BackColor = Color.DarkSlateBlue
        C_VPN2.BackColor = Color.DarkSlateBlue
        FECHAFAB.BackColor = Color.DarkSlateBlue
    End Sub 'OK


    Private Sub BOT_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BOT_ACEPTAR.Click
        If FUENTES.ACCION_FUENTE = "NUEVO" Then
            Me.Cursor = Cursors.WaitCursor
            If C_MODFUENTE.Text <> "COM" Then
                If C_CANTBAT.Text = "" Then
                    MsgBox("Debe ingresar la Cant de Baterias")
                    Exit Sub
                End If
                If C_MODBAT.Text = "" Then
                    MsgBox("Debe ingresar el Modelo de Bateria")
                    Exit Sub
                End If
            End If
            NEWFUENTERow = BASEFUENTESDataSet.FUENTE.NewFUENTERow
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
            If C_MODBAT.Text <> "" Then NEWFUENTERow.MODBATERIA = C_MODBAT.Text
            If C_CANTBAT.Text <> "" Then NEWFUENTERow.CANT_BAT = C_CANTBAT.Text Else NEWFUENTERow.CANT_BAT = 0
            If C_RX.Text <> "" Then NEWFUENTERow.RX = C_RX.Text
            If C_TR.Text <> "" Then NEWFUENTERow.TR = C_TR.Text
            If C_MB.Text <> "" Then NEWFUENTERow.BR = C_MB.Text
            If C_LEX.Text <> "" Then NEWFUENTERow.LEX = C_LEX.Text

            NEWFUENTERow.ITOTAL = ""
            NEWFUENTERow.AUTONOMIA = ""
            If INSTALACION.Text <> "" Then NEWFUENTERow.INSTALACION_RUS = INSTALACION.Text
            If FECHAFAB.Text <> "" Then NEWFUENTERow.FECHA_BAT = FECHAFAB.Text
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
            NEWFUENTERow.INSTALACION = CODIGOFUENTE

            CALCULADORA_CARGA()

            NEWFUENTERow.ITOTAL = Format(CARGATOTAL, "##.#")
            NEWFUENTERow.FECHA = Today.ToShortDateString
            Try
                BASEFUENTESDataSet.FUENTE.Rows.Add(NEWFUENTERow)
                FUENTETableAdapter.Update(NEWFUENTERow)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try


            FUENTETableAdapter.Fill(BASEFUENTESDataSet.FUENTE)
            FUENTE_MOD = BASEFUENTESDataSet.FUENTE.Rows(BASEFUENTESDataSet.FUENTE.Rows.Count - 1)
            NUEVA_INSTALACION()
            Me.Cursor = DefaultCursor
        End If
        If FUENTES.ACCION_FUENTE = "EDITAR" Then
            Me.Cursor = Cursors.WaitCursor
            NUEVA_INSTALACION()
            If INSTALACION.Text <> FUENTE_MOD.INSTALACION_RUS Then FUENTE_MOD.INSTALACION_RUS = INSTALACION.Text
            If C_CALLE.Text <> FUENTE_MOD.CALLE Then FUENTE_MOD.CALLE = C_CALLE.Text
            If C_NRO.Text <> FUENTE_MOD.PUERTA Then FUENTE_MOD.PUERTA = C_NRO.Text
            If C_ESQUINA.Text <> FUENTE_MOD.ESQUINA Then FUENTE_MOD.ESQUINA = C_ESQUINA.Text
            If C_NODO.Text <> FUENTE_MOD.NODO Then FUENTE_MOD.NODO = C_NODO.Text
            If C_ZONAG.Text <> FUENTE_MOD.ZONA Then FUENTE_MOD.ZONA = C_ZONAG.Text
            If FUENTE_MOD.MODFUENTE <> C_MODFUENTE.Text Then FUENTE_MOD.MODFUENTE = C_MODFUENTE.Text
            If FUENTE_MOD.IsCARGA_REALNull = False Then
                If TXT_CARGA_REAL.Text <> FUENTE_MOD.CARGA_REAL Then FUENTE_MOD.CARGA_REAL = TXT_CARGA_REAL.Text
            Else
                FUENTE_MOD.CARGA_REAL = TXT_CARGA_REAL.Text
            End If

            If FUENTE_MOD.IsLEXNull = False AndAlso C_LEX.Text <> FUENTE_MOD.LEX Then FUENTE_MOD.LEX = C_LEX.Text
            If FUENTE_MOD.IsBRNull = False AndAlso C_MB.Text <> FUENTE_MOD.BR Then FUENTE_MOD.BR = C_MB.Text
            If FUENTE_MOD.IsRXNull = False AndAlso C_RX.Text <> FUENTE_MOD.RX Then FUENTE_MOD.RX = C_RX.Text
            If FUENTE_MOD.IsTRNull = False AndAlso C_TR.Text <> FUENTE_MOD.TR Then FUENTE_MOD.TR = C_TR.Text

            If C_MODFUENTE.Text = "COM" Then
                FUENTE_MOD.CANT_BAT = 0
                FUENTE_MOD.ID2 = "-"
                FUENTE_MOD.IMEI = "-"
                FUENTE_MOD.IPMODEM = "-"
                FUENTE_MOD.PIN = "-"
                FUENTE_MOD.PUK = "-"
                FUENTE_MOD.VPN1 = "-"
                FUENTE_MOD.VPN2 = "-"
                FUENTE_MOD.MAC = "-"
                FUENTE_MOD.MODBATERIA = ""
                FUENTE_MOD.GABINETE = ""
                FUENTE_MOD.FECHA_BAT = ""
            Else
                FUENTE_MOD.CANT_BAT = C_CANTBAT.Text
                FUENTE_MOD.ID2 = C_ID2.Text
                FUENTE_MOD.IMEI = C_IMEI.Text
                FUENTE_MOD.IPMODEM = C_IP.Text
                FUENTE_MOD.PIN = C_PIN.Text
                FUENTE_MOD.PUK = C_PUK.Text
                FUENTE_MOD.VPN1 = C_VPN1.Text
                FUENTE_MOD.VPN2 = C_VPN2.Text
                FUENTE_MOD.MAC = C_MAC.Text
                FUENTE_MOD.MODBATERIA = C_MODBAT.Text
                FUENTE_MOD.GABINETE = C_MODGAB.Text
                FUENTE_MOD.FECHA_BAT = FECHAFAB.Text
            End If

            FUENTE_MOD.FECHA = Today.ToShortDateString
            FUENTETableAdapter.Update(FUENTE_MOD)
            Me.Cursor = DefaultCursor
        End If

        FUENTES.FUENTETableAdapter.FillByFUENTES(FUENTES.BASEFUENTESDataSet.FUENTE)
        FUENTES.Enabled = True
        Me.Close()
    End Sub
    Private Sub NUEVA_INSTALACION()
        NewINSTALACION = BASEFUENTESDataSet.INSTALACION.NewINSTALACIONRow
        NewINSTALACION.FECHA_HIST = Today.ToShortDateString
        NewINSTALACION.NODO = FUENTE_MOD.NODO
        NewINSTALACION.ZONAG = FUENTE_MOD.ZONA
        NewINSTALACION.CALLE = FUENTE_MOD.CALLE
        NewINSTALACION.NRO = FUENTE_MOD.PUERTA
        NewINSTALACION.IDFUENTE = FUENTE_MOD.ID_FUENTE
        If FUENTE_MOD.IsESQUINANull = False Then NewINSTALACION.ESQUINA = FUENTE_MOD.ESQUINA
        If FUENTE_MOD.IsMODFUENTENull = False Then NewINSTALACION.MODFUENTE = FUENTE_MOD.MODFUENTE
        If FUENTE_MOD.IsGABINETENull = False Then NewINSTALACION.MODGABINETE = FUENTE_MOD.GABINETE
        If FUENTE_MOD.IsMODBATERIANull = False Then NewINSTALACION.MODBATERIA = FUENTE_MOD.MODBATERIA
        If FUENTE_MOD.IsCANT_BATNull = False Then NewINSTALACION.CANTBATERIA = FUENTE_MOD.CANT_BAT

        If FUENTE_MOD.IsRXNull = False Then NewINSTALACION.RX = FUENTE_MOD.RX
        If FUENTE_MOD.IsTRNull = False Then NewINSTALACION.TR = FUENTE_MOD.TR
        If FUENTE_MOD.IsBRNull = False Then NewINSTALACION.BR = FUENTE_MOD.BR
        If FUENTE_MOD.IsLEXNull = False Then NewINSTALACION.LE = FUENTE_MOD.LEX
        If FUENTE_MOD.IsITOTALNull = False Then NewINSTALACION.ITOTAL = FUENTE_MOD.ITOTAL
        If FUENTE_MOD.IsAUTONOMIANull = False Then NewINSTALACION.MODFUENTE = FUENTE_MOD.MODFUENTE
        If IsNumeric(FUENTE_MOD.AUTONOMIA) Then NewINSTALACION.AUTONOMIA_REAL = FUENTE_MOD.AUTONOMIA
        If FUENTE_MOD.IsINSTALACION_RUSNull = False Then NewINSTALACION.CODORD = FUENTE_MOD.INSTALACION_RUS
        If FUENTE_MOD.IsINSTALACIONNull = False Then NewINSTALACION.CODIGO = FUENTE_MOD.INSTALACION

        If FUENTE_MOD.IsFECHA_BATNull = False Then
            If FUENTE_MOD.FECHA_BAT.ToString <> "" Then NewINSTALACION.FECHAFAB_BAT = FUENTE_MOD.FECHA_BAT
        End If
        If FUENTE_MOD.IsIPMODEMNull = False Then NewINSTALACION.IPMODEM = FUENTE_MOD.IPMODEM
        If FUENTE_MOD.IsID2Null = False Then NewINSTALACION.ID2 = FUENTE_MOD.ID2
        If FUENTE_MOD.IsMACNull = False Then NewINSTALACION.MAC = FUENTE_MOD.MAC
        If FUENTE_MOD.IsIMEINull = False Then NewINSTALACION.IMEI = FUENTE_MOD.IMEI
        If FUENTE_MOD.IsPINNull = False Then NewINSTALACION.PIN = FUENTE_MOD.PIN
        If FUENTE_MOD.IsPUKNull = False Then NewINSTALACION.PUK = FUENTE_MOD.PUK
        If FUENTE_MOD.IsVPN1Null = False Then NewINSTALACION.VPN1 = FUENTE_MOD.VPN1
        If FUENTE_MOD.IsVPN2Null = False Then NewINSTALACION.VPN2 = FUENTE_MOD.VPN2

        ''DETERMINA MODELO DE FUENTE
        If FUENTE_MOD.IsMODFUENTENull = False AndAlso FUENTE_MOD.MODFUENTE <> "N/A" Then
            Select Case FUENTE_MOD.MODFUENTE
                Case "COM"
                    TIPOFUENTE = "FC"
                Case Else
                    TIPOFUENTE = "FS"
            End Select
        End If
        If FUENTE_MOD.IsRXNull = False AndAlso FUENTE_MOD.RX <> "" Then
            RX = FUENTE_MOD.RX
        Else
            RX = 0
        End If
        If FUENTE_MOD.IsTRNull = False AndAlso FUENTE_MOD.TR <> "" Then
            TR = FUENTE_MOD.TR
        Else
            TR = 0
        End If
        If FUENTE_MOD.IsBRNull = False AndAlso FUENTE_MOD.BR <> "" Then
            BR = FUENTE_MOD.BR
        Else
            BR = 0
        End If
        If FUENTE_MOD.IsLEXNull = False AndAlso FUENTE_MOD.LEX <> "" Then
            LE = FUENTE_MOD.LEX
        Else
            LE = 0
        End If
        'CALCULA CARGA
        CALCULADORA_CARGA()

        If FUENTE_MOD.MODFUENTE <> "COM" Then
            'CALCULA AUTONOMIA
            Select Case FUENTE_MOD.MODBATERIA
                Case "150 XTV"
                    POTBAT = CInt(80 * 12 * FUENTE_MOD.CANT_BAT)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)

                Case "165 GXL"
                    POTBAT = CInt(86 * 12 * FUENTE_MOD.CANT_BAT)
                    AUTONOMIAFUENTE = POTBAT * 0.85 / (CARGATOTAL * 60)

                Case "195 XTV"
                    POTBAT = CInt(90 * 12 * FUENTE_MOD.CANT_BAT)
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
            Select Case C_MODBAT.Text
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