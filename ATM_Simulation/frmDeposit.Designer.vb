<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeposit
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
        txtDepositAmount = New TextBox()
        btnDeposit = New Button()
        btnCancel = New Button()
        Panel1 = New Panel()
        lbl0 = New Label()
        lbl9 = New Label()
        lbl8 = New Label()
        btnDel = New Label()
        lbl7 = New Label()
        lblClear = New Label()
        lbl2 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl3 = New Label()
        lbl6 = New Label()
        lbl1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(101, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 23)
        Label1.TabIndex = 1
        Label1.Text = "Deposit Amount:"
        ' 
        ' txtDepositAmount
        ' 
        txtDepositAmount.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDepositAmount.Location = New Point(271, 92)
        txtDepositAmount.Name = "txtDepositAmount"
        txtDepositAmount.Size = New Size(200, 30)
        txtDepositAmount.TabIndex = 2
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.ForestGreen
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(275, 145)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(95, 35)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(376, 145)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(lbl0)
        Panel1.Controls.Add(lbl9)
        Panel1.Controls.Add(lbl8)
        Panel1.Controls.Add(btnDel)
        Panel1.Controls.Add(lbl7)
        Panel1.Controls.Add(lblClear)
        Panel1.Controls.Add(lbl2)
        Panel1.Controls.Add(lbl4)
        Panel1.Controls.Add(lbl5)
        Panel1.Controls.Add(lbl3)
        Panel1.Controls.Add(lbl6)
        Panel1.Controls.Add(lbl1)
        Panel1.Location = New Point(0, 196)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(597, 171)
        Panel1.TabIndex = 9
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.BorderStyle = BorderStyle.Fixed3D
        lbl0.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl0.ForeColor = SystemColors.ButtonHighlight
        lbl0.Location = New Point(251, 122)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(91, 24)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.BorderStyle = BorderStyle.Fixed3D
        lbl9.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl9.ForeColor = SystemColors.ButtonHighlight
        lbl9.Location = New Point(346, 88)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(91, 24)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.BorderStyle = BorderStyle.Fixed3D
        lbl8.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl8.ForeColor = SystemColors.ButtonHighlight
        lbl8.Location = New Point(251, 88)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(91, 24)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.BorderStyle = BorderStyle.Fixed3D
        btnDel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(352, 123)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(87, 25)
        btnDel.TabIndex = 39
        btnDel.Text = "     Del    "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.BorderStyle = BorderStyle.Fixed3D
        lbl7.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl7.ForeColor = SystemColors.ButtonHighlight
        lbl7.Location = New Point(157, 88)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(91, 24)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.BorderStyle = BorderStyle.Fixed3D
        lblClear.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblClear.Location = New Point(156, 121)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(88, 25)
        lblClear.TabIndex = 38
        lblClear.Text = "  Clear   "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl2.ForeColor = SystemColors.ButtonHighlight
        lbl2.Location = New Point(251, 21)
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
        lbl4.ForeColor = SystemColors.ButtonHighlight
        lbl4.Location = New Point(156, 53)
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
        lbl5.ForeColor = SystemColors.ButtonHighlight
        lbl5.Location = New Point(251, 53)
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
        lbl3.ForeColor = SystemColors.ButtonHighlight
        lbl3.Location = New Point(346, 21)
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
        lbl6.ForeColor = SystemColors.ButtonHighlight
        lbl6.Location = New Point(346, 53)
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
        lbl1.ForeColor = SystemColors.ButtonHighlight
        lbl1.Location = New Point(156, 21)
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
        PictureBox1.Size = New Size(768, 484)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtDepositAmount)
        Panel2.Controls.Add(btnDeposit)
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(84, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(597, 367)
        Panel2.TabIndex = 42
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-12, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(655, 37)
        Button1.TabIndex = 12
        Button1.Text = "   Deposit:"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(767, 480)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmDeposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblClear As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button

End Class
