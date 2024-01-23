Imports System.IO
Public Class INFORME_MDU_GESTIONESPROGRAMADAS

    Dim GESTIONRow As ORDENESDataSet.GESTIONRow
    Dim TRABAJOSRow As ORDENESDataSet.TRABAJOSRow
    Dim ORDENESRow As ORDENESDataSet.ORDENESRow
    Dim NewINFORMERow As ORDENESDataSet.INFORMMEMDU_PERMISORRow
    Dim NewAVANCE_OBRASRow As ORDENESDataSet.INFORME_AVANCE_OBRASRow
    Dim FECHA_PREVISTA As Date
    Dim TIPO_REPORTE As String
    'PAINT
    Dim BORRAR As New SolidBrush(Color.White)
    Dim POS_X As Integer
    Dim POS_Y As Integer
    Dim FUENTE As New System.Drawing.Font("ARIAL", 10, FontStyle.Bold)
    Dim FUENTE_CHICA As New System.Drawing.Font("ARIAL", 7)
    Dim Relleno_GREEN As New SolidBrush(Color.Green)
    Dim Relleno_YELLOW As New SolidBrush(Color.Yellow)
    Dim Relleno_ORANGE As New SolidBrush(Color.OrangeRed)
    Dim Relleno_RED As New SolidBrush(Color.Red)
    Dim Relleno_DARKBLUE As New SolidBrush(Color.DarkBlue)
    Dim Relleno_NEGRO As New SolidBrush(Color.Black)
    Dim Relleno_GRAY As New SolidBrush(Color.Gainsboro)
    Dim Relleno_VIOLETA As New SolidBrush(Color.DarkViolet)
    Dim LAPIZ_GRAY As New Pen(Color.DarkGray, 2)
    Dim Lapiz_ROJO As New Pen(Color.Red, 2)
    Dim Lapiz_BLANCO As New Pen(Color.White, 2)
    Dim Lapiz_VERDE As New Pen(Color.Green, 2)
    Dim Lapiz_Negro As New Pen(Color.Black, 2)
    Dim Lapiz_Violeta As New Pen(Color.DarkViolet, 2)
    Dim Lapiz_Naranja As New Pen(Color.Orange, 2)
    Dim ORDEN_FINALIZADA As Integer
    Dim LIENZO As Graphics
    Private Sub INFORME_MDU_GESTIONESPROGRAMADAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        'BUSCA GESTIONES PENDIENTES
        Me.GESTIONTableAdapter.FillByNOSTATUS(ORDENESDataSet.GESTION, "FINALIZADO", "OBRA NUEVA")
        CANT_GESTIONES.Text = ORDENESDataSet.GESTION.Rows.Count
        Me.Cursor = DefaultCursor
        AVANCEGEST.Maximum = ORDENESDataSet.GESTION.Rows.Count
    End Sub
    Private Sub CARGA_SOLOTRABAJO()
        'GENERA UNA LINEA DE INFORME CON INFORMACION SOLO DE TRABAJO
        NewINFORMERow = ORDENESDataSet.INFORMMEMDU_PERMISOR.NewINFORMMEMDU_PERMISORRow
        'DATOS DE GESTION
        NewINFORMERow("CALLE") = Trim(GESTIONRow("CALLE")) & " " & GESTIONRow("NUMERO")
        NewINFORMERow("SOLICITANTE") = GESTIONRow("SOLICITANTE")
        NewINFORMERow("OBS_GESTION") = Trim(GESTIONRow("DESCRIPCION"))
        'DATOS DE TRABAJO
        NewINFORMERow.ITEMS = TRABAJOSRow("TIPOTRABAJO")
        NewINFORMERow("STATUS") = TRABAJOSRow("STATUS")
        NewINFORMERow("FECHAINIESTIMADO") = TRABAJOSRow("FECHAINICESTIMADO")
        NewINFORMERow("TESTIMADO") = TRABAJOSRow("TIEMPOESTIMADO")
        NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
        NewINFORMERow("FECHAFINREAL") = TRABAJOSRow("FECHAFINALIZADO")
        NewINFORMERow("FECHAINICIOREAL") = TRABAJOSRow("FECHAINICIADO")
        If FECHA_PREVISTA <> Nothing Then
            NewINFORMERow("FECHA_FINGESTION") = FECHA_PREVISTA
        Else
            NewINFORMERow("FECHA_FINGESTION") = DBNull.Value
        End If
        'AGREGA UNA FILA A LA TABLA
        ORDENESDataSet.INFORMMEMDU_PERMISOR.AddINFORMMEMDU_PERMISORRow(NewINFORMERow)
        FECHA_PREVISTA = Nothing
    End Sub
    Private Sub CARGA_ORDENyTRABAJO()

        'GENERA UNA LINEA DE INFORME CON INFORMACION DE ORDEN
        NewINFORMERow = ORDENESDataSet.INFORMMEMDU_PERMISOR.NewINFORMMEMDU_PERMISORRow
        'DATOS DE GESTION
        NewINFORMERow("CALLE") = Trim(GESTIONRow("CALLE")) & " " & GESTIONRow("NUMERO")
        NewINFORMERow("OBS_GESTION") = GESTIONRow("DESCRIPCION")
        'DATOS DE TRABAJO
        NewINFORMERow("ITEMS") = TRABAJOSRow("TIPOTRABAJO")

        NewINFORMERow("STATUS") = TRABAJOSRow("STATUS")

        NewINFORMERow("FECHAINIESTIMADO") = TRABAJOSRow("FECHAINICESTIMADO")
        NewINFORMERow("TESTIMADO") = TRABAJOSRow("TIEMPOESTIMADO")
        NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
        NewINFORMERow("FECHAFINREAL") = TRABAJOSRow("FECHAFINALIZADO")

        If FECHA_PREVISTA <> Nothing Then
            NewINFORMERow("FECHA_FINGESTION") = FECHA_PREVISTA
        Else
            NewINFORMERow("FECHA_FINGESTION") = DBNull.Value
        End If

        'DATOS DE LA ORDEN
        NewINFORMERow("ORDENNRO") = ORDENESRow("NRO_ORDENINT")
        NewINFORMERow("ORDINALNRO") = ORDENESRow("NRO_ORDINAL")
        NewINFORMERow("FALLAORIG") = ORDENESRow("MOTIVOORIGEN")
        NewINFORMERow("ORDEN_STATUS") = ORDENESRow("STATUS")
        NewINFORMERow("ORDEN_FECHACOOR") = ORDENESRow("FECHAAGEND")
        NewINFORMERow("ORDEN_FECHAFIN") = ORDENESRow("FECHAFIN")

        'MARCA_TRABAJOSPROCESADOS()
        'AGREGA UNA FILA A LA TABLA
        ORDENESDataSet.INFORMMEMDU_PERMISOR.AddINFORMMEMDU_PERMISORRow(NewINFORMERow)
        FECHA_PREVISTA = Nothing

    End Sub
    Private Sub MARCA_TRABAJOSPROCESADOS()

        'MARCA SI LOS TRABAJOS FUERON PROCESADOS ENTRE FECHAS
        Select Case TRABAJOSRow("STATUS")
            Case "FINALIZADO", "Finalizado"
                NewINFORMERow("FECHAFINREAL") = TRABAJOSRow("FECHAFINALIZADO")
                NewINFORMERow("DEMORA") = DateDiff(DateInterval.Day, DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO")), TRABAJOSRow("FECHAFINALIZADO"))
                If TRABAJOSRow("FECHAFINALIZADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAFINALIZADO") < FECHA_HASTA.Value.ToShortDateString Then
                    NewINFORMERow("REALIZADAACTUAL") = "PROC"
                End If
            Case "INICIADO", "Iniciado"
                NewINFORMERow("FECHAINICIOREAL") = TRABAJOSRow("FECHAINICIADO")
                NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICIADO"))
                If TRABAJOSRow("FECHAINICIADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAINICIADO") < FECHA_HASTA.Value.ToShortDateString Then
                    NewINFORMERow("REALIZADAACTUAL") = "PROC"
                End If
            Case "INGRESADO", "Ingresado"
                NewINFORMERow("FECHAINIESTIMADO") = TRABAJOSRow("FECHAINICESTIMADO")
                NewINFORMERow("TESTIMADO") = TRABAJOSRow("TIEMPOESTIMADO")
                NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
                If TRABAJOSRow("FECHAINGRESADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAINGRESADO") < FECHA_HASTA.Value.ToShortDateString Then
                    NewINFORMERow("REALIZADAACTUAL") = "PROC"
                End If
            Case Else
        End Select

    End Sub
    Private Sub CARGA_DATOSREPORTE()
        ORDENESDataSet.INFORMMEMDU_PERMISOR.Clear()
        Me.Cursor = Cursors.WaitCursor
        For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
            AVANCEGEST.Value = I + 1
            GESTIONRow = ORDENESDataSet.GESTION.Rows(I)
            'BUSCA LOS TRABAJOS DENTRO DE LA GESTION
            TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, GESTIONRow("ID_GESTION"))
            CANT_TRABAJOS.Text = ORDENESDataSet.TRABAJOS.Rows.Count
            AVANCETRAB.Maximum = ORDENESDataSet.TRABAJOS.Rows.Count

            If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then
                'RECORRE LOS TRABAJOS DENTRO DE LA GESTION
                For X = 0 To ORDENESDataSet.TRABAJOS.Count - 1

                    'BUSCA LA FECHA ESTIMADA DE FINALIZACION
                    For M = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                        TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(M)
                        Select Case TRABAJOSRow("TIPOTRABAJO")
                            Case "EJECUCION"
                                Select Case TRABAJOSRow("STATUS")
                                    Case "INGRESADO", "COORDINADO", "Ingresado", "Coordinado"
                                        FECHA_PREVISTA = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
                                    Case "INICIADO", "FINALIZADO", "Iniciado", "Finalizado"
                                        FECHA_PREVISTA = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICIADO"))
                                    Case Else
                                        FECHA_PREVISTA = Nothing
                                End Select
                        End Select
                    Next M

                    AVANCETRAB.Value = X + 1
                    TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)
                    Select Case TIPO_REPORTE
                        Case "COMPLETO"
                            'BUSCA LAS ORDENES QUE ESTAN DEFINIDAS DENTRO DEL TRABAJO
                            ORDENESTableAdapter.FillByIDTRABAJO(ORDENESDataSet.ORDENES, TRABAJOSRow("Id_TRABAJO"))
                            CANT_ORDENES.Text = ORDENESDataSet.ORDENES.Rows.Count
                            AVANCEORD.Maximum = ORDENESDataSet.ORDENES.Rows.Count
                            If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                                For J = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                                    ORDENESRow = ORDENESDataSet.ORDENES.Rows(J)
                                    AVANCEORD.Value = J + 1
                                    CARGA_ORDENyTRABAJO()
                                Next J
                                AVANCEORD.Value = 0
                            Else
                                CARGA_SOLOTRABAJO()
                            End If
                        Case Else
                            CARGA_SOLOTRABAJO()
                    End Select
                Next X
                AVANCETRAB.Value = 0
            End If
        Next I
        AVANCEGEST.Value = 0
        Me.Cursor = DefaultCursor
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  Me.ReportViewer1.Visible = True
        Me.ReportViewer2.Visible = False
        Me.ReportViewer3.Visible = False
        ReportViewer4.Visible = False
        TIPO_REPORTE = "COMPLETO"
        CARGA_DATOSREPORTE()
        '  Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Me.ReportViewer3.Visible = False
        ReportViewer4.Visible = False
        TIPO_REPORTE = "COMPLETO"
        CARGA_DATOSREPORTE()
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'INFORME PERMISOR
        '   Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
        Me.ReportViewer3.Visible = True
        ReportViewer4.Visible = False
        TIPO_REPORTE = "PERMISOR"
        CARGA_DATOSREPORTE()
        ReportViewer3.RefreshReport()
    End Sub
    Private Sub BTN_REPORT_AVANCE_Click(sender As Object, e As EventArgs) Handles BTN_REPORT_AVANCE.Click
        '  Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
        Me.ReportViewer3.Visible = False
        'ReportViewer4.Visible = True

        REPORTE_AVANCE()
    End Sub
    Private Sub CELDA(ByVal XU As Single)
        LIENZO.FillRectangle(BORRAR, POS_X + 420 - 50 * XU, POS_Y, 46, 12)
        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            If ORDEN_FINALIZADA = ORDENESDataSet.ORDENES.Rows.Count Then
                LIENZO.FillRectangle(Relleno_VIOLETA, POS_X + 418 - 50 * XU, POS_Y - 1, 50, 14)
            Else
                LIENZO.FillRectangle(Relleno_VIOLETA, POS_X + 419 - 50 * XU, POS_Y - 1, CInt(50 * ORDEN_FINALIZADA / ORDENESDataSet.ORDENES.Rows.Count), 14)
            End If
        End If
        Select Case TRABAJOSRow.STATUS
            Case "INGRESADO", "SOLICITUD"
                LIENZO.DrawRectangle(Lapiz_VERDE, POS_X + 420 - 50 * XU, POS_Y, 46, 12)
            Case "INICIADO", "COORDINADO"
                LIENZO.DrawRectangle(Lapiz_Naranja, POS_X + 420 - 50 * XU, POS_Y, 46, 12)
            Case "DEMORADO"
                LIENZO.DrawRectangle(Lapiz_ROJO, POS_X + 420 - 50 * XU, POS_Y, 46, 12)
            Case "FINALIZADO"
                LIENZO.DrawRectangle(Lapiz_Violeta, POS_X + 420 - 50 * XU, POS_Y, 46, 12)
                Select Case TRABAJOSRow.TIPOTRABAJO
                    Case "OBRA CIVIL"
                        LIENZO.FillRectangle(Relleno_VIOLETA, POS_X + 418 - 50 * XU, POS_Y - 1, 50, 14)
                End Select
        End Select
    End Sub
    Private Sub REPORTE_AVANCE()
        LIENZO = PAINT_PANEL.CreateGraphics
        LIENZO.FillRectangle(BORRAR, 0, 0, PAINT_PANEL.Width, PAINT_PANEL.Height)
        POS_X = 70
        POS_Y = 0
        ORDENESDataSet.INFORME_AVANCE_OBRAS.Clear()
        GESTIONTableAdapter.FillByAVANCE_PERMISORES(ORDENESDataSet.GESTION)
        LIENZO.DrawString("SOLICITADOS POR TODOS", FUENTE, Relleno_DARKBLUE, POS_X, POS_Y)
        POS_Y += 30
        LIENZO.DrawString("ACT.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 1, POS_Y - 12)
        LIENZO.DrawString("PLANO", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 1, POS_Y)
        LIENZO.DrawString("EJEC.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 2, POS_Y)
        LIENZO.DrawString("ASOC.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 3, POS_Y - 12)
        LIENZO.DrawString("RED", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 3, POS_Y)
        LIENZO.DrawString("OBRA", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 4, POS_Y - 12)
        LIENZO.DrawString("CIVIL", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 4, POS_Y)
        LIENZO.DrawString("GEST", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 5, POS_Y - 12)
        LIENZO.DrawString("C/IMM", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 5, POS_Y)
        LIENZO.DrawString("AUT.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 6, POS_Y - 12)
        LIENZO.DrawString("CABLE", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 6, POS_Y)
        LIENZO.DrawString("PRESUP.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 7, POS_Y)
        LIENZO.DrawString("DISEÑO", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 8, POS_Y)
        LIENZO.DrawString("RELEVA.", FUENTE_CHICA, Relleno_NEGRO, POS_X + 420 - 50 * 9, POS_Y)
        POS_Y += 15

        For X = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
            GESTIONRow = ORDENESDataSet.GESTION.Rows(X)
            LIENZO.FillRectangle(Relleno_GRAY, POS_X + 20, POS_Y - 1, 620, 14)
            TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, GESTIONRow.Id_GESTION)
            If GESTIONRow.SOLICITANTE = "TERCEROS" Then
                LIENZO.DrawString(Trim(GESTIONRow.CALLE) & " " & GESTIONRow.NUMERO, FUENTE_CHICA, Relleno_DARKBLUE, POS_X + 425, POS_Y + 1)
            Else
                LIENZO.DrawString(Trim(GESTIONRow.CALLE) & " " & GESTIONRow.NUMERO, FUENTE_CHICA, Relleno_ORANGE, POS_X + 425, POS_Y + 1)
            End If
            For Y = 0 To ORDENESDataSet.TRABAJOS.Rows.Count - 1
                ORDEN_FINALIZADA = 0
                TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(Y)
                ORDENESTableAdapter.FillByIDTRABAJO_FINTRA(ORDENESDataSet.ORDENES, TRABAJOSRow.Id_TRABAJO)
                CANT_ORDENES.Text = ORDENESDataSet.ORDENES.Rows.Count
                AVANCEORD.Maximum = ORDENESDataSet.ORDENES.Rows.Count
                If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
                    For J = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                        ORDENESRow = ORDENESDataSet.ORDENES.Rows(J)
                        If ORDENESRow.STATUS = "FINALIZADO" Then
                            ORDEN_FINALIZADA += 1
                        End If
                    Next J
                End If
                If TRABAJOSRow.TIPOTRABAJO = "RELEVAMIENTO" Then 'PARA RELEVAMIENTO
                    CELDA(9)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "DISEÑO" Then 'PARA DISEÑO
                    CELDA(8)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "PRESUPUESTO" Then 'PARA PRESUPUESTO
                    CELDA(7)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "AUTORIZACION CABLEADO" Then 'PARA AUTORIZACION CABLEADO
                    CELDA(6)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "APROBACION IMM" Then 'PARA APROBACION IMM
                    CELDA(5)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "OBRA CIVIL" Then 'PARA OBRA CIVIL
                    CELDA(4)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "ASOCIADO A RED" Then 'PARA ASOCIADO A RED
                    CELDA(3)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "EJECUCION" Then    'PARA EJECUCION
                    CELDA(2)
                ElseIf TRABAJOSRow.TIPOTRABAJO = "ACTUALIZACION DE PLANOS" Then 'PARA ACTUALIZACION PLANOS
                    CELDA(1)
                End If
            Next
            POS_Y += 15
        Next
        LIENZO.DrawLine(LAPIZ_GRAY, POS_X + 423, 20, POS_X + 423, 60 + ORDENESDataSet.GESTION.Rows.Count * 15)
        AVANCEGEST.Value = 0
        Me.Cursor = DefaultCursor
    End Sub

End Class