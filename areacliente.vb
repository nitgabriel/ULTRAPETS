Public Class areacliente
    Private Sub btn_banhotosa_Click(sender As Object, e As EventArgs) Handles btn_banhotosa.Click
        Me.Hide()
        banhotosa.Show()
    End Sub

    Private Sub btn_hotel_Click(sender As Object, e As EventArgs) Handles btn_hotel.Click
        Me.Hide()
        hotel.Show()
    End Sub

    Private Sub btn_vet_Click(sender As Object, e As EventArgs) Handles btn_vet.Click
        Me.Hide()
        clinica.Show()
    End Sub

    Private Sub btn_creche_Click(sender As Object, e As EventArgs) Handles btn_creche.Click
        Me.Hide()
        creche.Show()
    End Sub

    Private Sub areacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id_cliente_atual = 0 Then
            btn_adm.Visible = True
        Else
            btn_adm.Visible = False
        End If
    End Sub

    Private Sub btn_petshop_Click(sender As Object, e As EventArgs) Handles btn_petshop.Click
        Me.Hide()
        petshop.Show()
    End Sub

    Private Sub btn_adm_Click(sender As Object, e As EventArgs) Handles btn_adm.Click
        Me.Hide()
        administrativo.Show()
    End Sub
End Class