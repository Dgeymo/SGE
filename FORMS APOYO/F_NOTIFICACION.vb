Public Class F_NOTIFICACION
    Dim TIEMPO As Integer = 0
    Private Sub NOTIFICACION_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, -50)
        For Y = 0 To 65 Step 0.5
            Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, Y - 50)
            Refresh()
        Next
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TIEMPO = 3 Then
            For Y = 65 To 0 Step -0.5
                Location = New Point((My.Computer.Screen.WorkingArea.Width - Size.Width) / 2, Y - 50)
                Visible = True
                Refresh()
            Next
            Timer1.Enabled = True
            Close()
            Dispose()
        End If
        TIEMPO += 1
    End Sub
    Private Sub F_NOTIFICACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = False
    End Sub
End Class