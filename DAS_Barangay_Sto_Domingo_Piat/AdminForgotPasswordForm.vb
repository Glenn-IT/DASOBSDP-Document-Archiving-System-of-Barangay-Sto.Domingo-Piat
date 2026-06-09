Public Class AdminForgotPasswordForm
    Inherits System.Windows.Forms.Form

    Private lblUsernameField As New System.Windows.Forms.Label()
    Private txtUsernameField As New System.Windows.Forms.TextBox()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuildUsernameField()
        cmbSecurityQuestion.Items.Clear()
    End Sub

    Private Sub BuildUsernameField()
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)

        lblUsernameField.AutoSize  = False
        lblUsernameField.Text      = "Username"
        lblUsernameField.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblUsernameField.ForeColor = dark
        lblUsernameField.BackColor = System.Drawing.Color.Transparent
        lblUsernameField.Size      = New System.Drawing.Size(360, 20)
        lblUsernameField.Location  = New System.Drawing.Point(20, 162)

        txtUsernameField.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtUsernameField.Size            = New System.Drawing.Size(360, 30)
        txtUsernameField.Location        = New System.Drawing.Point(20, 184)
        txtUsernameField.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtUsernameField.BackColor       = cream
        txtUsernameField.ForeColor       = dark
        txtUsernameField.PlaceholderText = "Enter your username"
        AddHandler txtUsernameField.Leave, AddressOf txtUsernameField_Leave

        pnlCard.Controls.Add(lblUsernameField)
        pnlCard.Controls.Add(txtUsernameField)

        Dim shift As Integer = 54
        For Each ctrl As System.Windows.Forms.Control In New System.Windows.Forms.Control() {
            lblSecQuestion, cmbSecurityQuestion, lblSecAnswer, txtSecurityAnswer,
            lblNewPassword, txtNewPassword, lblConfirmPassword, txtConfirmPassword,
            btnConfirm, btnBackToLogin
        }
            ctrl.Top += shift
        Next

        pnlCard.Height += shift
    End Sub

    Private Sub txtUsernameField_Leave(sender As Object, e As EventArgs)
        Dim username As String = InputHelper.SanitizeInput(txtUsernameField.Text)
        If username = "" Then Return

        cmbSecurityQuestion.Items.Clear()
        Try
            Dim question As String = UserRepository.GetSecurityQuestion(username, UserType_Admin)
            If question Is Nothing Then
                MessageBox.Show("No admin account found with that username.", "Forgot Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmbSecurityQuestion.Items.Add(question)
                cmbSecurityQuestion.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error looking up account: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
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

        Try
            If Not UserRepository.ValidateSecurityAnswer(username, UserType_Admin, answer) Then
                MessageBox.Show("Incorrect security answer.", "Forgot Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hashedPassword As String = PasswordHelper.HashPassword(newPass)
            UserRepository.UpdatePassword(username, UserType_Admin, hashedPassword)

            ActivityLogger.Log(username, "Success", "Admin reset their password via forgot password.")
            MessageBox.Show("Password reset successfully!", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
