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
        lblHeader = New Label()
        Label1 = New Label()
        txtAmount = New TextBox()
        btnWithdraw = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblHeader.Location = New Point(280, 40)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(157, 37)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Withdrawal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(104, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter Withdrawal Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 14F)
        txtAmount.ForeColor = Color.Gray
        txtAmount.Location = New Point(360, 127)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(180, 32)
        txtAmount.TabIndex = 2
        txtAmount.Text = "Enter amount here"
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btnWithdraw.FlatAppearance.BorderSize = 0
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Location = New Point(339, 190)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(106, 35)
        btnWithdraw.TabIndex = 3
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(455, 190)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(85, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmWithdrawal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(700, 350)
        Controls.Add(btnCancel)
        Controls.Add(btnWithdraw)
        Controls.Add(txtAmount)
        Controls.Add(Label1)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmWithdrawal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdrawal"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCancel As Button

End Class
