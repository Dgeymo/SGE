<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USUARIO
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
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.TXTPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OPERACIONES_LOGDataSet = New REDES.OPERACIONES_LOGDataSet()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New REDES.OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter()
        Me.TableAdapterManager = New REDES.OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_USUARIO_RUS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_PASSWORD_RUS = New System.Windows.Forms.TextBox()
        Me.BTN_GUARDAR_RUS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_ID_SELECTOR = New System.Windows.Forms.TextBox()
        Me.TXT_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_USUARIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_THEME = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNGuardar
        '
        Me.BTNGuardar.BackColor = System.Drawing.Color.White
        Me.BTNGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGuardar.ForeColor = System.Drawing.Color.Black
        Me.BTNGuardar.Location = New System.Drawing.Point(158, 440)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 0
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = False
        '
        'TXTPass
        '
        Me.TXTPass.BackColor = System.Drawing.Color.DimGray
        Me.TXTPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPass.ForeColor = System.Drawing.Color.White
        Me.TXTPass.Location = New System.Drawing.Point(44, 404)
        Me.TXTPass.Name = "TXTPass"
        Me.TXTPass.Size = New System.Drawing.Size(189, 19)
        Me.TXTPass.TabIndex = 1
        Me.TXTPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese nueva contraseña"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.REDES.My.Resources.Resources.UserBlack
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 116)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Configuracion de USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuario RUS"
        '
        'TXT_USUARIO_RUS
        '
        Me.TXT_USUARIO_RUS.BackColor = System.Drawing.Color.DimGray
        Me.TXT_USUARIO_RUS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_USUARIO_RUS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USUARIO_RUS.ForeColor = System.Drawing.Color.White
        Me.TXT_USUARIO_RUS.Location = New System.Drawing.Point(169, 84)
        Me.TXT_USUARIO_RUS.Name = "TXT_USUARIO_RUS"
        Me.TXT_USUARIO_RUS.Size = New System.Drawing.Size(189, 19)
        Me.TXT_USUARIO_RUS.TabIndex = 6
        Me.TXT_USUARIO_RUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contraseña RUS"
        '
        'TXT_PASSWORD_RUS
        '
        Me.TXT_PASSWORD_RUS.BackColor = System.Drawing.Color.DimGray
        Me.TXT_PASSWORD_RUS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_PASSWORD_RUS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PASSWORD_RUS.ForeColor = System.Drawing.Color.White
        Me.TXT_PASSWORD_RUS.Location = New System.Drawing.Point(169, 121)
        Me.TXT_PASSWORD_RUS.Name = "TXT_PASSWORD_RUS"
        Me.TXT_PASSWORD_RUS.Size = New System.Drawing.Size(189, 19)
        Me.TXT_PASSWORD_RUS.TabIndex = 9
        Me.TXT_PASSWORD_RUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_GUARDAR_RUS
        '
        Me.BTN_GUARDAR_RUS.BackColor = System.Drawing.Color.White
        Me.BTN_GUARDAR_RUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GUARDAR_RUS.ForeColor = System.Drawing.Color.Black
        Me.BTN_GUARDAR_RUS.Location = New System.Drawing.Point(272, 158)
        Me.BTN_GUARDAR_RUS.Name = "BTN_GUARDAR_RUS"
        Me.BTN_GUARDAR_RUS.Size = New System.Drawing.Size(86, 23)
        Me.BTN_GUARDAR_RUS.TabIndex = 8
        Me.BTN_GUARDAR_RUS.Text = "Guardar RUS"
        Me.BTN_GUARDAR_RUS.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Selector*"
        '
        'TXT_ID_SELECTOR
        '
        Me.TXT_ID_SELECTOR.BackColor = System.Drawing.Color.DimGray
        Me.TXT_ID_SELECTOR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ID_SELECTOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID_SELECTOR.ForeColor = System.Drawing.Color.White
        Me.TXT_ID_SELECTOR.Location = New System.Drawing.Point(169, 162)
        Me.TXT_ID_SELECTOR.Name = "TXT_ID_SELECTOR"
        Me.TXT_ID_SELECTOR.Size = New System.Drawing.Size(77, 19)
        Me.TXT_ID_SELECTOR.TabIndex = 11
        Me.TXT_ID_SELECTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_APELLIDO
        '
        Me.TXT_APELLIDO.BackColor = System.Drawing.Color.DimGray
        Me.TXT_APELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_APELLIDO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELLIDO.ForeColor = System.Drawing.Color.White
        Me.TXT_APELLIDO.Location = New System.Drawing.Point(46, 332)
        Me.TXT_APELLIDO.Name = "TXT_APELLIDO"
        Me.TXT_APELLIDO.Size = New System.Drawing.Size(189, 19)
        Me.TXT_APELLIDO.TabIndex = 14
        Me.TXT_APELLIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.BackColor = System.Drawing.Color.DimGray
        Me.TXT_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.ForeColor = System.Drawing.Color.White
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(46, 296)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(189, 19)
        Me.TXT_NOMBRE.TabIndex = 13
        Me.TXT_NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "APELLIDO"
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.BackColor = System.Drawing.Color.DimGray
        Me.TXT_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_USUARIO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USUARIO.ForeColor = System.Drawing.Color.White
        Me.TXT_USUARIO.Location = New System.Drawing.Point(45, 368)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.Size = New System.Drawing.Size(189, 19)
        Me.TXT_USUARIO.TabIndex = 17
        Me.TXT_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "USUARIO aplicación"
        '
        'CB_THEME
        '
        Me.CB_THEME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_THEME.FormattingEnabled = True
        Me.CB_THEME.IntegralHeight = False
        Me.CB_THEME.Items.AddRange(New Object() {"OSCURA", "CLARA"})
        Me.CB_THEME.Location = New System.Drawing.Point(12, 158)
        Me.CB_THEME.Name = "CB_THEME"
        Me.CB_THEME.Size = New System.Drawing.Size(121, 21)
        Me.CB_THEME.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "UI usuario"
        '
        'USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CB_THEME)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_USUARIO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_APELLIDO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_ID_SELECTOR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_PASSWORD_RUS)
        Me.Controls.Add(Me.BTN_GUARDAR_RUS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_USUARIO_RUS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTPass)
        Me.Controls.Add(Me.BTNGuardar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "USUARIO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "USUARIO"
        CType(Me.OPERACIONES_LOGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNGuardar As Button
    Friend WithEvents TXTPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OPERACIONES_LOGDataSet As OPERACIONES_LOGDataSet
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents USUARIOSTableAdapter As OPERACIONES_LOGDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents TableAdapterManager As OPERACIONES_LOGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_USUARIO_RUS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_PASSWORD_RUS As TextBox
    Friend WithEvents BTN_GUARDAR_RUS As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_ID_SELECTOR As TextBox
    Friend WithEvents TXT_APELLIDO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_USUARIO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_THEME As ComboBox
    Friend WithEvents Label9 As Label
End Class
