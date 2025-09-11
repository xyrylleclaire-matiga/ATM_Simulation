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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(17, 73)
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
        Label2.Location = New Point(17, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 1
        Label2.Text = "PIN:"
        ' 
        ' txtAccNum
        ' 
        txtAccNum.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtAccNum.Location = New Point(177, 73)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(200, 25)
        txtAccNum.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(177, 123)
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
        btnLogin.Location = New Point(177, 173)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(200, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.BorderStyle = BorderStyle.Fixed3D
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
        Panel1.Location = New Point(0, 228)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(409, 164)
        Panel1.TabIndex = 8
        ' 
        ' lblEnter
        ' 
        lblEnter.AutoSize = True
        lblEnter.BackColor = Color.ForestGreen
        lblEnter.BorderStyle = BorderStyle.Fixed3D
        lblEnter.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblEnter.Location = New Point(301, 78)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New Size(87, 25)
        lblEnter.TabIndex = 36
        lblEnter.Text = "    Enter  "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.BorderStyle = BorderStyle.Fixed3D
        btnDel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(301, 112)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(87, 25)
        btnDel.TabIndex = 35
        btnDel.Text = "     Del    "
        ' 
        ' lblCancel
        ' 
        lblCancel.AutoSize = True
        lblCancel.BackColor = Color.Brown
        lblCancel.BorderStyle = BorderStyle.Fixed3D
        lblCancel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblCancel.ForeColor = SystemColors.ControlLight
        lblCancel.Location = New Point(301, 11)
        lblCancel.Name = "lblCancel"
        lblCancel.Size = New Size(85, 25)
        lblCancel.TabIndex = 34
        lblCancel.Text = " Cancel"
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.BorderStyle = BorderStyle.Fixed3D
        lblClear.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblClear.ForeColor = SystemColors.Desktop
        lblClear.Location = New Point(301, 43)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(88, 25)
        lblClear.TabIndex = 33
        lblClear.Text = "  Clear   "
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.BorderStyle = BorderStyle.Fixed3D
        lbl0.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl0.ForeColor = SystemColors.ControlLight
        lbl0.Location = New Point(111, 112)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(91, 24)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.DimGray
        lblEmpty.BorderStyle = BorderStyle.Fixed3D
        lblEmpty.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lblEmpty.Location = New Point(17, 112)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(90, 24)
        lblEmpty.TabIndex = 31
        lblEmpty.Text = "             "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.BorderStyle = BorderStyle.Fixed3D
        lbl9.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl9.ForeColor = SystemColors.ControlLight
        lbl9.Location = New Point(206, 78)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(91, 24)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lblEmpty1
        ' 
        lblEmpty1.AutoSize = True
        lblEmpty1.BackColor = Color.DimGray
        lblEmpty1.BorderStyle = BorderStyle.Fixed3D
        lblEmpty1.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lblEmpty1.Location = New Point(206, 112)
        lblEmpty1.Name = "lblEmpty1"
        lblEmpty1.Size = New Size(90, 24)
        lblEmpty1.TabIndex = 29
        lblEmpty1.Text = "             "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.BorderStyle = BorderStyle.Fixed3D
        lbl8.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl8.ForeColor = SystemColors.ControlLight
        lbl8.Location = New Point(111, 78)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(91, 24)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.BorderStyle = BorderStyle.Fixed3D
        lbl7.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl7.ForeColor = SystemColors.ControlLight
        lbl7.Location = New Point(17, 78)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(91, 24)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl2.ForeColor = SystemColors.ControlLight
        lbl2.Location = New Point(111, 11)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(91, 24)
        lbl2.TabIndex = 26
        lbl2.Text = "      2     "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl4.ForeColor = SystemColors.ControlLight
        lbl4.Location = New Point(16, 43)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(91, 24)
        lbl4.TabIndex = 25
        lbl4.Text = "      4     "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl5.ForeColor = SystemColors.ControlLight
        lbl5.Location = New Point(111, 43)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(91, 24)
        lbl5.TabIndex = 24
        lbl5.Text = "      5     "
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl3.ForeColor = SystemColors.ControlLight
        lbl3.Location = New Point(206, 11)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(91, 24)
        lbl3.TabIndex = 23
        lbl3.Text = "      3     "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.BorderStyle = BorderStyle.Fixed3D
        lbl6.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl6.ForeColor = SystemColors.ControlLight
        lbl6.Location = New Point(206, 43)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(91, 24)
        lbl6.TabIndex = 22
        lbl6.Text = "      6     "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl1.ForeColor = SystemColors.ControlLight
        lbl1.Location = New Point(16, 11)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(91, 24)
        lbl1.TabIndex = 21
        lbl1.Text = "      1     "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(724, 512)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtAccNum)
        Panel2.Controls.Add(txtPIN)
        Panel2.Location = New Point(80, 60)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(566, 392)
        Panel2.TabIndex = 37
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.ForeColor = SystemColors.ControlLight
        Panel3.Location = New Point(394, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(175, 392)
        Panel3.TabIndex = 9
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(721, 505)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ATM Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
