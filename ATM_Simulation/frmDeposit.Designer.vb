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
        Panel1 = New Panel()
        Label2 = New Label()
        lblEmpty = New Label()
        lbl0 = New Label()
        lbl9 = New Label()
        lbl8 = New Label()
        lbl7 = New Label()
        lbl2 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl3 = New Label()
        lbl6 = New Label()
        lbl1 = New Label()
        lblEnter = New Label()
        lblClear = New Label()
        btnDel = New Label()
        lblCancel = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.DarkOliveGreen
        lblHeader.Location = New Point(216, 19)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(121, 36)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Deposit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(78, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 23)
        Label1.TabIndex = 1
        Label1.Text = "Deposit Amount:"
        ' 
        ' txtDepositAmount
        ' 
        txtDepositAmount.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDepositAmount.Location = New Point(248, 88)
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
        btnDeposit.Location = New Point(252, 141)
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
        btnCancel.Location = New Point(353, 141)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblEmpty)
        Panel1.Controls.Add(lbl0)
        Panel1.Controls.Add(lbl9)
        Panel1.Controls.Add(lbl8)
        Panel1.Controls.Add(lbl7)
        Panel1.Controls.Add(lbl2)
        Panel1.Controls.Add(lbl4)
        Panel1.Controls.Add(lbl5)
        Panel1.Controls.Add(lbl3)
        Panel1.Controls.Add(lbl6)
        Panel1.Controls.Add(lbl1)
        Panel1.Location = New Point(78, 191)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(303, 147)
        Panel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DimGray
        Label2.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(205, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 22)
        Label2.TabIndex = 34
        Label2.Text = "             "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.DimGray
        lblEmpty.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lblEmpty.Location = New Point(16, 113)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(88, 22)
        lblEmpty.TabIndex = 33
        lblEmpty.Text = "             "
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.BackColor = Color.DimGray
        lbl0.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl0.ForeColor = SystemColors.ButtonHighlight
        lbl0.Location = New Point(109, 113)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(89, 22)
        lbl0.TabIndex = 32
        lbl0.Text = "      0     "
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.DimGray
        lbl9.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl9.ForeColor = SystemColors.ButtonHighlight
        lbl9.Location = New Point(204, 79)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(89, 22)
        lbl9.TabIndex = 30
        lbl9.Text = "      9     "
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.DimGray
        lbl8.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl8.ForeColor = SystemColors.ButtonHighlight
        lbl8.Location = New Point(109, 79)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(89, 22)
        lbl8.TabIndex = 28
        lbl8.Text = "      8     "
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.DimGray
        lbl7.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl7.ForeColor = SystemColors.ButtonHighlight
        lbl7.Location = New Point(15, 79)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(89, 22)
        lbl7.TabIndex = 27
        lbl7.Text = "      7     "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.DimGray
        lbl2.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl2.ForeColor = SystemColors.ButtonHighlight
        lbl2.Location = New Point(109, 12)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(89, 22)
        lbl2.TabIndex = 26
        lbl2.Text = "      2     "
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.DimGray
        lbl4.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl4.ForeColor = SystemColors.ButtonHighlight
        lbl4.Location = New Point(14, 44)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(89, 22)
        lbl4.TabIndex = 25
        lbl4.Text = "      4     "
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.DimGray
        lbl5.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl5.ForeColor = SystemColors.ButtonHighlight
        lbl5.Location = New Point(109, 44)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(89, 22)
        lbl5.TabIndex = 24
        lbl5.Text = "      5     "
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.DimGray
        lbl3.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl3.ForeColor = SystemColors.ButtonHighlight
        lbl3.Location = New Point(204, 12)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(89, 22)
        lbl3.TabIndex = 23
        lbl3.Text = "      3     "
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.DimGray
        lbl6.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl6.ForeColor = SystemColors.ButtonHighlight
        lbl6.Location = New Point(204, 44)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(89, 22)
        lbl6.TabIndex = 22
        lbl6.Text = "      6     "
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.DimGray
        lbl1.Font = New Font("Lucida Fax", 14.25F, FontStyle.Bold)
        lbl1.ForeColor = SystemColors.ButtonHighlight
        lbl1.Location = New Point(14, 12)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(89, 22)
        lbl1.TabIndex = 21
        lbl1.Text = "      1     "
        ' 
        ' lblEnter
        ' 
        lblEnter.AutoSize = True
        lblEnter.BackColor = Color.ForestGreen
        lblEnter.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblEnter.ForeColor = SystemColors.Control
        lblEnter.Location = New Point(387, 202)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New Size(85, 23)
        lblEnter.TabIndex = 37
        lblEnter.Text = "    Enter  "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblClear.Location = New Point(387, 235)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(86, 23)
        lblClear.TabIndex = 38
        lblClear.Text = "  Clear   "
        ' 
        ' btnDel
        ' 
        btnDel.AutoSize = True
        btnDel.BackColor = Color.Sienna
        btnDel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(387, 304)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(85, 23)
        btnDel.TabIndex = 39
        btnDel.Text = "     Del    "
        ' 
        ' lblCancel
        ' 
        lblCancel.AutoSize = True
        lblCancel.BackColor = Color.DarkRed
        lblCancel.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        lblCancel.Location = New Point(387, 270)
        lblCancel.Name = "lblCancel"
        lblCancel.Size = New Size(83, 23)
        lblCancel.TabIndex = 40
        lblCancel.Text = " Cancel"
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(529, 386)
        Controls.Add(lblCancel)
        Controls.Add(btnDel)
        Controls.Add(lblClear)
        Controls.Add(lblEnter)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
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
    Friend WithEvents lblEnter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lblClear As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents lblCancel As Label

End Class
