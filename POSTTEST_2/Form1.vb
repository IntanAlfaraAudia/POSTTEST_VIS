Public Class Form1

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < daftarBuku.Length Then
            daftarBuku(jumlahBuku) = FormatBuku(judul, genre)
            jumlahBuku += 1
        End If

    End Sub


    Public Sub HapusBuku(ByVal judul As String)

        For i As Integer = 0 To jumlahBuku - 1

            If daftarBuku(i).Contains(judul) Then

                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j) = daftarBuku(j + 1)
                Next

                jumlahBuku -= 1
                Exit For

            End If

        Next

    End Sub


    Sub TampilData()

        lbDaftar.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            lbDaftar.Items.Add(daftarBuku(i))
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Masukkan judul dan genre buku")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilData()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtHapus.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus")
            Exit Sub
        End If

        HapusBuku(txtHapus.Text)

        TampilData()

        txtHapus.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class