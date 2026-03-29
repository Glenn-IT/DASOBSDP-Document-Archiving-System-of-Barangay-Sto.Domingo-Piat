Public Class UserDashboardForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserDashboardForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPanel(New UserArchiveListPanel())
        HighlightButton(btnArchiveList)
    End Sub

    Private Sub LoadPanel(panel As UserControl)
        pnlMainContent.Controls.Clear()
        panel.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(panel)
    End Sub

    Private Sub HighlightButton(active As Button)
        Dim sidebarButtons As Button() = {btnArchiveList, btnUploadDocument, btnSearchArchive, btnViewProfile}
        For Each btn In sidebarButtons
            btn.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
            btn.ForeColor = System.Drawing.Color.FromArgb(242, 237, 194)
        Next
        active.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        active.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnArchiveList_Click(sender As Object, e As EventArgs) Handles btnArchiveList.Click
        LoadPanel(New UserArchiveListPanel())
        HighlightButton(btnArchiveList)
        lblPageTitle.Text = "Archive List"
    End Sub

    Private Sub btnUploadDocument_Click(sender As Object, e As EventArgs) Handles btnUploadDocument.Click
        LoadPanel(New UserUploadDocumentPanel())
        HighlightButton(btnUploadDocument)
        lblPageTitle.Text = "Upload Document"
    End Sub

    Private Sub btnSearchArchive_Click(sender As Object, e As EventArgs) Handles btnSearchArchive.Click
        LoadPanel(New UserSearchArchivePanel())
        HighlightButton(btnSearchArchive)
        lblPageTitle.Text = "Search Archive"
    End Sub

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
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
            Me.Close()
        End If
    End Sub

End Class
