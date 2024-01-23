Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Public Class VER_INFORME_MATERIALES
    Private Sub VER_INFORMES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ReportDataSource2 As New ReportDataSource()
        Dim ReporteDataTable As DataTable = MATERIALES.IndicesDataSet.MAT_INFORME
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = ReporteDataTable

        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)

        ReportViewer1.AutoSize = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth

        Dim setup = ReportViewer1.GetPageSettings()
        setup.Margins = New Printing.Margins(15, 1, 15, 10)
        '  setup.Landscape = True
        ReportViewer1.SetPageSettings(setup)
        Me.ReportViewer1.RefreshReport()
        '    Me.ReportViewer1.RefreshReport()

    End Sub


End Class