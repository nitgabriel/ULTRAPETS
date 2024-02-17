Public Class clinica
    Private genero As String

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        animar.HideSync(painel_mostrar)
        animar.ShowSync(painel_adquirir)
        painel_adquirir.BringToFront()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        animar.ShowSync(painel_cancelar)
        painel_cancelar.BringToFront()
        animar.HideSync(painel_adquirir)

    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        animar.HideSync(painel_cancelar)
        animar.ShowSync(painel_mostrar)
        painel_mostrar.BringToFront()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        animar.HideSync(painel_adquirir)
        animar.ShowSync(painel_mostrar)
        painel_mostrar.BringToFront()
    End Sub

    Private Sub txt_cpfclin_TextChanged(sender As Object, e As EventArgs) Handles txt_cpfclin.TextChanged
        Dim cpf As String = txt_cpfclin.Text

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

        txt_cpfclin.Text = cpf
    End Sub

    Private Sub txt_cpfclin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cpfclin.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cpfclin.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ctt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ctt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_ctt.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_val_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_val.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_val.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_cpfcan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cpfcan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cpfcan.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn_adquirir_Click(sender As Object, e As EventArgs) Handles btn_adquirir.Click

        If txt_namepet.Text = "" Or txt_race.Text = "" Or txt_name.Text = "" Or txt_ctt.Text = "" Or txt_cpfclin.Text = "" Or txt_numc.Text = "" Or txt_val.Text = "" Or txt_cvvclin.Text = "" Or genero = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf check_fem.Checked = False And check_male.Checked = False Then
            MsgBox("Informe o gênero do pet!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
        Else
            Try
                sql = "SELECT * FROM tb_clinica WHERE nomepet='" & txt_namepet.Text & "' AND id_cliente=" & id_cliente_atual
                rs = db.Execute(sql)
                If rs.EOF = True Then 'caso não o pet com o mesmo id na tabela 
                    sql = "INSERT INTO tb_clinica (nomepet, racapet, data, genero, nome, cpf, contato, id_cliente, cartao, validade, cvv) VALUES ('" & txt_namepet.Text & "', '" & txt_race.Text & "', '" & txt_nasc.Value.ToString("dd/MM/yyyy") & "', '" & genero & "', '" & txt_name.Text & "', '" & txt_cpfclin.Text & "', '" & txt_ctt.Text & "', " & id_cliente_atual & ", '" & txt_numc.Text & "', '" & txt_val.Text & "', '" & txt_cvvclin.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Plano veterinário adquirido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_namepet.ResetText()
                    txt_race.ResetText()
                    txt_name.ResetText()
                    txt_ctt.ResetText()
                    txt_cpfclin.ResetText()
                    txt_numc.ResetText()
                    txt_val.ResetText()
                    txt_cvvclin.ResetText()
                    txt_nasc.ResetText()
                Else
                    MsgBox("Não é permitido adquirir o plano veterinário duas vezes para o mesmo pet!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End If
            Catch ex As Exception
                MsgBox("Erro ao contratar plano! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub check_fem_CheckedChanged(sender As Object, e As EventArgs) Handles check_fem.CheckedChanged
        If check_fem.Checked = True Then
            genero = "Fêmea"
        Else
            genero = ""
        End If
    End Sub

    Private Sub check_male_CheckedChanged(sender As Object, e As EventArgs) Handles check_male.CheckedChanged
        If check_male.Checked = True Then
            genero = "Macho"
        Else
            genero = ""
        End If
    End Sub
    Private Sub txt_numc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numc.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_numc.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_cvvclin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cvvclin.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cvvclin.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_val_LostFocus(sender As Object, e As EventArgs) Handles txt_val.LostFocus
        If txt_val.Text.Length = 4 Then
            txt_val.Text = txt_val.Text.Insert(2, "/")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If txt_nomecanc.Text = "" Or txt_cpfcan.Text = "" Or txt_petcanc.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "SELECT * FROM tb_clinica WHERE nomepet='" & txt_petcanc.Text & "' AND cpf='" & txt_cpfcan.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then 'caso haja o pet com o mesmo id na tabela 
                    resp = MsgBox("Deseja realmente encerrar o plano veterinário de " & txt_petcanc.Text & "?" & vbNewLine & vbNewLine & "Lembramos aos clientes que, de acordo com nossa política de cancelamento, será cobrada uma taxa de R$ 200,00 em caso de cancelamento.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE FROM tb_clinica WHERE nomepet='" & txt_petcanc.Text & "' AND cpf='" & txt_cpfcan.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Plano veterinário cancelado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Else
                        MsgBox("Plano veterinário mantido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    MsgBox("Dados não encontrados no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                MsgBox("ERRO AO CANCELAR PLANO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub sair_clinica_Click(sender As Object, e As EventArgs) Handles sair_clinica.Click
        Me.Hide()
        areacliente.Show()
    End Sub

    Private Sub clinica_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_nasc.Value = DateTime.Now
    End Sub
End Class