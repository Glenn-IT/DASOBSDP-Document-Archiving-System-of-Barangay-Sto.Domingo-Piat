Public Class LoginForm
    Inherits System.Windows.Forms.Form

    Private _failedAttempts As New Dictionary(Of String, Integer)
    Private Const MaxAttempts As Integer = 5

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = InputHelper.SanitizeInput(txtUsername.Text)
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _failedAttempts.ContainsKey(username) AndAlso _failedAttempts(username) >= MaxAttempts Then
            MessageBox.Show("This account has been temporarily locked after 5 failed attempts." &
                            Environment.NewLine & "Please wait a moment or contact the administrator.",
                            "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnLogin.Enabled = False
            Return
        End If

        Try
            Dim dt As DataTable = UserRepository.GetByUsername(username)

            If dt.Rows.Count = 0 Then
                IncrementFailedAttempts(username)
                ActivityLogger.Log(username, "Failed", "Login failed - invalid username or password.")
                MessageBox.Show("Invalid username or password.",
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim row        As DataRow = dt.Rows(0)
            Dim userType   As String  = row("UserType").ToString()
            Dim status     As String  = row("Status").ToString()
            Dim storedHash As String  = row("PasswordHash").ToString()

            If Not PasswordHelper.VerifyPassword(password, storedHash) Then
                IncrementFailedAttempts(username)
                ActivityLogger.Log(username, "Failed", "Login failed - invalid username or password.")
                MessageBox.Show("Invalid username or password.",
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If status = Status_Inactive Then
                IncrementFailedAttempts(username)
                ActivityLogger.Log(username, "Failed",
                    $"{userType} login failed - account is inactive.")
                MessageBox.Show("Your account is inactive. Please contact the system administrator.",
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            SessionManager.Username = username
            SessionManager.UserType  = userType
            SessionManager.UserCode  = row("UserCode").ToString()

            _failedAttempts.Remove(username)
            ActivityLogger.Log(username, "Success", $"{userType} logged in successfully.")

            Me.Hide()

            If userType = UserType_Admin Then
                Dim dashboard As New AdminDashboardForm()
                dashboard.ShowDialog()
            Else
                Dim dashboard As New UserDashboardForm()
                dashboard.ShowDialog()
            End If

            SessionManager.Clear()
            Me.Show()
            btnLogin.Enabled = True
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message,
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IncrementFailedAttempts(username As String)
        If Not _failedAttempts.ContainsKey(username) Then
            _failedAttempts(username) = 0
        End If
        _failedAttempts(username) += 1

        If _failedAttempts(username) >= MaxAttempts Then
            btnLogin.Enabled = False
            MessageBox.Show($"Too many failed attempts. The login button has been disabled." &
                            Environment.NewLine & "Please contact the administrator to unlock your account.",
                            "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim forgotPw As New AdminForgotPasswordForm()
        Me.Hide()
        forgotPw.ShowDialog()
        Me.Show()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

End Class
