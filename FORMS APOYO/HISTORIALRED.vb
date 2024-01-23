Public Class HISTORIALRED

    Dim RECSS As Integer
    Dim RECOTR As Integer
    Dim ORDSS As Integer
    Dim ORDOTR As Integer
    Dim RECUTE As Integer
    Dim ORDUTE As Integer

    Dim NewORDENRow As ORDENESDataSet.CREAR_ORDRow
    Dim ORDENESRow As DataRow

    Dim FECHADESDE As Date
    Dim FECHAHASTA As Date

    Dim FILTRONODO As String
    Dim FILTROZONA As String

    Dim CAMPOFILTRO(5) As String
    Dim EXPRFILTRO(5) As String
    Dim FILTRO(5) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        DATOS.Enabled = True
    End Sub

    Private Sub CREAR_ORDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CREAR_ORDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CREAR_ORDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ORDENESDataSet)

    End Sub

    Private Sub CARGA_RECYORD()
        If Trim(ORDENESRow("MOTIVOORIGEN")) = "SIN SEÑAL TOTAL" Then
            RECSS = RECSS + ORDENESRow("RECLAMOSTOT")
            ORDSS = ORDSS + 1
            'MsgBox(RECSS)
        Else
            RECOTR = RECOTR + ORDENESRow("RECLAMOSTOT")
            ORDOTR = ORDOTR + 1
        End If

        If Trim(ORDENESRow("CAUSACIERRE")) = "UTE" Then
            RECUTE = RECUTE + ORDENESRow("RECLAMOSTOT")
            ORDUTE = ORDUTE + 1
        End If
    End Sub

    Private Sub GRABA_RECYORD()
        NewORDENRow = ORDENESDataSet.CREAR_ORD.NewCREAR_ORDRow
        NewORDENRow("NODO") = ORDENESRow("NODO")
        NewORDENRow("ZONA") = ORDENESRow("ZONA")
        NewORDENRow("CANT_RECSS") = RECSS
        NewORDENRow("CANT_ORDSS") = ORDSS
        NewORDENRow("CANT_RECOTROS") = RECOTR
        NewORDENRow("CANT_ORDOTROS") = ORDOTR
        NewORDENRow("CANT_RECUTE") = RECUTE
        NewORDENRow("CANT_ORDUTE") = ORDUTE

        ORDENESDataSet.CREAR_ORD.AddCREAR_ORDRow(NewORDENRow)

        RECSS = 0
        ORDSS = 0
        RECOTR = 0
        ORDOTR = 0
        RECUTE = 0
        ORDUTE = 0
    End Sub

    Private Sub HISTORIALRED_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NODOFILTRO.Text = DATOS.FILTRONODO

    End Sub

    Private Sub BOT_ORDENES_Click(sender As Object, e As EventArgs) Handles BOT_ORDENES.Click
        Me.Cursor = Cursors.WaitCursor
        ORDENESDataSet.CREAR_ORD.Clear()
        RECSS = 0
        RECOTR = 0
        ORDSS = 0
        ORDOTR = 0
        RECUTE = 0
        ORDUTE = 0
        FECHADESDE = DESDE_ORD.Value.ToShortDateString
        FECHAHASTA = HASTA_ORD.Value.ToShortDateString


        ORDENESTableAdapter.FillByCORRECTIVO(ORDENESDataSet.ORDENES, FECHADESDE, FECHAHASTA)

        If ORDENESDataSet.ORDENES.Rows.Count > 0 Then
            'AVANCE_ORD.Maximum = ORDENESDataSet.ORDENES.Rows.Count - 1
            For I = 0 To ORDENESDataSet.ORDENES.Rows.Count - 1
                'AVANCE_ORD.Value = I
                ORDENESRow = ORDENESDataSet.ORDENES.Rows(I)
                If I < ORDENESDataSet.ORDENES.Rows.Count - 1 Then
                    If ORDENESRow("NODO") = ORDENESDataSet.ORDENES.Rows(I + 1).Item("NODO") Then
                        If ORDENESRow("ZONA") = ORDENESDataSet.ORDENES.Rows(I + 1).Item("ZONA") Then
                            CARGA_RECYORD()
                        Else
                            CARGA_RECYORD()
                            GRABA_RECYORD()
                        End If
                    End If
                End If
            Next I
        Else
            MsgBox("No existen ordenes a procesar enlas fechas seleccionadas")
        End If
        FILTRA_NODO()
        'AVANCE_ORD.Value = 0
        Me.Cursor = DefaultCursor
    End Sub

    Private Sub CREAR_ORDDataGridView_DoubleClick(sender As Object, e As EventArgs)
        'ING_NODO.Text = Me.CREAR_ORDDataGridView.CurrentRow.Cells.Item(0).Value
        'ING_ZONA.Text = Me.CREAR_ORDDataGridView.CurrentRow.Cells.Item(1).Value
        'BUSCA_NODO.Text = ING_NODO.Text

        'FILTRONODO = ING_NODO.Text
        'FILTROZONA = ING_ZONA.Text
        'FILTRA_NODO()

    End Sub

    Private Sub FILTRA_NODO()

        Dim VISTAPRIM As DataView = ORDENESDataSet.CREAR_ORD.AsDataView
        'Dim OTRAVISTA As DataView = ORDENESDataSet.ORDENES.AsDataView

        CAMPOFILTRO(0) = "NODO"
        EXPRFILTRO(0) = NODOFILTRO.Text
        If EXPRFILTRO(0) = "" Then
            FILTRO(0) = ""

        Else
            FILTRO(0) = "  [" & CAMPOFILTRO(0) & "] = '" & EXPRFILTRO(0) & "'"
        End If

        CAMPOFILTRO(1) = "ZONA"
        EXPRFILTRO(1) = FILTROZONA

        If EXPRFILTRO(0) = "" Then
            FILTRO(1) = " [" & CAMPOFILTRO(1) & "] like '*" & EXPRFILTRO(1) & "*'"
        Else
            FILTRO(1) = " AND  [" & CAMPOFILTRO(1) & "] like '*" & EXPRFILTRO(1) & "*'"
        End If

        '" AND  [" & PRINCampo(1) & "] like '*" & PRINExpre(1) & "*'"



        VISTAPRIM.RowFilter = FILTRO(0)
        'OTRAVISTA.RowFilter = FILTRO(0) & FILTRO(1)
        'MsgBox(GRUPOFILTRO)
        CREAR_ORDBindingSource.DataSource = VISTAPRIM
        'ORDENESBindingSource.DataSource = OTRAVISTA
    End Sub
End Class