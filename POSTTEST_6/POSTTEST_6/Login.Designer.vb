<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Pink
        Label1.Font = New Font("Algerian", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(-2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(842, 108)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN SISTEM PERHIASAN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Pink
        txtUsername.Location = New Point(337, 171)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(272, 31)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(195, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(195, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Pink
        txtPassword.Location = New Point(337, 246)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(272, 31)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Pink
        btnLogin.ForeColor = Color.Maroon
        btnLogin.Location = New Point(282, 354)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Masuk"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.Pink
        btnKeluar.ForeColor = Color.Maroon
        btnKeluar.Location = New Point(482, 354)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button
End Class
