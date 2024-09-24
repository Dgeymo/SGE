<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIO
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBAGENDA = New System.Windows.Forms.ComboBox()
        Me.BTN_DESAGENDAR = New System.Windows.Forms.Button()
        Me.BTN_VER_AGENDA = New System.Windows.Forms.Button()
        Me.BTN_REFRESCAR = New System.Windows.Forms.Button()
        Me.BTN_AGENDAR = New System.Windows.Forms.Button()
        Me.BTN_VER_EDIFICIO = New System.Windows.Forms.Button()
        Me.DGV_EDIFICIOS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENDADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOMETIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDIF_VISTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EDIFICIODataSet = New REDES.EDIFICIODataSet()
        Me.TXT_NODO = New System.Windows.Forms.TextBox()
        Me.TXT_NRO = New System.Windows.Forms.TextBox()
        Me.CB_STATUS = New System.Windows.Forms.ComboBox()
        Me.TXT_CALLE = New System.Windows.Forms.TextBox()
        Me.TXT_ZONA = New System.Windows.Forms.TextBox()
        Me.LBL_CANT_ROWS = New System.Windows.Forms.Label()
        Me.AVANCEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VER_DUCTOS_FECHADA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AVANCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_HABILITAR = New System.Windows.Forms.Button()
        Me.CB_INGRESO = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_ACTUALIZAR_MDU = New System.Windows.Forms.Button()
        Me.BTN_REPO = New System.Windows.Forms.Button()
        Me.AVANCETableAdapter = New REDES.EDIFICIODataSetTableAdapters.AVANCETableAdapter()
        Me.TableAdapterManager1 = New REDES.EDIFICIODataSetTableAdapters.TableAdapterManager()
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.STATUSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.STATUSTableAdapter()
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENDATableAdapter = New REDES.EDIFICIODataSetTableAdapters.AGENDATableAdapter()
        Me.EdificioDataSetBackUp = New REDES.EDIFICIODataSet()
        Me.FTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FTTBTableAdapter = New REDES.EDIFICIODataSetTableAdapters.FTTBTableAdapter()
        Me.TURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TURNOSTableAdapter()
        Me.BTN_VER_TODOS = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_EDIFICIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIF_VISTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVANCEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificioDataSetBackUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_VER_TODOS)
        Me.GroupBox1.Controls.Add(Me.CBAGENDA)
        Me.GroupBox1.Controls.Add(Me.BTN_DESAGENDAR)
        Me.GroupBox1.Controls.Add(Me.BTN_VER_AGENDA)
        Me.GroupBox1.Controls.Add(Me.BTN_REFRESCAR)
        Me.GroupBox1.Controls.Add(Me.BTN_AGENDAR)
        Me.GroupBox1.Controls.Add(Me.BTN_VER_EDIFICIO)
        Me.GroupBox1.Controls.Add(Me.DGV_EDIFICIOS)
        Me.GroupBox1.Controls.Add(Me.TXT_NODO)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO)
        Me.GroupBox1.Controls.Add(Me.CB_STATUS)
        Me.GroupBox1.Controls.Add(Me.TXT_CALLE)
        Me.GroupBox1.Controls.Add(Me.TXT_ZONA)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(874, 698)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADMINISTRACION DE EDIFICIOS"
        '
        'CBAGENDA
        '
        Me.CBAGENDA.FormattingEnabled = True
        Me.CBAGENDA.Items.AddRange(New Object() {"AGENDA CABLEADO", "AGENDA CERTIFICADO"})
        Me.CBAGENDA.Location = New System.Drawing.Point(674, 626)
        Me.CBAGENDA.Name = "CBAGENDA"
        Me.CBAGENDA.Size = New System.Drawing.Size(165, 21)
        Me.CBAGENDA.TabIndex = 11
        Me.CBAGENDA.Text = "AGENDA CABLEADO"
        '
        'BTN_DESAGENDAR
        '
        Me.BTN_DESAGENDAR.BackColor = System.Drawing.Color.Gray
        Me.BTN_DESAGENDAR.Enabled = False
        Me.BTN_DESAGENDAR.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_DESAGENDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DESAGENDAR.ForeColor = System.Drawing.Color.White
        Me.BTN_DESAGENDAR.Location = New System.Drawing.Point(460, 625)
        Me.BTN_DESAGENDAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_DESAGENDAR.Name = "BTN_DESAGENDAR"
        Me.BTN_DESAGENDAR.Size = New System.Drawing.Size(93, 31)
        Me.BTN_DESAGENDAR.TabIndex = 10
        Me.BTN_DESAGENDAR.Text = "DESAGENDAR"
        Me.BTN_DESAGENDAR.UseVisualStyleBackColor = False
        '
        'BTN_VER_AGENDA
        '
        Me.BTN_VER_AGENDA.BackColor = System.Drawing.Color.Gray
        Me.BTN_VER_AGENDA.Enabled = False
        Me.BTN_VER_AGENDA.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_VER_AGENDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_AGENDA.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_AGENDA.Location = New System.Drawing.Point(557, 625)
        Me.BTN_VER_AGENDA.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_AGENDA.Name = "BTN_VER_AGENDA"
        Me.BTN_VER_AGENDA.Size = New System.Drawing.Size(112, 31)
        Me.BTN_VER_AGENDA.TabIndex = 9
        Me.BTN_VER_AGENDA.Text = "VER AGENDA"
        Me.BTN_VER_AGENDA.UseVisualStyleBackColor = False
        '
        'BTN_REFRESCAR
        '
        Me.BTN_REFRESCAR.BackColor = System.Drawing.Color.Gray
        Me.BTN_REFRESCAR.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_REFRESCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REFRESCAR.ForeColor = System.Drawing.Color.White
        Me.BTN_REFRESCAR.Location = New System.Drawing.Point(6, 625)
        Me.BTN_REFRESCAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_REFRESCAR.Name = "BTN_REFRESCAR"
        Me.BTN_REFRESCAR.Size = New System.Drawing.Size(112, 31)
        Me.BTN_REFRESCAR.TabIndex = 6
        Me.BTN_REFRESCAR.Text = "REFRESCAR"
        Me.BTN_REFRESCAR.UseVisualStyleBackColor = False
        '
        'BTN_AGENDAR
        '
        Me.BTN_AGENDAR.BackColor = System.Drawing.Color.Gray
        Me.BTN_AGENDAR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_AGENDAR.Enabled = False
        Me.BTN_AGENDAR.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_AGENDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGENDAR.ForeColor = System.Drawing.Color.White
        Me.BTN_AGENDAR.Location = New System.Drawing.Point(2, 673)
        Me.BTN_AGENDAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AGENDAR.Name = "BTN_AGENDAR"
        Me.BTN_AGENDAR.Size = New System.Drawing.Size(870, 23)
        Me.BTN_AGENDAR.TabIndex = 8
        Me.BTN_AGENDAR.Text = "AGENDAR EDIFICIO"
        Me.BTN_AGENDAR.UseVisualStyleBackColor = False
        Me.BTN_AGENDAR.Visible = False
        '
        'BTN_VER_EDIFICIO
        '
        Me.BTN_VER_EDIFICIO.BackColor = System.Drawing.Color.Gray
        Me.BTN_VER_EDIFICIO.Enabled = False
        Me.BTN_VER_EDIFICIO.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_VER_EDIFICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_EDIFICIO.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_EDIFICIO.Location = New System.Drawing.Point(122, 625)
        Me.BTN_VER_EDIFICIO.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_EDIFICIO.Name = "BTN_VER_EDIFICIO"
        Me.BTN_VER_EDIFICIO.Size = New System.Drawing.Size(112, 31)
        Me.BTN_VER_EDIFICIO.TabIndex = 7
        Me.BTN_VER_EDIFICIO.Text = "VER EDIFICIO"
        Me.BTN_VER_EDIFICIO.UseVisualStyleBackColor = False
        '
        'DGV_EDIFICIOS
        '
        Me.DGV_EDIFICIOS.AllowUserToAddRows = False
        Me.DGV_EDIFICIOS.AllowUserToDeleteRows = False
        Me.DGV_EDIFICIOS.AllowUserToOrderColumns = True
        Me.DGV_EDIFICIOS.AllowUserToResizeRows = False
        Me.DGV_EDIFICIOS.AutoGenerateColumns = False
        Me.DGV_EDIFICIOS.BackgroundColor = System.Drawing.Color.White
        Me.DGV_EDIFICIOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_EDIFICIOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_EDIFICIOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EDIFICIOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_EDIFICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EDIFICIOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.AGENDADO, Me.ACOMETIDA})
        Me.DGV_EDIFICIOS.DataSource = Me.EDIF_VISTABindingSource
        Me.DGV_EDIFICIOS.EnableHeadersVisualStyles = False
        Me.DGV_EDIFICIOS.GridColor = System.Drawing.Color.Silver
        Me.DGV_EDIFICIOS.Location = New System.Drawing.Point(6, 41)
        Me.DGV_EDIFICIOS.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV_EDIFICIOS.Name = "DGV_EDIFICIOS"
        Me.DGV_EDIFICIOS.ReadOnly = True
        Me.DGV_EDIFICIOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_EDIFICIOS.RowHeadersVisible = False
        Me.DGV_EDIFICIOS.RowHeadersWidth = 51
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_EDIFICIOS.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_EDIFICIOS.RowTemplate.Height = 24
        Me.DGV_EDIFICIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_EDIFICIOS.ShowCellErrors = False
        Me.DGV_EDIFICIOS.ShowCellToolTips = False
        Me.DGV_EDIFICIOS.ShowEditingIcon = False
        Me.DGV_EDIFICIOS.ShowRowErrors = False
        Me.DGV_EDIFICIOS.Size = New System.Drawing.Size(862, 580)
        Me.DGV_EDIFICIOS.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NODO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NODO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ZONA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CALLE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CALLE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PUERTA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PUERTA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "INGRESO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "INGRESO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'AGENDADO
        '
        Me.AGENDADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AGENDADO.DataPropertyName = "AGENDADO"
        Me.AGENDADO.HeaderText = "AGENDADO"
        Me.AGENDADO.Name = "AGENDADO"
        Me.AGENDADO.ReadOnly = True
        '
        'ACOMETIDA
        '
        Me.ACOMETIDA.DataPropertyName = "ACOMETIDA"
        Me.ACOMETIDA.HeaderText = "ACOM"
        Me.ACOMETIDA.Name = "ACOMETIDA"
        Me.ACOMETIDA.ReadOnly = True
        Me.ACOMETIDA.Width = 45
        '
        'EDIF_VISTABindingSource
        '
        Me.EDIF_VISTABindingSource.DataMember = "EDIF_VISTA"
        Me.EDIF_VISTABindingSource.DataSource = Me.EDIFICIODataSet
        '
        'EDIFICIODataSet
        '
        Me.EDIFICIODataSet.DataSetName = "EDIFICIODataSet"
        Me.EDIFICIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_NODO
        '
        Me.TXT_NODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NODO.Location = New System.Drawing.Point(9, 17)
        Me.TXT_NODO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NODO.Name = "TXT_NODO"
        Me.TXT_NODO.Size = New System.Drawing.Size(37, 20)
        Me.TXT_NODO.TabIndex = 1
        Me.TXT_NODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NRO
        '
        Me.TXT_NRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NRO.Location = New System.Drawing.Point(317, 17)
        Me.TXT_NRO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NRO.Name = "TXT_NRO"
        Me.TXT_NRO.Size = New System.Drawing.Size(62, 20)
        Me.TXT_NRO.TabIndex = 4
        Me.TXT_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_STATUS
        '
        Me.CB_STATUS.FormattingEnabled = True
        Me.CB_STATUS.Items.AddRange(New Object() {"AGENDADO", "FINALIZADO", "FALLA TECNICA", "SIN ABONADOS"})
        Me.CB_STATUS.Location = New System.Drawing.Point(383, 16)
        Me.CB_STATUS.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_STATUS.Name = "CB_STATUS"
        Me.CB_STATUS.Size = New System.Drawing.Size(170, 21)
        Me.CB_STATUS.TabIndex = 0
        Me.CB_STATUS.Text = "SIN FILTRO"
        '
        'TXT_CALLE
        '
        Me.TXT_CALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CALLE.Location = New System.Drawing.Point(90, 17)
        Me.TXT_CALLE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_CALLE.Name = "TXT_CALLE"
        Me.TXT_CALLE.Size = New System.Drawing.Size(223, 20)
        Me.TXT_CALLE.TabIndex = 3
        '
        'TXT_ZONA
        '
        Me.TXT_ZONA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ZONA.Location = New System.Drawing.Point(49, 17)
        Me.TXT_ZONA.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_ZONA.Name = "TXT_ZONA"
        Me.TXT_ZONA.Size = New System.Drawing.Size(37, 20)
        Me.TXT_ZONA.TabIndex = 2
        Me.TXT_ZONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_CANT_ROWS
        '
        Me.LBL_CANT_ROWS.AutoSize = True
        Me.LBL_CANT_ROWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_CANT_ROWS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CANT_ROWS.Location = New System.Drawing.Point(989, 11)
        Me.LBL_CANT_ROWS.Name = "LBL_CANT_ROWS"
        Me.LBL_CANT_ROWS.Size = New System.Drawing.Size(94, 13)
        Me.LBL_CANT_ROWS.TabIndex = 7
        Me.LBL_CANT_ROWS.Text = "MOSTRANDO: "
        '
        'AVANCEDataGridView
        '
        Me.AVANCEDataGridView.AllowUserToAddRows = False
        Me.AVANCEDataGridView.AllowUserToDeleteRows = False
        Me.AVANCEDataGridView.AllowUserToResizeColumns = False
        Me.AVANCEDataGridView.AllowUserToResizeRows = False
        Me.AVANCEDataGridView.AutoGenerateColumns = False
        Me.AVANCEDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AVANCEDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AVANCEDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AVANCEDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AVANCEDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.AVANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AVANCEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn4, Me.VER_DUCTOS_FECHADA, Me.DataGridViewCheckBoxColumn2})
        Me.AVANCEDataGridView.DataSource = Me.AVANCEBindingSource
        Me.AVANCEDataGridView.EnableHeadersVisualStyles = False
        Me.AVANCEDataGridView.GridColor = System.Drawing.Color.Silver
        Me.AVANCEDataGridView.Location = New System.Drawing.Point(983, 69)
        Me.AVANCEDataGridView.Name = "AVANCEDataGridView"
        Me.AVANCEDataGridView.ReadOnly = True
        Me.AVANCEDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.AVANCEDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.AVANCEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AVANCEDataGridView.ShowCellErrors = False
        Me.AVANCEDataGridView.ShowCellToolTips = False
        Me.AVANCEDataGridView.ShowEditingIcon = False
        Me.AVANCEDataGridView.ShowRowErrors = False
        Me.AVANCEDataGridView.Size = New System.Drawing.Size(306, 578)
        Me.AVANCEDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ID_AVANCE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID_AVANCE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NODO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NODO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ZONA"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "VER_AEREOS"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "AEREOS"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        Me.DataGridViewCheckBoxColumn4.Width = 60
        '
        'VER_DUCTOS_FECHADA
        '
        Me.VER_DUCTOS_FECHADA.DataPropertyName = "VER_DUCTOS_FECHADA"
        Me.VER_DUCTOS_FECHADA.HeaderText = "DUCTOS"
        Me.VER_DUCTOS_FECHADA.Name = "VER_DUCTOS_FECHADA"
        Me.VER_DUCTOS_FECHADA.ReadOnly = True
        Me.VER_DUCTOS_FECHADA.Width = 50
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "VER_SUBTERRANEO"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "SUBTER"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 60
        '
        'AVANCEBindingSource
        '
        Me.AVANCEBindingSource.DataMember = "AVANCE"
        Me.AVANCEBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(989, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ZONAS HABILITADAS PARA COORDINAR"
        '
        'BTN_HABILITAR
        '
        Me.BTN_HABILITAR.Location = New System.Drawing.Point(1153, 28)
        Me.BTN_HABILITAR.Name = "BTN_HABILITAR"
        Me.BTN_HABILITAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_HABILITAR.TabIndex = 9
        Me.BTN_HABILITAR.Text = "HABILITAR"
        Me.BTN_HABILITAR.UseVisualStyleBackColor = True
        Me.BTN_HABILITAR.Visible = False
        '
        'CB_INGRESO
        '
        Me.CB_INGRESO.FormattingEnabled = True
        Me.CB_INGRESO.Items.AddRange(New Object() {"AEREO", "DUCTO", "SUBTERRANEO"})
        Me.CB_INGRESO.Location = New System.Drawing.Point(1055, 29)
        Me.CB_INGRESO.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_INGRESO.Name = "CB_INGRESO"
        Me.CB_INGRESO.Size = New System.Drawing.Size(93, 21)
        Me.CB_INGRESO.TabIndex = 11
        Me.CB_INGRESO.Text = "INGRESO"
        Me.CB_INGRESO.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1234, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CARGAR ZONAS"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BTN_ACTUALIZAR_MDU
        '
        Me.BTN_ACTUALIZAR_MDU.BackColor = System.Drawing.Color.Gray
        Me.BTN_ACTUALIZAR_MDU.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_ACTUALIZAR_MDU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACTUALIZAR_MDU.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR_MDU.Location = New System.Drawing.Point(1168, 634)
        Me.BTN_ACTUALIZAR_MDU.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_ACTUALIZAR_MDU.Name = "BTN_ACTUALIZAR_MDU"
        Me.BTN_ACTUALIZAR_MDU.Size = New System.Drawing.Size(180, 22)
        Me.BTN_ACTUALIZAR_MDU.TabIndex = 13
        Me.BTN_ACTUALIZAR_MDU.Text = "ACTUALIZAR EDIFICIO"
        Me.BTN_ACTUALIZAR_MDU.UseVisualStyleBackColor = False
        '
        'BTN_REPO
        '
        Me.BTN_REPO.BackColor = System.Drawing.Color.Gray
        Me.BTN_REPO.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_REPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REPO.ForeColor = System.Drawing.Color.White
        Me.BTN_REPO.Location = New System.Drawing.Point(878, 673)
        Me.BTN_REPO.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_REPO.Name = "BTN_REPO"
        Me.BTN_REPO.Size = New System.Drawing.Size(291, 23)
        Me.BTN_REPO.TabIndex = 14
        Me.BTN_REPO.Text = "REPORTE AGENDA"
        Me.BTN_REPO.UseVisualStyleBackColor = False
        '
        'AVANCETableAdapter
        '
        Me.AVANCETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AGENDATableAdapter = Nothing
        Me.TableAdapterManager1.AVANCETableAdapter = Me.AVANCETableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BITACORATableAdapter = Nothing
        Me.TableAdapterManager1.FTTBTableAdapter = Nothing
        Me.TableAdapterManager1.MDUTableAdapter = Me.MDUTableAdapter
        Me.TableAdapterManager1.STATUSTableAdapter = Me.STATUSTableAdapter
        Me.TableAdapterManager1.TECNICOSTableAdapter = Nothing
        Me.TableAdapterManager1.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.EDIFICIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
        '
        'STATUSTableAdapter
        '
        Me.STATUSTableAdapter.ClearBeforeFill = True
        '
        'MDUBindingSource
        '
        Me.MDUBindingSource.DataMember = "MDU"
        Me.MDUBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'STATUSBindingSource
        '
        Me.STATUSBindingSource.DataMember = "STATUS"
        Me.STATUSBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'AGENDABindingSource
        '
        Me.AGENDABindingSource.DataMember = "AGENDA"
        Me.AGENDABindingSource.DataSource = Me.EDIFICIODataSet
        '
        'AGENDATableAdapter
        '
        Me.AGENDATableAdapter.ClearBeforeFill = True
        '
        'EdificioDataSetBackUp
        '
        Me.EdificioDataSetBackUp.DataSetName = "EDIFICIODataSet"
        Me.EdificioDataSetBackUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FTTBBindingSource
        '
        Me.FTTBBindingSource.DataMember = "FTTB"
        Me.FTTBBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'FTTBTableAdapter
        '
        Me.FTTBTableAdapter.ClearBeforeFill = True
        '
        'TURNOSBindingSource
        '
        Me.TURNOSBindingSource.DataMember = "TURNOS"
        Me.TURNOSBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'TURNOSTableAdapter
        '
        Me.TURNOSTableAdapter.ClearBeforeFill = True
        '
        'BTN_VER_TODOS
        '
        Me.BTN_VER_TODOS.BackColor = System.Drawing.Color.Gray
        Me.BTN_VER_TODOS.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_VER_TODOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_TODOS.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_TODOS.Location = New System.Drawing.Point(280, 626)
        Me.BTN_VER_TODOS.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_TODOS.Name = "BTN_VER_TODOS"
        Me.BTN_VER_TODOS.Size = New System.Drawing.Size(112, 31)
        Me.BTN_VER_TODOS.TabIndex = 12
        Me.BTN_VER_TODOS.Text = "VER TODOS"
        Me.BTN_VER_TODOS.UseVisualStyleBackColor = False
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 698)
        Me.Controls.Add(Me.BTN_REPO)
        Me.Controls.Add(Me.BTN_ACTUALIZAR_MDU)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_INGRESO)
        Me.Controls.Add(Me.BTN_HABILITAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AVANCEDataGridView)
        Me.Controls.Add(Me.LBL_CANT_ROWS)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "INICIO"
        Me.Text = "INICIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_EDIFICIOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDIF_VISTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVANCEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVANCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificioDataSetBackUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_VER_AGENDA As Button
    Friend WithEvents BTN_REFRESCAR As Button
    Friend WithEvents BTN_AGENDAR As Button
    Friend WithEvents BTN_VER_EDIFICIO As Button
    Friend WithEvents DGV_EDIFICIOS As DataGridView
    Friend WithEvents TXT_NODO As TextBox
    Friend WithEvents TXT_NRO As TextBox
    Friend WithEvents CB_STATUS As ComboBox
    Friend WithEvents TXT_CALLE As TextBox
    Friend WithEvents TXT_ZONA As TextBox

    Friend WithEvents TableAdapterManager As OBRAS_MDUDataSetTableAdapters.TableAdapterManager



    Friend WithEvents LBL_CANT_ROWS As Label
    Friend WithEvents BTN_DESAGENDAR As Button
    Friend WithEvents IDEDIFICIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NODODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZONADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUERTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INGRESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MODIFICADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDIFICIODataSet As EDIFICIODataSet
    Friend WithEvents AVANCEBindingSource As BindingSource
    Friend WithEvents AVANCETableAdapter As EDIFICIODataSetTableAdapters.AVANCETableAdapter
    Friend WithEvents TableAdapterManager1 As EDIFICIODataSetTableAdapters.TableAdapterManager
    Friend WithEvents EDIF_VISTABindingSource As BindingSource
    Friend WithEvents MDUTableAdapter As EDIFICIODataSetTableAdapters.MDUTableAdapter
    Friend WithEvents MDUBindingSource As BindingSource
    Friend WithEvents STATUSTableAdapter As EDIFICIODataSetTableAdapters.STATUSTableAdapter
    Friend WithEvents STATUSBindingSource As BindingSource
    Friend WithEvents AGENDABindingSource As BindingSource
    Friend WithEvents AGENDATableAdapter As EDIFICIODataSetTableAdapters.AGENDATableAdapter
    Friend WithEvents AVANCEDataGridView As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_HABILITAR As Button
    Friend WithEvents CB_INGRESO As ComboBox
    Friend WithEvents EdificioDataSetBackUp As EDIFICIODataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents VER_DUCTOS_FECHADA As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents FTTBBindingSource As BindingSource
    Friend WithEvents FTTBTableAdapter As EDIFICIODataSetTableAdapters.FTTBTableAdapter
    Friend WithEvents BTN_ACTUALIZAR_MDU As Button
    Friend WithEvents AGENDADO As DataGridViewTextBoxColumn
    Friend WithEvents ACOMETIDA As DataGridViewTextBoxColumn
    Friend WithEvents BTN_REPO As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TURNOSBindingSource As BindingSource
    Friend WithEvents TURNOSTableAdapter As EDIFICIODataSetTableAdapters.TURNOSTableAdapter
    Friend WithEvents CBAGENDA As ComboBox
    Friend WithEvents BTN_VER_TODOS As Button
End Class
