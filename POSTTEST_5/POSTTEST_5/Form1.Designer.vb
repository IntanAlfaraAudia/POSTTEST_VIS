<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtJenis = New TextBox()
        txtHarga = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        dgvPerhiasan = New DataGridView()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPerhiasan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(26, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Perhiasan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(26, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Perhiasan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(26, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 25)
        Label3.TabIndex = 2
        Label3.Text = "Jenis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(26, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Maroon
        Label5.Location = New Point(26, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 4
        Label5.Text = "Cari Data"
        ' 
        ' txtKode
        ' 
        txtKode.BackColor = Color.Pink
        txtKode.Location = New Point(186, 24)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(544, 31)
        txtKode.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Pink
        txtNama.Location = New Point(186, 61)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(544, 31)
        txtNama.TabIndex = 6
        ' 
        ' txtJenis
        ' 
        txtJenis.BackColor = Color.Pink
        txtJenis.Location = New Point(186, 98)
        txtJenis.Name = "txtJenis"
        txtJenis.Size = New Size(544, 31)
        txtJenis.TabIndex = 7
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.Pink
        txtHarga.Location = New Point(186, 137)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(544, 31)
        txtHarga.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Pink
        txtSearch.Location = New Point(186, 174)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(544, 31)
        txtSearch.TabIndex = 9
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Pink
        btnSimpan.ForeColor = Color.Maroon
        btnSimpan.Location = New Point(26, 224)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Pink
        btnUbah.ForeColor = Color.Maroon
        btnUbah.Location = New Point(228, 224)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 11
        btnUbah.Text = "Update"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Pink
        btnHapus.ForeColor = Color.Maroon
        btnHapus.Location = New Point(434, 224)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Delete"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Pink
        btnBatal.ForeColor = Color.Maroon
        btnBatal.Location = New Point(618, 224)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Reset"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvPerhiasan
        ' 
        dgvPerhiasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPerhiasan.Location = New Point(26, 275)
        dgvPerhiasan.Name = "dgvPerhiasan"
        dgvPerhiasan.RowHeadersWidth = 62
        dgvPerhiasan.Size = New Size(704, 230)
        dgvPerhiasan.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 537)
        Controls.Add(dgvPerhiasan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtHarga)
        Controls.Add(txtJenis)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Perhiasan"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPerhiasan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvPerhiasan As DataGridView

End Class
