Imports System.IO
Public Class FOpenFileDialog
    Dim PathRuta As String
    Dim NewADJUNTORow As ORDENESDataSet.ADJUNTOSRow
    Dim SUBCARPETAS
    Dim SOBRECARPETAS
    Dim CARPETAS As String
    Dim TECLA As String
    Dim POS_LIST_CARPETA As Integer
    Private Sub FOpenFileDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case SECTOR
            Case = "PLANIFICACION TECNICA", "GERENCIA"
                CARPETAS = "R:\OPERACIONES\Planificación-Técnica"
            Case = "DISEÑO", "OBRA CIVIL"
                CARPETAS = "R:\OPERACIONES\Diseños"
            Case Else
                CARPETAS = "C:\DOCUMENTOS"
        End Select
        If PROCESOS.Visible = True Then
            CARPETAS = "G:\OPERACIONES\BD_INDICE"
        End If

        BUSCAR(CARPETAS, False)
    End Sub
    Private Sub BUSCAR(CARPETAS, SUBIR)
        L_FOLDERS.Items.Clear()
        ListArchivos.Items.Clear()
        Try
            If CARPETAS = "" Then
                L_FOLDERS.Items.Add("C:\").SubItems.Add("C:\")
                L_FOLDERS.Items.Add("G:\").SubItems.Add("G:\")
                L_FOLDERS.Items.Add("R:\").SubItems.Add("R:\")
                ListArchivos.Items.Add("").SubItems.Add("Seleccione carpeta...")
                LBLRuta.Text = ""
            Else
                If SUBIR = True Then
                    Select Case CARPETAS
                        Case "C:\"
                            L_FOLDERS.Items.Add("").SubItems.Add("\...")
                            LBLRuta.Text = ""
                        Case "G:\"
                            L_FOLDERS.Items.Add("").SubItems.Add("\...")
                            LBLRuta.Text = ""
                        Case "R:\"
                            L_FOLDERS.Items.Add("").SubItems.Add("\...")
                            LBLRuta.Text = ""
                        Case Else
                            L_FOLDERS.Items.Add(My.Computer.FileSystem.GetParentPath(CARPETAS)).SubItems.Add("\...")
                            SOBRECARPETAS = Directory.GetDirectories(My.Computer.FileSystem.GetParentPath(CARPETAS))
                            For Each CARPETA In SOBRECARPETAS
                                L_FOLDERS.Items.Add(CARPETA).SubItems.Add(Path.GetFileName(CARPETA))
                            Next
                            LBLRuta.Text = My.Computer.FileSystem.GetParentPath(CARPETAS)
                            For Each NombreArchivo In My.Computer.FileSystem.GetFiles(CARPETAS, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                                ListArchivos.Items.Add(NombreArchivo).SubItems.Add(Path.GetFileName(NombreArchivo))
                            Next
                    End Select
                Else
                    L_FOLDERS.Items.Add(CARPETAS).subitems.add("\...")
                    SUBCARPETAS = Directory.GetDirectories(CARPETAS)
                    For Each CARPETA In SUBCARPETAS
                        L_FOLDERS.Items.Add(CARPETA).SubItems.Add(Path.GetFileName(CARPETA))
                    Next
                    For Each NombreArchivo In My.Computer.FileSystem.GetFiles(CARPETAS, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                        ListArchivos.Items.Add(NombreArchivo).SubItems.Add(Path.GetFileName(NombreArchivo))
                    Next
                    LBLRuta.Text = CARPETAS
                End If
            End If
        Catch ex As Exception
            L_FOLDERS.Items.Add(CARPETAS).subitems.add("ERROR AL ACCEDER....")
        End Try
    End Sub
    Private Sub BTNCerrar_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Close()
        Dispose()
    End Sub
    Private Sub ListArchivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListArchivos.SelectedIndexChanged
        If ListArchivos.SelectedItems.Count > 0 Then
            TXTNombre.Text = Path.GetFileNameWithoutExtension(ListArchivos.SelectedItems(0).SubItems(1).Text)
            PathRuta = ListArchivos.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub ListArchivos_DoubleClick(sender As Object, e As EventArgs) Handles ListArchivos.DoubleClick
        If ListArchivos.SelectedItems.Count > 0 Then
            Process.Start(ListArchivos.SelectedItems(0).SubItems(0).Text)
        End If
    End Sub
    Private Sub BTNAbrir_Click(sender As Object, e As EventArgs) Handles BTNAbrir.Click
        Dim PathADJUNTOS As String = "G:\\OPERACIONES\ADJUNTOS"
        Dim MSGBOX1 As MsgBoxResult
        Dim mover As Boolean = False
        'If PROCESOS.Visible = True Then
        '    NUEVO_INDICE.RUTA_EXCEL = ListArchivos.SelectedItems(0).SubItems(0).Text
        '    Visible = False
        '    NUEVO_INDICE.CARGAR_EXCEL_INFORME()
        '    Exit Sub
        'End If
        If TIPOACCION = "SERVICIOS" Then
            SERVICIOS.ListArchivos = ListArchivos
            For A = 0 To ListArchivos.SelectedItems.Count - 1
                SERVICIOS.NewADJUNTOSRow = SERVICIOS.ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
                SERVICIOS.NewADJUNTOSRow("NOM_ARCHIVO") = Path.GetFileNameWithoutExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                SERVICIOS.ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(SERVICIOS.NewADJUNTOSRow)
                SERVICIOS.DGV_ADJUNTO.Refresh()
            Next
            Me.Close()
            Exit Sub
        End If
        If Directory.Exists(PathADJUNTOS) = False Then
            Directory.CreateDirectory(PathADJUNTOS)
        End If 'CREA EL DIRECTORIO ADJUNTOS SI NO EXISTE
        If Directory.Exists(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO")) = False Then
            Directory.CreateDirectory(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
        End If 'PREGUNTAMOS SI EXISTE EL DIRECTORIO CREADO, DE LO CONTRARIO SE CREA
        'SE PREGUNTA SI SE QUIERE MOVER EL ARCHIVO A ADJUNTAR
        MSGBOX1 = MsgBox("MOVER EL ARCHIVO SELECCIONADO?" & vbNewLine & vbNewLine & "Si selecciona SI, borra el archivo seleccionado" & vbNewLine & "en caso contrario lo mantiene" & vbNewLine & "Para ambos casos el sistema creara un nuevo archivo" & vbNewLine & "asociado a la orden", vbYesNo, "ARCHIVO SELECCIONADO")
        If MSGBOX1 = DialogResult.Yes Then
            mover = True
        End If
        'VERIFICAMOS SI YA EXISTE UN ARCHIVO QUE SE LLAME IGUAL, DENTRO DE LA CARPETA
        For A = 0 To ListArchivos.SelectedItems.Count - 1
            Dim CANTARCHIVOS As Integer = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\").Count
            Dim NombreArchivos = Directory.GetFiles(PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\")
            Dim IgualArchivo As Boolean
            PathRuta = ListArchivos.SelectedItems(A).SubItems(0).Text
            NewADJUNTORow = ORDENESDataSet.ADJUNTOS.NewADJUNTOSRow
            NewADJUNTORow("ID_GESTION") = DATOS.DATOS_TRABAJORow("ID_GESTION")
            NewADJUNTORow("ID_TRABAJO") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
            If STANDARD.Visible = True Then
                NewADJUNTORow("ID_ORDEN") = DATOS.DATOS_ORDENESRow("NRO_ORDENINT")
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_ORDENESRow("NRO_ORDENINT").ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_ORDENESRow("NRO_ORDENINT") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                End If
            Else
                NewADJUNTORow("ID_ORDEN") = DATOS.DATOS_TRABAJORow("ID_TRABAJO")
                If CANTARCHIVOS > 0 Then
                    For Each ExisteArchivo In NombreArchivos
                        If Path.GetFileNameWithoutExtension(ExisteArchivo).ToString = DATOS.DATOS_TRABAJORow("ID_TRABAJO").ToString Then
                            IgualArchivo = True
                            Exit For
                        Else
                            IgualArchivo = False
                        End If
                    Next
                    If IgualArchivo = True Then
                        Try
                            NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "(" & CANTARCHIVOS & ")" & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                            File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    NewADJUNTORow("RUTA_ADJUNTO") = PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text)
                    File.Copy(PathRuta, PathADJUNTOS & "\" & DATOS.DATOS_GESTIONRow("ID_GESTION") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & "\" & DATOS.DATOS_TRABAJORow("ID_TRABAJO") & Path.GetExtension(ListArchivos.SelectedItems(A).SubItems(1).Text), True)
                End If
            End If
            If ListArchivos.SelectedItems.Count > 1 Then
                NewADJUNTORow("NOM_ARCHIVO") = ListArchivos.SelectedItems(A).SubItems(1).Text
            Else
                NewADJUNTORow("NOM_ARCHIVO") = TXTNombre.Text
            End If
            ORDENESDataSet.ADJUNTOS.AddADJUNTOSRow(NewADJUNTORow)
            ADJUNTOSTableAdapter.Update(NewADJUNTORow)
            If STANDARD.Visible = True Then
                STANDARD.ADJUNTOSTableAdapter.FillByORDEN(STANDARD.ORDENESDataSet.ADJUNTOS, DATOS.DATOS_ORDENESRow("NRO_ORDENINT"))
            Else
                DATOS.ADJUNTOSTableAdapter.FillByORDEN(DATOS.ORDENESDataSet.ADJUNTOS, DATOS.DATOS_TRABAJORow("ID_TRABAJO"))
            End If
            If mover = True Then
                'BORRA EL ARCHIVO DE ORIGEN
                Try
                    File.Delete(PathRuta)
                Catch ex As Exception
                    MsgBox("No se pudo borrar el archivo, realicelo manualmente")
                End Try

            End If ' BORRAR EL ARCHIVO SI SE HA MARCADO EN SI
        Next A
        BTNCerrar.Text = "Cerrar"
        Try
            ListArchivos.Items.Clear()
            For Each NombreArchivo In My.Computer.FileSystem.GetFiles(CARPETAS, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                ListArchivos.Items.Add(NombreArchivo).SubItems.Add(Path.GetFileName(NombreArchivo))
            Next
        Catch ex As Exception
        End Try
        If STANDARD.Visible = True Then
            STANDARD.BTNBorrar.Enabled = True
        Else
            DATOS.BTN_BORRAR.Enabled = True
            DATOS.LBL_ADJUNTOS.Visible = True
        End If
    End Sub
    Private Sub CB_RAIZ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_RAIZ.SelectedIndexChanged
        CARPETAS = CB_RAIZ.Text
        BUSCAR(CARPETAS, False)
        If L_FOLDERS.Items(0).SubItems(0).Text = "" Then
            BTN_SUBIRDIR.Enabled = False
        Else
            BTN_SUBIRDIR.Enabled = True
        End If
    End Sub
    Private Sub L_FOLDERS_DoubleClick(sender As Object, e As EventArgs) Handles L_FOLDERS.DoubleClick
        If L_FOLDERS.SelectedItems(0).SubItems(1).Text = "\..." Then
            BUSCAR(L_FOLDERS.SelectedItems(0).SubItems(0).Text, True)
        Else
            BUSCAR(L_FOLDERS.SelectedItems(0).SubItems(0).Text, False)
        End If
        If L_FOLDERS.Items(0).SubItems(0).Text = "" Then
            BTN_SUBIRDIR.Enabled = False
        Else
            BTN_SUBIRDIR.Enabled = True
        End If
    End Sub
    Private Sub BTN_SUBIRDIR_Click(sender As Object, e As EventArgs) Handles BTN_SUBIRDIR.Click
        If L_FOLDERS.Items(0).SubItems(0).Text = "" Then
            BTN_SUBIRDIR.Enabled = False
        End If
        BUSCAR(L_FOLDERS.Items(0).SubItems(0).Text, True)
    End Sub
    Private Sub L_FOLDERS_KeyDown(sender As Object, e As KeyEventArgs) Handles L_FOLDERS.KeyDown
        POS_LIST_CARPETA = 0
        If L_FOLDERS.Items.Count > 0 Then
            For x = 1 To L_FOLDERS.Items.Count
                ' If POS_LIST_CARPETA < L_FOLDERS.Items.Count - 1 Then

                If e.KeyData.ToString = Mid(L_FOLDERS.Items(x).SubItems(1).Text, 1, 1) Then
                    If TECLA = e.KeyData.ToString Then
                        If L_FOLDERS.Items(POS_LIST_CARPETA).Index = POS_LIST_CARPETA Then

                            L_FOLDERS.Items(CInt(POS_LIST_CARPETA + 1)).Selected = True
                            L_FOLDERS.Select()
                            TECLA = e.KeyData.ToString
                            POS_LIST_CARPETA += 1
                            'Else
                            '    L_FOLDERS.Items(x).Selected = True
                            '    L_FOLDERS.Select()
                            '    TECLA = e.KeyData.ToString
                            '    POS_LIST_CARPETA = L_FOLDERS.Items(x).Index + 1
                        End If
                    End If
                    'Exit For
                Else
                    L_FOLDERS.Items(x).Selected = True
                    L_FOLDERS.Select()
                    TECLA = e.KeyData.ToString
                    POS_LIST_CARPETA = L_FOLDERS.Items(x).Index
                    Exit For
                End If
                ' End If
            Next
        End If
    End Sub
End Class