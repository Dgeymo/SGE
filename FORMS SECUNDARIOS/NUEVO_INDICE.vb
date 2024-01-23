Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Public Class NUEVO_INDICE
    '    'INDICES
    '    Dim MES As String
    '    Dim AÑO As Integer
    '    Public RUTA_EXCEL As String
    '    Dim TOTAL_REGISTROS As Integer
    '    Dim ORDINAL_ACTUAL As Integer = 0
    '    'Variables____________________________________________________________________________
    '    Dim Registros As Integer                'Cuenta los registros cargados en el dataset de base
    '    Dim RegistrosCambiados As Integer       'Cuenta los registros cambiados con respecto al dataset de base
    '    Dim RegistrosProcesados As Integer      'Cuenta los registros procesados 
    '    Dim CONTADOR As Integer                 'Variable para utilizar en lazos For Next en TABLA PRINCIPAL
    '    Dim CONTADOR1 As Integer                'Variable para utilizar en lazos For Next en TABLA PRINCIPAL
    '    Dim CONTADOR2 As Integer                'Variable para utilizar en lazos secundarios de TABLA PRINCIPAL
    '    Dim CuentaCambios(10) As Integer        'Variable que registra los cambios individuales en cada proceso
    '    Dim ItemSeleccionados(10) As String     'Variable para recoger los item seleccionados en un list box con seleccion múltiple
    '    Dim StatusRECselec As Integer           'Variable que indica cuantos Status de reclamo se seleccionaron para eliminar
    '    Public NRO_RECLAMO                      'Variable para buscar el reclamo para analizar

    '    Dim VER_REG As String                   'Variable que setea los campos que se van a ver en el analisis
    '    Dim FALLA_CIERRE_REC As String            'Variable para almacenar temporalmente el dato de cierre del REC si es 819
    '    Dim FECHA_CIERRE_REC As String          'Valor para almacenar temporalmente la fecha de cierre del RECLAMO
    '    Dim FECHA_INGRES_REC As String          'Valor para almacenar temporalmente la fecha de Ingreso del RECLAMO
    '    Dim CAUSA_CIERRE_REC As String            'Valor para almacenar temporalmente la causa de cierre del RECLAMO

    '    Dim CANT_REC_97 As Long                 'Valor que almacena la cantidad de reclamos sin señal
    '    Dim CANT_REC_OTROS As Long              'Valor que almacena la cantidad de reclamos con OTRA falla  para calculo de indices
    '    Dim CANT_REC_ALL As Long                'Valor que muestra la cantidad total de reclamos
    '    Dim CANT_REC_97_CUMPTM As Long          'Valor que muestra la cantidad de reclamos sin señal que cumplen el tiempo optimo
    '    Dim CANT_REC_OTROS_CUMPTM As Long       'Valor que muestra la cantidad de reclamos de otro tipo que cumplen con el tiempo optimo
    '    Dim CANT_REC_ALL_CUMPTM As Long         'Valor que uestra la cantidad de reclamos totales que cumplen con el tiempo optimo
    '    Dim PERCENT_97 As Decimal               'Porcentaje de reclamos sin señal que cumplen con el tiempo optimo
    '    Dim PERCENT_ALL As Decimal              'Porcentaje total de recalmos que cumplen con el tiempo optimo

    '    Dim CANT_REC_RED_MAN_CXM As Integer          'Variable para almacenar la totalidad de reclamos de RED MANT c/ corte x mantenimiento
    '    Dim CANT_REC_RED_MAN_ORD As Integer          'Variable para almacenar la totalidad de reclamos de RED MANT c/ Falla Ordinal
    '    Dim CANT_REC_RED_COR_CXM As UInteger         'Variable para almacenar la totalidad de reclamos de RED CORR c/ corte x mantenimiento
    '    Dim CANT_REC_RED_COR_ORD As Integer          'Variable para almacenar la totalidad de reclamos de RED CORR c/ Falla Ordinal
    '    Dim CANT_REC_MDU_MAN_CXM As Integer          'Variable para almacenar la totalidad de reclamos de MDU MANT c/ corte x mantenimiento
    '    Dim CANT_REC_MDU_MAN_ORD As Integer          'Variable para almacenar la totalidad de reclamos de MDU MANT c/ Falla Ordinal   
    '    Dim CANT_REC_MDU_COR_CXM As Integer          'Variable para almacenar la totalidad de reclamos de MDU CORR c/ corte x mantenimiento
    '    Dim CANT_REC_MDU_COR_ORD As Integer          'Variable para almacenar la totalidad de reclamos de MDU CORR c/ Falla Ordinal
    '    Dim CANT_ORD_RED_CORR As Integer             'Variable que cuenta la cantidad de ordinales de RED CORRECTIVOS
    '    Dim CANT_ORD_RED_MANT As Integer             'Variable que cuenta la cantidad de ordinales de RED MANTENIMIENTO
    '    Dim CANT_ORD_MDU_CORR As Integer             'Variable que cuenta la cantidad de ordinales de MDU CORRECTIVOS
    '    Dim CANT_ORD_MDU_MANT As Integer             'Variable que cuenta la cantidad de ordinales de MDU MANTENIMIENTO

    '    Dim CANT_REC_97_RED_MANT_OTR As Integer
    '    Dim CANT_REC_97_RED_MANT_CXM As Integer
    '    Dim CANT_REC_97_MDU_MANT_OTR As Integer
    '    Dim CANT_REC_97_MDU_MANT_CXM As Integer
    '    Dim CANT_REC_97_RED_CORR_OTR As Integer
    '    Dim CANT_REC_97_RED_CORR_CXM As Integer
    '    Dim CANT_REC_97_MDU_CORR_OTR As Integer
    '    Dim CANT_REC_97_MDU_CORR_CXM As Integer

    '    Dim CANT_REC_OTR_RED_MANT As Integer
    '    Dim CANT_REC_OTR_RED_CORR As Integer
    '    Dim CANT_REC_OTR_MDU_MANT As Integer
    '    Dim CANT_REC_OTR_MDU_CORR As Integer

    '    'Dimensiona las variables de definición de indices
    '    Dim DESCRIPCION_IND(50) As String
    '    Dim UNIDAD_IND(50) As String
    '    Dim VALOR_INDICE(50) As String
    '    Dim VALOR_NUM_INDICE(50) As Double
    '    Public CUMPLE_IND_OPT(50) As String
    '    Public CUMPLE_IND_ACEP(50) As String
    '    Dim DESVIACION_IND_OPT(50) As Long
    '    Dim DESVIACION_IND_ACEP(50) As Long

    '    'Variables para el cálculo de tiempos de corte por mantenimiento y siin señal otras causas
    '    Dim TIEM_REC_97_RED_MANT_OTR As Long
    '    Dim TIEM_REC_97_RED_MANT_CXM As Long
    '    Dim TIEM_REC_97_MDU_MANT_OTR As Long
    '    Dim TIEM_REC_97_MDU_MANT_CXM As Long
    '    Dim TIEM_REC_97_RED_CORR_OTR As Long
    '    Dim TIEM_REC_97_RED_CORR_CXM As Long
    '    Dim TIEM_REC_97_MDU_CORR_OTR As Long
    '    Dim TIEM_REC_97_MDU_CORR_CXM As Long

    '    'Variables para el cálculo de Tiempo de Vida, Asistencia y Trabajo
    '    Dim TIEMP_VIDA_97 As Integer
    '    Dim TIEMP_ASIST_97 As Integer
    '    Dim CANT_ASIST_97 As Integer
    '    Dim TIEMP_VIDA_OTROS As Integer
    '    Dim TIEMP_ASIST_OTROS As Integer
    '    Dim CANT_ASIST_OTROS As Integer
    '    Dim TIEMP_VIDA_TOTAL As Integer
    '    Dim TIEMP_ASIST_TOTAL As Integer
    '    Dim CANT_ASIST_TOTAL As Integer
    '    Dim TIEMP_TRAB_TOTAL As Integer
    '    Dim TIEMPO_TRAB_PROM As Integer
    '    Dim CANT_TRAB_TOTAL As Integer
    '    Dim NODO_RED As String
    '    Dim NRO_INDICE As Integer
    '    Dim NRO_ORDINAL(10000) As Integer

    '    'Variables para tabla de ordinales
    '    Dim CANT_REC_FALL_97 As Integer
    '    Dim CANT_REC_FALL_ORD As Integer
    '    Dim COD_ZONE As String

    '    'Operaciones Especiales, recorte de caracteres
    '    Dim Caracteres_a_sacar() As Char = {"1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "0"c}
    '    Dim NEWINFORMERow As INFORME_INDICEDataSet.InformesRow
    '    Dim NUEVO_REGISTRORow As INFORME_INDICEDataSet.TablaWEBRow
    '    'Objetos_________________________________________________________________________________________
    '    'Objeto para caragar los cambios que hubo en la dataset original
    '    Public CAMBIOSBindingSource As New BindingSource
    '    'Objeto para determinar el array de items seleccionados en un determinado listbox
    '    'Dim ListSelection As ListBox.SelectedObjectCollection
    '    Dim TABLAWEBRow As INFORME_INDICEDataSet.TablaWEBRow
    '    'Objeto Fila nueva para la base de datos de cálculo
    '    Dim NEWRECLAMORow As INFORME_INDICEDataSet.BaseCalculoRow
    '    'Objeto Fila  Nueva para la base Ordinales
    '    Dim newOrdinalRow As INFORME_INDICEDataSet.OrdinalesRow
    '    'Objeto Fila Nueva para la base reporte de Indices
    '    Dim NewRepIndrow As INFORME_INDICEDataSet.RepoIndicesRow
    '    'Objeto Fila Nueva para la base historico  de Indices
    '    Dim NewHistoIndrow As INFORME_INDICEDataSet.HistoIndicesRow
    '    'Define una fila para ubicar el registro en la Base de Reportes de indices
    '    Dim RepoINDRow As DataRow
    '    'Define una fila para ubicar el registro en la Base de Calculo
    '    Dim RECLAMORow As DataRow
    '    'Defne una fila para ubicar el registro an la base de Ordinales
    '    Dim OrdinalRow As DataRow
    '    'Defne una fila para ubicar el registro an la base de definicion de Indices
    '    Dim IndiceRow As DataRow
    '    'Define una fila para ubicar la ZOna de red de acuerdo al NODO
    '    Dim ZonaRedRow As DataRow
    '    'Ver los registros nuevos en BaseCalculo
    '    Public NewBaseCalculoBindingSource As New BindingSource
    '    'Define una instancia para recoger los datos, se usa para filtrar las vistas
    '    Dim FallasRow As DataRow
    '    Dim CausasRow As DataRow
    '    Dim BASECALCULORow As INFORME_INDICEDataSet.BaseCalculoRow
    '    'Variables utilizadas en los cálculos de tiempo
    '    Public nroreclamo As String
    '    Public nroOrdinal As String
    '    Dim datTim1 As Date
    '    Dim datTim2 As Date
    '    Dim DiaVenc As Date
    '    Dim DiaVencHora As Date
    '    Dim DiaVencMin As Date
    '    Dim FECHA_VENC_OPTIMO As Date
    '    Dim FECHA_VENC_ACEPTABLE As Date
    '    Dim FECHA_LIM_RECLAMO As Date
    '    Dim EXISTE_FALLA As String
    '    Dim CANT_97_CUMPLE_OPT As Integer
    '    Dim CANT_97_CUMPLE_ACEP As Integer
    '    Dim CANT_OTROS_CUMPLE_OPT As Integer
    '    Dim CANT_OTROS_CUMPLE_ACE As Integer
    '    Dim CANT_ALL_CUMPLE_OPT As Integer
    '    Dim CANT_ALL_CUMPLE_ACEP As Integer
    '    Dim SUMA_TIE_97 As Long
    '    Public PROM_TIE_97 As String
    '    Dim SUMA_TIE_OTROS As Long
    '    Dim PROM_TIE_OTROS As String
    '    Dim SUMA_TIE_ALL As Long
    '    Dim PROM_TIE_ALL As String
    '    Dim SUMA_TIE_ASIST_97 As Long
    '    Dim PROM_TIE_ASIST_97 As String
    '    Dim HORAS As Integer
    '    Dim MINUTOS As Integer
    '    Dim prueba As Date
    '    Dim TIEM_MAX_97 As Long
    '    Public TIEM_MAX_97_STR As String
    '    Dim TIEM_MAX_TODOS As Long
    '    Public TIEM_MAX_TODOS_STR As String
    '    Dim REGISTRO As Integer
    '    Private Sub NUEVO_INDICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        'INFORME INDICES
    '        BaseIndicesTableAdapter.Fill(INFORME_INDICEDataSet.BaseIndices)
    '        CAUSASTableAdapter.Fill(INFORME_INDICEDataSet.CAUSAS)
    '        InfoIndicesTableAdapter.Fill(INFORME_INDICEDataSet.InfoIndices)
    '        ZonasREDTableAdapter.Fill(INFORME_INDICEDataSet.ZonasRED)
    '        FALLASTableAdapter.Fill(INFORME_INDICEDataSet.FALLAS)
    '    End Sub
    '    'INFORME INDICES______________________________________
    '    Private Sub CB_FECHA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FECHA.SelectedIndexChanged
    '        MES = ""
    '        If CB_FECHA.Text <> "(Seleccione)" Then
    '            Select Case CB_FECHA.SelectedItem
    '                Case "ENERO"
    '                    MES = "01"
    '                Case "FEBRERO"
    '                    MES = "02"
    '                Case "MARZO"
    '                    MES = "03"
    '                Case "ABRIL"
    '                    MES = "04"
    '                Case "MAYO"
    '                    MES = "05"
    '                Case "JUNIO"
    '                    MES = "06"
    '                Case "JULIO"
    '                    MES = "07"
    '                Case "AGOSTO"
    '                    MES = "08"
    '                Case "SETIEMBRE"
    '                    MES = "09"
    '                Case "OCTUBRE"
    '                    MES = "10"
    '                Case "NOVIEMBRE"
    '                    MES = "11"
    '                Case "DICIEMBRE"
    '                    MES = "12"
    '            End Select

    '        Else
    '            MsgBox("Seleccione un MES")
    '        End If
    '        AÑO = CB_ANIO.Text
    '        InformesTableAdapter.FillByMESANIO(INFORME_INDICEDataSet.Informes, MES, AÑO)
    '        If INFORME_INDICEDataSet.Informes.Rows.Count > 0 Then
    '            TXT_ID_INFORME.Text = INFORME_INDICEDataSet.Informes.Rows(0).Item("ID")
    '            TXT_INFORME.Text = INFORME_INDICEDataSet.Informes.Rows(0).Item("NombreInforme")
    '        Else
    '            TXT_ID_INFORME.Text = CInt(PROCESOS.ULTIMO_INDICE) + 1
    '            TXT_INFORME.Text = "Informe  " & CB_FECHA.Text & " " & AÑO
    '            TXT_INFORME.Focus()
    '        End If
    '        BTN_CARGAR_excel.Visible = True

    '        TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "SI")
    '        If INFORME_INDICEDataSet.TablaWEB.Rows.Count > 0 Then
    '            PROCESOS.PROGRESS_BAR("TOTAL REGISTROS VALIDOS", INFORME_INDICEDataSet.TablaWEB.Rows.Count, INFORME_INDICEDataSet.TablaWEB.Rows.Count)
    '            BTN_CARGAR_excel.Text = "CONTINUAR"
    '            BTN_BORRAR_EXCEL.Visible = True
    '        Else
    '            BTN_CARGAR_excel.Text = "CARGAR DB EXCEL"
    '            BTN_BORRAR_EXCEL.Visible = False
    '        End If
    '        LBL_TITULO_INFORME.Visible = True
    '        TXT_ID_INFORME.Visible = True
    '        TXT_INFORME.Visible = True

    '    End Sub
    '    Public Sub CARGAR_EXCEL_INFORME()
    '        BTN_SALIR.Enabled = False
    '        Dim Fila As Integer = 2
    '        Dim oExcel As New Application
    '        Dim oLibro As Workbook
    '        Dim oHoja As Worksheet
    '        oLibro = oExcel.Workbooks.Open(RUTA_EXCEL)
    '        oHoja = oLibro.Sheets(oLibro.Worksheets.Item(1).NAME)

    '        Dim CONTENIDO As String = oHoja.Cells(2, 1).VALUE
    '        TOTAL_REGISTROS = 0
    '        While CONTENIDO <> ""
    '            TOTAL_REGISTROS += 1
    '            Fila += 1
    '            CONTENIDO = oHoja.Cells(Fila, 1).value
    '        End While

    '        CONTENIDO = oHoja.Cells(2, 1).VALUE
    '        Fila = 2
    '        While CONTENIDO <> ""
    '            CONTENIDO = oHoja.Cells(Fila, 1).value
    '            Try
    '                'CARGAMOS LOS DATOS AL ACCES CON LOS DATOS AQUI
    '                NUEVO_REGISTRORow = INFORME_INDICEDataSet.TablaWEB.NewTablaWEBRow()
    '                NUEVO_REGISTRORow.ID_RECLAMO = oHoja.Cells(Fila, 1).value           '1
    '                NUEVO_REGISTRORow.ID_RECLAMO_PERMISOR = oHoja.Cells(Fila, 2).value  '2
    '                NUEVO_REGISTRORow.FALLA_ORI_REC = oHoja.Cells(Fila, 3).value        '3
    '                NUEVO_REGISTRORow.DESCRIPCION_DE_FALLA_ORI_REC = oHoja.Cells(Fila, 4).value '4
    '                NUEVO_REGISTRORow.NRO_FALLA_REC = oHoja.Cells(Fila, 5).value        '5
    '                NUEVO_REGISTRORow.TIPO_DE_SOLUCION = oHoja.Cells(Fila, 6).value     '6
    '                NUEVO_REGISTRORow.PERMISOR = oHoja.Cells(Fila, 7).value             '7
    '                NUEVO_REGISTRORow.FECHA_ING_RECLAMO = oHoja.Cells(Fila, 8).value    '8
    '                NUEVO_REGISTRORow.FECHA_CUMPLIDA_REC = oHoja.Cells(Fila, 9).value   '9
    '                NUEVO_REGISTRORow.STS_RECLAMO = oHoja.Cells(Fila, 10).value         '10
    '                NUEVO_REGISTRORow.ORDINAL = oHoja.Cells(Fila, 11).value             '11
    '                NUEVO_REGISTRORow.FECHA_ING_ORDINAL = oHoja.Cells(Fila, 12).value   '12
    '                NUEVO_REGISTRORow.HORA_ING_ORDINAL = oHoja.Cells(Fila, 13).value    '13
    '                NUEVO_REGISTRORow.FALLA_ORI_ORDINAL = oHoja.Cells(Fila, 14).value   '14
    '                NUEVO_REGISTRORow.FCH_CIERRE_TRAB_ORDINAL = oHoja.Cells(Fila, 15).value '15
    '                NUEVO_REGISTRORow.FECHA_CIERRE_ORDINAL = oHoja.Cells(Fila, 16).value    '16
    '                NUEVO_REGISTRORow.FALLA_CIERRE_ORDINAL = oHoja.Cells(Fila, 17).value    '17
    '                NUEVO_REGISTRORow.CAUSA_CIERRE_ORDINAL = oHoja.Cells(Fila, 18).value    '18
    '                NUEVO_REGISTRORow.TIPO_ORDINAL = oHoja.Cells(Fila, 19).value        '19
    '                NUEVO_REGISTRORow.SECTOR_ORDINAL = oHoja.Cells(Fila, 20).value      '20
    '                NUEVO_REGISTRORow.TECNICO_EJECUTANTE = oHoja.Cells(Fila, 21).value  '21
    '                NUEVO_REGISTRORow.TECNICO_SUPERVISOR = oHoja.Cells(Fila, 22).value  '22
    '                NUEVO_REGISTRORow.TECNICO_AYUDANTE = oHoja.Cells(Fila, 23).value    '23    
    '                NUEVO_REGISTRORow.STS_ORDINAL = oHoja.Cells(Fila, 24).value         '24
    '                NUEVO_REGISTRORow.ORDINAL_CIERRE_RED = oHoja.Cells(Fila, 25).value  '25
    '                NUEVO_REGISTRORow.FALLA_CIERRE_RED = oHoja.Cells(Fila, 26).value    '26
    '                NUEVO_REGISTRORow.CAUSA_CIERRE_RED = oHoja.Cells(Fila, 27).value    '27
    '                NUEVO_REGISTRORow.FECHA_CIERRE_RED = oHoja.Cells(Fila, 28).value    '28
    '                NUEVO_REGISTRORow.FALLA_ORI_ORD_RED = oHoja.Cells(Fila, 29).value   '29
    '                NUEVO_REGISTRORow.FALLA_FIN_ORD_RED = oHoja.Cells(Fila, 30).value   '30
    '                NUEVO_REGISTRORow.CAUSA_FIN_ORD_RED = oHoja.Cells(Fila, 31).value   '31
    '                NUEVO_REGISTRORow.FCH_CIERRE_TRAB_ORD_RED = oHoja.Cells(Fila, 32).value '32
    '                NUEVO_REGISTRORow.ORDINAL_CIERRE_MDU = oHoja.Cells(Fila, 33).value  '33
    '                NUEVO_REGISTRORow.FALLA_CIERRE_MDU = oHoja.Cells(Fila, 34).value    '34
    '                NUEVO_REGISTRORow.CAUSA_CIERRE_MDU = oHoja.Cells(Fila, 35).value    '35
    '                NUEVO_REGISTRORow.FECHA_CIERRE_MDU = oHoja.Cells(Fila, 36).value    '36
    '                NUEVO_REGISTRORow.FALLA_ORI_ORD_MDU = oHoja.Cells(Fila, 37).value   '37
    '                NUEVO_REGISTRORow.FALLA_FIN_ORD_MDU = oHoja.Cells(Fila, 38).value   '38
    '                NUEVO_REGISTRORow.CAUSA_FIN_ORD_MDU = oHoja.Cells(Fila, 39).value   '39
    '                NUEVO_REGISTRORow.FCH_CIERRE_TRAB_ORD_MDU = oHoja.Cells(Fila, 40).value '40
    '                NUEVO_REGISTRORow.FCH_CIERRE_ORD_MDU = oHoja.Cells(Fila, 41).value  '41
    '                NUEVO_REGISTRORow.COD_ZONA = oHoja.Cells(Fila, 42).value            '42
    '                NUEVO_REGISTRORow.ZONA = oHoja.Cells(Fila, 43).value                '43
    '                NUEVO_REGISTRORow.COD_CALLE = oHoja.Cells(Fila, 44).value           '44
    '                NUEVO_REGISTRORow.CALLE = oHoja.Cells(Fila, 45).value               '45
    '                NUEVO_REGISTRORow.NRO = oHoja.Cells(Fila, 46).value                 '46
    '                NUEVO_REGISTRORow.APTO = oHoja.Cells(Fila, 47).value                '47
    '                NUEVO_REGISTRORow.ABONADO = oHoja.Cells(Fila, 48).value             '48
    '                NUEVO_REGISTRORow.NOMBRE = oHoja.Cells(Fila, 49).value              '49
    '                NUEVO_REGISTRORow.FCH_INICIO_TRAB_ORDINAL = oHoja.Cells(Fila, 50).value '50
    '                NUEVO_REGISTRORow.TIPO_GEN = oHoja.Cells(Fila, 51).value            '51
    '                NUEVO_REGISTRORow.USUARIO_ID = oHoja.Cells(Fila, 52).value          '52
    '                NUEVO_REGISTRORow.USUARIO_ING = oHoja.Cells(Fila, 53).value         '53
    '                NUEVO_REGISTRORow.VALIDO_INDICE = "SI"
    '                INFORME_INDICEDataSet.TablaWEB.Rows.Add(NUEVO_REGISTRORow)
    '                REGISTRO += 1
    '            Catch EX As Exception
    '            End Try
    '            PROCESOS.PROGRESS_BAR("CARGANDO REGISTRO A BD", TOTAL_REGISTROS, REGISTRO)
    '            Fila += 1

    '        End While
    '        Try
    '            TablaWEBTableAdapter.Update(INFORME_INDICEDataSet.TablaWEB)
    '            BTN_CARGAR_excel.Enabled = False
    '            TablaWEBTableAdapter.FillByBORRAR_FORANEOS()
    '            PROCESOS.PROGRESS_BAR("REGISTROS INGRESADO", TOTAL_REGISTROS, REGISTRO)
    '        Catch ex As Exception
    '            MsgBox("NO SE PUDO GRABAR EN LA BASE DE DATOS  " & ex.Message, vbExclamation)
    '        End Try
    '        oLibro.Close()
    '        oExcel.Quit()

    '        PASAR_A_NO_VALIDO()
    '    End Sub
    '    'Private Sub BTN_CARGAR_excel_Click(sender As Object, e As EventArgs) Handles BTN_CARGAR_excel.Click
    '    '    If BTN_CARGAR_excel.Text = "CONTINUAR" Then
    '    '        PASAR_A_NO_VALIDO()
    '    '        PROCESOS.InformesTableAdapter.FillByMESANIO(PROCESOS.INFORME_INDICEDataSet.Informes, MES, AÑO)
    '    '    Else
    '    '        Dim primerDia As Date = DateSerial(AÑO, MES, 1)
    '    '        Dim ultimoDia As Date = DateSerial(AÑO, MES + 1, 0)

    '    '        NEWINFORMERow = INFORME_INDICEDataSet.Informes.NewInformesRow
    '    '        NEWINFORMERow.Id = TXT_ID_INFORME.Text
    '    '        NEWINFORMERow.NombreInforme = TXT_INFORME.Text
    '    '        NEWINFORMERow.Mes = MES
    '    '        NEWINFORMERow.MesNombre = CB_FECHA.Text
    '    '        NEWINFORMERow.Año = AÑO
    '    '        NEWINFORMERow.Desde = primerDia
    '    '        NEWINFORMERow.Hasta = ultimoDia
    '    '        INFORME_INDICEDataSet.Informes.AddInformesRow(NEWINFORMERow)
    '    '        InformesTableAdapter.Update(NEWINFORMERow)
    '    '        PROCESOS.INDICES_INCIAL()
    '    '        FOpenFileDialog.Show(Me)
    '    '    End If
    '    'End Sub
    '    Public Sub PASAR_A_NO_VALIDO()
    '        GB_MARCAR_NOVALIDOS.Visible = True
    '        GB_MARCAR_NOVALIDOS.Refresh()
    '        TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "SI")

    '        'RECLAMOS EN STATUS CANCELADO Y PENDIENTE
    '        LBL_RECCANCPEND.Refresh()
    '        CONTADOR1 = 0
    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
    '            TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)

    '            If Trim(TABLAWEBRow.STS_RECLAMO) = "CANCELADO" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Status de reclamo = CANCELADO"
    '                CONTADOR1 += 1
    '            End If
    '            If Trim(TABLAWEBRow.STS_RECLAMO) = "PENDIENTE" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Status de reclamo = PENDIENTE"
    '                CONTADOR1 += 1
    '            End If
    '            TXT_TOTAL_CANCPEND.Text = CONTADOR1
    '            TXT_TOTAL_CANCPEND.Refresh()
    '        Next

    '        'RECLAMOS CON ORDINALES ANULADOS
    '        LBL_ORDPEND.Visible = True
    '        LBL_ORDPEND.Refresh()
    '        TXT_ORDPEND.Visible = True

    '        CONTADOR1 = 0
    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
    '            TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)
    '            Select Case Trim(TABLAWEBRow.STS_ORDINAL)
    '                Case "ANULADO", "AUTORIZADO", "EMITIDO", "ENEJECUCION"
    '                    TABLAWEBRow.VALIDO_INDICE = "NO"
    '                    TABLAWEBRow.MOTIVO = "Status de ORDINAL = ANULADO"
    '                    CONTADOR1 += 1
    '            End Select
    '            TXT_ORDPEND.Text = CONTADOR1
    '            TXT_ORDPEND.Refresh()
    '        Next

    '        'RECLAMOS CON SECTOR CABECERA Y OTT
    '        LBL_SECTOR.Visible = True
    '        LBL_SECTOR.Refresh()
    '        TXT_SECTOR.Visible = True

    '        CONTADOR1 = 0
    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
    '            TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)

    '            If Trim(TABLAWEBRow.SECTOR_ORDINAL) = "CABECERA" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Reclamo Ingresado a Sector CABECERA"
    '                CONTADOR1 += 1
    '            End If
    '            If Trim(TABLAWEBRow.SECTOR_ORDINAL) = "OTT" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Reclamo Ingresado a Sector OTT"
    '                CONTADOR1 += 1
    '            End If
    '            TXT_SECTOR.Text = CONTADOR1
    '            TXT_SECTOR.Refresh()
    '        Next
    '        'RECLAMOS SEGUN TIPO DE SOLUCION
    '        LBL_TIPOSOL.Visible = True
    '        LBL_TIPOSOL.Refresh()
    '        TXT_TIPOSOL.Visible = True
    '        CONTADOR1 = 0
    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
    '            TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)

    '            If Trim(TABLAWEBRow.TIPO_DE_SOLUCION) = "D" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Tipo de Solucion = D"
    '                CONTADOR1 += 1
    '            End If
    '            If Trim(TABLAWEBRow.TIPO_DE_SOLUCION) = "C" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Tipo de Solucion = C"
    '                CONTADOR1 += 1
    '            End If
    '            If Trim(TABLAWEBRow.TIPO_DE_SOLUCION) = "?" Then
    '                TABLAWEBRow.VALIDO_INDICE = "NO"
    '                TABLAWEBRow.MOTIVO = "Tipo de Solucion = ?"
    '                CONTADOR1 += 1
    '            End If
    '            TXT_TIPOSOL.Text = CONTADOR1
    '            TXT_TIPOSOL.Refresh()
    '        Next

    '        LBL_GUARDANDOREG.Visible = True
    '        LBL_GUARDANDOREG.Refresh()
    '        Try
    '            If CInt(TXT_TOTAL_CANCPEND.Text) + CInt(TXT_ORDPEND.Text) + CInt(TXT_SECTOR.Text) + CInt(TXT_TIPOSOL.Text) > 0 Then
    '                TablaWEBTableAdapter.Update(INFORME_INDICEDataSet.TablaWEB)
    '                LBL_GUARDANDOREG.Text = "REGISTROS GUARDADOS"
    '            Else
    '                LBL_GUARDANDOREG.Text = "NO HAY REGISTROS A MODIFICAR"
    '            End If
    '            LBL_GUARDANDOREG.Refresh()
    '            TXT_TOTALREG.Visible = True
    '            TXT_TOTALREG.Text = CInt(TXT_TOTAL_CANCPEND.Text) + CInt(TXT_ORDPEND.Text) + CInt(TXT_SECTOR.Text) + CInt(TXT_TIPOSOL.Text)
    '            TXT_TOTALREG.Refresh()
    '        Catch ex As Exception
    '            LBL_GUARDANDOREG.Text = "ERROR AL GUARDAR - " & ex.Message
    '            LBL_GUARDANDOREG.Refresh()
    '        End Try
    '        BTN_CONTINUAR.Visible = True
    '        BTN_BORRAR_BASECALCULO.Visible = True
    '    End Sub
    '    Private Sub BTN_CONTINUAR_Click(sender As Object, e As EventArgs) Handles BTN_CONTINUAR.Click
    '        BUSCA_FALLA()
    '    End Sub
    '    Public Sub BUSCA_FALLA()
    '        TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "SI")
    '        TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet1.TablaWEB, AÑO, MES, "SI")
    '        BaseCalculoTableAdapter.FillByMESANIO(INFORME_INDICEDataSet.BaseCalculo, AÑO, MES)
    '        'If INFORME_INDICEDataSet.BaseCalculo.Rows.Count > 0 Then
    '        '    For X = 0 To INFORME_INDICEDataSet.BaseCalculo.Count - 1
    '        '        INFORME_INDICEDataSet.BaseCalculo.Rows(X).Delete()
    '        '        PROCESOS.PROGRESS_BAR("BORRANDO BASECALCULO", INFORME_INDICEDataSet.BaseCalculo.Rows.Count, X + 1)
    '        '    Next
    '        '    PROCESOS.PROGRESS_BAR("GRABANDO", INFORME_INDICEDataSet.BaseCalculo.Rows.Count, INFORME_INDICEDataSet.BaseCalculo.Rows.Count)
    '        '    BaseCalculoTableAdapter.Update(INFORME_INDICEDataSet.BaseCalculo)
    '        '    PROCESOS.PROGRESS_BAR("LISTO", 0, 0)
    '        'End If

    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1
    '            TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR)
    '            RECLAMORow = INFORME_INDICEDataSet.BaseCalculo.FindByidReclamo(TABLAWEBRow.ID_RECLAMO)
    '            FECHA_INGRES_REC = ""
    '            FECHA_CIERRE_REC = ""
    '            FALLA_CIERRE_REC = ""
    '            CAUSA_CIERRE_REC = ""
    '            If IsNothing(RECLAMORow) Then
    '                NEWRECLAMORow = INFORME_INDICEDataSet.BaseCalculo.NewBaseCalculoRow


    '                'Evalua las fecha de cierre del reclamo a tener en cuenta para el calculo de indices, VERSION 1 :
    '                'Si encuentra que la falla de cierre de RED es 819 carga esa fecha como fecha de cierre y la falla como falla de cierre del reclamo (No tiene en cuenta
    '                'la falla de origen, despues hace lo mismo para MDU, si se cumple alguna de estas dos situaciones la facha y la fecha corresponde a la de la 819
    '                If TABLAWEBRow.FALLA_CIERRE_RED = Str(819) Then
    '                    FECHA_INGRES_REC = TABLAWEBRow.FECHA_ING_RECLAMO
    '                    FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_RED
    '                    FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_RED
    '                    CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_RED

    '                ElseIf TABLAWEBRow.FALLA_CIERRE_MDU = Str(819) Then
    '                    FECHA_INGRES_REC = TABLAWEBRow.FECHA_ING_RECLAMO
    '                    FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_MDU
    '                    FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_MDU
    '                    CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_MDU


    '                Else 'Si la falla no es 819 se fija si la falla de RED es 0, si esto es asi busca la falla de MDU y carga esta como fecha de cierre y la falla que corresponda
    '                    If TABLAWEBRow.FALLA_CIERRE_RED = 0 Then
    '                        FECHA_INGRES_REC = TABLAWEBRow.HORA_ING_ORDINAL
    '                        FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_MDU
    '                        FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_MDU
    '                        CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_MDU
    '                    Else
    '                        FECHA_INGRES_REC = TABLAWEBRow.HORA_ING_ORDINAL
    '                        FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_RED
    '                        FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_RED
    '                        CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_RED
    '                        If TABLAWEBRow.STS_ORDINAL = "CANCELADO" Then
    '                            TablaWEBTableAdapter.FillByORD_PADRE(INFORME_INDICEDataSet1.TablaWEB, TABLAWEBRow.ORDINAL_CIERRE_RED)
    '                            If INFORME_INDICEDataSet1.TablaWEB.Rows.Count > 0 Then
    '                                For Each ORDENES In INFORME_INDICEDataSet1.TablaWEB
    '                                    Select Case Trim(ORDENES.Item("FALLA_ORI_ORDINAL"))
    '                                        Case "97", "446", "771"
    '                                            FECHA_INGRES_REC = ORDENES.Item("HORA_ING_ORDINAL")
    '                                            FALLA_CIERRE_REC = ORDENES.Item("FALLA_CIERRE_RED")
    '                                            FECHA_CIERRE_REC = ORDENES.Item("FECHA_CIERRE_RED")
    '                                            CAUSA_CIERRE_REC = ORDENES.Item("CAUSA_CIERRE_RED")
    '                                    End Select
    '                                Next
    '                            End If
    '                        End If
    '                        End If
    '                End If
    '                '_________________________________________________________________________________________________________________

    '                NEWRECLAMORow.idReclamo = TABLAWEBRow.ID_RECLAMO
    '                NEWRECLAMORow.FallaOrigen = TABLAWEBRow.FALLA_ORI_REC
    '                NEWRECLAMORow.FechaIngreso = TABLAWEBRow.FECHA_ING_RECLAMO
    '                NEWRECLAMORow.FechaIngCalculo = FECHA_INGRES_REC
    '                NEWRECLAMORow.FechaCierreCalculo = FECHA_CIERRE_REC
    '                NEWRECLAMORow.FallaCierre = FALLA_CIERRE_REC
    '                NEWRECLAMORow.CausaCierre = CAUSA_CIERRE_REC
    '                NEWRECLAMORow.Tipo = TABLAWEBRow.TIPO_ORDINAL
    '                NEWRECLAMORow.Sector = TABLAWEBRow.SECTOR_ORDINAL
    '                NEWRECLAMORow.Ordinal = TABLAWEBRow.ORDINAL

    '                'Carga Nodo , Sector y Zona RED

    '                'Rutina para cargar nodo y zona a la tabla de ordinales (Agregar ZONARED)__________________________________________________________

    '                Select Case TABLAWEBRow.ZONA.ToString.Length
    '                    Case 3
    '                        COD_ZONE = "  " & TABLAWEBRow.ZONA
    '                    Case 4
    '                        COD_ZONE = " " & TABLAWEBRow.ZONA
    '                    Case 5
    '                        COD_ZONE = TABLAWEBRow.ZONA
    '                End Select

    '                NEWRECLAMORow.Nodo = LTrim(COD_ZONE.Remove(3))
    '                NEWRECLAMORow.Zona = COD_ZONE.Substring(3)
    '                NODO_RED = LTrim(COD_ZONE.Remove(3))

    '                ZonaRedRow = INFORME_INDICEDataSet.ZonasRED.FindByNodo(NODO_RED)
    '                If IsNothing(ZonaRedRow) = False Then NEWRECLAMORow.ZonaRED = ZonaRedRow("Sector")

    '                'Carga Descripcion de Falla
    '                FallasRow = INFORME_INDICEDataSet.FALLAS.FindByCódigo(FALLA_CIERRE_REC)
    '                NEWRECLAMORow.DescFallaCierre = FallasRow("Descripción")

    '                'Carga Descripcion de Causa
    '                CausasRow = INFORME_INDICEDataSet.CAUSAS.FindByCódigo(CAUSA_CIERRE_REC)
    '                NEWRECLAMORow.DescCausaCierre = CausasRow("Descripción")

    '                'Diferencia de tiempos
    '                datTim1 = CDate(FECHA_INGRES_REC)
    '                datTim2 = CDate(FECHA_CIERRE_REC)

    '                'Dimensiona variables utilizadas en los calculos
    '                Dim CantDiasOPT As Long
    '                Dim CantDiasACE As Long
    '                Dim HoraVen As Integer
    '                Dim MinVen As Integer
    '                Dim HoraAgre As Integer
    '                Dim MinAgre As Integer

    '                'Calcula fecha limite (al dia o al otro dia)_____________________________________________
    '                HoraVen = datTim1.Hour          'Obtiene la hora de la fecha de ingreso
    '                MinVen = datTim1.Minute         'Obtiene los minutos de la fecha de ingreso

    '                HoraAgre = 23 - HoraVen         'Calcula cuantas horas le faltan para llegar a 23:00
    '                MinAgre = 59 - MinVen           'Calcula cuantos minutos le faltan para llegar a 59 minutos

    '                DiaVenc = DateAdd(DateInterval.Day, 1, datTim1)                     'Suma un dia a la fecha de ingreso
    '                DiaVencHora = DateAdd(DateInterval.Hour, HoraAgre, DiaVenc)         'Suma horas hasta que quede en 23:00
    '                DiaVencMin = DateAdd(DateInterval.Minute, MinAgre, DiaVencHora)     'Suma Minutos hasta que quede en 59

    '                'Carga Indice de informe
    '                NEWRECLAMORow.Informe = CInt(TXT_ID_INFORME.Text)

    '                'Carga fecha limite_______________________________________________________________________
    '                NEWRECLAMORow.FechaLimite = DiaVencMin
    '                FECHA_LIM_RECLAMO = DiaVencMin
    '                'Carga Tiempo de Solución_________________________________________________________________
    '                NEWRECLAMORow.TiempoSolución = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '                'Carga Fecha y tiempo de asistencia_______________________________________________________________
    '                If IsDate(TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL) Then
    '                    NEWRECLAMORow.FechaAsistencia = TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL
    '                    datTim2 = TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL
    '                    NEWRECLAMORow.TiempoAsistencia = DateDiff(DateInterval.Minute, datTim1, datTim2)
    '                Else
    '                    NEWRECLAMORow.TiempoAsistencia = 0
    '                End If

    '                'Calcula Vencimiento Optimo y Aceptable____________________________________________________
    '                If Trim(TABLAWEBRow.FALLA_ORI_REC) = 97 Then
    '                    CantDiasOPT = 2
    '                    CantDiasACE = 3
    '                Else
    '                    CantDiasOPT = 3
    '                    CantDiasACE = 6
    '                End If
    '                NEWRECLAMORow.VencOptimo = DateAdd(DateInterval.Day, CantDiasOPT, datTim1)
    '                FECHA_VENC_OPTIMO = DateAdd(DateInterval.Day, CantDiasOPT, datTim1)
    '                NEWRECLAMORow.VencAceptable = DateAdd(DateInterval.Day, CantDiasACE, datTim1)
    '                FECHA_VENC_ACEPTABLE = DateAdd(DateInterval.Day, CantDiasACE, datTim1)

    '                'Calcula si cumple Tiempo de vencimiento óptimo_____________________________________________
    '                If CDate(FECHA_CIERRE_REC) < FECHA_VENC_OPTIMO Then
    '                    NEWRECLAMORow.CumpleIndiceVencOpti = "SI"
    '                Else
    '                    NEWRECLAMORow.CumpleIndiceVencOpti = "NO"
    '                End If
    '                '  MsgBox("cumple con vencimiento optimo si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_VENC_OPTIMO)

    '                'Calcula si vence Tiempo de vencimiento Aceptable____________________________________________
    '                If CDate(FECHA_CIERRE_REC) < FECHA_VENC_ACEPTABLE Then
    '                    NEWRECLAMORow.CumpleIndiceVencAcep = "SI"
    '                Else
    '                    NEWRECLAMORow.CumpleIndiceVencAcep = "NO"
    '                End If
    '                'MsgBox("cumple con vencimiento aceptable si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_VENC_ACEPTABLE)

    '                'Calcula la desviación del tiempo de cumplido con el OPTIMO en minutos _______________________
    '                datTim1 = FECHA_VENC_OPTIMO
    '                datTim2 = FECHA_CIERRE_REC
    '                NEWRECLAMORow.DesviacionVencOpti = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '                'Calcula la desviación del tiempo de cumplido con el ACEPTABLE en minutos _______________________
    '                datTim1 = FECHA_VENC_ACEPTABLE
    '                datTim2 = FECHA_CIERRE_REC
    '                NEWRECLAMORow.DesviacionVencAcep = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '                'Marca si cumple con el tiempo máximo
    '                If CDate(FECHA_CIERRE_REC) < FECHA_LIM_RECLAMO Then
    '                    NEWRECLAMORow.CumpleIndiceTM = "SI"
    '                Else
    '                    NEWRECLAMORow.CumpleIndiceTM = "NO"
    '                End If
    '                '  MsgBox("cumple con vencimiento maximo si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_LIM_RECLAMO)

    '                'Calcula la desviación con el TM_________________________________________________________________
    '                datTim1 = FECHA_LIM_RECLAMO
    '                datTim2 = FECHA_CIERRE_REC
    '                NEWRECLAMORow.DesviacionTM = DateDiff(DateInterval.Minute, datTim1, datTim2)
    '                'Agrega una nueva Fila___________________________________________________________________________
    '                INFORME_INDICEDataSet.BaseCalculo.Rows.Add(NEWRECLAMORow)
    '            End If
    '            PROCESOS.PROGRESS_BAR("Calculando TIEMPOS de RECLAMOS", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR + 1)
    '        Next
    '        PROCESOS.PROGRESS_BAR("GRABANDO BASECALCULO", INFORME_INDICEDataSet.TablaWEB.Rows.Count, INFORME_INDICEDataSet.TablaWEB.Rows.Count)
    '        BaseCalculoTableAdapter.Update(INFORME_INDICEDataSet.BaseCalculo)
    '        PROCESOS.PROGRESS_BAR("PROCESO TERMINADO", 0, 0)

    '        BaseCalculoTableAdapter.FillByNOTANOTOmes(INFORME_INDICEDataSet1.BaseCalculo, AÑO, MES, AÑO, MES)

    '        If INFORME_INDICEDataSet1.BaseCalculo.Rows.Count > 0 Then
    '            LBL_PASARANOVALIDO.Visible = True
    '            DGVBASECALCULO.Visible = True
    '            TXTMOTIVONOVALIDO.Visible = True
    '            BTN_PASARANO.Visible = True
    '            BTN_PASARSI.Visible = True
    '            LBL_PASASI.Visible = True
    '        Else
    '            LBL_PASARANOVALIDO.Visible = False
    '            DGVBASECALCULO.Visible = False
    '            TXTMOTIVONOVALIDO.Visible = False
    '            BTN_PASARANO.Visible = False
    '            CALCULA_INDICE()
    '        End If
    '    End Sub
    '    Private Sub BTN_BORRAR_BASECALCULO_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR_BASECALCULO.Click
    '        CURSOR_WAIT(True, Me)
    '        BaseCalculoTableAdapter.FillByMESANIO(INFORME_INDICEDataSet.BaseCalculo, AÑO, MES)
    '        For X = 0 To INFORME_INDICEDataSet.BaseCalculo.Rows.Count - 1
    '            INFORME_INDICEDataSet.BaseCalculo.Rows(X).Delete()
    '        Next
    '        BaseCalculoTableAdapter.Update(INFORME_INDICEDataSet.BaseCalculo)
    '        CURSOR_WAIT(False, Me)
    '    End Sub
    '    Private Sub BTN_PASARSI_Click(sender As Object, e As EventArgs) Handles BTN_PASARSI.Click
    '        CALCULA_INDICE()
    '    End Sub
    '    Private Sub AGREGA_BASE_CALCULO(ByVal ID_REC As Integer)


    '        TABLAWEBRow = INFORME_INDICEDataSet.TablaWEB.FindByID_RECLAMO(ID_REC)
    '        RECLAMORow = INFORME_INDICEDataSet.BaseCalculo.FindByidReclamo(ID_REC)
    '        If IsNothing(RECLAMORow) Then
    '            'Evalua las fecha de cierre del reclamo a tener en cuenta para el calculo de indices, VERSION 1 :
    '            'Si encuentra que la falla de cierre de RED es 819 carga esa fecha como fecha de cierre y la falla como falla de cierre del reclamo (No tiene en cuenta
    '            'la falla de origen, despues hace lo mismo para MDU, si se cumple alguna de estas dos situaciones la facha y la fecha corresponde a la de la 819
    '            If TABLAWEBRow.FALLA_CIERRE_RED = Str(819) Then
    '                FECHA_INGRES_REC = TABLAWEBRow.FECHA_ING_RECLAMO
    '                FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_RED
    '                FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_RED
    '                CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_RED

    '            ElseIf TABLAWEBRow.FALLA_CIERRE_MDU = Str(819) Then
    '                FECHA_INGRES_REC = TABLAWEBRow.FECHA_ING_RECLAMO
    '                FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_MDU
    '                FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_MDU
    '                CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_MDU

    '            Else 'Si la falla no es 819 se fija si la falla de RED es 0, si esto es asi busca la falla de MDU y carga esta como fecha de cierre y la falla que corresponda
    '                If TABLAWEBRow.FALLA_CIERRE_RED = 0 Then
    '                    FECHA_INGRES_REC = TABLAWEBRow.HORA_ING_ORDINAL
    '                    FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_MDU
    '                    FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_MDU
    '                    CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_MDU
    '                Else
    '                    FECHA_INGRES_REC = TABLAWEBRow.HORA_ING_ORDINAL
    '                    FALLA_CIERRE_REC = TABLAWEBRow.FALLA_CIERRE_RED
    '                    FECHA_CIERRE_REC = TABLAWEBRow.FECHA_CIERRE_RED
    '                    CAUSA_CIERRE_REC = TABLAWEBRow.CAUSA_CIERRE_RED
    '                End If
    '            End If
    '            '_________________________________________________________________________________________________________________
    '            NEWRECLAMORow = INFORME_INDICEDataSet.BaseCalculo.NewBaseCalculoRow
    '            'Agrega una fila a la tabla de  base de calculo
    '            NEWRECLAMORow.idReclamo = TABLAWEBRow.ID_RECLAMO
    '            NEWRECLAMORow.FallaOrigen = TABLAWEBRow.FALLA_ORI_REC
    '            NEWRECLAMORow.FechaIngreso = TABLAWEBRow.FECHA_ING_RECLAMO
    '            NEWRECLAMORow.FechaIngCalculo = FECHA_INGRES_REC
    '            NEWRECLAMORow.FechaCierreCalculo = FECHA_CIERRE_REC
    '            NEWRECLAMORow.FallaCierre = FALLA_CIERRE_REC
    '            NEWRECLAMORow.CausaCierre = CAUSA_CIERRE_REC
    '            NEWRECLAMORow.Tipo = TABLAWEBRow.TIPO_ORDINAL
    '            NEWRECLAMORow.Sector = TABLAWEBRow.SECTOR_ORDINAL
    '            NEWRECLAMORow.Ordinal = TABLAWEBRow.ORDINAL

    '            'Carga Nodo , Sector y Zona RED

    '            'Rutina para cargar nodo y zona a la tabla de ordinales (Agregar ZONARED)__________________________________________________________

    '            Select Case TABLAWEBRow.ZONA.ToString.Length
    '                Case 3
    '                    COD_ZONE = "  " & TABLAWEBRow.ZONA
    '                Case 4
    '                    COD_ZONE = " " & TABLAWEBRow.ZONA
    '                Case 5
    '                    COD_ZONE = TABLAWEBRow.ZONA
    '            End Select

    '            NEWRECLAMORow.Nodo = LTrim(COD_ZONE.Remove(3))
    '            NEWRECLAMORow.Zona = COD_ZONE.Substring(3)
    '            NODO_RED = LTrim(COD_ZONE.Remove(3))

    '            ZonaRedRow = INFORME_INDICEDataSet.ZonasRED.FindByNodo(NODO_RED)
    '            If IsNothing(ZonaRedRow) = False Then NEWRECLAMORow.ZonaRED = ZonaRedRow("Sector")

    '            'Carga Descripcion de Falla
    '            FallasRow = INFORME_INDICEDataSet.FALLAS.FindByCódigo(FALLA_CIERRE_REC)
    '            NEWRECLAMORow.DescFallaCierre = FallasRow("Descripción")

    '            'Carga Descripcion de Causa
    '            CausasRow = INFORME_INDICEDataSet.CAUSAS.FindByCódigo(CAUSA_CIERRE_REC)
    '            NEWRECLAMORow.DescCausaCierre = CausasRow("Descripción")

    '            'Diferencia de tiempos
    '            datTim1 = CDate(FECHA_INGRES_REC)
    '            datTim2 = CDate(FECHA_CIERRE_REC)

    '            'Dimensiona variables utilizadas en los calculos
    '            Dim CantDiasOPT As Long
    '            Dim CantDiasACE As Long
    '            Dim HoraVen As Integer
    '            Dim MinVen As Integer
    '            Dim HoraAgre As Integer
    '            Dim MinAgre As Integer

    '            'Calcula fecha limite (al dia o al otro dia)_____________________________________________
    '            HoraVen = datTim1.Hour          'Obtiene la hora de la fecha de ingreso
    '            MinVen = datTim1.Minute         'Obtiene los minutos de la fecha de ingreso

    '            HoraAgre = 23 - HoraVen         'Calcula cuantas horas le faltan para llegar a 23:00
    '            MinAgre = 59 - MinVen           'Calcula cuantos minutos le faltan para llegar a 59 minutos

    '            DiaVenc = DateAdd(DateInterval.Day, 1, datTim1)                     'Suma un dia a la fecha de ingreso
    '            DiaVencHora = DateAdd(DateInterval.Hour, HoraAgre, DiaVenc)         'Suma horas hasta que quede en 23:00
    '            DiaVencMin = DateAdd(DateInterval.Minute, MinAgre, DiaVencHora)     'Suma Minutos hasta que quede en 59

    '            'Carga Indice de informe
    '            NEWRECLAMORow.Informe = CInt(TXT_ID_INFORME.Text)

    '            'Carga fecha limite_______________________________________________________________________
    '            NEWRECLAMORow.FechaLimite = DiaVencMin
    '            FECHA_LIM_RECLAMO = DiaVencMin
    '            'Carga Tiempo de Solución_________________________________________________________________
    '            NEWRECLAMORow.TiempoSolución = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '            'Carga Fecha y tiempo de asistencia_______________________________________________________________
    '            If IsDate(TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL) Then
    '                NEWRECLAMORow.FechaAsistencia = TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL
    '                datTim2 = TABLAWEBRow.FCH_INICIO_TRAB_ORDINAL
    '                NEWRECLAMORow.TiempoAsistencia = DateDiff(DateInterval.Minute, datTim1, datTim2)
    '            Else
    '                NEWRECLAMORow.TiempoAsistencia = 0
    '            End If

    '            'Calcula Vencimiento Optimo y Aceptable____________________________________________________
    '            If Trim(TABLAWEBRow.FALLA_ORI_REC) = 97 Then
    '                CantDiasOPT = 2
    '                CantDiasACE = 3
    '            Else
    '                CantDiasOPT = 3
    '                CantDiasACE = 6
    '            End If
    '            NEWRECLAMORow.VencOptimo = DateAdd(DateInterval.Day, CantDiasOPT, datTim1)
    '            FECHA_VENC_OPTIMO = DateAdd(DateInterval.Day, CantDiasOPT, datTim1)
    '            NEWRECLAMORow.VencAceptable = DateAdd(DateInterval.Day, CantDiasACE, datTim1)
    '            FECHA_VENC_ACEPTABLE = DateAdd(DateInterval.Day, CantDiasACE, datTim1)

    '            'Calcula si cumple Tiempo de vencimiento óptimo_____________________________________________
    '            If CDate(FECHA_CIERRE_REC) < FECHA_VENC_OPTIMO Then
    '                NEWRECLAMORow.CumpleIndiceVencOpti = "SI"
    '            Else
    '                NEWRECLAMORow.CumpleIndiceVencOpti = "NO"
    '            End If
    '            '  MsgBox("cumple con vencimiento optimo si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_VENC_OPTIMO)

    '            'Calcula si vence Tiempo de vencimiento Aceptable____________________________________________
    '            If CDate(FECHA_CIERRE_REC) < FECHA_VENC_ACEPTABLE Then
    '                NEWRECLAMORow.CumpleIndiceVencAcep = "SI"
    '            Else
    '                NEWRECLAMORow.CumpleIndiceVencAcep = "NO"
    '            End If
    '            'MsgBox("cumple con vencimiento aceptable si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_VENC_ACEPTABLE)

    '            'Calcula la desviación del tiempo de cumplido con el OPTIMO en minutos _______________________
    '            datTim1 = FECHA_VENC_OPTIMO
    '            datTim2 = FECHA_CIERRE_REC
    '            NEWRECLAMORow.DesviacionVencOpti = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '            'Calcula la desviación del tiempo de cumplido con el ACEPTABLE en minutos _______________________
    '            datTim1 = FECHA_VENC_ACEPTABLE
    '            datTim2 = FECHA_CIERRE_REC
    '            NEWRECLAMORow.DesviacionVencAcep = DateDiff(DateInterval.Minute, datTim1, datTim2)

    '            'Marca si cumple con el tiempo máximo
    '            If CDate(FECHA_CIERRE_REC) < FECHA_LIM_RECLAMO Then
    '                NEWRECLAMORow.CumpleIndiceTM = "SI"
    '            Else
    '                NEWRECLAMORow.CumpleIndiceTM = "NO"
    '            End If
    '            '  MsgBox("cumple con vencimiento maximo si " & CDate(FECHA_CIERRE_REC) & " menor que " & FECHA_LIM_RECLAMO)

    '            'Calcula la desviación con el TM_________________________________________________________________
    '            datTim1 = FECHA_LIM_RECLAMO
    '            datTim2 = FECHA_CIERRE_REC
    '            NEWRECLAMORow.DesviacionTM = DateDiff(DateInterval.Minute, datTim1, datTim2)
    '            'Agrega una nueva Fila___________________________________________________________________________
    '            INFORME_INDICEDataSet.BaseCalculo.Rows.Add(NEWRECLAMORow)
    '        End If
    '    End Sub
    '    Private Sub BTN_PASARANO_Click(sender As Object, e As EventArgs) Handles BTN_PASARANO.Click
    '        MsgBox("HAS SELECCIONADO EL RECLAMO " & DGVBASECALCULO.CurrentRow.Cells.Item(1).Value)
    '        Dim RECLAMO = DGVBASECALCULO.CurrentRow.Cells.Item(1).Value
    '        TablaWEBTableAdapter.FillByID_RECLAMO(INFORME_INDICEDataSet1.TablaWEB, RECLAMO)
    '        RECLAMORow = INFORME_INDICEDataSet1.TablaWEB.Rows(0)
    '        RECLAMORow("VALIDO_INDICE") = "NO"
    '        RECLAMORow("MOTIVO") = TXTMOTIVONOVALIDO.Text
    '        TablaWEBTableAdapter.Update(RECLAMORow)

    '        'BORRA EL REGISTRO EN BASE CALCULO
    '        BaseCalculoTableAdapter.FillByID_RECLAMO(INFORME_INDICEDataSet.BaseCalculo, RECLAMO)
    '        INFORME_INDICEDataSet.BaseCalculo.Rows(0).Delete()
    '        BaseCalculoTableAdapter.Update(INFORME_INDICEDataSet.BaseCalculo)
    '        INFORME_INDICEDataSet1.BaseCalculo.Rows(DGVBASECALCULO.CurrentRow.Index).Delete()
    '        '  BaseCalculoTableAdapter.Update(INFORME_INDICEDataSet1.BaseCalculo)
    '        If DGVBASECALCULO.Rows.Count = 0 Then
    '            BaseCalculoTableAdapter.FillByMESANIO(INFORME_INDICEDataSet.BaseCalculo, AÑO, MES)
    '            TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "SI")
    '            CALCULA_INDICE()
    '        End If
    '    End Sub
    '    Private Sub DGVBASECALCULO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBASECALCULO.CellClick
    '        If DGVBASECALCULO.Rows.Count > 0 Then
    '            ' MsgBox(DGVBASECALCULO.CurrentRow.Cells.Item(1).Value)
    '            'For x = 0 To DGVBASECALCULO.Rows.Count - 1
    '            '    If DGVBASECALCULO.CurrentRow.Cells.Item(0).Value = DGVBASECALCULO.Rows(x).Cells.Item(0).Value Then
    '            '        DGVBASECALCULO.Rows(x).Selected = True
    '            '    End If
    '            'Next
    '        End If
    '    End Sub
    '    Private Sub CALCULA_INDICE()
    '        BaseCalculoTableAdapter.FillByMESANIO(INFORME_INDICEDataSet.BaseCalculo, AÑO, MES)

    '        CANT_REC_97 = 0
    '        CANT_REC_OTROS = 0
    '        CANT_REC_ALL = 0
    '        CANT_REC_97_CUMPTM = 0
    '        CANT_REC_OTROS_CUMPTM = 0
    '        CANT_REC_ALL_CUMPTM = 0
    '        PERCENT_97 = 0.0
    '        PERCENT_ALL = 0.0
    '        SUMA_TIE_97 = 0
    '        PROM_TIE_97 = 0
    '        SUMA_TIE_ASIST_97 = 0
    '        PROM_TIE_ASIST_97 = 0
    '        SUMA_TIE_OTROS = 0
    '        PROM_TIE_OTROS = 0
    '        SUMA_TIE_ALL = 0
    '        PROM_TIE_ALL = 0
    '        CANT_97_CUMPLE_ACEP = 0
    '        CANT_97_CUMPLE_OPT = 0
    '        CANT_OTROS_CUMPLE_OPT = 0
    '        CANT_OTROS_CUMPLE_ACE = 0
    '        CANT_ALL_CUMPLE_ACEP = 0
    '        CANT_ALL_CUMPLE_OPT = 0
    '        TIEM_MAX_97 = 0
    '        TIEM_MAX_97_STR = 0
    '        TIEM_MAX_TODOS = 0
    '        TIEM_MAX_TODOS_STR = 0

    '        CANT_REC_97_RED_MANT_OTR = 0
    '        CANT_REC_97_RED_MANT_CXM = 0
    '        CANT_REC_97_MDU_MANT_OTR = 0
    '        CANT_REC_97_MDU_MANT_CXM = 0
    '        CANT_REC_97_RED_CORR_OTR = 0
    '        CANT_REC_97_RED_CORR_CXM = 0
    '        CANT_REC_97_MDU_CORR_OTR = 0
    '        CANT_REC_97_MDU_CORR_CXM = 0

    '        TIEM_REC_97_RED_MANT_OTR = 0
    '        TIEM_REC_97_RED_MANT_CXM = 0
    '        TIEM_REC_97_MDU_MANT_OTR = 0
    '        TIEM_REC_97_MDU_MANT_CXM = 0
    '        TIEM_REC_97_RED_CORR_OTR = 0
    '        TIEM_REC_97_RED_CORR_CXM = 0
    '        TIEM_REC_97_MDU_CORR_OTR = 0
    '        TIEM_REC_97_MDU_CORR_CXM = 0

    '        CANT_REC_OTR_RED_MANT = 0
    '        CANT_REC_OTR_RED_CORR = 0
    '        CANT_REC_OTR_MDU_MANT = 0
    '        CANT_REC_OTR_MDU_CORR = 0

    '        TIEMP_VIDA_97 = 0
    '        TIEMP_ASIST_97 = 0
    '        CANT_ASIST_97 = 0
    '        TIEMP_VIDA_OTROS = 0
    '        TIEMP_ASIST_OTROS = 0
    '        CANT_ASIST_OTROS = 0
    '        TIEMP_VIDA_TOTAL = 0
    '        TIEMP_ASIST_TOTAL = 0
    '        CANT_ASIST_TOTAL = 0
    '        TIEMP_TRAB_TOTAL = 0
    '        TIEMPO_TRAB_PROM = 0
    '        CANT_TRAB_TOTAL = 0

    '        If INFORME_INDICEDataSet.BaseCalculo.Rows.Count > 0 Then
    '            For CONTADOR = 0 To INFORME_INDICEDataSet.BaseCalculo.Rows.Count - 1
    '                BASECALCULORow = INFORME_INDICEDataSet.BaseCalculo.Rows(CONTADOR)

    '                Select Case BASECALCULORow.FallaOrigen
    '                    Case 97 'Analiza los casos de reclamos de Sin señal
    '                        CANT_REC_97 = CANT_REC_97 + 1
    '                        'Identifica el sector
    '                        If Trim(BASECALCULORow.Sector) = "MDU" Then  'Si el sector es MDU
    '                            'identifica el tipo de ORDINAL
    '                            If Trim(BASECALCULORow.Tipo) = "TAREA" Then  'Si el tipo de Ordinal es MDU MANTENIMIENTO
    '                                'Identifica si la falla de cierre es CXM
    '                                If BASECALCULORow.FallaCierre = 819 Then    'MDU MANTENIMIENTO  CXM
    '                                    CANT_REC_97_MDU_MANT_CXM = CANT_REC_97_MDU_MANT_CXM + 1
    '                                    TIEM_REC_97_MDU_MANT_CXM = TIEM_REC_97_MDU_MANT_CXM + BASECALCULORow.TiempoSolución
    '                                Else  'MDU MANTENIMIENTO OTR
    '                                    CANT_REC_97_MDU_MANT_OTR = CANT_REC_97_MDU_MANT_OTR + 1
    '                                    TIEM_REC_97_MDU_MANT_OTR = TIEM_REC_97_MDU_MANT_OTR + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de Vida del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    TIEMP_VIDA_97 = TIEMP_VIDA_97 + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de asistenacia del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                        TIEMP_ASIST_97 = TIEMP_ASIST_97 + BASECALCULORow.TiempoAsistencia
    '                                        CANT_ASIST_97 = CANT_ASIST_97 + 1
    '                                    End If
    '                                End If
    '                            ElseIf Trim(BASECALCULORow.Tipo) = "CORRECTIVO" Then  'Si el tipo de ordinal ES MDU CORRECTIVO
    '                                'Identifica si la falla de cierre es CXM
    '                                If BASECALCULORow.FallaCierre = 819 Then 'MDU CORRECTIVO CXM
    '                                    CANT_REC_97_MDU_CORR_CXM = CANT_REC_97_MDU_CORR_CXM + 1
    '                                    TIEM_REC_97_MDU_CORR_CXM = TIEM_REC_97_MDU_CORR_CXM + BASECALCULORow.TiempoSolución
    '                                Else  'MDU CORRECTIVO OTR
    '                                    CANT_REC_97_MDU_CORR_OTR = CANT_REC_97_MDU_CORR_OTR + 1
    '                                    TIEM_REC_97_MDU_CORR_OTR = TIEM_REC_97_MDU_CORR_OTR + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de Vida del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    TIEMP_VIDA_97 = TIEMP_VIDA_97 + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de asistenacia del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                        TIEMP_ASIST_97 = TIEMP_ASIST_97 + BASECALCULORow.TiempoAsistencia
    '                                        CANT_ASIST_97 = CANT_ASIST_97 + 1
    '                                    End If

    '                                End If
    '                            End If


    '                        Else  'Si el sector es Mantenimiento de RED o CABLEADO
    '                            'identifica el tipo de ORDINAL
    '                            If Trim(BASECALCULORow.Tipo) = "TAREA" Then   'Si el tipo de Ordinal es RED MANTENIMIENTO
    '                                'Identifica si la falla de cierre es CXM
    '                                If BASECALCULORow.FallaCierre = 819 Then     'RED MANTENIMIENTO  CXM
    '                                    CANT_REC_97_RED_MANT_CXM = CANT_REC_97_RED_MANT_CXM + 1
    '                                    TIEM_REC_97_RED_MANT_CXM = TIEM_REC_97_RED_MANT_CXM + BASECALCULORow.TiempoSolución
    '                                Else  'RED MANTENIMIENTO OTR
    '                                    CANT_REC_97_RED_MANT_OTR = CANT_REC_97_RED_MANT_OTR + 1
    '                                    TIEM_REC_97_RED_MANT_OTR = TIEM_REC_97_RED_MANT_OTR + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de Vida del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    TIEMP_VIDA_97 = TIEMP_VIDA_97 + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de asistenacia del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                        TIEMP_ASIST_97 = TIEMP_ASIST_97 + BASECALCULORow.TiempoAsistencia
    '                                        CANT_ASIST_97 = CANT_ASIST_97 + 1
    '                                    End If
    '                                End If
    '                            ElseIf Trim(BASECALCULORow.Tipo) = "CORRECTIVO" Then 'Si el tipo de ordinal es RED CORRECTIVO
    '                                'Identifica si la falla de cierre es CXM
    '                                If BASECALCULORow.FallaCierre = 819 Then   'RED CORRECTIVO CXM
    '                                    CANT_REC_97_RED_CORR_CXM = CANT_REC_97_RED_CORR_CXM + 1
    '                                    TIEM_REC_97_RED_CORR_CXM = TIEM_REC_97_RED_CORR_CXM + BASECALCULORow.TiempoSolución
    '                                Else 'RED CORRECTIVO OTR
    '                                    CANT_REC_97_RED_CORR_OTR = CANT_REC_97_RED_CORR_OTR + 1
    '                                    TIEM_REC_97_RED_CORR_OTR = TIEM_REC_97_RED_CORR_OTR + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de Vida del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    TIEMP_VIDA_97 = TIEMP_VIDA_97 + BASECALCULORow.TiempoSolución
    '                                    'Carga el tiempo de asistenacia del ordinal si la falla es 97 y no por corte de mantenimiento
    '                                    If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                        TIEMP_ASIST_97 = TIEMP_ASIST_97 + BASECALCULORow.TiempoAsistencia
    '                                        CANT_ASIST_97 = CANT_ASIST_97 + 1
    '                                    End If
    '                                End If
    '                            End If
    '                        End If

    '                        'Cuenta los reclamos SIN SEÑAL que estan realizados dentro del TIEMPO OPTIMO
    '                        If BASECALCULORow.CumpleIndiceVencOpti = "SI" Then
    '                            CANT_97_CUMPLE_OPT = CANT_97_CUMPLE_OPT + 1
    '                        Else
    '                            'Cuenta los reclamos SIN SEÑAL que si NO cumplen el TIEMPO OPTIMO, cumplen con el tiempo ACEPTABLE
    '                            If BASECALCULORow.CumpleIndiceVencAcep = "SI" Then
    '                                CANT_97_CUMPLE_ACEP = CANT_97_CUMPLE_ACEP + 1
    '                            End If
    '                        End If

    '                        'Suma los tiempos y cuenta los reclamos  SIN SEÑAL que cumplen la condicion de T. resol < TM
    '                        If BASECALCULORow.CumpleIndiceTM = "SI" Then
    '                            CANT_REC_97_CUMPTM = CANT_REC_97_CUMPTM + 1
    '                            SUMA_TIE_97 = BASECALCULORow.TiempoSolución + SUMA_TIE_97
    '                        Else
    '                            'Solo suma el tiempo de resolucion para calcular el Tiemo Promedio
    '                            SUMA_TIE_97 = BASECALCULORow.TiempoSolución + SUMA_TIE_97
    '                        End If
    '                        'Elige el TIEMPO MAXIMO DE SOLUCION de reclamos de RED con falla 97 (Sin SEñal)
    '                        If BASECALCULORow.TiempoSolución > TIEM_MAX_97 Then
    '                            TIEM_MAX_97 = BASECALCULORow.TiempoSolución
    '                        End If
    ''____________________________Hasta aqui se procesan los reclamos SIN SEÑAL________________________________________________________________________________________

    '                    Case Is <> 97 ' Analiza los todos los reclamos que no son Sin Señal
    '                        'Identifica el sector
    '                        'Si el sector es MDU
    '                        If Trim(BASECALCULORow.Sector) = "MDU" Then
    '                            'identifica el tipo de ORDINAL
    '                            'Si el tipo de Ordinal es MDU MANTENIMIENTO
    '                            If Trim(BASECALCULORow.Tipo) = "TAREA" Then

    '                                CANT_REC_OTR_MDU_MANT = CANT_REC_OTR_MDU_MANT + 1

    '                                'Carga el tiempo de vida del ordinal que no es sin señal
    '                                TIEMP_VIDA_OTROS = TIEMP_VIDA_OTROS + BASECALCULORow.TiempoSolución
    '                                'Carga el tiempo de asistencia para otras fallas que no sean sin señal
    '                                If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                    TIEMP_ASIST_OTROS = TIEMP_ASIST_OTROS + BASECALCULORow.TiempoAsistencia
    '                                    CANT_ASIST_OTROS = CANT_ASIST_OTROS + 1
    '                                End If
    '                                'Si el tipo de ordinal ES MDU CORRECTIVO
    '                            ElseIf Trim(BASECALCULORow.Tipo) = "CORRECTIVO" Then

    '                                CANT_REC_OTR_MDU_CORR = CANT_REC_OTR_MDU_CORR + 1

    '                                'Carga el tiempo de vida del ordinal que no es sin señal
    '                                TIEMP_VIDA_OTROS = TIEMP_VIDA_OTROS + BASECALCULORow.TiempoSolución
    '                                'Carga el tiempo de asistencia para otras fallas que no sean sin señal
    '                                If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                    TIEMP_ASIST_OTROS = TIEMP_ASIST_OTROS + BASECALCULORow.TiempoAsistencia
    '                                    CANT_ASIST_OTROS = CANT_ASIST_OTROS + 1
    '                                End If
    '                            End If

    '                            'Si el sector es Mantenimiento de RED o CABLEADO
    '                        Else
    '                            'identifica el tipo de ORDINAL
    '                            'Si el tipo de Ordinal es RED MANTENIMIENTO
    '                            If Trim(BASECALCULORow.Tipo) = "TAREA" Then

    '                                CANT_REC_OTR_RED_MANT = CANT_REC_OTR_RED_MANT + 1

    '                                'Carga el tiempo de vida del ordinal que no es sin señal
    '                                TIEMP_VIDA_OTROS = TIEMP_VIDA_OTROS + BASECALCULORow.TiempoSolución
    '                                'Carga el tiempo de asistencia para otras fallas que no sean sin señal
    '                                If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                    TIEMP_ASIST_OTROS = TIEMP_ASIST_OTROS + BASECALCULORow.TiempoAsistencia
    '                                    CANT_ASIST_OTROS = CANT_ASIST_OTROS + 1
    '                                End If

    '                                'Si el tipo de ordinal es RED CORRECTIVO
    '                            ElseIf Trim(BASECALCULORow.Tipo) = "CORRECTIVO" Then

    '                                CANT_REC_OTR_RED_CORR = CANT_REC_OTR_RED_CORR + 1

    '                                'Carga el tiempo de vida del ordinal que no es sin señal
    '                                TIEMP_VIDA_OTROS = TIEMP_VIDA_OTROS + BASECALCULORow.TiempoSolución
    '                                'Carga el tiempo de asistencia para otras fallas que no sean sin señal
    '                                If BASECALCULORow.TiempoAsistencia > 0 Then
    '                                    TIEMP_ASIST_OTROS = TIEMP_ASIST_OTROS + BASECALCULORow.TiempoAsistencia
    '                                    CANT_ASIST_OTROS = CANT_ASIST_OTROS + 1
    '                                End If
    '                            End If
    '                        End If
    '                        CANT_REC_OTROS = CANT_REC_OTROS + 1
    '                        'Cuenta los reclamos diferentes a SIN SEÑAL que estan realizados dentro del TIEMPO OPTIMO
    '                        If BASECALCULORow.CumpleIndiceVencOpti = "SI" Then
    '                            CANT_OTROS_CUMPLE_OPT = CANT_OTROS_CUMPLE_OPT + 1
    '                        Else
    '                            'Cuenta los reclamos diferentes de SIN SEÑAL que si NO cumplen el TIEMPO OPTIMO, cumplen con el tiempo ACEPTABLE
    '                            If BASECALCULORow.CumpleIndiceVencAcep = "SI" Then
    '                                CANT_OTROS_CUMPLE_ACE = CANT_OTROS_CUMPLE_ACE + 1
    '                            End If
    '                        End If
    '                        'Suma los tiempos y cuenta los reclamos  SIN SEÑAL que cumplen la condicion de T. resol < TM
    '                        If BASECALCULORow.CumpleIndiceTM = "SI" Then
    '                            CANT_REC_OTROS_CUMPTM = CANT_REC_OTROS_CUMPTM + 1
    '                            SUMA_TIE_OTROS = BASECALCULORow.TiempoSolución + SUMA_TIE_OTROS
    '                        Else
    '                            'Solo suma el tiempo de resolucion para calcular el Tiemo Promedio
    '                            SUMA_TIE_OTROS = BASECALCULORow.TiempoSolución + SUMA_TIE_OTROS
    '                        End If

    '                        'Elige el TIEMPO MAXIMO DE SOLUCION de reclamos de RED con falla distinta de 97 (Sin SEñal)
    '                        If BASECALCULORow.TiempoSolución > TIEM_MAX_TODOS Then
    '                            TIEM_MAX_TODOS = BASECALCULORow.TiempoSolución
    '                        End If
    '                End Select
    '                PROCESOS.PROGRESS_BAR("LLENANDO INFORMACION A MOSTRAR", INFORME_INDICEDataSet.BaseCalculo.Rows.Count, CONTADOR + 1)
    '            Next

    '            CANT_REC_ALL = CANT_REC_97 + CANT_REC_OTROS                                     'Carga Variable con suma total de reclamos analizados
    '            CANT_REC_ALL_CUMPTM = CANT_REC_97_CUMPTM + CANT_REC_OTROS_CUMPTM                'Carga la cantidad de reclamos totales que cumplen con el TM
    '            PERCENT_97 = CANT_REC_97_CUMPTM / CANT_REC_97                                   'Calcula el % de reclamos solucionados dentro del TM (Falla 97)
    '            PERCENT_ALL = CANT_REC_ALL_CUMPTM / CANT_REC_ALL                                'Calcula el % de reclamos solucionados dentro del TM <> (Falla 97)
    '            CANT_ALL_CUMPLE_OPT = CANT_97_CUMPLE_OPT + CANT_OTROS_CUMPLE_OPT
    '            CANT_ALL_CUMPLE_ACEP = CANT_97_CUMPLE_ACEP + CANT_OTROS_CUMPLE_ACE
    '            'Formato para mostrar el tiempo MAXIMO de resolución de reclamos Sin Señal
    '            HORAS = Int(TIEM_MAX_97 / 60)                                                   'Extrae las horas de la cantidad de minutos promedio
    '            MINUTOS = Int(TIEM_MAX_97 - (HORAS * 60))                                       'Extrae los minutos de la cantidad de minutos prom (sacando las horas)
    '            TIEM_MAX_97_STR = (Format(HORAS, "#00"))                                        'conforma el STR que muestra el tiempo promedio de solcucion con formato

    '            'Formato para mostrar el tiempo MAXIMO de resolución de reclamos de otros tipos (menos 97 SIn señal)
    '            HORAS = Int(TIEM_MAX_TODOS / 60)                                                'Extrae las horas de la cantidad de minutos promedio
    '            MINUTOS = TIEM_MAX_TODOS - (HORAS * 60)                                         'Extrae los minutos de la cantidad de minutos prom (sacando las horas)
    '            TIEM_MAX_TODOS_STR = (Format(HORAS, "#00"))                                     'conforma el STR que muestra el tiempo promedio de solcucion con formato

    '            'Calcula el tiempo promedio de resolución de reclamos Sin Señal
    '            HORAS = (Int(Int((SUMA_TIE_97 / CANT_REC_97)) / 60))                            'Extrae las horas de la cantidad de minutos promedio
    '            MINUTOS = Int(SUMA_TIE_97 / CANT_REC_97) - (HORAS * 60)                         'Extrae los minutos de la cantidad de minutos prom (sacando las horas)
    '            PROM_TIE_97 = (Format(HORAS, "00")) & ":" & Format(MINUTOS, "00")               'conforma el STR que muestra el tiempo promedio de solcucion con formato

    '            'Calcula el tiempo promedio de resolución de reclamos diferentes a Sin Señal
    '            HORAS = (Int(Int((SUMA_TIE_OTROS / CANT_REC_OTROS)) / 60))                      'Extrae las horas de la cantidad de minutos promedio
    '            MINUTOS = Int(SUMA_TIE_OTROS / CANT_REC_OTROS) - (HORAS * 60)                   'Extrae los minutos de la cantidad de minutos prom (sacando las horas)
    '            PROM_TIE_OTROS = (Format(HORAS, "00")) & ":" & Format(MINUTOS, "00")            'conforma el STR que muestra el tiempo promedio de solcucion con formato

    '            'Calcula el tiempo promedio de resolución de todos los reclamos
    '            CANT_REC_ALL = CANT_REC_97 + CANT_REC_OTROS
    '            SUMA_TIE_ALL = SUMA_TIE_97 + SUMA_TIE_OTROS
    '            HORAS = (Int(Int((SUMA_TIE_ALL / CANT_REC_ALL)) / 60))                          'Extrae las horas de la cantidad de minutos promedio
    '            MINUTOS = Int(SUMA_TIE_ALL / CANT_REC_ALL) - (HORAS * 60)                       'Extrae los minutos de la cantidad de minutos prom (sacando las horas)
    '            PROM_TIE_ALL = (Format(HORAS, "00")) & ":" & Format(MINUTOS, "00")              'conforma el STR que muestra el tiempo promedio de solcucion con formato


    '            'Carga las etiquetas del formulario con los datos obtenidos
    '            PROCESOS.Label16.Text = (CANT_REC_97)
    '            VALOR_INDICE(36) = (CANT_REC_97)
    '            VALOR_NUM_INDICE(36) = (CANT_REC_97)

    '            PROCESOS.Label17.Text = (CANT_REC_ALL)
    '            VALOR_INDICE(41) = (CANT_REC_ALL)
    '            VALOR_NUM_INDICE(41) = (CANT_REC_ALL)

    '            PROCESOS.Label19.Text = (CANT_REC_97_CUMPTM)
    '            VALOR_INDICE(37) = (CANT_REC_97_CUMPTM)
    '            VALOR_NUM_INDICE(37) = (CANT_REC_97_CUMPTM)

    '            PROCESOS.Label21.Text = (CANT_REC_ALL_CUMPTM)
    '            VALOR_INDICE(42) = (CANT_REC_ALL_CUMPTM)
    '            VALOR_NUM_INDICE(42) = (CANT_REC_ALL_CUMPTM)

    '            'Calcula el Indice Nro 1 (Porcentaje de reclamos sin señal solucionados al dia o al otro dia)
    '            PROCESOS.TextBox1.Text = FormatPercent(PERCENT_97)
    '            VALOR_INDICE(1) = FormatPercent(PERCENT_97)
    '            VALOR_NUM_INDICE(1) = FormatNumber(PERCENT_97 * 100, 2)

    '            'Calcula el Indice Nro 1 (Porcentaje de reclamos DE CUALQUIER TIPO solucionados al dia o al otro dia)
    '            PROCESOS.TextBox2.Text = FormatPercent(PERCENT_ALL)
    '            VALOR_INDICE(2) = FormatPercent(PERCENT_ALL)
    '            VALOR_NUM_INDICE(2) = FormatNumber(PERCENT_ALL * 100, 2)

    '            'Carga en el formulario el tiempo promedio de sol, de los reclamos = falla 97
    '            PROCESOS.TextBox3.Text = (PROM_TIE_97)
    '            VALOR_INDICE(3) = (PROM_TIE_97)
    '            VALOR_NUM_INDICE(3) = FormatNumber((SUMA_TIE_97 / CANT_REC_97) / 60, 2)

    '            'Carga el tiempo MAXIMO de resolucion de reclamos con falla 97
    '            PROCESOS.TextBox6.Text = TIEM_MAX_97_STR
    '            VALOR_INDICE(4) = TIEM_MAX_97_STR
    '            VALOR_NUM_INDICE(4) = FormatNumber((TIEM_MAX_97 / 60), 2)

    '            'Carga el tiempo MAXIMO de resolucion de reclamos con CUALQUIER FALLA
    '            PROCESOS.TextBox7.Text = TIEM_MAX_TODOS_STR
    '            VALOR_INDICE(5) = TIEM_MAX_TODOS_STR
    '            VALOR_NUM_INDICE(5) = FormatNumber((TIEM_MAX_TODOS / 60), 2)

    '            'Carga en el formulario el tiempo promedio de sol, de los reclamos <> falla 97
    '            PROCESOS.TextBox4.Text = (PROM_TIE_OTROS)
    '            VALOR_INDICE(6) = (PROM_TIE_OTROS)
    '            VALOR_NUM_INDICE(6) = FormatNumber((SUMA_TIE_OTROS / CANT_REC_OTROS) / 60, 2)

    '            'Carga en el formulario el tiempo promedio de sol, de los reclamos totales
    '            PROCESOS.TextBox5.Text = (PROM_TIE_ALL)
    '            VALOR_NUM_INDICE(7) = FormatNumber((SUMA_TIE_ALL / CANT_REC_ALL) / 60, 2)

    '            PROCESOS.Label31.Text = CANT_97_CUMPLE_OPT
    '            VALOR_INDICE(38) = CANT_97_CUMPLE_OPT
    '            VALOR_NUM_INDICE(38) = CANT_97_CUMPLE_OPT


    '            PROCESOS.Label33.Text = CANT_97_CUMPLE_ACEP
    '            VALOR_INDICE(39) = CANT_97_CUMPLE_ACEP
    '            VALOR_NUM_INDICE(39) = CANT_97_CUMPLE_ACEP

    '            PROCESOS.Label35.Text = CANT_ALL_CUMPLE_OPT
    '            VALOR_INDICE(43) = CANT_ALL_CUMPLE_OPT
    '            VALOR_NUM_INDICE(43) = CANT_ALL_CUMPLE_OPT

    '            PROCESOS.Label37.Text = CANT_ALL_CUMPLE_ACEP
    '            VALOR_INDICE(44) = CANT_ALL_CUMPLE_ACEP
    '            VALOR_NUM_INDICE(44) = CANT_ALL_CUMPLE_ACEP

    '            PROCESOS.Label39.Text = (CANT_REC_97 - CANT_97_CUMPLE_OPT - CANT_97_CUMPLE_ACEP)
    '            VALOR_INDICE(40) = (CANT_REC_97 - CANT_97_CUMPLE_OPT - CANT_97_CUMPLE_ACEP)
    '            VALOR_NUM_INDICE(40) = (CANT_REC_97 - CANT_97_CUMPLE_OPT - CANT_97_CUMPLE_ACEP)

    '            PROCESOS.Label42.Text = (CANT_REC_ALL - CANT_ALL_CUMPLE_OPT - CANT_ALL_CUMPLE_ACEP)
    '            VALOR_INDICE(45) = (CANT_REC_ALL - CANT_ALL_CUMPLE_OPT - CANT_ALL_CUMPLE_ACEP)
    '            VALOR_NUM_INDICE(45) = (CANT_REC_ALL - CANT_ALL_CUMPLE_OPT - CANT_ALL_CUMPLE_ACEP)

    '            VALOR_INDICE(46) = FormatPercent(CANT_97_CUMPLE_ACEP / (CANT_REC_97))
    '            VALOR_NUM_INDICE(46) = FormatNumber((CANT_97_CUMPLE_ACEP / CANT_REC_97) * 100, 2)

    '            VALOR_INDICE(47) = FormatPercent((CANT_REC_97 - CANT_97_CUMPLE_OPT - CANT_97_CUMPLE_ACEP) / (CANT_REC_97))
    '            VALOR_NUM_INDICE(47) = FormatNumber(((CANT_REC_97 - CANT_97_CUMPLE_OPT - CANT_97_CUMPLE_ACEP) / CANT_REC_97) * 100, 2)

    '            VALOR_INDICE(48) = FormatPercent(CANT_ALL_CUMPLE_ACEP / (CANT_REC_ALL))
    '            VALOR_NUM_INDICE(48) = FormatNumber((CANT_ALL_CUMPLE_ACEP / CANT_REC_ALL) * 100, 2)

    '            VALOR_INDICE(49) = FormatPercent((CANT_REC_ALL - CANT_ALL_CUMPLE_OPT - CANT_ALL_CUMPLE_ACEP) / (CANT_REC_ALL))
    '            VALOR_NUM_INDICE(49) = FormatNumber(((CANT_REC_ALL - CANT_ALL_CUMPLE_OPT - CANT_ALL_CUMPLE_ACEP) / CANT_REC_ALL) * 100, 2)

    '            'Carga la cantidad de reclamos sin señal en MANT RED excluidos CXM
    '            PROCESOS.TextBox21.Text = CANT_REC_97_RED_MANT_OTR
    '            VALOR_INDICE(17) = CANT_REC_97_RED_MANT_OTR
    '            VALOR_NUM_INDICE(17) = CANT_REC_97_RED_MANT_OTR

    '            'Carga la cantidad de reclamos sin señal en CORR RED excluidos CXM
    '            PROCESOS.TextBox20.Text = CANT_REC_97_RED_CORR_OTR
    '            VALOR_INDICE(18) = CANT_REC_97_RED_CORR_OTR
    '            VALOR_NUM_INDICE(18) = CANT_REC_97_RED_CORR_OTR

    '            'Carga la cantidad de reclamos sin señal en MANT MDU excluidos CXM
    '            PROCESOS.TextBox23.Text = CANT_REC_97_MDU_MANT_OTR
    '            VALOR_INDICE(19) = CANT_REC_97_MDU_MANT_OTR
    '            VALOR_NUM_INDICE(19) = CANT_REC_97_MDU_MANT_OTR

    '            'Carga la cantidad de reclamos sin señal en CORR MDU excluidos CXM
    '            PROCESOS.TextBox22.Text = CANT_REC_97_MDU_CORR_OTR
    '            VALOR_INDICE(20) = CANT_REC_97_MDU_CORR_OTR
    '            VALOR_NUM_INDICE(20) = CANT_REC_97_MDU_CORR_OTR

    '            'Carga la cantidad de reclamos sin señal en MANT RED causados x CXM
    '            PROCESOS.TextBox33.Text = CANT_REC_97_RED_MANT_CXM
    '            VALOR_INDICE(21) = CANT_REC_97_RED_MANT_CXM
    '            VALOR_NUM_INDICE(21) = CANT_REC_97_RED_MANT_CXM

    '            'Carga la cantidad de reclamos sin señal en CORR RED causados x CXM
    '            PROCESOS.TextBox32.Text = CANT_REC_97_RED_CORR_CXM
    '            VALOR_INDICE(23) = CANT_REC_97_RED_CORR_CXM
    '            VALOR_NUM_INDICE(23) = CANT_REC_97_RED_CORR_CXM

    '            'Carga la cantidad de reclamos sin señal en MANT MDU causados x CXM
    '            PROCESOS.TextBox35.Text = CANT_REC_97_MDU_MANT_CXM
    '            VALOR_INDICE(26) = CANT_REC_97_MDU_MANT_CXM
    '            VALOR_NUM_INDICE(26) = CANT_REC_97_MDU_MANT_CXM
    '            'Carga la cantidad de reclamos sin señal en CORR MDU causados x CXM
    '            PROCESOS.TextBox34.Text = CANT_REC_97_MDU_CORR_CXM
    '            VALOR_INDICE(28) = CANT_REC_97_MDU_CORR_CXM
    '            VALOR_NUM_INDICE(28) = CANT_REC_97_MDU_CORR_CXM

    '            PROCESOS.TextBox8.Text = CANT_REC_OTR_RED_MANT
    '            PROCESOS.TextBox10.Text = CANT_REC_OTR_RED_CORR
    '            PROCESOS.TextBox12.Text = CANT_REC_OTR_MDU_MANT
    '            PROCESOS.TextBox14.Text = CANT_REC_OTR_MDU_CORR

    '            PROCESOS.TextBox25.Text = Int(TIEM_REC_97_RED_MANT_OTR / 60)
    '            'Carga el tiempo de corte excluido los de mantenimiento en CORR RED
    '            PROCESOS.TextBox24.Text = Int(TIEM_REC_97_RED_CORR_OTR / 60)
    '            VALOR_INDICE(32) = Int(TIEM_REC_97_RED_CORR_OTR / 60)
    '            VALOR_NUM_INDICE(32) = FormatNumber((TIEM_REC_97_RED_CORR_OTR / 60), 2)
    '            'Carga el tiempo en Horas de corte x mantenimiento en MANT RED
    '            PROCESOS.TextBox27.Text = Int(TIEM_REC_97_RED_MANT_CXM / 60)
    '            VALOR_INDICE(22) = Int(TIEM_REC_97_RED_MANT_CXM / 60)
    '            VALOR_NUM_INDICE(22) = FormatNumber((TIEM_REC_97_RED_MANT_CXM / 60), 2)
    '            'Carga el tiempo en Horas de corte x mantenimiento en CORR RED
    '            PROCESOS.TextBox26.Text = Int(TIEM_REC_97_RED_CORR_CXM / 60)
    '            VALOR_INDICE(24) = Int(TIEM_REC_97_RED_CORR_CXM / 60)
    '            VALOR_NUM_INDICE(24) = FormatNumber((TIEM_REC_97_RED_CORR_CXM / 60), 2)

    '            PROCESOS.TextBox31.Text = Int(TIEM_REC_97_MDU_MANT_OTR / 60)

    '            'Carga el tiempo de corte excluido los de mantenimiento en CORR MDU
    '            PROCESOS.TextBox30.Text = Int(TIEM_REC_97_MDU_CORR_OTR / 60)
    '            VALOR_INDICE(33) = Int(TIEM_REC_97_MDU_CORR_OTR / 60)
    '            VALOR_NUM_INDICE(33) = FormatNumber((TIEM_REC_97_MDU_CORR_OTR / 60), 2)
    '            'Carga el tiempo en Horas de corte x mantenimiento en MANT MDU
    '            PROCESOS.TextBox29.Text = Int(TIEM_REC_97_MDU_MANT_CXM / 60)
    '            VALOR_INDICE(27) = Int(TIEM_REC_97_MDU_MANT_CXM / 60)
    '            VALOR_NUM_INDICE(27) = FormatNumber((TIEM_REC_97_MDU_MANT_CXM / 60), 2)
    '            'Carga el tiempo en Horas de corte x mantenimiento en CORR MDU
    '            PROCESOS.TextBox28.Text = Int(TIEM_REC_97_MDU_CORR_CXM / 60)
    '            VALOR_INDICE(30) = Int(TIEM_REC_97_MDU_CORR_CXM / 60)
    '            VALOR_NUM_INDICE(30) = FormatNumber((TIEM_REC_97_MDU_CORR_CXM / 60), 2)

    '            PROCESOS.TextBox36.Text = Int((TIEMP_VIDA_97 / (CANT_REC_97_RED_MANT_OTR + CANT_REC_97_RED_CORR_OTR + CANT_REC_97_MDU_MANT_OTR + CANT_REC_97_MDU_CORR_OTR)) / 60)

    '            'Carga el promedio de tiempo de asistencia de reclamos SIN SEÑAL
    '            PROCESOS.TextBox37.Text = Int((TIEMP_ASIST_97 / CANT_ASIST_97) / 60)
    '            VALOR_INDICE(8) = Int((TIEMP_ASIST_97 / CANT_ASIST_97) / 60)
    '            VALOR_NUM_INDICE(8) = FormatNumber((TIEMP_ASIST_97 / CANT_ASIST_97) / 60, 2)

    '            PROCESOS.TextBox38.Text = Int((TIEMP_VIDA_OTROS / (CANT_REC_OTR_RED_MANT + CANT_REC_OTR_RED_CORR + CANT_REC_OTR_MDU_MANT + CANT_REC_OTR_MDU_CORR)) / 60)
    '            'Carga el tiempo de asistencia excluidos los SIN SEÑAL
    '            PROCESOS.TextBox39.Text = Int((TIEMP_ASIST_OTROS / CANT_ASIST_OTROS) / 60)
    '            VALOR_INDICE(9) = Int((TIEMP_ASIST_OTROS / CANT_ASIST_OTROS) / 60)
    '            VALOR_NUM_INDICE(9) = FormatNumber((TIEMP_ASIST_OTROS / CANT_ASIST_OTROS) / 60, 2)

    '            PROCESOS.TextBox41.Text = Int(((TIEMP_VIDA_97 + TIEMP_VIDA_OTROS) / (CANT_REC_97_RED_MANT_OTR + CANT_REC_97_RED_CORR_OTR + CANT_REC_97_MDU_MANT_OTR + CANT_REC_97_MDU_CORR_OTR + CANT_REC_OTR_RED_MANT + CANT_REC_OTR_RED_CORR + CANT_REC_OTR_MDU_MANT + CANT_REC_OTR_MDU_CORR)) / 60)

    '            'Carga el tiempo de asistencia para reclamos de CUALQUIER TIPO
    '            PROCESOS.TextBox40.Text = Int(((TIEMP_ASIST_97 + TIEMP_ASIST_OTROS) / (CANT_ASIST_97 + CANT_ASIST_OTROS)) / 60)
    '            VALOR_INDICE(10) = Int(((TIEMP_ASIST_97 + TIEMP_ASIST_OTROS) / (CANT_ASIST_97 + CANT_ASIST_OTROS)) / 60)
    '            VALOR_NUM_INDICE(10) = FormatNumber(((TIEMP_ASIST_97 + TIEMP_ASIST_OTROS) / (CANT_ASIST_97 + CANT_ASIST_OTROS)) / 60, 2)
    '            'Porcentaje de tiempo de corte x mantenimiento vs corte por otras causas en RED
    '            VALOR_INDICE(25) = FormatPercent((Int(TIEM_REC_97_RED_MANT_CXM / 60) + Int(TIEM_REC_97_RED_CORR_CXM / 60)) / Int(TIEM_REC_97_RED_CORR_OTR / 60))
    '            VALOR_NUM_INDICE(25) = FormatNumber(((Int(TIEM_REC_97_RED_MANT_CXM / 60) + Int(TIEM_REC_97_RED_CORR_CXM / 60)) / Int(TIEM_REC_97_RED_CORR_OTR / 60)) * 100, 2)
    '            'Porcentaje de tiempo de corte x mantenimiento vs corte por otras causas en MDU
    '            VALOR_INDICE(31) = FormatPercent((Int(Int(TIEM_REC_97_MDU_MANT_CXM / 60)) + Int(TIEM_REC_97_MDU_CORR_CXM / 60)) / Int(TIEM_REC_97_MDU_CORR_OTR / 60))
    '            VALOR_NUM_INDICE(31) = FormatNumber(((Int(Int(TIEM_REC_97_MDU_MANT_CXM / 60)) + Int(TIEM_REC_97_MDU_CORR_CXM / 60)) / Int(TIEM_REC_97_MDU_CORR_OTR / 60)) * 100, 2)
    '            'Porcentaje de tiempo de corte x mantenimiento vs corte por otras causas en MDU
    '            VALOR_INDICE(34) = FormatPercent((Int(TIEM_REC_97_RED_MANT_CXM / 60) + Int(TIEM_REC_97_RED_CORR_CXM / 60) + Int(TIEM_REC_97_MDU_MANT_CXM / 60) + Int(TIEM_REC_97_MDU_CORR_CXM / 60)) / (Int(TIEM_REC_97_RED_CORR_OTR / 60) + Int(TIEM_REC_97_MDU_CORR_OTR / 60)))
    '            VALOR_NUM_INDICE(34) = FormatNumber(((Int(TIEM_REC_97_RED_MANT_CXM / 60) + Int(TIEM_REC_97_RED_CORR_CXM / 60) + Int(TIEM_REC_97_MDU_MANT_CXM / 60) + Int(TIEM_REC_97_MDU_CORR_CXM / 60)) / (Int(TIEM_REC_97_RED_CORR_OTR / 60) + Int(TIEM_REC_97_MDU_CORR_OTR / 60))) * 100, 2)

    '            CARGA_TABLA_ORDINALES()

    '            CARGA_REPO_INDICES()

    '            CALCULO_ORDINALES()

    '            PROCESOS.PROGRESS_BAR("PROCESO TERMINADO", 0, 0)
    '            PROCESOS.GB_INFORME1.Visible = True
    '            PROCESOS.BTN_CREAR.Enabled = True
    '            Close()
    '        Else
    '            MsgBox("No hay registros en BASECALCULO")
    '        End If
    '    End Sub
    '    Private Sub CARGA_TABLA_ORDINALES()
    '        'INFORME DE ORDINALES
    '        'Carga tabla de ordinales con todos sus valores porque se inicia filtrando el informe correspondiente
    '        OrdinalesTableAdapter.Fill(INFORME_INDICEDataSet.Ordinales)
    '        For CONTADOR = 0 To INFORME_INDICEDataSet.TablaWEB.Rows.Count - 1

    '            nroOrdinal = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ORDINAL")
    '            OrdinalRow = INFORME_INDICEDataSet.Ordinales.FindByOrdinal(nroOrdinal)

    '            If IsNothing(OrdinalRow) Then 'Agrega un registro completo a la Tabla de Ordinales con todos los datos

    '                'CANT_REC_FALL_97 = 0
    '                'CANT_REC_FALL_ORD = 0

    '                newOrdinalRow = INFORME_INDICEDataSet.Ordinales.NewOrdinalesRow

    '                newOrdinalRow.Ordinal = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ORDINAL")                  'Carga el nro de Ordinal
    '                newOrdinalRow.TipoOrdinal = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("TIPO_ORDINAL")         'Carga el tipo de Ordinal
    '                newOrdinalRow.SectorOrdinal = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("SECTOR_ORDINAL")     'Carga el sector del Ordinal
    '                newOrdinalRow.Permisor = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("PERMISOR")

    '                'Busca el reclamo en la BasedeCalculo para saber donde suma el reclamo
    '                nroreclamo = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ID_RECLAMO")
    '                RECLAMORow = INFORME_INDICEDataSet.BaseCalculo.FindByidReclamo(nroreclamo)
    '                If IsNothing(RECLAMORow) = False Then
    '                    If Trim(RECLAMORow("FallaCierre")) = 819 Then ' El reclamo se cerró por un corte de mantenimiento
    '                        'CANT_REC_FALL_97 = CANT_REC_FALL_97 + 1
    '                        newOrdinalRow("CantRecFall97") = 1
    '                        newOrdinalRow("CantRecFallOrd") = 0
    '                    Else 'El reclamo se cerró con el cierre del Ordinal
    '                        'CANT_REC_FALL_ORD = CANT_REC_FALL_ORD + 1
    '                        newOrdinalRow("CantRecFallOrd") = 1
    '                        newOrdinalRow("CantRecFall97") = 0
    '                    End If
    '                    newOrdinalRow.Informe = RECLAMORow("Informe")



    '                End If

    '                newOrdinalRow.FallaOrigOrd = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FALLA_ORI_ORDINAL")
    '                newOrdinalRow.FallaCierreOrd = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FALLA_CIERRE_ORDINAL")
    '                newOrdinalRow.FechaOrigOrd = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("HORA_ING_ORDINAL")
    '                newOrdinalRow.FechaCierreOrd = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FECHA_CIERRE_ORDINAL")

    '                If IsDBNull(INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FECHA_CIERRE_ORDINAL")) = False Then
    '                    newOrdinalRow.TiempoVida = DateDiff(DateInterval.Minute, INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("HORA_ING_ORDINAL"), INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FECHA_CIERRE_ORDINAL"))
    '                End If

    '                newOrdinalRow.FechaInicTrab = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FCH_INICIO_TRAB_ORDINAL")
    '                newOrdinalRow.FechaCierrTrab = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("FCH_CIERRE_TRAB_ORDINAL")
    '                newOrdinalRow.CODZona = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA")

    '                'Rutina para cargar nodo y zona a la tabla de ordinales (Agregar ZONARED)__________________________________________________________
    '                If IsDBNull(INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA")) = False Then
    '                    Select Case INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA").ToString.Length
    '                        Case 3
    '                            COD_ZONE = "  " & INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA")
    '                        Case 4
    '                            COD_ZONE = " " & INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA")
    '                        Case 5
    '                            COD_ZONE = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ZONA")
    '                    End Select

    '                    newOrdinalRow.Nodo = LTrim(COD_ZONE.Remove(3))
    '                    newOrdinalRow.Zona = COD_ZONE.Substring(3)


    '                    ZonaRedRow = INFORME_INDICEDataSet.ZonasRED.FindByNodo(LTrim(COD_ZONE.Remove(3)))
    '                    If IsNothing(ZonaRedRow) = False Then
    '                        newOrdinalRow.ZonaRED = ZonaRedRow("Sector")
    '                    End If
    '                End If

    '                newOrdinalRow("StatusOrd") = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("STS_ORDINAL")


    '                'Agrega a la tabla los valores cargados
    '                INFORME_INDICEDataSet.Ordinales.Rows.Add(newOrdinalRow)

    '            Else 'Significa que el Ordinal ya esta cargado entonces solo suma los reclamos segun sus características

    '                'Busca el reclamo en la BasedeCalculo para saber donde suma el reclamo
    '                nroreclamo = INFORME_INDICEDataSet.TablaWEB.Rows(CONTADOR).Item("ID_RECLAMO")
    '                RECLAMORow = INFORME_INDICEDataSet.BaseCalculo.FindByidReclamo(nroreclamo)

    '                CANT_REC_FALL_97 = OrdinalRow("CantRecFall97")
    '                    CANT_REC_FALL_ORD = OrdinalRow("CantRecFallOrd")

    '                    If RECLAMORow("FallaCierre") = "819" Then ' El reclamo se cerró por un corte de mantenimiento
    '                        OrdinalRow("CantRecFall97") = CANT_REC_FALL_97 + 1

    '                    Else 'El reclamo se cerró con el cierre del Ordinal
    '                        OrdinalRow("CantRecFallOrd") = CANT_REC_FALL_ORD + 1

    '                    End If


    '            End If
    '            PROCESOS.PROGRESS_BAR("CREANDO INFORME ORDINALES", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR + 1)
    '        Next
    '        PROCESOS.PROGRESS_BAR("GRABANDO INFORME ORDINALES", INFORME_INDICEDataSet.TablaWEB.Rows.Count, CONTADOR)
    '        OrdinalesTableAdapter.Update(INFORME_INDICEDataSet.Ordinales)
    '        OrdinalesTableAdapter.FillByInforme(INFORME_INDICEDataSet.Ordinales, TXT_ID_INFORME.Text)
    '        PROCESOS.PROGRESS_BAR("PROCESO TERMINADO", 0, 0)
    '    End Sub
    '    Private Sub CARGA_REPO_INDICES()
    '        'GRABA EN BASE REPORTES
    '        'Pregunta si existen grabacion de indices en el informe analizado
    '        RepoIndicesTableAdapter.FillByInformeID(INFORME_INDICEDataSet.RepoIndices, Trim(TXT_ID_INFORME.Text))
    '        If INFORME_INDICEDataSet.RepoIndices.Rows.Count = 0 Then
    '            'Si no hay ningun registro con ese numero de informe agrega una fila vacia
    '            For CONTADOR = 1 To 49
    '                IndiceRow = INFORME_INDICEDataSet.InfoIndices.FindByIndiceNro(CONTADOR)
    '                NewRepIndrow = INFORME_INDICEDataSet.RepoIndices.NewRepoIndicesRow
    '                NewRepIndrow("InformeNro") = Trim(TXT_ID_INFORME.Text)
    '                NewRepIndrow("InformeNombre") = Trim(TXT_INFORME.Text)
    '                NewRepIndrow("Indice") = CONTADOR
    '                NewRepIndrow("DescripcionInd") = IndiceRow("Descripción")
    '                NewRepIndrow("Unidad") = IndiceRow("Unidad")
    '                NewRepIndrow("ValorIndice") = VALOR_INDICE(CONTADOR)
    '                NewRepIndrow("CumpleOpt") = CUMPLE_IND_OPT(CONTADOR)
    '                NewRepIndrow("CumpleAcep") = CUMPLE_IND_ACEP(CONTADOR)
    '                NewRepIndrow("DesviacionOpt") = 0
    '                NewRepIndrow("DesviacionAcep") = 0
    '                NewRepIndrow("TipoInforme") = IndiceRow("Tipo")
    '                NewRepIndrow("TipoOrdinal") = IndiceRow("TipoOrdinal")
    '                NewRepIndrow("SectorOrdinal") = IndiceRow("SectorOedinal")
    '                NewRepIndrow("Falla") = IndiceRow("Falla")
    '                'Agrega a la tabla los valores cargados
    '                INFORME_INDICEDataSet.RepoIndices.AddRepoIndicesRow(NewRepIndrow)
    '                PROCESOS.PROGRESS_BAR("CREANDO VALORES PARA INFORME", 50, CONTADOR)
    '            Next
    '            'Graba la Base de datos de indices
    '            PROCESOS.PROGRESS_BAR("GRABANDO", 50, 50)
    '            RepoIndicesTableAdapter.Update(INFORME_INDICEDataSet.RepoIndices)

    '            RepoIndicesTableAdapter.FillByInformeID(INFORME_INDICEDataSet.RepoIndices, TXT_ID_INFORME.Text)
    '            PROCESOS.PROGRESS_BAR("PROCESO FINALIZADO", 0, 0)
    '        Else
    '            Dim REPO_INIDCE As DataRow
    '            For CONTADOR = 1 To 49
    '                IndiceRow = INFORME_INDICEDataSet.InfoIndices.FindByIndiceNro(CONTADOR)
    '                REPO_INIDCE = INFORME_INDICEDataSet.RepoIndices.Rows(CONTADOR - 1)
    '                'NewRepIndrow = INFORME_INDICEDataSet.RepoIndices.NewRepoIndicesRow
    '                REPO_INIDCE("InformeNro") = Trim(TXT_ID_INFORME.Text)
    '                REPO_INIDCE("InformeNombre") = Trim(TXT_INFORME.Text)
    '                REPO_INIDCE("Indice") = CONTADOR
    '                REPO_INIDCE("DescripcionInd") = IndiceRow("Descripción")
    '                REPO_INIDCE("Unidad") = IndiceRow("Unidad")
    '                REPO_INIDCE("ValorIndice") = VALOR_INDICE(CONTADOR)
    '                REPO_INIDCE("CumpleOpt") = CUMPLE_IND_OPT(CONTADOR)
    '                REPO_INIDCE("CumpleAcep") = CUMPLE_IND_ACEP(CONTADOR)
    '                REPO_INIDCE("DesviacionOpt") = 0
    '                REPO_INIDCE("DesviacionAcep") = 0
    '                REPO_INIDCE("TipoInforme") = IndiceRow("Tipo")
    '                REPO_INIDCE("TipoOrdinal") = IndiceRow("TipoOrdinal")
    '                REPO_INIDCE("SectorOrdinal") = IndiceRow("SectorOedinal")
    '                REPO_INIDCE("Falla") = IndiceRow("Falla")
    '                'Agrega a la tabla los valores cargados
    '                RepoIndicesTableAdapter.Update(REPO_INIDCE)
    '                PROCESOS.PROGRESS_BAR("CREANDO VALORES PARA INFORME", 50, CONTADOR)
    '            Next
    '        End If
    '        'FIN GRABACION TABLA REPORTES INDICES____________________________________________________________________________________________


    '        'SEGUNDO PASO  PASO GRABA LOS DATOS DE TABLA DE REPORTES DE INDICES EN HISTOINDICES
    '        'Carga los datos de la TABLA DE HISTORICOS filtrado por el informe que se esta procesando
    '        HistoIndicesTableAdapter.FillByInformeNRO(INFORME_INDICEDataSet.HistoIndices, TXT_ID_INFORME.Text)
    '        If INFORME_INDICEDataSet.HistoIndices.Rows.Count = 0 Then
    '            For CONTADOR = 0 To INFORME_INDICEDataSet.RepoIndices.Rows.Count - 1
    '                RepoINDRow = INFORME_INDICEDataSet.RepoIndices.Rows(CONTADOR)
    '                NewHistoIndrow = INFORME_INDICEDataSet.HistoIndices.NewHistoIndicesRow
    '                NRO_INDICE = RepoINDRow("Indice")
    '                NewHistoIndrow("InformeNro") = RepoINDRow("InformeNro")
    '                NewHistoIndrow("Indice") = NRO_INDICE
    '                NewHistoIndrow("DescripcionInd") = RepoINDRow("DescripcionInd")
    '                NewHistoIndrow("ValorIndice") = VALOR_NUM_INDICE(NRO_INDICE)
    '                NewHistoIndrow("Unidad") = RepoINDRow("Unidad")
    '                NewHistoIndrow("Año") = AÑO
    '                NewHistoIndrow("Mes") = MES
    '                NewHistoIndrow("MesNombre") = CB_FECHA.Text
    '                NewHistoIndrow("DesviacionOpt") = RepoINDRow("DesviacionOpt")
    '                NewHistoIndrow("DesviacionAcep") = RepoINDRow("DesviacionAcep")
    '                NewHistoIndrow("TipoOrdinal") = RepoINDRow("TipoOrdinal")
    '                NewHistoIndrow("SectorOrdinal") = RepoINDRow("SectorOrdinal")
    '                NewHistoIndrow("Falla") = RepoINDRow("Falla")

    '                'Agrega a la tabla los valores cargados
    '                INFORME_INDICEDataSet.HistoIndices.Rows.Add(NewHistoIndrow)
    '                PROCESOS.PROGRESS_BAR("PROCESANDO HISTORIO", INFORME_INDICEDataSet.RepoIndices.Rows.Count, CONTADOR + 1)
    '            Next
    '            'Graba la Base de datos EN LA TABLA REPORTES DE INDICES
    '            PROCESOS.PROGRESS_BAR("GRABANDO DATOS DE HISTORIO", INFORME_INDICEDataSet.RepoIndices.Rows.Count, CONTADOR)
    '            HistoIndicesTableAdapter.Update(INFORME_INDICEDataSet.HistoIndices)
    '            PROCESOS.PROGRESS_BAR("PROCESO TERMINADO", 0, 0)
    '        Else
    '            MsgBox(" Ya existen datos en la tabla Historicos para el período " & CB_FECHA.Text & " de " & AÑO)
    '        End If
    '    End Sub
    '    Private Sub CALCULO_ORDINALES()
    '        CANT_REC_RED_MAN_CXM = 0
    '        CANT_REC_RED_MAN_ORD = 0
    '        CANT_REC_RED_COR_CXM = 0
    '        CANT_REC_RED_COR_ORD = 0
    '        CANT_REC_MDU_MAN_CXM = 0
    '        CANT_REC_MDU_MAN_ORD = 0
    '        CANT_REC_MDU_COR_CXM = 0
    '        CANT_REC_MDU_COR_ORD = 0
    '        CANT_ORD_RED_CORR = 0
    '        CANT_ORD_RED_MANT = 0
    '        CANT_ORD_MDU_CORR = 0
    '        CANT_ORD_MDU_MANT = 0

    '        For CONTADOR = 0 To INFORME_INDICEDataSet.Ordinales.Rows.Count - 1
    '            OrdinalRow = INFORME_INDICEDataSet.Ordinales.Rows(CONTADOR)
    '            If Trim(OrdinalRow("TipoOrdinal")) = "CORRECTIVO" Then
    '                If Trim(OrdinalRow("SectorOrdinal")) = "RED" Or Trim(OrdinalRow("SectorOrdinal")) = "CABLEADO" Then
    '                    CANT_ORD_RED_CORR = CANT_ORD_RED_CORR + 1
    '                    'Suma uno al tipo de ordinales
    '                    CANT_REC_RED_COR_CXM = OrdinalRow("CantRecFall97") + CANT_REC_RED_COR_CXM
    '                    CANT_REC_RED_COR_ORD = OrdinalRow("CantRecFallOrd") + CANT_REC_RED_COR_ORD
    '                ElseIf Trim(OrdinalRow("SectorOrdinal")) = "MDU" Then
    '                    CANT_ORD_MDU_CORR = CANT_ORD_MDU_CORR + 1                                       'Suma uno al tipo de ordinales
    '                    CANT_REC_MDU_COR_CXM = OrdinalRow("CantRecFall97") + CANT_REC_MDU_COR_CXM
    '                    CANT_REC_MDU_COR_ORD = OrdinalRow("CantRecFallOrd") + CANT_REC_MDU_COR_ORD
    '                End If

    '            ElseIf Trim(OrdinalRow("TipoOrdinal")) = "TAREA" Then
    '                If Trim(OrdinalRow("SectorOrdinal")) = "RED" Or Trim(OrdinalRow("SectorOrdinal")) = "CABLEADO" Then
    '                    CANT_ORD_RED_MANT = CANT_ORD_RED_MANT + 1                                       'Suma uno al tipo de ordinales
    '                    CANT_REC_RED_MAN_CXM = OrdinalRow("CantRecFall97") + CANT_REC_RED_MAN_CXM
    '                    CANT_REC_RED_MAN_ORD = OrdinalRow("CantRecFallOrd") + CANT_REC_RED_MAN_ORD
    '                ElseIf Trim(OrdinalRow("SectorOrdinal")) = "MDU" Then
    '                    CANT_ORD_MDU_MANT = CANT_ORD_MDU_MANT + 1                                       'Suma uno al tipo de ordinales
    '                    CANT_REC_RED_MAN_CXM = OrdinalRow("CantRecFall97") + CANT_REC_RED_MAN_CXM
    '                    CANT_REC_MDU_MAN_CXM = OrdinalRow("CantRecFall97") + CANT_REC_MDU_MAN_CXM
    '                    CANT_REC_MDU_MAN_ORD = OrdinalRow("CantRecFallOrd") + CANT_REC_MDU_MAN_ORD
    '                End If
    '            End If
    '            PROCESOS.PROGRESS_BAR("PROCESANDO ORDINALES", INFORME_INDICEDataSet.Ordinales.Rows.Count, CONTADOR + 1)
    '        Next

    '        'TextBox8.Text = CANT_REC_RED_MAN_ORD
    '        PROCESOS.TextBox9.Text = CANT_REC_RED_MAN_CXM
    '        'TextBox10.Text = CANT_REC_RED_COR_ORD
    '        PROCESOS.TextBox11.Text = CANT_REC_RED_COR_CXM
    '        'TextBox12.Text = CANT_REC_MDU_MAN_ORD
    '        PROCESOS.TextBox13.Text = CANT_REC_MDU_MAN_CXM
    '        'TextBox14.Text = CANT_REC_MDU_COR_ORD
    '        PROCESOS.TextBox15.Text = CANT_REC_MDU_COR_CXM

    '        'Carga la cantidad de ordinales de MANT RED
    '        PROCESOS.TextBox17.Text = CANT_ORD_RED_MANT
    '        VALOR_INDICE(13) = CANT_ORD_RED_MANT
    '        VALOR_NUM_INDICE(13) = CANT_ORD_RED_MANT

    '        'Carga la cantidad de ordinales de CORR RED
    '        PROCESOS.TextBox16.Text = CANT_ORD_RED_CORR
    '        VALOR_INDICE(14) = CANT_ORD_RED_CORR
    '        VALOR_NUM_INDICE(14) = CANT_ORD_RED_CORR

    '        'Carga la cantidad de ordinales de MANT MDU
    '        PROCESOS.TextBox19.Text = CANT_ORD_MDU_MANT
    '        VALOR_INDICE(15) = CANT_ORD_MDU_MANT
    '        VALOR_NUM_INDICE(15) = CANT_ORD_MDU_MANT

    '        'Carga la cantidad de ordinales de CORR MDU
    '        PROCESOS.TextBox18.Text = CANT_ORD_MDU_CORR
    '        VALOR_INDICE(16) = CANT_ORD_MDU_CORR
    '        VALOR_NUM_INDICE(16) = CANT_ORD_MDU_CORR
    '        PROCESOS.PROGRESS_BAR("PROCESO TERMINADO", 0, 0)
    '    End Sub
    '    Private Sub BTN_BORRAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR_EXCEL.Click
    '        If MES IsNot Nothing Then
    '            TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "SI")
    '            If INFORME_INDICEDataSet.TablaWEB.Rows.Count > 0 Then
    '                For X = 0 To INFORME_INDICEDataSet.TablaWEB.Count - 1
    '                    INFORME_INDICEDataSet.TablaWEB.Rows(X).Delete()
    '                    PROCESOS.PROGRESS_BAR("BORRANDO REGISTRO DE TABLAWEB - VALIDOS", INFORME_INDICEDataSet.TablaWEB.Count, X + 1)
    '                Next
    '                TablaWEBTableAdapter.Update(INFORME_INDICEDataSet.TablaWEB)
    '                PROCESOS.PROGRESS_BAR("ACTUALIZANDO TABLAS", INFORME_INDICEDataSet.TablaWEB.Count, 0)
    '            Else
    '                MsgBox("NO HAY REGISTRO A BORRAR")
    '            End If
    '            TablaWEBTableAdapter.FillByMES_AÑO_VALIDO(INFORME_INDICEDataSet.TablaWEB, AÑO, MES, "NO")
    '            If INFORME_INDICEDataSet.TablaWEB.Rows.Count > 0 Then
    '                For X = 0 To INFORME_INDICEDataSet.TablaWEB.Count - 1
    '                    INFORME_INDICEDataSet.TablaWEB.Rows(X).Delete()
    '                    PROCESOS.PROGRESS_BAR("BORRANDO REGISTRO DE TABLAWEB - NO VALIDOS", INFORME_INDICEDataSet.TablaWEB.Count, X + 1)
    '                Next
    '                PROCESOS.PROGRESS_BAR("ACTUALIZANDO TABLAS", INFORME_INDICEDataSet.TablaWEB.Count, 0)
    '                TablaWEBTableAdapter.Update(INFORME_INDICEDataSet.TablaWEB)
    '            Else
    '                MsgBox("NO HAY REGISTRO A BORRAR")
    '            End If
    '        Else
    '            MsgBox("SELECCIONE MES A BORRAR")
    '        End If
    '    End Sub
    '    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
    '        Close()
    '    End Sub
    '    Private Sub CB_ANIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ANIO.SelectedIndexChanged
    '        AÑO = CB_ANIO.Text
    '    End Sub


End Class