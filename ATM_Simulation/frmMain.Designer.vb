<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        btnLogout = New Button()
        btnBalanceInquiry = New Button()
        btnDeposit = New Button()
        btnWithdrawal = New Button()
        btnMiniStatement = New Button()
        btnFundTransfer = New Button()
        TextBox2 = New TextBox()
        lblUser = New Label()
        lbl = New Label()
        lblUserAccountNumber = New Label()
        lblAccountNumberDisplay = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(818, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(btnLogout)
        Panel2.Controls.Add(btnBalanceInquiry)
        Panel2.Controls.Add(btnDeposit)
        Panel2.Controls.Add(btnWithdrawal)
        Panel2.Controls.Add(btnMiniStatement)
        Panel2.Controls.Add(btnFundTransfer)
        Panel2.Location = New Point(54, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(550, 263)
        Panel2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(14, -17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(128, 20)
        TextBox1.TabIndex = 10
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Brown
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(298, 180)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(232, 51)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnBalanceInquiry
        ' 
        btnBalanceInquiry.BackColor = Color.DarkOliveGreen
        btnBalanceInquiry.FlatAppearance.BorderSize = 0
        btnBalanceInquiry.FlatStyle = FlatStyle.Flat
        btnBalanceInquiry.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBalanceInquiry.ForeColor = Color.White
        btnBalanceInquiry.Location = New Point(14, 28)
        btnBalanceInquiry.Margin = New Padding(3, 4, 3, 4)
        btnBalanceInquiry.Name = "btnBalanceInquiry"
        btnBalanceInquiry.Size = New Size(232, 51)
        btnBalanceInquiry.TabIndex = 0
        btnBalanceInquiry.Text = "Balance Inquiry"
        btnBalanceInquiry.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.DarkOliveGreen
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(298, 28)
        btnDeposit.Margin = New Padding(3, 4, 3, 4)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(232, 51)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.BackColor = Color.DarkOliveGreen
        btnWithdrawal.FlatAppearance.BorderSize = 0
        btnWithdrawal.FlatStyle = FlatStyle.Flat
        btnWithdrawal.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdrawal.ForeColor = Color.White
        btnWithdrawal.Location = New Point(14, 104)
        btnWithdrawal.Margin = New Padding(3, 4, 3, 4)
        btnWithdrawal.Name = "btnWithdrawal"
        btnWithdrawal.Size = New Size(232, 51)
        btnWithdrawal.TabIndex = 1
        btnWithdrawal.Text = "Withdrawal"
        btnWithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btnMiniStatement
        ' 
        btnMiniStatement.BackColor = Color.DarkOliveGreen
        btnMiniStatement.FlatAppearance.BorderSize = 0
        btnMiniStatement.FlatStyle = FlatStyle.Flat
        btnMiniStatement.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMiniStatement.ForeColor = Color.White
        btnMiniStatement.Location = New Point(14, 180)
        btnMiniStatement.Margin = New Padding(3, 4, 3, 4)
        btnMiniStatement.Name = "btnMiniStatement"
        btnMiniStatement.Size = New Size(232, 51)
        btnMiniStatement.TabIndex = 2
        btnMiniStatement.Text = "Mini Statement"
        btnMiniStatement.UseVisualStyleBackColor = False
        ' 
        ' btnFundTransfer
        ' 
        btnFundTransfer.BackColor = Color.DarkOliveGreen
        btnFundTransfer.FlatAppearance.BorderSize = 0
        btnFundTransfer.FlatStyle = FlatStyle.Flat
        btnFundTransfer.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFundTransfer.ForeColor = Color.White
        btnFundTransfer.Location = New Point(298, 104)
        btnFundTransfer.Margin = New Padding(3, 4, 3, 4)
        btnFundTransfer.Name = "btnFundTransfer"
        btnFundTransfer.Size = New Size(232, 51)
        btnFundTransfer.TabIndex = 4
        btnFundTransfer.Text = "Fund Transfer"
        btnFundTransfer.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(263, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(118, 20)
        TextBox2.TabIndex = 11
        TextBox2.Text = "    Transaction"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(98, 8)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(15, 24)
        lblUser.TabIndex = 13
        lblUser.Text = " "
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lbl.Location = New Point(132, 42)
        lbl.Name = "lbl"
        lbl.Size = New Size(125, 16)
        lbl.TabIndex = 14
        lbl.Text = "Account Number: "
        ' 
        ' lblUserAccountNumber
        ' 
        lblUserAccountNumber.AutoSize = True
        lblUserAccountNumber.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserAccountNumber.Location = New Point(310, 385)
        lblUserAccountNumber.Name = "lblUserAccountNumber"
        lblUserAccountNumber.Size = New Size(15, 23)
        lblUserAccountNumber.TabIndex = 15
        lblUserAccountNumber.Text = " "
        ' 
        ' lblAccountNumberDisplay
        ' 
        lblAccountNumberDisplay.AutoSize = True
        lblAccountNumberDisplay.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lblAccountNumberDisplay.Location = New Point(251, 42)
        lblAccountNumberDisplay.Name = "lblAccountNumberDisplay"
        lblAccountNumberDisplay.Size = New Size(11, 16)
        lblAccountNumberDisplay.TabIndex = 16
        lblAccountNumberDisplay.Text = " "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Gemini_Generated_Image_reg5dyreg5dyreg5_removebg_preview1
        PictureBox2.Location = New Point(23, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(73, 64)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lblUserAccountNumber)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(82, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(648, 408)
        Panel1.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Linen
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(lblAccountNumberDisplay)
        Panel3.Controls.Add(lblUser)
        Panel3.Controls.Add(lbl)
        Panel3.Location = New Point(-23, 24)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(671, 64)
        Panel3.TabIndex = 18
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Abstract_credit_cards_icon_by_Flower_Travelin_Man_on__creativemarket_removebg_preview2
        PictureBox3.Location = New Point(103, 38)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(33, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(815, 523)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banking Operations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblUserAccountNumber As Label
    Friend WithEvents lblAccountNumberDisplay As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox

End Class
