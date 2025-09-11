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
        btnBalanceInquiry = New Button()
        btnWithdrawal = New Button()
        btnMiniStatement = New Button()
        btnDeposit = New Button()
        btnFundTransfer = New Button()
        btnLogout = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBalanceInquiry
        ' 
        btnBalanceInquiry.BackColor = Color.DarkOliveGreen
        btnBalanceInquiry.FlatAppearance.BorderSize = 0
        btnBalanceInquiry.FlatStyle = FlatStyle.Flat
        btnBalanceInquiry.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBalanceInquiry.ForeColor = Color.White
        btnBalanceInquiry.Location = New Point(33, 83)
        btnBalanceInquiry.Margin = New Padding(3, 4, 3, 4)
        btnBalanceInquiry.Name = "btnBalanceInquiry"
        btnBalanceInquiry.Size = New Size(232, 51)
        btnBalanceInquiry.TabIndex = 0
        btnBalanceInquiry.Text = "Balance Inquiry"
        btnBalanceInquiry.UseVisualStyleBackColor = False
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.BackColor = Color.DarkOliveGreen
        btnWithdrawal.FlatAppearance.BorderSize = 0
        btnWithdrawal.FlatStyle = FlatStyle.Flat
        btnWithdrawal.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnWithdrawal.ForeColor = Color.White
        btnWithdrawal.Location = New Point(33, 159)
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
        btnMiniStatement.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnMiniStatement.ForeColor = Color.White
        btnMiniStatement.Location = New Point(33, 235)
        btnMiniStatement.Margin = New Padding(3, 4, 3, 4)
        btnMiniStatement.Name = "btnMiniStatement"
        btnMiniStatement.Size = New Size(232, 51)
        btnMiniStatement.TabIndex = 2
        btnMiniStatement.Text = "Mini Statement"
        btnMiniStatement.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.DarkOliveGreen
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(317, 83)
        btnDeposit.Margin = New Padding(3, 4, 3, 4)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(232, 51)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnFundTransfer
        ' 
        btnFundTransfer.BackColor = Color.DarkOliveGreen
        btnFundTransfer.FlatAppearance.BorderSize = 0
        btnFundTransfer.FlatStyle = FlatStyle.Flat
        btnFundTransfer.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnFundTransfer.ForeColor = Color.White
        btnFundTransfer.Location = New Point(317, 159)
        btnFundTransfer.Margin = New Padding(3, 4, 3, 4)
        btnFundTransfer.Name = "btnFundTransfer"
        btnFundTransfer.Size = New Size(232, 51)
        btnFundTransfer.TabIndex = 4
        btnFundTransfer.Text = "Fund Transfer"
        btnFundTransfer.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Brown
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(317, 235)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(232, 51)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(748, 482)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnBalanceInquiry)
        Panel1.Controls.Add(btnWithdrawal)
        Panel1.Controls.Add(btnFundTransfer)
        Panel1.Controls.Add(btnMiniStatement)
        Panel1.Controls.Add(btnDeposit)
        Panel1.Location = New Point(82, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(583, 367)
        Panel1.TabIndex = 7
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(743, 479)
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
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel

End Class
