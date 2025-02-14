<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PROCESOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_PROCESO = New System.Windows.Forms.Button()
        Me.LBL_ESTADO = New System.Windows.Forms.Label()
        Me.LBL_REGISTROS = New System.Windows.Forms.Label()
        Me.LBL_CANT_REGISTROS = New System.Windows.Forms.Label()
        Me.BasePermisoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_slash = New System.Windows.Forms.Label()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.PPROGRESSS = New System.Windows.Forms.Panel()
        Me.LBL_ORD = New System.Windows.Forms.Label()
        Me.LBL_TRAB = New System.Windows.Forms.Label()
        Me.LBL_GEST = New System.Windows.Forms.Label()
        Me.SLASH_ORDENES = New System.Windows.Forms.Label()
        Me.TOTAL_ORDENES = New System.Windows.Forms.Label()
        Me.CANT_ORDENES = New System.Windows.Forms.Label()
        Me.BTN_MATERIALES = New System.Windows.Forms.Button()
        Me.SLASH_TRABAJOS = New System.Windows.Forms.Label()
        Me.TOTAL_TRABAJOS = New System.Windows.Forms.Label()
        Me.CANT_TRABAJOS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PB_ORDENES = New System.Windows.Forms.ProgressBar()
        Me.P_TRABAJO = New System.Windows.Forms.Panel()
        Me.PB_TRABAJOS = New System.Windows.Forms.ProgressBar()
        Me.P_GESTION = New System.Windows.Forms.Panel()
        Me.PB_GESTIONES = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.EdificiosTableAdapter = New REDES.MDUDataSetTableAdapters.EdificiosTableAdapter()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUDataSet = New REDES.MDUDataSet()
        Me.HISTORICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaWEBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TecnicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseCalculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoIndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_BUSCAR_REPETIDOS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_ORDENES = New System.Windows.Forms.DataGridView()
        Me.NROORDENINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROORDINALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGESTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTRABAJODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTOROPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTORDESTINODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHASOLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINGRESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAFINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACIERREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIORIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERADORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITANTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUADRILLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NODODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESQU1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESQU2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFECTCLIENTESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFECTPORCIENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTONOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTOTELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVOORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSARIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVOCIERREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAUSACIERREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTALACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARPETADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREMDUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDPRINCIPALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDAPOYADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDPADREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECLAMOSREDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECLAMOSMDUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECLAMOSTOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPREVISTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TREALIZADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPOTRABAJODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREARORDINALDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COORDINARDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MANZANADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOAGENDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPENDENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPODEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAAGENDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENDEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUPLICADADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUPLICADAADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESTIMADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENDARDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CLASEDEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTORGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTALACIONRUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPREVISTOUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AFECTACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECURSODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESAGENDARDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesDataSet1 = New REDES.ORDENESDataSet()
        Me.BTN_SIGUIENTE = New System.Windows.Forms.Button()
        Me.BTN_BORRAR = New System.Windows.Forms.Button()
        Me.CK_INICIAR_TRABAJOS = New System.Windows.Forms.CheckBox()
        Me.CK_FINALIZA_TRABAJO = New System.Windows.Forms.CheckBox()
        Me.CK_MARCA_DUPLICAR = New System.Windows.Forms.CheckBox()
        Me.CK_INICIA_GESTION = New System.Windows.Forms.CheckBox()
        Me.CK_REQUERIDOS = New System.Windows.Forms.CheckBox()
        Me.CK_LIMPIEZA_MENSAJES = New System.Windows.Forms.CheckBox()
        Me.CK_FINALIZA_GESTION = New System.Windows.Forms.CheckBox()
        Me.BTN_REPORTE_SERVICIOS = New System.Windows.Forms.Button()
        Me.DT_SERVICIO_INICIO = New System.Windows.Forms.DateTimePicker()
        Me.DT_SERVICIO_FIN = New System.Windows.Forms.DateTimePicker()
        Me.LBL_DESDE_SERVICIOS = New System.Windows.Forms.Label()
        Me.LBL_HASTA_SERVICIOS = New System.Windows.Forms.Label()
        Me.CB_TIPO_SERVICIOS = New System.Windows.Forms.ComboBox()
        Me.BTN_EXCEL = New System.Windows.Forms.Button()
        Me.DGVOBRACIVIL = New System.Windows.Forms.DataGridView()
        Me.BTN_OBRA_CIVIL_PENDIENTES = New System.Windows.Forms.Button()
        Me.CK_DISENO_OC = New System.Windows.Forms.CheckBox()
        Me.CK_DISENO_RED = New System.Windows.Forms.CheckBox()
        Me.CK_ACT_PLANOS = New System.Windows.Forms.CheckBox()
        Me.CK_SERVICIOS = New System.Windows.Forms.CheckBox()
        Me.BTN_LISTAR_ORDENES = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_TRABAJAR_ORDENES = New System.Windows.Forms.Button()
        Me.dt_desde_repetidos = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.MENSAJERIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MENSAJERIA_OLDTableAdapter = New REDES.ORDENESDataSetTableAdapters.MENSAJERIA_OLDTableAdapter()
        Me.MENSAJERIATableAdapter = New REDES.ORDENESDataSetTableAdapters.MENSAJERIATableAdapter()
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MENSAJERIA_OLDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HISTORICOTableAdapter = New REDES.ORDENESDataSetTableAdapters.HISTORICOTableAdapter()
        Me.INFORMESERVICIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OBESERVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OBESERVACIONESTableAdapter = New REDES.ORDENESDataSetTableAdapters.OBESERVACIONESTableAdapter()
        Me.TableAdapterManager1 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        CType(Me.BasePermisoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PPROGRESSS.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.P_TRABAJO.SuspendLayout()
        Me.P_GESTION.SuspendLayout()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaWEBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseCalculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ORDENES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOBRACIVIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENSAJERIA_OLDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMESERVICIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OBESERVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_PROCESO
        '
        Me.BTN_PROCESO.BackColor = System.Drawing.Color.Silver
        Me.BTN_PROCESO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_PROCESO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_PROCESO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PROCESO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_PROCESO.Location = New System.Drawing.Point(19, 266)
        Me.BTN_PROCESO.Name = "BTN_PROCESO"
        Me.BTN_PROCESO.Size = New System.Drawing.Size(161, 33)
        Me.BTN_PROCESO.TabIndex = 22
        Me.BTN_PROCESO.Text = "PROCESAR"
        Me.BTN_PROCESO.UseVisualStyleBackColor = False
        '
        'LBL_ESTADO
        '
        Me.LBL_ESTADO.AutoSize = True
        Me.LBL_ESTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ESTADO.ForeColor = System.Drawing.Color.Black
        Me.LBL_ESTADO.Location = New System.Drawing.Point(35, 302)
        Me.LBL_ESTADO.Name = "LBL_ESTADO"
        Me.LBL_ESTADO.Size = New System.Drawing.Size(23, 29)
        Me.LBL_ESTADO.TabIndex = 48
        Me.LBL_ESTADO.Text = "*"
        Me.LBL_ESTADO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_REGISTROS
        '
        Me.LBL_REGISTROS.BackColor = System.Drawing.Color.Transparent
        Me.LBL_REGISTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_REGISTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_REGISTROS.ForeColor = System.Drawing.Color.Black
        Me.LBL_REGISTROS.Location = New System.Drawing.Point(212, 63)
        Me.LBL_REGISTROS.Name = "LBL_REGISTROS"
        Me.LBL_REGISTROS.Size = New System.Drawing.Size(594, 19)
        Me.LBL_REGISTROS.TabIndex = 141
        Me.LBL_REGISTROS.Text = "REGISTROS"
        Me.LBL_REGISTROS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LBL_REGISTROS.Visible = False
        '
        'LBL_CANT_REGISTROS
        '
        Me.LBL_CANT_REGISTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_CANT_REGISTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CANT_REGISTROS.ForeColor = System.Drawing.Color.Black
        Me.LBL_CANT_REGISTROS.Location = New System.Drawing.Point(551, 4)
        Me.LBL_CANT_REGISTROS.Name = "LBL_CANT_REGISTROS"
        Me.LBL_CANT_REGISTROS.Size = New System.Drawing.Size(42, 17)
        Me.LBL_CANT_REGISTROS.TabIndex = 142
        Me.LBL_CANT_REGISTROS.Text = "0"
        Me.LBL_CANT_REGISTROS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBL_CANT_REGISTROS.Visible = False
        '
        'lbl_slash
        '
        Me.lbl_slash.AutoSize = True
        Me.lbl_slash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_slash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_slash.ForeColor = System.Drawing.Color.Black
        Me.lbl_slash.Location = New System.Drawing.Point(593, 6)
        Me.lbl_slash.Name = "lbl_slash"
        Me.lbl_slash.Size = New System.Drawing.Size(13, 13)
        Me.lbl_slash.TabIndex = 269
        Me.lbl_slash.Text = "/"
        Me.lbl_slash.Visible = False
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTAL.ForeColor = System.Drawing.Color.Black
        Me.LBL_TOTAL.Location = New System.Drawing.Point(605, 4)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(42, 17)
        Me.LBL_TOTAL.TabIndex = 268
        Me.LBL_TOTAL.Text = "0"
        Me.LBL_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBL_TOTAL.Visible = False
        '
        'PPROGRESSS
        '
        Me.PPROGRESSS.BackColor = System.Drawing.Color.Gainsboro
        Me.PPROGRESSS.Controls.Add(Me.LBL_ORD)
        Me.PPROGRESSS.Controls.Add(Me.LBL_TRAB)
        Me.PPROGRESSS.Controls.Add(Me.LBL_GEST)
        Me.PPROGRESSS.Controls.Add(Me.SLASH_ORDENES)
        Me.PPROGRESSS.Controls.Add(Me.TOTAL_ORDENES)
        Me.PPROGRESSS.Controls.Add(Me.CANT_ORDENES)
        Me.PPROGRESSS.Controls.Add(Me.BTN_MATERIALES)
        Me.PPROGRESSS.Controls.Add(Me.SLASH_TRABAJOS)
        Me.PPROGRESSS.Controls.Add(Me.TOTAL_TRABAJOS)
        Me.PPROGRESSS.Controls.Add(Me.CANT_TRABAJOS)
        Me.PPROGRESSS.Controls.Add(Me.Panel1)
        Me.PPROGRESSS.Controls.Add(Me.lbl_slash)
        Me.PPROGRESSS.Controls.Add(Me.LBL_TOTAL)
        Me.PPROGRESSS.Controls.Add(Me.LBL_CANT_REGISTROS)
        Me.PPROGRESSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PPROGRESSS.Location = New System.Drawing.Point(0, 0)
        Me.PPROGRESSS.Name = "PPROGRESSS"
        Me.PPROGRESSS.Size = New System.Drawing.Size(1381, 60)
        Me.PPROGRESSS.TabIndex = 171
        '
        'LBL_ORD
        '
        Me.LBL_ORD.AutoSize = True
        Me.LBL_ORD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_ORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ORD.ForeColor = System.Drawing.Color.Black
        Me.LBL_ORD.Location = New System.Drawing.Point(653, 43)
        Me.LBL_ORD.Name = "LBL_ORD"
        Me.LBL_ORD.Size = New System.Drawing.Size(67, 13)
        Me.LBL_ORD.TabIndex = 278
        Me.LBL_ORD.Text = "ORDENES"
        Me.LBL_ORD.Visible = False
        '
        'LBL_TRAB
        '
        Me.LBL_TRAB.AutoSize = True
        Me.LBL_TRAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_TRAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TRAB.ForeColor = System.Drawing.Color.Black
        Me.LBL_TRAB.Location = New System.Drawing.Point(653, 25)
        Me.LBL_TRAB.Name = "LBL_TRAB"
        Me.LBL_TRAB.Size = New System.Drawing.Size(71, 13)
        Me.LBL_TRAB.TabIndex = 277
        Me.LBL_TRAB.Text = "TRABAJOS"
        Me.LBL_TRAB.Visible = False
        '
        'LBL_GEST
        '
        Me.LBL_GEST.AutoSize = True
        Me.LBL_GEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_GEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GEST.ForeColor = System.Drawing.Color.Black
        Me.LBL_GEST.Location = New System.Drawing.Point(653, 6)
        Me.LBL_GEST.Name = "LBL_GEST"
        Me.LBL_GEST.Size = New System.Drawing.Size(78, 13)
        Me.LBL_GEST.TabIndex = 276
        Me.LBL_GEST.Text = "GESTIONES"
        Me.LBL_GEST.Visible = False
        '
        'SLASH_ORDENES
        '
        Me.SLASH_ORDENES.AutoSize = True
        Me.SLASH_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SLASH_ORDENES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLASH_ORDENES.ForeColor = System.Drawing.Color.Black
        Me.SLASH_ORDENES.Location = New System.Drawing.Point(593, 43)
        Me.SLASH_ORDENES.Name = "SLASH_ORDENES"
        Me.SLASH_ORDENES.Size = New System.Drawing.Size(13, 13)
        Me.SLASH_ORDENES.TabIndex = 275
        Me.SLASH_ORDENES.Text = "/"
        Me.SLASH_ORDENES.Visible = False
        '
        'TOTAL_ORDENES
        '
        Me.TOTAL_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TOTAL_ORDENES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_ORDENES.ForeColor = System.Drawing.Color.Black
        Me.TOTAL_ORDENES.Location = New System.Drawing.Point(605, 41)
        Me.TOTAL_ORDENES.Name = "TOTAL_ORDENES"
        Me.TOTAL_ORDENES.Size = New System.Drawing.Size(42, 17)
        Me.TOTAL_ORDENES.TabIndex = 274
        Me.TOTAL_ORDENES.Text = "0"
        Me.TOTAL_ORDENES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TOTAL_ORDENES.Visible = False
        '
        'CANT_ORDENES
        '
        Me.CANT_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CANT_ORDENES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANT_ORDENES.ForeColor = System.Drawing.Color.Black
        Me.CANT_ORDENES.Location = New System.Drawing.Point(551, 41)
        Me.CANT_ORDENES.Name = "CANT_ORDENES"
        Me.CANT_ORDENES.Size = New System.Drawing.Size(42, 17)
        Me.CANT_ORDENES.TabIndex = 273
        Me.CANT_ORDENES.Text = "0"
        Me.CANT_ORDENES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CANT_ORDENES.Visible = False
        '
        'BTN_MATERIALES
        '
        Me.BTN_MATERIALES.BackColor = System.Drawing.Color.Silver
        Me.BTN_MATERIALES.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_MATERIALES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_MATERIALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MATERIALES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_MATERIALES.Location = New System.Drawing.Point(1187, 12)
        Me.BTN_MATERIALES.Name = "BTN_MATERIALES"
        Me.BTN_MATERIALES.Size = New System.Drawing.Size(161, 33)
        Me.BTN_MATERIALES.TabIndex = 270
        Me.BTN_MATERIALES.Text = "MATERIALES"
        Me.BTN_MATERIALES.UseVisualStyleBackColor = False
        '
        'SLASH_TRABAJOS
        '
        Me.SLASH_TRABAJOS.AutoSize = True
        Me.SLASH_TRABAJOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SLASH_TRABAJOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLASH_TRABAJOS.ForeColor = System.Drawing.Color.Black
        Me.SLASH_TRABAJOS.Location = New System.Drawing.Point(593, 25)
        Me.SLASH_TRABAJOS.Name = "SLASH_TRABAJOS"
        Me.SLASH_TRABAJOS.Size = New System.Drawing.Size(13, 13)
        Me.SLASH_TRABAJOS.TabIndex = 272
        Me.SLASH_TRABAJOS.Text = "/"
        Me.SLASH_TRABAJOS.Visible = False
        '
        'TOTAL_TRABAJOS
        '
        Me.TOTAL_TRABAJOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TOTAL_TRABAJOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_TRABAJOS.ForeColor = System.Drawing.Color.Black
        Me.TOTAL_TRABAJOS.Location = New System.Drawing.Point(605, 23)
        Me.TOTAL_TRABAJOS.Name = "TOTAL_TRABAJOS"
        Me.TOTAL_TRABAJOS.Size = New System.Drawing.Size(42, 17)
        Me.TOTAL_TRABAJOS.TabIndex = 271
        Me.TOTAL_TRABAJOS.Text = "0"
        Me.TOTAL_TRABAJOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TOTAL_TRABAJOS.Visible = False
        '
        'CANT_TRABAJOS
        '
        Me.CANT_TRABAJOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CANT_TRABAJOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANT_TRABAJOS.ForeColor = System.Drawing.Color.Black
        Me.CANT_TRABAJOS.Location = New System.Drawing.Point(551, 23)
        Me.CANT_TRABAJOS.Name = "CANT_TRABAJOS"
        Me.CANT_TRABAJOS.Size = New System.Drawing.Size(42, 17)
        Me.CANT_TRABAJOS.TabIndex = 270
        Me.CANT_TRABAJOS.Text = "0"
        Me.CANT_TRABAJOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CANT_TRABAJOS.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.P_TRABAJO)
        Me.Panel1.Controls.Add(Me.P_GESTION)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 60)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PB_ORDENES)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 20)
        Me.Panel2.TabIndex = 2
        '
        'PB_ORDENES
        '
        Me.PB_ORDENES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_ORDENES.Location = New System.Drawing.Point(0, 0)
        Me.PB_ORDENES.Name = "PB_ORDENES"
        Me.PB_ORDENES.Size = New System.Drawing.Size(547, 20)
        Me.PB_ORDENES.TabIndex = 273
        '
        'P_TRABAJO
        '
        Me.P_TRABAJO.Controls.Add(Me.PB_TRABAJOS)
        Me.P_TRABAJO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_TRABAJO.Location = New System.Drawing.Point(0, 20)
        Me.P_TRABAJO.Name = "P_TRABAJO"
        Me.P_TRABAJO.Size = New System.Drawing.Size(547, 40)
        Me.P_TRABAJO.TabIndex = 1
        '
        'PB_TRABAJOS
        '
        Me.PB_TRABAJOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_TRABAJOS.Location = New System.Drawing.Point(0, 0)
        Me.PB_TRABAJOS.Name = "PB_TRABAJOS"
        Me.PB_TRABAJOS.Size = New System.Drawing.Size(547, 40)
        Me.PB_TRABAJOS.TabIndex = 272
        '
        'P_GESTION
        '
        Me.P_GESTION.Controls.Add(Me.PB_GESTIONES)
        Me.P_GESTION.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_GESTION.Location = New System.Drawing.Point(0, 0)
        Me.P_GESTION.Name = "P_GESTION"
        Me.P_GESTION.Size = New System.Drawing.Size(547, 20)
        Me.P_GESTION.TabIndex = 0
        '
        'PB_GESTIONES
        '
        Me.PB_GESTIONES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_GESTIONES.Location = New System.Drawing.Point(0, 0)
        Me.PB_GESTIONES.Name = "PB_GESTIONES"
        Me.PB_GESTIONES.Size = New System.Drawing.Size(547, 20)
        Me.PB_GESTIONES.TabIndex = 271
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.MDUDataSet
        '
        'MDUDataSet
        '
        Me.MDUDataSet.DataSetName = "MDUDataSet"
        Me.MDUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_BUSCAR_REPETIDOS
        '
        Me.BTN_BUSCAR_REPETIDOS.BackColor = System.Drawing.Color.Black
        Me.BTN_BUSCAR_REPETIDOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BUSCAR_REPETIDOS.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_BUSCAR_REPETIDOS.Location = New System.Drawing.Point(1072, 528)
        Me.BTN_BUSCAR_REPETIDOS.Name = "BTN_BUSCAR_REPETIDOS"
        Me.BTN_BUSCAR_REPETIDOS.Size = New System.Drawing.Size(93, 32)
        Me.BTN_BUSCAR_REPETIDOS.TabIndex = 220
        Me.BTN_BUSCAR_REPETIDOS.Text = "BUSCAR"
        Me.BTN_BUSCAR_REPETIDOS.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(630, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 25)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "ordenes con ordinales repetidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'DGV_ORDENES
        '
        Me.DGV_ORDENES.AutoGenerateColumns = False
        Me.DGV_ORDENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ORDENES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROORDENINTDataGridViewTextBoxColumn, Me.NROORDINALDataGridViewTextBoxColumn, Me.IDGESTIONDataGridViewTextBoxColumn, Me.IDTRABAJODataGridViewTextBoxColumn, Me.TIPODataGridViewTextBoxColumn, Me.SECTOROPEDataGridViewTextBoxColumn, Me.SECTORDESTINODataGridViewTextBoxColumn, Me.FECHASOLDataGridViewTextBoxColumn, Me.FECHAINGRESODataGridViewTextBoxColumn, Me.FECHAINICIODataGridViewTextBoxColumn, Me.FECHAFINDataGridViewTextBoxColumn, Me.FECHACIERREDataGridViewTextBoxColumn, Me.PRIORIDADDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.GENERADORDataGridViewTextBoxColumn, Me.SOLICITANTEDataGridViewTextBoxColumn, Me.CUADRILLADataGridViewTextBoxColumn, Me.NODODataGridViewTextBoxColumn, Me.ZONADataGridViewTextBoxColumn, Me.CALLEDataGridViewTextBoxColumn, Me.NRODataGridViewTextBoxColumn, Me.ESQU1DataGridViewTextBoxColumn, Me.ESQU2DataGridViewTextBoxColumn, Me.AFECTCLIENTESDataGridViewTextBoxColumn, Me.AFECTPORCIENTODataGridViewTextBoxColumn, Me.CONTACTONOMBREDataGridViewTextBoxColumn, Me.CONTACTOTELDataGridViewTextBoxColumn, Me.MOTIVOORIGENDataGridViewTextBoxColumn, Me.CAUSARIGENDataGridViewTextBoxColumn, Me.MOTIVOCIERREDataGridViewTextBoxColumn, Me.ACTIVIDADDataGridViewTextBoxColumn, Me.CAUSACIERREDataGridViewTextBoxColumn, Me.INSTALACIONDataGridViewTextBoxColumn, Me.CARPETADataGridViewTextBoxColumn, Me.NOMBREMDUDataGridViewTextBoxColumn, Me.ORDPRINCIPALDataGridViewTextBoxColumn, Me.ORDAPOYADODataGridViewTextBoxColumn, Me.ORDPADREDataGridViewTextBoxColumn, Me.RECLAMOSREDDataGridViewTextBoxColumn, Me.RECLAMOSMDUDataGridViewTextBoxColumn, Me.RECLAMOSTOTDataGridViewTextBoxColumn, Me.TPREVISTODataGridViewTextBoxColumn, Me.TREALIZADODataGridViewTextBoxColumn, Me.TIEMPOTRABAJODataGridViewTextBoxColumn, Me.CREARORDINALDataGridViewCheckBoxColumn, Me.COORDINARDataGridViewCheckBoxColumn, Me.MANZANADataGridViewTextBoxColumn, Me.TURNOAGENDDataGridViewTextBoxColumn, Me.DEPENDENCIADataGridViewTextBoxColumn, Me.TIPODEPDataGridViewTextBoxColumn, Me.FECHAAGENDDataGridViewTextBoxColumn, Me.ORDENDEPDataGridViewTextBoxColumn, Me.DUPLICADADEDataGridViewTextBoxColumn, Me.DUPLICADAADataGridViewTextBoxColumn, Me.FECHAINICESTIMADODataGridViewTextBoxColumn, Me.TESTIMADODataGridViewTextBoxColumn, Me.AGENDARDataGridViewCheckBoxColumn, Me.CLASEDEPDataGridViewTextBoxColumn, Me.ORDORIGENDataGridViewTextBoxColumn, Me.SECTORGENDataGridViewTextBoxColumn, Me.INSTALACIONRUSDataGridViewTextBoxColumn, Me.TPREVISTOUTDataGridViewTextBoxColumn, Me.AFECTACIONDataGridViewTextBoxColumn, Me.RECURSODataGridViewTextBoxColumn, Me.IDCALLEDataGridViewTextBoxColumn, Me.DESAGENDARDataGridViewCheckBoxColumn})
        Me.DGV_ORDENES.DataSource = Me.BindingSource1
        Me.DGV_ORDENES.Location = New System.Drawing.Point(12, 566)
        Me.DGV_ORDENES.MultiSelect = False
        Me.DGV_ORDENES.Name = "DGV_ORDENES"
        Me.DGV_ORDENES.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_ORDENES.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ORDENES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ORDENES.ShowCellErrors = False
        Me.DGV_ORDENES.ShowCellToolTips = False
        Me.DGV_ORDENES.ShowEditingIcon = False
        Me.DGV_ORDENES.ShowRowErrors = False
        Me.DGV_ORDENES.Size = New System.Drawing.Size(1349, 101)
        Me.DGV_ORDENES.TabIndex = 222
        '
        'NROORDENINTDataGridViewTextBoxColumn
        '
        Me.NROORDENINTDataGridViewTextBoxColumn.DataPropertyName = "NRO_ORDENINT"
        Me.NROORDENINTDataGridViewTextBoxColumn.HeaderText = "NRO_ORDENINT"
        Me.NROORDENINTDataGridViewTextBoxColumn.Name = "NROORDENINTDataGridViewTextBoxColumn"
        '
        'NROORDINALDataGridViewTextBoxColumn
        '
        Me.NROORDINALDataGridViewTextBoxColumn.DataPropertyName = "NRO_ORDINAL"
        Me.NROORDINALDataGridViewTextBoxColumn.HeaderText = "NRO_ORDINAL"
        Me.NROORDINALDataGridViewTextBoxColumn.Name = "NROORDINALDataGridViewTextBoxColumn"
        '
        'IDGESTIONDataGridViewTextBoxColumn
        '
        Me.IDGESTIONDataGridViewTextBoxColumn.DataPropertyName = "ID_GESTION"
        Me.IDGESTIONDataGridViewTextBoxColumn.HeaderText = "ID_GESTION"
        Me.IDGESTIONDataGridViewTextBoxColumn.Name = "IDGESTIONDataGridViewTextBoxColumn"
        '
        'IDTRABAJODataGridViewTextBoxColumn
        '
        Me.IDTRABAJODataGridViewTextBoxColumn.DataPropertyName = "ID_TRABAJO"
        Me.IDTRABAJODataGridViewTextBoxColumn.HeaderText = "ID_TRABAJO"
        Me.IDTRABAJODataGridViewTextBoxColumn.Name = "IDTRABAJODataGridViewTextBoxColumn"
        '
        'TIPODataGridViewTextBoxColumn
        '
        Me.TIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.Name = "TIPODataGridViewTextBoxColumn"
        '
        'SECTOROPEDataGridViewTextBoxColumn
        '
        Me.SECTOROPEDataGridViewTextBoxColumn.DataPropertyName = "SECTOROPE"
        Me.SECTOROPEDataGridViewTextBoxColumn.HeaderText = "SECTOROPE"
        Me.SECTOROPEDataGridViewTextBoxColumn.Name = "SECTOROPEDataGridViewTextBoxColumn"
        '
        'SECTORDESTINODataGridViewTextBoxColumn
        '
        Me.SECTORDESTINODataGridViewTextBoxColumn.DataPropertyName = "SECTORDESTINO"
        Me.SECTORDESTINODataGridViewTextBoxColumn.HeaderText = "SECTORDESTINO"
        Me.SECTORDESTINODataGridViewTextBoxColumn.Name = "SECTORDESTINODataGridViewTextBoxColumn"
        '
        'FECHASOLDataGridViewTextBoxColumn
        '
        Me.FECHASOLDataGridViewTextBoxColumn.DataPropertyName = "FECHASOL"
        Me.FECHASOLDataGridViewTextBoxColumn.HeaderText = "FECHASOL"
        Me.FECHASOLDataGridViewTextBoxColumn.Name = "FECHASOLDataGridViewTextBoxColumn"
        '
        'FECHAINGRESODataGridViewTextBoxColumn
        '
        Me.FECHAINGRESODataGridViewTextBoxColumn.DataPropertyName = "FECHAINGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.HeaderText = "FECHAINGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.Name = "FECHAINGRESODataGridViewTextBoxColumn"
        '
        'FECHAINICIODataGridViewTextBoxColumn
        '
        Me.FECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHAINICIO"
        Me.FECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHAINICIO"
        Me.FECHAINICIODataGridViewTextBoxColumn.Name = "FECHAINICIODataGridViewTextBoxColumn"
        '
        'FECHAFINDataGridViewTextBoxColumn
        '
        Me.FECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN"
        Me.FECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHAFIN"
        Me.FECHAFINDataGridViewTextBoxColumn.Name = "FECHAFINDataGridViewTextBoxColumn"
        '
        'FECHACIERREDataGridViewTextBoxColumn
        '
        Me.FECHACIERREDataGridViewTextBoxColumn.DataPropertyName = "FECHACIERRE"
        Me.FECHACIERREDataGridViewTextBoxColumn.HeaderText = "FECHACIERRE"
        Me.FECHACIERREDataGridViewTextBoxColumn.Name = "FECHACIERREDataGridViewTextBoxColumn"
        '
        'PRIORIDADDataGridViewTextBoxColumn
        '
        Me.PRIORIDADDataGridViewTextBoxColumn.DataPropertyName = "PRIORIDAD"
        Me.PRIORIDADDataGridViewTextBoxColumn.HeaderText = "PRIORIDAD"
        Me.PRIORIDADDataGridViewTextBoxColumn.Name = "PRIORIDADDataGridViewTextBoxColumn"
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        '
        'GENERADORDataGridViewTextBoxColumn
        '
        Me.GENERADORDataGridViewTextBoxColumn.DataPropertyName = "GENERADOR"
        Me.GENERADORDataGridViewTextBoxColumn.HeaderText = "GENERADOR"
        Me.GENERADORDataGridViewTextBoxColumn.Name = "GENERADORDataGridViewTextBoxColumn"
        '
        'SOLICITANTEDataGridViewTextBoxColumn
        '
        Me.SOLICITANTEDataGridViewTextBoxColumn.DataPropertyName = "SOLICITANTE"
        Me.SOLICITANTEDataGridViewTextBoxColumn.HeaderText = "SOLICITANTE"
        Me.SOLICITANTEDataGridViewTextBoxColumn.Name = "SOLICITANTEDataGridViewTextBoxColumn"
        '
        'CUADRILLADataGridViewTextBoxColumn
        '
        Me.CUADRILLADataGridViewTextBoxColumn.DataPropertyName = "CUADRILLA"
        Me.CUADRILLADataGridViewTextBoxColumn.HeaderText = "CUADRILLA"
        Me.CUADRILLADataGridViewTextBoxColumn.Name = "CUADRILLADataGridViewTextBoxColumn"
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
        'ESQU1DataGridViewTextBoxColumn
        '
        Me.ESQU1DataGridViewTextBoxColumn.DataPropertyName = "ESQU1"
        Me.ESQU1DataGridViewTextBoxColumn.HeaderText = "ESQU1"
        Me.ESQU1DataGridViewTextBoxColumn.Name = "ESQU1DataGridViewTextBoxColumn"
        '
        'ESQU2DataGridViewTextBoxColumn
        '
        Me.ESQU2DataGridViewTextBoxColumn.DataPropertyName = "ESQU2"
        Me.ESQU2DataGridViewTextBoxColumn.HeaderText = "ESQU2"
        Me.ESQU2DataGridViewTextBoxColumn.Name = "ESQU2DataGridViewTextBoxColumn"
        '
        'AFECTCLIENTESDataGridViewTextBoxColumn
        '
        Me.AFECTCLIENTESDataGridViewTextBoxColumn.DataPropertyName = "AFECTCLIENTES"
        Me.AFECTCLIENTESDataGridViewTextBoxColumn.HeaderText = "AFECTCLIENTES"
        Me.AFECTCLIENTESDataGridViewTextBoxColumn.Name = "AFECTCLIENTESDataGridViewTextBoxColumn"
        '
        'AFECTPORCIENTODataGridViewTextBoxColumn
        '
        Me.AFECTPORCIENTODataGridViewTextBoxColumn.DataPropertyName = "AFECTPORCIENTO"
        Me.AFECTPORCIENTODataGridViewTextBoxColumn.HeaderText = "AFECTPORCIENTO"
        Me.AFECTPORCIENTODataGridViewTextBoxColumn.Name = "AFECTPORCIENTODataGridViewTextBoxColumn"
        '
        'CONTACTONOMBREDataGridViewTextBoxColumn
        '
        Me.CONTACTONOMBREDataGridViewTextBoxColumn.DataPropertyName = "CONTACTONOMBRE"
        Me.CONTACTONOMBREDataGridViewTextBoxColumn.HeaderText = "CONTACTONOMBRE"
        Me.CONTACTONOMBREDataGridViewTextBoxColumn.Name = "CONTACTONOMBREDataGridViewTextBoxColumn"
        '
        'CONTACTOTELDataGridViewTextBoxColumn
        '
        Me.CONTACTOTELDataGridViewTextBoxColumn.DataPropertyName = "CONTACTOTEL"
        Me.CONTACTOTELDataGridViewTextBoxColumn.HeaderText = "CONTACTOTEL"
        Me.CONTACTOTELDataGridViewTextBoxColumn.Name = "CONTACTOTELDataGridViewTextBoxColumn"
        '
        'MOTIVOORIGENDataGridViewTextBoxColumn
        '
        Me.MOTIVOORIGENDataGridViewTextBoxColumn.DataPropertyName = "MOTIVOORIGEN"
        Me.MOTIVOORIGENDataGridViewTextBoxColumn.HeaderText = "MOTIVOORIGEN"
        Me.MOTIVOORIGENDataGridViewTextBoxColumn.Name = "MOTIVOORIGENDataGridViewTextBoxColumn"
        '
        'CAUSARIGENDataGridViewTextBoxColumn
        '
        Me.CAUSARIGENDataGridViewTextBoxColumn.DataPropertyName = "CAUSARIGEN"
        Me.CAUSARIGENDataGridViewTextBoxColumn.HeaderText = "CAUSARIGEN"
        Me.CAUSARIGENDataGridViewTextBoxColumn.Name = "CAUSARIGENDataGridViewTextBoxColumn"
        '
        'MOTIVOCIERREDataGridViewTextBoxColumn
        '
        Me.MOTIVOCIERREDataGridViewTextBoxColumn.DataPropertyName = "MOTIVOCIERRE"
        Me.MOTIVOCIERREDataGridViewTextBoxColumn.HeaderText = "MOTIVOCIERRE"
        Me.MOTIVOCIERREDataGridViewTextBoxColumn.Name = "MOTIVOCIERREDataGridViewTextBoxColumn"
        '
        'ACTIVIDADDataGridViewTextBoxColumn
        '
        Me.ACTIVIDADDataGridViewTextBoxColumn.DataPropertyName = "ACTIVIDAD"
        Me.ACTIVIDADDataGridViewTextBoxColumn.HeaderText = "ACTIVIDAD"
        Me.ACTIVIDADDataGridViewTextBoxColumn.Name = "ACTIVIDADDataGridViewTextBoxColumn"
        '
        'CAUSACIERREDataGridViewTextBoxColumn
        '
        Me.CAUSACIERREDataGridViewTextBoxColumn.DataPropertyName = "CAUSACIERRE"
        Me.CAUSACIERREDataGridViewTextBoxColumn.HeaderText = "CAUSACIERRE"
        Me.CAUSACIERREDataGridViewTextBoxColumn.Name = "CAUSACIERREDataGridViewTextBoxColumn"
        '
        'INSTALACIONDataGridViewTextBoxColumn
        '
        Me.INSTALACIONDataGridViewTextBoxColumn.DataPropertyName = "INSTALACION"
        Me.INSTALACIONDataGridViewTextBoxColumn.HeaderText = "INSTALACION"
        Me.INSTALACIONDataGridViewTextBoxColumn.Name = "INSTALACIONDataGridViewTextBoxColumn"
        '
        'CARPETADataGridViewTextBoxColumn
        '
        Me.CARPETADataGridViewTextBoxColumn.DataPropertyName = "CARPETA"
        Me.CARPETADataGridViewTextBoxColumn.HeaderText = "CARPETA"
        Me.CARPETADataGridViewTextBoxColumn.Name = "CARPETADataGridViewTextBoxColumn"
        '
        'NOMBREMDUDataGridViewTextBoxColumn
        '
        Me.NOMBREMDUDataGridViewTextBoxColumn.DataPropertyName = "NOMBREMDU"
        Me.NOMBREMDUDataGridViewTextBoxColumn.HeaderText = "NOMBREMDU"
        Me.NOMBREMDUDataGridViewTextBoxColumn.Name = "NOMBREMDUDataGridViewTextBoxColumn"
        '
        'ORDPRINCIPALDataGridViewTextBoxColumn
        '
        Me.ORDPRINCIPALDataGridViewTextBoxColumn.DataPropertyName = "ORDPRINCIPAL"
        Me.ORDPRINCIPALDataGridViewTextBoxColumn.HeaderText = "ORDPRINCIPAL"
        Me.ORDPRINCIPALDataGridViewTextBoxColumn.Name = "ORDPRINCIPALDataGridViewTextBoxColumn"
        '
        'ORDAPOYADODataGridViewTextBoxColumn
        '
        Me.ORDAPOYADODataGridViewTextBoxColumn.DataPropertyName = "ORDAPOYADO"
        Me.ORDAPOYADODataGridViewTextBoxColumn.HeaderText = "ORDAPOYADO"
        Me.ORDAPOYADODataGridViewTextBoxColumn.Name = "ORDAPOYADODataGridViewTextBoxColumn"
        '
        'ORDPADREDataGridViewTextBoxColumn
        '
        Me.ORDPADREDataGridViewTextBoxColumn.DataPropertyName = "ORDPADRE"
        Me.ORDPADREDataGridViewTextBoxColumn.HeaderText = "ORDPADRE"
        Me.ORDPADREDataGridViewTextBoxColumn.Name = "ORDPADREDataGridViewTextBoxColumn"
        '
        'RECLAMOSREDDataGridViewTextBoxColumn
        '
        Me.RECLAMOSREDDataGridViewTextBoxColumn.DataPropertyName = "RECLAMOSRED"
        Me.RECLAMOSREDDataGridViewTextBoxColumn.HeaderText = "RECLAMOSRED"
        Me.RECLAMOSREDDataGridViewTextBoxColumn.Name = "RECLAMOSREDDataGridViewTextBoxColumn"
        '
        'RECLAMOSMDUDataGridViewTextBoxColumn
        '
        Me.RECLAMOSMDUDataGridViewTextBoxColumn.DataPropertyName = "RECLAMOSMDU"
        Me.RECLAMOSMDUDataGridViewTextBoxColumn.HeaderText = "RECLAMOSMDU"
        Me.RECLAMOSMDUDataGridViewTextBoxColumn.Name = "RECLAMOSMDUDataGridViewTextBoxColumn"
        '
        'RECLAMOSTOTDataGridViewTextBoxColumn
        '
        Me.RECLAMOSTOTDataGridViewTextBoxColumn.DataPropertyName = "RECLAMOSTOT"
        Me.RECLAMOSTOTDataGridViewTextBoxColumn.HeaderText = "RECLAMOSTOT"
        Me.RECLAMOSTOTDataGridViewTextBoxColumn.Name = "RECLAMOSTOTDataGridViewTextBoxColumn"
        '
        'TPREVISTODataGridViewTextBoxColumn
        '
        Me.TPREVISTODataGridViewTextBoxColumn.DataPropertyName = "TPREVISTO"
        Me.TPREVISTODataGridViewTextBoxColumn.HeaderText = "TPREVISTO"
        Me.TPREVISTODataGridViewTextBoxColumn.Name = "TPREVISTODataGridViewTextBoxColumn"
        '
        'TREALIZADODataGridViewTextBoxColumn
        '
        Me.TREALIZADODataGridViewTextBoxColumn.DataPropertyName = "TREALIZADO"
        Me.TREALIZADODataGridViewTextBoxColumn.HeaderText = "TREALIZADO"
        Me.TREALIZADODataGridViewTextBoxColumn.Name = "TREALIZADODataGridViewTextBoxColumn"
        '
        'TIEMPOTRABAJODataGridViewTextBoxColumn
        '
        Me.TIEMPOTRABAJODataGridViewTextBoxColumn.DataPropertyName = "TIEMPOTRABAJO"
        Me.TIEMPOTRABAJODataGridViewTextBoxColumn.HeaderText = "TIEMPOTRABAJO"
        Me.TIEMPOTRABAJODataGridViewTextBoxColumn.Name = "TIEMPOTRABAJODataGridViewTextBoxColumn"
        '
        'CREARORDINALDataGridViewCheckBoxColumn
        '
        Me.CREARORDINALDataGridViewCheckBoxColumn.DataPropertyName = "CREARORDINAL"
        Me.CREARORDINALDataGridViewCheckBoxColumn.HeaderText = "CREARORDINAL"
        Me.CREARORDINALDataGridViewCheckBoxColumn.Name = "CREARORDINALDataGridViewCheckBoxColumn"
        '
        'COORDINARDataGridViewCheckBoxColumn
        '
        Me.COORDINARDataGridViewCheckBoxColumn.DataPropertyName = "COORDINAR"
        Me.COORDINARDataGridViewCheckBoxColumn.HeaderText = "COORDINAR"
        Me.COORDINARDataGridViewCheckBoxColumn.Name = "COORDINARDataGridViewCheckBoxColumn"
        '
        'MANZANADataGridViewTextBoxColumn
        '
        Me.MANZANADataGridViewTextBoxColumn.DataPropertyName = "MANZANA"
        Me.MANZANADataGridViewTextBoxColumn.HeaderText = "MANZANA"
        Me.MANZANADataGridViewTextBoxColumn.Name = "MANZANADataGridViewTextBoxColumn"
        '
        'TURNOAGENDDataGridViewTextBoxColumn
        '
        Me.TURNOAGENDDataGridViewTextBoxColumn.DataPropertyName = "TURNOAGEND"
        Me.TURNOAGENDDataGridViewTextBoxColumn.HeaderText = "TURNOAGEND"
        Me.TURNOAGENDDataGridViewTextBoxColumn.Name = "TURNOAGENDDataGridViewTextBoxColumn"
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
        'FECHAAGENDDataGridViewTextBoxColumn
        '
        Me.FECHAAGENDDataGridViewTextBoxColumn.DataPropertyName = "FECHAAGEND"
        Me.FECHAAGENDDataGridViewTextBoxColumn.HeaderText = "FECHAAGEND"
        Me.FECHAAGENDDataGridViewTextBoxColumn.Name = "FECHAAGENDDataGridViewTextBoxColumn"
        '
        'ORDENDEPDataGridViewTextBoxColumn
        '
        Me.ORDENDEPDataGridViewTextBoxColumn.DataPropertyName = "ORDENDEP"
        Me.ORDENDEPDataGridViewTextBoxColumn.HeaderText = "ORDENDEP"
        Me.ORDENDEPDataGridViewTextBoxColumn.Name = "ORDENDEPDataGridViewTextBoxColumn"
        '
        'DUPLICADADEDataGridViewTextBoxColumn
        '
        Me.DUPLICADADEDataGridViewTextBoxColumn.DataPropertyName = "DUPLICADADE"
        Me.DUPLICADADEDataGridViewTextBoxColumn.HeaderText = "DUPLICADADE"
        Me.DUPLICADADEDataGridViewTextBoxColumn.Name = "DUPLICADADEDataGridViewTextBoxColumn"
        '
        'DUPLICADAADataGridViewTextBoxColumn
        '
        Me.DUPLICADAADataGridViewTextBoxColumn.DataPropertyName = "DUPLICADAA"
        Me.DUPLICADAADataGridViewTextBoxColumn.HeaderText = "DUPLICADAA"
        Me.DUPLICADAADataGridViewTextBoxColumn.Name = "DUPLICADAADataGridViewTextBoxColumn"
        '
        'FECHAINICESTIMADODataGridViewTextBoxColumn
        '
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.DataPropertyName = "FECHAINICESTIMADO"
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.HeaderText = "FECHAINICESTIMADO"
        Me.FECHAINICESTIMADODataGridViewTextBoxColumn.Name = "FECHAINICESTIMADODataGridViewTextBoxColumn"
        '
        'TESTIMADODataGridViewTextBoxColumn
        '
        Me.TESTIMADODataGridViewTextBoxColumn.DataPropertyName = "TESTIMADO"
        Me.TESTIMADODataGridViewTextBoxColumn.HeaderText = "TESTIMADO"
        Me.TESTIMADODataGridViewTextBoxColumn.Name = "TESTIMADODataGridViewTextBoxColumn"
        '
        'AGENDARDataGridViewCheckBoxColumn
        '
        Me.AGENDARDataGridViewCheckBoxColumn.DataPropertyName = "AGENDAR"
        Me.AGENDARDataGridViewCheckBoxColumn.HeaderText = "AGENDAR"
        Me.AGENDARDataGridViewCheckBoxColumn.Name = "AGENDARDataGridViewCheckBoxColumn"
        '
        'CLASEDEPDataGridViewTextBoxColumn
        '
        Me.CLASEDEPDataGridViewTextBoxColumn.DataPropertyName = "CLASEDEP"
        Me.CLASEDEPDataGridViewTextBoxColumn.HeaderText = "CLASEDEP"
        Me.CLASEDEPDataGridViewTextBoxColumn.Name = "CLASEDEPDataGridViewTextBoxColumn"
        '
        'ORDORIGENDataGridViewTextBoxColumn
        '
        Me.ORDORIGENDataGridViewTextBoxColumn.DataPropertyName = "ORDORIGEN"
        Me.ORDORIGENDataGridViewTextBoxColumn.HeaderText = "ORDORIGEN"
        Me.ORDORIGENDataGridViewTextBoxColumn.Name = "ORDORIGENDataGridViewTextBoxColumn"
        '
        'SECTORGENDataGridViewTextBoxColumn
        '
        Me.SECTORGENDataGridViewTextBoxColumn.DataPropertyName = "SECTORGEN"
        Me.SECTORGENDataGridViewTextBoxColumn.HeaderText = "SECTORGEN"
        Me.SECTORGENDataGridViewTextBoxColumn.Name = "SECTORGENDataGridViewTextBoxColumn"
        '
        'INSTALACIONRUSDataGridViewTextBoxColumn
        '
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.DataPropertyName = "INSTALACIONRUS"
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.HeaderText = "INSTALACIONRUS"
        Me.INSTALACIONRUSDataGridViewTextBoxColumn.Name = "INSTALACIONRUSDataGridViewTextBoxColumn"
        '
        'TPREVISTOUTDataGridViewTextBoxColumn
        '
        Me.TPREVISTOUTDataGridViewTextBoxColumn.DataPropertyName = "TPREVISTO_UT"
        Me.TPREVISTOUTDataGridViewTextBoxColumn.HeaderText = "TPREVISTO_UT"
        Me.TPREVISTOUTDataGridViewTextBoxColumn.Name = "TPREVISTOUTDataGridViewTextBoxColumn"
        '
        'AFECTACIONDataGridViewTextBoxColumn
        '
        Me.AFECTACIONDataGridViewTextBoxColumn.DataPropertyName = "AFECTACION"
        Me.AFECTACIONDataGridViewTextBoxColumn.HeaderText = "AFECTACION"
        Me.AFECTACIONDataGridViewTextBoxColumn.Name = "AFECTACIONDataGridViewTextBoxColumn"
        '
        'RECURSODataGridViewTextBoxColumn
        '
        Me.RECURSODataGridViewTextBoxColumn.DataPropertyName = "RECURSO"
        Me.RECURSODataGridViewTextBoxColumn.HeaderText = "RECURSO"
        Me.RECURSODataGridViewTextBoxColumn.Name = "RECURSODataGridViewTextBoxColumn"
        '
        'IDCALLEDataGridViewTextBoxColumn
        '
        Me.IDCALLEDataGridViewTextBoxColumn.DataPropertyName = "ID_CALLE"
        Me.IDCALLEDataGridViewTextBoxColumn.HeaderText = "ID_CALLE"
        Me.IDCALLEDataGridViewTextBoxColumn.Name = "IDCALLEDataGridViewTextBoxColumn"
        '
        'DESAGENDARDataGridViewCheckBoxColumn
        '
        Me.DESAGENDARDataGridViewCheckBoxColumn.DataPropertyName = "DESAGENDAR"
        Me.DESAGENDARDataGridViewCheckBoxColumn.HeaderText = "DESAGENDAR"
        Me.DESAGENDARDataGridViewCheckBoxColumn.Name = "DESAGENDARDataGridViewCheckBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ORDENES"
        Me.BindingSource1.DataSource = Me.OrdenesDataSet1
        '
        'OrdenesDataSet1
        '
        Me.OrdenesDataSet1.DataSetName = "ORDENESDataSet"
        Me.OrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_SIGUIENTE
        '
        Me.BTN_SIGUIENTE.BackColor = System.Drawing.Color.Black
        Me.BTN_SIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SIGUIENTE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_SIGUIENTE.Location = New System.Drawing.Point(1171, 528)
        Me.BTN_SIGUIENTE.Name = "BTN_SIGUIENTE"
        Me.BTN_SIGUIENTE.Size = New System.Drawing.Size(93, 32)
        Me.BTN_SIGUIENTE.TabIndex = 223
        Me.BTN_SIGUIENTE.Text = "SIGUIENTE"
        Me.BTN_SIGUIENTE.UseVisualStyleBackColor = False
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.BackColor = System.Drawing.Color.Black
        Me.BTN_BORRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BORRAR.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_BORRAR.Location = New System.Drawing.Point(1270, 528)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(80, 32)
        Me.BTN_BORRAR.TabIndex = 224
        Me.BTN_BORRAR.Text = "BORRAR"
        Me.BTN_BORRAR.UseVisualStyleBackColor = False
        '
        'CK_INICIAR_TRABAJOS
        '
        Me.CK_INICIAR_TRABAJOS.AutoSize = True
        Me.CK_INICIAR_TRABAJOS.Checked = True
        Me.CK_INICIAR_TRABAJOS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_INICIAR_TRABAJOS.Location = New System.Drawing.Point(11, 68)
        Me.CK_INICIAR_TRABAJOS.Name = "CK_INICIAR_TRABAJOS"
        Me.CK_INICIAR_TRABAJOS.Size = New System.Drawing.Size(124, 17)
        Me.CK_INICIAR_TRABAJOS.TabIndex = 225
        Me.CK_INICIAR_TRABAJOS.Text = "INICIAR TRABAJOS"
        Me.CK_INICIAR_TRABAJOS.UseVisualStyleBackColor = True
        '
        'CK_FINALIZA_TRABAJO
        '
        Me.CK_FINALIZA_TRABAJO.AutoSize = True
        Me.CK_FINALIZA_TRABAJO.Checked = True
        Me.CK_FINALIZA_TRABAJO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_FINALIZA_TRABAJO.Location = New System.Drawing.Point(11, 146)
        Me.CK_FINALIZA_TRABAJO.Name = "CK_FINALIZA_TRABAJO"
        Me.CK_FINALIZA_TRABAJO.Size = New System.Drawing.Size(140, 17)
        Me.CK_FINALIZA_TRABAJO.TabIndex = 226
        Me.CK_FINALIZA_TRABAJO.Text = "FINALIZAR TRABAJOS"
        Me.CK_FINALIZA_TRABAJO.UseVisualStyleBackColor = True
        '
        'CK_MARCA_DUPLICAR
        '
        Me.CK_MARCA_DUPLICAR.AutoSize = True
        Me.CK_MARCA_DUPLICAR.Checked = True
        Me.CK_MARCA_DUPLICAR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_MARCA_DUPLICAR.Location = New System.Drawing.Point(11, 94)
        Me.CK_MARCA_DUPLICAR.Name = "CK_MARCA_DUPLICAR"
        Me.CK_MARCA_DUPLICAR.Size = New System.Drawing.Size(139, 17)
        Me.CK_MARCA_DUPLICAR.TabIndex = 227
        Me.CK_MARCA_DUPLICAR.Text = "MARCAR A DUPLICAR"
        Me.CK_MARCA_DUPLICAR.UseVisualStyleBackColor = True
        '
        'CK_INICIA_GESTION
        '
        Me.CK_INICIA_GESTION.AutoSize = True
        Me.CK_INICIA_GESTION.Checked = True
        Me.CK_INICIA_GESTION.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_INICIA_GESTION.Location = New System.Drawing.Point(11, 120)
        Me.CK_INICIA_GESTION.Name = "CK_INICIA_GESTION"
        Me.CK_INICIA_GESTION.Size = New System.Drawing.Size(130, 17)
        Me.CK_INICIA_GESTION.TabIndex = 228
        Me.CK_INICIA_GESTION.Text = "INICIAR GESTIONES"
        Me.CK_INICIA_GESTION.UseVisualStyleBackColor = True
        '
        'CK_REQUERIDOS
        '
        Me.CK_REQUERIDOS.AutoSize = True
        Me.CK_REQUERIDOS.Checked = True
        Me.CK_REQUERIDOS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_REQUERIDOS.Location = New System.Drawing.Point(11, 198)
        Me.CK_REQUERIDOS.Name = "CK_REQUERIDOS"
        Me.CK_REQUERIDOS.Size = New System.Drawing.Size(154, 17)
        Me.CK_REQUERIDOS.TabIndex = 229
        Me.CK_REQUERIDOS.Text = "ANALIZAR REQUERIDOS"
        Me.CK_REQUERIDOS.UseVisualStyleBackColor = True
        '
        'CK_LIMPIEZA_MENSAJES
        '
        Me.CK_LIMPIEZA_MENSAJES.AutoSize = True
        Me.CK_LIMPIEZA_MENSAJES.Checked = True
        Me.CK_LIMPIEZA_MENSAJES.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_LIMPIEZA_MENSAJES.Location = New System.Drawing.Point(11, 234)
        Me.CK_LIMPIEZA_MENSAJES.Name = "CK_LIMPIEZA_MENSAJES"
        Me.CK_LIMPIEZA_MENSAJES.Size = New System.Drawing.Size(169, 17)
        Me.CK_LIMPIEZA_MENSAJES.TabIndex = 230
        Me.CK_LIMPIEZA_MENSAJES.Text = "LIMPIAR MENSAJES VIEJOS"
        Me.CK_LIMPIEZA_MENSAJES.UseVisualStyleBackColor = True
        '
        'CK_FINALIZA_GESTION
        '
        Me.CK_FINALIZA_GESTION.AutoSize = True
        Me.CK_FINALIZA_GESTION.Checked = True
        Me.CK_FINALIZA_GESTION.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_FINALIZA_GESTION.Location = New System.Drawing.Point(11, 172)
        Me.CK_FINALIZA_GESTION.Name = "CK_FINALIZA_GESTION"
        Me.CK_FINALIZA_GESTION.Size = New System.Drawing.Size(146, 17)
        Me.CK_FINALIZA_GESTION.TabIndex = 231
        Me.CK_FINALIZA_GESTION.Text = "FINALIZAR GESTIONES"
        Me.CK_FINALIZA_GESTION.UseVisualStyleBackColor = True
        '
        'BTN_REPORTE_SERVICIOS
        '
        Me.BTN_REPORTE_SERVICIOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REPORTE_SERVICIOS.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_REPORTE_SERVICIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_REPORTE_SERVICIOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REPORTE_SERVICIOS.FlatAppearance.BorderSize = 0
        Me.BTN_REPORTE_SERVICIOS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REPORTE_SERVICIOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REPORTE_SERVICIOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REPORTE_SERVICIOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REPORTE_SERVICIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REPORTE_SERVICIOS.ForeColor = System.Drawing.Color.White
        Me.BTN_REPORTE_SERVICIOS.Location = New System.Drawing.Point(17, 104)
        Me.BTN_REPORTE_SERVICIOS.Name = "BTN_REPORTE_SERVICIOS"
        Me.BTN_REPORTE_SERVICIOS.Size = New System.Drawing.Size(188, 31)
        Me.BTN_REPORTE_SERVICIOS.TabIndex = 391
        Me.BTN_REPORTE_SERVICIOS.Text = "REPORTE SERVICIOS"
        Me.BTN_REPORTE_SERVICIOS.UseVisualStyleBackColor = False
        '
        'DT_SERVICIO_INICIO
        '
        Me.DT_SERVICIO_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_SERVICIO_INICIO.Location = New System.Drawing.Point(109, 52)
        Me.DT_SERVICIO_INICIO.Name = "DT_SERVICIO_INICIO"
        Me.DT_SERVICIO_INICIO.Size = New System.Drawing.Size(93, 20)
        Me.DT_SERVICIO_INICIO.TabIndex = 392
        '
        'DT_SERVICIO_FIN
        '
        Me.DT_SERVICIO_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_SERVICIO_FIN.Location = New System.Drawing.Point(109, 78)
        Me.DT_SERVICIO_FIN.Name = "DT_SERVICIO_FIN"
        Me.DT_SERVICIO_FIN.Size = New System.Drawing.Size(93, 20)
        Me.DT_SERVICIO_FIN.TabIndex = 393
        '
        'LBL_DESDE_SERVICIOS
        '
        Me.LBL_DESDE_SERVICIOS.AutoSize = True
        Me.LBL_DESDE_SERVICIOS.ForeColor = System.Drawing.Color.White
        Me.LBL_DESDE_SERVICIOS.Location = New System.Drawing.Point(59, 56)
        Me.LBL_DESDE_SERVICIOS.Name = "LBL_DESDE_SERVICIOS"
        Me.LBL_DESDE_SERVICIOS.Size = New System.Drawing.Size(44, 13)
        Me.LBL_DESDE_SERVICIOS.TabIndex = 394
        Me.LBL_DESDE_SERVICIOS.Text = "DESDE"
        '
        'LBL_HASTA_SERVICIOS
        '
        Me.LBL_HASTA_SERVICIOS.AutoSize = True
        Me.LBL_HASTA_SERVICIOS.ForeColor = System.Drawing.Color.White
        Me.LBL_HASTA_SERVICIOS.Location = New System.Drawing.Point(60, 82)
        Me.LBL_HASTA_SERVICIOS.Name = "LBL_HASTA_SERVICIOS"
        Me.LBL_HASTA_SERVICIOS.Size = New System.Drawing.Size(43, 13)
        Me.LBL_HASTA_SERVICIOS.TabIndex = 395
        Me.LBL_HASTA_SERVICIOS.Text = "HASTA"
        '
        'CB_TIPO_SERVICIOS
        '
        Me.CB_TIPO_SERVICIOS.FormattingEnabled = True
        Me.CB_TIPO_SERVICIOS.Items.AddRange(New Object() {"INGRESADOS", "FINALIZADOS"})
        Me.CB_TIPO_SERVICIOS.Location = New System.Drawing.Point(21, 26)
        Me.CB_TIPO_SERVICIOS.Name = "CB_TIPO_SERVICIOS"
        Me.CB_TIPO_SERVICIOS.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIPO_SERVICIOS.TabIndex = 396
        Me.CB_TIPO_SERVICIOS.Text = "INGRESADOS"
        '
        'BTN_EXCEL
        '
        Me.BTN_EXCEL.BackColor = System.Drawing.Color.Transparent
        Me.BTN_EXCEL.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_EXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_EXCEL.FlatAppearance.BorderSize = 0
        Me.BTN_EXCEL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_EXCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_EXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EXCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXCEL.ForeColor = System.Drawing.Color.White
        Me.BTN_EXCEL.Location = New System.Drawing.Point(17, 176)
        Me.BTN_EXCEL.Name = "BTN_EXCEL"
        Me.BTN_EXCEL.Size = New System.Drawing.Size(188, 31)
        Me.BTN_EXCEL.TabIndex = 397
        Me.BTN_EXCEL.Text = "SERVICIOS REITERADOS"
        Me.BTN_EXCEL.UseVisualStyleBackColor = False
        '
        'DGVOBRACIVIL
        '
        Me.DGVOBRACIVIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOBRACIVIL.Location = New System.Drawing.Point(19, 441)
        Me.DGVOBRACIVIL.Name = "DGVOBRACIVIL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGVOBRACIVIL.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVOBRACIVIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOBRACIVIL.ShowCellErrors = False
        Me.DGVOBRACIVIL.ShowCellToolTips = False
        Me.DGVOBRACIVIL.ShowEditingIcon = False
        Me.DGVOBRACIVIL.ShowRowErrors = False
        Me.DGVOBRACIVIL.Size = New System.Drawing.Size(755, 101)
        Me.DGVOBRACIVIL.TabIndex = 398
        Me.DGVOBRACIVIL.Visible = False
        '
        'BTN_OBRA_CIVIL_PENDIENTES
        '
        Me.BTN_OBRA_CIVIL_PENDIENTES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OBRA_CIVIL_PENDIENTES.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_OBRA_CIVIL_PENDIENTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_OBRA_CIVIL_PENDIENTES.FlatAppearance.BorderSize = 0
        Me.BTN_OBRA_CIVIL_PENDIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_OBRA_CIVIL_PENDIENTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OBRA_CIVIL_PENDIENTES.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_OBRA_CIVIL_PENDIENTES.Location = New System.Drawing.Point(17, 140)
        Me.BTN_OBRA_CIVIL_PENDIENTES.Name = "BTN_OBRA_CIVIL_PENDIENTES"
        Me.BTN_OBRA_CIVIL_PENDIENTES.Size = New System.Drawing.Size(188, 32)
        Me.BTN_OBRA_CIVIL_PENDIENTES.TabIndex = 399
        Me.BTN_OBRA_CIVIL_PENDIENTES.Text = "VER OBRA CIVIL - PEND"
        Me.BTN_OBRA_CIVIL_PENDIENTES.UseVisualStyleBackColor = False
        '
        'CK_DISENO_OC
        '
        Me.CK_DISENO_OC.AutoSize = True
        Me.CK_DISENO_OC.Checked = True
        Me.CK_DISENO_OC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_DISENO_OC.Location = New System.Drawing.Point(21, 77)
        Me.CK_DISENO_OC.Name = "CK_DISENO_OC"
        Me.CK_DISENO_OC.Size = New System.Drawing.Size(85, 17)
        Me.CK_DISENO_OC.TabIndex = 403
        Me.CK_DISENO_OC.Text = "DISEÑO OC"
        Me.CK_DISENO_OC.UseVisualStyleBackColor = True
        '
        'CK_DISENO_RED
        '
        Me.CK_DISENO_RED.AutoSize = True
        Me.CK_DISENO_RED.Checked = True
        Me.CK_DISENO_RED.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_DISENO_RED.Location = New System.Drawing.Point(21, 51)
        Me.CK_DISENO_RED.Name = "CK_DISENO_RED"
        Me.CK_DISENO_RED.Size = New System.Drawing.Size(93, 17)
        Me.CK_DISENO_RED.TabIndex = 402
        Me.CK_DISENO_RED.Text = "DISEÑO RED"
        Me.CK_DISENO_RED.UseVisualStyleBackColor = True
        '
        'CK_ACT_PLANOS
        '
        Me.CK_ACT_PLANOS.AutoSize = True
        Me.CK_ACT_PLANOS.Checked = True
        Me.CK_ACT_PLANOS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_ACT_PLANOS.Location = New System.Drawing.Point(21, 103)
        Me.CK_ACT_PLANOS.Name = "CK_ACT_PLANOS"
        Me.CK_ACT_PLANOS.Size = New System.Drawing.Size(93, 17)
        Me.CK_ACT_PLANOS.TabIndex = 401
        Me.CK_ACT_PLANOS.Text = "ACT PLANOS"
        Me.CK_ACT_PLANOS.UseVisualStyleBackColor = True
        '
        'CK_SERVICIOS
        '
        Me.CK_SERVICIOS.AutoSize = True
        Me.CK_SERVICIOS.Checked = True
        Me.CK_SERVICIOS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_SERVICIOS.Location = New System.Drawing.Point(21, 25)
        Me.CK_SERVICIOS.Name = "CK_SERVICIOS"
        Me.CK_SERVICIOS.Size = New System.Drawing.Size(83, 17)
        Me.CK_SERVICIOS.TabIndex = 400
        Me.CK_SERVICIOS.Text = "SERVICIOS"
        Me.CK_SERVICIOS.UseVisualStyleBackColor = True
        '
        'BTN_LISTAR_ORDENES
        '
        Me.BTN_LISTAR_ORDENES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_LISTAR_ORDENES.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_LISTAR_ORDENES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_LISTAR_ORDENES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_LISTAR_ORDENES.FlatAppearance.BorderSize = 0
        Me.BTN_LISTAR_ORDENES.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_LISTAR_ORDENES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_LISTAR_ORDENES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_LISTAR_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LISTAR_ORDENES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LISTAR_ORDENES.ForeColor = System.Drawing.Color.White
        Me.BTN_LISTAR_ORDENES.Location = New System.Drawing.Point(17, 126)
        Me.BTN_LISTAR_ORDENES.Name = "BTN_LISTAR_ORDENES"
        Me.BTN_LISTAR_ORDENES.Size = New System.Drawing.Size(188, 31)
        Me.BTN_LISTAR_ORDENES.TabIndex = 404
        Me.BTN_LISTAR_ORDENES.Text = "LISTAR ORDENES"
        Me.BTN_LISTAR_ORDENES.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_OBRA_CIVIL_PENDIENTES)
        Me.GroupBox1.Controls.Add(Me.BTN_EXCEL)
        Me.GroupBox1.Controls.Add(Me.CB_TIPO_SERVICIOS)
        Me.GroupBox1.Controls.Add(Me.BTN_REPORTE_SERVICIOS)
        Me.GroupBox1.Controls.Add(Me.LBL_HASTA_SERVICIOS)
        Me.GroupBox1.Controls.Add(Me.DT_SERVICIO_INICIO)
        Me.GroupBox1.Controls.Add(Me.LBL_DESDE_SERVICIOS)
        Me.GroupBox1.Controls.Add(Me.DT_SERVICIO_FIN)
        Me.GroupBox1.Location = New System.Drawing.Point(993, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 222)
        Me.GroupBox1.TabIndex = 405
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTRO CON FECHA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_LISTAR_ORDENES)
        Me.GroupBox2.Controls.Add(Me.CK_SERVICIOS)
        Me.GroupBox2.Controls.Add(Me.CK_ACT_PLANOS)
        Me.GroupBox2.Controls.Add(Me.CK_DISENO_OC)
        Me.GroupBox2.Controls.Add(Me.CK_DISENO_RED)
        Me.GroupBox2.Location = New System.Drawing.Point(993, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 163)
        Me.GroupBox2.TabIndex = 406
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEGUN MOTIVO "
        '
        'BTN_TRABAJAR_ORDENES
        '
        Me.BTN_TRABAJAR_ORDENES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_TRABAJAR_ORDENES.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_TRABAJAR_ORDENES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_TRABAJAR_ORDENES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_TRABAJAR_ORDENES.FlatAppearance.BorderSize = 0
        Me.BTN_TRABAJAR_ORDENES.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_TRABAJAR_ORDENES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_TRABAJAR_ORDENES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_TRABAJAR_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TRABAJAR_ORDENES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_TRABAJAR_ORDENES.ForeColor = System.Drawing.Color.White
        Me.BTN_TRABAJAR_ORDENES.Location = New System.Drawing.Point(11, 388)
        Me.BTN_TRABAJAR_ORDENES.Name = "BTN_TRABAJAR_ORDENES"
        Me.BTN_TRABAJAR_ORDENES.Size = New System.Drawing.Size(188, 31)
        Me.BTN_TRABAJAR_ORDENES.TabIndex = 405
        Me.BTN_TRABAJAR_ORDENES.Text = "TRABAJAR CON ORDENES"
        Me.BTN_TRABAJAR_ORDENES.UseVisualStyleBackColor = False
        '
        'dt_desde_repetidos
        '
        Me.dt_desde_repetidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde_repetidos.Location = New System.Drawing.Point(973, 508)
        Me.dt_desde_repetidos.Name = "dt_desde_repetidos"
        Me.dt_desde_repetidos.Size = New System.Drawing.Size(93, 20)
        Me.dt_desde_repetidos.TabIndex = 407
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(923, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "DESDE"
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
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
        '
        'MENSAJERIABindingSource
        '
        Me.MENSAJERIABindingSource.DataMember = "MENSAJERIA"
        Me.MENSAJERIABindingSource.DataSource = Me.ORDENESDataSet
        '
        'MENSAJERIA_OLDTableAdapter
        '
        Me.MENSAJERIA_OLDTableAdapter.ClearBeforeFill = True
        '
        'MENSAJERIATableAdapter
        '
        Me.MENSAJERIATableAdapter.ClearBeforeFill = True
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSBindingSource
        '
        Me.TRABAJOSBindingSource.DataMember = "TRABAJOS"
        Me.TRABAJOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'MENSAJERIA_OLDBindingSource
        '
        Me.MENSAJERIA_OLDBindingSource.DataMember = "MENSAJERIA_OLD"
        Me.MENSAJERIA_OLDBindingSource.DataSource = Me.ORDENESDataSet
        '
        'HISTORICOTableAdapter
        '
        Me.HISTORICOTableAdapter.ClearBeforeFill = True
        '
        'INFORMESERVICIOSBindingSource
        '
        Me.INFORMESERVICIOSBindingSource.DataMember = "INFORME_SERVICIOS"
        Me.INFORMESERVICIOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'OBESERVACIONESBindingSource
        '
        Me.OBESERVACIONESBindingSource.DataMember = "OBESERVACIONES"
        Me.OBESERVACIONESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'OBESERVACIONESTableAdapter
        '
        Me.OBESERVACIONESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager1.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager1.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager1.AREASTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager1.COMBOSTableAdapter = Nothing
        Me.TableAdapterManager1.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager1.FALLASTableAdapter = Nothing
        Me.TableAdapterManager1.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONES_TIPOTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONTableAdapter = Me.GESTIONTableAdapter
        Me.TableAdapterManager1.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager1.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager1.HISTORICOTableAdapter = Me.HISTORICOTableAdapter
        Me.TableAdapterManager1.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager1.MENSAJERIA_OLDTableAdapter = Me.MENSAJERIA_OLDTableAdapter
        Me.TableAdapterManager1.MENSAJERIATableAdapter = Me.MENSAJERIATableAdapter
        Me.TableAdapterManager1.OBESERVACIONESTableAdapter = Me.OBESERVACIONESTableAdapter
        Me.TableAdapterManager1.ORDENESTableAdapter = Me.ORDENESTableAdapter
        Me.TableAdapterManager1.PRESUPUESTOTableAdapter = Nothing
        Me.TableAdapterManager1.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager1.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager1.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager1.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager1.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager1.STATUSTableAdapter = Nothing
        Me.TableAdapterManager1.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager1.TAREASTableAdapter = Nothing
        Me.TableAdapterManager1.TIPOTableAdapter = Nothing
        Me.TableAdapterManager1.TRABAJOSTableAdapter = Me.TRABAJOSTableAdapter
        Me.TableAdapterManager1.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PROCESOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1381, 687)
        Me.Controls.Add(Me.dt_desde_repetidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_TRABAJAR_ORDENES)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVOBRACIVIL)
        Me.Controls.Add(Me.LBL_ESTADO)
        Me.Controls.Add(Me.BTN_PROCESO)
        Me.Controls.Add(Me.LBL_REGISTROS)
        Me.Controls.Add(Me.CK_FINALIZA_GESTION)
        Me.Controls.Add(Me.CK_LIMPIEZA_MENSAJES)
        Me.Controls.Add(Me.CK_REQUERIDOS)
        Me.Controls.Add(Me.CK_INICIA_GESTION)
        Me.Controls.Add(Me.CK_MARCA_DUPLICAR)
        Me.Controls.Add(Me.CK_FINALIZA_TRABAJO)
        Me.Controls.Add(Me.CK_INICIAR_TRABAJOS)
        Me.Controls.Add(Me.BTN_BORRAR)
        Me.Controls.Add(Me.BTN_SIGUIENTE)
        Me.Controls.Add(Me.DGV_ORDENES)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_BUSCAR_REPETIDOS)
        Me.Controls.Add(Me.PPROGRESSS)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PROCESOS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "PROCESOS"
        CType(Me.BasePermisoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PPROGRESSS.ResumeLayout(False)
        Me.PPROGRESSS.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.P_TRABAJO.ResumeLayout(False)
        Me.P_GESTION.ResumeLayout(False)
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaWEBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseCalculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoIndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ORDENES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOBRACIVIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENSAJERIA_OLDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMESERVICIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OBESERVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_PROCESO As Button
    Friend WithEvents LBL_ESTADO As Label
    Friend WithEvents LBL_REGISTROS As Label
    Friend WithEvents LBL_CANT_REGISTROS As Label
    Friend WithEvents PPROGRESSS As Panel
    Friend WithEvents lbl_slash As Label
    Friend WithEvents LBL_TOTAL As Label
    '   Friend WithEvents INFORME_INDICEDataSet As INFORME_INDICEDataSet
    Friend WithEvents InformesBindingSource As BindingSource
    '   Friend WithEvents InformesTableAdapter As INFORME_INDICEDataSetTableAdapters.InformesTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents MENSAJERIABindingSource As BindingSource
    Friend WithEvents MENSAJERIA_OLDTableAdapter As ORDENESDataSetTableAdapters.MENSAJERIA_OLDTableAdapter
    Friend WithEvents MENSAJERIATableAdapter As ORDENESDataSetTableAdapters.MENSAJERIATableAdapter
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents MENSAJERIA_OLDBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As MDUDataSetTableAdapters.EdificiosTableAdapter
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents MDUDataSet As MDUDataSet
    Friend WithEvents HISTORICOBindingSource As BindingSource
    Friend WithEvents HISTORICOTableAdapter As ORDENESDataSetTableAdapters.HISTORICOTableAdapter
    Friend WithEvents BaseIndicesBindingSource As BindingSource
    'Friend WithEvents BaseIndicesTableAdapter As INFORME_INDICEDataSetTableAdapters.BaseIndicesTableAdapter
    'Friend WithEvents TableAdapterManager As INFORME_INDICEDataSetTableAdapters.TableAdapterManager
    'Friend WithEvents BasePermisoresTableAdapter As INFORME_INDICEDataSetTableAdapters.BasePermisoresTableAdapter
    Friend WithEvents BasePermisoresBindingSource As BindingSource
    '  Friend WithEvents TablaWEBTableAdapter As INFORME_INDICEDataSetTableAdapters.TablaWEBTableAdapter
    Friend WithEvents TablaWEBBindingSource As BindingSource
    ' Friend WithEvents TecnicosTableAdapter As INFORME_INDICEDataSetTableAdapters.TecnicosTableAdapter
    Friend WithEvents TecnicosBindingSource As BindingSource
    '   Friend WithEvents BaseCalculoTableAdapter As INFORME_INDICEDataSetTableAdapters.BaseCalculoTableAdapter
    Friend WithEvents BaseCalculoBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents RepoIndicesBindingSource As BindingSource
    Friend WithEvents BTN_MATERIALES As Button
    Friend WithEvents BTN_BUSCAR_REPETIDOS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OrdenesDataSet1 As ORDENESDataSet
    Friend WithEvents DGV_ORDENES As DataGridView
    Friend WithEvents BTN_SIGUIENTE As Button
    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents NROORDENINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NROORDINALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGESTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTRABAJODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECTOROPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECTORDESTINODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHASOLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINGRESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAFINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHACIERREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRIORIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENERADORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SOLICITANTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUADRILLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NODODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZONADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NRODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESQU1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESQU2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AFECTCLIENTESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AFECTPORCIENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTONOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTOTELDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOTIVOORIGENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAUSARIGENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOTIVOCIERREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAUSACIERREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTALACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CARPETADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREMDUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDPRINCIPALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDAPOYADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDPADREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECLAMOSREDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECLAMOSMDUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECLAMOSTOTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TPREVISTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TREALIZADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPOTRABAJODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREARORDINALDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents COORDINARDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MANZANADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TURNOAGENDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPENDENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPODEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAAGENDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDENDEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DUPLICADADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DUPLICADAADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICESTIMADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TESTIMADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AGENDARDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CLASEDEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDORIGENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECTORGENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTALACIONRUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TPREVISTOUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AFECTACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECURSODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESAGENDARDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CK_INICIAR_TRABAJOS As CheckBox
    Friend WithEvents CK_FINALIZA_TRABAJO As CheckBox
    Friend WithEvents CK_MARCA_DUPLICAR As CheckBox
    Friend WithEvents CK_INICIA_GESTION As CheckBox
    Friend WithEvents CK_REQUERIDOS As CheckBox
    Friend WithEvents CK_LIMPIEZA_MENSAJES As CheckBox
    Friend WithEvents CK_FINALIZA_GESTION As CheckBox
    Friend WithEvents LBL_ORD As Label
    Friend WithEvents LBL_TRAB As Label
    Friend WithEvents LBL_GEST As Label
    Friend WithEvents SLASH_ORDENES As Label
    Friend WithEvents TOTAL_ORDENES As Label
    Friend WithEvents CANT_ORDENES As Label
    Friend WithEvents SLASH_TRABAJOS As Label
    Friend WithEvents TOTAL_TRABAJOS As Label
    Friend WithEvents CANT_TRABAJOS As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents P_TRABAJO As Panel
    Friend WithEvents P_GESTION As Panel
    Friend WithEvents PB_ORDENES As ProgressBar
    Friend WithEvents PB_TRABAJOS As ProgressBar
    Friend WithEvents PB_GESTIONES As ProgressBar
    Friend WithEvents BTN_REPORTE_SERVICIOS As Button
    Friend WithEvents INFORMESERVICIOSBindingSource As BindingSource
    Friend WithEvents DT_SERVICIO_INICIO As DateTimePicker
    Friend WithEvents DT_SERVICIO_FIN As DateTimePicker
    Friend WithEvents LBL_DESDE_SERVICIOS As Label
    Friend WithEvents LBL_HASTA_SERVICIOS As Label
    Friend WithEvents CB_TIPO_SERVICIOS As ComboBox
    Friend WithEvents BTN_EXCEL As Button
    Friend WithEvents DGVOBRACIVIL As DataGridView
    Friend WithEvents BTN_OBRA_CIVIL_PENDIENTES As Button
    Friend WithEvents CK_DISENO_OC As CheckBox
    Friend WithEvents CK_DISENO_RED As CheckBox
    Friend WithEvents CK_ACT_PLANOS As CheckBox
    Friend WithEvents CK_SERVICIOS As CheckBox
    Friend WithEvents BTN_LISTAR_ORDENES As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_TRABAJAR_ORDENES As Button
    Friend WithEvents dt_desde_repetidos As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents OBESERVACIONESBindingSource As BindingSource
    Friend WithEvents OBESERVACIONESTableAdapter As ORDENESDataSetTableAdapters.OBESERVACIONESTableAdapter
    Friend WithEvents TableAdapterManager1 As ORDENESDataSetTableAdapters.TableAdapterManager
End Class
