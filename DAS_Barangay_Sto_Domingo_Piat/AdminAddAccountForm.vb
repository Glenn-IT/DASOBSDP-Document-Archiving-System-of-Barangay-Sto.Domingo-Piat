Public Class AdminAddAccountForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminAddAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbUserType.Items.AddRange(New String() {UserType_Admin, UserType_User})
        cmbUserType.SelectedIndex = 1

        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim username         As String = InputHelper.SanitizeInput(txtUsername.Text)
        Dim securityAnswer   As String = InputHelper.SanitizeInput(txtSecurityAnswer.Text)
        Dim newPassword      As String = txtNewPassword.Text.Trim()
        Dim confirmPassword  As String = txtConfirmPassword.Text.Trim()
        Dim userType         As String = If(cmbUserType.SelectedItem IsNot Nothing,
                                            cmbUserType.SelectedItem.ToString(), UserType_User)
        Dim securityQuestion As String = If(cmbSecurityQuestion.SelectedItem IsNot Nothing,
                                            cmbSecurityQuestion.SelectedItem.ToString(), "")

        If username = "" OrElse newPassword = "" Then
            MessageBox.Show("Please fill in all required fields.", "Add Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Add Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If UserRepository.CheckDuplicateUsername(username) Then
                MessageBox.Show($"Username '{username}' is already taken. Please choose a different username.",
                                "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim userCode       As String = UserRepository.GenerateCode()
            Dim hashedPassword As String = PasswordHelper.HashPassword(newPassword)
            UserRepository.Insert(userCode, username, hashedPassword, userType,
                                  securityQuestion, securityAnswer)

            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin created account: {username}")
            MessageBox.Show("Account added successfully!", "Add Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error creating account: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
