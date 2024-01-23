<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ORDEN
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
        Dim NRO_ORDENINTLabel As System.Windows.Forms.Label
        Dim NRO_ORDINALLabel As System.Windows.Forms.Label
        Dim ID_GESTIONLabel As System.Windows.Forms.Label
        Dim ID_TRABAJOLabel As System.Windows.Forms.Label
        Dim TIPOLabel As System.Windows.Forms.Label
        Dim SECTOROPELabel As System.Windows.Forms.Label
        Dim SECTORDESTINOLabel As System.Windows.Forms.Label
        Dim FECHASOLLabel As System.Windows.Forms.Label
        Dim FECHAINGRESOLabel As System.Windows.Forms.Label
        Dim FECHAINICIOLabel As System.Windows.Forms.Label
        Dim FECHAFINLabel As System.Windows.Forms.Label
        Dim PRIORIDADLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim GENERADORLabel As System.Windows.Forms.Label
        Dim SOLICITANTELabel As System.Windows.Forms.Label
        Dim CUADRILLALabel As System.Windows.Forms.Label
        Dim NODOLabel As System.Windows.Forms.Label
        Dim ZONALabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim NROLabel As System.Windows.Forms.Label
        Dim MOTIVOORIGENLabel As System.Windows.Forms.Label
        Dim CAUSARIGENLabel As System.Windows.Forms.Label
        Dim MOTIVOCIERRELabel As System.Windows.Forms.Label
        Dim CAUSACIERRELabel As System.Windows.Forms.Label
        Dim INSTALACIONLabel As System.Windows.Forms.Label
        Dim INSTALACIONRUSLabel As System.Windows.Forms.Label
        Dim MANZANALabel As System.Windows.Forms.Label
        Dim FECHAAGENDLabel As System.Windows.Forms.Label
        Dim FECHA_ASIGNADALabel As System.Windows.Forms.Label
        Dim PROYECTO_ORDINALLabel As System.Windows.Forms.Label
        Dim GEST_SOLICITADOLabel As System.Windows.Forms.Label
        Dim ATRIBUTOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NRO_ORDEN = New System.Windows.Forms.TextBox()
        Me.ORDINAL = New System.Windows.Forms.TextBox()
        Me.GESTION = New System.Windows.Forms.TextBox()
        Me.TRABAJO = New System.Windows.Forms.TextBox()
        Me.MOTIVO = New System.Windows.Forms.TextBox()
        Me.INSTALACION = New System.Windows.Forms.TextBox()
        Me.INSTALACION_RUS = New System.Windows.Forms.TextBox()
        Me.CALLE = New System.Windows.Forms.TextBox()
        Me.ORDENESDataGridView = New System.Windows.Forms.DataGridView()
        Me.NRO_ORDENINTTextBox = New System.Windows.Forms.TextBox()
        Me.NRO_ORDINALTextBox = New System.Windows.Forms.TextBox()
        Me.ID_GESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TRABAJOTextBox = New System.Windows.Forms.TextBox()
        Me.TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.SECTOROPETextBox = New System.Windows.Forms.TextBox()
        Me.SECTORDESTINOTextBox = New System.Windows.Forms.TextBox()
        Me.PRIORIDADTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.GENERADORTextBox = New System.Windows.Forms.TextBox()
        Me.SOLICITANTETextBox = New System.Windows.Forms.TextBox()
        Me.CUADRILLATextBox = New System.Windows.Forms.TextBox()
        Me.NODOTextBox = New System.Windows.Forms.TextBox()
        Me.ZONATextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.NROTextBox = New System.Windows.Forms.TextBox()
        Me.MOTIVOORIGENTextBox = New System.Windows.Forms.TextBox()
        Me.CAUSARIGENTextBox = New System.Windows.Forms.TextBox()
        Me.MOTIVOCIERRETextBox = New System.Windows.Forms.TextBox()
        Me.CAUSACIERRETextBox = New System.Windows.Forms.TextBox()
        Me.INSTALACIONTextBox = New System.Windows.Forms.TextBox()
        Me.INSTALACIONRUSTextBox = New System.Windows.Forms.TextBox()
        Me.MANZANATextBox = New System.Windows.Forms.TextBox()
        Me.PROYECTO_ORDINALTextBox = New System.Windows.Forms.TextBox()
        Me.GEST_SOLICITADOTextBox = New System.Windows.Forms.TextBox()
        Me.ATRIBUTOTextBox = New System.Windows.Forms.TextBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.BTN_GUARDAR = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
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
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        NRO_ORDENINTLabel = New System.Windows.Forms.Label()
        NRO_ORDINALLabel = New System.Windows.Forms.Label()
        ID_GESTIONLabel = New System.Windows.Forms.Label()
        ID_TRABAJOLabel = New System.Windows.Forms.Label()
        TIPOLabel = New System.Windows.Forms.Label()
        SECTOROPELabel = New System.Windows.Forms.Label()
        SECTORDESTINOLabel = New System.Windows.Forms.Label()
        FECHASOLLabel = New System.Windows.Forms.Label()
        FECHAINGRESOLabel = New System.Windows.Forms.Label()
        FECHAINICIOLabel = New System.Windows.Forms.Label()
        FECHAFINLabel = New System.Windows.Forms.Label()
        PRIORIDADLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        GENERADORLabel = New System.Windows.Forms.Label()
        SOLICITANTELabel = New System.Windows.Forms.Label()
        CUADRILLALabel = New System.Windows.Forms.Label()
        NODOLabel = New System.Windows.Forms.Label()
        ZONALabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        NROLabel = New System.Windows.Forms.Label()
        MOTIVOORIGENLabel = New System.Windows.Forms.Label()
        CAUSARIGENLabel = New System.Windows.Forms.Label()
        MOTIVOCIERRELabel = New System.Windows.Forms.Label()
        CAUSACIERRELabel = New System.Windows.Forms.Label()
        INSTALACIONLabel = New System.Windows.Forms.Label()
        INSTALACIONRUSLabel = New System.Windows.Forms.Label()
        MANZANALabel = New System.Windows.Forms.Label()
        FECHAAGENDLabel = New System.Windows.Forms.Label()
        FECHA_ASIGNADALabel = New System.Windows.Forms.Label()
        PROYECTO_ORDINALLabel = New System.Windows.Forms.Label()
        GEST_SOLICITADOLabel = New System.Windows.Forms.Label()
        ATRIBUTOLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.ORDENESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NRO_ORDENINTLabel
        '
        NRO_ORDENINTLabel.AutoSize = True
        NRO_ORDENINTLabel.Location = New System.Drawing.Point(6, 268)
        NRO_ORDENINTLabel.Name = "NRO_ORDENINTLabel"
        NRO_ORDENINTLabel.Size = New System.Drawing.Size(94, 13)
        NRO_ORDENINTLabel.TabIndex = 10
        NRO_ORDENINTLabel.Text = "NRO ORDENINT:"
        '
        'NRO_ORDINALLabel
        '
        NRO_ORDINALLabel.AutoSize = True
        NRO_ORDINALLabel.Location = New System.Drawing.Point(15, 291)
        NRO_ORDINALLabel.Name = "NRO_ORDINALLabel"
        NRO_ORDINALLabel.Size = New System.Drawing.Size(85, 13)
        NRO_ORDINALLabel.TabIndex = 12
        NRO_ORDINALLabel.Text = "NRO ORDINAL:"
        '
        'ID_GESTIONLabel
        '
        ID_GESTIONLabel.AutoSize = True
        ID_GESTIONLabel.Location = New System.Drawing.Point(28, 314)
        ID_GESTIONLabel.Name = "ID_GESTIONLabel"
        ID_GESTIONLabel.Size = New System.Drawing.Size(72, 13)
        ID_GESTIONLabel.TabIndex = 14
        ID_GESTIONLabel.Text = "ID GESTION:"
        '
        'ID_TRABAJOLabel
        '
        ID_TRABAJOLabel.AutoSize = True
        ID_TRABAJOLabel.Location = New System.Drawing.Point(27, 337)
        ID_TRABAJOLabel.Name = "ID_TRABAJOLabel"
        ID_TRABAJOLabel.Size = New System.Drawing.Size(73, 13)
        ID_TRABAJOLabel.TabIndex = 16
        ID_TRABAJOLabel.Text = "ID TRABAJO:"
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.Location = New System.Drawing.Point(304, 268)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(35, 13)
        TIPOLabel.TabIndex = 18
        TIPOLabel.Text = "TIPO:"
        '
        'SECTOROPELabel
        '
        SECTOROPELabel.AutoSize = True
        SECTOROPELabel.Location = New System.Drawing.Point(260, 290)
        SECTOROPELabel.Name = "SECTOROPELabel"
        SECTOROPELabel.Size = New System.Drawing.Size(79, 13)
        SECTOROPELabel.TabIndex = 20
        SECTOROPELabel.Text = "SECTOR OPE:"
        '
        'SECTORDESTINOLabel
        '
        SECTORDESTINOLabel.AutoSize = True
        SECTORDESTINOLabel.Location = New System.Drawing.Point(234, 312)
        SECTORDESTINOLabel.Name = "SECTORDESTINOLabel"
        SECTORDESTINOLabel.Size = New System.Drawing.Size(105, 13)
        SECTORDESTINOLabel.TabIndex = 22
        SECTORDESTINOLabel.Text = "SECTOR DESTINO:"
        '
        'FECHASOLLabel
        '
        FECHASOLLabel.AutoSize = True
        FECHASOLLabel.Location = New System.Drawing.Point(1027, 273)
        FECHASOLLabel.Name = "FECHASOLLabel"
        FECHASOLLabel.Size = New System.Drawing.Size(112, 13)
        FECHASOLLabel.TabIndex = 24
        FECHASOLLabel.Text = "FECHA SOLICITADO:"
        FECHASOLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FECHAINGRESOLabel
        '
        FECHAINGRESOLabel.AutoSize = True
        FECHAINGRESOLabel.Location = New System.Drawing.Point(1042, 294)
        FECHAINGRESOLabel.Name = "FECHAINGRESOLabel"
        FECHAINGRESOLabel.Size = New System.Drawing.Size(97, 13)
        FECHAINGRESOLabel.TabIndex = 26
        FECHAINGRESOLabel.Text = "FECHA INGRESO:"
        FECHAINGRESOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FECHAINICIOLabel
        '
        FECHAINICIOLabel.AutoSize = True
        FECHAINICIOLabel.Location = New System.Drawing.Point(1059, 315)
        FECHAINICIOLabel.Name = "FECHAINICIOLabel"
        FECHAINICIOLabel.Size = New System.Drawing.Size(80, 13)
        FECHAINICIOLabel.TabIndex = 28
        FECHAINICIOLabel.Text = "FECHA INICIO:"
        FECHAINICIOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FECHAFINLabel
        '
        FECHAFINLabel.AutoSize = True
        FECHAFINLabel.Location = New System.Drawing.Point(1074, 336)
        FECHAFINLabel.Name = "FECHAFINLabel"
        FECHAFINLabel.Size = New System.Drawing.Size(65, 13)
        FECHAFINLabel.TabIndex = 30
        FECHAFINLabel.Text = "FECHA FIN:"
        FECHAFINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PRIORIDADLabel
        '
        PRIORIDADLabel.AutoSize = True
        PRIORIDADLabel.Location = New System.Drawing.Point(30, 360)
        PRIORIDADLabel.Name = "PRIORIDADLabel"
        PRIORIDADLabel.Size = New System.Drawing.Size(70, 13)
        PRIORIDADLabel.TabIndex = 32
        PRIORIDADLabel.Text = "PRIORIDAD:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(47, 383)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 34
        STATUSLabel.Text = "STATUS:"
        '
        'GENERADORLabel
        '
        GENERADORLabel.AutoSize = True
        GENERADORLabel.Location = New System.Drawing.Point(21, 406)
        GENERADORLabel.Name = "GENERADORLabel"
        GENERADORLabel.Size = New System.Drawing.Size(79, 13)
        GENERADORLabel.TabIndex = 36
        GENERADORLabel.Text = "GENERADOR:"
        '
        'SOLICITANTELabel
        '
        SOLICITANTELabel.AutoSize = True
        SOLICITANTELabel.Location = New System.Drawing.Point(20, 429)
        SOLICITANTELabel.Name = "SOLICITANTELabel"
        SOLICITANTELabel.Size = New System.Drawing.Size(80, 13)
        SOLICITANTELabel.TabIndex = 38
        SOLICITANTELabel.Text = "SOLICITANTE:"
        '
        'CUADRILLALabel
        '
        CUADRILLALabel.AutoSize = True
        CUADRILLALabel.Location = New System.Drawing.Point(269, 334)
        CUADRILLALabel.Name = "CUADRILLALabel"
        CUADRILLALabel.Size = New System.Drawing.Size(70, 13)
        CUADRILLALabel.TabIndex = 40
        CUADRILLALabel.Text = "CUADRILLA:"
        '
        'NODOLabel
        '
        NODOLabel.AutoSize = True
        NODOLabel.Location = New System.Drawing.Point(58, 452)
        NODOLabel.Name = "NODOLabel"
        NODOLabel.Size = New System.Drawing.Size(42, 13)
        NODOLabel.TabIndex = 42
        NODOLabel.Text = "NODO:"
        '
        'ZONALabel
        '
        ZONALabel.AutoSize = True
        ZONALabel.Location = New System.Drawing.Point(60, 475)
        ZONALabel.Name = "ZONALabel"
        ZONALabel.Size = New System.Drawing.Size(40, 13)
        ZONALabel.TabIndex = 44
        ZONALabel.Text = "ZONA:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Location = New System.Drawing.Point(254, 359)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(43, 13)
        CALLELabel.TabIndex = 46
        CALLELabel.Text = "CALLE:"
        '
        'NROLabel
        '
        NROLabel.AutoSize = True
        NROLabel.Location = New System.Drawing.Point(263, 381)
        NROLabel.Name = "NROLabel"
        NROLabel.Size = New System.Drawing.Size(34, 13)
        NROLabel.TabIndex = 48
        NROLabel.Text = "NRO:"
        '
        'MOTIVOORIGENLabel
        '
        MOTIVOORIGENLabel.AutoSize = True
        MOTIVOORIGENLabel.Location = New System.Drawing.Point(527, 360)
        MOTIVOORIGENLabel.Name = "MOTIVOORIGENLabel"
        MOTIVOORIGENLabel.Size = New System.Drawing.Size(97, 13)
        MOTIVOORIGENLabel.TabIndex = 50
        MOTIVOORIGENLabel.Text = "MOTIVO ORIGEN:"
        '
        'CAUSARIGENLabel
        '
        CAUSARIGENLabel.AutoSize = True
        CAUSARIGENLabel.Location = New System.Drawing.Point(533, 383)
        CAUSARIGENLabel.Name = "CAUSARIGENLabel"
        CAUSARIGENLabel.Size = New System.Drawing.Size(91, 13)
        CAUSARIGENLabel.TabIndex = 52
        CAUSARIGENLabel.Text = "CAUSA ORIGEN:"
        '
        'MOTIVOCIERRELabel
        '
        MOTIVOCIERRELabel.AutoSize = True
        MOTIVOCIERRELabel.Location = New System.Drawing.Point(529, 406)
        MOTIVOCIERRELabel.Name = "MOTIVOCIERRELabel"
        MOTIVOCIERRELabel.Size = New System.Drawing.Size(95, 13)
        MOTIVOCIERRELabel.TabIndex = 54
        MOTIVOCIERRELabel.Text = "MOTIVO CIERRE:"
        '
        'CAUSACIERRELabel
        '
        CAUSACIERRELabel.AutoSize = True
        CAUSACIERRELabel.Location = New System.Drawing.Point(535, 429)
        CAUSACIERRELabel.Name = "CAUSACIERRELabel"
        CAUSACIERRELabel.Size = New System.Drawing.Size(89, 13)
        CAUSACIERRELabel.TabIndex = 56
        CAUSACIERRELabel.Text = "CAUSA CIERRE:"
        '
        'INSTALACIONLabel
        '
        INSTALACIONLabel.AutoSize = True
        INSTALACIONLabel.Location = New System.Drawing.Point(543, 268)
        INSTALACIONLabel.Name = "INSTALACIONLabel"
        INSTALACIONLabel.Size = New System.Drawing.Size(81, 13)
        INSTALACIONLabel.TabIndex = 58
        INSTALACIONLabel.Text = "INSTALACION:"
        '
        'INSTALACIONRUSLabel
        '
        INSTALACIONRUSLabel.AutoSize = True
        INSTALACIONRUSLabel.Location = New System.Drawing.Point(517, 291)
        INSTALACIONRUSLabel.Name = "INSTALACIONRUSLabel"
        INSTALACIONRUSLabel.Size = New System.Drawing.Size(107, 13)
        INSTALACIONRUSLabel.TabIndex = 60
        INSTALACIONRUSLabel.Text = "INSTALACION RUS:"
        '
        'MANZANALabel
        '
        MANZANALabel.AutoSize = True
        MANZANALabel.Location = New System.Drawing.Point(37, 498)
        MANZANALabel.Name = "MANZANALabel"
        MANZANALabel.Size = New System.Drawing.Size(63, 13)
        MANZANALabel.TabIndex = 62
        MANZANALabel.Text = "MANZANA:"
        '
        'FECHAAGENDLabel
        '
        FECHAAGENDLabel.AutoSize = True
        FECHAAGENDLabel.Location = New System.Drawing.Point(1046, 357)
        FECHAAGENDLabel.Name = "FECHAAGENDLabel"
        FECHAAGENDLabel.Size = New System.Drawing.Size(93, 13)
        FECHAAGENDLabel.TabIndex = 64
        FECHAAGENDLabel.Text = "FECHA AGENDA:"
        FECHAAGENDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FECHA_ASIGNADALabel
        '
        FECHA_ASIGNADALabel.AutoSize = True
        FECHA_ASIGNADALabel.Location = New System.Drawing.Point(1036, 378)
        FECHA_ASIGNADALabel.Name = "FECHA_ASIGNADALabel"
        FECHA_ASIGNADALabel.Size = New System.Drawing.Size(103, 13)
        FECHA_ASIGNADALabel.TabIndex = 66
        FECHA_ASIGNADALabel.Text = "FECHA ASIGNADA:"
        FECHA_ASIGNADALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PROYECTO_ORDINALLabel
        '
        PROYECTO_ORDINALLabel.AutoSize = True
        PROYECTO_ORDINALLabel.Location = New System.Drawing.Point(504, 452)
        PROYECTO_ORDINALLabel.Name = "PROYECTO_ORDINALLabel"
        PROYECTO_ORDINALLabel.Size = New System.Drawing.Size(120, 13)
        PROYECTO_ORDINALLabel.TabIndex = 68
        PROYECTO_ORDINALLabel.Text = "PROYECTO ORDINAL:"
        '
        'GEST_SOLICITADOLabel
        '
        GEST_SOLICITADOLabel.AutoSize = True
        GEST_SOLICITADOLabel.Location = New System.Drawing.Point(518, 314)
        GEST_SOLICITADOLabel.Name = "GEST_SOLICITADOLabel"
        GEST_SOLICITADOLabel.Size = New System.Drawing.Size(106, 13)
        GEST_SOLICITADOLabel.TabIndex = 70
        GEST_SOLICITADOLabel.Text = "GEST SOLICITADO:"
        '
        'ATRIBUTOLabel
        '
        ATRIBUTOLabel.AutoSize = True
        ATRIBUTOLabel.Location = New System.Drawing.Point(559, 337)
        ATRIBUTOLabel.Name = "ATRIBUTOLabel"
        ATRIBUTOLabel.Size = New System.Drawing.Size(65, 13)
        ATRIBUTOLabel.TabIndex = 72
        ATRIBUTOLabel.Text = "ATRIBUTO:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 13)
        Label1.TabIndex = 74
        Label1.Text = "NRO ORDENINT"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(132, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 13)
        Label2.TabIndex = 75
        Label2.Text = "NRO ORDINAL"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(233, 9)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 13)
        Label3.TabIndex = 76
        Label3.Text = "ID GESTION"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(341, 9)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 13)
        Label4.TabIndex = 77
        Label4.Text = "ID TRABAJO"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(437, 9)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(94, 13)
        Label6.TabIndex = 79
        Label6.Text = "MOTIVO ORIGEN"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(615, 9)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(78, 13)
        Label7.TabIndex = 80
        Label7.Text = "INSTALACION"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(710, 9)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(104, 13)
        Label8.TabIndex = 81
        Label8.Text = "INSTALACION RUS"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(848, 9)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(40, 13)
        Label9.TabIndex = 82
        Label9.Text = "CALLE"
        '
        'NRO_ORDEN
        '
        Me.NRO_ORDEN.Location = New System.Drawing.Point(12, 23)
        Me.NRO_ORDEN.Name = "NRO_ORDEN"
        Me.NRO_ORDEN.Size = New System.Drawing.Size(100, 20)
        Me.NRO_ORDEN.TabIndex = 0
        '
        'ORDINAL
        '
        Me.ORDINAL.Location = New System.Drawing.Point(118, 23)
        Me.ORDINAL.Name = "ORDINAL"
        Me.ORDINAL.Size = New System.Drawing.Size(100, 20)
        Me.ORDINAL.TabIndex = 1
        '
        'GESTION
        '
        Me.GESTION.Location = New System.Drawing.Point(224, 23)
        Me.GESTION.Name = "GESTION"
        Me.GESTION.Size = New System.Drawing.Size(100, 20)
        Me.GESTION.TabIndex = 2
        '
        'TRABAJO
        '
        Me.TRABAJO.Location = New System.Drawing.Point(330, 23)
        Me.TRABAJO.Name = "TRABAJO"
        Me.TRABAJO.Size = New System.Drawing.Size(100, 20)
        Me.TRABAJO.TabIndex = 3
        '
        'MOTIVO
        '
        Me.MOTIVO.Location = New System.Drawing.Point(437, 23)
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.Size = New System.Drawing.Size(165, 20)
        Me.MOTIVO.TabIndex = 5
        '
        'INSTALACION
        '
        Me.INSTALACION.Location = New System.Drawing.Point(608, 23)
        Me.INSTALACION.Name = "INSTALACION"
        Me.INSTALACION.Size = New System.Drawing.Size(100, 20)
        Me.INSTALACION.TabIndex = 6
        '
        'INSTALACION_RUS
        '
        Me.INSTALACION_RUS.Location = New System.Drawing.Point(714, 23)
        Me.INSTALACION_RUS.Name = "INSTALACION_RUS"
        Me.INSTALACION_RUS.Size = New System.Drawing.Size(100, 20)
        Me.INSTALACION_RUS.TabIndex = 7
        '
        'CALLE
        '
        Me.CALLE.Location = New System.Drawing.Point(820, 23)
        Me.CALLE.Name = "CALLE"
        Me.CALLE.Size = New System.Drawing.Size(185, 20)
        Me.CALLE.TabIndex = 8
        '
        'ORDENESDataGridView
        '
        Me.ORDENESDataGridView.AutoGenerateColumns = False
        Me.ORDENESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ORDENESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn63, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn64, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68})
        Me.ORDENESDataGridView.DataSource = Me.ORDENESBindingSource
        Me.ORDENESDataGridView.Location = New System.Drawing.Point(12, 49)
        Me.ORDENESDataGridView.Name = "ORDENESDataGridView"
        Me.ORDENESDataGridView.Size = New System.Drawing.Size(1229, 205)
        Me.ORDENESDataGridView.TabIndex = 10
        '
        'NRO_ORDENINTTextBox
        '
        Me.NRO_ORDENINTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "NRO_ORDENINT", True))
        Me.NRO_ORDENINTTextBox.Location = New System.Drawing.Point(102, 265)
        Me.NRO_ORDENINTTextBox.Name = "NRO_ORDENINTTextBox"
        Me.NRO_ORDENINTTextBox.Size = New System.Drawing.Size(119, 20)
        Me.NRO_ORDENINTTextBox.TabIndex = 11
        '
        'NRO_ORDINALTextBox
        '
        Me.NRO_ORDINALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "NRO_ORDINAL", True))
        Me.NRO_ORDINALTextBox.Location = New System.Drawing.Point(102, 288)
        Me.NRO_ORDINALTextBox.Name = "NRO_ORDINALTextBox"
        Me.NRO_ORDINALTextBox.Size = New System.Drawing.Size(119, 20)
        Me.NRO_ORDINALTextBox.TabIndex = 13
        '
        'ID_GESTIONTextBox
        '
        Me.ID_GESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "ID_GESTION", True))
        Me.ID_GESTIONTextBox.Location = New System.Drawing.Point(102, 311)
        Me.ID_GESTIONTextBox.Name = "ID_GESTIONTextBox"
        Me.ID_GESTIONTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ID_GESTIONTextBox.TabIndex = 15
        '
        'ID_TRABAJOTextBox
        '
        Me.ID_TRABAJOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "ID_TRABAJO", True))
        Me.ID_TRABAJOTextBox.Location = New System.Drawing.Point(102, 334)
        Me.ID_TRABAJOTextBox.Name = "ID_TRABAJOTextBox"
        Me.ID_TRABAJOTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ID_TRABAJOTextBox.TabIndex = 17
        '
        'TIPOTextBox
        '
        Me.TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "TIPO", True))
        Me.TIPOTextBox.Location = New System.Drawing.Point(345, 265)
        Me.TIPOTextBox.Name = "TIPOTextBox"
        Me.TIPOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPOTextBox.TabIndex = 19
        '
        'SECTOROPETextBox
        '
        Me.SECTOROPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "SECTOROPE", True))
        Me.SECTOROPETextBox.Location = New System.Drawing.Point(345, 287)
        Me.SECTOROPETextBox.Name = "SECTOROPETextBox"
        Me.SECTOROPETextBox.Size = New System.Drawing.Size(142, 20)
        Me.SECTOROPETextBox.TabIndex = 21
        '
        'SECTORDESTINOTextBox
        '
        Me.SECTORDESTINOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "SECTORDESTINO", True))
        Me.SECTORDESTINOTextBox.Location = New System.Drawing.Point(345, 309)
        Me.SECTORDESTINOTextBox.Name = "SECTORDESTINOTextBox"
        Me.SECTORDESTINOTextBox.Size = New System.Drawing.Size(142, 20)
        Me.SECTORDESTINOTextBox.TabIndex = 23
        '
        'PRIORIDADTextBox
        '
        Me.PRIORIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "PRIORIDAD", True))
        Me.PRIORIDADTextBox.Location = New System.Drawing.Point(102, 357)
        Me.PRIORIDADTextBox.Name = "PRIORIDADTextBox"
        Me.PRIORIDADTextBox.Size = New System.Drawing.Size(119, 20)
        Me.PRIORIDADTextBox.TabIndex = 33
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(102, 380)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(119, 20)
        Me.STATUSTextBox.TabIndex = 35
        '
        'GENERADORTextBox
        '
        Me.GENERADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "GENERADOR", True))
        Me.GENERADORTextBox.Location = New System.Drawing.Point(102, 403)
        Me.GENERADORTextBox.Name = "GENERADORTextBox"
        Me.GENERADORTextBox.Size = New System.Drawing.Size(119, 20)
        Me.GENERADORTextBox.TabIndex = 37
        '
        'SOLICITANTETextBox
        '
        Me.SOLICITANTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "SOLICITANTE", True))
        Me.SOLICITANTETextBox.Location = New System.Drawing.Point(102, 426)
        Me.SOLICITANTETextBox.Name = "SOLICITANTETextBox"
        Me.SOLICITANTETextBox.Size = New System.Drawing.Size(119, 20)
        Me.SOLICITANTETextBox.TabIndex = 39
        '
        'CUADRILLATextBox
        '
        Me.CUADRILLATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "CUADRILLA", True))
        Me.CUADRILLATextBox.Location = New System.Drawing.Point(345, 331)
        Me.CUADRILLATextBox.Name = "CUADRILLATextBox"
        Me.CUADRILLATextBox.Size = New System.Drawing.Size(142, 20)
        Me.CUADRILLATextBox.TabIndex = 41
        '
        'NODOTextBox
        '
        Me.NODOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "NODO", True))
        Me.NODOTextBox.Location = New System.Drawing.Point(102, 449)
        Me.NODOTextBox.Name = "NODOTextBox"
        Me.NODOTextBox.Size = New System.Drawing.Size(119, 20)
        Me.NODOTextBox.TabIndex = 43
        '
        'ZONATextBox
        '
        Me.ZONATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "ZONA", True))
        Me.ZONATextBox.Location = New System.Drawing.Point(102, 472)
        Me.ZONATextBox.Name = "ZONATextBox"
        Me.ZONATextBox.Size = New System.Drawing.Size(119, 20)
        Me.ZONATextBox.TabIndex = 45
        '
        'CALLETextBox
        '
        Me.CALLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "CALLE", True))
        Me.CALLETextBox.Location = New System.Drawing.Point(303, 356)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(184, 20)
        Me.CALLETextBox.TabIndex = 47
        '
        'NROTextBox
        '
        Me.NROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "NRO", True))
        Me.NROTextBox.Location = New System.Drawing.Point(303, 378)
        Me.NROTextBox.Name = "NROTextBox"
        Me.NROTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NROTextBox.TabIndex = 49
        '
        'MOTIVOORIGENTextBox
        '
        Me.MOTIVOORIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "MOTIVOORIGEN", True))
        Me.MOTIVOORIGENTextBox.Location = New System.Drawing.Point(626, 357)
        Me.MOTIVOORIGENTextBox.Name = "MOTIVOORIGENTextBox"
        Me.MOTIVOORIGENTextBox.Size = New System.Drawing.Size(231, 20)
        Me.MOTIVOORIGENTextBox.TabIndex = 51
        '
        'CAUSARIGENTextBox
        '
        Me.CAUSARIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "CAUSARIGEN", True))
        Me.CAUSARIGENTextBox.Location = New System.Drawing.Point(626, 380)
        Me.CAUSARIGENTextBox.Name = "CAUSARIGENTextBox"
        Me.CAUSARIGENTextBox.Size = New System.Drawing.Size(231, 20)
        Me.CAUSARIGENTextBox.TabIndex = 53
        '
        'MOTIVOCIERRETextBox
        '
        Me.MOTIVOCIERRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "MOTIVOCIERRE", True))
        Me.MOTIVOCIERRETextBox.Location = New System.Drawing.Point(626, 403)
        Me.MOTIVOCIERRETextBox.Name = "MOTIVOCIERRETextBox"
        Me.MOTIVOCIERRETextBox.Size = New System.Drawing.Size(231, 20)
        Me.MOTIVOCIERRETextBox.TabIndex = 55
        '
        'CAUSACIERRETextBox
        '
        Me.CAUSACIERRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "CAUSACIERRE", True))
        Me.CAUSACIERRETextBox.Location = New System.Drawing.Point(626, 426)
        Me.CAUSACIERRETextBox.Name = "CAUSACIERRETextBox"
        Me.CAUSACIERRETextBox.Size = New System.Drawing.Size(231, 20)
        Me.CAUSACIERRETextBox.TabIndex = 57
        '
        'INSTALACIONTextBox
        '
        Me.INSTALACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "INSTALACION", True))
        Me.INSTALACIONTextBox.Location = New System.Drawing.Point(626, 265)
        Me.INSTALACIONTextBox.Name = "INSTALACIONTextBox"
        Me.INSTALACIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.INSTALACIONTextBox.TabIndex = 59
        '
        'INSTALACIONRUSTextBox
        '
        Me.INSTALACIONRUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "INSTALACIONRUS", True))
        Me.INSTALACIONRUSTextBox.Location = New System.Drawing.Point(626, 288)
        Me.INSTALACIONRUSTextBox.Name = "INSTALACIONRUSTextBox"
        Me.INSTALACIONRUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.INSTALACIONRUSTextBox.TabIndex = 61
        '
        'MANZANATextBox
        '
        Me.MANZANATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "MANZANA", True))
        Me.MANZANATextBox.Location = New System.Drawing.Point(102, 495)
        Me.MANZANATextBox.Name = "MANZANATextBox"
        Me.MANZANATextBox.Size = New System.Drawing.Size(119, 20)
        Me.MANZANATextBox.TabIndex = 63
        '
        'PROYECTO_ORDINALTextBox
        '
        Me.PROYECTO_ORDINALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "PROYECTO_ORDINAL", True))
        Me.PROYECTO_ORDINALTextBox.Location = New System.Drawing.Point(626, 449)
        Me.PROYECTO_ORDINALTextBox.Name = "PROYECTO_ORDINALTextBox"
        Me.PROYECTO_ORDINALTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PROYECTO_ORDINALTextBox.TabIndex = 69
        '
        'GEST_SOLICITADOTextBox
        '
        Me.GEST_SOLICITADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "GEST_SOLICITADO", True))
        Me.GEST_SOLICITADOTextBox.Location = New System.Drawing.Point(626, 311)
        Me.GEST_SOLICITADOTextBox.Name = "GEST_SOLICITADOTextBox"
        Me.GEST_SOLICITADOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GEST_SOLICITADOTextBox.TabIndex = 71
        '
        'ATRIBUTOTextBox
        '
        Me.ATRIBUTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "ATRIBUTO", True))
        Me.ATRIBUTOTextBox.Location = New System.Drawing.Point(626, 334)
        Me.ATRIBUTOTextBox.Name = "ATRIBUTOTextBox"
        Me.ATRIBUTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ATRIBUTOTextBox.TabIndex = 73
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(1062, 21)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(179, 23)
        Me.BTN_BUSCAR.TabIndex = 83
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.Location = New System.Drawing.Point(1264, 4)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(100, 23)
        Me.BTN_CERRAR.TabIndex = 84
        Me.BTN_CERRAR.Text = "CERRAR"
        Me.BTN_CERRAR.UseVisualStyleBackColor = True
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(1062, 423)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(179, 23)
        Me.BTN_GUARDAR.TabIndex = 85
        Me.BTN_GUARDAR.Text = "GUARDAR CAMBIOS"
        Me.BTN_GUARDAR.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHASOL", True))
        Me.TextBox1.Location = New System.Drawing.Point(1141, 269)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 86
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHAINGRESO", True))
        Me.TextBox2.Location = New System.Drawing.Point(1141, 290)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 87
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHAINICIO", True))
        Me.TextBox3.Location = New System.Drawing.Point(1141, 311)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 88
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHAFIN", True))
        Me.TextBox4.Location = New System.Drawing.Point(1141, 332)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 89
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHAAGEND", True))
        Me.TextBox5.Location = New System.Drawing.Point(1141, 353)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 90
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDENESBindingSource, "FECHA_ASIGNADA", True))
        Me.TextBox6.Location = New System.Drawing.Point(1141, 374)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 91
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRO_ORDENINT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NRO_ORDENINT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRO_ORDINAL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NRO_ORDINAL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_GESTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_GESTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_TRABAJO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_TRABAJO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TIPO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SECTOROPE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SECTOROPE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SECTORDESTINO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SECTORDESTINO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FECHASOL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FECHASOL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FECHAINGRESO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FECHAINGRESO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FECHAINICIO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FECHAINICIO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FECHAFIN"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FECHAFIN"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRIORIDAD"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PRIORIDAD"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn14.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "GENERADOR"
        Me.DataGridViewTextBoxColumn15.HeaderText = "GENERADOR"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SOLICITANTE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "SOLICITANTE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CUADRILLA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "CUADRILLA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NODO"
        Me.DataGridViewTextBoxColumn18.HeaderText = "NODO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ZONA"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CALLE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CALLE"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NRO"
        Me.DataGridViewTextBoxColumn21.HeaderText = "NRO"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "MOTIVOORIGEN"
        Me.DataGridViewTextBoxColumn28.HeaderText = "MOTIVOORIGEN"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "CAUSARIGEN"
        Me.DataGridViewTextBoxColumn29.HeaderText = "CAUSARIGEN"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "MOTIVOCIERRE"
        Me.DataGridViewTextBoxColumn30.HeaderText = "MOTIVOCIERRE"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ACTIVIDAD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ACTIVIDAD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "CAUSACIERRE"
        Me.DataGridViewTextBoxColumn32.HeaderText = "CAUSACIERRE"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "INSTALACION"
        Me.DataGridViewTextBoxColumn33.HeaderText = "INSTALACION"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "CARPETA"
        Me.DataGridViewTextBoxColumn34.HeaderText = "CARPETA"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "NOMBREMDU"
        Me.DataGridViewTextBoxColumn35.HeaderText = "NOMBREMDU"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "ORDPRINCIPAL"
        Me.DataGridViewTextBoxColumn36.HeaderText = "ORDPRINCIPAL"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ORDAPOYADO"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ORDAPOYADO"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ORDPADRE"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ORDPADRE"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "RECLAMOSRED"
        Me.DataGridViewTextBoxColumn39.HeaderText = "RECLAMOSRED"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "RECLAMOSMDU"
        Me.DataGridViewTextBoxColumn40.HeaderText = "RECLAMOSMDU"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "RECLAMOSTOT"
        Me.DataGridViewTextBoxColumn41.HeaderText = "RECLAMOSTOT"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "TPREVISTO"
        Me.DataGridViewTextBoxColumn42.HeaderText = "TPREVISTO"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TREALIZADO"
        Me.DataGridViewTextBoxColumn43.HeaderText = "TREALIZADO"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TIEMPOTRABAJO"
        Me.DataGridViewTextBoxColumn44.HeaderText = "TIEMPOTRABAJO"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CREARORDINAL"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CREARORDINAL"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "COORDINAR"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "COORDINAR"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "MANZANA"
        Me.DataGridViewTextBoxColumn45.HeaderText = "MANZANA"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "TURNOAGEND"
        Me.DataGridViewTextBoxColumn46.HeaderText = "TURNOAGEND"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "DEPENDENCIA"
        Me.DataGridViewTextBoxColumn47.HeaderText = "DEPENDENCIA"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "TIPODEP"
        Me.DataGridViewTextBoxColumn48.HeaderText = "TIPODEP"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "FECHAAGEND"
        Me.DataGridViewTextBoxColumn49.HeaderText = "FECHAAGEND"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "ORDENDEP"
        Me.DataGridViewTextBoxColumn50.HeaderText = "ORDENDEP"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "DUPLICADADE"
        Me.DataGridViewTextBoxColumn51.HeaderText = "DUPLICADADE"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "DUPLICADAA"
        Me.DataGridViewTextBoxColumn52.HeaderText = "DUPLICADAA"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "FECHAINICESTIMADO"
        Me.DataGridViewTextBoxColumn53.HeaderText = "FECHAINICESTIMADO"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "TESTIMADO"
        Me.DataGridViewTextBoxColumn54.HeaderText = "TESTIMADO"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "AGENDAR"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "AGENDAR"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "CLASEDEP"
        Me.DataGridViewTextBoxColumn55.HeaderText = "CLASEDEP"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "ORDORIGEN"
        Me.DataGridViewTextBoxColumn56.HeaderText = "ORDORIGEN"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "SECTORGEN"
        Me.DataGridViewTextBoxColumn57.HeaderText = "SECTORGEN"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "INSTALACIONRUS"
        Me.DataGridViewTextBoxColumn58.HeaderText = "INSTALACIONRUS"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "TPREVISTO_UT"
        Me.DataGridViewTextBoxColumn59.HeaderText = "TPREVISTO_UT"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "AFECTACION"
        Me.DataGridViewTextBoxColumn60.HeaderText = "AFECTACION"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "RECURSO"
        Me.DataGridViewTextBoxColumn61.HeaderText = "RECURSO"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "ID_CALLE"
        Me.DataGridViewTextBoxColumn62.HeaderText = "ID_CALLE"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "DESAGENDAR"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "DESAGENDAR"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "ATRIBUTO"
        Me.DataGridViewTextBoxColumn63.HeaderText = "ATRIBUTO"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "NOTIF"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "NOTIF"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "ORDEN_OC"
        Me.DataGridViewTextBoxColumn64.HeaderText = "ORDEN_OC"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "DOCUMENTO_FISICO"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "DOCUMENTO_FISICO"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "FECHA_ASIGNADA"
        Me.DataGridViewTextBoxColumn65.HeaderText = "FECHA_ASIGNADA"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "CANTIDAD_SERVICIOS"
        Me.DataGridViewTextBoxColumn66.HeaderText = "CANTIDAD_SERVICIOS"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "GEST_SOLICITADO"
        Me.DataGridViewTextBoxColumn67.HeaderText = "GEST_SOLICITADO"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "PROYECTO_ORDINAL"
        Me.DataGridViewTextBoxColumn68.HeaderText = "PROYECTO_ORDINAL"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
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
        Me.TableAdapterManager.COMBOSTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONES_TIPOTableAdapter = Nothing
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
        Me.TableAdapterManager.TIPOTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTN_GUARDAR)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ATRIBUTOLabel)
        Me.Controls.Add(Me.ATRIBUTOTextBox)
        Me.Controls.Add(GEST_SOLICITADOLabel)
        Me.Controls.Add(Me.GEST_SOLICITADOTextBox)
        Me.Controls.Add(PROYECTO_ORDINALLabel)
        Me.Controls.Add(Me.PROYECTO_ORDINALTextBox)
        Me.Controls.Add(FECHA_ASIGNADALabel)
        Me.Controls.Add(FECHAAGENDLabel)
        Me.Controls.Add(MANZANALabel)
        Me.Controls.Add(Me.MANZANATextBox)
        Me.Controls.Add(INSTALACIONRUSLabel)
        Me.Controls.Add(Me.INSTALACIONRUSTextBox)
        Me.Controls.Add(INSTALACIONLabel)
        Me.Controls.Add(Me.INSTALACIONTextBox)
        Me.Controls.Add(CAUSACIERRELabel)
        Me.Controls.Add(Me.CAUSACIERRETextBox)
        Me.Controls.Add(MOTIVOCIERRELabel)
        Me.Controls.Add(Me.MOTIVOCIERRETextBox)
        Me.Controls.Add(CAUSARIGENLabel)
        Me.Controls.Add(Me.CAUSARIGENTextBox)
        Me.Controls.Add(MOTIVOORIGENLabel)
        Me.Controls.Add(Me.MOTIVOORIGENTextBox)
        Me.Controls.Add(NROLabel)
        Me.Controls.Add(Me.NROTextBox)
        Me.Controls.Add(CALLELabel)
        Me.Controls.Add(Me.CALLETextBox)
        Me.Controls.Add(ZONALabel)
        Me.Controls.Add(Me.ZONATextBox)
        Me.Controls.Add(NODOLabel)
        Me.Controls.Add(Me.NODOTextBox)
        Me.Controls.Add(CUADRILLALabel)
        Me.Controls.Add(Me.CUADRILLATextBox)
        Me.Controls.Add(SOLICITANTELabel)
        Me.Controls.Add(Me.SOLICITANTETextBox)
        Me.Controls.Add(GENERADORLabel)
        Me.Controls.Add(Me.GENERADORTextBox)
        Me.Controls.Add(STATUSLabel)
        Me.Controls.Add(Me.STATUSTextBox)
        Me.Controls.Add(PRIORIDADLabel)
        Me.Controls.Add(Me.PRIORIDADTextBox)
        Me.Controls.Add(FECHAFINLabel)
        Me.Controls.Add(FECHAINICIOLabel)
        Me.Controls.Add(FECHAINGRESOLabel)
        Me.Controls.Add(FECHASOLLabel)
        Me.Controls.Add(SECTORDESTINOLabel)
        Me.Controls.Add(Me.SECTORDESTINOTextBox)
        Me.Controls.Add(SECTOROPELabel)
        Me.Controls.Add(Me.SECTOROPETextBox)
        Me.Controls.Add(TIPOLabel)
        Me.Controls.Add(Me.TIPOTextBox)
        Me.Controls.Add(ID_TRABAJOLabel)
        Me.Controls.Add(Me.ID_TRABAJOTextBox)
        Me.Controls.Add(ID_GESTIONLabel)
        Me.Controls.Add(Me.ID_GESTIONTextBox)
        Me.Controls.Add(NRO_ORDINALLabel)
        Me.Controls.Add(Me.NRO_ORDINALTextBox)
        Me.Controls.Add(NRO_ORDENINTLabel)
        Me.Controls.Add(Me.NRO_ORDENINTTextBox)
        Me.Controls.Add(Me.ORDENESDataGridView)
        Me.Controls.Add(Me.CALLE)
        Me.Controls.Add(Me.INSTALACION_RUS)
        Me.Controls.Add(Me.INSTALACION)
        Me.Controls.Add(Me.MOTIVO)
        Me.Controls.Add(Me.TRABAJO)
        Me.Controls.Add(Me.GESTION)
        Me.Controls.Add(Me.ORDINAL)
        Me.Controls.Add(Me.NRO_ORDEN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ORDEN"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAIT"
        CType(Me.ORDENESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NRO_ORDEN As TextBox
    Friend WithEvents ORDINAL As TextBox
    Friend WithEvents GESTION As TextBox
    Friend WithEvents TRABAJO As TextBox
    Friend WithEvents MOTIVO As TextBox
    Friend WithEvents INSTALACION As TextBox
    Friend WithEvents INSTALACION_RUS As TextBox
    Friend WithEvents CALLE As TextBox
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDENESDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents NRO_ORDENINTTextBox As TextBox
    Friend WithEvents NRO_ORDINALTextBox As TextBox
    Friend WithEvents ID_GESTIONTextBox As TextBox
    Friend WithEvents ID_TRABAJOTextBox As TextBox
    Friend WithEvents TIPOTextBox As TextBox
    Friend WithEvents SECTOROPETextBox As TextBox
    Friend WithEvents SECTORDESTINOTextBox As TextBox
    Friend WithEvents PRIORIDADTextBox As TextBox
    Friend WithEvents STATUSTextBox As TextBox
    Friend WithEvents GENERADORTextBox As TextBox
    Friend WithEvents SOLICITANTETextBox As TextBox
    Friend WithEvents CUADRILLATextBox As TextBox
    Friend WithEvents NODOTextBox As TextBox
    Friend WithEvents ZONATextBox As TextBox
    Friend WithEvents CALLETextBox As TextBox
    Friend WithEvents NROTextBox As TextBox
    Friend WithEvents MOTIVOORIGENTextBox As TextBox
    Friend WithEvents CAUSARIGENTextBox As TextBox
    Friend WithEvents MOTIVOCIERRETextBox As TextBox
    Friend WithEvents CAUSACIERRETextBox As TextBox
    Friend WithEvents INSTALACIONTextBox As TextBox
    Friend WithEvents INSTALACIONRUSTextBox As TextBox
    Friend WithEvents MANZANATextBox As TextBox
    Friend WithEvents PROYECTO_ORDINALTextBox As TextBox
    Friend WithEvents GEST_SOLICITADOTextBox As TextBox
    Friend WithEvents ATRIBUTOTextBox As TextBox
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents BTN_CERRAR As Button
    Friend WithEvents BTN_GUARDAR As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
