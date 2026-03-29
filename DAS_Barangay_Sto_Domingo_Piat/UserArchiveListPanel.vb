Public Class UserArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
    End Sub

    Private Sub LoadPlaceholderData()
        dgvUserArchiveList.Rows.Clear()
        dgvUserArchiveList.Rows.Add("DOC-0001", "Barangay Budget Report 2024",        "2024-11-15 09:00", "Approved",    "Active")
        dgvUserArchiveList.Rows.Add("DOC-0002", "Health Program Summary",             "2024-12-01 14:30", "For Review",  "Active")
        dgvUserArchiveList.Rows.Add("DOC-0003", "Infrastructure Project Docs",        "2025-02-03 10:15", "Approved",    "Active")
        dgvUserArchiveList.Rows.Add("DOC-0004", "Solid Waste Management Plan",        "2025-01-20 08:45", "Archived",    "Archived")
        dgvUserArchiveList.Rows.Add("DOC-0005", "Livelihood Program 2025",            "2025-03-05 11:00", "For Review",  "Active")
        dgvUserArchiveList.Rows.Add("DOC-0006", "Barangay Assembly Minutes — Q1",     "2025-03-12 13:00", "Approved",    "Active")
        dgvUserArchiveList.Rows.Add("DOC-0007", "Disaster Risk Reduction Plan",       "2025-03-20 09:30", "For Review",  "Active")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = txtSearch.Text.Trim().ToLower()
        LoadPlaceholderData()
        If query = "" Then Return
        For i As Integer = dgvUserArchiveList.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dgvUserArchiveList.Rows(i)
            Dim match As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(query) Then
                    match = True
                    Exit For
                End If
            Next
            If Not match Then dgvUserArchiveList.Rows.RemoveAt(i)
        Next
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvUserArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to delete.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm As New UserDeleteDocumentForm()
        frm.ShowDialog()
    End Sub

End Class
