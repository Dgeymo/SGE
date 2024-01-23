<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NUEVOTRABAJO
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
        Me.BOT_CANCELARTRABAJO = New System.Windows.Forms.Button()
        Me.BOT_GUARDARTRABAJO = New System.Windows.Forms.Button()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TRAB_NRO = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TRAB_CALLE = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TRAB_MANZANA = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TRAB_TIEMPOESTIMADO = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TRAB_INIESTIMADO = New System.Windows.Forms.DateTimePicker()
        Me.TRAB_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TRAB_TIPO = New System.Windows.Forms.Label()
        Me.TRAB_ZONA = New System.Windows.Forms.TextBox()
        Me.DEPEND = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TIPO_DEP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TRAB_INSTALACION = New System.Windows.Forms.TextBox()
        Me.TRAB_INSTALACIONRUS = New System.Windows.Forms.TextBox()
        Me.TRAB_NODO = New System.Windows.Forms.TextBox()
        Me.INDICE_CALLESDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRECALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INDICE_CALLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.INDICE_CALLESTableAdapter = New REDES.INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_TRAB_ATRIBUTO = New System.Windows.Forms.ComboBox()
        Me.TXT_PROYECTO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOT_CANCELARTRABAJO
        '
        Me.BOT_CANCELARTRABAJO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_CANCELARTRABAJO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_CANCELARTRABAJO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_CANCELARTRABAJO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BOT_CANCELARTRABAJO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_CANCELARTRABAJO.ForeColor = System.Drawing.Color.Yellow
        Me.BOT_CANCELARTRABAJO.Location = New System.Drawing.Point(266, 409)
        Me.BOT_CANCELARTRABAJO.Name = "BOT_CANCELARTRABAJO"
        Me.BOT_CANCELARTRABAJO.Size = New System.Drawing.Size(100, 25)
        Me.BOT_CANCELARTRABAJO.TabIndex = 8
        Me.BOT_CANCELARTRABAJO.Text = "Cancelar"
        Me.BOT_CANCELARTRABAJO.UseVisualStyleBackColor = False
        '
        'BOT_GUARDARTRABAJO
        '
        Me.BOT_GUARDARTRABAJO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_GUARDARTRABAJO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_GUARDARTRABAJO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_GUARDARTRABAJO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BOT_GUARDARTRABAJO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_GUARDARTRABAJO.ForeColor = System.Drawing.Color.Yellow
        Me.BOT_GUARDARTRABAJO.Location = New System.Drawing.Point(160, 409)
        Me.BOT_GUARDARTRABAJO.Name = "BOT_GUARDARTRABAJO"
        Me.BOT_GUARDARTRABAJO.Size = New System.Drawing.Size(100, 25)
        Me.BOT_GUARDARTRABAJO.TabIndex = 7
        Me.BOT_GUARDARTRABAJO.Text = "Guardar"
        Me.BOT_GUARDARTRABAJO.UseVisualStyleBackColor = False
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(104, 156)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(58, 19)
        Me.Label53.TabIndex = 230
        Me.Label53.Text = "Depend"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(12, 156)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(40, 19)
        Me.Label45.TabIndex = 228
        Me.Label45.Text = "T Dep"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(12, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 19)
        Me.Label15.TabIndex = 225
        Me.Label15.Text = "Nodo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label58.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(254, 128)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(40, 19)
        Me.Label58.TabIndex = 223
        Me.Label58.Text = "Nro"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TRAB_NRO
        '
        Me.TRAB_NRO.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_NRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_NRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_NRO.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_NRO.Location = New System.Drawing.Point(298, 128)
        Me.TRAB_NRO.Name = "TRAB_NRO"
        Me.TRAB_NRO.Size = New System.Drawing.Size(68, 20)
        Me.TRAB_NRO.TabIndex = 3
        Me.TRAB_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(12, 128)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(40, 19)
        Me.Label47.TabIndex = 221
        Me.Label47.Text = "Calle"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TRAB_CALLE
        '
        Me.TRAB_CALLE.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_CALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_CALLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_CALLE.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_CALLE.Location = New System.Drawing.Point(58, 128)
        Me.TRAB_CALLE.Name = "TRAB_CALLE"
        Me.TRAB_CALLE.Size = New System.Drawing.Size(176, 20)
        Me.TRAB_CALLE.TabIndex = 2
        Me.TRAB_CALLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label46.Location = New System.Drawing.Point(12, 97)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(40, 19)
        Me.Label46.TabIndex = 219
        Me.Label46.Text = "Mzna"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TRAB_MANZANA
        '
        Me.TRAB_MANZANA.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_MANZANA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_MANZANA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_MANZANA.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_MANZANA.Location = New System.Drawing.Point(58, 96)
        Me.TRAB_MANZANA.Name = "TRAB_MANZANA"
        Me.TRAB_MANZANA.Size = New System.Drawing.Size(70, 20)
        Me.TRAB_MANZANA.TabIndex = 1
        Me.TRAB_MANZANA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(150, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 19)
        Me.Label33.TabIndex = 217
        Me.Label33.Text = "T Est"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TRAB_TIEMPOESTIMADO
        '
        Me.TRAB_TIEMPOESTIMADO.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_TIEMPOESTIMADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_TIEMPOESTIMADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_TIEMPOESTIMADO.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_TIEMPOESTIMADO.Location = New System.Drawing.Point(198, 74)
        Me.TRAB_TIEMPOESTIMADO.Name = "TRAB_TIEMPOESTIMADO"
        Me.TRAB_TIEMPOESTIMADO.Size = New System.Drawing.Size(41, 20)
        Me.TRAB_TIEMPOESTIMADO.TabIndex = 5
        Me.TRAB_TIEMPOESTIMADO.Text = "1"
        Me.TRAB_TIEMPOESTIMADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label52.Location = New System.Drawing.Point(12, 74)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(40, 19)
        Me.Label52.TabIndex = 215
        Me.Label52.Text = "Zona"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label55.Location = New System.Drawing.Point(12, 18)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(40, 19)
        Me.Label55.TabIndex = 213
        Me.Label55.Text = "Tipo"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(150, 51)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(40, 19)
        Me.Label54.TabIndex = 212
        Me.Label54.Text = "Ini Est"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TRAB_INIESTIMADO
        '
        Me.TRAB_INIESTIMADO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TRAB_INIESTIMADO.Location = New System.Drawing.Point(198, 50)
        Me.TRAB_INIESTIMADO.Name = "TRAB_INIESTIMADO"
        Me.TRAB_INIESTIMADO.Size = New System.Drawing.Size(106, 20)
        Me.TRAB_INIESTIMADO.TabIndex = 4
        '
        'TRAB_DESCRIPCION
        '
        Me.TRAB_DESCRIPCION.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_DESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_DESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_DESCRIPCION.ForeColor = System.Drawing.Color.LemonChiffon
        Me.TRAB_DESCRIPCION.Location = New System.Drawing.Point(12, 232)
        Me.TRAB_DESCRIPCION.MaxLength = 80000
        Me.TRAB_DESCRIPCION.Multiline = True
        Me.TRAB_DESCRIPCION.Name = "TRAB_DESCRIPCION"
        Me.TRAB_DESCRIPCION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TRAB_DESCRIPCION.Size = New System.Drawing.Size(354, 159)
        Me.TRAB_DESCRIPCION.TabIndex = 6
        '
        'TRAB_TIPO
        '
        Me.TRAB_TIPO.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_TIPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_TIPO.Enabled = False
        Me.TRAB_TIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TRAB_TIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRAB_TIPO.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_TIPO.Location = New System.Drawing.Point(58, 18)
        Me.TRAB_TIPO.Name = "TRAB_TIPO"
        Me.TRAB_TIPO.Size = New System.Drawing.Size(289, 19)
        Me.TRAB_TIPO.TabIndex = 231
        Me.TRAB_TIPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TRAB_ZONA
        '
        Me.TRAB_ZONA.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_ZONA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_ZONA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_ZONA.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_ZONA.Location = New System.Drawing.Point(58, 73)
        Me.TRAB_ZONA.Name = "TRAB_ZONA"
        Me.TRAB_ZONA.Size = New System.Drawing.Size(40, 20)
        Me.TRAB_ZONA.TabIndex = 0
        Me.TRAB_ZONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DEPEND
        '
        Me.DEPEND.BackColor = System.Drawing.Color.DimGray
        Me.DEPEND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEPEND.Enabled = False
        Me.DEPEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DEPEND.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPEND.ForeColor = System.Drawing.Color.Yellow
        Me.DEPEND.Location = New System.Drawing.Point(166, 156)
        Me.DEPEND.Name = "DEPEND"
        Me.DEPEND.Size = New System.Drawing.Size(58, 19)
        Me.DEPEND.TabIndex = 234
        Me.DEPEND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Detalle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIPO_DEP
        '
        Me.TIPO_DEP.BackColor = System.Drawing.Color.DimGray
        Me.TIPO_DEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIPO_DEP.Enabled = False
        Me.TIPO_DEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TIPO_DEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPO_DEP.ForeColor = System.Drawing.Color.Yellow
        Me.TIPO_DEP.Location = New System.Drawing.Point(58, 156)
        Me.TIPO_DEP.Name = "TIPO_DEP"
        Me.TIPO_DEP.Size = New System.Drawing.Size(40, 19)
        Me.TIPO_DEP.TabIndex = 233
        Me.TIPO_DEP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(230, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Instalacion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(230, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Inst RUS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TRAB_INSTALACION
        '
        Me.TRAB_INSTALACION.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_INSTALACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_INSTALACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_INSTALACION.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_INSTALACION.Location = New System.Drawing.Point(298, 155)
        Me.TRAB_INSTALACION.Name = "TRAB_INSTALACION"
        Me.TRAB_INSTALACION.Size = New System.Drawing.Size(68, 20)
        Me.TRAB_INSTALACION.TabIndex = 239
        Me.TRAB_INSTALACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TRAB_INSTALACIONRUS
        '
        Me.TRAB_INSTALACIONRUS.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_INSTALACIONRUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_INSTALACIONRUS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_INSTALACIONRUS.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_INSTALACIONRUS.Location = New System.Drawing.Point(298, 178)
        Me.TRAB_INSTALACIONRUS.Name = "TRAB_INSTALACIONRUS"
        Me.TRAB_INSTALACIONRUS.Size = New System.Drawing.Size(68, 20)
        Me.TRAB_INSTALACIONRUS.TabIndex = 240
        Me.TRAB_INSTALACIONRUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TRAB_NODO
        '
        Me.TRAB_NODO.BackColor = System.Drawing.Color.DimGray
        Me.TRAB_NODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRAB_NODO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TRAB_NODO.ForeColor = System.Drawing.Color.Yellow
        Me.TRAB_NODO.Location = New System.Drawing.Point(58, 50)
        Me.TRAB_NODO.Name = "TRAB_NODO"
        Me.TRAB_NODO.Size = New System.Drawing.Size(40, 20)
        Me.TRAB_NODO.TabIndex = 241
        Me.TRAB_NODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INDICE_CALLESDataGridView
        '
        Me.INDICE_CALLESDataGridView.AllowUserToAddRows = False
        Me.INDICE_CALLESDataGridView.AllowUserToDeleteRows = False
        Me.INDICE_CALLESDataGridView.AutoGenerateColumns = False
        Me.INDICE_CALLESDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.INDICE_CALLESDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.INDICE_CALLESDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.INDICE_CALLESDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.INDICE_CALLESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.INDICE_CALLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INDICE_CALLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CALLE, Me.TIPO, Me.NOMBRECALLEDataGridViewTextBoxColumn})
        Me.INDICE_CALLESDataGridView.DataSource = Me.INDICE_CALLESBindingSource
        Me.INDICE_CALLESDataGridView.EnableHeadersVisualStyles = False
        Me.INDICE_CALLESDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.INDICE_CALLESDataGridView.Location = New System.Drawing.Point(30, 150)
        Me.INDICE_CALLESDataGridView.Name = "INDICE_CALLESDataGridView"
        Me.INDICE_CALLESDataGridView.ReadOnly = True
        Me.INDICE_CALLESDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.INDICE_CALLESDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.INDICE_CALLESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.INDICE_CALLESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INDICE_CALLESDataGridView.Size = New System.Drawing.Size(336, 190)
        Me.INDICE_CALLESDataGridView.TabIndex = 309
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
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.MinimumWidth = 65
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 65
        '
        'NOMBRECALLEDataGridViewTextBoxColumn
        '
        Me.NOMBRECALLEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CALLE"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.HeaderText = "Nombre Calle"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.Name = "NOMBRECALLEDataGridViewTextBoxColumn"
        Me.NOMBRECALLEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBRECALLEDataGridViewTextBoxColumn.Width = 270
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(257, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 310
        Me.Label4.Text = "ATR:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_TRAB_ATRIBUTO
        '
        Me.CB_TRAB_ATRIBUTO.FormattingEnabled = True
        Me.CB_TRAB_ATRIBUTO.Items.AddRange(New Object() {"HFC", "RHFC", "FTTH"})
        Me.CB_TRAB_ATRIBUTO.Location = New System.Drawing.Point(305, 74)
        Me.CB_TRAB_ATRIBUTO.Name = "CB_TRAB_ATRIBUTO"
        Me.CB_TRAB_ATRIBUTO.Size = New System.Drawing.Size(63, 21)
        Me.CB_TRAB_ATRIBUTO.TabIndex = 311
        Me.CB_TRAB_ATRIBUTO.Text = "HFC"
        '
        'TXT_PROYECTO
        '
        Me.TXT_PROYECTO.BackColor = System.Drawing.Color.DimGray
        Me.TXT_PROYECTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PROYECTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PROYECTO.ForeColor = System.Drawing.Color.Yellow
        Me.TXT_PROYECTO.Location = New System.Drawing.Point(305, 96)
        Me.TXT_PROYECTO.Name = "TXT_PROYECTO"
        Me.TXT_PROYECTO.Size = New System.Drawing.Size(61, 20)
        Me.TXT_PROYECTO.TabIndex = 313
        Me.TXT_PROYECTO.Text = "0"
        Me.TXT_PROYECTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(247, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 312
        Me.Label5.Text = "Proyecto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NUEVOTRABAJO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(378, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_PROYECTO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CB_TRAB_ATRIBUTO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.INDICE_CALLESDataGridView)
        Me.Controls.Add(Me.TRAB_NODO)
        Me.Controls.Add(Me.TRAB_INSTALACIONRUS)
        Me.Controls.Add(Me.TRAB_INSTALACION)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DEPEND)
        Me.Controls.Add(Me.TIPO_DEP)
        Me.Controls.Add(Me.TRAB_TIPO)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.TRAB_NRO)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.TRAB_CALLE)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.TRAB_MANZANA)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TRAB_TIEMPOESTIMADO)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.TRAB_ZONA)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.TRAB_INIESTIMADO)
        Me.Controls.Add(Me.TRAB_DESCRIPCION)
        Me.Controls.Add(Me.BOT_CANCELARTRABAJO)
        Me.Controls.Add(Me.BOT_GUARDARTRABAJO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NUEVOTRABAJO"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BOT_CANCELARTRABAJO As Button
    Friend WithEvents BOT_GUARDARTRABAJO As Button
    Friend WithEvents Label53 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents TRAB_NRO As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents TRAB_CALLE As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents TRAB_MANZANA As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TRAB_TIEMPOESTIMADO As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents TRAB_INIESTIMADO As DateTimePicker
    Friend WithEvents TRAB_DESCRIPCION As TextBox
    Friend WithEvents TRAB_TIPO As Label
    Friend WithEvents TRAB_ZONA As TextBox
    Friend WithEvents DEPEND As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TIPO_DEP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TRAB_INSTALACION As TextBox
    Friend WithEvents TRAB_INSTALACIONRUS As TextBox
    Friend WithEvents TRAB_NODO As TextBox
    Friend WithEvents INDICE_CALLESDataGridView As DataGridView
    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents INDICE_CALLESBindingSource As BindingSource
    Friend WithEvents INDICE_CALLESTableAdapter As INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRECALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_TRAB_ATRIBUTO As ComboBox
    Friend WithEvents TXT_PROYECTO As TextBox
    Friend WithEvents Label5 As Label
End Class
