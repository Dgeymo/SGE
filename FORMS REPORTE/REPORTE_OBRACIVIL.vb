Imports Microsoft.Reporting.WinForms

Public Class REPORTE_OBRACIVIL
    Private Sub REPORTE_OBRACIVIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ReportDataSource2 As New ReportDataSource()
        Dim ReporteDataTable As DataTable = ORDENESDataSet.REPORTE_OC
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = ReporteDataTable

        ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)

        ReportViewer2.AutoSize = True
        ReportViewer2.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer2.ZoomMode = ZoomMode.FullPage
        ' ReportViewer2.SetPageSettings.landscape = True

        Dim setup = ReportViewer2.GetPageSettings()
        setup.Margins = New Printing.Margins(15, 1, 15, 10)
        setup.Landscape = True
        ReportViewer2.SetPageSettings(setup)
        Me.ReportViewer2.RefreshReport()
    End Sub

End Class