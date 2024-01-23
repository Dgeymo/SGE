<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INFORME_MDU_GESTIONESPROGRAMADAS
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.INFORMMEMDU_PERMISORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.FECHA_DESDE = New System.Windows.Forms.DateTimePicker()
        Me.FECHA_HASTA = New System.Windows.Forms.DateTimePicker()
        Me.MDUDataSet = New REDES.MDUDataSet()
        Me.ANALISISGESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANALISISGESTTableAdapter = New REDES.MDUDataSetTableAdapters.ANALISISGESTTableAdapter()
        Me.AVANCEGEST = New System.Windows.Forms.ProgressBar()
        Me.AVANCETRAB = New System.Windows.Forms.ProgressBar()
        Me.AVANCEORD = New System.Windows.Forms.ProgressBar()
        Me.CANT_GESTIONES = New System.Windows.Forms.Label()
        Me.CANT_TRABAJOS = New System.Windows.Forms.Label()
        Me.CANT_ORDENES = New System.Windows.Forms.Label()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GEST_NRO = New System.Windows.Forms.Label()
        Me.BTN_REPORT_AVANCE = New System.Windows.Forms.Button()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PAINT_PANEL = New System.Windows.Forms.Panel()
        Me.INFORMMEMDU_PERMISORTableAdapter = New REDES.ORDENESDataSetTableAdapters.INFORMMEMDU_PERMISORTableAdapter()
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.ReporteordinalesTableAdapter1 = New REDES.ORDENESDataSetTableAdapters.REPORTEORDINALESTableAdapter()
        Me.AVANCE_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.INFORMMEMDU_PERMISORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANALISISGESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVANCE_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INFORMMEMDU_PERMISORBindingSource
        '
        Me.INFORMMEMDU_PERMISORBindingSource.DataMember = "INFORMMEMDU_PERMISOR"
        Me.INFORMMEMDU_PERMISORBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FECHA_DESDE
        '
        Me.FECHA_DESDE.Location = New System.Drawing.Point(54, 3)
        Me.FECHA_DESDE.Name = "FECHA_DESDE"
        Me.FECHA_DESDE.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DESDE.TabIndex = 6
        '
        'FECHA_HASTA
        '
        Me.FECHA_HASTA.Location = New System.Drawing.Point(344, 3)
        Me.FECHA_HASTA.Name = "FECHA_HASTA"
        Me.FECHA_HASTA.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_HASTA.TabIndex = 7
        '
        'MDUDataSet
        '
        Me.MDUDataSet.DataSetName = "MDUDataSet"
        Me.MDUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ANALISISGESTBindingSource
        '
        Me.ANALISISGESTBindingSource.DataMember = "ANALISISGEST"
        Me.ANALISISGESTBindingSource.DataSource = Me.MDUDataSet
        '
        'ANALISISGESTTableAdapter
        '
        Me.ANALISISGESTTableAdapter.ClearBeforeFill = True
        '
        'AVANCEGEST
        '
        Me.AVANCEGEST.Location = New System.Drawing.Point(398, 34)
        Me.AVANCEGEST.Name = "AVANCEGEST"
        Me.AVANCEGEST.Size = New System.Drawing.Size(182, 13)
        Me.AVANCEGEST.TabIndex = 8
        '
        'AVANCETRAB
        '
        Me.AVANCETRAB.Location = New System.Drawing.Point(398, 51)
        Me.AVANCETRAB.Name = "AVANCETRAB"
        Me.AVANCETRAB.Size = New System.Drawing.Size(182, 13)
        Me.AVANCETRAB.TabIndex = 9
        '
        'AVANCEORD
        '
        Me.AVANCEORD.Location = New System.Drawing.Point(398, 68)
        Me.AVANCEORD.Name = "AVANCEORD"
        Me.AVANCEORD.Size = New System.Drawing.Size(182, 13)
        Me.AVANCEORD.TabIndex = 10
        '
        'CANT_GESTIONES
        '
        Me.CANT_GESTIONES.AutoSize = True
        Me.CANT_GESTIONES.ForeColor = System.Drawing.Color.LightBlue
        Me.CANT_GESTIONES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CANT_GESTIONES.Location = New System.Drawing.Point(332, 32)
        Me.CANT_GESTIONES.Name = "CANT_GESTIONES"
        Me.CANT_GESTIONES.Size = New System.Drawing.Size(29, 13)
        Me.CANT_GESTIONES.TabIndex = 11
        Me.CANT_GESTIONES.Text = "Gest"
        '
        'CANT_TRABAJOS
        '
        Me.CANT_TRABAJOS.AutoSize = True
        Me.CANT_TRABAJOS.ForeColor = System.Drawing.Color.LightBlue
        Me.CANT_TRABAJOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CANT_TRABAJOS.Location = New System.Drawing.Point(332, 50)
        Me.CANT_TRABAJOS.Name = "CANT_TRABAJOS"
        Me.CANT_TRABAJOS.Size = New System.Drawing.Size(29, 13)
        Me.CANT_TRABAJOS.TabIndex = 12
        Me.CANT_TRABAJOS.Text = "Trab"
        '
        'CANT_ORDENES
        '
        Me.CANT_ORDENES.AutoSize = True
        Me.CANT_ORDENES.ForeColor = System.Drawing.Color.LightBlue
        Me.CANT_ORDENES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CANT_ORDENES.Location = New System.Drawing.Point(332, 68)
        Me.CANT_ORDENES.Name = "CANT_ORDENES"
        Me.CANT_ORDENES.Size = New System.Drawing.Size(24, 13)
        Me.CANT_ORDENES.TabIndex = 13
        Me.CANT_ORDENES.Text = "Ord"
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.INFORMMEMDU_PERMISORBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "REDES.REPORTE_MDU_TRABAJOSPREVISTOS.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, -27)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(1350, 378)
        Me.ReportViewer2.TabIndex = 14
        Me.ReportViewer2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Reporte de estado por Edificio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 32)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Reporte de TRABAJOS a Realizar por FECHA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 32)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Reporte de estado para PERMISORES"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.INFORMMEMDU_PERMISORBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "REDES.INFORME_MDU_PERMISORES.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 351)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(1350, 378)
        Me.ReportViewer3.TabIndex = 18
        Me.ReportViewer3.Visible = False
        '
        'GEST_NRO
        '
        Me.GEST_NRO.AutoSize = True
        Me.GEST_NRO.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_NRO.Location = New System.Drawing.Point(367, 32)
        Me.GEST_NRO.Name = "GEST_NRO"
        Me.GEST_NRO.Size = New System.Drawing.Size(29, 13)
        Me.GEST_NRO.TabIndex = 19
        Me.GEST_NRO.Text = "Gest"
        '
        'BTN_REPORT_AVANCE
        '
        Me.BTN_REPORT_AVANCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_REPORT_AVANCE.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_REPORT_AVANCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REPORT_AVANCE.ForeColor = System.Drawing.Color.White
        Me.BTN_REPORT_AVANCE.Location = New System.Drawing.Point(371, 116)
        Me.BTN_REPORT_AVANCE.Name = "BTN_REPORT_AVANCE"
        Me.BTN_REPORT_AVANCE.Size = New System.Drawing.Size(134, 32)
        Me.BTN_REPORT_AVANCE.TabIndex = 20
        Me.BTN_REPORT_AVANCE.Text = "REPORTE AVANCES"
        Me.BTN_REPORT_AVANCE.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.ServerReport.BearerToken = Nothing
        Me.ReportViewer4.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer4.TabIndex = 0
        '
        'PAINT_PANEL
        '
        Me.PAINT_PANEL.BackColor = System.Drawing.Color.White
        Me.PAINT_PANEL.Dock = System.Windows.Forms.DockStyle.Right
        Me.PAINT_PANEL.Location = New System.Drawing.Point(586, 0)
        Me.PAINT_PANEL.Name = "PAINT_PANEL"
        Me.PAINT_PANEL.Size = New System.Drawing.Size(764, 0)
        Me.PAINT_PANEL.TabIndex = 22
        '
        'INFORMMEMDU_PERMISORTableAdapter
        '
        Me.INFORMMEMDU_PERMISORTableAdapter.ClearBeforeFill = True
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
        '
        'ReporteordinalesTableAdapter1
        '
        Me.ReporteordinalesTableAdapter1.ClearBeforeFill = True
        '
        'AVANCE_BindingSource
        '
        Me.AVANCE_BindingSource.DataMember = "ORDENES"
        Me.AVANCE_BindingSource.DataSource = Me.ORDENESDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.COMBOSTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONES_TIPOTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager.ORDENESTableAdapter = Nothing
        Me.TableAdapterManager.PRESUPUESTOTableAdapter = Nothing
        Me.TableAdapterManager.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager.STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager.TAREASTableAdapter = Nothing
        Me.TableAdapterManager.TIPOTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'TRABAJOSBindingSource
        '
        Me.TRABAJOSBindingSource.DataMember = "TRABAJOS"
        Me.TRABAJOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(367, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Trab"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(368, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Ord"
        '
        'INFORME_MDU_GESTIONESPROGRAMADAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_REPORT_AVANCE)
        Me.Controls.Add(Me.GEST_NRO)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CANT_ORDENES)
        Me.Controls.Add(Me.CANT_TRABAJOS)
        Me.Controls.Add(Me.CANT_GESTIONES)
        Me.Controls.Add(Me.AVANCEORD)
        Me.Controls.Add(Me.AVANCETRAB)
        Me.Controls.Add(Me.AVANCEGEST)
        Me.Controls.Add(Me.FECHA_HASTA)
        Me.Controls.Add(Me.FECHA_DESDE)
        Me.Controls.Add(Me.PAINT_PANEL)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Name = "INFORME_MDU_GESTIONESPROGRAMADAS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMES MDU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.INFORMMEMDU_PERMISORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANALISISGESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVANCE_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents INFORMMEMDU_PERMISORBindingSource As BindingSource
    Friend WithEvents INFORMMEMDU_PERMISORTableAdapter As ORDENESDataSetTableAdapters.INFORMMEMDU_PERMISORTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents FECHA_DESDE As DateTimePicker
    Friend WithEvents FECHA_HASTA As DateTimePicker
    Friend WithEvents ANALISISGESTBindingSource As BindingSource
    Friend WithEvents MDUDataSet As MDUDataSet
    Friend WithEvents ANALISISGESTTableAdapter As MDUDataSetTableAdapters.ANALISISGESTTableAdapter
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents AVANCEGEST As ProgressBar
    Friend WithEvents AVANCETRAB As ProgressBar
    Friend WithEvents AVANCEORD As ProgressBar
    Friend WithEvents CANT_GESTIONES As Label
    Friend WithEvents CANT_TRABAJOS As Label
    Friend WithEvents CANT_ORDENES As Label
    Friend WithEvents ReporteordinalesTableAdapter1 As ORDENESDataSetTableAdapters.REPORTEORDINALESTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GEST_NRO As Label
    Private WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BTN_REPORT_AVANCE As Button
    Private WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AVANCE_BindingSource As BindingSource
    Friend WithEvents PAINT_PANEL As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
