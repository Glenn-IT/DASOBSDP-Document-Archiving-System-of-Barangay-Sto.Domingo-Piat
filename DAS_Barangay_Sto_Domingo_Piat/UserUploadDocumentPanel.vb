Public Class UserUploadDocumentPanel
    Inherits System.Windows.Forms.UserControl

    Private Const MaxImageBytes As Long = 5L * 1024 * 1024
    Private Const MaxPdfBytes   As Long = 50L * 1024 * 1024

    Private _selectedImagePath As String = ""
    Private _selectedPdfPath   As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserUploadDocumentPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbDocumentType.Items.AddRange(New String() {
            "Ordinance", "Resolution", "Budget Report",
            "Health Report", "Infrastructure", "Livelihood", "Others"
        })
        cmbDocumentType.SelectedIndex = 0
        cmbStatus.Items.AddRange(New String() {Status_Active, Approval_Archived})
        cmbStatus.SelectedIndex = 0

        txtUploadedBy.Text     = SessionManager.Username
        txtUploadedBy.ReadOnly = True
        dtpDateTime.Value      = Now
        GenerateDocumentCode()
    End Sub

    Private Sub GenerateDocumentCode()
        Try
            txtDocumentID.Text = DocumentRepository.GenerateCode()
        Catch
            txtDocumentID.Text = "DOC-0001"
        End Try
        txtDocumentID.ReadOnly = True
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Title  = "Select Image Banner"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim info As New System.IO.FileInfo(ofd.FileName)
                If info.Length > MaxImageBytes Then
                    MessageBox.Show("Image file exceeds the 5 MB limit. Please choose a smaller file.",
                                    "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                _selectedImagePath = ofd.FileName
                picBanner.Image    = System.Drawing.Image.FromFile(ofd.FileName)
                picBanner.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    Private Sub btnUploadPDF_Click(sender As Object, e As EventArgs) Handles btnUploadPDF.Click
        Using ofd As New OpenFileDialog()
            ofd.Title  = "Select PDF Document"
            ofd.Filter = "PDF Files|*.pdf"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim info As New System.IO.FileInfo(ofd.FileName)
                If info.Length > MaxPdfBytes Then
                    MessageBox.Show("PDF file exceeds the 50 MB limit. Please choose a smaller file.",
                                    "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                _selectedPdfPath = ofd.FileName
                lblPDFFile.Text  = System.IO.Path.GetFileName(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim title        As String = InputHelper.SanitizeInput(txtDocumentTitle.Text)
        Dim description  As String = InputHelper.SanitizeInput(txtDescription.Text)
        Dim documentCode As String = txtDocumentID.Text.Trim()
        Dim documentType As String = If(cmbDocumentType.SelectedItem IsNot Nothing,
                                        cmbDocumentType.SelectedItem.ToString(), "")

        If title = "" Then
            MessageBox.Show("Document title is required.", "Upload Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bannerBytes As Byte() = Nothing
        Dim pdfBytes    As Byte() = Nothing
        Dim pdfFileName As String = ""

        If _selectedImagePath <> "" Then
            bannerBytes = System.IO.File.ReadAllBytes(_selectedImagePath)
        End If
        If _selectedPdfPath <> "" Then
            pdfBytes    = System.IO.File.ReadAllBytes(_selectedPdfPath)
            pdfFileName = System.IO.Path.GetFileName(_selectedPdfPath)
        End If

        Try
            DocumentRepository.Insert(documentCode, title, description, documentType,
                                      bannerBytes, pdfFileName, pdfBytes,
                                      SessionManager.Username, dtpDateTime.Value)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"User uploaded document: {title}")
            MessageBox.Show("Document uploaded successfully!", "Upload Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetForm()
        Catch ex As Exception
            MessageBox.Show("Error uploading document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtDocumentTitle.Clear()
        txtDescription.Clear()
        picBanner.Image    = Nothing
        lblPDFFile.Text    = "No file selected"
        _selectedImagePath = ""
        _selectedPdfPath   = ""
        cmbDocumentType.SelectedIndex = 0
        cmbStatus.SelectedIndex       = 0
        dtpDateTime.Value  = Now
        GenerateDocumentCode()
    End Sub

End Class
