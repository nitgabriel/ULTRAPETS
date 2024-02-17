<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(matricula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nomepet = New ns1.BunifuMaterialTextbox()
        Me.txt_raca = New ns1.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome = New ns1.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_contato = New ns1.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_numcartao = New ns1.BunifuMaterialTextbox()
        Me.txt_validade = New ns1.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.check_plano1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.check_plano2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.check_plano3 = New Guna.UI.WinForms.GunaRadioButton()
        Me.check_femea = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.check_macho = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.txt_cvv = New ns1.BunifuMaterialTextbox()
        Me.btn_finalizar = New ns1.BunifuThinButton2()
        Me.BunifuCards1 = New ns1.BunifuCards()
        Me.txt_datanasc = New ns1.BunifuDatepicker()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sobre o Pet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Raça"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gênero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data de Nascimento"
        '
        'txt_nomepet
        '
        Me.txt_nomepet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomepet.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nomepet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nomepet.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nomepet.HintText = ""
        Me.txt_nomepet.isPassword = False
        Me.txt_nomepet.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_nomepet.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nomepet.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_nomepet.LineThickness = 3
        Me.txt_nomepet.Location = New System.Drawing.Point(15, 56)
        Me.txt_nomepet.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomepet.Name = "txt_nomepet"
        Me.txt_nomepet.Size = New System.Drawing.Size(177, 30)
        Me.txt_nomepet.TabIndex = 5
        Me.txt_nomepet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_raca
        '
        Me.txt_raca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_raca.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_raca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_raca.HintForeColor = System.Drawing.Color.Empty
        Me.txt_raca.HintText = ""
        Me.txt_raca.isPassword = False
        Me.txt_raca.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_raca.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_raca.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_raca.LineThickness = 3
        Me.txt_raca.Location = New System.Drawing.Point(15, 112)
        Me.txt_raca.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_raca.Name = "txt_raca"
        Me.txt_raca.Size = New System.Drawing.Size(177, 30)
        Me.txt_raca.TabIndex = 6
        Me.txt_raca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Sobre o Proprietário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nome Completo"
        '
        'txt_nome
        '
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nome.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nome.HintText = ""
        Me.txt_nome.isPassword = False
        Me.txt_nome.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_nome.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nome.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_nome.LineThickness = 3
        Me.txt_nome.Location = New System.Drawing.Point(15, 191)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(376, 30)
        Me.txt_nome.TabIndex = 9
        Me.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Contato Telefônico"
        '
        'txt_contato
        '
        Me.txt_contato.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contato.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_contato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_contato.HintForeColor = System.Drawing.Color.Empty
        Me.txt_contato.HintText = ""
        Me.txt_contato.isPassword = False
        Me.txt_contato.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_contato.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_contato.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_contato.LineThickness = 3
        Me.txt_contato.Location = New System.Drawing.Point(15, 247)
        Me.txt_contato.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(177, 30)
        Me.txt_contato.TabIndex = 11
        Me.txt_contato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = ""
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cpf.LineThickness = 3
        Me.txt_cpf.Location = New System.Drawing.Point(213, 247)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(178, 30)
        Me.txt_cpf.TabIndex = 13
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(287, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Dados de Pagamento e Matrícula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Número do Cartão"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(210, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Validade"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(297, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "CVV"
        '
        'txt_numcartao
        '
        Me.txt_numcartao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_numcartao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_numcartao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_numcartao.HintForeColor = System.Drawing.Color.Empty
        Me.txt_numcartao.HintText = ""
        Me.txt_numcartao.isPassword = False
        Me.txt_numcartao.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_numcartao.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_numcartao.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_numcartao.LineThickness = 3
        Me.txt_numcartao.Location = New System.Drawing.Point(15, 328)
        Me.txt_numcartao.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numcartao.Name = "txt_numcartao"
        Me.txt_numcartao.Size = New System.Drawing.Size(177, 21)
        Me.txt_numcartao.TabIndex = 18
        Me.txt_numcartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_validade
        '
        Me.txt_validade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_validade.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_validade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_validade.HintForeColor = System.Drawing.Color.Empty
        Me.txt_validade.HintText = ""
        Me.txt_validade.isPassword = False
        Me.txt_validade.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_validade.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_validade.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_validade.LineThickness = 3
        Me.txt_validade.Location = New System.Drawing.Point(213, 328)
        Me.txt_validade.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_validade.Name = "txt_validade"
        Me.txt_validade.Size = New System.Drawing.Size(65, 21)
        Me.txt_validade.TabIndex = 20
        Me.txt_validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Plano de Assinatura"
        '
        'check_plano1
        '
        Me.check_plano1.BaseColor = System.Drawing.SystemColors.Control
        Me.check_plano1.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_plano1.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_plano1.FillColor = System.Drawing.Color.White
        Me.check_plano1.Location = New System.Drawing.Point(15, 372)
        Me.check_plano1.Name = "check_plano1"
        Me.check_plano1.Size = New System.Drawing.Size(68, 20)
        Me.check_plano1.TabIndex = 23
        Me.check_plano1.Text = "Plano 1"
        '
        'check_plano2
        '
        Me.check_plano2.BaseColor = System.Drawing.SystemColors.Control
        Me.check_plano2.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_plano2.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_plano2.FillColor = System.Drawing.Color.White
        Me.check_plano2.Location = New System.Drawing.Point(87, 372)
        Me.check_plano2.Name = "check_plano2"
        Me.check_plano2.Size = New System.Drawing.Size(68, 20)
        Me.check_plano2.TabIndex = 24
        Me.check_plano2.Text = "Plano 2"
        '
        'check_plano3
        '
        Me.check_plano3.BaseColor = System.Drawing.SystemColors.Control
        Me.check_plano3.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_plano3.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_plano3.FillColor = System.Drawing.Color.White
        Me.check_plano3.Location = New System.Drawing.Point(162, 372)
        Me.check_plano3.Name = "check_plano3"
        Me.check_plano3.Size = New System.Drawing.Size(68, 20)
        Me.check_plano3.TabIndex = 25
        Me.check_plano3.Text = "Plano 3"
        '
        'check_femea
        '
        Me.check_femea.BaseColor = System.Drawing.Color.White
        Me.check_femea.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_femea.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_femea.FillColor = System.Drawing.Color.White
        Me.check_femea.Location = New System.Drawing.Point(213, 63)
        Me.check_femea.Name = "check_femea"
        Me.check_femea.Size = New System.Drawing.Size(20, 20)
        Me.check_femea.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(236, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 14)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Fêmea"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(311, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 14)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Macho"
        '
        'check_macho
        '
        Me.check_macho.BaseColor = System.Drawing.Color.White
        Me.check_macho.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_macho.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_macho.FillColor = System.Drawing.Color.White
        Me.check_macho.Location = New System.Drawing.Point(288, 63)
        Me.check_macho.Name = "check_macho"
        Me.check_macho.Size = New System.Drawing.Size(20, 20)
        Me.check_macho.TabIndex = 29
        '
        'txt_cvv
        '
        Me.txt_cvv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cvv.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cvv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cvv.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cvv.HintText = ""
        Me.txt_cvv.isPassword = False
        Me.txt_cvv.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cvv.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cvv.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cvv.LineThickness = 3
        Me.txt_cvv.Location = New System.Drawing.Point(300, 328)
        Me.txt_cvv.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cvv.Name = "txt_cvv"
        Me.txt_cvv.Size = New System.Drawing.Size(65, 21)
        Me.txt_cvv.TabIndex = 31
        Me.txt_cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_finalizar
        '
        Me.btn_finalizar.ActiveBorderThickness = 1
        Me.btn_finalizar.ActiveCornerRadius = 20
        Me.btn_finalizar.ActiveFillColor = System.Drawing.Color.Orange
        Me.btn_finalizar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_finalizar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_finalizar.BackColor = System.Drawing.Color.White
        Me.btn_finalizar.BackgroundImage = CType(resources.GetObject("btn_finalizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_finalizar.ButtonText = "Finalizar"
        Me.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.Color.Orange
        Me.btn_finalizar.IdleBorderThickness = 1
        Me.btn_finalizar.IdleCornerRadius = 20
        Me.btn_finalizar.IdleFillColor = System.Drawing.Color.White
        Me.btn_finalizar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_finalizar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_finalizar.Location = New System.Drawing.Point(101, 400)
        Me.btn_finalizar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(181, 41)
        Me.btn_finalizar.TabIndex = 26
        Me.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards1.Controls.Add(Me.txt_datanasc)
        Me.BunifuCards1.Controls.Add(Me.txt_cvv)
        Me.BunifuCards1.Controls.Add(Me.Label16)
        Me.BunifuCards1.Controls.Add(Me.check_macho)
        Me.BunifuCards1.Controls.Add(Me.Label15)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.check_femea)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.btn_finalizar)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.check_plano3)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.Controls.Add(Me.check_plano2)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.check_plano1)
        Me.BunifuCards1.Controls.Add(Me.txt_nomepet)
        Me.BunifuCards1.Controls.Add(Me.txt_raca)
        Me.BunifuCards1.Controls.Add(Me.Label14)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.txt_validade)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.txt_numcartao)
        Me.BunifuCards1.Controls.Add(Me.txt_nome)
        Me.BunifuCards1.Controls.Add(Me.Label13)
        Me.BunifuCards1.Controls.Add(Me.Label8)
        Me.BunifuCards1.Controls.Add(Me.Label12)
        Me.BunifuCards1.Controls.Add(Me.txt_contato)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.Label10)
        Me.BunifuCards1.Controls.Add(Me.txt_cpf)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(411, 455)
        Me.BunifuCards1.TabIndex = 32
        '
        'txt_datanasc
        '
        Me.txt_datanasc.BackColor = System.Drawing.Color.Orange
        Me.txt_datanasc.BorderRadius = 0
        Me.txt_datanasc.ForeColor = System.Drawing.Color.White
        Me.txt_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_datanasc.FormatCustom = Nothing
        Me.txt_datanasc.Location = New System.Drawing.Point(213, 120)
        Me.txt_datanasc.Name = "txt_datanasc"
        Me.txt_datanasc.Size = New System.Drawing.Size(178, 22)
        Me.txt_datanasc.TabIndex = 32
        Me.txt_datanasc.Value = New Date(2023, 5, 21, 0, 0, 0, 0)
        '
        'matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(411, 455)
        Me.Controls.Add(Me.BunifuCards1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "matricula"
        Me.Text = "matricula"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nomepet As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_raca As ns1.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome As ns1.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_contato As ns1.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_numcartao As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_validade As ns1.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents check_plano1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents check_plano2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents check_plano3 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents btn_finalizar As ns1.BunifuThinButton2
    Friend WithEvents check_femea As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents check_macho As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents txt_cvv As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuCards1 As ns1.BunifuCards
    Friend WithEvents txt_datanasc As ns1.BunifuDatepicker
End Class
