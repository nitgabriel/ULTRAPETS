Imports System.Globalization

Public Class banhotosa
    Private servico, valor As String
    Private Sub banhotosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarCorBotoes()
    End Sub
    Private Sub AtualizarCorBotoes()
        Dim dataSelecionada As DateTime = datepicker_bantosa.Value

        For Each btn As Guna.UI.WinForms.GunaButton In Me.Controls.OfType(Of Guna.UI.WinForms.GunaButton)()
            If btn.Name.StartsWith("uni") Then
                Dim horario As String = btn.Name.Substring(btn.Name.LastIndexOf("_") + 1) & ":00"
                Dim unidade As Integer = CInt(btn.Name.Substring(3, 1))

                If VerificarDisponibilidadeHorario(dataSelecionada, horario, unidade) Then
                    btn.BaseColor = Color.Green ' Horário disponível
                Else
                    btn.BaseColor = Color.Red ' Horário ocupado
                End If
            End If
        Next
    End Sub
    Private Sub btn_banho_CheckedChanged(sender As Object, e As EventArgs) Handles btn_banho.CheckedChanged
        If btn_banho.Checked = True Then
            servico = "Banho simples"
            valor = "20"
        Else
            servico = ""
            valor = ""
        End If
    End Sub
    Private Sub btn_tosa_CheckedChanged(sender As Object, e As EventArgs) Handles btn_tosa.CheckedChanged
        If btn_tosa.Checked = True Then
            servico = "Banho e tosa"
            valor = "50"
        Else
            servico = ""
            valor = ""
        End If
    End Sub
    Function VerificarDisponibilidadeHorario(dataSelecionada As DateTime, horario As String, unidade As Integer) As Boolean
        ' Formatar a data para comparação no SQL
        Dim dataFormatada As String = dataSelecionada.ToString("yyyy/MM/dd")

        ' Consultar o banco de dados para verificar se há um agendamento com o horário na data selecionada e unidade
        sql = "SELECT * FROM tb_banho_tosa WHERE data = #" & dataFormatada & "# AND horario = '" & horario & "' AND unidade = '" & unidade & "'"
        Console.WriteLine(sql)
        rs = db.Execute(sql)

        ' Verificar se o conjunto de registros está vazio
        Console.WriteLine("rs.EOF: " & rs.EOF)
        If rs.EOF Then
            Return True ' Horário disponível
        Else
            Return False ' Horário ocupado
        End If
    End Function
    Private Sub uni1_10_Click(sender As Object, e As EventArgs) Handles uni1_10.Click
        AgendarHorario(servico, 1, "10:00")
    End Sub

    Private Sub uni1_11_Click(sender As Object, e As EventArgs) Handles uni1_11.Click
        AgendarHorario(servico, 1, "11:00")
    End Sub

    Private Sub uni1_13_Click(sender As Object, e As EventArgs) Handles uni1_13.Click
        AgendarHorario(servico, 1, "13:00")
    End Sub

    Private Sub uni1_14_Click(sender As Object, e As EventArgs) Handles uni1_14.Click
        AgendarHorario(servico, 1, "14:00")
    End Sub

    Private Sub uni1_15_Click(sender As Object, e As EventArgs) Handles uni1_15.Click
        AgendarHorario(servico, 1, "15:00")
    End Sub

    Private Sub uni1_16_Click(sender As Object, e As EventArgs) Handles uni1_16.Click
        AgendarHorario(servico, 1, "16:00")
    End Sub

    Private Sub uni1_17_Click(sender As Object, e As EventArgs) Handles uni1_17.Click
        AgendarHorario(servico, 1, "17:00")
    End Sub

    Private Sub uni2_08_Click(sender As Object, e As EventArgs) Handles uni2_08.Click
        AgendarHorario(servico, 2, "08:00")
    End Sub

    Private Sub uni2_09_Click(sender As Object, e As EventArgs) Handles uni2_09.Click
        AgendarHorario(servico, 2, "09:00")
    End Sub

    Private Sub uni2_10_Click(sender As Object, e As EventArgs) Handles uni2_10.Click
        AgendarHorario(servico, 2, "10:00")
    End Sub

    Private Sub uni2_11_Click(sender As Object, e As EventArgs) Handles uni2_11.Click
        AgendarHorario(servico, 2, "11:00")
    End Sub

    Private Sub uni2_12_Click(sender As Object, e As EventArgs) Handles uni2_12.Click
        AgendarHorario(servico, 2, "12:00")
    End Sub

    Private Sub uni2_13_Click(sender As Object, e As EventArgs) Handles uni2_13.Click
        AgendarHorario(servico, 2, "13:00")
    End Sub

    Private Sub uni2_14_Click(sender As Object, e As EventArgs) Handles uni2_14.Click
        AgendarHorario(servico, 2, "14:00")
    End Sub

    Private Sub uni2_15_Click(sender As Object, e As EventArgs) Handles uni2_15.Click
        AgendarHorario(servico, 2, "15:00")
    End Sub
    Private Sub AgendarHorario(servico As String, unidade As Integer, horario As String)
        ' Verificar se todos os campos estão preenchidos
        If String.IsNullOrEmpty(txtbox_nomepet.Text) OrElse String.IsNullOrEmpty(servico) OrElse
       String.IsNullOrEmpty(txtbox_ctt.Text) OrElse String.IsNullOrEmpty(txtbox_num.Text) OrElse
       String.IsNullOrEmpty(txtbox_val.Text) OrElse String.IsNullOrEmpty(txtbox_cvv.Text) Then
            MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' Verificar disponibilidade do horário
        Dim dataSelecionada As DateTime = datepicker_bantosa.Value
        If Not VerificarDisponibilidadeHorario(dataSelecionada, horario, unidade) Then
            MessageBox.Show("Horário indisponível nesta unidade!", "Erro", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' Realizar o agendamento
        Try
            Dim nomePet As String = txtbox_nomepet.Text
            Dim contato As String = txtbox_ctt.Text
            Dim pagamento As String = txtbox_num.Text
            Dim validade As String = txtbox_val.Text
            Dim cvv As String = txtbox_cvv.Text
            Dim valorDecimal As Decimal = Decimal.Parse(valor)

            ' Inserir os dados no banco de dados
            sql = "INSERT INTO tb_banho_tosa (nome_pet, servico, unidade, contato, pagamento, validade, cvv, data, horario, valor, id_cliente) " &
                  "VALUES ('" & nomePet & "', '" & servico & "', " & unidade & ", '" & contato & "', '" & pagamento & "', '" & validade & "', '" & cvv & "', #" & dataSelecionada.ToString("yyyy/MM/dd") & "#, '" & horario & "', " & valorDecimal.ToString("0.00", CultureInfo.InvariantCulture) & ", " & id_cliente_atual & ")"
            db.Execute(sql)

            AtualizarCorBotoes()
            MessageBox.Show("Agendamento de " & servico & " na unidade " & unidade & " no horário " & horario & " foi realizado com sucesso." & vbCrLf & "Valor: R$" & valorDecimal, "Sucesso", MessageBoxButtons.OK)
            txtbox_ctt.ResetText()
            txtbox_cvv.ResetText()
            txtbox_nomepet.ResetText()
            txtbox_num.ResetText()
            txtbox_val.ResetText()
            txtbox_nomepet.Focus()

        Catch ex As Exception
            MessageBox.Show("Erro ao realizar o agendamento: " & ex.ToString(), "Erro", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub txtbox_ctt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_ctt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txtbox_ctt.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbox_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_num.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txtbox_num.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbox_cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_cvv.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txtbox_cvv.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbox_val_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_val.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txtbox_val.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub sair_banho_Click(sender As Object, e As EventArgs) Handles sair_banho.Click
        Me.Hide()
        areacliente.Show()
    End Sub

    Private Sub datepicker_bantosa_ValueChanged(sender As Object, e As EventArgs) Handles datepicker_bantosa.ValueChanged
        AtualizarCorBotoes()
    End Sub
End Class