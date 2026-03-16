Imports System.IO

Public Class Form1

    'UPLOAD FOTO
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Dim buka As New OpenFileDialog
        buka.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If buka.ShowDialog = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(buka.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub


    'VALIDASI NAMA (HURUF SAJA)
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    'VALIDASI UMUR (ANGKA SAJA)
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    'VALIDASI TELEPON (ANGKA SAJA)
    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    'AMBIL HOBBY DARI CHECKBOX
    Function AmbilHobby() As String

        Dim hobby As String = ""

        If cbGaming.Checked Then hobby &= cbGaming.Text & ", "
        If cbCoding.Checked Then hobby &= cbCoding.Text & ", "
        If cbTravel.Checked Then hobby &= cbTravel.Text & ", "
        If cbReading.Checked Then hobby &= cbReading.Text & ", "
        If cbMusic.Checked Then hobby &= cbMusic.Text & ", "
        If cbDrawing.Checked Then hobby &= cbDrawing.Text & ", "
        If cbSport.Checked Then hobby &= cbSport.Text & ", "
        If cbEditing.Checked Then hobby &= cbEditing.Text & ", "
        If cbPhotography.Checked Then hobby &= cbPhotography.Text & ", "
        If cbDesign.Checked Then hobby &= cbDesign.Text & ", "

        Return hobby

    End Function


    'TOMBOL GENERATE KARTU
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        'VALIDASI INPUT KOSONG
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI JENIS KELAMIN
        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI HOBBY
        If AmbilHobby() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'VALIDASI FOTO
        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        'MENENTUKAN JENIS KELAMIN
        Dim jk As String

        If rbLaki.Checked Then
            jk = "Laki-Laki"
        Else
            jk = "Perempuan"
        End If


        'BUKA FORM HASIL
        Dim kartu As New Form2

        kartu.nama = txtNama.Text
        kartu.umur = txtUmur.Text
        kartu.telepon = txtTelepon.Text
        kartu.alamat = txtAlamat.Text
        kartu.tanggal = dtTanggal.Text
        kartu.jk = jk
        kartu.hobby = AmbilHobby()
        kartu.foto = pbFoto.Image

        kartu.Show()

    End Sub

End Class
