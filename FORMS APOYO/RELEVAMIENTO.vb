Public Class RELEVAMIENTO
    'Dim DATOSRELEVRow As DataRow


    'Private Sub CARGA_FORM()

    '    DATOSRELEVRow = MDUDataSet.RELEVAMIENTOMDU.Rows(0)

    '    DATOSRELEVRow("IDTRABAJO") = EDIF_IDTRABAJO
    '    DATOSRELEVRow("CARPETA") = EDIF_CARPETA
    '    DATOSRELEVRow("SOLICITANTE") = SOLICITANTE.Text
    '    DATOSRELEVRow("NOMBRECONTACTO") = NOMBRECONTACTO.Text
    '    DATOSRELEVRow("TELEFCONTACTO") = TELCONTACTO.Text
    '    DATOSRELEVRow("MAILCONTACTO") = MAILCONTACTO.Text
    '    DATOSRELEVRow("CAUSAORIGEN") = CAUSAORIGEN.Text

    '    'TOMA EL DATO DE LA FECHA DE FINALIZACION ORDINAL
    '    DATOSRELEVRow("FECHARELEV") = "" ' LO DEBERIA CARGAR DEL ORDINAL
    '    DATOSRELEVRow("EJECUTANTE") = "" ' LO DEBERIA CARGAR DEL ORDINAL
    '    'DATOSRELEVRow("NROORDINAL") = EDIF_NROORDINAL
    '    'CARGA DATOS RELEVADOS
    '    DATOSRELEVRow("PISOS") = PISOS.Text
    '    DATOSRELEVRow("APTOS") = APTOS.Text
    '    DATOSRELEVRow("BOCAS") = BOCAS.Text
    '    DATOSRELEVRow("NROTAP") = NROTAP.Text
    '    DATOSRELEVRow("MEDTAPCH3") = MEDTAPCH3.Text
    '    DATOSRELEVRow("MEDTAPCH70") = MEDTAPCH70.Text
    '    DATOSRELEVRow("MEDTAPCH5") = MEDTAPCH5.Text
    '    DATOSRELEVRow("ACOMETIDA") = ACOMETIDA.Text
    '    DATOSRELEVRow("MONTANTE") = MONTANTE.Text
    '    DATOSRELEVRow("PASIVOS") = PASIVOS.Text
    '    DATOSRELEVRow("AMPUBIC") = AMPUBIC.Text
    '    DATOSRELEVRow("AMPTIPO") = AMPTIPO.Text
    '    DATOSRELEVRow("MEDENTCH3") = MEDENTCH3.Text
    '    DATOSRELEVRow("MEDENTCH70") = MEDENTCH70.Text
    '    DATOSRELEVRow("MEDENTCH5") = MEDENTCH5.Text
    '    DATOSRELEVRow("MEDENT291") = MEDENT291.Text
    '    DATOSRELEVRow("MEDENT327") = MEDENT327.Text
    '    DATOSRELEVRow("MEDENT405") = MEDENT405.Text
    '    DATOSRELEVRow("MEDENT561") = MEDENT561.Text
    '    DATOSRELEVRow("MEDSALCH3") = MEDSALCH3.Text
    '    DATOSRELEVRow("MEDSALCH70") = MEDSALCH70.Text
    '    DATOSRELEVRow("MEDSALCH5") = MEDSALCH5.Text
    '    DATOSRELEVRow("MEDSAL291") = MEDSAL291.Text
    '    DATOSRELEVRow("MEDSAL327") = MEDSAL327.Text
    '    DATOSRELEVRow("MEDSAL405") = MEDSAL405.Text
    '    DATOSRELEVRow("MEDSAL561") = MEDSAL561.Text
    '    DATOSRELEVRow("ELECSUMI") = ELECSUMI.Text
    '    If CAJA.Text = "SI" Then DATOSRELEVRow("CAJA") = True Else DATOSRELEVRow("CAJA") = False
    '    DATOSRELEVRow("STSELECTRICA") = STSELECTRICA.Text
    '    DATOSRELEVRow("STSACOMETIDA") = STSACOMETIDA.Text
    '    DATOSRELEVRow("STSMONTANTE") = STSMONTANTE.Text
    '    DATOSRELEVRow("STSAMPLIFICADOR") = STSAMPLIFICADOR.Text
    '    If RETDOMIC.Text = "SI" Then DATOSRELEVRow("RETDOMIC") = True Else DATOSRELEVRow("RETDOMIC") = False
    '    If PORTERIA.Text = "SI" Then DATOSRELEVRow("PORTERIA") = True Else DATOSRELEVRow("PORTERIA") = False
    '    DATOSRELEVRow("PORTDESDE") = PORTDESDE.Text
    '    DATOSRELEVRow("PORTHASTA") = PORTHASTA.Text

    '    'CARGA LOS DATOS
    '    RELEVAMIENTOMDUTableAdapter.Update(DATOSRELEVRow)

    '    'GRABA LOS DATOS
    '    RELEVAMIENTOMDUTableAdapter.Update(MDUDataSet.RELEVAMIENTOMDU)


    'End Sub
    'Private Sub RELEVAMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'MDUDataSet.RELEVAMIENTOMDU' Puede moverla o quitarla según sea necesario.
    '    Me.RELEVAMIENTOMDUTableAdapter.Fill(Me.MDUDataSet.RELEVAMIENTOMDU)
    '    'TODO: esta línea de código carga datos en la tabla 'MDUDataSet.RELEVAMIENTOMDU' Puede moverla o quitarla según sea necesario.
    '    Me.RELEVAMIENTOMDUTableAdapter.FillByIDTRABAJO(Me.MDUDataSet.RELEVAMIENTOMDU, EDIF_IDTRABAJO)

    '    SOLICITANTE.Text = EDIF_SOLICITANTE
    '    NOMBRECONTACTO.Text = EDIF_CONTACTO
    '    CAUSAORIGEN.Text = EDIF_CAUSAORIGEN
    '    TELCONTACTO.Text = EDIF_TELEFONO
    '    MAILCONTACTO.Text = EDIF_MAILCONTACTO
    '    'NROORDINAL.Text = NROORDINAL

    '    'DATOS CARGADOS EN FORMULARIO DE RELEVAMIENT0
    '    If MDUDataSet.RELEVAMIENTOMDU.Rows.Count > 0 Then

    '        DATOSRELEVRow = MDUDataSet.RELEVAMIENTOMDU.Rows(0)


    '        PISOS.Text = DATOSRELEVRow("PISOS")
    '        APTOS.Text = DATOSRELEVRow("APTOS")
    '        BOCAS.Text = DATOSRELEVRow("BOCAS")
    '        NROTAP.Text = DATOSRELEVRow("NROTAP")
    '        MEDTAPCH3.Text = DATOSRELEVRow("MEDTAPCH3")
    '        MEDTAPCH70.Text = DATOSRELEVRow("MEDTAPCH70")
    '        MEDTAPCH5.Text = DATOSRELEVRow("MEDTAPCH5")
    '        ACOMETIDA.Text = DATOSRELEVRow("ACOMETIDA")
    '        MONTANTE.Text = DATOSRELEVRow("MONTANTE")
    '        PASIVOS.Text = DATOSRELEVRow("PASIVOS")
    '        AMPUBIC.Text = DATOSRELEVRow("AMPUBIC")
    '        AMPTIPO.Text = DATOSRELEVRow("AMPTIPO")
    '        MEDENTCH3.Text = DATOSRELEVRow("MEDENTCH3")
    '        MEDENTCH70.Text = DATOSRELEVRow("MEDENTCH70")
    '        MEDENTCH5.Text = DATOSRELEVRow("MEDENTCH5")
    '        MEDENT291.Text = DATOSRELEVRow("MEDENT291")
    '        MEDENT327.Text = DATOSRELEVRow("MEDENT327")
    '        MEDENT405.Text = DATOSRELEVRow("MEDENT405")
    '        MEDENT561.Text = DATOSRELEVRow("MEDENT561")
    '        MEDSALCH3.Text = DATOSRELEVRow("MEDSALCH3")
    '        MEDSALCH70.Text = DATOSRELEVRow("MEDSALCH70")
    '        MEDSALCH5.Text = DATOSRELEVRow("MEDSALCH5")
    '        MEDSAL291.Text = DATOSRELEVRow("MEDSAL291")
    '        MEDSAL327.Text = DATOSRELEVRow("MEDSAL327")
    '        MEDSAL405.Text = DATOSRELEVRow("MEDSAL405")
    '        MEDSAL561.Text = DATOSRELEVRow("MEDSAL561")
    '        ELECSUMI.Text = DATOSRELEVRow("ELECSUMI")
    '        If DATOSRELEVRow("CAJA") = True Then CAJA.Text = "SI" Else CAJA.Text = "NO"
    '        STSELECTRICA.Text = DATOSRELEVRow("STSELECTRICA")
    '        STSACOMETIDA.Text = DATOSRELEVRow("STSACOMETIDA")
    '        STSMONTANTE.Text = DATOSRELEVRow("STSMONTANTE")
    '        STSAMPLIFICADOR.Text = DATOSRELEVRow("STSAMPLIFICADOR")
    '        If DATOSRELEVRow("RETDOMIC") = True Then RETDOMIC.Text = "SI" Else RETDOMIC.Text = "NO"
    '        If DATOSRELEVRow("PORTERIA") = True Then PORTERIA.Text = "SI" Else PORTERIA.Text = "NO"
    '        PORTDESDE.Text = DATOSRELEVRow("PORTDESDE")
    '        PORTHASTA.Text = DATOSRELEVRow("PORTHASTA")
    '    Else
    '        MsgBox("No existe relevamiento cargado para este trabajo")
    '    End If

    'End Sub


    'Private Sub BOT_GUARDARELEV_MouseHover(sender As Object, e As EventArgs) Handles BOT_GUARDARELEV.MouseHover
    '    BOT_GUARDARELEV.BackColor = Color.Yellow
    'End Sub

    'Private Sub BOT_GUARDARELEV_MouseLeave(sender As Object, e As EventArgs) Handles BOT_GUARDARELEV.MouseLeave
    '    BOT_GUARDARELEV.BackColor = Color.LightYellow
    'End Sub



    'Private Sub BOT_GUARDARELEV_Click(sender As Object, e As EventArgs) Handles BOT_GUARDARELEV.Click
    '    CARGA_FORM()
    'End Sub
End Class