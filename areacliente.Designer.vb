<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class areacliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areacliente))
        Me.btn_banhotosa = New System.Windows.Forms.Button()
        Me.btn_hotel = New System.Windows.Forms.Button()
        Me.btn_creche = New System.Windows.Forms.Button()
        Me.btn_vet = New System.Windows.Forms.Button()
        Me.btn_petshop = New System.Windows.Forms.Button()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_banhotosa
        '
        Me.btn_banhotosa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_banhotosa.BackgroundImage = CType(resources.GetObject("btn_banhotosa.BackgroundImage"), System.Drawing.Image)
        Me.btn_banhotosa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_banhotosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_banhotosa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_banhotosa.Location = New System.Drawing.Point(440, 34)
        Me.btn_banhotosa.Name = "btn_banhotosa"
        Me.btn_banhotosa.Size = New System.Drawing.Size(57, 51)
        Me.btn_banhotosa.TabIndex = 0
        Me.btn_banhotosa.UseVisualStyleBackColor = False
        '
        'btn_hotel
        '
        Me.btn_hotel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_hotel.BackgroundImage = CType(resources.GetObject("btn_hotel.BackgroundImage"), System.Drawing.Image)
        Me.btn_hotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hotel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_hotel.Location = New System.Drawing.Point(440, 121)
        Me.btn_hotel.Name = "btn_hotel"
        Me.btn_hotel.Size = New System.Drawing.Size(57, 51)
        Me.btn_hotel.TabIndex = 1
        Me.btn_hotel.UseVisualStyleBackColor = False
        '
        'btn_creche
        '
        Me.btn_creche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_creche.BackgroundImage = CType(resources.GetObject("btn_creche.BackgroundImage"), System.Drawing.Image)
        Me.btn_creche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_creche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_creche.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_creche.Location = New System.Drawing.Point(440, 291)
        Me.btn_creche.Name = "btn_creche"
        Me.btn_creche.Size = New System.Drawing.Size(57, 51)
        Me.btn_creche.TabIndex = 3
        Me.btn_creche.UseVisualStyleBackColor = False
        '
        'btn_vet
        '
        Me.btn_vet.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_vet.BackgroundImage = CType(resources.GetObject("btn_vet.BackgroundImage"), System.Drawing.Image)
        Me.btn_vet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_vet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_vet.Location = New System.Drawing.Point(440, 202)
        Me.btn_vet.Name = "btn_vet"
        Me.btn_vet.Size = New System.Drawing.Size(57, 51)
        Me.btn_vet.TabIndex = 2
        Me.btn_vet.UseVisualStyleBackColor = False
        '
        'btn_petshop
        '
        Me.btn_petshop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_petshop.BackgroundImage = CType(resources.GetObject("btn_petshop.BackgroundImage"), System.Drawing.Image)
        Me.btn_petshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_petshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_petshop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_petshop.Location = New System.Drawing.Point(440, 371)
        Me.btn_petshop.Name = "btn_petshop"
        Me.btn_petshop.Size = New System.Drawing.Size(57, 51)
        Me.btn_petshop.TabIndex = 4
        Me.btn_petshop.UseVisualStyleBackColor = False
        '
        'btn_adm
        '
        Me.btn_adm.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_adm.BackgroundImage = CType(resources.GetObject("btn_adm.BackgroundImage"), System.Drawing.Image)
        Me.btn_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_adm.Location = New System.Drawing.Point(764, 12)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(24, 26)
        Me.btn_adm.TabIndex = 5
        Me.btn_adm.UseVisualStyleBackColor = False
        Me.btn_adm.Visible = False
        '
        'areacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_adm)
        Me.Controls.Add(Me.btn_petshop)
        Me.Controls.Add(Me.btn_creche)
        Me.Controls.Add(Me.btn_vet)
        Me.Controls.Add(Me.btn_hotel)
        Me.Controls.Add(Me.btn_banhotosa)
        Me.DoubleBuffered = True
        Me.Name = "areacliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÁREA DO CLIENTE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_banhotosa As Button
    Friend WithEvents btn_hotel As Button
    Friend WithEvents btn_creche As Button
    Friend WithEvents btn_vet As Button
    Friend WithEvents btn_petshop As Button
    Friend WithEvents btn_adm As Button
End Class
