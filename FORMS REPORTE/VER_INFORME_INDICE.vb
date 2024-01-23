Imports Microsoft.Reporting.WinForms
Public Class VER_INFORME_INDICE
    Private Sub VER_INFORME_INDICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseIndicesTableAdapter.Fill(INFORME_INDICEDataSet.BaseIndices)
        Dim PARAMETROS(49) As ReportParameter


        For X = 0 To INFORME_INDICEDataSet.RepoIndices.Rows.Count - 1
            Select Case INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("Indice")


                'PARA SIN SEÑAL
                Case 1
                    PARAMETROS(X) = New ReportParameter("VALOR_INDICE_SIN_SEÑAL", Replace(INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString, "%", ""))
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 2
                    PARAMETROS(X) = New ReportParameter("VALOR_INDICE_TODOS", Replace(INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString, "%", ""))
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 47
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_SS_PORCENT_MAYOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 40
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_SS_MAYOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 39
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_SS_SOL_MENOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 38
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_SS_SOL_MENOR_T_ACEP", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 37
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_SS_SOL_ENDIA", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 36
                    PARAMETROS(X) = New ReportParameter("CANT_RECLAMOS_TOTAL_SINSEÑAL", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))


                    'PARA TODOS
                Case 2
                    PARAMETROS(X) = New ReportParameter("VALOR_INDICE_TODOS", Replace(INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString, "%", ""))
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 41
                    PARAMETROS(X) = New ReportParameter("CANT_RECLAMOS_ATENDIDOS", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 42
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_TODOS_SOL_ENDIA", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 43
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_TODOS_SOL_MENOR_T_ACEP", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 44
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_TODOS_MENOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 45
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_TODOS_MAYOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 49
                    PARAMETROS(X) = New ReportParameter("RECLAMOS_TODOS_PORCENT_MAYOR_ADMISIBLE", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))


                    'PARA LOS PROMEDIOS
                Case 3
                    PARAMETROS(X) = New ReportParameter("PROMEDIO_RECLAMOS_SS", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 6
                    PARAMETROS(X) = New ReportParameter("PROMEDIO_RECLAMOS_TODOS_SIN_SS", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 4
                    PARAMETROS(X) = New ReportParameter("TIEMPOMAXIMO_RECLAMOS_SIN_SENAL", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
                Case 5
                    PARAMETROS(X) = New ReportParameter("TIEMPOMAXIMO_RECLAMOS_TODOS", INFORME_INDICEDataSet.RepoIndices.Rows(X).Item("ValorIndice").ToString)
                    Me.ReportViewer1.LocalReport.SetParameters(PARAMETROS(X))
            End Select




        Next
        ReportViewer1.Dock = DockStyle.Fill
        ReportViewer1.AutoSize = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
       ' ReportViewer1.ZoomMode = ZoomMode.PageWidth

        'Dim setup = ReportViewer1.GetPageSettings()
        'setup.Margins = New Printing.Margins(15, 1, 15, 10)
        '' setup.Landscape = True
        'ReportViewer1.SetPageSettings(setup)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class