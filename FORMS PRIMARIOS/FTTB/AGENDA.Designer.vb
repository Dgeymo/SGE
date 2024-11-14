<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENDA
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
        Me.BTN_NEXT = New System.Windows.Forms.Button()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.LBL_ACCESO = New System.Windows.Forms.Label()
        Me.P_MENU = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE_MENU = New System.Windows.Forms.Button()
        Me.BTN_MENU_REAGENDAR = New System.Windows.Forms.Button()
        Me.BTN_MENU_DESAGENDAR = New System.Windows.Forms.Button()
        Me.EDIFICIODataSet = New REDES.EDIFICIODataSet()
        Me.AGENDATableAdapter = New REDES.EDIFICIODataSetTableAdapters.AGENDATableAdapter()
        Me.TECNICOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TECNICOSTableAdapter()
        Me.TURNOSTableAdapter = New REDES.EDIFICIODataSetTableAdapters.TURNOSTableAdapter()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.AGENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New REDES.EDIFICIODataSetTableAdapters.TableAdapterManager()
        Me.TECNICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDUTableAdapter = New REDES.EDIFICIODataSetTableAdapters.MDUTableAdapter()
        Me.P_MENU.SuspendLayout()
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_NEXT
        '
        Me.BTN_NEXT.BackColor = System.Drawing.Color.Black
        Me.BTN_NEXT.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NEXT.FlatAppearance.BorderSize = 0
        Me.BTN_NEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NEXT.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEXT.ForeColor = System.Drawing.Color.White
        Me.BTN_NEXT.Location = New System.Drawing.Point(1331, 0)
        Me.BTN_NEXT.Name = "BTN_NEXT"
        Me.BTN_NEXT.Size = New System.Drawing.Size(30, 749)
        Me.BTN_NEXT.TabIndex = 0
        Me.BTN_NEXT.Text = ">"
        Me.BTN_NEXT.UseVisualStyleBackColor = False
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.Black
        Me.BTN_BACK.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_BACK.FlatAppearance.BorderSize = 0
        Me.BTN_BACK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_BACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BACK.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.ForeColor = System.Drawing.Color.White
        Me.BTN_BACK.Location = New System.Drawing.Point(0, 0)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(30, 749)
        Me.BTN_BACK.TabIndex = 1
        Me.BTN_BACK.Text = "<"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'LBL_ACCESO
        '
        Me.LBL_ACCESO.AutoSize = True
        Me.LBL_ACCESO.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ACCESO.Location = New System.Drawing.Point(66, 1)
        Me.LBL_ACCESO.Name = "LBL_ACCESO"
        Me.LBL_ACCESO.Size = New System.Drawing.Size(233, 22)
        Me.LBL_ACCESO.TabIndex = 2
        Me.LBL_ACCESO.Text = "MODO VISTA DE AGENDA"
        '
        'P_MENU
        '
        Me.P_MENU.BackColor = System.Drawing.Color.Gray
        Me.P_MENU.Controls.Add(Me.BTN_CLOSE_MENU)
        Me.P_MENU.Controls.Add(Me.BTN_MENU_REAGENDAR)
        Me.P_MENU.Controls.Add(Me.BTN_MENU_DESAGENDAR)
        Me.P_MENU.Location = New System.Drawing.Point(1001, 609)
        Me.P_MENU.Name = "P_MENU"
        Me.P_MENU.Size = New System.Drawing.Size(128, 74)
        Me.P_MENU.TabIndex = 3
        Me.P_MENU.Visible = False
        '
        'BTN_CLOSE_MENU
        '
        Me.BTN_CLOSE_MENU.Location = New System.Drawing.Point(106, -1)
        Me.BTN_CLOSE_MENU.Name = "BTN_CLOSE_MENU"
        Me.BTN_CLOSE_MENU.Size = New System.Drawing.Size(22, 20)
        Me.BTN_CLOSE_MENU.TabIndex = 2
        Me.BTN_CLOSE_MENU.Text = "X"
        Me.BTN_CLOSE_MENU.UseVisualStyleBackColor = True
        '
        'BTN_MENU_REAGENDAR
        '
        Me.BTN_MENU_REAGENDAR.Location = New System.Drawing.Point(15, 48)
        Me.BTN_MENU_REAGENDAR.Name = "BTN_MENU_REAGENDAR"
        Me.BTN_MENU_REAGENDAR.Size = New System.Drawing.Size(99, 23)
        Me.BTN_MENU_REAGENDAR.TabIndex = 1
        Me.BTN_MENU_REAGENDAR.Text = "REAGENDAR"
        Me.BTN_MENU_REAGENDAR.UseVisualStyleBackColor = True
        Me.BTN_MENU_REAGENDAR.Visible = False
        '
        'BTN_MENU_DESAGENDAR
        '
        Me.BTN_MENU_DESAGENDAR.Location = New System.Drawing.Point(15, 19)
        Me.BTN_MENU_DESAGENDAR.Name = "BTN_MENU_DESAGENDAR"
        Me.BTN_MENU_DESAGENDAR.Size = New System.Drawing.Size(99, 23)
        Me.BTN_MENU_DESAGENDAR.TabIndex = 0
        Me.BTN_MENU_DESAGENDAR.Text = "DESAGENDAR"
        Me.BTN_MENU_DESAGENDAR.UseVisualStyleBackColor = True
        '
        'EDIFICIODataSet
        '
        Me.EDIFICIODataSet.DataSetName = "EDIFICIODataSet"
        Me.EDIFICIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AGENDATableAdapter
        '
        Me.AGENDATableAdapter.ClearBeforeFill = True
        '
        'TECNICOSTableAdapter
        '
        Me.TECNICOSTableAdapter.ClearBeforeFill = True
        '
        'TURNOSTableAdapter
        '
        Me.TURNOSTableAdapter.ClearBeforeFill = True
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.BackColor = System.Drawing.Color.Red
        Me.BTN_CERRAR.FlatAppearance.BorderSize = 0
        Me.BTN_CERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CERRAR.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CERRAR.ForeColor = System.Drawing.Color.White
        Me.BTN_CERRAR.Location = New System.Drawing.Point(1242, 0)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(69, 23)
        Me.BTN_CERRAR.TabIndex = 3
        Me.BTN_CERRAR.Text = "CERRAR"
        Me.BTN_CERRAR.UseVisualStyleBackColor = False
        '
        'AGENDABindingSource
        '
        Me.AGENDABindingSource.DataMember = "AGENDA"
        Me.AGENDABindingSource.DataSource = Me.EDIFICIODataSet
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AGENDATableAdapter = Nothing
        Me.TableAdapterManager1.AVANCETableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BITACORATableAdapter = Nothing
        Me.TableAdapterManager1.CALLESTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.FTTBTableAdapter = Nothing
        Me.TableAdapterManager1.MDUTableAdapter = Nothing
        Me.TableAdapterManager1.STATUSTableAdapter = Nothing
        Me.TableAdapterManager1.TECNICOSTableAdapter = Nothing
        Me.TableAdapterManager1.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.EDIFICIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'MDUBindingSource
        '
        Me.MDUBindingSource.DataMember = "MDU"
        Me.MDUBindingSource.DataSource = Me.EDIFICIODataSet
        '
        'MDUTableAdapter
        '
        Me.MDUTableAdapter.ClearBeforeFill = True
        '
        'AGENDA
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1361, 749)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.P_MENU)
        Me.Controls.Add(Me.LBL_ACCESO)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_NEXT)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AGENDA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AGENDA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_MENU.ResumeLayout(False)
        CType(Me.EDIFICIODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECNICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents TableAdapterManager As OBRAS_MDUDataSetTableAdapters.TableAdapterManager



    Friend WithEvents BTN_NEXT As Button
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents LBL_ACCESO As Label
    Friend WithEvents P_MENU As Panel
    Friend WithEvents BTN_MENU_REAGENDAR As Button
    Friend WithEvents BTN_MENU_DESAGENDAR As Button
    Friend WithEvents BTN_CLOSE_MENU As Button
    Friend WithEvents EDIFICIODataSet As EDIFICIODataSet
    Friend WithEvents AGENDABindingSource As BindingSource
    Friend WithEvents AGENDATableAdapter As EDIFICIODataSetTableAdapters.AGENDATableAdapter
    Friend WithEvents TableAdapterManager1 As EDIFICIODataSetTableAdapters.TableAdapterManager
    Friend WithEvents TECNICOSTableAdapter As EDIFICIODataSetTableAdapters.TECNICOSTableAdapter
    Friend WithEvents TECNICOSBindingSource As BindingSource
    Friend WithEvents TURNOSTableAdapter As EDIFICIODataSetTableAdapters.TURNOSTableAdapter
    Friend WithEvents TURNOSBindingSource As BindingSource
    Friend WithEvents MDUBindingSource As BindingSource
    Friend WithEvents BTN_CERRAR As Button
    Friend WithEvents MDUTableAdapter As EDIFICIODataSetTableAdapters.MDUTableAdapter
End Class
