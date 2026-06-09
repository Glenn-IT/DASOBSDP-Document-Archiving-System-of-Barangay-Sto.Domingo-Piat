Public Class AdminUpdateAccountForm
    Inherits System.Windows.Forms.Form

    Public Property UserID   As Integer
    Public Property Username As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUpdateAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbUserType.Items.AddRange(New String() {UserType_Admin, UserType_User})
        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })

        Try
            Dim dt As DataTable = UserRepository.GetById(UserID)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtUsername.Text                 = row("Username").ToString()
                cmbUserType.SelectedItem         = row("UserType").ToString()
                cmbSecurityQuestion.SelectedItem = row("SecurityQuestion").ToString()
                txtSecurityAnswer.Text           = row("SecurityAnswer").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim newUsername      As String = InputHelper.SanitizeInput(txtUsername.Text)
        Dim securityAnswer   As String = InputHelper.SanitizeInput(txtSecurityAnswer.Text)
        Dim newPassword      As String = txtNewPassword.Text.Trim()
        Dim confirmPassword  As String = txtConfirmPassword.Text.Trim()
        Dim userType         As String = If(cmbUserType.SelectedItem IsNot Nothing,
                                            cmbUserType.SelectedItem.ToString(), UserType_User)
        Dim securityQuestion As String = If(cmbSecurityQuestion.SelectedItem IsNot Nothing,
                                            cmbSecurityQuestion.SelectedItem.ToString(), "")

        If newUsername = "" Then
            MessageBox.Show("Please fill in all required fields.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If newPassword <> "" AndAlso newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim hashedPassword As String = If(newPassword <> "",
                PasswordHelper.HashPassword(newPassword), Nothing)
            UserRepository.Update(UserID, newUsername, userType, securityQuestion,
                                  securityAnswer, hashedPassword)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin updated account: {Username}")
            MessageBox.Show("Account updated successfully!", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating account: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
