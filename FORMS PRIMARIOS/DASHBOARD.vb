Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Public Class DASHBOARD
    Dim TIEMPO As Integer
    Dim CUENTA_CLIMA As Integer
    Dim CUENTA_CLIMA_HORA As Integer
    Public ALTOP As Integer = Screen.PrimaryScreen.WorkingArea.Size.Height
    Public ANCHOP As Integer = Screen.PrimaryScreen.WorkingArea.Size.Width
    Public USUARIO_ARRAY As Array
    Dim arrastre As Boolean
    Dim ex As Integer
    Dim ey As Integer
    Public MonitorPrimario As Boolean
    Public MonitorNegativo As Boolean
    Dim CONTAR As Integer
    Dim HORA As String
    Dim MINUTOS As String
    Private Sub DASHBOARD_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'OBTENER_HORA()
        RELOJ_SEG.Enabled = True

    End Sub
    Private Sub INGRESO_Load(sender As Object, e As EventArgs) Handles Me.Load


        Try
            USUARIO_ARRAY = Split(Trim(File.ReadAllText("C:\DOCUMENTOS\USUARIO\LOGVBNET.TXT")), ",")
        Catch ex As Exception
            MsgBox("error al leer archivo  " & ex.Message)
            Exit Sub
        End Try
        Try
            If File.Exists("C:\DOCUMENTOS\USUARIO\VERSION.TXT") And File.Exists("G:\OPERACIONES\PROGRAMAS\VERSION.TXT") Then
                If File.ReadAllText("C:\DOCUMENTOS\USUARIO\VERSION.TXT") <> File.ReadAllText("G:\OPERACIONES\PROGRAMAS\VERSION.TXT") Then
                    USUARIOSTableAdapter.FillByID(OPERACIONES_LOGDataSet.USUARIOS, USUARIO_ARRAY(0))
                    If OPERACIONES_LOGDataSet.USUARIOS.Rows.Count() > 0 Then
                        VERSION = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("VERSION")
                    End If
                    'CARGAMOS LA VARIABLE DE QUE VERSION ES Y HACEMOS UN SHELL CON LA APLICACION ACTUALIZAR
                    Shell("G:\OPERACIONES\PROGRAMAS\ACTUALIZADOR\" & VERSION & "\Actualizador.exe")
                    Dispose()
                    End
                Else
                    WindowState = FormWindowState.Minimized
                    INICIO_DASH()

                End If
            Else
                If File.Exists("C:\DOCUMENTOS\USUARIO\VERSION.TXT") = False Then
                    File.Create("C:\DOCUMENTOS\USUARIO\VERSION.TXT").Dispose()
                End If
                If File.ReadAllText("C:\DOCUMENTOS\USUARIO\VERSION.TXT") <> File.ReadAllText("G:\OPERACIONES\PROGRAMAS\VERSION.TXT") Then
                    USUARIOSTableAdapter.FillByID(OPERACIONES_LOGDataSet.USUARIOS, USUARIO_ARRAY(0))
                    If OPERACIONES_LOGDataSet.USUARIOS.Rows.Count() > 0 Then
                        VERSION = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("VERSION")
                        THEME_BLACK = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("BLACK")
                    End If
                    'CARGAMOS LA VARIABLE DE QUE VERSION ES Y HACEMOS UN SHELL CON LA APLICACION ACTUALIZAR
                    Shell("G:\OPERACIONES\PROGRAMAS\ACTUALIZADOR\" & VERSION & "\Actualizador.exe")
                    Dispose()
                    Close()
                Else
                    INICIO_DASH()

                End If
            End If

        Catch EX As Exception
            MsgBox("OOOps!!! Parece que algo anda mal -> " & EX.Message)
        End Try
    End Sub
    Public Sub ContarRegistros()
        'CUENTA MENSAJES RECIBIDOS
        MENSAJERIATableAdapter.FillByRECIBIDOSNOLEIDOS(ORDENESDataSet.MENSAJERIA, FULLNOMBRE, SECTOR)
        BTNMensajeria.Text = ORDENESDataSet.MENSAJERIA.Count
        ORDENESTableAdapter.FillByASIGNADOA(ORDENESDataSet.ORDENES, FULLNOMBRE)
        TRABAJOSTableAdapter.FillByASIGNADOA(ORDENESDataSet.TRABAJOS, FULLNOMBRE)
        GESTIONTableAdapter.FillByASIGNADOA(ORDENESDataSet.GESTION, FULLNOMBRE)
        BTNAsignado.Text = ORDENESDataSet.ORDENES.Count + ORDENESDataSet.TRABAJOS.Count + ORDENESDataSet.GESTION.Count
    End Sub
    Public Sub APLICAR_THEME_WHITE()
        '___________________UI__________________________________________________________________
        If THEME_BLACK = False Then
            BtnCerrar.BackgroundImage = My.Resources.logout
            BtnCerrar.FlatAppearance.MouseOverBackColor = Color.White
            BtnFull.BackgroundImage = My.Resources.restore
            BtnFull.FlatAppearance.MouseOverBackColor = Color.White
            BtnMinimizar.BackgroundImage = My.Resources.menos
            BtnMinimizar.FlatAppearance.MouseOverBackColor = Color.White

            ForeColor = FORE_COLOR_W
            BackColor = Color.White
            PanelTrabajo.BackColor = Color.White
            PanelSuperior.Height = 56
            PanelSUPInterior.Size = New Size(900, 56)

            PanelSuperior.BackColor = Color.White
            PanelSuperior.BackgroundImage = My.Resources.BANNER_SUPERIOR
            '  PanelSuperior.BackgroundImageLayout = ImageLayout.None
            PanelSUPInterior.Width = 1100
            PanelInferior.Height = 0
            Dim centrado As Integer = 420
            BTNMensajeria.Location = New Point(1, 0)
            BTNMensajeria.ForeColor = FORE_COLOR_W
            BTNMensajeria.Size = New Size(50, 50)
            BTNMensajeria.TextAlign = ContentAlignment.MiddleCenter
            BTNMensajeria.BackgroundImage = My.Resources.MENSAJES
            BTNMensajeria.BackColor = Color.Transparent
            BTNCerrarMensajes.FlatAppearance.MouseOverBackColor = Color.White
            BTNCerrarMensajes.BackgroundImage = My.Resources.BTNCancelar
            BTNCerrarMensajes.Location = New Point(50, 1)

            BTNAsignado.Location = New Point(61, 0)
            BTNAsignado.ForeColor = FORE_COLOR_W
            BTNAsignado.Size = New Size(50, 50)
            BTNAsignado.TextAlign = ContentAlignment.MiddleCenter
            BTNAsignado.BackgroundImage = My.Resources.ASIGNADO
            BTNCerrarAsignado.FlatAppearance.MouseOverBackColor = Color.White
            BTNCerrarAsignado.BackColor = Color.Transparent
            BTNCerrarAsignado.BackgroundImage = My.Resources.BTNCancelar
            BTNCerrarAsignado.Location = New Point(111, 1)

            MISTrabajos.Parent = PanelSUPInterior
            MISTrabajos.AutoSize = True
            MISTrabajos.Location = New Point(62 * 2, 4)
            MISTrabajos.ForeColor = Color.White
            MISTrabajos.BackColor = Color.Transparent
            MISTrabajos.BackgroundImage = My.Resources.DEMORADO_BANNER
            MISTrabajos.BackgroundImageLayout = ImageLayout.Stretch

            BTN_MISGestiones.Parent = PanelSUPInterior
            BTN_MISGestiones.AutoSize = True
            BTN_MISGestiones.Location = New Point(62 * 2, 21)
            BTN_MISGestiones.BackColor = Color.White
            BTN_MISGestiones.ForeColor = Color.White
            BTN_MISGestiones.BackgroundImage = My.Resources.DEMORADO_BANNER
            BTN_MISGestiones.BackgroundImageLayout = ImageLayout.Stretch


            BTN_AGENDA.Parent = PanelSUPInterior
            BTN_AGENDA.Location = New Point(centrado, 0)

            BTN_AGENDA.BackgroundImage = My.Resources.AGENDA
            BTN_AGENDA.Size = New Size(50, 50)
            BTN3Close.Location = New Point(BTN_AGENDA.Location.X + BTN_AGENDA.Size.Width, BTN_AGENDA.Location.Y)
            BTN_AGENDA.Text = ""
            BTN_AGENDA.BringToFront()

            BTN_ADMIN.Parent = PanelSUPInterior
            BTN_ADMIN.Location = New Point(centrado + 60, 0)
            BTN_ADMIN.BackgroundImage = My.Resources.AD_TEC
            BTN_ADMIN.Size = New Size(50, 50)
            BTN_ADMIN.Text = ""
            BTN_ADMIN.BringToFront()

            BTN_MDU.Parent = PanelSUPInterior
            BTN_MDU.Location = New Point(centrado + 60 * 2, 0)
            BTN_MDU.BackgroundImage = My.Resources.EDIFICIO
            BTN_MDU.Size = New Size(50, 50)
            BTN_MDU.Text = ""
            BTN_MDU.BringToFront()

            BTN_RED.Parent = PanelSUPInterior
            BTN_RED.Location = New Point(centrado + 60 * 3, 0)
            BTN_RED.BackgroundImage = My.Resources.RED
            BTN_RED.Size = New Size(50, 50)
            BTN_RED.Text = ""
            BTN_RED.BringToFront()

            BTN_FUENTES.Parent = PanelSUPInterior
            BTN_FUENTES.Location = New Point(centrado + 60 * 4, 0)
            BTN_FUENTES.BackgroundImage = My.Resources.FUENTE
            BTN_FUENTES.Size = New Size(50, 50)
            BTN_FUENTES.Text = ""
            BTN_FUENTES.BringToFront()

            BTN_FTTB.Parent = PanelSUPInterior
            BTN_FTTB.Location = New Point(centrado + 60 * 5, 0)
            BTN_FTTB.BackgroundImage = My.Resources.FIBRA
            BTN_FTTB.Size = New Size(50, 50)
            BTN_FTTB.Text = ""
            BTN_FTTB.Visible = True
            BTN_FTTB.BringToFront()

            BTN_DESPACHO.Parent = PanelSUPInterior
            BTN_DESPACHO.Location = New Point(centrado + 60 * 6, 0)
            BTN_DESPACHO.BackgroundImage = My.Resources.DESPACHO
            BTN_DESPACHO.Size = New Size(50, 50)
            BTN_DESPACHO.Text = ""
            BTN_DESPACHO.BringToFront()

            BTN_BUSCADOR.Parent = PanelSUPInterior
            BTN_BUSCADOR.Location = New Point(centrado + 60 * 7, 0)
            BTN_BUSCADOR.BackgroundImage = My.Resources.BUSQUEDA
            BTN_BUSCADOR.Size = New Size(50, 50)
            BTN_BUSCADOR.Text = ""
            BTN_BUSCADOR.Visible = True
            BTN_BUSCADOR.BringToFront()

            BTN_Proceso.Parent = PanelSUPInterior
            BTN_Proceso.Location = New Point(centrado + 60 * 8, 0)
            BTN_Proceso.BackgroundImage = My.Resources.PROCESOS
            BTN_Proceso.Size = New Size(50, 50)
            BTN_Proceso.Text = ""
            BTN_Proceso.BringToFront()

            'BTN_FTTB.Parent = PanelSUPInterior
            'BTN_FTTB.Location = New Point(200 + 60 * 9, 0)
            'BTN_FTTB.Size = New Size(50, 50)
            'BTN_FTTB.Text = ""
            'BTN_FTTB.BringToFront()

            BTN_Usuario.Parent = PanelSuperior
            BTN_Usuario.BackgroundImage = My.Resources.UserBlack
            BTN_Usuario.Size = New Size(15, 15)
            BTN_Usuario.Location = New Point(PanelSuperior.Width - BTN_Usuario.Width + 670, PanelSuperior.Height - BTN_Usuario.Height - 10)
            BTN_Usuario.BringToFront()

            BTN_BOT.Parent = PanelSuperior
            BTN_BOT.BackgroundImage = My.Resources.bot
            BTN_BOT.Size = New Size(15, 15)
            BTN_BOT.Location = New Point(PanelSuperior.Width - BTN_BOT.Width + 650, PanelSuperior.Height - BTN_BOT.Height - 10)
            BTN_BOT.BringToFront()

            PIC_CLIMA.Visible = True
            PIC_CLIMA.Parent = PanelSuperior
            PIC_CLIMA.Location = New Point(1003, 2)
            PIC_CLIMA.Size = New Size(25, 25)
            PIC_CLIMA.BackgroundImageLayout = ImageLayout.Zoom
            PIC_CLIMA.BringToFront()

            HoraAhora.ForeColor = Color.Black
            'FechaAhora.Parent = PanelSuperior
            FechaAhora.ForeColor = Color.Black
            'FechaAhora.Location = New Point(PanelSuperior.Width + 500, PanelSuperior.Height - 14)
            'FechaAhora.BringToFront()
            'HoraAhora.Visible = True
            'HoraAhora.Font = New Font("Calibri", 22, FontStyle.Bold)
            'HoraAhora.Size = New Size(100, 30)
            'HoraAhora.Location = New Point(PanelSuperior.Width + 500, PanelSuperior.Height - 12)
            'LBL_TEMP.TextAlign = ContentAlignment.MiddleLeft
            'LBL_TEMP.ForeColor = Color.Red
            'FechaAhora.Visible = True
            'LBL_TEMP.Text = "esto es el texto temp"
            'LBL_TEMP.Parent = PanelSuperior
            'LBL_TEMP.Location = New Point(PanelSuperior.Width + 500, PanelSuperior.Height - 17)
            'LBL_TEMP.BringToFront()
            'HoraAhora.BringToFront()

            BTN1Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN1Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN1Close.BackColor = Color.White
            BTN1Close.BackgroundImage = My.Resources.BTNCancelar
            BTN2Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN2Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN2Close.BackColor = Color.White
            BTN2Close.BackgroundImage = My.Resources.BTNCancelar
            BTN3Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN3Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN3Close.BackColor = Color.White
            BTN3Close.BackgroundImage = My.Resources.BTNCancelar
            BTN4Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN4Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN4Close.BackColor = Color.White
            BTN4Close.BackgroundImage = My.Resources.BTNCancelar
            BTN5Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN5Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN5Close.BackColor = Color.White
            BTN5Close.BackgroundImage = My.Resources.BTNCancelar
            BTN6Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN6Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN6Close.BackColor = Color.White
            BTN6Close.BackgroundImage = My.Resources.BTNCancelar
            BTN7Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN7Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN7Close.BackColor = Color.White
            BTN7Close.BackgroundImage = My.Resources.BTNCancelar

            BTN_HAND.BackgroundImage = My.Resources.tap
            BTN_HAND.FlatAppearance.MouseOverBackColor = Color.White
            BTN_HAND.FlatAppearance.MouseDownBackColor = Color.Gray

            BTN8Close.FlatAppearance.MouseDownBackColor = Color.White
            BTN8Close.FlatAppearance.MouseOverBackColor = Color.White
            BTN8Close.BackColor = Color.White
            BTN8Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    Private Sub INICIO_DASH()
        HoraAhora.Text = Date.Now.ToString("HH:mm")
        FechaAhora.Text = Date.Now.ToString("dd/MM/yy")
        RELOJ.Enabled = True

        PanelInferior.Visible = False
        PanelSUPInterior.Visible = False

        BtnFull.BackgroundImage = My.Resources.restore_W

        HoraAhora.Visible = True
        FechaAhora.Visible = True
        LBL_TEMP.Visible = True

        Refresh()
        Login.Show(Me)
        Login.BtnIngresar.Focus()
    End Sub
    '---------------------------------------------------------INICIO DE ESTILO y COMPORTAMIENTO DE BOTONES----------------------------------------------------------------------------------------------------------------------------
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub
    Private Sub BtnPropiedades_Click(sender As Object, e As EventArgs) Handles BtnPropiedades.Click
        If FORMORDENES.Visible = False Then
            FORMORDENES.TopLevel = False
            FORMORDENES.Parent = PanelTrabajo
            FORMORDENES.Dock = DockStyle.Fill
            FORMORDENES.Show()
            FORMORDENES.BringToFront()
        Else
            FORMORDENES.Close()
        End If
    End Sub
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnFull_Click(sender As Object, e As EventArgs) Handles BtnFull.Click
        USUARIOSTableAdapter.FillByID(OPERACIONES_LOGDataSet.USUARIOS, ID)
        PANTALLA_PRIMARIA = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA")
        PANTALLA_NEGATIVA = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_NEGATIVA")
        If Me.Size.Width = ANCHOP Then
            Size = New Size(1000, 600)
            HoraAhora.Visible = False
            FechaAhora.Visible = False
            PanelSuperior.BackgroundImage = Nothing
            LBL_TEMP.Visible = False
            PIC_CLIMA.Visible = False
            BTN_HAND.Visible = True
            PanelSUPInterior.Width = 700
            If PANTALLA_PRIMARIA = False Then
                If PANTALLA_NEGATIVA Then
                    Location = New Point(((ANCHOP - 1000) / 2) - 1366, (ALTOP - 600) / 2)
                Else
                    Location = New Point(((ANCHOP - 1000) / 2) + 1366, (ALTOP - 600) / 2)
                End If
            Else
                Location = New Point((ANCHOP - 1000) / 2, (ALTOP - 600) / 2)
            End If
            If THEME_BLACK Then BtnFull.BackgroundImage = My.Resources.PantallaCompleta_W Else BtnFull.BackgroundImage = My.Resources.PantallaCompleta
        Else
            Size = New Size(ANCHOP, ALTOP)
            PanelSuperior.BackgroundImage = My.Resources.BANNER_SUPERIOR
            LBL_TEMP.Visible = True
            PIC_CLIMA.Visible = True
            BTN_HAND.Visible = False
            If PANTALLA_PRIMARIA = False Then
                If PANTALLA_NEGATIVA Then
                    Location = New Point(-1366, 0)
                Else
                    Location = New Point(1366, 0)
                End If
            Else
                Me.Location = Screen.PrimaryScreen.WorkingArea.Location
            End If
            HoraAhora.Visible = True
            FechaAhora.Visible = True
            If THEME_BLACK Then BtnFull.BackgroundImage = My.Resources.restore_W Else BtnFull.BackgroundImage = My.Resources.restore
        End If
    End Sub
    ''ASIGNADOS
    Private Sub BTNAsignado_Click(sender As Object, e As EventArgs) Handles BTNAsignado.Click
        If MIS_GESTIONES.Visible = False Then
            If THEME_BLACK Then BTNAsignado.BackgroundImage = My.Resources.BTNAsignadoClick Else BTNAsignado.BackgroundImage = My.Resources.ASIGNADO_ACTIVO
            BTNAsignado.Refresh()
            BTNCerrarAsignado.Visible = True
            BTNCerrarAsignado.BringToFront()
            BTNCerrarAsignado.Refresh()
            MIS_GESTIONES.TopLevel = False
            MIS_GESTIONES.Parent = PanelTrabajo
            MIS_GESTIONES.Dock = DockStyle.Fill
            MIS_GESTIONES.Show()
            MIS_GESTIONES.BringToFront()

        Else
            MIS_GESTIONES.BringToFront()
            If DATOS.Visible = True And ACCESO_DESDE = "MISGESTIONES" Then DATOS.BringToFront()
        End If
    End Sub
    Private Sub BTNAsignado_MouseHover(sender As Object, e As EventArgs) Handles BTNAsignado.MouseHover
        If MIS_GESTIONES.Visible = False Then
            If THEME_BLACK Then
                BTNAsignado.BackgroundImage = My.Resources.BTNAsignadoOver
            Else
                BTNAsignado.BackgroundImage = My.Resources.ASIGNADO_HOVER
            End If
        End If
    End Sub
    Private Sub BTNAsignado_MouseLeave(sender As Object, e As EventArgs) Handles BTNAsignado.MouseLeave
        If MIS_GESTIONES.Visible = False Then
            If THEME_BLACK Then
                BTNAsignado.BackgroundImage = My.Resources.BTNAsignado
            Else
                BTNAsignado.BackgroundImage = My.Resources.ASIGNADO
            End If
        End If
    End Sub
    Private Sub BTNCerrarAsignado_Click(sender As Object, e As EventArgs) Handles BTNCerrarAsignado.Click
        If MIS_GESTIONES.Visible Then
            MIS_GESTIONES.Close()
            BTNCerrarAsignado.Visible = False
            If THEME_BLACK = False Then BTNAsignado.BackgroundImage = My.Resources.ASIGNADO
            If DATOS.Visible = True And ACCESO_DESDE = "MISGESTIONES" Then DATOS.Close()
        End If
    End Sub
    Private Sub BTNCerrarAsignado_MouseHover(sender As Object, e As EventArgs) Handles BTNCerrarAsignado.MouseHover
        BTNCerrarAsignado.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTNCerrarAsignado_MouseLeave(sender As Object, e As EventArgs) Handles BTNCerrarAsignado.MouseLeave
        If THEME_BLACK Then
            BTNCerrarAsignado.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTNCerrarAsignado.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'MENSAJERIA
    Private Sub BTNMensajeria_Click(sender As Object, e As EventArgs) Handles BTNMensajeria.Click
        If MENSAJERIA.Visible = False Then
            Me.Cursor = Cursors.WaitCursor
            If THEME_BLACK Then BTNMensajeria.BackgroundImage = My.Resources.BTNMensajesClick Else BTNMensajeria.BackgroundImage = My.Resources.MENSAJES_ACTIVO
            BTNMensajeria.Refresh()
            BTNCerrarMensajes.Visible = True
            BTNCerrarMensajes.Refresh()
            'INCRUSTACION EN PANEL DE TRABAJO
            MENSAJERIA.TopLevel = False
            MENSAJERIA.Parent = PanelTrabajo
            MENSAJERIA.Dock = DockStyle.Fill
            'ABRE FORMULARIO Y LLEVA AL FRENTE
            MENSAJERIA.Show()
            MENSAJERIA.BringToFront()
            'HABILITA BOTON CORRESPONDIENTE

        Else
            MENSAJERIA.BringToFront()
        End If
    End Sub
    Private Sub BTNMensajeria_MouseLeave(sender As Object, e As EventArgs) Handles BTNMensajeria.MouseLeave
        If MENSAJERIA.Visible = False Then
            If THEME_BLACK Then
                BTNMensajeria.BackgroundImage = My.Resources.correo_electronico_vacio
            Else
                BTNMensajeria.BackgroundImage = My.Resources.MENSAJES
            End If
        End If
    End Sub
    Private Sub BTNMensajeria_MouseHover(sender As Object, e As EventArgs) Handles BTNMensajeria.MouseHover
        If MENSAJERIA.Visible = False Then
            If THEME_BLACK Then
                BTNMensajeria.BackgroundImage = My.Resources.BTNMensajesOVER
            Else
                BTNMensajeria.BackgroundImage = My.Resources.MENSAJES_HOVER
            End If
        End If
    End Sub
    Private Sub BTNCerrarMensajes_Click(sender As Object, e As EventArgs) Handles BTNCerrarMensajes.Click
        If MENSAJERIA.Visible Then
            MENSAJERIA.Close()
            BTNCerrarMensajes.Visible = False
            If THEME_BLACK = False Then BTNMensajeria.BackgroundImage = My.Resources.MENSAJES
        End If
    End Sub
    Private Sub BTNCerrarMensajes_MouseHover(sender As Object, e As EventArgs) Handles BTNCerrarMensajes.MouseHover
        BTNCerrarMensajes.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTNCerrarMensajes_MouseLeave(sender As Object, e As EventArgs) Handles BTNCerrarMensajes.MouseLeave
        If THEME_BLACK Then
            BTNCerrarMensajes.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTNCerrarMensajes.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTONES SUPERIORES
    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        BTN1var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN1.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select

    End Sub
    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        BTN2var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN2.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        BTN3var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN3.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        BTN4var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN4.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN5_Click(sender As Object, e As EventArgs) Handles BTN5.Click
        BTN5var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN5.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN6_Click(sender As Object, e As EventArgs) Handles BTN6.Click
        BTN6var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN6.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN7_Click(sender As Object, e As EventArgs) Handles BTN7.Click
        BTN7var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        BTN8.BackgroundImage = My.Resources.BTNSuperior
        Select Case BTN7.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    Private Sub BTN8_Click(sender As Object, e As EventArgs) Handles BTN8.Click
        BTN8var.BringToFront()
        BTN1.BackgroundImage = My.Resources.BTNSuperior
        BTN2.BackgroundImage = My.Resources.BTNSuperior
        BTN3.BackgroundImage = My.Resources.BTNSuperior
        BTN4.BackgroundImage = My.Resources.BTNSuperior
        BTN5.BackgroundImage = My.Resources.BTNSuperior
        BTN6.BackgroundImage = My.Resources.BTNSuperior
        BTN7.BackgroundImage = My.Resources.BTNSuperior
        BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
        Select Case BTN8.Text
            Case "AGENDA"
                'AGENDA.RENUEVA_ETIQUETAS()
                'AGENDA.DIBUJA_BARRAS()
                'AGENDA.DIBUJA_GRILLAS()
            Case "MDU"
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then
                    DATOS.BringToFront()
                End If
            Case "FUENTES"
                If DATOS.Visible = True And INGRESO_AREA = "FUENTES" Then
                    DATOS.BringToFront()
                End If
            Case "BUSCADOR"
                If DATOS.Visible = True And ACCESO_DESDE = "BUSCADOR" Then
                    DATOS.BringToFront()
                End If
        End Select
    End Sub
    'BOTONES INFERIORES DEL SISTEMA
    Private Sub BTN_Usuario_Click(sender As Object, e As EventArgs) Handles BTN_Usuario.Click
        If USUARIO.Visible = False Then
            USUARIO.Show(Me)
        Else
            USUARIO.Close()
        End If
    End Sub
    Private Sub BTN_Usuario_MouseHover(sender As Object, e As EventArgs) Handles BTN_Usuario.MouseHover
        BTN_Usuario.BackgroundImage = My.Resources.UserOver
    End Sub
    Private Sub BTN_Usuario_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Usuario.MouseLeave
        BTN_Usuario.BackgroundImage = My.Resources.UserBlack
    End Sub
    Private Sub BtnPropiedades_Mousehover(sender As Object, e As EventArgs) Handles BtnPropiedades.MouseHover
        BtnPropiedades.BackgroundImage = My.Resources.SettingOver
    End Sub
    Private Sub BtnPropiedades_MouseLeave(sender As Object, e As EventArgs) Handles BtnPropiedades.MouseLeave
        BtnPropiedades.BackgroundImage = My.Resources.SettingBlack
    End Sub
    'BOTON PROCESOS
    Private Sub BTN_Proceso_Click(sender As Object, e As EventArgs) Handles BTN_Proceso.Click
        If PROCESOS.Visible = False Then
            If THEME_BLACK Then
                BTN_Proceso.BackgroundImage = My.Resources.ProcesosOver
            Else
                BTN_Proceso.BackgroundImage = My.Resources.PROCESOS_ACTIVO
                BTN_Proceso.Refresh()
                BTN7Close.Visible = True
                BTN7Close.Location = New Point(BTN_Proceso.Location.X + 50, 1)
                BTN7Close.Refresh()
            End If
            'INCUSTACION EN PANEL DE TRABAJO
            PROCESOS.TopLevel = False
            PROCESOS.Parent = PanelTrabajo
            PROCESOS.Dock = DockStyle.Fill
            'ABRE FORMULARIO Y LLEVA AL FRENTE
            PROCESOS.Show()
            PROCESOS.BringToFront()
        Else
            If THEME_BLACK Then PROCESOS.Close() Else PROCESOS.BringToFront()
        End If
    End Sub
    Private Sub BTN_Proceso_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Proceso.MouseLeave
        If PROCESOS.Visible = False Then
            If THEME_BLACK Then
                BTN_Proceso.BackgroundImage = My.Resources.ProocesosBlack
            Else
                BTN_Proceso.BackgroundImage = My.Resources.PROCESOS
            End If
        End If
    End Sub
    Private Sub BTN_Proceso_MouseHover(sender As Object, e As EventArgs) Handles BTN_Proceso.MouseHover
        If PROCESOS.Visible = False Then
            If THEME_BLACK Then
                BTN_Proceso.BackgroundImage = My.Resources.ProcesosOver
            Else
                BTN_Proceso.BackgroundImage = My.Resources.PROCESOS_HOVER
            End If
        End If
    End Sub
    'BOTON DIRECTORIO
    'Private Sub BTN_Directorio_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Directorio.MouseLeave
    '    BTN_Directorio.BackgroundImage = My.Resources.BookAdressBlack
    'End Sub
    'Private Sub BTN_Directorio_MouseHover(sender As Object, e As EventArgs) Handles BTN_Directorio.MouseHover
    '    BTN_Directorio.BackgroundImage = My.Resources.BookAdressOver
    'End Sub
    'BOTON ADMINISTRACION
    Private Sub BTN_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_ADMIN.Click
        If THEME_BLACK Then
            BTN_ADMIN.BackgroundImage = My.Resources.BTNClick
            BotonesInferiores("AdminTEC", ORDINALES)
        Else
            If ORDINALES.Visible Then
                ORDINALES.BringToFront()
            Else
                BTN_ADMIN.BackgroundImage = My.Resources.AD_TEC_ACTIVO
                BTN_ADMIN.Refresh()
                BTN1Close.Visible = True
                BTN1Close.Location = New Point(BTN_ADMIN.Location.X + BTN_ADMIN.Size.Width, BTN_ADMIN.Location.Y)
                BTN1Close.BringToFront()
                BTN1Close.Refresh()
                ORDINALES.TopLevel = False
                ORDINALES.Parent = PanelTrabajo
                ORDINALES.Dock = DockStyle.Fill
                ORDINALES.Show()
                ORDINALES.BringToFront()
            End If
        End If
    End Sub
    Private Sub BTN_ADMIN_MouseHover(sender As Object, e As EventArgs) Handles BTN_ADMIN.MouseHover
        If ORDINALES.Visible = False Then
            If THEME_BLACK Then
                BTN_ADMIN.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_ADMIN.BackgroundImage = My.Resources.AD_TEC_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_ADMIN_MouseLeave(sender As Object, e As EventArgs) Handles BTN_ADMIN.MouseLeave
        If ORDINALES.Visible = False Then
            If THEME_BLACK Then
                BTN_ADMIN.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_ADMIN.BackgroundImage = My.Resources.AD_TEC
            End If
        End If
    End Sub
    'BOTON GESTION MDU
    Private Sub BTN_MDU_Click(sender As Object, e As EventArgs) Handles BTN_MDU.Click
        If THEME_BLACK Then
            BotonesInferiores("MDU", INGRESO_MDU)
            BTN_MDU.BackgroundImage = My.Resources.BTNClick
        Else
            If INGRESO_MDU.Visible Then
                INGRESO_MDU.BringToFront()
                Select Case INGRESO_AREA
                    Case "MDU"
                        If DATOS.Visible = True Then
                            DATOS.BringToFront()
                        End If
                End Select
                Select Case ACCESO_DESDE
                    Case "MDU"
                        If DATOS.Visible = True Then
                            DATOS.BringToFront()
                        End If
                End Select
            Else
                BTN_MDU.BackgroundImage = My.Resources.EDIFICIO_ACTIVO
                BTN_MDU.Refresh()
                BTN6Close.Visible = True
                BTN6Close.Location = New Point(BTN_MDU.Location.X + 50, 1)
                BTN6Close.BringToFront()
                BTN6Close.Refresh()
                INGRESO_MDU.TopLevel = False
                INGRESO_MDU.Parent = PanelTrabajo
                INGRESO_MDU.Dock = DockStyle.Fill
                INGRESO_MDU.Show()
                INGRESO_MDU.BringToFront()
            End If
        End If
    End Sub
    Private Sub BTN_MDU_MouseHover(sender As Object, e As EventArgs) Handles BTN_MDU.MouseHover
        If INGRESO_MDU.Visible = False Then
            If THEME_BLACK Then
                BTN_MDU.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_MDU.BackgroundImage = My.Resources.EDIFICIO_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_MDU_MouseLeave(sender As Object, e As EventArgs) Handles BTN_MDU.MouseLeave
        If INGRESO_MDU.Visible = False Then
            If THEME_BLACK Then
                BTN_MDU.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_MDU.BackgroundImage = My.Resources.EDIFICIO
            End If
        End If
    End Sub
    'BOTON GESTION RED
    Public Sub BTN_RED_Click(sender As Object, e As EventArgs) Handles BTN_RED.Click
        Select Case INGRESO_AREA
            Case "MDU", "FUENTES"
                If DATOS.Visible = True Then
                    DATOS.Close()
                End If
        End Select
        Select Case ACCESO_DESDE
            Case "BUSCAR", "MISGESTIONES", "MDU"
                If DATOS.Visible = True Then
                    DATOS.Close()
                End If
        End Select

        ACCESO_DESDE = "RED"
        INGRESO_AREA = "RED"


        If THEME_BLACK Then
            BotonesInferiores("RED", DATOS)
            BTN_RED.BackgroundImage = My.Resources.BTNClick
        Else
            If DATOS.Visible Then
                DATOS.BringToFront()
            Else
                BTN_RED.BackgroundImage = My.Resources.RED_ACTIVO
                BTN_RED.Refresh()
                BTN4Close.Visible = True
                BTN4Close.Location = New Point(BTN_RED.Location.X + 50, 1)
                BTN4Close.BringToFront()
                BTN4Close.Refresh()

                DATOS.TopLevel = False
                DATOS.Parent = PanelTrabajo
                DATOS.Dock = DockStyle.Fill
                DATOS.Show()
                DATOS.BringToFront()

            End If
        End If
    End Sub
    Private Sub BTN_RED_MouseHover(sender As Object, e As EventArgs) Handles BTN_RED.MouseHover
        If DATOS.Visible = False Then
            If THEME_BLACK Then
                BTN_RED.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_RED.BackgroundImage = My.Resources.RED_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_RED_MouseLeave(sender As Object, e As EventArgs) Handles BTN_RED.MouseLeave
        If DATOS.Visible = False Then
            If THEME_BLACK Then
                BTN_RED.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_RED.BackgroundImage = My.Resources.RED
            End If
        End If
    End Sub
    'BOTON BUSCADOR
    Private Sub BTN_BUSCADOR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCADOR.Click
        If THEME_BLACK Then
            BotonesInferiores("BUSCADOR", BUSQUEDA)
            BTN_BUSCADOR.BackgroundImage = My.Resources.BTNClick
        Else
            If BUSQUEDA.Visible Then
                BUSQUEDA.BringToFront()
                Select Case ACCESO_DESDE
                    Case "BUSCADOR"
                        If DATOS.Visible = True Then
                            DATOS.BringToFront()
                        End If
                End Select
            Else
                BTN_BUSCADOR.BackgroundImage = My.Resources.BUSQUEDA_ACTIVO
                BTN_BUSCADOR.Refresh()
                BTN5Close.Visible = True
                BTN5Close.Location = New Point(BTN_BUSCADOR.Location.X + 50, 1)
                BTN5Close.BringToFront()
                BTN5Close.Refresh()

                BUSQUEDA.TopLevel = False
                BUSQUEDA.Parent = PanelTrabajo
                BUSQUEDA.Dock = DockStyle.Fill
                BUSQUEDA.Show()
                BUSQUEDA.BringToFront()

            End If
        End If
    End Sub
    Private Sub BTN_BUSCADOR_MouseHover(sender As Object, e As EventArgs) Handles BTN_BUSCADOR.MouseHover
        If BUSQUEDA.Visible = False Then
            If THEME_BLACK Then
                BTN_BUSCADOR.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_BUSCADOR.BackgroundImage = My.Resources.BUSQUEDA_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_BUSCADOR_MouseLeave(sender As Object, e As EventArgs) Handles BTN_BUSCADOR.MouseLeave
        If BUSQUEDA.Visible = False Then
            If THEME_BLACK Then
                BTN_BUSCADOR.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_BUSCADOR.BackgroundImage = My.Resources.BUSQUEDA
            End If
        End If
    End Sub
    'BOTON DESPACHO
    Private Sub BTN_DESPACHO_Click(sender As Object, e As EventArgs) Handles BTN_DESPACHO.Click
        If File.Exists("C:\DOCUMENTOS\USUARIO\APLICACION\AGENDA\ANALISISAGENDA.EXE") Then
            MsgBox("SALDRA A UNA APLICACION EXTERNA")
            Shell("C:\DOCUMENTOS\USUARIO\APLICACION\AGENDA\ANALISISAGENDA.EXE")
        Else
            MsgBox("OOPS! solicite ayuda tecnica")
        End If
    End Sub
    Private Sub BTN_DESPACHO_MouseHover(sender As Object, e As EventArgs) Handles BTN_DESPACHO.MouseHover
        If THEME_BLACK Then
            BTN_DESPACHO.BackgroundImage = My.Resources.BTNOver
        Else
            BTN_DESPACHO.BackgroundImage = My.Resources.DESPACHO_HOVER
        End If
    End Sub
    Private Sub BTN_DESPACHO_MouseLeave(sender As Object, e As EventArgs) Handles BTN_DESPACHO.MouseLeave
        If THEME_BLACK Then
            BTN_DESPACHO.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        Else
            BTN_DESPACHO.BackgroundImage = My.Resources.DESPACHO
        End If
    End Sub
    'BOTON GESTION FUENTES
    Private Sub BTN_FUENTES_Click(sender As Object, e As EventArgs) Handles BTN_FUENTES.Click
        If THEME_BLACK Then
            BotonesInferiores("FUENTES", FUENTES)
            BTN_FUENTES.BackgroundImage = My.Resources.BTNClick
        Else
            If FUENTES.Visible Then
                FUENTES.BringToFront()
                Select Case INGRESO_AREA
                    Case "FUENTES"
                        If DATOS.Visible = True Then
                            DATOS.BringToFront()
                        End If
                End Select
            Else
                BTN_FUENTES.BackgroundImage = My.Resources.FUENTE_ACTIVO
                BTN_FUENTES.Refresh()
                BTN2Close.Visible = True
                BTN2Close.Location = New Point(BTN_FUENTES.Location.X + BTN_FUENTES.Size.Width, BTN_FUENTES.Location.Y)
                BTN2Close.BringToFront()
                BTN2Close.Refresh()

                FUENTES.TopLevel = False
                FUENTES.Parent = PanelTrabajo
                FUENTES.Dock = DockStyle.Fill
                FUENTES.Show()
                FUENTES.BringToFront()

            End If
        End If
    End Sub
    Private Sub BTN_FUENTES_MouseHover(sender As Object, e As EventArgs) Handles BTN_FUENTES.MouseHover
        If FUENTES.Visible = False Then
            If THEME_BLACK Then
                BTN_FUENTES.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_FUENTES.BackgroundImage = My.Resources.FUENTE_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_FUENTES_MouseLeave(sender As Object, e As EventArgs) Handles BTN_FUENTES.MouseLeave
        If FUENTES.Visible = False Then
            If THEME_BLACK Then
                BTN_FUENTES.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_FUENTES.BackgroundImage = My.Resources.FUENTE
            End If
        End If
    End Sub
    'BOTON FIBRA
    Private Sub BTN_FIBRA_Click(sender As Object, e As EventArgs) Handles BTN_FTTB.Click
        'BotonesInferiores("FIBRA", Fibra)
        'If File.Exists("G:\OPERACIONES\PROGRAMAS\FIBRA\" & VERSION & "\REDFIBRAMONTEVIDEO.exe") Then
        '    MsgBox("SALDRA A UNA APLICACION EXTERNA")
        '    Shell("G:\OPERACIONES\PROGRAMAS\FIBRA\" & VERSION & "\REDFIBRAMONTEVIDEO.exe")
        'Else
        '    MsgBox("OOOPS! Solicite ayuda tecnica")
        'End If
        If INICIO.Visible Then INICIO.Close()
        INICIO.Show()
        If THEME_BLACK Then
            BTN_FTTB.BackgroundImage = My.Resources.BTNClick
        End If


    End Sub
    Private Sub BTN_FIBRA_MouseHover(sender As Object, e As EventArgs) Handles BTN_FTTB.MouseHover
        If THEME_BLACK Then
            BTN_FTTB.BackgroundImage = My.Resources.BTNOver
        Else
            BTN_FTTB.BackgroundImage = My.Resources.FIBRA_HOVER
        End If
    End Sub
    Private Sub BTN_FIBRA_MouseLeave(sender As Object, e As EventArgs) Handles BTN_FTTB.MouseLeave
        If THEME_BLACK Then
            BTN_FTTB.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        Else
            BTN_FTTB.BackgroundImage = My.Resources.FIBRA
        End If
    End Sub
    'BOTON AGENDA
    Private Sub BTN_AGENDA_Click(sender As Object, e As EventArgs) Handles BTN_AGENDA.Click
        If FORMAGE.Visible = False Then
            ACCESO_AGENDA = "FORM_INICIO"
            If THEME_BLACK Then
                BotonesInferiores("AGENDA", FORMAGE)
                BTN_AGENDA.BackgroundImage = My.Resources.BTNClick

            Else
                ACCESO_AGENDA = "FORM_INICIO"
                BTN_AGENDA.BackgroundImage = My.Resources.AGENDA_ACTIVO
                BTN_AGENDA.Refresh()
                BTN3Close.Visible = True

                BTN3Close.BringToFront()
                BTN3Close.Refresh()
            End If
            FORMAGE.TopLevel = False
            FORMAGE.Parent = PanelTrabajo
            FORMAGE.Dock = DockStyle.Fill
            FORMAGE.Show()
            FORMAGE.BringToFront()
        Else

            'FORMAGE.BringToFront()
            'FORMAGE.DIBUJA_BARRAS()
            'AGENDA.DIBUJA_GRILLAS()
            FORMAGE.BringToFront()
        End If
    End Sub
    Private Sub BTN_AGENDA_MouseHover(sender As Object, e As EventArgs) Handles BTN_AGENDA.MouseHover
        If FORMAGE.Visible = False Then
            If THEME_BLACK Then
                BTN_AGENDA.BackgroundImage = My.Resources.BTNOver
            Else
                BTN_AGENDA.BackgroundImage = My.Resources.AGENDA_HOVER
            End If
        End If
    End Sub
    Private Sub BTN_AGENDA_MouseLeave(sender As Object, e As EventArgs) Handles BTN_AGENDA.MouseLeave
        If FORMAGE.Visible = False Then
            If THEME_BLACK Then
                BTN_AGENDA.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
            Else
                BTN_AGENDA.BackgroundImage = My.Resources.AGENDA
            End If
        End If
    End Sub
    'BOTON CERRAR 1 -ADMINTEC
    Private Sub BTN1Close_Click(sender As Object, e As EventArgs) Handles BTN1Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(1)
        Else
            If ORDINALES.Visible Then
                ORDINALES.Close()
                BTN1Close.Visible = False
                BTN_ADMIN.BackgroundImage = My.Resources.AD_TEC
            End If
        End If
    End Sub
    Private Sub BTN1Close_MouseHover(sender As Object, e As EventArgs) Handles BTN1Close.MouseHover
        BTN1Close.BackgroundImage = My.Resources.BTNCancelarOver
        'BTN1Close.BackColor = Color.Black
    End Sub
    Private Sub BTN1Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN1Close.MouseLeave
        If THEME_BLACK Then
            BTN1Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN1Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 2 - FUENTES
    Private Sub BTN2Close_Click(sender As Object, e As EventArgs) Handles BTN2Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(2)
        Else
            If FUENTES.Visible Then
                FUENTES.Close()
                BTN2Close.Visible = False
                BTN_FUENTES.BackgroundImage = My.Resources.FUENTE
            End If
        End If
    End Sub
    Private Sub BTN2Close_MouseHover(sender As Object, e As EventArgs) Handles BTN2Close.MouseHover
        BTN2Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN2Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN2Close.MouseLeave
        If THEME_BLACK Then
            BTN2Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN2Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 3 -AGENDA
    Private Sub BTN3Close_Click(sender As Object, e As EventArgs) Handles BTN3Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(3)
        Else
            FORMAGE.Close()
            BTN3Close.Visible = False
            BTN_AGENDA.BackgroundImage = My.Resources.AGENDA
        End If
    End Sub
    Private Sub BTN3Close_MouseHover(sender As Object, e As EventArgs) Handles BTN3Close.MouseHover
        BTN3Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN3Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN3Close.MouseLeave
        If THEME_BLACK Then
            BTN3Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN3Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 4 - RED
    Private Sub BTN4Close_Click(sender As Object, e As EventArgs) Handles BTN4Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(4)
        Else
            If DATOS.Visible Then
                DATOS.Close()
                BTN4Close.Visible = False
                BTN_RED.BackgroundImage = My.Resources.RED
            End If
        End If

    End Sub
    Private Sub BTN4Close_MouseHover(sender As Object, e As EventArgs) Handles BTN4Close.MouseHover
        BTN4Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN4Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN4Close.MouseLeave
        If THEME_BLACK Then
            BTN4Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN4Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 5 - BUSQUEDA
    Private Sub BTN5Close_Click(sender As Object, e As EventArgs) Handles BTN5Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(5)
        Else
            If BUSQUEDA.Visible Then
                BUSQUEDA.Close()
                BTN5Close.Visible = False
                BTN_BUSCADOR.BackgroundImage = My.Resources.BUSQUEDA
            End If
        End If
    End Sub
    Private Sub BTN5Close_MouseHover(sender As Object, e As EventArgs) Handles BTN5Close.MouseHover
        BTN5Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN5Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN5Close.MouseLeave
        If THEME_BLACK Then
            BTN5Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN5Close.BackgroundImage = My.Resources.BTNCancelar
        End If

    End Sub
    'BOTON CERRAR 6 - MDU
    Private Sub BTN6Close_Click(sender As Object, e As EventArgs) Handles BTN6Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(6)
        Else
            If INGRESO_MDU.Visible Then
                INGRESO_MDU.Close()
                If DATOS.Visible = True And INGRESO_AREA = "MDU" Then DATOS.Close()
                BTN6Close.Visible = False
                BTN_MDU.BackgroundImage = My.Resources.EDIFICIO
            End If
        End If
    End Sub
    Private Sub BTN6Close_MouseHover(sender As Object, e As EventArgs) Handles BTN6Close.MouseHover
        BTN6Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN6Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN6Close.MouseLeave
        If THEME_BLACK Then
            BTN6Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN6Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 7 - PROCESOS
    Private Sub BTN7Close_Click(sender As Object, e As EventArgs) Handles BTN7Close.Click
        If THEME_BLACK Then
            EstiloBTNCerrar(7)
        Else
            If PROCESOS.Visible Then
                PROCESOS.Close()
                BTN7Close.Visible = False
                BTN_Proceso.BackgroundImage = My.Resources.PROCESOS
            End If
        End If

    End Sub
    Private Sub BTN7Close_MouseHover(sender As Object, e As EventArgs) Handles BTN7Close.MouseHover
        BTN7Close.BackgroundImage = My.Resources.BTNCancelarOver
    End Sub
    Private Sub BTN7Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN7Close.MouseLeave
        If THEME_BLACK Then
            BTN7Close.BackgroundImage = My.Resources.BTNCancelarBlanco
        Else
            BTN7Close.BackgroundImage = My.Resources.BTNCancelar
        End If
    End Sub
    'BOTON CERRAR 8
    Private Sub BTN8Close_Click(sender As Object, e As EventArgs) Handles BTN8Close.Click
        EstiloBTNCerrar(8)
    End Sub
    Private Sub BTN8Close_MouseHover(sender As Object, e As EventArgs) Handles BTN8Close.MouseHover
        BTN8Close.BackgroundImage = My.Resources.BTNCancelarOver
        BTN8Close.BackColor = Color.Black
    End Sub
    Private Sub BTN8Close_MouseLeave(sender As Object, e As EventArgs) Handles BTN8Close.MouseLeave
        BTN8Close.BackgroundImage = My.Resources.BTNCancelarBlanco
    End Sub

    '--------------------------------------------------FIN DE ESTILO y COMPORTAMIENTO DE BOTONES----------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub INGRESO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Login.Visible = False Then
            Select Case e.KeyCode
                Case Keys.F1
                    If ABOUT.Visible = False Then
                        ABOUT.Show(Me)
                    Else
                        ABOUT.Close()
                    End If
                Case Keys.F2
                    If MIS_GESTIONES.Visible = False Then
                        BTNAsignado_Click(Nothing, Nothing)
                    End If
                Case Keys.F3
                    'If AGENDA.Visible = False Then
                    '    BTN_AGENDA_Click(Nothing, Nothing)
                    'End If
                Case Keys.F7
                    If INGRESO_MDU.Visible = False Then
                        BTN_MDU_Click(Nothing, Nothing)
                    End If
            End Select
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RELOJ.Tick
        HoraAhora.Text = Now.ToString("HH:mm")

        FechaAhora.Text = Date.Now.ToString("dd/MM/yy")
        TIEMPO += 1
        CUENTA_CLIMA += 1
        CUENTA_CLIMA_HORA += 1
        If CUENTA_CLIMA >= 60 Then
            CLIMATableAdapter.FillByCLIMA_INGRESO(INDICESDataSet.CLIMA, Today.ToShortDateString)
            CUENTA_CLIMA = 0

            If SECTOR = "PLANIFICACION TECNICA" Then
                If INDICESDataSet.CLIMA.Rows.Count > 0 Then
                    If DateDiff(DateInterval.Hour, CDate(INDICESDataSet.CLIMA.Rows(0).Item("HORA_INGRESO")), Now) >= 1 Then
                        OBTENER_CLIMA_HORA()
                        Threading.Thread.Sleep(5000)
                        Try
                            If CLIMA_DATOS_hora IsNot Nothing Then
                                INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_TEMPERATURA") = CLIMA_DATOS_hora
                                INDICESDataSet.CLIMA.Rows(0).Item("HORA_INGRESO") = Now
                                CLIMATableAdapter.Update(INDICESDataSet.CLIMA)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End If
            End If

            If INDICESDataSet.CLIMA.Rows.Count > 0 Then
                LBL_TEMP.Text = "TEMP: " & CInt(INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_TEMPERATURA")) & "°C"
            End If
        End If
        If TIEMPO >= 10 Then
            TIEMPO = 0
            MENSAJERIATableAdapter.FillByRECIBIDOSNOLEIDOS(ORDENESDataSet.MENSAJERIA, FULLNOMBRE, SECTOR)
            BTNMensajeria.Text = ORDENESDataSet.MENSAJERIA.Count
            ORDENESTableAdapter.FillByASIGNADOA(Me.ORDENESDataSet.ORDENES, FULLNOMBRE)
            TRABAJOSTableAdapter.FillByASIGNADOA(Me.ORDENESDataSet.TRABAJOS, FULLNOMBRE)
            GESTIONTableAdapter.FillByASIGNADOA(Me.ORDENESDataSet.GESTION, FULLNOMBRE)

            BTNAsignado.Text = ORDENESDataSet.ORDENES.Count + ORDENESDataSet.TRABAJOS.Count + ORDENESDataSet.GESTION.Count
            If BTN_MISGestiones.Visible = True Then
                MIS_GESTIONES.LBL_DESCRIPCION.Text = "MIS ASIGNADOS"
                GESTIONTableAdapter.FillByASIGNADOA(MIS_GESTIONES.ORDENESDataSet.GESTION, FULLNOMBRE)
                TRABAJOSTableAdapter.FillByASIGNADOA(MIS_GESTIONES.ORDENESDataSet.TRABAJOS, FULLNOMBRE)
                GESTIONTableAdapter.FillByASIGNADOA(MIS_GESTIONES.ORDENESDataSet.GESTION, FULLNOMBRE)
            End If
        End If
    End Sub

    Private Sub BTN_MISGestiones_Click(sender As Object, e As EventArgs)
        If MIS_GESTIONES.Visible = False Then
            If THEME_BLACK Then BTNAsignado.BackgroundImage = My.Resources.BTNAsignadoClick Else BTNAsignado.BackgroundImage = My.Resources.ASIGNADO_ACTIVO
            BTNCerrarAsignado.Visible = True
            MIS_GESTIONES.TopLevel = False
            MIS_GESTIONES.Parent = PanelTrabajo
            MIS_GESTIONES.Dock = DockStyle.Fill
            MIS_GESTIONES.Show()
            MIS_GESTIONES.BringToFront()
        Else
            MIS_GESTIONES.BringToFront()
        End If
    End Sub
    Private Sub MISTrabajos_Click(sender As Object, e As EventArgs) Handles MISTrabajos.Click
        If MIS_GESTIONES.Visible = False Then
            If THEME_BLACK Then BTNAsignado.BackgroundImage = My.Resources.BTNAsignadoClick Else BTNAsignado.BackgroundImage = My.Resources.ASIGNADO_ACTIVO
            BTNCerrarAsignado.Visible = True
            MIS_GESTIONES.TopLevel = False
            MIS_GESTIONES.Parent = PanelTrabajo
            MIS_GESTIONES.Dock = DockStyle.Fill
            MIS_GESTIONES.Show()
            MIS_GESTIONES.BringToFront()
        Else
            MIS_GESTIONES.BringToFront()
        End If
    End Sub
    Private Sub BTN_BOT_Click(sender As Object, e As EventArgs) Handles BTN_BOT.Click
        MsgBox("SALDRA A UNA APLICACION EXTERNA")
        If My.Computer.Info.OSFullName.Contains(10) Or My.Computer.Info.OSFullName.Contains(11) Then
            Try
                Dim ruta As String = "G:\OPERACIONES\PROGRAMAS\BOTServer\W10\" & VERSION & "\BOTSverver.exe"
                Shell(ruta)
            Catch ex As Exception
                MsgBox("OOOPS! Solicite ayuda tecnica, NO HAY CONECCION A ARCHIVO")
            End Try
        Else
            Try
                Shell("G:\OPERACIONES\PROGRAMAS\BOTServer\" & VERSION & "\BOTSverver.exe")
            Catch ex As Exception
                MsgBox("OOOPS! Solicite ayuda tecnica, NO HAY CONECCION A ARCHIVO")
            End Try
        End If
    End Sub
    Private Sub BTN_Directorio_Click(sender As Object, e As EventArgs) Handles BTN_Directorio.Click
        'ESCRITORIO.TopLevel = False
        'ESCRITORIO.Parent = PanelTrabajo
        'ESCRITORIO.Dock = DockStyle.Fill
        ''ABRE FORMULARIO Y LLEVA AL FRENTE
        'ESCRITORIO.Show()
        'ESCRITORIO.BringToFront()

    End Sub
    'Private Sub BTN_MAS_Click(sender As Object, e As EventArgs) Handles mas
    '    'If AGENDA.Visible = False Then
    '    '    BTN_MAS.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    '    '    MATERIALES.TopLevel = False
    '    '    MATERIALES.Parent = PanelTrabajo
    '    '    MATERIALES.Dock = DockStyle.Fill
    '    '    'ABRE FORMULARIO Y LLEVA AL FRENTE
    '    '    MATERIALES.Show()
    '    '    MATERIALES.BringToFront()
    '    'End If
    'End Sub
    Private Sub BTN_MAS_MouseHover(sender As Object, e As EventArgs) Handles BTN_BUSCADOR.Click
        If BTN_BUSCADOR.Visible = False Then
            BTN_BUSCADOR.BackgroundImage = My.Resources.BTNOver
        End If
    End Sub
    Private Sub BTN_MAS_MouseLeave(sender As Object, e As EventArgs) Handles BTN_BUSCADOR.MouseLeave
        If BTN_BUSCADOR.Visible = False Then
            BTN_BUSCADOR.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        End If
    End Sub
    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles BTN_HAND.MouseMove
        BTN_Directorio.Text = MousePosition.X & " - " & MousePosition.Y
        BTN_Directorio.Refresh()
        If arrastre And Size.Width <> ANCHOP Then
            Location = PointToScreen(New Point(MousePosition.X - BTN_HAND.Location.X - Location.X - ex, MousePosition.Y - Location.Y - BTN_HAND.Location.Y - ey))
        End If
        If MousePosition.X > 1366 Then
            MonitorPrimario = False
            MonitorNegativo = False
        ElseIf MousePosition.X < 0 Then
            MonitorPrimario = False
            MonitorNegativo = True
        Else
            MonitorPrimario = True
        End If
    End Sub
    Private Sub PanelSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles BTN_HAND.MouseUp
        arrastre = False
        USUARIOSTableAdapter.FillByID(OPERACIONES_LOGDataSet.USUARIOS, ID)
        PANTALLA_PRIMARIA = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA")
        PANTALLA_NEGATIVA = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA")
        If MonitorPrimario <> PANTALLA_PRIMARIA Then
            OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA") = MonitorPrimario
            PANTALLA_PRIMARIA = MonitorPrimario
            USUARIOSTableAdapter.Update(OPERACIONES_LOGDataSet.USUARIOS.Rows(0))
        End If
        If MonitorNegativo <> PANTALLA_NEGATIVA Then
            OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_NEGATIVA") = MonitorNegativo
            PANTALLA_NEGATIVA = MonitorNegativo
            USUARIOSTableAdapter.Update(OPERACIONES_LOGDataSet.USUARIOS.Rows(0))
        End If
        If MousePosition.Y = 0 Then
            arrastre = False
            If Me.Size.Width = ANCHOP Then
                Size = New Size(1000, 600)
                HoraAhora.Visible = False
                FechaAhora.Visible = False
                ' PanelSuperior.BackgroundImage = Nothing
                LBL_TEMP.Visible = False
                PIC_CLIMA.Visible = False
                BTN_HAND.Visible = True

                If PANTALLA_PRIMARIA = False Then
                    If PANTALLA_NEGATIVA Then
                        Location = New Point(((ANCHOP - 1000) / 2) - 1366, (ALTOP - 600) / 2)
                    Else
                        ANCHOP = Screen.AllScreens(1).WorkingArea.Width
                        ALTOP = Screen.AllScreens(1).WorkingArea.Height
                        Location = New Point(((ANCHOP - 1000) / 2) + 1366, (ALTOP - 600) / 2)
                    End If
                Else
                    Location = New Point((ANCHOP - 1000) / 2, (ALTOP - 600) / 2)
                End If
                If THEME_BLACK Then
                    BtnFull.BackgroundImage = My.Resources.PantallaCompleta_W
                Else
                    BtnFull.BackgroundImage = My.Resources.PantallaCompleta
                End If
            Else
                Me.Size = New Size(ANCHOP, ALTOP)
                'PanelSuperior.BackgroundImage = My.Resources.BANNER_SUPERIOR
                LBL_TEMP.Visible = True
                PIC_CLIMA.Visible = True
                BTN_HAND.Visible = False
                PanelSUPInterior.Width = 1004
                If PANTALLA_PRIMARIA = False Then
                    If PANTALLA_NEGATIVA Then
                        Location = New Point(Screen.AllScreens(0).WorkingArea.X, Screen.AllScreens(0).WorkingArea.Y)
                    Else
                        Location = New Point(Screen.AllScreens(0).WorkingArea.X + 1366, Screen.AllScreens(1).WorkingArea.Y)
                    End If
                Else
                    Location = Screen.PrimaryScreen.WorkingArea.Location
                End If
                HoraAhora.Visible = True
                FechaAhora.Visible = True
                If THEME_BLACK Then
                    BtnFull.BackgroundImage = My.Resources.restore_W
                Else
                    BtnFull.BackgroundImage = My.Resources.restore
                End If
            End If
        End If
    End Sub
    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles BTN_HAND.MouseDown
        ex = e.X
        ey = e.Y
        If MousePosition.Y = 0 Then
            arrastre = False
        Else
            arrastre = True
        End If
        BTN_Directorio.Text = e.X & " - " & e.Y
    End Sub

    Private Sub BTN_PASAR_Click(sender As Object, e As EventArgs) Handles BTN_PASAR.Click
        Cursor = Cursors.WaitCursor
        'Dim CONTADOR As Integer = 1
        'Dim REPARADOS As Integer = 0
        'ORDENESTableAdapter.FillBy(OrdenesDataSet1.ORDENES)
        'Dim TOTAL As Integer = OrdenesDataSet1.ORDENES.Rows.Count
        'For Each ORDEN In OrdenesDataSet1.ORDENES

        '    If ORDEN.IsSTATUSNull = False AndAlso ORDEN.IsMOTIVOCIERRENull = False Then
        '        If Trim(ORDEN.MOTIVOCIERRE) = "REALIZADO" And ORDEN.STATUS <> "ADUPLICAR" And ORDEN.STATUS <> "DUPLICADO" And ORDEN.STATUS <> "FINALIZADO" Then
        '            REPARADOS += 1
        '            lblcuentas.Text = "SE HAN REPARADO " & REPARADOS & " ORDENES"
        '            lblcuentas.Refresh()
        '            ORDEN.STATUS = "FINALIZADO"
        '            ORDENESTableAdapter.Update(ORDEN)
        '        End If
        '    End If
        '    Label2.Text = "CONTANDO " & CONTADOR & " De " & TOTAL
        '    Label2.Refresh()
        '    CONTADOR += 1
        'Next

        'TRABAJOSTableAdapter.Fill(ORDENESDataSet.TRABAJOS)
        'Dim CUENTA As Integer = 0
        'For Each TRABAJOS In ORDENESDataSet.TRABAJOS
        '    CUENTA += 1
        '    lblcuentas.Text = "CHEQUEANDO " & CUENTA & " DE " & ORDENESDataSet.TRABAJOS.Rows.Count
        '    lblcuentas.Refresh()
        '    If TRABAJOS.GENERADOX <> TRABAJOS.ASIGNADOA Then
        '        HISTORICOTableAdapter.FillByIDTRABAJO(ORDENESDataSet.HISTORICO, TRABAJOS.Id_TRABAJO)
        '    If ORDENESDataSet.HISTORICO.Rows.Count > 0 Then
        '        For Each HISTORICO In ORDENESDataSet.HISTORICO
        '                If HISTORICO.IsCAUSANull = False AndAlso HISTORICO.CAUSA = "ASIGNAR RESPONSABLE" Then
        '                    TRABAJOS.FECHA_ASIGNADO = HISTORICO.FECHA.ToShortDateString()
        '                End If
        '            Next

        '    End If
        '    End If


        'Next
        'TRABAJOSTableAdapter.Update(ORDENESDataSet.TRABAJOS)

        'FUENTETableAdapter.FillByFUENTES(BASEFUENTESDataSet.FUENTE)
        'Dim FUENTE As BASEFUENTESDataSet.FUENTERow
        'Dim ORDEN As ORDENESDataSet.ORDENESRow
        'Dim INSTALACION As BASEFUENTESDataSet.INSTALACIONRow
        'Dim afectacions As ORDENESDataSet.AFECTACIONRow
        'ORDENESTableAdapter.FillByINSTALACION(ORDENESDataSet.ORDENES, "0")
        'ORDENESTableAdapter.FillBySTS_FINALIZADO(ORDENESDataSet.ORDENES)
        'For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
        '    BTN_Directorio.Text = "UPDATEANDO ORDEN " & X + 1 & " DE " & ORDENESDataSet.ORDENES.Rows.Count
        '    BTN_Directorio.Refresh()
        '    ORDEN = ORDENESDataSet.ORDENES.Rows(X)
        '    If ORDEN.IsFECHAINICIONull Then
        '        If ORDEN.IsFECHAINGRESONull = False Then
        '            ORDEN.FECHAINICIO = ORDEN.FECHAINGRESO
        '        End If
        '    End If
        '    If ORDEN.IsFECHAFINNull Then
        '        If ORDEN.IsFECHAINGRESONull = False Then
        '            ORDEN.FECHAFIN = ORDEN.FECHAINGRESO
        '        End If
        '    End If
        '    ORDENESTableAdapter.Update(ORDEN)


        'Next
        ' ORDENESTableAdapter.Update(ORDENESDataSet.ORDENES)
        'For X = 0 To BASEFUENTESDataSet.FUENTE.Rows.Count - 1
        '    FUENTE = BASEFUENTESDataSet.FUENTE.Rows(X)
        '    BTN_Directorio.Text = "UPDATEANDO ORDEN DE FUENTE " & X + 1 & " DE " & BASEFUENTESDataSet.FUENTE.Rows.Count
        '    BTN_Directorio.Refresh()
        '    ORDENESTableAdapter.FillByINSTALACION(ORDENESDataSet.ORDENES, Trim(FUENTE.INSTALACION))
        '    If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
        '        For Y = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
        '            ORDEN = ORDENESDataSet.ORDENES.Rows(Y)
        '            ORDEN.INSTALACION = FUENTE.ID_FUENTE
        '            ORDEN.INSTALACIONRUS = FUENTE.INSTALACION_RUS
        '            ORDENESTableAdapter.Update(ORDEN)
        '        Next
        '    End If
        '    AFECTACIONTableAdapter.FillByINSTALACION(ORDENESDataSet.AFECTACION, FUENTE.INSTALACION)
        '    If ORDENESDataSet.AFECTACION.Rows.Count > 0 Then
        '        For a = 0 To ORDENESDataSet.AFECTACION.Rows.Count - 1
        '            afectacions = ORDENESDataSet.AFECTACION.Rows(a)
        '            If afectacions.INSTALACION.ToString <> FUENTE.ID_FUENTE.ToString Then
        '                afectacions.INSTALACION = FUENTE.ID_FUENTE
        '                AFECTACIONTableAdapter.Update(afectacions)
        '            End If
        '        Next

        '    End If
        'Next
        'If FUENTE.INSTALACION.ToString = "" Or FUENTE.INSTALACION.ToString = "0" Then
        '    MsgBox("LA FUENTE " & FUENTE.INSTALACION & " NO TIENE INSTALACION_RUS ASOCIADO")
        'Else
        'INSTALACIONTableAdapter.FillByCODIGO(BASEFUENTESDataSet.INSTALACION, FUENTE.INSTALACION)

        'For O = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 1
        '    INSTALACION = BASEFUENTESDataSet.INSTALACION.Rows(O)
        '    If INSTALACION.IsIDFUENTENull Then
        '        INSTALACION.IDFUENTE = FUENTE.ID_FUENTE
        '        INSTALACIONTableAdapter.Update(INSTALACION)
        '    Else
        '        If INSTALACION.IDFUENTE <> FUENTE.ID_FUENTE Then
        '            INSTALACION.IDFUENTE = FUENTE.ID_FUENTE
        '            INSTALACIONTableAdapter.Update(INSTALACION)
        '        End If
        '    End If
        '            ORDEN = ORDENESDataSet.ORDENES.Rows(O)
        '            If ORDEN.IsINSTALACIONNull Then
        '                ORDEN.INSTALACION = FUENTE.ID_FUENTE
        '                ORDENESTableAdapter.Update(ORDEN)
        '            Else
        '                If ORDEN.INSTALACION.ToString <> FUENTE.ID_FUENTE.ToString Then
        '                    ORDEN.INSTALACION = FUENTE.ID_FUENTE
        '                    ORDENESTableAdapter.Update(ORDEN)
        '                End If
        '    '            End If
        'Next
        '    End If
        '  Next




        'INSTALACIONTableAdapter.FillByACTUAL_TODAS(BASEFUENTESDataSet.INSTALACION)
        'Dim NEWFUENTE As BASEFUENTESDataSet.FUENTERow
        'Dim FUENTE As BASEFUENTESDataSet.INSTALACIONRow
        'For X = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 1
        '    FUENTE = BASEFUENTESDataSet.INSTALACION.Rows(X)
        '    NEWFUENTE = BASEFUENTESDataSet.FUENTE.NewFUENTERow()

        '    If FUENTE.IsFECHA_HISTNull = False Then NEWFUENTE.FECHA = FUENTE.FECHA_HIST
        '    NEWFUENTE.NODO = FUENTE.NODO
        '    NEWFUENTE.ZONA = FUENTE.ZONA
        '    NEWFUENTE.CALLE = FUENTE.CALLE
        '    If FUENTE.IsNRONull = False Then NEWFUENTE.PUERTA = FUENTE.NRO Else NEWFUENTE.PUERTA = "S/D"
        '    If FUENTE.IsESQUINANull = False Then NEWFUENTE.ESQUINA = FUENTE.ESQUINA Else NEWFUENTE.ESQUINA = "S/D"
        '    NEWFUENTE.MODFUENTE = FUENTE.MODFUENTE
        '    If FUENTE.IsMODGABINETENull = False Then NEWFUENTE.GABINETE = FUENTE.MODGABINETE
        '    If FUENTE.IsMODBATERIANull = False Then NEWFUENTE.MODBATERIA = FUENTE.MODBATERIA
        '    If FUENTE.IsCANTBATERIANull = False Then NEWFUENTE.CANT_BAT = FUENTE.CANTBATERIA
        '    If FUENTE.IsFECHAFAB_BATNull = False Then NEWFUENTE.FECHA_BAT = FUENTE.FECHAFAB_BAT
        '    If FUENTE.IsRXNull = False Then NEWFUENTE.RX = FUENTE.RX Else NEWFUENTE.RX = 0
        '    If FUENTE.IsBRNull = False Then NEWFUENTE.BR = FUENTE.BR Else NEWFUENTE.BR = 0
        '    If FUENTE.IsTRNull = False Then NEWFUENTE.TR = FUENTE.TR Else NEWFUENTE.TR = 0
        '    If FUENTE.IsLENull = False Then NEWFUENTE.LEX = FUENTE.LE Else NEWFUENTE.LEX = 0
        '    NEWFUENTE.AUTONOMIA = FUENTE.AUTONOMIA
        '    If FUENTE.IsCODORDNull = False Then NEWFUENTE.INSTALACION_RUS = FUENTE.CODORD Else NEWFUENTE.INSTALACION_RUS = "S/D"
        '    NEWFUENTE.INSTALACION = FUENTE.CODIGO
        '    If FUENTE.IsITOTALNull = False Then NEWFUENTE.ITOTAL = FUENTE.ITOTAL Else NEWFUENTE.ITOTAL = "-"
        '    If FUENTE.IsIPMODEMNull = False Then NEWFUENTE.IPMODEM = FUENTE.IPMODEM Else NEWFUENTE.IPMODEM = "-"
        '    If FUENTE.IsMAPEONull = False Then NEWFUENTE.MAPEO = FUENTE.MAPEO Else NEWFUENTE.MAPEO = "-"
        '    If FUENTE.IsID2Null = False Then NEWFUENTE.ID2 = FUENTE.ID2 Else NEWFUENTE.ID2 = "-"
        '    If FUENTE.IsMACNull = False Then NEWFUENTE.MAC = FUENTE.MAC Else NEWFUENTE.MAC = "-"
        '    If FUENTE.IsIMEINull = False Then NEWFUENTE.IMEI = FUENTE.IMEI Else NEWFUENTE.IMEI = "-"
        '    If FUENTE.IsPINNull = False Then NEWFUENTE.PIN = FUENTE.PIN Else NEWFUENTE.PIN = "-"
        '    If FUENTE.IsPUKNull = False Then NEWFUENTE.PUK = FUENTE.PUK Else NEWFUENTE.PUK = "-"
        '    If FUENTE.IsVPN1Null = False Then NEWFUENTE.VPN1 = FUENTE.VPN1 Else NEWFUENTE.VPN1 = "-"
        '    If FUENTE.IsVPN2Null = False Then NEWFUENTE.VPN2 = FUENTE.VPN2 Else NEWFUENTE.VPN2 = "-"
        '    If FUENTE.IsCARGA_REALNull = False Then NEWFUENTE.CARGA_REAL = FUENTE.CARGA_REAL
        '    BASEFUENTESDataSet.FUENTE.AddFUENTERow(NEWFUENTE)


        'Next

        'Try
        '    FUENTETableAdapter.Update(BASEFUENTESDataSet.FUENTE)
        'Catch ex As Exception

        'End Try


        'ORDENESTableAdapter.FillByTO(ORDENESDataSet.ORDENES)
        'For X = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
        '    DATOS.DATOS_ORDENESRow = ORDENESDataSet.ORDENES.Rows(X)
        '    'If DATOS.DATOS_ORDENESRow.ID_GESTION <> 0 Then
        '    If DATOS.DATOS_ORDENESRow.IsGEST_SOLICITADONull Then
        '        GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, DATOS.DATOS_ORDENESRow.ID_GESTION)
        '        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
        '            DATOS.DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(0)
        '            BTN_Directorio.Text = "GARGANDO ORDEN " & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & ", ES LA " & X + 1 & " DE " & ORDENESDataSet.ORDENES.Rows.Count
        '            BTN_Directorio.Refresh()
        '            DATOS.DATOS_ORDENESRow.GEST_SOLICITADO = DATOS.DATOS_GESTIONRow.SOLICITANTE
        '            ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)
        '        End If

        '    ElseIf DATOS.DATOS_ORDENESRow.GEST_SOLICITADO = "" Then
        '        GESTIONTableAdapter.FillByIDGESTION(ORDENESDataSet.GESTION, DATOS.DATOS_ORDENESRow.ID_GESTION)
        '        If ORDENESDataSet.GESTION.Rows.Count > 0 Then
        '            BTN_Directorio.Text = "GARGANDO ORDEN " & DATOS.DATOS_ORDENESRow.NRO_ORDENINT & ", ES LA " & X + 1 & " DE " & ORDENESDataSet.ORDENES.Rows.Count
        '            BTN_Directorio.Refresh()
        '            DATOS.DATOS_GESTIONRow = ORDENESDataSet.GESTION.Rows(0)
        '            DATOS.DATOS_ORDENESRow.GEST_SOLICITADO = DATOS.DATOS_GESTIONRow.SOLICITANTE
        '            ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)
        '        End If

        '    End If
        '    'End If




        'Next
        'BTN_Directorio.Visible = True
        'BTN_Directorio.Refresh()
        'Dim FILA As Integer
        'Dim oExcel As New Excel.Application
        'Dim oLibro As Excel.Workbook
        'Dim oHoja As Excel.Worksheet
        'oExcel.Application.AskToUpdateLinks = False
        'oExcel.Application.DisplayAlerts = False

        'Cursor = Cursors.WaitCursor
        'oLibro = oExcel.Workbooks.Open("C:\Users\dgeymonat\Downloads\EDIFICIOS.xlsx", UpdateLinks:=0)
        'oHoja = oLibro.Sheets("hoja1")


        'FILA = 5
        'Dim TOTAL_REGISTROS As Integer
        'Dim CONTENIDO As String = oHoja.Cells(FILA, 3).VALUE

        'While CONTENIDO <> ""
        '    TOTAL_REGISTROS += 1
        '    INICIO.VER_EDIFICIO = EDIFICIODataSet.EDIF_VISTA.NewEDIF_VISTARow()
        '    INICIO.VER_EDIFICIO.ID_EDIFICIO = TOTAL_REGISTROS
        '    INICIO.VER_EDIFICIO.NODO = oHoja.Cells(FILA, 1).value
        '    INICIO.VER_EDIFICIO.ZONA = oHoja.Cells(FILA, 2).value
        '    INICIO.VER_EDIFICIO.ID_CALLE = oHoja.Cells(FILA, 3).value
        '    INICIO.VER_EDIFICIO.INGRESO = Trim(oHoja.Cells(FILA, 4).value)
        '    INICIO.VER_EDIFICIO.TORRE = Trim(oHoja.Cells(FILA, 5).value)
        '    INICIO.VER_EDIFICIO.CALLE = oHoja.Cells(FILA, 6).value
        '    INICIO.VER_EDIFICIO.PUERTA = oHoja.Cells(FILA, 7).value
        '    INICIO.VER_EDIFICIO.APTOS = oHoja.Cells(FILA, 8).value
        '    INICIO.VER_EDIFICIO.PISOS = oHoja.Cells(FILA, 9).value

        '    INICIO.VER_EDIFICIO.TIPO_CAJA = oHoja.Cells(FILA, 14).value
        '    INICIO.VER_EDIFICIO.NUMERO_CAJA = oHoja.Cells(FILA, 15).value
        '    INICIO.VER_EDIFICIO.TUBO_CAJA = oHoja.Cells(FILA, 16).value
        '    INICIO.VER_EDIFICIO.PELO_CAJA = oHoja.Cells(FILA, 17).value

        '    INICIO.VER_EDIFICIO.NAP_TUBO = oHoja.Cells(FILA, 19).value
        '    INICIO.VER_EDIFICIO.NAP_PELO = oHoja.Cells(FILA, 20).value
        '    INICIO.VER_EDIFICIO.NAP_NUMERO = oHoja.Cells(FILA, 21).value
        '    INICIO.VER_EDIFICIO.NAP_TIPO = oHoja.Cells(FILA, 22).value
        '    INICIO.VER_EDIFICIO.ACOMETIDA = oHoja.Cells(FILA, 23).value
        '    INICIO.VER_EDIFICIO.OBS = oHoja.Cells(FILA, 29).value

        '    EDIFICIODataSet.EDIF_VISTA.AddEDIF_VISTARow(INICIO.VER_EDIFICIO)
        '    FILA += 1
        '    CONTENIDO = oHoja.Cells(FILA, 3).value
        'End While
        ' Dim MDUROW As EDIFICIODataSet.MDURow
        'Dim FTTHRow As EDIFICIODataSet.FTTBRow
        '  Dim CUENTA As Integer
        'Dim CUENTA_INGRES As Integer
        ''Dim CUENTA_TORRES As Integer
        'For Each EDIFICIO In EDIFICIODataSet.EDIF_VISTA
        '    '    'CARGAR EDIFICIOS
        '    CUENTA += 1
        '    INICIO.MDUTableAdapter.FillByCALLEYPUERTA(INICIO.EDIFICIODataSet.MDU, EDIFICIO.ID_CALLE, EDIFICIO.PUERTA)
        '    If INICIO.EDIFICIODataSet.MDU.Rows.Count > 0 Then
        '        '  MDUROW = INICIO.EDIFICIODataSet.MDU.Rows(0)
        '        '  MDUROW.ACOMETIDA = EDIFICIO.ACOMETIDA
        '        '   INICIO.MDUTableAdapter.Update(MDUROW)
        '        '    MDUROW = EDIFICIODataSet.MDU.NewMDURow()
        '        '    MDUROW.NODO = EDIFICIO.NODO
        '        '    MDUROW.ZONA = CInt(EDIFICIO.ZONA)
        '        '    MDUROW.ID_STATUS = 1
        '        '    MDUROW.ID_CALLE = CInt(EDIFICIO.ID_CALLE)
        '        '    If EDIFICIO.IsINGRESONull = False Then
        '        '        Select Case EDIFICIO.INGRESO
        '        '            Case "SI"
        '        '                MDUROW.INGRESO = "SUBTERRANEO"
        '        '            Case "O"
        '        '                MDUROW.INGRESO = "DUCTO"
        '        '            Case Else
        '        '                MDUROW.INGRESO = "AEREO"
        '        '        End Select
        '        '    End If
        '        '    If EDIFICIO.IsTORRENull = False AndAlso EDIFICIO.TORRE <> "" Then MDUROW.TORRE = CInt(EDIFICIO.TORRE) Else MDUROW.TORRE = 0
        '        '    CUENTA_TORRES += MDUROW.TORRE
        '        '    MDUROW.CALLE = EDIFICIO.CALLE
        '        '    MDUROW.PUERTA = EDIFICIO.PUERTA

        '        '    If EDIFICIO.IsAPTOSNull = False Then MDUROW.APTOS = EDIFICIO.APTOS
        '        '    If EDIFICIO.IsPISOSNull = False Then MDUROW.PISOS = EDIFICIO.PISOS
        '        '    EDIFICIODataSet.MDU.AddMDURow(MDUROW)
        '        CUENTA_INGRES += 1


        '        '    MDUTableAdapter1.Update(MDUROW)

        '        '    'PARA INFORMACION TECNICA DEL EDIFICIO
        '        '    'INICIO.MDUTableAdapter.FillByCALLEyPUERTA(INICIO.EDIFICIODataSet.MDU, EDIFICIO.CALLE, EDIFICIO.PUERTA)
        '        '    'If INICIO.EDIFICIODataSet.MDU.Rows.Count = 1 Then
        '        MDUROW = INICIO.EDIFICIODataSet.MDU.Rows(0)
        '        FTTHRow = INICIO.EDIFICIODataSet.FTTB.NewFTTBRow()
        '        FTTHRow.ID_EDIFICIO = MDUROW.ID_MDU
        '        If EDIFICIO.IsNUMERO_CAJANull = False Then FTTHRow.CONEXION_DESDE = EDIFICIO.NUMERO_CAJA
        '        FTTHRow.TIPO_CONEXION_DESDE = EDIFICIO.TIPO_CAJA
        '        FTTHRow.CABLE = "Acometida (12 fibras 1 tubo)"
        '        If EDIFICIO.IsNAP_TIPONull OrElse EDIFICIO.NAP_TIPO = "" Then
        '            FTTHRow.NAP = 16
        '        Else
        '            FTTHRow.NAP = EDIFICIO.NAP_TIPO
        '        End If
        '        FTTHRow.NAP_NRO = EDIFICIO.NAP_NUMERO
        '        FTTHRow.TUBO = EDIFICIO.NAP_TUBO
        '        FTTHRow.PELO = EDIFICIO.NAP_PELO
        '        If EDIFICIO.IsNAP_TIPONull Then
        '            FTTHRow.SPL_NRO = 2
        '        Else
        '            FTTHRow.SPL_NRO = 1
        '        End If
        '        If EDIFICIO.IsOBSNull = False Then FTTHRow.OBS_TEC = EDIFICIO.OBS
        '        INICIO.EDIFICIODataSet.FTTB.AddFTTBRow(FTTHRow)
        '        INICIO.FTTBTableAdapter.Update(FTTHRow)
        '    End If

        '    BTN_Directorio.Text = CUENTA & "  modificados: " & CUENTA_INGRES
        '    BTN_Directorio.Refresh()

        'Next
        'FTTBTableAdapter.Fill(EDIFICIODataSet.FTTB)

        'For Each fttb In EDIFICIODataSet.FTTB
        '    CUENTA += 1
        '    lblcuentas.Text = "actualizando " & CUENTA & "  de   " & EDIFICIODataSet.FTTB.Rows.Count
        '    lblcuentas.Refresh()
        '    If fttb.IsACOMETIDANull Then

        '        MDUTableAdapter.FillByID(EDIFICIODataSet.MDU, fttb.ID_EDIFICIO)
        '        MDUROW = EDIFICIODataSet.MDU.Rows(0)
        '        fttb.ACOMETIDA = MDUROW.ACOMETIDA
        '        FTTBTableAdapter.Update(fttb)

        '    End If

        'Next

        'MDUTableAdapter.Fill(EDIFICIODataSet.MDU)

        'For Each mdu In EDIFICIODataSet.MDU
        '    lblcuentas.Text = "actualizando " & mdu.CALLE & "  " & mdu.PUERTA
        '    lblcuentas.Refresh()
        '    'InsertMDU(mdu.ID_MDU, mdu.ID_STATUS, mdu.ID_CALLE, mdu.CALLE, mdu.PUERTA, mdu.APTOS, mdu.PISOS, mdu.NODO, mdu.ZONA, mdu.INGRESO, mdu.TORRE)

        '    '  Await getMDU(mdu.ID_MDU)
        'Next


        'CORRIGE EL PROBLEMA DE LOS EMITIDOS
        '  Dim trabajoRow As ORDENESDataSet.TRABAJOSRow
        'TRABAJOSTableAdapter.Fill(ORDENESDataSet.TRABAJOS)
        'If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '    For i = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '        trabajoRow = ORDENESDataSet.TRABAJOS.Rows(i)
        '        lblcuentas.Text = "actualizando " & trabajoRow.Id_TRABAJO & " DE " & ORDENESDataSet.TRABAJOS.Rows.Count
        '        lblcuentas.Refresh()

        '        If trabajoRow.IsFECHAINICIADONull = False AndAlso trabajoRow.FECHAINICIADO = "1/3/2024" AndAlso trabajoRow.STATUS = "INGRESADO" Then
        '            trabajoRow("FECHAINICESTIMADO") = Now.ToShortDateString
        '            trabajoRow("FECHAINICIADO") = DBNull.Value
        '            TRABAJOSTableAdapter.Update(trabajoRow)
        '        End If
        'If trabajoRow.STATUS = "INICIADO" Then
        '    ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, trabajoRow.Id_TRABAJO)
        '    If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
        '        Dim hayIniciado = False
        '        Dim OrdenRow As ORDENESDataSet.ORDENESRow
        '        For j = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
        '            OrdenRow = ORDENESDataSet.ORDENES.Rows(j)
        '            Select Case OrdenRow.STATUS
        '                Case "INICIADO", "DUPLICADO", "ADUPLICAR", "FINALIZADO"
        '                    hayIniciado = True
        '                    Exit For
        '            End Select
        '        Next

        '        If hayIniciado = False Then
        '            trabajoRow.STATUS = "INGRESADO"
        '            trabajoRow.FECHAINICESTIMADO = Nothing
        '            TRABAJOSTableAdapter.Update(trabajoRow)
        '        End If
        '    Else
        '        trabajoRow.STATUS = "INGRESADO"
        '        trabajoRow.FECHAINICESTIMADO = Nothing
        '        TRABAJOSTableAdapter.Update(trabajoRow)
        '    End If


        'End If
        'Next
        'End If

        'Dim GROW As ORDENESDataSet.GESTIONRow

        'GESTIONTableAdapter.Fill(ORDENESDataSet.GESTION)
        'If ORDENESDataSet.GESTION.Rows.Count > 0 Then
        '    For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
        '        GROW = ORDENESDataSet.GESTION.Rows(I)
        '        lblcuentas.Text = "actualizando " & GROW.Id_GESTION & " DE " & ORDENESDataSet.GESTION.Rows.Count
        'lblcuentas.Refresh()
        'Dim hayIniciado = False
        ' If GROW.IsFECHAINICIADANull = False AndAlso GROW.FECHAINICIADA = "30/12/1899" Then

        'TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, GROW.Id_GESTION)
        'If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '    Dim trabajoRow As ORDENESDataSet.TRABAJOSRow
        '   
        '    For J = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
        '        trabajoRow = ORDENESDataSet.TRABAJOS.Rows(J)
        '        If trabajoRow.STATUS = "INICIADO" Then
        '            hayIniciado = True
        '            Exit For
        '        End If
        '    Next
        'If hayIniciado = False Then
        'GROW("FECHAINICIADA") = DBNull.Value
        'GESTIONTableAdapter.Update(GROW)
        'End If
        'Else
        '    GROW.FECHAINICIADA = Nothing
        '    GROW.STATUS = "INGRESADO"
        '    GESTIONTableAdapter.Update(GROW)
        '        End If

        '    Next
        'End If

        Cursor = Cursors.Default
    End Sub

    Private Sub BTN_FTTB_Click(sender As Object, e As EventArgs)
        If INICIO.Visible Then INICIO.Close()
        INICIO.Show()
    End Sub

    Private Sub BTN_MODIFICA_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICA.Click
        Cursor = Cursors.WaitCursor
        Dim SQL = "SELECT T.id_TRABAJO, T.ID_GESTION FROM TRABAJOS T WHERE T.ID_GESTION  NOT IN ( SELECT G.ID_GESTION FROM GESTION G WHERE T.id_TRABAJO = G.id_GESTION );"
        SQL = "SELECT O.* FROM ORDENES O LEFT JOIN TRABAJOS T ON O.ID_TRABAJO = T.ID_TRABAJO WHERE T.ID_TRABAJO IS NULL"
        Dim RESULTADO = ExecuteQuery("ordenes", SQL)
        NOTIFICACION("SYS", RESULTADO.FieldCount.ToString)
        Dim DT As New DataTable()
        DT.Load(RESULTADO)
            DGVRESULT.DataSource = DT

        'For I = 0 To DT.Rows.Count - 1
        '    SQL = "DELETE FROM TRABAJOS WHERE ID_TRABAJO = " & DT.Rows(I).Item("id_TRABAJO")
        '    ExecuteNonQuery("ORDENES", SQL)
        'Next

        Cursor = Cursors.Default
    End Sub



    'Private Sub DASHBOARD_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    BTN_Directorio.Text = MousePosition.X.ToString

    'End Sub

    'Private Sub RELOJ_SEG_Tick(sender As Object, e As EventArgs) Handles RELOJ_SEG.Tick

    '    HORA = Mid(HoraAhora.Text, 1, 2)
    '    MINUTOS = Mid(HoraAhora.Text, 4, 2)
    '    If Mid(HoraAhora.Text, 3, 1) = ":" Then
    '        HoraAhora.Text = HORA & " " & MINUTOS
    '    Else
    '        HoraAhora.Text = HORA & ":" & MINUTOS
    '    End If

    'End Sub




    'Private Sub TimerWAIT_Tick(sender As Object, e As EventArgs) Handles TimerWAIT.Tick
    '    CONTAR += 1
    '    If CONTAR > 3 Then
    '        TimerWAIT.Enabled = False
    '        P_WAIT.Visible = False
    '    End If
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    TRABAJOSTableAdapter.FillBytTIPO(ORDENESDataSet.TRABAJOS, "CONSTRUCCION")
    '    If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
    '        For X = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
    '            ORDENESDataSet.TRABAJOS.Rows(X).Item("TIPOTRABAJO") = "EJECUCION"
    '            TRABAJOSTableAdapter.Update(ORDENESDataSet.TRABAJOS.Rows(X))
    '            Button1.Text = X + 1 & " DE " & ORDENESDataSet.TRABAJOS.Rows.Count
    '            Button1.Refresh()
    '        Next
    '    End If
    'End Sub
End Class
