Imports MySql.Data.MySqlClient

Public Class FrmCadastroClientes
    Dim valorAnteriorCPF As String

    Private Sub FrmCadastroClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDataGrid()
        FormatarDatGrid()
        txtBuscarCpf.Visible = False

        txtBuscarNome.Location = New Point(433, 15)

        Desbilitar_campos(Me)
        btnNovo.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnSalvar.Enabled = False
    End Sub

    Private Sub rbCpf_CheckedChanged(sender As Object, e As EventArgs) Handles rbCpf.CheckedChanged

        txtBuscarCpf.Visible = True
        txtBuscarNome.Visible = False
        txtBuscarCpf.Location = New Point(433, 15)
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarNome.Visible = True
        txtBuscarCpf.Visible = False
        rbCpf.Checked = False
        txtBuscarNome.Location = New Point(433, 15)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Habilitar_campos(Me)

        txtNome.Focus()
        Habilitar_campos(Me)
        dtGridClientes.Enabled = False
        btnCancelar.Enabled = True
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar_campos(Me)
        Desbilitar_campos(Me)
        dtGridClientes.Enabled = True
        btnNovo.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnSalvar.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        'VERIFICA SE SERÁ UMA EDIÇÃO OU CRIAÇÃO DE CLIENTE
        If lblId.Text = "" Then
            'VERIFICA SE HÁ ALGUM CAMPO OBRIGATÓRIO VAZIO
            If campos_obrigatorios(Me) Then
                Exit Sub
            End If

            'REALIZA UMA BUSCA E VERIFICA SE O CPF JÁ EXISTE
            If BuscarPorCPF(txtCPF.Text) Then
                MsgBox("Este CPF já está cadastrado!", MsgBoxStyle.Critical, "Busca CPF")
                txtCPF.Focus()
                txtCPF.BackColor = Color.Red
                Exit Sub
            End If

            'SALVA UM NOVO CLINTE
            If InserirNovoCliente() Then
                MsgBox("Salvo com Sucesso!", MsgBoxStyle.Information, "Registro salvo")
                CarregarDataGrid()
                Desbilitar_campos(Me)
                Limpar_campos(Me)
                dtGridClientes.Enabled = True
                btnSalvar.Enabled = False
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                btnNovo.Enabled = True
                btnCancelar.Enabled = False
            End If
        Else

            If valorAnteriorCPF <> txtCPF.Text Then
                If BuscarPorCPF(txtCPF.Text) Then
                    MsgBox("Este CPF já está cadastrado!", MsgBoxStyle.Critical, "Busca CPF")
                    txtCPF.Focus()
                    txtCPF.BackColor = Color.Red
                    Exit Sub
                End If
            End If

            If AlterarCliente() Then
                MsgBox("Cliente alterado com Sucesso!", MsgBoxStyle.Information, "Alterar Cliente")
                CarregarDataGrid()
                Desbilitar_campos(Me)
                Limpar_campos(Me)
                dtGridClientes.Enabled = True
                btnSalvar.Enabled = False
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                btnNovo.Enabled = True
                btnCancelar.Enabled = False
            End If

        End If
    End Sub

    Private Sub dtGridClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridClientes.CellClick
        btnExcluir.Enabled = True
        btnEditar.Enabled = True
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnSalvar.Enabled = False

        'carrega valores do datagrid nos campos do formulario
        lblId.Text = dtGridClientes.CurrentRow.Cells(0).Value
        txtNome.Text = dtGridClientes.CurrentRow.Cells(1).Value
        txtCPF.Text = dtGridClientes.CurrentRow.Cells(2).Value
        txtTelefone.Text = dtGridClientes.CurrentRow.Cells(3).Value
        txtCelular.Text = dtGridClientes.CurrentRow.Cells(4).Value
        txtEmail.Text = dtGridClientes.CurrentRow.Cells(5).Value
        txtCEP.Text = dtGridClientes.CurrentRow.Cells(6).Value
        txtEndereço.Text = dtGridClientes.CurrentRow.Cells(7).Value
        txtBairro.Text = dtGridClientes.CurrentRow.Cells(8).Value
        txtCidade.Text = dtGridClientes.CurrentRow.Cells(9).Value

        'variavel utilizada para verificar se o cpf que será informado não existe no bd
        valorAnteriorCPF = txtCPF.Text

        Desbilitar_campos(Me)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Habilitar_campos(Me)
        dtGridClientes.Enabled = False
        btnExcluir.Enabled = True
        btnEditar.Enabled = False
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
    End Sub


    Private Sub txtDatanascimento_TextChanged(sender As Object, e As EventArgs) Handles txtDatanascimento.TextChanged
        MascaraDatas(sender)
    End Sub

    Private Sub txtDatanascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatanascimento.KeyPress
        ApenasNumeros(e, sender)
    End Sub


    Private Sub txtCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCEP.KeyPress
        ApenasNumeros(e, sender)
    End Sub

    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs)
        ApenasNumeros(e, sender)
        If txtCPF.Text <> "" Then
            txtCPF.BackColor = Color.White
        End If
    End Sub


    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs)
        ApenasNumeros(e, sender)
        If txtCelular.Text <> "" Then
            txtCelular.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        ApenasLetras(e, sender)
        If txtNome.Text <> "" Then
            txtNome.BackColor = Color.White
        End If
    End Sub

    Private Sub txtEndereço_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEndereço.KeyPress
        If txtEndereço.Text <> "" Then
            txtEndereço.BackColor = Color.White
        End If
    End Sub

    Private Sub txtBairro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBairro.KeyPress
        If txtBairro.Text <> "" Then
            txtBairro.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCidade.KeyPress
        If txtCidade.Text <> "" Then
            txtCidade.BackColor = Color.White
        End If
    End Sub

    Function AlterarCliente() As Boolean

        'A FUNÇÃO RETORNA VERDADEIRO CASO O CLIENTE TENHA SIDO SALVO NO BANCO DE DADOS
        Dim resultado As Boolean
        resultado = False

        Try
            ' VARIAVEL DO TIPO COMMAND NECESSÁRIA PARA REALIZAR A INSERÇÃO NO BC
            Dim cmd As MySqlCommand
            Dim sql As String

            'NECESSÁRIO ABRIR A CONEXÃO DO BD PARA REALIZAR A TRANSAÇÃO
            AbrirConexao()

            'FOI RETIRADO TEMPORARIAMENTE A DATA DE NASCIMENTO DO CLIENTE
            sql = "UPDATE tb_clientes SET nome ='" & txtNome.Text & "', cpf ='" & txtCPF.Text & "', telefone ='" & txtTelefone.Text & "', celular ='" & txtCelular.Text & "', email ='" & txtEmail.Text & "', cep ='" & txtCEP.Text & "', endereco ='" & txtEndereço.Text & "', bairro ='" & txtBairro.Text & "', cidade ='" & txtCidade.Text & "' WHERE id ='" & lblId.Text & "'"

            'NECESSÁRIO INSTANCIAR A VARIAVEL COM UM NOVO MYSQLCOMMAND PASSANDO OS PARÂMETROS DA SQL E A CONEXÃO DO BANCO DE DADOS
            cmd = New MySqlCommand(sql, Conexao.conexao)
            cmd.ExecuteNonQuery()

            resultado = True

        Catch ex As Exception
            MsgBox("Erro ao tentar alterar Cliente !" & ex.Message, MsgBoxStyle.Critical, "Alterar Cliente")
        Finally
            FecharConcexao()
        End Try

        Return resultado

    End Function

    Function InserirNovoCliente() As Boolean

        'A FUNÇÃO RETORNA VERDADEIRO CASO O CLIENTE TENHA SIDO SALVO NO BANCO DE DADOS
        Dim resultado As Boolean
        resultado = False

        Try
            ' VARIAVEL DO TIPO COMMAND NECESSÁRIA PARA REALIZAR A INSERÇÃO NO BC
            Dim cmd As MySqlCommand
            Dim sql As String

            'NECESSÁRIO ABRIR A CONEXÃO DO BD PARA REALIZAR A TRANSAÇÃO
            AbrirConexao()
            'sql = "INSERT INTO tb_clientes (nome, cpf, telefone, dataNascimento, celular, email, cep, endereco, bairro, cidade) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "'
            '    ,'" & txtTelefone.Text & "','" & Now & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtCEP.Text & "',
            '    " & txtEndereço.Text & "','" & txtBairro.Text & "','" & txtCidade.Text & "')"

            'FOI RETIRADO TEMPORARIAMENTE A DATA DE NASCIMENTO DO CLIENTE
            sql = "INSERT INTO tb_clientes (nome, cpf, telefone,  celular, email, cep, endereco, bairro, cidade) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "'
                ,'" & txtTelefone.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtCEP.Text & "',
                '" & txtEndereço.Text & "','" & txtBairro.Text & "','" & txtCidade.Text & "')"

            'NECESSÁRIO INSTANCIAR A VARIAVEL COM UM NOVO MYSQLCOMMAND PASSANDO OS PARÂMETROS DA SQL E A CONEXÃO DO BANCO DE DADOS
            cmd = New MySqlCommand(sql, Conexao.conexao)
            cmd.ExecuteNonQuery()

            resultado = True

        Catch ex As Exception
            MsgBox("Erro ao tentar salvar Cliente !" & ex.Message, MsgBoxStyle.Critical, "Salvar Cliente")
        Finally
            FecharConcexao()
        End Try

        Return resultado

    End Function

    Public Sub FormatarDatGrid()
        'dtGridClientes.Columns(0).Visible = False
        dtGridClientes.Columns(0).HeaderText = "Id"
        dtGridClientes.Columns(1).HeaderText = "Nome"
        dtGridClientes.Columns(1).Width = 150
        dtGridClientes.Columns(2).HeaderText = "CPF"
        dtGridClientes.Columns(2).Width = 90
        dtGridClientes.Columns(3).HeaderText = "Telefone"
        dtGridClientes.Columns(3).Width = 90
        dtGridClientes.Columns(4).HeaderText = "Celular"
        dtGridClientes.Columns(4).Width = 90
        dtGridClientes.Columns(5).HeaderText = "Email"
        dtGridClientes.Columns(5).Width = 190
        dtGridClientes.Columns(6).HeaderText = "CEP"
        dtGridClientes.Columns(6).Width = 80
        dtGridClientes.Columns(7).HeaderText = "Endereço"
        dtGridClientes.Columns(7).Width = 250
        dtGridClientes.Columns(8).HeaderText = "Bairro"
        dtGridClientes.Columns(8).Width = 120
        dtGridClientes.Columns(9).HeaderText = "Cidade"
        dtGridClientes.Columns(9).Width = 120
    End Sub

    Public Function BuscarPorCPF(valor As String) As Boolean

        'CRIADO UMA VARIÁVEL DO TIPO MYSQLCOMMAND E OUTRA MYSQLDATAREADER QUE EXECUTARÁ A BUSCA
        Dim cmdCPF As MySqlCommand
        Dim readerCPF As MySqlDataReader

        Dim retorno As Boolean = False

        Try
            Dim sql As String
            AbrirConexao()
            sql = "SELECT * FROM tb_clientes WHERE cpf = '" & valor & "'"

            'INSTANCIA DA VARIAVEL COMMAND
            cmdCPF = New MySqlCommand(sql, Conexao.conexao)

            'A VARIAVEL DATAREADER RECEBE O CONTEÚDO DA EXECUÇÃO DO COMMAND
            readerCPF = cmdCPF.ExecuteReader
            If readerCPF.Read = True Then
                retorno = True
                readerCPF.Close()
                FecharConcexao()
            Else
                FecharConcexao()
                readerCPF.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar cpf!" & ex.Message)
        Finally
            FecharConcexao()
        End Try


        Return retorno

    End Function


    Public Sub ApagarCliente(nome As String)

        Try
            Dim cmd As MySqlCommand
            Dim sql As String

            AbrirConexao()
            sql = "DELETE FROM tb_clientes WHERE id='" & lblId.Text & "'"
            cmd = New MySqlCommand(sql, Conexao.conexao)

            cmd.ExecuteNonQuery()

            MsgBox("Cliente apagado com sucesso", MsgBoxStyle.Information, "Apagar Cliente")

        Catch ex As Exception
            MsgBox("Erro apagar cliente no banco de dados" & ex.Message, MsgBoxStyle.Critical, "Apagar Cliente")
        Finally
            FecharConcexao()
        End Try


    End Sub


    Public Sub CarregarDataGrid()

        Try
            AbrirConexao()

            Dim sql As String

            'COMPONENTES NECESSÁRIOS PARA PEGAR OS DADOS NO BD E INSERILOS EM DATAGRID
            'o tbTemporaria será uma tabela temporária para alimentar o dtgrid
            Dim da As MySqlDataAdapter
            Dim tbTemporaria As New DataTable

            sql = "SELECT * FROM tb_clientes ORDER BY nome asc"
            da = New MySqlDataAdapter(sql, Conexao.conexao)

            'preenchendo a tabela criada
            da.Fill(tbTemporaria)

            'carregando os valaores no datagrid
            dtGridClientes.DataSource = tbTemporaria

        Catch ex As Exception
            MsgBox("Erro ao buscar todos registros no BD" & Chr(10) & ex.Message, MsgBoxStyle.Information, "Busca Clientes")
        Finally
            FecharConcexao()
        End Try
    End Sub

    Private Sub txtCEP_TextChanged(sender As Object, e As EventArgs) Handles txtCEP.TextChanged
        MascaraCEP(sender)
    End Sub

    Private Sub txtCPF_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCPF.KeyPress
        If txtCPF.Text <> "" Then
            txtCPF.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCelular_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        If txtCelular.Text <> "" Then
            txtCelular.BackColor = Color.White
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir o cliente: " & txtNome.Text, vbOKCancel, "Apagar Cliente") = vbOK Then
            ApagarCliente(lblId.Text)
            Limpar_campos(Me)
            CarregarDataGrid()
        End If
    End Sub


    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        If rbNome.Checked Then
            Try
                AbrirConexao()
                Dim dt As New DataTable
                Dim da As MySqlDataAdapter
                Dim sql As String

                sql = "SELECT * FROM tb_clientes WHERE nome LIKE '" & txtBuscarNome.Text & "%' ORDER BY nome asc"
                da = New MySqlDataAdapter(sql, Conexao.conexao)

                da.Fill(dt)

                dtGridClientes.DataSource = dt

            Catch ex As Exception
                MsgBox("Erro ao localizar nomes para o dataGrid" & ex.Message, MsgBoxStyle.Critical, "Localizar Clientes")
            Finally

                FecharConcexao()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCpf_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCpf.TextChanged
        If rbCpf.Checked Then
            If txtBuscarCpf.Text <> "   .   .   -" Then
                Try
                    AbrirConexao()
                    Dim dt As New DataTable
                    Dim da As MySqlDataAdapter
                    Dim sql As String

                    sql = "SELECT * FROM tb_clientes WHERE cpf = '" & txtBuscarCpf.Text & "' ORDER BY cpf asc"
                    da = New MySqlDataAdapter(sql, Conexao.conexao)

                    da.Fill(dt)

                    dtGridClientes.DataSource = dt

                Catch ex As Exception
                    MsgBox("Erro ao localizar CPF para o dataGrid" & ex.Message, MsgBoxStyle.Critical, "Localizar Clientes")
                Finally
                    FecharConcexao()
                End Try
            Else
                CarregarDataGrid()
            End If
        End If
    End Sub
End Class