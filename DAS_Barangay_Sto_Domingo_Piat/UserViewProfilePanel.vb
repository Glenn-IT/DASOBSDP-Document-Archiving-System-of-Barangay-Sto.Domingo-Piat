Public Class UserViewProfilePanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserViewProfilePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })

        ' Pre-fill with current user profile data
        txtUsername.Text       = "jdela"
        txtUserType.Text       = "User"
        cmbSecurityQuestion.SelectedIndex = 0
        txtSecurityAnswer.Text = "Santos"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNewPassword.Text.Trim() <> "" AndAlso txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "View Profile",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Profile updated successfully!", "View Profile",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        UserViewProfilePanel_Load(Nothing, EventArgs.Empty)
    End Sub

End Class
