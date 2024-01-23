Public Class INFORME_MDU_PERMISORES
    Dim GESTIONRow As DataRow
    Dim TRABAJOSRow As DataRow
    Dim NewINFORMERow As ORDENESDataSet.INFORMMEMDU_PERMISORRow
    Dim FECHA_PREVISTA As Date


    Private Sub INFORME_MDU_PERMISORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.INFORMMEMDU_PERMISOR' Puede moverla o quitarla según sea necesario.
        'Me.INFORMMEMDU_PERMISORTableAdapter.Fill(Me.ORDENESDataSet.INFORMMEMDU_PERMISOR)
        'TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.TRABAJOS' Puede moverla o quitarla según sea necesario.
        'Me.TRABAJOSTableAdapter.Fill(Me.ORDENESDataSet.TRABAJOS)
        Me.Cursor = Cursors.WaitCursor

        'BUSCA GESTIONES PENDIENTES
        Me.GESTIONTableAdapter.FillByNOSTATUS(ORDENESDataSet.GESTION, "FINALIZADO", "Obra Nueva")


        Me.Cursor = DefaultCursor


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        For I = 0 To ORDENESDataSet.GESTION.Rows.Count - 1
            GESTIONRow = ORDENESDataSet.GESTION.Rows(I)
            'BUSCA LOS TRABAJOS DENTRO DE LA GESTION
            TRABAJOSTableAdapter.FillByIDGESTION(ORDENESDataSet.TRABAJOS, GESTIONRow("ID_GESTION"))
            If ORDENESDataSet.TRABAJOS.Rows.Count > 0 Then

                For X = 0 To ORDENESDataSet.TRABAJOS.Count - 1
                    TRABAJOSRow = ORDENESDataSet.TRABAJOS.Rows(X)

                    NewINFORMERow = ORDENESDataSet.INFORMMEMDU_PERMISOR.NewINFORMMEMDU_PERMISORRow
                    'GENERA UNA LINEA DE INFORME
                    'DATOS DE GESTION
                    NewINFORMERow("CALLE") = Trim(GESTIONRow("CALLE")) & " " & GESTIONRow("NUMERO")
                    'NewINFORMERow("NRO") = GESTIONRow("NUMERO")
                    'DATOS DE TRABAJO

                    NewINFORMERow("ITEM") = TRABAJOSRow("TIPOTRABAJO")
                    NewINFORMERow("STATUS") = TRABAJOSRow("STATUS")


                    Select Case TRABAJOSRow("STATUS")
                        Case "FINALIZADO"
                            NewINFORMERow("FECHAFINREAL") = TRABAJOSRow("FECHAFINALIZADO")
                            NewINFORMERow("DEMORA") = DateDiff(DateInterval.Day, DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO")), TRABAJOSRow("FECHAFINALIZADO"))
                            If TRABAJOSRow("FECHAFINALIZADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAFINALIZADO") < FECHA_HASTA.Value.ToShortDateString Then
                                NewINFORMERow("REALIZADAACTUAL") = True
                            End If
                        Case "INICIADO"
                            NewINFORMERow("FECHAINICIOREAL") = TRABAJOSRow("FECHAINICIADO")
                            NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICIADO"))
                            If TRABAJOSRow("FECHAINICIADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAINICIADO") < FECHA_HASTA.Value.ToShortDateString Then
                                NewINFORMERow("REALIZADAACTUAL") = True
                            End If
                        Case "INGRESADO"
                            NewINFORMERow("FECHAINIESTIMADO") = TRABAJOSRow("FECHAINICESTIMADO")
                            NewINFORMERow("TESTIMADO") = TRABAJOSRow("TIEMPOESTIMADO")
                            NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
                            If TRABAJOSRow("FECHAINGRESADO") > FECHA_DESDE.Value.ToShortDateString And TRABAJOSRow("FECHAINGRESADO") < FECHA_HASTA.Value.ToShortDateString Then
                                NewINFORMERow("REALIZADAACTUAL") = True
                            End If
                        Case Else
                            'NewINFORMERow("REALIZADAACTUAL") = False
                    End Select
                    If TRABAJOSRow("TIPOTRABAJO") = "EJECUCION" Then
                        FECHA_PREVISTA = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
                    Else
                        FECHA_PREVISTA = Nothing
                    End If
                    ORDENESDataSet.INFORMMEMDU_PERMISOR.AddINFORMMEMDU_PERMISORRow(NewINFORMERow)
                Next X

            End If
            NewINFORMERow = ORDENESDataSet.INFORMMEMDU_PERMISOR.NewINFORMMEMDU_PERMISORRow

            NewINFORMERow("CALLE") = Trim(GESTIONRow("CALLE")) & " " & GESTIONRow("NUMERO")
            'NewINFORMERow("NRO") = GESTIONRow("NUMERO")
            NewINFORMERow("ITEM") = "FECHA FINALIZACION PREVISTA"
            If FECHA_PREVISTA <> Nothing Then
                NewINFORMERow("FECHAFINESTIMADA") = DateAdd(DateInterval.Day, TRABAJOSRow("TIEMPOESTIMADO"), TRABAJOSRow("FECHAINICESTIMADO"))
            Else
                NewINFORMERow("FECHAFINESTIMADA") = DBNull.Value
            End If
            ORDENESDataSet.INFORMMEMDU_PERMISOR.AddINFORMMEMDU_PERMISORRow(NewINFORMERow)
        Next I

        Me.ReportViewer1.RefreshReport()
        Me.Cursor = DefaultCursor
    End Sub
End Class