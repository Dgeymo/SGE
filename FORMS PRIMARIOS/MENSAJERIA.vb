Public Class MENSAJERIA
    Dim S As String
    Dim USUARIOSRow As DataRow
    Dim RECIBIDOSECTOR As String
    Dim CANTMJESNow As Integer
    Dim MENSAJERow As DataRow
    Dim SECTORRow As DataRow
    Dim MSJ_NewMENSAJE As ORDENESDataSet.MENSAJERIARow
    Dim LEIDOS As Boolean
    Dim FECHAMAX As Date
    Dim IDMENSAJE As Integer
    Dim MJE_MJE_ASUNTO As String
    Dim MJE_MJE_DESTINONOMBRE As String
    Dim MJE_MJE_DESTINOSECTOR As String
    Dim MJE_MJE_MENSAJE As String
    Dim MJE_MJE_NROORDENASOC As String
    Dim MJE_MJE_TIPOMENSAJE As String
    Dim MJE_MJE_TIPO_ORDENASOC As String
    Private Sub CONDICION_RECIBIDOS()
        'BOTONES
        BOT_NUEVO.Enabled = True
        BOT_RESPONDER.Enabled = True
        BOT_REENVIAR.Enabled = True

        TIPO_MENSAJE.Enabled = True
        FILTRALEIDOS.Enabled = True

        BOT_ENVIAR.Enabled = False
        BOT_CANCELAR.Enabled = False

        DataGridView1.Enabled = True

        DE_NOMBRE.ReadOnly = True
        PARA_NOMBRE.Enabled = False
        DE_SECTOR.ReadOnly = True
        PARA_SECTOR.Enabled = False
        ASUNTO.ReadOnly = True
        TIPO_ORDEN.Enabled = False
        NRO_ORDEN.ReadOnly = True
        MENSAJE.ReadOnly = True

    End Sub
    Private Sub BLOQUEA_CAMPOS()

        Me.PARA_NOMBRE.Items.Clear()
        Me.PARA_NOMBRE.Text = ""
        Me.PARA_NOMBRE.Enabled = True

        Me.PARA_SECTOR.Items.Clear()
        Me.PARA_SECTOR.Text = ""
        Me.PARA_SECTOR.Enabled = False

        Me.ASUNTO.Text = ""
        Me.ASUNTO.ReadOnly = True

        Me.TIPO_ORDEN.Text = ""
        Me.TIPO_ORDEN.Enabled = False

        Me.NRO_ORDEN.Text = ""
        Me.NRO_ORDEN.ReadOnly = True

        MENSAJE.Text = ""
        MENSAJE.ReadOnly = True

    End Sub
    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Me.Refresh()
        'Dim RESPUESTA As New OpenFileDialog
        'RESPUESTA.ShowDialog()

        TIPO_MENSAJE.Text = "RECIBIDOS"
        FILTRALEIDOS.Text = "NO LEIDOS"
        LEIDOS = True
        CONDICION_RECIBIDOS()
        DASHBOARD.Cursor = DefaultCursor
        Cursor = DefaultCursor
    End Sub
    Private Sub BUSCA_MENSAJES()
        Select Case TIPO_MENSAJE.Text
            Case "RECIBIDOS"
                Select Case FILTRALEIDOS.Text
                    Case "TODOS"
                        Me.MENSAJERIATableAdapter.FillByRECIBIDOSTODOS(ORDENESDataSet.MENSAJERIA, FULLNOMBRE, SECTOR)
                        Me.BOT_RESPONDER.Enabled = True
                    Case "NO LEIDOS"
                        Me.MENSAJERIATableAdapter.FillByRECIBIDOSNOLEIDOS(ORDENESDataSet.MENSAJERIA, FULLNOMBRE, SECTOR)
                        Me.BOT_RESPONDER.Enabled = True
                End Select
                CANTMJESNow = ORDENESDataSet.MENSAJERIA.Rows.Count
            Case "ENVIADOS"
                Me.MENSAJERIATableAdapter.FillByENVIADOS(ORDENESDataSet.MENSAJERIA, FULLNOMBRE, SECTOR)
                Me.BOT_RESPONDER.Enabled = False
        End Select
        DASHBOARD.BTNMensajeria.Text = CANTMJESNow
    End Sub
    Private Sub PRINCIPAL_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'BUSCA_MENSAJES()
        PINTA_LEIDOS()
        'CARGA_MJE()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If ORDENESDataSet.MENSAJERIA.Rows.Count > 0 Then
            Cursor = Cursors.WaitCursor
            Select Case TIPO_MENSAJE.Text
                Case "RECIBIDOS"
                    BOT_RESPONDER.Enabled = True
                    TIPO_MENSAJE.Enabled = False
                    FILTRALEIDOS.Enabled = False
                    BOT_MARCARNOLEIDO.Enabled = True
            End Select

            MENSAJERow = ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position)
            Select Case MENSAJERow("LEIDO")
                Case True
                    BOT_MARCARNOLEIDO.Enabled = True
                Case False
                    MENSAJERow("LEIDO") = True
                    MENSAJERIATableAdapter.Update(MENSAJERow)
                    BOT_MARCARNOLEIDO.Enabled = False
            End Select

            BOT_NUEVO.Enabled = True
            BOT_ENVIAR.Enabled = False
            BOT_CANCELAR.Enabled = True

            'BLOQUEA_CAMPOS()
            'CARGA LOS DATOS DEL MENSAJE EN LOS CAMPOS CORRESPONDIENTES
            CARGA_MJE()
            PINTA_LEIDOS()
            Me.Cursor = DefaultCursor
        End If
    End Sub
    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        PINTA_LEIDOS()
        Cursor = DefaultCursor
    End Sub
    Private Sub CARGA_MJE()

        If ORDENESDataSet.MENSAJERIA.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            MENSAJERow = ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position)

            'IDMENSAJE = DataGridView1.CurrentRow.Cells.Item(7).Value
            'MENSAJERow = ORDENESDataSet.Tables("MENSAJERIA").Rows.Find(IDMENSAJE)
            IDMENSAJE = MENSAJERow("Id_MENSAJE")
            If IsDBNull(MENSAJERow("DESTINO_NOMBRE")) = False Then PARA_NOMBRE.Text = MENSAJERow("DESTINO_NOMBRE") Else PARA_NOMBRE.Text = ""
            If IsDBNull(MENSAJERow("DESTINO_SECTOR")) = False Then PARA_SECTOR.Text = MENSAJERow("DESTINO_SECTOR") Else PARA_SECTOR.Text = ""
            If IsDBNull(MENSAJERow("ORIGEN_NOMBRE")) = False Then DE_NOMBRE.Text = MENSAJERow("ORIGEN_NOMBRE") Else DE_NOMBRE.Text = ""
            If IsDBNull(MENSAJERow("ORIGEN_SECTOR")) = False Then DE_SECTOR.Text = MENSAJERow("ORIGEN_SECTOR") Else DE_SECTOR.Text = ""
            If IsDBNull(MENSAJERow("ASUNTO")) = False Then ASUNTO.Text = MENSAJERow("ASUNTO") Else ASUNTO.Text = ""
            If IsDBNull(MENSAJERow("TIPO_ORDENASOC")) = False Then TIPO_ORDEN.Text = MENSAJERow("TIPO_ORDENASOC") Else TIPO_ORDEN.Text = ""
            If IsDBNull(MENSAJERow("NRO_ORDENASOC")) = False Then NRO_ORDEN.Text = MENSAJERow("NRO_ORDENASOC") Else NRO_ORDEN.Text = 0


            If IsDBNull(MENSAJERow("MENSAJE")) = False Then MENSAJE.Text = MENSAJERow("MENSAJE") Else MENSAJE.Text = ""
            Me.Cursor = DefaultCursor
        End If
    End Sub
    Private Sub PINTA_LEIDOS()
        If DataGridView1.Rows.Count > 0 Then
            For I = 0 To DataGridView1.Rows.Count - 1
                Select Case DataGridView1.Rows(I).Cells.Item(6).Value
                    Case True
                        DataGridView1.Rows(I).DefaultCellStyle.ForeColor = Color.BurlyWood
                        DataGridView1.Rows(I).DefaultCellStyle.BackColor = Color.DimGray
                    Case Else
                        DataGridView1.Rows(I).DefaultCellStyle.ForeColor = Color.LightGreen
                        DataGridView1.Rows(I).DefaultCellStyle.BackColor = Color.DimGray
                End Select
            Next
        End If
    End Sub
    Private Sub BOT_MARCARNOLEIDO_Click(sender As Object, e As EventArgs) Handles BOT_MARCARNOLEIDO.Click
        If ORDENESDataSet.MENSAJERIA.Rows.Count > 0 Then
            MENSAJERow = ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position)
            MENSAJERow("LEIDO") = False
            MENSAJERIATableAdapter.Update(MENSAJERow)
            PINTA_LEIDOS()
            BOT_MARCARNOLEIDO.Enabled = False
        End If
    End Sub
    Private Sub CARGA_COMBOSNUEVO()

        Me.PARA_NOMBRE.Items.Clear()
        Me.USUARIOSTableAdapter.FillByORDEN(Me.OPERACIONES_LOGDataSet.USUARIOS)
        Me.PARA_NOMBRE.Items.Add("")

        'CARGA EL COMBO PARA_NOMBRE CON LOS USUARIOS DEFINIDOS EN EL LOG
        For I = 0 To Me.OPERACIONES_LOGDataSet.USUARIOS.Rows.Count - 1
            USUARIOSRow = OPERACIONES_LOGDataSet.USUARIOS.Rows(I)
            If USUARIOSRow("NOMBRE") & " " & USUARIOSRow("APELLIDO") <> NOMBRE & " " & APELLIDO Then
                Me.PARA_NOMBRE.Items.Add(USUARIOSRow("NOMBRE") & " " & USUARIOSRow("APELLIDO"))
            End If
        Next I

        'CARGA LOS SECTORES DEFINIDOS EN EL LOG
        Me.USUARIOSTableAdapter.FillBySOLOSECTOR(OPERACIONES_LOGDataSet.USUARIOS)
        Me.PARA_SECTOR.Items.Add("")
        For I = 0 To Me.OPERACIONES_LOGDataSet.USUARIOS.Rows.Count - 1
            SECTORRow = OPERACIONES_LOGDataSet.USUARIOS.Rows(I)
            Me.PARA_SECTOR.Items.Add(SECTORRow("SECTOR"))
        Next I

    End Sub
    Private Sub TIPO_MENSAJE_TextChanged(sender As Object, e As EventArgs) Handles TIPO_MENSAJE.TextChanged
        FULLNOMBRE = NOMBRE & " " & APELLIDO
        BUSCA_MENSAJES()
        CARGA_MJE()
        PINTA_LEIDOS()
    End Sub
    Private Sub BOT_RESPONDER_Click(sender As Object, e As EventArgs) Handles BOT_RESPONDER.Click

        BOT_NUEVO.Enabled = False
        BOT_RESPONDER.Enabled = False

        BOT_ENVIAR.Enabled = True
        BOT_CANCELAR.Enabled = True

        TIPO_MENSAJE.Enabled = False
        FILTRALEIDOS.Enabled = False

        DataGridView1.Enabled = False

        'CARGA DATOS DE ENVIO Y DESHABILITA LA EDICION
        Me.DE_NOMBRE.Text = FULLNOMBRE
        Me.PARA_NOMBRE.Text = ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position).Item("ORIGEN_NOMBRE")
        Me.DE_NOMBRE.ReadOnly = True


        Me.ASUNTO.ReadOnly = True
        Me.TIPO_ORDEN.Enabled = False
        Me.NRO_ORDEN.ReadOnly = True

        'DETECTA SI EL MENSAJO VINO DIRIGIDO AL SECTOR
        If IsDBNull(ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position).Item("ORIGEN_SECTOR")) = False Then
            RECIBIDOSECTOR = "SI"
        Else
            RECIBIDOSECTOR = "NO"
        End If
        'HABILITA EL CAMPO DE MENSAJE PARA CONTESTAR
        MENSAJE.ReadOnly = False
        'CARGA ENCABEZAMIENTO DE LA RESPUESTA
        MENSAJE.Text = MENSAJE.Text & vbNewLine & vbNewLine & "_____________________________________________________________________________________" _
        & vbNewLine & "RESPUESTA DE: " & NOMBRE & " " & APELLIDO & "                                                    " & Now & vbNewLine & vbNewLine
        'COLOCA EL CURSOR EN PSICION PARA VOLVER A ESCRIBIR
        MENSAJE.Focus()
        MENSAJE.SelectionStart = MENSAJE.Text.Length & vbNewLine
        MENSAJE.ScrollToCaret()
    End Sub
    Private Sub BOT_REENVIAR_Click(sender As Object, e As EventArgs) Handles BOT_REENVIAR.Click
        BOT_NUEVO.Enabled = False
        BOT_RESPONDER.Enabled = False

        BOT_ENVIAR.Enabled = True
        BOT_CANCELAR.Enabled = True

        TIPO_MENSAJE.Enabled = False
        FILTRALEIDOS.Enabled = False

        DataGridView1.Enabled = False

        'CARGA DATOS DE ENVIO Y DESHABILITA LA EDICION
        Me.DE_NOMBRE.Text = FULLNOMBRE
        CARGA_COMBOSNUEVO()
        Me.PARA_NOMBRE.Text = ""
        Me.DE_NOMBRE.ReadOnly = True

        Me.PARA_SECTOR.Text = ""
        Me.ASUNTO.ReadOnly = True
        Me.TIPO_ORDEN.Enabled = False
        Me.NRO_ORDEN.ReadOnly = True

        'DETECTA SI EL MENSAJO VINO DIRIGIDO AL SECTOR
        If IsDBNull(ORDENESDataSet.MENSAJERIA.Rows(MENSAJERIABindingSource.Position).Item("ORIGEN_SECTOR")) = False Then
            RECIBIDOSECTOR = "SI"
        Else
            RECIBIDOSECTOR = "NO"
        End If
        'HABILITA EL CAMPO DE MENSAJE PARA CONTESTAR
        MENSAJE.ReadOnly = False
        'CARGA ENCABEZAMIENTO DE LA RESPUESTA
        MENSAJE.Text = MENSAJE.Text & vbNewLine & vbNewLine & "_____________________________________________________________________________________" _
        & vbNewLine & "REENVIADO POR: " & NOMBRE & " " & APELLIDO & "                                                    " & Now & vbNewLine & vbNewLine
        'COLOCA EL CURSOR EN PSICION PARA VOLVER A ESCRIBIR
        MENSAJE.Focus()
        MENSAJE.SelectionStart = MENSAJE.Text.Length & vbNewLine
        MENSAJE.ScrollToCaret()
    End Sub
    Private Sub BOT_NUEVO_Click(sender As Object, e As EventArgs) Handles BOT_NUEVO.Click

        CARGA_COMBOSNUEVO()

        BOT_NUEVO.Enabled = False
        BOT_RESPONDER.Enabled = False
        BOT_ENVIAR.Enabled = True
        BOT_CANCELAR.Enabled = True

        TIPO_MENSAJE.Enabled = False
        FILTRALEIDOS.Enabled = False


        Me.DE_NOMBRE.Text = FULLNOMBRE
        Me.DE_NOMBRE.ReadOnly = True

        Me.PARA_NOMBRE.Visible = True
        Me.PARA_NOMBRE.Text = ""
        Me.PARA_NOMBRE.Enabled = True

        Me.PARA_SECTOR.Visible = True
        Me.PARA_SECTOR.Text = ""
        Me.PARA_SECTOR.Enabled = True

        Me.ASUNTO.ReadOnly = False
        Me.ASUNTO.Text = ""

        Me.TIPO_ORDEN.Enabled = True
        Me.TIPO_ORDEN.Text = ""
        Me.NRO_ORDEN.ReadOnly = False

        Me.NRO_ORDEN.Text = ""
        MENSAJE.ReadOnly = False
        MENSAJE.Text = ""

        PARA_NOMBRE.Focus()

        DataGridView1.Enabled = False
    End Sub
    Private Sub BOT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BOT_CANCELAR.Click
        CONDICION_RECIBIDOS()
        DataGridView1_Click(Nothing, Nothing)
    End Sub
    Private Sub PARA_SECTOR_TextChanged(sender As Object, e As EventArgs) Handles PARA_SECTOR.TextChanged
        If PARA_SECTOR.Text <> "" Then
            PARA_NOMBRE.Text = ""
            PARA_NOMBRE.Enabled = False
        Else
            PARA_NOMBRE.Enabled = True
        End If
    End Sub
    Private Sub PARA_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles PARA_NOMBRE.TextChanged
        If PARA_NOMBRE.Text <> "" Then
            PARA_SECTOR.Text = ""
            PARA_SECTOR.Enabled = False
        Else
            PARA_SECTOR.Enabled = True
        End If
    End Sub
    Private Sub BOT_ENVIAR_Click(sender As Object, e As EventArgs) Handles BOT_ENVIAR.Click

        If PARA_NOMBRE.Text = "" Then
            If PARA_SECTOR.Text = "" Then
                MsgBox("NO SE HA INGRESADO NINGUN DESTINATARIO PARA ESTE MENSAJE")
            Else
                'GENERAR UN NUEVO MENSAJE
                MJE_MJE_ASUNTO = ASUNTO.Text
                MJE_MJE_TIPOMENSAJE = "GENERICO"
                MJE_MJE_DESTINONOMBRE = PARA_NOMBRE.Text
                MJE_MJE_DESTINOSECTOR = PARA_SECTOR.Text
                MJE_MJE_MENSAJE = MENSAJE.Text
                MJE_MJE_TIPO_ORDENASOC = TIPO_ORDEN.Text
                If NRO_ORDEN.Text <> "" Then
                    MJE_MJE_NROORDENASOC = NRO_ORDEN.Text
                Else
                    MJE_MJE_NROORDENASOC = 0
                End If

                GENERA_MENSAJE()
            End If
        Else
            'GENERAR UN NUEVO MENSAJE


            MJE_MJE_ASUNTO = ASUNTO.Text
            MJE_MJE_TIPOMENSAJE = "GENERICO"
            MJE_MJE_DESTINONOMBRE = PARA_NOMBRE.Text
            MJE_MJE_DESTINOSECTOR = PARA_SECTOR.Text
            MJE_MJE_MENSAJE = MENSAJE.Text
            MJE_MJE_TIPO_ORDENASOC = TIPO_ORDEN.Text
            If NRO_ORDEN.Text <> "" Then
                MJE_MJE_NROORDENASOC = NRO_ORDEN.Text
            Else
                MJE_MJE_NROORDENASOC = 0
            End If

            GENERA_MENSAJE()
        End If

        Select Case RECIBIDOSECTOR
            Case "SI"
                'GENERAR UN NUEVO MENSAJE
                MJE_MJE_ASUNTO = ASUNTO.Text
                MJE_MJE_TIPOMENSAJE = "COPIADO"
                'NewMensaje("ORIGEN_NOMBRE") = DE_NOMBRE.Text
                MJE_MJE_DESTINONOMBRE = ""
                MJE_MJE_DESTINOSECTOR = SECTOR
                MJE_MJE_ASUNTO = ASUNTO.Text
                MJE_MJE_MENSAJE = "EL USUARIO " & NOMBRE & " " & APELLIDO & " RESPONDIO ESTE MENSAJE CON EL SIGUIENTE TEXTO : " & vbNewLine & vbNewLine & MENSAJE.Text
                MJE_MJE_TIPO_ORDENASOC = TIPO_ORDEN.Text
                If NRO_ORDEN.Text <> "" Then
                    MJE_MJE_NROORDENASOC = NRO_ORDEN.Text
                Else
                    MJE_MJE_NROORDENASOC = 0
                End If

                GENERA_MENSAJE()

        End Select

        CONDICION_RECIBIDOS()
    End Sub
    Private Sub GENERA_MENSAJE()
        'ENVIA MENSAJE 
        MSJ_NewMENSAJE = ORDENESDataSet.MENSAJERIA.NewMENSAJERIARow
        MSJ_NewMENSAJE("FECHACREADO") = Now
        MSJ_NewMENSAJE("TIPOMENSAJE") = MJE_MJE_TIPOMENSAJE
        MSJ_NewMENSAJE("ASUNTO") = MJE_MJE_ASUNTO
        MSJ_NewMENSAJE("ORIGEN_NOMBRE") = NOMBRE & " " & APELLIDO
        MSJ_NewMENSAJE("ORIGEN_SECTOR") = ""
        MSJ_NewMENSAJE("DESTINO_NOMBRE") = MJE_MJE_DESTINONOMBRE
        MSJ_NewMENSAJE("DESTINO_SECTOR") = MJE_MJE_DESTINOSECTOR
        MSJ_NewMENSAJE("MENSAJE") = MJE_MJE_MENSAJE
        MSJ_NewMENSAJE("TIPO_ORDENASOC") = MJE_MJE_TIPO_ORDENASOC
        MSJ_NewMENSAJE("NRO_ORDENASOC") = MJE_MJE_NROORDENASOC

        ORDENESDataSet.MENSAJERIA.AddMENSAJERIARow(MSJ_NewMENSAJE)
        MENSAJERIATableAdapter.Update(MSJ_NewMENSAJE)
    End Sub
    Private Sub FILTRALEIDOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FILTRALEIDOS.SelectedIndexChanged
        BUSCA_MENSAJES()
        CARGA_MJE()
        PINTA_LEIDOS()
    End Sub
    Private Sub BOT_IMPRIMIRMENSAJE_Click(sender As Object, e As EventArgs) Handles BOT_IMPRIMIRMENSAJE.Click
        'VER QUE ES ESTO
        ' IMP_MENSAJE.Show()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Cursor = Cursors.WaitCursor
        BUSCA_MENSAJES()
        PINTA_LEIDOS()
        CARGA_MJE()
        Me.Cursor = DefaultCursor
    End Sub
End Class