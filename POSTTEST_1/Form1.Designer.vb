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
        From1 = New Label()
        lblIPS = New Label()
        txtIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblIPKText = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' From1
        ' 
        From1.AutoSize = True
        From1.Location = New Point(319, 30)
        From1.Name = "From1"
        From1.Size = New Size(110, 25)
        From1.TabIndex = 0
        From1.Text = "Kalkulator IP"
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(81, 99)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(105, 25)
        lblIPS.TabIndex = 1
        lblIPS.Text = "IP Semester"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(245, 99)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(288, 31)
        txtIPS.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(256, 146)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(390, 146)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIPKText
        ' 
        lblIPKText.AutoSize = True
        lblIPKText.Location = New Point(84, 248)
        lblIPKText.Name = "lblIPKText"
        lblIPKText.Size = New Size(107, 25)
        lblIPKText.TabIndex = 5
        lblIPKText.Text = "IP Kumulatif"
        lblIPKText.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.Window
        txtIPK.ForeColor = SystemColors.WindowFrame
        txtIPK.Location = New Point(245, 242)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.ScrollBars = ScrollBars.Vertical
        txtIPK.Size = New Size(294, 31)
        txtIPK.TabIndex = 6
        txtIPK.Text = "0.00"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(341, 316)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(19, 25)
        lblPredikat.TabIndex = 7
        lblPredikat.Text = "-" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(lblIPKText)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Controls.Add(lblIPS)
        Controls.Add(From1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents From1 As Label
    Friend WithEvents lblIPS As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIPKText As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class
