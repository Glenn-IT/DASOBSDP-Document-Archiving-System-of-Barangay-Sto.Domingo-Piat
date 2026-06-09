Public Class AdminViewProfilePanel
    Inherits System.Windows.Forms.UserControl

    Private _isDirty As Boolean = False
    Public ReadOnly Property HasUnsavedChanges As Boolean
        Get
            Return _isDirty
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminViewProfilePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })
        txtUsername.ReadOnly = True
        txtUserType.ReadOnly = True

        AddHandler cmbSecurityQuestion.SelectedIndexChanged, Sub() _isDirty = True
        AddHandler txtSecurityAnswer.TextChanged,            Sub() _isDirty = True
        AddHandler txtNewPassword.TextChanged,               Sub() _isDirty = True
        AddHandler txtConfirmPassword.TextChanged,           Sub() _isDirty = True

        LoadProfileFromDB()
    End Sub

    Private Sub LoadProfileFromDB()
        Try
            Dim dt As DataTable = UserRepository.GetByUsername(SessionManager.Username)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtUsername.Text                 = SessionManager.Username
                txtUserType.Text                 = row("UserType").ToString()
                cmbSecurityQuestion.SelectedItem = row("SecurityQuestion").ToString()
                txtSecurityAnswer.Text           = row("SecurityAnswer").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        _isDirty = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim securityAnswer   As String = InputHelper.SanitizeInput(txtSecurityAnswer.Text)
        Dim securityQuestion As String = If(cmbSecurityQuestion.SelectedItem IsNot Nothing,
                                            cmbSecurityQuestion.SelectedItem.ToString(), "")
        Dim newPassword      As String = txtNewPassword.Text.Trim()
        Dim confirmPassword  As String = txtConfirmPassword.Text.Trim()

        If newPassword <> "" AndAlso newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "View Profile",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim hashedPassword As String = If(newPassword <> "",
                PasswordHelper.HashPassword(newPassword), Nothing)
            UserRepository.UpdateProfile(SessionManager.Username, securityQuestion,
                                         securityAnswer, hashedPassword)
            ActivityLogger.Log(SessionManager.Username, "Success",
                "Admin updated their profile.")
            MessageBox.Show("Profile updated successfully!", "View Profile",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProfileFromDB()
        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        LoadProfileFromDB()
    End Sub

End Class
