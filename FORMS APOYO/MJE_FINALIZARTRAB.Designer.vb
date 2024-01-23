<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MJE_FINALIZARTRAB
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
        Me.BOT_CANCELAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MENSAJE = New System.Windows.Forms.Label()
        Me.DETALLE = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOT_CANCELAR
        '
        Me.BOT_CANCELAR.BackColor = System.Drawing.Color.White
        Me.BOT_CANCELAR.FlatAppearance.BorderSize = 2
        Me.BOT_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BOT_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BOT_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOT_CANCELAR.ForeColor = System.Drawing.Color.Red
        Me.BOT_CANCELAR.Location = New System.Drawing.Point(325, 150)
        Me.BOT_CANCELAR.Name = "BOT_CANCELAR"
        Me.BOT_CANCELAR.Size = New System.Drawing.Size(127, 38)
        Me.BOT_CANCELAR.TabIndex = 0
        Me.BOT_CANCELAR.Text = "Cancelar"
        Me.BOT_CANCELAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(32, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Finalizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 68)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MENSAJE
        '
        Me.MENSAJE.BackColor = System.Drawing.Color.Silver
        Me.MENSAJE.ForeColor = System.Drawing.Color.White
        Me.MENSAJE.Location = New System.Drawing.Point(26, 9)
        Me.MENSAJE.Name = "MENSAJE"
        Me.MENSAJE.Size = New System.Drawing.Size(438, 42)
        Me.MENSAJE.TabIndex = 3
        Me.MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DETALLE
        '
        Me.DETALLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DETALLE.Location = New System.Drawing.Point(26, 70)
        Me.DETALLE.Multiline = True
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.Size = New System.Drawing.Size(438, 60)
        Me.DETALLE.TabIndex = 4
        '
        'MJE_FINALIZARTRAB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.DETALLE)
        Me.Controls.Add(Me.MENSAJE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BOT_CANCELAR)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MJE_FINALIZARTRAB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BOT_CANCELAR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MENSAJE As Label
    Friend WithEvents DETALLE As TextBox
End Class
