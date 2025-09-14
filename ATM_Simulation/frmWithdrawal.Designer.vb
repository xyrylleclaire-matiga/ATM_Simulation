<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWithdrawal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWithdrawal))
        Label1 = New Label()
        txtAmount = New TextBox()
        btnWithdraw = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel1 = New Panel()
        lblDel = New Label()
        lblClear = New Label()
        Button3 = New Button()
        Button4 = New Button()
        btnDel = New Button()
        btnClickClear = New Button()
        lblEmptyy = New Label()
        lblEmpty = New Label()
        lblNo0 = New Label()
        lblNo9 = New Label()
        lblNo8 = New Label()
        lblNo7 = New Label()
        lblNo4 = New Label()
        lblNo5 = New Label()
        lblNo6 = New Label()
        lblNo3 = New Label()
        lblNo2 = New Label()
        lblNo1 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(196, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 23)
        Label1.TabIndex = 1
        Label1.Text = "Enter Withdrawal Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.ForeColor = Color.Black
        txtAmount.Location = New Point(231, 124)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(180, 29)
        txtAmount.TabIndex = 2
        txtAmount.Text = "0.00"
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.ForestGreen
        btnWithdraw.FlatAppearance.BorderSize = 0
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnWithdraw.ForeColor = Color.Transparent
        btnWithdraw.Location = New Point(150, 184)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(178, 35)
        btnWithdraw.TabIndex = 3
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(334, 184)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(178, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(820, 524)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtAmount)
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnWithdraw)
        Panel2.Location = New Point(81, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(649, 407)
        Panel2.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-11, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(674, 51)
        Button1.TabIndex = 42
        Button1.Text = "   Withdraw "
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(lblDel)
        Panel1.Controls.Add(lblClear)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(btnDel)
        Panel1.Controls.Add(btnClickClear)
        Panel1.Controls.Add(lblEmptyy)
        Panel1.Controls.Add(lblEmpty)
        Panel1.Controls.Add(lblNo0)
        Panel1.Controls.Add(lblNo9)
        Panel1.Controls.Add(lblNo8)
        Panel1.Controls.Add(lblNo7)
        Panel1.Controls.Add(lblNo4)
        Panel1.Controls.Add(lblNo5)
        Panel1.Controls.Add(lblNo6)
        Panel1.Controls.Add(lblNo3)
        Panel1.Controls.Add(lblNo2)
        Panel1.Controls.Add(lblNo1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(81, 291)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(649, 173)
        Panel1.TabIndex = 68
        ' 
        ' lblDel
        ' 
        lblDel.AutoSize = True
        lblDel.BackColor = Color.DarkKhaki
        lblDel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDel.Location = New Point(383, 56)
        lblDel.Name = "lblDel"
        lblDel.Size = New Size(65, 18)
        lblDel.TabIndex = 71
        lblDel.Text = "   DEL   "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblClear.Location = New Point(383, 14)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(65, 18)
        lblClear.TabIndex = 44
        lblClear.Text = "CLEAR"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Location = New Point(378, 128)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 38)
        Button3.TabIndex = 69
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(378, 88)
        Button4.Name = "Button4"
        Button4.Size = New Size(76, 38)
        Button4.TabIndex = 68
        Button4.Text = " "
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.DarkKhaki
        btnDel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnDel.Location = New Point(378, 46)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(76, 38)
        btnDel.TabIndex = 67
        btnDel.Text = "DEL"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' btnClickClear
        ' 
        btnClickClear.BackColor = Color.Yellow
        btnClickClear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClickClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClickClear.Location = New Point(378, 5)
        btnClickClear.Name = "btnClickClear"
        btnClickClear.Size = New Size(76, 38)
        btnClickClear.TabIndex = 66
        btnClickClear.Text = "CLEAR"
        btnClickClear.UseVisualStyleBackColor = False
        ' 
        ' lblEmptyy
        ' 
        lblEmptyy.AutoSize = True
        lblEmptyy.BackColor = Color.WhiteSmoke
        lblEmptyy.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmptyy.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmptyy.Location = New Point(334, 137)
        lblEmptyy.Name = "lblEmptyy"
        lblEmptyy.Size = New Size(20, 22)
        lblEmptyy.TabIndex = 63
        lblEmptyy.Text = "  "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.WhiteSmoke
        lblEmpty.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpty.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmpty.Location = New Point(252, 137)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(20, 22)
        lblEmpty.TabIndex = 62
        lblEmpty.Text = "  "
        ' 
        ' lblNo0
        ' 
        lblNo0.AutoSize = True
        lblNo0.BackColor = Color.WhiteSmoke
        lblNo0.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo0.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo0.Location = New Point(293, 137)
        lblNo0.Name = "lblNo0"
        lblNo0.Size = New Size(22, 24)
        lblNo0.TabIndex = 61
        lblNo0.Text = "0"
        ' 
        ' lblNo9
        ' 
        lblNo9.AutoSize = True
        lblNo9.BackColor = Color.WhiteSmoke
        lblNo9.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo9.Location = New Point(340, 95)
        lblNo9.Name = "lblNo9"
        lblNo9.Size = New Size(22, 24)
        lblNo9.TabIndex = 60
        lblNo9.Text = "9"
        ' 
        ' lblNo8
        ' 
        lblNo8.AutoSize = True
        lblNo8.BackColor = Color.WhiteSmoke
        lblNo8.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo8.Location = New Point(294, 95)
        lblNo8.Name = "lblNo8"
        lblNo8.Size = New Size(22, 24)
        lblNo8.TabIndex = 59
        lblNo8.Text = "8"
        ' 
        ' lblNo7
        ' 
        lblNo7.AutoSize = True
        lblNo7.BackColor = Color.WhiteSmoke
        lblNo7.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo7.Location = New Point(247, 95)
        lblNo7.Name = "lblNo7"
        lblNo7.Size = New Size(22, 24)
        lblNo7.TabIndex = 58
        lblNo7.Text = "7"
        ' 
        ' lblNo4
        ' 
        lblNo4.AutoSize = True
        lblNo4.BackColor = Color.WhiteSmoke
        lblNo4.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo4.Location = New Point(247, 54)
        lblNo4.Name = "lblNo4"
        lblNo4.Size = New Size(22, 24)
        lblNo4.TabIndex = 55
        lblNo4.Text = "4"
        ' 
        ' lblNo5
        ' 
        lblNo5.AutoSize = True
        lblNo5.BackColor = Color.WhiteSmoke
        lblNo5.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo5.Location = New Point(293, 54)
        lblNo5.Name = "lblNo5"
        lblNo5.Size = New Size(22, 24)
        lblNo5.TabIndex = 56
        lblNo5.Text = "5"
        ' 
        ' lblNo6
        ' 
        lblNo6.AutoSize = True
        lblNo6.BackColor = Color.WhiteSmoke
        lblNo6.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo6.Location = New Point(340, 54)
        lblNo6.Name = "lblNo6"
        lblNo6.Size = New Size(22, 24)
        lblNo6.TabIndex = 57
        lblNo6.Text = "6"
        ' 
        ' lblNo3
        ' 
        lblNo3.AutoSize = True
        lblNo3.BackColor = Color.WhiteSmoke
        lblNo3.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo3.Location = New Point(340, 12)
        lblNo3.Name = "lblNo3"
        lblNo3.Size = New Size(22, 24)
        lblNo3.TabIndex = 54
        lblNo3.Text = "3"
        ' 
        ' lblNo2
        ' 
        lblNo2.AutoSize = True
        lblNo2.BackColor = Color.WhiteSmoke
        lblNo2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo2.Location = New Point(293, 12)
        lblNo2.Name = "lblNo2"
        lblNo2.Size = New Size(22, 24)
        lblNo2.TabIndex = 53
        lblNo2.Text = "2"
        ' 
        ' lblNo1
        ' 
        lblNo1.AutoSize = True
        lblNo1.BackColor = Color.WhiteSmoke
        lblNo1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo1.Location = New Point(247, 12)
        lblNo1.Name = "lblNo1"
        lblNo1.Size = New Size(22, 24)
        lblNo1.TabIndex = 35
        lblNo1.Text = "1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(234, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 169)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 52
        PictureBox2.TabStop = False
        ' 
        ' frmWithdrawal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(815, 523)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmWithdrawal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdrawal"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClickClear As Button
    Friend WithEvents lblEmptyy As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lblNo0 As Label
    Friend WithEvents lblNo9 As Label
    Friend WithEvents lblNo8 As Label
    Friend WithEvents lblNo7 As Label
    Friend WithEvents lblNo4 As Label
    Friend WithEvents lblNo5 As Label
    Friend WithEvents lblNo6 As Label
    Friend WithEvents lblNo3 As Label
    Friend WithEvents lblNo2 As Label
    Friend WithEvents lblNo1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblClear As Label
    Friend WithEvents lblDel As Label

End Class
