
Public Class VER_ORDINAL_BOT
    Private Sub VER_ORDINAL_BOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        Size = New Size(My.Computer.Screen.WorkingArea.Width, 100)
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If DATOS.driver IsNot Nothing Then
            DATOS.driver.Quit()
            DATOS.driver.Dispose()
            DATOS.driver = Nothing
        End If
        Dispose()
        Close()
    End Sub
End Class