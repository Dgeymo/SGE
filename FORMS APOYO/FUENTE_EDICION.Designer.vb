<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUENTE_EDICION
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
        Dim CAUSACIERRELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.C_AUTONOMIA_REAL = New System.Windows.Forms.Label()
        Me.TXT_CARGA_REAL = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLHSAUTONOMIAREAL = New System.Windows.Forms.Label()
        Me.LBLAUTONOMIA_REAL = New System.Windows.Forms.Label()
        Me.C_LEX = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.C_RX = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.C_TR = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.C_MB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.C_CARGA = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LBLAUTONOMIA_TEORICA = New System.Windows.Forms.Label()
        Me.C_AUTONOMIA = New System.Windows.Forms.Label()
        Me.LBLHRSAUTONOMIATEORICA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.C_IP = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.C_VPN1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C_VPN2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.C_ID2 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.C_PIN = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.C_PUK = New System.Windows.Forms.TextBox()
        Me.C_MAC = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.C_IMEI = New System.Windows.Forms.TextBox()
        Me.INSTALACION = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.C_MODFUENTE = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.C_MODGAB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.C_MODBAT = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.C_CANTBAT = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.FECHAFAB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.INDICE_CALLESDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRECALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INDICE_CALLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.C_CALLE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_NRO = New System.Windows.Forms.TextBox()
        Me.C_ESQUINA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.C_ZONAG = New System.Windows.Forms.TextBox()
        Me.C_NODO = New System.Windows.Forms.ComboBox()
        Me.INDICE_CALLESTableAdapter = New REDES.INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.BOT_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BASEFUENTESDataSet = New REDES.BASEFUENTESDataSet()
        Me.FUENTETableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.FUENTETableAdapter()
        Me.FUENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.AFECTACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AFECTACIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.AFECTACIONTableAdapter()
        Me.TableAdapterManager2 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.INSTALACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INSTALACIONTableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.INSTALACIONTableAdapter()
        CAUSACIERRELabel = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AFECTACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSTALACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CAUSACIERRELabel
        '
        CAUSACIERRELabel.AutoSize = True
        CAUSACIERRELabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CAUSACIERRELabel.ForeColor = System.Drawing.Color.White
        CAUSACIERRELabel.Location = New System.Drawing.Point(418, -33)
        CAUSACIERRELabel.Name = "CAUSACIERRELabel"
        CAUSACIERRELabel.Size = New System.Drawing.Size(82, 13)
        CAUSACIERRELabel.TabIndex = 310
        CAUSACIERRELabel.Text = "Causa de Cierre"
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.BackColor = System.Drawing.Color.Red
        Me.BTN_CERRAR.BackgroundImage = Global.REDES.My.Resources.Resources.logout_W
        Me.BTN_CERRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_CERRAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTN_CERRAR.FlatAppearance.BorderSize = 0
        Me.BTN_CERRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BTN_CERRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_CERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CERRAR.ForeColor = System.Drawing.Color.LightGreen
        Me.BTN_CERRAR.Location = New System.Drawing.Point(600, 4)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(36, 42)
        Me.BTN_CERRAR.TabIndex = 12
        Me.BTN_CERRAR.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.C_AUTONOMIA_REAL)
        Me.GroupBox5.Controls.Add(Me.TXT_CARGA_REAL)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.LBLHSAUTONOMIAREAL)
        Me.GroupBox5.Controls.Add(Me.LBLAUTONOMIA_REAL)
        Me.GroupBox5.Controls.Add(Me.C_LEX)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.C_RX)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.C_TR)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.C_MB)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.C_CARGA)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.LBLAUTONOMIA_TEORICA)
        Me.GroupBox5.Controls.Add(Me.C_AUTONOMIA)
        Me.GroupBox5.Controls.Add(Me.LBLHRSAUTONOMIATEORICA)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(559, 66)
        Me.GroupBox5.TabIndex = 263
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CARGA - AUTONOMIA"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(338, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 13)
        Me.Label25.TabIndex = 197
        Me.Label25.Text = "Amp"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_AUTONOMIA_REAL
        '
        Me.C_AUTONOMIA_REAL.AutoSize = True
        Me.C_AUTONOMIA_REAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_AUTONOMIA_REAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_AUTONOMIA_REAL.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_AUTONOMIA_REAL.Location = New System.Drawing.Point(485, 44)
        Me.C_AUTONOMIA_REAL.Name = "C_AUTONOMIA_REAL"
        Me.C_AUTONOMIA_REAL.Size = New System.Drawing.Size(0, 15)
        Me.C_AUTONOMIA_REAL.TabIndex = 196
        Me.C_AUTONOMIA_REAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_CARGA_REAL
        '
        Me.TXT_CARGA_REAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CARGA_REAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CARGA_REAL.ForeColor = System.Drawing.Color.DarkOrange
        Me.TXT_CARGA_REAL.Location = New System.Drawing.Point(297, 41)
        Me.TXT_CARGA_REAL.Name = "TXT_CARGA_REAL"
        Me.TXT_CARGA_REAL.Size = New System.Drawing.Size(39, 20)
        Me.TXT_CARGA_REAL.TabIndex = 195
        Me.TXT_CARGA_REAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(205, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 16)
        Me.Label15.TabIndex = 194
        Me.Label15.Text = "Carga REAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLHSAUTONOMIAREAL
        '
        Me.LBLHSAUTONOMIAREAL.AutoSize = True
        Me.LBLHSAUTONOMIAREAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHSAUTONOMIAREAL.ForeColor = System.Drawing.Color.White
        Me.LBLHSAUTONOMIAREAL.Location = New System.Drawing.Point(517, 45)
        Me.LBLHSAUTONOMIAREAL.Name = "LBLHSAUTONOMIAREAL"
        Me.LBLHSAUTONOMIAREAL.Size = New System.Drawing.Size(20, 13)
        Me.LBLHSAUTONOMIAREAL.TabIndex = 193
        Me.LBLHSAUTONOMIAREAL.Text = "Hs"
        Me.LBLHSAUTONOMIAREAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLAUTONOMIA_REAL
        '
        Me.LBLAUTONOMIA_REAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAUTONOMIA_REAL.ForeColor = System.Drawing.Color.White
        Me.LBLAUTONOMIA_REAL.Location = New System.Drawing.Point(393, 43)
        Me.LBLAUTONOMIA_REAL.Name = "LBLAUTONOMIA_REAL"
        Me.LBLAUTONOMIA_REAL.Size = New System.Drawing.Size(92, 16)
        Me.LBLAUTONOMIA_REAL.TabIndex = 191
        Me.LBLAUTONOMIA_REAL.Text = "Autonomía REAL"
        Me.LBLAUTONOMIA_REAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_LEX
        '
        Me.C_LEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_LEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_LEX.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_LEX.Location = New System.Drawing.Point(105, 39)
        Me.C_LEX.Name = "C_LEX"
        Me.C_LEX.Size = New System.Drawing.Size(39, 20)
        Me.C_LEX.TabIndex = 166
        Me.C_LEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(10, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "RX"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_RX
        '
        Me.C_RX.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_RX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_RX.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_RX.Location = New System.Drawing.Point(32, 18)
        Me.C_RX.Name = "C_RX"
        Me.C_RX.Size = New System.Drawing.Size(39, 20)
        Me.C_RX.TabIndex = 160
        Me.C_RX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(83, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 13)
        Me.Label17.TabIndex = 161
        Me.Label17.Text = "TR"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_TR
        '
        Me.C_TR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_TR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_TR.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_TR.Location = New System.Drawing.Point(105, 18)
        Me.C_TR.Name = "C_TR"
        Me.C_TR.Size = New System.Drawing.Size(39, 20)
        Me.C_TR.TabIndex = 162
        Me.C_TR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(9, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 13)
        Me.Label18.TabIndex = 163
        Me.Label18.Text = "MB"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_MB
        '
        Me.C_MB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_MB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MB.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_MB.Location = New System.Drawing.Point(32, 39)
        Me.C_MB.Name = "C_MB"
        Me.C_MB.Size = New System.Drawing.Size(39, 20)
        Me.C_MB.TabIndex = 164
        Me.C_MB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(79, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 165
        Me.Label19.Text = "LEX"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_CARGA
        '
        Me.C_CARGA.AutoSize = True
        Me.C_CARGA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_CARGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CARGA.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_CARGA.Location = New System.Drawing.Point(303, 20)
        Me.C_CARGA.Name = "C_CARGA"
        Me.C_CARGA.Size = New System.Drawing.Size(13, 15)
        Me.C_CARGA.TabIndex = 186
        Me.C_CARGA.Text = "*"
        Me.C_CARGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(211, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 13)
        Me.Label31.TabIndex = 185
        Me.Label31.Text = "Carga TEORICA"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(338, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 13)
        Me.Label33.TabIndex = 187
        Me.Label33.Text = "Amp"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLAUTONOMIA_TEORICA
        '
        Me.LBLAUTONOMIA_TEORICA.AutoSize = True
        Me.LBLAUTONOMIA_TEORICA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAUTONOMIA_TEORICA.ForeColor = System.Drawing.Color.White
        Me.LBLAUTONOMIA_TEORICA.Location = New System.Drawing.Point(374, 21)
        Me.LBLAUTONOMIA_TEORICA.Name = "LBLAUTONOMIA_TEORICA"
        Me.LBLAUTONOMIA_TEORICA.Size = New System.Drawing.Size(109, 13)
        Me.LBLAUTONOMIA_TEORICA.TabIndex = 188
        Me.LBLAUTONOMIA_TEORICA.Text = "Autonomía TEÓRICA"
        Me.LBLAUTONOMIA_TEORICA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_AUTONOMIA
        '
        Me.C_AUTONOMIA.AutoSize = True
        Me.C_AUTONOMIA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_AUTONOMIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_AUTONOMIA.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_AUTONOMIA.Location = New System.Drawing.Point(485, 20)
        Me.C_AUTONOMIA.Name = "C_AUTONOMIA"
        Me.C_AUTONOMIA.Size = New System.Drawing.Size(0, 15)
        Me.C_AUTONOMIA.TabIndex = 189
        Me.C_AUTONOMIA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLHRSAUTONOMIATEORICA
        '
        Me.LBLHRSAUTONOMIATEORICA.AutoSize = True
        Me.LBLHRSAUTONOMIATEORICA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHRSAUTONOMIATEORICA.ForeColor = System.Drawing.Color.White
        Me.LBLHRSAUTONOMIATEORICA.Location = New System.Drawing.Point(517, 21)
        Me.LBLHRSAUTONOMIATEORICA.Name = "LBLHRSAUTONOMIATEORICA"
        Me.LBLHRSAUTONOMIATEORICA.Size = New System.Drawing.Size(20, 13)
        Me.LBLHRSAUTONOMIATEORICA.TabIndex = 190
        Me.LBLHRSAUTONOMIATEORICA.Text = "Hs"
        Me.LBLHRSAUTONOMIATEORICA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.C_IP)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.C_VPN1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.C_VPN2)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.C_ID2)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.C_PIN)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.C_PUK)
        Me.GroupBox2.Controls.Add(Me.C_MAC)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.C_IMEI)
        Me.GroupBox2.Controls.Add(Me.INSTALACION)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(381, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 232)
        Me.GroupBox2.TabIndex = 264
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONFIGURACION"
        '
        'C_IP
        '
        Me.C_IP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_IP.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_IP.Location = New System.Drawing.Point(63, 23)
        Me.C_IP.Name = "C_IP"
        Me.C_IP.Size = New System.Drawing.Size(132, 20)
        Me.C_IP.TabIndex = 169
        Me.C_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(9, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 168
        Me.Label21.Text = "IP Router"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(26, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 170
        Me.Label22.Text = "VPN1"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_VPN1
        '
        Me.C_VPN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_VPN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_VPN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_VPN1.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_VPN1.Location = New System.Drawing.Point(63, 63)
        Me.C_VPN1.Name = "C_VPN1"
        Me.C_VPN1.Size = New System.Drawing.Size(132, 20)
        Me.C_VPN1.TabIndex = 171
        Me.C_VPN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(26, 86)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 172
        Me.Label23.Text = "VPN2"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 234
        Me.Label9.Text = "INST.RUS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_VPN2
        '
        Me.C_VPN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_VPN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_VPN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_VPN2.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_VPN2.Location = New System.Drawing.Point(63, 83)
        Me.C_VPN2.Name = "C_VPN2"
        Me.C_VPN2.Size = New System.Drawing.Size(132, 20)
        Me.C_VPN2.TabIndex = 173
        Me.C_VPN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(8, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 174
        Me.Label24.Text = "IP Transp"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_ID2
        '
        Me.C_ID2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_ID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_ID2.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_ID2.Location = New System.Drawing.Point(63, 43)
        Me.C_ID2.Name = "C_ID2"
        Me.C_ID2.Size = New System.Drawing.Size(132, 20)
        Me.C_ID2.TabIndex = 175
        Me.C_ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(36, 107)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 176
        Me.Label26.Text = "PIN"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_PIN
        '
        Me.C_PIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_PIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_PIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_PIN.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_PIN.Location = New System.Drawing.Point(63, 103)
        Me.C_PIN.Name = "C_PIN"
        Me.C_PIN.Size = New System.Drawing.Size(132, 20)
        Me.C_PIN.TabIndex = 177
        Me.C_PIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(32, 128)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 178
        Me.Label27.Text = "PUK"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_PUK
        '
        Me.C_PUK.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_PUK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_PUK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_PUK.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_PUK.Location = New System.Drawing.Point(63, 123)
        Me.C_PUK.Name = "C_PUK"
        Me.C_PUK.Size = New System.Drawing.Size(132, 20)
        Me.C_PUK.TabIndex = 179
        Me.C_PUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_MAC
        '
        Me.C_MAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_MAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_MAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MAC.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_MAC.Location = New System.Drawing.Point(63, 143)
        Me.C_MAC.Name = "C_MAC"
        Me.C_MAC.Size = New System.Drawing.Size(132, 20)
        Me.C_MAC.TabIndex = 180
        Me.C_MAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(31, 147)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 181
        Me.Label28.Text = "MAC"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_IMEI
        '
        Me.C_IMEI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_IMEI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_IMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_IMEI.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_IMEI.Location = New System.Drawing.Point(63, 163)
        Me.C_IMEI.Name = "C_IMEI"
        Me.C_IMEI.Size = New System.Drawing.Size(132, 20)
        Me.C_IMEI.TabIndex = 182
        Me.C_IMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INSTALACION
        '
        Me.INSTALACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.INSTALACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INSTALACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSTALACION.ForeColor = System.Drawing.Color.DarkOrange
        Me.INSTALACION.Location = New System.Drawing.Point(63, 193)
        Me.INSTALACION.Name = "INSTALACION"
        Me.INSTALACION.Size = New System.Drawing.Size(132, 20)
        Me.INSTALACION.TabIndex = 233
        Me.INSTALACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(32, 167)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 13)
        Me.Label29.TabIndex = 183
        Me.Label29.Text = "IMEI"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.C_MODFUENTE)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.C_MODGAB)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.C_MODBAT)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.C_CANTBAT)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.FECHAFAB)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(20, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(355, 95)
        Me.GroupBox4.TabIndex = 266
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "COMPONENTES"
        '
        'C_MODFUENTE
        '
        Me.C_MODFUENTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_MODFUENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_MODFUENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MODFUENTE.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_MODFUENTE.FormattingEnabled = True
        Me.C_MODFUENTE.Items.AddRange(New Object() {"COM", "EM", "VMX", "XM2", "XM3.1"})
        Me.C_MODFUENTE.Location = New System.Drawing.Point(78, 19)
        Me.C_MODFUENTE.MaxLength = 20
        Me.C_MODFUENTE.Name = "C_MODFUENTE"
        Me.C_MODFUENTE.Size = New System.Drawing.Size(100, 21)
        Me.C_MODFUENTE.TabIndex = 150
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Mod Fuente"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_MODGAB
        '
        Me.C_MODGAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_MODGAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_MODGAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MODGAB.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_MODGAB.FormattingEnabled = True
        Me.C_MODGAB.Items.AddRange(New Object() {"Grande", "Chico", "Pedestal"})
        Me.C_MODGAB.Location = New System.Drawing.Point(78, 41)
        Me.C_MODGAB.MaxLength = 20
        Me.C_MODGAB.Name = "C_MODGAB"
        Me.C_MODGAB.Size = New System.Drawing.Size(100, 21)
        Me.C_MODGAB.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Mod Gabinete"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_MODBAT
        '
        Me.C_MODBAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_MODBAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_MODBAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MODBAT.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_MODBAT.FormattingEnabled = True
        Me.C_MODBAT.Items.AddRange(New Object() {"150 XTV", "165 GXL", "195 XTV"})
        Me.C_MODBAT.Location = New System.Drawing.Point(261, 19)
        Me.C_MODBAT.MaxLength = 20
        Me.C_MODBAT.Name = "C_MODBAT"
        Me.C_MODBAT.Size = New System.Drawing.Size(83, 21)
        Me.C_MODBAT.TabIndex = 154
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(197, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "Mod Bateria"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C_CANTBAT
        '
        Me.C_CANTBAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_CANTBAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_CANTBAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CANTBAT.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_CANTBAT.FormattingEnabled = True
        Me.C_CANTBAT.Items.AddRange(New Object() {"2", "3", "4"})
        Me.C_CANTBAT.Location = New System.Drawing.Point(261, 43)
        Me.C_CANTBAT.MaxLength = 20
        Me.C_CANTBAT.Name = "C_CANTBAT"
        Me.C_CANTBAT.Size = New System.Drawing.Size(50, 21)
        Me.C_CANTBAT.TabIndex = 156
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(155, 70)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 246
        Me.Label34.Text = "Fecha Fab Bateria"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FECHAFAB
        '
        Me.FECHAFAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FECHAFAB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FECHAFAB.ForeColor = System.Drawing.Color.DarkOrange
        Me.FECHAFAB.Location = New System.Drawing.Point(255, 70)
        Me.FECHAFAB.Name = "FECHAFAB"
        Me.FECHAFAB.Size = New System.Drawing.Size(89, 20)
        Me.FECHAFAB.TabIndex = 247
        Me.FECHAFAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(212, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 157
        Me.Label14.Text = "Cantidad"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INDICE_CALLESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.INDICE_CALLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INDICE_CALLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CALLE, Me.TIPO, Me.NOMBRE_CALLE, Me.IdDataGridViewTextBoxColumn, Me.IDCALLEDataGridViewTextBoxColumn, Me.TIPODataGridViewTextBoxColumn, Me.NOMBRECALLEDataGridViewTextBoxColumn})
        Me.INDICE_CALLESDataGridView.DataSource = Me.INDICE_CALLESBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.INDICE_CALLESDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.INDICE_CALLESDataGridView.EnableHeadersVisualStyles = False
        Me.INDICE_CALLESDataGridView.GridColor = System.Drawing.Color.DarkOrange
        Me.INDICE_CALLESDataGridView.Location = New System.Drawing.Point(20, 236)
        Me.INDICE_CALLESDataGridView.Name = "INDICE_CALLESDataGridView"
        Me.INDICE_CALLESDataGridView.ReadOnly = True
        Me.INDICE_CALLESDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.INDICE_CALLESDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        Me.INDICE_CALLESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.INDICE_CALLESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INDICE_CALLESDataGridView.Size = New System.Drawing.Size(369, 190)
        Me.INDICE_CALLESDataGridView.TabIndex = 312
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
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Visible = False
        '
        'NOMBRE_CALLE
        '
        Me.NOMBRE_CALLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE_CALLE.DataPropertyName = "NOMBRE_CALLE"
        Me.NOMBRE_CALLE.HeaderText = "CALLE"
        Me.NOMBRE_CALLE.Name = "NOMBRE_CALLE"
        Me.NOMBRE_CALLE.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDCALLEDataGridViewTextBoxColumn
        '
        Me.IDCALLEDataGridViewTextBoxColumn.DataPropertyName = "ID_CALLE"
        Me.IDCALLEDataGridViewTextBoxColumn.HeaderText = "ID_CALLE"
        Me.IDCALLEDataGridViewTextBoxColumn.Name = "IDCALLEDataGridViewTextBoxColumn"
        Me.IDCALLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIPODataGridViewTextBoxColumn
        '
        Me.TIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.Name = "TIPODataGridViewTextBoxColumn"
        Me.TIPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBRECALLEDataGridViewTextBoxColumn
        '
        Me.NOMBRECALLEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CALLE"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.HeaderText = "NOMBRE_CALLE"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.Name = "NOMBRECALLEDataGridViewTextBoxColumn"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INDICE_CALLESBindingSource
        '
        Me.INDICE_CALLESBindingSource.DataMember = "INDICE_CALLES"
        Me.INDICE_CALLESBindingSource.DataSource = Me.INDICESDataSet
        '
        'INDICESDataSet
        '
        Me.INDICESDataSet.DataSetName = "INDICESDataSet"
        Me.INDICESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.C_CALLE)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.C_NRO)
        Me.GroupBox3.Controls.Add(Me.C_ESQUINA)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.C_ZONAG)
        Me.GroupBox3.Controls.Add(Me.C_NODO)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(20, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 75)
        Me.GroupBox3.TabIndex = 311
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "UBICACION"
        '
        'C_CALLE
        '
        Me.C_CALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_CALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CALLE.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_CALLE.Location = New System.Drawing.Point(46, 24)
        Me.C_CALLE.Name = "C_CALLE"
        Me.C_CALLE.Size = New System.Drawing.Size(163, 20)
        Me.C_CALLE.TabIndex = 228
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "CALLE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(213, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "NRO."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_NRO
        '
        Me.C_NRO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_NRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_NRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NRO.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_NRO.Location = New System.Drawing.Point(247, 24)
        Me.C_NRO.Name = "C_NRO"
        Me.C_NRO.Size = New System.Drawing.Size(39, 20)
        Me.C_NRO.TabIndex = 140
        '
        'C_ESQUINA
        '
        Me.C_ESQUINA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_ESQUINA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_ESQUINA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_ESQUINA.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_ESQUINA.Location = New System.Drawing.Point(46, 45)
        Me.C_ESQUINA.Name = "C_ESQUINA"
        Me.C_ESQUINA.Size = New System.Drawing.Size(130, 20)
        Me.C_ESQUINA.TabIndex = 141
        Me.C_ESQUINA.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "ESQ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(296, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "NODO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(180, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "ZONA GEO."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C_ZONAG
        '
        Me.C_ZONAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_ZONAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_ZONAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_ZONAG.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_ZONAG.Location = New System.Drawing.Point(247, 45)
        Me.C_ZONAG.Name = "C_ZONAG"
        Me.C_ZONAG.Size = New System.Drawing.Size(39, 20)
        Me.C_ZONAG.TabIndex = 147
        '
        'C_NODO
        '
        Me.C_NODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C_NODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_NODO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NODO.ForeColor = System.Drawing.Color.DarkOrange
        Me.C_NODO.FormattingEnabled = True
        Me.C_NODO.Items.AddRange(New Object() {"A", "B", "C", "CAB", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "ZB"})
        Me.C_NODO.Location = New System.Drawing.Point(291, 42)
        Me.C_NODO.MaxDropDownItems = 50
        Me.C_NODO.Name = "C_NODO"
        Me.C_NODO.Size = New System.Drawing.Size(50, 21)
        Me.C_NODO.TabIndex = 227
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
        Me.TableAdapterManager.UpdateOrder = REDES.INDICESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BOT_ACEPTAR
        '
        Me.BOT_ACEPTAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_ACEPTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BOT_ACEPTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BOT_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_ACEPTAR.Location = New System.Drawing.Point(402, 406)
        Me.BOT_ACEPTAR.Name = "BOT_ACEPTAR"
        Me.BOT_ACEPTAR.Size = New System.Drawing.Size(81, 50)
        Me.BOT_ACEPTAR.TabIndex = 314
        Me.BOT_ACEPTAR.Text = "ACEPTAR"
        Me.BOT_ACEPTAR.UseVisualStyleBackColor = False
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(517, 406)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(81, 50)
        Me.BTN_CANCELAR.TabIndex = 315
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = False
        '
        'BASEFUENTESDataSet
        '
        Me.BASEFUENTESDataSet.DataSetName = "BASEFUENTESDataSet"
        Me.BASEFUENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FUENTETableAdapter
        '
        Me.FUENTETableAdapter.ClearBeforeFill = True
        '
        'FUENTEBindingSource
        '
        Me.FUENTEBindingSource.DataMember = "FUENTE"
        Me.FUENTEBindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ANTIGUEDADBATTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.baseTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.FUENTETableAdapter = Nothing
        Me.TableAdapterManager1.GENERADOR_MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager1.GENERADORESTableAdapter = Nothing
        Me.TableAdapterManager1.GRAFANTIGUEDADTableAdapter = Nothing
        Me.TableAdapterManager1.GRAFAUTONOMIATableAdapter = Nothing
        Me.TableAdapterManager1.GRAFTIPOFUENTETableAdapter = Nothing
        Me.TableAdapterManager1.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager1.Hoja1TableAdapter = Nothing
        Me.TableAdapterManager1.INSTALACIONTableAdapter = Nothing
        Me.TableAdapterManager1.NRONODOSTableAdapter = Nothing
        Me.TableAdapterManager1.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AFECTACIONBindingSource
        '
        Me.AFECTACIONBindingSource.DataMember = "AFECTACION"
        Me.AFECTACIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'AFECTACIONTableAdapter
        '
        Me.AFECTACIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager2.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager2.AFECTACIONTableAdapter = Me.AFECTACIONTableAdapter
        Me.TableAdapterManager2.AREASTableAdapter = Nothing
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager2.COMBOSTableAdapter = Nothing
        Me.TableAdapterManager2.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager2.FALLASTableAdapter = Nothing
        Me.TableAdapterManager2.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager2.GESTIONES_TIPOTableAdapter = Nothing
        Me.TableAdapterManager2.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager2.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager2.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager2.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager2.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager2.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager2.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager2.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager2.ORDENESTableAdapter = Nothing
        Me.TableAdapterManager2.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager2.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager2.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager2.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager2.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager2.STATUSTableAdapter = Nothing
        Me.TableAdapterManager2.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager2.TAREASTableAdapter = Nothing
        Me.TableAdapterManager2.TIPOTableAdapter = Nothing
        Me.TableAdapterManager2.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'INSTALACIONBindingSource
        '
        Me.INSTALACIONBindingSource.DataMember = "INSTALACION"
        Me.INSTALACIONBindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'INSTALACIONTableAdapter
        '
        Me.INSTALACIONTableAdapter.ClearBeforeFill = True
        '
        'FUENTE_EDICION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(639, 463)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BOT_ACEPTAR)
        Me.Controls.Add(Me.INDICE_CALLESDataGridView)
        Me.Controls.Add(CAUSACIERRELabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FUENTE_EDICION"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FUENTE_EDICION"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AFECTACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSTALACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CERRAR As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents C_AUTONOMIA_REAL As Label
    Friend WithEvents TXT_CARGA_REAL As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LBLHSAUTONOMIAREAL As Label
    Friend WithEvents LBLAUTONOMIA_REAL As Label
    Friend WithEvents C_LEX As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents C_RX As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents C_TR As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents C_MB As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents C_CARGA As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents LBLAUTONOMIA_TEORICA As Label
    Friend WithEvents C_AUTONOMIA As Label
    Friend WithEvents LBLHRSAUTONOMIATEORICA As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents C_IP As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents C_VPN1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents C_VPN2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents C_ID2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents C_PIN As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents C_PUK As TextBox
    Friend WithEvents C_MAC As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents C_IMEI As TextBox
    Friend WithEvents INSTALACION As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents C_MODFUENTE As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents C_MODGAB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents C_MODBAT As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents C_CANTBAT As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents FECHAFAB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents INDICE_CALLESDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents C_CALLE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents C_NRO As TextBox
    Friend WithEvents C_ESQUINA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents C_ZONAG As TextBox
    Friend WithEvents C_NODO As ComboBox
    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents INDICE_CALLESBindingSource As BindingSource
    Friend WithEvents INDICE_CALLESTableAdapter As INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BOT_ACEPTAR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BASEFUENTESDataSet As BASEFUENTESDataSet
    Friend WithEvents FUENTEBindingSource As BindingSource
    Friend WithEvents FUENTETableAdapter As BASEFUENTESDataSetTableAdapters.FUENTETableAdapter
    Friend WithEvents TableAdapterManager1 As BASEFUENTESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents AFECTACIONBindingSource As BindingSource
    Friend WithEvents AFECTACIONTableAdapter As ORDENESDataSetTableAdapters.AFECTACIONTableAdapter
    Friend WithEvents TableAdapterManager2 As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents INSTALACIONBindingSource As BindingSource
    Friend WithEvents INSTALACIONTableAdapter As BASEFUENTESDataSetTableAdapters.INSTALACIONTableAdapter
    Friend WithEvents ID_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRECALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
