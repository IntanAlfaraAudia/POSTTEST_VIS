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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pbFoto = New PictureBox()
        btnUpload = New Button()
        btnCetak = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblTanggal = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtTelepon = New TextBox()
        txtUmur = New TextBox()
        dtTanggal = New DateTimePicker()
        gbKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbDesign = New CheckBox()
        cbPhotography = New CheckBox()
        cbEditing = New CheckBox()
        cbSport = New CheckBox()
        cbDrawing = New CheckBox()
        cbMusic = New CheckBox()
        cbReading = New CheckBox()
        cbTravel = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        PictureBox1 = New PictureBox()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbKelamin.SuspendLayout()
        gbHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(12, 9)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(362, 414)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = SystemColors.HotTrack
        btnUpload.Location = New Point(5, 530)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(369, 44)
        btnUpload.TabIndex = 1
        btnUpload.Text = "Upload Foto"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = SystemColors.HotTrack
        btnCetak.Location = New Point(424, 530)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(734, 44)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Generate Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(427, 15)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(427, 69)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(424, 121)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(106, 25)
        lblTelepon.TabIndex = 5
        lblTelepon.Text = "No. Telepon"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(424, 179)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(115, 25)
        lblTanggal.TabIndex = 7
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(424, 231)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 8
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.LightCyan
        txtNama.Location = New Point(590, 9)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.LightCyan
        txtAlamat.Location = New Point(590, 225)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(300, 31)
        txtAlamat.TabIndex = 11
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.LightCyan
        txtTelepon.Location = New Point(590, 121)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(300, 31)
        txtTelepon.TabIndex = 12
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.LightCyan
        txtUmur.Location = New Point(590, 66)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(300, 31)
        txtUmur.TabIndex = 13
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(590, 179)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(300, 31)
        dtTanggal.TabIndex = 14
        ' 
        ' gbKelamin
        ' 
        gbKelamin.Controls.Add(rbPerempuan)
        gbKelamin.Controls.Add(rbLaki)
        gbKelamin.Location = New Point(427, 277)
        gbKelamin.Name = "gbKelamin"
        gbKelamin.Size = New Size(327, 150)
        gbKelamin.TabIndex = 15
        gbKelamin.TabStop = False
        gbKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 93)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 49)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(104, 29)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.TextAlign = ContentAlignment.TopLeft
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(cbDesign)
        gbHobby.Controls.Add(cbPhotography)
        gbHobby.Controls.Add(cbEditing)
        gbHobby.Controls.Add(cbSport)
        gbHobby.Controls.Add(cbDrawing)
        gbHobby.Controls.Add(cbMusic)
        gbHobby.Controls.Add(cbReading)
        gbHobby.Controls.Add(cbTravel)
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbGaming)
        gbHobby.Location = New Point(777, 277)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(387, 247)
        gbHobby.TabIndex = 16
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbDesign
        ' 
        cbDesign.AutoSize = True
        cbDesign.Location = New Point(194, 195)
        cbDesign.Name = "cbDesign"
        cbDesign.Size = New Size(93, 29)
        cbDesign.TabIndex = 26
        cbDesign.Text = "Design"
        cbDesign.UseVisualStyleBackColor = True
        ' 
        ' cbPhotography
        ' 
        cbPhotography.AutoSize = True
        cbPhotography.Location = New Point(194, 160)
        cbPhotography.Name = "cbPhotography"
        cbPhotography.Size = New Size(142, 29)
        cbPhotography.TabIndex = 25
        cbPhotography.Text = "Photography"
        cbPhotography.UseVisualStyleBackColor = True
        ' 
        ' cbEditing
        ' 
        cbEditing.AutoSize = True
        cbEditing.Location = New Point(194, 117)
        cbEditing.Name = "cbEditing"
        cbEditing.Size = New Size(93, 29)
        cbEditing.TabIndex = 24
        cbEditing.Text = "Editing"
        cbEditing.UseVisualStyleBackColor = True
        ' 
        ' cbSport
        ' 
        cbSport.AutoSize = True
        cbSport.Location = New Point(194, 74)
        cbSport.Name = "cbSport"
        cbSport.Size = New Size(82, 29)
        cbSport.TabIndex = 23
        cbSport.Text = "Sport"
        cbSport.UseVisualStyleBackColor = True
        ' 
        ' cbDrawing
        ' 
        cbDrawing.AutoSize = True
        cbDrawing.Location = New Point(194, 34)
        cbDrawing.Name = "cbDrawing"
        cbDrawing.Size = New Size(104, 29)
        cbDrawing.TabIndex = 22
        cbDrawing.Text = "Drawing"
        cbDrawing.UseVisualStyleBackColor = True
        ' 
        ' cbMusic
        ' 
        cbMusic.AutoSize = True
        cbMusic.Location = New Point(26, 187)
        cbMusic.Name = "cbMusic"
        cbMusic.Size = New Size(84, 29)
        cbMusic.TabIndex = 21
        cbMusic.Text = "Music"
        cbMusic.UseVisualStyleBackColor = True
        ' 
        ' cbReading
        ' 
        cbReading.AutoSize = True
        cbReading.Location = New Point(26, 152)
        cbReading.Name = "cbReading"
        cbReading.Size = New Size(102, 29)
        cbReading.TabIndex = 20
        cbReading.Text = "Reading"
        cbReading.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(24, 117)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(107, 29)
        cbTravel.TabIndex = 19
        cbTravel.Text = "Traveling"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(24, 74)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 29)
        cbCoding.TabIndex = 18
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(24, 34)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(100, 29)
        cbGaming.TabIndex = 17
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2026_03_16_at_16_15_08
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(984, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 141)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1209, 586)
        Controls.Add(PictureBox1)
        Controls.Add(gbHobby)
        Controls.Add(gbKelamin)
        Controls.Add(btnCetak)
        Controls.Add(dtTanggal)
        Controls.Add(txtUmur)
        Controls.Add(txtTelepon)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(lblAlamat)
        Controls.Add(lblTanggal)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnUpload)
        Controls.Add(pbFoto)
        Name = "Form1"
        Text = "Form1"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        gbKelamin.ResumeLayout(False)
        gbKelamin.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents gbKelamin As GroupBox
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbDesign As CheckBox
    Friend WithEvents cbPhotography As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents cbSport As CheckBox
    Friend WithEvents cbDrawing As CheckBox
    Friend WithEvents cbMusic As CheckBox
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
