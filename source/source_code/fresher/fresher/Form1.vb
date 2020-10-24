Public Class frm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New controlItems()
        f.Left = 0
        gr.Controls.Add(f)

        Dim g As New controlItems()
        g.Left = 200
        gr.Controls.Add(g)

    End Sub
End Class
