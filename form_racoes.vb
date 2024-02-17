Public Class form_racoes
    Private Sub adc_origens_Click(sender As Object, e As EventArgs) Handles adc_origens.Click
        If qtde_origens.Text = "" Or qtde_origens.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            ' Substitua 1 pelo ID correto do produto
            Dim id_produto As Integer = 1

            ' Pegar a quantidade inserida pelo usuário
            Dim quantidade As Integer = Integer.Parse(qtde_origens.Text)

            ' Chamar a função para adicionar o produto ao carrinho
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_pedigree_Click(sender As Object, e As EventArgs) Handles adc_pedigree.Click
        If qtde_pedigree.Text = "" Or qtde_pedigree.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 2
            Dim quantidade As Integer = Integer.Parse(qtde_pedigree.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_papagaio_Click(sender As Object, e As EventArgs) Handles adc_papagaio.Click
        If qtde_papagaio.Text = "" Or qtde_papagaio.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 3
            Dim quantidade As Integer = Integer.Parse(qtde_papagaio.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_felina_Click(sender As Object, e As EventArgs) Handles adc_felina.Click
        If qtde_felina.Text = "" Or qtde_felina.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 4
            Dim quantidade As Integer = Integer.Parse(qtde_felina.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_vitakraft_Click(sender As Object, e As EventArgs) Handles adc_vitakraft.Click
        If qtde_vitakraft.Text = "" Or qtde_vitakraft.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 5
            Dim quantidade As Integer = Integer.Parse(qtde_vitakraft.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_nutriflakes_Click(sender As Object, e As EventArgs) Handles adc_peixes.Click
        If qtde_peixes.Text = "" Or qtde_peixes.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 6
            Dim quantidade As Integer = Integer.Parse(qtde_peixes.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub

End Class