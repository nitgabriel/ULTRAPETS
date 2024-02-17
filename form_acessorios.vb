Public Class form_acessorios
    Private Sub adc_astronauta_Click(sender As Object, e As EventArgs) Handles adc_astro.Click
        If qtde_astro.Text = "" Or qtde_astro.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 13
            Dim quantidade As Integer = Integer.Parse(qtde_astro.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_mochilinha_Click(sender As Object, e As EventArgs) Handles adc_mochilinha.Click
        If qtde_mochilinha.Text = "" Or qtde_mochilinha.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 14
            Dim quantidade As Integer = Integer.Parse(qtde_mochilinha.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_transporte_Click(sender As Object, e As EventArgs) Handles adc_transporte.Click
        If qtde_transporte.Text = "" Or qtde_transporte.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 15
            Dim quantidade As Integer = Integer.Parse(qtde_transporte.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_playground_Click(sender As Object, e As EventArgs) Handles adc_playground.Click
        If qtde_playground.Text = "" Or qtde_playground.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 16
            Dim quantidade As Integer = Integer.Parse(qtde_playground.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_cercado_Click(sender As Object, e As EventArgs) Handles adc_cercado.Click
        If qtde_cercado.Text = "" Or qtde_cercado.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 17
            Dim quantidade As Integer = Integer.Parse(qtde_cercado.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_banheira_Click(sender As Object, e As EventArgs) Handles adc_banheira.Click
        If qtde_banheira.Text = "" Or qtde_banheira.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 18
            Dim quantidade As Integer = Integer.Parse(qtde_banheira.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
End Class