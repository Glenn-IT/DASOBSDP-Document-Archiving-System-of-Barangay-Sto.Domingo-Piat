<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLoginForm

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
        ' ?? Controls ??????????????????????????????????????????????
        pnlBackground       = New System.Windows.Forms.Panel()
        pnlCard             = New System.Windows.Forms.Panel()
        pnlHeader           = New System.Windows.Forms.Panel()
        lblSystemTitle      = New System.Windows.Forms.Label()
        lblSubTitle         = New System.Windows.Forms.Label()
        lblWelcome          = New System.Windows.Forms.Label()
        lblUsername         = New System.Windows.Forms.Label()
        txtAdminUsername    = New System.Windows.Forms.TextBox()
        lblPassword         = New System.Windows.Forms.Label()
        txtAdminPassword    = New System.Windows.Forms.TextBox()
        btnAdminLogin       = New System.Windows.Forms.Button()
        btnAdminForgotPassword = New System.Windows.Forms.Button()
        lblFooter           = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' ?? pnlBackground (full form fill, dark navy) ??????????????
        pnlBackground.BackColor    = System.Drawing.Color.FromArgb(18, 32, 58)
        pnlBackground.Dock         = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Location     = New System.Drawing.Point(0, 0)
        pnlBackground.Name         = "pnlBackground"
        pnlBackground.Size         = New System.Drawing.Size(900, 580)
        pnlBackground.TabIndex     = 0

        ' ?? pnlHeader (navy blue top strip on card) ????????????????
        pnlHeader.BackColor        = System.Drawing.Color.FromArgb(18, 32, 58)
        pnlHeader.Dock             = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height           = 100
        pnlHeader.Name             = "pnlHeader"
        pnlHeader.Padding          = New System.Windows.Forms.Padding(10)

        ' ?? lblSystemTitle ?????????????????????????????????????????
        lblSystemTitle.AutoSize    = False
        lblSystemTitle.Dock        = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.ForeColor   = System.Drawing.Color.White
        lblSystemTitle.Font        = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblSystemTitle.Text        = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign   = System.Drawing.ContentAlignment.BottomCenter
        lblSystemTitle.Height      = 50
        lblSystemTitle.Name        = "lblSystemTitle"

        ' ?? lblSubTitle ????????????????????????????????????????????
        lblSubTitle.AutoSize       = False
        lblSubTitle.Dock           = System.Windows.Forms.DockStyle.Top
        lblSubTitle.ForeColor      = System.Drawing.Color.FromArgb(173, 216, 230)
        lblSubTitle.Font           = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Regular)
        lblSubTitle.Text           = "Piat, Cagayan"
        lblSubTitle.TextAlign      = System.Drawing.ContentAlignment.TopCenter
        lblSubTitle.Height         = 28
        lblSubTitle.Name           = "lblSubTitle"

        ' pnlHeader children (added bottom-up because Dock=Top stacks)
        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        ' ?? lblWelcome ?????????????????????????????????????????????
        lblWelcome.AutoSize        = False
        lblWelcome.Text            = "Admin Login"
        lblWelcome.Font            = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblWelcome.ForeColor       = System.Drawing.Color.FromArgb(18, 32, 58)
        lblWelcome.TextAlign       = System.Drawing.ContentAlignment.MiddleCenter
        lblWelcome.Size            = New System.Drawing.Size(340, 38)
        lblWelcome.Location        = New System.Drawing.Point(30, 116)
        lblWelcome.Name            = "lblWelcome"

        ' ?? lblUsername ????????????????????????????????????????????
        lblUsername.AutoSize       = False
        lblUsername.Text           = "Username"
        lblUsername.Font           = New System.Drawing.Font("Segoe UI", 9)
        lblUsername.ForeColor      = System.Drawing.Color.FromArgb(80, 80, 80)
        lblUsername.Size           = New System.Drawing.Size(340, 20)
        lblUsername.Location       = New System.Drawing.Point(30, 170)
        lblUsername.Name           = "lblUsername"

        ' ?? txtAdminUsername ???????????????????????????????????????
        txtAdminUsername.Font      = New System.Drawing.Font("Segoe UI", 10)
        txtAdminUsername.Size      = New System.Drawing.Size(340, 34)
        txtAdminUsername.Location  = New System.Drawing.Point(30, 192)
        txtAdminUsername.Name      = "txtAdminUsername"
        txtAdminUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAdminUsername.PlaceholderText = "Enter username"
        txtAdminUsername.TabIndex    = 0

        ' ?? lblPassword ????????????????????????????????????????????
        lblPassword.AutoSize       = False
        lblPassword.Text           = "Password"
        lblPassword.Font           = New System.Drawing.Font("Segoe UI", 9)
        lblPassword.ForeColor      = System.Drawing.Color.FromArgb(80, 80, 80)
        lblPassword.Size           = New System.Drawing.Size(340, 20)
        lblPassword.Location       = New System.Drawing.Point(30, 242)
        lblPassword.Name           = "lblPassword"

        ' ?? txtAdminPassword ???????????????????????????????????????
        txtAdminPassword.Font      = New System.Drawing.Font("Segoe UI", 10)
        txtAdminPassword.Size      = New System.Drawing.Size(340, 34)
        txtAdminPassword.Location  = New System.Drawing.Point(30, 264)
        txtAdminPassword.Name      = "txtAdminPassword"
        txtAdminPassword.PasswordChar = "*"c
        txtAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAdminPassword.PlaceholderText = "Enter password"
        txtAdminPassword.TabIndex    = 1

        ' ?? btnAdminLogin ??????????????????????????????????????????
        btnAdminLogin.Text         = "LOGIN"
        btnAdminLogin.Font         = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnAdminLogin.BackColor    = System.Drawing.Color.FromArgb(18, 32, 58)
        btnAdminLogin.ForeColor    = System.Drawing.Color.White
        btnAdminLogin.FlatStyle    = System.Windows.Forms.FlatStyle.Flat
        btnAdminLogin.FlatAppearance.BorderSize = 0
        btnAdminLogin.Size         = New System.Drawing.Size(340, 42)
        btnAdminLogin.Location     = New System.Drawing.Point(30, 322)
        btnAdminLogin.Name         = "btnAdminLogin"
        btnAdminLogin.Cursor       = System.Windows.Forms.Cursors.Hand
        btnAdminLogin.TabIndex      = 2

        ' ?? btnAdminForgotPassword ?????????????????????????????????
        btnAdminForgotPassword.Text      = "Forgot Password?"
        btnAdminForgotPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
        btnAdminForgotPassword.ForeColor = System.Drawing.Color.FromArgb(18, 32, 58)
        btnAdminForgotPassword.BackColor = System.Drawing.Color.Transparent
        btnAdminForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAdminForgotPassword.FlatAppearance.BorderSize  = 0
        btnAdminForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnAdminForgotPassword.Size      = New System.Drawing.Size(340, 28)
        btnAdminForgotPassword.Location  = New System.Drawing.Point(30, 378)
        btnAdminForgotPassword.Name      = "btnAdminForgotPassword"
        btnAdminForgotPassword.Cursor    = System.Windows.Forms.Cursors.Hand
        btnAdminForgotPassword.TabIndex    = 3

        ' ?? pnlCard (white centered card) ??????????????????????????
        pnlCard.BackColor          = System.Drawing.Color.White
        pnlCard.Location           = New System.Drawing.Point(250, 70)
        pnlCard.Name               = "pnlCard"
        pnlCard.Size               = New System.Drawing.Size(400, 450)
        pnlCard.TabIndex           = 0
        ' rounded feel via padding only (no Region needed)

        ' ?? lblFooter ??????????????????????????????????????????????
        lblFooter.AutoSize         = False
        lblFooter.Text             = "© 2025 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.Font             = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor        = System.Drawing.Color.FromArgb(160, 160, 160)
        lblFooter.TextAlign        = System.Drawing.ContentAlignment.MiddleCenter
        lblFooter.Size             = New System.Drawing.Size(900, 26)
        lblFooter.Location         = New System.Drawing.Point(0, 548)
        lblFooter.Name             = "lblFooter"

        ' ?? Assemble pnlCard ???????????????????????????????????????
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtAdminUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtAdminPassword)
        pnlCard.Controls.Add(btnAdminLogin)
        pnlCard.Controls.Add(btnAdminForgotPassword)

        ' ?? Assemble pnlBackground ?????????????????????????????????
        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)

        ' ?? Form Settings ??????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(900, 580)
        Me.Controls.Add(pnlBackground)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.Name                = "AdminLoginForm"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Document Archiving System — Admin Login"

        Me.ResumeLayout(False)
    End Sub

    ' ?? Control Declarations ???????????????????????????????????????
    Friend WithEvents pnlBackground          As System.Windows.Forms.Panel
    Friend WithEvents pnlCard                As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader              As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle         As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle            As System.Windows.Forms.Label
    Friend WithEvents lblWelcome             As System.Windows.Forms.Label
    Friend WithEvents lblUsername            As System.Windows.Forms.Label
    Friend WithEvents txtAdminUsername       As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword            As System.Windows.Forms.Label
    Friend WithEvents txtAdminPassword       As System.Windows.Forms.TextBox
    Friend WithEvents btnAdminLogin          As System.Windows.Forms.Button
    Friend WithEvents btnAdminForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblFooter              As System.Windows.Forms.Label

End Class
