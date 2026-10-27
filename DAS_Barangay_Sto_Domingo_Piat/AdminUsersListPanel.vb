Public Class AdminUsersListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUsersListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUsersFromDB()
    End Sub

    Friend Sub LoadUsersFromDB()
        dgvUsersList.Rows.Clear()
        Try
            Dim dt As DataTable = UserRepository.GetAll()
            For Each row As DataRow In dt.Rows
                Dim userStatus As String = row("Status").ToString()
                Dim idx As Integer = dgvUsersList.Rows.Add(
                    row("UserCode").ToString(),
                    row("Username").ToString(),
                    row("UserType").ToString(),
                    userStatus
                )
                dgvUsersList.Rows(idx).Tag = CInt(row("UserID"))

                Dim cell As DataGridViewCell = dgvUsersList.Rows(idx).Cells("colStatus")
                If userStatus = "Inactive" Then
                    cell.Style.ForeColor = Color.FromArgb(192, 57, 43)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                Else
                    cell.Style.ForeColor = Color.FromArgb(32, 120, 32)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New AdminAddAccountForm()
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsersFromDB()
        End If
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If dgvUsersList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow As DataGridViewRow = dgvUsersList.SelectedRows(0)
        Dim userId      As Integer = CInt(selectedRow.Tag)
        Dim username    As String  = selectedRow.Cells(1).Value.ToString()

        Dim frm As New AdminUpdateAccountForm()
        frm.UserID   = userId
        frm.Username = username
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsersFromDB()
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsersList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "Delete User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow As DataGridViewRow = dgvUsersList.SelectedRows(0)
        Dim userId      As Integer = CInt(selectedRow.Tag)
        Dim username    As String  = selectedRow.Cells(1).Value.ToString()

        If String.Equals(username, "admin", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("The main admin account ('admin') cannot be deleted.", "Action Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.Equals(username, SessionManager.Username, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("You cannot delete your currently logged-in account.", "Action Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New AdminDeleteUserForm()
        frm.UserID   = userId
        frm.Username = username
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsersFromDB()
        End If
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If dgvUsersList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to activate or deactivate.", "Account Status",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvUsersList.SelectedRows(0)
        Dim userId As Integer = CInt(selectedRow.Tag)
        Dim username As String = selectedRow.Cells(1).Value.ToString()
        Dim currentStatus As String = selectedRow.Cells(3).Value.ToString()

        If String.Equals(username, "admin", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("The main admin account ('admin') cannot be deactivated.", "Action Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.Equals(username, SessionManager.Username, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("You cannot deactivate your currently logged-in account.", "Action Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newStatus As String = If(currentStatus = "Active", "Inactive", "Active")
        Dim actionWord As String = If(newStatus = "Inactive", "deactivate", "activate")

        Dim confirm As DialogResult = MessageBox.Show(
            $"Are you sure you want to {actionWord} account '{username}'?{Environment.NewLine}{Environment.NewLine}" &
            If(newStatus = "Inactive", "The user will not be able to log in until reactivated.", "The user will regain system access."),
            $"{Char.ToUpper(actionWord(0))}{actionWord.Substring(1)} Account",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                UserRepository.UpdateStatus(userId, newStatus)
                ActivityLogger.Log(SessionManager.Username, "Success", $"Admin {actionWord}d user account: {username}")
                MessageBox.Show($"Account '{username}' has been {actionWord}d successfully.", "Status Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsersFromDB()
            Catch ex As Exception
                MessageBox.Show($"Error updating account status: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
