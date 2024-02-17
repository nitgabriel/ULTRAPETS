Public Class hotel
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        AtualizarAgendamentos(dgv_hotel, MonthCalendar1)
    End Sub

    Private Sub hotel_Load(sender As Object, e As EventArgs) Handles Me.Load
        AtualizarAgendamentos(dgv_hotel, MonthCalendar1)
        CarregarApontamentos()
        MonthCalendar1.SelectionStart = DateTime.Now
    End Sub
    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        resp = MsgBox("Você confirma que seu pet está com as vacinas atualizadas? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            agendhotel.Show()
        Else
            MsgBox("É obrigatório o pet estar com as vacinas atualizadas para ser admitido no hotel.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If

    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        ' Verifica se um item está selecionado no ComboBox
        If cmb_cancelamento.SelectedItem Is Nothing Then
            MessageBox.Show("Selecione uma reserva para cancelar.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' Confirmação do cancelamento
        Dim resposta As DialogResult = MessageBox.Show("Tem certeza de que deseja cancelar essa reserva?", "Confirmação de Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            ' Obtém o ID da reserva associado ao item selecionado no ComboBox
            Dim indexSelecionado As Integer = cmb_cancelamento.SelectedIndex
            Dim idReserva As Integer = listaIdReservas(indexSelecionado)

            ' Executa a consulta de exclusão no banco de dados
            sql = "DELETE FROM tb_hotel WHERE id_reserva = " & idReserva
            cmb_cancelamento.SelectedIndex = -1


            Try
                db.Execute(sql)
                MessageBox.Show("Reserva cancelada com sucesso.", "Cancelamento de Reserva", MessageBoxButtons.OK)
                CarregarApontamentos() ' Atualiza a lista de apontamentos no ComboBox após a exclusão
                AtualizarAgendamentos(dgv_hotel, MonthCalendar1) ' Atualiza a exibição dos agendamentos no calendário
            Catch ex As Exception
                MessageBox.Show("Erro ao cancelar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub sair_hotel_Click(sender As Object, e As EventArgs) Handles sair_hotel.Click
        Me.Hide()
        areacliente.Show()
    End Sub
End Class