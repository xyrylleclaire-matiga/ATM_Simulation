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
        Label1 = New Label()
        txtAmount = New TextBox()
        btnWithdraw = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        lbl3 = New Label()
        btnDel = New Label()
        lbl1 = New Label()
        lbl6 = New Label()
        lblClear = New Label()
        lbl5 = New Label()
        lbl0 = New Label()
        lbl4 = New Label()
        lbl2 = New Label()
        lbl9 = New Label()
        lbl7 = New Label()
        lbl8 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(184, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 23)
        Label1.TabIndex = 1
        Label1.Text = "Enter Withdrawal Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.ForeColor = Color.Black
        txtAmount.Location = New Point(219, 134)
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
        btnWithdraw.Location = New Point(124, 193)
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
        btnCancel.Location = New Point(308, 193)
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
        PictureBox1.Size = New Size(769, 482)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtAmount)
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnWithdraw)
        Panel2.Location = New Point(81, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(604, 390)
        Panel2.TabIndex = 11
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Controls.Add(lbl3)
        Panel3.Controls.Add(btnDel)
        Panel3.Controls.Add(lbl1)
        Panel3.Controls.Add(lbl6)
        Panel3.Controls.Add(lblClear)
        Panel3.Controls.Add(lbl5)
        Panel3.Controls.Add(lbl0)
        Panel3.Controls.Add(lbl4)
        Panel3.Controls.Add(lbl2)
        Panel3.Controls.Add(lbl9)
        Panel3.Controls.Add(lbl7)
        Panel3.Controls.Add(lbl8)
        Panel3.Location = New Point(0, 234)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(604, 156)
        Panel3.TabIndex = 11
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl3.ForeColor = SystemColors.ButtonHighlight
        lbl3.Location = New Point(352, 15)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(78, 24)
        lbl3.TabIndex = 23
        lbl3.Text = "      3     "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(352, 118)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(75, 22)
        btnDel.TabIndex = 35
        btnDel.Text = "    Del   "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl1.ForeColor = SystemColors.ButtonHighlight
        lbl1.Location = New Point(184, 16)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(78, 24)
        lbl1.TabIndex = 21
        lbl1.Text = "      1     "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.BorderStyle = BorderStyle.Fixed3D
        lbl6.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl6.ForeColor = SystemColors.ButtonHighlight
        lbl6.Location = New Point(352, 47)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(78, 24)
        lbl6.TabIndex = 22
        lbl6.Text = "      6     "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lblClear.Location = New Point(185, 116)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(79, 22)
        lblClear.TabIndex = 33
        lblClear.Text = "  Clear  "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl5.ForeColor = SystemColors.ButtonHighlight
        lbl5.Location = New Point(268, 47)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(78, 24)
        lbl5.TabIndex = 24
        lbl5.Text = "      5     "
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.BorderStyle = BorderStyle.Fixed3D
        lbl0.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl0.ForeColor = SystemColors.ButtonHighlight
        lbl0.Location = New Point(268, 116)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(78, 24)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl4.ForeColor = SystemColors.ButtonHighlight
        lbl4.Location = New Point(184, 48)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(78, 24)
        lbl4.TabIndex = 25
        lbl4.Text = "      4     "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl2.ForeColor = SystemColors.ButtonHighlight
        lbl2.Location = New Point(268, 15)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(78, 24)
        lbl2.TabIndex = 26
        lbl2.Text = "      2     "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.BorderStyle = BorderStyle.Fixed3D
        lbl9.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl9.ForeColor = SystemColors.ButtonHighlight
        lbl9.Location = New Point(352, 82)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(78, 24)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.BorderStyle = BorderStyle.Fixed3D
        lbl7.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl7.ForeColor = SystemColors.ButtonHighlight
        lbl7.Location = New Point(185, 83)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(78, 24)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.BorderStyle = BorderStyle.Fixed3D
        lbl8.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl8.ForeColor = SystemColors.ButtonHighlight
        lbl8.Location = New Point(268, 82)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(78, 24)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-8, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(612, 51)
        Button1.TabIndex = 10
        Button1.Text = "  Withdraw"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmWithdrawal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(767, 480)
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl3 As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lblClear As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl8 As Label

End Class
