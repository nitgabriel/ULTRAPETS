Public Class desmatricula
    Private alterar As String

    Private Sub btn_desmatricular_Click(sender As Object, e As EventArgs) Handles btn_desmatricular.Click
        If txt_nomedesm.Text = "" Or txt_cpfdesm.Text = "" Or txt_nomepetdesm.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "SELECT * FROM tb_creche WHERE nomepet='" & txt_nomepetdesm.Text & "' AND cpf='" & txt_cpfdesm.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then 'caso haja o pet com o mesmo id na tabela 
                    resp = MsgBox("Deseja realmente encerrar o plano da creche de " & txt_nomepetdesm.Text & "?" & vbNewLine & vbNewLine & "Lembramos aos clientes que, de acordo com nossa política de cancelamento, será cobrada uma taxa de R$ 200,00 em caso de cancelamento.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE FROM tb_creche WHERE nomepet='" & txt_nomepetdesm.Text & "' AND cpf='" & txt_cpfdesm.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Pet desmatrículado da creche!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        txt_cpfdesm.ResetText()
                        txt_nomedesm.ResetText()
                        txt_nomepetdesm.ResetText()
                    Else
                        MsgBox("Matrícula do pet mantida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    MsgBox("Dados não encontrados no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                MsgBox("ERRO AO CANCELAR PLANO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If txt_nomedesm.Text = "" Or txt_cpfdesm.Text = "" Or txt_nomepetdesm.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "SELECT * FROM tb_creche WHERE nomepet='" & txt_nomepetdesm.Text & "' AND cpf='" & txt_cpfdesm.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    If rs.Fields("planocreche").Value.ToString = alterar Then
                        MsgBox("O plano escolhido já é o atual!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Exit Sub
                    End If
                    sql = "update tb_creche set planocreche='" & alterar & "' WHERE nomepet='" & txt_nomepetdesm.Text & "' AND cpf='" & txt_cpfdesm.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Plano alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpfdesm.ResetText()
                    txt_nomedesm.ResetText()
                    txt_nomepetdesm.ResetText()
                Else
                    MsgBox("Dados não encontrados no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End If
            Catch ex As Exception
                MsgBox("ERRO AO ALTERAR PLANO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    Private Sub alterar_p1_CheckedChanged(sender As Object, e As EventArgs) Handles alterar_p1.CheckedChanged
        If alterar_p1.Checked = True Then
            alterar = "Plano 1"
        Else
            alterar = ""
        End If
    End Sub

    Private Sub alterar_p2_CheckedChanged(sender As Object, e As EventArgs) Handles alterar_p2.CheckedChanged
        If alterar_p2.Checked = True Then
            alterar = "Plano 2"
        Else
            alterar = ""
        End If
    End Sub

    Private Sub alterar_p3_CheckedChanged(sender As Object, e As EventArgs) Handles alterar_p3.CheckedChanged
        If alterar_p3.Checked = True Then
            alterar = "Plano 3"
        Else
            alterar = ""
        End If
    End Sub
    Private Sub txt_cpfdesm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cpfdesm.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cpfdesm.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class