Public Class AdminArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupApprovalMenu()
        LoadDocumentsFromDB()
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
                    row("Status").ToString(),
                    "View"
                )
                dgvArchiveList.Rows(idx).Tag = CInt(row("DocumentID"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvArchiveList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvArchiveList.CellContentClick

        If e.RowIndex < 0 OrElse e.ColumnIndex <> dgvArchiveList.Columns("colView").Index Then Return

        Dim gridRow As DataGridViewRow = dgvArchiveList.Rows(e.RowIndex)
        Dim documentId As Integer = CInt(gridRow.Tag)

        Try
            Dim dt As DataTable = DocumentRepository.GetByIdFull(documentId)
            If dt.Rows.Count = 0 Then Return

            Dim dr As DataRow = dt.Rows(0)
            Dim bannerBytes As Byte() = Nothing
            Dim pdfBytes    As Byte() = Nothing
            Dim pdfFileName As String = ""

            If Not IsDBNull(dr("BannerImage")) Then
                bannerBytes = CType(dr("BannerImage"), Byte())
            End If
            If Not IsDBNull(dr("PDFFile")) Then
                pdfBytes = CType(dr("PDFFile"), Byte())
            End If
            If Not IsDBNull(dr("PDFFileName")) Then
                pdfFileName = dr("PDFFileName").ToString()
            End If

            Using viewForm As New UserDocumentViewForm(
                dr("DocumentCode").ToString(),
                dr("Title").ToString(),
                dr("DocumentType").ToString(),
                If(IsDBNull(dr("Description")), "", dr("Description").ToString()),
                dr("UploadedBy").ToString(),
                Convert.ToDateTime(dr("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                dr("ApprovalStatus").ToString(),
                dr("Status").ToString(),
                bannerBytes, pdfBytes, pdfFileName)
                viewForm.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading document: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
