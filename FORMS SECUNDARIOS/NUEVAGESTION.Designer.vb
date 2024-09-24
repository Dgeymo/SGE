<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVAGESTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NUEVAGESTION))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GEST_TIPO = New System.Windows.Forms.ComboBox()
        Me.GEST_TESTIMADO = New System.Windows.Forms.TextBox()
        Me.GEST_INIEST = New System.Windows.Forms.DateTimePicker()
        Me.GEST_DESCRIPCION2 = New System.Windows.Forms.TextBox()
        Me.GEST_TELEFCONTAC = New System.Windows.Forms.TextBox()
        Me.GEST_MAILCONTAC = New System.Windows.Forms.TextBox()
        Me.GEST_CONTACTO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BOT_CANCELARGEST = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LBLNODO = New System.Windows.Forms.Label()
        Me.GEST_NODO = New System.Windows.Forms.TextBox()
        Me.GEST_SOLICITANTE = New System.Windows.Forms.ComboBox()
        Me.TXTZONA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSECCION = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSEGMENTO = New System.Windows.Forms.TextBox()
        Me.TXTMANZANA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCALLE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTPUERTA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BOT_GUARDARGEST = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.INDICE_CALLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.INDICE_CALLESTableAdapter = New REDES.INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.CKGENTRAB = New System.Windows.Forms.CheckBox()
        Me.CKLIST = New System.Windows.Forms.CheckedListBox()
        Me.CB_GEST_ATRIBUTO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.COMBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMBOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.COMBOSTableAdapter()
        Me.TableAdapterManager1 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.GESTIONES_TIPOTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONES_TIPOTableAdapter()
        Me.INDICE_CALLESDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTIONES_TIPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_GEST_ORD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBL_ID_CALLE = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONES_TIPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GEST_TIPO
        '
        Me.GEST_TIPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GEST_TIPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GEST_TIPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_TIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GEST_TIPO.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_TIPO.FormattingEnabled = True
        Me.GEST_TIPO.Location = New System.Drawing.Point(120, 12)
        Me.GEST_TIPO.MaxDropDownItems = 50
        Me.GEST_TIPO.Name = "GEST_TIPO"
        Me.GEST_TIPO.Size = New System.Drawing.Size(250, 21)
        Me.GEST_TIPO.TabIndex = 0
        '
        'GEST_TESTIMADO
        '
        Me.GEST_TESTIMADO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_TESTIMADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_TESTIMADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_TESTIMADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GEST_TESTIMADO.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_TESTIMADO.Location = New System.Drawing.Point(221, 161)
        Me.GEST_TESTIMADO.Name = "GEST_TESTIMADO"
        Me.GEST_TESTIMADO.Size = New System.Drawing.Size(41, 24)
        Me.GEST_TESTIMADO.TabIndex = 13
        Me.GEST_TESTIMADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GEST_INIEST
        '
        Me.GEST_INIEST.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_INIEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GEST_INIEST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.GEST_INIEST.Location = New System.Drawing.Point(57, 163)
        Me.GEST_INIEST.Name = "GEST_INIEST"
        Me.GEST_INIEST.Size = New System.Drawing.Size(106, 21)
        Me.GEST_INIEST.TabIndex = 12
        '
        'GEST_DESCRIPCION2
        '
        Me.GEST_DESCRIPCION2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_DESCRIPCION2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_DESCRIPCION2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_DESCRIPCION2.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_DESCRIPCION2.Location = New System.Drawing.Point(61, 209)
        Me.GEST_DESCRIPCION2.Multiline = True
        Me.GEST_DESCRIPCION2.Name = "GEST_DESCRIPCION2"
        Me.GEST_DESCRIPCION2.Size = New System.Drawing.Size(314, 140)
        Me.GEST_DESCRIPCION2.TabIndex = 14
        '
        'GEST_TELEFCONTAC
        '
        Me.GEST_TELEFCONTAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_TELEFCONTAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_TELEFCONTAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_TELEFCONTAC.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_TELEFCONTAC.Location = New System.Drawing.Point(381, 95)
        Me.GEST_TELEFCONTAC.Name = "GEST_TELEFCONTAC"
        Me.GEST_TELEFCONTAC.Size = New System.Drawing.Size(203, 20)
        Me.GEST_TELEFCONTAC.TabIndex = 11
        Me.GEST_TELEFCONTAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GEST_MAILCONTAC
        '
        Me.GEST_MAILCONTAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_MAILCONTAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_MAILCONTAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_MAILCONTAC.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_MAILCONTAC.Location = New System.Drawing.Point(381, 73)
        Me.GEST_MAILCONTAC.Name = "GEST_MAILCONTAC"
        Me.GEST_MAILCONTAC.Size = New System.Drawing.Size(203, 20)
        Me.GEST_MAILCONTAC.TabIndex = 10
        Me.GEST_MAILCONTAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GEST_CONTACTO
        '
        Me.GEST_CONTACTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_CONTACTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_CONTACTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_CONTACTO.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_CONTACTO.Location = New System.Drawing.Point(381, 51)
        Me.GEST_CONTACTO.Name = "GEST_CONTACTO"
        Me.GEST_CONTACTO.Size = New System.Drawing.Size(203, 20)
        Me.GEST_CONTACTO.TabIndex = 9
        Me.GEST_CONTACTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(58, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 15)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "OBSERVACIONES"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BOT_CANCELARGEST
        '
        Me.BOT_CANCELARGEST.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_CANCELARGEST.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BOT_CANCELARGEST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BOT_CANCELARGEST.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_CANCELARGEST.FlatAppearance.BorderSize = 0
        Me.BOT_CANCELARGEST.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_CANCELARGEST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_CANCELARGEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_CANCELARGEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOT_CANCELARGEST.ForeColor = System.Drawing.Color.White
        Me.BOT_CANCELARGEST.Location = New System.Drawing.Point(532, 382)
        Me.BOT_CANCELARGEST.Name = "BOT_CANCELARGEST"
        Me.BOT_CANCELARGEST.Size = New System.Drawing.Size(100, 35)
        Me.BOT_CANCELARGEST.TabIndex = 16
        Me.BOT_CANCELARGEST.Text = "CANCELAR"
        Me.BOT_CANCELARGEST.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(304, 95)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(71, 15)
        Me.Label43.TabIndex = 106
        Me.Label43.Text = "TELEFONO"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(331, 72)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 15)
        Me.Label42.TabIndex = 104
        Me.Label42.Text = "EMAIL"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(303, 51)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 15)
        Me.Label41.TabIndex = 102
        Me.Label41.Text = "CONTACTO"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(449, 9)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 15)
        Me.Label40.TabIndex = 100
        Me.Label40.Text = "SOLICITANTE"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(188, 147)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(118, 15)
        Me.Label56.TabIndex = 96
        Me.Label56.Text = "TIEMPO ESTIMADO"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(58, 147)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(107, 15)
        Me.Label48.TabIndex = 94
        Me.Label48.Text = "INICIO ESTIMADO"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(77, 12)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 19)
        Me.Label36.TabIndex = 49
        Me.Label36.Text = "TIPO"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLNODO
        '
        Me.LBLNODO.AutoSize = True
        Me.LBLNODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.LBLNODO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNODO.ForeColor = System.Drawing.Color.White
        Me.LBLNODO.Location = New System.Drawing.Point(74, 42)
        Me.LBLNODO.Name = "LBLNODO"
        Me.LBLNODO.Size = New System.Drawing.Size(43, 15)
        Me.LBLNODO.TabIndex = 169
        Me.LBLNODO.Text = "NODO"
        Me.LBLNODO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GEST_NODO
        '
        Me.GEST_NODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_NODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEST_NODO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GEST_NODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.GEST_NODO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GEST_NODO.ForeColor = System.Drawing.Color.LightBlue
        Me.GEST_NODO.Location = New System.Drawing.Point(120, 39)
        Me.GEST_NODO.Name = "GEST_NODO"
        Me.GEST_NODO.Size = New System.Drawing.Size(32, 24)
        Me.GEST_NODO.TabIndex = 999
        Me.GEST_NODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GEST_SOLICITANTE
        '
        Me.GEST_SOLICITANTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GEST_SOLICITANTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GEST_SOLICITANTE.ForeColor = System.Drawing.Color.White
        Me.GEST_SOLICITANTE.FormattingEnabled = True
        Me.GEST_SOLICITANTE.Items.AddRange(New Object() {"TERCEROS", "NUEVO SIGLO", "MONTECABLE", "TCC", "EQUITAL"})
        Me.GEST_SOLICITANTE.Location = New System.Drawing.Point(399, 27)
        Me.GEST_SOLICITANTE.Name = "GEST_SOLICITANTE"
        Me.GEST_SOLICITANTE.Size = New System.Drawing.Size(185, 21)
        Me.GEST_SOLICITANTE.TabIndex = 8
        '
        'TXTZONA
        '
        Me.TXTZONA.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTZONA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTZONA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTZONA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTZONA.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTZONA.Location = New System.Drawing.Point(196, 39)
        Me.TXTZONA.Name = "TXTZONA"
        Me.TXTZONA.Size = New System.Drawing.Size(32, 24)
        Me.TXTZONA.TabIndex = 2
        Me.TXTZONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "ZONA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTSECCION
        '
        Me.TXTSECCION.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTSECCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSECCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSECCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSECCION.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTSECCION.Location = New System.Drawing.Point(120, 65)
        Me.TXTSECCION.Name = "TXTSECCION"
        Me.TXTSECCION.Size = New System.Drawing.Size(32, 24)
        Me.TXTSECCION.TabIndex = 3
        Me.TXTSECCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "MANZANA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTSEGMENTO
        '
        Me.TXTSEGMENTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTSEGMENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEGMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSEGMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEGMENTO.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTSEGMENTO.Location = New System.Drawing.Point(158, 65)
        Me.TXTSEGMENTO.Name = "TXTSEGMENTO"
        Me.TXTSEGMENTO.Size = New System.Drawing.Size(32, 24)
        Me.TXTSEGMENTO.TabIndex = 4
        Me.TXTSEGMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTMANZANA
        '
        Me.TXTMANZANA.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTMANZANA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTMANZANA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMANZANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMANZANA.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTMANZANA.Location = New System.Drawing.Point(196, 65)
        Me.TXTMANZANA.Name = "TXTMANZANA"
        Me.TXTMANZANA.Size = New System.Drawing.Size(32, 24)
        Me.TXTMANZANA.TabIndex = 5
        Me.TXTMANZANA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(150, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "/"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(187, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTCALLE
        '
        Me.TXTCALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTCALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCALLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCALLE.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTCALLE.Location = New System.Drawing.Point(56, 117)
        Me.TXTCALLE.Name = "TXTCALLE"
        Me.TXTCALLE.Size = New System.Drawing.Size(223, 24)
        Me.TXTCALLE.TabIndex = 6
        Me.TXTCALLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(87, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "CALLE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTPUERTA
        '
        Me.TXTPUERTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTPUERTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPUERTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPUERTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPUERTA.ForeColor = System.Drawing.Color.LightBlue
        Me.TXTPUERTA.Location = New System.Drawing.Point(334, 117)
        Me.TXTPUERTA.Name = "TXTPUERTA"
        Me.TXTPUERTA.Size = New System.Drawing.Size(70, 24)
        Me.TXTPUERTA.TabIndex = 7
        Me.TXTPUERTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(280, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "PUERTA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BOT_GUARDARGEST
        '
        Me.BOT_GUARDARGEST.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_GUARDARGEST.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BOT_GUARDARGEST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BOT_GUARDARGEST.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BOT_GUARDARGEST.FlatAppearance.BorderSize = 0
        Me.BOT_GUARDARGEST.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_GUARDARGEST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BOT_GUARDARGEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_GUARDARGEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOT_GUARDARGEST.ForeColor = System.Drawing.Color.White
        Me.BOT_GUARDARGEST.Location = New System.Drawing.Point(431, 382)
        Me.BOT_GUARDARGEST.Name = "BOT_GUARDARGEST"
        Me.BOT_GUARDARGEST.Size = New System.Drawing.Size(100, 35)
        Me.BOT_GUARDARGEST.TabIndex = 15
        Me.BOT_GUARDARGEST.Text = "CREAR"
        Me.BOT_GUARDARGEST.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(648, 432)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
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
        Me.TableAdapterManager.TecnicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.INDICESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CKGENTRAB
        '
        Me.CKGENTRAB.AutoSize = True
        Me.CKGENTRAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CKGENTRAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CKGENTRAB.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.CKGENTRAB.FlatAppearance.BorderSize = 0
        Me.CKGENTRAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CKGENTRAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKGENTRAB.ForeColor = System.Drawing.Color.White
        Me.CKGENTRAB.Location = New System.Drawing.Point(460, 180)
        Me.CKGENTRAB.Name = "CKGENTRAB"
        Me.CKGENTRAB.Size = New System.Drawing.Size(166, 19)
        Me.CKGENTRAB.TabIndex = 1018
        Me.CKGENTRAB.Text = "GEN.TRAB. AUTOMATICO"
        Me.CKGENTRAB.UseVisualStyleBackColor = False
        '
        'CKLIST
        '
        Me.CKLIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CKLIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CKLIST.FormattingEnabled = True
        Me.CKLIST.Location = New System.Drawing.Point(460, 201)
        Me.CKLIST.Name = "CKLIST"
        Me.CKLIST.Size = New System.Drawing.Size(166, 165)
        Me.CKLIST.TabIndex = 1020
        '
        'CB_GEST_ATRIBUTO
        '
        Me.CB_GEST_ATRIBUTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CB_GEST_ATRIBUTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_GEST_ATRIBUTO.ForeColor = System.Drawing.Color.White
        Me.CB_GEST_ATRIBUTO.Items.AddRange(New Object() {"HFC", "RHFC", "FTTH"})
        Me.CB_GEST_ATRIBUTO.Location = New System.Drawing.Point(498, 118)
        Me.CB_GEST_ATRIBUTO.Name = "CB_GEST_ATRIBUTO"
        Me.CB_GEST_ATRIBUTO.Size = New System.Drawing.Size(86, 21)
        Me.CB_GEST_ATRIBUTO.TabIndex = 1021
        Me.CB_GEST_ATRIBUTO.Text = "HFC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(429, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 1022
        Me.Label1.Text = "TIPO RED"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMBOSBindingSource
        '
        Me.COMBOSBindingSource.DataMember = "COMBOS"
        Me.COMBOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'COMBOSTableAdapter
        '
        Me.COMBOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager1.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager1.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager1.AREASTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager1.COMBOSTableAdapter = Me.COMBOSTableAdapter
        Me.TableAdapterManager1.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager1.FALLASTableAdapter = Nothing
        Me.TableAdapterManager1.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONES_TIPOTableAdapter = Me.GESTIONES_TIPOTableAdapter
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
        'GESTIONES_TIPOTableAdapter
        '
        Me.GESTIONES_TIPOTableAdapter.ClearBeforeFill = True
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
        Me.INDICE_CALLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ID_CALLE, Me.NOMBRE_CALLE})
        Me.INDICE_CALLESDataGridView.DataSource = Me.INDICE_CALLESBindingSource
        Me.INDICE_CALLESDataGridView.EnableHeadersVisualStyles = False
        Me.INDICE_CALLESDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INDICE_CALLESDataGridView.Location = New System.Drawing.Point(56, 142)
        Me.INDICE_CALLESDataGridView.Name = "INDICE_CALLESDataGridView"
        Me.INDICE_CALLESDataGridView.ReadOnly = True
        Me.INDICE_CALLESDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.INDICE_CALLESDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.INDICE_CALLESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.INDICE_CALLESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INDICE_CALLESDataGridView.Size = New System.Drawing.Size(336, 207)
        Me.INDICE_CALLESDataGridView.TabIndex = 1000
        Me.INDICE_CALLESDataGridView.Visible = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'ID_CALLE
        '
        Me.ID_CALLE.DataPropertyName = "ID_CALLE"
        Me.ID_CALLE.HeaderText = "CALLE"
        Me.ID_CALLE.Name = "ID_CALLE"
        Me.ID_CALLE.ReadOnly = True
        Me.ID_CALLE.Width = 50
        '
        'NOMBRE_CALLE
        '
        Me.NOMBRE_CALLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE_CALLE.DataPropertyName = "NOMBRE_CALLE"
        Me.NOMBRE_CALLE.HeaderText = "NOMBRE"
        Me.NOMBRE_CALLE.Name = "NOMBRE_CALLE"
        Me.NOMBRE_CALLE.ReadOnly = True
        '
        'GESTIONES_TIPOBindingSource
        '
        Me.GESTIONES_TIPOBindingSource.DataMember = "GESTIONES_TIPO"
        Me.GESTIONES_TIPOBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ID_GEST_ORD
        '
        Me.ID_GEST_ORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ID_GEST_ORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_GEST_ORD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ID_GEST_ORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_GEST_ORD.ForeColor = System.Drawing.Color.LightBlue
        Me.ID_GEST_ORD.Location = New System.Drawing.Point(322, 382)
        Me.ID_GEST_ORD.Name = "ID_GEST_ORD"
        Me.ID_GEST_ORD.Size = New System.Drawing.Size(70, 24)
        Me.ID_GEST_ORD.TabIndex = 1023
        Me.ID_GEST_ORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(200, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 1024
        Me.Label8.Text = "GESTION SIS_ORD"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_ID_CALLE
        '
        Me.LBL_ID_CALLE.AutoSize = True
        Me.LBL_ID_CALLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.LBL_ID_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ID_CALLE.ForeColor = System.Drawing.Color.White
        Me.LBL_ID_CALLE.Location = New System.Drawing.Point(152, 105)
        Me.LBL_ID_CALLE.Name = "LBL_ID_CALLE"
        Me.LBL_ID_CALLE.Size = New System.Drawing.Size(0, 9)
        Me.LBL_ID_CALLE.TabIndex = 1025
        Me.LBL_ID_CALLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NUEVAGESTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_ID_CALLE)
        Me.Controls.Add(Me.ID_GEST_ORD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_GEST_ATRIBUTO)
        Me.Controls.Add(Me.CKGENTRAB)
        Me.Controls.Add(Me.INDICE_CALLESDataGridView)
        Me.Controls.Add(Me.TXTPUERTA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTCALLE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTSECCION)
        Me.Controls.Add(Me.TXTSEGMENTO)
        Me.Controls.Add(Me.TXTMANZANA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTZONA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GEST_SOLICITANTE)
        Me.Controls.Add(Me.GEST_NODO)
        Me.Controls.Add(Me.LBLNODO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BOT_CANCELARGEST)
        Me.Controls.Add(Me.BOT_GUARDARGEST)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.GEST_TELEFCONTAC)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.GEST_MAILCONTAC)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.GEST_CONTACTO)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.GEST_TESTIMADO)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.GEST_INIEST)
        Me.Controls.Add(Me.GEST_DESCRIPCION2)
        Me.Controls.Add(Me.GEST_TIPO)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.CKLIST)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NUEVAGESTION"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONES_TIPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label36 As Label
    Friend WithEvents GEST_TIPO As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents GEST_TESTIMADO As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents GEST_INIEST As DateTimePicker
    Friend WithEvents GEST_DESCRIPCION2 As TextBox
    Friend WithEvents BOT_CANCELARGEST As Button
    Friend WithEvents BOT_GUARDARGEST As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents GEST_TELEFCONTAC As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents GEST_MAILCONTAC As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents GEST_CONTACTO As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBLNODO As Label
    Friend WithEvents GEST_NODO As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GEST_SOLICITANTE As ComboBox
    Friend WithEvents TXTZONA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTSECCION As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSEGMENTO As TextBox
    Friend WithEvents TXTMANZANA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTCALLE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTPUERTA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents INDICE_CALLESBindingSource As BindingSource
    Friend WithEvents INDICE_CALLESTableAdapter As INDICESDataSetTableAdapters.INDICE_CALLESTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CKGENTRAB As CheckBox
    Friend WithEvents CKLIST As CheckedListBox
    Friend WithEvents BTN_PASAR_GESTION As Button
    Friend WithEvents CB_GEST_ATRIBUTO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents COMBOSBindingSource As BindingSource
    Friend WithEvents COMBOSTableAdapter As ORDENESDataSetTableAdapters.COMBOSTableAdapter
    Friend WithEvents TableAdapterManager1 As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GESTIONES_TIPOTableAdapter As ORDENESDataSetTableAdapters.GESTIONES_TIPOTableAdapter
    Friend WithEvents INDICE_CALLESDataGridView As DataGridView
    Friend WithEvents GESTIONES_TIPOBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_CALLE As DataGridViewTextBoxColumn
    Friend WithEvents ID_GEST_ORD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LBL_ID_CALLE As Label
End Class
