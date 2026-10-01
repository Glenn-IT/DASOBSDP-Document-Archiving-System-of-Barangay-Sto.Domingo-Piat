Public Class AdminArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Private _initialFilter As String = "All Documents"

    Public Sub New(Optional initialFilter As String = "All Documents")
        InitializeComponent()
        _initialFilter = initialFilter
    End Sub

    Private Sub AdminArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupApprovalMenu()
        SetupStatusFilter()
        LoadDocumentsFromDB()
    End Sub

    Private Sub SetupApprovalMenu()
        Dim cms         As New ContextMenuStrip()
        Dim approveItem As New ToolStripMenuItem("Approve Document")
        AddHandler approveItem.Click, AddressOf ApproveSelectedDocument
        cms.Items.Add(approveItem)
        dgvArchiveList.ContextMenuStrip = cms
    End Sub

    Private Sub SetupStatusFilter()
        cmbStatusFilter.Items.Clear()
        cmbStatusFilter.Items.Add("All Documents")
        cmbStatusFilter.Items.Add("For Review")
        cmbStatusFilter.Items.Add("Approved")

        If cmbStatusFilter.Items.Contains(_initialFilter) Then
            cmbStatusFilter.SelectedItem = _initialFilter
        Else
            cmbStatusFilter.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        Dim q As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadDocumentsFromDB(If(q = "", Nothing, q))
    End Sub

    Friend Sub LoadDocumentsFromDB(Optional searchQuery As String = Nothing)
        dgvArchiveList.Rows.Clear()
        Try
            Dim selectedStatus As String = If(cmbStatusFilter.SelectedItem IsNot Nothing, cmbStatusFilter.SelectedItem.ToString(), "All Documents")
            Dim dt As DataTable = DocumentRepository.GetAll(searchQuery, selectedStatus)
            For Each row As DataRow In dt.Rows
                Dim appStatus As String = row("ApprovalStatus").ToString()
                Dim idx As Integer = dgvArchiveList.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    row("UploadedBy").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    appStatus,
                    row("Status").ToString(),
                    "View"
                )
                dgvArchiveList.Rows(idx).Tag = CInt(row("DocumentID"))

                Dim cell As DataGridViewCell = dgvArchiveList.Rows(idx).Cells("colApprovalStatus")
                If appStatus = "For Review" Then
                    cell.Style.ForeColor = Color.FromArgb(190, 110, 0)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                ElseIf appStatus = "Approved" Then
                    cell.Style.ForeColor = Color.FromArgb(32, 120, 32)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                End If
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
                bannerBytes, pdfBytes, pdfFileName,
                documentId)
                If viewForm.ShowDialog() = DialogResult.OK Then
                    LoadDocumentsFromDB()
                End If
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
        Dim documentCode As String  = selectedRow.Cells("colDocID").Value.ToString()

        Dim frm As New AdminUpdateDocumentForm()
        frm.DocumentID   = documentId
        frm.DocumentCode = documentCode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDocumentsFromDB()
        End If
    End Sub

    Private Sub btnApproveDocument_Click(sender As Object, e As EventArgs) Handles btnApproveDocument.Click
        ApproveSelectedDocument(sender, e)
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to delete.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow  As DataGridViewRow = dgvArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)
        Dim documentCode As String  = selectedRow.Cells("colDocID").Value.ToString()

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
        Dim documentCode As String  = selectedRow.Cells("colDocID").Value.ToString()
        Dim currentApproval As String = selectedRow.Cells("colApprovalStatus").Value.ToString()

        If currentApproval = "Approved" Then
            MessageBox.Show($"Document {documentCode} is already approved.",
                            "Already Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            $"Are you sure you want to approve document '{documentCode}'?{Environment.NewLine}{Environment.NewLine}This will officially verify the document for the archive.",
            "Approve Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            DocumentRepository.Approve(documentId)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin approved document: {documentCode}")
            MessageBox.Show($"Document {documentCode} approved successfully.", "Approve Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDocumentsFromDB()
        Catch ex As Exception
            MessageBox.Show("Error approving document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
