<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agendhotel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agendhotel))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_saida = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_entrada = New System.Windows.Forms.DateTimePicker()
        Me.txt_peth = New ns1.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_agendar = New ns1.BunifuThinButton2()
        Me.txt_cttprop = New ns1.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_quartos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Fim da hospedagem"
        '
        'dtp_saida
        '
        Me.dtp_saida.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_saida.Location = New System.Drawing.Point(177, 174)
        Me.dtp_saida.Name = "dtp_saida"
        Me.dtp_saida.Size = New System.Drawing.Size(127, 20)
        Me.dtp_saida.TabIndex = 70
        Me.dtp_saida.Value = New Date(2023, 5, 28, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Inicio da hospedagem"
        '
        'dtp_entrada
        '
        Me.dtp_entrada.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_entrada.Location = New System.Drawing.Point(177, 122)
        Me.dtp_entrada.Name = "dtp_entrada"
        Me.dtp_entrada.Size = New System.Drawing.Size(127, 20)
        Me.dtp_entrada.TabIndex = 69
        Me.dtp_entrada.Value = New Date(2023, 5, 28, 0, 0, 0, 0)
        '
        'txt_peth
        '
        Me.txt_peth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_peth.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_peth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_peth.HintForeColor = System.Drawing.Color.Empty
        Me.txt_peth.HintText = ""
        Me.txt_peth.isPassword = False
        Me.txt_peth.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_peth.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_peth.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_peth.LineThickness = 3
        Me.txt_peth.Location = New System.Drawing.Point(31, 121)
        Me.txt_peth.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_peth.Name = "txt_peth"
        Me.txt_peth.Size = New System.Drawing.Size(127, 21)
        Me.txt_peth.TabIndex = 71
        Me.txt_peth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nome do Pet"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "REALIZE SEU AGENDAMENTO:"
        '
        'btn_agendar
        '
        Me.btn_agendar.ActiveBorderThickness = 1
        Me.btn_agendar.ActiveCornerRadius = 20
        Me.btn_agendar.ActiveFillColor = System.Drawing.Color.Gold
        Me.btn_agendar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agendar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_agendar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_agendar.BackgroundImage = CType(resources.GetObject("btn_agendar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agendar.ButtonText = "Agendar"
        Me.btn_agendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agendar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendar.ForeColor = System.Drawing.Color.Orange
        Me.btn_agendar.IdleBorderThickness = 1
        Me.btn_agendar.IdleCornerRadius = 20
        Me.btn_agendar.IdleFillColor = System.Drawing.Color.White
        Me.btn_agendar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_agendar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_agendar.Location = New System.Drawing.Point(66, 266)
        Me.btn_agendar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agendar.Name = "btn_agendar"
        Me.btn_agendar.Size = New System.Drawing.Size(128, 37)
        Me.btn_agendar.TabIndex = 79
        Me.btn_agendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cttprop
        '
        Me.txt_cttprop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cttprop.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cttprop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cttprop.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cttprop.HintText = ""
        Me.txt_cttprop.isPassword = False
        Me.txt_cttprop.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cttprop.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cttprop.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cttprop.LineThickness = 3
        Me.txt_cttprop.Location = New System.Drawing.Point(31, 173)
        Me.txt_cttprop.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cttprop.Name = "txt_cttprop"
        Me.txt_cttprop.Size = New System.Drawing.Size(127, 21)
        Me.txt_cttprop.TabIndex = 80
        Me.txt_cttprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Contato"
        '
        'cmb_quartos
        '
        Me.cmb_quartos.FormattingEnabled = True
        Me.cmb_quartos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmb_quartos.Location = New System.Drawing.Point(32, 222)
        Me.cmb_quartos.Name = "cmb_quartos"
        Me.cmb_quartos.Size = New System.Drawing.Size(126, 21)
        Me.cmb_quartos.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Quarto"
        '
        'agendhotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 393)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_quartos)
        Me.Controls.Add(Me.txt_cttprop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_agendar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_saida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_entrada)
        Me.Controls.Add(Me.txt_peth)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "agendhotel"
        Me.Text = "AGENDAMENTO HOTEL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_saida As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_entrada As DateTimePicker
    Friend WithEvents txt_peth As ns1.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_agendar As ns1.BunifuThinButton2
    Friend WithEvents txt_cttprop As ns1.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_quartos As ComboBox
    Friend WithEvents Label5 As Label
End Class
