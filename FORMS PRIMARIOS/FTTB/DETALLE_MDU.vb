Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class DETALLE_MDU
    Dim ENCABEZADO As PdfPTable
    Dim BITACORARow As EDIFICIODataSet.BITACORARow
    Dim ACT_MDURow As EDIFICIODataSet.MDURow
    Dim AGENDARow As EDIFICIODataSet.AGENDARow
    Dim TECNICORow As EDIFICIODataSet.TECNICOSRow
    Dim TURNORow As EDIFICIODataSet.TURNOSRow
    Dim VAR_ACOMETIDA As Integer
    Dim VAR_NODO As String
    Dim VAR_ZONA As Integer
    Dim CUENTA4 As Integer = 0
    Dim CUENTA8 As Integer = 0
    Dim CUENTA16 As Integer = 0
    Public Sub DETALLE_MDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AGENDA.Visible = False Then
            VAR_ACOMETIDA = INICIO.VER_MDU.ACOMETIDA
            VAR_NODO = INICIO.VER_MDU.NODO
            VAR_ZONA = INICIO.VER_MDU.ZONA
        Else
            If AGENDA.MDURow IsNot Nothing Then
                VAR_ACOMETIDA = AGENDA.MDURow.ACOMETIDA
                VAR_NODO = AGENDA.MDURow.NODO
                VAR_ZONA = AGENDA.MDURow.ZONA
            End If
        End If
        'BUSCAMOS TODOS LOS EDIFICIOS CON LA MISMA ACOMETIDA
        MDUTableAdapter.FillByACOMETIDA(EdificioDataSetBACKUP.MDU, VAR_ACOMETIDA, VAR_NODO, VAR_ZONA)
        MDUBindingSource.MoveFirst()
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDUDataGridView.CurrentRow.Cells(0).Value)
        BTN_AGENDAR.Enabled = True
        STATUSTableAdapter.Fill(EDIFICIODataSet.STATUS)
        CB_STATUS.Items.Clear()
        For Each STATUS In EDIFICIODataSet.STATUS
            CB_STATUS.Items.Add(STATUS.NOMBRE)
        Next

        If MDUDataGridView.CurrentRow.Cells(1).Value = 1 Then
            BTN_AGENDAR.Text = "AGENDAR EDIFICIO"
        ElseIf MDUDataGridView.CurrentRow.Cells(1).Value = 4 Then
            BTN_AGENDAR.Text = "AGENDAR EDIF CERTIFICADO"
        ElseIf MDUDataGridView.CurrentRow.Cells(1).Value = 2 Then
            BTN_AGENDAR.Text = "VER EN AGENDA"
        Else
            BTN_AGENDAR.Enabled = False
        End If

        MDUTableAdapter.FillByID(EdificioDataSetACTUALIZAR.MDU, MDUDataGridView.CurrentRow.Cells(0).Value)
        CB_STATUS.Text = CB_STATUS.Items.Item(EdificioDataSetACTUALIZAR.MDU.Rows(0).Item("ID_STATUS") - 1)
        '  If EdificioDataSetACTUALIZAR.MDU.Rows(0).Item("ID_STATUS") = 2 Then
        AGENDATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.AGENDA, CInt(EdificioDataSetACTUALIZAR.MDU.Rows(0).Item("ID_MDU")))
        If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
            LBL_FECHA_AGENDA.Text = "AGENDADO PARA EL: " & CDate(EDIFICIODataSet.AGENDA.Rows(EDIFICIODataSet.AGENDA.Rows.Count - 1).Item("DIA_AGENDA")).ToShortDateString
            LBL_CANTIDAD_AGENDAMIENTOS.Text = "CANT.AGENDAMIENTOS: " & EDIFICIODataSet.AGENDA.Rows.Count
        Else
            LBL_FECHA_AGENDA.Text = "Sin agendamientos"
            LBL_CANTIDAD_AGENDAMIENTOS.Text = ""
        End If


        BITACORATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.BITACORA, CInt(MDUDataGridView.CurrentRow.Cells(0).Value))
        BITACORABindingSource.MoveLast()

        'datos de fibra
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, MDUDataGridView.CurrentRow.Cells(0).Value)
        For Each FTTBS In EDIFICIODataSet.FTTB
            If FTTBS.SPL_NRO = 1 Then
                Select Case FTTBS.NAP
                    Case 4
                        CUENTA4 += 1
                    Case 8
                        CUENTA8 += 1
                    Case 16
                        CUENTA16 += 1
                End Select
            End If
        Next
        TXT_CANT16.Text = CUENTA16
        TXT_CANT_8.Text = CUENTA8
        TXT_CANT_4.Text = CUENTA4
    End Sub
    Private Sub BTN_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click
        BITACORARow = EDIFICIODataSet.BITACORA.NewBITACORARow()
        BITACORARow.ID_EDIFICIO = INICIO.VER_MDU.ID_MDU
        BITACORARow.NOMBRE_CTTO = TXT_NOMBRE.Text
        BITACORARow.TELEFONO_CTTO = TXT_TELEFONO.Text
        BITACORARow.EMAIL_CTTO = TXT_EMAIL.Text
        BITACORARow.FECHA_ING = Today
        BITACORARow.APTO_CTTO = TXT_APTO.Text
        BITACORARow.VALIDO = CK_VALIDO.Checked
        BITACORARow.OBSERVACIONES = TXT_OBS.Text
        EDIFICIODataSet.BITACORA.AddBITACORARow(BITACORARow)
        BITACORATableAdapter.Update(BITACORARow)
        NOTIFICACION("SYS", "NUEVOS DATOS EDIFICIO INGRESADO")
    End Sub
    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        BITACORATableAdapter.FillByID(EdificioDataSetACTUALIZAR.BITACORA, BITACORADataGridView.CurrentRow.Cells(1).Value)
        If EdificioDataSetACTUALIZAR.BITACORA.Rows.Count > 0 Then
            BITACORARow = EdificioDataSetACTUALIZAR.BITACORA.Rows(0)
            BITACORARow.NOMBRE_CTTO = TXT_NOMBRE.Text
            BITACORARow.TELEFONO_CTTO = TXT_TELEFONO.Text
            BITACORARow.EMAIL_CTTO = TXT_EMAIL.Text
            BITACORARow.APTO_CTTO = TXT_APTO.Text
            BITACORARow.VALIDO = CK_VALIDO.Checked
            BITACORARow.OBSERVACIONES = TXT_OBS.Text
            BITACORARow.FECHA_ING = Today
            BITACORATableAdapter.Update(BITACORARow)
            BITACORATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.BITACORA, CInt(MDUDataGridView.CurrentRow.Cells(0).Value))
            '   BITACORABindingSource.MoveLast()
            NOTIFICACION("SYS", "REGISTRO MODIFICADO")
        End If
    End Sub
    Private Sub FTTBDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles FTTBDataGridView.SelectionChanged
        If FTTBDataGridView.Rows.Count > 0 AndAlso IsDBNull(EDIFICIODataSet.FTTB.Rows(FTTBBindingSource.Position).Item("OBS_TEC")) = False Then
            TXT_OBS_TEC.Text = EDIFICIODataSet.FTTB.Rows(FTTBBindingSource.Position).Item("OBS_TEC")
        Else
            TXT_OBS_TEC.Text = ""
        End If
    End Sub
    Private Sub BTN_AGENDAR_Click(sender As Object, e As EventArgs) Handles BTN_AGENDAR.Click
        If BTN_AGENDAR.Text = "AGENDAR EDIFICIO" Then
            ACCION_AGENDA = "AGENDAR"
        ElseIf BTN_AGENDAR.Text = "AGENDAR EDIF CERTIFICADO" Then
            ACCION_AGENDA = "AGENDAR CERTIFICADO"
        ElseIf BTN_AGENDAR.Text = "VER EN AGENDA CERTIFICACION" Then
            ACCION_AGENDA = "VISTA CERTIFICADOS"
        Else
            ACCION_AGENDA = "VER AGENDAMIENTO"
        End If
        If AGENDA.Visible Then
            AGENDA.Close()
        End If
        AGENDA.EDI_ID_AGENDAR = MDUDataGridView.CurrentRow.Cells(0).Value
        AGENDA.Show(Me)
    End Sub
    Private Sub MDUDataGridView_Click(sender As Object, e As EventArgs) Handles MDUDataGridView.Click
        CUENTA16 = 0
        CUENTA8 = 0
        CUENTA4 = 0
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, CInt(MDUDataGridView.CurrentRow.Cells(0).Value))
        For Each FTTBS In EDIFICIODataSet.FTTB
            If FTTBS.SPL_NRO = 1 Then
                Select Case FTTBS.NAP
                    Case 4
                        CUENTA4 += 1
                    Case 8
                        CUENTA8 += 1
                    Case 16
                        CUENTA16 += 1
                End Select
            End If
        Next
        TXT_CANT16.Text = CUENTA16
        TXT_CANT_8.Text = CUENTA8
        TXT_CANT_4.Text = CUENTA4
        BITACORATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.BITACORA, CInt(MDUDataGridView.CurrentRow.Cells(0).Value))
        BTN_AGENDAR.Enabled = True
        If MDUDataGridView.CurrentRow.Cells(1).Value = 1 Then
            BTN_AGENDAR.Text = "AGENDAR EDIFICIO"
        ElseIf MDUDataGridView.CurrentRow.Cells(1).Value = 2 Then
            BTN_AGENDAR.Text = "VER EN AGENDA"
        ElseIf MDUDataGridView.CurrentRow.Cells(1).Value = 5 Then
            BTN_AGENDAR.Text = "VER EN AGENDA CERTIFICACION"
        ElseIf MDUDataGridView.CurrentRow.Cells(1).Value = 4 Then
            BTN_AGENDAR.Text = "AGENDAR EDIF CERTIFICADO"
        Else
            BTN_AGENDAR.Enabled = False
        End If

        MDUTableAdapter.FillByID(EdificioDataSetACTUALIZAR.MDU, MDUDataGridView.CurrentRow.Cells(0).Value)
        CB_STATUS.Text = CB_STATUS.Items.Item(EdificioDataSetACTUALIZAR.MDU.Rows(0).Item("ID_STATUS") - 1)

        AGENDATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.AGENDA, CInt(EdificioDataSetACTUALIZAR.MDU.Rows(0).Item("ID_MDU")))
        If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
            LBL_FECHA_AGENDA.Text = "AGENDADO PARA EL: " & CDate(EDIFICIODataSet.AGENDA.Rows(EDIFICIODataSet.AGENDA.Rows.Count - 1).Item("DIA_AGENDA")).ToShortDateString
            LBL_CANTIDAD_AGENDAMIENTOS.Text = "CANT.AGENDAMIENTOS: " & EDIFICIODataSet.AGENDA.Rows.Count
        Else
            LBL_FECHA_AGENDA.Text = "Sin agendamientos"
            LBL_CANTIDAD_AGENDAMIENTOS.Text = ""
        End If
    End Sub
    Private Sub DETALLE_MDU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.Handled = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BTN_IMPRIMIR_ORDTEC_Click(sender As Object, e As EventArgs) Handles BTN_IMPRIMIR_ORDTEC.Click
        Dim FUENTETITULOCOTI As Font = FontFactory.GetFont("arial", 30, 1)
        Dim FUENTE As Font = FontFactory.GetFont("arial", 10, 1)
        Dim barra As New BaseColor(84, 84, 84)
        Dim BORRAR As New BaseColor(255, 255, 255)
        Dim P As Process
        Dim CANT_NAPS4 As Integer
        Dim CANT_NAPS8 As Integer
        Dim CANT_NAPS16 As Integer
        Dim STR_ZONA As String
        Dim STR_NRO_NAP As String
        Dim STR_ACOMETIDA As String
        Dim STR_NOMBRES_NAP(20) As String
        Dim VALORANTERIOR As Integer
        Dim CANT_NAP As Integer
        Dim NAP_TEXT As String
        Dim NAP_TEXT_NRO As String
        Dim CAJA_NUMERO As String
        Dim STR_CAJA_DISTRIBUCION As String
        Dim UBICACION As String = ""
        Dim valorAcometida As Integer = 0
        For Each P In Process.GetProcesses()
            If (P IsNot Nothing) And (P.ProcessName = "AcroRD32") Then
                P.Kill()
            End If
        Next
        If Directory.Exists("C:\DOCUMENTOS\ARCHIVOS") = False Then
            Directory.CreateDirectory("C:\DOCUMENTOS\ARCHIVOS")
        End If
        Dim RUTA As String = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF"
        If File.Exists("C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF") = True Then
            Try
                File.Delete("C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF")
            Catch ex As Exception
                Dim archivos = My.Computer.FileSystem.GetFiles("C:\DOCUMENTOS\ARCHIVOS\")
                If archivos.Count >= 1 Then
                    For X = 1 To archivos.Count
                        Try
                            If File.Exists(Path.GetFullPath(archivos(X))) = True Then
                                File.Delete(Path.GetFullPath(archivos(X)))
                            End If
                        Catch eM As Exception

                        End Try
                    Next
                    archivos = My.Computer.FileSystem.GetFiles("C:\DOCUMENTOS\ARCHIVOS\")
                    If archivos.Count >= 1 Then
                        RUTA = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR(" & archivos.Count & ").PDF"
                    Else
                        RUTA = "C:\DOCUMENTOS\ARCHIVOS\IMPRIMIR.PDF"
                    End If

                End If
            End Try
        End If

        'ARMADO DEL DOCUMENTO PDF
        Dim DOCUMENTO As New Document(PageSize.A4, 3, 3, 15, 15)
        Dim writer As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(RUTA, FileMode.Create))
        DOCUMENTO.Open()

        Dim CeldaVACIA As New PdfPCell(New Phrase("")) With {
           .Border = 0,
           .Padding = 7
        }
        Dim CeldaVACIALeft As New PdfPCell(New Phrase("")) With {
           .Border = 0,
           .BorderWidthLeft = 1,
           .Padding = 7
        }
        Dim CeldaVACIARight As New PdfPCell(New Phrase("")) With {
           .Border = 0,
           .BorderWidthRight = 1,
           .Padding = 7
        }
        Dim CeldaCANTvacias As New PdfPCell(New Phrase("")) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .Colspan = 1
            }
        Dim CeldaCANTvaciasRight As New PdfPCell(New Phrase("")) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthRight = 1,
            .Colspan = 1
            }
        Dim CeldaCANTvaciasLeft As New PdfPCell(New Phrase("")) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthLeft = 1,
            .Colspan = 1
            }
        'NUEVA LINEA (12 COLUMNAS)
        ENCABEZADO = New PdfPTable(12) With {
            .WidthPercentage = 95
            }

        'CARGADO DE DATOS
        Dim GIF As Image = Image.GetInstance(My.Resources.equital, Imaging.ImageFormat.Png)
        GIF.ScalePercent(28)
        Dim CeldaLOGO As New PdfPCell(GIF) With {
            .Border = 0,
            .Colspan = 4,
            .VerticalAlignment = Element.ALIGN_TOP
        }
        ENCABEZADO.AddCell(CeldaLOGO)
        Dim celdaORDENTRABAJO As New PdfPCell(New Phrase("FTTH EN EDIFICIOS", FontFactory.GetFont("Helvetica", 16, 1))) With {
            .Border = 0,
            .Colspan = 8,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
        ENCABEZADO.AddCell(celdaORDENTRABAJO)
        MDUTableAdapter.FillByACOMETIDA(EdificioDataSetBACKUP.MDU, MDUDataGridView.CurrentRow.Cells(12).Value, MDUDataGridView.CurrentRow.Cells(5).Value, MDUDataGridView.CurrentRow.Cells(6).Value)
        Dim cantTorres As Integer = 0
        Dim NroAcometida As Integer = 0
        Dim acometidas As String = ""
        Dim fibrasConectadas As Integer = 0
        Dim id_edificio As Integer = 0

        For X = 1 To 12
            ENCABEZADO.AddCell(CeldaVACIA)
        Next
        CUENTA4 = 0
        CUENTA8 = 0
        CUENTA16 = 0
        For Each MDU In EdificioDataSetBACKUP.MDU
            cantTorres += MDU.TORRE
            FTTBTableAdapter.FillByID_EDIFICIO(EdificioDataSetBACKUP.FTTB, MDU.ID_MDU)
            For Each FTTBS In EdificioDataSetBACKUP.FTTB
                Select Case FTTBS.NAP
                    Case 16
                        CUENTA16 += 1
                    Case 8
                        CUENTA8 += 1
                    Case 4
                        CUENTA4 += 1
                End Select
                If FTTBS.ACOMETIDA <> NroAcometida Then
                    If fibrasConectadas < 1 Then
                        If FTTBS.ACOMETIDA < 10 Then
                            acometidas += "0" & FTTBS.ACOMETIDA
                        Else
                            acometidas += CStr(FTTBS.ACOMETIDA)
                        End If
                    Else
                        If FTTBS.ACOMETIDA < 10 Then
                            acometidas += ", A0" & FTTBS.ACOMETIDA
                        Else
                            acometidas += ", A" & FTTBS.ACOMETIDA
                        End If
                    End If
                End If
                fibrasConectadas += 1
                NroAcometida = FTTBS.ACOMETIDA
            Next
        Next

        'NUEVA LIENA
        Dim CeldaACOMETIDA As New PdfPCell(New Phrase("Acometida A" & acometidas, FontFactory.GetFont("ARIAL", 12, 1))) With {
            .BorderWidth = 1,
            .Colspan = 5,
            .Padding = 5,
            .HorizontalAlignment = Element.ALIGN_MIDDLE,
             .VerticalAlignment = Element.ALIGN_CENTER
            }
        ENCABEZADO.AddCell(CeldaACOMETIDA)
        Dim CeldaEDIFICIO As New PdfPCell(New Phrase("Edificios " & cantTorres, FontFactory.GetFont("ARIAL", 12, 1))) With {
            .BorderWidth = 1,
            .Colspan = 4,
            .Padding = 5,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_CENTER
            }
        ENCABEZADO.AddCell(CeldaEDIFICIO)
        Dim CeldaNAP16 As New PdfPCell(New Phrase("NAP16: " & CUENTA16 / 2, FontFactory.GetFont("ARIAL", 9, 1))) With {
            .BorderWidth = 1,
            .Colspan = 1,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_MIDDLE
            }
        ENCABEZADO.AddCell(CeldaNAP16)
        Dim CeldaNAP8 As New PdfPCell(New Phrase("NAP8: " & CUENTA8, FontFactory.GetFont("ARIAL", 9, 1))) With {
            .BorderWidth = 1,
            .Colspan = 1,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_MIDDLE
            }
        ENCABEZADO.AddCell(CeldaNAP8)
        Dim CeldaNAP4 As New PdfPCell(New Phrase("NAP4: " & CUENTA4, FontFactory.GetFont("ARIAL", 9, 1))) With {
            .BorderWidth = 1,
            .Colspan = 1,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_MIDDLE
            }
        ENCABEZADO.AddCell(CeldaNAP4)

        For X = 1 To 12
            ENCABEZADO.AddCell(CeldaVACIA)
        Next

        'CICLO PARA ARMAR LOS DATOS DEL/LOS EDIFICIOS AFECTADOS
        For Each MDU In EdificioDataSetBACKUP.MDU
            CUENTA4 = 0
            CUENTA8 = 0
            CUENTA16 = 0

            FTTBTableAdapter.FillByID_EDIFICIO(EdificioDataSetBACKUP.FTTB, MDU.ID_MDU)
            For Each FTTBS In EdificioDataSetBACKUP.FTTB
                If FTTBS.SPL_NRO = 1 Then
                    Select Case FTTBS.NAP
                        Case 4
                            CUENTA4 += 1
                        Case 8
                            CUENTA8 += 1
                        Case 16
                            CUENTA16 += 1
                    End Select
                End If
            Next
            'DATOS DE AGENDA
            AGENDATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.AGENDA, CInt(MDU.ID_MDU))
            If EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
                AGENDARow = EDIFICIODataSet.AGENDA.Rows(EDIFICIODataSet.AGENDA.Rows.Count - 1)
                TECNICOSTableAdapter.FillByidTEC(EDIFICIODataSet.TECNICOS, AGENDARow.ID_TECNICO)
                TECNICORow = EDIFICIODataSet.TECNICOS.Rows(0)
                TURNOSTableAdapter.FillByIDTURNO(EDIFICIODataSet.TURNOS, AGENDARow.ID_TURNO)
                TURNORow = EDIFICIODataSet.TURNOS.Rows(0)

                'NUEVA LINEA DATOS DEL TECNICO Y AGENDA
                Dim CeldaNOMBRETEC As New PdfPCell(New Phrase("TECNICO:", FontFactory.GetFont("ARIAL", 8, 0))) With {
            .BorderWidth = 0,
            .BorderWidthLeft = 1,
            .BorderWidthTop = 1,
            .Colspan = 1,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNOMBRETEC)
                Dim CeldaNOMBRETECValue As New PdfPCell(New Phrase(TECNICORow.NOMBRE, FontFactory.GetFont("ARIAL", 12, 1))) With {
            .BorderWidth = 0,
            .Colspan = 4,
            .BorderWidthTop = 1,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNOMBRETECValue)
                Dim CeldaDIAAGENDA As New PdfPCell(New Phrase("DIA AGENDADO:", FontFactory.GetFont("ARIAL", 9, 0))) With {
           .BorderWidth = 0,
           .BorderWidthTop = 1,
           .Colspan = 2,
           .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaDIAAGENDA)
                Dim CeldaDIAAGENDAValue As New PdfPCell(New Phrase(AGENDARow.DIA_AGENDA, FontFactory.GetFont("ARIAL", 9, 1))) With {
            .BorderWidth = 0,
            .BorderWidthTop = 1,
            .Colspan = 2,
             .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaDIAAGENDAValue)
                Dim CeldaTURNO As New PdfPCell(New Phrase("TURNO:", FontFactory.GetFont("ARIAL", 9, 0))) With {
             .BorderWidth = 0,
             .BorderWidthTop = 1,
             .Colspan = 1,
             .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
              }
                ENCABEZADO.AddCell(CeldaTURNO)
                Dim CeldaTURNOValue As New PdfPCell(New Phrase(TURNORow.HORARIO, FontFactory.GetFont("ARIAL", 9, 1))) With {
            .BorderWidth = 0,
            .BorderWidthTop = 1,
            .BorderWidthRight = 1,
            .Colspan = 2,
             .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaTURNOValue)
            End If

            'NUEVA LINEA DATOS EL EDIFICIO
            Dim CeldaDIRECCION As New PdfPCell(New Phrase("DIRECCION:", FontFactory.GetFont("Arial", 12, 0))) With {
            .BorderWidth = 0,
            .BorderWidthLeft = 1,
            .BorderWidthTop = 1,
            .BorderWidthBottom = 1,
            .PaddingBottom = 5,
            .Colspan = 2,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaDIRECCION)
            Dim CeldaDIRECCIONValor As New PdfPCell(New Phrase(MDU.CALLE & "  " & MDU.PUERTA, FontFactory.GetFont("Arial", 15, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthTop = 1,
            .Colspan = 6,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_CENTER,
             .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaDIRECCIONValor)

            Dim CeldaNODO As New PdfPCell(New Phrase("NODO:", FontFactory.GetFont("Arial", 12, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthTop = 1,
            .Colspan = 1,
            .PaddingBottom = 5,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaNODO)
            Dim CeldaNODOValor As New PdfPCell(New Phrase(MDU.NODO, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthTop = 1,
            .Colspan = 1,
            .PaddingBottom = 5,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaNODOValor)
            Dim CeldaZONA As New PdfPCell(New Phrase("ZONA:", FontFactory.GetFont("Arial", 12, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthTop = 1,
            .PaddingBottom = 5,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaZONA)
            If MDU.ZONA < 10 Then
                STR_ZONA = "0" & MDU.ZONA
            Else
                STR_ZONA = MDU.ZONA
            End If
            Dim CeldaZONAValor As New PdfPCell(New Phrase(STR_ZONA, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 1,
            .BorderWidthRight = 1,
            .BorderWidthTop = 1,
            .PaddingBottom = 5,
            .HorizontalAlignment = Element.ALIGN_LEFT,
             .VerticalAlignment = Element.ALIGN_BOTTOM
            }
            ENCABEZADO.AddCell(CeldaZONAValor)

            'NUEVA LINEA - CANT APTOS Y PISOS
            Dim CeldaCANTIDAD As New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 12, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .BorderWidthLeft = 1,
            .Colspan = 2,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT
        }
            ENCABEZADO.AddCell(CeldaCANTIDAD)
            Dim CeldaPISOS As New PdfPCell(New Phrase("PISOS:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaPISOS)
            Dim CeldaPISOSValor As New PdfPCell(New Phrase(Trim(MDU.PISOS), FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaPISOSValor)
            Dim CeldaAPTOS As New PdfPCell(New Phrase("APTOS:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaAPTOS)
            Dim CeldaAPTOSValor As New PdfPCell(New Phrase(MDU.APTOS, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaAPTOSValor)
            Dim CeldaTORRES As New PdfPCell(New Phrase("TORRES:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaTORRES)
            Dim CeldaTORRESValor As New PdfPCell(New Phrase(MDU.TORRE, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
        }
            ENCABEZADO.AddCell(CeldaTORRESValor)
            If CUENTA16 > 0 Then CANT_NAPS16 = CUENTA16 Else CANT_NAPS16 = 0
            If CUENTA8 > 0 Then CANT_NAPS8 = 1 Else CANT_NAPS8 = 0
            If CUENTA4 > 0 Then CANT_NAPS4 = 1 Else CANT_NAPS4 = 0
            If CANT_NAPS16 > 0 Then
                Dim CeldaNAPS16 As New PdfPCell(New Phrase("NAPS-16:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPS16)
                Dim CeldaNAPSValor16 As New PdfPCell(New Phrase(CANT_NAPS16, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPSValor16)
            End If
            If CANT_NAPS8 >= 1 Then
                Dim CeldaNAPS8 As New PdfPCell(New Phrase("NAPS-8:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPS8)
                Dim CeldaNAPSValor8 As New PdfPCell(New Phrase(CANT_NAPS8, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .BorderWidthRight = 1,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPSValor8)
            End If
            If CANT_NAPS4 >= 1 Then
                Dim CeldaNAPS4 As New PdfPCell(New Phrase("NAPS-4:", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_RIGHT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPS4)
                Dim CeldaNAPSValor4 As New PdfPCell(New Phrase(CANT_NAPS4, FontFactory.GetFont("Arial", 12, 1))) With {
            .BorderWidth = 0,
            .BorderWidthBottom = 0,
            .Colspan = 1,
            .PaddingBottom = 7,
            .HorizontalAlignment = Element.ALIGN_LEFT,
            .VerticalAlignment = Element.ALIGN_BOTTOM
            }
                ENCABEZADO.AddCell(CeldaNAPSValor4)
            End If
            If CANT_NAPS16 = 0 Then
                If CANT_NAPS4 > 0 Then
                    ENCABEZADO.AddCell(CeldaVACIA)
                Else
                    ENCABEZADO.AddCell(CeldaVACIA)
                    ENCABEZADO.AddCell(CeldaVACIARight)
                End If
            End If
            If CANT_NAPS8 = 0 Then
                If CANT_NAPS4 > 0 Then
                    ENCABEZADO.AddCell(CeldaVACIA)
                Else
                    ENCABEZADO.AddCell(CeldaVACIA)
                    ENCABEZADO.AddCell(CeldaVACIARight)
                End If
            End If

            'NUEVAS LINEAS - RECORREMOS CADA NAP CON LA INFORMACION
            Dim CeldaNRONAP(15) As PdfPCell
            Dim CeldaDATOS(15) As PdfPCell
            Dim CeldaDATOS_AMPL(15) As PdfPCell

            Dim CAB_CAJA_NRO(15) As PdfPCell
            Dim CAB_CAJA_TIPO(15) As PdfPCell
            Dim CAB_ACOMETIDA(15) As PdfPCell
            Dim CAB_NAP_TUBO(15) As PdfPCell
            Dim CAB_NAP_PELO(15) As PdfPCell
            Dim CAB_NAP_SPL(15) As PdfPCell

            Dim CAJA_NRO(15) As PdfPCell
            Dim CAJA_TIPO(15) As PdfPCell
            Dim ACOMETIDA(15) As PdfPCell
            Dim NAP_TUBO(15) As PdfPCell
            Dim NAP_PELO(15) As PdfPCell
            Dim NAP_SPL(15) As PdfPCell


            For Each VALOR In EdificioDataSetBACKUP.FTTB
                If VALOR.ACOMETIDA <> valorAcometida Then
                    CANT_NAP = 1
                Else
                    CANT_NAP += 1
                End If
                'VERIFICAMOS SI EL NRO DE NAP ES EL MISMO O NO.(16 O 8)
                If VALORANTERIOR <> VALOR.NAP_NRO Or VALOR.ACOMETIDA <> valorAcometida Then
                    'INFORMACION DE LA CABECERA
                    'CALCULANDO EL NOMBRE DE LA NAP PARA ALMACENARLA
                    If VALOR.NAP_NRO < 10 Then
                        NAP_TEXT_NRO = "0" & VALOR.NAP_NRO
                    Else
                        NAP_TEXT_NRO = VALOR.NAP_NRO
                    End If
                    If VALOR.ACOMETIDA < 10 Then
                        STR_ACOMETIDA = "0" & VALOR.ACOMETIDA
                    Else
                        STR_ACOMETIDA = VALOR.ACOMETIDA
                    End If
                    STR_NOMBRES_NAP(CANT_NAP) = "NAP" & NAP_TEXT_NRO & "-A" & STR_ACOMETIDA & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                    CeldaNRONAP(CANT_NAP) = New PdfPCell(New Phrase(STR_NOMBRES_NAP(CANT_NAP), FontFactory.GetFont("Arial", 10, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthTop = 1,
                    .BorderWidthLeft = 1,
                    .Padding = 2,
                    .Colspan = 3,
                    .Rowspan = 3,
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .VerticalAlignment = Element.ALIGN_MIDDLE
                    }

                    ENCABEZADO.AddCell(CeldaNRONAP(CANT_NAP))
                    If VALOR.IsOBS_TECNull = False AndAlso VALOR.OBS_TEC <> "" Then
                        UBICACION = "Ubicación sugerida: " & VALOR.OBS_TEC
                    Else
                        UBICACION = ""
                    End If
                    CeldaDATOS_AMPL(CANT_NAP) = New PdfPCell(New Phrase(UBICACION, FontFactory.GetFont("Arial", 10, 0))) With {
                    .BorderWidth = 0,
                    .BorderWidthTop = 1,
                    .BorderWidthLeft = 0.5,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthRight = 1,
                    .Padding = 2,
                    .Colspan = 9,
                    .Rowspan = 1,
                    .HorizontalAlignment = Element.ALIGN_LEFT
                    }
                    ENCABEZADO.AddCell(CeldaDATOS_AMPL(CANT_NAP))

                    'nueva linea
                    CeldaDATOS_AMPL(CANT_NAP) = New PdfPCell(New Phrase("Ubicación definitiva:", FontFactory.GetFont("Arial", 10, 0))) With {
                    .BorderWidth = 0,
                    .BorderWidthLeft = 0.5,
                    .BorderWidthRight = 1,
                    .Colspan = 9,
                    .Rowspan = 2,
                    .PaddingBottom = 20,
                    .HorizontalAlignment = Element.ALIGN_LEFT,
                    .VerticalAlignment = Element.ALIGN_TOP
                    }
                    ENCABEZADO.AddCell(CeldaDATOS_AMPL(CANT_NAP))
                    'ENCABEZADOS DE CADA NAP
                    'CAJA TIPO
                    CAB_CAJA_TIPO(CANT_NAP) = New PdfPCell(New Phrase("CONEXION DESDE", FontFactory.GetFont("Arial", 8, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthTop = 0.5,
                    .BorderWidthLeft = 1,
                    .Colspan = 2,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAB_CAJA_TIPO(CANT_NAP))
                    'ACOMETIDA
                    CAB_ACOMETIDA(CANT_NAP) = New PdfPCell(New Phrase("TIPO CABLE", FontFactory.GetFont("Arial", 8, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthTop = 0.5,
                    .Colspan = 7,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAB_ACOMETIDA(CANT_NAP))
                    'NAP TUBO
                    CAB_NAP_TUBO(CANT_NAP) = New PdfPCell(New Phrase("NAP TUBO", FontFactory.GetFont("Arial", 8, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthTop = 0.5,
                    .Colspan = 1,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAB_NAP_TUBO(CANT_NAP))
                    'NAP PELO
                    CAB_NAP_PELO(CANT_NAP) = New PdfPCell(New Phrase("NAP PELO", FontFactory.GetFont("Arial", 8, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthTop = 0.5,
                    .Colspan = 1,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAB_NAP_PELO(CANT_NAP))
                    'NAP SPL
                    CAB_NAP_SPL(CANT_NAP) = New PdfPCell(New Phrase("SPL NAP", FontFactory.GetFont("Arial", 8, 1))) With {
                    .BorderWidth = 0,
                    .BorderWidthBottom = 0.5,
                    .BorderWidthTop = 0.5,
                    .BorderWidthRight = 1,
                    .Colspan = 1,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAB_NAP_SPL(CANT_NAP))

                    'dato de conexionados
                    If CANT_NAP > 1 Then
                        If VALOR.NAP_NRO - 1 < 10 Then
                            NAP_TEXT_NRO = "0" & VALOR.NAP_NRO - 1
                        Else
                            NAP_TEXT_NRO = VALOR.NAP_NRO - 1
                        End If
                        If MDUDataGridView.CurrentRow.Cells(12).Value < 10 Then
                            STR_ACOMETIDA = "0" & MDUDataGridView.CurrentRow.Cells(12).Value
                        Else
                            STR_ACOMETIDA = MDUDataGridView.CurrentRow.Cells(12).Value
                        End If
                        NAP_TEXT = "NAP" & NAP_TEXT_NRO & "-A" & STR_ACOMETIDA & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                    Else
                        '  If VALOR.NAP = 16 Then
                        If VALOR.IsCONEXION_DESDENull Then
                            CAJA_NUMERO = "(S/D)"
                        Else
                            If VALOR.CONEXION_DESDE < 10 Then
                                CAJA_NUMERO = "0" & VALOR.CONEXION_DESDE
                            Else
                                CAJA_NUMERO = VALOR.CONEXION_DESDE
                            End If
                        End If
                        If VALOR.IsCAJA_DISTRIBUCIONNull Then
                            STR_CAJA_DISTRIBUCION = "(S/D)"
                        Else
                            If VALOR.CAJA_DISTRIBUCION < 10 Then
                                STR_CAJA_DISTRIBUCION = "0" & VALOR.CAJA_DISTRIBUCION
                            Else
                                STR_CAJA_DISTRIBUCION = VALOR.CAJA_DISTRIBUCION
                            End If
                        End If
                        'EVALUAMOS SI EL NUMERO DE NAP ES MAYOR QUE 1 SIGNIFICA QUE ESTA NAP NO DEBE DE TOMAR DE LA CED O FDH
                        If VALOR.NAP_NRO > 1 Then
                            If VALOR.NAP_NRO - 1 < 10 Then
                                NAP_TEXT_NRO = "0" & VALOR.NAP_NRO - 1
                            Else
                                NAP_TEXT_NRO = VALOR.NAP_NRO - 1
                            End If
                            NAP_TEXT = "NAP" & NAP_TEXT_NRO & "-A" & STR_ACOMETIDA & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                        Else
                            If VALOR.TIPO_CONEXION_DESDE = "FDH" Then
                                NAP_TEXT = VALOR.TIPO_CONEXION_DESDE & CAJA_NUMERO & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                            Else
                                NAP_TEXT = VALOR.TIPO_CONEXION_DESDE & CAJA_NUMERO & "-D" & STR_CAJA_DISTRIBUCION & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA

                            End If
                        End If
                    End If
                    'CAJA TIPO
                    CAJA_TIPO(CANT_NAP) = New PdfPCell(New Phrase(NAP_TEXT, FontFactory.GetFont("Arial", 8, 0))) With {
                        .BorderWidth = 0,
                        .BorderWidthLeft = 1,
                        .Colspan = 2,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    ENCABEZADO.AddCell(CAJA_TIPO(CANT_NAP))
                    'ACOMETIDA
                    ACOMETIDA(CANT_NAP) = New PdfPCell(New Phrase(VALOR.CABLE, FontFactory.GetFont("Arial", 8, 0))) With {
                                .BorderWidth = 0,
                                .Colspan = 7,
                                .HorizontalAlignment = Element.ALIGN_CENTER
                                }
                    ENCABEZADO.AddCell(ACOMETIDA(CANT_NAP))
                    'NAP TUBO
                    NAP_TUBO(CANT_NAP) = New PdfPCell(New Phrase(VALOR.TUBO, FontFactory.GetFont("Arial", 8, 0))) With {
                                .BorderWidth = 0,
                                .Colspan = 1,
                                .HorizontalAlignment = Element.ALIGN_CENTER
                                }
                    ENCABEZADO.AddCell(NAP_TUBO(CANT_NAP))
                    'NAP PELO
                    NAP_PELO(CANT_NAP) = New PdfPCell(New Phrase(VALOR.PELO, FontFactory.GetFont("Arial", 8, 0))) With {
                                .BorderWidth = 0,
                                .Colspan = 1,
                                .HorizontalAlignment = Element.ALIGN_CENTER
                                }
                    ENCABEZADO.AddCell(NAP_PELO(CANT_NAP))
                    'NAP SPL
                    NAP_SPL(CANT_NAP) = New PdfPCell(New Phrase(VALOR.SPL_NRO, FontFactory.GetFont("Arial", 8, 0))) With {
                                .BorderWidth = 0,
                                .Colspan = 1,
                                .BorderWidthRight = 1,
                                .HorizontalAlignment = Element.ALIGN_CENTER
                                }
                    ENCABEZADO.AddCell(NAP_SPL(CANT_NAP))

                Else 'CUANDO NO ES LA PRIMERA LINEA

                    If CANT_NAP <= 2 Then '<=
                        If VALOR.NAP = 16 Then
                            If VALOR.IsCONEXION_DESDENull Then
                                CAJA_NUMERO = "(S/D)"
                            Else
                                If VALOR.CONEXION_DESDE < 10 Then
                                    CAJA_NUMERO = "0" & VALOR.CONEXION_DESDE
                                Else
                                    CAJA_NUMERO = VALOR.CONEXION_DESDE
                                End If
                            End If
                            If VALOR.IsCAJA_DISTRIBUCIONNull Then
                                STR_CAJA_DISTRIBUCION = "(S/D)"
                            Else
                                If VALOR.CAJA_DISTRIBUCION < 10 Then
                                    STR_CAJA_DISTRIBUCION = "0" & VALOR.CAJA_DISTRIBUCION
                                Else
                                    STR_CAJA_DISTRIBUCION = VALOR.CAJA_DISTRIBUCION
                                End If
                            End If
                            If VALOR.TIPO_CONEXION_DESDE = "FDH" Then
                                NAP_TEXT = VALOR.TIPO_CONEXION_DESDE & CAJA_NUMERO & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                            Else
                                NAP_TEXT = VALOR.TIPO_CONEXION_DESDE & CAJA_NUMERO & "-D" & STR_CAJA_DISTRIBUCION & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                            End If
                        End If
                    Else
                        '  If VALOR.NAP = 16 Then
                        If VALORANTERIOR - 1 < 10 Then
                            NAP_TEXT_NRO = "0" & VALORANTERIOR - 1
                        Else
                            NAP_TEXT_NRO = VALORANTERIOR - 1
                        End If
                        If MDUDataGridView.CurrentRow.Cells(12).Value < 10 Then
                            STR_ACOMETIDA = "0" & MDUDataGridView.CurrentRow.Cells(12).Value
                        Else
                            STR_ACOMETIDA = MDUDataGridView.CurrentRow.Cells(12).Value
                        End If
                        NAP_TEXT = "NAP" & NAP_TEXT_NRO & "-A" & STR_ACOMETIDA & "-" & MDUDataGridView.CurrentRow.Cells(5).Value & STR_ZONA
                        '  End If
                    End If

                    CAJA_TIPO(CANT_NAP) = New PdfPCell(New Phrase(NAP_TEXT, FontFactory.GetFont("Arial", 8, 0))) With {
                    .BorderWidth = 0,
                    .Colspan = 2,
                    .BorderWidthLeft = 1,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    ENCABEZADO.AddCell(CAJA_TIPO(CANT_NAP))
                    'ACOMETIDA
                    ACOMETIDA(CANT_NAP) = New PdfPCell(New Phrase(VALOR.CABLE, FontFactory.GetFont("Arial", 8, 0))) With {
                        .BorderWidth = 0,
                        .Colspan = 7,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    ENCABEZADO.AddCell(ACOMETIDA(CANT_NAP))
                    'NAP TUBO
                    NAP_TUBO(CANT_NAP) = New PdfPCell(New Phrase(VALOR.TUBO, FontFactory.GetFont("Arial", 8, 0))) With {
                        .BorderWidth = 0,
                        .Colspan = 1,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    ENCABEZADO.AddCell(NAP_TUBO(CANT_NAP))
                    'NAP PELO
                    NAP_PELO(CANT_NAP) = New PdfPCell(New Phrase(VALOR.PELO, FontFactory.GetFont("Arial", 8, 0))) With {
                        .BorderWidth = 0,
                        .Colspan = 1,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    ENCABEZADO.AddCell(NAP_PELO(CANT_NAP))
                    NAP_SPL(CANT_NAP) = New PdfPCell(New Phrase(VALOR.SPL_NRO, FontFactory.GetFont("Arial", 8, 0))) With {
                        .BorderWidth = 0,
                        .Colspan = 1,
                        .BorderWidthRight = 1,
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        }
                    ENCABEZADO.AddCell(NAP_SPL(CANT_NAP))

                    STR_NOMBRES_NAP(CANT_NAP) = ""
                End If

                VALORANTERIOR = VALOR.NAP_NRO
                valorAcometida = VALOR.ACOMETIDA
            Next
            ENCABEZADO.AddCell(CeldaCANTvaciasLeft)
            For X = 1 To 10
                ENCABEZADO.AddCell(CeldaCANTvacias)
            Next
            ENCABEZADO.AddCell(CeldaCANTvaciasRight)

            BITACORATableAdapter.FillByEDIF_ACTIVO(EdificioDataSetBACKUP.BITACORA, CInt(MDU.ID_MDU))
            If EdificioDataSetBACKUP.BITACORA.Rows.Count > 0 Then

                Dim email As String
                If IsDBNull(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("EMAIL_CTTO")) = False AndAlso EdificioDataSetBACKUP.BITACORA.Rows(0).Item("EMAIL_CTTO") <> "" Then
                    email = EdificioDataSetBACKUP.BITACORA.Rows(0).Item("EMAIL_CTTO")
                Else
                    email = ""
                End If
                'ENCABEZADOS DE CONTACTO
                '1
                Dim CeldaAPTO As New PdfPCell(New Phrase("CONTACTO", FontFactory.GetFont("Arial", 10, 0))) With {
                .Colspan = 3,
                .BorderWidth = 0,
                .BorderWidthLeft = 1,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaAPTO)
                '2
                Dim CeldaCONTACTO As New PdfPCell(New Phrase("NOMBRE", FontFactory.GetFont("Arial", 10, 0))) With {
                .Border = 0,
                .Colspan = 3,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaCONTACTO)
                '3
                Dim CeldaTELEFONO As New PdfPCell(New Phrase("TELEFONO", FontFactory.GetFont("Arial", 10, 0))) With {
                .Border = 0,
                .Colspan = 3,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaTELEFONO)
                '4
                Dim CeldaEMAIL As New PdfPCell(New Phrase("EMAIL", FontFactory.GetFont("Arial", 10, 0))) With {
                .BorderWidth = 0,
                .Colspan = 3,
                .BorderWidthRight = 1,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaEMAIL)
                'NUEVA LIENA
                'VALORES DE LOS ENCABEZADOS
                Dim CeldaAPTOValor As New PdfPCell(New Phrase(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("APTO_CTTO"), FontFactory.GetFont("Arial", 10, 1))) With {
                .Colspan = 3,
                .BorderWidth = 0,
                .BorderWidthLeft = 1,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaAPTOValor)
                Dim CeldaCONTACTOValor As New PdfPCell(New Phrase(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("NOMBRE_CTTO"), FontFactory.GetFont("Arial", 10, 1))) With {
                .Border = 0,
                .Colspan = 3,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaCONTACTOValor)

                Dim CeldaTELEFONOValor As New PdfPCell(New Phrase(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("TELEFONO_CTTO"), FontFactory.GetFont("Arial", 10, 1))) With {
                .Border = 0,
                .Colspan = 3,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaTELEFONOValor)

                Dim CeldaEMAILValor As New PdfPCell(New Phrase(email, FontFactory.GetFont("Arial", 10, 1))) With {
                .BorderWidth = 0,
                .Colspan = 3,
                .BorderWidthRight = 1,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
                ENCABEZADO.AddCell(CeldaEMAILValor)

                'NUEVA LIENA OBSERVACIONES DE CONTACTO
                Dim observa As String
                If IsDBNull(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("OBSERVACIONES")) Then
                    observa = ""
                Else
                    observa = Trim(EdificioDataSetBACKUP.BITACORA.Rows(0).Item("OBSERVACIONES"))
                End If
                Dim CeldaOBSCONTACTOValor As New PdfPCell(New Phrase(observa, FontFactory.GetFont("Arial", 10, 0))) With {
                .HorizontalAlignment = Element.ALIGN_LEFT,
                .BorderWidth = 0,
                .BorderWidthBottom = 1,
                .BorderWidthRight = 1,
                .BorderWidthLeft = 1,
                .PaddingBottom = 7,
                .Colspan = 12
                }
                ENCABEZADO.AddCell(CeldaOBSCONTACTOValor)
            End If

            'For X = 1 To 12
            '    ENCABEZADO.AddCell(CeldaVACIA)
            'Next
        Next
        Dim TEMPLATE As PdfTemplate = writer.DirectContent().CreateTemplate(40, 18)
        TEMPLATE.SetColorStroke(barra)
        TEMPLATE.SetColorFill(BORRAR)
        TEMPLATE.SetLineWidth(1.5F)
        TEMPLATE.Circle(20, 8, 7)
        TEMPLATE.FillStroke()
        writer.ReleaseTemplate(TEMPLATE)
        Dim CeldaC1 As New PdfPCell(Image.GetInstance(TEMPLATE)) With {
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .BorderWidth = 0.5,
            .Colspan = 1
        }
        Dim CeldaC2 As New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 9, 0))) With {
       .BorderWidth = 0.5,
           .Colspan = 2,
           .Padding = 10,
           .PaddingLeft = 6,
           .HorizontalAlignment = Element.ALIGN_LEFT
       }
        Dim CeldaC3 As New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 3,
            .Padding = 10
        }
        Dim CeldaC4 As New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 4,
            .Padding = 10
        }
        'NUEVA FILA PARA INGRESAR EL DATO CODIGO DE BOBINA - HORA INICIO Y HORA FIN
        Dim CeldaC2Bold As New PdfPCell(New Phrase("", FontFactory.GetFont("Arial", 9, 0))) With {
           .BorderWidth = 1.5,
           .Colspan = 2,
           .Padding = 10
       }
        Dim CeldaCODBobina As New PdfPCell(New Phrase("Codigo BOBINA", FontFactory.GetFont("Arial", 10, 1))) With {
                .BorderWidth = 1.5,
                .Colspan = 2,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
        ENCABEZADO.AddCell(CeldaCODBobina)
        ENCABEZADO.AddCell(CeldaC2Bold)
        Dim CeldaHoraInicio As New PdfPCell(New Phrase("Hora Inicio", FontFactory.GetFont("Arial", 10, 1))) With {
                .BorderWidth = 1.5,
                .Colspan = 2,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
        ENCABEZADO.AddCell(CeldaHoraInicio)
        ENCABEZADO.AddCell(CeldaC2Bold)
        Dim CeldaHoraFin As New PdfPCell(New Phrase("Hora Fin", FontFactory.GetFont("Arial", 10, 1))) With {
                .BorderWidth = 1.5,
                .Colspan = 2,
                .HorizontalAlignment = Element.ALIGN_CENTER
                }
        ENCABEZADO.AddCell(CeldaHoraFin)
        ENCABEZADO.AddCell(CeldaC2Bold)

        'NUEVA LIENA DATOS PARA INGRESAR POR TECNICO
        Dim CeldaTITULOValor As New PdfPCell(New Phrase("REGISTRO DE RECORRIDO PARA ACOMETIDA DEL EDIFICIO", FontFactory.GetFont("Arial", 12, 0))) With {
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .BorderWidth = 0,
            .PaddingTop = 10,
            .PaddingBottom = 2,
            .Colspan = 12
            }
        ENCABEZADO.AddCell(CeldaTITULOValor)

        'NUEVA FILA CUADROS
        Dim CeldaPuntoTitulo As New PdfPCell(New Phrase("Registro", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 2,
            .Rowspan = 2,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaPuntoTitulo)
        Dim CeldaNMetrajeFibra As New PdfPCell(New Phrase("Nº marca fibra", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 6,
            .Rowspan = 1,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaNMetrajeFibra)
        Dim CeldaNMetrajeInicial As New PdfPCell(New Phrase("Recorrido", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 4,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaNMetrajeInicial)
        Dim CeldaNMetrajeFinal As New PdfPCell(New Phrase("Inicial", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 3,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaNMetrajeFinal)
        Dim CeldaSoporte As New PdfPCell(New Phrase("Final", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 3,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaSoporte)
        Dim CeldaAereo As New PdfPCell(New Phrase("Aéreo", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 1,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaAereo)
        Dim CeldaSubterraneo As New PdfPCell(New Phrase("Subte", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 1,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaSubterraneo)
        Dim CeldaOculto As New PdfPCell(New Phrase("Oculto", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 1,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaOculto)
        Dim CeldaInterna As New PdfPCell(New Phrase("Interna", FontFactory.GetFont("Arial", 9, 0))) With {
            .BorderWidth = 0.5,
            .Colspan = 1,
            .Padding = 2,
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_CENTER
        }
        ENCABEZADO.AddCell(CeldaInterna)


        For X = 1 To 15
            ENCABEZADO.AddCell(CeldaC2)
            ENCABEZADO.AddCell(CeldaC3)
            ENCABEZADO.AddCell(CeldaC3)

            ENCABEZADO.AddCell(CeldaC1)
            ENCABEZADO.AddCell(CeldaC1)
            ENCABEZADO.AddCell(CeldaC1)
            ENCABEZADO.AddCell(CeldaC1)
        Next

        DOCUMENTO.Add(ENCABEZADO)
        DOCUMENTO.Close()

        Process.Start(RUTA)

        'IMPRIMIR_ORDEN.Show()
    End Sub
    Private Sub BTN_ACTUALIZAR_sTATUS_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR_sTATUS.Click
        'BUSCAMOS EL EDFICIO A MODIFICAR
        MDUTableAdapter.FillByID(EdificioDataSetACTUALIZAR.MDU, MDUDataGridView.CurrentRow.Cells(0).Value)
        ACT_MDURow = EdificioDataSetACTUALIZAR.MDU.Rows(0)
        ACT_MDURow.ID_STATUS = CB_STATUS.SelectedIndex + 1
        ACT_MDURow.MODIFICADO = Today.ToShortDateString
        MDUTableAdapter.Update(ACT_MDURow)
        DETALLE_MDU_Load(Nothing, Nothing)
        NOTIFICACION("SYS", "EDIFICIO ACTUALIZADO")
    End Sub
    Private Sub BTN_ELIMINAR_CTTO_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR_CTTO.Click
        BITACORATableAdapter.FillByID(EdificioDataSetACTUALIZAR.BITACORA, BITACORADataGridView.CurrentRow.Cells(1).Value)
        EdificioDataSetACTUALIZAR.BITACORA.Rows(0).Delete()
        BITACORATableAdapter.Update(EdificioDataSetACTUALIZAR.BITACORA)
        DETALLE_MDU_Load(Nothing, Nothing)
        BITACORATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.BITACORA, CInt(MDUDataGridView.CurrentRow.Cells(0).Value))
        NOTIFICACION("SYS", "CONTACTO ELIMINADO")
    End Sub

End Class