Imports MySqlConnector

Module DataModule

    Public Function GetAllPerhiasan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbperhiasan ORDER BY kodePerhiasan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchPerhiasan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbperhiasan WHERE kodePerhiasan LIKE @key OR namaPerhiasan LIKE @key"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal search: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanPerhiasan(kode As String, nama As String, jenis As String, harga As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tbperhiasan VALUES (@kode,@nama,@jenis,@harga)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahPerhiasan(kode As String, nama As String, jenis As String, harga As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tbperhiasan SET namaPerhiasan=@nama, jenis=@jenis, harga=@harga WHERE kodePerhiasan=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusPerhiasan(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbperhiasan WHERE kodePerhiasan=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

End Module