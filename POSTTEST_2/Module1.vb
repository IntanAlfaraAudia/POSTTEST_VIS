Public Module ModuleData

    Public daftarBuku(100) As String
    Public jumlahBuku As Integer = 0

    Public Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

End Module