Module utilidades
    Public TeclaPressionada As String
    Public UltimoChar As String



    Public Sub ApenasNumeros(Tecla As KeyPressEventArgs, Caixa As Object)
        TeclaPressionada = Tecla.KeyChar
        If Caixa.SelectionStart - 1 <> -1 Then
            UltimoChar = Caixa.text.chars(Caixa.SelectionStart - 1)
        Else
            UltimoChar = ""
        End If


        'Rejeitando teclas que sejam diferentes de BACKSPACE e que não sejam algum numero

        If (AscW(Tecla.KeyChar) < 48 Or AscW(Tecla.KeyChar) > 57) And (AscW(Tecla.KeyChar) <> 8) Then

            Tecla.KeyChar = ""

        End If



    End Sub

    Public Sub ApenasLetras(Tecla As KeyPressEventArgs, Caixa As Object)
        TeclaPressionada = Tecla.KeyChar
        If Caixa.SelectionStart - 1 <> -1 Then
            UltimoChar = Caixa.text.chars(Caixa.SelectionStart - 1)
        Else
            UltimoChar = ""
        End If

        If ((AscW(Tecla.KeyChar) > 32) And (AscW(Tecla.KeyChar) <= 64)) Or ((AscW(Tecla.KeyChar) >= 91) And (AscW(Tecla.KeyChar) <= 93)) _
            Or (AscW(Tecla.KeyChar) = 95) Or ((AscW(Tecla.KeyChar) >= 123) And (AscW(Tecla.KeyChar) <= 125)) Then
            Tecla.KeyChar = ""
        End If

    End Sub

    'Public Sub MascaraCelular(Caixa As Object)

    '    Dim Cursor As Integer

    '    Dim Mask As String

    '    '(00)0.0000-0000

    '    Caixa.MaxLength = 13

    '    If AscW(TeclaPressionada) <> 8 Then

    '        '----- Definindo a posição que o cursor esta no momento

    '        Cursor = Caixa.SelectionStart

    '        '----- Redefinindo a nova posição do cursor para inserir os caracteres da máscara

    '        If Len(Caixa.text) = 0 Then

    '            Cursor = Cursor + 1

    '        End If



    '        '----- Retirando os caracteres caso o usuário digite

    '        Mask = Replace(Caixa.text, "(", "")
    '        Mask = Replace(Caixa.text, ")", "")
    '        Mask = Replace(Caixa.text, ".", "")
    '        Mask = Replace(Caixa.text, "-", "")



    '        '----- Recolocando os caracteres especiais

    '        If Len(Mask) >= 0 Then

    '            Mask = Replace(Caixa.text, "(", "")

    '            Mask = Mask.Insert(0, "(")

    '            Cursor = Cursor + 1

    '        End If


    '        If Len(Mask) >= 3 And Len(Mask) <= 4 Then
    '            Mask = Replace(Caixa.text, ")", "")
    '            Mask = Mask.Insert(3, ")")
    '            Cursor = Cursor + 1
    '        End If

    '        If Len(Mask) = 4 Then
    '            Cursor = Cursor + 1
    '        End If

    '        'If Len(Mask) >= 5 And Len(Mask) <= 6 Then
    '        '    Mask = Replace(Caixa.text, ".", "")
    '        '    Mask = Mask.Insert(5, ".")
    '        '    Cursor = Cursor + 1
    '        'End If

    '        If Len(Mask) > 4 And Len(Mask) <= 5 Then
    '            Mask = Replace(Caixa.text, ".", "")
    '            Mask = Mask.Insert(4, ".")
    '            Cursor = Cursor + 1
    '        End If

    '        If Len(Mask) > 10 And Len(Mask) <= 11 Then
    '            Mask = Replace(Caixa.text, ".", "")
    '            Mask = Mask.Insert(10, ".")
    '            Cursor = Cursor + 1
    '        End If

    '        If Len(Mask) > 11 Then

    '            '----- Retirando os pontos
    '            Mask = Replace(Caixa.text, "(", "")
    '            Mask = Replace(Caixa.text, ")", "")
    '            Mask = Replace(Caixa.text, ".", "")

    '            '----- Recolocando os pontos

    '            Mask = Mask.Insert(0, "(")

    '            Mask = Mask.Insert(3, ")")

    '            Mask = Mask.Insert(4, ".")

    '            Mask = Mask.Insert(10, ".")

    '        End If



    '        '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar

    '        Caixa.text = Mask

    '        Caixa.SelectionStart = Cursor
    '    Else
    '        If UltimoChar = "-" Then
    '            SendKeys.Send("{BACKSPACE}")
    '        End If
    '    End If

    'End Sub

    Public Sub MascaraCPF(Caixa As Object)

        Dim Cursor As Integer

        Dim Mask As String

        '000.000.000-00

        Caixa.MaxLength = 14

        If AscW(TeclaPressionada) <> 8 Then

            '----- Definindo a posição que o cursor esta no momento

            Cursor = Caixa.SelectionStart

            '----- Redefinindo a nova posição do cursor para inserir os caracteres da máscara

            If Len(Caixa.text) = 3 Then

                Cursor = Cursor + 1

            End If



            '----- Retirando os caracteres caso o usuário digite

            Mask = Replace(Caixa.text, ".", "")
            Mask = Replace(Caixa.text, "-", "")



            '----- Recolocando os caracteres especiais



            If Len(Mask) >= 3 Then

                Mask = Replace(Caixa.text, ".", "")

                Mask = Mask.Insert(3, ".")

                Cursor = Cursor + 1

            End If

            If Len(Mask) >= 7 Then
                Mask = Mask.Insert(7, ".")
                Cursor = Cursor + 1
            End If

            If Len(Mask) >= 11 Then
                Mask = Mask.Insert(11, ".")
                Cursor = Cursor + 1
            End If


            'If Len(Mask) >= 11 Then

            '    '----- Retirando os pontos

            '    Mask = Replace(Caixa.text, ".", "")
            '    Mask = Replace(Caixa.text, "-", "")

            '    '----- Recolocando os pontos

            '    Mask = Mask.Insert(3, ".")

            '    Mask = Mask.Insert(7, ".")

            '    Mask = Mask.Insert(11, "-")

            'End If



            '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar

            Caixa.text = Mask

            Caixa.SelectionStart = Cursor
        Else
            If UltimoChar = "-" Then
                SendKeys.Send("{BACKSPACE}")
            End If
        End If

    End Sub

    Public Sub MascaraCEP(Caixa As Object)

        Dim Cursor As Integer

        Dim Mask As String



        Caixa.MaxLength = 9

        If AscW(TeclaPressionada) <> 8 Then

            '----- Definindo a posição que o cursor esta no momento

            Cursor = Caixa.SelectionStart



            '----- Redefinindo a nova posição do cursor caso necessario

            If Len(Caixa.text) = 5 Then

                Cursor = Cursor + 1

            End If



            '----- Retirando as barras

            Mask = Replace(Caixa.text, "-", "")



            '----- Recolocando as barras

            'If Len(Mask) < 5 And Len(Mask) >= 2 Then

            '    Mask = Mask.Insert(2, "/")

            'End If



            If Len(Mask) >= 5 Then

                '----- Retirando as barras

                Mask = Replace(Caixa.text, "-", "")

                '----- Recolocando as barras

                ' Mask = Mask.Insert(2, "/")

                Mask = Mask.Insert(5, "-")

            End If



            '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar

            Caixa.text = Mask

            Caixa.SelectionStart = Cursor
        Else
            If UltimoChar = "-" Then
                SendKeys.Send("{BACKSPACE}")
            End If
        End If

    End Sub

    Public Sub MascaraDatas(Caixa As Object)

        Dim Cursor As Integer

        Dim Mask As String



        Caixa.MaxLength = 10

        If AscW(TeclaPressionada) <> 8 Then

            '----- Definindo a posição que o cursor esta no momento

            Cursor = Caixa.SelectionStart



            '----- Redefinindo a nova posição do cursor caso necessario

            If Len(Caixa.text) = 2 Or Len(Caixa.text) = 5 Then

                Cursor = Cursor + 1

            End If



            '----- Retirando as barras

            Mask = Replace(Caixa.text, "/", "")



            '----- Recolocando as barras

            If Len(Mask) < 5 And Len(Mask) >= 2 Then

                Mask = Mask.Insert(2, "/")

            End If



            If Len(Mask) >= 5 Then

                '----- Retirando as barras

                Mask = Replace(Caixa.text, "/", "")

                '----- Recolocando as barras

                Mask = Mask.Insert(2, "/")

                Mask = Mask.Insert(5, "/")

            End If



            '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar

            Caixa.text = Mask

            Caixa.SelectionStart = Cursor
        Else
            If UltimoChar = "/" Then
                SendKeys.Send("{BACKSPACE}")
            End If
        End If

    End Sub



    Public Sub Limpar_campos(f As Form)
        Dim c As Object
        For Each c In f.Controls
            If c.tag = "*" Or c.tag = "*Obr" Then
                c.Text = ""
            End If
        Next
    End Sub

    Public Sub Habilitar_campos(f As Form)
        Dim c As Object
        For Each c In f.Controls
            If c.tag = "*" Or c.tag = "*Obr" Then
                c.Enabled = True
            End If
        Next
    End Sub

    Public Sub Desbilitar_campos(f As Form)
        Dim c As Object
        For Each c In f.Controls
            If c.tag = "*" Or c.tag = "*Obr" Then
                c.BackColor = Color.White
                c.Enabled = False
            End If
        Next
    End Sub

    Public Function campos_com_valores(f As Form) As Boolean
        Dim c As Object
        Dim x As Boolean
        x = False
        For Each c In f.Controls
            If c.tag = "*" Or c.tag = "*Obr" Then
                If c.Text <> "" Then
                    x = True
                End If
            End If
        Next
        Return x
    End Function

    Public Function campos_obrigatorios(f As Form) As Boolean
        Dim c = New Object
        Dim l = New List(Of Object)
        Dim erros As Boolean
        erros = False

        For Each c In f.Controls
            If c.tag = "*Obr" Then
                If c.Text = "" Or c.Text = "(  ) .    -" Or c.Text = "   .   .   -" Then
                    Try
                        l.Add(c)
                    Catch ex As NullReferenceException
                        MsgBox("Erro ao criar lista de objetos")
                    End Try

                End If
            End If
        Next

        If l.Count > 0 Then
            For Each c In l
                c.BackColor = Color.Red
            Next
            MsgBox("Verifique os campos Obrigatorios!", MsgBoxStyle.Information, "Atenção")
            erros = True
        End If

        Return erros

    End Function

End Module
