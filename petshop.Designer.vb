<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class petshop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petshop))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_ufcarrinho = New ns1.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cidadecarrinho = New ns1.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.check_delivery = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.check_buscar = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comp = New ns1.BunifuMaterialTextbox()
        Me.txt_cep = New ns1.BunifuMaterialTextbox()
        Me.txt_numcasa = New ns1.BunifuMaterialTextbox()
        Me.txt_bairro = New ns1.BunifuMaterialTextbox()
        Me.txt_rua = New ns1.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_comprar = New ns1.BunifuThinButton2()
        Me.conf_cvv = New ns1.BunifuMaterialTextbox()
        Me.conf_validade = New ns1.BunifuMaterialTextbox()
        Me.conf_cartao = New ns1.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_carrinho = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.sair_petshop = New System.Windows.Forms.Label()
        Me.mostrar_form = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_acessorios = New Guna.UI.WinForms.GunaButton()
        Me.btn_brinquedos = New Guna.UI.WinForms.GunaButton()
        Me.btn_racoes = New Guna.UI.WinForms.GunaButton()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txt_ufcarrinho)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_cidadecarrinho)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.check_delivery)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.check_buscar)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_comp)
        Me.TabPage2.Controls.Add(Me.txt_cep)
        Me.TabPage2.Controls.Add(Me.txt_numcasa)
        Me.TabPage2.Controls.Add(Me.txt_bairro)
        Me.TabPage2.Controls.Add(Me.txt_rua)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btn_comprar)
        Me.TabPage2.Controls.Add(Me.conf_cvv)
        Me.TabPage2.Controls.Add(Me.conf_validade)
        Me.TabPage2.Controls.Add(Me.conf_cartao)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.dgv_carrinho)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CARRINHO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(454, 305)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Estado"
        '
        'txt_ufcarrinho
        '
        Me.txt_ufcarrinho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ufcarrinho.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_ufcarrinho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_ufcarrinho.HintForeColor = System.Drawing.Color.Empty
        Me.txt_ufcarrinho.HintText = "UF"
        Me.txt_ufcarrinho.isPassword = False
        Me.txt_ufcarrinho.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_ufcarrinho.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_ufcarrinho.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_ufcarrinho.LineThickness = 3
        Me.txt_ufcarrinho.Location = New System.Drawing.Point(457, 325)
        Me.txt_ufcarrinho.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ufcarrinho.Name = "txt_ufcarrinho"
        Me.txt_ufcarrinho.Size = New System.Drawing.Size(44, 21)
        Me.txt_ufcarrinho.TabIndex = 62
        Me.txt_ufcarrinho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(332, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Cidade"
        '
        'txt_cidadecarrinho
        '
        Me.txt_cidadecarrinho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cidadecarrinho.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cidadecarrinho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cidadecarrinho.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cidadecarrinho.HintText = "Miaucópolis"
        Me.txt_cidadecarrinho.isPassword = False
        Me.txt_cidadecarrinho.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cidadecarrinho.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cidadecarrinho.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cidadecarrinho.LineThickness = 3
        Me.txt_cidadecarrinho.Location = New System.Drawing.Point(334, 325)
        Me.txt_cidadecarrinho.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cidadecarrinho.Name = "txt_cidadecarrinho"
        Me.txt_cidadecarrinho.Size = New System.Drawing.Size(109, 21)
        Me.txt_cidadecarrinho.TabIndex = 60
        Me.txt_cidadecarrinho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Complemento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Número"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "CEP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Bairro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Rua"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(548, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 14)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Delivery"
        '
        'check_delivery
        '
        Me.check_delivery.BaseColor = System.Drawing.Color.White
        Me.check_delivery.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_delivery.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_delivery.FillColor = System.Drawing.Color.White
        Me.check_delivery.Location = New System.Drawing.Point(522, 264)
        Me.check_delivery.Name = "check_delivery"
        Me.check_delivery.Size = New System.Drawing.Size(20, 20)
        Me.check_delivery.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(411, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 14)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Buscar na unidade"
        '
        'check_buscar
        '
        Me.check_buscar.BaseColor = System.Drawing.Color.White
        Me.check_buscar.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_buscar.CheckedOnColor = System.Drawing.Color.Orange
        Me.check_buscar.FillColor = System.Drawing.Color.White
        Me.check_buscar.Location = New System.Drawing.Point(388, 266)
        Me.check_buscar.Name = "check_buscar"
        Me.check_buscar.Size = New System.Drawing.Size(20, 20)
        Me.check_buscar.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Forma de Entrega"
        '
        'txt_comp
        '
        Me.txt_comp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_comp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_comp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_comp.HintForeColor = System.Drawing.Color.Empty
        Me.txt_comp.HintText = "Casa dos Ronrons"
        Me.txt_comp.isPassword = False
        Me.txt_comp.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_comp.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_comp.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_comp.LineThickness = 3
        Me.txt_comp.Location = New System.Drawing.Point(74, 373)
        Me.txt_comp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(134, 21)
        Me.txt_comp.TabIndex = 49
        Me.txt_comp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cep
        '
        Me.txt_cep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cep.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cep.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cep.HintText = "00000-000"
        Me.txt_cep.isPassword = False
        Me.txt_cep.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cep.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cep.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cep.LineThickness = 3
        Me.txt_cep.Location = New System.Drawing.Point(518, 325)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(80, 21)
        Me.txt_cep.TabIndex = 48
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_numcasa
        '
        Me.txt_numcasa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_numcasa.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_numcasa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_numcasa.HintForeColor = System.Drawing.Color.Empty
        Me.txt_numcasa.HintText = "123"
        Me.txt_numcasa.isPassword = False
        Me.txt_numcasa.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_numcasa.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_numcasa.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_numcasa.LineThickness = 3
        Me.txt_numcasa.Location = New System.Drawing.Point(15, 373)
        Me.txt_numcasa.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numcasa.Name = "txt_numcasa"
        Me.txt_numcasa.Size = New System.Drawing.Size(51, 21)
        Me.txt_numcasa.TabIndex = 47
        Me.txt_numcasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_bairro
        '
        Me.txt_bairro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bairro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_bairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_bairro.HintForeColor = System.Drawing.Color.Empty
        Me.txt_bairro.HintText = "Ronroville"
        Me.txt_bairro.isPassword = False
        Me.txt_bairro.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_bairro.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_bairro.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_bairro.LineThickness = 3
        Me.txt_bairro.Location = New System.Drawing.Point(211, 325)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(107, 21)
        Me.txt_bairro.TabIndex = 46
        Me.txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_rua
        '
        Me.txt_rua.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rua.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_rua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rua.HintForeColor = System.Drawing.Color.Empty
        Me.txt_rua.HintText = "Rua dos Sussurros Felinos"
        Me.txt_rua.isPassword = False
        Me.txt_rua.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_rua.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_rua.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_rua.LineThickness = 3
        Me.txt_rua.Location = New System.Drawing.Point(15, 325)
        Me.txt_rua.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rua.Name = "txt_rua"
        Me.txt_rua.Size = New System.Drawing.Size(177, 21)
        Me.txt_rua.TabIndex = 45
        Me.txt_rua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Caso queira delivery, informe o endereço da entrega:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Informe os dados para finalizar a compra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CONFIRA SEU CARRINHO AQUI:"
        '
        'btn_comprar
        '
        Me.btn_comprar.ActiveBorderThickness = 1
        Me.btn_comprar.ActiveCornerRadius = 20
        Me.btn_comprar.ActiveFillColor = System.Drawing.Color.Orange
        Me.btn_comprar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_comprar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_comprar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.ButtonText = "Finalizar Compra"
        Me.btn_comprar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_comprar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprar.ForeColor = System.Drawing.Color.Orange
        Me.btn_comprar.IdleBorderThickness = 1
        Me.btn_comprar.IdleCornerRadius = 20
        Me.btn_comprar.IdleFillColor = System.Drawing.Color.White
        Me.btn_comprar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_comprar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_comprar.Location = New System.Drawing.Point(258, 394)
        Me.btn_comprar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(181, 41)
        Me.btn_comprar.TabIndex = 38
        Me.btn_comprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'conf_cvv
        '
        Me.conf_cvv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.conf_cvv.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.conf_cvv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.conf_cvv.HintForeColor = System.Drawing.Color.Empty
        Me.conf_cvv.HintText = ""
        Me.conf_cvv.isPassword = False
        Me.conf_cvv.LineFocusedColor = System.Drawing.Color.Orange
        Me.conf_cvv.LineIdleColor = System.Drawing.Color.Gray
        Me.conf_cvv.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.conf_cvv.LineThickness = 3
        Me.conf_cvv.Location = New System.Drawing.Point(298, 263)
        Me.conf_cvv.Margin = New System.Windows.Forms.Padding(4)
        Me.conf_cvv.Name = "conf_cvv"
        Me.conf_cvv.Size = New System.Drawing.Size(65, 21)
        Me.conf_cvv.TabIndex = 37
        Me.conf_cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'conf_validade
        '
        Me.conf_validade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.conf_validade.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.conf_validade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.conf_validade.HintForeColor = System.Drawing.Color.Empty
        Me.conf_validade.HintText = ""
        Me.conf_validade.isPassword = False
        Me.conf_validade.LineFocusedColor = System.Drawing.Color.Orange
        Me.conf_validade.LineIdleColor = System.Drawing.Color.Gray
        Me.conf_validade.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.conf_validade.LineThickness = 3
        Me.conf_validade.Location = New System.Drawing.Point(211, 263)
        Me.conf_validade.Margin = New System.Windows.Forms.Padding(4)
        Me.conf_validade.Name = "conf_validade"
        Me.conf_validade.Size = New System.Drawing.Size(65, 21)
        Me.conf_validade.TabIndex = 36
        Me.conf_validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'conf_cartao
        '
        Me.conf_cartao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.conf_cartao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.conf_cartao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.conf_cartao.HintForeColor = System.Drawing.Color.Empty
        Me.conf_cartao.HintText = ""
        Me.conf_cartao.isPassword = False
        Me.conf_cartao.LineFocusedColor = System.Drawing.Color.Orange
        Me.conf_cartao.LineIdleColor = System.Drawing.Color.Gray
        Me.conf_cartao.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.conf_cartao.LineThickness = 3
        Me.conf_cartao.Location = New System.Drawing.Point(13, 263)
        Me.conf_cartao.Margin = New System.Windows.Forms.Padding(4)
        Me.conf_cartao.Name = "conf_cartao"
        Me.conf_cartao.Size = New System.Drawing.Size(177, 21)
        Me.conf_cartao.TabIndex = 35
        Me.conf_cartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(295, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "CVV"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(208, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Validade"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Número do Cartão"
        '
        'dgv_carrinho
        '
        Me.dgv_carrinho.AllowUserToAddRows = False
        Me.dgv_carrinho.AllowUserToDeleteRows = False
        Me.dgv_carrinho.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrinho.GridColor = System.Drawing.Color.Gray
        Me.dgv_carrinho.Location = New System.Drawing.Point(12, 22)
        Me.dgv_carrinho.Name = "dgv_carrinho"
        Me.dgv_carrinho.ReadOnly = True
        Me.dgv_carrinho.Size = New System.Drawing.Size(781, 198)
        Me.dgv_carrinho.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 469)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.sair_petshop)
        Me.TabPage1.Controls.Add(Me.mostrar_form)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PRODUTOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'sair_petshop
        '
        Me.sair_petshop.AutoSize = True
        Me.sair_petshop.Location = New System.Drawing.Point(6, 419)
        Me.sair_petshop.Name = "sair_petshop"
        Me.sair_petshop.Size = New System.Drawing.Size(111, 13)
        Me.sair_petshop.TabIndex = 0
        Me.sair_petshop.Text = "↩  Voltar para o menu"
        '
        'mostrar_form
        '
        Me.mostrar_form.Location = New System.Drawing.Point(268, 42)
        Me.mostrar_form.Name = "mostrar_form"
        Me.mostrar_form.Size = New System.Drawing.Size(533, 403)
        Me.mostrar_form.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.btn_acessorios)
        Me.Panel2.Controls.Add(Me.btn_brinquedos)
        Me.Panel2.Controls.Add(Me.btn_racoes)
        Me.Panel2.Location = New System.Drawing.Point(265, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 41)
        Me.Panel2.TabIndex = 1
        '
        'btn_acessorios
        '
        Me.btn_acessorios.AnimationHoverSpeed = 0.07!
        Me.btn_acessorios.AnimationSpeed = 0.03!
        Me.btn_acessorios.BaseColor = System.Drawing.Color.White
        Me.btn_acessorios.BorderColor = System.Drawing.Color.Black
        Me.btn_acessorios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_acessorios.FocusedColor = System.Drawing.Color.Empty
        Me.btn_acessorios.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_acessorios.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_acessorios.Image = Nothing
        Me.btn_acessorios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_acessorios.Location = New System.Drawing.Point(359, 4)
        Me.btn_acessorios.Name = "btn_acessorios"
        Me.btn_acessorios.OnHoverBaseColor = System.Drawing.Color.DarkOrange
        Me.btn_acessorios.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_acessorios.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_acessorios.OnHoverImage = Nothing
        Me.btn_acessorios.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_acessorios.Size = New System.Drawing.Size(168, 32)
        Me.btn_acessorios.TabIndex = 8
        Me.btn_acessorios.Text = "ACESSÓRIOS E DIVERSOS"
        Me.btn_acessorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_brinquedos
        '
        Me.btn_brinquedos.AnimationHoverSpeed = 0.07!
        Me.btn_brinquedos.AnimationSpeed = 0.03!
        Me.btn_brinquedos.BaseColor = System.Drawing.Color.White
        Me.btn_brinquedos.BorderColor = System.Drawing.Color.Black
        Me.btn_brinquedos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_brinquedos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_brinquedos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_brinquedos.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_brinquedos.Image = Nothing
        Me.btn_brinquedos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_brinquedos.Location = New System.Drawing.Point(186, 4)
        Me.btn_brinquedos.Name = "btn_brinquedos"
        Me.btn_brinquedos.OnHoverBaseColor = System.Drawing.Color.DarkOrange
        Me.btn_brinquedos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_brinquedos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_brinquedos.OnHoverImage = Nothing
        Me.btn_brinquedos.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_brinquedos.Size = New System.Drawing.Size(168, 32)
        Me.btn_brinquedos.TabIndex = 7
        Me.btn_brinquedos.Text = "BRINQUEDOS E COLEIRAS"
        Me.btn_brinquedos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_racoes
        '
        Me.btn_racoes.AnimationHoverSpeed = 0.07!
        Me.btn_racoes.AnimationSpeed = 0.03!
        Me.btn_racoes.BaseColor = System.Drawing.Color.White
        Me.btn_racoes.BorderColor = System.Drawing.Color.Black
        Me.btn_racoes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_racoes.FocusedColor = System.Drawing.Color.Empty
        Me.btn_racoes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_racoes.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_racoes.Image = Nothing
        Me.btn_racoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_racoes.Location = New System.Drawing.Point(12, 4)
        Me.btn_racoes.Name = "btn_racoes"
        Me.btn_racoes.OnHoverBaseColor = System.Drawing.Color.DarkOrange
        Me.btn_racoes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_racoes.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_racoes.OnHoverImage = Nothing
        Me.btn_racoes.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_racoes.Size = New System.Drawing.Size(168, 32)
        Me.btn_racoes.TabIndex = 6
        Me.btn_racoes.Text = "RAÇÕES E PETISCOS"
        Me.btn_racoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'petshop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(805, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "petshop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PETSHOP"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents mostrar_form As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_acessorios As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_brinquedos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_racoes As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgv_carrinho As DataGridView
    Friend WithEvents conf_cvv As ns1.BunifuMaterialTextbox
    Friend WithEvents conf_validade As ns1.BunifuMaterialTextbox
    Friend WithEvents conf_cartao As ns1.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_comprar As ns1.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_comp As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cep As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_numcasa As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_bairro As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_rua As ns1.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents check_delivery As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents check_buscar As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_ufcarrinho As ns1.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cidadecarrinho As ns1.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sair_petshop As Label
End Class
