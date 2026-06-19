Public Class UserForgotPasswordForm
    Inherits System.Windows.Forms.Form

    Private pnlBackground       As New System.Windows.Forms.Panel()
    Private pnlCard             As New System.Windows.Forms.Panel()
    Private pnlHeader           As New System.Windows.Forms.Panel()
    Private lblSystemTitle      As New System.Windows.Forms.Label()
    Private lblSubTitle         As New System.Windows.Forms.Label()
    Private lblFormTitle        As New System.Windows.Forms.Label()
    Private lblUsernameField    As New System.Windows.Forms.Label()
    Private txtUsernameField    As New System.Windows.Forms.TextBox()
    Private lblSecQuestion      As New System.Windows.Forms.Label()
    Private cmbSecurityQuestion As New System.Windows.Forms.ComboBox()
    Private lblSecAnswer        As New System.Windows.Forms.Label()
    Private txtSecurityAnswer   As New System.Windows.Forms.TextBox()
    Private lblNewPassword      As New System.Windows.Forms.Label()
    Private txtNewPassword      As New System.Windows.Forms.TextBox()
    Private lblConfirmPassword  As New System.Windows.Forms.Label()
    Private txtConfirmPassword  As New System.Windows.Forms.TextBox()
    Private btnConfirm          As New System.Windows.Forms.Button()
    Private btnBackToLogin      As New System.Windows.Forms.Button()
    Private lblFooter           As New System.Windows.Forms.Label()

    Public Sub New()
        InitializeComponent()
        BuildUI()
    End Sub

    Private Sub BuildUI()
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)
        Dim light As System.Drawing.Color = System.Drawing.Color.FromArgb(159, 203, 152)

        Me.ClientSize      = New System.Drawing.Size(860, 644)
        Me.BackColor       = dark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox     = False
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text            = "Document Archiving System - Forgot Password"

        pnlBackground.BackColor = dark
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill

        pnlHeader.BackColor = mid
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 100
        pnlHeader.Padding   = New System.Windows.Forms.Padding(10)

        With lblSystemTitle
            .AutoSize  = False
            .Dock      = System.Windows.Forms.DockStyle.Top
            .ForeColor = System.Drawing.Color.White
            .Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
            .Text      = "Document Archiving System of Barangay Sto. Domingo"
            .TextAlign = System.Drawing.ContentAlignment.BottomCenter
            .Height    = 50
        End With

        With lblSubTitle
            .AutoSize  = False
            .Dock      = System.Windows.Forms.DockStyle.Top
            .ForeColor = cream
            .Font      = New System.Drawing.Font("Segoe UI", 8.5)
            .Text      = "Piat, Cagayan"
            .TextAlign = System.Drawing.ContentAlignment.TopCenter
            .Height    = 28
        End With

        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        pnlCard.BackColor = cream
        pnlCard.Location  = New System.Drawing.Point(230, 50)
        pnlCard.Size      = New System.Drawing.Size(400, 584)

        AddLabel(lblFormTitle, "Forgot Password",
                 New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 110), New System.Drawing.Size(360, 38),
                 System.Drawing.ContentAlignment.MiddleCenter)

        AddLabel(lblUsernameField, "Username",
                 New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 162), New System.Drawing.Size(360, 20))

        ConfigureTextBox(txtUsernameField, New System.Drawing.Point(20, 184), "Enter your username", cream, dark)
        AddHandler txtUsernameField.Leave, AddressOf txtUsernameField_Leave

        AddLabel(lblSecQuestion, "Security Question",
                 New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 226), New System.Drawing.Size(360, 20))

        With cmbSecurityQuestion
            .Font          = New System.Drawing.Font("Segoe UI", 9.5)
            .Size          = New System.Drawing.Size(360, 30)
            .Location      = New System.Drawing.Point(20, 248)
            .DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            .BackColor     = cream
            .ForeColor     = dark
            .FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        End With

        AddLabel(lblSecAnswer, "Answer",
                 New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 290), New System.Drawing.Size(360, 20))

        ConfigureTextBox(txtSecurityAnswer, New System.Drawing.Point(20, 312), "Enter your answer", cream, dark)

        AddLabel(lblNewPassword, "New Password",
                 New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 356), New System.Drawing.Size(360, 20))

        ConfigureTextBox(txtNewPassword, New System.Drawing.Point(20, 378), "Enter new password", cream, dark, True)

        AddLabel(lblConfirmPassword, "Confirm Password",
                 New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                 dark, New System.Drawing.Point(20, 422), New System.Drawing.Size(360, 20))

        ConfigureTextBox(txtConfirmPassword, New System.Drawing.Point(20, 444), "Re-enter new password", cream, dark, True)

        With btnConfirm
            .Text                              = "CONFIRM"
            .Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
            .BackColor                         = dark
            .ForeColor                         = cream
            .FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize         = 0
            .FlatAppearance.MouseOverBackColor = mid
            .Size                              = New System.Drawing.Size(360, 42)
            .Location                          = New System.Drawing.Point(20, 494)
            .Cursor                            = System.Windows.Forms.Cursors.Hand
        End With
        AddHandler btnConfirm.Click, AddressOf btnConfirm_Click

        With btnBackToLogin
            .Text                              = "← Go Back to Login"
            .Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
            .ForeColor                         = mid
            .BackColor                         = System.Drawing.Color.Transparent
            .FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize         = 0
            .FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            .Size                              = New System.Drawing.Size(360, 28)
            .Location                          = New System.Drawing.Point(20, 548)
            .Cursor                            = System.Windows.Forms.Cursors.Hand
        End With
        AddHandler btnBackToLogin.Click, AddressOf btnBackToLogin_Click

        With lblFooter
            .AutoSize  = False
            .Text      = "© 2026 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
            .Font      = New System.Drawing.Font("Segoe UI", 8)
            .ForeColor = light
            .BackColor = System.Drawing.Color.Transparent
            .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            .Size      = New System.Drawing.Size(860, 26)
            .Location  = New System.Drawing.Point(0, 610)
        End With

        pnlCard.Controls.AddRange(New System.Windows.Forms.Control() {
            pnlHeader, lblFormTitle,
            lblUsernameField, txtUsernameField,
            lblSecQuestion, cmbSecurityQuestion,
            lblSecAnswer, txtSecurityAnswer,
            lblNewPassword, txtNewPassword,
            lblConfirmPassword, txtConfirmPassword,
            btnConfirm, btnBackToLogin
        })
        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)
        Me.Controls.Add(pnlBackground)
    End Sub

    Private Sub AddLabel(lbl As System.Windows.Forms.Label, text As String,
                         font As System.Drawing.Font,
                         foreColor As System.Drawing.Color,
                         location As System.Drawing.Point,
                         size As System.Drawing.Size,
                         Optional align As System.Drawing.ContentAlignment =
                             System.Drawing.ContentAlignment.MiddleLeft)
        lbl.AutoSize  = False
        lbl.Text      = text
        lbl.Font      = font
        lbl.ForeColor = foreColor
        lbl.BackColor = System.Drawing.Color.Transparent
        lbl.Size      = size
        lbl.Location  = location
        lbl.TextAlign = align
    End Sub

    Private Sub ConfigureTextBox(txt As System.Windows.Forms.TextBox,
                                  location As System.Drawing.Point,
                                  placeholder As String,
                                  backColor As System.Drawing.Color,
                                  foreColor As System.Drawing.Color,
                                  Optional isPassword As Boolean = False)
        txt.Font            = New System.Drawing.Font("Segoe UI", 10)
        txt.Size            = New System.Drawing.Size(360, 30)
        txt.Location        = location
        txt.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txt.BackColor       = backColor
        txt.ForeColor       = foreColor
        txt.PlaceholderText = placeholder
        If isPassword Then txt.PasswordChar = "*"c
    End Sub

    Private Sub txtUsernameField_Leave(sender As Object, e As EventArgs)
        Dim username As String = InputHelper.SanitizeInput(txtUsernameField.Text)
        If username = "" Then Return

        cmbSecurityQuestion.Items.Clear()
        Try
            Dim dt As DataTable = UserRepository.GetByUsername(username)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No account found with that username.", "Forgot Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmbSecurityQuestion.Items.AddRange(New String() {
                    "What is your mother's maiden name?",
                    "What was the name of your first pet?",
                    "What is your elementary school name?",
                    "What city were you born in?",
                    "What is your favorite childhood nickname?"
                })
                cmbSecurityQuestion.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error looking up account: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Dim username    As String = InputHelper.SanitizeInput(txtUsernameField.Text)
        Dim answer      As String = InputHelper.SanitizeInput(txtSecurityAnswer.Text)
        Dim newPass     As String = txtNewPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPassword.Text.Trim()

        If username = "" OrElse answer = "" OrElse newPass = "" OrElse confirmPass = "" Then
            MessageBox.Show("Please fill in all fields.", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If newPass <> confirmPass Then
            MessageBox.Show("Passwords do not match. Please try again.", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedQuestion As String = If(cmbSecurityQuestion.SelectedItem IsNot Nothing,
                                            cmbSecurityQuestion.SelectedItem.ToString(), "")
        If selectedQuestion = "" Then
            MessageBox.Show("Please select a security question.", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If Not UserRepository.ValidateSecurityAnswer(username, UserType_User, selectedQuestion, answer) Then
                MessageBox.Show("Incorrect security question or answer.", "Forgot Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hashedPassword As String = PasswordHelper.HashPassword(newPass)
            UserRepository.UpdatePassword(username, UserType_User, hashedPassword)

            ActivityLogger.Log(username, "Success", "User reset their password via forgot password.")
            MessageBox.Show("Password reset successfully!", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class
