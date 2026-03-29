Public Class AdminLoginForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ready for demo
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim username As String = txtAdminUsername.Text.Trim()
        Dim password As String = txtAdminPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dashboard As New AdminDashboardForm()
        Me.Hide()
        dashboard.ShowDialog()
        Me.Show()
        txtAdminUsername.Clear()
        txtAdminPassword.Clear()
        txtAdminUsername.Focus()
    End Sub

    Private Sub btnAdminForgotPassword_Click(sender As Object, e As EventArgs) Handles btnAdminForgotPassword.Click
        Dim forgotPw As New AdminForgotPasswordForm()
        forgotPw.Show()
        Me.Hide()
    End Sub

End Class
