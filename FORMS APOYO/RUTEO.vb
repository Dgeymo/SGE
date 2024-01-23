Public Class RUTEO
    Private Sub RUTEO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ORDENESDataSet.ORDENES' Puede moverla o quitarla según sea necesario.

        'Me.ORDENESTableAdapter.FillByFECHA_RUTEO(Me.ORDENESDataSet.ORDENES, AGENDA.FECHA_RUTEO)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class