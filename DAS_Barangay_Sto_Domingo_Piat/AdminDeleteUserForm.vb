Public Class AdminDeleteUserForm
    Inherits System.Windows.Forms.Form

    Public Property UserID   As Integer
    Public Property Username As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminDeleteUserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMessage.Text = $"Delete user account: {Username}?"
        lblSubMsg.Text  = "This action cannot be undone."
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            UserRepository.Delete(UserID)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin deleted account: {Username}")
            MessageBox.Show("User deleted successfully.", "Delete User",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
