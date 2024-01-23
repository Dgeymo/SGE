Public Class OC_LISTADO
    Dim DRAGINDEX
    Dim FROMINDEX
    Dim DRAGRECT
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView2.AllowDrop = True
        TRABAJOSTableAdapter.FillByOBRACIVIL_ACTIVOS(ORDENESDataSet.TRABAJOS)
        DataGridView1.DataSource = ORDENESDataSet.TRABAJOS
    End Sub
    Private Sub DataGridView1_DragDrop(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
                                  Handles DataGridView1.DragDrop
        Dim p As Point = DataGridView1.PointToClient(New Point(e.X, e.Y))
        dragIndex = DataGridView1.HitTest(p.X, p.Y).RowIndex
        DataGridView1.AllowUserToAddRows = True
        If (e.Effect = DragDropEffects.Move) Then
            Dim dragRow As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
            DataGridView1.Rows.RemoveAt(fromIndex)
            DataGridView1.Rows.Insert(dragIndex, dragRow)
        End If
    End Sub

    '
    Private Sub DataGridView1_DragOver(ByVal sender As Object,
                                       ByVal e As DragEventArgs) _
                                       Handles DataGridView1.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub DataGridView1_MouseDown(ByVal sender As Object,
                                    ByVal e As MouseEventArgs) _
                                    Handles DataGridView1.MouseDown
        fromIndex = DataGridView1.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2),
                                               e.Y - (dragSize.Height / 2)),
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub DataGridView1_MouseMove(ByVal sender As Object,
                                        ByVal e As MouseEventArgs) _
                                        Handles DataGridView1.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                DataGridView1.DoDragDrop(DataGridView1.Rows(fromIndex),
                                         DragDropEffects.Move)
            End If
        End If
    End Sub
    'Private Sub DataGridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown

    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        If DataGridView1.CurrentCell IsNot Nothing AndAlso DataGridView1.CurrentCell.Value IsNot Nothing Then
    '            DoDragDrop(DataGridView1.CurrentCell.Value, DragDropEffects.Copy)
    '        End If
    '    End If
    'End Sub

    'Private Sub DataGridView2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DataGridView2.DragDrop
    '    If e.Data IsNot Nothing Then
    '        Dim text As String = e.Data.GetData(DataFormats.Text)
    '        Dim clientPoint As Point = DataGridView2.PointToClient(New Point(e.X, e.Y))

    '        Dim info As DataGridView.HitTestInfo = DataGridView2.HitTest(clientPoint.X, clientPoint.Y)

    '        If info.Type = DataGridViewHitTestType.Cell Then
    '            DataGridView2.Rows(info.RowIndex).Cells(info.ColumnIndex).Value = text
    '        End If
    '    End If
    'End Sub

    'Private Sub DataGridView2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DataGridView2.DragEnter
    '    If (e.Data.GetDataPresent(DataFormats.Text)) Then
    '        e.Effect = DragDropEffects.Copy
    '    Else
    '        e.Effect = DragDropEffects.All
    '    End If
    'End Sub
    'Private Sub OC_LISTADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    'End Sub
    'Private MouseIsDown As Boolean = False 'variable declaration

    'Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown

    '    'Set a flag to show that the mouse is down.

    '    MouseIsDown = True

    'End Sub

    'Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove

    '    If MouseIsDown Then

    '        ' Initiate dragging.

    '        TextBox1.DoDragDrop(TextBox1.Text, DragDropEffects.Move)

    '    End If

    '    MouseIsDown = False

    'End Sub

    Private Sub TextBox2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox2.DragEnter
        'Check the format of the data being dropped.
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            ' Display the copy cursor.
            e.Effect = DragDropEffects.Copy
        Else
            ' Display the no-drop cursor.
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub TextBox2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox2.DragDrop
        'Paste the text.
        TextBox2.Text = e.Data.GetData(DataFormats.Text)
    End Sub
    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click

    End Sub
End Class