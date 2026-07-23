Public Class AdminNewDocumentForm
    Inherits System.Windows.Forms.Form

    Private Const MaxImageBytes As Long = 5L * 1024 * 1024
    Private Const MaxPdfBytes   As Long = 50L * 1024 * 1024

    Private _selectedImagePath As String = ""
    Private _selectedPdfPath   As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminNewDocumentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbStatus.Items.AddRange(DocumentTypes)
        cmbStatus.SelectedIndex = 0
        txtDocumentID.Text     = "Auto-generated"
        dtpDateTime.Value      = Now
        txtUploadedBy.Text     = SessionManager.Username
        txtUploadedBy.ReadOnly = True
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim title        As String = InputHelper.SanitizeInput(txtDocumentTitle.Text)
        Dim description  As String = InputHelper.SanitizeInput(txtDescription.Text)
        Dim documentType As String = If(cmbStatus.SelectedItem IsNot Nothing,
                                        cmbStatus.SelectedItem.ToString(), "")

        If title = "" Then
            MessageBox.Show("Please enter a document title.", "New Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If documentType = "" Then
            MessageBox.Show("Please select a document type.", "New Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If _selectedPdfPath = "" Then
            MessageBox.Show("Please upload a document file.", "New Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bannerBytes As Byte() = If(_selectedImagePath <> "",
            System.IO.File.ReadAllBytes(_selectedImagePath), Nothing)
        Dim pdfBytes    As Byte() = Nothing
        Dim pdfFileName As String = ""
        If _selectedPdfPath <> "" Then
            pdfBytes    = System.IO.File.ReadAllBytes(_selectedPdfPath)
            pdfFileName = System.IO.Path.GetFileName(_selectedPdfPath)
        End If

        Try
            Dim docCode As String = DocumentRepository.GenerateCode()
            DocumentRepository.Insert(docCode, title, description, documentType,
                                      bannerBytes, pdfFileName, pdfBytes,
                                      SessionManager.Username, dtpDateTime.Value)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin added document: {title}")
            MessageBox.Show("Document added successfully!", "New Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
