﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DASHBOARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DASHBOARD))
        Me.PanelTrabajo = New System.Windows.Forms.Panel()
        Me.DGVRESULT = New System.Windows.Forms.DataGridView()
        Me.BTN_MODIFICA = New System.Windows.Forms.Button()
        Me.LBLCUENTA2 = New System.Windows.Forms.Label()
        Me.lblcuentas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_PASAR = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.BTN_DATABASE = New System.Windows.Forms.Button()
        Me.BTN_BUSCADOR = New System.Windows.Forms.Button()
        Me.BTN_OBRAS = New System.Windows.Forms.Button()
        Me.BTN_BOT = New System.Windows.Forms.Button()
        Me.MISTrabajos = New System.Windows.Forms.Button()
        Me.BTN_MISGestiones = New System.Windows.Forms.Button()
        Me.BTN_FTTB = New System.Windows.Forms.Button()
        Me.BTN_Proceso = New System.Windows.Forms.Button()
        Me.BTN_Usuario = New System.Windows.Forms.Button()
        Me.BTN_AGENDA = New System.Windows.Forms.Button()
        Me.BTN_ADMIN = New System.Windows.Forms.Button()
        Me.BTN_FUENTES = New System.Windows.Forms.Button()
        Me.BtnPropiedades = New System.Windows.Forms.Button()
        Me.BTN_DESPACHO = New System.Windows.Forms.Button()
        Me.BTN_RED = New System.Windows.Forms.Button()
        Me.BTN_MDU = New System.Windows.Forms.Button()
        Me.BTN_Directorio = New System.Windows.Forms.Button()
        Me.RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialogINGRESO = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialogINGRESO = New System.Windows.Forms.OpenFileDialog()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelSUPInterior = New System.Windows.Forms.Panel()
        Me.BTNCerrarAsignado = New System.Windows.Forms.Button()
        Me.BTNCerrarMensajes = New System.Windows.Forms.Button()
        Me.BTN8Close = New System.Windows.Forms.Button()
        Me.BTN8 = New System.Windows.Forms.Button()
        Me.BTN7Close = New System.Windows.Forms.Button()
        Me.BTN7 = New System.Windows.Forms.Button()
        Me.BTN6Close = New System.Windows.Forms.Button()
        Me.BTN5Close = New System.Windows.Forms.Button()
        Me.BTN4Close = New System.Windows.Forms.Button()
        Me.BTN6 = New System.Windows.Forms.Button()
        Me.BTN5 = New System.Windows.Forms.Button()
        Me.BTN4 = New System.Windows.Forms.Button()
        Me.BTN3Close = New System.Windows.Forms.Button()
        Me.BTN2Close = New System.Windows.Forms.Button()
        Me.BTN1Close = New System.Windows.Forms.Button()
        Me.BTNMensajeria = New System.Windows.Forms.Button()
        Me.BTNAsignado = New System.Windows.Forms.Button()
        Me.BTN3 = New System.Windows.Forms.Button()
        Me.BTN2 = New System.Windows.Forms.Button()
        Me.BTN1 = New System.Windows.Forms.Button()
        Me.BTN_HAND = New System.Windows.Forms.Button()
        Me.PIC_CLIMA = New System.Windows.Forms.PictureBox()
        Me.LBL_TEMP = New System.Windows.Forms.Label()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnFull = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.FechaAhora = New System.Windows.Forms.Label()
        Me.HoraAhora = New System.Windows.Forms.Label()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPERACIONES_LOGDataSet = New REDES.OPERACIONES_LOGDataSet()
        Me.USUARIOSTableAdapter = New REDES.OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter()
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.CLIMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIMATableAdapter = New REDES.INDICESDataSetTableAdapters.CLIMATableAdapter()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.MENSAJERIATableAdapter = New REDES.ORDENESDataSetTableAdapters.MENSAJERIATableAdapter()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.HISTORICOTableAdapter = New REDES.ORDENESDataSetTableAdapters.HISTORICOTableAdapter()
        Me.OrdenesDataSet1 = New REDES.ORDENESDataSet()
        Me.MENSAJERIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HISTORICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICE_CALLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BASEFUENTESDataSet = New REDES.BASEFUENTESDataSet()
        Me.FUENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUENTETableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.FUENTETableAdapter()
        Me.TableAdapterManager = New REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager()
        Me.FECHA_BATERIATableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.FECHA_BATERIATableAdapter()
        Me.TIPO_BATERIATableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.TIPO_BATERIATableAdapter()
        Me.TIPO_FUENTETableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.TIPO_FUENTETableAdapter()
        Me.TIPO_BATERIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_FUENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FECHA_BATERIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICE_CALLESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICE_CALLESTableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.INDICE_CALLESTableAdapter()
        Me.EDIFICIODataSet = New REDES.EDIFICIODataSet()
        Me.FTTBTableAdapter = New REDES.EDIFICIODataSetTableAdapters.FTTBTableAdapter()
        Me.FTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.PanelTrabajo.SuspendLayout()
        CType(Me.DGVRESULT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelSUPInterior.SuspendLayout()
        CType(Me.PIC_CLIMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_BATERIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_FUENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_BATERIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICE_CALLESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTrabajo
        '
        Me.PanelTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.PanelTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelTrabajo.Controls.Add(Me.DGVRESULT)
        Me.PanelTrabajo.Controls.Add(Me.BTN_MODIFICA)
        Me.PanelTrabajo.Controls.Add(Me.LBLCUENTA2)
        Me.PanelTrabajo.Controls.Add(Me.lblcuentas)
        Me.PanelTrabajo.Controls.Add(Me.Label1)
        Me.PanelTrabajo.Controls.Add(Me.BTN_PASAR)
        Me.PanelTrabajo.Controls.Add(Me.PanelInferior)
        Me.PanelTrabajo.Controls.Add(Me.BTN_Directorio)
        Me.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTrabajo.Location = New System.Drawing.Point(0, 27)
        Me.PanelTrabajo.Name = "PanelTrabajo"
        Me.PanelTrabajo.Size = New System.Drawing.Size(1950, 761)
        Me.PanelTrabajo.TabIndex = 4
        '
        'DGVRESULT
        '
        Me.DGVRESULT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRESULT.Location = New System.Drawing.Point(183, 223)
        Me.DGVRESULT.Name = "DGVRESULT"
        Me.DGVRESULT.Size = New System.Drawing.Size(740, 150)
        Me.DGVRESULT.TabIndex = 20
        Me.DGVRESULT.Visible = False
        '
        'BTN_MODIFICA
        '
        Me.BTN_MODIFICA.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_MODIFICA.BackColor = System.Drawing.Color.DarkRed
        Me.BTN_MODIFICA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MODIFICA.FlatAppearance.BorderSize = 0
        Me.BTN_MODIFICA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_MODIFICA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_MODIFICA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MODIFICA.ForeColor = System.Drawing.Color.White
        Me.BTN_MODIFICA.Location = New System.Drawing.Point(769, 559)
        Me.BTN_MODIFICA.Name = "BTN_MODIFICA"
        Me.BTN_MODIFICA.Size = New System.Drawing.Size(118, 46)
        Me.BTN_MODIFICA.TabIndex = 19
        Me.BTN_MODIFICA.Text = "FUENTE"
        Me.BTN_MODIFICA.UseVisualStyleBackColor = False
        Me.BTN_MODIFICA.Visible = False
        '
        'LBLCUENTA2
        '
        Me.LBLCUENTA2.AutoSize = True
        Me.LBLCUENTA2.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLCUENTA2.Location = New System.Drawing.Point(636, 468)
        Me.LBLCUENTA2.Name = "LBLCUENTA2"
        Me.LBLCUENTA2.Size = New System.Drawing.Size(39, 13)
        Me.LBLCUENTA2.TabIndex = 18
        Me.LBLCUENTA2.Text = "Label2"
        Me.LBLCUENTA2.Visible = False
        '
        'lblcuentas
        '
        Me.lblcuentas.AutoSize = True
        Me.lblcuentas.ForeColor = System.Drawing.Color.DarkGray
        Me.lblcuentas.Location = New System.Drawing.Point(636, 426)
        Me.lblcuentas.Name = "lblcuentas"
        Me.lblcuentas.Size = New System.Drawing.Size(39, 13)
        Me.lblcuentas.TabIndex = 17
        Me.lblcuentas.Text = "Label2"
        Me.lblcuentas.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1824, 695)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VER: 3.7.27"
        '
        'BTN_PASAR
        '
        Me.BTN_PASAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_PASAR.BackColor = System.Drawing.Color.DarkRed
        Me.BTN_PASAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_PASAR.FlatAppearance.BorderSize = 0
        Me.BTN_PASAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_PASAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_PASAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PASAR.ForeColor = System.Drawing.Color.White
        Me.BTN_PASAR.Location = New System.Drawing.Point(345, 568)
        Me.BTN_PASAR.Name = "BTN_PASAR"
        Me.BTN_PASAR.Size = New System.Drawing.Size(118, 46)
        Me.BTN_PASAR.TabIndex = 16
        Me.BTN_PASAR.Text = "GEST"
        Me.BTN_PASAR.UseVisualStyleBackColor = False
        Me.BTN_PASAR.Visible = False
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelInferior.Controls.Add(Me.BTN_DATABASE)
        Me.PanelInferior.Controls.Add(Me.BTN_BUSCADOR)
        Me.PanelInferior.Controls.Add(Me.BTN_OBRAS)
        Me.PanelInferior.Controls.Add(Me.BTN_BOT)
        Me.PanelInferior.Controls.Add(Me.MISTrabajos)
        Me.PanelInferior.Controls.Add(Me.BTN_MISGestiones)
        Me.PanelInferior.Controls.Add(Me.BTN_FTTB)
        Me.PanelInferior.Controls.Add(Me.BTN_Proceso)
        Me.PanelInferior.Controls.Add(Me.BTN_Usuario)
        Me.PanelInferior.Controls.Add(Me.BTN_AGENDA)
        Me.PanelInferior.Controls.Add(Me.BTN_ADMIN)
        Me.PanelInferior.Controls.Add(Me.BTN_FUENTES)
        Me.PanelInferior.Controls.Add(Me.BtnPropiedades)
        Me.PanelInferior.Controls.Add(Me.BTN_DESPACHO)
        Me.PanelInferior.Controls.Add(Me.BTN_RED)
        Me.PanelInferior.Controls.Add(Me.BTN_MDU)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.ForeColor = System.Drawing.Color.White
        Me.PanelInferior.Location = New System.Drawing.Point(0, 721)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(1950, 40)
        Me.PanelInferior.TabIndex = 1
        '
        'BTN_DATABASE
        '
        Me.BTN_DATABASE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_DATABASE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_DATABASE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DATABASE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_DATABASE.FlatAppearance.BorderSize = 0
        Me.BTN_DATABASE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_DATABASE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_DATABASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DATABASE.Location = New System.Drawing.Point(1927, 1)
        Me.BTN_DATABASE.Name = "BTN_DATABASE"
        Me.BTN_DATABASE.Size = New System.Drawing.Size(20, 20)
        Me.BTN_DATABASE.TabIndex = 14
        Me.BTN_DATABASE.UseVisualStyleBackColor = False
        Me.BTN_DATABASE.Visible = False
        '
        'BTN_BUSCADOR
        '
        Me.BTN_BUSCADOR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_BUSCADOR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BUSCADOR.BackgroundImage = CType(resources.GetObject("BTN_BUSCADOR.BackgroundImage"), System.Drawing.Image)
        Me.BTN_BUSCADOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_BUSCADOR.FlatAppearance.BorderSize = 0
        Me.BTN_BUSCADOR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_BUSCADOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_BUSCADOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BUSCADOR.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_BUSCADOR.Location = New System.Drawing.Point(1087, 3)
        Me.BTN_BUSCADOR.Name = "BTN_BUSCADOR"
        Me.BTN_BUSCADOR.Size = New System.Drawing.Size(100, 33)
        Me.BTN_BUSCADOR.TabIndex = 15
        Me.BTN_BUSCADOR.Text = "BUSCADOR"
        Me.BTN_BUSCADOR.UseVisualStyleBackColor = False
        '
        'BTN_OBRAS
        '
        Me.BTN_OBRAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_OBRAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OBRAS.BackgroundImage = CType(resources.GetObject("BTN_OBRAS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_OBRAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_OBRAS.FlatAppearance.BorderSize = 0
        Me.BTN_OBRAS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_OBRAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_OBRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_OBRAS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_OBRAS.Location = New System.Drawing.Point(1187, 3)
        Me.BTN_OBRAS.Name = "BTN_OBRAS"
        Me.BTN_OBRAS.Size = New System.Drawing.Size(100, 33)
        Me.BTN_OBRAS.TabIndex = 2
        Me.BTN_OBRAS.Text = "Buscador"
        Me.BTN_OBRAS.UseVisualStyleBackColor = False
        Me.BTN_OBRAS.Visible = False
        '
        'BTN_BOT
        '
        Me.BTN_BOT.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_BOT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BOT.BackgroundImage = Global.REDES.My.Resources.Resources.bot
        Me.BTN_BOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_BOT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_BOT.FlatAppearance.BorderSize = 0
        Me.BTN_BOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_BOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_BOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BOT.Location = New System.Drawing.Point(1533, 7)
        Me.BTN_BOT.Name = "BTN_BOT"
        Me.BTN_BOT.Size = New System.Drawing.Size(25, 25)
        Me.BTN_BOT.TabIndex = 14
        Me.BTN_BOT.UseVisualStyleBackColor = False
        '
        'MISTrabajos
        '
        Me.MISTrabajos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MISTrabajos.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MISTrabajos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MISTrabajos.FlatAppearance.BorderSize = 0
        Me.MISTrabajos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MISTrabajos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MISTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MISTrabajos.ForeColor = System.Drawing.Color.Silver
        Me.MISTrabajos.Location = New System.Drawing.Point(1153, 7)
        Me.MISTrabajos.Name = "MISTrabajos"
        Me.MISTrabajos.Size = New System.Drawing.Size(59, 30)
        Me.MISTrabajos.TabIndex = 3
        Me.MISTrabajos.Text = "TRAB"
        Me.MISTrabajos.UseVisualStyleBackColor = False
        Me.MISTrabajos.Visible = False
        '
        'BTN_MISGestiones
        '
        Me.BTN_MISGestiones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN_MISGestiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTN_MISGestiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MISGestiones.FlatAppearance.BorderSize = 0
        Me.BTN_MISGestiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_MISGestiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_MISGestiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MISGestiones.ForeColor = System.Drawing.Color.Silver
        Me.BTN_MISGestiones.Location = New System.Drawing.Point(1088, 7)
        Me.BTN_MISGestiones.Name = "BTN_MISGestiones"
        Me.BTN_MISGestiones.Size = New System.Drawing.Size(59, 30)
        Me.BTN_MISGestiones.TabIndex = 2
        Me.BTN_MISGestiones.Text = "GEST"
        Me.BTN_MISGestiones.UseVisualStyleBackColor = False
        Me.BTN_MISGestiones.Visible = False
        '
        'BTN_FTTB
        '
        Me.BTN_FTTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_FTTB.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FTTB.BackgroundImage = CType(resources.GetObject("BTN_FTTB.BackgroundImage"), System.Drawing.Image)
        Me.BTN_FTTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_FTTB.FlatAppearance.BorderSize = 0
        Me.BTN_FTTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_FTTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_FTTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FTTB.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_FTTB.Location = New System.Drawing.Point(887, 3)
        Me.BTN_FTTB.Name = "BTN_FTTB"
        Me.BTN_FTTB.Size = New System.Drawing.Size(100, 33)
        Me.BTN_FTTB.TabIndex = 11
        Me.BTN_FTTB.Text = "FIBRA OPTICA"
        Me.BTN_FTTB.UseVisualStyleBackColor = False
        '
        'BTN_Proceso
        '
        Me.BTN_Proceso.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Proceso.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Proceso.BackgroundImage = Global.REDES.My.Resources.Resources.ProocesosBlack
        Me.BTN_Proceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Proceso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_Proceso.FlatAppearance.BorderSize = 0
        Me.BTN_Proceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_Proceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_Proceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Proceso.Location = New System.Drawing.Point(1597, 7)
        Me.BTN_Proceso.Name = "BTN_Proceso"
        Me.BTN_Proceso.Size = New System.Drawing.Size(25, 25)
        Me.BTN_Proceso.TabIndex = 8
        Me.BTN_Proceso.UseVisualStyleBackColor = False
        '
        'BTN_Usuario
        '
        Me.BTN_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Usuario.BackgroundImage = Global.REDES.My.Resources.Resources.UserBlack
        Me.BTN_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_Usuario.FlatAppearance.BorderSize = 0
        Me.BTN_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Usuario.Location = New System.Drawing.Point(1628, 7)
        Me.BTN_Usuario.Name = "BTN_Usuario"
        Me.BTN_Usuario.Size = New System.Drawing.Size(25, 25)
        Me.BTN_Usuario.TabIndex = 7
        Me.BTN_Usuario.UseVisualStyleBackColor = False
        '
        'BTN_AGENDA
        '
        Me.BTN_AGENDA.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_AGENDA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AGENDA.BackgroundImage = CType(resources.GetObject("BTN_AGENDA.BackgroundImage"), System.Drawing.Image)
        Me.BTN_AGENDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AGENDA.FlatAppearance.BorderSize = 0
        Me.BTN_AGENDA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGENDA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_AGENDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGENDA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_AGENDA.Location = New System.Drawing.Point(304, 3)
        Me.BTN_AGENDA.Name = "BTN_AGENDA"
        Me.BTN_AGENDA.Size = New System.Drawing.Size(100, 33)
        Me.BTN_AGENDA.TabIndex = 6
        Me.BTN_AGENDA.Text = "AGENDA"
        Me.BTN_AGENDA.UseVisualStyleBackColor = False
        '
        'BTN_ADMIN
        '
        Me.BTN_ADMIN.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_ADMIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ADMIN.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_ADMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADMIN.FlatAppearance.BorderSize = 0
        Me.BTN_ADMIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_ADMIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_ADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADMIN.ForeColor = System.Drawing.Color.White
        Me.BTN_ADMIN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_ADMIN.Location = New System.Drawing.Point(487, 3)
        Me.BTN_ADMIN.Name = "BTN_ADMIN"
        Me.BTN_ADMIN.Size = New System.Drawing.Size(100, 33)
        Me.BTN_ADMIN.TabIndex = 12
        Me.BTN_ADMIN.Text = "ADMIN"
        Me.BTN_ADMIN.UseVisualStyleBackColor = False
        '
        'BTN_FUENTES
        '
        Me.BTN_FUENTES.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_FUENTES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FUENTES.BackgroundImage = CType(resources.GetObject("BTN_FUENTES.BackgroundImage"), System.Drawing.Image)
        Me.BTN_FUENTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_FUENTES.FlatAppearance.BorderSize = 0
        Me.BTN_FUENTES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_FUENTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_FUENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FUENTES.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_FUENTES.Location = New System.Drawing.Point(787, 3)
        Me.BTN_FUENTES.Name = "BTN_FUENTES"
        Me.BTN_FUENTES.Size = New System.Drawing.Size(100, 33)
        Me.BTN_FUENTES.TabIndex = 9
        Me.BTN_FUENTES.Text = "FUENTES"
        Me.BTN_FUENTES.UseVisualStyleBackColor = False
        '
        'BtnPropiedades
        '
        Me.BtnPropiedades.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnPropiedades.BackColor = System.Drawing.Color.Transparent
        Me.BtnPropiedades.BackgroundImage = Global.REDES.My.Resources.Resources.SettingBlack
        Me.BtnPropiedades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPropiedades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPropiedades.FlatAppearance.BorderSize = 0
        Me.BtnPropiedades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPropiedades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPropiedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPropiedades.Location = New System.Drawing.Point(1564, 7)
        Me.BtnPropiedades.Name = "BtnPropiedades"
        Me.BtnPropiedades.Size = New System.Drawing.Size(25, 25)
        Me.BtnPropiedades.TabIndex = 4
        Me.BtnPropiedades.UseVisualStyleBackColor = False
        Me.BtnPropiedades.Visible = False
        '
        'BTN_DESPACHO
        '
        Me.BTN_DESPACHO.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_DESPACHO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_DESPACHO.BackgroundImage = CType(resources.GetObject("BTN_DESPACHO.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DESPACHO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DESPACHO.FlatAppearance.BorderSize = 0
        Me.BTN_DESPACHO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_DESPACHO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_DESPACHO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DESPACHO.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_DESPACHO.Location = New System.Drawing.Point(987, 3)
        Me.BTN_DESPACHO.Name = "BTN_DESPACHO"
        Me.BTN_DESPACHO.Size = New System.Drawing.Size(100, 33)
        Me.BTN_DESPACHO.TabIndex = 5
        Me.BTN_DESPACHO.Text = "DESPACHO"
        Me.BTN_DESPACHO.UseVisualStyleBackColor = False
        '
        'BTN_RED
        '
        Me.BTN_RED.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_RED.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RED.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BTN_RED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_RED.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_RED.FlatAppearance.BorderSize = 0
        Me.BTN_RED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_RED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_RED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_RED.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_RED.Location = New System.Drawing.Point(687, 3)
        Me.BTN_RED.Name = "BTN_RED"
        Me.BTN_RED.Size = New System.Drawing.Size(100, 33)
        Me.BTN_RED.TabIndex = 3
        Me.BTN_RED.Text = "RED"
        Me.BTN_RED.UseVisualStyleBackColor = False
        '
        'BTN_MDU
        '
        Me.BTN_MDU.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTN_MDU.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MDU.BackgroundImage = CType(resources.GetObject("BTN_MDU.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MDU.FlatAppearance.BorderSize = 0
        Me.BTN_MDU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_MDU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_MDU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MDU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_MDU.Location = New System.Drawing.Point(587, 3)
        Me.BTN_MDU.Name = "BTN_MDU"
        Me.BTN_MDU.Size = New System.Drawing.Size(100, 33)
        Me.BTN_MDU.TabIndex = 4
        Me.BTN_MDU.Text = "MDU"
        Me.BTN_MDU.UseVisualStyleBackColor = False
        '
        'BTN_Directorio
        '
        Me.BTN_Directorio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_Directorio.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Directorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_Directorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_Directorio.FlatAppearance.BorderSize = 0
        Me.BTN_Directorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_Directorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_Directorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Directorio.Location = New System.Drawing.Point(1913, 619)
        Me.BTN_Directorio.Name = "BTN_Directorio"
        Me.BTN_Directorio.Size = New System.Drawing.Size(36, 25)
        Me.BTN_Directorio.TabIndex = 13
        Me.BTN_Directorio.Text = "xd"
        Me.BTN_Directorio.UseVisualStyleBackColor = False
        Me.BTN_Directorio.Visible = False
        '
        'RELOJ
        '
        Me.RELOJ.Interval = 3600000
        '
        'OpenFileDialogINGRESO
        '
        Me.OpenFileDialogINGRESO.FileName = "OpenFileDialog1"
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Transparent
        Me.PanelSuperior.Controls.Add(Me.PanelSUPInterior)
        Me.PanelSuperior.Controls.Add(Me.BTN_HAND)
        Me.PanelSuperior.Controls.Add(Me.PIC_CLIMA)
        Me.PanelSuperior.Controls.Add(Me.LBL_TEMP)
        Me.PanelSuperior.Controls.Add(Me.BtnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.BtnFull)
        Me.PanelSuperior.Controls.Add(Me.BtnCerrar)
        Me.PanelSuperior.Controls.Add(Me.FechaAhora)
        Me.PanelSuperior.Controls.Add(Me.HoraAhora)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1950, 27)
        Me.PanelSuperior.TabIndex = 3
        '
        'PanelSUPInterior
        '
        Me.PanelSUPInterior.BackColor = System.Drawing.Color.Transparent
        Me.PanelSUPInterior.Controls.Add(Me.BTNCerrarAsignado)
        Me.PanelSUPInterior.Controls.Add(Me.BTNCerrarMensajes)
        Me.PanelSUPInterior.Controls.Add(Me.BTN8Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN8)
        Me.PanelSUPInterior.Controls.Add(Me.BTN7Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN7)
        Me.PanelSUPInterior.Controls.Add(Me.BTN6Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN5Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN4Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN6)
        Me.PanelSUPInterior.Controls.Add(Me.BTN5)
        Me.PanelSUPInterior.Controls.Add(Me.BTN4)
        Me.PanelSUPInterior.Controls.Add(Me.BTN3Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN2Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTN1Close)
        Me.PanelSUPInterior.Controls.Add(Me.BTNMensajeria)
        Me.PanelSUPInterior.Controls.Add(Me.BTNAsignado)
        Me.PanelSUPInterior.Controls.Add(Me.BTN3)
        Me.PanelSUPInterior.Controls.Add(Me.BTN2)
        Me.PanelSUPInterior.Controls.Add(Me.BTN1)
        Me.PanelSUPInterior.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSUPInterior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSUPInterior.Name = "PanelSUPInterior"
        Me.PanelSUPInterior.Size = New System.Drawing.Size(1004, 27)
        Me.PanelSUPInterior.TabIndex = 11
        '
        'BTNCerrarAsignado
        '
        Me.BTNCerrarAsignado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTNCerrarAsignado.BackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarAsignado.BackgroundImage = Global.REDES.My.Resources.Resources.BTNCancelarBlanco
        Me.BTNCerrarAsignado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCerrarAsignado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTNCerrarAsignado.FlatAppearance.BorderSize = 0
        Me.BTNCerrarAsignado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarAsignado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarAsignado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCerrarAsignado.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCerrarAsignado.ForeColor = System.Drawing.Color.White
        Me.BTNCerrarAsignado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCerrarAsignado.Location = New System.Drawing.Point(126, 0)
        Me.BTNCerrarAsignado.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNCerrarAsignado.Name = "BTNCerrarAsignado"
        Me.BTNCerrarAsignado.Size = New System.Drawing.Size(10, 10)
        Me.BTNCerrarAsignado.TabIndex = 21
        Me.BTNCerrarAsignado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCerrarAsignado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTNCerrarAsignado.UseVisualStyleBackColor = False
        Me.BTNCerrarAsignado.Visible = False
        '
        'BTNCerrarMensajes
        '
        Me.BTNCerrarMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTNCerrarMensajes.BackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarMensajes.BackgroundImage = Global.REDES.My.Resources.Resources.BTNCancelarBlanco
        Me.BTNCerrarMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCerrarMensajes.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTNCerrarMensajes.FlatAppearance.BorderSize = 0
        Me.BTNCerrarMensajes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarMensajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarMensajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNCerrarMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCerrarMensajes.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCerrarMensajes.ForeColor = System.Drawing.Color.White
        Me.BTNCerrarMensajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCerrarMensajes.Location = New System.Drawing.Point(57, 0)
        Me.BTNCerrarMensajes.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNCerrarMensajes.Name = "BTNCerrarMensajes"
        Me.BTNCerrarMensajes.Size = New System.Drawing.Size(10, 10)
        Me.BTNCerrarMensajes.TabIndex = 20
        Me.BTNCerrarMensajes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCerrarMensajes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTNCerrarMensajes.UseVisualStyleBackColor = False
        Me.BTNCerrarMensajes.Visible = False
        '
        'BTN8Close
        '
        Me.BTN8Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN8Close.BackColor = System.Drawing.Color.Black
        Me.BTN8Close.BackgroundImage = CType(resources.GetObject("BTN8Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN8Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN8Close.FlatAppearance.BorderSize = 0
        Me.BTN8Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN8Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN8Close.ForeColor = System.Drawing.Color.White
        Me.BTN8Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN8Close.Location = New System.Drawing.Point(846, 3)
        Me.BTN8Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN8Close.Name = "BTN8Close"
        Me.BTN8Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN8Close.TabIndex = 19
        Me.BTN8Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN8Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN8Close.UseVisualStyleBackColor = False
        Me.BTN8Close.Visible = False
        '
        'BTN8
        '
        Me.BTN8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN8.BackColor = System.Drawing.Color.Transparent
        Me.BTN8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN8.FlatAppearance.BorderSize = 0
        Me.BTN8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN8.ForeColor = System.Drawing.Color.White
        Me.BTN8.Location = New System.Drawing.Point(781, 1)
        Me.BTN8.Name = "BTN8"
        Me.BTN8.Size = New System.Drawing.Size(80, 25)
        Me.BTN8.TabIndex = 18
        Me.BTN8.Text = "Button8"
        Me.BTN8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN8.UseVisualStyleBackColor = False
        Me.BTN8.Visible = False
        '
        'BTN7Close
        '
        Me.BTN7Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN7Close.BackColor = System.Drawing.Color.Black
        Me.BTN7Close.BackgroundImage = CType(resources.GetObject("BTN7Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN7Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN7Close.FlatAppearance.BorderSize = 0
        Me.BTN7Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN7Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN7Close.ForeColor = System.Drawing.Color.White
        Me.BTN7Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN7Close.Location = New System.Drawing.Point(765, 3)
        Me.BTN7Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN7Close.Name = "BTN7Close"
        Me.BTN7Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN7Close.TabIndex = 17
        Me.BTN7Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN7Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN7Close.UseVisualStyleBackColor = False
        Me.BTN7Close.Visible = False
        '
        'BTN7
        '
        Me.BTN7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN7.BackColor = System.Drawing.Color.Transparent
        Me.BTN7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN7.FlatAppearance.BorderSize = 0
        Me.BTN7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN7.ForeColor = System.Drawing.Color.White
        Me.BTN7.Location = New System.Drawing.Point(700, 1)
        Me.BTN7.Name = "BTN7"
        Me.BTN7.Size = New System.Drawing.Size(80, 25)
        Me.BTN7.TabIndex = 16
        Me.BTN7.Text = "Button7"
        Me.BTN7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN7.UseVisualStyleBackColor = False
        Me.BTN7.Visible = False
        '
        'BTN6Close
        '
        Me.BTN6Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN6Close.BackColor = System.Drawing.Color.Black
        Me.BTN6Close.BackgroundImage = CType(resources.GetObject("BTN6Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN6Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN6Close.FlatAppearance.BorderSize = 0
        Me.BTN6Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN6Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN6Close.ForeColor = System.Drawing.Color.White
        Me.BTN6Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN6Close.Location = New System.Drawing.Point(684, 3)
        Me.BTN6Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN6Close.Name = "BTN6Close"
        Me.BTN6Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN6Close.TabIndex = 15
        Me.BTN6Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN6Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN6Close.UseVisualStyleBackColor = False
        Me.BTN6Close.Visible = False
        '
        'BTN5Close
        '
        Me.BTN5Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN5Close.BackColor = System.Drawing.Color.Black
        Me.BTN5Close.BackgroundImage = CType(resources.GetObject("BTN5Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN5Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN5Close.FlatAppearance.BorderSize = 0
        Me.BTN5Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN5Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN5Close.ForeColor = System.Drawing.Color.White
        Me.BTN5Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN5Close.Location = New System.Drawing.Point(603, 3)
        Me.BTN5Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN5Close.Name = "BTN5Close"
        Me.BTN5Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN5Close.TabIndex = 14
        Me.BTN5Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN5Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN5Close.UseVisualStyleBackColor = False
        Me.BTN5Close.Visible = False
        '
        'BTN4Close
        '
        Me.BTN4Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN4Close.BackColor = System.Drawing.Color.Black
        Me.BTN4Close.BackgroundImage = CType(resources.GetObject("BTN4Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN4Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN4Close.FlatAppearance.BorderSize = 0
        Me.BTN4Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN4Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN4Close.ForeColor = System.Drawing.Color.White
        Me.BTN4Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN4Close.Location = New System.Drawing.Point(522, 3)
        Me.BTN4Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN4Close.Name = "BTN4Close"
        Me.BTN4Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN4Close.TabIndex = 13
        Me.BTN4Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN4Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN4Close.UseVisualStyleBackColor = False
        Me.BTN4Close.Visible = False
        '
        'BTN6
        '
        Me.BTN6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN6.BackColor = System.Drawing.Color.Transparent
        Me.BTN6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN6.FlatAppearance.BorderSize = 0
        Me.BTN6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN6.ForeColor = System.Drawing.Color.White
        Me.BTN6.Location = New System.Drawing.Point(619, 1)
        Me.BTN6.Name = "BTN6"
        Me.BTN6.Size = New System.Drawing.Size(80, 25)
        Me.BTN6.TabIndex = 12
        Me.BTN6.Text = "Button6"
        Me.BTN6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN6.UseVisualStyleBackColor = False
        Me.BTN6.Visible = False
        '
        'BTN5
        '
        Me.BTN5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN5.BackColor = System.Drawing.Color.Transparent
        Me.BTN5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN5.FlatAppearance.BorderSize = 0
        Me.BTN5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN5.ForeColor = System.Drawing.Color.White
        Me.BTN5.Location = New System.Drawing.Point(538, 1)
        Me.BTN5.Name = "BTN5"
        Me.BTN5.Size = New System.Drawing.Size(80, 25)
        Me.BTN5.TabIndex = 11
        Me.BTN5.Text = "Button5"
        Me.BTN5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN5.UseVisualStyleBackColor = False
        Me.BTN5.Visible = False
        '
        'BTN4
        '
        Me.BTN4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN4.BackColor = System.Drawing.Color.Transparent
        Me.BTN4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN4.FlatAppearance.BorderSize = 0
        Me.BTN4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN4.ForeColor = System.Drawing.Color.White
        Me.BTN4.Location = New System.Drawing.Point(457, 1)
        Me.BTN4.Name = "BTN4"
        Me.BTN4.Size = New System.Drawing.Size(80, 25)
        Me.BTN4.TabIndex = 10
        Me.BTN4.Text = "Button4"
        Me.BTN4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN4.UseVisualStyleBackColor = False
        Me.BTN4.Visible = False
        '
        'BTN3Close
        '
        Me.BTN3Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN3Close.BackColor = System.Drawing.Color.Black
        Me.BTN3Close.BackgroundImage = CType(resources.GetObject("BTN3Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN3Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN3Close.FlatAppearance.BorderSize = 0
        Me.BTN3Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN3Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN3Close.ForeColor = System.Drawing.Color.White
        Me.BTN3Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN3Close.Location = New System.Drawing.Point(441, 4)
        Me.BTN3Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN3Close.Name = "BTN3Close"
        Me.BTN3Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN3Close.TabIndex = 9
        Me.BTN3Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN3Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN3Close.UseVisualStyleBackColor = False
        Me.BTN3Close.Visible = False
        '
        'BTN2Close
        '
        Me.BTN2Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN2Close.BackColor = System.Drawing.Color.Black
        Me.BTN2Close.BackgroundImage = CType(resources.GetObject("BTN2Close.BackgroundImage"), System.Drawing.Image)
        Me.BTN2Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN2Close.FlatAppearance.BorderSize = 0
        Me.BTN2Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN2Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN2Close.ForeColor = System.Drawing.Color.White
        Me.BTN2Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN2Close.Location = New System.Drawing.Point(360, 4)
        Me.BTN2Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN2Close.Name = "BTN2Close"
        Me.BTN2Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN2Close.TabIndex = 8
        Me.BTN2Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN2Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN2Close.UseVisualStyleBackColor = False
        Me.BTN2Close.Visible = False
        '
        'BTN1Close
        '
        Me.BTN1Close.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN1Close.BackColor = System.Drawing.Color.Black
        Me.BTN1Close.BackgroundImage = Global.REDES.My.Resources.Resources.BTNCancelarBlanco
        Me.BTN1Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN1Close.FlatAppearance.BorderSize = 0
        Me.BTN1Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN1Close.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN1Close.ForeColor = System.Drawing.Color.White
        Me.BTN1Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN1Close.Location = New System.Drawing.Point(279, 4)
        Me.BTN1Close.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN1Close.Name = "BTN1Close"
        Me.BTN1Close.Size = New System.Drawing.Size(10, 10)
        Me.BTN1Close.TabIndex = 7
        Me.BTN1Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN1Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN1Close.UseVisualStyleBackColor = False
        Me.BTN1Close.Visible = False
        '
        'BTNMensajeria
        '
        Me.BTNMensajeria.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTNMensajeria.BackgroundImage = Global.REDES.My.Resources.Resources.correo_electronico_vacio
        Me.BTNMensajeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNMensajeria.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTNMensajeria.FlatAppearance.BorderSize = 0
        Me.BTNMensajeria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNMensajeria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNMensajeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNMensajeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMensajeria.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMensajeria.ForeColor = System.Drawing.Color.White
        Me.BTNMensajeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMensajeria.Location = New System.Drawing.Point(12, 0)
        Me.BTNMensajeria.Name = "BTNMensajeria"
        Me.BTNMensajeria.Size = New System.Drawing.Size(55, 26)
        Me.BTNMensajeria.TabIndex = 1
        Me.BTNMensajeria.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BTNMensajeria.UseVisualStyleBackColor = True
        '
        'BTNAsignado
        '
        Me.BTNAsignado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTNAsignado.BackgroundImage = Global.REDES.My.Resources.Resources.BTNAsignado
        Me.BTNAsignado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNAsignado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTNAsignado.FlatAppearance.BorderSize = 0
        Me.BTNAsignado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNAsignado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNAsignado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAsignado.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAsignado.ForeColor = System.Drawing.Color.White
        Me.BTNAsignado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAsignado.Location = New System.Drawing.Point(81, 0)
        Me.BTNAsignado.Name = "BTNAsignado"
        Me.BTNAsignado.Size = New System.Drawing.Size(55, 26)
        Me.BTNAsignado.TabIndex = 2
        Me.BTNAsignado.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BTNAsignado.UseVisualStyleBackColor = True
        '
        'BTN3
        '
        Me.BTN3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN3.BackColor = System.Drawing.Color.Transparent
        Me.BTN3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN3.FlatAppearance.BorderSize = 0
        Me.BTN3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN3.ForeColor = System.Drawing.Color.White
        Me.BTN3.Location = New System.Drawing.Point(376, 1)
        Me.BTN3.Name = "BTN3"
        Me.BTN3.Size = New System.Drawing.Size(80, 25)
        Me.BTN3.TabIndex = 6
        Me.BTN3.Text = "Button3"
        Me.BTN3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN3.UseVisualStyleBackColor = False
        Me.BTN3.Visible = False
        '
        'BTN2
        '
        Me.BTN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN2.BackColor = System.Drawing.Color.Transparent
        Me.BTN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN2.FlatAppearance.BorderSize = 0
        Me.BTN2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN2.ForeColor = System.Drawing.Color.White
        Me.BTN2.Location = New System.Drawing.Point(295, 1)
        Me.BTN2.Name = "BTN2"
        Me.BTN2.Size = New System.Drawing.Size(80, 25)
        Me.BTN2.TabIndex = 5
        Me.BTN2.Text = "Button2"
        Me.BTN2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN2.UseVisualStyleBackColor = False
        Me.BTN2.Visible = False
        '
        'BTN1
        '
        Me.BTN1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN1.BackColor = System.Drawing.Color.Transparent
        Me.BTN1.BackgroundImage = Global.REDES.My.Resources.Resources.BTNSuperior
        Me.BTN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN1.FlatAppearance.BorderSize = 0
        Me.BTN1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN1.ForeColor = System.Drawing.Color.White
        Me.BTN1.Location = New System.Drawing.Point(214, 1)
        Me.BTN1.Name = "BTN1"
        Me.BTN1.Size = New System.Drawing.Size(80, 25)
        Me.BTN1.TabIndex = 4
        Me.BTN1.Text = "Button1"
        Me.BTN1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN1.UseVisualStyleBackColor = False
        Me.BTN1.Visible = False
        '
        'BTN_HAND
        '
        Me.BTN_HAND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_HAND.BackColor = System.Drawing.Color.Transparent
        Me.BTN_HAND.BackgroundImage = Global.REDES.My.Resources.Resources.TAP_W
        Me.BTN_HAND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_HAND.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_HAND.FlatAppearance.BorderSize = 0
        Me.BTN_HAND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTN_HAND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTN_HAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_HAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_HAND.ForeColor = System.Drawing.Color.White
        Me.BTN_HAND.Location = New System.Drawing.Point(1827, 2)
        Me.BTN_HAND.Name = "BTN_HAND"
        Me.BTN_HAND.Size = New System.Drawing.Size(23, 23)
        Me.BTN_HAND.TabIndex = 15
        Me.BTN_HAND.UseVisualStyleBackColor = False
        Me.BTN_HAND.Visible = False
        '
        'PIC_CLIMA
        '
        Me.PIC_CLIMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PIC_CLIMA.Location = New System.Drawing.Point(1010, 2)
        Me.PIC_CLIMA.Name = "PIC_CLIMA"
        Me.PIC_CLIMA.Size = New System.Drawing.Size(59, 22)
        Me.PIC_CLIMA.TabIndex = 14
        Me.PIC_CLIMA.TabStop = False
        '
        'LBL_TEMP
        '
        Me.LBL_TEMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_TEMP.AutoSize = True
        Me.LBL_TEMP.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TEMP.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TEMP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LBL_TEMP.Location = New System.Drawing.Point(1543, 4)
        Me.LBL_TEMP.Name = "LBL_TEMP"
        Me.LBL_TEMP.Size = New System.Drawing.Size(0, 17)
        Me.LBL_TEMP.TabIndex = 13
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.BackgroundImage = Global.REDES.My.Resources.Resources.menos_W
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.ForeColor = System.Drawing.Color.White
        Me.BtnMinimizar.Location = New System.Drawing.Point(1860, 2)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(23, 23)
        Me.BtnMinimizar.TabIndex = 8
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnFull
        '
        Me.BtnFull.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFull.BackColor = System.Drawing.Color.Transparent
        Me.BtnFull.BackgroundImage = Global.REDES.My.Resources.Resources.PantallaCompleta_W
        Me.BtnFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnFull.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnFull.FlatAppearance.BorderSize = 0
        Me.BtnFull.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnFull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFull.ForeColor = System.Drawing.Color.White
        Me.BtnFull.Location = New System.Drawing.Point(1890, 2)
        Me.BtnFull.Name = "BtnFull"
        Me.BtnFull.Size = New System.Drawing.Size(23, 23)
        Me.BtnFull.TabIndex = 7
        Me.BtnFull.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.BackgroundImage = Global.REDES.My.Resources.Resources.logout_W
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(1921, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'FechaAhora
        '
        Me.FechaAhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaAhora.AutoSize = True
        Me.FechaAhora.BackColor = System.Drawing.Color.Transparent
        Me.FechaAhora.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAhora.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FechaAhora.Location = New System.Drawing.Point(1764, 4)
        Me.FechaAhora.Name = "FechaAhora"
        Me.FechaAhora.Size = New System.Drawing.Size(17, 17)
        Me.FechaAhora.TabIndex = 6
        Me.FechaAhora.Text = "*"
        '
        'HoraAhora
        '
        Me.HoraAhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HoraAhora.AutoSize = True
        Me.HoraAhora.BackColor = System.Drawing.Color.Transparent
        Me.HoraAhora.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraAhora.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.HoraAhora.Location = New System.Drawing.Point(1699, 4)
        Me.HoraAhora.Name = "HoraAhora"
        Me.HoraAhora.Size = New System.Drawing.Size(17, 17)
        Me.HoraAhora.TabIndex = 5
        Me.HoraAhora.Text = "*"
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        '
        'OPERACIONES_LOGDataSet
        '
        Me.OPERACIONES_LOGDataSet.DataSetName = "OPERACIONES_LOGDataSet"
        Me.OPERACIONES_LOGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'INDICESDataSet
        '
        Me.INDICESDataSet.DataSetName = "INDICESDataSet"
        Me.INDICESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIMABindingSource
        '
        Me.CLIMABindingSource.DataMember = "CLIMA"
        Me.CLIMABindingSource.DataSource = Me.INDICESDataSet
        '
        'CLIMATableAdapter
        '
        Me.CLIMATableAdapter.ClearBeforeFill = True
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MENSAJERIATableAdapter
        '
        Me.MENSAJERIATableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'HISTORICOTableAdapter
        '
        Me.HISTORICOTableAdapter.ClearBeforeFill = True
        '
        'OrdenesDataSet1
        '
        Me.OrdenesDataSet1.DataSetName = "ORDENESDataSet"
        Me.OrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MENSAJERIABindingSource
        '
        Me.MENSAJERIABindingSource.DataMember = "MENSAJERIA"
        Me.MENSAJERIABindingSource.DataSource = Me.ORDENESDataSet
        '
        'TRABAJOSBindingSource
        '
        Me.TRABAJOSBindingSource.DataMember = "TRABAJOS"
        Me.TRABAJOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'HISTORICOBindingSource
        '
        Me.HISTORICOBindingSource.DataMember = "HISTORICO"
        Me.HISTORICOBindingSource.DataSource = Me.ORDENESDataSet
        '
        'BASEFUENTESDataSet
        '
        Me.BASEFUENTESDataSet.DataSetName = "BASEFUENTESDataSet"
        Me.BASEFUENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FUENTEBindingSource
        '
        Me.FUENTEBindingSource.DataMember = "FUENTE"
        Me.FUENTEBindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'FUENTETableAdapter
        '
        Me.FUENTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FECHA_BATERIATableAdapter = Me.FECHA_BATERIATableAdapter
        Me.TableAdapterManager.FUENTETableAdapter = Me.FUENTETableAdapter
        Me.TableAdapterManager.INDICE_CALLESTableAdapter = Nothing
        Me.TableAdapterManager.INSTALACIONTableAdapter = Nothing
        Me.TableAdapterManager.NRONODOSTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_BATERIATableAdapter = Me.TIPO_BATERIATableAdapter
        Me.TableAdapterManager.TIPO_FUENTETableAdapter = Me.TIPO_FUENTETableAdapter
        Me.TableAdapterManager.UpdateOrder = REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FECHA_BATERIATableAdapter
        '
        Me.FECHA_BATERIATableAdapter.ClearBeforeFill = True
        '
        'TIPO_BATERIATableAdapter
        '
        Me.TIPO_BATERIATableAdapter.ClearBeforeFill = True
        '
        'TIPO_FUENTETableAdapter
        '
        Me.TIPO_FUENTETableAdapter.ClearBeforeFill = True
        '
        'TIPO_BATERIABindingSource
        '
        Me.TIPO_BATERIABindingSource.DataMember = "TIPO_BATERIA"
        Me.TIPO_BATERIABindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'TIPO_FUENTEBindingSource
        '
        Me.TIPO_FUENTEBindingSource.DataMember = "TIPO_FUENTE"
        Me.TIPO_FUENTEBindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'FECHA_BATERIABindingSource
        '
        Me.FECHA_BATERIABindingSource.DataMember = "FECHA_BATERIA"
        Me.FECHA_BATERIABindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'INDICE_CALLESBindingSource1
        '
        Me.INDICE_CALLESBindingSource1.DataMember = "INDICE_CALLES"
        Me.INDICE_CALLESBindingSource1.DataSource = Me.BASEFUENTESDataSet
        '
        'INDICE_CALLESTableAdapter
        '
        Me.INDICE_CALLESTableAdapter.ClearBeforeFill = True
        '
        'EDIFICIODataSet
        '
        Me.EDIFICIODataSet.DataSetName = "EDIFICIODataSet"
        Me.EDIFICIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FTTBTableAdapter
        '
        Me.FTTBTableAdapter.ClearBeforeFill = True
        '
        'FTTBBindingSource
        '
        Me.FTTBBindingSource.DataMember = "FTTB"
        Me.FTTBBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'MDUBindingSource
        '
        Me.MDUBindingSource.DataMember = "MDU"
        Me.MDUBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
        '
        'DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1950, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelTrabajo)
        Me.Controls.Add(Me.PanelSuperior)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "DASHBOARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SGE"
        Me.PanelTrabajo.ResumeLayout(False)
        Me.PanelTrabajo.PerformLayout()
        CType(Me.DGVRESULT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelSUPInterior.ResumeLayout(False)
        CType(Me.PIC_CLIMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENSAJERIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_BATERIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_FUENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_BATERIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICE_CALLESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_DESPACHO As Button
    Friend WithEvents BTN_OBRAS As Button
    Friend WithEvents BTN_RED As Button
    Friend WithEvents BTNCerrarAsignado As Button
    Friend WithEvents BTNCerrarMensajes As Button
    Friend WithEvents BTN8Close As Button
    Friend WithEvents BTN8 As Button
    Friend WithEvents BTN_ADMIN As Button
    Friend WithEvents BTN_FUENTES As Button
    Friend WithEvents BTN7Close As Button
    Friend WithEvents BTN7 As Button
    Friend WithEvents BTN6Close As Button
    Friend WithEvents BTN5Close As Button
    Friend WithEvents BTN4Close As Button
    Friend WithEvents BTN6 As Button
    Friend WithEvents BTN_Proceso As Button
    Friend WithEvents BTN_AGENDA As Button
    Friend WithEvents BtnPropiedades As Button
    Friend WithEvents BTN5 As Button
    Friend WithEvents BTN4 As Button
    Friend WithEvents BTN3Close As Button
    Friend WithEvents BTN1Close As Button
    Friend WithEvents BTNMensajeria As Button
    Friend WithEvents BTNAsignado As Button
    Friend WithEvents BTN3 As Button
    Friend WithEvents BTN_Usuario As Button
    Friend WithEvents BTN_MDU As Button
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents BTN2Close As Button
    Friend WithEvents BTN2 As Button
    Friend WithEvents BTN_Directorio As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents BTN_FTTB As Button
    Friend WithEvents PanelTrabajo As Panel
    Friend WithEvents RELOJ As Timer
    Friend WithEvents FechaAhora As Label
    Friend WithEvents HoraAhora As Label
    Friend WithEvents BTN1 As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnFull As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelSUPInterior As Panel
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents OPERACIONES_LOGDataSet As OPERACIONES_LOGDataSet
    Friend WithEvents USUARIOSTableAdapter As OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents MENSAJERIABindingSource As BindingSource
    Friend WithEvents MENSAJERIATableAdapter As ORDENESDataSetTableAdapters.MENSAJERIATableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents MISTrabajos As Button
    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents CLIMABindingSource As BindingSource
    Friend WithEvents CLIMATableAdapter As INDICESDataSetTableAdapters.CLIMATableAdapter
    Friend WithEvents LBL_TEMP As Label
    Friend WithEvents BTN_MISGestiones As Button
    Friend WithEvents FolderBrowserDialogINGRESO As FolderBrowserDialog
    Friend WithEvents OpenFileDialogINGRESO As OpenFileDialog
    Friend WithEvents BTN_BOT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_BUSCADOR As Button
    Friend WithEvents BTN_DATABASE As Button
    Friend WithEvents PIC_CLIMA As PictureBox
    Friend WithEvents BTN_HAND As Button
    Friend WithEvents BTN_PASAR As Button
    Friend WithEvents EDIFICIODataSet As EDIFICIODataSet
    Friend WithEvents FTTBBindingSource As BindingSource
    Friend WithEvents FTTBTableAdapter As EDIFICIODataSetTableAdapters.FTTBTableAdapter
    Friend WithEvents MDUBindingSource As BindingSource
    Friend WithEvents lblcuentas As Label
    Friend WithEvents HISTORICOBindingSource As BindingSource
    Friend WithEvents HISTORICOTableAdapter As ORDENESDataSetTableAdapters.HISTORICOTableAdapter
    Friend WithEvents OrdenesDataSet1 As ORDENESDataSet
    Friend WithEvents LBLCUENTA2 As Label
    Friend WithEvents BTN_MODIFICA As Button
    Friend WithEvents DGVRESULT As DataGridView
    Friend WithEvents MDUTableAdapter As EDIFICIODataSetTableAdapters.MDUTableAdapter
    '  Friend WithEvents INDICE_CALLESTableAdapter As BD_FUENTESDataSetTableAdapters.INDICE_CALLESTableAdapter
    Friend WithEvents INDICE_CALLESBindingSource As BindingSource
    Friend WithEvents BASEFUENTESDataSet As BASEFUENTESDataSet
    Friend WithEvents FUENTEBindingSource As BindingSource
    Friend WithEvents FUENTETableAdapter As BASEFUENTESDataSetTableAdapters.FUENTETableAdapter
    Friend WithEvents TableAdapterManager As BASEFUENTESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_BATERIATableAdapter As BASEFUENTESDataSetTableAdapters.TIPO_BATERIATableAdapter
    Friend WithEvents TIPO_BATERIABindingSource As BindingSource
    Friend WithEvents TIPO_FUENTETableAdapter As BASEFUENTESDataSetTableAdapters.TIPO_FUENTETableAdapter
    Friend WithEvents TIPO_FUENTEBindingSource As BindingSource
    Friend WithEvents FECHA_BATERIATableAdapter As BASEFUENTESDataSetTableAdapters.FECHA_BATERIATableAdapter
    Friend WithEvents FECHA_BATERIABindingSource As BindingSource
    Friend WithEvents INDICE_CALLESBindingSource1 As BindingSource
    Friend WithEvents INDICE_CALLESTableAdapter As BASEFUENTESDataSetTableAdapters.INDICE_CALLESTableAdapter
End Class
