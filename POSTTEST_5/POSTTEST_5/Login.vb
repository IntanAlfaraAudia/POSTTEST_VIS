Public Class Login

    ' 🔐 LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!")
            Exit Sub
        End If

        ' LOGIN SEDERHANA
        If username = "admin" And password = "123" Then
            MessageBox.Show("Login Berhasil!")

            Perhiasan.Show()
            Me.Hide()

        Else
            MessageBox.Show("Username atau Password salah!")
            txtPassword.Clear()
            txtPassword.Focus()
        End If

    End Sub

    ' ❌ KELUAR BUTTON
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

End Class