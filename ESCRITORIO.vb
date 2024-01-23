Public Class ESCRITORIO
    Dim BTN_NODOS(27) As Button
    'VARIABLES GESTION
    Dim LBL_TIPOGESTION(60) As Label
    Dim LBL_OBSGESTION(60) As Label
    Dim LBL_DIRGESTION(60) As Label
    Dim LBL_ASIGGESTION(60) As Label
    Dim LBL_INIGESTION(60) As Label
    Dim LBL_INIESTGESTION(60) As Label
    Dim LBL_ZONAGESTION(60) As Label
    Dim BTN_GESTION(60) As Button
    Dim BTN_STATUS_GESTION(60) As Button
    Dim CONTROL_NODO As Object
    'VARIABLES TRABAJO
    Dim MODAL_PANEL As Panel
    Dim BTN_TRABAJO(50) As Button
    Dim BTN_STATUS_GESTION_ENTRABAJO As Button
    Dim LBL_TITULOTRABAJO As Label
    Dim LBL_SUBTITULOTRABAJO As Label
    Dim LBL_ZONATRABAJO(50) As Label
    Dim LBL_OBSTRABAJO(50) As Label
    Dim LBL_ASIGtrabajo(50) As Label
    Dim BTN_STATUS_TRABAJO(50) As Button
    'Dim BTN_VERMAS_TRABAJO As Button
    Dim LBL_INITRABAJO(50) As Label
    Dim LBL_INIESTTRABAJO(50) As Label
    'VARIABLES ORDEN
    Dim PANEL_ORDEN As Panel
    Dim BTN_ORDEN(50) As Button
    Dim LBL_TITULOORDEN As Label
    Dim LBL_SUBTITULOORDEN As Label
    Dim BTN_STATUS_TRABAJO_EN_ORDEN As Button
    Dim BTN_STATUS_ORDEN(50) As Button
    Dim LBL_ASIGorden(50) As Label
    'VARIABLES GLOBALES
    Dim YPOS As Integer
    Dim XPOS As Integer = 100

    Dim W_GESTIONRow As ORDENESDataSet.GESTIONRow
    Dim W_TRABAJORow As ORDENESDataSet.TRABAJOSRow
    Dim INIFORG As Integer
    Dim FINFORG As Integer
    Dim INIFORT As Integer
    Dim FINFORT As Integer
    Dim INIFORO As Integer
    Dim FINFORO As Integer
    'Dim BTNVERMASTEMP As String
    Private Sub ESCRITORIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NRONODOSTableAdapter.Fill(BASEFUENTESDataSet.NRONODOS)
        If BASEFUENTESDataSet.NRONODOS.Rows.Count > 0 Then
            YPOS = 10
            For X = 0 To BASEFUENTESDataSet.NRONODOS.Count
                BTN_NODOS(X) = New Button()
                BTN_NODOS(X).FlatStyle = FlatStyle.Flat
                BTN_NODOS(X).FlatAppearance.BorderSize = 0
                BTN_NODOS(X).FlatAppearance.BorderColor = Color.White
                BTN_NODOS(X).FlatAppearance.MouseDownBackColor = Color.White
                BTN_NODOS(X).FlatAppearance.MouseOverBackColor = Color.White
                BTN_NODOS(X).BackgroundImage = My.Resources.BTN_NODO
                BTN_NODOS(X).Font = New Font(BTN_NODOS(X).Font.Name, 8)
                BTN_NODOS(X).ForeColor = Color.Black
                BTN_NODOS(X).TextAlign = ContentAlignment.MiddleRight
                BTN_NODOS(X).BackgroundImageLayout = ImageLayout.Stretch
                If X = 27 Then
                    BTN_NODOS(X).Size = New Size(90, 22)
                    BTN_NODOS(X).Location = New Point(-10, YPOS + 20)
                    BTN_NODOS(X).Text = "PreGESTION"
                    BTN_NODOS(X).Name = "28"
                Else
                    BTN_NODOS(X).Size = New Size(50, 22)
                    BTN_NODOS(X).Location = New Point(-10, YPOS)
                    BTN_NODOS(X).Text = BASEFUENTESDataSet.NRONODOS.Rows(X).Item("NODO")
                    BTN_NODOS(X).Name = BASEFUENTESDataSet.NRONODOS.Rows(X).Item("NRO")
                End If

                AddHandler BTN_NODOS(X).Click, AddressOf BTN_NODO_Click
                Me.Controls.Add(BTN_NODOS(X))
                YPOS += 22
            Next
        End If
    End Sub    'LOAD - INICIA LOS BOTONES DE LOS NODOS
    Private Sub BTN_NODO_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim crtl_nodo As Control = DirectCast(sender, Control)
        CONTROL_NODO = crtl_nodo
        CREAR_BTN_VER_GESTION(False, "NO")
        CREAR_WIDGET_TRABAJO(False)
        CREAR_MODAL_TRABAJO(False)
        CREAR_BTN_VER_TRABAJO(False, "NO")
        CREAR_MODAL_ORDEN(False)
        CREAR_WIDGET_ORDEN(False)

        If IsNumeric(crtl_nodo.Name) Then
            CREAR_WIDGET_GESTION(False)
            If crtl_nodo.Name >= 1 And crtl_nodo.Name < 29 Then
                YPOS = 10
                'FORMATEAMOS LOS BOTONES DE LOS NODOS.
                For x = 0 To 27
                    BTN_NODOS(x).BackgroundImage = My.Resources.BTN_NODO
                    BTN_NODOS(x).Size = New Size(50, 22)
                    BTN_NODOS(x).Location = New Point(-10, YPOS)
                    BTN_NODOS(x).Font = New Font(BTN_NODOS(x).Font.Name, 8)
                    If x = 27 Then
                        BTN_NODOS(x).Size = New Size(90, 22)
                        BTN_NODOS(x).Location = New Point(-10, YPOS + 20)
                    End If
                    YPOS += 22
                Next
                If crtl_nodo.Name = BTN_NODOS(27).Name Then
                    crtl_nodo.Size = New Size(130, 25)
                    crtl_nodo.Location = New Point(crtl_nodo.Location.X, crtl_nodo.Location.Y - 3)
                Else
                    crtl_nodo.Size = New Size(65, 25)
                    crtl_nodo.Location = New Point(crtl_nodo.Location.X, crtl_nodo.Location.Y - 3)
                End If
                crtl_nodo.Font = New Font(crtl_nodo.Font.Name, 10, FontStyle.Bold)
                crtl_nodo.BackgroundImageLayout = ImageLayout.Stretch
                crtl_nodo.BringToFront()
                crtl_nodo.BackgroundImage = My.Resources.BTN_NODO_sel
                'BUSCAMOS SI ES PREGESTION O GESTIONES
                If CONTROL_NODO.Text = "PreGESTION" Then
                    GESTIONTableAdapter.FillByPREGESTION(ORDENESDataSet.GESTION)
                Else
                    GESTIONTableAdapter.FillByGESTIONES_ACTIVAS(ORDENESDataSet.GESTION, CONTROL_NODO.Text)
                End If

                'SETEAMOS QUE ARRANQUE EL FOR EN 0 Y MUESTRE PANTALLA COMPLETA
                INIFORG = 0
                If ORDENESDataSet.GESTION.Rows.Count < 11 Then
                    FINFORG = ORDENESDataSet.GESTION.Rows.Count - 1
                    CREAR_WIDGET_GESTION(True)
                Else
                    FINFORG = 11
                    CREAR_WIDGET_GESTION(True)
                    If ORDENESDataSet.GESTION.Rows.Count > 12 Then
                        CREAR_BTN_VER_GESTION(True, ">")
                    End If
                End If




            End If
            'CREACION DE ETIQUETAS PARA GESTIONES DENTRO DEL NODO


        End If
    End Sub    'BTN PARA INGRESAR AL NODO
    Private Sub CREAR_WIDGET_GESTION(CREAR As Boolean)
        If CREAR = True Then
            YPOS = 10
            XPOS = 60
            Try
                For X = INIFORG To FINFORG
                    Select Case X
                        Case 3, 6, 9
                            YPOS = 10
                            XPOS += 320
                        Case 15, 18, 21, 24
                            YPOS = 10
                            XPOS += 320
                    End Select
                    'GENERA EL BANNER-BOTON GESTION
                    BTN_GESTION(X) = New Button()
                    BTN_GESTION(X).Size = New Size(320, 200)
                    BTN_GESTION(X).Location = New Point(XPOS, YPOS)
                    BTN_GESTION(X).FlatStyle = FlatStyle.Flat
                    BTN_GESTION(X).FlatAppearance.BorderSize = 0
                    BTN_GESTION(X).FlatAppearance.BorderColor = Color.White
                    Select Case ORDENESDataSet.GESTION.Rows(X).Item("TIPOGESTION")
                        Case "MANT DISTRIBUCION", "MANT DISTRIBUCION - CRUCES", "SOLICITUD TERCEROS", "MANTENIMIENTO PREDICTIVO", "MANTENIMIENTO PREVENTIVO", "PREVENTIVO PUNTUAL", "SOLICITUD PERMISORES", "MANT TRONCALES", "RELEVAMIENTO PRE GESTION", "MODIF DE RED", "MANT SOPORTES DE RED", "MANT FIBRA", "CONST DE RED", "CONST DE FIBRA"
                            BTN_GESTION(X).BackgroundImage = My.Resources.BTN_GESTION_RED
                        Case "OBRA NUEVA", "MANT PREVENTIVO"
                            BTN_GESTION(X).BackgroundImage = My.Resources.BTN_GESTION_MDU
                        Case "MANTENIMIENTO PREVENTIVO DE FUENTES", "MANTENIMIENTO PROGRAMADO DE FUENTES", "TRABAJOS DE LABORATORIO", "INSTALACION / RETIRO DE FUENTE X OBRA", "MANT FUENTES"
                            BTN_GESTION(X).BackgroundImage = My.Resources.BTN_GESTION_FUENTE
                    End Select
                    BTN_GESTION(X).BackgroundImageLayout = ImageLayout.Zoom
                    BTN_GESTION(X).FlatAppearance.MouseOverBackColor = Color.White
                    BTN_GESTION(X).FlatAppearance.MouseDownBackColor = Color.White
                    BTN_GESTION(X).Name = ORDENESDataSet.GESTION.Rows(X).Item("ID_GESTION")
                    'TITULO DE LA GESTION
                    LBL_TIPOGESTION(X) = New Label()
                    LBL_TIPOGESTION(X).AutoSize = False
                    LBL_TIPOGESTION(X).Size = New Size(190, 64)
                    LBL_TIPOGESTION(X).Location = New Point(XPOS + 30, YPOS + 8)
                    LBL_TIPOGESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("TIPOGESTION")
                    LBL_TIPOGESTION(X).Font = New Font(LBL_TIPOGESTION(X).Font.Name, 11, FontStyle.Bold)
                    'OBSERVACIONES DE LA GESTION
                    LBL_OBSGESTION(X) = New Label()
                    LBL_OBSGESTION(X).Size = New Size(300, 50)
                    LBL_OBSGESTION(X).Location = New Point(XPOS + 10, YPOS + 130)
                    LBL_OBSGESTION(X).TextAlign = ContentAlignment.BottomLeft
                    LBL_OBSGESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("DESCRIPCION")
                    LBL_OBSGESTION(X).Font = New Font(LBL_OBSGESTION(X).Font.Name, 6.5)
                    'DIRECCION DE LA GESTION
                    If ORDENESDataSet.GESTION.Rows(X).Item("CALLE") <> "" Then
                        LBL_DIRGESTION(X) = New Label()
                        LBL_DIRGESTION(X).AutoSize = True
                        LBL_DIRGESTION(X).Location = New Point(XPOS + 10, YPOS + 100)
                        LBL_DIRGESTION(X).TextAlign = ContentAlignment.BottomLeft
                        LBL_DIRGESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("CALLE") & "  " & ORDENESDataSet.GESTION.Rows(X).Item("NUMERO")
                        LBL_DIRGESTION(X).Font = New Font(LBL_DIRGESTION(X).Font.Name, 11, FontStyle.Bold)
                        Controls.Add(LBL_DIRGESTION(X))
                    End If
                    'ZONA DE LA GESTION
                    If IsDBNull(ORDENESDataSet.GESTION.Rows(X).Item("ZONA")) = False Then
                        If ORDENESDataSet.GESTION.Rows(X).Item("ZONA") <> "" Then
                            LBL_ZONAGESTION(X) = New Label()
                            LBL_ZONAGESTION(X).AutoSize = True
                            LBL_ZONAGESTION(X).FlatStyle = FlatStyle.Flat
                            LBL_ZONAGESTION(X).Location = New Point(XPOS + 3, YPOS + 19)
                            LBL_ZONAGESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("ZONA")
                            LBL_ZONAGESTION(X).Font = New Font(LBL_ZONAGESTION(X).Font.Name, 10, FontStyle.Bold)
                            Controls.Add(LBL_ZONAGESTION(X))
                        End If
                    End If
                    'STATUS DE LA GESTION
                    BTN_STATUS_GESTION(X) = New Button()
                    BTN_STATUS_GESTION(X).AutoSize = False
                    BTN_STATUS_GESTION(X).Size = New Size(80, 20)
                    BTN_STATUS_GESTION(X).Location = New Point(XPOS + 220, YPOS + 4)
                    BTN_STATUS_GESTION(X).TextAlign = ContentAlignment.MiddleCenter
                    BTN_STATUS_GESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("STATUS")
                    BTN_STATUS_GESTION(X).Font = New Font(LBL_TIPOGESTION(X).Font.Name, 6, FontStyle.Bold)
                    BTN_STATUS_GESTION(X).FlatStyle = FlatStyle.Flat
                    BTN_STATUS_GESTION(X).FlatAppearance.BorderSize = 0
                    BTN_STATUS_GESTION(X).FlatAppearance.MouseDownBackColor = Color.White
                    BTN_STATUS_GESTION(X).FlatAppearance.MouseOverBackColor = Color.White
                    BTN_STATUS_GESTION(X).ForeColor = Color.White
                    LBL_INIGESTION(X) = New Label()
                    LBL_INIESTGESTION(X) = New Label()
                    Select Case ORDENESDataSet.GESTION.Rows(X).Item("STATUS")
                        Case "INGRESADO"
                            BTN_STATUS_GESTION(X).BackgroundImage = My.Resources.INGRESADO_BANNER
                            LBL_INIGESTION(X).Text = "INGRESADO: " & CDate(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINGRESADA")).ToShortDateString
                            LBL_INIESTGESTION(X).Text = "INI EST: " & CDate(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINICESTIMADA")).ToShortDateString & "      T.EST: " & (ORDENESDataSet.GESTION.Rows(X).Item("TIEMPOEST")) & " DÍAS"
                        Case "INICIADO"
                            BTN_STATUS_GESTION(X).BackgroundImage = My.Resources.INICIADO_BANNER
                            If IsDBNull(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINICIADA")) = False Then
                                LBL_INIGESTION(X).Text = "INICIADO: " & CDate(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINICIADA")).ToShortDateString
                            Else
                                LBL_INIGESTION(X).Text = "INICIO: S/D"
                            End If
                        Case "DEMORADO"
                            BTN_STATUS_GESTION(X).BackgroundImage = My.Resources.DEMORADO_BANNER
                            If IsDBNull(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINICIADA")) = False Then
                                LBL_INIGESTION(X).Text = "INICIADO: " & CDate(ORDENESDataSet.GESTION.Rows(X).Item("FECHAINICIADA")).ToShortDateString & "       T.EST: " & (ORDENESDataSet.GESTION.Rows(X).Item("TIEMPOEST")) & " DÍAS"
                            Else
                                LBL_INIGESTION(X).Text = "INICIO: S/D"
                            End If
                        Case "FINALIZADO"
                            BTN_STATUS_GESTION(X).BackgroundImage = My.Resources.FINALIZADO_BANNER
                    End Select
                    BTN_STATUS_GESTION(X).BackgroundImageLayout = ImageLayout.Stretch
                    Controls.Add(BTN_STATUS_GESTION(X))
                    'ASIGNACION DE LA GESTION
                    LBL_ASIGGESTION(X) = New Label()
                    LBL_ASIGGESTION(X).Size = New Size(95, 12)
                    LBL_ASIGGESTION(X).TextAlign = ContentAlignment.TopCenter
                    LBL_ASIGGESTION(X).FlatStyle = FlatStyle.Flat
                    LBL_ASIGGESTION(X).Location = New Point(XPOS + 215, YPOS + 25)
                    LBL_ASIGGESTION(X).Text = ORDENESDataSet.GESTION.Rows(X).Item("ASIGNADOA")
                    LBL_ASIGGESTION(X).Font = New Font(LBL_ASIGGESTION(X).Font.Name, 6, FontStyle.Bold)

                    'INICIO DE LA GESTION
                    LBL_INIGESTION(X).AutoSize = True
                    LBL_INIGESTION(X).FlatStyle = FlatStyle.Flat
                    LBL_INIGESTION(X).Location = New Point(XPOS + 30, YPOS + 70)
                    LBL_INIGESTION(X).Font = New Font(LBL_INIGESTION(X).Font.Name, 7)
                    Controls.Add(LBL_INIGESTION(X))

                    'INICIO ESTIMADO DE LA GESTION
                    LBL_INIESTGESTION(X).AutoSize = True
                    LBL_INIESTGESTION(X).FlatStyle = FlatStyle.Flat
                    LBL_INIESTGESTION(X).Location = New Point(XPOS + 30, YPOS + 81)
                    LBL_INIESTGESTION(X).Font = New Font(LBL_INIESTGESTION(X).Font.Name, 7)
                    Controls.Add(LBL_INIESTGESTION(X))
                    AddHandler BTN_GESTION(X).Click, AddressOf BTN_GESTION_Click
                    'AddHandler LBL_OBSGESTION(X).Click, AddressOf BTN_GESTION_Click
                    'AddHandler LBL_TIPOGESTION(X).Click, AddressOf BTN_GESTION_Click
                    Controls.Add(LBL_TIPOGESTION(X))
                    Controls.Add(LBL_OBSGESTION(X))
                    Controls.Add(LBL_ASIGGESTION(X))
                    Controls.Add(BTN_GESTION(X))
                    YPOS += 200
                Next

            Catch ex As Exception
                MsgBox("ERROR EN EL MODULO CREAR WIDGET GESTION  ->  " & ex.ToString)
            End Try
        Else
            Try
                For x = 0 To 48
                    Controls.Remove(BTN_GESTION(x))
                    Controls.Remove(LBL_TIPOGESTION(x))
                    Controls.Remove(LBL_OBSGESTION(x))
                    Controls.Remove(MODAL_PANEL)
                    Controls.Remove(BTN_STATUS_GESTION(x))
                    Controls.Remove(LBL_DIRGESTION(x))
                    Controls.Remove(LBL_ZONAGESTION(x))
                    Controls.Remove(LBL_ASIGGESTION(x))
                    Controls.Remove(LBL_INIGESTION(x))
                    Controls.Remove(LBL_INIESTGESTION(x))
                    Controls.Remove(BTN_TRABAJO(x))
                Next
            Catch ex As Exception
            End Try

        End If
    End Sub
    Private Sub CREAR_BTN_VER_GESTION(CREAR As Boolean, VALOR As String)
        If CREAR Then
            BTN_VERMAS_GESTION.Size = New Size(50, 50)
            BTN_VERMAS_GESTION.Location = New Point(1280, 618)
            BTN_VERMAS_GESTION.FlatStyle = FlatStyle.Flat
            BTN_VERMAS_GESTION.FlatAppearance.BorderSize = 0
            BTN_VERMAS_GESTION.FlatAppearance.BorderColor = Color.White
            BTN_VERMAS_GESTION.FlatAppearance.MouseOverBackColor = Color.White
            BTN_VERMAS_GESTION.FlatAppearance.MouseDownBackColor = Color.White
            BTN_VERMAS_GESTION.Font = New Font(BTN_VERMAS_GESTION.Font.Name, 20, FontStyle.Bold)
            BTN_VERMAS_GESTION.BackgroundImageLayout = ImageLayout.Stretch
            BTN_VERMAS_GESTION.BackgroundImage = My.Resources.BTN_VERMAS
            BTN_VERMAS_GESTION.Text = VALOR
            BTN_VERMAS_GESTION.Visible = True
            BTN_VERMAS_GESTION.BringToFront()
        Else
            BTN_VERMAS_GESTION.Visible = False
        End If

    End Sub                                                      'WIDGET DE GESTIONES
    Private Sub CREAR_MODAL_TRABAJO(CREAR As Boolean)
        If CREAR Then
            MODAL_PANEL = New Panel()
            MODAL_PANEL.Name = "TRABAJO"
            MODAL_PANEL.BorderStyle = BorderStyle.None
            MODAL_PANEL.BackColor = Color.White
            MODAL_PANEL.Size = New Size(1300, 609)
            MODAL_PANEL.Location = New Point(XPOS - 10, YPOS - 43)
            MODAL_PANEL.BackgroundImage = My.Resources.MODAL_PANEL
            MODAL_PANEL.BackgroundImageLayout = ImageLayout.Stretch
            Controls.Add(MODAL_PANEL)
            MODAL_PANEL.BringToFront()
            'TITULO DEL MODAL CON INFORMACION DE LA GESTION
            LBL_TITULOTRABAJO = New Label()
            LBL_TITULOTRABAJO.AutoSize = True
            LBL_TITULOTRABAJO.Location = New Point(XPOS + 105, YPOS - 32)
            LBL_TITULOTRABAJO.Text = "GESTION: " & W_GESTIONRow.Id_GESTION & " - " & W_GESTIONRow.TIPOGESTION
            LBL_TITULOTRABAJO.Font = New Font(LBL_TITULOTRABAJO.Font.Name, 18)
            'LBL_TITULOTRABAJO.ForeColor = Color.Black
            AddHandler MODAL_PANEL.Click, AddressOf BTN_TRABAJO_Click
            Controls.Add(LBL_TITULOTRABAJO)
            LBL_TITULOTRABAJO.BringToFront()
            'LABEL DE DIRECCION DE LA GESTION
            If W_GESTIONRow.CALLE <> "" Then
                LBL_SUBTITULOTRABAJO = New Label()
                LBL_SUBTITULOTRABAJO.AutoSize = True
                LBL_SUBTITULOTRABAJO.Location = New Point(LBL_TITULOTRABAJO.Location.X + LBL_TITULOTRABAJO.Size.Width + 100, YPOS - 30)
                LBL_SUBTITULOTRABAJO.Text = "Dirección: " & W_GESTIONRow.CALLE & " " & W_GESTIONRow.NUMERO
                LBL_SUBTITULOTRABAJO.Font = New Font(LBL_SUBTITULOTRABAJO.Font.Name, 11)
                LBL_SUBTITULOTRABAJO.ForeColor = Color.Black
                Controls.Add(LBL_SUBTITULOTRABAJO)
                LBL_SUBTITULOTRABAJO.BringToFront()
            End If
            'STATUS DE LA GESTION 
            BTN_STATUS_GESTION_ENTRABAJO = New Button()
            BTN_STATUS_GESTION_ENTRABAJO.Size = New Size(100, 30)
            BTN_STATUS_GESTION_ENTRABAJO.Location = New Point(XPOS + 1, YPOS - 32)
            BTN_STATUS_GESTION_ENTRABAJO.FlatStyle = FlatStyle.Flat
            BTN_STATUS_GESTION_ENTRABAJO.FlatAppearance.BorderSize = 0
            BTN_STATUS_GESTION_ENTRABAJO.FlatAppearance.BorderColor = Color.White
            BTN_STATUS_GESTION_ENTRABAJO.FlatAppearance.MouseOverBackColor = Color.White
            BTN_STATUS_GESTION_ENTRABAJO.FlatAppearance.MouseDownBackColor = Color.White
            BTN_STATUS_GESTION_ENTRABAJO.ForeColor = Color.White
            BTN_STATUS_GESTION_ENTRABAJO.Text = W_GESTIONRow.STATUS
            BTN_STATUS_GESTION_ENTRABAJO.Font = New Font(BTN_STATUS_GESTION_ENTRABAJO.Font.Name, 8, FontStyle.Bold)
            BTN_STATUS_GESTION_ENTRABAJO.BackgroundImageLayout = ImageLayout.Stretch
            Select Case W_GESTIONRow.STATUS
                Case "INGRESADO"
                    BTN_STATUS_GESTION_ENTRABAJO.BackgroundImage = My.Resources.INGRESADO_BANNER
                Case "INICIADO"
                    BTN_STATUS_GESTION_ENTRABAJO.BackgroundImage = My.Resources.INICIADO_BANNER
                Case "DEMORADO"
                    BTN_STATUS_GESTION_ENTRABAJO.BackgroundImage = My.Resources.DEMORADO_BANNER
                Case "FINALIZADO"
                    BTN_STATUS_GESTION_ENTRABAJO.BackgroundImage = My.Resources.FINALIZADO_BANNER
            End Select
            Controls.Add(BTN_STATUS_GESTION_ENTRABAJO)
            BTN_STATUS_GESTION_ENTRABAJO.BringToFront()
        Else
            Controls.Remove(MODAL_PANEL)
            Controls.Remove(LBL_TITULOTRABAJO)
            Controls.Remove(BTN_STATUS_GESTION_ENTRABAJO)
            Try
                Controls.Remove(LBL_SUBTITULOTRABAJO)
            Catch ex As Exception
            End Try
        End If

    End Sub                                    'WIDGET DEL MODAL TRABAJOS
    Private Sub BTN_GESTION_Click(sender As Object, e As EventArgs) Handles MyBase.Click 'BOTON PARA INGRESAR A LA GESTION Y CREAR ENTORNO
        Dim crtl_nodo As Control = DirectCast(sender, Control)
        YPOS = 50
        XPOS = 70

        If IsNumeric(crtl_nodo.Name) Then
            W_GESTIONRow = ORDENESDataSet.GESTION.FindById_GESTION(crtl_nodo.Name)
            TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, W_GESTIONRow.Id_GESTION)
            CREAR_MODAL_TRABAJO(True)
            INIFORT = 0
            If ORDENESDataSet.TRABAJOS.Rows.Count < 24 Then
                FINFORT = ORDENESDataSet.TRABAJOS.Rows.Count - 1
            Else
                FINFORT = 23
                If ORDENESDataSet.TRABAJOS.Rows.Count > 24 Then
                    CREAR_BTN_VER_TRABAJO(True, ">")
                End If
            End If
            CREAR_WIDGET_TRABAJO(True)
            'BTN_VERMAS_TRABAJO.BringToFront()
        Else
            CREAR_WIDGET_TRABAJO(False)
            CREAR_MODAL_ORDEN(False)
            CREAR_WIDGET_ORDEN(False)
        End If
    End Sub 'BOTON PARA INGRESAR A LA GESTION
    Private Sub CREAR_WIDGET_TRABAJO(CREAR As Boolean)
        YPOS = 50
        XPOS = 80
        If CREAR Then
            Try
                If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                    For X = INIFORT To FINFORT
                        Select Case X
                            Case 8
                                YPOS += 180
                                XPOS = 80
                            Case 16
                                YPOS += 180
                                XPOS = 80
                            Case 32
                                YPOS += 180
                                XPOS = 80
                            Case 40
                                YPOS += 180
                                XPOS = 80
                            Case 48
                                YPOS += 180
                                XPOS = 80
                        End Select
                        'GENERA EL BANNER-BOTON GESTION
                        BTN_TRABAJO(X) = New Button()
                        BTN_TRABAJO(X).Size = New Size(150, 180)
                        BTN_TRABAJO(X).Location = New Point(XPOS, YPOS)
                        BTN_TRABAJO(X).FlatStyle = FlatStyle.Flat
                        BTN_TRABAJO(X).FlatAppearance.BorderSize = 0
                        BTN_TRABAJO(X).FlatAppearance.BorderColor = Color.White
                        Select Case ORDENESDataSet.TRABAJOS.Rows(X).Item("TIPOTRABAJO")
                            Case "RELEVAMIENTO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_RELEVAMIENTO
                            Case "DISEÑO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_DISEÑO
                            Case "PRESUPUESTO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_PRESUPUESTO
                            Case "PREDICTIVO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_PREDICTIVO
                            Case "PREVENTIVO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_PREVENTIVO
                            Case "OBRA CIVIL", "GESTION OC"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_OBRACIVIL
                            Case "EJECUCION", "CONSTRUCCION"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_EJECUCION
                            Case "APROBACION IMM"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_APROBIMM
                            Case "APROBACION PERMISOS"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_APROBPERMISOR
                            Case "ACTUALIZACION PLANOS"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_ACTPLANOS
                            Case "REEMPLAZO DE FUENTE"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_REEMPFUENTE
                            Case "MANTENIMIENTO PREVENTIVO DE FUENTES"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_PREVENTIVO
                            Case "REPARACION DE FUENTE"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_REPARAFUENTE
                            Case "CAMBIO DE UBICACION"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_CAMBIOUBICACION
                            Case "TRABAJOS DE RED"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_TRABAJORED
                            Case "INSTALACION DE FUENTE X OBRA"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_INSTFUENTEOBRA
                            Case "RETIRO DE FUENTE X OBRA"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_RETFUENTEOBRA
                            Case "MEDICION Y CONTROL DE FUENTE"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_MEDYCONTROL
                            Case "AUTORIZACION CABLEADO"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_AUTOCABLEADO
                            Case "GESTION RED", "ASOCIADO A RED"
                                BTN_TRABAJO(X).BackgroundImage = My.Resources.BTN_TRABAJO_ASOCIADORED
                        End Select
                        'BTN_TRABAJO(X).Parent = MODAL_PANEL
                        BTN_TRABAJO(X).BackgroundImageLayout = ImageLayout.Stretch
                        BTN_TRABAJO(X).FlatAppearance.MouseOverBackColor = Color.White
                        BTN_TRABAJO(X).FlatAppearance.MouseDownBackColor = Color.White
                        BTN_TRABAJO(X).Name = ORDENESDataSet.TRABAJOS.Rows(X).Item("ID_TRABAJO")
                        AddHandler BTN_TRABAJO(X).Click, AddressOf BTN_TRABAJO_Click
                        Controls.Add(BTN_TRABAJO(X))
                        BTN_TRABAJO(X).BringToFront()
                        'STATUS TRABAJO
                        BTN_STATUS_TRABAJO(X) = New Button()
                        BTN_STATUS_TRABAJO(X).Size = New Size(65, 15)
                        BTN_STATUS_TRABAJO(X).Location = New Point(XPOS + 76, YPOS + 29)
                        BTN_STATUS_TRABAJO(X).FlatStyle = FlatStyle.Flat
                        BTN_STATUS_TRABAJO(X).FlatAppearance.BorderSize = 0
                        BTN_STATUS_TRABAJO(X).FlatAppearance.BorderColor = Color.White
                        BTN_STATUS_TRABAJO(X).FlatAppearance.MouseOverBackColor = Color.White
                        BTN_STATUS_TRABAJO(X).FlatAppearance.MouseDownBackColor = Color.White
                        BTN_STATUS_TRABAJO(X).ForeColor = Color.White
                        BTN_STATUS_TRABAJO(X).Text = ORDENESDataSet.TRABAJOS.Rows(X).Item("STATUS")
                        BTN_STATUS_TRABAJO(X).Font = New Font(BTN_STATUS_TRABAJO(X).Font.Name, 5, FontStyle.Bold)
                        BTN_STATUS_TRABAJO(X).BackgroundImageLayout = ImageLayout.Stretch

                        LBL_INITRABAJO(X) = New Label()
                        LBL_INIESTTRABAJO(X) = New Label()

                        Select Case ORDENESDataSet.TRABAJOS.Rows(X).Item("STATUS")
                            Case "INGRESADO"
                                BTN_STATUS_TRABAJO(X).BackgroundImage = My.Resources.INGRESADO_BANNER
                                LBL_INITRABAJO(X).Text = "INGRESADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINGRESADO")).ToShortDateString
                                LBL_INIESTTRABAJO(X).Text = "INI EST: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICESTIMADO")).ToShortDateString & "      T.EST: " & (ORDENESDataSet.TRABAJOS.Rows(X).Item("TIEMPOESTIMADO")) & " DÍAS"
                            Case "INICIADO"
                                BTN_STATUS_TRABAJO(X).BackgroundImage = My.Resources.INICIADO_BANNER
                                If IsDBNull(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")) = False Then
                                    LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString
                                Else
                                    LBL_INITRABAJO(X).Text = "INICIO: S/D"
                                End If
                            Case "DEMORADO"
                                BTN_STATUS_TRABAJO(X).BackgroundImage = My.Resources.DEMORADO_BANNER
                                If IsDBNull(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")) = False Then
                                    LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString & "       T.EST: " & (ORDENESDataSet.TRABAJOS.Rows(X).Item("TIEMPOESTIMADO")) & " DÍAS"
                                Else
                                    LBL_INITRABAJO(X).Text = "INICIO: S/D"
                                End If
                            Case "FINALIZADO"
                                BTN_STATUS_TRABAJO(X).BackgroundImage = My.Resources.FINALIZADO_BANNER
                                LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString
                                LBL_INIESTTRABAJO(X).Text = "FINALIZADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAFINALIZADO")).ToShortDateString

                        End Select
                        Controls.Add(BTN_STATUS_TRABAJO(X))
                        BTN_STATUS_TRABAJO(X).BringToFront()
                        'ZONA DEL TRABAJO
                        LBL_ZONATRABAJO(X) = New Label()
                        LBL_ZONATRABAJO(X).AutoSize = True
                        'LBL_ZONATRABAJO(X).Size = New Size(190, 64)
                        LBL_ZONATRABAJO(X).Location = New Point(XPOS + 3, YPOS + 30)
                        LBL_ZONATRABAJO(X).Text = "Zona: " & ORDENESDataSet.TRABAJOS.Rows(X).Item("ZONA")
                        LBL_ZONATRABAJO(X).Font = New Font(LBL_ZONATRABAJO(X).Font.Name, 7.5, FontStyle.Bold)
                        Controls.Add(LBL_ZONATRABAJO(X))
                        LBL_ZONATRABAJO(X).BringToFront()
                        'ZONA DEL TRABAJO
                        LBL_OBSTRABAJO(X) = New Label()
                        LBL_OBSTRABAJO(X).AutoSize = False
                        LBL_OBSTRABAJO(X).Size = New Size(139, 60)
                        LBL_OBSTRABAJO(X).Location = New Point(XPOS + 3, YPOS + 110)
                        LBL_OBSTRABAJO(X).Text = ORDENESDataSet.TRABAJOS.Rows(X).Item("DESCRIPCION")
                        LBL_OBSTRABAJO(X).Font = New Font(LBL_OBSTRABAJO(X).Font.Name, 6)
                        LBL_OBSTRABAJO(X).TextAlign = ContentAlignment.BottomCenter
                        Controls.Add(LBL_OBSTRABAJO(X))
                        LBL_OBSTRABAJO(X).BringToFront()
                        'ASIGNADO AL TRABAJO
                        LBL_ASIGtrabajo(X) = New Label()
                        LBL_ASIGtrabajo(X).AutoSize = True
                        LBL_ASIGtrabajo(X).Location = New Point(XPOS + 3, YPOS + 44)
                        LBL_ASIGtrabajo(X).Text = ORDENESDataSet.TRABAJOS.Rows(X).Item("ASIGNADOA")
                        LBL_ASIGtrabajo(X).Font = New Font(LBL_ASIGtrabajo(X).Font.Name, 7)
                        LBL_ASIGtrabajo(X).TextAlign = ContentAlignment.BottomCenter
                        Controls.Add(LBL_ASIGtrabajo(X))
                        LBL_ASIGtrabajo(X).BringToFront()
                        'INICIO DEL TRABAJO

                        LBL_INITRABAJO(X).AutoSize = True
                        LBL_INITRABAJO(X).FlatStyle = FlatStyle.Flat
                        LBL_INITRABAJO(X).Location = New Point(XPOS + 5, YPOS + 60)
                        LBL_INITRABAJO(X).Font = New Font(LBL_INITRABAJO(X).Font.Name, 6)
                        Controls.Add(LBL_INITRABAJO(X))
                        LBL_INITRABAJO(X).BringToFront()
                        'INICIO ESTIMADO DEL TRABAJO
                        LBL_INIESTTRABAJO(X).AutoSize = True
                        LBL_INIESTTRABAJO(X).FlatStyle = FlatStyle.Flat
                        LBL_INIESTTRABAJO(X).Location = New Point(XPOS + 5, YPOS + 70)
                        LBL_INIESTTRABAJO(X).Font = New Font(LBL_INIESTTRABAJO(X).Font.Name, 6)
                        Controls.Add(LBL_INIESTTRABAJO(X))
                        LBL_INIESTTRABAJO(X).BringToFront()

                        XPOS += 150
                    Next

                Else
                    MsgBox("NO HAY TRABAJOS EN ESTA GESTION")
                End If
            Catch EX As Exception
            End Try
        Else
            Try
                For x = 0 To 60
                    Controls.Remove(BTN_TRABAJO(x))
                    Controls.Remove(BTN_TRABAJO(x))
                    Controls.Remove(BTN_STATUS_TRABAJO(x))
                    Controls.Remove(LBL_ZONATRABAJO(x))
                    Controls.Remove(LBL_OBSTRABAJO(x))
                    Controls.Remove(LBL_ASIGtrabajo(x))
                    Controls.Remove(LBL_INITRABAJO(x))
                    Controls.Remove(LBL_INIESTTRABAJO(x))
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub                                    'WIDGET DE TRABAJOS
    Private Sub CREAR_BTN_VER_TRABAJO(CREAR As Boolean, VALOR As String)
        If CREAR Then
            BTN_VERMAS_TRABAJO.Size = New Size(50, 50)
            BTN_VERMAS_TRABAJO.Location = New Point(1280, 535)
            BTN_VERMAS_TRABAJO.FlatStyle = FlatStyle.Flat
            BTN_VERMAS_TRABAJO.FlatAppearance.BorderSize = 0
            BTN_VERMAS_TRABAJO.FlatAppearance.BorderColor = Color.White
            BTN_VERMAS_TRABAJO.FlatAppearance.MouseOverBackColor = Color.White
            BTN_VERMAS_TRABAJO.FlatAppearance.MouseDownBackColor = Color.White
            BTN_VERMAS_TRABAJO.Font = New Font(BTN_VERMAS_TRABAJO.Font.Name, 20, FontStyle.Bold)
            BTN_VERMAS_TRABAJO.BackgroundImageLayout = ImageLayout.Stretch
            BTN_VERMAS_TRABAJO.BackgroundImage = My.Resources.BTN_VERMAS
            BTN_VERMAS_TRABAJO.Text = VALOR
            BTN_VERMAS_TRABAJO.Visible = True
            BTN_VERMAS_TRABAJO.BringToFront()
        Else
            BTN_VERMAS_TRABAJO.Visible = False
        End If

    End Sub                 'CREA EL BOTON PARA AVANZAR EN TRABAJOS
    Private Sub BTN_VERMAS_GESTION_Click(sender As Object, e As EventArgs) Handles BTN_VERMAS_GESTION.Click 'BOTON PARA AVANZAR EN MOSTRAR MAS WIDGET
        Dim crtl_nodo As Control = DirectCast(sender, Control)
        CREAR_BTN_VER_GESTION(False, "NO")
        CREAR_WIDGET_GESTION(False)

        If BTN_VERMAS_GESTION.Text = ">" Then
            If ORDENESDataSet.GESTION.Rows.Count - 1 > 24 And INIFORG = 12 Then
                CREAR_BTN_VER_GESTION(True, ">")
                INIFORG = 23
                FINFORG = ORDENESDataSet.GESTION.Rows.Count - 1
                MsgBox("ENTRE A SI INIFORG ES 0")
            Else
                INIFORG = 12
                FINFORG = ORDENESDataSet.GESTION.Rows.Count - 1
                CREAR_BTN_VER_GESTION(True, "<")
                'MsgBox("ENTRE A SI INIFORG ES 12")
            End If
        Else
            INIFORG = 0
            FINFORG = 11
            CREAR_BTN_VER_GESTION(True, ">")
        End If
        CREAR_WIDGET_GESTION(True)
    End Sub
    Private Sub BTN_VERMAS_TRABAJO_CLICK(sender As Object, e As EventArgs) Handles BTN_VERMAS_TRABAJO.Click            'BOTON PARA AVANZAR EN MOSTRAR MAS WIDGET
        Dim crtl_nodo As Control = DirectCast(sender, Control)
        YPOS = 50
        XPOS = 70
        CREAR_WIDGET_TRABAJO(False)
        CREAR_BTN_VER_TRABAJO(False, "NO")

        If BTN_VERMAS_TRABAJO.Text = ">" Then
            If ORDENESDataSet.TRABAJOS.Rows.Count > 47 And INIFORT = 24 Then
                CREAR_BTN_VER_TRABAJO(True, ">")
                INIFORT = 48
                FINFORT = ORDENESDataSet.TRABAJOS.Rows.Count - 1
            Else
                INIFORT = 24
                FINFORT = 47
                CREAR_BTN_VER_TRABAJO(True, "<")
            End If
            CREAR_WIDGET_TRABAJO(True)
        Else
            If BTN_VERMAS_TRABAJO.Text = "<" Then
                INIFORT = 0
                FINFORT = 23
                CREAR_WIDGET_TRABAJO(True)
                CREAR_BTN_VER_TRABAJO(True, ">")
            End If
        End If
    End Sub               'BOTON PARA MOVER DE PAGINA TRABAJOS
    Private Sub BTN_TRABAJO_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim CRTL_TRABAJO As Control = DirectCast(sender, Control)

        If IsNumeric(CRTL_TRABAJO.Name) Then
            W_TRABAJORow = ORDENESDataSet.TRABAJOS.FindById_TRABAJO(CRTL_TRABAJO.Name)
            ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, W_TRABAJORow.Id_TRABAJO)
            CREAR_MODAL_ORDEN(True)
            'If ORDENESDataSet.ORDENES.Rows.Count < 10 Then

            'End If
            CREAR_WIDGET_ORDEN(True)
        Else
            CREAR_MODAL_ORDEN(False)
            CREAR_WIDGET_ORDEN(False)
        End If
    End Sub 'BOTON PARA INGRESAR AL TRABAJO
    Private Sub CREAR_MODAL_ORDEN(CREAR As Boolean)
        If CREAR = True Then
            YPOS = 50
            XPOS = 75
            PANEL_ORDEN = New Panel()
            PANEL_ORDEN.BorderStyle = BorderStyle.None
            PANEL_ORDEN.BackColor = Color.White
            PANEL_ORDEN.Size = New Size(1265, 551)
            PANEL_ORDEN.Location = New Point(XPOS, YPOS)
            PANEL_ORDEN.BackgroundImage = My.Resources.MODAL_PANEL
            PANEL_ORDEN.BackgroundImageLayout = ImageLayout.Stretch
            PANEL_ORDEN.Name = "ORDEN"
            AddHandler PANEL_ORDEN.Click, AddressOf BTN_ORDEN_CLICK
            Controls.Add(PANEL_ORDEN)
            PANEL_ORDEN.BringToFront()
            'TITULO DEL MODAL CON INFORMACION DE DEL TRABAJO
            LBL_TITULOORDEN = New Label()
            LBL_TITULOORDEN.AutoSize = True
            LBL_TITULOORDEN.Location = New Point(XPOS + 120, YPOS + 10)
            LBL_TITULOORDEN.Text = "TRABAJO: " & W_TRABAJORow.Id_TRABAJO & " - " & W_TRABAJORow.TIPOTRABAJO
            LBL_TITULOORDEN.Font = New Font(LBL_TITULOORDEN.Font.Name, 18)
            'LBL_TITULOTRABAJO.ForeColor = Color.Black

            Controls.Add(LBL_TITULOORDEN)
            LBL_TITULOORDEN.BringToFront()

            'LABEL DE DIRECCION DEL TRABAJO
            If W_TRABAJORow.CALLE <> "" Then
                LBL_SUBTITULOORDEN = New Label()
                LBL_SUBTITULOORDEN.AutoSize = True
                LBL_SUBTITULOORDEN.Location = New Point(LBL_TITULOORDEN.Location.X + LBL_TITULOORDEN.Size.Width + 100, YPOS + 16)
                LBL_SUBTITULOORDEN.Text = "Dirección: " & W_TRABAJORow.CALLE & " " & W_TRABAJORow.NRO
                LBL_SUBTITULOORDEN.Font = New Font(LBL_SUBTITULOORDEN.Font.Name, 11)
                LBL_SUBTITULOORDEN.ForeColor = Color.Black
                Controls.Add(LBL_SUBTITULOORDEN)
                LBL_SUBTITULOORDEN.BringToFront()
            End If
            'STATUS DEL TRABAJO
            BTN_STATUS_TRABAJO_EN_ORDEN = New Button()
            BTN_STATUS_TRABAJO_EN_ORDEN.Size = New Size(100, 30)
            BTN_STATUS_TRABAJO_EN_ORDEN.Location = New Point(XPOS + 10, YPOS + 12)
            BTN_STATUS_TRABAJO_EN_ORDEN.FlatStyle = FlatStyle.Flat
            BTN_STATUS_TRABAJO_EN_ORDEN.FlatAppearance.BorderSize = 0
            BTN_STATUS_TRABAJO_EN_ORDEN.FlatAppearance.BorderColor = Color.White
            BTN_STATUS_TRABAJO_EN_ORDEN.FlatAppearance.MouseOverBackColor = Color.White
            BTN_STATUS_TRABAJO_EN_ORDEN.FlatAppearance.MouseDownBackColor = Color.White
            BTN_STATUS_TRABAJO_EN_ORDEN.ForeColor = Color.White
            BTN_STATUS_TRABAJO_EN_ORDEN.Text = W_TRABAJORow.STATUS
            BTN_STATUS_TRABAJO_EN_ORDEN.Font = New Font(BTN_STATUS_TRABAJO_EN_ORDEN.Font.Name, 8, FontStyle.Bold)
            BTN_STATUS_TRABAJO_EN_ORDEN.BackgroundImageLayout = ImageLayout.Stretch
            Select Case W_TRABAJORow.STATUS
                Case "INGRESADO"
                    BTN_STATUS_TRABAJO_EN_ORDEN.BackgroundImage = My.Resources.INGRESADO_BANNER
                Case "INICIADO"
                    BTN_STATUS_TRABAJO_EN_ORDEN.BackgroundImage = My.Resources.INICIADO_BANNER
                Case "DEMORADO"
                    BTN_STATUS_TRABAJO_EN_ORDEN.BackgroundImage = My.Resources.DEMORADO_BANNER
                Case "FINALIZADO"
                    BTN_STATUS_TRABAJO_EN_ORDEN.BackgroundImage = My.Resources.FINALIZADO_BANNER
            End Select
            Controls.Add(BTN_STATUS_TRABAJO_EN_ORDEN)
            BTN_STATUS_TRABAJO_EN_ORDEN.BringToFront()
        Else
            Controls.Remove(PANEL_ORDEN)
            Controls.Remove(LBL_TITULOORDEN)
            Controls.Remove(LBL_SUBTITULOORDEN)
            Controls.Remove(BTN_STATUS_TRABAJO_EN_ORDEN)
        End If
    End Sub
    Private Sub CREAR_WIDGET_ORDEN(CREAR As Boolean)
        XPOS = 100
        YPOS = 100

        If CREAR Then
            Try
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                    For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1

                        'GENERA EL BANNER-BOTON ORDEN
                        BTN_ORDEN(X) = New Button()
                        BTN_ORDEN(X).Size = New Size(1200, 45)
                        BTN_ORDEN(X).Location = New Point(XPOS, YPOS)
                        BTN_ORDEN(X).FlatStyle = FlatStyle.Flat
                        BTN_ORDEN(X).FlatAppearance.BorderSize = 0
                        BTN_ORDEN(X).FlatAppearance.BorderColor = Color.White
                        BTN_ORDEN(X).BackgroundImageLayout = ImageLayout.Stretch
                        BTN_ORDEN(X).FlatAppearance.MouseOverBackColor = Color.White
                        BTN_ORDEN(X).FlatAppearance.MouseDownBackColor = Color.White
                        BTN_ORDEN(X).BackgroundImage = My.Resources.BTN_ORDEN
                        BTN_ORDEN(X).Name = ORDENESDataSet.ORDENES.Rows(X).Item("NRO_ORDENINT")
                        AddHandler BTN_ORDEN(X).Click, AddressOf BTN_ORDEN_CLICK
                        AddHandler BTN_ORDEN(X).MouseHover, AddressOf BTN_ORDEN_MOUSEHOVER
                        Controls.Add(BTN_ORDEN(X))
                        BTN_ORDEN(X).BringToFront()

                        BTN_STATUS_ORDEN(X) = New Button()
                        BTN_STATUS_ORDEN(X).Size = New Size(80, 20)
                        BTN_STATUS_ORDEN(X).Location = New Point(XPOS + 2, YPOS + 2)
                        BTN_STATUS_ORDEN(X).FlatStyle = FlatStyle.Flat
                        BTN_STATUS_ORDEN(X).FlatAppearance.BorderSize = 0
                        BTN_STATUS_ORDEN(X).FlatAppearance.BorderColor = Color.White
                        BTN_STATUS_ORDEN(X).FlatAppearance.MouseOverBackColor = Color.White
                        BTN_STATUS_ORDEN(X).FlatAppearance.MouseDownBackColor = Color.White
                        BTN_STATUS_ORDEN(X).ForeColor = Color.White
                        BTN_STATUS_ORDEN(X).Text = ORDENESDataSet.ORDENES.Rows(X).Item("STATUS")
                        BTN_STATUS_ORDEN(X).Font = New Font(BTN_STATUS_ORDEN(X).Font.Name, 5, FontStyle.Bold)
                        BTN_STATUS_ORDEN(X).BackgroundImageLayout = ImageLayout.Stretch


                        'LBL_INITRABAJO(X) = New Label()
                        'LBL_INIESTTRABAJO(X) = New Label()
                        If ORDENESDataSet.ORDENES.Rows(X).Item("CUADRILLA") <> "SIN ASIGNAR" Then
                            LBL_ASIGorden(X) = New Label()
                            LBL_ASIGorden(X).AutoSize = True
                            LBL_ASIGorden(X).Location = New Point(XPOS + 8, YPOS + 22)
                            LBL_ASIGorden(X).Text = ORDENESDataSet.ORDENES.Rows(X).Item("CUADRILLA")
                            LBL_ASIGorden(X).Font = New Font(LBL_ASIGorden(X).Font.Name, 7)
                            LBL_ASIGorden(X).TextAlign = ContentAlignment.BottomCenter
                            Controls.Add(LBL_ASIGorden(X))
                            LBL_ASIGorden(X).BringToFront()
                        End If

                        Select Case ORDENESDataSet.ORDENES.Rows(X).Item("STATUS")
                            Case "ORDINGRESADO", "INGRESADOINT", "ASIGNADO"
                                BTN_STATUS_ORDEN(X).BackgroundImage = My.Resources.INGRESADO_BANNER
                                'LBL_INITRABAJO(X).Text = "INGRESADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINGRESADO")).ToShortDateString
                                'LBL_INIESTTRABAJO(X).Text = "INI EST: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICESTIMADO")).ToShortDateString & "      T.EST: " & (ORDENESDataSet.TRABAJOS.Rows(X).Item("TIEMPOESTIMADO")) & " DÍAS"
                            Case "INICIADO", "AGENDADO"
                                BTN_STATUS_ORDEN(X).BackgroundImage = My.Resources.INICIADO_BANNER
                                'If IsDBNull(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")) = False Then
                                '    LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString
                                'Else
                                '    LBL_INITRABAJO(X).Text = "INICIO: S/D"
                                'End If
                            Case "DEMORADO", "ADUPLICAR", "CANCELADO"
                                BTN_STATUS_ORDEN(X).BackgroundImage = My.Resources.DEMORADO_BANNER
                                'If IsDBNull(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")) = False Then
                                '    LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString & "       T.EST: " & (ORDENESDataSet.TRABAJOS.Rows(X).Item("TIEMPOESTIMADO")) & " DÍAS"
                                'Else
                                '    LBL_INITRABAJO(X).Text = "INICIO: S/D"
                                'End If
                            Case "FINALIZADO", "DUPLICADO"
                                BTN_STATUS_ORDEN(X).BackgroundImage = My.Resources.FINALIZADO_BANNER
                                'LBL_INITRABAJO(X).Text = "INICIADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAINICIADO")).ToShortDateString
                                'LBL_INIESTTRABAJO(X).Text = "FINALIZADO: " & CDate(ORDENESDataSet.TRABAJOS.Rows(X).Item("FECHAFINALIZADO")).ToShortDateString
                        End Select
                        Controls.Add(BTN_STATUS_ORDEN(X))
                        BTN_STATUS_ORDEN(X).BringToFront()

                        YPOS += 45
                    Next
                End If
            Catch ex As Exception
            End Try
        Else
            Try
                For X = 0 To 50
                    Controls.Remove(BTN_ORDEN(X))
                    Controls.Remove(BTN_STATUS_ORDEN(X))
                    Controls.Remove(LBL_ASIGorden(X))
                Next
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub BTN_ORDEN_CLICK(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim CRTL_ORDEN As Control = DirectCast(sender, Control)
        If IsNumeric(CRTL_ORDEN.Name) Then
            MsgBox("NUMERO DE ORDEN " & CRTL_ORDEN.Name)
        End If
    End Sub
    Private Sub BTN_ORDEN_MOUSEHOVER(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        'Dim CRTL_ORDEN_HOVER As Control = DirectCast(sender, Control)
        'If IsNumeric(CRTL_ORDEN_HOVER.Name) Then
        '    LBL_TITULOORDEN.Text = "NUMERO DE ORDEN " & CRTL_ORDEN_HOVER.Name
        'End If
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover

    End Sub


End Class