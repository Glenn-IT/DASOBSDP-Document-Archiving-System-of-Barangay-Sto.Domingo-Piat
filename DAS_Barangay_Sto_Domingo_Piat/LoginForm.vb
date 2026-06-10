Public Class LoginForm
    Inherits System.Windows.Forms.Form

    Private _failedAttempts As New Dictionary(Of String, Integer)
    Private Const MaxAttempts As Integer = 5
    Private _lockoutTimer As New System.Windows.Forms.Timer()
    Private _lockoutSecondsLeft As Integer = 0
    Private _lockedUsername As String = ""

    Public Sub New()
        InitializeComponent()
        _lockoutTimer.Interval = 1000
        AddHandler _lockoutTimer.Tick, AddressOf LockoutTimer_Tick
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = InputHelper.SanitizeInput(txtUsername.Text)
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _lockoutTimer.Enabled Then Return

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

            MessageBox.Show($"Login successful! Welcome, {username}.",
                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            _lockedUsername = username
            _lockoutSecondsLeft = 15
            btnLogin.Enabled = False
            btnLogin.Text = $"Please wait ({_lockoutSecondsLeft}s)..."
            _lockoutTimer.Start()
        End If
    End Sub

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

End Class
