<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INFORME_MDU_PERMISORES
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
        Me.FECHA_DESDE = New System.Windows.Forms.DateTimePicker()
        Me.FECHA_HASTA = New System.Windows.Forms.DateTimePicker()
        Me.INFORMMEMDU_PERMISORDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICIOREAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEMORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFORMMEMDU_PERMISORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.INFORMMEMDU_PERMISORTableAdapter = New REDES.ORDENESDataSetTableAdapters.INFORMMEMDU_PERMISORTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.INFORMMEMDU_PERMISORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMMEMDU_PERMISORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHA_DESDE
        '
        Me.FECHA_DESDE.Location = New System.Drawing.Point(117, 12)
        Me.FECHA_DESDE.Name = "FECHA_DESDE"
        Me.FECHA_DESDE.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DESDE.TabIndex = 3
        '
        'FECHA_HASTA
        '
        Me.FECHA_HASTA.Location = New System.Drawing.Point(412, 12)
        Me.FECHA_HASTA.Name = "FECHA_HASTA"
        Me.FECHA_HASTA.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_HASTA.TabIndex = 4
        '
        'INFORMMEMDU_PERMISORDataGridView
        '
        Me.INFORMMEMDU_PERMISORDataGridView.AutoGenerateColumns = False
        Me.INFORMMEMDU_PERMISORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INFORMMEMDU_PERMISORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.STATUS, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.FECHAINICIOREAL, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DEMORA})
        Me.INFORMMEMDU_PERMISORDataGridView.DataSource = Me.INFORMMEMDU_PERMISORBindingSource
        Me.INFORMMEMDU_PERMISORDataGridView.Location = New System.Drawing.Point(21, 65)
        Me.INFORMMEMDU_PERMISORDataGridView.Name = "INFORMMEMDU_PERMISORDataGridView"
        Me.INFORMMEMDU_PERMISORDataGridView.Size = New System.Drawing.Size(668, 137)
        Me.INFORMMEMDU_PERMISORDataGridView.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(639, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'STATUS
        '
        Me.STATUS.DataPropertyName = "STATUS"
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        '
        'FECHAINICIOREAL
        '
        Me.FECHAINICIOREAL.DataPropertyName = "FECHAINICIOREAL"
        Me.FECHAINICIOREAL.HeaderText = "FECHAINICIOREAL"
        Me.FECHAINICIOREAL.Name = "FECHAINICIOREAL"
        '
        'DEMORA
        '
        Me.DEMORA.DataPropertyName = "DEMORA"
        Me.DEMORA.HeaderText = "DEMORA"
        Me.DEMORA.Name = "DEMORA"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "ID_INFORME"
        Me.DataGridViewTextBoxColumn53.HeaderText = "ID_INFORME"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "CALLE"
        Me.DataGridViewTextBoxColumn54.HeaderText = "CALLE"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "NRO"
        Me.DataGridViewTextBoxColumn55.HeaderText = "NRO"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "ITEM"
        Me.DataGridViewTextBoxColumn56.HeaderText = "ITEM"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "FECHAINIESTIMADO"
        Me.DataGridViewTextBoxColumn57.HeaderText = "FECHAINIESTIMADO"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "TESTIMADO"
        Me.DataGridViewTextBoxColumn58.HeaderText = "TESTIMADO"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "FECHAFINESTIMADA"
        Me.DataGridViewTextBoxColumn59.HeaderText = "FECHAFINESTIMADA"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "FECHAFINREAL"
        Me.DataGridViewTextBoxColumn60.HeaderText = "FECHAFINREAL"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "REALIZADAACTUAL"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "REALIZADAACTUAL"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "FECHADESDE"
        Me.DataGridViewTextBoxColumn61.HeaderText = "FECHADESDE"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "FECHAHASTA"
        Me.DataGridViewTextBoxColumn62.HeaderText = "FECHAHASTA"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
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
        'TRABAJOSBindingSource
        '
        Me.TRABAJOSBindingSource.DataMember = "TRABAJOS"
        Me.TRABAJOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONTableAdapter = Me.GESTIONTableAdapter
        Me.TableAdapterManager.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager.ORDENESTableAdapter = Nothing
        Me.TableAdapterManager.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager.STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager.TAREASTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJOSTableAdapter = Me.TRABAJOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
        '
        'INFORMMEMDU_PERMISORTableAdapter
        '
        Me.INFORMMEMDU_PERMISORTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.INFORMMEMDU_PERMISORBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "REDES.INFORME_MDU_PERMISORES.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 208)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(668, 246)
        Me.ReportViewer1.TabIndex = 6
        '
        'INFORME_MDU_PERMISORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 510)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.INFORMMEMDU_PERMISORDataGridView)
        Me.Controls.Add(Me.FECHA_HASTA)
        Me.Controls.Add(Me.FECHA_DESDE)
        Me.Name = "INFORME_MDU_PERMISORES"
        Me.Text = "INFORME_MDU_PERMISORES"
        CType(Me.INFORMMEMDU_PERMISORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMMEMDU_PERMISORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents FECHA_DESDE As DateTimePicker
    Friend WithEvents FECHA_HASTA As DateTimePicker
    Friend WithEvents INFORMMEMDU_PERMISORBindingSource As BindingSource
    Friend WithEvents INFORMMEMDU_PERMISORTableAdapter As ORDENESDataSetTableAdapters.INFORMMEMDU_PERMISORTableAdapter
    Friend WithEvents INFORMMEMDU_PERMISORDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICIOREAL As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DEMORA As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
