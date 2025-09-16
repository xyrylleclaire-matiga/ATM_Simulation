﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserManagement
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private WithEvents lblTitle As Label
    Private WithEvents txtSearch As TextBox
    Private WithEvents dgvUsers As DataGridView
    Private WithEvents lblUsername As Label
    Private WithEvents txtUsernameInput As TextBox
    Private WithEvents lblFullName As Label
    Private WithEvents txtFullNameInput As TextBox
    Private WithEvents lblRole As Label
    Private WithEvents txtRoleInput As TextBox
    Private WithEvents btnSave As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnDelete As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        txtSearch = New TextBox()
        dgvUsers = New DataGridView()
        lblUsername = New Label()
        txtUsernameInput = New TextBox()
        lblFullName = New Label()
        txtFullNameInput = New TextBox()
        lblRole = New Label()
        txtRoleInput = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(204, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "User Management"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(20, 70)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search users..."
        txtSearch.Size = New Size(250, 25)
        txtSearch.TabIndex = 1
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Location = New Point(0, 0)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(1386, 650)
        dgvUsers.TabIndex = 10
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblUsername.Location = New Point(300, 70)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(80, 19)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' txtUsernameInput
        ' 
        txtUsernameInput.Font = New Font("Segoe UI", 10F)
        txtUsernameInput.Location = New Point(380, 68)
        txtUsernameInput.Name = "txtUsernameInput"
        txtUsernameInput.Size = New Size(180, 25)
        txtUsernameInput.TabIndex = 3
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFullName.Location = New Point(580, 70)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(80, 19)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full Name:"
        ' 
        ' txtFullNameInput
        ' 
        txtFullNameInput.Font = New Font("Segoe UI", 10F)
        txtFullNameInput.Location = New Point(660, 68)
        txtFullNameInput.Name = "txtFullNameInput"
        txtFullNameInput.Size = New Size(200, 25)
        txtFullNameInput.TabIndex = 5
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblRole.Location = New Point(880, 70)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(43, 19)
        lblRole.TabIndex = 6
        lblRole.Text = "Role:"
        ' 
        ' txtRoleInput
        ' 
        txtRoleInput.Font = New Font("Segoe UI", 10F)
        txtRoleInput.Location = New Point(920, 68)
        txtRoleInput.Name = "txtRoleInput"
        txtRoleInput.Size = New Size(150, 25)
        txtRoleInput.TabIndex = 7
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(1080, 65)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 30)
        btnSave.TabIndex = 8
        btnSave.Text = "Add User"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Gray
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(1190, 65)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 30)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1280, 65)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 30)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete User"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1386, 650)
        Controls.Add(lblTitle)
        Controls.Add(txtSearch)
        Controls.Add(lblUsername)
        Controls.Add(txtUsernameInput)
        Controls.Add(lblFullName)
        Controls.Add(txtFullNameInput)
        Controls.Add(lblRole)
        Controls.Add(txtRoleInput)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(dgvUsers)
        Controls.Add(btnDelete)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUserManagement"
        Text = "User Management"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
