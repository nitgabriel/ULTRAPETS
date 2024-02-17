Public Class matricula
    Private generom, plano As String

    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        Dim cpf As String = txt_cpf.Text

        ' Remove caracteres não numéricos do CPF
        cpf = New String(cpf.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Verifica o comprimento do CPF para aplicar a máscara corretamente
        If cpf.Length > 0 Then
            If cpf.Length <= 3 Then
                cpf = cpf.PadRight(3, "0"c)
            ElseIf cpf.Length <= 6 Then
                cpf = cpf.PadRight(6, "0"c).Insert(3, ".")
            ElseIf cpf.Length <= 9 Then
                cpf = cpf.PadRight(9, "0"c).Insert(3, ".").Insert(7, ".")
            Else
                cpf = cpf.PadRight(11, "0"c).Insert(3, ".").Insert(7, ".").Insert(11, "-")
            End If
        End If

        txt_cpf.Text = cpf
    End Sub
    Private Sub check_femea_CheckedChanged(sender As Object, e As EventArgs) Handles check_femea.CheckedChanged
        If check_femea.Checked = True Then
            generom = "Fêmea"
        Else
            generom = ""
        End If
    End Sub

    Private Sub check_macho_CheckedChanged(sender As Object, e As EventArgs) Handles check_macho.CheckedChanged
        If check_macho.Checked = True Then
            generom = "Macho"
        Else
            generom = ""
        End If
    End Sub
    Private Sub txt_contato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contato.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_contato.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_numcartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numcartao.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_numcartao.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cvv.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cvv.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_validade_LostFocus(sender As Object, e As EventArgs) Handles txt_validade.LostFocus
        If txt_validade.Text.Length = 4 Then
            txt_validade.Text = txt_validade.Text.Insert(2, "/")
        End If
    End Sub
    Private Sub txt_validade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_validade.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_validade.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub check_plano1_CheckedChanged(sender As Object, e As EventArgs) Handles check_plano1.CheckedChanged
        If check_plano1.Checked = True Then
            plano = "Plano 1"
        Else
            plano = ""
        End If
    End Sub
    Private Sub check_plano2_CheckedChanged(sender As Object, e As EventArgs) Handles check_plano2.CheckedChanged
        If check_plano2.Checked = True Then
            plano = "Plano 2"
        Else
            plano = ""
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If txt_nomepet.Text = "" Or txt_raca.Text = "" Or txt_nome.Text = "" Or txt_contato.Text = "" Or txt_cpf.Text = "" Or txt_numcartao.Text = "" Or txt_validade.Text = "" Or txt_cvv.Text = "" Or generom = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf check_femea.Checked = False And check_macho.Checked = False Then
            MsgBox("Informe o gênero do pet!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
        ElseIf check_plano1.Checked = False And check_plano2.Checked = False And check_plano3.Checked = False Then
            MsgBox("Selecione o plano desejado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
        Else
            Try
                sql = "SELECT * FROM tb_creche WHERE nomepet='" & txt_nomepet.Text & "' AND id_cliente=" & id_cliente_atual
                rs = db.Execute(sql)
                If rs.EOF = True Then 'caso não o pet com o mesmo id na tabela 
                    sql = "INSERT INTO tb_creche (nomepet, racapet, data, genero, nome, cpf, contato, id_cliente, cartao, validade, cvv, planocreche) VALUES ('" & txt_nomepet.Text & "', '" & txt_raca.Text & "', '" & txt_datanasc.Value.ToString("dd/MM/yyyy") & "', '" & generom & "', '" & txt_nome.Text & "', '" & txt_cpf.Text & "', '" & txt_contato.Text & "', " & id_cliente_atual & ", '" & txt_numcartao.Text & "', '" & txt_validade.Text & "', '" & txt_cvv.Text & "', '" & plano & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("" & plano & " da Ultracreche adquirido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_nomepet.ResetText()
                    txt_raca.ResetText()
                    txt_nome.ResetText()
                    txt_contato.ResetText()
                    txt_cpf.ResetText()
                    txt_numcartao.ResetText()
                    txt_validade.ResetText()
                    txt_cvv.ResetText()
                    txt_datanasc.ResetText()
                Else
                    MsgBox("Não é permitido dois pets com o mesmo nome do mesmo usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End If
            Catch ex As Exception
                MsgBox("Erro ao contratar plano! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub check_plano3_CheckedChanged(sender As Object, e As EventArgs) Handles check_plano3.CheckedChanged
        If check_plano3.Checked = True Then
            plano = "Plano 3"
        Else
            plano = ""
        End If
    End Sub

    Private Sub matricula_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_datanasc.Value = DateTime.Now
    End Sub
    Private Sub txt_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cpf.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cpf.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class