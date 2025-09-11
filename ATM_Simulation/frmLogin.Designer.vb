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
        Panel1 = New Panel()
        lblEnter = New Label()
        btnDel = New Label()
        lblCancel = New Label()
        lblClear = New Label()
        lbl0 = New Label()
        lblEmpty = New Label()
        lbl9 = New Label()
        lblEmpty1 = New Label()
        lbl8 = New Label()
        lbl7 = New Label()
        lbl2 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl3 = New Label()
        lbl6 = New Label()
        lbl1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(65, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 19)
        Label1.TabIndex = 0
        Label1.Text = "Account Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(65, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 1
        Label2.Text = "PIN:"
        ' 
        ' txtAccNum
        ' 
        txtAccNum.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtAccNum.Location = New Point(225, 54)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(200, 25)
        txtAccNum.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(225, 104)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(200, 25)
        txtPIN.TabIndex = 3
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(225, 154)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(200, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(lblEnter)
        Panel1.Controls.Add(btnDel)
        Panel1.Controls.Add(lblCancel)
        Panel1.Controls.Add(lblClear)
        Panel1.Controls.Add(lbl0)
        Panel1.Controls.Add(lblEmpty)
        Panel1.Controls.Add(lbl9)
        Panel1.Controls.Add(lblEmpty1)
        Panel1.Controls.Add(lbl8)
        Panel1.Controls.Add(lbl7)
        Panel1.Controls.Add(lbl2)
        Panel1.Controls.Add(lbl4)
        Panel1.Controls.Add(lbl5)
        Panel1.Controls.Add(lbl3)
        Panel1.Controls.Add(lbl6)
        Panel1.Controls.Add(lbl1)
        Panel1.Location = New Point(42, 209)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(403, 146)
        Panel1.TabIndex = 8
        ' 
        ' lblEnter
        ' 
        lblEnter.AutoSize = True
        lblEnter.BackColor = Color.ForestGreen
        lblEnter.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblEnter.Location = New Point(301, 78)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New Size(85, 23)
        lblEnter.TabIndex = 36
        lblEnter.Text = "    Enter  "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(301, 112)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(85, 23)
        btnDel.TabIndex = 35
        btnDel.Text = "     Del    "
        ' 
        ' lblCancel
        ' 
        lblCancel.AutoSize = True
        lblCancel.BackColor = Color.DarkRed
        lblCancel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblCancel.Location = New Point(301, 11)
        lblCancel.Name = "lblCancel"
        lblCancel.Size = New Size(83, 23)
        lblCancel.TabIndex = 34
        lblCancel.Text = " Cancel"
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblClear.Location = New Point(301, 43)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(86, 23)
        lblClear.TabIndex = 33
        lblClear.Text = "  Clear   "
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl0.Location = New Point(111, 112)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(89, 22)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.DimGray
        lblEmpty.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lblEmpty.Location = New Point(17, 112)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(88, 22)
        lblEmpty.TabIndex = 31
        lblEmpty.Text = "             "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl9.Location = New Point(206, 78)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(89, 22)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lblEmpty1
        ' 
        lblEmpty1.AutoSize = True
        lblEmpty1.BackColor = Color.DimGray
        lblEmpty1.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lblEmpty1.Location = New Point(206, 112)
        lblEmpty1.Name = "lblEmpty1"
        lblEmpty1.Size = New Size(88, 22)
        lblEmpty1.TabIndex = 29
        lblEmpty1.Text = "             "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl8.Location = New Point(111, 78)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(89, 22)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl7.Location = New Point(17, 78)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(89, 22)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl2.Location = New Point(111, 11)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(89, 22)
        lbl2.TabIndex = 26
        lbl2.Text = "      2     "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl4.Location = New Point(16, 43)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(89, 22)
        lbl4.TabIndex = 25
        lbl4.Text = "      4     "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl5.Location = New Point(111, 43)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(89, 22)
        lbl5.TabIndex = 24
        lbl5.Text = "      5     "
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl3.Location = New Point(206, 11)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(89, 22)
        lbl3.TabIndex = 23
        lbl3.Text = "      3     "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl6.Location = New Point(206, 43)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(89, 22)
        lbl6.TabIndex = 22
        lbl6.Text = "      6     "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl1.Location = New Point(16, 11)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(89, 22)
        lbl1.TabIndex = 21
        lbl1.Text = "      1     "
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(488, 386)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lblEmpty1 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblClear As Label
End Class
