<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_NOTIFICACION
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
        Me.LBL_ASUNTO = New System.Windows.Forms.Label()
        Me.LBL_INICIALES = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LBL_ASUNTO
        '
        Me.LBL_ASUNTO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ASUNTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_ASUNTO.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ASUNTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_ASUNTO.Location = New System.Drawing.Point(69, 10)
        Me.LBL_ASUNTO.Name = "LBL_ASUNTO"
        Me.LBL_ASUNTO.Size = New System.Drawing.Size(219, 42)
        Me.LBL_ASUNTO.TabIndex = 5
        Me.LBL_ASUNTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_INICIALES
        '
        Me.LBL_INICIALES.BackColor = System.Drawing.Color.Transparent
        Me.LBL_INICIALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_INICIALES.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INICIALES.ForeColor = System.Drawing.Color.White
        Me.LBL_INICIALES.Location = New System.Drawing.Point(13, 15)
        Me.LBL_INICIALES.Name = "LBL_INICIALES"
        Me.LBL_INICIALES.Size = New System.Drawing.Size(49, 32)
        Me.LBL_INICIALES.TabIndex = 4
        Me.LBL_INICIALES.Text = "SYS"
        Me.LBL_INICIALES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'F_NOTIFICACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.REDES.My.Resources.Resources.STICK_NOTIF
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(300, 62)
        Me.Controls.Add(Me.LBL_ASUNTO)
        Me.Controls.Add(Me.LBL_INICIALES)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(10, -50)
        Me.Name = "F_NOTIFICACION"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_NOTIFICACION"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBL_ASUNTO As Label
    Friend WithEvents LBL_INICIALES As Label
    Friend WithEvents Timer1 As Timer
End Class
