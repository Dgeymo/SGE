<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INICIO
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_VER_AGENDA_CERTIFICADO = New System.Windows.Forms.Button()
        Me.BTN_VER_TODOS = New System.Windows.Forms.Button()
        Me.BTN_DESAGENDAR = New System.Windows.Forms.Button()
        Me.BTN_VER_AGENDA = New System.Windows.Forms.Button()
        Me.BTN_REFRESCAR = New System.Windows.Forms.Button()
        Me.BTN_VER_EDIFICIO = New System.Windows.Forms.Button()
        Me.BTN_AGENDAR = New System.Windows.Forms.Button()
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdificioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportarMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPorExcelSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelDeRelevamientoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConformeAObraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TorresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDIFICIOSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPorExcelCertEdificioSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTREGABLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSTALACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HABILITADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRONCALESsubStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsignarNAPEdificioSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nodo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNODO = New System.Windows.Forms.ComboBox()
        Me.BTN_IRNODO = New System.Windows.Forms.Button()
        Me.AVANCETableAdapter = New REDES.EDIFICIODataSetTableAdapters.AVANCETableAdapter()
        Me.TableAdapterManager1 = New REDES.EDIFICIODataSetTableAdapters.TableAdapterManager()
        Me.STATUSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.STATUSTableAdapter()
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENDATableAdapter = New REDES.EDIFICIODataSetTableAdapters.AGENDATableAdapter()
        Me.EdificioDataSetBackUp = New REDES.EDIFICIODataSet()
        Me.FTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FTTBTableAdapter = New REDES.EDIFICIODataSetTableAdapters.FTTBTableAdapter()
        Me.TURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TURNOSTableAdapter()
        Me.CERTIFICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CERTIFICACIONESTableAdapter = New REDES.EDIFICIODataSetTableAdapters.CERTIFICACIONESTableAdapter()
        Me.FTTBBindingSourceFIBRA = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIBRADataSet = New REDES.FIBRADataSet()
        Me.TRONCALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRONCALESTableAdapter = New REDES.FIBRADataSetTableAdapters.TRONCALESTableAdapter()
        Me.TableAdapterManager2 = New REDES.FIBRADataSetTableAdapters.TableAdapterManager()
        Me.FTTBTableAdapterFIBRA = New REDES.FIBRADataSetTableAdapters.FTTBTableAdapter()
        Me.OBS_MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OBS_MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.OBS_MDUTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_EDIFICIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIF_VISTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVANCEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificioDataSetBackUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CERTIFICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBBindingSourceFIBRA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIBRADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRONCALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OBS_MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_VER_AGENDA_CERTIFICADO)
        Me.GroupBox1.Controls.Add(Me.BTN_VER_TODOS)
        Me.GroupBox1.Controls.Add(Me.BTN_DESAGENDAR)
        Me.GroupBox1.Controls.Add(Me.BTN_VER_AGENDA)
        Me.GroupBox1.Controls.Add(Me.BTN_REFRESCAR)
        Me.GroupBox1.Controls.Add(Me.BTN_VER_EDIFICIO)
        Me.GroupBox1.Controls.Add(Me.BTN_AGENDAR)
        Me.GroupBox1.Controls.Add(Me.DGV_EDIFICIOS)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO)
        Me.GroupBox1.Controls.Add(Me.CB_STATUS)
        Me.GroupBox1.Controls.Add(Me.TXT_CALLE)
        Me.GroupBox1.Controls.Add(Me.TXT_ZONA)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(874, 677)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADMINISTRACION DE EDIFICIOS"
        '
        'BTN_VER_AGENDA_CERTIFICADO
        '
        Me.BTN_VER_AGENDA_CERTIFICADO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_VER_AGENDA_CERTIFICADO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA_CERTIFICADO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_VER_AGENDA_CERTIFICADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_VER_AGENDA_CERTIFICADO.FlatAppearance.BorderSize = 0
        Me.BTN_VER_AGENDA_CERTIFICADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA_CERTIFICADO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA_CERTIFICADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_AGENDA_CERTIFICADO.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_AGENDA_CERTIFICADO.Location = New System.Drawing.Point(663, 636)
        Me.BTN_VER_AGENDA_CERTIFICADO.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_AGENDA_CERTIFICADO.Name = "BTN_VER_AGENDA_CERTIFICADO"
        Me.BTN_VER_AGENDA_CERTIFICADO.Size = New System.Drawing.Size(113, 41)
        Me.BTN_VER_AGENDA_CERTIFICADO.TabIndex = 13
        Me.BTN_VER_AGENDA_CERTIFICADO.Text = "VER AGENDA CERTIFICADO"
        Me.BTN_VER_AGENDA_CERTIFICADO.UseVisualStyleBackColor = False
        '
        'BTN_VER_TODOS
        '
        Me.BTN_VER_TODOS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_VER_TODOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_TODOS.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_VER_TODOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_VER_TODOS.FlatAppearance.BorderSize = 0
        Me.BTN_VER_TODOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_TODOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_TODOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_TODOS.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_TODOS.Location = New System.Drawing.Point(196, 636)
        Me.BTN_VER_TODOS.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_TODOS.Name = "BTN_VER_TODOS"
        Me.BTN_VER_TODOS.Size = New System.Drawing.Size(97, 31)
        Me.BTN_VER_TODOS.TabIndex = 12
        Me.BTN_VER_TODOS.Text = "VER TODOS"
        Me.BTN_VER_TODOS.UseVisualStyleBackColor = False
        '
        'BTN_DESAGENDAR
        '
        Me.BTN_DESAGENDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_DESAGENDAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_DESAGENDAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_DESAGENDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DESAGENDAR.Enabled = False
        Me.BTN_DESAGENDAR.FlatAppearance.BorderSize = 0
        Me.BTN_DESAGENDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_DESAGENDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_DESAGENDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DESAGENDAR.ForeColor = System.Drawing.Color.White
        Me.BTN_DESAGENDAR.Location = New System.Drawing.Point(383, 636)
        Me.BTN_DESAGENDAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_DESAGENDAR.Name = "BTN_DESAGENDAR"
        Me.BTN_DESAGENDAR.Size = New System.Drawing.Size(93, 31)
        Me.BTN_DESAGENDAR.TabIndex = 10
        Me.BTN_DESAGENDAR.Text = "DESAGENDAR"
        Me.BTN_DESAGENDAR.UseVisualStyleBackColor = False
        '
        'BTN_VER_AGENDA
        '
        Me.BTN_VER_AGENDA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_VER_AGENDA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_VER_AGENDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_VER_AGENDA.FlatAppearance.BorderSize = 0
        Me.BTN_VER_AGENDA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_AGENDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_AGENDA.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_AGENDA.Location = New System.Drawing.Point(540, 636)
        Me.BTN_VER_AGENDA.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_AGENDA.Name = "BTN_VER_AGENDA"
        Me.BTN_VER_AGENDA.Size = New System.Drawing.Size(119, 41)
        Me.BTN_VER_AGENDA.TabIndex = 9
        Me.BTN_VER_AGENDA.Text = "VER AGENDA CABLEADO"
        Me.BTN_VER_AGENDA.UseVisualStyleBackColor = False
        '
        'BTN_REFRESCAR
        '
        Me.BTN_REFRESCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_REFRESCAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REFRESCAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_REFRESCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_REFRESCAR.FlatAppearance.BorderSize = 0
        Me.BTN_REFRESCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_REFRESCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_REFRESCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REFRESCAR.ForeColor = System.Drawing.Color.White
        Me.BTN_REFRESCAR.Location = New System.Drawing.Point(6, 636)
        Me.BTN_REFRESCAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_REFRESCAR.Name = "BTN_REFRESCAR"
        Me.BTN_REFRESCAR.Size = New System.Drawing.Size(92, 31)
        Me.BTN_REFRESCAR.TabIndex = 6
        Me.BTN_REFRESCAR.Text = "REFRESCAR"
        Me.BTN_REFRESCAR.UseVisualStyleBackColor = False
        '
        'BTN_VER_EDIFICIO
        '
        Me.BTN_VER_EDIFICIO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_VER_EDIFICIO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_EDIFICIO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_VER_EDIFICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_VER_EDIFICIO.Enabled = False
        Me.BTN_VER_EDIFICIO.FlatAppearance.BorderSize = 0
        Me.BTN_VER_EDIFICIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_EDIFICIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_EDIFICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_EDIFICIO.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_EDIFICIO.Location = New System.Drawing.Point(102, 636)
        Me.BTN_VER_EDIFICIO.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_VER_EDIFICIO.Name = "BTN_VER_EDIFICIO"
        Me.BTN_VER_EDIFICIO.Size = New System.Drawing.Size(90, 31)
        Me.BTN_VER_EDIFICIO.TabIndex = 7
        Me.BTN_VER_EDIFICIO.Text = "VER EDIFICIO"
        Me.BTN_VER_EDIFICIO.UseVisualStyleBackColor = False
        '
        'BTN_AGENDAR
        '
        Me.BTN_AGENDAR.BackColor = System.Drawing.Color.Gray
        Me.BTN_AGENDAR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_AGENDAR.Enabled = False
        Me.BTN_AGENDAR.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_AGENDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGENDAR.ForeColor = System.Drawing.Color.White
        Me.BTN_AGENDAR.Location = New System.Drawing.Point(2, 652)
        Me.BTN_AGENDAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AGENDAR.Name = "BTN_AGENDAR"
        Me.BTN_AGENDAR.Size = New System.Drawing.Size(870, 23)
        Me.BTN_AGENDAR.TabIndex = 8
        Me.BTN_AGENDAR.Text = "AGENDAR EDIFICIO"
        Me.BTN_AGENDAR.UseVisualStyleBackColor = False
        Me.BTN_AGENDAR.Visible = False
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EDIFICIOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_EDIFICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EDIFICIOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.AGENDADO, Me.ACOMETIDA})
        Me.DGV_EDIFICIOS.DataSource = Me.EDIF_VISTABindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_EDIFICIOS.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_EDIFICIOS.EnableHeadersVisualStyles = False
        Me.DGV_EDIFICIOS.GridColor = System.Drawing.Color.Silver
        Me.DGV_EDIFICIOS.Location = New System.Drawing.Point(6, 41)
        Me.DGV_EDIFICIOS.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV_EDIFICIOS.Name = "DGV_EDIFICIOS"
        Me.DGV_EDIFICIOS.ReadOnly = True
        Me.DGV_EDIFICIOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EDIFICIOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_EDIFICIOS.RowHeadersVisible = False
        Me.DGV_EDIFICIOS.RowHeadersWidth = 51
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV_EDIFICIOS.RowsDefaultCellStyle = DataGridViewCellStyle12
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
        Me.LBL_CANT_ROWS.BackColor = System.Drawing.Color.Silver
        Me.LBL_CANT_ROWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_CANT_ROWS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CANT_ROWS.Location = New System.Drawing.Point(971, 5)
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AVANCEDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.AVANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AVANCEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn4, Me.VER_DUCTOS_FECHADA, Me.DataGridViewCheckBoxColumn2})
        Me.AVANCEDataGridView.DataSource = Me.AVANCEBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AVANCEDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.AVANCEDataGridView.EnableHeadersVisualStyles = False
        Me.AVANCEDataGridView.GridColor = System.Drawing.Color.Silver
        Me.AVANCEDataGridView.Location = New System.Drawing.Point(1042, 65)
        Me.AVANCEDataGridView.Name = "AVANCEDataGridView"
        Me.AVANCEDataGridView.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AVANCEDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.AVANCEDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.AVANCEDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16
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
        Me.Label1.Location = New System.Drawing.Point(1048, 49)
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
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.Silver
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoMenuItem, Me.EdificioMenuItem, Me.CertificacionMenuItem, Me.REPORTEToolStripMenuItem, Me.OperacionesToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1368, 24)
        Me.menuStrip1.TabIndex = 16
        Me.menuStrip1.Text = "menuStrip1"
        '
        'ArchivoMenuItem
        '
        Me.ArchivoMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirSubMenuItem})
        Me.ArchivoMenuItem.Name = "ArchivoMenuItem"
        Me.ArchivoMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoMenuItem.Text = "Archivo"
        '
        'SalirSubMenuItem
        '
        Me.SalirSubMenuItem.Name = "SalirSubMenuItem"
        Me.SalirSubMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirSubMenuItem.Text = "Salir"
        '
        'EdificioMenuItem
        '
        Me.EdificioMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarSubMenuItem, Me.ToolStripSeparator1, Me.ImportarMenuItem, Me.ConformeAObraToolStripMenuItem})
        Me.EdificioMenuItem.Name = "EdificioMenuItem"
        Me.EdificioMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdificioMenuItem.Text = "Edificio"
        '
        'AdministrarSubMenuItem
        '
        Me.AdministrarSubMenuItem.Name = "AdministrarSubMenuItem"
        Me.AdministrarSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdministrarSubMenuItem.Text = "Administrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ImportarMenuItem
        '
        Me.ImportarMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPorExcelSubMenuItem, Me.ExcelDeRelevamientoMenuItem})
        Me.ImportarMenuItem.Name = "ImportarMenuItem"
        Me.ImportarMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImportarMenuItem.Text = "Importar"
        '
        'AgregarPorExcelSubMenuItem
        '
        Me.AgregarPorExcelSubMenuItem.Name = "AgregarPorExcelSubMenuItem"
        Me.AgregarPorExcelSubMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AgregarPorExcelSubMenuItem.Text = "Excel de nodo"
        '
        'ExcelDeRelevamientoMenuItem
        '
        Me.ExcelDeRelevamientoMenuItem.Name = "ExcelDeRelevamientoMenuItem"
        Me.ExcelDeRelevamientoMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ExcelDeRelevamientoMenuItem.Text = "Excel de relevamiento"
        '
        'ConformeAObraToolStripMenuItem
        '
        Me.ConformeAObraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CablesToolStripMenuItem, Me.TorresToolStripMenuItem})
        Me.ConformeAObraToolStripMenuItem.Name = "ConformeAObraToolStripMenuItem"
        Me.ConformeAObraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConformeAObraToolStripMenuItem.Text = "Conforme a obra"
        '
        'CablesToolStripMenuItem
        '
        Me.CablesToolStripMenuItem.Name = "CablesToolStripMenuItem"
        Me.CablesToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CablesToolStripMenuItem.Text = "Cables"
        '
        'TorresToolStripMenuItem
        '
        Me.TorresToolStripMenuItem.Name = "TorresToolStripMenuItem"
        Me.TorresToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.TorresToolStripMenuItem.Text = "Torres"
        '
        'CertificacionMenuItem
        '
        Me.CertificacionMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REDToolStripMenuItem, Me.EDIFICIOSubMenuItem})
        Me.CertificacionMenuItem.Name = "CertificacionMenuItem"
        Me.CertificacionMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CertificacionMenuItem.Text = "Certificacion"
        '
        'REDToolStripMenuItem
        '
        Me.REDToolStripMenuItem.Name = "REDToolStripMenuItem"
        Me.REDToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.REDToolStripMenuItem.Text = "RED"
        '
        'EDIFICIOSubMenuItem
        '
        Me.EDIFICIOSubMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPorExcelCertEdificioSubMenuItem})
        Me.EDIFICIOSubMenuItem.Name = "EDIFICIOSubMenuItem"
        Me.EDIFICIOSubMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EDIFICIOSubMenuItem.Text = "EDIFICIO"
        '
        'AgregarPorExcelCertEdificioSubMenuItem
        '
        Me.AgregarPorExcelCertEdificioSubMenuItem.Name = "AgregarPorExcelCertEdificioSubMenuItem"
        Me.AgregarPorExcelCertEdificioSubMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AgregarPorExcelCertEdificioSubMenuItem.Text = "Importar de Excel"
        '
        'REPORTEToolStripMenuItem
        '
        Me.REPORTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTREGABLEToolStripMenuItem, Me.INSTALACIONESToolStripMenuItem, Me.HABILITADOSToolStripMenuItem, Me.AgendaToolStripMenuItem})
        Me.REPORTEToolStripMenuItem.Name = "REPORTEToolStripMenuItem"
        Me.REPORTEToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.REPORTEToolStripMenuItem.Text = "Reporte"
        '
        'ENTREGABLEToolStripMenuItem
        '
        Me.ENTREGABLEToolStripMenuItem.Name = "ENTREGABLEToolStripMenuItem"
        Me.ENTREGABLEToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ENTREGABLEToolStripMenuItem.Text = "Entregable"
        '
        'INSTALACIONESToolStripMenuItem
        '
        Me.INSTALACIONESToolStripMenuItem.Name = "INSTALACIONESToolStripMenuItem"
        Me.INSTALACIONESToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.INSTALACIONESToolStripMenuItem.Text = "Instalaciones"
        '
        'HABILITADOSToolStripMenuItem
        '
        Me.HABILITADOSToolStripMenuItem.Name = "HABILITADOSToolStripMenuItem"
        Me.HABILITADOSToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HABILITADOSToolStripMenuItem.Text = "Edif Habilitados"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRONCALESsubStripMenuItem, Me.ToolStripSeparator2, Me.AsignarNAPEdificioSubMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'TRONCALESsubStripMenuItem
        '
        Me.TRONCALESsubStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearSubMenuItem, Me.ExportarSubMenuItem})
        Me.TRONCALESsubStripMenuItem.Name = "TRONCALESsubStripMenuItem"
        Me.TRONCALESsubStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.TRONCALESsubStripMenuItem.Text = "Excel TRONCALES"
        '
        'CrearSubMenuItem
        '
        Me.CrearSubMenuItem.Name = "CrearSubMenuItem"
        Me.CrearSubMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.CrearSubMenuItem.Text = "Carga/Mod dsd OZ-relatorios"
        '
        'ExportarSubMenuItem
        '
        Me.ExportarSubMenuItem.Name = "ExportarSubMenuItem"
        Me.ExportarSubMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ExportarSubMenuItem.Text = "Exportar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(257, 6)
        '
        'AsignarNAPEdificioSubMenuItem
        '
        Me.AsignarNAPEdificioSubMenuItem.Name = "AsignarNAPEdificioSubMenuItem"
        Me.AsignarNAPEdificioSubMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.AsignarNAPEdificioSubMenuItem.Text = "Asignar EDIF a NAP en TRONCALES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(879, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nodo"
        '
        'lbl_nodo
        '
        Me.lbl_nodo.AutoSize = True
        Me.lbl_nodo.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nodo.Location = New System.Drawing.Point(868, 65)
        Me.lbl_nodo.Name = "lbl_nodo"
        Me.lbl_nodo.Size = New System.Drawing.Size(80, 85)
        Me.lbl_nodo.TabIndex = 18
        Me.lbl_nodo.Text = "*"
        Me.lbl_nodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(893, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Seleccione:"
        '
        'CBNODO
        '
        Me.CBNODO.FormattingEnabled = True
        Me.CBNODO.Location = New System.Drawing.Point(955, 25)
        Me.CBNODO.Name = "CBNODO"
        Me.CBNODO.Size = New System.Drawing.Size(55, 21)
        Me.CBNODO.TabIndex = 21
        '
        'BTN_IRNODO
        '
        Me.BTN_IRNODO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_IRNODO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_IRNODO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_IRNODO.FlatAppearance.BorderSize = 0
        Me.BTN_IRNODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_IRNODO.ForeColor = System.Drawing.Color.White
        Me.BTN_IRNODO.Location = New System.Drawing.Point(933, 46)
        Me.BTN_IRNODO.Name = "BTN_IRNODO"
        Me.BTN_IRNODO.Size = New System.Drawing.Size(77, 27)
        Me.BTN_IRNODO.TabIndex = 20
        Me.BTN_IRNODO.Text = "IR"
        Me.BTN_IRNODO.UseVisualStyleBackColor = False
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
        Me.TableAdapterManager1.CALLESTableAdapter = Nothing
        Me.TableAdapterManager1.CERTIFICACIONESTableAdapter = Nothing
        Me.TableAdapterManager1.FTTBTableAdapter = Nothing
        Me.TableAdapterManager1.MDUTableAdapter = Nothing
        Me.TableAdapterManager1.OBS_MDUTableAdapter = Nothing
        Me.TableAdapterManager1.STATUSTableAdapter = Me.STATUSTableAdapter
        Me.TableAdapterManager1.TECNICOSTableAdapter = Nothing
        Me.TableAdapterManager1.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.EDIFICIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STATUSTableAdapter
        '
        Me.STATUSTableAdapter.ClearBeforeFill = True
        '
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
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
        'CERTIFICACIONESBindingSource
        '
        Me.CERTIFICACIONESBindingSource.DataMember = "CERTIFICACIONES"
        Me.CERTIFICACIONESBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'CERTIFICACIONESTableAdapter
        '
        Me.CERTIFICACIONESTableAdapter.ClearBeforeFill = True
        '
        'FTTBBindingSourceFIBRA
        '
        Me.FTTBBindingSourceFIBRA.DataMember = "FTTB"
        Me.FTTBBindingSourceFIBRA.DataSource = Me.FIBRADataSet
        '
        'FIBRADataSet
        '
        Me.FIBRADataSet.DataSetName = "FIBRADataSet"
        Me.FIBRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRONCALESBindingSource
        '
        Me.TRONCALESBindingSource.DataMember = "TRONCALES"
        Me.TRONCALESBindingSource.DataSource = Me.FIBRADataSet
        '
        'TRONCALESTableAdapter
        '
        Me.TRONCALESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.ARTICULOTableAdapter = Nothing
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CABLESTableAdapter = Nothing
        Me.TableAdapterManager2.COLORESTableAdapter = Nothing
        Me.TableAdapterManager2.FTTBTableAdapter = Nothing
        Me.TableAdapterManager2.MDUTableAdapter = Nothing
        Me.TableAdapterManager2.TRONCALESTableAdapter = Me.TRONCALESTableAdapter
        Me.TableAdapterManager2.UpdateOrder = REDES.FIBRADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FTTBTableAdapterFIBRA
        '
        Me.FTTBTableAdapterFIBRA.ClearBeforeFill = True
        '
        'OBS_MDUBindingSource
        '
        Me.OBS_MDUBindingSource.DataMember = "OBS_MDU"
        Me.OBS_MDUBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'OBS_MDUTableAdapter
        '
        Me.OBS_MDUTableAdapter.ClearBeforeFill = True
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1368, 701)
        Me.Controls.Add(Me.LBL_CANT_ROWS)
        Me.Controls.Add(Me.CBNODO)
        Me.Controls.Add(Me.BTN_IRNODO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_INGRESO)
        Me.Controls.Add(Me.BTN_HABILITAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AVANCEDataGridView)
        Me.Controls.Add(Me.lbl_nodo)
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
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificioDataSetBackUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CERTIFICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBBindingSourceFIBRA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIBRADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRONCALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OBS_MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_VER_AGENDA As Button
    Friend WithEvents BTN_REFRESCAR As Button
    Friend WithEvents BTN_AGENDAR As Button
    Friend WithEvents BTN_VER_EDIFICIO As Button
    Friend WithEvents DGV_EDIFICIOS As DataGridView
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
    Friend WithEvents AGENDADO As DataGridViewTextBoxColumn
    Friend WithEvents ACOMETIDA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TURNOSBindingSource As BindingSource
    Friend WithEvents TURNOSTableAdapter As EDIFICIODataSetTableAdapters.TURNOSTableAdapter
    Friend WithEvents BTN_VER_TODOS As Button
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents ArchivoMenuItem As ToolStripMenuItem
    Private WithEvents SalirSubMenuItem As ToolStripMenuItem
    Private WithEvents EdificioMenuItem As ToolStripMenuItem
    Private WithEvents AdministrarSubMenuItem As ToolStripMenuItem
    Private WithEvents CertificacionMenuItem As ToolStripMenuItem
    Private WithEvents REDToolStripMenuItem As ToolStripMenuItem
    Private WithEvents EDIFICIOSubMenuItem As ToolStripMenuItem
    Private WithEvents REPORTEToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ENTREGABLEToolStripMenuItem As ToolStripMenuItem
    Private WithEvents INSTALACIONESToolStripMenuItem As ToolStripMenuItem
    Private WithEvents HABILITADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nodo As Label
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_IRNODO As Button
    Friend WithEvents CBNODO As ComboBox
    Friend WithEvents ImportarMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_VER_AGENDA_CERTIFICADO As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AgregarPorExcelCertEdificioSubMenuItem As ToolStripMenuItem
    Friend WithEvents CERTIFICACIONESBindingSource As BindingSource
    Friend WithEvents CERTIFICACIONESTableAdapter As EDIFICIODataSetTableAdapters.CERTIFICACIONESTableAdapter
    Friend WithEvents FIBRADataSet As FIBRADataSet
    Friend WithEvents TRONCALESBindingSource As BindingSource
    Friend WithEvents TRONCALESTableAdapter As FIBRADataSetTableAdapters.TRONCALESTableAdapter
    Friend WithEvents TableAdapterManager2 As FIBRADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConformeAObraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TorresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRONCALESsubStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearSubMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExportarSubMenuItem As ToolStripMenuItem
    Friend WithEvents FTTBBindingSourceFIBRA As BindingSource
    Friend WithEvents FTTBTableAdapterFIBRA As FIBRADataSetTableAdapters.FTTBTableAdapter
    Friend WithEvents AsignarNAPEdificioSubMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPorExcelSubMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelDeRelevamientoMenuItem As ToolStripMenuItem
    Friend WithEvents OBS_MDUBindingSource As BindingSource
    Friend WithEvents OBS_MDUTableAdapter As EDIFICIODataSetTableAdapters.OBS_MDUTableAdapter
End Class
