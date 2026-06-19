Public Class UserDashboardForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserDashboardForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' GATE — remove when unlocking for v1.05
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnDashboard)
        lblPageTitle.Text = "Dashboard"
        Return
        ' END GATE
        LoadPanel(New UserDashboardPanel())
        HighlightButton(btnDashboard)
        lblPageTitle.Text = "Dashboard"
    End Sub

    Private Sub LoadPanel(panel As UserControl)
        If pnlMainContent.Controls.Count > 0 Then
            Dim current As UserViewProfilePanel =
                TryCast(pnlMainContent.Controls(0), UserViewProfilePanel)
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
        Dim sidebarButtons As Button() = {btnDashboard, btnUploadDocument, btnSearchArchive, btnViewProfile}
        For Each btn In sidebarButtons
            btn.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
            btn.ForeColor = System.Drawing.Color.FromArgb(242, 237, 194)
        Next
        active.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        active.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' GATE — remove when unlocking for v1.05
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnDashboard)
        lblPageTitle.Text = "Dashboard"
        Return
        ' END GATE
        LoadPanel(New UserDashboardPanel())
        HighlightButton(btnDashboard)
        lblPageTitle.Text = "Dashboard"
    End Sub

    Private Sub btnUploadDocument_Click(sender As Object, e As EventArgs) Handles btnUploadDocument.Click
        ' GATE — remove when unlocking for v1.06
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnUploadDocument)
        lblPageTitle.Text = "Upload Document"
        Return
        ' END GATE
        LoadPanel(New UserUploadDocumentPanel())
        HighlightButton(btnUploadDocument)
        lblPageTitle.Text = "Upload Document"
    End Sub

    Private Sub btnSearchArchive_Click(sender As Object, e As EventArgs) Handles btnSearchArchive.Click
        ' GATE — remove when unlocking for v1.07
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnSearchArchive)
        lblPageTitle.Text = "Search Archive"
        Return
        ' END GATE
        LoadPanel(New UserSearchArchivePanel())
        HighlightButton(btnSearchArchive)
        lblPageTitle.Text = "Search Archive"
    End Sub

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        ' GATE — remove when unlocking for v1.08
        LoadPanel(New UnderConstructionPanel())
        HighlightButton(btnViewProfile)
        lblPageTitle.Text = "View Profile"
        Return
        ' END GATE
        LoadPanel(New UserViewProfilePanel())
        HighlightButton(btnViewProfile)
        lblPageTitle.Text = "View Profile"
    End Sub

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
