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
        Label1 = New Label()
        Label2 = New Label()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        txtHapus = New TextBox()
        Label3 = New Label()
        lbDaftar = New ListBox()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 24)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 24)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(139, 49)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(254, 31)
        txtJudul.TabIndex = 3
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(139, 96)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(254, 31)
        txtGenre.TabIndex = 5
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LavenderBlush
        btnTambah.Location = New Point(270, 145)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(123, 33)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Lavender
        btnHapus.Location = New Point(270, 145)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(123, 33)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.RosyBrown
        GroupBox2.Controls.Add(txtJudul)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnTambah)
        GroupBox2.Controls.Add(txtGenre)
        GroupBox2.Location = New Point(13, 21)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(412, 183)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Tambah Buku"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.RosyBrown
        GroupBox1.Controls.Add(txtHapus)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Location = New Point(454, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(412, 183)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hapus Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(139, 49)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(254, 31)
        txtHapus.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 24)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' lbDaftar
        ' 
        lbDaftar.BackColor = Color.SeaShell
        lbDaftar.BorderStyle = BorderStyle.FixedSingle
        lbDaftar.FormattingEnabled = True
        lbDaftar.Location = New Point(208, 235)
        lbDaftar.Name = "lbDaftar"
        lbDaftar.Size = New Size(443, 194)
        lbDaftar.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(880, 432)
        Controls.Add(lbDaftar)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Font = New Font("Plantagenet Cherokee", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posttest 2"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbDaftar As ListBox

End Class
