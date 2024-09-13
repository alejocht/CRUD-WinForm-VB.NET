Public Class mainForm
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

        For Each form In Application.OpenForms
            If TypeOf form Is principalClienteForm Then
                MessageBox.Show("Ya existe esta ventana abierta")
                Exit Sub
            End If

        Next

        Dim form1 As New principalClienteForm
        form1.MdiParent = Me
        form1.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click

        For Each form In Application.OpenForms
            If TypeOf form Is principalProductoForm Then
                MessageBox.Show("Ya existe esta ventana abierta")
                Exit Sub
            End If
        Next

        Dim form1 As New principalProductoForm
        form1.MdiParent = Me
        form1.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        For Each form In Application.OpenForms
            If TypeOf form Is principalVentaForm Then
                MessageBox.Show("Ya existe esta ventana abierta")
                Exit Sub
            End If
        Next

        Dim form1 As New principalVentaForm
        form1.MdiParent = Me
        form1.Show()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
