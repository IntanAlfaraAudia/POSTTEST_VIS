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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        BukaFormInputToolStripMenuItem = New ToolStripMenuItem()
        ResetInputToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblKomunitas = New Label()
        grpGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        txtID = New TextBox()
        txtNama = New TextBox()
        lblID = New Label()
        lblNama = New Label()
        lblJudul = New Label()
        cmbKomunitas = New ComboBox()
        dtpTanggalLahir = New DateTimePicker()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        lblEmail = New Label()
        lblNoHP = New Label()
        mtbNoHp = New MaskedTextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        chkOlahraga = New CheckBox()
        chkTraveling = New CheckBox()
        chkFotografi = New CheckBox()
        chkMembaca = New CheckBox()
        chkMusik = New CheckBox()
        chkGaming = New CheckBox()
        chkDesain = New CheckBox()
        chkNgoding = New CheckBox()
        grpPeran = New GroupBox()
        rbKoordinator = New RadioButton()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        grpGender.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.PaleVioletRed
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1063, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaFormInputToolStripMenuItem, ResetInputToolStripMenuItem})
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(117, 29)
        InputDataToolStripMenuItem.Text = "Input Data "
        ' 
        ' BukaFormInputToolStripMenuItem
        ' 
        BukaFormInputToolStripMenuItem.Name = "BukaFormInputToolStripMenuItem"
        BukaFormInputToolStripMenuItem.Size = New Size(246, 34)
        BukaFormInputToolStripMenuItem.Text = "Buka Form Input"
        ' 
        ' ResetInputToolStripMenuItem
        ' 
        ResetInputToolStripMenuItem.Name = "ResetInputToolStripMenuItem"
        ResetInputToolStripMenuItem.Size = New Size(246, 34)
        ResetInputToolStripMenuItem.Text = "Reset Input"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(113, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data "
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(23, 54)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(672, 449)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Pink
        TabPage1.Controls.Add(lblKomunitas)
        TabPage1.Controls.Add(grpGender)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(lblID)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Controls.Add(lblJudul)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(664, 411)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Font = New Font("Times New Roman", 11.0F)
        lblKomunitas.ForeColor = Color.Brown
        lblKomunitas.Location = New Point(448, 187)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(106, 25)
        lblKomunitas.TabIndex = 11
        lblKomunitas.Text = "Komunitas"
        ' 
        ' grpGender
        ' 
        grpGender.BackColor = Color.LavenderBlush
        grpGender.Controls.Add(rbPerempuan)
        grpGender.Controls.Add(rbLaki)
        grpGender.ForeColor = Color.Brown
        grpGender.Location = New Point(85, 235)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(261, 122)
        grpGender.TabIndex = 10
        grpGender.TabStop = False
        grpGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(24, 74)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 3
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(24, 39)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(104, 29)
        rbLaki.TabIndex = 2
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.LavenderBlush
        txtID.Location = New Point(403, 124)
        txtID.Name = "txtID"
        txtID.Size = New Size(203, 31)
        txtID.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.LavenderBlush
        txtNama.Location = New Point(85, 124)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(211, 31)
        txtNama.TabIndex = 8
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Times New Roman", 11.0F)
        lblID.ForeColor = Color.Brown
        lblID.Location = New Point(448, 81)
        lblID.Name = "lblID"
        lblID.Size = New Size(112, 25)
        lblID.TabIndex = 7
        lblID.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Times New Roman", 11.0F)
        lblNama.ForeColor = Color.Brown
        lblNama.Location = New Point(120, 81)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(144, 25)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama Lengkap"
        ' 
        ' lblJudul
        ' 
        lblJudul.BackColor = Color.PaleVioletRed
        lblJudul.Font = New Font("Sans Serif Collection", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Brown
        lblJudul.Location = New Point(-15, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(695, 78)
        lblJudul.TabIndex = 5
        lblJudul.Text = "APLIKASI KARTU KOMUNITAS"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.BackColor = Color.LavenderBlush
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Programming", "Design", "Gaming", "Musik", "Fotografi"})
        cmbKomunitas.Location = New Point(403, 235)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(203, 33)
        cmbKomunitas.TabIndex = 3
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CalendarMonthBackground = Color.LavenderBlush
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(85, 181)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(211, 31)
        dtpTanggalLahir.TabIndex = 1
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Pink
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(lblNoHP)
        TabPage2.Controls.Add(mtbNoHp)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(664, 411)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.LavenderBlush
        txtAlamat.Location = New Point(229, 175)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(365, 31)
        txtAlamat.TabIndex = 7
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.ForeColor = Color.Maroon
        lblAlamat.Location = New Point(41, 175)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.Maroon
        lblEmail.Location = New Point(41, 102)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' lblNoHP
        ' 
        lblNoHP.AutoSize = True
        lblNoHP.ForeColor = Color.Maroon
        lblNoHP.Location = New Point(41, 23)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(135, 25)
        lblNoHP.TabIndex = 4
        lblNoHP.Text = "Nomor Telepon"
        ' 
        ' mtbNoHp
        ' 
        mtbNoHp.BackColor = Color.LavenderBlush
        mtbNoHp.Location = New Point(229, 23)
        mtbNoHp.Mask = "0000-0000-0000"
        mtbNoHp.Name = "mtbNoHp"
        mtbNoHp.Size = New Size(365, 31)
        mtbNoHp.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.LavenderBlush
        txtEmail.Location = New Point(229, 96)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(365, 31)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Pink
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(chkOlahraga)
        TabPage3.Controls.Add(chkTraveling)
        TabPage3.Controls.Add(chkFotografi)
        TabPage3.Controls.Add(chkMembaca)
        TabPage3.Controls.Add(chkMusik)
        TabPage3.Controls.Add(chkGaming)
        TabPage3.Controls.Add(chkDesain)
        TabPage3.Controls.Add(chkNgoding)
        TabPage3.Controls.Add(grpPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFoto)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(664, 411)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.LavenderBlush
        btnSimpanCetak.ForeColor = Color.Maroon
        btnSimpanCetak.Location = New Point(279, 321)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(246, 34)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.ForeColor = Color.Maroon
        chkOlahraga.Location = New Point(418, 153)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(110, 29)
        chkOlahraga.TabIndex = 10
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.ForeColor = Color.Maroon
        chkTraveling.Location = New Point(418, 188)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(107, 29)
        chkTraveling.TabIndex = 9
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.ForeColor = Color.Maroon
        chkFotografi.Location = New Point(417, 223)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(111, 29)
        chkFotografi.TabIndex = 8
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.ForeColor = Color.Maroon
        chkMembaca.Location = New Point(418, 264)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(116, 29)
        chkMembaca.TabIndex = 7
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.ForeColor = Color.Maroon
        chkMusik.Location = New Point(256, 264)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(85, 29)
        chkMusik.TabIndex = 6
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.ForeColor = Color.Maroon
        chkGaming.Location = New Point(256, 223)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(100, 29)
        chkGaming.TabIndex = 5
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkDesain
        ' 
        chkDesain.AutoSize = True
        chkDesain.ForeColor = Color.Maroon
        chkDesain.Location = New Point(256, 188)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(91, 29)
        chkDesain.TabIndex = 4
        chkDesain.Text = "Desain"
        chkDesain.UseVisualStyleBackColor = True
        ' 
        ' chkNgoding
        ' 
        chkNgoding.AutoSize = True
        chkNgoding.ForeColor = Color.Maroon
        chkNgoding.Location = New Point(257, 153)
        chkNgoding.Name = "chkNgoding"
        chkNgoding.Size = New Size(109, 29)
        chkNgoding.TabIndex = 3
        chkNgoding.Text = "Ngoding"
        chkNgoding.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.BackColor = Color.LavenderBlush
        grpPeran.Controls.Add(rbKoordinator)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.ForeColor = Color.Maroon
        grpPeran.Location = New Point(260, 16)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(300, 131)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran di Komunitas"
        ' 
        ' rbKoordinator
        ' 
        rbKoordinator.AutoSize = True
        rbKoordinator.Location = New Point(158, 46)
        rbKoordinator.Name = "rbKoordinator"
        rbKoordinator.Size = New Size(132, 29)
        rbKoordinator.TabIndex = 3
        rbKoordinator.TabStop = True
        rbKoordinator.Text = "Koordinator"
        rbKoordinator.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(6, 81)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(90, 29)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(158, 81)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(107, 29)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 46)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(81, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.LavenderBlush
        btnBrowse.ForeColor = Color.Maroon
        btnBrowse.Location = New Point(70, 321)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Upload Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.LavenderBlush
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(21, 16)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(205, 277)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(1063, 529)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents mtbNoHp As MaskedTextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkDesain As CheckBox
    Friend WithEvents chkNgoding As CheckBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNoHP As Label
    Friend WithEvents rbKoordinator As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BukaFormInputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetInputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblKomunitas As Label

End Class
