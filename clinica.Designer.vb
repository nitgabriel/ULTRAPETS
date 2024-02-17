<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clinica
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
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clinica))
        Dim Animation4 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.painel_cancelar = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.painel_adquirir = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Label()
        Me.txt_nasc = New ns1.BunifuDatepicker()
        Me.txt_cvvclin = New ns1.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.check_male = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.check_fem = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_adquirir = New ns1.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_namepet = New ns1.BunifuMaterialTextbox()
        Me.txt_race = New ns1.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_val = New ns1.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_numc = New ns1.BunifuMaterialTextbox()
        Me.txt_name = New ns1.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_ctt = New ns1.BunifuMaterialTextbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cpfclin = New ns1.BunifuMaterialTextbox()
        Me.btn_fechar = New System.Windows.Forms.Label()
        Me.btn_cancelar = New ns1.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_petcanc = New ns1.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nomecanc = New ns1.BunifuMaterialTextbox()
        Me.txt_cpfcan = New ns1.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.painel_mostrar = New ns1.BunifuCards()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.animar = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.sair_clinica = New System.Windows.Forms.Label()
        Me.animar2 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.animar3 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.animar4 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.painel_cancelar.SuspendLayout()
        Me.painel_adquirir.SuspendLayout()
        Me.SuspendLayout()
        '
        'painel_cancelar
        '
        Me.painel_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.painel_cancelar.Controls.Add(Me.painel_adquirir)
        Me.painel_cancelar.Controls.Add(Me.btn_fechar)
        Me.painel_cancelar.Controls.Add(Me.btn_cancelar)
        Me.painel_cancelar.Controls.Add(Me.Label1)
        Me.painel_cancelar.Controls.Add(Me.txt_petcanc)
        Me.painel_cancelar.Controls.Add(Me.Label2)
        Me.painel_cancelar.Controls.Add(Me.Label6)
        Me.painel_cancelar.Controls.Add(Me.Label7)
        Me.painel_cancelar.Controls.Add(Me.txt_nomecanc)
        Me.painel_cancelar.Controls.Add(Me.txt_cpfcan)
        Me.painel_cancelar.Controls.Add(Me.Label9)
        Me.animar3.SetDecoration(Me.painel_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.painel_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.painel_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.painel_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.painel_cancelar.GradientColor1 = System.Drawing.Color.White
        Me.painel_cancelar.GradientColor2 = System.Drawing.Color.White
        Me.painel_cancelar.Location = New System.Drawing.Point(352, 0)
        Me.painel_cancelar.Name = "painel_cancelar"
        Me.painel_cancelar.Size = New System.Drawing.Size(448, 443)
        Me.painel_cancelar.TabIndex = 0
        '
        'painel_adquirir
        '
        Me.painel_adquirir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.painel_adquirir.Controls.Add(Me.btn_close)
        Me.painel_adquirir.Controls.Add(Me.txt_nasc)
        Me.painel_adquirir.Controls.Add(Me.txt_cvvclin)
        Me.painel_adquirir.Controls.Add(Me.Label16)
        Me.painel_adquirir.Controls.Add(Me.check_male)
        Me.painel_adquirir.Controls.Add(Me.Label15)
        Me.painel_adquirir.Controls.Add(Me.Label3)
        Me.painel_adquirir.Controls.Add(Me.check_fem)
        Me.painel_adquirir.Controls.Add(Me.Label4)
        Me.painel_adquirir.Controls.Add(Me.btn_adquirir)
        Me.painel_adquirir.Controls.Add(Me.Label5)
        Me.painel_adquirir.Controls.Add(Me.Label8)
        Me.painel_adquirir.Controls.Add(Me.Label10)
        Me.painel_adquirir.Controls.Add(Me.txt_namepet)
        Me.painel_adquirir.Controls.Add(Me.txt_race)
        Me.painel_adquirir.Controls.Add(Me.Label11)
        Me.painel_adquirir.Controls.Add(Me.txt_val)
        Me.painel_adquirir.Controls.Add(Me.Label12)
        Me.painel_adquirir.Controls.Add(Me.txt_numc)
        Me.painel_adquirir.Controls.Add(Me.txt_name)
        Me.painel_adquirir.Controls.Add(Me.Label13)
        Me.painel_adquirir.Controls.Add(Me.Label17)
        Me.painel_adquirir.Controls.Add(Me.Label18)
        Me.painel_adquirir.Controls.Add(Me.txt_ctt)
        Me.painel_adquirir.Controls.Add(Me.Label19)
        Me.painel_adquirir.Controls.Add(Me.Label20)
        Me.painel_adquirir.Controls.Add(Me.Label21)
        Me.painel_adquirir.Controls.Add(Me.txt_cpfclin)
        Me.animar4.SetDecoration(Me.painel_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.painel_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.painel_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.painel_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.painel_adquirir.Location = New System.Drawing.Point(0, 0)
        Me.painel_adquirir.Name = "painel_adquirir"
        Me.painel_adquirir.Size = New System.Drawing.Size(448, 443)
        Me.painel_adquirir.TabIndex = 64
        '
        'btn_close
        '
        Me.btn_close.AutoSize = True
        Me.animar3.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.btn_close.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(419, 7)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(17, 18)
        Me.btn_close.TabIndex = 64
        Me.btn_close.Text = "X"
        '
        'txt_nasc
        '
        Me.txt_nasc.BackColor = System.Drawing.Color.Orange
        Me.txt_nasc.BorderRadius = 0
        Me.animar4.SetDecoration(Me.txt_nasc, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_nasc, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_nasc, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_nasc, Guna.UI.Animation.DecorationType.None)
        Me.txt_nasc.ForeColor = System.Drawing.Color.White
        Me.txt_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_nasc.FormatCustom = Nothing
        Me.txt_nasc.Location = New System.Drawing.Point(235, 115)
        Me.txt_nasc.Name = "txt_nasc"
        Me.txt_nasc.Size = New System.Drawing.Size(178, 22)
        Me.txt_nasc.TabIndex = 63
        Me.txt_nasc.Value = New Date(2023, 5, 26, 0, 0, 0, 0)
        '
        'txt_cvvclin
        '
        Me.txt_cvvclin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_cvvclin, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_cvvclin, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_cvvclin, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_cvvclin, Guna.UI.Animation.DecorationType.None)
        Me.txt_cvvclin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cvvclin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cvvclin.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cvvclin.HintText = ""
        Me.txt_cvvclin.isPassword = False
        Me.txt_cvvclin.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cvvclin.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cvvclin.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cvvclin.LineThickness = 3
        Me.txt_cvvclin.Location = New System.Drawing.Point(322, 323)
        Me.txt_cvvclin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cvvclin.Name = "txt_cvvclin"
        Me.txt_cvvclin.Size = New System.Drawing.Size(65, 21)
        Me.txt_cvvclin.TabIndex = 62
        Me.txt_cvvclin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.animar3.SetDecoration(Me.Label16, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label16, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label16, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label16, Guna.UI.Animation.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(333, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 14)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Macho"
        '
        'check_male
        '
        Me.check_male.BaseColor = System.Drawing.Color.White
        Me.check_male.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_male.CheckedOnColor = System.Drawing.Color.Orange
        Me.animar3.SetDecoration(Me.check_male, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.check_male, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.check_male, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.check_male, Guna.UI.Animation.DecorationType.None)
        Me.check_male.FillColor = System.Drawing.Color.White
        Me.check_male.Location = New System.Drawing.Point(310, 58)
        Me.check_male.Name = "check_male"
        Me.check_male.Size = New System.Drawing.Size(20, 20)
        Me.check_male.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.animar3.SetDecoration(Me.Label15, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label15, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label15, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label15, Guna.UI.Animation.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(258, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 14)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Fêmea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.animar3.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Sobre o Pet"
        '
        'check_fem
        '
        Me.check_fem.BaseColor = System.Drawing.Color.White
        Me.check_fem.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_fem.CheckedOnColor = System.Drawing.Color.Orange
        Me.animar3.SetDecoration(Me.check_fem, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.check_fem, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.check_fem, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.check_fem, Guna.UI.Animation.DecorationType.None)
        Me.check_fem.FillColor = System.Drawing.Color.White
        Me.check_fem.Location = New System.Drawing.Point(235, 58)
        Me.check_fem.Name = "check_fem"
        Me.check_fem.Size = New System.Drawing.Size(20, 20)
        Me.check_fem.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.animar3.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Nome"
        '
        'btn_adquirir
        '
        Me.btn_adquirir.ActiveBorderThickness = 1
        Me.btn_adquirir.ActiveCornerRadius = 20
        Me.btn_adquirir.ActiveFillColor = System.Drawing.Color.Orange
        Me.btn_adquirir.ActiveForecolor = System.Drawing.Color.White
        Me.btn_adquirir.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_adquirir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_adquirir.BackgroundImage = CType(resources.GetObject("btn_adquirir.BackgroundImage"), System.Drawing.Image)
        Me.btn_adquirir.ButtonText = "Adquirir"
        Me.btn_adquirir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animar3.SetDecoration(Me.btn_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.btn_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.btn_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.btn_adquirir, Guna.UI.Animation.DecorationType.None)
        Me.btn_adquirir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adquirir.ForeColor = System.Drawing.Color.Orange
        Me.btn_adquirir.IdleBorderThickness = 1
        Me.btn_adquirir.IdleCornerRadius = 20
        Me.btn_adquirir.IdleFillColor = System.Drawing.Color.White
        Me.btn_adquirir.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_adquirir.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_adquirir.Location = New System.Drawing.Point(138, 370)
        Me.btn_adquirir.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_adquirir.Name = "btn_adquirir"
        Me.btn_adquirir.Size = New System.Drawing.Size(181, 41)
        Me.btn_adquirir.TabIndex = 57
        Me.btn_adquirir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.animar3.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Raça"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.animar3.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(232, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Gênero"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.animar3.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(232, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Data de Nascimento"
        '
        'txt_namepet
        '
        Me.txt_namepet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_namepet, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_namepet, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_namepet, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_namepet, Guna.UI.Animation.DecorationType.None)
        Me.txt_namepet.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_namepet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_namepet.HintForeColor = System.Drawing.Color.Empty
        Me.txt_namepet.HintText = ""
        Me.txt_namepet.isPassword = False
        Me.txt_namepet.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_namepet.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_namepet.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_namepet.LineThickness = 3
        Me.txt_namepet.Location = New System.Drawing.Point(37, 51)
        Me.txt_namepet.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_namepet.Name = "txt_namepet"
        Me.txt_namepet.Size = New System.Drawing.Size(177, 30)
        Me.txt_namepet.TabIndex = 38
        Me.txt_namepet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_race
        '
        Me.txt_race.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_race, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_race, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_race, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_race, Guna.UI.Animation.DecorationType.None)
        Me.txt_race.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_race.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_race.HintForeColor = System.Drawing.Color.Empty
        Me.txt_race.HintText = ""
        Me.txt_race.isPassword = False
        Me.txt_race.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_race.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_race.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_race.LineThickness = 3
        Me.txt_race.Location = New System.Drawing.Point(37, 107)
        Me.txt_race.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_race.Name = "txt_race"
        Me.txt_race.Size = New System.Drawing.Size(177, 30)
        Me.txt_race.TabIndex = 39
        Me.txt_race.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.animar3.SetDecoration(Me.Label11, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label11, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label11, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label11, Guna.UI.Animation.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(148, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 23)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Sobre o Proprietário"
        '
        'txt_val
        '
        Me.txt_val.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_val, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_val, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_val, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_val, Guna.UI.Animation.DecorationType.None)
        Me.txt_val.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_val.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_val.HintForeColor = System.Drawing.Color.Empty
        Me.txt_val.HintText = ""
        Me.txt_val.isPassword = False
        Me.txt_val.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_val.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_val.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_val.LineThickness = 3
        Me.txt_val.Location = New System.Drawing.Point(235, 323)
        Me.txt_val.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_val.Name = "txt_val"
        Me.txt_val.Size = New System.Drawing.Size(65, 21)
        Me.txt_val.TabIndex = 52
        Me.txt_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.animar3.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Nome Completo"
        '
        'txt_numc
        '
        Me.txt_numc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_numc, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_numc, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_numc, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_numc, Guna.UI.Animation.DecorationType.None)
        Me.txt_numc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_numc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_numc.HintForeColor = System.Drawing.Color.Empty
        Me.txt_numc.HintText = ""
        Me.txt_numc.isPassword = False
        Me.txt_numc.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_numc.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_numc.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_numc.LineThickness = 3
        Me.txt_numc.Location = New System.Drawing.Point(37, 323)
        Me.txt_numc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numc.Name = "txt_numc"
        Me.txt_numc.Size = New System.Drawing.Size(177, 21)
        Me.txt_numc.TabIndex = 51
        Me.txt_numc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_name, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_name, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_name, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_name, Guna.UI.Animation.DecorationType.None)
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_name.HintForeColor = System.Drawing.Color.Empty
        Me.txt_name.HintText = ""
        Me.txt_name.isPassword = False
        Me.txt_name.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_name.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_name.LineThickness = 3
        Me.txt_name.Location = New System.Drawing.Point(37, 186)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(376, 30)
        Me.txt_name.TabIndex = 42
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.animar3.SetDecoration(Me.Label13, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label13, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label13, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label13, Guna.UI.Animation.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(319, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "CVV"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.animar3.SetDecoration(Me.Label17, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label17, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label17, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label17, Guna.UI.Animation.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 220)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 18)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Contato Telefônico"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.animar3.SetDecoration(Me.Label18, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label18, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label18, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label18, Guna.UI.Animation.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(232, 303)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Validade"
        '
        'txt_ctt
        '
        Me.txt_ctt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_ctt, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_ctt, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_ctt, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_ctt, Guna.UI.Animation.DecorationType.None)
        Me.txt_ctt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_ctt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_ctt.HintForeColor = System.Drawing.Color.Empty
        Me.txt_ctt.HintText = ""
        Me.txt_ctt.isPassword = False
        Me.txt_ctt.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_ctt.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_ctt.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_ctt.LineThickness = 3
        Me.txt_ctt.Location = New System.Drawing.Point(37, 242)
        Me.txt_ctt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ctt.Name = "txt_ctt"
        Me.txt_ctt.Size = New System.Drawing.Size(177, 30)
        Me.txt_ctt.TabIndex = 44
        Me.txt_ctt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.animar3.SetDecoration(Me.Label19, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label19, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label19, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label19, Guna.UI.Animation.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 303)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 16)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Número do Cartão"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.animar3.SetDecoration(Me.Label20, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label20, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label20, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label20, Guna.UI.Animation.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(232, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 18)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "CPF"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.animar3.SetDecoration(Me.Label21, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label21, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label21, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label21, Guna.UI.Animation.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(136, 279)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(187, 23)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Dados de Pagamento"
        '
        'txt_cpfclin
        '
        Me.txt_cpfclin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_cpfclin, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_cpfclin, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_cpfclin, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_cpfclin, Guna.UI.Animation.DecorationType.None)
        Me.txt_cpfclin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cpfclin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpfclin.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpfclin.HintText = ""
        Me.txt_cpfclin.isPassword = False
        Me.txt_cpfclin.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cpfclin.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpfclin.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cpfclin.LineThickness = 3
        Me.txt_cpfclin.Location = New System.Drawing.Point(235, 242)
        Me.txt_cpfclin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpfclin.Name = "txt_cpfclin"
        Me.txt_cpfclin.Size = New System.Drawing.Size(178, 30)
        Me.txt_cpfclin.TabIndex = 46
        Me.txt_cpfclin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_fechar
        '
        Me.btn_fechar.AutoSize = True
        Me.animar3.SetDecoration(Me.btn_fechar, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.btn_fechar, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.btn_fechar, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.btn_fechar, Guna.UI.Animation.DecorationType.None)
        Me.btn_fechar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.Location = New System.Drawing.Point(419, 9)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(17, 18)
        Me.btn_fechar.TabIndex = 65
        Me.btn_fechar.Text = "X"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.ActiveBorderThickness = 1
        Me.btn_cancelar.ActiveCornerRadius = 20
        Me.btn_cancelar.ActiveFillColor = System.Drawing.Color.Gold
        Me.btn_cancelar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancelar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.ButtonText = "Cancelar"
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animar3.SetDecoration(Me.btn_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.btn_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.btn_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.btn_cancelar, Guna.UI.Animation.DecorationType.None)
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Orange
        Me.btn_cancelar.IdleBorderThickness = 1
        Me.btn_cancelar.IdleCornerRadius = 20
        Me.btn_cancelar.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancelar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_cancelar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_cancelar.Location = New System.Drawing.Point(142, 362)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(158, 41)
        Me.btn_cancelar.TabIndex = 67
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.animar3.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Que pena que você vai nos deixar!"
        '
        'txt_petcanc
        '
        Me.txt_petcanc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_petcanc, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_petcanc, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_petcanc, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_petcanc, Guna.UI.Animation.DecorationType.None)
        Me.txt_petcanc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_petcanc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_petcanc.HintForeColor = System.Drawing.Color.Empty
        Me.txt_petcanc.HintText = ""
        Me.txt_petcanc.isPassword = False
        Me.txt_petcanc.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_petcanc.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_petcanc.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_petcanc.LineThickness = 3
        Me.txt_petcanc.Location = New System.Drawing.Point(231, 274)
        Me.txt_petcanc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_petcanc.Name = "txt_petcanc"
        Me.txt_petcanc.Size = New System.Drawing.Size(161, 30)
        Me.txt_petcanc.TabIndex = 65
        Me.txt_petcanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.animar3.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nome do Pet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.animar3.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Informe os dados abaixo para cancelar a assinatura."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.animar3.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Nome Completo"
        '
        'txt_nomecanc
        '
        Me.txt_nomecanc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_nomecanc, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_nomecanc, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_nomecanc, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_nomecanc, Guna.UI.Animation.DecorationType.None)
        Me.txt_nomecanc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nomecanc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nomecanc.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nomecanc.HintText = ""
        Me.txt_nomecanc.isPassword = False
        Me.txt_nomecanc.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_nomecanc.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nomecanc.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_nomecanc.LineThickness = 3
        Me.txt_nomecanc.Location = New System.Drawing.Point(54, 218)
        Me.txt_nomecanc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomecanc.Name = "txt_nomecanc"
        Me.txt_nomecanc.Size = New System.Drawing.Size(338, 30)
        Me.txt_nomecanc.TabIndex = 62
        Me.txt_nomecanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cpfcan
        '
        Me.txt_cpfcan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animar4.SetDecoration(Me.txt_cpfcan, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.txt_cpfcan, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.txt_cpfcan, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.txt_cpfcan, Guna.UI.Animation.DecorationType.None)
        Me.txt_cpfcan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cpfcan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpfcan.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpfcan.HintText = ""
        Me.txt_cpfcan.isPassword = False
        Me.txt_cpfcan.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cpfcan.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpfcan.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cpfcan.LineThickness = 3
        Me.txt_cpfcan.Location = New System.Drawing.Point(54, 274)
        Me.txt_cpfcan.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpfcan.Name = "txt_cpfcan"
        Me.txt_cpfcan.Size = New System.Drawing.Size(163, 30)
        Me.txt_cpfcan.TabIndex = 64
        Me.txt_cpfcan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.animar3.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "CPF"
        '
        'painel_mostrar
        '
        Me.painel_mostrar.BackColor = System.Drawing.Color.White
        Me.painel_mostrar.BackgroundImage = CType(resources.GetObject("painel_mostrar.BackgroundImage"), System.Drawing.Image)
        Me.painel_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.painel_mostrar.BorderRadius = 5
        Me.painel_mostrar.BottomSahddow = True
        Me.painel_mostrar.color = System.Drawing.Color.Transparent
        Me.animar4.SetDecoration(Me.painel_mostrar, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.painel_mostrar, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.painel_mostrar, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.painel_mostrar, Guna.UI.Animation.DecorationType.None)
        Me.painel_mostrar.LeftSahddow = False
        Me.painel_mostrar.Location = New System.Drawing.Point(352, 0)
        Me.painel_mostrar.Name = "painel_mostrar"
        Me.painel_mostrar.RightSahddow = True
        Me.painel_mostrar.ShadowDepth = 20
        Me.painel_mostrar.Size = New System.Drawing.Size(448, 443)
        Me.painel_mostrar.TabIndex = 1
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.animar4.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.DarkOrange
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(-2, 212)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Yellow
        Me.GunaButton1.Size = New System.Drawing.Size(354, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "CANCELAR PLANO"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.animar4.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.DarkOrange
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(-2, 160)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Yellow
        Me.GunaButton2.Size = New System.Drawing.Size(354, 42)
        Me.GunaButton2.TabIndex = 3
        Me.GunaButton2.Text = "ADQUIRIR PLANO"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'animar
        '
        Me.animar.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.animar.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.animar.DefaultAnimation = Animation2
        '
        'sair_clinica
        '
        Me.sair_clinica.AutoSize = True
        Me.sair_clinica.BackColor = System.Drawing.Color.Transparent
        Me.animar3.SetDecoration(Me.sair_clinica, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me.sair_clinica, Guna.UI.Animation.DecorationType.None)
        Me.animar2.SetDecoration(Me.sair_clinica, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me.sair_clinica, Guna.UI.Animation.DecorationType.None)
        Me.sair_clinica.Location = New System.Drawing.Point(4, 424)
        Me.sair_clinica.Name = "sair_clinica"
        Me.sair_clinica.Size = New System.Drawing.Size(111, 13)
        Me.sair_clinica.TabIndex = 4
        Me.sair_clinica.Text = "↩  Voltar para o menu"
        '
        'animar2
        '
        Me.animar2.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.animar2.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.animar2.DefaultAnimation = Animation3
        '
        'animar3
        '
        Me.animar3.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.animar3.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.animar3.DefaultAnimation = Animation1
        '
        'animar4
        '
        Me.animar4.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.animar4.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.animar4.DefaultAnimation = Animation4
        '
        'clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sair_clinica)
        Me.Controls.Add(Me.painel_mostrar)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.painel_cancelar)
        Me.animar2.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.animar.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.animar4.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.animar3.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Name = "clinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLÍNICA VET"
        Me.painel_cancelar.ResumeLayout(False)
        Me.painel_cancelar.PerformLayout()
        Me.painel_adquirir.ResumeLayout(False)
        Me.painel_adquirir.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents painel_cancelar As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_petcanc As ns1.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nomecanc As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cpfcan As ns1.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cancelar As ns1.BunifuThinButton2
    Friend WithEvents txt_nasc As ns1.BunifuDatepicker
    Friend WithEvents txt_cvvclin As ns1.BunifuMaterialTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents check_male As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents check_fem As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_adquirir As ns1.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_namepet As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_race As ns1.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_val As ns1.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_numc As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_name As ns1.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_ctt As ns1.BunifuMaterialTextbox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cpfclin As ns1.BunifuMaterialTextbox
    Friend WithEvents painel_adquirir As Panel
    Friend WithEvents painel_mostrar As ns1.BunifuCards
    Friend WithEvents animar As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents animar2 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents btn_close As Label
    Friend WithEvents btn_fechar As Label
    Friend WithEvents animar3 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents animar4 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents sair_clinica As Label
End Class
