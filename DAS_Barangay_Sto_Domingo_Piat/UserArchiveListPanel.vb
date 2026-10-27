Public Class UserArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupDocTypeFilter()
        SetupDateFilter()
        LoadMyDocuments()
    End Sub

    Private Sub SetupDocTypeFilter()
        cmbDocTypeFilter.Items.Clear()
        cmbDocTypeFilter.Items.Add("All Document Types")
        cmbDocTypeFilter.Items.Add("Barangay Clearance")
        cmbDocTypeFilter.Items.Add("Barangay Certificate")
        cmbDocTypeFilter.Items.Add("Certificate of Indigency")
        cmbDocTypeFilter.Items.Add("Barangay Resolution")
        cmbDocTypeFilter.Items.Add("Barangay Ordinance")
        cmbDocTypeFilter.Items.Add("Business Permit")
        cmbDocTypeFilter.Items.Add("Blotter Report")
        cmbDocTypeFilter.Items.Add("Others")
        cmbDocTypeFilter.SelectedIndex = 0
    End Sub

    Private Sub SetupDateFilter()
        dtpDateFrom.Value = DateTime.Today.AddMonths(-1)
        dtpDateTo.Value = DateTime.Today
        chkFilterDate.Checked = False
        dtpDateFrom.Enabled = False
        dtpDateTo.Enabled = False
    End Sub

    Private Sub cmbDocTypeFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocTypeFilter.SelectedIndexChanged
        TriggerFilter()
    End Sub

    Private Sub chkFilterDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterDate.CheckedChanged
        dtpDateFrom.Enabled = chkFilterDate.Checked
        dtpDateTo.Enabled = chkFilterDate.Checked
        TriggerFilter()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        If chkFilterDate.Checked Then TriggerFilter()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        If chkFilterDate.Checked Then TriggerFilter()
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        txtSearch.Clear()
        cmbDocTypeFilter.SelectedIndex = 0
        chkFilterDate.Checked = False
        LoadMyDocuments()
    End Sub

    Private Sub TriggerFilter()
        Dim query As String = InputHelper.SanitizeInput(txtSearch.Text)
        LoadMyDocuments(If(query = "", Nothing, query))
    End Sub

    Friend Sub LoadMyDocuments(Optional searchQuery As String = Nothing)
        dgvUserArchiveList.Rows.Clear()
        Try
            Dim selectedDocType As String = If(cmbDocTypeFilter.SelectedItem IsNot Nothing, cmbDocTypeFilter.SelectedItem.ToString(), "All Document Types")
            Dim dateFrom As Nullable(Of DateTime) = Nothing
            Dim dateTo As Nullable(Of DateTime) = Nothing
            If chkFilterDate.Checked Then
                dateFrom = dtpDateFrom.Value.Date
                dateTo = dtpDateTo.Value.Date
            End If

            Dim dt As DataTable = DocumentRepository.GetByUser(SessionManager.Username, searchQuery, Nothing, selectedDocType, dateFrom, dateTo)
            For Each row As DataRow In dt.Rows
                Dim appStatus As String = row("ApprovalStatus").ToString()
                Dim rowIdx As Integer = dgvUserArchiveList.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    appStatus,
                    row("Status").ToString()
                )
                dgvUserArchiveList.Rows(rowIdx).Tag = CInt(row("DocumentID"))

                Dim cell As DataGridViewCell = dgvUserArchiveList.Rows(rowIdx).Cells("colRemarks")
                If appStatus = "For Review" Then
                    cell.Style.ForeColor = Color.FromArgb(190, 110, 0)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                ElseIf appStatus = "Approved" Then
                    cell.Style.ForeColor = Color.FromArgb(32, 120, 32)
                    cell.Style.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
                End If
            Next

            lblTotalDocs.Text = $"Total Documents: {dgvUserArchiveList.Rows.Count}"
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TriggerFilter()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TriggerFilter()
    End Sub

    Private Sub btnPrintDocument_Click(sender As Object, e As EventArgs) Handles btnPrintDocument.Click
        If dgvUserArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document from your archive list to print.", "Print Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim selectedRow  As DataGridViewRow = dgvUserArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)
        ReportHelper.PrintSingleDocumentReport(documentId)
    End Sub

    Private Sub btnViewDocument_Click(sender As Object, e As EventArgs) Handles btnViewDocument.Click
        ViewSelectedDocument()
    End Sub

    Private Sub dgvUserArchiveList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserArchiveList.CellDoubleClick
        If e.RowIndex >= 0 Then
            ViewSelectedDocument()
        End If
    End Sub

    Private Sub ViewSelectedDocument()
        If dgvUserArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to view.", "View Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow  As DataGridViewRow = dgvUserArchiveList.SelectedRows(0)
        Dim documentId   As Integer = CInt(selectedRow.Tag)

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
                viewForm.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading document details: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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