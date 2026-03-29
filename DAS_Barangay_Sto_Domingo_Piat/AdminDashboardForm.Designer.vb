<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardForm

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
        pnlSidebar      = New System.Windows.Forms.Panel()
        pnlSidebarTop   = New System.Windows.Forms.Panel()
        lblSysTitle     = New System.Windows.Forms.Label()
        lblSysSubTitle  = New System.Windows.Forms.Label()
        lblMenuLabel    = New System.Windows.Forms.Label()
        btnArchiveList  = New System.Windows.Forms.Button()
        btnUsersList    = New System.Windows.Forms.Button()
        btnActivityLogs = New System.Windows.Forms.Button()
        btnViewProfile  = New System.Windows.Forms.Button()
        pnlSidebarBottom = New System.Windows.Forms.Panel()
        btnLogout       = New System.Windows.Forms.Button()
        pnlRight        = New System.Windows.Forms.Panel()
        pnlHeader       = New System.Windows.Forms.Panel()
        lblPageTitle    = New System.Windows.Forms.Label()
        lblWelcomeUser  = New System.Windows.Forms.Label()
        pnlMainContent  = New System.Windows.Forms.Panel()

        Me.SuspendLayout()

        ' ?? pnlSidebar  (#346739 — Dark Green, left 220px) ????????
        pnlSidebar.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
        pnlSidebar.Dock      = System.Windows.Forms.DockStyle.Left
        pnlSidebar.Width     = 220
        pnlSidebar.Name      = "pnlSidebar"
        pnlSidebar.TabIndex  = 0

        ' ?? pnlSidebarTop  (brand header, docked Top) ?????????????
        pnlSidebarTop.BackColor = System.Drawing.Color.FromArgb(40, 80, 44)
        pnlSidebarTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlSidebarTop.Height    = 110
        pnlSidebarTop.Name      = "pnlSidebarTop"

        lblSysTitle.AutoSize  = False
        lblSysTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSysTitle.Text      = "Document Archiving System"
        lblSysTitle.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblSysTitle.ForeColor = System.Drawing.Color.White
        lblSysTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        lblSysTitle.Height    = 60
        lblSysTitle.Name      = "lblSysTitle"
        lblSysTitle.Padding   = New System.Windows.Forms.Padding(6, 0, 6, 0)

        lblSysSubTitle.AutoSize  = False
        lblSysSubTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSysSubTitle.Text      = "Brgy. Sto. Domingo - Piat"
        lblSysSubTitle.Font      = New System.Drawing.Font("Segoe UI", 7.5, System.Drawing.FontStyle.Regular)
        lblSysSubTitle.ForeColor = System.Drawing.Color.FromArgb(242, 237, 194)
        lblSysSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        lblSysSubTitle.Height    = 28
        lblSysSubTitle.Name      = "lblSysSubTitle"

        pnlSidebarTop.Controls.Add(lblSysSubTitle)
        pnlSidebarTop.Controls.Add(lblSysTitle)

        ' ?? lblMenuLabel ??????????????????????????????????????????
        lblMenuLabel.AutoSize  = False
        lblMenuLabel.Text      = "MAIN MENU"
        lblMenuLabel.Font      = New System.Drawing.Font("Segoe UI", 7.5, System.Drawing.FontStyle.Bold)
        lblMenuLabel.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblMenuLabel.BackColor = System.Drawing.Color.Transparent
        lblMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMenuLabel.Size      = New System.Drawing.Size(220, 28)
        lblMenuLabel.Location  = New System.Drawing.Point(0, 118)
        lblMenuLabel.Padding   = New System.Windows.Forms.Padding(16, 0, 0, 0)
        lblMenuLabel.Name      = "lblMenuLabel"

        Dim sbSize As New System.Drawing.Size(220, 48)
        Dim sbFont As New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular)

        ' ?? Menu buttons (Top-anchored, fixed positions) ???????????
        btnArchiveList.Text                              = "  Archive List"
        btnArchiveList.Font                              = sbFont
        btnArchiveList.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnArchiveList.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnArchiveList.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnArchiveList.FlatAppearance.BorderSize         = 0
        btnArchiveList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnArchiveList.Size                              = sbSize
        btnArchiveList.Location                          = New System.Drawing.Point(0, 150)
        btnArchiveList.TextAlign                         = System.Drawing.ContentAlignment.MiddleLeft
        btnArchiveList.Padding                           = New System.Windows.Forms.Padding(16, 0, 0, 0)
        btnArchiveList.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnArchiveList.Name                              = "btnArchiveList"
        btnArchiveList.TabIndex                          = 0

        btnUsersList.Text                              = "  Users List"
        btnUsersList.Font                              = sbFont
        btnUsersList.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnUsersList.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnUsersList.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUsersList.FlatAppearance.BorderSize         = 0
        btnUsersList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnUsersList.Size                              = sbSize
        btnUsersList.Location                          = New System.Drawing.Point(0, 198)
        btnUsersList.TextAlign                         = System.Drawing.ContentAlignment.MiddleLeft
        btnUsersList.Padding                           = New System.Windows.Forms.Padding(16, 0, 0, 0)
        btnUsersList.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUsersList.Name                              = "btnUsersList"
        btnUsersList.TabIndex                          = 1

        btnActivityLogs.Text                              = "  Activity Logs"
        btnActivityLogs.Font                              = sbFont
        btnActivityLogs.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnActivityLogs.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnActivityLogs.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnActivityLogs.FlatAppearance.BorderSize         = 0
        btnActivityLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnActivityLogs.Size                              = sbSize
        btnActivityLogs.Location                          = New System.Drawing.Point(0, 246)
        btnActivityLogs.TextAlign                         = System.Drawing.ContentAlignment.MiddleLeft
        btnActivityLogs.Padding                           = New System.Windows.Forms.Padding(16, 0, 0, 0)
        btnActivityLogs.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnActivityLogs.Name                              = "btnActivityLogs"
        btnActivityLogs.TabIndex                          = 2

        btnViewProfile.Text                              = "  View Profile"
        btnViewProfile.Font                              = sbFont
        btnViewProfile.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnViewProfile.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnViewProfile.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnViewProfile.FlatAppearance.BorderSize         = 0
        btnViewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnViewProfile.Size                              = sbSize
        btnViewProfile.Location                          = New System.Drawing.Point(0, 294)
        btnViewProfile.TextAlign                         = System.Drawing.ContentAlignment.MiddleLeft
        btnViewProfile.Padding                           = New System.Windows.Forms.Padding(16, 0, 0, 0)
        btnViewProfile.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnViewProfile.Name                              = "btnViewProfile"
        btnViewProfile.TabIndex                          = 3

        ' ?? pnlSidebarBottom  (Dock=Bottom — always visible) ??????
        pnlSidebarBottom.BackColor = System.Drawing.Color.FromArgb(40, 80, 44)
        pnlSidebarBottom.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlSidebarBottom.Height    = 56
        pnlSidebarBottom.Name      = "pnlSidebarBottom"

        ' ?? btnLogout  (inside pnlSidebarBottom, Dock=Fill) ???????
        btnLogout.Text                              = "  Logout"
        btnLogout.Font                              = sbFont
        btnLogout.BackColor                         = System.Drawing.Color.FromArgb(40, 80, 44)
        btnLogout.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnLogout.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize         = 0
        btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 60, 60)
        btnLogout.Dock                              = System.Windows.Forms.DockStyle.Fill
        btnLogout.TextAlign                         = System.Drawing.ContentAlignment.MiddleLeft
        btnLogout.Padding                           = New System.Windows.Forms.Padding(16, 0, 0, 0)
        btnLogout.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnLogout.Name                              = "btnLogout"
        btnLogout.TabIndex                          = 0

        pnlSidebarBottom.Controls.Add(btnLogout)

        ' Assemble sidebar
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(lblMenuLabel)
        pnlSidebar.Controls.Add(btnArchiveList)
        pnlSidebar.Controls.Add(btnUsersList)
        pnlSidebar.Controls.Add(btnActivityLogs)
        pnlSidebar.Controls.Add(btnViewProfile)
        pnlSidebar.Controls.Add(pnlSidebarBottom)

        ' ?? pnlRight ??????????????????????????????????????????????
        pnlRight.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlRight.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlRight.Name      = "pnlRight"
        pnlRight.TabIndex  = 1

        ' ?? pnlHeader ?????????????????????????????????????????????
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 64
        pnlHeader.Name      = "pnlHeader"

        lblPageTitle.AutoSize  = False
        lblPageTitle.Text      = "Admin Dashboard"
        lblPageTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblPageTitle.ForeColor = System.Drawing.Color.White
        lblPageTitle.BackColor = System.Drawing.Color.Transparent
        lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPageTitle.Size      = New System.Drawing.Size(500, 64)
        lblPageTitle.Location  = New System.Drawing.Point(20, 0)
        lblPageTitle.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left
        lblPageTitle.Name      = "lblPageTitle"

        lblWelcomeUser.AutoSize  = False
        lblWelcomeUser.Text      = "Welcome, Admin"
        lblWelcomeUser.Font      = New System.Drawing.Font("Segoe UI", 9)
        lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(242, 237, 194)
        lblWelcomeUser.BackColor = System.Drawing.Color.Transparent
        lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        lblWelcomeUser.Size      = New System.Drawing.Size(240, 64)
        lblWelcomeUser.Location  = New System.Drawing.Point(640, 0)
        lblWelcomeUser.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        lblWelcomeUser.Name      = "lblWelcomeUser"

        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblWelcomeUser)

        ' ?? pnlMainContent ????????????????????????????????????????
        pnlMainContent.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlMainContent.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlMainContent.Name      = "pnlMainContent"
        pnlMainContent.TabIndex  = 0
        pnlMainContent.Padding   = New System.Windows.Forms.Padding(16)

        pnlRight.Controls.Add(pnlMainContent)
        pnlRight.Controls.Add(pnlHeader)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(1100, 660)
        Me.Controls.Add(pnlRight)
        Me.Controls.Add(pnlSidebar)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox         = True
        Me.WindowState         = System.Windows.Forms.FormWindowState.Maximized
        Me.Name                = "AdminDashboardForm"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Document Archiving System — Admin Dashboard"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar        As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebarTop     As System.Windows.Forms.Panel
    Friend WithEvents lblSysTitle       As System.Windows.Forms.Label
    Friend WithEvents lblSysSubTitle    As System.Windows.Forms.Label
    Friend WithEvents lblMenuLabel      As System.Windows.Forms.Label
    Friend WithEvents btnArchiveList    As System.Windows.Forms.Button
    Friend WithEvents btnUsersList      As System.Windows.Forms.Button
    Friend WithEvents btnActivityLogs   As System.Windows.Forms.Button
    Friend WithEvents btnViewProfile    As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarBottom  As System.Windows.Forms.Panel
    Friend WithEvents btnLogout         As System.Windows.Forms.Button
    Friend WithEvents pnlRight          As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader         As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle      As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeUser    As System.Windows.Forms.Label
    Friend WithEvents pnlMainContent    As System.Windows.Forms.Panel

End Class
