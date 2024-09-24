Imports Newtonsoft.Json
Imports System.Net
Module MODULODASHBOARD
    'DASHBOARD
    Public VERSION As String
    Public BTN1var As Object
    Public BTN2var As Object
    Public BTN3var As Object
    Public BTN4var As Object
    Public BTN5var As Object
    Public BTN6var As Object
    Public BTN7var As Object
    Public BTN8var As Object

    Public CLIMA_DATOS
    Public CLIMA_DATOS_hora As String
    Public HORA_DATOS As Date

    Public Sub SiBoton(BTNOB As Object)
        If BTNOB.Text = "AdminTEC" Then
            DASHBOARD.BTN_ADMIN.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "MDU" Then
            DASHBOARD.BTN_MDU.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "RED" Then
            DASHBOARD.BTN_RED.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "BUSCADOR" Then
            DASHBOARD.BTN_BUSCADOR.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "ORDENES" Then
            DASHBOARD.BTN_DESPACHO.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "FIBRA" Then
            DASHBOARD.BTN_FTTB.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "FUENTES" Then
            DASHBOARD.BTN_FUENTES.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        ElseIf BTNOB.Text = "AGENDA" Then
            DASHBOARD.BTN_AGENDA.BackgroundImage = My.Resources.BTNGRAL_DEFAULT
        End If
    End Sub
    Public Sub EstiloBTNCerrar(ByVal boton As Integer)
        If boton = 1 Then
            DASHBOARD.BTN1Close.Visible = False
            DASHBOARD.BTN1.Visible = False
            '  If ingreso.btn1.Text = "AGENDA" Then ACCESO_AGENDA = ""
            If DASHBOARD.BTN1.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN1.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN1.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN1var.close()
            SiBoton(DASHBOARD.BTN1)
            If DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 2 Then
            DASHBOARD.BTN2Close.Visible = False
            DASHBOARD.BTN2.Visible = False
            SiBoton(DASHBOARD.BTN2)
            '  If ingreso.btn2.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN2.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN2.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN2.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN2var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 3 Then
            DASHBOARD.BTN3Close.Visible = False
            DASHBOARD.BTN3.Visible = False
            SiBoton(DASHBOARD.BTN3)

            If DASHBOARD.BTN3.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN3.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN3.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN3var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 4 Then
            DASHBOARD.BTN4Close.Visible = False
            DASHBOARD.BTN4.Visible = False
            SiBoton(DASHBOARD.BTN4)
            '  If ingreso.btn4.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN4.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN4.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN4.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN4var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 5 Then
            DASHBOARD.BTN5Close.Visible = False
            DASHBOARD.BTN5.Visible = False
            SiBoton(DASHBOARD.BTN5)
            '  If ingreso.btn5.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN5.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN5.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN5.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN5var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 6 Then
            DASHBOARD.BTN6Close.Visible = False
            DASHBOARD.BTN6.Visible = False
            SiBoton(DASHBOARD.BTN6)
            '  If INGRESO.BTN6.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN6.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN6.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN6.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN6var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 7 Then
            DASHBOARD.BTN7Close.Visible = False
            DASHBOARD.BTN7.Visible = False
            SiBoton(DASHBOARD.BTN7)
            '  If INGRESO.BTN7.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN7.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN7.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN7.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN7var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN8.Visible Then
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN8var.bringtofront()
            End If
        ElseIf boton = 8 Then
            DASHBOARD.BTN8Close.Visible = False
            DASHBOARD.BTN8.Visible = False
            SiBoton(DASHBOARD.BTN8)
            '  If INGRESO.BTN8.Text = "AGENDA" Then INGRESO.ACCESO_AGENDA = False
            If DASHBOARD.BTN8.Text = "MDU" And INGRESO_AREA = "MDU" Then
                INGRESO_AREA = ""
                If DATOS IsNot Nothing Then DATOS.Close()
            End If
            If DASHBOARD.BTN8.Text = "FUENTES" And INGRESO_AREA = "FUENTES" Then If DATOS IsNot Nothing Then DATOS.Close()
            If DASHBOARD.BTN8.Text = "BUSCADOR" And ACCESO_DESDE = "BUSCADOR" Then If DATOS IsNot Nothing Then DATOS.Close()
            BTN8var.close()
            If DASHBOARD.BTN1.Visible Then
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN1var.BRINGTOFRONT()
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN2.Visible Then
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN2var.BRINGTOFRONT()
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN3.Visible Then
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN3var.BRINGTOFRONT()
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN4.Visible Then
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN4var.BRINGTOFRONT()
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN5.Visible Then
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN5var.BRINGTOFRONT()
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN6.Visible Then
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN6var.BRINGTOFRONT()
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN7.Visible Then
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                BTN7var.BRINGTOFRONT()
            End If
        End If
    End Sub
    Public Sub BotonesInferiores(nombre As String, variable As Form)
        DASHBOARD.BTN1.ForeColor = Color.White
        DASHBOARD.BTN2.ForeColor = Color.White
        DASHBOARD.BTN3.ForeColor = Color.White
        DASHBOARD.BTN4.ForeColor = Color.White
        DASHBOARD.BTN5.ForeColor = Color.White
        DASHBOARD.BTN6.ForeColor = Color.White
        DASHBOARD.BTN7.ForeColor = Color.White
        DASHBOARD.BTN8.ForeColor = Color.White
        If variable.Visible = False Then
            variable.TopLevel = False
            variable.Parent = DASHBOARD.PanelTrabajo
            variable.Dock = DockStyle.Fill
            variable.Show()
            'variable.Location = New Point(0, 27)
            variable.BringToFront()

            If DASHBOARD.BTN1.Visible = False Then
                DASHBOARD.BTN1.Text = nombre
                DASHBOARD.BTN1Close.Visible = True
                DASHBOARD.BTN1Close.BackColor = Color.Black
                DASHBOARD.BTN1.Visible = True
                BTN1var = variable
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible = True And DASHBOARD.BTN2.Visible = False Then
                DASHBOARD.BTN2.Text = nombre
                DASHBOARD.BTN2Close.Visible = True
                DASHBOARD.BTN2Close.BackColor = Color.Black
                DASHBOARD.BTN2.Visible = True
                BTN2var = variable

                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible = True And DASHBOARD.BTN2.Visible = True And DASHBOARD.BTN3.Visible = False Then
                DASHBOARD.BTN3.Text = nombre
                DASHBOARD.BTN3Close.Visible = True
                DASHBOARD.BTN3Close.BackColor = Color.Black
                DASHBOARD.BTN3.Visible = True
                BTN3var = variable
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible And DASHBOARD.BTN2.Visible And DASHBOARD.BTN3.Visible And DASHBOARD.BTN4.Visible = False Then
                DASHBOARD.BTN4.Text = nombre
                DASHBOARD.BTN4Close.Visible = True
                DASHBOARD.BTN4Close.BackColor = Color.Black
                DASHBOARD.BTN4.Visible = True
                BTN4var = variable
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible And DASHBOARD.BTN2.Visible And DASHBOARD.BTN3.Visible And DASHBOARD.BTN4.Visible And DASHBOARD.BTN5.Visible = False Then
                DASHBOARD.BTN5.Text = nombre
                DASHBOARD.BTN5Close.Visible = True
                DASHBOARD.BTN5Close.BackColor = Color.Black
                DASHBOARD.BTN5.Visible = True
                BTN5var = variable
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible And DASHBOARD.BTN2.Visible And DASHBOARD.BTN3.Visible And DASHBOARD.BTN4.Visible And DASHBOARD.BTN5.Visible And DASHBOARD.BTN6.Visible = False Then
                DASHBOARD.BTN6.Text = nombre
                DASHBOARD.BTN6Close.Visible = True
                DASHBOARD.BTN6Close.BackColor = Color.Black
                DASHBOARD.BTN6.Visible = True
                BTN6var = variable
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible And DASHBOARD.BTN2.Visible And DASHBOARD.BTN3.Visible And DASHBOARD.BTN4.Visible And DASHBOARD.BTN5.Visible And DASHBOARD.BTN6.Visible And DASHBOARD.BTN7.Visible = False Then
                DASHBOARD.BTN7.Text = nombre
                DASHBOARD.BTN7Close.Visible = True
                DASHBOARD.BTN7Close.BackColor = Color.Black
                DASHBOARD.BTN7.Visible = True
                BTN7var = variable
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior
            ElseIf DASHBOARD.BTN1.Visible And DASHBOARD.BTN2.Visible And DASHBOARD.BTN3.Visible And DASHBOARD.BTN4.Visible And DASHBOARD.BTN5.Visible And DASHBOARD.BTN6.Visible And DASHBOARD.BTN7.Visible And DASHBOARD.BTN8.Visible = False Then
                DASHBOARD.BTN8.Text = nombre
                DASHBOARD.BTN8Close.Visible = True
                DASHBOARD.BTN8Close.BackColor = Color.Black
                DASHBOARD.BTN8.Visible = True
                BTN8var = variable
                DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
                DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
                DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            End If
        Else
            variable.BringToFront()
            ColorBTNSuperior(nombre)
        End If
        Select Case nombre
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
    Public Sub ColorBTNSuperior(ByVal nombre As String)
        If DASHBOARD.BTN1.Text = nombre Then
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN2.Text = nombre Then
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN3.Text = nombre Then
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN4.Text = nombre Then
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN5.Text = nombre Then
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN6.Text = nombre Then
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN7.Text = nombre Then
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperior

        ElseIf DASHBOARD.BTN8.Text = nombre Then
            DASHBOARD.BTN8.BackgroundImage = My.Resources.BTNSuperiorACTIVO
            DASHBOARD.BTN1.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN2.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN3.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN4.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN5.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN6.BackgroundImage = My.Resources.BTNSuperior
            DASHBOARD.BTN7.BackgroundImage = My.Resources.BTNSuperior

        End If
        DASHBOARD.BTN1.Refresh()
        DASHBOARD.BTN2.Refresh()
        DASHBOARD.BTN3.Refresh()
        DASHBOARD.BTN4.Refresh()
        DASHBOARD.BTN5.Refresh()
        DASHBOARD.BTN6.Refresh()
        DASHBOARD.BTN7.Refresh()
        DASHBOARD.BTN8.Refresh()
    End Sub
    Public Sub OBTENER_CLIMA()
        Try
            Dim webClient As New WebClient
            Dim forescast = webClient.DownloadString("https://api.tomorrow.io/v4/timelines/?fields=temperature&fields=weatherCode&location=-34.8748,-56.17163&timesteps=1d&units=metric&apikey=937RgXzZKlY544V5KyT9IZoii9Rm9ZOl")
            CLIMA_DATOS = JsonConvert.DeserializeObject(forescast)("data")("timelines")(0)("intervals")
        Catch ex As Exception
            MsgBox("ERROR AL OBTENER CLIMA-DIAS")
            CLIMA_DATOS = Nothing
        End Try
    End Sub
    Public Sub OBTENER_CLIMA_HORA()
        Try
            Dim webClient As New WebClient
            Dim current = webClient.DownloadString("https://api.tomorrow.io/v4/timelines/?fields=temperature&location=-34.8748,-56.17163&timesteps=current&units=metric&apikey=937RgXzZKlY544V5KyT9IZoii9Rm9ZOl")
            CLIMA_DATOS_hora = JsonConvert.DeserializeObject(current)("data")("timelines")(0)("intervals")(0)("values")("temperature")

        Catch ex As Exception
            MsgBox("ERROR AL OBTENER CLIMA-HORA")
            CLIMA_DATOS_hora = Nothing
        End Try
    End Sub
    Public Sub OBTENER_HORA()
        Try
            Dim webClient As New WebClient
            Dim current = webClient.DownloadString("http://worldtimeapi.org/api/timezone/America/Montevideo")
            HORA_DATOS = Split(JsonConvert.DeserializeObject(current)("datetime"), "T")(0)
            DASHBOARD.HoraAhora.Text = HORA_DATOS.ToString("HH:mm")

        Catch ex As Exception
            'MsgBox("ERROR AL OBTENER LA HORA")
            HORA_DATOS = Nothing
            DASHBOARD.HoraAhora.Text = ""
        End Try
    End Sub
End Module
