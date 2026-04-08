Imports System.IO

Public Class Form1

    ' =========================
    ' BROWSE FOTO
    ' =========================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    ' =========================
    ' VALIDASI
    ' =========================
    Private Function Validasi() As Boolean

        If txtNama.Text.Trim = "" Or txtID.Text.Trim = "" Or txtEmail.Text.Trim = "" Or txtAlamat.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not mtbNoHp.MaskCompleted Then
            MessageBox.Show("Nomor HP tidak lengkap")
            Return False
        End If

        If cmbKomunitas.SelectedIndex = -1 Then
            MessageBox.Show("Pilih komunitas")
            Return False
        End If

        If Not (chkNgoding.Checked Or chkDesain.Checked Or chkGaming.Checked Or chkMusik.Checked Or chkOlahraga.Checked Or chkTraveling.Checked Or chkFotografi.Checked Or chkMembaca.Checked) Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Return False
        End If

        Return True
    End Function

    ' =========================
    ' SIMPAN & CETAK
    ' =========================
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

        If Not Validasi() Then Exit Sub

        If MessageBox.Show("Simpan dan cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        ' SIMPAN
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim data As String =
                txtNama.Text & vbCrLf &
                txtID.Text & vbCrLf &
                mtbNoHp.Text & vbCrLf &
                txtEmail.Text & vbCrLf &
                txtAlamat.Text

            File.WriteAllText(sfd.FileName, data)
        End If

        ' HOBBY
        Dim hobby As String = ""
        If chkNgoding.Checked Then hobby &= "Ngoding, "
        If chkDesain.Checked Then hobby &= "Desain, "
        If chkGaming.Checked Then hobby &= "Gaming, "
        If chkMusik.Checked Then hobby &= "Musik, "
        If chkOlahraga.Checked Then hobby &= "Olahraga, "
        If chkTraveling.Checked Then hobby &= "Traveling, "
        If chkFotografi.Checked Then hobby &= "Fotografi, "
        If chkMembaca.Checked Then hobby &= "Membaca, "

        ' KIRIM DATA
        FormHasil.lblNama.Text = "Nama: " & txtNama.Text
        FormHasil.lblID.Text = "ID: " & txtID.Text
        FormHasil.lblKomunitas.Text = "Komunitas: " & cmbKomunitas.Text
        FormHasil.lblKontak.Text = "No HP: " & mtbNoHp.Text & vbCrLf & "Email: " & txtEmail.Text
        FormHasil.lblHobby.Text = "Hobby: " & hobby
        FormHasil.pbHasilFoto.Image = pbFoto.Image

        FormHasil.Show()

        MessageBox.Show("Berhasil disimpan & ditampilkan")

    End Sub

    ' =========================
    ' VALIDASI HURUF (NAMA)
    ' =========================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' =========================
    ' VALIDASI ANGKA (HP)
    ' =========================
    Private Sub mtbNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbNoHp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    ' =========================
    ' MENU
    ' =========================
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormHasil.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub grpPeran_Enter(sender As Object, e As EventArgs) Handles grpPeran.Enter

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class