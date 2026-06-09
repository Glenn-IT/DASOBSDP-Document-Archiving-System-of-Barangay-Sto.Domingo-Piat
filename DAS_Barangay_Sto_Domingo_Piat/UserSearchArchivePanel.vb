Public Class UserSearchArchivePanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserSearchArchivePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LayoutSearchBar()
        LoadDocumentsFromDB()
    End Sub

    Private Sub UserSearchArchivePanel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutSearchBar()
    End Sub

    Private Sub LayoutSearchBar()
        Dim margin As Integer = 16
        Dim btnW   As Integer = 90
        Dim iconW  As Integer = 36
        Dim barH   As Integer = 32
        Dim topOff As Integer = (pnlSearch.Height - barH) \ 2

        lblSearchIcon.SetBounds(margin, topOff, iconW, barH)
        btnSearch.SetBounds(pnlSearch.Width - margin - btnW, topOff, btnW, barH)
        txtSearchQuery.SetBounds(margin + iconW + 4, topOff,
                                 pnlSearch.Width - margin - btnW - 4 - iconW - margin - 4, barH)
    End Sub

    Private Sub LoadDocumentsFromDB(Optional searchQuery As String = Nothing)
        dgvSearchResults.Rows.Clear()
        Try
            Dim dt As DataTable = DocumentRepository.GetActive(searchQuery)
            For Each row As DataRow In dt.Rows
                dgvSearchResults.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    row("ApprovalStatus").ToString(),
                    row("Status").ToString()
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchQuery_TextChanged(sender As Object, e As EventArgs) Handles txtSearchQuery.TextChanged
        Dim query As String = InputHelper.SanitizeInput(txtSearchQuery.Text)
        LoadDocumentsFromDB(If(query = "", Nothing, query))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = InputHelper.SanitizeInput(txtSearchQuery.Text)
        LoadDocumentsFromDB(If(query = "", Nothing, query))
    End Sub

End Class
