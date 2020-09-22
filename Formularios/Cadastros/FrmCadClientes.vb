Public Class FrmCadClientes
    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub

    Private Sub RbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Visible = False
        txtBuscarNome.Visible = True
        txtBuscarNome.Focus()
    End Sub

    Private Sub RbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscarCPF.Visible = True
        txtBuscarNome.Visible = False
        txtBuscarCPF.Focus()
    End Sub


    Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtEndereco.Enabled = False
        txtTelefone.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try
                MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                DesabilitarCampos()
                btnSalvar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtNome.Focus()
        End If





    End Sub


    Sub Limpar()
        txtNome.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try
                MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editado")
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao editar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtNome.Focus()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub
End Class