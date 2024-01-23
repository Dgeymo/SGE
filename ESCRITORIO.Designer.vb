<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ESCRITORIO
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
        Me.BASEFUENTESDataSet = New REDES.BASEFUENTESDataSet()
        Me.NRONODOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NRONODOSTableAdapter = New REDES.BASEFUENTESDataSetTableAdapters.NRONODOSTableAdapter()
        Me.TableAdapterManager1 = New REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.GESTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTIONTableAdapter = New REDES.ORDENESDataSetTableAdapters.GESTIONTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        Me.ORDENESTableAdapter = New REDES.ORDENESDataSetTableAdapters.ORDENESTableAdapter()
        Me.TRABAJOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.TRABAJOSTableAdapter()
        Me.TRABAJOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BTN_VERMAS_TRABAJO = New System.Windows.Forms.Button()
        Me.BTN_VERMAS_GESTION = New System.Windows.Forms.Button()
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NRONODOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BASEFUENTESDataSet
        '
        Me.BASEFUENTESDataSet.DataSetName = "BASEFUENTESDataSet"
        Me.BASEFUENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NRONODOSBindingSource
        '
        Me.NRONODOSBindingSource.DataMember = "NRONODOS"
        Me.NRONODOSBindingSource.DataSource = Me.BASEFUENTESDataSet
        '
        'NRONODOSTableAdapter
        '
        Me.NRONODOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ANTIGUEDADBATTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.baseTableAdapter = Nothing
        Me.TableAdapterManager1.GRAFANTIGUEDADTableAdapter = Nothing
        Me.TableAdapterManager1.GRAFAUTONOMIATableAdapter = Nothing
        Me.TableAdapterManager1.GRAFTIPOFUENTETableAdapter = Nothing
        Me.TableAdapterManager1.HISTORICOTableAdapter = Nothing
        Me.TableAdapterManager1.Hoja1TableAdapter = Nothing
        Me.TableAdapterManager1.INSTALACIONTableAdapter = Nothing
        Me.TableAdapterManager1.NRONODOSTableAdapter = Me.NRONODOSTableAdapter
        Me.TableAdapterManager1.TRABAJOSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REDES.BASEFUENTESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GESTIONBindingSource
        '
        Me.GESTIONBindingSource.DataMember = "GESTION"
        Me.GESTIONBindingSource.DataSource = Me.ORDENESDataSet
        '
        'GESTIONTableAdapter
        '
        Me.GESTIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.ADJUNTOSTableAdapter = Nothing
        Me.TableAdapterManager.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
        Me.TableAdapterManager.FALLASTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.GESTIONTableAdapter = Me.GESTIONTableAdapter
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
        Me.TableAdapterManager.TRABAJOSTableAdapter = Me.TRABAJOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = REDES.ORDENESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDENESTableAdapter
        '
        Me.ORDENESTableAdapter.ClearBeforeFill = True
        '
        'TRABAJOSTableAdapter
        '
        Me.TRABAJOSTableAdapter.ClearBeforeFill = True
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
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCerrar.BackgroundImage = Global.REDES.My.Resources.Resources.logout
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(1331, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 31)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BTN_VERMAS_TRABAJO
        '
        Me.BTN_VERMAS_TRABAJO.Location = New System.Drawing.Point(755, 304)
        Me.BTN_VERMAS_TRABAJO.Name = "BTN_VERMAS_TRABAJO"
        Me.BTN_VERMAS_TRABAJO.Size = New System.Drawing.Size(190, 23)
        Me.BTN_VERMAS_TRABAJO.TabIndex = 2
        Me.BTN_VERMAS_TRABAJO.Text = "BTN_VER MAS TRABAJOS"
        Me.BTN_VERMAS_TRABAJO.UseVisualStyleBackColor = True
        Me.BTN_VERMAS_TRABAJO.Visible = False
        '
        'BTN_VERMAS_GESTION
        '
        Me.BTN_VERMAS_GESTION.Location = New System.Drawing.Point(1155, 618)
        Me.BTN_VERMAS_GESTION.Name = "BTN_VERMAS_GESTION"
        Me.BTN_VERMAS_GESTION.Size = New System.Drawing.Size(190, 23)
        Me.BTN_VERMAS_GESTION.TabIndex = 3
        Me.BTN_VERMAS_GESTION.Text = "BTN_VER MAS GESTIONES"
        Me.BTN_VERMAS_GESTION.UseVisualStyleBackColor = True
        '
        'ESCRITORIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 662)
        Me.Controls.Add(Me.BTN_VERMAS_GESTION)
        Me.Controls.Add(Me.BTN_VERMAS_TRABAJO)
        Me.Controls.Add(Me.BtnCerrar)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ESCRITORIO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESCRITORIO"
        CType(Me.BASEFUENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NRONODOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRABAJOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents GESTIONBindingSource As BindingSource
    Friend WithEvents GESTIONTableAdapter As ORDENESDataSetTableAdapters.GESTIONTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TRABAJOSTableAdapter As ORDENESDataSetTableAdapters.TRABAJOSTableAdapter
    Friend WithEvents TRABAJOSBindingSource As BindingSource
    Friend WithEvents ORDENESTableAdapter As ORDENESDataSetTableAdapters.ORDENESTableAdapter
    Friend WithEvents ORDENESBindingSource As BindingSource
    Friend WithEvents BUSCA_NODO As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BASEFUENTESDataSet As BASEFUENTESDataSet
    Friend WithEvents NRONODOSBindingSource As BindingSource
    Friend WithEvents NRONODOSTableAdapter As BASEFUENTESDataSetTableAdapters.NRONODOSTableAdapter
    Friend WithEvents TableAdapterManager1 As BASEFUENTESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BTN_VERMAS_TRABAJO As Button
    Friend WithEvents BTN_VERMAS_GESTION As Button
End Class
