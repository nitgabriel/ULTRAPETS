Public Class creche

    Sub switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        switchpanel(plano1)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        switchpanel(plano2)
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        switchpanel(plano3)
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        resp = MsgBox("Você confirma que seu pet está com as vacinas atualizadas? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            switchpanel(matricula)
        Else
            MsgBox("É obrigatório o pet estar com as vacinas atualizadas para ser matrículado na creche.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        switchpanel(desmatricula)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        switchpanel(ultra)
    End Sub

    Private Sub sair_creche_Click(sender As Object, e As EventArgs) Handles sair_creche.Click
        Me.Hide()
        areacliente.Show()
    End Sub
End Class