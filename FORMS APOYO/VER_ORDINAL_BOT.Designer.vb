<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VER_ORDINAL_BOT
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
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.LBL_ORDINAL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_SALIR.BackgroundImage = Global.REDES.My.Resources.Resources.logout
        Me.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR.FlatAppearance.BorderSize = 0
        Me.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SALIR.Location = New System.Drawing.Point(1298, 12)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(40, 40)
        Me.BTN_SALIR.TabIndex = 267
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'LBL_ORDINAL
        '
        Me.LBL_ORDINAL.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBL_ORDINAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_ORDINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ORDINAL.ForeColor = System.Drawing.Color.Silver
        Me.LBL_ORDINAL.Location = New System.Drawing.Point(0, 0)
        Me.LBL_ORDINAL.Name = "LBL_ORDINAL"
        Me.LBL_ORDINAL.Size = New System.Drawing.Size(1278, 61)
        Me.LBL_ORDINAL.TabIndex = 268
        Me.LBL_ORDINAL.Text = "Label1"
        Me.LBL_ORDINAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VER_ORDINAL_BOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 61)
        Me.Controls.Add(Me.LBL_ORDINAL)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VER_ORDINAL_BOT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDINAL RUS"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents LBL_ORDINAL As Label
End Class
