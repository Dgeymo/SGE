Imports System.IO
Public Class USUARIO
    Dim usuarioActualizar As DataRow
    Private Sub USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(My.Computer.Screen.WorkingArea.Width - 450, My.Computer.Screen.WorkingArea.Height - 550)
        USUARIOSTableAdapter.FillByINICIO(OPERACIONES_LOGDataSet.USUARIOS, Split(File.ReadAllText("C:\DOCUMENTOS\USUARIO\LOGVBNET.TXT"), ",")(0))
        If THEME_BLACK Then
            ForeColor = Color.White
            BackColor = Color.Black
        Else
            ForeColor = Color.Black
            BackColor = Color.White
        End If
        If OPERACIONES_LOGDataSet.USUARIOS.Rows.Count > 0 Then
            TXT_USUARIO.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("USUARIO")
            TXTPass.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PASWORD")
            TXT_NOMBRE.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("NOMBRE")
            TXT_APELLIDO.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("APELLIDO")
            TXT_USUARIO_RUS.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("USUARIO_RUS")
            TXT_PASSWORD_RUS.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("PASWORD_RUS")
            TXT_ID_SELECTOR.Text = OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("ID_SELECTOR")
        Else
            MsgBox("ERROR AL INTENTAR ACCEDER A LOS DATOS DE USUARIO")
        End If
    End Sub
    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        If TXTPass.Text <> "" Then
            Try
                USUARIOSTableAdapter.FillByINICIO(OPERACIONES_LOGDataSet.USUARIOS, Split(File.ReadAllText("C:\DOCUMENTOS\USUARIO\LOGVBNET.TXT"), ",")(0))
                usuarioActualizar = OPERACIONES_LOGDataSet.USUARIOS.Rows(0)
                usuarioActualizar("PASWORD") = Trim(TXTPass.Text)
                If TXT_USUARIO.Text <> "" Then usuarioActualizar("USUARIO") = Trim(TXT_USUARIO.Text) Else MsgBox("COMPLETAR NOMBRE DE USUARIO")
                If TXT_NOMBRE.Text <> "" Then usuarioActualizar("NOMBRE") = Trim(TXT_NOMBRE.Text) Else MsgBox("COMPLETE NOMBRE")
                If TXT_APELLIDO.Text <> "" Then usuarioActualizar("APELLIDO") = Trim(TXT_APELLIDO.Text) Else MsgBox("COMPLETE APELLIDO")

                USUARIOSTableAdapter.Update(OPERACIONES_LOGDataSet.USUARIOS)
                MsgBox("USUARIO actualizado con exito")
            Catch ex As Exception
                MsgBox("UPSSS!" & vbNewLine & "No se pudo actualizar", MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("COMPLETE CONTRASEÑA")
        End If
    End Sub
    Private Sub BTN_GUARDAR_RUS_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR_RUS.Click
        USUARIOSTableAdapter.FillByINICIO(OPERACIONES_LOGDataSet.USUARIOS, Split(File.ReadAllText("C:\DOCUMENTOS\USUARIO\LOGVBNET.TXT"), ",")(0))
        If OPERACIONES_LOGDataSet.USUARIOS.Rows.Count > 0 Then
            usuarioActualizar = OPERACIONES_LOGDataSet.USUARIOS.Rows(0)
            Try
                If TXT_USUARIO_RUS.Text <> "" Then
                    usuarioActualizar("USUARIO_RUS") = Trim(TXT_USUARIO_RUS.Text)
                Else
                    MsgBox("COMPLETE USUARIO RUS")
                    Exit Sub
                End If

                If TXT_PASSWORD_RUS.Text <> "" Then
                    usuarioActualizar("PASWORD_RUS") = Trim(TXT_PASSWORD_RUS.Text)
                Else
                    MsgBox("COMPLETE PASSWORD RUS")
                    Exit Sub
                End If
                If TXT_ID_SELECTOR.Text <> "" Then
                    usuarioActualizar("ID_SELECTOR") = Trim(TXT_ID_SELECTOR.Text)
                Else
                    MsgBox("COMPLETE ID-SELECTOR")
                    Exit Sub
                End If
                USUARIOSTableAdapter.Update(OPERACIONES_LOGDataSet.USUARIOS)
                MsgBox("USUARIO RUS ACTUALIZADO!", vbInformation)
            Catch ex As Exception
                MsgBox("UPSSS!" & vbNewLine & "No se pudo actualizar", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub CB_THEME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_THEME.SelectedIndexChanged
        USUARIOSTableAdapter.FillByID(OPERACIONES_LOGDataSet.USUARIOS, ID)
        If CB_THEME.Text = "CLARA" Then
            OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("BLACK") = False
            MsgBox("Cierre la aplicacion para actualizar cambios")
        Else
            OPERACIONES_LOGDataSet.USUARIOS.Rows(0).Item("BLACK") = True
            MsgBox("Cierre la aplicacion para actualizar cambios")
        End If
        USUARIOSTableAdapter.Update(OPERACIONES_LOGDataSet.USUARIOS.Rows(0))
    End Sub
End Class