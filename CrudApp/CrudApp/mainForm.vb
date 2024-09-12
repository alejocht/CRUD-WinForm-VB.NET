Public Class mainForm
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

        For Each form In Application.OpenForms
            If TypeOf form Is clienteForm Then
                Exit Sub
            End If

        Next

        Dim form1 As New clienteForm
        form1.MdiParent = Me
        form1.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click

        For Each form In Application.OpenForms
            If TypeOf form Is productoForm Then
                Exit Sub
            End If
        Next

        Dim form1 As New productoForm
        form1.MdiParent = Me
        form1.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        For Each form In Application.OpenForms
            If TypeOf form Is ventaForm Then
                Exit Sub
            End If
        Next

        Dim form1 As New ventaForm
        form1.MdiParent = Me
        form1.Show()
    End Sub
End Class
