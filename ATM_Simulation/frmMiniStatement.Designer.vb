<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMiniStatement
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
        lblHeader = New Label()
        lstMiniStatement = New ListBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblHeader.Location = New Point(300, 20)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(205, 37)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Mini Statement"
        ' 
        ' lstMiniStatement
        ' 
        lstMiniStatement.Font = New Font("Segoe UI", 12F)
        lstMiniStatement.FormattingEnabled = True
        lstMiniStatement.ItemHeight = 21
        lstMiniStatement.Location = New Point(50, 80)
        lstMiniStatement.Name = "lstMiniStatement"
        lstMiniStatement.Size = New Size(700, 340)
        lstMiniStatement.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-6, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(818, 463)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(btnCancel)
        Panel1.Location = New Point(84, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(636, 361)
        Panel1.TabIndex = 3
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkOliveGreen
        btnCancel.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = SystemColors.ControlLight
        btnCancel.Location = New Point(474, 311)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 47)
        btnCancel.TabIndex = 0
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmMiniStatement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(lstMiniStatement)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMiniStatement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mini Statement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMiniStatement As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
End Class
