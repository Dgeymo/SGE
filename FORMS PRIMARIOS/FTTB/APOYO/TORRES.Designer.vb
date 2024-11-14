<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TORRES
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
        Me.BTN_CONFIRMAR = New System.Windows.Forms.Button()
        Me.LBL_DIRECCION = New System.Windows.Forms.Label()
        Me.TXT_ACOMETIDA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_UBICACION_NAP = New System.Windows.Forms.TextBox()
        Me.CB_TORRES = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTN_CONFIRMAR
        '
        Me.BTN_CONFIRMAR.Location = New System.Drawing.Point(437, 190)
        Me.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR"
        Me.BTN_CONFIRMAR.Size = New System.Drawing.Size(89, 43)
        Me.BTN_CONFIRMAR.TabIndex = 0
        Me.BTN_CONFIRMAR.Text = "CONFIRMAR"
        Me.BTN_CONFIRMAR.UseVisualStyleBackColor = True
        '
        'LBL_DIRECCION
        '
        Me.LBL_DIRECCION.AutoSize = True
        Me.LBL_DIRECCION.Location = New System.Drawing.Point(28, 13)
        Me.LBL_DIRECCION.Name = "LBL_DIRECCION"
        Me.LBL_DIRECCION.Size = New System.Drawing.Size(39, 13)
        Me.LBL_DIRECCION.TabIndex = 1
        Me.LBL_DIRECCION.Text = "Label1"
        '
        'TXT_ACOMETIDA
        '
        Me.TXT_ACOMETIDA.Location = New System.Drawing.Point(107, 57)
        Me.TXT_ACOMETIDA.Name = "TXT_ACOMETIDA"
        Me.TXT_ACOMETIDA.Size = New System.Drawing.Size(46, 20)
        Me.TXT_ACOMETIDA.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ACOMETIDA   A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TORRES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "UBICACION NAP"
        '
        'TXT_UBICACION_NAP
        '
        Me.TXT_UBICACION_NAP.Location = New System.Drawing.Point(107, 148)
        Me.TXT_UBICACION_NAP.Name = "TXT_UBICACION_NAP"
        Me.TXT_UBICACION_NAP.Size = New System.Drawing.Size(185, 20)
        Me.TXT_UBICACION_NAP.TabIndex = 6
        '
        'CB_TORRES
        '
        Me.CB_TORRES.FormattingEnabled = True
        Me.CB_TORRES.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_TORRES.Location = New System.Drawing.Point(107, 102)
        Me.CB_TORRES.Name = "CB_TORRES"
        Me.CB_TORRES.Size = New System.Drawing.Size(75, 21)
        Me.CB_TORRES.TabIndex = 8
        Me.CB_TORRES.Text = "1"
        '
        'TORRES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 266)
        Me.Controls.Add(Me.CB_TORRES)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_UBICACION_NAP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_ACOMETIDA)
        Me.Controls.Add(Me.LBL_DIRECCION)
        Me.Controls.Add(Me.BTN_CONFIRMAR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TORRES"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIFICIO CONFORME A OBRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CONFIRMAR As Button
    Friend WithEvents LBL_DIRECCION As Label
    Friend WithEvents TXT_ACOMETIDA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_UBICACION_NAP As TextBox
    Friend WithEvents CB_TORRES As ComboBox
End Class
