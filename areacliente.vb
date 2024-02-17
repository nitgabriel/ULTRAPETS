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
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_petshop_Click(sender As Object, e As EventArgs) Handles btn_petshop.Click
        Me.Hide()
        petshop.Show()
    End Sub
End Class