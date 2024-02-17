Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio_foto, aux_cpf, resp, aux_nome As String
    Public dir_banco = Application.StartupPath & "\banco_dados\banco_dados.mdb"
    Public cont, id_cliente_atual As Integer
    Public listaIdReservas As New List(Of Integer)

    Sub conectar_banco()
        'String de criação de banco ADO (MSACCESS)
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source =" & dir_banco)
            MsgBox("Conectado com o banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub AtualizarAgendamentos(dgv_hotel As DataGridView, MonthCalendar1 As MonthCalendar)
        dgv_hotel.Rows.Clear()

        ' Cria o cabeçalho das colunas
        dgv_hotel.ColumnCount = DateTime.DaysInMonth(MonthCalendar1.SelectionStart.Year, MonthCalendar1.SelectionStart.Month) + 1
        dgv_hotel.Columns(0).Name = "Número do Quarto"

        For i = 1 To dgv_hotel.ColumnCount - 1
            dgv_hotel.Columns(i).Name = i.ToString()
        Next

        ' Cria as linhas do DGV representando cada quarto
        For i = 1 To 10
            Dim row As String() = New String(dgv_hotel.ColumnCount - 1) {}
            row(0) = "Quarto " & i.ToString()
            dgv_hotel.Rows.Add(row)
        Next

        ' Consulta o banco de dados e pinta de vermelho os dias em que há reservas
        Dim primeiroDiaDoMes As DateTime = New DateTime(MonthCalendar1.SelectionStart.Year, MonthCalendar1.SelectionStart.Month, 1)
        Dim ultimoDiaDoMes As DateTime = primeiroDiaDoMes.AddMonths(1).AddSeconds(-1)

        sql = "SELECT * FROM tb_hotel WHERE data_entrada < #" & ultimoDiaDoMes.ToString("yyyy/MM/dd HH:mm:ss") & "# AND data_saida > #" & primeiroDiaDoMes.ToString("yyyy/MM/dd HH:mm:ss") & "#"
        rs = db.Execute(sql)

        While Not rs.EOF
            Dim numeroQuarto As Integer = CInt(rs("numero_quarto").Value)
            Dim dataEntrada As DateTime = DateTime.Parse(rs("data_entrada").Value.ToString())
            Dim dataSaida As DateTime = DateTime.Parse(rs("data_saida").Value.ToString())

            For Each cell As DataGridViewCell In dgv_hotel.Rows(numeroQuarto - 1).Cells
                If cell.ColumnIndex > 0 Then
                    Dim currentDate As DateTime = primeiroDiaDoMes.AddDays(cell.ColumnIndex - 1)
                    If currentDate >= dataEntrada AndAlso currentDate <= dataSaida Then
                        cell.Style.BackColor = Color.Red
                    End If
                End If
            Next

            rs.MoveNext()
        End While
    End Sub
    Sub CarregarApontamentos()
        ' Limpa o ComboBox de cancelamento
        hotel.cmb_cancelamento.Items.Clear()
        listaIdReservas.Clear()

        ' Consulta o banco de dados para obter as reservas do cliente atual
        sql = "SELECT * FROM tb_hotel WHERE id_cliente = " & id_cliente_atual
        rs = db.Execute(sql)

        ' Adiciona as informações das reservas no ComboBox de cancelamento
        While Not rs.EOF
            Dim apontamento As String = rs("nome_pet").Value.ToString() & " - "

            If IsDate(rs("data_entrada").Value) Then
                apontamento &= CDate(rs("data_entrada").Value).ToString("dd/MM/yyyy")
            End If

            apontamento &= " - "

            If IsDate(rs("data_saida").Value) Then
                apontamento &= CDate(rs("data_saida").Value).ToString("dd/MM/yyyy")
            End If
            hotel.cmb_cancelamento.Items.Add(apontamento)
            listaIdReservas.Add(CInt(rs("id_reserva").Value))
            rs.MoveNext()
        End While
    End Sub

End Module
