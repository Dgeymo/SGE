<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OC_LISTADO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.BTN_QUITAR = New System.Windows.Forms.Button()
        Me.ORDEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRABAJO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NODO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTRABAJODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGESTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOTRABAJODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINGRESADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERADOXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICIADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAFINALIZADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPOESTIMADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPOREALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEMORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AREADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NODODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANZANADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASIGNADOADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTORASIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDASIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPLETODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DEPENDENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPODEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTALACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTALACIONRUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUERIDODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HABILITADODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ATRIBUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.GESTIONTableAdapter = Me.GESTIONTableAdapter
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
        Me.TableAdapterManager.TRABAJOSTableAdapter = Me.TRABAJOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(519, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TEXT1"
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.Location = New System.Drawing.Point(302, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "TEXT2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTRABAJODataGridViewTextBoxColumn, Me.IDGESTIONDataGridViewTextBoxColumn, Me.TIPOTRABAJODataGridViewTextBoxColumn, Me.FECHAINGRESADODataGridViewTextBoxColumn, Me.GENERADOXDataGridViewTextBoxColumn, Me.FECHAINICIADODataGridViewTextBoxColumn, Me.FECHAFINALIZADODataGridViewTextBoxColumn, Me.TIEMPOESTIMADODataGridViewTextBoxColumn, Me.TIEMPOREALDataGridViewTextBoxColumn, Me.DEMORADataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.AREADataGridViewTextBoxColumn, Me.FECHAINICESTIMADODataGridViewTextBoxColumn, Me.NODODataGridViewTextBoxColumn, Me.ZONADataGridViewTextBoxColumn, Me.MANZANADataGridViewTextBoxColumn, Me.CALLEDataGridViewTextBoxColumn, Me.NRODataGridViewTextBoxColumn, Me.ASIGNADOADataGridViewTextBoxColumn, Me.SECTORASIGDataGridViewTextBoxColumn, Me.IDASIGDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.COMPLETODataGridViewCheckBoxColumn, Me.DEPENDENCIADataGridViewTextBoxColumn, Me.TIPODEPDataGridViewTextBoxColumn, Me.INSTALACIONDataGridViewTextBoxColumn, Me.INSTALACIONRUSDataGridViewTextBoxColumn, Me.REQUERIDODataGridViewCheckBoxColumn, Me.HABILITADODataGridViewCheckBoxColumn, Me.ATRIBUTODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TRABAJOSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(669, 388)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowDrop = True
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDEN, Me.TRABAJO, Me.DIRECCION, Me.NODO, Me.ZONA})
        Me.DataGridView2.Location = New System.Drawing.Point(816, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(522, 388)
        Me.DataGridView2.TabIndex = 3
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(722, 271)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_AGREGAR.TabIndex = 4
        Me.BTN_AGREGAR.Text = ">>"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'BTN_QUITAR
        '
        Me.BTN_QUITAR.Location = New System.Drawing.Point(722, 300)
        Me.BTN_QUITAR.Name = "BTN_QUITAR"
        Me.BTN_QUITAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_QUITAR.TabIndex = 5
        Me.BTN_QUITAR.Text = "<<"
        Me.BTN_QUITAR.UseVisualStyleBackColor = True
        '
        'ORDEN
        '
        Me.ORDEN.HeaderText = "ORDEN"
        Me.ORDEN.Name = "ORDEN"
        Me.ORDEN.ReadOnly = True
        '
        'TRABAJO
        '
        Me.TRABAJO.HeaderText = "TRABAJO"
        Me.TRABAJO.Name = "TRABAJO"
        Me.TRABAJO.ReadOnly = True
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        '
        'NODO
        '
        Me.NODO.HeaderText = "NODO"
        Me.NODO.Name = "NODO"
        Me.NODO.ReadOnly = True
        '
        'ZONA
        '
        Me.ZONA.HeaderText = "ZONA"
        Me.ZONA.Name = "ZONA"
        Me.ZONA.ReadOnly = True
        '
        'IdTRABAJODataGridViewTextBoxColumn
        '
        Me.IdTRABAJODataGridViewTextBoxColumn.DataPropertyName = "Id_TRABAJO"
        Me.IdTRABAJODataGridViewTextBoxColumn.HeaderText = "Id_TRABAJO"
        Me.IdTRABAJODataGridViewTextBoxColumn.Name = "IdTRABAJODataGridViewTextBoxColumn"
        '
        'IDGESTIONDataGridViewTextBoxColumn
        '
        Me.IDGESTIONDataGridViewTextBoxColumn.DataPropertyName = "ID_GESTION"
        Me.IDGESTIONDataGridViewTextBoxColumn.HeaderText = "ID_GESTION"
        Me.IDGESTIONDataGridViewTextBoxColumn.Name = "IDGESTIONDataGridViewTextBoxColumn"
        '
        'TIPOTRABAJODataGridViewTextBoxColumn
        '
        Me.TIPOTRABAJODataGridViewTextBoxColumn.DataPropertyName = "TIPOTRABAJO"
        Me.TIPOTRABAJODataGridViewTextBoxColumn.HeaderText = "TIPOTRABAJO"
        Me.TIPOTRABAJODataGridViewTextBoxColumn.Name = "TIPOTRABAJODataGridViewTextBoxColumn"
        '
        'FECHAINGRESADODataGridViewTextBoxColumn
        '
        Me.FECHAINGRESADODataGridViewTextBoxColumn.DataPropertyName = "FECHAINGRESADO"
        Me.FECHAINGRESADODataGridViewTextBoxColumn.HeaderText = "FECHAINGRESADO"
        Me.FECHAINGRESADODataGridViewTextBoxColumn.Name = "FECHAINGRESADODataGridViewTextBoxColumn"
        '
        'GENERADOXDataGridViewTextBoxColumn
        '
        Me.GENERADOXDataGridViewTextBoxColumn.DataPropertyName = "GENERADOX"
        Me.GENERADOXDataGridViewTextBoxColumn.HeaderText = "GENERADOX"
        Me.GENERADOXDataGridViewTextBoxColumn.Name = "GENERADOXDataGridViewTextBoxColumn"
        '
        'FECHAINICIADODataGridViewTextBoxColumn
        '
        Me.FECHAINICIADODataGridViewTextBoxColumn.DataPropertyName = "FECHAINICIADO"
        Me.FECHAINICIADODataGridViewTextBoxColumn.HeaderText = "FECHAINICIADO"
        Me.FECHAINICIADODataGridViewTextBoxColumn.Name = "FECHAINICIADODataGridViewTextBoxColumn"
        '
        'FECHAFINALIZADODataGridViewTextBoxColumn
        '
        Me.FECHAFINALIZADODataGridViewTextBoxColumn.DataPropertyName = "FECHAFINALIZADO"
        Me.FECHAFINALIZADODataGridViewTextBoxColumn.HeaderText = "FECHAFINALIZADO"
        Me.FECHAFINALIZADODataGridViewTextBoxColumn.Name = "FECHAFINALIZADODataGridViewTextBoxColumn"
        '
        'TIEMPOESTIMADODataGridViewTextBoxColumn
        '
        Me.TIEMPOESTIMADODataGridViewTextBoxColumn.DataPropertyName = "TIEMPOESTIMADO"
        Me.TIEMPOESTIMADODataGridViewTextBoxColumn.HeaderText = "TIEMPOESTIMADO"
        Me.TIEMPOESTIMADODataGridViewTextBoxColumn.Name = "TIEMPOESTIMADODataGridViewTextBoxColumn"
        '
        'TIEMPOREALDataGridViewTextBoxColumn
        '
        Me.TIEMPOREALDataGridViewTextBoxColumn.DataPropertyName = "TIEMPOREAL"
        Me.TIEMPOREALDataGridViewTextBoxColumn.HeaderText = "TIEMPOREAL"
        Me.TIEMPOREALDataGridViewTextBoxColumn.Name = "TIEMPOREALDataGridViewTextBoxColumn"
        '
        'DEMORADataGridViewTextBoxColumn
        '
        Me.DEMORADataGridViewTextBoxColumn.DataPropertyName = "DEMORA"
        Me.DEMORADataGridViewTextBoxColumn.HeaderText = "DEMORA"
        Me.DEMORADataGridViewTextBoxColumn.Name = "DEMORADataGridViewTextBoxColumn"
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        '
        'AREADataGridViewTextBoxColumn
        '
        Me.AREADataGridViewTextBoxColumn.DataPropertyName = "AREA"
        Me.AREADataGridViewTextBoxColumn.HeaderText = "AREA"
        Me.AREADataGridViewTextBoxColumn.Name = "AREADataGridViewTextBoxColumn"
        '
        'FECHAINICESTIMADODataGridViewTextBoxColumn
        '
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.DataPropertyName = "FECHAINICESTIMADO"
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.HeaderText = "FECHAINICESTIMADO"
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.Name = "FECHAINICESTIMADODataGridViewTextBoxColumn"
        '
        'NODODataGridViewTextBoxColumn
        '
        Me.NODODataGridViewTextBoxColumn.DataPropertyName = "NODO"
        Me.NODODataGridViewTextBoxColumn.HeaderText = "NODO"
        Me.NODODataGridViewTextBoxColumn.Name = "NODODataGridViewTextBoxColumn"
        '
        'ZONADataGridViewTextBoxColumn
        '
        Me.ZONADataGridViewTextBoxColumn.DataPropertyName = "ZONA"
        Me.ZONADataGridViewTextBoxColumn.HeaderText = "ZONA"
        Me.ZONADataGridViewTextBoxColumn.Name = "ZONADataGridViewTextBoxColumn"
        '
        'MANZANADataGridViewTextBoxColumn
        '
        Me.MANZANADataGridViewTextBoxColumn.DataPropertyName = "MANZANA"
        Me.MANZANADataGridViewTextBoxColumn.HeaderText = "MANZANA"
        Me.MANZANADataGridViewTextBoxColumn.Name = "MANZANADataGridViewTextBoxColumn"
        '
        'CALLEDataGridViewTextBoxColumn
        '
        Me.CALLEDataGridViewTextBoxColumn.DataPropertyName = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.HeaderText = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.Name = "CALLEDataGridViewTextBoxColumn"
        '
        'NRODataGridViewTextBoxColumn
        '
        Me.NRODataGridViewTextBoxColumn.DataPropertyName = "NRO"
        Me.NRODataGridViewTextBoxColumn.HeaderText = "NRO"
        Me.NRODataGridViewTextBoxColumn.Name = "NRODataGridViewTextBoxColumn"
        '
        'ASIGNADOADataGridViewTextBoxColumn
        '
        Me.ASIGNADOADataGridViewTextBoxColumn.DataPropertyName = "ASIGNADOA"
        Me.ASIGNADOADataGridViewTextBoxColumn.HeaderText = "ASIGNADOA"
        Me.ASIGNADOADataGridViewTextBoxColumn.Name = "ASIGNADOADataGridViewTextBoxColumn"
        '
        'SECTORASIGDataGridViewTextBoxColumn
        '
        Me.SECTORASIGDataGridViewTextBoxColumn.DataPropertyName = "SECTORASIG"
        Me.SECTORASIGDataGridViewTextBoxColumn.HeaderText = "SECTORASIG"
        Me.SECTORASIGDataGridViewTextBoxColumn.Name = "SECTORASIGDataGridViewTextBoxColumn"
        '
        'IDASIGDataGridViewTextBoxColumn
        '
        Me.IDASIGDataGridViewTextBoxColumn.DataPropertyName = "IDASIG"
        Me.IDASIGDataGridViewTextBoxColumn.HeaderText = "IDASIG"
        Me.IDASIGDataGridViewTextBoxColumn.Name = "IDASIGDataGridViewTextBoxColumn"
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        '
        'COMPLETODataGridViewCheckBoxColumn
        '
        Me.COMPLETODataGridViewCheckBoxColumn.DataPropertyName = "COMPLETO"
        Me.COMPLETODataGridViewCheckBoxColumn.HeaderText = "COMPLETO"
        Me.COMPLETODataGridViewCheckBoxColumn.Name = "COMPLETODataGridViewCheckBoxColumn"
        '
        'DEPENDENCIADataGridViewTextBoxColumn
        '
        Me.DEPENDENCIADataGridViewTextBoxColumn.DataPropertyName = "DEPENDENCIA"
        Me.DEPENDENCIADataGridViewTextBoxColumn.HeaderText = "DEPENDENCIA"
        Me.DEPENDENCIADataGridViewTextBoxColumn.Name = "DEPENDENCIADataGridViewTextBoxColumn"
        '
        'TIPODEPDataGridViewTextBoxColumn
        '
        Me.TIPODEPDataGridViewTextBoxColumn.DataPropertyName = "TIPODEP"
        Me.TIPODEPDataGridViewTextBoxColumn.HeaderText = "TIPODEP"
        Me.TIPODEPDataGridViewTextBoxColumn.Name = "TIPODEPDataGridViewTextBoxColumn"
        '
        'INSTALACIONDataGridViewTextBoxColumn
        '
        Me.INSTALACIONDataGridViewTextBoxColumn.DataPropertyName = "INSTALACION"
        Me.INSTALACIONDataGridViewTextBoxColumn.HeaderText = "INSTALACION"
        Me.INSTALACIONDataGridViewTextBoxColumn.Name = "INSTALACIONDataGridViewTextBoxColumn"
        '
        'INSTALACIONRUSDataGridViewTextBoxColumn
        '
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.DataPropertyName = "INSTALACIONRUS"
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.HeaderText = "INSTALACIONRUS"
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.Name = "INSTALACIONRUSDataGridViewTextBoxColumn"
        '
        'REQUERIDODataGridViewCheckBoxColumn
        '
        Me.REQUERIDODataGridViewCheckBoxColumn.DataPropertyName = "REQUERIDO"
        Me.REQUERIDODataGridViewCheckBoxColumn.HeaderText = "REQUERIDO"
        Me.REQUERIDODataGridViewCheckBoxColumn.Name = "REQUERIDODataGridViewCheckBoxColumn"
        '
        'HABILITADODataGridViewCheckBoxColumn
        '
        Me.HABILITADODataGridViewCheckBoxColumn.DataPropertyName = "HABILITADO"
        Me.HABILITADODataGridViewCheckBoxColumn.HeaderText = "HABILITADO"
        Me.HABILITADODataGridViewCheckBoxColumn.Name = "HABILITADODataGridViewCheckBoxColumn"
        '
        'ATRIBUTODataGridViewTextBoxColumn
        '
        Me.ATRIBUTODataGridViewTextBoxColumn.DataPropertyName = "ATRIBUTO"
        Me.ATRIBUTODataGridViewTextBoxColumn.HeaderText = "ATRIBUTO"
        Me.ATRIBUTODataGridViewTextBoxColumn.Name = "ATRIBUTODataGridViewTextBoxColumn"
        '
        'OC_LISTADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.BTN_QUITAR)
        Me.Controls.Add(Me.BTN_AGREGAR)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "OC_LISTADO"
        Me.Text = "OC_LISTADO"
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents BTN_QUITAR As Button
    Friend WithEvents ORDEN As DataGridViewTextBoxColumn
    Friend WithEvents TRABAJO As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents NODO As DataGridViewTextBoxColumn
    Friend WithEvents ZONA As DataGridViewTextBoxColumn
    Friend WithEvents IdTRABAJODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGESTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOTRABAJODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINGRESADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENERADOXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICIADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAFINALIZADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPOESTIMADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPOREALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEMORADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AREADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICESTIMADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NODODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZONADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MANZANADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NRODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASIGNADOADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECTORASIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDASIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMPLETODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DEPENDENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPODEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTALACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTALACIONRUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQUERIDODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HABILITADODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ATRIBUTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
