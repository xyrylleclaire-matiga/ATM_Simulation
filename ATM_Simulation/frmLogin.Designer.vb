<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Label1 = New Label()
        Label2 = New Label()
        txtAccNum = New TextBox()
        txtPIN = New TextBox()
        btnLogin = New Button()
        Panel1 = New Panel()
        btnDel = New Button()
        btnCancel = New Button()
        btnClear = New Button()
        btnEnter = New Button()
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
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(47, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 19)
        Label1.TabIndex = 0
        Label1.Text = "Account Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(47, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 1
        Label2.Text = "PIN:"
        ' 
        ' txtAccNum
        ' 
        txtAccNum.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtAccNum.Location = New Point(207, 77)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(200, 25)
        txtAccNum.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(207, 127)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(200, 25)
        txtPIN.TabIndex = 3
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Green
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(207, 177)
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
        Panel1.Controls.Add(btnDel)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnEnter)
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
        Panel1.Location = New Point(0, 230)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(493, 169)
        Panel1.TabIndex = 8
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.Chocolate
        btnDel.FlatAppearance.BorderSize = 0
        btnDel.FlatStyle = FlatStyle.Flat
        btnDel.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDel.ForeColor = Color.White
        btnDel.Location = New Point(299, 125)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(80, 24)
        btnDel.TabIndex = 39
        btnDel.Text = "Del"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(300, 23)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(80, 24)
        btnCancel.TabIndex = 38
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Yellow
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12F)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(300, 56)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 24)
        btnClear.TabIndex = 37
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.ForestGreen
        btnEnter.FlatAppearance.BorderSize = 0
        btnEnter.FlatStyle = FlatStyle.Flat
        btnEnter.Font = New Font("Arial Rounded MT Bold", 12F)
        btnEnter.ForeColor = Color.White
        btnEnter.Location = New Point(300, 89)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(80, 27)
        btnEnter.TabIndex = 14
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.BorderStyle = BorderStyle.Fixed3D
        lbl0.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl0.ForeColor = SystemColors.ControlLight
        lbl0.Location = New Point(132, 124)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(78, 24)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.DimGray
        lblEmpty.BorderStyle = BorderStyle.Fixed3D
        lblEmpty.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lblEmpty.Location = New Point(52, 124)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(77, 24)
        lblEmpty.TabIndex = 31
        lblEmpty.Text = "             "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.BorderStyle = BorderStyle.Fixed3D
        lbl9.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl9.ForeColor = SystemColors.ControlLight
        lbl9.Location = New Point(216, 91)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(78, 24)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lblEmpty1
        ' 
        lblEmpty1.AutoSize = True
        lblEmpty1.BackColor = Color.DimGray
        lblEmpty1.BorderStyle = BorderStyle.Fixed3D
        lblEmpty1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lblEmpty1.Location = New Point(216, 125)
        lblEmpty1.Name = "lblEmpty1"
        lblEmpty1.Size = New Size(77, 24)
        lblEmpty1.TabIndex = 29
        lblEmpty1.Text = "             "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.BorderStyle = BorderStyle.Fixed3D
        lbl8.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl8.ForeColor = SystemColors.ControlLight
        lbl8.Location = New Point(132, 90)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(78, 24)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.BorderStyle = BorderStyle.Fixed3D
        lbl7.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl7.ForeColor = SystemColors.ControlLight
        lbl7.Location = New Point(52, 90)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(78, 24)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl2.ForeColor = SystemColors.ControlLight
        lbl2.Location = New Point(132, 23)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(78, 24)
        lbl2.TabIndex = 26
        lbl2.Text = "      2     "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl4.ForeColor = SystemColors.ControlLight
        lbl4.Location = New Point(51, 55)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(78, 24)
        lbl4.TabIndex = 25
        lbl4.Text = "      4     "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl5.ForeColor = SystemColors.ControlLight
        lbl5.Location = New Point(132, 55)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(78, 24)
        lbl5.TabIndex = 24
        lbl5.Text = "      5     "
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl3.ForeColor = SystemColors.ControlLight
        lbl3.Location = New Point(216, 23)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(78, 24)
        lbl3.TabIndex = 23
        lbl3.Text = "      3     "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.BorderStyle = BorderStyle.Fixed3D
        lbl6.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl6.ForeColor = SystemColors.ControlLight
        lbl6.Location = New Point(216, 56)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(78, 24)
        lbl6.TabIndex = 22
        lbl6.Text = "      6     "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl1.ForeColor = SystemColors.ControlLight
        lbl1.Location = New Point(51, 23)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(78, 24)
        lbl1.TabIndex = 21
        lbl1.Text = "      1     "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(769, 482)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtAccNum)
        Panel2.Controls.Add(txtPIN)
        Panel2.Location = New Point(79, 53)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(604, 399)
        Panel2.TabIndex = 37
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Window
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(385, 78)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(21, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(7, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(436, 33)
        Label4.TabIndex = 13
        Label4.Text = "Welcome to QUICKCASH ATM"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Image = My.Resources.Resources.Security_Green_Icon_removebg_preview
        PictureBox2.Location = New Point(385, 128)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightGray
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox4)
        Panel3.ForeColor = SystemColors.ControlLight
        Panel3.Location = New Point(445, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(159, 399)
        Panel3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkOliveGreen
        Label3.Location = New Point(-1, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 56)
        Label3.TabIndex = 12
        Label3.Text = "QUICKCASH " & vbCrLf & "ATM"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(5, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(151, 130)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(765, 479)
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
