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
        SuspendLayout()
        ' 
        ' btnBalanceInquiry
        ' 
        btnBalanceInquiry.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnBalanceInquiry.FlatAppearance.BorderSize = 0
        btnBalanceInquiry.FlatStyle = FlatStyle.Flat
        btnBalanceInquiry.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnBalanceInquiry.ForeColor = Color.White
        btnBalanceInquiry.Location = New Point(100, 80)
        btnBalanceInquiry.Name = "btnBalanceInquiry"
        btnBalanceInquiry.Size = New Size(180, 40)
        btnBalanceInquiry.TabIndex = 0
        btnBalanceInquiry.Text = "Balance Inquiry"
        btnBalanceInquiry.UseVisualStyleBackColor = False
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnWithdrawal.FlatAppearance.BorderSize = 0
        btnWithdrawal.FlatStyle = FlatStyle.Flat
        btnWithdrawal.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnWithdrawal.ForeColor = Color.White
        btnWithdrawal.Location = New Point(100, 140)
        btnWithdrawal.Name = "btnWithdrawal"
        btnWithdrawal.Size = New Size(180, 40)
        btnWithdrawal.TabIndex = 1
        btnWithdrawal.Text = "Withdrawal"
        btnWithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btnMiniStatement
        ' 
        btnMiniStatement.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnMiniStatement.FlatAppearance.BorderSize = 0
        btnMiniStatement.FlatStyle = FlatStyle.Flat
        btnMiniStatement.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnMiniStatement.ForeColor = Color.White
        btnMiniStatement.Location = New Point(100, 200)
        btnMiniStatement.Name = "btnMiniStatement"
        btnMiniStatement.Size = New Size(180, 40)
        btnMiniStatement.TabIndex = 2
        btnMiniStatement.Text = "Mini Statement"
        btnMiniStatement.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(320, 80)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(180, 40)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnFundTransfer
        ' 
        btnFundTransfer.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnFundTransfer.FlatAppearance.BorderSize = 0
        btnFundTransfer.FlatStyle = FlatStyle.Flat
        btnFundTransfer.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnFundTransfer.ForeColor = Color.White
        btnFundTransfer.Location = New Point(320, 140)
        btnFundTransfer.Name = "btnFundTransfer"
        btnFundTransfer.Size = New Size(180, 40)
        btnFundTransfer.TabIndex = 4
        btnFundTransfer.Text = "Fund Transfer"
        btnFundTransfer.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(320, 200)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(180, 40)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(600, 350)
        Controls.Add(btnLogout)
        Controls.Add(btnFundTransfer)
        Controls.Add(btnDeposit)
        Controls.Add(btnMiniStatement)
        Controls.Add(btnWithdrawal)
        Controls.Add(btnBalanceInquiry)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banking Operations"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents btnLogout As Button

End Class
