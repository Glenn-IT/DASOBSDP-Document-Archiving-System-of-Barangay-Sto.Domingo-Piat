Public Class UserDashboardPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserDashboardPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblGreeting.Text = $"Welcome, {SessionManager.Username}!"
        LoadStatsFromDB()
    End Sub

    Private Sub LoadStatsFromDB()
        Try
            lblTotalCount.Text  = DocumentRepository.CountByUser(SessionManager.Username).ToString()
            lblRecentCount.Text = DocumentRepository.CountRecentByUser(SessionManager.Username).ToString()
            lblPendingCount.Text = DocumentRepository.CountPendingByUser(SessionManager.Username).ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard stats: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
