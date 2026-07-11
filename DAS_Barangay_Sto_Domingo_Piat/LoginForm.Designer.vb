<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        pnlBackground = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        pnlCard = New Panel()
        btnExit = New Button()
        pnlHeader = New Panel()
        lblSubTitle = New Label()
        lblSystemTitle = New Label()
        lblWelcome = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        btnForgotPassword = New Button()
        lblFooter = New Label()
        pnlBackground.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCard.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBackground
        ' 
        pnlBackground.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        pnlBackground.Controls.Add(Panel1)
        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)
        pnlBackground.Dock = DockStyle.Fill
        pnlBackground.Location = New Point(0, 0)
        pnlBackground.Name = "pnlBackground"
        pnlBackground.Size = New Size(900, 753)
        pnlBackground.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(357, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 195)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlCard.Controls.Add(btnExit)
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtPassword)
        pnlCard.Controls.Add(chkShowPassword)
        pnlCard.Controls.Add(btnLogin)
        pnlCard.Controls.Add(btnForgotPassword)
        pnlCard.Location = New Point(250, 226)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(400, 487)
        pnlCard.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.DarkRed
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnExit.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnExit.Location = New Point(30, 404)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(340, 48)
        btnExit.TabIndex = 5
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(10, 11, 10, 11)
        pnlHeader.Size = New Size(400, 113)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubTitle
        ' 
        lblSubTitle.Dock = DockStyle.Top
        lblSubTitle.Font = New Font("Segoe UI", 8.5F)
        lblSubTitle.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        lblSubTitle.Location = New Point(10, 68)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(380, 32)
        lblSubTitle.TabIndex = 0
        lblSubTitle.Text = "Piat, Cagayan"
        lblSubTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSystemTitle
        ' 
        lblSystemTitle.Dock = DockStyle.Top
        lblSystemTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSystemTitle.ForeColor = Color.White
        lblSystemTitle.Location = New Point(10, 11)
        lblSystemTitle.Name = "lblSystemTitle"
        lblSystemTitle.Size = New Size(380, 57)
        lblSystemTitle.TabIndex = 1
        lblSystemTitle.Text = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblWelcome.Location = New Point(30, 131)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(340, 43)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Login"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblUsername.Location = New Point(30, 193)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(340, 23)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtUsername.Location = New Point(30, 218)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter username"
        txtUsername.Size = New Size(340, 27)
        txtUsername.TabIndex = 0
        ' 
        ' lblPassword
        ' 
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblPassword.Location = New Point(30, 256)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(340, 23)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtPassword.Location = New Point(30, 281)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter password"
        txtPassword.Size = New Size(340, 27)
        txtPassword.TabIndex = 1
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Cursor = Cursors.Hand
        chkShowPassword.Font = New Font("Segoe UI", 8.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        chkShowPassword.Location = New Point(30, 314)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(150, 24)
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnLogin.Location = New Point(30, 350)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(340, 48)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.BackColor = Color.Transparent
        btnForgotPassword.Cursor = Cursors.Hand
        btnForgotPassword.FlatAppearance.BorderSize = 0
        btnForgotPassword.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnForgotPassword.FlatStyle = FlatStyle.Flat
        btnForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        btnForgotPassword.ForeColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnForgotPassword.Location = New Point(30, 452)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(340, 32)
        btnForgotPassword.TabIndex = 4
        btnForgotPassword.Text = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.BackColor = Color.Transparent
        lblFooter.Font = New Font("Segoe UI", 8F)
        lblFooter.ForeColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        lblFooter.Location = New Point(0, 717)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(900, 29)
        lblFooter.TabIndex = 1
        lblFooter.Text = "@2026 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 753)
        ControlBox = False
        Controls.Add(pnlBackground)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        pnlBackground.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBackground     As System.Windows.Forms.Panel
    Friend WithEvents pnlCard           As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader         As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle    As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle       As System.Windows.Forms.Label
    Friend WithEvents lblWelcome        As System.Windows.Forms.Label
    Friend WithEvents lblUsername       As System.Windows.Forms.Label
    Friend WithEvents txtUsername       As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword       As System.Windows.Forms.Label
    Friend WithEvents txtPassword       As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword   As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin          As System.Windows.Forms.Button
    Friend WithEvents btnForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblFooter         As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button

End Class
