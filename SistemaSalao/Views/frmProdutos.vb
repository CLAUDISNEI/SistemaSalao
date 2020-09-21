Public Class frmProdutos


    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Desbilitar_campos(Me)
        img.Image = My.Resources.sem_foto
        btnNovo.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnSalvar.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Habilitar_campos(Me)
        txtNome.Focus()
        Habilitar_campos(Me)
        btnCancelar.Enabled = True
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Limpar_campos(Me)
        Desbilitar_campos(Me)
        btnNovo.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnSalvar.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        'If campos_obrigatorios(Me).Count > 0 Then
        '    Dim ob = New Object
        '    Dim lista = New List(Of Object)
        '    lista = campos_obrigatorios(Me)

        '    For Each ob In lista
        '        ob.BackColor = Color.Red
        '    Next
        '    MsgBox("Verifique os campos Obrigatorios!", MsgBoxStyle.Information, "Atenção")

        '    Exit Sub
        'End If

        Try
            MsgBox("Salvo com Sucesso!", MsgBoxStyle.Information, "Registro salvo")
            Desbilitar_campos(Me)
            Limpar_campos(Me)
            btnSalvar.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            btnNovo.Enabled = True
        Catch ex As Exception
            MsgBox("Erro : " & ex.Message, MsgBoxStyle.Critical, "Erro ao Salvar")
        End Try
    End Sub

    Private Sub dtGridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridClientes.CellContentClick
        btnExcluir.Enabled = True
        btnEditar.Enabled = False
    End Sub

    Private Sub btnAdicionarImagem_Click(sender As Object, e As EventArgs) Handles btnAdicionarImagem.Click
        Dim dialogo As FileDialog = New OpenFileDialog
        dialogo.Filter = "Arquvio de imagem(*.jpg; *.bmp; *.png)|*.jpg; *.bmp; *.png"

        If dialogo.ShowDialog = DialogResult.OK Then
            MsgBox("Escolhi uma imagem")
        Else
            MsgBox("Nao escolhi uma imagem")
        End If
    End Sub
End Class