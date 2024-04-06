Public Class Form_RelatorioAgendamentos
    Private Sub Form_RelatorioAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Banco_dadosAgendamentosDataSet.banhoetosa'. Você pode movê-la ou removê-la conforme necessário.
        Me.BanhoetosaTableAdapter.Fill(Me.Banco_dadosAgendamentosDataSet.banhoetosa)
        'TODO: esta linha de código carrega dados na tabela 'Banco_dadosAgendamentosDataSet.clinica'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClinicaTableAdapter.Fill(Me.Banco_dadosAgendamentosDataSet.clinica)
        'TODO: esta linha de código carrega dados na tabela 'Banco_dadosAgendamentosDataSet.hotel'. Você pode movê-la ou removê-la conforme necessário.
        Me.HotelTableAdapter.Fill(Me.Banco_dadosAgendamentosDataSet.hotel)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class