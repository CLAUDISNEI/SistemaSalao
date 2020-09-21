Imports MySql.Data.MySqlClient
Module Conexao
    'CRIA UMA CONEXÃO COM BANCO DE DATOS INFORMADO
    Public conexao As New MySqlConnection("server=localhost; userid=root; database=sistema_salao; port=;")

    Sub AbrirConexao()
        'verifica se a conexão está fechada
        Try
            If conexao.State = 0 Then
                conexao.Open()
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir UrlConexao" & ex.Message, MsgBoxStyle.Critical, "Conexão!")
        End Try

    End Sub

    Sub FecharConcexao()
        Try
            If conexao.State = 1 Then
                conexao.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao fechar UrlConexao" & ex.Message, MsgBoxStyle.Critical, "Conexão!")
        End Try

    End Sub
End Module
