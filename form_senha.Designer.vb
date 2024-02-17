<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_senha))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.senha_api = New ns1.BunifuMaterialTextbox()
        Me.senha_numero = New ns1.BunifuMaterialTextbox()
        Me.btn_recuperar = New ns1.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(345, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PROCEDIMENTO DE RECUPERAÇÃO DA SENHA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Você vai precisar de:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "- Adicionar o número +34 611 04 87 48 aos seus contatos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "- Mande exatamente isso para o contato pelo WhatsApp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = """I allow callmebot to send me messages"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "INFORME OS DADOS PARA CONFIRMAÇÃO:"
        '
        'senha_api
        '
        Me.senha_api.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.senha_api.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.senha_api.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.senha_api.HintForeColor = System.Drawing.Color.Empty
        Me.senha_api.HintText = "API Recebido"
        Me.senha_api.isPassword = False
        Me.senha_api.LineFocusedColor = System.Drawing.Color.Orange
        Me.senha_api.LineIdleColor = System.Drawing.Color.Gray
        Me.senha_api.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.senha_api.LineThickness = 3
        Me.senha_api.Location = New System.Drawing.Point(259, 217)
        Me.senha_api.Margin = New System.Windows.Forms.Padding(4)
        Me.senha_api.Name = "senha_api"
        Me.senha_api.Size = New System.Drawing.Size(145, 30)
        Me.senha_api.TabIndex = 20
        Me.senha_api.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'senha_numero
        '
        Me.senha_numero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.senha_numero.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.senha_numero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.senha_numero.HintForeColor = System.Drawing.Color.Empty
        Me.senha_numero.HintText = "Número Celular"
        Me.senha_numero.isPassword = False
        Me.senha_numero.LineFocusedColor = System.Drawing.Color.Orange
        Me.senha_numero.LineIdleColor = System.Drawing.Color.Gray
        Me.senha_numero.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.senha_numero.LineThickness = 3
        Me.senha_numero.Location = New System.Drawing.Point(259, 265)
        Me.senha_numero.Margin = New System.Windows.Forms.Padding(4)
        Me.senha_numero.Name = "senha_numero"
        Me.senha_numero.Size = New System.Drawing.Size(145, 30)
        Me.senha_numero.TabIndex = 21
        Me.senha_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_recuperar
        '
        Me.btn_recuperar.ActiveBorderThickness = 1
        Me.btn_recuperar.ActiveCornerRadius = 20
        Me.btn_recuperar.ActiveFillColor = System.Drawing.Color.Gold
        Me.btn_recuperar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_recuperar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_recuperar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_recuperar.BackgroundImage = CType(resources.GetObject("btn_recuperar.BackgroundImage"), System.Drawing.Image)
        Me.btn_recuperar.ButtonText = "Recuperar"
        Me.btn_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_recuperar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recuperar.ForeColor = System.Drawing.Color.Orange
        Me.btn_recuperar.IdleBorderThickness = 1
        Me.btn_recuperar.IdleCornerRadius = 20
        Me.btn_recuperar.IdleFillColor = System.Drawing.Color.White
        Me.btn_recuperar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_recuperar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_recuperar.Location = New System.Drawing.Point(253, 301)
        Me.btn_recuperar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_recuperar.Name = "btn_recuperar"
        Me.btn_recuperar.Size = New System.Drawing.Size(158, 41)
        Me.btn_recuperar.TabIndex = 61
        Me.btn_recuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'form_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(459, 364)
        Me.Controls.Add(Me.btn_recuperar)
        Me.Controls.Add(Me.senha_numero)
        Me.Controls.Add(Me.senha_api)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.Name = "form_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECUPERAR SENHA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents senha_api As ns1.BunifuMaterialTextbox
    Friend WithEvents senha_numero As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_recuperar As ns1.BunifuThinButton2
End Class
