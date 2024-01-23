<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVO_INDICE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_BORRAR_EXCEL = New System.Windows.Forms.Button()
        Me.LBL_PASARANOVALIDO = New System.Windows.Forms.Label()
        Me.TXTMOTIVONOVALIDO = New System.Windows.Forms.TextBox()
        Me.BTN_PASARANO = New System.Windows.Forms.Button()
        Me.DGVBASECALCULO = New System.Windows.Forms.DataGridView()
        Me.OrdinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECLAMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FallaOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CumpleIndiceTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaseCalculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORME_INDICEDataSet1 = New REDES.INFORME_INDICEDataSet()
        Me.TXT_ID_INFORME = New System.Windows.Forms.TextBox()
        Me.GB_MARCAR_NOVALIDOS = New System.Windows.Forms.GroupBox()
        Me.TXT_TOTALREG = New System.Windows.Forms.TextBox()
        Me.LBL_GUARDANDOREG = New System.Windows.Forms.Label()
        Me.TXT_TIPOSOL = New System.Windows.Forms.TextBox()
        Me.LBL_TIPOSOL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL_CANCPEND = New System.Windows.Forms.TextBox()
        Me.LBL_SECTOR = New System.Windows.Forms.Label()
        Me.TXT_ORDPEND = New System.Windows.Forms.TextBox()
        Me.LBL_ORDPEND = New System.Windows.Forms.Label()
        Me.TXT_SECTOR = New System.Windows.Forms.TextBox()
        Me.LBL_RECCANCPEND = New System.Windows.Forms.Label()
        Me.TXT_INFORME = New System.Windows.Forms.TextBox()
        Me.LBL_TITULO_INFORME = New System.Windows.Forms.Label()
        Me.BTN_CARGAR_excel = New System.Windows.Forms.Button()
        Me.lbl_selfecha = New System.Windows.Forms.Label()
        Me.lbl_año = New System.Windows.Forms.Label()
        Me.lbl_mes = New System.Windows.Forms.Label()
        Me.CB_ANIO = New System.Windows.Forms.ComboBox()
        Me.CB_FECHA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.LBL_PASASI = New System.Windows.Forms.Label()
        Me.BTN_PASARSI = New System.Windows.Forms.Button()
        Me.BaseIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORME_INDICEDataSet = New REDES.INFORME_INDICEDataSet()
        Me.TablaWEBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaWEBTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.TablaWEBTableAdapter()
        Me.RepoIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.RepoIndicesTableAdapter()
        Me.RepoIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.InformesTableAdapter()
        Me.InfoIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.InfoIndicesTableAdapter()
        Me.BaseCalculoTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.BaseCalculoTableAdapter()
        Me.FALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FALLASTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.FALLASTableAdapter()
        Me.ZonasREDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZonasREDTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.ZonasREDTableAdapter()
        Me.CAUSASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAUSASTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.CAUSASTableAdapter()
        Me.BaseIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.BaseIndicesTableAdapter()
        Me.HistoIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoIndicesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.HistoIndicesTableAdapter()
        Me.OrdinalesTableAdapter = New REDES.INFORME_INDICEDataSetTableAdapters.OrdinalesTableAdapter()
        Me.OrdinalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_CONTINUAR = New System.Windows.Forms.Button()
        Me.BTN_BORRAR_BASECALCULO = New System.Windows.Forms.Button()
        CType(Me.DGVBASECALCULO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseCalculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORME_INDICEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_MARCAR_NOVALIDOS.SuspendLayout()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORME_INDICEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaWEBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasREDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAUSASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdinalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_BORRAR_EXCEL
        '
        Me.BTN_BORRAR_EXCEL.BackColor = System.Drawing.Color.Black
        Me.BTN_BORRAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BORRAR_EXCEL.Location = New System.Drawing.Point(319, 77)
        Me.BTN_BORRAR_EXCEL.Name = "BTN_BORRAR_EXCEL"
        Me.BTN_BORRAR_EXCEL.Size = New System.Drawing.Size(124, 24)
        Me.BTN_BORRAR_EXCEL.TabIndex = 178
        Me.BTN_BORRAR_EXCEL.Text = "BORRAR BD EXCEL"
        Me.BTN_BORRAR_EXCEL.UseVisualStyleBackColor = False
        Me.BTN_BORRAR_EXCEL.Visible = False
        '
        'LBL_PASARANOVALIDO
        '
        Me.LBL_PASARANOVALIDO.AutoSize = True
        Me.LBL_PASARANOVALIDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_PASARANOVALIDO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_PASARANOVALIDO.Location = New System.Drawing.Point(115, 451)
        Me.LBL_PASARANOVALIDO.Name = "LBL_PASARANOVALIDO"
        Me.LBL_PASARANOVALIDO.Size = New System.Drawing.Size(182, 13)
        Me.LBL_PASARANOVALIDO.TabIndex = 176
        Me.LBL_PASARANOVALIDO.Text = "PASAR seleccion a NO VALIDO por:"
        Me.LBL_PASARANOVALIDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_PASARANOVALIDO.Visible = False
        '
        'TXTMOTIVONOVALIDO
        '
        Me.TXTMOTIVONOVALIDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTMOTIVONOVALIDO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTMOTIVONOVALIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOTIVONOVALIDO.ForeColor = System.Drawing.Color.White
        Me.TXTMOTIVONOVALIDO.Location = New System.Drawing.Point(303, 446)
        Me.TXTMOTIVONOVALIDO.Name = "TXTMOTIVONOVALIDO"
        Me.TXTMOTIVONOVALIDO.Size = New System.Drawing.Size(211, 23)
        Me.TXTMOTIVONOVALIDO.TabIndex = 175
        Me.TXTMOTIVONOVALIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTMOTIVONOVALIDO.Visible = False
        '
        'BTN_PASARANO
        '
        Me.BTN_PASARANO.BackColor = System.Drawing.Color.Black
        Me.BTN_PASARANO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PASARANO.Location = New System.Drawing.Point(520, 446)
        Me.BTN_PASARANO.Name = "BTN_PASARANO"
        Me.BTN_PASARANO.Size = New System.Drawing.Size(75, 23)
        Me.BTN_PASARANO.TabIndex = 174
        Me.BTN_PASARANO.Text = "MARCAR"
        Me.BTN_PASARANO.UseVisualStyleBackColor = False
        Me.BTN_PASARANO.Visible = False
        '
        'DGVBASECALCULO
        '
        Me.DGVBASECALCULO.AllowUserToAddRows = False
        Me.DGVBASECALCULO.AllowUserToDeleteRows = False
        Me.DGVBASECALCULO.AllowUserToResizeColumns = False
        Me.DGVBASECALCULO.AllowUserToResizeRows = False
        Me.DGVBASECALCULO.AutoGenerateColumns = False
        Me.DGVBASECALCULO.BackgroundColor = System.Drawing.Color.Black
        Me.DGVBASECALCULO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVBASECALCULO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVBASECALCULO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVBASECALCULO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBASECALCULO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdinalDataGridViewTextBoxColumn, Me.RECLAMO, Me.FallaOrigenDataGridViewTextBoxColumn, Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn, Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn, Me.CumpleIndiceTMDataGridViewTextBoxColumn, Me.NodoDataGridViewTextBoxColumn, Me.ZonaDataGridViewTextBoxColumn})
        Me.DGVBASECALCULO.DataSource = Me.BaseCalculoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVBASECALCULO.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVBASECALCULO.EnableHeadersVisualStyles = False
        Me.DGVBASECALCULO.Location = New System.Drawing.Point(34, 287)
        Me.DGVBASECALCULO.Name = "DGVBASECALCULO"
        Me.DGVBASECALCULO.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVBASECALCULO.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVBASECALCULO.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DGVBASECALCULO.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVBASECALCULO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBASECALCULO.ShowCellErrors = False
        Me.DGVBASECALCULO.ShowCellToolTips = False
        Me.DGVBASECALCULO.ShowEditingIcon = False
        Me.DGVBASECALCULO.ShowRowErrors = False
        Me.DGVBASECALCULO.Size = New System.Drawing.Size(542, 150)
        Me.DGVBASECALCULO.TabIndex = 173
        Me.DGVBASECALCULO.Visible = False
        '
        'OrdinalDataGridViewTextBoxColumn
        '
        Me.OrdinalDataGridViewTextBoxColumn.DataPropertyName = "Ordinal"
        Me.OrdinalDataGridViewTextBoxColumn.HeaderText = "Ordinal"
        Me.OrdinalDataGridViewTextBoxColumn.Name = "OrdinalDataGridViewTextBoxColumn"
        Me.OrdinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdinalDataGridViewTextBoxColumn.Width = 60
        '
        'RECLAMO
        '
        Me.RECLAMO.DataPropertyName = "idReclamo"
        Me.RECLAMO.HeaderText = "RECLAMO"
        Me.RECLAMO.Name = "RECLAMO"
        Me.RECLAMO.ReadOnly = True
        Me.RECLAMO.Width = 70
        '
        'FallaOrigenDataGridViewTextBoxColumn
        '
        Me.FallaOrigenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FallaOrigenDataGridViewTextBoxColumn.DataPropertyName = "FallaOrigen"
        Me.FallaOrigenDataGridViewTextBoxColumn.HeaderText = "FallaOrigen"
        Me.FallaOrigenDataGridViewTextBoxColumn.Name = "FallaOrigenDataGridViewTextBoxColumn"
        Me.FallaOrigenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CumpleIndiceVencOptiDataGridViewTextBoxColumn
        '
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn.DataPropertyName = "CumpleIndiceVencOpti"
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn.HeaderText = "CumTO"
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn.Name = "CumpleIndiceVencOptiDataGridViewTextBoxColumn"
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn.ReadOnly = True
        Me.CumpleIndiceVencOptiDataGridViewTextBoxColumn.Width = 45
        '
        'CumpleIndiceVencAcepDataGridViewTextBoxColumn
        '
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn.DataPropertyName = "CumpleIndiceVencAcep"
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn.HeaderText = "CumTA"
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn.Name = "CumpleIndiceVencAcepDataGridViewTextBoxColumn"
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn.ReadOnly = True
        Me.CumpleIndiceVencAcepDataGridViewTextBoxColumn.Width = 45
        '
        'CumpleIndiceTMDataGridViewTextBoxColumn
        '
        Me.CumpleIndiceTMDataGridViewTextBoxColumn.DataPropertyName = "CumpleIndiceTM"
        Me.CumpleIndiceTMDataGridViewTextBoxColumn.HeaderText = "CumTM"
        Me.CumpleIndiceTMDataGridViewTextBoxColumn.Name = "CumpleIndiceTMDataGridViewTextBoxColumn"
        Me.CumpleIndiceTMDataGridViewTextBoxColumn.ReadOnly = True
        Me.CumpleIndiceTMDataGridViewTextBoxColumn.Width = 45
        '
        'NodoDataGridViewTextBoxColumn
        '
        Me.NodoDataGridViewTextBoxColumn.DataPropertyName = "Nodo"
        Me.NodoDataGridViewTextBoxColumn.HeaderText = "Nodo"
        Me.NodoDataGridViewTextBoxColumn.Name = "NodoDataGridViewTextBoxColumn"
        Me.NodoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NodoDataGridViewTextBoxColumn.Width = 30
        '
        'ZonaDataGridViewTextBoxColumn
        '
        Me.ZonaDataGridViewTextBoxColumn.DataPropertyName = "Zona"
        Me.ZonaDataGridViewTextBoxColumn.HeaderText = "Zona"
        Me.ZonaDataGridViewTextBoxColumn.Name = "ZonaDataGridViewTextBoxColumn"
        Me.ZonaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZonaDataGridViewTextBoxColumn.Width = 30
        '
        'BaseCalculoBindingSource
        '
        Me.BaseCalculoBindingSource.DataMember = "BaseCalculo"
        Me.BaseCalculoBindingSource.DataSource = Me.INFORME_INDICEDataSet1
        '
        'INFORME_INDICEDataSet1
        '
        Me.INFORME_INDICEDataSet1.DataSetName = "INFORME_INDICEDataSet"
        Me.INFORME_INDICEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_ID_INFORME
        '
        Me.TXT_ID_INFORME.BackColor = System.Drawing.Color.Black
        Me.TXT_ID_INFORME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ID_INFORME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID_INFORME.ForeColor = System.Drawing.Color.White
        Me.TXT_ID_INFORME.Location = New System.Drawing.Point(211, 57)
        Me.TXT_ID_INFORME.Name = "TXT_ID_INFORME"
        Me.TXT_ID_INFORME.Size = New System.Drawing.Size(41, 16)
        Me.TXT_ID_INFORME.TabIndex = 172
        Me.TXT_ID_INFORME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ID_INFORME.Visible = False
        '
        'GB_MARCAR_NOVALIDOS
        '
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.TXT_TOTALREG)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.LBL_GUARDANDOREG)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.TXT_TIPOSOL)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.LBL_TIPOSOL)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.Label1)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.TXT_TOTAL_CANCPEND)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.LBL_SECTOR)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.TXT_ORDPEND)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.LBL_ORDPEND)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.TXT_SECTOR)
        Me.GB_MARCAR_NOVALIDOS.Controls.Add(Me.LBL_RECCANCPEND)
        Me.GB_MARCAR_NOVALIDOS.ForeColor = System.Drawing.Color.White
        Me.GB_MARCAR_NOVALIDOS.Location = New System.Drawing.Point(106, 107)
        Me.GB_MARCAR_NOVALIDOS.Name = "GB_MARCAR_NOVALIDOS"
        Me.GB_MARCAR_NOVALIDOS.Size = New System.Drawing.Size(406, 142)
        Me.GB_MARCAR_NOVALIDOS.TabIndex = 171
        Me.GB_MARCAR_NOVALIDOS.TabStop = False
        Me.GB_MARCAR_NOVALIDOS.Text = "PASANDO RECLAMOS A NO VALIDOS"
        Me.GB_MARCAR_NOVALIDOS.Visible = False
        '
        'TXT_TOTALREG
        '
        Me.TXT_TOTALREG.BackColor = System.Drawing.Color.Black
        Me.TXT_TOTALREG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_TOTALREG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTALREG.ForeColor = System.Drawing.Color.White
        Me.TXT_TOTALREG.Location = New System.Drawing.Point(325, 114)
        Me.TXT_TOTALREG.Name = "TXT_TOTALREG"
        Me.TXT_TOTALREG.Size = New System.Drawing.Size(49, 16)
        Me.TXT_TOTALREG.TabIndex = 156
        Me.TXT_TOTALREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_TOTALREG.Visible = False
        '
        'LBL_GUARDANDOREG
        '
        Me.LBL_GUARDANDOREG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_GUARDANDOREG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUARDANDOREG.Location = New System.Drawing.Point(61, 115)
        Me.LBL_GUARDANDOREG.Name = "LBL_GUARDANDOREG"
        Me.LBL_GUARDANDOREG.Size = New System.Drawing.Size(258, 15)
        Me.LBL_GUARDANDOREG.TabIndex = 155
        Me.LBL_GUARDANDOREG.Text = "MODIFICANDO REGISTROS, AGUARDE..."
        Me.LBL_GUARDANDOREG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_GUARDANDOREG.Visible = False
        '
        'TXT_TIPOSOL
        '
        Me.TXT_TIPOSOL.BackColor = System.Drawing.Color.Black
        Me.TXT_TIPOSOL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_TIPOSOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TIPOSOL.ForeColor = System.Drawing.Color.White
        Me.TXT_TIPOSOL.Location = New System.Drawing.Point(325, 88)
        Me.TXT_TIPOSOL.Name = "TXT_TIPOSOL"
        Me.TXT_TIPOSOL.Size = New System.Drawing.Size(49, 16)
        Me.TXT_TIPOSOL.TabIndex = 149
        Me.TXT_TIPOSOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_TIPOSOL.Visible = False
        '
        'LBL_TIPOSOL
        '
        Me.LBL_TIPOSOL.AutoSize = True
        Me.LBL_TIPOSOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_TIPOSOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIPOSOL.Location = New System.Drawing.Point(11, 90)
        Me.LBL_TIPOSOL.Name = "LBL_TIPOSOL"
        Me.LBL_TIPOSOL.Size = New System.Drawing.Size(308, 13)
        Me.LBL_TIPOSOL.TabIndex = 154
        Me.LBL_TIPOSOL.Text = "DOMICILIARIOS, CABECERA Y ANULADOS POR PERMISOR"
        Me.LBL_TIPOSOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_TIPOSOL.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(328, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "TOTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_TOTAL_CANCPEND
        '
        Me.TXT_TOTAL_CANCPEND.BackColor = System.Drawing.Color.Black
        Me.TXT_TOTAL_CANCPEND.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_TOTAL_CANCPEND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTAL_CANCPEND.ForeColor = System.Drawing.Color.White
        Me.TXT_TOTAL_CANCPEND.Location = New System.Drawing.Point(325, 31)
        Me.TXT_TOTAL_CANCPEND.Name = "TXT_TOTAL_CANCPEND"
        Me.TXT_TOTAL_CANCPEND.Size = New System.Drawing.Size(49, 16)
        Me.TXT_TOTAL_CANCPEND.TabIndex = 146
        Me.TXT_TOTAL_CANCPEND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_SECTOR
        '
        Me.LBL_SECTOR.AutoSize = True
        Me.LBL_SECTOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_SECTOR.Location = New System.Drawing.Point(173, 71)
        Me.LBL_SECTOR.Name = "LBL_SECTOR"
        Me.LBL_SECTOR.Size = New System.Drawing.Size(146, 13)
        Me.LBL_SECTOR.TabIndex = 153
        Me.LBL_SECTOR.Text = "SECTOR CABECERA Y OTT"
        Me.LBL_SECTOR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_SECTOR.Visible = False
        '
        'TXT_ORDPEND
        '
        Me.TXT_ORDPEND.BackColor = System.Drawing.Color.Black
        Me.TXT_ORDPEND.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ORDPEND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ORDPEND.ForeColor = System.Drawing.Color.White
        Me.TXT_ORDPEND.Location = New System.Drawing.Point(325, 50)
        Me.TXT_ORDPEND.Name = "TXT_ORDPEND"
        Me.TXT_ORDPEND.Size = New System.Drawing.Size(49, 16)
        Me.TXT_ORDPEND.TabIndex = 147
        Me.TXT_ORDPEND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ORDPEND.Visible = False
        '
        'LBL_ORDPEND
        '
        Me.LBL_ORDPEND.AutoSize = True
        Me.LBL_ORDPEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_ORDPEND.Location = New System.Drawing.Point(85, 52)
        Me.LBL_ORDPEND.Name = "LBL_ORDPEND"
        Me.LBL_ORDPEND.Size = New System.Drawing.Size(234, 13)
        Me.LBL_ORDPEND.TabIndex = 152
        Me.LBL_ORDPEND.Text = "ORDINALES ANULADOS O NO FINALIZADOS"
        Me.LBL_ORDPEND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_ORDPEND.Visible = False
        '
        'TXT_SECTOR
        '
        Me.TXT_SECTOR.BackColor = System.Drawing.Color.Black
        Me.TXT_SECTOR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_SECTOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SECTOR.ForeColor = System.Drawing.Color.White
        Me.TXT_SECTOR.Location = New System.Drawing.Point(325, 69)
        Me.TXT_SECTOR.Name = "TXT_SECTOR"
        Me.TXT_SECTOR.Size = New System.Drawing.Size(49, 16)
        Me.TXT_SECTOR.TabIndex = 148
        Me.TXT_SECTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_SECTOR.Visible = False
        '
        'LBL_RECCANCPEND
        '
        Me.LBL_RECCANCPEND.AutoSize = True
        Me.LBL_RECCANCPEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_RECCANCPEND.Location = New System.Drawing.Point(112, 33)
        Me.LBL_RECCANCPEND.Name = "LBL_RECCANCPEND"
        Me.LBL_RECCANCPEND.Size = New System.Drawing.Size(207, 13)
        Me.LBL_RECCANCPEND.TabIndex = 151
        Me.LBL_RECCANCPEND.Text = "STATUS CANCELADOS Y PENDIENTES"
        Me.LBL_RECCANCPEND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_INFORME
        '
        Me.TXT_INFORME.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_INFORME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_INFORME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_INFORME.ForeColor = System.Drawing.Color.White
        Me.TXT_INFORME.Location = New System.Drawing.Point(258, 57)
        Me.TXT_INFORME.Name = "TXT_INFORME"
        Me.TXT_INFORME.Size = New System.Drawing.Size(254, 16)
        Me.TXT_INFORME.TabIndex = 170
        Me.TXT_INFORME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_INFORME.Visible = False
        '
        'LBL_TITULO_INFORME
        '
        Me.LBL_TITULO_INFORME.AutoSize = True
        Me.LBL_TITULO_INFORME.Location = New System.Drawing.Point(52, 59)
        Me.LBL_TITULO_INFORME.Name = "LBL_TITULO_INFORME"
        Me.LBL_TITULO_INFORME.Size = New System.Drawing.Size(157, 13)
        Me.LBL_TITULO_INFORME.TabIndex = 169
        Me.LBL_TITULO_INFORME.Text = "Ingrese un titulo para el informe:"
        Me.LBL_TITULO_INFORME.Visible = False
        '
        'BTN_CARGAR_excel
        '
        Me.BTN_CARGAR_excel.BackColor = System.Drawing.Color.Black
        Me.BTN_CARGAR_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CARGAR_excel.Location = New System.Drawing.Point(167, 78)
        Me.BTN_CARGAR_excel.Name = "BTN_CARGAR_excel"
        Me.BTN_CARGAR_excel.Size = New System.Drawing.Size(146, 23)
        Me.BTN_CARGAR_excel.TabIndex = 168
        Me.BTN_CARGAR_excel.Text = "CARGAR DB EXCEL"
        Me.BTN_CARGAR_excel.UseVisualStyleBackColor = False
        Me.BTN_CARGAR_excel.Visible = False
        '
        'lbl_selfecha
        '
        Me.lbl_selfecha.AutoSize = True
        Me.lbl_selfecha.Location = New System.Drawing.Point(84, 22)
        Me.lbl_selfecha.Name = "lbl_selfecha"
        Me.lbl_selfecha.Size = New System.Drawing.Size(213, 13)
        Me.lbl_selfecha.TabIndex = 183
        Me.lbl_selfecha.Text = "Seleccione MES y AÑO del informe a crear:"
        '
        'lbl_año
        '
        Me.lbl_año.AutoSize = True
        Me.lbl_año.Location = New System.Drawing.Point(303, 22)
        Me.lbl_año.Name = "lbl_año"
        Me.lbl_año.Size = New System.Drawing.Size(30, 13)
        Me.lbl_año.TabIndex = 182
        Me.lbl_año.Text = "AÑO"
        Me.lbl_año.Visible = False
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Location = New System.Drawing.Point(403, 22)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(30, 13)
        Me.lbl_mes.TabIndex = 179
        Me.lbl_mes.Text = "MES"
        Me.lbl_mes.Visible = False
        '
        'CB_ANIO
        '
        Me.CB_ANIO.BackColor = System.Drawing.Color.Black
        Me.CB_ANIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ANIO.ForeColor = System.Drawing.Color.White
        Me.CB_ANIO.FormattingEnabled = True
        Me.CB_ANIO.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025"})
        Me.CB_ANIO.Location = New System.Drawing.Point(333, 18)
        Me.CB_ANIO.Name = "CB_ANIO"
        Me.CB_ANIO.Size = New System.Drawing.Size(58, 21)
        Me.CB_ANIO.TabIndex = 181
        Me.CB_ANIO.Text = "2022"
        Me.CB_ANIO.Visible = False
        '
        'CB_FECHA
        '
        Me.CB_FECHA.BackColor = System.Drawing.Color.Black
        Me.CB_FECHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FECHA.ForeColor = System.Drawing.Color.White
        Me.CB_FECHA.FormattingEnabled = True
        Me.CB_FECHA.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CB_FECHA.Location = New System.Drawing.Point(433, 18)
        Me.CB_FECHA.MaxDropDownItems = 50
        Me.CB_FECHA.Name = "CB_FECHA"
        Me.CB_FECHA.Size = New System.Drawing.Size(85, 21)
        Me.CB_FECHA.TabIndex = 180
        Me.CB_FECHA.Text = "(Seleccione)"
        Me.CB_FECHA.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(117, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 13)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "NO HAY RECLAMOS POR FUERA DEL INDICE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Black
        Me.BTN_SALIR.BackgroundImage = Global.REDES.My.Resources.Resources.logout_W
        Me.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR.FlatAppearance.BorderSize = 0
        Me.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SALIR.Location = New System.Drawing.Point(579, 11)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(28, 33)
        Me.BTN_SALIR.TabIndex = 268
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'LBL_PASASI
        '
        Me.LBL_PASASI.AutoSize = True
        Me.LBL_PASASI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_PASASI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_PASASI.Location = New System.Drawing.Point(222, 485)
        Me.LBL_PASASI.Name = "LBL_PASASI"
        Me.LBL_PASASI.Size = New System.Drawing.Size(130, 13)
        Me.LBL_PASASI.TabIndex = 271
        Me.LBL_PASASI.Text = "MARCAR COMO VALIDO"
        Me.LBL_PASASI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_PASASI.Visible = False
        '
        'BTN_PASARSI
        '
        Me.BTN_PASARSI.BackColor = System.Drawing.Color.Black
        Me.BTN_PASARSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PASARSI.Location = New System.Drawing.Point(358, 480)
        Me.BTN_PASARSI.Name = "BTN_PASARSI"
        Me.BTN_PASARSI.Size = New System.Drawing.Size(75, 23)
        Me.BTN_PASARSI.TabIndex = 269
        Me.BTN_PASARSI.Text = "MARCAR"
        Me.BTN_PASARSI.UseVisualStyleBackColor = False
        Me.BTN_PASARSI.Visible = False
        '
        'BaseIndicesBindingSource
        '
        Me.BaseIndicesBindingSource.DataMember = "BaseIndices"
        Me.BaseIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'INFORME_INDICEDataSet
        '
        Me.INFORME_INDICEDataSet.DataSetName = "INFORME_INDICEDataSet"
        Me.INFORME_INDICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaWEBBindingSource
        '
        Me.TablaWEBBindingSource.DataMember = "TablaWEB"
        Me.TablaWEBBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'TablaWEBTableAdapter
        '
        Me.TablaWEBTableAdapter.ClearBeforeFill = True
        '
        'RepoIndicesTableAdapter
        '
        Me.RepoIndicesTableAdapter.ClearBeforeFill = True
        '
        'RepoIndicesBindingSource
        '
        Me.RepoIndicesBindingSource.DataMember = "RepoIndices"
        Me.RepoIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'InformesBindingSource
        '
        Me.InformesBindingSource.DataMember = "Informes"
        Me.InformesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'InformesTableAdapter
        '
        Me.InformesTableAdapter.ClearBeforeFill = True
        '
        'InfoIndicesBindingSource
        '
        Me.InfoIndicesBindingSource.DataMember = "InfoIndices"
        Me.InfoIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'InfoIndicesTableAdapter
        '
        Me.InfoIndicesTableAdapter.ClearBeforeFill = True
        '
        'BaseCalculoTableAdapter
        '
        Me.BaseCalculoTableAdapter.ClearBeforeFill = True
        '
        'FALLASBindingSource
        '
        Me.FALLASBindingSource.DataMember = "FALLAS"
        Me.FALLASBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'FALLASTableAdapter
        '
        Me.FALLASTableAdapter.ClearBeforeFill = True
        '
        'ZonasREDBindingSource
        '
        Me.ZonasREDBindingSource.DataMember = "ZonasRED"
        Me.ZonasREDBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'ZonasREDTableAdapter
        '
        Me.ZonasREDTableAdapter.ClearBeforeFill = True
        '
        'CAUSASBindingSource
        '
        Me.CAUSASBindingSource.DataMember = "CAUSAS"
        Me.CAUSASBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'CAUSASTableAdapter
        '
        Me.CAUSASTableAdapter.ClearBeforeFill = True
        '
        'BaseIndicesTableAdapter
        '
        Me.BaseIndicesTableAdapter.ClearBeforeFill = True
        '
        'HistoIndicesBindingSource
        '
        Me.HistoIndicesBindingSource.DataMember = "HistoIndices"
        Me.HistoIndicesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'HistoIndicesTableAdapter
        '
        Me.HistoIndicesTableAdapter.ClearBeforeFill = True
        '
        'OrdinalesTableAdapter
        '
        Me.OrdinalesTableAdapter.ClearBeforeFill = True
        '
        'OrdinalesBindingSource
        '
        Me.OrdinalesBindingSource.DataMember = "Ordinales"
        Me.OrdinalesBindingSource.DataSource = Me.INFORME_INDICEDataSet
        '
        'BTN_CONTINUAR
        '
        Me.BTN_CONTINUAR.BackColor = System.Drawing.Color.Black
        Me.BTN_CONTINUAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CONTINUAR.Location = New System.Drawing.Point(368, 255)
        Me.BTN_CONTINUAR.Name = "BTN_CONTINUAR"
        Me.BTN_CONTINUAR.Size = New System.Drawing.Size(146, 23)
        Me.BTN_CONTINUAR.TabIndex = 272
        Me.BTN_CONTINUAR.Text = "CONTINUAR"
        Me.BTN_CONTINUAR.UseVisualStyleBackColor = False
        Me.BTN_CONTINUAR.Visible = False
        '
        'BTN_BORRAR_BASECALCULO
        '
        Me.BTN_BORRAR_BASECALCULO.BackColor = System.Drawing.Color.Black
        Me.BTN_BORRAR_BASECALCULO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BORRAR_BASECALCULO.Location = New System.Drawing.Point(520, 222)
        Me.BTN_BORRAR_BASECALCULO.Name = "BTN_BORRAR_BASECALCULO"
        Me.BTN_BORRAR_BASECALCULO.Size = New System.Drawing.Size(87, 56)
        Me.BTN_BORRAR_BASECALCULO.TabIndex = 273
        Me.BTN_BORRAR_BASECALCULO.Text = "BORRAR BaseCalculo"
        Me.BTN_BORRAR_BASECALCULO.UseVisualStyleBackColor = False
        Me.BTN_BORRAR_BASECALCULO.Visible = False
        '
        'NUEVO_INDICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(619, 523)
        Me.Controls.Add(Me.BTN_BORRAR_BASECALCULO)
        Me.Controls.Add(Me.BTN_CONTINUAR)
        Me.Controls.Add(Me.LBL_PASASI)
        Me.Controls.Add(Me.BTN_PASARSI)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_selfecha)
        Me.Controls.Add(Me.lbl_año)
        Me.Controls.Add(Me.lbl_mes)
        Me.Controls.Add(Me.CB_ANIO)
        Me.Controls.Add(Me.CB_FECHA)
        Me.Controls.Add(Me.BTN_BORRAR_EXCEL)
        Me.Controls.Add(Me.LBL_PASARANOVALIDO)
        Me.Controls.Add(Me.TXTMOTIVONOVALIDO)
        Me.Controls.Add(Me.BTN_PASARANO)
        Me.Controls.Add(Me.DGVBASECALCULO)
        Me.Controls.Add(Me.TXT_ID_INFORME)
        Me.Controls.Add(Me.GB_MARCAR_NOVALIDOS)
        Me.Controls.Add(Me.TXT_INFORME)
        Me.Controls.Add(Me.LBL_TITULO_INFORME)
        Me.Controls.Add(Me.BTN_CARGAR_excel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NUEVO_INDICE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO_INDICE"
        CType(Me.DGVBASECALCULO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseCalculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORME_INDICEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_MARCAR_NOVALIDOS.ResumeLayout(False)
        Me.GB_MARCAR_NOVALIDOS.PerformLayout()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORME_INDICEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaWEBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasREDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAUSASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdinalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BaseCalculoBindingSource As BindingSource
    Friend WithEvents INFORME_INDICEDataSet1 As INFORME_INDICEDataSet
    Friend WithEvents BaseIndicesBindingSource As BindingSource
    Friend WithEvents INFORME_INDICEDataSet As INFORME_INDICEDataSet
    Friend WithEvents TablaWEBBindingSource As BindingSource
    Friend WithEvents TablaWEBTableAdapter As INFORME_INDICEDataSetTableAdapters.TablaWEBTableAdapter
    Friend WithEvents RepoIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.RepoIndicesTableAdapter
    Friend WithEvents RepoIndicesBindingSource As BindingSource
    Friend WithEvents InformesBindingSource As BindingSource
    Friend WithEvents InformesTableAdapter As INFORME_INDICEDataSetTableAdapters.InformesTableAdapter
    Friend WithEvents InfoIndicesBindingSource As BindingSource
    Friend WithEvents InfoIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.InfoIndicesTableAdapter
    Friend WithEvents BaseCalculoTableAdapter As INFORME_INDICEDataSetTableAdapters.BaseCalculoTableAdapter
    Friend WithEvents FALLASBindingSource As BindingSource
    Friend WithEvents FALLASTableAdapter As INFORME_INDICEDataSetTableAdapters.FALLASTableAdapter
    Friend WithEvents ZonasREDBindingSource As BindingSource
    Friend WithEvents ZonasREDTableAdapter As INFORME_INDICEDataSetTableAdapters.ZonasREDTableAdapter
    Friend WithEvents CAUSASBindingSource As BindingSource
    Friend WithEvents CAUSASTableAdapter As INFORME_INDICEDataSetTableAdapters.CAUSASTableAdapter
    Friend WithEvents BaseIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.BaseIndicesTableAdapter
    Friend WithEvents HistoIndicesBindingSource As BindingSource
    Friend WithEvents HistoIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.HistoIndicesTableAdapter
    Friend WithEvents BTN_BORRAR_EXCEL As Button
    Friend WithEvents LBL_PASARANOVALIDO As Label
    Friend WithEvents TXTMOTIVONOVALIDO As TextBox
    Friend WithEvents BTN_PASARANO As Button
    Friend WithEvents DGVBASECALCULO As DataGridView
    Friend WithEvents TXT_ID_INFORME As TextBox
    Friend WithEvents GB_MARCAR_NOVALIDOS As GroupBox
    Friend WithEvents TXT_TOTALREG As TextBox
    Friend WithEvents LBL_GUARDANDOREG As Label
    Friend WithEvents TXT_TIPOSOL As TextBox
    Friend WithEvents LBL_TIPOSOL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_TOTAL_CANCPEND As TextBox
    Friend WithEvents LBL_SECTOR As Label
    Friend WithEvents TXT_ORDPEND As TextBox
    Friend WithEvents LBL_ORDPEND As Label
    Friend WithEvents TXT_SECTOR As TextBox
    Friend WithEvents LBL_RECCANCPEND As Label
    Friend WithEvents TXT_INFORME As TextBox
    Friend WithEvents LBL_TITULO_INFORME As Label
    Friend WithEvents BTN_CARGAR_excel As Button
    Friend WithEvents lbl_selfecha As Label
    Friend WithEvents lbl_año As Label
    Friend WithEvents lbl_mes As Label
    Friend WithEvents CB_ANIO As ComboBox
    Friend WithEvents CB_FECHA As ComboBox
    Friend WithEvents OrdinalesTableAdapter As INFORME_INDICEDataSetTableAdapters.OrdinalesTableAdapter
    Friend WithEvents OrdinalesBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents OrdinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECLAMO As DataGridViewTextBoxColumn
    Friend WithEvents FallaOrigenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CumpleIndiceVencOptiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CumpleIndiceVencAcepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CumpleIndiceTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LBL_PASASI As Label
    Friend WithEvents BTN_PASARSI As Button
    Friend WithEvents BTN_CONTINUAR As Button
    Friend WithEvents BTN_BORRAR_BASECALCULO As Button
End Class
