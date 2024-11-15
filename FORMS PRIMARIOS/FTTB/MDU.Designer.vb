<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDU
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
        Dim ID_CALLELabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim PUERTALabel As System.Windows.Forms.Label
        Dim APTOSLabel As System.Windows.Forms.Label
        Dim NODOLabel As System.Windows.Forms.Label
        Dim ZONALabel As System.Windows.Forms.Label
        Dim INGRESOLabel As System.Windows.Forms.Label
        Dim MODIFICADOLabel As System.Windows.Forms.Label
        Dim TORRELabel As System.Windows.Forms.Label
        Dim PISOSLabel As System.Windows.Forms.Label
        Dim ACOMETIDALabel As System.Windows.Forms.Label
        Dim CONEXION_DESDELabel As System.Windows.Forms.Label
        Dim TIPO_CONEXION_DESDELabel As System.Windows.Forms.Label
        Dim CABLELabel As System.Windows.Forms.Label
        Dim NAPLabel As System.Windows.Forms.Label
        Dim NAP_NROLabel As System.Windows.Forms.Label
        Dim TUBOLabel As System.Windows.Forms.Label
        Dim PELOLabel As System.Windows.Forms.Label
        Dim SPL_NROLabel As System.Windows.Forms.Label
        Dim OBS_TECLabel As System.Windows.Forms.Label
        Dim ACOMETIDALabel1 As System.Windows.Forms.Label
        Dim CAJA_DISTRIBUCIONLabel As System.Windows.Forms.Label
        Dim NOMBRE_CTTOLabel As System.Windows.Forms.Label
        Dim TELEFONO_CTTOLabel As System.Windows.Forms.Label
        Dim EMAIL_CTTOLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim VALIDOLabel As System.Windows.Forms.Label
        Dim APTO_CTTOLabel As System.Windows.Forms.Label
        Dim DIA_AGENDALabel As System.Windows.Forms.Label
        Dim ID_TECNICOLabel As System.Windows.Forms.Label
        Dim ID_EDIFICIOLabel As System.Windows.Forms.Label
        Dim ID_TURNOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CARPETATextBox = New System.Windows.Forms.TextBox()
        Me.TXT_NRO = New System.Windows.Forms.TextBox()
        Me.TXT_CALLE = New System.Windows.Forms.TextBox()
        Me.BTN_AGREGAR_MDU = New System.Windows.Forms.Button()
        Me.CB_INGRESO = New System.Windows.Forms.ComboBox()
        Me.DGV_MDU = New System.Windows.Forms.DataGridView()
        Me.CARPETADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUERTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOMETIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MDU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EDIFICIODataSet = New REDES.EDIFICIODataSet()
        Me.btnGuardarEdificio = New System.Windows.Forms.Button()
        Me.ACOMETIDATextBox = New System.Windows.Forms.TextBox()
        Me.PISOSTextBox = New System.Windows.Forms.TextBox()
        Me.TORRETextBox = New System.Windows.Forms.TextBox()
        Me.MODIFICADODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ZONATextBox = New System.Windows.Forms.TextBox()
        Me.NODOTextBox = New System.Windows.Forms.TextBox()
        Me.APTOSTextBox = New System.Windows.Forms.TextBox()
        Me.PUERTATextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.ID_CALLETextBox = New System.Windows.Forms.TextBox()
        Me.EdificioDataSetBACK = New REDES.EDIFICIODataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarCtto = New System.Windows.Forms.Button()
        Me.APTO_CTTOTextBox = New System.Windows.Forms.TextBox()
        Me.BITACORABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VALIDOCheckBox = New System.Windows.Forms.CheckBox()
        Me.OBSERVACIONESTextBox = New System.Windows.Forms.TextBox()
        Me.EMAIL_CTTOTextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONO_CTTOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_CTTOTextBox = New System.Windows.Forms.TextBox()
        Me.BITACORADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FTTBDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_FTTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAPNRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONEXIONDESDEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUBODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PELODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPLNRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_AGREGAR_FTTB = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CB_TIPO_NAP = New System.Windows.Forms.ComboBox()
        Me.NAP_SPL = New System.Windows.Forms.ComboBox()
        Me.NAP_PELO = New System.Windows.Forms.ComboBox()
        Me.NAP_TUBO = New System.Windows.Forms.ComboBox()
        Me.NAP_NROTextBox = New System.Windows.Forms.TextBox()
        Me.OBS_TECTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_ACOMETIDA = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CB_CABLE = New System.Windows.Forms.ComboBox()
        Me.TXT_CONEXION_DESDE = New System.Windows.Forms.TextBox()
        Me.CB_TIPO = New System.Windows.Forms.ComboBox()
        Me.CAJA_DISTRIBUCIONTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardarFttb = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarAgenda = New System.Windows.Forms.Button()
        Me.ID_TURNOTextBox = New System.Windows.Forms.TextBox()
        Me.AGENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EDIFICIOTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TECNICOTextBox = New System.Windows.Forms.TextBox()
        Me.DIA_AGENDADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AGENDADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENDATableAdapter = New REDES.EDIFICIODataSetTableAdapters.AGENDATableAdapter()
        Me.TableAdapterManager = New REDES.EDIFICIODataSetTableAdapters.TableAdapterManager()
        Me.BITACORATableAdapter = New REDES.EDIFICIODataSetTableAdapters.BITACORATableAdapter()
        Me.FTTBTableAdapter = New REDES.EDIFICIODataSetTableAdapters.FTTBTableAdapter()
        Me.STATUSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.STATUSTableAdapter()
        Me.TECNICOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TECNICOSTableAdapter()
        Me.TURNOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TURNOSTableAdapter()
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.STATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TECNICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLORESTableAdapter = New REDES.EDIFICIODataSetTableAdapters.COLORESTableAdapter()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOTableAdapter = New REDES.EDIFICIODataSetTableAdapters.ARTICULOTableAdapter()
        Me.CABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CABLESTableAdapter = New REDES.EDIFICIODataSetTableAdapters.CABLESTableAdapter()
        ID_CALLELabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        PUERTALabel = New System.Windows.Forms.Label()
        APTOSLabel = New System.Windows.Forms.Label()
        NODOLabel = New System.Windows.Forms.Label()
        ZONALabel = New System.Windows.Forms.Label()
        INGRESOLabel = New System.Windows.Forms.Label()
        MODIFICADOLabel = New System.Windows.Forms.Label()
        TORRELabel = New System.Windows.Forms.Label()
        PISOSLabel = New System.Windows.Forms.Label()
        ACOMETIDALabel = New System.Windows.Forms.Label()
        CONEXION_DESDELabel = New System.Windows.Forms.Label()
        TIPO_CONEXION_DESDELabel = New System.Windows.Forms.Label()
        CABLELabel = New System.Windows.Forms.Label()
        NAPLabel = New System.Windows.Forms.Label()
        NAP_NROLabel = New System.Windows.Forms.Label()
        TUBOLabel = New System.Windows.Forms.Label()
        PELOLabel = New System.Windows.Forms.Label()
        SPL_NROLabel = New System.Windows.Forms.Label()
        OBS_TECLabel = New System.Windows.Forms.Label()
        ACOMETIDALabel1 = New System.Windows.Forms.Label()
        CAJA_DISTRIBUCIONLabel = New System.Windows.Forms.Label()
        NOMBRE_CTTOLabel = New System.Windows.Forms.Label()
        TELEFONO_CTTOLabel = New System.Windows.Forms.Label()
        EMAIL_CTTOLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        VALIDOLabel = New System.Windows.Forms.Label()
        APTO_CTTOLabel = New System.Windows.Forms.Label()
        DIA_AGENDALabel = New System.Windows.Forms.Label()
        ID_TECNICOLabel = New System.Windows.Forms.Label()
        ID_EDIFICIOLabel = New System.Windows.Forms.Label()
        ID_TURNOLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_MDU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificioDataSetBACK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BITACORABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BITACORADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FTTBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENDADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CALLELabel
        '
        ID_CALLELabel.AutoSize = True
        ID_CALLELabel.Location = New System.Drawing.Point(481, 19)
        ID_CALLELabel.Name = "ID_CALLELabel"
        ID_CALLELabel.Size = New System.Drawing.Size(57, 13)
        ID_CALLELabel.TabIndex = 4
        ID_CALLELabel.Text = "ID CALLE:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Location = New System.Drawing.Point(384, 31)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(43, 13)
        CALLELabel.TabIndex = 6
        CALLELabel.Text = "CALLE:"
        '
        'PUERTALabel
        '
        PUERTALabel.AutoSize = True
        PUERTALabel.Location = New System.Drawing.Point(377, 77)
        PUERTALabel.Name = "PUERTALabel"
        PUERTALabel.Size = New System.Drawing.Size(54, 13)
        PUERTALabel.TabIndex = 8
        PUERTALabel.Text = "PUERTA:"
        '
        'APTOSLabel
        '
        APTOSLabel.AutoSize = True
        APTOSLabel.Location = New System.Drawing.Point(456, 117)
        APTOSLabel.Name = "APTOSLabel"
        APTOSLabel.Size = New System.Drawing.Size(46, 13)
        APTOSLabel.TabIndex = 10
        APTOSLabel.Text = "APTOS:"
        '
        'NODOLabel
        '
        NODOLabel.AutoSize = True
        NODOLabel.Location = New System.Drawing.Point(355, 139)
        NODOLabel.Name = "NODOLabel"
        NODOLabel.Size = New System.Drawing.Size(42, 13)
        NODOLabel.TabIndex = 12
        NODOLabel.Text = "NODO:"
        '
        'ZONALabel
        '
        ZONALabel.AutoSize = True
        ZONALabel.Location = New System.Drawing.Point(357, 161)
        ZONALabel.Name = "ZONALabel"
        ZONALabel.Size = New System.Drawing.Size(40, 13)
        ZONALabel.TabIndex = 14
        ZONALabel.Text = "ZONA:"
        '
        'INGRESOLabel
        '
        INGRESOLabel.AutoSize = True
        INGRESOLabel.Location = New System.Drawing.Point(444, 183)
        INGRESOLabel.Name = "INGRESOLabel"
        INGRESOLabel.Size = New System.Drawing.Size(59, 13)
        INGRESOLabel.TabIndex = 16
        INGRESOLabel.Text = "INGRESO:"
        '
        'MODIFICADOLabel
        '
        MODIFICADOLabel.AutoSize = True
        MODIFICADOLabel.Location = New System.Drawing.Point(424, 227)
        MODIFICADOLabel.Name = "MODIFICADOLabel"
        MODIFICADOLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        MODIFICADOLabel.Size = New System.Drawing.Size(77, 13)
        MODIFICADOLabel.TabIndex = 18
        MODIFICADOLabel.Text = "MODIFICADO:"
        '
        'TORRELabel
        '
        TORRELabel.AutoSize = True
        TORRELabel.Location = New System.Drawing.Point(453, 161)
        TORRELabel.Name = "TORRELabel"
        TORRELabel.Size = New System.Drawing.Size(48, 13)
        TORRELabel.TabIndex = 20
        TORRELabel.Text = "TORRE:"
        '
        'PISOSLabel
        '
        PISOSLabel.AutoSize = True
        PISOSLabel.Location = New System.Drawing.Point(459, 139)
        PISOSLabel.Name = "PISOSLabel"
        PISOSLabel.Size = New System.Drawing.Size(42, 13)
        PISOSLabel.TabIndex = 22
        PISOSLabel.Text = "PISOS:"
        '
        'ACOMETIDALabel
        '
        ACOMETIDALabel.AutoSize = True
        ACOMETIDALabel.Location = New System.Drawing.Point(428, 205)
        ACOMETIDALabel.Name = "ACOMETIDALabel"
        ACOMETIDALabel.Size = New System.Drawing.Size(73, 13)
        ACOMETIDALabel.TabIndex = 24
        ACOMETIDALabel.Text = "ACOMETIDA:"
        '
        'CONEXION_DESDELabel
        '
        CONEXION_DESDELabel.AutoSize = True
        CONEXION_DESDELabel.Location = New System.Drawing.Point(97, 21)
        CONEXION_DESDELabel.Name = "CONEXION_DESDELabel"
        CONEXION_DESDELabel.Size = New System.Drawing.Size(55, 13)
        CONEXION_DESDELabel.TabIndex = 1
        CONEXION_DESDELabel.Text = "NUMERO"
        '
        'TIPO_CONEXION_DESDELabel
        '
        TIPO_CONEXION_DESDELabel.AutoSize = True
        TIPO_CONEXION_DESDELabel.Location = New System.Drawing.Point(120, 52)
        TIPO_CONEXION_DESDELabel.Name = "TIPO_CONEXION_DESDELabel"
        TIPO_CONEXION_DESDELabel.Size = New System.Drawing.Size(32, 13)
        TIPO_CONEXION_DESDELabel.TabIndex = 3
        TIPO_CONEXION_DESDELabel.Text = "TIPO"
        '
        'CABLELabel
        '
        CABLELabel.AutoSize = True
        CABLELabel.Location = New System.Drawing.Point(0, 108)
        CABLELabel.Name = "CABLELabel"
        CABLELabel.Size = New System.Drawing.Size(44, 13)
        CABLELabel.TabIndex = 5
        CABLELabel.Text = "CABLE:"
        '
        'NAPLabel
        '
        NAPLabel.AutoSize = True
        NAPLabel.Location = New System.Drawing.Point(23, 24)
        NAPLabel.Name = "NAPLabel"
        NAPLabel.Size = New System.Drawing.Size(60, 13)
        NAPLabel.TabIndex = 7
        NAPLabel.Text = "TIPO NAP:"
        '
        'NAP_NROLabel
        '
        NAP_NROLabel.AutoSize = True
        NAP_NROLabel.Location = New System.Drawing.Point(24, 47)
        NAP_NROLabel.Name = "NAP_NROLabel"
        NAP_NROLabel.Size = New System.Drawing.Size(59, 13)
        NAP_NROLabel.TabIndex = 9
        NAP_NROLabel.Text = "NAP NRO:"
        '
        'TUBOLabel
        '
        TUBOLabel.AutoSize = True
        TUBOLabel.Location = New System.Drawing.Point(190, 24)
        TUBOLabel.Name = "TUBOLabel"
        TUBOLabel.Size = New System.Drawing.Size(40, 13)
        TUBOLabel.TabIndex = 11
        TUBOLabel.Text = "TUBO:"
        '
        'PELOLabel
        '
        PELOLabel.AutoSize = True
        PELOLabel.Location = New System.Drawing.Point(192, 47)
        PELOLabel.Name = "PELOLabel"
        PELOLabel.Size = New System.Drawing.Size(38, 13)
        PELOLabel.TabIndex = 13
        PELOLabel.Text = "PELO:"
        '
        'SPL_NROLabel
        '
        SPL_NROLabel.AutoSize = True
        SPL_NROLabel.Location = New System.Drawing.Point(173, 70)
        SPL_NROLabel.Name = "SPL_NROLabel"
        SPL_NROLabel.Size = New System.Drawing.Size(57, 13)
        SPL_NROLabel.TabIndex = 15
        SPL_NROLabel.Text = "SPL NRO:"
        '
        'OBS_TECLabel
        '
        OBS_TECLabel.AutoSize = True
        OBS_TECLabel.Location = New System.Drawing.Point(6, 94)
        OBS_TECLabel.Name = "OBS_TECLabel"
        OBS_TECLabel.Size = New System.Drawing.Size(56, 13)
        OBS_TECLabel.TabIndex = 17
        OBS_TECLabel.Text = "OBS TEC:"
        '
        'ACOMETIDALabel1
        '
        ACOMETIDALabel1.AutoSize = True
        ACOMETIDALabel1.Location = New System.Drawing.Point(10, 70)
        ACOMETIDALabel1.Name = "ACOMETIDALabel1"
        ACOMETIDALabel1.Size = New System.Drawing.Size(73, 13)
        ACOMETIDALabel1.TabIndex = 19
        ACOMETIDALabel1.Text = "ACOMETIDA:"
        '
        'CAJA_DISTRIBUCIONLabel
        '
        CAJA_DISTRIBUCIONLabel.AutoSize = True
        CAJA_DISTRIBUCIONLabel.Location = New System.Drawing.Point(65, 81)
        CAJA_DISTRIBUCIONLabel.Name = "CAJA_DISTRIBUCIONLabel"
        CAJA_DISTRIBUCIONLabel.Size = New System.Drawing.Size(87, 13)
        CAJA_DISTRIBUCIONLabel.TabIndex = 21
        CAJA_DISTRIBUCIONLabel.Text = "DISTRIBUCION "
        '
        'NOMBRE_CTTOLabel
        '
        NOMBRE_CTTOLabel.AutoSize = True
        NOMBRE_CTTOLabel.Location = New System.Drawing.Point(12, 163)
        NOMBRE_CTTOLabel.Name = "NOMBRE_CTTOLabel"
        NOMBRE_CTTOLabel.Size = New System.Drawing.Size(89, 13)
        NOMBRE_CTTOLabel.TabIndex = 1
        NOMBRE_CTTOLabel.Text = "NOMBRE CTTO:"
        '
        'TELEFONO_CTTOLabel
        '
        TELEFONO_CTTOLabel.AutoSize = True
        TELEFONO_CTTOLabel.Location = New System.Drawing.Point(2, 188)
        TELEFONO_CTTOLabel.Name = "TELEFONO_CTTOLabel"
        TELEFONO_CTTOLabel.Size = New System.Drawing.Size(99, 13)
        TELEFONO_CTTOLabel.TabIndex = 3
        TELEFONO_CTTOLabel.Text = "TELEFONO CTTO:"
        '
        'EMAIL_CTTOLabel
        '
        EMAIL_CTTOLabel.AutoSize = True
        EMAIL_CTTOLabel.Location = New System.Drawing.Point(27, 212)
        EMAIL_CTTOLabel.Name = "EMAIL_CTTOLabel"
        EMAIL_CTTOLabel.Size = New System.Drawing.Size(74, 13)
        EMAIL_CTTOLabel.TabIndex = 5
        EMAIL_CTTOLabel.Text = "EMAIL CTTO:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(358, 163)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(101, 13)
        OBSERVACIONESLabel.TabIndex = 7
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'VALIDOLabel
        '
        VALIDOLabel.AutoSize = True
        VALIDOLabel.Location = New System.Drawing.Point(52, 239)
        VALIDOLabel.Name = "VALIDOLabel"
        VALIDOLabel.Size = New System.Drawing.Size(49, 13)
        VALIDOLabel.TabIndex = 9
        VALIDOLabel.Text = "VALIDO:"
        '
        'APTO_CTTOLabel
        '
        APTO_CTTOLabel.AutoSize = True
        APTO_CTTOLabel.Location = New System.Drawing.Point(165, 239)
        APTO_CTTOLabel.Name = "APTO_CTTOLabel"
        APTO_CTTOLabel.Size = New System.Drawing.Size(71, 13)
        APTO_CTTOLabel.TabIndex = 11
        APTO_CTTOLabel.Text = "APTO CTTO:"
        '
        'DIA_AGENDALabel
        '
        DIA_AGENDALabel.AutoSize = True
        DIA_AGENDALabel.Location = New System.Drawing.Point(12, 98)
        DIA_AGENDALabel.Name = "DIA_AGENDALabel"
        DIA_AGENDALabel.Size = New System.Drawing.Size(76, 13)
        DIA_AGENDALabel.TabIndex = 1
        DIA_AGENDALabel.Text = "DIA AGENDA:"
        '
        'ID_TECNICOLabel
        '
        ID_TECNICOLabel.AutoSize = True
        ID_TECNICOLabel.Location = New System.Drawing.Point(248, 98)
        ID_TECNICOLabel.Name = "ID_TECNICOLabel"
        ID_TECNICOLabel.Size = New System.Drawing.Size(71, 13)
        ID_TECNICOLabel.TabIndex = 3
        ID_TECNICOLabel.Text = "ID TECNICO:"
        '
        'ID_EDIFICIOLabel
        '
        ID_EDIFICIOLabel.AutoSize = True
        ID_EDIFICIOLabel.Location = New System.Drawing.Point(9, 124)
        ID_EDIFICIOLabel.Name = "ID_EDIFICIOLabel"
        ID_EDIFICIOLabel.Size = New System.Drawing.Size(69, 13)
        ID_EDIFICIOLabel.TabIndex = 5
        ID_EDIFICIOLabel.Text = "ID EDIFICIO:"
        '
        'ID_TURNOLabel
        '
        ID_TURNOLabel.AutoSize = True
        ID_TURNOLabel.Location = New System.Drawing.Point(205, 124)
        ID_TURNOLabel.Name = "ID_TURNOLabel"
        ID_TURNOLabel.Size = New System.Drawing.Size(63, 13)
        ID_TURNOLabel.TabIndex = 7
        ID_TURNOLabel.Text = "ID TURNO:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(337, 117)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 13)
        Label1.TabIndex = 36
        Label1.Text = "CARPETA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.CARPETATextBox)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO)
        Me.GroupBox1.Controls.Add(Me.TXT_CALLE)
        Me.GroupBox1.Controls.Add(Me.BTN_AGREGAR_MDU)
        Me.GroupBox1.Controls.Add(Me.CB_INGRESO)
        Me.GroupBox1.Controls.Add(Me.DGV_MDU)
        Me.GroupBox1.Controls.Add(Me.btnGuardarEdificio)
        Me.GroupBox1.Controls.Add(ACOMETIDALabel)
        Me.GroupBox1.Controls.Add(Me.ACOMETIDATextBox)
        Me.GroupBox1.Controls.Add(PISOSLabel)
        Me.GroupBox1.Controls.Add(Me.PISOSTextBox)
        Me.GroupBox1.Controls.Add(TORRELabel)
        Me.GroupBox1.Controls.Add(Me.TORRETextBox)
        Me.GroupBox1.Controls.Add(MODIFICADOLabel)
        Me.GroupBox1.Controls.Add(Me.MODIFICADODateTimePicker)
        Me.GroupBox1.Controls.Add(INGRESOLabel)
        Me.GroupBox1.Controls.Add(ZONALabel)
        Me.GroupBox1.Controls.Add(Me.ZONATextBox)
        Me.GroupBox1.Controls.Add(NODOLabel)
        Me.GroupBox1.Controls.Add(Me.NODOTextBox)
        Me.GroupBox1.Controls.Add(APTOSLabel)
        Me.GroupBox1.Controls.Add(Me.APTOSTextBox)
        Me.GroupBox1.Controls.Add(PUERTALabel)
        Me.GroupBox1.Controls.Add(Me.PUERTATextBox)
        Me.GroupBox1.Controls.Add(CALLELabel)
        Me.GroupBox1.Controls.Add(Me.CALLETextBox)
        Me.GroupBox1.Controls.Add(ID_CALLELabel)
        Me.GroupBox1.Controls.Add(Me.ID_CALLETextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIFICIO"
        '
        'CARPETATextBox
        '
        Me.CARPETATextBox.Location = New System.Drawing.Point(403, 113)
        Me.CARPETATextBox.Name = "CARPETATextBox"
        Me.CARPETATextBox.Size = New System.Drawing.Size(48, 20)
        Me.CARPETATextBox.TabIndex = 37
        '
        'TXT_NRO
        '
        Me.TXT_NRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NRO.Location = New System.Drawing.Point(267, 12)
        Me.TXT_NRO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NRO.Name = "TXT_NRO"
        Me.TXT_NRO.Size = New System.Drawing.Size(62, 20)
        Me.TXT_NRO.TabIndex = 35
        Me.TXT_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CALLE
        '
        Me.TXT_CALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CALLE.Location = New System.Drawing.Point(40, 12)
        Me.TXT_CALLE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_CALLE.Name = "TXT_CALLE"
        Me.TXT_CALLE.Size = New System.Drawing.Size(223, 20)
        Me.TXT_CALLE.TabIndex = 34
        '
        'BTN_AGREGAR_MDU
        '
        Me.BTN_AGREGAR_MDU.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_MDU.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_PRESS
        Me.BTN_AGREGAR_MDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_AGREGAR_MDU.FlatAppearance.BorderSize = 0
        Me.BTN_AGREGAR_MDU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_MDU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_MDU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_MDU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGREGAR_MDU.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_MDU.Location = New System.Drawing.Point(331, 250)
        Me.BTN_AGREGAR_MDU.Name = "BTN_AGREGAR_MDU"
        Me.BTN_AGREGAR_MDU.Size = New System.Drawing.Size(113, 45)
        Me.BTN_AGREGAR_MDU.TabIndex = 33
        Me.BTN_AGREGAR_MDU.Text = "AGREGAR"
        Me.BTN_AGREGAR_MDU.UseVisualStyleBackColor = False
        '
        'CB_INGRESO
        '
        Me.CB_INGRESO.FormattingEnabled = True
        Me.CB_INGRESO.Items.AddRange(New Object() {"AEREO", "SUBTERRANEO", "DUCTO"})
        Me.CB_INGRESO.Location = New System.Drawing.Point(507, 179)
        Me.CB_INGRESO.Name = "CB_INGRESO"
        Me.CB_INGRESO.Size = New System.Drawing.Size(102, 21)
        Me.CB_INGRESO.TabIndex = 30
        Me.CB_INGRESO.Text = "AEREO"
        '
        'DGV_MDU
        '
        Me.DGV_MDU.AllowUserToAddRows = False
        Me.DGV_MDU.AllowUserToDeleteRows = False
        Me.DGV_MDU.AutoGenerateColumns = False
        Me.DGV_MDU.BackgroundColor = System.Drawing.Color.White
        Me.DGV_MDU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MDU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CARPETADataGridViewTextBoxColumn, Me.CALLEDataGridViewTextBoxColumn, Me.PUERTADataGridViewTextBoxColumn, Me.ACOMETIDADataGridViewTextBoxColumn, Me.ID_MDU})
        Me.DGV_MDU.DataSource = Me.MDUBindingSource
        Me.DGV_MDU.GridColor = System.Drawing.Color.Green
        Me.DGV_MDU.Location = New System.Drawing.Point(3, 37)
        Me.DGV_MDU.MultiSelect = False
        Me.DGV_MDU.Name = "DGV_MDU"
        Me.DGV_MDU.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_MDU.RowHeadersVisible = False
        Me.DGV_MDU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_MDU.ShowCellErrors = False
        Me.DGV_MDU.ShowCellToolTips = False
        Me.DGV_MDU.ShowEditingIcon = False
        Me.DGV_MDU.ShowRowErrors = False
        Me.DGV_MDU.Size = New System.Drawing.Size(322, 266)
        Me.DGV_MDU.TabIndex = 27
        '
        'CARPETADataGridViewTextBoxColumn
        '
        Me.CARPETADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CARPETADataGridViewTextBoxColumn.DataPropertyName = "CARPETA"
        Me.CARPETADataGridViewTextBoxColumn.HeaderText = "CARPETA"
        Me.CARPETADataGridViewTextBoxColumn.Name = "CARPETADataGridViewTextBoxColumn"
        '
        'CALLEDataGridViewTextBoxColumn
        '
        Me.CALLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CALLEDataGridViewTextBoxColumn.DataPropertyName = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.HeaderText = "CALLE"
        Me.CALLEDataGridViewTextBoxColumn.Name = "CALLEDataGridViewTextBoxColumn"
        '
        'PUERTADataGridViewTextBoxColumn
        '
        Me.PUERTADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PUERTADataGridViewTextBoxColumn.DataPropertyName = "PUERTA"
        Me.PUERTADataGridViewTextBoxColumn.HeaderText = "PUERTA"
        Me.PUERTADataGridViewTextBoxColumn.Name = "PUERTADataGridViewTextBoxColumn"
        '
        'ACOMETIDADataGridViewTextBoxColumn
        '
        Me.ACOMETIDADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ACOMETIDADataGridViewTextBoxColumn.DataPropertyName = "ACOMETIDA"
        Me.ACOMETIDADataGridViewTextBoxColumn.HeaderText = "ACOMETIDA"
        Me.ACOMETIDADataGridViewTextBoxColumn.Name = "ACOMETIDADataGridViewTextBoxColumn"
        '
        'ID_MDU
        '
        Me.ID_MDU.DataPropertyName = "ID_MDU"
        Me.ID_MDU.HeaderText = "ID_MDU"
        Me.ID_MDU.Name = "ID_MDU"
        Me.ID_MDU.Visible = False
        '
        'MDUBindingSource
        '
        Me.MDUBindingSource.DataMember = "MDU"
        Me.MDUBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'EDIFICIODataSet
        '
        Me.EDIFICIODataSet.DataSetName = "EDIFICIODataSet"
        Me.EDIFICIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGuardarEdificio
        '
        Me.btnGuardarEdificio.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarEdificio.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_OVER
        Me.btnGuardarEdificio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarEdificio.FlatAppearance.BorderSize = 0
        Me.btnGuardarEdificio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardarEdificio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardarEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEdificio.ForeColor = System.Drawing.Color.White
        Me.btnGuardarEdificio.Location = New System.Drawing.Point(478, 249)
        Me.btnGuardarEdificio.Name = "btnGuardarEdificio"
        Me.btnGuardarEdificio.Size = New System.Drawing.Size(129, 45)
        Me.btnGuardarEdificio.TabIndex = 26
        Me.btnGuardarEdificio.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarEdificio.UseVisualStyleBackColor = False
        '
        'ACOMETIDATextBox
        '
        Me.ACOMETIDATextBox.Location = New System.Drawing.Point(507, 202)
        Me.ACOMETIDATextBox.Name = "ACOMETIDATextBox"
        Me.ACOMETIDATextBox.Size = New System.Drawing.Size(59, 20)
        Me.ACOMETIDATextBox.TabIndex = 25
        '
        'PISOSTextBox
        '
        Me.PISOSTextBox.Location = New System.Drawing.Point(507, 135)
        Me.PISOSTextBox.Name = "PISOSTextBox"
        Me.PISOSTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PISOSTextBox.TabIndex = 23
        '
        'TORRETextBox
        '
        Me.TORRETextBox.Location = New System.Drawing.Point(507, 157)
        Me.TORRETextBox.Name = "TORRETextBox"
        Me.TORRETextBox.Size = New System.Drawing.Size(48, 20)
        Me.TORRETextBox.TabIndex = 21
        '
        'MODIFICADODateTimePicker
        '
        Me.MODIFICADODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MODIFICADODateTimePicker.Location = New System.Drawing.Point(507, 223)
        Me.MODIFICADODateTimePicker.Name = "MODIFICADODateTimePicker"
        Me.MODIFICADODateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MODIFICADODateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.MODIFICADODateTimePicker.TabIndex = 19
        '
        'ZONATextBox
        '
        Me.ZONATextBox.Location = New System.Drawing.Point(403, 157)
        Me.ZONATextBox.Name = "ZONATextBox"
        Me.ZONATextBox.Size = New System.Drawing.Size(48, 20)
        Me.ZONATextBox.TabIndex = 15
        '
        'NODOTextBox
        '
        Me.NODOTextBox.Location = New System.Drawing.Point(403, 135)
        Me.NODOTextBox.Name = "NODOTextBox"
        Me.NODOTextBox.Size = New System.Drawing.Size(48, 20)
        Me.NODOTextBox.TabIndex = 13
        '
        'APTOSTextBox
        '
        Me.APTOSTextBox.Location = New System.Drawing.Point(507, 113)
        Me.APTOSTextBox.Name = "APTOSTextBox"
        Me.APTOSTextBox.Size = New System.Drawing.Size(48, 20)
        Me.APTOSTextBox.TabIndex = 11
        '
        'PUERTATextBox
        '
        Me.PUERTATextBox.Location = New System.Drawing.Point(437, 74)
        Me.PUERTATextBox.Name = "PUERTATextBox"
        Me.PUERTATextBox.Size = New System.Drawing.Size(79, 20)
        Me.PUERTATextBox.TabIndex = 9
        '
        'CALLETextBox
        '
        Me.CALLETextBox.Location = New System.Drawing.Point(378, 47)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(237, 20)
        Me.CALLETextBox.TabIndex = 7
        '
        'ID_CALLETextBox
        '
        Me.ID_CALLETextBox.Location = New System.Drawing.Point(544, 16)
        Me.ID_CALLETextBox.Name = "ID_CALLETextBox"
        Me.ID_CALLETextBox.Size = New System.Drawing.Size(71, 20)
        Me.ID_CALLETextBox.TabIndex = 5
        '
        'EdificioDataSetBACK
        '
        Me.EdificioDataSetBACK.DataSetName = "EDIFICIODataSet"
        Me.EdificioDataSetBACK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGuardarCtto)
        Me.GroupBox2.Controls.Add(APTO_CTTOLabel)
        Me.GroupBox2.Controls.Add(Me.APTO_CTTOTextBox)
        Me.GroupBox2.Controls.Add(VALIDOLabel)
        Me.GroupBox2.Controls.Add(Me.VALIDOCheckBox)
        Me.GroupBox2.Controls.Add(OBSERVACIONESLabel)
        Me.GroupBox2.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.GroupBox2.Controls.Add(EMAIL_CTTOLabel)
        Me.GroupBox2.Controls.Add(Me.EMAIL_CTTOTextBox)
        Me.GroupBox2.Controls.Add(TELEFONO_CTTOLabel)
        Me.GroupBox2.Controls.Add(Me.TELEFONO_CTTOTextBox)
        Me.GroupBox2.Controls.Add(NOMBRE_CTTOLabel)
        Me.GroupBox2.Controls.Add(Me.NOMBRE_CTTOTextBox)
        Me.GroupBox2.Controls.Add(Me.BITACORADataGridView)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(0, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 347)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTACTOS"
        '
        'btnGuardarCtto
        '
        Me.btnGuardarCtto.Location = New System.Drawing.Point(1209, 156)
        Me.btnGuardarCtto.Name = "btnGuardarCtto"
        Me.btnGuardarCtto.Size = New System.Drawing.Size(129, 45)
        Me.btnGuardarCtto.TabIndex = 28
        Me.btnGuardarCtto.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarCtto.UseVisualStyleBackColor = True
        '
        'APTO_CTTOTextBox
        '
        Me.APTO_CTTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BITACORABindingSource, "APTO_CTTO", True))
        Me.APTO_CTTOTextBox.Location = New System.Drawing.Point(242, 235)
        Me.APTO_CTTOTextBox.Name = "APTO_CTTOTextBox"
        Me.APTO_CTTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.APTO_CTTOTextBox.TabIndex = 12
        '
        'BITACORABindingSource
        '
        Me.BITACORABindingSource.DataMember = "BITACORA"
        Me.BITACORABindingSource.DataSource = Me.EDIFICIODataSet
        '
        'VALIDOCheckBox
        '
        Me.VALIDOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BITACORABindingSource, "VALIDO", True))
        Me.VALIDOCheckBox.Location = New System.Drawing.Point(107, 233)
        Me.VALIDOCheckBox.Name = "VALIDOCheckBox"
        Me.VALIDOCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.VALIDOCheckBox.TabIndex = 10
        Me.VALIDOCheckBox.UseVisualStyleBackColor = True
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BITACORABindingSource, "OBSERVACIONES", True))
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(465, 160)
        Me.OBSERVACIONESTextBox.Multiline = True
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(168, 160)
        Me.OBSERVACIONESTextBox.TabIndex = 8
        '
        'EMAIL_CTTOTextBox
        '
        Me.EMAIL_CTTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BITACORABindingSource, "EMAIL_CTTO", True))
        Me.EMAIL_CTTOTextBox.Location = New System.Drawing.Point(107, 209)
        Me.EMAIL_CTTOTextBox.Name = "EMAIL_CTTOTextBox"
        Me.EMAIL_CTTOTextBox.Size = New System.Drawing.Size(235, 20)
        Me.EMAIL_CTTOTextBox.TabIndex = 6
        '
        'TELEFONO_CTTOTextBox
        '
        Me.TELEFONO_CTTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BITACORABindingSource, "TELEFONO_CTTO", True))
        Me.TELEFONO_CTTOTextBox.Location = New System.Drawing.Point(107, 185)
        Me.TELEFONO_CTTOTextBox.Name = "TELEFONO_CTTOTextBox"
        Me.TELEFONO_CTTOTextBox.Size = New System.Drawing.Size(235, 20)
        Me.TELEFONO_CTTOTextBox.TabIndex = 4
        '
        'NOMBRE_CTTOTextBox
        '
        Me.NOMBRE_CTTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BITACORABindingSource, "NOMBRE_CTTO", True))
        Me.NOMBRE_CTTOTextBox.Location = New System.Drawing.Point(107, 160)
        Me.NOMBRE_CTTOTextBox.Name = "NOMBRE_CTTOTextBox"
        Me.NOMBRE_CTTOTextBox.Size = New System.Drawing.Size(235, 20)
        Me.NOMBRE_CTTOTextBox.TabIndex = 2
        '
        'BITACORADataGridView
        '
        Me.BITACORADataGridView.AutoGenerateColumns = False
        Me.BITACORADataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BITACORADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BITACORADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn21})
        Me.BITACORADataGridView.DataSource = Me.BITACORABindingSource
        Me.BITACORADataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.BITACORADataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BITACORADataGridView.Location = New System.Drawing.Point(3, 16)
        Me.BITACORADataGridView.MultiSelect = False
        Me.BITACORADataGridView.Name = "BITACORADataGridView"
        Me.BITACORADataGridView.RowHeadersVisible = False
        Me.BITACORADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BITACORADataGridView.ShowCellErrors = False
        Me.BITACORADataGridView.ShowCellToolTips = False
        Me.BITACORADataGridView.ShowEditingIcon = False
        Me.BITACORADataGridView.ShowRowErrors = False
        Me.BITACORADataGridView.Size = New System.Drawing.Size(760, 131)
        Me.BITACORADataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ID_BITACORA"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID_BITACORA"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FECHA_ING"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FECHA_ING"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NOMBRE_CTTO"
        Me.DataGridViewTextBoxColumn17.HeaderText = "NOMBRE_CTTO"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TELEFONO_CTTO"
        Me.DataGridViewTextBoxColumn18.HeaderText = "TELEFONO_CTTO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "EMAIL_CTTO"
        Me.DataGridViewTextBoxColumn19.HeaderText = "EMAIL_CTTO"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn20.HeaderText = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "VALIDO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "VALIDO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "APTO_CTTO"
        Me.DataGridViewTextBoxColumn21.HeaderText = "APTO_CTTO"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.FTTBDataGridView)
        Me.GroupBox3.Controls.Add(Me.BTN_AGREGAR_FTTB)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.btnGuardarFttb)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(670, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(677, 306)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONEXIONADO"
        '
        'FTTBDataGridView
        '
        Me.FTTBDataGridView.AllowUserToAddRows = False
        Me.FTTBDataGridView.AllowUserToDeleteRows = False
        Me.FTTBDataGridView.AllowUserToResizeColumns = False
        Me.FTTBDataGridView.AllowUserToResizeRows = False
        Me.FTTBDataGridView.AutoGenerateColumns = False
        Me.FTTBDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FTTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FTTBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_FTTB, Me.NAPDataGridViewTextBoxColumn, Me.NAPNRODataGridViewTextBoxColumn, Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn, Me.CONEXIONDESDEDataGridViewTextBoxColumn, Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn, Me.TUBODataGridViewTextBoxColumn, Me.PELODataGridViewTextBoxColumn, Me.SPLNRODataGridViewTextBoxColumn})
        Me.FTTBDataGridView.DataSource = Me.FTTBBindingSource
        Me.FTTBDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FTTBDataGridView.Location = New System.Drawing.Point(355, 16)
        Me.FTTBDataGridView.MultiSelect = False
        Me.FTTBDataGridView.Name = "FTTBDataGridView"
        Me.FTTBDataGridView.ReadOnly = True
        Me.FTTBDataGridView.RowHeadersVisible = False
        Me.FTTBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.FTTBDataGridView.ShowCellErrors = False
        Me.FTTBDataGridView.ShowCellToolTips = False
        Me.FTTBDataGridView.ShowEditingIcon = False
        Me.FTTBDataGridView.ShowRowErrors = False
        Me.FTTBDataGridView.Size = New System.Drawing.Size(353, 279)
        Me.FTTBDataGridView.TabIndex = 32
        '
        'ID_FTTB
        '
        Me.ID_FTTB.DataPropertyName = "ID_FTTB"
        Me.ID_FTTB.HeaderText = "ID_FTTB"
        Me.ID_FTTB.Name = "ID_FTTB"
        Me.ID_FTTB.ReadOnly = True
        Me.ID_FTTB.Visible = False
        '
        'NAPDataGridViewTextBoxColumn
        '
        Me.NAPDataGridViewTextBoxColumn.DataPropertyName = "NAP"
        Me.NAPDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.NAPDataGridViewTextBoxColumn.Name = "NAPDataGridViewTextBoxColumn"
        Me.NAPDataGridViewTextBoxColumn.ReadOnly = True
        Me.NAPDataGridViewTextBoxColumn.Width = 40
        '
        'NAPNRODataGridViewTextBoxColumn
        '
        Me.NAPNRODataGridViewTextBoxColumn.DataPropertyName = "NAP_NRO"
        Me.NAPNRODataGridViewTextBoxColumn.HeaderText = "NRO"
        Me.NAPNRODataGridViewTextBoxColumn.Name = "NAPNRODataGridViewTextBoxColumn"
        Me.NAPNRODataGridViewTextBoxColumn.ReadOnly = True
        Me.NAPNRODataGridViewTextBoxColumn.Width = 30
        '
        'TIPOCONEXIONDESDEDataGridViewTextBoxColumn
        '
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn.DataPropertyName = "TIPO_CONEXION_DESDE"
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn.HeaderText = "CAJ"
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn.Name = "TIPOCONEXIONDESDEDataGridViewTextBoxColumn"
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPOCONEXIONDESDEDataGridViewTextBoxColumn.Width = 40
        '
        'CONEXIONDESDEDataGridViewTextBoxColumn
        '
        Me.CONEXIONDESDEDataGridViewTextBoxColumn.DataPropertyName = "CONEXION_DESDE"
        Me.CONEXIONDESDEDataGridViewTextBoxColumn.HeaderText = "CNRO"
        Me.CONEXIONDESDEDataGridViewTextBoxColumn.Name = "CONEXIONDESDEDataGridViewTextBoxColumn"
        Me.CONEXIONDESDEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CONEXIONDESDEDataGridViewTextBoxColumn.Width = 40
        '
        'CAJADISTRIBUCIONDataGridViewTextBoxColumn
        '
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn.DataPropertyName = "CAJA_DISTRIBUCION"
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn.HeaderText = "DIST"
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn.Name = "CAJADISTRIBUCIONDataGridViewTextBoxColumn"
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJADISTRIBUCIONDataGridViewTextBoxColumn.Width = 40
        '
        'TUBODataGridViewTextBoxColumn
        '
        Me.TUBODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TUBODataGridViewTextBoxColumn.DataPropertyName = "TUBO"
        Me.TUBODataGridViewTextBoxColumn.HeaderText = "TUBO"
        Me.TUBODataGridViewTextBoxColumn.Name = "TUBODataGridViewTextBoxColumn"
        Me.TUBODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PELODataGridViewTextBoxColumn
        '
        Me.PELODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PELODataGridViewTextBoxColumn.DataPropertyName = "PELO"
        Me.PELODataGridViewTextBoxColumn.HeaderText = "PELO"
        Me.PELODataGridViewTextBoxColumn.Name = "PELODataGridViewTextBoxColumn"
        Me.PELODataGridViewTextBoxColumn.ReadOnly = True
        '
        'SPLNRODataGridViewTextBoxColumn
        '
        Me.SPLNRODataGridViewTextBoxColumn.DataPropertyName = "SPL_NRO"
        Me.SPLNRODataGridViewTextBoxColumn.HeaderText = "SPL"
        Me.SPLNRODataGridViewTextBoxColumn.Name = "SPLNRODataGridViewTextBoxColumn"
        Me.SPLNRODataGridViewTextBoxColumn.ReadOnly = True
        Me.SPLNRODataGridViewTextBoxColumn.Width = 35
        '
        'FTTBBindingSource
        '
        Me.FTTBBindingSource.DataMember = "FTTB"
        Me.FTTBBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'BTN_AGREGAR_FTTB
        '
        Me.BTN_AGREGAR_FTTB.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_FTTB.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_PRESS
        Me.BTN_AGREGAR_FTTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_AGREGAR_FTTB.FlatAppearance.BorderSize = 0
        Me.BTN_AGREGAR_FTTB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_FTTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_FTTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGAR_FTTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGREGAR_FTTB.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_FTTB.Location = New System.Drawing.Point(236, 109)
        Me.BTN_AGREGAR_FTTB.Name = "BTN_AGREGAR_FTTB"
        Me.BTN_AGREGAR_FTTB.Size = New System.Drawing.Size(113, 45)
        Me.BTN_AGREGAR_FTTB.TabIndex = 32
        Me.BTN_AGREGAR_FTTB.Text = "AGREGAR"
        Me.BTN_AGREGAR_FTTB.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CB_TIPO_NAP)
        Me.GroupBox6.Controls.Add(Me.NAP_SPL)
        Me.GroupBox6.Controls.Add(Me.NAP_PELO)
        Me.GroupBox6.Controls.Add(Me.NAP_TUBO)
        Me.GroupBox6.Controls.Add(NAPLabel)
        Me.GroupBox6.Controls.Add(Me.NAP_NROTextBox)
        Me.GroupBox6.Controls.Add(SPL_NROLabel)
        Me.GroupBox6.Controls.Add(OBS_TECLabel)
        Me.GroupBox6.Controls.Add(ACOMETIDALabel1)
        Me.GroupBox6.Controls.Add(PELOLabel)
        Me.GroupBox6.Controls.Add(Me.OBS_TECTextBox)
        Me.GroupBox6.Controls.Add(NAP_NROLabel)
        Me.GroupBox6.Controls.Add(TUBOLabel)
        Me.GroupBox6.Controls.Add(Me.TXT_ACOMETIDA)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 160)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(346, 135)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CONEXION INTERIOR"
        '
        'CB_TIPO_NAP
        '
        Me.CB_TIPO_NAP.FormattingEnabled = True
        Me.CB_TIPO_NAP.Items.AddRange(New Object() {"4", "8", "16"})
        Me.CB_TIPO_NAP.Location = New System.Drawing.Point(89, 19)
        Me.CB_TIPO_NAP.Name = "CB_TIPO_NAP"
        Me.CB_TIPO_NAP.Size = New System.Drawing.Size(48, 21)
        Me.CB_TIPO_NAP.TabIndex = 24
        Me.CB_TIPO_NAP.Text = "8"
        '
        'NAP_SPL
        '
        Me.NAP_SPL.FormattingEnabled = True
        Me.NAP_SPL.Items.AddRange(New Object() {"1", "2"})
        Me.NAP_SPL.Location = New System.Drawing.Point(235, 66)
        Me.NAP_SPL.Name = "NAP_SPL"
        Me.NAP_SPL.Size = New System.Drawing.Size(99, 21)
        Me.NAP_SPL.TabIndex = 23
        Me.NAP_SPL.Text = "1"
        '
        'NAP_PELO
        '
        Me.NAP_PELO.FormattingEnabled = True
        Me.NAP_PELO.Items.AddRange(New Object() {"AZUL", "NARANJA", "VERDE", "MARRON", "GRIS", "BLANCO", "ROJO", "NEGRO", "AMARILLO", "VIOLETA", "ROSADO", "CELESTE"})
        Me.NAP_PELO.Location = New System.Drawing.Point(235, 43)
        Me.NAP_PELO.Name = "NAP_PELO"
        Me.NAP_PELO.Size = New System.Drawing.Size(99, 21)
        Me.NAP_PELO.TabIndex = 22
        Me.NAP_PELO.Text = "AZUL"
        '
        'NAP_TUBO
        '
        Me.NAP_TUBO.FormattingEnabled = True
        Me.NAP_TUBO.Items.AddRange(New Object() {"AZUL", "NARANJA", "VERDE", "MARRON", "GRIS", "BLANCO", "ROJO", "NEGRO", "AMARILLO", "VIOLETA", "ROSADO", "CELESTE"})
        Me.NAP_TUBO.Location = New System.Drawing.Point(235, 20)
        Me.NAP_TUBO.Name = "NAP_TUBO"
        Me.NAP_TUBO.Size = New System.Drawing.Size(99, 21)
        Me.NAP_TUBO.TabIndex = 21
        Me.NAP_TUBO.Text = "AZUL"
        '
        'NAP_NROTextBox
        '
        Me.NAP_NROTextBox.Location = New System.Drawing.Point(89, 43)
        Me.NAP_NROTextBox.Name = "NAP_NROTextBox"
        Me.NAP_NROTextBox.Size = New System.Drawing.Size(48, 20)
        Me.NAP_NROTextBox.TabIndex = 10
        Me.NAP_NROTextBox.Text = "1"
        Me.NAP_NROTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OBS_TECTextBox
        '
        Me.OBS_TECTextBox.Location = New System.Drawing.Point(71, 90)
        Me.OBS_TECTextBox.Multiline = True
        Me.OBS_TECTextBox.Name = "OBS_TECTextBox"
        Me.OBS_TECTextBox.Size = New System.Drawing.Size(263, 39)
        Me.OBS_TECTextBox.TabIndex = 18
        '
        'TXT_ACOMETIDA
        '
        Me.TXT_ACOMETIDA.Location = New System.Drawing.Point(89, 66)
        Me.TXT_ACOMETIDA.Name = "TXT_ACOMETIDA"
        Me.TXT_ACOMETIDA.Size = New System.Drawing.Size(48, 20)
        Me.TXT_ACOMETIDA.TabIndex = 20
        Me.TXT_ACOMETIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CB_CABLE)
        Me.GroupBox5.Controls.Add(Me.TXT_CONEXION_DESDE)
        Me.GroupBox5.Controls.Add(Me.CB_TIPO)
        Me.GroupBox5.Controls.Add(CONEXION_DESDELabel)
        Me.GroupBox5.Controls.Add(TIPO_CONEXION_DESDELabel)
        Me.GroupBox5.Controls.Add(CAJA_DISTRIBUCIONLabel)
        Me.GroupBox5.Controls.Add(CABLELabel)
        Me.GroupBox5.Controls.Add(Me.CAJA_DISTRIBUCIONTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(227, 135)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CONEXION EXTERIOR"
        '
        'CB_CABLE
        '
        Me.CB_CABLE.FormattingEnabled = True
        Me.CB_CABLE.Items.AddRange(New Object() {"Acometida (12 fibras 1 tubo)", "Acometida (12 fibras 2 tubos)", "Distribución (24 fibras 4 tubos)"})
        Me.CB_CABLE.Location = New System.Drawing.Point(50, 105)
        Me.CB_CABLE.Name = "CB_CABLE"
        Me.CB_CABLE.Size = New System.Drawing.Size(166, 21)
        Me.CB_CABLE.TabIndex = 29
        Me.CB_CABLE.Text = "Acometida (12 fibras 1 tubo)"
        '
        'TXT_CONEXION_DESDE
        '
        Me.TXT_CONEXION_DESDE.Location = New System.Drawing.Point(154, 18)
        Me.TXT_CONEXION_DESDE.Name = "TXT_CONEXION_DESDE"
        Me.TXT_CONEXION_DESDE.Size = New System.Drawing.Size(62, 20)
        Me.TXT_CONEXION_DESDE.TabIndex = 2
        Me.TXT_CONEXION_DESDE.Text = "1"
        Me.TXT_CONEXION_DESDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_TIPO
        '
        Me.CB_TIPO.FormattingEnabled = True
        Me.CB_TIPO.Items.AddRange(New Object() {"CED", "FDH", "NAP"})
        Me.CB_TIPO.Location = New System.Drawing.Point(153, 47)
        Me.CB_TIPO.Name = "CB_TIPO"
        Me.CB_TIPO.Size = New System.Drawing.Size(63, 21)
        Me.CB_TIPO.TabIndex = 28
        Me.CB_TIPO.Text = "CED"
        '
        'CAJA_DISTRIBUCIONTextBox
        '
        Me.CAJA_DISTRIBUCIONTextBox.Location = New System.Drawing.Point(153, 77)
        Me.CAJA_DISTRIBUCIONTextBox.Name = "CAJA_DISTRIBUCIONTextBox"
        Me.CAJA_DISTRIBUCIONTextBox.Size = New System.Drawing.Size(63, 20)
        Me.CAJA_DISTRIBUCIONTextBox.TabIndex = 22
        Me.CAJA_DISTRIBUCIONTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGuardarFttb
        '
        Me.btnGuardarFttb.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarFttb.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_OVER
        Me.btnGuardarFttb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarFttb.FlatAppearance.BorderSize = 0
        Me.btnGuardarFttb.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnGuardarFttb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardarFttb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardarFttb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFttb.ForeColor = System.Drawing.Color.White
        Me.btnGuardarFttb.Location = New System.Drawing.Point(236, 58)
        Me.btnGuardarFttb.Name = "btnGuardarFttb"
        Me.btnGuardarFttb.Size = New System.Drawing.Size(113, 45)
        Me.btnGuardarFttb.TabIndex = 27
        Me.btnGuardarFttb.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarFttb.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGuardarAgenda)
        Me.GroupBox4.Controls.Add(ID_TURNOLabel)
        Me.GroupBox4.Controls.Add(Me.ID_TURNOTextBox)
        Me.GroupBox4.Controls.Add(ID_EDIFICIOLabel)
        Me.GroupBox4.Controls.Add(Me.ID_EDIFICIOTextBox)
        Me.GroupBox4.Controls.Add(ID_TECNICOLabel)
        Me.GroupBox4.Controls.Add(Me.ID_TECNICOTextBox)
        Me.GroupBox4.Controls.Add(DIA_AGENDALabel)
        Me.GroupBox4.Controls.Add(Me.DIA_AGENDADateTimePicker)
        Me.GroupBox4.Controls.Add(Me.AGENDADataGridView)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(824, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 170)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AGENDA"
        '
        'btnGuardarAgenda
        '
        Me.btnGuardarAgenda.Location = New System.Drawing.Point(380, 119)
        Me.btnGuardarAgenda.Name = "btnGuardarAgenda"
        Me.btnGuardarAgenda.Size = New System.Drawing.Size(79, 45)
        Me.btnGuardarAgenda.TabIndex = 29
        Me.btnGuardarAgenda.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarAgenda.UseVisualStyleBackColor = True
        '
        'ID_TURNOTextBox
        '
        Me.ID_TURNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENDABindingSource, "ID_TURNO", True))
        Me.ID_TURNOTextBox.Location = New System.Drawing.Point(274, 120)
        Me.ID_TURNOTextBox.Name = "ID_TURNOTextBox"
        Me.ID_TURNOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TURNOTextBox.TabIndex = 8
        '
        'AGENDABindingSource
        '
        Me.AGENDABindingSource.DataMember = "AGENDA"
        Me.AGENDABindingSource.DataSource = Me.EDIFICIODataSet
        '
        'ID_EDIFICIOTextBox
        '
        Me.ID_EDIFICIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENDABindingSource, "ID_EDIFICIO", True))
        Me.ID_EDIFICIOTextBox.Location = New System.Drawing.Point(84, 120)
        Me.ID_EDIFICIOTextBox.Name = "ID_EDIFICIOTextBox"
        Me.ID_EDIFICIOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_EDIFICIOTextBox.TabIndex = 6
        '
        'ID_TECNICOTextBox
        '
        Me.ID_TECNICOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENDABindingSource, "ID_TECNICO", True))
        Me.ID_TECNICOTextBox.Location = New System.Drawing.Point(325, 94)
        Me.ID_TECNICOTextBox.Name = "ID_TECNICOTextBox"
        Me.ID_TECNICOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TECNICOTextBox.TabIndex = 4
        '
        'DIA_AGENDADateTimePicker
        '
        Me.DIA_AGENDADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AGENDABindingSource, "DIA_AGENDA", True))
        Me.DIA_AGENDADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DIA_AGENDADateTimePicker.Location = New System.Drawing.Point(94, 94)
        Me.DIA_AGENDADateTimePicker.Name = "DIA_AGENDADateTimePicker"
        Me.DIA_AGENDADateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.DIA_AGENDADateTimePicker.TabIndex = 2
        '
        'AGENDADataGridView
        '
        Me.AGENDADataGridView.AllowUserToAddRows = False
        Me.AGENDADataGridView.AllowUserToDeleteRows = False
        Me.AGENDADataGridView.AllowUserToResizeColumns = False
        Me.AGENDADataGridView.AllowUserToResizeRows = False
        Me.AGENDADataGridView.AutoGenerateColumns = False
        Me.AGENDADataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AGENDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AGENDADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.AGENDADataGridView.DataSource = Me.AGENDABindingSource
        Me.AGENDADataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.AGENDADataGridView.Location = New System.Drawing.Point(3, 16)
        Me.AGENDADataGridView.Name = "AGENDADataGridView"
        Me.AGENDADataGridView.RowHeadersVisible = False
        Me.AGENDADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AGENDADataGridView.ShowCellErrors = False
        Me.AGENDADataGridView.ShowCellToolTips = False
        Me.AGENDADataGridView.ShowEditingIcon = False
        Me.AGENDADataGridView.ShowRowErrors = False
        Me.AGENDADataGridView.Size = New System.Drawing.Size(506, 71)
        Me.AGENDADataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ID_AGENDA"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ID_AGENDA"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "ID_TURNO"
        Me.DataGridViewTextBoxColumn24.HeaderText = "ID_TURNO"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "ID_TECNICO"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ID_TECNICO"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DIA_AGENDA"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DIA_AGENDA"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1350, 325)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "CONTROL TECNICO"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_FTTB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_FTTB"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TIPO_CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TIPO_CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CABLE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CABLE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NAP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NAP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NAP_NRO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NAP_NRO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TUBO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TUBO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PELO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PELO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SPL_NRO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SPL_NRO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OBS_TEC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "OBS_TEC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ACOMETIDA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ACOMETIDA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CAJA_DISTRIBUCION"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CAJA_DISTRIBUCION"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'AGENDATableAdapter
        '
        Me.AGENDATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AGENDATableAdapter = Me.AGENDATableAdapter
        Me.TableAdapterManager.ARTICULOTableAdapter = Nothing
        Me.TableAdapterManager.AVANCETableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BITACORATableAdapter = Me.BITACORATableAdapter
        Me.TableAdapterManager.CABLESTableAdapter = Nothing
        Me.TableAdapterManager.CALLESTableAdapter = Nothing
        Me.TableAdapterManager.CERTIFICACIONESTableAdapter = Nothing
        Me.TableAdapterManager.COLORESTableAdapter = Nothing
        Me.TableAdapterManager.FTTBTableAdapter = Me.FTTBTableAdapter
        Me.TableAdapterManager.INGRESOTableAdapter = Nothing
        Me.TableAdapterManager.MDUTableAdapter = Nothing
        Me.TableAdapterManager.OBS_MDUTableAdapter = Nothing
        Me.TableAdapterManager.STATUSTableAdapter = Me.STATUSTableAdapter
        Me.TableAdapterManager.TECNICOSTableAdapter = Me.TECNICOSTableAdapter
        Me.TableAdapterManager.TRONCALESTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Me.TURNOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = REDES.EDIFICIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BITACORATableAdapter
        '
        Me.BITACORATableAdapter.ClearBeforeFill = True
        '
        'FTTBTableAdapter
        '
        Me.FTTBTableAdapter.ClearBeforeFill = True
        '
        'STATUSTableAdapter
        '
        Me.STATUSTableAdapter.ClearBeforeFill = True
        '
        'TECNICOSTableAdapter
        '
        Me.TECNICOSTableAdapter.ClearBeforeFill = True
        '
        'TURNOSTableAdapter
        '
        Me.TURNOSTableAdapter.ClearBeforeFill = True
        '
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
        '
        'STATUSBindingSource
        '
        Me.STATUSBindingSource.DataMember = "STATUS"
        Me.STATUSBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'TECNICOSBindingSource
        '
        Me.TECNICOSBindingSource.DataMember = "TECNICOS"
        Me.TECNICOSBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'TURNOSBindingSource
        '
        Me.TURNOSBindingSource.DataMember = "TURNOS"
        Me.TURNOSBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'ARTICULOTableAdapter
        '
        Me.ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'CABLESBindingSource
        '
        Me.CABLESBindingSource.DataMember = "CABLES"
        Me.CABLESBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'CABLESTableAdapter
        '
        Me.CABLESTableAdapter.ClearBeforeFill = True
        '
        'MDU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "MDU"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_MDU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificioDataSetBACK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BITACORABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BITACORADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.FTTBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENDADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EDIFICIODataSet As EDIFICIODataSet
    Friend WithEvents AGENDABindingSource As BindingSource
    Friend WithEvents AGENDATableAdapter As EDIFICIODataSetTableAdapters.AGENDATableAdapter
    Friend WithEvents TableAdapterManager As EDIFICIODataSetTableAdapters.TableAdapterManager
    Friend WithEvents BITACORATableAdapter As EDIFICIODataSetTableAdapters.BITACORATableAdapter
    Friend WithEvents BITACORABindingSource As BindingSource
    Friend WithEvents MDUTableAdapter As EDIFICIODataSetTableAdapters.MDUTableAdapter
    Friend WithEvents MDUBindingSource As BindingSource
    Friend WithEvents STATUSTableAdapter As EDIFICIODataSetTableAdapters.STATUSTableAdapter
    Friend WithEvents STATUSBindingSource As BindingSource
    Friend WithEvents TECNICOSTableAdapter As EDIFICIODataSetTableAdapters.TECNICOSTableAdapter
    Friend WithEvents TECNICOSBindingSource As BindingSource
    Friend WithEvents TURNOSTableAdapter As EDIFICIODataSetTableAdapters.TURNOSTableAdapter
    Friend WithEvents TURNOSBindingSource As BindingSource
    Friend WithEvents FTTBTableAdapter As EDIFICIODataSetTableAdapters.FTTBTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardarEdificio As Button
    Friend WithEvents ACOMETIDATextBox As TextBox
    Friend WithEvents PISOSTextBox As TextBox
    Friend WithEvents TORRETextBox As TextBox
    Friend WithEvents MODIFICADODateTimePicker As DateTimePicker
    Friend WithEvents ZONATextBox As TextBox
    Friend WithEvents NODOTextBox As TextBox
    Friend WithEvents APTOSTextBox As TextBox
    Friend WithEvents PUERTATextBox As TextBox
    Friend WithEvents CALLETextBox As TextBox
    Friend WithEvents ID_CALLETextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents FTTBBindingSource As BindingSource
    Friend WithEvents btnGuardarCtto As Button
    Friend WithEvents APTO_CTTOTextBox As TextBox
    Friend WithEvents VALIDOCheckBox As CheckBox
    Friend WithEvents OBSERVACIONESTextBox As TextBox
    Friend WithEvents EMAIL_CTTOTextBox As TextBox
    Friend WithEvents TELEFONO_CTTOTextBox As TextBox
    Friend WithEvents NOMBRE_CTTOTextBox As TextBox
    Friend WithEvents BITACORADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardarFttb As Button
    Friend WithEvents CAJA_DISTRIBUCIONTextBox As TextBox
    Friend WithEvents TXT_ACOMETIDA As TextBox
    Friend WithEvents OBS_TECTextBox As TextBox
    Friend WithEvents NAP_NROTextBox As TextBox
    Friend WithEvents TXT_CONEXION_DESDE As TextBox
    Friend WithEvents btnGuardarAgenda As Button
    Friend WithEvents ID_TURNOTextBox As TextBox
    Friend WithEvents ID_EDIFICIOTextBox As TextBox
    Friend WithEvents ID_TECNICOTextBox As TextBox
    Friend WithEvents DIA_AGENDADateTimePicker As DateTimePicker
    Friend WithEvents AGENDADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CB_CABLE As ComboBox
    Friend WithEvents CB_TIPO As ComboBox
    Friend WithEvents BTN_AGREGAR_FTTB As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents NAP_SPL As ComboBox
    Friend WithEvents NAP_PELO As ComboBox
    Friend WithEvents NAP_TUBO As ComboBox
    Friend WithEvents CB_INGRESO As ComboBox
    Friend WithEvents DGV_MDU As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BTN_AGREGAR_MDU As Button
    Friend WithEvents FTTBDataGridView As DataGridView
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
    Friend WithEvents TXT_NRO As TextBox
    Friend WithEvents TXT_CALLE As TextBox
    Friend WithEvents CB_TIPO_NAP As ComboBox
    Friend WithEvents EdificioDataSetBACK As EDIFICIODataSet
    Friend WithEvents CARPETADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUERTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACOMETIDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_MDU As DataGridViewTextBoxColumn
    Friend WithEvents ID_FTTB As DataGridViewTextBoxColumn
    Friend WithEvents NAPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAPNRODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOCONEXIONDESDEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONEXIONDESDEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAJADISTRIBUCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TUBODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PELODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPLNRODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CARPETATextBox As TextBox
    Friend WithEvents COLORESBindingSource As BindingSource
    Friend WithEvents COLORESTableAdapter As EDIFICIODataSetTableAdapters.COLORESTableAdapter
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As EDIFICIODataSetTableAdapters.ARTICULOTableAdapter
    Friend WithEvents CABLESBindingSource As BindingSource
    Friend WithEvents CABLESTableAdapter As EDIFICIODataSetTableAdapters.CABLESTableAdapter
End Class
