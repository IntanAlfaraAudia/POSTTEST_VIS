Public Class Form2

    Public nama As String
    Public umur As String
    Public telepon As String
    Public alamat As String
    Public tanggal As String
    Public jk As String
    Public hobby As String
    Public foto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = nama
        lblUmur.Text = umur
        lblTelepon.Text = telepon
        lblAlamat.Text = alamat
        lblTanggal.Text = tanggal
        lblJK.Text = jk
        lblHobby.Text = hobby

        pbFoto.Image = foto

    End Sub

    Private Sub pbFoto_Click(sender As Object, e As EventArgs) Handles pbFoto.Click

    End Sub
End Class
