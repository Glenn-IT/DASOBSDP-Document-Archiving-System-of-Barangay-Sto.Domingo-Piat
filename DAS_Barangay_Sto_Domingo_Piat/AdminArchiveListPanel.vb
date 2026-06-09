Public Class AdminArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LayoutSearchBar()
        SetupApprovalMenu()
        LoadDocumentsFromDB()
    End Sub

    Private Sub AdminArchiveListPanel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutSearchBar()
    End Sub

    Private Sub LayoutSearchBar()
        Dim margin As Integer = 16
        Dim btnW   As Integer = 90
        Dim iconW  As Integer = 36
        Dim barH   As Integer = 32
        Dim topOff As Integer = (pnlSearch.Height - barH) \ 2

        btnSearch.SetBounds(pnlSearch.Width - margin - btnW, topOff, btnW, barH)
        txtSearch.SetBounds(margin + iconW + 4, topOff,
                            pnlSearch.Width - margin - btnW - 4 - iconW - margin - 4, barH)
    End Sub

    Private Sub SetupApprovalMenu()
        Dim cms         As New ContextMenuStrip()
        Dim approveItem As New ToolStripMenuItem("Approve Document")
        AddHandler approveItem.Click, AddressOf ApproveSelectedDocument
        cms.Items.Add(approveItem)
        dgvArchiveList.ContextMenuStrip = cms
    End Sub

    Friend Sub LoadDocumentsFromDB(Optional searchQuery As String = Nothing)
        dgvArchiveList.Rows.Clear()
        Try
            Dim dt As DataTable = DocumentRepository.GetAll(searchQuery)
            For Each row As DataRow In dt.Rows
                Dim idx As Integer = dgvArchiveList.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    row("UploadedBy").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    row("Status").ToString()
                )
                dgvArchiveList.Rows(idx).Tag = CInt(row("DocumentID"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim q As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadDocumentsFromDB(If(q = "", Nothing, q))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim q As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadDocumentsFromDB(If(q = "", Nothing, q))
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim frm As New AdminNewDocumentForm()
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDocumentsFromDB()
        End If
    End Sub

    Private Sub btnUpdateDocument_Click(sender As Object, e As EventArgs) Handles btnUpdateDocument.Click
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to update.", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow  As DataGridViewRow = dgvArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)
        Dim documentCode As String  = selectedRow.Cells(0).Value.ToString()

        Dim frm As New AdminUpdateDocumentForm()
        frm.DocumentID   = documentId
        frm.DocumentCode = documentCode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDocumentsFromDB()
        End If
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to delete.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow  As DataGridViewRow = dgvArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)
        Dim documentCode As String  = selectedRow.Cells(0).Value.ToString()

        Dim frm As New AdminDeleteDocumentForm()
        frm.DocumentID   = documentId
        frm.DocumentCode = documentCode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDocumentsFromDB()
        End If
    End Sub

    Private Sub ApproveSelectedDocument(sender As Object, e As EventArgs)
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to approve.", "Approve Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow  As DataGridViewRow = dgvArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)
        Dim documentCode As String  = selectedRow.Cells(0).Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show(
            $"Approve document {documentCode}?",
            "Approve Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            DocumentRepository.Approve(documentId)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin approved document: {documentCode}")
            MessageBox.Show("Document approved successfully.", "Approve Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDocumentsFromDB()
        Catch ex As Exception
            MessageBox.Show("Error approving document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
