<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VER_INFORME_INDICE
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
        Me.RepoIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORME_INDICEDataSet = New REDES.INFORME_INDICEDataSet()
        Me.BaseIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RepoIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.RepoIndicesTableAdapter()
        Me.BaseIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.BaseIndicesTableAdapter()
        Me.TableAdapterManager = New REDES.INFORME_INDICEDataSetTableAdapters.TableAdapterManager()
        Me.HistoIndices_dataset = New REDES.INFORME_INDICEDataSet()
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORME_INDICEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoIndices_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepoIndicesBindingSource
        '
        Me.RepoIndicesBindingSource.DataMember = "RepoIndices"
        Me.RepoIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'INFORME_INDICEDataSet
        '
        Me.INFORME_INDICEDataSet.DataSetName = "INFORME_INDICEDataSet"
        Me.INFORME_INDICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaseIndicesBindingSource
        '
        Me.BaseIndicesBindingSource.DataMember = "BaseIndices"
        Me.BaseIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RepoIndicesBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.BaseIndicesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "REDES.INFORME_INDICES.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'RepoIndicesTableAdapter
        '
        Me.RepoIndicesTableAdapter.ClearBeforeFill = True
        '
        'BaseIndicesTableAdapter
        '
        Me.BaseIndicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BaseCalculoTableAdapter = Nothing
        Me.TableAdapterManager.BaseIndicesTableAdapter = Me.BaseIndicesTableAdapter
        Me.TableAdapterManager.BasePermisoresTableAdapter = Nothing
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.FALLAS_ORIGENTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.HistoIndicesTableAdapter = Nothing
        Me.TableAdapterManager.InfoIndicesTableAdapter = Nothing
        Me.TableAdapterManager.InformesTableAdapter = Nothing
        Me.TableAdapterManager.ORDINALESREDTableAdapter = Nothing
        Me.TableAdapterManager.OrdinalesTableAdapter = Nothing
        Me.TableAdapterManager.RepoIndicesTableAdapter = Me.RepoIndicesTableAdapter
        Me.TableAdapterManager.SectoresTableAdapter = Nothing
        Me.TableAdapterManager.StatusOrdinalTableAdapter = Nothing
        Me.TableAdapterManager.StatusReclamoTableAdapter = Nothing
        Me.TableAdapterManager.TablaWEBTableAdapter = Nothing
        Me.TableAdapterManager.TecnicosTableAdapter = Nothing
        Me.TableAdapterManager.TipoSolRecTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.INFORME_INDICEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ZonasREDTableAdapter = Nothing
        '
        'HistoIndices_dataset
        '
        Me.HistoIndices_dataset.DataSetName = "INFORME_INDICEDataSet"
        Me.HistoIndices_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VER_INFORME_INDICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 532)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VER_INFORME_INDICE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "VER_INFORME_INDICE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORME_INDICEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoIndices_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoIndicesBindingSource As BindingSource
    Friend WithEvents INFORME_INDICEDataSet As INFORME_INDICEDataSet
    Friend WithEvents BaseIndicesBindingSource As BindingSource
    Friend WithEvents RepoIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.RepoIndicesTableAdapter
    Friend WithEvents BaseIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.BaseIndicesTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TableAdapterManager As INFORME_INDICEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistoIndices_dataset As INFORME_INDICEDataSet
End Class
