<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RelatorioAgendamentos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Banco_dadosAgendamentosDataSet = New ULTRAPETS.banco_dadosAgendamentosDataSet()
        Me.HotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelTableAdapter = New ULTRAPETS.banco_dadosAgendamentosDataSetTableAdapters.hotelTableAdapter()
        Me.ClinicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaTableAdapter = New ULTRAPETS.banco_dadosAgendamentosDataSetTableAdapters.clinicaTableAdapter()
        Me.BanhoetosaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BanhoetosaTableAdapter = New ULTRAPETS.banco_dadosAgendamentosDataSetTableAdapters.banhoetosaTableAdapter()
        CType(Me.Banco_dadosAgendamentosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanhoetosaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HotelBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ClinicaBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.BanhoetosaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ULTRAPETS.Rel_Agendamento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Banco_dadosAgendamentosDataSet
        '
        Me.Banco_dadosAgendamentosDataSet.DataSetName = "banco_dadosAgendamentosDataSet"
        Me.Banco_dadosAgendamentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HotelBindingSource
        '
        Me.HotelBindingSource.DataMember = "hotel"
        Me.HotelBindingSource.DataSource = Me.Banco_dadosAgendamentosDataSet
        '
        'HotelTableAdapter
        '
        Me.HotelTableAdapter.ClearBeforeFill = True
        '
        'ClinicaBindingSource
        '
        Me.ClinicaBindingSource.DataMember = "clinica"
        Me.ClinicaBindingSource.DataSource = Me.Banco_dadosAgendamentosDataSet
        '
        'ClinicaTableAdapter
        '
        Me.ClinicaTableAdapter.ClearBeforeFill = True
        '
        'BanhoetosaBindingSource
        '
        Me.BanhoetosaBindingSource.DataMember = "banhoetosa"
        Me.BanhoetosaBindingSource.DataSource = Me.Banco_dadosAgendamentosDataSet
        '
        'BanhoetosaTableAdapter
        '
        Me.BanhoetosaTableAdapter.ClearBeforeFill = True
        '
        'Form_RelatorioAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_RelatorioAgendamentos"
        Me.Text = "Relatório de Agendamentos"
        CType(Me.Banco_dadosAgendamentosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanhoetosaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Banco_dadosAgendamentosDataSet As banco_dadosAgendamentosDataSet
    Friend WithEvents HotelBindingSource As BindingSource
    Friend WithEvents HotelTableAdapter As banco_dadosAgendamentosDataSetTableAdapters.hotelTableAdapter
    Friend WithEvents ClinicaBindingSource As BindingSource
    Friend WithEvents ClinicaTableAdapter As banco_dadosAgendamentosDataSetTableAdapters.clinicaTableAdapter
    Friend WithEvents BanhoetosaBindingSource As BindingSource
    Friend WithEvents BanhoetosaTableAdapter As banco_dadosAgendamentosDataSetTableAdapters.banhoetosaTableAdapter
End Class
