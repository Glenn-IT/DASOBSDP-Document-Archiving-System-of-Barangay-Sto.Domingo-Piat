<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUsersListPanel
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvUsersList  = New System.Windows.Forms.DataGridView()
        colUserID     = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colUsername   = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colUserType   = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colStatus     = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlTop        = New System.Windows.Forms.Panel()
        lblTitle      = New System.Windows.Forms.Label()
        pnlActions    = New System.Windows.Forms.Panel()
        btnAddUser    = New System.Windows.Forms.Button()
        btnUpdateUser = New System.Windows.Forms.Button()
        btnDeleteUser = New System.Windows.Forms.Button()
        btnToggleStatus = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Users List"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size      = New System.Drawing.Size(400, 52)
        lblTitle.Location  = New System.Drawing.Point(16, 0)
        lblTitle.Name      = "lblTitle"
        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlActions ????????????????????????????????????????????
        pnlActions.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlActions.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlActions.Height    = 60
        pnlActions.Name      = "pnlActions"
        pnlActions.Padding   = New System.Windows.Forms.Padding(12, 10, 12, 10)

        Dim btnSize As New System.Drawing.Size(120, 38)
        Dim btnFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)

        btnAddUser.Text                              = "Add"
        btnAddUser.Font                              = btnFont
        btnAddUser.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnAddUser.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnAddUser.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAddUser.FlatAppearance.BorderSize         = 0
        btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAddUser.Size                              = btnSize
        btnAddUser.Location                          = New System.Drawing.Point(12, 11)
        btnAddUser.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAddUser.Name                              = "btnAddUser"
        btnAddUser.TabIndex                          = 0

        btnUpdateUser.Text                              = "Update"
        btnUpdateUser.Font                              = btnFont
        btnUpdateUser.BackColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnUpdateUser.ForeColor                         = System.Drawing.Color.White
        btnUpdateUser.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUpdateUser.FlatAppearance.BorderSize         = 0
        btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUpdateUser.Size                              = btnSize
        btnUpdateUser.Location                          = New System.Drawing.Point(144, 11)
        btnUpdateUser.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUpdateUser.Name                              = "btnUpdateUser"
        btnUpdateUser.TabIndex                          = 1

        btnDeleteUser.Text                              = "Delete"
        btnDeleteUser.Font                              = btnFont
        btnDeleteUser.BackColor                         = System.Drawing.Color.FromArgb(192, 57, 43)
        btnDeleteUser.ForeColor                         = System.Drawing.Color.White
        btnDeleteUser.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnDeleteUser.FlatAppearance.BorderSize         = 0
        btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 60)
        btnDeleteUser.Size                              = btnSize
        btnDeleteUser.Location                          = New System.Drawing.Point(276, 11)
        btnDeleteUser.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnDeleteUser.Name                              = "btnDeleteUser"
        btnDeleteUser.TabIndex                          = 2

        pnlActions.Controls.Add(btnAddUser)
        pnlActions.Controls.Add(btnUpdateUser)
        pnlActions.Controls.Add(btnDeleteUser)
        btnToggleStatus.Text                              = "Deactivate / Activate"
        btnToggleStatus.Font                              = btnFont
        btnToggleStatus.BackColor                         = System.Drawing.Color.FromArgb(200, 120, 20)
        btnToggleStatus.ForeColor                         = System.Drawing.Color.White
        btnToggleStatus.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnToggleStatus.FlatAppearance.BorderSize         = 0
        btnToggleStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 140, 40)
        btnToggleStatus.Size                              = New System.Drawing.Size(160, 36)
        btnToggleStatus.Location                          = New System.Drawing.Point(408, 11)
        btnToggleStatus.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnToggleStatus.Name                              = "btnToggleStatus"
        btnToggleStatus.TabIndex                          = 3
        pnlActions.Controls.Add(btnToggleStatus)

        ' ?? dgvUsersList ??????????????????????????????????????????
        dgvUsersList.Dock                  = System.Windows.Forms.DockStyle.Fill
        dgvUsersList.Name                  = "dgvUsersList"
        dgvUsersList.ReadOnly              = True
        dgvUsersList.AllowUserToAddRows    = False
        dgvUsersList.AllowUserToDeleteRows = False
        dgvUsersList.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvUsersList.MultiSelect           = False
        dgvUsersList.RowHeadersVisible     = False
        dgvUsersList.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvUsersList.BackgroundColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvUsersList.BorderStyle           = System.Windows.Forms.BorderStyle.None
        dgvUsersList.GridColor             = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvUsersList.Font                  = New System.Drawing.Font("Segoe UI", 9)
        dgvUsersList.TabIndex              = 3

        dgvUsersList.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvUsersList.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvUsersList.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvUsersList.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvUsersList.ColumnHeadersHeight                      = 36
        dgvUsersList.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUsersList.EnableHeadersVisualStyles                = False

        dgvUsersList.DefaultCellStyle.BackColor         = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvUsersList.DefaultCellStyle.ForeColor         = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvUsersList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        dgvUsersList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvUsersList.DefaultCellStyle.Alignment         = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvUsersList.RowTemplate.Height                 = 32
        dgvUsersList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        colUserID.Name       = "colUserID"
        colUserID.HeaderText = "User ID"
        colUserID.FillWeight = 15

        colUsername.Name       = "colUsername"
        colUsername.HeaderText = "Username"
        colUsername.FillWeight = 35

        colUserType.Name       = "colUserType"
        colUserType.HeaderText = "User Type"
        colUserType.FillWeight = 25

        colStatus.Name       = "colStatus"
        colStatus.HeaderText = "Status"
        colStatus.FillWeight = 25

        dgvUsersList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colUserID, colUsername, colUserType, colStatus
        })

        Me.Controls.Add(dgvUsersList)
        Me.Controls.Add(pnlActions)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = System.Drawing.Color.FromArgb(242, 237, 194)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "AdminUsersListPanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUsersList  As System.Windows.Forms.DataGridView
    Friend WithEvents colUserID     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsername   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUserType   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTop        As System.Windows.Forms.Panel
    Friend WithEvents lblTitle      As System.Windows.Forms.Label
    Friend WithEvents pnlActions    As System.Windows.Forms.Panel
    Friend WithEvents btnAddUser    As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnToggleStatus As System.Windows.Forms.Button

End Class
