Imports System.IO
Imports System.Net
Imports System.Text

Public Class AGENDA
    Dim TEC_GROUP(300) As GroupBox
    Dim BTN_ACTIVIDAD(300) As Button
    Dim LBL_DIA(5) As Label
    Dim LBL_FECHA(5) As Label
    Dim AGENDARow As EDIFICIODataSet.AGENDARow
    Dim TECNICORow As EDIFICIODataSet.TECNICOSRow
    Public MDURow As EDIFICIODataSet.MDURow
    Dim BITACORARow As EDIFICIODataSet.BITACORARow
    Dim POSX As Integer
    Dim POSY As Integer
    Dim POS_ACT_Y As Integer
    Dim DIA_DIFF As Integer
    Dim DIA_AGENDA As Date
    Dim POSX_DIA As Integer
    Dim TOTAL_DIAS_AG As Integer
    Dim ANCHO_GRAL As Integer
    Dim ALTO_GRAL As Integer
    Dim DIA_INI As Date
    Dim CTRL_AGENDA As Control
    Dim TEC_ID As Integer

    Dim AGENDA_DIA_TEMP As Date
    Dim IDMDU_TEMP As Integer
    Public EDI_ID_AGENDAR As Integer
    Dim TURNO As Integer
    Dim EDI_ID As Integer
    Dim TURNO_ID As String
    Dim TIPO_AG_ID As Boolean
    Dim AGENDA_DIA As Date
    Dim canva As Graphics
    Dim LAPIZ_GRAY As New Pen(Color.DarkGray, 1)

    Private Sub AGENDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)

        ACCION_AG(ACCION_AGENDA)
    End Sub
    Public Sub ACCION_AG(ByVal ACCION As String)
        If ACCION = "VER AGENDAMIENTO" Then
            AGENDATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.AGENDA, EDI_ID_AGENDAR)
            DIA_INI = EDIFICIODataSet.AGENDA.Rows(0).Item("DIA_AGENDA")
        Else
            DIA_INI = Today
        End If
        LBL_ACCESO.Text = "MODO " & ACCION
        LBL_ACCESO.Refresh()
        CARGAR_DATOS(DIA_INI)
    End Sub
    Private Sub CARGAR_DATOS(ByVal FECHA_INI As Date)
        TURNOSTableAdapter.FillByACTIVO(EDIFICIODataSet.TURNOS)
        ANCHO_GRAL = 250
        ALTO_GRAL = 21 * EDIFICIODataSet.TURNOS.Rows.Count + 28
        BORRAR()
        DIA_DIFF = DateDiff(DateInterval.Day, FECHA_INI, FECHA_INI.AddDays(4))
        POSX_DIA = 20 + ANCHO_GRAL / 3
        If DIA_DIFF > 5 Then
            TOTAL_DIAS_AG = 5
        Else
            TOTAL_DIAS_AG = DIA_DIFF
        End If
        POSX = 50
        canva = CreateGraphics()

        For DIA = 0 To TOTAL_DIAS_AG
            DIA_AGENDA = FECHA_INI.AddDays(DIA)

            LBL_DIA(DIA) = New Label
                LBL_DIA(DIA).AutoSize = True
                LBL_DIA(DIA).Text = DIA_AGENDA.ToString("dddd").ToUpper
                LBL_FECHA(DIA) = New Label
                LBL_FECHA(DIA).Text = DIA_AGENDA.ToShortDateString
                LBL_DIA(DIA).Location = New Point(POSX_DIA, 25)
                LBL_FECHA(DIA).Location = New Point(POSX_DIA + LBL_DIA(DIA).Width - 20, 25)
                Controls.Add(LBL_FECHA(DIA))
                Controls.Add(LBL_DIA(DIA))

                POSX_DIA += ANCHO_GRAL + 5
            POSY = 48
            TECNICOSTableAdapter.FillByDISPONIBILIDAD_DIA(EDIFICIODataSet.TECNICOS, DIA_AGENDA.ToString("dddd").ToUpper) ' HAY QUE VER SI TODOS LOS TECNICOS 
            If EDIFICIODataSet.TECNICOS.Rows.Count > 0 Then
                For TEC = 0 To EDIFICIODataSet.TECNICOS.Rows.Count - 1
                    TECNICORow = EDIFICIODataSet.TECNICOS.Rows(TEC)
                    If TECNICORow.DISPONIBILIDAD_DIA = DIA_AGENDA.ToString("dddd").ToUpper Then
                        POS_ACT_Y = -5
                        TEC_GROUP(DIA & TEC) = New GroupBox
                        TEC_GROUP(DIA & TEC).Size = New Size(ANCHO_GRAL, ALTO_GRAL)
                        TEC_GROUP(DIA & TEC).Location = New Point(POSX, POSY)
                        TEC_GROUP(DIA & TEC).Text = TECNICORow.NOMBRE & "    -   " & TECNICORow.TURNO
                        Select Case ACCION_AGENDA
                            Case "AGENDAR", "VISTA", "VER AGENDAMIENTO"
                                AGENDATableAdapter.FILLBYDIA_TEC(EDIFICIODataSet.AGENDA, DIA_AGENDA, TECNICORow.ID_TECNICO, False)
                            Case "AGENDAR CERTIFICADO", "VISTA CERTIFICADOS"
                                AGENDATableAdapter.FILLBYDIA_TEC(EDIFICIODataSet.AGENDA, DIA_AGENDA, TECNICORow.ID_TECNICO, True)
                        End Select

                        TURNO = 0
                        'RECORREMOS LOS 4 TURNOS DEL TECNICO
                        For Each TURNOS In EDIFICIODataSet.TURNOS
                            If TURNO = EDIFICIODataSet.TURNOS.Rows.Count Then
                                POS_ACT_Y += 11
                            End If
                            TURNO += 1
                            POS_ACT_Y += 22
                            BTN_ACTIVIDAD(TURNO & TEC) = New Button
                            BTN_ACTIVIDAD(TURNO & TEC).BackColor = Color.Green
                            BTN_ACTIVIDAD(TURNO & TEC).Text = TURNOS.HORARIO & " - " & TURNOS.TIEMPO
                            If TURNOS.HORARIO = "EXTRA" Then
                                BTN_ACTIVIDAD(TURNO & TEC).Text = "CAPACIDAD EXTRA - FUERA AGENDA"
                                BTN_ACTIVIDAD(TURNO & TEC).BackColor = Color.Gray
                            End If
                            BTN_ACTIVIDAD(TURNO & TEC).Name = DIA_AGENDA & "-" & TURNOS.ID_TURNO & "-" & TECNICORow.ID_TECNICO
                            BTN_ACTIVIDAD(TURNO & TEC).Size = New Size(ANCHO_GRAL - 4, 21)
                            BTN_ACTIVIDAD(TURNO & TEC).ForeColor = Color.White
                            BTN_ACTIVIDAD(TURNO & TEC).Location = New Point(2, POS_ACT_Y)
                            BTN_ACTIVIDAD(TURNO & TEC).FlatStyle = FlatStyle.Flat

                            If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
                                For TAREA = 0 To EDIFICIODataSet.AGENDA.Rows.Count - 1
                                    AGENDARow = EDIFICIODataSet.AGENDA.Rows(TAREA)
                                    If TURNOS.ID_TURNO = AGENDARow.ID_TURNO Then
                                        MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, AGENDARow.ID_EDIFICIO)
                                        MDURow = EDIFICIODataSet.MDU.Rows(0)
                                        BTN_ACTIVIDAD(TURNO & TEC).BackColor = Color.Red
                                        BTN_ACTIVIDAD(TURNO & TEC).Text = Mid(TURNOS.HORARIO, 1, 3) & " || " & MDURow.NODO & " " & MDURow.ZONA & " - " & MDURow.CALLE & " " & MDURow.PUERTA
                                        BTN_ACTIVIDAD(TURNO & TEC).Name += "-" & AGENDARow.ID_EDIFICIO
                                    End If
                                Next
                            End If
                            TEC_GROUP(DIA & TEC).Controls.Add(BTN_ACTIVIDAD(TURNO & TEC))
                            AddHandler BTN_ACTIVIDAD(TURNO & TEC).MouseDown, AddressOf BTN_AGENDA_Click
                        Next
                        Controls.Add(TEC_GROUP(DIA & TEC))
                    End If
                    POSY += ALTO_GRAL + 10
                Next   'CICLO PARA CADA TECNICO
            End If
            POSX += ANCHO_GRAL + 5
            If DIA <> TOTAL_DIAS_AG Then canva.DrawLine(LAPIZ_GRAY, POSX - 3, 20, POSX - 3, Screen.PrimaryScreen.WorkingArea.Height)
        Next    'CICLO PARA RECORRER LA AGENDA DIA A DIA, SE ARMA EL DIA PARA TODOS LOS TECNICOS, LUEGO SE PASA AL DIA SIG
    End Sub
    Private Sub BTN_AGENDA_Click(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        CTRL_AGENDA = DirectCast(sender, Control)
        If IsDate(Split(CTRL_AGENDA.Name, "-")(0)) Then
            AGENDA_DIA = Split(CTRL_AGENDA.Name, "-")(0)
            TURNO_ID = Split(CTRL_AGENDA.Name, "-")(1)
            TEC_ID = Split(CTRL_AGENDA.Name, "-")(2)
            Try
                EDI_ID = Split(CTRL_AGENDA.Name, "-")(3)
                MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, EDI_ID)
                If EDIFICIODataSet.MDU.Rows.Count > 0 Then
                    MDURow = EDIFICIODataSet.MDU.Rows(0)
                    CLICK_DERECHO(e)
                End If
            Catch ex As Exception
                EDI_ID = 0
            End Try
            Select Case ACCION_AGENDA
                Case "AGENDAR", "AGENDAR CERTIFICADO"
                    'EDITA EL STATUS DEL EDIFICIO
                    If EDI_ID = 0 Then
                        MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, EDI_ID_AGENDAR)
                        If EDIFICIODataSet.MDU.Rows.Count > 0 Then
                            MDURow = EDIFICIODataSet.MDU.Rows(0)

                            'InsertAgendaAPI()
                            If ACCION_AGENDA = "AGENDAR" Then
                                EDITAR_EDIFICIO(2)
                                AGENDA_INSERT(False)
                                ACCION_AGENDA = "VER AGENDAMIENTO"
                            ElseIf ACCION_AGENDA = "AGENDAR CERTIFICADO" Then
                                EDITAR_EDIFICIO(5)
                                AGENDA_INSERT(True)
                                ACCION_AGENDA = "VISTA CERTIFICADOS"
                            End If
                            ACCION_AG(ACCION_AGENDA)
                            NOTIFICACION("SYS", "EDIFICIO AGENDADO")
                        End If
                    Else
                        NOTIFICACION("SYS", "CAPACIDAD YA USADA")
                    End If
                Case "REAGENDAR", "REAGENDAR CERTIFICADO"
                    'MODIFICA EL REGISTRO DE LA AGENDA

                    AGENDATableAdapter.FillByIDMDU_DIAAGENDA(EDIFICIODataSet.AGENDA, IDMDU_TEMP, AGENDA_DIA_TEMP)

                    If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
                        AGENDARow = EDIFICIODataSet.AGENDA.Rows(0)
                        AGENDARow.DIA_AGENDA = AGENDA_DIA
                        AGENDARow.ID_TECNICO = TEC_ID
                        AGENDARow.ID_EDIFICIO = EDI_ID_AGENDAR
                        AGENDARow.ID_TURNO = TURNO_ID
                        AGENDATableAdapter.Update(AGENDARow)
                        MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, IDMDU_TEMP)
                        If EDIFICIODataSet.MDU.Rows.Count > 0 Then
                            MDURow = EDIFICIODataSet.MDU.Rows(0)
                        End If
                        If ACCION_AGENDA = "REAGENDAR" Then
                            EDITAR_EDIFICIO(2)
                            ACCION_AGENDA = "VER AGENDAMIENTO"
                            ACCION_AG(ACCION_AGENDA)
                        ElseIf ACCION_AGENDA = "REAGENDAR CERTIFICADO" Then
                            EDITAR_EDIFICIO(5)
                            ACCION_AGENDA = "VER AGENDAMIENTO CERTIFICADO"
                            ACCION_AG(ACCION_AGENDA)
                        End If
                        NOTIFICACION("SYS", "EDIFICIO REAGENDADO")
                    End If
            End Select
        Else
            CTRL_AGENDA = Nothing
        End If
    End Sub
    Private Sub CLICK_DERECHO(ByVal e)
        If e.Button = MouseButtons.Right Then
            P_MENU.Location = New Point(MousePosition.X - 5, MousePosition.Y - 5)
            P_MENU.Visible = True
            P_MENU.Focus()
        Else
            If DETALLE_MDU.Visible Then DETALLE_MDU.Close()
            DETALLE_MDU.Show()
        End If
    End Sub
    Private Sub AGENDA_INSERT(ByVal TIPOAGENDA As Boolean)
        'INGRESA NUEVO REGISTRO DE AGENDA
        AGENDARow = EDIFICIODataSet.AGENDA.NewAGENDARow()
        AGENDARow.ID_EDIFICIO = EDI_ID_AGENDAR
        AGENDARow.ID_TURNO = TURNO_ID
        AGENDARow.ID_TECNICO = TEC_ID
        AGENDARow.DIA_AGENDA = AGENDA_DIA
        AGENDARow.CERTIFICADO = TIPOAGENDA
        EDIFICIODataSet.AGENDA.AddAGENDARow(AGENDARow)
        AGENDATableAdapter.Update(AGENDARow)
    End Sub
    Private Sub BORRAR()
        For X = 0 To 5
            Try
                Controls.Remove(LBL_DIA(X))
                Controls.Remove(LBL_FECHA(X))
            Catch ex As Exception
            End Try
        Next

        For Y = 0 To 100
            Try
                Controls.Remove(BTN_ACTIVIDAD(Y))
            Catch ex As Exception
            End Try
            Try
                Controls.Remove(TEC_GROUP(Y))
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        DIA_INI = DIA_INI.AddDays(-5)
        CARGAR_DATOS(DIA_INI)
    End Sub
    Private Sub BTN_NEXT_Click(sender As Object, e As EventArgs) Handles BTN_NEXT.Click
        DIA_INI = DIA_INI.AddDays(5)
        CARGAR_DATOS(DIA_INI)
    End Sub
    Private Sub BTN_CLOSE_MENU_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE_MENU.Click
        P_MENU.Visible = False
    End Sub
    Private Sub BTN_MENU_DESAGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_MENU_DESAGENDAR.Click
        'EVENTO PARA DEAGENDAR EL EDIFICIO
        AGENDATableAdapter.FillByIDMDU_DIAAGENDA(EDIFICIODataSet.AGENDA, MDURow.ID_MDU, AGENDA_DIA)
        If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
            EDIFICIODataSet.AGENDA.Rows(0).Delete()
            AGENDATableAdapter.Update(EDIFICIODataSet.AGENDA)
        End If
        Select Case ACCION_AGENDA
            Case "VER AGENDAMIENTO", "VISTA"
                EDITAR_EDIFICIO(1)
            Case "VISTA CERTIFICADOS"
                EDITAR_EDIFICIO(4)
        End Select
        CARGAR_DATOS(DIA_INI)
    End Sub
    Public Sub BITACORA_INSERT(ByVal ID_EDIFICIO As Integer)
        BITACORARow = EDIFICIODataSet.BITACORA.NewBITACORARow()
        BITACORARow.ID_EDIFICIO = MDURow.ID_MDU
        BITACORARow.FECHA_ING = Today.ToShortDateString
        If DETALLE_MDU.TXT_NOMBRE.Text <> "" Then BITACORARow.NOMBRE_CTTO = DETALLE_MDU.TXT_NOMBRE.Text
    End Sub
    Public Sub EDITAR_EDIFICIO(ByVal CODIGO_STATUS As Integer)
        MDURow.ID_STATUS = CODIGO_STATUS
        MDURow.MODIFICADO = Today.ToShortDateString
        MDUTableAdapter.Update(MDURow)
        NOTIFICACION("SYS", "EDIFICIO MODIFICADO")
        '  CARGAR_DATOS(DIA_INI)
        P_MENU.Visible = False
    End Sub
    
    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click

        If DETALLE_MDU.Visible Then DETALLE_MDU.DETALLE_MDU_Load(Nothing, Nothing)
        Me.Close()
    End Sub
    Private Sub InsertAgendaAPI()

        Dim jsonData As String = "{""token"":""75dc7f7d88c3a2cfe3be912562215ca7"",""id_edificio"":""" & EDI_ID_AGENDAR & """,""id_turno"":""" & TURNO_ID & """,""id_tecnico"":""" & TEC_ID & """,""dia_agenda"":""" & Format(AGENDA_DIA, "yyyy-MM-dd") & """}"
        MsgBox(jsonData)
        Dim url As String = "http://localhost/api/agenda.php"
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(jsonData)
        request.ContentLength = dataBytes.Length

        Using stream As Stream = request.GetRequestStream()
            stream.Write(dataBytes, 0, dataBytes.Length)
        End Using

        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            MsgBox(reader.ReadToEnd())
        End Using
    End Sub

    Private Sub BTN_MENU_REAGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_MENU_REAGENDAR.Click
        ACCION_AGENDA = "REAGENDAR"
        P_MENU.Visible = False
        AGENDA_DIA_TEMP = DIA_AGENDA
        IDMDU_TEMP = MDURow.ID_MDU
    End Sub
End Class