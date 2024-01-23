Imports System.IO
Public Class ABOUT
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("C:\DOCUMENTOS\USUARIO\VERSION.TXT") = False Then
            File.Create("C:\DOCUMENTOS\USUARIO\VERSION.TXT").Dispose()
        End If
        Label2.Text = File.ReadAllText("C:\DOCUMENTOS\USUARIO\VERSION.TXT")
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NOTASVERS.Show(Me)
    End Sub
End Class