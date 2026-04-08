<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        panelCard = New Panel()
        lblTitle = New Label()
        lblHobby = New Label()
        lblKontak = New Label()
        lblKomunitas = New Label()
        lblID = New Label()
        lblNama = New Label()
        pbHasilFoto = New PictureBox()
        panelCard.SuspendLayout()
        CType(pbHasilFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelCard
        ' 
        panelCard.BackColor = Color.Pink
        panelCard.Controls.Add(lblTitle)
        panelCard.Controls.Add(lblHobby)
        panelCard.Controls.Add(lblKontak)
        panelCard.Controls.Add(lblKomunitas)
        panelCard.Controls.Add(lblID)
        panelCard.Controls.Add(lblNama)
        panelCard.Controls.Add(pbHasilFoto)
        panelCard.Location = New Point(33, 27)
        panelCard.Name = "panelCard"
        panelCard.Size = New Size(741, 396)
        panelCard.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.PaleVioletRed
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(-21, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(776, 59)
        lblTitle.TabIndex = 6
        lblTitle.Text = "MEMBER CARD"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(299, 270)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(67, 25)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Hobby"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(299, 217)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(67, 25)
        lblKontak.TabIndex = 4
        lblKontak.Text = "Kontak"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(299, 170)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(96, 25)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(299, 118)
        lblID.Name = "lblID"
        lblID.Size = New Size(30, 25)
        lblID.TabIndex = 2
        lblID.Text = "ID"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(299, 75)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' pbHasilFoto
        ' 
        pbHasilFoto.BackColor = Color.LavenderBlush
        pbHasilFoto.Location = New Point(74, 75)
        pbHasilFoto.Name = "pbHasilFoto"
        pbHasilFoto.Size = New Size(177, 220)
        pbHasilFoto.TabIndex = 0
        pbHasilFoto.TabStop = False
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 450)
        Controls.Add(panelCard)
        Name = "FormHasil"
        Text = "Hasil"
        panelCard.ResumeLayout(False)
        panelCard.PerformLayout()
        CType(pbHasilFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelCard As Panel
    Friend WithEvents pbHasilFoto As PictureBox
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTitle As Label
End Class
