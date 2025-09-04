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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lstMiniStatement = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        ' lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.lblHeader.Location = New System.Drawing.Point(300, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(192, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Mini Statement"
        '
        ' lstMiniStatement
        '
        Me.lstMiniStatement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstMiniStatement.FormattingEnabled = True
        Me.lstMiniStatement.ItemHeight = 21
        Me.lstMiniStatement.Location = New System.Drawing.Point(50, 80)
        Me.lstMiniStatement.Name = "lstMiniStatement"
        Me.lstMiniStatement.Size = New System.Drawing.Size(700, 340)
        Me.lstMiniStatement.TabIndex = 1
        '
        ' MiniStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstMiniStatement)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MiniStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mini Statement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMiniStatement As ListBox
End Class
