<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HISTORIALRED
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HISTORIALRED))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BOT_ORDENES = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HASTA_ORD = New System.Windows.Forms.DateTimePicker()
        Me.DESDE_ORD = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.CREAR_ORDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CREAR_ORDTableAdapter = New REDES.ORDENESDataSetTableAdapters.CREAR_ORDTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.CREAR_ORDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CREAR_ORDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CREAR_ORDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.NODOFILTRO = New System.Windows.Forms.Label()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREAR_ORDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREAR_ORDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CREAR_ORDBindingNavigator.SuspendLayout()
        CType(Me.CREAR_ORDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(359, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkRed
        Me.Label23.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label23.Location = New System.Drawing.Point(13, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 19)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "UBICACION"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.DarkRed
        Me.Label22.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label22.Location = New System.Drawing.Point(288, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 19)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "UTE"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.DarkRed
        Me.Label21.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label21.Location = New System.Drawing.Point(203, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 19)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "ORDINALES"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DarkRed
        Me.Label20.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label20.Location = New System.Drawing.Point(118, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 19)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "RECLAMOS"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FloralWhite
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(288, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 16)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "REC"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FloralWhite
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.ForeColor = System.Drawing.Color.DarkRed
        Me.Label19.Location = New System.Drawing.Point(328, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 16)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "ORD"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FloralWhite
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(243, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "OTRO"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FloralWhite
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(203, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 16)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "SS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FloralWhite
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(158, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "OTRO"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FloralWhite
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(118, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "SS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FloralWhite
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(63, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "ZONA"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FloralWhite
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(13, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "NODO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BOT_ORDENES
        '
        Me.BOT_ORDENES.FlatAppearance.BorderSize = 2
        Me.BOT_ORDENES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip
        Me.BOT_ORDENES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BOT_ORDENES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_ORDENES.ForeColor = System.Drawing.Color.DarkRed
        Me.BOT_ORDENES.Location = New System.Drawing.Point(164, 8)
        Me.BOT_ORDENES.Name = "BOT_ORDENES"
        Me.BOT_ORDENES.Size = New System.Drawing.Size(95, 42)
        Me.BOT_ORDENES.TabIndex = 45
        Me.BOT_ORDENES.Text = "Calcular"
        Me.BOT_ORDENES.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(13, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Hasta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(15, -16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Desde"
        '
        'HASTA_ORD
        '
        Me.HASTA_ORD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HASTA_ORD.Location = New System.Drawing.Point(52, 31)
        Me.HASTA_ORD.Name = "HASTA_ORD"
        Me.HASTA_ORD.Size = New System.Drawing.Size(106, 20)
        Me.HASTA_ORD.TabIndex = 42
        '
        'DESDE_ORD
        '
        Me.DESDE_ORD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DESDE_ORD.Location = New System.Drawing.Point(52, 9)
        Me.DESDE_ORD.Name = "DESDE_ORD"
        Me.DESDE_ORD.Size = New System.Drawing.Size(106, 20)
        Me.DESDE_ORD.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Desde"
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CREAR_ORDBindingSource
        '
        Me.CREAR_ORDBindingSource.DataMember = "CREAR_ORD"
        Me.CREAR_ORDBindingSource.DataSource = Me.ORDENESDataSet
        '
        'CREAR_ORDTableAdapter
        '
        Me.CREAR_ORDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Me.CREAR_ORDTableAdapter
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_ORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.GRAF_REDESTableAdapter = Nothing
        Me.TableAdapterManager.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager.INFORMMEMDU_PERMISORTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIA_OLDTableAdapter = Nothing
        Me.TableAdapterManager.MENSAJERIATableAdapter = Nothing
        Me.TableAdapterManager.OBESERVACIONESTableAdapter = Nothing
        Me.TableAdapterManager.ORDENESTableAdapter = Nothing
        Me.TableAdapterManager.RELACION_FALLAACTIVIDADTableAdapter = Nothing
        Me.TableAdapterManager.REPORTEORDINALESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORESTableAdapter = Nothing
        Me.TableAdapterManager.SECTORFALLATableAdapter = Nothing
        Me.TableAdapterManager.STANDARDTableAdapter = Nothing
        Me.TableAdapterManager.STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TAREASSTDTableAdapter = Nothing
        Me.TableAdapterManager.TAREASTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CREAR_ORDBindingNavigator
        '
        Me.CREAR_ORDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CREAR_ORDBindingNavigator.BindingSource = Me.CREAR_ORDBindingSource
        Me.CREAR_ORDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CREAR_ORDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CREAR_ORDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CREAR_ORDBindingNavigatorSaveItem})
        Me.CREAR_ORDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CREAR_ORDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CREAR_ORDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CREAR_ORDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CREAR_ORDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CREAR_ORDBindingNavigator.Name = "CREAR_ORDBindingNavigator"
        Me.CREAR_ORDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CREAR_ORDBindingNavigator.Size = New System.Drawing.Size(400, 25)
        Me.CREAR_ORDBindingNavigator.TabIndex = 60
        Me.CREAR_ORDBindingNavigator.Text = "BindingNavigator1"
        Me.CREAR_ORDBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CREAR_ORDBindingNavigatorSaveItem
        '
        Me.CREAR_ORDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CREAR_ORDBindingNavigatorSaveItem.Image = CType(resources.GetObject("CREAR_ORDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CREAR_ORDBindingNavigatorSaveItem.Name = "CREAR_ORDBindingNavigatorSaveItem"
        Me.CREAR_ORDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CREAR_ORDBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CREAR_ORDDataGridView
        '
        Me.CREAR_ORDDataGridView.AllowUserToAddRows = False
        Me.CREAR_ORDDataGridView.AllowUserToDeleteRows = False
        Me.CREAR_ORDDataGridView.AutoGenerateColumns = False
        Me.CREAR_ORDDataGridView.BackgroundColor = System.Drawing.Color.Gray
        Me.CREAR_ORDDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CREAR_ORDDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CREAR_ORDDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CREAR_ORDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CREAR_ORDDataGridView.ColumnHeadersVisible = False
        Me.CREAR_ORDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83, Me.Column1, Me.DataGridViewTextBoxColumn84, Me.DataGridViewTextBoxColumn85, Me.Column2, Me.DataGridViewTextBoxColumn86, Me.DataGridViewTextBoxColumn87, Me.Column3, Me.DataGridViewTextBoxColumn88, Me.DataGridViewTextBoxColumn89})
        Me.CREAR_ORDDataGridView.DataSource = Me.CREAR_ORDBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CREAR_ORDDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.CREAR_ORDDataGridView.EnableHeadersVisualStyles = False
        Me.CREAR_ORDDataGridView.GridColor = System.Drawing.Color.Gray
        Me.CREAR_ORDDataGridView.Location = New System.Drawing.Point(14, 94)
        Me.CREAR_ORDDataGridView.Name = "CREAR_ORDDataGridView"
        Me.CREAR_ORDDataGridView.ReadOnly = True
        Me.CREAR_ORDDataGridView.RowHeadersVisible = False
        Me.CREAR_ORDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CREAR_ORDDataGridView.Size = New System.Drawing.Size(378, 629)
        Me.CREAR_ORDDataGridView.TabIndex = 61
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "NODO"
        Me.DataGridViewTextBoxColumn82.HeaderText = "NODO"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        Me.DataGridViewTextBoxColumn82.ReadOnly = True
        Me.DataGridViewTextBoxColumn82.Width = 50
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn83.HeaderText = "ZONA"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        Me.DataGridViewTextBoxColumn83.ReadOnly = True
        Me.DataGridViewTextBoxColumn83.Width = 50
        '
        'Column1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FloralWhite
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 5
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.DataPropertyName = "CANT_RECSS"
        Me.DataGridViewTextBoxColumn84.HeaderText = "SS"
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        Me.DataGridViewTextBoxColumn84.ReadOnly = True
        Me.DataGridViewTextBoxColumn84.Width = 40
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "CANT_RECOTROS"
        Me.DataGridViewTextBoxColumn85.HeaderText = "OTR"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        Me.DataGridViewTextBoxColumn85.ReadOnly = True
        Me.DataGridViewTextBoxColumn85.Width = 40
        '
        'Column2
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FloralWhite
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 5
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.DataPropertyName = "CANT_ORDSS"
        Me.DataGridViewTextBoxColumn86.HeaderText = "SS"
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        Me.DataGridViewTextBoxColumn86.ReadOnly = True
        Me.DataGridViewTextBoxColumn86.Width = 40
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.DataPropertyName = "CANT_ORDOTROS"
        Me.DataGridViewTextBoxColumn87.HeaderText = "OTR"
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        Me.DataGridViewTextBoxColumn87.ReadOnly = True
        Me.DataGridViewTextBoxColumn87.Width = 40
        '
        'Column3
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FloralWhite
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 5
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.DataPropertyName = "CANT_RECUTE"
        Me.DataGridViewTextBoxColumn88.HeaderText = "REC"
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        Me.DataGridViewTextBoxColumn88.ReadOnly = True
        Me.DataGridViewTextBoxColumn88.Width = 40
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.DataPropertyName = "CANT_ORDUTE"
        Me.DataGridViewTextBoxColumn89.HeaderText = "ORD"
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        Me.DataGridViewTextBoxColumn89.ReadOnly = True
        Me.DataGridViewTextBoxColumn89.Width = 40
        '
        'ORDENESBindingSource
        '
        Me.ORDENESBindingSource.DataMember = "ORDENES"
        Me.ORDENESBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'NODOFILTRO
        '
        Me.NODOFILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NODOFILTRO.ForeColor = System.Drawing.Color.DarkRed
        Me.NODOFILTRO.Location = New System.Drawing.Point(265, 23)
        Me.NODOFILTRO.Name = "NODOFILTRO"
        Me.NODOFILTRO.Size = New System.Drawing.Size(80, 23)
        Me.NODOFILTRO.TabIndex = 62
        Me.NODOFILTRO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HISTORIALRED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(410, 748)
        Me.Controls.Add(Me.NODOFILTRO)
        Me.Controls.Add(Me.CREAR_ORDDataGridView)
        Me.Controls.Add(Me.CREAR_ORDBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BOT_ORDENES)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.HASTA_ORD)
        Me.Controls.Add(Me.DESDE_ORD)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(950, 10)
        Me.Name = "HISTORIALRED"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "HISTORIALRED"
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREAR_ORDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREAR_ORDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CREAR_ORDBindingNavigator.ResumeLayout(False)
        Me.CREAR_ORDBindingNavigator.PerformLayout()
        CType(Me.CREAR_ORDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BOT_ORDENES As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents HASTA_ORD As DateTimePicker
    Friend WithEvents DESDE_ORD As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents CREAR_ORDBindingSource As BindingSource
    Friend WithEvents CREAR_ORDTableAdapter As ORDENESDataSetTableAdapters.CREAR_ORDTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CREAR_ORDBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CREAR_ORDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CREAR_ORDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn82 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn84 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn86 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn87 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn88 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn89 As DataGridViewTextBoxColumn
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents NODOFILTRO As Label
End Class
