Public Class AdminDashboardPanel
    Inherits System.Windows.Forms.UserControl

    Public Event PendingReviewRequested()
    Public Event TotalDocumentsRequested()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminDashboardPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblGreeting.Text = $"Welcome, {SessionManager.Username}!"
        LoadStatsFromDB()
        WireCardEvents()
    End Sub

    Private Sub WireCardEvents()
        ' Setup click interactions on KPI cards
        pnlCardPending.Cursor = Cursors.Hand
        lblPendingTitle.Cursor = Cursors.Hand
        lblPendingCount.Cursor = Cursors.Hand
        lblPendingSub.Cursor = Cursors.Hand

        Dim onPendingClick As EventHandler = Sub(s, e) RaiseEvent PendingReviewRequested()
        AddHandler pnlCardPending.Click, onPendingClick
        AddHandler lblPendingTitle.Click, onPendingClick
        AddHandler lblPendingCount.Click, onPendingClick
        AddHandler lblPendingSub.Click, onPendingClick

        pnlCardTotal.Cursor = Cursors.Hand
        lblTotalTitle.Cursor = Cursors.Hand
        lblTotalCount.Cursor = Cursors.Hand
        lblTotalSub.Cursor = Cursors.Hand

        Dim onTotalClick As EventHandler = Sub(s, e) RaiseEvent TotalDocumentsRequested()
        AddHandler pnlCardTotal.Click, onTotalClick
        AddHandler lblTotalTitle.Click, onTotalClick
        AddHandler lblTotalCount.Click, onTotalClick
        AddHandler lblTotalSub.Click, onTotalClick

        ' Print Report card click interactions
        pnlCardPrint.Cursor = Cursors.Hand
        lblPrintTitle.Cursor = Cursors.Hand
        lblPrintIcon.Cursor = Cursors.Hand
        lblPrintSub.Cursor = Cursors.Hand

        Dim onPrintClick As EventHandler = Sub(s, e) ReportHelper.PrintDocumentArchiveReport()
        AddHandler pnlCardPrint.Click, onPrintClick
        AddHandler lblPrintTitle.Click, onPrintClick
        AddHandler lblPrintIcon.Click, onPrintClick
        AddHandler lblPrintSub.Click, onPrintClick
    End Sub

    Private Sub LoadStatsFromDB()
        Try
            lblTotalCount.Text   = DocumentRepository.CountAll().ToString()
            lblRecentCount.Text  = DocumentRepository.CountRecent().ToString()
            lblPendingCount.Text = DocumentRepository.CountPending().ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard stats: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        ReportHelper.PrintDocumentArchiveReport()
    End Sub

End Class
