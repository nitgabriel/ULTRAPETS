<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hotel
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hotel))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.dgv_hotel = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New Guna.UI.WinForms.GunaButton()
        Me.cmb_cancelamento = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sair_hotel = New System.Windows.Forms.Label()
        CType(Me.dgv_hotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(35, 180)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.DarkOrange
        '
        'dgv_hotel
        '
        Me.dgv_hotel.AllowUserToAddRows = False
        Me.dgv_hotel.AllowUserToDeleteRows = False
        Me.dgv_hotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_hotel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hotel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27, Me.Column28, Me.Column29, Me.Column30, Me.Column31, Me.Column32})
        Me.dgv_hotel.Location = New System.Drawing.Point(35, 385)
        Me.dgv_hotel.Name = "dgv_hotel"
        Me.dgv_hotel.ReadOnly = True
        Me.dgv_hotel.Size = New System.Drawing.Size(1009, 253)
        Me.dgv_hotel.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Número do Quarto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "1"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 38
        '
        'Column3
        '
        Me.Column3.HeaderText = "2"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 38
        '
        'Column4
        '
        Me.Column4.HeaderText = "3"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 38
        '
        'Column5
        '
        Me.Column5.HeaderText = "4"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 38
        '
        'Column6
        '
        Me.Column6.HeaderText = "5"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 38
        '
        'Column7
        '
        Me.Column7.HeaderText = "6"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 38
        '
        'Column8
        '
        Me.Column8.HeaderText = "7"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 38
        '
        'Column9
        '
        Me.Column9.HeaderText = "8"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 38
        '
        'Column10
        '
        Me.Column10.HeaderText = "9"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 38
        '
        'Column11
        '
        Me.Column11.HeaderText = "10"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 44
        '
        'Column12
        '
        Me.Column12.HeaderText = "11"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 44
        '
        'Column13
        '
        Me.Column13.HeaderText = "12"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 44
        '
        'Column14
        '
        Me.Column14.HeaderText = "13"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 44
        '
        'Column15
        '
        Me.Column15.HeaderText = "14"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 44
        '
        'Column16
        '
        Me.Column16.HeaderText = "15"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 44
        '
        'Column17
        '
        Me.Column17.HeaderText = "16"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 44
        '
        'Column18
        '
        Me.Column18.HeaderText = "17"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 44
        '
        'Column19
        '
        Me.Column19.HeaderText = "18"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 44
        '
        'Column20
        '
        Me.Column20.HeaderText = "19"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 44
        '
        'Column21
        '
        Me.Column21.HeaderText = "20"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 44
        '
        'Column22
        '
        Me.Column22.HeaderText = "21"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 44
        '
        'Column23
        '
        Me.Column23.HeaderText = "22"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 44
        '
        'Column24
        '
        Me.Column24.HeaderText = "23"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Width = 44
        '
        'Column25
        '
        Me.Column25.HeaderText = "24"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Width = 44
        '
        'Column26
        '
        Me.Column26.HeaderText = "25"
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.Width = 44
        '
        'Column27
        '
        Me.Column27.HeaderText = "26"
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        Me.Column27.Width = 44
        '
        'Column28
        '
        Me.Column28.HeaderText = "27"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.Width = 44
        '
        'Column29
        '
        Me.Column29.HeaderText = "28"
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.Width = 44
        '
        'Column30
        '
        Me.Column30.HeaderText = "29"
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.Width = 44
        '
        'Column31
        '
        Me.Column31.HeaderText = "30"
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.Width = 44
        '
        'Column32
        '
        Me.Column32.HeaderText = "31"
        Me.Column32.Name = "Column32"
        Me.Column32.ReadOnly = True
        Me.Column32.Width = 44
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaButton4.BaseColor = System.Drawing.Color.DarkOrange
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(35, 347)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Yellow
        Me.GunaButton4.Size = New System.Drawing.Size(227, 28)
        Me.GunaButton4.TabIndex = 6
        Me.GunaButton4.Text = "RESERVAR"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(399, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "INFORMAÇÕES SOBRE NOSSO PET HOTEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "- Pagamento na unidade ao realizar Check-In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "- Métodos de pagamento: PIX, Crédito e Débito "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 16)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "- Veterinários e monitores de plantão "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "- Refeições Inclusas "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "- Preço diária: R$100,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "ATENÇÃO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(356, 16)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "- A demarcação em                      significa que está indisponível"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(503, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "vermelho"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.AnimationHoverSpeed = 0.07!
        Me.btn_cancelar.AnimationSpeed = 0.03!
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.BaseColor = System.Drawing.Color.DarkOrange
        Me.btn_cancelar.BorderColor = System.Drawing.Color.Black
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cancelar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.Image = Nothing
        Me.btn_cancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_cancelar.Location = New System.Drawing.Point(805, 282)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_cancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cancelar.OnHoverImage = Nothing
        Me.btn_cancelar.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_cancelar.Size = New System.Drawing.Size(227, 28)
        Me.btn_cancelar.TabIndex = 90
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_cancelamento
        '
        Me.cmb_cancelamento.FormattingEnabled = True
        Me.cmb_cancelamento.Location = New System.Drawing.Point(805, 252)
        Me.cmb_cancelamento.Name = "cmb_cancelamento"
        Me.cmb_cancelamento.Size = New System.Drawing.Size(227, 21)
        Me.cmb_cancelamento.TabIndex = 91
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(792, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(256, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Procure sua reserva, caso queira cancelar:"
        '
        'sair_hotel
        '
        Me.sair_hotel.AutoSize = True
        Me.sair_hotel.BackColor = System.Drawing.Color.Transparent
        Me.sair_hotel.Location = New System.Drawing.Point(6, 8)
        Me.sair_hotel.Name = "sair_hotel"
        Me.sair_hotel.Size = New System.Drawing.Size(121, 13)
        Me.sair_hotel.TabIndex = 93
        Me.sair_hotel.Text = "↩  Voltar para o menu"
        '
        'hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1082, 650)
        Me.Controls.Add(Me.sair_hotel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_cancelamento)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.dgv_hotel)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.DoubleBuffered = True
        Me.Name = "hotel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PETSHOTEL"
        CType(Me.dgv_hotel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents dgv_hotel As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_cancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmb_cancelamento As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sair_hotel As Label
End Class
