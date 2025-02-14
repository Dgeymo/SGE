Imports System.IO
Imports Newtonsoft.Json
Public Class Login
    Dim newCLIMArow As DataRow
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Refresh()
        If File.Exists("C:\DOCUMENTOS\USUARIO\LOGVBNET.TXT") Then
            IDUSUARIO = DASHBOARD.USUARIO_ARRAY(0)
            DASHBOARD.USUARIOSTableAdapter.FillByID(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS, IDUSUARIO)
            If DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows.Count > 0 Then
                Usuario.Text = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("USUARIO")
                THEME_BLACK = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("BLACK")
                DASHBOARD.APLICAR_THEME_WHITE()
            Else
                MsgBox("ERROR EN OBTENER USUARIO, VERIFIQUE CONEXION DE RED O CONFIGURACION EN EQUIPO", MsgBoxStyle.Critical)
            End If
            If Screen.AllScreens.Length = 1 Then
                DASHBOARD.Location = New Point(Screen.PrimaryScreen.WorkingArea.Location)
                DASHBOARD.Size = New Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height)
                PANTALLA_PRIMARIA = True
                PANTALLA_NEGATIVA = False
            Else
                If DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows.Count > 0 Then
                    PANTALLA_PRIMARIA = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA")
                    PANTALLA_NEGATIVA = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_NEGATIVA")

                    Select Case PANTALLA_PRIMARIA
                        Case False
                            If PANTALLA_NEGATIVA Then
                                Location = New Point((Screen.PrimaryScreen.WorkingArea.Size.Width - Size.Width) / 2 - 1366, (Screen.PrimaryScreen.WorkingArea.Size.Height - Size.Height) / 2)
                                DASHBOARD.Location = New Point(-1366, 0)
                                DASHBOARD.Size = New Size(Screen.AllScreens(0).WorkingArea.Size.Width, Screen.AllScreens(0).WorkingArea.Size.Height)
                            Else
                                Location = New Point((Screen.PrimaryScreen.WorkingArea.Size.Width - Size.Width) / 2 + 1366, (Screen.PrimaryScreen.WorkingArea.Size.Height - Size.Height) / 2)
                                DASHBOARD.Location = New Point(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.AllScreens(1).WorkingArea.Y)
                                DASHBOARD.Size = New Size(Screen.AllScreens(1).WorkingArea.Size.Width, Screen.AllScreens(1).WorkingArea.Size.Height)
                            End If
                        Case True
                            Location = New Point((Screen.PrimaryScreen.WorkingArea.Size.Width - Size.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Size.Height - Size.Height) / 2)
                            DASHBOARD.Location = New Point(0, 0)
                            DASHBOARD.Size = New Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height)
                    End Select
                End If
            End If
        End If
        If My.Settings.Validar = True Then
            CheckRecordar.Text = "Olvidar"
            Usuario.Text = My.Settings.User
            Password.Text = My.Settings.Pass
        End If
    End Sub
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Usuario.Text <> "" And Password.Text <> "" Then
            If CheckRecordar.Checked = True And My.Settings.Validar = False Then
                My.Settings.User = Usuario.Text
                My.Settings.Pass = Password.Text
                My.Settings.Validar = True
                My.Settings.Save()
                My.Settings.Reload()
            ElseIf CheckRecordar.Checked = True And My.Settings.Validar = True Then
                My.Settings.User = ""
                My.Settings.Pass = ""
                My.Settings.Validar = False
                My.Settings.Save()
                My.Settings.Reload()
            End If
            'BUSCAMOS SI HAY USUARIO REGISTRADO
            DASHBOARD.USUARIOSTableAdapter.FillByUSUARIO(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS, Usuario.Text, Password.Text)


            If DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows.Count() > 0 Then
                If Password.Text <> DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PASWORD") Then
                    LBLError.Visible = True
                    Password.Focus()
                    Exit Sub
                End If
                DASHBOARD.PanelInferior.Visible = True
                DASHBOARD.PanelSUPInterior.Visible = True
                VERSION = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("VERSION")
                NOMBRE = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("NOMBRE")
                APELLIDO = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("APELLIDO")
                FULLNOMBRE = NOMBRE & " " & APELLIDO
                SECTOR = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("SECTOR")
                ID = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("Id")
                THEME_BLACK = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("BLACK")
                PANTALLA_PRIMARIA = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_PRIMARIA")
                PANTALLA_NEGATIVA = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PANTALLA_NEGATIVA")

                If IsDBNull(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("USUARIO_RUS")) = False Then USUARIO_RUS = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("USUARIO_RUS")
                If IsDBNull(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PASWORD_RUS")) = False Then PASSWORD_RUS = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PASWORD_RUS")
                If IsDBNull(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("ID_SELECTOR")) = False Then SELECTOR = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("ID_SELECTOR")
                If IsDBNull(DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("EMAIL")) = False Then REMITENTE = DASHBOARD.OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("EMAIL")

                ' DASHBOARD.GESTIONTableAdapter.FillByGEST_REQUERIDO(DASHBOARD.ORDENESDataSet.GESTION, FULLNOMBRE)
                '  DASHBOARD.TRABAJOSTableAdapter.FillByTRABAJO_REQUERIDO(DASHBOARD.ORDENESDataSet.TRABAJOS, FULLNOMBRE)
                If DASHBOARD.ORDENESDataSet.GESTION.Rows.Count > 0 Then
                    DASHBOARD.BTN_MISGestiones.Text = DASHBOARD.ORDENESDataSet.GESTION.Rows.Count & " GEST"
                    DASHBOARD.BTN_MISGestiones.Visible = True
                End If
                If DASHBOARD.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                    DASHBOARD.MISTrabajos.Text = DASHBOARD.ORDENESDataSet.TRABAJOS.Rows.Count & " TRAB"
                    DASHBOARD.MISTrabajos.Visible = True
                End If
                If SECTOR = "GERENCIA" Or SECTOR = "PLANIFICACION TECNICA" Then
                    DASHBOARD.BtnPropiedades.Visible = True
                Else
                    DASHBOARD.BtnPropiedades.Visible = False
                End If



                DASHBOARD.CLIMATableAdapter.FillByCLIMA_INGRESO(DASHBOARD.INDICESDataSet.CLIMA, Today.ToShortDateString)

                If SECTOR = "PLANIFICACION TECNICA" Then
                    If DASHBOARD.INDICESDataSet.CLIMA.Rows.Count = 0 Then
                        'SI NO ENCUENTRA REGISTROS PARA EL DIA DE HOY PROCEDEMOS A ELIMINAR TODOS LOS DIAS PRONOSTICADOS DE DIAS ANTERIORES
                        Try
                            For Dia = 0 To 14
                                Select Case Dia
                                    Case 0
                                        DASHBOARD.CLIMATableAdapter.FillByCLIMA_FECHA(DASHBOARD.INDICESDataSet.CLIMA, Today.ToShortDateString)
                                        DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Delete()
                                        DASHBOARD.CLIMATableAdapter.Update(DASHBOARD.INDICESDataSet.CLIMA)
                                    Case Else
                                        DASHBOARD.CLIMATableAdapter.FillByCLIMA_FECHA(DASHBOARD.INDICESDataSet.CLIMA, Today.AddDays(Dia).ToShortDateString)
                                        DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Delete()
                                        DASHBOARD.CLIMATableAdapter.Update(DASHBOARD.INDICESDataSet.CLIMA)
                                End Select
                            Next
                        Catch ex As Exception
                        End Try
                        OBTENER_CLIMA()
                        Dim ESPERA = 0

                        ESPERA += 100
                        Dim VALOR As String = 0
                        Try
                            VALOR = CLIMA_DATOS(0)("startTime").ToString
                            Threading.Thread.Sleep(ESPERA)
                            For VARCLIMA = 0 To 14
                                newCLIMArow = DASHBOARD.INDICESDataSet.CLIMA.NewCLIMARow
                                newCLIMArow("CLIMA_FECHA") = CDate(CLIMA_DATOS(VARCLIMA)("startTime")).ToShortDateString
                                newCLIMArow("CLIMA_TEMPERATURA") = CDbl(CLIMA_DATOS(VARCLIMA)("values")("temperature"))
                                newCLIMArow("CLIMA_CODIGO_LOGO") = CLIMA_DATOS(VARCLIMA)("values")("weatherCode").ToString & "0"
                                newCLIMArow("CLIMA_INGRESO") = Today.ToShortDateString
                                newCLIMArow("HORA_INGRESO") = Now
                                Try
                                    DASHBOARD.INDICESDataSet.CLIMA.AddCLIMARow(newCLIMArow)
                                    DASHBOARD.CLIMATableAdapter.Update(newCLIMArow)
                                Catch x As Exception
                                    MsgBox(x.Message)
                                End Try
                            Next
                        Catch ex As Exception
                        End Try
                        CLIMA_DATOS = Nothing
                        OBTENER_CLIMA_HORA()
                        If CLIMA_DATOS_hora IsNot Nothing Then
                            DASHBOARD.CLIMATableAdapter.FillByCLIMA_INGRESO(DASHBOARD.INDICESDataSet.CLIMA, Today.ToShortDateString)
                            If DASHBOARD.INDICESDataSet.CLIMA.Rows.Count > 0 Then
                                DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_TEMPERATURA") = CLIMA_DATOS_hora
                                DASHBOARD.CLIMATableAdapter.Update(DASHBOARD.INDICESDataSet.CLIMA)
                                DASHBOARD.LBL_TEMP.Text = "TEMP: " & CInt(DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_TEMPERATURA")) & "°C"
                            End If
                        End If
                    End If
                End If
                If DASHBOARD.INDICESDataSet.CLIMA.Rows.Count > 0 Then
                    DASHBOARD.LBL_TEMP.Text = "TEMP: " & CInt(DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_TEMPERATURA")) & "°C"
                    DASHBOARD.PIC_CLIMA.BackgroundImage = My.Resources.ResourceManager.GetObject(DASHBOARD.INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_CODIGO_LOGO"))
                Else
                    DASHBOARD.LBL_TEMP.Text = "TEMP: N/D"
                End If
                DASHBOARD.WindowState = FormWindowState.Normal
                DASHBOARD.Refresh()
                Dim FECHA As String = Format(Today, "yyyy-MM-dd")
                Dim FECHA_ANTERIOR As String
                If SECTOR = "PLANIFICACION TECNICA" Then
                    For D = 0 To 10
                        FECHA_ANTERIOR = Format(Today.AddDays(-D - 5), "yyyy-MM-dd")
                        Try
                            If Directory.Exists("R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA_ANTERIOR) Then
                                Directory.Delete("R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA_ANTERIOR, True)
                            End If
                        Catch ex As Exception
                        End Try
                    Next
                    If Directory.Exists("R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA) Then
                        NOTIFICACION("SYS", "BBDD-ORDENES, ya respaldada")
                    Else
                        'no existe
                        NOTIFICACION("SYS", "AGUARDE... realizando respado de BBDD-ORDENES")
                        Directory.CreateDirectory("R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA)
                        File.Copy("G:\OPERACIONES\BD_ORDENES\ORDENES.accdb", "R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA & "\ORDENES.accdb")
                        ' File.Copy("G:\OPERACIONES\BD_ORDENES\ORDENES.accdb", "R:\OPERACIONES\PROGRAMAS\BBDD\" & FECHA & "\ORDENES_be.accdb")
                        NOTIFICACION("SYS", "Respado de BBDD-ORDENES, correcto")
                    End If
                End If
                DASHBOARD.ContarRegistros()
                Close()
                Else
                    LBLError.Visible = True
                Password.Focus()
            End If
        Else
            If Usuario.Text = "" Then
                MsgBox("Por favor, completa usuario")
                Usuario.Focus()
            End If
            If Password.Text = "" Then
                MsgBox("Por favor, completa contraseña")
                Password.Focus()
            End If
        End If
    End Sub
    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIngresar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Focus()
        Usuario.Focus()
        If Usuario.Text <> "" Then
            Password.Focus()
        End If
        If Usuario.Text <> "" And Password.Text <> "" Then
            BtnIngresar.Focus()
        End If
    End Sub
    Private Sub BtnIngresar_MouseHover(sender As Object, e As EventArgs) Handles BtnIngresar.MouseHover
        BtnIngresar.BackgroundImage = My.Resources.BTNGRAL_OVER
    End Sub
    Private Sub BtnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        BtnIngresar.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
    End Sub
    Private Sub BtnIngresar_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIngresar.MouseDown
        BtnIngresar.BackgroundImage = My.Resources.BTNGRAL_PRESS
    End Sub
End Class