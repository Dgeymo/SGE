Public Class GRAF_GESTION

    ''VARIABLES DE POSICIONAMIENTO DEL MOUSE
    'Dim POSX As Integer
    'Dim POSY As Integer

    'Dim POSX_GRAF As Integer                'VARIABLE GENERICA PARA DIBUJAR LOS FERIADOS GRISES SOBRE EL FONSO
    'Dim POSX_FER As Integer                 'VARIABLE GENERICA PARA DIBUJAR LOS FERIADOS VERDES SOBRE LA ESCALA
    'Dim POSY_GRAF As Integer
    'Dim POS_ORD As Integer

    ''VARIABLES DE DIBUJO
    ''Dim LINEABLANCA As New Pen(Color.White, 1)
    ''Dim LINEAGRIS1 As New Pen(Color.LightGray, 1)
    ''Dim LINEAGRIS2 As New Pen(Color.Silver, 1)
    ''Dim LINEAGRIS3 As New Pen(Color.DarkGray, 1)
    ''Dim LINEAGRIS4 As New Pen(Color.Gray, 1)
    ''Dim LINEAGRIS5 As New Pen(Color.DimGray, 1)
    ''Dim FERIADO As New Pen(Color.LightGray, 15)
    ''Dim HOY As New Pen(Color.LightGreen, 15)
    ''Dim LABORABLE As New Pen(Color.DarkGreen, 6)
    ''Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    ''Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    ''Dim LINEAORDEN As New Pen(Color.Green, 3)
    ''Dim INICIADO As New Pen(Color.Khaki, 12)
    ''Dim AGENDADO As New Pen(Color.DimGray, 12)
    ''Dim FINALTRAB As New Pen(Color.Coral, 12)
    ''Dim FINALORD As New Pen(Color.LimeGreen, 12)
    ''Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    ''Dim DEMORADO As New Pen(Color.Purple, 12)


    'Dim POSH As Integer
    'Dim POSV As Integer


    'Dim BASE_ORDEN As New Pen(Color.PapayaWhip, 19)
    'Dim BASE_ETIQUETAS As New Pen(Color.Black, 19)

    ''PARAMETROS DE DIBUJO
    'Dim ALTO_BANNER As Integer              'ALTO DEL BANNER SUPERIOR DE CARGA DE DATOS,GRILLA ETC
    'Dim ALTO_ESCALA As Integer              'ALTO DE LA ESCALA INDICADORA DE DIAS 
    'Dim FONDO_ANCHO As Integer              'ANCHO DEL FONDE DE PANTALLA DEL GRAFICO
    'Dim FONDO_ALTO As Integer               'ALTO DEL FONDO DE PANTALLA DEL GRAFICO
    'Dim ANCHO_DIAS As Integer               'DEFINICION DE ANCHO DEL DIA DE DIBUJO
    'Dim ALTO_ORDENES As Integer             'DEFINICION DE ALTO DE CADA ORDEN
    'Dim ANCHO_ETIQUETAS As Integer          'ANCHO EN  DE LAS ETIQUETAS DESCRIPTIVAS DE LAS ORDENES
    'Dim ESCALA_ANCHO As Integer             'ANCHO DE LAS ESCALA DE DIAS

    'Dim MARGEN_IZQUIERDO As Integer         'MARGEN IZQUIERDO SIN DIBUJAR
    'Dim MARGEN_DERECHO As Integer           'MARGEN DERECHO SIN DIBUJAR
    'Dim MARGEN_SUPERIOR As Integer          'MARGEN SUPERIOR SIN DIBUJAR
    'Dim MARGEN_INFERIOR As Integer          'MARGEN INFERIOR SIN DIBUJAR

    'Dim ESCALA_POSX As Integer              'POSICION X DE LA ESCALA DE DIAS
    'Dim ESCALA_POSY As Integer              'POSICION Y DE LA ESCALA DE DIAS
    'Dim FONDO_POSX As Integer               'POSICION EN X DE LA BASE DEL GRAFICO (0,0) Superior izquierda
    'Dim FONDO_POSY As Integer               'POSICION EN Y DE LA BASE DEL GRAFICO (0,0) Superior izquierda , PANTALLA ES (0,0)
    'Dim ETIQUETA_POSX As Integer            'POSICION EN X DEL INICIO DE ETOQUETAS
    'Dim ETIQUETA_POSY As Integer            'POSICION EN Y DEL INICIO DE ETOQUETAS

    ''COORDENADAS DE GRAFICOS DE ORDENES/TRABAJOS
    'Dim ARRIBA_IZQX As Integer
    'Dim ARRIBA_IZQY As Integer
    'Dim ARRIBA_DERX As Integer
    'Dim ARRIBA_DERY As Integer

    'Dim ABAJO_IZQX As Integer
    'Dim ABAJO_IZQY As Integer
    'Dim ABAJO_DERX As Integer
    'Dim ABAJO_DERY As Integer

    'Dim I As Integer
    'Dim POS_LINEAGRAF As Integer            'ESTA VARIABLE INDICA LA POSICION DE LA LINEA EN EL DIBUJO DEL GRAFICO EN LA PANTALLA

    ''VARIABLES DE CONFORMACION DE PANTALLA
    'Dim CANT_DIAS As Integer
    'Dim CANT_ORDENES As Integer

    ''VARIABLES DE CALCULA
    'Dim DIA(120, 2) As Integer
    'Dim CALC_FECHAGRAF As Date

    'Dim LABELARRAY(300) As Label
    'Dim NODO_TRAB(300) As Label
    'Dim ZONA_TRAB(300) As Label


    'Private Sub CALCULA_VARGRAF()
    '    'FIJA LA POSICION DE LAS ETIQUETAS
    '    ETIQUETA_POSX = MARGEN_IZQUIERDO
    '    ETIQUETA_POSY = MARGEN_SUPERIOR + ALTO_BANNER + ALTO_ESCALA
    '    'FIJA LA POSICION DEL FONDO
    '    FONDO_POSX = MARGEN_IZQUIERDO + ANCHO_ETIQUETAS
    '    FONDO_POSY = MARGEN_SUPERIOR + ALTO_BANNER + ALTO_ESCALA
    '    'ESTABLECE UN LIMITE DE DIBUJO DEL FONDO Y ESCALA EN ANCHO
    '    If CANT_DIAS * ANCHO_DIAS + ANCHO_ETIQUETAS + MARGEN_IZQUIERDO < 1366 - MARGEN_DERECHO Then
    '        FONDO_ANCHO = CANT_DIAS * ANCHO_DIAS
    '    Else
    '        FONDO_ANCHO = 1366 - MARGEN_DERECHO - MARGEN_IZQUIERDO - ANCHO_ETIQUETAS
    '        CANT_DIAS = FONDO_ANCHO / ANCHO_DIAS
    '    End If
    '    'ESTABLECE UN LIMITE DE DIBUJO DEL FONDO Y ESCALA EN ALTO
    '    If CANT_ORDENES * ALTO_ORDENES + ALTO_BANNER + ALTO_ESCALA + MARGEN_SUPERIOR + ALTO_ORDENES / 2 < 768 - MARGEN_INFERIOR Then
    '        FONDO_ALTO = CANT_ORDENES * ALTO_ORDENES
    '    Else
    '        FONDO_ALTO = 768 - MARGEN_INFERIOR - ALTO_ESCALA - ALTO_BANNER - MARGEN_SUPERIOR - ALTO_ORDENES / 2
    '        CANT_ORDENES = FONDO_ALTO / ALTO_ORDENES
    '    End If
    '    'FIJA LA POSICION DE LA ESCALA
    '    ESCALA_POSX = MARGEN_IZQUIERDO + ANCHO_ETIQUETAS
    '    ESCALA_POSY = MARGEN_SUPERIOR + ALTO_BANNER
    '    ESCALA_ANCHO = FONDO_ANCHO

    '    DIAS.Location = New Point(ESCALA_POSX - 4, ESCALA_POSY + 10)

    'End Sub
    'Private Sub GRAF_GESTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Cursor = Cursors.WaitCursor
    '    ALTO_ESCALA = 40
    '    ANCHO_DIAS = 15
    '    ALTO_ORDENES = 19
    '    ALTO_BANNER = 80

    '    MARGEN_IZQUIERDO = 10
    '    MARGEN_DERECHO = 40
    '    MARGEN_SUPERIOR = 10
    '    MARGEN_INFERIOR = 40

    '    ANCHO_ETIQUETAS = 220
    '    CALC_FECHAGRAF = GRAF_FECHAINIGRAFICO

    '    CANT_ORDENES = 35   'ESPECIFICA EL CICLO QUE RECOORE PARA DIBUJAR Y COLOCAR ETIQUETAS 
    '    CANT_DIAS = 100     'ESPECIFICA EL ANCHO DE DIBUJO (DENTRO DE LOS LIMITES) EN X

    '    CALCULA_VARGRAF()




    '    Cursor = DefaultCursor
    'End Sub



    'Private Sub DIBUJA_ELEMENTO_PROGRAMADO()

    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()
    '    Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    '    Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    '    Dim LINEAORDEN As New Pen(Color.Green, 3)
    '    Dim INICIADO As New Pen(Color.Khaki, 12)
    '    Dim AGENDADO As New Pen(Color.DimGray, 12)
    '    Dim FINALTRAB As New Pen(Color.Coral, 12)
    '    Dim FINALORD As New Pen(Color.LimeGreen, 12)
    '    Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    '    Dim DEMORADO As New Pen(Color.Purple, 12)
    '    Dim ESTRICTA As New Pen(Color.Red, 3)
    '    Dim DINAMICA As New Pen(Color.DarkBlue, 3)
    '    Dim COORDX_INICIO As Integer
    '    Dim COORDX_FIN As Integer

    '    'DIBUJA ELEMENTO PROGRAMADO
    '    COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINIESTIMADO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    COORDX_FIN = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAFINESTIMADO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS

    '    If COORDX_INICIO >= FONDO_POSX Then ARRIBA_IZQX = COORDX_INICIO Else ARRIBA_IZQX = FONDO_POSX
    '    ARRIBA_DERX = COORDX_FIN
    '    ARRIBA_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES
    '    ARRIBA_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES

    '    If COORDX_INICIO >= FONDO_POSX Then ABAJO_IZQX = COORDX_INICIO Else ABAJO_IZQX = FONDO_POSX
    '    ABAJO_DERX = COORDX_FIN
    '    ABAJO_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES
    '    ABAJO_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES

    '    If ABAJO_IZQY < 768 - MARGEN_INFERIOR And ARRIBA_IZQY >= FONDO_POSY Then
    '        Select Case GRAF_CLASE(I)
    '            Case "TRABAJO"
    '                'HORIZONTALES
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEATRABAJO, ARRIBA_IZQX, ARRIBA_IZQY, ARRIBA_DERX, ARRIBA_DERY)
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEATRABAJO, ABAJO_IZQX, ABAJO_IZQY, ABAJO_DERX, ABAJO_DERY)
    '                'VERTICALES
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEATRABAJO, ARRIBA_IZQX + 1, ARRIBA_IZQY, ARRIBA_IZQX + 1, ABAJO_IZQY)
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEATRABAJO, ARRIBA_DERX - 2, ARRIBA_DERY, ARRIBA_DERX - 2, ABAJO_DERY)
    '            Case "ORDEN"
    '                'HORIZONTALES
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAORDEN, ARRIBA_IZQX, ARRIBA_IZQY, ARRIBA_DERX, ARRIBA_DERY)
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAORDEN, ABAJO_IZQX, ABAJO_IZQY, ABAJO_DERX, ABAJO_DERY)
    '                'VERTICALES
    '                Select Case GRAF_CLASEDEP(I)
    '                    Case "EST"
    '                        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(ESTRICTA, ARRIBA_IZQX + 1, ARRIBA_IZQY, ARRIBA_IZQX + 1, ABAJO_IZQY)
    '                    Case "DIN"
    '                        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(DINAMICA, ARRIBA_IZQX + 1, ARRIBA_IZQY, ARRIBA_IZQX + 1, ABAJO_IZQY)
    '                    Case "IND"
    '                        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAORDEN, ARRIBA_IZQX + 1, ARRIBA_IZQY, ARRIBA_IZQX + 1, ABAJO_IZQY)
    '                End Select
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAORDEN, ARRIBA_DERX - 2, ARRIBA_DERY, ARRIBA_DERX - 2, ABAJO_DERY)

    '            Case "GESTION"
    '                'HORIZONTALES
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAGESTION, ARRIBA_IZQX, ARRIBA_IZQY, ARRIBA_DERX, ARRIBA_DERY)
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAGESTION, ABAJO_IZQX, ABAJO_IZQY, ABAJO_DERX, ABAJO_DERY)
    '                'VERTICALES
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAGESTION, ARRIBA_IZQX + 1, ARRIBA_IZQY, ARRIBA_IZQX + 1, ABAJO_IZQY)
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(LINEAGESTION, ARRIBA_DERX - 2, ARRIBA_DERY, ARRIBA_DERX - 2, ABAJO_DERY)
    '        End Select
    '    End If
    'End Sub

    'Private Sub DIBUJA_ELEMENTO_INICIADO()

    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()
    '    Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    '    Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    '    Dim LINEAORDEN As New Pen(Color.Green, 3)
    '    Dim INICIADO As New Pen(Color.Khaki, 12)
    '    Dim AGENDADO As New Pen(Color.DimGray, 12)
    '    Dim FINALTRAB As New Pen(Color.Coral, 12)
    '    Dim FINALORD As New Pen(Color.LimeGreen, 12)
    '    Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    '    Dim DEMORADO As New Pen(Color.Purple, 12)
    '    Dim COORDX_INICIO As Integer
    '    Dim COORDX_FIN As Integer

    '    'DIBUJA ELEMENTO INICIADO
    '    COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINICIO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    COORDX_FIN = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, Now.Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    'MsgBox(COORDX_INICIO)
    '    'MsgBox(COORDX_FIN)

    '    If COORDX_INICIO >= FONDO_POSX Then ARRIBA_IZQX = COORDX_INICIO Else ARRIBA_IZQX = FONDO_POSX
    '    ARRIBA_DERX = COORDX_FIN
    '    ARRIBA_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES
    '    ARRIBA_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES

    '    If COORDX_INICIO >= FONDO_POSX Then ABAJO_IZQX = COORDX_INICIO Else ABAJO_IZQX = FONDO_POSX
    '    ABAJO_DERX = COORDX_FIN
    '    ABAJO_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES
    '    ABAJO_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES

    '    If ABAJO_IZQY < 768 - MARGEN_INFERIOR And ARRIBA_IZQY >= FONDO_POSY Then
    '        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(INICIADO, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '    End If
    'End Sub

    'Private Sub DIBUJA_ELEMENTO_DEMORADO()
    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()
    '    Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    '    Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    '    Dim LINEAORDEN As New Pen(Color.Green, 3)
    '    Dim INICIADO As New Pen(Color.Khaki, 12)
    '    Dim AGENDADO As New Pen(Color.DimGray, 12)
    '    Dim FINALTRAB As New Pen(Color.Coral, 12)
    '    Dim FINALORD As New Pen(Color.LimeGreen, 12)
    '    Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    '    Dim DEMORADO As New Pen(Color.Purple, 12)
    '    Dim COORDX_INICIO As Integer
    '    Dim COORDX_FIN As Integer

    '    'DIBUJA ELEMENTO DEMORADO
    '    COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINIESTIMADO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    COORDX_FIN = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAFINESTIMADO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    'MsgBox(COORDX_INICIO)
    '    'MsgBox(COORDX_FIN)


    '    If COORDX_INICIO >= FONDO_POSX Then ARRIBA_IZQX = COORDX_INICIO Else ARRIBA_IZQX = FONDO_POSX
    '    ARRIBA_DERX = COORDX_FIN
    '    ARRIBA_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES
    '    ARRIBA_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES

    '    If COORDX_INICIO >= FONDO_POSX Then ABAJO_IZQX = COORDX_INICIO Else ABAJO_IZQX = FONDO_POSX
    '    ABAJO_DERX = COORDX_FIN
    '    ABAJO_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES
    '    ABAJO_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES

    '    If ABAJO_IZQY < 768 - MARGEN_INFERIOR And ARRIBA_IZQY >= FONDO_POSY Then
    '        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(DEMORADO, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '    End If


    'End Sub

    'Private Sub DIBUJA_ELEMENTO_AGENDADO()
    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()
    '    Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    '    Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    '    Dim LINEAORDEN As New Pen(Color.Green, 3)
    '    Dim INICIADO As New Pen(Color.Khaki, 12)
    '    Dim AGENDADO As New Pen(Color.DimGray, 12)
    '    Dim FINALTRAB As New Pen(Color.Coral, 12)
    '    Dim FINALORD As New Pen(Color.LimeGreen, 12)
    '    Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    '    Dim DEMORADO As New Pen(Color.Purple, 12)
    '    Dim COORDX_INICIO As Integer
    '    Dim COORDX_FIN As Integer

    '    'DIBUJA ELEMENTO AGENDADO
    '    COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINIESTIMADO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    COORDX_FIN = DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAFINESTIMADO(I).Date) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS


    '    If COORDX_INICIO >= FONDO_POSX Then ARRIBA_IZQX = COORDX_INICIO Else ARRIBA_IZQX = FONDO_POSX
    '    ARRIBA_DERX = COORDX_FIN
    '    ARRIBA_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES
    '    ARRIBA_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES

    '    If COORDX_INICIO >= FONDO_POSX + 1 Then ABAJO_IZQX = COORDX_INICIO Else ABAJO_IZQX = FONDO_POSX
    '    ABAJO_DERX = COORDX_FIN
    '    ABAJO_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES
    '    ABAJO_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES

    '    If ABAJO_IZQY < 768 - MARGEN_INFERIOR And ARRIBA_IZQY >= FONDO_POSY Then
    '        If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(AGENDADO, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '    End If
    'End Sub

    'Private Sub DIBUJA_ELEMENTO_FINALIZADO()

    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()
    '    Dim LINEAGESTION As New Pen(Color.CornflowerBlue, 3)
    '    Dim LINEATRABAJO As New Pen(Color.OrangeRed, 3)
    '    Dim LINEAORDEN As New Pen(Color.Green, 3)
    '    Dim INICIADO As New Pen(Color.Khaki, 12)
    '    Dim AGENDADO As New Pen(Color.DimGray, 12)
    '    Dim FINALTRAB As New Pen(Color.Coral, 12)
    '    Dim FINALORD As New Pen(Color.LimeGreen, 12)
    '    Dim FINALGESTION As New Pen(Color.SkyBlue, 12)
    '    Dim DEMORADO As New Pen(Color.Purple, 12)
    '    Dim COORDX_INICIO As Integer
    '    Dim COORDX_FIN As Integer

    '    'DIBUJA ELEMENTO FINALIZADO
    '    If GRAF_FECHAFINALIZADO(I).Date <> GRAF_FECHAINICIO(I).Date Then
    '        COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINICIO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '        COORDX_FIN = COORDX_INICIO + ANCHO_DIAS
    '    Else
    '        COORDX_INICIO = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAINICIO(I).Date)) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '        COORDX_FIN = (DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, GRAF_FECHAFINALIZADO(I).Date) + 1) * ANCHO_DIAS + ETIQUETA_POSX + ANCHO_ETIQUETAS
    '    End If

    '    If COORDX_INICIO >= FONDO_POSX Then ARRIBA_IZQX = COORDX_INICIO Else ARRIBA_IZQX = FONDO_POSX
    '    ARRIBA_DERX = COORDX_FIN
    '    ARRIBA_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES
    '    ARRIBA_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + 2 + POSV * ALTO_ORDENES

    '    If COORDX_INICIO >= FONDO_POSX Then ABAJO_IZQX = COORDX_INICIO Else ABAJO_IZQX = FONDO_POSX
    '    ABAJO_DERX = COORDX_FIN
    '    ABAJO_IZQY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES
    '    ABAJO_DERY = ETIQUETA_POSY + (I - 1) * ALTO_ORDENES + (ALTO_ORDENES - 2) + POSV * ALTO_ORDENES

    '    If ABAJO_IZQY < 768 - MARGEN_INFERIOR And ARRIBA_IZQY >= FONDO_POSY Then
    '        Select Case GRAF_CLASE(I)
    '            Case "TRABAJO"
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(FINALTRAB, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '            Case "ORDEN"
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(FINALORD, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '            Case "GESTION"
    '                If ARRIBA_DERX > FONDO_POSX Then GRILLA.DrawLine(FINALGESTION, ARRIBA_IZQX + 1, ARRIBA_IZQY + 8, ARRIBA_DERX, ARRIBA_IZQY + 8)
    '        End Select
    '    End If
    'End Sub

    'Private Sub DIBUJA_ETIQUETAS()


    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()

    '    For J = 1 To GRAF_CANTIDADFILAS
    '        LABELARRAY(J) = New Label : NODO_TRAB(J) = New Label : ZONA_TRAB(J) = New Label

    '        LABELARRAY(J).Location = New Point(ETIQUETA_POSX + 1, ETIQUETA_POSY + (J - 1) * ALTO_ORDENES + 1)
    '        NODO_TRAB(J).Location = New Point(ETIQUETA_POSX + 121, ETIQUETA_POSY + (J - 1) * ALTO_ORDENES + 1)
    '        ZONA_TRAB(J).Location = New Point(ETIQUETA_POSX + 121 + 56, ETIQUETA_POSY + (J - 1) * ALTO_ORDENES + 1)
    '        NODO_TRAB(J).Width = 56
    '        ZONA_TRAB(J).Width = 40

    '        LABELARRAY(J).AutoSize = False : NODO_TRAB(J).AutoSize = False : ZONA_TRAB(J).AutoSize = False

    '        LABELARRAY(J).BackColor = Color.Black : NODO_TRAB(J).BackColor = Color.Black : ZONA_TRAB(J).BackColor = Color.Black
    '        Select Case GRAF_CLASE(J)
    '            Case "TRABAJO"
    '                LABELARRAY(J).Text = " " & GRAF_MOTIVO(J)
    '                NODO_TRAB(J).Text = "NODO: " & GRAF_NODOTRAB(J)
    '                ZONA_TRAB(J).Text = "Z: " & GRAF_ZONATRAB(J)

    '                LABELARRAY(J).Font = New Font("ARIAL", 7, FontStyle.Regular)
    '                NODO_TRAB(J).Font = New Font("ARIAL", 7, FontStyle.Regular)
    '                ZONA_TRAB(J).Font = New Font("ARIAL", 7, FontStyle.Regular)

    '                LABELARRAY(J).ForeColor = Color.Coral
    '                NODO_TRAB(J).ForeColor = Color.Coral
    '                ZONA_TRAB(J).ForeColor = Color.Coral
    '                LABELARRAY(J).Width = 120

    '            Case "ORDEN"
    '                LABELARRAY(J).Text = "   " & GRAF_MOTIVO(J)
    '                LABELARRAY(J).Font = New Font("ARIAL", 7, FontStyle.Regular)
    '                LABELARRAY(J).ForeColor = Color.LightGreen
    '                LABELARRAY(J).Width = ANCHO_ETIQUETAS - 8
    '            Case "GESTION"
    '                LABELARRAY(J).Text = GRAF_MOTIVO(J)
    '                LABELARRAY(J).Font = New Font("ARIAL", 7, FontStyle.Bold)
    '                LABELARRAY(J).ForeColor = Color.LightBlue
    '                LABELARRAY(J).Width = ANCHO_ETIQUETAS - 8
    '        End Select

    '        LABELARRAY(J).Height = 17
    '        NODO_TRAB(J).Height = 17
    '        ZONA_TRAB(J).Height = 17

    '        LABELARRAY(J).TextAlign = ContentAlignment.MiddleLeft
    '        NODO_TRAB(J).TextAlign = ContentAlignment.MiddleLeft
    '        ZONA_TRAB(J).TextAlign = ContentAlignment.MiddleRight

    '        LABELARRAY(J).BorderStyle = BorderStyle.None
    '        NODO_TRAB(J).BorderStyle = BorderStyle.None
    '        ZONA_TRAB(J).BorderStyle = BorderStyle.None
    '        'If J < GRAF_CANTIDADFILAS Then

    '        'Else
    '        'LABELARRAY(J).Text = ""
    '        'End If
    '        FONDO_GRAF.Controls.Add(LABELARRAY(J))
    '        FONDO_GRAF.Controls.Add(NODO_TRAB(J))
    '        FONDO_GRAF.Controls.Add(ZONA_TRAB(J))
    '    Next J


    'End Sub
    'Private Sub POSICIONA_ETIQUETAS()
    '    For R = 1 To GRAF_CANTIDADFILAS
    '        'DETERMINA LA POSICION DE LA ETIQUETA TOMANDO LA COORDENADA QUE TENDRA
    '        Dim POS_ETIQUETA = CInt(((ETIQUETA_POSY + (R - 1) * ALTO_ORDENES + 1 + POSV * ALTO_ORDENES) - MARGEN_SUPERIOR - ALTO_BANNER - ALTO_ESCALA) / ALTO_ORDENES)
    '        'CAMBIA LAUBICACION DE LA ETIQUETA
    '        LABELARRAY(R).Location = New Point(ETIQUETA_POSX + 1, ETIQUETA_POSY + (R - 1) * ALTO_ORDENES + 1 + POSV * ALTO_ORDENES)
    '        NODO_TRAB(R).Location = New Point(ETIQUETA_POSX + 124, ETIQUETA_POSY + (R - 1) * ALTO_ORDENES + 1 + POSV * ALTO_ORDENES)
    '        ZONA_TRAB(R).Location = New Point(ETIQUETA_POSX + 124 + 56, ETIQUETA_POSY + (R - 1) * ALTO_ORDENES + 1 + POSV * ALTO_ORDENES)

    '        'HACE LAS ETIQUETAS INVISIBLES DE ACUERDO A LA POSICION
    '        If POSV < 0 And R <= POSV * (-1) Then
    '            LABELARRAY(R).Visible = False
    '            NODO_TRAB(R).Visible = False
    '            ZONA_TRAB(R).Visible = False
    '        Else
    '            If POS_ETIQUETA >= CANT_ORDENES Then
    '                LABELARRAY(R).Visible = False
    '                NODO_TRAB(R).Visible = False
    '                ZONA_TRAB(R).Visible = False
    '            Else
    '                LABELARRAY(R).Visible = True
    '                NODO_TRAB(R).Visible = True
    '                ZONA_TRAB(R).Visible = True
    '            End If
    '        End If
    '    Next R
    'End Sub
    'Private Sub PROCESA_DATOS()
    '    I = 0
    '    For POS_LINEAGRAF = 1 To GRAF_CANTIDADFILAS     'BARRE EN Y LAS POSICIONES DE LAS LINEAS DEL DIBUJO DEL GRAFICO
    '        I = I + 1
    '        Select Case GRAF_STATUS(I)
    '            Case "COORDINADO", "RUTEADO", "AGENDADO"
    '                DIBUJA_ELEMENTO_AGENDADO()
    '            Case "INICIADO"
    '                DIBUJA_ELEMENTO_INICIADO()
    '            Case "FINALIZADO"
    '                DIBUJA_ELEMENTO_FINALIZADO()
    '            Case "DEMORADO"
    '                DIBUJA_ELEMENTO_DEMORADO()
    '        End Select
    '        DIBUJA_ELEMENTO_PROGRAMADO()
    '    Next POS_LINEAGRAF
    'End Sub


    'Private Sub FONDO_GRAF_MouseMove(sender As Object, e As MouseEventArgs) Handles FONDO_GRAF.MouseMove
    '    Dim POS_DIA As Integer
    '    Dim POS_ORDEN As Integer

    '    POSX = Control.MousePosition.X
    '    POSY = Control.MousePosition.Y

    '    POS_MOUSE.Text = "(" & POSX & "," & POSY & ")"

    '    If POSX > MARGEN_IZQUIERDO + ANCHO_ETIQUETAS Then
    '        POS_DIA = (((POSX - MARGEN_IZQUIERDO - ANCHO_ETIQUETAS) - 7) / ANCHO_DIAS)

    '        If POSY > FONDO_POSY And POSY < FONDO_POSY + FONDO_ALTO Then
    '            POS_ORDEN = (CInt(POSY - FONDO_POSY) / ALTO_ORDENES + 0.5 - POSV)
    '            Label21.Text = POS_ORDEN
    '            LBL_CLASE.Text = GRAF_CLASE(POS_ORDEN)
    '            LBL_FECHAING.Text = GRAF_FECHAINIGRAFICO.ToShortDateString
    '            LBL_FECHAINICIO.Text = GRAF_FECHAINICIO(POS_ORDEN).ToShortDateString
    '            LBL_INIESTIMADO.Text = GRAF_FECHAINIESTIMADO(POS_ORDEN).ToShortDateString
    '            LBL_FECHAAGENDA.Text = GRAF_FECHAAGENDADO(POS_ORDEN).ToShortDateString
    '            LBL_MOTIVO.Text = GRAF_MOTIVO(POS_ORDEN)
    '            LBL_CAUSA.Text = GRAF_CAUSA(POS_ORDEN)
    '            LBL_STATUS.Text = GRAF_STATUS(POS_ORDEN)
    '            LBL_FINESTIMADO.Text = GRAF_FECHAFINESTIMADO(POS_ORDEN).ToShortDateString
    '            LBL_DIRECCION.Text = Trim(GRAF_CALLE(POS_ORDEN)) & " " & GRAF_NRO(POS_ORDEN)
    '            LBL_NROGESTION.Text = GRAF_NROGESTION(POS_ORDEN)
    '            LBL_NROTRABAJO.Text = GRAF_NROTRABAJO(POS_ORDEN)
    '            LBL_NROORDENINT.Text = GRAF_NROORDEN(POS_ORDEN)
    '            LBL_ORDINAL.Text = GRAF_NROORDINAL(POS_ORDEN)
    '            LBL_FECHAFIN.Text = GRAF_FECHAFINALIZADO(POS_ORDEN).ToShortDateString
    '        End If

    '        SEL_DIAPOS.Text = POS_DIA
    '        SEL_DIANRO.Text = DateAdd(DateInterval.Day, POS_DIA, CALC_FECHAGRAF).ToLongDateString
    '        'SEL_DIASEM.Text = DateAdd(DateInterval.Day, POS_DIA, CALC_FECHAGRAF).DayOfWeek
    '        '    Select Case DateAdd(DateInterval.Day, POS_DIA, CALC_FECHAGRAF).DayOfWeek
    '        '        Case 1
    '        '            SEL_DIASEM.Text = "LUNES"
    '        '        Case 2
    '        '            SEL_DIASEM.Text = "MARTES"
    '        '        Case 3
    '        '            SEL_DIASEM.Text = "MIERCOLES"
    '        '        Case 4
    '        '            SEL_DIASEM.Text = "JUEVES"
    '        '        Case 5
    '        '            SEL_DIASEM.Text = "VIERNES"
    '        '        Case 6
    '        '            SEL_DIASEM.Text = "SABADO"
    '        '        Case 0
    '        '            SEL_DIASEM.Text = "DOMINGO"
    '        '    End Select
    '    End If
    'End Sub
    'Private Sub DIBUJA_GRAFFONDO()

    '    Dim GAP_Y As Integer
    '    Dim DIA_SEMANA As Integer
    '    Dim CALC_FERIADO As Integer
    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()

    '    Dim LINEABLANCA As New Pen(Color.White, 1)
    '    Dim LINEAGRIS1 As New Pen(Color.LightGray, 1)
    '    Dim LINEAGRIS2 As New Pen(Color.Silver, 1)
    '    Dim LINEAGRIS3 As New Pen(Color.DarkGray, 1)
    '    Dim LINEAGRIS4 As New Pen(Color.Gray, 1)
    '    Dim LINEAGRIS5 As New Pen(Color.DimGray, 1)
    '    Dim FERIADO As New Pen(Color.LightGray, 15)
    '    Dim HOY As New Pen(Color.LightGreen, 15)
    '    Dim LABORABLE As New Pen(Color.DarkGreen, 6)


    '    'DIBUJA LINEAS DE ORDENES BASICAS
    '    For I = 0 To CANT_ORDENES - 1
    '        GAP_Y = ALTO_ORDENES * I + CInt(ALTO_ORDENES / 2)
    '        GRILLA.DrawLine(BASE_ORDEN, FONDO_POSX, FONDO_POSY + GAP_Y, (FONDO_POSX + FONDO_ANCHO), FONDO_POSY + GAP_Y)
    '    Next I

    '    'DIBUJA LOS FERIADOS EN EL FONDO DE LA ZONA DE ORDENES___________________________________________________________________________________________________________
    '    'DIBUJA FERIADOS
    '    DIA_SEMANA = (CALC_FECHAGRAF).DayOfWeek
    '    'CALCULA LOS DIAS QUE FALTAN PARA LLEGAR AL PRIMER FERIADO
    '    CALC_FERIADO = (6 - DIA_SEMANA) * ANCHO_DIAS
    '    'DIA_SEMANA ES EL DIA DE LA SEMANA EN QUE INICA EL GRAFICO DEL FONDO Y DE LA ESCALA
    '    Select Case DIA_SEMANA
    '        Case 1, 2, 3, 4, 5
    '            'DETERMINA S = CANTIDAD DE DIAS HASTA QUE LLEGUE EL SABADO Y LLENA LA POSICION DEL GRAFICO PARA PINTAR A PARTIR DE ALLI LAS LINEAS GRISES
    '            'REORRE EL GRAFICO A LO ANCHO DESDE EL INICIO HASTA EL FINAL 
    '            For S = FONDO_POSX + CALC_FERIADO To FONDO_POSX + FONDO_ANCHO Step 7 * ANCHO_DIAS
    '                POSX_GRAF = S + ANCHO_DIAS / 2

    '                If POSX_GRAF + CALC_FERIADO <= FONDO_POSX + FONDO_ANCHO + ANCHO_DIAS Then
    '                    GRILLA.DrawLine(FERIADO, POSX_GRAF, FONDO_POSY, POSX_GRAF, (FONDO_POSY + FONDO_ALTO))
    '                    GRILLA.DrawLine(FERIADO, POSX_GRAF + ANCHO_DIAS, FONDO_POSY, POSX_GRAF + ANCHO_DIAS, (FONDO_POSY + FONDO_ALTO))
    '                End If
    '            Next S
    '        Case 6
    '            For S = FONDO_POSX To FONDO_POSX + FONDO_ANCHO Step 7 * ANCHO_DIAS
    '                'SITUA EL INICIO DEL GRAFICO EN LA POSICION DE INICIO (ES SABADO) Y REPITE CADA 7 DIAS
    '                POSX_GRAF = CInt(S + ANCHO_DIAS / 2)
    '                GRILLA.DrawLine(FERIADO, POSX_GRAF, FONDO_POSY, POSX_GRAF, FONDO_POSY + FONDO_ALTO)
    '                GRILLA.DrawLine(FERIADO, POSX_GRAF + ANCHO_DIAS, FONDO_POSY, POSX_GRAF + ANCHO_DIAS, FONDO_POSY + FONDO_ALTO)
    '            Next S
    '        Case 0
    '            For S = FONDO_POSX To FONDO_POSX + FONDO_ANCHO Step 7 * ANCHO_DIAS
    '                'SITUA EL INICIO DEL GRAFICO EN LA OSICION DE INICIO )ES DOMINGO) SOLO DEBE PINTAR UN DIA Y DESPUES DOS POR SEMANA
    '                POSX_GRAF = CInt(S + ANCHO_DIAS / 2)
    '                GRILLA.DrawLine(FERIADO, POSX_GRAF, FONDO_POSY, POSX_GRAF, FONDO_POSY + FONDO_ALTO)
    '                GRILLA.DrawLine(FERIADO, POSX_GRAF + 6 * ANCHO_DIAS, FONDO_POSY, POSX_GRAF + 6 * ANCHO_DIAS, FONDO_POSY + FONDO_ALTO)
    '            Next S
    '    End Select

    '    'MARCA EL DIA DE LA FECHA (HOY)
    '    Dim DIA_HOY As Integer
    '    DIA_HOY = DateDiff(DateInterval.Day, GRAF_FECHAINIGRAFICO.Date, Now.Date)
    '    If FONDO_POSX + DIA_HOY * ANCHO_DIAS > FONDO_POSX Then GRILLA.DrawLine(HOY, FONDO_POSX + DIA_HOY * ANCHO_DIAS + CInt(ANCHO_DIAS / 2), FONDO_POSY, FONDO_POSX + DIA_HOY * ANCHO_DIAS + CInt(ANCHO_DIAS / 2), (FONDO_POSY + FONDO_ALTO))

    '    'DIBUJA LINEAS VERTICALES EN FONDO
    '    'DIBUJA DIVISIONES

    '    'Dim DIA_SEM As Integer
    '    'Dim DIA_GRAF As String

    '    For I = 0 To CANT_DIAS
    '        If I * ANCHO_DIAS + ANCHO_ETIQUETAS + MARGEN_IZQUIERDO < 1366 - MARGEN_DERECHO Then
    '            GRILLA.DrawLine(LINEAGRIS2, FONDO_POSX + I * ANCHO_DIAS, FONDO_POSY, FONDO_POSX + I * ANCHO_DIAS, FONDO_POSY + FONDO_ALTO)
    '        End If
    '    Next I
    '    'DIBUJA LINEAS HORIZONTALES EN FONDO___________________________________________________________________________________________________
    '    For I = 0 To CANT_ORDENES - 1
    '        GAP_Y = ALTO_ORDENES * I
    '        GRILLA.DrawLine(LINEAGRIS3, FONDO_POSX, FONDO_POSY + GAP_Y, (FONDO_POSX + FONDO_ANCHO), FONDO_POSY + GAP_Y)
    '    Next I



    'End Sub

    'Private Sub DIBUJA_ESCALA()
    '    Dim DIA_SEMANA As Integer
    '    Dim CALC_FERIADO As Integer
    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()

    '    Dim LINEABLANCA As New Pen(Color.White, 1)
    '    Dim LINEAGRIS1 As New Pen(Color.LightGray, 1)
    '    Dim LINEAGRIS2 As New Pen(Color.Silver, 1)
    '    Dim LINEAGRIS3 As New Pen(Color.DarkGray, 1)
    '    Dim LINEAGRIS4 As New Pen(Color.Gray, 1)
    '    Dim LINEAGRIS5 As New Pen(Color.DimGray, 1)
    '    Dim FERIADO As New Pen(Color.LightGray, 15)
    '    Dim HOY As New Pen(Color.LightGreen, 15)
    '    Dim LABORABLE As New Pen(Color.DarkGreen, 6)

    '    Dim BORRAGRILLA As New Pen(Color.Black, ALTO_ESCALA - 2)

    '    'BORRA ESCALA (ESCALA_POSX ES SIEMPRE FIJO E INDICA EL PUNTO A PARTIR DEL QUE SE DUBUJAN LA ESCALA Y LOS GRAFICOS EN X)
    '    GRILLA.DrawLine(BORRAGRILLA, ESCALA_POSX, ESCALA_POSY + CInt(ALTO_ESCALA / 2), 1366, ESCALA_POSY + CInt(ALTO_ESCALA / 2))
    '    DIAS.Text = ""

    '    'DIBUJA LINEA HORIZONTAL DE ESCALA
    '    GRILLA.DrawLine(LINEABLANCA, ESCALA_POSX, ESCALA_POSY + 23, (ESCALA_POSX + FONDO_ANCHO), ESCALA_POSY + 23)

    '    'DIBUJA EL FONDO VERDE DE DIAS HABILES EN ESCALA
    '    DIA_SEMANA = (CALC_FECHAGRAF).DayOfWeek
    '    'CALCULA LOS DIAS QUE FALTAN PARA LLEGAR AL PRIMER FERIADO
    '    CALC_FERIADO = (6 - DIA_SEMANA) * ANCHO_DIAS
    '    Select Case DIA_SEMANA
    '        Case 1, 2, 3, 4, 5
    '            'DETERMINA S = CANTIDAD DE DIAS HASTA QUE LLEGUE EL SABADO Y LLENA LA POSICION DEL GRAFICO PARA PINTAR A PARTIR DE ALLI LAS LINEAS GRISES
    '            'REORRE EL GRAFICO A LO ANCHO DESDE EL INICIO HASTA EL FINAL (DESDE EL PRIMER LUNES HASTA EL FINAL DEL GRAFICO)
    '            For S = FONDO_POSX + CALC_FERIADO To FONDO_POSX + FONDO_ANCHO Step 7 * ANCHO_DIAS
    '                'POSX_GRAF ES LA POSICION VARIABLE DEL COMIENZO DE LA LINEA VERDE Y POSICIONADOLA AL COMIENZO DEL DIA
    '                POSX_GRAF = S + ANCHO_DIAS / 2
    '                'PRIMER SEMANA
    '                'POSX_FER (POSICION INICIAL DEL PRIMER TRAMO DE ESCALA QUE ES VARIABLE DE ACUERDO AL DIA QUE COMIENZA LA SEMANA, ES FIJO)
    '                POSX_FER = ESCALA_POSX
    '                GRILLA.DrawLine(LABORABLE, POSX_FER, ESCALA_POSY + 27, (POSX_FER + (6 - DIA_SEMANA) * ANCHO_DIAS), ESCALA_POSY + 27)
    '                'SEMANAS SUCESIVAS
    '                If (POSX_GRAF + 1 + 7 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2) < ESCALA_POSX + ESCALA_ANCHO Then
    '                    GRILLA.DrawLine(LABORABLE, (POSX_GRAF + 1 + 2 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27, (POSX_GRAF + 1 + 7 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27)
    '                End If
    '            Next S
    '        Case 6
    '            For S = ESCALA_POSX To ESCALA_POSX + ESCALA_ANCHO Step 7 * ANCHO_DIAS
    '                POSX_GRAF = S + ANCHO_DIAS / 2
    '                'SITUA LA FRANJA LABORABLE A PARTIR DEL TERCER DIA (+ 2 DIAS)
    '                If (POSX_GRAF + 1 + 7 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2) < ESCALA_POSX + ESCALA_ANCHO Then
    '                    GRILLA.DrawLine(LABORABLE, (POSX_GRAF + 1 + 2 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27, (POSX_GRAF + 1 + 7 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27)
    '                End If
    '            Next S
    '        Case 0
    '            For S = ESCALA_POSX To ESCALA_POSX + ESCALA_ANCHO Step 7 * ANCHO_DIAS
    '                POSX_GRAF = S + ANCHO_DIAS / 2
    '                'SITUA LA FRANJA LABORABLE A PARTIR DEL SEGUNDO DIA (+ 1 DIA)
    '                If (POSX_GRAF + 1 + 7 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2) < ESCALA_POSX + ESCALA_ANCHO Then
    '                    GRILLA.DrawLine(LABORABLE, (POSX_GRAF + 1 + ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27, (POSX_GRAF + 1 + 6 * ANCHO_DIAS) - CInt(ANCHO_DIAS / 2), ESCALA_POSY + 27)
    '                End If
    '            Next S
    '    End Select


    '    'DIBUJA DIVISIONES VERTICALES EN ESCALA
    '    Dim DIA_HOY As Integer
    '    Dim DIA_SEM As Integer
    '    Dim DIA_GRAF As String
    '    DIAS.Text = ""
    '    For I = 0 To CANT_DIAS
    '        If I * ANCHO_DIAS + ANCHO_ETIQUETAS + MARGEN_IZQUIERDO < 1366 - MARGEN_DERECHO Then
    '            'DIBUJA LAS LINEAS BLANCAS DE LA ESCALA DE SEPARACION ENTRE DIAS
    '            GRILLA.DrawLine(LINEABLANCA, ESCALA_POSX + I * ANCHO_DIAS, ESCALA_POSY + 23, ESCALA_POSX + I * ANCHO_DIAS, ESCALA_POSY + 30)

    '            'CONSTRUYE EL STRING DE DIAS QUE VA SOBRE LA ESCALA
    '            If I <= CANT_DIAS - 1 Then
    '                'CARGA LAS FECHAS CORRESPONDIENTES A LOS DIAS
    '                DIA_HOY = DateAdd(DateInterval.Day, I, CALC_FECHAGRAF).Day
    '                DIA(I, 1) = DIA_HOY
    '                DIA_SEM = DateAdd(DateInterval.Day, I, CALC_FECHAGRAF).DayOfWeek
    '                DIA(I, 2) = DIA_SEM

    '                If DIA_HOY <= 9 Then
    '                    DIA_GRAF = " " + Str(DIA_HOY)
    '                Else
    '                    DIA_GRAF = Str(DIA_HOY)
    '                End If
    '                DIAS.Text = DIAS.Text & DIA_GRAF
    '            End If
    '        End If
    '    Next I
    'End Sub

    'Private Sub DIBUJA_BASEETIQUETAS()
    '    Dim GAP_Y As Integer
    '    Dim GRILLA As Graphics = FONDO_GRAF.CreateGraphics()

    '    Dim LINEABLANCA As New Pen(Color.White, 1)
    '    Dim LINEAGRIS1 As New Pen(Color.LightGray, 1)
    '    Dim LINEAGRIS2 As New Pen(Color.Silver, 1)
    '    Dim LINEAGRIS3 As New Pen(Color.DarkGray, 1)
    '    Dim LINEAGRIS4 As New Pen(Color.Gray, 1)
    '    Dim LINEAGRIS5 As New Pen(Color.DimGray, 1)
    '    Dim FERIADO As New Pen(Color.LightGray, 15)
    '    Dim HOY As New Pen(Color.LightGreen, 15)
    '    Dim LABORABLE As New Pen(Color.DarkGreen, 6)

    '    'DIBUJA FONDO DE ETIQUETAS
    '    For H = 0 To CANT_ORDENES - 1
    '        GAP_Y = ALTO_ORDENES * H
    '        GRILLA.DrawLine(BASE_ETIQUETAS, ETIQUETA_POSX, ETIQUETA_POSY + CInt(ALTO_ORDENES / 2) + GAP_Y, (ETIQUETA_POSX + ANCHO_ETIQUETAS), ETIQUETA_POSY + CInt(ALTO_ORDENES / 2) + GAP_Y)
    '    Next H
    '    'DIBUJA LINEAS HORIZONTALES EN FONDO DE ETIQUEYAS___________________________________________________________________________________________________
    '    For H = 0 To CANT_ORDENES - 1
    '        GAP_Y = ALTO_ORDENES * H
    '        GRILLA.DrawLine(LINEAGRIS5, ETIQUETA_POSX, FONDO_POSY + GAP_Y, (ETIQUETA_POSX + ANCHO_ETIQUETAS), FONDO_POSY + GAP_Y)
    '    Next H

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    DIBUJA_GRAFFONDO()
    'End Sub

    'Private Sub BOTON_SALIR_Click(sender As Object, e As EventArgs) Handles BOTON_SALIR.Click
    '    BORRA_VARIABLES()
    '    Me.Close()
    'End Sub
    'Private Sub BORRA_VARIABLES()

    '    For B = 1 To GRAF_CANTIDADFILAS

    '        GRAF_CLASE(B) = ""
    '        GRAF_MOTIVO(B) = ""
    '        GRAF_CAUSA(B) = ""
    '        GRAF_MANZANA(B) = ""
    '        GRAF_CALLE(B) = ""
    '        GRAF_NRO(B) = 0
    '        GRAF_NODOTRAB(B) = ""
    '        GRAF_ZONATRAB(B) = ""
    '        GRAF_CREARORDINAL(B) = False
    '        GRAF_COORDINAR(B) = False
    '        GRAF_NROGESTION(B) = 0
    '        GRAF_NROTRABAJO(B) = 0
    '        GRAF_NROORDEN(B) = 0
    '        GRAF_NROORDINAL(B) = 0
    '        GRAF_FECHAINGRESO(B) = Nothing
    '        GRAF_FECHAINIESTIMADO(B) = Nothing
    '        GRAF_FECHAINICIO(B) = Nothing
    '        GRAF_FECHAFINESTIMADO(B) = Nothing
    '        GRAF_FECHAAGENDADO(B) = Nothing
    '        GRAF_TIEMPOESTIMADO(B) = 0
    '        GRAF_FECHAFINALIZADO(B) = Nothing
    '        GRAF_STATUS(B) = ""

    '    Next B
    '    GRAF_FECHAINIGRAFICO = Nothing
    '    GRAF_CANTIDADFILAS = 0

    'End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    DIBUJA_GRAFFONDO()
    '    PROCESA_DATOS()
    '    DIBUJA_BASEETIQUETAS()
    '    DIBUJA_ETIQUETAS()
    '    DIBUJA_ESCALA()
    '    Timer1.Stop()
    'End Sub


    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    POSH = -1

    '    Dim FECHAORIG As Date = CALC_FECHAGRAF.Date
    '    CALC_FECHAGRAF = DateAdd(DateInterval.Day, POSH, FECHAORIG.Date)
    '    GRAF_FECHAINIGRAFICO = CALC_FECHAGRAF.Date

    '    DIBUJA_GRAFFONDO()
    '    PROCESA_DATOS()
    '    DIBUJA_ESCALA()

    'End Sub
    'Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    '    POSH = +1
    '    Dim FECHAORIG As Date = CALC_FECHAGRAF.Date
    '    CALC_FECHAGRAF = DateAdd(DateInterval.Day, POSH, FECHAORIG.Date)
    '    GRAF_FECHAINIGRAFICO = CALC_FECHAGRAF.Date

    '    DIBUJA_GRAFFONDO()
    '    PROCESA_DATOS()
    '    DIBUJA_ESCALA()
    'End Sub



    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    POSV = POSV + 1
    '    POSICIONA_ETIQUETAS()
    '    DIBUJA_GRAFFONDO()
    '    PROCESA_DATOS()


    '    'DIBUJA_BASEETIQUETAS()

    '    'DIBUJA_ESCALA()

    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    POSV = POSV - 1

    '    DIBUJA_GRAFFONDO()
    '    PROCESA_DATOS()
    '    'DIBUJA_BASEETIQUETAS()
    '    POSICIONA_ETIQUETAS()


    '    'DIBUJA_ESCALA()


    'End Sub


End Class