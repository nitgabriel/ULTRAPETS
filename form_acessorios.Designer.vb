<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_acessorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_acessorios))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.qtde_banheira = New System.Windows.Forms.TextBox()
        Me.adc_banheira = New Guna.UI.WinForms.GunaButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.qtde_cercado = New System.Windows.Forms.TextBox()
        Me.adc_cercado = New Guna.UI.WinForms.GunaButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.qtde_playground = New System.Windows.Forms.TextBox()
        Me.adc_playground = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qtde_transporte = New System.Windows.Forms.TextBox()
        Me.adc_transporte = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.qtde_mochilinha = New System.Windows.Forms.TextBox()
        Me.adc_mochilinha = New Guna.UI.WinForms.GunaButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.qtde_astro = New System.Windows.Forms.TextBox()
        Me.adc_astro = New Guna.UI.WinForms.GunaButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 14)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Banheira para Pássaros - R$10,00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(363, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "Qtde:"
        '
        'qtde_banheira
        '
        Me.qtde_banheira.Location = New System.Drawing.Point(402, 377)
        Me.qtde_banheira.Name = "qtde_banheira"
        Me.qtde_banheira.Size = New System.Drawing.Size(24, 20)
        Me.qtde_banheira.TabIndex = 199
        '
        'adc_banheira
        '
        Me.adc_banheira.AnimationHoverSpeed = 0.07!
        Me.adc_banheira.AnimationSpeed = 0.03!
        Me.adc_banheira.BackColor = System.Drawing.Color.White
        Me.adc_banheira.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_banheira.BorderColor = System.Drawing.Color.Black
        Me.adc_banheira.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_banheira.FocusedColor = System.Drawing.Color.Empty
        Me.adc_banheira.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_banheira.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_banheira.Image = Nothing
        Me.adc_banheira.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_banheira.Location = New System.Drawing.Point(431, 377)
        Me.adc_banheira.Name = "adc_banheira"
        Me.adc_banheira.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_banheira.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_banheira.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_banheira.OnHoverImage = Nothing
        Me.adc_banheira.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_banheira.Size = New System.Drawing.Size(84, 21)
        Me.adc_banheira.TabIndex = 198
        Me.adc_banheira.Text = "ADICIONAR "
        Me.adc_banheira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 14)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Cercado para roedores - R$30,00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(186, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 195
        Me.Label10.Text = "Qtde:"
        '
        'qtde_cercado
        '
        Me.qtde_cercado.Location = New System.Drawing.Point(225, 377)
        Me.qtde_cercado.Name = "qtde_cercado"
        Me.qtde_cercado.Size = New System.Drawing.Size(24, 20)
        Me.qtde_cercado.TabIndex = 194
        '
        'adc_cercado
        '
        Me.adc_cercado.AnimationHoverSpeed = 0.07!
        Me.adc_cercado.AnimationSpeed = 0.03!
        Me.adc_cercado.BackColor = System.Drawing.Color.White
        Me.adc_cercado.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_cercado.BorderColor = System.Drawing.Color.Black
        Me.adc_cercado.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_cercado.FocusedColor = System.Drawing.Color.Empty
        Me.adc_cercado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_cercado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_cercado.Image = Nothing
        Me.adc_cercado.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_cercado.Location = New System.Drawing.Point(254, 377)
        Me.adc_cercado.Name = "adc_cercado"
        Me.adc_cercado.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_cercado.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_cercado.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_cercado.OnHoverImage = Nothing
        Me.adc_cercado.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_cercado.Size = New System.Drawing.Size(84, 21)
        Me.adc_cercado.TabIndex = 193
        Me.adc_cercado.Text = "ADICIONAR "
        Me.adc_cercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 14)
        Me.Label11.TabIndex = 191
        Me.Label11.Text = "Playground cama felino - R$60,00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 378)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Qtde:"
        '
        'qtde_playground
        '
        Me.qtde_playground.Location = New System.Drawing.Point(48, 377)
        Me.qtde_playground.Name = "qtde_playground"
        Me.qtde_playground.Size = New System.Drawing.Size(24, 20)
        Me.qtde_playground.TabIndex = 189
        '
        'adc_playground
        '
        Me.adc_playground.AnimationHoverSpeed = 0.07!
        Me.adc_playground.AnimationSpeed = 0.03!
        Me.adc_playground.BackColor = System.Drawing.Color.White
        Me.adc_playground.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_playground.BorderColor = System.Drawing.Color.Black
        Me.adc_playground.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_playground.FocusedColor = System.Drawing.Color.Empty
        Me.adc_playground.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_playground.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_playground.Image = Nothing
        Me.adc_playground.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_playground.Location = New System.Drawing.Point(77, 377)
        Me.adc_playground.Name = "adc_playground"
        Me.adc_playground.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_playground.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_playground.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_playground.OnHoverImage = Nothing
        Me.adc_playground.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_playground.Size = New System.Drawing.Size(84, 21)
        Me.adc_playground.TabIndex = 188
        Me.adc_playground.Text = "ADICIONAR "
        Me.adc_playground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 14)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Transporte para Roedor - R$40,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "Qtde:"
        '
        'qtde_transporte
        '
        Me.qtde_transporte.Location = New System.Drawing.Point(402, 177)
        Me.qtde_transporte.Name = "qtde_transporte"
        Me.qtde_transporte.Size = New System.Drawing.Size(24, 20)
        Me.qtde_transporte.TabIndex = 184
        '
        'adc_transporte
        '
        Me.adc_transporte.AnimationHoverSpeed = 0.07!
        Me.adc_transporte.AnimationSpeed = 0.03!
        Me.adc_transporte.BackColor = System.Drawing.Color.White
        Me.adc_transporte.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_transporte.BorderColor = System.Drawing.Color.Black
        Me.adc_transporte.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_transporte.FocusedColor = System.Drawing.Color.Empty
        Me.adc_transporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_transporte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_transporte.Image = Nothing
        Me.adc_transporte.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_transporte.Location = New System.Drawing.Point(431, 177)
        Me.adc_transporte.Name = "adc_transporte"
        Me.adc_transporte.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_transporte.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_transporte.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_transporte.OnHoverImage = Nothing
        Me.adc_transporte.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_transporte.Size = New System.Drawing.Size(84, 21)
        Me.adc_transporte.TabIndex = 183
        Me.adc_transporte.Text = "ADICIONAR "
        Me.adc_transporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 14)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Mochilinha Escolar PET - R$80,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Qtde:"
        '
        'qtde_mochilinha
        '
        Me.qtde_mochilinha.Location = New System.Drawing.Point(225, 177)
        Me.qtde_mochilinha.Name = "qtde_mochilinha"
        Me.qtde_mochilinha.Size = New System.Drawing.Size(24, 20)
        Me.qtde_mochilinha.TabIndex = 179
        '
        'adc_mochilinha
        '
        Me.adc_mochilinha.AnimationHoverSpeed = 0.07!
        Me.adc_mochilinha.AnimationSpeed = 0.03!
        Me.adc_mochilinha.BackColor = System.Drawing.Color.White
        Me.adc_mochilinha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_mochilinha.BorderColor = System.Drawing.Color.Black
        Me.adc_mochilinha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_mochilinha.FocusedColor = System.Drawing.Color.Empty
        Me.adc_mochilinha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_mochilinha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_mochilinha.Image = Nothing
        Me.adc_mochilinha.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_mochilinha.Location = New System.Drawing.Point(254, 177)
        Me.adc_mochilinha.Name = "adc_mochilinha"
        Me.adc_mochilinha.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_mochilinha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_mochilinha.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_mochilinha.OnHoverImage = Nothing
        Me.adc_mochilinha.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_mochilinha.Size = New System.Drawing.Size(84, 21)
        Me.adc_mochilinha.TabIndex = 178
        Me.adc_mochilinha.Text = "ADICIONAR "
        Me.adc_mochilinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 14)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Mochila Astronauta PET - R$80,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Qtde:"
        '
        'qtde_astro
        '
        Me.qtde_astro.Location = New System.Drawing.Point(48, 177)
        Me.qtde_astro.Name = "qtde_astro"
        Me.qtde_astro.Size = New System.Drawing.Size(24, 20)
        Me.qtde_astro.TabIndex = 174
        '
        'adc_astro
        '
        Me.adc_astro.AnimationHoverSpeed = 0.07!
        Me.adc_astro.AnimationSpeed = 0.03!
        Me.adc_astro.BackColor = System.Drawing.Color.White
        Me.adc_astro.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.adc_astro.BorderColor = System.Drawing.Color.Black
        Me.adc_astro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.adc_astro.FocusedColor = System.Drawing.Color.Empty
        Me.adc_astro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adc_astro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adc_astro.Image = Nothing
        Me.adc_astro.ImageSize = New System.Drawing.Size(20, 20)
        Me.adc_astro.Location = New System.Drawing.Point(77, 177)
        Me.adc_astro.Name = "adc_astro"
        Me.adc_astro.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.adc_astro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.adc_astro.OnHoverForeColor = System.Drawing.Color.White
        Me.adc_astro.OnHoverImage = Nothing
        Me.adc_astro.OnPressedColor = System.Drawing.Color.Yellow
        Me.adc_astro.Size = New System.Drawing.Size(84, 21)
        Me.adc_astro.TabIndex = 173
        Me.adc_astro.Text = "ADICIONAR "
        Me.adc_astro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(359, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 153)
        Me.Button4.TabIndex = 197
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(182, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(168, 153)
        Me.Button5.TabIndex = 192
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(5, 204)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(168, 153)
        Me.Button6.TabIndex = 187
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(359, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 153)
        Me.Button3.TabIndex = 182
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(182, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 153)
        Me.Button2.TabIndex = 177
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 153)
        Me.Button1.TabIndex = 172
        Me.Button1.UseVisualStyleBackColor = False
        '
        'form_acessorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.qtde_banheira)
        Me.Controls.Add(Me.adc_banheira)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.qtde_cercado)
        Me.Controls.Add(Me.adc_cercado)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.qtde_playground)
        Me.Controls.Add(Me.adc_playground)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qtde_transporte)
        Me.Controls.Add(Me.adc_transporte)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.qtde_mochilinha)
        Me.Controls.Add(Me.adc_mochilinha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.qtde_astro)
        Me.Controls.Add(Me.adc_astro)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_acessorios"
        Me.Text = "form_acessorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents qtde_banheira As TextBox
    Friend WithEvents adc_banheira As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents qtde_cercado As TextBox
    Friend WithEvents adc_cercado As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents qtde_playground As TextBox
    Friend WithEvents adc_playground As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents qtde_transporte As TextBox
    Friend WithEvents adc_transporte As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents qtde_mochilinha As TextBox
    Friend WithEvents adc_mochilinha As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents qtde_astro As TextBox
    Friend WithEvents adc_astro As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Button
End Class
