Public Class AdminDocumentTypeListPanel
    Inherits System.Windows.Forms.UserControl

    Public Event BackRequested As EventHandler

    Private ReadOnly _docType As String

    Public Sub New(docType As String)
        InitializeComponent()
        _docType = docType
        lblTitle.Text = docType
    End Sub

    Private Sub AdminDocumentTypeListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDocumentsFromDB()
    End Sub

    Private Sub LoadDocumentsFromDB()
        dgvTypeList.Rows.Clear()
        Try
            Dim dt As DataTable = DocumentRepository.GetByType(_docType)
            For Each row As DataRow In dt.Rows
                Dim idx As Integer = dgvTypeList.Rows.Add(
                    row("DocumentCode").ToString(),
                    row("Title").ToString(),
                    row("UploadedBy").ToString(),
                    Convert.ToDateTime(row("DateUploaded")).ToString("yyyy-MM-dd HH:mm"),
                    row("Status").ToString(),
                    "View"
                )
                dgvTypeList.Rows(idx).Tag = CInt(row("DocumentID"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvTypeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvTypeList.CellContentClick

        If e.RowIndex < 0 OrElse e.ColumnIndex <> dgvTypeList.Columns("colView").Index Then Return

        Dim gridRow As DataGridViewRow = dgvTypeList.Rows(e.RowIndex)
        Dim documentId As Integer = CInt(gridRow.Tag)

        Try
            Dim dt As DataTable = DocumentRepository.GetByIdFull(documentId)
            If dt.Rows.Count = 0 Then Return

            Dim dr As DataRow = dt.Rows(0)
            Dim bannerBytes As Byte() = Nothing
            Dim pdfBytes As Byte() = Nothing
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        RaiseEvent BackRequested(Me, EventArgs.Empty)
    End Sub

End Class
