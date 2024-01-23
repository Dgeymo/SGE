<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RUTEO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager.ORDENESTableAdapter = Me.ORDENESTableAdapter
        Me.TableAdapterManager.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager.STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager.TAREASTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDENESDataGridView
        '
        Me.ORDENESDataGridView.AutoGenerateColumns = False
        Me.ORDENESDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ORDENESDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ORDENESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ORDENESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ORDENESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn28})
        Me.ORDENESDataGridView.DataSource = Me.ORDENESBindingSource
        Me.ORDENESDataGridView.EnableHeadersVisualStyles = False
        Me.ORDENESDataGridView.GridColor = System.Drawing.Color.White
        Me.ORDENESDataGridView.Location = New System.Drawing.Point(12, 21)
        Me.ORDENESDataGridView.Name = "ORDENESDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ORDENESDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ORDENESDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.ORDENESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ORDENESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ORDENESDataGridView.Size = New System.Drawing.Size(761, 639)
        Me.ORDENESDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRIORIDAD"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Prioridad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SECTORDESTINO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRO_ORDENINT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OrdenINT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SECTOROPE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Recurso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "CLASEDEP"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn55.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn55.HeaderText = "Clase"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRO_ORDINAL"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ordinal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "ORDENDEP"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Ord"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 30
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "DEPENDENCIA"
        Me.DataGridViewTextBoxColumn47.HeaderText = "ORDDepend"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "TPREVISTO"
        Me.DataGridViewTextBoxColumn42.HeaderText = "TPre"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 30
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "MOTIVOORIGEN"
        Me.DataGridViewTextBoxColumn28.HeaderText = "MOTIVOORIGEN"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 200
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ORDENESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "REDES.RUTEO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(821, 21)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(529, 639)
        Me.ReportViewer1.TabIndex = 2
        '
        'RUTEO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ORDENESDataGridView)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "RUTEO"
        Me.Text = "RUTEO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDENESDataGridView As DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
End Class
