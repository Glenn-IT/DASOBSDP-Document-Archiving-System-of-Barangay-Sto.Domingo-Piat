Public Class AdminUpdateDocumentForm
    Inherits System.Windows.Forms.Form

    Public Property DocumentID   As Integer
    Public Property DocumentCode As String

    Private _selectedImagePath As String = ""
    Private _selectedPdfPath   As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUpdateDocumentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbStatus.Items.AddRange(DocumentTypes)
        txtUploadedBy.ReadOnly = True

        Try
            Dim dt As DataTable = DocumentRepository.GetByIdFull(DocumentID)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtDocumentID.Text    = row("DocumentCode").ToString()
                txtDocumentTitle.Text = row("Title").ToString()
                txtDescription.Text   = row("Description").ToString()
                txtUploadedBy.Text    = row("UploadedBy").ToString()
                dtpDateTime.Value     = Convert.ToDateTime(row("DateUploaded"))
                lblPDFFile.Text       = If(row("PDFFileName") Is DBNull.Value,
                                           "No file", row("PDFFileName").ToString())
                cmbStatus.SelectedItem = row("DocumentType").ToString()

                If Not IsDBNull(row("BannerImage")) Then
                    Dim bannerBytes As Byte() = CType(row("BannerImage"), Byte())
                    If bannerBytes.Length > 0 Then
                        Using ms As New System.IO.MemoryStream(bannerBytes)
                            Using loadedImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                picBanner.Image = New System.Drawing.Bitmap(loadedImage)
                            End Using
                        End Using
                        picBanner.SizeMode = PictureBoxSizeMode.Zoom
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Title  = "Select Image Banner"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
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
                _selectedPdfPath = ofd.FileName
                lblPDFFile.Text  = System.IO.Path.GetFileName(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim title        As String = InputHelper.SanitizeInput(txtDocumentTitle.Text)
        Dim description  As String = InputHelper.SanitizeInput(txtDescription.Text)
        Dim documentType As String = If(cmbStatus.SelectedItem IsNot Nothing,
                                        cmbStatus.SelectedItem.ToString(), "")

        If title = "" Then
            MessageBox.Show("Please enter a document title.", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If _selectedPdfPath = "" AndAlso lblPDFFile.Text = "No file" Then
            MessageBox.Show("Please upload a document file.", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DocumentRepository.Update(DocumentID, title, description, documentType,
                                      _selectedImagePath, _selectedPdfPath)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"Admin updated document: {DocumentCode}")
            MessageBox.Show("Document updated successfully!", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
