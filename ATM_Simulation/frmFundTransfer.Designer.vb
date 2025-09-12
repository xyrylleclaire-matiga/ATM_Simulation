<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFundTransfer
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnTransfer = New Button()
        txtAmountTransfer = New TextBox()
        txtTargetAccount = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        lblClear = New Label()
        lbl3 = New Label()
        lbl0 = New Label()
        lbl1 = New Label()
        lbl9 = New Label()
        lbl6 = New Label()
        lbl8 = New Label()
        lbl5 = New Label()
        btnDel = New Label()
        lbl4 = New Label()
        lbl7 = New Label()
        lbl2 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(818, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(lblClear)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnTransfer)
        Panel1.Controls.Add(txtAmountTransfer)
        Panel1.Controls.Add(txtTargetAccount)
        Panel1.Controls.Add(btnDel)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(84, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(642, 407)
        Panel1.TabIndex = 8
        ' 
        ' btnTransfer
        ' 
        btnTransfer.BackColor = Color.DarkOliveGreen
        btnTransfer.FlatAppearance.BorderSize = 0
        btnTransfer.FlatStyle = FlatStyle.Flat
        btnTransfer.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTransfer.ForeColor = Color.White
        btnTransfer.Location = New Point(356, 135)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(131, 35)
        btnTransfer.TabIndex = 48
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = False
        ' 
        ' txtAmountTransfer
        ' 
        txtAmountTransfer.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmountTransfer.Location = New Point(79, 189)
        txtAmountTransfer.Name = "txtAmountTransfer"
        txtAmountTransfer.Size = New Size(244, 29)
        txtAmountTransfer.TabIndex = 44
        ' 
        ' txtTargetAccount
        ' 
        txtTargetAccount.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTargetAccount.Location = New Point(79, 116)
        txtTargetAccount.Name = "txtTargetAccount"
        txtTargetAccount.Size = New Size(244, 29)
        txtTargetAccount.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(493, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 35)
        Button1.TabIndex = 43
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOliveGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(-4, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(657, 51)
        Button2.TabIndex = 42
        Button2.Text = "  Fund Transfer"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label3.Location = New Point(17, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 23)
        Label3.TabIndex = 49
        Label3.Text = "Send to:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(17, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 23)
        Label1.TabIndex = 50
        Label1.Text = "Amount Transfer:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(lbl3)
        Panel3.Controls.Add(lbl0)
        Panel3.Controls.Add(lbl1)
        Panel3.Controls.Add(lbl9)
        Panel3.Controls.Add(lbl6)
        Panel3.Controls.Add(lbl8)
        Panel3.Controls.Add(lbl5)
        Panel3.Controls.Add(lbl4)
        Panel3.Controls.Add(lbl7)
        Panel3.Controls.Add(lbl2)
        Panel3.Location = New Point(260, 242)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(172, 151)
        Panel3.TabIndex = 51
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Goldenrod
        lblClear.BorderStyle = BorderStyle.Fixed3D
        lblClear.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClear.Location = New Point(356, 194)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(76, 24)
        lblClear.TabIndex = 40
        lblClear.Text = "  Clear "
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl3.ForeColor = SystemColors.ButtonHighlight
        lbl3.Location = New Point(113, 12)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(43, 24)
        lbl3.TabIndex = 23
        lbl3.Text = "  3  "
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.BorderStyle = BorderStyle.Fixed3D
        lbl0.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl0.ForeColor = SystemColors.ButtonHighlight
        lbl0.Location = New Point(64, 113)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(43, 24)
        lbl0.TabIndex = 32
        lbl0.Text = "  0  "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl1.ForeColor = SystemColors.ButtonHighlight
        lbl1.Location = New Point(16, 12)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(43, 24)
        lbl1.TabIndex = 21
        lbl1.Text = "  1  "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.BorderStyle = BorderStyle.Fixed3D
        lbl9.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl9.ForeColor = SystemColors.ButtonHighlight
        lbl9.Location = New Point(113, 79)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(43, 24)
        lbl9.TabIndex = 30
        lbl9.Text = "  9  "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.BorderStyle = BorderStyle.Fixed3D
        lbl6.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl6.ForeColor = SystemColors.ButtonHighlight
        lbl6.Location = New Point(113, 44)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(43, 24)
        lbl6.TabIndex = 22
        lbl6.Text = "  6  "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.BorderStyle = BorderStyle.Fixed3D
        lbl8.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl8.ForeColor = SystemColors.ButtonHighlight
        lbl8.Location = New Point(64, 79)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(43, 24)
        lbl8.TabIndex = 28
        lbl8.Text = "  8  "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl5.ForeColor = SystemColors.ButtonHighlight
        lbl5.Location = New Point(64, 44)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(43, 24)
        lbl5.TabIndex = 24
        lbl5.Text = "  5  "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.BorderStyle = BorderStyle.Fixed3D
        btnDel.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(438, 192)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(77, 24)
        btnDel.TabIndex = 39
        btnDel.Text = "    Del   "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl4.ForeColor = SystemColors.ButtonHighlight
        lbl4.Location = New Point(14, 44)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(43, 24)
        lbl4.TabIndex = 25
        lbl4.Text = "  4  "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.BorderStyle = BorderStyle.Fixed3D
        lbl7.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl7.ForeColor = SystemColors.ButtonHighlight
        lbl7.Location = New Point(15, 79)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(43, 24)
        lbl7.TabIndex = 27
        lbl7.Text = "  7  "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Arial Rounded MT Bold", 14.25F)
        lbl2.ForeColor = SystemColors.ButtonHighlight
        lbl2.Location = New Point(64, 12)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(43, 24)
        lbl2.TabIndex = 26
        lbl2.Text = "  2  "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DimGray
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(113, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 24)
        Label2.TabIndex = 33
        Label2.Text = "      "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DimGray
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(16, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 24)
        Label4.TabIndex = 34
        Label4.Text = "      "
        ' 
        ' frmFundTransfer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(815, 523)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frmFundTransfer"
        Text = "frmFundTransfer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTargetAccount As TextBox
    Friend WithEvents txtAmountTransfer As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblClear As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
