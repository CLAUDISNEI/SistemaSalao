Public Class FrmTelaPrincipal
    Private Sub frmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.BackColor = Color.FromArgb(226, 251, 245)


    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim form = New FrmCadastroClientes
        form.ShowDialog()
    End Sub

    Private Sub CadastroProdudosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroProdudosToolStripMenuItem.Click
        Dim form = New frmProdutos
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New FrmCadastroClientes
        form.ShowDialog()
    End Sub
End Class