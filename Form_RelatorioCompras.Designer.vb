<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RelatorioCompras
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
        Me.BancodadosComprasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_dadosComprasDataSet = New ULTRAPETS.banco_dadosComprasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pedidoseprodutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pedidoseprodutosTableAdapter = New ULTRAPETS.banco_dadosComprasDataSetTableAdapters.pedidoseprodutosTableAdapter()
        CType(Me.BancodadosComprasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_dadosComprasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pedidoseprodutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BancodadosComprasDataSetBindingSource
        '
        Me.BancodadosComprasDataSetBindingSource.DataSource = Me.Banco_dadosComprasDataSet
        Me.BancodadosComprasDataSetBindingSource.Position = 0
        '
        'Banco_dadosComprasDataSet
        '
        Me.Banco_dadosComprasDataSet.DataSetName = "banco_dadosComprasDataSet"
        Me.Banco_dadosComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.pedidoseprodutosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ULTRAPETS.Rel_Compras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'pedidoseprodutosBindingSource
        '
        Me.pedidoseprodutosBindingSource.DataMember = "pedidoseprodutos"
        Me.pedidoseprodutosBindingSource.DataSource = Me.Banco_dadosComprasDataSet
        '
        'pedidoseprodutosTableAdapter
        '
        Me.pedidoseprodutosTableAdapter.ClearBeforeFill = True
        '
        'Form_RelatorioCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_RelatorioCompras"
        Me.Text = "Relatório de Compras"
        CType(Me.BancodadosComprasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_dadosComprasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pedidoseprodutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BancodadosComprasDataSetBindingSource As BindingSource
    Friend WithEvents Banco_dadosComprasDataSet As banco_dadosComprasDataSet
    Friend WithEvents pedidoseprodutosBindingSource As BindingSource
    Friend WithEvents pedidoseprodutosTableAdapter As banco_dadosComprasDataSetTableAdapters.pedidoseprodutosTableAdapter
End Class
