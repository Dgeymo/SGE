<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FOpenFileDialog
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
        Me.TXTNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListArchivos = New System.Windows.Forms.ListView()
        Me.RUTA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ARCHIVO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNAbrir = New System.Windows.Forms.Button()
        Me.BTNCerrar = New System.Windows.Forms.Button()
        Me.LBLRuta = New System.Windows.Forms.Label()
        Me.L_FOLDERS = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_SUBIRDIR = New System.Windows.Forms.Button()
        Me.CB_RAIZ = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ORDENESDataSet = New REDES.ORDENESDataSet()
        Me.ADJUNTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADJUNTOSTableAdapter = New REDES.ORDENESDataSetTableAdapters.ADJUNTOSTableAdapter()
        Me.TableAdapterManager = New REDES.ORDENESDataSetTableAdapters.TableAdapterManager()
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADJUNTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTNombre
        '
        Me.TXTNombre.BackColor = System.Drawing.Color.Gray
        Me.TXTNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre.ForeColor = System.Drawing.Color.White
        Me.TXTNombre.Location = New System.Drawing.Point(4, 452)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(300, 24)
        Me.TXTNombre.TabIndex = 1
        Me.TXTNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de referencia:"
        '
        'ListArchivos
        '
        Me.ListArchivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListArchivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListArchivos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RUTA, Me.ARCHIVO})
        Me.ListArchivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListArchivos.FullRowSelect = True
        Me.ListArchivos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListArchivos.HideSelection = False
        Me.ListArchivos.Location = New System.Drawing.Point(5, 297)
        Me.ListArchivos.Name = "ListArchivos"
        Me.ListArchivos.Size = New System.Drawing.Size(339, 155)
        Me.ListArchivos.TabIndex = 3
        Me.ListArchivos.UseCompatibleStateImageBehavior = False
        Me.ListArchivos.View = System.Windows.Forms.View.Details
        '
        'RUTA
        '
        Me.RUTA.Width = 0
        '
        'ARCHIVO
        '
        Me.ARCHIVO.Text = "ARCHIVO"
        Me.ARCHIVO.Width = 280
        '
        'BTNAbrir
        '
        Me.BTNAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAbrir.ForeColor = System.Drawing.Color.White
        Me.BTNAbrir.Location = New System.Drawing.Point(148, 484)
        Me.BTNAbrir.Name = "BTNAbrir"
        Me.BTNAbrir.Size = New System.Drawing.Size(75, 23)
        Me.BTNAbrir.TabIndex = 4
        Me.BTNAbrir.Text = "Agregar"
        Me.BTNAbrir.UseVisualStyleBackColor = True
        '
        'BTNCerrar
        '
        Me.BTNCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCerrar.ForeColor = System.Drawing.Color.White
        Me.BTNCerrar.Location = New System.Drawing.Point(227, 484)
        Me.BTNCerrar.Name = "BTNCerrar"
        Me.BTNCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCerrar.TabIndex = 5
        Me.BTNCerrar.Text = "Cancelar"
        Me.BTNCerrar.UseVisualStyleBackColor = True
        '
        'LBLRuta
        '
        Me.LBLRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRuta.ForeColor = System.Drawing.Color.Silver
        Me.LBLRuta.Location = New System.Drawing.Point(4, 29)
        Me.LBLRuta.Name = "LBLRuta"
        Me.LBLRuta.Size = New System.Drawing.Size(301, 20)
        Me.LBLRuta.TabIndex = 13
        Me.LBLRuta.Text = "Ruta:"
        '
        'L_FOLDERS
        '
        Me.L_FOLDERS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_FOLDERS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_FOLDERS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L_FOLDERS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.L_FOLDERS.ForeColor = System.Drawing.Color.White
        Me.L_FOLDERS.FullRowSelect = True
        Me.L_FOLDERS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.L_FOLDERS.HideSelection = False
        Me.L_FOLDERS.Location = New System.Drawing.Point(5, 62)
        Me.L_FOLDERS.MultiSelect = False
        Me.L_FOLDERS.Name = "L_FOLDERS"
        Me.L_FOLDERS.Size = New System.Drawing.Size(339, 202)
        Me.L_FOLDERS.TabIndex = 14
        Me.L_FOLDERS.UseCompatibleStateImageBehavior = False
        Me.L_FOLDERS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ARCHIVO"
        Me.ColumnHeader2.Width = 280
        '
        'BTN_SUBIRDIR
        '
        Me.BTN_SUBIRDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SUBIRDIR.ForeColor = System.Drawing.Color.White
        Me.BTN_SUBIRDIR.Location = New System.Drawing.Point(249, 3)
        Me.BTN_SUBIRDIR.Name = "BTN_SUBIRDIR"
        Me.BTN_SUBIRDIR.Size = New System.Drawing.Size(55, 23)
        Me.BTN_SUBIRDIR.TabIndex = 15
        Me.BTN_SUBIRDIR.Text = "SUBIR"
        Me.BTN_SUBIRDIR.UseVisualStyleBackColor = True
        '
        'CB_RAIZ
        '
        Me.CB_RAIZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_RAIZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_RAIZ.ForeColor = System.Drawing.Color.PaleGreen
        Me.CB_RAIZ.FormattingEnabled = True
        Me.CB_RAIZ.Items.AddRange(New Object() {"", "C:\", "G:\", "R:\"})
        Me.CB_RAIZ.Location = New System.Drawing.Point(123, 3)
        Me.CB_RAIZ.Name = "CB_RAIZ"
        Me.CB_RAIZ.Size = New System.Drawing.Size(63, 21)
        Me.CB_RAIZ.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(73, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Unidad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "SUB Carpetas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Archivos del directorio:"
        '
        'ORDENESDataSet
        '
        Me.ORDENESDataSet.DataSetName = "ORDENESDataSet"
        Me.ORDENESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ADJUNTOSBindingSource
        '
        Me.ADJUNTOSBindingSource.DataMember = "ADJUNTOS"
        Me.ADJUNTOSBindingSource.DataSource = Me.ORDENESDataSet
        '
        'ADJUNTOSTableAdapter
        '
        Me.ADJUNTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACTIVIDADESSTDTableAdapter = Nothing
        Me.TableAdapterManager.ADJUNTOSTableAdapter = Me.ADJUNTOSTableAdapter
        Me.TableAdapterManager.AFECTACIONTableAdapter = Nothing
        Me.TableAdapterManager.AREASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAUSASTableAdapter = Nothing
        Me.TableAdapterManager.CREAR_ORDTableAdapter = Nothing
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
        'FOpenFileDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(351, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_RAIZ)
        Me.Controls.Add(Me.BTN_SUBIRDIR)
        Me.Controls.Add(Me.L_FOLDERS)
        Me.Controls.Add(Me.LBLRuta)
        Me.Controls.Add(Me.BTNCerrar)
        Me.Controls.Add(Me.BTNAbrir)
        Me.Controls.Add(Me.ListArchivos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNombre)
        Me.ForeColor = System.Drawing.Color.LawnGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FOpenFileDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ORDENESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADJUNTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListArchivos As ListView
    Friend WithEvents BTNAbrir As Button
    Friend WithEvents BTNCerrar As Button
    Friend WithEvents RUTA As ColumnHeader
    Friend WithEvents ARCHIVO As ColumnHeader
    Friend WithEvents LBLRuta As Label
    Friend WithEvents L_FOLDERS As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BTN_SUBIRDIR As Button
    Friend WithEvents CB_RAIZ As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ORDENESDataSet As ORDENESDataSet
    Friend WithEvents ADJUNTOSBindingSource As BindingSource
    Friend WithEvents ADJUNTOSTableAdapter As ORDENESDataSetTableAdapters.ADJUNTOSTableAdapter
    Friend WithEvents TableAdapterManager As ORDENESDataSetTableAdapters.TableAdapterManager
End Class
