Public Class FrmTelaPrincipal
    Private Sub FrmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.BackColor = Color.FromArgb(209, 251, 241)
        btnAddCliente.BackColor = Color.FromArgb(230, 252, 247)
        btnAgendamento.BackColor = Color.FromArgb(230, 252, 247)
        btnVenda.BackColor = Color.FromArgb(230, 252, 247)
        btnHorarios.BackColor = Color.FromArgb(230, 252, 247)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeProdutosToolStripMenuItem.Click
        Dim form = New FrmCadProdutos
        form.ShowDialog()
    End Sub
End Class