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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboardForm))
        pnlSidebar = New Panel()
        pnlSidebarTop = New Panel()
        lblSysSubTitle = New Label()
        lblSysTitle = New Label()
        lblMenuLabel = New Label()
        btnArchiveList = New Button()
        btnUsersList = New Button()
        btnActivityLogs = New Button()
        btnViewProfile = New Button()
        pnlSidebarBottom = New Panel()
        btnLogout = New Button()
        pnlRight = New Panel()
        pnlMainContent = New Panel()
        pnlHeader = New Panel()
        lblPageTitle = New Label()
        lblWelcomeUser = New Label()
        PictureBox1 = New PictureBox()
        pnlSidebar.SuspendLayout()
        pnlSidebarTop.SuspendLayout()
        pnlSidebarBottom.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(lblMenuLabel)
        pnlSidebar.Controls.Add(btnArchiveList)
        pnlSidebar.Controls.Add(btnUsersList)
        pnlSidebar.Controls.Add(btnActivityLogs)
        pnlSidebar.Controls.Add(btnViewProfile)
        pnlSidebar.Controls.Add(pnlSidebarBottom)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 748)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlSidebarTop
        ' 
        pnlSidebarTop.BackColor = Color.FromArgb(CByte(40), CByte(80), CByte(44))
        pnlSidebarTop.Controls.Add(PictureBox1)
        pnlSidebarTop.Controls.Add(lblSysSubTitle)
        pnlSidebarTop.Controls.Add(lblSysTitle)
        pnlSidebarTop.Dock = DockStyle.Top
        pnlSidebarTop.Location = New Point(0, 0)
        pnlSidebarTop.Name = "pnlSidebarTop"
        pnlSidebarTop.Size = New Size(220, 173)
        pnlSidebarTop.TabIndex = 0
        ' 
        ' lblSysSubTitle
        ' 
        lblSysSubTitle.Font = New Font("Segoe UI", 7.5F)
        lblSysSubTitle.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        lblSysSubTitle.Location = New Point(0, 68)
        lblSysSubTitle.Name = "lblSysSubTitle"
        lblSysSubTitle.Size = New Size(220, 32)
        lblSysSubTitle.TabIndex = 0
        lblSysSubTitle.Text = "Brgy. Sto. Domingo - Piat"
        lblSysSubTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSysTitle
        ' 
        lblSysTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSysTitle.ForeColor = Color.White
        lblSysTitle.Location = New Point(0, 0)
        lblSysTitle.Name = "lblSysTitle"
        lblSysTitle.Padding = New Padding(6, 0, 6, 0)
        lblSysTitle.Size = New Size(220, 68)
        lblSysTitle.TabIndex = 1
        lblSysTitle.Text = "Document Archiving System"
        lblSysTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblMenuLabel
        ' 
        lblMenuLabel.BackColor = Color.Transparent
        lblMenuLabel.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblMenuLabel.ForeColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        lblMenuLabel.Location = New Point(0, 176)
        lblMenuLabel.Name = "lblMenuLabel"
        lblMenuLabel.Padding = New Padding(16, 0, 0, 0)
        lblMenuLabel.Size = New Size(220, 32)
        lblMenuLabel.TabIndex = 1
        lblMenuLabel.Text = "MAIN MENU"
        lblMenuLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnArchiveList
        ' 
        btnArchiveList.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnArchiveList.Cursor = Cursors.Hand
        btnArchiveList.FlatAppearance.BorderSize = 0
        btnArchiveList.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnArchiveList.FlatStyle = FlatStyle.Flat
        btnArchiveList.Font = New Font("Segoe UI", 10F)
        btnArchiveList.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnArchiveList.Location = New Point(0, 212)
        btnArchiveList.Name = "btnArchiveList"
        btnArchiveList.Padding = New Padding(16, 0, 0, 0)
        btnArchiveList.Size = New Size(220, 54)
        btnArchiveList.TabIndex = 0
        btnArchiveList.Text = "  Archive List"
        btnArchiveList.TextAlign = ContentAlignment.MiddleLeft
        btnArchiveList.UseVisualStyleBackColor = False
        ' 
        ' btnUsersList
        ' 
        btnUsersList.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnUsersList.Cursor = Cursors.Hand
        btnUsersList.FlatAppearance.BorderSize = 0
        btnUsersList.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUsersList.FlatStyle = FlatStyle.Flat
        btnUsersList.Font = New Font("Segoe UI", 10F)
        btnUsersList.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnUsersList.Location = New Point(0, 266)
        btnUsersList.Name = "btnUsersList"
        btnUsersList.Padding = New Padding(16, 0, 0, 0)
        btnUsersList.Size = New Size(220, 54)
        btnUsersList.TabIndex = 1
        btnUsersList.Text = "  Users List"
        btnUsersList.TextAlign = ContentAlignment.MiddleLeft
        btnUsersList.UseVisualStyleBackColor = False
        ' 
        ' btnActivityLogs
        ' 
        btnActivityLogs.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnActivityLogs.Cursor = Cursors.Hand
        btnActivityLogs.FlatAppearance.BorderSize = 0
        btnActivityLogs.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnActivityLogs.FlatStyle = FlatStyle.Flat
        btnActivityLogs.Font = New Font("Segoe UI", 10F)
        btnActivityLogs.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnActivityLogs.Location = New Point(0, 321)
        btnActivityLogs.Name = "btnActivityLogs"
        btnActivityLogs.Padding = New Padding(16, 0, 0, 0)
        btnActivityLogs.Size = New Size(220, 54)
        btnActivityLogs.TabIndex = 2
        btnActivityLogs.Text = "  Activity Logs"
        btnActivityLogs.TextAlign = ContentAlignment.MiddleLeft
        btnActivityLogs.UseVisualStyleBackColor = False
        ' 
        ' btnViewProfile
        ' 
        btnViewProfile.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnViewProfile.Cursor = Cursors.Hand
        btnViewProfile.FlatAppearance.BorderSize = 0
        btnViewProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnViewProfile.FlatStyle = FlatStyle.Flat
        btnViewProfile.Font = New Font("Segoe UI", 10F)
        btnViewProfile.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnViewProfile.Location = New Point(0, 375)
        btnViewProfile.Name = "btnViewProfile"
        btnViewProfile.Padding = New Padding(16, 0, 0, 0)
        btnViewProfile.Size = New Size(220, 54)
        btnViewProfile.TabIndex = 3
        btnViewProfile.Text = "  View Profile"
        btnViewProfile.TextAlign = ContentAlignment.MiddleLeft
        btnViewProfile.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarBottom
        ' 
        pnlSidebarBottom.BackColor = Color.FromArgb(CByte(40), CByte(80), CByte(44))
        pnlSidebarBottom.Controls.Add(btnLogout)
        pnlSidebarBottom.Dock = DockStyle.Bottom
        pnlSidebarBottom.Location = New Point(0, 685)
        pnlSidebarBottom.Name = "pnlSidebarBottom"
        pnlSidebarBottom.Size = New Size(220, 63)
        pnlSidebarBottom.TabIndex = 4
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(40), CByte(80), CByte(44))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Fill
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(60), CByte(60))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F)
        btnLogout.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnLogout.Location = New Point(0, 0)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(16, 0, 0, 0)
        btnLogout.Size = New Size(220, 63)
        btnLogout.TabIndex = 0
        btnLogout.Text = "  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlRight.Controls.Add(pnlMainContent)
        pnlRight.Controls.Add(pnlHeader)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(220, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(880, 748)
        pnlRight.TabIndex = 1
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.Location = New Point(0, 73)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Padding = New Padding(16, 18, 16, 18)
        pnlMainContent.Size = New Size(880, 675)
        pnlMainContent.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblWelcomeUser)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(880, 73)
        pnlHeader.TabIndex = 1
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.BackColor = Color.Transparent
        lblPageTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Location = New Point(20, 0)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(500, 73)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Admin Dashboard"
        lblPageTitle.TextAlign = ContentAlignment.MiddleLeft
        lblPageTitle.Visible = False
        ' 
        ' lblWelcomeUser
        ' 
        lblWelcomeUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWelcomeUser.BackColor = Color.Transparent
        lblWelcomeUser.Font = New Font("Segoe UI", 9F)
        lblWelcomeUser.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        lblWelcomeUser.Location = New Point(1320, 0)
        lblWelcomeUser.Name = "lblWelcomeUser"
        lblWelcomeUser.Size = New Size(240, 73)
        lblWelcomeUser.TabIndex = 1
        lblWelcomeUser.Text = "Welcome, Admin"
        lblWelcomeUser.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' AdminDashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 748)
        Controls.Add(pnlRight)
        Controls.Add(pnlSidebar)
        Name = "AdminDashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Document Archiving System — Admin Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebarTop.ResumeLayout(False)
        pnlSidebarBottom.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents PictureBox1 As PictureBox

End Class
