<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SERVICIOS
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
        Dim TIPOLabel As System.Windows.Forms.Label
        Dim SECTOROPELabel As System.Windows.Forms.Label
        Dim FECHASOLLabel As System.Windows.Forms.Label
        Dim FECHAINICIOLabel As System.Windows.Forms.Label
        Dim FECHAFINLabel As System.Windows.Forms.Label
        Dim PRIORIDADLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim GENERADORLabel As System.Windows.Forms.Label
        Dim SOLICITANTELabel As System.Windows.Forms.Label
        Dim CUADRILLALabel As System.Windows.Forms.Label
        Dim MOTIVOORIGENLabel As System.Windows.Forms.Label
        Dim CAUSARIGENLabel As System.Windows.Forms.Label
        Dim MOTIVOCIERRELabel As System.Windows.Forms.Label
        Dim CAUSACIERRELabel As System.Windows.Forms.Label
        Dim ATRIBUTOLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim NRO_ORDENINTLabel As System.Windows.Forms.Label
        Dim ID_GESTIONLabel As System.Windows.Forms.Label
        Dim ID_TRABAJOLabel As System.Windows.Forms.Label
        Dim ORDEN_OCLabel As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.INDICE_CALLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICE_CALLESTableAdapter = New REDES.INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.DGV_ORDENES = New System.Windows.Forms.DataGridView()
        Me.OC_APROBADO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_CANT_OBRAC = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ORDEN_OCTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TRABAJOTextBox = New System.Windows.Forms.TextBox()
        Me.ID_GESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.NRO_ORDENINTTextBox = New System.Windows.Forms.TextBox()
        Me.DOCUMENTO_FISICOCheckBox = New System.Windows.Forms.CheckBox()
        Me.ATRIBUTOTextBox = New System.Windows.Forms.TextBox()
        Me.CAUSACIERRETextBox = New System.Windows.Forms.TextBox()
        Me.MOTIVOCIERRETextBox = New System.Windows.Forms.TextBox()
        Me.CAUSARIGENTextBox = New System.Windows.Forms.TextBox()
        Me.MOTIVOORIGENTextBox = New System.Windows.Forms.TextBox()
        Me.CUADRILLATextBox = New System.Windows.Forms.TextBox()
        Me.SOLICITANTETextBox = New System.Windows.Forms.TextBox()
        Me.GENERADORTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.PRIORIDADTextBox = New System.Windows.Forms.TextBox()
        Me.SECTOROPETextBox = New System.Windows.Forms.TextBox()
        Me.TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.GB_NUEVO = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TXT_CANT_OC = New System.Windows.Forms.TextBox()
        Me.DGV_ADJUNTO = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CB_CAUSAS = New System.Windows.Forms.ComboBox()
        Me.INDICE_CALLESDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_MAN = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT_SEG = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.IND_CALLE = New System.Windows.Forms.Label()
        Me.TXT_SEC = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.BTN_INGRESAR = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_OBS = New System.Windows.Forms.TextBox()
        Me.BTN_ADJUNTAR = New System.Windows.Forms.Button()
        Me.CK_DOCUMENTO_FISICO = New System.Windows.Forms.CheckBox()
        Me.LBL_OC = New System.Windows.Forms.Label()
        Me.TXT_ORDEN_OC = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CB_PRIORIDAD = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_ATRIBUTO = New System.Windows.Forms.ComboBox()
        Me.CB_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_ESQ2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_ESQ1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_ZONA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_NODO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_CALLE = New System.Windows.Forms.TextBox()
        Me.TXT_NRO = New System.Windows.Forms.TextBox()
        Me.ListArchivos = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_OC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_ORDENINT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CK_STATUS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_ING_NRO = New System.Windows.Forms.TextBox()
        Me.TXT_ING_CALLE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FILTRO_ZONA = New System.Windows.Forms.TextBox()
        Me.BUSCA_NODO = New System.Windows.Forms.ComboBox()
        Me.LBLNODO = New System.Windows.Forms.Label()
        Me.INDICE_CAUSASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICE_CAUSASTableAdapter = New REDES.INDICESDataSetTableAdapters.INDICE_CAUSASTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OBS_CIERRE = New System.Windows.Forms.TextBox()
        Me.OBS_ORIGEN = New System.Windows.Forms.TextBox()
        Me.CALLESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OBESERVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUNCIONARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECTORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HISTORICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_APROBAR = New System.Windows.Forms.Button()
        Me.BTN_REFRESCAR = New System.Windows.Forms.Button()
        Me.NROORDENINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGESTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTRABAJODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINGRESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAASIGNADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIORIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NODODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANZANADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATRIBUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ORDENESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.NOMARCHIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADJUNTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORMESERVICIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.OBESERVACIONESTableAdapter = New REDES.ORDENESDataSetTableAdapters.OBESERVACIONESTableAdapter()
        Me.FUNCIONARIOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.FUNCIONARIOSTableAdapter()
        Me.SECTORESTableAdapter = New REDES.ORDENESDataSetTableAdapters.SECTORESTableAdapter()
        Me.HISTORICOTableAdapter = New REDES.ORDENESDataSetTableAdapters.HISTORICOTableAdapter()
        Me.ADJUNTOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.ADJUNTOSTableAdapter()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.HISTORICOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesDataSet1 = New REDES.ORDENESDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        TIPOLabel = New System.Windows.Forms.Label()
        SECTOROPELabel = New System.Windows.Forms.Label()
        FECHASOLLabel = New System.Windows.Forms.Label()
        FECHAINICIOLabel = New System.Windows.Forms.Label()
        FECHAFINLabel = New System.Windows.Forms.Label()
        PRIORIDADLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        GENERADORLabel = New System.Windows.Forms.Label()
        SOLICITANTELabel = New System.Windows.Forms.Label()
        CUADRILLALabel = New System.Windows.Forms.Label()
        MOTIVOORIGENLabel = New System.Windows.Forms.Label()
        CAUSARIGENLabel = New System.Windows.Forms.Label()
        MOTIVOCIERRELabel = New System.Windows.Forms.Label()
        CAUSACIERRELabel = New System.Windows.Forms.Label()
        ATRIBUTOLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        NRO_ORDENINTLabel = New System.Windows.Forms.Label()
        ID_GESTIONLabel = New System.Windows.Forms.Label()
        ID_TRABAJOLabel = New System.Windows.Forms.Label()
        ORDEN_OCLabel = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ORDENES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GB_NUEVO.SuspendLayout()
        CType(Me.DGV_ADJUNTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CAUSASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CALLESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OBESERVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECTORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADJUNTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMESERVICIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORICOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.ForeColor = System.Drawing.Color.White
        TIPOLabel.Location = New System.Drawing.Point(214, 8)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(35, 13)
        TIPOLabel.TabIndex = 6
        TIPOLabel.Text = "TIPO:"
        '
        'SECTOROPELabel
        '
        SECTOROPELabel.AutoSize = True
        SECTOROPELabel.ForeColor = System.Drawing.Color.White
        SECTOROPELabel.Location = New System.Drawing.Point(174, 30)
        SECTOROPELabel.Name = "SECTOROPELabel"
        SECTOROPELabel.Size = New System.Drawing.Size(76, 13)
        SECTOROPELabel.TabIndex = 8
        SECTOROPELabel.Text = "SECTOROPE:"
        '
        'FECHASOLLabel
        '
        FECHASOLLabel.AutoSize = True
        FECHASOLLabel.ForeColor = System.Drawing.Color.White
        FECHASOLLabel.Location = New System.Drawing.Point(363, 8)
        FECHASOLLabel.Name = "FECHASOLLabel"
        FECHASOLLabel.Size = New System.Drawing.Size(66, 13)
        FECHASOLLabel.TabIndex = 10
        FECHASOLLabel.Text = "FECHASOL:"
        '
        'FECHAINICIOLabel
        '
        FECHAINICIOLabel.AutoSize = True
        FECHAINICIOLabel.ForeColor = System.Drawing.Color.White
        FECHAINICIOLabel.Location = New System.Drawing.Point(352, 30)
        FECHAINICIOLabel.Name = "FECHAINICIOLabel"
        FECHAINICIOLabel.Size = New System.Drawing.Size(77, 13)
        FECHAINICIOLabel.TabIndex = 12
        FECHAINICIOLabel.Text = "FECHAINICIO:"
        '
        'FECHAFINLabel
        '
        FECHAFINLabel.AutoSize = True
        FECHAFINLabel.ForeColor = System.Drawing.Color.White
        FECHAFINLabel.Location = New System.Drawing.Point(367, 52)
        FECHAFINLabel.Name = "FECHAFINLabel"
        FECHAFINLabel.Size = New System.Drawing.Size(62, 13)
        FECHAFINLabel.TabIndex = 14
        FECHAFINLabel.Text = "FECHAFIN:"
        '
        'PRIORIDADLabel
        '
        PRIORIDADLabel.AutoSize = True
        PRIORIDADLabel.ForeColor = System.Drawing.Color.White
        PRIORIDADLabel.Location = New System.Drawing.Point(359, 73)
        PRIORIDADLabel.Name = "PRIORIDADLabel"
        PRIORIDADLabel.Size = New System.Drawing.Size(70, 13)
        PRIORIDADLabel.TabIndex = 16
        PRIORIDADLabel.Text = "PRIORIDAD:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.ForeColor = System.Drawing.Color.White
        STATUSLabel.Location = New System.Drawing.Point(563, 51)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 18
        STATUSLabel.Text = "STATUS:"
        '
        'GENERADORLabel
        '
        GENERADORLabel.AutoSize = True
        GENERADORLabel.ForeColor = System.Drawing.Color.White
        GENERADORLabel.Location = New System.Drawing.Point(537, 6)
        GENERADORLabel.Name = "GENERADORLabel"
        GENERADORLabel.Size = New System.Drawing.Size(79, 13)
        GENERADORLabel.TabIndex = 20
        GENERADORLabel.Text = "GENERADOR:"
        '
        'SOLICITANTELabel
        '
        SOLICITANTELabel.AutoSize = True
        SOLICITANTELabel.ForeColor = System.Drawing.Color.White
        SOLICITANTELabel.Location = New System.Drawing.Point(536, 72)
        SOLICITANTELabel.Name = "SOLICITANTELabel"
        SOLICITANTELabel.Size = New System.Drawing.Size(80, 13)
        SOLICITANTELabel.TabIndex = 22
        SOLICITANTELabel.Text = "SOLICITANTE:"
        SOLICITANTELabel.Visible = False
        '
        'CUADRILLALabel
        '
        CUADRILLALabel.AutoSize = True
        CUADRILLALabel.ForeColor = System.Drawing.Color.White
        CUADRILLALabel.Location = New System.Drawing.Point(546, 28)
        CUADRILLALabel.Name = "CUADRILLALabel"
        CUADRILLALabel.Size = New System.Drawing.Size(70, 13)
        CUADRILLALabel.TabIndex = 24
        CUADRILLALabel.Text = "CUADRILLA:"
        '
        'MOTIVOORIGENLabel
        '
        MOTIVOORIGENLabel.AutoSize = True
        MOTIVOORIGENLabel.ForeColor = System.Drawing.Color.White
        MOTIVOORIGENLabel.Location = New System.Drawing.Point(728, 6)
        MOTIVOORIGENLabel.Name = "MOTIVOORIGENLabel"
        MOTIVOORIGENLabel.Size = New System.Drawing.Size(94, 13)
        MOTIVOORIGENLabel.TabIndex = 38
        MOTIVOORIGENLabel.Text = "MOTIVOORIGEN:"
        '
        'CAUSARIGENLabel
        '
        CAUSARIGENLabel.AutoSize = True
        CAUSARIGENLabel.ForeColor = System.Drawing.Color.White
        CAUSARIGENLabel.Location = New System.Drawing.Point(742, 28)
        CAUSARIGENLabel.Name = "CAUSARIGENLabel"
        CAUSARIGENLabel.Size = New System.Drawing.Size(80, 13)
        CAUSARIGENLabel.TabIndex = 40
        CAUSARIGENLabel.Text = "CAUSARIGEN:"
        '
        'MOTIVOCIERRELabel
        '
        MOTIVOCIERRELabel.AutoSize = True
        MOTIVOCIERRELabel.ForeColor = System.Drawing.Color.White
        MOTIVOCIERRELabel.Location = New System.Drawing.Point(730, 50)
        MOTIVOCIERRELabel.Name = "MOTIVOCIERRELabel"
        MOTIVOCIERRELabel.Size = New System.Drawing.Size(92, 13)
        MOTIVOCIERRELabel.TabIndex = 42
        MOTIVOCIERRELabel.Text = "MOTIVOCIERRE:"
        '
        'CAUSACIERRELabel
        '
        CAUSACIERRELabel.AutoSize = True
        CAUSACIERRELabel.ForeColor = System.Drawing.Color.White
        CAUSACIERRELabel.Location = New System.Drawing.Point(736, 73)
        CAUSACIERRELabel.Name = "CAUSACIERRELabel"
        CAUSACIERRELabel.Size = New System.Drawing.Size(86, 13)
        CAUSACIERRELabel.TabIndex = 44
        CAUSACIERRELabel.Text = "CAUSACIERRE:"
        '
        'ATRIBUTOLabel
        '
        ATRIBUTOLabel.AutoSize = True
        ATRIBUTOLabel.ForeColor = System.Drawing.Color.White
        ATRIBUTOLabel.Location = New System.Drawing.Point(185, 52)
        ATRIBUTOLabel.Name = "ATRIBUTOLabel"
        ATRIBUTOLabel.Size = New System.Drawing.Size(65, 13)
        ATRIBUTOLabel.TabIndex = 46
        ATRIBUTOLabel.Text = "ATRIBUTO:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.ForeColor = System.Drawing.Color.White
        Label9.Location = New System.Drawing.Point(6, 5)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(143, 13)
        Label9.TabIndex = 4
        Label9.Text = "OBSERVACIONES ORIGEN"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.ForeColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(542, 5)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(141, 13)
        Label10.TabIndex = 6
        Label10.Text = "OBSERVACIONES CIERRE"
        '
        'NRO_ORDENINTLabel
        '
        NRO_ORDENINTLabel.AutoSize = True
        NRO_ORDENINTLabel.ForeColor = System.Drawing.Color.White
        NRO_ORDENINTLabel.Location = New System.Drawing.Point(5, 51)
        NRO_ORDENINTLabel.Name = "NRO_ORDENINTLabel"
        NRO_ORDENINTLabel.Size = New System.Drawing.Size(70, 13)
        NRO_ORDENINTLabel.TabIndex = 51
        NRO_ORDENINTLabel.Text = "ORDEN INT:"
        '
        'ID_GESTIONLabel
        '
        ID_GESTIONLabel.AutoSize = True
        ID_GESTIONLabel.ForeColor = System.Drawing.Color.White
        ID_GESTIONLabel.Location = New System.Drawing.Point(3, 7)
        ID_GESTIONLabel.Name = "ID_GESTIONLabel"
        ID_GESTIONLabel.Size = New System.Drawing.Size(72, 13)
        ID_GESTIONLabel.TabIndex = 52
        ID_GESTIONLabel.Text = "ID GESTION:"
        '
        'ID_TRABAJOLabel
        '
        ID_TRABAJOLabel.AutoSize = True
        ID_TRABAJOLabel.ForeColor = System.Drawing.Color.White
        ID_TRABAJOLabel.Location = New System.Drawing.Point(2, 29)
        ID_TRABAJOLabel.Name = "ID_TRABAJOLabel"
        ID_TRABAJOLabel.Size = New System.Drawing.Size(73, 13)
        ID_TRABAJOLabel.TabIndex = 53
        ID_TRABAJOLabel.Text = "ID TRABAJO:"
        '
        'ORDEN_OCLabel
        '
        ORDEN_OCLabel.AutoSize = True
        ORDEN_OCLabel.ForeColor = System.Drawing.Color.White
        ORDEN_OCLabel.Location = New System.Drawing.Point(8, 73)
        ORDEN_OCLabel.Name = "ORDEN_OCLabel"
        ORDEN_OCLabel.Size = New System.Drawing.Size(67, 13)
        ORDEN_OCLabel.TabIndex = 54
        ORDEN_OCLabel.Text = "ORDEN OC:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.ForeColor = System.Drawing.Color.White
        Label23.Location = New System.Drawing.Point(181, 74)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(39, 13)
        Label23.TabIndex = 60
        Label23.Text = "CANT:"
        '
        'INDICESDataSet
        '
        Me.INDICESDataSet.DataSetName = "INDICESDataSet"
        Me.INDICESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INDICE_CALLESBindingSource
        '
        Me.INDICE_CALLESBindingSource.DataMember = "INDICE_CALLES"
        Me.INDICE_CALLESBindingSource.DataSource = Me.INDICESDataSet
        '
        'INDICE_CALLESTableAdapter
        '
        Me.INDICE_CALLESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIMATableAdapter = Nothing
        Me.TableAdapterManager.GUARDIASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_CALLESTableAdapter = Me.INDICE_CALLESTableAdapter
        Me.TableAdapterManager.INDICE_CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_DIAGNOSTICOTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_FALLASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_FRECUENCIASTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_MEDIDORTableAdapter = Nothing
        Me.TableAdapterManager.INDICE_PUNTOMEDIDATableAdapter = Nothing
        Me.TableAdapterManager.INDICE_TIPOMEDIDATableAdapter = Nothing
        Me.TableAdapterManager.MAT_ACTIVOSTableAdapter = Nothing
        Me.TableAdapterManager.MAT_CONSOLIDADOTableAdapter = Nothing
        Me.TableAdapterManager.MAT_CONSUMOSXMESTableAdapter = Nothing
        Me.TableAdapterManager.MAT_INFORMETableAdapter = Nothing
        Me.TableAdapterManager.MAT_STOCKTableAdapter = Nothing
        Me.TableAdapterManager.MAT_TRANSITOTableAdapter = Nothing
        Me.TableAdapterManager.ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.PLANOSTableAdapter = Nothing
        Me.TableAdapterManager.TecnicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.INDICESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DGV_ORDENES
        '
        Me.DGV_ORDENES.AllowUserToAddRows = False
        Me.DGV_ORDENES.AllowUserToDeleteRows = False
        Me.DGV_ORDENES.AllowUserToResizeColumns = False
        Me.DGV_ORDENES.AllowUserToResizeRows = False
        Me.DGV_ORDENES.AutoGenerateColumns = False
        Me.DGV_ORDENES.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV_ORDENES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV_ORDENES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ORDENES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ORDENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ORDENES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROORDENINTDataGridViewTextBoxColumn, Me.ORDENOCDataGridViewTextBoxColumn, Me.IDGESTIONDataGridViewTextBoxColumn, Me.IDTRABAJODataGridViewTextBoxColumn, Me.FECHAINGRESODataGridViewTextBoxColumn, Me.FECHAASIGNADADataGridViewTextBoxColumn, Me.PRIORIDADDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.NODODataGridViewTextBoxColumn, Me.ZONADataGridViewTextBoxColumn, Me.CALLEDataGridViewTextBoxColumn, Me.NRODataGridViewTextBoxColumn, Me.MANZANADataGridViewTextBoxColumn, Me.ATRIBUTODataGridViewTextBoxColumn, Me.DOCUMENTOFISICODataGridViewCheckBoxColumn, Me.OC_APROBADO})
        Me.DGV_ORDENES.DataSource = Me.ORDENESBindingSource1
        Me.DGV_ORDENES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ORDENES.EnableHeadersVisualStyles = False
        Me.DGV_ORDENES.GridColor = System.Drawing.Color.LightGray
        Me.DGV_ORDENES.Location = New System.Drawing.Point(0, 69)
        Me.DGV_ORDENES.Name = "DGV_ORDENES"
        Me.DGV_ORDENES.ReadOnly = True
        Me.DGV_ORDENES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_ORDENES.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_ORDENES.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ORDENES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ORDENES.ShowCellErrors = False
        Me.DGV_ORDENES.ShowCellToolTips = False
        Me.DGV_ORDENES.ShowEditingIcon = False
        Me.DGV_ORDENES.ShowRowErrors = False
        Me.DGV_ORDENES.Size = New System.Drawing.Size(1142, 275)
        Me.DGV_ORDENES.TabIndex = 333
        '
        'OC_APROBADO
        '
        Me.OC_APROBADO.DataPropertyName = "OC_APROBADO"
        Me.OC_APROBADO.HeaderText = "AP"
        Me.OC_APROBADO.Name = "OC_APROBADO"
        Me.OC_APROBADO.ReadOnly = True
        Me.OC_APROBADO.Width = 25
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label23)
        Me.Panel1.Controls.Add(Me.TXT_CANT_OBRAC)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(ORDEN_OCLabel)
        Me.Panel1.Controls.Add(Me.ORDEN_OCTextBox)
        Me.Panel1.Controls.Add(ID_TRABAJOLabel)
        Me.Panel1.Controls.Add(Me.ID_TRABAJOTextBox)
        Me.Panel1.Controls.Add(ID_GESTIONLabel)
        Me.Panel1.Controls.Add(Me.ID_GESTIONTextBox)
        Me.Panel1.Controls.Add(NRO_ORDENINTLabel)
        Me.Panel1.Controls.Add(Me.NRO_ORDENINTTextBox)
        Me.Panel1.Controls.Add(Me.DOCUMENTO_FISICOCheckBox)
        Me.Panel1.Controls.Add(ATRIBUTOLabel)
        Me.Panel1.Controls.Add(Me.ATRIBUTOTextBox)
        Me.Panel1.Controls.Add(CAUSACIERRELabel)
        Me.Panel1.Controls.Add(Me.CAUSACIERRETextBox)
        Me.Panel1.Controls.Add(MOTIVOCIERRELabel)
        Me.Panel1.Controls.Add(Me.MOTIVOCIERRETextBox)
        Me.Panel1.Controls.Add(CAUSARIGENLabel)
        Me.Panel1.Controls.Add(Me.CAUSARIGENTextBox)
        Me.Panel1.Controls.Add(MOTIVOORIGENLabel)
        Me.Panel1.Controls.Add(Me.MOTIVOORIGENTextBox)
        Me.Panel1.Controls.Add(CUADRILLALabel)
        Me.Panel1.Controls.Add(Me.CUADRILLATextBox)
        Me.Panel1.Controls.Add(SOLICITANTELabel)
        Me.Panel1.Controls.Add(Me.SOLICITANTETextBox)
        Me.Panel1.Controls.Add(GENERADORLabel)
        Me.Panel1.Controls.Add(Me.GENERADORTextBox)
        Me.Panel1.Controls.Add(STATUSLabel)
        Me.Panel1.Controls.Add(Me.STATUSTextBox)
        Me.Panel1.Controls.Add(PRIORIDADLabel)
        Me.Panel1.Controls.Add(Me.PRIORIDADTextBox)
        Me.Panel1.Controls.Add(FECHAFINLabel)
        Me.Panel1.Controls.Add(FECHAINICIOLabel)
        Me.Panel1.Controls.Add(FECHASOLLabel)
        Me.Panel1.Controls.Add(SECTOROPELabel)
        Me.Panel1.Controls.Add(Me.SECTOROPETextBox)
        Me.Panel1.Controls.Add(TIPOLabel)
        Me.Panel1.Controls.Add(Me.TIPOTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 344)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 98)
        Me.Panel1.TabIndex = 334
        '
        'TXT_CANT_OBRAC
        '
        Me.TXT_CANT_OBRAC.BackColor = System.Drawing.Color.Black
        Me.TXT_CANT_OBRAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CANT_OBRAC.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TXT_CANT_OBRAC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "CANTIDAD_SERVICIOS", True))
        Me.TXT_CANT_OBRAC.ForeColor = System.Drawing.Color.White
        Me.TXT_CANT_OBRAC.Location = New System.Drawing.Point(221, 70)
        Me.TXT_CANT_OBRAC.Name = "TXT_CANT_OBRAC"
        Me.TXT_CANT_OBRAC.Size = New System.Drawing.Size(39, 20)
        Me.TXT_CANT_OBRAC.TabIndex = 59
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "FECHAFIN", True))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(431, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 58
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "FECHAINICIO", True))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(431, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 57
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "FECHASOL", True))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(431, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 56
        '
        'ORDEN_OCTextBox
        '
        Me.ORDEN_OCTextBox.BackColor = System.Drawing.Color.Black
        Me.ORDEN_OCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ORDEN_OCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "ORDEN_OC", True))
        Me.ORDEN_OCTextBox.ForeColor = System.Drawing.Color.White
        Me.ORDEN_OCTextBox.Location = New System.Drawing.Point(76, 70)
        Me.ORDEN_OCTextBox.Name = "ORDEN_OCTextBox"
        Me.ORDEN_OCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDEN_OCTextBox.TabIndex = 55
        '
        'ID_TRABAJOTextBox
        '
        Me.ID_TRABAJOTextBox.BackColor = System.Drawing.Color.Black
        Me.ID_TRABAJOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_TRABAJOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "ID_TRABAJO", True))
        Me.ID_TRABAJOTextBox.ForeColor = System.Drawing.Color.White
        Me.ID_TRABAJOTextBox.Location = New System.Drawing.Point(76, 26)
        Me.ID_TRABAJOTextBox.Name = "ID_TRABAJOTextBox"
        Me.ID_TRABAJOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TRABAJOTextBox.TabIndex = 54
        '
        'ID_GESTIONTextBox
        '
        Me.ID_GESTIONTextBox.BackColor = System.Drawing.Color.Black
        Me.ID_GESTIONTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_GESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "ID_GESTION", True))
        Me.ID_GESTIONTextBox.ForeColor = System.Drawing.Color.White
        Me.ID_GESTIONTextBox.Location = New System.Drawing.Point(76, 4)
        Me.ID_GESTIONTextBox.Name = "ID_GESTIONTextBox"
        Me.ID_GESTIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_GESTIONTextBox.TabIndex = 53
        '
        'NRO_ORDENINTTextBox
        '
        Me.NRO_ORDENINTTextBox.BackColor = System.Drawing.Color.Black
        Me.NRO_ORDENINTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NRO_ORDENINTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "NRO_ORDENINT", True))
        Me.NRO_ORDENINTTextBox.ForeColor = System.Drawing.Color.White
        Me.NRO_ORDENINTTextBox.Location = New System.Drawing.Point(76, 48)
        Me.NRO_ORDENINTTextBox.Name = "NRO_ORDENINTTextBox"
        Me.NRO_ORDENINTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NRO_ORDENINTTextBox.TabIndex = 52
        '
        'DOCUMENTO_FISICOCheckBox
        '
        Me.DOCUMENTO_FISICOCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DOCUMENTO_FISICOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ORDENESBindingSource1, "DOCUMENTO_FISICO", True))
        Me.DOCUMENTO_FISICOCheckBox.ForeColor = System.Drawing.Color.White
        Me.DOCUMENTO_FISICOCheckBox.Location = New System.Drawing.Point(266, 69)
        Me.DOCUMENTO_FISICOCheckBox.Name = "DOCUMENTO_FISICOCheckBox"
        Me.DOCUMENTO_FISICOCheckBox.Size = New System.Drawing.Size(89, 24)
        Me.DOCUMENTO_FISICOCheckBox.TabIndex = 51
        Me.DOCUMENTO_FISICOCheckBox.Text = "DOC. FISICA"
        Me.DOCUMENTO_FISICOCheckBox.UseVisualStyleBackColor = False
        '
        'ATRIBUTOTextBox
        '
        Me.ATRIBUTOTextBox.BackColor = System.Drawing.Color.Black
        Me.ATRIBUTOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATRIBUTOTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ATRIBUTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "ATRIBUTO", True))
        Me.ATRIBUTOTextBox.ForeColor = System.Drawing.Color.White
        Me.ATRIBUTOTextBox.Location = New System.Drawing.Point(251, 49)
        Me.ATRIBUTOTextBox.Name = "ATRIBUTOTextBox"
        Me.ATRIBUTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ATRIBUTOTextBox.TabIndex = 47
        '
        'CAUSACIERRETextBox
        '
        Me.CAUSACIERRETextBox.BackColor = System.Drawing.Color.Black
        Me.CAUSACIERRETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CAUSACIERRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "CAUSACIERRE", True))
        Me.CAUSACIERRETextBox.ForeColor = System.Drawing.Color.White
        Me.CAUSACIERRETextBox.Location = New System.Drawing.Point(824, 69)
        Me.CAUSACIERRETextBox.Name = "CAUSACIERRETextBox"
        Me.CAUSACIERRETextBox.Size = New System.Drawing.Size(186, 20)
        Me.CAUSACIERRETextBox.TabIndex = 45
        '
        'MOTIVOCIERRETextBox
        '
        Me.MOTIVOCIERRETextBox.BackColor = System.Drawing.Color.Black
        Me.MOTIVOCIERRETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MOTIVOCIERRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "MOTIVOCIERRE", True))
        Me.MOTIVOCIERRETextBox.ForeColor = System.Drawing.Color.White
        Me.MOTIVOCIERRETextBox.Location = New System.Drawing.Point(824, 47)
        Me.MOTIVOCIERRETextBox.Name = "MOTIVOCIERRETextBox"
        Me.MOTIVOCIERRETextBox.Size = New System.Drawing.Size(186, 20)
        Me.MOTIVOCIERRETextBox.TabIndex = 43
        '
        'CAUSARIGENTextBox
        '
        Me.CAUSARIGENTextBox.BackColor = System.Drawing.Color.Black
        Me.CAUSARIGENTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CAUSARIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "CAUSARIGEN", True))
        Me.CAUSARIGENTextBox.ForeColor = System.Drawing.Color.White
        Me.CAUSARIGENTextBox.Location = New System.Drawing.Point(824, 25)
        Me.CAUSARIGENTextBox.Name = "CAUSARIGENTextBox"
        Me.CAUSARIGENTextBox.Size = New System.Drawing.Size(186, 20)
        Me.CAUSARIGENTextBox.TabIndex = 41
        '
        'MOTIVOORIGENTextBox
        '
        Me.MOTIVOORIGENTextBox.BackColor = System.Drawing.Color.Black
        Me.MOTIVOORIGENTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MOTIVOORIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "MOTIVOORIGEN", True))
        Me.MOTIVOORIGENTextBox.ForeColor = System.Drawing.Color.White
        Me.MOTIVOORIGENTextBox.Location = New System.Drawing.Point(824, 3)
        Me.MOTIVOORIGENTextBox.Name = "MOTIVOORIGENTextBox"
        Me.MOTIVOORIGENTextBox.Size = New System.Drawing.Size(186, 20)
        Me.MOTIVOORIGENTextBox.TabIndex = 39
        '
        'CUADRILLATextBox
        '
        Me.CUADRILLATextBox.BackColor = System.Drawing.Color.Black
        Me.CUADRILLATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUADRILLATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "CUADRILLA", True))
        Me.CUADRILLATextBox.ForeColor = System.Drawing.Color.White
        Me.CUADRILLATextBox.Location = New System.Drawing.Point(618, 25)
        Me.CUADRILLATextBox.Name = "CUADRILLATextBox"
        Me.CUADRILLATextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUADRILLATextBox.TabIndex = 25
        '
        'SOLICITANTETextBox
        '
        Me.SOLICITANTETextBox.BackColor = System.Drawing.Color.Black
        Me.SOLICITANTETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SOLICITANTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "SOLICITANTE", True))
        Me.SOLICITANTETextBox.ForeColor = System.Drawing.Color.White
        Me.SOLICITANTETextBox.Location = New System.Drawing.Point(618, 69)
        Me.SOLICITANTETextBox.Name = "SOLICITANTETextBox"
        Me.SOLICITANTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SOLICITANTETextBox.TabIndex = 23
        Me.SOLICITANTETextBox.Visible = False
        '
        'GENERADORTextBox
        '
        Me.GENERADORTextBox.BackColor = System.Drawing.Color.Black
        Me.GENERADORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GENERADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "GENERADOR", True))
        Me.GENERADORTextBox.ForeColor = System.Drawing.Color.White
        Me.GENERADORTextBox.Location = New System.Drawing.Point(618, 3)
        Me.GENERADORTextBox.Name = "GENERADORTextBox"
        Me.GENERADORTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GENERADORTextBox.TabIndex = 21
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.BackColor = System.Drawing.Color.Black
        Me.STATUSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "STATUS", True))
        Me.STATUSTextBox.ForeColor = System.Drawing.Color.White
        Me.STATUSTextBox.Location = New System.Drawing.Point(618, 47)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATUSTextBox.TabIndex = 19
        '
        'PRIORIDADTextBox
        '
        Me.PRIORIDADTextBox.BackColor = System.Drawing.Color.Black
        Me.PRIORIDADTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRIORIDADTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PRIORIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "PRIORIDAD", True))
        Me.PRIORIDADTextBox.ForeColor = System.Drawing.Color.White
        Me.PRIORIDADTextBox.Location = New System.Drawing.Point(431, 69)
        Me.PRIORIDADTextBox.Name = "PRIORIDADTextBox"
        Me.PRIORIDADTextBox.Size = New System.Drawing.Size(101, 20)
        Me.PRIORIDADTextBox.TabIndex = 17
        '
        'SECTOROPETextBox
        '
        Me.SECTOROPETextBox.BackColor = System.Drawing.Color.Black
        Me.SECTOROPETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SECTOROPETextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SECTOROPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "SECTOROPE", True))
        Me.SECTOROPETextBox.ForeColor = System.Drawing.Color.White
        Me.SECTOROPETextBox.Location = New System.Drawing.Point(251, 27)
        Me.SECTOROPETextBox.Name = "SECTOROPETextBox"
        Me.SECTOROPETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SECTOROPETextBox.TabIndex = 9
        '
        'TIPOTextBox
        '
        Me.TIPOTextBox.BackColor = System.Drawing.Color.Black
        Me.TIPOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIPOTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource1, "TIPO", True))
        Me.TIPOTextBox.ForeColor = System.Drawing.Color.White
        Me.TIPOTextBox.Location = New System.Drawing.Point(251, 5)
        Me.TIPOTextBox.Name = "TIPOTextBox"
        Me.TIPOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPOTextBox.TabIndex = 7
        '
        'GB_NUEVO
        '
        Me.GB_NUEVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GB_NUEVO.Controls.Add(Me.Label22)
        Me.GB_NUEVO.Controls.Add(Me.TXT_CANT_OC)
        Me.GB_NUEVO.Controls.Add(Me.DGV_ADJUNTO)
        Me.GB_NUEVO.Controls.Add(Me.Label21)
        Me.GB_NUEVO.Controls.Add(Me.CB_CAUSAS)
        Me.GB_NUEVO.Controls.Add(Me.INDICE_CALLESDataGridView)
        Me.GB_NUEVO.Controls.Add(Me.Label20)
        Me.GB_NUEVO.Controls.Add(Me.TXT_MAN)
        Me.GB_NUEVO.Controls.Add(Me.Label18)
        Me.GB_NUEVO.Controls.Add(Me.TXT_SEG)
        Me.GB_NUEVO.Controls.Add(Me.Label19)
        Me.GB_NUEVO.Controls.Add(Me.IND_CALLE)
        Me.GB_NUEVO.Controls.Add(Me.TXT_SEC)
        Me.GB_NUEVO.Controls.Add(Me.Label38)
        Me.GB_NUEVO.Controls.Add(Me.BTN_INGRESAR)
        Me.GB_NUEVO.Controls.Add(Me.Label17)
        Me.GB_NUEVO.Controls.Add(Me.TXT_OBS)
        Me.GB_NUEVO.Controls.Add(Me.BTN_ADJUNTAR)
        Me.GB_NUEVO.Controls.Add(Me.CK_DOCUMENTO_FISICO)
        Me.GB_NUEVO.Controls.Add(Me.LBL_OC)
        Me.GB_NUEVO.Controls.Add(Me.TXT_ORDEN_OC)
        Me.GB_NUEVO.Controls.Add(Me.Label26)
        Me.GB_NUEVO.Controls.Add(Me.CB_PRIORIDAD)
        Me.GB_NUEVO.Controls.Add(Me.Label15)
        Me.GB_NUEVO.Controls.Add(Me.CB_ATRIBUTO)
        Me.GB_NUEVO.Controls.Add(Me.CB_TIPO)
        Me.GB_NUEVO.Controls.Add(Me.Label16)
        Me.GB_NUEVO.Controls.Add(Me.Label14)
        Me.GB_NUEVO.Controls.Add(Me.TXT_ESQ2)
        Me.GB_NUEVO.Controls.Add(Me.Label13)
        Me.GB_NUEVO.Controls.Add(Me.TXT_ESQ1)
        Me.GB_NUEVO.Controls.Add(Me.Label12)
        Me.GB_NUEVO.Controls.Add(Me.TXT_ZONA)
        Me.GB_NUEVO.Controls.Add(Me.Label11)
        Me.GB_NUEVO.Controls.Add(Me.TXT_NODO)
        Me.GB_NUEVO.Controls.Add(Me.Label7)
        Me.GB_NUEVO.Controls.Add(Me.Label8)
        Me.GB_NUEVO.Controls.Add(Me.TXT_CALLE)
        Me.GB_NUEVO.Controls.Add(Me.TXT_NRO)
        Me.GB_NUEVO.Controls.Add(Me.ListArchivos)
        Me.GB_NUEVO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_NUEVO.ForeColor = System.Drawing.Color.White
        Me.GB_NUEVO.Location = New System.Drawing.Point(0, 532)
        Me.GB_NUEVO.Name = "GB_NUEVO"
        Me.GB_NUEVO.Size = New System.Drawing.Size(1142, 185)
        Me.GB_NUEVO.TabIndex = 335
        Me.GB_NUEVO.TabStop = False
        Me.GB_NUEVO.Text = "NUEVO SERVICIO"
        Me.GB_NUEVO.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(686, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 13)
        Me.Label22.TabIndex = 399
        Me.Label22.Text = "Cantidad OC"
        '
        'TXT_CANT_OC
        '
        Me.TXT_CANT_OC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CANT_OC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CANT_OC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CANT_OC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_CANT_OC.Location = New System.Drawing.Point(689, 22)
        Me.TXT_CANT_OC.MaxLength = 3
        Me.TXT_CANT_OC.Name = "TXT_CANT_OC"
        Me.TXT_CANT_OC.Size = New System.Drawing.Size(55, 21)
        Me.TXT_CANT_OC.TabIndex = 398
        Me.TXT_CANT_OC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_ADJUNTO
        '
        Me.DGV_ADJUNTO.AllowUserToAddRows = False
        Me.DGV_ADJUNTO.AllowUserToDeleteRows = False
        Me.DGV_ADJUNTO.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DGV_ADJUNTO.AutoGenerateColumns = False
        Me.DGV_ADJUNTO.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DGV_ADJUNTO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_ADJUNTO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ADJUNTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ADJUNTO.ColumnHeadersVisible = False
        Me.DGV_ADJUNTO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMARCHIVODataGridViewTextBoxColumn})
        Me.DGV_ADJUNTO.DataSource = Me.ADJUNTOSBindingSource
        Me.DGV_ADJUNTO.GridColor = System.Drawing.Color.Gray
        Me.DGV_ADJUNTO.Location = New System.Drawing.Point(919, 29)
        Me.DGV_ADJUNTO.Name = "DGV_ADJUNTO"
        Me.DGV_ADJUNTO.ReadOnly = True
        Me.DGV_ADJUNTO.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightGreen
        Me.DGV_ADJUNTO.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ADJUNTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ADJUNTO.Size = New System.Drawing.Size(212, 70)
        Me.DGV_ADJUNTO.TabIndex = 397
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(548, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 394
        Me.Label21.Text = "CAUSA:"
        '
        'CB_CAUSAS
        '
        Me.CB_CAUSAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_CAUSAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CAUSAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CB_CAUSAS.FormattingEnabled = True
        Me.CB_CAUSAS.Location = New System.Drawing.Point(604, 78)
        Me.CB_CAUSAS.Name = "CB_CAUSAS"
        Me.CB_CAUSAS.Size = New System.Drawing.Size(186, 21)
        Me.CB_CAUSAS.TabIndex = 395
        '
        'INDICE_CALLESDataGridView
        '
        Me.INDICE_CALLESDataGridView.AllowUserToAddRows = False
        Me.INDICE_CALLESDataGridView.AllowUserToDeleteRows = False
        Me.INDICE_CALLESDataGridView.AutoGenerateColumns = False
        Me.INDICE_CALLESDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.INDICE_CALLESDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.INDICE_CALLESDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.INDICE_CALLESDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INDICE_CALLESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.INDICE_CALLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INDICE_CALLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CALLE, Me.TIPO, Me.DataGridViewTextBoxColumn10})
        Me.INDICE_CALLESDataGridView.DataSource = Me.INDICE_CALLESBindingSource
        Me.INDICE_CALLESDataGridView.EnableHeadersVisualStyles = False
        Me.INDICE_CALLESDataGridView.GridColor = System.Drawing.Color.Silver
        Me.INDICE_CALLESDataGridView.Location = New System.Drawing.Point(116, 54)
        Me.INDICE_CALLESDataGridView.Name = "INDICE_CALLESDataGridView"
        Me.INDICE_CALLESDataGridView.ReadOnly = True
        Me.INDICE_CALLESDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.INDICE_CALLESDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.INDICE_CALLESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.INDICE_CALLESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INDICE_CALLESDataGridView.Size = New System.Drawing.Size(369, 129)
        Me.INDICE_CALLESDataGridView.TabIndex = 349
        Me.INDICE_CALLESDataGridView.Visible = False
        '
        'ID_CALLE
        '
        Me.ID_CALLE.DataPropertyName = "ID_CALLE"
        Me.ID_CALLE.HeaderText = "ID_CALLE"
        Me.ID_CALLE.Name = "ID_CALLE"
        Me.ID_CALLE.ReadOnly = True
        Me.ID_CALLE.Visible = False
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.MinimumWidth = 65
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NOMBRE_CALLE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre Calle"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(475, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 17)
        Me.Label20.TabIndex = 393
        Me.Label20.Text = "MAN"
        '
        'TXT_MAN
        '
        Me.TXT_MAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_MAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_MAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_MAN.Location = New System.Drawing.Point(472, 77)
        Me.TXT_MAN.Name = "TXT_MAN"
        Me.TXT_MAN.Size = New System.Drawing.Size(49, 21)
        Me.TXT_MAN.TabIndex = 392
        Me.TXT_MAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(427, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 17)
        Me.Label18.TabIndex = 391
        Me.Label18.Text = "SEG"
        '
        'TXT_SEG
        '
        Me.TXT_SEG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_SEG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_SEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_SEG.Location = New System.Drawing.Point(422, 77)
        Me.TXT_SEG.Name = "TXT_SEG"
        Me.TXT_SEG.Size = New System.Drawing.Size(49, 21)
        Me.TXT_SEG.TabIndex = 390
        Me.TXT_SEG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(377, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 17)
        Me.Label19.TabIndex = 389
        Me.Label19.Text = "SEC"
        '
        'IND_CALLE
        '
        Me.IND_CALLE.AutoSize = True
        Me.IND_CALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IND_CALLE.ForeColor = System.Drawing.Color.Silver
        Me.IND_CALLE.Location = New System.Drawing.Point(227, 16)
        Me.IND_CALLE.Name = "IND_CALLE"
        Me.IND_CALLE.Size = New System.Drawing.Size(11, 13)
        Me.IND_CALLE.TabIndex = 351
        Me.IND_CALLE.Text = "*"
        '
        'TXT_SEC
        '
        Me.TXT_SEC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_SEC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_SEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_SEC.Location = New System.Drawing.Point(372, 77)
        Me.TXT_SEC.Name = "TXT_SEC"
        Me.TXT_SEC.Size = New System.Drawing.Size(49, 21)
        Me.TXT_SEC.TabIndex = 388
        Me.TXT_SEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label38.ForeColor = System.Drawing.Color.Silver
        Me.Label38.Location = New System.Drawing.Point(199, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(25, 13)
        Me.Label38.TabIndex = 350
        Me.Label38.Text = "Ind:"
        '
        'BTN_INGRESAR
        '
        Me.BTN_INGRESAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_INGRESAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_INGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_INGRESAR.FlatAppearance.BorderSize = 0
        Me.BTN_INGRESAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_INGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_INGRESAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_INGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INGRESAR.ForeColor = System.Drawing.Color.White
        Me.BTN_INGRESAR.Location = New System.Drawing.Point(849, 134)
        Me.BTN_INGRESAR.Name = "BTN_INGRESAR"
        Me.BTN_INGRESAR.Size = New System.Drawing.Size(138, 43)
        Me.BTN_INGRESAR.TabIndex = 387
        Me.BTN_INGRESAR.Text = "INGRESAR"
        Me.BTN_INGRESAR.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(12, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 386
        Me.Label17.Text = "OBS:"
        '
        'TXT_OBS
        '
        Me.TXT_OBS.BackColor = System.Drawing.Color.Black
        Me.TXT_OBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_OBS.ForeColor = System.Drawing.Color.White
        Me.TXT_OBS.Location = New System.Drawing.Point(10, 105)
        Me.TXT_OBS.Multiline = True
        Me.TXT_OBS.Name = "TXT_OBS"
        Me.TXT_OBS.Size = New System.Drawing.Size(779, 72)
        Me.TXT_OBS.TabIndex = 385
        '
        'BTN_ADJUNTAR
        '
        Me.BTN_ADJUNTAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ADJUNTAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ADJUNTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADJUNTAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_ADJUNTAR.FlatAppearance.BorderSize = 0
        Me.BTN_ADJUNTAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_ADJUNTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_ADJUNTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_ADJUNTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADJUNTAR.ForeColor = System.Drawing.Color.White
        Me.BTN_ADJUNTAR.Location = New System.Drawing.Point(869, 103)
        Me.BTN_ADJUNTAR.Name = "BTN_ADJUNTAR"
        Me.BTN_ADJUNTAR.Size = New System.Drawing.Size(138, 21)
        Me.BTN_ADJUNTAR.TabIndex = 382
        Me.BTN_ADJUNTAR.Text = "Buscar archivo a adjuntar"
        Me.BTN_ADJUNTAR.UseVisualStyleBackColor = False
        '
        'CK_DOCUMENTO_FISICO
        '
        Me.CK_DOCUMENTO_FISICO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CK_DOCUMENTO_FISICO.AutoSize = True
        Me.CK_DOCUMENTO_FISICO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_DOCUMENTO_FISICO.ForeColor = System.Drawing.Color.White
        Me.CK_DOCUMENTO_FISICO.Location = New System.Drawing.Point(931, 10)
        Me.CK_DOCUMENTO_FISICO.Name = "CK_DOCUMENTO_FISICO"
        Me.CK_DOCUMENTO_FISICO.Size = New System.Drawing.Size(180, 17)
        Me.CK_DOCUMENTO_FISICO.TabIndex = 383
        Me.CK_DOCUMENTO_FISICO.Text = "ENTREGA CON PLANO FISICO"
        Me.CK_DOCUMENTO_FISICO.UseVisualStyleBackColor = False
        '
        'LBL_OC
        '
        Me.LBL_OC.AutoSize = True
        Me.LBL_OC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_OC.ForeColor = System.Drawing.Color.White
        Me.LBL_OC.Location = New System.Drawing.Point(588, 7)
        Me.LBL_OC.Name = "LBL_OC"
        Me.LBL_OC.Size = New System.Drawing.Size(92, 13)
        Me.LBL_OC.TabIndex = 381
        Me.LBL_OC.Text = "Orden interna OC:"
        '
        'TXT_ORDEN_OC
        '
        Me.TXT_ORDEN_OC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ORDEN_OC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_ORDEN_OC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ORDEN_OC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_ORDEN_OC.Location = New System.Drawing.Point(588, 22)
        Me.TXT_ORDEN_OC.Name = "TXT_ORDEN_OC"
        Me.TXT_ORDEN_OC.Size = New System.Drawing.Size(93, 21)
        Me.TXT_ORDEN_OC.TabIndex = 380
        Me.TXT_ORDEN_OC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(649, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 378
        Me.Label26.Text = "Prioridad:"
        '
        'CB_PRIORIDAD
        '
        Me.CB_PRIORIDAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_PRIORIDAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_PRIORIDAD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CB_PRIORIDAD.FormattingEnabled = True
        Me.CB_PRIORIDAD.Items.AddRange(New Object() {"URGENTE", "ALTA", "BAJA"})
        Me.CB_PRIORIDAD.Location = New System.Drawing.Point(703, 48)
        Me.CB_PRIORIDAD.Name = "CB_PRIORIDAD"
        Me.CB_PRIORIDAD.Size = New System.Drawing.Size(87, 21)
        Me.CB_PRIORIDAD.TabIndex = 379
        Me.CB_PRIORIDAD.Text = "BAJA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(505, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 376
        Me.Label15.Text = "Tipo RED"
        '
        'CB_ATRIBUTO
        '
        Me.CB_ATRIBUTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_ATRIBUTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ATRIBUTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CB_ATRIBUTO.FormattingEnabled = True
        Me.CB_ATRIBUTO.Items.AddRange(New Object() {"HFC", "RHFC", "FTTH"})
        Me.CB_ATRIBUTO.Location = New System.Drawing.Point(508, 22)
        Me.CB_ATRIBUTO.Name = "CB_ATRIBUTO"
        Me.CB_ATRIBUTO.Size = New System.Drawing.Size(72, 21)
        Me.CB_ATRIBUTO.TabIndex = 377
        Me.CB_ATRIBUTO.Text = "HFC"
        '
        'CB_TIPO
        '
        Me.CB_TIPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_TIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TIPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CB_TIPO.FormattingEnabled = True
        Me.CB_TIPO.Items.AddRange(New Object() {"TAREA", "OBRAS", "CORRECTIVO"})
        Me.CB_TIPO.Location = New System.Drawing.Point(396, 22)
        Me.CB_TIPO.Name = "CB_TIPO"
        Me.CB_TIPO.Size = New System.Drawing.Size(106, 21)
        Me.CB_TIPO.TabIndex = 375
        Me.CB_TIPO.Text = "TAREA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(393, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 374
        Me.Label16.Text = "Tipo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(61, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 373
        Me.Label14.Text = "ESQ2."
        '
        'TXT_ESQ2
        '
        Me.TXT_ESQ2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ESQ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ESQ2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_ESQ2.Location = New System.Drawing.Point(116, 77)
        Me.TXT_ESQ2.Name = "TXT_ESQ2"
        Me.TXT_ESQ2.Size = New System.Drawing.Size(226, 21)
        Me.TXT_ESQ2.TabIndex = 372
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(61, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 371
        Me.Label13.Text = "ESQ1."
        '
        'TXT_ESQ1
        '
        Me.TXT_ESQ1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ESQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ESQ1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_ESQ1.Location = New System.Drawing.Point(116, 54)
        Me.TXT_ESQ1.Name = "TXT_ESQ1"
        Me.TXT_ESQ1.Size = New System.Drawing.Size(226, 21)
        Me.TXT_ESQ1.TabIndex = 370
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(60, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 369
        Me.Label12.Text = "ZONA"
        '
        'TXT_ZONA
        '
        Me.TXT_ZONA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ZONA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_ZONA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ZONA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_ZONA.Location = New System.Drawing.Point(62, 31)
        Me.TXT_ZONA.Name = "TXT_ZONA"
        Me.TXT_ZONA.Size = New System.Drawing.Size(49, 21)
        Me.TXT_ZONA.TabIndex = 368
        Me.TXT_ZONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(6, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 367
        Me.Label11.Text = "NODO"
        '
        'TXT_NODO
        '
        Me.TXT_NODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_NODO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NODO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NODO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_NODO.Location = New System.Drawing.Point(9, 31)
        Me.TXT_NODO.Name = "TXT_NODO"
        Me.TXT_NODO.Size = New System.Drawing.Size(49, 21)
        Me.TXT_NODO.TabIndex = 366
        Me.TXT_NODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(344, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 365
        Me.Label7.Text = "NRO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(117, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 364
        Me.Label8.Text = "CALLE"
        '
        'TXT_CALLE
        '
        Me.TXT_CALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CALLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_CALLE.Location = New System.Drawing.Point(116, 31)
        Me.TXT_CALLE.Name = "TXT_CALLE"
        Me.TXT_CALLE.Size = New System.Drawing.Size(226, 21)
        Me.TXT_CALLE.TabIndex = 360
        '
        'TXT_NRO
        '
        Me.TXT_NRO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_NRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NRO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_NRO.Location = New System.Drawing.Point(347, 22)
        Me.TXT_NRO.Name = "TXT_NRO"
        Me.TXT_NRO.Size = New System.Drawing.Size(43, 21)
        Me.TXT_NRO.TabIndex = 361
        Me.TXT_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListArchivos
        '
        Me.ListArchivos.BackColor = System.Drawing.Color.Black
        Me.ListArchivos.HideSelection = False
        Me.ListArchivos.Location = New System.Drawing.Point(899, 63)
        Me.ListArchivos.Name = "ListArchivos"
        Me.ListArchivos.Size = New System.Drawing.Size(121, 97)
        Me.ListArchivos.TabIndex = 396
        Me.ListArchivos.UseCompatibleStateImageBehavior = False
        Me.ListArchivos.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(670, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 359
        Me.Label6.Text = "ORDEN OC"
        '
        'TXT_OC
        '
        Me.TXT_OC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_OC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_OC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OC.ForeColor = System.Drawing.Color.White
        Me.TXT_OC.Location = New System.Drawing.Point(671, 35)
        Me.TXT_OC.Name = "TXT_OC"
        Me.TXT_OC.Size = New System.Drawing.Size(89, 21)
        Me.TXT_OC.TabIndex = 358
        Me.TXT_OC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(571, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 357
        Me.Label5.Text = "ORDEN INT"
        '
        'TXT_ORDENINT
        '
        Me.TXT_ORDENINT.AcceptsReturn = True
        Me.TXT_ORDENINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ORDENINT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_ORDENINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ORDENINT.ForeColor = System.Drawing.Color.White
        Me.TXT_ORDENINT.Location = New System.Drawing.Point(575, 35)
        Me.TXT_ORDENINT.Name = "TXT_ORDENINT"
        Me.TXT_ORDENINT.Size = New System.Drawing.Size(89, 21)
        Me.TXT_ORDENINT.TabIndex = 356
        Me.TXT_ORDENINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(434, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 355
        Me.Label4.Text = "STATUS"
        '
        'CK_STATUS
        '
        Me.CK_STATUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_STATUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CK_STATUS.ForeColor = System.Drawing.Color.White
        Me.CK_STATUS.FormattingEnabled = True
        Me.CK_STATUS.Items.AddRange(New Object() {"INGRESADO", "ASIGNADO", "FINALIZADO", "CANCELADO", "EMITIDO", "TODOS"})
        Me.CK_STATUS.Location = New System.Drawing.Point(437, 35)
        Me.CK_STATUS.Name = "CK_STATUS"
        Me.CK_STATUS.Size = New System.Drawing.Size(121, 21)
        Me.CK_STATUS.TabIndex = 354
        Me.CK_STATUS.Text = "TODOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(374, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 353
        Me.Label3.Text = "NRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(147, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "CALLE"
        '
        'TXT_ING_NRO
        '
        Me.TXT_ING_NRO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ING_NRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ING_NRO.ForeColor = System.Drawing.Color.White
        Me.TXT_ING_NRO.Location = New System.Drawing.Point(374, 35)
        Me.TXT_ING_NRO.Name = "TXT_ING_NRO"
        Me.TXT_ING_NRO.Size = New System.Drawing.Size(43, 21)
        Me.TXT_ING_NRO.TabIndex = 348
        Me.TXT_ING_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ING_CALLE
        '
        Me.TXT_ING_CALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_ING_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ING_CALLE.ForeColor = System.Drawing.Color.White
        Me.TXT_ING_CALLE.Location = New System.Drawing.Point(146, 35)
        Me.TXT_ING_CALLE.Name = "TXT_ING_CALLE"
        Me.TXT_ING_CALLE.Size = New System.Drawing.Size(226, 21)
        Me.TXT_ING_CALLE.TabIndex = 347
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(84, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "ZONA"
        '
        'FILTRO_ZONA
        '
        Me.FILTRO_ZONA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FILTRO_ZONA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FILTRO_ZONA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILTRO_ZONA.ForeColor = System.Drawing.Color.White
        Me.FILTRO_ZONA.Location = New System.Drawing.Point(86, 35)
        Me.FILTRO_ZONA.Name = "FILTRO_ZONA"
        Me.FILTRO_ZONA.Size = New System.Drawing.Size(49, 21)
        Me.FILTRO_ZONA.TabIndex = 345
        Me.FILTRO_ZONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BUSCA_NODO
        '
        Me.BUSCA_NODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BUSCA_NODO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BUSCA_NODO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BUSCA_NODO.DropDownWidth = 40
        Me.BUSCA_NODO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BUSCA_NODO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCA_NODO.ForeColor = System.Drawing.Color.PowderBlue
        Me.BUSCA_NODO.FormattingEnabled = True
        Me.BUSCA_NODO.ItemHeight = 15
        Me.BUSCA_NODO.Items.AddRange(New Object() {"A", "B", "C", "CAB", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "ZB"})
        Me.BUSCA_NODO.Location = New System.Drawing.Point(16, 35)
        Me.BUSCA_NODO.MaxDropDownItems = 50
        Me.BUSCA_NODO.Name = "BUSCA_NODO"
        Me.BUSCA_NODO.Size = New System.Drawing.Size(65, 23)
        Me.BUSCA_NODO.TabIndex = 343
        '
        'LBLNODO
        '
        Me.LBLNODO.AutoSize = True
        Me.LBLNODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNODO.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNODO.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LBLNODO.Location = New System.Drawing.Point(16, 17)
        Me.LBLNODO.Name = "LBLNODO"
        Me.LBLNODO.Size = New System.Drawing.Size(54, 17)
        Me.LBLNODO.TabIndex = 344
        Me.LBLNODO.Text = "NODO"
        '
        'INDICE_CAUSASBindingSource
        '
        Me.INDICE_CAUSASBindingSource.DataMember = "INDICE_CAUSAS"
        Me.INDICE_CAUSASBindingSource.DataSource = Me.INDICESDataSet
        '
        'INDICE_CAUSASTableAdapter
        '
        Me.INDICE_CAUSASTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Label10)
        Me.Panel2.Controls.Add(Me.OBS_CIERRE)
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Me.OBS_ORIGEN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 90)
        Me.Panel2.TabIndex = 389
        '
        'OBS_CIERRE
        '
        Me.OBS_CIERRE.BackColor = System.Drawing.Color.Black
        Me.OBS_CIERRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OBS_CIERRE.ForeColor = System.Drawing.Color.White
        Me.OBS_CIERRE.Location = New System.Drawing.Point(540, 19)
        Me.OBS_CIERRE.Multiline = True
        Me.OBS_CIERRE.Name = "OBS_CIERRE"
        Me.OBS_CIERRE.Size = New System.Drawing.Size(426, 67)
        Me.OBS_CIERRE.TabIndex = 7
        '
        'OBS_ORIGEN
        '
        Me.OBS_ORIGEN.BackColor = System.Drawing.Color.Black
        Me.OBS_ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OBS_ORIGEN.ForeColor = System.Drawing.Color.White
        Me.OBS_ORIGEN.Location = New System.Drawing.Point(4, 19)
        Me.OBS_ORIGEN.Multiline = True
        Me.OBS_ORIGEN.Name = "OBS_ORIGEN"
        Me.OBS_ORIGEN.Size = New System.Drawing.Size(426, 67)
        Me.OBS_ORIGEN.TabIndex = 5
        '
        'CALLESBindingSource1
        '
        Me.CALLESBindingSource1.DataMember = "INDICE_CALLES"
        Me.CALLESBindingSource1.DataSource = Me.INDICESDataSet
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_NUEVO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_NUEVO.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_NUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_NUEVO.FlatAppearance.BorderSize = 0
        Me.BTN_NUEVO.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NUEVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NUEVO.ForeColor = System.Drawing.Color.White
        Me.BTN_NUEVO.Location = New System.Drawing.Point(904, 24)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(103, 32)
        Me.BTN_NUEVO.TabIndex = 388
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = False
        '
        'BTN_APROBAR
        '
        Me.BTN_APROBAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_APROBAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APROBAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_APROBAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_APROBAR.Enabled = False
        Me.BTN_APROBAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_APROBAR.FlatAppearance.BorderSize = 0
        Me.BTN_APROBAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_APROBAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_APROBAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_APROBAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_APROBAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_APROBAR.ForeColor = System.Drawing.Color.Red
        Me.BTN_APROBAR.Location = New System.Drawing.Point(1023, 24)
        Me.BTN_APROBAR.Name = "BTN_APROBAR"
        Me.BTN_APROBAR.Size = New System.Drawing.Size(103, 32)
        Me.BTN_APROBAR.TabIndex = 390
        Me.BTN_APROBAR.Text = "APROBAR"
        Me.BTN_APROBAR.UseVisualStyleBackColor = False
        '
        'BTN_REFRESCAR
        '
        Me.BTN_REFRESCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_REFRESCAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REFRESCAR.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_REFRESCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_REFRESCAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REFRESCAR.FlatAppearance.BorderSize = 0
        Me.BTN_REFRESCAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REFRESCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REFRESCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_REFRESCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REFRESCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESCAR.ForeColor = System.Drawing.Color.White
        Me.BTN_REFRESCAR.Location = New System.Drawing.Point(801, 24)
        Me.BTN_REFRESCAR.Name = "BTN_REFRESCAR"
        Me.BTN_REFRESCAR.Size = New System.Drawing.Size(89, 32)
        Me.BTN_REFRESCAR.TabIndex = 389
        Me.BTN_REFRESCAR.Text = "REFRESCAR"
        Me.BTN_REFRESCAR.UseVisualStyleBackColor = False
        '
        'NROORDENINTDataGridViewTextBoxColumn
        '
        Me.NROORDENINTDataGridViewTextBoxColumn.DataPropertyName = "NRO_ORDENINT"
        Me.NROORDENINTDataGridViewTextBoxColumn.HeaderText = "ORDEN"
        Me.NROORDENINTDataGridViewTextBoxColumn.Name = "NROORDENINTDataGridViewTextBoxColumn"
        Me.NROORDENINTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NROORDENINTDataGridViewTextBoxColumn.Width = 60
        '
        'ORDENOCDataGridViewTextBoxColumn
        '
        Me.ORDENOCDataGridViewTextBoxColumn.DataPropertyName = "ORDEN_OC"
        Me.ORDENOCDataGridViewTextBoxColumn.HeaderText = "OC"
        Me.ORDENOCDataGridViewTextBoxColumn.Name = "ORDENOCDataGridViewTextBoxColumn"
        Me.ORDENOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ORDENOCDataGridViewTextBoxColumn.Width = 65
        '
        'IDGESTIONDataGridViewTextBoxColumn
        '
        Me.IDGESTIONDataGridViewTextBoxColumn.DataPropertyName = "ID_GESTION"
        Me.IDGESTIONDataGridViewTextBoxColumn.HeaderText = "GEST"
        Me.IDGESTIONDataGridViewTextBoxColumn.Name = "IDGESTIONDataGridViewTextBoxColumn"
        Me.IDGESTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDGESTIONDataGridViewTextBoxColumn.Width = 40
        '
        'IDTRABAJODataGridViewTextBoxColumn
        '
        Me.IDTRABAJODataGridViewTextBoxColumn.DataPropertyName = "ID_TRABAJO"
        Me.IDTRABAJODataGridViewTextBoxColumn.HeaderText = "TRAB"
        Me.IDTRABAJODataGridViewTextBoxColumn.Name = "IDTRABAJODataGridViewTextBoxColumn"
        Me.IDTRABAJODataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTRABAJODataGridViewTextBoxColumn.Width = 40
        '
        'FECHAINGRESODataGridViewTextBoxColumn
        '
        Me.FECHAINGRESODataGridViewTextBoxColumn.DataPropertyName = "FECHAINGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.HeaderText = "INGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.Name = "FECHAINGRESODataGridViewTextBoxColumn"
        Me.FECHAINGRESODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAINGRESODataGridViewTextBoxColumn.Width = 75
        '
        'FECHAASIGNADADataGridViewTextBoxColumn
        '
        Me.FECHAASIGNADADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ASIGNADA"
        Me.FECHAASIGNADADataGridViewTextBoxColumn.HeaderText = "ASIGNADO"
        Me.FECHAASIGNADADataGridViewTextBoxColumn.Name = "FECHAASIGNADADataGridViewTextBoxColumn"
        Me.FECHAASIGNADADataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRIORIDADDataGridViewTextBoxColumn
        '
        Me.PRIORIDADDataGridViewTextBoxColumn.DataPropertyName = "PRIORIDAD"
        Me.PRIORIDADDataGridViewTextBoxColumn.HeaderText = "PRIO"
        Me.PRIORIDADDataGridViewTextBoxColumn.Name = "PRIORIDADDataGridViewTextBoxColumn"
        Me.PRIORIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRIORIDADDataGridViewTextBoxColumn.Width = 50
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATUSDataGridViewTextBoxColumn.Width = 80
        '
        'NODODataGridViewTextBoxColumn
        '
        Me.NODODataGridViewTextBoxColumn.DataPropertyName = "NODO"
        Me.NODODataGridViewTextBoxColumn.HeaderText = "NODO"
        Me.NODODataGridViewTextBoxColumn.Name = "NODODataGridViewTextBoxColumn"
        Me.NODODataGridViewTextBoxColumn.ReadOnly = True
        Me.NODODataGridViewTextBoxColumn.Width = 45
        '
        'ZONADataGridViewTextBoxColumn
        '
        Me.ZONADataGridViewTextBoxColumn.DataPropertyName = "ZONA"
        Me.ZONADataGridViewTextBoxColumn.HeaderText = "ZONA"
        Me.ZONADataGridViewTextBoxColumn.Name = "ZONADataGridViewTextBoxColumn"
        Me.ZONADataGridViewTextBoxColumn.ReadOnly = True
        Me.ZONADataGridViewTextBoxColumn.Width = 45
        '
        'CALLEDataGridViewTextBoxColumn
        '
        Me.CALLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CALLEDataGridViewTextBoxColumn.DataPropertyName = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.HeaderText = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.Name = "CALLEDataGridViewTextBoxColumn"
        Me.CALLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NRODataGridViewTextBoxColumn
        '
        Me.NRODataGridViewTextBoxColumn.DataPropertyName = "NRO"
        Me.NRODataGridViewTextBoxColumn.HeaderText = "NRO"
        Me.NRODataGridViewTextBoxColumn.Name = "NRODataGridViewTextBoxColumn"
        Me.NRODataGridViewTextBoxColumn.ReadOnly = True
        Me.NRODataGridViewTextBoxColumn.Width = 50
        '
        'MANZANADataGridViewTextBoxColumn
        '
        Me.MANZANADataGridViewTextBoxColumn.DataPropertyName = "MANZANA"
        Me.MANZANADataGridViewTextBoxColumn.HeaderText = "MANZ"
        Me.MANZANADataGridViewTextBoxColumn.Name = "MANZANADataGridViewTextBoxColumn"
        Me.MANZANADataGridViewTextBoxColumn.ReadOnly = True
        Me.MANZANADataGridViewTextBoxColumn.Width = 70
        '
        'ATRIBUTODataGridViewTextBoxColumn
        '
        Me.ATRIBUTODataGridViewTextBoxColumn.DataPropertyName = "ATRIBUTO"
        Me.ATRIBUTODataGridViewTextBoxColumn.HeaderText = "RED"
        Me.ATRIBUTODataGridViewTextBoxColumn.Name = "ATRIBUTODataGridViewTextBoxColumn"
        Me.ATRIBUTODataGridViewTextBoxColumn.ReadOnly = True
        Me.ATRIBUTODataGridViewTextBoxColumn.Width = 50
        '
        'DOCUMENTOFISICODataGridViewCheckBoxColumn
        '
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn.DataPropertyName = "DOCUMENTO_FISICO"
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn.HeaderText = "DF"
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn.Name = "DOCUMENTOFISICODataGridViewCheckBoxColumn"
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn.ReadOnly = True
        Me.DOCUMENTOFISICODataGridViewCheckBoxColumn.Width = 25
        '
        'ORDENESBindingSource1
        '
        Me.ORDENESBindingSource1.DataMember = "ORDENES"
        Me.ORDENESBindingSource1.DataSource = Me.ORDENESDataSet
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOMARCHIVODataGridViewTextBoxColumn
        '
        Me.NOMARCHIVODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMARCHIVODataGridViewTextBoxColumn.DataPropertyName = "NOM_ARCHIVO"
        Me.NOMARCHIVODataGridViewTextBoxColumn.HeaderText = "NOM_ARCHIVO"
        Me.NOMARCHIVODataGridViewTextBoxColumn.Name = "NOMARCHIVODataGridViewTextBoxColumn"
        Me.NOMARCHIVODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADJUNTOSBindingSource
        '
        Me.ADJUNTOSBindingSource.DataMember = "ADJUNTOS"
        Me.ADJUNTOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'INFORMESERVICIOSBindingSource
        '
        Me.INFORMESERVICIOSBindingSource.DataMember = "INFORME_SERVICIOS"
        Me.INFORMESERVICIOSBindingSource.DataSource = Me.ORDENESDataSet
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
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager1.FALLASTableAdapter = Nothing
        Me.TableAdapterManager1.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONES_TIPOTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager1.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager1.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager1.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager1.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager1.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager1.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager1.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager1.ORDENESTableAdapter = Nothing
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
        Me.TableAdapterManager1.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
        '
        'OBESERVACIONESTableAdapter
        '
        Me.OBESERVACIONESTableAdapter.ClearBeforeFill = True
        '
        'FUNCIONARIOSTableAdapter
        '
        Me.FUNCIONARIOSTableAdapter.ClearBeforeFill = True
        '
        'SECTORESTableAdapter
        '
        Me.SECTORESTableAdapter.ClearBeforeFill = True
        '
        'HISTORICOTableAdapter
        '
        Me.HISTORICOTableAdapter.ClearBeforeFill = True
        '
        'ADJUNTOSTableAdapter
        '
        Me.ADJUNTOSTableAdapter.ClearBeforeFill = True
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'HISTORICOBindingSource1
        '
        Me.HISTORICOBindingSource1.DataMember = "HISTORICO"
        Me.HISTORICOBindingSource1.DataSource = Me.ORDENESDataSet
        '
        'OrdenesDataSet1
        '
        Me.OrdenesDataSet1.DataSetName = "ORDENESDataSet"
        Me.OrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LBLNODO)
        Me.Panel3.Controls.Add(Me.BTN_REFRESCAR)
        Me.Panel3.Controls.Add(Me.BUSCA_NODO)
        Me.Panel3.Controls.Add(Me.BTN_APROBAR)
        Me.Panel3.Controls.Add(Me.FILTRO_ZONA)
        Me.Panel3.Controls.Add(Me.BTN_NUEVO)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TXT_ING_CALLE)
        Me.Panel3.Controls.Add(Me.TXT_OC)
        Me.Panel3.Controls.Add(Me.TXT_ING_NRO)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TXT_ORDENINT)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CK_STATUS)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1142, 69)
        Me.Panel3.TabIndex = 391
        '
        'SERVICIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 717)
        Me.Controls.Add(Me.DGV_ORDENES)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GB_NUEVO)
        Me.KeyPreview = True
        Me.Name = "SERVICIOS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVICIOS"
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ORDENES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GB_NUEVO.ResumeLayout(False)
        Me.GB_NUEVO.PerformLayout()
        CType(Me.DGV_ADJUNTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CAUSASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CALLESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OBESERVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECTORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADJUNTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMESERVICIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORICOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents INDICE_CALLESBindingSource As BindingSource
    Friend WithEvents INDICE_CALLESTableAdapter As INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager1 As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DGV_ORDENES As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DOCUMENTO_FISICOCheckBox As CheckBox
    Friend WithEvents ATRIBUTOTextBox As TextBox
    Friend WithEvents CAUSACIERRETextBox As TextBox
    Friend WithEvents MOTIVOCIERRETextBox As TextBox
    Friend WithEvents CAUSARIGENTextBox As TextBox
    Friend WithEvents MOTIVOORIGENTextBox As TextBox
    Friend WithEvents CUADRILLATextBox As TextBox
    Friend WithEvents SOLICITANTETextBox As TextBox
    Friend WithEvents GENERADORTextBox As TextBox
    Friend WithEvents STATUSTextBox As TextBox
    Friend WithEvents PRIORIDADTextBox As TextBox
    Friend WithEvents SECTOROPETextBox As TextBox
    Friend WithEvents TIPOTextBox As TextBox
    Friend WithEvents GB_NUEVO As GroupBox
    Friend WithEvents INDICE_CALLESDataGridView As DataGridView
    Friend WithEvents ID_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_OC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_ORDENINT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CK_STATUS As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IND_CALLE As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TXT_ING_NRO As TextBox
    Friend WithEvents TXT_ING_CALLE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FILTRO_ZONA As TextBox
    Friend WithEvents BUSCA_NODO As ComboBox
    Friend WithEvents LBLNODO As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_ESQ2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_ESQ1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_ZONA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_NODO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_CALLE As TextBox
    Friend WithEvents TXT_NRO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_ATRIBUTO As ComboBox
    Friend WithEvents CB_TIPO As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents LBL_OC As Label
    Friend WithEvents TXT_ORDEN_OC As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents CB_PRIORIDAD As ComboBox
    Friend WithEvents BTN_ADJUNTAR As Button
    Friend WithEvents CK_DOCUMENTO_FISICO As CheckBox
    Friend WithEvents BTN_INGRESAR As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_OBS As TextBox
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_MAN As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TXT_SEG As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TXT_SEC As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CB_CAUSAS As ComboBox
    Friend WithEvents INDICE_CAUSASBindingSource As BindingSource
    Friend WithEvents INDICE_CAUSASTableAdapter As INDICESDataSetTableAdapters.INDICE_CAUSASTableAdapter
    Friend WithEvents OBESERVACIONESBindingSource As BindingSource
    Friend WithEvents OBESERVACIONESTableAdapter As ORDENESDataSetTableAdapters.OBESERVACIONESTableAdapter
    Friend WithEvents FUNCIONARIOSBindingSource As BindingSource
    Friend WithEvents FUNCIONARIOSTableAdapter As ORDENESDataSetTableAdapters.FUNCIONARIOSTableAdapter
    Friend WithEvents SECTORESBindingSource As BindingSource
    Friend WithEvents SECTORESTableAdapter As ORDENESDataSetTableAdapters.SECTORESTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListArchivos As ListView
    Friend WithEvents HISTORICOBindingSource As BindingSource
    Friend WithEvents HISTORICOTableAdapter As ORDENESDataSetTableAdapters.HISTORICOTableAdapter
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents ORDENESBindingSource1 As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OBS_CIERRE As TextBox
    Friend WithEvents OBS_ORIGEN As TextBox
    Friend WithEvents DGV_ADJUNTO As DataGridView
    Friend WithEvents ADJUNTOSBindingSource As BindingSource
    Friend WithEvents ADJUNTOSTableAdapter As ORDENESDataSetTableAdapters.ADJUNTOSTableAdapter
    Friend WithEvents NOMARCHIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents ORDEN_OCTextBox As TextBox
    Friend WithEvents ID_TRABAJOTextBox As TextBox
    Friend WithEvents ID_GESTIONTextBox As TextBox
    Friend WithEvents NRO_ORDENINTTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CALLESBindingSource1 As BindingSource
    Friend WithEvents HISTORICOBindingSource1 As BindingSource
    Friend WithEvents INFORMESERVICIOSBindingSource As BindingSource
    Friend WithEvents Label22 As Label
    Friend WithEvents TXT_CANT_OC As TextBox
    Friend WithEvents TXT_CANT_OBRAC As TextBox
    Friend WithEvents BTN_APROBAR As Button
    Friend WithEvents OrdenesDataSet1 As ORDENESDataSet
    Friend WithEvents NROORDENINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDENOCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGESTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTRABAJODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINGRESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAASIGNADADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRIORIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NODODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZONADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NRODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MANZANADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ATRIBUTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTOFISICODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OC_APROBADO As DataGridViewCheckBoxColumn
    Friend WithEvents BTN_REFRESCAR As Button
    Friend WithEvents Panel3 As Panel
End Class
