<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAddAccountForm

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
        pnlHeader          = New System.Windows.Forms.Panel()
        lblFormTitle       = New System.Windows.Forms.Label()
        pnlBody            = New System.Windows.Forms.Panel()
        lblUsername        = New System.Windows.Forms.Label()
        txtUsername        = New System.Windows.Forms.TextBox()
        lblNewPassword     = New System.Windows.Forms.Label()
        txtNewPassword     = New System.Windows.Forms.TextBox()
        lblConfirmPassword = New System.Windows.Forms.Label()
        txtConfirmPassword = New System.Windows.Forms.TextBox()
        chkShowPassword    = New System.Windows.Forms.CheckBox()
        lblUserType        = New System.Windows.Forms.Label()
        cmbUserType        = New System.Windows.Forms.ComboBox()
        lblSecQuestion     = New System.Windows.Forms.Label()
        cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        lblSecAnswer       = New System.Windows.Forms.Label()
        txtSecurityAnswer  = New System.Windows.Forms.TextBox()
        pnlFooter          = New System.Windows.Forms.Panel()
        btnAdd             = New System.Windows.Forms.Button()
        btnCancel          = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim lbFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Dim tbFont As New System.Drawing.Font("Segoe UI", 10)
        Dim cream  As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark   As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)

        ' ?? pnlHeader ?????????????????????????????????????????????
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 56
        pnlHeader.Name      = "pnlHeader"

        lblFormTitle.AutoSize  = False
        lblFormTitle.Text      = "Add New Account"
        lblFormTitle.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblFormTitle.ForeColor = System.Drawing.Color.White
        lblFormTitle.BackColor = System.Drawing.Color.Transparent
        lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblFormTitle.Dock      = System.Windows.Forms.DockStyle.Fill
        lblFormTitle.Padding   = New System.Windows.Forms.Padding(20, 0, 0, 0)
        lblFormTitle.Name      = "lblFormTitle"
        pnlHeader.Controls.Add(lblFormTitle)

        ' ?? pnlFooter ?????????????????????????????????????????????
        pnlFooter.BackColor = cream
        pnlFooter.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlFooter.Height    = 60
        pnlFooter.Name      = "pnlFooter"
        pnlFooter.Padding   = New System.Windows.Forms.Padding(20, 10, 20, 10)

        btnAdd.Text                              = "ADD ACCOUNT"
        btnAdd.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnAdd.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnAdd.ForeColor                         = cream
        btnAdd.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAdd.FlatAppearance.BorderSize         = 0
        btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAdd.Size                              = New System.Drawing.Size(160, 38)
        btnAdd.Location                          = New System.Drawing.Point(20, 11)
        btnAdd.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAdd.Name                              = "btnAdd"
        btnAdd.TabIndex                          = 0

        btnCancel.Text                              = "CANCEL"
        btnCancel.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnCancel.BackColor                         = System.Drawing.Color.FromArgb(160, 160, 160)
        btnCancel.ForeColor                         = System.Drawing.Color.White
        btnCancel.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize         = 0
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 60, 60)
        btnCancel.Size                              = New System.Drawing.Size(120, 38)
        btnCancel.Location                          = New System.Drawing.Point(192, 11)
        btnCancel.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnCancel.Name                              = "btnCancel"
        btnCancel.TabIndex                          = 1

        pnlFooter.Controls.Add(btnAdd)
        pnlFooter.Controls.Add(btnCancel)

        ' ?? pnlBody ???????????????????????????????????????????????
        pnlBody.BackColor = cream
        pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBody.Name      = "pnlBody"
        pnlBody.Padding   = New System.Windows.Forms.Padding(30, 16, 30, 0)

        ' Username
        lblUsername.AutoSize = False : lblUsername.Text = "Username"
        lblUsername.Font = lbFont : lblUsername.ForeColor = dark : lblUsername.BackColor = System.Drawing.Color.Transparent
        lblUsername.Size = New System.Drawing.Size(420, 20) : lblUsername.Location = New System.Drawing.Point(30, 16)
        lblUsername.Name = "lblUsername"

        txtUsername.Font = tbFont : txtUsername.Size = New System.Drawing.Size(420, 32)
        txtUsername.Location = New System.Drawing.Point(30, 38)
        txtUsername.BackColor = cream : txtUsername.ForeColor = dark
        txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtUsername.PlaceholderText = "Enter username"
        txtUsername.Name = "txtUsername" : txtUsername.TabIndex = 0

        ' New Password
        lblNewPassword.AutoSize = False : lblNewPassword.Text = "New Password"
        lblNewPassword.Font = lbFont : lblNewPassword.ForeColor = dark : lblNewPassword.BackColor = System.Drawing.Color.Transparent
        lblNewPassword.Size = New System.Drawing.Size(420, 20) : lblNewPassword.Location = New System.Drawing.Point(30, 82)
        lblNewPassword.Name = "lblNewPassword"

        txtNewPassword.Font = tbFont : txtNewPassword.Size = New System.Drawing.Size(420, 32)
        txtNewPassword.Location = New System.Drawing.Point(30, 104) : txtNewPassword.PasswordChar = "*"c
        txtNewPassword.BackColor = cream : txtNewPassword.ForeColor = dark
        txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNewPassword.PlaceholderText = "Enter password"
        txtNewPassword.Name = "txtNewPassword" : txtNewPassword.TabIndex = 1

        ' Confirm Password
        lblConfirmPassword.AutoSize = False : lblConfirmPassword.Text = "Confirm Password"
        lblConfirmPassword.Font = lbFont : lblConfirmPassword.ForeColor = dark : lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        lblConfirmPassword.Size = New System.Drawing.Size(420, 20) : lblConfirmPassword.Location = New System.Drawing.Point(30, 148)
        lblConfirmPassword.Name = "lblConfirmPassword"

        txtConfirmPassword.Font = tbFont : txtConfirmPassword.Size = New System.Drawing.Size(420, 32)
        txtConfirmPassword.Location = New System.Drawing.Point(30, 170) : txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.BackColor = cream : txtConfirmPassword.ForeColor = dark
        txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtConfirmPassword.PlaceholderText = "Re-enter password"
        txtConfirmPassword.Name = "txtConfirmPassword" : txtConfirmPassword.TabIndex = 2

        ' Show Password
        chkShowPassword.AutoSize = False : chkShowPassword.Text = "Show Password"
        chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        chkShowPassword.ForeColor = dark : chkShowPassword.BackColor = System.Drawing.Color.Transparent
        chkShowPassword.Size = New System.Drawing.Size(180, 24) : chkShowPassword.Location = New System.Drawing.Point(30, 206)
        chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        chkShowPassword.Name = "chkShowPassword" : chkShowPassword.TabIndex = 3

        ' User Type
        lblUserType.AutoSize = False : lblUserType.Text = "User Type"
        lblUserType.Font = lbFont : lblUserType.ForeColor = dark : lblUserType.BackColor = System.Drawing.Color.Transparent
        lblUserType.Size = New System.Drawing.Size(420, 20) : lblUserType.Location = New System.Drawing.Point(30, 238)
        lblUserType.Name = "lblUserType"

        cmbUserType.Font = tbFont : cmbUserType.Size = New System.Drawing.Size(420, 32)
        cmbUserType.Location = New System.Drawing.Point(30, 260)
        cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbUserType.BackColor = cream : cmbUserType.ForeColor = dark
        cmbUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbUserType.Name = "cmbUserType" : cmbUserType.TabIndex = 4

        ' Security Question
        lblSecQuestion.AutoSize = False : lblSecQuestion.Text = "Security Question"
        lblSecQuestion.Font = lbFont : lblSecQuestion.ForeColor = dark : lblSecQuestion.BackColor = System.Drawing.Color.Transparent
        lblSecQuestion.Size = New System.Drawing.Size(420, 20) : lblSecQuestion.Location = New System.Drawing.Point(30, 304)
        lblSecQuestion.Name = "lblSecQuestion"

        cmbSecurityQuestion.Font = tbFont : cmbSecurityQuestion.Size = New System.Drawing.Size(420, 32)
        cmbSecurityQuestion.Location = New System.Drawing.Point(30, 326)
        cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbSecurityQuestion.BackColor = cream : cmbSecurityQuestion.ForeColor = dark
        cmbSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbSecurityQuestion.Name = "cmbSecurityQuestion" : cmbSecurityQuestion.TabIndex = 5

        ' Security Answer
        lblSecAnswer.AutoSize = False : lblSecAnswer.Text = "Security Answer"
        lblSecAnswer.Font = lbFont : lblSecAnswer.ForeColor = dark : lblSecAnswer.BackColor = System.Drawing.Color.Transparent
        lblSecAnswer.Size = New System.Drawing.Size(420, 20) : lblSecAnswer.Location = New System.Drawing.Point(30, 370)
        lblSecAnswer.Name = "lblSecAnswer"

        txtSecurityAnswer.Font = tbFont : txtSecurityAnswer.Size = New System.Drawing.Size(420, 32)
        txtSecurityAnswer.Location = New System.Drawing.Point(30, 392)
        txtSecurityAnswer.BackColor = cream : txtSecurityAnswer.ForeColor = dark
        txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtSecurityAnswer.PlaceholderText = "Enter your answer"
        txtSecurityAnswer.Name = "txtSecurityAnswer" : txtSecurityAnswer.TabIndex = 6

        pnlBody.Controls.Add(lblUsername)
        pnlBody.Controls.Add(txtUsername)
        pnlBody.Controls.Add(lblNewPassword)
        pnlBody.Controls.Add(txtNewPassword)
        pnlBody.Controls.Add(lblConfirmPassword)
        pnlBody.Controls.Add(txtConfirmPassword)
        pnlBody.Controls.Add(chkShowPassword)
        pnlBody.Controls.Add(lblUserType)
        pnlBody.Controls.Add(cmbUserType)
        pnlBody.Controls.Add(lblSecQuestion)
        pnlBody.Controls.Add(cmbSecurityQuestion)
        pnlBody.Controls.Add(lblSecAnswer)
        pnlBody.Controls.Add(txtSecurityAnswer)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(480, 540)
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlFooter)
        Me.Controls.Add(pnlHeader)
        Me.BackColor           = cream
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Name                = "AdminAddAccountForm"
        Me.Text                = "Add New Account"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader           As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle        As System.Windows.Forms.Label
    Friend WithEvents pnlBody             As System.Windows.Forms.Panel
    Friend WithEvents lblUsername         As System.Windows.Forms.Label
    Friend WithEvents txtUsername         As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword      As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword      As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword  As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword  As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword     As System.Windows.Forms.CheckBox
    Friend WithEvents lblUserType         As System.Windows.Forms.Label
    Friend WithEvents cmbUserType         As System.Windows.Forms.ComboBox
    Friend WithEvents lblSecQuestion      As System.Windows.Forms.Label
    Friend WithEvents cmbSecurityQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSecAnswer        As System.Windows.Forms.Label
    Friend WithEvents txtSecurityAnswer   As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter           As System.Windows.Forms.Panel
    Friend WithEvents btnAdd              As System.Windows.Forms.Button
    Friend WithEvents btnCancel           As System.Windows.Forms.Button

End Class
