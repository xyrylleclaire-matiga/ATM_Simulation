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
        lblHeader = New Label()
        Label1 = New Label()
        txtDepositAmount = New TextBox()
        btnDeposit = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblHeader.Location = New Point(320, 40)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(111, 37)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Deposit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F)
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(150, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 25)
        Label1.TabIndex = 1
        Label1.Text = "Deposit Amount:"
        ' 
        ' txtDepositAmount
        ' 
        txtDepositAmount.Font = New Font("Segoe UI", 14.0F)
        txtDepositAmount.Location = New Point(320, 137)
        txtDepositAmount.Name = "txtDepositAmount"
        txtDepositAmount.Size = New Size(200, 32)
        txtDepositAmount.TabIndex = 2
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(320, 190)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(95, 35)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(425, 190)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(700, 350)
        Controls.Add(btnCancel)
        Controls.Add(btnDeposit)
        Controls.Add(txtDepositAmount)
        Controls.Add(Label1)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmDeposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposit"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnCancel As Button

End Class
