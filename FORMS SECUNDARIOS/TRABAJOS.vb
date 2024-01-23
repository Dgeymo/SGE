Public Class TRABAJOS
    Dim NewANTIGUEDADRow As BASEFUENTESDataSet.ANTIGUEDADBATRow
    Dim NewGRAFANTIGUEDADRow As BASEFUENTESDataSet.GRAFANTIGUEDADRow
    Dim NewGRAFTIPOFUENTERow As BASEFUENTESDataSet.GRAFTIPOFUENTERow
    Dim NewAUTONOMIARow As BASEFUENTESDataSet.GRAFAUTONOMIARow


    Dim HISTORICORow As DataRow
    Dim INSTALACIONRow As DataRow

    Dim CAMPO(10) As String
    Dim DATO(10) As String
    Dim FILTRO(10) As String

    Dim ANTBAT1 As Integer
    Dim ANTBAT2 As Integer
    Dim ANTBAT3 As Integer
    Dim ANTBAT4 As Integer

    Dim SELANT(10) As Integer
    Dim SELAUT(10) As Integer
    Dim PRUEBA As String

    Dim CANTIDADFUE As Integer



    Private Sub INSTALACIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles INSTALACIONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.INSTALACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASEFUENTESDataSet)

    End Sub

    Private Sub BUSCA_FUENTE()

        Dim VISTAFUENTE As DataView = BASEFUENTESDataSet.ANTIGUEDADBAT.AsDataView

        CAMPO(0) = ("CODIGO")
        DATO(0) = BUSC_CODIGO.Text
        FILTRO(0) = "[" & CAMPO(0) & "] like '*" & DATO(0) & "*'"

        CAMPO(1) = ("NODO")
        DATO(1) = BUSC_NODO.Text

        If BUSC_NODO.Text = "" Then
            FILTRO(1) = ""
        Else
            FILTRO(1) = " AND  [" & CAMPO(1) & "] = '" & DATO(1) & "'"
        End If

        CAMPO(2) = ("ZONA")
        DATO(2) = BUSC_ZONA.Text
        FILTRO(2) = " AND  [" & CAMPO(2) & "] like '*" & DATO(2) & "*'"

        CAMPO(3) = ("CALLE")
        DATO(3) = BUSC_CALLE.Text
        FILTRO(3) = " AND  [" & CAMPO(3) & "] like '*" & DATO(3) & "*'"

        CAMPO(4) = ("ANTBAT1")
        DATO(4) = BUSC_ANT1.Text
        If BUSC_ANT1.Text = "" Then
            FILTRO(4) = ""
        Else
            FILTRO(4) = " AND  [" & CAMPO(4) & "] > '" & CInt(DATO(4)) & "'"
        End If
        '    'CAMPO(5) = ("MODFUENTE")
        '    'DATO(5) = BUSC_FUENTE.Text
        '    'FILTRO(5) = " AND  [" & CAMPO(5) & "] like '*" & DATO(5) & "*'"

        '    'CAMPO(6) = ("IPMODEM")
        '    'DATO(6) = BUSC_IP.Text
        '    'FILTRO(6) = " AND  [" & CAMPO(6) & "] like '*" & DATO(6) & "*'"

        '    'CAMPO(7) = ("VPN1")
        '    'DATO(7) = BUSC_VPN1.Text
        '    'FILTRO(7) = " AND  [" & CAMPO(7) & "] like '*" & DATO(7) & "*'"

        '    'CAMPO(8) = ("VPN2")
        '    'DATO(8) = BUSC_VPN2.Text
        '    'FILTRO(8) = " AND  [" & CAMPO(8) & "] like '*" & DATO(8) & "*'"

        VISTAFUENTE.RowFilter = FILTRO(0) & FILTRO(1) & FILTRO(2) & FILTRO(3) & FILTRO(4) '& FILTRO(5) & FILTRO(6) & FILTRO(7) & FILTRO(8)

        ANTIGUEDADBATBindingSource.DataSource = VISTAFUENTE
        CANTIDADFUE = ANTIGUEDADBATDataGridView.Rows.Count
        CANT_FUE.Text = CANTIDADFUE

        PINTA_ANTIGUEDAD()



    End Sub

    Private Sub TRABAJOS_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'BASEFUENTESDataSet.GRAFAUTONOMIA' Puede moverla o quitarla según sea necesario.
        Me.GRAFAUTONOMIATableAdapter.Fill(Me.BASEFUENTESDataSet.GRAFAUTONOMIA)
        'TODO: esta línea de código carga datos en la tabla 'BASEFUENTESDataSet.GRAFTIPOFUENTE' Puede moverla o quitarla según sea necesario.
        Me.GRAFTIPOFUENTETableAdapter.Fill(Me.BASEFUENTESDataSet.GRAFTIPOFUENTE)
        'TODO: esta línea de código carga datos en la tabla 'BASEFUENTESDataSet.GRAFANTIGUEDAD' Puede moverla o quitarla según sea necesario.
        Me.GRAFANTIGUEDADTableAdapter.Fill(Me.BASEFUENTESDataSet.GRAFANTIGUEDAD)

        Me.HISTORICOTableAdapter.Fill(Me.BASEFUENTESDataSet.HISTORICO)
        'TODO: esta línea de código carga datos en la tabla 'BASEFUENTESDataSet.INSTALACION' Puede moverla o quitarla según sea necesario.
        Me.INSTALACIONTableAdapter.FillByORDEN(Me.BASEFUENTESDataSet.INSTALACION)

        SEL_ANT4.Checked = True
        SELANT(4) = 4

    End Sub

    Private Sub CALCULA_GRAFANTIGUEDAD()
        Dim NUEVONODO As String
        Dim I As Integer
        NUEVONODO = "SI"

        SEL_TIPOFUENTE()

        ProgressBar2.Maximum = BASEFUENTESDataSet.INSTALACION.Rows.Count
        CANT_ANT.Text = BASEFUENTESDataSet.INSTALACION.Rows.Count

        For I = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 2
            ProgressBar2.Value = I

            INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)

            HISTORICOTableAdapter.FillByCODIGO(BASEFUENTESDataSet.HISTORICO, INSTALACIONRow("CODIGO"))

            If BASEFUENTESDataSet.HISTORICO.Rows.Count > 0 Then
                HISTORICOBindingSource.MoveLast()
                HISTORICORow = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position)
            End If

            If BASEFUENTESDataSet.HISTORICO.Rows.Count > 0 Then
                If I = 0 Then
                    'ESCRIBE LA PRIMERA FILA
                    NewGRAFANTIGUEDADRow = BASEFUENTESDataSet.GRAFANTIGUEDAD.NewGRAFANTIGUEDADRow
                    NewGRAFANTIGUEDADRow("NODO") = INSTALACIONRow("NODO")

                    If IsDBNull(HISTORICORow("BAT1FECHAFAB")) = False Then
                        NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now)
                    Else
                        NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = 0
                    End If
                Else

                    'DETERMINA SI LA FILA SIGUIENTE ES UN NUEVO NODO
                    If I > 0 Then
                        If INSTALACIONRow("NODO") = BASEFUENTESDataSet.INSTALACION.Rows(I + 1).Item("NODO") Then 'LA SIGUIENTE FILA ES DEL MISMO NODO
                            NUEVONODO = "NO"
                        Else 'LA SIGUIENTE FILA ES UN NODO NUEVO
                            NUEVONODO = "SI"
                        End If
                    End If

                    If NUEVONODO = "SI" Then
                        NewGRAFANTIGUEDADRow("NODO") = INSTALACIONRow("NODO")
                        If IsDBNull(HISTORICORow("BAT1FECHAFAB")) = False Then NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now) Else NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = 0

                        BASEFUENTESDataSet.GRAFANTIGUEDAD.AddGRAFANTIGUEDADRow(NewGRAFANTIGUEDADRow)
                        NewGRAFANTIGUEDADRow = BASEFUENTESDataSet.GRAFANTIGUEDAD.NewGRAFANTIGUEDADRow
                    Else
                        If IsDBNull(HISTORICORow("BAT1FECHAFAB")) = False Then
                            NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now)
                        Else
                            NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = 0
                        End If
                    End If
                End If
            End If

        Next

        INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)
        NewGRAFANTIGUEDADRow("NODO") = INSTALACIONRow("NODO")

        If IsDBNull(HISTORICORow("BAT1FECHAFAB")) = False Then
            NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now)
        Else
            NewGRAFANTIGUEDADRow(INSTALACIONRow("ZONA")) = 0
        End If

        ProgressBar2.Value = 0

        BASEFUENTESDataSet.GRAFANTIGUEDAD.AddGRAFANTIGUEDADRow(NewGRAFANTIGUEDADRow)
        PINTA_GRAFANTIGUEDAD()
    End Sub

    Private Sub PINTA_GRAFANTIGUEDAD()
        Dim ANT As Integer
        For I = 0 To BASEFUENTESDataSet.GRAFANTIGUEDAD.Rows.Count - 1
            For X = 1 To 30
                If IsDBNull(GRAFANTIGUEDADDataGridView.Item(X, I).Value) = False Then
                    ANT = GRAFANTIGUEDADDataGridView.Item(X, I).Value
                    If ANT > 0 And ANT < 365 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.Green
                    If ANT >= 365 And ANT < 730 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
                    If ANT >= 730 And ANT < 1095 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.Yellow
                    If ANT >= 1095 And ANT < 1460 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.Orange
                    If ANT >= 1460 And ANT < 1795 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.Red
                    If ANT >= 1795 Then GRAFANTIGUEDADDataGridView.Item(X, I).Style.BackColor = Color.Violet
                End If
            Next X
        Next I
    End Sub

    Private Sub CALCULA_GRAFAUTONOMIA()

        Dim NUEVONODO As String
        Dim I As Integer
        NUEVONODO = "SI"

        SEL_TIPOFAUTONOMIA()

        CANT_AUT.Text = BASEFUENTESDataSet.INSTALACION.Rows.Count
        For I = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 2

            INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)

            If I = 0 Then
                'ESCRIBE LA PRIMERA FILA
                NewAUTONOMIARow = BASEFUENTESDataSet.GRAFAUTONOMIA.NewGRAFAUTONOMIARow
                NewAUTONOMIARow("NODO") = INSTALACIONRow("NODO")
                NewAUTONOMIARow(INSTALACIONRow("ZONA")) = CInt(INSTALACIONRow("AUTONOMIA"))
            Else
                'DETERMINA SI LA FILA SIGUIENTE ES UN NUEVO NODO
                If I > 0 Then
                    If INSTALACIONRow("NODO") = BASEFUENTESDataSet.INSTALACION.Rows(I + 1).Item("NODO") Then 'LA SIGUIENTE FILA ES DEL MISMO NODO
                        NUEVONODO = "NO"
                    Else 'LA SIGUIENTE FILA ES UN NODO NUEVO
                        NUEVONODO = "SI"
                    End If
                End If
                If NUEVONODO = "SI" Then
                    NewAUTONOMIARow("NODO") = INSTALACIONRow("NODO")
                    NewAUTONOMIARow(INSTALACIONRow("ZONA")) = CInt(INSTALACIONRow("AUTONOMIA"))

                    BASEFUENTESDataSet.GRAFAUTONOMIA.AddGRAFAUTONOMIARow(NewAUTONOMIARow)
                    NewAUTONOMIARow = BASEFUENTESDataSet.GRAFAUTONOMIA.NewGRAFAUTONOMIARow
                Else
                    NewAUTONOMIARow(INSTALACIONRow("ZONA")) = CInt(INSTALACIONRow("AUTONOMIA"))
                End If
            End If
        Next
        INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)
        NewAUTONOMIARow("NODO") = INSTALACIONRow("NODO")
        NewAUTONOMIARow(INSTALACIONRow("ZONA")) = CInt(INSTALACIONRow("AUTONOMIA"))
        BASEFUENTESDataSet.GRAFAUTONOMIA.AddGRAFAUTONOMIARow(NewAUTONOMIARow)
        PINTA_GRAFAUTONOMIA()


    End Sub

    Private Sub PINTA_GRAFAUTONOMIA()
        Dim ANT As Integer
        For I = 0 To DataGridView1.Rows.Count - 1
            For X = 1 To 29
                If IsDBNull(DataGridView1.Item(X, I).Value) = False Then
                    ANT = DataGridView1.Item(X, I).Value
                    If ANT > 0 And ANT < 2 Then DataGridView1.Item(X, I).Style.BackColor = Color.Orange
                    If ANT >= 2 And ANT < 4 Then DataGridView1.Item(X, I).Style.BackColor = Color.Yellow
                    If ANT >= 4 And ANT < 6 Then DataGridView1.Item(X, I).Style.BackColor = Color.LightGreen
                    If ANT >= 6 And ANT < 8 Then DataGridView1.Item(X, I).Style.BackColor = Color.LightBlue
                    If ANT >= 8 And ANT < 10 Then DataGridView1.Item(X, I).Style.BackColor = Color.Blue
                    If ANT >= 10 Then DataGridView1.Item(X, I).Style.BackColor = Color.Violet
                End If
            Next X
        Next I

    End Sub

    Private Sub CALCULA_GRAFTIPOFUENTE()
        Dim NUEVONODO As String
        NUEVONODO = "SI"
        Me.INSTALACIONTableAdapter.FillByORDEN(Me.BASEFUENTESDataSet.INSTALACION)

        For I = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 2

            INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)

            If I = 0 Then
                'ESCRIBE LA PRIMERA FILA
                NewGRAFTIPOFUENTERow = BASEFUENTESDataSet.GRAFTIPOFUENTE.NewGRAFTIPOFUENTERow
                NewGRAFTIPOFUENTERow("NODO") = INSTALACIONRow("NODO")
                NewGRAFTIPOFUENTERow(INSTALACIONRow("ZONA")) = INSTALACIONRow("MODFUENTE")
            Else
                'DETERMINA SI LA FILA SIGUIENTE ES UN NUEVO NODO
                If I > 0 Then
                    If INSTALACIONRow("NODO") = BASEFUENTESDataSet.INSTALACION.Rows(I + 1).Item("NODO") Then 'LA SIGUIENTE FILA ES DEL MISMO NODO
                        NUEVONODO = "NO"
                    Else 'LA SIGUIENTE FILA ES UN NODO NUEVO
                        NUEVONODO = "SI"
                    End If
                End If
                If NUEVONODO = "SI" Then
                    NewGRAFTIPOFUENTERow("NODO") = INSTALACIONRow("NODO")
                    NewGRAFTIPOFUENTERow(INSTALACIONRow("ZONA")) = INSTALACIONRow("MODFUENTE")

                    BASEFUENTESDataSet.GRAFTIPOFUENTE.AddGRAFTIPOFUENTERow(NewGRAFTIPOFUENTERow)
                    NewGRAFTIPOFUENTERow = BASEFUENTESDataSet.GRAFTIPOFUENTE.NewGRAFTIPOFUENTERow
                Else
                    NewGRAFTIPOFUENTERow(INSTALACIONRow("ZONA")) = INSTALACIONRow("MODFUENTE")
                End If
            End If
        Next
        NewGRAFTIPOFUENTERow("NODO") = INSTALACIONRow("NODO")
        NewGRAFTIPOFUENTERow(INSTALACIONRow("ZONA")) = INSTALACIONRow("MODFUENTE")
        BASEFUENTESDataSet.GRAFTIPOFUENTE.AddGRAFTIPOFUENTERow(NewGRAFTIPOFUENTERow)
        PINTA_GRAFTIPOFUENTE()

    End Sub
    Private Sub PINTA_GRAFTIPOFUENTE()
        Dim ANT As String
        For I = 0 To BASEFUENTESDataSet.GRAFTIPOFUENTE.Rows.Count - 1
            For X = 1 To 30
                If IsDBNull(GRAFTIPOFUENTEDataGridView.Item(X, I).Value) = False Then
                    ANT = GRAFTIPOFUENTEDataGridView.Item(X, I).Value
                    If ANT = "COM" Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.LightBlue
                    If ANT = "EM" Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Chocolate
                    If ANT = "AM660" Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.LightCoral
                    If ANT = "VMX" Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.LightSalmon
                    If ANT = "XM2" Then GRAFTIPOFUENTEDataGridView.Item(X, I).Style.BackColor = Color.Coral
                End If
            Next X
        Next I
    End Sub
    Private Sub CALCULA_ANTIGUEDAD()


        ProgressBar1.Maximum = BASEFUENTESDataSet.INSTALACION.Rows.Count
        For I = 0 To BASEFUENTESDataSet.INSTALACION.Rows.Count - 1
            ProgressBar1.Value = I
            INSTALACIONRow = BASEFUENTESDataSet.INSTALACION.Rows(I)

            HISTORICOTableAdapter.FillByCODIGO(BASEFUENTESDataSet.HISTORICO, INSTALACIONRow("CODIGO"))

            If BASEFUENTESDataSet.HISTORICO.Rows.Count > 0 Then
                HISTORICOBindingSource.MoveLast()
                HISTORICORow = BASEFUENTESDataSet.HISTORICO.Rows(HISTORICOBindingSource.Position)
            End If
            NewANTIGUEDADRow = BASEFUENTESDataSet.ANTIGUEDADBAT.NewANTIGUEDADBATRow

            If BASEFUENTESDataSet.HISTORICO.Rows.Count > 0 Then
                'If DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now) > 700 Then
                NewANTIGUEDADRow("CODIGO") = HISTORICORow("CODINSTLACION")
                NewANTIGUEDADRow("INSTALACION") = INSTALACIONRow("CODORD")
                NewANTIGUEDADRow("NODO") = INSTALACIONRow("NODO")
                NewANTIGUEDADRow("ZONA") = INSTALACIONRow("ZONA")
                NewANTIGUEDADRow("CALLE") = INSTALACIONRow("CALLE")
                NewANTIGUEDADRow("NRO") = INSTALACIONRow("NRO")
                NewANTIGUEDADRow("MODELO") = INSTALACIONRow("MODFUENTE")
                NewANTIGUEDADRow("MARCA") = ""
                NewANTIGUEDADRow("BAT1") = HISTORICORow("BAT1MARCA") & " " & HISTORICORow("BAT1MOD")
                NewANTIGUEDADRow("BAT2") = HISTORICORow("BAT2MARCA") & " " & HISTORICORow("BAT2MOD")
                NewANTIGUEDADRow("BAT3") = HISTORICORow("BAT3MARCA") & " " & HISTORICORow("BAT3MOD")
                NewANTIGUEDADRow("BAT4") = HISTORICORow("BAT4MARCA") & " " & HISTORICORow("BAT4MOD")

                If IsDBNull(HISTORICORow("BAT1FECHAFAB")) = False Then
                    ANTBAT1 = DateDiff(DateInterval.Day, HISTORICORow("BAT1FECHAFAB"), Now)
                    NewANTIGUEDADRow("ANTBAT1") = ANTBAT1
                Else
                    NewANTIGUEDADRow("ANTBAT1") = 0
                End If
                If IsDBNull(HISTORICORow("BAT2FECHAFAB")) = False Then NewANTIGUEDADRow("ANTBAT2") = DateDiff(DateInterval.Day, HISTORICORow("BAT2FECHAFAB"), Now) Else NewANTIGUEDADRow("ANTBAT2") = 0
                If IsDBNull(HISTORICORow("BAT3FECHAFAB")) = False Then NewANTIGUEDADRow("ANTBAT3") = DateDiff(DateInterval.Day, HISTORICORow("BAT3FECHAFAB"), Now) Else NewANTIGUEDADRow("ANTBAT3") = 0
                If IsDBNull(HISTORICORow("BAT4FECHAFAB")) = False Then NewANTIGUEDADRow("ANTBAT4") = DateDiff(DateInterval.Day, HISTORICORow("BAT4FECHAFAB"), Now) Else NewANTIGUEDADRow("ANTBAT4") = 0

                NewANTIGUEDADRow("PEORCOND") = DateDiff(DateInterval.Day, HISTORICORow("FECHAMOV"), Now)
                BASEFUENTESDataSet.ANTIGUEDADBAT.AddANTIGUEDADBATRow(NewANTIGUEDADRow)

            Else
                NewANTIGUEDADRow("CODIGO") = INSTALACIONRow("CODIGO")
                NewANTIGUEDADRow("INSTALACION") = INSTALACIONRow("CODORD")
                NewANTIGUEDADRow("NODO") = INSTALACIONRow("NODO")
                NewANTIGUEDADRow("ZONA") = INSTALACIONRow("ZONA")
                NewANTIGUEDADRow("CALLE") = INSTALACIONRow("CALLE")
                NewANTIGUEDADRow("NRO") = INSTALACIONRow("NRO")
                NewANTIGUEDADRow("MODELO") = INSTALACIONRow("MODFUENTE")
                NewANTIGUEDADRow("MARCA") = ""
                NewANTIGUEDADRow("BAT1") = "S/R"
                NewANTIGUEDADRow("BAT2") = "S/R"
                NewANTIGUEDADRow("BAT3") = "S/R"
                NewANTIGUEDADRow("BAT4") = "S/R"

                NewANTIGUEDADRow("ANTBAT1") = 0
                NewANTIGUEDADRow("ANTBAT2") = 0
                NewANTIGUEDADRow("ANTBAT3") = 0
                NewANTIGUEDADRow("ANTBAT4") = 0

                NewANTIGUEDADRow("PEORCOND") = 0

                BASEFUENTESDataSet.ANTIGUEDADBAT.AddANTIGUEDADBATRow(NewANTIGUEDADRow)
            End If
        Next I

        CANTIDADFUE = ANTIGUEDADBATDataGridView.Rows.Count
        CANT_FUE.Text = CANTIDADFUE

        PINTA_ANTIGUEDAD()
    End Sub

    Private Sub PINTA_ANTIGUEDAD()
        Dim ANT As Integer
        For I = 0 To ANTIGUEDADBATDataGridView.Rows.Count - 1
            For X = 11 To 15
                If IsDBNull(ANTIGUEDADBATDataGridView.Item(X, I).Value) = False Then
                    ANT = ANTIGUEDADBATDataGridView.Item(X, I).Value
                    If ANT > 0 And ANT < 365 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.Green
                    If ANT >= 365 And ANT < 730 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.LightGreen
                    If ANT >= 730 And ANT < 1095 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.Yellow
                    If ANT >= 1095 And ANT < 1460 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.Orange
                    If ANT >= 1460 And ANT < 1795 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.Red
                    If ANT >= 1795 And ANT < 1795 Then ANTIGUEDADBATDataGridView.Item(X, I).Style.BackColor = Color.Violet
                End If
            Next X
        Next I
    End Sub





    Private Sub BUSC_CODIGO_TextChanged(sender As Object, e As EventArgs) Handles BUSC_CODIGO.TextChanged
        BUSCA_FUENTE()
    End Sub

    Private Sub BUSC_NODO_TextChanged(sender As Object, e As EventArgs) Handles BUSC_NODO.TextChanged
        BUSCA_FUENTE()
    End Sub

    Private Sub BUSC_ZONA_TextChanged(sender As Object, e As EventArgs) Handles BUSC_ZONA.TextChanged
        BUSCA_FUENTE()
    End Sub

    Private Sub BUSC_CALLE_TextChanged(sender As Object, e As EventArgs) Handles BUSC_CALLE.TextChanged
        BUSCA_FUENTE()
    End Sub

    Private Sub BOT_CALCTIPOFUENTE_Click(sender As Object, e As EventArgs) Handles BOT_CALCTIPOFUENTE.Click
        CALCULA_GRAFTIPOFUENTE()
    End Sub

    Private Sub BOT_CALCANTIGUEDAD_Click(sender As Object, e As EventArgs) Handles BOT_CALCANTIGUEDAD.Click
        CALCULA_ANTIGUEDAD()
    End Sub



    Private Sub BUSC_ANT1_TextChanged(sender As Object, e As EventArgs) Handles BUSC_ANT1.TextChanged
        BUSCA_FUENTE()
    End Sub



    Private Sub BOT_CALGRAFANT_Click(sender As Object, e As EventArgs) Handles BOT_CALGRAFANT.Click
        BASEFUENTESDataSet.GRAFANTIGUEDAD.Clear()
        CALCULA_GRAFANTIGUEDAD()
    End Sub



    Private Sub BOT_CALCGRAFAUTONOMIA_Click(sender As Object, e As EventArgs) Handles BOT_CALCGRAFAUTONOMIA.Click
        BASEFUENTESDataSet.GRAFAUTONOMIA.Clear()
        CALCULA_GRAFAUTONOMIA()
    End Sub



    Private Sub SEL_TIPOFUENTE()

        For I = 1 To 5
            Select Case SELANT(I)
                Case 1
                    TITULO_TF.Text = "FUENTES DE RX"
                    Me.INSTALACIONTableAdapter.FillByFSR(BASEFUENTESDataSet.INSTALACION)
                Case 2
                    TITULO_TF.Text = "FUENTES DE TRONCALES"
                    Me.INSTALACIONTableAdapter.FillByFST(BASEFUENTESDataSet.INSTALACION)
                Case 3
                    TITULO_TF.Text = "FUENTES MIXTAS"
                    Me.INSTALACIONTableAdapter.FillByFSM(BASEFUENTESDataSet.INSTALACION)
                Case 4
                    TITULO_TF.Text = "FUENTES DE ZONA (DISTRIBUCION)"
                    Me.INSTALACIONTableAdapter.FillByFSD(BASEFUENTESDataSet.INSTALACION)
                Case 5
                    TITULO_TF.Text = "FUENTES STD BY (TODAS)"
                    Me.INSTALACIONTableAdapter.FillByNOCOM(BASEFUENTESDataSet.INSTALACION)
            End Select
        Next I
    End Sub



    Private Sub SEL_TIPOFAUTONOMIA()
        For I = 1 To 5
            Select Case SELAUT(I)
                Case 1
                    TITULO_AUT.Text = "FUENTES DE RX"
                    Me.INSTALACIONTableAdapter.FillByFSR(BASEFUENTESDataSet.INSTALACION)
                Case 2
                    TITULO_AUT.Text = "FUENTES DE TRONCALES"
                    Me.INSTALACIONTableAdapter.FillByFST(BASEFUENTESDataSet.INSTALACION)
                Case 3
                    TITULO_AUT.Text = "FUENTES MIXTAS"
                    Me.INSTALACIONTableAdapter.FillByFSM(BASEFUENTESDataSet.INSTALACION)
                Case 4
                    TITULO_AUT.Text = "FUENTES DE ZONA (DISTRIBUCION)"
                    Me.INSTALACIONTableAdapter.FillByFSD(BASEFUENTESDataSet.INSTALACION)
                Case 5
                    TITULO_AUT.Text = "FUENTES STD BY (TODAS)"
                    Me.INSTALACIONTableAdapter.FillByNOCOM(BASEFUENTESDataSet.INSTALACION)
            End Select
        Next I





    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class