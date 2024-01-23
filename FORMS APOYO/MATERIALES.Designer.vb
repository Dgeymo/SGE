<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MATERIALES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MATERIALES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_VER_PanelINGRESO = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR_MAT = New System.Windows.Forms.Button()
        Me.BTN_CONTROL_MATERIAL = New System.Windows.Forms.Button()
        Me.BTN_MAS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.P_INFERIOR = New System.Windows.Forms.Panel()
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.TXT_PATH = New System.Windows.Forms.TextBox()
        Me.BTN_CARGAR = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.BTN_ABRIR_OPENFILE = New System.Windows.Forms.Button()
        Me.P_INGRESO = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_año = New System.Windows.Forms.Label()
        Me.CB_ANIO = New System.Windows.Forms.ComboBox()
        Me.lbl_mes = New System.Windows.Forms.Label()
        Me.CB_FECHA = New System.Windows.Forms.ComboBox()
        Me.BTN_CALCULAR_PROMEDIO = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LBL_CONSOLIDADO_ULTIMA = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BTN_CARGAR_CONSOLIDADO = New System.Windows.Forms.Button()
        Me.BTN_ABRIR_CONSOLIDADO = New System.Windows.Forms.Button()
        Me.TXT_CONSOLIDADO = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTN_AGREGAR_ARTICULO_MANUAL = New System.Windows.Forms.Button()
        Me.GB_AGREGAR_STOCK_MANUAL = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_ALIAS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_ACTUALIZAR_ARTICULO = New System.Windows.Forms.Button()
        Me.CB_ARTICULO = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CANT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BTN_NUEVO_TRANSITO_MANUAL = New System.Windows.Forms.Button()
        Me.GB_NUEVO_TRANSITO = New System.Windows.Forms.GroupBox()
        Me.BTN_INGRESAR_TRANSITO = New System.Windows.Forms.Button()
        Me.CB_NOMBRE_TRANSITO = New System.Windows.Forms.ComboBox()
        Me.CB_ALIAS_TRANSITO = New System.Windows.Forms.ComboBox()
        Me.TXT_CANT_NUEVO_TRANSITO = New System.Windows.Forms.TextBox()
        Me.DT_FIN_NUEVO_TRANSITO = New System.Windows.Forms.DateTimePicker()
        Me.DT_INI_NUEVO_TRANSITO = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_ALIAS_TRANSITO = New System.Windows.Forms.TextBox()
        Me.TXT_CANT_TRANSITO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE_TRANSITO = New System.Windows.Forms.TextBox()
        Me.DT_INI_TRANSITO = New System.Windows.Forms.DateTimePicker()
        Me.DT_FIN_TRANSITO = New System.Windows.Forms.DateTimePicker()
        Me.BTN_ACTUALIZAR_TRANSITO = New System.Windows.Forms.Button()
        Me.TRANSITODataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTN_AGREGAR_TRANSITO = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTN_AGREGAR_EXCEL_TRANISTO = New System.Windows.Forms.Button()
        Me.TXT_TRANSITO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MAT_ACTIVOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_MAT_ARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_MATERIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIN_TIEMPO_COMPRA_DIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIN_STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MAT_ACTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndicesDataSet = New REDES.INDICESDataSet()
        Me.CK_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.CB_ESTADO = New System.Windows.Forms.ComboBox()
        Me.TXT_ID_ART = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE_ART = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CB_TIPO_MATERIAL = New System.Windows.Forms.ComboBox()
        Me.CK_MATERIAL_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.BTN_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_TIPO_COMPRA = New System.Windows.Forms.ComboBox()
        Me.LBL_MIN_STOCK = New System.Windows.Forms.Label()
        Me.TXT_MIN_STOCK = New System.Windows.Forms.TextBox()
        Me.LBL_CANT_DIAS = New System.Windows.Forms.Label()
        Me.TXT_CANT_DIAS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FECHA_PRECIO = New System.Windows.Forms.DateTimePicker()
        Me.P_BUSCAR_MAT = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.P_INFORME = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXT_FLETE_LOCAL = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXT_FLETE_IMPO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_MESES = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.INFORME_MATERIALESDataGridView = New System.Windows.Forms.DataGridView()
        Me.CODIGOALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOCOMPRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERIODO_PROMEDIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPO_ENTREGA_FLETE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_CONSUMIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSUMOxMES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXISTENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCK_MIN_SEGUN_CONSUMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKMINIMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHASINSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACOMPRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREVISIONMESESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIASPARACOMPRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAT_INFORMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_PREVISION_LOCAL = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PREVISION_IMPORTACION = New System.Windows.Forms.TextBox()
        Me.BTN_BINFORME = New System.Windows.Forms.Button()
        Me.CB_BINFORME = New System.Windows.Forms.ComboBox()
        Me.BTN_BUSCAR_INFORME = New System.Windows.Forms.Button()
        Me.LBL_BINFORME = New System.Windows.Forms.Label()
        Me.BTN_GENERAR_INFORME = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.MAT_ACTIVOSTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_ACTIVOSTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.MAT_CONSOLIDADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_CONSOLIDADOTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_CONSOLIDADOTableAdapter()
        Me.MAT_CONSUMOSXMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_CONSUMOSXMESTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_CONSUMOSXMESTableAdapter()
        Me.MAT_STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_STOCKTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_STOCKTableAdapter()
        Me.MAT_TRANSITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_TRANSITOTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_TRANSITOTableAdapter()
        Me.IndicesDataSet1 = New REDES.INDICESDataSet()
        Me.MAT_INFORMETableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_INFORMETableAdapter()
        Me.P_INFERIOR.SuspendLayout()
        Me.P_INGRESO.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GB_AGREGAR_STOCK_MANUAL.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GB_NUEVO_TRANSITO.SuspendLayout()
        CType(Me.TRANSITODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.MAT_ACTIVOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_ACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.P_BUSCAR_MAT.SuspendLayout()
        Me.P_INFORME.SuspendLayout()
        CType(Me.INFORME_MATERIALESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_INFORMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_CONSOLIDADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_CONSUMOSXMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_TRANSITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_VER_PanelINGRESO
        '
        Me.BTN_VER_PanelINGRESO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_VER_PanelINGRESO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_VER_PanelINGRESO.FlatAppearance.BorderSize = 0
        Me.BTN_VER_PanelINGRESO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER_PanelINGRESO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VER_PanelINGRESO.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_PanelINGRESO.Location = New System.Drawing.Point(12, 52)
        Me.BTN_VER_PanelINGRESO.Name = "BTN_VER_PanelINGRESO"
        Me.BTN_VER_PanelINGRESO.Size = New System.Drawing.Size(136, 49)
        Me.BTN_VER_PanelINGRESO.TabIndex = 11
        Me.BTN_VER_PanelINGRESO.Text = "CARGAR DATOS"
        Me.BTN_VER_PanelINGRESO.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR_MAT
        '
        Me.BTN_BUSCAR_MAT.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_BUSCAR_MAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_BUSCAR_MAT.FlatAppearance.BorderSize = 0
        Me.BTN_BUSCAR_MAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BUSCAR_MAT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BUSCAR_MAT.ForeColor = System.Drawing.Color.White
        Me.BTN_BUSCAR_MAT.Location = New System.Drawing.Point(12, 540)
        Me.BTN_BUSCAR_MAT.Name = "BTN_BUSCAR_MAT"
        Me.BTN_BUSCAR_MAT.Size = New System.Drawing.Size(136, 49)
        Me.BTN_BUSCAR_MAT.TabIndex = 12
        Me.BTN_BUSCAR_MAT.Text = "BUSCAR MATERIAL"
        Me.BTN_BUSCAR_MAT.UseVisualStyleBackColor = True
        Me.BTN_BUSCAR_MAT.Visible = False
        '
        'BTN_CONTROL_MATERIAL
        '
        Me.BTN_CONTROL_MATERIAL.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_CONTROL_MATERIAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_CONTROL_MATERIAL.FlatAppearance.BorderSize = 0
        Me.BTN_CONTROL_MATERIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CONTROL_MATERIAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONTROL_MATERIAL.ForeColor = System.Drawing.Color.White
        Me.BTN_CONTROL_MATERIAL.Location = New System.Drawing.Point(12, 140)
        Me.BTN_CONTROL_MATERIAL.Name = "BTN_CONTROL_MATERIAL"
        Me.BTN_CONTROL_MATERIAL.Size = New System.Drawing.Size(136, 49)
        Me.BTN_CONTROL_MATERIAL.TabIndex = 14
        Me.BTN_CONTROL_MATERIAL.Text = "CONTROL MATERIAL"
        Me.BTN_CONTROL_MATERIAL.UseVisualStyleBackColor = True
        '
        'BTN_MAS
        '
        Me.BTN_MAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_MAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MAS.BackgroundImage = CType(resources.GetObject("BTN_MAS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MAS.FlatAppearance.BorderSize = 0
        Me.BTN_MAS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_MAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_MAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MAS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_MAS.Location = New System.Drawing.Point(905, -34)
        Me.BTN_MAS.Name = "BTN_MAS"
        Me.BTN_MAS.Size = New System.Drawing.Size(100, 33)
        Me.BTN_MAS.TabIndex = 16
        Me.BTN_MAS.Text = "ESCRITORIO"
        Me.BTN_MAS.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(1011, -34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "ACTIVIDADES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(1117, -34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "MATERIALES"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'P_INFERIOR
        '
        Me.P_INFERIOR.BackColor = System.Drawing.Color.White
        Me.P_INFERIOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_INFERIOR.Controls.Add(Me.Button2)
        Me.P_INFERIOR.Controls.Add(Me.Button1)
        Me.P_INFERIOR.Controls.Add(Me.BTN_MAS)
        Me.P_INFERIOR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_INFERIOR.Location = New System.Drawing.Point(0, 788)
        Me.P_INFERIOR.Name = "P_INFERIOR"
        Me.P_INFERIOR.Size = New System.Drawing.Size(1377, 0)
        Me.P_INFERIOR.TabIndex = 16
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(14, 75)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(107, 20)
        Me.DT_FECHA.TabIndex = 8
        '
        'TXT_PATH
        '
        Me.TXT_PATH.Location = New System.Drawing.Point(6, 22)
        Me.TXT_PATH.Name = "TXT_PATH"
        Me.TXT_PATH.Size = New System.Drawing.Size(294, 20)
        Me.TXT_PATH.TabIndex = 6
        '
        'BTN_CARGAR
        '
        Me.BTN_CARGAR.Location = New System.Drawing.Point(263, 64)
        Me.BTN_CARGAR.Name = "BTN_CARGAR"
        Me.BTN_CARGAR.Size = New System.Drawing.Size(164, 47)
        Me.BTN_CARGAR.TabIndex = 5
        Me.BTN_CARGAR.Text = "EJECUTAR PROCESO CARGAR DATOS"
        Me.BTN_CARGAR.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Red
        Me.txt_id.Location = New System.Drawing.Point(232, 12)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(944, 14)
        Me.txt_id.TabIndex = 7
        '
        'BTN_ABRIR_OPENFILE
        '
        Me.BTN_ABRIR_OPENFILE.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ABRIR_OPENFILE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ABRIR_OPENFILE.FlatAppearance.BorderSize = 0
        Me.BTN_ABRIR_OPENFILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ABRIR_OPENFILE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ABRIR_OPENFILE.ForeColor = System.Drawing.Color.White
        Me.BTN_ABRIR_OPENFILE.Location = New System.Drawing.Point(306, 22)
        Me.BTN_ABRIR_OPENFILE.Name = "BTN_ABRIR_OPENFILE"
        Me.BTN_ABRIR_OPENFILE.Size = New System.Drawing.Size(79, 20)
        Me.BTN_ABRIR_OPENFILE.TabIndex = 10
        Me.BTN_ABRIR_OPENFILE.Text = "ABRIR XLS"
        Me.BTN_ABRIR_OPENFILE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_ABRIR_OPENFILE.UseVisualStyleBackColor = True
        '
        'P_INGRESO
        '
        Me.P_INGRESO.BackColor = System.Drawing.Color.White
        Me.P_INGRESO.Controls.Add(Me.GroupBox2)
        Me.P_INGRESO.Controls.Add(Me.GroupBox6)
        Me.P_INGRESO.Controls.Add(Me.GroupBox3)
        Me.P_INGRESO.Controls.Add(Me.GroupBox5)
        Me.P_INGRESO.Controls.Add(Me.GroupBox4)
        Me.P_INGRESO.Location = New System.Drawing.Point(162, 40)
        Me.P_INGRESO.Name = "P_INGRESO"
        Me.P_INGRESO.Size = New System.Drawing.Size(1187, 584)
        Me.P_INGRESO.TabIndex = 10
        Me.P_INGRESO.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_año)
        Me.GroupBox2.Controls.Add(Me.CB_ANIO)
        Me.GroupBox2.Controls.Add(Me.lbl_mes)
        Me.GroupBox2.Controls.Add(Me.CB_FECHA)
        Me.GroupBox2.Controls.Add(Me.BTN_CALCULAR_PROMEDIO)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 121)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CALCULAR PROMEDIOS MES"
        '
        'lbl_año
        '
        Me.lbl_año.AutoSize = True
        Me.lbl_año.Location = New System.Drawing.Point(158, 39)
        Me.lbl_año.Name = "lbl_año"
        Me.lbl_año.Size = New System.Drawing.Size(30, 13)
        Me.lbl_año.TabIndex = 184
        Me.lbl_año.Text = "AÑO"
        '
        'CB_ANIO
        '
        Me.CB_ANIO.BackColor = System.Drawing.Color.White
        Me.CB_ANIO.ForeColor = System.Drawing.Color.Black
        Me.CB_ANIO.FormattingEnabled = True
        Me.CB_ANIO.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025"})
        Me.CB_ANIO.Location = New System.Drawing.Point(188, 35)
        Me.CB_ANIO.Name = "CB_ANIO"
        Me.CB_ANIO.Size = New System.Drawing.Size(58, 21)
        Me.CB_ANIO.TabIndex = 183
        Me.CB_ANIO.Text = "2022"
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Location = New System.Drawing.Point(19, 39)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(30, 13)
        Me.lbl_mes.TabIndex = 181
        Me.lbl_mes.Text = "MES"
        '
        'CB_FECHA
        '
        Me.CB_FECHA.BackColor = System.Drawing.Color.White
        Me.CB_FECHA.ForeColor = System.Drawing.Color.Black
        Me.CB_FECHA.FormattingEnabled = True
        Me.CB_FECHA.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CB_FECHA.Location = New System.Drawing.Point(53, 35)
        Me.CB_FECHA.MaxDropDownItems = 50
        Me.CB_FECHA.Name = "CB_FECHA"
        Me.CB_FECHA.Size = New System.Drawing.Size(85, 21)
        Me.CB_FECHA.TabIndex = 182
        Me.CB_FECHA.Text = "(Seleccione)"
        '
        'BTN_CALCULAR_PROMEDIO
        '
        Me.BTN_CALCULAR_PROMEDIO.Location = New System.Drawing.Point(263, 65)
        Me.BTN_CALCULAR_PROMEDIO.Name = "BTN_CALCULAR_PROMEDIO"
        Me.BTN_CALCULAR_PROMEDIO.Size = New System.Drawing.Size(164, 50)
        Me.BTN_CALCULAR_PROMEDIO.TabIndex = 11
        Me.BTN_CALCULAR_PROMEDIO.Text = "CALCULAR"
        Me.BTN_CALCULAR_PROMEDIO.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LBL_CONSOLIDADO_ULTIMA)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.BTN_CARGAR_CONSOLIDADO)
        Me.GroupBox6.Controls.Add(Me.BTN_ABRIR_CONSOLIDADO)
        Me.GroupBox6.Controls.Add(Me.TXT_CONSOLIDADO)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 303)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(440, 121)
        Me.GroupBox6.TabIndex = 187
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "INFORMACION DESDE EL CONSOLIDADO"
        '
        'LBL_CONSOLIDADO_ULTIMA
        '
        Me.LBL_CONSOLIDADO_ULTIMA.AutoSize = True
        Me.LBL_CONSOLIDADO_ULTIMA.Location = New System.Drawing.Point(11, 80)
        Me.LBL_CONSOLIDADO_ULTIMA.Name = "LBL_CONSOLIDADO_ULTIMA"
        Me.LBL_CONSOLIDADO_ULTIMA.Size = New System.Drawing.Size(88, 13)
        Me.LBL_CONSOLIDADO_ULTIMA.TabIndex = 17
        Me.LBL_CONSOLIDADO_ULTIMA.Text = "ULTIMA FECHA:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(259, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "COMPLETAR PERIODOS DE MESES COMPLETOS"
        '
        'BTN_CARGAR_CONSOLIDADO
        '
        Me.BTN_CARGAR_CONSOLIDADO.Location = New System.Drawing.Point(263, 65)
        Me.BTN_CARGAR_CONSOLIDADO.Name = "BTN_CARGAR_CONSOLIDADO"
        Me.BTN_CARGAR_CONSOLIDADO.Size = New System.Drawing.Size(164, 50)
        Me.BTN_CARGAR_CONSOLIDADO.TabIndex = 11
        Me.BTN_CARGAR_CONSOLIDADO.Text = "INGRESAR CONSUMOS "
        Me.BTN_CARGAR_CONSOLIDADO.UseVisualStyleBackColor = True
        '
        'BTN_ABRIR_CONSOLIDADO
        '
        Me.BTN_ABRIR_CONSOLIDADO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ABRIR_CONSOLIDADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ABRIR_CONSOLIDADO.FlatAppearance.BorderSize = 0
        Me.BTN_ABRIR_CONSOLIDADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ABRIR_CONSOLIDADO.ForeColor = System.Drawing.Color.White
        Me.BTN_ABRIR_CONSOLIDADO.Location = New System.Drawing.Point(309, 19)
        Me.BTN_ABRIR_CONSOLIDADO.Name = "BTN_ABRIR_CONSOLIDADO"
        Me.BTN_ABRIR_CONSOLIDADO.Size = New System.Drawing.Size(79, 20)
        Me.BTN_ABRIR_CONSOLIDADO.TabIndex = 15
        Me.BTN_ABRIR_CONSOLIDADO.Text = "ABRIR XLS"
        Me.BTN_ABRIR_CONSOLIDADO.UseVisualStyleBackColor = True
        '
        'TXT_CONSOLIDADO
        '
        Me.TXT_CONSOLIDADO.Location = New System.Drawing.Point(9, 19)
        Me.TXT_CONSOLIDADO.Name = "TXT_CONSOLIDADO"
        Me.TXT_CONSOLIDADO.Size = New System.Drawing.Size(294, 20)
        Me.TXT_CONSOLIDADO.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTN_AGREGAR_ARTICULO_MANUAL)
        Me.GroupBox3.Controls.Add(Me.GB_AGREGAR_STOCK_MANUAL)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.BTN_CARGAR)
        Me.GroupBox3.Controls.Add(Me.DT_FECHA)
        Me.GroupBox3.Controls.Add(Me.BTN_ABRIR_OPENFILE)
        Me.GroupBox3.Controls.Add(Me.TXT_PATH)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 240)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACION DEL SETA - INGRESO DE STOCK ACTUAL"
        '
        'BTN_AGREGAR_ARTICULO_MANUAL
        '
        Me.BTN_AGREGAR_ARTICULO_MANUAL.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_AGREGAR_ARTICULO_MANUAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AGREGAR_ARTICULO_MANUAL.FlatAppearance.BorderSize = 0
        Me.BTN_AGREGAR_ARTICULO_MANUAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGREGAR_ARTICULO_MANUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AGREGAR_ARTICULO_MANUAL.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_ARTICULO_MANUAL.Location = New System.Drawing.Point(6, 109)
        Me.BTN_AGREGAR_ARTICULO_MANUAL.Name = "BTN_AGREGAR_ARTICULO_MANUAL"
        Me.BTN_AGREGAR_ARTICULO_MANUAL.Size = New System.Drawing.Size(138, 23)
        Me.BTN_AGREGAR_ARTICULO_MANUAL.TabIndex = 37
        Me.BTN_AGREGAR_ARTICULO_MANUAL.Text = "AGREGAR ART MANUAL"
        Me.BTN_AGREGAR_ARTICULO_MANUAL.UseVisualStyleBackColor = True
        '
        'GB_AGREGAR_STOCK_MANUAL
        '
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.Label15)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.CB_ALIAS)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.Label4)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.BTN_ACTUALIZAR_ARTICULO)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.CB_ARTICULO)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.Label3)
        Me.GB_AGREGAR_STOCK_MANUAL.Controls.Add(Me.TXT_CANT)
        Me.GB_AGREGAR_STOCK_MANUAL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_AGREGAR_STOCK_MANUAL.Location = New System.Drawing.Point(3, 134)
        Me.GB_AGREGAR_STOCK_MANUAL.Name = "GB_AGREGAR_STOCK_MANUAL"
        Me.GB_AGREGAR_STOCK_MANUAL.Size = New System.Drawing.Size(434, 103)
        Me.GB_AGREGAR_STOCK_MANUAL.TabIndex = 36
        Me.GB_AGREGAR_STOCK_MANUAL.TabStop = False
        Me.GB_AGREGAR_STOCK_MANUAL.Text = "INGRESAR ARTICULO MANUAL"
        Me.GB_AGREGAR_STOCK_MANUAL.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(81, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "NOMBRE"
        '
        'CB_ALIAS
        '
        Me.CB_ALIAS.FormattingEnabled = True
        Me.CB_ALIAS.Location = New System.Drawing.Point(3, 37)
        Me.CB_ALIAS.Name = "CB_ALIAS"
        Me.CB_ALIAS.Size = New System.Drawing.Size(67, 21)
        Me.CB_ALIAS.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "ALIAS"
        '
        'BTN_ACTUALIZAR_ARTICULO
        '
        Me.BTN_ACTUALIZAR_ARTICULO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ACTUALIZAR_ARTICULO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_ACTUALIZAR_ARTICULO.FlatAppearance.BorderSize = 0
        Me.BTN_ACTUALIZAR_ARTICULO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACTUALIZAR_ARTICULO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTUALIZAR_ARTICULO.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR_ARTICULO.Location = New System.Drawing.Point(312, 68)
        Me.BTN_ACTUALIZAR_ARTICULO.Name = "BTN_ACTUALIZAR_ARTICULO"
        Me.BTN_ACTUALIZAR_ARTICULO.Size = New System.Drawing.Size(92, 29)
        Me.BTN_ACTUALIZAR_ARTICULO.TabIndex = 35
        Me.BTN_ACTUALIZAR_ARTICULO.Text = "INGRESAR"
        Me.BTN_ACTUALIZAR_ARTICULO.UseVisualStyleBackColor = True
        '
        'CB_ARTICULO
        '
        Me.CB_ARTICULO.FormattingEnabled = True
        Me.CB_ARTICULO.Items.AddRange(New Object() {"POR STOCK MINIMO", "DEMORA IMPORTACION"})
        Me.CB_ARTICULO.Location = New System.Drawing.Point(74, 37)
        Me.CB_ARTICULO.Name = "CB_ARTICULO"
        Me.CB_ARTICULO.Size = New System.Drawing.Size(248, 21)
        Me.CB_ARTICULO.TabIndex = 31
        Me.CB_ARTICULO.Text = "SELECCIONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "CANTIDAD"
        '
        'TXT_CANT
        '
        Me.TXT_CANT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CANT.Location = New System.Drawing.Point(328, 37)
        Me.TXT_CANT.Name = "TXT_CANT"
        Me.TXT_CANT.Size = New System.Drawing.Size(63, 20)
        Me.TXT_CANT.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "FECHA DEL REPORTE MATERIALES"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BTN_NUEVO_TRANSITO_MANUAL)
        Me.GroupBox5.Controls.Add(Me.GB_NUEVO_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.TXT_ALIAS_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.TXT_CANT_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.TXT_NOMBRE_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.DT_INI_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.DT_FIN_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.BTN_ACTUALIZAR_TRANSITO)
        Me.GroupBox5.Controls.Add(Me.TRANSITODataGridView)
        Me.GroupBox5.Location = New System.Drawing.Point(460, 159)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(567, 405)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MATERIALES EN TRANSITO"
        '
        'BTN_NUEVO_TRANSITO_MANUAL
        '
        Me.BTN_NUEVO_TRANSITO_MANUAL.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_NUEVO_TRANSITO_MANUAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_NUEVO_TRANSITO_MANUAL.FlatAppearance.BorderSize = 0
        Me.BTN_NUEVO_TRANSITO_MANUAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NUEVO_TRANSITO_MANUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NUEVO_TRANSITO_MANUAL.ForeColor = System.Drawing.Color.White
        Me.BTN_NUEVO_TRANSITO_MANUAL.Location = New System.Drawing.Point(7, 290)
        Me.BTN_NUEVO_TRANSITO_MANUAL.Name = "BTN_NUEVO_TRANSITO_MANUAL"
        Me.BTN_NUEVO_TRANSITO_MANUAL.Size = New System.Drawing.Size(185, 23)
        Me.BTN_NUEVO_TRANSITO_MANUAL.TabIndex = 28
        Me.BTN_NUEVO_TRANSITO_MANUAL.Text = "AGREGAR TRANSITO MANUAL"
        Me.BTN_NUEVO_TRANSITO_MANUAL.UseVisualStyleBackColor = True
        '
        'GB_NUEVO_TRANSITO
        '
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.BTN_INGRESAR_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.CB_NOMBRE_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.CB_ALIAS_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.TXT_CANT_NUEVO_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.DT_FIN_NUEVO_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Controls.Add(Me.DT_INI_NUEVO_TRANSITO)
        Me.GB_NUEVO_TRANSITO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_NUEVO_TRANSITO.Location = New System.Drawing.Point(3, 319)
        Me.GB_NUEVO_TRANSITO.Name = "GB_NUEVO_TRANSITO"
        Me.GB_NUEVO_TRANSITO.Size = New System.Drawing.Size(561, 83)
        Me.GB_NUEVO_TRANSITO.TabIndex = 26
        Me.GB_NUEVO_TRANSITO.TabStop = False
        Me.GB_NUEVO_TRANSITO.Text = "AGREGAR MANUAL TRANSITO NUEVO"
        Me.GB_NUEVO_TRANSITO.Visible = False
        '
        'BTN_INGRESAR_TRANSITO
        '
        Me.BTN_INGRESAR_TRANSITO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_INGRESAR_TRANSITO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INGRESAR_TRANSITO.FlatAppearance.BorderSize = 0
        Me.BTN_INGRESAR_TRANSITO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INGRESAR_TRANSITO.ForeColor = System.Drawing.Color.White
        Me.BTN_INGRESAR_TRANSITO.Location = New System.Drawing.Point(472, 51)
        Me.BTN_INGRESAR_TRANSITO.Name = "BTN_INGRESAR_TRANSITO"
        Me.BTN_INGRESAR_TRANSITO.Size = New System.Drawing.Size(89, 23)
        Me.BTN_INGRESAR_TRANSITO.TabIndex = 27
        Me.BTN_INGRESAR_TRANSITO.Text = "INGRESAR"
        Me.BTN_INGRESAR_TRANSITO.UseVisualStyleBackColor = True
        '
        'CB_NOMBRE_TRANSITO
        '
        Me.CB_NOMBRE_TRANSITO.FormattingEnabled = True
        Me.CB_NOMBRE_TRANSITO.Location = New System.Drawing.Point(102, 25)
        Me.CB_NOMBRE_TRANSITO.Name = "CB_NOMBRE_TRANSITO"
        Me.CB_NOMBRE_TRANSITO.Size = New System.Drawing.Size(211, 21)
        Me.CB_NOMBRE_TRANSITO.TabIndex = 32
        '
        'CB_ALIAS_TRANSITO
        '
        Me.CB_ALIAS_TRANSITO.FormattingEnabled = True
        Me.CB_ALIAS_TRANSITO.Location = New System.Drawing.Point(4, 25)
        Me.CB_ALIAS_TRANSITO.Name = "CB_ALIAS_TRANSITO"
        Me.CB_ALIAS_TRANSITO.Size = New System.Drawing.Size(95, 21)
        Me.CB_ALIAS_TRANSITO.TabIndex = 31
        '
        'TXT_CANT_NUEVO_TRANSITO
        '
        Me.TXT_CANT_NUEVO_TRANSITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CANT_NUEVO_TRANSITO.Location = New System.Drawing.Point(316, 25)
        Me.TXT_CANT_NUEVO_TRANSITO.Name = "TXT_CANT_NUEVO_TRANSITO"
        Me.TXT_CANT_NUEVO_TRANSITO.Size = New System.Drawing.Size(43, 20)
        Me.TXT_CANT_NUEVO_TRANSITO.TabIndex = 30
        '
        'DT_FIN_NUEVO_TRANSITO
        '
        Me.DT_FIN_NUEVO_TRANSITO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN_NUEVO_TRANSITO.Location = New System.Drawing.Point(465, 25)
        Me.DT_FIN_NUEVO_TRANSITO.Name = "DT_FIN_NUEVO_TRANSITO"
        Me.DT_FIN_NUEVO_TRANSITO.Size = New System.Drawing.Size(96, 20)
        Me.DT_FIN_NUEVO_TRANSITO.TabIndex = 27
        '
        'DT_INI_NUEVO_TRANSITO
        '
        Me.DT_INI_NUEVO_TRANSITO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI_NUEVO_TRANSITO.Location = New System.Drawing.Point(362, 25)
        Me.DT_INI_NUEVO_TRANSITO.Name = "DT_INI_NUEVO_TRANSITO"
        Me.DT_INI_NUEVO_TRANSITO.Size = New System.Drawing.Size(99, 20)
        Me.DT_INI_NUEVO_TRANSITO.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(451, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 9)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "DOBLE CLICK PARA EDITAR"
        '
        'TXT_ALIAS_TRANSITO
        '
        Me.TXT_ALIAS_TRANSITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ALIAS_TRANSITO.Enabled = False
        Me.TXT_ALIAS_TRANSITO.Location = New System.Drawing.Point(3, 241)
        Me.TXT_ALIAS_TRANSITO.Name = "TXT_ALIAS_TRANSITO"
        Me.TXT_ALIAS_TRANSITO.Size = New System.Drawing.Size(99, 20)
        Me.TXT_ALIAS_TRANSITO.TabIndex = 21
        '
        'TXT_CANT_TRANSITO
        '
        Me.TXT_CANT_TRANSITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CANT_TRANSITO.Enabled = False
        Me.TXT_CANT_TRANSITO.Location = New System.Drawing.Point(319, 241)
        Me.TXT_CANT_TRANSITO.Name = "TXT_CANT_TRANSITO"
        Me.TXT_CANT_TRANSITO.Size = New System.Drawing.Size(43, 20)
        Me.TXT_CANT_TRANSITO.TabIndex = 20
        '
        'TXT_NOMBRE_TRANSITO
        '
        Me.TXT_NOMBRE_TRANSITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOMBRE_TRANSITO.Enabled = False
        Me.TXT_NOMBRE_TRANSITO.Location = New System.Drawing.Point(105, 241)
        Me.TXT_NOMBRE_TRANSITO.Name = "TXT_NOMBRE_TRANSITO"
        Me.TXT_NOMBRE_TRANSITO.Size = New System.Drawing.Size(211, 20)
        Me.TXT_NOMBRE_TRANSITO.TabIndex = 19
        '
        'DT_INI_TRANSITO
        '
        Me.DT_INI_TRANSITO.Enabled = False
        Me.DT_INI_TRANSITO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI_TRANSITO.Location = New System.Drawing.Point(365, 241)
        Me.DT_INI_TRANSITO.Name = "DT_INI_TRANSITO"
        Me.DT_INI_TRANSITO.Size = New System.Drawing.Size(99, 20)
        Me.DT_INI_TRANSITO.TabIndex = 3
        '
        'DT_FIN_TRANSITO
        '
        Me.DT_FIN_TRANSITO.Enabled = False
        Me.DT_FIN_TRANSITO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN_TRANSITO.Location = New System.Drawing.Point(468, 241)
        Me.DT_FIN_TRANSITO.Name = "DT_FIN_TRANSITO"
        Me.DT_FIN_TRANSITO.Size = New System.Drawing.Size(96, 20)
        Me.DT_FIN_TRANSITO.TabIndex = 2
        '
        'BTN_ACTUALIZAR_TRANSITO
        '
        Me.BTN_ACTUALIZAR_TRANSITO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ACTUALIZAR_TRANSITO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ACTUALIZAR_TRANSITO.Enabled = False
        Me.BTN_ACTUALIZAR_TRANSITO.FlatAppearance.BorderSize = 0
        Me.BTN_ACTUALIZAR_TRANSITO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACTUALIZAR_TRANSITO.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR_TRANSITO.Location = New System.Drawing.Point(475, 270)
        Me.BTN_ACTUALIZAR_TRANSITO.Name = "BTN_ACTUALIZAR_TRANSITO"
        Me.BTN_ACTUALIZAR_TRANSITO.Size = New System.Drawing.Size(89, 23)
        Me.BTN_ACTUALIZAR_TRANSITO.TabIndex = 1
        Me.BTN_ACTUALIZAR_TRANSITO.Text = "ACTUALIZAR"
        Me.BTN_ACTUALIZAR_TRANSITO.UseVisualStyleBackColor = True
        '
        'TRANSITODataGridView
        '
        Me.TRANSITODataGridView.AllowUserToAddRows = False
        Me.TRANSITODataGridView.AllowUserToDeleteRows = False
        Me.TRANSITODataGridView.AllowUserToResizeColumns = False
        Me.TRANSITODataGridView.AllowUserToResizeRows = False
        Me.TRANSITODataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TRANSITODataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TRANSITODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TRANSITODataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TRANSITODataGridView.GridColor = System.Drawing.Color.White
        Me.TRANSITODataGridView.Location = New System.Drawing.Point(3, 16)
        Me.TRANSITODataGridView.MultiSelect = False
        Me.TRANSITODataGridView.Name = "TRANSITODataGridView"
        Me.TRANSITODataGridView.RowHeadersVisible = False
        Me.TRANSITODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TRANSITODataGridView.ShowCellErrors = False
        Me.TRANSITODataGridView.ShowCellToolTips = False
        Me.TRANSITODataGridView.ShowEditingIcon = False
        Me.TRANSITODataGridView.ShowRowErrors = False
        Me.TRANSITODataGridView.Size = New System.Drawing.Size(561, 205)
        Me.TRANSITODataGridView.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.BTN_AGREGAR_TRANSITO)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.BTN_AGREGAR_EXCEL_TRANISTO)
        Me.GroupBox4.Controls.Add(Me.TXT_TRANSITO)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(460, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(567, 132)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "INFORMACION DE MATERIALES EN TRANSITO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(195, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "FECHA DEL REPORTE DE COMPRAS"
        '
        'BTN_AGREGAR_TRANSITO
        '
        Me.BTN_AGREGAR_TRANSITO.Location = New System.Drawing.Point(365, 80)
        Me.BTN_AGREGAR_TRANSITO.Name = "BTN_AGREGAR_TRANSITO"
        Me.BTN_AGREGAR_TRANSITO.Size = New System.Drawing.Size(164, 47)
        Me.BTN_AGREGAR_TRANSITO.TabIndex = 20
        Me.BTN_AGREGAR_TRANSITO.Text = "CARGAR TRANSITOS"
        Me.BTN_AGREGAR_TRANSITO.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'BTN_AGREGAR_EXCEL_TRANISTO
        '
        Me.BTN_AGREGAR_EXCEL_TRANISTO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_AGREGAR_EXCEL_TRANISTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AGREGAR_EXCEL_TRANISTO.FlatAppearance.BorderSize = 0
        Me.BTN_AGREGAR_EXCEL_TRANISTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGREGAR_EXCEL_TRANISTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AGREGAR_EXCEL_TRANISTO.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_EXCEL_TRANISTO.Location = New System.Drawing.Point(306, 38)
        Me.BTN_AGREGAR_EXCEL_TRANISTO.Name = "BTN_AGREGAR_EXCEL_TRANISTO"
        Me.BTN_AGREGAR_EXCEL_TRANISTO.Size = New System.Drawing.Size(79, 20)
        Me.BTN_AGREGAR_EXCEL_TRANISTO.TabIndex = 23
        Me.BTN_AGREGAR_EXCEL_TRANISTO.Text = "ABRIR XLS"
        Me.BTN_AGREGAR_EXCEL_TRANISTO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_AGREGAR_EXCEL_TRANISTO.UseVisualStyleBackColor = True
        '
        'TXT_TRANSITO
        '
        Me.TXT_TRANSITO.Location = New System.Drawing.Point(6, 38)
        Me.TXT_TRANSITO.Name = "TXT_TRANSITO"
        Me.TXT_TRANSITO.Size = New System.Drawing.Size(294, 20)
        Me.TXT_TRANSITO.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(178, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENDIENTE DE YANIRE"
        '
        'MAT_ACTIVOSDataGridView
        '
        Me.MAT_ACTIVOSDataGridView.AllowUserToAddRows = False
        Me.MAT_ACTIVOSDataGridView.AllowUserToDeleteRows = False
        Me.MAT_ACTIVOSDataGridView.AllowUserToResizeColumns = False
        Me.MAT_ACTIVOSDataGridView.AllowUserToResizeRows = False
        Me.MAT_ACTIVOSDataGridView.AutoGenerateColumns = False
        Me.MAT_ACTIVOSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MAT_ACTIVOSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MAT_ACTIVOSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MAT_ACTIVOSDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.MAT_ACTIVOSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MAT_ACTIVOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MAT_ACTIVOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MAT_ACTIVOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_MAT_ARTICULO, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.TIPO_MATERIAL, Me.TIPO_COMPRA, Me.MIN_TIEMPO_COMPRA_DIAS, Me.MIN_STOCK, Me.ACTIVODataGridViewCheckBoxColumn})
        Me.MAT_ACTIVOSDataGridView.DataSource = Me.MAT_ACTIVOSBindingSource
        Me.MAT_ACTIVOSDataGridView.EnableHeadersVisualStyles = False
        Me.MAT_ACTIVOSDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.MAT_ACTIVOSDataGridView.Location = New System.Drawing.Point(5, 29)
        Me.MAT_ACTIVOSDataGridView.MultiSelect = False
        Me.MAT_ACTIVOSDataGridView.Name = "MAT_ACTIVOSDataGridView"
        Me.MAT_ACTIVOSDataGridView.ReadOnly = True
        Me.MAT_ACTIVOSDataGridView.RowHeadersVisible = False
        Me.MAT_ACTIVOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MAT_ACTIVOSDataGridView.ShowCellErrors = False
        Me.MAT_ACTIVOSDataGridView.ShowCellToolTips = False
        Me.MAT_ACTIVOSDataGridView.ShowEditingIcon = False
        Me.MAT_ACTIVOSDataGridView.ShowRowErrors = False
        Me.MAT_ACTIVOSDataGridView.Size = New System.Drawing.Size(834, 551)
        Me.MAT_ACTIVOSDataGridView.TabIndex = 1
        '
        'ID_MAT_ARTICULO
        '
        Me.ID_MAT_ARTICULO.DataPropertyName = "ID_MAT_ARTICULO"
        Me.ID_MAT_ARTICULO.HeaderText = "CODIGO"
        Me.ID_MAT_ARTICULO.Name = "ID_MAT_ARTICULO"
        Me.ID_MAT_ARTICULO.ReadOnly = True
        Me.ID_MAT_ARTICULO.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALIAS_ARTICULO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ALIAS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE_ARTICULO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE ARTICULO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ESTADO_ARTICULO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ESTADO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'TIPO_MATERIAL
        '
        Me.TIPO_MATERIAL.DataPropertyName = "TIPO_MATERIAL"
        Me.TIPO_MATERIAL.HeaderText = "RECURSO"
        Me.TIPO_MATERIAL.Name = "TIPO_MATERIAL"
        Me.TIPO_MATERIAL.ReadOnly = True
        Me.TIPO_MATERIAL.Width = 110
        '
        'TIPO_COMPRA
        '
        Me.TIPO_COMPRA.DataPropertyName = "TIPO_COMPRA"
        Me.TIPO_COMPRA.HeaderText = "TIPO COMPRA"
        Me.TIPO_COMPRA.Name = "TIPO_COMPRA"
        Me.TIPO_COMPRA.ReadOnly = True
        Me.TIPO_COMPRA.Width = 110
        '
        'MIN_TIEMPO_COMPRA_DIAS
        '
        Me.MIN_TIEMPO_COMPRA_DIAS.DataPropertyName = "MIN_TIEMPO_COMPRA_DIAS"
        Me.MIN_TIEMPO_COMPRA_DIAS.HeaderText = "FLETE"
        Me.MIN_TIEMPO_COMPRA_DIAS.Name = "MIN_TIEMPO_COMPRA_DIAS"
        Me.MIN_TIEMPO_COMPRA_DIAS.ReadOnly = True
        Me.MIN_TIEMPO_COMPRA_DIAS.Width = 40
        '
        'MIN_STOCK
        '
        Me.MIN_STOCK.DataPropertyName = "MIN_STOCK"
        Me.MIN_STOCK.HeaderText = "MINIMO STOCK"
        Me.MIN_STOCK.Name = "MIN_STOCK"
        Me.MIN_STOCK.ReadOnly = True
        Me.MIN_STOCK.Width = 40
        '
        'ACTIVODataGridViewCheckBoxColumn
        '
        Me.ACTIVODataGridViewCheckBoxColumn.DataPropertyName = "ACTIVO"
        Me.ACTIVODataGridViewCheckBoxColumn.HeaderText = "ACTIVO"
        Me.ACTIVODataGridViewCheckBoxColumn.Name = "ACTIVODataGridViewCheckBoxColumn"
        Me.ACTIVODataGridViewCheckBoxColumn.ReadOnly = True
        Me.ACTIVODataGridViewCheckBoxColumn.Width = 35
        '
        'MAT_ACTIVOSBindingSource
        '
        Me.MAT_ACTIVOSBindingSource.DataMember = "MAT_ACTIVOS"
        Me.MAT_ACTIVOSBindingSource.DataSource = Me.IndicesDataSet
        '
        'IndicesDataSet
        '
        Me.IndicesDataSet.DataSetName = "INDICESDataSet"
        Me.IndicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CK_ACTIVO
        '
        Me.CK_ACTIVO.AutoSize = True
        Me.CK_ACTIVO.Checked = True
        Me.CK_ACTIVO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_ACTIVO.Location = New System.Drawing.Point(485, 5)
        Me.CK_ACTIVO.Name = "CK_ACTIVO"
        Me.CK_ACTIVO.Size = New System.Drawing.Size(72, 17)
        Me.CK_ACTIVO.TabIndex = 2
        Me.CK_ACTIVO.Text = "ACTIVOS"
        Me.CK_ACTIVO.UseVisualStyleBackColor = True
        '
        'CB_ESTADO
        '
        Me.CB_ESTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ESTADO.FormattingEnabled = True
        Me.CB_ESTADO.Items.AddRange(New Object() {"NUEVO", "USADO", "REVISAR", "TODOS"})
        Me.CB_ESTADO.Location = New System.Drawing.Point(356, 3)
        Me.CB_ESTADO.Name = "CB_ESTADO"
        Me.CB_ESTADO.Size = New System.Drawing.Size(83, 21)
        Me.CB_ESTADO.TabIndex = 3
        Me.CB_ESTADO.Text = "TODOS"
        '
        'TXT_ID_ART
        '
        Me.TXT_ID_ART.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ID_ART.Location = New System.Drawing.Point(12, 3)
        Me.TXT_ID_ART.Name = "TXT_ID_ART"
        Me.TXT_ID_ART.Size = New System.Drawing.Size(63, 20)
        Me.TXT_ID_ART.TabIndex = 25
        '
        'TXT_NOMBRE_ART
        '
        Me.TXT_NOMBRE_ART.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOMBRE_ART.Location = New System.Drawing.Point(96, 3)
        Me.TXT_NOMBRE_ART.Name = "TXT_NOMBRE_ART"
        Me.TXT_NOMBRE_ART.Size = New System.Drawing.Size(235, 20)
        Me.TXT_NOMBRE_ART.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.CB_TIPO_MATERIAL)
        Me.GroupBox1.Controls.Add(Me.CK_MATERIAL_ACTIVO)
        Me.GroupBox1.Controls.Add(Me.BTN_ACTUALIZAR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CB_TIPO_COMPRA)
        Me.GroupBox1.Controls.Add(Me.LBL_MIN_STOCK)
        Me.GroupBox1.Controls.Add(Me.TXT_MIN_STOCK)
        Me.GroupBox1.Controls.Add(Me.LBL_CANT_DIAS)
        Me.GroupBox1.Controls.Add(Me.TXT_CANT_DIAS)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_PRECIO)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.FECHA_PRECIO)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(845, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 350)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DEL ARTICULO"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(157, 166)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(134, 9)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "* VALORES EXPRESADOS EN DÍAS"
        '
        'CB_TIPO_MATERIAL
        '
        Me.CB_TIPO_MATERIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TIPO_MATERIAL.FormattingEnabled = True
        Me.CB_TIPO_MATERIAL.Items.AddRange(New Object() {"CABLE", "HERRAJE", "AMPLIFICADOR", "CONECTOR", "PASIVO", "SUMINISTRO"})
        Me.CB_TIPO_MATERIAL.Location = New System.Drawing.Point(61, 61)
        Me.CB_TIPO_MATERIAL.Name = "CB_TIPO_MATERIAL"
        Me.CB_TIPO_MATERIAL.Size = New System.Drawing.Size(175, 21)
        Me.CB_TIPO_MATERIAL.TabIndex = 28
        '
        'CK_MATERIAL_ACTIVO
        '
        Me.CK_MATERIAL_ACTIVO.AutoSize = True
        Me.CK_MATERIAL_ACTIVO.Checked = True
        Me.CK_MATERIAL_ACTIVO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_MATERIAL_ACTIVO.Location = New System.Drawing.Point(6, 19)
        Me.CK_MATERIAL_ACTIVO.Name = "CK_MATERIAL_ACTIVO"
        Me.CK_MATERIAL_ACTIVO.Size = New System.Drawing.Size(96, 17)
        Me.CK_MATERIAL_ACTIVO.TabIndex = 31
        Me.CK_MATERIAL_ACTIVO.Text = "ESTA ACTIVO"
        Me.CK_MATERIAL_ACTIVO.UseVisualStyleBackColor = True
        '
        'BTN_ACTUALIZAR
        '
        Me.BTN_ACTUALIZAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ACTUALIZAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_ACTUALIZAR.FlatAppearance.BorderSize = 0
        Me.BTN_ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACTUALIZAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTUALIZAR.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR.Location = New System.Drawing.Point(196, 302)
        Me.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR"
        Me.BTN_ACTUALIZAR.Size = New System.Drawing.Size(136, 42)
        Me.BTN_ACTUALIZAR.TabIndex = 14
        Me.BTN_ACTUALIZAR.Text = "ACTUALIZAR"
        Me.BTN_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TIPO MATERIAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tipo COMPRA"
        '
        'CB_TIPO_COMPRA
        '
        Me.CB_TIPO_COMPRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TIPO_COMPRA.FormattingEnabled = True
        Me.CB_TIPO_COMPRA.Items.AddRange(New Object() {"EN PLAZA", "IMPORTACION"})
        Me.CB_TIPO_COMPRA.Location = New System.Drawing.Point(61, 105)
        Me.CB_TIPO_COMPRA.Name = "CB_TIPO_COMPRA"
        Me.CB_TIPO_COMPRA.Size = New System.Drawing.Size(175, 21)
        Me.CB_TIPO_COMPRA.TabIndex = 18
        '
        'LBL_MIN_STOCK
        '
        Me.LBL_MIN_STOCK.AutoSize = True
        Me.LBL_MIN_STOCK.Location = New System.Drawing.Point(50, 185)
        Me.LBL_MIN_STOCK.Name = "LBL_MIN_STOCK"
        Me.LBL_MIN_STOCK.Size = New System.Drawing.Size(86, 13)
        Me.LBL_MIN_STOCK.TabIndex = 19
        Me.LBL_MIN_STOCK.Text = "STOCK MINIMO"
        '
        'TXT_MIN_STOCK
        '
        Me.TXT_MIN_STOCK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_MIN_STOCK.Location = New System.Drawing.Point(158, 181)
        Me.TXT_MIN_STOCK.Name = "TXT_MIN_STOCK"
        Me.TXT_MIN_STOCK.Size = New System.Drawing.Size(76, 20)
        Me.TXT_MIN_STOCK.TabIndex = 20
        Me.TXT_MIN_STOCK.Text = "0"
        Me.TXT_MIN_STOCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_CANT_DIAS
        '
        Me.LBL_CANT_DIAS.Location = New System.Drawing.Point(30, 143)
        Me.LBL_CANT_DIAS.Name = "LBL_CANT_DIAS"
        Me.LBL_CANT_DIAS.Size = New System.Drawing.Size(126, 26)
        Me.LBL_CANT_DIAS.TabIndex = 21
        Me.LBL_CANT_DIAS.Text = "CANT. DIAS ENTREGA DEL PROVEDOR"
        Me.LBL_CANT_DIAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_CANT_DIAS
        '
        Me.TXT_CANT_DIAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CANT_DIAS.Location = New System.Drawing.Point(158, 146)
        Me.TXT_CANT_DIAS.Name = "TXT_CANT_DIAS"
        Me.TXT_CANT_DIAS.Size = New System.Drawing.Size(76, 20)
        Me.TXT_CANT_DIAS.TabIndex = 22
        Me.TXT_CANT_DIAS.Text = "0"
        Me.TXT_CANT_DIAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio $"
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PRECIO.Location = New System.Drawing.Point(150, 249)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(105, 20)
        Me.TXT_PRECIO.TabIndex = 13
        Me.TXT_PRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha de Precio $"
        '
        'FECHA_PRECIO
        '
        Me.FECHA_PRECIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_PRECIO.Location = New System.Drawing.Point(42, 249)
        Me.FECHA_PRECIO.Name = "FECHA_PRECIO"
        Me.FECHA_PRECIO.Size = New System.Drawing.Size(88, 20)
        Me.FECHA_PRECIO.TabIndex = 16
        '
        'P_BUSCAR_MAT
        '
        Me.P_BUSCAR_MAT.BackColor = System.Drawing.Color.White
        Me.P_BUSCAR_MAT.Controls.Add(Me.Label30)
        Me.P_BUSCAR_MAT.Controls.Add(Me.GroupBox1)
        Me.P_BUSCAR_MAT.Controls.Add(Me.TXT_NOMBRE_ART)
        Me.P_BUSCAR_MAT.Controls.Add(Me.TXT_ID_ART)
        Me.P_BUSCAR_MAT.Controls.Add(Me.CB_ESTADO)
        Me.P_BUSCAR_MAT.Controls.Add(Me.CK_ACTIVO)
        Me.P_BUSCAR_MAT.Controls.Add(Me.MAT_ACTIVOSDataGridView)
        Me.P_BUSCAR_MAT.Location = New System.Drawing.Point(163, 41)
        Me.P_BUSCAR_MAT.Name = "P_BUSCAR_MAT"
        Me.P_BUSCAR_MAT.Size = New System.Drawing.Size(1186, 577)
        Me.P_BUSCAR_MAT.TabIndex = 13
        Me.P_BUSCAR_MAT.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(656, 15)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(183, 13)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "* VALORES EXPRESADOS EN DÍAS"
        '
        'P_INFORME
        '
        Me.P_INFORME.BackColor = System.Drawing.Color.White
        Me.P_INFORME.Controls.Add(Me.Label28)
        Me.P_INFORME.Controls.Add(Me.Label27)
        Me.P_INFORME.Controls.Add(Me.Label23)
        Me.P_INFORME.Controls.Add(Me.Label24)
        Me.P_INFORME.Controls.Add(Me.TXT_FLETE_LOCAL)
        Me.P_INFORME.Controls.Add(Me.Label25)
        Me.P_INFORME.Controls.Add(Me.Label26)
        Me.P_INFORME.Controls.Add(Me.TXT_FLETE_IMPO)
        Me.P_INFORME.Controls.Add(Me.Label22)
        Me.P_INFORME.Controls.Add(Me.Label21)
        Me.P_INFORME.Controls.Add(Me.Label11)
        Me.P_INFORME.Controls.Add(Me.Label10)
        Me.P_INFORME.Controls.Add(Me.CB_MESES)
        Me.P_INFORME.Controls.Add(Me.Label9)
        Me.P_INFORME.Controls.Add(Me.INFORME_MATERIALESDataGridView)
        Me.P_INFORME.Controls.Add(Me.Label19)
        Me.P_INFORME.Controls.Add(Me.Label18)
        Me.P_INFORME.Controls.Add(Me.Label17)
        Me.P_INFORME.Controls.Add(Me.TXT_PREVISION_LOCAL)
        Me.P_INFORME.Controls.Add(Me.Label16)
        Me.P_INFORME.Controls.Add(Me.Label5)
        Me.P_INFORME.Controls.Add(Me.TXT_PREVISION_IMPORTACION)
        Me.P_INFORME.Controls.Add(Me.BTN_BINFORME)
        Me.P_INFORME.Controls.Add(Me.CB_BINFORME)
        Me.P_INFORME.Controls.Add(Me.BTN_BUSCAR_INFORME)
        Me.P_INFORME.Controls.Add(Me.LBL_BINFORME)
        Me.P_INFORME.Location = New System.Drawing.Point(162, 43)
        Me.P_INFORME.Name = "P_INFORME"
        Me.P_INFORME.Size = New System.Drawing.Size(1187, 561)
        Me.P_INFORME.TabIndex = 16
        Me.P_INFORME.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(266, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 13)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "TIPO DE COMPRA"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(274, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 15)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "TIEMPO DE FLETE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(375, 79)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "mes"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(375, 53)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "meses"
        '
        'TXT_FLETE_LOCAL
        '
        Me.TXT_FLETE_LOCAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_FLETE_LOCAL.Location = New System.Drawing.Point(337, 75)
        Me.TXT_FLETE_LOCAL.Name = "TXT_FLETE_LOCAL"
        Me.TXT_FLETE_LOCAL.Size = New System.Drawing.Size(36, 20)
        Me.TXT_FLETE_LOCAL.TabIndex = 37
        Me.TXT_FLETE_LOCAL.Text = "1"
        Me.TXT_FLETE_LOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(293, 79)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "LOCAL"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(252, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "IMPORTACION"
        '
        'TXT_FLETE_IMPO
        '
        Me.TXT_FLETE_IMPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_FLETE_IMPO.Location = New System.Drawing.Point(337, 49)
        Me.TXT_FLETE_IMPO.Name = "TXT_FLETE_IMPO"
        Me.TXT_FLETE_IMPO.Size = New System.Drawing.Size(36, 20)
        Me.TXT_FLETE_IMPO.TabIndex = 34
        Me.TXT_FLETE_IMPO.Text = "6"
        Me.TXT_FLETE_IMPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(41, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Ultimos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(179, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "*meses consumo promedio a calcular"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(115, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "meses"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "PERIODO DE CONSUMO"
        '
        'CB_MESES
        '
        Me.CB_MESES.FormattingEnabled = True
        Me.CB_MESES.Items.AddRange(New Object() {"1", "2", "3", "6", "9", "12", "24", "36", "48"})
        Me.CB_MESES.Location = New System.Drawing.Point(82, 49)
        Me.CB_MESES.Name = "CB_MESES"
        Me.CB_MESES.Size = New System.Drawing.Size(33, 21)
        Me.CB_MESES.TabIndex = 29
        Me.CB_MESES.Text = "9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(483, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "TIPO DE COMPRA"
        '
        'INFORME_MATERIALESDataGridView
        '
        Me.INFORME_MATERIALESDataGridView.AutoGenerateColumns = False
        Me.INFORME_MATERIALESDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.INFORME_MATERIALESDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INFORME_MATERIALESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.INFORME_MATERIALESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INFORME_MATERIALESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGOALIASDataGridViewTextBoxColumn, Me.CODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.TIPOCOMPRADataGridViewTextBoxColumn, Me.PERIODO_PROMEDIO, Me.TIEMPO_ENTREGA_FLETE, Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn, Me.TOTAL_CONSUMIDO, Me.CONSUMOxMES, Me.EXISTENCIADataGridViewTextBoxColumn, Me.STOCK_MIN_SEGUN_CONSUMO, Me.STOCKMINIMODataGridViewTextBoxColumn, Me.FECHASINSTOCKMINDataGridViewTextBoxColumn, Me.FECHASINSTOCKDataGridViewTextBoxColumn, Me.FECHACOMPRADataGridViewTextBoxColumn, Me.PREVISIONMESESDataGridViewTextBoxColumn, Me.DIASPARACOMPRADataGridViewTextBoxColumn, Me.CANTIDADACOMPRARDataGridViewTextBoxColumn})
        Me.INFORME_MATERIALESDataGridView.DataSource = Me.MAT_INFORMEBindingSource
        Me.INFORME_MATERIALESDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.INFORME_MATERIALESDataGridView.EnableHeadersVisualStyles = False
        Me.INFORME_MATERIALESDataGridView.Location = New System.Drawing.Point(0, 123)
        Me.INFORME_MATERIALESDataGridView.MultiSelect = False
        Me.INFORME_MATERIALESDataGridView.Name = "INFORME_MATERIALESDataGridView"
        Me.INFORME_MATERIALESDataGridView.ReadOnly = True
        Me.INFORME_MATERIALESDataGridView.RowHeadersVisible = False
        Me.INFORME_MATERIALESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INFORME_MATERIALESDataGridView.ShowCellErrors = False
        Me.INFORME_MATERIALESDataGridView.ShowCellToolTips = False
        Me.INFORME_MATERIALESDataGridView.ShowEditingIcon = False
        Me.INFORME_MATERIALESDataGridView.ShowRowErrors = False
        Me.INFORME_MATERIALESDataGridView.Size = New System.Drawing.Size(1187, 438)
        Me.INFORME_MATERIALESDataGridView.TabIndex = 20
        '
        'CODIGOALIASDataGridViewTextBoxColumn
        '
        Me.CODIGOALIASDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ALIAS"
        Me.CODIGOALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.CODIGOALIASDataGridViewTextBoxColumn.Name = "CODIGOALIASDataGridViewTextBoxColumn"
        Me.CODIGOALIASDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGOALIASDataGridViewTextBoxColumn.Width = 60
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "COD"
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        Me.CODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGODataGridViewTextBoxColumn.Width = 40
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIPOCOMPRADataGridViewTextBoxColumn
        '
        Me.TIPOCOMPRADataGridViewTextBoxColumn.DataPropertyName = "TIPO_COMPRA"
        Me.TIPOCOMPRADataGridViewTextBoxColumn.HeaderText = "TIPO COMPRA"
        Me.TIPOCOMPRADataGridViewTextBoxColumn.Name = "TIPOCOMPRADataGridViewTextBoxColumn"
        Me.TIPOCOMPRADataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPOCOMPRADataGridViewTextBoxColumn.Width = 80
        '
        'PERIODO_PROMEDIO
        '
        Me.PERIODO_PROMEDIO.DataPropertyName = "PERIODO_PROMEDIO"
        Me.PERIODO_PROMEDIO.HeaderText = "PERIODO PROM CONSUMO"
        Me.PERIODO_PROMEDIO.Name = "PERIODO_PROMEDIO"
        Me.PERIODO_PROMEDIO.ReadOnly = True
        Me.PERIODO_PROMEDIO.Width = 40
        '
        'TIEMPO_ENTREGA_FLETE
        '
        Me.TIEMPO_ENTREGA_FLETE.DataPropertyName = "TIEMPO_ENTREGA_FLETE"
        Me.TIEMPO_ENTREGA_FLETE.HeaderText = "FLETE"
        Me.TIEMPO_ENTREGA_FLETE.Name = "TIEMPO_ENTREGA_FLETE"
        Me.TIEMPO_ENTREGA_FLETE.ReadOnly = True
        Me.TIEMPO_ENTREGA_FLETE.Width = 40
        '
        'EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn
        '
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn.DataPropertyName = "EXISTENCIA_COMPROMETIDA"
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn.HeaderText = "EXIST COMPRO"
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn.Name = "EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn"
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn.ReadOnly = True
        Me.EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn.Width = 40
        '
        'TOTAL_CONSUMIDO
        '
        Me.TOTAL_CONSUMIDO.DataPropertyName = "TOTAL_CONSUMIDO"
        Me.TOTAL_CONSUMIDO.HeaderText = "TOTAL CONSUMIDO"
        Me.TOTAL_CONSUMIDO.Name = "TOTAL_CONSUMIDO"
        Me.TOTAL_CONSUMIDO.ReadOnly = True
        Me.TOTAL_CONSUMIDO.Width = 40
        '
        'CONSUMOxMES
        '
        Me.CONSUMOxMES.DataPropertyName = "CONSUMOxMES"
        Me.CONSUMOxMES.HeaderText = "CONSUMO POR MES"
        Me.CONSUMOxMES.Name = "CONSUMOxMES"
        Me.CONSUMOxMES.ReadOnly = True
        Me.CONSUMOxMES.Width = 40
        '
        'EXISTENCIADataGridViewTextBoxColumn
        '
        Me.EXISTENCIADataGridViewTextBoxColumn.DataPropertyName = "EXISTENCIA"
        Me.EXISTENCIADataGridViewTextBoxColumn.HeaderText = "EXISTENCIA"
        Me.EXISTENCIADataGridViewTextBoxColumn.Name = "EXISTENCIADataGridViewTextBoxColumn"
        Me.EXISTENCIADataGridViewTextBoxColumn.ReadOnly = True
        Me.EXISTENCIADataGridViewTextBoxColumn.Width = 40
        '
        'STOCK_MIN_SEGUN_CONSUMO
        '
        Me.STOCK_MIN_SEGUN_CONSUMO.DataPropertyName = "STOCK_MIN_SEGUN_CONSUMO"
        Me.STOCK_MIN_SEGUN_CONSUMO.HeaderText = "STK_MIN CONSUMO"
        Me.STOCK_MIN_SEGUN_CONSUMO.Name = "STOCK_MIN_SEGUN_CONSUMO"
        Me.STOCK_MIN_SEGUN_CONSUMO.ReadOnly = True
        Me.STOCK_MIN_SEGUN_CONSUMO.Width = 40
        '
        'STOCKMINIMODataGridViewTextBoxColumn
        '
        Me.STOCKMINIMODataGridViewTextBoxColumn.DataPropertyName = "STOCK_MINIMO"
        Me.STOCKMINIMODataGridViewTextBoxColumn.HeaderText = "STK_MIN"
        Me.STOCKMINIMODataGridViewTextBoxColumn.Name = "STOCKMINIMODataGridViewTextBoxColumn"
        Me.STOCKMINIMODataGridViewTextBoxColumn.ReadOnly = True
        Me.STOCKMINIMODataGridViewTextBoxColumn.Width = 40
        '
        'FECHASINSTOCKMINDataGridViewTextBoxColumn
        '
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "FECHA_SIN_STOCK_MIN"
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn.HeaderText = "F.S/STK MIN"
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn.Name = "FECHASINSTOCKMINDataGridViewTextBoxColumn"
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHASINSTOCKMINDataGridViewTextBoxColumn.Width = 75
        '
        'FECHASINSTOCKDataGridViewTextBoxColumn
        '
        Me.FECHASINSTOCKDataGridViewTextBoxColumn.DataPropertyName = "FECHA_SIN_STOCK"
        Me.FECHASINSTOCKDataGridViewTextBoxColumn.HeaderText = "F.S/STK"
        Me.FECHASINSTOCKDataGridViewTextBoxColumn.Name = "FECHASINSTOCKDataGridViewTextBoxColumn"
        Me.FECHASINSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHASINSTOCKDataGridViewTextBoxColumn.Width = 75
        '
        'FECHACOMPRADataGridViewTextBoxColumn
        '
        Me.FECHACOMPRADataGridViewTextBoxColumn.DataPropertyName = "FECHA_COMPRA"
        Me.FECHACOMPRADataGridViewTextBoxColumn.HeaderText = "F.COMPRA"
        Me.FECHACOMPRADataGridViewTextBoxColumn.Name = "FECHACOMPRADataGridViewTextBoxColumn"
        Me.FECHACOMPRADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHACOMPRADataGridViewTextBoxColumn.Width = 90
        '
        'PREVISIONMESESDataGridViewTextBoxColumn
        '
        Me.PREVISIONMESESDataGridViewTextBoxColumn.DataPropertyName = "PREVISION_MESES"
        Me.PREVISIONMESESDataGridViewTextBoxColumn.HeaderText = "PREV"
        Me.PREVISIONMESESDataGridViewTextBoxColumn.Name = "PREVISIONMESESDataGridViewTextBoxColumn"
        Me.PREVISIONMESESDataGridViewTextBoxColumn.ReadOnly = True
        Me.PREVISIONMESESDataGridViewTextBoxColumn.Width = 40
        '
        'DIASPARACOMPRADataGridViewTextBoxColumn
        '
        Me.DIASPARACOMPRADataGridViewTextBoxColumn.DataPropertyName = "DIAS_PARA_COMPRA"
        Me.DIASPARACOMPRADataGridViewTextBoxColumn.HeaderText = "DIAS COMPRA"
        Me.DIASPARACOMPRADataGridViewTextBoxColumn.Name = "DIASPARACOMPRADataGridViewTextBoxColumn"
        Me.DIASPARACOMPRADataGridViewTextBoxColumn.ReadOnly = True
        Me.DIASPARACOMPRADataGridViewTextBoxColumn.Width = 40
        '
        'CANTIDADACOMPRARDataGridViewTextBoxColumn
        '
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_A_COMPRAR"
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn.HeaderText = "CANT COMP"
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn.Name = "CANTIDADACOMPRARDataGridViewTextBoxColumn"
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANTIDADACOMPRARDataGridViewTextBoxColumn.Width = 40
        '
        'MAT_INFORMEBindingSource
        '
        Me.MAT_INFORMEBindingSource.DataMember = "MAT_INFORME"
        Me.MAT_INFORMEBindingSource.DataSource = Me.IndicesDataSet
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(526, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "PREVISION"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(615, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "meses"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(615, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "meses"
        '
        'TXT_PREVISION_LOCAL
        '
        Me.TXT_PREVISION_LOCAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PREVISION_LOCAL.Location = New System.Drawing.Point(577, 75)
        Me.TXT_PREVISION_LOCAL.Name = "TXT_PREVISION_LOCAL"
        Me.TXT_PREVISION_LOCAL.Size = New System.Drawing.Size(36, 20)
        Me.TXT_PREVISION_LOCAL.TabIndex = 24
        Me.TXT_PREVISION_LOCAL.Text = "3"
        Me.TXT_PREVISION_LOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(533, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "LOCAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(492, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "IMPORTACION"
        '
        'TXT_PREVISION_IMPORTACION
        '
        Me.TXT_PREVISION_IMPORTACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PREVISION_IMPORTACION.Location = New System.Drawing.Point(577, 49)
        Me.TXT_PREVISION_IMPORTACION.Name = "TXT_PREVISION_IMPORTACION"
        Me.TXT_PREVISION_IMPORTACION.Size = New System.Drawing.Size(36, 20)
        Me.TXT_PREVISION_IMPORTACION.TabIndex = 21
        Me.TXT_PREVISION_IMPORTACION.Text = "9"
        Me.TXT_PREVISION_IMPORTACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BINFORME
        '
        Me.BTN_BINFORME.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_BINFORME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_BINFORME.FlatAppearance.BorderSize = 0
        Me.BTN_BINFORME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BINFORME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BINFORME.ForeColor = System.Drawing.Color.White
        Me.BTN_BINFORME.Location = New System.Drawing.Point(1063, 73)
        Me.BTN_BINFORME.Name = "BTN_BINFORME"
        Me.BTN_BINFORME.Size = New System.Drawing.Size(74, 27)
        Me.BTN_BINFORME.TabIndex = 20
        Me.BTN_BINFORME.Text = "BUSCAR"
        Me.BTN_BINFORME.UseVisualStyleBackColor = True
        '
        'CB_BINFORME
        '
        Me.CB_BINFORME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_BINFORME.FormattingEnabled = True
        Me.CB_BINFORME.Location = New System.Drawing.Point(934, 79)
        Me.CB_BINFORME.Name = "CB_BINFORME"
        Me.CB_BINFORME.Size = New System.Drawing.Size(121, 21)
        Me.CB_BINFORME.TabIndex = 13
        Me.CB_BINFORME.Text = "SELECCIONE"
        '
        'BTN_BUSCAR_INFORME
        '
        Me.BTN_BUSCAR_INFORME.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_BUSCAR_INFORME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_BUSCAR_INFORME.FlatAppearance.BorderSize = 0
        Me.BTN_BUSCAR_INFORME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BUSCAR_INFORME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BUSCAR_INFORME.ForeColor = System.Drawing.Color.White
        Me.BTN_BUSCAR_INFORME.Location = New System.Drawing.Point(672, 49)
        Me.BTN_BUSCAR_INFORME.Name = "BTN_BUSCAR_INFORME"
        Me.BTN_BUSCAR_INFORME.Size = New System.Drawing.Size(136, 49)
        Me.BTN_BUSCAR_INFORME.TabIndex = 19
        Me.BTN_BUSCAR_INFORME.Text = "GENERAR NUEVO INFORME"
        Me.BTN_BUSCAR_INFORME.UseVisualStyleBackColor = True
        '
        'LBL_BINFORME
        '
        Me.LBL_BINFORME.AutoSize = True
        Me.LBL_BINFORME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_BINFORME.Location = New System.Drawing.Point(936, 57)
        Me.LBL_BINFORME.Name = "LBL_BINFORME"
        Me.LBL_BINFORME.Size = New System.Drawing.Size(107, 13)
        Me.LBL_BINFORME.TabIndex = 12
        Me.LBL_BINFORME.Text = "CARGAR INFORME:"
        '
        'BTN_GENERAR_INFORME
        '
        Me.BTN_GENERAR_INFORME.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_GENERAR_INFORME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_GENERAR_INFORME.FlatAppearance.BorderSize = 0
        Me.BTN_GENERAR_INFORME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GENERAR_INFORME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GENERAR_INFORME.ForeColor = System.Drawing.Color.White
        Me.BTN_GENERAR_INFORME.Location = New System.Drawing.Point(12, 188)
        Me.BTN_GENERAR_INFORME.Name = "BTN_GENERAR_INFORME"
        Me.BTN_GENERAR_INFORME.Size = New System.Drawing.Size(136, 49)
        Me.BTN_GENERAR_INFORME.TabIndex = 18
        Me.BTN_GENERAR_INFORME.Text = "INFORMES"
        Me.BTN_GENERAR_INFORME.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1287, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "CERRAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_export.FlatAppearance.BorderSize = 0
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.Location = New System.Drawing.Point(12, 483)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(136, 42)
        Me.btn_export.TabIndex = 32
        Me.btn_export.Text = "exportar"
        Me.btn_export.UseVisualStyleBackColor = True
        Me.btn_export.Visible = False
        '
        'MAT_ACTIVOSTableAdapter
        '
        Me.MAT_ACTIVOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIMATableAdapter = Nothing
        Me.TableAdapterManager.GUARDIASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_CALLESTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_DIAGNOSTICOTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_FALLASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_FRECUENCIASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_MEDIDORTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_PUNTOMEDIDATableAdapter = Nothing
        Me.TableAdapterManager.INDICE_TIPOMEDIDATableAdapter = Nothing
        Me.TableAdapterManager.MAT_ACTIVOSTableAdapter = Me.MAT_ACTIVOSTableAdapter
        Me.TableAdapterManager.MAT_CONSOLIDADOTableAdapter = Nothing
        Me.TableAdapterManager.MAT_CONSUMOSXMESTableAdapter = Nothing
        Me.TableAdapterManager.MAT_INFORMETableAdapter = Nothing
        Me.TableAdapterManager.MAT_STOCKTableAdapter = Nothing
        Me.TableAdapterManager.MAT_TRANSITOTableAdapter = Nothing
        Me.TableAdapterManager.ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.PLANOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.INDICESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MAT_CONSOLIDADOBindingSource
        '
        Me.MAT_CONSOLIDADOBindingSource.DataMember = "MAT_CONSOLIDADO"
        Me.MAT_CONSOLIDADOBindingSource.DataSource = Me.IndicesDataSet
        '
        'MAT_CONSOLIDADOTableAdapter
        '
        Me.MAT_CONSOLIDADOTableAdapter.ClearBeforeFill = True
        '
        'MAT_CONSUMOSXMESBindingSource
        '
        Me.MAT_CONSUMOSXMESBindingSource.DataMember = "MAT_CONSUMOSXMES"
        Me.MAT_CONSUMOSXMESBindingSource.DataSource = Me.IndicesDataSet
        '
        'MAT_CONSUMOSXMESTableAdapter
        '
        Me.MAT_CONSUMOSXMESTableAdapter.ClearBeforeFill = True
        '
        'MAT_STOCKBindingSource
        '
        Me.MAT_STOCKBindingSource.DataMember = "MAT_STOCK"
        Me.MAT_STOCKBindingSource.DataSource = Me.IndicesDataSet
        '
        'MAT_STOCKTableAdapter
        '
        Me.MAT_STOCKTableAdapter.ClearBeforeFill = True
        '
        'MAT_TRANSITOBindingSource
        '
        Me.MAT_TRANSITOBindingSource.DataMember = "MAT_TRANSITO"
        Me.MAT_TRANSITOBindingSource.DataSource = Me.IndicesDataSet
        '
        'MAT_TRANSITOTableAdapter
        '
        Me.MAT_TRANSITOTableAdapter.ClearBeforeFill = True
        '
        'IndicesDataSet1
        '
        Me.IndicesDataSet1.DataSetName = "INDICESDataSet"
        Me.IndicesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MAT_INFORMETableAdapter
        '
        Me.MAT_INFORMETableAdapter.ClearBeforeFill = True
        '
        'MATERIALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1377, 788)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BTN_GENERAR_INFORME)
        Me.Controls.Add(Me.P_INFERIOR)
        Me.Controls.Add(Me.BTN_CONTROL_MATERIAL)
        Me.Controls.Add(Me.BTN_BUSCAR_MAT)
        Me.Controls.Add(Me.BTN_VER_PanelINGRESO)
        Me.Controls.Add(Me.P_INFORME)
        Me.Controls.Add(Me.P_BUSCAR_MAT)
        Me.Controls.Add(Me.P_INGRESO)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MATERIALES"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.P_INFERIOR.ResumeLayout(False)
        Me.P_INGRESO.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GB_AGREGAR_STOCK_MANUAL.ResumeLayout(False)
        Me.GB_AGREGAR_STOCK_MANUAL.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GB_NUEVO_TRANSITO.ResumeLayout(False)
        Me.GB_NUEVO_TRANSITO.PerformLayout()
        CType(Me.TRANSITODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.MAT_ACTIVOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_ACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.P_BUSCAR_MAT.ResumeLayout(False)
        Me.P_BUSCAR_MAT.PerformLayout()
        Me.P_INFORME.ResumeLayout(False)
        Me.P_INFORME.PerformLayout()
        CType(Me.INFORME_MATERIALESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_INFORMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_CONSOLIDADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_CONSUMOSXMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_TRANSITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub





    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

    Friend WithEvents BTN_VER_PanelINGRESO As Button
    Friend WithEvents BTN_BUSCAR_MAT As Button
    Friend WithEvents BTN_CONTROL_MATERIAL As Button
    Friend WithEvents BTN_MAS As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents P_INFERIOR As Panel
    Friend WithEvents DT_FECHA As DateTimePicker
    Friend WithEvents TXT_PATH As TextBox
    Friend WithEvents BTN_CARGAR As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents BTN_ABRIR_OPENFILE As Button
    Friend WithEvents P_INGRESO As Panel
    Friend WithEvents MAT_ACTIVOSDataGridView As DataGridView
    Friend WithEvents CK_ACTIVO As CheckBox
    Friend WithEvents CB_ESTADO As ComboBox
    Friend WithEvents TXT_ID_ART As TextBox
    Friend WithEvents TXT_NOMBRE_ART As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_TIPO_MATERIAL As ComboBox
    Friend WithEvents CK_MATERIAL_ACTIVO As CheckBox
    Friend WithEvents BTN_ACTUALIZAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_TIPO_COMPRA As ComboBox
    Friend WithEvents LBL_MIN_STOCK As Label
    Friend WithEvents TXT_MIN_STOCK As TextBox
    Friend WithEvents LBL_CANT_DIAS As Label
    Friend WithEvents TXT_CANT_DIAS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FECHA_PRECIO As DateTimePicker
    Friend WithEvents P_BUSCAR_MAT As Panel
    Friend WithEvents BTN_GENERAR_INFORME As Button
    Friend WithEvents P_INFORME As Panel
    Friend WithEvents BTN_CARGAR_CONSOLIDADO As Button
    Friend WithEvents IDMATARTICULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREARTICULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASARTICULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADOARTICULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BTN_BUSCAR_INFORME As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BTN_BINFORME As Button
    Friend WithEvents CB_BINFORME As ComboBox
    Friend WithEvents LBL_BINFORME As Label
    Friend WithEvents btn_export As Button
    Friend WithEvents BTN_ABRIR_CONSOLIDADO As Button
    Friend WithEvents TXT_CONSOLIDADO As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_AGREGAR_TRANSITO As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BTN_AGREGAR_EXCEL_TRANISTO As Button
    Friend WithEvents TXT_TRANSITO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_ALIAS_TRANSITO As TextBox
    Friend WithEvents TXT_CANT_TRANSITO As TextBox
    Friend WithEvents TXT_NOMBRE_TRANSITO As TextBox
    Friend WithEvents DT_INI_TRANSITO As DateTimePicker
    Friend WithEvents DT_FIN_TRANSITO As DateTimePicker
    Friend WithEvents BTN_ACTUALIZAR_TRANSITO As Button
    Friend WithEvents TRANSITODataGridView As DataGridView
    Friend WithEvents BTN_NUEVO_TRANSITO_MANUAL As Button
    Friend WithEvents GB_NUEVO_TRANSITO As GroupBox
    Friend WithEvents BTN_INGRESAR_TRANSITO As Button
    Friend WithEvents CB_NOMBRE_TRANSITO As ComboBox
    Friend WithEvents CB_ALIAS_TRANSITO As ComboBox
    Friend WithEvents TXT_CANT_NUEVO_TRANSITO As TextBox
    Friend WithEvents DT_FIN_NUEVO_TRANSITO As DateTimePicker
    Friend WithEvents DT_INI_NUEVO_TRANSITO As DateTimePicker
    Friend WithEvents BTN_AGREGAR_ARTICULO_MANUAL As Button
    Friend WithEvents GB_AGREGAR_STOCK_MANUAL As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_ACTUALIZAR_ARTICULO As Button
    Friend WithEvents CB_ARTICULO As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CANT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_ALIAS As ComboBox
    Friend WithEvents INFORME_MATERIALESDataGridView As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_PREVISION_LOCAL As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_PREVISION_IMPORTACION As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents LBL_CONSOLIDADO_ULTIMA As Label
    Friend WithEvents IndicesDataSet As INDICESDataSet
    Friend WithEvents MAT_ACTIVOSBindingSource As BindingSource
    Friend WithEvents MAT_ACTIVOSTableAdapter As INDICESDataSetTableAdapters.MAT_ACTIVOSTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MAT_CONSOLIDADOBindingSource As BindingSource
    Friend WithEvents MAT_CONSOLIDADOTableAdapter As INDICESDataSetTableAdapters.MAT_CONSOLIDADOTableAdapter
    Friend WithEvents MAT_CONSUMOSXMESBindingSource As BindingSource
    Friend WithEvents MAT_CONSUMOSXMESTableAdapter As INDICESDataSetTableAdapters.MAT_CONSUMOSXMESTableAdapter
    Friend WithEvents MAT_INFORMEBindingSource As BindingSource
    Friend WithEvents MAT_STOCKBindingSource As BindingSource
    Friend WithEvents MAT_STOCKTableAdapter As INDICESDataSetTableAdapters.MAT_STOCKTableAdapter
    Friend WithEvents MAT_TRANSITOBindingSource As BindingSource
    Friend WithEvents MAT_TRANSITOTableAdapter As INDICESDataSetTableAdapters.MAT_TRANSITOTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_CALCULAR_PROMEDIO As Button
    Friend WithEvents lbl_mes As Label
    Friend WithEvents CB_FECHA As ComboBox
    Friend WithEvents lbl_año As Label
    Friend WithEvents CB_ANIO As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CB_MESES As ComboBox
    Friend WithEvents TIEMPOENTREGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONSUMOxDIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIACOMPROMETIDANUEVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIANUEVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIAUSADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIACOMPROMETIDAUSADADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndicesDataSet1 As INDICESDataSet
    Friend WithEvents Label22 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TXT_FLETE_LOCAL As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TXT_FLETE_IMPO As TextBox
    Friend WithEvents MAT_INFORMETableAdapter As INDICESDataSetTableAdapters.MAT_INFORMETableAdapter
    Friend WithEvents Label28 As Label
    Friend WithEvents CODIGOALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOCOMPRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PERIODO_PROMEDIO As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPO_ENTREGA_FLETE As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIACOMPROMETIDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_CONSUMIDO As DataGridViewTextBoxColumn
    Friend WithEvents CONSUMOxMES As DataGridViewTextBoxColumn
    Friend WithEvents EXISTENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOCK_MIN_SEGUN_CONSUMO As DataGridViewTextBoxColumn
    Friend WithEvents STOCKMINIMODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHASINSTOCKMINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHASINSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHACOMPRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREVISIONMESESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIASPARACOMPRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADACOMPRARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_MAT_ARTICULO As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_MATERIAL As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents MIN_TIEMPO_COMPRA_DIAS As DataGridViewTextBoxColumn
    Friend WithEvents MIN_STOCK As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
End Class
