Imports System.Runtime.Remoting

Public Class petshop
    Private entrega As String
    Private valorTotal As Decimal = 0

    Sub switchpanel(ByVal panel As Form)
        mostrar_form.Controls.Clear()
        panel.TopLevel = False
        mostrar_form.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btn_racoes_Click(sender As Object, e As EventArgs) Handles btn_racoes.Click
        switchpanel(form_racoes)
    End Sub

    Private Sub btn_brinquedos_Click(sender As Object, e As EventArgs) Handles btn_brinquedos.Click
        switchpanel(form_brinquedos)
    End Sub

    Private Sub btn_acessorios_Click(sender As Object, e As EventArgs) Handles btn_acessorios.Click
        switchpanel(form_acessorios)
    End Sub

    Private Sub sair_petshop_Click(sender As Object, e As EventArgs) Handles sair_petshop.Click
        Me.Hide()
        areacliente.Show()
    End Sub
    Private Sub AtualizarValorTotal()
        valorTotal = 0 ' Reinicializa o valor total

        ' Percorre todas as linhas do carrinho
        For Each row As DataGridViewRow In dgv_carrinho.Rows
            ' Obtém o valor total do produto na linha atual
            Dim precoTotal As Decimal = CDec(row.Cells("PrecoTotal").Value)
            valorTotal += precoTotal ' Soma ao valor total do carrinho
        Next

        ' Atualiza o texto da label com o valor total formatado
        txt_total.Text = "Valor Total: R$ " & valorTotal.ToString("0.00")
    End Sub

    Private Sub InicializarCarrinho()
        'Limpar todas as linhas e colunas existentes
        dgv_carrinho.Rows.Clear()
        dgv_carrinho.Columns.Clear()

        'Adicionar colunas para o DataGridView
        dgv_carrinho.Columns.Add("Id", "Id")
        dgv_carrinho.Columns.Add("Descricao", "Descrição")
        dgv_carrinho.Columns.Add("Categoria", "Categoria")
        dgv_carrinho.Columns.Add("Preco", "Preço")
        dgv_carrinho.Columns.Add("Quantidade", "Quantidade")
        dgv_carrinho.Columns.Add("PrecoTotal", "Preço Total")

        'Adicionar coluna para Alteração
        Dim alterColumn As New DataGridViewImageColumn()
        alterColumn.Image = Image.FromFile(Application.StartupPath & "\botoes\edit_dgv.png")
        alterColumn.Name = "alterColumn"
        alterColumn.HeaderText = "Alterar"
        dgv_carrinho.Columns.Add(alterColumn)

        'Adicionar coluna para Exclusão
        Dim delColumn As New DataGridViewImageColumn()
        delColumn.Image = Image.FromFile(Application.StartupPath & "\botoes\delete_dgv.png")
        delColumn.Name = "delColumn"
        delColumn.HeaderText = "Excluir"
        dgv_carrinho.Columns.Add(delColumn)
    End Sub
    Private Sub dgv_carrinho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_carrinho.CellContentClick

        If e.ColumnIndex = dgv_carrinho.Columns("alterColumn").Index AndAlso e.RowIndex >= 0 Then
            Dim novaQuantidade As String = InputBox("Forneça a nova quantidade:", "Editar Quantidade")
            Dim quantidade As Integer
            If Integer.TryParse(novaQuantidade, quantidade) Then
                If quantidade > 0 Then
                    ' Atualizar a quantidade na linha correspondente
                    dgv_carrinho.Rows(e.RowIndex).Cells("Quantidade").Value = quantidade

                    ' Calcular o novo preço total
                    Dim preco As Double = CDbl(dgv_carrinho.Rows(e.RowIndex).Cells("Preco").Value)
                    Dim precoTotal As Double = quantidade * preco
                    dgv_carrinho.Rows(e.RowIndex).Cells("PrecoTotal").Value = precoTotal
                    AtualizarValorTotal()
                Else
                    dgv_carrinho.Rows.RemoveAt(e.RowIndex)
                    MessageBox.Show("Produto removido do carrinho!", "Editar Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AtualizarValorTotal()
                End If
            Else
                ' Exibir mensagem de erro para quantidade inválida
                MessageBox.Show("Quantidade inválida!", "Editar Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf e.ColumnIndex = dgv_carrinho.Columns("delColumn").Index AndAlso e.RowIndex >= 0 Then
            dgv_carrinho.Rows.RemoveAt(e.RowIndex)
            AtualizarValorTotal()

        End If
    End Sub

    Private Sub petshop_Load(sender As Object, e As EventArgs) Handles Me.Load
        InicializarCarrinho()
    End Sub
    Public Sub AdicionarAoCarrinho(id_produto As Integer, quantidade As Integer)

        sql = "SELECT * FROM tb_produtos WHERE id_produto = " & id_produto
        rs = db.Execute(sql)

        If rs.EOF = False Then
            Dim newRow As Object() = New Object() {rs.Fields("id_produto").Value, rs.Fields("descricao").Value, rs.Fields("categoria").Value, rs.Fields("preco").Value, quantidade, quantidade * rs.Fields("preco").Value}
            dgv_carrinho.Rows.Add(newRow)
            AtualizarValorTotal()
        Else
            MsgBox("Produto não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End If
    End Sub
    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        If conf_cartao.Text = "" Or conf_validade.Text = "" Or conf_cvv.Text = "" Then
            MsgBox("Preencha os dados do pagamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        ElseIf entrega = "Delivery" AndAlso (txt_rua.Text = "" Or txt_bairro.Text = "" Or txt_cidadecarrinho.Text = "" Or txt_ufcarrinho.Text = "" Or txt_cep.Text = "" Or txt_numcasa.Text = "") Then
            MsgBox("Preencha os dados para entrega via delivery!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                ' Inserir novo pedido na tb_pedidos
                sql = "INSERT INTO tb_pedidos (id_cliente, cartao, validade, cvv, entrega, rua, bairro, cidade, uf, cep, numero, complemento) VALUES (" &
                            id_cliente_atual & ", '" &
                            conf_cartao.Text & "', '" &
                            conf_validade.Text & "', '" &
                            conf_cvv.Text & "', '" &
                            entrega & "', '" &
                            txt_rua.Text & "', '" &
                            txt_bairro.Text & "', '" &
                            txt_cidadecarrinho.Text & "', '" &
                            txt_ufcarrinho.Text & "', '" &
                            txt_cep.Text & "', '" &
                            txt_numcasa.Text & "', '" &
                            txt_comp.Text & "')"

                db.Execute(sql)

                ' Obter id do pedido recém-criado
                sql = "SELECT TOP 1 id_pedido FROM tb_pedidos ORDER BY id_pedido DESC"
                rs = db.Execute(sql)
                Dim id_pedido As Integer = rs.Fields("id_pedido").Value

                ' Inserir todos os produtos no pedido na tb_pedido_produto
                For Each row As DataGridViewRow In dgv_carrinho.Rows
                    Dim id_produto As Integer = row.Cells("Id").Value
                    Dim quantidade As Integer = row.Cells("Quantidade").Value
                    Dim valor_total_produto As Decimal = row.Cells("PrecoTotal").Value
                    sql = "INSERT INTO tb_pedido_produto (id_pedido, id_produto, quantidade, valortotal) VALUES (" & id_pedido & ", " & id_produto & ", " & quantidade & ", " & valor_total_produto & ")"
                    db.Execute(sql)

                    ' Atualizar o campo "estoque" na tabela "tb_produtos"
                    sql = "UPDATE tb_produtos SET estoque = estoque - " & quantidade & " WHERE id_produto = " & id_produto
                    db.Execute(sql)

                Next

                ' Limpar o carrinho
                InicializarCarrinho()

                MsgBox("Compra realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
            Catch ex As Exception
                MsgBox("ERRO ao realizar a compra!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub
    Private Sub check_buscar_CheckedChanged(sender As Object, e As EventArgs) Handles check_buscar.CheckedChanged
        If check_buscar.Checked = True Then
            entrega = "Buscar na unidade"
        Else
            entrega = ""

        End If
    End Sub
    Private Sub check_delivery_CheckedChanged(sender As Object, e As EventArgs) Handles check_delivery.CheckedChanged
        If check_delivery.Checked = True Then
            entrega = "Delivery"

        Else
            entrega = ""

        End If
    End Sub
    Private Sub txtbox_conf_cartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_cartao.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_cartao.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbox_conf_validade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_validade.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_validade.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbox_conf_cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_cvv.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_cvv.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub conf_cartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_cartao.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_cartao.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub conf_validade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_validade.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_validade.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub conf_cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conf_cvv.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If conf_cvv.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_ufcarrinho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ufcarrinho.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If txt_ufcarrinho.Text.Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cep.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If txt_cep.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numcasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numcasa.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_total_Click(sender As Object, e As EventArgs) Handles txt_total.Click

    End Sub
End Class