<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class STANDARD_MATERIALES
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
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TXT_CANTCABLEADOINT = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TXT_MTSCABLES_ACOMETIDA = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GrupoActivo = New System.Windows.Forms.GroupBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TipoAMP = New System.Windows.Forms.ComboBox()
        Me.GrupoCables = New System.Windows.Forms.GroupBox()
        Me.GroupPASIVOS = New System.Windows.Forms.GroupBox()
        Me.DISP_9 = New System.Windows.Forms.TextBox()
        Me.DISP_8 = New System.Windows.Forms.TextBox()
        Me.DISP_7 = New System.Windows.Forms.TextBox()
        Me.DISP_6 = New System.Windows.Forms.TextBox()
        Me.DISP_5 = New System.Windows.Forms.TextBox()
        Me.DISP_4 = New System.Windows.Forms.TextBox()
        Me.DISP_3 = New System.Windows.Forms.TextBox()
        Me.DISP_2 = New System.Windows.Forms.TextBox()
        Me.DISP_1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_QUITAR = New System.Windows.Forms.Button()
        Me.COD_9 = New System.Windows.Forms.TextBox()
        Me.CANT_9 = New System.Windows.Forms.TextBox()
        Me.COD_ART_9 = New System.Windows.Forms.ComboBox()
        Me.COD_8 = New System.Windows.Forms.TextBox()
        Me.CANT_8 = New System.Windows.Forms.TextBox()
        Me.COD_ART_8 = New System.Windows.Forms.ComboBox()
        Me.COD_7 = New System.Windows.Forms.TextBox()
        Me.CANT_7 = New System.Windows.Forms.TextBox()
        Me.COD_ART_7 = New System.Windows.Forms.ComboBox()
        Me.COD_6 = New System.Windows.Forms.TextBox()
        Me.CANT_6 = New System.Windows.Forms.TextBox()
        Me.COD_ART_6 = New System.Windows.Forms.ComboBox()
        Me.COD_5 = New System.Windows.Forms.TextBox()
        Me.CANT_5 = New System.Windows.Forms.TextBox()
        Me.COD_ART_5 = New System.Windows.Forms.ComboBox()
        Me.COD_4 = New System.Windows.Forms.TextBox()
        Me.CANT_4 = New System.Windows.Forms.TextBox()
        Me.COD_ART_4 = New System.Windows.Forms.ComboBox()
        Me.COD_3 = New System.Windows.Forms.TextBox()
        Me.CANT_3 = New System.Windows.Forms.TextBox()
        Me.COD_ART_3 = New System.Windows.Forms.ComboBox()
        Me.COD_2 = New System.Windows.Forms.TextBox()
        Me.CANT_2 = New System.Windows.Forms.TextBox()
        Me.COD_ART_2 = New System.Windows.Forms.ComboBox()
        Me.COD_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CANT_1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.COD_ART_1 = New System.Windows.Forms.ComboBox()
        Me.BTN_INGRESAR = New System.Windows.Forms.Button()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.INDICESDataSet = New REDES.INDICESDataSet()
        Me.MAT_ACTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_ACTIVOSTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_ACTIVOSTableAdapter()
        Me.TableAdapterManager = New REDES.INDICESDataSetTableAdapters.TableAdapterManager()
        Me.MAT_STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAT_STOCKTableAdapter = New REDES.INDICESDataSetTableAdapters.MAT_STOCKTableAdapter()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.PRESUPUESTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESUPUESTOTableAdapter = New REDES.ORDENESDataSetTableAdapters.PRESUPUESTOTableAdapter()
        Me.TableAdapterManager1 = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.GrupoActivo.SuspendLayout()
        Me.GrupoCables.SuspendLayout()
        Me.GroupPASIVOS.SuspendLayout()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_ACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAT_STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESUPUESTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(292, 10)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_AGREGAR.TabIndex = 0
        Me.BTN_AGREGAR.Text = "AGREGAR"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(212, 15)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(90, 13)
        Me.Label49.TabIndex = 65
        Me.Label49.Text = "Cableado interno:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"RG11", ".540", "RG6"})
        Me.ComboBox2.Location = New System.Drawing.Point(215, 31)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox2.TabIndex = 64
        Me.ComboBox2.Text = "RG6"
        '
        'TXT_CANTCABLEADOINT
        '
        Me.TXT_CANTCABLEADOINT.Location = New System.Drawing.Point(215, 53)
        Me.TXT_CANTCABLEADOINT.Name = "TXT_CANTCABLEADOINT"
        Me.TXT_CANTCABLEADOINT.Size = New System.Drawing.Size(61, 20)
        Me.TXT_CANTCABLEADOINT.TabIndex = 61
        Me.TXT_CANTCABLEADOINT.Text = "0"
        Me.TXT_CANTCABLEADOINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(112, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Acometida"
        '
        'TXT_MTSCABLES_ACOMETIDA
        '
        Me.TXT_MTSCABLES_ACOMETIDA.Location = New System.Drawing.Point(105, 53)
        Me.TXT_MTSCABLES_ACOMETIDA.Name = "TXT_MTSCABLES_ACOMETIDA"
        Me.TXT_MTSCABLES_ACOMETIDA.Size = New System.Drawing.Size(64, 20)
        Me.TXT_MTSCABLES_ACOMETIDA.TabIndex = 69
        Me.TXT_MTSCABLES_ACOMETIDA.Text = "0"
        Me.TXT_MTSCABLES_ACOMETIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(2, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Metros de cable"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "TIPO de cable"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RG11", ".540", "RG6"})
        Me.ComboBox1.Location = New System.Drawing.Point(105, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 72
        Me.ComboBox1.Text = "RG11"
        '
        'GrupoActivo
        '
        Me.GrupoActivo.BackColor = System.Drawing.Color.White
        Me.GrupoActivo.Controls.Add(Me.Label52)
        Me.GrupoActivo.Controls.Add(Me.Label53)
        Me.GrupoActivo.Controls.Add(Me.ComboBox3)
        Me.GrupoActivo.Controls.Add(Me.Label54)
        Me.GrupoActivo.Controls.Add(Me.TipoAMP)
        Me.GrupoActivo.Location = New System.Drawing.Point(12, 102)
        Me.GrupoActivo.Name = "GrupoActivo"
        Me.GrupoActivo.Size = New System.Drawing.Size(455, 62)
        Me.GrupoActivo.TabIndex = 73
        Me.GrupoActivo.TabStop = False
        Me.GrupoActivo.Text = "ACTIVO"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(312, 18)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(49, 13)
        Me.Label52.TabIndex = 25
        Me.Label52.Text = "Cantidad"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(11, 18)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(103, 13)
        Me.Label53.TabIndex = 8
        Me.Label53.Text = "Tipo de Amplificador"
        Me.Label53.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.ComboBox3.Location = New System.Drawing.Point(317, 32)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(44, 21)
        Me.ComboBox3.TabIndex = 24
        Me.ComboBox3.Text = "0"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(435, 44)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(0, 13)
        Me.Label54.TabIndex = 23
        '
        'TipoAMP
        '
        Me.TipoAMP.FormattingEnabled = True
        Me.TipoAMP.Location = New System.Drawing.Point(15, 32)
        Me.TipoAMP.Name = "TipoAMP"
        Me.TipoAMP.Size = New System.Drawing.Size(251, 21)
        Me.TipoAMP.TabIndex = 20
        Me.TipoAMP.Text = "NINGUNO"
        '
        'GrupoCables
        '
        Me.GrupoCables.BackColor = System.Drawing.Color.White
        Me.GrupoCables.Controls.Add(Me.Label25)
        Me.GrupoCables.Controls.Add(Me.TXT_CANTCABLEADOINT)
        Me.GrupoCables.Controls.Add(Me.Label23)
        Me.GrupoCables.Controls.Add(Me.ComboBox2)
        Me.GrupoCables.Controls.Add(Me.TXT_MTSCABLES_ACOMETIDA)
        Me.GrupoCables.Controls.Add(Me.Label49)
        Me.GrupoCables.Controls.Add(Me.Label24)
        Me.GrupoCables.Controls.Add(Me.ComboBox1)
        Me.GrupoCables.Location = New System.Drawing.Point(14, 12)
        Me.GrupoCables.Name = "GrupoCables"
        Me.GrupoCables.Size = New System.Drawing.Size(361, 84)
        Me.GrupoCables.TabIndex = 74
        Me.GrupoCables.TabStop = False
        Me.GrupoCables.Text = "CABLES"
        '
        'GroupPASIVOS
        '
        Me.GroupPASIVOS.BackColor = System.Drawing.Color.White
        Me.GroupPASIVOS.Controls.Add(Me.DISP_9)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_8)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_7)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_6)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_5)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_4)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_3)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_2)
        Me.GroupPASIVOS.Controls.Add(Me.DISP_1)
        Me.GroupPASIVOS.Controls.Add(Me.Label4)
        Me.GroupPASIVOS.Controls.Add(Me.BTN_QUITAR)
        Me.GroupPASIVOS.Controls.Add(Me.COD_9)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_9)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_9)
        Me.GroupPASIVOS.Controls.Add(Me.COD_8)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_8)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_8)
        Me.GroupPASIVOS.Controls.Add(Me.COD_7)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_7)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_7)
        Me.GroupPASIVOS.Controls.Add(Me.COD_6)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_6)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_6)
        Me.GroupPASIVOS.Controls.Add(Me.COD_5)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_5)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_5)
        Me.GroupPASIVOS.Controls.Add(Me.COD_4)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_4)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_4)
        Me.GroupPASIVOS.Controls.Add(Me.COD_3)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_3)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_3)
        Me.GroupPASIVOS.Controls.Add(Me.COD_2)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_2)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_2)
        Me.GroupPASIVOS.Controls.Add(Me.COD_1)
        Me.GroupPASIVOS.Controls.Add(Me.Label1)
        Me.GroupPASIVOS.Controls.Add(Me.CANT_1)
        Me.GroupPASIVOS.Controls.Add(Me.Label2)
        Me.GroupPASIVOS.Controls.Add(Me.BTN_AGREGAR)
        Me.GroupPASIVOS.Controls.Add(Me.Label3)
        Me.GroupPASIVOS.Controls.Add(Me.COD_ART_1)
        Me.GroupPASIVOS.Location = New System.Drawing.Point(12, 170)
        Me.GroupPASIVOS.Name = "GroupPASIVOS"
        Me.GroupPASIVOS.Size = New System.Drawing.Size(526, 331)
        Me.GroupPASIVOS.TabIndex = 75
        Me.GroupPASIVOS.TabStop = False
        Me.GroupPASIVOS.Text = "PASIVOS"
        '
        'DISP_9
        '
        Me.DISP_9.Location = New System.Drawing.Point(348, 272)
        Me.DISP_9.Name = "DISP_9"
        Me.DISP_9.Size = New System.Drawing.Size(32, 20)
        Me.DISP_9.TabIndex = 108
        Me.DISP_9.Text = "0"
        Me.DISP_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_9.Visible = False
        '
        'DISP_8
        '
        Me.DISP_8.Location = New System.Drawing.Point(348, 245)
        Me.DISP_8.Name = "DISP_8"
        Me.DISP_8.Size = New System.Drawing.Size(32, 20)
        Me.DISP_8.TabIndex = 107
        Me.DISP_8.Text = "0"
        Me.DISP_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_8.Visible = False
        '
        'DISP_7
        '
        Me.DISP_7.Location = New System.Drawing.Point(348, 218)
        Me.DISP_7.Name = "DISP_7"
        Me.DISP_7.Size = New System.Drawing.Size(32, 20)
        Me.DISP_7.TabIndex = 106
        Me.DISP_7.Text = "0"
        Me.DISP_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_7.Visible = False
        '
        'DISP_6
        '
        Me.DISP_6.Location = New System.Drawing.Point(348, 191)
        Me.DISP_6.Name = "DISP_6"
        Me.DISP_6.Size = New System.Drawing.Size(32, 20)
        Me.DISP_6.TabIndex = 105
        Me.DISP_6.Text = "0"
        Me.DISP_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_6.Visible = False
        '
        'DISP_5
        '
        Me.DISP_5.Location = New System.Drawing.Point(348, 164)
        Me.DISP_5.Name = "DISP_5"
        Me.DISP_5.Size = New System.Drawing.Size(32, 20)
        Me.DISP_5.TabIndex = 104
        Me.DISP_5.Text = "0"
        Me.DISP_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_5.Visible = False
        '
        'DISP_4
        '
        Me.DISP_4.Location = New System.Drawing.Point(348, 137)
        Me.DISP_4.Name = "DISP_4"
        Me.DISP_4.Size = New System.Drawing.Size(32, 20)
        Me.DISP_4.TabIndex = 103
        Me.DISP_4.Text = "0"
        Me.DISP_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_4.Visible = False
        '
        'DISP_3
        '
        Me.DISP_3.Location = New System.Drawing.Point(348, 110)
        Me.DISP_3.Name = "DISP_3"
        Me.DISP_3.Size = New System.Drawing.Size(32, 20)
        Me.DISP_3.TabIndex = 102
        Me.DISP_3.Text = "0"
        Me.DISP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_3.Visible = False
        '
        'DISP_2
        '
        Me.DISP_2.Location = New System.Drawing.Point(348, 83)
        Me.DISP_2.Name = "DISP_2"
        Me.DISP_2.Size = New System.Drawing.Size(32, 20)
        Me.DISP_2.TabIndex = 101
        Me.DISP_2.Text = "0"
        Me.DISP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DISP_2.Visible = False
        '
        'DISP_1
        '
        Me.DISP_1.Location = New System.Drawing.Point(348, 56)
        Me.DISP_1.Name = "DISP_1"
        Me.DISP_1.Size = New System.Drawing.Size(32, 20)
        Me.DISP_1.TabIndex = 99
        Me.DISP_1.Text = "0"
        Me.DISP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "DISP"
        '
        'BTN_QUITAR
        '
        Me.BTN_QUITAR.Location = New System.Drawing.Point(374, 10)
        Me.BTN_QUITAR.Name = "BTN_QUITAR"
        Me.BTN_QUITAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_QUITAR.TabIndex = 98
        Me.BTN_QUITAR.Text = "QUITAR"
        Me.BTN_QUITAR.UseVisualStyleBackColor = True
        Me.BTN_QUITAR.Visible = False
        '
        'COD_9
        '
        Me.COD_9.Location = New System.Drawing.Point(6, 272)
        Me.COD_9.Name = "COD_9"
        Me.COD_9.Size = New System.Drawing.Size(61, 20)
        Me.COD_9.TabIndex = 97
        Me.COD_9.Text = "0"
        Me.COD_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_9.Visible = False
        '
        'CANT_9
        '
        Me.CANT_9.Location = New System.Drawing.Point(387, 272)
        Me.CANT_9.Name = "CANT_9"
        Me.CANT_9.Size = New System.Drawing.Size(61, 20)
        Me.CANT_9.TabIndex = 95
        Me.CANT_9.Text = "0"
        Me.CANT_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_9.Visible = False
        '
        'COD_ART_9
        '
        Me.COD_ART_9.FormattingEnabled = True
        Me.COD_ART_9.Location = New System.Drawing.Point(73, 271)
        Me.COD_ART_9.Name = "COD_ART_9"
        Me.COD_ART_9.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_9.TabIndex = 96
        Me.COD_ART_9.Text = "Seleccione..."
        Me.COD_ART_9.Visible = False
        '
        'COD_8
        '
        Me.COD_8.Location = New System.Drawing.Point(6, 245)
        Me.COD_8.Name = "COD_8"
        Me.COD_8.Size = New System.Drawing.Size(61, 20)
        Me.COD_8.TabIndex = 94
        Me.COD_8.Text = "0"
        Me.COD_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_8.Visible = False
        '
        'CANT_8
        '
        Me.CANT_8.Location = New System.Drawing.Point(387, 245)
        Me.CANT_8.Name = "CANT_8"
        Me.CANT_8.Size = New System.Drawing.Size(61, 20)
        Me.CANT_8.TabIndex = 92
        Me.CANT_8.Text = "0"
        Me.CANT_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_8.Visible = False
        '
        'COD_ART_8
        '
        Me.COD_ART_8.FormattingEnabled = True
        Me.COD_ART_8.Location = New System.Drawing.Point(73, 244)
        Me.COD_ART_8.Name = "COD_ART_8"
        Me.COD_ART_8.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_8.TabIndex = 93
        Me.COD_ART_8.Text = "Seleccione..."
        Me.COD_ART_8.Visible = False
        '
        'COD_7
        '
        Me.COD_7.Location = New System.Drawing.Point(6, 218)
        Me.COD_7.Name = "COD_7"
        Me.COD_7.Size = New System.Drawing.Size(61, 20)
        Me.COD_7.TabIndex = 91
        Me.COD_7.Text = "0"
        Me.COD_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_7.Visible = False
        '
        'CANT_7
        '
        Me.CANT_7.Location = New System.Drawing.Point(387, 218)
        Me.CANT_7.Name = "CANT_7"
        Me.CANT_7.Size = New System.Drawing.Size(61, 20)
        Me.CANT_7.TabIndex = 89
        Me.CANT_7.Text = "0"
        Me.CANT_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_7.Visible = False
        '
        'COD_ART_7
        '
        Me.COD_ART_7.FormattingEnabled = True
        Me.COD_ART_7.Location = New System.Drawing.Point(73, 217)
        Me.COD_ART_7.Name = "COD_ART_7"
        Me.COD_ART_7.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_7.TabIndex = 90
        Me.COD_ART_7.Text = "Seleccione..."
        Me.COD_ART_7.Visible = False
        '
        'COD_6
        '
        Me.COD_6.Location = New System.Drawing.Point(6, 191)
        Me.COD_6.Name = "COD_6"
        Me.COD_6.Size = New System.Drawing.Size(61, 20)
        Me.COD_6.TabIndex = 88
        Me.COD_6.Text = "0"
        Me.COD_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_6.Visible = False
        '
        'CANT_6
        '
        Me.CANT_6.Location = New System.Drawing.Point(387, 191)
        Me.CANT_6.Name = "CANT_6"
        Me.CANT_6.Size = New System.Drawing.Size(61, 20)
        Me.CANT_6.TabIndex = 86
        Me.CANT_6.Text = "0"
        Me.CANT_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_6.Visible = False
        '
        'COD_ART_6
        '
        Me.COD_ART_6.FormattingEnabled = True
        Me.COD_ART_6.Location = New System.Drawing.Point(73, 190)
        Me.COD_ART_6.Name = "COD_ART_6"
        Me.COD_ART_6.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_6.TabIndex = 87
        Me.COD_ART_6.Text = "Seleccione..."
        Me.COD_ART_6.Visible = False
        '
        'COD_5
        '
        Me.COD_5.Location = New System.Drawing.Point(6, 164)
        Me.COD_5.Name = "COD_5"
        Me.COD_5.Size = New System.Drawing.Size(61, 20)
        Me.COD_5.TabIndex = 85
        Me.COD_5.Text = "0"
        Me.COD_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_5.Visible = False
        '
        'CANT_5
        '
        Me.CANT_5.Location = New System.Drawing.Point(387, 164)
        Me.CANT_5.Name = "CANT_5"
        Me.CANT_5.Size = New System.Drawing.Size(61, 20)
        Me.CANT_5.TabIndex = 83
        Me.CANT_5.Text = "0"
        Me.CANT_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_5.Visible = False
        '
        'COD_ART_5
        '
        Me.COD_ART_5.FormattingEnabled = True
        Me.COD_ART_5.Location = New System.Drawing.Point(73, 163)
        Me.COD_ART_5.Name = "COD_ART_5"
        Me.COD_ART_5.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_5.TabIndex = 84
        Me.COD_ART_5.Text = "Seleccione..."
        Me.COD_ART_5.Visible = False
        '
        'COD_4
        '
        Me.COD_4.Location = New System.Drawing.Point(6, 137)
        Me.COD_4.Name = "COD_4"
        Me.COD_4.Size = New System.Drawing.Size(61, 20)
        Me.COD_4.TabIndex = 82
        Me.COD_4.Text = "0"
        Me.COD_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_4.Visible = False
        '
        'CANT_4
        '
        Me.CANT_4.Location = New System.Drawing.Point(387, 137)
        Me.CANT_4.Name = "CANT_4"
        Me.CANT_4.Size = New System.Drawing.Size(61, 20)
        Me.CANT_4.TabIndex = 80
        Me.CANT_4.Text = "0"
        Me.CANT_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_4.Visible = False
        '
        'COD_ART_4
        '
        Me.COD_ART_4.FormattingEnabled = True
        Me.COD_ART_4.Location = New System.Drawing.Point(73, 136)
        Me.COD_ART_4.Name = "COD_ART_4"
        Me.COD_ART_4.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_4.TabIndex = 81
        Me.COD_ART_4.Text = "Seleccione..."
        Me.COD_ART_4.Visible = False
        '
        'COD_3
        '
        Me.COD_3.Location = New System.Drawing.Point(6, 110)
        Me.COD_3.Name = "COD_3"
        Me.COD_3.Size = New System.Drawing.Size(61, 20)
        Me.COD_3.TabIndex = 79
        Me.COD_3.Text = "0"
        Me.COD_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_3.Visible = False
        '
        'CANT_3
        '
        Me.CANT_3.Location = New System.Drawing.Point(387, 110)
        Me.CANT_3.Name = "CANT_3"
        Me.CANT_3.Size = New System.Drawing.Size(61, 20)
        Me.CANT_3.TabIndex = 77
        Me.CANT_3.Text = "0"
        Me.CANT_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_3.Visible = False
        '
        'COD_ART_3
        '
        Me.COD_ART_3.FormattingEnabled = True
        Me.COD_ART_3.Location = New System.Drawing.Point(73, 109)
        Me.COD_ART_3.Name = "COD_ART_3"
        Me.COD_ART_3.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_3.TabIndex = 78
        Me.COD_ART_3.Text = "Seleccione..."
        Me.COD_ART_3.Visible = False
        '
        'COD_2
        '
        Me.COD_2.Location = New System.Drawing.Point(6, 83)
        Me.COD_2.Name = "COD_2"
        Me.COD_2.Size = New System.Drawing.Size(61, 20)
        Me.COD_2.TabIndex = 76
        Me.COD_2.Text = "0"
        Me.COD_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.COD_2.Visible = False
        '
        'CANT_2
        '
        Me.CANT_2.Location = New System.Drawing.Point(387, 83)
        Me.CANT_2.Name = "CANT_2"
        Me.CANT_2.Size = New System.Drawing.Size(61, 20)
        Me.CANT_2.TabIndex = 74
        Me.CANT_2.Text = "0"
        Me.CANT_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CANT_2.Visible = False
        '
        'COD_ART_2
        '
        Me.COD_ART_2.FormattingEnabled = True
        Me.COD_ART_2.Location = New System.Drawing.Point(73, 82)
        Me.COD_ART_2.Name = "COD_ART_2"
        Me.COD_ART_2.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_2.TabIndex = 75
        Me.COD_ART_2.Text = "Seleccione..."
        Me.COD_ART_2.Visible = False
        '
        'COD_1
        '
        Me.COD_1.Location = New System.Drawing.Point(6, 56)
        Me.COD_1.Name = "COD_1"
        Me.COD_1.Size = New System.Drawing.Size(61, 20)
        Me.COD_1.TabIndex = 73
        Me.COD_1.Text = "0"
        Me.COD_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "CODIGO"
        '
        'CANT_1
        '
        Me.CANT_1.Location = New System.Drawing.Point(387, 56)
        Me.CANT_1.Name = "CANT_1"
        Me.CANT_1.Size = New System.Drawing.Size(61, 20)
        Me.CANT_1.TabIndex = 61
        Me.CANT_1.Text = "0"
        Me.CANT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ARTICULO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "CANTIDAD"
        '
        'COD_ART_1
        '
        Me.COD_ART_1.FormattingEnabled = True
        Me.COD_ART_1.Location = New System.Drawing.Point(73, 55)
        Me.COD_ART_1.Name = "COD_ART_1"
        Me.COD_ART_1.Size = New System.Drawing.Size(269, 21)
        Me.COD_ART_1.TabIndex = 72
        Me.COD_ART_1.Text = "Seleccione..."
        '
        'BTN_INGRESAR
        '
        Me.BTN_INGRESAR.Location = New System.Drawing.Point(392, 507)
        Me.BTN_INGRESAR.Name = "BTN_INGRESAR"
        Me.BTN_INGRESAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_INGRESAR.TabIndex = 74
        Me.BTN_INGRESAR.Text = "AGREGAR"
        Me.BTN_INGRESAR.UseVisualStyleBackColor = True
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
        Me.BTN_CERRAR.Location = New System.Drawing.Point(447, 0)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(36, 42)
        Me.BTN_CERRAR.TabIndex = 76
        Me.BTN_CERRAR.UseVisualStyleBackColor = False
        '
        'INDICESDataSet
        '
        Me.INDICESDataSet.DataSetName = "INDICESDataSet"
        Me.INDICESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MAT_ACTIVOSBindingSource
        '
        Me.MAT_ACTIVOSBindingSource.DataMember = "MAT_ACTIVOS"
        Me.MAT_ACTIVOSBindingSource.DataSource = Me.INDICESDataSet
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
        'MAT_STOCKBindingSource
        '
        Me.MAT_STOCKBindingSource.DataMember = "MAT_STOCK"
        Me.MAT_STOCKBindingSource.DataSource = Me.INDICESDataSet
        '
        'MAT_STOCKTableAdapter
        '
        Me.MAT_STOCKTableAdapter.ClearBeforeFill = True
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRESUPUESTOBindingSource
        '
        Me.PRESUPUESTOBindingSource.DataMember = "PRESUPUESTO"
        Me.PRESUPUESTOBindingSource.DataSource = Me.ORDENESDataSet
        '
        'PRESUPUESTOTableAdapter
        '
        Me.PRESUPUESTOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.PRESUPUESTOTableAdapter = Me.PRESUPUESTOTableAdapter
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
        'STANDARD_MATERIALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 550)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.BTN_INGRESAR)
        Me.Controls.Add(Me.GroupPASIVOS)
        Me.Controls.Add(Me.GrupoCables)
        Me.Controls.Add(Me.GrupoActivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "STANDARD_MATERIALES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STANDARD_MATERIALES"
        Me.GrupoActivo.ResumeLayout(False)
        Me.GrupoActivo.PerformLayout()
        Me.GrupoCables.ResumeLayout(False)
        Me.GrupoCables.PerformLayout()
        Me.GroupPASIVOS.ResumeLayout(False)
        Me.GroupPASIVOS.PerformLayout()
        CType(Me.INDICESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_ACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAT_STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESUPUESTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents Label49 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TXT_CANTCABLEADOINT As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TXT_MTSCABLES_ACOMETIDA As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GrupoActivo As GroupBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TipoAMP As ComboBox
    Friend WithEvents GrupoCables As GroupBox
    Friend WithEvents GroupPASIVOS As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CANT_1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents COD_ART_1 As ComboBox
    Friend WithEvents COD_1 As TextBox
    Friend WithEvents BTN_INGRESAR As Button
    Friend WithEvents BTN_QUITAR As Button
    Friend WithEvents COD_9 As TextBox
    Friend WithEvents CANT_9 As TextBox
    Friend WithEvents COD_ART_9 As ComboBox
    Friend WithEvents COD_8 As TextBox
    Friend WithEvents CANT_8 As TextBox
    Friend WithEvents COD_ART_8 As ComboBox
    Friend WithEvents COD_7 As TextBox
    Friend WithEvents CANT_7 As TextBox
    Friend WithEvents COD_ART_7 As ComboBox
    Friend WithEvents COD_6 As TextBox
    Friend WithEvents CANT_6 As TextBox
    Friend WithEvents COD_ART_6 As ComboBox
    Friend WithEvents COD_5 As TextBox
    Friend WithEvents CANT_5 As TextBox
    Friend WithEvents COD_ART_5 As ComboBox
    Friend WithEvents COD_4 As TextBox
    Friend WithEvents CANT_4 As TextBox
    Friend WithEvents COD_ART_4 As ComboBox
    Friend WithEvents COD_3 As TextBox
    Friend WithEvents CANT_3 As TextBox
    Friend WithEvents COD_ART_3 As ComboBox
    Friend WithEvents COD_2 As TextBox
    Friend WithEvents CANT_2 As TextBox
    Friend WithEvents COD_ART_2 As ComboBox
    Friend WithEvents BTN_CERRAR As Button
    Friend WithEvents INDICESDataSet As INDICESDataSet
    Friend WithEvents MAT_ACTIVOSBindingSource As BindingSource
    Friend WithEvents MAT_ACTIVOSTableAdapter As INDICESDataSetTableAdapters.MAT_ACTIVOSTableAdapter
    Friend WithEvents TableAdapterManager As INDICESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DISP_9 As TextBox
    Friend WithEvents DISP_8 As TextBox
    Friend WithEvents DISP_7 As TextBox
    Friend WithEvents DISP_6 As TextBox
    Friend WithEvents DISP_5 As TextBox
    Friend WithEvents DISP_4 As TextBox
    Friend WithEvents DISP_3 As TextBox
    Friend WithEvents DISP_2 As TextBox
    Friend WithEvents DISP_1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MAT_STOCKBindingSource As BindingSource
    Friend WithEvents MAT_STOCKTableAdapter As INDICESDataSetTableAdapters.MAT_STOCKTableAdapter
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents PRESUPUESTOBindingSource As BindingSource
    Friend WithEvents PRESUPUESTOTableAdapter As ORDENESDataSetTableAdapters.PRESUPUESTOTableAdapter
    Friend WithEvents TableAdapterManager1 As ORDENESDataSetTableAdapters.TableAdapterManager
End Class
