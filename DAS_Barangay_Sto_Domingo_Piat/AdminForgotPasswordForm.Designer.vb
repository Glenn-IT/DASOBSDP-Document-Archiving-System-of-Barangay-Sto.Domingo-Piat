<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForgotPasswordForm

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
        pnlBackground      = New System.Windows.Forms.Panel()
        pnlCard            = New System.Windows.Forms.Panel()
        pnlHeader          = New System.Windows.Forms.Panel()
        lblSystemTitle     = New System.Windows.Forms.Label()
        lblSubTitle        = New System.Windows.Forms.Label()
        lblFormTitle       = New System.Windows.Forms.Label()
        lblSecQuestion     = New System.Windows.Forms.Label()
        cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        lblSecAnswer       = New System.Windows.Forms.Label()
        txtSecurityAnswer  = New System.Windows.Forms.TextBox()
        lblNewPassword     = New System.Windows.Forms.Label()
        txtNewPassword     = New System.Windows.Forms.TextBox()
        lblConfirmPassword = New System.Windows.Forms.Label()
        txtConfirmPassword = New System.Windows.Forms.TextBox()
        btnConfirm         = New System.Windows.Forms.Button()
        btnBackToLogin     = New System.Windows.Forms.Button()
        lblFooter          = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' ?? pnlBackground  (#346739 � Dark Green) ?????????????????
        pnlBackground.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Name      = "pnlBackground"
        pnlBackground.TabIndex  = 0

        ' ?? pnlHeader  (#79AE6F � Mid Green) ??????????????????????
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 100
        pnlHeader.Name      = "pnlHeader"
        pnlHeader.Padding   = New System.Windows.Forms.Padding(10)

        ' ?? lblSystemTitle  (White on Mid Green) ??????????????????
        lblSystemTitle.AutoSize  = False
        lblSystemTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.ForeColor = System.Drawing.Color.White
        lblSystemTitle.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblSystemTitle.Text      = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        lblSystemTitle.Height    = 50
        lblSystemTitle.Name      = "lblSystemTitle"

        ' ?? lblSubTitle  (#F2EDC2 � Cream on Mid Green) ???????????
        lblSubTitle.AutoSize   = False
        lblSubTitle.Dock       = System.Windows.Forms.DockStyle.Top
        lblSubTitle.ForeColor  = System.Drawing.Color.FromArgb(242, 237, 194)
        lblSubTitle.Font       = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Regular)
        lblSubTitle.Text       = "Piat, Cagayan"
        lblSubTitle.TextAlign  = System.Drawing.ContentAlignment.TopCenter
        lblSubTitle.Height     = 28
        lblSubTitle.Name       = "lblSubTitle"

        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        ' ?? lblFormTitle  (#346739 text on Cream card) ????????????
        lblFormTitle.AutoSize  = False
        lblFormTitle.Text      = "Forgot Password"
        lblFormTitle.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblFormTitle.BackColor = System.Drawing.Color.Transparent
        lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblFormTitle.Size      = New System.Drawing.Size(360, 38)
        lblFormTitle.Location  = New System.Drawing.Point(20, 110)
        lblFormTitle.Name      = "lblFormTitle"

        ' ?? lblSecQuestion ????????????????????????????????????????
        lblSecQuestion.AutoSize  = False
        lblSecQuestion.Text      = "Security Question"
        lblSecQuestion.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblSecQuestion.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblSecQuestion.BackColor = System.Drawing.Color.Transparent
        lblSecQuestion.Size      = New System.Drawing.Size(360, 20)
        lblSecQuestion.Location  = New System.Drawing.Point(20, 162)
        lblSecQuestion.Name      = "lblSecQuestion"

        ' ?? cmbSecurityQuestion  (Cream bg, Dark Green text) ??????
        cmbSecurityQuestion.Font          = New System.Drawing.Font("Segoe UI", 9.5)
        cmbSecurityQuestion.Size          = New System.Drawing.Size(360, 30)
        cmbSecurityQuestion.Location      = New System.Drawing.Point(20, 184)
        cmbSecurityQuestion.Name          = "cmbSecurityQuestion"
        cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbSecurityQuestion.BackColor     = System.Drawing.Color.FromArgb(242, 237, 194)
        cmbSecurityQuestion.ForeColor     = System.Drawing.Color.FromArgb(52, 103, 57)
        cmbSecurityQuestion.FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        cmbSecurityQuestion.TabIndex      = 0

        ' ?? lblSecAnswer ??????????????????????????????????????????
        lblSecAnswer.AutoSize  = False
        lblSecAnswer.Text      = "Answer"
        lblSecAnswer.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblSecAnswer.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblSecAnswer.BackColor = System.Drawing.Color.Transparent
        lblSecAnswer.Size      = New System.Drawing.Size(360, 20)
        lblSecAnswer.Location  = New System.Drawing.Point(20, 226)
        lblSecAnswer.Name      = "lblSecAnswer"

        ' ?? txtSecurityAnswer  (Cream bg) ?????????????????????????
        txtSecurityAnswer.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtSecurityAnswer.Size            = New System.Drawing.Size(360, 30)
        txtSecurityAnswer.Location        = New System.Drawing.Point(20, 248)
        txtSecurityAnswer.Name            = "txtSecurityAnswer"
        txtSecurityAnswer.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtSecurityAnswer.BackColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        txtSecurityAnswer.ForeColor       = System.Drawing.Color.FromArgb(52, 103, 57)
        txtSecurityAnswer.PlaceholderText = "Enter your answer"
        txtSecurityAnswer.TabIndex        = 1

        ' ?? lblNewPassword ????????????????????????????????????????
        lblNewPassword.AutoSize  = False
        lblNewPassword.Text      = "New Password"
        lblNewPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblNewPassword.BackColor = System.Drawing.Color.Transparent
        lblNewPassword.Size      = New System.Drawing.Size(360, 20)
        lblNewPassword.Location  = New System.Drawing.Point(20, 292)
        lblNewPassword.Name      = "lblNewPassword"

        ' ?? txtNewPassword  (Cream bg, masked) ????????????????????
        txtNewPassword.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtNewPassword.Size            = New System.Drawing.Size(360, 30)
        txtNewPassword.Location        = New System.Drawing.Point(20, 314)
        txtNewPassword.Name            = "txtNewPassword"
        txtNewPassword.PasswordChar    = "*"c
        txtNewPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtNewPassword.BackColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        txtNewPassword.ForeColor       = System.Drawing.Color.FromArgb(52, 103, 57)
        txtNewPassword.PlaceholderText = "Enter new password"
        txtNewPassword.TabIndex        = 2

        ' ?? lblConfirmPassword ????????????????????????????????????
        lblConfirmPassword.AutoSize  = False
        lblConfirmPassword.Text      = "Confirm Password"
        lblConfirmPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        lblConfirmPassword.Size      = New System.Drawing.Size(360, 20)
        lblConfirmPassword.Location  = New System.Drawing.Point(20, 358)
        lblConfirmPassword.Name      = "lblConfirmPassword"

        ' ?? txtConfirmPassword  (Cream bg, masked) ????????????????
        txtConfirmPassword.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtConfirmPassword.Size            = New System.Drawing.Size(360, 30)
        txtConfirmPassword.Location        = New System.Drawing.Point(20, 380)
        txtConfirmPassword.Name            = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar    = "*"c
        txtConfirmPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtConfirmPassword.BackColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        txtConfirmPassword.ForeColor       = System.Drawing.Color.FromArgb(52, 103, 57)
        txtConfirmPassword.PlaceholderText = "Re-enter new password"
        txtConfirmPassword.TabIndex        = 3

        ' ?? btnConfirm  (#346739 bg, Cream text) ??????????????????
        btnConfirm.Text                              = "CONFIRM"
        btnConfirm.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnConfirm.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnConfirm.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnConfirm.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnConfirm.FlatAppearance.BorderSize         = 0
        btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnConfirm.Size                              = New System.Drawing.Size(360, 42)
        btnConfirm.Location                          = New System.Drawing.Point(20, 430)
        btnConfirm.Name                              = "btnConfirm"
        btnConfirm.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnConfirm.TabIndex                          = 4

        ' ?? btnBackToLogin  (#79AE6F underline link) ??????????????
        btnBackToLogin.Text                              = "? Go Back to Login"
        btnBackToLogin.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
        btnBackToLogin.ForeColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnBackToLogin.BackColor                         = System.Drawing.Color.Transparent
        btnBackToLogin.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnBackToLogin.FlatAppearance.BorderSize         = 0
        btnBackToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnBackToLogin.Size                              = New System.Drawing.Size(360, 28)
        btnBackToLogin.Location                          = New System.Drawing.Point(20, 484)
        btnBackToLogin.Name                              = "btnBackToLogin"
        btnBackToLogin.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnBackToLogin.TabIndex                          = 5

        ' ?? pnlCard  (#F2EDC2 � Cream card) ???????????????????????
        pnlCard.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlCard.Location  = New System.Drawing.Point(230, 50)
        pnlCard.Name      = "pnlCard"
        pnlCard.Size      = New System.Drawing.Size(400, 530)
        pnlCard.TabIndex  = 0
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblFormTitle)
        pnlCard.Controls.Add(lblSecQuestion)
        pnlCard.Controls.Add(cmbSecurityQuestion)
        pnlCard.Controls.Add(lblSecAnswer)
        pnlCard.Controls.Add(txtSecurityAnswer)
        pnlCard.Controls.Add(lblNewPassword)
        pnlCard.Controls.Add(txtNewPassword)
        pnlCard.Controls.Add(lblConfirmPassword)
        pnlCard.Controls.Add(txtConfirmPassword)
        pnlCard.Controls.Add(btnConfirm)
        pnlCard.Controls.Add(btnBackToLogin)

        ' ?? lblFooter  (#9FCB98 � Light Green) ????????????????????
        lblFooter.AutoSize  = False
        lblFooter.Text      = "� 2026 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.Font      = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblFooter.BackColor = System.Drawing.Color.Transparent
        lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblFooter.Size      = New System.Drawing.Size(860, 26)
        lblFooter.Location  = New System.Drawing.Point(0, 610)
        lblFooter.Name      = "lblFooter"

        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(860, 644)
        Me.Controls.Add(pnlBackground)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.Name                = "AdminForgotPasswordForm"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Document Archiving System � Forgot Password"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBackground       As System.Windows.Forms.Panel
    Friend WithEvents pnlCard             As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader           As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle      As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle         As System.Windows.Forms.Label
    Friend WithEvents lblFormTitle        As System.Windows.Forms.Label
    Friend WithEvents lblSecQuestion      As System.Windows.Forms.Label
    Friend WithEvents cmbSecurityQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSecAnswer        As System.Windows.Forms.Label
    Friend WithEvents txtSecurityAnswer   As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword      As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword      As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword  As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword  As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm          As System.Windows.Forms.Button
    Friend WithEvents btnBackToLogin      As System.Windows.Forms.Button
    Friend WithEvents lblFooter           As System.Windows.Forms.Label

End Class
