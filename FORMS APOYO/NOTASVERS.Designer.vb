<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NOTASVERS
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
        Me.OPERACIONES_LOGDataSet = New REDES.OPERACIONES_LOGDataSet()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New REDES.OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter()
        Me.TableAdapterManager = New REDES.OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TXTTexto = New System.Windows.Forms.TextBox()
        Me.LBLLogo1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLLogo = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnCerrar.Location = New System.Drawing.Point(349, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'TXTTexto
        '
        Me.TXTTexto.Location = New System.Drawing.Point(12, 116)
        Me.TXTTexto.Multiline = True
        Me.TXTTexto.Name = "TXTTexto"
        Me.TXTTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTTexto.Size = New System.Drawing.Size(360, 433)
        Me.TXTTexto.TabIndex = 2
        Me.TXTTexto.Text = "texto"
        '
        'LBLLogo1
        '
        Me.LBLLogo1.AutoSize = True
        Me.LBLLogo1.BackColor = System.Drawing.Color.Transparent
        Me.LBLLogo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLLogo1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLogo1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBLLogo1.Location = New System.Drawing.Point(134, 27)
        Me.LBLLogo1.Name = "LBLLogo1"
        Me.LBLLogo1.Size = New System.Drawing.Size(49, 25)
        Me.LBLLogo1.TabIndex = 17
        Me.LBLLogo1.Text = "Lite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(33, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Soluciones a su medida"
        '
        'LBLLogo
        '
        Me.LBLLogo.ActiveLinkColor = System.Drawing.Color.DarkSlateGray
        Me.LBLLogo.AutoSize = True
        Me.LBLLogo.BackColor = System.Drawing.Color.Transparent
        Me.LBLLogo.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLogo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LBLLogo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LBLLogo.Location = New System.Drawing.Point(65, 12)
        Me.LBLLogo.Name = "LBLLogo"
        Me.LBLLogo.Size = New System.Drawing.Size(77, 45)
        Me.LBLLogo.TabIndex = 16
        Me.LBLLogo.TabStop = True
        Me.LBLLogo.Text = "SGE"
        Me.LBLLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBLLogo.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Notas de version"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(239, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "VERSION 3.1.13"
        Me.Label3.Visible = False
        '
        'NOTASVERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLLogo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLLogo)
        Me.Controls.Add(Me.TXTTexto)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NOTASVERS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO"
        Me.TopMost = True
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OPERACIONES_LOGDataSet As OPERACIONES_LOGDataSet
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents USUARIOSTableAdapter As OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents TableAdapterManager As OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TXTTexto As TextBox
    Friend WithEvents LBLLogo1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLLogo As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
