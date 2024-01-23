<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENSAJERIA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BOT_IMPRIMIRMENSAJE = New System.Windows.Forms.Button()
        Me.FILTRALEIDOS = New System.Windows.Forms.ComboBox()
        Me.BOT_MARCARNOLEIDO = New System.Windows.Forms.Button()
        Me.BOT_CANCELAR = New System.Windows.Forms.Button()
        Me.BOT_NUEVO = New System.Windows.Forms.Button()
        Me.BOT_RESPONDER = New System.Windows.Forms.Button()
        Me.BOT_ENVIAR = New System.Windows.Forms.Button()
        Me.MENSAJE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ASUNTO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TIPO_ORDEN = New System.Windows.Forms.ComboBox()
        Me.NRO_ORDEN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PARA_SECTOR = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PARA_NOMBRE = New System.Windows.Forms.ComboBox()
        Me.TIPO_MENSAJE = New System.Windows.Forms.ComboBox()
        Me.OPERACIONES_LOGDataSet = New REDES.OPERACIONES_LOGDataSet()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New REDES.OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter()
        Me.TableAdapterManager = New REDES.OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.MENSAJERIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MENSAJERIATableAdapter = New REDES.ORDENESDataSetTableAdapters.MENSAJERIATableAdapter()
        Me.TableAdapterManager1 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OrdenesDataSet1 = New REDES.ORDENESDataSet()
        Me.OrdenesDataSet2 = New REDES.ORDENESDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FECHACREADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUNTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORIGENNOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORIGENSECTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINONOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINOSECTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEIDODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdMENSAJEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOORDENASOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROORDENASOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHALEIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BOT_REENVIAR = New System.Windows.Forms.Button()
        Me.DE_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DE_SECTOR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.Location = New System.Drawing.Point(15, 17)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(288, 34)
        Me.Button9.TabIndex = 80
        Me.Button9.Text = "Enviar y Recibir"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'BOT_IMPRIMIRMENSAJE
        '
        Me.BOT_IMPRIMIRMENSAJE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_IMPRIMIRMENSAJE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_IMPRIMIRMENSAJE.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_IMPRIMIRMENSAJE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_IMPRIMIRMENSAJE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_IMPRIMIRMENSAJE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_IMPRIMIRMENSAJE.ForeColor = System.Drawing.Color.White
        Me.BOT_IMPRIMIRMENSAJE.Location = New System.Drawing.Point(150, 214)
        Me.BOT_IMPRIMIRMENSAJE.Name = "BOT_IMPRIMIRMENSAJE"
        Me.BOT_IMPRIMIRMENSAJE.Size = New System.Drawing.Size(153, 34)
        Me.BOT_IMPRIMIRMENSAJE.TabIndex = 78
        Me.BOT_IMPRIMIRMENSAJE.Text = "Imprimir Mensaje"
        Me.BOT_IMPRIMIRMENSAJE.UseVisualStyleBackColor = False
        Me.BOT_IMPRIMIRMENSAJE.Visible = False
        '
        'FILTRALEIDOS
        '
        Me.FILTRALEIDOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FILTRALEIDOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FILTRALEIDOS.ForeColor = System.Drawing.Color.LightGray
        Me.FILTRALEIDOS.FormattingEnabled = True
        Me.FILTRALEIDOS.Items.AddRange(New Object() {"TODOS", "NO LEIDOS"})
        Me.FILTRALEIDOS.Location = New System.Drawing.Point(165, 53)
        Me.FILTRALEIDOS.Name = "FILTRALEIDOS"
        Me.FILTRALEIDOS.Size = New System.Drawing.Size(138, 21)
        Me.FILTRALEIDOS.TabIndex = 77
        '
        'BOT_MARCARNOLEIDO
        '
        Me.BOT_MARCARNOLEIDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_MARCARNOLEIDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_MARCARNOLEIDO.Enabled = False
        Me.BOT_MARCARNOLEIDO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_MARCARNOLEIDO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_MARCARNOLEIDO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_MARCARNOLEIDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_MARCARNOLEIDO.ForeColor = System.Drawing.Color.White
        Me.BOT_MARCARNOLEIDO.Location = New System.Drawing.Point(150, 106)
        Me.BOT_MARCARNOLEIDO.Name = "BOT_MARCARNOLEIDO"
        Me.BOT_MARCARNOLEIDO.Size = New System.Drawing.Size(153, 34)
        Me.BOT_MARCARNOLEIDO.TabIndex = 76
        Me.BOT_MARCARNOLEIDO.Text = "Marcar  NO LEIDO"
        Me.BOT_MARCARNOLEIDO.UseVisualStyleBackColor = False
        '
        'BOT_CANCELAR
        '
        Me.BOT_CANCELAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_CANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_CANCELAR.ForeColor = System.Drawing.Color.LightCoral
        Me.BOT_CANCELAR.Location = New System.Drawing.Point(15, 280)
        Me.BOT_CANCELAR.Name = "BOT_CANCELAR"
        Me.BOT_CANCELAR.Size = New System.Drawing.Size(288, 34)
        Me.BOT_CANCELAR.TabIndex = 71
        Me.BOT_CANCELAR.Text = "Cancelar"
        Me.BOT_CANCELAR.UseVisualStyleBackColor = False
        '
        'BOT_NUEVO
        '
        Me.BOT_NUEVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_NUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_NUEVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BOT_NUEVO.Location = New System.Drawing.Point(15, 317)
        Me.BOT_NUEVO.Name = "BOT_NUEVO"
        Me.BOT_NUEVO.Size = New System.Drawing.Size(288, 34)
        Me.BOT_NUEVO.TabIndex = 69
        Me.BOT_NUEVO.Text = "Nuevo Mensaje"
        Me.BOT_NUEVO.UseVisualStyleBackColor = False
        '
        'BOT_RESPONDER
        '
        Me.BOT_RESPONDER.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_RESPONDER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_RESPONDER.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_RESPONDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_RESPONDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_RESPONDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_RESPONDER.ForeColor = System.Drawing.Color.White
        Me.BOT_RESPONDER.Location = New System.Drawing.Point(150, 142)
        Me.BOT_RESPONDER.Name = "BOT_RESPONDER"
        Me.BOT_RESPONDER.Size = New System.Drawing.Size(153, 34)
        Me.BOT_RESPONDER.TabIndex = 68
        Me.BOT_RESPONDER.Text = "Responder"
        Me.BOT_RESPONDER.UseVisualStyleBackColor = False
        '
        'BOT_ENVIAR
        '
        Me.BOT_ENVIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_ENVIAR.BackgroundImage = Global.REDES.My.Resources.Resources.DERECHA
        Me.BOT_ENVIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_ENVIAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_ENVIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_ENVIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_ENVIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_ENVIAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_ENVIAR.Location = New System.Drawing.Point(1249, 374)
        Me.BOT_ENVIAR.Name = "BOT_ENVIAR"
        Me.BOT_ENVIAR.Size = New System.Drawing.Size(97, 66)
        Me.BOT_ENVIAR.TabIndex = 67
        Me.BOT_ENVIAR.Text = "Enviar"
        Me.BOT_ENVIAR.UseVisualStyleBackColor = False
        '
        'MENSAJE
        '
        Me.MENSAJE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MENSAJE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MENSAJE.ForeColor = System.Drawing.Color.White
        Me.MENSAJE.Location = New System.Drawing.Point(322, 456)
        Me.MENSAJE.Multiline = True
        Me.MENSAJE.Name = "MENSAJE"
        Me.MENSAJE.Size = New System.Drawing.Size(1039, 197)
        Me.MENSAJE.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DimGray
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(329, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(859, 25)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Asunto :"
        '
        'ASUNTO
        '
        Me.ASUNTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ASUNTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUNTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASUNTO.ForeColor = System.Drawing.Color.White
        Me.ASUNTO.Location = New System.Drawing.Point(379, 427)
        Me.ASUNTO.Name = "ASUNTO"
        Me.ASUNTO.Size = New System.Drawing.Size(807, 21)
        Me.ASUNTO.TabIndex = 65
        Me.ASUNTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DimGray
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(910, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(235, 25)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Tipo Orden"
        '
        'TIPO_ORDEN
        '
        Me.TIPO_ORDEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TIPO_ORDEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TIPO_ORDEN.ForeColor = System.Drawing.Color.White
        Me.TIPO_ORDEN.FormattingEnabled = True
        Me.TIPO_ORDEN.Items.AddRange(New Object() {"ORDINAL", "ORDENINT", "TAREA"})
        Me.TIPO_ORDEN.Location = New System.Drawing.Point(973, 369)
        Me.TIPO_ORDEN.Name = "TIPO_ORDEN"
        Me.TIPO_ORDEN.Size = New System.Drawing.Size(170, 21)
        Me.TIPO_ORDEN.TabIndex = 63
        '
        'NRO_ORDEN
        '
        Me.NRO_ORDEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NRO_ORDEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NRO_ORDEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_ORDEN.ForeColor = System.Drawing.Color.White
        Me.NRO_ORDEN.Location = New System.Drawing.Point(973, 397)
        Me.NRO_ORDEN.Name = "NRO_ORDEN"
        Me.NRO_ORDEN.Size = New System.Drawing.Size(110, 21)
        Me.NRO_ORDEN.TabIndex = 61
        Me.NRO_ORDEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(644, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Sector:"
        '
        'PARA_SECTOR
        '
        Me.PARA_SECTOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PARA_SECTOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PARA_SECTOR.ForeColor = System.Drawing.Color.White
        Me.PARA_SECTOR.FormattingEnabled = True
        Me.PARA_SECTOR.Location = New System.Drawing.Point(702, 398)
        Me.PARA_SECTOR.Name = "PARA_SECTOR"
        Me.PARA_SECTOR.Size = New System.Drawing.Size(178, 21)
        Me.PARA_SECTOR.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(329, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(285, 25)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Para:"
        '
        'PARA_NOMBRE
        '
        Me.PARA_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PARA_NOMBRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PARA_NOMBRE.ForeColor = System.Drawing.Color.White
        Me.PARA_NOMBRE.FormattingEnabled = True
        Me.PARA_NOMBRE.Location = New System.Drawing.Point(380, 398)
        Me.PARA_NOMBRE.Name = "PARA_NOMBRE"
        Me.PARA_NOMBRE.Size = New System.Drawing.Size(231, 21)
        Me.PARA_NOMBRE.TabIndex = 56
        '
        'TIPO_MENSAJE
        '
        Me.TIPO_MENSAJE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TIPO_MENSAJE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TIPO_MENSAJE.ForeColor = System.Drawing.Color.LightGray
        Me.TIPO_MENSAJE.FormattingEnabled = True
        Me.TIPO_MENSAJE.Items.AddRange(New Object() {"RECIBIDOS", "ENVIADOS"})
        Me.TIPO_MENSAJE.Location = New System.Drawing.Point(15, 53)
        Me.TIPO_MENSAJE.Name = "TIPO_MENSAJE"
        Me.TIPO_MENSAJE.Size = New System.Drawing.Size(138, 21)
        Me.TIPO_MENSAJE.TabIndex = 55
        '
        'OPERACIONES_LOGDataSet
        '
        Me.OPERACIONES_LOGDataSet.DataSetName = "OPERACIONES_LOGDataSet"
        Me.OPERACIONES_LOGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.OPERACIONES_LOGDataSet
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = REDES.OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSTableAdapter = Me.USUARIOSTableAdapter
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MENSAJERIABindingSource
        '
        Me.MENSAJERIABindingSource.DataMember = "MENSAJERIA"
        Me.MENSAJERIABindingSource.DataSource = Me.ORDENESDataSet
        '
        'MENSAJERIATableAdapter
        '
        Me.MENSAJERIATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager1.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager1.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager1.AREASTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager1.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager1.FALLASTableAdapter = Nothing
        Me.TableAdapterManager1.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager1.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager1.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager1.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager1.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager1.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager1.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager1.MENSAJERIATableAdapter = Me.MENSAJERIATableAdapter
        Me.TableAdapterManager1.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager1.ORDENESTableAdapter = Me.ORDENESTableAdapter
        Me.TableAdapterManager1.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager1.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager1.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager1.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager1.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager1.STATUSTableAdapter = Nothing
        Me.TableAdapterManager1.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager1.TAREASTableAdapter = Nothing
        Me.TableAdapterManager1.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'Timer1
        '
        Me.Timer1.Interval = 100000
        '
        'OrdenesDataSet1
        '
        Me.OrdenesDataSet1.DataSetName = "ORDENESDataSet"
        Me.OrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdenesDataSet2
        '
        Me.OrdenesDataSet2.DataSetName = "ORDENESDataSet"
        Me.OrdenesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHACREADODataGridViewTextBoxColumn, Me.ASUNTODataGridViewTextBoxColumn, Me.ORIGENNOMBREDataGridViewTextBoxColumn, Me.ORIGENSECTORDataGridViewTextBoxColumn, Me.DESTINONOMBREDataGridViewTextBoxColumn, Me.DESTINOSECTORDataGridViewTextBoxColumn, Me.LEIDODataGridViewCheckBoxColumn, Me.IdMENSAJEDataGridViewTextBoxColumn, Me.TIPOORDENASOCDataGridViewTextBoxColumn, Me.NROORDENASOCDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.FECHALEIDODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MENSAJERIABindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(323, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1038, 355)
        Me.DataGridView1.TabIndex = 85
        '
        'FECHACREADODataGridViewTextBoxColumn
        '
        Me.FECHACREADODataGridViewTextBoxColumn.DataPropertyName = "FECHACREADO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FECHACREADODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECHACREADODataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FECHACREADODataGridViewTextBoxColumn.Name = "FECHACREADODataGridViewTextBoxColumn"
        Me.FECHACREADODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHACREADODataGridViewTextBoxColumn.Width = 80
        '
        'ASUNTODataGridViewTextBoxColumn
        '
        Me.ASUNTODataGridViewTextBoxColumn.DataPropertyName = "ASUNTO"
        Me.ASUNTODataGridViewTextBoxColumn.HeaderText = "Asunto"
        Me.ASUNTODataGridViewTextBoxColumn.Name = "ASUNTODataGridViewTextBoxColumn"
        Me.ASUNTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ORIGENNOMBREDataGridViewTextBoxColumn
        '
        Me.ORIGENNOMBREDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN_NOMBRE"
        Me.ORIGENNOMBREDataGridViewTextBoxColumn.HeaderText = "De:"
        Me.ORIGENNOMBREDataGridViewTextBoxColumn.Name = "ORIGENNOMBREDataGridViewTextBoxColumn"
        Me.ORIGENNOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ORIGENSECTORDataGridViewTextBoxColumn
        '
        Me.ORIGENSECTORDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN_SECTOR"
        Me.ORIGENSECTORDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.ORIGENSECTORDataGridViewTextBoxColumn.Name = "ORIGENSECTORDataGridViewTextBoxColumn"
        Me.ORIGENSECTORDataGridViewTextBoxColumn.ReadOnly = True
        Me.ORIGENSECTORDataGridViewTextBoxColumn.Width = 140
        '
        'DESTINONOMBREDataGridViewTextBoxColumn
        '
        Me.DESTINONOMBREDataGridViewTextBoxColumn.DataPropertyName = "DESTINO_NOMBRE"
        Me.DESTINONOMBREDataGridViewTextBoxColumn.HeaderText = "Para"
        Me.DESTINONOMBREDataGridViewTextBoxColumn.Name = "DESTINONOMBREDataGridViewTextBoxColumn"
        Me.DESTINONOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESTINONOMBREDataGridViewTextBoxColumn.Width = 140
        '
        'DESTINOSECTORDataGridViewTextBoxColumn
        '
        Me.DESTINOSECTORDataGridViewTextBoxColumn.DataPropertyName = "DESTINO_SECTOR"
        Me.DESTINOSECTORDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.DESTINOSECTORDataGridViewTextBoxColumn.Name = "DESTINOSECTORDataGridViewTextBoxColumn"
        Me.DESTINOSECTORDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESTINOSECTORDataGridViewTextBoxColumn.Width = 120
        '
        'LEIDODataGridViewCheckBoxColumn
        '
        Me.LEIDODataGridViewCheckBoxColumn.DataPropertyName = "LEIDO"
        Me.LEIDODataGridViewCheckBoxColumn.HeaderText = "Leido"
        Me.LEIDODataGridViewCheckBoxColumn.Name = "LEIDODataGridViewCheckBoxColumn"
        Me.LEIDODataGridViewCheckBoxColumn.ReadOnly = True
        Me.LEIDODataGridViewCheckBoxColumn.Width = 40
        '
        'IdMENSAJEDataGridViewTextBoxColumn
        '
        Me.IdMENSAJEDataGridViewTextBoxColumn.DataPropertyName = "Id_MENSAJE"
        Me.IdMENSAJEDataGridViewTextBoxColumn.HeaderText = "Id_MENSAJE"
        Me.IdMENSAJEDataGridViewTextBoxColumn.Name = "IdMENSAJEDataGridViewTextBoxColumn"
        Me.IdMENSAJEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMENSAJEDataGridViewTextBoxColumn.Visible = False
        '
        'TIPOORDENASOCDataGridViewTextBoxColumn
        '
        Me.TIPOORDENASOCDataGridViewTextBoxColumn.DataPropertyName = "TIPO_ORDENASOC"
        Me.TIPOORDENASOCDataGridViewTextBoxColumn.HeaderText = "Tipo Ord "
        Me.TIPOORDENASOCDataGridViewTextBoxColumn.Name = "TIPOORDENASOCDataGridViewTextBoxColumn"
        Me.TIPOORDENASOCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NROORDENASOCDataGridViewTextBoxColumn
        '
        Me.NROORDENASOCDataGridViewTextBoxColumn.DataPropertyName = "NRO_ORDENASOC"
        Me.NROORDENASOCDataGridViewTextBoxColumn.HeaderText = "Nro Ord"
        Me.NROORDENASOCDataGridViewTextBoxColumn.Name = "NROORDENASOCDataGridViewTextBoxColumn"
        Me.NROORDENASOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NROORDENASOCDataGridViewTextBoxColumn.Width = 60
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATUSDataGridViewTextBoxColumn.Width = 60
        '
        'FECHALEIDODataGridViewTextBoxColumn
        '
        Me.FECHALEIDODataGridViewTextBoxColumn.DataPropertyName = "FECHALEIDO"
        Me.FECHALEIDODataGridViewTextBoxColumn.HeaderText = "Fecha Leido"
        Me.FECHALEIDODataGridViewTextBoxColumn.Name = "FECHALEIDODataGridViewTextBoxColumn"
        Me.FECHALEIDODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHALEIDODataGridViewTextBoxColumn.Width = 80
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(322, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1039, 95)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'BOT_REENVIAR
        '
        Me.BOT_REENVIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOT_REENVIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOT_REENVIAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BOT_REENVIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BOT_REENVIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BOT_REENVIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_REENVIAR.ForeColor = System.Drawing.Color.White
        Me.BOT_REENVIAR.Location = New System.Drawing.Point(150, 178)
        Me.BOT_REENVIAR.Name = "BOT_REENVIAR"
        Me.BOT_REENVIAR.Size = New System.Drawing.Size(153, 34)
        Me.BOT_REENVIAR.TabIndex = 88
        Me.BOT_REENVIAR.Text = "Reenviar"
        Me.BOT_REENVIAR.UseVisualStyleBackColor = False
        '
        'DE_NOMBRE
        '
        Me.DE_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DE_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DE_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DE_NOMBRE.ForeColor = System.Drawing.Color.White
        Me.DE_NOMBRE.Location = New System.Drawing.Point(379, 369)
        Me.DE_NOMBRE.Name = "DE_NOMBRE"
        Me.DE_NOMBRE.ReadOnly = True
        Me.DE_NOMBRE.Size = New System.Drawing.Size(233, 21)
        Me.DE_NOMBRE.TabIndex = 89
        Me.DE_NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(329, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "De:"
        '
        'DE_SECTOR
        '
        Me.DE_SECTOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DE_SECTOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DE_SECTOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DE_SECTOR.ForeColor = System.Drawing.Color.White
        Me.DE_SECTOR.Location = New System.Drawing.Point(702, 369)
        Me.DE_SECTOR.Name = "DE_SECTOR"
        Me.DE_SECTOR.ReadOnly = True
        Me.DE_SECTOR.Size = New System.Drawing.Size(178, 21)
        Me.DE_SECTOR.TabIndex = 91
        Me.DE_SECTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(644, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 25)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Sector:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(910, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 25)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Nro"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.REDES.My.Resources.Resources.refresh_celeste
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.BackgroundImage = Global.REDES.My.Resources.Resources.correo_electronico_vacio
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(21, 318)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 30)
        Me.PictureBox3.TabIndex = 95
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox4.BackgroundImage = Global.REDES.My.Resources.Resources.klipartz_com__2_
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(22, 285)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.TabIndex = 96
        Me.PictureBox4.TabStop = False
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 665)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NRO_ORDEN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TIPO_ORDEN)
        Me.Controls.Add(Me.PARA_SECTOR)
        Me.Controls.Add(Me.DE_SECTOR)
        Me.Controls.Add(Me.ASUNTO)
        Me.Controls.Add(Me.PARA_NOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DE_NOMBRE)
        Me.Controls.Add(Me.BOT_REENVIAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.BOT_IMPRIMIRMENSAJE)
        Me.Controls.Add(Me.FILTRALEIDOS)
        Me.Controls.Add(Me.BOT_MARCARNOLEIDO)
        Me.Controls.Add(Me.BOT_CANCELAR)
        Me.Controls.Add(Me.BOT_NUEVO)
        Me.Controls.Add(Me.BOT_RESPONDER)
        Me.Controls.Add(Me.BOT_ENVIAR)
        Me.Controls.Add(Me.MENSAJE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TIPO_MENSAJE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PRINCIPAL"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PRINCIPAL"
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button9 As Button
    Friend WithEvents BOT_IMPRIMIRMENSAJE As Button
    Friend WithEvents FILTRALEIDOS As ComboBox
    Friend WithEvents BOT_MARCARNOLEIDO As Button
    Friend WithEvents BOT_CANCELAR As Button
    Friend WithEvents BOT_NUEVO As Button
    Friend WithEvents BOT_RESPONDER As Button
    Friend WithEvents BOT_ENVIAR As Button
    Friend WithEvents MENSAJE As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ASUNTO As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TIPO_ORDEN As ComboBox
    Friend WithEvents NRO_ORDEN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PARA_SECTOR As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PARA_NOMBRE As ComboBox
    Friend WithEvents TIPO_MENSAJE As ComboBox
    Friend WithEvents OPERACIONES_LOGDataSet As OPERACIONES_LOGDataSet
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents USUARIOSTableAdapter As OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents TableAdapterManager As OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents MENSAJERIABindingSource As BindingSource
    Friend WithEvents MENSAJERIATableAdapter As ORDENESDataSetTableAdapters.MENSAJERIATableAdapter
    Friend WithEvents TableAdapterManager1 As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OrdenesDataSet1 As ORDENESDataSet
    Friend WithEvents OrdenesDataSet2 As ORDENESDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BOT_REENVIAR As Button
    Friend WithEvents FECHACREADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASUNTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORIGENNOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORIGENSECTORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESTINONOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESTINOSECTORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LEIDODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdMENSAJEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOORDENASOCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NROORDENASOCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHALEIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DE_NOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DE_SECTOR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
