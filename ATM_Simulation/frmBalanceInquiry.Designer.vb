<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBalanceInquiry
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblBalanceAmount = New Label()
        btnCancel = New Button()
        btnRefresh = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Label1.Location = New Point(200, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 32)
        Label1.TabIndex = 0
        Label1.Text = "Account Balance:"
        ' 
        ' lblBalanceAmount
        ' 
        lblBalanceAmount.AutoSize = True
        lblBalanceAmount.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblBalanceAmount.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblBalanceAmount.Location = New Point(420, 145)
        lblBalanceAmount.Name = "lblBalanceAmount"
        lblBalanceAmount.Size = New Size(85, 45)
        lblBalanceAmount.TabIndex = 1
        lblBalanceAmount.Text = "-----"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(374, 228)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 35)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Teal
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(234, 228)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(95, 35)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10000
        ' 
        ' frmBalanceInquiry
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 400)
        Controls.Add(btnRefresh)
        Controls.Add(btnCancel)
        Controls.Add(lblBalanceAmount)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmBalanceInquiry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Balance Inquiry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBalanceAmount As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Timer1 As Timer
End Class
