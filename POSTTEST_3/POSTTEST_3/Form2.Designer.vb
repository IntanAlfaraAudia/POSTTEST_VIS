<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pbFoto = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblTanggal = New Label()
        lblAlamat = New Label()
        lblJK = New Label()
        lblHobby = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(43, 86)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(245, 306)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(554, 95)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(557, 145)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 14
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(557, 185)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(106, 25)
        lblTelepon.TabIndex = 16
        lblTelepon.Text = "No. Telepon"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(558, 228)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(115, 25)
        lblTanggal.TabIndex = 17
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(558, 277)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 18
        lblAlamat.Text = "Alamat"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(558, 324)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(116, 25)
        lblJK.TabIndex = 19
        lblJK.Text = "Jenis Kelamin"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(559, 367)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(67, 25)
        lblHobby.TabIndex = 20
        lblHobby.Text = "Hobby"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(335, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 25)
        Label1.TabIndex = 21
        Label1.Text = "Nama Lengkap :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(335, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 25)
        Label2.TabIndex = 22
        Label2.Text = "Umur :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(335, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 25)
        Label3.TabIndex = 23
        Label3.Text = "No. Telepon : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(335, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 25)
        Label4.TabIndex = 24
        Label4.Text = "Tanggal Lahir :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(335, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 25
        Label5.Text = "Alamat :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(335, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 25)
        Label6.TabIndex = 26
        Label6.Text = "Jenis Kelamin :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(335, 367)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 25)
        Label7.TabIndex = 27
        Label7.Text = "Hobby : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.MidnightBlue
        Label8.Location = New Point(215, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(315, 40)
        Label8.TabIndex = 28
        Label8.Text = "KARTU KOMUNITAS"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(765, 443)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblJK)
        Controls.Add(lblAlamat)
        Controls.Add(lblTanggal)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pbFoto)
        Name = "Form2"
        Text = "Form2"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
