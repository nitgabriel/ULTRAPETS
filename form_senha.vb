Imports System.IO

Public Class form_senha
    Private Sub btn_recuperar_Click(sender As Object, e As EventArgs) Handles btn_recuperar.Click
        If senha_api.Text = "" Or senha_numero.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If

        Try
            Dim api_senha As String = senha_api.Text
            Dim senhaNumero As String = senha_numero.Text
            sql = "SELECT * FROM tb_login WHERE contato='" & senhaNumero & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                Dim numeroTelefone As String = rs.Fields("contato").Value
                Dim emailUsuario As String = rs.Fields("email").Value
                Dim senhaUsuario As String = rs.Fields("senha").Value

                Dim curlPath As String = Path.Combine(Application.StartupPath, "curl.exe")
                Dim comando As String = "https://api.callmebot.com/whatsapp.php?phone=+55" & numeroTelefone & "&text=Prezado(a)%20" & emailUsuario & ",%20conforme%20solicitado%20na%20tela%20de%20recuperação,%20sua%20senha%20é:%20" & senhaUsuario & "&apikey=" & api_senha

                Dim processInfo As New ProcessStartInfo(curlPath, comando)
                processInfo.UseShellExecute = False
                processInfo.CreateNoWindow = True

                Dim process As Process = Process.Start(processInfo)
                process.WaitForExit()

                MsgBox("Por favor, verificar o seu WhatsApp para ver a sua senha cadastrada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Contato não consta no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Erro ao tentar recuperar a senha!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub


    Private Sub senha_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles senha_numero.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If senha_numero.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class