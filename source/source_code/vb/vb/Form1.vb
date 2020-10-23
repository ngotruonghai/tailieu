Imports System.Data.DataTable


Public Class Form1
    Private Sub DataGridView2_DragDrop(sender As Object, e As DragEventArgs) Handles DataGridView2.DragDrop
        Dim row As Integer = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")))
        Dim points As Point = DataGridView2.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = DataGridView2.HitTest(points.X, points.Y)
        If hit.Type = DataGridViewHitTestType.Cell Then
            Dim desrow As Integer = hit.RowIndex
            Dim descontrol As Integer = hit.ColumnIndex
            DataGridView2.Rows(desrow).Cells(descontrol).Value = DataGridView1.Rows(row).Cells(1).Value
        End If
    End Sub

    Private Sub DataGridView1_DragDrop(sender As Object, e As DragEventArgs) Handles DataGridView1.DragDrop

    End Sub

    Private Sub DataGridView1_DragOver(sender As Object, e As DragEventArgs) Handles DataGridView1.DragOver

    End Sub

    Private Sub DataGridView2_DragOver(sender As Object, e As DragEventArgs) Handles DataGridView2.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToOrderColumns = True

        Dim table As New DataTable("table")
        Dim tables As New DataTable("table")
        table.Columns.Add("id")
        table.Columns.Add("name")
        DataGridView1.DataSource = table
        Dim x As Int16 = 1
        For x = 1 To 10
            table.Rows.Add(x.ToString(), "số: " + x.ToString())
            DataGridView1.DataSource = table
        Next

        tables.Columns.Add("id")
        tables.Columns.Add("name")
        DataGridView1.DataSource = table
        Dim xs As Int16 = 1
        For xs = 1 To 10
            tables.Rows.Add(xs.ToString())
            DataGridView2.DataSource = tables
        Next

    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        If e.X > DataGridView1.RowHeadersWidth And e.Y > DataGridView1.ColumnHeadersHeight Then


            Dim SourceRow As Integer
            SourceRow = DataGridView1.HitTest(e.X, e.Y).RowIndex
            DataGridView1.DoDragDrop(SourceRow, DragDropEffects.All)

        Else

            'MsgBox("Click detected was on a header")

        End If

    End Sub

    Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove

    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        'If e.RowIndex > -1 And e.ColumnIndex > -1 Then

        '    MsgBox("you clicked in Column: " & e.ColumnIndex + 1 & "  Row: " & e.RowIndex + 1)

        'Else

        '    MsgBox("you clicked on a header")

        'End If

    End Sub
End Class
