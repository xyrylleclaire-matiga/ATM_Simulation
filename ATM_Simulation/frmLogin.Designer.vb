<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtAccNum = New TextBox()
        txtPIN = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(200, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 21)
        Label1.TabIndex = 0
        Label1.Text = "Account Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(200, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 21)
        Label2.TabIndex = 1
        Label2.Text = "PIN:"
        ' 
        ' txtAccNum
        ' 
        txtAccNum.Font = New Font("Segoe UI", 11F)
        txtAccNum.Location = New Point(360, 100)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(200, 27)
        txtAccNum.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Segoe UI", 11F)
        txtPIN.Location = New Point(360, 150)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(200, 27)
        txtPIN.TabIndex = 3
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(360, 200)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(200, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 400)
        Controls.Add(btnLogin)
        Controls.Add(txtPIN)
        Controls.Add(txtAccNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ATM Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnLogin As Button
End Class
