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
        Dim ID_MDULabel As System.Windows.Forms.Label
        Dim ID_STATUSLabel As System.Windows.Forms.Label
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
        Me.EDIFICIODataSet = New REDES.EDIFICIODataSet()
        Me.AGENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENDATableAdapter = New REDES.EDIFICIODataSetTableAdapters.AGENDATableAdapter()
        Me.TableAdapterManager = New REDES.EDIFICIODataSetTableAdapters.TableAdapterManager()
        Me.BITACORATableAdapter = New REDES.EDIFICIODataSetTableAdapters.BITACORATableAdapter()
        Me.FTTBTableAdapter = New REDES.EDIFICIODataSetTableAdapters.FTTBTableAdapter()
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.STATUSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.STATUSTableAdapter()
        Me.TECNICOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TECNICOSTableAdapter()
        Me.TURNOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TURNOSTableAdapter()
        Me.BITACORABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TECNICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarEdificio = New System.Windows.Forms.Button()
        Me.ACOMETIDATextBox = New System.Windows.Forms.TextBox()
        Me.PISOSTextBox = New System.Windows.Forms.TextBox()
        Me.TORRETextBox = New System.Windows.Forms.TextBox()
        Me.MODIFICADODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INGRESOTextBox = New System.Windows.Forms.TextBox()
        Me.ZONATextBox = New System.Windows.Forms.TextBox()
        Me.NODOTextBox = New System.Windows.Forms.TextBox()
        Me.APTOSTextBox = New System.Windows.Forms.TextBox()
        Me.PUERTATextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.ID_CALLETextBox = New System.Windows.Forms.TextBox()
        Me.ID_STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.ID_MDUTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarCtto = New System.Windows.Forms.Button()
        Me.APTO_CTTOTextBox = New System.Windows.Forms.TextBox()
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
        Me.btnGuardarFttb = New System.Windows.Forms.Button()
        Me.CAJA_DISTRIBUCIONTextBox = New System.Windows.Forms.TextBox()
        Me.FTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACOMETIDATextBox1 = New System.Windows.Forms.TextBox()
        Me.OBS_TECTextBox = New System.Windows.Forms.TextBox()
        Me.SPL_NROTextBox = New System.Windows.Forms.TextBox()
        Me.PELOTextBox = New System.Windows.Forms.TextBox()
        Me.TUBOTextBox = New System.Windows.Forms.TextBox()
        Me.NAP_NROTextBox = New System.Windows.Forms.TextBox()
        Me.NAPTextBox = New System.Windows.Forms.TextBox()
        Me.CABLETextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_CONEXION_DESDETextBox = New System.Windows.Forms.TextBox()
        Me.CONEXION_DESDETextBox = New System.Windows.Forms.TextBox()
        Me.FTTBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarAgenda = New System.Windows.Forms.Button()
        Me.ID_TURNOTextBox = New System.Windows.Forms.TextBox()
        Me.ID_EDIFICIOTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TECNICOTextBox = New System.Windows.Forms.TextBox()
        Me.DIA_AGENDADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AGENDADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_MDULabel = New System.Windows.Forms.Label()
        ID_STATUSLabel = New System.Windows.Forms.Label()
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
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BITACORABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BITACORADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AGENDADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_MDULabel
        '
        ID_MDULabel.AutoSize = True
        ID_MDULabel.Location = New System.Drawing.Point(30, 16)
        ID_MDULabel.Name = "ID_MDULabel"
        ID_MDULabel.Size = New System.Drawing.Size(49, 13)
        ID_MDULabel.TabIndex = 0
        ID_MDULabel.Text = "ID MDU:"
        '
        'ID_STATUSLabel
        '
        ID_STATUSLabel.AutoSize = True
        ID_STATUSLabel.Location = New System.Drawing.Point(12, 39)
        ID_STATUSLabel.Name = "ID_STATUSLabel"
        ID_STATUSLabel.Size = New System.Drawing.Size(67, 13)
        ID_STATUSLabel.TabIndex = 2
        ID_STATUSLabel.Text = "ID STATUS:"
        '
        'ID_CALLELabel
        '
        ID_CALLELabel.AutoSize = True
        ID_CALLELabel.Location = New System.Drawing.Point(208, 16)
        ID_CALLELabel.Name = "ID_CALLELabel"
        ID_CALLELabel.Size = New System.Drawing.Size(57, 13)
        ID_CALLELabel.TabIndex = 4
        ID_CALLELabel.Text = "ID CALLE:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Location = New System.Drawing.Point(348, 16)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(43, 13)
        CALLELabel.TabIndex = 6
        CALLELabel.Text = "CALLE:"
        '
        'PUERTALabel
        '
        PUERTALabel.AutoSize = True
        PUERTALabel.Location = New System.Drawing.Point(640, 16)
        PUERTALabel.Name = "PUERTALabel"
        PUERTALabel.Size = New System.Drawing.Size(54, 13)
        PUERTALabel.TabIndex = 8
        PUERTALabel.Text = "PUERTA:"
        '
        'APTOSLabel
        '
        APTOSLabel.AutoSize = True
        APTOSLabel.Location = New System.Drawing.Point(834, 16)
        APTOSLabel.Name = "APTOSLabel"
        APTOSLabel.Size = New System.Drawing.Size(46, 13)
        APTOSLabel.TabIndex = 10
        APTOSLabel.Text = "APTOS:"
        '
        'NODOLabel
        '
        NODOLabel.AutoSize = True
        NODOLabel.Location = New System.Drawing.Point(992, 16)
        NODOLabel.Name = "NODOLabel"
        NODOLabel.Size = New System.Drawing.Size(42, 13)
        NODOLabel.TabIndex = 12
        NODOLabel.Text = "NODO:"
        '
        'ZONALabel
        '
        ZONALabel.AutoSize = True
        ZONALabel.Location = New System.Drawing.Point(1102, 16)
        ZONALabel.Name = "ZONALabel"
        ZONALabel.Size = New System.Drawing.Size(40, 13)
        ZONALabel.TabIndex = 14
        ZONALabel.Text = "ZONA:"
        '
        'INGRESOLabel
        '
        INGRESOLabel.AutoSize = True
        INGRESOLabel.Location = New System.Drawing.Point(206, 39)
        INGRESOLabel.Name = "INGRESOLabel"
        INGRESOLabel.Size = New System.Drawing.Size(59, 13)
        INGRESOLabel.TabIndex = 16
        INGRESOLabel.Text = "INGRESO:"
        '
        'MODIFICADOLabel
        '
        MODIFICADOLabel.AutoSize = True
        MODIFICADOLabel.Location = New System.Drawing.Point(511, 39)
        MODIFICADOLabel.Name = "MODIFICADOLabel"
        MODIFICADOLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        MODIFICADOLabel.Size = New System.Drawing.Size(77, 13)
        MODIFICADOLabel.TabIndex = 18
        MODIFICADOLabel.Text = "MODIFICADO:"
        '
        'TORRELabel
        '
        TORRELabel.AutoSize = True
        TORRELabel.Location = New System.Drawing.Point(1094, 41)
        TORRELabel.Name = "TORRELabel"
        TORRELabel.Size = New System.Drawing.Size(48, 13)
        TORRELabel.TabIndex = 20
        TORRELabel.Text = "TORRE:"
        '
        'PISOSLabel
        '
        PISOSLabel.AutoSize = True
        PISOSLabel.Location = New System.Drawing.Point(992, 41)
        PISOSLabel.Name = "PISOSLabel"
        PISOSLabel.Size = New System.Drawing.Size(42, 13)
        PISOSLabel.TabIndex = 22
        PISOSLabel.Text = "PISOS:"
        '
        'ACOMETIDALabel
        '
        ACOMETIDALabel.AutoSize = True
        ACOMETIDALabel.Location = New System.Drawing.Point(722, 39)
        ACOMETIDALabel.Name = "ACOMETIDALabel"
        ACOMETIDALabel.Size = New System.Drawing.Size(73, 13)
        ACOMETIDALabel.TabIndex = 24
        ACOMETIDALabel.Text = "ACOMETIDA:"
        '
        'CONEXION_DESDELabel
        '
        CONEXION_DESDELabel.AutoSize = True
        CONEXION_DESDELabel.Location = New System.Drawing.Point(6, 132)
        CONEXION_DESDELabel.Name = "CONEXION_DESDELabel"
        CONEXION_DESDELabel.Size = New System.Drawing.Size(63, 13)
        CONEXION_DESDELabel.TabIndex = 1
        CONEXION_DESDELabel.Text = "NRO CAJA:"
        '
        'TIPO_CONEXION_DESDELabel
        '
        TIPO_CONEXION_DESDELabel.AutoSize = True
        TIPO_CONEXION_DESDELabel.Location = New System.Drawing.Point(206, 132)
        TIPO_CONEXION_DESDELabel.Name = "TIPO_CONEXION_DESDELabel"
        TIPO_CONEXION_DESDELabel.Size = New System.Drawing.Size(64, 13)
        TIPO_CONEXION_DESDELabel.TabIndex = 3
        TIPO_CONEXION_DESDELabel.Text = "TIPO CAJA:"
        '
        'CABLELabel
        '
        CABLELabel.AutoSize = True
        CABLELabel.Location = New System.Drawing.Point(18, 188)
        CABLELabel.Name = "CABLELabel"
        CABLELabel.Size = New System.Drawing.Size(44, 13)
        CABLELabel.TabIndex = 5
        CABLELabel.Text = "CABLE:"
        '
        'NAPLabel
        '
        NAPLabel.AutoSize = True
        NAPLabel.Location = New System.Drawing.Point(483, 132)
        NAPLabel.Name = "NAPLabel"
        NAPLabel.Size = New System.Drawing.Size(32, 13)
        NAPLabel.TabIndex = 7
        NAPLabel.Text = "NAP:"
        '
        'NAP_NROLabel
        '
        NAP_NROLabel.AutoSize = True
        NAP_NROLabel.Location = New System.Drawing.Point(456, 160)
        NAP_NROLabel.Name = "NAP_NROLabel"
        NAP_NROLabel.Size = New System.Drawing.Size(59, 13)
        NAP_NROLabel.TabIndex = 9
        NAP_NROLabel.Text = "NAP NRO:"
        '
        'TUBOLabel
        '
        TUBOLabel.AutoSize = True
        TUBOLabel.Location = New System.Drawing.Point(627, 132)
        TUBOLabel.Name = "TUBOLabel"
        TUBOLabel.Size = New System.Drawing.Size(40, 13)
        TUBOLabel.TabIndex = 11
        TUBOLabel.Text = "TUBO:"
        '
        'PELOLabel
        '
        PELOLabel.AutoSize = True
        PELOLabel.Location = New System.Drawing.Point(790, 132)
        PELOLabel.Name = "PELOLabel"
        PELOLabel.Size = New System.Drawing.Size(38, 13)
        PELOLabel.TabIndex = 13
        PELOLabel.Text = "PELO:"
        '
        'SPL_NROLabel
        '
        SPL_NROLabel.AutoSize = True
        SPL_NROLabel.Location = New System.Drawing.Point(952, 132)
        SPL_NROLabel.Name = "SPL_NROLabel"
        SPL_NROLabel.Size = New System.Drawing.Size(57, 13)
        SPL_NROLabel.TabIndex = 15
        SPL_NROLabel.Text = "SPL NRO:"
        '
        'OBS_TECLabel
        '
        OBS_TECLabel.AutoSize = True
        OBS_TECLabel.Location = New System.Drawing.Point(640, 160)
        OBS_TECLabel.Name = "OBS_TECLabel"
        OBS_TECLabel.Size = New System.Drawing.Size(56, 13)
        OBS_TECLabel.TabIndex = 17
        OBS_TECLabel.Text = "OBS TEC:"
        '
        'ACOMETIDALabel1
        '
        ACOMETIDALabel1.AutoSize = True
        ACOMETIDALabel1.Location = New System.Drawing.Point(442, 188)
        ACOMETIDALabel1.Name = "ACOMETIDALabel1"
        ACOMETIDALabel1.Size = New System.Drawing.Size(73, 13)
        ACOMETIDALabel1.TabIndex = 19
        ACOMETIDALabel1.Text = "ACOMETIDA:"
        '
        'CAJA_DISTRIBUCIONLabel
        '
        CAJA_DISTRIBUCIONLabel.AutoSize = True
        CAJA_DISTRIBUCIONLabel.Location = New System.Drawing.Point(150, 161)
        CAJA_DISTRIBUCIONLabel.Name = "CAJA_DISTRIBUCIONLabel"
        CAJA_DISTRIBUCIONLabel.Size = New System.Drawing.Size(116, 13)
        CAJA_DISTRIBUCIONLabel.TabIndex = 21
        CAJA_DISTRIBUCIONLabel.Text = "DISTRIBUCION CAJA:"
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
        ID_EDIFICIOLabel.Location = New System.Drawing.Point(474, 98)
        ID_EDIFICIOLabel.Name = "ID_EDIFICIOLabel"
        ID_EDIFICIOLabel.Size = New System.Drawing.Size(69, 13)
        ID_EDIFICIOLabel.TabIndex = 5
        ID_EDIFICIOLabel.Text = "ID EDIFICIO:"
        '
        'ID_TURNOLabel
        '
        ID_TURNOLabel.AutoSize = True
        ID_TURNOLabel.Location = New System.Drawing.Point(670, 98)
        ID_TURNOLabel.Name = "ID_TURNOLabel"
        ID_TURNOLabel.Size = New System.Drawing.Size(63, 13)
        ID_TURNOLabel.TabIndex = 7
        ID_TURNOLabel.Text = "ID TURNO:"
        '
        'EDIFICIODataSet
        '
        Me.EDIFICIODataSet.DataSetName = "EDIFICIODataSet"
        Me.EDIFICIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AGENDATableAdapter = Me.AGENDATableAdapter
        Me.TableAdapterManager.AVANCETableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BITACORATableAdapter = Me.BITACORATableAdapter
        Me.TableAdapterManager.FTTBTableAdapter = Me.FTTBTableAdapter
        Me.TableAdapterManager.MDUTableAdapter = Me.MDUTableAdapter
        Me.TableAdapterManager.STATUSTableAdapter = Me.STATUSTableAdapter
        Me.TableAdapterManager.TECNICOSTableAdapter = Me.TECNICOSTableAdapter
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
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
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
        'BITACORABindingSource
        '
        Me.BITACORABindingSource.DataMember = "BITACORA"
        Me.BITACORABindingSource.DataSource = Me.EDIFICIODataSet
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
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.INGRESOTextBox)
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
        Me.GroupBox1.Controls.Add(ID_STATUSLabel)
        Me.GroupBox1.Controls.Add(Me.ID_STATUSTextBox)
        Me.GroupBox1.Controls.Add(ID_MDULabel)
        Me.GroupBox1.Controls.Add(Me.ID_MDUTextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1350, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIFICIO"
        '
        'btnGuardarEdificio
        '
        Me.btnGuardarEdificio.Location = New System.Drawing.Point(1209, 12)
        Me.btnGuardarEdificio.Name = "btnGuardarEdificio"
        Me.btnGuardarEdificio.Size = New System.Drawing.Size(129, 45)
        Me.btnGuardarEdificio.TabIndex = 26
        Me.btnGuardarEdificio.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarEdificio.UseVisualStyleBackColor = True
        '
        'ACOMETIDATextBox
        '
        Me.ACOMETIDATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "ACOMETIDA", True))
        Me.ACOMETIDATextBox.Location = New System.Drawing.Point(801, 36)
        Me.ACOMETIDATextBox.Name = "ACOMETIDATextBox"
        Me.ACOMETIDATextBox.Size = New System.Drawing.Size(59, 20)
        Me.ACOMETIDATextBox.TabIndex = 25
        '
        'PISOSTextBox
        '
        Me.PISOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "PISOS", True))
        Me.PISOSTextBox.Location = New System.Drawing.Point(1040, 37)
        Me.PISOSTextBox.Name = "PISOSTextBox"
        Me.PISOSTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PISOSTextBox.TabIndex = 23
        '
        'TORRETextBox
        '
        Me.TORRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "TORRE", True))
        Me.TORRETextBox.Location = New System.Drawing.Point(1148, 37)
        Me.TORRETextBox.Name = "TORRETextBox"
        Me.TORRETextBox.Size = New System.Drawing.Size(42, 20)
        Me.TORRETextBox.TabIndex = 21
        '
        'MODIFICADODateTimePicker
        '
        Me.MODIFICADODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MDUBindingSource, "MODIFICADO", True))
        Me.MODIFICADODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MODIFICADODateTimePicker.Location = New System.Drawing.Point(594, 35)
        Me.MODIFICADODateTimePicker.Name = "MODIFICADODateTimePicker"
        Me.MODIFICADODateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MODIFICADODateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.MODIFICADODateTimePicker.TabIndex = 19
        '
        'INGRESOTextBox
        '
        Me.INGRESOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "INGRESO", True))
        Me.INGRESOTextBox.Location = New System.Drawing.Point(271, 36)
        Me.INGRESOTextBox.Name = "INGRESOTextBox"
        Me.INGRESOTextBox.Size = New System.Drawing.Size(215, 20)
        Me.INGRESOTextBox.TabIndex = 17
        '
        'ZONATextBox
        '
        Me.ZONATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "ZONA", True))
        Me.ZONATextBox.Location = New System.Drawing.Point(1148, 12)
        Me.ZONATextBox.Name = "ZONATextBox"
        Me.ZONATextBox.Size = New System.Drawing.Size(42, 20)
        Me.ZONATextBox.TabIndex = 15
        '
        'NODOTextBox
        '
        Me.NODOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "NODO", True))
        Me.NODOTextBox.Location = New System.Drawing.Point(1040, 12)
        Me.NODOTextBox.Name = "NODOTextBox"
        Me.NODOTextBox.Size = New System.Drawing.Size(48, 20)
        Me.NODOTextBox.TabIndex = 13
        '
        'APTOSTextBox
        '
        Me.APTOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "APTOS", True))
        Me.APTOSTextBox.Location = New System.Drawing.Point(886, 13)
        Me.APTOSTextBox.Name = "APTOSTextBox"
        Me.APTOSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.APTOSTextBox.TabIndex = 11
        '
        'PUERTATextBox
        '
        Me.PUERTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "PUERTA", True))
        Me.PUERTATextBox.Location = New System.Drawing.Point(700, 13)
        Me.PUERTATextBox.Name = "PUERTATextBox"
        Me.PUERTATextBox.Size = New System.Drawing.Size(128, 20)
        Me.PUERTATextBox.TabIndex = 9
        '
        'CALLETextBox
        '
        Me.CALLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "CALLE", True))
        Me.CALLETextBox.Location = New System.Drawing.Point(397, 13)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(237, 20)
        Me.CALLETextBox.TabIndex = 7
        '
        'ID_CALLETextBox
        '
        Me.ID_CALLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "ID_CALLE", True))
        Me.ID_CALLETextBox.Location = New System.Drawing.Point(271, 13)
        Me.ID_CALLETextBox.Name = "ID_CALLETextBox"
        Me.ID_CALLETextBox.Size = New System.Drawing.Size(71, 20)
        Me.ID_CALLETextBox.TabIndex = 5
        '
        'ID_STATUSTextBox
        '
        Me.ID_STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "ID_STATUS", True))
        Me.ID_STATUSTextBox.Location = New System.Drawing.Point(85, 36)
        Me.ID_STATUSTextBox.Name = "ID_STATUSTextBox"
        Me.ID_STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_STATUSTextBox.TabIndex = 3
        '
        'ID_MDUTextBox
        '
        Me.ID_MDUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MDUBindingSource, "ID_MDU", True))
        Me.ID_MDUTextBox.Location = New System.Drawing.Point(85, 13)
        Me.ID_MDUTextBox.Name = "ID_MDUTextBox"
        Me.ID_MDUTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_MDUTextBox.TabIndex = 1
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
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(0, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1350, 270)
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
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(587, 92)
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
        Me.BITACORADataGridView.Size = New System.Drawing.Size(1344, 131)
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
        Me.GroupBox3.Controls.Add(Me.btnGuardarFttb)
        Me.GroupBox3.Controls.Add(CAJA_DISTRIBUCIONLabel)
        Me.GroupBox3.Controls.Add(Me.CAJA_DISTRIBUCIONTextBox)
        Me.GroupBox3.Controls.Add(ACOMETIDALabel1)
        Me.GroupBox3.Controls.Add(Me.ACOMETIDATextBox1)
        Me.GroupBox3.Controls.Add(OBS_TECLabel)
        Me.GroupBox3.Controls.Add(Me.OBS_TECTextBox)
        Me.GroupBox3.Controls.Add(SPL_NROLabel)
        Me.GroupBox3.Controls.Add(Me.SPL_NROTextBox)
        Me.GroupBox3.Controls.Add(PELOLabel)
        Me.GroupBox3.Controls.Add(Me.PELOTextBox)
        Me.GroupBox3.Controls.Add(TUBOLabel)
        Me.GroupBox3.Controls.Add(Me.TUBOTextBox)
        Me.GroupBox3.Controls.Add(NAP_NROLabel)
        Me.GroupBox3.Controls.Add(Me.NAP_NROTextBox)
        Me.GroupBox3.Controls.Add(NAPLabel)
        Me.GroupBox3.Controls.Add(Me.NAPTextBox)
        Me.GroupBox3.Controls.Add(CABLELabel)
        Me.GroupBox3.Controls.Add(Me.CABLETextBox)
        Me.GroupBox3.Controls.Add(TIPO_CONEXION_DESDELabel)
        Me.GroupBox3.Controls.Add(Me.TIPO_CONEXION_DESDETextBox)
        Me.GroupBox3.Controls.Add(CONEXION_DESDELabel)
        Me.GroupBox3.Controls.Add(Me.CONEXION_DESDETextBox)
        Me.GroupBox3.Controls.Add(Me.FTTBDataGridView)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1350, 218)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONEXIONADO"
        '
        'btnGuardarFttb
        '
        Me.btnGuardarFttb.Location = New System.Drawing.Point(1209, 128)
        Me.btnGuardarFttb.Name = "btnGuardarFttb"
        Me.btnGuardarFttb.Size = New System.Drawing.Size(129, 45)
        Me.btnGuardarFttb.TabIndex = 27
        Me.btnGuardarFttb.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarFttb.UseVisualStyleBackColor = True
        '
        'CAJA_DISTRIBUCIONTextBox
        '
        Me.CAJA_DISTRIBUCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "CAJA_DISTRIBUCION", True))
        Me.CAJA_DISTRIBUCIONTextBox.Location = New System.Drawing.Point(274, 157)
        Me.CAJA_DISTRIBUCIONTextBox.Name = "CAJA_DISTRIBUCIONTextBox"
        Me.CAJA_DISTRIBUCIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CAJA_DISTRIBUCIONTextBox.TabIndex = 22
        '
        'FTTBBindingSource
        '
        Me.FTTBBindingSource.DataMember = "FTTB"
        Me.FTTBBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'ACOMETIDATextBox1
        '
        Me.ACOMETIDATextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "ACOMETIDA", True))
        Me.ACOMETIDATextBox1.Location = New System.Drawing.Point(521, 185)
        Me.ACOMETIDATextBox1.Name = "ACOMETIDATextBox1"
        Me.ACOMETIDATextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ACOMETIDATextBox1.TabIndex = 20
        '
        'OBS_TECTextBox
        '
        Me.OBS_TECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "OBS_TEC", True))
        Me.OBS_TECTextBox.Location = New System.Drawing.Point(702, 157)
        Me.OBS_TECTextBox.Name = "OBS_TECTextBox"
        Me.OBS_TECTextBox.Size = New System.Drawing.Size(413, 20)
        Me.OBS_TECTextBox.TabIndex = 18
        '
        'SPL_NROTextBox
        '
        Me.SPL_NROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "SPL_NRO", True))
        Me.SPL_NROTextBox.Location = New System.Drawing.Point(1015, 129)
        Me.SPL_NROTextBox.Name = "SPL_NROTextBox"
        Me.SPL_NROTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SPL_NROTextBox.TabIndex = 16
        '
        'PELOTextBox
        '
        Me.PELOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "PELO", True))
        Me.PELOTextBox.Location = New System.Drawing.Point(834, 129)
        Me.PELOTextBox.Name = "PELOTextBox"
        Me.PELOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PELOTextBox.TabIndex = 14
        '
        'TUBOTextBox
        '
        Me.TUBOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "TUBO", True))
        Me.TUBOTextBox.Location = New System.Drawing.Point(673, 129)
        Me.TUBOTextBox.Name = "TUBOTextBox"
        Me.TUBOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TUBOTextBox.TabIndex = 12
        '
        'NAP_NROTextBox
        '
        Me.NAP_NROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "NAP_NRO", True))
        Me.NAP_NROTextBox.Location = New System.Drawing.Point(521, 157)
        Me.NAP_NROTextBox.Name = "NAP_NROTextBox"
        Me.NAP_NROTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAP_NROTextBox.TabIndex = 10
        '
        'NAPTextBox
        '
        Me.NAPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "NAP", True))
        Me.NAPTextBox.Location = New System.Drawing.Point(521, 129)
        Me.NAPTextBox.Name = "NAPTextBox"
        Me.NAPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAPTextBox.TabIndex = 8
        '
        'CABLETextBox
        '
        Me.CABLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "CABLE", True))
        Me.CABLETextBox.Location = New System.Drawing.Point(68, 185)
        Me.CABLETextBox.Name = "CABLETextBox"
        Me.CABLETextBox.Size = New System.Drawing.Size(306, 20)
        Me.CABLETextBox.TabIndex = 6
        '
        'TIPO_CONEXION_DESDETextBox
        '
        Me.TIPO_CONEXION_DESDETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "TIPO_CONEXION_DESDE", True))
        Me.TIPO_CONEXION_DESDETextBox.Location = New System.Drawing.Point(274, 129)
        Me.TIPO_CONEXION_DESDETextBox.Name = "TIPO_CONEXION_DESDETextBox"
        Me.TIPO_CONEXION_DESDETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPO_CONEXION_DESDETextBox.TabIndex = 4
        '
        'CONEXION_DESDETextBox
        '
        Me.CONEXION_DESDETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FTTBBindingSource, "CONEXION_DESDE", True))
        Me.CONEXION_DESDETextBox.Location = New System.Drawing.Point(70, 129)
        Me.CONEXION_DESDETextBox.Name = "CONEXION_DESDETextBox"
        Me.CONEXION_DESDETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONEXION_DESDETextBox.TabIndex = 2
        '
        'FTTBDataGridView
        '
        Me.FTTBDataGridView.AutoGenerateColumns = False
        Me.FTTBDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FTTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FTTBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.FTTBDataGridView.DataSource = Me.FTTBBindingSource
        Me.FTTBDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.FTTBDataGridView.GridColor = System.Drawing.Color.Green
        Me.FTTBDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.FTTBDataGridView.MultiSelect = False
        Me.FTTBDataGridView.Name = "FTTBDataGridView"
        Me.FTTBDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.FTTBDataGridView.RowHeadersVisible = False
        Me.FTTBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FTTBDataGridView.ShowCellErrors = False
        Me.FTTBDataGridView.ShowCellToolTips = False
        Me.FTTBDataGridView.ShowEditingIcon = False
        Me.FTTBDataGridView.ShowRowErrors = False
        Me.FTTBDataGridView.Size = New System.Drawing.Size(1344, 104)
        Me.FTTBDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_FTTB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_EDIFICIO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdEDI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CAJA_DISTRIBUCION"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TipoCAJA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NºCaja"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TIPO_CONEXION_DESDE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NºDistC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CABLE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CABLE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NAP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "T.NAP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NAP_NRO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NºNap"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TUBO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TUBO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PELO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PELO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SPL_NRO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NapSPL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OBS_TEC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "OBS_TEC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ACOMETIDA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ACOM"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 40
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
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(0, 554)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1350, 176)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AGENDA"
        '
        'btnGuardarAgenda
        '
        Me.btnGuardarAgenda.Location = New System.Drawing.Point(1209, 98)
        Me.btnGuardarAgenda.Name = "btnGuardarAgenda"
        Me.btnGuardarAgenda.Size = New System.Drawing.Size(129, 45)
        Me.btnGuardarAgenda.TabIndex = 29
        Me.btnGuardarAgenda.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarAgenda.UseVisualStyleBackColor = True
        '
        'ID_TURNOTextBox
        '
        Me.ID_TURNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENDABindingSource, "ID_TURNO", True))
        Me.ID_TURNOTextBox.Location = New System.Drawing.Point(739, 94)
        Me.ID_TURNOTextBox.Name = "ID_TURNOTextBox"
        Me.ID_TURNOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TURNOTextBox.TabIndex = 8
        '
        'ID_EDIFICIOTextBox
        '
        Me.ID_EDIFICIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENDABindingSource, "ID_EDIFICIO", True))
        Me.ID_EDIFICIOTextBox.Location = New System.Drawing.Point(549, 94)
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
        Me.AGENDADataGridView.Size = New System.Drawing.Size(1344, 71)
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
        'MDU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MDU"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BITACORABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BITACORADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.AGENDADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents INGRESOTextBox As TextBox
    Friend WithEvents ZONATextBox As TextBox
    Friend WithEvents NODOTextBox As TextBox
    Friend WithEvents APTOSTextBox As TextBox
    Friend WithEvents PUERTATextBox As TextBox
    Friend WithEvents CALLETextBox As TextBox
    Friend WithEvents ID_CALLETextBox As TextBox
    Friend WithEvents ID_STATUSTextBox As TextBox
    Friend WithEvents ID_MDUTextBox As TextBox
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
    Friend WithEvents ACOMETIDATextBox1 As TextBox
    Friend WithEvents OBS_TECTextBox As TextBox
    Friend WithEvents SPL_NROTextBox As TextBox
    Friend WithEvents PELOTextBox As TextBox
    Friend WithEvents TUBOTextBox As TextBox
    Friend WithEvents NAP_NROTextBox As TextBox
    Friend WithEvents NAPTextBox As TextBox
    Friend WithEvents CABLETextBox As TextBox
    Friend WithEvents TIPO_CONEXION_DESDETextBox As TextBox
    Friend WithEvents CONEXION_DESDETextBox As TextBox
    Friend WithEvents FTTBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
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
End Class
