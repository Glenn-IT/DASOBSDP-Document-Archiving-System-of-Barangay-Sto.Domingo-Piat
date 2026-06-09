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
                Dim idx As Integer = dgvUsersList.Rows.Add(
                    row("UserCode").ToString(),
                    row("Username").ToString(),
                    row("UserType").ToString(),
                    row("Status").ToString()
                )
                dgvUsersList.Rows(idx).Tag = CInt(row("UserID"))
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

        Dim frm As New AdminDeleteUserForm()
        frm.UserID   = userId
        frm.Username = username
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsersFromDB()
        End If
    End Sub

End Class
