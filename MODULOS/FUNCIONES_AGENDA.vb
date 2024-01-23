Imports System.Runtime.InteropServices.ComTypes
Imports System.IO
Imports Microsoft.Office.Interop
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.Support.Extensions
Imports System.Threading.Thread

Module FUNCIONES_AGENDA
    Public driver As IWebDriver
    Public SALIR As Boolean = False
    Dim FECHATRATADA As String
    Dim FECHATAREA1 As Date
    Dim FECHATAREA2 As Date
    Dim ORDINALGRAB As Double
    Dim HORASTRAB As String
    Dim MINTRAB As String
    Dim NROORDINAL As Integer
    Dim NROORDINT As Integer
    Dim X As Integer
    Dim MAX_ID As Integer

    Dim CANT_PROC As Integer
    Dim CANT_ORDINGRE As Integer
    Dim CANT_ORDEDITA As Integer
    Dim CANT_TAREASINGRE As Integer
    Dim CANT_OBSINGRE As Integer

    Dim CANT_TEC_ALT_TEOR_PT(7) As Integer
    Dim CANT_TEC_MED_TEOR_PT(7) As Integer
    Dim CANT_TEC_BAJ_TEOR_PT(7) As Integer
    Dim CANT_TEC_ALT_TEOR_SU(7) As Integer
    Dim CANT_TEC_MED_TEOR_SU(7) As Integer
    Dim CANT_TEC_BAJ_TEOR_SU(7) As Integer
    Dim CANT_TEC_TEOR_CO(7) As Integer

    Dim CANT_CUAD_ALT_TEOR_PT(7) As Integer
    Dim CANT_CUAD_MED_TEOR_PT(7) As Integer
    Dim CANT_CUAD_BAJ_TEOR_PT(7) As Integer
    Dim CANT_CUAD_ALT_TEOR_SU(7) As Integer
    Dim CANT_CUAD_MED_TEOR_SU(7) As Integer
    Dim CANT_CUAD_BAJ_TEOR_SU(7) As Integer
    Dim CANT_CUAD_TEOR_CO(7) As Integer

    Dim ENCONTRE_ORDINAL As String
    Dim ORDENINTERNA As Integer
    Dim STATUSANTERIOR As String
    Dim GENERADORGEST As String
    Dim TIPOGESTION As String
    Dim TAREA_DESC As String
    Dim PAINT_TEC As Graphics

    Dim TIEMP_TARPREV As Double
    Dim TIEMP_TARREAL As Double

    Dim URLESIR As String = "wsinterno.equital.com/ords/f?p=101:LOGIN_DESKTOP"

    ReadOnly USER As String = "P101_USERNAME"
    ReadOnly NOMBRE As String = "DGEYMONAT"
    ReadOnly PASS As String = "P101_PASSWORD"
    ReadOnly PASSWORD As String = "dgeymonat2020"
    ReadOnly BTN_INGRESAR_LOGIN = "P101_LOGIN"
    ReadOnly CB_TIPO_FECHA As String = "P127_TPOFCH"
    ReadOnly CB_GRUPO_PERMISOR As String = "P127_GRPPERCOD"
    ReadOnly FECHA_DESDE As String = "P127_FCHDESDE"
    ReadOnly FECHA_HASTA As String = "P127_FCHHASTA"
    ReadOnly BTN_ACTIONS As String = "apexir_ACTIONSMENUROOT"

    Dim BDTAREASACTRow As ANALISIS_AGDataSet.BD_TAREASRow
    Dim BDTAREASPOSTRow As ANALISIS_AGDataSet.BD_TAREASRow
    Dim ORDENACTRow As ORDENESDataSet.ORDENESRow
    Dim ORDENESRow As ORDENESDataSet.ORDENESRow
    Dim TOTALxDIARow As ANALISIS_AGDataSet.TOTAL_XDIARow
    Dim CAUSASRow As ORDENESDataSet.CAUSASRow
    Dim MISMOORDINAL As Boolean
    Dim REG_DIARIORow As DataRow
    Dim CAPACIDADRow As DataRow
    Dim ORDINALRow As ORDENESDataSet.ORDENESRow
    Dim DISTAGENDARow As DataRow
    Dim TECNICOsRow As DataRow

    Dim MAPA_AGENDARow As ANALISIS_AGDataSet.MAPA_AGENDARow
    Dim TECNICORow As ANALISIS_AGDataSet.TECNICOSRow
    Dim NEWTAREARow As ORDENESDataSet.TAREASRow
    Dim TAREAS_NEWROW As ANALISIS_AGDataSet.BD_TAREASRow
    Dim NewObservacionRow As ORDENESDataSet.OBESERVACIONESRow
    Dim NewOrdinalRow As ORDENESDataSet.ORDENESRow
    Dim NewMENSAJERow As ORDENESDataSet.MENSAJERIARow
    Dim NewHISTORICORow As ORDENESDataSet.HISTORICORow
    Dim ELIMINARow As ANALISIS_AGDataSet.TOTAL_XDIARow
    Dim NewTotalxDiaRow As ANALISIS_AGDataSet.TOTAL_XDIARow
    Dim TECNICOS As ANALISIS_AGDataSet.REG_AUSENCIASRow

    Dim CANT(10, 10) As Integer
    Dim PREV(10, 10) As Double
    Dim REAL(10, 10) As Double
    Dim TIEM(10, 10) As Double

    Dim SECTOR(10) As String
    Dim CAUSA(20) As String
    Dim TIPO(3) As String
    Dim TRABSTD_REAL(20) As String
    Dim TIEM_REAL(20) As String
    Dim RELREAL_STD(20) As String
    Dim RELTIEM_REAL(20) As String
    Dim TRABSTD_PREV(20) As String
    Public ACCION As String
    Public CRTL_BTN As Control
    Dim DIASEMCALC As Integer


    Dim CANT_PROCESADOS As Integer
    Dim CANT_ORDING As Integer
    Dim CANT_ORDEDIT As Integer
    Dim CANT_TAREASING As Integer
    Dim CANT_OBSING As Integer

    Dim TRASCORR_RED As Double
    Dim TRABCORR_RED As Double
    Dim TRASCORR_MDU As Double
    Dim TRABCORR_MDU As Double
    Dim IND1CORR As String
    Dim IND2CORR As String
    Dim UTTOTAL_CORR As Double

    Dim TRASPREV_RED As Double
    Dim TRABPREV_RED As Double
    Dim TRASPREV_MDU As Double
    Dim TRABPREV_MDU As Double
    Dim IND1PREV As String
    Dim IND2PREV As String
    Dim UTOTAL_PREV As Double

    Dim TRASPRED_RED As Double
    Dim TRABPRED_RED As Double
    Dim TRASPRED_MDU As Double
    Dim TRABPRED_MDU As Double
    Dim IND1PRED As String
    Dim IND2PRED As String
    Dim UTTOTAL_PRED As Double

    Dim TRASOBRA_RED As Double
    Dim TRABOBRA_RED As Double
    Dim TRASOBRA_MDU As Double
    Dim TRABOBRA_MDU As Double
    Dim IND1OBRAS As String
    Dim IND2OBRAS As String
    Dim UTTOTAL_OBRAS As Double

    Dim TOTTRAS_RED As Double
    Dim TOTTRAB_RED As Double
    Dim TOTTRAS_MDU As Double
    Dim TOTTRAB_MDU As Double
    Dim TOTGEN_RED As Double
    Dim TOTGEN_MDU As Double
    Dim UTOTAL_GEN As Double

    Dim TRASDESC_RED As Double
    Dim TRABDESC_RED As Double
    Dim TRASDESC_MDU As Double
    Dim TRABDESC_MDU As Double
    Dim IND1DESC As String
    Dim IND2DESC As String
    Dim UTTOTAL_DESC As Double

    Dim IND1GEN As String
    Dim IND2GEN As String
    Dim PORCCORR As String
    Dim PORCPREV As String
    Dim PORCPRED As String
    Dim PORCOBRAS As String
    Dim PORCDESC As String
    Dim PORCRED_GEN As String
    Dim PORCMDU_GEN As String

    Dim CAN_TEC As Double
    Dim CANT_UTREAL As Double
    Dim UT_PERD As Double
    Dim UT_DISPONIBLES As Double
    Dim UT_UTILIZADAS As Double
    Dim OCUPACION As String


    Dim BORRAR As New SolidBrush(Color.White)
    Dim LAPIZ_GRAY As New Pen(Color.DarkGray, 1)
    Dim Lapiz_ROJO As New Pen(Color.Red, 3)
    Dim Lapiz_VERDE As New Pen(Color.Green, 10)
    Dim Lapiz_Negro As New Pen(Color.Black, 1)
    Dim LAPIZ_AGUJA As New Pen(Color.Black, 4)
    Dim LAPIZ_AGUJA_SOMBRA As New Pen(Color.FromArgb(64, 64, 64), 4)
    Dim Relleno_GRAY As New SolidBrush(Color.DarkGray)
    Dim Relleno_GREEN As New SolidBrush(Color.Green)
    Dim Relleno_YELLOW As New SolidBrush(Color.DarkGoldenrod)
    Dim Relleno_ORANGE As New SolidBrush(Color.OrangeRed)
    Dim Relleno_RED As New SolidBrush(Color.Red)
    Dim Relleno_NEGRO As New SolidBrush(Color.Black)
    Dim RELLENO_SOMBRA As New SolidBrush(Color.FromArgb(64, 64, 64))
    Dim FUENTE As New Font("ARIAL", 10, FontStyle.Bold)
    Dim FUENTE_CHICA As New Font("ARIAL", 7)
    Dim puntoX As Integer
    Dim puntoY As Integer
    Public Sub LOAD_P_CONTROLTECNICO()
        '     FORMAGE.BORRA_BOTONES()


        FORMAGE.REG_AUSENCIASTableAdapter.FillByFECHAyPRESENCIA(FORMAGE.AnalisiS_AGDataSet1.REG_AUSENCIAS, FECHAINI)
        FORMAGE.REG_AUSENCIASTableAdapter.FillByAUSENCIADIA(FORMAGE.AnalisiS_AGDataSet2.REG_AUSENCIAS, FECHAINI, "NO")
        'CARGA LOS TECNICOS EN EL COMBOBOX
        FORMAGE.TECNICOSTableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.TECNICOS)
        FORMAGE.CB_TECNICO.Items.Clear()
        FORMAGE.CB_TECNICO.Items.Add("")
        For X = 0 To FORMAGE.ANALISIS_AGDataSet.TECNICOS.Rows.Count - 1
            FORMAGE.CB_TECNICO.Items.Add(FORMAGE.ANALISIS_AGDataSet.TECNICOS.Rows(X).Item("NOMBRE"))
        Next
        FORMAGE.CB_MOTIVO_AUSENCIA.Items.Clear()
        FORMAGE.CB_MOTIVO_AUSENCIA.Items.Add("")
        FORMAGE.AUSENCIASTableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.AUSENCIAS)
        For X = 0 To FORMAGE.ANALISIS_AGDataSet.AUSENCIAS.Rows.Count - 1
            FORMAGE.CB_MOTIVO_AUSENCIA.Items.Add(FORMAGE.ANALISIS_AGDataSet.AUSENCIAS.Rows(X).Item("DESCRIPCION"))
        Next
        CARGA_METEOROLOGIA()
    End Sub
    Public Sub ACTUALIZAR_CAMBIODIA()
        If FORMAGE.P_CONTROLTECNICO.Visible Then
            LOAD_P_CONTROLTECNICO()
        End If
        If FORMAGE.P_DISTRIBUCIONTEC.Visible Then
            CARGA_DISTRIBUCIONAGENDA()
        End If
        If FORMAGE.P_REASIGNAR.Visible Then
            CARGAR_CAMPOS_ASIGNADOS()
        End If
        If FORMAGE.P_PROCESAMIENTO.Visible Then
            VERIFICA_PROCESOS()
        End If
    End Sub
    Public Sub CARGAR_CAMPOS_ASIGNADOS()
        FORMAGE.REG_AUSENCIASTableAdapter.FillByFECHAyPRESENCIA(FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI)
        FORMAGE.CB_TECNICO_IN.Items.Clear()
        FORMAGE.CB_TECNICO_IN.Items.Add("")
        For X = 0 To FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count - 1
            FORMAGE.CB_TECNICO_IN.Items.Add(FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(X).Item("NOMBRETEC"))
        Next
        FORMAGE.TXT_TEC_ALT_PT.Text = 0
        FORMAGE.TXT_TEC_MED_PT.Text = 0
        FORMAGE.TXT_TEC_BAJ_PT.Text = 0
        FORMAGE.TXT_TEC_ALT_SU.Text = 0
        FORMAGE.TXT_TEC_MED_SU.Text = 0
        FORMAGE.TXT_TEC_BAJ_SU.Text = 0
        FORMAGE.TXT_TEC_ALT_CO.Text = 0
        FORMAGE.TXT_TEC_TOT_CO.Text = 0
        FORMAGE.TXT_TEC_TOT_PT.Text = 0
        FORMAGE.TXT_TEC_TOT_SU.Text = 0

        FORMAGE.TXT_CUAD_ALT_PT.Text = 0
        FORMAGE.TXT_CUAD_MED_PT.Text = 0
        FORMAGE.TXT_CUAD_BAJ_PT.Text = 0
        FORMAGE.TXT_CUAD_ALT_SU.Text = 0
        FORMAGE.TXT_CUAD_MED_SU.Text = 0
        FORMAGE.TXT_CUAD_BAJ_SU.Text = 0
        FORMAGE.TXT_CUAD_ALT_CO.Text = 0
        FORMAGE.TXT_CUAD_TOT_CO.Text = 0
        FORMAGE.TXT_CUAD_TOT_PT.Text = 0
        FORMAGE.TXT_CUAD_TOT_SU.Text = 0

        FORMAGE.REG_AUSENCIASTableAdapter.FillByFECHAyPRESENCIA(FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI)
        If FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count > 0 Then
            For X = 0 To FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count - 1
                TECNICOsRow = FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(X)

                Select Case TECNICOsRow("SECTOR")
                    Case "RED/MDU"
                        Select Case TECNICOsRow("RECURSO")
                            Case "PLANIFICACION TECNICA", "PT"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_TEC_ALT_PT.Text += 1
                                    Case "MEDIA"
                                        FORMAGE.TXT_TEC_MED_PT.Text += 1
                                    Case "BAJA"
                                        FORMAGE.TXT_TEC_BAJ_PT.Text += 1
                                End Select
                            Case "SUPERVISION", "SU"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_TEC_ALT_SU.Text += 1
                                    Case "MEDIA"
                                        FORMAGE.TXT_TEC_MED_SU.Text += 1
                                    Case "BAJA"
                                        FORMAGE.TXT_TEC_BAJ_SU.Text += 1
                                End Select
                            Case "CORRECTIVO", "CO"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_TEC_ALT_CO.Text += 1
                                End Select
                        End Select
                    Case "CUAD MDU", "CUAD RED"
                        Select Case TECNICOsRow("RECURSO")
                            Case "PLANIFICACION TECNICA", "PT"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_CUAD_ALT_PT.Text += 1
                                    Case "MEDIA"
                                        FORMAGE.TXT_CUAD_MED_PT.Text += 1
                                    Case "BAJA"
                                        FORMAGE.TXT_CUAD_BAJ_PT.Text += 1
                                End Select
                            Case "SUPERVISION", "SU"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_CUAD_ALT_SU.Text += 1
                                    Case "MEDIA"
                                        FORMAGE.TXT_CUAD_MED_SU.Text += 1
                                    Case "BAJA"
                                        FORMAGE.TXT_CUAD_BAJ_SU.Text += 1
                                End Select
                            Case "CORRECTIVO", "CO"
                                Select Case TECNICOsRow("PRIORIDAD")
                                    Case "ALTA"
                                        FORMAGE.TXT_CUAD_ALT_CO.Text += 1
                                End Select
                        End Select
                End Select
            Next
            FORMAGE.TXT_TEC_TOT_CO.Text = FORMAGE.TXT_TEC_ALT_CO.Text
            FORMAGE.TXT_TEC_TOT_PT.Text = CInt(FORMAGE.TXT_TEC_ALT_PT.Text) + CInt(FORMAGE.TXT_TEC_MED_PT.Text) + CInt(FORMAGE.TXT_TEC_BAJ_PT.Text)
            FORMAGE.TXT_TEC_TOT_SU.Text = CInt(FORMAGE.TXT_TEC_ALT_SU.Text) + CInt(FORMAGE.TXT_TEC_MED_SU.Text) + CInt(FORMAGE.TXT_TEC_BAJ_SU.Text)

            FORMAGE.TXT_CUAD_TOT_CO.Text = FORMAGE.TXT_CUAD_ALT_CO.Text
            FORMAGE.TXT_CUAD_TOT_PT.Text = CInt(FORMAGE.TXT_CUAD_ALT_PT.Text) + CInt(FORMAGE.TXT_CUAD_MED_PT.Text) + CInt(FORMAGE.TXT_CUAD_BAJ_PT.Text)
            FORMAGE.TXT_CUAD_TOT_SU.Text = CInt(FORMAGE.TXT_CUAD_ALT_SU.Text) + CInt(FORMAGE.TXT_CUAD_MED_SU.Text) + CInt(FORMAGE.TXT_CUAD_BAJ_SU.Text)
        End If

    End Sub
    Public Sub MODIFICAR_AGENDA(ByVal FECHA As Date, ByVal SECTOROPE As String, ByVal RECURSO As String, ByVal MINTEC As Integer, ByVal PRIORIDAD As String)
        FORMAGE.CAPACIDAXDIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.CAPACIDAXDIA, FECHA)
        CAPACIDADRow = FORMAGE.ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
        Select Case SECTOROPE
            Case "RED/MDU"
                CAPACIDADRow("MIN_TEC") -= MINTEC
                Select Case RECURSO
                    Case "PLANIFICACION TECNICA", "PT"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_TEC_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_TEC_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_TEC_PT") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_TEC_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_TEC_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_TEC_PT") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_TEC_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_TEC_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_TEC_PT") = 0
                                End If
                        End Select
                    Case "SUPERVISION", "SU"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_TEC_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_TEC_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_TEC_SU") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_TEC_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_TEC_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_TEC_SU") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_TEC_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_TEC_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_TEC_SU") = 0
                                End If
                        End Select
                    Case "CORRECTIVO", "CO"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_TEC_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_TEC_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_TEC_CO") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_TEC_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_TEC_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_TEC_CO") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_TEC_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_TEC_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_TEC_CO") = 0
                                End If
                        End Select
                End Select
            Case "CUAD RED"
                CAPACIDADRow("MIN_CUA") -= MINTEC
                Select Case RECURSO
                    Case "PLANIFICACION TECNICA", "PT"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_CUA_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_CUA_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_CUA_PT") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_CUA_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_CUA_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_CUA_PT") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_CUA_PT") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_CUA_PT") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_CUA_PT") = 0
                                End If
                        End Select
                    Case "SUPERVISION", "SU"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_CUA_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_CUA_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_CUA_SU") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_CUA_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_CUA_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_CUA_SU") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_CUA_SU") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_CUA_SU") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_CUA_SU") = 0
                                End If
                        End Select
                    Case "CORRECTIVO", "CO"
                        Select Case PRIORIDAD
                            Case "BAJA"
                                If CAPACIDADRow("MIN_BAJ_CUA_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_BAJ_CUA_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_BAJ_CUA_CO") = 0
                                End If
                            Case "MEDIA"
                                If CAPACIDADRow("MIN_MED_CUA_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_MED_CUA_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_MED_CUA_CO") = 0
                                End If
                            Case "ALTA"
                                If CAPACIDADRow("MIN_ALT_CUA_CO") - MINTEC >= 0 Then
                                    CAPACIDADRow("MIN_ALT_CUA_CO") -= MINTEC
                                Else
                                    CAPACIDADRow("MIN_ALT_CUA_CO") = 0
                                End If
                        End Select
                End Select
        End Select
        FORMAGE.CAPACIDAXDIATableAdapter.Update(CAPACIDADRow)
    End Sub
    Public Sub CARGA_METEOROLOGIA()
        FORMAGE.METEOROLOGIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.METEOROLOGIA, FECHAINI)
        FORMAGE.METEOROLOGIAMOT.Text = ""
        FORMAGE.DESCRIPCIONMET.Text = ""
        FORMAGE.DESDEMET.Text = ""
        FORMAGE.HASTAMET.Text = ""
        FORMAGE.CATEGORIAMET.Text = ""
    End Sub
    Public Sub LOAD_PARAMETROS()
        FORMAGE.MAPA_AGENDATableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA)
        FORMAGE.DISTRIBUCION_AGENDATableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.DISTRIBUCION_AGENDA)
        FORMAGE.CAPACIDAXDIATableAdapter.FillByDESDEFECHA(FORMAGE.ANALISIS_AGDataSet.CAPACIDAXDIA, Today.ToShortDateString)
    End Sub
    Public Sub CARGA_DISTRIBUCIONAGENDA()
        FORMAGE.DISTRIBUCION_AGENDATableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.DISTRIBUCION_AGENDA)
        For I = 0 To FORMAGE.ANALISIS_AGDataSet.DISTRIBUCION_AGENDA.Rows.Count - 1
            DISTAGENDARow = FORMAGE.ANALISIS_AGDataSet.DISTRIBUCION_AGENDA.Rows(I)
            If FECHAINI.DayOfWeek = 0 Then
                DIASEMCALC = 7
            Else
                DIASEMCALC = FECHAINI.DayOfWeek
            End If
            Select Case DISTAGENDARow("SECTOR")
                Case "PT"
                    Select Case DISTAGENDARow("RECURSO")
                        Case "Tecnicos"
                            FORMAGE.PLA_ALT_TEC.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.PLA_MED_TEC.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.PLA_BAJ_TEC.Text = DISTAGENDARow(DIASEMCALC & "B")
                        Case "Cuadrilla"
                            FORMAGE.PLA_ALT_CUA.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.PLA_MED_CUA.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.PLA_BAJ_CUA.Text = DISTAGENDARow(DIASEMCALC & "B")
                    End Select

                Case "Supervisores"
                    Select Case DISTAGENDARow("RECURSO")
                        Case "Tecnicos"
                            FORMAGE.SUP_ALT_TEC.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.SUP_MED_TEC.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.SUP_BAJ_TEC.Text = DISTAGENDARow(DIASEMCALC & "B")
                        Case "Cuadrilla"
                            FORMAGE.SUP_ALT_CUA.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.SUP_MED_CUA.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.SUP_BAJ_CUA.Text = DISTAGENDARow(DIASEMCALC & "B")
                    End Select

                Case "Correctivos"
                    Select Case DISTAGENDARow("RECURSO")
                        Case "Tecnicos"
                            FORMAGE.COR_ALT_TEC.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.COR_MED_TEC.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.COR_BAJ_TEC.Text = DISTAGENDARow(DIASEMCALC & "B")
                        Case "Cuadrilla"
                            FORMAGE.COR_ALT_CUA.Text = DISTAGENDARow(DIASEMCALC & "A")
                            FORMAGE.COR_MED_CUA.Text = DISTAGENDARow(DIASEMCALC & "M")
                            FORMAGE.COR_BAJ_CUA.Text = DISTAGENDARow(DIASEMCALC & "B")
                    End Select
            End Select
        Next
    End Sub
    Private Sub ELIMINA_MAPA()
        FORMAGE.MAPA_AGENDATableAdapter.Fill(FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA)
        For X = 0 To FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA.Rows.Count - 1
            FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA.Rows(X).Delete()
        Next
        FORMAGE.MAPA_AGENDATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA)
    End Sub
    Public Sub RECALCULAR_MAPA_AGENDA()
        ELIMINA_MAPA()

        For X = 0 To 7
            CANT_TEC_ALT_TEOR_PT(X) = 0
            CANT_TEC_MED_TEOR_PT(X) = 0
            CANT_TEC_BAJ_TEOR_PT(X) = 0
            CANT_TEC_ALT_TEOR_SU(X) = 0
            CANT_TEC_MED_TEOR_SU(X) = 0
            CANT_TEC_BAJ_TEOR_SU(X) = 0
            CANT_TEC_TEOR_CO(X) = 0

            CANT_CUAD_ALT_TEOR_PT(X) = 0
            CANT_CUAD_MED_TEOR_PT(X) = 0
            CANT_CUAD_BAJ_TEOR_PT(X) = 0
            CANT_CUAD_ALT_TEOR_SU(X) = 0
            CANT_CUAD_MED_TEOR_SU(X) = 0
            CANT_CUAD_BAJ_TEOR_SU(X) = 0
            CANT_CUAD_TEOR_CO(X) = 0
        Next
        FORMAGE.TECNICOSTableAdapter.FillByDACAPACIDAD(FORMAGE.ANALISIS_AGDataSet.TECNICOS)
        For X = 0 To FORMAGE.ANALISIS_AGDataSet.TECNICOS.Rows.Count - 1
            TECNICORow = FORMAGE.ANALISIS_AGDataSet.TECNICOS.Rows(X)
            For D = 1 To 7
                Select Case D
                    Case 1
                        If TECNICORow.LUN_ENT <> "--" Then MAPA(1)
                    Case 2
                        If TECNICORow.MAR_ENT <> "--" Then MAPA(2)
                    Case 3
                        If TECNICORow.MIE_ENT <> "--" Then MAPA(3)
                    Case 4
                        If TECNICORow.JUE_ENT <> "--" Then MAPA(4)
                    Case 5
                        If TECNICORow.VIE_ENT <> "--" Then MAPA(5)
                    Case 6
                        If TECNICORow.SAB_ENT <> "--" Then MAPA(6)
                    Case 7
                        If TECNICORow.DOM_ENT <> "--" Then MAPA(7)
                End Select
            Next
        Next

        For I = 0 To 5
            MAPA_AGENDARow = FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA.NewMAPA_AGENDARow
            MAPA_AGENDARow.FECHA_VIGENCIA = Today.ToShortDateString
            Select Case I
                Case 0
                    MAPA_AGENDARow.SECTOR = "PT"
                    MAPA_AGENDARow.RECURSOS = "TECNICO"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_TEC_ALT_TEOR_PT(X)
                        MAPA_AGENDARow(X & "M") = CANT_TEC_MED_TEOR_PT(X)
                        MAPA_AGENDARow(X & "B") = CANT_TEC_BAJ_TEOR_PT(X)
                        Select Case X
                            Case 6, 7
                                MAPA_AGENDARow(X & "A") = 0
                                MAPA_AGENDARow(X & "M") = 0
                                MAPA_AGENDARow(X & "B") = 0
                        End Select
                    Next
                Case 1
                    MAPA_AGENDARow.SECTOR = "SU"
                    MAPA_AGENDARow.RECURSOS = "TECNICO"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_TEC_ALT_TEOR_SU(X)
                        MAPA_AGENDARow(X & "M") = CANT_TEC_MED_TEOR_SU(X)
                        MAPA_AGENDARow(X & "B") = CANT_TEC_BAJ_TEOR_SU(X)
                    Next
                Case 2
                    MAPA_AGENDARow.SECTOR = "CO"
                    MAPA_AGENDARow.RECURSOS = "TECNICO"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_TEC_TEOR_CO(X)
                        If X = 6 Then
                            MAPA_AGENDARow(X & "A") = CANT_TEC_TEOR_CO(X) + CANT_TEC_ALT_TEOR_PT(X) + CANT_TEC_MED_TEOR_PT(X) + CANT_TEC_BAJ_TEOR_PT(X) + CANT_TEC_ALT_TEOR_SU(X) + CANT_TEC_MED_TEOR_SU(X) + CANT_TEC_BAJ_TEOR_SU(X)
                        End If
                    Next
                Case 3
                    MAPA_AGENDARow.SECTOR = "PT"
                    MAPA_AGENDARow.RECURSOS = "CUADRILLA"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_CUAD_ALT_TEOR_PT(X)
                        MAPA_AGENDARow(X & "M") = CANT_CUAD_MED_TEOR_PT(X)
                        MAPA_AGENDARow(X & "B") = CANT_CUAD_BAJ_TEOR_PT(X)
                        Select Case X
                            Case 6, 7
                                MAPA_AGENDARow(X & "A") = 0
                                MAPA_AGENDARow(X & "M") = 0
                                MAPA_AGENDARow(X & "B") = 0
                        End Select
                    Next
                Case 4
                    MAPA_AGENDARow.SECTOR = "SU"
                    MAPA_AGENDARow.RECURSOS = "CUADRILLA"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_CUAD_ALT_TEOR_SU(X)
                        MAPA_AGENDARow(X & "M") = CANT_CUAD_MED_TEOR_SU(X)
                        MAPA_AGENDARow(X & "B") = CANT_CUAD_BAJ_TEOR_SU(X)
                        Select Case X
                            Case 6, 7
                                MAPA_AGENDARow(X & "A") = 0
                                MAPA_AGENDARow(X & "M") = 0
                                MAPA_AGENDARow(X & "B") = 0
                        End Select
                    Next
                Case 5
                    MAPA_AGENDARow.SECTOR = "CO"
                    MAPA_AGENDARow.RECURSOS = "CUADRILLA"
                    For X = 1 To 7
                        MAPA_AGENDARow(X & "A") = CANT_CUAD_TEOR_CO(X)
                        If X = 6 Then
                            MAPA_AGENDARow(X & "A") = CANT_CUAD_TEOR_CO(X) + CANT_CUAD_ALT_TEOR_PT(X) + CANT_CUAD_MED_TEOR_PT(X) + CANT_CUAD_BAJ_TEOR_PT(X) + CANT_CUAD_ALT_TEOR_SU(X) + CANT_CUAD_MED_TEOR_SU(X) + CANT_CUAD_BAJ_TEOR_SU(X)
                        End If
                    Next
            End Select
            FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA.Rows.Add(MAPA_AGENDARow)
        Next
        FORMAGE.MAPA_AGENDATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.MAPA_AGENDA)
    End Sub
    Private Sub MAPA(DIASEMCALC As Integer)
        Select Case TECNICORow.SECTOR
            Case "RED/MDU"
                Select Case DIASEMCALC
                    Case 1
                        Select Case TECNICORow.LUN_RECURSO
                            Case "PT"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 2
                        Select Case TECNICORow.MAR_RECURSO
                            Case "PT"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 3
                        Select Case TECNICORow.MIER_RECURSO
                            Case "PT"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 4
                        Select Case TECNICORow.JUEV_RECURSO
                            Case "PT"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 5
                        Select Case TECNICORow.VIER_RECURSO
                            Case "PT"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 6
                        Select Case TECNICORow.SAB_RECURSO
                            Case "PT"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 7
                        Select Case TECNICORow.DOM_RECURSO
                            Case "PT"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_TEC_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_TEC_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_TEC_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_TEC_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                End Select
            Case "CUAD RED", "CUAD MDU"
                Select Case DIASEMCALC
                    Case 1
                        Select Case TECNICORow.LUN_RECURSO
                            Case "PT"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.LUN_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 2
                        Select Case TECNICORow.MAR_RECURSO
                            Case "PT"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.MAR_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 3
                        Select Case TECNICORow.MIER_RECURSO
                            Case "PT"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.MIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 4
                        Select Case TECNICORow.JUEV_RECURSO
                            Case "PT"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.JUEV_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 5
                        Select Case TECNICORow.VIER_RECURSO
                            Case "PT"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.VIER_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 6
                        Select Case TECNICORow.SAB_RECURSO
                            Case "PT"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.SAB_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                    Case 7
                        Select Case TECNICORow.DOM_RECURSO
                            Case "PT"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_PT(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_PT(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_PT(DIASEMCALC) += 1
                                End Select
                            Case "SU"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_ALT_TEOR_SU(DIASEMCALC) += 1
                                    Case "MEDIA"
                                        CANT_CUAD_MED_TEOR_SU(DIASEMCALC) += 1
                                    Case "BAJA"
                                        CANT_CUAD_BAJ_TEOR_SU(DIASEMCALC) += 1
                                End Select
                            Case "CO"
                                Select Case TECNICORow.DOM_PRIO
                                    Case "ALTA"
                                        CANT_CUAD_TEOR_CO(DIASEMCALC) += 1
                                End Select
                        End Select
                End Select


        End Select
    End Sub

    'AL CAMBIAR DE DIA
    Private Sub VERIFICA_PROCESOS()
        FORMAGE.Cursor = Cursors.WaitCursor
        FORMAGE.BD_TAREASTableAdapter.FillByENTREFECHAS(FORMAGE.ANALISIS_AGDataSet.BD_TAREAS, FECHAINI, FECHAINI.AddDays(1))
        If FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count > 0 Then
            FORMAGE.ORDENESTableAdapter.FillByFECHAYSTATUS(FORMAGE.ORDENESDataSet.ORDENES, FECHAINI, FECHAINI.AddDays(1), "FINALIZADO")
            FORMAGE.REG_DIARIOTableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.REG_DIARIO, FECHAINI)
            FORMAGE.TOTAL_XDIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA, FECHAINI)
            If FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows.Count > 0 Then
                TOTALxDIARow = FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows(0)
                If TOTALxDIARow.IsCANT_TAREASPROCNull = False Then FORMAGE.CANT_TAREASING.Text = TOTALxDIARow.CANT_TAREASPROC Else FORMAGE.CANT_TAREASING.Text = 0
                If TOTALxDIARow.IsCANT_ORDINALESINGNull = False Then FORMAGE.CANT_ORDING.Text = TOTALxDIARow.CANT_ORDINALESING Else FORMAGE.CANT_ORDING.Text = 0
                If TOTALxDIARow.IsCANT_OBSERVACIONESINGNull = False Then FORMAGE.CANT_OBSING.Text = TOTALxDIARow.CANT_OBSERVACIONESING Else FORMAGE.CANT_OBSING.Text = 0
                If TOTALxDIARow.IsCANT_ORDINALESEDITNull = False Then FORMAGE.CANT_ORDEDIT.Text = TOTALxDIARow.CANT_ORDINALESEDIT Else FORMAGE.CANT_ORDEDIT.Text = 0
            End If
            RESUMEN_DIARIO()
            FORMAGE.BOT_CALCULATOTDIA.Enabled = True
            FORMAGE.Cursor = Cursors.Default
            FORMAGE.BOT_PROCESAR.Enabled = True
            FORMAGE.BOT_PROCESAR.Text = "REPROCESAR"
        Else
            If FECHAINI = Today.ToShortDateString Then
                FORMAGE.Cursor = Cursors.Default
                Exit Sub
            End If
            FORMAGE.Cursor = Cursors.Default
            FORMAGE.BOT_CALCULATOTDIA.Enabled = False
            If Format(FECHAINI, "yyyyMMdd") < Format(Today, "yyyyMMdd") Then
                Dim RESULTADO_BASE As DialogResult = MsgBox("NO EXISTEN REGISTROS CARGADOS PARA EL DIA " & FECHAINI & vbNewLine & "DESEA CARGARLOS?", vbYesNo)
                If RESULTADO_BASE = DialogResult.Yes Then
                    IMPORTAR_ESIR()
                End If
            End If
        End If
        FORMAGE.CANT_PROCESADOS.Text = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count
        CANT_PROCESADOS = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count
    End Sub
    Public Sub IMPORTAR_ESIR()
        Dim TIPO_PROCESO As DialogResult = MsgBox("COMO DESEA CARGAR LOS REGISTROS?" & vbNewLine & "OPCION = SI -> SE CARGARÁ MEDIANTE ARCHIVO EXCEL (*.XLSX)" & vbNewLine & "OPCION = NO -> SE CONECTARA AL E-SIR AUTOMATICAMENTE", vbYesNo)
        Dim espera As Integer = 100
        FORMAGE.Cursor = Cursors.WaitCursor
        If TIPO_PROCESO = DialogResult.No Then
            CARGAR_TAREASAG_BOT()
        ElseIf TIPO_PROCESO = DialogResult.Yes Then
            CARGAR_TAREAS_EXCEL()
        ElseIf TIPO_PROCESO = DialogResult.Cancel Then
        End If
        'FORMAGE.LBL_NOTIFICACION.Text = "ORDENES IMPORTADAS CON EXITO"
        'FORMAGE.AVANCE.Value = 0
        'FORMAGE.LBL_CUENTA.Text = ""
        FORMAGE.Cursor = Cursors.Default
        FORMAGE.AVANCE.Value = 0
    End Sub
    Private Sub CARGAR_TAREASAG_BOT()
        Dim Fila As Integer
        Dim REGISTRO As Integer = 0
        Dim TOTAL_REGS As Integer = 0
        If driver Is Nothing Then
            Dim CHROMEOPTION As New ChromeOptions()
            CHROMEOPTION.PageLoadStrategy = PageLoadStrategy.Eager
            driver = New ChromeDriver(CHROMEOPTION)
        End If 'INICIA EL DRIVER DEL BOT
        driver.Url = "http://wsinterno.equital.com/ords/f?p=101:LOGIN_DESKTOP:14421523630655" ' "wsinterno.equital.com/ords/f?p=101:LOGIN_DESKTOP"
        Sleep(2000)
        driver.FindElement(By.Id(USER)).Clear()
        driver.FindElement(By.Id(USER)).SendKeys(NOMBRE)
        Sleep(500)
        driver.FindElement(By.Id(PASS)).Clear()
        driver.FindElement(By.Id(PASS)).SendKeys(PASSWORD)
        Sleep(500)
        driver.FindElement(By.Id(BTN_INGRESAR_LOGIN)).Click()
        Sleep(3000)
        Dim PAGINA_ACTUAL As Array = Split(driver.Url, ":")
        Dim WEB_BUSQUEDA = "http:" & PAGINA_ACTUAL(1) & ":127:" & PAGINA_ACTUAL(3) & "::NO:::"
        Try
            driver.Url = WEB_BUSQUEDA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Sleep(4000)
        Try
            Dim TIPO = New SelectElement(driver.FindElement(By.Id(CB_TIPO_FECHA)))
            TIPO.SelectByIndex(0)
            Sleep(1500)
            Dim GRUPO_PERMISOR = New SelectElement(driver.FindElement(By.Id(CB_GRUPO_PERMISOR)))
            GRUPO_PERMISOR.SelectByIndex(1)
            Sleep(500)
            driver.FindElement(By.Id(FECHA_DESDE)).SendKeys(FECHATRATADA) 'FECHA_INICIO.ToShortDateString
            Sleep(200)
            driver.FindElement(By.Id(FECHA_HASTA)).SendKeys(FECHATRATADA) ' FECHA_FIN.ToShortDateString
            Sleep(500)
            driver.ExecuteJavaScript("javascript:gReport.dialog2('SHOW_DOWNLOAD');")
            driver.Navigate().Refresh()
            Sleep(1500)
            driver.ExecuteJavaScript("javascript:gReport.search('SEARCH',100000)")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Sleep(8000)
        Dim PARCIAL_XPATH As String = "//*[@id='7089724241694741']/tbody/tr["

        '//*[@id="7089724241694741"]/tbody/tr[2]/td[1]

        FORMAGE.ESTADOTXT.Text = "CONTANDO REGISTROS"
        FORMAGE.ESTADOTXT.Refresh()

        FORMAGE.AVANCE.Value = 0
        FORMAGE.AVANCE.Maximum = 10000
        For CANTIDAD = 2 To 10000
            Try

                If Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & CANTIDAD & "]/td[5]")).Text) = "FINALIZADO" Then
                    NROORDINAL = Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & CANTIDAD & "]/td[1]")).Text)
                    TOTAL_REGS += 1
                    FORMAGE.CANT_PROCESOS.Text = "Leyendo " & TOTAL_REGS & " registros"
                    FORMAGE.CANT_PROCESOS.Refresh()
                End If
            Catch ex As Exception
                Exit For
            End Try
            FORMAGE.AVANCE.Value = CANTIDAD
            FORMAGE.AVANCE.Refresh()
        Next

        FORMAGE.Label51.Text = "Total " & TOTAL_REGS & " registros"
        FORMAGE.Label51.Refresh()
        FORMAGE.ESTADOTXT.Text = TOTAL_REGS & " REGISTROS"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.AVANCE.Maximum = TOTAL_REGS
        FORMAGE.AVANCE.Value = 0
        Sleep(5000)

        FORMAGE.ESTADOTXT.Text = "INGRESANDO REGISTROS"
        FORMAGE.ESTADOTXT.Refresh()
        'For D = 0 To 20
        '    Try
        For Fila = 2 To 1000
            Try
                If Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[5]")).Text) = "FINALIZADO" Then
                    Dim AFECTACION As String
                    If Mid(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[15]")).Text), 1, 1) = "," Then
                        AFECTACION = "0" & Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[15]")).Text)
                    Else
                        AFECTACION = Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[15]")).Text)
                    End If
                    Dim INICIO_TRABAJO As String
                    If Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[28]")).Text) = "-" Then
                        INICIO_TRABAJO = ""
                    Else
                        INICIO_TRABAJO = Format(CDate(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[28]")).Text)), "yyyy-MM-dd hh:mm:ss")
                    End If
                    Dim FIN_TRABAJO As String
                    If Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[29]")).Text) = "-" Then
                        FIN_TRABAJO = ""
                    Else
                        FIN_TRABAJO = Format(CDate(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[29]")).Text)), "yyyy-MM-dd hh:mm:ss")
                    End If
                    Dim TIEMPO_TRABAJO As String
                    If Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[30]")).Text) = ":" Then
                        TIEMPO_TRABAJO = 0
                    Else
                        Dim PARCIAL = Split(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[30]")).Text), ":")
                        If Trim(PARCIAL(0)) & ":" & Trim(PARCIAL(1)) = "0:60" Then
                            TIEMPO_TRABAJO = Mid(CDate("1:00").ToOADate, 1, 13)
                        Else
                            TIEMPO_TRABAJO = Mid(CDate(Trim(PARCIAL(0)) & ":" & Trim(PARCIAL(1))).ToOADate, 1, 13)
                        End If
                    End If
                    Dim TIEMPO_STANDARD As String
                    If Mid(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[48]")).Text), 1, 1) = "," Then
                        TIEMPO_STANDARD = "0" & Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[48]")).Text)
                    Else
                        TIEMPO_STANDARD = Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[48]")).Text)
                    End If
                    Dim TIEMPO_PREVISTA As String
                    If Mid(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[49]")).Text), 1, 1) = "," Then
                        TIEMPO_PREVISTA = "0" & Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[49]")).Text)
                    Else
                        TIEMPO_PREVISTA = Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[49]")).Text)
                    End If
                    Dim TIEMPO_REALIZADA As String
                    If Mid(Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[50]")).Text), 1, 1) = "," Then
                        TIEMPO_REALIZADA = "0" & Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[50]")).Text)
                    Else
                        TIEMPO_REALIZADA = Trim(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[50]")).Text)
                    End If

                    TAREAS_NEWROW = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.NewBD_TAREASRow()
                    TAREAS_NEWROW("Nro Ordinal") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[1]")).Text
                    TAREAS_NEWROW.Tipo = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[2]")).Text
                    TAREAS_NEWROW.Sector = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[3]")).Text
                    TAREAS_NEWROW.Visibilidad = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[4]")).Text
                    TAREAS_NEWROW.Status = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[5]")).Text
                    TAREAS_NEWROW.Ingreso = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[6]")).Text
                    TAREAS_NEWROW.Cierre = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[7]")).Text
                    TAREAS_NEWROW.Nodo = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[8]")).Text
                    TAREAS_NEWROW.Nodo_Abr = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[9]")).Text
                    TAREAS_NEWROW.Zona = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[10]")).Text
                    TAREAS_NEWROW("Reclamos") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[11]")).Text
                    TAREAS_NEWROW.Reclamos_Mdu_Asoc = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[12]")).Text
                    TAREAS_NEWROW.Reclamos_Tot = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[13]")).Text
                    TAREAS_NEWROW.Cliafec = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[14]")).Text
                    TAREAS_NEWROW("%Afectacion") = AFECTACION
                    TAREAS_NEWROW.Generacion = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[16]")).Text
                    TAREAS_NEWROW.Permisor = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[17]")).Text
                    TAREAS_NEWROW("Falla Origen") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[18]")).Text
                    TAREAS_NEWROW.Desc_Falla_Origen = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[19]")).Text
                    TAREAS_NEWROW("Falla Cierre") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[20]")).Text
                    TAREAS_NEWROW.Desc_Falla_Cierre = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[21]")).Text
                    TAREAS_NEWROW("Causa Cierre") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[22]")).Text
                    TAREAS_NEWROW.Desc_Causa_Cierre = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[23]")).Text
                    TAREAS_NEWROW("Ejecutante") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[24]")).Text
                    TAREAS_NEWROW.Nombre_Ejecutante = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[25]")).Text
                    TAREAS_NEWROW.Observaciones_Origen = Mid(driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[26]")).Text, 1, 255)
                    TAREAS_NEWROW.Observaciones_Cierre = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[27]")).Text
                    TAREAS_NEWROW.Inicio_De_Trabajo = INICIO_TRABAJO
                    TAREAS_NEWROW.Fin_De_Trabajo = FIN_TRABAJO
                    TAREAS_NEWROW.Tiempo_De_Trabajo = TIEMPO_TRABAJO
                    TAREAS_NEWROW("Causa De Origen") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[31]")).Text
                    TAREAS_NEWROW.Desc_Causa_Origen = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[32]")).Text
                    TAREAS_NEWROW("Ordinal Principal") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[33]")).Text
                    TAREAS_NEWROW.Ordinal_Apoyado = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[34]")).Text
                    TAREAS_NEWROW.Ordinal_Padre = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[35]")).Text
                    TAREAS_NEWROW.Instalación = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[36]")).Text
                    TAREAS_NEWROW("Nro Agendmiento") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[37]")).Text
                    TAREAS_NEWROW("Ordinal") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[38]")).Text
                    TAREAS_NEWROW("Actividad Agenda Id") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[39]")).Text
                    TAREAS_NEWROW.Actividad_Agenda_Acrónimo = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[40]")).Text
                    TAREAS_NEWROW.Actividad_Agenda_Desc = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[41]")).Text
                    TAREAS_NEWROW("Actividad Agenda Linea Id") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[42]")).Text
                    TAREAS_NEWROW("Tarea De Agenda Id") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[43]")).Text
                    TAREAS_NEWROW.Tarea_De_Agenda_Acrónimo = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[44]")).Text
                    TAREAS_NEWROW.Tarea_De_Agenda_Descripción = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[45]")).Text
                    TAREAS_NEWROW("Cantidad Tarea Según Estándar") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[46]")).Text
                    TAREAS_NEWROW("Cantidad Tarea Realizada") = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[47]")).Text
                    TAREAS_NEWROW("Tiempo Estándar Tarea Ua") = TIEMPO_STANDARD
                    TAREAS_NEWROW("Tiempo Prevista") = TIEMPO_PREVISTA
                    TAREAS_NEWROW("Tiempo Realizada") = TIEMPO_REALIZADA
                    TAREAS_NEWROW.Codigo_Calle = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[51]")).Text
                    TAREAS_NEWROW.Nombre_Calle = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[52]")).Text
                    TAREAS_NEWROW.Nro_puerta = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[53]")).Text
                    TAREAS_NEWROW.MduNom = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[54]")).Text
                    TAREAS_NEWROW.Mdunro = driver.FindElement(By.XPath(PARCIAL_XPATH & Fila & "]/td[55]")).Text
                    FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Add(TAREAS_NEWROW)
                    FORMAGE.CANT_PROCESOS.Text = "Cargando " & Fila - 1 & "/" & TOTAL_REGS
                    FORMAGE.AVANCE.Value = REGISTRO
                    FORMAGE.AVANCE.Refresh()
                    FORMAGE.CANT_PROCESOS.Refresh()
                    REGISTRO += 1
                    Try
                        FORMAGE.BD_TAREASTableAdapter.Update(TAREAS_NEWROW)
                    Catch ex As Exception
                        MsgBox("NO SE PUDO GRABAR EN LA BASE DE DATOS  ORDINAL" & Trim(driver.FindElement(By.XPath("//*[@class='apexir_WORKSHEET_DATA']/tbody/tr[" & Fila & "]/td[1]")).Text) & "   " & ex.Message, vbExclamation)
                    End Try
                End If
            Catch ex As Exception
                Exit For
            End Try
        Next

        If driver IsNot Nothing Then
            driver.Quit()
        End If

        FORMAGE.BD_TAREASTableAdapter.FillByENTREFECHAS(FORMAGE.ANALISIS_AGDataSet.BD_TAREAS, FECHAINI, FECHAINI.AddDays(1))
        FORMAGE.CANT_PROCESADOS.Text = 0
        FORMAGE.CANT_PROCESADOS.Text = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count
        FORMAGE.CANT_ORDING.Text = 0
        FORMAGE.CANT_ORDEDIT.Text = 0
        FORMAGE.CANT_OBSING.Text = 0
        FORMAGE.CANT_TAREASING.Text = 0
        FORMAGE.AVANCE.Value = 0
        PROCESAR()

    End Sub
    Private Sub CARGAR_TAREAS_EXCEL()
        '    '_________________________________________________________________________________________-
        FORMAGE.OpenFileDialog1.ShowDialog()
        FORMAGE.Cursor = Cursors.WaitCursor
        'Button1.Enabled = False
        Dim Fila As Integer = 0
        Dim REGISTRO As Integer = 0
        Dim TOTAL_REGS As Integer = 0
        Dim CONTENIDO As String = "INICIO"
        Dim oExcel As New Excel.Application
        Dim oLibro As Excel.Workbook
        Dim oHoja As Excel.Worksheet

        oLibro = oExcel.Workbooks.Open(FORMAGE.OpenFileDialog1.FileName)
        oHoja = oLibro.Sheets(oLibro.Worksheets.Item(1).NAME)

        FORMAGE.AVANCE.Maximum = 10000
        While CONTENIDO <> ""
            REGISTRO += 1
            CONTENIDO = oHoja.Cells(REGISTRO, 1).value
            If oHoja.Cells(REGISTRO, 5).value = "FINALIZADO" Then
                Fila += 1
                FORMAGE.CANT_PROCESOS.Text = "Leyendo " & Fila & " registros"
                FORMAGE.CANT_PROCESOS.Refresh()
                FORMAGE.AVANCE.Value = Fila
                FORMAGE.AVANCE.Refresh()
            End If
        End While
        TOTAL_REGS = Fila
        FORMAGE.CANT_PROCESOS.Text = "Total " & TOTAL_REGS & " registros"
        FORMAGE.CANT_PROCESOS.Refresh()
        FORMAGE.ESTADOTXT.Text = TOTAL_REGS & " REGISTROS"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.AVANCE.Maximum = TOTAL_REGS
        FORMAGE.AVANCE.Value = 0
        REGISTRO = 0
        Fila = 0
        CONTENIDO = oHoja.Cells(2, 1).VALUE
        While CONTENIDO <> ""
            Fila += 1
            CONTENIDO = oHoja.Cells(Fila, 1).value
            Try
                If oHoja.Cells(Fila, 5).value = "FINALIZADO" Then
                    'CARGAMOS LOS DATOS AL ACCES CON LOS DATOS AQUI
                    TAREAS_NEWROW = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.NewBD_TAREASRow()
                    TAREAS_NEWROW.Nro_Ordinal = oHoja.Cells(Fila, 1).value
                    TAREAS_NEWROW.Tipo = oHoja.Cells(Fila, 2).value
                    TAREAS_NEWROW.Sector = oHoja.Cells(Fila, 3).value
                    TAREAS_NEWROW.Visibilidad = oHoja.Cells(Fila, 4).value
                    TAREAS_NEWROW.Status = oHoja.Cells(Fila, 5).value
                    TAREAS_NEWROW.Ingreso = oHoja.Cells(Fila, 6).value
                    TAREAS_NEWROW.Cierre = oHoja.Cells(Fila, 7).value
                    TAREAS_NEWROW.Nodo = oHoja.Cells(Fila, 8).value
                    TAREAS_NEWROW.Nodo_Abr = oHoja.Cells(Fila, 9).value
                    TAREAS_NEWROW.Zona = Mid(oHoja.Cells(Fila, 10).value, 1, 255)
                    TAREAS_NEWROW.Reclamos = oHoja.Cells(Fila, 11).value
                    TAREAS_NEWROW.Reclamos_Mdu_Asoc = oHoja.Cells(Fila, 12).value
                    TAREAS_NEWROW.Reclamos_Tot = oHoja.Cells(Fila, 13).value
                    TAREAS_NEWROW.Cliafec = oHoja.Cells(Fila, 14).value
                    TAREAS_NEWROW.__Afectacion = oHoja.Cells(Fila, 15).value
                    TAREAS_NEWROW.Generacion = oHoja.Cells(Fila, 16).value
                    TAREAS_NEWROW.Permisor = oHoja.Cells(Fila, 17).value
                    TAREAS_NEWROW.Falla_Origen = oHoja.Cells(Fila, 18).value
                    TAREAS_NEWROW.Desc_Falla_Origen = Trim(oHoja.Cells(Fila, 19).value)
                    TAREAS_NEWROW.Falla_Cierre = oHoja.Cells(Fila, 20).value
                    TAREAS_NEWROW.Desc_Falla_Cierre = Trim(oHoja.Cells(Fila, 21).value)
                    TAREAS_NEWROW.Causa_Cierre = oHoja.Cells(Fila, 22).value
                    TAREAS_NEWROW.Desc_Causa_Cierre = Trim(oHoja.Cells(Fila, 23).value)
                    TAREAS_NEWROW.Ejecutante = oHoja.Cells(Fila, 24).value
                    TAREAS_NEWROW.Nombre_Ejecutante = Trim(oHoja.Cells(Fila, 25).value)
                    TAREAS_NEWROW.Observaciones_Origen = Mid(oHoja.Cells(Fila, 26).value, 1, 255)
                    TAREAS_NEWROW.Observaciones_Cierre = oHoja.Cells(Fila, 27).value
                    If Trim(oHoja.Cells(Fila, 28).value) = "-" Then
                    Else
                        TAREAS_NEWROW.Inicio_De_Trabajo = oHoja.Cells(Fila, 28).value
                    End If
                    If Trim(oHoja.Cells(Fila, 29).value) = "-" Then
                    Else
                        TAREAS_NEWROW.Fin_De_Trabajo = oHoja.Cells(Fila, 29).value
                    End If

                    If Trim(oHoja.Cells(Fila, 30).value) = ":" Then
                        TAREAS_NEWROW.Tiempo_De_Trabajo = 0
                    Else
                        TAREAS_NEWROW.Tiempo_De_Trabajo = Mid(Trim(oHoja.Cells(Fila, 30).value), 1, 14)
                    End If
                        TAREAS_NEWROW.Causa_De_Origen = oHoja.Cells(Fila, 31).value
                    TAREAS_NEWROW.Desc_Causa_Origen = oHoja.Cells(Fila, 32).value
                    TAREAS_NEWROW.Ordinal_Principal = oHoja.Cells(Fila, 33).value
                    TAREAS_NEWROW.Ordinal_Apoyado = oHoja.Cells(Fila, 34).value
                    TAREAS_NEWROW.Ordinal_Padre = oHoja.Cells(Fila, 35).value
                    TAREAS_NEWROW.Instalación = oHoja.Cells(Fila, 36).value
                    TAREAS_NEWROW.Nro_Agendmiento = oHoja.Cells(Fila, 37).value
                    TAREAS_NEWROW.Ordinal = oHoja.Cells(Fila, 38).value
                    TAREAS_NEWROW.Actividad_Agenda_Id = oHoja.Cells(Fila, 39).value
                    TAREAS_NEWROW.Actividad_Agenda_Acrónimo = oHoja.Cells(Fila, 40).value
                    TAREAS_NEWROW.Actividad_Agenda_Desc = oHoja.Cells(Fila, 41).value
                    TAREAS_NEWROW.Actividad_Agenda_Linea_Id = oHoja.Cells(Fila, 42).value
                    TAREAS_NEWROW.Tarea_De_Agenda_Id = oHoja.Cells(Fila, 43).value
                    TAREAS_NEWROW.Tarea_De_Agenda_Acrónimo = oHoja.Cells(Fila, 44).value
                    TAREAS_NEWROW.Tarea_De_Agenda_Descripción = oHoja.Cells(Fila, 45).value
                    TAREAS_NEWROW.Cantidad_Tarea_Según_Estándar = oHoja.Cells(Fila, 46).value
                    TAREAS_NEWROW.Cantidad_Tarea_Realizada = oHoja.Cells(Fila, 47).value
                    TAREAS_NEWROW.Tiempo_Estándar_Tarea_Ua = oHoja.Cells(Fila, 48).value
                    TAREAS_NEWROW.Tiempo_Prevista = oHoja.Cells(Fila, 49).value
                    TAREAS_NEWROW.Tiempo_Realizada = oHoja.Cells(Fila, 50).value
                    TAREAS_NEWROW.Codigo_Calle = oHoja.Cells(Fila, 51).value
                    TAREAS_NEWROW.Nombre_Calle = Trim(oHoja.Cells(Fila, 52).value)
                    TAREAS_NEWROW.Nro_puerta = oHoja.Cells(Fila, 53).value
                    TAREAS_NEWROW.MduNom = oHoja.Cells(Fila, 54).value
                    TAREAS_NEWROW.Mdunro = oHoja.Cells(Fila, 55).value
                    FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Add(TAREAS_NEWROW)
                    REGISTRO += 1
                    FORMAGE.CANT_PROCESOS.Text = "Cargando " & REGISTRO & "/" & TOTAL_REGS
                    FORMAGE.AVANCE.Value = REGISTRO
                    FORMAGE.AVANCE.Refresh()
                    FORMAGE.CANT_PROCESOS.Refresh()
                End If

            Catch EX As Exception
                MsgBox("ERROR AL LEER LA LINEA " & REGISTRO & "  ...ORDINAL     " & EX.Message) '" & oHoja.Cells(Fila, 1).value & "
            End Try

        End While
        Try
            FORMAGE.ESTADOTXT.Text = "GRABANDO EN BBDD"
            FORMAGE.BD_TAREASTableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.BD_TAREAS)
            MsgBox("DATOS INGRESADOS CORRECTAMENTE TOTAL: " & REGISTRO, vbInformation)


        Catch ex As Exception
            MsgBox("NO SE PUDO GRABAR EN LA BASE DE DATOS  " & ex.Message, vbExclamation)
        End Try

        oLibro.Close()
        oExcel.Quit()

        oExcel = Nothing

        FORMAGE.ESTADOTXT.Text = "TAREA TERMINADAS"

        'Button1.Enabled = True

        FORMAGE.Cursor = Cursors.Default
        FORMAGE.BD_TAREASTableAdapter.FillByENTREFECHAS(FORMAGE.ANALISIS_AGDataSet.BD_TAREAS, FECHAINI, FECHAINI.AddDays(1))
        FORMAGE.CANT_PROCESADOS.Text = 0
        FORMAGE.CANT_PROCESADOS.Text = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count
        FORMAGE.CANT_ORDING.Text = 0
        FORMAGE.CANT_ORDEDIT.Text = 0
        FORMAGE.CANT_OBSING.Text = 0
        FORMAGE.CANT_TAREASING.Text = 0
        FORMAGE.AVANCE.Value = 0
        PROCESAR()
    End Sub
    Public Sub PROCESAR()
        CANT_ORDINGRE = 0
        CANT_ORDEDITA = 0
        CANT_TAREASINGRE = 0
        CANT_OBSINGRE = 0
        TIEMP_TARPREV = 0
        TIEMP_TARREAL = 0
        FORMAGE.ESTADOTXT.Text = "PROCESANDO"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.CANT_PROCESADOS.Text = 0
        FORMAGE.CANT_ORDING.Text = 0
        FORMAGE.CANT_ORDEDIT.Text = 0
        FORMAGE.CANT_OBSING.Text = 0
        FORMAGE.CANT_TAREASING.Text = 0

        Dim I As Integer
        MISMOORDINAL = True
        FORMAGE.Cursor = Cursors.WaitCursor
        Dim BUSCA_DATOSORDINAL As Boolean = True
        BUSCA_DATOSORDINAL = True
        ENCONTRE_ORDINAL = "NO"


        'BUSCAMOS TODAS LAS ORDENES CARGADAS NO FINALIZADAS Y QUE EXISTEN EN EL SISTEMA DE GESTION (EN DATASET)
        FORMAGE.ORDENESTableAdapter.FillBySTSDIF(FORMAGE.ORDENESDataSet1.ORDENES, "FINALIZADO")
        FORMAGE.AVANCE.Maximum = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count

        'RECORRE LA BASE DE DATOS EXPORTADA CON FECHA DE ANALISIS = FECHA DE FINALIZACION HASTA EL ANTE-ULTIMO REGISTRO, ESTA ES UNA BASE DE TAREAS
        For I = 0 To FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows.Count - 2
            FORMAGE.AVANCE.Value = I + 1
            FORMAGE.AVANCE.Refresh()
            FORMAGE.CANT_PROCESADOS.Text = I + 1
            FORMAGE.CANT_PROCESADOS.Refresh()
            'OBTIENE DATOS SOBE LA POSICION
            BDTAREASACTRow = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows(I)
            BDTAREASPOSTRow = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows(I + 1)
            NROORDINAL = BDTAREASACTRow.Nro_Ordinal

            'COMPARAMOS EL NUMERO DE ORDINAL ENTRE LA LINEA ACTUAL Y LA SIGUIENTE, SI SON IGUALES MARCAMOS COMO TRUE LA VARIABLE MISMOORDINAL
            Select Case BDTAREASACTRow.Nro_Ordinal
                Case BDTAREASPOSTRow.Nro_Ordinal
                    MISMOORDINAL = True
                Case Else
                    MISMOORDINAL = False
            End Select

            'ANALIZA SI SE CARGARON ORDENES FINALIZADAS, SI EXISTEN ORDENES PARCIALMENTE CARGADAS AHORA SE PODRA CORRER EL PROCESO
            If FORMAGE.ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                For M = 0 To FORMAGE.ORDENESDataSet.ORDENES.Rows.Count - 1
                    If FORMAGE.ORDENESDataSet.ORDENES.Rows(M).Item("NRO_ORDINAL") = NROORDINAL Then
                        GoTo YACARGADO
                    End If
                Next M
            End If
            TIEMP_TARPREV += BDTAREASACTRow.Tiempo_Prevista
            TIEMP_TARREAL += BDTAREASACTRow.Tiempo_Realizada

            Select Case Trim(BDTAREASACTRow.Tipo)
                Case "TAREA", "OBRAS"
                    Select Case BUSCA_DATOSORDINAL
                        Case True
                            If FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count > 0 Then 'ENCONTRO ORDENES CON ORDINAL CARGADO Y NO FINALIZADAS
                                For X = 0 To FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count - 1
                                    If NROORDINAL = FORMAGE.OrdenesDataSet1.ORDENES.Rows(X).Item("NRO_ORDINAL") Then   'VERIFICA QUE EL ORDINAL QUE FIGURA EN BD_TAREAS SEA IGUAL AL ORDINAL DE LA TABLA ORDENES
                                        ORDENACTRow = FORMAGE.OrdenesDataSet1.ORDENES.Rows(X)
                                        STATUSANTERIOR = ORDENACTRow.STATUS
                                        ORDENINTERNA = ORDENACTRow.NRO_ORDENINT
                                        ENCONTRE_ORDINAL = "SI"
                                        Exit For
                                    End If
                                    'SI NO ENCONTRO UNA ORDEN
                                    ORDENINTERNA = 0
                                    ENCONTRE_ORDINAL = "NO"
                                Next
                            End If
                    End Select
                Case Else  'SI NO ES UN ORDINAL DE TAREA
                    ORDENINTERNA = 0
                    ENCONTRE_ORDINAL = "NO"
            End Select

            Select Case MISMOORDINAL     'VERIFICA QUE NO ES LA ULTIMA TAREA YA QUE LA PROXIMA FILA TIENE EL MISMO NRO DE ORDINAL 
                Case True
                    BUSCA_DATOSORDINAL = False
                Case False
                    BUSCA_DATOSORDINAL = True
            End Select
            'SI LA FILA ANALIZADA TIENE EL MISMO ORDINAL QUE LA FILA SIGUIENTE ES SOLO UNA TAREA
            'SI NO ES EL MISMO SIGNIFICA QUE ES LA ULTIMA TAREA, POR LO QUE SE GRABA LA MISMA Y SE EDITA O GRABA EL ORDINAL
            MODIFICAR_PARAMETROS()
YACARGADO:
            FORMAGE.CANT_ORDING.Refresh()
            FORMAGE.CANT_ORDEDIT.Refresh()
            FORMAGE.CANT_TAREASING.Refresh()
            FORMAGE.CANT_OBSING.Refresh()
        Next I

        'EN ESTE PUNTO TERMINO DE RECORRER LA BASE DE DATOS DEL ESIR (TAREAS), SOLO QUEDA GRABAR LA ULTIMA TAREA 
        FORMAGE.AVANCE.Value = I + 1
        FORMAGE.AVANCE.Refresh()
        'OBTIENE DATOS SOBRE LA POSICION
        BDTAREASACTRow = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows(I)
        NROORDINAL = BDTAREASACTRow("Nro Ordinal")
        BDTAREASPOSTRow = FORMAGE.ANALISIS_AGDataSet.BD_TAREAS.Rows(I - 1)

        TIEMP_TARPREV += BDTAREASACTRow("Tiempo Prevista")
        TIEMP_TARREAL += BDTAREASACTRow("Tiempo Realizada")

        MISMOORDINAL = False

        'ANALIZA SI SE CARGARON ORDENES FINALIZADAS, SI EXISTEN ORDENES PARCIALMENTE CARGADAS AHORA SE PODRA CORRER EL PROCESO
        If FORMAGE.ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            For M = 0 To FORMAGE.ORDENESDataSet.ORDENES.Rows.Count - 1
                If FORMAGE.ORDENESDataSet.ORDENES.Rows(M).Item("NRO_ORDINAL") = NROORDINAL Then
                    GRABAR_PROCESOS()
                    Exit For
                End If
            Next M
        End If

        Select Case BUSCA_DATOSORDINAL
            Case True
                If FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count > 0 Then
                    'ENCONTRO ORDENES CON ORDINAL CARGADO Y NO FINALIZADAS
                    For X = 0 To FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count - 1
                        Select Case NROORDINAL
                       'VERIFICA QUE EL ORDINAL QUE FIGURA EN BD_TAREAS SEA IGUAL AL ORDINAL DE LA TABLA ORDENES
                            Case = FORMAGE.OrdenesDataSet1.ORDENES.Rows(X).Item("NRO_ORDINAL") 'ENCONTRO UN ORDINAL QUE YA ESTA EN LA BASE DE DATOS
                                ORDENACTRow = FORMAGE.OrdenesDataSet1.ORDENES.Rows(X)
                                STATUSANTERIOR = ORDENACTRow("STATUS")
                                ORDENINTERNA = ORDENACTRow("NRO_ORDENINT")
                                ENCONTRE_ORDINAL = "SI"
                                Exit For 'COMO YA ENCONTRO UNA ORDEN SALE DEL LAZO
                            Case Else 'NO ENCONTRO UN ORDINAL QUE YA ESTA EN LA BASE DE DATOS
                                ORDENINTERNA = 0
                                ENCONTRE_ORDINAL = "NO"
                        End Select
                    Next X
                End If
        End Select
        MODIFICAR_PARAMETROS()
        GRABAR_PROCESOS()
        CALCULA_TOTALXDIA()
    End Sub
    Private Sub MODIFICAR_PARAMETROS()
        If MISMOORDINAL = True Then
            GRABAR_TAREAS()
            CANT_TAREASINGRE += 1
            FORMAGE.CANT_TAREASING.Text = CANT_TAREASINGRE
            FORMAGE.CANT_TAREASING.Refresh()
        Else
            GRABAR_OBSERVACIONES()
            CANT_OBSINGRE += 1
            FORMAGE.CANT_OBSING.Text = CANT_OBSINGRE
            FORMAGE.CANT_OBSING.Refresh()

            GRABAR_TAREAS()
            CANT_TAREASINGRE += 1
            FORMAGE.CANT_TAREASING.Text = CANT_TAREASINGRE
            FORMAGE.CANT_TAREASING.Refresh()

            If ENCONTRE_ORDINAL = "NO" Then
                GRABA_ORDINAL()
                CANT_ORDINGRE += 1
                FORMAGE.CANT_ORDING.Text = CANT_ORDINGRE
                FORMAGE.CANT_OBSING.Refresh()
            Else
                EDITA_ORDINAL()
                CANT_ORDEDITA += 1
                FORMAGE.CANT_ORDEDIT.Text = CANT_ORDEDITA
                FORMAGE.CANT_ORDEDIT.Refresh()
            End If
        End If
    End Sub
    Private Sub GRABAR_OBSERVACIONES()
        NewObservacionRow = FORMAGE.ORDENESDataSet.OBESERVACIONES.NewOBESERVACIONESRow
        NewObservacionRow("NROORDINAL") = BDTAREASACTRow("Nro Ordinal")
        NewObservacionRow("NRO_ORDENINT") = ORDENINTERNA
        NewObservacionRow("OBSORIGEN") = BDTAREASACTRow("Observaciones Origen")
        NewObservacionRow("OBSCIERRE") = BDTAREASACTRow("Observaciones Cierre")
        FORMAGE.ORDENESDataSet.OBESERVACIONES.Rows.Add(NewObservacionRow)
    End Sub
    Private Sub GRABAR_TAREAS()
        NEWTAREARow = FORMAGE.ORDENESDataSet.TAREAS.NewTAREASRow
        NEWTAREARow("ORDINAL") = BDTAREASACTRow("Nro Ordinal")
        NEWTAREARow("NRO_ORDENINT") = ORDENINTERNA
        NEWTAREARow("NRO_AGENDAMIENTO") = BDTAREASACTRow("Nro Agendmiento")
        NEWTAREARow("STATUS") = BDTAREASACTRow("Status")
        NEWTAREARow("ACTIVIDADDESC") = BDTAREASACTRow("Actividad Agenda Desc")
        NEWTAREARow("TAREADESC") = BDTAREASACTRow("Tarea De Agenda Descripción")
        NEWTAREARow("CANTSTD") = BDTAREASACTRow("Cantidad Tarea Según Estándar")
        NEWTAREARow("CANTREAL") = BDTAREASACTRow("Cantidad Tarea Realizada")
        NEWTAREARow("TIEMPOSTD") = BDTAREASACTRow("Tiempo Estándar Tarea Ua")
        NEWTAREARow("TIEMPOPREV") = BDTAREASACTRow("Tiempo Prevista")
        NEWTAREARow("TIEMPOREAL") = BDTAREASACTRow("Tiempo Realizada")
        FORMAGE.ORDENESDataSet.TAREAS.Rows.Add(NEWTAREARow)
    End Sub
    Private Sub GRABA_ORDINAL()
        NewOrdinalRow = FORMAGE.ORDENESDataSet.ORDENES.NewORDENESRow

        'CAMPOS DE OT INTERNA
        NewOrdinalRow("ID_GESTION") = 0
        NewOrdinalRow("ID_TRABAJO") = 0
        NewOrdinalRow("SECTOROPE") = "MANTENIMIENTO"
        NewOrdinalRow("PRIORIDAD") = "ALTA"
        NewOrdinalRow("ESQU1") = ""
        NewOrdinalRow("ESQU2") = ""

        'CAMPOS EN BASE DE DATOS DE ORDINALES
        NewOrdinalRow("NRO_ORDINAL") = BDTAREASACTRow("Nro Ordinal")
        NewOrdinalRow("TIPO") = Trim(BDTAREASACTRow("Tipo"))
        NewOrdinalRow("SECTORDESTINO") = Trim(BDTAREASACTRow("Sector"))
        NewOrdinalRow("FECHASOL") = BDTAREASACTRow("Ingreso")
        NewOrdinalRow("FECHAINGRESO") = BDTAREASACTRow("Ingreso")
        NewOrdinalRow("FECHAINICIO") = BDTAREASACTRow("Inicio De Trabajo")
        NewOrdinalRow("FECHAFIN") = BDTAREASACTRow("Fin De Trabajo")


        NewOrdinalRow("FECHAAGEND") = CDate(BDTAREASACTRow("Cierre")).ToShortDateString
        NewOrdinalRow("FECHACIERRE") = BDTAREASACTRow("Cierre")

        NewOrdinalRow("STATUS") = BDTAREASACTRow("Status")
        NewOrdinalRow("GENERADOR") = Trim(BDTAREASACTRow("Generacion"))
        NewOrdinalRow("SOLICITANTE") = Trim(BDTAREASACTRow("Permisor"))
        NewOrdinalRow("CUADRILLA") = BDTAREASACTRow("Nombre Ejecutante")
        NewOrdinalRow("NODO") = BDTAREASACTRow("Nodo Abr")
        NewOrdinalRow("ZONA") = BDTAREASACTRow("Zona")
        NewOrdinalRow("CALLE") = BDTAREASACTRow("Nombre Calle")
        NewOrdinalRow("NRO") = BDTAREASACTRow("Nro Puerta")
        NewOrdinalRow("AFECTCLIENTES") = BDTAREASACTRow("Cliafec")
        NewOrdinalRow("AFECTPORCIENTO") = BDTAREASACTRow("%Afectacion")
        NewOrdinalRow("CONTACTONOMBRE") = ""
        NewOrdinalRow("CONTACTOTEL") = ""
        NewOrdinalRow("MOTIVOORIGEN") = BDTAREASACTRow("Desc Falla Origen")

        If Trim(BDTAREASACTRow("Tipo")) = "CORRECTIVO" Then
            NewOrdinalRow("CAUSARIGEN") = "DIAGNOSTICO"
        Else
            If BDTAREASACTRow("Falla Origen") = 886 Then
                NewOrdinalRow("CAUSARIGEN") = "DESCANSO"
            Else
                NewOrdinalRow("CAUSARIGEN") = Trim(BDTAREASACTRow("Desc Causa Origen"))
            End If
        End If

        If Trim(BDTAREASACTRow("Tipo")) = "CORRECTIVO" Then NewOrdinalRow("SECTORGEN") = "CO"

        NewOrdinalRow("MOTIVOCIERRE") = BDTAREASACTRow("Desc Falla Cierre")
        NewOrdinalRow("ACTIVIDAD") = BDTAREASACTRow("Actividad Agenda Desc")
        NewOrdinalRow("CAUSACIERRE") = Trim(BDTAREASACTRow("Desc Causa Cierre"))

        If IsDBNull(BDTAREASACTRow("Instalación")) = False Then
            NewOrdinalRow("INSTALACIONRUS") = Trim(BDTAREASACTRow("Instalación"))
        Else
            NewOrdinalRow("INSTALACIONRUS") = 0
        End If
        NewOrdinalRow("CARPETA") = BDTAREASACTRow("Mdunro")
        NewOrdinalRow("NOMBREMDU") = BDTAREASACTRow("MduNom")
        NewOrdinalRow("TIEMPOTRABAJO") = BDTAREASACTRow("Tiempo De Trabajo")
        NewOrdinalRow("ORDPRINCIPAL") = BDTAREASACTRow("Ordinal Principal")
        NewOrdinalRow("ORDAPOYADO") = BDTAREASACTRow("Ordinal Apoyado")
        NewOrdinalRow("ORDPADRE") = BDTAREASACTRow("Ordinal Padre")
        NewOrdinalRow("RECLAMOSRED") = BDTAREASACTRow("Reclamos")
        NewOrdinalRow("RECLAMOSMDU") = BDTAREASACTRow("Reclamos Mdu Asoc")
        NewOrdinalRow("RECLAMOSTOT") = BDTAREASACTRow("Reclamos Tot")
        NewOrdinalRow("TPREVISTO") = (TIEMP_TARPREV * 5 + 20) * 100 / 450
        NewOrdinalRow("TPREVISTO_UT") = TIEMP_TARPREV
        NewOrdinalRow("TREALIZADO") = TIEMP_TARREAL

        FORMAGE.ORDENESDataSet.ORDENES.Rows.Add(NewOrdinalRow)

        'VUELVE LAS VARIABLES A 0
        TIEMP_TARPREV = 0
        TIEMP_TARREAL = 0

    End Sub
    Private Sub EDITA_ORDINAL()
        'EDITA ORDENINTERNA
        ORDENACTRow("NRO_ORDINAL") = BDTAREASACTRow("Nro Ordinal")
        ORDENACTRow("FECHAINICIO") = BDTAREASACTRow("Inicio De Trabajo")
        ORDENACTRow("FECHAFIN") = BDTAREASACTRow("Fin De Trabajo")
        ORDENACTRow("FECHAAGEND") = CDate(BDTAREASACTRow("Cierre")).ToShortDateString
        ORDENACTRow("FECHACIERRE") = BDTAREASACTRow("Cierre")
        ORDENACTRow.STATUS = BDTAREASACTRow("Status")
        ORDENACTRow("CUADRILLA") = BDTAREASACTRow("Nombre Ejecutante")
        ORDENACTRow("AFECTCLIENTES") = BDTAREASACTRow("Cliafec")
        ORDENACTRow("AFECTPORCIENTO") = BDTAREASACTRow("%Afectacion")

        If Trim(BDTAREASACTRow("Tipo")) = "CORRECTIVO" Then
            ORDENACTRow("CAUSARIGEN") = "DIAGNOSTICO"
        Else
            If BDTAREASACTRow("Falla Origen") = 886 Then
                ORDENACTRow("CAUSARIGEN") = "DESCANSO"
            Else
                ORDENACTRow("CAUSARIGEN") = Trim(BDTAREASACTRow("Desc Causa Origen"))
            End If
        End If

        ORDENACTRow("MOTIVOCIERRE") = BDTAREASACTRow("Desc Falla Cierre")
        ORDENACTRow("ACTIVIDAD") = BDTAREASACTRow("Actividad Agenda Desc")
        ORDENACTRow("CAUSACIERRE") = Trim(BDTAREASACTRow("Desc Causa Cierre"))
        ORDENACTRow("CARPETA") = BDTAREASACTRow("Mdunro")
        ORDENACTRow("NOMBREMDU") = BDTAREASACTRow("MduNom")
        ORDENACTRow("TIEMPOTRABAJO") = BDTAREASACTRow("Tiempo De Trabajo")
        ORDENACTRow("ORDPRINCIPAL") = BDTAREASACTRow("Ordinal Principal")
        ORDENACTRow("ORDAPOYADO") = BDTAREASACTRow("Ordinal Apoyado")
        ORDENACTRow("ORDPADRE") = BDTAREASACTRow("Ordinal Padre")
        ORDENACTRow("RECLAMOSRED") = BDTAREASACTRow("Reclamos")
        ORDENACTRow("RECLAMOSMDU") = BDTAREASACTRow("Reclamos Mdu Asoc")
        ORDENACTRow("RECLAMOSTOT") = BDTAREASACTRow("Reclamos Tot")
        ORDENACTRow("TPREVISTO") = (TIEMP_TARPREV * 5 + 20) * 100 / 450
        ORDENACTRow("TPREVISTO_UT") = TIEMP_TARPREV
        ORDENACTRow("TREALIZADO") = TIEMP_TARREAL

        'VUELVE LAS VARIABLES A 0
        TIEMP_TARPREV = 0
        TIEMP_TARREAL = 0

        Try
            FORMAGE.ORDENESTableAdapter.Update(ORDENACTRow)

        Catch TRANCA As Exception
            MsgBox("EL ORDINAL " & ORDENACTRow("NRO_ORDINAL") & " NO SE HA GRABADO, REPROCESE AL FINALIZAR")
        End Try

        ''AQUI SE PUEDE CARGAR UN AVISO PARA EL INICIADOR DE LA GESTION
        'DATOS.TRABAJOSTableAdapter.FillByID_TRABAJO(DATOS.ORDENESDataSet.TRABAJOS, ORDENACTRow("ID_TRABAJO"))

        'If DATOS.ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
        '    GENERADORGEST = DATOS.ORDENESDataSet.TRABAJOS.Rows(0).Item("GENERADOX")
        '    TIPOGESTION = DATOS.ORDENESDataSet.TRABAJOS.Rows(0).Item("TIPOTRABAJO")
        'Else
        '    GENERADORGEST = ORDENACTRow("GENERADOR")
        '    TIPOGESTION = "SIN TRABAJO DEFINIDO"
        'End If

        'NewMENSAJERow = DATOS.ORDENESDataSet.MENSAJERIA.NewMENSAJERIARow
        'NewMENSAJERow("FECHACREADO") = Now
        'NewMENSAJERow("ASUNTO") = "INFORME ORDINAL FINALIZADO"
        'NewMENSAJERow("ORIGEN_NOMBRE") = "SISTEMA"
        'NewMENSAJERow("DESTINO_NOMBRE") = GENERADORGEST
        'NewMENSAJERow("MENSAJE") = "HA INGRESADO EL ORDINAL NRO " & BDTAREASACTRow("Nro Ordinal") & " CON LA TAREA " & ORDENACTRow("MOTIVOORIGEN") & " en CALLE: " & ORDENACTRow("CALLE") & " NRO: " & ORDENACTRow("NRO") _
        '& " que forma parte deL TRABAJO de " & TIPOGESTION & " solicitada por usted, el mismo se ya encuentra en status " & BDTAREASACTRow("STATUS")
        'NewMENSAJERow("TIPO_ORDENASOC") = "ORDEN INT"
        'NewMENSAJERow("NRO_ORDENASOC") = ORDENINTERNA
        'DATOS.ORDENESDataSet.MENSAJERIA.Rows.Add(NewMENSAJERow)
        'DATOS.ORDENESTableAdapter.Update(NewMENSAJERow)

        'CARGA HISTORICO
        NewHISTORICORow = DATOS.ORDENESDataSet.HISTORICO.NewHISTORICORow
        NewHISTORICORow("ID_ORDENINT") = ORDENINTERNA
        NewHISTORICORow("FECHA") = Now
        NewHISTORICORow("STATUSANTERIOR") = STATUSANTERIOR
        NewHISTORICORow("STATUSACTUAL") = BDTAREASACTRow("Status")
        NewHISTORICORow("CAUSA") = "INGRESO DATOS ORDINAL"
        DATOS.ORDENESDataSet.HISTORICO.Rows.Add(NewHISTORICORow)
        DATOS.HISTORICOTableAdapter.Update(NewHISTORICORow)
    End Sub
    Private Sub GRABAR_PROCESOS()
        'GRABA LA TABLA DE ORDINALES COMPLETA
        FORMAGE.ESTADOTXT.Text = "GRABANDO ORDENES"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.ORDENESTableAdapter.Update(FORMAGE.ORDENESDataSet.ORDENES)

        'GRABA TAREAS
        FORMAGE.ESTADOTXT.Text = "GRABANDO TAREAS"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.TAREASTableAdapter.Update(FORMAGE.ORDENESDataSet.TAREAS)

        'GRABA OBSERVACIONES
        FORMAGE.ESTADOTXT.Text = "GRABANDO OBSERVACIONES"
        FORMAGE.ESTADOTXT.Refresh()
        FORMAGE.OBESERVACIONESTableAdapter.Update(FORMAGE.ORDENESDataSet.OBESERVACIONES)

        If FORMAGE.ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            FORMAGE.BOT_CALCULATOTDIA.Enabled = True
        End If
        FORMAGE.AVANCE.Value = 0

        FORMAGE.CANT_ORDING.Refresh()
        FORMAGE.CANT_ORDEDIT.Refresh()
        FORMAGE.CANT_TAREASING.Refresh()
        FORMAGE.CANT_OBSING.Refresh()

        FORMAGE.Cursor = Cursors.Default
        FORMAGE.ESTADOTXT.Text = "FIN PROCESO"

    End Sub
    Private Sub CARGA_VARIABLES(VAL_CAUSA As Integer)
        If Trim(ORDINALRow.CAUSARIGEN) = Trim(CAUSASRow.DESCCAUSA) Then
            For SEC = 1 To 4
                Select Case Trim(ORDINALRow.SECTORDESTINO)
                    Case SECTOR(SEC)
                        CANT(SEC, VAL_CAUSA) += 1
                        PREV(SEC, VAL_CAUSA) += ORDINALRow("TPREVISTO_UT")
                        REAL(SEC, VAL_CAUSA) += ORDINALRow("TREALIZADO")
                        If IsDBNull(ORDINALRow("TIEMPOTRABAJO")) = False Then
                            TIEM(SEC, VAL_CAUSA) += ORDINALRow("TIEMPOTRABAJO")
                        Else
                            TIEM(SEC, VAL_CAUSA) += 0
                        End If
                End Select
            Next
        End If
    End Sub
    Private Sub DISTRIBUYE_VARIABLES()
        FORMAGE.ORDENESTableAdapter.FillByFECHAYSTATUS(FORMAGE.ORDENESDataSet.ORDENES, FECHAINI, FECHAINI.AddDays(1), "FINALIZADO")
        FORMAGE.ESTADOTXT.Text = ""
        FORMAGE.Cursor = Cursors.WaitCursor

        'CARGA LAS VARIABLES DE SECTOR
        SECTOR(1) = "RED"
        SECTOR(2) = "MDU"
        SECTOR(3) = "CUADRILLAS DE RED"
        SECTOR(4) = "CUADRILLAS MDU"
        SECTOR(5) = "OBRA CIVIL"
        SECTOR(6) = "PLANIFICACION TECNICA"
        'BORRA LAS COORDENADAS
        For I = 1 To 6
            For X = 1 To 10
                TIEM(I, X) = "0000"
                CANT(I, X) = 0
                PREV(I, X) = 0
                REAL(I, X) = 0
            Next
        Next

        FORMAGE.CAUSASTableAdapter.FillByTIPOCAUSA(FORMAGE.ORDENESDataSet.CAUSAS)

        For I = 0 To FORMAGE.ORDENESDataSet.ORDENES.Rows.Count - 1
            ORDINALRow = FORMAGE.ORDENESDataSet.ORDENES.Rows(I)
            Select Case ORDINALRow.TIPO
                Case "CORRECTIVO"
                    For SEC = 1 To 4
                        Select Case Trim(ORDINALRow.SECTORDESTINO)
                            Case SECTOR(SEC)
                                CANT(SEC, 1) += 1
                                PREV(SEC, 1) += ORDINALRow("TPREVISTO_UT")
                                REAL(SEC, 1) += ORDINALRow("TREALIZADO")
                                If IsDBNull(ORDINALRow("TIEMPOTRABAJO")) = False Then
                                    TIEM(SEC, 1) += ORDINALRow("TIEMPOTRABAJO")
                                Else
                                    TIEM(SEC, 1) += 0
                                End If
                        End Select
                    Next 'DIAGNOSTICO
                Case "TAREA"
                    For C = 0 To FORMAGE.ORDENESDataSet.CAUSAS.Rows.Count - 1
                        CAUSASRow = FORMAGE.ORDENESDataSet.CAUSAS.Rows(C)
                        Select Case CAUSASRow.TIPO_ORDINAL
                            Case "ASOC CORRECTIVO"              'TAREAS ASOC CORRECTIVOS
                                CARGA_VARIABLES(2)
                            Case "PREDICTIVO"                  'MANTENIMIENTO PREDICTIVO
                                CARGA_VARIABLES(4)
                            Case "INACTIVIDAD"                  'INACTIVIDAD
                                CARGA_VARIABLES(6)
                            Case "PREVENTIVO"                   'MANTEMINIETO PREVENTIVO
                                CARGA_VARIABLES(3)
                            Case "OBRA CIVIL"                   'OBRA CIVIL
                                CARGA_VARIABLES(5)
                            Case Else
                                MsgBox("ENTRO EN " & CAUSASRow.TIPO_ORDINAL & "  Y LA DESC CASUSA ES  " & CAUSASRow.DESCCAUSA)
                        End Select
                    Next
                Case "OBRAS"
                    For SEC = 1 To 4
                        Select Case ORDINALRow.SECTORDESTINO
                            Case SECTOR(SEC)
                                CANT(SEC, 5) = CANT(SEC, 5) + 1
                                PREV(SEC, 5) = PREV(SEC, 5) + Int(CDbl(ORDINALRow("TPREVISTO_UT")))
                                REAL(SEC, 5) = REAL(SEC, 5) + Int(CDbl(ORDINALRow("TREALIZADO")))
                                TIEM(SEC, 5) = TIEM(SEC, 5) + CDbl(ORDINALRow("TIEMPOTRABAJO"))
                        End Select
                    Next
            End Select
        Next
    End Sub
    Public Sub CALCULA_TOTALDIA()

        DISTRIBUYE_VARIABLES()

        FORMAGE.TOTAL_XDIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA, FECHAINI)
        If FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows.Count > 0 Then
            For I = 1 To 6
                TOTALxDIARow = FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows(I - 1)
                TOTALxDIARow("CANT_DIAG") = CANT(I, 1)
                TOTALxDIARow("PREV_DIAG") = PREV(I, 1)
                TOTALxDIARow("REAL_DIAG") = REAL(I, 1)
                If TIEM(I, 1) <> "0000" Then
                    TOTALxDIARow("TIEMPO_DIAG") = Int(TIEM(I, 1) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_DIAG") = ""
                End If

                TOTALxDIARow("CANT_ASOCORR") = CANT(I, 2)
                TOTALxDIARow("PREV_ASOCORR") = PREV(I, 2)
                TOTALxDIARow("REAL_ASOCORR") = REAL(I, 2)
                If TIEM(I, 2) <> "0000" Then
                    TOTALxDIARow("TIEMPO_ASOCORR") = Int(TIEM(I, 2) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_ASOCORR") = ""
                End If

                TOTALxDIARow("CANT_ASOPREV") = CANT(I, 3)
                TOTALxDIARow("PREV_ASOPREV") = PREV(I, 3)
                TOTALxDIARow("REAL_ASOPREV") = REAL(I, 3)
                If TIEM(I, 3) <> "0000" Then
                    TOTALxDIARow("TIEMPO_ASOPREV") = Int(TIEM(I, 3) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_ASOPREV") = ""
                End If

                TOTALxDIARow("CANT_ASOPRED") = CANT(I, 4)
                TOTALxDIARow("PREV_ASOPRED") = PREV(I, 4)
                TOTALxDIARow("REAL_ASOPRED") = REAL(I, 4)
                If TIEM(I, 4) <> "0000" Then
                    TOTALxDIARow("TIEMPO_ASOPRED") = Int(TIEM(I, 4) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_ASOPRED") = ""
                End If

                TOTALxDIARow("CANT_OBRAS") = CANT(I, 5)
                TOTALxDIARow("PREV_OBRAS") = PREV(I, 5)
                TOTALxDIARow("REAL_OBRAS") = REAL(I, 5)
                If TIEM(I, 5) <> "0000" Then
                    TOTALxDIARow("TIEMPO_OBRAS") = Int(TIEM(I, 5) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_OBRAS") = ""
                End If
                TOTALxDIARow("CANT_DESC") = CANT(I, 6)
                TOTALxDIARow("PREV_DESC") = PREV(I, 6)
                TOTALxDIARow("REAL_DESC") = REAL(I, 6)
                If TIEM(I, 6) <> "0000" Then
                    TOTALxDIARow("TIEMPO_DESC") = Int(TIEM(I, 6) * 24 * 12)
                Else
                    TOTALxDIARow("TIEMPO_DESC") = ""
                End If
                FORMAGE.TOTAL_XDIATableAdapter.Update(TOTALxDIARow)
            Next

        Else
            For I = 1 To 6
                NewTotalxDiaRow = FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.NewTOTAL_XDIARow
                NewTotalxDiaRow("FECHA") = FECHAINI.ToShortDateString
                NewTotalxDiaRow("SECTOR") = SECTOR(I)

                NewTotalxDiaRow("CANT_DIAG") = CANT(I, 1)
                NewTotalxDiaRow("PREV_DIAG") = PREV(I, 1)
                NewTotalxDiaRow("REAL_DIAG") = REAL(I, 1)
                If TIEM(I, 1) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_DIAG") = Int(TIEM(I, 1) * 24 * 12)
                Else
                    NewTotalxDiaRow("TIEMPO_DIAG") = ""
                End If

                NewTotalxDiaRow("CANT_ASOCORR") = CANT(I, 2)
                NewTotalxDiaRow("PREV_ASOCORR") = PREV(I, 2)
                NewTotalxDiaRow("REAL_ASOCORR") = REAL(I, 2)
                If TIEM(I, 2) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_ASOCORR") = Int(TIEM(I, 2) * 24 * 12)
                Else
                    NewTotalxDiaRow("TIEMPO_ASOCORR") = ""
                End If

                NewTotalxDiaRow("CANT_ASOPREV") = CANT(I, 3)
                NewTotalxDiaRow("PREV_ASOPREV") = PREV(I, 3)
                NewTotalxDiaRow("REAL_ASOPREV") = REAL(I, 3)
                If TIEM(I, 3) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_ASOPREV") = Int(TIEM(I, 3) * 24 * 12)
                Else
                    NewTotalxDiaRow("TIEMPO_ASOPREV") = ""
                End If

                NewTotalxDiaRow("CANT_ASOPRED") = CANT(I, 4)
                NewTotalxDiaRow("PREV_ASOPRED") = PREV(I, 4)
                NewTotalxDiaRow("REAL_ASOPRED") = REAL(I, 4)
                If TIEM(I, 4) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_ASOPRED") = Int(TIEM(I, 4) * 24 * 12)
                Else
                    NewTotalxDiaRow("TIEMPO_ASOPRED") = ""
                End If

                NewTotalxDiaRow("CANT_OBRAS") = CANT(I, 5)
                NewTotalxDiaRow("PREV_OBRAS") = PREV(I, 5)
                NewTotalxDiaRow("REAL_OBRAS") = REAL(I, 5)
                If TIEM(I, 5) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_OBRAS") = Int(TIEM(I, 5) * 24 * 12) 'calcula tiempo en horas
                Else
                    NewTotalxDiaRow("TIEMPO_OBRAS") = ""
                End If
                NewTotalxDiaRow("CANT_DESC") = CANT(I, 6)
                NewTotalxDiaRow("PREV_DESC") = PREV(I, 6)
                NewTotalxDiaRow("REAL_DESC") = REAL(I, 6)
                If TIEM(I, 6) <> "0000" Then
                    NewTotalxDiaRow("TIEMPO_DESC") = Int(TIEM(I, 6) * 24 * 12)
                Else
                    NewTotalxDiaRow("TIEMPO_DESC") = ""
                End If


                NewTotalxDiaRow.CANT_TAREASPROC = CANT_TAREASINGRE
                NewTotalxDiaRow.CANT_ORDINALESING = CANT_ORDINGRE
                NewTotalxDiaRow.CANT_OBSERVACIONESING = CANT_OBSINGRE
                NewTotalxDiaRow.CANT_ORDINALESEDIT = CANT_ORDEDITA

                FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.AddTOTAL_XDIARow(NewTotalxDiaRow)
            Next

        End If

        Try
            FORMAGE.TOTAL_XDIATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA)
            NOTIFICACION("SYS", "TOTAL POR DIA ACTUALIZADO")
        Catch ex As Exception
            NOTIFICACION("SYS", "ERROR EN EL PROCESO")
        End Try

        FORMAGE.Cursor = Cursors.Default

    End Sub
    Public Sub CALCULA_TOTALXDIA()
        FORMAGE.ESTADOTXT.Text = ""
        FORMAGE.Cursor = Cursors.WaitCursor

        FORMAGE.TOTAL_XDIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA, FECHAINI)
        If FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows.Count = 0 Then
            CALCULA_TOTALDIA()
            FORMAGE.TOTAL_XDIATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA)
        Else
            For i = 0 To FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows.Count - 1
                ELIMINARow = FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA.Rows(i)
                ELIMINARow.Delete()
                'TOTAL_XDIATableAdapter.Update(ELIMINARow)
            Next
            FORMAGE.TOTAL_XDIATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA)
            CALCULA_TOTALDIA()
            FORMAGE.TOTAL_XDIATableAdapter.Update(FORMAGE.ANALISIS_AGDataSet.TOTAL_XDIA)
        End If

        RESUMEN_DIARIO()
        'EDITA LA TABLA DE REGDIARIO

        FORMAGE.REG_DIARIORow.UT_TRASINIFIN = UT_PERD
        FORMAGE.REG_DIARIORow("UTTOTAL_CORR") = UTTOTAL_CORR
        FORMAGE.REG_DIARIORow("UTTOTAL_PREV") = UTOTAL_PREV
        FORMAGE.REG_DIARIORow("UTTOTAL_PRED") = UTTOTAL_PRED
        FORMAGE.REG_DIARIORow("UTTOTAL_OBRAS") = UTTOTAL_OBRAS
        FORMAGE.REG_DIARIORow("UTTOTAL_DESC") = UTTOTAL_DESC
        FORMAGE.REG_DIARIORow("UTTOTAL_RED") = TOTGEN_RED
        FORMAGE.REG_DIARIORow("UTTOTAL_MDU") = TOTGEN_MDU
        FORMAGE.REG_DIARIORow("Ut_DISPONIBLES") = UT_DISPONIBLES
        FORMAGE.REG_DIARIORow("UT_UTILIZADAS") = UT_UTILIZADAS
        FORMAGE.REG_DIARIORow("TOTGEN_RED") = TOTGEN_RED
        FORMAGE.REG_DIARIORow("TOTGEN_MDU") = TOTGEN_MDU

        FORMAGE.REG_DIARIORow("CANT_PROCESADOS") = CANT_PROCESADOS
        FORMAGE.REG_DIARIORow("CANT_ORDING") = CANT_ORDINGRE
        FORMAGE.REG_DIARIORow("CANT_ORDEDIT") = CANT_ORDEDITA
        FORMAGE.REG_DIARIORow("CANT_TARING") = CANT_TAREASINGRE
        FORMAGE.REG_DIARIORow("CANT_OBSING") = CANT_OBSINGRE

        FORMAGE.REG_DIARIORow("IND1CORR") = RELREAL_STD(1)
        FORMAGE.REG_DIARIORow("IND1PREV") = RELREAL_STD(2)
        FORMAGE.REG_DIARIORow("IND1PRED") = RELREAL_STD(3)
        FORMAGE.REG_DIARIORow("IND1OBRAS") = RELREAL_STD(4)
        FORMAGE.REG_DIARIORow("IND1DESC") = RELREAL_STD(5)
        FORMAGE.REG_DIARIORow("IND1GEN") = RELREAL_STD(6)

        FORMAGE.REG_DIARIORow("IND2CORR") = RELTIEM_REAL(1)
        FORMAGE.REG_DIARIORow("IND2PREV") = RELTIEM_REAL(2)
        FORMAGE.REG_DIARIORow("IND2PRED") = RELTIEM_REAL(3)
        FORMAGE.REG_DIARIORow("IND2OBRAS") = RELTIEM_REAL(4)
        FORMAGE.REG_DIARIORow("IND2DESC") = RELTIEM_REAL(5)
        FORMAGE.REG_DIARIORow("IND2GEN") = RELTIEM_REAL(6)

        'FORMAGE.Validate()
        'GRABA LA TABLA DE REGISTRO DIARIO
        Try
            FORMAGE.REG_DIARIOTableAdapter.Update(FORMAGE.REG_DIARIORow)
        Catch ex As Exception

        End Try

        CALCULA_AGENDA()
        FORMAGE.Cursor = Cursors.Default
    End Sub
    Private Sub CALCULA_AGENDA()
        'CALCULA LA CAPACIDAD OCUPADA POR ORDINALES CORRECTIVOS Y ASOCIADOS A CORRECTIVOS   
        Dim TIEMPOTOTAL_CORRECTIVOTEC As Integer
        Dim TIEMPOTOTAL_CORRECTIVOCUA As Integer

        For I = 0 To FORMAGE.ORDENESDataSet.ORDENES.Rows.Count - 1
            ORDENESRow = FORMAGE.ORDENESDataSet.ORDENES.Rows(I)
            Select Case ORDENESRow("TIPO")
                Case "CORRECTIVO"
                    TIEMPOTOTAL_CORRECTIVOTEC = TIEMPOTOTAL_CORRECTIVOTEC + CInt(ORDENESRow("TPREVISTO") * 450 / 100)

                Case Else
                    Select Case ORDENESRow("CAUSARIGEN")
                        Case "CORRECTIVO CUADRICULADO IMAGEN", "CORRECTIVO SIN SEÑAL TOTAL", "CORRECTIVO SIN SEÑAL ALG. FREC"
                            Select Case Trim(ORDENESRow("SECTORDESTINO"))
                                Case "CUADRILLAS MDU", "CUADRILLAS DE RED"
                                    TIEMPOTOTAL_CORRECTIVOCUA = TIEMPOTOTAL_CORRECTIVOCUA + CInt(ORDENESRow("TPREVISTO") * 450 / 100)
                                Case Else
                                    TIEMPOTOTAL_CORRECTIVOTEC = TIEMPOTOTAL_CORRECTIVOTEC + CInt(ORDENESRow("TPREVISTO") * 450 / 100)
                            End Select
                    End Select
            End Select
        Next
        'LLAMA A LA TABLA CAPACIDAD DE AGENDA DEL DIA TRATADO
        FORMAGE.CAPACIDAXDIATableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.CAPACIDAXDIA, FECHAINI.ToShortDateString)
        CAPACIDADRow = FORMAGE.ANALISIS_AGDataSet.CAPACIDAXDIA.Rows(0)
        CAPACIDADRow("MIN_ALT_TEC_CO_AGE") = TIEMPOTOTAL_CORRECTIVOTEC
        CAPACIDADRow("MIN_ALT_CUA_CO_AGE") = TIEMPOTOTAL_CORRECTIVOCUA
        FORMAGE.CAPACIDAXDIATableAdapter.Update(CAPACIDADRow)

    End Sub
    Public Sub RESUMEN_DIARIO()
        DISTRIBUYE_VARIABLES()



        'CORRECTIVOS
        '___________________________________________________________________________________________________________________________
        TRASCORR_RED = CANT(1, 1) * 4 + CANT(1, 2) * 4 + CANT(3, 2) * 4 + CANT(5, 2) * 4
        TRABCORR_RED = CDbl(PREV(1, 1)) + CDbl(PREV(1, 2)) + CDbl(PREV(3, 2)) + CDbl(PREV(5, 2))

        TRASCORR_MDU = CANT(2, 1) * 4 + CANT(4, 2) * 4 + CANT(2, 2) * 4
        TRABCORR_MDU = CDbl(PREV(2, 1)) + CDbl(PREV(2, 2)) + CDbl(PREV(4, 2))
        TIEM_REAL(1) = CDbl(TIEM(1, 1)) + CDbl(TIEM(1, 2)) + CDbl(TIEM(3, 2)) + CDbl(TIEM(2, 1)) + CDbl(TIEM(2, 2)) + CDbl(TIEM(4, 2))

        TRABSTD_REAL(1) = CDbl(REAL(1, 1)) + CDbl(REAL(1, 2)) + CDbl(REAL(3, 2)) + REAL(5, 2) + CDbl(REAL(2, 1)) + CDbl(REAL(2, 2)) + CDbl(REAL(4, 2))

        TRABSTD_PREV(1) = CDbl(TRABCORR_RED) + CDbl(TRABCORR_MDU)
        RELREAL_STD(1) = TRABSTD_REAL(1) / (CDbl(TRABCORR_RED) + CDbl(TRABCORR_MDU))
        RELTIEM_REAL(1) = TRABSTD_REAL(1) / (TIEM_REAL(1) * 24 * 12)

        IND1CORR = FormatPercent(RELREAL_STD(1))
        IND2CORR = FormatPercent(RELTIEM_REAL(1))

        UTTOTAL_CORR = CDbl(TRABCORR_RED) + CDbl(TRABCORR_MDU) + CDbl(TRASCORR_RED) + CDbl(TRASCORR_MDU)
        ''____________________________________________________________________________________________________________________________



        ''PREVENTIVOS
        ''________________________________________________________________________________________________________________________________
        TRASPREV_RED = CANT(1, 2) * 4 + CANT(3, 2) * 4
        TRABPREV_RED = PREV(1, 2) + PREV(3, 2)
        TRASPREV_MDU = CANT(2, 2) * 4 + CANT(4, 2) * 4

        TRABPREV_MDU = PREV(2, 3) + PREV(4, 3)
        TIEM_REAL(2) = TIEM(1, 3) + TIEM(3, 3) + TIEM(2, 3) + TIEM(4, 3)

        TRABSTD_REAL(2) = CDbl(REAL(1, 3)) + CDbl(REAL(3, 3)) + CDbl(REAL(2, 3)) + CDbl(REAL(4, 3))
        TRABSTD_PREV(2) = CDbl(TRABPREV_RED) + CDbl(TRABPREV_MDU)
        RELREAL_STD(2) = TRABSTD_REAL(2) / (CDbl(TRABPREV_RED) + CDbl(TRABPREV_MDU))
        RELTIEM_REAL(2) = TRABSTD_REAL(2) / (TIEM_REAL(2) * 24 * 12)

        IND1PREV = FormatPercent(RELREAL_STD(2))
        IND2PREV = FormatPercent(RELTIEM_REAL(2))

        UTOTAL_PREV = CDbl(TRASPREV_RED) + CDbl(TRABPREV_RED) + CDbl(TRASPREV_MDU) + CDbl(TRABPREV_MDU)
        '_______________________________________________________________________________________________________________________



        'PREDICTIVOS
        '_______________________________________________________________________________________________________________________
        TRASPRED_RED = CANT(1, 4) * 4 + CANT(3, 4) * 4
        TRABPRED_RED = CDbl(PREV(1, 4)) + CDbl(PREV(3, 4))
        TRASPRED_MDU = CANT(2, 4) * 4 + CANT(4, 4) * 4
        TRABPRED_MDU = CDbl(PREV(2, 4)) + CDbl(PREV(4, 4))
        TIEM_REAL(3) = CDbl(TIEM(1, 4)) + CDbl(TIEM(3, 4)) + CDbl(TIEM(2, 4)) + CDbl(TIEM(4, 4))

        TRABSTD_REAL(3) = CDbl(REAL(1, 4)) + CDbl(REAL(3, 4)) + CDbl(REAL(2, 4)) + CDbl(REAL(4, 4))
        TRABSTD_PREV(3) = CDbl(TRABPRED_RED) + CDbl(TRABPRED_MDU)
        RELREAL_STD(3) = TRABSTD_REAL(3) / (CDbl(TRABPRED_RED) + CDbl(TRABPRED_MDU))
        RELTIEM_REAL(3) = TRABSTD_REAL(3) / (TIEM_REAL(3) * 24 * 12)

        IND1PRED = FormatPercent(RELREAL_STD(3))
        IND2PRED = FormatPercent(RELTIEM_REAL(3))

        UTTOTAL_PRED = CDbl(TRASPRED_RED) + CDbl(TRABPRED_RED) + CDbl(TRASPRED_MDU) + CDbl(TRABPRED_MDU)

        ''OBRAS
        ''________________________________________________________________________________________________________________________
        TRASOBRA_RED = CANT(1, 5) * 4
        TRABOBRA_RED = CDbl(PREV(1, 5))
        TRASOBRA_MDU = CANT(2, 5) * 4 + CANT(5, 5) * 4 + CANT(4, 5) * 4

        TRABOBRA_MDU = CDbl(PREV(2, 5)) + CDbl(PREV(5, 5)) + CDbl(PREV(4, 5))
        TIEM_REAL(4) = CDbl(TIEM(1, 5)) + CDbl(TIEM(2, 5)) + CDbl(TIEM(5, 5)) + CDbl(TIEM(4, 5))

        TRABSTD_REAL(4) = CDbl(REAL(1, 5)) + CDbl(REAL(2, 5)) + CDbl(REAL(5, 5)) + CDbl(REAL(4, 5))
        TRABSTD_PREV(4) = CDbl(TRABOBRA_RED) + CDbl(TRABOBRA_MDU)
        RELREAL_STD(4) = TRABSTD_REAL(4) / TRABSTD_PREV(4)
        RELTIEM_REAL(4) = TRABSTD_REAL(4) / (TIEM_REAL(4) * 24 * 12)

        IND1OBRAS = FormatPercent(RELREAL_STD(4))
        IND2OBRAS = FormatPercent(RELTIEM_REAL(4))

        UTTOTAL_OBRAS = CDbl(TRASOBRA_RED) + CDbl(TRABOBRA_RED) + CDbl(TRASOBRA_MDU) + CDbl(TRABOBRA_MDU)
        ''_________________________________________________________________________________________________________________________

        ''DESCANSO
        ''__________________________________________________________________________________________________________________________

        TRASDESC_RED = CANT(1, 6) * 4 + CANT(3, 6) * 4
        TRABDESC_RED = CDbl(PREV(1, 6)) + CDbl(PREV(3, 6))
        TRASDESC_MDU = CANT(2, 6) * 4 + CANT(4, 6) * 4
        TRABDESC_MDU = CDbl(PREV(2, 6)) + CDbl(PREV(4, 6))
        TIEM_REAL(5) = CDbl(TIEM(1, 6)) + CDbl(TIEM(2, 6)) + CDbl(TIEM(3, 6)) + CDbl(TIEM(4, 6))

        TRABSTD_REAL(5) = CDbl(REAL(1, 6)) + CDbl(REAL(2, 6)) + CDbl(REAL(3, 6)) + CDbl(REAL(4, 6))


        TRABSTD_PREV(5) = CDbl(TRABDESC_RED) + CDbl(TRABDESC_MDU)
        RELREAL_STD(5) = TRABSTD_REAL(5) / TRABSTD_PREV(5)

        RELTIEM_REAL(5) = TRABSTD_REAL(5) / (TIEM_REAL(5) * 24 * 12)

        IND1DESC = FormatPercent(RELREAL_STD(5))
        IND2DESC = FormatPercent(RELTIEM_REAL(5))

        UTTOTAL_DESC = CDbl(TRASDESC_RED) + CDbl(TRABDESC_RED) + CDbl(TRASDESC_MDU) + CDbl(TRABDESC_MDU)

        '___________________________________________________________________________________________________________________________

        'TOTAL GENERAL (INDICES DEL DIA)
        '___________________________________________________________________________________________________________________________
        TOTTRAS_RED = CDbl(TRASCORR_RED) + CDbl(TRASPREV_RED) + CDbl(TRASPRED_RED) + CDbl(TRASOBRA_RED) + CDbl(TRASDESC_RED)
        TOTTRAB_RED = CDbl(TRABCORR_RED) + CDbl(TRABPREV_RED) + CDbl(TRABPRED_RED) + CDbl(TRABOBRA_RED) + CDbl(TRABDESC_RED)
        TOTTRAS_MDU = CDbl(TRASCORR_MDU) + CDbl(TRASPREV_MDU) + CDbl(TRASPRED_MDU) + CDbl(TRASOBRA_MDU) + CDbl(TRASDESC_MDU)
        TOTTRAB_MDU = CDbl(TRABCORR_MDU) + CDbl(TRABPREV_MDU) + CDbl(TRABPRED_MDU) + CDbl(TRABOBRA_MDU) + CDbl(TRABDESC_MDU)


        TOTGEN_RED = CDbl(TOTTRAS_RED) + CDbl(TOTTRAB_RED)
        TOTGEN_MDU = CDbl(TOTTRAS_MDU) + CDbl(TOTTRAB_MDU)

        UTOTAL_GEN = CDbl(TOTGEN_RED) + CDbl(TOTGEN_MDU)

        For I = 1 To 5
            TIEM_REAL(6) = CDbl(TIEM_REAL(6)) + CDbl(TIEM_REAL(I))
            TRABSTD_REAL(6) = CDbl(TRABSTD_REAL(6)) + CDbl(TRABSTD_REAL(I))
            TRABSTD_PREV(6) = CDbl(TRABSTD_PREV(6)) + CDbl(TRABSTD_PREV(I))
        Next I


        RELTIEM_REAL(6) = TRABSTD_REAL(6) / (TIEM_REAL(6) * 24 * 12)
        RELREAL_STD(6) = TRABSTD_REAL(6) / TRABSTD_PREV(6)



        IND1GEN = FormatPercent(RELREAL_STD(6))

        IND2GEN = FormatPercent(RELTIEM_REAL(6))

        PORCCORR = FormatPercent(UTTOTAL_CORR / UTOTAL_GEN)
        PORCPREV = FormatPercent(UTOTAL_PREV / UTOTAL_GEN)
        PORCPRED = FormatPercent(UTTOTAL_PRED / UTOTAL_GEN)
        PORCOBRAS = FormatPercent(UTTOTAL_OBRAS / UTOTAL_GEN)
        PORCDESC = FormatPercent(UTTOTAL_DESC / UTOTAL_GEN)
        PORCRED_GEN = FormatPercent(TOTGEN_RED / UTOTAL_GEN)
        PORCMDU_GEN = FormatPercent(TOTGEN_MDU / UTOTAL_GEN)

        FORMAGE.REG_DIARIOTableAdapter.FillByFECHA(FORMAGE.ANALISIS_AGDataSet.REG_DIARIO, FECHAINI.ToShortDateString)
        FORMAGE.REG_DIARIORow = FORMAGE.ANALISIS_AGDataSet.REG_DIARIO.Rows(0)
        CAN_TEC = CDbl(FORMAGE.REG_DIARIORow("CANT_TECPRES")) + CDbl(FORMAGE.REG_DIARIORow("CANT_CUADPRES"))
        CANT_UTREAL = CDbl(FORMAGE.REG_DIARIORow("UT_REALTEC")) + CDbl(FORMAGE.REG_DIARIORow("UT_REALCUAD"))
        UT_PERD = CAN_TEC * 8
        UT_DISPONIBLES = CDbl(CANT_UTREAL) - CDbl(UT_PERD)
        UT_UTILIZADAS = UTOTAL_GEN

        OCUPACION = FormatPercent((UT_UTILIZADAS / UT_DISPONIBLES), 0)

        FORMAGE.LBL_OCUPACION_PROCESO.Text = OCUPACION
        FORMAGE.LBL_OCUPACION_PROCESO.Visible = True
        FORMAGE.LBL_TITLE_OCUPACION.Visible = True
        CARGAR_VALORES_TEXTBOX()
    End Sub 'HACE LOS CALCULOS PERO NO GRABA EN BASE DE DATOS.
    Public Sub CARGAR_VALORES_TEXTBOX()
        puntoY = 20
        puntoX = 5
        ' FORMAGE.REG_AUSENCIASTableAdapter.FillByAUSENCIADIA(FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI, "NO")
        '  FORMAGE.CANT_TEC_TEO.Text = CAN_TEC + FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count
        FORMAGE.ORDENESTableAdapter.FillByDISCTINCT_CUADRILLA_FECHAYSTATUS(FORMAGE.OrdenesDataSet1.ORDENES, FECHAINI, FECHAINI.AddDays(1), "FINALIZADO")

        FORMAGE.CANT_TEC_REAL.Text = CAN_TEC
        FORMAGE.MIN_TEC_TEO.Text = FORMAGE.REG_DIARIORow("UT_TEORICATEC")
        FORMAGE.MIN_TEC_REAL.Text = FORMAGE.REG_DIARIORow("UT_ACTIVATEC")


        'CREACION DEL GRAFICO DE OCUPACION POR TECNICOS
        PAINT_TEC = FORMAGE.Panel_TECNICOS.CreateGraphics()
        'BORRAMOS EL GRAFICO
        PAINT_TEC.FillRectangle(BORRAR, 0, 0, FORMAGE.Panel_TECNICOS.Width, FORMAGE.Panel_TECNICOS.Height)

        'TRAEMOS A LOS TECNICOS PRESENTES
        ' FORMAGE.TECNICOSTableAdapter.Fill(FORMAGE.AnalisiS_AGDataSet1.TECNICOS)

        Dim TOTAL_TPREV As Integer 'CANTIDAD DE TIEMPO SEGUN STANDARD DE TAREAS PREVISTAS
        Dim TOTAL_TSTD As Integer 'CANTIDAD DE TIEMPO SEGUN STANDARD DE TAREAS FINALIZADAS SEGUN TECNICO
        Dim TOTAL_TREAL As Integer ' CANTIDAD DE TIEMPO SEGUN SUMA DE EJECUCIONES DE DEL ORDINAL 
        'DIBUJAMOS A CADA TECNICO
        Dim CANTIDAD_TECS As Integer = FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count
        'DIBUJA LAS RAYAS POR HORA
        For X = 0 To 9
            PAINT_TEC.DrawLine(LAPIZ_GRAY, puntoX + 125 + 12 * X, 0, puntoX + 125 + 12 * X, puntoY * CANTIDAD_TECS - 15)
            PAINT_TEC.DrawString(X, FUENTE_CHICA, Relleno_GRAY, puntoX + 117 + 12 * X, 3)
        Next


        For T = 0 To FORMAGE.OrdenesDataSet1.ORDENES.Rows.Count - 1
            ORDENESRow = FORMAGE.OrdenesDataSet1.ORDENES.Rows(T)
            '  MsgBox(ORDENESRow.CUADRILLA)
            TOTAL_TPREV = 0
            TOTAL_TSTD = 0
            TOTAL_TREAL = 0

            '  FORMAGE.CALCULA_TECNICOS(FECHAINI.ToString("dddd").ToUpper, T)

            'BUSCAMOS LAS ORDENES QUE HA REALIZADO EL TECNICO ESE DIA
            For X = 0 To FORMAGE.ORDENESDataSet.ORDENES.Rows.Count - 1
                If ORDENESRow.CUADRILLA = FORMAGE.ORDENESDataSet.ORDENES.Rows(X).Item("CUADRILLA") Then
                    TOTAL_TREAL += FORMAGE.ORDENESDataSet.ORDENES.Rows(X).Item("TIEMPOTRABAJO") * 24 * 12
                    TOTAL_TPREV += FORMAGE.ORDENESDataSet.ORDENES.Rows(X).Item("TPREVISTO_UT")
                    TOTAL_TSTD += FORMAGE.ORDENESDataSet.ORDENES.Rows(X).Item("TREALIZADO")
                End If
            Next
            '108 ES EL ANCHO DE LAS COLUMNAS YA QUE SON LAS UT QUE HAY EN 9 HORAS
            PAINT_TEC.DrawString(ORDENESRow.CUADRILLA, FUENTE_CHICA, Relleno_NEGRO, puntoX, puntoY + 2)
            FORMAGE.REG_AUSENCIASTableAdapter.FillByFECHAYTEC(FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS, FECHAINI.ToShortDateString, ORDENESRow.CUADRILLA)
            If FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows.Count > 0 Then
                TECNICOS = FORMAGE.ANALISIS_AGDataSet.REG_AUSENCIAS.Rows(0)
                If TECNICOS.HORAS = 0 Then
                    PAINT_TEC.DrawRectangle(LAPIZ_GRAY, puntoX + 125, puntoY, 12 * CInt(TECNICOS.HORAS), 15)
                    PAINT_TEC.DrawString(TECNICOS.MOTIVO, FUENTE_CHICA, Relleno_RED, puntoX + 240, puntoY + 2)
                Else
                    PAINT_TEC.DrawRectangle(Lapiz_Negro, puntoX + 125, puntoY, 12 * CInt(TECNICOS.HORAS), 15)
                End If
            Else

            End If
            PAINT_TEC.FillRectangle(Relleno_GREEN, puntoX + 125, puntoY, CInt(TOTAL_TREAL), 5)
            PAINT_TEC.FillRectangle(Relleno_YELLOW, puntoX + 125, puntoY + 5, CInt(TOTAL_TPREV), 5)
            PAINT_TEC.FillRectangle(Relleno_RED, puntoX + 125, puntoY + 10, CInt(TOTAL_TSTD), 5)
            puntoY += 18

        Next
        PAINT_TEC.DrawString("REFERENCIAS:", FUENTE_CHICA, Relleno_NEGRO, puntoX + 20, puntoY)
            PAINT_TEC.FillRectangle(Relleno_GREEN, puntoX, puntoY + 2 + 16, 30, 5)
            PAINT_TEC.DrawString("CANTIDAD DE TIEMPO SEGUN SUMA DE EJECUCIONES DEL ORDINAL", FUENTE_CHICA, Relleno_NEGRO, puntoX + 30, puntoY + 16)
            PAINT_TEC.FillRectangle(Relleno_YELLOW, puntoX, puntoY + 2 + 16 * 2, 30, 5)
            PAINT_TEC.DrawString("CANTIDAD DE TIEMPO SEGUN STANDARD DE TAREAS PREVISTAS", FUENTE_CHICA, Relleno_NEGRO, puntoX + 30, puntoY + 16 * 2)
            PAINT_TEC.FillRectangle(Relleno_RED, puntoX, puntoY + 2 + 16 * 3, 30, 5)
            PAINT_TEC.DrawString("CANTIDAD DE TIEMPO SEGUN STANDARD DE TAREAS FINALIZADAS SEGUN TECNICO", FUENTE_CHICA, Relleno_NEGRO, puntoX + 30, puntoY + 16 * 3)

    End Sub



End Module
