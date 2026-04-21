Module ValidationModule

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiPerhiasan(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox) As Boolean
        Dim a As Boolean = ValidasiTextBox(ep, txtKode, "Kode tidak boleh kosong")
        Dim b As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Return a And b
    End Function

End Module