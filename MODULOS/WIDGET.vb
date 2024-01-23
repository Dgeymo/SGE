Module WIDGET
    Dim BTN_GESTION(60) As Button
    Public Sub CREAR_GESTION(ByVal FONDO As Panel, ByVal POS_X As Integer, ByVal POS_Y As Integer, ByVal X As Integer, ByVal BORDER As Color, ByVal SIZE_W As Integer, ByVal SIZE_H As Integer)
        BTN_GESTION(X) = New Button()
        BTN_GESTION(X).Size = New Size(SIZE_W, SIZE_H)
        BTN_GESTION(X).Location = New Point(POS_X, POS_Y)
        BTN_GESTION(X).FlatStyle = FlatStyle.Flat
        BTN_GESTION(X).FlatAppearance.BorderSize = 1
        BTN_GESTION(X).FlatAppearance.BorderSize = 1
        BTN_GESTION(X).FlatAppearance.BorderColor = BORDER
        FONDO.Controls.Add(BTN_GESTION(X))

    End Sub
End Module
