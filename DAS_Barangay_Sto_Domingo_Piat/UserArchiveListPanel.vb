Public Class UserArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMyDocuments()
    End Sub

    Friend Sub LoadMyDocuments(Optional searchQuery As String = Nothing)
        dgvUserArchiveList.Rows.Clear()
        Try
            Dim dt As DataTable = DocumentRepository.GetByUser(SessionManager.Username, searchQuery)
            For Each row As DataRow In dt.Rows
                Dim rowIdx As Integer = dgvUserArchiveList.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    row("ApprovalStatus").ToString(),
                    row("Status").ToString()
                )
                dgvUserArchiveList.Rows(rowIdx).Tag = CInt(row("DocumentID"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim query As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadMyDocuments(If(query = "", Nothing, query))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadMyDocuments(If(query = "", Nothing, query))
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvUserArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to delete.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow  As DataGridViewRow = dgvUserArchiveList.SelectedRows(0)
        Dim documentID   As Integer = CInt(selectedRow.Tag)
        Dim documentCode As String  = selectedRow.Cells(0).Value.ToString()

        Dim frm As New UserDeleteDocumentForm()
        frm.DocumentID   = documentID
        frm.DocumentCode = documentCode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadMyDocuments()
        End If
    End Sub

End Class
