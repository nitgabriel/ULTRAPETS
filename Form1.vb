Imports System.ComponentModel.Design

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call conectar_banco()
    End Sub

    Private Sub btn_cad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_cad.LinkClicked
        anima.HideSync(painel_login)
        anima.ShowSync(painel_cadastro)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        anima.HideSync(painel_cadastro)
        anima.ShowSync(painel_login)
        painel_login.Visible = True
        painel_login.BringToFront()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            sql = "select * from tb_login where email='" & txt_email.Text & "' and senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then 'as informações de login estão corretas
                MsgBox("Usuário logado com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                id_cliente_atual = rs.Fields("id_cliente").Value 'Assumindo que "id_cliente" é o nome do campo no seu recordset
                areacliente.Show()
                Me.Hide()
            ElseIf txt_email.Text = "administrativoUltra" And txt_senha.Text = "acessoAdministrativo" Then
                id_cliente_atual = 0
                areacliente.Show()
                Me.Hide()
            Else
                'as informações de login estão incorretas
                MsgBox("Email ou senha incorretos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao efetuar login!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_cadsenha.Text <> txt_confsenha.Text Then
            MsgBox("As senhas inseridas diferem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cademail.Text = "" Or txt_cadsenha.Text = "" Or txt_confsenha.Text = "" Or txt_cadcel.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "SELECT * FROM tb_login WHERE contato='" & txt_cadcel.Text & "'"
                rs = db.Execute(sql)
                If Not rs.EOF Then
                    MsgBox("Este telefone de contato já cadastrado no sistema!")
                    Exit Sub
                End If

                sql = "SELECT * FROM tb_login WHERE email='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then 'caso não haja o usuario na tabela de lo banco
                    sql = "INSERT INTO tb_login (email, senha, contato) VALUES ('" & txt_cademail.Text & "', '" & txt_cadsenha.Text & "', '" & txt_cadcel.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cademail.ResetText()
                    txt_cadsenha.ResetText()
                    txt_confsenha.ResetText()
                    txt_cadcel.ResetText()
                    anima.HideSync(painel_cadastro)
                    anima.ShowSync(painel_login)
                End If
            Catch ex As Exception
                MsgBox("Erro ao cadastrar usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub check_senha_CheckedChanged(sender As Object, e As EventArgs) Handles check_senha.CheckedChanged
        If check_senha.Checked Then
            txt_senha.isPassword = False
        Else
            txt_senha.isPassword = True
        End If
    End Sub

    Private Sub txt_senha_Enter(sender As Object, e As EventArgs) Handles txt_senha.Enter
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = String.Empty
            txt_senha.isPassword = True
        End If
    End Sub

    Private Sub txt_cadsenha_Enter(sender As Object, e As EventArgs) Handles txt_cadsenha.Enter
        If txt_cadsenha.Text = "Senha" Then
            txt_cadsenha.Text = String.Empty
            txt_cadsenha.isPassword = True
        End If
    End Sub

    Private Sub txt_confsenha_Enter(sender As Object, e As EventArgs) Handles txt_confsenha.Enter
        If txt_confsenha.Text = "Senha" Then
            txt_confsenha.Text = String.Empty
            txt_confsenha.isPassword = True
        End If
    End Sub

    Private Sub check_msenha_CheckedChanged(sender As Object, e As EventArgs) Handles check_msenha.CheckedChanged
        If check_msenha.Checked Then
            txt_cadsenha.isPassword = False
            txt_confsenha.isPassword = False
        Else
            txt_cadsenha.isPassword = True
            txt_confsenha.isPassword = True
        End If
    End Sub
    Private Sub txt_cadcel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cadcel.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cadcel.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_esqueceu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_esqueceu.LinkClicked
        form_senha.Show()
    End Sub
End Class
