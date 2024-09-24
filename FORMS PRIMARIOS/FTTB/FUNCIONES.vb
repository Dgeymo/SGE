Module FUNCIONES
    Public ACCION_AGENDA As String
    Dim EDIFICIO As EDIFICIODataSet.MDURow
    Public Sub ACTUALIZAR_INFO_MDU(Optional TODOS As String = Nothing)
        INICIO.STATUSTableAdapter.Fill(INICIO.EDIFICIODataSet.STATUS)
        INICIO.EDIFICIODataSet.EDIF_VISTA.Clear()
        If TODOS IsNot Nothing Then
            INICIO.MDUTableAdapter.Fill(INICIO.EDIFICIODataSet.MDU)
            For Each EDIFICIO In INICIO.EDIFICIODataSet.MDU
                AGREGAR()
            Next
        Else
            INICIO.AVANCETableAdapter.FillByHABILITADOS(INICIO.EdificioDataSetBackUp.AVANCE)

            INICIO.EDIFICIODataSet.EDIF_VISTA.Clear()
            For Each AVANCE In INICIO.EdificioDataSetBackUp.AVANCE
                If AVANCE.VER_SUBTERRANEO = True Then
                    INICIO.MDUTableAdapter.FillByINGRESO_ZONA(INICIO.EDIFICIODataSet.MDU, "SUBTERRANEO", AVANCE.ZONA)
                    For Each EDIFICIO In INICIO.EDIFICIODataSet.MDU
                        AGREGAR()
                    Next
                End If
                If AVANCE.VER_DUCTOS_FECHADA = True Then
                    INICIO.MDUTableAdapter.FillByINGRESO_ZONA(INICIO.EDIFICIODataSet.MDU, "DUCTO", AVANCE.ZONA)
                    For Each EDIFICIO In INICIO.EDIFICIODataSet.MDU
                        AGREGAR()
                    Next
                End If
                If AVANCE.VER_AEREOS = True Then
                    INICIO.MDUTableAdapter.FillByINGRESO_ZONA(INICIO.EDIFICIODataSet.MDU, "AEREO", AVANCE.ZONA)
                    For Each EDIFICIO In INICIO.EDIFICIODataSet.MDU
                        AGREGAR()
                    Next
                End If
            Next
        End If
        marcarVencidos()
        INICIO.LBL_CANT_ROWS.Text = "MOSTRANDO: " & INICIO.EDIF_VISTABindingSource.Count & " EDIFICIOS"
        INICIO.AVANCETableAdapter.Fill(INICIO.EDIFICIODataSet.AVANCE)
    End Sub
    Public Sub marcarVencidos()
        If INICIO.DGV_EDIFICIOS.Rows.Count > 0 Then
            For i = 0 To INICIO.DGV_EDIFICIOS.Rows.Count - 1
                If IsDBNull(INICIO.DGV_EDIFICIOS.Rows(i).Cells(7).Value) = False Then
                    If CDate(INICIO.DGV_EDIFICIOS.Rows(i).Cells(7).Value) < Today Then
                        INICIO.DGV_EDIFICIOS.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                    Else
                        INICIO.DGV_EDIFICIOS.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub AGREGAR()
        INICIO.VER_EDIFICIO = INICIO.EDIFICIODataSet.EDIF_VISTA.NewEDIF_VISTARow()
        INICIO.VER_EDIFICIO.ID_EDIFICIO = EDIFICIO.ID_MDU
        INICIO.VER_EDIFICIO.NODO = EDIFICIO.NODO
        INICIO.VER_EDIFICIO.ZONA = EDIFICIO.ZONA
        INICIO.VER_EDIFICIO.CALLE = EDIFICIO.CALLE
        INICIO.VER_EDIFICIO.PUERTA = EDIFICIO.PUERTA
        INICIO.VER_EDIFICIO.INGRESO = EDIFICIO.INGRESO
        INICIO.VER_EDIFICIO.ACOMETIDA = EDIFICIO.ACOMETIDA
        INICIO.VER_EDIFICIO.STATUS = INICIO.EDIFICIODataSet.STATUS.Rows(EDIFICIO.ID_STATUS - 1).Item("NOMBRE")
        If EDIFICIO.ID_STATUS = 2 Or EDIFICIO.ID_STATUS = 5 Then
            INICIO.AGENDATableAdapter.FillByID_EDIFICIO(INICIO.EDIFICIODataSet.AGENDA, EDIFICIO.ID_MDU)
            If INICIO.EDIFICIODataSet.AGENDA.Rows.Count > 0 Then
                INICIO.VER_EDIFICIO.AGENDADO = INICIO.EDIFICIODataSet.AGENDA.Rows(INICIO.EDIFICIODataSet.AGENDA.Rows.Count - 1).Item("DIA_AGENDA")
            End If
        End If
        INICIO.EDIFICIODataSet.EDIF_VISTA.AddEDIF_VISTARow(INICIO.VER_EDIFICIO)
    End Sub

    'Public Async Function getMDU(ByVal id_mdu As Integer) As Task

    '    '        Dim jsonData As String = "{""token"":""c2d48b214091ac25583e68ef92b04c89"",
    '    '""id_mdu"":""" & id_mdu & """,
    '    '""id_status"":""" & id_status & """,
    '    '""id_calle"":""" & id_calle & """,
    '    '""calle"":""" & calle & """,
    '    '""puerta"":""" & puerta & """,
    '    '""aptos"":""" & aptos & """,
    '    '""pisos"":""" & pisos & """,
    '    '""nodo"":""" & nodo & """,
    '    '""zona"":""" & zona & """,
    '    '""ingreso"":""" & ingreso & """,
    '    '""torre"":""" & torre & """}"
    '    ' Dim url As String = "http://localhost/api/mdu.php"

    '    ' MsgBox(jsonData) 'Format(AGENDA_DIA, "yyyy-MM-dd")
    '    Dim url As String = "http://obra.webcindario.com/mdu.php?id_mdu=" & id_mdu
    '    Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
    '    request.Method = WebRequestMethods.Http.Get
    '    'request.Method = "POST"
    '    ' request.ContentType = "application/json"
    '    'Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(jsonData)
    '    'request.ContentLength = dataBytes.Length
    '    Dim response = Await request.GetResponseAsync()
    '    'Using stream As Stream = request.GetRequestStream()
    '    '    stream.Write(dataBytes, 0, dataBytes.Length)
    '    'End Using
    '    MsgBox(response.ToString())
    '    ' Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

    '    ' Using reader As StreamReader = New StreamReader(response.GetResponseStream())
    '    '  MsgBox(reader.ToString())
    '    '  End Using

    '    'metodo get
    '    ' Dim client As HttpWebRequest
    '    'Try
    '    '    Dim response As HttpResponseMessage = Await client.GetAsync(url)
    '    '    response.EnsureSuccessStatusCode()
    '    '    Dim responseBody As String = Await response.Content.ReadAsStringAsync()

    '    '    Console.WriteLine(responseBody)
    '    'Catch ex As Exception

    '    'End Try
    'End Function
    'Public Async Function InsertMDU(ByVal id_mdu As Integer, ByVal id_status As Integer, ByVal id_calle As Integer, ByVal calle As String, ByVal puerta As String, ByVal aptos As Integer, ByVal pisos As String, ByVal nodo As String, ByVal zona As Integer, ByVal ingreso As String, ByVal torre As Integer) As Task

    'End Function
End Module
