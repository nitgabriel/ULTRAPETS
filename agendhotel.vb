Public Class agendhotel
    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        ' Verifica se todos os campos estão preenchidos
        If txt_peth.Text = "" OrElse txt_cttprop.Text = "" OrElse cmb_quartos.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' Verifica se a estadia é de pelo menos dois dias
        If dtp_saida.Value <= dtp_entrada.Value.AddDays(1) Then
            MessageBox.Show("O pet deve ser hospedado por pelo menos dois dias.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        If dtp_entrada.Value.Date < DateTime.Today Then
            MessageBox.Show("Não é possível agendar para uma data no passado.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        If dtp_saida.Value.Date < dtp_entrada.Value.Date Then
            MessageBox.Show("A data de saída deve ser posterior à data de entrada.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If


        ' Verifica se já existe uma reserva para o quarto no período desejado
        Dim dataEntrada As DateTime = dtp_entrada.Value
        Dim dataSaida As DateTime = dtp_saida.Value

        sql = "SELECT * FROM tb_hotel WHERE numero_quarto = " & cmb_quartos.SelectedItem & " AND ((data_entrada >= #" & dataEntrada.ToString("yyyy/MM/dd") & "# AND data_entrada <= #" & dataSaida.ToString("yyyy/MM/dd") & "#) OR (data_saida >= #" & dataEntrada.ToString("yyyy/MM/dd") & "# AND data_saida <= #" & dataSaida.ToString("yyyy/MM/dd") & "#))"
        rs = db.Execute(sql)

        If Not rs.EOF Then
            MessageBox.Show("O quarto já está reservado para o período desejado.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim totalDias As Integer = (dataSaida - dataEntrada).Days + 1
        Dim precoTotal As Integer = totalDias * 100
        Dim valorReserva As Decimal = CDec(precoTotal)

        Try
            Dim resposta As DialogResult = MessageBox.Show("O preço total é R$" & precoTotal.ToString() & ". Deseja confirmar o agendamento?", "Confirmação de Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resposta = DialogResult.Yes Then
                sql = "INSERT INTO tb_hotel (id_cliente, nome_pet, numero_quarto, data_entrada, data_saida, contato, valor) VALUES (" & id_cliente_atual & ", '" & txt_peth.Text & "', " & cmb_quartos.SelectedItem & ", #" & dataEntrada.ToString("yyyy/MM/dd") & "#, #" & dataSaida.ToString("yyyy/MM/dd") & "#, '" & txt_cttprop.Text & "', " & valorReserva & ")"
                db.Execute(sql)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer agendamento!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try

        AtualizarAgendamentos(hotel.dgv_hotel, hotel.MonthCalendar1)
        CarregarApontamentos()
        Me.Close()
    End Sub
    Private Sub txt_cttprop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cttprop.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cttprop.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub agendhotel_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_entrada.Value = DateTime.Now
        dtp_saida.Value = DateTime.Now
    End Sub
End Class