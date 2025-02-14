Imports Microsoft.Office.Interop
Module EXPORTAR_EXCEL
    Function RetornaLetra(ByVal numero As Integer)
        Dim abc As String = "abcdefghijklmnopqrstuvwxyz"
        Dim letra As String
        If numero > Len(abc) * 2 Then
            letra = "b" & Mid(abc, numero - Len(abc) * 2, 1)
        ElseIf numero > Len(abc) Then
            letra = "a" & Mid(abc, numero - Len(abc), 1)
        Else
            letra = Mid(abc, numero, 1)
        End If
        Return letra
    End Function
    Sub ExportarExcel(ByVal DtReport As DataTable, ByVal Titulo As String, Optional ByVal pgbar As ProgressBar = Nothing, Optional ByVal lbl As Label = Nothing)
        Try
            Dim Iprogres As Double = 0
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim m_Excel = New Excel.Application
            m_Excel.Visible = False

            objLibroExcel = m_Excel.Workbooks.Add()
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()

            Dim objCelda As Excel.Range

            For Jx As Integer = 0 To DtReport.Columns.Count - 1
                objCelda = objHojaExcel.Range(RetornaLetra(Jx + 1) & "1", Type.Missing)
                objCelda.Value = DtReport.Columns(Jx).Caption
            Next

            Dim i As Integer = 2
            Dim acu As Double = 0

            Iprogres = 100 / (DtReport.Rows.Count - 1)
            If Not pgbar Is Nothing Then
                pgbar.Step = Iprogres
            End If

            For Ix As Integer = 0 To DtReport.Rows.Count - 1
                For Jx As Integer = 0 To DtReport.Columns.Count - 1
                    Try
                        If IsDBNull(DtReport.Rows(Ix).Item(Jx)) = False AndAlso DtReport.Rows(Ix).Item(Jx) = "SIN AGENDAMIENTO" Then objHojaExcel.Cells(i, RetornaLetra(Jx + 1)).Font.Color = Color.Green
                    Catch ex As Exception

                    End Try
                    objHojaExcel.Cells(i, RetornaLetra(Jx + 1)) = DtReport.Rows(Ix).Item(Jx).ToString
                Next
                i += 1

                If Not pgbar Is Nothing Then
                    If Not acu + Iprogres > 100 Then
                        acu += Iprogres
                    End If
                    pgbar.Value = acu
                End If

                If Not lbl Is Nothing Then
                    lbl.Text = CInt(acu) & "%"
                End If
            Next

            Dim objRango As Excel.Range = objHojaExcel.Range("A1:" & RetornaLetra(DtReport.Columns.Count) & DtReport.Rows.Count + 1)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.AutoFilter(1, , VisibleDropDown:=True)
            objRango.Font.Name = "TAHOMA"
            objRango.Font.Size = 10
            objRango.HorizontalAlignment = HorizontalAlignment.Center
            objRango.Borders.LineStyle = 0
            objHojaExcel = Nothing
            objLibroExcel = Nothing

            m_Excel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
