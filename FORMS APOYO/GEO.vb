Public Class GEO
    Private Sub GEO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim URL As String = "https://www.google.com.uy/maps/place/" & DIRECCION_GEO & ",+11800+Montevideo,+Departamento+de+Montevideo"
        NAVEGADOR.Source = New Uri(URL)
        DIRECCION_GEO = ""
    End Sub
    Public Sub ACTUALIZAR_GEO()
        NAVEGADOR.Source = New Uri("https://www.google.com.uy/maps/place/" & DIRECCION_GEO)
        DIRECCION_GEO = ""
    End Sub
End Class