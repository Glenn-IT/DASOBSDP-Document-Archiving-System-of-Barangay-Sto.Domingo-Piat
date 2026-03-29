<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserViewProfilePanel
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
        pnlTop              = New System.Windows.Forms.Panel()
        lblTitle            = New System.Windows.Forms.Label()
        pnlBody             = New System.Windows.Forms.Panel()
        pnlCard             = New System.Windows.Forms.Panel()
        lblUsername         = New System.Windows.Forms.Label()
        txtUsername         = New System.Windows.Forms.TextBox()
        lblNewPassword      = New System.Windows.Forms.Label()
        txtNewPassword      = New System.Windows.Forms.TextBox()
        lblConfirmPassword  = New System.Windows.Forms.Label()
        txtConfirmPassword  = New System.Windows.Forms.TextBox()
        lblUserType         = New System.Windows.Forms.Label()
        txtUserType         = New System.Windows.Forms.TextBox()
        lblSecQuestion      = New System.Windows.Forms.Label()
        cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        lblSecAnswer        = New System.Windows.Forms.Label()
        txtSecurityAnswer   = New System.Windows.Forms.TextBox()
        pnlCardFooter       = New System.Windows.Forms.Panel()
        btnUpdate           = New System.Windows.Forms.Button()
        btnCancel           = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim lbFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Dim tbFont As New System.Drawing.Font("Segoe UI", 10)
        Dim cream  As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark   As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid    As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = mid
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "View Profile"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size      = New System.Drawing.Size(400, 52)
        lblTitle.Location  = New System.Drawing.Point(16, 0)
        lblTitle.Name      = "lblTitle"
        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlBody ???????????????????????????????????????????????
        pnlBody.BackColor = cream
        pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBody.Name      = "pnlBody"

        ' ?? pnlCard ???????????????????????????????????????????????
        pnlCard.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)
        pnlCard.Size      = New System.Drawing.Size(480, 490)
        pnlCard.Location  = New System.Drawing.Point(40, 24)
        pnlCard.Name      = "pnlCard"

        ' Username (read-only)
        lblUsername.AutoSize = False : lblUsername.Text = "Username" : lblUsername.Font = lbFont
        lblUsername.ForeColor = dark : lblUsername.BackColor = System.Drawing.Color.Transparent
        lblUsername.Size = New System.Drawing.Size(432, 20) : lblUsername.Location = New System.Drawing.Point(24, 16) : lblUsername.Name = "lblUsername"

        txtUsername.Font = tbFont : txtUsername.Size = New System.Drawing.Size(432, 32)
        txtUsername.Location = New System.Drawing.Point(24, 38) : txtUsername.ReadOnly = True
        txtUsername.BackColor = System.Drawing.Color.FromArgb(215, 210, 165)
        txtUsername.ForeColor = dark : txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtUsername.Name = "txtUsername" : txtUsername.TabIndex = 0

        ' New Password
        lblNewPassword.AutoSize = False : lblNewPassword.Text = "New Password (leave blank to keep)" : lblNewPassword.Font = lbFont
        lblNewPassword.ForeColor = dark : lblNewPassword.BackColor = System.Drawing.Color.Transparent
        lblNewPassword.Size = New System.Drawing.Size(432, 20) : lblNewPassword.Location = New System.Drawing.Point(24, 82) : lblNewPassword.Name = "lblNewPassword"

        txtNewPassword.Font = tbFont : txtNewPassword.Size = New System.Drawing.Size(432, 32)
        txtNewPassword.Location = New System.Drawing.Point(24, 104) : txtNewPassword.PasswordChar = "*"c
        txtNewPassword.BackColor = cream : txtNewPassword.ForeColor = dark
        txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNewPassword.PlaceholderText = "Enter new password"
        txtNewPassword.Name = "txtNewPassword" : txtNewPassword.TabIndex = 1

        ' Confirm Password
        lblConfirmPassword.AutoSize = False : lblConfirmPassword.Text = "Confirm Password" : lblConfirmPassword.Font = lbFont
        lblConfirmPassword.ForeColor = dark : lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        lblConfirmPassword.Size = New System.Drawing.Size(432, 20) : lblConfirmPassword.Location = New System.Drawing.Point(24, 148) : lblConfirmPassword.Name = "lblConfirmPassword"

        txtConfirmPassword.Font = tbFont : txtConfirmPassword.Size = New System.Drawing.Size(432, 32)
        txtConfirmPassword.Location = New System.Drawing.Point(24, 170) : txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.BackColor = cream : txtConfirmPassword.ForeColor = dark
        txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtConfirmPassword.PlaceholderText = "Re-enter password"
        txtConfirmPassword.Name = "txtConfirmPassword" : txtConfirmPassword.TabIndex = 2

        ' User Type (read-only)
        lblUserType.AutoSize = False : lblUserType.Text = "User Type" : lblUserType.Font = lbFont
        lblUserType.ForeColor = dark : lblUserType.BackColor = System.Drawing.Color.Transparent
        lblUserType.Size = New System.Drawing.Size(432, 20) : lblUserType.Location = New System.Drawing.Point(24, 214) : lblUserType.Name = "lblUserType"

        txtUserType.Font = tbFont : txtUserType.Size = New System.Drawing.Size(432, 32)
        txtUserType.Location = New System.Drawing.Point(24, 236) : txtUserType.ReadOnly = True
        txtUserType.BackColor = System.Drawing.Color.FromArgb(215, 210, 165)
        txtUserType.ForeColor = dark : txtUserType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtUserType.Name = "txtUserType" : txtUserType.TabIndex = 3

        ' Security Question
        lblSecQuestion.AutoSize = False : lblSecQuestion.Text = "Security Question" : lblSecQuestion.Font = lbFont
        lblSecQuestion.ForeColor = dark : lblSecQuestion.BackColor = System.Drawing.Color.Transparent
        lblSecQuestion.Size = New System.Drawing.Size(432, 20) : lblSecQuestion.Location = New System.Drawing.Point(24, 280) : lblSecQuestion.Name = "lblSecQuestion"

        cmbSecurityQuestion.Font = tbFont : cmbSecurityQuestion.Size = New System.Drawing.Size(432, 32)
        cmbSecurityQuestion.Location = New System.Drawing.Point(24, 302)
        cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbSecurityQuestion.BackColor = cream : cmbSecurityQuestion.ForeColor = dark
        cmbSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbSecurityQuestion.Name = "cmbSecurityQuestion" : cmbSecurityQuestion.TabIndex = 4

        ' Security Answer
        lblSecAnswer.AutoSize = False : lblSecAnswer.Text = "Security Answer" : lblSecAnswer.Font = lbFont
        lblSecAnswer.ForeColor = dark : lblSecAnswer.BackColor = System.Drawing.Color.Transparent
        lblSecAnswer.Size = New System.Drawing.Size(432, 20) : lblSecAnswer.Location = New System.Drawing.Point(24, 346) : lblSecAnswer.Name = "lblSecAnswer"

        txtSecurityAnswer.Font = tbFont : txtSecurityAnswer.Size = New System.Drawing.Size(432, 32)
        txtSecurityAnswer.Location = New System.Drawing.Point(24, 368)
        txtSecurityAnswer.BackColor = cream : txtSecurityAnswer.ForeColor = dark
        txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtSecurityAnswer.PlaceholderText = "Enter your answer"
        txtSecurityAnswer.Name = "txtSecurityAnswer" : txtSecurityAnswer.TabIndex = 5

        ' ?? pnlCardFooter ?????????????????????????????????????????
        pnlCardFooter.BackColor = System.Drawing.Color.Transparent
        pnlCardFooter.Size      = New System.Drawing.Size(432, 50)
        pnlCardFooter.Location  = New System.Drawing.Point(24, 420)
        pnlCardFooter.Name      = "pnlCardFooter"

        btnUpdate.Text = "UPDATE PROFILE" : btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnUpdate.BackColor = dark : btnUpdate.ForeColor = cream
        btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseOverBackColor = mid
        btnUpdate.Size = New System.Drawing.Size(170, 38) : btnUpdate.Location = New System.Drawing.Point(0, 6)
        btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand : btnUpdate.Name = "btnUpdate" : btnUpdate.TabIndex = 6

        btnCancel.Text = "CANCEL" : btnCancel.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnCancel.BackColor = System.Drawing.Color.FromArgb(160, 160, 160) : btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 60, 60)
        btnCancel.Size = New System.Drawing.Size(120, 38) : btnCancel.Location = New System.Drawing.Point(182, 6)
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand : btnCancel.Name = "btnCancel" : btnCancel.TabIndex = 7

        pnlCardFooter.Controls.Add(btnUpdate)
        pnlCardFooter.Controls.Add(btnCancel)

        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(lblNewPassword)
        pnlCard.Controls.Add(txtNewPassword)
        pnlCard.Controls.Add(lblConfirmPassword)
        pnlCard.Controls.Add(txtConfirmPassword)
        pnlCard.Controls.Add(lblUserType)
        pnlCard.Controls.Add(txtUserType)
        pnlCard.Controls.Add(lblSecQuestion)
        pnlCard.Controls.Add(cmbSecurityQuestion)
        pnlCard.Controls.Add(lblSecAnswer)
        pnlCard.Controls.Add(txtSecurityAnswer)
        pnlCard.Controls.Add(pnlCardFooter)

        pnlBody.Controls.Add(pnlCard)

        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = cream
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "UserViewProfilePanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop              As System.Windows.Forms.Panel
    Friend WithEvents lblTitle            As System.Windows.Forms.Label
    Friend WithEvents pnlBody             As System.Windows.Forms.Panel
    Friend WithEvents pnlCard             As System.Windows.Forms.Panel
    Friend WithEvents lblUsername         As System.Windows.Forms.Label
    Friend WithEvents txtUsername         As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword      As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword      As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword  As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword  As System.Windows.Forms.TextBox
    Friend WithEvents lblUserType         As System.Windows.Forms.Label
    Friend WithEvents txtUserType         As System.Windows.Forms.TextBox
    Friend WithEvents lblSecQuestion      As System.Windows.Forms.Label
    Friend WithEvents cmbSecurityQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSecAnswer        As System.Windows.Forms.Label
    Friend WithEvents txtSecurityAnswer   As System.Windows.Forms.TextBox
    Friend WithEvents pnlCardFooter       As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate           As System.Windows.Forms.Button
    Friend WithEvents btnCancel           As System.Windows.Forms.Button

End Class
