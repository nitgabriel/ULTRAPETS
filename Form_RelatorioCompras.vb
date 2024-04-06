Public Class Form_RelatorioCompras
    Private Sub Form_RelatorioCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Banco_dadosComprasDataSet.pedidoseprodutos'. Você pode movê-la ou removê-la conforme necessário.
        Me.pedidoseprodutosTableAdapter.Fill(Me.Banco_dadosComprasDataSet.pedidoseprodutos)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class