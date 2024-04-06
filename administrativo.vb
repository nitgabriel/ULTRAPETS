Public Class administrativo
    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        Form_RelatorioCompras.Show()
    End Sub

    Private Sub btn_agendamentos_Click(sender As Object, e As EventArgs) Handles btn_agendamentos.Click
        Form_RelatorioAgendamentos.Show()
    End Sub

    Private Sub sair_administrativo_Click(sender As Object, e As EventArgs) Handles sair_administrativo.Click
        Me.Hide()
        areacliente.Show()
    End Sub
End Class