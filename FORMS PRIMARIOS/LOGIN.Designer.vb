<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.LBLLogo1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLError = New System.Windows.Forms.Label()
        Me.LBLLogo = New System.Windows.Forms.LinkLabel()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.CheckRecordar = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LBLLogo1
        '
        Me.LBLLogo1.AutoSize = True
        Me.LBLLogo1.BackColor = System.Drawing.Color.Transparent
        Me.LBLLogo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLLogo1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLogo1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBLLogo1.Location = New System.Drawing.Point(510, 143)
        Me.LBLLogo1.Name = "LBLLogo1"
        Me.LBLLogo1.Size = New System.Drawing.Size(49, 25)
        Me.LBLLogo1.TabIndex = 13
        Me.LBLLogo1.Text = "Lite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(419, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Soluciones a medida"
        '
        'LBLError
        '
        Me.LBLError.AutoSize = True
        Me.LBLError.BackColor = System.Drawing.Color.Transparent
        Me.LBLError.ForeColor = System.Drawing.Color.Red
        Me.LBLError.Location = New System.Drawing.Point(419, 301)
        Me.LBLError.Name = "LBLError"
        Me.LBLError.Size = New System.Drawing.Size(163, 13)
        Me.LBLError.TabIndex = 14
        Me.LBLError.Text = "Usuario o contraseña incorrectos"
        Me.LBLError.Visible = False
        '
        'LBLLogo
        '
        Me.LBLLogo.ActiveLinkColor = System.Drawing.Color.DarkSlateGray
        Me.LBLLogo.AutoSize = True
        Me.LBLLogo.BackColor = System.Drawing.Color.Transparent
        Me.LBLLogo.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLogo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LBLLogo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LBLLogo.Location = New System.Drawing.Point(441, 128)
        Me.LBLLogo.Name = "LBLLogo"
        Me.LBLLogo.Size = New System.Drawing.Size(77, 45)
        Me.LBLLogo.TabIndex = 12
        Me.LBLLogo.TabStop = True
        Me.LBLLogo.Text = "SGE"
        Me.LBLLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBLLogo.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(427, 254)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(147, 20)
        Me.Password.TabIndex = 9
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Usuario
        '
        Me.Usuario.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Usuario.Location = New System.Drawing.Point(427, 228)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(147, 20)
        Me.Usuario.TabIndex = 8
        Me.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BackgroundImage = Global.REDES.My.Resources.Resources.BTNGRAL_DEFAULT
        Me.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.Location = New System.Drawing.Point(437, 335)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(122, 33)
        Me.BtnIngresar.TabIndex = 11
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'CheckRecordar
        '
        Me.CheckRecordar.AutoSize = True
        Me.CheckRecordar.BackColor = System.Drawing.Color.Transparent
        Me.CheckRecordar.Location = New System.Drawing.Point(465, 281)
        Me.CheckRecordar.Name = "CheckRecordar"
        Me.CheckRecordar.Size = New System.Drawing.Size(70, 17)
        Me.CheckRecordar.TabIndex = 10
        Me.CheckRecordar.Text = "Recordar"
        Me.CheckRecordar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.REDES.My.Resources.Resources.LoginFondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1013, 522)
        Me.Controls.Add(Me.LBLLogo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLError)
        Me.Controls.Add(Me.LBLLogo)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.CheckRecordar)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLLogo1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLError As Label
    Friend WithEvents LBLLogo As LinkLabel
    Friend WithEvents Password As TextBox
    Friend WithEvents Usuario As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents CheckRecordar As CheckBox
End Class
