<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GEO
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
        Me.NAVEGADOR = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.NAVEGADOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NAVEGADOR
        '
        Me.NAVEGADOR.AllowExternalDrop = True
        Me.NAVEGADOR.CreationProperties = Nothing
        Me.NAVEGADOR.DefaultBackgroundColor = System.Drawing.Color.White
        Me.NAVEGADOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NAVEGADOR.Location = New System.Drawing.Point(0, 0)
        Me.NAVEGADOR.Name = "NAVEGADOR"
        Me.NAVEGADOR.Size = New System.Drawing.Size(462, 482)
        Me.NAVEGADOR.TabIndex = 0
        Me.NAVEGADOR.ZoomFactor = 1.0R
        '
        'GEO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 482)
        Me.Controls.Add(Me.NAVEGADOR)
        Me.Name = "GEO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GEO"
        CType(Me.NAVEGADOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NAVEGADOR As Microsoft.Web.WebView2.WinForms.WebView2
End Class
