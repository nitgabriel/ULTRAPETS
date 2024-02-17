<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.painel_cadastro = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_confsenha = New ns1.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cadsenha = New ns1.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Label()
        Me.btn_registrar = New Guna.UI.WinForms.GunaButton()
        Me.check_msenha = New Guna.UI.WinForms.GunaCheckBox()
        Me.txt_cademail = New ns1.BunifuMaterialTextbox()
        Me.painel_login = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cad = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btn_esqueceu = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_entrar = New Guna.UI.WinForms.GunaButton()
        Me.check_senha = New Guna.UI.WinForms.GunaCheckBox()
        Me.txt_email = New ns1.BunifuMaterialTextbox()
        Me.anima = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cadcel = New ns1.BunifuMaterialTextbox()
        Me.painel_cadastro.SuspendLayout()
        Me.painel_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'painel_cadastro
        '
        Me.painel_cadastro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.painel_cadastro.Controls.Add(Me.Label9)
        Me.painel_cadastro.Controls.Add(Me.txt_cadcel)
        Me.painel_cadastro.Controls.Add(Me.Label4)
        Me.painel_cadastro.Controls.Add(Me.txt_confsenha)
        Me.painel_cadastro.Controls.Add(Me.Label3)
        Me.painel_cadastro.Controls.Add(Me.Label2)
        Me.painel_cadastro.Controls.Add(Me.txt_cadsenha)
        Me.painel_cadastro.Controls.Add(Me.Label1)
        Me.painel_cadastro.Controls.Add(Me.btn_close)
        Me.painel_cadastro.Controls.Add(Me.btn_registrar)
        Me.painel_cadastro.Controls.Add(Me.check_msenha)
        Me.painel_cadastro.Controls.Add(Me.txt_cademail)
        Me.anima1.SetDecoration(Me.painel_cadastro, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.painel_cadastro, Guna.UI.Animation.DecorationType.None)
        Me.painel_cadastro.GradientColor1 = System.Drawing.Color.White
        Me.painel_cadastro.GradientColor2 = System.Drawing.Color.White
        Me.painel_cadastro.Location = New System.Drawing.Point(383, 0)
        Me.painel_cadastro.Name = "painel_cadastro"
        Me.painel_cadastro.Size = New System.Drawing.Size(416, 451)
        Me.painel_cadastro.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.anima.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "E-mail"
        '
        'txt_confsenha
        '
        Me.txt_confsenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_confsenha, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_confsenha, Guna.UI.Animation.DecorationType.None)
        Me.txt_confsenha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_confsenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_confsenha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_confsenha.HintText = ""
        Me.txt_confsenha.isPassword = True
        Me.txt_confsenha.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_confsenha.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_confsenha.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_confsenha.LineThickness = 3
        Me.txt_confsenha.Location = New System.Drawing.Point(32, 261)
        Me.txt_confsenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_confsenha.Name = "txt_confsenha"
        Me.txt_confsenha.Size = New System.Drawing.Size(360, 45)
        Me.txt_confsenha.TabIndex = 12
        Me.txt_confsenha.Text = "Senha"
        Me.txt_confsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.anima.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Confirmar Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.anima.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Senha"
        '
        'txt_cadsenha
        '
        Me.txt_cadsenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_cadsenha, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_cadsenha, Guna.UI.Animation.DecorationType.None)
        Me.txt_cadsenha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cadsenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cadsenha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cadsenha.HintText = ""
        Me.txt_cadsenha.isPassword = True
        Me.txt_cadsenha.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cadsenha.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cadsenha.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cadsenha.LineThickness = 3
        Me.txt_cadsenha.Location = New System.Drawing.Point(32, 191)
        Me.txt_cadsenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cadsenha.Name = "txt_cadsenha"
        Me.txt_cadsenha.Size = New System.Drawing.Size(360, 45)
        Me.txt_cadsenha.TabIndex = 8
        Me.txt_cadsenha.Text = "Senha"
        Me.txt_cadsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.anima.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Informe os dados para realizar o seu cadastro."
        '
        'btn_close
        '
        Me.btn_close.AutoSize = True
        Me.anima.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(386, 10)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(20, 20)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "X"
        '
        'btn_registrar
        '
        Me.btn_registrar.AnimationHoverSpeed = 0.07!
        Me.btn_registrar.AnimationSpeed = 0.03!
        Me.btn_registrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_registrar.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btn_registrar, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.btn_registrar, Guna.UI.Animation.DecorationType.None)
        Me.btn_registrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Image = Nothing
        Me.btn_registrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrar.Location = New System.Drawing.Point(32, 374)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.btn_registrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar.OnHoverImage = Nothing
        Me.btn_registrar.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_registrar.Size = New System.Drawing.Size(366, 50)
        Me.btn_registrar.TabIndex = 4
        Me.btn_registrar.Text = "Registrar-se"
        Me.btn_registrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'check_msenha
        '
        Me.check_msenha.BaseColor = System.Drawing.Color.White
        Me.check_msenha.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_msenha.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.anima1.SetDecoration(Me.check_msenha, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.check_msenha, Guna.UI.Animation.DecorationType.None)
        Me.check_msenha.FillColor = System.Drawing.Color.White
        Me.check_msenha.Location = New System.Drawing.Point(32, 313)
        Me.check_msenha.Name = "check_msenha"
        Me.check_msenha.Size = New System.Drawing.Size(104, 20)
        Me.check_msenha.TabIndex = 3
        Me.check_msenha.Text = "Mostrar Senha"
        '
        'txt_cademail
        '
        Me.txt_cademail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_cademail, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_cademail, Guna.UI.Animation.DecorationType.None)
        Me.txt_cademail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cademail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cademail.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cademail.HintText = "fulano@email.com"
        Me.txt_cademail.isPassword = False
        Me.txt_cademail.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cademail.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cademail.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cademail.LineThickness = 3
        Me.txt_cademail.Location = New System.Drawing.Point(32, 109)
        Me.txt_cademail.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cademail.Name = "txt_cademail"
        Me.txt_cademail.Size = New System.Drawing.Size(189, 49)
        Me.txt_cademail.TabIndex = 0
        Me.txt_cademail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'painel_login
        '
        Me.painel_login.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.painel_login.Controls.Add(Me.Label6)
        Me.painel_login.Controls.Add(Me.btn_cad)
        Me.painel_login.Controls.Add(Me.btn_esqueceu)
        Me.painel_login.Controls.Add(Me.Label5)
        Me.painel_login.Controls.Add(Me.Label7)
        Me.painel_login.Controls.Add(Me.txt_senha)
        Me.painel_login.Controls.Add(Me.Label8)
        Me.painel_login.Controls.Add(Me.btn_entrar)
        Me.painel_login.Controls.Add(Me.check_senha)
        Me.painel_login.Controls.Add(Me.txt_email)
        Me.anima1.SetDecoration(Me.painel_login, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.painel_login, Guna.UI.Animation.DecorationType.None)
        Me.painel_login.GradientColor1 = System.Drawing.Color.White
        Me.painel_login.GradientColor2 = System.Drawing.Color.White
        Me.painel_login.Location = New System.Drawing.Point(383, 0)
        Me.painel_login.Name = "painel_login"
        Me.painel_login.Size = New System.Drawing.Size(416, 451)
        Me.painel_login.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.anima.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ou"
        '
        'btn_cad
        '
        Me.btn_cad.AutoSize = True
        Me.anima1.SetDecoration(Me.btn_cad, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.btn_cad, Guna.UI.Animation.DecorationType.None)
        Me.btn_cad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cad.Location = New System.Drawing.Point(181, 408)
        Me.btn_cad.Name = "btn_cad"
        Me.btn_cad.Size = New System.Drawing.Size(69, 15)
        Me.btn_cad.TabIndex = 15
        Me.btn_cad.TabStop = True
        Me.btn_cad.Text = "Registrar-se"
        '
        'btn_esqueceu
        '
        Me.btn_esqueceu.AutoSize = True
        Me.anima1.SetDecoration(Me.btn_esqueceu, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.btn_esqueceu, Guna.UI.Animation.DecorationType.None)
        Me.btn_esqueceu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_esqueceu.Location = New System.Drawing.Point(161, 373)
        Me.btn_esqueceu.Name = "btn_esqueceu"
        Me.btn_esqueceu.Size = New System.Drawing.Size(105, 15)
        Me.btn_esqueceu.TabIndex = 14
        Me.btn_esqueceu.TabStop = True
        Me.btn_esqueceu.Text = "Esqueceu a senha?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.anima.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "E-mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.anima.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_senha, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_senha, Guna.UI.Animation.DecorationType.None)
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = ""
        Me.txt_senha.isPassword = True
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_senha.LineThickness = 3
        Me.txt_senha.Location = New System.Drawing.Point(32, 191)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(360, 45)
        Me.txt_senha.TabIndex = 8
        Me.txt_senha.Text = "Senha"
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.anima.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Informe os dados para realizar o seu login."
        '
        'btn_entrar
        '
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_entrar.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btn_entrar, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.btn_entrar, Guna.UI.Animation.DecorationType.None)
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = Nothing
        Me.btn_entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_entrar.Location = New System.Drawing.Point(31, 299)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Yellow
        Me.btn_entrar.Size = New System.Drawing.Size(366, 50)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'check_senha
        '
        Me.check_senha.BaseColor = System.Drawing.Color.White
        Me.check_senha.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_senha.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.anima1.SetDecoration(Me.check_senha, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.check_senha, Guna.UI.Animation.DecorationType.None)
        Me.check_senha.FillColor = System.Drawing.Color.White
        Me.check_senha.Location = New System.Drawing.Point(31, 243)
        Me.check_senha.Name = "check_senha"
        Me.check_senha.Size = New System.Drawing.Size(104, 20)
        Me.check_senha.TabIndex = 3
        Me.check_senha.Text = "Mostrar Senha"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_email, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_email, Guna.UI.Animation.DecorationType.None)
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_email.HintText = "fulano@email.com"
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_email.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_email.LineThickness = 3
        Me.txt_email.Location = New System.Drawing.Point(32, 109)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(360, 49)
        Me.txt_email.TabIndex = 0
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anima
        '
        Me.anima.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.anima.Cursor = Nothing
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
        Me.anima.DefaultAnimation = Animation1
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.anima1.Cursor = Nothing
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
        Me.anima1.DefaultAnimation = Animation2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.anima.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.anima1.SetDecoration(Me.Label9, Guna.UI.Animation.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Número Celular"
        '
        'txt_cadcel
        '
        Me.txt_cadcel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txt_cadcel, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me.txt_cadcel, Guna.UI.Animation.DecorationType.None)
        Me.txt_cadcel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cadcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cadcel.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cadcel.HintText = "(00) 00000-0000"
        Me.txt_cadcel.isPassword = False
        Me.txt_cadcel.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cadcel.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cadcel.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cadcel.LineThickness = 3
        Me.txt_cadcel.Location = New System.Drawing.Point(242, 109)
        Me.txt_cadcel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cadcel.Name = "txt_cadcel"
        Me.txt_cadcel.Size = New System.Drawing.Size(150, 49)
        Me.txt_cadcel.TabIndex = 14
        Me.txt_cadcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.painel_login)
        Me.Controls.Add(Me.painel_cadastro)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.anima.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ULTRAPETS"
        Me.painel_cadastro.ResumeLayout(False)
        Me.painel_cadastro.PerformLayout()
        Me.painel_login.ResumeLayout(False)
        Me.painel_login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents painel_cadastro As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Label
    Friend WithEvents btn_registrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents check_msenha As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txt_cademail As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cadsenha As ns1.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_confsenha As ns1.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents painel_login As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents check_senha As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txt_email As ns1.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cad As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents btn_esqueceu As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents anima As Guna.UI.WinForms.GunaTransition
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cadcel As ns1.BunifuMaterialTextbox
End Class
