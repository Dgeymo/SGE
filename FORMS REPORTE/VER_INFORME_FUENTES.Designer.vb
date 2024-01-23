<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VER_INFORME_FUENTES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me._INFORMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORME_FUENTESDataSet = New REDES.INFORME_FUENTESDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me._INFORMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORME_FUENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_INFORMEBindingSource
        '
        Me._INFORMEBindingSource.DataMember = "‌INFORME"
        Me._INFORMEBindingSource.DataSource = Me.INFORME_FUENTESDataSet
        '
        'INFORME_FUENTESDataSet
        '
        Me.INFORME_FUENTESDataSet.DataSetName = "INFORME_FUENTESDataSet"
        Me.INFORME_FUENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me._INFORMEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "REDES.INFORME_FUENTES.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 631)
        Me.ReportViewer1.TabIndex = 0
        '
        'VER_INFORME_FUENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 631)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VER_INFORME_FUENTES"
        Me.Text = "VER_INFORME_FUENTES"
        CType(Me._INFORMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORME_FUENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents INFORME_FUENTESDataSet As INFORME_FUENTESDataSet
    Friend WithEvents _INFORMEBindingSource As BindingSource
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
