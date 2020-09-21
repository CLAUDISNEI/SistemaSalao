Public Class FrmLogin
    Dim nomeTela As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(116, 204, 182)
        txtSenha.BackColor = Color.FromArgb(116, 204, 182)

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String
        Dim senha As String

        usuario = txtUsuario.Text
        senha = txtSenha.Text

        If usuario <> "" And senha <> "" Then
            Dim form = New FrmTelaPrincipal
            FrmTelaPrincipal.ShowDialog()


        Else
            MsgBox("Preencha os Campos!", vbInformation, "Atenção!")
            txtUsuario.Focus()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblErro.Click

    End Sub
End Class
