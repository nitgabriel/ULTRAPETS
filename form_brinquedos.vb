Public Class form_brinquedos
    Private Sub adc_bolinha_Click(sender As Object, e As EventArgs) Handles adc_bolinha.Click
        If qtde_bolinha.Text = "" Or qtde_bolinha.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 7
            Dim quantidade As Integer = Integer.Parse(qtde_bolinha.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_rato_Click(sender As Object, e As EventArgs) Handles adc_rato.Click
        If qtde_rato.Text = "" Or qtde_rato.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 8
            Dim quantidade As Integer = Integer.Parse(qtde_rato.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_superball_Click(sender As Object, e As EventArgs) Handles adc_superball.Click
        If qtde_superball.Text = "" Or qtde_superball.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 9
            Dim quantidade As Integer = Integer.Parse(qtde_superball.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_coleira_Click(sender As Object, e As EventArgs) Handles adc_coleira.Click
        If qtde_coleira.Text = "" Or qtde_coleira.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 10
            Dim quantidade As Integer = Integer.Parse(qtde_coleira.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_colhamster_Click(sender As Object, e As EventArgs) Handles adc_colhamster.Click
        If qtde_colhamster.Text = "" Or qtde_colhamster.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 11
            Dim quantidade As Integer = Integer.Parse(qtde_colhamster.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
    Private Sub adc_colpeitoral_Click(sender As Object, e As EventArgs) Handles adc_colpeitoral.Click
        If qtde_colpeitoral.Text = "" Or qtde_colpeitoral.Text < 0 Then
            MsgBox("Forneça um número válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            Dim id_produto As Integer = 12
            Dim quantidade As Integer = Integer.Parse(qtde_colpeitoral.Text)
            petshop.AdicionarAoCarrinho(id_produto, quantidade)
        End If
    End Sub
End Class