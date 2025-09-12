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
        Label2 = New Label()
        Label1 = New Label()
        txtAmountTransfer = New TextBox()
        txtTargetAccount = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        Panel1.Controls.Add(btnTransfer)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtAmountTransfer)
        Panel1.Controls.Add(txtTargetAccount)
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
        btnTransfer.FlatStyle = FlatStyle.Flat
        btnTransfer.Location = New Point(238, 241)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(161, 38)
        btnTransfer.TabIndex = 47
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 46
        Label2.Text = "Amount Transfer:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 15)
        Label1.TabIndex = 45
        Label1.Text = "Target Account Number"
        ' 
        ' txtAmountTransfer
        ' 
        txtAmountTransfer.Location = New Point(220, 156)
        txtAmountTransfer.Name = "txtAmountTransfer"
        txtAmountTransfer.Size = New Size(244, 23)
        txtAmountTransfer.TabIndex = 44
        ' 
        ' txtTargetAccount
        ' 
        txtTargetAccount.Location = New Point(220, 114)
        txtTargetAccount.Name = "txtTargetAccount"
        txtTargetAccount.Size = New Size(244, 23)
        txtTargetAccount.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(503, 363)
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTargetAccount As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmountTransfer As TextBox
End Class
