Imports MySqlConnector
Public Class Form1

    ' 🔹 KOSONGKAN INPUT
    Private Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtJenis.Clear()
        txtHarga.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKode.Focus()
    End Sub

    ' 🔹 TAMPIL DATA
    Private Sub TampilData()
        dgvPerhiasan.DataSource = GetAllPerhiasan()
    End Sub

    ' 🔹 LOAD FORM
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    ' 🔹 SIMPAN DATA
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If txtKode.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong!")
            Exit Sub
        End If

        If SimpanPerhiasan(txtKode.Text, txtNama.Text, txtJenis.Text, CInt(txtHarga.Text)) Then
            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    ' 🔹 UBAH DATA
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahPerhiasan(txtKode.Text, txtNama.Text, txtJenis.Text, CInt(txtHarga.Text)) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan")
        End If
    End Sub

    ' 🔹 HAPUS DATA
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin mau hapus?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            If HapusPerhiasan(txtKode.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' 🔹 BATAL / RESET
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' 🔹 KLIK DATA DI TABEL
    Private Sub dgvPerhiasan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerhiasan.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvPerhiasan.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNama.Text = dgvPerhiasan.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtJenis.Text = dgvPerhiasan.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvPerhiasan.Rows(e.RowIndex).Cells(3).Value.ToString()
        End If
    End Sub

    ' 🔹 SEARCH DATA
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvPerhiasan.DataSource = SearchPerhiasan(txtSearch.Text)
        End If
    End Sub

    ' 🔹 VALIDASI ANGKA (HARGA)
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class