Imports Newtonsoft.Json
Public Class FORMAGE

    Dim FECHAHOY As Date
    Dim POSX As Integer
    Dim POSY As Integer
    Dim FIJA_FECHAINI As Date
    Dim CANT_TECNICOS_DIA As Integer

    Dim DIAINI As Date
    Dim DIAFIN As Date
    Dim DIA As Integer
    Public ACCION_AGENDA As String
    Dim BTN_DIA_MOD(45) As Button
    Dim BTN_DIA_ADD(45) As Button
    Public BTN_CALENDARIO_DIA(120) As Button
    Dim MES_INI As Integer
    Dim AÑO_INI As Integer
    Dim FIJA_DIA As Boolean
    Public PRIORIDAD As String

    Dim COLUMN_A_MOSTRAR As Integer
    Dim CAPACIDADRow As DataRow
    Dim ACCESO_AUSENCIA As String
    Dim HSLUNES As Double
    Dim HSMARTES As Double
    Dim HSMIERCOLES As Double
    Dim HSJUEVES As Double
    Dim HSVIERNES As Double
    Dim HSSABADO As Double
    Dim HSDOMINGO As Double

    Dim PORCENT_DIA(20) As Label
    Dim OCUPACION_DIA(20) As Label
    Dim PERCENT_DIA(20) As Label
    Dim TEC_DIA(539) As PictureBox
    Dim HOVER_DIA As Integer
    Dim FECHADIA(60) As Date
    Dim CANT_TEC(60) As Integer
    Dim CANt_CUA(60) As Integer
    Dim CANTMINUTOS_TEC(60) As Integer
    Dim CANTMINUTOS_CUA(60) As Integer

    Dim CAP_DIA_ALTA As Integer
    Dim CAP_DIA_MEDIA As Integer
    Dim CAP_DIA_BAJA As Integer
    Dim AGE_DIA_ALTA As Integer
    Dim AGE_DIA_MEDIA As Integer
    Dim AGE_DIA_BAJA As Integer
    Dim DIS_DIA_ALTA As Integer
    Dim DIS_DIA_MEDIA As Integer
    Dim DIS_DIA_BAJA As Integer

    Dim HS_TECTEOR_ALT_PT As Double
    Dim HS_TECTEOR_MED_PT As Double
    Dim HS_TECTEOR_BAJ_PT As Double
    Dim HS_TECTEOR_ALT_SU As Double
    Dim HS_TECTEOR_MED_SU As Double
    Dim HS_TECTEOR_BAJ_SU As Double
    Dim HS_TECTEOR_CO As Double
    Dim HS_TECTEOR As Double

    Dim HS_CUATEOR_ALT_PT As Double
    Dim HS_CUATEOR_MED_PT As Double
    Dim HS_CUATEOR_BAJ_PT As Double
    Dim HS_CUATEOR_ALT_SU As Double
    Dim HS_CUATEOR_MED_SU As Double
    Dim HS_CUATEOR_BAJ_SU As Double
    Dim HS_CUATEOR_CO As Double
    Dim HS_CUATEOR As Double


    Dim HS_AUSTEC_ALT_PT As Double
    Dim HS_AUSTEC_MED_PT As Double
    Dim HS_AUSTEC_BAJ_PT As Double
    Dim HS_AUSTEC_ALT_SU As Double
    Dim HS_AUSTEC_MED_SU As Double
    Dim HS_AUSTEC_BAJ_SU As Double
    Dim HS_AUSTEC_CO As Double
    Dim HS_AUSTEC As Double

    Dim HS_TECRET As Double

    Dim HS_AUSCUA_ALT_PT As Double
    Dim HS_AUSCUA_MED_PT As Double
    Dim HS_AUSCUA_BAJ_PT As Double
    Dim HS_AUSCUA_ALT_SU As Double
    Dim HS_AUSCUA_MED_SU As Double
    Dim HS_AUSCUA_BAJ_SU As Double
    Dim HS_AUSCUA_CO As Double
    Dim HS_AUSCUA As Double

    Dim HS_REALTEC_ALT_PT As Double
    Dim HS_REALTEC_MED_PT As Double
    Dim HS_REALTEC_BAJ_PT As Double
    Dim HS_REALTEC_ALT_SU As Double
    Dim HS_REALTEC_MED_SU As Double
    Dim HS_REALTEC_BAJ_SU As Double
    Dim HS_REALTEC_CO As Double
    Dim HS_REALTEC As Double

    Dim HS_REALCUA_ALT_PT As Double
    Dim HS_REALCUA_MED_PT As Double
    Dim HS_REALCUA_BAJ_PT As Double
    Dim HS_REALCUA_ALT_SU As Double
    Dim HS_REALCUA_MED_SU As Double
    Dim HS_REALCUA_BAJ_SU As Double
    Dim HS_REALCUA_CO As Double
    Dim HS_REALCUA As Double

    Dim HS_CLITEC_ALT_PT As Double
    Dim HS_CLITEC_MED_PT As Double
    Dim HS_CLITEC_BAJ_PT As Double
    Dim HS_CLITEC_ALT_SU As Double
    Dim HS_CLITEC_MED_SU As Double
    Dim HS_CLITEC_BAJ_SU As Double
    Dim HS_CLITEC_CO As Double
    Dim HS_CLITEC As Double

    Dim HS_CLICUA_ALT_PT As Double
    Dim HS_CLICUA_MED_PT As Double
    Dim HS_CLICUA_BAJ_PT As Double
    Dim HS_CLICUA_ALT_SU As Double
    Dim HS_CLICUA_MED_SU As Double
    Dim HS_CLICUA_BAJ_SU As Double
    Dim HS_CLICUA_CO As Double
    Dim HS_CLICUA As Double
    'Dim PERCENT_TEC As Double
    'Dim PERCENT_CUA As Double

    Dim CANT_TEC_PRES_ALT_PT As Integer
    Dim CANT_TEC_PRES_MED_PT As Integer
    Dim CANT_TEC_PRES_BAJ_PT As Integer
    Dim CANT_TEC_PRES_ALT_SU As Integer
    Dim CANT_TEC_PRES_MED_SU As Integer
    Dim CANT_TEC_PRES_BAJ_SU As Integer
    Dim CANT_TEC_PRES_CO As Integer

    Public CANT_TEC_ALT_TEOR_PT As Integer
    Public CANT_TEC_MED_TEOR_PT As Integer
    Public CANT_TEC_BAJ_TEOR_PT As Integer
    Public CANT_TEC_ALT_TEOR_SU As Integer
    Public CANT_TEC_MED_TEOR_SU As Integer
    Public CANT_TEC_BAJ_TEOR_SU As Integer
    Public CANT_TEC_TEOR_CO As Integer

    Dim CANT_TEC_ALT_FALT_PT As Integer
    Dim CANT_TEC_MED_FALT_PT As Integer
    Dim CANT_TEC_BAJ_FALT_PT As Integer
    Dim CANT_TEC_ALT_FALT_SU As Integer
    Dim CANT_TEC_MED_FALT_SU As Integer
    Dim CANT_TEC_BAJ_FALT_SU As Integer
    Dim CANT_TEC_FALT_CO As Integer

    Dim CANT_CUAD_PRES_ALT_PT As Integer
    Dim CANT_CUAD_PRES_MED_PT As Integer
    Dim CANT_CUAD_PRES_BAJ_PT As Integer
    Dim CANT_CUAD_PRES_ALT_SU As Integer
    Dim CANT_CUAD_PRES_MED_SU As Integer
    Dim CANT_CUAD_PRES_BAJ_SU As Integer
    Dim CANT_CUAD_PRES_CO As Integer

    Public CANT_CUAD_ALT_TEOR_PT As Integer
    Public CANT_CUAD_MED_TEOR_PT As Integer
    Public CANT_CUAD_BAJ_TEOR_PT As Integer
    Public CANT_CUAD_ALT_TEOR_SU As Integer
    Public CANT_CUAD_MED_TEOR_SU As Integer
    Public CANT_CUAD_BAJ_TEOR_SU As Integer
    Public CANT_CUAD_TEOR_CO As Integer

    Dim CANT_CUAD_ALT_FALT_PT As Integer
    Dim CANT_CUAD_MED_FALT_PT As Integer
    Dim CANT_CUAD_BAJ_FALT_PT As Integer
    Dim CANT_CUAD_ALT_FALT_SU As Integer
    Dim CANT_CUAD_MED_FALT_SU As Integer
    Dim CANT_CUAD_BAJ_FALT_SU As Integer
    Dim CANT_CUAD_FALT_CO As Integer

    Dim CANT_MINUTOS_TEC As Integer
    Dim CANT_MINUTOS_CUA As Integer
    Dim CANTIDAD_TEC As Integer
    Dim CANTIDAD_CUA As Integer

    Dim DATE1 As Date
    Dim DATE2 As Date
    Dim CLIINI As Date
    Dim CLIFIN As Date
    Dim TECNICOINI As Date
    Dim TECNICOFIN As Date

    Dim DIFERENCIA_AGENDA_ALTA(5) As Integer
    Dim DIFERENCIA_AGENDA_MEDIA(5) As Integer
    Dim DIFERENCIA_AGENDA_BAJA(5) As Integer
    Dim DISPONIBLE_AGENDA_ALTA(5) As Integer
    Dim DISPONIBLE_AGENDA_MEDIA(5) As Integer
    Dim DISPONIBLE_AGENDA_BAJA(5) As Integer

    Dim CANTMINUTOS_ALT_TEC_PT(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_PT(60) As Integer
    Dim CANTMINUTOS_MED_TEC_PT(60) As Integer
    Dim CANTMINUTOS_MED_CUA_PT(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_PT(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_PT(60) As Integer

    Dim CANTMINUTOS_ALT_TEC_SU(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_SU(60) As Integer
    Dim CANTMINUTOS_MED_TEC_SU(60) As Integer
    Dim CANTMINUTOS_MED_CUA_SU(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_SU(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_SU(60) As Integer

    Dim CANTMINUTOS_ALT_TEC_CO(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_CO(60) As Integer
    Dim CANTMINUTOS_MED_TEC_CO(60) As Integer
    Dim CANTMINUTOS_MED_CUA_CO(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_CO(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_CO(60) As Integer

    Dim CANTMINUTOS_ALT_TEC_PT_AGE(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_PT_AGE(60) As Integer
    Dim CANTMINUTOS_MED_TEC_PT_AGE(60) As Integer
    Dim CANTMINUTOS_MED_CUA_PT_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_PT_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_PT_AGE(60) As Integer

    Dim CANTMINUTOS_ALT_TEC_SU_AGE(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_SU_AGE(60) As Integer
    Dim CANTMINUTOS_MED_TEC_SU_AGE(60) As Integer
    Dim CANTMINUTOS_MED_CUA_SU_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_SU_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_SU_AGE(60) As Integer

    Dim CANTMINUTOS_ALT_TEC_CO_AGE(60) As Integer
    Dim CANTMINUTOS_ALT_CUA_CO_AGE(60) As Integer
    Dim CANTMINUTOS_MED_TEC_CO_AGE(60) As Integer
    Dim CANTMINUTOS_MED_CUA_CO_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_TEC_CO_AGE(60) As Integer
    Dim CANTMINUTOS_BAJ_CUA_CO_AGE(60) As Integer

    Public SEL_SECTOROPERATIVO As String
    Public SEL_SECTORGENERADOR As String
    Public SEL_PRIORIDAD As String
    Public SEL_FECHAORDEN As String
    Public SEL_ORDENORIG As Integer
    Public SEL_ORDENSELEC As Integer
    Public SEL_CANTORDENES As Integer
    Public SEL_CLASEDEP As String

    Public FIJA_DIAAGENDA_VIEJA As String
    Public FIJA_TIEMPOAGENDA_VIEJA As String
    Public DESAGEND_ORDEN(50) As Integer
    Dim CAPACIDADDIARow As ANALISIS_AGDataSet.CAPACIDAXDIARow
    Dim ORDENAAgendarROW As ORDENESDataSet.ORDENESRow
    Dim REGAUSENCIASRow As ANALISIS_AGDataSet.REG_AUSENCIASRow
    Dim MAPARow As DataRow
    Dim DISTRIBUCIONAGERow As ANALISIS_AGDataSet.DISTRIBUCION_AGENDARow
    Dim TECNICOSRow As DataRow
    Dim AUSENCIANEWRow As ANALISIS_AGDataSet.REG_AUSENCIASRow
    Dim GUARDIAROW As INDICESDataSet.GUARDIASRow
    Public REG_DIARIORow As ANALISIS_AGDataSet.REG_DIARIORow


    Public DIA_ENTRA As Date
    Public DIA_HORAS As Integer
    Public VIENE As Boolean
    Dim RECURSO_TEC As String
    Dim PRIORIDAD_TEC As String


    Private Sub FORMAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        'CREAR LOS MACACOS DE CANTIDAD DE TECNICOS



        If THEME_BLACK Then
            BackgroundImage = My.Resources.FAGENDA
            LBL_ACCIONAGENDA.BackColor = Color.FromArgb(64, 64, 64)
            Label18.BackColor = Color.FromArgb(64, 64, 64)
            LBL_CANTORDENES.BackColor = Color.FromArgb(64, 64, 64)
            LBL_CANTORDENES.ForeColor = Color.White
            Label16.BackColor = Color.FromArgb(64, 64, 64)
            LBL_NROORDENINT.BackColor = Color.FromArgb(64, 64, 64)
            LBL_NROORDENINT.ForeColor = Color.White
            Label19.BackColor = Color.FromArgb(64, 64, 64)
            ORD_AAGENDAR.BackColor = Color.FromArgb(64, 64, 64)
            ORD_AAGENDAR.ForeColor = Color.White
            Label15.BackColor = Color.FromArgb(64, 64, 64)
            CAP_ORDEN.BackColor = Color.FromArgb(64, 64, 64)
            CAP_ORDEN.ForeColor = Color.White
            P_LATERAL.BackColor = Color.FromArgb(64, 64, 64)
            LBL_SECTOR.BackColor = Color.FromArgb(64, 64, 64)
            BTN_FILL_TODOS.BackColor = Color.FromArgb(64, 64, 64)
            BTN_FILL_TODOS.ForeColor = Color.White
            BTN_FILL_PT.BackColor = Color.FromArgb(64, 64, 64)
            BTN_FILL_PT.ForeColor = Color.White
            BTN_FILL_SU.BackColor = Color.FromArgb(64, 64, 64)
            BTN_FILL_SU.ForeColor = Color.White
            BTN_FILL_COO.BackColor = Color.FromArgb(64, 64, 64)
            BTN_FILL_COO.ForeColor = Color.White
            LBL_REC.BackColor = Color.FromArgb(64, 64, 64)

            BTN_REC_TODOS.BackColor = Color.FromArgb(64, 64, 64)
            BTN_REC_TODOS.ForeColor = Color.White
            BTN_REC_TEC.BackColor = Color.FromArgb(64, 64, 64)
            BTN_REC_TEC.ForeColor = Color.White
            BTN_REC_CUA.BackColor = Color.FromArgb(64, 64, 64)
            BTN_REC_CUA.ForeColor = Color.White

            'CLIMA_PIC1.BackColor = Color.FromArgb(64, 64, 64)
            'CLIMA_PIC2.BackColor = Color.FromArgb(64, 64, 64)
            'CLIMA_PIC3.BackColor = Color.FromArgb(64, 64, 64)
            'CLIMA_PIC4.BackColor = Color.FromArgb(64, 64, 64)
            'CLIMA_PIC5.BackColor = Color.FromArgb(64, 64, 64)
            'LBL_DIA1.BackColor = Color.FromArgb(64, 64, 64)
            'LBL_DIA2.BackColor = Color.FromArgb(64, 64, 64)
            'LBL_DIA3.BackColor = Color.White
            'LBL_DIA4.BackColor = Color.White
            'LBL_DIA5.BackColor = Color.White
            'LBL_DIA01.BackColor = Color.White
            'LBL_DIA02.BackColor = Color.White
            'LBL_DIA03.BackColor = Color.White
            'LBL_DIA04.BackColor = Color.White
            'LBL_DIA05.BackColor = Color.White

        End If
        FECHAHOY = Today.ToShortDateString
        FECHAINI = Today.ToShortDateString
        FECHAFIN = DateAdd(DateInterval.Day, 4, FECHAHOY).Date
        Me.Refresh()

        Select Case ACCESO_AGENDA
            Case "FORM_AGENDAR"
                CAP_ORDEN.Text = TIEMPO_AGENDA
                LBL_NROORDENINT.Text = NROORDENINT
                LBL_CANTORDENES.Text = DATOS.CANT_ORDENESAAGENDAR
                ACCION_AGENDA = "AGENDAR"
                Select Case DATOS.SECTOR_CAP
                    Case "PT"
                        BTN_FILL_PT.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                    Case "SU"
                        BTN_FILL_SU.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                    Case "CO"
                        BTN_FILL_COO.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                End Select
                Select Case DATOS.RECURSO_CAP
                    Case "CUA"
                        BTN_REC_CUA.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                    Case "TEC"
                        BTN_REC_TEC.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                End Select
                BOT_CARGATEC.Visible = False
                BTN_CONTROLTECNICO.Visible = False
                BOT_PROCESARORD.Visible = False
                BOT_PARAMAGENDA.Visible = False
                BOT_CONTROLCUAD.Visible = False
                BOT_VERORDINAL.Visible = False
                BTN_REC_TODOS.Enabled = False
                BTN_FILL_TODOS.Enabled = False
                BTN_PROCESAMIENTO.Visible = False
                BTN_REASIGNAR_CAP.Visible = False
                BTN_GUARDIAS.Visible = False

                BTN_SALIR.Visible = True
                Label18.Visible = True
                LBL_CANTORDENES.Visible = True
                Label15.Visible = True
                CAP_ORDEN.Visible = True
                Label16.Visible = True
                LBL_NROORDENINT.Visible = True
                Label19.Visible = True
                ORD_AAGENDAR.Visible = True
                For X = 0 To DATOS.CANT_ORDENESAAGENDAR - 1
                    ORD_AAGENDAR.Text += DATOS.ORDEN_EST(X).ToString
                    If X <> DATOS.CANT_ORDENESAAGENDAR - 1 Then
                        ORD_AAGENDAR.Text += vbNewLine
                    End If
                Next

            Case "FORM_INICIO"
                CAP_ORDEN.Text = 0
                LBL_NROORDENINT.Text = 0
                LBL_TIPODEP.Text = ""
                LBL_CANTORDENES.Text = 0
                DATOS.SECTOR_CAP = "TODOS"
                DATOS.RECURSO_CAP = "TODOS"
                ACCION_AGENDA = "VER AGENDA"
                BTN_REC_TODOS.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                BTN_FILL_TODOS.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
                BTN_FILL_TODOS.BackgroundImageLayout = ImageLayout.Stretch
                BTN_REC_TODOS.BackgroundImageLayout = ImageLayout.Stretch
        End Select

        LBL_ACCIONAGENDA.Text = ACCION_AGENDA
        DASHBOARD.Cursor = DefaultCursor
        CALENDARIO(True, Today.Month, Today.Year)
        MES_INI = Today.Month
        AÑO_INI = Today.Year
        MOSTRAR_AGENDA(Today.ToShortDateString, Today.AddDays(4).ToShortDateString)
    End Sub
    'CALENDARIO
    Private Sub CALENDARIO(ByVal CREAR As Boolean, ByVal MES_CALENDARIO As Integer, ByVal AÑO_CALENDARIO As Integer)

        Dim MES As Integer = MES_CALENDARIO
        Dim AÑO As Integer = AÑO_CALENDARIO
        Dim dia1 As Integer
        Dim DIA_MES As Integer = 0
        Dim POSX_DIA As Integer = 20
        Dim POSY_DIA As Integer = 92
        Dim primerDia As Date = DateSerial(AÑO, MES, 1)
        Dim ultimoDia As Integer = DateSerial(AÑO, MES + 1, 0).Day
        LBL_AÑO.Text = AÑO_CALENDARIO
        LBL_MES.Text = primerDia.ToString("MMMM")

        'CORREGIMOS QUE DIA EMPIEZA EL CALENDARIO
        Select Case (primerDia.ToString("dddd").ToUpper)
            Case "DOMINGO"
                dia1 = 1
                POSX_DIA = POSX_DIA
            Case "LUNES"
                dia1 = 2
                POSX_DIA = 51
            Case "MARTES"
                dia1 = 3
                POSX_DIA = 41 * 2
            Case "MIÉRCOLES"
                dia1 = 4
                POSX_DIA = (38 * 3) - 1
            Case "JUEVES"
                dia1 = 5
                POSX_DIA = 36 * 4
            Case "VIERNES"
                dia1 = 6
                POSX_DIA += 31 * 5
            Case "SÁBADO"
                dia1 = 7
                POSX_DIA += 31 * 6
        End Select
        If THEME_BLACK Then
            P_CALENDARIO.ForeColor = Color.White
            P_CALENDARIO.BackColor = Color.FromArgb(64, 64, 64)
            CAL_ATRAZA_AÑO.ForeColor = Color.White
            CAL_AVANZA_AÑO.ForeColor = Color.White
            LBL_AÑO.ForeColor = Color.White
            CAL_ATRAZA_MES.ForeColor = Color.White
            CAL_AVANZA_MES.ForeColor = Color.White
            LBL_MES.ForeColor = Color.White
            DOM.ForeColor = Color.White
            LUN.ForeColor = Color.White
            MAR.ForeColor = Color.White
            MIER.ForeColor = Color.White
            JUEV.ForeColor = Color.White
            VIE.ForeColor = Color.White
            SAB.ForeColor = Color.White
        Else
            P_CALENDARIO.ForeColor = Color.FromArgb(64, 64, 64)
            P_CALENDARIO.BackColor = Color.White
            CAL_ATRAZA_AÑO.ForeColor = Color.FromArgb(64, 64, 64)
            CAL_AVANZA_AÑO.ForeColor = Color.FromArgb(64, 64, 64)
            LBL_AÑO.ForeColor = Color.FromArgb(64, 64, 64)
            CAL_ATRAZA_MES.ForeColor = Color.FromArgb(64, 64, 64)
            CAL_AVANZA_MES.ForeColor = Color.FromArgb(64, 64, 64)
            LBL_MES.ForeColor = Color.FromArgb(64, 64, 64)
            BTN_HOY.ForeColor = Color.FromArgb(64, 64, 64)
        End If
        'ASIGNA UBICACION Y ESTILO A CADA BOTON
        If CREAR Then
            For D = dia1 To 42
                Select Case D
                    Case 8
                        POSX_DIA = 20
                        POSY_DIA = POSY_DIA + 31
                    Case 15
                        POSX_DIA = 20
                        POSY_DIA = POSY_DIA + 31
                    Case 22
                        POSX_DIA = 20
                        POSY_DIA = POSY_DIA + 31
                    Case 29
                        POSX_DIA = 20
                        POSY_DIA = POSY_DIA + 31
                    Case 36
                        POSX_DIA = 20
                        POSY_DIA = POSY_DIA + 31
                End Select
                BTN_CALENDARIO_DIA(D) = New Button()
                BTN_CALENDARIO_DIA(D).Location = New Point(POSX_DIA, POSY_DIA)
                BTN_CALENDARIO_DIA(D).Size = New Size(30, 30)
                BTN_CALENDARIO_DIA(D).Font = New Font(BTN_CALENDARIO_DIA(D).Font.Name, 8, FontStyle.Bold)

                DIA_MES += 1
                If DIA_MES = ultimoDia + 1 Then
                    DIA_MES = 1
                    MES = primerDia.AddMonths(1).Month
                    AÑO = primerDia.AddMonths(1).Year
                    BTN_CALENDARIO_DIA(D).Font = New Font(BTN_CALENDARIO_DIA(D).Font.Name, 8)
                    BTN_CALENDARIO_DIA(D).Name = DIA_MES & "/" & MES & "/" & AÑO
                End If
                If MES <> primerDia.Month Then
                    BTN_CALENDARIO_DIA(D).Font = New Font(BTN_CALENDARIO_DIA(D).Font.Name, 8)
                    BTN_CALENDARIO_DIA(D).Name = DIA_MES & "/" & MES & "/" & AÑO
                End If
                If THEME_BLACK Then
                    BTN_CALENDARIO_DIA(D).ForeColor = Color.White
                    BTN_CALENDARIO_DIA(D).BackColor = Color.FromArgb(64, 64, 64)
                Else
                    BTN_CALENDARIO_DIA(D).ForeColor = Color.FromArgb(64, 64, 64)
                    BTN_CALENDARIO_DIA(D).BackColor = Color.White
                End If

                BTN_CALENDARIO_DIA(D).FlatStyle = FlatStyle.Flat
                BTN_CALENDARIO_DIA(D).FlatAppearance.BorderSize = 0
                BTN_CALENDARIO_DIA(D).FlatAppearance.BorderColor = Color.White 'FromArgb(64, 64, 64)
                BTN_CALENDARIO_DIA(D).FlatAppearance.MouseDownBackColor = Color.DimGray
                BTN_CALENDARIO_DIA(D).FlatAppearance.MouseOverBackColor = Color.Gray
                BTN_CALENDARIO_DIA(D).Name = DIA_MES & "/" & MES & "/" & AÑO
                BTN_CALENDARIO_DIA(D).Text = DIA_MES
                If ACCION_AGENDA = "PROCESAR" Then
                    If CDate(DIA_MES & "/" & MES & "/" & AÑO) = Today Then
                        BTN_CALENDARIO_DIA(D).BackColor = Color.DarkBlue
                        BTN_CALENDARIO_DIA(D).ForeColor = Color.White
                    End If

                Else
                    If CDate(DIA_MES & "/" & MES & "/" & AÑO) >= Today And CDate(DIA_MES & "/" & MES & "/" & AÑO) <= Today.AddDays(4) Then
                        BTN_CALENDARIO_DIA(D).BackColor = Color.DarkBlue
                        BTN_CALENDARIO_DIA(D).ForeColor = Color.White
                    End If
                End If
                AddHandler BTN_CALENDARIO_DIA(D).MouseDown, AddressOf BTN_CALENDARIO_DIA_Click
                P_CALENDARIO.Controls.Add(BTN_CALENDARIO_DIA(D))
                POSX_DIA += 31
            Next
        Else
            For D = 0 To 42
                P_CALENDARIO.Controls.Remove(BTN_CALENDARIO_DIA(D))
            Next
        End If

    End Sub
    Private Sub BTN_CALENDARIO_DIA_Click(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        CRTL_BTN = DirectCast(sender, Control)
        If IsDate(CRTL_BTN.Name) Then
            If e.Clicks = 1 Then
                Select Case ACCION_AGENDA
                    Case "AGENDAR", "REAGENDAR", "REASIGNAR", "VER AGENDA"
                        BORRA_BOTONES()
                        Select Case FIJA_DIA
                            Case False
                                For X = 1 To 42
                                    Try
                                        BTN_CALENDARIO_DIA(X).BackColor = Color.White
                                        BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)
                                        If Today.ToShortDateString = CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString Then
                                            BTN_CALENDARIO_DIA(X).BackColor = Color.LightGreen
                                        End If
                                        If BTN_CALENDARIO_DIA(X).Name = CRTL_BTN.Name Then
                                            BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                                            BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                                        End If
                                    Catch ex As Exception
                                    End Try
                                Next
                                FECHAINI = CRTL_BTN.Name
                                FECHAFIN = CRTL_BTN.Name
                                MOSTRAR_AGENDA(CRTL_BTN.Name, CRTL_BTN.Name)
                            Case True
                                If FECHAINI > CRTL_BTN.Name Then
                                    For X = 1 To 42
                                        Try
                                            BTN_CALENDARIO_DIA(X).BackColor = Color.White
                                            BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)
                                            If Today.ToShortDateString = CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString Then
                                                BTN_CALENDARIO_DIA(X).BackColor = Color.LightGreen
                                            End If
                                            If Format(CDate(BTN_CALENDARIO_DIA(X).Name), "yyyyMMdd") >= Format(CDate(CRTL_BTN.Name), "yyyyMMdd") And Format(CDate(BTN_CALENDARIO_DIA(X).Name), "yyyyMMdd") <= Format(CDate(FECHAINI), "yyyyMMdd") Then
                                                BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                                                BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                                            End If
                                        Catch ex As Exception
                                        End Try
                                    Next
                                    FECHAFIN = FECHAINI
                                    FECHAINI = CRTL_BTN.Name
                                    MOSTRAR_AGENDA(CRTL_BTN.Name, FECHAINI)
                                Else
                                    For X = 1 To 42
                                        Try
                                            BTN_CALENDARIO_DIA(X).BackColor = Color.White
                                            BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)
                                            If Today.ToShortDateString = CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString Then
                                                BTN_CALENDARIO_DIA(X).BackColor = Color.LightGreen
                                            End If
                                            If Format(CDate(BTN_CALENDARIO_DIA(X).Name), "yyyyMMdd") <= Format(CDate(CRTL_BTN.Name), "yyyyMMdd") And Format(CDate(BTN_CALENDARIO_DIA(X).Name), "yyyyMMdd") >= Format(CDate(FECHAINI), "yyyyMMdd") Then
                                                BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                                                BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    MOSTRAR_AGENDA(FECHAINI, CRTL_BTN.Name)
                                    FECHAFIN = CRTL_BTN.Name
                                End If
                                FIJA_DIA = False
                        End Select
                    Case "CAP_TECNICA"
                        For X = 1 To 42
                            Try
                                BTN_CALENDARIO_DIA(X).BackColor = Color.White
                                BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)
                                If Today.ToShortDateString = CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString Then
                                    BTN_CALENDARIO_DIA(X).BackColor = Color.LightGreen
                                End If
                                If BTN_CALENDARIO_DIA(X).Name = CRTL_BTN.Name Then
                                    BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                                    BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                                End If
                            Catch ex As Exception
                            End Try
                        Next
                        FECHAINI = CRTL_BTN.Name
                        ACTUALIZAR_CAMBIODIA()
                End Select
            Else
                BORRA_BOTONES()
                For X = 1 To 42
                    Try
                        BTN_CALENDARIO_DIA(X).BackColor = Color.White
                        BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)

                        If Today.ToShortDateString = CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString Then
                            BTN_CALENDARIO_DIA(X).BackColor = Color.LightGreen
                        End If
                        If BTN_CALENDARIO_DIA(X).Name = CRTL_BTN.Name Then
                            BTN_CALENDARIO_DIA(X).BackColor = Color.Blue
                            BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                        End If
                    Catch ex As Exception
                    End Try
                Next
                FECHAINI = CRTL_BTN.Name
                FIJA_DIA = True
            End If
        End If
    End Sub
    Private Sub CAL_AVANZA_MES_Click(sender As Object, e As EventArgs) Handles CAL_AVANZA_MES.Click
        If MES_INI = 12 Then
            MES_INI = 1
            AÑO_INI += 1
        Else
            MES_INI += 1
        End If
        CALENDARIO(False, MES_INI, AÑO_INI)
        CALENDARIO(True, MES_INI, AÑO_INI)
    End Sub
    Private Sub CAL_ATRAZA_MES_Click(sender As Object, e As EventArgs) Handles CAL_ATRAZA_MES.Click
        If MES_INI = 1 Then
            MES_INI = 12
            AÑO_INI -= 1
        Else
            MES_INI -= 1
        End If
        CALENDARIO(False, MES_INI, AÑO_INI)
        CALENDARIO(True, MES_INI, AÑO_INI)
    End Sub
    Private Sub CAL_AVANZA_AÑO_Click(sender As Object, e As EventArgs) Handles CAL_AVANZA_AÑO.Click
        AÑO_INI += 1
        CALENDARIO(False, MES_INI, AÑO_INI)
        CALENDARIO(True, MES_INI, AÑO_INI)
    End Sub
    Private Sub CAL_ATRAZA_AÑO_Click(sender As Object, e As EventArgs) Handles CAL_ATRAZA_AÑO.Click
        AÑO_INI -= 1
        CALENDARIO(False, MES_INI, AÑO_INI)
        CALENDARIO(True, MES_INI, AÑO_INI)
    End Sub
    Private Sub BTN_HOY_Click(sender As Object, e As EventArgs) Handles BTN_HOY.Click
        AÑO_INI = Today.Year
        MES_INI = Today.Month
        CALENDARIO(False, MES_INI, AÑO_INI)
        CALENDARIO(True, MES_INI, AÑO_INI)
        FECHAINI = Today.ToShortDateString
        FECHAFIN = Today.AddDays(4).ToShortDateString
        MOSTRAR_AGENDA(Today.ToShortDateString, Today.AddDays(4).ToShortDateString)

    End Sub
    'FIN CALENDARIO
    Public Sub MOSTRAR_AGENDA(ByVal FECHAINI As Date, ByVal FECHAFIN As Date)
        CAPACIDAXDIATableAdapter.FillByENTREFECHAS(ANALISIS_AGDataSet.CAPACIDAXDIA, FECHAINI, FECHAFIN)
        CLIMATableAdapter.FillByCLIMA_ENTRE_FECHAS(INDICESDataSet.CLIMA, FECHAINI, FECHAFIN)

        Try
            For X = 0 To 539
                Me.Controls.Remove(TEC_DIA(X))
            Next
        Catch ex As Exception
        End Try
        If ANALISIS_AGDataSet.CAPACIDAXDIA.Rows.Count < 5 Then
            COLUMN_A_MOSTRAR = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows.Count
        Else
            COLUMN_A_MOSTRAR = 5
        End If
        For C = 1 To COLUMN_A_MOSTRAR

            Select Case C
                Case 1
                    If THEME_BLACK = False Then
                        PIC1.BackColor = Color.White
                        P1.BackColor = Color.White
                        P6.BackColor = Color.White
                        P11.BackColor = Color.White
                        CLIMA_PIC1.BackColor = Color.White
                        LBL_DIA1.BackColor = Color.White
                        LBL_DIA01.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_DIA1.ForeColor = Color.FromArgb(64, 64, 64)
                        CAP_DIA1.BackColor = Color.LightGray
                        CAP_DIA6.BackColor = Color.LightGray
                        CAP_DIA11.BackColor = Color.LightGray
                        LBL_PORCENT_DIA1.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA1.BackColor = Color.White
                        LBL_PORCENT_DIA6.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA6.BackColor = Color.White
                        LBL_PORCENT_DIA11.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA11.BackColor = Color.White
                        LBL_PORC1.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC1.BackColor = Color.White
                        LBL_PORC6.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC6.BackColor = Color.White
                        LBL_PORC11.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC11.BackColor = Color.White
                        LBL_OCUPACION1.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION1.BackColor = Color.White
                        LBL_OCUPACION6.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION6.BackColor = Color.White
                        LBL_OCUPACION11.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION11.BackColor = Color.White
                        LBL_ACCIONAGENDA.BackColor = Color.White
                    Else
                        'LBL_DIA1.ForeColor = Color.White
                        'LBL_DIA01.ForeColor = Color.White
                        'PIC1.BackColor = Color.FromArgb(64, 64, 64)
                        'CLIMA_PIC1.BackColor = Color.FromArgb(64, 64, 64)
                    End If
                    CAPACIDADRow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
                    DIA = 1
                    CARGAR_VARIABLES()

                    P1.Visible = True
                    P6.Visible = True
                    P11.Visible = True
                    PIC1.Visible = True
                    CLIMA_PIC1.Visible = True

                    LBL_DIA1.Visible = True
                    LBL_DIA01.Visible = True
                    CAP_DIA1.Visible = True
                    AGE_DIA1.Visible = True
                    DIS_DIA1.Visible = True
                    LBL_OCUPACION1.Visible = True
                    LBL_PORC1.Visible = True
                    LBL_PORCENT_DIA1.Visible = True

                    CAP_DIA6.Visible = True
                    AGE_DIA6.Visible = True
                    DIS_DIA6.Visible = True
                    LBL_OCUPACION6.Visible = True
                    LBL_PORC6.Visible = True
                    LBL_PORCENT_DIA6.Visible = True

                    CAP_DIA11.Visible = True
                    AGE_DIA11.Visible = True
                    DIS_DIA11.Visible = True
                    LBL_OCUPACION11.Visible = True
                    LBL_PORC11.Visible = True
                    LBL_PORCENT_DIA11.Visible = True

                    LBL_DIA1.Text = FECHAINI.AddDays(0).ToShortDateString
                    LBL_DIA01.Text = FECHAINI.AddDays(0).ToString("dddd").ToUpper
                    Select Case FECHAINI.ToString("dddd").ToUpper
                        Case "SÁBADO", "DOMINGO"
                            LBL_DIA1.ForeColor = Color.Red
                            LBL_DIA01.ForeColor = Color.Red
                    End Select
                    If INDICESDataSet.CLIMA.Rows.Count > 0 Then
                        CLIMA_PIC1.BackgroundImage = My.Resources.ResourceManager.GetObject(INDICESDataSet.CLIMA.Rows(0).Item("CLIMA_CODIGO_LOGO"))
                    Else
                        CLIMA_PIC1.BackgroundImage = Nothing
                    End If

                    CAP_DIA1.Text = CAP_DIA_ALTA
                    AGE_DIA1.Text = AGE_DIA_ALTA
                    DIS_DIA1.Text = DIS_DIA_ALTA

                    POSX = 209 + (158 * C)
                    POSY = 105
                    If CAP_DIA1.Text <> 0 Then
                        CAP_DIA1.Size = New Size(115, 15)
                        If CAP_DIA1.Size.Width >= (115 * CDbl(AGE_DIA1.Text) / CDbl(CAP_DIA1.Text)) Then
                            AGE_DIA1.Size = New Size((115) * CDbl(AGE_DIA1.Text) / CDbl(CAP_DIA1.Text), 15)
                        Else
                            AGE_DIA1.Size = New Size(115, 15)
                        End If
                        DIS_DIA1.Size = New Size((115) * CDbl(DIS_DIA1.Text) / CDbl(CAP_DIA1.Text), 15)

                        LBL_PORCENT_DIA1.Text = CInt(CDbl(AGE_DIA1.Text) * 100 / CDbl(CAP_DIA1.Text))
                        LBL_PORC1.Text = "%"
                        LBL_OCUPACION1.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_ALTA / 450)
                        If CAP_DIA_ALTA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 1 & X) = New PictureBox()
                                TEC_DIA(C & 1 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 1 & X).BackColor = Color.White
                                TEC_DIA(C & 1 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 1 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 1 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 1 & X))
                                TEC_DIA(C & 1 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA1.Size = New Size(30, 15)
                        If AGE_DIA1.Text <> 0 Then
                            AGE_DIA1.Size = New Size(30, 15)
                        Else
                            AGE_DIA1.Size = New Size(15, 15)
                        End If
                        DIS_DIA1.Visible = False
                        LBL_PORCENT_DIA1.Text = ""
                        LBL_PORC1.Text = ""
                        LBL_OCUPACION1.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA1.Location = New Point(AGE_DIA1.Location.X + AGE_DIA1.Size.Width, AGE_DIA1.Location.Y)

                    CAP_DIA6.Text = CAP_DIA_MEDIA
                    AGE_DIA6.Text = AGE_DIA_MEDIA
                    DIS_DIA6.Text = DIS_DIA_MEDIA
                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA6.Text <> 0 Then
                        CAP_DIA6.Size = New Size(115, 15)
                        If CAP_DIA6.Size.Width >= (115 * CDbl(AGE_DIA6.Text) / CDbl(CAP_DIA6.Text)) Then
                            AGE_DIA6.Size = New Size((115) * CDbl(AGE_DIA6.Text) / CDbl(CAP_DIA6.Text), 15)
                        Else
                            AGE_DIA6.Size = New Size(115, 15)
                        End If
                        DIS_DIA6.Size = New Size((115) * CDbl(DIS_DIA6.Text) / CDbl(CAP_DIA6.Text), 15)

                        LBL_PORCENT_DIA6.Text = CInt(CDbl(AGE_DIA6.Text) * 100 / CDbl(CAP_DIA6.Text))
                        LBL_PORC6.Text = "%"
                        LBL_OCUPACION6.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_MEDIA / 450)
                        If CAP_DIA_MEDIA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 2 & X) = New PictureBox()
                                TEC_DIA(C & 2 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 2 & X).BackColor = Color.White
                                TEC_DIA(C & 2 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 2 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 2 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 2 & X))
                                TEC_DIA(C & 2 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA6.Size = New Size(30, 15)
                        If AGE_DIA6.Text <> 0 Then
                            AGE_DIA6.Size = New Size(30, 15)
                        Else
                            AGE_DIA6.Size = New Size(15, 15)
                        End If
                        DIS_DIA6.Visible = False
                        LBL_PORCENT_DIA6.Text = ""
                        LBL_PORC6.Text = ""
                        LBL_OCUPACION6.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA6.Location = New Point(AGE_DIA6.Location.X + AGE_DIA6.Size.Width, AGE_DIA6.Location.Y)

                    CAP_DIA11.Text = CAP_DIA_BAJA
                    AGE_DIA11.Text = AGE_DIA_BAJA
                    DIS_DIA11.Text = DIS_DIA_BAJA
                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA11.Text <> 0 Then
                        CAP_DIA11.Size = New Size(115, 15)
                        If CAP_DIA11.Size.Width >= (115 * CDbl(AGE_DIA11.Text) / CDbl(CAP_DIA11.Text)) Then
                            AGE_DIA11.Size = New Size((115) * CDbl(AGE_DIA11.Text) / CDbl(CAP_DIA11.Text), 15)
                        Else
                            AGE_DIA11.Size = New Size(115, 15)
                        End If
                        DIS_DIA11.Size = New Size((115) * CDbl(DIS_DIA11.Text) / CDbl(CAP_DIA11.Text), 15)

                        LBL_PORCENT_DIA11.Text = CInt(CDbl(AGE_DIA11.Text) * 100 / CDbl(CAP_DIA11.Text))
                        LBL_PORC11.Text = "%"
                        LBL_OCUPACION11.Text = "OCUPACION DEL:"

                        CANT_TECNICOS_DIA = CInt(CAP_DIA_BAJA / 450)
                        If CAP_DIA_BAJA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 3 & X) = New PictureBox()
                                TEC_DIA(C & 3 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 3 & X).BackColor = Color.White
                                TEC_DIA(C & 3 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 3 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 3 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 3 & X))
                                TEC_DIA(C & 3 & X).BringToFront()
                            End If
                        Next
                    Else

                        CAP_DIA11.Size = New Size(30, 15)
                        If AGE_DIA11.Text <> 0 Then
                            AGE_DIA11.Size = New Size(30, 15)
                        Else
                            AGE_DIA11.Size = New Size(15, 15)
                        End If
                        DIS_DIA11.Visible = False
                        LBL_PORCENT_DIA11.Text = ""
                        LBL_PORC11.Text = ""
                        LBL_OCUPACION11.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA11.Location = New Point(AGE_DIA11.Location.X + AGE_DIA11.Size.Width, AGE_DIA11.Location.Y)



                Case 2
                    If THEME_BLACK = False Then
                        PIC2.BackColor = Color.White
                        P2.BackColor = Color.White
                        P7.BackColor = Color.White
                        P12.BackColor = Color.White
                        CLIMA_PIC2.BackColor = Color.White
                        LBL_DIA2.BackColor = Color.White
                        LBL_DIA2.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_DIA02.ForeColor = Color.FromArgb(64, 64, 64)
                        CAP_DIA2.BackColor = Color.LightGray
                        CAP_DIA7.BackColor = Color.LightGray
                        CAP_DIA12.BackColor = Color.LightGray
                        LBL_PORCENT_DIA2.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA2.BackColor = Color.White
                        LBL_PORCENT_DIA7.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA7.BackColor = Color.White
                        LBL_PORCENT_DIA12.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA12.BackColor = Color.White
                        LBL_PORC2.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC2.BackColor = Color.White
                        LBL_PORC7.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC7.BackColor = Color.White
                        LBL_PORC12.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC12.BackColor = Color.White
                        LBL_OCUPACION2.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION2.BackColor = Color.White
                        LBL_OCUPACION7.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION7.BackColor = Color.White
                        LBL_OCUPACION12.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION12.BackColor = Color.White
                    Else
                        'LBL_DIA2.ForeColor = Color.White
                        'LBL_DIA02.ForeColor = Color.White
                        'PIC2.BackColor = Color.FromArgb(64, 64, 64)
                        'CLIMA_PIC2.BackColor = Color.FromArgb(64, 64, 64)
                    End If
                    CAPACIDADRow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(1)
                    DIA = 2
                    CARGAR_VARIABLES()
                    P2.Visible = True
                    P7.Visible = True
                    P12.Visible = True
                    PIC2.Visible = True
                    CLIMA_PIC2.Visible = True

                    LBL_DIA2.Visible = True
                    LBL_DIA02.Visible = True
                    CAP_DIA2.Visible = True
                    AGE_DIA2.Visible = True
                    DIS_DIA2.Visible = True
                    LBL_OCUPACION2.Visible = True
                    LBL_PORC2.Visible = True
                    LBL_PORCENT_DIA2.Visible = True

                    CAP_DIA7.Visible = True
                    AGE_DIA7.Visible = True
                    DIS_DIA7.Visible = True
                    LBL_OCUPACION7.Visible = True
                    LBL_PORC7.Visible = True
                    LBL_PORCENT_DIA7.Visible = True

                    CAP_DIA12.Visible = True
                    AGE_DIA12.Visible = True
                    DIS_DIA12.Visible = True
                    LBL_OCUPACION12.Visible = True
                    LBL_PORC12.Visible = True
                    LBL_PORCENT_DIA12.Visible = True

                    LBL_DIA2.Text = FECHAINI.AddDays(1).ToShortDateString
                    LBL_DIA02.Text = FECHAINI.AddDays(1).ToString("dddd").ToUpper
                    Select Case FECHAINI.AddDays(1).ToString("dddd").ToUpper
                        Case "SÁBADO", "DOMINGO"
                            LBL_DIA2.ForeColor = Color.Red
                            LBL_DIA02.ForeColor = Color.Red
                    End Select
                    If INDICESDataSet.CLIMA.Rows.Count > 1 Then
                        CLIMA_PIC2.BackgroundImage = My.Resources.ResourceManager.GetObject(INDICESDataSet.CLIMA.Rows(1).Item("CLIMA_CODIGO_LOGO"))
                    Else
                        CLIMA_PIC2.BackgroundImage = Nothing
                    End If

                    CAP_DIA2.Text = CAP_DIA_ALTA
                    AGE_DIA2.Text = AGE_DIA_ALTA
                    DIS_DIA2.Text = DIS_DIA_ALTA
                    POSX = 209 + (158 * C)
                    POSY = 105
                    If CAP_DIA2.Text <> 0 Then
                        CAP_DIA2.Size = New Size(115, 15)
                        If CAP_DIA2.Size.Width >= (115 * CDbl(AGE_DIA2.Text) / CDbl(CAP_DIA2.Text)) Then
                            AGE_DIA2.Size = New Size((115) * CDbl(AGE_DIA2.Text) / CDbl(CAP_DIA2.Text), 15)
                        Else
                            AGE_DIA2.Size = New Size(115, 15)
                        End If
                        DIS_DIA2.Size = New Size((115) * CDbl(DIS_DIA2.Text) / CDbl(CAP_DIA2.Text), 15)

                        LBL_PORCENT_DIA2.Text = CInt(CDbl(AGE_DIA2.Text) * 100 / CDbl(CAP_DIA2.Text))
                        LBL_PORC2.Text = "%"
                        LBL_OCUPACION2.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_ALTA / 450)
                        If CAP_DIA_ALTA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 1 & X) = New PictureBox()
                                TEC_DIA(C & 1 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 1 & X).BackColor = Color.White
                                TEC_DIA(C & 1 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 1 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 1 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 1 & X))
                                TEC_DIA(C & 1 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA2.Size = New Size(30, 15)
                        If AGE_DIA2.Text <> 0 Then
                            AGE_DIA2.Size = New Size(30, 15)
                        Else
                            AGE_DIA2.Size = New Size(15, 15)
                        End If
                        DIS_DIA2.Visible = False
                        LBL_PORCENT_DIA2.Text = ""
                        LBL_PORC2.Text = ""
                        LBL_OCUPACION2.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA2.Location = New Point(AGE_DIA2.Location.X + AGE_DIA2.Size.Width, AGE_DIA2.Location.Y)

                    CAP_DIA7.Text = CAP_DIA_MEDIA
                    AGE_DIA7.Text = AGE_DIA_MEDIA
                    DIS_DIA7.Text = DIS_DIA_MEDIA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA7.Text <> 0 Then
                        CAP_DIA7.Size = New Size(115, 15)
                        If CAP_DIA7.Size.Width >= (115 * CDbl(AGE_DIA7.Text) / CDbl(CAP_DIA7.Text)) Then
                            AGE_DIA7.Size = New Size((115) * CDbl(AGE_DIA7.Text) / CDbl(CAP_DIA7.Text), 15)
                        Else
                            AGE_DIA7.Size = New Size(115, 15)
                        End If
                        DIS_DIA7.Size = New Size((115) * CDbl(DIS_DIA7.Text) / CDbl(CAP_DIA7.Text), 15)

                        LBL_PORCENT_DIA7.Text = CInt(CDbl(AGE_DIA7.Text) * 100 / CDbl(CAP_DIA7.Text))
                        LBL_PORC7.Text = "%"
                        LBL_OCUPACION7.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_MEDIA / 450)
                        If CAP_DIA_MEDIA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 2 & X) = New PictureBox()
                                TEC_DIA(C & 2 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 2 & X).BackColor = Color.White
                                TEC_DIA(C & 2 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 2 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 2 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 2 & X))
                                TEC_DIA(C & 2 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA7.Size = New Size(30, 15)
                        If AGE_DIA7.Text <> 0 Then
                            AGE_DIA7.Size = New Size(30, 15)
                        Else
                            AGE_DIA7.Size = New Size(15, 15)
                        End If
                        DIS_DIA7.Visible = False
                        LBL_PORCENT_DIA7.Text = ""
                        LBL_PORC7.Text = ""
                        LBL_OCUPACION7.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA7.Location = New Point(AGE_DIA7.Location.X + AGE_DIA7.Size.Width, AGE_DIA7.Location.Y)

                    CAP_DIA12.Text = CAP_DIA_BAJA
                    AGE_DIA12.Text = AGE_DIA_BAJA
                    DIS_DIA12.Text = DIS_DIA_BAJA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA12.Text <> 0 Then
                        CAP_DIA12.Size = New Size(115, 15)
                        If CAP_DIA12.Size.Width >= (115 * CDbl(AGE_DIA12.Text) / CDbl(CAP_DIA12.Text)) Then
                            AGE_DIA12.Size = New Size((115) * CDbl(AGE_DIA12.Text) / CDbl(CAP_DIA12.Text), 15)
                        Else
                            AGE_DIA12.Size = New Size(115, 15)
                        End If
                        DIS_DIA12.Size = New Size((115) * CDbl(DIS_DIA12.Text) / CDbl(CAP_DIA12.Text), 15)

                        LBL_PORCENT_DIA12.Text = CInt(CDbl(AGE_DIA12.Text) * 100 / CDbl(CAP_DIA12.Text))
                        LBL_PORC12.Text = "%"
                        LBL_OCUPACION12.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_BAJA / 450)
                        If CAP_DIA_BAJA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 3 & X) = New PictureBox()
                                TEC_DIA(C & 3 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 3 & X).BackColor = Color.White
                                TEC_DIA(C & 3 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 3 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 3 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 3 & X))
                                TEC_DIA(C & 3 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA12.Size = New Size(30, 15)
                        If AGE_DIA12.Text <> 0 Then
                            AGE_DIA12.Size = New Size(30, 15)
                        Else
                            AGE_DIA12.Size = New Size(15, 15)
                        End If
                        DIS_DIA12.Visible = False
                        LBL_PORCENT_DIA12.Text = ""
                        LBL_PORC12.Text = ""
                        LBL_OCUPACION12.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA12.Location = New Point(AGE_DIA12.Location.X + AGE_DIA12.Size.Width, AGE_DIA12.Location.Y)
                Case 3
                    If THEME_BLACK = False Then
                        PIC3.BackColor = Color.White
                        P3.BackColor = Color.White
                        P8.BackColor = Color.White
                        P13.BackColor = Color.White
                        CLIMA_PIC3.BackColor = Color.White
                        LBL_DIA3.BackColor = Color.White
                        LBL_DIA3.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_DIA03.ForeColor = Color.FromArgb(64, 64, 64)
                        CAP_DIA3.BackColor = Color.LightGray
                        CAP_DIA8.BackColor = Color.LightGray
                        CAP_DIA13.BackColor = Color.LightGray
                        LBL_PORCENT_DIA3.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA3.BackColor = Color.White
                        LBL_PORCENT_DIA8.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA8.BackColor = Color.White
                        LBL_PORCENT_DIA13.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA13.BackColor = Color.White
                        LBL_PORC3.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC3.BackColor = Color.White
                        LBL_PORC8.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC8.BackColor = Color.White
                        LBL_PORC13.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC13.BackColor = Color.White
                        LBL_OCUPACION3.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION3.BackColor = Color.White
                        LBL_OCUPACION8.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION8.BackColor = Color.White
                        LBL_OCUPACION13.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION13.BackColor = Color.White
                    Else
                        'LBL_DIA3.ForeColor = Color.White
                        'LBL_DIA03.ForeColor = Color.White
                        'PIC3.BackColor = Color.FromArgb(64, 64, 64)
                        'CLIMA_PIC3.BackColor = Color.FromArgb(64, 64, 64)
                    End If
                    CAPACIDADRow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(2)
                    DIA = 3
                    CARGAR_VARIABLES()
                    P3.Visible = True
                    P8.Visible = True
                    P13.Visible = True
                    PIC3.Visible = True
                    CLIMA_PIC3.Visible = True

                    LBL_DIA3.Visible = True
                    LBL_DIA03.Visible = True
                    CAP_DIA3.Visible = True
                    AGE_DIA3.Visible = True
                    DIS_DIA3.Visible = True
                    LBL_OCUPACION3.Visible = True
                    LBL_PORC3.Visible = True
                    LBL_PORCENT_DIA3.Visible = True

                    CAP_DIA8.Visible = True
                    AGE_DIA8.Visible = True
                    DIS_DIA8.Visible = True
                    LBL_OCUPACION8.Visible = True
                    LBL_PORC8.Visible = True
                    LBL_PORCENT_DIA8.Visible = True

                    CAP_DIA13.Visible = True
                    AGE_DIA13.Visible = True
                    DIS_DIA13.Visible = True
                    LBL_OCUPACION13.Visible = True
                    LBL_PORC13.Visible = True
                    LBL_PORCENT_DIA13.Visible = True

                    LBL_DIA3.Text = FECHAINI.AddDays(2).ToShortDateString
                    LBL_DIA03.Text = FECHAINI.AddDays(2).ToString("dddd").ToUpper
                    Select Case FECHAINI.AddDays(2).ToString("dddd").ToUpper
                        Case "SÁBADO", "DOMINGO"
                            LBL_DIA3.ForeColor = Color.Red
                            LBL_DIA03.ForeColor = Color.Red
                    End Select

                    If INDICESDataSet.CLIMA.Rows.Count > 2 Then
                        CLIMA_PIC3.BackgroundImage = My.Resources.ResourceManager.GetObject(INDICESDataSet.CLIMA.Rows(2).Item("CLIMA_CODIGO_LOGO"))
                    Else
                        CLIMA_PIC3.BackgroundImage = Nothing
                    End If

                    CAP_DIA3.Text = CAP_DIA_ALTA
                    AGE_DIA3.Text = AGE_DIA_ALTA
                    DIS_DIA3.Text = DIS_DIA_ALTA


                    POSX = 209 + (158 * C)
                    POSY = 105
                    If CAP_DIA3.Text <> 0 Then
                        CAP_DIA3.Size = New Size(115, 15)
                        If CAP_DIA3.Size.Width >= (115 * CDbl(AGE_DIA3.Text) / CDbl(CAP_DIA3.Text)) Then
                            AGE_DIA3.Size = New Size((115) * CDbl(AGE_DIA3.Text) / CDbl(CAP_DIA3.Text), 15)
                        Else
                            AGE_DIA3.Size = New Size(115, 15)
                        End If
                        DIS_DIA3.Size = New Size((115) * CDbl(DIS_DIA3.Text) / CDbl(CAP_DIA3.Text), 15)

                        LBL_PORCENT_DIA3.Text = CInt(CDbl(AGE_DIA3.Text) * 100 / CDbl(CAP_DIA3.Text))
                        LBL_PORC3.Text = "%"
                        LBL_OCUPACION3.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_ALTA / 450)
                        If CAP_DIA_ALTA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 1 & X) = New PictureBox()
                                TEC_DIA(C & 1 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 1 & X).BackColor = Color.White
                                TEC_DIA(C & 1 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 1 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 1 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 1 & X))
                                TEC_DIA(C & 1 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA3.Size = New Size(30, 15)
                        If AGE_DIA3.Text <> 0 Then
                            AGE_DIA3.Size = New Size(30, 15)
                        Else
                            AGE_DIA3.Size = New Size(15, 15)
                        End If
                        DIS_DIA3.Visible = False
                        LBL_PORCENT_DIA3.Text = ""
                        LBL_PORC3.Text = ""
                        LBL_OCUPACION3.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA3.Location = New Point(AGE_DIA3.Location.X + AGE_DIA3.Size.Width, AGE_DIA3.Location.Y)

                    CAP_DIA8.Text = CAP_DIA_MEDIA
                    AGE_DIA8.Text = AGE_DIA_MEDIA
                    DIS_DIA8.Text = DIS_DIA_MEDIA


                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA8.Text <> 0 Then
                        CAP_DIA8.Size = New Size(115, 15)
                        If CAP_DIA8.Size.Width >= (115 * CDbl(AGE_DIA8.Text) / CDbl(CAP_DIA8.Text)) Then
                            AGE_DIA8.Size = New Size((115) * CDbl(AGE_DIA8.Text) / CDbl(CAP_DIA8.Text), 15)
                        Else
                            AGE_DIA8.Size = New Size(115, 15)
                        End If
                        DIS_DIA8.Size = New Size((115) * CDbl(DIS_DIA8.Text) / CDbl(CAP_DIA8.Text), 15)

                        LBL_PORCENT_DIA8.Text = CInt(CDbl(AGE_DIA8.Text) * 100 / CDbl(CAP_DIA8.Text))
                        LBL_PORC8.Text = "%"
                        LBL_OCUPACION8.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_MEDIA / 450)
                        If CAP_DIA_MEDIA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 2 & X) = New PictureBox()
                                TEC_DIA(C & 2 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 2 & X).BackColor = Color.White
                                TEC_DIA(C & 2 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 2 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 2 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 2 & X))
                                TEC_DIA(C & 2 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA8.Size = New Size(30, 15)
                        If AGE_DIA8.Text <> 0 Then
                            AGE_DIA8.Size = New Size(30, 15)
                        Else
                            AGE_DIA8.Size = New Size(15, 15)
                        End If
                        DIS_DIA8.Visible = False
                        LBL_PORCENT_DIA8.Text = ""
                        LBL_PORC8.Text = ""
                        LBL_OCUPACION8.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA8.Location = New Point(AGE_DIA8.Location.X + AGE_DIA8.Size.Width, AGE_DIA8.Location.Y)

                    CAP_DIA13.Text = CAP_DIA_BAJA
                    AGE_DIA13.Text = AGE_DIA_BAJA
                    DIS_DIA13.Text = DIS_DIA_BAJA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA13.Text <> 0 Then
                        CAP_DIA13.Size = New Size(115, 15)
                        If CAP_DIA13.Size.Width >= (115 * CDbl(AGE_DIA13.Text) / CDbl(CAP_DIA13.Text)) Then
                            AGE_DIA13.Size = New Size((115) * CDbl(AGE_DIA13.Text) / CDbl(CAP_DIA13.Text), 15)
                        Else
                            AGE_DIA13.Size = New Size(115, 15)
                        End If
                        DIS_DIA13.Size = New Size((115) * CDbl(DIS_DIA13.Text) / CDbl(CAP_DIA13.Text), 15)

                        LBL_PORCENT_DIA13.Text = CInt(CDbl(AGE_DIA13.Text) * 100 / CDbl(CAP_DIA13.Text))
                        LBL_PORC13.Text = "%"
                        LBL_OCUPACION13.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_BAJA / 450)
                        If CAP_DIA_BAJA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 3 & X) = New PictureBox()
                                TEC_DIA(C & 3 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 3 & X).BackColor = Color.White
                                TEC_DIA(C & 3 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 3 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 3 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 3 & X))
                                TEC_DIA(C & 3 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA13.Size = New Size(30, 15)
                        If AGE_DIA13.Text <> 0 Then
                            AGE_DIA13.Size = New Size(30, 15)
                        Else
                            AGE_DIA13.Size = New Size(15, 15)
                        End If
                        DIS_DIA13.Visible = False
                        LBL_PORCENT_DIA13.Text = ""
                        LBL_PORC13.Text = ""
                        LBL_OCUPACION13.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA13.Location = New Point(AGE_DIA13.Location.X + AGE_DIA13.Size.Width, AGE_DIA13.Location.Y)

                Case 4
                    If THEME_BLACK = False Then
                        PIC4.BackColor = Color.White
                        P9.BackColor = Color.White
                        P4.BackColor = Color.White
                        P14.BackColor = Color.White
                        CLIMA_PIC4.BackColor = Color.White
                        LBL_DIA4.BackColor = Color.White
                        LBL_DIA4.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_DIA04.ForeColor = Color.FromArgb(64, 64, 64)
                        CAP_DIA4.BackColor = Color.LightGray
                        CAP_DIA9.BackColor = Color.LightGray
                        CAP_DIA14.BackColor = Color.LightGray
                        LBL_PORCENT_DIA4.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA4.BackColor = Color.White
                        LBL_PORCENT_DIA9.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA9.BackColor = Color.White
                        LBL_PORCENT_DIA14.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA14.BackColor = Color.White
                        LBL_PORC4.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC4.BackColor = Color.White
                        LBL_PORC9.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC9.BackColor = Color.White
                        LBL_PORC14.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC14.BackColor = Color.White
                        LBL_OCUPACION4.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION4.BackColor = Color.White
                        LBL_OCUPACION9.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION9.BackColor = Color.White
                        LBL_OCUPACION14.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION14.BackColor = Color.White
                    Else
                        'LBL_DIA4.ForeColor = Color.White
                        'LBL_DIA04.ForeColor = Color.White
                        'PIC4.BackColor = Color.FromArgb(64, 64, 64)
                        'CLIMA_PIC4.BackColor = Color.FromArgb(64, 64, 64)
                    End If
                    CAPACIDADRow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(3)
                    DIA = 4
                    CARGAR_VARIABLES()
                    P4.Visible = True
                    P9.Visible = True
                    P14.Visible = True
                    PIC4.Visible = True
                    CLIMA_PIC4.Visible = True

                    LBL_DIA4.Visible = True
                    LBL_DIA04.Visible = True
                    CAP_DIA4.Visible = True
                    AGE_DIA4.Visible = True
                    DIS_DIA4.Visible = True
                    LBL_OCUPACION4.Visible = True
                    LBL_PORC4.Visible = True
                    LBL_PORCENT_DIA4.Visible = True

                    CAP_DIA9.Visible = True
                    AGE_DIA9.Visible = True
                    DIS_DIA9.Visible = True
                    LBL_OCUPACION9.Visible = True
                    LBL_PORC9.Visible = True
                    LBL_PORCENT_DIA9.Visible = True

                    CAP_DIA14.Visible = True
                    AGE_DIA14.Visible = True
                    DIS_DIA14.Visible = True
                    LBL_OCUPACION14.Visible = True
                    LBL_PORC14.Visible = True
                    LBL_PORCENT_DIA14.Visible = True

                    LBL_DIA4.Text = FECHAINI.AddDays(3).ToShortDateString
                    LBL_DIA04.Text = FECHAINI.AddDays(3).ToString("dddd").ToUpper
                    Select Case FECHAINI.AddDays(3).ToString("dddd").ToUpper
                        Case "SÁBADO", "DOMINGO"
                            LBL_DIA4.ForeColor = Color.Red
                            LBL_DIA04.ForeColor = Color.Red
                    End Select

                    If INDICESDataSet.CLIMA.Rows.Count > 3 Then
                        CLIMA_PIC4.BackgroundImage = My.Resources.ResourceManager.GetObject(INDICESDataSet.CLIMA.Rows(3).Item("CLIMA_CODIGO_LOGO"))
                    Else
                        CLIMA_PIC4.BackgroundImage = Nothing
                    End If

                    CAP_DIA4.Text = CAP_DIA_ALTA
                    AGE_DIA4.Text = AGE_DIA_ALTA
                    DIS_DIA4.Text = DIS_DIA_ALTA


                    POSX = 209 + (158 * C)
                    POSY = 105
                    If CAP_DIA4.Text <> 0 Then
                        CAP_DIA4.Size = New Size(115, 15)
                        If CAP_DIA4.Size.Width >= (115 * CDbl(AGE_DIA4.Text) / CDbl(CAP_DIA4.Text)) Then
                            AGE_DIA4.Size = New Size((115) * CDbl(AGE_DIA4.Text) / CDbl(CAP_DIA4.Text), 15)
                        Else
                            AGE_DIA4.Size = New Size(115, 15)
                        End If
                        DIS_DIA4.Size = New Size((115) * CDbl(DIS_DIA4.Text) / CDbl(CAP_DIA4.Text), 15)

                        LBL_PORCENT_DIA4.Text = CInt(CDbl(AGE_DIA4.Text) * 100 / CDbl(CAP_DIA4.Text))
                        LBL_PORC4.Text = "%"
                        LBL_OCUPACION4.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_ALTA / 450)
                        If CAP_DIA_ALTA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 1 & X) = New PictureBox()
                                TEC_DIA(C & 1 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 1 & X).BackColor = Color.White
                                TEC_DIA(C & 1 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 1 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 1 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 1 & X))
                                TEC_DIA(C & 1 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA4.Size = New Size(30, 15)
                        If AGE_DIA4.Text <> 0 Then
                            AGE_DIA4.Size = New Size(30, 15)
                        Else
                            AGE_DIA4.Size = New Size(15, 15)
                        End If
                        DIS_DIA4.Visible = False
                        LBL_PORCENT_DIA4.Text = ""
                        LBL_PORC4.Text = ""
                        LBL_OCUPACION4.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA4.Location = New Point(AGE_DIA4.Location.X + AGE_DIA4.Size.Width, AGE_DIA4.Location.Y)

                    CAP_DIA9.Text = CAP_DIA_MEDIA
                    AGE_DIA9.Text = AGE_DIA_MEDIA
                    DIS_DIA9.Text = DIS_DIA_MEDIA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA9.Text <> 0 Then
                        CAP_DIA9.Size = New Size(115, 15)
                        If CAP_DIA9.Size.Width >= (115 * CDbl(AGE_DIA9.Text) / CDbl(CAP_DIA9.Text)) Then
                            AGE_DIA9.Size = New Size((115) * CDbl(AGE_DIA9.Text) / CDbl(CAP_DIA9.Text), 15)
                        Else
                            AGE_DIA9.Size = New Size(115, 15)
                        End If
                        DIS_DIA9.Size = New Size((115) * CDbl(DIS_DIA9.Text) / CDbl(CAP_DIA9.Text), 15)

                        LBL_PORCENT_DIA9.Text = CInt(CDbl(AGE_DIA9.Text) * 100 / CDbl(CAP_DIA9.Text))
                        LBL_PORC9.Text = "%"
                        LBL_OCUPACION9.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_MEDIA / 450)
                        If CAP_DIA_MEDIA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 2 & X) = New PictureBox()
                                TEC_DIA(C & 2 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 2 & X).BackColor = Color.White
                                TEC_DIA(C & 2 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 2 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 2 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 2 & X))
                                TEC_DIA(C & 2 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA9.Size = New Size(30, 15)
                        If AGE_DIA9.Text <> 0 Then
                            AGE_DIA9.Size = New Size(30, 15)
                        Else
                            AGE_DIA9.Size = New Size(15, 15)
                        End If
                        DIS_DIA9.Visible = False
                        LBL_PORCENT_DIA9.Text = ""
                        LBL_PORC9.Text = ""
                        LBL_OCUPACION9.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA9.Location = New Point(AGE_DIA9.Location.X + AGE_DIA9.Size.Width, AGE_DIA9.Location.Y)

                    CAP_DIA14.Text = CAP_DIA_BAJA
                    AGE_DIA14.Text = AGE_DIA_BAJA
                    DIS_DIA14.Text = DIS_DIA_BAJA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA14.Text <> 0 Then
                        CAP_DIA14.Size = New Size(115, 15)
                        If CAP_DIA14.Size.Width >= (115 * CDbl(AGE_DIA14.Text) / CDbl(CAP_DIA14.Text)) Then
                            AGE_DIA14.Size = New Size((115) * CDbl(AGE_DIA14.Text) / CDbl(CAP_DIA14.Text), 15)
                        Else
                            AGE_DIA14.Size = New Size(115, 15)
                        End If
                        DIS_DIA14.Size = New Size((115) * CDbl(DIS_DIA14.Text) / CDbl(CAP_DIA14.Text), 15)

                        LBL_PORCENT_DIA14.Text = CInt(CDbl(AGE_DIA14.Text) * 100 / CDbl(CAP_DIA14.Text))
                        LBL_PORC14.Text = "%"
                        LBL_OCUPACION14.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_BAJA / 450)
                        If CAP_DIA_BAJA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 3 & X) = New PictureBox()
                                TEC_DIA(C & 3 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 3 & X).BackColor = Color.White
                                TEC_DIA(C & 3 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 3 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 3 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 3 & X))
                                TEC_DIA(C & 3 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA14.Size = New Size(30, 15)
                        If AGE_DIA14.Text <> 0 Then
                            AGE_DIA14.Size = New Size(30, 15)
                        Else
                            AGE_DIA14.Size = New Size(15, 15)
                        End If
                        DIS_DIA14.Visible = False
                        LBL_PORCENT_DIA14.Text = ""
                        LBL_PORC14.Text = ""
                        LBL_OCUPACION14.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA14.Location = New Point(AGE_DIA14.Location.X + AGE_DIA14.Size.Width, AGE_DIA14.Location.Y)

                Case 5
                    If THEME_BLACK = False Then
                        PIC5.BackColor = Color.White
                        P5.BackColor = Color.White
                        P10.BackColor = Color.White
                        P15.BackColor = Color.White
                        CLIMA_PIC5.BackColor = Color.White
                        LBL_DIA5.BackColor = Color.White
                        LBL_DIA5.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_DIA05.ForeColor = Color.FromArgb(64, 64, 64)
                        CAP_DIA5.BackColor = Color.LightGray
                        CAP_DIA10.BackColor = Color.LightGray
                        CAP_DIA15.BackColor = Color.LightGray
                        LBL_PORCENT_DIA5.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA5.BackColor = Color.White
                        LBL_PORCENT_DIA10.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA10.BackColor = Color.White
                        LBL_PORCENT_DIA15.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORCENT_DIA15.BackColor = Color.White
                        LBL_PORC5.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC5.BackColor = Color.White
                        LBL_PORC10.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC10.BackColor = Color.White
                        LBL_PORC15.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_PORC15.BackColor = Color.White
                        LBL_OCUPACION5.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION5.BackColor = Color.White
                        LBL_OCUPACION10.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION10.BackColor = Color.White
                        LBL_OCUPACION15.ForeColor = Color.FromArgb(64, 64, 64)
                        LBL_OCUPACION15.BackColor = Color.White
                    Else
                        'LBL_DIA5.ForeColor = Color.White
                        'LBL_DIA05.ForeColor = Color.White
                        'PIC5.BackColor = Color.FromArgb(64, 64, 64)
                        'CLIMA_PIC5.BackColor = Color.FromArgb(64, 64, 64)
                    End If
                    CAPACIDADRow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(4)
                    DIA = 5
                    CARGAR_VARIABLES()
                    P5.Visible = True
                    P10.Visible = True
                    P15.Visible = True
                    PIC5.Visible = True
                    CLIMA_PIC5.Visible = True

                    LBL_DIA5.Visible = True
                    LBL_DIA05.Visible = True
                    CAP_DIA5.Visible = True
                    AGE_DIA5.Visible = True
                    DIS_DIA5.Visible = True
                    LBL_OCUPACION5.Visible = True
                    LBL_PORC5.Visible = True
                    LBL_PORCENT_DIA5.Visible = True

                    CAP_DIA10.Visible = True
                    AGE_DIA10.Visible = True
                    DIS_DIA10.Visible = True
                    LBL_OCUPACION10.Visible = True
                    LBL_PORC10.Visible = True
                    LBL_PORCENT_DIA10.Visible = True

                    CAP_DIA15.Visible = True
                    AGE_DIA15.Visible = True
                    DIS_DIA15.Visible = True
                    LBL_OCUPACION15.Visible = True
                    LBL_PORC15.Visible = True
                    LBL_PORCENT_DIA15.Visible = True

                    LBL_DIA5.Text = FECHAINI.AddDays(4).ToShortDateString
                    LBL_DIA05.Text = FECHAINI.AddDays(4).ToString("dddd").ToUpper
                    Select Case FECHAINI.AddDays(4).ToString("dddd").ToUpper
                        Case "SÁBADO", "DOMINGO"
                            LBL_DIA5.ForeColor = Color.Red
                            LBL_DIA05.ForeColor = Color.Red
                    End Select
                    If INDICESDataSet.CLIMA.Rows.Count > 4 Then
                        CLIMA_PIC5.BackgroundImage = My.Resources.ResourceManager.GetObject(INDICESDataSet.CLIMA.Rows(4).Item("CLIMA_CODIGO_LOGO"))
                    Else
                        CLIMA_PIC5.BackgroundImage = Nothing
                    End If

                    CAP_DIA5.Text = CAP_DIA_ALTA
                    AGE_DIA5.Text = AGE_DIA_ALTA
                    DIS_DIA5.Text = DIS_DIA_ALTA

                    POSX = 209 + (158 * C)
                    POSY = 105
                    If CAP_DIA5.Text <> 0 Then
                        CAP_DIA5.Size = New Size(115, 15)
                        If CAP_DIA5.Size.Width >= (115 * CDbl(AGE_DIA5.Text) / CDbl(CAP_DIA5.Text)) Then
                            AGE_DIA5.Size = New Size((115) * CDbl(AGE_DIA5.Text) / CDbl(CAP_DIA5.Text), 15)
                        Else
                            AGE_DIA5.Size = New Size(115, 15)
                        End If
                        DIS_DIA5.Size = New Size((115) * CDbl(DIS_DIA5.Text) / CDbl(CAP_DIA5.Text), 15)

                        LBL_PORCENT_DIA5.Text = CInt(CDbl(AGE_DIA5.Text) * 100 / CDbl(CAP_DIA5.Text))
                        LBL_PORC5.Text = "%"
                        LBL_OCUPACION5.Text = "OCUPACION DEL:"

                        CANT_TECNICOS_DIA = CInt(CAP_DIA_ALTA / 450)
                        If CAP_DIA_ALTA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 1 & X) = New PictureBox()
                                TEC_DIA(C & 1 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 1 & X).BackColor = Color.White
                                TEC_DIA(C & 1 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 1 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 1 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 1 & X))
                                TEC_DIA(C & 1 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA5.Size = New Size(30, 15)
                        If AGE_DIA5.Text <> 0 Then
                            AGE_DIA5.Size = New Size(30, 15)
                        Else
                            AGE_DIA5.Size = New Size(15, 15)
                        End If
                        DIS_DIA5.Visible = False
                        LBL_PORCENT_DIA5.Text = ""
                        LBL_PORC5.Text = ""
                        LBL_OCUPACION5.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA5.Location = New Point(AGE_DIA5.Location.X + AGE_DIA5.Size.Width, AGE_DIA5.Location.Y)

                    CAP_DIA10.Text = CAP_DIA_MEDIA
                    AGE_DIA10.Text = AGE_DIA_MEDIA
                    DIS_DIA10.Text = DIS_DIA_MEDIA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA10.Text <> 0 Then
                        CAP_DIA10.Size = New Size(115, 15)
                        If CAP_DIA10.Size.Width >= (115 * CDbl(AGE_DIA10.Text) / CDbl(CAP_DIA10.Text)) Then
                            AGE_DIA10.Size = New Size((115) * CDbl(AGE_DIA10.Text) / CDbl(CAP_DIA10.Text), 15)
                        Else
                            AGE_DIA10.Size = New Size(115, 15)
                        End If
                        DIS_DIA10.Size = New Size((115) * CDbl(DIS_DIA10.Text) / CDbl(CAP_DIA10.Text), 15)

                        LBL_PORCENT_DIA10.Text = CInt(CDbl(AGE_DIA10.Text) * 100 / CDbl(CAP_DIA10.Text))
                        LBL_PORC10.Text = "%"
                        LBL_OCUPACION10.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_MEDIA / 450)
                        If CAP_DIA_MEDIA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 2 & X) = New PictureBox()
                                TEC_DIA(C & 2 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 2 & X).BackColor = Color.White
                                TEC_DIA(C & 2 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 2 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 2 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 2 & X))
                                TEC_DIA(C & 2 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA10.Size = New Size(30, 15)
                        If AGE_DIA10.Text <> 0 Then
                            AGE_DIA10.Size = New Size(30, 15)
                        Else
                            AGE_DIA10.Size = New Size(15, 15)
                        End If
                        DIS_DIA10.Visible = False
                        LBL_PORCENT_DIA10.Text = ""
                        LBL_PORC10.Text = ""
                        LBL_OCUPACION10.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA10.Location = New Point(AGE_DIA10.Location.X + AGE_DIA10.Size.Width, AGE_DIA10.Location.Y)

                    CAP_DIA15.Text = CAP_DIA_BAJA
                    AGE_DIA15.Text = AGE_DIA_BAJA
                    DIS_DIA15.Text = DIS_DIA_BAJA

                    POSX = 209 + (158 * C)
                    POSY += 185
                    If CAP_DIA15.Text <> 0 Then
                        CAP_DIA15.Size = New Size(115, 15)
                        If CAP_DIA15.Size.Width >= (115 * CDbl(AGE_DIA15.Text) / CDbl(CAP_DIA15.Text)) Then
                            AGE_DIA15.Size = New Size((115) * CDbl(AGE_DIA15.Text) / CDbl(CAP_DIA15.Text), 15)
                        Else
                            AGE_DIA15.Size = New Size(115, 15)
                        End If
                        DIS_DIA15.Size = New Size((115) * CDbl(DIS_DIA15.Text) / CDbl(CAP_DIA15.Text), 15)

                        LBL_PORCENT_DIA15.Text = CInt(CDbl(AGE_DIA15.Text) * 100 / CDbl(CAP_DIA15.Text))
                        LBL_PORC15.Text = "%"
                        LBL_OCUPACION15.Text = "OCUPACION DEL:"
                        CANT_TECNICOS_DIA = CInt(CAP_DIA_BAJA / 450)
                        If CAP_DIA_BAJA / 450 > CANT_TECNICOS_DIA Then
                            CANT_TECNICOS_DIA += 1
                        End If
                        For X = 0 To CANT_TECNICOS_DIA - 1
                            If X <= 9 Then
                                TEC_DIA(C & 3 & X) = New PictureBox()
                                TEC_DIA(C & 3 & X).Size = New Size(10, 10)
                                TEC_DIA(C & 3 & X).BackColor = Color.White
                                TEC_DIA(C & 3 & X).BackgroundImage = My.Resources.UserBlack
                                TEC_DIA(C & 3 & X).BackgroundImageLayout = ImageLayout.Zoom
                                TEC_DIA(C & 3 & X).Location = New Point(POSX, POSY)
                                POSX += 10
                                Me.Controls.Add(TEC_DIA(C & 3 & X))
                                TEC_DIA(C & 3 & X).BringToFront()
                            End If
                        Next
                    Else
                        CAP_DIA15.Size = New Size(30, 15)
                        If AGE_DIA15.Text <> 0 Then
                            AGE_DIA15.Size = New Size(30, 15)
                        Else
                            AGE_DIA15.Size = New Size(15, 15)
                        End If
                        DIS_DIA15.Visible = False
                        LBL_PORCENT_DIA15.Text = ""
                        LBL_PORC15.Text = ""
                        LBL_OCUPACION15.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA15.Location = New Point(AGE_DIA15.Location.X + AGE_DIA15.Size.Width, AGE_DIA15.Location.Y)
            End Select
        Next
    End Sub
    'CARGA Y/O MODIFICA LAS CAPACIDADES EN LOS WIDGETS
    Private Sub CARGAR_VARIABLES() 'ByVal PRIORIDAD As String, ByVal RECURSO As String
        FECHADIA(DIA) = CAPACIDADRow("FECHA")
        CANT_TEC(DIA) = CAPACIDADRow("CANT_TEC")
        CANt_CUA(DIA) = CAPACIDADRow("CANT_CUA")
        CANTMINUTOS_TEC(DIA) = CAPACIDADRow("MIN_TEC")
        CANTMINUTOS_CUA(DIA) = CAPACIDADRow("MIN_CUA")

        CANTMINUTOS_ALT_TEC_PT(DIA) = CAPACIDADRow("MIN_ALT_TEC_PT")
        CANTMINUTOS_ALT_CUA_PT(DIA) = CAPACIDADRow("MIN_ALT_CUA_PT")
        CANTMINUTOS_MED_TEC_PT(DIA) = CAPACIDADRow("MIN_MED_TEC_PT")
        CANTMINUTOS_MED_CUA_PT(DIA) = CAPACIDADRow("MIN_MED_CUA_PT")
        CANTMINUTOS_BAJ_TEC_PT(DIA) = CAPACIDADRow("MIN_BAJ_TEC_PT")
        CANTMINUTOS_BAJ_CUA_PT(DIA) = CAPACIDADRow("MIN_BAJ_CUA_PT")

        CANTMINUTOS_ALT_TEC_SU(DIA) = CAPACIDADRow("MIN_ALT_TEC_SU")
        CANTMINUTOS_ALT_CUA_SU(DIA) = CAPACIDADRow("MIN_ALT_CUA_SU")
        CANTMINUTOS_MED_TEC_SU(DIA) = CAPACIDADRow("MIN_MED_TEC_SU")
        CANTMINUTOS_MED_CUA_SU(DIA) = CAPACIDADRow("MIN_MED_CUA_SU")
        CANTMINUTOS_BAJ_TEC_SU(DIA) = CAPACIDADRow("MIN_BAJ_TEC_SU")
        CANTMINUTOS_BAJ_CUA_SU(DIA) = CAPACIDADRow("MIN_BAJ_CUA_SU")

        CANTMINUTOS_ALT_TEC_CO(DIA) = CAPACIDADRow("MIN_ALT_TEC_CO")
        CANTMINUTOS_ALT_CUA_CO(DIA) = CAPACIDADRow("MIN_ALT_CUA_CO")
        CANTMINUTOS_MED_TEC_CO(DIA) = CAPACIDADRow("MIN_MED_TEC_CO")
        CANTMINUTOS_MED_CUA_CO(DIA) = CAPACIDADRow("MIN_MED_CUA_CO")
        CANTMINUTOS_BAJ_TEC_CO(DIA) = CAPACIDADRow("MIN_BAJ_TEC_CO")
        CANTMINUTOS_BAJ_CUA_CO(DIA) = CAPACIDADRow("MIN_BAJ_CUA_CO")

        CANTMINUTOS_ALT_TEC_PT_AGE(DIA) = CAPACIDADRow("MIN_ALT_TEC_PT_AGE")
        CANTMINUTOS_ALT_CUA_PT_AGE(DIA) = CAPACIDADRow("MIN_ALT_CUA_PT_AGE")
        CANTMINUTOS_MED_TEC_PT_AGE(DIA) = CAPACIDADRow("MIN_MED_TEC_PT_AGE")
        CANTMINUTOS_MED_CUA_PT_AGE(DIA) = CAPACIDADRow("MIN_MED_CUA_PT_AGE")
        CANTMINUTOS_BAJ_TEC_PT_AGE(DIA) = CAPACIDADRow("MIN_BAJ_TEC_PT_AGE")
        CANTMINUTOS_BAJ_CUA_PT_AGE(DIA) = CAPACIDADRow("MIN_BAJ_CUA_PT_AGE")

        CANTMINUTOS_ALT_TEC_SU_AGE(DIA) = CAPACIDADRow("MIN_ALT_TEC_SU_AGE")
        CANTMINUTOS_ALT_CUA_SU_AGE(DIA) = CAPACIDADRow("MIN_ALT_CUA_SU_AGE")
        CANTMINUTOS_MED_TEC_SU_AGE(DIA) = CAPACIDADRow("MIN_MED_TEC_SU_AGE")
        CANTMINUTOS_MED_CUA_SU_AGE(DIA) = CAPACIDADRow("MIN_MED_CUA_SU_AGE")
        CANTMINUTOS_BAJ_TEC_SU_AGE(DIA) = CAPACIDADRow("MIN_BAJ_TEC_SU_AGE")
        CANTMINUTOS_BAJ_CUA_SU_AGE(DIA) = CAPACIDADRow("MIN_BAJ_CUA_SU_AGE")

        CANTMINUTOS_ALT_TEC_CO_AGE(DIA) = CAPACIDADRow("MIN_ALT_TEC_CO_AGE")
        CANTMINUTOS_ALT_CUA_CO_AGE(DIA) = CAPACIDADRow("MIN_ALT_CUA_CO_AGE")
        CANTMINUTOS_MED_TEC_CO_AGE(DIA) = CAPACIDADRow("MIN_MED_TEC_CO_AGE")
        CANTMINUTOS_MED_CUA_CO_AGE(DIA) = CAPACIDADRow("MIN_MED_CUA_CO_AGE")
        CANTMINUTOS_BAJ_TEC_CO_AGE(DIA) = CAPACIDADRow("MIN_BAJ_TEC_CO_AGE")
        CANTMINUTOS_BAJ_CUA_CO_AGE(DIA) = CAPACIDADRow("MIN_BAJ_CUA_CO_AGE")

        Select Case DATOS.SECTOR_CAP
            Case "PT"
                Select Case DATOS.RECURSO_CAP
                    Case "TEC"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "CUA"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_CUA_PT(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_CUA_PT_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_CUA_PT(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_CUA_PT_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_CUA_PT(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_CUA_PT_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "TODOS"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT(DIA) + CANTMINUTOS_ALT_CUA_PT(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT_AGE(DIA) + CANTMINUTOS_ALT_CUA_PT_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT(DIA) + CANTMINUTOS_MED_CUA_PT(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT_AGE(DIA) + CANTMINUTOS_MED_CUA_PT_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT(DIA) + CANTMINUTOS_BAJ_CUA_PT(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT_AGE(DIA) + CANTMINUTOS_BAJ_CUA_PT_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                End Select
            Case "SU"
                Select Case DATOS.RECURSO_CAP
                    Case "TEC"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_SU(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_SU_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_SU(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_SU_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_SU(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_SU_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "CUA"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_CUA_SU(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_CUA_SU_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_CUA_SU(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_CUA_SU_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_CUA_SU(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_CUA_SU_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "TODOS"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_SU(DIA) + CANTMINUTOS_ALT_CUA_SU(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_SU_AGE(DIA) + CANTMINUTOS_ALT_CUA_SU_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_SU(DIA) + CANTMINUTOS_MED_CUA_SU(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_SU_AGE(DIA) + CANTMINUTOS_MED_CUA_SU_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_SU(DIA) + CANTMINUTOS_BAJ_CUA_SU(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_SU_AGE(DIA) + CANTMINUTOS_BAJ_CUA_SU_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                End Select
            Case "CO"
                Select Case DATOS.RECURSO_CAP
                    Case "TEC"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "CUA"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_CUA_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_CUA_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_CUA_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_CUA_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_CUA_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_CUA_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "TODOS"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_CO(DIA) + CANTMINUTOS_ALT_CUA_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_CO_AGE(DIA) + CANTMINUTOS_ALT_CUA_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_CO(DIA) + CANTMINUTOS_MED_CUA_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_CO_AGE(DIA) + CANTMINUTOS_MED_CUA_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_CO(DIA) + CANTMINUTOS_BAJ_CUA_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_CO_AGE(DIA) + CANTMINUTOS_BAJ_CUA_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                End Select
            Case "TODOS"
                Select Case DATOS.RECURSO_CAP
                    Case "TEC"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT(DIA) + CANTMINUTOS_ALT_TEC_SU(DIA) + CANTMINUTOS_ALT_TEC_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT_AGE(DIA) + CANTMINUTOS_ALT_TEC_SU_AGE(DIA) + CANTMINUTOS_ALT_TEC_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT(DIA) + CANTMINUTOS_MED_TEC_SU(DIA) + CANTMINUTOS_MED_TEC_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT_AGE(DIA) + CANTMINUTOS_MED_TEC_SU_AGE(DIA) + CANTMINUTOS_MED_TEC_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT(DIA) + CANTMINUTOS_BAJ_TEC_SU(DIA) + CANTMINUTOS_BAJ_TEC_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT_AGE(DIA) + CANTMINUTOS_BAJ_TEC_SU_AGE(DIA) + CANTMINUTOS_BAJ_TEC_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "CUA"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_CUA_PT(DIA) + CANTMINUTOS_ALT_CUA_SU(DIA) + CANTMINUTOS_ALT_CUA_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_CUA_PT_AGE(DIA) + CANTMINUTOS_ALT_CUA_SU_AGE(DIA) + CANTMINUTOS_ALT_CUA_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_CUA_PT(DIA) + CANTMINUTOS_MED_CUA_SU(DIA) + CANTMINUTOS_MED_CUA_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_CUA_PT_AGE(DIA) + CANTMINUTOS_MED_CUA_SU_AGE(DIA) + CANTMINUTOS_MED_CUA_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_CUA_PT(DIA) + CANTMINUTOS_BAJ_CUA_SU(DIA) + CANTMINUTOS_BAJ_CUA_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_CUA_PT_AGE(DIA) + CANTMINUTOS_BAJ_CUA_SU_AGE(DIA) + CANTMINUTOS_BAJ_CUA_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                    Case "TODOS"
                        CAP_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT(DIA) + CANTMINUTOS_ALT_TEC_SU(DIA) + CANTMINUTOS_ALT_TEC_CO(DIA) + CANTMINUTOS_ALT_CUA_PT(DIA) + CANTMINUTOS_ALT_CUA_SU(DIA) + CANTMINUTOS_ALT_CUA_CO(DIA)
                        AGE_DIA_ALTA = CANTMINUTOS_ALT_TEC_PT_AGE(DIA) + CANTMINUTOS_ALT_TEC_SU_AGE(DIA) + CANTMINUTOS_ALT_TEC_CO_AGE(DIA) + CANTMINUTOS_ALT_CUA_PT_AGE(DIA) + CANTMINUTOS_ALT_CUA_SU_AGE(DIA) + CANTMINUTOS_ALT_CUA_CO_AGE(DIA)
                        DIS_DIA_ALTA = CAP_DIA_ALTA - AGE_DIA_ALTA
                        CAP_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT(DIA) + CANTMINUTOS_MED_TEC_SU(DIA) + CANTMINUTOS_MED_TEC_CO(DIA) + CANTMINUTOS_MED_CUA_PT(DIA) + CANTMINUTOS_MED_CUA_SU(DIA) + CANTMINUTOS_MED_CUA_CO(DIA)
                        AGE_DIA_MEDIA = CANTMINUTOS_MED_TEC_PT_AGE(DIA) + CANTMINUTOS_MED_TEC_SU_AGE(DIA) + CANTMINUTOS_MED_TEC_CO_AGE(DIA) + CANTMINUTOS_MED_CUA_PT_AGE(DIA) + CANTMINUTOS_MED_CUA_SU_AGE(DIA) + CANTMINUTOS_MED_CUA_CO_AGE(DIA)
                        DIS_DIA_MEDIA = CAP_DIA_MEDIA - AGE_DIA_MEDIA
                        CAP_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT(DIA) + CANTMINUTOS_BAJ_TEC_SU(DIA) + CANTMINUTOS_BAJ_TEC_CO(DIA) + CANTMINUTOS_BAJ_CUA_PT(DIA) + CANTMINUTOS_BAJ_CUA_SU(DIA) + CANTMINUTOS_BAJ_CUA_CO(DIA)
                        AGE_DIA_BAJA = CANTMINUTOS_BAJ_TEC_PT_AGE(DIA) + CANTMINUTOS_BAJ_TEC_SU_AGE(DIA) + CANTMINUTOS_BAJ_TEC_CO_AGE(DIA) + CANTMINUTOS_BAJ_CUA_PT_AGE(DIA) + CANTMINUTOS_BAJ_CUA_SU_AGE(DIA) + CANTMINUTOS_BAJ_CUA_CO_AGE(DIA)
                        DIS_DIA_BAJA = CAP_DIA_BAJA - AGE_DIA_BAJA
                End Select
        End Select
    End Sub

    '_____________________________EVENTOS EN BOTONES_______________________________________
    Public Sub BORRA_BOTONES()
        'BORRA TODO
        'Try
        '    For X = 0 To 539
        '        Me.Controls.Remove(TEC_DIA(X))
        '    Next
        'Catch ex As Exception
        'End Try
        P1.Visible = False
        P2.Visible = False
        P3.Visible = False
        P4.Visible = False
        P5.Visible = False
        P6.Visible = False
        P7.Visible = False
        P8.Visible = False
        P9.Visible = False
        P10.Visible = False
        P11.Visible = False
        P12.Visible = False
        P13.Visible = False
        P14.Visible = False
        P15.Visible = False

        PIC1.Visible = False
        PIC2.Visible = False
        PIC3.Visible = False
        PIC4.Visible = False
        PIC5.Visible = False

        LBL_DIA1.Visible = False
        LBL_DIA01.Visible = False
        LBL_DIA2.Visible = False
        LBL_DIA02.Visible = False
        LBL_DIA3.Visible = False
        LBL_DIA03.Visible = False
        LBL_DIA4.Visible = False
        LBL_DIA04.Visible = False
        LBL_DIA5.Visible = False
        LBL_DIA05.Visible = False

        CLIMA_PIC1.Visible = False
        CLIMA_PIC2.Visible = False
        CLIMA_PIC3.Visible = False
        CLIMA_PIC4.Visible = False
        CLIMA_PIC5.Visible = False

        CAP_DIA1.Visible = False
        CAP_DIA2.Visible = False
        CAP_DIA3.Visible = False
        CAP_DIA4.Visible = False
        CAP_DIA5.Visible = False
        CAP_DIA6.Visible = False
        CAP_DIA7.Visible = False
        CAP_DIA8.Visible = False
        CAP_DIA9.Visible = False
        CAP_DIA10.Visible = False
        CAP_DIA11.Visible = False
        CAP_DIA12.Visible = False
        CAP_DIA13.Visible = False
        CAP_DIA14.Visible = False
        CAP_DIA15.Visible = False

        AGE_DIA1.Visible = False
        AGE_DIA2.Visible = False
        AGE_DIA3.Visible = False
        AGE_DIA4.Visible = False
        AGE_DIA5.Visible = False
        AGE_DIA6.Visible = False
        AGE_DIA7.Visible = False
        AGE_DIA8.Visible = False
        AGE_DIA9.Visible = False
        AGE_DIA10.Visible = False
        AGE_DIA11.Visible = False
        AGE_DIA12.Visible = False
        AGE_DIA13.Visible = False
        AGE_DIA14.Visible = False
        AGE_DIA15.Visible = False

        DIS_DIA1.Visible = False
        DIS_DIA2.Visible = False
        DIS_DIA3.Visible = False
        DIS_DIA4.Visible = False
        DIS_DIA5.Visible = False
        DIS_DIA6.Visible = False
        DIS_DIA7.Visible = False
        DIS_DIA8.Visible = False
        DIS_DIA9.Visible = False
        DIS_DIA10.Visible = False
        DIS_DIA11.Visible = False
        DIS_DIA12.Visible = False
        DIS_DIA13.Visible = False
        DIS_DIA14.Visible = False
        DIS_DIA15.Visible = False

        LBL_OCUPACION1.Visible = False
        LBL_OCUPACION2.Visible = False
        LBL_OCUPACION3.Visible = False
        LBL_OCUPACION4.Visible = False
        LBL_OCUPACION5.Visible = False
        LBL_OCUPACION6.Visible = False
        LBL_OCUPACION7.Visible = False
        LBL_OCUPACION8.Visible = False
        LBL_OCUPACION9.Visible = False
        LBL_OCUPACION10.Visible = False
        LBL_OCUPACION11.Visible = False
        LBL_OCUPACION12.Visible = False
        LBL_OCUPACION13.Visible = False
        LBL_OCUPACION14.Visible = False
        LBL_OCUPACION15.Visible = False

        LBL_PORCENT_DIA1.Visible = False
        LBL_PORCENT_DIA2.Visible = False
        LBL_PORCENT_DIA3.Visible = False
        LBL_PORCENT_DIA4.Visible = False
        LBL_PORCENT_DIA5.Visible = False
        LBL_PORCENT_DIA6.Visible = False
        LBL_PORCENT_DIA7.Visible = False
        LBL_PORCENT_DIA8.Visible = False
        LBL_PORCENT_DIA9.Visible = False
        LBL_PORCENT_DIA10.Visible = False
        LBL_PORCENT_DIA11.Visible = False
        LBL_PORCENT_DIA12.Visible = False
        LBL_PORCENT_DIA13.Visible = False
        LBL_PORCENT_DIA14.Visible = False
        LBL_PORCENT_DIA15.Visible = False

        LBL_PORC1.Visible = False
        LBL_PORC2.Visible = False
        LBL_PORC3.Visible = False
        LBL_PORC4.Visible = False
        LBL_PORC5.Visible = False
        LBL_PORC6.Visible = False
        LBL_PORC7.Visible = False
        LBL_PORC8.Visible = False
        LBL_PORC9.Visible = False
        LBL_PORC10.Visible = False
        LBL_PORC11.Visible = False
        LBL_PORC12.Visible = False
        LBL_PORC13.Visible = False
        LBL_PORC14.Visible = False
        LBL_PORC15.Visible = False
        HOVER_DIA = 0
        BORRAR_BTN_DIA()
    End Sub
    Private Sub BORRAR_BTN_DIA()
        BTN_DIA_SET1.Visible = False
        BTN_DIA_SET2.Visible = False
        BTN_DIA_SET3.Visible = False
        BTN_DIA_SET4.Visible = False
        BTN_DIA_SET5.Visible = False
        BTN_DIA_SET6.Visible = False
        BTN_DIA_SET7.Visible = False
        BTN_DIA_SET8.Visible = False
        BTN_DIA_SET9.Visible = False
        BTN_DIA_SET10.Visible = False
        BTN_DIA_SET11.Visible = False
        BTN_DIA_SET12.Visible = False
        BTN_DIA_SET13.Visible = False
        BTN_DIA_SET14.Visible = False
        BTN_DIA_SET15.Visible = False
        P1.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P2.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P3.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P4.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P5.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P6.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P7.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P8.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P9.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P10.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P11.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P12.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P13.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P14.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        P15.BackgroundImage = My.Resources.FONDO_AGENDA_DIA
        Select Case HOVER_DIA
            Case 1
                P1.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET1.Visible = True
                End Select
            Case 2
                P2.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET2.Visible = True
                End Select
            Case 3
                P3.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET3.Visible = True
                End Select
            Case 4
                P4.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET4.Visible = True
                End Select
            Case 5
                P5.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET5.Visible = True
                End Select
            Case 6
                P6.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET6.Visible = True
                End Select
            Case 7
                P7.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET7.Visible = True
                End Select
            Case 8
                P8.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET8.Visible = True
                End Select
            Case 9
                P9.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET9.Visible = True
                End Select
            Case 10
                P10.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET10.Visible = True
                End Select
            Case 11
                P11.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET11.Visible = True
                End Select
            Case 12
                P12.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET12.Visible = True
                End Select
            Case 13
                P13.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET13.Visible = True
                End Select
            Case 14
                P14.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET14.Visible = True
                End Select
            Case 15
                P15.BackgroundImage = My.Resources.FONDO_AGENDA_DIA_OVER
                Select Case ACCION_AGENDA
                    Case "MODIFICAR"
                        BTN_DIA_SET15.Visible = True
                End Select
        End Select
        'RECALCULA_CAPACIDADES()
    End Sub
    Private Sub RECALCULA_CAPACIDADES()
        If ACCION_AGENDA = "AGENDAR" Or ACCION_AGENDA = "REAGENDAR" Then
            MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
            Select Case HOVER_DIA
                Case 1
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA1.Text += TIEMPO_AGENDA
                    DIS_DIA1.Text = CAP_DIA1.Text - AGE_DIA1.Text
                    If CAP_DIA1.Text <> 0 Then
                        CAP_DIA1.Size = New Size(115, 15)
                        If CAP_DIA1.Size.Width >= (115 * CDbl(AGE_DIA1.Text) / CDbl(CAP_DIA1.Text)) Then
                            AGE_DIA1.Size = New Size((115) * CDbl(AGE_DIA1.Text) / CDbl(CAP_DIA1.Text), 15)
                        Else
                            AGE_DIA1.Size = New Size(115, 15)
                        End If
                        DIS_DIA1.Size = New Size((115) * CDbl(DIS_DIA1.Text) / CDbl(CAP_DIA1.Text), 15)
                        LBL_PORCENT_DIA1.Text = CInt(CDbl(AGE_DIA1.Text) * 100 / CDbl(CAP_DIA1.Text))
                        LBL_PORC1.Text = "%"
                        LBL_OCUPACION1.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA1.Size = New Size(30, 15)
                        If AGE_DIA1.Text <> 0 Then
                            AGE_DIA1.Size = New Size(30, 15)
                        Else
                            AGE_DIA1.Size = New Size(15, 15)
                        End If
                        DIS_DIA1.Visible = False
                        LBL_PORCENT_DIA1.Text = ""
                        LBL_PORC1.Text = ""
                        LBL_OCUPACION1.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA1.Location = New Point(AGE_DIA1.Location.X + AGE_DIA1.Size.Width, AGE_DIA1.Location.Y)
                Case 2
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA2.Text = AGE_DIA2.Text + TIEMPO_AGENDA
                    DIS_DIA2.Text = CAP_DIA2.Text - AGE_DIA2.Text
                    If CAP_DIA2.Text <> 0 Then
                        CAP_DIA2.Size = New Size(115, 15)
                        If CAP_DIA2.Size.Width >= (115 * CDbl(AGE_DIA2.Text) / CDbl(CAP_DIA2.Text)) Then
                            AGE_DIA2.Size = New Size((115) * CDbl(AGE_DIA2.Text) / CDbl(CAP_DIA2.Text), 15)
                        Else
                            AGE_DIA2.Size = New Size(115, 15)
                        End If
                        DIS_DIA2.Size = New Size((115) * CDbl(DIS_DIA2.Text) / CDbl(CAP_DIA2.Text), 15)

                        LBL_PORCENT_DIA2.Text = CInt(CDbl(AGE_DIA2.Text) * 100 / CDbl(CAP_DIA2.Text))
                        LBL_PORC2.Text = "%"
                        LBL_OCUPACION2.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA2.Size = New Size(30, 15)
                        If AGE_DIA2.Text <> 0 Then
                            AGE_DIA2.Size = New Size(30, 15)
                        Else
                            AGE_DIA2.Size = New Size(15, 15)
                        End If
                        DIS_DIA2.Visible = False
                        LBL_PORCENT_DIA2.Text = ""
                        LBL_PORC2.Text = ""
                        LBL_OCUPACION2.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA2.Location = New Point(AGE_DIA2.Location.X + AGE_DIA2.Size.Width, AGE_DIA2.Location.Y)
                Case 3
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA3.Text = AGE_DIA3.Text + TIEMPO_AGENDA
                    DIS_DIA3.Text = CAP_DIA3.Text - AGE_DIA3.Text
                    If CAP_DIA3.Text <> 0 Then
                        CAP_DIA3.Size = New Size(115, 15)
                        If CAP_DIA3.Size.Width >= (115 * CDbl(AGE_DIA3.Text) / CDbl(CAP_DIA3.Text)) Then
                            AGE_DIA3.Size = New Size((115) * CDbl(AGE_DIA3.Text) / CDbl(CAP_DIA3.Text), 15)
                        Else
                            AGE_DIA3.Size = New Size(115, 15)
                        End If
                        DIS_DIA3.Size = New Size((115) * CDbl(DIS_DIA3.Text) / CDbl(CAP_DIA3.Text), 15)

                        LBL_PORCENT_DIA3.Text = CInt(CDbl(AGE_DIA3.Text) * 100 / CDbl(CAP_DIA3.Text))
                        LBL_PORC3.Text = "%"
                        LBL_OCUPACION3.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA3.Size = New Size(30, 15)
                        If AGE_DIA3.Text <> 0 Then
                            AGE_DIA3.Size = New Size(30, 15)
                        Else
                            AGE_DIA3.Size = New Size(15, 15)
                        End If
                        DIS_DIA3.Visible = False
                        LBL_PORCENT_DIA3.Text = ""
                        LBL_PORC3.Text = ""
                        LBL_OCUPACION3.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA3.Location = New Point(AGE_DIA3.Location.X + AGE_DIA3.Size.Width, AGE_DIA3.Location.Y)
                Case 4
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA4.Text = AGE_DIA4.Text + TIEMPO_AGENDA
                    DIS_DIA4.Text = CAP_DIA4.Text - AGE_DIA4.Text
                    If CAP_DIA4.Text <> 0 Then
                        CAP_DIA4.Size = New Size(115, 15)
                        If CAP_DIA4.Size.Width >= (115 * CDbl(AGE_DIA4.Text) / CDbl(CAP_DIA4.Text)) Then
                            AGE_DIA4.Size = New Size((115) * CDbl(AGE_DIA4.Text) / CDbl(CAP_DIA4.Text), 15)
                        Else
                            AGE_DIA4.Size = New Size(115, 15)
                        End If
                        DIS_DIA4.Size = New Size((115) * CDbl(DIS_DIA4.Text) / CDbl(CAP_DIA4.Text), 15)

                        LBL_PORCENT_DIA4.Text = CInt(CDbl(AGE_DIA4.Text) * 100 / CDbl(CAP_DIA4.Text))
                        LBL_PORC4.Text = "%"
                        LBL_OCUPACION4.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA4.Size = New Size(30, 15)
                        If AGE_DIA4.Text <> 0 Then
                            AGE_DIA4.Size = New Size(30, 15)
                        Else
                            AGE_DIA4.Size = New Size(15, 15)
                        End If
                        DIS_DIA4.Visible = False
                        LBL_PORCENT_DIA4.Text = ""
                        LBL_PORC4.Text = ""
                        LBL_OCUPACION4.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA4.Location = New Point(AGE_DIA4.Location.X + AGE_DIA4.Size.Width, AGE_DIA4.Location.Y)
                Case 5
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA5.Text = AGE_DIA5.Text + TIEMPO_AGENDA
                    DIS_DIA5.Text = CAP_DIA5.Text - AGE_DIA5.Text
                    If CAP_DIA5.Text <> 0 Then
                        CAP_DIA5.Size = New Size(115, 15)
                        If CAP_DIA5.Size.Width >= (115 * CDbl(AGE_DIA5.Text) / CDbl(CAP_DIA5.Text)) Then
                            AGE_DIA5.Size = New Size((115) * CDbl(AGE_DIA5.Text) / CDbl(CAP_DIA5.Text), 15)
                        Else
                            AGE_DIA5.Size = New Size(115, 15)
                        End If
                        DIS_DIA5.Size = New Size((115) * CDbl(DIS_DIA5.Text) / CDbl(CAP_DIA5.Text), 15)

                        LBL_PORCENT_DIA5.Text = CInt(CDbl(AGE_DIA5.Text) * 100 / CDbl(CAP_DIA5.Text))
                        LBL_PORC5.Text = "%"
                        LBL_OCUPACION5.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA5.Size = New Size(30, 15)
                        If AGE_DIA5.Text <> 0 Then
                            AGE_DIA5.Size = New Size(30, 15)
                        Else
                            AGE_DIA5.Size = New Size(15, 15)
                        End If
                        DIS_DIA5.Visible = False
                        LBL_PORCENT_DIA5.Text = ""
                        LBL_PORC5.Text = ""
                        LBL_OCUPACION5.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA5.Location = New Point(AGE_DIA5.Location.X + AGE_DIA5.Size.Width, AGE_DIA5.Location.Y)
                Case 6
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA6.Text = AGE_DIA6.Text + TIEMPO_AGENDA
                    DIS_DIA6.Text = CAP_DIA6.Text - AGE_DIA6.Text
                    If CAP_DIA6.Text <> 0 Then
                        CAP_DIA6.Size = New Size(115, 15)
                        If CAP_DIA6.Size.Width >= (115 * CDbl(AGE_DIA6.Text) / CDbl(CAP_DIA6.Text)) Then
                            AGE_DIA6.Size = New Size((115) * CDbl(AGE_DIA6.Text) / CDbl(CAP_DIA6.Text), 15)
                        Else
                            AGE_DIA6.Size = New Size(115, 15)
                        End If
                        DIS_DIA6.Size = New Size((115) * CDbl(DIS_DIA6.Text) / CDbl(CAP_DIA6.Text), 15)

                        LBL_PORCENT_DIA6.Text = CInt(CDbl(AGE_DIA6.Text) * 100 / CDbl(CAP_DIA6.Text))
                        LBL_PORC6.Text = "%"
                        LBL_OCUPACION6.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA6.Size = New Size(30, 15)
                        If AGE_DIA6.Text <> 0 Then
                            AGE_DIA6.Size = New Size(30, 15)
                        Else
                            AGE_DIA6.Size = New Size(15, 15)
                        End If
                        DIS_DIA6.Visible = False
                        LBL_PORCENT_DIA6.Text = ""
                        LBL_PORC6.Text = ""
                        LBL_OCUPACION6.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA6.Location = New Point(AGE_DIA6.Location.X + AGE_DIA6.Size.Width, AGE_DIA6.Location.Y)
                Case 7
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA7.Text = AGE_DIA7.Text + TIEMPO_AGENDA
                    DIS_DIA7.Text = CAP_DIA7.Text - AGE_DIA7.Text
                    If CAP_DIA7.Text <> 0 Then
                        CAP_DIA7.Size = New Size(115, 15)
                        If CAP_DIA7.Size.Width >= (115 * CDbl(AGE_DIA7.Text) / CDbl(CAP_DIA7.Text)) Then
                            AGE_DIA7.Size = New Size((115) * CDbl(AGE_DIA7.Text) / CDbl(CAP_DIA7.Text), 15)
                        Else
                            AGE_DIA7.Size = New Size(115, 15)
                        End If
                        DIS_DIA7.Size = New Size((115) * CDbl(DIS_DIA7.Text) / CDbl(CAP_DIA7.Text), 15)

                        LBL_PORCENT_DIA7.Text = CInt(CDbl(AGE_DIA7.Text) * 100 / CDbl(CAP_DIA7.Text))
                        LBL_PORC7.Text = "%"
                        LBL_OCUPACION7.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA7.Size = New Size(30, 15)
                        If AGE_DIA7.Text <> 0 Then
                            AGE_DIA7.Size = New Size(30, 15)
                        Else
                            AGE_DIA7.Size = New Size(15, 15)
                        End If
                        DIS_DIA7.Visible = False
                        LBL_PORCENT_DIA7.Text = ""
                        LBL_PORC7.Text = ""
                        LBL_OCUPACION7.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA7.Location = New Point(AGE_DIA7.Location.X + AGE_DIA7.Size.Width, AGE_DIA7.Location.Y)
                Case 8
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA8.Text = AGE_DIA8.Text + TIEMPO_AGENDA
                    DIS_DIA8.Text = CAP_DIA8.Text - AGE_DIA8.Text
                    If CAP_DIA8.Text <> 0 Then
                        CAP_DIA8.Size = New Size(115, 15)
                        If CAP_DIA8.Size.Width >= (115 * CDbl(AGE_DIA8.Text) / CDbl(CAP_DIA8.Text)) Then
                            AGE_DIA8.Size = New Size((115) * CDbl(AGE_DIA8.Text) / CDbl(CAP_DIA8.Text), 15)
                        Else
                            AGE_DIA8.Size = New Size(115, 15)
                        End If
                        DIS_DIA8.Size = New Size((115) * CDbl(DIS_DIA8.Text) / CDbl(CAP_DIA8.Text), 15)

                        LBL_PORCENT_DIA8.Text = CInt(CDbl(AGE_DIA8.Text) * 100 / CDbl(CAP_DIA8.Text))
                        LBL_PORC8.Text = "%"
                        LBL_OCUPACION8.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA8.Size = New Size(30, 15)
                        If AGE_DIA8.Text <> 0 Then
                            AGE_DIA8.Size = New Size(30, 15)
                        Else
                            AGE_DIA8.Size = New Size(15, 15)
                        End If
                        DIS_DIA8.Visible = False
                        LBL_PORCENT_DIA8.Text = ""
                        LBL_PORC8.Text = ""
                        LBL_OCUPACION8.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA8.Location = New Point(AGE_DIA8.Location.X + AGE_DIA8.Size.Width, AGE_DIA8.Location.Y)
                Case 9
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA9.Text = AGE_DIA9.Text + TIEMPO_AGENDA
                    DIS_DIA9.Text = CAP_DIA9.Text - AGE_DIA9.Text
                    If CAP_DIA9.Text <> 0 Then
                        CAP_DIA9.Size = New Size(115, 15)
                        If CAP_DIA9.Size.Width >= (115 * CDbl(AGE_DIA9.Text) / CDbl(CAP_DIA9.Text)) Then
                            AGE_DIA9.Size = New Size((115) * CDbl(AGE_DIA9.Text) / CDbl(CAP_DIA9.Text), 15)
                        Else
                            AGE_DIA9.Size = New Size(115, 15)
                        End If
                        DIS_DIA9.Size = New Size((115) * CDbl(DIS_DIA9.Text) / CDbl(CAP_DIA9.Text), 15)

                        LBL_PORCENT_DIA9.Text = CInt(CDbl(AGE_DIA9.Text) * 100 / CDbl(CAP_DIA9.Text))
                        LBL_PORC9.Text = "%"
                        LBL_OCUPACION9.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA9.Size = New Size(30, 15)
                        If AGE_DIA9.Text <> 0 Then
                            AGE_DIA9.Size = New Size(30, 15)
                        Else
                            AGE_DIA9.Size = New Size(15, 15)
                        End If
                        DIS_DIA9.Visible = False
                        LBL_PORCENT_DIA9.Text = ""
                        LBL_PORC9.Text = ""
                        LBL_OCUPACION9.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA9.Location = New Point(AGE_DIA9.Location.X + AGE_DIA9.Size.Width, AGE_DIA9.Location.Y)
                Case 10
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA10.Text = AGE_DIA10.Text + TIEMPO_AGENDA
                    DIS_DIA10.Text = CAP_DIA10.Text - AGE_DIA10.Text
                    If CAP_DIA10.Text <> 0 Then
                        CAP_DIA10.Size = New Size(115, 15)
                        If CAP_DIA10.Size.Width >= (115 * CDbl(AGE_DIA10.Text) / CDbl(CAP_DIA10.Text)) Then
                            AGE_DIA10.Size = New Size((115) * CDbl(AGE_DIA10.Text) / CDbl(CAP_DIA10.Text), 15)
                        Else
                            AGE_DIA10.Size = New Size(115, 15)
                        End If
                        DIS_DIA10.Size = New Size((115) * CDbl(DIS_DIA10.Text) / CDbl(CAP_DIA10.Text), 15)

                        LBL_PORCENT_DIA10.Text = CInt(CDbl(AGE_DIA10.Text) * 100 / CDbl(CAP_DIA10.Text))
                        LBL_PORC10.Text = "%"
                        LBL_OCUPACION10.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA10.Size = New Size(30, 15)
                        If AGE_DIA10.Text <> 0 Then
                            AGE_DIA10.Size = New Size(30, 15)
                        Else
                            AGE_DIA10.Size = New Size(15, 15)
                        End If
                        DIS_DIA10.Visible = False
                        LBL_PORCENT_DIA10.Text = ""
                        LBL_PORC10.Text = ""
                        LBL_OCUPACION10.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA10.Location = New Point(AGE_DIA10.Location.X + AGE_DIA10.Size.Width, AGE_DIA10.Location.Y)
                Case 11
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA11.Text = AGE_DIA11.Text + TIEMPO_AGENDA
                    DIS_DIA11.Text = CAP_DIA11.Text - AGE_DIA11.Text
                    If CAP_DIA11.Text <> 0 Then
                        CAP_DIA11.Size = New Size(115, 15)
                        If CAP_DIA11.Size.Width >= (115 * CDbl(AGE_DIA11.Text) / CDbl(CAP_DIA11.Text)) Then
                            AGE_DIA11.Size = New Size((115) * CDbl(AGE_DIA11.Text) / CDbl(CAP_DIA11.Text), 15)
                        Else
                            AGE_DIA11.Size = New Size(115, 15)
                        End If
                        DIS_DIA11.Size = New Size((115) * CDbl(DIS_DIA11.Text) / CDbl(CAP_DIA11.Text), 15)

                        LBL_PORCENT_DIA11.Text = CInt(CDbl(AGE_DIA11.Text) * 100 / CDbl(CAP_DIA11.Text))
                        LBL_PORC11.Text = "%"
                        LBL_OCUPACION11.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA11.Size = New Size(30, 15)
                        If AGE_DIA11.Text <> 0 Then
                            AGE_DIA11.Size = New Size(30, 15)
                        Else
                            AGE_DIA11.Size = New Size(15, 15)
                        End If
                        DIS_DIA11.Visible = False
                        LBL_PORCENT_DIA11.Text = ""
                        LBL_PORC11.Text = ""
                        LBL_OCUPACION11.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA11.Location = New Point(AGE_DIA11.Location.X + AGE_DIA11.Size.Width, AGE_DIA11.Location.Y)
                Case 12
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA12.Text = AGE_DIA12.Text + TIEMPO_AGENDA
                    DIS_DIA12.Text = CAP_DIA12.Text - AGE_DIA12.Text
                    If CAP_DIA12.Text <> 0 Then
                        CAP_DIA12.Size = New Size(115, 15)
                        If CAP_DIA12.Size.Width >= (115 * CDbl(AGE_DIA12.Text) / CDbl(CAP_DIA12.Text)) Then
                            AGE_DIA12.Size = New Size((115) * CDbl(AGE_DIA12.Text) / CDbl(CAP_DIA12.Text), 15)
                        Else
                            AGE_DIA12.Size = New Size(115, 15)
                        End If
                        DIS_DIA12.Size = New Size((115) * CDbl(DIS_DIA12.Text) / CDbl(CAP_DIA12.Text), 15)

                        LBL_PORCENT_DIA12.Text = CInt(CDbl(AGE_DIA12.Text) * 100 / CDbl(CAP_DIA12.Text))
                        LBL_PORC12.Text = "%"
                        LBL_OCUPACION12.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA12.Size = New Size(30, 15)
                        If AGE_DIA12.Text <> 0 Then
                            AGE_DIA12.Size = New Size(30, 15)
                        Else
                            AGE_DIA12.Size = New Size(15, 15)
                        End If
                        DIS_DIA12.Visible = False
                        LBL_PORCENT_DIA12.Text = ""
                        LBL_PORC12.Text = ""
                        LBL_OCUPACION12.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA12.Location = New Point(AGE_DIA12.Location.X + AGE_DIA12.Size.Width, AGE_DIA12.Location.Y)
                Case 13
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA13.Text = AGE_DIA13.Text + TIEMPO_AGENDA
                    DIS_DIA13.Text = CAP_DIA13.Text - AGE_DIA13.Text
                    If CAP_DIA13.Text <> 0 Then
                        CAP_DIA13.Size = New Size(115, 15)
                        If CAP_DIA13.Size.Width >= (115 * CDbl(AGE_DIA13.Text) / CDbl(CAP_DIA13.Text)) Then
                            AGE_DIA13.Size = New Size((115) * CDbl(AGE_DIA13.Text) / CDbl(CAP_DIA13.Text), 15)
                        Else
                            AGE_DIA13.Size = New Size(115, 15)
                        End If
                        DIS_DIA13.Size = New Size((115) * CDbl(DIS_DIA13.Text) / CDbl(CAP_DIA13.Text), 15)

                        LBL_PORCENT_DIA13.Text = CInt(CDbl(AGE_DIA13.Text) * 100 / CDbl(CAP_DIA13.Text))
                        LBL_PORC13.Text = "%"
                        LBL_OCUPACION13.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA13.Size = New Size(30, 15)
                        If AGE_DIA13.Text <> 0 Then
                            AGE_DIA13.Size = New Size(30, 15)
                        Else
                            AGE_DIA13.Size = New Size(15, 15)
                        End If
                        DIS_DIA13.Visible = False
                        LBL_PORCENT_DIA13.Text = ""
                        LBL_PORC13.Text = ""
                        LBL_OCUPACION13.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA13.Location = New Point(AGE_DIA13.Location.X + AGE_DIA13.Size.Width, AGE_DIA13.Location.Y)
                Case 14
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA14.Text = AGE_DIA14.Text + TIEMPO_AGENDA
                    DIS_DIA14.Text = CAP_DIA14.Text - AGE_DIA14.Text
                    If CAP_DIA14.Text <> 0 Then
                        CAP_DIA14.Size = New Size(115, 15)
                        If CAP_DIA14.Size.Width >= (115 * CDbl(AGE_DIA14.Text) / CDbl(CAP_DIA14.Text)) Then
                            AGE_DIA14.Size = New Size((115) * CDbl(AGE_DIA14.Text) / CDbl(CAP_DIA14.Text), 15)
                        Else
                            AGE_DIA14.Size = New Size(115, 15)
                        End If
                        DIS_DIA14.Size = New Size((115) * CDbl(DIS_DIA14.Text) / CDbl(CAP_DIA14.Text), 15)

                        LBL_PORCENT_DIA14.Text = CInt(CDbl(AGE_DIA14.Text) * 100 / CDbl(CAP_DIA14.Text))
                        LBL_PORC14.Text = "%"
                        LBL_OCUPACION14.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA14.Size = New Size(30, 15)
                        If AGE_DIA14.Text <> 0 Then
                            AGE_DIA14.Size = New Size(30, 15)
                        Else
                            AGE_DIA14.Size = New Size(15, 15)
                        End If
                        DIS_DIA14.Visible = False
                        LBL_PORCENT_DIA14.Text = ""
                        LBL_PORC14.Text = ""
                        LBL_OCUPACION14.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA14.Location = New Point(AGE_DIA14.Location.X + AGE_DIA14.Size.Width, AGE_DIA14.Location.Y)
                Case 15
                    'MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                    AGE_DIA15.Text = AGE_DIA15.Text + TIEMPO_AGENDA
                    DIS_DIA15.Text = CAP_DIA15.Text - AGE_DIA15.Text
                    If CAP_DIA15.Text <> 0 Then
                        CAP_DIA15.Size = New Size(115, 15)
                        If CAP_DIA15.Size.Width >= (115 * CDbl(AGE_DIA15.Text) / CDbl(CAP_DIA15.Text)) Then
                            AGE_DIA15.Size = New Size((115) * CDbl(AGE_DIA15.Text) / CDbl(CAP_DIA15.Text), 15)
                        Else
                            AGE_DIA15.Size = New Size(115, 15)
                        End If
                        DIS_DIA15.Size = New Size((115) * CDbl(DIS_DIA15.Text) / CDbl(CAP_DIA15.Text), 15)

                        LBL_PORCENT_DIA15.Text = CInt(CDbl(AGE_DIA15.Text) * 100 / CDbl(CAP_DIA15.Text))
                        LBL_PORC15.Text = "%"
                        LBL_OCUPACION15.Text = "OCUPACION DEL:"
                    Else
                        CAP_DIA15.Size = New Size(30, 15)
                        If AGE_DIA15.Text <> 0 Then
                            AGE_DIA15.Size = New Size(30, 15)
                        Else
                            AGE_DIA15.Size = New Size(15, 15)
                        End If
                        DIS_DIA15.Visible = False
                        LBL_PORCENT_DIA15.Text = ""
                        LBL_PORC15.Text = ""
                        LBL_OCUPACION15.Text = "SIN CAPACIDAD"
                    End If
                    DIS_DIA15.Location = New Point(AGE_DIA15.Location.X + AGE_DIA15.Size.Width, AGE_DIA15.Location.Y)
            End Select
        End If
    End Sub
    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Close()
    End Sub
    Private Sub BTN_FILL_PT_Click(sender As Object, e As EventArgs) Handles BTN_FILL_PT.Click
        DATOS.SECTOR_CAP = "PT"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_FILL_PT.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_FILL_SU.BackgroundImage = Nothing
        BTN_FILL_TODOS.BackgroundImage = Nothing
        BTN_FILL_COO.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_FILL_TODOS_Click(sender As Object, e As EventArgs) Handles BTN_FILL_TODOS.Click
        DATOS.SECTOR_CAP = "TODOS"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_FILL_TODOS.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_FILL_SU.BackgroundImage = Nothing
        BTN_FILL_PT.BackgroundImage = Nothing
        BTN_FILL_COO.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_FILL_SU_Click(sender As Object, e As EventArgs) Handles BTN_FILL_SU.Click
        DATOS.SECTOR_CAP = "SU"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_FILL_SU.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_FILL_TODOS.BackgroundImage = Nothing
        BTN_FILL_PT.BackgroundImage = Nothing
        BTN_FILL_COO.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_FILL_COO_Click(sender As Object, e As EventArgs) Handles BTN_FILL_COO.Click
        DATOS.SECTOR_CAP = "CO"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_FILL_COO.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_FILL_TODOS.BackgroundImage = Nothing
        BTN_FILL_PT.BackgroundImage = Nothing
        BTN_FILL_SU.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_REC_TODOS_Click(sender As Object, e As EventArgs) Handles BTN_REC_TODOS.Click
        DATOS.RECURSO_CAP = "TODOS"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_REC_TODOS.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_REC_TEC.BackgroundImage = Nothing
        BTN_REC_CUA.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_REC_TEC_Click(sender As Object, e As EventArgs) Handles BTN_REC_TEC.Click
        DATOS.RECURSO_CAP = "TEC"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_REC_TEC.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_REC_TODOS.BackgroundImage = Nothing
        BTN_REC_CUA.BackgroundImage = Nothing
    End Sub
    Private Sub BTN_REC_CUA_Click(sender As Object, e As EventArgs) Handles BTN_REC_CUA.Click
        DATOS.RECURSO_CAP = "CUA"
        MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
        BTN_REC_CUA.BackgroundImage = My.Resources.BTN_AGENDA_ACTIVO
        BTN_REC_TODOS.BackgroundImage = Nothing
        BTN_REC_TEC.BackgroundImage = Nothing
    End Sub


    'INICIO CONFIGUGACION BOTONES
    'BOTON 1
    Private Sub LBL_PORCENT_DIA1_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA1.MouseHover
        HOVER_DIA = 1
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P1_MouseHover(sender As Object, e As EventArgs) Handles P1.MouseHover
        HOVER_DIA = 1
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA1_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA1.Click
        BOTON_CLICK(LBL_DIA1.Text, "ALTA", CAP_DIA1.Text)
    End Sub
    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click
        BOTON_CLICK(LBL_DIA1.Text, "ALTA", CAP_DIA1.Text)
    End Sub
    'BOTON 2
    Private Sub LBL_PORCENT_DIA2_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA2.MouseHover
        HOVER_DIA = 2
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P2_MouseHover(sender As Object, e As EventArgs) Handles P2.MouseHover
        HOVER_DIA = 2
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA2_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA2.Click
        BOTON_CLICK(LBL_DIA2.Text, "ALTA", CAP_DIA2.Text)
    End Sub
    Private Sub P2_Click(sender As Object, e As EventArgs) Handles P2.Click
        BOTON_CLICK(LBL_DIA2.Text, "ALTA", CAP_DIA2.Text)
    End Sub
    'BOTON 3
    Private Sub LBL_PORCENT_DIA3_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA3.MouseHover
        HOVER_DIA = 3
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P3_MouseHover(sender As Object, e As EventArgs) Handles P3.MouseHover
        HOVER_DIA = 3
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA3_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA3.Click
        BOTON_CLICK(LBL_DIA3.Text, "ALTA", CAP_DIA3.Text)
    End Sub
    Private Sub P3_Click(sender As Object, e As EventArgs) Handles P3.Click
        BOTON_CLICK(LBL_DIA3.Text, "ALTA", CAP_DIA3.Text)
    End Sub
    'BOTON 4
    Private Sub LBL_PORCENT_DIA4_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA4.MouseHover
        HOVER_DIA = 4
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P4_MouseHover(sender As Object, e As EventArgs) Handles P4.MouseHover
        HOVER_DIA = 4
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA4_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA4.Click
        BOTON_CLICK(LBL_DIA4.Text, "ALTA", CAP_DIA4.Text)
    End Sub
    Private Sub P4_Click(sender As Object, e As EventArgs) Handles P4.Click
        BOTON_CLICK(LBL_DIA4.Text, "ALTA", CAP_DIA4.Text)
    End Sub
    'BOTON 5
    Private Sub LBL_PORCENT_DIA5_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA5.MouseHover
        HOVER_DIA = 5
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P5_MouseHover(sender As Object, e As EventArgs) Handles P5.MouseHover
        HOVER_DIA = 5
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA5_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA5.Click
        BOTON_CLICK(LBL_DIA5.Text, "ALTA", CAP_DIA5.Text)
    End Sub
    Private Sub P5_Click(sender As Object, e As EventArgs) Handles P5.Click
        BOTON_CLICK(LBL_DIA5.Text, "ALTA", CAP_DIA5.Text)
    End Sub
    'BOTON 6
    Private Sub LBL_PORCENT_DIA6_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA6.MouseHover
        HOVER_DIA = 6
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P6_MouseHover(sender As Object, e As EventArgs) Handles P6.MouseHover
        HOVER_DIA = 6
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA6_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA6.Click
        BOTON_CLICK(LBL_DIA1.Text, "MEDIA", CAP_DIA6.Text)
    End Sub
    Private Sub P6_Click(sender As Object, e As EventArgs) Handles P6.Click
        BOTON_CLICK(LBL_DIA1.Text, "MEDIA", CAP_DIA6.Text)
    End Sub
    'BOTON 7
    Private Sub LBL_PORCENT_DIA7_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA7.MouseHover
        HOVER_DIA = 7
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P7_MouseHover(sender As Object, e As EventArgs) Handles P7.MouseHover
        HOVER_DIA = 7
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA7_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA7.Click
        BOTON_CLICK(LBL_DIA2.Text, "MEDIA", CAP_DIA7.Text)
    End Sub
    Private Sub P7_Click(sender As Object, e As EventArgs) Handles P7.Click
        BOTON_CLICK(LBL_DIA2.Text, "MEDIA", CAP_DIA7.Text)
    End Sub
    'BOTON 8
    Private Sub LBL_PORCENT_DIA8_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA8.MouseHover
        HOVER_DIA = 8
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P8_MouseHover(sender As Object, e As EventArgs) Handles P8.MouseHover
        HOVER_DIA = 8
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA8_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA8.Click
        BOTON_CLICK(LBL_DIA3.Text, "MEDIA", CAP_DIA8.Text)
    End Sub
    Private Sub P8_Click(sender As Object, e As EventArgs) Handles P8.Click
        BOTON_CLICK(LBL_DIA3.Text, "MEDIA", CAP_DIA8.Text)
    End Sub
    'BOTON 9
    Private Sub LBL_PORCENT_DIA9_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA9.MouseHover
        HOVER_DIA = 9
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P9_MouseHover(sender As Object, e As EventArgs) Handles P9.MouseHover
        HOVER_DIA = 9
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA9_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA9.Click
        BOTON_CLICK(LBL_DIA4.Text, "MEDIA", CAP_DIA9.Text)
    End Sub
    Private Sub P9_Click(sender As Object, e As EventArgs) Handles P9.Click
        BOTON_CLICK(LBL_DIA4.Text, "MEDIA", CAP_DIA9.Text)
    End Sub
    'BOTON 10
    Private Sub LBL_PORCENT_DIA10_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA10.MouseHover
        HOVER_DIA = 10
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P10_MouseHover(sender As Object, e As EventArgs) Handles P10.MouseHover
        HOVER_DIA = 10
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA10_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA10.Click
        BOTON_CLICK(LBL_DIA5.Text, "MEDIA", CAP_DIA10.Text)
    End Sub
    Private Sub P10_Click(sender As Object, e As EventArgs) Handles P10.Click
        BOTON_CLICK(LBL_DIA5.Text, "MEDIA", CAP_DIA10.Text)
    End Sub
    'BOTON 11
    Private Sub LBL_PORCENT_DIA11_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA11.MouseHover
        HOVER_DIA = 11
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P11_MouseHover(sender As Object, e As EventArgs) Handles P11.MouseHover
        HOVER_DIA = 11
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA11_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA11.Click
        BOTON_CLICK(LBL_DIA1.Text, "BAJA", CAP_DIA11.Text)
    End Sub
    Private Sub P11_Click(sender As Object, e As EventArgs) Handles P11.Click
        BOTON_CLICK(LBL_DIA1.Text, "BAJA", CAP_DIA11.Text)
    End Sub
    'BOTON 12
    Private Sub LBL_PORCENT_DIA12_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA12.MouseHover
        HOVER_DIA = 12
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P12_MouseHover(sender As Object, e As EventArgs) Handles P12.MouseHover
        HOVER_DIA = 12
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA12_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA12.Click
        BOTON_CLICK(LBL_DIA2.Text, "BAJA", CAP_DIA12.Text)
    End Sub
    Private Sub P12_Click(sender As Object, e As EventArgs) Handles P12.Click
        BOTON_CLICK(LBL_DIA2.Text, "BAJA", CAP_DIA12.Text)
    End Sub
    'BOTON 13
    Private Sub LBL_PORCENT_DIA13_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA13.MouseHover
        HOVER_DIA = 13
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P13_MouseHover(sender As Object, e As EventArgs) Handles P13.MouseHover
        HOVER_DIA = 13
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA13_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA13.Click
        BOTON_CLICK(LBL_DIA3.Text, "BAJA", CAP_DIA13.Text)
    End Sub
    Private Sub P13_Click(sender As Object, e As EventArgs) Handles P13.Click
        BOTON_CLICK(LBL_DIA3.Text, "BAJA", CAP_DIA13.Text)
    End Sub
    'BOTON 14
    Private Sub LBL_PORCENT_DIA14_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA14.MouseHover
        HOVER_DIA = 14
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P14_MouseHover(sender As Object, e As EventArgs) Handles P14.MouseHover
        HOVER_DIA = 14
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA14_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA14.Click
        BOTON_CLICK(LBL_DIA4.Text, "BAJA", CAP_DIA14.Text)
    End Sub
    Private Sub P14_Click(sender As Object, e As EventArgs) Handles P14.Click
        BOTON_CLICK(LBL_DIA4.Text, "BAJA", CAP_DIA14.Text)
    End Sub
    'BOTON 15
    Private Sub LBL_PORCENT_DIA15_MouseHover(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA15.MouseHover
        HOVER_DIA = 15
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub P15_MouseHover(sender As Object, e As EventArgs) Handles P15.MouseHover
        HOVER_DIA = 15
        BORRAR_BTN_DIA()
        RECALCULA_CAPACIDADES()
    End Sub
    Private Sub LBL_PORCENT_DIA15_Click(sender As Object, e As EventArgs) Handles LBL_PORCENT_DIA15.Click
        BOTON_CLICK(LBL_DIA5.Text, "BAJA", CAP_DIA15.Text)
    End Sub
    Private Sub P15_Click(sender As Object, e As EventArgs) Handles P15.Click
        BOTON_CLICK(LBL_DIA5.Text, "BAJA", CAP_DIA15.Text)
    End Sub
    'FIN BOTONES
    Private Sub BOTON_CLICK(ByVal FECHAAGENDAR As Date, ByVal PRIORIDAD_AG As String, ByVal CAPACIDAD As Integer)
        If CAPACIDAD = 0 Then
            NOTIFICACION("SYS", "SIN CAPACIDAD EN AGENDA")
        Else
            Select Case ACCION_AGENDA
                Case "AGENDAR", "REAGENDAR"
                    ACCIONES(FECHAAGENDAR, PRIORIDAD_AG)
                Case "VER AGENDA"
                    If VER_ORD_AGENDA.Visible = True Then
                        VER_ORD_AGENDA.BringToFront()
                    Else
                        FECHAAGENDA = FECHAAGENDAR
                        PRIORIDAD = PRIORIDAD_AG
                        VER_ORD_AGENDA.Show(Me)
                    End If
            End Select
        End If
    End Sub
    Private Sub ACCIONES(ByVal DIA_A_AGENDAR As String, ByVal PRIORIDAD_AGENDA As String)
        Cursor = Cursors.WaitCursor
        Select Case ACCION_AGENDA 'MODIFICA LA CAPACIDAD DE LA AGENDA SEGUN LA ACCION A TOMAR
            Case "AGENDAR"
                'Select Case DATOS.ORDEN_TIPODEPENDENCIA
                'TRATAMIENTO DE ORDEN TIPO INDEPENDIENTE O DINAMICA
                'Case "IND", "DIN"
                '    DATOS.DATOS_ORDENESRow.FECHAAGEND = DIA_A_AGENDAR
                '    DATOS.DATOS_ORDENESRow.FECHAINICESTIMADO = DIA_A_AGENDAR
                '    DATOS.DATOS_ORDENESRow.DESAGENDAR = False
                '    If DATOS.DATOS_ORDENESRow.CREARORDINAL = False And DATOS.DATOS_ORDENESRow.NRO_ORDINAL = 0 Then
                '        DATOS.DATOS_ORDENESRow.CREARORDINAL = True
                '    End If
                '    DATOS.DATOS_ORDENESRow.AGENDAR = True
                '    DATOS.DATOS_ORDENESRow.COORDINAR = False
                '    DATOS.DATOS_ORDENESRow.SECTORGEN = DATOS.SECTOR_CAP
                '    Select Case DATOS.DATOS_ORDENESRow("COORDINAR")
                '        Case True
                '            DATOS.DATOS_ORDENESRow.STATUS = "COORDINADO"
                '        Case Else
                '            DATOS.DATOS_ORDENESRow.STATUS = "AGENDADO"
                '    End Select
                '    DATOS.DATOS_ORDENESRow.PRIORIDAD = PRIORIDAD_AGENDA
                '    DATOS.ORDENESTableAdapter.Update(DATOS.DATOS_ORDENESRow)

                'Case "EST" 'TRATAMIENTO DE ORDEN TIPO ESTRICTA
                For A = 0 To DATOS.CANT_ORDENESAAGENDAR - 1
                    ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, DATOS.ORDEN_EST(A))
                    ORDENAAgendarROW = ORDENESDataSet.ORDENES.Rows(0)
                    If ORDENAAgendarROW.CREARORDINAL = False And ORDENAAgendarROW.NRO_ORDINAL = 0 Then
                        ORDENAAgendarROW.CREARORDINAL = True
                    End If
                    ORDENAAgendarROW.FECHAAGEND = DIA_A_AGENDAR
                    ORDENAAgendarROW.FECHAINICESTIMADO = DIA_A_AGENDAR
                    ORDENAAgendarROW.DESAGENDAR = False
                    ORDENAAgendarROW.AGENDAR = True
                    ORDENAAgendarROW.COORDINAR = False
                    ORDENAAgendarROW.SECTORGEN = DATOS.SECTOR_CAP
                    ORDENAAgendarROW.PRIORIDAD = PRIORIDAD_AGENDA

                    Select Case ORDENAAgendarROW("STATUS")
                        Case "COORDINADO"
                            ORDENAAgendarROW.STATUS = "COORDINADO"
                        Case "RUTEADO"
                            ORDENAAgendarROW.STATUS = "RUTEADO"
                        Case Else
                            ORDENAAgendarROW.STATUS = "AGENDADO"
                    End Select
                    DATOS.ORDENESTableAdapter.Update(ORDENAAgendarROW)
                Next
                'End Select
                'CARGA LA CAPACIDAD DEL DIA A AGENDAR
                CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, DIA_A_AGENDAR)
                CAPACIDADDIARow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)

                'MODIFICAMOS CAPACIDAD DEL DIA A AGENDAR
                Select Case DATOS.SECTOR_CAP
                    Case "PT"
                        Select Case DATOS.RECURSO_CAP
                            Case "TEC"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_TEC_PT_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_TEC_PT_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_TEC_PT_AGE += TIEMPO_AGENDA
                                End Select
                            Case "CUA"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_CUA_PT_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_CUA_PT_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_CUA_PT_AGE += TIEMPO_AGENDA
                                End Select
                        End Select

                    Case "SU"
                        Select Case DATOS.RECURSO_CAP
                            Case "TEC"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_TEC_SU_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_TEC_SU_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_TEC_SU_AGE += TIEMPO_AGENDA
                                End Select
                            Case "CUA"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_CUA_SU_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_CUA_SU_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_CUA_SU_AGE += TIEMPO_AGENDA
                                End Select
                        End Select
                    Case "CO"
                        Select Case DATOS.RECURSO_CAP
                            Case "TEC"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_TEC_CO_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_TEC_CO_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_TEC_CO_AGE += TIEMPO_AGENDA
                                End Select
                            Case "CUA"
                                Select Case PRIORIDAD_AGENDA
                                    Case "ALTA"
                                        CAPACIDADDIARow.MIN_ALT_CUA_CO_AGE += TIEMPO_AGENDA
                                    Case "MEDIA"
                                        CAPACIDADDIARow.MIN_MED_CUA_CO_AGE += TIEMPO_AGENDA
                                    Case "BAJA"
                                        CAPACIDADDIARow.MIN_BAJ_CUA_CO_AGE += TIEMPO_AGENDA
                                End Select
                        End Select
                End Select
                CAPACIDAXDIATableAdapter.Update(CAPACIDADDIARow)
                DATOS.ORDENESTableAdapter.FillByIDTRABAJO(DATOS.ORDENESDataSet.ORDENES, DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
                Close()
            Case "REAGENDAR"
                VER_ORD_AGENDA.DESAGENDAR_ORDEN(VER_ORD_AGENDA.DGVOrdenes, FECHAAGENDA, "AGENDA")
                For X = 0 To VER_ORD_AGENDA.CANTIDAD_ORDENES - 1
                    ORDENESTableAdapter.FillByIDORDENINT(ORDENESDataSet.ORDENES, VER_ORD_AGENDA.ORDEN_AG(X))
                    ORDENAAgendarROW = ORDENESDataSet.ORDENES.Rows(0)
                    If ORDENAAgendarROW.CREARORDINAL = False And ORDENAAgendarROW.NRO_ORDINAL = 0 Then
                        ORDENAAgendarROW.CREARORDINAL = True
                    End If
                    ORDENAAgendarROW.FECHAAGEND = DIA_A_AGENDAR
                    ORDENAAgendarROW.FECHAINICESTIMADO = DIA_A_AGENDAR
                    ORDENAAgendarROW.DESAGENDAR = False
                    ORDENAAgendarROW.AGENDAR = True
                    ORDENAAgendarROW.COORDINAR = False
                    ORDENAAgendarROW.SECTORGEN = DATOS.SECTOR_CAP
                    TIEMPO_AGENDA = (CInt(ORDENAAgendarROW.TPREVISTO * CAPACIDAD_DIA / 100))
                    ORDENAAgendarROW.PRIORIDAD = PRIORIDAD_AGENDA

                    Select Case ORDENAAgendarROW("STATUS")
                        Case "COORDINADO"
                            ORDENAAgendarROW.STATUS = "COORDINADO"
                        Case "RUTEADO"
                            ORDENAAgendarROW.STATUS = "RUTEADO"
                        Case Else
                            ORDENAAgendarROW.STATUS = "AGENDADO"
                    End Select
                    DATOS.ORDENESTableAdapter.Update(ORDENAAgendarROW)

                    'CARGA LA CAPACIDAD DEL DIA A AGENDAR
                    CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, DIA_A_AGENDAR)
                    CAPACIDADDIARow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)

                    'MODIFICAMOS CAPACIDAD DEL DIA A AGENDAR
                    Select Case DATOS.SECTOR_CAP
                        Case "PT"
                            Select Case DATOS.RECURSO_CAP
                                Case "TEC"
                                    Select Case PRIORIDAD_AGENDA
                                        Case "ALTA"
                                            CAPACIDADDIARow.MIN_ALT_TEC_PT_AGE += TIEMPO_AGENDA
                                        Case "MEDIA"
                                            CAPACIDADDIARow.MIN_MED_TEC_PT_AGE += TIEMPO_AGENDA
                                        Case "BAJA"
                                            CAPACIDADDIARow.MIN_BAJ_TEC_PT_AGE += TIEMPO_AGENDA
                                    End Select
                                Case "CUA"
                                    Select Case PRIORIDAD_AGENDA
                                        Case "ALTA"
                                            CAPACIDADDIARow.MIN_ALT_CUA_PT_AGE += TIEMPO_AGENDA
                                        Case "MEDIA"
                                            CAPACIDADDIARow.MIN_MED_CUA_PT_AGE += TIEMPO_AGENDA
                                        Case "BAJA"
                                            CAPACIDADDIARow.MIN_BAJ_CUA_PT_AGE += TIEMPO_AGENDA
                                    End Select
                            End Select
                        Case "SU"
                            Select Case DATOS.RECURSO_CAP
                                Case "TEC"
                                    Select Case PRIORIDAD_AGENDA
                                        Case "ALTA"
                                            CAPACIDADDIARow.MIN_ALT_TEC_SU_AGE += TIEMPO_AGENDA
                                        Case "MEDIA"
                                            CAPACIDADDIARow.MIN_MED_TEC_SU_AGE += TIEMPO_AGENDA
                                        Case "BAJA"
                                            CAPACIDADDIARow.MIN_BAJ_TEC_SU_AGE += TIEMPO_AGENDA
                                    End Select
                                Case "CUA"
                                    Select Case PRIORIDAD_AGENDA
                                        Case "ALTA"
                                            CAPACIDADDIARow.MIN_ALT_CUA_SU_AGE += TIEMPO_AGENDA
                                        Case "MEDIA"
                                            CAPACIDADDIARow.MIN_MED_CUA_SU_AGE += TIEMPO_AGENDA
                                        Case "BAJA"
                                            CAPACIDADDIARow.MIN_BAJ_CUA_SU_AGE += TIEMPO_AGENDA
                                    End Select
                            End Select
                    End Select
                    CAPACIDAXDIATableAdapter.Update(CAPACIDADDIARow)
                Next
                Select Case DATOS.SECTOR_CAP
                    Case "TODOS"
                        VER_ORD_AGENDA.ORDENESTableAdapter.FillByFECHAGEND_PRIORIDAD(VER_ORD_AGENDA.ORDENESDataSet.ORDENES, FECHAAGENDA, PRIORIDAD)
                    Case Else
                        Select Case DATOS.RECURSO_CAP
                            Case "CUA", "TEC"
                                If DATOS.RECURSO_CAP = "CUA" Then
                                    ORDENESTableAdapter.FillByAGENDA_PRIORIDAD_SECTOROPE(VER_ORD_AGENDA.ORDENESDataSet.ORDENES, FECHAAGENDA, PRIORIDAD, "CUADRILLAS", DATOS.SECTOR_CAP)
                                Else
                                    ORDENESTableAdapter.FillByAGENDA_PRIORIDAD_SECTOROPE(VER_ORD_AGENDA.ORDENESDataSet.ORDENES, FECHAAGENDA, PRIORIDAD, "MANTENIMIENTO", DATOS.SECTOR_CAP)
                                End If
                        End Select
                End Select
                VER_ORD_AGENDA.LBL_PRIORIDAD.Text = "PRIORIDAD: " & PRIORIDAD

                MOSTRAR_AGENDA(FECHAINI, FECHAFIN)
                VER_ORD_AGENDA.BTN_RESTAURAR_Click(Nothing, Nothing)
        End Select
        Cursor = Cursors.Default
    End Sub
    Private Sub BOT_CARGATEC_Click(sender As Object, e As EventArgs) Handles BOT_CARGATEC.Click
        P_LATERAL.Visible = False
        If P_CARGARTECNICO.Visible Then
            P_CARGARTECNICO.BringToFront()
        Else
            CONDICION_INI_P_AGREGARTECNICO()
            BUSCA_HORAS_P_AGREGAR_TECNICO()
            P_CARGARTECNICO.Parent = Me
            P_CARGARTECNICO.Visible = True
            P_CARGARTECNICO.Location = New Point(289, 11)
            P_CARGARTECNICO.Size = New Size(843, 659)
            BTN_CERRAR_CARGARTEC.Visible = True
            P_CARGARTECNICO.BringToFront()
        End If
    End Sub
    Private Sub BTN_VER_AGENDA_Click(sender As Object, e As EventArgs) Handles BTN_VER_AGENDA.Click
        '   P_PROCESOS.Visible = False
        ACCESO_AGENDA = "FORM_INICIO"
        ACCION_AGENDA = "VER AGENDA"
        MOSTRAR_AGENDA(Today.ToShortDateString, Today.AddDays(4).ToShortDateString)
    End Sub
    Private Sub BTN_DIA_SET15_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET15.Click

    End Sub
    Private Sub BTN_DIA_SET14_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET14.Click

    End Sub
    Private Sub BTN_DIA_SET13_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET13.Click

    End Sub
    Private Sub BTN_DIA_SET12_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET12.Click

    End Sub
    Private Sub BTN_DIA_SET11_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET11.Click

    End Sub
    Private Sub BTN_DIA_SET6_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET6.Click

    End Sub
    Private Sub BTN_DIA_SET7_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET7.Click

    End Sub
    Private Sub BTN_DIA_SET8_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET8.Click

    End Sub
    Private Sub BTN_DIA_SET9_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET9.Click

    End Sub
    Private Sub BTN_DIA_SET10_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET10.Click

    End Sub
    Private Sub BTN_DIA_SET5_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET5.Click

    End Sub
    Private Sub BTN_DIA_SET4_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET4.Click

    End Sub
    Private Sub BTN_DIA_SET3_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET3.Click

    End Sub
    Private Sub BTN_DIA_SET2_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET2.Click

    End Sub
    Private Sub BTN_DIA_SET1_Click(sender As Object, e As EventArgs) Handles BTN_DIA_SET1.Click

    End Sub
    Private Sub BTN_REASIGNAR_CAP_Click(sender As Object, e As EventArgs) Handles BTN_REASIGNAR_CAP.Click
        P_LATERAL.Visible = False
        For X = 1 To 42
            Try
                BTN_CALENDARIO_DIA(X).BackColor = Color.White
                BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)

                If CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString = Today.ToShortDateString Then
                    BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                    BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                End If
            Catch ex As Exception
            End Try
        Next
        FECHAINI = Today.ToShortDateString
        ACCION_AGENDA = "CAP_TECNICA"
        If P_REASIGNAR.Visible Then
            P_REASIGNAR.BringToFront()
        Else
            P_REASIGNAR.Parent = Me
            P_REASIGNAR.Visible = True
            P_REASIGNAR.Location = New Point(289, 11)
            P_REASIGNAR.Size = New Size(843, 659)
            BTN_CERRAR_REASIGNARCAP.Visible = True
            P_REASIGNAR.BringToFront()
        End If
        CARGAR_CAMPOS_ASIGNADOS()
    End Sub
    Private Sub BOT_PARAMAGENDA_Click(sender As Object, e As EventArgs) Handles BOT_PARAMAGENDA.Click
        LBL_ACCIONAGENDA.Text = "PARAMETROS DE AGENDA"
        P_LATERAL.Visible = False
        BTN_CERRAR_PARAMETROS.Visible = True
        P_CALENDARIO.Visible = False
        If P_PARAMETROS.Visible Then
            P_PARAMETROS.BringToFront()
        Else
            P_PARAMETROS.Parent = Me
            P_PARAMETROS.Visible = True
            P_PARAMETROS.Location = New Point(289, 11)
            P_PARAMETROS.Size = New Size(843, 659)
            P_PARAMETROS.Visible = True
            P_PARAMETROS.BringToFront()
        End If
        LOAD_PARAMETROS()
    End Sub
    Private Sub BTN_CERRAR_CARGARTEC_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_CARGARTEC.Click
        ACCION_AGENDA = "VER AGENDA"
        LBL_ACCIONAGENDA.Text = "VER AGENDA"
        P_LATERAL.Visible = True
        BTN_CERRAR_CARGARTEC.Visible = False
        P_CARGARTECNICO.Visible = False
    End Sub
    Private Sub BTN_CONTROLTECNICO_Click(sender As Object, e As EventArgs) Handles BTN_CONTROLTECNICO.Click
        For X = 1 To 42
            Try
                BTN_CALENDARIO_DIA(X).BackColor = Color.White
                BTN_CALENDARIO_DIA(X).ForeColor = Color.FromArgb(64, 64, 64)

                If CDate(BTN_CALENDARIO_DIA(X).Name).ToShortDateString = Today.ToShortDateString Then
                    BTN_CALENDARIO_DIA(X).BackColor = Color.DarkBlue
                    BTN_CALENDARIO_DIA(X).ForeColor = Color.White
                End If
            Catch ex As Exception
            End Try
        Next
        FECHAINI = Today.ToShortDateString
        LOAD_P_CONTROLTECNICO()
        ACCION_AGENDA = "CAP_TECNICA"
        LBL_ACCIONAGENDA.Text = "AUSENCIA TECNICA"
        P_LATERAL.Visible = False
        If P_CONTROLTECNICO.Visible = True Then
            P_CONTROLTECNICO.BringToFront()
        Else
            P_CONTROLTECNICO.Parent = Me
            P_CONTROLTECNICO.Visible = True
            P_CONTROLTECNICO.Location = New Point(289, 11)
            P_CONTROLTECNICO.Size = New Size(843, 659)
            BTN_CERRAR_CONTROLTECNICO.Visible = True
            P_CONTROLTECNICO.BringToFront()
        End If
    End Sub
    Private Sub BTN_CERRAR_CONTROLTECNICO_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_CONTROLTECNICO.Click
        P_CONTROLTECNICO.Visible = False
        BTN_CERRAR_CONTROLTECNICO.Visible = False
        P_LATERAL.Visible = True
        ACCION_AGENDA = "VER AGENDA"
        LBL_ACCIONAGENDA.Text = "VER AGENDA"
    End Sub
    Private Sub BTN_CERRAR_REASIGNARCAP_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_REASIGNARCAP.Click
        ACCION_AGENDA = "VER AGENDA"
        LBL_ACCIONAGENDA.Text = "VER AGENDA"
        P_REASIGNAR.Visible = False
        BTN_CERRAR_REASIGNARCAP.Visible = False
        P_LATERAL.Visible = True
    End Sub
    Private Sub CATEGORIAMET_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CATEGORIAMET.Text = "TOTAL" Then
            DESDEMET.Text = "8:00"
            HASTAMET.Text = "21:00"
        Else
            DESDEMET.Text = ""
            HASTAMET.Text = ""
        End If
    End Sub
    Private Sub CB_MOTIVO_AUSENCIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MOTIVO_AUSENCIA.SelectedIndexChanged
        AUSENCIASTableAdapter.FillByDESC(AnalisiS_AGDataSet2.AUSENCIAS, CB_MOTIVO_AUSENCIA.Text)
        Select Case AnalisiS_AGDataSet2.AUSENCIAS.Rows(0).Item("TOTAL")
            Case True
                CB_DESDE.Visible = False
                CB_HASTA.Visible = False
                DT_INI.Visible = True
                DT_FIN.Visible = True
            Case False
                CB_DESDE.Visible = True
                CB_HASTA.Visible = True
                DT_INI.Visible = False
                DT_FIN.Visible = False
        End Select
    End Sub
    Private Sub BTN_AGREGARAUSENCIA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGARAUSENCIA.Click
        ACCESO_AUSENCIA = "NUEVA"
        P_DISPONIBILIDAD.Visible = False
        P_DISTRIBUCIONTEC.Visible = False
        P_METEOROLOGIA.Visible = False
        LBL_ACCIONAGENDA.Text = "REGISTRO AUSENCIAS"
        If P_AUSENCIA.Visible Then
            P_AUSENCIA.BringToFront()
        Else
            P_AUSENCIA.Visible = True
            P_AUSENCIA.BringToFront()
        End If
    End Sub
    Private Sub BTN_CANCELARAUSENCIA_Click(sender As Object, e As EventArgs) Handles BTN_CANCELARAUSENCIA.Click
        P_AUSENCIA.Visible = False
    End Sub
    Private Sub BTN_METEOROLOGIA_Click(sender As Object, e As EventArgs) Handles BTN_METEOROLOGIA.Click
        P_DISPONIBILIDAD.Visible = False
        P_DISTRIBUCIONTEC.Visible = False
        P_AUSENCIA.Visible = False
        LBL_ACCIONAGENDA.Text = "CLIMA E IMPREVISTOS"
        If P_METEOROLOGIA.Visible Then
            P_METEOROLOGIA.BringToFront()
        Else
            P_METEOROLOGIA.Visible = True
            P_METEOROLOGIA.BringToFront()
        End If
    End Sub
    Private Sub BTN_CANCELAR_CONTINGENCIAS_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR_CONTINGENCIAS.Click
        P_METEOROLOGIA.Visible = False
    End Sub
    Private Sub REG_AUSENCIASDataGridView_Click(sender As Object, e As EventArgs) Handles REG_AUSENCIASDataGridView.Click
        BTN_BORRAR.Visible = True
        BTN_EDITAR.Visible = True
    End Sub
    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        ACCESO_AUSENCIA = "EDITAR"
        BTN_AUSENCIA_NORMAL.Visible = True
        CB_TECNICO.Text = REG_AUSENCIASDataGridView.CurrentRow.Cells.Item(1).Value
        AUSENCIA_TECNICO()
        If P_AUSENCIA.Visible Then
            P_AUSENCIA.BringToFront()
        Else
            P_AUSENCIA.Visible = True
            P_AUSENCIA.BringToFront()
        End If
    End Sub
    Private Sub BTN_EDITAR_AUSENCIA_ACTIVO_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR_AUSENCIA_ACTIVO.Click
        ACCESO_AUSENCIA = "EDITAR"
        BTN_AUSENCIA_NORMAL.Visible = True
        CB_TECNICO.Items.Clear()
        CB_TECNICO.Text = DGV_TEC_ACTIVOS.CurrentRow.Cells.Item(1).Value
        AUSENCIA_TECNICO()
        If P_AUSENCIA.Visible Then
            P_AUSENCIA.BringToFront()
        Else
            P_AUSENCIA.Visible = True
            P_AUSENCIA.BringToFront()
        End If
    End Sub
    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        Cursor = Cursors.WaitCursor
        If REG_AUSENCIASDataGridView.Rows.Count > 0 Then
            Dim REGISTRO As DataRow = AnalisiS_AGDataSet2.REG_AUSENCIAS.Rows(BindingSource1.Position)
            REGISTRO.Delete()
            REG_AUSENCIASTableAdapter.Update(REGISTRO)

            GENERAR_AGENDA(FECHAINI.ToShortDateString, FECHAINI.ToShortDateString)
            LOAD_P_CONTROLTECNICO()
        Else
            MsgBox("NO HAY REGISTRO PARA BORRAR")
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub BTN_VER_DISTRIBUCION_Click(sender As Object, e As EventArgs) Handles BTN_VER_DISTRIBUCION.Click
        P_AUSENCIA.Visible = False
        P_METEOROLOGIA.Visible = False
        LBL_ACCIONAGENDA.Text = "DISTRIBUCION AGENDA"
        If P_DISTRIBUCIONTEC.Visible Then
            P_DISTRIBUCIONTEC.BringToFront()
        Else
            P_DISTRIBUCIONTEC.Visible = True
            P_DISTRIBUCIONTEC.BringToFront()
        End If
    End Sub
    Private Sub BTN_VER_DISPONIBILIDAD_Click(sender As Object, e As EventArgs) Handles BTN_VER_DISPONIBILIDAD.Click
        P_AUSENCIA.Visible = False
        P_METEOROLOGIA.Visible = False
        If P_DISPONIBILIDAD.Visible Then
            P_DISPONIBILIDAD.BringToFront()
        Else
            P_DISPONIBILIDAD.Visible = True
            P_DISPONIBILIDAD.BringToFront()
        End If
    End Sub
    Private Sub BOT_REGMET_Click(sender As Object, e As EventArgs) Handles BOT_REGMET.Click
        If METEOROLOGIAMOT.Text = "" Then
            MsgBox("INGRESE MOTIVO")
            Exit Sub
        End If
        If CATEGORIAMET.Text = "" Then
            MsgBox("INGRESE CATEGORIA")
            Exit Sub
        End If
        Dim NewMeteorologiaRow As ANALISIS_AGDataSet.METEOROLOGIARow
        NewMeteorologiaRow = ANALISIS_AGDataSet.METEOROLOGIA.NewMETEOROLOGIARow
        NewMeteorologiaRow("FECHA") = FECHAINI.ToShortDateString
        NewMeteorologiaRow("MOTIVO") = METEOROLOGIAMOT.Text
        NewMeteorologiaRow("DESCRIPCION") = DESCRIPCIONMET.Text
        NewMeteorologiaRow("DESDE") = DESDEMET.Text
        NewMeteorologiaRow("HASTA") = HASTAMET.Text
        NewMeteorologiaRow("CATEGORIA") = CATEGORIAMET.Text

        ANALISIS_AGDataSet.METEOROLOGIA.Rows.Add(NewMeteorologiaRow)
        METEOROLOGIATableAdapter.Update(NewMeteorologiaRow)

        'MODIFICACION DE TECNICOS EN REG_AUSENCIAS SEGUN EVENTO ANTERIOR PARA EL DIA


        TECNICOSTableAdapter.FillByDACAPACIDAD(AnalisiS_AGDataSet1.TECNICOS)

        For X = 0 To AnalisiS_AGDataSet1.TECNICOS.Rows.Count - 1

            CALCULA_TECNICOS(FECHAINI.ToString("dddd").ToUpper, X)
            Dim fecha1 As DateTime = DateTime.Parse(DESDEMET.Text)
            Dim fecha2 As DateTime = DateTime.Parse(HASTAMET.Text)
            Dim hora As TimeSpan = fecha2.Subtract(fecha1)
            Dim HORAS As String = DIA_HORAS - CInt(String.Format("{0}", hora.Hours))

            REG_AUSENCIASTableAdapter.FillByFECHAYTEC(AnalisiS_AGDataSet1.REG_AUSENCIAS, FECHAINI.ToShortDateString, AnalisiS_AGDataSet1.TECNICOS.Rows(X).Item("NOMBRE"))
            If AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows.Count > 0 Then
                TECNICOSRow = AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows(0)
                If CATEGORIAMET.Text = "TOTAL" Then
                    TECNICOSRow("PRESENCIA") = "NO"
                    TECNICOSRow("INICIO") = DIA_ENTRA.ToShortTimeString
                    TECNICOSRow("FIN") = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                Else
                    TECNICOSRow("PRESENCIA") = "SI"
                    TECNICOSRow("HORAS") = HORAS
                    If DIA_ENTRA.ToString("HHmm") < fecha1.ToString("HHmm") Then
                        TECNICOSRow("INICIO") = DIA_ENTRA.ToShortTimeString
                    Else
                        TECNICOSRow("INICIO") = fecha2.ToShortTimeString
                    End If 'MARCA LA HORA DE INGRESO SEGUN HORARIOS A FALTAR
                    If DIA_ENTRA.AddHours(DIA_HORAS).ToString("HHmm") = fecha2.ToString("HHmm") Then
                        TECNICOSRow("FIN") = CB_DESDE.Text
                    Else
                        '   TECNICOSRow("FIN") = ES EL MISMO FIN
                    End If 'MARCA LA HORA DE SALIDA  SEGUN HORARIOS A FALTAR
                End If
                TECNICOSRow("MOTIVO") = METEOROLOGIAMOT.Text
                REG_AUSENCIASTableAdapter.Update(TECNICOSRow)
            Else
                If VIENE Then
                    AUSENCIANEWRow = ANALISIS_AGDataSet.REG_AUSENCIAS.NewREG_AUSENCIASRow
                    AUSENCIANEWRow.FECHA = DT_INI.Value.AddDays(X).ToShortDateString
                    AUSENCIANEWRow.DIASEMANA = DT_INI.Value.AddDays(X).ToString("dddd").ToUpper
                    AUSENCIANEWRow.NOMBRETEC = AnalisiS_AGDataSet1.TECNICOS.Rows(X).Item("NOMBRE")
                    AUSENCIANEWRow.SECTOR = AnalisiS_AGDataSet1.TECNICOS.Rows(X).Item("SECTOR")
                    AUSENCIANEWRow.TIPO = AnalisiS_AGDataSet1.TECNICOS.Rows(X).Item("TIPO")
                    AUSENCIANEWRow.HORAS = DIA_HORAS
                    AUSENCIANEWRow.MOTIVO = CB_MOTIVO_AUSENCIA.Text

                    AUSENCIANEWRow.SUMACAP = AnalisiS_AGDataSet1.TECNICOS.Rows(X).Item("DA_CAPACIDAD")
                    AUSENCIANEWRow.RECURSO = RECURSO_TEC
                    AUSENCIANEWRow.PRIORIDAD = PRIORIDAD_TEC
                    If CATEGORIAMET.Text = "TOTAL" Then
                        AUSENCIANEWRow.PRESENCIA = "NO"
                        AUSENCIANEWRow.INICIO = DIA_ENTRA.ToShortTimeString
                        AUSENCIANEWRow.FIN = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                    Else
                        AUSENCIANEWRow.PRESENCIA = "SI"
                        If DIA_ENTRA.ToString("HHmm") < fecha1.ToString("HHmm") Then
                            AUSENCIANEWRow.INICIO = DIA_ENTRA.ToShortTimeString
                        Else
                            AUSENCIANEWRow.INICIO = fecha2.ToShortTimeString
                        End If 'MARCA LA HORA DE INGRESO SEGUN HORARIOS A FALTAR
                        If DIA_ENTRA.AddHours(DIA_HORAS).ToString("HHmm") = fecha2.ToString("HHmm") Then
                            AUSENCIANEWRow.FIN = CB_DESDE.Text
                        Else
                            AUSENCIANEWRow.FIN = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                        End If 'MARCA LA HORA DE SALIDA  SEGUN HORARIOS A FALTAR
                    End If
                    ANALISIS_AGDataSet.REG_AUSENCIAS.AddREG_AUSENCIASRow(AUSENCIANEWRow)
                    REG_AUSENCIASTableAdapter.Update(AUSENCIANEWRow)
                End If
            End If

        Next
        GENERAR_AGENDA(FECHAINI.ToShortDateString, FECHAINI.ToShortDateString)
    End Sub
    Private Sub CATEGORIAMET_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CATEGORIAMET.SelectedIndexChanged
        If CATEGORIAMET.Text = "TOTAL" Then
            DESDEMET.Text = "8:00"
            HASTAMET.Text = "21:00"
        Else
            DESDEMET.Text = "0"
            HASTAMET.Text = "0"
        End If
    End Sub
    Private Sub CB_TECNICO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TECNICO.SelectedIndexChanged
        AUSENCIA_TECNICO()
    End Sub
    Private Sub AUSENCIA_TECNICO()
        TECNICOSTableAdapter.FillByNOMBRE(AnalisiS_AGDataSet1.TECNICOS, CB_TECNICO.Text)
        RECURSO_TEC = ""
        PRIORIDAD_TEC = ""
        LBL_DATOSTECNICO.Text = ""
        BOT_AUSENCIA.Enabled = True
        If IsDBNull(AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_RECURSO")) Then
            MsgBox("TECNICO " & CB_TECNICO.Text & " NO TIENE RECURSO ASIGNADO Y NO SE LE PUEDE MARCAR AUSENCIA")
            BOT_AUSENCIA.Enabled = False
            Exit Sub
        End If

        Select Case (FECHAINI.ToString("dddd").ToUpper)
            Case "DOMINGO"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DOM_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
            Case "LUNES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("LUN_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("LUN_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("LUN_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("LUN_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("LUN_PRIO")
                End If
            Case "MARTES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MAR_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MAR_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MAR_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MAR_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MAR_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
            Case "MIÉRCOLES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MIE_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MIE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MIE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MIER_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("MIER_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
            Case "JUEVES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("JUE_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("JUE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("JUE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("JUEV_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("JUEV_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
            Case "VIERNES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("VIE_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("VIE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("VIE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("VIER_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("VIER_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
            Case "SÁBADO"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SAB_ENT") <> "--" Then
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SAB_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SAB_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SAB_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SAB_PRIO")
                Else
                    MsgBox("TECNICO NO VIENE ESTE DIA")
                    Exit Sub
                End If
        End Select
        LBL_DATOSTECNICO.Text = FECHAINI.ToString("dddd").ToUpper & ": ENTRA A LAS " & DIA_ENTRA.ToShortTimeString & " Y SALE A LAS " & DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString & ", TOTAL: " & DIA_HORAS & " HORAS"
        LBL_RECURSO.Text = RECURSO_TEC
    End Sub
    Private Sub BOT_AUSENCIA_Click(sender As Object, e As EventArgs) Handles BOT_AUSENCIA.Click
        If CB_TECNICO.Text = "" Then
            MsgBox("INGRESE UN TECNICO", MsgBoxStyle.Critical)
            CB_TECNICO.Focus()
            Exit Sub
        End If
        If CB_MOTIVO_AUSENCIA.Text = "" Then
            MsgBox("INGRESE UN MOTIVO DE AUSENCIA", MsgBoxStyle.Critical)
            CB_MOTIVO_AUSENCIA.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        If ACCESO_AUSENCIA = "NUEVA" Then
            If DT_INI.Visible = False Then 'PARA FALTAS PARCIALES EN EL DIA.
                REG_AUSENCIASTableAdapter.FillByFECHAYTEC(AnalisiS_AGDataSet1.REG_AUSENCIAS, FECHAINI, CB_TECNICO.Text)
                TECNICOSTableAdapter.FillByNOMBRE(AnalisiS_AGDataSet1.TECNICOS, CB_TECNICO.Text)
                TECNICOSRow = AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows(0)
                CALCULA_TECNICOS(FECHAINI.ToString("dddd").ToUpper, 0)
                Dim fecha1 As DateTime = DateTime.Parse(CB_DESDE.Text)
                Dim fecha2 As DateTime = DateTime.Parse(CB_HASTA.Text)
                Dim hora As TimeSpan = fecha2.Subtract(fecha1)
                Dim HORAS As String = DIA_HORAS - CInt(String.Format("{0}", hora.Hours))
                If AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows.Count > 0 Then
                    TECNICOSRow("PRESENCIA") = "SI"
                    TECNICOSRow("MOTIVO") = CB_MOTIVO_AUSENCIA.Text
                    TECNICOSRow("HORAS") = HORAS
                    If DIA_ENTRA.ToString("HHmm") < fecha1.ToString("HHmm") Then
                        TECNICOSRow("INICIO") = DIA_ENTRA
                    Else
                        TECNICOSRow("INICIO") = fecha2.ToShortTimeString
                    End If 'MARCA LA HORA DE INGRESO SEGUN HORARIOS A FALTAR
                    If DIA_ENTRA.AddHours(DIA_HORAS).ToString("HHmm") = fecha2.ToString("HHmm") Then
                        TECNICOSRow("FIN") = CB_DESDE.Text
                    Else
                        '   TECNICOSRow("FIN") = ES EL MISMO FIN
                    End If 'MARCA LA HORA DE SALIDA  SEGUN HORARIOS A FALTAR
                    REG_AUSENCIASTableAdapter.Update(TECNICOSRow)
                Else
                    AUSENCIANEWRow = ANALISIS_AGDataSet.REG_AUSENCIAS.NewREG_AUSENCIASRow
                    AUSENCIANEWRow.FECHA = FECHAINI
                    AUSENCIANEWRow.DIASEMANA = FECHAINI.ToString("dddd").ToUpper
                    AUSENCIANEWRow.NOMBRETEC = CB_TECNICO.Text
                    AUSENCIANEWRow.SECTOR = TECNICOSRow("SECTOR")
                    AUSENCIANEWRow.TIPO = TECNICOSRow("TIPO")
                    AUSENCIANEWRow.HORAS = HORAS
                    AUSENCIANEWRow.PRESENCIA = "SI"
                    AUSENCIANEWRow.MOTIVO = CB_MOTIVO_AUSENCIA.Text
                    If DIA_ENTRA.ToString("HHmm") < fecha1.ToString("HHmm") Then
                        AUSENCIANEWRow.INICIO = DIA_ENTRA
                    Else
                        AUSENCIANEWRow.INICIO = fecha2.ToShortTimeString
                    End If 'MARCA LA HORA DE INGRESO SEGUN HORARIOS A FALTAR
                    If DIA_ENTRA.AddHours(DIA_HORAS).ToString("HHmm") = fecha2.ToString("HHmm") Then
                        AUSENCIANEWRow.FIN = CB_DESDE.Text
                    Else
                        AUSENCIANEWRow.FIN = fecha2.AddHours(HORAS).ToShortTimeString
                    End If 'MARCA LA HORA DE SALIDA  SEGUN HORARIOS A FALTAR
                    AUSENCIANEWRow.SUMACAP = TECNICOSRow("DA_CAPACIDAD")
                    AUSENCIANEWRow.RECURSO = TECNICOSRow("RECURSO")
                    AUSENCIANEWRow.PRIORIDAD = TECNICOSRow("PRIORIDAD")
                    ANALISIS_AGDataSet.REG_AUSENCIAS.AddREG_AUSENCIASRow(AUSENCIANEWRow)
                    REG_AUSENCIASTableAdapter.Update(AUSENCIANEWRow)
                End If

                GENERAR_AGENDA(FECHAINI.ToShortDateString, FECHAINI.ToShortDateString)

            Else 'PARA EL CASO DE DIAS ENTEROS O PERIODOS
                FECHAINI = DT_INI.Value.ToShortDateString
                For X = 0 To DateDiff(DateInterval.Day, DT_INI.Value, DT_FIN.Value)
                    REG_AUSENCIASTableAdapter.FillByFECHAYTEC(AnalisiS_AGDataSet1.REG_AUSENCIAS, DT_INI.Value.AddDays(X).ToShortDateString, CB_TECNICO.Text)
                    TECNICOSTableAdapter.FillByNOMBRE(AnalisiS_AGDataSet1.TECNICOS, CB_TECNICO.Text)
                    CALCULA_TECNICOS(DT_INI.Value.AddDays(X).ToString("dddd").ToUpper, 0)

                    If AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows.Count > 0 Then
                        TECNICOSRow = AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows(0)
                        TECNICOSRow("PRESENCIA") = "NO"
                        TECNICOSRow("MOTIVO") = CB_MOTIVO_AUSENCIA.Text
                        TECNICOSRow("HORAS") = DIA_HORAS
                        TECNICOSRow("INICIO") = DIA_ENTRA.ToShortTimeString
                        TECNICOSRow("FIN") = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                        REG_AUSENCIASTableAdapter.Update(AnalisiS_AGDataSet1.REG_AUSENCIAS.Rows(0))
                    Else
                        If VIENE Then
                            AUSENCIANEWRow = ANALISIS_AGDataSet.REG_AUSENCIAS.NewREG_AUSENCIASRow
                            AUSENCIANEWRow.FECHA = DT_INI.Value.AddDays(X).ToShortDateString
                            AUSENCIANEWRow.DIASEMANA = DT_INI.Value.AddDays(X).ToString("dddd").ToUpper
                            AUSENCIANEWRow.NOMBRETEC = CB_TECNICO.Text
                            AUSENCIANEWRow.SECTOR = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("SECTOR")
                            AUSENCIANEWRow.TIPO = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("TIPO")
                            AUSENCIANEWRow.HORAS = DIA_HORAS
                            AUSENCIANEWRow.PRESENCIA = "NO"
                            AUSENCIANEWRow.MOTIVO = CB_MOTIVO_AUSENCIA.Text
                            AUSENCIANEWRow.INICIO = DIA_ENTRA.ToShortTimeString
                            AUSENCIANEWRow.FIN = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                            AUSENCIANEWRow.SUMACAP = AnalisiS_AGDataSet1.TECNICOS.Rows(0).Item("DA_CAPACIDAD")
                            AUSENCIANEWRow.RECURSO = RECURSO_TEC
                            AUSENCIANEWRow.PRIORIDAD = PRIORIDAD_TEC
                            ANALISIS_AGDataSet.REG_AUSENCIAS.AddREG_AUSENCIASRow(AUSENCIANEWRow)
                            REG_AUSENCIASTableAdapter.Update(AUSENCIANEWRow)
                        End If
                    End If

                    GENERAR_AGENDA(DT_INI.Value.AddDays(X).ToShortDateString, DT_INI.Value.AddDays(X).ToShortDateString)
                Next
            End If

        Else

        End If
        Cursor = Cursors.Default
        NOTIFICACION("SYS", "AUSENCIA CREADA")
        REG_AUSENCIASTableAdapter.FillByFECHAyPRESENCIA(AnalisiS_AGDataSet1.REG_AUSENCIAS, FECHAINI)
        REG_AUSENCIASTableAdapter.FillByAUSENCIADIA(AnalisiS_AGDataSet2.REG_AUSENCIAS, FECHAINI, "NO")
    End Sub
    Public Sub CALCULA_TECNICOS(ByVal X As String, ByVal T As Integer)
        Select Case X
            Case "DOMINGO"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DOM_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DOM_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DOM_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DOM_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DOM_PRIO")
                End If
            Case "LUNES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("LUN_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("LUN_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("LUN_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("LUN_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("LUN_PRIO")
                End If
            Case "MARTES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MAR_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MAR_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MAR_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MAR_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MAR_PRIO")
                End If
            Case "MIÉRCOLES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MIE_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MIE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MIE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MIER_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("MIER_PRIO")
                End If
            Case "JUEVES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("JUE_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("JUE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("JUE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("JUEV_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("JUEV_PRIO")
                End If
            Case "VIERNES"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("VIE_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("VIE_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("VIE_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("VIER_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("VIER_PRIO")
                End If
            Case "SÁBADO"
                If AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SAB_ENT") = "--" Then
                    VIENE = False
                Else
                    VIENE = True
                    DIA_ENTRA = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SAB_ENT")
                    DIA_HORAS = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SAB_HS")
                    RECURSO_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SAB_RECURSO")
                    PRIORIDAD_TEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SAB_PRIO")
                End If
        End Select
    End Sub
    Private Sub BTN_CREAR_CAP_Click(sender As Object, e As EventArgs) Handles BTN_CREAR_CAP.Click
        GENERAR_AGENDA(DT_INI_CAP.Value.ToShortDateString, DT_FIN_CAP.Value.ToShortDateString)
    End Sub
    Private Sub GENERAR_AGENDA(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date)
        'NO REALIZA CALCULO DE CUADRILLA RETEN
        Cursor = Cursors.WaitCursor

        'CARGA_DISTRIBUCIONAGENDA()
        FECHAINI = FECHAINICIO
        FECHAFIN = FECHAFINAL
        If Format(FECHAFIN, "yyyyMMdd") < Format(FECHAINI, "yyyyMMdd") Then
            MsgBox("LA FECHA FIN NO PUEDE SER MAYOR QUE LA DE INICIO")
            Cursor = Cursors.Default
            Exit Sub
        End If
        TECNICOSTableAdapter.FillByDACAPACIDAD(AnalisiS_AGDataSet1.TECNICOS)
        For X = 0 To DateDiff(DateInterval.Day, FECHAINI, FECHAFIN) 'RECORRE LOS DIAS MARCADOS
            HS_TECTEOR_ALT_PT = 0
            HS_TECTEOR_MED_PT = 0
            HS_TECTEOR_BAJ_PT = 0
            HS_TECTEOR_ALT_SU = 0
            HS_TECTEOR_MED_SU = 0
            HS_TECTEOR_BAJ_SU = 0
            HS_TECTEOR_CO = 0
            HS_TECTEOR = 0

            HS_CUATEOR_ALT_PT = 0
            HS_CUATEOR_MED_PT = 0
            HS_CUATEOR_BAJ_PT = 0
            HS_CUATEOR_ALT_SU = 0
            HS_CUATEOR_MED_SU = 0
            HS_CUATEOR_BAJ_SU = 0
            HS_CUATEOR_CO = 0
            HS_CUATEOR = 0

            HS_AUSTEC_ALT_PT = 0
            HS_AUSTEC_MED_PT = 0
            HS_AUSTEC_BAJ_PT = 0
            HS_AUSTEC_ALT_SU = 0
            HS_AUSTEC_MED_SU = 0
            HS_AUSTEC_BAJ_SU = 0
            HS_AUSTEC_CO = 0
            HS_AUSTEC = 0

            HS_AUSCUA_ALT_PT = 0
            HS_AUSCUA_MED_PT = 0
            HS_AUSCUA_BAJ_PT = 0
            HS_AUSCUA_ALT_SU = 0
            HS_AUSCUA_MED_SU = 0
            HS_AUSCUA_BAJ_SU = 0
            HS_AUSCUA_CO = 0
            HS_AUSCUA = 0

            HS_CLITEC_ALT_PT = 0
            HS_CLITEC_MED_PT = 0
            HS_CLITEC_BAJ_PT = 0
            HS_CLITEC_ALT_SU = 0
            HS_CLITEC_MED_SU = 0
            HS_CLITEC_BAJ_SU = 0
            HS_CLITEC_CO = 0
            '    HS_CLITEC = 0

            HS_CLICUA_ALT_PT = 0
            HS_CLICUA_MED_PT = 0
            HS_CLICUA_BAJ_PT = 0
            HS_CLICUA_ALT_SU = 0
            HS_CLICUA_MED_SU = 0
            HS_CLICUA_BAJ_SU = 0
            HS_CLICUA_CO = 0
            '  HS_CLICUA = 0

            HS_REALTEC_ALT_PT = 0
            HS_REALTEC_MED_PT = 0
            HS_REALTEC_BAJ_PT = 0
            HS_REALTEC_ALT_SU = 0
            HS_REALTEC_MED_SU = 0
            HS_REALTEC_BAJ_SU = 0
            HS_REALTEC_CO = 0
            HS_REALTEC = 0

            HS_REALCUA_ALT_PT = 0
            HS_REALCUA_MED_PT = 0
            HS_REALCUA_BAJ_PT = 0
            HS_REALCUA_ALT_SU = 0
            HS_REALCUA_MED_SU = 0
            HS_REALCUA_BAJ_SU = 0
            HS_REALCUA_CO = 0
            HS_REALCUA = 0

            CANT_TEC_ALT_TEOR_PT = 0
            CANT_TEC_MED_TEOR_PT = 0
            CANT_TEC_BAJ_TEOR_PT = 0
            CANT_TEC_ALT_TEOR_SU = 0
            CANT_TEC_MED_TEOR_SU = 0
            CANT_TEC_BAJ_TEOR_SU = 0
            CANT_TEC_TEOR_CO = 0

            CANT_TEC_PRES_ALT_PT = 0
            CANT_TEC_PRES_MED_PT = 0
            CANT_TEC_PRES_BAJ_PT = 0
            CANT_TEC_PRES_ALT_SU = 0
            CANT_TEC_PRES_MED_SU = 0
            CANT_TEC_PRES_BAJ_SU = 0
            CANT_TEC_PRES_CO = 0

            CANT_TEC_ALT_FALT_PT = 0
            CANT_TEC_MED_FALT_PT = 0
            CANT_TEC_BAJ_FALT_PT = 0
            CANT_TEC_ALT_FALT_SU = 0
            CANT_TEC_MED_FALT_SU = 0
            CANT_TEC_BAJ_FALT_SU = 0
            CANT_TEC_FALT_CO = 0

            CANT_CUAD_ALT_FALT_PT = 0
            CANT_CUAD_MED_FALT_PT = 0
            CANT_CUAD_BAJ_FALT_PT = 0
            CANT_CUAD_ALT_FALT_SU = 0
            CANT_CUAD_MED_FALT_SU = 0
            CANT_CUAD_BAJ_FALT_SU = 0
            CANT_CUAD_FALT_CO = 0

            CANT_CUAD_PRES_ALT_PT = 0
            CANT_CUAD_PRES_MED_PT = 0
            CANT_CUAD_PRES_BAJ_PT = 0
            CANT_CUAD_PRES_ALT_SU = 0
            CANT_CUAD_PRES_MED_SU = 0
            CANT_CUAD_PRES_BAJ_SU = 0
            CANT_CUAD_PRES_CO = 0

            CANT_CUAD_ALT_TEOR_PT = 0
            CANT_CUAD_MED_TEOR_PT = 0
            CANT_CUAD_BAJ_TEOR_PT = 0
            CANT_CUAD_ALT_TEOR_SU = 0
            CANT_CUAD_MED_TEOR_SU = 0
            CANT_CUAD_BAJ_TEOR_SU = 0
            CANT_CUAD_TEOR_CO = 0

            CANT_MINUTOS_TEC = 0
            CANT_MINUTOS_CUA = 0
            CANTIDAD_TEC = 0
            CANTIDAD_CUA = 0

            LBL_DIA.Text = "ANALIZANDO TÉCNICOS PARA EL DIA: " & FECHAINI.AddDays(X)
            LBL_DIA.Refresh()
            'CREA EL (REG_AUSENCIAS) REGISTRO DE AUSENCIAS - MENOS LOS AUSENTES QUE YA FUERON CREADO.
            For T = 0 To AnalisiS_AGDataSet1.TECNICOS.Rows.Count - 1
                CALCULA_TECNICOS(FECHAINI.AddDays(X).ToString("dddd").ToUpper, T)
                REG_AUSENCIASTableAdapter.FillByFECHAYTEC(ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI.AddDays(X), AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("NOMBRE"))
                If VIENE Then
                    If ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count = 0 Then
                        Dim AUSENCIANEWRow As ANALISIS_AGDataSet.REG_AUSENCIASRow
                        AUSENCIANEWRow = ANALISIS_AGDataSet.REG_AUSENCIAS.NewREG_AUSENCIASRow
                        AUSENCIANEWRow.FECHA = FECHAINI.AddDays(X)
                        AUSENCIANEWRow.DIASEMANA = FECHAINI.AddDays(X).ToString("dddd").ToUpper
                        AUSENCIANEWRow.NOMBRETEC = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("NOMBRE")
                        AUSENCIANEWRow.SECTOR = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("SECTOR")
                        AUSENCIANEWRow.TIPO = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("TIPO")
                        AUSENCIANEWRow.HORAS = DIA_HORAS
                        AUSENCIANEWRow.PRESENCIA = "SI"
                        AUSENCIANEWRow.MOTIVO = ""
                        AUSENCIANEWRow.INICIO = DIA_ENTRA.ToShortTimeString
                        AUSENCIANEWRow.FIN = DIA_ENTRA.AddHours(DIA_HORAS).ToShortTimeString
                        AUSENCIANEWRow.SUMACAP = AnalisiS_AGDataSet1.TECNICOS.Rows(T).Item("DA_CAPACIDAD")
                        AUSENCIANEWRow.RECURSO = RECURSO_TEC
                        AUSENCIANEWRow.PRIORIDAD = PRIORIDAD_TEC
                        ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Add(AUSENCIANEWRow)
                        REG_AUSENCIASTableAdapter.Update(ANALISIS_AGDataSet.REG_AUSENCIAS)
                    End If
                End If
            Next

            'CREA LA CAPACIDAD X DIA SEGUN TECNICOS DISPONIBLES, CREADOS O MODIFICADOS ANTERIORMENTE
            REG_DIARIOTableAdapter.FillByFECHA(ANALISIS_AGDataSet.REG_DIARIO, FECHAINI.AddDays(X))
            REG_AUSENCIASTableAdapter.FillByFECHA(ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI.AddDays(X))
            CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, FECHAINI.AddDays(X))

            If ANALISIS_AGDataSet.CAPACIDAXDIA.Rows.Count > 0 Then
                LBL_DIA.Text = "RECALCULANDO AGENDA PARA EL DIA: " & FECHAINI.AddDays(X)
            Else
                LBL_DIA.Text = "GENERANDO AGENDA PARA EL DIA: " & FECHAINI.AddDays(X)
            End If
            LBL_DIA.Refresh()
            '5675767
            For I = 0 To ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count - 1
                REGAUSENCIASRow = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(I)
                If REGAUSENCIASRow("SUMACAP") = "SI" Then   'SI SUMA CAPACIDAD PARA LA AGENDA
                    'CALCULA LA CAPACIDA TEORICA DE TECNICOS DE RED/MDU
                    Select Case REGAUSENCIASRow.SECTOR
                        Case "RED/MDU"
                            Select Case REGAUSENCIASRow.RECURSO
                                Case "PLANIFICACION TECNICA", "PT"
                                    Select Case REGAUSENCIASRow.PRIORIDAD
                                        Case "ALTA"
                                            HS_TECTEOR_ALT_PT += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_ALT_TEOR_PT += 1
                                        Case "MEDIA"
                                            HS_TECTEOR_MED_PT += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_MED_TEOR_PT += 1
                                        Case "BAJA"
                                            HS_TECTEOR_BAJ_PT += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_BAJ_TEOR_PT += 1
                                    End Select
                                Case "SUPERVISION", "SU"
                                    Select Case REGAUSENCIASRow("PRIORIDAD")
                                        Case "ALTA"
                                            HS_TECTEOR_ALT_SU += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_ALT_TEOR_SU += 1
                                        Case "MEDIA"
                                            HS_TECTEOR_MED_SU += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_MED_TEOR_SU += 1
                                        Case "BAJA"
                                            HS_TECTEOR_BAJ_SU += REGAUSENCIASRow("HORAS")
                                            CANT_TEC_BAJ_TEOR_SU += 1
                                    End Select
                                Case "CORRECTIVO", "CO"
                                    HS_TECTEOR_CO += REGAUSENCIASRow("HORAS")
                                    CANT_TEC_TEOR_CO += 1
                            End Select
                        Case "CUAD RED", "CUAD MDU" 'CALCULA LA CAPACIDA TEORICA DE TECNICOS DE CUADRILLA DE CABLEADO
                            Select Case REGAUSENCIASRow("RECURSO")
                                Case "PLANIFICACION TECNICA", "PT"
                                    Select Case REGAUSENCIASRow("PRIORIDAD")
                                        Case "ALTA"
                                            HS_CUATEOR_ALT_PT += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_ALT_TEOR_PT += 1
                                        Case "MEDIA"
                                            HS_CUATEOR_MED_PT += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_MED_TEOR_PT += 1
                                        Case "BAJA"
                                            HS_CUATEOR_BAJ_PT += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_BAJ_TEOR_PT += 1
                                    End Select
                                Case "SUPERVISION", "SU"
                                    Select Case REGAUSENCIASRow("PRIORIDAD")
                                        Case "ALTA"
                                            HS_CUATEOR_ALT_SU += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_ALT_TEOR_SU += 1
                                        Case "MEDIA"
                                            HS_CUATEOR_MED_SU += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_MED_TEOR_SU += 1
                                        Case "BAJA"
                                            HS_CUATEOR_BAJ_SU += REGAUSENCIASRow("HORAS")
                                            CANT_CUAD_BAJ_TEOR_SU += 1
                                    End Select
                                Case "CORRECTIVO", "CO"
                                    HS_CUATEOR_CO += REGAUSENCIASRow("HORAS")
                                    CANT_CUAD_TEOR_CO += 1
                            End Select
                    End Select
                    'CALCULA LA CANTIDAD DE TECNICOS CON FIGURA "RETEN" QUE EXISTEN ESE DIA
                    'If ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(I).Item("TIPO") = "RET" Then
                    '    HS_TECRET += ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(I).Item("HORAS")
                    'End If

                    'CALCULA LA CANTIDAD DE AUSENCIAS DEL DIA
                    If REGAUSENCIASRow("PRESENCIA") = "NO" Then
                        'TECNICOS DE RED AUSENTES
                        Select Case REGAUSENCIASRow("SECTOR")
                            Case "RED/MDU"  'TECNICOS  AUSENTES
                                Select Case REGAUSENCIASRow("RECURSO")
                                    Case "PLANIFICACION TECNICA", "PT"
                                        Select Case REGAUSENCIASRow("PRIORIDAD")
                                            Case "ALTA"

                                                HS_AUSTEC_ALT_PT += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_ALT_FALT_PT += 1
                                            Case "MEDIA"
                                                HS_AUSTEC_MED_PT += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_MED_FALT_PT += 1
                                            Case "BAJA"
                                                HS_AUSTEC_BAJ_PT += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_BAJ_FALT_PT += 1
                                        End Select
                                    Case "SUPERVISION", "SU"
                                        Select Case REGAUSENCIASRow("PRIORIDAD")
                                            Case "ALTA"
                                                HS_AUSTEC_ALT_SU += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_ALT_FALT_SU += 1
                                            Case "MEDIA"
                                                HS_AUSTEC_MED_SU += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_MED_FALT_SU += 1
                                            Case "BAJA"
                                                HS_AUSTEC_BAJ_SU += REGAUSENCIASRow("HORAS")
                                                CANT_TEC_BAJ_FALT_SU += 1
                                        End Select
                                    Case "CORRECTIVO", "CO"
                                        HS_AUSTEC_CO += REGAUSENCIASRow("HORAS")
                                        CANT_TEC_FALT_CO += 1
                                End Select
                            Case "CUAD RED", "CUAD MDU"  'TECNICOS DE CUADRILLA AUSENTES
                                Select Case REGAUSENCIASRow("RECURSO")
                                    Case "PLANIFICACION TECNICA", "PT"
                                        Select Case REGAUSENCIASRow("PRIORIDAD")
                                            Case "ALTA"
                                                HS_AUSCUA_ALT_PT += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_ALT_FALT_PT += 1
                                            Case "MEDIA"
                                                HS_AUSCUA_MED_PT += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_MED_FALT_PT += 1
                                            Case "BAJA"
                                                HS_AUSCUA_BAJ_PT += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_BAJ_FALT_PT += 1
                                        End Select
                                    Case "SUPERVISION", "SU"
                                        Select Case REGAUSENCIASRow("PRIORIDAD")
                                            Case "ALTA"
                                                HS_AUSCUA_ALT_SU += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_ALT_FALT_SU += 1
                                            Case "MEDIA"
                                                HS_AUSCUA_MED_SU += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_MED_FALT_SU += 1
                                            Case "BAJA"
                                                HS_AUSCUA_BAJ_SU += REGAUSENCIASRow("HORAS")
                                                CANT_CUAD_BAJ_FALT_SU += 1
                                        End Select
                                    Case "CORRECTIVO", "CO"
                                        HS_AUSTEC_CO += REGAUSENCIASRow("HORAS")
                                        CANT_CUAD_FALT_CO += 1
                                End Select
                        End Select
                    End If
                End If
            Next
            'EL CLIMA YA ESTA CALCULADO AL MOMENTO DE INGRESARLO
            '            CALCULACLIMA_FILL(FECHAINI.AddDays(X))
            'CARGA LAS VARIABLES CALCULADAS
            CANT_TEC_PRES_ALT_PT = CANT_TEC_ALT_TEOR_PT - CANT_TEC_ALT_FALT_PT
            CANT_TEC_PRES_MED_PT = CANT_TEC_MED_TEOR_PT - CANT_TEC_MED_FALT_PT
            CANT_TEC_PRES_BAJ_PT = CANT_TEC_BAJ_TEOR_PT - CANT_TEC_BAJ_FALT_PT
            CANT_TEC_PRES_ALT_SU = CANT_TEC_ALT_TEOR_SU - CANT_TEC_ALT_FALT_SU
            CANT_TEC_PRES_MED_SU = CANT_TEC_MED_TEOR_SU - CANT_TEC_MED_FALT_SU
            CANT_TEC_PRES_BAJ_SU = CANT_TEC_BAJ_TEOR_SU - CANT_TEC_BAJ_FALT_SU
            CANT_TEC_PRES_CO = CANT_TEC_TEOR_CO - CANT_TEC_FALT_CO

            CANT_CUAD_PRES_ALT_PT = CANT_CUAD_ALT_TEOR_PT - CANT_CUAD_ALT_FALT_PT
            CANT_CUAD_PRES_MED_PT = CANT_CUAD_MED_TEOR_PT - CANT_CUAD_MED_FALT_PT
            CANT_CUAD_PRES_BAJ_PT = CANT_CUAD_BAJ_TEOR_PT - CANT_CUAD_BAJ_FALT_PT
            CANT_CUAD_PRES_ALT_SU = CANT_CUAD_ALT_TEOR_SU - CANT_CUAD_ALT_FALT_SU
            CANT_CUAD_PRES_MED_SU = CANT_CUAD_MED_TEOR_SU - CANT_CUAD_MED_FALT_SU
            CANT_CUAD_PRES_BAJ_SU = CANT_CUAD_BAJ_TEOR_SU - CANT_CUAD_BAJ_FALT_SU
            CANT_CUAD_PRES_CO = CANT_CUAD_TEOR_CO - CANT_CUAD_FALT_CO

            HS_REALTEC_ALT_PT = HS_TECTEOR_ALT_PT - HS_AUSTEC_ALT_PT - HS_CLITEC_ALT_PT - (CANT_TEC_PRES_ALT_PT * 1.5)
            HS_REALTEC_MED_PT = HS_TECTEOR_MED_PT - HS_AUSTEC_MED_PT - HS_CLITEC_MED_PT - (CANT_TEC_PRES_MED_PT * 1.5)
            HS_REALTEC_BAJ_PT = HS_TECTEOR_BAJ_PT - HS_AUSTEC_BAJ_PT - HS_CLITEC_BAJ_PT - (CANT_TEC_PRES_BAJ_PT * 1.5)
            HS_REALTEC_ALT_SU = HS_TECTEOR_ALT_SU - HS_AUSTEC_ALT_SU - HS_CLITEC_ALT_SU - (CANT_TEC_PRES_ALT_SU * 1.5)
            HS_REALTEC_MED_SU = HS_TECTEOR_MED_SU - HS_AUSTEC_MED_SU - HS_CLITEC_MED_SU - (CANT_TEC_PRES_MED_SU * 1.5)
            HS_REALTEC_BAJ_SU = HS_TECTEOR_BAJ_SU - HS_AUSTEC_BAJ_SU - HS_CLITEC_BAJ_SU - (CANT_TEC_PRES_BAJ_SU * 1.5)
            HS_REALTEC_CO = HS_TECTEOR_CO - HS_AUSTEC_CO - HS_CLITEC_CO - (CANT_TEC_PRES_CO * 1.5)

            HS_TECTEOR = HS_TECTEOR_ALT_PT + HS_TECTEOR_MED_PT + HS_TECTEOR_BAJ_PT + HS_TECTEOR_ALT_SU + HS_TECTEOR_MED_SU + HS_TECTEOR_BAJ_SU + HS_TECTEOR_CO
            HS_AUSTEC = HS_AUSTEC_ALT_PT + HS_AUSTEC_MED_PT + HS_AUSTEC_BAJ_PT + HS_AUSTEC_ALT_SU + HS_AUSTEC_MED_SU + HS_AUSTEC_BAJ_SU + HS_AUSTEC_CO
            HS_CLITEC = HS_CLITEC_ALT_PT + HS_CLITEC_MED_PT + HS_CLITEC_BAJ_PT + HS_CLITEC_ALT_SU + HS_CLITEC_MED_SU + HS_CLITEC_BAJ_SU + HS_CLITEC_CO
            'HS_REALTEC = HS_REALTEC_ALT_PT + HS_REALTEC_MED_PT + HS_REALTEC_BAJ_PT + HS_REALTEC_ALT_SU + HS_REALTEC_ALT_SU + HS_REALTEC_MED_SU + HS_REALTEC_BAJ_SU + HS_REALTEC_CO

            HS_REALCUA_ALT_PT = HS_CUATEOR_ALT_PT - HS_AUSCUA_ALT_PT - HS_CLICUA_ALT_PT - (CANT_CUAD_PRES_ALT_PT * 1.5)
            HS_REALCUA_MED_PT = HS_CUATEOR_MED_PT - HS_AUSCUA_MED_PT - HS_CLICUA_MED_PT - (CANT_CUAD_PRES_MED_PT * 1.5)
            HS_REALCUA_BAJ_PT = HS_CUATEOR_BAJ_PT - HS_AUSCUA_BAJ_PT - HS_CLICUA_BAJ_PT - (CANT_CUAD_PRES_BAJ_PT * 1.5)
            HS_REALCUA_ALT_SU = HS_CUATEOR_ALT_SU - HS_AUSCUA_ALT_SU - HS_CLICUA_ALT_SU - (CANT_CUAD_PRES_ALT_SU * 1.5)
            HS_REALCUA_MED_SU = HS_CUATEOR_MED_SU - HS_AUSCUA_MED_SU - HS_CLICUA_MED_SU - (CANT_CUAD_PRES_MED_SU * 1.5)
            HS_REALCUA_BAJ_SU = HS_CUATEOR_BAJ_SU - HS_AUSCUA_BAJ_SU - HS_CLICUA_BAJ_SU - (CANT_CUAD_PRES_BAJ_SU * 1.5)
            HS_REALCUA_CO = HS_CUATEOR_CO - HS_AUSCUA_CO - HS_CLICUA_CO - (CANT_CUAD_PRES_CO * 1.5)

            HS_CUATEOR = HS_CUATEOR_ALT_PT + HS_CUATEOR_MED_PT + HS_CUATEOR_BAJ_PT + HS_CUATEOR_ALT_SU + HS_CUATEOR_MED_SU + HS_CUATEOR_BAJ_SU + HS_CUATEOR_CO
            HS_AUSCUA = HS_AUSCUA_ALT_PT + HS_AUSCUA_MED_PT + HS_AUSCUA_BAJ_PT + HS_AUSCUA_ALT_SU + HS_AUSCUA_MED_SU + HS_AUSCUA_BAJ_SU + HS_AUSCUA_CO
            HS_CLICUA = HS_CLICUA_ALT_PT + HS_CLICUA_MED_PT + HS_CLICUA_BAJ_PT + HS_CLICUA_ALT_SU + HS_CLICUA_MED_SU + HS_CLICUA_BAJ_SU + HS_CLICUA_CO
            ' HS_REALCUA = HS_REALCUA_ALT_PT + HS_REALCUA_MED_PT + HS_REALCUA_BAJ_PT + HS_REALCUA_ALT_SU + HS_REALCUA_MED_SU + HS_REALCUA_BAJ_SU + HS_REALCUA_CO

            'PERCENT_TEC = (HS_REALTEC_PT + HS_REALTEC_SU + HS_REALTEC_CO) / (HS_TECTEOR_PT + HS_TECTEOR_SU + HS_TECTEOR_CO)
            'PERCENT_CUA = (HS_REALCUA_PT + HS_REALCUA_SU + HS_REALCUA_CO) / (HS_CUATEOR_SU + HS_CUATEOR_PT + HS_CUATEOR_CO)

            'SUMA GENERALES
            CANT_MINUTOS_TEC = (HS_REALTEC_ALT_PT + HS_REALTEC_MED_PT + HS_REALTEC_BAJ_PT + HS_REALTEC_ALT_SU + HS_REALTEC_MED_SU + HS_REALTEC_BAJ_SU + HS_REALTEC_CO) * 60
            CANT_MINUTOS_CUA = (HS_REALCUA_ALT_PT + HS_REALCUA_MED_PT + HS_REALCUA_BAJ_PT + HS_REALCUA_ALT_SU + HS_REALCUA_MED_SU + HS_REALCUA_BAJ_SU + HS_REALCUA_CO) * 60

            CANTIDAD_TEC = CANT_TEC_PRES_ALT_PT + CANT_TEC_PRES_MED_PT + CANT_TEC_PRES_BAJ_PT + CANT_TEC_PRES_ALT_SU + CANT_TEC_PRES_MED_SU + CANT_TEC_PRES_BAJ_SU + CANT_TEC_PRES_CO
            CANTIDAD_CUA = CANT_CUAD_PRES_ALT_PT + CANT_CUAD_PRES_MED_PT + CANT_CUAD_PRES_BAJ_PT + CANT_CUAD_PRES_ALT_SU + CANT_CUAD_PRES_MED_SU + CANT_CUAD_PRES_BAJ_SU + CANT_CUAD_PRES_CO

            'CREA O MODIFICA TABLA REGISTRO DIARIO
            REG_DIARIOTableAdapter.FillByFECHA(ANALISIS_AGDataSet.REG_DIARIO, FECHAINI.AddDays(X).ToShortDateString)
            If ANALISIS_AGDataSet.REG_DIARIO.Rows.Count > 0 Then
                REGISTRO_DIARIO(False, FECHAINI.AddDays(X))
                NOTIFICACION("SYS", "REGISTRO DIARIO MODIFICADO PARA EL DIA: " & FECHAINI.AddDays(X))
            Else
                REGISTRO_DIARIO(True, FECHAINI.AddDays(X))
                NOTIFICACION("SYS", "REGISTRO DIARIO CREADO PARA EL DIA: " & FECHAINI.AddDays(X))
            End If

            'CREA O MODIFICA CAPACIDAD DE AGENDA SEGUN TECNICOS DISPONIBLES
            If ANALISIS_AGDataSet.CAPACIDAXDIA.Rows.Count > 0 Then
                LBL_DIA.Text = "MODIFICANDO CAPACIDAD DE AGENDA PARA EL DIA: " & FECHAINI.AddDays(X)
                LBL_DIA.Refresh()
                CAPACIDADDIARow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)

                CAPACIDADDIARow.FECHA = FECHAINI.AddDays(X)
                CAPACIDADDIARow.MIN_TEC = CANT_MINUTOS_TEC
                CAPACIDADDIARow.MIN_CUA = CANT_MINUTOS_CUA
                CAPACIDADDIARow.CANT_TEC = CANTIDAD_TEC
                CAPACIDADDIARow.CANT_CUA = CANTIDAD_CUA

                CAPACIDADDIARow.MIN_ALT_TEC_CO = HS_REALTEC_CO * 60
                CAPACIDADDIARow.MIN_ALT_CUA_CO = HS_REALCUA_CO * 60 'CANT_MINUTOS_ALT_CUA_CO
                CAPACIDADDIARow.MIN_MED_TEC_CO = 0 ' CANT_MINUTOS_MED_TEC_CO
                CAPACIDADDIARow.MIN_MED_CUA_CO = 0 'CANT_MINUTOS_MED_CUA_CO
                CAPACIDADDIARow.MIN_BAJ_TEC_CO = 0 'CANT_MINUTOS_BAJ_TEC_CO
                CAPACIDADDIARow.MIN_BAJ_CUA_CO = 0 'CANT_MINUTOS_BAJ_CUA_CO

                CAPACIDADDIARow.MIN_ALT_TEC_PT = HS_REALTEC_ALT_PT * 60 ' CANT_MINUTOS_ALT_TEC_PT
                CAPACIDADDIARow.MIN_ALT_CUA_PT = HS_REALCUA_ALT_PT * 60 ' CANT_MINUTOS_ALT_CUA_PT
                CAPACIDADDIARow.MIN_MED_TEC_PT = HS_REALTEC_MED_PT * 60 ' CANT_MINUTOS_MED_TEC_PT
                CAPACIDADDIARow.MIN_MED_CUA_PT = HS_REALCUA_MED_PT * 60 ' CANT_MINUTOS_MED_CUA_PT
                CAPACIDADDIARow.MIN_BAJ_TEC_PT = HS_REALTEC_BAJ_PT * 60 ' CANT_MINUTOS_BAJ_TEC_PT
                CAPACIDADDIARow.MIN_BAJ_CUA_PT = HS_REALCUA_BAJ_PT * 60 ' CANT_MINUTOS_BAJ_CUA_PT

                CAPACIDADDIARow.MIN_ALT_TEC_SU = HS_REALTEC_ALT_SU * 60 ' CANT_MINUTOS_ALT_TEC_SU
                CAPACIDADDIARow.MIN_ALT_CUA_SU = HS_REALCUA_ALT_SU * 60 ' CANT_MINUTOS_ALT_CUA_SU
                CAPACIDADDIARow.MIN_MED_TEC_SU = HS_REALTEC_MED_SU * 60 ' CANT_MINUTOS_MED_TEC_SU
                CAPACIDADDIARow.MIN_MED_CUA_SU = HS_CUATEOR_MED_SU * 60 ' CANT_MINUTOS_MED_CUA_SU
                CAPACIDADDIARow.MIN_BAJ_TEC_SU = HS_REALTEC_BAJ_SU * 60 ' CANT_MINUTOS_BAJ_TEC_SU
                CAPACIDADDIARow.MIN_BAJ_CUA_SU = HS_REALCUA_BAJ_SU * 60 ' CANT_MINUTOS_BAJ_CUA_SU
                CAPACIDAXDIATableAdapter.Update(CAPACIDADDIARow)
            Else
                Dim NewCAPACIDADAGENDARow As ANALISIS_AGDataSet.CAPACIDAXDIARow
                NewCAPACIDADAGENDARow = ANALISIS_AGDataSet.CAPACIDAXDIA.NewCAPACIDAXDIARow
                LBL_DIA.Text = "CREANDO CAPACIDAD DE AGENDA PARA EL DIA: " & FECHAINI.AddDays(X)
                LBL_DIA.Refresh()
                NewCAPACIDADAGENDARow("FECHA") = FECHAINI.AddDays(X)
                NewCAPACIDADAGENDARow("MIN_TEC") = CANT_MINUTOS_TEC
                NewCAPACIDADAGENDARow("MIN_CUA") = CANT_MINUTOS_CUA
                NewCAPACIDADAGENDARow("CANT_TEC") = CANTIDAD_TEC
                NewCAPACIDADAGENDARow("CANT_CUA") = CANTIDAD_CUA

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_CO") = HS_REALTEC_CO * 60
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_CO") = HS_REALCUA_CO * 60 'CANT_MINUTOS_ALT_CUA_CO
                NewCAPACIDADAGENDARow("MIN_MED_TEC_CO") = 0 ' CANT_MINUTOS_MED_TEC_CO
                NewCAPACIDADAGENDARow("MIN_MED_CUA_CO") = 0 'CANT_MINUTOS_MED_CUA_CO
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_CO") = 0 'CANT_MINUTOS_BAJ_TEC_CO
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_CO") = 0 'CANT_MINUTOS_BAJ_CUA_CO

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_PT") = HS_REALTEC_ALT_PT * 60 ' CANT_MINUTOS_ALT_TEC_PT
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_PT") = HS_REALCUA_ALT_PT * 60 ' CANT_MINUTOS_ALT_CUA_PT
                NewCAPACIDADAGENDARow("MIN_MED_TEC_PT") = HS_REALTEC_MED_PT * 60 ' CANT_MINUTOS_MED_TEC_PT
                NewCAPACIDADAGENDARow("MIN_MED_CUA_PT") = HS_REALCUA_MED_PT * 60 ' CANT_MINUTOS_MED_CUA_PT
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_PT") = HS_REALTEC_BAJ_PT * 60 ' CANT_MINUTOS_BAJ_TEC_PT
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_PT") = HS_REALCUA_BAJ_PT * 60 ' CANT_MINUTOS_BAJ_CUA_PT

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_SU") = HS_REALTEC_ALT_SU * 60 ' CANT_MINUTOS_ALT_TEC_SU
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_SU") = HS_REALCUA_ALT_SU * 60 ' CANT_MINUTOS_ALT_CUA_SU
                NewCAPACIDADAGENDARow("MIN_MED_TEC_SU") = HS_REALTEC_MED_SU * 60 ' CANT_MINUTOS_MED_TEC_SU
                NewCAPACIDADAGENDARow("MIN_MED_CUA_SU") = HS_CUATEOR_MED_SU * 60 ' CANT_MINUTOS_MED_CUA_SU
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_SU") = HS_REALTEC_BAJ_SU * 60 ' CANT_MINUTOS_BAJ_TEC_SU
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_SU") = HS_REALCUA_BAJ_SU * 60 ' CANT_MINUTOS_BAJ_CUA_SU

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_CO_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_CO_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_TEC_CO_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_CUA_CO_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_CO_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_CO_AGE") = 0

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_PT_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_PT_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_TEC_PT_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_CUA_PT_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_PT_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_PT_AGE") = 0

                NewCAPACIDADAGENDARow("MIN_ALT_TEC_SU_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_ALT_CUA_SU_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_TEC_SU_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_MED_CUA_SU_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_TEC_SU_AGE") = 0
                NewCAPACIDADAGENDARow("MIN_BAJ_CUA_SU_AGE") = 0

                ANALISIS_AGDataSet.CAPACIDAXDIA.AddCAPACIDAXDIARow(NewCAPACIDADAGENDARow)
                CAPACIDAXDIATableAdapter.Update(ANALISIS_AGDataSet.CAPACIDAXDIA)
            End If
        Next
        CAPACIDAXDIATableAdapter.FillByDESDEFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, Today.ToShortDateString)
        LBL_DIA.Text = "PROCESO TERMINADO"
        Cursor = Cursors.Default
    End Sub 'CREA O MODIFICA LA CAPACIDAD POR DIA DESDE BOTON
    Private Sub REGISTRO_DIARIO(ByVal NUEVO_REG As Boolean, ByVal FECHA As Date)
        Select Case NUEVO_REG
            Case True
                Dim NewREG_DIARIORow As ANALISIS_AGDataSet.REG_DIARIORow
                NewREG_DIARIORow = ANALISIS_AGDataSet.REG_DIARIO.NewREG_DIARIORow
                NewREG_DIARIORow("FECHA") = FECHA.ToShortDateString
                NewREG_DIARIORow("DIASEM") = FECHA.ToString("dddd").ToUpper
                NewREG_DIARIORow("DIA") = CDate(FECHA).Day
                NewREG_DIARIORow("MES") = UCase(MonthName(Month(FECHA)))
                NewREG_DIARIORow("AÑO") = Year(FECHA)
                NewREG_DIARIORow("CANT_TECPRES") = CANTIDAD_TEC
                NewREG_DIARIORow("CANT_CUADPRES") = CANTIDAD_CUA
                NewREG_DIARIORow("UT_RETENTEC") = 0
                NewREG_DIARIORow("UT_RETENCUAD") = 0
                NewREG_DIARIORow("UT_AUSENCIASCUAD") = CInt(HS_AUSCUA * 12)
                NewREG_DIARIORow("UT_TEORICATEC") = CInt(HS_TECTEOR * 12)
                NewREG_DIARIORow("UT_ACTIVATEC") = CInt((HS_TECTEOR - HS_AUSTEC) * 12)
                NewREG_DIARIORow("UT_AUSENCIASTEC") = CInt(HS_AUSTEC * 12)
                NewREG_DIARIORow("UT_CLIMATEC") = CInt(HS_CLITEC * 12)
                NewREG_DIARIORow("UT_REALTEC") = CInt((HS_TECTEOR - HS_AUSTEC - HS_CLITEC) * 12)
                NewREG_DIARIORow("UT_TEORICACUAD") = CInt(HS_CUATEOR * 12)
                NewREG_DIARIORow("UT_ACTIVACUAD") = CInt((HS_CUATEOR - HS_AUSCUA) * 12)
                NewREG_DIARIORow("UT_CLIMACUAD") = CInt(HS_CLICUA * 12)
                NewREG_DIARIORow("UT_REALCUAD") = CInt((HS_CUATEOR - HS_AUSCUA - HS_CLICUA) * 12)
                ANALISIS_AGDataSet.REG_DIARIO.Rows.Add(NewREG_DIARIORow)
            Case False
                REG_DIARIORow = ANALISIS_AGDataSet.REG_DIARIO.Rows(0)
                REG_DIARIORow("CANT_TECPRES") = CANTIDAD_TEC
                REG_DIARIORow("CANT_CUADPRES") = CANTIDAD_CUA
                REG_DIARIORow("UT_AUSENCIASCUAD") = CInt(HS_AUSCUA * 12)
                REG_DIARIORow("UT_TEORICATEC") = CInt(HS_TECTEOR * 12)
                REG_DIARIORow("UT_ACTIVATEC") = CInt((HS_TECTEOR - HS_AUSTEC) * 12)
                REG_DIARIORow("UT_AUSENCIASTEC") = CInt(HS_AUSTEC * 12)
                REG_DIARIORow("UT_CLIMATEC") = CInt(HS_CLITEC * 12)
                REG_DIARIORow("UT_REALTEC") = CInt((HS_TECTEOR - HS_AUSTEC - HS_CLITEC) * 12)
                REG_DIARIORow("UT_TEORICACUAD") = CInt(HS_CUATEOR * 12)
                REG_DIARIORow("UT_ACTIVACUAD") = CInt((HS_CUATEOR - HS_AUSCUA) * 12)
                REG_DIARIORow("UT_CLIMACUAD") = CInt(HS_CLICUA * 12)
                REG_DIARIORow("UT_REALCUAD") = CInt((HS_CUATEOR - HS_AUSCUA - HS_CLICUA) * 12)
        End Select
        REG_DIARIOTableAdapter.Update(ANALISIS_AGDataSet.REG_DIARIO)


    End Sub
    Private Sub CALCULACLIMA_FILL(ByVal FECHA)
        METEOROLOGIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.METEOROLOGIA, FECHA)

        'RECORRE LA TABLA DE INCLEMENCIAS CLIMATICAS
        If ANALISIS_AGDataSet.METEOROLOGIA.Rows.Count > 0 Then
            'SE CORRE ESTE CICLO POR CADA REGISTRO DE METEOROLOGIA
            For X = 0 To ANALISIS_AGDataSet.METEOROLOGIA.Rows.Count - 1
                If ANALISIS_AGDataSet.METEOROLOGIA.Rows(X).Item("DESDE") <> "" Then
                    'SETEO DEL HORARIO DEL CLIMA PARA ESE DIA
                    CLIINI = ANALISIS_AGDataSet.METEOROLOGIA.Rows(X).Item("DESDE")
                    CLIFIN = ANALISIS_AGDataSet.METEOROLOGIA.Rows(X).Item("HASTA")

                    'RECORRE LA BASE DE DATOS DE TECNICOS Y CUADRILLAS PRESENTES
                    For T = 0 To ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count - 1
                        REGAUSENCIASRow = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(T)
                        'SELECCIONA SI EL TECNICO ESTA PRESENTE 
                        If REGAUSENCIASRow("PRESENCIA") = "SI" Then
                            'CARGA TIEMPO DE INGRESO Y SALIDA DE TECNICO

                            TECNICOINI = REGAUSENCIASRow("INICIO")
                            TECNICOFIN = REGAUSENCIASRow("FIN")
                            Select Case REGAUSENCIASRow("RECURSO")
                                Case "PLANIFICACION TECNICA"
                                    Select Case REGAUSENCIASRow("SECTOR")
                                        Case "RED/MDU"
                                            Select Case REGAUSENCIASRow("PRIORIDAD")
                                                Case "ALTA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "MEDIA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "BAJA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                            End Select
                                        Case "CUAD RED", "CUAD MDU"         'SI EL TECNICO ES DE CUAD 
                                            Select Case REGAUSENCIASRow("PRIORIDAD")
                                                Case "ALTA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "MEDIA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "BAJA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_PT += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                            End Select
                                    End Select
                                Case "SUPERVISION"
                                    Select Case REGAUSENCIASRow("SECTOR")
                                        Case "RED/MDU"
                                            Select Case REGAUSENCIASRow("PRIORIDAD")
                                                Case "ALTA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_ALT_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_ALT_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_ALT_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "MEDIA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_MED_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_MED_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_MED_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "BAJA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLITEC_BAJ_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLITEC_BAJ_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLITEC_BAJ_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                            End Select
                                        Case "CUAD RED", "CUAD MDU"         'SI EL TECNICO ES DE CUAD 
                                            Select Case REGAUSENCIASRow("PRIORIDAD")
                                                Case "ALTA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLICUA_ALT_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_ALT_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLICUA_ALT_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_ALT_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "MEDIA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLICUA_MED_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_MED_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLICUA_MED_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_MED_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                                Case "BAJA"
                                                    If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                        If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then
                                                                HS_CLICUA_BAJ_SU += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_BAJ_SU += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    Else
                                                        If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                            If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                                HS_CLICUA_BAJ_SU += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                            Else
                                                                HS_CLICUA_BAJ_SU += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                            End If
                                                        End If
                                                    End If
                                            End Select
                                    End Select
                                Case "CORRECTIVO"
                                    Select Case REGAUSENCIASRow("SECTOR")
                                        Case "RED/MDU"
                                            If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                    If CLIFIN <= TECNICOFIN Then
                                                        HS_CLITEC_CO += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                    Else
                                                        HS_CLITEC_CO += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                    End If
                                                End If
                                            Else
                                                If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                    If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                        HS_CLITEC_CO += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                    Else
                                                        HS_CLITEC_CO += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                    End If
                                                End If
                                            End If
                                        Case "CUAD RED", "CUAD MDU"         'SI EL TECNICO ES DE CUAD 
                                            If CLIINI <= TECNICOINI Then  'SI EL EFECTO CLIMATICO EMPIEZA ANTES DEL TURNO DEL TECNICO
                                                If CLIFIN > TECNICOINI Then  'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                    If CLIFIN <= TECNICOFIN Then
                                                        HS_CLICUA_CO += DateDiff(DateInterval.Hour, TECNICOINI, CLIFIN)
                                                    Else
                                                        HS_CLICUA_CO += DateDiff(DateInterval.Hour, TECNICOINI, TECNICOFIN)
                                                    End If
                                                End If
                                            Else
                                                If CLIFIN > TECNICOINI Then 'SI EL EFECTO CLIMATICO EMPIEZA DESPUES DEL TURNO DEL TECNICO
                                                    If CLIFIN <= TECNICOFIN Then 'SI EL EFECTO CLIMATICO TERMINA ANTES  DEL TURNO DEL TECNICO
                                                        HS_CLICUA_CO += DateDiff(DateInterval.Hour, CLIINI, CLIFIN)
                                                    Else
                                                        HS_CLICUA_CO += DateDiff(DateInterval.Hour, CLIINI, TECNICOFIN)
                                                    End If
                                                End If
                                            End If
                                    End Select
                            End Select
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub BOT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BOT_AGREGAR.Click
        HABILITAR_INGRESO()
        ACCION = "AGREGAR"
        BTN_GRABAR_TEC.Enabled = True
    End Sub 'BOTON PARA AGREGAR TECNICO NUEVO (HABILITA CAMPOS)
    Private Sub HABILITAR_INGRESO()
        LUN_ENT1.Enabled = True
        MAR_ENT1.Enabled = True
        MIE_ENT1.Enabled = True
        JUE_ENT1.Enabled = True
        VIE_ENT1.Enabled = True
        SAB_ENT1.Enabled = True
        DOM_ENT1.Enabled = True
        NOM1.Enabled = True
    End Sub
    Private Sub BTN_GRABAR_TEC_Click(sender As Object, e As EventArgs) Handles BTN_GRABAR_TEC.Click
        Dim NewTECNICOSRow As DataRow
        If ACCION = "AGREGAR" Then
            NewTECNICOSRow = ANALISIS_AGDataSet.TECNICOS.NewTECNICOSRow
        Else
            NewTECNICOSRow = ANALISIS_AGDataSet.TECNICOS.FindById(ANALISIS_AGDataSet.TECNICOS.Rows(TECNICOSBindingSource.Position).Item("id"))
        End If
        NewTECNICOSRow("DA_CAPACIDAD") = CAPACIDAD.Text
        NewTECNICOSRow("NOMBRE") = NOM1.Text
        NewTECNICOSRow("SECTOR") = SECTOR1.Text
        NewTECNICOSRow("TIPO") = TIPO1.Text

        NewTECNICOSRow("LUN_ENT") = LUN_ENT1.Text
        If LUN_ENT1.Text <> "--" Then
            NewTECNICOSRow("LUN_HS") = LUN_HS1.Text
            NewTECNICOSRow("LUN_PRIO") = CB_LUN_PRIORIDAD.Text
            NewTECNICOSRow("LUN_RECURSO") = CB_LUN_RECURSO.Text
        Else
            NewTECNICOSRow("LUN_HS") = "--"
            NewTECNICOSRow("LUN_PRIO") = "--"
            NewTECNICOSRow("LUN_RECURSO") = "--"
        End If
        NewTECNICOSRow("MAR_ENT") = MAR_ENT1.Text
        If MAR_ENT1.Text <> "--" Then
            NewTECNICOSRow("MAR_HS") = MAR_HS1.Text
            NewTECNICOSRow("MAR_PRIO") = CB_MAR_PRIORIDAD.Text
            NewTECNICOSRow("MAR_RECURSO") = CB_MAR_RECURSO.Text
        Else
            NewTECNICOSRow("MAR_HS") = "--"
            NewTECNICOSRow("MAR_PRIO") = "--"
            NewTECNICOSRow("MAR_RECURSO") = "--"
        End If
        NewTECNICOSRow("MIE_ENT") = MIE_ENT1.Text
        If MIE_ENT1.Text <> "--" Then
            NewTECNICOSRow("MIE_HS") = MIE_HS1.Text
            NewTECNICOSRow("MIER_PRIO") = CB_MIER_PRIORIDAD.Text
            NewTECNICOSRow("MIER_RECURSO") = CB_MIER_RECURSO.Text
        Else
            NewTECNICOSRow("MIE_HS") = "--"
            NewTECNICOSRow("MIER_PRIO") = "--"
            NewTECNICOSRow("MIER_RECURSO") = "--"
        End If
        NewTECNICOSRow("JUE_ENT") = JUE_ENT1.Text
        If JUE_ENT1.Text <> "--" Then
            NewTECNICOSRow("JUE_HS") = JUE_HS1.Text
            NewTECNICOSRow("JUEV_PRIO") = CB_JUE_PRIORIDAD.Text
            NewTECNICOSRow("JUEV_RECURSO") = CB_JUEV_RECURSO.Text
        Else
            NewTECNICOSRow("JUE_HS") = "--"
            NewTECNICOSRow("JUEV_PRIO") = "--"
            NewTECNICOSRow("JUEV_RECURSO") = "--"
        End If
        NewTECNICOSRow("VIE_ENT") = VIE_ENT1.Text
        If VIE_ENT1.Text <> "--" Then
            NewTECNICOSRow("VIE_HS") = VIE_HS1.Text
            NewTECNICOSRow("VIER_PRIO") = CB_VIER_PRIORIDAD.Text
            NewTECNICOSRow("VIER_RECURSO") = CB_VIER_RECURSO.Text
        Else
            NewTECNICOSRow("VIE_HS") = "--"
            NewTECNICOSRow("VIER_PRIO") = "--"
            NewTECNICOSRow("VIER_RECURSO") = "--"
        End If
        NewTECNICOSRow("SAB_ENT") = SAB_ENT1.Text
        If SAB_ENT1.Text <> "--" Then
            NewTECNICOSRow("SAB_HS") = SAB_HS1.Text
            NewTECNICOSRow("SAB_PRIO") = CB_SAB_PRIORIDAD.Text
            NewTECNICOSRow("SAB_RECURSO") = CB_SAB_RECURSO.Text
        Else
            NewTECNICOSRow("SAB_HS") = "--"
            NewTECNICOSRow("SAB_PRIO") = "--"
            NewTECNICOSRow("SAB_RECURSO") = "--"
        End If
        NewTECNICOSRow("DOM_ENT") = DOM_ENT1.Text
        If DOM_ENT1.Text <> "--" Then
            NewTECNICOSRow("DOM_HS") = DOM_HS1.Text
            NewTECNICOSRow("DOM_PRIO") = CB_DOM_PRIORIDAD.Text
            NewTECNICOSRow("DOM_RECURSO") = CB_DOM_RECURSO.Text
        Else
            NewTECNICOSRow("DOM_HS") = "--"
            NewTECNICOSRow("DOM_PRIO") = "--"
            NewTECNICOSRow("DOM_RECURSO") = "--"
        End If
        NewTECNICOSRow("TELEFONO") = TXT_TELEFONO.Text

        If ACCION = "AGREGAR" Then
            ANALISIS_AGDataSet.TECNICOS.Rows.Add(NewTECNICOSRow)
        End If
        Me.Cursor = Cursors.WaitCursor
        Me.Validate()
        TECNICOSTableAdapter.Update(ANALISIS_AGDataSet.TECNICOS)

        BUSCA_HORAS_P_AGREGAR_TECNICO()
        CONDICION_INI_P_AGREGARTECNICO()
        RECALCULAR_MAPA_AGENDA()
        Me.Cursor = Cursors.Default
    End Sub 'GRABA O MODIFICA TECNICO
    Private Sub CONDICION_INI_P_AGREGARTECNICO()
        NOM1.Text = ""
        SECTOR1.Text = "--"
        TIPO1.Text = "--"
        CAPACIDAD.Text = "--"
        LUN_ENT1.Text = "--"
        MAR_ENT1.Text = "--"
        MIE_ENT1.Text = "--"
        JUE_ENT1.Text = "--"
        VIE_ENT1.Text = "--"
        SAB_ENT1.Text = "--"
        DOM_ENT1.Text = "--"

        LUN_HS1.Text = "9"
        MAR_HS1.Text = "9"
        MIE_HS1.Text = "9"
        JUE_HS1.Text = "9"
        VIE_HS1.Text = "9"
        SAB_HS1.Text = "9"
        DOM_HS1.Text = "9"

        LUN_ENT1.Enabled = False
        MAR_ENT1.Enabled = False
        MIE_ENT1.Enabled = False
        JUE_ENT1.Enabled = False
        VIE_ENT1.Enabled = False
        SAB_ENT1.Enabled = False
        DOM_ENT1.Enabled = False
        NOM1.Enabled = False

        'CB_PRIORIDAD_TEC.Text = ""
        CB_LUN_PRIORIDAD.Text = ""
        TXT_TELEFONO.Text = ""
        BOT_AGREGAR.Enabled = True
        BOT_BORRAR.Enabled = False
        BOT_EDITAR.Enabled = False
        BTN_GRABAR_TEC.Enabled = False
    End Sub
    Private Sub BUSCA_HORAS_P_AGREGAR_TECNICO()
        Me.TECNICOSTableAdapter.Fill(Me.ANALISIS_AGDataSet.TECNICOS)
        For I = 0 To ANALISIS_AGDataSet.TECNICOS.Rows.Count - 1
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("LUN_HS") <> "--" Then HSLUNES = HSLUNES + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("LUN_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("MAR_HS") <> "--" Then HSMARTES = HSMARTES + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("MAR_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("MIE_HS") <> "--" Then HSMIERCOLES = HSMIERCOLES + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("MIE_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("JUE_HS") <> "--" Then HSJUEVES = HSJUEVES + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("JUE_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("VIE_HS") <> "--" Then HSVIERNES = HSVIERNES + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("VIE_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("SAB_HS") <> "--" Then HSSABADO = HSSABADO + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("SAB_HS")
            If ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("DOM_HS") <> "--" Then HSDOMINGO = HSDOMINGO + ANALISIS_AGDataSet.TECNICOS.Rows(I).Item("DOM_HS")
        Next
        HSLUN.Text = HSLUNES
        HSMAR.Text = HSMARTES
        HSMIE.Text = HSMIERCOLES
        HSJUE.Text = HSJUEVES
        HSVIE.Text = HSVIERNES
        HSSAB.Text = HSSABADO
        HSDOM.Text = HSDOMINGO

        UTLUN.Text = HSLUNES * 12
        UTMAR.Text = HSMARTES * 12
        UTMIE.Text = HSMIERCOLES * 12
        UTJUE.Text = HSJUEVES * 12
        UTVIE.Text = HSVIERNES * 12
        UTSAB.Text = HSSABADO * 12
        UTDOM.Text = HSDOMINGO * 12


        HSLUNES = 0
        HSMARTES = 0
        HSMIERCOLES = 0
        HSJUEVES = 0
        HSVIERNES = 0
        HSSABADO = 0
        HSDOMINGO = 0

    End Sub
    Private Sub BTN_CERRAR_PARAMETROS_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_PARAMETROS.Click
        ACCION_AGENDA = "VER AGENDA"
        P_PARAMETROS.Visible = False
        BTN_CERRAR_PARAMETROS.Visible = False
        P_LATERAL.Visible = True
        P_CALENDARIO.Visible = True
    End Sub
    Private Sub BTN_ACTUALIZAR_DISTRIBUCION_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR_DISTRIBUCION.Click

        Dim FILAMAPA As Integer
        Dim DIAMAPA As Integer
        Dim FILADIST As Integer
        Dim DIADIST As Integer

        Dim TOTAL_DIATEC(10) As Integer
        Dim TOTAL_DIACUA(10) As Integer
        Dim SECTOR(20) As String
        Dim RECURSOS(20) As String

        Dim PORCALTA(7) As Double
        Dim PORCMEDIA(7) As Double
        Dim PORCBAJA(7) As Double
        DISTRIBUCION_AGENDATableAdapter.Fill(ANALISIS_AGDataSet.DISTRIBUCION_AGENDA)
        For FILAMAPA = 0 To ANALISIS_AGDataSet.MAPA_AGENDA.Rows.Count - 1
            MAPARow = ANALISIS_AGDataSet.MAPA_AGENDA.Rows(FILAMAPA)
            SECTOR(FILAMAPA) = MAPARow("SECTOR")
            RECURSOS(FILAMAPA) = MAPARow("RECURSOS")
            'CALCULA EL TOTAL DE TECNICOS X DIA
            For DIAMAPA = 1 To 7
                Select Case MAPARow("RECURSOS")
                    Case "Tecnicos"
                        TOTAL_DIATEC(DIAMAPA) = MAPARow(DIAMAPA & "A") + MAPARow(DIAMAPA & "M") + MAPARow(DIAMAPA & "B") + TOTAL_DIATEC(DIAMAPA)
                    Case "Cuadrilla"
                        TOTAL_DIACUA(DIAMAPA) = MAPARow(DIAMAPA & "A") + MAPARow(DIAMAPA & "M") + MAPARow(DIAMAPA & "B") + TOTAL_DIACUA(DIAMAPA)
                End Select
            Next DIAMAPA
        Next FILAMAPA

        For FILADIST = 0 To 5
            MAPARow = ANALISIS_AGDataSet.MAPA_AGENDA.Rows(FILADIST)
            DISTRIBUCIONAGERow = ANALISIS_AGDataSet.DISTRIBUCION_AGENDA.Rows(FILADIST)
            DISTRIBUCIONAGERow("SECTOR") = SECTOR(FILADIST)
            DISTRIBUCIONAGERow("RECURSO") = RECURSOS(FILADIST)
            DISTRIBUCIONAGERow("FECHA") = Today.ToShortDateString
            For DIADIST = 1 To 7
                Select Case RECURSOS(FILADIST)
                    Case "Tecnicos"
                        DISTRIBUCIONAGERow(DIADIST & "A") = CInt(MAPARow(DIADIST & "A") / TOTAL_DIATEC(DIADIST) * 100)
                        DISTRIBUCIONAGERow(DIADIST & "M") = CInt(MAPARow(DIADIST & "M") / TOTAL_DIATEC(DIADIST) * 100)
                        DISTRIBUCIONAGERow(DIADIST & "B") = CInt(MAPARow(DIADIST & "B") / TOTAL_DIATEC(DIADIST) * 100)
                    Case "Cuadrilla"
                        If TOTAL_DIACUA(DIADIST) > 0 Then
                            DISTRIBUCIONAGERow(DIADIST & "A") = CInt(MAPARow(DIADIST & "A") / TOTAL_DIACUA(DIADIST) * 100)
                        Else
                            DISTRIBUCIONAGERow(DIADIST & "A") = 0
                        End If

                        If TOTAL_DIACUA(DIADIST) > 0 Then
                            DISTRIBUCIONAGERow(DIADIST & "M") = CInt(MAPARow(DIADIST & "M") / TOTAL_DIACUA(DIADIST) * 100)
                        Else
                            DISTRIBUCIONAGERow(DIADIST & "M") = 0
                        End If

                        If TOTAL_DIACUA(DIADIST) > 0 Then
                            DISTRIBUCIONAGERow(DIADIST & "B") = CInt(MAPARow(DIADIST & "B") / TOTAL_DIACUA(DIADIST) * 100)
                        Else
                            DISTRIBUCIONAGERow(DIADIST & "B") = 0
                        End If
                End Select
            Next DIADIST
        Next FILADIST
        DISTRIBUCION_AGENDATableAdapter.Update(ANALISIS_AGDataSet.DISTRIBUCION_AGENDA)
    End Sub
    Private Sub BOT_EDITAR_Click(sender As Object, e As EventArgs) Handles BOT_EDITAR.Click
        HABILITAR_INGRESO()
        BTN_GRABAR_TEC.Enabled = True
        TECNICOSRow = ANALISIS_AGDataSet.TECNICOS.FindById(TECNICOSDataGridView.CurrentRow.Cells(0).Value)

        NOM1.Text = TECNICOSRow("NOMBRE")
        SECTOR1.Text = TECNICOSRow("SECTOR")
        TIPO1.Text = TECNICOSRow("TIPO")
        LUN_ENT1.Text = TECNICOSRow("LUN_ENT")
        LUN_HS1.Text = TECNICOSRow("LUN_HS")
        CB_LUN_PRIORIDAD.Text = TECNICOSRow("LUN_PRIO")
        CB_LUN_RECURSO.Text = TECNICOSRow("LUN_RECURSO")

        MAR_ENT1.Text = TECNICOSRow("MAR_ENT")
        MAR_HS1.Text = TECNICOSRow("MAR_HS")
        CB_MAR_PRIORIDAD.Text = TECNICOSRow("MAR_PRIO")
        CB_MAR_RECURSO.Text = TECNICOSRow("MAR_RECURSO")

        MIE_ENT1.Text = TECNICOSRow("MIE_ENT")
        MIE_HS1.Text = TECNICOSRow("MIE_HS")
        CB_MIER_PRIORIDAD.Text = TECNICOSRow("MIER_PRIO")
        CB_MIER_RECURSO.Text = TECNICOSRow("MIER_RECURSO")

        JUE_ENT1.Text = TECNICOSRow("JUE_ENT")
        JUE_HS1.Text = TECNICOSRow("JUE_HS")
        CB_JUE_PRIORIDAD.Text = TECNICOSRow("JUEV_PRIO")
        CB_JUEV_RECURSO.Text = TECNICOSRow("JUEV_RECURSO")

        VIE_ENT1.Text = TECNICOSRow("VIE_ENT")
        VIE_HS1.Text = TECNICOSRow("VIE_HS")
        CB_VIER_PRIORIDAD.Text = TECNICOSRow("VIER_PRIO")
        CB_VIER_RECURSO.Text = TECNICOSRow("VIER_RECURSO")

        SAB_ENT1.Text = TECNICOSRow("SAB_ENT")
        SAB_HS1.Text = TECNICOSRow("SAB_HS")
        CB_SAB_PRIORIDAD.Text = TECNICOSRow("SAB_PRIO")
        CB_SAB_RECURSO.Text = TECNICOSRow("SAB_RECURSO")

        DOM_ENT1.Text = TECNICOSRow("DOM_ENT")
        DOM_HS1.Text = TECNICOSRow("DOM_HS")
        CB_DOM_PRIORIDAD.Text = TECNICOSRow("DOM_PRIO")
        CB_DOM_RECURSO.Text = TECNICOSRow("DOM_RECURSO")

        CAPACIDAD.Text = TECNICOSRow("DA_CAPACIDAD")

        ' If IsDBNull(TECNICOSRow("RECURSO")) = False Then CB_LUN_PRIORIDAD.Text = TECNICOSRow("RECURSO")
        '   If IsDBNull(TECNICOSRow("PRIORIDAD")) = False Then CB_PRIORIDAD_TEC.Text = TECNICOSRow("PRIORIDAD")
        If IsDBNull(TECNICOSRow("TELEFONO")) = False Then TXT_TELEFONO.Text = TECNICOSRow("TELEFONO")
        ACCION = "EDITAR"
    End Sub 'HABILITA Y LLENA LOS CAMPOS PARA EDITAR TECNICO
    Private Sub TECNICOSDataGridView_Click(sender As Object, e As EventArgs) Handles TECNICOSDataGridView.Click
        BOT_EDITAR.Enabled = True
        BOT_BORRAR.Enabled = True
        BOT_AGREGAR.Enabled = False
    End Sub
    Private Sub BOT_CANCELAR_Click(sender As Object, e As EventArgs)
        CONDICION_INI_P_AGREGARTECNICO()
    End Sub
    Private Sub TECNICOSDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles TECNICOSDataGridView.SelectionChanged
        CONDICION_INI_P_AGREGARTECNICO()
    End Sub
    Private Sub BOT_BORRAR_Click(sender As Object, e As EventArgs) Handles BOT_BORRAR.Click
        TECNICOSRow = ANALISIS_AGDataSet.TECNICOS.FindById(TECNICOSDataGridView.CurrentRow.Cells(0).Value)
        TECNICOSRow.Delete()
        TECNICOSTableAdapter.Update(ANALISIS_AGDataSet.TECNICOS)
        BUSCA_HORAS_P_AGREGAR_TECNICO()
        CONDICION_INI_P_AGREGARTECNICO()
    End Sub
    Private Sub BTN_GUARDIAS_Click(sender As Object, e As EventArgs) Handles BTN_GUARDIAS.Click
        P_LATERAL.Visible = False
        P_GUARDIAS.Visible = True
        P_GUARDIAS.BringToFront()

        GUARDIASTableAdapter.FillByDESDE(INDICESDataSet.GUARDIAS, Today.ToShortDateString)
        'CARGA LOS TECNICOS EN EL COMBOBOX
        TECNICOSTableAdapter.Fill(ANALISIS_AGDataSet.TECNICOS)
        CB_GUARD_TEC.Items.Clear()
        CB_GUARD_TEC.Items.Add("")
        For X = 0 To ANALISIS_AGDataSet.TECNICOS.Rows.Count - 1
            CB_GUARD_TEC.Items.Add(ANALISIS_AGDataSet.TECNICOS.Rows(X).Item("NOMBRE"))
        Next
        'CARGA LOS AYUDANTES EN EL COMBOBOX
        AYUDANTESTableAdapter.Fill(ANALISIS_AGDataSet.AYUDANTES)
        CB_GUARD_AYUDANTE.Items.Clear()
        CB_GUARD_AYUDANTE.Items.Add("")
        For X = 0 To ANALISIS_AGDataSet.AYUDANTES.Rows.Count - 1
            CB_GUARD_AYUDANTE.Items.Add(ANALISIS_AGDataSet.AYUDANTES.Rows(X).Item("NOMBRE"))
        Next
    End Sub
    Private Sub BTN_AYUDANTES_Click(sender As Object, e As EventArgs) Handles BTN_AYUDANTES.Click
        P_AYUDANTE.Visible = True
        AYUDANTESTableAdapter.Fill(ANALISIS_AGDataSet.AYUDANTES)
        'CARGA LOS TECNICOS EN EL COMBOBOX
        TECNICOSTableAdapter.Fill(ANALISIS_AGDataSet.TECNICOS)
        CB_TEC_DE_AYUD.Items.Clear()
        CB_TEC_DE_AYUD.Items.Add("")
        For X = 0 To ANALISIS_AGDataSet.TECNICOS.Rows.Count - 1
            CB_TEC_DE_AYUD.Items.Add(ANALISIS_AGDataSet.TECNICOS.Rows(X).Item("NOMBRE"))
        Next
    End Sub
    Private Sub BTN_CERRAR_AYUD_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_AYUD.Click
        P_AYUDANTE.Visible = False
    End Sub
    Private Sub BTN_ING_AYUDANTE_Click(sender As Object, e As EventArgs) Handles BTN_ING_AYUDANTE.Click
        Try
            Dim NEW_AYUDANTE As ANALISIS_AGDataSet.AYUDANTESRow
            NEW_AYUDANTE = ANALISIS_AGDataSet.AYUDANTES.NewAYUDANTESRow
            NEW_AYUDANTE.TEC_ASOC = CB_TEC_DE_AYUD.Text
            NEW_AYUDANTE.NOMBRE = TXT_NOMBRE_AYUD.Text
            ANALISIS_AGDataSet.AYUDANTES.AddAYUDANTESRow(NEW_AYUDANTE)
            AYUDANTESTableAdapter.Update(NEW_AYUDANTE)
            MsgBox("REGISTRO INGRESADO")
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
        End Try
    End Sub
    Private Sub BTN_MODIFICA_AYUDANTE_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICA_AYUDANTE.Click
        If TXT_NOMBRE_AYUD.Text <> "" Then
            Dim AYUDANTEROW As ANALISIS_AGDataSet.AYUDANTESRow
            AYUDANTEROW = ANALISIS_AGDataSet.AYUDANTES.Rows(AYUDANTESDataGridView.CurrentRow.Cells(0).RowIndex)
            AYUDANTEROW.TEC_ASOC = CB_TEC_DE_AYUD.Text
            AYUDANTEROW.NOMBRE = TXT_NOMBRE_AYUD.Text
            AYUDANTESTableAdapter.Update(AYUDANTEROW)
        End If
    End Sub
    Private Sub AYUDANTESDataGridView_Click(sender As Object, e As EventArgs) Handles AYUDANTESDataGridView.Click
        If AYUDANTESDataGridView.Rows.Count > 0 Then
            TXT_NOMBRE_AYUD.Text = AYUDANTESDataGridView.CurrentRow.Cells(0).Value
            CB_TEC_DE_AYUD.Text = AYUDANTESDataGridView.CurrentRow.Cells(1).Value
        End If
    End Sub
    Private Sub BTN_ING_GUARDIA_Click(sender As Object, e As EventArgs) Handles BTN_ING_GUARDIA.Click
        If CB_GUARD_TEC.Text = "" Then
            MsgBox("COMPLETE EL TECNICO A MARCAR")
            Exit Sub
        End If
        If CB_GUARD_AYUDANTE.Text = "" Then
            MsgBox("COMPLETE EL AYUDANTE A MARCAR")
            Exit Sub
        End If
        If CB_TIPO_GUARDIA.Text = "SELECCIONE" Then
            MsgBox("ELIJA EL TIPO DE GUARDIA A GENERAR")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Try
            Dim CANTDIAS_GUARDIA As Integer = DateDiff(DateInterval.Day, DT_GUARDIA_INI.Value, DT_GUARDIA_FIN.Value)
            For D = 0 To CANTDIAS_GUARDIA
                GUARDIASTableAdapter.FillByFECHAyTIPO(INDICESDataSet.GUARDIAS, DT_GUARDIA_INI.Value.AddDays(D).ToShortDateString, CB_TIPO_GUARDIA.Text)
                If INDICESDataSet.GUARDIAS.Rows.Count > 0 Then
                    Dim DIALOGRESULT As DialogResult = MsgBox("YA EXISTE GUARDIA INGRESADA PARA EL DIA " & DT_GUARDIA_INI.Value.AddDays(D).ToShortDateString & vbNewLine & "DESEA SOBREESCRIBIR CON LOS NUEVOS DATOS?", vbYesNo)
                    If DIALOGRESULT = DialogResult.Yes Then
                        GUARDIAROW = INDICESDataSet.GUARDIAS.Rows(D)
                        GUARDIAROW.TECNICO = CB_GUARD_TEC.Text
                        GUARDIAROW.TELEFONO = TXT_TELEFONO.Text
                        GUARDIAROW.AYUDANTE = CB_GUARD_AYUDANTE.Text
                        GUARDIAROW.TIPO = CB_TIPO_GUARDIA.Text
                        GUARDIAROW.FECHA_INGRESADO = Today.ToShortDateString
                        GUARDIAROW.INGRESADO = FULLNOMBRE
                        GUARDIAROW.FECHA = DT_GUARDIA_INI.Value.AddDays(D).ToShortDateString
                        GUARDIASTableAdapter.Update(INDICESDataSet.GUARDIAS)
                    Else
                        Continue For
                    End If
                Else
                    Dim NEWGUARDIA As INDICESDataSet.GUARDIASRow
                    NEWGUARDIA = INDICESDataSet.GUARDIAS.NewGUARDIASRow
                    NEWGUARDIA.TECNICO = CB_GUARD_TEC.Text
                    NEWGUARDIA.TELEFONO = TXT_TELEFONO.Text
                    NEWGUARDIA.AYUDANTE = CB_GUARD_AYUDANTE.Text
                    NEWGUARDIA.TIPO = CB_TIPO_GUARDIA.Text
                    NEWGUARDIA.FECHA_INGRESADO = Today.ToShortDateString
                    NEWGUARDIA.INGRESADO = FULLNOMBRE
                    NEWGUARDIA.FECHA = DT_GUARDIA_INI.Value.AddDays(D).ToShortDateString
                    INDICESDataSet.GUARDIAS.AddGUARDIASRow(NEWGUARDIA)
                    GUARDIASTableAdapter.Update(NEWGUARDIA)
                End If
            Next
            GUARDIASTableAdapter.FillByDESDE(INDICESDataSet.GUARDIAS, Today.ToShortDateString)
            Cursor = Cursors.Default
            MsgBox("REGISTRO INGRESADO")
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("ERROR " & ex.Message)
        End Try

    End Sub
    Private Sub GUARDIASDataGridView_Click(sender As Object, e As EventArgs) Handles GUARDIASDataGridView.Click
        If GUARDIASDataGridView.Rows.Count < 0 Then
            CB_GUARD_TEC.Text = GUARDIASDataGridView.CurrentRow.Cells(1).Value
            CB_GUARD_AYUDANTE.Text = GUARDIASDataGridView.CurrentRow.Cells(2).Value
            CB_TIPO_GUARDIA.Text = GUARDIASDataGridView.CurrentRow.Cells(0).Value
            DT_GUARDIA_INI.Value = GUARDIASDataGridView.CurrentRow.Cells(3).Value
            DT_GUARDIA_FIN.Value = GUARDIASDataGridView.CurrentRow.Cells(3).Value
        End If
    End Sub
    Private Sub BTN_MOD_GUARDIA_Click(sender As Object, e As EventArgs) Handles BTN_MOD_GUARDIA.Click
        Try
            Dim MODGUARDIA As INDICESDataSet.GUARDIASRow
            MODGUARDIA = INDICESDataSet.GUARDIAS.Rows(GUARDIASBindingSource.Position)
            MODGUARDIA.TIPO = CB_TIPO_GUARDIA.Text
            MODGUARDIA.TECNICO = CB_GUARD_TEC.Text
            MODGUARDIA.AYUDANTE = CB_GUARD_AYUDANTE.Text
            MODGUARDIA.FECHA = GUARDIASDataGridView.CurrentRow.Cells(3).Value
            GUARDIASTableAdapter.Update(MODGUARDIA)
            MsgBox("REGISTRO ACTUALIZADO")
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
        End Try
    End Sub
    Private Sub BTN_SALIR_GUARDIA_Click(sender As Object, e As EventArgs) Handles BTN_SALIR_GUARDIA.Click
        P_LATERAL.Visible = True
        P_GUARDIAS.Visible = False
    End Sub
    Private Sub BTN_BORRAR_GUARDIA_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR_GUARDIA.Click
        Try
            GUARDIAROW = INDICESDataSet.GUARDIAS.Rows(GUARDIASDataGridView.CurrentRow.Index)
            GUARDIAROW.Delete()
            GUARDIASTableAdapter.Update(GUARDIAROW)
            MsgBox("REGISTRO BORRADO")
        Catch ex As Exception
            MsgBox("EROR " & ex.Message)
        End Try

    End Sub
    Private Sub CB_GUARD_TEC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GUARD_TEC.SelectedIndexChanged
        If CB_GUARD_TEC.Text <> "" Then
            TECNICOSTableAdapter.FillByNOMBRE(ANALISIS_AGDataSet.TECNICOS, CB_GUARD_TEC.Text)
            If ANALISIS_AGDataSet.TECNICOS.Rows.Count > 0 Then
                If IsDBNull(ANALISIS_AGDataSet.TECNICOS.Rows(0).Item("TELEFONO")) = False Then
                    TXT_GUARD_TELEFONO.Text = ANALISIS_AGDataSet.TECNICOS.Rows(0).Item("TELEFONO")
                Else
                    TXT_GUARD_TELEFONO.Text = "NO TIENE"
                End If
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        RECALCULAR_MAPA_AGENDA()
        Cursor = Cursors.Default
    End Sub
    Private Sub BTN_GUARDAR_REASIGNAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR_REASIGNAR.Click
        If CB_TECNICO_IN.Text = "" Then
            MsgBox("COMPLETE TECNICO A MOVER")
            Exit Sub
        End If
        If CB_SECTOR_OUT.Text = "" Then
            MsgBox("COMPLETE SECTOR A SUMAR CAPACIDAD")
            Exit Sub
        End If
        If CB_RECURSO_OUT.Text = "" Then
            MsgBox("COMPLETE RECURSO A SUMAR CAPACIDAD")
            Exit Sub
        End If
        If CB_PRIORIDAD_OUT.Text = "" Then
            MsgBox("COMPLETE PRIORIDAD A SUMAR CAPACIDAD")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        REG_AUSENCIASTableAdapter.FillByFECHAYTEC(ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI, CB_TECNICO_IN.Text)
        REGAUSENCIASRow = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0)

        'MODIFICA CAPACIDAD DE AGENDA
        ' CAPACIDAXDIATableAdapter.FillByFECHA(ANALISIS_AGDataSet.CAPACIDAXDIA, FECHAINI)
        'CAPACIDADDIARow = ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
        'CAPACIDADDIARow.FECHA = FECHAINI
        ''DESCUENTA CAPACIDAD
        'Select Case REGAUSENCIASRow.SECTOR
        '    Case "RED/MDU"
        '        Select Case REGAUSENCIASRow.RECURSO
        '            Case "PLANIFICACION TECNICA", "PT"
        '                Select Case REGAUSENCIASRow.PRIORIDAD
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_ALT_TEC_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_MED_TEC_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_BAJ_TEC_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                End Select
        '            Case "SUPERVISION", "SU"
        '                Select Case REGAUSENCIASRow.PRIORIDAD
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_ALT_TEC_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_MED_TEC_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_TEC -= 1
        '                        CAPACIDADDIARow.MIN_BAJ_TEC_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                End Select
        '            Case "CORRECTIVO", "CO"
        '                CAPACIDADDIARow.CANT_TEC -= 1
        '                CAPACIDADDIARow.MIN_ALT_TEC_CO -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '        End Select
        '    Case "CUAD MDU", "CUAD RED"
        '        Select Case REGAUSENCIASRow.RECURSO
        '            Case "PLANIFICACION TECNICA", "PT"
        '                Select Case REGAUSENCIASRow.PRIORIDAD
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_PT -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                End Select
        '            Case "SUPERVISION", "SU"
        '                Select Case REGAUSENCIASRow.PRIORIDAD
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_SU -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '                End Select
        '            Case "CORRECTIVO", "CO"
        '                CAPACIDADDIARow.CANT_CUA -= 1
        '                CAPACIDADDIARow.MIN_ALT_CUA_CO -= ((REGAUSENCIASRow.HORAS * 60) - 90)
        '        End Select
        'End Select
        ''SUMA CAPACIDAD
        'Select Case CB_SECTOR_OUT.Text
        '    Case "RED/MDU"
        '        Select Case CB_RECURSO_OUT.Text
        '            Case "PLANIFICACION TECNICA", "PT"
        '                Select Case CB_PRIORIDAD_OUT.Text
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_TEC += 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                End Select
        '            Case "SUPERVISION", "SU"
        '                Select Case CB_PRIORIDAD_OUT.Text
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_CUA -= 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                End Select
        '            Case "CORRECTIVO", "CO"
        '                CAPACIDADDIARow.CANT_TEC += 1
        '                CAPACIDADDIARow.MIN_ALT_TEC_CO += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '        End Select
        '    Case "CUAD RED", "CUAD MDU"
        '        Select Case CB_RECURSO_OUT.Text
        '            Case "PT"
        '                Select Case CB_PRIORIDAD_OUT.Text
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_PT += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                End Select
        '            Case "SU"
        '                Select Case CB_PRIORIDAD_OUT.Text
        '                    Case "ALTA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_ALT_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "MEDIA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_MED_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                    Case "BAJA"
        '                        CAPACIDADDIARow.CANT_CUA += 1
        '                        CAPACIDADDIARow.MIN_BAJ_CUA_SU += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '                End Select
        '            Case "CO"
        '                CAPACIDADDIARow.CANT_CUA += 1
        '                CAPACIDADDIARow.MIN_ALT_CUA_CO += ((REGAUSENCIASRow.HORAS * 60) + 90)
        '        End Select
        'End Select

        'MODIFICA PERFIL DEL TECNICO PARA EL DIA
        REGAUSENCIASRow.SECTOR = CB_SECTOR_OUT.Text
        REGAUSENCIASRow.RECURSO = CB_RECURSO_OUT.Text
        REGAUSENCIASRow.PRIORIDAD = CB_PRIORIDAD_OUT.Text
        REG_AUSENCIASTableAdapter.Update(REGAUSENCIASRow)
        '   CAPACIDAXDIATableAdapter.Update(CAPACIDADDIARow)
        GENERAR_AGENDA(FECHAINI.ToShortDateString, FECHAINI.ToShortDateString)
        CARGAR_CAMPOS_ASIGNADOS()
        Cursor = Cursors.Default
    End Sub
    Private Sub BTN_PROCESAMIENTO_Click(sender As Object, e As EventArgs) Handles BTN_PROCESAMIENTO.Click
        P_LATERAL.Visible = False
        If P_PROCESAMIENTO.Visible Then
            P_PROCESAMIENTO.BringToFront()
        Else
            ACCION_AGENDA = "CAP_TECNICA"
            P_PROCESAMIENTO.Visible = True
            P_PROCESAMIENTO.BringToFront()
            BTN_CERRAR_PROCESAMIENTO.Visible = True
        End If
    End Sub
    Private Sub BTN_CERRAR_PROCESAMIENTO_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR_PROCESAMIENTO.Click
        P_PROCESAMIENTO.Visible = False
        BTN_CERRAR_PROCESAMIENTO.Visible = False
        P_LATERAL.Visible = True
        ACCION_AGENDA = "VER AGENDA"
    End Sub
    Private Sub CB_TECNICO_IN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TECNICO_IN.SelectedIndexChanged
        REG_AUSENCIASTableAdapter.FillByFECHAYTEC(ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI, CB_TECNICO_IN.Text)
        If ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count > 0 Then
            RECURS_TEC.Text = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0).Item("RECURSO")
            SECTOR_TEC.Text = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0).Item("SECTOR")
            PRIOR_TEC.Text = ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0).Item("PRIORIDAD")
        End If
    End Sub
    Private Sub BOT_CALCULATOTDIA_Click(sender As Object, e As EventArgs) Handles BOT_CALCULATOTDIA.Click
        RESUMEN_DIARIO()
    End Sub
    Private Sub BOT_PROCESAR_Click_1(sender As Object, e As EventArgs) Handles BOT_PROCESAR.Click
        PROCESAR()
    End Sub
    Private Sub DGV_TEC_ACTIVOS_Click(sender As Object, e As EventArgs) Handles DGV_TEC_ACTIVOS.Click
        BTN_EDITAR_AUSENCIA_ACTIVO.Visible = True
    End Sub
    Private Sub BTN_AUSENCIA_NORMAL_Click(sender As Object, e As EventArgs) Handles BTN_AUSENCIA_NORMAL.Click
        Cursor = Cursors.WaitCursor
        REG_AUSENCIASTableAdapter.FillByFECHAYTEC(ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI, CB_TECNICO.Text)
        If ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count > 0 Then
            ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0).Delete()
            REG_AUSENCIASTableAdapter.Update(ANALISIS_AGDataSet.REG_AUSENCIAS)
            GENERAR_AGENDA(FECHAINI.ToShortDateString, FECHAINI.ToShortDateString)
            REG_AUSENCIASTableAdapter.FillByFECHAyPRESENCIA(AnalisiS_AGDataSet1.REG_AUSENCIAS, FECHAINI)
            REG_AUSENCIASTableAdapter.FillByAUSENCIADIA(AnalisiS_AGDataSet2.REG_AUSENCIAS, FECHAINI, "NO")
            P_AUSENCIA.Visible = False
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BTN_CARGAR_eXCEL_Click(sender As Object, e As EventArgs) Handles BTN_CARGAR_eXCEL.Click
        IMPORTAR_ESIR()
    End Sub
End Class