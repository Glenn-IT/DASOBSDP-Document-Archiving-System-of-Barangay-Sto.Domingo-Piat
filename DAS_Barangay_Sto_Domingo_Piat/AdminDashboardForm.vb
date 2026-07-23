Public Class AdminDashboardForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPanel(New AdminArchiveListPanel())
        HighlightButton(btnArchiveList)
        lblPageTitle.Text   = "Archive List"
        lblWelcomeUser.Text = $"Welcome, {SessionManager.Username}!"
    End Sub

    Private Sub LoadPanel(panel As UserControl)
        If pnlMainContent.Controls.Count > 0 Then
            Dim current As AdminViewProfilePanel =
                TryCast(pnlMainContent.Controls(0), AdminViewProfilePanel)
            If current IsNot Nothing AndAlso current.HasUnsavedChanges Then
                Dim answer As DialogResult = MessageBox.Show(
                    "You have unsaved profile changes. Discard and leave?",
                    "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If answer <> DialogResult.Yes Then Return
            End If
        End If
        pnlMainContent.Controls.Clear()
        panel.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(panel)
    End Sub

    Private Sub HighlightButton(active As Button)
        Dim sidebarButtons As Button() = {btnArchiveList, btnUsersList, btnActivityLogs, btnViewProfile, btnLogout}
        For Each btn In sidebarButtons
            btn.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
            btn.ForeColor = System.Drawing.Color.FromArgb(242, 237, 194)
        Next
        active.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        active.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnArchiveList_Click(sender As Object, e As EventArgs) Handles btnArchiveList.Click
        LoadPanel(New AdminArchiveListPanel())
        HighlightButton(btnArchiveList)
        lblPageTitle.Text = "Archive List"
    End Sub

    Private Sub btnUsersList_Click(sender As Object, e As EventArgs) Handles btnUsersList.Click
        ' GATE — remove when unlocking for vX.XX
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnUsersList)
        lblPageTitle.Text = "Users List"
        Return
        ' END GATE
        LoadPanel(New AdminUsersListPanel())
        HighlightButton(btnUsersList)
        lblPageTitle.Text = "Users List"
    End Sub

    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click
        ' GATE — remove when unlocking for vX.XX
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnActivityLogs)
        lblPageTitle.Text = "Activity Logs"
        Return
        ' END GATE
        LoadPanel(New AdminActivityLogsPanel())
        HighlightButton(btnActivityLogs)
        lblPageTitle.Text = "Activity Logs"
    End Sub

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        LoadPanel(New AdminViewProfilePanel())
        HighlightButton(btnViewProfile)
        lblPageTitle.Text = "View Profile"
    End Sub

    ' ?? E � Logout ?????????????????????????????????????????????????
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ActivityLogger.Log(SessionManager.Username, "Success", "User logged out.")
            SessionManager.Clear()
            Me.Close()
        End If
    End Sub

End Class
