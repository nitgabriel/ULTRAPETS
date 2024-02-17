<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desmatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(desmatricula))
        Me.alterar_p3 = New Guna.UI.WinForms.GunaRadioButton()
        Me.alterar_p2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.alterar_p1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_cpfdesm = New ns1.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nomedesm = New ns1.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nomepetdesm = New ns1.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_alterar = New ns1.BunifuThinButton2()
        Me.btn_desmatricular = New ns1.BunifuThinButton2()
        Me.BunifuCards1 = New ns1.BunifuCards()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'alterar_p3
        '
        Me.alterar_p3.BaseColor = System.Drawing.SystemColors.Control
        Me.alterar_p3.CheckedOffColor = System.Drawing.Color.Gray
        Me.alterar_p3.CheckedOnColor = System.Drawing.Color.Orange
        Me.alterar_p3.FillColor = System.Drawing.Color.White
        Me.alterar_p3.Location = New System.Drawing.Point(186, 282)
        Me.alterar_p3.Name = "alterar_p3"
        Me.alterar_p3.Size = New System.Drawing.Size(68, 20)
        Me.alterar_p3.TabIndex = 56
        Me.alterar_p3.Text = "Plano 3"
        '
        'alterar_p2
        '
        Me.alterar_p2.BaseColor = System.Drawing.SystemColors.Control
        Me.alterar_p2.CheckedOffColor = System.Drawing.Color.Gray
        Me.alterar_p2.CheckedOnColor = System.Drawing.Color.Orange
        Me.alterar_p2.FillColor = System.Drawing.Color.White
        Me.alterar_p2.Location = New System.Drawing.Point(111, 282)
        Me.alterar_p2.Name = "alterar_p2"
        Me.alterar_p2.Size = New System.Drawing.Size(68, 20)
        Me.alterar_p2.TabIndex = 55
        Me.alterar_p2.Text = "Plano 2"
        '
        'alterar_p1
        '
        Me.alterar_p1.BaseColor = System.Drawing.SystemColors.Control
        Me.alterar_p1.CheckedOffColor = System.Drawing.Color.Gray
        Me.alterar_p1.CheckedOnColor = System.Drawing.Color.Orange
        Me.alterar_p1.FillColor = System.Drawing.Color.White
        Me.alterar_p1.Location = New System.Drawing.Point(39, 282)
        Me.alterar_p1.Name = "alterar_p1"
        Me.alterar_p1.Size = New System.Drawing.Size(68, 20)
        Me.alterar_p1.TabIndex = 54
        Me.alterar_p1.Text = "Plano 1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(36, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Plano de Assinatura"
        '
        'txt_cpfdesm
        '
        Me.txt_cpfdesm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfdesm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cpfdesm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpfdesm.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpfdesm.HintText = ""
        Me.txt_cpfdesm.isPassword = False
        Me.txt_cpfdesm.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_cpfdesm.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpfdesm.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_cpfdesm.LineThickness = 3
        Me.txt_cpfdesm.Location = New System.Drawing.Point(39, 182)
        Me.txt_cpfdesm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpfdesm.Name = "txt_cpfdesm"
        Me.txt_cpfdesm.Size = New System.Drawing.Size(163, 30)
        Me.txt_cpfdesm.TabIndex = 45
        Me.txt_cpfdesm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "CPF"
        '
        'txt_nomedesm
        '
        Me.txt_nomedesm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomedesm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nomedesm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nomedesm.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nomedesm.HintText = ""
        Me.txt_nomedesm.isPassword = False
        Me.txt_nomedesm.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_nomedesm.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nomedesm.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_nomedesm.LineThickness = 3
        Me.txt_nomedesm.Location = New System.Drawing.Point(39, 126)
        Me.txt_nomedesm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomedesm.Name = "txt_nomedesm"
        Me.txt_nomedesm.Size = New System.Drawing.Size(338, 30)
        Me.txt_nomedesm.TabIndex = 41
        Me.txt_nomedesm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nome Completo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Informe os dados abaixo para alterar ou cancelar assinatura."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nome do Pet"
        '
        'txt_nomepetdesm
        '
        Me.txt_nomepetdesm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomepetdesm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nomepetdesm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nomepetdesm.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nomepetdesm.HintText = ""
        Me.txt_nomepetdesm.isPassword = False
        Me.txt_nomepetdesm.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_nomepetdesm.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nomepetdesm.LineMouseHoverColor = System.Drawing.Color.Gold
        Me.txt_nomepetdesm.LineThickness = 3
        Me.txt_nomepetdesm.Location = New System.Drawing.Point(216, 182)
        Me.txt_nomepetdesm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomepetdesm.Name = "txt_nomepetdesm"
        Me.txt_nomepetdesm.Size = New System.Drawing.Size(161, 30)
        Me.txt_nomepetdesm.TabIndex = 58
        Me.txt_nomepetdesm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Em caso de mudança de plano, digite o plano desejado:"
        '
        'btn_alterar
        '
        Me.btn_alterar.ActiveBorderThickness = 1
        Me.btn_alterar.ActiveCornerRadius = 20
        Me.btn_alterar.ActiveFillColor = System.Drawing.Color.Gold
        Me.btn_alterar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_alterar.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_alterar.BackColor = System.Drawing.Color.White
        Me.btn_alterar.BackgroundImage = CType(resources.GetObject("btn_alterar.BackgroundImage"), System.Drawing.Image)
        Me.btn_alterar.ButtonText = "Alterar"
        Me.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alterar.ForeColor = System.Drawing.Color.Orange
        Me.btn_alterar.IdleBorderThickness = 1
        Me.btn_alterar.IdleCornerRadius = 20
        Me.btn_alterar.IdleFillColor = System.Drawing.Color.White
        Me.btn_alterar.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_alterar.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_alterar.Location = New System.Drawing.Point(32, 359)
        Me.btn_alterar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(158, 41)
        Me.btn_alterar.TabIndex = 60
        Me.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_desmatricular
        '
        Me.btn_desmatricular.ActiveBorderThickness = 1
        Me.btn_desmatricular.ActiveCornerRadius = 20
        Me.btn_desmatricular.ActiveFillColor = System.Drawing.Color.Gold
        Me.btn_desmatricular.ActiveForecolor = System.Drawing.Color.White
        Me.btn_desmatricular.ActiveLineColor = System.Drawing.Color.Orange
        Me.btn_desmatricular.BackColor = System.Drawing.Color.White
        Me.btn_desmatricular.BackgroundImage = CType(resources.GetObject("btn_desmatricular.BackgroundImage"), System.Drawing.Image)
        Me.btn_desmatricular.ButtonText = "Desmatrícular"
        Me.btn_desmatricular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_desmatricular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desmatricular.ForeColor = System.Drawing.Color.Orange
        Me.btn_desmatricular.IdleBorderThickness = 1
        Me.btn_desmatricular.IdleCornerRadius = 20
        Me.btn_desmatricular.IdleFillColor = System.Drawing.Color.White
        Me.btn_desmatricular.IdleForecolor = System.Drawing.Color.Orange
        Me.btn_desmatricular.IdleLineColor = System.Drawing.Color.Orange
        Me.btn_desmatricular.Location = New System.Drawing.Point(216, 359)
        Me.btn_desmatricular.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_desmatricular.Name = "btn_desmatricular"
        Me.btn_desmatricular.Size = New System.Drawing.Size(158, 41)
        Me.btn_desmatricular.TabIndex = 61
        Me.btn_desmatricular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards1.Controls.Add(Me.btn_desmatricular)
        Me.BunifuCards1.Controls.Add(Me.btn_alterar)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.txt_nomepetdesm)
        Me.BunifuCards1.Controls.Add(Me.alterar_p3)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.alterar_p2)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.alterar_p1)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.Label14)
        Me.BunifuCards1.Controls.Add(Me.txt_nomedesm)
        Me.BunifuCards1.Controls.Add(Me.txt_cpfdesm)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(411, 455)
        Me.BunifuCards1.TabIndex = 62
        '
        'desmatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(411, 455)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "desmatricula"
        Me.Text = "desmatricula"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents alterar_p3 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents alterar_p2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents alterar_p1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_cpfdesm As ns1.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nomedesm As ns1.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomepetdesm As ns1.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_alterar As ns1.BunifuThinButton2
    Friend WithEvents btn_desmatricular As ns1.BunifuThinButton2
    Friend WithEvents BunifuCards1 As ns1.BunifuCards
End Class
