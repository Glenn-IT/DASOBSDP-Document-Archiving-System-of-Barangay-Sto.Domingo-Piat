Public Class LoginForm
    Inherits System.Windows.Forms.Form

    Private _failedAttempts As New Dictionary(Of String, Integer)
    Private Const MaxAttempts As Integer = 3
    Private Const LockoutSeconds As Integer = 30
    Private _lockoutTimer As New System.Windows.Forms.Timer()
    Private _lockoutSecondsLeft As Integer = 0
    Private _lockedUsername As String = ""

    Public Sub New()
        InitializeComponent()
        _lockoutTimer.Interval = 1000
        AddHandler _lockoutTimer.Tick, AddressOf LockoutTimer_Tick
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = SanitizeInput(txtUsername.Text)
        Dim password = txtPassword.Text.Trim

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _lockoutTimer.Enabled Then Return

        Try
            Dim dt = GetByUsername(username)

            If dt.Rows.Count = 0 Then
                Dim remaining = IncrementFailedAttempts(username)
                ActivityLogger.Log(username, "Failed", "Login failed - invalid username or password.")
                MessageBox.Show(AttemptsMessage("Invalid username or password.", remaining),
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim row = dt.Rows(0)
            Dim userType = row("UserType").ToString
            Dim status = row("Status").ToString
            Dim storedHash = row("PasswordHash").ToString

            If Not VerifyPassword(password, storedHash) Then
                Dim remaining = IncrementFailedAttempts(username)
                ActivityLogger.Log(username, "Failed", "Login failed - invalid username or password.")
                MessageBox.Show(AttemptsMessage("Invalid username or password.", remaining),
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
            SessionManager.UserType = userType
            SessionManager.UserCode = row("UserCode").ToString

            _failedAttempts.Remove(username)
            ActivityLogger.Log(username, "Success", $"{userType} logged in successfully.")

            MessageBox.Show($"Login successful! Welcome, {username}.",
                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Hide

            If userType = UserType_Admin Then
                Dim dashboard As New AdminDashboardForm
                dashboard.ShowDialog
            Else
                Dim dashboard As New UserDashboardForm
                dashboard.ShowDialog
            End If

            SessionManager.Clear
            Show
            btnLogin.Enabled = True
            txtUsername.Clear
            txtPassword.Clear
            txtUsername.Focus

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message,
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>Increments the failed-attempt count for a username and returns how many attempts remain (0 if now locked out).</summary>
    Private Function IncrementFailedAttempts(username As String) As Integer
        If Not _failedAttempts.ContainsKey(username) Then
            _failedAttempts(username) = 0
        End If
        _failedAttempts(username) += 1

        Dim remaining As Integer = Math.Max(MaxAttempts - _failedAttempts(username), 0)

        If _failedAttempts(username) >= MaxAttempts Then
            _lockedUsername = username
            _lockoutSecondsLeft = LockoutSeconds
            btnLogin.Enabled = False
            btnLogin.Text = $"Please wait ({_lockoutSecondsLeft}s)..."
            _lockoutTimer.Start()
        End If

        Return remaining
    End Function

    Private Function AttemptsMessage(baseMessage As String, remainingAttempts As Integer) As String
        If remainingAttempts <= 0 Then
            Return $"{baseMessage} Account locked. Please wait {LockoutSeconds} seconds."
        ElseIf remainingAttempts = 1 Then
            Return $"{baseMessage} 1 attempt left."
        Else
            Return $"{baseMessage} {remainingAttempts} attempts left."
        End If
    End Function

    Private Sub LockoutTimer_Tick(sender As Object, e As EventArgs)
        _lockoutSecondsLeft -= 1
        If _lockoutSecondsLeft <= 0 Then
            _lockoutTimer.Stop()
            _failedAttempts.Remove(_lockedUsername)
            _lockedUsername = ""
            btnLogin.Enabled = True
            btnLogin.Text = "LOGIN"
        Else
            btnLogin.Text = $"Please wait ({_lockoutSecondsLeft}s)..."
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

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Chr(0)
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit the application?",
                                      "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
