Imports MySql.Data.MySqlClient
Imports SistemaSalao.FrmCadastroClientes
Imports SistemaSalao.Conexao

Module DadosClientes
    'Dim f As FrmCadastroClientes
    '' f = New FrmCadastroClientes()
    'Function InserirNovoCliente() As Boolean

    '    Dim resultado As Boolean
    '    resultado = False


    '    Try
    '        Dim cmd As MySqlCommand
    '        Dim sql As String
    '        AbrirConexao()

    '        sql = "INSERT INTO tb_clientes (nome, cpf, telefone, dataNascimento, celular, email, cep, endereco, bairro, cidade) VALUES ('" & f.txtNome.Text & "', '" & f.txtCPF.Text & "'
    ''            ,'" & f.txtTelefone.Text & "','" & CDate(f.txtDatanascimento.Text) & "','" & f.txtCelular.Text & "','" & f.txtEmail.Text & "','" & f.txtCEP.Text & "',
    ''            '" & f.txtEndereço.Text & "','" & f.txtBairro.Text & "','" & f.txtCidade.Text & "')"

    '        cmd = New MySqlCommand(sql, Conexao.conexao)
    '        cmd.ExecuteNonQuery()

    '        resultado = True

    '    Catch ex As Exception
    '        MsgBox("Erro ao tentar salvar Cliente !" & ex.Message)
    '    Finally
    '        FecharConcexao()
    '    End Try

    '    Return resultado

    'End Function

    'Public Function buscarPorCPF(CPF As String) As Boolean
    '    Dim cmdCPF As MySqlCommand
    '    Dim readerCPF As MySqlDataReader

    '    Dim retorno As Boolean = False

    '    Try
    '        Dim sql As String
    '        AbrirConexao()
    '        sql = "SELECT * FROM tb_clientes WHERE cpf = '" & f.txtCPF.Text & "'"
    '        cmdCPF = New MySqlCommand(sql, Conexao.conexao)

    '        readerCPF = cmdCPF.ExecuteReader
    '        If readerCPF.Read = True Then
    '            retorno = True
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Erro ao buscar cpf!" & ex.Message)
    '    Finally
    '        FecharConcexao()
    '    End Try


    '    Return retorno

    ' End Function
End Module
